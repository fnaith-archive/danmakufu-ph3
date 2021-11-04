// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for tvratings.idl:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
// @@MIDL_FILE_HEADING(  )


/* verify that the <rpcndr.h> version is high enough to compile this file*/

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "rpc.h"
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "rpcndr.h"

#if ! __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#if ! COM_NO_WINDOWS_H
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "ole2.h"
#endif //COM_NO_WINDOWS_H


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER && (_MSC_VER >= 1020)
#endif

/* Forward Declarations */ 






#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class XDSToRat XDSToRat;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct XDSToRat XDSToRat;
#endif // __cplusplus




#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class EvalRat EvalRat;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct EvalRat EvalRat;
#endif // __cplusplus



/* header files for imported files */
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "oaidl.h"
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "ocidl.h"

#if __cplusplus
#endif

/* interface __MIDL_itf_tvratings_0000 */
/* [local] */ 

public enum __MIDL___MIDL_itf_tvratings_0000_0001
{
        MPAA = 0,
    US_TV = 1,
    Canadian_English = 2,
    Canadian_French = 3,
    Reserved4 = 4,
    System5 = 5,
    System6 = 6,
    Reserved7 = 7,
    TvRat_kSystems = 8,
    TvRat_SystemDontKnow = 255
}

public enum __MIDL___MIDL_itf_tvratings_0000_0002
{
        TvRat_0 = 0,
    TvRat_1 = 1,
    TvRat_2 = 2,
    TvRat_3 = 3,
    TvRat_4 = 4,
    TvRat_5 = 5,
    TvRat_6 = 6,
    TvRat_7 = 7,
    TvRat_kLevels = 8,
    TvRat_LevelDontKnow = 255
}

public enum __MIDL___MIDL_itf_tvratings_0000_0003
{
        MPAA_NotApplicable = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_0,
    MPAA_G = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_1,
    MPAA_PG = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_2,
    MPAA_PG13 = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_3,
    MPAA_R = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_4,
    MPAA_NC17 = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_5,
    MPAA_X = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_6,
    MPAA_NotRated = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_7
}

public enum __MIDL___MIDL_itf_tvratings_0000_0004
{
        US_TV_None = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_0,
    US_TV_Y = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_1,
    US_TV_Y7 = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_2,
    US_TV_G = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_3,
    US_TV_PG = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_4,
    US_TV_14 = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_5,
    US_TV_MA = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_6,
    US_TV_None7 = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_7
}

public enum __MIDL___MIDL_itf_tvratings_0000_0005
{
        CAE_TV_Exempt = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_0,
    CAE_TV_C = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_1,
    CAE_TV_C8 = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_2,
    CAE_TV_G = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_3,
    CAE_TV_PG = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_4,
    CAE_TV_14 = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_5,
    CAE_TV_18 = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_6,
    CAE_TV_Reserved = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_7
}

public enum __MIDL___MIDL_itf_tvratings_0000_0006
{
        CAF_TV_Exempt = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_0,
    CAF_TV_G = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_1,
    CAF_TV_8 = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_2,
    CAF_TV_13 = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_3,
    CAF_TV_16 = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_4,
    CAF_TV_18 = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_5,
    CAF_TV_Reserved6 = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_6,
    CAF_TV_Reserved = __MIDL___MIDL_itf_tvratings_0000_0002.TvRat_7
}

public enum __MIDL___MIDL_itf_tvratings_0000_0007
{
        BfAttrNone = 0,
    BfIsBlocked = 1,
    BfIsAttr_1 = 2,
    BfIsAttr_2 = 4,
    BfIsAttr_3 = 8,
    BfIsAttr_4 = 16,
    BfIsAttr_5 = 32,
    BfIsAttr_6 = 64,
    BfIsAttr_7 = 128,
    BfValidAttrSubmask = 255
}

public enum __MIDL___MIDL_itf_tvratings_0000_0008
{
        US_TV_IsBlocked = __MIDL___MIDL_itf_tvratings_0000_0007.BfIsBlocked,
    US_TV_IsViolent = __MIDL___MIDL_itf_tvratings_0000_0007.BfIsAttr_1,
    US_TV_IsSexualSituation = __MIDL___MIDL_itf_tvratings_0000_0007.BfIsAttr_2,
    US_TV_IsAdultLanguage = __MIDL___MIDL_itf_tvratings_0000_0007.BfIsAttr_3,
    US_TV_IsSexuallySuggestiveDialog = __MIDL___MIDL_itf_tvratings_0000_0007.BfIsAttr_4,
    US_TV_ValidAttrSubmask = 31
}

public enum __MIDL___MIDL_itf_tvratings_0000_0009
{
        MPAA_IsBlocked = __MIDL___MIDL_itf_tvratings_0000_0007.BfIsBlocked,
    MPAA_ValidAttrSubmask = 1
}

public enum __MIDL___MIDL_itf_tvratings_0000_0010
{
        CAE_IsBlocked = __MIDL___MIDL_itf_tvratings_0000_0007.BfIsBlocked,
    CAE_ValidAttrSubmask = 1
}

public enum __MIDL___MIDL_itf_tvratings_0000_0011
{
        CAF_IsBlocked = __MIDL___MIDL_itf_tvratings_0000_0007.BfIsBlocked,
    CAF_ValidAttrSubmask = 1
}

#else // C style interface

    public class IXDSToRatVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IXDSToRat * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IXDSToRat This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IXDSToRat * This);
        public delegate uint AddRefDelegate(@interface IXDSToRat This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IXDSToRat * This);
        public delegate uint ReleaseDelegate(@interface IXDSToRat This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IXDSToRat * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IXDSToRat This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IXDSToRat * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IXDSToRat This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IXDSToRat * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IXDSToRat This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IXDSToRat * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IXDSToRat This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Init)(interface IXDSToRat * This);
        public delegate int InitDelegate(@interface IXDSToRat This);
        public InitDelegate Init;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ParseXDSBytePair)(interface IXDSToRat * This, byte byte1, byte byte2, EnTvRat_System *pEnSystem, EnTvRat_GenericLevel *pEnLevel, int *plBfEnAttributes);
        public delegate int ParseXDSBytePairDelegate(@interface IXDSToRat This, byte byte1, byte byte2, EnTvRat_System pEnSystem, EnTvRat_GenericLevel pEnLevel, ref int plBfEnAttributes);
        public ParseXDSBytePairDelegate ParseXDSBytePair;

//        END_INTERFACE
    }

#else // C style interface

    public class IEvalRatVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IEvalRat * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IEvalRat This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IEvalRat * This);
        public delegate uint AddRefDelegate(@interface IEvalRat This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IEvalRat * This);
        public delegate uint ReleaseDelegate(@interface IEvalRat This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IEvalRat * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IEvalRat This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IEvalRat * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IEvalRat This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IEvalRat * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IEvalRat This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IEvalRat * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IEvalRat This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BlockedRatingAttributes)(interface IEvalRat * This, EnTvRat_System enSystem, EnTvRat_GenericLevel enLevel, int *plbfAttrs);
        public delegate int get_BlockedRatingAttributesDelegate(@interface IEvalRat This, EnTvRat_System enSystem, EnTvRat_GenericLevel enLevel, ref int plbfAttrs);
        public get_BlockedRatingAttributesDelegate get_BlockedRatingAttributes;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BlockedRatingAttributes)(interface IEvalRat * This, EnTvRat_System enSystem, EnTvRat_GenericLevel enLevel, int lbfAttrs);
        public delegate int put_BlockedRatingAttributesDelegate(@interface IEvalRat This, EnTvRat_System enSystem, EnTvRat_GenericLevel enLevel, int lbfAttrs);
        public put_BlockedRatingAttributesDelegate put_BlockedRatingAttributes;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BlockUnRated)(interface IEvalRat * This, bool *pfBlockUnRatedShows);
        public delegate int get_BlockUnRatedDelegate(@interface IEvalRat This, ref bool pfBlockUnRatedShows);
        public get_BlockUnRatedDelegate get_BlockUnRated;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BlockUnRated)(interface IEvalRat * This, bool fBlockUnRatedShows);
        public delegate int put_BlockUnRatedDelegate(@interface IEvalRat This, bool fBlockUnRatedShows);
        public put_BlockUnRatedDelegate put_BlockUnRated;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *MostRestrictiveRating)(interface IEvalRat * This, EnTvRat_System enSystem1, EnTvRat_GenericLevel enEnLevel1, int lbfEnAttr1, EnTvRat_System enSystem2, EnTvRat_GenericLevel enEnLevel2, int lbfEnAttr2, EnTvRat_System *penSystem, EnTvRat_GenericLevel *penEnLevel, int *plbfEnAttr);
        public delegate int MostRestrictiveRatingDelegate(@interface IEvalRat This, EnTvRat_System enSystem1, EnTvRat_GenericLevel enEnLevel1, int lbfEnAttr1, EnTvRat_System enSystem2, EnTvRat_GenericLevel enEnLevel2, int lbfEnAttr2, EnTvRat_System penSystem, EnTvRat_GenericLevel penEnLevel, ref int plbfEnAttr);
        public MostRestrictiveRatingDelegate MostRestrictiveRating;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *TestRating)(interface IEvalRat * This, EnTvRat_System enShowSystem, EnTvRat_GenericLevel enShowLevel, int lbfEnShowAttributes);
        public delegate int TestRatingDelegate(@interface IEvalRat This, EnTvRat_System enShowSystem, EnTvRat_GenericLevel enShowLevel, int lbfEnShowAttributes);
        public TestRatingDelegate TestRating;

//        END_INTERFACE
    }