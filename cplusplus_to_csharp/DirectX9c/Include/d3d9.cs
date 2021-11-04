using System;

/*==========================================================================;
 *
 *  Copyright (C) Microsoft Corporation.  All Rights Reserved.
 *
 *  File:   d3d9.h
 *  Content:    Direct3D include file
 *
 ****************************************************************************/



// include this file content only if compiling for DX9 interfaces
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0900)


/* This identifier is passed to Direct3DCreate9 in order to ensure that an
 * application was built against the correct header files. This number is
 * incremented whenever a header (or other) change would require applications
 * to be rebuilt. If the version doesn't match, Direct3DCreate9 will fail.
 * (The number itself has no meaning.)*/

#if D3D_DEBUG_INFO
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3D_SDK_VERSION (32 | 0x80000000)
#define D3D_SDK_VERSION
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3D9b_SDK_VERSION (31 | 0x80000000)
#define D3D9b_SDK_VERSION

#else
#define D3D_SDK_VERSION
#define D3D9b_SDK_VERSION
#endif



// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <objbase.h>


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if !HMONITOR_DECLARED && (WINVER < 0x0500)
    #define HMONITOR_DECLARED
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DECLARE_HANDLE(IntPtr);
#endif

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DAPI WINAPI

/*
 * Interface IID's
 */
#if _WIN32 && ! _NO_COM

/* IID_IDirect3D9 */
/* {81BDCBCA-64D4-426d-AE8D-AD0147F4275C} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3D9, 0x81bdcbca, 0x64d4, 0x426d, 0xae, 0x8d, 0xad, 0x1, 0x47, 0xf4, 0x27, 0x5c);

/* IID_IDirect3DDevice9 */
// {D0223B96-BF7A-43fd-92BD-A43B0D82B9EB} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DDevice9, 0xd0223b96, 0xbf7a, 0x43fd, 0x92, 0xbd, 0xa4, 0x3b, 0xd, 0x82, 0xb9, 0xeb);

/* IID_IDirect3DResource9 */
// {05EEC05D-8F7D-4362-B999-D1BAF357C704}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DResource9, 0x5eec05d, 0x8f7d, 0x4362, 0xb9, 0x99, 0xd1, 0xba, 0xf3, 0x57, 0xc7, 0x4);

/* IID_IDirect3DBaseTexture9 */
/* {580CA87E-1D3C-4d54-991D-B7D3E3C298CE} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DBaseTexture9, 0x580ca87e, 0x1d3c, 0x4d54, 0x99, 0x1d, 0xb7, 0xd3, 0xe3, 0xc2, 0x98, 0xce);

/* IID_IDirect3DTexture9 */
/* {85C31227-3DE5-4f00-9B3A-F11AC38C18B5} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DTexture9, 0x85c31227, 0x3de5, 0x4f00, 0x9b, 0x3a, 0xf1, 0x1a, 0xc3, 0x8c, 0x18, 0xb5);

/* IID_IDirect3DCubeTexture9 */
/* {FFF32F81-D953-473a-9223-93D652ABA93F} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DCubeTexture9, 0xfff32f81, 0xd953, 0x473a, 0x92, 0x23, 0x93, 0xd6, 0x52, 0xab, 0xa9, 0x3f);

/* IID_IDirect3DVolumeTexture9 */
/* {2518526C-E789-4111-A7B9-47EF328D13E6} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DVolumeTexture9, 0x2518526c, 0xe789, 0x4111, 0xa7, 0xb9, 0x47, 0xef, 0x32, 0x8d, 0x13, 0xe6);

/* IID_IDirect3DVertexBuffer9 */
/* {B64BB1B5-FD70-4df6-BF91-19D0A12455E3} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DVertexBuffer9, 0xb64bb1b5, 0xfd70, 0x4df6, 0xbf, 0x91, 0x19, 0xd0, 0xa1, 0x24, 0x55, 0xe3);

/* IID_IDirect3DIndexBuffer9 */
/* {7C9DD65E-D3F7-4529-ACEE-785830ACDE35} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DIndexBuffer9, 0x7c9dd65e, 0xd3f7, 0x4529, 0xac, 0xee, 0x78, 0x58, 0x30, 0xac, 0xde, 0x35);

/* IID_IDirect3DSurface9 */
/* {0CFBAF3A-9FF6-429a-99B3-A2796AF8B89B} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DSurface9, 0xcfbaf3a, 0x9ff6, 0x429a, 0x99, 0xb3, 0xa2, 0x79, 0x6a, 0xf8, 0xb8, 0x9b);

/* IID_IDirect3DVolume9 */
/* {24F416E6-1F67-4aa7-B88E-D33F6F3128A1} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DVolume9, 0x24f416e6, 0x1f67, 0x4aa7, 0xb8, 0x8e, 0xd3, 0x3f, 0x6f, 0x31, 0x28, 0xa1);

/* IID_IDirect3DSwapChain9 */
/* {794950F2-ADFC-458a-905E-10A10B0B503B} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DSwapChain9, 0x794950f2, 0xadfc, 0x458a, 0x90, 0x5e, 0x10, 0xa1, 0xb, 0xb, 0x50, 0x3b);

/* IID_IDirect3DVertexDeclaration9 */
/* {DD13C59C-36FA-4098-A8FB-C7ED39DC8546} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DVertexDeclaration9, 0xdd13c59c, 0x36fa, 0x4098, 0xa8, 0xfb, 0xc7, 0xed, 0x39, 0xdc, 0x85, 0x46);

/* IID_IDirect3DVertexShader9 */
/* {EFC5557E-6265-4613-8A94-43857889EB36} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DVertexShader9, 0xefc5557e, 0x6265, 0x4613, 0x8a, 0x94, 0x43, 0x85, 0x78, 0x89, 0xeb, 0x36);

/* IID_IDirect3DPixelShader9 */
/* {6D3BDBDC-5B02-4415-B852-CE5E8BCCB289} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DPixelShader9, 0x6d3bdbdc, 0x5b02, 0x4415, 0xb8, 0x52, 0xce, 0x5e, 0x8b, 0xcc, 0xb2, 0x89);

/* IID_IDirect3DStateBlock9 */
/* {B07C4FE5-310D-4ba8-A23C-4F0F206F218B} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DStateBlock9, 0xb07c4fe5, 0x310d, 0x4ba8, 0xa2, 0x3c, 0x4f, 0xf, 0x20, 0x6f, 0x21, 0x8b);

/* IID_IDirect3DQuery9 */
/* {d9771460-a695-4f26-bbd3-27b840b541cc} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirect3DQuery9, 0xd9771460, 0xa695, 0x4f26, 0xbb, 0xd3, 0x27, 0xb8, 0x40, 0xb5, 0x41, 0xcc);


/* IID_HelperName */
/* {E4A36723-FDFE-4b22-B146-3C04C07F4CC8} */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_HelperName, 0xe4a36723, 0xfdfe, 0x4b22, 0xb1, 0x46, 0x3c, 0x4, 0xc0, 0x7f, 0x4c, 0xc8);


#endif

#if __cplusplus

#if ! DECLSPEC_UUID
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER >= 1100
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DECLSPEC_UUID(x) __declspec(uuid(x))
#define DECLSPEC_UUID
#else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DECLSPEC_UUID(x)
#define DECLSPEC_UUID
#endif
#endif

// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("81BDCBCA-64D4-426d-AE8D-AD0147F4275C") IDirect3D9;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("D0223B96-BF7A-43fd-92BD-A43B0D82B9EB") IDirect3DDevice9;

// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("B07C4FE5-310D-4ba8-A23C-4F0F206F218B") IDirect3DStateBlock9;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("05EEC05D-8F7D-4362-B999-D1BAF357C704") IDirect3DResource9;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("DD13C59C-36FA-4098-A8FB-C7ED39DC8546") IDirect3DVertexDeclaration9;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("EFC5557E-6265-4613-8A94-43857889EB36") IDirect3DVertexShader9;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("6D3BDBDC-5B02-4415-B852-CE5E8BCCB289") IDirect3DPixelShader9;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("580CA87E-1D3C-4d54-991D-B7D3E3C298CE") IDirect3DBaseTexture9;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("85C31227-3DE5-4f00-9B3A-F11AC38C18B5") IDirect3DTexture9;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("2518526C-E789-4111-A7B9-47EF328D13E6") IDirect3DVolumeTexture9;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("FFF32F81-D953-473a-9223-93D652ABA93F") IDirect3DCubeTexture9;

// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("B64BB1B5-FD70-4df6-BF91-19D0A12455E3") IDirect3DVertexBuffer9;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("7C9DD65E-D3F7-4529-ACEE-785830ACDE35") IDirect3DIndexBuffer9;

// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("0CFBAF3A-9FF6-429a-99B3-A2796AF8B89B") IDirect3DSurface9;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("24F416E6-1F67-4aa7-B88E-D33F6F3128A1") IDirect3DVolume9;

// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("794950F2-ADFC-458a-905E-10A10B0B503B") IDirect3DSwapChain9;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("d9771460-a695-4f26-bbd3-27b840b541cc") IDirect3DQuery9;


#if _COM_SMARTPTR_TYPEDEF
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3D9, __uuidof(IDirect3D9));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DDevice9, __uuidof(IDirect3DDevice9));

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DStateBlock9, __uuidof(IDirect3DStateBlock9));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DResource9, __uuidof(IDirect3DResource9));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DVertexDeclaration9, __uuidof(IDirect3DVertexDeclaration9));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DVertexShader9, __uuidof(IDirect3DVertexShader9));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DPixelShader9, __uuidof(IDirect3DPixelShader9));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DBaseTexture9, __uuidof(IDirect3DBaseTexture9));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DTexture9, __uuidof(IDirect3DTexture9));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DVolumeTexture9, __uuidof(IDirect3DVolumeTexture9));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DCubeTexture9, __uuidof(IDirect3DCubeTexture9));

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DVertexBuffer9, __uuidof(IDirect3DVertexBuffer9));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DIndexBuffer9, __uuidof(IDirect3DIndexBuffer9));

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DSurface9, __uuidof(IDirect3DSurface9));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DVolume9, __uuidof(IDirect3DVolume9));

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DSwapChain9, __uuidof(IDirect3DSwapChain9));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(IDirect3DQuery9, __uuidof(IDirect3DQuery9));

#endif
#endif


// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3D9 IDirect3D9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DDevice9 IDirect3DDevice9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DStateBlock9 IDirect3DStateBlock9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DVertexDeclaration9 IDirect3DVertexDeclaration9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DVertexShader9 IDirect3DVertexShader9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DPixelShader9 IDirect3DPixelShader9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DResource9 IDirect3DResource9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DBaseTexture9 IDirect3DBaseTexture9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DTexture9 IDirect3DTexture9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DVolumeTexture9 IDirect3DVolumeTexture9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DCubeTexture9 IDirect3DCubeTexture9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DVertexBuffer9 IDirect3DVertexBuffer9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DIndexBuffer9 IDirect3DIndexBuffer9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DSurface9 IDirect3DSurface9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DVolume9 IDirect3DVolume9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DSwapChain9 IDirect3DSwapChain9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IDirect3DQuery9 IDirect3DQuery9;


// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_ARGB(a,r,g,b) ((D3DCOLOR)((((a)&0xff)<<24)|(((r)&0xff)<<16)|(((g)&0xff)<<8)|((b)&0xff)))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_RGBA(r,g,b,a) D3DCOLOR_ARGB(a,r,g,b)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_XRGB(r,g,b) D3DCOLOR_ARGB(0xff,r,g,b)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_XYUV(y,u,v) D3DCOLOR_ARGB(0xff,y,u,v)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_AYUV(a,y,u,v) D3DCOLOR_ARGB(a,y,u,v)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_COLORVALUE(r,g,b,a) D3DCOLOR_RGBA((DWORD)((r)*255.f),(DWORD)((g)*255.f),(DWORD)((b)*255.f),(DWORD)((a)*255.f))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE0 (1 << 0)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE1 (1 << 1)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE2 (1 << 2)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE3 (1 << 3)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE4 (1 << 4)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE5 (1 << 5)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCS_ALL (D3DCS_LEFT | D3DCS_RIGHT | D3DCS_TOP | D3DCS_BOTTOM | D3DCS_FRONT | D3DCS_BACK | D3DCS_PLANE0 | D3DCS_PLANE1 | D3DCS_PLANE2 | D3DCS_PLANE3 | D3DCS_PLANE4 | D3DCS_PLANE5)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLDMATRIX(index) (D3DTRANSFORMSTATETYPE)(index + 256)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLD D3DTS_WORLDMATRIX(0)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLD1 D3DTS_WORLDMATRIX(1)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLD2 D3DTS_WORLDMATRIX(2)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLD3 D3DTS_WORLDMATRIX(3)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLORWRITEENABLE_RED (1L<<0)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLORWRITEENABLE_GREEN (1L<<1)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLORWRITEENABLE_BLUE (1L<<2)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLORWRITEENABLE_ALPHA (1L<<3)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVERTEXTEXTURESAMPLER0 (D3DDMAPSAMPLER+1)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVERTEXTEXTURESAMPLER1 (D3DDMAPSAMPLER+2)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVERTEXTEXTURESAMPLER2 (D3DDMAPSAMPLER+3)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVERTEXTEXTURESAMPLER3 (D3DDMAPSAMPLER+4)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPV_DONOTCOPYDATA (1 << 0)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAXD3DDECLUSAGE D3DDECLUSAGE_SAMPLE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAXD3DDECLMETHOD D3DDECLMETHOD_LOOKUPPRESAMPLED
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAXD3DDECLTYPE D3DDECLTYPE_UNUSED
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DDECL_END() {0xFF,0,D3DDECLTYPE_UNUSED,0,0,0}
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTREAMSOURCE_INDEXEDDATA (1<<30)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTREAMSOURCE_INSTANCEDATA (2<<30)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSINCOSCONST1 -1.5500992e-006f, -2.1701389e-005f, 0.0026041667f, 0.00026041668f
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSINCOSCONST2 -0.020833334f, -0.12500000f, 1.0f, 0.50000000f
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSI_TEXLD_PROJECT (0x01 << D3DSP_OPCODESPECIFICCONTROL_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSI_TEXLD_BIAS (0x02 << D3DSP_OPCODESPECIFICCONTROL_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_COMPARISON_SHIFT D3DSP_OPCODESPECIFICCONTROL_SHIFT
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_COMPARISON_MASK (0x7<<D3DSHADER_COMPARISON_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_INSTRUCTION_PREDICATED (0x1 << 28)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSPDM_NONE (0<<D3DSP_DSTMOD_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSPDM_SATURATE (1<<D3DSP_DSTMOD_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSPDM_PARTIALPRECISION (2<<D3DSP_DSTMOD_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSPDM_MSAMPCENTROID (4<<D3DSP_DSTMOD_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_ADDRESSMODE_MASK (1 << D3DVS_ADDRESSMODE_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_ADDRESSMODE_MASK (1 << D3DSHADER_ADDRESSMODE_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_X_X (0 << D3DVS_SWIZZLE_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_X_Y (1 << D3DVS_SWIZZLE_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_X_Z (2 << D3DVS_SWIZZLE_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_X_W (3 << D3DVS_SWIZZLE_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Y_X (0 << (D3DVS_SWIZZLE_SHIFT + 2))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Y_Y (1 << (D3DVS_SWIZZLE_SHIFT + 2))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Y_Z (2 << (D3DVS_SWIZZLE_SHIFT + 2))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Y_W (3 << (D3DVS_SWIZZLE_SHIFT + 2))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Z_X (0 << (D3DVS_SWIZZLE_SHIFT + 4))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Z_Y (1 << (D3DVS_SWIZZLE_SHIFT + 4))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Z_Z (2 << (D3DVS_SWIZZLE_SHIFT + 4))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Z_W (3 << (D3DVS_SWIZZLE_SHIFT + 4))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_W_X (0 << (D3DVS_SWIZZLE_SHIFT + 6))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_W_Y (1 << (D3DVS_SWIZZLE_SHIFT + 6))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_W_Z (2 << (D3DVS_SWIZZLE_SHIFT + 6))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_W_W (3 << (D3DVS_SWIZZLE_SHIFT + 6))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_NOSWIZZLE (D3DVS_X_X | D3DVS_Y_Y | D3DVS_Z_Z | D3DVS_W_W)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_NOSWIZZLE ( (0 << (D3DSP_SWIZZLE_SHIFT + 0)) | (1 << (D3DSP_SWIZZLE_SHIFT + 2)) | (2 << (D3DSP_SWIZZLE_SHIFT + 4)) | (3 << (D3DSP_SWIZZLE_SHIFT + 6)) )
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_REPLICATERED ( (0 << (D3DSP_SWIZZLE_SHIFT + 0)) | (0 << (D3DSP_SWIZZLE_SHIFT + 2)) | (0 << (D3DSP_SWIZZLE_SHIFT + 4)) | (0 << (D3DSP_SWIZZLE_SHIFT + 6)) )
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_REPLICATEGREEN ( (1 << (D3DSP_SWIZZLE_SHIFT + 0)) | (1 << (D3DSP_SWIZZLE_SHIFT + 2)) | (1 << (D3DSP_SWIZZLE_SHIFT + 4)) | (1 << (D3DSP_SWIZZLE_SHIFT + 6)) )
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_REPLICATEBLUE ( (2 << (D3DSP_SWIZZLE_SHIFT + 0)) | (2 << (D3DSP_SWIZZLE_SHIFT + 2)) | (2 << (D3DSP_SWIZZLE_SHIFT + 4)) | (2 << (D3DSP_SWIZZLE_SHIFT + 6)) )
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_REPLICATEALPHA ( (3 << (D3DSP_SWIZZLE_SHIFT + 0)) | (3 << (D3DSP_SWIZZLE_SHIFT + 2)) | (3 << (D3DSP_SWIZZLE_SHIFT + 4)) | (3 << (D3DSP_SWIZZLE_SHIFT + 6)) )
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS_VERSION(_Major,_Minor) (0xFFFF0000|((_Major)<<8)|(_Minor))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_VERSION(_Major,_Minor) (0xFFFE0000|((_Major)<<8)|(_Minor))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_VERSION_MAJOR(_Version) (((_Version)>>8)&0xFF)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_VERSION_MINOR(_Version) (((_Version)>>0)&0xFF)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_COMMENT(_DWordSize) ((((_DWordSize)<<D3DSI_COMMENTSIZE_SHIFT)&D3DSI_COMMENTSIZE_MASK)|D3DSIO_COMMENT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS_END() 0x0000FFFF
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_END() 0x0000FFFF
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE3(CoordIndex) (D3DFVF_TEXTUREFORMAT3 << (CoordIndex*2 + 16))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE2(CoordIndex) (D3DFVF_TEXTUREFORMAT2)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE4(CoordIndex) (D3DFVF_TEXTUREFORMAT4 << (CoordIndex*2 + 16))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE1(CoordIndex) (D3DFVF_TEXTUREFORMAT1 << (CoordIndex*2 + 16))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKEFOURCC(ch0, ch1, ch2, ch3) ((DWORD)(BYTE)(ch0) | ((DWORD)(BYTE)(ch1) << 8) | ((DWORD)(BYTE)(ch2) << 16) | ((DWORD)(BYTE)(ch3) << 24 ))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_RENDERTARGET (0x00000001L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_DEPTHSTENCIL (0x00000002L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_DYNAMIC (0x00000200L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_AUTOGENMIPMAP (0x00000400L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_DMAP (0x00004000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_LEGACYBUMPMAP (0x00008000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_SRGBREAD (0x00010000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_FILTER (0x00020000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_SRGBWRITE (0x00040000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_POSTPIXELSHADER_BLENDING (0x00080000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_VERTEXTEXTURE (0x00100000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_WRAPANDMIP (0x00200000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_WRITEONLY (0x00000008L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_SOFTWAREPROCESSING (0x00000010L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_DONOTCLIP (0x00000020L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_POINTS (0x00000040L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_RTPATCHES (0x00000080L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_NPATCHES (0x00000100L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DISSUE_END (1 << 0)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DISSUE_BEGIN (1 << 1)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DGETDATA_FLUSH (1 << 0)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRTYPECOUNT (D3DRTYPE_INDEXBUFFER+1)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS20CAPS_PREDICATION (1<<0)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS20CAPS_ARBITRARYSWIZZLE (1<<0)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS20CAPS_GRADIENTINSTRUCTIONS (1<<1)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS20CAPS_PREDICATION (1<<2)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS20CAPS_NODEPENDENTREADLIMIT (1<<3)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS20CAPS_NOTEXINSTRUCTIONLIMIT (1<<4)


#if __cplusplus
#endif