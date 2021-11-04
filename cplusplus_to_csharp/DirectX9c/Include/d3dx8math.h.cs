using System;

/// ///////////////////////////////////////////////////////////////////////////
// 
//  Copyright (C) Microsoft Corporation.  All Rights Reserved.
// 
//  File:       d3dx8math.h
//  Content:    D3DX math types and functions
// 
/// ///////////////////////////////////////////////////////////////////////////

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DAPI WINAPI
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_ARGB(a,r,g,b) ((D3DCOLOR)((((a)&0xff)<<24)|(((r)&0xff)<<16)|(((g)&0xff)<<8)|((b)&0xff)))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_RGBA(r,g,b,a) D3DCOLOR_ARGB(a,r,g,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_XRGB(r,g,b) D3DCOLOR_ARGB(0xff,r,g,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_COLORVALUE(r,g,b,a) D3DCOLOR_RGBA((DWORD)((r)*255.f),(DWORD)((g)*255.f),(DWORD)((b)*255.f),(DWORD)((a)*255.f))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE0 (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE1 (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE2 (1 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE3 (1 << 3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE4 (1 << 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE5 (1 << 5)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCS_ALL (D3DCS_LEFT | D3DCS_RIGHT | D3DCS_TOP | D3DCS_BOTTOM | D3DCS_FRONT | D3DCS_BACK | D3DCS_PLANE0 | D3DCS_PLANE1 | D3DCS_PLANE2 | D3DCS_PLANE3 | D3DCS_PLANE4 | D3DCS_PLANE5)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLDMATRIX(index) (D3DTRANSFORMSTATETYPE)(index + 256)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLD D3DTS_WORLDMATRIX(0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLD1 D3DTS_WORLDMATRIX(1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLD2 D3DTS_WORLDMATRIX(2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLD3 D3DTS_WORLDMATRIX(3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLORWRITEENABLE_RED (1L<<0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLORWRITEENABLE_GREEN (1L<<1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLORWRITEENABLE_BLUE (1L<<2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLORWRITEENABLE_ALPHA (1L<<3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPV_DONOTCOPYDATA (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_TOKENTYPEMASK (7 << D3DVSD_TOKENTYPESHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_STREAMNUMBERMASK (0xF << D3DVSD_STREAMNUMBERSHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_DATALOADTYPEMASK (0x1 << D3DVSD_DATALOADTYPESHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_DATATYPEMASK (0xF << D3DVSD_DATATYPESHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_SKIPCOUNTMASK (0xF << D3DVSD_SKIPCOUNTSHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_VERTEXREGMASK (0x1F << D3DVSD_VERTEXREGSHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_VERTEXREGINMASK (0xF << D3DVSD_VERTEXREGINSHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_CONSTCOUNTMASK (0xF << D3DVSD_CONSTCOUNTSHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_CONSTADDRESSMASK (0x7F << D3DVSD_CONSTADDRESSSHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_CONSTRSMASK (0x1FFF << D3DVSD_CONSTRSSHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_EXTCOUNTMASK (0x1F << D3DVSD_EXTCOUNTSHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_EXTINFOMASK (0xFFFFFF << D3DVSD_EXTINFOSHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_MAKETOKENTYPE(tokenType) ((tokenType << D3DVSD_TOKENTYPESHIFT) & D3DVSD_TOKENTYPEMASK)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_STREAM( _StreamNumber ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_STREAM) | (_StreamNumber))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_STREAMTESSMASK (1 << D3DVSD_STREAMTESSSHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_STREAM_TESS( ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_STREAM) | (D3DVSD_STREAMTESSMASK))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_REG( _VertexRegister, _Type ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_STREAMDATA) | ((_Type) << D3DVSD_DATATYPESHIFT) | (_VertexRegister))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_SKIP( _DWORDCount ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_STREAMDATA) | 0x10000000 | ((_DWORDCount) << D3DVSD_SKIPCOUNTSHIFT))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_CONST( _ConstantAddress, _Count ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_CONSTMEM) | ((_Count) << D3DVSD_CONSTCOUNTSHIFT) | (_ConstantAddress))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_TESSNORMAL( _VertexRegisterIn, _VertexRegisterOut ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_TESSELLATOR) | ((_VertexRegisterIn) << D3DVSD_VERTEXREGINSHIFT) | ((0x02) << D3DVSD_DATATYPESHIFT) | (_VertexRegisterOut))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_TESSUV( _VertexRegister ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_TESSELLATOR) | 0x10000000 | ((0x01) << D3DVSD_DATATYPESHIFT) | (_VertexRegister))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_END() 0xFFFFFFFF
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_NOP() 0x00000000
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_ADDRESSMODE_MASK (1 << D3DVS_ADDRESSMODE_SHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_X_X (0 << D3DVS_SWIZZLE_SHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_X_Y (1 << D3DVS_SWIZZLE_SHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_X_Z (2 << D3DVS_SWIZZLE_SHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_X_W (3 << D3DVS_SWIZZLE_SHIFT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Y_X (0 << (D3DVS_SWIZZLE_SHIFT + 2))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Y_Y (1 << (D3DVS_SWIZZLE_SHIFT + 2))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Y_Z (2 << (D3DVS_SWIZZLE_SHIFT + 2))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Y_W (3 << (D3DVS_SWIZZLE_SHIFT + 2))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Z_X (0 << (D3DVS_SWIZZLE_SHIFT + 4))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Z_Y (1 << (D3DVS_SWIZZLE_SHIFT + 4))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Z_Z (2 << (D3DVS_SWIZZLE_SHIFT + 4))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Z_W (3 << (D3DVS_SWIZZLE_SHIFT + 4))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_W_X (0 << (D3DVS_SWIZZLE_SHIFT + 6))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_W_Y (1 << (D3DVS_SWIZZLE_SHIFT + 6))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_W_Z (2 << (D3DVS_SWIZZLE_SHIFT + 6))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_W_W (3 << (D3DVS_SWIZZLE_SHIFT + 6))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_NOSWIZZLE (D3DVS_X_X | D3DVS_Y_Y | D3DVS_Z_Z | D3DVS_W_W)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_NOSWIZZLE ( (0 << (D3DSP_SWIZZLE_SHIFT + 0)) | (1 << (D3DSP_SWIZZLE_SHIFT + 2)) | (2 << (D3DSP_SWIZZLE_SHIFT + 4)) | (3 << (D3DSP_SWIZZLE_SHIFT + 6)) )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_REPLICATERED ( (0 << (D3DSP_SWIZZLE_SHIFT + 0)) | (0 << (D3DSP_SWIZZLE_SHIFT + 2)) | (0 << (D3DSP_SWIZZLE_SHIFT + 4)) | (0 << (D3DSP_SWIZZLE_SHIFT + 6)) )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_REPLICATEGREEN ( (1 << (D3DSP_SWIZZLE_SHIFT + 0)) | (1 << (D3DSP_SWIZZLE_SHIFT + 2)) | (1 << (D3DSP_SWIZZLE_SHIFT + 4)) | (1 << (D3DSP_SWIZZLE_SHIFT + 6)) )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_REPLICATEBLUE ( (2 << (D3DSP_SWIZZLE_SHIFT + 0)) | (2 << (D3DSP_SWIZZLE_SHIFT + 2)) | (2 << (D3DSP_SWIZZLE_SHIFT + 4)) | (2 << (D3DSP_SWIZZLE_SHIFT + 6)) )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_REPLICATEALPHA ( (3 << (D3DSP_SWIZZLE_SHIFT + 0)) | (3 << (D3DSP_SWIZZLE_SHIFT + 2)) | (3 << (D3DSP_SWIZZLE_SHIFT + 4)) | (3 << (D3DSP_SWIZZLE_SHIFT + 6)) )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS_VERSION(_Major,_Minor) (0xFFFF0000|((_Major)<<8)|(_Minor))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_VERSION(_Major,_Minor) (0xFFFE0000|((_Major)<<8)|(_Minor))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_VERSION_MAJOR(_Version) (((_Version)>>8)&0xFF)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_VERSION_MINOR(_Version) (((_Version)>>0)&0xFF)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_COMMENT(_DWordSize) ((((_DWordSize)<<D3DSI_COMMENTSIZE_SHIFT)&D3DSI_COMMENTSIZE_MASK)|D3DSIO_COMMENT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS_END() 0x0000FFFF
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_END() 0x0000FFFF
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE3(CoordIndex) (D3DFVF_TEXTUREFORMAT3 << (CoordIndex*2 + 16))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE2(CoordIndex) (D3DFVF_TEXTUREFORMAT2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE4(CoordIndex) (D3DFVF_TEXTUREFORMAT4 << (CoordIndex*2 + 16))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE1(CoordIndex) (D3DFVF_TEXTUREFORMAT1 << (CoordIndex*2 + 16))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKEFOURCC(ch0, ch1, ch2, ch3) ((DWORD)(BYTE)(ch0) | ((DWORD)(BYTE)(ch1) << 8) | ((DWORD)(BYTE)(ch2) << 16) | ((DWORD)(BYTE)(ch3) << 24 ))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_RENDERTARGET (0x00000001L)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_DEPTHSTENCIL (0x00000002L)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_WRITEONLY (0x00000008L)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_SOFTWAREPROCESSING (0x00000010L)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_DONOTCLIP (0x00000020L)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_POINTS (0x00000040L)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_RTPATCHES (0x00000080L)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_NPATCHES (0x00000100L)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_DYNAMIC (0x00000200L)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRTYPECOUNT (D3DRTYPE_INDEXBUFFER+1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirect3D8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_RegisterSoftwareDevice(p,a) (p)->lpVtbl->RegisterSoftwareDevice(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_GetAdapterCount(p) (p)->lpVtbl->GetAdapterCount(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_GetAdapterIdentifier(p,a,b,c) (p)->lpVtbl->GetAdapterIdentifier(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_GetAdapterModeCount(p,a) (p)->lpVtbl->GetAdapterModeCount(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_EnumAdapterModes(p,a,b,c) (p)->lpVtbl->EnumAdapterModes(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_GetAdapterDisplayMode(p,a,b) (p)->lpVtbl->GetAdapterDisplayMode(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_CheckDeviceType(p,a,b,c,d,e) (p)->lpVtbl->CheckDeviceType(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_CheckDeviceFormat(p,a,b,c,d,e,f) (p)->lpVtbl->CheckDeviceFormat(p,a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_CheckDeviceMultiSampleType(p,a,b,c,d,e) (p)->lpVtbl->CheckDeviceMultiSampleType(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_CheckDepthStencilMatch(p,a,b,c,d,e) (p)->lpVtbl->CheckDepthStencilMatch(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_GetDeviceCaps(p,a,b,c) (p)->lpVtbl->GetDeviceCaps(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_GetAdapterMonitor(p,a) (p)->lpVtbl->GetAdapterMonitor(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_CreateDevice(p,a,b,c,d,e,f) (p)->lpVtbl->CreateDevice(p,a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_RegisterSoftwareDevice(p,a) (p)->RegisterSoftwareDevice(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_GetAdapterCount(p) (p)->GetAdapterCount()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_GetAdapterIdentifier(p,a,b,c) (p)->GetAdapterIdentifier(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_GetAdapterModeCount(p,a) (p)->GetAdapterModeCount(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_EnumAdapterModes(p,a,b,c) (p)->EnumAdapterModes(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_GetAdapterDisplayMode(p,a,b) (p)->GetAdapterDisplayMode(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_CheckDeviceType(p,a,b,c,d,e) (p)->CheckDeviceType(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_CheckDeviceFormat(p,a,b,c,d,e,f) (p)->CheckDeviceFormat(a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_CheckDeviceMultiSampleType(p,a,b,c,d,e) (p)->CheckDeviceMultiSampleType(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_CheckDepthStencilMatch(p,a,b,c,d,e) (p)->CheckDepthStencilMatch(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_GetDeviceCaps(p,a,b,c) (p)->GetDeviceCaps(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_GetAdapterMonitor(p,a) (p)->GetAdapterMonitor(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3D8_CreateDevice(p,a,b,c,d,e,f) (p)->CreateDevice(a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirect3DDevice8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_TestCooperativeLevel(p) (p)->lpVtbl->TestCooperativeLevel(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetAvailableTextureMem(p) (p)->lpVtbl->GetAvailableTextureMem(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_ResourceManagerDiscardBytes(p,a) (p)->lpVtbl->ResourceManagerDiscardBytes(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetDirect3D(p,a) (p)->lpVtbl->GetDirect3D(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetDeviceCaps(p,a) (p)->lpVtbl->GetDeviceCaps(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetDisplayMode(p,a) (p)->lpVtbl->GetDisplayMode(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetCreationParameters(p,a) (p)->lpVtbl->GetCreationParameters(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetCursorProperties(p,a,b,c) (p)->lpVtbl->SetCursorProperties(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetCursorPosition(p,a,b,c) (p)->lpVtbl->SetCursorPosition(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_ShowCursor(p,a) (p)->lpVtbl->ShowCursor(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateAdditionalSwapChain(p,a,b) (p)->lpVtbl->CreateAdditionalSwapChain(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_Reset(p,a) (p)->lpVtbl->Reset(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_Present(p,a,b,c,d) (p)->lpVtbl->Present(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetBackBuffer(p,a,b,c) (p)->lpVtbl->GetBackBuffer(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetRasterStatus(p,a) (p)->lpVtbl->GetRasterStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetGammaRamp(p,a,b) (p)->lpVtbl->SetGammaRamp(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetGammaRamp(p,a) (p)->lpVtbl->GetGammaRamp(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateTexture(p,a,b,c,d,e,f,g) (p)->lpVtbl->CreateTexture(p,a,b,c,d,e,f,g)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateVolumeTexture(p,a,b,c,d,e,f,g,h) (p)->lpVtbl->CreateVolumeTexture(p,a,b,c,d,e,f,g,h)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateCubeTexture(p,a,b,c,d,e,f) (p)->lpVtbl->CreateCubeTexture(p,a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateVertexBuffer(p,a,b,c,d,e) (p)->lpVtbl->CreateVertexBuffer(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateIndexBuffer(p,a,b,c,d,e) (p)->lpVtbl->CreateIndexBuffer(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateRenderTarget(p,a,b,c,d,e,f) (p)->lpVtbl->CreateRenderTarget(p,a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateDepthStencilSurface(p,a,b,c,d,e) (p)->lpVtbl->CreateDepthStencilSurface(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateImageSurface(p,a,b,c,d) (p)->lpVtbl->CreateImageSurface(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CopyRects(p,a,b,c,d,e) (p)->lpVtbl->CopyRects(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_UpdateTexture(p,a,b) (p)->lpVtbl->UpdateTexture(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetFrontBuffer(p,a) (p)->lpVtbl->GetFrontBuffer(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetRenderTarget(p,a,b) (p)->lpVtbl->SetRenderTarget(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetRenderTarget(p,a) (p)->lpVtbl->GetRenderTarget(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetDepthStencilSurface(p,a) (p)->lpVtbl->GetDepthStencilSurface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_BeginScene(p) (p)->lpVtbl->BeginScene(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_EndScene(p) (p)->lpVtbl->EndScene(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_Clear(p,a,b,c,d,e,f) (p)->lpVtbl->Clear(p,a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetTransform(p,a,b) (p)->lpVtbl->SetTransform(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetTransform(p,a,b) (p)->lpVtbl->GetTransform(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_MultiplyTransform(p,a,b) (p)->lpVtbl->MultiplyTransform(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetViewport(p,a) (p)->lpVtbl->SetViewport(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetViewport(p,a) (p)->lpVtbl->GetViewport(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetMaterial(p,a) (p)->lpVtbl->SetMaterial(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetMaterial(p,a) (p)->lpVtbl->GetMaterial(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetLight(p,a,b) (p)->lpVtbl->SetLight(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetLight(p,a,b) (p)->lpVtbl->GetLight(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_LightEnable(p,a,b) (p)->lpVtbl->LightEnable(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetLightEnable(p,a,b) (p)->lpVtbl->GetLightEnable(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetClipPlane(p,a,b) (p)->lpVtbl->SetClipPlane(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetClipPlane(p,a,b) (p)->lpVtbl->GetClipPlane(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetRenderState(p,a,b) (p)->lpVtbl->SetRenderState(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetRenderState(p,a,b) (p)->lpVtbl->GetRenderState(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_BeginStateBlock(p) (p)->lpVtbl->BeginStateBlock(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_EndStateBlock(p,a) (p)->lpVtbl->EndStateBlock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_ApplyStateBlock(p,a) (p)->lpVtbl->ApplyStateBlock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CaptureStateBlock(p,a) (p)->lpVtbl->CaptureStateBlock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DeleteStateBlock(p,a) (p)->lpVtbl->DeleteStateBlock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateStateBlock(p,a,b) (p)->lpVtbl->CreateStateBlock(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetClipStatus(p,a) (p)->lpVtbl->SetClipStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetClipStatus(p,a) (p)->lpVtbl->GetClipStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetTexture(p,a,b) (p)->lpVtbl->GetTexture(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetTexture(p,a,b) (p)->lpVtbl->SetTexture(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetTextureStageState(p,a,b,c) (p)->lpVtbl->GetTextureStageState(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetTextureStageState(p,a,b,c) (p)->lpVtbl->SetTextureStageState(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_ValidateDevice(p,a) (p)->lpVtbl->ValidateDevice(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetInfo(p,a,b,c) (p)->lpVtbl->GetInfo(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetPaletteEntries(p,a,b) (p)->lpVtbl->SetPaletteEntries(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetPaletteEntries(p,a,b) (p)->lpVtbl->GetPaletteEntries(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetCurrentTexturePalette(p,a) (p)->lpVtbl->SetCurrentTexturePalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetCurrentTexturePalette(p,a) (p)->lpVtbl->GetCurrentTexturePalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DrawPrimitive(p,a,b,c) (p)->lpVtbl->DrawPrimitive(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DrawIndexedPrimitive(p,a,b,c,d,e) (p)->lpVtbl->DrawIndexedPrimitive(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DrawPrimitiveUP(p,a,b,c,d) (p)->lpVtbl->DrawPrimitiveUP(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DrawIndexedPrimitiveUP(p,a,b,c,d,e,f,g,h) (p)->lpVtbl->DrawIndexedPrimitiveUP(p,a,b,c,d,e,f,g,h)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_ProcessVertices(p,a,b,c,d,e) (p)->lpVtbl->ProcessVertices(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateVertexShader(p,a,b,c,d) (p)->lpVtbl->CreateVertexShader(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetVertexShader(p,a) (p)->lpVtbl->SetVertexShader(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetVertexShader(p,a) (p)->lpVtbl->GetVertexShader(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DeleteVertexShader(p,a) (p)->lpVtbl->DeleteVertexShader(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetVertexShaderConstant(p,a,b,c) (p)->lpVtbl->SetVertexShaderConstant(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetVertexShaderConstant(p,a,b,c) (p)->lpVtbl->GetVertexShaderConstant(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetVertexShaderDeclaration(p,a,b,c) (p)->lpVtbl->GetVertexShaderDeclaration(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetVertexShaderFunction(p,a,b,c) (p)->lpVtbl->GetVertexShaderFunction(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetStreamSource(p,a,b,c) (p)->lpVtbl->SetStreamSource(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetStreamSource(p,a,b,c) (p)->lpVtbl->GetStreamSource(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetIndices(p,a,b) (p)->lpVtbl->SetIndices(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetIndices(p,a,b) (p)->lpVtbl->GetIndices(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreatePixelShader(p,a,b) (p)->lpVtbl->CreatePixelShader(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetPixelShader(p,a) (p)->lpVtbl->SetPixelShader(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetPixelShader(p,a) (p)->lpVtbl->GetPixelShader(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DeletePixelShader(p,a) (p)->lpVtbl->DeletePixelShader(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetPixelShaderConstant(p,a,b,c) (p)->lpVtbl->SetPixelShaderConstant(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetPixelShaderConstant(p,a,b,c) (p)->lpVtbl->GetPixelShaderConstant(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetPixelShaderFunction(p,a,b,c) (p)->lpVtbl->GetPixelShaderFunction(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DrawRectPatch(p,a,b,c) (p)->lpVtbl->DrawRectPatch(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DrawTriPatch(p,a,b,c) (p)->lpVtbl->DrawTriPatch(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DeletePatch(p,a) (p)->lpVtbl->DeletePatch(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_TestCooperativeLevel(p) (p)->TestCooperativeLevel()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetAvailableTextureMem(p) (p)->GetAvailableTextureMem()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_ResourceManagerDiscardBytes(p,a) (p)->ResourceManagerDiscardBytes(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetDirect3D(p,a) (p)->GetDirect3D(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetDeviceCaps(p,a) (p)->GetDeviceCaps(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetDisplayMode(p,a) (p)->GetDisplayMode(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetCreationParameters(p,a) (p)->GetCreationParameters(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetCursorProperties(p,a,b,c) (p)->SetCursorProperties(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetCursorPosition(p,a,b,c) (p)->SetCursorPosition(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_ShowCursor(p,a) (p)->ShowCursor(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateAdditionalSwapChain(p,a,b) (p)->CreateAdditionalSwapChain(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_Reset(p,a) (p)->Reset(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_Present(p,a,b,c,d) (p)->Present(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetBackBuffer(p,a,b,c) (p)->GetBackBuffer(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetRasterStatus(p,a) (p)->GetRasterStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetGammaRamp(p,a,b) (p)->SetGammaRamp(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetGammaRamp(p,a) (p)->GetGammaRamp(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateTexture(p,a,b,c,d,e,f,g) (p)->CreateTexture(a,b,c,d,e,f,g)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateVolumeTexture(p,a,b,c,d,e,f,g,h) (p)->CreateVolumeTexture(a,b,c,d,e,f,g,h)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateCubeTexture(p,a,b,c,d,e,f) (p)->CreateCubeTexture(a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateVertexBuffer(p,a,b,c,d,e) (p)->CreateVertexBuffer(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateIndexBuffer(p,a,b,c,d,e) (p)->CreateIndexBuffer(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateRenderTarget(p,a,b,c,d,e,f) (p)->CreateRenderTarget(a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateDepthStencilSurface(p,a,b,c,d,e) (p)->CreateDepthStencilSurface(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateImageSurface(p,a,b,c,d) (p)->CreateImageSurface(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CopyRects(p,a,b,c,d,e) (p)->CopyRects(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_UpdateTexture(p,a,b) (p)->UpdateTexture(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetFrontBuffer(p,a) (p)->GetFrontBuffer(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetRenderTarget(p,a,b) (p)->SetRenderTarget(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetRenderTarget(p,a) (p)->GetRenderTarget(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetDepthStencilSurface(p,a) (p)->GetDepthStencilSurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_BeginScene(p) (p)->BeginScene()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_EndScene(p) (p)->EndScene()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_Clear(p,a,b,c,d,e,f) (p)->Clear(a,b,c,d,e,f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetTransform(p,a,b) (p)->SetTransform(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetTransform(p,a,b) (p)->GetTransform(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_MultiplyTransform(p,a,b) (p)->MultiplyTransform(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetViewport(p,a) (p)->SetViewport(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetViewport(p,a) (p)->GetViewport(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetMaterial(p,a) (p)->SetMaterial(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetMaterial(p,a) (p)->GetMaterial(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetLight(p,a,b) (p)->SetLight(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetLight(p,a,b) (p)->GetLight(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_LightEnable(p,a,b) (p)->LightEnable(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetLightEnable(p,a,b) (p)->GetLightEnable(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetClipPlane(p,a,b) (p)->SetClipPlane(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetClipPlane(p,a,b) (p)->GetClipPlane(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetRenderState(p,a,b) (p)->SetRenderState(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetRenderState(p,a,b) (p)->GetRenderState(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_BeginStateBlock(p) (p)->BeginStateBlock()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_EndStateBlock(p,a) (p)->EndStateBlock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_ApplyStateBlock(p,a) (p)->ApplyStateBlock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CaptureStateBlock(p,a) (p)->CaptureStateBlock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DeleteStateBlock(p,a) (p)->DeleteStateBlock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateStateBlock(p,a,b) (p)->CreateStateBlock(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetClipStatus(p,a) (p)->SetClipStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetClipStatus(p,a) (p)->GetClipStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetTexture(p,a,b) (p)->GetTexture(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetTexture(p,a,b) (p)->SetTexture(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetTextureStageState(p,a,b,c) (p)->GetTextureStageState(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetTextureStageState(p,a,b,c) (p)->SetTextureStageState(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_ValidateDevice(p,a) (p)->ValidateDevice(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetInfo(p,a,b,c) (p)->GetInfo(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetPaletteEntries(p,a,b) (p)->SetPaletteEntries(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetPaletteEntries(p,a,b) (p)->GetPaletteEntries(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetCurrentTexturePalette(p,a) (p)->SetCurrentTexturePalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetCurrentTexturePalette(p,a) (p)->GetCurrentTexturePalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DrawPrimitive(p,a,b,c) (p)->DrawPrimitive(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DrawIndexedPrimitive(p,a,b,c,d,e) (p)->DrawIndexedPrimitive(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DrawPrimitiveUP(p,a,b,c,d) (p)->DrawPrimitiveUP(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DrawIndexedPrimitiveUP(p,a,b,c,d,e,f,g,h) (p)->DrawIndexedPrimitiveUP(a,b,c,d,e,f,g,h)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_ProcessVertices(p,a,b,c,d,e) (p)->ProcessVertices(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreateVertexShader(p,a,b,c,d) (p)->CreateVertexShader(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetVertexShader(p,a) (p)->SetVertexShader(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetVertexShader(p,a) (p)->GetVertexShader(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DeleteVertexShader(p,a) (p)->DeleteVertexShader(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetVertexShaderConstant(p,a,b,c) (p)->SetVertexShaderConstant(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetVertexShaderConstant(p,a,b,c) (p)->GetVertexShaderConstant(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetVertexShaderDeclaration(p,a,b,c) (p)->GetVertexShaderDeclaration(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetVertexShaderFunction(p,a,b,c) (p)->GetVertexShaderFunction(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetStreamSource(p,a,b,c) (p)->SetStreamSource(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetStreamSource(p,a,b,c) (p)->GetStreamSource(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetIndices(p,a,b) (p)->SetIndices(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetIndices(p,a,b) (p)->GetIndices(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_CreatePixelShader(p,a,b) (p)->CreatePixelShader(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetPixelShader(p,a) (p)->SetPixelShader(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetPixelShader(p,a) (p)->GetPixelShader(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DeletePixelShader(p,a) (p)->DeletePixelShader(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_SetPixelShaderConstant(p,a,b,c) (p)->SetPixelShaderConstant(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetPixelShaderConstant(p,a,b,c) (p)->GetPixelShaderConstant(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_GetPixelShaderFunction(p,a,b,c) (p)->GetPixelShaderFunction(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DrawRectPatch(p,a,b,c) (p)->DrawRectPatch(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DrawTriPatch(p,a,b,c) (p)->DrawTriPatch(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DDevice8_DeletePatch(p,a) (p)->DeletePatch(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirect3DSwapChain8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSwapChain8_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSwapChain8_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSwapChain8_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSwapChain8_Present(p,a,b,c,d) (p)->lpVtbl->Present(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSwapChain8_GetBackBuffer(p,a,b,c) (p)->lpVtbl->GetBackBuffer(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSwapChain8_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSwapChain8_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSwapChain8_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSwapChain8_Present(p,a,b,c,d) (p)->Present(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSwapChain8_GetBackBuffer(p,a,b,c) (p)->GetBackBuffer(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirect3DResource8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_GetDevice(p,a) (p)->lpVtbl->GetDevice(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_SetPriority(p,a) (p)->lpVtbl->SetPriority(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_GetPriority(p) (p)->lpVtbl->GetPriority(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_PreLoad(p) (p)->lpVtbl->PreLoad(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_GetType(p) (p)->lpVtbl->GetType(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_GetDevice(p,a) (p)->GetDevice(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_FreePrivateData(p,a) (p)->FreePrivateData(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_SetPriority(p,a) (p)->SetPriority(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_GetPriority(p) (p)->GetPriority()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_PreLoad(p) (p)->PreLoad()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DResource8_GetType(p) (p)->GetType()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirect3DBaseTexture8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_GetDevice(p,a) (p)->lpVtbl->GetDevice(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_SetPriority(p,a) (p)->lpVtbl->SetPriority(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_GetPriority(p) (p)->lpVtbl->GetPriority(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_PreLoad(p) (p)->lpVtbl->PreLoad(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_GetType(p) (p)->lpVtbl->GetType(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_SetLOD(p,a) (p)->lpVtbl->SetLOD(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_GetLOD(p) (p)->lpVtbl->GetLOD(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_GetLevelCount(p) (p)->lpVtbl->GetLevelCount(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_GetDevice(p,a) (p)->GetDevice(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_FreePrivateData(p,a) (p)->FreePrivateData(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_SetPriority(p,a) (p)->SetPriority(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_GetPriority(p) (p)->GetPriority()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_PreLoad(p) (p)->PreLoad()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_GetType(p) (p)->GetType()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_SetLOD(p,a) (p)->SetLOD(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_GetLOD(p) (p)->GetLOD()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DBaseTexture8_GetLevelCount(p) (p)->GetLevelCount()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirect3DTexture8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetDevice(p,a) (p)->lpVtbl->GetDevice(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_SetPriority(p,a) (p)->lpVtbl->SetPriority(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetPriority(p) (p)->lpVtbl->GetPriority(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_PreLoad(p) (p)->lpVtbl->PreLoad(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetType(p) (p)->lpVtbl->GetType(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_SetLOD(p,a) (p)->lpVtbl->SetLOD(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetLOD(p) (p)->lpVtbl->GetLOD(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetLevelCount(p) (p)->lpVtbl->GetLevelCount(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetLevelDesc(p,a,b) (p)->lpVtbl->GetLevelDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetSurfaceLevel(p,a,b) (p)->lpVtbl->GetSurfaceLevel(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_LockRect(p,a,b,c,d) (p)->lpVtbl->LockRect(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_UnlockRect(p,a) (p)->lpVtbl->UnlockRect(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_AddDirtyRect(p,a) (p)->lpVtbl->AddDirtyRect(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetDevice(p,a) (p)->GetDevice(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_FreePrivateData(p,a) (p)->FreePrivateData(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_SetPriority(p,a) (p)->SetPriority(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetPriority(p) (p)->GetPriority()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_PreLoad(p) (p)->PreLoad()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetType(p) (p)->GetType()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_SetLOD(p,a) (p)->SetLOD(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetLOD(p) (p)->GetLOD()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetLevelCount(p) (p)->GetLevelCount()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetLevelDesc(p,a,b) (p)->GetLevelDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_GetSurfaceLevel(p,a,b) (p)->GetSurfaceLevel(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_LockRect(p,a,b,c,d) (p)->LockRect(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_UnlockRect(p,a) (p)->UnlockRect(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DTexture8_AddDirtyRect(p,a) (p)->AddDirtyRect(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirect3DVolumeTexture8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetDevice(p,a) (p)->lpVtbl->GetDevice(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_SetPriority(p,a) (p)->lpVtbl->SetPriority(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetPriority(p) (p)->lpVtbl->GetPriority(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_PreLoad(p) (p)->lpVtbl->PreLoad(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetType(p) (p)->lpVtbl->GetType(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_SetLOD(p,a) (p)->lpVtbl->SetLOD(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetLOD(p) (p)->lpVtbl->GetLOD(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetLevelCount(p) (p)->lpVtbl->GetLevelCount(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetLevelDesc(p,a,b) (p)->lpVtbl->GetLevelDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetVolumeLevel(p,a,b) (p)->lpVtbl->GetVolumeLevel(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_LockBox(p,a,b,c,d) (p)->lpVtbl->LockBox(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_UnlockBox(p,a) (p)->lpVtbl->UnlockBox(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_AddDirtyBox(p,a) (p)->lpVtbl->AddDirtyBox(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetDevice(p,a) (p)->GetDevice(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_FreePrivateData(p,a) (p)->FreePrivateData(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_SetPriority(p,a) (p)->SetPriority(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetPriority(p) (p)->GetPriority()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_PreLoad(p) (p)->PreLoad()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetType(p) (p)->GetType()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_SetLOD(p,a) (p)->SetLOD(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetLOD(p) (p)->GetLOD()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetLevelCount(p) (p)->GetLevelCount()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetLevelDesc(p,a,b) (p)->GetLevelDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_GetVolumeLevel(p,a,b) (p)->GetVolumeLevel(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_LockBox(p,a,b,c,d) (p)->LockBox(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_UnlockBox(p,a) (p)->UnlockBox(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolumeTexture8_AddDirtyBox(p,a) (p)->AddDirtyBox(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirect3DCubeTexture8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetDevice(p,a) (p)->lpVtbl->GetDevice(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_SetPriority(p,a) (p)->lpVtbl->SetPriority(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetPriority(p) (p)->lpVtbl->GetPriority(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_PreLoad(p) (p)->lpVtbl->PreLoad(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetType(p) (p)->lpVtbl->GetType(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_SetLOD(p,a) (p)->lpVtbl->SetLOD(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetLOD(p) (p)->lpVtbl->GetLOD(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetLevelCount(p) (p)->lpVtbl->GetLevelCount(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetLevelDesc(p,a,b) (p)->lpVtbl->GetLevelDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetCubeMapSurface(p,a,b,c) (p)->lpVtbl->GetCubeMapSurface(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_LockRect(p,a,b,c,d,e) (p)->lpVtbl->LockRect(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_UnlockRect(p,a,b) (p)->lpVtbl->UnlockRect(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_AddDirtyRect(p,a,b) (p)->lpVtbl->AddDirtyRect(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetDevice(p,a) (p)->GetDevice(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_FreePrivateData(p,a) (p)->FreePrivateData(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_SetPriority(p,a) (p)->SetPriority(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetPriority(p) (p)->GetPriority()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_PreLoad(p) (p)->PreLoad()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetType(p) (p)->GetType()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_SetLOD(p,a) (p)->SetLOD(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetLOD(p) (p)->GetLOD()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetLevelCount(p) (p)->GetLevelCount()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetLevelDesc(p,a,b) (p)->GetLevelDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_GetCubeMapSurface(p,a,b,c) (p)->GetCubeMapSurface(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_LockRect(p,a,b,c,d,e) (p)->LockRect(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_UnlockRect(p,a,b) (p)->UnlockRect(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DCubeTexture8_AddDirtyRect(p,a,b) (p)->AddDirtyRect(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirect3DVertexBuffer8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_GetDevice(p,a) (p)->lpVtbl->GetDevice(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_SetPriority(p,a) (p)->lpVtbl->SetPriority(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_GetPriority(p) (p)->lpVtbl->GetPriority(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_PreLoad(p) (p)->lpVtbl->PreLoad(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_GetType(p) (p)->lpVtbl->GetType(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_Unlock(p) (p)->lpVtbl->Unlock(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_GetDesc(p,a) (p)->lpVtbl->GetDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_GetDevice(p,a) (p)->GetDevice(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_FreePrivateData(p,a) (p)->FreePrivateData(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_SetPriority(p,a) (p)->SetPriority(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_GetPriority(p) (p)->GetPriority()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_PreLoad(p) (p)->PreLoad()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_GetType(p) (p)->GetType()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_Unlock(p) (p)->Unlock()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVertexBuffer8_GetDesc(p,a) (p)->GetDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirect3DIndexBuffer8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_GetDevice(p,a) (p)->lpVtbl->GetDevice(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_SetPriority(p,a) (p)->lpVtbl->SetPriority(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_GetPriority(p) (p)->lpVtbl->GetPriority(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_PreLoad(p) (p)->lpVtbl->PreLoad(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_GetType(p) (p)->lpVtbl->GetType(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_Unlock(p) (p)->lpVtbl->Unlock(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_GetDesc(p,a) (p)->lpVtbl->GetDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_GetDevice(p,a) (p)->GetDevice(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_FreePrivateData(p,a) (p)->FreePrivateData(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_SetPriority(p,a) (p)->SetPriority(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_GetPriority(p) (p)->GetPriority()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_PreLoad(p) (p)->PreLoad()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_GetType(p) (p)->GetType()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_Unlock(p) (p)->Unlock()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DIndexBuffer8_GetDesc(p,a) (p)->GetDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirect3DSurface8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_GetDevice(p,a) (p)->lpVtbl->GetDevice(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_GetContainer(p,a,b) (p)->lpVtbl->GetContainer(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_GetDesc(p,a) (p)->lpVtbl->GetDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_LockRect(p,a,b,c) (p)->lpVtbl->LockRect(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_UnlockRect(p) (p)->lpVtbl->UnlockRect(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_GetDevice(p,a) (p)->GetDevice(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_FreePrivateData(p,a) (p)->FreePrivateData(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_GetContainer(p,a,b) (p)->GetContainer(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_GetDesc(p,a) (p)->GetDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_LockRect(p,a,b,c) (p)->LockRect(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DSurface8_UnlockRect(p) (p)->UnlockRect()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirect3DVolume8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_GetDevice(p,a) (p)->lpVtbl->GetDevice(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_GetContainer(p,a,b) (p)->lpVtbl->GetContainer(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_GetDesc(p,a) (p)->lpVtbl->GetDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_LockBox(p,a,b,c) (p)->lpVtbl->LockBox(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_UnlockBox(p) (p)->lpVtbl->UnlockBox(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_GetDevice(p,a) (p)->GetDevice(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_FreePrivateData(p,a) (p)->FreePrivateData(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_GetContainer(p,a,b) (p)->GetContainer(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_GetDesc(p,a) (p)->GetDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_LockBox(p,a,b,c) (p)->LockBox(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirect3DVolume8_UnlockBox(p) (p)->UnlockBox()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKE_D3DHRESULT( code ) MAKE_HRESULT( 1, _FACD3D, code )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3D_OK S_OK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_WRONGTEXTUREFORMAT MAKE_D3DHRESULT(2072)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_UNSUPPORTEDCOLOROPERATION MAKE_D3DHRESULT(2073)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_UNSUPPORTEDCOLORARG MAKE_D3DHRESULT(2074)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_UNSUPPORTEDALPHAOPERATION MAKE_D3DHRESULT(2075)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_UNSUPPORTEDALPHAARG MAKE_D3DHRESULT(2076)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_TOOMANYOPERATIONS MAKE_D3DHRESULT(2077)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_CONFLICTINGTEXTUREFILTER MAKE_D3DHRESULT(2078)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_UNSUPPORTEDFACTORVALUE MAKE_D3DHRESULT(2079)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_CONFLICTINGRENDERSTATE MAKE_D3DHRESULT(2081)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_UNSUPPORTEDTEXTUREFILTER MAKE_D3DHRESULT(2082)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_CONFLICTINGTEXTUREPALETTE MAKE_D3DHRESULT(2086)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_DRIVERINTERNALERROR MAKE_D3DHRESULT(2087)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_NOTFOUND MAKE_D3DHRESULT(2150)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_MOREDATA MAKE_D3DHRESULT(2151)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_DEVICELOST MAKE_D3DHRESULT(2152)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_DEVICENOTRESET MAKE_D3DHRESULT(2153)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_NOTAVAILABLE MAKE_D3DHRESULT(2154)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_OUTOFVIDEOMEMORY MAKE_D3DHRESULT(380)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_INVALIDDEVICE MAKE_D3DHRESULT(2155)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_INVALIDCALL MAKE_D3DHRESULT(2156)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DERR_DRIVERINVALIDCALL MAKE_D3DHRESULT(2157)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXINLINE __forceinline
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXINLINE __inline
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXINLINE inline
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_DEFAULT ULONG_MAX
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_DEFAULT_FLOAT FLT_MAX
/// ///////////////////////////////////////////////////////////////////////////
// 
//  Copyright (C) Microsoft Corporation.  All Rights Reserved.
// 
//  File:       d3dx8math.h
//  Content:    D3DX math types and functions
// 
/// ///////////////////////////////////////////////////////////////////////////



// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(disable:4201) // anonymous unions warning



// ===========================================================================
// 
// General purpose utilities
// 
// ===========================================================================
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_PI ((FLOAT) 3.141592654f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_1BYPI ((FLOAT) 0.318309886f)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXToRadian( degree ) ((degree) * (D3DX_PI / 180.0f))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXToDegree( radian ) ((radian) * (180.0f / D3DX_PI))



// ===========================================================================
// 
// Vectors
// 
// ===========================================================================

// --------------------------
// 2D Vector
// --------------------------
public partial class D3DXVECTOR2
{
#if __cplusplus
    public D3DXVECTOR2()
    {
    }

    // --------------------------
    // 2D Vector
    // --------------------------

    public D3DXINLINE D3DXVECTOR2(CONST float[] pf)
    {
#if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
#endif

        x = pf[0];
        y = pf[1];
    }

    public D3DXINLINE D3DXVECTOR2(float fx, float fy)
    {
        x = fx;
        y = fy;
    }

    // casting

    // casting
    public static D3DXINLINE implicit operator float(D3DXVECTOR2 ImpliedObject)
    {
        return (float) & ImpliedObject.x;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator CONST float* () const
    public static D3DXINLINE implicit operator CONST float(D3DXVECTOR2 ImpliedObject)
    {
        return (CONST float) & ImpliedObject.x;
    }

    // assignment operators

    // assignment operators
// C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR2 operator += (CONST D3DXVECTOR2 v)
    {
        x += v.x;
        y += v.y;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR2 operator -= (CONST D3DXVECTOR2 v)
    {
        x -= v.x;
        y -= v.y;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR2 operator *= (float f)
    {
        x *= f;
        y *= f;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR2 operator /= (float f)
    {
        float fInv = 1.0f / f;
        x *= fInv;
        y *= fInv;
        return this;
    }

    // unary operators

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR2 operator + () const
    public static D3DXINLINE D3DXVECTOR2 operator + (D3DXVECTOR2 ImpliedObject)
    {
        return ImpliedObject;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR2 operator - () const
    public static D3DXINLINE D3DXVECTOR2 operator - (D3DXVECTOR2 ImpliedObject)
    {
        return new D3DXVECTOR2(-ImpliedObject.x, -ImpliedObject.y);
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR2 operator + (CONST D3DXVECTOR2& v) const
    public static D3DXINLINE D3DXVECTOR2 operator + (D3DXVECTOR2 ImpliedObject, CONST D3DXVECTOR2 v)
    {
        return new D3DXVECTOR2(ImpliedObject.x + v.x, ImpliedObject.y + v.y);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR2 operator - (CONST D3DXVECTOR2& v) const
    public static D3DXINLINE D3DXVECTOR2 operator - (D3DXVECTOR2 ImpliedObject, CONST D3DXVECTOR2 v)
    {
        return new D3DXVECTOR2(ImpliedObject.x - v.x, ImpliedObject.y - v.y);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR2 operator * (float f) const
    public static D3DXINLINE D3DXVECTOR2 operator * (D3DXVECTOR2 ImpliedObject, float f)
    {
        return new D3DXVECTOR2(ImpliedObject.x * f, ImpliedObject.y * f);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR2 operator / (float f) const
    public static D3DXINLINE D3DXVECTOR2 operator / (D3DXVECTOR2 ImpliedObject, float f)
    {
        float fInv = 1.0f / f;
        return new D3DXVECTOR2(ImpliedObject.x * fInv, ImpliedObject.y * fInv);
    }

    public static D3DXINLINE D3DXVECTOR2 operator * (float f, CONST D3DXVECTOR2 v)
    {
        return new D3DXVECTOR2(f * v.x, f * v.y);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXVECTOR2& v) const
    public static D3DXINLINE bool operator == (D3DXVECTOR2 ImpliedObject, CONST D3DXVECTOR2 v)
    {
        return ImpliedObject.x == v.x && ImpliedObject.y == v.y;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXVECTOR2& v) const
    public static D3DXINLINE bool operator != (D3DXVECTOR2 ImpliedObject, CONST D3DXVECTOR2 v)
    {
        return ImpliedObject.x != v.x || ImpliedObject.y != v.y;
    }


#endif //__cplusplus
    public float x;
    public float y;
}


// --------------------------
// 3D Vector
// --------------------------
#if __cplusplus
public partial class D3DXVECTOR3 : _D3DVECTOR
{
    public D3DXVECTOR3()
    {
    }

    // --------------------------
    // 3D Vector
    // --------------------------
    public D3DXINLINE D3DXVECTOR3(CONST float[] pf)
    {
#if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
#endif

        x = pf[0];
        y = pf[1];
        z = pf[2];
    }

    public D3DXINLINE D3DXVECTOR3(CONST _D3DVECTOR v)
    {
        x = v.x;
        y = v.y;
        z = v.z;
    }

    public D3DXINLINE D3DXVECTOR3(float fx, float fy, float fz)
    {
        x = fx;
        y = fy;
        z = fz;
    }

    // casting
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator float* ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator CONST float* () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator CONST float* ();

    // assignment operators
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator += (CONST D3DXVECTOR3);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator -= (CONST D3DXVECTOR3);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator *= (float UnnamedParameter);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator /= (float UnnamedParameter);

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR3 operator + () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator + ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR3 operator - () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator - ();

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR3 operator + (CONST D3DXVECTOR3&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator + (CONST D3DXVECTOR3);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR3 operator - (CONST D3DXVECTOR3&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator - (CONST D3DXVECTOR3);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR3 operator * (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator * (float UnnamedParameter);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR3 operator / (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator / (float UnnamedParameter);

    public static D3DXINLINE _D3DVECTOR operator * (float f, CONST D3DXVECTOR3 v)
    {
        return struct new _D3DVECTOR(f * v.x, f * v.y, f * v.z);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator == (CONST D3DXVECTOR3&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator == (CONST D3DXVECTOR3);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator != (CONST D3DXVECTOR3&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator != (CONST D3DXVECTOR3);

}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXVECTOR3 D3DXVECTOR3;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXVECTOR3 *LPD3DXVECTOR3;

#else //!__cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _D3DVECTOR D3DXVECTOR3, *LPD3DXVECTOR3;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _D3DVECTOR *LPD3DXVECTOR3;
#endif //!__cplusplus


// --------------------------
// 4D Vector
// --------------------------
public partial class D3DXVECTOR4
{
#if __cplusplus
    public D3DXVECTOR4()
    {
    }

    // --------------------------
    // 4D Vector
    // --------------------------
    public D3DXINLINE D3DXVECTOR4(CONST float[] pf)
    {
#if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
#endif

        x = pf[0];
        y = pf[1];
        z = pf[2];
        w = pf[3];
    }

    public D3DXINLINE D3DXVECTOR4(float fx, float fy, float fz, float fw)
    {
        x = fx;
        y = fy;
        z = fz;
        w = fw;
    }

    // casting

    // casting
    public static D3DXINLINE implicit operator float(D3DXVECTOR4 ImpliedObject)
    {
        return (float) & ImpliedObject.x;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator CONST float* () const
    public static D3DXINLINE implicit operator CONST float(D3DXVECTOR4 ImpliedObject)
    {
        return (CONST float) & ImpliedObject.x;
    }

    // assignment operators

    // assignment operators
// C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR4 operator += (CONST D3DXVECTOR4 v)
    {
        x += v.x;
        y += v.y;
        z += v.z;
        w += v.w;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR4 operator -= (CONST D3DXVECTOR4 v)
    {
        x -= v.x;
        y -= v.y;
        z -= v.z;
        w -= v.w;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR4 operator *= (float f)
    {
        x *= f;
        y *= f;
        z *= f;
        w *= f;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR4 operator /= (float f)
    {
        float fInv = 1.0f / f;
        x *= fInv;
        y *= fInv;
        z *= fInv;
        w *= fInv;
        return this;
    }

    // unary operators

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR4 operator + () const
    public static D3DXINLINE D3DXVECTOR4 operator + (D3DXVECTOR4 ImpliedObject)
    {
        return ImpliedObject;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR4 operator - () const
    public static D3DXINLINE D3DXVECTOR4 operator - (D3DXVECTOR4 ImpliedObject)
    {
        return new D3DXVECTOR4(-ImpliedObject.x, -ImpliedObject.y, -ImpliedObject.z, -ImpliedObject.w);
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR4 operator + (CONST D3DXVECTOR4& v) const
    public static D3DXINLINE D3DXVECTOR4 operator + (D3DXVECTOR4 ImpliedObject, CONST D3DXVECTOR4 v)
    {
        return new D3DXVECTOR4(ImpliedObject.x + v.x, ImpliedObject.y + v.y, ImpliedObject.z + v.z, ImpliedObject.w + v.w);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR4 operator - (CONST D3DXVECTOR4& v) const
    public static D3DXINLINE D3DXVECTOR4 operator - (D3DXVECTOR4 ImpliedObject, CONST D3DXVECTOR4 v)
    {
        return new D3DXVECTOR4(ImpliedObject.x - v.x, ImpliedObject.y - v.y, ImpliedObject.z - v.z, ImpliedObject.w - v.w);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR4 operator * (float f) const
    public static D3DXINLINE D3DXVECTOR4 operator * (D3DXVECTOR4 ImpliedObject, float f)
    {
        return new D3DXVECTOR4(ImpliedObject.x * f, ImpliedObject.y * f, ImpliedObject.z * f, ImpliedObject.w * f);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR4 operator / (float f) const
    public static D3DXINLINE D3DXVECTOR4 operator / (D3DXVECTOR4 ImpliedObject, float f)
    {
        float fInv = 1.0f / f;
        return new D3DXVECTOR4(ImpliedObject.x * fInv, ImpliedObject.y * fInv, ImpliedObject.z * fInv, ImpliedObject.w * fInv);
    }

    public static D3DXINLINE D3DXVECTOR4 operator * (float f, CONST D3DXVECTOR4 v)
    {
        return new D3DXVECTOR4(f * v.x, f * v.y, f * v.z, f * v.w);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXVECTOR4& v) const
    public static D3DXINLINE bool operator == (D3DXVECTOR4 ImpliedObject, CONST D3DXVECTOR4 v)
    {
        return ImpliedObject.x == v.x && ImpliedObject.y == v.y && ImpliedObject.z == v.z && ImpliedObject.w == v.w;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXVECTOR4& v) const
    public static D3DXINLINE bool operator != (D3DXVECTOR4 ImpliedObject, CONST D3DXVECTOR4 v)
    {
        return ImpliedObject.x != v.x || ImpliedObject.y != v.y || ImpliedObject.z != v.z || ImpliedObject.w != v.w;
    }

#endif //__cplusplus
    public float x;
    public float y;
    public float z;
    public float w;
}


// ===========================================================================
// 
// Matrices
// 
// ===========================================================================
#if __cplusplus
public partial class D3DXMATRIX : _D3DMATRIX
{
    public D3DXMATRIX()
    {
    }

    // --------------------------
    // Matrix
    // --------------------------
    public D3DXINLINE D3DXMATRIX(CONST float pf)
    {
#if D3DX_DEBUG
        if (pf == null)
        {
            return;
        }
#endif

// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
        memcpy(_11, pf, sizeof(_D3DMATRIX));
    }

    public D3DXINLINE D3DXMATRIX(CONST _D3DMATRIX mat)
    {
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
        memcpy(_11, mat, sizeof(_D3DMATRIX));
    }

    public D3DXINLINE D3DXMATRIX(float f11, float f12, float f13, float f14, float f21, float f22, float f23, float f24, float f31, float f32, float f33, float f34, float f41, float f42, float f43, float f44)
    {
        _11 = f11;
        _12 = f12;
        _13 = f13;
        _14 = f14;
        _21 = f21;
        _22 = f22;
        _23 = f23;
        _24 = f24;
        _31 = f31;
        _32 = f32;
        _33 = f33;
        _34 = f34;
        _41 = f41;
        _42 = f42;
        _43 = f43;
        _44 = f44;
    }


    // access grants
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    float operator ()(uint Row, uint Col);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: float operator ()(uint Row, uint Col) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    float operator ()(uint Row, uint Col);

    // casting operators
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator float* ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator CONST float* () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator CONST float* ();

    // assignment operators
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator *= (CONST D3DXMATRIX);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator += (CONST D3DXMATRIX);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator -= (CONST D3DXMATRIX);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator *= (float UnnamedParameter);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator /= (float UnnamedParameter);

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator + () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator + ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator - () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator - ();

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator * (CONST D3DXMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator * (CONST D3DXMATRIX);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator + (CONST D3DXMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator + (CONST D3DXMATRIX);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator - (CONST D3DXMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator - (CONST D3DXMATRIX);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator * (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator * (float UnnamedParameter);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator / (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator / (float UnnamedParameter);

    public static D3DXINLINE _D3DMATRIX operator * (float f, CONST _D3DMATRIX mat)
    {
        return struct new _D3DMATRIX(f * mat._11, f * mat._12, f * mat._13, f * mat._14, f * mat._21, f * mat._22, f * mat._23, f * mat._24, f * mat._31, f * mat._32, f * mat._33, f * mat._34, f * mat._41, f * mat._42, f * mat._43, f * mat._44);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator == (CONST D3DXMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator == (CONST D3DXMATRIX);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator != (CONST D3DXMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator != (CONST D3DXMATRIX);

}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXMATRIX D3DXMATRIX;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXMATRIX *LPD3DXMATRIX;

#else //!__cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _D3DMATRIX D3DXMATRIX, *LPD3DXMATRIX;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _D3DMATRIX *LPD3DXMATRIX;
#endif //!__cplusplus

// ===========================================================================
// 
// Aligned Matrices
// 
// This class helps keep matrices 16-byte aligned as preferred by P4 cpus.
// It aligns matrices on the stack and on the heap or in global scope.
// It does this using __declspec(align(16)) which works on VC7 and on VC 6
// with the processor pack. Unfortunately there is no way to detect the 
// latter so this is turned on only on VC7. On other compilers this is the
// the same as D3DXMATRIX.
// Using this class on a compiler that does not actually do the alignment
// can be dangerous since it will not expose bugs that ignore alignment.
// E.g if an object of this class in inside a struct or class, and some code
// memcopys data in it assuming tight packing. This could break on a compiler
// that eventually start aligning the matrix.
// 
// ===========================================================================
#if __cplusplus
public partial class _D3DXMATRIXA16 : struct _D3DMATRIX
{
    public _D3DXMATRIXA16()
    {
    }
    public _D3DXMATRIXA16(CONST float f)
    {
        this.D3DXMATRIX = f;
    }
    public _D3DXMATRIXA16(CONST _D3DMATRIX m)
    {
        this.D3DXMATRIX = m;
    }
    public _D3DXMATRIXA16(float _11, float _12, float _13, float _14, float _21, float _22, float _23, float _24, float _31, float _32, float _33, float _34, float _41, float _42, float _43, float _44)
    {
        this.D3DXMATRIX = new <type missing>(_11, _12, _13, _14, _21, _22, _23, _24, _31, _32, _33, _34, _41, _42, _43, _44);
    }
// C++ TO C# CONVERTER TODO TASK: The new operator cannot be overloaded in C#:
    public static object operator new(size_t s)
    {
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
        byte * p = global::new byte[s + 16];
        if (p != 0)
        {
            byte offset = (byte)(16 - ((UIntPtr)p & 15));
            p += offset;
            p[-1] = offset;
        }
        return p;
    }

// C++ TO C# CONVERTER TODO TASK: The new[] operator cannot be overloaded in C#:
    public static object operator new[](size_t s)
    {
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
        byte * p = global::new byte[s + 16];
        if (p != 0)
        {
            byte offset = (byte)(16 - ((UIntPtr)p & 15));
            p += offset;
            p[-1] = offset;
        }
        return p;
    }

    // This is NOT a virtual operator. If you cast
    // to D3DXMATRIX, do not delete using that
// C++ TO C# CONVERTER TODO TASK: The delete operator cannot be overloaded in C#:
    public static void operator delete(object p)
    {
        if (p)
        {
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
            byte * pb = (byte)p;
            pb -= pb[-1];
            global::delete[] pb;
        }
    }

    // This is NOT a virtual operator. If you cast
    // to D3DXMATRIX, do not delete using that
// C++ TO C# CONVERTER TODO TASK: The delete[] operator cannot be overloaded in C#:
    public static void operator delete[](object p)
    {
        if (p)
        {
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
            byte * pb = (byte)p;
            pb -= pb[-1];
            global::delete[] pb;
        }
    }

// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: struct _D3DXMATRIXA16& operator =(CONST struct _D3DMATRIX& rhs)
    public _D3DXMATRIXA16 CopyFrom(CONST _D3DMATRIX rhs)
    {
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
        memcpy(_11, rhs, sizeof(_D3DMATRIX));
        return this;
    }
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DXMATRIXA16 _D3DXMATRIXA16;

#else //!__cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXMATRIX _D3DXMATRIXA16;
#endif //!__cplusplus

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER >= 1300 // VC7
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ALIGN_16 __declspec(align(16))
#define _ALIGN_16
#else
#define _ALIGN_16 // Earlier compiler may not understand this, do nothing.
#endif

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXMATRIXA16 _ALIGN_16 _D3DXMATRIXA16

// C++ TO C# CONVERTER TODO TASK: The #define macro '_ALIGN_16' was defined in multiple preprocessor conditionals and cannot be replaced in-line:

// ===========================================================================
// 
//    Quaternions
// 
// ===========================================================================
public partial class D3DXQUATERNION
{
#if __cplusplus
    public D3DXQUATERNION()
    {
    }

    // --------------------------
    // Quaternion
    // --------------------------

    public D3DXINLINE D3DXQUATERNION(CONST float[] pf)
    {
#if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
#endif

        x = pf[0];
        y = pf[1];
        z = pf[2];
        w = pf[3];
    }

    public D3DXINLINE D3DXQUATERNION(float fx, float fy, float fz, float fw)
    {
        x = fx;
        y = fy;
        z = fz;
        w = fw;
    }

    // casting

    // casting
    public static D3DXINLINE implicit operator float(D3DXQUATERNION ImpliedObject)
    {
        return (float) & ImpliedObject.x;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator CONST float* () const
    public static D3DXINLINE implicit operator CONST float(D3DXQUATERNION ImpliedObject)
    {
        return (CONST float) & ImpliedObject.x;
    }

    // assignment operators

    // assignment operators
// C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXQUATERNION operator += (CONST D3DXQUATERNION q)
    {
        x += q.x;
        y += q.y;
        z += q.z;
        w += q.w;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXQUATERNION operator -= (CONST D3DXQUATERNION q)
    {
        x -= q.x;
        y -= q.y;
        z -= q.z;
        w -= q.w;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXQUATERNION operator *= (CONST D3DXQUATERNION q)
    {
        D3DXQuaternionMultiply(this, this, q);
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXQUATERNION operator *= (float f)
    {
        x *= f;
        y *= f;
        z *= f;
        w *= f;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXQUATERNION operator /= (float f)
    {
        float fInv = 1.0f / f;
        x *= fInv;
        y *= fInv;
        z *= fInv;
        w *= fInv;
        return this;
    }

    // unary operators

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator + () const
    public static D3DXINLINE D3DXQUATERNION operator + (D3DXQUATERNION ImpliedObject)
    {
        return ImpliedObject;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator - () const
    public static D3DXINLINE D3DXQUATERNION operator - (D3DXQUATERNION ImpliedObject)
    {
        return new D3DXQUATERNION(-ImpliedObject.x, -ImpliedObject.y, -ImpliedObject.z, -ImpliedObject.w);
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator + (CONST D3DXQUATERNION& q) const
    public static D3DXINLINE D3DXQUATERNION operator + (D3DXQUATERNION ImpliedObject, CONST D3DXQUATERNION q)
    {
        return new D3DXQUATERNION(ImpliedObject.x + q.x, ImpliedObject.y + q.y, ImpliedObject.z + q.z, ImpliedObject.w + q.w);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator - (CONST D3DXQUATERNION& q) const
    public static D3DXINLINE D3DXQUATERNION operator - (D3DXQUATERNION ImpliedObject, CONST D3DXQUATERNION q)
    {
        return new D3DXQUATERNION(ImpliedObject.x - q.x, ImpliedObject.y - q.y, ImpliedObject.z - q.z, ImpliedObject.w - q.w);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator * (CONST D3DXQUATERNION& q) const
    public static D3DXINLINE D3DXQUATERNION operator * (D3DXQUATERNION ImpliedObject, CONST D3DXQUATERNION q)
    {
        D3DXQUATERNION qT = new ImpliedObject.D3DXQUATERNION();
        D3DXQuaternionMultiply(qT, ImpliedObject, q);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return qT;
        return new D3DXQUATERNION(qT);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator * (float f) const
    public static D3DXINLINE D3DXQUATERNION operator * (D3DXQUATERNION ImpliedObject, float f)
    {
        return new D3DXQUATERNION(ImpliedObject.x * f, ImpliedObject.y * f, ImpliedObject.z * f, ImpliedObject.w * f);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator / (float f) const
    public static D3DXINLINE D3DXQUATERNION operator / (D3DXQUATERNION ImpliedObject, float f)
    {
        float fInv = 1.0f / f;
        return new D3DXQUATERNION(ImpliedObject.x * fInv, ImpliedObject.y * fInv, ImpliedObject.z * fInv, ImpliedObject.w * fInv);
    }

    public static D3DXINLINE D3DXQUATERNION operator * (float f, CONST D3DXQUATERNION q)
    {
        return new D3DXQUATERNION(f * q.x, f * q.y, f * q.z, f * q.w);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXQUATERNION& q) const
    public static D3DXINLINE bool operator == (D3DXQUATERNION ImpliedObject, CONST D3DXQUATERNION q)
    {
        return ImpliedObject.x == q.x && ImpliedObject.y == q.y && ImpliedObject.z == q.z && ImpliedObject.w == q.w;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXQUATERNION& q) const
    public static D3DXINLINE bool operator != (D3DXQUATERNION ImpliedObject, CONST D3DXQUATERNION q)
    {
        return ImpliedObject.x != q.x || ImpliedObject.y != q.y || ImpliedObject.z != q.z || ImpliedObject.w != q.w;
    }

#endif //__cplusplus
    public float x;
    public float y;
    public float z;
    public float w;
}


// ===========================================================================
// 
// Planes
// 
// ===========================================================================
public partial class D3DXPLANE
{
#if __cplusplus
    public D3DXPLANE()
    {
    }

    // --------------------------
    // Plane
    // --------------------------

    public D3DXINLINE D3DXPLANE(CONST float[] pf)
    {
#if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
#endif

        a = pf[0];
        b = pf[1];
        c = pf[2];
        d = pf[3];
    }

    public D3DXINLINE D3DXPLANE(float fa, float fb, float fc, float fd)
    {
        a = fa;
        b = fb;
        c = fc;
        d = fd;
    }

    // casting

    // casting
    public static D3DXINLINE implicit operator float(D3DXPLANE ImpliedObject)
    {
        return (float) & ImpliedObject.a;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator CONST float* () const
    public static D3DXINLINE implicit operator CONST float(D3DXPLANE ImpliedObject)
    {
        return (CONST float) & ImpliedObject.a;
    }

    // unary operators

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXPLANE operator + () const
    public static D3DXINLINE D3DXPLANE operator + (D3DXPLANE ImpliedObject)
    {
        return ImpliedObject;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXPLANE operator - () const
    public static D3DXINLINE D3DXPLANE operator - (D3DXPLANE ImpliedObject)
    {
        return new D3DXPLANE(-ImpliedObject.a, -ImpliedObject.b, -ImpliedObject.c, -ImpliedObject.d);
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXPLANE& p) const
    public static D3DXINLINE bool operator == (D3DXPLANE ImpliedObject, CONST D3DXPLANE p)
    {
        return ImpliedObject.a == p.a && ImpliedObject.b == p.b && ImpliedObject.c == p.c && ImpliedObject.d == p.d;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXPLANE& p) const
    public static D3DXINLINE bool operator != (D3DXPLANE ImpliedObject, CONST D3DXPLANE p)
    {
        return ImpliedObject.a != p.a || ImpliedObject.b != p.b || ImpliedObject.c != p.c || ImpliedObject.d != p.d;
    }

#endif //__cplusplus
    public float a;
    public float b;
    public float c;
    public float d;
}


// ===========================================================================
// 
// Colors
// 
// ===========================================================================

public partial class D3DXCOLOR
{
#if __cplusplus
    public D3DXCOLOR()
    {
    }

    // --------------------------
    // Color
    // --------------------------

    public D3DXINLINE D3DXCOLOR(uint dw)
    {
        CONST float f = 1.0f / 255.0f;
        r = f * (float)(byte)(dw >> 16);
        g = f * (float)(byte)(dw >> 8);
        b = f * (float)(byte)(dw >> 0);
        a = f * (float)(byte)(dw >> 24);
    }

    public D3DXINLINE D3DXCOLOR(CONST float[] pf)
    {
#if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
#endif

        r = pf[0];
        g = pf[1];
        b = pf[2];
        a = pf[3];
    }

    public D3DXINLINE D3DXCOLOR(CONST _D3DCOLORVALUE c)
    {
        r = c.r;
        g = c.g;
        b = c.b;
        a = c.a;
    }

    public D3DXINLINE D3DXCOLOR(float fr, float fg, float fb, float fa)
    {
        r = fr;
        g = fg;
        b = fb;
        a = fa;
    }

    // casting

    // casting
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator uint() const
    public static D3DXINLINE implicit operator uint(D3DXCOLOR ImpliedObject)
    {
        uint dwR = ImpliedObject.r >= 1.0f ? 0xff : (uint)(ImpliedObject.r <= 0.0f ? 0x00 : (uint)(ImpliedObject.r * 255.0f + 0.5f));
        uint dwG = ImpliedObject.g >= 1.0f ? 0xff : (uint)(ImpliedObject.g <= 0.0f ? 0x00 : (uint)(ImpliedObject.g * 255.0f + 0.5f));
        uint dwB = ImpliedObject.b >= 1.0f ? 0xff : (uint)(ImpliedObject.b <= 0.0f ? 0x00 : (uint)(ImpliedObject.b * 255.0f + 0.5f));
        uint dwA = ImpliedObject.a >= 1.0f ? 0xff : (uint)(ImpliedObject.a <= 0.0f ? 0x00 : (uint)(ImpliedObject.a * 255.0f + 0.5f));

        return (dwA << 24) | (dwR << 16) | (dwG << 8) | dwB;
    }

    public static D3DXINLINE D3DXCOLOR.implicit operator float (D3DXCOLOR ImpliedObject)
    {
        return (float) & ImpliedObject.r;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR::operator CONST float * () const
    public static D3DXINLINE D3DXCOLOR.implicit operator CONST float (D3DXCOLOR ImpliedObject)
    {
        return (CONST float) & ImpliedObject.r;
    }

    public static D3DXINLINE D3DXCOLOR.operator _D3DCOLORVALUE * ()
    {
        return (_D3DCOLORVALUE) & r;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR::operator CONST _D3DCOLORVALUE * () const
    public static D3DXINLINE D3DXCOLOR.implicit operator CONST _D3DCOLORVALUE (D3DXCOLOR ImpliedObject)
    {
        return (CONST _D3DCOLORVALUE) & ImpliedObject.r;
    }

    public static D3DXINLINE operator _D3DCOLORVALUE & ()
    {
        return ((_D3DCOLORVALUE) & r);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator CONST _D3DCOLORVALUE& () const
    public static D3DXINLINE implicit operator CONST _D3DCOLORVALUE & (D3DXCOLOR ImpliedObject)
    {
        return ((CONST _D3DCOLORVALUE) & ImpliedObject.r);
    }

    // assignment operators

    // assignment operators
// C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXCOLOR operator += (CONST D3DXCOLOR c)
    {
        r += c.r;
        g += c.g;
        b += c.b;
        a += c.a;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXCOLOR operator -= (CONST D3DXCOLOR c)
    {
        r -= c.r;
        g -= c.g;
        b -= c.b;
        a -= c.a;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXCOLOR operator *= (float f)
    {
        r *= f;
        g *= f;
        b *= f;
        a *= f;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXCOLOR operator /= (float f)
    {
        float fInv = 1.0f / f;
        r *= fInv;
        g *= fInv;
        b *= fInv;
        a *= fInv;
        return this;
    }

    // unary operators

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR operator + () const
    public static D3DXINLINE D3DXCOLOR operator + (D3DXCOLOR ImpliedObject)
    {
        return ImpliedObject;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR operator - () const
    public static D3DXINLINE D3DXCOLOR operator - (D3DXCOLOR ImpliedObject)
    {
        return new D3DXCOLOR(-ImpliedObject.r, -ImpliedObject.g, -ImpliedObject.b, -ImpliedObject.a);
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR operator + (CONST D3DXCOLOR& c) const
    public static D3DXINLINE D3DXCOLOR operator + (D3DXCOLOR ImpliedObject, CONST D3DXCOLOR c)
    {
        return new D3DXCOLOR(ImpliedObject.r + c.r, ImpliedObject.g + c.g, ImpliedObject.b + c.b, ImpliedObject.a + c.a);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR operator - (CONST D3DXCOLOR& c) const
    public static D3DXINLINE D3DXCOLOR operator - (D3DXCOLOR ImpliedObject, CONST D3DXCOLOR c)
    {
        return new D3DXCOLOR(ImpliedObject.r - c.r, ImpliedObject.g - c.g, ImpliedObject.b - c.b, ImpliedObject.a - c.a);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR operator * (float f) const
    public static D3DXINLINE D3DXCOLOR operator * (D3DXCOLOR ImpliedObject, float f)
    {
        return new D3DXCOLOR(ImpliedObject.r * f, ImpliedObject.g * f, ImpliedObject.b * f, ImpliedObject.a * f);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR operator / (float f) const
    public static D3DXINLINE D3DXCOLOR operator / (D3DXCOLOR ImpliedObject, float f)
    {
        float fInv = 1.0f / f;
        return new D3DXCOLOR(ImpliedObject.r * fInv, ImpliedObject.g * fInv, ImpliedObject.b * fInv, ImpliedObject.a * fInv);
    }

    public static D3DXINLINE D3DXCOLOR operator * (float f, CONST D3DXCOLOR c)
    {
        return new D3DXCOLOR(f * c.r, f * c.g, f * c.b, f * c.a);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXCOLOR& c) const
    public static D3DXINLINE bool operator == (D3DXCOLOR ImpliedObject, CONST D3DXCOLOR c)
    {
        return ImpliedObject.r == c.r && ImpliedObject.g == c.g && ImpliedObject.b == c.b && ImpliedObject.a == c.a;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXCOLOR& c) const
    public static D3DXINLINE bool operator != (D3DXCOLOR ImpliedObject, CONST D3DXCOLOR c)
    {
        return ImpliedObject.r != c.r || ImpliedObject.g != c.g || ImpliedObject.b != c.b || ImpliedObject.a != c.a;
    }

#endif //__cplusplus
    public float r;
    public float g;
    public float b;
    public float a;
}




// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(default:4201)


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXBuffer
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXFont
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DrawText DrawTextW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DrawText DrawTextA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXSprite
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXRenderToSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXRenderToEnvMap
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXASM_DEBUG (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXASM_SKIPVALIDATION (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXAssembleShaderFromFile D3DXAssembleShaderFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXAssembleShaderFromFile D3DXAssembleShaderFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXAssembleShaderFromResource D3DXAssembleShaderFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXAssembleShaderFromResource D3DXAssembleShaderFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGetErrorString D3DXGetErrorStringW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGetErrorString D3DXGetErrorStringA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_NONE (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_POINT (2 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_LINEAR (3 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_TRIANGLE (4 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_BOX (5 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_MIRROR_U (1 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_MIRROR_V (2 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_MIRROR_W (4 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_MIRROR (7 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_DITHER (8 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_NORMALMAP_MIRROR_U (1 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_NORMALMAP_MIRROR_V (2 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_NORMALMAP_MIRROR (3 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_NORMALMAP_INVERTSIGN (8 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_NORMALMAP_COMPUTE_OCCLUSION (16 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_CHANNEL_RED (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_CHANNEL_BLUE (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_CHANNEL_GREEN (1 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_CHANNEL_ALPHA (1 << 3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_CHANNEL_LUMINANCE (1 << 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGetImageInfoFromFile D3DXGetImageInfoFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGetImageInfoFromFile D3DXGetImageInfoFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGetImageInfoFromResource D3DXGetImageInfoFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGetImageInfoFromResource D3DXGetImageInfoFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadSurfaceFromFile D3DXLoadSurfaceFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadSurfaceFromFile D3DXLoadSurfaceFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadSurfaceFromResource D3DXLoadSurfaceFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadSurfaceFromResource D3DXLoadSurfaceFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveSurfaceToFile D3DXSaveSurfaceToFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveSurfaceToFile D3DXSaveSurfaceToFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadVolumeFromFile D3DXLoadVolumeFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadVolumeFromFile D3DXLoadVolumeFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadVolumeFromResource D3DXLoadVolumeFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadVolumeFromResource D3DXLoadVolumeFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveVolumeToFile D3DXSaveVolumeToFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveVolumeToFile D3DXSaveVolumeToFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromFile D3DXCreateTextureFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromFile D3DXCreateTextureFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromFile D3DXCreateCubeTextureFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromFile D3DXCreateCubeTextureFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromFile D3DXCreateVolumeTextureFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromFile D3DXCreateVolumeTextureFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromResource D3DXCreateTextureFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromResource D3DXCreateTextureFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromResource D3DXCreateCubeTextureFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromResource D3DXCreateCubeTextureFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromResource D3DXCreateVolumeTextureFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromResource D3DXCreateVolumeTextureFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromFileEx D3DXCreateTextureFromFileExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromFileEx D3DXCreateTextureFromFileExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromFileEx D3DXCreateCubeTextureFromFileExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromFileEx D3DXCreateCubeTextureFromFileExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromFileEx D3DXCreateVolumeTextureFromFileExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromFileEx D3DXCreateVolumeTextureFromFileExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromResourceEx D3DXCreateTextureFromResourceExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromResourceEx D3DXCreateTextureFromResourceExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromResourceEx D3DXCreateCubeTextureFromResourceExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromResourceEx D3DXCreateCubeTextureFromResourceExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromResourceEx D3DXCreateVolumeTextureFromResourceExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromResourceEx D3DXCreateVolumeTextureFromResourceExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveTextureToFile D3DXSaveTextureToFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveTextureToFile D3DXSaveTextureToFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFilterCubeTexture D3DXFilterTexture
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFilterVolumeTexture D3DXFilterTexture
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define WIN_TYPES(itype, ptype) typedef interface itype *LP##ptype, **LPLP##ptype
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IUNKNOWN_METHODS(kind) STDMETHOD(QueryInterface) (THIS_ REFIID riid, LPVOID *ppvObj) kind; STDMETHOD_(ULONG, AddRef) (THIS) kind; STDMETHOD_(ULONG, Release) (THIS) kind
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDIRECTXFILEOBJECT_METHODS(kind) STDMETHOD(GetName) (THIS_ LPSTR, LPDWORD) kind; STDMETHOD(GetId) (THIS_ LPGUID) kind
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectXFile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectXFileEnumObject
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectXFileSaveObject
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectXFileObject
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectXFileData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectXFileDataReference
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectXFileBinary
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKE_DDHRESULT( code ) MAKE_HRESULT( 1, _FACDD, code )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADOBJECT MAKE_DDHRESULT(850)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADVALUE MAKE_DDHRESULT(851)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADTYPE MAKE_DDHRESULT(852)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADSTREAMHANDLE MAKE_DDHRESULT(853)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADALLOC MAKE_DDHRESULT(854)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_NOTFOUND MAKE_DDHRESULT(855)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_NOTDONEYET MAKE_DDHRESULT(856)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_FILENOTFOUND MAKE_DDHRESULT(857)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_RESOURCENOTFOUND MAKE_DDHRESULT(858)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_URLNOTFOUND MAKE_DDHRESULT(859)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADRESOURCE MAKE_DDHRESULT(860)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADFILETYPE MAKE_DDHRESULT(861)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADFILEVERSION MAKE_DDHRESULT(862)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADFILEFLOATSIZE MAKE_DDHRESULT(863)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADFILECOMPRESSIONTYPE MAKE_DDHRESULT(864)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADFILE MAKE_DDHRESULT(865)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_PARSEERROR MAKE_DDHRESULT(866)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_NOTEMPLATE MAKE_DDHRESULT(867)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADARRAYSIZE MAKE_DDHRESULT(868)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADDATAREFERENCE MAKE_DDHRESULT(869)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_INTERNALERROR MAKE_DDHRESULT(870)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_NOMOREOBJECTS MAKE_DDHRESULT(871)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADINTRINSICS MAKE_DDHRESULT(872)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_NOMORESTREAMHANDLES MAKE_DDHRESULT(873)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_NOMOREDATA MAKE_DDHRESULT(874)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_BADCACHEFILE MAKE_DDHRESULT(875)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXFILEERR_NOINTERNET MAKE_DDHRESULT(876)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXBaseMesh
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXMesh
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXPMesh
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXSPMesh
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define UNUSED16 (0xffff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define UNUSED32 (0xffffffff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXSkinMesh
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateText D3DXCreateTextW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateText D3DXCreateTextA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFX_DONOTSAVESTATE (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXEffect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateEffectFromFile D3DXCreateEffectFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateEffectFromFile D3DXCreateEffectFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateEffectFromResource D3DXCreateEffectFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateEffectFromResource D3DXCreateEffectFromResourceA


// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(disable:4201) // anonymous unions warning



// ===========================================================================
// 
// General purpose utilities
// 
// ===========================================================================
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_PI ((FLOAT) 3.141592654f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_1BYPI ((FLOAT) 0.318309886f)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXToRadian( degree ) ((degree) * (D3DX_PI / 180.0f))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXToDegree( radian ) ((radian) * (180.0f / D3DX_PI))



// ===========================================================================
// 
// Vectors
// 
// ===========================================================================

// --------------------------
// 2D Vector
// --------------------------
public partial class D3DXVECTOR2
{
#if __cplusplus
    public D3DXVECTOR2()
    {
    }
    public D3DXINLINE D3DXVECTOR2(CONST float[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        x = pf[0];
        y = pf[1];
    }
    public D3DXINLINE D3DXVECTOR2(float fx, float fy)
    {
        x = fx;
        y = fy;
    }

    // casting
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator float* ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator CONST float* () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator CONST float* ();

    // assignment operators
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR2 operator += (CONST D3DXVECTOR2);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR2 operator -= (CONST D3DXVECTOR2);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR2 operator *= (float UnnamedParameter);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR2 operator /= (float UnnamedParameter);

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR2 operator + () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR2 operator + ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR2 operator - () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR2 operator - ();

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR2 operator + (CONST D3DXVECTOR2&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR2 operator + (CONST D3DXVECTOR2);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR2 operator - (CONST D3DXVECTOR2&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR2 operator - (CONST D3DXVECTOR2);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR2 operator * (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR2 operator * (float UnnamedParameter);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR2 operator / (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR2 operator / (float UnnamedParameter);

// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' function:
// ORIGINAL LINE: friend D3DXVECTOR2 operator * (float, CONST D3DXVECTOR2&);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR2 operator * (float UnnamedParameter, CONST D3DXVECTOR2);

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator == (CONST D3DXVECTOR2&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator == (CONST D3DXVECTOR2);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator != (CONST D3DXVECTOR2&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator != (CONST D3DXVECTOR2);


#endif //__cplusplus
    public float x;
    public float y;
}


// --------------------------
// 3D Vector
// --------------------------
#if __cplusplus
public partial class D3DXVECTOR3 : _D3DVECTOR
{
    public D3DXVECTOR3()
    {
    }
    public D3DXINLINE D3DXVECTOR3(CONST float[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        x = pf[0];
        y = pf[1];
        z = pf[2];
    }
    public D3DXINLINE D3DXVECTOR3(CONST D3DVECTOR v)
    {
        x = v.x;
        y = v.y;
        z = v.z;
    }
    public D3DXINLINE D3DXVECTOR3(float fx, float fy, float fz)
    {
        x = fx;
        y = fy;
        z = fz;
    }

    // casting
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator float* ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator CONST float* () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator CONST float* ();

    // assignment operators
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DVECTOR operator += (CONST _D3DVECTOR);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DVECTOR operator -= (CONST _D3DVECTOR);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DVECTOR operator *= (float UnnamedParameter);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DVECTOR operator /= (float UnnamedParameter);

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: struct _D3DVECTOR operator + () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DVECTOR operator + ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: struct _D3DVECTOR operator - () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DVECTOR operator - ();

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: struct _D3DVECTOR operator + (CONST struct _D3DVECTOR&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DVECTOR operator + (CONST _D3DVECTOR);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: struct _D3DVECTOR operator - (CONST struct _D3DVECTOR&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DVECTOR operator - (CONST _D3DVECTOR);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: struct _D3DVECTOR operator * (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DVECTOR operator * (float UnnamedParameter);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: struct _D3DVECTOR operator / (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DVECTOR operator / (float UnnamedParameter);

// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//    friend struct _D3DVECTOR operator * (float, CONST struct D3DXVECTOR3&);

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator == (CONST struct _D3DVECTOR&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator == (CONST _D3DVECTOR);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator != (CONST struct _D3DVECTOR&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator != (CONST _D3DVECTOR);

}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXVECTOR3 D3DXVECTOR3;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXVECTOR3 *LPD3DXVECTOR3;

#else //!__cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _D3DVECTOR D3DXVECTOR3, *LPD3DXVECTOR3;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _D3DVECTOR *LPD3DXVECTOR3;
#endif //!__cplusplus


// --------------------------
// 4D Vector
// --------------------------
public partial class D3DXVECTOR4
{
#if __cplusplus
    public D3DXVECTOR4()
    {
    }
    public D3DXINLINE D3DXVECTOR4(CONST float[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        x = pf[0];
        y = pf[1];
        z = pf[2];
        w = pf[3];
    }
    public D3DXINLINE D3DXVECTOR4(float fx, float fy, float fz, float fw)
    {
        x = fx;
        y = fy;
        z = fz;
        w = fw;
    }

    // casting
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator float* ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator CONST float* () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator CONST float* ();

    // assignment operators
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR4 operator += (CONST D3DXVECTOR4);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR4 operator -= (CONST D3DXVECTOR4);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR4 operator *= (float UnnamedParameter);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR4 operator /= (float UnnamedParameter);

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR4 operator + () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR4 operator + ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR4 operator - () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR4 operator - ();

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR4 operator + (CONST D3DXVECTOR4&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR4 operator + (CONST D3DXVECTOR4);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR4 operator - (CONST D3DXVECTOR4&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR4 operator - (CONST D3DXVECTOR4);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR4 operator * (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR4 operator * (float UnnamedParameter);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR4 operator / (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR4 operator / (float UnnamedParameter);

// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' function:
// ORIGINAL LINE: friend D3DXVECTOR4 operator * (float, CONST D3DXVECTOR4&);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR4 operator * (float UnnamedParameter, CONST D3DXVECTOR4);

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator == (CONST D3DXVECTOR4&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator == (CONST D3DXVECTOR4);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator != (CONST D3DXVECTOR4&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator != (CONST D3DXVECTOR4);

#endif //__cplusplus
    public float x;
    public float y;
    public float z;
    public float w;
}


// ===========================================================================
// 
// Matrices
// 
// ===========================================================================
#if __cplusplus
public partial class D3DXMATRIX : _D3DMATRIX
{
    public D3DXMATRIX()
    {
    }
    public D3DXINLINE D3DXMATRIX(CONST float pf)
    {
    #if D3DX_DEBUG
        if (pf == null)
        {
            return;
        }
    #endif
    
    // C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
        memcpy(_11, pf, sizeof(D3DXMATRIX));
    }
    public D3DXINLINE D3DXMATRIX(CONST D3DMATRIX mat)
    {
    // C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
        memcpy(_11, mat, sizeof(D3DXMATRIX));
    }
    public D3DXINLINE D3DXMATRIX(float f11, float f12, float f13, float f14, float f21, float f22, float f23, float f24, float f31, float f32, float f33, float f34, float f41, float f42, float f43, float f44)
    {
        _11 = f11;
        _12 = f12;
        _13 = f13;
        _14 = f14;
        _21 = f21;
        _22 = f22;
        _23 = f23;
        _24 = f24;
        _31 = f31;
        _32 = f32;
        _33 = f33;
        _34 = f34;
        _41 = f41;
        _42 = f42;
        _43 = f43;
        _44 = f44;
    }


    // access grants
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    float operator ()(uint Row, uint Col);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: float operator ()(uint Row, uint Col) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    float operator ()(uint Row, uint Col);

    // casting operators
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator float* ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator CONST float* () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator CONST float* ();

    // assignment operators
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DMATRIX operator *= (CONST _D3DMATRIX);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DMATRIX operator += (CONST _D3DMATRIX);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DMATRIX operator -= (CONST _D3DMATRIX);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DMATRIX operator *= (float UnnamedParameter);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DMATRIX operator /= (float UnnamedParameter);

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: struct _D3DMATRIX operator + () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DMATRIX operator + ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: struct _D3DMATRIX operator - () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DMATRIX operator - ();

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: struct _D3DMATRIX operator * (CONST struct _D3DMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DMATRIX operator * (CONST _D3DMATRIX);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: struct _D3DMATRIX operator + (CONST struct _D3DMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DMATRIX operator + (CONST _D3DMATRIX);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: struct _D3DMATRIX operator - (CONST struct _D3DMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DMATRIX operator - (CONST _D3DMATRIX);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: struct _D3DMATRIX operator * (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DMATRIX operator * (float UnnamedParameter);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: struct _D3DMATRIX operator / (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DMATRIX operator / (float UnnamedParameter);

// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//    friend struct _D3DMATRIX operator * (float, CONST struct _D3DMATRIX&);

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator == (CONST struct _D3DMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator == (CONST _D3DMATRIX);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator != (CONST struct _D3DMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator != (CONST _D3DMATRIX);

}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXMATRIX D3DXMATRIX;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXMATRIX *LPD3DXMATRIX;

#else //!__cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _D3DMATRIX D3DXMATRIX, *LPD3DXMATRIX;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _D3DMATRIX *LPD3DXMATRIX;
#endif //!__cplusplus

// ===========================================================================
// 
// Aligned Matrices
// 
// This class helps keep matrices 16-byte aligned as preferred by P4 cpus.
// It aligns matrices on the stack and on the heap or in global scope.
// It does this using __declspec(align(16)) which works on VC7 and on VC 6
// with the processor pack. Unfortunately there is no way to detect the 
// latter so this is turned on only on VC7. On other compilers this is the
// the same as D3DXMATRIX.
// Using this class on a compiler that does not actually do the alignment
// can be dangerous since it will not expose bugs that ignore alignment.
// E.g if an object of this class in inside a struct or class, and some code
// memcopys data in it assuming tight packing. This could break on a compiler
// that eventually start aligning the matrix.
// 
// ===========================================================================
#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: The typedef 'D3DXMATRIX' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
public partial class _D3DXMATRIXA16 : D3DXMATRIX
{
    public _D3DXMATRIXA16()
    {
    }
// C++ TO C# CONVERTER TODO TASK: The typedef 'D3DXMATRIX' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
    public _D3DXMATRIXA16(CONST float f) : base.functorMethod(f)
    {
    }
// C++ TO C# CONVERTER TODO TASK: The typedef 'D3DXMATRIX' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
    public _D3DXMATRIXA16(CONST _D3DMATRIX m) : base.functorMethod(m)
    {
    }
// C++ TO C# CONVERTER TODO TASK: The typedef 'D3DXMATRIX' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
    public _D3DXMATRIXA16(float _11, float _12, float _13, float _14, float _21, float _22, float _23, float _24, float _31, float _32, float _33, float _34, float _41, float _42, float _43, float _44) : base.functorMethod(_11, _12, _13, _14, _21, _22, _23, _24, _31, _32, _33, _34, _41, _42, _43, _44)
    {
    }
// C++ TO C# CONVERTER TODO TASK: The new operator cannot be overloaded in C#:
    public static object operator new(size_t s)
    {
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
        byte * p = global::new byte[s + 16];
        if (p != 0)
        {
            byte offset = (byte)(16 - ((UIntPtr)p & 15));
            p += offset;
            p[-1] = offset;
        }
        return p;
    }

// C++ TO C# CONVERTER TODO TASK: The new[] operator cannot be overloaded in C#:
    public static object operator new[](size_t s)
    {
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
        byte * p = global::new byte[s + 16];
        if (p != 0)
        {
            byte offset = (byte)(16 - ((UIntPtr)p & 15));
            p += offset;
            p[-1] = offset;
        }
        return p;
    }

    // This is NOT a virtual operator. If you cast
    // to D3DXMATRIX, do not delete using that
// C++ TO C# CONVERTER TODO TASK: The delete operator cannot be overloaded in C#:
    public static void operator delete(object p)
    {
        if (p)
        {
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
            byte * pb = (byte)p;
            pb -= pb[-1];
            global::delete[] pb;
        }
    }

    // This is NOT a virtual operator. If you cast
    // to D3DXMATRIX, do not delete using that
// C++ TO C# CONVERTER TODO TASK: The delete[] operator cannot be overloaded in C#:
    public static void operator delete[](object p)
    {
        if (p)
        {
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
            byte * pb = (byte)p;
            pb -= pb[-1];
            global::delete[] pb;
        }
    }

// C++ TO C# CONVERTER TODO TASK: The typedef 'D3DXMATRIX' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: struct _D3DXMATRIXA16& operator =(CONST D3DXMATRIX& rhs)
    public _D3DXMATRIXA16 CopyFrom(CONST D3DXMATRIX rhs)
    {
// C++ TO C# CONVERTER TODO TASK: The typedef 'D3DXMATRIX' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
        memcpy(_11, rhs, sizeof(D3DXMATRIX));
        return this;
    }
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DXMATRIXA16 _D3DXMATRIXA16;

#else //!__cplusplus
// C++ TO C# CONVERTER TODO TASK: The typedef 'D3DXMATRIX' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXMATRIX _D3DXMATRIXA16;
#endif //!__cplusplus

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER >= 1300 // VC7
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ALIGN_16 __declspec(align(16))
#define _ALIGN_16
#else
#define _ALIGN_16 // Earlier compiler may not understand this, do nothing.
#endif

// C++ TO C# CONVERTER TODO TASK: The typedef '_D3DXMATRIXA16' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXMATRIXA16 _ALIGN_16 _D3DXMATRIXA16

// C++ TO C# CONVERTER TODO TASK: The #define macro '_ALIGN_16' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The typedef '_D3DXMATRIXA16' was defined in multiple preprocessor conditionals and cannot be replaced in-line:

// ===========================================================================
// 
//    Quaternions
// 
// ===========================================================================
public partial class D3DXQUATERNION
{
#if __cplusplus
    public D3DXQUATERNION()
    {
    }
    public D3DXINLINE D3DXQUATERNION(CONST float[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        x = pf[0];
        y = pf[1];
        z = pf[2];
        w = pf[3];
    }
    public D3DXINLINE D3DXQUATERNION(float fx, float fy, float fz, float fw)
    {
        x = fx;
        y = fy;
        z = fz;
        w = fw;
    }

    // casting
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator float* ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator CONST float* () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator CONST float* ();

    // assignment operators
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXQUATERNION operator += (CONST D3DXQUATERNION);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXQUATERNION operator -= (CONST D3DXQUATERNION);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXQUATERNION operator *= (CONST D3DXQUATERNION);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXQUATERNION operator *= (float UnnamedParameter);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXQUATERNION operator /= (float UnnamedParameter);

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXQUATERNION operator + () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXQUATERNION operator + ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXQUATERNION operator - () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXQUATERNION operator - ();

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXQUATERNION operator + (CONST D3DXQUATERNION&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXQUATERNION operator + (CONST D3DXQUATERNION);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXQUATERNION operator - (CONST D3DXQUATERNION&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXQUATERNION operator - (CONST D3DXQUATERNION);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXQUATERNION operator * (CONST D3DXQUATERNION&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXQUATERNION operator * (CONST D3DXQUATERNION);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXQUATERNION operator * (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXQUATERNION operator * (float UnnamedParameter);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXQUATERNION operator / (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXQUATERNION operator / (float UnnamedParameter);

// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' function:
// ORIGINAL LINE: friend D3DXQUATERNION operator * (float, CONST D3DXQUATERNION&);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXQUATERNION operator * (float UnnamedParameter, CONST D3DXQUATERNION);

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator == (CONST D3DXQUATERNION&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator == (CONST D3DXQUATERNION);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator != (CONST D3DXQUATERNION&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator != (CONST D3DXQUATERNION);

#endif //__cplusplus
    public float x;
    public float y;
    public float z;
    public float w;
}


// ===========================================================================
// 
// Planes
// 
// ===========================================================================
public partial class D3DXPLANE
{
#if __cplusplus
    public D3DXPLANE()
    {
    }
    public D3DXINLINE D3DXPLANE(CONST float[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        a = pf[0];
        b = pf[1];
        c = pf[2];
        d = pf[3];
    }
    public D3DXINLINE D3DXPLANE(float fa, float fb, float fc, float fd)
    {
        a = fa;
        b = fb;
        c = fc;
        d = fd;
    }

    // casting
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator float* ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator CONST float* () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator CONST float* ();

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXPLANE operator + () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXPLANE operator + ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXPLANE operator - () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXPLANE operator - ();

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator == (CONST D3DXPLANE&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator == (CONST D3DXPLANE);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator != (CONST D3DXPLANE&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator != (CONST D3DXPLANE);

#endif //__cplusplus
    public float a;
    public float b;
    public float c;
    public float d;
}


// ===========================================================================
// 
// Colors
// 
// ===========================================================================

public partial class D3DXCOLOR
{
#if __cplusplus
    public D3DXCOLOR()
    {
    }
    public D3DXINLINE D3DXCOLOR(uint dw)
    {
        CONST float f = 1.0f / 255.0f;
        r = f * (float)(byte)(dw >> 16);
        g = f * (float)(byte)(dw >> 8);
        b = f * (float)(byte)(dw >> 0);
        a = f * (float)(byte)(dw >> 24);
    }
    public D3DXINLINE D3DXCOLOR(CONST float[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        r = pf[0];
        g = pf[1];
        b = pf[2];
        a = pf[3];
    }
    public D3DXINLINE D3DXCOLOR(CONST D3DCOLORVALUE c)
    {
        r = c.r;
        g = c.g;
        b = c.b;
        a = c.a;
    }
    public D3DXINLINE D3DXCOLOR(float fr, float fg, float fb, float fa)
    {
        r = fr;
        g = fg;
        b = fb;
        a = fa;
    }

    // casting
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator uint() const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator uint();

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator float* ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator CONST float* () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator CONST float* ();

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator _D3DCOLORVALUE* ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator CONST _D3DCOLORVALUE* () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator CONST _D3DCOLORVALUE* ();

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator _D3DCOLORVALUE& ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator CONST _D3DCOLORVALUE& () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator CONST _D3DCOLORVALUE& ();

    // assignment operators
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXCOLOR operator += (CONST D3DXCOLOR);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXCOLOR operator -= (CONST D3DXCOLOR);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXCOLOR operator *= (float UnnamedParameter);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXCOLOR operator /= (float UnnamedParameter);

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXCOLOR operator + () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXCOLOR operator + ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXCOLOR operator - () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXCOLOR operator - ();

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXCOLOR operator + (CONST D3DXCOLOR&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXCOLOR operator + (CONST D3DXCOLOR);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXCOLOR operator - (CONST D3DXCOLOR&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXCOLOR operator - (CONST D3DXCOLOR);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXCOLOR operator * (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXCOLOR operator * (float UnnamedParameter);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXCOLOR operator / (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXCOLOR operator / (float UnnamedParameter);

// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' function:
// ORIGINAL LINE: friend D3DXCOLOR operator * (float, CONST D3DXCOLOR&);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXCOLOR operator * (float UnnamedParameter, CONST D3DXCOLOR);

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator == (CONST D3DXCOLOR&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator == (CONST D3DXCOLOR);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator != (CONST D3DXCOLOR&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator != (CONST D3DXCOLOR);

#endif //__cplusplus
    public float r;
    public float g;
    public float b;
    public float a;
}