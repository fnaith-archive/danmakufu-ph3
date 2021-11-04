/*==========================================================================;
 *
 *  Copyright (C) Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       dxdiag.h
 *  Content:    DirectX Diagnostic Tool include file
 *
 ****************************************************************************/


// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <ole2.h> // for DECLARE_INTERFACE_ and HRESULT

// This identifier is passed to IDxDiagProvider::Initialize in order to ensure that an
// application was built against the correct header files. This number is
// incremented whenever a header (or other) change would require applications
// to be rebuilt. If the version doesn't match, IDxDiagProvider::Initialize will fail.
// (The number itself has no meaning.)

#if __cplusplus
#endif


/****************************************************************************
 *
 * DxDiag Errors
 *
 ****************************************************************************/
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXDIAG_E_INSUFFICIENT_BUFFER ((HRESULT)0x8007007AL)


/****************************************************************************
 *
 * DxDiag CLSIDs
 *
 ****************************************************************************/

// {A65B8071-3BFE-4213-9A5B-491DA4461CA7}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DxDiagProvider, 0xA65B8071, 0x3BFE, 0x4213, 0x9A, 0x5B, 0x49, 0x1D, 0xA4, 0x46, 0x1C, 0xA7);


/****************************************************************************
 *
 * DxDiag Interface IIDs
 *
 ****************************************************************************/

// {9C6B4CB0-23F8-49CC-A3ED-45A55000A6D2}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDxDiagProvider, 0x9C6B4CB0, 0x23F8, 0x49CC, 0xA3, 0xED, 0x45, 0xA5, 0x50, 0x00, 0xA6, 0xD2);

// {0x7D0F462F-0x4064-0x4862-BC7F-933E5058C10F}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDxDiagContainer, 0x7D0F462F, 0x4064, 0x4862, 0xBC, 0x7F, 0x93, 0x3E, 0x50, 0x58, 0xC1, 0x0F);


/****************************************************************************
 *
 * DxDiag Interface Pointer definitions
 *
 ****************************************************************************/




/****************************************************************************
 *
 * DxDiag Structures
 *
 ****************************************************************************/

public class _DXDIAG_INIT_PARAMS
{
    public uint dwSize; // Size of this structure.
    public uint dwDxDiagHeaderVersion; // Pass in DXDIAG_DX9_SDK_VERSION.  This verifies
                                    // the header and dll are correctly matched.
    public bool bAllowWHQLChecks; // If true, allow dxdiag to check if drivers are
                                    // digital signed as logo'd by WHQL which may 
                                    // connect via internet to update WHQL certificates.
    public object pReserved; // Reserved. Must be NULL.
}