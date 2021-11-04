/*==========================================================================;
 *
 *  Copyright (C) Microsoft Corporation.  All Rights Reserved. 
 *
 *  File:       d3dcaps.h
 *  Content:    Direct3D capabilities include file
 *
 ***************************************************************************/


/*
 *  Pull in DirectDraw include file automatically:
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IUnknown void
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKE_DDHRESULT( code ) MAKE_HRESULT( 1, _FACDD, code )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DUMMYUNIONNAMEN(n)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DUMMYUNIONNAMEN(n) u##n
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKEFOURCC(ch0, ch1, ch2, ch3) ((DWORD)(BYTE)(ch0) | ((DWORD)(BYTE)(ch1) << 8) | ((DWORD)(BYTE)(ch2) << 16) | ((DWORD)(BYTE)(ch3) << 24 ))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT1 (MAKEFOURCC('D','X','T','1'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT2 (MAKEFOURCC('D','X','T','2'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT3 (MAKEFOURCC('D','X','T','3'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT4 (MAKEFOURCC('D','X','T','4'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT5 (MAKEFOURCC('D','X','T','5'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectDrawEnumerate DirectDrawEnumerateW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectDrawEnumerateEx DirectDrawEnumerateExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectDrawEnumerate DirectDrawEnumerateA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectDrawEnumerateEx DirectDrawEnumerateExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_WHQL_YEAR( dwWHQLLevel ) ( (dwWHQLLevel) / 0x10000 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_WHQL_MONTH( dwWHQLLevel ) ( ( (dwWHQLLevel) / 0x100 ) & 0x00ff )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_WHQL_DAY( dwWHQLLevel ) ( (dwWHQLLevel) & 0xff )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDraw
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Compact(p) (p)->lpVtbl->Compact(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreateClipper(p, a, b, c) (p)->lpVtbl->CreateClipper(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreatePalette(p, a, b, c, d) (p)->lpVtbl->CreatePalette(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreateSurface(p, a, b, c) (p)->lpVtbl->CreateSurface(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_DuplicateSurface(p, a, b) (p)->lpVtbl->DuplicateSurface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_EnumDisplayModes(p, a, b, c, d) (p)->lpVtbl->EnumDisplayModes(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_EnumSurfaces(p, a, b, c, d) (p)->lpVtbl->EnumSurfaces(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_FlipToGDISurface(p) (p)->lpVtbl->FlipToGDISurface(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetCaps(p, a, b) (p)->lpVtbl->GetCaps(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetDisplayMode(p, a) (p)->lpVtbl->GetDisplayMode(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetFourCCCodes(p, a, b) (p)->lpVtbl->GetFourCCCodes(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetGDISurface(p, a) (p)->lpVtbl->GetGDISurface(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetMonitorFrequency(p, a) (p)->lpVtbl->GetMonitorFrequency(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetScanLine(p, a) (p)->lpVtbl->GetScanLine(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetVerticalBlankStatus(p, a) (p)->lpVtbl->GetVerticalBlankStatus(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Initialize(p, a) (p)->lpVtbl->Initialize(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_RestoreDisplayMode(p) (p)->lpVtbl->RestoreDisplayMode(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_SetCooperativeLevel(p, a, b) (p)->lpVtbl->SetCooperativeLevel(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_SetDisplayMode(p, a, b, c) (p)->lpVtbl->SetDisplayMode(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_WaitForVerticalBlank(p, a, b) (p)->lpVtbl->WaitForVerticalBlank(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Compact(p) (p)->Compact()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreateClipper(p, a, b, c) (p)->CreateClipper(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreatePalette(p, a, b, c, d) (p)->CreatePalette(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreateSurface(p, a, b, c) (p)->CreateSurface(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_DuplicateSurface(p, a, b) (p)->DuplicateSurface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_EnumDisplayModes(p, a, b, c, d) (p)->EnumDisplayModes(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_EnumSurfaces(p, a, b, c, d) (p)->EnumSurfaces(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_FlipToGDISurface(p) (p)->FlipToGDISurface()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetCaps(p, a, b) (p)->GetCaps(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetDisplayMode(p, a) (p)->GetDisplayMode(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetFourCCCodes(p, a, b) (p)->GetFourCCCodes(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetGDISurface(p, a) (p)->GetGDISurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetMonitorFrequency(p, a) (p)->GetMonitorFrequency(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetScanLine(p, a) (p)->GetScanLine(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetVerticalBlankStatus(p, a) (p)->GetVerticalBlankStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Initialize(p, a) (p)->Initialize(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_RestoreDisplayMode(p) (p)->RestoreDisplayMode()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_SetCooperativeLevel(p, a, b) (p)->SetCooperativeLevel(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_SetDisplayMode(p, a, b, c) (p)->SetDisplayMode(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_WaitForVerticalBlank(p, a, b) (p)->WaitForVerticalBlank(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDraw2
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Compact(p) (p)->lpVtbl->Compact(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreateClipper(p, a, b, c) (p)->lpVtbl->CreateClipper(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreatePalette(p, a, b, c, d) (p)->lpVtbl->CreatePalette(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreateSurface(p, a, b, c) (p)->lpVtbl->CreateSurface(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_DuplicateSurface(p, a, b) (p)->lpVtbl->DuplicateSurface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_EnumDisplayModes(p, a, b, c, d) (p)->lpVtbl->EnumDisplayModes(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_EnumSurfaces(p, a, b, c, d) (p)->lpVtbl->EnumSurfaces(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_FlipToGDISurface(p) (p)->lpVtbl->FlipToGDISurface(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetCaps(p, a, b) (p)->lpVtbl->GetCaps(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetDisplayMode(p, a) (p)->lpVtbl->GetDisplayMode(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetFourCCCodes(p, a, b) (p)->lpVtbl->GetFourCCCodes(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetGDISurface(p, a) (p)->lpVtbl->GetGDISurface(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetMonitorFrequency(p, a) (p)->lpVtbl->GetMonitorFrequency(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetScanLine(p, a) (p)->lpVtbl->GetScanLine(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetVerticalBlankStatus(p, a) (p)->lpVtbl->GetVerticalBlankStatus(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Initialize(p, a) (p)->lpVtbl->Initialize(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_RestoreDisplayMode(p) (p)->lpVtbl->RestoreDisplayMode(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_SetCooperativeLevel(p, a, b) (p)->lpVtbl->SetCooperativeLevel(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_SetDisplayMode(p, a, b, c, d, e) (p)->lpVtbl->SetDisplayMode(p, a, b, c, d, e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_WaitForVerticalBlank(p, a, b) (p)->lpVtbl->WaitForVerticalBlank(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetAvailableVidMem(p, a, b, c) (p)->lpVtbl->GetAvailableVidMem(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Compact(p) (p)->Compact()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreateClipper(p, a, b, c) (p)->CreateClipper(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreatePalette(p, a, b, c, d) (p)->CreatePalette(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreateSurface(p, a, b, c) (p)->CreateSurface(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_DuplicateSurface(p, a, b) (p)->DuplicateSurface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_EnumDisplayModes(p, a, b, c, d) (p)->EnumDisplayModes(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_EnumSurfaces(p, a, b, c, d) (p)->EnumSurfaces(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_FlipToGDISurface(p) (p)->FlipToGDISurface()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetCaps(p, a, b) (p)->GetCaps(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetDisplayMode(p, a) (p)->GetDisplayMode(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetFourCCCodes(p, a, b) (p)->GetFourCCCodes(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetGDISurface(p, a) (p)->GetGDISurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetMonitorFrequency(p, a) (p)->GetMonitorFrequency(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetScanLine(p, a) (p)->GetScanLine(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetVerticalBlankStatus(p, a) (p)->GetVerticalBlankStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Initialize(p, a) (p)->Initialize(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_RestoreDisplayMode(p) (p)->RestoreDisplayMode()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_SetCooperativeLevel(p, a, b) (p)->SetCooperativeLevel(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_SetDisplayMode(p, a, b, c, d, e) (p)->SetDisplayMode(a, b, c, d, e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_WaitForVerticalBlank(p, a, b) (p)->WaitForVerticalBlank(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetAvailableVidMem(p, a, b, c) (p)->GetAvailableVidMem(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDraw4
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Compact(p) (p)->lpVtbl->Compact(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreateClipper(p, a, b, c) (p)->lpVtbl->CreateClipper(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreatePalette(p, a, b, c, d) (p)->lpVtbl->CreatePalette(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreateSurface(p, a, b, c) (p)->lpVtbl->CreateSurface(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_DuplicateSurface(p, a, b) (p)->lpVtbl->DuplicateSurface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_EnumDisplayModes(p, a, b, c, d) (p)->lpVtbl->EnumDisplayModes(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_EnumSurfaces(p, a, b, c, d) (p)->lpVtbl->EnumSurfaces(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_FlipToGDISurface(p) (p)->lpVtbl->FlipToGDISurface(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetCaps(p, a, b) (p)->lpVtbl->GetCaps(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetDisplayMode(p, a) (p)->lpVtbl->GetDisplayMode(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetFourCCCodes(p, a, b) (p)->lpVtbl->GetFourCCCodes(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetGDISurface(p, a) (p)->lpVtbl->GetGDISurface(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetMonitorFrequency(p, a) (p)->lpVtbl->GetMonitorFrequency(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetScanLine(p, a) (p)->lpVtbl->GetScanLine(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetVerticalBlankStatus(p, a) (p)->lpVtbl->GetVerticalBlankStatus(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Initialize(p, a) (p)->lpVtbl->Initialize(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_RestoreDisplayMode(p) (p)->lpVtbl->RestoreDisplayMode(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_SetCooperativeLevel(p, a, b) (p)->lpVtbl->SetCooperativeLevel(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_SetDisplayMode(p, a, b, c, d, e) (p)->lpVtbl->SetDisplayMode(p, a, b, c, d, e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_WaitForVerticalBlank(p, a, b) (p)->lpVtbl->WaitForVerticalBlank(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetAvailableVidMem(p, a, b, c) (p)->lpVtbl->GetAvailableVidMem(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetSurfaceFromDC(p, a, b) (p)->lpVtbl->GetSurfaceFromDC(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_RestoreAllSurfaces(p) (p)->lpVtbl->RestoreAllSurfaces(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_TestCooperativeLevel(p) (p)->lpVtbl->TestCooperativeLevel(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetDeviceIdentifier(p,a,b) (p)->lpVtbl->GetDeviceIdentifier(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Compact(p) (p)->Compact()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreateClipper(p, a, b, c) (p)->CreateClipper(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreatePalette(p, a, b, c, d) (p)->CreatePalette(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreateSurface(p, a, b, c) (p)->CreateSurface(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_DuplicateSurface(p, a, b) (p)->DuplicateSurface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_EnumDisplayModes(p, a, b, c, d) (p)->EnumDisplayModes(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_EnumSurfaces(p, a, b, c, d) (p)->EnumSurfaces(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_FlipToGDISurface(p) (p)->FlipToGDISurface()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetCaps(p, a, b) (p)->GetCaps(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetDisplayMode(p, a) (p)->GetDisplayMode(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetFourCCCodes(p, a, b) (p)->GetFourCCCodes(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetGDISurface(p, a) (p)->GetGDISurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetMonitorFrequency(p, a) (p)->GetMonitorFrequency(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetScanLine(p, a) (p)->GetScanLine(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetVerticalBlankStatus(p, a) (p)->GetVerticalBlankStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Initialize(p, a) (p)->Initialize(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_RestoreDisplayMode(p) (p)->RestoreDisplayMode()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_SetCooperativeLevel(p, a, b) (p)->SetCooperativeLevel(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_SetDisplayMode(p, a, b, c, d, e) (p)->SetDisplayMode(a, b, c, d, e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_WaitForVerticalBlank(p, a, b) (p)->WaitForVerticalBlank(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetAvailableVidMem(p, a, b, c) (p)->GetAvailableVidMem(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetSurfaceFromDC(p, a, b) (p)->GetSurfaceFromDC(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_RestoreAllSurfaces(p) (p)->RestoreAllSurfaces()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_TestCooperativeLevel(p) (p)->TestCooperativeLevel()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetDeviceIdentifier(p,a,b) (p)->GetDeviceIdentifier(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDraw7
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Compact(p) (p)->lpVtbl->Compact(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreateClipper(p, a, b, c) (p)->lpVtbl->CreateClipper(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreatePalette(p, a, b, c, d) (p)->lpVtbl->CreatePalette(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreateSurface(p, a, b, c) (p)->lpVtbl->CreateSurface(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_DuplicateSurface(p, a, b) (p)->lpVtbl->DuplicateSurface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EnumDisplayModes(p, a, b, c, d) (p)->lpVtbl->EnumDisplayModes(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EnumSurfaces(p, a, b, c, d) (p)->lpVtbl->EnumSurfaces(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_FlipToGDISurface(p) (p)->lpVtbl->FlipToGDISurface(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetCaps(p, a, b) (p)->lpVtbl->GetCaps(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetDisplayMode(p, a) (p)->lpVtbl->GetDisplayMode(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetFourCCCodes(p, a, b) (p)->lpVtbl->GetFourCCCodes(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetGDISurface(p, a) (p)->lpVtbl->GetGDISurface(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetMonitorFrequency(p, a) (p)->lpVtbl->GetMonitorFrequency(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetScanLine(p, a) (p)->lpVtbl->GetScanLine(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetVerticalBlankStatus(p, a) (p)->lpVtbl->GetVerticalBlankStatus(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Initialize(p, a) (p)->lpVtbl->Initialize(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_RestoreDisplayMode(p) (p)->lpVtbl->RestoreDisplayMode(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_SetCooperativeLevel(p, a, b) (p)->lpVtbl->SetCooperativeLevel(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_SetDisplayMode(p, a, b, c, d, e) (p)->lpVtbl->SetDisplayMode(p, a, b, c, d, e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_WaitForVerticalBlank(p, a, b) (p)->lpVtbl->WaitForVerticalBlank(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetAvailableVidMem(p, a, b, c) (p)->lpVtbl->GetAvailableVidMem(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetSurfaceFromDC(p, a, b) (p)->lpVtbl->GetSurfaceFromDC(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_RestoreAllSurfaces(p) (p)->lpVtbl->RestoreAllSurfaces(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_TestCooperativeLevel(p) (p)->lpVtbl->TestCooperativeLevel(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetDeviceIdentifier(p,a,b) (p)->lpVtbl->GetDeviceIdentifier(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_StartModeTest(p,a,b,c) (p)->lpVtbl->StartModeTest(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EvaluateMode(p,a,b) (p)->lpVtbl->EvaluateMode(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Compact(p) (p)->Compact()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreateClipper(p, a, b, c) (p)->CreateClipper(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreatePalette(p, a, b, c, d) (p)->CreatePalette(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreateSurface(p, a, b, c) (p)->CreateSurface(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_DuplicateSurface(p, a, b) (p)->DuplicateSurface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EnumDisplayModes(p, a, b, c, d) (p)->EnumDisplayModes(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EnumSurfaces(p, a, b, c, d) (p)->EnumSurfaces(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_FlipToGDISurface(p) (p)->FlipToGDISurface()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetCaps(p, a, b) (p)->GetCaps(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetDisplayMode(p, a) (p)->GetDisplayMode(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetFourCCCodes(p, a, b) (p)->GetFourCCCodes(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetGDISurface(p, a) (p)->GetGDISurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetMonitorFrequency(p, a) (p)->GetMonitorFrequency(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetScanLine(p, a) (p)->GetScanLine(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetVerticalBlankStatus(p, a) (p)->GetVerticalBlankStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Initialize(p, a) (p)->Initialize(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_RestoreDisplayMode(p) (p)->RestoreDisplayMode()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_SetCooperativeLevel(p, a, b) (p)->SetCooperativeLevel(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_SetDisplayMode(p, a, b, c, d, e) (p)->SetDisplayMode(a, b, c, d, e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_WaitForVerticalBlank(p, a, b) (p)->WaitForVerticalBlank(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetAvailableVidMem(p, a, b, c) (p)->GetAvailableVidMem(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetSurfaceFromDC(p, a, b) (p)->GetSurfaceFromDC(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_RestoreAllSurfaces(p) (p)->RestoreAllSurfaces()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_TestCooperativeLevel(p) (p)->TestCooperativeLevel()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetDeviceIdentifier(p,a,b) (p)->GetDeviceIdentifier(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_StartModeTest(p,a,b,c) (p)->lpVtbl->StartModeTest(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EvaluateMode(p,a,b) (p)->lpVtbl->EvaluateMode(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_GetCaps(p, a) (p)->lpVtbl->GetCaps(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_GetEntries(p, a, b, c, d) (p)->lpVtbl->GetEntries(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_Initialize(p, a, b, c) (p)->lpVtbl->Initialize(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_SetEntries(p, a, b, c, d) (p)->lpVtbl->SetEntries(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_GetCaps(p, a) (p)->GetCaps(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_GetEntries(p, a, b, c, d) (p)->GetEntries(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_Initialize(p, a, b, c) (p)->Initialize(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_SetEntries(p, a, b, c, d) (p)->SetEntries(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_GetClipList(p, a, b, c) (p)->lpVtbl->GetClipList(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_GetHWnd(p, a) (p)->lpVtbl->GetHWnd(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_Initialize(p, a, b) (p)->lpVtbl->Initialize(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_IsClipListChanged(p, a) (p)->lpVtbl->IsClipListChanged(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_SetClipList(p, a, b) (p)->lpVtbl->SetClipList(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_SetHWnd(p, a, b) (p)->lpVtbl->SetHWnd(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_GetClipList(p, a, b, c) (p)->GetClipList(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_GetHWnd(p, a) (p)->GetHWnd(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_Initialize(p, a, b) (p)->Initialize(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_IsClipListChanged(p, a) (p)->IsClipListChanged(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_SetClipList(p, a, b) (p)->SetClipList(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_SetHWnd(p, a, b) (p)->SetHWnd(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_IsLost(p) (p)->lpVtbl->IsLost(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Restore(p) (p)->lpVtbl->Restore(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Flip(p,a,b) (p)->Flip(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetBltStatus(p,a) (p)->GetBltStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetCaps(p,b) (p)->GetCaps(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetClipper(p,a) (p)->GetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetDC(p,a) (p)->GetDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetPalette(p,a) (p)->GetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Initialize(p,a,b) (p)->Initialize(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_IsLost(p) (p)->IsLost()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_ReleaseDC(p,a) (p)->ReleaseDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Restore(p) (p)->Restore()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetClipper(p,a) (p)->SetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetPalette(p,a) (p)->SetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Unlock(p,b) (p)->Unlock(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface2
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_IsLost(p) (p)->lpVtbl->IsLost(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Restore(p) (p)->lpVtbl->Restore(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetDDInterface(p,a) (p)->lpVtbl->GetDDInterface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_PageLock(p,a) (p)->lpVtbl->PageLock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_PageUnlock(p,a) (p)->lpVtbl->PageUnlock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Flip(p,a,b) (p)->Flip(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetBltStatus(p,a) (p)->GetBltStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetCaps(p,b) (p)->GetCaps(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetClipper(p,a) (p)->GetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetDC(p,a) (p)->GetDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetPalette(p,a) (p)->GetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Initialize(p,a,b) (p)->Initialize(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_IsLost(p) (p)->IsLost()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_ReleaseDC(p,a) (p)->ReleaseDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Restore(p) (p)->Restore()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetClipper(p,a) (p)->SetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetPalette(p,a) (p)->SetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Unlock(p,b) (p)->Unlock(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetDDInterface(p,a) (p)->GetDDInterface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_PageLock(p,a) (p)->PageLock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_PageUnlock(p,a) (p)->PageUnlock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface3
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_IsLost(p) (p)->lpVtbl->IsLost(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Restore(p) (p)->lpVtbl->Restore(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetDDInterface(p,a) (p)->lpVtbl->GetDDInterface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_PageLock(p,a) (p)->lpVtbl->PageLock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_PageUnlock(p,a) (p)->lpVtbl->PageUnlock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetSurfaceDesc(p,a,b) (p)->lpVtbl->SetSurfaceDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Flip(p,a,b) (p)->Flip(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetBltStatus(p,a) (p)->GetBltStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetCaps(p,b) (p)->GetCaps(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetClipper(p,a) (p)->GetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetDC(p,a) (p)->GetDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetPalette(p,a) (p)->GetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Initialize(p,a,b) (p)->Initialize(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_IsLost(p) (p)->IsLost()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_ReleaseDC(p,a) (p)->ReleaseDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Restore(p) (p)->Restore()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetClipper(p,a) (p)->SetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetPalette(p,a) (p)->SetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Unlock(p,b) (p)->Unlock(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetDDInterface(p,a) (p)->GetDDInterface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_PageLock(p,a) (p)->PageLock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_PageUnlock(p,a) (p)->PageUnlock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetSurfaceDesc(p,a,b) (p)->SetSurfaceDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface4
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_IsLost(p) (p)->lpVtbl->IsLost(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Restore(p) (p)->lpVtbl->Restore(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetDDInterface(p,a) (p)->lpVtbl->GetDDInterface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_PageLock(p,a) (p)->lpVtbl->PageLock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_PageUnlock(p,a) (p)->lpVtbl->PageUnlock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetSurfaceDesc(p,a,b) (p)->lpVtbl->SetSurfaceDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetUniquenessValue(p, a) (p)->lpVtbl->GetUniquenessValue(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_ChangeUniquenessValue(p) (p)->lpVtbl->ChangeUniquenessValue(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Flip(p,a,b) (p)->Flip(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetBltStatus(p,a) (p)->GetBltStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetCaps(p,b) (p)->GetCaps(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetClipper(p,a) (p)->GetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetDC(p,a) (p)->GetDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPalette(p,a) (p)->GetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Initialize(p,a,b) (p)->Initialize(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_IsLost(p) (p)->IsLost()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_ReleaseDC(p,a) (p)->ReleaseDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Restore(p) (p)->Restore()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetClipper(p,a) (p)->SetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetPalette(p,a) (p)->SetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Unlock(p,b) (p)->Unlock(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetDDInterface(p,a) (p)->GetDDInterface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_PageLock(p,a) (p)->PageLock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_PageUnlock(p,a) (p)->PageUnlock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetSurfaceDesc(p,a,b) (p)->SetSurfaceDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_FreePrivateData(p,a) (p)->FreePrivateData(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetUniquenessValue(p, a) (p)->GetUniquenessValue(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_ChangeUniquenessValue(p) (p)->ChangeUniquenessValue()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface7
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_IsLost(p) (p)->lpVtbl->IsLost(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Restore(p) (p)->lpVtbl->Restore(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetDDInterface(p,a) (p)->lpVtbl->GetDDInterface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_PageLock(p,a) (p)->lpVtbl->PageLock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_PageUnlock(p,a) (p)->lpVtbl->PageUnlock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetSurfaceDesc(p,a,b) (p)->lpVtbl->SetSurfaceDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetUniquenessValue(p, a) (p)->lpVtbl->GetUniquenessValue(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_ChangeUniquenessValue(p) (p)->lpVtbl->ChangeUniquenessValue(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPriority(p,a) (p)->lpVtbl->SetPriority(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPriority(p,a) (p)->lpVtbl->GetPriority(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetLOD(p,a) (p)->lpVtbl->SetLOD(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetLOD(p,a) (p)->lpVtbl->GetLOD(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Flip(p,a,b) (p)->Flip(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetBltStatus(p,a) (p)->GetBltStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetCaps(p,b) (p)->GetCaps(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetClipper(p,a) (p)->GetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetDC(p,a) (p)->GetDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPalette(p,a) (p)->GetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Initialize(p,a,b) (p)->Initialize(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_IsLost(p) (p)->IsLost()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_ReleaseDC(p,a) (p)->ReleaseDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Restore(p) (p)->Restore()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetClipper(p,a) (p)->SetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPalette(p,a) (p)->SetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Unlock(p,b) (p)->Unlock(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetDDInterface(p,a) (p)->GetDDInterface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_PageLock(p,a) (p)->PageLock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_PageUnlock(p,a) (p)->PageUnlock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetSurfaceDesc(p,a,b) (p)->SetSurfaceDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_FreePrivateData(p,a) (p)->FreePrivateData(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetUniquenessValue(p, a) (p)->GetUniquenessValue(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_ChangeUniquenessValue(p) (p)->ChangeUniquenessValue()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPriority(p,a) (p)->SetPriority(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPriority(p,a) (p)->GetPriority(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetLOD(p,a) (p)->SetLOD(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetLOD(p,a) (p)->GetLOD(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawColorControl
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_GetColorControls(p, a) (p)->lpVtbl->GetColorControls(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_SetColorControls(p, a) (p)->lpVtbl->SetColorControls(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_GetColorControls(p, a) (p)->GetColorControls(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_SetColorControls(p, a) (p)->SetColorControls(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawGammaControl
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_GetGammaRamp(p, a, b) (p)->lpVtbl->GetGammaRamp(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_SetGammaRamp(p, a, b) (p)->lpVtbl->SetGammaRamp(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_GetGammaRamp(p, a, b) (p)->GetGammaRamp(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_SetGammaRamp(p, a, b) (p)->SetGammaRamp(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDSCAPS2_CUBEMAP_ALLFACES ( DDSCAPS2_CUBEMAP_POSITIVEX | DDSCAPS2_CUBEMAP_NEGATIVEX | DDSCAPS2_CUBEMAP_POSITIVEY | DDSCAPS2_CUBEMAP_NEGATIVEY | DDSCAPS2_CUBEMAP_POSITIVEZ | DDSCAPS2_CUBEMAP_NEGATIVEZ )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDFXCAPS_BLTFILTER DDFXCAPS_BLTARITHSTRETCHY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDFXCAPS_OVERLAYFILTER DDFXCAPS_OVERLAYARITHSTRETCHY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DD_OK S_OK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DD_FALSE S_FALSE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_ALREADYINITIALIZED MAKE_DDHRESULT( 5 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANNOTATTACHSURFACE MAKE_DDHRESULT( 10 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANNOTDETACHSURFACE MAKE_DDHRESULT( 20 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CURRENTLYNOTAVAIL MAKE_DDHRESULT( 40 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_EXCEPTION MAKE_DDHRESULT( 55 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_GENERIC E_FAIL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_HEIGHTALIGN MAKE_DDHRESULT( 90 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INCOMPATIBLEPRIMARY MAKE_DDHRESULT( 95 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDCAPS MAKE_DDHRESULT( 100 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDCLIPLIST MAKE_DDHRESULT( 110 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDMODE MAKE_DDHRESULT( 120 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDOBJECT MAKE_DDHRESULT( 130 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDPARAMS E_INVALIDARG
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDPIXELFORMAT MAKE_DDHRESULT( 145 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDRECT MAKE_DDHRESULT( 150 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_LOCKEDSURFACES MAKE_DDHRESULT( 160 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NO3D MAKE_DDHRESULT( 170 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOALPHAHW MAKE_DDHRESULT( 180 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOSTEREOHARDWARE MAKE_DDHRESULT( 181 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOSURFACELEFT MAKE_DDHRESULT( 182 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCLIPLIST MAKE_DDHRESULT( 205 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOLORCONVHW MAKE_DDHRESULT( 210 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOOPERATIVELEVELSET MAKE_DDHRESULT( 212 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOLORKEY MAKE_DDHRESULT( 215 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOLORKEYHW MAKE_DDHRESULT( 220 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODIRECTDRAWSUPPORT MAKE_DDHRESULT( 222 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOEXCLUSIVEMODE MAKE_DDHRESULT( 225 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOFLIPHW MAKE_DDHRESULT( 230 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOGDI MAKE_DDHRESULT( 240 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOMIRRORHW MAKE_DDHRESULT( 250 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTFOUND MAKE_DDHRESULT( 255 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOOVERLAYHW MAKE_DDHRESULT( 260 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAPPINGRECTS MAKE_DDHRESULT( 270 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NORASTEROPHW MAKE_DDHRESULT( 280 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOROTATIONHW MAKE_DDHRESULT( 290 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOSTRETCHHW MAKE_DDHRESULT( 310 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOT4BITCOLOR MAKE_DDHRESULT( 316 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOT4BITCOLORINDEX MAKE_DDHRESULT( 317 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOT8BITCOLOR MAKE_DDHRESULT( 320 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTEXTUREHW MAKE_DDHRESULT( 330 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOVSYNCHW MAKE_DDHRESULT( 335 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOZBUFFERHW MAKE_DDHRESULT( 340 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOZOVERLAYHW MAKE_DDHRESULT( 350 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OUTOFCAPS MAKE_DDHRESULT( 360 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OUTOFMEMORY E_OUTOFMEMORY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OUTOFVIDEOMEMORY MAKE_DDHRESULT( 380 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAYCANTCLIP MAKE_DDHRESULT( 382 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAYCOLORKEYONLYONEACTIVE MAKE_DDHRESULT( 384 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_PALETTEBUSY MAKE_DDHRESULT( 387 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_COLORKEYNOTSET MAKE_DDHRESULT( 400 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEALREADYATTACHED MAKE_DDHRESULT( 410 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEALREADYDEPENDENT MAKE_DDHRESULT( 420 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEBUSY MAKE_DDHRESULT( 430 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTLOCKSURFACE MAKE_DDHRESULT( 435 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEISOBSCURED MAKE_DDHRESULT( 440 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACELOST MAKE_DDHRESULT( 450 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACENOTATTACHED MAKE_DDHRESULT( 460 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TOOBIGHEIGHT MAKE_DDHRESULT( 470 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TOOBIGSIZE MAKE_DDHRESULT( 480 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TOOBIGWIDTH MAKE_DDHRESULT( 490 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTED E_NOTIMPL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTEDFORMAT MAKE_DDHRESULT( 510 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTEDMASK MAKE_DDHRESULT( 520 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDSTREAM MAKE_DDHRESULT( 521 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_VERTICALBLANKINPROGRESS MAKE_DDHRESULT( 537 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_WASSTILLDRAWING MAKE_DDHRESULT( 540 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DDSCAPSCOMPLEXREQUIRED MAKE_DDHRESULT( 542 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_XALIGN MAKE_DDHRESULT( 560 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDDIRECTDRAWGUID MAKE_DDHRESULT( 561 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DIRECTDRAWALREADYCREATED MAKE_DDHRESULT( 562 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODIRECTDRAWHW MAKE_DDHRESULT( 563 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_PRIMARYSURFACEALREADYEXISTS MAKE_DDHRESULT( 564 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOEMULATION MAKE_DDHRESULT( 565 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_REGIONTOOSMALL MAKE_DDHRESULT( 566 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CLIPPERISUSINGHWND MAKE_DDHRESULT( 567 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCLIPPERATTACHED MAKE_DDHRESULT( 568 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOHWND MAKE_DDHRESULT( 569 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_HWNDSUBCLASSED MAKE_DDHRESULT( 570 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_HWNDALREADYSET MAKE_DDHRESULT( 571 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOPALETTEATTACHED MAKE_DDHRESULT( 572 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOPALETTEHW MAKE_DDHRESULT( 573 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_BLTFASTCANTCLIP MAKE_DDHRESULT( 574 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOBLTHW MAKE_DDHRESULT( 575 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODDROPSHW MAKE_DDHRESULT( 576 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAYNOTVISIBLE MAKE_DDHRESULT( 577 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOOVERLAYDEST MAKE_DDHRESULT( 578 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDPOSITION MAKE_DDHRESULT( 579 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTAOVERLAYSURFACE MAKE_DDHRESULT( 580 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_EXCLUSIVEMODEALREADYSET MAKE_DDHRESULT( 581 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTFLIPPABLE MAKE_DDHRESULT( 582 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTDUPLICATE MAKE_DDHRESULT( 583 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTLOCKED MAKE_DDHRESULT( 584 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTCREATEDC MAKE_DDHRESULT( 585 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODC MAKE_DDHRESULT( 586 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_WRONGMODE MAKE_DDHRESULT( 587 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_IMPLICITLYCREATED MAKE_DDHRESULT( 588 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTPALETTIZED MAKE_DDHRESULT( 589 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTEDMODE MAKE_DDHRESULT( 590 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOMIPMAPHW MAKE_DDHRESULT( 591 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDSURFACETYPE MAKE_DDHRESULT( 592 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOOPTIMIZEHW MAKE_DDHRESULT( 600 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTLOADED MAKE_DDHRESULT( 601 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOFOCUSWINDOW MAKE_DDHRESULT( 602 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTONMIPMAPSUBLEVEL MAKE_DDHRESULT( 603 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DCALREADYCREATED MAKE_DDHRESULT( 620 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NONONLOCALVIDMEM MAKE_DDHRESULT( 630 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTPAGELOCK MAKE_DDHRESULT( 640 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTPAGEUNLOCK MAKE_DDHRESULT( 660 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTPAGELOCKED MAKE_DDHRESULT( 680 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_MOREDATA MAKE_DDHRESULT( 690 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_EXPIRED MAKE_DDHRESULT( 691 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TESTFINISHED MAKE_DDHRESULT( 692 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NEWMODE MAKE_DDHRESULT( 693 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_D3DNOTINITIALIZED MAKE_DDHRESULT( 694 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_VIDEONOTACTIVE MAKE_DDHRESULT( 695 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOMONITORINFORMATION MAKE_DDHRESULT( 696 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODRIVERSUPPORT MAKE_DDHRESULT( 697 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DEVICEDOESNTOWNSURFACE MAKE_DDHRESULT( 699 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTINITIALIZED CO_E_NOTINITIALIZED


#if _X86_ || _IA64_
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(4)
#endif

/* Description of capabilities of transform */

public class _D3DTRANSFORMCAPS
{
    public uint dwSize;
    public uint dwCaps;
}


/* Description of capabilities of lighting */

public class _D3DLIGHTINGCAPS
{
    public uint dwSize;
    public uint dwCaps; // Lighting caps
    public uint dwLightingModel; // Lighting model - RGB or mono
    public uint dwNumLights; // Number of lights that can be handled
}


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION < 0x700)
#endif
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION < 0x500)
#endif

/* Description of capabilities for each primitive type */

public class _D3DPrimCaps
{
    public uint dwSize;
    public uint dwMiscCaps; // Capability flags
    public uint dwRasterCaps;
    public uint dwZCmpCaps;
    public uint dwSrcBlendCaps;
    public uint dwDestBlendCaps;
    public uint dwAlphaCmpCaps;
    public uint dwShadeCaps;
    public uint dwTextureCaps;
    public uint dwTextureFilterCaps;
    public uint dwTextureBlendCaps;
    public uint dwTextureAddressCaps;
    public uint dwStippleWidth; // maximum width and height of
    public uint dwStippleHeight; // of supported stipple (up to 32x32)
}

/* D3DPRIMCAPS dwMiscCaps */


/* D3DPRIMCAPS dwRasterCaps */

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0500)
#endif // DIRECT3D_VERSION >= 0x0500
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0600)
#endif // DIRECT3D_VERSION >= 0x0600

/* D3DPRIMCAPS dwZCmpCaps, dwAlphaCmpCaps */


/* D3DPRIMCAPS dwSourceBlendCaps, dwDestBlendCaps */


/* D3DPRIMCAPS dwShadeCaps */





/* D3DPRIMCAPS dwTextureCaps */

/*
 * Perspective-correct texturing is supported
 */

/*
 * Power-of-2 texture dimensions are required
 */

/*
 * Alpha in texture pixels is supported
 */

/*
 * Color-keyed textures are supported
 */

/*
 * obsolete, see D3DPTADDRESSCAPS_BORDER
 */

/*
 * Only square textures are supported
 */

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0600)
/*
 * Texture indices are not scaled by the texture size prior
 * to interpolation.
 */

/*
 * Device can draw alpha from texture palettes
 */

/*
 * Device can use non-POW2 textures if:
 *  1) D3DTEXTURE_ADDRESS is set to CLAMP for this texture's stage
 *  2) D3DRS_WRAP(N) is zero for this texture's coordinates
 *  3) mip mapping is not enabled (use magnification filter only)
 */

#endif // DIRECT3D_VERSION >= 0x0600
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0700)

// 0x00000200L unused

/*
 * Device can divide transformed texture coordinates by the
 * COUNTth texture coordinate (can do D3DTTFF_PROJECTED)
 */

/*
 * Device can do cubemap textures
 */

#endif // DIRECT3D_VERSION >= 0x0700

/* D3DPRIMCAPS dwTextureFilterCaps */


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0600)
/* Device3 Min Filter */

/* Device3 Mip Filter */

/* Device3 Mag Filter */
#endif // DIRECT3D_VERSION >= 0x0600

/* D3DPRIMCAPS dwTextureBlendCaps */

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0500)
#endif // DIRECT3D_VERSION >= 0x0500

/* D3DPRIMCAPS dwTextureAddressCaps */
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0500)
#endif // DIRECT3D_VERSION >= 0x0500

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0600)

/* D3DDEVICEDESC dwStencilCaps */


/* D3DDEVICEDESC dwTextureOpCaps */


/* D3DDEVICEDESC dwFVFCaps flags */


#endif // DIRECT3D_VERSION >= 0x0600

/*
 * Description for a device.
 * This is used to describe a device that is to be created or to query
 * the current device.
 */
public class _D3DDeviceDesc
{
    public uint dwSize; // Size of D3DDEVICEDESC structure
    public uint dwFlags; // Indicates which fields have valid data
    public D3DCOLORMODEL dcmColorModel = new D3DCOLORMODEL(); // Color model of device
    public uint dwDevCaps; // Capabilities of device
    public _D3DTRANSFORMCAPS dtcTransformCaps = new _D3DTRANSFORMCAPS(); // Capabilities of transform
    public bool bClipping; // Device can do 3D clipping
    public _D3DLIGHTINGCAPS dlcLightingCaps = new _D3DLIGHTINGCAPS(); // Capabilities of lighting
    public _D3DPrimCaps dpcLineCaps = new _D3DPrimCaps();
    public _D3DPrimCaps dpcTriCaps = new _D3DPrimCaps();
    public uint dwDeviceRenderBitDepth; // One of DDBB_8, 16, etc..
    public uint dwDeviceZBufferBitDepth; // One of DDBD_16, 32, etc..
    public uint dwMaxBufferSize; // Maximum execute buffer size
    public uint dwMaxVertexCount; // Maximum vertex count
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0500)
    // *** New fields for DX5 *** //

    // Width and height caps are 0 for legacy HALs.
    public uint dwMinTextureWidth;
    public uint dwMinTextureHeight;
    public uint dwMaxTextureWidth;
    public uint dwMaxTextureHeight;
    public uint dwMinStippleWidth;
    public uint dwMaxStippleWidth;
    public uint dwMinStippleHeight;
    public uint dwMaxStippleHeight;
#endif // DIRECT3D_VERSION >= 0x0500

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0600)
    // New fields for DX6
    public uint dwMaxTextureRepeat;
    public uint dwMaxTextureAspectRatio;
    public uint dwMaxAnisotropy;

    // Guard band that the rasterizer can accommodate
    // Screen-space vertices inside this space but outside the viewport
    // will get clipped properly.
    public D3DVALUE dvGuardBandLeft = new D3DVALUE();
    public D3DVALUE dvGuardBandTop = new D3DVALUE();
    public D3DVALUE dvGuardBandRight = new D3DVALUE();
    public D3DVALUE dvGuardBandBottom = new D3DVALUE();

    public D3DVALUE dvExtentsAdjust = new D3DVALUE();
    public uint dwStencilCaps;

    public uint dwFVFCaps;
    public uint dwTextureOpCaps;
    public ushort wMaxTextureBlendStages;
    public ushort wMaxSimultaneousTextures;
#endif // DIRECT3D_VERSION >= 0x0600
}

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0700)
public class _D3DDeviceDesc7
{
    public uint dwDevCaps; // Capabilities of device
    public _D3DPrimCaps dpcLineCaps = new _D3DPrimCaps();
    public _D3DPrimCaps dpcTriCaps = new _D3DPrimCaps();
    public uint dwDeviceRenderBitDepth; // One of DDBB_8, 16, etc..
    public uint dwDeviceZBufferBitDepth; // One of DDBD_16, 32, etc..

    public uint dwMinTextureWidth;
    public uint dwMinTextureHeight;
    public uint dwMaxTextureWidth;
    public uint dwMaxTextureHeight;

    public uint dwMaxTextureRepeat;
    public uint dwMaxTextureAspectRatio;
    public uint dwMaxAnisotropy;

    public D3DVALUE dvGuardBandLeft = new D3DVALUE();
    public D3DVALUE dvGuardBandTop = new D3DVALUE();
    public D3DVALUE dvGuardBandRight = new D3DVALUE();
    public D3DVALUE dvGuardBandBottom = new D3DVALUE();

    public D3DVALUE dvExtentsAdjust = new D3DVALUE();
    public uint dwStencilCaps;

    public uint dwFVFCaps;
    public uint dwTextureOpCaps;
    public ushort wMaxTextureBlendStages;
    public ushort wMaxSimultaneousTextures;

    public uint dwMaxActiveLights;
    public D3DVALUE dvMaxVertexW = new D3DVALUE();
    public GUID deviceGUID = new GUID();

    public ushort wMaxUserClipPlanes;
    public ushort wMaxVertexBlendMatrices;

    public uint dwVertexProcessingCaps;

    public uint dwReserved1;
    public uint dwReserved2;
    public uint dwReserved3;
    public uint dwReserved4;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDeviceDesc7 D3DDEVICEDESC7;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDeviceDesc7 *LPD3DDEVICEDESC7;
#endif // DIRECT3D_VERSION >= 0x0700

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DDEVICEDESCSIZE (sizeof(D3DDEVICEDESC))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DDEVICEDESC7SIZE (sizeof(D3DDEVICEDESC7))

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef int(CALLBACK * LPD3DENUMDEVICESCALLBACK)(GUID FAR *lpGuid, char* lpDeviceDescription, char* lpDeviceName, _D3DDeviceDesc *, _D3DDeviceDesc *, object*);
public delegate int LPD3DENUMDEVICESCALLBACK(GUID lpGuid, ref string lpDeviceDescription, ref string lpDeviceName, _D3DDeviceDesc UnnamedParameter, _D3DDeviceDesc UnnamedParameter2, object UnnamedParameter3);

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0700)
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef int(CALLBACK * LPD3DENUMDEVICESCALLBACK7)(char* lpDeviceDescription, char* lpDeviceName, _D3DDeviceDesc7 *, object*);
public delegate int LPD3DENUMDEVICESCALLBACK7(ref string lpDeviceDescription, ref string lpDeviceName, _D3DDeviceDesc7 UnnamedParameter, object UnnamedParameter2);
#endif // DIRECT3D_VERSION >= 0x0700

/* D3DDEVICEDESC dwFlags indicating valid fields */


/* D3DDEVICEDESC dwDevCaps flags */

                                                    /* for post-transform vertex data */

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0500)
#endif // DIRECT3D_VERSION >= 0x0500
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0600)
#endif // DIRECT3D_VERSION >= 0x0600
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0700)

/*
 * These are the flags in the D3DDEVICEDESC7.dwVertexProcessingCaps field
 */

/* device can do texgen */
/* device can do IDirect3DDevice7 colormaterialsource ops */
/* device can do vertex fog */
/* device can do directional lights */
/* device can do positional lights (includes point and spot) */
/* device can do local viewer */

#endif // DIRECT3D_VERSION >= 0x0700


/*
 * FindDevice arguments
 */
public class _D3DFINDDEVICESEARCH
{
    public uint dwSize;
    public uint dwFlags;
    public bool bHardware;
    public D3DCOLORMODEL dcmColorModel = new D3DCOLORMODEL();
    public GUID guid = new GUID();
    public uint dwCaps;
    public _D3DPrimCaps dpcPrimCaps = new _D3DPrimCaps();
}

public class _D3DFINDDEVICERESULT
{
    public uint dwSize;
    public GUID guid = new GUID(); // guid which matched
    public _D3DDeviceDesc ddHwDesc = new _D3DDeviceDesc(); // hardware D3DDEVICEDESC
    public _D3DDeviceDesc ddSwDesc = new _D3DDeviceDesc(); // software D3DDEVICEDESC
}

/*
 * Description of execute buffer.
 */
public class _D3DExecuteBufferDesc
{
    public uint dwSize; // size of this structure
    public uint dwFlags; // flags indicating which fields are valid
    public uint dwCaps; // capabilities of execute buffer
    public uint dwBufferSize; // size of execute buffer data
    public object lpData; // pointer to actual data
}

/* D3DEXECUTEBUFFER dwFlags indicating valid fields */


/* D3DEXECUTEBUFFER dwCaps */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DDEBCAPS_MEM (D3DDEBCAPS_SYSTEMMEMORY|D3DDEBCAPS_VIDEOMEMORY)

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION < 0x0800)

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0700)
public class _D3DDEVINFO_TEXTUREMANAGER
{
    public bool bThrashing; // indicates if thrashing
    public uint dwApproxBytesDownloaded; // Approximate number of bytes downloaded by texture manager
    public uint dwNumEvicts; // number of textures evicted
    public uint dwNumVidCreates; // number of textures created in video memory
    public uint dwNumTexturesUsed; // number of textures used
    public uint dwNumUsedTexInVid; // number of used textures present in video memory
    public uint dwWorkingSet; // number of textures in video memory
    public uint dwWorkingSetBytes; // number of bytes in video memory
    public uint dwTotalManaged; // total number of managed textures
    public uint dwTotalBytes; // total number of bytes of managed textures
    public uint dwLastPri; // priority of last texture evicted
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_TEXTUREMANAGER D3DDEVINFO_TEXTUREMANAGER;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_TEXTUREMANAGER *LPD3DDEVINFO_TEXTUREMANAGER;

public class _D3DDEVINFO_TEXTURING
{
    public uint dwNumLoads; // counts Load() API calls
    public uint dwApproxBytesLoaded; // Approximate number bytes loaded via Load()
    public uint dwNumPreLoads; // counts PreLoad() API calls
    public uint dwNumSet; // counts SetTexture() API calls
    public uint dwNumCreates; // counts texture creates
    public uint dwNumDestroys; // counts texture destroys
    public uint dwNumSetPriorities; // counts SetPriority() API calls
    public uint dwNumSetLODs; // counts SetLOD() API calls
    public uint dwNumLocks; // counts number of texture locks
    public uint dwNumGetDCs; // counts number of GetDCs to textures
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_TEXTURING D3DDEVINFO_TEXTURING;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_TEXTURING *LPD3DDEVINFO_TEXTURING;
#endif // DIRECT3D_VERSION >= 0x0700

#endif //(DIRECT3D_VERSION < 0x0800)

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack()



