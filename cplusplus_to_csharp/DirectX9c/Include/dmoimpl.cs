// ------------------------------------------------------------------------------
// File: DMOImpl.h
// 
// Desc: Classes to implement a DMO.
// 
// Copyright (c) 2000-2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------



#if DEBUG
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <crtdbg.h>
#endif

//  Class to implement a DMO
// 
// 
//       Assumes the number of input and output streams is fixed
//       (these are template parameters)
// 
//       Provides following services:
// 
//          Basic parameter checking and locking
//          Fully implements :
//                 GetStreamCount
//                 SetInputType
//                 SetOutputType
//                 GetCurrentInputType
//                 GetCurrentOutputType
// 
//          Checks if all types are set before streaming
//          Automatically calls AllocateStreamingResources before streaming
//              if it's not been called already
//          Prevents streaming until the types on all non-optional streams
//              have been set
// 
// 
//  Derived class implements the following methods :
// 
/*
   HRESULT InternalGetInputStreamInfo(DWORD dwInputStreamIndex, DWORD *pdwFlags);
   HRESULT InternalGetOutputStreamInfo(DWORD dwOutputStreamIndex, DWORD *pdwFlags);
   HRESULT InternalCheckInputType(DWORD dwInputStreamIndex, const DMO_MEDIA_TYPE *pmt);
   HRESULT InternalCheckOutputType(DWORD dwOutputStreamIndex, const DMO_MEDIA_TYPE *pmt);
   HRESULT InternalGetInputType(DWORD dwInputStreamIndex, DWORD dwTypeIndex,
                            DMO_MEDIA_TYPE *pmt);
   HRESULT InternalGetOutputType(DWORD dwOutputStreamIndex, DWORD dwTypeIndex,
                            DMO_MEDIA_TYPE *pmt);
   HRESULT InternalGetInputSizeInfo(DWORD dwInputStreamIndex, DWORD *pcbSize,
                            DWORD *pcbMaxLookahead, DWORD *pcbAlignment);
   HRESULT InternalGetOutputSizeInfo(DWORD dwOutputStreamIndex, DWORD *pcbSize,
                             DWORD *pcbAlignment);
   HRESULT InternalGetInputMaxLatency(DWORD dwInputStreamIndex, REFERENCE_TIME *prtMaxLatency);
   HRESULT InternalSetInputMaxLatency(DWORD dwInputStreamIndex, REFERENCE_TIME rtMaxLatency);
   HRESULT InternalFlush();
   HRESULT InternalDiscontinuity(DWORD dwInputStreamIndex);
   HRESULT InternalAllocateStreamingResources();
   HRESULT InternalFreeStreamingResources();
   HRESULT InternalProcessInput(DWORD dwInputStreamIndex, IMediaBuffer *pBuffer,
                               DWORD dwFlags, REFERENCE_TIME rtTimestamp,
                               REFERENCE_TIME rtTimelength);
   HRESULT InternalProcessOutput(DWORD dwFlags, DWORD cOutputBufferCount,
                               DMO_OUTPUT_DATA_BUFFER *pOutputBuffers,
                           DWORD *pdwStatus);
   HRESULT InternalAcceptingInput(DWORD dwInputStreamIndex);
   void Lock();
   void Unlock();

   Notes:
       The derived class is meant to do most work to initialize streaming
       in AllocateStreamingResources rather than when types are set.

       This centralizes the work to one
       clear place based on the types set for all streams.

       The derived class implements locking.

       The derived class implements the IUnknown methods

   Usage example (1 input and 1 output) :
   class CMyDMO : public IMediaObjectImpl<CMyDmo, 1, 1>,
                  ...
*/


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERNAL_CALL(_T_, _X_) static_cast<_T_ *>(this)->Internal##_X_

// C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
// ORIGINAL LINE: template <class _DERIVED_, int NUMBEROFINPUTS, int NUMBEROFOUTPUTS>
public class IMediaObjectImpl <_DERIVED_, int NUMBEROFINPUTS, int NUMBEROFOUTPUTS> : IMediaObject, System.IDisposable
{
    // Member variables
// C++ TO C# CONVERTER NOTE: Classes must be named in C#, so the following class has been named by the converter:
    private class AnonymousClass
    {
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
        public uint fTypeSet:1;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
        public uint fIncomplete:1;
        public DMO_MEDIA_TYPE CurrentMediaType = new DMO_MEDIA_TYPE();
    }
    private AnonymousClass[] m_InputInfo = Arrays.InitializeWithDefaultInstances<AnonymousClass>(NUMBEROFINPUTS);
    private AnonymousClass[] m_OutputInfo = Arrays.InitializeWithDefaultInstances<AnonymousClass>(NUMBEROFOUTPUTS);

    private bool m_fTypesSet;
    private bool m_fFlushed;
    private bool m_fResourcesAllocated;


    //  Helpers
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool InputTypeSet(uint ulInputStreamIndex) const
    protected bool InputTypeSet(uint ulInputStreamIndex)
    {
        _ASSERTE(ulInputStreamIndex < NUMBEROFINPUTS);
        return 0 != m_InputInfo[ulInputStreamIndex].fTypeSet;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool OutputTypeSet(uint ulOutputStreamIndex) const
    protected bool OutputTypeSet(uint ulOutputStreamIndex)
    {
        _ASSERTE(ulOutputStreamIndex < NUMBEROFOUTPUTS);
        return 0 != m_OutputInfo[ulOutputStreamIndex].fTypeSet;
    }
    protected DMO_MEDIA_TYPE InputType(uint ulInputStreamIndex)
    {
        if (!InputTypeSet(ulInputStreamIndex))
        {
            return null;
        }
        return new DMO_MEDIA_TYPE(m_InputInfo[ulInputStreamIndex].CurrentMediaType);
    }
    protected DMO_MEDIA_TYPE OutputType(uint ulOutputStreamIndex)
    {
        if (!OutputTypeSet(ulOutputStreamIndex))
        {
            return null;
        }
        return new DMO_MEDIA_TYPE(m_OutputInfo[ulOutputStreamIndex].CurrentMediaType);
    }


    protected class LockIt : System.IDisposable
    {
        public LockIt(_DERIVED_ p)
        {
            this.m_p = p;
            ((_DERIVED_)m_p).Lock();
        }
        public void Dispose()
        {
            ((_DERIVED_)m_p).Unlock();
        }
        public readonly _DERIVED_ m_p;
    }

    protected bool CheckTypesSet()
    {
        m_fTypesSet = false;
        uint dw;
        for (dw = 0; dw < NUMBEROFINPUTS; dw++)
        {
            if (!InputTypeSet(dw))
            {
                return false;
            }
        }
        for (dw = 0; dw < NUMBEROFOUTPUTS; dw++)
        {
            if (!OutputTypeSet(dw))
            {
                //  Check if it's optional
                uint dwFlags;
#if DEBUG
                dwFlags = 0xFFFFFFFF;
#endif
                ((_DERIVED_)this).InternalGetOutputStreamInfo(dw, dwFlags);
                _ASSERTE(0 == (dwFlags & ~(DMO_OUTPUT_STREAMF_WHOLE_SAMPLES | DMO_OUTPUT_STREAMF_SINGLE_SAMPLE_PER_BUFFER | DMO_OUTPUT_STREAMF_FIXED_SAMPLE_SIZE | DMO_OUTPUT_STREAMF_DISCARDABLE | DMO_OUTPUT_STREAMF_OPTIONAL)));
                if ((dwFlags & DMO_OUTPUT_STREAMF_OPTIONAL) == 0)
                {
                    return false;
                }
            }
        }
        m_fTypesSet = true;
        return true;
    }


    protected IMediaObjectImpl()
    {
        this.m_fTypesSet = false;
        this.m_fFlushed = true;
        this.m_fResourcesAllocated = false;
        ZeroMemory(m_InputInfo, sizeof(IMediaObjectImpl.AnonymousClass));
        ZeroMemory(m_OutputInfo, sizeof(IMediaObjectImpl.AnonymousClass));
    }

    public virtual void Dispose()
    {
        uint dwCurrentType;

        for (dwCurrentType = 0; dwCurrentType < NUMBEROFINPUTS; dwCurrentType++)
        {
            if (InputTypeSet(dwCurrentType))
            {
                MoFreeMediaType(m_InputInfo[dwCurrentType].CurrentMediaType);
            }
        }

        for (dwCurrentType = 0; dwCurrentType < NUMBEROFOUTPUTS; dwCurrentType++)
        {
            if (OutputTypeSet(dwCurrentType))
            {
                MoFreeMediaType(m_OutputInfo[dwCurrentType].CurrentMediaType);
            }
        }
    }


    // IMediaObject methods


    // 
    // IMediaObject methods
    // 
    protected STDMETHODIMP GetStreamCount(ref uint pulNumberOfInputStreams, ref uint pulNumberOfOutputStreams)
    {
        LockIt lck = new LockIt((_DERIVED_)this);
        if (pulNumberOfInputStreams == null || pulNumberOfOutputStreams == null)
        {
            return E_POINTER;
        }
        pulNumberOfInputStreams = NUMBEROFINPUTS;
        pulNumberOfOutputStreams = NUMBEROFOUTPUTS;
        return S_OK;
    }

    protected STDMETHODIMP GetInputStreamInfo(uint ulStreamIndex, ref uint pdwFlags)
    {
        LockIt lck = new LockIt((_DERIVED_)this);
        if (ulStreamIndex >= NUMBEROFINPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }
        if (pdwFlags == null)
        {
            return E_POINTER;
        }
        int hr = ((_DERIVED_)this).InternalGetInputStreamInfo(ulStreamIndex, pdwFlags);
        _ASSERTE(0 == (pdwFlags & ~(DMO_INPUT_STREAMF_WHOLE_SAMPLES | DMO_INPUT_STREAMF_SINGLE_SAMPLE_PER_BUFFER | DMO_INPUT_STREAMF_FIXED_SAMPLE_SIZE | DMO_INPUT_STREAMF_HOLDS_BUFFERS)));
        return hr;
    }

    protected STDMETHODIMP GetOutputStreamInfo(uint ulStreamIndex, ref uint pdwFlags)
    {
        LockIt lck = new LockIt((_DERIVED_)this);
        if (ulStreamIndex >= NUMBEROFOUTPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }
        if (pdwFlags == null)
        {
            return E_POINTER;
        }
        int hr = ((_DERIVED_)this).InternalGetOutputStreamInfo(ulStreamIndex, pdwFlags);
        _ASSERTE(0 == (pdwFlags & ~(DMO_OUTPUT_STREAMF_WHOLE_SAMPLES | DMO_OUTPUT_STREAMF_SINGLE_SAMPLE_PER_BUFFER | DMO_OUTPUT_STREAMF_FIXED_SAMPLE_SIZE | DMO_OUTPUT_STREAMF_DISCARDABLE | DMO_OUTPUT_STREAMF_OPTIONAL)));
        return hr;
    }

    protected STDMETHODIMP GetInputType(uint ulStreamIndex, uint ulTypeIndex, DMO_MEDIA_TYPE pmt)
    {
        if (ulStreamIndex >= NUMBEROFINPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }
        LockIt lck = new LockIt((_DERIVED_)this);
        return ((_DERIVED_)this).InternalGetInputType(ulStreamIndex, ulTypeIndex, pmt);
    }

    protected STDMETHODIMP GetOutputType(uint ulStreamIndex, uint ulTypeIndex, DMO_MEDIA_TYPE pmt)
    {
        if (ulStreamIndex >= NUMBEROFOUTPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }
        LockIt lck = new LockIt((_DERIVED_)this);
        return ((_DERIVED_)this).InternalGetOutputType(ulStreamIndex, ulTypeIndex, pmt);
    }

    protected STDMETHODIMP GetInputCurrentType(uint ulStreamIndex, DMO_MEDIA_TYPE pmt)
    {
        if (ulStreamIndex >= NUMBEROFINPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }
        if (null == pmt)
        {
            return E_POINTER;
        }
        LockIt lck = new LockIt((_DERIVED_)this);
        if (InputTypeSet(ulStreamIndex))
        {
            return MoCopyMediaType(pmt, m_InputInfo[ulStreamIndex].CurrentMediaType);
        }
        else
        {
           return DMO_E_TYPE_NOT_SET;
        }
    }

    protected STDMETHODIMP GetOutputCurrentType(uint ulStreamIndex, DMO_MEDIA_TYPE pmt)
    {
        if (ulStreamIndex >= NUMBEROFOUTPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }
        if (null == pmt)
        {
            return E_POINTER;
        }
        LockIt lck = new LockIt((_DERIVED_)this);
        if (OutputTypeSet(ulStreamIndex))
        {
            return MoCopyMediaType(pmt, m_OutputInfo[ulStreamIndex].CurrentMediaType);
        }
        else
        {
           return DMO_E_TYPE_NOT_SET;
        }
    }

    protected STDMETHODIMP GetInputSizeInfo(uint ulStreamIndex, ref uint pulSize, ref uint pcbMaxLookahead, ref uint pulAlignment)
    {
        if (ulStreamIndex >= NUMBEROFINPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }
        if (null == pulSize || null == pulAlignment || null == pcbMaxLookahead)
        {
            return E_POINTER;
        }
        LockIt lck = new LockIt((_DERIVED_)this);
        if (!InputTypeSet(ulStreamIndex))
        {
           return DMO_E_TYPE_NOT_SET;
        }
        return ((_DERIVED_)this).InternalGetInputSizeInfo(ulStreamIndex, pulSize, pcbMaxLookahead, pulAlignment);
    }

    protected STDMETHODIMP GetOutputSizeInfo(uint ulStreamIndex, ref uint pulSize, ref uint pulAlignment)
    {
        if (ulStreamIndex >= NUMBEROFOUTPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }
        if (null == pulSize || null == pulAlignment)
        {
            return E_POINTER;
        }
        LockIt lck = new LockIt((_DERIVED_)this);
        if (!m_fTypesSet || !OutputTypeSet(ulStreamIndex))
        {
           return DMO_E_TYPE_NOT_SET;
        }
        return ((_DERIVED_)this).InternalGetOutputSizeInfo(ulStreamIndex, pulSize, pulAlignment);
    }

    protected STDMETHODIMP SetInputType(uint ulStreamIndex, DMO_MEDIA_TYPE pmt, uint dwFlags)
    {
        if (ulStreamIndex >= NUMBEROFINPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }
        if ((dwFlags & ~(DMO_SET_TYPEF_CLEAR | DMO_SET_TYPEF_TEST_ONLY)) != 0)
        {
            return E_INVALIDARG;
        }

        LockIt lck = new LockIt((_DERIVED_)this);

        if ((dwFlags & DMO_SET_TYPEF_CLEAR) != 0)
        {
            MoFreeMediaType(m_InputInfo[ulStreamIndex].CurrentMediaType);
            m_InputInfo[ulStreamIndex].fTypeSet = false;
            if (!CheckTypesSet())
            {
                Flush();
                FreeStreamingResources();
            }
            return NOERROR;
        }
        if (null == pmt)
        {
            return E_POINTER;
        }
        int hr = ((_DERIVED_)this).InternalCheckInputType(ulStreamIndex, pmt);
        if (FAILED(hr))
        {
           return hr;
        }

        if ((dwFlags & DMO_SET_TYPEF_TEST_ONLY) != 0)
        {
           return NOERROR;
        }


        // actually set the type
        DMO_MEDIA_TYPE mtTemp = new DMO_MEDIA_TYPE();
        if (S_OK == MoCopyMediaType(mtTemp, pmt))
        {
            // Free any previous mediatype
            if (InputTypeSet(ulStreamIndex))
            {
                MoFreeMediaType(m_InputInfo[ulStreamIndex].CurrentMediaType);
            }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: m_InputInfo[ulStreamIndex].CurrentMediaType = mtTemp;
            m_InputInfo[ulStreamIndex].CurrentMediaType.CopyFrom(mtTemp);
            m_InputInfo[ulStreamIndex].fTypeSet = true;
            CheckTypesSet();
        }
        else
        {
            return E_OUTOFMEMORY;
        }

        return NOERROR;
    }

    protected STDMETHODIMP SetOutputType(uint ulStreamIndex, DMO_MEDIA_TYPE pmt, uint dwFlags)
    {
        if (ulStreamIndex >= NUMBEROFOUTPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }
        if ((dwFlags & ~(DMO_SET_TYPEF_CLEAR | DMO_SET_TYPEF_TEST_ONLY)) != 0)
        {
            return E_INVALIDARG;
        }

        LockIt lck = new LockIt((_DERIVED_)this);

        if ((dwFlags & DMO_SET_TYPEF_CLEAR) != 0)
        {
            MoFreeMediaType(m_OutputInfo[ulStreamIndex].CurrentMediaType);
            m_OutputInfo[ulStreamIndex].fTypeSet = false;
            if (!CheckTypesSet())
            {
                Flush();
                FreeStreamingResources();
            }
            return NOERROR;
        }
        if (null == pmt)
        {
            return E_POINTER;
        }
        int hr = ((_DERIVED_)this).InternalCheckOutputType(ulStreamIndex, pmt);
        if (FAILED(hr))
        {
           return hr;
        }

        if ((dwFlags & DMO_SET_TYPEF_TEST_ONLY) != 0)
        {
           return NOERROR;
        }


        // actually set the type
        DMO_MEDIA_TYPE mtTemp = new DMO_MEDIA_TYPE();
        if (S_OK == MoCopyMediaType(mtTemp, pmt))
        {
            // Free any previous mediatype
            if (OutputTypeSet(ulStreamIndex))
            {
                MoFreeMediaType(m_OutputInfo[ulStreamIndex].CurrentMediaType);
            }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: m_OutputInfo[ulStreamIndex].CurrentMediaType = mtTemp;
            m_OutputInfo[ulStreamIndex].CurrentMediaType.CopyFrom(mtTemp);
            m_OutputInfo[ulStreamIndex].fTypeSet = true;
            CheckTypesSet();
        }
        else
        {
            return E_OUTOFMEMORY;
        }

        return NOERROR;
    }

    protected STDMETHODIMP GetInputStatus(uint ulStreamIndex, ref uint pdwStatus)
    {
        if (ulStreamIndex >= NUMBEROFINPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }
        if (null == pdwStatus)
        {
            return E_POINTER;
        }
        pdwStatus = null;

        LockIt lck = new LockIt((_DERIVED_)this);

        if (!m_fTypesSet)
        {
            return DMO_E_TYPE_NOT_SET;
        }

        if ((_DERIVED_)this.InternalAcceptingInput(ulStreamIndex) == S_OK)
        {
           pdwStatus |= DMO_INPUT_STATUSF_ACCEPT_DATA;
        }
        return NOERROR;
    }

    protected STDMETHODIMP GetInputMaxLatency(uint ulStreamIndex, REFERENCE_TIME prtLatency)
    {

        if (prtLatency == null)
        {
            return E_POINTER;
        }
        if (ulStreamIndex >= NUMBEROFINPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }

        LockIt lck = new LockIt((_DERIVED_)this);

        return ((_DERIVED_)this).InternalGetInputMaxLatency(ulStreamIndex, prtLatency);
    }

    protected STDMETHODIMP SetInputMaxLatency(uint ulStreamIndex, REFERENCE_TIME rtLatency)
    {
        if (ulStreamIndex >= NUMBEROFINPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }

        LockIt lck = new LockIt((_DERIVED_)this);

        return ((_DERIVED_)this).InternalSetInputMaxLatency(ulStreamIndex, rtLatency);
    }

    protected STDMETHODIMP Discontinuity(uint ulStreamIndex)
    {
        if (ulStreamIndex >= NUMBEROFINPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }

        LockIt lck = new LockIt((_DERIVED_)this);

        if (!m_fTypesSet)
        {
            return DMO_E_TYPE_NOT_SET;
        }

        if (S_OK != ((_DERIVED_)this).InternalAcceptingInput(ulStreamIndex))
        {
            return DMO_E_NOTACCEPTING;
        }

        return ((_DERIVED_)this).InternalDiscontinuity(ulStreamIndex);
    }

    protected STDMETHODIMP Flush()
    {
        LockIt lck = new LockIt((_DERIVED_)this);

        if (!m_fTypesSet)
        {
            return S_OK;
        }
        if (m_fFlushed)
        {
            return S_OK;
        }
        int hr = ((_DERIVED_)this).InternalFlush();
        m_fFlushed = true;
        return hr;
    }

    protected STDMETHODIMP AllocateStreamingResources()
    {
        LockIt lck = new LockIt((_DERIVED_)this);
        if (!m_fTypesSet)
        {
            return DMO_E_TYPE_NOT_SET;
        }
        if (m_fResourcesAllocated)
        {
            return S_OK;
        }
        int hr = ((_DERIVED_)this).InternalAllocateStreamingResources();
        if (SUCCEEDED(hr))
        {
            m_fResourcesAllocated = true;
        }
        return hr;
    }

    protected STDMETHODIMP FreeStreamingResources()
    {
        LockIt lck = new LockIt((_DERIVED_)this);
        if (m_fResourcesAllocated)
        {
            m_fResourcesAllocated = false;
            ((_DERIVED_)this).InternalFlush();
            return ((_DERIVED_)this).InternalFreeStreamingResources();
        }
        return S_OK;
    }

    // 
    // Processing methods - public entry points
    // 
    protected STDMETHODIMP ProcessInput(uint ulStreamIndex, IMediaBuffer pBuffer, uint dwFlags, REFERENCE_TIME rtTimestamp, REFERENCE_TIME rtTimelength)
    {
        if (pBuffer == null)
        {
            return E_POINTER;
        }
        if (ulStreamIndex >= NUMBEROFINPUTS)
        {
            return DMO_E_INVALIDSTREAMINDEX;
        }
        if ((dwFlags & ~(DMO_INPUT_DATA_BUFFERF_SYNCPOINT | DMO_INPUT_DATA_BUFFERF_TIME | DMO_INPUT_DATA_BUFFERF_TIMELENGTH)) != 0)
        {
            return E_INVALIDARG;
        }

        LockIt lck = new LockIt((_DERIVED_)this);

        //  Make sure all streams have media types set and resources are allocated
        int hr = AllocateStreamingResources();
        if (FAILED(hr))
        {
            return hr;
        }
        if ((_DERIVED_)this.InternalAcceptingInput(ulStreamIndex) != S_OK)
        {
            return DMO_E_NOTACCEPTING;
        }

        m_fFlushed = false;

        return ((_DERIVED_)this).InternalProcessInput(ulStreamIndex, pBuffer, dwFlags, rtTimestamp, rtTimelength);
    }

    protected STDMETHODIMP ProcessOutput(uint dwFlags, uint ulOutputBufferCount, DMO_OUTPUT_DATA_BUFFER[] pOutputBuffers, ref uint pdwStatus)
    {
        if (pdwStatus == null)
        {
            return E_POINTER;
        }


        if (ulOutputBufferCount != NUMBEROFOUTPUTS || (dwFlags & ~DMO_PROCESS_OUTPUT_DISCARD_WHEN_NO_BUFFER) != 0)
        {
           return E_INVALIDARG;
        }

        if (NUMBEROFOUTPUTS != 0 && pOutputBuffers == null)
        {
            return E_POINTER;
        }

        pdwStatus = null;

        LockIt lck = new LockIt((_DERIVED_)this);

        int hr = AllocateStreamingResources();
        if (FAILED(hr))
        {
            return hr;
        }

        for (uint dw = 0; dw < NUMBEROFOUTPUTS; dw++)
        {
            pOutputBuffers[dw].dwStatus = 0;
        }

        hr = ((_DERIVED_)this).InternalProcessOutput(dwFlags, ulOutputBufferCount, pOutputBuffers, pdwStatus);

        // remember the DMO's incomplete status
        for (dw = 0; dw < NUMBEROFOUTPUTS; dw++)
        {
            if ((pOutputBuffers[dw].dwStatus & DMO_OUTPUT_DATA_BUFFERF_INCOMPLETE) != 0)
            {
                m_OutputInfo[dw].fIncomplete = true;
            }
            else
            {
                m_OutputInfo[dw].fIncomplete = false;
            }
        }

        return hr;
    }

    protected STDMETHODIMP DMOLock(int lLock)
    {
        if (lLock != 0)
        {
            ((_DERIVED_)this).Lock();
        }
        else
        {
            ((_DERIVED_)this).Unlock();
        }
        return S_OK;
    }
}


