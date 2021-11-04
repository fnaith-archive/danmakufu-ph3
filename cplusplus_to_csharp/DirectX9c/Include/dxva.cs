// ------------------------------------------------------------------------------
// File: DXVA.h
// 
// Desc: DirectX Video Acceleration header file.
// 
// Copyright (c) 1999 - 2002, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------



#if __cplusplus
#endif

#if __DIRECTX_VA_COPP_ONLY
#define __DIRECTX_VA_DECODER__
#define __DIRECTX_VA_PROCAMPCONTROL__
#define __DIRECTX_VA_DEINTERLACE__
#endif


// -------------------------------------------------------------------------
// 
// The definitions that follow describe the DirectX Video Acceleration
// decoding interface.
// This interface is accessable via the IAMVideoAccelerator interface.
// 
// -------------------------------------------------------------------------
// 

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeNone, 0x1b81be00, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeH261_A, 0x1b81be01, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeH261_B, 0x1b81be02, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeH263_A, 0x1b81be03, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeH263_B, 0x1b81be04, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeH263_C, 0x1b81be05, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeH263_D, 0x1b81be06, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeH263_E, 0x1b81be07, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeH263_F, 0x1b81be08, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeMPEG1_A, 0x1b81be09, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeMPEG2_A, 0x1b81be0A, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeMPEG2_B, 0x1b81be0B, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeMPEG2_C, 0x1b81be0C, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeMPEG2_D, 0x1b81be0D, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeWMV8_A, 0x1b81be80, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeWMV8_B, 0x1b81be81, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeWMV9_A, 0x1b81be90, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeWMV9_B, 0x1b81be91, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeWMV9_Ai, 0x1b81be92, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ModeWMV9_Bi, 0x1b81be93, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);


// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_NoEncrypt, 0x1b81beD0, 0xa0c7,0x11d3,0xb9,0x84,0x00,0xc0,0x4f,0x2e,0x73,0xc5);










/* values for bDXVA_Func */

/* values returned from Execute command in absence of read-back */


// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(push, BeforeDXVApacking, 1)


public class _DXVA_ConnectMode
{
  public GUID guidMode = new GUID();
  public ushort wRestrictedMode;
}




// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_QueryOrReplyFuncFlag(ptr) ((*(ptr)) >> 8)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_QueryOrReplyFuncFlag_ACCEL(ptr) (((*(ptr)) >> 11) & 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_QueryOrReplyFuncFlag_LOCK(ptr) (((*(ptr)) >> 10) & 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_QueryOrReplyFuncFlag_BAD(ptr) (((*(ptr)) >> 9) & 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_QueryOrReplyFuncFlag_PLUS(ptr) (((*(ptr)) >> 8) & 1)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_QueryOrReplyFuncFunc(ptr) ((*(ptr)) & 0xFF)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define writeDXVA_QueryOrReplyFunc(ptr, flg, fnc) ((*(ptr)) = ((flg) << 8) | (fnc))

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_QueryOrReplyFuncFlag(ptr, flg) ((*(ptr)) |= ((flg) << 8))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_QueryOrReplyFuncFunc(ptr, fnc) ((*(ptr)) |= (fnc));



// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_EncryptProtocolFuncFlag(ptr) ((*(ptr)) >> 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_EncryptProtocolFuncFlag_ACCEL(ptr) (((*(ptr)) >> 11) & 1)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_EncryptProtocolFuncFunc(ptr) ((*(ptr)) & 0xFF)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define writeDXVA_EncryptProtocolFunc(ptr, flg, fnc) ((*(ptr)) = ((flg) << 8) | (fnc))

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_EncryptProtocolFuncFlag(ptr, flg) ((*(ptr)) |= ((flg) << 8))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_EncryptProtocolFuncFunc(ptr, fnc) ((*(ptr)) |= (fnc));

public class _DXVA_EncryptProtocolHeader
{
  public uint dwFunction;
  public uint[] ReservedBits = new uint[3];
  public GUID guidEncryptProtocol = new GUID();
}

public class _DXVA_ConfigPictureDecode
{

  // Operation Indicated
  public uint dwFunction;

  // Alignment
  public uint[] dwReservedBits = new uint[3];

  // Encryption GUIDs
  public GUID guidConfigBitstreamEncryption = new GUID();
  public GUID guidConfigMBcontrolEncryption = new GUID();
  public GUID guidConfigResidDiffEncryption = new GUID();

  // Bitstream Processing Indicator
  public byte bConfigBitstreamRaw;

  // Macroblock Control Config
  public byte bConfigMBcontrolRasterOrder;

  // Host Resid Diff Config
  public byte bConfigResidDiffHost;
  public byte bConfigSpatialResid8;
  public byte bConfigResid8Subtraction;
  public byte bConfigSpatialHost8or9Clipping;
  public byte bConfigSpatialResidInterleaved;
  public byte bConfigIntraResidUnsigned;

  // Accelerator Resid Diff Config
  public byte bConfigResidDiffAccelerator;
  public byte bConfigHostInverseScan;
  public byte bConfigSpecificIDCT;
  public byte bConfig4GroupedCoefs;
}


/* Picture Decoding Parameters */

public class _DXVA_PictureParameters
{

  public ushort wDecodedPictureIndex;
  public ushort wDeblockedPictureIndex;

  public ushort wForwardRefPictureIndex;
  public ushort wBackwardRefPictureIndex;

  public ushort wPicWidthInMBminus1;
  public ushort wPicHeightInMBminus1;

  public byte bMacroblockWidthMinus1;
  public byte bMacroblockHeightMinus1;

  public byte bBlockWidthMinus1;
  public byte bBlockHeightMinus1;

  public byte bBPPminus1;

  public byte bPicStructure;
  public byte bSecondField;
  public byte bPicIntra;
  public byte bPicBackwardPrediction;

  public byte bBidirectionalAveragingMode;
  public byte bMVprecisionAndChromaRelation;
  public byte bChromaFormat;

  public byte bPicScanFixed;
  public byte bPicScanMethod;
  public byte bPicReadbackRequests;

  public byte bRcontrol;
  public byte bPicSpatialResid8;
  public byte bPicOverflowBlocks;
  public byte bPicExtrapolation;

  public byte bPicDeblocked;
  public byte bPicDeblockConfined;
  public byte bPic4MVallowed;
  public byte bPicOBMC;
  public byte bPicBinPB;
  public byte bMV_RPS;

  public byte bReservedBits;

  public ushort wBitstreamFcodes;
  public ushort wBitstreamPCEelements;
  public byte bBitstreamConcealmentNeed;
  public byte bBitstreamConcealmentMethod;

}



/* Picture Resampling */

public class _DXVA_PicResample
{

  public ushort wPicResampleSourcePicIndex;
  public ushort wPicResampleDestPicIndex;

  public ushort wPicResampleRcontrol;
  public byte bPicResampleExtrapWidth;
  public byte bPicResampleExtrapHeight;

  public uint dwPicResampleSourceWidth;
  public uint dwPicResampleSourceHeight;

  public uint dwPicResampleDestWidth;
  public uint dwPicResampleDestHeight;

  public uint dwPicResampleFullDestWidth;
  public uint dwPicResampleFullDestHeight;

}










/* Buffer Description Data */

public class _DXVA_BufferDescription
{
  public uint dwTypeIndex;
  public uint dwBufferIndex;
  public uint dwDataOffset;
  public uint dwDataSize;
  public uint dwFirstMBaddress;
  public uint dwNumMBsInBuffer;
  public uint dwWidth;
  public uint dwHeight;
  public uint dwStride;
  public uint dwReservedBits;
}


/* Off-Host IDCT Coefficient Data Structures */

public class _DXVA_TCoef4Group
{
  public byte[] TCoefIDX = new byte[4];
  public short[] TCoefValue = new short[4];
}

public class _DXVA_TCoefSingle
{
  public ushort wIndexWithEOB;
  public short TCoefValue;
}

/* Macros for Reading EOB and Index Values */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_TCoefSingleIDX(ptr) ((ptr)->wIndexWithEOB >> 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_TCoefSingleEOB(ptr) ((ptr)->wIndexWithEOB & 1)

/* Macro for Writing EOB and Index Values */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define writeDXVA_TCoefSingleIndexWithEOB(ptr, idx, eob) ((ptr)->wIndexWithEOB = ((idx) << 1) | (eob))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_TCoefSingleIDX(ptr, idx) ((ptr)->wIndexWithEOB |= ((idx) << 1))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_TCoefSingleEOB(ptr) ((ptr)->wIndexWithEOB |= 1)

/* Spatial-Domain Residual Difference Blocks */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXVA_USUAL_BLOCK_SIZE (DXVA_USUAL_BLOCK_WIDTH * DXVA_USUAL_BLOCK_HEIGHT)


/* Deblocking Filter Control Structure */



/* Macros for Reading STRENGTH and FilterOn */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_EdgeFilterStrength(ptr) ((*(ptr)) >> 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_EdgeFilterOn(ptr) ((*(ptr)) & 1)

/* Macro for Writing STRENGTH and FilterOn */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define writeDXVA_DeblockingEdgeControl(ptr, str, fon) ((*(ptr)) = ((str) << 1) | (fon))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_EdgeFilterStrength(ptr, str) ((*(ptr)) |= ((str) << 1))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_EdgeFilterOn(ptr) ((*(ptr)) |= 1)


/* Macroblock Control Command Data Structures */

public class _DXVA_MVvalue
{
  public short horz;
  public short vert;
}


/* Inverse Quantization Matrices */

public class _DXVA_QmatrixData
{
  public byte[] bNewQmatrix = new byte[4]; // intra Y, inter Y, intra chroma, inter chroma
  public ushort[][] Qmatrix = RectangularArrays.RectangularUshortArray(4, DefineConstants.DXVA_USUAL_BLOCK_WIDTH * DefineConstants.DXVA_USUAL_BLOCK_HEIGHT);
}


/* Slice Control Buffer Data */

public class _DXVA_SliceInfo
{
  public ushort wHorizontalPosition;
  public ushort wVerticalPosition;
  public uint dwSliceBitsInBuffer;
  public uint dwSliceDataLocation;
  public byte bStartCodeBitOffset;
  public byte bReservedBits;
  public ushort wMBbitOffset;
  public ushort wNumberMBsInSlice;
  public ushort wQuantizerScaleCode;
  public ushort wBadSliceChopping;
}




/* Basic form for I pictures */
/* Host Residual Differences */
public class _DXVA_MBctrl_I_HostResidDiff_1
{
  public ushort wMBaddress;
  public ushort wMBtype;
  public uint dwMB_SNL;
  public ushort wPatternCode;
  public ushort wPC_Overflow; // zero if not overflow format
  public uint dwReservedBits2;
}

/* Basic form for I pictures */
/* Off-Host IDCT, 4:2:0 sampling */
public class _DXVA_MBctrl_I_OffHostIDCT_1
{
  public ushort wMBaddress;
  public ushort wMBtype;
  public uint dwMB_SNL;
  public ushort wPatternCode;
  public byte[] bNumCoef = new byte[DefineConstants.DXVA_NumBlocksPerMB_420];
}

/* Basic form for P and B pictures */
/* Should also be used for concealment MVs in MPEG-2 I pictures */
/* Without OBMC, without BinPB and 4MV together, without MV RPS */
/* Host Residual Differences */
public class _DXVA_MBctrl_P_HostResidDiff_1
{
  public ushort wMBaddress;
  public ushort wMBtype;
  public uint dwMB_SNL;
  public ushort wPatternCode;
  public ushort wPC_Overflow; // zero if not overflow format
  public uint dwReservedBits2;
  public _DXVA_MVvalue[] MVector = Arrays.InitializeWithDefaultInstances<_DXVA_MVvalue>(DefineConstants.DXVA_NumMV_OBMC_off_BinPBwith4MV_off);
}

/* Basic form for P and B pictures */
/* Without OBMC, without BinPB and 4MV together, without MV RPS */
/* Off-Host IDCT, 4:2:0 sampling */
public class _DXVA_MBctrl_P_OffHostIDCT_1
{
  public ushort wMBaddress;
  public ushort wMBtype;
  public uint dwMB_SNL;
  public ushort wPatternCode;
  public byte[] bNumCoef = new byte[DefineConstants.DXVA_NumBlocksPerMB_420];
  public _DXVA_MVvalue[] MVector = Arrays.InitializeWithDefaultInstances<_DXVA_MVvalue>(DefineConstants.DXVA_NumMV_OBMC_off_BinPBwith4MV_off);
}

/* How to load alpha blending graphic data */
public class _DXVA_ConfigAlphaLoad
{

  // Operation Indicated
  public uint dwFunction;

  // Alignment
  public uint[] dwReservedBits = new uint[3];

  public byte bConfigDataType;
}



/* How to combine alpha blending graphic data */
public class _DXVA_ConfigAlphaCombine
{

  // Operation Indicated
  public uint dwFunction;

  // Alignment
  public uint[] dwReservedBits = new uint[3];

  public byte bConfigBlendType;
  public byte bConfigPictureResizing;
  public byte bConfigOnlyUsePicDestRectArea;
  public byte bConfigGraphicResizing;
  public byte bConfigWholePlaneAlpha;

}



/* AYUV sample for 16-entry YUV palette or graphic surface */

public class _DXVA_AYUVsample2
{
  public byte bCrValue;
  public byte bCbValue;
  public byte bY_Value;
  public byte bSampleAlpha8;
}

/* Macros for IA44 alpha blending surface samples */


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_IA44index(ptr) (((*(ptr)) & 0xF0) >> 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_IA44alpha(ptr) ((*(ptr)) & 0x0F)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define writeDXVA_IA44(ptr, idx, alpha) ((*(ptr)) = (((idx) << 4) | (alpha)))

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_IA44index(ptr, idx) ((*(ptr)) |= ((idx) << 4))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_IA44alpha(ptr, alpha) ((*(ptr)) |= (alpha))

/* Macros for AI44 alpha blending surface samples */


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_AI44index(ptr) ((*(ptr)) & 0x0F)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_AI44alpha(ptr) (((*(ptr)) & 0xF0) >> 4)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define writeDXVA_AI44(ptr, idx, alpha) ((*(ptr)) = (((alpha) << 4) | (idx)))

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_AI44index(ptr, idx) ((*(ptr)) |= (idx))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_AI44alpha(ptr, alpha) ((*(ptr)) |= ((alpha) << 4))


/* Highlight data structure */

public class _DXVA_Highlight
{
  public ushort wHighlightActive;
  public ushort wHighlightIndices;
  public ushort wHighlightAlphas;
  public RECT HighlightRect = new RECT();
}


/* Alpha blend combination */

public class _DXVA_BlendCombination
{
  public ushort wPictureSourceIndex;
  public ushort wBlendedDestinationIndex;
  public RECT PictureSourceRect16thPel = new RECT();
  public RECT PictureDestinationRect = new RECT();
  public RECT GraphicSourceRect = new RECT();
  public RECT GraphicDestinationRect = new RECT();
  public ushort wBlendDelay;
  public byte bBlendOn;
  public byte bWholePlaneAlpha;
  public _DXVA_AYUVsample2 OutsideYUVcolor = new _DXVA_AYUVsample2();
}


// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(push, 16)







// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(pop)

/*
 * Other forms of pictures are constructed in the obvious way
 * from the above by adjusting the number of residual difference
 * blocks, the number of motion vectors per macroblock, etc.
 */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_MBskipsFollowing(ptr) (((ptr)->dwMB_SNL & 0xFF000000) >> 24)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_MBdataLocation(ptr) (((ptr)->dwMB_SNL & 0x00FFFFFF))

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define writeDXVA_MB_SNL(ptr, skips, dloc) ((ptr)->dwMB_SNL = (((skips) << 24) | (dloc)))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_MBskipsFollowing(ptr, skips) ((ptr)->dwMB_SNL |= ((skips) << 24))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_MBdataLocation(ptr, dloc) ((ptr)->dwMB_SNL |= (dloc))

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_MvertFieldSel_3(ptr) (((ptr)->wMBtype & 0x8000) >> 15)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_MvertFieldSel_2(ptr) (((ptr)->wMBtype & 0x4000) >> 14)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_MvertFieldSel_1(ptr) (((ptr)->wMBtype & 0x2000) >> 13)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_MvertFieldSel_0(ptr) (((ptr)->wMBtype & 0x1000) >> 12)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_ReservedBits(ptr) (((ptr)->wMBtype & 0x0800) >> 11)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_HostResidDiff(ptr) (((ptr)->wMBtype & 0x0400) >> 10)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_MotionType(ptr) (((ptr)->wMBtype & 0x0300) >> 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_MBscanMethod(ptr) (((ptr)->wMBtype & 0x00C0) >> 6)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_FieldResidual(ptr) (((ptr)->wMBtype & 0x0020) >> 5)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_H261LoopFilter(ptr) (((ptr)->wMBtype & 0x0010) >> 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Motion4MV(ptr) (((ptr)->wMBtype & 0x0008) >> 3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_MotionBackward(ptr) (((ptr)->wMBtype & 0x0004) >> 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_MotionForward(ptr) (((ptr)->wMBtype & 0x0002) >> 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_IntraMacroblock(ptr) (((ptr)->wMBtype & 0x0001))

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_MvertFieldSel_3(ptr) ((ptr)->wMBtype |= 0x8000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_MvertFieldSel_2(ptr) ((ptr)->wMBtype |= 0x4000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_MvertFieldSel_1(ptr) ((ptr)->wMBtype |= 0x2000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_MvertFieldSel_0(ptr) ((ptr)->wMBtype |= 0x1000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_ReservedBits(ptr) ((ptr)->wMBtype |= 0x0800)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_HostResidDiff(ptr) ((ptr)->wMBtype |= 0x0400)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_MotionType(ptr, value) ((ptr)->wMBtype |= ((value) << 8))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_MBscanMethod(ptr, value) ((ptr)->wMBtype |= ((value) << 6))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_FieldResidual(ptr) ((ptr)->wMBtype |= 0x0020)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_H261LoopFilter(ptr) ((ptr)->wMBtype |= 0x0010)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_Motion4MV(ptr) ((ptr)->wMBtype |= 0x0008)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_MotionBackward(ptr) ((ptr)->wMBtype |= 0x0004)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_MotionForward(ptr) ((ptr)->wMBtype |= 0x0002)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define setDXVA_IntraMacroblock(ptr) ((ptr)->wMBtype |= 0x0001)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Y___0coded(ptr) (((ptr)->wPatternCode & 0x0800) >> 11)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Y___1coded(ptr) (((ptr)->wPatternCode & 0x0400) >> 10)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Y___2coded(ptr) (((ptr)->wPatternCode & 0x0200) >> 9)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Y___3coded(ptr) (((ptr)->wPatternCode & 0x0100) >> 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cb__4coded(ptr) (((ptr)->wPatternCode & 0x0080) >> 7)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cr__5coded(ptr) (((ptr)->wPatternCode & 0x0040) >> 6)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cb__6coded(ptr) (((ptr)->wPatternCode & 0x0020) >> 5)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cr__7coded(ptr) (((ptr)->wPatternCode & 0x0010) >> 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cb__8coded(ptr) (((ptr)->wPatternCode & 0x0008) >> 3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cb__9coded(ptr) (((ptr)->wPatternCode & 0x0004) >> 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cr_10coded(ptr) (((ptr)->wPatternCode & 0x0002) >> 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cr_11coded(ptr) (((ptr)->wPatternCode & 0x0001))

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Y___0oflow(ptr) (((ptr)->wPC_Overflow & 0x0800) >> 11)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Y___1oflow(ptr) (((ptr)->wPC_Overflow & 0x0400) >> 10)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Y___2oflow(ptr) (((ptr)->wPC_Overflow & 0x0200) >> 9)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Y___3oflow(ptr) (((ptr)->wPC_Overflow & 0x0100) >> 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cb__4oflow(ptr) (((ptr)->wPC_Overflow & 0x0080) >> 7)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cr__5oflow(ptr) (((ptr)->wPC_Overflow & 0x0040) >> 6)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cb__6oflow(ptr) (((ptr)->wPC_Overflow & 0x0020) >> 5)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cr__7oflow(ptr) (((ptr)->wPC_Overflow & 0x0010) >> 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cb__8oflow(ptr) (((ptr)->wPC_Overflow & 0x0008) >> 3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cb__9oflow(ptr) (((ptr)->wPC_Overflow & 0x0004) >> 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cr_10oflow(ptr) (((ptr)->wPC_Overflow & 0x0002) >> 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define readDXVA_Cr_11oflow(ptr) (((ptr)->wPC_Overflow & 0x0001))

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(pop, BeforeDXVApacking)


// -------------------------------------------------------------------------
// 
// D3DFORMAT describes a pixel memory layout, DXVA sample format contains
// additional information that describes how the pixels should be interpreted.
// 
// -------------------------------------------------------------------------

#if ! DXVABit
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXVABit(__x) (1 << __x)
#define DXVABit
#endif

public enum _DXVA_SampleFormat
{
    DXVA_SampleFormatMask = 0xFF, // 8 bits used for DXVA Sample format
    DXVA_SampleUnknown = 0,
    DXVA_SamplePreviousFrame = 1,
    DXVA_SampleProgressiveFrame = 2,
    DXVA_SampleFieldInterleavedEvenFirst = 3,
    DXVA_SampleFieldInterleavedOddFirst = 4,
    DXVA_SampleFieldSingleEven = 5,
    DXVA_SampleFieldSingleOdd = 6,
    DXVA_SampleSubStream = 7
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXVA_ExtractSampleFormat(_sf) ((_sf) & (DXVA_SampleFormatMask))

// -------------------------------------------------------------------------
// 
// DXVA Extended color data - occupies the HIWORD of the SampleFormat DWORD
// use the DXVA_ExtractExtColorData macro to extract the individual color
// data fields.
// 
// The packed form is:
//   VideoTransferFunction  (bits 15..12)
//   VideoPrimaries         (bits 11..8)
//   VideoLighting          (bits 7..5)
//   VideoTransferMatrix (Y'Cb'Cr') OR VideoNominalRange (RGB images) (bits 4..2)
//   VideoChromaSubsampling (bits 1..0)
// 
// -------------------------------------------------------------------------

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DXVA_ExtractExtColorData(_sf, _Mask, _Shift) (((_sf) >> (_Shift)) & (_Mask))


public enum _DXVA_VideoTransferFunction
{
    DXVA_VideoTransFuncMask = (1 << 15) | (1 << 14) | (1 << 13) | (1 << 12),
    DXVA_VideoTransFuncShift = (DefineConstants.DXVA_ExtColorData_ShiftBase + 12),

    DXVA_VideoTransFunc_Unknown = 0,
    DXVA_VideoTransFunc_10 = 1,
    DXVA_VideoTransFunc_18 = 2,
    DXVA_VideoTransFunc_20 = 3,
    DXVA_VideoTransFunc_22 = 4,
    DXVA_VideoTransFunc_22_8bit = 5,
    DXVA_VideoTransFunc_22_8bit_240M = 6,
    DXVA_VideoTransFunc_24_8bit_sRGB = 7,
    DXVA_VideoTransFunc_28 = 8
}


public enum _DXVA_VideoPrimaries
{
    DXVA_VideoPrimariesMask = (1 << 11) | (1 << 10) | (1 << 9) | (1 << 8),
    DXVA_VideoPrimariesShift = (DefineConstants.DXVA_ExtColorData_ShiftBase + 8),

    DXVA_VideoPrimaries_Unknown = 0,
    DXVA_VideoPrimaries_BT601 = 1,
    DXVA_VideoPrimaries_BT709 = 2,
    DXVA_VideoPrimaries_BT470_2_SysM = 3,
    DXVA_VideoPrimaries_BT470_2_SysBG = 4,
    DXVA_VideoPrimaries_SMPTE170M = 5,
    DXVA_VideoPrimaries_SMPTE240M = 6,
    DXVA_VideoPrimaries_EBU3213 = 7,
    DXVA_VideoPrimaries_SMPTE_C = 8
}


public enum _DXVA_VideoLighting
{
    DXVA_VideoLightingMask = (1 << 7) | (1 << 6) | (1 << 5),
    DXVA_VideoLightingShift = (DefineConstants.DXVA_ExtColorData_ShiftBase + 5),

    DXVA_VideoLighting_Unknown = 0,
    DXVA_VideoLighting_bright = 1,
    DXVA_VideoLighting_office = 2,
    DXVA_VideoLighting_dim = 3,
    DXVA_VideoLighting_dark = 4
}


// -------------------------------------------------------------------------
// Note:
// 
// DXVA_NominalRange and DXVA_VideoTransferMatrix are unioned together.
// 
// -------------------------------------------------------------------------
// 

public enum _DXVA_VideoTransferMatrix
{
    DXVA_VideoTransferMatrixMask = (1 << 4) | (1 << 3) | (1 << 2),
    DXVA_VideoTransferMatrixShift = (DefineConstants.DXVA_ExtColorData_ShiftBase + 2),

    DXVA_VideoTransferMatrix_Unknown = 0,
    DXVA_VideoTransferMatrix_BT709 = 1,
    DXVA_VideoTransferMatrix_BT601 = 2,
    DXVA_VideoTransferMatrix_SMPTE240M = 3
}


public enum _DXVA_NominalRange
{
    DXVA_NominalRangeMask = (1 << 4) | (1 << 3) | (1 << 2),
    DXVA_NominalRangeShift = (DefineConstants.DXVA_ExtColorData_ShiftBase + 2),

    DXVA_NominalRange_Normal = 0,
    DXVA_NominalRange_Wide = 1
}


public enum _DXVA_VideoChromaSubsampling
{
    DXVA_VideoChromaSubsamplingMask = (1 << 1) | (1 << 0),
    DXVA_VideoChromaSubsamplingShift = (DefineConstants.DXVA_ExtColorData_ShiftBase + 0),

    DXVA_VideoChromaSubsampling_Unknown = 0,
    DXVA_VideoChromaSubsampling_non_cosited = 1,
    DXVA_VideoChromaSubsampling_cosited = 2
}




// -------------------------------------------------------------------------
// 
// The definitions that follow describe the video de-interlace interface
// between the VMR and the graphics device driver.  This interface is not
// accessable via the IAMVideoAccelerator interface.
// 
// -------------------------------------------------------------------------
// 


// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_DeinterlaceBobDevice, 0x335aa36e,0x7884,0x43a4,0x9c,0x91,0x7f,0x87,0xfa,0xf3,0xe3,0x7e);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_DeinterlaceContainerDevice, 0x0e85cb93,0x3046,0x4ff0,0xae,0xcc,0xd5,0x8c,0xb5,0xf0,0x35,0xfd);


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if (DIRECT3D_VERSION < 0x0800) || !DIRECT3D_VERSION
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
public enum AnonymousEnum
{
    D3DPOOL_DEFAULT = 0,
    D3DPOOL_MANAGED = 1,
    D3DPOOL_SYSTEMMEM = 2,
    D3DPOOL_SCRATCH = 3,
    D3DPOOL_LOCALVIDMEM = 4,
    D3DPOOL_NONLOCALVIDMEM = 5,
    D3DPOOL_FORCE_DWORD = 0x7fffffff
}
#endif


// -------------------------------------------------------------------------
// data structures shared by User mode and Kernel mode.
// -------------------------------------------------------------------------
// 

public class _DXVA_Frequency
{
    public uint Numerator;
    public uint Denominator;
}

public class _DXVA_VideoDesc
{
    public uint Size;
    public uint SampleWidth;
    public uint SampleHeight;
    public uint SampleFormat; // also contains extend color data
    public uint d3dFormat;
    public _DXVA_Frequency InputSampleFreq = new _DXVA_Frequency();
    public _DXVA_Frequency OutputFrameFreq = new _DXVA_Frequency();
}

public enum _DXVA_VideoProcessCaps
{
    DXVA_VideoProcess_None = 0x0000,
    DXVA_VideoProcess_YUV2RGB = 0x0001,
    DXVA_VideoProcess_StretchX = 0x0002,
    DXVA_VideoProcess_StretchY = 0x0004,
    DXVA_VideoProcess_AlphaBlend = 0x0008,
    DXVA_VideoProcess_SubRects = 0x0010,
    DXVA_VideoProcess_SubStreams = 0x0020,
    DXVA_VideoProcess_SubStreamsExtended = 0x0040,
    DXVA_VideoProcess_YUV2RGBExtended = 0x0080,
    DXVA_VideoProcess_AlphaBlendExtended = 0x0100
}

public enum _DXVA_DeinterlaceTech
{

    // the algorithm is unknown or proprietary
    DXVA_DeinterlaceTech_Unknown = 0x0000,

    // the algorithm creates the missing lines by repeating
    // the line either above or below it - this method will look very jaggy and
    // isn't recommended
    DXVA_DeinterlaceTech_BOBLineReplicate = 0x0001,

    // The algorithm creates the missing lines by vertically stretching each
    // video field by a factor of two by averaging two lines
    DXVA_DeinterlaceTech_BOBVerticalStretch = 0x0002,

    // or using a [-1, 9, 9, -1]/16 filter across four lines.
    DXVA_DeinterlaceTech_BOBVerticalStretch4Tap = 0x0100,

    // the pixels in the missing line are recreated by a median filtering operation
    DXVA_DeinterlaceTech_MedianFiltering = 0x0004,

    // the pixels in the missing line are recreated by an edge filter.
    // In this process, spatial directional filters are applied to determine
    // the orientation of edges in the picture content, and missing
    // pixels are created by filtering along (rather than across) the
    // detected edges.
    DXVA_DeinterlaceTech_EdgeFiltering = 0x0010,

    // the pixels in the missing line are recreated by switching on a field by
    // field basis between using either spatial or temporal interpolation
    // depending on the amount of motion.
    DXVA_DeinterlaceTech_FieldAdaptive = 0x0020,

    // the pixels in the missing line are recreated by switching on a pixel by pixel
    // basis between using either spatial or temporal interpolation depending on
    // the amount of motion..
    DXVA_DeinterlaceTech_PixelAdaptive = 0x0040,

    // Motion Vector Steering  identifies objects within a sequence of video
    // fields.  The missing pixels are recreated after first aligning the
    // movement axes of the individual objects in the scene to make them
    // parallel with the time axis.
    DXVA_DeinterlaceTech_MotionVectorSteered = 0x0080

}


public class _DXVA_VideoSample
{
    public long rtStart;
    public long rtEnd;
    public DXVA_SampleFormat SampleFormat = new DXVA_SampleFormat(); // only lower 8 bits used
    public object lpDDSSrcSurface;
}



// -------------------------------------------------------------------------
// DeinterlaceBltEx declarations
// -------------------------------------------------------------------------
// 

public enum _DXVA_SampleFlags
{
    DXVA_SampleFlagsMask = (1 << 3) | (1 << 2) | (1 << 1) | (1 << 0),

    DXVA_SampleFlag_Palette_Changed = 0x0001,
    DXVA_SampleFlag_SrcRect_Changed = 0x0002,
    DXVA_SampleFlag_DstRect_Changed = 0x0004,
    DXVA_SampleFlag_ColorData_Changed = 0x0008
}

public enum _DXVA_DestinationFlags
{
    DXVA_DestinationFlagMask = (1 << 3) | (1 << 2) | (1 << 1) | (1 << 0),

    DXVA_DestinationFlag_Background_Changed = 0x0001,
    DXVA_DestinationFlag_TargetRect_Changed = 0x0002,
    DXVA_DestinationFlag_ColorData_Changed = 0x0004,
    DXVA_DestinationFlag_Alpha_Changed = 0x0008
}


public class _DXVA_VideoSample2
{
    public long rtStart;
    public long rtEnd;
    public uint SampleFormat;
    public uint SampleFlags;
    public object lpDDSSrcSurface;
    public RECT rcSrc = new RECT();
    public RECT rcDst = new RECT();
    public _DXVA_AYUVsample2[] Palette = Arrays.InitializeWithDefaultInstances<_DXVA_AYUVsample2>(16);
}

public class _DXVA_DeinterlaceCaps
{
    public uint Size;
    public uint NumPreviousOutputFrames;
    public uint InputPool;
    public uint NumForwardRefSamples;
    public uint NumBackwardRefSamples;
    public uint d3dOutputFormat;
    public DXVA_VideoProcessCaps VideoProcessingCaps = new DXVA_VideoProcessCaps();
    public DXVA_DeinterlaceTech DeinterlaceTechnology = new DXVA_DeinterlaceTech();
}




// -------------------------------------------------------------------------
// Data types used with RenderMoComp in kernel mode
// -------------------------------------------------------------------------
// 

// Function codes for RenderMoComp


public class _DXVA_DeinterlaceBlt
{
    public uint Size;
    public uint Reserved;
    public long rtTarget;
    public RECT DstRect = new RECT();
    public RECT SrcRect = new RECT();
    public uint NumSourceSurfaces;
    public float Alpha;
    public _DXVA_VideoSample[] Source = Arrays.InitializeWithDefaultInstances<_DXVA_VideoSample>(DefineConstants.MAX_DEINTERLACE_SURFACES);
}

// lpInput => DXVA_DeinterlaceBlt*
// lpOuput => NULL /* not currently used */


public class _DXVA_DeinterlaceBltEx
{
    public uint Size;
    public _DXVA_AYUVsample2 BackgroundColor = new _DXVA_AYUVsample2();
    public RECT rcTarget = new RECT();
    public long rtTarget;
    public uint NumSourceSurfaces;
    public float Alpha;
    public _DXVA_VideoSample2[] Source = Arrays.InitializeWithDefaultInstances<_DXVA_VideoSample2>(DefineConstants.MAX_DEINTERLACE_SURFACES);
    public uint DestinationFormat;
    public uint DestinationFlags;
}

// lpInput => DXVA_DeinterlaceBltEx*
// lpOuput => NULL /* not currently used */


public class _DXVA_DeinterlaceQueryAvailableModes
{
    public uint Size;
    public uint NumGuids;
    public GUID[] Guids = Arrays.InitializeWithDefaultInstances<GUID>(DefineConstants.MAX_DEINTERLACE_DEVICE_GUIDS);
}

// lpInput => DXVA_VideoDesc*
// lpOuput => DXVA_DeinterlaceQueryAvailableModes*


public class _DXVA_DeinterlaceQueryModeCaps
{
    public uint Size;
    public GUID Guid = new GUID();
    public _DXVA_VideoDesc VideoDesc = new _DXVA_VideoDesc();
}

// lpInput => DXVA_DeinterlaceQueryModeCaps*
// lpOuput => DXVA_DeinterlaceCaps*



// -------------------------------------------------------------------------
// 
// The definitions that follow describe the video ProcAmp interface
// between the VMR and the graphics device driver.  This interface is not
// accessable via the IAMVideoAccelerator interface.
// 
// -------------------------------------------------------------------------
// 

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_ProcAmpControlDevice, 0x9f200913,0x2ffd,0x4056,0x9f,0x1e,0xe1,0xb5,0x08,0xf2,0x2d,0xcf);

public enum _DXVA_ProcAmpControlProp
{
    DXVA_ProcAmp_None = 0x0000,
    DXVA_ProcAmp_Brightness = 0x0001,
    DXVA_ProcAmp_Contrast = 0x0002,
    DXVA_ProcAmp_Hue = 0x0004,
    DXVA_ProcAmp_Saturation = 0x0008
}


public class _DXVA_ProcAmpControlCaps
{
    public uint Size;
    public uint InputPool;
    public uint d3dOutputFormat;
    public uint ProcAmpControlProps; // see DXVA_ProcAmpControlProp
    public uint VideoProcessingCaps; // see DXVA_VideoProcessCaps
}

// lpInput => DXVA_VideoDesc*
// lpOuput => DXVA_ProcAmpControlCaps*


public class _DXVA_ProcAmpControlQueryRange
{
    public uint Size;
    public DXVA_ProcAmpControlProp ProcAmpControlProp = new DXVA_ProcAmpControlProp();
    public _DXVA_VideoDesc VideoDesc = new _DXVA_VideoDesc();
}

public class _DXVA_VideoPropertyRange
{
    public float MinValue;
    public float MaxValue;
    public float DefaultValue;
    public float StepSize;
}

// lpInput => DXVA_ProcAmpControlQueryRange*
// lpOuput => DXVA_VideoPropertyRange*


public class _DXVA_ProcAmpControlBlt
{
    public uint Size;
    public RECT DstRect = new RECT();
    public RECT SrcRect = new RECT();
    public float Alpha;
    public float Brightness;
    public float Contrast;
    public float Hue;
    public float Saturation;
}

// lpInput => DXVA_ProcAmpControlBlt*
// lpOuput => NULL /* not currently used */



// -------------------------------------------------------------------------
// 
// The definitions that follow describe the Certified Output Protection
// Protocol between the VMR and the graphics device driver.  This interface
// is not accessable via the IAMVideoAccelerator interface.
// 
// -------------------------------------------------------------------------
// 



// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_COPPDevice, 0xd2457add,0x8999,0x45ed,0x8a,0x8a,0xd1,0xaa,0x04,0x7b,0xa4,0xd5);


// -------------------------------------------------------------------------
// COPPGetCertificateLength
// -------------------------------------------------------------------------
// lpInput => NULL
// lpOuput => DWORD*


// -------------------------------------------------------------------------
// COPPKeyExchange
// -------------------------------------------------------------------------
// lpInputData => NULL
// lpOuputData => GUID*


// -------------------------------------------------------------------------
// COPPSequenceStart
// -------------------------------------------------------------------------
public class _DXVA_COPPSignature
{
    public byte[] Signature = new byte[256];
}

// lpInputData => DXVA_COPPSignature*
// lpOuputData => NULL



// -------------------------------------------------------------------------
// COPPCommand
// -------------------------------------------------------------------------
public class _DXVA_COPPCommand
{
    public GUID macKDI = new GUID(); //   16 bytes
    public GUID guidCommandID = new GUID(); //   16 bytes
    public uint dwSequence; //    4 bytes
    public uint cbSizeData; //    4 bytes
    public byte[] CommandData = new byte[4056]; // 4056 bytes (4056+4+4+16+16 = 4096)
}

// lpInputData => DXVA_COPPCommand*
// lpOuputData => NULL


// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_COPPSetProtectionLevel, 0x9bb9327c,0x4eb5,0x4727,0x9f,0x00,0xb4,0x2b,0x09,0x19,0xc0,0xda);

public class _DXVA_COPPSetProtectionLevelCmdData
{
    public uint ProtType;
    public uint ProtLevel;
    public uint TypeSpecificMask;
    public uint TypeSpecificInfo;
}


// Set the HDCP protection level - (0 - 1 DWORD, 4 bytes)

public enum _COPP_HDCP_Protection_Level
{
    COPP_HDCP_Level0 = 0,
    COPP_HDCP_LevelMin = COPP_HDCP_Level0,
    COPP_HDCP_Level1 = 1,
    COPP_HDCP_LevelMax = COPP_HDCP_Level1,
    COPP_HDCP_ForceDWORD = 0x7fffffff
}

public enum _COPP_CGMSA_Protection_Level
{
    COPP_CGMSA_CopyFreely = 0,
    COPP_CGMSA_LevelMin = COPP_CGMSA_CopyFreely,
    COPP_CGMSA_CopyOneGeneration = 2,
    COPP_CGMSA_CopyNever = 3,
    COPP_CGMSA_RedistributionControlRequired = 0x04,
    COPP_CGMSA_LevelMax = (COPP_CGMSA_RedistributionControlRequired + COPP_CGMSA_CopyNever),
    COPP_CGMSA_ForceDWORD = 0x7fffffff
}


public enum _COPP_ACP_Protection_Level
{
    COPP_ACP_Level0 = 0,
    COPP_ACP_LevelMin = COPP_ACP_Level0,
    COPP_ACP_Level1 = 1,
    COPP_ACP_Level2 = 2,
    COPP_ACP_Level3 = 3,
    COPP_ACP_LevelMax = COPP_ACP_Level3,
    COPP_ACP_ForceDWORD = 0x7fffffff
}



// 
// Bit flags of possible protection types.  Note that it is possible to apply
// different protection settings to a single connector.
// 
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
public enum AnonymousEnum2
{
    COPP_ProtectionType_Unknown = 0x80000000,
    COPP_ProtectionType_None = 0x00000000,
    COPP_ProtectionType_HDCP = 0x00000001,
    COPP_ProtectionType_ACP = 0x00000002,
    COPP_ProtectionType_CGMSA = 0x00000004,
    COPP_ProtectionType_Mask = 0x80000007,
    COPP_ProtectionType_Reserved = 0x7FFFFFF8
}

// -------------------------------------------------------------------------
// COPPQueryStatus
// -------------------------------------------------------------------------
public class _DXVA_COPPStatusInput
{
    public GUID rApp = new GUID(); //   16 bytes
    public GUID guidStatusRequestID = new GUID(); //   16 bytes
    public uint dwSequence; //    4 bytes
    public uint cbSizeData; //    4 bytes
    public byte[] StatusData = new byte[4056]; // 4056 bytes (4056+4+4+16+16 = 4096)
}

public class _DXVA_COPPStatusOutput
{
    public GUID macKDI = new GUID(); //   16 bytes
    public uint cbSizeData; //    4 bytes
    public byte[] COPPStatus = new byte[4076]; // 4076 bytes (4076+16+4 = 4096)
}

public enum _COPP_StatusFlags
{
    COPP_StatusNormal = 0x00,
    COPP_LinkLost = 0x01,
    COPP_RenegotiationRequired = 0x02,
    COPP_StatusFlagsReserved = 0xFFFFFFFC
}

public class _DXVA_COPPStatusData
{
    public GUID rApp = new GUID();
    public uint dwFlags; // See COPP_StatusFlags above
    public uint dwData;
    public uint TypeSpecificMask;
    public uint TypeSpecificInfo;
}

public class _DXVA_COPPStatusDisplayData
{
    public GUID rApp = new GUID();
    public uint dwFlags; // See COPP_StatusFlags above
    public uint DisplayWidth;
    public uint Displayheight;
    public uint Format; // also contains extended color data
    public uint d3dFormat;
    public uint FreqNumerator;
    public uint FreqDenominator;
}

public enum _COPP_StatusHDCPFlags
{
    COPP_HDCPReceiver = 0x00,
    COPP_HDCPRepeater = 0x01
}

public class _DXVA_COPPStatusHDCPKeyData
{
    public GUID rApp = new GUID();
    public uint dwFlags; // See COPP_StatusFlags above
    public uint dwHDCPFlags; // See COPP_StatusHDCPFlags above
    public GUID BKey = new GUID(); // Lower 40 bits
    public GUID reserved1 = new GUID();
    public GUID reserved2 = new GUID();
}


// lpInputData => DXVA_COPPStatusInput*
// lpOuputData => DXVA_COPPStatusOutput*


// 
// Status GUID and enumerations
// 
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_COPPQueryConnectorType, 0x81d0bfd5,0x6afe,0x48c2,0x99,0xc0,0x95,0xa0,0x8f,0x97,0xc5,0xda);

public enum _COPP_ConnectorType
{
    COPP_ConnectorType_Unknown = -1,
    COPP_ConnectorType_VGA = 0,
    COPP_ConnectorType_SVideo = 1,
    COPP_ConnectorType_CompositeVideo = 2,
    COPP_ConnectorType_ComponentVideo = 3,
    COPP_ConnectorType_DVI = 4,
    COPP_ConnectorType_HDMI = 5,
    COPP_ConnectorType_LVDS = 6,
    COPP_ConnectorType_TMDS = 7,
    COPP_ConnectorType_D_JPN = 8,
    COPP_ConnectorType_Internal = 0x80000000, // can be combined with the other connector types
    COPP_ConnectorType_ForceDWORD = 0x7fffffff // force 32-bit size enum
}

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_COPPQueryProtectionType, 0x38f2a801,0x9a6c,0x48bb,0x91,0x07,0xb6,0x69,0x6e,0x6f,0x17,0x97);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_COPPQueryLocalProtectionLevel, 0xb2075857,0x3eda,0x4d5d,0x88,0xdb,0x74,0x8f,0x8c,0x1a,0x05,0x49);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_COPPQueryGlobalProtectionLevel, 0x1957210a,0x7766,0x452a,0xb9,0x9a,0xd2,0x7a,0xed,0x54,0xf0,0x3a);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_COPPQueryDisplayData, 0xd7bf1ba3,0xad13,0x4f8e,0xaf,0x98,0x0d,0xcb,0x3c,0xa2,0x04,0xcc);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_COPPQueryHDCPKeyData, 0xdb59d74, 0xa992, 0x492e, 0xa0, 0xbd, 0xc2, 0x3f, 0xda, 0x56, 0x4e, 0x0);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DXVA_COPPQueryBusData, 0xc6f4d673, 0x6174, 0x4184, 0x8e, 0x35, 0xf6, 0xdb, 0x52, 0x0, 0xbc, 0xba);

public enum _COPP_BusType
{
    COPP_BusType_Unknown = 0,
    COPP_BusType_PCI = 1,
    COPP_BusType_PCIX = 2,
    COPP_BusType_PCIExpress = 3,
    COPP_BusType_AGP = 4,
    COPP_BusType_Integrated = 0x80000000, // can be combined with the other bus types
    COPP_BusType_ForceDWORD = 0x7fffffff // force 32-bit size enum
}



#if __cplusplus
#endif

