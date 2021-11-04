using System;

/*==========================================================================;
 *
 *  Copyright (c) Microsoft Corporation.  All rights reserved.
 *
 *  File:       d3drm.h
 *  Content:    Direct3DRM include file
 *
 ***************************************************************************/


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
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVALP(val, prec) ((float)(val))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVAL(val) ((float)(val))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DDivide(a, b) (float)((double) (a) / (double) (b))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DMultiply(a, b) ((a) * (b))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CI_GETALPHA(ci) ((ci) >> 24)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CI_GETINDEX(ci) (((ci) >> 8) & 0xffff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CI_GETFRACTION(ci) ((ci) & 0xff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CI_ROUNDINDEX(ci) CI_GETINDEX((ci) + 0x80)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CI_MASKALPHA(ci) ((ci) & 0xffffff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CI_MAKE(a, i, f) (((a) << 24) | ((i) << 8) | (f))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RGBA_GETALPHA(rgb) ((rgb) >> 24)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RGBA_GETRED(rgb) (((rgb) >> 16) & 0xff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RGBA_GETGREEN(rgb) (((rgb) >> 8) & 0xff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RGBA_GETBLUE(rgb) ((rgb) & 0xff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RGBA_MAKE(r, g, b, a) ((D3DCOLOR) (((a) << 24) | ((r) << 16) | ((g) << 8) | (b)))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRGB(r, g, b) (0xff000000L | ( ((long)((r) * 255)) << 16) | (((long)((g) * 255)) << 8) | (long)((b) * 255))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRGBA(r, g, b, a) ( (((long)((a) * 255)) << 24) | (((long)((r) * 255)) << 16) | (((long)((g) * 255)) << 8) | (long)((b) * 255) )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RGB_GETRED(rgb) (((rgb) >> 16) & 0xff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RGB_GETGREEN(rgb) (((rgb) >> 8) & 0xff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RGB_GETBLUE(rgb) ((rgb) & 0xff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RGBA_SETALPHA(rgba, x) (((x) << 24) | ((rgba) & 0x00ffffff))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RGB_MAKE(r, g, b) ((D3DCOLOR) (((r) << 16) | ((g) << 8) | (b)))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RGBA_TORGB(rgba) ((D3DCOLOR) ((rgba) & 0xffffff))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RGB_TORGBA(rgb) ((D3DCOLOR) ((rgb) | 0xff000000))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DENUMRET_CANCEL DDENUMRET_CANCEL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DENUMRET_OK DDENUMRET_OK
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
// ORIGINAL LINE: #define D3DSTATUS_CLIPUNIONLEFT D3DCLIP_LEFT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_CLIPUNIONRIGHT D3DCLIP_RIGHT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_CLIPUNIONTOP D3DCLIP_TOP
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_CLIPUNIONBOTTOM D3DCLIP_BOTTOM
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_CLIPUNIONFRONT D3DCLIP_FRONT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_CLIPUNIONBACK D3DCLIP_BACK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_CLIPUNIONGEN0 D3DCLIP_GEN0
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_CLIPUNIONGEN1 D3DCLIP_GEN1
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_CLIPUNIONGEN2 D3DCLIP_GEN2
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_CLIPUNIONGEN3 D3DCLIP_GEN3
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_CLIPUNIONGEN4 D3DCLIP_GEN4
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_CLIPUNIONGEN5 D3DCLIP_GEN5
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_CLIPUNIONALL ( D3DSTATUS_CLIPUNIONLEFT | D3DSTATUS_CLIPUNIONRIGHT | D3DSTATUS_CLIPUNIONTOP | D3DSTATUS_CLIPUNIONBOTTOM | D3DSTATUS_CLIPUNIONFRONT | D3DSTATUS_CLIPUNIONBACK | D3DSTATUS_CLIPUNIONGEN0 | D3DSTATUS_CLIPUNIONGEN1 | D3DSTATUS_CLIPUNIONGEN2 | D3DSTATUS_CLIPUNIONGEN3 | D3DSTATUS_CLIPUNIONGEN4 | D3DSTATUS_CLIPUNIONGEN5 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_CLIPINTERSECTIONALL ( D3DSTATUS_CLIPINTERSECTIONLEFT | D3DSTATUS_CLIPINTERSECTIONRIGHT | D3DSTATUS_CLIPINTERSECTIONTOP | D3DSTATUS_CLIPINTERSECTIONBOTTOM | D3DSTATUS_CLIPINTERSECTIONFRONT | D3DSTATUS_CLIPINTERSECTIONBACK | D3DSTATUS_CLIPINTERSECTIONGEN0 | D3DSTATUS_CLIPINTERSECTIONGEN1 | D3DSTATUS_CLIPINTERSECTIONGEN2 | D3DSTATUS_CLIPINTERSECTIONGEN3 | D3DSTATUS_CLIPINTERSECTIONGEN4 | D3DSTATUS_CLIPINTERSECTIONGEN5 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATUS_DEFAULT ( D3DSTATUS_CLIPINTERSECTIONALL | D3DSTATUS_ZNOTVISIBLE)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DLIGHT_PARALLELPOINT (D3DLIGHTTYPE)4
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DLIGHT_GLSPOT (D3DLIGHTTYPE)5
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DLIGHT_ALL (D3DLIGHT_ACTIVE | D3DLIGHT_NO_SPECULAR)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DLIGHT_RANGE_MAX ((float)sqrt(FLT_MAX))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTATE_OVERRIDE(type) (D3DRENDERSTATETYPE)(((DWORD) (type) + D3DSTATE_OVERRIDE_BIAS))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_WORLD (D3DTRANSFORMSTATETYPE)1
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_VIEW (D3DTRANSFORMSTATETYPE)2
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_PROJECTION (D3DTRANSFORMSTATETYPE)3
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_WORLD1 (D3DTRANSFORMSTATETYPE)4
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_WORLD2 (D3DTRANSFORMSTATETYPE)5
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_WORLD3 (D3DTRANSFORMSTATETYPE)6
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_TEXTURE0 (D3DTRANSFORMSTATETYPE)16
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_TEXTURE1 (D3DTRANSFORMSTATETYPE)17
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_TEXTURE2 (D3DTRANSFORMSTATETYPE)18
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_TEXTURE3 (D3DTRANSFORMSTATETYPE)19
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_TEXTURE4 (D3DTRANSFORMSTATETYPE)20
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_TEXTURE5 (D3DTRANSFORMSTATETYPE)21
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_TEXTURE6 (D3DTRANSFORMSTATETYPE)22
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRANSFORMSTATE_TEXTURE7 (D3DTRANSFORMSTATETYPE)23
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_TEXTUREPERSPECTIVE (D3DRENDERSTATETYPE)4
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_ZENABLE (D3DRENDERSTATETYPE)7
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_FILLMODE (D3DRENDERSTATETYPE)8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_SHADEMODE (D3DRENDERSTATETYPE)9
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_LINEPATTERN (D3DRENDERSTATETYPE)10
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_ZWRITEENABLE (D3DRENDERSTATETYPE)14
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_ALPHATESTENABLE (D3DRENDERSTATETYPE)15
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_LASTPIXEL (D3DRENDERSTATETYPE)16
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_SRCBLEND (D3DRENDERSTATETYPE)19
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_DESTBLEND (D3DRENDERSTATETYPE)20
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_CULLMODE (D3DRENDERSTATETYPE)22
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_ZFUNC (D3DRENDERSTATETYPE)23
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_ALPHAREF (D3DRENDERSTATETYPE)24
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_ALPHAFUNC (D3DRENDERSTATETYPE)25
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_DITHERENABLE (D3DRENDERSTATETYPE)26
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_ALPHABLENDENABLE (D3DRENDERSTATETYPE)27
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_FOGENABLE (D3DRENDERSTATETYPE)28
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_SPECULARENABLE (D3DRENDERSTATETYPE)29
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_ZVISIBLE (D3DRENDERSTATETYPE)30
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEDALPHA (D3DRENDERSTATETYPE)33
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_FOGCOLOR (D3DRENDERSTATETYPE)34
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_FOGTABLEMODE (D3DRENDERSTATETYPE)35
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_FOGSTART (D3DRENDERSTATETYPE)36
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_FOGEND (D3DRENDERSTATETYPE)37
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_FOGDENSITY (D3DRENDERSTATETYPE)38
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_EDGEANTIALIAS (D3DRENDERSTATETYPE)40
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_ZBIAS (D3DRENDERSTATETYPE)47
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_RANGEFOGENABLE (D3DRENDERSTATETYPE)48
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STENCILENABLE (D3DRENDERSTATETYPE)52
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STENCILFAIL (D3DRENDERSTATETYPE)53
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STENCILZFAIL (D3DRENDERSTATETYPE)54
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STENCILPASS (D3DRENDERSTATETYPE)55
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STENCILFUNC (D3DRENDERSTATETYPE)56
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STENCILREF (D3DRENDERSTATETYPE)57
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STENCILMASK (D3DRENDERSTATETYPE)58
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STENCILWRITEMASK (D3DRENDERSTATETYPE)59
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_TEXTUREFACTOR (D3DRENDERSTATETYPE)60
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_WRAP0 (D3DRENDERSTATETYPE)128
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_WRAP1 (D3DRENDERSTATETYPE)129
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_WRAP2 (D3DRENDERSTATETYPE)130
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_WRAP3 (D3DRENDERSTATETYPE)131
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_WRAP4 (D3DRENDERSTATETYPE)132
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_WRAP5 (D3DRENDERSTATETYPE)133
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_WRAP6 (D3DRENDERSTATETYPE)134
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_WRAP7 (D3DRENDERSTATETYPE)135
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_CLIPPING (D3DRENDERSTATETYPE)136
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_LIGHTING (D3DRENDERSTATETYPE)137
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_EXTENTS (D3DRENDERSTATETYPE)138
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_AMBIENT (D3DRENDERSTATETYPE)139
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_FOGVERTEXMODE (D3DRENDERSTATETYPE)140
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_COLORVERTEX (D3DRENDERSTATETYPE)141
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_LOCALVIEWER (D3DRENDERSTATETYPE)142
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_NORMALIZENORMALS (D3DRENDERSTATETYPE)143
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_COLORKEYBLENDENABLE (D3DRENDERSTATETYPE)144
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_DIFFUSEMATERIALSOURCE (D3DRENDERSTATETYPE)145
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_SPECULARMATERIALSOURCE (D3DRENDERSTATETYPE)146
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_AMBIENTMATERIALSOURCE (D3DRENDERSTATETYPE)147
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_EMISSIVEMATERIALSOURCE (D3DRENDERSTATETYPE)148
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_VERTEXBLEND (D3DRENDERSTATETYPE)151
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_CLIPPLANEENABLE (D3DRENDERSTATETYPE)152
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_TEXTUREHANDLE (D3DRENDERSTATETYPE)1
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_ANTIALIAS (D3DRENDERSTATETYPE)2
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_TEXTUREADDRESS (D3DRENDERSTATETYPE)3
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_WRAPU (D3DRENDERSTATETYPE)5
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_WRAPV (D3DRENDERSTATETYPE)6
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_MONOENABLE (D3DRENDERSTATETYPE)11
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_ROP2 (D3DRENDERSTATETYPE)12
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_PLANEMASK (D3DRENDERSTATETYPE)13
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_TEXTUREMAG (D3DRENDERSTATETYPE)17
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_TEXTUREMIN (D3DRENDERSTATETYPE)18
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_TEXTUREMAPBLEND (D3DRENDERSTATETYPE)21
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_SUBPIXEL (D3DRENDERSTATETYPE)31
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_SUBPIXELX (D3DRENDERSTATETYPE)32
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEENABLE (D3DRENDERSTATETYPE)39
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_OLDALPHABLENDENABLE (D3DRENDERSTATETYPE)42
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_BORDERCOLOR (D3DRENDERSTATETYPE)43
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_TEXTUREADDRESSU (D3DRENDERSTATETYPE)44
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_TEXTUREADDRESSV (D3DRENDERSTATETYPE)45
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_MIPMAPLODBIAS (D3DRENDERSTATETYPE)46
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_ANISOTROPY (D3DRENDERSTATETYPE)49
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_FLUSHBATCH (D3DRENDERSTATETYPE)50
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_TRANSLUCENTSORTINDEPENDENT (D3DRENDERSTATETYPE)51
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN00 (D3DRENDERSTATETYPE)64
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN01 (D3DRENDERSTATETYPE)65
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN02 (D3DRENDERSTATETYPE)66
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN03 (D3DRENDERSTATETYPE)67
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN04 (D3DRENDERSTATETYPE)68
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN05 (D3DRENDERSTATETYPE)69
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN06 (D3DRENDERSTATETYPE)70
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN07 (D3DRENDERSTATETYPE)71
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN08 (D3DRENDERSTATETYPE)72
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN09 (D3DRENDERSTATETYPE)73
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN10 (D3DRENDERSTATETYPE)74
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN11 (D3DRENDERSTATETYPE)75
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN12 (D3DRENDERSTATETYPE)76
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN13 (D3DRENDERSTATETYPE)77
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN14 (D3DRENDERSTATETYPE)78
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN15 (D3DRENDERSTATETYPE)79
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN16 (D3DRENDERSTATETYPE)80
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN17 (D3DRENDERSTATETYPE)81
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN18 (D3DRENDERSTATETYPE)82
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN19 (D3DRENDERSTATETYPE)83
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN20 (D3DRENDERSTATETYPE)84
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN21 (D3DRENDERSTATETYPE)85
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN22 (D3DRENDERSTATETYPE)86
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN23 (D3DRENDERSTATETYPE)87
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN24 (D3DRENDERSTATETYPE)88
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN25 (D3DRENDERSTATETYPE)89
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN26 (D3DRENDERSTATETYPE)90
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN27 (D3DRENDERSTATETYPE)91
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN28 (D3DRENDERSTATETYPE)92
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN29 (D3DRENDERSTATETYPE)93
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN30 (D3DRENDERSTATETYPE)94
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN31 (D3DRENDERSTATETYPE)95
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_COLORKEYENABLE (D3DRENDERSTATETYPE)41
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_COLORKEYBLENDENABLE (D3DRENDERSTATETYPE)144
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_BLENDENABLE (D3DRENDERSTATETYPE)27
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_FOGTABLESTART (D3DRENDERSTATETYPE)36
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_FOGTABLEEND (D3DRENDERSTATETYPE)37
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_FOGTABLEDENSITY (D3DRENDERSTATETYPE)38
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_BLENDENABLE D3DRENDERSTATE_ALPHABLENDENABLE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRENDERSTATE_STIPPLEPATTERN(y) (D3DRENDERSTATE_STIPPLEPATTERN00 + (y))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRIFLAG_STARTFLAT(len) (len)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTRIFLAG_EDGEENABLETRIANGLE (D3DTRIFLAG_EDGEENABLE1 | D3DTRIFLAG_EDGEENABLE2 | D3DTRIFLAG_EDGEENABLE3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSETSTATUS_ALL (D3DSETSTATUS_STATUS | D3DSETSTATUS_EXTENTS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVOP_LIGHT (1 << 10)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVOP_TRANSFORM (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVOP_CLIP (1 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVOP_EXTENTS (1 << 3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DMAXNUMVERTICES ((1<<16) - 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DMAXNUMPRIMITIVES ((1<<16) - 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPV_DONOTCOPYDATA (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_VERTEX ( D3DFVF_XYZ | D3DFVF_NORMAL | D3DFVF_TEX1 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_LVERTEX ( D3DFVF_XYZ | D3DFVF_RESERVED1 | D3DFVF_DIFFUSE | D3DFVF_SPECULAR | D3DFVF_TEX1 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TLVERTEX ( D3DFVF_XYZRHW | D3DFVF_DIFFUSE | D3DFVF_SPECULAR | D3DFVF_TEX1 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_INTERSECT_LEFT (1 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_OUTSIDE_LEFT (2 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_INTERSECT_RIGHT (1 << 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_OUTSIDE_RIGHT (2 << 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_INTERSECT_TOP (1 << 6)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_OUTSIDE_TOP (2 << 6)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_INTERSECT_BOTTOM (1 << 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_OUTSIDE_BOTTOM (2 << 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_INTERSECT_NEAR (1 << 10)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_OUTSIDE_NEAR (2 << 10)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_INTERSECT_FAR (1 << 12)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_OUTSIDE_FAR (2 << 12)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_MASK_FRUSTUM (3 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_MASK_LEFT (3 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_MASK_RIGHT (3 << 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_MASK_TOP (3 << 6)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_MASK_BOTTOM (3 << 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_MASK_NEAR (3 << 10)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVIS_MASK_FAR (3 << 12)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE3(CoordIndex) (D3DFVF_TEXTUREFORMAT3 << (CoordIndex*2 + 16))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE2(CoordIndex) (D3DFVF_TEXTUREFORMAT2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE4(CoordIndex) (D3DFVF_TEXTUREFORMAT4 << (CoordIndex*2 + 16))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE1(CoordIndex) (D3DFVF_TEXTUREFORMAT1 << (CoordIndex*2 + 16))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVBLEND_DISABLE (D3DVERTEXBLENDFLAGS)0
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVBLEND_1WEIGHT (D3DVERTEXBLENDFLAGS)1
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVBLEND_2WEIGHTS (D3DVERTEXBLENDFLAGS)2
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVBLEND_3WEIGHTS (D3DVERTEXBLENDFLAGS)3

#if WIN32
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRMAPI __stdcall
#define D3DRMAPI
#else
#define D3DRMAPI
#endif

#if __cplusplus
#endif

#if ! TRUE
#endif

public class _D3DRMVECTOR4D
{
    public float x;
    public float y;
    public float z;
    public float w;
}


public class _D3DRMQUATERNION
{
    public float s;
    public _D3DVECTOR v = new _D3DVECTOR();
}

public class _D3DRMRAY
{
    public _D3DVECTOR dvDir = new _D3DVECTOR();
    public _D3DVECTOR dvPos = new _D3DVECTOR();
}

public class _D3DRMBOX
{
    public _D3DVECTOR min = new _D3DVECTOR();
    public _D3DVECTOR max = new _D3DVECTOR();
}

public delegate void D3DRMWRAPCALLBACK(_D3DVECTOR UnnamedParameter, ref int u, ref int v, _D3DVECTOR a, _D3DVECTOR b, object UnnamedParameter2);

public enum _D3DRMLIGHTTYPE
{
    D3DRMLIGHT_AMBIENT,
    D3DRMLIGHT_POINT,
    D3DRMLIGHT_SPOT,
    D3DRMLIGHT_DIRECTIONAL,
    D3DRMLIGHT_PARALLELPOINT
}

public enum _D3DRMSHADEMODE
{
    D3DRMSHADE_FLAT = 0,
    D3DRMSHADE_GOURAUD = 1,
    D3DRMSHADE_PHONG = 2,

    D3DRMSHADE_MASK = 7,
    D3DRMSHADE_MAX = 8
}

public enum _D3DRMLIGHTMODE
{
    D3DRMLIGHT_OFF = 0 * _D3DRMSHADEMODE.D3DRMSHADE_MAX,
    D3DRMLIGHT_ON = 1 * _D3DRMSHADEMODE.D3DRMSHADE_MAX,

    D3DRMLIGHT_MASK = 7 * _D3DRMSHADEMODE.D3DRMSHADE_MAX,
    D3DRMLIGHT_MAX = 8 * _D3DRMSHADEMODE.D3DRMSHADE_MAX
}

public enum _D3DRMFILLMODE
{
    D3DRMFILL_POINTS = 0 * _D3DRMLIGHTMODE.D3DRMLIGHT_MAX,
    D3DRMFILL_WIREFRAME = 1 * _D3DRMLIGHTMODE.D3DRMLIGHT_MAX,
    D3DRMFILL_SOLID = 2 * _D3DRMLIGHTMODE.D3DRMLIGHT_MAX,

    D3DRMFILL_MASK = 7 * _D3DRMLIGHTMODE.D3DRMLIGHT_MAX,
    D3DRMFILL_MAX = 8 * _D3DRMLIGHTMODE.D3DRMLIGHT_MAX
}


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRMRENDER_WIREFRAME (D3DRMSHADE_FLAT+D3DRMLIGHT_OFF+D3DRMFILL_WIREFRAME)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRMRENDER_UNLITFLAT (D3DRMSHADE_FLAT+D3DRMLIGHT_OFF+D3DRMFILL_SOLID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRMRENDER_FLAT (D3DRMSHADE_FLAT+D3DRMLIGHT_ON+D3DRMFILL_SOLID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRMRENDER_GOURAUD (D3DRMSHADE_GOURAUD+D3DRMLIGHT_ON+D3DRMFILL_SOLID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRMRENDER_PHONG (D3DRMSHADE_PHONG+D3DRMLIGHT_ON+D3DRMFILL_SOLID)


public enum _D3DRMTEXTUREQUALITY
{
    D3DRMTEXTURE_NEAREST, // choose nearest texel
    D3DRMTEXTURE_LINEAR, // interpolate 4 texels
    D3DRMTEXTURE_MIPNEAREST, // nearest texel in nearest mipmap
    D3DRMTEXTURE_MIPLINEAR, // interpolate 2 texels from 2 mipmaps
    D3DRMTEXTURE_LINEARMIPNEAREST, // interpolate 4 texels in nearest mipmap
    D3DRMTEXTURE_LINEARMIPLINEAR // interpolate 8 texels from 2 mipmaps
}

/*
 * Texture flags
 */

/*
 * Shadow flags
 */

public enum _D3DRMCOMBINETYPE
{
    D3DRMCOMBINE_REPLACE,
    D3DRMCOMBINE_BEFORE,
    D3DRMCOMBINE_AFTER
}


public enum _D3DRMPALETTEFLAGS
{
    D3DRMPALETTE_FREE, // renderer may use this entry freely
    D3DRMPALETTE_READONLY, // fixed but may be used by renderer
    D3DRMPALETTE_RESERVED // may not be used by renderer
}

public class _D3DRMPALETTEENTRY
{
    public byte red; // 0 .. 255
    public byte green; // 0 .. 255
    public byte blue; // 0 .. 255
    public byte flags; // one of D3DRMPALETTEFLAGS
}

public class _D3DRMIMAGE
{
    public int width; // width and height in pixels
    public int height;
    public int aspectx; // aspect ratio for non-square pixels
    public int aspecty;
    public int depth; // bits per pixel
    public int rgb; /* if false, pixels are indices into a
                                   palette otherwise, pixels encode
                                   RGB values. */
    public int bytes_per_line; /* number of bytes of memory for a
                                   scanline. This must be a multiple
                                   of 4. */
    public object buffer1; // memory to render into (first buffer).
    public object buffer2; /* second rendering buffer for double
                                   buffering, set to NULL for single
                                   buffering. */
    public uint red_mask;
    public uint green_mask;
    public uint blue_mask;
    public uint alpha_mask; /* if rgb is true, these are masks for
                                   the red, green and blue parts of a
                                   pixel.  Otherwise, these are masks
                                   for the significant bits of the
                                   red, green and blue elements in the
                                   palette.  For instance, most SVGA
                                   displays use 64 intensities of red,
                                   green and blue, so the masks should
                                   all be set to 0xfc. */
    public int palette_size; // number of entries in palette
    public _D3DRMPALETTEENTRY palette; /* description of the palette (only if
                                   rgb is false).  Must be (1<<depth)
                                   elements. */
}

public enum _D3DRMWRAPTYPE
{
    D3DRMWRAP_FLAT,
    D3DRMWRAP_CYLINDER,
    D3DRMWRAP_SPHERE,
    D3DRMWRAP_CHROME,
    D3DRMWRAP_SHEET,
    D3DRMWRAP_BOX
}


/*
 * Do not use righthanded perspective in Viewport2::SetProjection().
 * Set up righthanded mode by using IDirect3DRM3::SetOptions().
 */
public enum _D3DRMPROJECTIONTYPE
{
    D3DRMPROJECT_PERSPECTIVE,
    D3DRMPROJECT_ORTHOGRAPHIC,
    D3DRMPROJECT_RIGHTHANDPERSPECTIVE, // Only valid pre-DX6
    D3DRMPROJECT_RIGHTHANDORTHOGRAPHIC // Only valid pre-DX6
}


public enum _D3DRMXOFFORMAT
{
    D3DRMXOF_BINARY,
    D3DRMXOF_COMPRESSED,
    D3DRMXOF_TEXT
}


public enum _D3DRMCOLORSOURCE
{
    D3DRMCOLOR_FROMFACE,
    D3DRMCOLOR_FROMVERTEX
}

public enum _D3DRMFRAMECONSTRAINT
{
    D3DRMCONSTRAIN_Z, // use only X and Y rotations
    D3DRMCONSTRAIN_Y, // use only X and Z rotations
    D3DRMCONSTRAIN_X // use only Y and Z rotations
}

public enum _D3DRMMATERIALMODE
{
    D3DRMMATERIAL_FROMMESH,
    D3DRMMATERIAL_FROMPARENT,
    D3DRMMATERIAL_FROMFRAME
}

public enum _D3DRMFOGMODE
{
    D3DRMFOG_LINEAR, // linear between start and end
    D3DRMFOG_EXPONENTIAL, // density * exp(-distance)
    D3DRMFOG_EXPONENTIALSQUARED // density * exp(-distance*distance)
}

public enum _D3DRMZBUFFERMODE
{
    D3DRMZBUFFER_FROMPARENT, // default
    D3DRMZBUFFER_ENABLE, // enable zbuffering
    D3DRMZBUFFER_DISABLE // disable zbuffering
}

public enum _D3DRMSORTMODE
{
    D3DRMSORT_FROMPARENT, // default
    D3DRMSORT_NONE, // don't sort child frames
    D3DRMSORT_FRONTTOBACK, // sort child frames front-to-back
    D3DRMSORT_BACKTOFRONT // sort child frames back-to-front
}

public class _D3DRMMATERIALOVERRIDE
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Indicate which fields are valid
    public _D3DCOLORVALUE dcDiffuse = new _D3DCOLORVALUE(); // RGBA
    public _D3DCOLORVALUE dcAmbient = new _D3DCOLORVALUE(); // RGB
    public _D3DCOLORVALUE dcEmissive = new _D3DCOLORVALUE(); // RGB
    public _D3DCOLORVALUE dcSpecular = new _D3DCOLORVALUE(); // RGB
    public float dvPower;
    public LPUNKNOWN lpD3DRMTex = new LPUNKNOWN();
}




/*
 * Values for flags in RM3::CreateDeviceFromSurface
 */

/*
 * Values for flags in Object2::SetClientData
 */

/*
 * Values for flags in Frame2::AddMoveCallback.
 */

/*
 * Values for flags in MeshBuilder2::RayPick.
 */

/*
 * Values for flags in MeshBuilder3::AddFacesIndexed.
 */

/*
 * Values for flags in MeshBuilder2::GenerateNormals.
 */

/*
 * Values for MeshBuilder3::GetParentMesh
 */

/*
 * Flags for MeshBuilder3::Enable
 */

/*
 * Flags for MeshBuilder3::AddMeshBuilder
 */

/*
 * Flags for Object2::GetAge when used with MeshBuilders
 */

/*
 * Format flags for MeshBuilder3::AddTriangles.
 */


/*
 * Values for flags in Viewport2::Clear2
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRMCLEAR_ALL (D3DRMCLEAR_TARGET | D3DRMCLEAR_ZBUFFER | D3DRMCLEAR_DIRTYRECTS)

/*
 * Values for flags in Frame3::SetSceneFogMethod
 */

/*
 * Values for flags in Frame3::SetTraversalOptions
 */








public class _D3DRMLOADRESOURCE
{
  public IntPtr hModule;
  public readonly string lpName;
  public readonly string lpType;
}

public class _D3DRMLOADMEMORY
{
  public object lpMemory;
  public uint dSize;
}



public class _D3DRMPMESHLOADSTATUS
{
  public uint dwSize; // Size of this structure
  public uint dwPMeshSize; // Total Size (bytes)
  public uint dwBaseMeshSize; // Total Size of the Base Mesh
  public uint dwBytesLoaded; // Total bytes loaded
  public uint dwVerticesLoaded; // Number of vertices loaded
  public uint dwFacesLoaded; // Number of faces loaded
  public int dwLoadResult; // Result of the load operation
  public uint dwFlags;
}

public enum _D3DRMUSERVISUALREASON
{
    D3DRMUSERVISUAL_CANSEE,
    D3DRMUSERVISUAL_RENDER
}


public class _D3DRMANIMATIONKEY
{
    public uint dwSize;
    public uint dwKeyType;
    public float dvTime;
    public uint dwID;
#if (! __cplusplus) || (! D3D_OVERLOADS)
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        _D3DRMQUATERNION dqRotateKey;
//        _D3DVECTOR dvScaleKey;
//        _D3DVECTOR dvPositionKey;
//    };
#else
    /*
     * We do this as D3D_OVERLOADS defines constructors for D3DVECTOR,
     * this can then not be used in a union.  Use the inlines provided
     * to extract and set the required component.
     */
    public float[] dvK = new float[4];
#endif
}

public class _D3DRMVERTEX
{
    public _D3DVECTOR position = new _D3DVECTOR();
    public _D3DVECTOR normal = new _D3DVECTOR();
    public float tu;
    public float tv;
    public uint color;
}