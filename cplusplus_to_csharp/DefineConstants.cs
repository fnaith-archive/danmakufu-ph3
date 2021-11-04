// C++ TO C# CONVERTER TODO TASK: Check to ensure that the necessary preprocessor flags are defined:
internal static class DefineConstants
{
    public const int _WIN32_WINNT = 0x0500;
    public const int STRICT = 1;
    public const int DIRECTINPUT_VERSION = 0x0800;
    public const int DIRECTSOUND_VERSION = 0x0900;
    public const int DIRECTSOUND_VERSION = 0x0900; // Version 9.0
    public const int OV_FALSE = -1;
    public const int OV_EOF = -2;
    public const int OV_HOLE = -3;
    public const int OV_EREAD = -128;
    public const int OV_EFAULT = -129;
    public const int OV_EIMPL = -130;
    public const int OV_EINVAL = -131;
    public const int OV_ENOTVORBIS = -132;
    public const int OV_EBADHEADER = -133;
    public const int OV_EVERSION = -134;
    public const int OV_ENOTAUDIO = -135;
    public const int OV_EBADPACKET = -136;
    public const int OV_EBADLINK = -137;
    public const int OV_ENOSEEK = -138;
    public const int NOTOPEN = 0;
    public const int PARTOPEN = 1;
    public const int OPENED = 2;
    public const int STREAMSET = 3;
    public const int INITSET = 4;
    public const string CFSTR_VFW_FILTERLIST = "Video for Windows 4 Filters";
    public const int __REQUIRED_RPCNDR_H_VERSION__ = 475;
    public const int __REQUIRED_RPCNDR_H_VERSION__ = 440;
    public const int CDEF_CLASS_DEFAULT = 0x0001;
    public const int CDEF_BYPASS_CLASS_MANAGER = 0x0002;
    public const int CDEF_MERIT_ABOVE_DO_NOT_USE = 0x0008;
    public const int CDEF_DEVMON_CMGR_DEVICE = 0x0010;
    public const int CDEF_DEVMON_DMO = 0x0020;
    public const int CDEF_DEVMON_PNP_DEVICE = 0x0040;
    public const int CDEF_DEVMON_FILTER = 0x0080;
    public const int CDEF_DEVMON_SELECTIVE_MASK = 0x00f0;
    public const int CHARS_IN_GUID = 39;
    public const int MAX_PIN_NAME = 128;
    public const int MAX_FILTER_NAME = 128;
    public const int AM_GBF_PREVFRAMESKIPPED = 1;
    public const int AM_GBF_NOTASYNCPOINT = 2;
    public const int AM_GBF_NOWAIT = 4;
    public const int AM_GBF_NODDSURFACELOCK = 8;
    public const double AMF_AUTOMATICGAIN = -1.0;
    public const int AnalogVideo_NTSC_Mask = 0x00000007;
    public const int AnalogVideo_PAL_Mask = 0x00100FF0;
    public const int AnalogVideo_SECAM_Mask = 0x000FF000;
    public const int KSPROPERTY_SUPPORT_GET = 1;
    public const int KSPROPERTY_SUPPORT_GET = 0x00000001;
    public const int KSPROPERTY_SUPPORT_SET = 2;
    public const int KSPROPERTY_SUPPORT_SET = 0x00000002;
    public const int MPEG2_PROGRAM_STREAM_MAP = 0x00000000;
    public const int MPEG2_PROGRAM_ELEMENTARY_STREAM = 0x00000001;
    public const int MPEG2_PROGRAM_DIRECTORY_PES_PACKET = 0x00000002;
    public const int MPEG2_PROGRAM_PACK_HEADER = 0x00000003;
    public const int MPEG2_PROGRAM_PES_STREAM = 0x00000004;
    public const int MPEG2_PROGRAM_SYSTEM_HEADER = 0x00000005;
    public const int SUBSTREAM_FILTER_VAL_NONE = 0x10000000;
    public const int AM_GETDECODERCAP_QUERY_VMR_SUPPORT = 0x00000001;
    public const int VMR_NOTSUPPORTED = 0x00000000;
    public const int VMR_SUPPORTED = 0x00000001;
    public const int AM_QUERY_DECODER_VMR_SUPPORT = 0x00000001;
    public const int AM_QUERY_DECODER_DXVA_1_SUPPORT = 0x00000002;
    public const int AM_QUERY_DECODER_DVD_SUPPORT = 0x00000003;
    public const int AM_QUERY_DECODER_ATSC_SD_SUPPORT = 0x00000004;
    public const int AM_QUERY_DECODER_ATSC_HD_SUPPORT = 0x00000005;
    public const int AM_GETDECODERCAP_QUERY_VMR9_SUPPORT = 0x00000006;
    public const int DECODER_CAP_NOTSUPPORTED = 0x00000000;
    public const int DECODER_CAP_SUPPORTED = 0x00000001;
    public const int DIRECTDRAW_VERSION = 0x0700;
#if ! (_WIN32 && ! _NO_COM) && ! NT_BUILD_ENVIRONMENT && !WINNT
    public const uint CO_E_NOTINITIALIZED = 0x800401F0;
#endif
    public const int _FACDD = 0x876;
    public const int DDENUM_ATTACHEDSECONDARYDEVICES = 0x00000001;
    public const int DDENUM_DETACHEDSECONDARYDEVICES = 0x00000002;
    public const int DDENUM_NONDISPLAYDEVICES = 0x00000004;
    public const string REGSTR_KEY_DDHW_DESCRIPTION = "Description";
    public const string REGSTR_KEY_DDHW_DRIVERNAME = "DriverName";
    public const string REGSTR_PATH_DDHW = "Hardware\\DirectDrawDrivers";
    public const int DDCREATE_HARDWAREONLY = 0x00000001;
    public const int DDCREATE_EMULATIONONLY = 0x00000002;
    public const int DD_ROP_SPACE = 256 / 32; // space required to store ROP array
    public const int MAX_DDDEVICEID_STRING = 512;
    public const int DDGDI_GETHOSTIDENTIFIER = 0x00000001;
    public const int DDSD_CAPS = 0x00000001; // default
    public const int DDSD_HEIGHT = 0x00000002;
    public const int DDSD_WIDTH = 0x00000004;
    public const int DDSD_PITCH = 0x00000008;
    public const int DDSD_BACKBUFFERCOUNT = 0x00000020;
    public const int DDSD_ZBUFFERBITDEPTH = 0x00000040;
    public const int DDSD_ALPHABITDEPTH = 0x00000080;
    public const int DDSD_LPSURFACE = 0x00000800;
    public const int DDSD_PIXELFORMAT = 0x00001000;
    public const int DDSD_CKDESTOVERLAY = 0x00002000;
    public const int DDSD_CKDESTBLT = 0x00004000;
    public const int DDSD_CKSRCOVERLAY = 0x00008000;
    public const int DDSD_CKSRCBLT = 0x00010000;
    public const int DDSD_MIPMAPCOUNT = 0x00020000;
    public const int DDSD_REFRESHRATE = 0x00040000;
    public const int DDSD_LINEARSIZE = 0x00080000;
    public const int DDSD_TEXTURESTAGE = 0x00100000;
    public const int DDSD_FVF = 0x00200000;
    public const int DDSD_SRCVBHANDLE = 0x00400000;
    public const int DDSD_DEPTH = 0x00800000;
    public const int DDSD_ALL = 0x00fff9ee;
    public const int DDOSD_GUID = 0x00000001;
    public const int DDOSD_COMPRESSION_RATIO = 0x00000002;
    public const int DDOSD_SCAPS = 0x00000004;
    public const int DDOSD_OSCAPS = 0x00000008;
    public const int DDOSD_ALL = 0x0000000f;
    public const int DDOSDCAPS_OPTCOMPRESSED = 0x00000001;
    public const int DDOSDCAPS_OPTREORDERED = 0x00000002;
    public const int DDOSDCAPS_MONOLITHICMIPMAP = 0x00000004;
    public const int DDOSDCAPS_VALIDSCAPS = 0x30004800;
    public const int DDOSDCAPS_VALIDOSCAPS = 0x00000007;
    public const int DDCOLOR_BRIGHTNESS = 0x00000001;
    public const int DDCOLOR_CONTRAST = 0x00000002;
    public const int DDCOLOR_HUE = 0x00000004;
    public const int DDCOLOR_SATURATION = 0x00000008;
    public const int DDCOLOR_SHARPNESS = 0x00000010;
    public const int DDCOLOR_GAMMA = 0x00000020;
    public const int DDCOLOR_COLORENABLE = 0x00000040;
    public const int DDSCAPS_RESERVED1 = 0x00000001;
    public const int DDSCAPS_ALPHA = 0x00000002;
    public const int DDSCAPS_BACKBUFFER = 0x00000004;
    public const int DDSCAPS_COMPLEX = 0x00000008;
    public const int DDSCAPS_FLIP = 0x00000010;
    public const int DDSCAPS_FRONTBUFFER = 0x00000020;
    public const int DDSCAPS_OFFSCREENPLAIN = 0x00000040;
    public const int DDSCAPS_OVERLAY = 0x00000080;
    public const int DDSCAPS_PALETTE = 0x00000100;
    public const int DDSCAPS_PRIMARYSURFACE = 0x00000200;
    public const int DDSCAPS_RESERVED3 = 0x00000400;
    public const int DDSCAPS_PRIMARYSURFACELEFT = 0x00000000;
    public const int DDSCAPS_SYSTEMMEMORY = 0x00000800;
    public const int DDSCAPS_TEXTURE = 0x00001000;
    public const int DDSCAPS_3DDEVICE = 0x00002000;
    public const int DDSCAPS_VIDEOMEMORY = 0x00004000;
    public const int DDSCAPS_VISIBLE = 0x00008000;
    public const int DDSCAPS_WRITEONLY = 0x00010000;
    public const int DDSCAPS_ZBUFFER = 0x00020000;
    public const int DDSCAPS_OWNDC = 0x00040000;
    public const int DDSCAPS_LIVEVIDEO = 0x00080000;
    public const int DDSCAPS_HWCODEC = 0x00100000;
    public const int DDSCAPS_MODEX = 0x00200000;
    public const int DDSCAPS_MIPMAP = 0x00400000;
    public const int DDSCAPS_RESERVED2 = 0x00800000;
    public const int DDSCAPS_ALLOCONLOAD = 0x04000000;
    public const int DDSCAPS_VIDEOPORT = 0x08000000;
    public const int DDSCAPS_LOCALVIDMEM = 0x10000000;
    public const int DDSCAPS_NONLOCALVIDMEM = 0x20000000;
    public const int DDSCAPS_STANDARDVGAMODE = 0x40000000;
    public const uint DDSCAPS_OPTIMIZED = 0x80000000;
    public const int DDSCAPS2_RESERVED4 = 0x00000002;
    public const int DDSCAPS2_HARDWAREDEINTERLACE = 0x00000000;
    public const int DDSCAPS2_HINTDYNAMIC = 0x00000004;
    public const int DDSCAPS2_HINTSTATIC = 0x00000008;
    public const int DDSCAPS2_TEXTUREMANAGE = 0x00000010;
    public const int DDSCAPS2_RESERVED1 = 0x00000020;
    public const int DDSCAPS2_RESERVED2 = 0x00000040;
    public const int DDSCAPS2_OPAQUE = 0x00000080;
    public const int DDSCAPS2_HINTANTIALIASING = 0x00000100;
    public const int DDSCAPS2_CUBEMAP = 0x00000200;
    public const int DDSCAPS2_CUBEMAP_POSITIVEX = 0x00000400;
    public const int DDSCAPS2_CUBEMAP_NEGATIVEX = 0x00000800;
    public const int DDSCAPS2_CUBEMAP_POSITIVEY = 0x00001000;
    public const int DDSCAPS2_CUBEMAP_NEGATIVEY = 0x00002000;
    public const int DDSCAPS2_CUBEMAP_POSITIVEZ = 0x00004000;
    public const int DDSCAPS2_CUBEMAP_NEGATIVEZ = 0x00008000;
    public const int DDSCAPS2_MIPMAPSUBLEVEL = 0x00010000;
    public const int DDSCAPS2_D3DTEXTUREMANAGE = 0x00020000;
    public const int DDSCAPS2_DONOTPERSIST = 0x00040000;
    public const int DDSCAPS2_STEREOSURFACELEFT = 0x00080000;
    public const int DDSCAPS2_VOLUME = 0x00200000;
    public const int DDSCAPS2_NOTUSERLOCKABLE = 0x00400000;
    public const int DDSCAPS2_POINTS = 0x00800000;
    public const int DDSCAPS2_RTPATCHES = 0x01000000;
    public const int DDSCAPS2_NPATCHES = 0x02000000;
    public const int DDSCAPS2_RESERVED3 = 0x04000000;
    public const int DDSCAPS2_DISCARDBACKBUFFER = 0x10000000;
    public const int DDSCAPS2_ENABLEALPHACHANNEL = 0x20000000;
    public const int DDSCAPS2_EXTENDEDFORMATPRIMARY = 0x40000000;
    public const uint DDSCAPS2_ADDITIONALPRIMARY = 0x80000000;
    public const int DDSCAPS3_MULTISAMPLE_MASK = 0x0000001F;
    public const int DDSCAPS3_MULTISAMPLE_QUALITY_MASK = 0x000000E0;
    public const int DDSCAPS3_MULTISAMPLE_QUALITY_SHIFT = 5;
    public const int DDSCAPS3_RESERVED1 = 0x00000100;
    public const int DDSCAPS3_RESERVED2 = 0x00000200;
    public const int DDSCAPS3_LIGHTWEIGHTMIPMAP = 0x00000400;
    public const int DDSCAPS3_AUTOGENMIPMAP = 0x00000800;
    public const int DDSCAPS3_DMAP = 0x00001000;
    public const int DDCAPS_3D = 0x00000001;
    public const int DDCAPS_ALIGNBOUNDARYDEST = 0x00000002;
    public const int DDCAPS_ALIGNSIZEDEST = 0x00000004;
    public const int DDCAPS_ALIGNBOUNDARYSRC = 0x00000008;
    public const int DDCAPS_ALIGNSIZESRC = 0x00000010;
    public const int DDCAPS_ALIGNSTRIDE = 0x00000020;
    public const int DDCAPS_BLT = 0x00000040;
    public const int DDCAPS_BLTQUEUE = 0x00000080;
    public const int DDCAPS_BLTFOURCC = 0x00000100;
    public const int DDCAPS_BLTSTRETCH = 0x00000200;
    public const int DDCAPS_GDI = 0x00000400;
    public const int DDCAPS_OVERLAY = 0x00000800;
    public const int DDCAPS_OVERLAYCANTCLIP = 0x00001000;
    public const int DDCAPS_OVERLAYFOURCC = 0x00002000;
    public const int DDCAPS_OVERLAYSTRETCH = 0x00004000;
    public const int DDCAPS_PALETTE = 0x00008000;
    public const int DDCAPS_PALETTEVSYNC = 0x00010000;
    public const int DDCAPS_READSCANLINE = 0x00020000;
    public const int DDCAPS_RESERVED1 = 0x00040000;
    public const int DDCAPS_VBI = 0x00080000;
    public const int DDCAPS_ZBLTS = 0x00100000;
    public const int DDCAPS_ZOVERLAYS = 0x00200000;
    public const int DDCAPS_COLORKEY = 0x00400000;
    public const int DDCAPS_ALPHA = 0x00800000;
    public const int DDCAPS_COLORKEYHWASSIST = 0x01000000;
    public const int DDCAPS_NOHARDWARE = 0x02000000;
    public const int DDCAPS_BLTCOLORFILL = 0x04000000;
    public const int DDCAPS_BANKSWITCHED = 0x08000000;
    public const int DDCAPS_BLTDEPTHFILL = 0x10000000;
    public const int DDCAPS_CANCLIP = 0x20000000;
    public const int DDCAPS_CANCLIPSTRETCHED = 0x40000000;
    public const uint DDCAPS_CANBLTSYSMEM = 0x80000000;
    public const int DDCAPS2_CERTIFIED = 0x00000001;
    public const int DDCAPS2_NO2DDURING3DSCENE = 0x00000002;
    public const int DDCAPS2_VIDEOPORT = 0x00000004;
    public const int DDCAPS2_AUTOFLIPOVERLAY = 0x00000008;
    public const int DDCAPS2_CANBOBINTERLEAVED = 0x00000010;
    public const int DDCAPS2_CANBOBNONINTERLEAVED = 0x00000020;
    public const int DDCAPS2_COLORCONTROLOVERLAY = 0x00000040;
    public const int DDCAPS2_COLORCONTROLPRIMARY = 0x00000080;
    public const int DDCAPS2_CANDROPZ16BIT = 0x00000100;
    public const int DDCAPS2_NONLOCALVIDMEM = 0x00000200;
    public const int DDCAPS2_NONLOCALVIDMEMCAPS = 0x00000400;
    public const int DDCAPS2_NOPAGELOCKREQUIRED = 0x00000800;
    public const int DDCAPS2_WIDESURFACES = 0x00001000;
    public const int DDCAPS2_CANFLIPODDEVEN = 0x00002000;
    public const int DDCAPS2_CANBOBHARDWARE = 0x00004000;
    public const int DDCAPS2_COPYFOURCC = 0x00008000;
    public const int DDCAPS2_PRIMARYGAMMA = 0x00020000;
    public const int DDCAPS2_CANRENDERWINDOWED = 0x00080000;
    public const int DDCAPS2_CANCALIBRATEGAMMA = 0x00100000;
    public const int DDCAPS2_FLIPINTERVAL = 0x00200000;
    public const int DDCAPS2_FLIPNOVSYNC = 0x00400000;
    public const int DDCAPS2_CANMANAGETEXTURE = 0x00800000;
    public const int DDCAPS2_TEXMANINNONLOCALVIDMEM = 0x01000000;
    public const int DDCAPS2_STEREO = 0x02000000;
    public const int DDCAPS2_SYSTONONLOCAL_AS_SYSTOLOCAL = 0x04000000;
    public const int DDCAPS2_RESERVED1 = 0x08000000;
    public const int DDCAPS2_CANMANAGERESOURCE = 0x10000000;
    public const int DDCAPS2_DYNAMICTEXTURES = 0x20000000;
    public const int DDCAPS2_CANAUTOGENMIPMAP = 0x40000000;
    public const int DDFXALPHACAPS_BLTALPHAEDGEBLEND = 0x00000001;
    public const int DDFXALPHACAPS_BLTALPHAPIXELS = 0x00000002;
    public const int DDFXALPHACAPS_BLTALPHAPIXELSNEG = 0x00000004;
    public const int DDFXALPHACAPS_BLTALPHASURFACES = 0x00000008;
    public const int DDFXALPHACAPS_BLTALPHASURFACESNEG = 0x00000010;
    public const int DDFXALPHACAPS_OVERLAYALPHAEDGEBLEND = 0x00000020;
    public const int DDFXALPHACAPS_OVERLAYALPHAPIXELS = 0x00000040;
    public const int DDFXALPHACAPS_OVERLAYALPHAPIXELSNEG = 0x00000080;
    public const int DDFXALPHACAPS_OVERLAYALPHASURFACES = 0x00000100;
    public const int DDFXALPHACAPS_OVERLAYALPHASURFACESNEG = 0x00000200;
    public const int DDFXCAPS_BLTARITHSTRETCHY = 0x00000020;
    public const int DDFXCAPS_BLTARITHSTRETCHYN = 0x00000010;
    public const int DDFXCAPS_BLTMIRRORLEFTRIGHT = 0x00000040;
    public const int DDFXCAPS_BLTMIRRORUPDOWN = 0x00000080;
    public const int DDFXCAPS_BLTROTATION = 0x00000100;
    public const int DDFXCAPS_BLTROTATION90 = 0x00000200;
    public const int DDFXCAPS_BLTSHRINKX = 0x00000400;
    public const int DDFXCAPS_BLTSHRINKXN = 0x00000800;
    public const int DDFXCAPS_BLTSHRINKY = 0x00001000;
    public const int DDFXCAPS_BLTSHRINKYN = 0x00002000;
    public const int DDFXCAPS_BLTSTRETCHX = 0x00004000;
    public const int DDFXCAPS_BLTSTRETCHXN = 0x00008000;
    public const int DDFXCAPS_BLTSTRETCHY = 0x00010000;
    public const int DDFXCAPS_BLTSTRETCHYN = 0x00020000;
    public const int DDFXCAPS_OVERLAYARITHSTRETCHY = 0x00040000;
    public const int DDFXCAPS_OVERLAYARITHSTRETCHYN = 0x00000008;
    public const int DDFXCAPS_OVERLAYSHRINKX = 0x00080000;
    public const int DDFXCAPS_OVERLAYSHRINKXN = 0x00100000;
    public const int DDFXCAPS_OVERLAYSHRINKY = 0x00200000;
    public const int DDFXCAPS_OVERLAYSHRINKYN = 0x00400000;
    public const int DDFXCAPS_OVERLAYSTRETCHX = 0x00800000;
    public const int DDFXCAPS_OVERLAYSTRETCHXN = 0x01000000;
    public const int DDFXCAPS_OVERLAYSTRETCHY = 0x02000000;
    public const int DDFXCAPS_OVERLAYSTRETCHYN = 0x04000000;
    public const int DDFXCAPS_OVERLAYMIRRORLEFTRIGHT = 0x08000000;
    public const int DDFXCAPS_OVERLAYMIRRORUPDOWN = 0x10000000;
    public const int DDFXCAPS_OVERLAYDEINTERLACE = 0x20000000;
    public const int DDFXCAPS_BLTALPHA = 0x00000001;
    public const int DDFXCAPS_OVERLAYALPHA = 0x00000004;
    public const int DDSVCAPS_RESERVED1 = 0x00000001;
    public const int DDSVCAPS_RESERVED2 = 0x00000002;
    public const int DDSVCAPS_RESERVED3 = 0x00000004;
    public const int DDSVCAPS_RESERVED4 = 0x00000008;
    public const int DDSVCAPS_STEREOSEQUENTIAL = 0x00000010;
    public const int DDPCAPS_4BIT = 0x00000001;
    public const int DDPCAPS_8BITENTRIES = 0x00000002;
    public const int DDPCAPS_8BIT = 0x00000004;
    public const int DDPCAPS_INITIALIZE = 0x00000000;
    public const int DDPCAPS_PRIMARYSURFACE = 0x00000010;
    public const int DDPCAPS_PRIMARYSURFACELEFT = 0x00000020;
    public const int DDPCAPS_ALLOW256 = 0x00000040;
    public const int DDPCAPS_VSYNC = 0x00000080;
    public const int DDPCAPS_1BIT = 0x00000100;
    public const int DDPCAPS_2BIT = 0x00000200;
    public const int DDPCAPS_ALPHA = 0x00000400;
    public const int DDSPD_IUNKNOWNPOINTER = 0x00000001;
    public const int DDSPD_VOLATILE = 0x00000002;
    public const int DDBD_1 = 0x00004000;
    public const int DDBD_2 = 0x00002000;
    public const int DDBD_4 = 0x00001000;
    public const int DDBD_8 = 0x00000800;
    public const int DDBD_16 = 0x00000400;
    public const int DDBD_24 = 0X00000200;
    public const int DDBD_32 = 0x00000100;
    public const int DDCKEY_COLORSPACE = 0x00000001;
    public const int DDCKEY_DESTBLT = 0x00000002;
    public const int DDCKEY_DESTOVERLAY = 0x00000004;
    public const int DDCKEY_SRCBLT = 0x00000008;
    public const int DDCKEY_SRCOVERLAY = 0x00000010;
    public const int DDCKEYCAPS_DESTBLT = 0x00000001;
    public const int DDCKEYCAPS_DESTBLTCLRSPACE = 0x00000002;
    public const int DDCKEYCAPS_DESTBLTCLRSPACEYUV = 0x00000004;
    public const int DDCKEYCAPS_DESTBLTYUV = 0x00000008;
    public const int DDCKEYCAPS_DESTOVERLAY = 0x00000010;
    public const int DDCKEYCAPS_DESTOVERLAYCLRSPACE = 0x00000020;
    public const int DDCKEYCAPS_DESTOVERLAYCLRSPACEYUV = 0x00000040;
    public const int DDCKEYCAPS_DESTOVERLAYONEACTIVE = 0x00000080;
    public const int DDCKEYCAPS_DESTOVERLAYYUV = 0x00000100;
    public const int DDCKEYCAPS_SRCBLT = 0x00000200;
    public const int DDCKEYCAPS_SRCBLTCLRSPACE = 0x00000400;
    public const int DDCKEYCAPS_SRCBLTCLRSPACEYUV = 0x00000800;
    public const int DDCKEYCAPS_SRCBLTYUV = 0x00001000;
    public const int DDCKEYCAPS_SRCOVERLAY = 0x00002000;
    public const int DDCKEYCAPS_SRCOVERLAYCLRSPACE = 0x00004000;
    public const int DDCKEYCAPS_SRCOVERLAYCLRSPACEYUV = 0x00008000;
    public const int DDCKEYCAPS_SRCOVERLAYONEACTIVE = 0x00010000;
    public const int DDCKEYCAPS_SRCOVERLAYYUV = 0x00020000;
    public const int DDCKEYCAPS_NOCOSTOVERLAY = 0x00040000;
    public const int DDPF_ALPHAPIXELS = 0x00000001;
    public const int DDPF_ALPHA = 0x00000002;
    public const int DDPF_FOURCC = 0x00000004;
    public const int DDPF_PALETTEINDEXED4 = 0x00000008;
    public const int DDPF_PALETTEINDEXEDTO8 = 0x00000010;
    public const int DDPF_PALETTEINDEXED8 = 0x00000020;
    public const int DDPF_RGB = 0x00000040;
    public const int DDPF_COMPRESSED = 0x00000080;
    public const int DDPF_RGBTOYUV = 0x00000100;
    public const int DDPF_YUV = 0x00000200;
    public const int DDPF_ZBUFFER = 0x00000400;
    public const int DDPF_PALETTEINDEXED1 = 0x00000800;
    public const int DDPF_PALETTEINDEXED2 = 0x00001000;
    public const int DDPF_ZPIXELS = 0x00002000;
    public const int DDPF_STENCILBUFFER = 0x00004000;
    public const int DDPF_ALPHAPREMULT = 0x00008000;
    public const int DDPF_LUMINANCE = 0x00020000;
    public const int DDPF_BUMPLUMINANCE = 0x00040000;
    public const int DDPF_BUMPDUDV = 0x00080000;
    public const int DDENUMSURFACES_ALL = 0x00000001;
    public const int DDENUMSURFACES_MATCH = 0x00000002;
    public const int DDENUMSURFACES_NOMATCH = 0x00000004;
    public const int DDENUMSURFACES_CANBECREATED = 0x00000008;
    public const int DDENUMSURFACES_DOESEXIST = 0x00000010;
    public const int DDSDM_STANDARDVGAMODE = 0x00000001;
    public const int DDEDM_REFRESHRATES = 0x00000001;
    public const int DDEDM_STANDARDVGAMODES = 0x00000002;
    public const int DDSCL_FULLSCREEN = 0x00000001;
    public const int DDSCL_ALLOWREBOOT = 0x00000002;
    public const int DDSCL_NOWINDOWCHANGES = 0x00000004;
    public const int DDSCL_NORMAL = 0x00000008;
    public const int DDSCL_EXCLUSIVE = 0x00000010;
    public const int DDSCL_ALLOWMODEX = 0x00000040;
    public const int DDSCL_SETFOCUSWINDOW = 0x00000080;
    public const int DDSCL_SETDEVICEWINDOW = 0x00000100;
    public const int DDSCL_CREATEDEVICEWINDOW = 0x00000200;
    public const int DDSCL_MULTITHREADED = 0x00000400;
    public const int DDSCL_FPUSETUP = 0x00000800;
    public const int DDSCL_FPUPRESERVE = 0x00001000;
    public const int DDBLT_ALPHADEST = 0x00000001;
    public const int DDBLT_ALPHADESTCONSTOVERRIDE = 0x00000002;
    public const int DDBLT_ALPHADESTNEG = 0x00000004;
    public const int DDBLT_ALPHADESTSURFACEOVERRIDE = 0x00000008;
    public const int DDBLT_ALPHAEDGEBLEND = 0x00000010;
    public const int DDBLT_ALPHASRC = 0x00000020;
    public const int DDBLT_ALPHASRCCONSTOVERRIDE = 0x00000040;
    public const int DDBLT_ALPHASRCNEG = 0x00000080;
    public const int DDBLT_ALPHASRCSURFACEOVERRIDE = 0x00000100;
    public const int DDBLT_ASYNC = 0x00000200;
    public const int DDBLT_COLORFILL = 0x00000400;
    public const int DDBLT_DDFX = 0x00000800;
    public const int DDBLT_DDROPS = 0x00001000;
    public const int DDBLT_KEYDEST = 0x00002000;
    public const int DDBLT_KEYDESTOVERRIDE = 0x00004000;
    public const int DDBLT_KEYSRC = 0x00008000;
    public const int DDBLT_KEYSRCOVERRIDE = 0x00010000;
    public const int DDBLT_ROP = 0x00020000;
    public const int DDBLT_ROTATIONANGLE = 0x00040000;
    public const int DDBLT_ZBUFFER = 0x00080000;
    public const int DDBLT_ZBUFFERDESTCONSTOVERRIDE = 0x00100000;
    public const int DDBLT_ZBUFFERDESTOVERRIDE = 0x00200000;
    public const int DDBLT_ZBUFFERSRCCONSTOVERRIDE = 0x00400000;
    public const int DDBLT_ZBUFFERSRCOVERRIDE = 0x00800000;
    public const int DDBLT_WAIT = 0x01000000;
    public const int DDBLT_DEPTHFILL = 0x02000000;
    public const int DDBLT_DONOTWAIT = 0x08000000;
    public const int DDBLT_PRESENTATION = 0x10000000;
    public const int DDBLT_LAST_PRESENTATION = 0x20000000;
    public const int DDBLT_EXTENDED_FLAGS = 0x40000000;
    public const int DDBLT_EXTENDED_LINEAR_CONTENT = 0x00000004;
    public const int DDBLTFAST_NOCOLORKEY = 0x00000000;
    public const int DDBLTFAST_SRCCOLORKEY = 0x00000001;
    public const int DDBLTFAST_DESTCOLORKEY = 0x00000002;
    public const int DDBLTFAST_WAIT = 0x00000010;
    public const int DDBLTFAST_DONOTWAIT = 0x00000020;
    public const int DDFLIP_WAIT = 0x00000001;
    public const int DDFLIP_EVEN = 0x00000002;
    public const int DDFLIP_ODD = 0x00000004;
    public const int DDFLIP_NOVSYNC = 0x00000008;
    public const int DDFLIP_INTERVAL2 = 0x02000000;
    public const int DDFLIP_INTERVAL3 = 0x03000000;
    public const int DDFLIP_INTERVAL4 = 0x04000000;
    public const int DDFLIP_STEREO = 0x00000010;
    public const int DDFLIP_DONOTWAIT = 0x00000020;
    public const int DDOVER_ALPHADEST = 0x00000001;
    public const int DDOVER_ALPHADESTCONSTOVERRIDE = 0x00000002;
    public const int DDOVER_ALPHADESTNEG = 0x00000004;
    public const int DDOVER_ALPHADESTSURFACEOVERRIDE = 0x00000008;
    public const int DDOVER_ALPHAEDGEBLEND = 0x00000010;
    public const int DDOVER_ALPHASRC = 0x00000020;
    public const int DDOVER_ALPHASRCCONSTOVERRIDE = 0x00000040;
    public const int DDOVER_ALPHASRCNEG = 0x00000080;
    public const int DDOVER_ALPHASRCSURFACEOVERRIDE = 0x00000100;
    public const int DDOVER_HIDE = 0x00000200;
    public const int DDOVER_KEYDEST = 0x00000400;
    public const int DDOVER_KEYDESTOVERRIDE = 0x00000800;
    public const int DDOVER_KEYSRC = 0x00001000;
    public const int DDOVER_KEYSRCOVERRIDE = 0x00002000;
    public const int DDOVER_SHOW = 0x00004000;
    public const int DDOVER_ADDDIRTYRECT = 0x00008000;
    public const int DDOVER_REFRESHDIRTYRECTS = 0x00010000;
    public const int DDOVER_REFRESHALL = 0x00020000;
    public const int DDOVER_DDFX = 0x00080000;
    public const int DDOVER_AUTOFLIP = 0x00100000;
    public const int DDOVER_BOB = 0x00200000;
    public const int DDOVER_OVERRIDEBOBWEAVE = 0x00400000;
    public const int DDOVER_INTERLEAVED = 0x00800000;
    public const int DDOVER_BOBHARDWARE = 0x01000000;
    public const int DDOVER_ARGBSCALEFACTORS = 0x02000000;
    public const int DDOVER_DEGRADEARGBSCALING = 0x04000000;
    public const int DDLOCK_SURFACEMEMORYPTR = 0x00000000; // default
    public const int DDLOCK_WAIT = 0x00000001;
    public const int DDLOCK_EVENT = 0x00000002;
    public const int DDLOCK_READONLY = 0x00000010;
    public const int DDLOCK_WRITEONLY = 0x00000020;
    public const int DDLOCK_NOSYSLOCK = 0x00000800;
    public const int DDLOCK_NOOVERWRITE = 0x00001000;
    public const int DDLOCK_DISCARDCONTENTS = 0x00002000;
    public const int DDLOCK_OKTOSWAP = 0x00002000;
    public const int DDLOCK_DONOTWAIT = 0x00004000;
    public const int DDLOCK_HASVOLUMETEXTUREBOXRECT = 0x00008000;
    public const int DDLOCK_NODIRTYUPDATE = 0x00010000;
    public const int DDBLTFX_ARITHSTRETCHY = 0x00000001;
    public const int DDBLTFX_MIRRORLEFTRIGHT = 0x00000002;
    public const int DDBLTFX_MIRRORUPDOWN = 0x00000004;
    public const int DDBLTFX_NOTEARING = 0x00000008;
    public const int DDBLTFX_ROTATE180 = 0x00000010;
    public const int DDBLTFX_ROTATE270 = 0x00000020;
    public const int DDBLTFX_ROTATE90 = 0x00000040;
    public const int DDBLTFX_ZBUFFERRANGE = 0x00000080;
    public const int DDBLTFX_ZBUFFERBASEDEST = 0x00000100;
    public const int DDOVERFX_ARITHSTRETCHY = 0x00000001;
    public const int DDOVERFX_MIRRORLEFTRIGHT = 0x00000002;
    public const int DDOVERFX_MIRRORUPDOWN = 0x00000004;
    public const int DDOVERFX_DEINTERLACE = 0x00000008;
    public const int DDWAITVB_BLOCKBEGIN = 0x00000001;
    public const int DDWAITVB_BLOCKBEGINEVENT = 0x00000002;
    public const int DDWAITVB_BLOCKEND = 0x00000004;
    public const int DDGFS_CANFLIP = 0x00000001;
    public const int DDGFS_ISFLIPDONE = 0x00000002;
    public const int DDGBS_CANBLT = 0x00000001;
    public const int DDGBS_ISBLTDONE = 0x00000002;
    public const int DDENUMOVERLAYZ_BACKTOFRONT = 0x00000000;
    public const int DDENUMOVERLAYZ_FRONTTOBACK = 0x00000001;
    public const int DDOVERZ_SENDTOFRONT = 0x00000000;
    public const int DDOVERZ_SENDTOBACK = 0x00000001;
    public const int DDOVERZ_MOVEFORWARD = 0x00000002;
    public const int DDOVERZ_MOVEBACKWARD = 0x00000003;
    public const int DDOVERZ_INSERTINFRONTOF = 0x00000004;
    public const int DDOVERZ_INSERTINBACKOF = 0x00000005;
    public const int DDSGR_CALIBRATE = 0x00000001;
    public const int DDSMT_ISTESTREQUIRED = 0x00000001;
    public const int DDEM_MODEPASSED = 0x00000001;
    public const int DDEM_MODEFAILED = 0x00000002;
    public const int DDENUMRET_CANCEL = 0;
    public const int DDENUMRET_OK = 1;
    public const int DVD_TITLE_MENU = 0x000;
    public const int DVD_STREAM_DATA_CURRENT = 0x800;
    public const int DVD_STREAM_DATA_VMGM = 0x400;
    public const int DVD_STREAM_DATA_VTSM = 0x401;
    public const int DVD_DEFAULT_AUDIO_STREAM = 0x0f;
    public const int DVD_AUDIO_CAPS_AC3 = 0x00000001;
    public const int DVD_AUDIO_CAPS_MPEG2 = 0x00000002;
    public const int DVD_AUDIO_CAPS_LPCM = 0x00000004;
    public const int DVD_AUDIO_CAPS_DTS = 0x00000008;
    public const int DVD_AUDIO_CAPS_SDDS = 0x00000010;
    public const int VMRBITMAP_DISABLE = 0x00000001;
    public const int VMRBITMAP_HDC = 0x00000002;
    public const int VMRBITMAP_ENTIREDDS = 0x00000004;
    public const int VMRBITMAP_SRCCOLORKEY = 0x00000008;
    public const int VMRBITMAP_SRCRECT = 0x00000010;
    public const uint AMVA_TYPEINDEX_OUTPUTFRAME = 0xFFFFFFFF;
    public const int AMVA_QUERYRENDERSTATUSF_READ = 0x00000001; // Query for read
    public const int AMDDS_NONE = 0x00; // No use for DCI/DirectDraw
    public const int AMDDS_DCIPS = 0x01; // Use DCI primary surface
    public const int AMDDS_PS = 0x02; // Use DirectDraw primary
    public const int AMDDS_RGBOVR = 0x04; // RGB overlay surfaces
    public const int AMDDS_YUVOVR = 0x08; // YUV overlay surfaces
    public const int AMDDS_RGBOFF = 0x10; // RGB offscreen surfaces
    public const int AMDDS_YUVOFF = 0x20; // YUV offscreen surfaces
    public const int AMDDS_RGBFLP = 0x40; // RGB flipping surfaces
    public const int AMDDS_YUVFLP = 0x80; // YUV flipping surfaces
    public const int AMDDS_ALL = 0xFF; // ALL the previous flags
    public const int iPALETTE_COLORS = 256; // Maximum colours in palette
    public const int iEGA_COLORS = 16; // Number colours in EGA palette
    public const int iMASK_COLORS = 3; // Maximum three components
    public const int iTRUECOLOR = 16; // Minimum true colour device
    public const int iRED = 0; // Index position for RED mask
    public const int iGREEN = 1; // Index position for GREEN mask
    public const int iBLUE = 2; // Index position for BLUE mask
    public const int iPALETTE = 8; // Maximum colour depth using a palette
    public const int iMAXBITS = 8; // Maximum bits per colour component
    public const int MAX_SIZE_MPEG1_SEQUENCE_INFO = 140;
    public const int EC_SND_DEVICE_ERROR_BASE = 0x0200;
#if ! AVIRIFF_H
    public const int TIMECODE_RATE_30DROP = 0; // this MUST be zero
#endif
#if ! AVIRIFF_H
    public const int TIMECODE_SMPTE_BINARY_GROUP = 0x07;
#endif
#if ! AVIRIFF_H
    public const int TIMECODE_SMPTE_COLOR_FRAME = 0x08;
#endif
#if ! AVIRIFF_H
    public const int AVI_INDEX_OF_INDEXES = 0x00;
#endif
#if ! AVIRIFF_H
    public const int AVI_INDEX_OF_CHUNKS = 0x01;
#endif
#if ! AVIRIFF_H
    public const int AVI_INDEX_OF_TIMED_CHUNKS = 0x02;
#endif
#if ! AVIRIFF_H
    public const int AVI_INDEX_OF_SUB_2FIELD = 0x03;
#endif
#if ! AVIRIFF_H
    public const int AVI_INDEX_IS_DATA = 0x80;
#endif
#if ! AVIRIFF_H
    public const int AVI_INDEX_SUB_DEFAULT = 0x00;
#endif
#if ! AVIRIFF_H
    public const int AVI_INDEX_SUB_2FIELD = 0x01;
#endif
#if ! AVIRIFF_H
    public const int STDINDEXSIZE = 0x4000;
#endif
    public const int _BDATYPES_ = 1;
    public const int MIN_DIMENSION = 1;
    public const int BDA_FREQUENCY_NOT_SET = -1;
    public const int BDA_FREQUENCY_NOT_DEFINED = 0;
    public const int BDA_RANGE_NOT_SET = -1;
    public const int BDA_RANGE_NOT_DEFINED = 0;
    public const int BDA_CHAN_BANDWITH_NOT_SET = -1;
    public const int BDA_CHAN_BANDWITH_NOT_DEFINED = 0;
    public const int BDA_FREQUENCY_MULTIPLIER_NOT_SET = -1;
    public const int BDA_FREQUENCY_MULTIPLIER_NOT_DEFINED = 0;
    public const int DIRECT3D_VERSION = 0x0700;
    public const int DIRECT3D_VERSION = 0x0800;
    public const int DIRECT3D_VERSION = 0x0900;
    public const int D3DMAXUSERCLIPPLANES = 32;
    public const int D3DCLIP_LEFT = 0x00000001;
    public const int D3DCLIP_RIGHT = 0x00000002;
    public const int D3DCLIP_TOP = 0x00000004;
    public const int D3DCLIP_BOTTOM = 0x00000008;
    public const int D3DCLIP_FRONT = 0x00000010;
    public const int D3DCLIP_BACK = 0x00000020;
    public const int D3DCLIP_GEN0 = 0x00000040;
    public const int D3DCLIP_GEN1 = 0x00000080;
    public const int D3DCLIP_GEN2 = 0x00000100;
    public const int D3DCLIP_GEN3 = 0x00000200;
    public const int D3DCLIP_GEN4 = 0x00000400;
    public const int D3DCLIP_GEN5 = 0x00000800;
    public const int D3DSTATUS_CLIPINTERSECTIONLEFT = 0x00001000;
    public const int D3DSTATUS_CLIPINTERSECTIONRIGHT = 0x00002000;
    public const int D3DSTATUS_CLIPINTERSECTIONTOP = 0x00004000;
    public const int D3DSTATUS_CLIPINTERSECTIONBOTTOM = 0x00008000;
    public const int D3DSTATUS_CLIPINTERSECTIONFRONT = 0x00010000;
    public const int D3DSTATUS_CLIPINTERSECTIONBACK = 0x00020000;
    public const int D3DSTATUS_CLIPINTERSECTIONGEN0 = 0x00040000;
    public const int D3DSTATUS_CLIPINTERSECTIONGEN1 = 0x00080000;
    public const int D3DSTATUS_CLIPINTERSECTIONGEN2 = 0x00100000;
    public const int D3DSTATUS_CLIPINTERSECTIONGEN3 = 0x00200000;
    public const int D3DSTATUS_CLIPINTERSECTIONGEN4 = 0x00400000;
    public const int D3DSTATUS_CLIPINTERSECTIONGEN5 = 0x00800000;
    public const int D3DSTATUS_ZNOTVISIBLE = 0x01000000;
    public const int D3DTRANSFORM_CLIPPED = 0x00000001;
    public const int D3DTRANSFORM_UNCLIPPED = 0x00000002;
    public const int D3DLIGHT_ACTIVE = 0x00000001;
    public const int D3DLIGHT_NO_SPECULAR = 0x00000002;
    public const int D3DCOLOR_MONO = 1;
    public const int D3DCOLOR_RGB = 2;
    public const int D3DCLEAR_TARGET = 0x00000001; // Clear target surface
    public const int D3DCLEAR_ZBUFFER = 0x00000002; // Clear target z buffer
    public const int D3DCLEAR_STENCIL = 0x00000004; // Clear stencil planes
    public const int D3DSTATE_OVERRIDE_BIAS = 256;
    public const uint D3DRENDERSTATE_WRAPBIAS = 128;
    public const int D3DWRAP_U = 0x00000001;
    public const int D3DWRAP_V = 0x00000002;
    public const int D3DWRAPCOORD_0 = 0x00000001; // same as D3DWRAP_U
    public const int D3DWRAPCOORD_1 = 0x00000002; // same as D3DWRAP_V
    public const int D3DWRAPCOORD_2 = 0x00000004;
    public const int D3DWRAPCOORD_2 = 0x00000004; // same as D3DWRAP_W
    public const int D3DWRAPCOORD_3 = 0x00000008;
    public const int D3DPROCESSVERTICES_TRANSFORMLIGHT = 0x00000000;
    public const int D3DPROCESSVERTICES_TRANSFORM = 0x00000001;
    public const int D3DPROCESSVERTICES_COPY = 0x00000002;
    public const int D3DPROCESSVERTICES_OPMASK = 0x00000007;
    public const int D3DPROCESSVERTICES_UPDATEEXTENTS = 0x00000008;
    public const int D3DPROCESSVERTICES_NOCOLOR = 0x00000010;
    public const int D3DTSS_TCI_PASSTHRU = 0x00000000;
    public const int D3DTSS_TCI_CAMERASPACENORMAL = 0x00010000;
    public const int D3DTSS_TCI_CAMERASPACEPOSITION = 0x00020000;
    public const int D3DTSS_TCI_CAMERASPACEREFLECTIONVECTOR = 0x00030000;
    public const int D3DTA_SELECTMASK = 0x0000000f; // mask for arg selector
    public const int D3DTA_DIFFUSE = 0x00000000; // select diffuse color
    public const int D3DTA_DIFFUSE = 0x00000000; // select diffuse color (read only)
    public const int D3DTA_CURRENT = 0x00000001; // select result of previous stage
    public const int D3DTA_CURRENT = 0x00000001; // select stage destination register (read/write)
    public const int D3DTA_TEXTURE = 0x00000002; // select texture color
    public const int D3DTA_TEXTURE = 0x00000002; // select texture color (read only)
    public const int D3DTA_TFACTOR = 0x00000003; // select RENDERSTATE_TEXTUREFACTOR
    public const int D3DTA_TFACTOR = 0x00000003; // select D3DRS_TEXTUREFACTOR (read only)
    public const int D3DTA_SPECULAR = 0x00000004; // select specular color
    public const int D3DTA_SPECULAR = 0x00000004; // select specular color (read only)
    public const int D3DTA_COMPLEMENT = 0x00000010; // take 1.0 - x
    public const int D3DTA_COMPLEMENT = 0x00000010; // take 1.0 - x (read modifier)
    public const int D3DTA_ALPHAREPLICATE = 0x00000020; // replicate alpha to color components
    public const int D3DTA_ALPHAREPLICATE = 0x00000020; // replicate alpha to color components (read modifier)
    public const int D3DTRIFLAG_START = 0x00000000;
    public const int D3DTRIFLAG_ODD = 0x0000001e;
    public const int D3DTRIFLAG_EVEN = 0x0000001f;
    public const int D3DTRIFLAG_EDGEENABLE1 = 0x00000100; // v0-v1 edge
    public const int D3DTRIFLAG_EDGEENABLE2 = 0x00000200; // v1-v2 edge
    public const int D3DTRIFLAG_EDGEENABLE3 = 0x00000400; // v2-v0 edge
    public const int D3DSETSTATUS_STATUS = 0x00000001;
    public const int D3DSETSTATUS_EXTENTS = 0x00000002;
    public const int D3DCLIPSTATUS_STATUS = 0x00000001;
    public const int D3DCLIPSTATUS_EXTENTS2 = 0x00000002;
    public const int D3DCLIPSTATUS_EXTENTS3 = 0x00000004;
    public const int D3DEXECUTE_CLIPPED = 0x00000001;
    public const int D3DEXECUTE_UNCLIPPED = 0x00000002;
    public const int D3DPAL_FREE = 0x00; // Renderer may use this entry freely
    public const int D3DPAL_READONLY = 0x40; // Renderer may not set this entry
    public const int D3DPAL_RESERVED = 0x80; // Renderer may not use this entry
    public const int D3DVBCAPS_SYSTEMMEMORY = 0x00000800;
    public const int D3DVBCAPS_WRITEONLY = 0x00010000;
    public const uint D3DVBCAPS_OPTIMIZED = 0x80000000;
    public const int D3DVBCAPS_DONOTCLIP = 0x00000001;
    public const int D3DFVF_RESERVED0 = 0x001;
    public const int D3DFVF_POSITION_MASK = 0x00E;
    public const int D3DFVF_POSITION_MASK = 0x400E;
    public const int D3DFVF_XYZ = 0x002;
    public const int D3DFVF_XYZRHW = 0x004;
    public const int D3DFVF_XYZB1 = 0x006;
    public const int D3DFVF_XYZB2 = 0x008;
    public const int D3DFVF_XYZB3 = 0x00a;
    public const int D3DFVF_XYZB4 = 0x00c;
    public const int D3DFVF_XYZB5 = 0x00e;
    public const int D3DFVF_NORMAL = 0x010;
    public const int D3DFVF_RESERVED1 = 0x020;
    public const int D3DFVF_DIFFUSE = 0x040;
    public const int D3DFVF_SPECULAR = 0x080;
    public const int D3DFVF_TEXCOUNT_MASK = 0xf00;
    public const int D3DFVF_TEXCOUNT_SHIFT = 8;
    public const int D3DFVF_TEX0 = 0x000;
    public const int D3DFVF_TEX1 = 0x100;
    public const int D3DFVF_TEX2 = 0x200;
    public const int D3DFVF_TEX3 = 0x300;
    public const int D3DFVF_TEX4 = 0x400;
    public const int D3DFVF_TEX5 = 0x500;
    public const int D3DFVF_TEX6 = 0x600;
    public const int D3DFVF_TEX7 = 0x700;
    public const int D3DFVF_TEX8 = 0x800;
    public const int D3DFVF_RESERVED2 = 0xf000; // 4 reserved bits
    public const int D3DFVF_RESERVED2 = 0xE000; // 4 reserved bits
    public const int D3DFVF_RESERVED2 = 0x6000; // 2 reserved bits
    public const int D3DDP_MAXTEXCOORD = 8;
    public const int D3DVIS_INSIDE_FRUSTUM = 0;
    public const int D3DVIS_INTERSECT_FRUSTUM = 1;
    public const int D3DVIS_OUTSIDE_FRUSTUM = 2;
    public const int D3DVIS_INSIDE_LEFT = 0;
    public const int D3DVIS_INSIDE_RIGHT = 0;
    public const int D3DVIS_INSIDE_TOP = 0;
    public const int D3DVIS_INSIDE_BOTTOM = 0;
    public const int D3DVIS_INSIDE_NEAR = 0;
    public const int D3DVIS_INSIDE_FAR = 0;
    public const int D3DDEVINFOID_TEXTUREMANAGER = 1;
    public const int D3DDEVINFOID_D3DTEXTUREMANAGER = 2;
    public const int D3DDEVINFOID_TEXTURING = 3;
    public const int D3DFVF_TEXTUREFORMAT2 = 0; // Two floating point values
    public const int D3DFVF_TEXTUREFORMAT1 = 3; // One floating point value
    public const int D3DFVF_TEXTUREFORMAT3 = 1; // Three floating point values
    public const int D3DFVF_TEXTUREFORMAT4 = 2; // Four floating point values
    public const int D3DTRANSFORMCAPS_CLIP = 0x00000001; // Will clip whilst transforming
    public const int D3DLIGHTINGMODEL_RGB = 0x00000001;
    public const int D3DLIGHTINGMODEL_MONO = 0x00000002;
    public const int D3DLIGHTCAPS_POINT = 0x00000001; // Point lights supported
    public const int D3DLIGHTCAPS_SPOT = 0x00000002; // Spot lights supported
    public const int D3DLIGHTCAPS_DIRECTIONAL = 0x00000004; // Directional lights supported
    public const int D3DLIGHTCAPS_PARALLELPOINT = 0x00000008; // Parallel point lights supported
    public const int D3DLIGHTCAPS_GLSPOT = 0x00000010; // GL syle spot lights supported
    public const int D3DPMISCCAPS_MASKPLANES = 0x00000001;
    public const int D3DPMISCCAPS_MASKZ = 0x00000002;
    public const int D3DPMISCCAPS_LINEPATTERNREP = 0x00000004;
    public const int D3DPMISCCAPS_CONFORMANT = 0x00000008;
    public const int D3DPMISCCAPS_CULLNONE = 0x00000010;
    public const int D3DPMISCCAPS_CULLCW = 0x00000020;
    public const int D3DPMISCCAPS_CULLCCW = 0x00000040;
    public const int D3DPRASTERCAPS_DITHER = 0x00000001;
    public const int D3DPRASTERCAPS_ROP2 = 0x00000002;
    public const int D3DPRASTERCAPS_XOR = 0x00000004;
    public const int D3DPRASTERCAPS_PAT = 0x00000008;
    public const int D3DPRASTERCAPS_ZTEST = 0x00000010;
    public const int D3DPRASTERCAPS_SUBPIXEL = 0x00000020;
    public const int D3DPRASTERCAPS_SUBPIXELX = 0x00000040;
    public const int D3DPRASTERCAPS_FOGVERTEX = 0x00000080;
    public const int D3DPRASTERCAPS_FOGTABLE = 0x00000100;
    public const int D3DPRASTERCAPS_STIPPLE = 0x00000200;
    public const int D3DPRASTERCAPS_ANTIALIASSORTDEPENDENT = 0x00000400;
    public const int D3DPRASTERCAPS_ANTIALIASSORTINDEPENDENT = 0x00000800;
    public const int D3DPRASTERCAPS_ANTIALIASEDGES = 0x00001000;
    public const int D3DPRASTERCAPS_MIPMAPLODBIAS = 0x00002000;
    public const int D3DPRASTERCAPS_ZBIAS = 0x00004000;
    public const int D3DPRASTERCAPS_ZBUFFERLESSHSR = 0x00008000;
    public const int D3DPRASTERCAPS_FOGRANGE = 0x00010000;
    public const int D3DPRASTERCAPS_ANISOTROPY = 0x00020000;
    public const int D3DPRASTERCAPS_WBUFFER = 0x00040000;
    public const int D3DPRASTERCAPS_TRANSLUCENTSORTINDEPENDENT = 0x00080000;
    public const int D3DPRASTERCAPS_WFOG = 0x00100000;
    public const int D3DPRASTERCAPS_ZFOG = 0x00200000;
    public const int D3DPCMPCAPS_NEVER = 0x00000001;
    public const int D3DPCMPCAPS_LESS = 0x00000002;
    public const int D3DPCMPCAPS_EQUAL = 0x00000004;
    public const int D3DPCMPCAPS_LESSEQUAL = 0x00000008;
    public const int D3DPCMPCAPS_GREATER = 0x00000010;
    public const int D3DPCMPCAPS_NOTEQUAL = 0x00000020;
    public const int D3DPCMPCAPS_GREATEREQUAL = 0x00000040;
    public const int D3DPCMPCAPS_ALWAYS = 0x00000080;
    public const int D3DPBLENDCAPS_ZERO = 0x00000001;
    public const int D3DPBLENDCAPS_ONE = 0x00000002;
    public const int D3DPBLENDCAPS_SRCCOLOR = 0x00000004;
    public const int D3DPBLENDCAPS_INVSRCCOLOR = 0x00000008;
    public const int D3DPBLENDCAPS_SRCALPHA = 0x00000010;
    public const int D3DPBLENDCAPS_INVSRCALPHA = 0x00000020;
    public const int D3DPBLENDCAPS_DESTALPHA = 0x00000040;
    public const int D3DPBLENDCAPS_INVDESTALPHA = 0x00000080;
    public const int D3DPBLENDCAPS_DESTCOLOR = 0x00000100;
    public const int D3DPBLENDCAPS_INVDESTCOLOR = 0x00000200;
    public const int D3DPBLENDCAPS_SRCALPHASAT = 0x00000400;
    public const int D3DPBLENDCAPS_BOTHSRCALPHA = 0x00000800;
    public const int D3DPBLENDCAPS_BOTHINVSRCALPHA = 0x00001000;
    public const int D3DPSHADECAPS_COLORFLATMONO = 0x00000001;
    public const int D3DPSHADECAPS_COLORFLATRGB = 0x00000002;
    public const int D3DPSHADECAPS_COLORGOURAUDMONO = 0x00000004;
    public const int D3DPSHADECAPS_COLORGOURAUDRGB = 0x00000008;
    public const int D3DPSHADECAPS_COLORPHONGMONO = 0x00000010;
    public const int D3DPSHADECAPS_COLORPHONGRGB = 0x00000020;
    public const int D3DPSHADECAPS_SPECULARFLATMONO = 0x00000040;
    public const int D3DPSHADECAPS_SPECULARFLATRGB = 0x00000080;
    public const int D3DPSHADECAPS_SPECULARGOURAUDMONO = 0x00000100;
    public const int D3DPSHADECAPS_SPECULARGOURAUDRGB = 0x00000200;
    public const int D3DPSHADECAPS_SPECULARPHONGMONO = 0x00000400;
    public const int D3DPSHADECAPS_SPECULARPHONGRGB = 0x00000800;
    public const int D3DPSHADECAPS_ALPHAFLATBLEND = 0x00001000;
    public const int D3DPSHADECAPS_ALPHAFLATSTIPPLED = 0x00002000;
    public const int D3DPSHADECAPS_ALPHAGOURAUDBLEND = 0x00004000;
    public const int D3DPSHADECAPS_ALPHAGOURAUDSTIPPLED = 0x00008000;
    public const int D3DPSHADECAPS_ALPHAPHONGBLEND = 0x00010000;
    public const int D3DPSHADECAPS_ALPHAPHONGSTIPPLED = 0x00020000;
    public const int D3DPSHADECAPS_FOGFLAT = 0x00040000;
    public const int D3DPSHADECAPS_FOGGOURAUD = 0x00080000;
    public const int D3DPSHADECAPS_FOGPHONG = 0x00100000;
    public const int D3DPTEXTURECAPS_PERSPECTIVE = 0x00000001;
    public const int D3DPTEXTURECAPS_PERSPECTIVE = 0x00000001; // Perspective-correct texturing is supported
    public const int D3DPTEXTURECAPS_POW2 = 0x00000002;
    public const int D3DPTEXTURECAPS_POW2 = 0x00000002; // Power-of-2 texture dimensions are required - applies to non-Cube/Volume textures only.
    public const int D3DPTEXTURECAPS_ALPHA = 0x00000004;
    public const int D3DPTEXTURECAPS_ALPHA = 0x00000004; // Alpha in texture pixels is supported
    public const int D3DPTEXTURECAPS_TRANSPARENCY = 0x00000008;
    public const int D3DPTEXTURECAPS_BORDER = 0x00000010;
    public const int D3DPTEXTURECAPS_SQUAREONLY = 0x00000020;
    public const int D3DPTEXTURECAPS_SQUAREONLY = 0x00000020; // Only square textures are supported
    public const int D3DPTEXTURECAPS_TEXREPEATNOTSCALEDBYSIZE = 0x00000040;
    public const int D3DPTEXTURECAPS_TEXREPEATNOTSCALEDBYSIZE = 0x00000040; // Texture indices are not scaled by the texture size prior to interpolation
    public const int D3DPTEXTURECAPS_ALPHAPALETTE = 0x00000080;
    public const int D3DPTEXTURECAPS_ALPHAPALETTE = 0x00000080; // Device can draw alpha from texture palettes
    public const int D3DPTEXTURECAPS_NONPOW2CONDITIONAL = 0x00000100;
    public const int D3DPTEXTURECAPS_PROJECTED = 0x00000400;
    public const int D3DPTEXTURECAPS_PROJECTED = 0x00000400; // Device can do D3DTTFF_PROJECTED
    public const int D3DPTEXTURECAPS_CUBEMAP = 0x00000800;
    public const int D3DPTEXTURECAPS_CUBEMAP = 0x00000800; // Device can do cubemap textures
    public const int D3DPTEXTURECAPS_COLORKEYBLEND = 0x00001000;
    public const int D3DPTFILTERCAPS_NEAREST = 0x00000001;
    public const int D3DPTFILTERCAPS_LINEAR = 0x00000002;
    public const int D3DPTFILTERCAPS_MIPNEAREST = 0x00000004;
    public const int D3DPTFILTERCAPS_MIPLINEAR = 0x00000008;
    public const int D3DPTFILTERCAPS_LINEARMIPNEAREST = 0x00000010;
    public const int D3DPTFILTERCAPS_LINEARMIPLINEAR = 0x00000020;
    public const int D3DPTFILTERCAPS_MINFPOINT = 0x00000100;
    public const int D3DPTFILTERCAPS_MINFPOINT = 0x00000100; // Min Filter
    public const int D3DPTFILTERCAPS_MINFLINEAR = 0x00000200;
    public const int D3DPTFILTERCAPS_MINFANISOTROPIC = 0x00000400;
    public const int D3DPTFILTERCAPS_MIPFPOINT = 0x00010000;
    public const int D3DPTFILTERCAPS_MIPFPOINT = 0x00010000; // Mip Filter
    public const int D3DPTFILTERCAPS_MIPFLINEAR = 0x00020000;
    public const int D3DPTFILTERCAPS_MAGFPOINT = 0x01000000;
    public const int D3DPTFILTERCAPS_MAGFPOINT = 0x01000000; // Mag Filter
    public const int D3DPTFILTERCAPS_MAGFLINEAR = 0x02000000;
    public const int D3DPTFILTERCAPS_MAGFANISOTROPIC = 0x04000000;
    public const int D3DPTFILTERCAPS_MAGFAFLATCUBIC = 0x08000000;
    public const int D3DPTFILTERCAPS_MAGFGAUSSIANCUBIC = 0x10000000;
    public const int D3DPTBLENDCAPS_DECAL = 0x00000001;
    public const int D3DPTBLENDCAPS_MODULATE = 0x00000002;
    public const int D3DPTBLENDCAPS_DECALALPHA = 0x00000004;
    public const int D3DPTBLENDCAPS_MODULATEALPHA = 0x00000008;
    public const int D3DPTBLENDCAPS_DECALMASK = 0x00000010;
    public const int D3DPTBLENDCAPS_MODULATEMASK = 0x00000020;
    public const int D3DPTBLENDCAPS_COPY = 0x00000040;
    public const int D3DPTBLENDCAPS_ADD = 0x00000080;
    public const int D3DPTADDRESSCAPS_WRAP = 0x00000001;
    public const int D3DPTADDRESSCAPS_MIRROR = 0x00000002;
    public const int D3DPTADDRESSCAPS_CLAMP = 0x00000004;
    public const int D3DPTADDRESSCAPS_BORDER = 0x00000008;
    public const int D3DPTADDRESSCAPS_INDEPENDENTUV = 0x00000010;
    public const int D3DSTENCILCAPS_KEEP = 0x00000001;
    public const int D3DSTENCILCAPS_ZERO = 0x00000002;
    public const int D3DSTENCILCAPS_REPLACE = 0x00000004;
    public const int D3DSTENCILCAPS_INCRSAT = 0x00000008;
    public const int D3DSTENCILCAPS_DECRSAT = 0x00000010;
    public const int D3DSTENCILCAPS_INVERT = 0x00000020;
    public const int D3DSTENCILCAPS_INCR = 0x00000040;
    public const int D3DSTENCILCAPS_DECR = 0x00000080;
    public const int D3DTEXOPCAPS_DISABLE = 0x00000001;
    public const int D3DTEXOPCAPS_SELECTARG1 = 0x00000002;
    public const int D3DTEXOPCAPS_SELECTARG2 = 0x00000004;
    public const int D3DTEXOPCAPS_MODULATE = 0x00000008;
    public const int D3DTEXOPCAPS_MODULATE2X = 0x00000010;
    public const int D3DTEXOPCAPS_MODULATE4X = 0x00000020;
    public const int D3DTEXOPCAPS_ADD = 0x00000040;
    public const int D3DTEXOPCAPS_ADDSIGNED = 0x00000080;
    public const int D3DTEXOPCAPS_ADDSIGNED2X = 0x00000100;
    public const int D3DTEXOPCAPS_SUBTRACT = 0x00000200;
    public const int D3DTEXOPCAPS_ADDSMOOTH = 0x00000400;
    public const int D3DTEXOPCAPS_BLENDDIFFUSEALPHA = 0x00000800;
    public const int D3DTEXOPCAPS_BLENDTEXTUREALPHA = 0x00001000;
    public const int D3DTEXOPCAPS_BLENDFACTORALPHA = 0x00002000;
    public const int D3DTEXOPCAPS_BLENDTEXTUREALPHAPM = 0x00004000;
    public const int D3DTEXOPCAPS_BLENDCURRENTALPHA = 0x00008000;
    public const int D3DTEXOPCAPS_PREMODULATE = 0x00010000;
    public const int D3DTEXOPCAPS_MODULATEALPHA_ADDCOLOR = 0x00020000;
    public const int D3DTEXOPCAPS_MODULATECOLOR_ADDALPHA = 0x00040000;
    public const int D3DTEXOPCAPS_MODULATEINVALPHA_ADDCOLOR = 0x00080000;
    public const int D3DTEXOPCAPS_MODULATEINVCOLOR_ADDALPHA = 0x00100000;
    public const int D3DTEXOPCAPS_BUMPENVMAP = 0x00200000;
    public const int D3DTEXOPCAPS_BUMPENVMAPLUMINANCE = 0x00400000;
    public const int D3DTEXOPCAPS_DOTPRODUCT3 = 0x00800000;
    public const int D3DFVFCAPS_TEXCOORDCOUNTMASK = 0x0000ffff; // mask for texture coordinate count field
    public const int D3DFVFCAPS_DONOTSTRIPELEMENTS = 0x00080000; // Device prefers that vertex elements not be stripped
    public const int D3DDD_COLORMODEL = 0x00000001; // dcmColorModel is valid
    public const int D3DDD_DEVCAPS = 0x00000002; // dwDevCaps is valid
    public const int D3DDD_TRANSFORMCAPS = 0x00000004; // dtcTransformCaps is valid
    public const int D3DDD_LIGHTINGCAPS = 0x00000008; // dlcLightingCaps is valid
    public const int D3DDD_BCLIPPING = 0x00000010; // bClipping is valid
    public const int D3DDD_LINECAPS = 0x00000020; // dpcLineCaps is valid
    public const int D3DDD_TRICAPS = 0x00000040; // dpcTriCaps is valid
    public const int D3DDD_DEVICERENDERBITDEPTH = 0x00000080; // dwDeviceRenderBitDepth is valid
    public const int D3DDD_DEVICEZBUFFERBITDEPTH = 0x00000100; // dwDeviceZBufferBitDepth is valid
    public const int D3DDD_MAXBUFFERSIZE = 0x00000200; // dwMaxBufferSize is valid
    public const int D3DDD_MAXVERTEXCOUNT = 0x00000400; // dwMaxVertexCount is valid
    public const int D3DDEVCAPS_FLOATTLVERTEX = 0x00000001; // Device accepts floating point
    public const int D3DDEVCAPS_SORTINCREASINGZ = 0x00000002; // Device needs data sorted for increasing Z
    public const int D3DDEVCAPS_SORTDECREASINGZ = 0X00000004; // Device needs data sorted for decreasing Z
    public const int D3DDEVCAPS_SORTEXACT = 0x00000008; // Device needs data sorted exactly
    public const int D3DDEVCAPS_EXECUTESYSTEMMEMORY = 0x00000010; // Device can use execute buffers from system memory
    public const int D3DDEVCAPS_EXECUTEVIDEOMEMORY = 0x00000020; // Device can use execute buffers from video memory
    public const int D3DDEVCAPS_TLVERTEXSYSTEMMEMORY = 0x00000040; // Device can use TL buffers from system memory
    public const int D3DDEVCAPS_TLVERTEXVIDEOMEMORY = 0x00000080; // Device can use TL buffers from video memory
    public const int D3DDEVCAPS_TEXTURESYSTEMMEMORY = 0x00000100; // Device can texture from system memory
    public const int D3DDEVCAPS_TEXTUREVIDEOMEMORY = 0x00000200; // Device can texture from device memory
    public const int D3DDEVCAPS_DRAWPRIMTLVERTEX = 0x00000400; // Device can draw TLVERTEX primitives
    public const int D3DDEVCAPS_CANRENDERAFTERFLIP = 0x00000800; // Device can render without waiting for flip to complete
    public const int D3DDEVCAPS_TEXTURENONLOCALVIDMEM = 0x00001000; // Device can texture from nonlocal video memory
    public const int D3DDEVCAPS_DRAWPRIMITIVES2 = 0x00002000; // Device can support DrawPrimitives2
    public const int D3DDEVCAPS_SEPARATETEXTUREMEMORIES = 0x00004000; // Device is texturing from separate memory pools
    public const int D3DDEVCAPS_DRAWPRIMITIVES2EX = 0x00008000; // Device can support Extended DrawPrimitives2 i.e. DX7 compliant driver
    public const int D3DDEVCAPS_HWTRANSFORMANDLIGHT = 0x00010000; // Device can support transformation and lighting in hardware and DRAWPRIMITIVES2EX must be also
    public const int D3DDEVCAPS_CANBLTSYSTONONLOCAL = 0x00020000; // Device supports a Tex Blt from system memory to non-local vidmem
    public const int D3DDEVCAPS_HWRASTERIZATION = 0x00080000; // Device has HW acceleration for rasterization
    public const int D3DVTXPCAPS_TEXGEN = 0x00000001;
    public const int D3DVTXPCAPS_TEXGEN = 0x00000001; // device can do texgen
    public const int D3DVTXPCAPS_MATERIALSOURCE7 = 0x00000002;
    public const int D3DVTXPCAPS_MATERIALSOURCE7 = 0x00000002; // device can do DX7-level colormaterialsource ops
    public const int D3DVTXPCAPS_VERTEXFOG = 0x00000004;
    public const int D3DVTXPCAPS_DIRECTIONALLIGHTS = 0x00000008;
    public const int D3DVTXPCAPS_DIRECTIONALLIGHTS = 0x00000008; // device can do directional lights
    public const int D3DVTXPCAPS_POSITIONALLIGHTS = 0x00000010;
    public const int D3DVTXPCAPS_POSITIONALLIGHTS = 0x00000010; // device can do positional lights (includes point and spot)
    public const int D3DVTXPCAPS_LOCALVIEWER = 0x00000020;
    public const int D3DVTXPCAPS_LOCALVIEWER = 0x00000020; // device can do local viewer
    public const int D3DFDS_COLORMODEL = 0x00000001; // Match color model
    public const int D3DFDS_GUID = 0x00000002; // Match guid
    public const int D3DFDS_HARDWARE = 0x00000004; // Match hardware/software
    public const int D3DFDS_TRIANGLES = 0x00000008; // Match in triCaps
    public const int D3DFDS_LINES = 0x00000010; // Match in lineCaps
    public const int D3DFDS_MISCCAPS = 0x00000020; // Match primCaps.dwMiscCaps
    public const int D3DFDS_RASTERCAPS = 0x00000040; // Match primCaps.dwRasterCaps
    public const int D3DFDS_ZCMPCAPS = 0x00000080; // Match primCaps.dwZCmpCaps
    public const int D3DFDS_ALPHACMPCAPS = 0x00000100; // Match primCaps.dwAlphaCmpCaps
    public const int D3DFDS_SRCBLENDCAPS = 0x00000200; // Match primCaps.dwSourceBlendCaps
    public const int D3DFDS_DSTBLENDCAPS = 0x00000400; // Match primCaps.dwDestBlendCaps
    public const int D3DFDS_SHADECAPS = 0x00000800; // Match primCaps.dwShadeCaps
    public const int D3DFDS_TEXTURECAPS = 0x00001000; // Match primCaps.dwTextureCaps
    public const int D3DFDS_TEXTUREFILTERCAPS = 0x00002000; // Match primCaps.dwTextureFilterCaps
    public const int D3DFDS_TEXTUREBLENDCAPS = 0x00004000; // Match primCaps.dwTextureBlendCaps
    public const int D3DFDS_TEXTUREADDRESSCAPS = 0x00008000; // Match primCaps.dwTextureBlendCaps
    public const int D3DDEB_BUFSIZE = 0x00000001; // buffer size valid
    public const int D3DDEB_CAPS = 0x00000002; // caps valid
    public const int D3DDEB_LPDATA = 0x00000004; // lpData valid
    public const int D3DDEBCAPS_SYSTEMMEMORY = 0x00000001; // buffer in system memory
    public const int D3DDEBCAPS_VIDEOMEMORY = 0x00000002; // buffer in device memory
    public const int D3DNEXT_NEXT = 0x00000001;
    public const int D3DNEXT_HEAD = 0x00000002;
    public const int D3DNEXT_TAIL = 0x00000004;
    public const int D3DDP_WAIT = 0x00000001;
#if (DIRECT3D_VERSION == 0x0500)
    public const int D3DDP_OUTOFORDER = 0x00000002;
#endif
    public const int D3DDP_DONOTCLIP = 0x00000004;
    public const int D3DDP_DONOTUPDATEEXTENTS = 0x00000008;
    public const int D3DDP_DONOTLIGHT = 0x00000010;
    public const int D3D_SDK_VERSION = 220;
#if ! D3D_DEBUG_INFO
    public const int D3D_SDK_VERSION = 32;
#endif
    public const int D3DCS_LEFT = 0x00000001;
    public const int D3DCS_RIGHT = 0x00000002;
    public const int D3DCS_TOP = 0x00000004;
    public const int D3DCS_BOTTOM = 0x00000008;
    public const int D3DCS_FRONT = 0x00000010;
    public const int D3DCS_BACK = 0x00000020;
    public const int D3DCS_PLANE0 = 0x00000040;
    public const int D3DCS_PLANE1 = 0x00000080;
    public const int D3DCS_PLANE2 = 0x00000100;
    public const int D3DCS_PLANE3 = 0x00000200;
    public const int D3DCS_PLANE4 = 0x00000400;
    public const int D3DCS_PLANE5 = 0x00000800;
    public const int D3DWRAP_W = 0x00000004;
    public const int D3DTA_TEMP = 0x00000005; // select temporary register color (read/write)
    public const int D3DFVF_PSIZE = 0x020;
    public const int D3DFVF_LASTBETA_UBYTE4 = 0x1000;
    public const int D3DVSD_TOKENTYPESHIFT = 29;
    public const int D3DVSD_STREAMNUMBERSHIFT = 0;
    public const int D3DVSD_DATALOADTYPESHIFT = 28;
    public const int D3DVSD_DATATYPESHIFT = 16;
    public const int D3DVSD_SKIPCOUNTSHIFT = 16;
    public const int D3DVSD_VERTEXREGSHIFT = 0;
    public const int D3DVSD_VERTEXREGINSHIFT = 20;
    public const int D3DVSD_CONSTCOUNTSHIFT = 25;
    public const int D3DVSD_CONSTADDRESSSHIFT = 0;
    public const int D3DVSD_CONSTRSSHIFT = 16;
    public const int D3DVSD_EXTCOUNTSHIFT = 24;
    public const int D3DVSD_EXTINFOSHIFT = 0;
    public const int D3DVSD_STREAMTESSSHIFT = 28;
    public const int D3DVSDT_FLOAT1 = 0x00; // 1D float expanded to (value, 0., 0., 1.)
    public const int D3DVSDT_FLOAT2 = 0x01; // 2D float expanded to (value, value, 0., 1.)
    public const int D3DVSDT_FLOAT3 = 0x02; // 3D float expanded to (value, value, value, 1.)
    public const int D3DVSDT_FLOAT4 = 0x03; // 4D float
    public const int D3DVSDT_D3DCOLOR = 0x04; // 4D packed unsigned bytes mapped to 0. to 1. range
    public const int D3DVSDT_UBYTE4 = 0x05; // 4D unsigned byte
    public const int D3DVSDT_SHORT2 = 0x06; // 2D signed short expanded to (value, value, 0., 1.)
    public const int D3DVSDT_SHORT4 = 0x07; // 4D signed short
    public const int D3DVSDE_POSITION = 0;
    public const int D3DVSDE_BLENDWEIGHT = 1;
    public const int D3DVSDE_BLENDINDICES = 2;
    public const int D3DVSDE_NORMAL = 3;
    public const int D3DVSDE_PSIZE = 4;
    public const int D3DVSDE_DIFFUSE = 5;
    public const int D3DVSDE_SPECULAR = 6;
    public const int D3DVSDE_TEXCOORD0 = 7;
    public const int D3DVSDE_TEXCOORD1 = 8;
    public const int D3DVSDE_TEXCOORD2 = 9;
    public const int D3DVSDE_TEXCOORD3 = 10;
    public const int D3DVSDE_TEXCOORD4 = 11;
    public const int D3DVSDE_TEXCOORD5 = 12;
    public const int D3DVSDE_TEXCOORD6 = 13;
    public const int D3DVSDE_TEXCOORD7 = 14;
    public const int D3DVSDE_POSITION2 = 15;
    public const int D3DVSDE_NORMAL2 = 16;
    public const int D3DSI_OPCODE_MASK = 0x0000FFFF;
    public const int D3DSI_COISSUE = 0x40000000;
    public const int D3DSP_REGNUM_MASK = 0x00001FFF;
    public const int D3DSP_REGNUM_MASK = 0x000007FF;
    public const int D3DSP_WRITEMASK_0 = 0x00010000; // Component 0 (X;Red)
    public const int D3DSP_WRITEMASK_1 = 0x00020000; // Component 1 (Y;Green)
    public const int D3DSP_WRITEMASK_2 = 0x00040000; // Component 2 (Z;Blue)
    public const int D3DSP_WRITEMASK_3 = 0x00080000; // Component 3 (W;Alpha)
    public const int D3DSP_WRITEMASK_ALL = 0x000F0000; // All Components
    public const int D3DSP_DSTMOD_SHIFT = 20;
    public const int D3DSP_DSTMOD_MASK = 0x00F00000;
    public const int D3DSP_DSTSHIFT_SHIFT = 24;
    public const int D3DSP_DSTSHIFT_MASK = 0x0F000000;
    public const int D3DSP_REGTYPE_SHIFT = 28;
    public const int D3DSP_REGTYPE_MASK = 0x70000000;
    public const int D3DVS_ADDRESSMODE_SHIFT = 13;
    public const int D3DVS_SWIZZLE_SHIFT = 16;
    public const int D3DVS_SWIZZLE_MASK = 0x00FF0000;
    public const int D3DSP_SWIZZLE_SHIFT = 16;
    public const int D3DSP_SWIZZLE_MASK = 0x00FF0000;
    public const int D3DSP_SRCMOD_SHIFT = 24;
    public const int D3DSP_SRCMOD_MASK = 0x0F000000;
    public const int D3DSI_COMMENTSIZE_SHIFT = 16;
    public const int D3DSI_COMMENTSIZE_MASK = 0x7FFF0000;
    public const int D3DPRESENT_RATE_DEFAULT = 0x00000000;
    public const int D3DPRESENT_RATE_UNLIMITED = 0x7fffffff;
    public const int D3DPRESENTFLAG_LOCKABLE_BACKBUFFER = 0x00000001;
    public const int D3DLOCK_READONLY = 0x00000010;
    public const int D3DLOCK_DISCARD = 0x00002000;
    public const int D3DLOCK_NOOVERWRITE = 0x00001000;
    public const int D3DLOCK_NOSYSLOCK = 0x00000800;
    public const int D3DLOCK_NO_DIRTY_UPDATE = 0x00008000;
    public const int MAX_DEVICE_IDENTIFIER_STRING = 512;
    public const int D3DDEVINFOID_RESOURCEMANAGER = 5; // Used with D3DDEVINFO_RESOURCEMANAGER
    public const int D3DDEVINFOID_VERTEXSTATS = 6; // Used with D3DDEVINFO_D3DVERTEXSTATS
    public const int D3DCAPS_READ_SCANLINE = 0x00020000;
    public const int D3DCAPS2_NO2DDURING3DSCENE = 0x00000002;
    public const int D3DCAPS2_FULLSCREENGAMMA = 0x00020000;
    public const int D3DCAPS2_CANRENDERWINDOWED = 0x00080000;
    public const int D3DCAPS2_CANCALIBRATEGAMMA = 0x00100000;
    public const int D3DCAPS2_RESERVED = 0x02000000;
    public const int D3DCAPS2_CANMANAGERESOURCE = 0x10000000;
    public const int D3DCAPS2_DYNAMICTEXTURES = 0x20000000;
    public const uint D3DCAPS3_RESERVED = 0x8000001f;
    public const int D3DCAPS3_ALPHA_FULLSCREEN_FLIP_OR_DISCARD = 0x00000020;
    public const int D3DPRESENT_INTERVAL_DEFAULT = 0x00000000;
    public const int D3DPRESENT_INTERVAL_ONE = 0x00000001;
    public const int D3DPRESENT_INTERVAL_TWO = 0x00000002;
    public const int D3DPRESENT_INTERVAL_THREE = 0x00000004;
    public const int D3DPRESENT_INTERVAL_FOUR = 0x00000008;
    public const uint D3DPRESENT_INTERVAL_IMMEDIATE = 0x80000000;
    public const int D3DCURSORCAPS_COLOR = 0x00000001;
    public const int D3DCURSORCAPS_LOWRES = 0x00000002;
    public const int D3DDEVCAPS_PUREDEVICE = 0x00100000; // Device supports D3DCREATE_PUREDEVICE
    public const int D3DDEVCAPS_QUINTICRTPATCHES = 0x00200000; // Device supports quintic Beziers and BSplines
    public const int D3DDEVCAPS_RTPATCHES = 0x00400000; // Device supports Rect and Tri patches
    public const int D3DDEVCAPS_RTPATCHHANDLEZERO = 0x00800000; // Indicates that RT Patches may be drawn efficiently using handle 0
    public const int D3DDEVCAPS_NPATCHES = 0x01000000; // Device supports N-Patches
    public const int D3DPMISCCAPS_COLORWRITEENABLE = 0x00000080;
    public const int D3DPMISCCAPS_CLIPPLANESCALEDPOINTS = 0x00000100; // Device correctly clips scaled points to clip planes
    public const int D3DPMISCCAPS_CLIPTLVERTS = 0x00000200; // device will clip post-transformed vertex primitives
    public const int D3DPMISCCAPS_TSSARGTEMP = 0x00000400; // device supports D3DTA_TEMP for temporary register
    public const int D3DPMISCCAPS_BLENDOP = 0x00000800; // device supports D3DRS_BLENDOP
    public const int D3DPMISCCAPS_NULLREFERENCE = 0x00001000; // Reference Device that doesnt render
    public const int D3DLINECAPS_TEXTURE = 0x00000001;
    public const int D3DLINECAPS_ZTEST = 0x00000002;
    public const int D3DLINECAPS_BLEND = 0x00000004;
    public const int D3DLINECAPS_ALPHACMP = 0x00000008;
    public const int D3DLINECAPS_FOG = 0x00000010;
    public const int D3DPRASTERCAPS_COLORPERSPECTIVE = 0x00400000; // Device iterates colors perspective correct
    public const int D3DPRASTERCAPS_STRETCHBLTMULTISAMPLE = 0x00800000;
    public const int D3DPTEXTURECAPS_VOLUMEMAP = 0x00002000; // Device can do volume textures
    public const int D3DPTEXTURECAPS_MIPMAP = 0x00004000; // Device can do mipmapped textures
    public const int D3DPTEXTURECAPS_MIPVOLUMEMAP = 0x00008000; // Device can do mipmapped volume textures
    public const int D3DPTEXTURECAPS_MIPCUBEMAP = 0x00010000; // Device can do mipmapped cube maps
    public const int D3DPTEXTURECAPS_CUBEMAP_POW2 = 0x00020000; // Device requires that cubemaps be power-of-2 dimension
    public const int D3DPTEXTURECAPS_VOLUMEMAP_POW2 = 0x00040000; // Device requires that volume maps be power-of-2 dimension
    public const int D3DPTADDRESSCAPS_MIRRORONCE = 0x00000020;
    public const int D3DTEXOPCAPS_MULTIPLYADD = 0x01000000;
    public const int D3DTEXOPCAPS_LERP = 0x02000000;
    public const int D3DFVFCAPS_PSIZE = 0x00100000; // Device can receive point size
    public const int D3DVTXPCAPS_TWEENING = 0x00000040; // device can do vertex tweening
    public const int D3DVTXPCAPS_NO_VSDT_UBYTE4 = 0x00000080; // device does not support D3DVSDT_UBYTE4
    public const int D3DSPD_IUNKNOWN = 0x00000001;
    public const int D3DCURRENT_DISPLAY_MODE = 0x00EFFFFF;
    public const int D3DCREATE_FPU_PRESERVE = 0x00000002;
    public const int D3DCREATE_MULTITHREADED = 0x00000004;
    public const int D3DCREATE_PUREDEVICE = 0x00000010;
    public const int D3DCREATE_SOFTWARE_VERTEXPROCESSING = 0x00000020;
    public const int D3DCREATE_HARDWARE_VERTEXPROCESSING = 0x00000040;
    public const int D3DCREATE_MIXED_VERTEXPROCESSING = 0x00000080;
    public const int D3DCREATE_DISABLE_DRIVER_MANAGEMENT = 0x00000100;
    public const int D3DADAPTER_DEFAULT = 0;
    public const int D3DENUM_NO_WHQL_LEVEL = 0x00000002;
    public const int D3DPRESENT_BACK_BUFFERS_MAX = 3;
    public const int D3DSGR_NO_CALIBRATION = 0x00000000;
    public const int D3DSGR_CALIBRATE = 0x00000001;
    public const int D3DCURSOR_IMMEDIATE_UPDATE = 0x00000001;
    public const int _FACD3D = 0x876;
#if ! D3D_DEBUG_INFO
    public const int D3D9b_SDK_VERSION = 31;
#endif
    public const int D3D_MAX_SIMULTANEOUS_RENDERTARGETS = 4;
    public const int D3DDMAPSAMPLER = 256;
    public const int D3DTSS_TCI_SPHEREMAP = 0x00040000;
    public const int D3DTA_CONSTANT = 0x00000006; // select texture stage constant
    public const int D3DFVF_XYZW = 0x4002;
    public const int D3DFVF_LASTBETA_D3DCOLOR = 0x8000;
    public const int MAXD3DDECLUSAGEINDEX = 15;
    public const int MAXD3DDECLLENGTH = 64; // does not include "end" marker vertex element
    public const int D3DSI_INSTLENGTH_MASK = 0x0F000000;
    public const int D3DSI_INSTLENGTH_SHIFT = 24;
    public const int D3DSP_OPCODESPECIFICCONTROL_MASK = 0x00ff0000;
    public const int D3DSP_OPCODESPECIFICCONTROL_SHIFT = 16;
    public const int D3DSP_DCL_USAGE_SHIFT = 0;
    public const int D3DSP_DCL_USAGE_MASK = 0x0000000f;
    public const int D3DSP_DCL_USAGEINDEX_SHIFT = 16;
    public const int D3DSP_DCL_USAGEINDEX_MASK = 0x000f0000;
    public const int D3DSP_TEXTURETYPE_SHIFT = 27;
    public const int D3DSP_TEXTURETYPE_MASK = 0x78000000;
    public const int D3DSP_REGTYPE_SHIFT2 = 8;
    public const int D3DSP_REGTYPE_MASK2 = 0x00001800;
    public const int D3DSHADER_ADDRESSMODE_SHIFT = 13;
    public const int D3DPRESENTFLAG_DISCARD_DEPTHSTENCIL = 0x00000002;
    public const int D3DPRESENTFLAG_DEVICECLIP = 0x00000004;
    public const int D3DPRESENTFLAG_VIDEO = 0x00000010;
    public const int D3DLOCK_DONOTWAIT = 0x00004000;
    public const int D3DVS20_MAX_DYNAMICFLOWCONTROLDEPTH = 24;
    public const int D3DVS20_MIN_DYNAMICFLOWCONTROLDEPTH = 0;
    public const int D3DVS20_MAX_NUMTEMPS = 32;
    public const int D3DVS20_MIN_NUMTEMPS = 12;
    public const int D3DVS20_MAX_STATICFLOWCONTROLDEPTH = 4;
    public const int D3DVS20_MIN_STATICFLOWCONTROLDEPTH = 1;
    public const int D3DPS20_MAX_DYNAMICFLOWCONTROLDEPTH = 24;
    public const int D3DPS20_MIN_DYNAMICFLOWCONTROLDEPTH = 0;
    public const int D3DPS20_MAX_NUMTEMPS = 32;
    public const int D3DPS20_MIN_NUMTEMPS = 12;
    public const int D3DPS20_MAX_STATICFLOWCONTROLDEPTH = 4;
    public const int D3DPS20_MIN_STATICFLOWCONTROLDEPTH = 0;
    public const int D3DPS20_MAX_NUMINSTRUCTIONSLOTS = 512;
    public const int D3DPS20_MIN_NUMINSTRUCTIONSLOTS = 96;
    public const int D3DMIN30SHADERINSTRUCTIONS = 512;
    public const int D3DMAX30SHADERINSTRUCTIONS = 32768;
    public const int D3DCAPS2_CANAUTOGENMIPMAP = 0x40000000;
    public const int D3DCAPS3_LINEAR_TO_SRGB_PRESENTATION = 0x00000080;
    public const int D3DCAPS3_COPY_TO_VIDMEM = 0x00000100; // Device can acclerate copies from sysmem to local vidmem
    public const int D3DCAPS3_COPY_TO_SYSTEMMEM = 0x00000200; // Device can acclerate copies from local vidmem to sysmem
    public const int D3DPMISCCAPS_INDEPENDENTWRITEMASKS = 0x00004000; // Device supports independent write masks for MET or MRT
    public const int D3DPMISCCAPS_PERSTAGECONSTANT = 0x00008000; // Device supports per-stage constants
    public const int D3DPMISCCAPS_FOGANDSPECULARALPHA = 0x00010000;
    public const int D3DPMISCCAPS_SEPARATEALPHABLEND = 0x00020000; // Device supports separate blend settings for the alpha channel
    public const int D3DPMISCCAPS_MRTINDEPENDENTBITDEPTHS = 0x00040000; // Device supports different bit depths for MRT
    public const int D3DPMISCCAPS_MRTPOSTPIXELSHADERBLENDING = 0x00080000; // Device supports post-pixel shader operations for MRT
    public const int D3DPMISCCAPS_FOGVERTEXCLAMPED = 0x00100000; // Device clamps fog blend factor per vertex
    public const int D3DLINECAPS_ANTIALIAS = 0x00000020;
    public const int D3DPRASTERCAPS_SCISSORTEST = 0x01000000;
    public const int D3DPRASTERCAPS_SLOPESCALEDEPTHBIAS = 0x02000000;
    public const int D3DPRASTERCAPS_DEPTHBIAS = 0x04000000;
    public const int D3DPRASTERCAPS_MULTISAMPLE_TOGGLE = 0x08000000;
    public const int D3DPBLENDCAPS_BLENDFACTOR = 0x00002000; // Supports both D3DBLEND_BLENDFACTOR and D3DBLEND_INVBLENDFACTOR
    public const int D3DPTEXTURECAPS_NOPROJECTEDBUMPENV = 0x00200000;
    public const int D3DPTFILTERCAPS_MINFPYRAMIDALQUAD = 0x00000800;
    public const int D3DPTFILTERCAPS_MINFGAUSSIANQUAD = 0x00001000;
    public const int D3DPTFILTERCAPS_MAGFPYRAMIDALQUAD = 0x08000000;
    public const int D3DPTFILTERCAPS_MAGFGAUSSIANQUAD = 0x10000000;
    public const int D3DSTENCILCAPS_TWOSIDED = 0x00000100;
    public const int D3DVTXPCAPS_TEXGEN_SPHEREMAP = 0x00000100; // device supports D3DTSS_TCI_SPHEREMAP
    public const int D3DVTXPCAPS_NO_TEXGEN_NONLOCALVIEWER = 0x00000200;
    public const int D3DDEVCAPS2_STREAMOFFSET = 0x00000001; // Device supports offsets in streams. Must be set by DX9 drivers
    public const int D3DDEVCAPS2_DMAPNPATCH = 0x00000002; // Device supports displacement maps for N-Patches
    public const int D3DDEVCAPS2_ADAPTIVETESSRTPATCH = 0x00000004; // Device supports adaptive tesselation of RT-patches
    public const int D3DDEVCAPS2_ADAPTIVETESSNPATCH = 0x00000008; // Device supports adaptive tesselation of N-patches
    public const int D3DDEVCAPS2_CAN_STRETCHRECT_FROM_TEXTURES = 0x00000010; // Device supports StretchRect calls with a texture as the source
    public const int D3DDEVCAPS2_PRESAMPLEDDMAPNPATCH = 0x00000020; // Device supports presampled displacement maps for N-Patches
    public const int D3DDEVCAPS2_VERTEXELEMENTSCANSHARESTREAMOFFSET = 0x00000040; // Vertex elements in a vertex declaration can share the same stream offset
    public const int D3DDTCAPS_UBYTE4 = 0x00000001;
    public const int D3DDTCAPS_UBYTE4N = 0x00000002;
    public const int D3DDTCAPS_SHORT2N = 0x00000004;
    public const int D3DDTCAPS_SHORT4N = 0x00000008;
    public const int D3DDTCAPS_USHORT2N = 0x00000010;
    public const int D3DDTCAPS_USHORT4N = 0x00000020;
    public const int D3DDTCAPS_UDEC3 = 0x00000040;
    public const int D3DDTCAPS_DEC3N = 0x00000080;
    public const int D3DDTCAPS_FLOAT16_2 = 0x00000100;
    public const int D3DDTCAPS_FLOAT16_4 = 0x00000200;
    public const int D3DCREATE_ADAPTERGROUP_DEVICE = 0x00000200;
    public const int D3DCREATE_DISABLE_DRIVER_MANAGEMENT_EX = 0x00000400;
    public const int D3DCREATE_NOWINDOWCHANGES = 0x00000800;
    public const int D3DENUM_WHQL_LEVEL = 0x00000002;
    public const int D3DPRESENT_DONOTWAIT = 0x00000001;
    public const int D3DPRESENT_LINEAR_CONTENT = 0x00000002;
    public const int D3DRMRENDERMODE_BLENDEDTRANSPARENCY = 1;
    public const int D3DRMRENDERMODE_SORTEDTRANSPARENCY = 2;
    public const int D3DRMRENDERMODE_LIGHTINMODELSPACE = 8;
    public const int D3DRMRENDERMODE_VIEWDEPENDENTSPECULAR = 16;
    public const int D3DRMRENDERMODE_DISABLESORTEDALPHAZWRITE = 32;
    public const int D3DRMTEXTURE_FORCERESIDENT = 0x00000001; // texture should be kept in video memory
    public const int D3DRMTEXTURE_STATIC = 0x00000002; // texture will not change
    public const int D3DRMTEXTURE_DOWNSAMPLEPOINT = 0x00000004; // point filtering should be used when downsampling
    public const int D3DRMTEXTURE_DOWNSAMPLEBILINEAR = 0x00000008; // bilinear filtering should be used when downsampling
    public const int D3DRMTEXTURE_DOWNSAMPLEREDUCEDEPTH = 0x00000010; // reduce bit depth when downsampling
    public const int D3DRMTEXTURE_DOWNSAMPLENONE = 0x00000020; // texture should never be downsampled
    public const int D3DRMTEXTURE_CHANGEDPIXELS = 0x00000040; // pixels have changed
    public const int D3DRMTEXTURE_CHANGEDPALETTE = 0x00000080; // palette has changed
    public const int D3DRMTEXTURE_INVALIDATEONLY = 0x00000100; // dirty regions are invalid
    public const int D3DRMSHADOW_TRUEALPHA = 0x00000001; // shadow should render without artifacts when true alpha is on
    public const int D3DRMWIREFRAME_CULL = 1; // cull backfaces
    public const int D3DRMWIREFRAME_HIDDENLINE = 2; // lines are obscured by closer objects
    public const int D3DRMOPTIONS_LEFTHANDED = 0x00000001; // Default
    public const int D3DRMOPTIONS_RIGHTHANDED = 0x00000002;
    public const int D3DRMXOFSAVE_NORMALS = 1;
    public const int D3DRMXOFSAVE_TEXTURECOORDINATES = 2;
    public const int D3DRMXOFSAVE_MATERIALS = 4;
    public const int D3DRMXOFSAVE_TEXTURENAMES = 8;
    public const int D3DRMXOFSAVE_ALL = 15;
    public const int D3DRMXOFSAVE_TEMPLATES = 16;
    public const int D3DRMXOFSAVE_TEXTURETOPOLOGY = 32;
    public const int D3DRMMATERIALOVERRIDE_DIFFUSE_ALPHAONLY = 0x00000001;
    public const int D3DRMMATERIALOVERRIDE_DIFFUSE_RGBONLY = 0x00000002;
    public const int D3DRMMATERIALOVERRIDE_DIFFUSE = 0x00000003;
    public const int D3DRMMATERIALOVERRIDE_AMBIENT = 0x00000004;
    public const int D3DRMMATERIALOVERRIDE_EMISSIVE = 0x00000008;
    public const int D3DRMMATERIALOVERRIDE_SPECULAR = 0x00000010;
    public const int D3DRMMATERIALOVERRIDE_POWER = 0x00000020;
    public const int D3DRMMATERIALOVERRIDE_TEXTURE = 0x00000040;
    public const int D3DRMMATERIALOVERRIDE_DIFFUSE_ALPHAMULTIPLY = 0x00000080;
    public const int D3DRMMATERIALOVERRIDE_ALL = 0x000000FF;
    public const int D3DRMFPTF_ALPHA = 0x00000001;
    public const int D3DRMFPTF_NOALPHA = 0x00000002;
    public const int D3DRMFPTF_PALETTIZED = 0x00000004;
    public const int D3DRMFPTF_NOTPALETTIZED = 0x00000008;
    public const int D3DRMSTATECHANGE_UPDATEONLY = 0x000000001;
    public const int D3DRMSTATECHANGE_VOLATILE = 0x000000002;
    public const int D3DRMSTATECHANGE_NONVOLATILE = 0x000000004;
    public const int D3DRMSTATECHANGE_RENDER = 0x000000020;
    public const int D3DRMSTATECHANGE_LIGHT = 0x000000040;
    public const int D3DRMDEVICE_NOZBUFFER = 0x00000001;
    public const int D3DRMCLIENTDATA_NONE = 0x00000001;
    public const int D3DRMCLIENTDATA_LOCALFREE = 0x00000002;
    public const int D3DRMCLIENTDATA_IUNKNOWN = 0x00000004;
    public const int D3DRMCALLBACK_PREORDER = 0;
    public const int D3DRMCALLBACK_POSTORDER = 1;
    public const int D3DRMRAYPICK_ONLYBOUNDINGBOXES = 1;
    public const int D3DRMRAYPICK_IGNOREFURTHERPRIMITIVES = 2;
    public const int D3DRMRAYPICK_INTERPOLATEUV = 4;
    public const int D3DRMRAYPICK_INTERPOLATECOLOR = 8;
    public const int D3DRMRAYPICK_INTERPOLATENORMAL = 0x10;
    public const int D3DRMADDFACES_VERTICESONLY = 1;
    public const int D3DRMGENERATENORMALS_PRECOMPACT = 1;
    public const int D3DRMGENERATENORMALS_USECREASEANGLE = 2;
    public const int D3DRMMESHBUILDER_DIRECTPARENT = 1;
    public const int D3DRMMESHBUILDER_ROOTMESH = 2;
    public const int D3DRMMESHBUILDER_RENDERENABLE = 0x00000001;
    public const int D3DRMMESHBUILDER_PICKENABLE = 0x00000002;
    public const int D3DRMADDMESHBUILDER_DONTCOPYAPPDATA = 1;
    public const int D3DRMADDMESHBUILDER_FLATTENSUBMESHES = 2;
    public const int D3DRMADDMESHBUILDER_NOSUBMESHES = 4;
    public const int D3DRMMESHBUILDERAGE_GEOMETRY = 0x00000001;
    public const int D3DRMMESHBUILDERAGE_MATERIALS = 0x00000002;
    public const int D3DRMMESHBUILDERAGE_TEXTURES = 0x00000004;
    public const int D3DRMFVF_TYPE = 0x00000001;
    public const int D3DRMFVF_NORMAL = 0x00000002;
    public const int D3DRMFVF_COLOR = 0x00000004;
    public const int D3DRMFVF_TEXTURECOORDS = 0x00000008;
    public const int D3DRMVERTEX_STRIP = 0x00000001;
    public const int D3DRMVERTEX_FAN = 0x00000002;
    public const int D3DRMVERTEX_LIST = 0x00000004;
    public const int D3DRMCLEAR_TARGET = 0x00000001;
    public const int D3DRMCLEAR_ZBUFFER = 0x00000002;
    public const int D3DRMCLEAR_DIRTYRECTS = 0x00000004;
    public const int D3DRMFOGMETHOD_VERTEX = 0x00000001;
    public const int D3DRMFOGMETHOD_TABLE = 0x00000002;
    public const int D3DRMFOGMETHOD_ANY = 0x00000004;
    public const int D3DRMFRAME_RENDERENABLE = 0x00000001;
    public const int D3DRMFRAME_PICKENABLE = 0x00000002;
    public const int D3DRMANIMATION_OPEN = 0x01;
    public const int D3DRMANIMATION_CLOSED = 0x02;
    public const int D3DRMANIMATION_LINEARPOSITION = 0x04;
    public const int D3DRMANIMATION_SPLINEPOSITION = 0x08;
    public const int D3DRMANIMATION_SCALEANDROTATION = 0x00000010;
    public const int D3DRMANIMATION_POSITION = 0x00000020;
    public const int D3DRMINTERPOLATION_OPEN = 0x01;
    public const int D3DRMINTERPOLATION_CLOSED = 0x02;
    public const int D3DRMINTERPOLATION_NEAREST = 0x0100;
    public const int D3DRMINTERPOLATION_LINEAR = 0x04;
    public const int D3DRMINTERPOLATION_SPLINE = 0x08;
    public const int D3DRMINTERPOLATION_VERTEXCOLOR = 0x40;
    public const int D3DRMINTERPOLATION_SLERPNORMALS = 0x80;
    public const int D3DRMLOAD_FROMFILE = 0x00;
    public const int D3DRMLOAD_FROMRESOURCE = 0x01;
    public const int D3DRMLOAD_FROMMEMORY = 0x02;
    public const int D3DRMLOAD_FROMSTREAM = 0x04;
    public const int D3DRMLOAD_FROMURL = 0x08;
    public const int D3DRMLOAD_BYNAME = 0x10;
    public const int D3DRMLOAD_BYPOSITION = 0x20;
    public const int D3DRMLOAD_BYGUID = 0x40;
    public const int D3DRMLOAD_FIRST = 0x80;
    public const int D3DRMLOAD_INSTANCEBYREFERENCE = 0x100;
    public const int D3DRMLOAD_INSTANCEBYCOPYING = 0x200;
    public const int D3DRMLOAD_ASYNCHRONOUS = 0x400;
    public const int D3DRMPMESHSTATUS_VALID = 0x01;
    public const int D3DRMPMESHSTATUS_INTERRUPTED = 0x02;
    public const int D3DRMPMESHSTATUS_BASEMESHCOMPLETE = 0x04;
    public const int D3DRMPMESHSTATUS_COMPLETE = 0x08;
    public const int D3DRMPMESHSTATUS_RENDERABLE = 0x10;
    public const int D3DRMPMESHEVENT_BASEMESH = 0x01;
    public const int D3DRMPMESHEVENT_COMPLETE = 0x02;
    public const int D3DRMANIMATION_ROTATEKEY = 0x01;
    public const int D3DRMANIMATION_SCALEKEY = 0x02;
    public const int D3DRMANIMATION_POSITIONKEY = 0x03;
    public const int FACILITY_D3DX = 0x877;
    public const int D3DX_SC_DEPTHBUFFER = 0x01;
    public const int D3DX_SC_STENCILBUFFER = 0x02;
    public const int D3DX_SC_COLORTEXTURE = 0x04;
    public const int D3DX_SC_BUMPMAP = 0x08;
    public const int D3DX_SC_LUMINANCEMAP = 0x10;
    public const int D3DX_SC_COLORRENDERTGT = 0x20;
    public const int D3DX_DRIVERDESC_LENGTH = 256;
    public const int D3DX_GVM_REFRESHRATE = 0x00000001;
    public const int D3DX_CONTEXT_FULLSCREEN = 0x00000001;
    public const int D3DX_CONTEXT_OFFSCREEN = 0x00000002;
    public const int D3DX_TEXTURE_STAGE0 = 0;
    public const int D3DX_TEXTURE_STAGE1 = 1;
    public const int D3DX_TEXTURE_STAGE2 = 2;
    public const int D3DX_TEXTURE_STAGE3 = 3;
    public const int D3DX_TEXTURE_STAGE4 = 4;
    public const int D3DX_TEXTURE_STAGE5 = 5;
    public const int D3DX_TEXTURE_STAGE6 = 6;
    public const int D3DX_TEXTURE_STAGE7 = 7;
    public const int DXFILEFORMAT_BINARY = 0;
    public const int DXFILEFORMAT_TEXT = 1;
    public const int DXFILEFORMAT_COMPRESSED = 2;
    public const int DXFILELOAD_FROMFILE = 0x00;
    public const int DXFILELOAD_FROMRESOURCE = 0x01;
    public const int DXFILELOAD_FROMMEMORY = 0x02;
    public const int DXFILELOAD_FROMSTREAM = 0x04;
    public const int DXFILELOAD_FROMURL = 0x08;
    public const int DXFILE_OK = 0;
    public const uint D3DX_COMP_TANGENT_NONE = 0xFFFFFFFF;
    public const int D3DX_16F_DIG = 3; // # of decimal digits of precision
    public const int D3DX_16F_MANT_DIG = 11; // # of bits in mantissa
    public const double D3DX_16F_MAX = 6.550400e+004; // max value
    public const int D3DX_16F_MAX_10_EXP = 4; // max decimal exponent
    public const int D3DX_16F_MAX_EXP = 15; // max binary exponent
    public const int D3DX_16F_MIN_10_EXP = -4; // min decimal exponent
    public const int D3DX_16F_MIN_EXP = -12; // min binary exponent
    public const int D3DX_16F_RADIX = 2; // exponent radix
    public const int D3DX_16F_ROUNDS = 1; // addition rounding: near
    public const int D3DXSH_MINORDER = 2;
    public const int D3DXSH_MAXORDER = 6;
    public const int D3DX_VERSION = 0x0902;
    public const int D3DX_SDK_VERSION = 22;
    public const int D3DXF_FILEFORMAT_BINARY = 0;
    public const int D3DXF_FILEFORMAT_TEXT = 1;
    public const int D3DXF_FILEFORMAT_COMPRESSED = 2;
    public const int D3DXF_FILESAVE_TOFILE = 0x00;
    public const int D3DXF_FILESAVE_TOWFILE = 0x01;
    public const int D3DXF_FILELOAD_FROMFILE = 0x00;
    public const int D3DXF_FILELOAD_FROMWFILE = 0x01;
    public const int D3DXF_FILELOAD_FROMRESOURCE = 0x02;
    public const int D3DXF_FILELOAD_FROMMEMORY = 0x03;
    public const int _FACD3DXF = 0x876;
    public const string XEXTENSIONS_TEMPLATES = "xof 0303txt 0032        template FVFData         {             <B6E70A0E-8EF9-4e83-94AD-ECC8B0C04897>             DWORD dwFVF;             DWORD nDWords;             array DWORD data[nDWords];         }         template VertexElement         {             <F752461C-1E23-48f6-B9F8-8350850F336F>             DWORD Type;             DWORD Method;             DWORD Usage;             DWORD UsageIndex;         }         template DeclData         {             <BF22E553-292C-4781-9FEA-62BD554BDD93>             DWORD nElements;             array VertexElement Elements[nElements];             DWORD nDWords;             array DWORD data[nDWords];         }         template PMAttributeRange         {             <917E0427-C61E-4a14-9C64-AFE65F9E9844>             DWORD iFaceOffset;             DWORD nFacesMin;             DWORD nFacesMax;             DWORD iVertexOffset;             DWORD nVerticesMin;             DWORD nVerticesMax;         }         template PMVSplitRecord         {             <574CCC14-F0B3-4333-822D-93E8A8A08E4C>             DWORD iFaceCLW;             DWORD iVlrOffset;             DWORD iCode;         }         template PMInfo         {             <B6C3E656-EC8B-4b92-9B62-681659522947>             DWORD nAttributes;             array PMAttributeRange attributeRanges[nAttributes];             DWORD nMaxValence;             DWORD nMinLogicalVertices;             DWORD nMaxLogicalVertices;             DWORD nVSplits;             array PMVSplitRecord splitRecords[nVSplits];             DWORD nAttributeMispredicts;             array DWORD attributeMispredicts[nAttributeMispredicts];         } ";
    public const int DIRECTINPUT_HEADER_VERSION = 0x0800;
    public const int DIEFT_ALL = 0x00000000;
    public const int DIEFT_CONSTANTFORCE = 0x00000001;
    public const int DIEFT_RAMPFORCE = 0x00000002;
    public const int DIEFT_PERIODIC = 0x00000003;
    public const int DIEFT_CONDITION = 0x00000004;
    public const int DIEFT_CUSTOMFORCE = 0x00000005;
    public const int DIEFT_HARDWARE = 0x000000FF;
    public const int DIEFT_FFATTACK = 0x00000200;
    public const int DIEFT_FFFADE = 0x00000400;
    public const int DIEFT_SATURATION = 0x00000800;
    public const int DIEFT_POSNEGCOEFFICIENTS = 0x00001000;
    public const int DIEFT_POSNEGSATURATION = 0x00002000;
    public const int DIEFT_DEADBAND = 0x00004000;
    public const int DIEFT_STARTDELAY = 0x00008000;
    public const int DI_DEGREES = 100;
    public const int DI_FFNOMINALMAX = 10000;
    public const int DI_SECONDS = 1000000;
    public const int DIEFF_OBJECTIDS = 0x00000001;
    public const int DIEFF_OBJECTOFFSETS = 0x00000002;
    public const int DIEFF_CARTESIAN = 0x00000010;
    public const int DIEFF_POLAR = 0x00000020;
    public const int DIEFF_SPHERICAL = 0x00000040;
    public const int DIEP_DURATION = 0x00000001;
    public const int DIEP_SAMPLEPERIOD = 0x00000002;
    public const int DIEP_GAIN = 0x00000004;
    public const int DIEP_TRIGGERBUTTON = 0x00000008;
    public const int DIEP_TRIGGERREPEATINTERVAL = 0x00000010;
    public const int DIEP_AXES = 0x00000020;
    public const int DIEP_DIRECTION = 0x00000040;
    public const int DIEP_ENVELOPE = 0x00000080;
    public const int DIEP_TYPESPECIFICPARAMS = 0x00000100;
    public const int DIEP_STARTDELAY = 0x00000200;
    public const int DIEP_ALLPARAMS_DX5 = 0x000001FF;
    public const int DIEP_ALLPARAMS = 0x000003FF;
    public const int DIEP_ALLPARAMS = 0x000001FF;
    public const int DIEP_START = 0x20000000;
    public const int DIEP_NORESTART = 0x40000000;
    public const uint DIEP_NODOWNLOAD = 0x80000000;
    public const uint DIEB_NOTRIGGER = 0xFFFFFFFF;
    public const int DIES_SOLO = 0x00000001;
    public const uint DIES_NODOWNLOAD = 0x80000000;
    public const int DIEGES_PLAYING = 0x00000001;
    public const int DIEGES_EMULATED = 0x00000002;
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPE_DEVICE = 1;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPE_MOUSE = 2;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPE_KEYBOARD = 3;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPE_JOYSTICK = 4;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVCLASS_ALL = 0;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVCLASS_DEVICE = 1;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVCLASS_POINTER = 2;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVCLASS_KEYBOARD = 3;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVCLASS_GAMECTRL = 4;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE_DEVICE = 0x11;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE_MOUSE = 0x12;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE_KEYBOARD = 0x13;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE_JOYSTICK = 0x14;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE_GAMEPAD = 0x15;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE_DRIVING = 0x16;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE_FLIGHT = 0x17;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE_1STPERSON = 0x18;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE_DEVICECTRL = 0x19;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE_SCREENPOINTER = 0x1A;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE_REMOTE = 0x1B;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE_SUPPLEMENTAL = 0x1C;
#endif
    public const int DIDEVTYPE_HID = 0x00010000;
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEMOUSE_UNKNOWN = 1;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEMOUSE_TRADITIONAL = 2;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEMOUSE_FINGERSTICK = 3;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEMOUSE_TOUCHPAD = 4;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEMOUSE_TRACKBALL = 5;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEKEYBOARD_UNKNOWN = 0;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEKEYBOARD_PCXT = 1;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEKEYBOARD_OLIVETTI = 2;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEKEYBOARD_PCAT = 3;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEKEYBOARD_PCENH = 4;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEKEYBOARD_NOKIA1050 = 5;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEKEYBOARD_NOKIA9140 = 6;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEKEYBOARD_NEC98 = 7;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEKEYBOARD_NEC98LAPTOP = 8;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEKEYBOARD_NEC98106 = 9;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEKEYBOARD_JAPAN106 = 10;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEKEYBOARD_JAPANAX = 11;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEKEYBOARD_J3100 = 12;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEJOYSTICK_UNKNOWN = 1;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEJOYSTICK_TRADITIONAL = 2;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEJOYSTICK_FLIGHTSTICK = 3;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEJOYSTICK_GAMEPAD = 4;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEJOYSTICK_RUDDER = 5;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEJOYSTICK_WHEEL = 6;
#endif
#if DIRECTINPUT_VERSION <= 0x700
    public const int DIDEVTYPEJOYSTICK_HEADTRACKER = 7;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEMOUSE_UNKNOWN = 1;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEMOUSE_TRADITIONAL = 2;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEMOUSE_FINGERSTICK = 3;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEMOUSE_TOUCHPAD = 4;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEMOUSE_TRACKBALL = 5;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEMOUSE_ABSOLUTE = 6;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEKEYBOARD_UNKNOWN = 0;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEKEYBOARD_PCXT = 1;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEKEYBOARD_OLIVETTI = 2;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEKEYBOARD_PCAT = 3;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEKEYBOARD_PCENH = 4;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEKEYBOARD_NOKIA1050 = 5;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEKEYBOARD_NOKIA9140 = 6;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEKEYBOARD_NEC98 = 7;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEKEYBOARD_NEC98LAPTOP = 8;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEKEYBOARD_NEC98106 = 9;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEKEYBOARD_JAPAN106 = 10;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEKEYBOARD_JAPANAX = 11;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEKEYBOARD_J3100 = 12;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE_LIMITEDGAMESUBTYPE = 1;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEJOYSTICK_STANDARD = 2;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEGAMEPAD_STANDARD = 2;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEGAMEPAD_TILT = 3;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEDRIVING_COMBINEDPEDALS = 2;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEDRIVING_DUALPEDALS = 3;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEDRIVING_THREEPEDALS = 4;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEDRIVING_HANDHELD = 5;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEFLIGHT_STICK = 2;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEFLIGHT_YOKE = 3;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEFLIGHT_RC = 4;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE1STPERSON_UNKNOWN = 2;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE1STPERSON_SIXDOF = 3;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPE1STPERSON_SHOOTER = 4;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESCREENPTR_UNKNOWN = 2;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESCREENPTR_LIGHTGUN = 3;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESCREENPTR_LIGHTPEN = 4;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESCREENPTR_TOUCH = 5;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEREMOTE_UNKNOWN = 2;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEDEVICECTRL_UNKNOWN = 2;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEDEVICECTRL_COMMSSELECTION = 3;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPEDEVICECTRL_COMMSSELECTION_HARDWIRED = 4;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESUPPLEMENTAL_UNKNOWN = 2;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESUPPLEMENTAL_2NDHANDCONTROLLER = 3;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESUPPLEMENTAL_HEADTRACKER = 4;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESUPPLEMENTAL_HANDTRACKER = 5;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESUPPLEMENTAL_SHIFTSTICKGATE = 6;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESUPPLEMENTAL_SHIFTER = 7;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESUPPLEMENTAL_THROTTLE = 8;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESUPPLEMENTAL_SPLITTHROTTLE = 9;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESUPPLEMENTAL_COMBINEDPEDALS = 10;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESUPPLEMENTAL_DUALPEDALS = 11;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESUPPLEMENTAL_THREEPEDALS = 12;
#endif
#if ! (DIRECTINPUT_VERSION <= 0x700)
    public const int DI8DEVTYPESUPPLEMENTAL_RUDDERPEDALS = 13;
#endif
    public const int DIDC_ATTACHED = 0x00000001;
    public const int DIDC_POLLEDDEVICE = 0x00000002;
    public const int DIDC_EMULATED = 0x00000004;
    public const int DIDC_POLLEDDATAFORMAT = 0x00000008;
    public const int DIDC_FORCEFEEDBACK = 0x00000100;
    public const int DIDC_FFATTACK = 0x00000200;
    public const int DIDC_FFFADE = 0x00000400;
    public const int DIDC_SATURATION = 0x00000800;
    public const int DIDC_POSNEGCOEFFICIENTS = 0x00001000;
    public const int DIDC_POSNEGSATURATION = 0x00002000;
    public const int DIDC_DEADBAND = 0x00004000;
    public const int DIDC_STARTDELAY = 0x00008000;
    public const int DIDC_ALIAS = 0x00010000;
    public const int DIDC_PHANTOM = 0x00020000;
    public const int DIDC_HIDDEN = 0x00040000;
    public const int DIDFT_ALL = 0x00000000;
    public const int DIDFT_RELAXIS = 0x00000001;
    public const int DIDFT_ABSAXIS = 0x00000002;
    public const int DIDFT_AXIS = 0x00000003;
    public const int DIDFT_PSHBUTTON = 0x00000004;
    public const int DIDFT_TGLBUTTON = 0x00000008;
    public const int DIDFT_BUTTON = 0x0000000C;
    public const int DIDFT_POV = 0x00000010;
    public const int DIDFT_COLLECTION = 0x00000040;
    public const int DIDFT_NODATA = 0x00000080;
    public const int DIDFT_ANYINSTANCE = 0x00FFFF00;
    public const int DIDFT_FFACTUATOR = 0x01000000;
    public const int DIDFT_FFEFFECTTRIGGER = 0x02000000;
    public const int DIDFT_OUTPUT = 0x10000000;
    public const int DIDFT_VENDORDEFINED = 0x04000000;
    public const int DIDFT_ALIAS = 0x08000000;
    public const uint DIDFT_OPTIONAL = 0x80000000;
    public const int DIDFT_NOCOLLECTION = 0x00FFFF00;
#if ! DIJ_RINGZERO
    public const int DIDF_ABSAXIS = 0x00000001;
#endif
#if ! DIJ_RINGZERO
    public const int DIDF_RELAXIS = 0x00000002;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIA_FORCEFEEDBACK = 0x00000001;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIA_APPMAPPED = 0x00000002;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIA_APPNOMAP = 0x00000004;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIA_NORANGE = 0x00000008;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIA_APPFIXED = 0x00000010;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIAH_UNMAPPED = 0x00000000;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIAH_USERCONFIG = 0x00000001;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIAH_APPREQUESTED = 0x00000002;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIAH_HWAPP = 0x00000004;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIAH_HWDEFAULT = 0x00000008;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIAH_DEFAULT = 0x00000020;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const uint DIAH_ERROR = 0x80000000;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const uint DIAFTS_NEWDEVICELOW = 0xFFFFFFFF;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const uint DIAFTS_NEWDEVICEHIGH = 0xFFFFFFFF;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIAFTS_UNUSEDDEVICELOW = 0x00000000;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIAFTS_UNUSEDDEVICEHIGH = 0x00000000;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDBAM_DEFAULT = 0x00000000;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDBAM_PRESERVE = 0x00000001;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDBAM_INITIALIZE = 0x00000002;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDBAM_HWDEFAULTS = 0x00000004;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDSAM_DEFAULT = 0x00000000;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDSAM_NOUSER = 0x00000001;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDSAM_FORCESAVE = 0x00000002;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DICD_DEFAULT = 0x00000000;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DICD_EDIT = 0x00000001;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDIFT_CONFIGURATION = 0x00000001;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDIFT_OVERLAY = 0x00000002;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDAL_CENTERED = 0x00000000;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDAL_LEFTALIGNED = 0x00000001;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDAL_RIGHTALIGNED = 0x00000002;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDAL_MIDDLE = 0x00000000;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDAL_TOPALIGNED = 0x00000004;
#endif
#if DIRECTINPUT_VERSION > 0x0700
    public const int DIDAL_BOTTOMALIGNED = 0x00000008;
#endif
    public const int DIDOI_FFACTUATOR = 0x00000001;
    public const int DIDOI_FFEFFECTTRIGGER = 0x00000002;
    public const int DIDOI_POLLED = 0x00008000;
    public const int DIDOI_ASPECTPOSITION = 0x00000100;
    public const int DIDOI_ASPECTVELOCITY = 0x00000200;
    public const int DIDOI_ASPECTACCEL = 0x00000300;
    public const int DIDOI_ASPECTFORCE = 0x00000400;
    public const int DIDOI_ASPECTMASK = 0x00000F00;
    public const int DIDOI_GUIDISUSAGE = 0x00010000;
    public const int DIPH_DEVICE = 0;
    public const int DIPH_BYOFFSET = 1;
    public const int DIPH_BYID = 2;
    public const int DIPH_BYUSAGE = 3;
    public const int MAXCPOINTSNUM = 8;
    public const int DIPROPAXISMODE_ABS = 0;
    public const int DIPROPAXISMODE_REL = 1;
    public const int DIPROPAUTOCENTER_OFF = 0;
    public const int DIPROPAUTOCENTER_ON = 1;
    public const int DIPROPCALIBRATIONMODE_COOKED = 0;
    public const int DIPROPCALIBRATIONMODE_RAW = 1;
    public const int DIGDD_PEEK = 0x00000001;
    public const int DISCL_EXCLUSIVE = 0x00000001;
    public const int DISCL_NONEXCLUSIVE = 0x00000002;
    public const int DISCL_FOREGROUND = 0x00000004;
    public const int DISCL_BACKGROUND = 0x00000008;
    public const int DISCL_NOWINKEY = 0x00000010;
    public const int DISFFC_RESET = 0x00000001;
    public const int DISFFC_STOPALL = 0x00000002;
    public const int DISFFC_PAUSE = 0x00000004;
    public const int DISFFC_CONTINUE = 0x00000008;
    public const int DISFFC_SETACTUATORSON = 0x00000010;
    public const int DISFFC_SETACTUATORSOFF = 0x00000020;
    public const int DIGFFS_EMPTY = 0x00000001;
    public const int DIGFFS_STOPPED = 0x00000002;
    public const int DIGFFS_PAUSED = 0x00000004;
    public const int DIGFFS_ACTUATORSON = 0x00000010;
    public const int DIGFFS_ACTUATORSOFF = 0x00000020;
    public const int DIGFFS_POWERON = 0x00000040;
    public const int DIGFFS_POWEROFF = 0x00000080;
    public const int DIGFFS_SAFETYSWITCHON = 0x00000100;
    public const int DIGFFS_SAFETYSWITCHOFF = 0x00000200;
    public const int DIGFFS_USERFFSWITCHON = 0x00000400;
    public const int DIGFFS_USERFFSWITCHOFF = 0x00000800;
    public const uint DIGFFS_DEVICELOST = 0x80000000;
#if ! DIJ_RINGZERO
    public const int DISDD_CONTINUE = 0x00000001;
#endif
    public const int DIFEF_DEFAULT = 0x00000000;
    public const int DIFEF_INCLUDENONSTANDARD = 0x00000001;
    public const int DIFEF_MODIFYIFNEEDED = 0x00000010;
#if ! DIJ_RINGZERO
    public const int DIK_ESCAPE = 0x01;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_1 = 0x02;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_2 = 0x03;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_3 = 0x04;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_4 = 0x05;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_5 = 0x06;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_6 = 0x07;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_7 = 0x08;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_8 = 0x09;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_9 = 0x0A;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_0 = 0x0B;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_MINUS = 0x0C; // - on main keyboard
#endif
#if ! DIJ_RINGZERO
    public const int DIK_EQUALS = 0x0D;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_BACK = 0x0E; // backspace
#endif
#if ! DIJ_RINGZERO
    public const int DIK_TAB = 0x0F;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_Q = 0x10;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_W = 0x11;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_E = 0x12;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_R = 0x13;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_T = 0x14;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_Y = 0x15;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_U = 0x16;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_I = 0x17;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_O = 0x18;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_P = 0x19;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_LBRACKET = 0x1A;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_RBRACKET = 0x1B;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_RETURN = 0x1C; // Enter on main keyboard
#endif
#if ! DIJ_RINGZERO
    public const int DIK_LCONTROL = 0x1D;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_A = 0x1E;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_S = 0x1F;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_D = 0x20;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F = 0x21;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_G = 0x22;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_H = 0x23;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_J = 0x24;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_K = 0x25;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_L = 0x26;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_SEMICOLON = 0x27;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_APOSTROPHE = 0x28;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_GRAVE = 0x29; // accent grave
#endif
#if ! DIJ_RINGZERO
    public const int DIK_LSHIFT = 0x2A;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_BACKSLASH = 0x2B;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_Z = 0x2C;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_X = 0x2D;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_C = 0x2E;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_V = 0x2F;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_B = 0x30;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_N = 0x31;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_M = 0x32;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_COMMA = 0x33;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_PERIOD = 0x34; // . on main keyboard
#endif
#if ! DIJ_RINGZERO
    public const int DIK_SLASH = 0x35; // / on main keyboard
#endif
#if ! DIJ_RINGZERO
    public const int DIK_RSHIFT = 0x36;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_MULTIPLY = 0x37; // * on numeric keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_LMENU = 0x38; // left Alt
#endif
#if ! DIJ_RINGZERO
    public const int DIK_SPACE = 0x39;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_CAPITAL = 0x3A;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F1 = 0x3B;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F2 = 0x3C;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F3 = 0x3D;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F4 = 0x3E;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F5 = 0x3F;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F6 = 0x40;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F7 = 0x41;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F8 = 0x42;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F9 = 0x43;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F10 = 0x44;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMLOCK = 0x45;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_SCROLL = 0x46; // Scroll Lock
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMPAD7 = 0x47;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMPAD8 = 0x48;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMPAD9 = 0x49;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_SUBTRACT = 0x4A; // - on numeric keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMPAD4 = 0x4B;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMPAD5 = 0x4C;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMPAD6 = 0x4D;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_ADD = 0x4E; // + on numeric keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMPAD1 = 0x4F;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMPAD2 = 0x50;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMPAD3 = 0x51;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMPAD0 = 0x52;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_DECIMAL = 0x53; // . on numeric keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_OEM_102 = 0x56; // <> or \| on RT 102-key keyboard (Non-U.S.)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F11 = 0x57;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F12 = 0x58;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F13 = 0x64; //                     (NEC PC98)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F14 = 0x65; //                     (NEC PC98)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_F15 = 0x66; //                     (NEC PC98)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_KANA = 0x70; // (Japanese keyboard)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_ABNT_C1 = 0x73; // /? on Brazilian keyboard
#endif
#if ! DIJ_RINGZERO
    public const int DIK_CONVERT = 0x79; // (Japanese keyboard)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NOCONVERT = 0x7B; // (Japanese keyboard)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_YEN = 0x7D; // (Japanese keyboard)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_ABNT_C2 = 0x7E; // Numpad . on Brazilian keyboard
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMPADEQUALS = 0x8D; // = on numeric keypad (NEC PC98)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_PREVTRACK = 0x90; // Previous Track (DIK_CIRCUMFLEX on Japanese keyboard)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_AT = 0x91; //                     (NEC PC98)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_COLON = 0x92; //                     (NEC PC98)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_UNDERLINE = 0x93; //                     (NEC PC98)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_KANJI = 0x94; // (Japanese keyboard)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_STOP = 0x95; //                     (NEC PC98)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_AX = 0x96; //                     (Japan AX)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_UNLABELED = 0x97; //                        (J3100)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NEXTTRACK = 0x99; // Next Track
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMPADENTER = 0x9C; // Enter on numeric keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_RCONTROL = 0x9D;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_MUTE = 0xA0; // Mute
#endif
#if ! DIJ_RINGZERO
    public const int DIK_CALCULATOR = 0xA1; // Calculator
#endif
#if ! DIJ_RINGZERO
    public const int DIK_PLAYPAUSE = 0xA2; // Play / Pause
#endif
#if ! DIJ_RINGZERO
    public const int DIK_MEDIASTOP = 0xA4; // Media Stop
#endif
#if ! DIJ_RINGZERO
    public const int DIK_VOLUMEDOWN = 0xAE; // Volume -
#endif
#if ! DIJ_RINGZERO
    public const int DIK_VOLUMEUP = 0xB0; // Volume +
#endif
#if ! DIJ_RINGZERO
    public const int DIK_WEBHOME = 0xB2; // Web home
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NUMPADCOMMA = 0xB3; // , on numeric keypad (NEC PC98)
#endif
#if ! DIJ_RINGZERO
    public const int DIK_DIVIDE = 0xB5; // / on numeric keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_SYSRQ = 0xB7;
#endif
#if ! DIJ_RINGZERO
    public const int DIK_RMENU = 0xB8; // right Alt
#endif
#if ! DIJ_RINGZERO
    public const int DIK_PAUSE = 0xC5; // Pause
#endif
#if ! DIJ_RINGZERO
    public const int DIK_HOME = 0xC7; // Home on arrow keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_UP = 0xC8; // UpArrow on arrow keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_PRIOR = 0xC9; // PgUp on arrow keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_LEFT = 0xCB; // LeftArrow on arrow keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_RIGHT = 0xCD; // RightArrow on arrow keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_END = 0xCF; // End on arrow keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_DOWN = 0xD0; // DownArrow on arrow keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_NEXT = 0xD1; // PgDn on arrow keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_INSERT = 0xD2; // Insert on arrow keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_DELETE = 0xD3; // Delete on arrow keypad
#endif
#if ! DIJ_RINGZERO
    public const int DIK_LWIN = 0xDB; // Left Windows key
#endif
#if ! DIJ_RINGZERO
    public const int DIK_RWIN = 0xDC; // Right Windows key
#endif
#if ! DIJ_RINGZERO
    public const int DIK_APPS = 0xDD; // AppMenu key
#endif
#if ! DIJ_RINGZERO
    public const int DIK_POWER = 0xDE; // System Power
#endif
#if ! DIJ_RINGZERO
    public const int DIK_SLEEP = 0xDF; // System Sleep
#endif
#if ! DIJ_RINGZERO
    public const int DIK_WAKE = 0xE3; // System Wake
#endif
#if ! DIJ_RINGZERO
    public const int DIK_WEBSEARCH = 0xE5; // Web Search
#endif
#if ! DIJ_RINGZERO
    public const int DIK_WEBFAVORITES = 0xE6; // Web Favorites
#endif
#if ! DIJ_RINGZERO
    public const int DIK_WEBREFRESH = 0xE7; // Web Refresh
#endif
#if ! DIJ_RINGZERO
    public const int DIK_WEBSTOP = 0xE8; // Web Stop
#endif
#if ! DIJ_RINGZERO
    public const int DIK_WEBFORWARD = 0xE9; // Web Forward
#endif
#if ! DIJ_RINGZERO
    public const int DIK_WEBBACK = 0xEA; // Web Back
#endif
#if ! DIJ_RINGZERO
    public const int DIK_MYCOMPUTER = 0xEB; // My Computer
#endif
#if ! DIJ_RINGZERO
    public const int DIK_MAIL = 0xEC; // Mail
#endif
#if ! DIJ_RINGZERO
    public const int DIK_MEDIASELECT = 0xED; // Media Select
#endif
#if ! DIJ_RINGZERO
    public const int DIENUM_STOP = 0;
#endif
#if ! DIJ_RINGZERO
    public const int DIENUM_CONTINUE = 1;
#endif
#if ! DIJ_RINGZERO
    public const int DIEDFL_ALLDEVICES = 0x00000000;
#endif
#if ! DIJ_RINGZERO
    public const int DIEDFL_ATTACHEDONLY = 0x00000001;
#endif
#if ! DIJ_RINGZERO
    public const int DIEDFL_FORCEFEEDBACK = 0x00000100;
#endif
    public const int DIEDFL_INCLUDEALIASES = 0x00010000;
    public const int DIEDFL_INCLUDEPHANTOMS = 0x00020000;
    public const int DIEDFL_INCLUDEHIDDEN = 0x00040000;
    public const int DIEDBS_MAPPEDPRI1 = 0x00000001;
    public const int DIEDBS_MAPPEDPRI2 = 0x00000002;
    public const int DIEDBS_RECENTDEVICE = 0x00000010;
    public const int DIEDBS_NEWDEVICE = 0x00000020;
    public const int DIEDBSFL_ATTACHEDONLY = 0x00000000;
    public const int DIEDBSFL_THISUSER = 0x00000010;
    public const int DIEDBSFL_AVAILABLEDEVICES = 0x00001000;
    public const int DIEDBSFL_MULTIMICEKEYBOARDS = 0x00002000;
    public const int DIEDBSFL_NONGAMINGDEVICES = 0x00004000;
    public const int DIEDBSFL_VALID = 0x00007110;
    public const uint E_PENDING = 0x8000000A;
    public const uint DIERR_INSUFFICIENTPRIVS = 0x80040200;
    public const uint DIERR_DEVICEFULL = 0x80040201;
    public const uint DIERR_MOREDATA = 0x80040202;
    public const uint DIERR_NOTDOWNLOADED = 0x80040203;
    public const uint DIERR_HASEFFECTS = 0x80040204;
    public const uint DIERR_NOTEXCLUSIVEACQUIRED = 0x80040205;
    public const uint DIERR_INCOMPLETEEFFECT = 0x80040206;
    public const uint DIERR_NOTBUFFERED = 0x80040207;
    public const uint DIERR_EFFECTPLAYING = 0x80040208;
    public const uint DIERR_UNPLUGGED = 0x80040209;
    public const uint DIERR_REPORTFULL = 0x8004020A;
    public const uint DIERR_MAPFILEFAIL = 0x8004020B;
    public const uint DIKEYBOARD_ESCAPE = 0x81000401;
    public const uint DIKEYBOARD_1 = 0x81000402;
    public const uint DIKEYBOARD_2 = 0x81000403;
    public const uint DIKEYBOARD_3 = 0x81000404;
    public const uint DIKEYBOARD_4 = 0x81000405;
    public const uint DIKEYBOARD_5 = 0x81000406;
    public const uint DIKEYBOARD_6 = 0x81000407;
    public const uint DIKEYBOARD_7 = 0x81000408;
    public const uint DIKEYBOARD_8 = 0x81000409;
    public const uint DIKEYBOARD_9 = 0x8100040A;
    public const uint DIKEYBOARD_0 = 0x8100040B;
    public const uint DIKEYBOARD_MINUS = 0x8100040C; // - on main keyboard
    public const uint DIKEYBOARD_EQUALS = 0x8100040D;
    public const uint DIKEYBOARD_BACK = 0x8100040E; // backspace
    public const uint DIKEYBOARD_TAB = 0x8100040F;
    public const uint DIKEYBOARD_Q = 0x81000410;
    public const uint DIKEYBOARD_W = 0x81000411;
    public const uint DIKEYBOARD_E = 0x81000412;
    public const uint DIKEYBOARD_R = 0x81000413;
    public const uint DIKEYBOARD_T = 0x81000414;
    public const uint DIKEYBOARD_Y = 0x81000415;
    public const uint DIKEYBOARD_U = 0x81000416;
    public const uint DIKEYBOARD_I = 0x81000417;
    public const uint DIKEYBOARD_O = 0x81000418;
    public const uint DIKEYBOARD_P = 0x81000419;
    public const uint DIKEYBOARD_LBRACKET = 0x8100041A;
    public const uint DIKEYBOARD_RBRACKET = 0x8100041B;
    public const uint DIKEYBOARD_RETURN = 0x8100041C; // Enter on main keyboard
    public const uint DIKEYBOARD_LCONTROL = 0x8100041D;
    public const uint DIKEYBOARD_A = 0x8100041E;
    public const uint DIKEYBOARD_S = 0x8100041F;
    public const uint DIKEYBOARD_D = 0x81000420;
    public const uint DIKEYBOARD_F = 0x81000421;
    public const uint DIKEYBOARD_G = 0x81000422;
    public const uint DIKEYBOARD_H = 0x81000423;
    public const uint DIKEYBOARD_J = 0x81000424;
    public const uint DIKEYBOARD_K = 0x81000425;
    public const uint DIKEYBOARD_L = 0x81000426;
    public const uint DIKEYBOARD_SEMICOLON = 0x81000427;
    public const uint DIKEYBOARD_APOSTROPHE = 0x81000428;
    public const uint DIKEYBOARD_GRAVE = 0x81000429; // accent grave
    public const uint DIKEYBOARD_LSHIFT = 0x8100042A;
    public const uint DIKEYBOARD_BACKSLASH = 0x8100042B;
    public const uint DIKEYBOARD_Z = 0x8100042C;
    public const uint DIKEYBOARD_X = 0x8100042D;
    public const uint DIKEYBOARD_C = 0x8100042E;
    public const uint DIKEYBOARD_V = 0x8100042F;
    public const uint DIKEYBOARD_B = 0x81000430;
    public const uint DIKEYBOARD_N = 0x81000431;
    public const uint DIKEYBOARD_M = 0x81000432;
    public const uint DIKEYBOARD_COMMA = 0x81000433;
    public const uint DIKEYBOARD_PERIOD = 0x81000434; // . on main keyboard
    public const uint DIKEYBOARD_SLASH = 0x81000435; // / on main keyboard
    public const uint DIKEYBOARD_RSHIFT = 0x81000436;
    public const uint DIKEYBOARD_MULTIPLY = 0x81000437; // * on numeric keypad
    public const uint DIKEYBOARD_LMENU = 0x81000438; // left Alt
    public const uint DIKEYBOARD_SPACE = 0x81000439;
    public const uint DIKEYBOARD_CAPITAL = 0x8100043A;
    public const uint DIKEYBOARD_F1 = 0x8100043B;
    public const uint DIKEYBOARD_F2 = 0x8100043C;
    public const uint DIKEYBOARD_F3 = 0x8100043D;
    public const uint DIKEYBOARD_F4 = 0x8100043E;
    public const uint DIKEYBOARD_F5 = 0x8100043F;
    public const uint DIKEYBOARD_F6 = 0x81000440;
    public const uint DIKEYBOARD_F7 = 0x81000441;
    public const uint DIKEYBOARD_F8 = 0x81000442;
    public const uint DIKEYBOARD_F9 = 0x81000443;
    public const uint DIKEYBOARD_F10 = 0x81000444;
    public const uint DIKEYBOARD_NUMLOCK = 0x81000445;
    public const uint DIKEYBOARD_SCROLL = 0x81000446; // Scroll Lock
    public const uint DIKEYBOARD_NUMPAD7 = 0x81000447;
    public const uint DIKEYBOARD_NUMPAD8 = 0x81000448;
    public const uint DIKEYBOARD_NUMPAD9 = 0x81000449;
    public const uint DIKEYBOARD_SUBTRACT = 0x8100044A; // - on numeric keypad
    public const uint DIKEYBOARD_NUMPAD4 = 0x8100044B;
    public const uint DIKEYBOARD_NUMPAD5 = 0x8100044C;
    public const uint DIKEYBOARD_NUMPAD6 = 0x8100044D;
    public const uint DIKEYBOARD_ADD = 0x8100044E; // + on numeric keypad
    public const uint DIKEYBOARD_NUMPAD1 = 0x8100044F;
    public const uint DIKEYBOARD_NUMPAD2 = 0x81000450;
    public const uint DIKEYBOARD_NUMPAD3 = 0x81000451;
    public const uint DIKEYBOARD_NUMPAD0 = 0x81000452;
    public const uint DIKEYBOARD_DECIMAL = 0x81000453; // . on numeric keypad
    public const uint DIKEYBOARD_OEM_102 = 0x81000456; // <> or \| on RT 102-key keyboard (Non-U.S.)
    public const uint DIKEYBOARD_F11 = 0x81000457;
    public const uint DIKEYBOARD_F12 = 0x81000458;
    public const uint DIKEYBOARD_F13 = 0x81000464; //                     (NEC PC98)
    public const uint DIKEYBOARD_F14 = 0x81000465; //                     (NEC PC98)
    public const uint DIKEYBOARD_F15 = 0x81000466; //                     (NEC PC98)
    public const uint DIKEYBOARD_KANA = 0x81000470; // (Japanese keyboard)
    public const uint DIKEYBOARD_ABNT_C1 = 0x81000473; // /? on Brazilian keyboard
    public const uint DIKEYBOARD_CONVERT = 0x81000479; // (Japanese keyboard)
    public const uint DIKEYBOARD_NOCONVERT = 0x8100047B; // (Japanese keyboard)
    public const uint DIKEYBOARD_YEN = 0x8100047D; // (Japanese keyboard)
    public const uint DIKEYBOARD_ABNT_C2 = 0x8100047E; // Numpad . on Brazilian keyboard
    public const uint DIKEYBOARD_NUMPADEQUALS = 0x8100048D; // = on numeric keypad (NEC PC98)
    public const uint DIKEYBOARD_PREVTRACK = 0x81000490; // Previous Track (DIK_CIRCUMFLEX on Japanese keyboard)
    public const uint DIKEYBOARD_AT = 0x81000491; //                     (NEC PC98)
    public const uint DIKEYBOARD_COLON = 0x81000492; //                     (NEC PC98)
    public const uint DIKEYBOARD_UNDERLINE = 0x81000493; //                     (NEC PC98)
    public const uint DIKEYBOARD_KANJI = 0x81000494; // (Japanese keyboard)
    public const uint DIKEYBOARD_STOP = 0x81000495; //                     (NEC PC98)
    public const uint DIKEYBOARD_AX = 0x81000496; //                     (Japan AX)
    public const uint DIKEYBOARD_UNLABELED = 0x81000497; //                        (J3100)
    public const uint DIKEYBOARD_NEXTTRACK = 0x81000499; // Next Track
    public const uint DIKEYBOARD_NUMPADENTER = 0x8100049C; // Enter on numeric keypad
    public const uint DIKEYBOARD_RCONTROL = 0x8100049D;
    public const uint DIKEYBOARD_MUTE = 0x810004A0; // Mute
    public const uint DIKEYBOARD_CALCULATOR = 0x810004A1; // Calculator
    public const uint DIKEYBOARD_PLAYPAUSE = 0x810004A2; // Play / Pause
    public const uint DIKEYBOARD_MEDIASTOP = 0x810004A4; // Media Stop
    public const uint DIKEYBOARD_VOLUMEDOWN = 0x810004AE; // Volume -
    public const uint DIKEYBOARD_VOLUMEUP = 0x810004B0; // Volume +
    public const uint DIKEYBOARD_WEBHOME = 0x810004B2; // Web home
    public const uint DIKEYBOARD_NUMPADCOMMA = 0x810004B3; // , on numeric keypad (NEC PC98)
    public const uint DIKEYBOARD_DIVIDE = 0x810004B5; // / on numeric keypad
    public const uint DIKEYBOARD_SYSRQ = 0x810004B7;
    public const uint DIKEYBOARD_RMENU = 0x810004B8; // right Alt
    public const uint DIKEYBOARD_PAUSE = 0x810004C5; // Pause
    public const uint DIKEYBOARD_HOME = 0x810004C7; // Home on arrow keypad
    public const uint DIKEYBOARD_UP = 0x810004C8; // UpArrow on arrow keypad
    public const uint DIKEYBOARD_PRIOR = 0x810004C9; // PgUp on arrow keypad
    public const uint DIKEYBOARD_LEFT = 0x810004CB; // LeftArrow on arrow keypad
    public const uint DIKEYBOARD_RIGHT = 0x810004CD; // RightArrow on arrow keypad
    public const uint DIKEYBOARD_END = 0x810004CF; // End on arrow keypad
    public const uint DIKEYBOARD_DOWN = 0x810004D0; // DownArrow on arrow keypad
    public const uint DIKEYBOARD_NEXT = 0x810004D1; // PgDn on arrow keypad
    public const uint DIKEYBOARD_INSERT = 0x810004D2; // Insert on arrow keypad
    public const uint DIKEYBOARD_DELETE = 0x810004D3; // Delete on arrow keypad
    public const uint DIKEYBOARD_LWIN = 0x810004DB; // Left Windows key
    public const uint DIKEYBOARD_RWIN = 0x810004DC; // Right Windows key
    public const uint DIKEYBOARD_APPS = 0x810004DD; // AppMenu key
    public const uint DIKEYBOARD_POWER = 0x810004DE; // System Power
    public const uint DIKEYBOARD_SLEEP = 0x810004DF; // System Sleep
    public const uint DIKEYBOARD_WAKE = 0x810004E3; // System Wake
    public const uint DIKEYBOARD_WEBSEARCH = 0x810004E5; // Web Search
    public const uint DIKEYBOARD_WEBFAVORITES = 0x810004E6; // Web Favorites
    public const uint DIKEYBOARD_WEBREFRESH = 0x810004E7; // Web Refresh
    public const uint DIKEYBOARD_WEBSTOP = 0x810004E8; // Web Stop
    public const uint DIKEYBOARD_WEBFORWARD = 0x810004E9; // Web Forward
    public const uint DIKEYBOARD_WEBBACK = 0x810004EA; // Web Back
    public const uint DIKEYBOARD_MYCOMPUTER = 0x810004EB; // My Computer
    public const uint DIKEYBOARD_MAIL = 0x810004EC; // Mail
    public const uint DIKEYBOARD_MEDIASELECT = 0x810004ED; // Media Select
    public const uint DIVOICE_CHANNEL1 = 0x83000401;
    public const uint DIVOICE_CHANNEL2 = 0x83000402;
    public const uint DIVOICE_CHANNEL3 = 0x83000403;
    public const uint DIVOICE_CHANNEL4 = 0x83000404;
    public const uint DIVOICE_CHANNEL5 = 0x83000405;
    public const uint DIVOICE_CHANNEL6 = 0x83000406;
    public const uint DIVOICE_CHANNEL7 = 0x83000407;
    public const uint DIVOICE_CHANNEL8 = 0x83000408;
    public const uint DIVOICE_TEAM = 0x83000409;
    public const uint DIVOICE_ALL = 0x8300040A;
    public const uint DIVOICE_RECORDMUTE = 0x8300040B;
    public const uint DIVOICE_PLAYBACKMUTE = 0x8300040C;
    public const uint DIVOICE_TRANSMIT = 0x8300040D;
    public const uint DIVOICE_VOICECOMMAND = 0x83000410;
    public const int DIVIRTUAL_DRIVING_RACE = 0x01000000;
    public const int DIAXIS_DRIVINGR_STEER = 0x01008A01; // Steering
    public const int DIAXIS_DRIVINGR_ACCELERATE = 0x01039202; // Accelerate
    public const int DIAXIS_DRIVINGR_BRAKE = 0x01041203; // Brake-Axis
    public const int DIBUTTON_DRIVINGR_SHIFTUP = 0x01000C01; // Shift to next higher gear
    public const int DIBUTTON_DRIVINGR_SHIFTDOWN = 0x01000C02; // Shift to next lower gear
    public const int DIBUTTON_DRIVINGR_VIEW = 0x01001C03; // Cycle through view options
    public const int DIBUTTON_DRIVINGR_MENU = 0x010004FD; // Show menu options
    public const int DIAXIS_DRIVINGR_ACCEL_AND_BRAKE = 0x01014A04; // Some devices combine accelerate and brake in a single axis
    public const int DIHATSWITCH_DRIVINGR_GLANCE = 0x01004601; // Look around
    public const int DIBUTTON_DRIVINGR_BRAKE = 0x01004C04; // Brake-button
    public const int DIBUTTON_DRIVINGR_DASHBOARD = 0x01004405; // Select next dashboard option
    public const int DIBUTTON_DRIVINGR_AIDS = 0x01004406; // Driver correction aids
    public const int DIBUTTON_DRIVINGR_MAP = 0x01004407; // Display Driving Map
    public const int DIBUTTON_DRIVINGR_BOOST = 0x01004408; // Turbo Boost
    public const int DIBUTTON_DRIVINGR_PIT = 0x01004409; // Pit stop notification
    public const int DIBUTTON_DRIVINGR_ACCELERATE_LINK = 0x0103D4E0; // Fallback Accelerate button
    public const int DIBUTTON_DRIVINGR_STEER_LEFT_LINK = 0x0100CCE4; // Fallback Steer Left button
    public const int DIBUTTON_DRIVINGR_STEER_RIGHT_LINK = 0x0100CCEC; // Fallback Steer Right button
    public const int DIBUTTON_DRIVINGR_GLANCE_LEFT_LINK = 0x0107C4E4; // Fallback Glance Left button
    public const int DIBUTTON_DRIVINGR_GLANCE_RIGHT_LINK = 0x0107C4EC; // Fallback Glance Right button
    public const int DIBUTTON_DRIVINGR_DEVICE = 0x010044FE; // Show input device and controls
    public const int DIBUTTON_DRIVINGR_PAUSE = 0x010044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_DRIVING_COMBAT = 0x02000000;
    public const int DIAXIS_DRIVINGC_STEER = 0x02008A01; // Steering
    public const int DIAXIS_DRIVINGC_ACCELERATE = 0x02039202; // Accelerate
    public const int DIAXIS_DRIVINGC_BRAKE = 0x02041203; // Brake-axis
    public const int DIBUTTON_DRIVINGC_FIRE = 0x02000C01; // Fire
    public const int DIBUTTON_DRIVINGC_WEAPONS = 0x02000C02; // Select next weapon
    public const int DIBUTTON_DRIVINGC_TARGET = 0x02000C03; // Select next available target
    public const int DIBUTTON_DRIVINGC_MENU = 0x020004FD; // Show menu options
    public const int DIAXIS_DRIVINGC_ACCEL_AND_BRAKE = 0x02014A04; // Some devices combine accelerate and brake in a single axis
    public const int DIHATSWITCH_DRIVINGC_GLANCE = 0x02004601; // Look around
    public const int DIBUTTON_DRIVINGC_SHIFTUP = 0x02004C04; // Shift to next higher gear
    public const int DIBUTTON_DRIVINGC_SHIFTDOWN = 0x02004C05; // Shift to next lower gear
    public const int DIBUTTON_DRIVINGC_DASHBOARD = 0x02004406; // Select next dashboard option
    public const int DIBUTTON_DRIVINGC_AIDS = 0x02004407; // Driver correction aids
    public const int DIBUTTON_DRIVINGC_BRAKE = 0x02004C08; // Brake-button
    public const int DIBUTTON_DRIVINGC_FIRESECONDARY = 0x02004C09; // Alternative fire button
    public const int DIBUTTON_DRIVINGC_ACCELERATE_LINK = 0x0203D4E0; // Fallback Accelerate button
    public const int DIBUTTON_DRIVINGC_STEER_LEFT_LINK = 0x0200CCE4; // Fallback Steer Left button
    public const int DIBUTTON_DRIVINGC_STEER_RIGHT_LINK = 0x0200CCEC; // Fallback Steer Right button
    public const int DIBUTTON_DRIVINGC_GLANCE_LEFT_LINK = 0x0207C4E4; // Fallback Glance Left button
    public const int DIBUTTON_DRIVINGC_GLANCE_RIGHT_LINK = 0x0207C4EC; // Fallback Glance Right button
    public const int DIBUTTON_DRIVINGC_DEVICE = 0x020044FE; // Show input device and controls
    public const int DIBUTTON_DRIVINGC_PAUSE = 0x020044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_DRIVING_TANK = 0x03000000;
    public const int DIAXIS_DRIVINGT_STEER = 0x03008A01; // Turn tank left / right
    public const int DIAXIS_DRIVINGT_BARREL = 0x03010202; // Raise / lower barrel
    public const int DIAXIS_DRIVINGT_ACCELERATE = 0x03039203; // Accelerate
    public const int DIAXIS_DRIVINGT_ROTATE = 0x03020204; // Turn barrel left / right
    public const int DIBUTTON_DRIVINGT_FIRE = 0x03000C01; // Fire
    public const int DIBUTTON_DRIVINGT_WEAPONS = 0x03000C02; // Select next weapon
    public const int DIBUTTON_DRIVINGT_TARGET = 0x03000C03; // Selects next available target
    public const int DIBUTTON_DRIVINGT_MENU = 0x030004FD; // Show menu options
    public const int DIHATSWITCH_DRIVINGT_GLANCE = 0x03004601; // Look around
    public const int DIAXIS_DRIVINGT_BRAKE = 0x03045205; // Brake-axis
    public const int DIAXIS_DRIVINGT_ACCEL_AND_BRAKE = 0x03014A06; // Some devices combine accelerate and brake in a single axis
    public const int DIBUTTON_DRIVINGT_VIEW = 0x03005C04; // Cycle through view options
    public const int DIBUTTON_DRIVINGT_DASHBOARD = 0x03005C05; // Select next dashboard option
    public const int DIBUTTON_DRIVINGT_BRAKE = 0x03004C06; // Brake-button
    public const int DIBUTTON_DRIVINGT_FIRESECONDARY = 0x03004C07; // Alternative fire button
    public const int DIBUTTON_DRIVINGT_ACCELERATE_LINK = 0x0303D4E0; // Fallback Accelerate button
    public const int DIBUTTON_DRIVINGT_STEER_LEFT_LINK = 0x0300CCE4; // Fallback Steer Left button
    public const int DIBUTTON_DRIVINGT_STEER_RIGHT_LINK = 0x0300CCEC; // Fallback Steer Right button
    public const int DIBUTTON_DRIVINGT_BARREL_UP_LINK = 0x030144E0; // Fallback Barrel up button
    public const int DIBUTTON_DRIVINGT_BARREL_DOWN_LINK = 0x030144E8; // Fallback Barrel down button
    public const int DIBUTTON_DRIVINGT_ROTATE_LEFT_LINK = 0x030244E4; // Fallback Rotate left button
    public const int DIBUTTON_DRIVINGT_ROTATE_RIGHT_LINK = 0x030244EC; // Fallback Rotate right button
    public const int DIBUTTON_DRIVINGT_GLANCE_LEFT_LINK = 0x0307C4E4; // Fallback Glance Left button
    public const int DIBUTTON_DRIVINGT_GLANCE_RIGHT_LINK = 0x0307C4EC; // Fallback Glance Right button
    public const int DIBUTTON_DRIVINGT_DEVICE = 0x030044FE; // Show input device and controls
    public const int DIBUTTON_DRIVINGT_PAUSE = 0x030044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_FLYING_CIVILIAN = 0x04000000;
    public const int DIAXIS_FLYINGC_BANK = 0x04008A01; // Roll ship left / right
    public const int DIAXIS_FLYINGC_PITCH = 0x04010A02; // Nose up / down
    public const int DIAXIS_FLYINGC_THROTTLE = 0x04039203; // Throttle
    public const int DIBUTTON_FLYINGC_VIEW = 0x04002401; // Cycle through view options
    public const int DIBUTTON_FLYINGC_DISPLAY = 0x04002402; // Select next dashboard / heads up display option
    public const int DIBUTTON_FLYINGC_GEAR = 0x04002C03; // Gear up / down
    public const int DIBUTTON_FLYINGC_MENU = 0x040004FD; // Show menu options
    public const int DIHATSWITCH_FLYINGC_GLANCE = 0x04004601; // Look around
    public const int DIAXIS_FLYINGC_BRAKE = 0x04046A04; // Apply Brake
    public const int DIAXIS_FLYINGC_RUDDER = 0x04025205; // Yaw ship left/right
    public const int DIAXIS_FLYINGC_FLAPS = 0x04055A06; // Flaps
    public const int DIBUTTON_FLYINGC_FLAPSUP = 0x04006404; // Increment stepping up until fully retracted
    public const int DIBUTTON_FLYINGC_FLAPSDOWN = 0x04006405; // Decrement stepping down until fully extended
    public const int DIBUTTON_FLYINGC_BRAKE_LINK = 0x04046CE0; // Fallback brake button
    public const int DIBUTTON_FLYINGC_FASTER_LINK = 0x0403D4E0; // Fallback throttle up button
    public const int DIBUTTON_FLYINGC_SLOWER_LINK = 0x0403D4E8; // Fallback throttle down button
    public const int DIBUTTON_FLYINGC_GLANCE_LEFT_LINK = 0x0407C4E4; // Fallback Glance Left button
    public const int DIBUTTON_FLYINGC_GLANCE_RIGHT_LINK = 0x0407C4EC; // Fallback Glance Right button
    public const int DIBUTTON_FLYINGC_GLANCE_UP_LINK = 0x0407C4E0; // Fallback Glance Up button
    public const int DIBUTTON_FLYINGC_GLANCE_DOWN_LINK = 0x0407C4E8; // Fallback Glance Down button
    public const int DIBUTTON_FLYINGC_DEVICE = 0x040044FE; // Show input device and controls
    public const int DIBUTTON_FLYINGC_PAUSE = 0x040044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_FLYING_MILITARY = 0x05000000;
    public const int DIAXIS_FLYINGM_BANK = 0x05008A01; // Bank - Roll ship left / right
    public const int DIAXIS_FLYINGM_PITCH = 0x05010A02; // Pitch - Nose up / down
    public const int DIAXIS_FLYINGM_THROTTLE = 0x05039203; // Throttle - faster / slower
    public const int DIBUTTON_FLYINGM_FIRE = 0x05000C01; // Fire
    public const int DIBUTTON_FLYINGM_WEAPONS = 0x05000C02; // Select next weapon
    public const int DIBUTTON_FLYINGM_TARGET = 0x05000C03; // Selects next available target
    public const int DIBUTTON_FLYINGM_MENU = 0x050004FD; // Show menu options
    public const int DIHATSWITCH_FLYINGM_GLANCE = 0x05004601; // Look around
    public const int DIBUTTON_FLYINGM_COUNTER = 0x05005C04; // Activate counter measures
    public const int DIAXIS_FLYINGM_RUDDER = 0x05024A04; // Rudder - Yaw ship left/right
    public const int DIAXIS_FLYINGM_BRAKE = 0x05046205; // Brake-axis
    public const int DIBUTTON_FLYINGM_VIEW = 0x05006405; // Cycle through view options
    public const int DIBUTTON_FLYINGM_DISPLAY = 0x05006406; // Select next dashboard option
    public const int DIAXIS_FLYINGM_FLAPS = 0x05055206; // Flaps
    public const int DIBUTTON_FLYINGM_FLAPSUP = 0x05005407; // Increment stepping up until fully retracted
    public const int DIBUTTON_FLYINGM_FLAPSDOWN = 0x05005408; // Decrement stepping down until fully extended
    public const int DIBUTTON_FLYINGM_FIRESECONDARY = 0x05004C09; // Alternative fire button
    public const int DIBUTTON_FLYINGM_GEAR = 0x0500640A; // Gear up / down
    public const int DIBUTTON_FLYINGM_BRAKE_LINK = 0x050464E0; // Fallback brake button
    public const int DIBUTTON_FLYINGM_FASTER_LINK = 0x0503D4E0; // Fallback throttle up button
    public const int DIBUTTON_FLYINGM_SLOWER_LINK = 0x0503D4E8; // Fallback throttle down button
    public const int DIBUTTON_FLYINGM_GLANCE_LEFT_LINK = 0x0507C4E4; // Fallback Glance Left button
    public const int DIBUTTON_FLYINGM_GLANCE_RIGHT_LINK = 0x0507C4EC; // Fallback Glance Right button
    public const int DIBUTTON_FLYINGM_GLANCE_UP_LINK = 0x0507C4E0; // Fallback Glance Up button
    public const int DIBUTTON_FLYINGM_GLANCE_DOWN_LINK = 0x0507C4E8; // Fallback Glance Down button
    public const int DIBUTTON_FLYINGM_DEVICE = 0x050044FE; // Show input device and controls
    public const int DIBUTTON_FLYINGM_PAUSE = 0x050044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_FLYING_HELICOPTER = 0x06000000;
    public const int DIAXIS_FLYINGH_BANK = 0x06008A01; // Bank - Roll ship left / right
    public const int DIAXIS_FLYINGH_PITCH = 0x06010A02; // Pitch - Nose up / down
    public const int DIAXIS_FLYINGH_COLLECTIVE = 0x06018A03; // Collective - Blade pitch/power
    public const int DIBUTTON_FLYINGH_FIRE = 0x06001401; // Fire
    public const int DIBUTTON_FLYINGH_WEAPONS = 0x06001402; // Select next weapon
    public const int DIBUTTON_FLYINGH_TARGET = 0x06001403; // Selects next available target
    public const int DIBUTTON_FLYINGH_MENU = 0x060004FD; // Show menu options
    public const int DIHATSWITCH_FLYINGH_GLANCE = 0x06004601; // Look around
    public const int DIAXIS_FLYINGH_TORQUE = 0x06025A04; // Torque - Rotate ship around left / right axis
    public const int DIAXIS_FLYINGH_THROTTLE = 0x0603DA05; // Throttle
    public const int DIBUTTON_FLYINGH_COUNTER = 0x06005404; // Activate counter measures
    public const int DIBUTTON_FLYINGH_VIEW = 0x06006405; // Cycle through view options
    public const int DIBUTTON_FLYINGH_GEAR = 0x06006406; // Gear up / down
    public const int DIBUTTON_FLYINGH_FIRESECONDARY = 0x06004C07; // Alternative fire button
    public const int DIBUTTON_FLYINGH_FASTER_LINK = 0x0603DCE0; // Fallback throttle up button
    public const int DIBUTTON_FLYINGH_SLOWER_LINK = 0x0603DCE8; // Fallback throttle down button
    public const int DIBUTTON_FLYINGH_GLANCE_LEFT_LINK = 0x0607C4E4; // Fallback Glance Left button
    public const int DIBUTTON_FLYINGH_GLANCE_RIGHT_LINK = 0x0607C4EC; // Fallback Glance Right button
    public const int DIBUTTON_FLYINGH_GLANCE_UP_LINK = 0x0607C4E0; // Fallback Glance Up button
    public const int DIBUTTON_FLYINGH_GLANCE_DOWN_LINK = 0x0607C4E8; // Fallback Glance Down button
    public const int DIBUTTON_FLYINGH_DEVICE = 0x060044FE; // Show input device and controls
    public const int DIBUTTON_FLYINGH_PAUSE = 0x060044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPACESIM = 0x07000000;
    public const int DIAXIS_SPACESIM_LATERAL = 0x07008201; // Move ship left / right
    public const int DIAXIS_SPACESIM_MOVE = 0x07010202; // Move ship forward/backward
    public const int DIAXIS_SPACESIM_THROTTLE = 0x07038203; // Throttle - Engine speed
    public const int DIBUTTON_SPACESIM_FIRE = 0x07000401; // Fire
    public const int DIBUTTON_SPACESIM_WEAPONS = 0x07000402; // Select next weapon
    public const int DIBUTTON_SPACESIM_TARGET = 0x07000403; // Selects next available target
    public const int DIBUTTON_SPACESIM_MENU = 0x070004FD; // Show menu options
    public const int DIHATSWITCH_SPACESIM_GLANCE = 0x07004601; // Look around
    public const int DIAXIS_SPACESIM_CLIMB = 0x0701C204; // Climb - Pitch ship up/down
    public const int DIAXIS_SPACESIM_ROTATE = 0x07024205; // Rotate - Turn ship left/right
    public const int DIBUTTON_SPACESIM_VIEW = 0x07004404; // Cycle through view options
    public const int DIBUTTON_SPACESIM_DISPLAY = 0x07004405; // Select next dashboard / heads up display option
    public const int DIBUTTON_SPACESIM_RAISE = 0x07004406; // Raise ship while maintaining current pitch
    public const int DIBUTTON_SPACESIM_LOWER = 0x07004407; // Lower ship while maintaining current pitch
    public const int DIBUTTON_SPACESIM_GEAR = 0x07004408; // Gear up / down
    public const int DIBUTTON_SPACESIM_FIRESECONDARY = 0x07004409; // Alternative fire button
    public const int DIBUTTON_SPACESIM_LEFT_LINK = 0x0700C4E4; // Fallback move left button
    public const int DIBUTTON_SPACESIM_RIGHT_LINK = 0x0700C4EC; // Fallback move right button
    public const int DIBUTTON_SPACESIM_FORWARD_LINK = 0x070144E0; // Fallback move forward button
    public const int DIBUTTON_SPACESIM_BACKWARD_LINK = 0x070144E8; // Fallback move backwards button
    public const int DIBUTTON_SPACESIM_FASTER_LINK = 0x0703C4E0; // Fallback throttle up button
    public const int DIBUTTON_SPACESIM_SLOWER_LINK = 0x0703C4E8; // Fallback throttle down button
    public const int DIBUTTON_SPACESIM_TURN_LEFT_LINK = 0x070244E4; // Fallback turn left button
    public const int DIBUTTON_SPACESIM_TURN_RIGHT_LINK = 0x070244EC; // Fallback turn right button
    public const int DIBUTTON_SPACESIM_GLANCE_LEFT_LINK = 0x0707C4E4; // Fallback Glance Left button
    public const int DIBUTTON_SPACESIM_GLANCE_RIGHT_LINK = 0x0707C4EC; // Fallback Glance Right button
    public const int DIBUTTON_SPACESIM_GLANCE_UP_LINK = 0x0707C4E0; // Fallback Glance Up button
    public const int DIBUTTON_SPACESIM_GLANCE_DOWN_LINK = 0x0707C4E8; // Fallback Glance Down button
    public const int DIBUTTON_SPACESIM_DEVICE = 0x070044FE; // Show input device and controls
    public const int DIBUTTON_SPACESIM_PAUSE = 0x070044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_FIGHTING_HAND2HAND = 0x08000000;
    public const int DIAXIS_FIGHTINGH_LATERAL = 0x08008201; // Sidestep left/right
    public const int DIAXIS_FIGHTINGH_MOVE = 0x08010202; // Move forward/backward
    public const int DIBUTTON_FIGHTINGH_PUNCH = 0x08000401; // Punch
    public const int DIBUTTON_FIGHTINGH_KICK = 0x08000402; // Kick
    public const int DIBUTTON_FIGHTINGH_BLOCK = 0x08000403; // Block
    public const int DIBUTTON_FIGHTINGH_CROUCH = 0x08000404; // Crouch
    public const int DIBUTTON_FIGHTINGH_JUMP = 0x08000405; // Jump
    public const int DIBUTTON_FIGHTINGH_SPECIAL1 = 0x08000406; // Apply first special move
    public const int DIBUTTON_FIGHTINGH_SPECIAL2 = 0x08000407; // Apply second special move
    public const int DIBUTTON_FIGHTINGH_MENU = 0x080004FD; // Show menu options
    public const int DIBUTTON_FIGHTINGH_SELECT = 0x08004408; // Select special move
    public const int DIHATSWITCH_FIGHTINGH_SLIDE = 0x08004601; // Look around
    public const int DIBUTTON_FIGHTINGH_DISPLAY = 0x08004409; // Shows next on-screen display option
    public const int DIAXIS_FIGHTINGH_ROTATE = 0x08024203; // Rotate - Turn body left/right
    public const int DIBUTTON_FIGHTINGH_DODGE = 0x0800440A; // Dodge
    public const int DIBUTTON_FIGHTINGH_LEFT_LINK = 0x0800C4E4; // Fallback left sidestep button
    public const int DIBUTTON_FIGHTINGH_RIGHT_LINK = 0x0800C4EC; // Fallback right sidestep button
    public const int DIBUTTON_FIGHTINGH_FORWARD_LINK = 0x080144E0; // Fallback forward button
    public const int DIBUTTON_FIGHTINGH_BACKWARD_LINK = 0x080144E8; // Fallback backward button
    public const int DIBUTTON_FIGHTINGH_DEVICE = 0x080044FE; // Show input device and controls
    public const int DIBUTTON_FIGHTINGH_PAUSE = 0x080044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_FIGHTING_FPS = 0x09000000;
    public const int DIAXIS_FPS_ROTATE = 0x09008201; // Rotate character left/right
    public const int DIAXIS_FPS_MOVE = 0x09010202; // Move forward/backward
    public const int DIBUTTON_FPS_FIRE = 0x09000401; // Fire
    public const int DIBUTTON_FPS_WEAPONS = 0x09000402; // Select next weapon
    public const int DIBUTTON_FPS_APPLY = 0x09000403; // Use item
    public const int DIBUTTON_FPS_SELECT = 0x09000404; // Select next inventory item
    public const int DIBUTTON_FPS_CROUCH = 0x09000405; // Crouch/ climb down/ swim down
    public const int DIBUTTON_FPS_JUMP = 0x09000406; // Jump/ climb up/ swim up
    public const int DIAXIS_FPS_LOOKUPDOWN = 0x09018203; // Look up / down
    public const int DIBUTTON_FPS_STRAFE = 0x09000407; // Enable strafing while active
    public const int DIBUTTON_FPS_MENU = 0x090004FD; // Show menu options
    public const int DIHATSWITCH_FPS_GLANCE = 0x09004601; // Look around
    public const int DIBUTTON_FPS_DISPLAY = 0x09004408; // Shows next on-screen display option/ map
    public const int DIAXIS_FPS_SIDESTEP = 0x09024204; // Sidestep
    public const int DIBUTTON_FPS_DODGE = 0x09004409; // Dodge
    public const int DIBUTTON_FPS_GLANCEL = 0x0900440A; // Glance Left
    public const int DIBUTTON_FPS_GLANCER = 0x0900440B; // Glance Right
    public const int DIBUTTON_FPS_FIRESECONDARY = 0x0900440C; // Alternative fire button
    public const int DIBUTTON_FPS_ROTATE_LEFT_LINK = 0x0900C4E4; // Fallback rotate left button
    public const int DIBUTTON_FPS_ROTATE_RIGHT_LINK = 0x0900C4EC; // Fallback rotate right button
    public const int DIBUTTON_FPS_FORWARD_LINK = 0x090144E0; // Fallback forward button
    public const int DIBUTTON_FPS_BACKWARD_LINK = 0x090144E8; // Fallback backward button
    public const int DIBUTTON_FPS_GLANCE_UP_LINK = 0x0901C4E0; // Fallback look up button
    public const int DIBUTTON_FPS_GLANCE_DOWN_LINK = 0x0901C4E8; // Fallback look down button
    public const int DIBUTTON_FPS_STEP_LEFT_LINK = 0x090244E4; // Fallback step left button
    public const int DIBUTTON_FPS_STEP_RIGHT_LINK = 0x090244EC; // Fallback step right button
    public const int DIBUTTON_FPS_DEVICE = 0x090044FE; // Show input device and controls
    public const int DIBUTTON_FPS_PAUSE = 0x090044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_FIGHTING_THIRDPERSON = 0x0A000000;
    public const int DIAXIS_TPS_TURN = 0x0A020201; // Turn left/right
    public const int DIAXIS_TPS_MOVE = 0x0A010202; // Move forward/backward
    public const int DIBUTTON_TPS_RUN = 0x0A000401; // Run or walk toggle switch
    public const int DIBUTTON_TPS_ACTION = 0x0A000402; // Action Button
    public const int DIBUTTON_TPS_SELECT = 0x0A000403; // Select next weapon
    public const int DIBUTTON_TPS_USE = 0x0A000404; // Use inventory item currently selected
    public const int DIBUTTON_TPS_JUMP = 0x0A000405; // Character Jumps
    public const int DIBUTTON_TPS_MENU = 0x0A0004FD; // Show menu options
    public const int DIHATSWITCH_TPS_GLANCE = 0x0A004601; // Look around
    public const int DIBUTTON_TPS_VIEW = 0x0A004406; // Select camera view
    public const int DIBUTTON_TPS_STEPLEFT = 0x0A004407; // Character takes a left step
    public const int DIBUTTON_TPS_STEPRIGHT = 0x0A004408; // Character takes a right step
    public const int DIAXIS_TPS_STEP = 0x0A00C203; // Character steps left/right
    public const int DIBUTTON_TPS_DODGE = 0x0A004409; // Character dodges or ducks
    public const int DIBUTTON_TPS_INVENTORY = 0x0A00440A; // Cycle through inventory
    public const int DIBUTTON_TPS_TURN_LEFT_LINK = 0x0A0244E4; // Fallback turn left button
    public const int DIBUTTON_TPS_TURN_RIGHT_LINK = 0x0A0244EC; // Fallback turn right button
    public const int DIBUTTON_TPS_FORWARD_LINK = 0x0A0144E0; // Fallback forward button
    public const int DIBUTTON_TPS_BACKWARD_LINK = 0x0A0144E8; // Fallback backward button
    public const int DIBUTTON_TPS_GLANCE_UP_LINK = 0x0A07C4E0; // Fallback look up button
    public const int DIBUTTON_TPS_GLANCE_DOWN_LINK = 0x0A07C4E8; // Fallback look down button
    public const int DIBUTTON_TPS_GLANCE_LEFT_LINK = 0x0A07C4E4; // Fallback glance up button
    public const int DIBUTTON_TPS_GLANCE_RIGHT_LINK = 0x0A07C4EC; // Fallback glance right button
    public const int DIBUTTON_TPS_DEVICE = 0x0A0044FE; // Show input device and controls
    public const int DIBUTTON_TPS_PAUSE = 0x0A0044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_STRATEGY_ROLEPLAYING = 0x0B000000;
    public const int DIAXIS_STRATEGYR_LATERAL = 0x0B008201; // sidestep - left/right
    public const int DIAXIS_STRATEGYR_MOVE = 0x0B010202; // move forward/backward
    public const int DIBUTTON_STRATEGYR_GET = 0x0B000401; // Acquire item
    public const int DIBUTTON_STRATEGYR_APPLY = 0x0B000402; // Use selected item
    public const int DIBUTTON_STRATEGYR_SELECT = 0x0B000403; // Select nextitem
    public const int DIBUTTON_STRATEGYR_ATTACK = 0x0B000404; // Attack
    public const int DIBUTTON_STRATEGYR_CAST = 0x0B000405; // Cast Spell
    public const int DIBUTTON_STRATEGYR_CROUCH = 0x0B000406; // Crouch
    public const int DIBUTTON_STRATEGYR_JUMP = 0x0B000407; // Jump
    public const int DIBUTTON_STRATEGYR_MENU = 0x0B0004FD; // Show menu options
    public const int DIHATSWITCH_STRATEGYR_GLANCE = 0x0B004601; // Look around
    public const int DIBUTTON_STRATEGYR_MAP = 0x0B004408; // Cycle through map options
    public const int DIBUTTON_STRATEGYR_DISPLAY = 0x0B004409; // Shows next on-screen display option
    public const int DIAXIS_STRATEGYR_ROTATE = 0x0B024203; // Turn body left/right
    public const int DIBUTTON_STRATEGYR_LEFT_LINK = 0x0B00C4E4; // Fallback sidestep left button
    public const int DIBUTTON_STRATEGYR_RIGHT_LINK = 0x0B00C4EC; // Fallback sidestep right button
    public const int DIBUTTON_STRATEGYR_FORWARD_LINK = 0x0B0144E0; // Fallback move forward button
    public const int DIBUTTON_STRATEGYR_BACK_LINK = 0x0B0144E8; // Fallback move backward button
    public const int DIBUTTON_STRATEGYR_ROTATE_LEFT_LINK = 0x0B0244E4; // Fallback turn body left button
    public const int DIBUTTON_STRATEGYR_ROTATE_RIGHT_LINK = 0x0B0244EC; // Fallback turn body right button
    public const int DIBUTTON_STRATEGYR_DEVICE = 0x0B0044FE; // Show input device and controls
    public const int DIBUTTON_STRATEGYR_PAUSE = 0x0B0044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_STRATEGY_TURN = 0x0C000000;
    public const int DIAXIS_STRATEGYT_LATERAL = 0x0C008201; // Sidestep left/right
    public const int DIAXIS_STRATEGYT_MOVE = 0x0C010202; // Move forward/backwards
    public const int DIBUTTON_STRATEGYT_SELECT = 0x0C000401; // Select unit or object
    public const int DIBUTTON_STRATEGYT_INSTRUCT = 0x0C000402; // Cycle through instructions
    public const int DIBUTTON_STRATEGYT_APPLY = 0x0C000403; // Apply selected instruction
    public const int DIBUTTON_STRATEGYT_TEAM = 0x0C000404; // Select next team / cycle through all
    public const int DIBUTTON_STRATEGYT_TURN = 0x0C000405; // Indicate turn over
    public const int DIBUTTON_STRATEGYT_MENU = 0x0C0004FD; // Show menu options
    public const int DIBUTTON_STRATEGYT_ZOOM = 0x0C004406; // Zoom - in / out
    public const int DIBUTTON_STRATEGYT_MAP = 0x0C004407; // cycle through map options
    public const int DIBUTTON_STRATEGYT_DISPLAY = 0x0C004408; // shows next on-screen display options
    public const int DIBUTTON_STRATEGYT_LEFT_LINK = 0x0C00C4E4; // Fallback sidestep left button
    public const int DIBUTTON_STRATEGYT_RIGHT_LINK = 0x0C00C4EC; // Fallback sidestep right button
    public const int DIBUTTON_STRATEGYT_FORWARD_LINK = 0x0C0144E0; // Fallback move forward button
    public const int DIBUTTON_STRATEGYT_BACK_LINK = 0x0C0144E8; // Fallback move back button
    public const int DIBUTTON_STRATEGYT_DEVICE = 0x0C0044FE; // Show input device and controls
    public const int DIBUTTON_STRATEGYT_PAUSE = 0x0C0044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_HUNTING = 0x0D000000;
    public const int DIAXIS_HUNTING_LATERAL = 0x0D008201; // sidestep left/right
    public const int DIAXIS_HUNTING_MOVE = 0x0D010202; // move forward/backwards
    public const int DIBUTTON_HUNTING_FIRE = 0x0D000401; // Fire selected weapon
    public const int DIBUTTON_HUNTING_AIM = 0x0D000402; // Select aim/move
    public const int DIBUTTON_HUNTING_WEAPON = 0x0D000403; // Select next weapon
    public const int DIBUTTON_HUNTING_BINOCULAR = 0x0D000404; // Look through Binoculars
    public const int DIBUTTON_HUNTING_CALL = 0x0D000405; // Make animal call
    public const int DIBUTTON_HUNTING_MAP = 0x0D000406; // View Map
    public const int DIBUTTON_HUNTING_SPECIAL = 0x0D000407; // Special game operation
    public const int DIBUTTON_HUNTING_MENU = 0x0D0004FD; // Show menu options
    public const int DIHATSWITCH_HUNTING_GLANCE = 0x0D004601; // Look around
    public const int DIBUTTON_HUNTING_DISPLAY = 0x0D004408; // show next on-screen display option
    public const int DIAXIS_HUNTING_ROTATE = 0x0D024203; // Turn body left/right
    public const int DIBUTTON_HUNTING_CROUCH = 0x0D004409; // Crouch/ Climb / Swim down
    public const int DIBUTTON_HUNTING_JUMP = 0x0D00440A; // Jump/ Climb up / Swim up
    public const int DIBUTTON_HUNTING_FIRESECONDARY = 0x0D00440B; // Alternative fire button
    public const int DIBUTTON_HUNTING_LEFT_LINK = 0x0D00C4E4; // Fallback sidestep left button
    public const int DIBUTTON_HUNTING_RIGHT_LINK = 0x0D00C4EC; // Fallback sidestep right button
    public const int DIBUTTON_HUNTING_FORWARD_LINK = 0x0D0144E0; // Fallback move forward button
    public const int DIBUTTON_HUNTING_BACK_LINK = 0x0D0144E8; // Fallback move back button
    public const int DIBUTTON_HUNTING_ROTATE_LEFT_LINK = 0x0D0244E4; // Fallback turn body left button
    public const int DIBUTTON_HUNTING_ROTATE_RIGHT_LINK = 0x0D0244EC; // Fallback turn body right button
    public const int DIBUTTON_HUNTING_DEVICE = 0x0D0044FE; // Show input device and controls
    public const int DIBUTTON_HUNTING_PAUSE = 0x0D0044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_FISHING = 0x0E000000;
    public const int DIAXIS_FISHING_LATERAL = 0x0E008201; // sidestep left/right
    public const int DIAXIS_FISHING_MOVE = 0x0E010202; // move forward/backwards
    public const int DIBUTTON_FISHING_CAST = 0x0E000401; // Cast line
    public const int DIBUTTON_FISHING_TYPE = 0x0E000402; // Select cast type
    public const int DIBUTTON_FISHING_BINOCULAR = 0x0E000403; // Look through Binocular
    public const int DIBUTTON_FISHING_BAIT = 0x0E000404; // Select type of Bait
    public const int DIBUTTON_FISHING_MAP = 0x0E000405; // View Map
    public const int DIBUTTON_FISHING_MENU = 0x0E0004FD; // Show menu options
    public const int DIHATSWITCH_FISHING_GLANCE = 0x0E004601; // Look around
    public const int DIBUTTON_FISHING_DISPLAY = 0x0E004406; // Show next on-screen display option
    public const int DIAXIS_FISHING_ROTATE = 0x0E024203; // Turn character left / right
    public const int DIBUTTON_FISHING_CROUCH = 0x0E004407; // Crouch/ Climb / Swim down
    public const int DIBUTTON_FISHING_JUMP = 0x0E004408; // Jump/ Climb up / Swim up
    public const int DIBUTTON_FISHING_LEFT_LINK = 0x0E00C4E4; // Fallback sidestep left button
    public const int DIBUTTON_FISHING_RIGHT_LINK = 0x0E00C4EC; // Fallback sidestep right button
    public const int DIBUTTON_FISHING_FORWARD_LINK = 0x0E0144E0; // Fallback move forward button
    public const int DIBUTTON_FISHING_BACK_LINK = 0x0E0144E8; // Fallback move back button
    public const int DIBUTTON_FISHING_ROTATE_LEFT_LINK = 0x0E0244E4; // Fallback turn body left button
    public const int DIBUTTON_FISHING_ROTATE_RIGHT_LINK = 0x0E0244EC; // Fallback turn body right button
    public const int DIBUTTON_FISHING_DEVICE = 0x0E0044FE; // Show input device and controls
    public const int DIBUTTON_FISHING_PAUSE = 0x0E0044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_BASEBALL_BAT = 0x0F000000;
    public const int DIAXIS_BASEBALLB_LATERAL = 0x0F008201; // Aim left / right
    public const int DIAXIS_BASEBALLB_MOVE = 0x0F010202; // Aim up / down
    public const int DIBUTTON_BASEBALLB_SELECT = 0x0F000401; // cycle through swing options
    public const int DIBUTTON_BASEBALLB_NORMAL = 0x0F000402; // normal swing
    public const int DIBUTTON_BASEBALLB_POWER = 0x0F000403; // swing for the fence
    public const int DIBUTTON_BASEBALLB_BUNT = 0x0F000404; // bunt
    public const int DIBUTTON_BASEBALLB_STEAL = 0x0F000405; // Base runner attempts to steal a base
    public const int DIBUTTON_BASEBALLB_BURST = 0x0F000406; // Base runner invokes burst of speed
    public const int DIBUTTON_BASEBALLB_SLIDE = 0x0F000407; // Base runner slides into base
    public const int DIBUTTON_BASEBALLB_CONTACT = 0x0F000408; // Contact swing
    public const int DIBUTTON_BASEBALLB_MENU = 0x0F0004FD; // Show menu options
    public const int DIBUTTON_BASEBALLB_NOSTEAL = 0x0F004409; // Base runner goes back to a base
    public const int DIBUTTON_BASEBALLB_BOX = 0x0F00440A; // Enter or exit batting box
    public const int DIBUTTON_BASEBALLB_LEFT_LINK = 0x0F00C4E4; // Fallback sidestep left button
    public const int DIBUTTON_BASEBALLB_RIGHT_LINK = 0x0F00C4EC; // Fallback sidestep right button
    public const int DIBUTTON_BASEBALLB_FORWARD_LINK = 0x0F0144E0; // Fallback move forward button
    public const int DIBUTTON_BASEBALLB_BACK_LINK = 0x0F0144E8; // Fallback move back button
    public const int DIBUTTON_BASEBALLB_DEVICE = 0x0F0044FE; // Show input device and controls
    public const int DIBUTTON_BASEBALLB_PAUSE = 0x0F0044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_BASEBALL_PITCH = 0x10000000;
    public const int DIAXIS_BASEBALLP_LATERAL = 0x10008201; // Aim left / right
    public const int DIAXIS_BASEBALLP_MOVE = 0x10010202; // Aim up / down
    public const int DIBUTTON_BASEBALLP_SELECT = 0x10000401; // cycle through pitch selections
    public const int DIBUTTON_BASEBALLP_PITCH = 0x10000402; // throw pitch
    public const int DIBUTTON_BASEBALLP_BASE = 0x10000403; // select base to throw to
    public const int DIBUTTON_BASEBALLP_THROW = 0x10000404; // throw to base
    public const int DIBUTTON_BASEBALLP_FAKE = 0x10000405; // Fake a throw to a base
    public const int DIBUTTON_BASEBALLP_MENU = 0x100004FD; // Show menu options
    public const int DIBUTTON_BASEBALLP_WALK = 0x10004406; // Throw intentional walk / pitch out
    public const int DIBUTTON_BASEBALLP_LOOK = 0x10004407; // Look at runners on bases
    public const int DIBUTTON_BASEBALLP_LEFT_LINK = 0x1000C4E4; // Fallback sidestep left button
    public const int DIBUTTON_BASEBALLP_RIGHT_LINK = 0x1000C4EC; // Fallback sidestep right button
    public const int DIBUTTON_BASEBALLP_FORWARD_LINK = 0x100144E0; // Fallback move forward button
    public const int DIBUTTON_BASEBALLP_BACK_LINK = 0x100144E8; // Fallback move back button
    public const int DIBUTTON_BASEBALLP_DEVICE = 0x100044FE; // Show input device and controls
    public const int DIBUTTON_BASEBALLP_PAUSE = 0x100044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_BASEBALL_FIELD = 0x11000000;
    public const int DIAXIS_BASEBALLF_LATERAL = 0x11008201; // Aim left / right
    public const int DIAXIS_BASEBALLF_MOVE = 0x11010202; // Aim up / down
    public const int DIBUTTON_BASEBALLF_NEAREST = 0x11000401; // Switch to fielder nearest to the ball
    public const int DIBUTTON_BASEBALLF_THROW1 = 0x11000402; // Make conservative throw
    public const int DIBUTTON_BASEBALLF_THROW2 = 0x11000403; // Make aggressive throw
    public const int DIBUTTON_BASEBALLF_BURST = 0x11000404; // Invoke burst of speed
    public const int DIBUTTON_BASEBALLF_JUMP = 0x11000405; // Jump to catch ball
    public const int DIBUTTON_BASEBALLF_DIVE = 0x11000406; // Dive to catch ball
    public const int DIBUTTON_BASEBALLF_MENU = 0x110004FD; // Show menu options
    public const int DIBUTTON_BASEBALLF_SHIFTIN = 0x11004407; // Shift the infield positioning
    public const int DIBUTTON_BASEBALLF_SHIFTOUT = 0x11004408; // Shift the outfield positioning
    public const int DIBUTTON_BASEBALLF_AIM_LEFT_LINK = 0x1100C4E4; // Fallback aim left button
    public const int DIBUTTON_BASEBALLF_AIM_RIGHT_LINK = 0x1100C4EC; // Fallback aim right button
    public const int DIBUTTON_BASEBALLF_FORWARD_LINK = 0x110144E0; // Fallback move forward button
    public const int DIBUTTON_BASEBALLF_BACK_LINK = 0x110144E8; // Fallback move back button
    public const int DIBUTTON_BASEBALLF_DEVICE = 0x110044FE; // Show input device and controls
    public const int DIBUTTON_BASEBALLF_PAUSE = 0x110044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_BASKETBALL_OFFENSE = 0x12000000;
    public const int DIAXIS_BBALLO_LATERAL = 0x12008201; // left / right
    public const int DIAXIS_BBALLO_MOVE = 0x12010202; // up / down
    public const int DIBUTTON_BBALLO_SHOOT = 0x12000401; // shoot basket
    public const int DIBUTTON_BBALLO_DUNK = 0x12000402; // dunk basket
    public const int DIBUTTON_BBALLO_PASS = 0x12000403; // throw pass
    public const int DIBUTTON_BBALLO_FAKE = 0x12000404; // fake shot or pass
    public const int DIBUTTON_BBALLO_SPECIAL = 0x12000405; // apply special move
    public const int DIBUTTON_BBALLO_PLAYER = 0x12000406; // select next player
    public const int DIBUTTON_BBALLO_BURST = 0x12000407; // invoke burst
    public const int DIBUTTON_BBALLO_CALL = 0x12000408; // call for ball / pass to me
    public const int DIBUTTON_BBALLO_MENU = 0x120004FD; // Show menu options
    public const int DIHATSWITCH_BBALLO_GLANCE = 0x12004601; // scroll view
    public const int DIBUTTON_BBALLO_SCREEN = 0x12004409; // Call for screen
    public const int DIBUTTON_BBALLO_PLAY = 0x1200440A; // Call for specific offensive play
    public const int DIBUTTON_BBALLO_JAB = 0x1200440B; // Initiate fake drive to basket
    public const int DIBUTTON_BBALLO_POST = 0x1200440C; // Perform post move
    public const int DIBUTTON_BBALLO_TIMEOUT = 0x1200440D; // Time Out
    public const int DIBUTTON_BBALLO_SUBSTITUTE = 0x1200440E; // substitute one player for another
    public const int DIBUTTON_BBALLO_LEFT_LINK = 0x1200C4E4; // Fallback sidestep left button
    public const int DIBUTTON_BBALLO_RIGHT_LINK = 0x1200C4EC; // Fallback sidestep right button
    public const int DIBUTTON_BBALLO_FORWARD_LINK = 0x120144E0; // Fallback move forward button
    public const int DIBUTTON_BBALLO_BACK_LINK = 0x120144E8; // Fallback move back button
    public const int DIBUTTON_BBALLO_DEVICE = 0x120044FE; // Show input device and controls
    public const int DIBUTTON_BBALLO_PAUSE = 0x120044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_BASKETBALL_DEFENSE = 0x13000000;
    public const int DIAXIS_BBALLD_LATERAL = 0x13008201; // left / right
    public const int DIAXIS_BBALLD_MOVE = 0x13010202; // up / down
    public const int DIBUTTON_BBALLD_JUMP = 0x13000401; // jump to block shot
    public const int DIBUTTON_BBALLD_STEAL = 0x13000402; // attempt to steal ball
    public const int DIBUTTON_BBALLD_FAKE = 0x13000403; // fake block or steal
    public const int DIBUTTON_BBALLD_SPECIAL = 0x13000404; // apply special move
    public const int DIBUTTON_BBALLD_PLAYER = 0x13000405; // select next player
    public const int DIBUTTON_BBALLD_BURST = 0x13000406; // invoke burst
    public const int DIBUTTON_BBALLD_PLAY = 0x13000407; // call for specific defensive play
    public const int DIBUTTON_BBALLD_MENU = 0x130004FD; // Show menu options
    public const int DIHATSWITCH_BBALLD_GLANCE = 0x13004601; // scroll view
    public const int DIBUTTON_BBALLD_TIMEOUT = 0x13004408; // Time Out
    public const int DIBUTTON_BBALLD_SUBSTITUTE = 0x13004409; // substitute one player for another
    public const int DIBUTTON_BBALLD_LEFT_LINK = 0x1300C4E4; // Fallback sidestep left button
    public const int DIBUTTON_BBALLD_RIGHT_LINK = 0x1300C4EC; // Fallback sidestep right button
    public const int DIBUTTON_BBALLD_FORWARD_LINK = 0x130144E0; // Fallback move forward button
    public const int DIBUTTON_BBALLD_BACK_LINK = 0x130144E8; // Fallback move back button
    public const int DIBUTTON_BBALLD_DEVICE = 0x130044FE; // Show input device and controls
    public const int DIBUTTON_BBALLD_PAUSE = 0x130044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_FOOTBALL_FIELD = 0x14000000;
    public const int DIBUTTON_FOOTBALLP_PLAY = 0x14000401; // cycle through available plays
    public const int DIBUTTON_FOOTBALLP_SELECT = 0x14000402; // select play
    public const int DIBUTTON_FOOTBALLP_HELP = 0x14000403; // Bring up pop-up help
    public const int DIBUTTON_FOOTBALLP_MENU = 0x140004FD; // Show menu options
    public const int DIBUTTON_FOOTBALLP_DEVICE = 0x140044FE; // Show input device and controls
    public const int DIBUTTON_FOOTBALLP_PAUSE = 0x140044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_FOOTBALL_QBCK = 0x15000000;
    public const int DIAXIS_FOOTBALLQ_LATERAL = 0x15008201; // Move / Aim: left / right
    public const int DIAXIS_FOOTBALLQ_MOVE = 0x15010202; // Move / Aim: up / down
    public const int DIBUTTON_FOOTBALLQ_SELECT = 0x15000401; // Select
    public const int DIBUTTON_FOOTBALLQ_SNAP = 0x15000402; // snap ball - start play
    public const int DIBUTTON_FOOTBALLQ_JUMP = 0x15000403; // jump over defender
    public const int DIBUTTON_FOOTBALLQ_SLIDE = 0x15000404; // Dive/Slide
    public const int DIBUTTON_FOOTBALLQ_PASS = 0x15000405; // throws pass to receiver
    public const int DIBUTTON_FOOTBALLQ_FAKE = 0x15000406; // pump fake pass or fake kick
    public const int DIBUTTON_FOOTBALLQ_MENU = 0x150004FD; // Show menu options
    public const int DIBUTTON_FOOTBALLQ_FAKESNAP = 0x15004407; // Fake snap
    public const int DIBUTTON_FOOTBALLQ_MOTION = 0x15004408; // Send receivers in motion
    public const int DIBUTTON_FOOTBALLQ_AUDIBLE = 0x15004409; // Change offensive play at line of scrimmage
    public const int DIBUTTON_FOOTBALLQ_LEFT_LINK = 0x1500C4E4; // Fallback sidestep left button
    public const int DIBUTTON_FOOTBALLQ_RIGHT_LINK = 0x1500C4EC; // Fallback sidestep right button
    public const int DIBUTTON_FOOTBALLQ_FORWARD_LINK = 0x150144E0; // Fallback move forward button
    public const int DIBUTTON_FOOTBALLQ_BACK_LINK = 0x150144E8; // Fallback move back button
    public const int DIBUTTON_FOOTBALLQ_DEVICE = 0x150044FE; // Show input device and controls
    public const int DIBUTTON_FOOTBALLQ_PAUSE = 0x150044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_FOOTBALL_OFFENSE = 0x16000000;
    public const int DIAXIS_FOOTBALLO_LATERAL = 0x16008201; // Move / Aim: left / right
    public const int DIAXIS_FOOTBALLO_MOVE = 0x16010202; // Move / Aim: up / down
    public const int DIBUTTON_FOOTBALLO_JUMP = 0x16000401; // jump or hurdle over defender
    public const int DIBUTTON_FOOTBALLO_LEFTARM = 0x16000402; // holds out left arm
    public const int DIBUTTON_FOOTBALLO_RIGHTARM = 0x16000403; // holds out right arm
    public const int DIBUTTON_FOOTBALLO_THROW = 0x16000404; // throw pass or lateral ball to another runner
    public const int DIBUTTON_FOOTBALLO_SPIN = 0x16000405; // Spin to avoid defenders
    public const int DIBUTTON_FOOTBALLO_MENU = 0x160004FD; // Show menu options
    public const int DIBUTTON_FOOTBALLO_JUKE = 0x16004406; // Use special move to avoid defenders
    public const int DIBUTTON_FOOTBALLO_SHOULDER = 0x16004407; // Lower shoulder to run over defenders
    public const int DIBUTTON_FOOTBALLO_TURBO = 0x16004408; // Speed burst past defenders
    public const int DIBUTTON_FOOTBALLO_DIVE = 0x16004409; // Dive over defenders
    public const int DIBUTTON_FOOTBALLO_ZOOM = 0x1600440A; // Zoom view in / out
    public const int DIBUTTON_FOOTBALLO_SUBSTITUTE = 0x1600440B; // substitute one player for another
    public const int DIBUTTON_FOOTBALLO_LEFT_LINK = 0x1600C4E4; // Fallback sidestep left button
    public const int DIBUTTON_FOOTBALLO_RIGHT_LINK = 0x1600C4EC; // Fallback sidestep right button
    public const int DIBUTTON_FOOTBALLO_FORWARD_LINK = 0x160144E0; // Fallback move forward button
    public const int DIBUTTON_FOOTBALLO_BACK_LINK = 0x160144E8; // Fallback move back button
    public const int DIBUTTON_FOOTBALLO_DEVICE = 0x160044FE; // Show input device and controls
    public const int DIBUTTON_FOOTBALLO_PAUSE = 0x160044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_FOOTBALL_DEFENSE = 0x17000000;
    public const int DIAXIS_FOOTBALLD_LATERAL = 0x17008201; // Move / Aim: left / right
    public const int DIAXIS_FOOTBALLD_MOVE = 0x17010202; // Move / Aim: up / down
    public const int DIBUTTON_FOOTBALLD_PLAY = 0x17000401; // cycle through available plays
    public const int DIBUTTON_FOOTBALLD_SELECT = 0x17000402; // select player closest to the ball
    public const int DIBUTTON_FOOTBALLD_JUMP = 0x17000403; // jump to intercept or block
    public const int DIBUTTON_FOOTBALLD_TACKLE = 0x17000404; // tackler runner
    public const int DIBUTTON_FOOTBALLD_FAKE = 0x17000405; // hold down to fake tackle or intercept
    public const int DIBUTTON_FOOTBALLD_SUPERTACKLE = 0x17000406; // Initiate special tackle
    public const int DIBUTTON_FOOTBALLD_MENU = 0x170004FD; // Show menu options
    public const int DIBUTTON_FOOTBALLD_SPIN = 0x17004407; // Spin to beat offensive line
    public const int DIBUTTON_FOOTBALLD_SWIM = 0x17004408; // Swim to beat the offensive line
    public const int DIBUTTON_FOOTBALLD_BULLRUSH = 0x17004409; // Bull rush the offensive line
    public const int DIBUTTON_FOOTBALLD_RIP = 0x1700440A; // Rip the offensive line
    public const int DIBUTTON_FOOTBALLD_AUDIBLE = 0x1700440B; // Change defensive play at the line of scrimmage
    public const int DIBUTTON_FOOTBALLD_ZOOM = 0x1700440C; // Zoom view in / out
    public const int DIBUTTON_FOOTBALLD_SUBSTITUTE = 0x1700440D; // substitute one player for another
    public const int DIBUTTON_FOOTBALLD_LEFT_LINK = 0x1700C4E4; // Fallback sidestep left button
    public const int DIBUTTON_FOOTBALLD_RIGHT_LINK = 0x1700C4EC; // Fallback sidestep right button
    public const int DIBUTTON_FOOTBALLD_FORWARD_LINK = 0x170144E0; // Fallback move forward button
    public const int DIBUTTON_FOOTBALLD_BACK_LINK = 0x170144E8; // Fallback move back button
    public const int DIBUTTON_FOOTBALLD_DEVICE = 0x170044FE; // Show input device and controls
    public const int DIBUTTON_FOOTBALLD_PAUSE = 0x170044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_GOLF = 0x18000000;
    public const int DIAXIS_GOLF_LATERAL = 0x18008201; // Move / Aim: left / right
    public const int DIAXIS_GOLF_MOVE = 0x18010202; // Move / Aim: up / down
    public const int DIBUTTON_GOLF_SWING = 0x18000401; // swing club
    public const int DIBUTTON_GOLF_SELECT = 0x18000402; // cycle between: club / swing strength / ball arc / ball spin
    public const int DIBUTTON_GOLF_UP = 0x18000403; // increase selection
    public const int DIBUTTON_GOLF_DOWN = 0x18000404; // decrease selection
    public const int DIBUTTON_GOLF_TERRAIN = 0x18000405; // shows terrain detail
    public const int DIBUTTON_GOLF_FLYBY = 0x18000406; // view the hole via a flyby
    public const int DIBUTTON_GOLF_MENU = 0x180004FD; // Show menu options
    public const int DIHATSWITCH_GOLF_SCROLL = 0x18004601; // scroll view
    public const int DIBUTTON_GOLF_ZOOM = 0x18004407; // Zoom view in / out
    public const int DIBUTTON_GOLF_TIMEOUT = 0x18004408; // Call for time out
    public const int DIBUTTON_GOLF_SUBSTITUTE = 0x18004409; // substitute one player for another
    public const int DIBUTTON_GOLF_LEFT_LINK = 0x1800C4E4; // Fallback sidestep left button
    public const int DIBUTTON_GOLF_RIGHT_LINK = 0x1800C4EC; // Fallback sidestep right button
    public const int DIBUTTON_GOLF_FORWARD_LINK = 0x180144E0; // Fallback move forward button
    public const int DIBUTTON_GOLF_BACK_LINK = 0x180144E8; // Fallback move back button
    public const int DIBUTTON_GOLF_DEVICE = 0x180044FE; // Show input device and controls
    public const int DIBUTTON_GOLF_PAUSE = 0x180044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_HOCKEY_OFFENSE = 0x19000000;
    public const int DIAXIS_HOCKEYO_LATERAL = 0x19008201; // Move / Aim: left / right
    public const int DIAXIS_HOCKEYO_MOVE = 0x19010202; // Move / Aim: up / down
    public const int DIBUTTON_HOCKEYO_SHOOT = 0x19000401; // Shoot
    public const int DIBUTTON_HOCKEYO_PASS = 0x19000402; // pass the puck
    public const int DIBUTTON_HOCKEYO_BURST = 0x19000403; // invoke speed burst
    public const int DIBUTTON_HOCKEYO_SPECIAL = 0x19000404; // invoke special move
    public const int DIBUTTON_HOCKEYO_FAKE = 0x19000405; // hold down to fake pass or kick
    public const int DIBUTTON_HOCKEYO_MENU = 0x190004FD; // Show menu options
    public const int DIHATSWITCH_HOCKEYO_SCROLL = 0x19004601; // scroll view
    public const int DIBUTTON_HOCKEYO_ZOOM = 0x19004406; // Zoom view in / out
    public const int DIBUTTON_HOCKEYO_STRATEGY = 0x19004407; // Invoke coaching menu for strategy help
    public const int DIBUTTON_HOCKEYO_TIMEOUT = 0x19004408; // Call for time out
    public const int DIBUTTON_HOCKEYO_SUBSTITUTE = 0x19004409; // substitute one player for another
    public const int DIBUTTON_HOCKEYO_LEFT_LINK = 0x1900C4E4; // Fallback sidestep left button
    public const int DIBUTTON_HOCKEYO_RIGHT_LINK = 0x1900C4EC; // Fallback sidestep right button
    public const int DIBUTTON_HOCKEYO_FORWARD_LINK = 0x190144E0; // Fallback move forward button
    public const int DIBUTTON_HOCKEYO_BACK_LINK = 0x190144E8; // Fallback move back button
    public const int DIBUTTON_HOCKEYO_DEVICE = 0x190044FE; // Show input device and controls
    public const int DIBUTTON_HOCKEYO_PAUSE = 0x190044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_HOCKEY_DEFENSE = 0x1A000000;
    public const int DIAXIS_HOCKEYD_LATERAL = 0x1A008201; // Move / Aim: left / right
    public const int DIAXIS_HOCKEYD_MOVE = 0x1A010202; // Move / Aim: up / down
    public const int DIBUTTON_HOCKEYD_PLAYER = 0x1A000401; // control player closest to the puck
    public const int DIBUTTON_HOCKEYD_STEAL = 0x1A000402; // attempt steal
    public const int DIBUTTON_HOCKEYD_BURST = 0x1A000403; // speed burst or body check
    public const int DIBUTTON_HOCKEYD_BLOCK = 0x1A000404; // block puck
    public const int DIBUTTON_HOCKEYD_FAKE = 0x1A000405; // hold down to fake tackle or intercept
    public const int DIBUTTON_HOCKEYD_MENU = 0x1A0004FD; // Show menu options
    public const int DIHATSWITCH_HOCKEYD_SCROLL = 0x1A004601; // scroll view
    public const int DIBUTTON_HOCKEYD_ZOOM = 0x1A004406; // Zoom view in / out
    public const int DIBUTTON_HOCKEYD_STRATEGY = 0x1A004407; // Invoke coaching menu for strategy help
    public const int DIBUTTON_HOCKEYD_TIMEOUT = 0x1A004408; // Call for time out
    public const int DIBUTTON_HOCKEYD_SUBSTITUTE = 0x1A004409; // substitute one player for another
    public const int DIBUTTON_HOCKEYD_LEFT_LINK = 0x1A00C4E4; // Fallback sidestep left button
    public const int DIBUTTON_HOCKEYD_RIGHT_LINK = 0x1A00C4EC; // Fallback sidestep right button
    public const int DIBUTTON_HOCKEYD_FORWARD_LINK = 0x1A0144E0; // Fallback move forward button
    public const int DIBUTTON_HOCKEYD_BACK_LINK = 0x1A0144E8; // Fallback move back button
    public const int DIBUTTON_HOCKEYD_DEVICE = 0x1A0044FE; // Show input device and controls
    public const int DIBUTTON_HOCKEYD_PAUSE = 0x1A0044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_HOCKEY_GOALIE = 0x1B000000;
    public const int DIAXIS_HOCKEYG_LATERAL = 0x1B008201; // Move / Aim: left / right
    public const int DIAXIS_HOCKEYG_MOVE = 0x1B010202; // Move / Aim: up / down
    public const int DIBUTTON_HOCKEYG_PASS = 0x1B000401; // pass puck
    public const int DIBUTTON_HOCKEYG_POKE = 0x1B000402; // poke / check / hack
    public const int DIBUTTON_HOCKEYG_STEAL = 0x1B000403; // attempt steal
    public const int DIBUTTON_HOCKEYG_BLOCK = 0x1B000404; // block puck
    public const int DIBUTTON_HOCKEYG_MENU = 0x1B0004FD; // Show menu options
    public const int DIHATSWITCH_HOCKEYG_SCROLL = 0x1B004601; // scroll view
    public const int DIBUTTON_HOCKEYG_ZOOM = 0x1B004405; // Zoom view in / out
    public const int DIBUTTON_HOCKEYG_STRATEGY = 0x1B004406; // Invoke coaching menu for strategy help
    public const int DIBUTTON_HOCKEYG_TIMEOUT = 0x1B004407; // Call for time out
    public const int DIBUTTON_HOCKEYG_SUBSTITUTE = 0x1B004408; // substitute one player for another
    public const int DIBUTTON_HOCKEYG_LEFT_LINK = 0x1B00C4E4; // Fallback sidestep left button
    public const int DIBUTTON_HOCKEYG_RIGHT_LINK = 0x1B00C4EC; // Fallback sidestep right button
    public const int DIBUTTON_HOCKEYG_FORWARD_LINK = 0x1B0144E0; // Fallback move forward button
    public const int DIBUTTON_HOCKEYG_BACK_LINK = 0x1B0144E8; // Fallback move back button
    public const int DIBUTTON_HOCKEYG_DEVICE = 0x1B0044FE; // Show input device and controls
    public const int DIBUTTON_HOCKEYG_PAUSE = 0x1B0044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_BIKING_MOUNTAIN = 0x1C000000;
    public const int DIAXIS_BIKINGM_TURN = 0x1C008201; // left / right
    public const int DIAXIS_BIKINGM_PEDAL = 0x1C010202; // Pedal faster / slower / brake
    public const int DIBUTTON_BIKINGM_JUMP = 0x1C000401; // jump over obstacle
    public const int DIBUTTON_BIKINGM_CAMERA = 0x1C000402; // switch camera view
    public const int DIBUTTON_BIKINGM_SPECIAL1 = 0x1C000403; // perform first special move
    public const int DIBUTTON_BIKINGM_SELECT = 0x1C000404; // Select
    public const int DIBUTTON_BIKINGM_SPECIAL2 = 0x1C000405; // perform second special move
    public const int DIBUTTON_BIKINGM_MENU = 0x1C0004FD; // Show menu options
    public const int DIHATSWITCH_BIKINGM_SCROLL = 0x1C004601; // scroll view
    public const int DIBUTTON_BIKINGM_ZOOM = 0x1C004406; // Zoom view in / out
    public const int DIAXIS_BIKINGM_BRAKE = 0x1C044203; // Brake axis
    public const int DIBUTTON_BIKINGM_LEFT_LINK = 0x1C00C4E4; // Fallback turn left button
    public const int DIBUTTON_BIKINGM_RIGHT_LINK = 0x1C00C4EC; // Fallback turn right button
    public const int DIBUTTON_BIKINGM_FASTER_LINK = 0x1C0144E0; // Fallback pedal faster button
    public const int DIBUTTON_BIKINGM_SLOWER_LINK = 0x1C0144E8; // Fallback pedal slower button
    public const int DIBUTTON_BIKINGM_BRAKE_BUTTON_LINK = 0x1C0444E8; // Fallback brake button
    public const int DIBUTTON_BIKINGM_DEVICE = 0x1C0044FE; // Show input device and controls
    public const int DIBUTTON_BIKINGM_PAUSE = 0x1C0044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_SKIING = 0x1D000000;
    public const int DIAXIS_SKIING_TURN = 0x1D008201; // left / right
    public const int DIAXIS_SKIING_SPEED = 0x1D010202; // faster / slower
    public const int DIBUTTON_SKIING_JUMP = 0x1D000401; // Jump
    public const int DIBUTTON_SKIING_CROUCH = 0x1D000402; // crouch down
    public const int DIBUTTON_SKIING_CAMERA = 0x1D000403; // switch camera view
    public const int DIBUTTON_SKIING_SPECIAL1 = 0x1D000404; // perform first special move
    public const int DIBUTTON_SKIING_SELECT = 0x1D000405; // Select
    public const int DIBUTTON_SKIING_SPECIAL2 = 0x1D000406; // perform second special move
    public const int DIBUTTON_SKIING_MENU = 0x1D0004FD; // Show menu options
    public const int DIHATSWITCH_SKIING_GLANCE = 0x1D004601; // scroll view
    public const int DIBUTTON_SKIING_ZOOM = 0x1D004407; // Zoom view in / out
    public const int DIBUTTON_SKIING_LEFT_LINK = 0x1D00C4E4; // Fallback turn left button
    public const int DIBUTTON_SKIING_RIGHT_LINK = 0x1D00C4EC; // Fallback turn right button
    public const int DIBUTTON_SKIING_FASTER_LINK = 0x1D0144E0; // Fallback increase speed button
    public const int DIBUTTON_SKIING_SLOWER_LINK = 0x1D0144E8; // Fallback decrease speed button
    public const int DIBUTTON_SKIING_DEVICE = 0x1D0044FE; // Show input device and controls
    public const int DIBUTTON_SKIING_PAUSE = 0x1D0044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_SOCCER_OFFENSE = 0x1E000000;
    public const int DIAXIS_SOCCERO_LATERAL = 0x1E008201; // Move / Aim: left / right
    public const int DIAXIS_SOCCERO_MOVE = 0x1E010202; // Move / Aim: up / down
    public const int DIAXIS_SOCCERO_BEND = 0x1E018203; // Bend to soccer shot/pass
    public const int DIBUTTON_SOCCERO_SHOOT = 0x1E000401; // Shoot the ball
    public const int DIBUTTON_SOCCERO_PASS = 0x1E000402; // Pass
    public const int DIBUTTON_SOCCERO_FAKE = 0x1E000403; // Fake
    public const int DIBUTTON_SOCCERO_PLAYER = 0x1E000404; // Select next player
    public const int DIBUTTON_SOCCERO_SPECIAL1 = 0x1E000405; // Apply special move
    public const int DIBUTTON_SOCCERO_SELECT = 0x1E000406; // Select special move
    public const int DIBUTTON_SOCCERO_MENU = 0x1E0004FD; // Show menu options
    public const int DIHATSWITCH_SOCCERO_GLANCE = 0x1E004601; // scroll view
    public const int DIBUTTON_SOCCERO_SUBSTITUTE = 0x1E004407; // Substitute one player for another
    public const int DIBUTTON_SOCCERO_SHOOTLOW = 0x1E004408; // Shoot the ball low
    public const int DIBUTTON_SOCCERO_SHOOTHIGH = 0x1E004409; // Shoot the ball high
    public const int DIBUTTON_SOCCERO_PASSTHRU = 0x1E00440A; // Make a thru pass
    public const int DIBUTTON_SOCCERO_SPRINT = 0x1E00440B; // Sprint / turbo boost
    public const int DIBUTTON_SOCCERO_CONTROL = 0x1E00440C; // Obtain control of the ball
    public const int DIBUTTON_SOCCERO_HEAD = 0x1E00440D; // Attempt to head the ball
    public const int DIBUTTON_SOCCERO_LEFT_LINK = 0x1E00C4E4; // Fallback sidestep left button
    public const int DIBUTTON_SOCCERO_RIGHT_LINK = 0x1E00C4EC; // Fallback sidestep right button
    public const int DIBUTTON_SOCCERO_FORWARD_LINK = 0x1E0144E0; // Fallback move forward button
    public const int DIBUTTON_SOCCERO_BACK_LINK = 0x1E0144E8; // Fallback move back button
    public const int DIBUTTON_SOCCERO_DEVICE = 0x1E0044FE; // Show input device and controls
    public const int DIBUTTON_SOCCERO_PAUSE = 0x1E0044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_SOCCER_DEFENSE = 0x1F000000;
    public const int DIAXIS_SOCCERD_LATERAL = 0x1F008201; // Move / Aim: left / right
    public const int DIAXIS_SOCCERD_MOVE = 0x1F010202; // Move / Aim: up / down
    public const int DIBUTTON_SOCCERD_BLOCK = 0x1F000401; // Attempt to block shot
    public const int DIBUTTON_SOCCERD_STEAL = 0x1F000402; // Attempt to steal ball
    public const int DIBUTTON_SOCCERD_FAKE = 0x1F000403; // Fake a block or a steal
    public const int DIBUTTON_SOCCERD_PLAYER = 0x1F000404; // Select next player
    public const int DIBUTTON_SOCCERD_SPECIAL = 0x1F000405; // Apply special move
    public const int DIBUTTON_SOCCERD_SELECT = 0x1F000406; // Select special move
    public const int DIBUTTON_SOCCERD_SLIDE = 0x1F000407; // Attempt a slide tackle
    public const int DIBUTTON_SOCCERD_MENU = 0x1F0004FD; // Show menu options
    public const int DIHATSWITCH_SOCCERD_GLANCE = 0x1F004601; // scroll view
    public const int DIBUTTON_SOCCERD_FOUL = 0x1F004408; // Initiate a foul / hard-foul
    public const int DIBUTTON_SOCCERD_HEAD = 0x1F004409; // Attempt a Header
    public const int DIBUTTON_SOCCERD_CLEAR = 0x1F00440A; // Attempt to clear the ball down the field
    public const int DIBUTTON_SOCCERD_GOALIECHARGE = 0x1F00440B; // Make the goalie charge out of the box
    public const int DIBUTTON_SOCCERD_SUBSTITUTE = 0x1F00440C; // Substitute one player for another
    public const int DIBUTTON_SOCCERD_LEFT_LINK = 0x1F00C4E4; // Fallback sidestep left button
    public const int DIBUTTON_SOCCERD_RIGHT_LINK = 0x1F00C4EC; // Fallback sidestep right button
    public const int DIBUTTON_SOCCERD_FORWARD_LINK = 0x1F0144E0; // Fallback move forward button
    public const int DIBUTTON_SOCCERD_BACK_LINK = 0x1F0144E8; // Fallback move back button
    public const int DIBUTTON_SOCCERD_DEVICE = 0x1F0044FE; // Show input device and controls
    public const int DIBUTTON_SOCCERD_PAUSE = 0x1F0044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_SPORTS_RACQUET = 0x20000000;
    public const int DIAXIS_RACQUET_LATERAL = 0x20008201; // Move / Aim: left / right
    public const int DIAXIS_RACQUET_MOVE = 0x20010202; // Move / Aim: up / down
    public const int DIBUTTON_RACQUET_SWING = 0x20000401; // Swing racquet
    public const int DIBUTTON_RACQUET_BACKSWING = 0x20000402; // Swing backhand
    public const int DIBUTTON_RACQUET_SMASH = 0x20000403; // Smash shot
    public const int DIBUTTON_RACQUET_SPECIAL = 0x20000404; // Special shot
    public const int DIBUTTON_RACQUET_SELECT = 0x20000405; // Select special shot
    public const int DIBUTTON_RACQUET_MENU = 0x200004FD; // Show menu options
    public const int DIHATSWITCH_RACQUET_GLANCE = 0x20004601; // scroll view
    public const int DIBUTTON_RACQUET_TIMEOUT = 0x20004406; // Call for time out
    public const int DIBUTTON_RACQUET_SUBSTITUTE = 0x20004407; // Substitute one player for another
    public const int DIBUTTON_RACQUET_LEFT_LINK = 0x2000C4E4; // Fallback sidestep left button
    public const int DIBUTTON_RACQUET_RIGHT_LINK = 0x2000C4EC; // Fallback sidestep right button
    public const int DIBUTTON_RACQUET_FORWARD_LINK = 0x200144E0; // Fallback move forward button
    public const int DIBUTTON_RACQUET_BACK_LINK = 0x200144E8; // Fallback move back button
    public const int DIBUTTON_RACQUET_DEVICE = 0x200044FE; // Show input device and controls
    public const int DIBUTTON_RACQUET_PAUSE = 0x200044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_ARCADE_SIDE2SIDE = 0x21000000;
    public const int DIAXIS_ARCADES_LATERAL = 0x21008201; // left / right
    public const int DIAXIS_ARCADES_MOVE = 0x21010202; // up / down
    public const int DIBUTTON_ARCADES_THROW = 0x21000401; // throw object
    public const int DIBUTTON_ARCADES_CARRY = 0x21000402; // carry object
    public const int DIBUTTON_ARCADES_ATTACK = 0x21000403; // attack
    public const int DIBUTTON_ARCADES_SPECIAL = 0x21000404; // apply special move
    public const int DIBUTTON_ARCADES_SELECT = 0x21000405; // select special move
    public const int DIBUTTON_ARCADES_MENU = 0x210004FD; // Show menu options
    public const int DIHATSWITCH_ARCADES_VIEW = 0x21004601; // scroll view left / right / up / down
    public const int DIBUTTON_ARCADES_LEFT_LINK = 0x2100C4E4; // Fallback sidestep left button
    public const int DIBUTTON_ARCADES_RIGHT_LINK = 0x2100C4EC; // Fallback sidestep right button
    public const int DIBUTTON_ARCADES_FORWARD_LINK = 0x210144E0; // Fallback move forward button
    public const int DIBUTTON_ARCADES_BACK_LINK = 0x210144E8; // Fallback move back button
    public const int DIBUTTON_ARCADES_VIEW_UP_LINK = 0x2107C4E0; // Fallback scroll view up button
    public const int DIBUTTON_ARCADES_VIEW_DOWN_LINK = 0x2107C4E8; // Fallback scroll view down button
    public const int DIBUTTON_ARCADES_VIEW_LEFT_LINK = 0x2107C4E4; // Fallback scroll view left button
    public const int DIBUTTON_ARCADES_VIEW_RIGHT_LINK = 0x2107C4EC; // Fallback scroll view right button
    public const int DIBUTTON_ARCADES_DEVICE = 0x210044FE; // Show input device and controls
    public const int DIBUTTON_ARCADES_PAUSE = 0x210044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_ARCADE_PLATFORM = 0x22000000;
    public const int DIAXIS_ARCADEP_LATERAL = 0x22008201; // Left / right
    public const int DIAXIS_ARCADEP_MOVE = 0x22010202; // Up / down
    public const int DIBUTTON_ARCADEP_JUMP = 0x22000401; // Jump
    public const int DIBUTTON_ARCADEP_FIRE = 0x22000402; // Fire
    public const int DIBUTTON_ARCADEP_CROUCH = 0x22000403; // Crouch
    public const int DIBUTTON_ARCADEP_SPECIAL = 0x22000404; // Apply special move
    public const int DIBUTTON_ARCADEP_SELECT = 0x22000405; // Select special move
    public const int DIBUTTON_ARCADEP_MENU = 0x220004FD; // Show menu options
    public const int DIHATSWITCH_ARCADEP_VIEW = 0x22004601; // Scroll view
    public const int DIBUTTON_ARCADEP_FIRESECONDARY = 0x22004406; // Alternative fire button
    public const int DIBUTTON_ARCADEP_LEFT_LINK = 0x2200C4E4; // Fallback sidestep left button
    public const int DIBUTTON_ARCADEP_RIGHT_LINK = 0x2200C4EC; // Fallback sidestep right button
    public const int DIBUTTON_ARCADEP_FORWARD_LINK = 0x220144E0; // Fallback move forward button
    public const int DIBUTTON_ARCADEP_BACK_LINK = 0x220144E8; // Fallback move back button
    public const int DIBUTTON_ARCADEP_VIEW_UP_LINK = 0x2207C4E0; // Fallback scroll view up button
    public const int DIBUTTON_ARCADEP_VIEW_DOWN_LINK = 0x2207C4E8; // Fallback scroll view down button
    public const int DIBUTTON_ARCADEP_VIEW_LEFT_LINK = 0x2207C4E4; // Fallback scroll view left button
    public const int DIBUTTON_ARCADEP_VIEW_RIGHT_LINK = 0x2207C4EC; // Fallback scroll view right button
    public const int DIBUTTON_ARCADEP_DEVICE = 0x220044FE; // Show input device and controls
    public const int DIBUTTON_ARCADEP_PAUSE = 0x220044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_CAD_2DCONTROL = 0x23000000;
    public const int DIAXIS_2DCONTROL_LATERAL = 0x23008201; // Move view left / right
    public const int DIAXIS_2DCONTROL_MOVE = 0x23010202; // Move view up / down
    public const int DIAXIS_2DCONTROL_INOUT = 0x23018203; // Zoom - in / out
    public const int DIBUTTON_2DCONTROL_SELECT = 0x23000401; // Select Object
    public const int DIBUTTON_2DCONTROL_SPECIAL1 = 0x23000402; // Do first special operation
    public const int DIBUTTON_2DCONTROL_SPECIAL = 0x23000403; // Select special operation
    public const int DIBUTTON_2DCONTROL_SPECIAL2 = 0x23000404; // Do second special operation
    public const int DIBUTTON_2DCONTROL_MENU = 0x230004FD; // Show menu options
    public const int DIHATSWITCH_2DCONTROL_HATSWITCH = 0x23004601; // Hat switch
    public const int DIAXIS_2DCONTROL_ROTATEZ = 0x23024204; // Rotate view clockwise / counterclockwise
    public const int DIBUTTON_2DCONTROL_DISPLAY = 0x23004405; // Shows next on-screen display options
    public const int DIBUTTON_2DCONTROL_DEVICE = 0x230044FE; // Show input device and controls
    public const int DIBUTTON_2DCONTROL_PAUSE = 0x230044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_CAD_3DCONTROL = 0x24000000;
    public const int DIAXIS_3DCONTROL_LATERAL = 0x24008201; // Move view left / right
    public const int DIAXIS_3DCONTROL_MOVE = 0x24010202; // Move view up / down
    public const int DIAXIS_3DCONTROL_INOUT = 0x24018203; // Zoom - in / out
    public const int DIBUTTON_3DCONTROL_SELECT = 0x24000401; // Select Object
    public const int DIBUTTON_3DCONTROL_SPECIAL1 = 0x24000402; // Do first special operation
    public const int DIBUTTON_3DCONTROL_SPECIAL = 0x24000403; // Select special operation
    public const int DIBUTTON_3DCONTROL_SPECIAL2 = 0x24000404; // Do second special operation
    public const int DIBUTTON_3DCONTROL_MENU = 0x240004FD; // Show menu options
    public const int DIHATSWITCH_3DCONTROL_HATSWITCH = 0x24004601; // Hat switch
    public const int DIAXIS_3DCONTROL_ROTATEX = 0x24034204; // Rotate view forward or up / backward or down
    public const int DIAXIS_3DCONTROL_ROTATEY = 0x2402C205; // Rotate view clockwise / counterclockwise
    public const int DIAXIS_3DCONTROL_ROTATEZ = 0x24024206; // Rotate view left / right
    public const int DIBUTTON_3DCONTROL_DISPLAY = 0x24004405; // Show next on-screen display options
    public const int DIBUTTON_3DCONTROL_DEVICE = 0x240044FE; // Show input device and controls
    public const int DIBUTTON_3DCONTROL_PAUSE = 0x240044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_CAD_FLYBY = 0x25000000;
    public const int DIAXIS_CADF_LATERAL = 0x25008201; // move view left / right
    public const int DIAXIS_CADF_MOVE = 0x25010202; // move view up / down
    public const int DIAXIS_CADF_INOUT = 0x25018203; // in / out
    public const int DIBUTTON_CADF_SELECT = 0x25000401; // Select Object
    public const int DIBUTTON_CADF_SPECIAL1 = 0x25000402; // do first special operation
    public const int DIBUTTON_CADF_SPECIAL = 0x25000403; // Select special operation
    public const int DIBUTTON_CADF_SPECIAL2 = 0x25000404; // do second special operation
    public const int DIBUTTON_CADF_MENU = 0x250004FD; // Show menu options
    public const int DIHATSWITCH_CADF_HATSWITCH = 0x25004601; // Hat switch
    public const int DIAXIS_CADF_ROTATEX = 0x25034204; // Rotate view forward or up / backward or down
    public const int DIAXIS_CADF_ROTATEY = 0x2502C205; // Rotate view clockwise / counterclockwise
    public const int DIAXIS_CADF_ROTATEZ = 0x25024206; // Rotate view left / right
    public const int DIBUTTON_CADF_DISPLAY = 0x25004405; // shows next on-screen display options
    public const int DIBUTTON_CADF_DEVICE = 0x250044FE; // Show input device and controls
    public const int DIBUTTON_CADF_PAUSE = 0x250044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_CAD_MODEL = 0x26000000;
    public const int DIAXIS_CADM_LATERAL = 0x26008201; // move view left / right
    public const int DIAXIS_CADM_MOVE = 0x26010202; // move view up / down
    public const int DIAXIS_CADM_INOUT = 0x26018203; // in / out
    public const int DIBUTTON_CADM_SELECT = 0x26000401; // Select Object
    public const int DIBUTTON_CADM_SPECIAL1 = 0x26000402; // do first special operation
    public const int DIBUTTON_CADM_SPECIAL = 0x26000403; // Select special operation
    public const int DIBUTTON_CADM_SPECIAL2 = 0x26000404; // do second special operation
    public const int DIBUTTON_CADM_MENU = 0x260004FD; // Show menu options
    public const int DIHATSWITCH_CADM_HATSWITCH = 0x26004601; // Hat switch
    public const int DIAXIS_CADM_ROTATEX = 0x26034204; // Rotate view forward or up / backward or down
    public const int DIAXIS_CADM_ROTATEY = 0x2602C205; // Rotate view clockwise / counterclockwise
    public const int DIAXIS_CADM_ROTATEZ = 0x26024206; // Rotate view left / right
    public const int DIBUTTON_CADM_DISPLAY = 0x26004405; // shows next on-screen display options
    public const int DIBUTTON_CADM_DEVICE = 0x260044FE; // Show input device and controls
    public const int DIBUTTON_CADM_PAUSE = 0x260044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_REMOTE_CONTROL = 0x27000000;
    public const int DIAXIS_REMOTE_SLIDER = 0x27050201; // Slider for adjustment: volume / color / bass / etc
    public const int DIBUTTON_REMOTE_MUTE = 0x27000401; // Set volume on current device to zero
    public const int DIBUTTON_REMOTE_SELECT = 0x27000402; // Next/previous: channel/ track / chapter / picture / station
    public const int DIBUTTON_REMOTE_PLAY = 0x27002403; // Start or pause entertainment on current device
    public const int DIBUTTON_REMOTE_CUE = 0x27002404; // Move through current media
    public const int DIBUTTON_REMOTE_REVIEW = 0x27002405; // Move through current media
    public const int DIBUTTON_REMOTE_CHANGE = 0x27002406; // Select next device
    public const int DIBUTTON_REMOTE_RECORD = 0x27002407; // Start recording the current media
    public const int DIBUTTON_REMOTE_MENU = 0x270004FD; // Show menu options
    public const int DIAXIS_REMOTE_SLIDER2 = 0x27054202; // Slider for adjustment: volume
    public const int DIBUTTON_REMOTE_TV = 0x27005C08; // Select TV
    public const int DIBUTTON_REMOTE_CABLE = 0x27005C09; // Select cable box
    public const int DIBUTTON_REMOTE_CD = 0x27005C0A; // Select CD player
    public const int DIBUTTON_REMOTE_VCR = 0x27005C0B; // Select VCR
    public const int DIBUTTON_REMOTE_TUNER = 0x27005C0C; // Select tuner
    public const int DIBUTTON_REMOTE_DVD = 0x27005C0D; // Select DVD player
    public const int DIBUTTON_REMOTE_ADJUST = 0x27005C0E; // Enter device adjustment menu
    public const int DIBUTTON_REMOTE_DIGIT0 = 0x2700540F; // Digit 0
    public const int DIBUTTON_REMOTE_DIGIT1 = 0x27005410; // Digit 1
    public const int DIBUTTON_REMOTE_DIGIT2 = 0x27005411; // Digit 2
    public const int DIBUTTON_REMOTE_DIGIT3 = 0x27005412; // Digit 3
    public const int DIBUTTON_REMOTE_DIGIT4 = 0x27005413; // Digit 4
    public const int DIBUTTON_REMOTE_DIGIT5 = 0x27005414; // Digit 5
    public const int DIBUTTON_REMOTE_DIGIT6 = 0x27005415; // Digit 6
    public const int DIBUTTON_REMOTE_DIGIT7 = 0x27005416; // Digit 7
    public const int DIBUTTON_REMOTE_DIGIT8 = 0x27005417; // Digit 8
    public const int DIBUTTON_REMOTE_DIGIT9 = 0x27005418; // Digit 9
    public const int DIBUTTON_REMOTE_DEVICE = 0x270044FE; // Show input device and controls
    public const int DIBUTTON_REMOTE_PAUSE = 0x270044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_BROWSER_CONTROL = 0x28000000;
    public const int DIAXIS_BROWSER_LATERAL = 0x28008201; // Move on screen pointer
    public const int DIAXIS_BROWSER_MOVE = 0x28010202; // Move on screen pointer
    public const int DIBUTTON_BROWSER_SELECT = 0x28000401; // Select current item
    public const int DIAXIS_BROWSER_VIEW = 0x28018203; // Move view up/down
    public const int DIBUTTON_BROWSER_REFRESH = 0x28000402; // Refresh
    public const int DIBUTTON_BROWSER_MENU = 0x280004FD; // Show menu options
    public const int DIBUTTON_BROWSER_SEARCH = 0x28004403; // Use search tool
    public const int DIBUTTON_BROWSER_STOP = 0x28004404; // Cease current update
    public const int DIBUTTON_BROWSER_HOME = 0x28004405; // Go directly to "home" location
    public const int DIBUTTON_BROWSER_FAVORITES = 0x28004406; // Mark current site as favorite
    public const int DIBUTTON_BROWSER_NEXT = 0x28004407; // Select Next page
    public const int DIBUTTON_BROWSER_PREVIOUS = 0x28004408; // Select Previous page
    public const int DIBUTTON_BROWSER_HISTORY = 0x28004409; // Show/Hide History
    public const int DIBUTTON_BROWSER_PRINT = 0x2800440A; // Print current page
    public const int DIBUTTON_BROWSER_DEVICE = 0x280044FE; // Show input device and controls
    public const int DIBUTTON_BROWSER_PAUSE = 0x280044FC; // Start / Pause / Restart game
    public const int DIVIRTUAL_DRIVING_MECHA = 0x29000000;
    public const int DIAXIS_MECHA_STEER = 0x29008201; // Turns mecha left/right
    public const int DIAXIS_MECHA_TORSO = 0x29010202; // Tilts torso forward/backward
    public const int DIAXIS_MECHA_ROTATE = 0x29020203; // Turns torso left/right
    public const int DIAXIS_MECHA_THROTTLE = 0x29038204; // Engine Speed
    public const int DIBUTTON_MECHA_FIRE = 0x29000401; // Fire
    public const int DIBUTTON_MECHA_WEAPONS = 0x29000402; // Select next weapon group
    public const int DIBUTTON_MECHA_TARGET = 0x29000403; // Select closest enemy available target
    public const int DIBUTTON_MECHA_REVERSE = 0x29000404; // Toggles throttle in/out of reverse
    public const int DIBUTTON_MECHA_ZOOM = 0x29000405; // Zoom in/out targeting reticule
    public const int DIBUTTON_MECHA_JUMP = 0x29000406; // Fires jump jets
    public const int DIBUTTON_MECHA_MENU = 0x290004FD; // Show menu options
    public const int DIBUTTON_MECHA_CENTER = 0x29004407; // Center torso to legs
    public const int DIHATSWITCH_MECHA_GLANCE = 0x29004601; // Look around
    public const int DIBUTTON_MECHA_VIEW = 0x29004408; // Cycle through view options
    public const int DIBUTTON_MECHA_FIRESECONDARY = 0x29004409; // Alternative fire button
    public const int DIBUTTON_MECHA_LEFT_LINK = 0x2900C4E4; // Fallback steer left button
    public const int DIBUTTON_MECHA_RIGHT_LINK = 0x2900C4EC; // Fallback steer right button
    public const int DIBUTTON_MECHA_FORWARD_LINK = 0x290144E0; // Fallback tilt torso forward button
    public const int DIBUTTON_MECHA_BACK_LINK = 0x290144E8; // Fallback tilt toroso backward button
    public const int DIBUTTON_MECHA_ROTATE_LEFT_LINK = 0x290244E4; // Fallback rotate toroso right button
    public const int DIBUTTON_MECHA_ROTATE_RIGHT_LINK = 0x290244EC; // Fallback rotate torso left button
    public const int DIBUTTON_MECHA_FASTER_LINK = 0x2903C4E0; // Fallback increase engine speed
    public const int DIBUTTON_MECHA_SLOWER_LINK = 0x2903C4E8; // Fallback decrease engine speed
    public const int DIBUTTON_MECHA_DEVICE = 0x290044FE; // Show input device and controls
    public const int DIBUTTON_MECHA_PAUSE = 0x290044FC; // Start / Pause / Restart game
    public const uint DIAXIS_ANY_X_1 = 0xFF00C201;
    public const uint DIAXIS_ANY_X_2 = 0xFF00C202;
    public const uint DIAXIS_ANY_Y_1 = 0xFF014201;
    public const uint DIAXIS_ANY_Y_2 = 0xFF014202;
    public const uint DIAXIS_ANY_Z_1 = 0xFF01C201;
    public const uint DIAXIS_ANY_Z_2 = 0xFF01C202;
    public const uint DIAXIS_ANY_R_1 = 0xFF024201;
    public const uint DIAXIS_ANY_R_2 = 0xFF024202;
    public const uint DIAXIS_ANY_U_1 = 0xFF02C201;
    public const uint DIAXIS_ANY_U_2 = 0xFF02C202;
    public const uint DIAXIS_ANY_V_1 = 0xFF034201;
    public const uint DIAXIS_ANY_V_2 = 0xFF034202;
    public const uint DIAXIS_ANY_A_1 = 0xFF03C201;
    public const uint DIAXIS_ANY_A_2 = 0xFF03C202;
    public const uint DIAXIS_ANY_B_1 = 0xFF044201;
    public const uint DIAXIS_ANY_B_2 = 0xFF044202;
    public const uint DIAXIS_ANY_C_1 = 0xFF04C201;
    public const uint DIAXIS_ANY_C_2 = 0xFF04C202;
    public const uint DIAXIS_ANY_S_1 = 0xFF054201;
    public const uint DIAXIS_ANY_S_2 = 0xFF054202;
    public const uint DIAXIS_ANY_1 = 0xFF004201;
    public const uint DIAXIS_ANY_2 = 0xFF004202;
    public const uint DIAXIS_ANY_3 = 0xFF004203;
    public const uint DIAXIS_ANY_4 = 0xFF004204;
    public const uint DIPOV_ANY_1 = 0xFF004601;
    public const uint DIPOV_ANY_2 = 0xFF004602;
    public const uint DIPOV_ANY_3 = 0xFF004603;
    public const uint DIPOV_ANY_4 = 0xFF004604;
#if _INC_MMSYSTEM && ! MMNOJOY
    public const int JOY_PASSDRIVERDATA = 0x10000000;
#endif
#if _INC_MMSYSTEM && ! MMNOJOY
    public const int JOY_HWS_ISHEADTRACKER = 0x02000000;
#endif
#if _INC_MMSYSTEM && ! MMNOJOY
    public const int JOY_HWS_ISGAMEPORTDRIVER = 0x04000000;
#endif
#if _INC_MMSYSTEM && ! MMNOJOY
    public const int JOY_HWS_ISANALOGPORTDRIVER = 0x08000000;
#endif
#if _INC_MMSYSTEM && ! MMNOJOY
    public const int JOY_HWS_AUTOLOAD = 0x10000000;
#endif
#if _INC_MMSYSTEM && ! MMNOJOY
    public const int JOY_HWS_NODEVNODE = 0x20000000;
#endif
#if _INC_MMSYSTEM && ! MMNOJOY
    public const uint JOY_HWS_ISGAMEPORTBUS = 0x80000000;
#endif
#if _INC_MMSYSTEM && ! MMNOJOY
    public const int JOY_HWS_GAMEPORTBUSBUSY = 0x00000001;
#endif
#if _INC_MMSYSTEM && ! MMNOJOY
    public const int JOY_US_VOLATILE = 0x00000008;
#endif
#if ! DIJ_RINGZERO && _INC_MMDDK && ! MMNOJOYDEV
    public const int JOY_OEMPOLL_PASSDRIVERDATA = 7;
#endif
    public const int JOY_HW_NONE = 0;
    public const int JOY_HW_CUSTOM = 1;
    public const int JOY_HW_2A_2B_GENERIC = 2;
    public const int JOY_HW_2A_4B_GENERIC = 3;
    public const int JOY_HW_2B_GAMEPAD = 4;
    public const int JOY_HW_2B_FLIGHTYOKE = 5;
    public const int JOY_HW_2B_FLIGHTYOKETHROTTLE = 6;
    public const int JOY_HW_3A_2B_GENERIC = 7;
    public const int JOY_HW_3A_4B_GENERIC = 8;
    public const int JOY_HW_4B_GAMEPAD = 9;
    public const int JOY_HW_4B_FLIGHTYOKE = 10;
    public const int JOY_HW_4B_FLIGHTYOKETHROTTLE = 11;
    public const int JOY_HW_TWO_2A_2B_WITH_Y = 12;
    public const int JOY_HW_LASTENTRY = 13;
    public const int JOY_ISCAL_XY = 0x00000001; // XY are calibrated
    public const int JOY_ISCAL_Z = 0x00000002; // Z is calibrated
    public const int JOY_ISCAL_R = 0x00000004; // R is calibrated
    public const int JOY_ISCAL_U = 0x00000008; // U is calibrated
    public const int JOY_ISCAL_V = 0x00000010; // V is calibrated
    public const int JOY_ISCAL_POV = 0x00000020; // POV is calibrated
    public const int JOY_POV_NUMDIRS = 4;
    public const int JOY_POVVAL_FORWARD = 0;
    public const int JOY_POVVAL_BACKWARD = 1;
    public const int JOY_POVVAL_LEFT = 2;
    public const int JOY_POVVAL_RIGHT = 3;
    public const int JOY_HWS_HASZ = 0x00000001; // has Z info?
    public const int JOY_HWS_HASPOV = 0x00000002; // point of view hat present
    public const int JOY_HWS_POVISBUTTONCOMBOS = 0x00000004; // pov done through combo of buttons
    public const int JOY_HWS_POVISPOLL = 0x00000008; // pov done through polling
    public const int JOY_HWS_ISYOKE = 0x00000010; // joystick is a flight yoke
    public const int JOY_HWS_ISGAMEPAD = 0x00000020; // joystick is a game pad
    public const int JOY_HWS_ISCARCTRL = 0x00000040; // joystick is a car controller
    public const int JOY_HWS_XISJ1Y = 0x00000080; // X is on J1 Y axis
    public const int JOY_HWS_XISJ2X = 0x00000100; // X is on J2 X axis
    public const int JOY_HWS_XISJ2Y = 0x00000200; // X is on J2 Y axis
    public const int JOY_HWS_YISJ1X = 0x00000400; // Y is on J1 X axis
    public const int JOY_HWS_YISJ2X = 0x00000800; // Y is on J2 X axis
    public const int JOY_HWS_YISJ2Y = 0x00001000; // Y is on J2 Y axis
    public const int JOY_HWS_ZISJ1X = 0x00002000; // Z is on J1 X axis
    public const int JOY_HWS_ZISJ1Y = 0x00004000; // Z is on J1 Y axis
    public const int JOY_HWS_ZISJ2X = 0x00008000; // Z is on J2 X axis
    public const int JOY_HWS_POVISJ1X = 0x00010000; // pov done through J1 X axis
    public const int JOY_HWS_POVISJ1Y = 0x00020000; // pov done through J1 Y axis
    public const int JOY_HWS_POVISJ2X = 0x00040000; // pov done through J2 X axis
    public const int JOY_HWS_HASR = 0x00080000; // has R (4th axis) info
    public const int JOY_HWS_RISJ1X = 0x00100000; // R done through J1 X axis
    public const int JOY_HWS_RISJ1Y = 0x00200000; // R done through J1 Y axis
    public const int JOY_HWS_RISJ2Y = 0x00400000; // R done through J2 X axis
    public const int JOY_HWS_HASU = 0x00800000; // has U (5th axis) info
    public const int JOY_HWS_HASV = 0x01000000; // has V (6th axis) info
    public const int JOY_US_HASRUDDER = 0x00000001; // joystick configured with rudder
    public const int JOY_US_PRESENT = 0x00000002; // is joystick actually present?
    public const int JOY_US_ISOEM = 0x00000004; // joystick is an OEM defined type
    public const uint JOY_US_RESERVED = 0x80000000; // reserved
    public const int JOYTYPE_ZEROGAMEENUMOEMDATA = 0x00000001; // Zero GameEnum's OEM data field
    public const int JOYTYPE_NOAUTODETECTGAMEPORT = 0x00000002; // Device does not support Autodetect gameport
    public const int JOYTYPE_NOHIDDIRECT = 0x00000004; // Do not use HID directly for this device
    public const int JOYTYPE_ANALOGCOMPAT = 0x00000008; // Expose the analog compatible ID
    public const uint JOYTYPE_DEFAULTPROPSHEET = 0x80000000; // CPL overrides custom property sheet
    public const int JOYTYPE_DEVICEHIDE = 0x00010000; // Hide unclassified devices
    public const int JOYTYPE_MOUSEHIDE = 0x00020000; // Hide mice
    public const int JOYTYPE_KEYBHIDE = 0x00040000; // Hide keyboards
    public const int JOYTYPE_GAMEHIDE = 0x00080000; // Hide game controllers
    public const int JOYTYPE_HIDEACTIVE = 0x00100000; // Hide flags are active
    public const int JOYTYPE_INFOMASK = 0x00E00000; // Mask for type specific info
    public const int JOYTYPE_INFODEFAULT = 0x00000000; // Use default axis mappings
    public const int JOYTYPE_INFOYYPEDALS = 0x00200000; // Use Y as a combined pedals axis
    public const int JOYTYPE_INFOZYPEDALS = 0x00400000; // Use Z for accelerate, Y for brake
    public const int JOYTYPE_INFOYRPEDALS = 0x00600000; // Use Y for accelerate, R for brake
    public const int JOYTYPE_INFOZRPEDALS = 0x00800000; // Use Z for accelerate, R for brake
    public const int JOYTYPE_INFOZISSLIDER = 0x00200000; // Use Z as a slider
    public const int JOYTYPE_INFOZISZ = 0x00400000; // Use Z as Z axis
    public const int JOYTYPE_ENABLEINPUTREPORT = 0x01000000; // Enable initial input reports
#if ! DIJ_RINGZERO
    public const int MAX_JOYSTRING = 256;
#endif
#if ! DIJ_RINGZERO
    public const int MAX_JOYSTICKOEMVXDNAME = 260;
#endif
#if ! DIJ_RINGZERO
    public const int DITC_REGHWSETTINGS = 0x00000001;
#endif
#if ! DIJ_RINGZERO
    public const int DITC_CLSIDCONFIG = 0x00000002;
#endif
#if ! DIJ_RINGZERO
    public const int DITC_DISPLAYNAME = 0x00000004;
#endif
#if ! DIJ_RINGZERO
    public const int DITC_CALLOUT = 0x00000008;
#endif
#if ! DIJ_RINGZERO
    public const int DITC_HARDWAREID = 0x00000010;
#endif
#if ! DIJ_RINGZERO
    public const int DITC_FLAGS1 = 0x00000020;
#endif
#if ! DIJ_RINGZERO
    public const int DITC_FLAGS2 = 0x00000040;
#endif
#if ! DIJ_RINGZERO
    public const int DITC_MAPFILE = 0x00000080;
#endif
    public const int DIJC_GUIDINSTANCE = 0x00000001;
    public const int DIJC_REGHWCONFIGTYPE = 0x00000002;
    public const int DIJC_GAIN = 0x00000004;
    public const int DIJC_CALLOUT = 0x00000008;
    public const int DIJC_WDMGAMEPORT = 0x00000010;
    public const int DIJU_USERVALUES = 0x00000001;
    public const int DIJU_GLOBALDRIVER = 0x00000002;
    public const int DIJU_GAMEPORTEMULATOR = 0x00000004;
    public const string DIRECTINPUT_NOTIFICATION_MSGSTRINGA = "DIRECTINPUT_NOTIFICATION_MSGSTRING";
    public const int DIMSGWP_NEWAPPSTART = 0x00000001;
    public const int DIMSGWP_DX8APPSTART = 0x00000002;
    public const int DIMSGWP_DX8MAPPERAPPSTART = 0x00000003;
    public const int DIAPPIDFLAG_NOTIME = 0x00000001;
    public const int DIAPPIDFLAG_NOSIZE = 0x00000002;
    public const string DIRECTINPUT_REGSTR_VAL_APPIDFLAGA = "AppIdFlag";
    public const string DIRECTINPUT_REGSTR_KEY_LASTAPPA = "MostRecentApplication";
    public const string DIRECTINPUT_REGSTR_KEY_LASTMAPAPPA = "MostRecentMapperApplication";
    public const string DIRECTINPUT_REGSTR_VAL_VERSIONA = "Version";
    public const string DIRECTINPUT_REGSTR_VAL_NAMEA = "Name";
    public const string DIRECTINPUT_REGSTR_VAL_IDA = "Id";
    public const string DIRECTINPUT_REGSTR_VAL_MAPPERA = "UsesMapper";
    public const string DIRECTINPUT_REGSTR_VAL_LASTSTARTA = "MostRecentStart";
    public const uint DIERR_DRIVERFIRST = 0x80040300;
    public const uint DIERR_DRIVERLAST = 0x800403FF;
    public const uint DIERR_INVALIDCLASSINSTALLER = 0x80040400;
    public const uint DIERR_CANCELLED = 0x80040401;
    public const uint DIERR_BADINF = 0x80040402;
    public const int DIDIFT_DELETE = 0x01000000;
    public const int CONN_SRC_NONE = 0x0000;
    public const int CONN_SRC_LFO = 0x0001;
    public const int CONN_SRC_KEYONVELOCITY = 0x0002;
    public const int CONN_SRC_KEYNUMBER = 0x0003;
    public const int CONN_SRC_EG1 = 0x0004;
    public const int CONN_SRC_EG2 = 0x0005;
    public const int CONN_SRC_PITCHWHEEL = 0x0006;
    public const int CONN_SRC_CC1 = 0x0081;
    public const int CONN_SRC_CC7 = 0x0087;
    public const int CONN_SRC_CC10 = 0x008a;
    public const int CONN_SRC_CC11 = 0x008b;
    public const int CONN_DST_NONE = 0x0000;
    public const int CONN_DST_ATTENUATION = 0x0001;
    public const int CONN_DST_PITCH = 0x0003;
    public const int CONN_DST_PAN = 0x0004;
    public const int CONN_DST_LFO_FREQUENCY = 0x0104;
    public const int CONN_DST_LFO_STARTDELAY = 0x0105;
    public const int CONN_DST_EG1_ATTACKTIME = 0x0206;
    public const int CONN_DST_EG1_DECAYTIME = 0x0207;
    public const int CONN_DST_EG1_RELEASETIME = 0x0209;
    public const int CONN_DST_EG1_SUSTAINLEVEL = 0x020a;
    public const int CONN_DST_EG2_ATTACKTIME = 0x030a;
    public const int CONN_DST_EG2_DECAYTIME = 0x030b;
    public const int CONN_DST_EG2_RELEASETIME = 0x030d;
    public const int CONN_DST_EG2_SUSTAINLEVEL = 0x030e;
    public const int CONN_TRN_NONE = 0x0000;
    public const int CONN_TRN_CONCAVE = 0x0001;
    public const uint F_INSTRUMENT_DRUMS = 0x80000000;
    public const int F_RGN_OPTION_SELFNONEXCLUSIVE = 0x0001;
    public const int WAVELINK_CHANNEL_LEFT = 0x0001;
    public const int WAVELINK_CHANNEL_RIGHT = 0x0002;
    public const int F_WAVELINK_PHASE_MASTER = 0x0001;
    public const uint POOL_CUE_NULL = 0xffffffff;
    public const int F_WSMP_NO_TRUNCATION = 0x0001;
    public const int F_WSMP_NO_COMPRESSION = 0x0002;
    public const int WLOOP_TYPE_FORWARD = 0;
    public const int CONN_SRC_POLYPRESSURE = 0x0007; // Polyphonic Pressure
    public const int CONN_SRC_CHANNELPRESSURE = 0x0008; // Channel Pressure
    public const int CONN_SRC_VIBRATO = 0x0009; // Vibrato LFO
    public const int CONN_SRC_MONOPRESSURE = 0x000a; // MIDI Mono pressure
    public const int CONN_SRC_CC91 = 0x00db; // Reverb Send
    public const int CONN_SRC_CC93 = 0x00dd; // Chorus Send
    public const int CONN_DST_GAIN = 0x0001; // Same as CONN_DST_ ATTENUATION, but more appropriate terminology.
    public const int CONN_DST_KEYNUMBER = 0x0005; // Key Number Generator
    public const int CONN_DST_LEFT = 0x0010; // Left Channel Send
    public const int CONN_DST_RIGHT = 0x0011; // Right Channel Send
    public const int CONN_DST_CENTER = 0x0012; // Center Channel Send
    public const int CONN_DST_LEFTREAR = 0x0013; // Left Rear Channel Send
    public const int CONN_DST_RIGHTREAR = 0x0014; // Right Rear Channel Send
    public const int CONN_DST_LFE_CHANNEL = 0x0015; // LFE Channel Send
    public const int CONN_DST_CHORUS = 0x0080; // Chorus Send
    public const int CONN_DST_REVERB = 0x0081; // Reverb Send
    public const int CONN_DST_VIB_FREQUENCY = 0x0114; // Vibrato Frequency
    public const int CONN_DST_VIB_STARTDELAY = 0x0115; // Vibrato Start Delay
    public const int CONN_DST_EG1_DELAYTIME = 0x020B; // EG1 Delay Time
    public const int CONN_DST_EG1_HOLDTIME = 0x020C; // EG1 Hold Time
    public const int CONN_DST_EG1_SHUTDOWNTIME = 0x020D; // EG1 Shutdown Time
    public const int CONN_DST_EG2_DELAYTIME = 0x030F; // EG2 Delay Time
    public const int CONN_DST_EG2_HOLDTIME = 0x0310; // EG2 Hold Time
    public const int CONN_DST_FILTER_CUTOFF = 0x0500; // Filter Cutoff Frequency
    public const int CONN_DST_FILTER_Q = 0x0501; // Filter Resonance
    public const int CONN_TRN_CONVEX = 0x0002; // Convex Transform
    public const int CONN_TRN_SWITCH = 0x0003; // Switch Transform
    public const int DLS_CDL_AND = 0x0001; // X = X & Y
    public const int DLS_CDL_OR = 0x0002; // X = X | Y
    public const int DLS_CDL_XOR = 0x0003; // X = X ^ Y
    public const int DLS_CDL_ADD = 0x0004; // X = X + Y
    public const int DLS_CDL_SUBTRACT = 0x0005; // X = X - Y
    public const int DLS_CDL_MULTIPLY = 0x0006; // X = X * Y
    public const int DLS_CDL_DIVIDE = 0x0007; // X = X / Y
    public const int DLS_CDL_LOGICAL_AND = 0x0008; // X = X && Y
    public const int DLS_CDL_LOGICAL_OR = 0x0009; // X = X || Y
    public const int DLS_CDL_LT = 0x000A; // X = (X < Y)
    public const int DLS_CDL_LE = 0x000B; // X = (X <= Y)
    public const int DLS_CDL_GT = 0x000C; // X = (X > Y)
    public const int DLS_CDL_GE = 0x000D; // X = (X >= Y)
    public const int DLS_CDL_EQ = 0x000E; // X = (X == Y)
    public const int DLS_CDL_NOT = 0x000F; // X = !X
    public const int DLS_CDL_CONST = 0x0010; // 32-bit constant
    public const int DLS_CDL_QUERY = 0x0011; // 32-bit value returned from query
    public const int DLS_CDL_QUERYSUPPORTED = 0x0012; // Test to see if query is supported by synth
    public const int WLOOP_TYPE_RELEASE = 1;
    public const int F_WAVELINK_MULTICHANNEL = 0x0002;
    public const int DMUS_DOWNLOADINFO_INSTRUMENT = 1;
    public const int DMUS_DOWNLOADINFO_WAVE = 2;
    public const int DMUS_DOWNLOADINFO_INSTRUMENT2 = 3; // New version for better DLS2 support.
    public const int DMUS_DOWNLOADINFO_WAVEARTICULATION = 4; // Wave articulation data
    public const int DMUS_DOWNLOADINFO_STREAMINGWAVE = 5; // One chunk of a streaming
    public const int DMUS_DOWNLOADINFO_ONESHOTWAVE = 6;
    public const int DMUS_DEFAULT_SIZE_OFFSETTABLE = 1;
    public const int DMUS_MIN_DATA_SIZE = 4;
    public const int FACILITY_DIRECTMUSIC = 0x878; // Shared with DirectSound
    public const int DMUS_ERRBASE = 0x1000; // Make error codes human readable in hex
    public const int KSMETHOD_TYPE_NONE = 0x00000000;
    public const int KSMETHOD_TYPE_READ = 0x00000001;
    public const int KSMETHOD_TYPE_WRITE = 0x00000002;
    public const int KSMETHOD_TYPE_MODIFY = 0x00000003;
    public const int KSMETHOD_TYPE_SOURCE = 0x00000004;
    public const int KSMETHOD_TYPE_SEND = 0x00000001;
    public const int KSMETHOD_TYPE_SETSUPPORT = 0x00000100;
    public const int KSMETHOD_TYPE_BASICSUPPORT = 0x00000200;
    public const int KSPROPERTY_TYPE_GET = 0x00000001;
    public const int KSPROPERTY_TYPE_SET = 0x00000002;
    public const int KSPROPERTY_TYPE_SETSUPPORT = 0x00000100;
    public const int KSPROPERTY_TYPE_BASICSUPPORT = 0x00000200;
    public const int KSPROPERTY_TYPE_RELATIONS = 0x00000400;
    public const int KSPROPERTY_TYPE_SERIALIZESET = 0x00000800;
    public const int KSPROPERTY_TYPE_UNSERIALIZESET = 0x00001000;
    public const int KSPROPERTY_TYPE_SERIALIZERAW = 0x00002000;
    public const int KSPROPERTY_TYPE_UNSERIALIZERAW = 0x00004000;
    public const int KSPROPERTY_TYPE_SERIALIZESIZE = 0x00008000;
    public const int KSPROPERTY_TYPE_DEFAULTVALUES = 0x00010000;
    public const int KSPROPERTY_TYPE_TOPOLOGY = 0x10000000;
    public const uint DMO_E_INVALIDSTREAMINDEX = 0x80040201;
    public const uint DMO_E_INVALIDTYPE = 0x80040202;
    public const uint DMO_E_TYPE_NOT_SET = 0x80040203;
    public const uint DMO_E_NOTACCEPTING = 0x80040204;
    public const uint DMO_E_TYPE_NOT_ACCEPTED = 0x80040205;
    public const uint DMO_E_NO_MORE_ITEMS = 0x80040206;
    public const string DMUS_REGSTR_PATH_TOOLS = "Software\\Microsoft\\DirectMusic\\Tools";
    public const int DMUS_TRACK_PARAMF_CLOCK = 0x01; // set when the time is measured is in reference (clock) time
    public const int DMUS_EVENT_STRUCTURED = 0x00000001; // Unstructured data (SysEx, etc.)
    public const int DMUS_MAX_DESCRIPTION = 128;
    public const int DMUS_MAX_DRIVER = 128;
    public const int DMUS_EFFECT_NONE = 0x00000000;
    public const int DMUS_EFFECT_REVERB = 0x00000001;
    public const int DMUS_EFFECT_CHORUS = 0x00000002;
    public const int DMUS_EFFECT_DELAY = 0x00000004;
    public const int DMUS_PC_INPUTCLASS = 0;
    public const int DMUS_PC_OUTPUTCLASS = 1;
    public const int DMUS_PORT_WINMM_DRIVER = 0;
    public const int DMUS_PORT_USER_MODE_SYNTH = 1;
    public const int DMUS_PORT_KERNEL_MODE = 2;
    public const int DMUS_PORTPARAMS_VOICES = 0x00000001;
    public const int DMUS_PORTPARAMS_CHANNELGROUPS = 0x00000002;
    public const int DMUS_PORTPARAMS_AUDIOCHANNELS = 0x00000004;
    public const int DMUS_PORTPARAMS_SAMPLERATE = 0x00000008;
    public const int DMUS_PORTPARAMS_EFFECTS = 0x00000020;
    public const int DMUS_PORTPARAMS_SHARE = 0x00000040;
    public const int DMUS_PORTPARAMS_FEATURES = 0x00000080; // DirectX 8.0 and above
    public const int DMUS_PORT_FEATURE_AUDIOPATH = 0x00000001; // Supports audiopath connection to DSound buffers.
    public const int DMUS_PORT_FEATURE_STREAMING = 0x00000002; // Supports streaming waves through the synth.
    public const int DMUS_CLOCKF_GLOBAL = 0x00000001;
    public const int DSBUSID_FIRST_SPKR_LOC = 0;
    public const int DSBUSID_FRONT_LEFT = 0;
    public const int DSBUSID_LEFT = 0; // Front left is also just left
    public const int DSBUSID_FRONT_RIGHT = 1;
    public const int DSBUSID_RIGHT = 1; // Ditto front right
    public const int DSBUSID_FRONT_CENTER = 2;
    public const int DSBUSID_LOW_FREQUENCY = 3;
    public const int DSBUSID_BACK_LEFT = 4;
    public const int DSBUSID_BACK_RIGHT = 5;
    public const int DSBUSID_FRONT_LEFT_OF_CENTER = 6;
    public const int DSBUSID_FRONT_RIGHT_OF_CENTER = 7;
    public const int DSBUSID_BACK_CENTER = 8;
    public const int DSBUSID_SIDE_LEFT = 9;
    public const int DSBUSID_SIDE_RIGHT = 10;
    public const int DSBUSID_TOP_CENTER = 11;
    public const int DSBUSID_TOP_FRONT_LEFT = 12;
    public const int DSBUSID_TOP_FRONT_CENTER = 13;
    public const int DSBUSID_TOP_FRONT_RIGHT = 14;
    public const int DSBUSID_TOP_BACK_LEFT = 15;
    public const int DSBUSID_TOP_BACK_CENTER = 16;
    public const int DSBUSID_TOP_BACK_RIGHT = 17;
    public const int DSBUSID_LAST_SPKR_LOC = 17;
    public const int DSBUSID_REVERB_SEND = 64;
    public const int DSBUSID_CHORUS_SEND = 65;
    public const int DSBUSID_DYNAMIC_0 = 512;
    public const uint DSBUSID_NULL = 0xFFFFFFFF;
    public const int DMUS_VOLUME_MAX = 2000; // +20 dB
    public const int DMUS_VOLUME_MIN = -20000; // -200 dB
    public const int DMUS_VARIATIONF_MAJOR = 0x0000007F; // Seven positions in the scale - major chords.
    public const int DMUS_VARIATIONF_MINOR = 0x00003F80; // Seven positions in the scale - minor chords.
    public const int DMUS_VARIATIONF_OTHER = 0x001FC000; // Seven positions in the scale - other chords.
    public const int DMUS_VARIATIONF_ROOT_SCALE = 0x00200000; // Handles chord roots in the scale.
    public const int DMUS_VARIATIONF_ROOT_FLAT = 0x00400000; // Handles flat chord roots (based on scale notes).
    public const int DMUS_VARIATIONF_ROOT_SHARP = 0x00800000; // Handles sharp chord roots (based on scale notes).
    public const int DMUS_VARIATIONF_TYPE_TRIAD = 0x01000000; // Handles simple chords - triads.
    public const int DMUS_VARIATIONF_TYPE_6AND7 = 0x02000000; // Handles simple chords - 6 and 7.
    public const int DMUS_VARIATIONF_TYPE_COMPLEX = 0x04000000; // Handles complex chords.
    public const int DMUS_VARIATIONF_DEST_TO1 = 0x08000000; // Handles transitions to 1 chord.
    public const int DMUS_VARIATIONF_DEST_TO5 = 0x10000000; // Handles transitions to 5 chord.
    public const int DMUS_VARIATIONF_DEST_OTHER = 0x40000000; // Handles transitions to chords other than 1 .
    public const uint DMUS_VARIATIONF_MODES = 0xE0000000;
    public const int DMUS_VARIATIONF_IMA25_MODE = 0x00000000;
    public const int DMUS_VARIATIONF_DMUS_MODE = 0x20000000;
    public const int DMUS_PARTF_USE_MARKERS = 0x1;
    public const int DMUS_PARTF_ALIGN_CHORDS = 0x2;
    public const int DMUS_MARKERF_START = 0x1;
    public const int DMUS_MARKERF_STOP = 0x2;
    public const int DMUS_MARKERF_CHORD_ALIGN = 0x4;
    public const int DMUS_PATTERNF_PERSIST_CONTROL = 0x1;
    public const int DMUS_PORTCONFIGF_DRUMSON10 = 1; // This port configured for drums on channel 10.
    public const int DMUS_PORTCONFIGF_USEDEFAULT = 2; // Use the default port.
    public const int DMUS_BUFFERF_SHARED = 1; // Share this with other audio paths, instead of creating unique copies.
    public const int DMUS_BUFFERF_DEFINED = 2; // Use one of the standard predefined buffers (see GUID_Buffer... in dmusici.h.)
    public const int DMUS_BUFFERF_MIXIN = 8; // This is a mixin buffer.
    public const int DMUS_WAVETRACKF_SYNC_VAR = 0x1;
    public const int DMUS_WAVETRACKF_PERSIST_CONTROL = 0x2;
    public const int DMUS_CONTAINED_OBJF_KEEP = 1; // Keep the object cached in the loader after the container is released.
    public const int DMUS_SEGIOF_REFLENGTH = 1; // Use the time in rtLength for the segment length.
    public const int DMUS_SEGIOF_CLOCKTIME = 2; // This is a clock time segment.
    public const int DMUS_SIGNPOSTF_A = 1;
    public const int DMUS_SIGNPOSTF_B = 2;
    public const int DMUS_SIGNPOSTF_C = 4;
    public const int DMUS_SIGNPOSTF_D = 8;
    public const int DMUS_SIGNPOSTF_E = 0x10;
    public const int DMUS_SIGNPOSTF_F = 0x20;
    public const int DMUS_SIGNPOSTF_1 = 0x100;
    public const int DMUS_SIGNPOSTF_2 = 0x200;
    public const int DMUS_SIGNPOSTF_3 = 0x400;
    public const int DMUS_SIGNPOSTF_4 = 0x800;
    public const int DMUS_SIGNPOSTF_5 = 0x1000;
    public const int DMUS_SIGNPOSTF_6 = 0x2000;
    public const int DMUS_SIGNPOSTF_7 = 0x4000;
    public const int DMUS_SIGNPOSTF_CADENCE = 0x8000;
    public const int DMUS_CHORDMAPF_VERSION8 = 1; // Chordmap is version 8 or above.
    public const int DMUS_SPOSTCADENCEF_1 = 2; // Use the first cadence chord.
    public const int DMUS_SPOSTCADENCEF_2 = 4; // Use the second cadence chord.
    public const int DMUS_SEGMENTTRACKF_MOTIF = 1; // interpret DMRF as link to style, and use snam as the name of a motif within the style
    public const uint MT_MIN = 0x80000000; // Minimum music time value.
    public const int MT_MAX = 0x7FFFFFFF; // Maximum music time value.
    public const int DMUS_PPQ = 768; // parts per quarter note
    public const uint DMUS_PCHANNEL_BROADCAST_PERFORMANCE = 0xFFFFFFFF; // PMsg is sent on all PChannels of the performance.
    public const uint DMUS_PCHANNEL_BROADCAST_AUDIOPATH = 0xFFFFFFFE; // PMsg is sent on all PChannels of the audio path.
    public const uint DMUS_PCHANNEL_BROADCAST_SEGMENT = 0xFFFFFFFD; // PMsg is sent on all PChannels of the segment.
    public const uint DMUS_PCHANNEL_BROADCAST_GROUPS = 0xFFFFFFFC; // A duplicate PMsg is for each Channels Groups in the performance.
    public const int DMUS_PATH_SEGMENT = 0x1000; // Get the segment itself (from a segment state.)
    public const int DMUS_PATH_SEGMENT_TRACK = 0x1100; // Look in Track List of Segment.
    public const int DMUS_PATH_SEGMENT_GRAPH = 0x1200; // Get the segment's tool graph.
    public const int DMUS_PATH_SEGMENT_TOOL = 0x1300; // Look in Tool Graph of Segment.
    public const int DMUS_PATH_AUDIOPATH = 0x2000; // Get the audiopath itself (from a segment state.)
    public const int DMUS_PATH_AUDIOPATH_GRAPH = 0x2200; // Get the audiopath's tool graph.
    public const int DMUS_PATH_AUDIOPATH_TOOL = 0x2300; // Look in Tool Graph of Audio Path.
    public const int DMUS_PATH_PERFORMANCE = 0x3000; // Access the performance.
    public const int DMUS_PATH_PERFORMANCE_GRAPH = 0x3200; // Get the performance's tool graph.
    public const int DMUS_PATH_PERFORMANCE_TOOL = 0x3300; // Look in Tool Graph of Performance.
    public const int DMUS_PATH_PORT = 0x4000; // Access the synth.
    public const int DMUS_PATH_BUFFER = 0x6000; // Look in DirectSoundBuffer.
    public const int DMUS_PATH_BUFFER_DMO = 0x6100; // Access a DMO in the buffer.
    public const int DMUS_PATH_MIXIN_BUFFER = 0x7000; // Look in a global mixin buffer.
    public const int DMUS_PATH_MIXIN_BUFFER_DMO = 0x7100; // Access a DMO in a global mixin buffer.
    public const int DMUS_PATH_PRIMARY_BUFFER = 0x8000; // Access the primary buffer.
    public const uint DMUS_PCHANNEL_ALL = 0xFFFFFFFB;
    public const int DMUS_APATH_SHARED_STEREOPLUSREVERB = 1; // A standard music set up with stereo outs and reverb.
    public const int DMUS_APATH_DYNAMIC_3D = 6; // An audio path with one dynamic bus from the synth feeding to a dynamic 3d buffer. Does not send to env reverb.
    public const int DMUS_APATH_DYNAMIC_MONO = 7; // An audio path with one dynamic bus from the synth feeding to a dynamic mono buffer.
    public const int DMUS_APATH_DYNAMIC_STEREO = 8; // An audio path with two dynamic buses from the synth feeding to a dynamic stereo buffer.
    public const int DMUS_AUDIOF_3D = 0x1; // Require 3D buffers.
    public const int DMUS_AUDIOF_ENVIRON = 0x2; // Require environmental modeling.
    public const int DMUS_AUDIOF_EAX = 0x4; // Require use of EAX effects.
    public const int DMUS_AUDIOF_DMOS = 0x8; // Require use of additional DMOs.
    public const int DMUS_AUDIOF_STREAMING = 0x10; // Require support for streaming waves.
    public const int DMUS_AUDIOF_BUFFERS = 0x20; // Require support for multiple buffers (all above cases need this.)
    public const int DMUS_AUDIOF_ALL = 0x3F; // Requires everything.
    public const int DMUS_AUDIOPARAMS_FEATURES = 0x00000001;
    public const int DMUS_AUDIOPARAMS_VOICES = 0x00000002;
    public const int DMUS_AUDIOPARAMS_SAMPLERATE = 0x00000004;
    public const int DMUS_AUDIOPARAMS_DEFAULTSYNTH = 0x00000008;
    public const uint DMUS_SEG_REPEAT_INFINITE = 0xFFFFFFFF; // For IDirectMusicSegment::SetRepeat
    public const uint DMUS_SEG_ALLTRACKS = 0x80000000; // For IDirectMusicSegment::SetParam() and SetTrackConfig() - selects all tracks instead on nth index.
    public const uint DMUS_SEG_ANYTRACK = 0x80000000; // For IDirectMusicSegment::GetParam() - checks each track until it finds one that returns data (not DMUS_E_NOT_FOUND.)
    public const int DMUS_MAXSUBCHORD = 8;
    public const int DMUS_PLAYMODE_FIXED = 0;
    public const int DMUS_TEMPO_MAX = 1000;
    public const int DMUS_TEMPO_MIN = 1;
    public const float DMUS_MASTERTEMPO_MAX = 100.0f;
    public const float DMUS_MASTERTEMPO_MIN = 0.01f;
    public const int DMUS_CURVE_RESET = 1;
    public const int DMUS_CURVET_PBCURVE = 0x03; // Pitch bend curve.
    public const int DMUS_CURVET_CCCURVE = 0x04; // Control change curve.
    public const int DMUS_CURVET_MATCURVE = 0x05; // Mono aftertouch curve.
    public const int DMUS_CURVET_PATCURVE = 0x06; // Poly aftertouch curve.
    public const int DMUS_CURVET_RPNCURVE = 0x07; // RPN curve with curve type in wParamType.
    public const int DMUS_CURVET_NRPNCURVE = 0x08; // NRPN curve with curve type in wParamType.
    public const int DMUS_NOTIFICATION_SEGSTART = 0;
    public const int DMUS_NOTIFICATION_SEGEND = 1;
    public const int DMUS_NOTIFICATION_SEGALMOSTEND = 2;
    public const int DMUS_NOTIFICATION_SEGLOOP = 3;
    public const int DMUS_NOTIFICATION_SEGABORT = 4;
    public const int DMUS_NOTIFICATION_MUSICSTARTED = 0;
    public const int DMUS_NOTIFICATION_MUSICSTOPPED = 1;
    public const int DMUS_NOTIFICATION_MUSICALMOSTEND = 2;
    public const int DMUS_NOTIFICATION_MEASUREBEAT = 0;
    public const int DMUS_NOTIFICATION_CHORD = 0;
    public const int DMUS_NOTIFICATION_GROOVE = 0;
    public const int DMUS_NOTIFICATION_EMBELLISHMENT = 1;
    public const int DMUS_NOTIFICATION_RECOMPOSE = 0;
    public const int DMUS_WAVEF_OFF = 1; // If wave is playing and this is the off message.
    public const int DMUS_WAVEF_STREAMING = 2; // If wave is streaming.
    public const int DMUS_WAVEF_NOINVALIDATE = 4; // Don't invalidate this wave.
    public const int DMUS_WAVEF_NOPREROLL = 8; // Don't preroll any wave data.
    public const int DMUS_WAVEF_IGNORELOOPS = 0x20; // Ignore segment looping.
    public const int DMUS_MAX_NAME = 64; // Maximum object name length.
    public const int DMUS_MAX_CATEGORY = 64; // Maximum object category name length.
    public const int DMUS_TRACKCONFIG_OVERRIDE_ALL = 1; // This track should get parameters from this segment before controlling and primary tracks.
    public const int DMUS_TRACKCONFIG_OVERRIDE_PRIMARY = 2; // This track should get parameters from this segment before the primary segment tracks.
    public const int DMUS_TRACKCONFIG_FALLBACK = 4; // This track should get parameters from this segment if the primary and controlling segments don't succeed.
    public const int DMUS_TRACKCONFIG_CONTROL_ENABLED = 8; // GetParam() enabled for this track.
    public const int DMUS_TRACKCONFIG_PLAY_ENABLED = 0x10; // Play() enabled for this track.
    public const int DMUS_TRACKCONFIG_NOTIFICATION_ENABLED = 0x20; // Notifications enabled for this track.
    public const int DMUS_TRACKCONFIG_PLAY_CLOCKTIME = 0x40; // This track plays in clock time, not music time.
    public const int DMUS_TRACKCONFIG_PLAY_COMPOSE = 0x80; // This track should regenerate data each time it starts playing.
    public const int DMUS_TRACKCONFIG_LOOP_COMPOSE = 0x100; // This track should regenerate data each time it repeats.
    public const int DMUS_TRACKCONFIG_COMPOSING = 0x200; // This track is used to compose other tracks.
    public const int DMUS_TRACKCONFIG_CONTROL_PLAY = 0x10000; // This track, when played in a controlling segment, overrides playback of primary segment tracks.
    public const int DMUS_TRACKCONFIG_CONTROL_NOTIFICATION = 0x20000; // This track, when played in a controlling segment, overrides notification of primary segment tracks.
    public const int DMUS_TRACKCONFIG_TRANS1_FROMSEGSTART = 0x400; // Get track info from start of From segment
    public const int DMUS_TRACKCONFIG_TRANS1_FROMSEGCURRENT = 0x800; // Get track info from current place in From segment
    public const int DMUS_TRACKCONFIG_TRANS1_TOSEGSTART = 0x1000; // Get track info from start of To segment
    public const string REGSTR_PATH_SOFTWARESYNTHS = "Software\\Microsoft\\DirectMusic\\SoftwareSynths";
    public const int REFRESH_F_LASTBUFFER = 0x00000001;
    public const int DPNA_DATATYPE_STRING = 0x00000001;
    public const int DPNA_DATATYPE_DWORD = 0x00000002;
    public const int DPNA_DATATYPE_GUID = 0x00000003;
    public const int DPNA_DATATYPE_BINARY = 0x00000004;
    public const int DPNA_DATATYPE_STRING_ANSI = 0x00000005;
    public const int DPNA_DPNSVR_PORT = 6073;
    public const uint DPNA_INDEX_INVALID = 0xFFFFFFFF;
    public const int DPNA_BAUD_RATE_9600 = 9600;
    public const int DPNA_BAUD_RATE_14400 = 14400;
    public const int DPNA_BAUD_RATE_19200 = 19200;
    public const int DPNA_BAUD_RATE_38400 = 38400;
    public const int DPNA_BAUD_RATE_56000 = 56000;
    public const int DPNA_BAUD_RATE_57600 = 57600;
    public const int DPNA_BAUD_RATE_115200 = 115200;
    public const int DPNA_TRAVERSALMODE_NONE = 0;
    public const int DPNA_TRAVERSALMODE_PORTREQUIRED = 1;
    public const int DPNA_TRAVERSALMODE_PORTRECOMMENDED = 2;
    public const string DPNA_HEADER_A = "x-directplay:/";
    public const char DPNA_SEPARATOR_KEYVALUE_A = '=';
    public const char DPNA_SEPARATOR_USERDATA_A = '#';
    public const char DPNA_SEPARATOR_COMPONENT_A = ';';
    public const char DPNA_ESCAPECHAR_A = '%';
    public const string DPNA_KEY_NAT_RESOLVER_A = "natresolver";
    public const string DPNA_KEY_NAT_RESOLVER_USER_STRING_A = "natresolveruserstring";
    public const string DPNA_KEY_APPLICATION_INSTANCE_A = "applicationinstance";
    public const string DPNA_KEY_DEVICE_A = "device";
    public const string DPNA_KEY_HOSTNAME_A = "hostname";
    public const string DPNA_KEY_PORT_A = "port";
    public const string DPNA_KEY_NAMEINFO_A = "nameinfo";
    public const string DPNA_KEY_PROCESSOR_A = "processor";
    public const string DPNA_KEY_PROGRAM_A = "program";
    public const string DPNA_KEY_PROVIDER_A = "provider";
    public const string DPNA_KEY_SCOPE_A = "scope";
    public const string DPNA_KEY_TRAVERSALMODE_A = "traversalmode";
    public const string DPNA_KEY_BAUD_A = "baud";
    public const string DPNA_KEY_FLOWCONTROL_A = "flowcontrol";
    public const string DPNA_KEY_PARITY_A = "parity";
    public const string DPNA_KEY_PHONENUMBER_A = "phonenumber";
    public const string DPNA_KEY_STOPBITS_A = "stopbits";
    public const string DPNA_STOP_BITS_ONE_A = "1";
    public const string DPNA_STOP_BITS_ONE_FIVE_A = "1.5";
    public const string DPNA_STOP_BITS_TWO_A = "2";
    public const string DPNA_PARITY_NONE_A = "NONE";
    public const string DPNA_PARITY_EVEN_A = "EVEN";
    public const string DPNA_PARITY_ODD_A = "ODD";
    public const string DPNA_PARITY_MARK_A = "MARK";
    public const string DPNA_PARITY_SPACE_A = "SPACE";
    public const string DPNA_FLOW_CONTROL_NONE_A = "NONE";
    public const string DPNA_FLOW_CONTROL_XONXOFF_A = "XONXOFF";
    public const string DPNA_FLOW_CONTROL_RTS_A = "RTS";
    public const string DPNA_FLOW_CONTROL_DTR_A = "DTR";
    public const string DPNA_FLOW_CONTROL_RTSDTR_A = "RTSDTR";
    public const string DPNA_VALUE_TCPIPPROVIDER_A = "IP";
    public const string DPNA_VALUE_IPXPROVIDER_A = "IPX";
    public const string DPNA_VALUE_MODEMPROVIDER_A = "MODEM";
    public const string DPNA_VALUE_SERIALPROVIDER_A = "SERIAL";
    public const uint DPN_MSGID_OFFSET = 0xFFFF0000;
    public const int DPNID_ALL_PLAYERS_GROUP = 0;
    public const int DPNDESTROYGROUPREASON_NORMAL = 0x0001;
    public const int DPNDESTROYGROUPREASON_AUTODESTRUCTED = 0x0002;
    public const int DPNDESTROYGROUPREASON_SESSIONTERMINATED = 0x0003;
    public const int DPNDESTROYPLAYERREASON_NORMAL = 0x0001;
    public const int DPNDESTROYPLAYERREASON_CONNECTIONLOST = 0x0002;
    public const int DPNDESTROYPLAYERREASON_SESSIONTERMINATED = 0x0003;
    public const int DPNDESTROYPLAYERREASON_HOSTDESTROYEDPLAYER = 0x0004;
    public const int DPN_MAX_APPDESC_RESERVEDDATA_SIZE = 64;
    public const uint DPNOP_SYNC = 0x80000000;
    public const int DPNCANCEL_CONNECT = 0x00000001;
    public const int DPNCANCEL_ENUM = 0x00000002;
    public const int DPNCANCEL_SEND = 0x00000004;
    public const int DPNCANCEL_ALL_OPERATIONS = 0x00008000;
    public const uint DPNCANCEL_PLAYER_SENDS = 0x80000000;
    public const int DPNCLOSE_IMMEDIATE = 0x00000001;
    public const int DPNCONNECT_OKTOQUERYFORADDRESSING = 0x0001;
    public const int DPNENUM_PLAYERS = 0x0001;
    public const int DPNENUM_GROUPS = 0x0010;
    public const int DPNENUMHOSTS_OKTOQUERYFORADDRESSING = 0x0001;
    public const int DPNENUMHOSTS_NOBROADCASTFALLBACK = 0x0002;
    public const int DPNENUMSERVICEPROVIDERS_ALL = 0x0001;
    public const int DPNGETLOCALHOSTADDRESSES_COMBINED = 0x0001;
    public const int DPNGETSENDQUEUEINFO_PRIORITY_NORMAL = 0x0001;
    public const int DPNGETSENDQUEUEINFO_PRIORITY_HIGH = 0x0002;
    public const int DPNGETSENDQUEUEINFO_PRIORITY_LOW = 0x0004;
    public const int DPNGROUP_AUTODESTRUCT = 0x0001;
    public const int DPNHOST_OKTOQUERYFORADDRESSING = 0x0001;
    public const int DPNINFO_NAME = 0x0001;
    public const int DPNINFO_DATA = 0x0002;
    public const int DPNINITIALIZE_DISABLEPARAMVAL = 0x0001;
    public const int DPNINITIALIZE_HINT_LANSESSION = 0x0002;
    public const int DPNINITIALIZE_DISABLELINKTUNING = 0x0004;
    public const int DPNLOBBY_REGISTER = 0x0001;
    public const int DPNLOBBY_UNREGISTER = 0x0002;
    public const int DPNPLAYER_LOCAL = 0x0002;
    public const int DPNPLAYER_HOST = 0x0004;
    public const int DPNRECEIVE_GUARANTEED = 0x0001;
    public const int DPNRECEIVE_COALESCED = 0x0002;
    public const int DPNSEND_NOCOPY = 0x0001;
    public const int DPNSEND_NOCOMPLETE = 0x0002;
    public const int DPNSEND_COMPLETEONPROCESS = 0x0004;
    public const int DPNSEND_GUARANTEED = 0x0008;
    public const int DPNSEND_NONSEQUENTIAL = 0x0010;
    public const int DPNSEND_NOLOOPBACK = 0x0020;
    public const int DPNSEND_PRIORITY_LOW = 0x0040;
    public const int DPNSEND_PRIORITY_HIGH = 0x0080;
    public const int DPNSEND_COALESCE = 0x0100;
    public const int DPNSENDCOMPLETE_GUARANTEED = 0x0001;
    public const int DPNSENDCOMPLETE_COALESCED = 0x0002;
    public const int DPNSESSION_CLIENT_SERVER = 0x0001;
    public const int DPNSESSION_MIGRATE_HOST = 0x0004;
    public const int DPNSESSION_NODPNSVR = 0x0040;
    public const int DPNSESSION_REQUIREPASSWORD = 0x0080;
    public const int DPNSESSION_NOENUMS = 0x0100;
    public const int DPNSESSION_FAST_SIGNED = 0x0200;
    public const int DPNSESSION_FULL_SIGNED = 0x0400;
    public const int DPNSPCAPS_SUPPORTSDPNSVR = 0x0001;
    public const int DPNSPCAPS_SUPPORTSBROADCAST = 0x0002;
    public const int DPNSPCAPS_SUPPORTSALLADAPTERS = 0x0004;
    public const int DPNSPCAPS_SUPPORTSTHREADPOOL = 0x0008;
    public const int DPNSPCAPS_NETWORKSIMULATOR = 0x0010;
    public const int DPNSPINFO_NETWORKSIMULATORDEVICE = 0x0001;
    public const int _DPN_FACILITY_CODE = 0x015;
    public const int _DPNHRESULT_BASE = 0x8000;
    public const int _FACDP = 0x877;
    public const int DPID_SYSMSG = 0;
    public const int DPID_ALLPLAYERS = 0;
    public const int DPID_SERVERPLAYER = 1;
    public const int DPID_RESERVEDRANGE = 100;
    public const uint DPID_UNKNOWN = 0xFFFFFFFF;
    public const int DPCAPS_ISHOST = 0x00000002;
    public const int DPCAPS_GROUPOPTIMIZED = 0x00000008;
    public const int DPCAPS_KEEPALIVEOPTIMIZED = 0x00000010;
    public const int DPCAPS_GUARANTEEDOPTIMIZED = 0x00000020;
    public const int DPCAPS_GUARANTEEDSUPPORTED = 0x00000040;
    public const int DPCAPS_SIGNINGSUPPORTED = 0x00000080;
    public const int DPCAPS_ENCRYPTIONSUPPORTED = 0x00000100;
    public const int DPPLAYERCAPS_LOCAL = 0x00000800;
    public const int DPCAPS_ASYNCCANCELSUPPORTED = 0x00001000;
    public const int DPCAPS_ASYNCCANCELALLSUPPORTED = 0x00002000;
    public const int DPCAPS_SENDTIMEOUTSUPPORTED = 0x00004000;
    public const int DPCAPS_SENDPRIORITYSUPPORTED = 0x00008000;
    public const int DPCAPS_ASYNCSUPPORTED = 0x00010000;
    public const int DPSESSION_NEWPLAYERSDISABLED = 0x00000001;
    public const int DPSESSION_MIGRATEHOST = 0x00000004;
    public const int DPSESSION_NOMESSAGEID = 0x00000008;
    public const int DPSESSION_JOINDISABLED = 0x00000020;
    public const int DPSESSION_KEEPALIVE = 0x00000040;
    public const int DPSESSION_NODATAMESSAGES = 0x00000080;
    public const int DPSESSION_SECURESERVER = 0x00000100;
    public const int DPSESSION_PRIVATE = 0x00000200;
    public const int DPSESSION_PASSWORDREQUIRED = 0x00000400;
    public const int DPSESSION_MULTICASTSERVER = 0x00000800;
    public const int DPSESSION_CLIENTSERVER = 0x00001000;
    public const int DPSESSION_DIRECTPLAYPROTOCOL = 0x00002000;
    public const int DPSESSION_NOPRESERVEORDER = 0x00004000;
    public const int DPSESSION_OPTIMIZELATENCY = 0x00008000;
    public const int DPSESSION_ALLOWVOICERETRO = 0x00010000;
    public const int DPSESSION_NOSESSIONDESCMESSAGES = 0x00020000;
    public const int DPESC_TIMEDOUT = 0x00000001;
    public const int DPCONNECTION_DIRECTPLAY = 0x00000001;
    public const int DPCONNECTION_DIRECTPLAYLOBBY = 0x00000002;
    public const int DPENUMPLAYERS_ALL = 0x00000000;
    public const int DPENUMPLAYERS_LOCAL = 0x00000008;
    public const int DPENUMPLAYERS_REMOTE = 0x00000010;
    public const int DPENUMPLAYERS_GROUP = 0x00000020;
    public const int DPENUMPLAYERS_SESSION = 0x00000080;
    public const int DPENUMPLAYERS_SERVERPLAYER = 0x00000100;
    public const int DPENUMPLAYERS_SPECTATOR = 0x00000200;
    public const int DPENUMGROUPS_SHORTCUT = 0x00000400;
    public const int DPENUMGROUPS_STAGINGAREA = 0x00000800;
    public const int DPENUMGROUPS_HIDDEN = 0x00001000;
    public const int DPENUMPLAYERS_OWNER = 0x00002000;
    public const int DPENUMSESSIONS_AVAILABLE = 0x00000001;
    public const int DPENUMSESSIONS_ALL = 0x00000002;
    public const int DPENUMSESSIONS_ASYNC = 0x00000010;
    public const int DPENUMSESSIONS_STOPASYNC = 0x00000020;
    public const int DPENUMSESSIONS_PASSWORDREQUIRED = 0x00000040;
    public const int DPENUMSESSIONS_RETURNSTATUS = 0x00000080;
    public const int DPGETCAPS_GUARANTEED = 0x00000001;
    public const int DPGET_REMOTE = 0x00000000;
    public const int DPGET_LOCAL = 0x00000001;
    public const int DPOPEN_JOIN = 0x00000001;
    public const int DPOPEN_CREATE = 0x00000002;
    public const int DPRECEIVE_ALL = 0x00000001;
    public const int DPRECEIVE_TOPLAYER = 0x00000002;
    public const int DPRECEIVE_FROMPLAYER = 0x00000004;
    public const int DPRECEIVE_PEEK = 0x00000008;
    public const int DPSEND_GUARANTEED = 0x00000001;
    public const int DPSEND_HIGHPRIORITY = 0x00000002;
    public const int DPSEND_OPENSTREAM = 0x00000008;
    public const int DPSEND_CLOSESTREAM = 0x00000010;
    public const int DPSEND_SIGNED = 0x00000020;
    public const int DPSEND_ENCRYPTED = 0x00000040;
    public const int DPSEND_LOBBYSYSTEMMESSAGE = 0x00000080;
    public const int DPSEND_ASYNC = 0x00000200;
    public const int DPSEND_NOSENDCOMPLETEMSG = 0x00000400;
    public const int DPSEND_MAX_PRI = 0x0000FFFF;
    public const int DPSET_REMOTE = 0x00000000;
    public const int DPSET_LOCAL = 0x00000001;
    public const int DPSET_GUARANTEED = 0x00000002;
    public const int DPMESSAGEQUEUE_SEND = 0x00000001;
    public const int DPMESSAGEQUEUE_RECEIVE = 0x00000002;
    public const int DPSYS_CREATEPLAYERORGROUP = 0x0003;
    public const int DPSYS_DESTROYPLAYERORGROUP = 0x0005;
    public const int DPSYS_ADDPLAYERTOGROUP = 0x0007;
    public const int DPSYS_DELETEPLAYERFROMGROUP = 0x0021;
    public const int DPSYS_SESSIONLOST = 0x0031;
    public const int DPSYS_HOST = 0x0101;
    public const int DPSYS_SETPLAYERORGROUPDATA = 0x0102;
    public const int DPSYS_SETPLAYERORGROUPNAME = 0x0103;
    public const int DPSYS_SETSESSIONDESC = 0x0104;
    public const int DPSYS_ADDGROUPTOGROUP = 0x0105;
    public const int DPSYS_DELETEGROUPFROMGROUP = 0x0106;
    public const int DPSYS_SECUREMESSAGE = 0x0107;
    public const int DPSYS_STARTSESSION = 0x0108;
    public const int DPSYS_CHAT = 0x0109;
    public const int DPSYS_SETGROUPOWNER = 0x010A;
    public const int DPSYS_SENDCOMPLETE = 0x010d;
    public const int DPPLAYERTYPE_GROUP = 0x00000000;
    public const int DPPLAYERTYPE_PLAYER = 0x00000001;
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPENUMSESSIONS_PREVIOUS = 0x00000004;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPENUMPLAYERS_PREVIOUS = 0x00000004;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPSEND_TRYONCE = 0x00000004;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPCAPS_NAMESERVICE = 0x00000001;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPCAPS_GUARANTEED = 0x00000004;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPLONGNAMELEN = 52;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPSHORTNAMELEN = 20;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPSESSIONNAMELEN = 32;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPPASSWORDLEN = 16;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPUSERRESERVED = 16;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPSYS_ADDPLAYER = 0x0003;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPSYS_DELETEPLAYER = 0x0005;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPSYS_DELETEGROUP = 0x0020;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPSYS_DELETEPLAYERFROMGRP = 0x0021;
#endif
#if ! IDIRECTPLAY2_OR_GREATER
    public const int DPSYS_CONNECT = 0x484b;
#endif
    public const int DPLWAIT_CANCEL = 0x00000001;
    public const int DPLMSG_SYSTEM = 0x00000001;
    public const int DPLMSG_STANDARD = 0x00000002;
    public const uint DPLAPP_NOENUM = 0x80000000;
    public const int DPLAPP_AUTOVOICE = 0x00000001;
    public const int DPLAPP_SELFVOICE = 0x00000002;
    public const int DPL_NOCONFIRMATION = 0;
    public const int DPLSYS_CONNECTIONSETTINGSREAD = 0x00000001;
    public const int DPLSYS_DPLAYCONNECTFAILED = 0x00000002;
    public const int DPLSYS_DPLAYCONNECTSUCCEEDED = 0x00000003;
    public const int DPLSYS_APPTERMINATED = 0x00000004;
    public const int DPLSYS_SETPROPERTY = 0x00000005;
    public const int DPLSYS_SETPROPERTYRESPONSE = 0x00000006;
    public const int DPLSYS_GETPROPERTY = 0x00000007;
    public const int DPLSYS_GETPROPERTYRESPONSE = 0x00000008;
    public const int DPLSYS_NEWSESSIONHOST = 0x00000009;
    public const int DPLSYS_NEWCONNECTIONSETTINGS = 0x0000000A;
    public const int DPLSYS_LOBBYCLIENTRELEASE = 0x0000000B;
    public const int DPCPA_NOFLOW = 0; // no flow control
    public const int DPCPA_XONXOFFFLOW = 1; // software flow control
    public const int DPCPA_RTSFLOW = 2; // hardware flow control with RTS
    public const int DPCPA_DTRFLOW = 3; // hardware flow control with DTR
    public const int DPCPA_RTSDTRFLOW = 4; // hardware flow control with RTS and DTR
    public const int DPL_MSGID_LOBBY = 0x8000;
    public const uint DPLHANDLE_ALLCONNECTIONS = 0xFFFFFFFF;
    public const int DPLSESSION_CONNECTED = 0x0001;
    public const int DPLSESSION_COULDNOTCONNECT = 0x0002;
    public const int DPLSESSION_DISCONNECTED = 0x0003;
    public const int DPLSESSION_TERMINATED = 0x0004;
    public const int DPLSESSION_HOSTMIGRATED = 0x0005;
    public const int DPLSESSION_HOSTMIGRATEDHERE = 0x0006;
    public const int DPLAVAILABLE_ALLOWMULTIPLECONNECT = 0x0001;
    public const int DPLCONNECT_LAUNCHNEW = 0x0001;
    public const int DPLCONNECT_LAUNCHNOTFOUND = 0x0002;
    public const int DPLCONNECTSETTINGS_HOST = 0x0001;
    public const int DPLINITIALIZE_DISABLEPARAMVAL = 0x0001;
    public const int DPNH_MAX_SIMULTANEOUS_PORTS = 16; // up to 16 ports may be specified in a single RegisterPorts call
    public const int DPNHINITIALIZE_DISABLEGATEWAYSUPPORT = 0x01; // disables Internet gateway traversal support (cannot be specified with DPNHINITIALIZE_DISABLELOCALFIREWALLSUPPORT)
    public const int DPNHINITIALIZE_DISABLELOCALFIREWALLSUPPORT = 0x02; // disables local firewall traversal support (cannot be specified with DPNHINITIALIZE_DISABLEGATEWAYSUPPORT)
    public const int DPNHGETCAPS_UPDATESERVERSTATUS = 0x01; // automatically extend expiring leases and detect changes in server status
    public const int DPNHREGISTERPORTS_TCP = 0x01; // request TCP ports instead of UDP
    public const int DPNHREGISTERPORTS_FIXEDPORTS = 0x02; // asks the server to use the same port numbers on the public interface
    public const int DPNHREGISTERPORTS_SHAREDPORTS = 0x04; // requests that the server allow the UDP fixed ports to be shared with other clients (must be specified with DPNHREGISTERPORTS_FIXEDPORTS and cannot be specified with DPNHREGISTERPORTS_TCP)
    public const int DPNHGETREGISTEREDADDRESSES_LOCALFIREWALLREMAPONLY = 0x01; // retrieve the public address for the local firewall only, even if mapped on remote Internet gateway
    public const int DPNHQUERYADDRESS_TCP = 0x01; // request a TCP port instead of UDP
    public const int DPNHQUERYADDRESS_CACHEFOUND = 0x02; // cache the discovered address if found
    public const int DPNHQUERYADDRESS_CACHENOTFOUND = 0x04; // cache the fact that no address was found, if that is the case
    public const int DPNHQUERYADDRESS_CHECKFORPRIVATEBUTUNMAPPED = 0x08; // determine if the address is behind the same Internet gateway, but not mapped on that Internet gateway
    public const int DPNHCAPSFLAG_LOCALFIREWALLPRESENT = 0x01; // at least one network connection has a local firewall present
    public const int DPNHCAPSFLAG_GATEWAYPRESENT = 0x02; // at least one network connection has an Internet gateway present
    public const int DPNHCAPSFLAG_GATEWAYISLOCAL = 0x04; // a detected Internet gateway is local (i.e. the public address is another network interface on the same machine)
    public const int DPNHCAPSFLAG_PUBLICADDRESSAVAILABLE = 0x08; // at least one server has a valid public address for registered mappings
    public const int DPNHCAPSFLAG_NOTALLSUPPORTACTIVENOTIFY = 0x10; // at least one available server does not support an active-notification mechanisms and must be polled
    public const int DPNHADDRESSTYPE_TCP = 0x01; // the mappings are for TCP ports instead of UDP
    public const int DPNHADDRESSTYPE_FIXEDPORTS = 0x02; // the mappings are for ports which are the same on the Internet gateway
    public const int DPNHADDRESSTYPE_SHAREDPORTS = 0x04; // the mappings are for shared UDP fixed ports
    public const int DPNHADDRESSTYPE_LOCALFIREWALL = 0x08; // the addresses are opened on a local firewall
    public const int DPNHADDRESSTYPE_GATEWAY = 0x10; // the addresses are registered with an Internet gateway
    public const int DPNHADDRESSTYPE_GATEWAYISLOCAL = 0x20; // the Internet gateway is local (i.e. the public address is another network interface on the same machine)
    public const int _DPNH_FACILITY_CODE = 0x015;
    public const int _DPNH_HRESULT_BASE = 0xF000;
    public const int DSETUPERR_SUCCESS_RESTART = 1;
    public const int DSETUPERR_SUCCESS = 0;
    public const int DSETUPERR_BADWINDOWSVERSION = -1;
    public const int DSETUPERR_SOURCEFILENOTFOUND = -2;
    public const int DSETUPERR_NOCOPY = -5;
    public const int DSETUPERR_OUTOFDISKSPACE = -6;
    public const int DSETUPERR_CANTFINDINF = -7;
    public const int DSETUPERR_CANTFINDDIR = -8;
    public const int DSETUPERR_INTERNAL = -9;
    public const int DSETUPERR_UNKNOWNOS = -11;
    public const int DSETUPERR_NEWERVERSION = -14;
    public const int DSETUPERR_NOTADMIN = -15;
    public const int DSETUPERR_UNSUPPORTEDPROCESSOR = -16;
    public const int DSETUPERR_MISSINGCAB_MANAGEDDX = -17;
    public const int DSETUPERR_NODOTNETFRAMEWORKINSTALLED = -18;
    public const int DSETUPERR_CABDOWNLOADFAIL = -19;
    public const int DSETUP_DDRAWDRV = 0x00000008; // install DirectDraw Drivers
    public const int DSETUP_DSOUNDDRV = 0x00000010; // install DirectSound Drivers
    public const int DSETUP_DXCORE = 0x00010000; // install DirectX runtime
    public const int DSETUP_MANAGEDDX = 0x00004000; // install managed DirectX
    public const int DSETUP_TESTINSTALL = 0x00020000; // just test install, don't do anything
    public const int DSETUP_DDRAW = 0x00000001; // OBSOLETE. install DirectDraw
    public const int DSETUP_DSOUND = 0x00000002; // OBSOLETE. install DirectSound
    public const int DSETUP_DPLAY = 0x00000004; // OBSOLETE. install DirectPlay
    public const int DSETUP_DPLAYSP = 0x00000020; // OBSOLETE. install DirectPlay Providers
    public const int DSETUP_DVIDEO = 0x00000040; // OBSOLETE. install DirectVideo
    public const int DSETUP_D3D = 0x00000200; // OBSOLETE. install Direct3D
    public const int DSETUP_DINPUT = 0x00000800; // OBSOLETE. install DirectInput
    public const int DSETUP_DIRECTXSETUP = 0x00001000; // OBSOLETE. install DirectXSetup DLL's
    public const int DSETUP_NOUI = 0x00002000; // OBSOLETE. install DirectX with NO UI
    public const int DSETUP_PROMPTFORDRIVERS = 0x10000000; // OBSOLETE. prompt when replacing display/audio drivers
    public const int DSETUP_RESTOREDRIVERS = 0x20000000; // OBSOLETE. restore display/audio drivers
    public const int DSETUP_CB_MSG_NOMESSAGE = 0;
    public const int DSETUP_CB_MSG_INTERNAL_ERROR = 10;
    public const int DSETUP_CB_MSG_BEGIN_INSTALL = 13;
    public const int DSETUP_CB_MSG_BEGIN_INSTALL_RUNTIME = 14;
    public const int DSETUP_CB_MSG_PROGRESS = 18;
    public const int DSETUP_CB_MSG_WARNING_DISABLED_COMPONENT = 19;
    public const int EC_SYSTEMBASE = 0x00;
    public const int EC_USER = 0x8000;
    public const int EC_COMPLETE = 0x01;
    public const int EC_USERABORT = 0x02;
    public const int EC_ERRORABORT = 0x03;
    public const int EC_TIME = 0x04;
    public const int EC_REPAINT = 0x05;
    public const int EC_STREAM_ERROR_STOPPED = 0x06;
    public const int EC_STREAM_ERROR_STILLPLAYING = 0x07;
    public const int EC_ERROR_STILLPLAYING = 0x08;
    public const int EC_PALETTE_CHANGED = 0x09;
    public const int EC_VIDEO_SIZE_CHANGED = 0x0A;
    public const int EC_QUALITY_CHANGE = 0x0B;
    public const int EC_SHUTTING_DOWN = 0x0C;
    public const int EC_CLOCK_CHANGED = 0x0D;
    public const int EC_PAUSED = 0x0E;
    public const int EC_OPENING_FILE = 0x10;
    public const int EC_BUFFERING_DATA = 0x11;
    public const int EC_FULLSCREEN_LOST = 0x12;
    public const int EC_ACTIVATE = 0x13;
    public const int EC_NEED_RESTART = 0x14;
    public const int EC_WINDOW_DESTROYED = 0x15;
    public const int EC_DISPLAY_CHANGED = 0x16;
    public const int EC_STARVATION = 0x17;
    public const int EC_OLE_EVENT = 0x18;
    public const int EC_NOTIFY_WINDOW = 0x19;
    public const int EC_STREAM_CONTROL_STOPPED = 0x1A;
    public const int EC_STREAM_CONTROL_STARTED = 0x1B;
    public const int EC_END_OF_SEGMENT = 0x1C;
    public const int EC_SEGMENT_STARTED = 0x1D;
    public const int EC_LENGTH_CHANGED = 0x1E;
    public const int EC_DEVICE_LOST = 0x1f;
    public const int EC_STEP_COMPLETE = 0x24;
    public const int EC_TIMECODE_AVAILABLE = 0x30;
    public const int EC_EXTDEVICE_MODE_CHANGE = 0x31;
    public const int EC_STATE_CHANGE = 0x32;
    public const int EC_GRAPH_CHANGED = 0x50;
    public const int EC_CLOCK_UNSET = 0x51;
    public const int EC_VMR_RENDERDEVICE_SET = 0x53;
    public const int VMR_RENDER_DEVICE_OVERLAY = 0x01;
    public const int VMR_RENDER_DEVICE_VIDMEM = 0x02;
    public const int VMR_RENDER_DEVICE_SYSMEM = 0x04;
    public const int EC_VMR_SURFACE_FLIPPED = 0x54;
    public const int EC_VMR_RECONNECTION_FAILED = 0x55;
    public const int EC_PREPROCESS_COMPLETE = 0x56;
    public const int EC_CODECAPI_EVENT = 0x57;
    public const int EC_WMT_EVENT_BASE = 0x0251;
    public const int EC_BUILT = 0x300;
    public const int EC_UNBUILT = 0x301;
    public const int VFW_FIRST_CODE = 0x200;
    public const int MAX_ERROR_TEXT_LEN = 160;
    public const int ED_BASE = 0x1000;
    public const int DEV_PORT_SIM = 1;
    public const int DEV_PORT_COM1 = 2; // standard serial ports
    public const int DEV_PORT_COM2 = 3;
    public const int DEV_PORT_COM3 = 4;
    public const int DEV_PORT_COM4 = 5;
    public const int DEV_PORT_DIAQ = 6; // Diaquest driver
    public const int DEV_PORT_ARTI = 7; // ARTI driver
    public const int DEV_PORT_1394 = 8; // IEEE 1394 Bus
    public const int DEV_PORT_1394 = 8; // IEEE 1394 Serial Bus
    public const int DEV_PORT_USB = 9; // Universal Serial Bus
    public const int ED_TOP = 0x0001;
    public const int ED_MIDDLE = 0x0002;
    public const int ED_BOTTOM = 0x0004; // OR'd with
    public const int ED_BOTTOM = 0x0004; // or�d  with
    public const int ED_LEFT = 0x0100;
    public const int ED_CENTER = 0x0200;
    public const int ED_RIGHT = 0x0400;
    public const int ED_AUDIO_ALL = 0x10000000; //  or any of the following OR'd together
    public const int ED_AUDIO_ALL = 0x10000000; //    or any of the following OR'd together
    public const int ED_AUDIO_1 = 0x0000001;
    public const int ED_AUDIO_2 = 0x0000002;
    public const int ED_AUDIO_3 = 0x0000004;
    public const int ED_AUDIO_4 = 0x0000008;
    public const int ED_AUDIO_5 = 0x0000010;
    public const int ED_AUDIO_6 = 0x0000020;
    public const int ED_AUDIO_7 = 0x0000040;
    public const int ED_AUDIO_8 = 0x0000080;
    public const int ED_AUDIO_9 = 0x0000100;
    public const int ED_AUDIO_10 = 0x0000200;
    public const int ED_AUDIO_11 = 0x0000400;
    public const int ED_AUDIO_12 = 0x0000800;
    public const int ED_AUDIO_13 = 0x0001000;
    public const int ED_AUDIO_14 = 0x0002000;
    public const int ED_AUDIO_15 = 0x0004000;
    public const int ED_AUDIO_16 = 0x0008000;
    public const int ED_AUDIO_17 = 0x0010000;
    public const int ED_AUDIO_18 = 0x0020000;
    public const int ED_AUDIO_19 = 0x0040000;
    public const int ED_AUDIO_20 = 0x0080000;
    public const int ED_AUDIO_21 = 0x0100000;
    public const int ED_AUDIO_22 = 0x0200000;
    public const int ED_AUDIO_23 = 0x0400000;
    public const int ED_AUDIO_24 = 0x0800000;
    public const int ED_VIDEO = 0x2000000; // for Edit props below
    public const int EC_DVDBASE = 0x0100;
    public const int OATRUE = -1;
    public const int OAFALSE = 0;
    public const int _FACDS = 0x878; // DirectSound's facility code
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_LOCHARDWARE = 0x00000001;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_LOCSOFTWARE = 0x00000002;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSCFX_LOCHARDWARE = 0x00000001;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSCFX_LOCSOFTWARE = 0x00000002;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSCFXR_LOCHARDWARE = 0x00000010;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSCFXR_LOCSOFTWARE = 0x00000020;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXGARGLE_WAVE_TRIANGLE = 0;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXGARGLE_WAVE_SQUARE = 1;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXGARGLE_RATEHZ_MIN = 1;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXGARGLE_RATEHZ_MAX = 1000;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXCHORUS_WAVE_TRIANGLE = 0;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXCHORUS_WAVE_SIN = 1;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCHORUS_WETDRYMIX_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCHORUS_WETDRYMIX_MAX = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCHORUS_DEPTH_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCHORUS_DEPTH_MAX = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCHORUS_FEEDBACK_MIN = -99.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCHORUS_FEEDBACK_MAX = 99.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCHORUS_FREQUENCY_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCHORUS_FREQUENCY_MAX = 10.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCHORUS_DELAY_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCHORUS_DELAY_MAX = 20.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXCHORUS_PHASE_MIN = 0;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXCHORUS_PHASE_MAX = 4;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXCHORUS_PHASE_NEG_180 = 0;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXCHORUS_PHASE_NEG_90 = 1;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXCHORUS_PHASE_ZERO = 2;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXCHORUS_PHASE_90 = 3;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXCHORUS_PHASE_180 = 4;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXFLANGER_WAVE_TRIANGLE = 0;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXFLANGER_WAVE_SIN = 1;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXFLANGER_WETDRYMIX_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXFLANGER_WETDRYMIX_MAX = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXFLANGER_FREQUENCY_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXFLANGER_FREQUENCY_MAX = 10.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXFLANGER_DEPTH_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXFLANGER_DEPTH_MAX = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXFLANGER_PHASE_MIN = 0;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXFLANGER_PHASE_MAX = 4;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXFLANGER_FEEDBACK_MIN = -99.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXFLANGER_FEEDBACK_MAX = 99.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXFLANGER_DELAY_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXFLANGER_DELAY_MAX = 4.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXFLANGER_PHASE_NEG_180 = 0;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXFLANGER_PHASE_NEG_90 = 1;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXFLANGER_PHASE_ZERO = 2;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXFLANGER_PHASE_90 = 3;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXFLANGER_PHASE_180 = 4;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXECHO_WETDRYMIX_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXECHO_WETDRYMIX_MAX = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXECHO_FEEDBACK_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXECHO_FEEDBACK_MAX = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXECHO_LEFTDELAY_MIN = 1.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXECHO_LEFTDELAY_MAX = 2000.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXECHO_RIGHTDELAY_MIN = 1.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXECHO_RIGHTDELAY_MAX = 2000.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXECHO_PANDELAY_MIN = 0;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFXECHO_PANDELAY_MAX = 1;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXDISTORTION_GAIN_MIN = -60.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXDISTORTION_GAIN_MAX = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXDISTORTION_EDGE_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXDISTORTION_EDGE_MAX = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXDISTORTION_POSTEQCENTERFREQUENCY_MIN = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXDISTORTION_POSTEQCENTERFREQUENCY_MAX = 8000.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXDISTORTION_POSTEQBANDWIDTH_MIN = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXDISTORTION_POSTEQBANDWIDTH_MAX = 8000.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXDISTORTION_PRELOWPASSCUTOFF_MIN = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXDISTORTION_PRELOWPASSCUTOFF_MAX = 8000.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCOMPRESSOR_GAIN_MIN = -60.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCOMPRESSOR_GAIN_MAX = 60.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCOMPRESSOR_ATTACK_MIN = 0.01f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCOMPRESSOR_ATTACK_MAX = 500.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCOMPRESSOR_RELEASE_MIN = 50.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCOMPRESSOR_RELEASE_MAX = 3000.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCOMPRESSOR_THRESHOLD_MIN = -60.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCOMPRESSOR_THRESHOLD_MAX = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCOMPRESSOR_RATIO_MIN = 1.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCOMPRESSOR_RATIO_MAX = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCOMPRESSOR_PREDELAY_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXCOMPRESSOR_PREDELAY_MAX = 4.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXPARAMEQ_CENTER_MIN = 80.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXPARAMEQ_CENTER_MAX = 16000.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXPARAMEQ_BANDWIDTH_MIN = 1.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXPARAMEQ_BANDWIDTH_MAX = 36.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXPARAMEQ_GAIN_MIN = -15.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFXPARAMEQ_GAIN_MAX = 15.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_ROOM_MIN = -10000;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_ROOM_MAX = 0;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_ROOM_DEFAULT = -1000;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_ROOMHF_MIN = -10000;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_ROOMHF_MAX = 0;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_ROOMHF_DEFAULT = -100;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_ROOMROLLOFFFACTOR_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_ROOMROLLOFFFACTOR_MAX = 10.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_ROOMROLLOFFFACTOR_DEFAULT = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_DECAYTIME_MIN = 0.1f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_DECAYTIME_MAX = 20.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_DECAYTIME_DEFAULT = 1.49f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_DECAYHFRATIO_MIN = 0.1f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_DECAYHFRATIO_MAX = 2.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_DECAYHFRATIO_DEFAULT = 0.83f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_REFLECTIONS_MIN = -10000;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_REFLECTIONS_MAX = 1000;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_REFLECTIONS_DEFAULT = -2602;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_REFLECTIONSDELAY_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_REFLECTIONSDELAY_MAX = 0.3f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_REFLECTIONSDELAY_DEFAULT = 0.007f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_REVERB_MIN = -10000;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_REVERB_MAX = 2000;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_REVERB_DEFAULT = 200;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_REVERBDELAY_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_REVERBDELAY_MAX = 0.1f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_REVERBDELAY_DEFAULT = 0.011f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_DIFFUSION_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_DIFFUSION_MAX = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_DIFFUSION_DEFAULT = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_DENSITY_MIN = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_DENSITY_MAX = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_DENSITY_DEFAULT = 100.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_HFREFERENCE_MIN = 20.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_HFREFERENCE_MAX = 20000.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_I3DL2REVERB_HFREFERENCE_DEFAULT = 5000.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_QUALITY_MIN = 0;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_QUALITY_MAX = 3;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSFX_I3DL2REVERB_QUALITY_DEFAULT = 2;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_WAVESREVERB_INGAIN_MIN = -96.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_WAVESREVERB_INGAIN_MAX = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_WAVESREVERB_INGAIN_DEFAULT = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_WAVESREVERB_REVERBMIX_MIN = -96.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_WAVESREVERB_REVERBMIX_MAX = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_WAVESREVERB_REVERBMIX_DEFAULT = 0.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_WAVESREVERB_REVERBTIME_MIN = 0.001f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_WAVESREVERB_REVERBTIME_MAX = 3000.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_WAVESREVERB_REVERBTIME_DEFAULT = 1000.0f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_WAVESREVERB_HIGHFREQRTRATIO_MIN = 0.001f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_WAVESREVERB_HIGHFREQRTRATIO_MAX = 0.999f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const float DSFX_WAVESREVERB_HIGHFREQRTRATIO_DEFAULT = 0.001f;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSCFX_AEC_MODE_PASS_THROUGH = 0x0;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSCFX_AEC_MODE_HALF_DUPLEX = 0x1;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSCFX_AEC_MODE_FULL_DUPLEX = 0x2;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSCFX_AEC_STATUS_HISTORY_UNINITIALIZED = 0x0;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSCFX_AEC_STATUS_HISTORY_CONTINUOUSLY_CONVERGED = 0x1;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSCFX_AEC_STATUS_HISTORY_PREVIOUSLY_DIVERGED = 0x2;
#endif
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSCFX_AEC_STATUS_CURRENTLY_CONVERGED = 0x8;
#endif
    public const int DSCAPS_PRIMARYMONO = 0x00000001;
    public const int DSCAPS_PRIMARYSTEREO = 0x00000002;
    public const int DSCAPS_PRIMARY8BIT = 0x00000004;
    public const int DSCAPS_PRIMARY16BIT = 0x00000008;
    public const int DSCAPS_CONTINUOUSRATE = 0x00000010;
    public const int DSCAPS_EMULDRIVER = 0x00000020;
    public const int DSCAPS_CERTIFIED = 0x00000040;
    public const int DSCAPS_SECONDARYMONO = 0x00000100;
    public const int DSCAPS_SECONDARYSTEREO = 0x00000200;
    public const int DSCAPS_SECONDARY8BIT = 0x00000400;
    public const int DSCAPS_SECONDARY16BIT = 0x00000800;
    public const int DSSCL_NORMAL = 0x00000001;
    public const int DSSCL_PRIORITY = 0x00000002;
    public const int DSSCL_EXCLUSIVE = 0x00000003;
    public const int DSSCL_WRITEPRIMARY = 0x00000004;
    public const int DSSPEAKER_DIRECTOUT = 0x00000000;
    public const int DSSPEAKER_HEADPHONE = 0x00000001;
    public const int DSSPEAKER_MONO = 0x00000002;
    public const int DSSPEAKER_QUAD = 0x00000003;
    public const int DSSPEAKER_STEREO = 0x00000004;
    public const int DSSPEAKER_SURROUND = 0x00000005;
    public const int DSSPEAKER_5POINT1 = 0x00000006;
    public const int DSSPEAKER_7POINT1 = 0x00000007;
    public const int DSSPEAKER_GEOMETRY_MIN = 0x00000005; //   5 degrees
    public const int DSSPEAKER_GEOMETRY_NARROW = 0x0000000A; //  10 degrees
    public const int DSSPEAKER_GEOMETRY_WIDE = 0x00000014; //  20 degrees
    public const int DSSPEAKER_GEOMETRY_MAX = 0x000000B4; // 180 degrees
    public const int DSBCAPS_PRIMARYBUFFER = 0x00000001;
    public const int DSBCAPS_STATIC = 0x00000002;
    public const int DSBCAPS_LOCHARDWARE = 0x00000004;
    public const int DSBCAPS_LOCSOFTWARE = 0x00000008;
    public const int DSBCAPS_CTRL3D = 0x00000010;
    public const int DSBCAPS_CTRLFREQUENCY = 0x00000020;
    public const int DSBCAPS_CTRLPAN = 0x00000040;
    public const int DSBCAPS_CTRLVOLUME = 0x00000080;
    public const int DSBCAPS_CTRLPOSITIONNOTIFY = 0x00000100;
    public const int DSBCAPS_CTRLFX = 0x00000200;
    public const int DSBCAPS_STICKYFOCUS = 0x00004000;
    public const int DSBCAPS_GLOBALFOCUS = 0x00008000;
    public const int DSBCAPS_GETCURRENTPOSITION2 = 0x00010000;
    public const int DSBCAPS_MUTE3DATMAXDISTANCE = 0x00020000;
    public const int DSBCAPS_LOCDEFER = 0x00040000;
    public const int DSBPLAY_LOOPING = 0x00000001;
    public const int DSBPLAY_LOCHARDWARE = 0x00000002;
    public const int DSBPLAY_LOCSOFTWARE = 0x00000004;
    public const int DSBPLAY_TERMINATEBY_TIME = 0x00000008;
    public const int DSBPLAY_TERMINATEBY_DISTANCE = 0x000000010;
    public const int DSBPLAY_TERMINATEBY_PRIORITY = 0x000000020;
    public const int DSBSTATUS_PLAYING = 0x00000001;
    public const int DSBSTATUS_BUFFERLOST = 0x00000002;
    public const int DSBSTATUS_LOOPING = 0x00000004;
    public const int DSBSTATUS_LOCHARDWARE = 0x00000008;
    public const int DSBSTATUS_LOCSOFTWARE = 0x00000010;
    public const int DSBSTATUS_TERMINATED = 0x00000020;
    public const int DSBLOCK_FROMWRITECURSOR = 0x00000001;
    public const int DSBLOCK_ENTIREBUFFER = 0x00000002;
    public const int DSBFREQUENCY_ORIGINAL = 0;
    public const int DSBFREQUENCY_MIN = 100;
#if DIRECTSOUND_VERSION >= 0x0900
    public const int DSBFREQUENCY_MAX = 200000;
#else
    public const int DSBFREQUENCY_MAX = 100000;
#endif
    public const int DSBPAN_LEFT = -10000;
    public const int DSBPAN_CENTER = 0;
    public const int DSBPAN_RIGHT = 10000;
    public const int DSBVOLUME_MIN = -10000;
    public const int DSBVOLUME_MAX = 0;
    public const int DSBSIZE_MIN = 4;
    public const int DSBSIZE_MAX = 0x0FFFFFFF;
    public const int DSBSIZE_FX_MIN = 150; // NOTE: Milliseconds, not bytes
    public const int DS3DMODE_NORMAL = 0x00000000;
    public const int DS3DMODE_HEADRELATIVE = 0x00000001;
    public const int DS3DMODE_DISABLE = 0x00000002;
    public const int DS3D_IMMEDIATE = 0x00000000;
    public const int DS3D_DEFERRED = 0x00000001;
    public const float DS3D_DEFAULTDISTANCEFACTOR = 1.0f;
    public const float DS3D_MINROLLOFFFACTOR = 0.0f;
    public const float DS3D_MAXROLLOFFFACTOR = 10.0f;
    public const float DS3D_DEFAULTROLLOFFFACTOR = 1.0f;
    public const float DS3D_MINDOPPLERFACTOR = 0.0f;
    public const float DS3D_MAXDOPPLERFACTOR = 10.0f;
    public const float DS3D_DEFAULTDOPPLERFACTOR = 1.0f;
    public const float DS3D_DEFAULTMINDISTANCE = 1.0f;
    public const float DS3D_DEFAULTMAXDISTANCE = 1000000000.0f;
    public const int DS3D_MINCONEANGLE = 0;
    public const int DS3D_MAXCONEANGLE = 360;
    public const int DS3D_DEFAULTCONEANGLE = 360;
    public const int DSCCAPS_MULTIPLECAPTURE = 0x00000001;
    public const uint DSCBCAPS_WAVEMAPPED = 0x80000000;
#if DIRECTSOUND_VERSION >= 0x0800
    public const int DSCBCAPS_CTRLFX = 0x00000200;
#endif
    public const int DSCBLOCK_ENTIREBUFFER = 0x00000001;
    public const int DSCBSTATUS_CAPTURING = 0x00000001;
    public const int DSCBSTATUS_LOOPING = 0x00000002;
    public const int DSCBSTART_LOOPING = 0x00000001;
    public const uint DSBPN_OFFSETSTOP = 0xFFFFFFFF;
    public const int DS_CERTIFIED = 0x00000000;
    public const int DS_UNCERTIFIED = 0x00000001;
    public const int DV_DVSD_NTSC_FRAMESIZE = 120000;
    public const int DV_DVSD_PAL_FRAMESIZE = 144000;
    public const int DV_SMCHN = 0x0000e000;
    public const int DV_AUDIOMODE = 0x00000f00;
    public const int DV_AUDIOSMP = 0x38000000;
    public const int DV_AUDIOQU = 0x07000000;
    public const int DV_NTSCPAL = 0x00200000;
    public const int DV_STYPE = 0x001f0000;
    public const int DV_NTSC = 0;
    public const int DV_PAL = 1;
    public const int DV_SD = 0x00;
    public const int DV_HD = 0x01;
    public const int DV_SL = 0x02;
    public const int DV_CAP_AUD16Bits = 0x00;
    public const int DV_CAP_AUD12Bits = 0x01;
    public const int SIZE_DVINFO = 0x20;
    public const int AM_AC3_ALTERNATE_AUDIO_1 = 1;
    public const int AM_AC3_ALTERNATE_AUDIO_2 = 2;
    public const int AM_AC3_ALTERNATE_AUDIO_BOTH = 3;
    public const int AM_AC3_SERVICE_MAIN_AUDIO = 0;
    public const int AM_AC3_SERVICE_NO_DIALOG = 1;
    public const int AM_AC3_SERVICE_VISUALLY_IMPAIRED = 2;
    public const int AM_AC3_SERVICE_HEARING_IMPAIRED = 3;
    public const int AM_AC3_SERVICE_DIALOG_ONLY = 4;
    public const int AM_AC3_SERVICE_COMMENTARY = 5;
    public const int AM_AC3_SERVICE_EMERGENCY_FLASH = 6;
    public const int AM_AC3_SERVICE_VOICE_OVER = 7;
    public const int AM_UseNewCSSKey = 0x1;
    public const int AM_DVD_CGMS_RESERVED_MASK = 0x00000078;
    public const int AM_DVD_CGMS_COPY_PROTECT_MASK = 0x00000018;
    public const int AM_DVD_CGMS_COPY_PERMITTED = 0x00000000;
    public const int AM_DVD_CGMS_COPY_ONCE = 0x00000010;
    public const int AM_DVD_CGMS_NO_COPY = 0x00000018;
    public const int AM_DVD_COPYRIGHT_MASK = 0x00000040;
    public const int AM_DVD_NOT_COPYRIGHTED = 0x00000000;
    public const int AM_DVD_COPYRIGHTED = 0x00000040;
    public const int AM_DVD_SECTOR_PROTECT_MASK = 0x00000020;
    public const int AM_DVD_SECTOR_NOT_PROTECTED = 0x00000000;
    public const int AM_DVD_SECTOR_PROTECTED = 0x00000020;
    public const int AMINTERLACE_IsInterlaced = 0x00000001; // if 0, other interlace bits are irrelevent
    public const int AMINTERLACE_1FieldPerSample = 0x00000002; // else 2 fields per media sample
    public const int AMINTERLACE_Field1First = 0x00000004; // else Field 2 is first;  top field in PAL is field 1, top field in NTSC is field 2?
    public const int AMINTERLACE_UNUSED = 0x00000008;
    public const int AMINTERLACE_FieldPatternMask = 0x00000030; // use this mask with AMINTERLACE_FieldPat*
    public const int AMINTERLACE_FieldPatField1Only = 0x00000000; // stream never contains a Field2
    public const int AMINTERLACE_FieldPatField2Only = 0x00000010; // stream never contains a Field1
    public const int AMINTERLACE_FieldPatBothRegular = 0x00000020; // There will be a Field2 for every Field1 (required for Weave?)
    public const int AMINTERLACE_FieldPatBothIrregular = 0x00000030; // Random pattern of Field1s and Field2s
    public const int AMINTERLACE_DisplayModeMask = 0x000000c0;
    public const int AMINTERLACE_DisplayModeBobOnly = 0x00000000;
    public const int AMINTERLACE_DisplayModeWeaveOnly = 0x00000040;
    public const int AMINTERLACE_DisplayModeBobOrWeave = 0x00000080;
    public const int AMCOPYPROTECT_RestrictDuplication = 0x00000001; // duplication of this stream should be restricted
    public const int AMMPEG2_DoPanScan = 0x00000001; // if set, the MPEG-2 video decoder should crop output image
    public const int AMMPEG2_DVDLine21Field1 = 0x00000002; // if set, the MPEG-2 decoder must be able to produce an output
    public const int AMMPEG2_DVDLine21Field2 = 0x00000004; // if set, the MPEG-2 decoder must be able to produce an output
    public const int AMMPEG2_SourceIsLetterboxed = 0x00000008; // if set, indicates that black bars have been encoded in the top
    public const int AMMPEG2_FilmCameraMode = 0x00000010; // if set, indicates "film mode" used for 625/50 content.  If cleared,
    public const int AMMPEG2_LetterboxAnalogOut = 0x00000020; // if set and this stream is sent to an analog output, it should
    public const int AMMPEG2_DSS_UserData = 0x00000040; // if set, the MPEG-2 decoder must process DSS style user data
    public const int AMMPEG2_DVB_UserData = 0x00000080; // if set, the MPEG-2 decoder must process DVB style user data
    public const int AMMPEG2_27MhzTimebase = 0x00000100; // if set, the PTS,DTS timestamps advance at 27MHz rather than 90KHz
    public const int AMMPEG2_WidescreenAnalogOut = 0x00000200; // if set and this stream is sent to an analog output, it should
    public const int AMCONTROL_USED = 0x00000001; // Used to test if these flags are supported.  Set and test for AcceptMediaType.
    public const int AMCONTROL_PAD_TO_4x3 = 0x00000002; // if set means display the image in a 4x3 area
    public const int AMCONTROL_PAD_TO_16x9 = 0x00000004; // if set means display the image in a 16x9 area
    public const int AM_VIDEO_FLAG_FIELD_MASK = 0x0003; // use this mask to check whether the sample is field1 or field2 or frame
    public const int AM_VIDEO_FLAG_INTERLEAVED_FRAME = 0x0000; // the sample is a frame (remember to use AM_VIDEO_FLAG_FIELD_MASK when using this)
    public const int AM_VIDEO_FLAG_FIELD1 = 0x0001; // the sample is field1 (remember to use AM_VIDEO_FLAG_FIELD_MASK when using this)
    public const int AM_VIDEO_FLAG_FIELD2 = 0x0002; // the sample is the field2 (remember to use AM_VIDEO_FLAG_FIELD_MASK when using this)
    public const int AM_VIDEO_FLAG_FIELD1FIRST = 0x0004; // if set means display field1 first, else display field2 first.
    public const int AM_VIDEO_FLAG_WEAVE = 0x0008; // if set use bob display mode else weave
    public const int AM_VIDEO_FLAG_IPB_MASK = 0x0030; // use this mask to check whether the sample is I, P or B
    public const int AM_VIDEO_FLAG_I_SAMPLE = 0x0000; // I Sample (remember to use AM_VIDEO_FLAG_IPB_MASK when using this)
    public const int AM_VIDEO_FLAG_P_SAMPLE = 0x0010; // P Sample (remember to use AM_VIDEO_FLAG_IPB_MASK when using this)
    public const int AM_VIDEO_FLAG_B_SAMPLE = 0x0020; // B Sample (remember to use AM_VIDEO_FLAG_IPB_MASK when using this)
    public const int AM_VIDEO_FLAG_REPEAT_FIELD = 0x0040; // if set means display the field which has been displayed first again after displaying
    public const int DVMSGID_BASE = 0x0000;
    public const int DVBUFFERAGGRESSIVENESS_MIN = 0x00000001;
    public const int DVBUFFERAGGRESSIVENESS_MAX = 0x00000064;
    public const int DVBUFFERAGGRESSIVENESS_DEFAULT = 0x00000000;
    public const int DVBUFFERQUALITY_MIN = 0x00000001;
    public const int DVBUFFERQUALITY_MAX = 0x00000064;
    public const int DVBUFFERQUALITY_DEFAULT = 0x00000000;
    public const int DVID_SYS = 0;
    public const int DVID_SERVERPLAYER = 1;
    public const int DVID_ALLPLAYERS = 0;
    public const uint DVID_REMAINING = 0xFFFFFFFF;
    public const int DVINPUTLEVEL_MIN = 0x00000000;
    public const int DVINPUTLEVEL_MAX = 0x00000063; // 99 decimal
    public const int DVNOTIFYPERIOD_MINPERIOD = 20;
    public const int DVRECORDVOLUME_LAST = 0x00000001;
    public const uint DVTHRESHOLD_DEFAULT = 0xFFFFFFFF;
    public const int DVTHRESHOLD_MIN = 0x00000000;
    public const int DVTHRESHOLD_MAX = 0x00000063; // 99 decimal
    public const uint DVTHRESHOLD_UNUSED = 0xFFFFFFFE;
    public const int DVSESSIONTYPE_PEER = 0x00000001;
    public const int DVSESSIONTYPE_MIXING = 0x00000002;
    public const int DVSESSIONTYPE_FORWARDING = 0x00000003;
    public const int DVSESSIONTYPE_ECHO = 0x00000004;
    public const int DVCLIENTCONFIG_AUTORECORDVOLUME = 0x00000008;
    public const int DVCLIENTCONFIG_AUTOVOICEACTIVATED = 0x00000020;
    public const int DVCLIENTCONFIG_ECHOSUPPRESSION = 0x08000000;
    public const int DVCLIENTCONFIG_MANUALVOICEACTIVATED = 0x00000004;
    public const int DVCLIENTCONFIG_MUTEGLOBAL = 0x00000010;
    public const int DVCLIENTCONFIG_PLAYBACKMUTE = 0x00000002;
    public const int DVCLIENTCONFIG_RECORDMUTE = 0x00000001;
    public const int DVFLAGS_SYNC = 0x00000001;
    public const int DVFLAGS_QUERYONLY = 0x00000002;
    public const int DVFLAGS_NOHOSTMIGRATE = 0x00000008;
    public const int DVFLAGS_ALLOWBACK = 0x00000010;
    public const int DVSESSION_NOHOSTMIGRATION = 0x00000001;
    public const int DVSESSION_SERVERCONTROLTARGET = 0x00000002;
    public const int DVSOUNDCONFIG_NORMALMODE = 0x00000001;
    public const int DVSOUNDCONFIG_AUTOSELECT = 0x00000002;
    public const int DVSOUNDCONFIG_HALFDUPLEX = 0x00000004;
    public const int DVSOUNDCONFIG_NORECVOLAVAILABLE = 0x00000010;
    public const int DVSOUNDCONFIG_NOFOCUS = 0x20000000;
    public const int DVSOUNDCONFIG_SETCONVERSIONQUALITY = 0x00000008;
    public const int DVSOUNDCONFIG_STRICTFOCUS = 0x40000000;
    public const int DVPLAYERCAPS_HALFDUPLEX = 0x00000001;
    public const int DVPLAYERCAPS_LOCAL = 0x00000002;
    public const int _FACDPV = 0x15;
#if ! GUID_DEFS_ONLY
    public const int DDVPD_WIDTH = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPD_HEIGHT = 0x00000002;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPD_ID = 0x00000004;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPD_CAPS = 0x00000008;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPD_FX = 0x00000010;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPD_AUTOFLIP = 0x00000020;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPD_ALIGN = 0x00000040;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPD_PREFERREDAUTOFLIP = 0x00000080;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPD_FILTERQUALITY = 0x00000100;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCONNECT_DOUBLECLOCK = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCONNECT_VACT = 0x00000002;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCONNECT_INVERTPOLARITY = 0x00000004;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCONNECT_DISCARDSVREFDATA = 0x00000008;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCONNECT_HALFLINE = 0x00000010;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCONNECT_INTERLACED = 0x00000020;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCONNECT_SHAREEVEN = 0x00000040;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCONNECT_SHAREODD = 0x00000080;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_AUTOFLIP = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_INTERLACED = 0x00000002;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_NONINTERLACED = 0x00000004;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_READBACKFIELD = 0x00000008;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_READBACKLINE = 0x00000010;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_SHAREABLE = 0x00000020;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_SKIPEVENFIELDS = 0x00000040;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_SKIPODDFIELDS = 0x00000080;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_SYNCMASTER = 0x00000100;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_VBISURFACE = 0x00000200;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_COLORCONTROL = 0x00000400;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_OVERSAMPLEDVBI = 0x00000800;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_SYSTEMMEMORY = 0x00001000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_VBIANDVIDEOINDEPENDENT = 0x00002000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCAPS_HARDWAREDEINTERLACE = 0x00004000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_CROPTOPDATA = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_CROPX = 0x00000002;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_CROPY = 0x00000004;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_INTERLEAVE = 0x00000008;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_MIRRORLEFTRIGHT = 0x00000010;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_MIRRORUPDOWN = 0x00000020;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_PRESHRINKX = 0x00000040;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_PRESHRINKY = 0x00000080;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_PRESHRINKXB = 0x00000100;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_PRESHRINKYB = 0x00000200;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_PRESHRINKXS = 0x00000400;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_PRESHRINKYS = 0x00000800;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_PRESTRETCHX = 0x00001000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_PRESTRETCHY = 0x00002000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_PRESTRETCHXN = 0x00004000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_PRESTRETCHYN = 0x00008000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_VBICONVERT = 0x00010000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_VBINOSCALE = 0x00020000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_IGNOREVBIXCROP = 0x00040000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFX_VBINOINTERLEAVE = 0x00080000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_AUTOFLIP = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_CONVERT = 0x00000002;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_CROP = 0x00000004;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_INTERLEAVE = 0x00000008;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_MIRRORLEFTRIGHT = 0x00000010;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_MIRRORUPDOWN = 0x00000020;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_PRESCALE = 0x00000040;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_SKIPEVENFIELDS = 0x00000080;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_SKIPODDFIELDS = 0x00000100;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_SYNCMASTER = 0x00000200;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_VBICONVERT = 0x00000400;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_VBINOSCALE = 0x00000800;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_OVERRIDEBOBWEAVE = 0x00001000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_IGNOREVBIXCROP = 0x00002000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_VBINOINTERLEAVE = 0x00004000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVP_HARDWAREDEINTERLACE = 0x00008000;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFORMAT_VIDEO = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFORMAT_VBI = 0x00000002;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPTARGET_VIDEO = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPTARGET_VBI = 0x00000002;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPWAIT_BEGIN = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPWAIT_END = 0x00000002;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPWAIT_LINE = 0x00000003;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFLIP_VIDEO = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPFLIP_VBI = 0x00000002;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPSQ_NOSIGNAL = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPSQ_SIGNALOK = 0x00000002;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPB_VIDEOPORT = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPB_OVERLAY = 0x00000002;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPB_TYPE = 0x00000004;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPBCAPS_SOURCE = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPBCAPS_DESTINATION = 0x00000002;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCREATE_VBIONLY = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPCREATE_VIDEOONLY = 0x00000002;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPSTATUS_VBIONLY = 0x00000001;
#endif
#if ! GUID_DEFS_ONLY
    public const int DDVPSTATUS_VIDEOONLY = 0x00000002;
#endif
    public const int DXDIAG_DX9_SDK_VERSION = 111;
    public const int DXTRANS_TLB_MAJOR_VER = 1;
    public const int DXTRANS_TLB_MINOR_VER = 1;
    public const int DX_MAX_RUN_INFO_COUNT =  128 ;
    public const int DXVA_RESTRICTED_MODE_UNRESTRICTED = 0xFFFF;
    public const int DXVA_RESTRICTED_MODE_H261_A = 1;
    public const int DXVA_RESTRICTED_MODE_H261_B = 2;
    public const int DXVA_RESTRICTED_MODE_H263_A = 3;
    public const int DXVA_RESTRICTED_MODE_H263_B = 4;
    public const int DXVA_RESTRICTED_MODE_H263_C = 5;
    public const int DXVA_RESTRICTED_MODE_H263_D = 6;
    public const int DXVA_RESTRICTED_MODE_H263_E = 7;
    public const int DXVA_RESTRICTED_MODE_H263_F = 8;
    public const int DXVA_RESTRICTED_MODE_MPEG1_A = 9;
    public const int DXVA_RESTRICTED_MODE_MPEG2_A = 0xA;
    public const int DXVA_RESTRICTED_MODE_MPEG2_B = 0xB;
    public const int DXVA_RESTRICTED_MODE_MPEG2_C = 0xC;
    public const int DXVA_RESTRICTED_MODE_MPEG2_D = 0xD;
    public const int DXVA_RESTRICTED_MODE_WMV8_A = 0x80;
    public const int DXVA_RESTRICTED_MODE_WMV8_B = 0x81;
    public const int DXVA_RESTRICTED_MODE_WMV9_A = 0x90;
    public const int DXVA_RESTRICTED_MODE_WMV9_B = 0x91;
    public const int DXVA_RESTRICTED_MODE_WMV9_Ai = 0x92;
    public const int DXVA_RESTRICTED_MODE_WMV9_Bi = 0x93;
    public const int DXVA_COMPBUFFER_TYPE_THAT_IS_NOT_USED = 0;
    public const int DXVA_PICTURE_DECODE_BUFFER = 1;
    public const int DXVA_MACROBLOCK_CONTROL_BUFFER = 2;
    public const int DXVA_RESIDUAL_DIFFERENCE_BUFFER = 3;
    public const int DXVA_DEBLOCKING_CONTROL_BUFFER = 4;
    public const int DXVA_INVERSE_QUANTIZATION_MATRIX_BUFFER = 5;
    public const int DXVA_SLICE_CONTROL_BUFFER = 6;
    public const int DXVA_BITSTREAM_DATA_BUFFER = 7;
    public const int DXVA_AYUV_BUFFER = 8;
    public const int DXVA_IA44_SURFACE_BUFFER = 9;
    public const int DXVA_DPXD_SURFACE_BUFFER = 10;
    public const int DXVA_HIGHLIGHT_BUFFER = 11;
    public const int DXVA_DCCMD_SURFACE_BUFFER = 12;
    public const int DXVA_ALPHA_BLEND_COMBINATION_BUFFER = 13;
    public const int DXVA_PICTURE_RESAMPLE_BUFFER = 14;
    public const int DXVA_READ_BACK_BUFFER = 15;
    public const int DXVA_NUM_TYPES_COMP_BUFFERS = 16;
    public const int DXVA_PICTURE_DECODING_FUNCTION = 1;
    public const int DXVA_ALPHA_BLEND_DATA_LOAD_FUNCTION = 2;
    public const int DXVA_ALPHA_BLEND_COMBINATION_FUNCTION = 3;
    public const int DXVA_PICTURE_RESAMPLE_FUNCTION = 4;
    public const int DXVA_EXECUTE_RETURN_OK = 0;
    public const int DXVA_EXECUTE_RETURN_DATA_ERROR_MINOR = 1;
    public const int DXVA_EXECUTE_RETURN_DATA_ERROR_SIGNIF = 2;
    public const int DXVA_EXECUTE_RETURN_DATA_ERROR_SEVERE = 3;
    public const int DXVA_EXECUTE_RETURN_OTHER_ERROR_SEVERE = 4;
    public const int DXVA_QUERYORREPLYFUNCFLAG_DECODER_PROBE_QUERY = 0xFFFFF1;
    public const int DXVA_QUERYORREPLYFUNCFLAG_DECODER_LOCK_QUERY = 0xFFFFF5;
    public const int DXVA_QUERYORREPLYFUNCFLAG_ACCEL_PROBE_OK_COPY = 0xFFFFF8;
    public const int DXVA_QUERYORREPLYFUNCFLAG_ACCEL_PROBE_OK_PLUS = 0xFFFFF9;
    public const int DXVA_QUERYORREPLYFUNCFLAG_ACCEL_LOCK_OK_COPY = 0xFFFFFC;
    public const int DXVA_QUERYORREPLYFUNCFLAG_ACCEL_PROBE_FALSE_PLUS = 0xFFFFFB;
    public const int DXVA_QUERYORREPLYFUNCFLAG_ACCEL_LOCK_FALSE_PLUS = 0xFFFFFF;
    public const int DXVA_ENCRYPTPROTOCOLFUNCFLAG_HOST = 0xFFFF00;
    public const int DXVA_ENCRYPTPROTOCOLFUNCFLAG_ACCEL = 0xFFFF08;
    public const int DXVA_CHROMA_FORMAT_420 = 1;
    public const int DXVA_CHROMA_FORMAT_422 = 2;
    public const int DXVA_CHROMA_FORMAT_444 = 3;
    public const int DXVA_PICTURE_STRUCTURE_TOP_FIELD = 1;
    public const int DXVA_PICTURE_STRUCTURE_BOTTOM_FIELD = 2;
    public const int DXVA_PICTURE_STRUCTURE_FRAME = 3;
    public const int DXVA_BIDIRECTIONAL_AVERAGING_MPEG2_ROUND = 0;
    public const int DXVA_BIDIRECTIONAL_AVERAGING_H263_TRUNC = 1;
    public const int DXVA_MV_PRECISION_AND_CHROMA_RELATION_MPEG2 = 0;
    public const int DXVA_MV_PRECISION_AND_CHROMA_RELATION_H263 = 1;
    public const int DXVA_MV_PRECISION_AND_CHROMA_RELATION_H261 = 2;
    public const int DXVA_SCAN_METHOD_ZIG_ZAG = 0;
    public const int DXVA_SCAN_METHOD_ALTERNATE_VERTICAL = 1;
    public const int DXVA_SCAN_METHOD_ALTERNATE_HORIZONTAL = 2;
    public const int DXVA_SCAN_METHOD_ARBITRARY = 3;
    public const int DXVA_BITSTREAM_CONCEALMENT_NEED_UNLIKELY = 0;
    public const int DXVA_BITSTREAM_CONCEALMENT_NEED_MILD = 1;
    public const int DXVA_BITSTREAM_CONCEALMENT_NEED_LIKELY = 2;
    public const int DXVA_BITSTREAM_CONCEALMENT_NEED_SEVERE = 3;
    public const int DXVA_BITSTREAM_CONCEALMENT_METHOD_UNSPECIFIED = 0;
    public const int DXVA_BITSTREAM_CONCEALMENT_METHOD_INTRA = 1;
    public const int DXVA_BITSTREAM_CONCEALMENT_METHOD_FORWARD = 2;
    public const int DXVA_BITSTREAM_CONCEALMENT_METHOD_BACKWARD = 3;
    public const int DXVA_USUAL_BLOCK_WIDTH = 8;
    public const int DXVA_USUAL_BLOCK_HEIGHT = 8;
    public const int DXVA_NumMV_OBMC_off_BinPBwith4MV_off = 4;
    public const int DXVA_NumMV_OBMC_off_BinPBwith4MV_on = 4 + 1;
    public const int DXVA_NumMV_OBMC_on__BinPB_off = 10;
    public const int DXVA_NumMV_OBMC_on__BinPB_on = 11; // not current standards
    public const int DXVA_NumBlocksPerMB_420 = 4 + 2 + 0;
    public const int DXVA_NumBlocksPerMB_422 = 4 + 2 + 2;
    public const int DXVA_NumBlocksPerMB_444 = 4 + 4 + 4;
    public const int DXVA_CONFIG_DATA_TYPE_IA44 = 0;
    public const int DXVA_CONFIG_DATA_TYPE_AI44 = 1;
    public const int DXVA_CONFIG_DATA_TYPE_DPXD = 2;
    public const int DXVA_CONFIG_DATA_TYPE_AYUV = 3;
    public const int DXVA_CONFIG_BLEND_TYPE_FRONT_BUFFER = 0;
    public const int DXVA_CONFIG_BLEND_TYPE_BACK_HARDWARE = 1;
    public const int DXVA_ExtColorData_ShiftBase = 16;
    public const int MAX_DEINTERLACE_SURFACES = 32;
    public const int DXVA_DeinterlaceBltFnCode = 0x01;
    public const int DXVA_DeinterlaceBltExFnCode = 0x02;
    public const int MAX_DEINTERLACE_DEVICE_GUIDS = 32;
    public const int DXVA_DeinterlaceQueryAvailableModesFnCode = 0x01;
    public const int DXVA_DeinterlaceQueryModeCapsFnCode = 0x02;
    public const int DXVA_ProcAmpControlQueryCapsFnCode = 0x03;
    public const int DXVA_ProcAmpControlQueryRangeFnCode = 0x04;
    public const int DXVA_ProcAmpControlBltFnCode = 0x01;
    public const int DXVA_COPPGetCertificateLengthFnCode = 0x01;
    public const int DXVA_COPPKeyExchangeFnCode = 0x02;
    public const int DXVA_COPPSequenceStartFnCode = 0x03;
    public const int DXVA_COPPCommandFnCode = 0x04;
    public const int COPP_WSS_FLAG = 0x01; // used with DXVA_COPPSetProtectionLevelCmdData::TypeSpecificInfo
    public const int COPP_NoProtectionLevelAvailable = -1;
    public const int COPP_DefaultProtectionLevel = 0;
    public const int DXVA_COPPQueryStatusFnCode = 0x05;
#if __TCS__
    public const int _KS_NO_ANONYMOUS_STRUCTURES_ = 1;
#endif
    public const int KSPRIORITY_LOW = 0x00000001;
    public const int KSPRIORITY_NORMAL = 0x40000000;
    public const uint KSPRIORITY_HIGH = 0x80000000;
    public const uint KSPRIORITY_EXCLUSIVE = 0xFFFFFFFF;
#if _INC_MMSYSTEM || _INC_MMREG
    public const int WAVE_FORMAT_EXTENSIBLE = 0xFFFE;
#endif
    public const int KSDSOUND_BUFFER_PRIMARY = 0x00000001;
    public const int KSDSOUND_BUFFER_STATIC = 0x00000002;
    public const int KSDSOUND_BUFFER_LOCHARDWARE = 0x00000004;
    public const int KSDSOUND_BUFFER_LOCSOFTWARE = 0x00000008;
    public const int KSDSOUND_BUFFER_CTRL_3D = 0x00000001;
    public const int KSDSOUND_BUFFER_CTRL_FREQUENCY = 0x00000002;
    public const int KSDSOUND_BUFFER_CTRL_PAN = 0x00000004;
    public const int KSDSOUND_BUFFER_CTRL_VOLUME = 0x00000008;
    public const int KSDSOUND_BUFFER_CTRL_POSITIONNOTIFY = 0x00000010;
    public const int KSAUDIO_STEREO_SPEAKER_GEOMETRY_HEADPHONE = -1;
    public const int KSAUDIO_STEREO_SPEAKER_GEOMETRY_MIN = 5;
    public const int KSAUDIO_STEREO_SPEAKER_GEOMETRY_NARROW = 10;
    public const int KSAUDIO_STEREO_SPEAKER_GEOMETRY_WIDE = 20;
    public const int KSAUDIO_STEREO_SPEAKER_GEOMETRY_MAX = 180;
    public const int KSDSOUND_3D_MODE_NORMAL = 0x00000000;
    public const int KSDSOUND_3D_MODE_HEADRELATIVE = 0x00000001;
    public const int KSDSOUND_3D_MODE_DISABLE = 0x00000002;
    public const int KSAUDIO_QUALITY_WORST = 0x0;
    public const int KSAUDIO_QUALITY_PC = 0x1;
    public const int KSAUDIO_QUALITY_BASIC = 0x2;
    public const int KSAUDIO_QUALITY_ADVANCED = 0x3;
    public const int KSAUDIO_CPU_RESOURCES_NOT_HOST_CPU = 0x00000000;
    public const int KSAUDIO_CPU_RESOURCES_HOST_CPU = 0x7FFFFFFF;
    public const int SPEAKER_FRONT_LEFT = 0x1;
    public const int SPEAKER_FRONT_RIGHT = 0x2;
    public const int SPEAKER_FRONT_CENTER = 0x4;
    public const int SPEAKER_LOW_FREQUENCY = 0x8;
    public const int SPEAKER_BACK_LEFT = 0x10;
    public const int SPEAKER_BACK_RIGHT = 0x20;
    public const int SPEAKER_FRONT_LEFT_OF_CENTER = 0x40;
    public const int SPEAKER_FRONT_RIGHT_OF_CENTER = 0x80;
    public const int SPEAKER_BACK_CENTER = 0x100;
    public const int SPEAKER_SIDE_LEFT = 0x200;
    public const int SPEAKER_SIDE_RIGHT = 0x400;
    public const int SPEAKER_TOP_CENTER = 0x800;
    public const int SPEAKER_TOP_FRONT_LEFT = 0x1000;
    public const int SPEAKER_TOP_FRONT_CENTER = 0x2000;
    public const int SPEAKER_TOP_FRONT_RIGHT = 0x4000;
    public const int SPEAKER_TOP_BACK_LEFT = 0x8000;
    public const int SPEAKER_TOP_BACK_CENTER = 0x10000;
    public const int SPEAKER_TOP_BACK_RIGHT = 0x20000;
    public const int SPEAKER_RESERVED = 0x7FFC0000;
    public const uint SPEAKER_ALL = 0x80000000;
    public const int KSAUDIO_SPEAKER_DIRECTOUT = 0;
    public const int KSNODEPIN_STANDARD_IN = 1;
    public const int KSNODEPIN_STANDARD_OUT = 0;
    public const int KSNODEPIN_SUM_MUX_IN = 1; // can be >= 1
    public const int KSNODEPIN_SUM_MUX_OUT = 0;
    public const int KSNODEPIN_DEMUX_IN = 0;
    public const int KSNODEPIN_DEMUX_OUT = 1; // can be >= 1
    public const int KSNODEPIN_AEC_RENDER_IN = 1;
    public const int KSNODEPIN_AEC_RENDER_OUT = 0;
    public const int KSNODEPIN_AEC_CAPTURE_IN = 2;
    public const int KSNODEPIN_AEC_CAPTURE_OUT = 3;
    public const int AEC_STATUS_FD_HISTORY_UNINITIALIZED = 0x0;
    public const int AEC_STATUS_FD_HISTORY_CONTINUOUSLY_CONVERGED = 0x1;
    public const int AEC_STATUS_FD_HISTORY_PREVIOUSLY_DIVERGED = 0x2;
    public const int AEC_STATUS_FD_CURRENTLY_CONVERGED = 0x8;
    public const int AEC_MODE_PASS_THROUGH = 0x0;
    public const int AEC_MODE_HALF_DUPLEX = 0x1;
    public const int AEC_MODE_FULL_DUPLEX = 0x2;
    public const int KSPROPERTY_WAVE_QUEUED_POSITION = 0x00000001;
    public const int KSMETHOD_WAVE_QUEUED_BREAKLOOP = 0x00000001;
    public const int KSWAVE_COMPATCAPS_INPUT = 0x00000000;
    public const int KSWAVE_COMPATCAPS_OUTPUT = 0x00000001;
    public const int KSWAVE_BUFFER_ATTRIBUTEF_LOOPING = 0x00000001;
    public const int KSWAVE_BUFFER_ATTRIBUTEF_STATIC = 0x00000002;
    public const int GFX_DEVICETYPE_RENDER = 1;
    public const int GFX_DEVICETYPE_CAPTURE = 2;
    public const int SYSAUDIO_FLAGS_DONT_COMBINE_PINS = 0x00000001;
    public const int SYSAUDIO_FLAGS_CLEAR_PREFERRED = 0x00000002;
    public const int KSMPEGVIDMODE_PANSCAN = 0x0001;
    public const int KSMPEGVIDMODE_LTRBOX = 0x0002;
    public const int KSMPEGVIDMODE_SCALE = 0x0004;
    public const int KSAC3_ALTERNATE_AUDIO_1 = 1;
    public const int KSAC3_ALTERNATE_AUDIO_2 = 2;
    public const int KSAC3_ALTERNATE_AUDIO_BOTH = 3;
    public const int KSAC3_SERVICE_MAIN_AUDIO = 0;
    public const int KSAC3_SERVICE_NO_DIALOG = 1;
    public const int KSAC3_SERVICE_VISUALLY_IMPAIRED = 2;
    public const int KSAC3_SERVICE_HEARING_IMPAIRED = 3;
    public const int KSAC3_SERVICE_DIALOG_ONLY = 4;
    public const int KSAC3_SERVICE_COMMENTARY = 5;
    public const int KSAC3_SERVICE_EMERGENCY_FLASH = 6;
    public const int KSAC3_SERVICE_VOICE_OVER = 7;
    public const int KSAUDDECOUTMODE_STEREO_ANALOG = 0x0001;
    public const int KSAUDDECOUTMODE_PCM_51 = 0x0002;
    public const int KSAUDDECOUTMODE_SPDIFF = 0x0004;
    public const int KS_DVD_CGMS_RESERVED_MASK = 0x00000078;
    public const int KS_DVD_CGMS_COPY_PROTECT_MASK = 0x00000018;
    public const int KS_DVD_CGMS_COPY_PERMITTED = 0x00000000;
    public const int KS_DVD_CGMS_COPY_ONCE = 0x00000010;
    public const int KS_DVD_CGMS_NO_COPY = 0x00000018;
    public const int KS_DVD_COPYRIGHT_MASK = 0x00000040;
    public const int KS_DVD_NOT_COPYRIGHTED = 0x00000000;
    public const int KS_DVD_COPYRIGHTED = 0x00000040;
    public const int KS_DVD_SECTOR_PROTECT_MASK = 0x00000020;
    public const int KS_DVD_SECTOR_NOT_PROTECTED = 0x00000000;
    public const int KS_DVD_SECTOR_PROTECTED = 0x00000020;
    public const int KS_BI_RGB = 0;
    public const int KS_BI_RLE8 = 1;
    public const int KS_BI_RLE4 = 2;
    public const int KS_BI_BITFIELDS = 3;
    public const int KS_iPALETTE_COLORS = 256; // Maximum colours in palette
    public const int KS_iEGA_COLORS = 16; // Number colours in EGA palette
    public const int KS_iMASK_COLORS = 3; // Maximum three components
    public const int KS_iTRUECOLOR = 16; // Minimum true colour device
    public const int KS_iRED = 0; // Index position for RED mask
    public const int KS_iGREEN = 1; // Index position for GREEN mask
    public const int KS_iBLUE = 2; // Index position for BLUE mask
    public const int KS_iPALETTE = 8; // Maximum colour depth using a palette
    public const int KS_iMAXBITS = 8; // Maximum bits per colour component
    public const int KS_TVTUNER_CHANGE_BEGIN_TUNE = 0x0001; // Starting a tuning operation
    public const int KS_TVTUNER_CHANGE_END_TUNE = 0x0002; // Ending a tuning operation
    public const int KS_INTERLACE_IsInterlaced = 0x00000001; // if 0, other interlace bits are irrelevent
    public const int KS_INTERLACE_1FieldPerSample = 0x00000002; // else 2 fields per media sample
    public const int KS_INTERLACE_Field1First = 0x00000004; // else Field 2 is first;  top field in PAL is field 1, top field in NTSC is field 2?
    public const int KS_INTERLACE_UNUSED = 0x00000008;
    public const int KS_INTERLACE_FieldPatternMask = 0x00000030; // use this mask with AMINTERLACE_FieldPat*
    public const int KS_INTERLACE_FieldPatField1Only = 0x00000000; // Data never contains a Field2
    public const int KS_INTERLACE_FieldPatField2Only = 0x00000010; // Data never contains a Field1
    public const int KS_INTERLACE_FieldPatBothRegular = 0x00000020; // There will be a Field2 for every Field1 (required for Weave?)
    public const int KS_INTERLACE_FieldPatBothIrregular = 0x00000030; // Random pattern of Field1s and Field2s
    public const int KS_INTERLACE_DisplayModeMask = 0x000000c0;
    public const int KS_INTERLACE_DisplayModeBobOnly = 0x00000000;
    public const int KS_INTERLACE_DisplayModeWeaveOnly = 0x00000040;
    public const int KS_INTERLACE_DisplayModeBobOrWeave = 0x00000080;
    public const int KS_MPEG2_DoPanScan = 0x00000001; // if set, the MPEG-2 video decoder should crop output image
    public const int KS_MPEG2_DVDLine21Field1 = 0x00000002; // if set, the MPEG-2 decoder must be able to produce an output
    public const int KS_MPEG2_DVDLine21Field2 = 0x00000004; // if set, the MPEG-2 decoder must be able to produce an output
    public const int KS_MPEG2_SourceIsLetterboxed = 0x00000008; // if set, indicates that black bars have been encoded in the top
    public const int KS_MPEG2_FilmCameraMode = 0x00000010; // if set, indicates "film mode" used for 625/50 content.  If cleared,
    public const int KS_MPEG2_LetterboxAnalogOut = 0x00000020; // if set and this stream is sent to an analog output, it should
    public const int KS_MPEG2_DSS_UserData = 0x00000040; // if set, the MPEG-2 decoder must process DSS style user data
    public const int KS_MPEG2_DVB_UserData = 0x00000080; // if set, the MPEG-2 decoder must process DVB style user data
    public const int KS_MPEG2_27MhzTimebase = 0x00000100; // if set, the PTS,DTS timestamps advance at 27MHz rather than 90KHz
    public const int KS_MAX_SIZE_MPEG1_SEQUENCE_INFO = 140;
    public const int KS_MPEGAUDIOINFO_27MhzTimebase = 0x00000001;
    public const int KS_VIDEOSTREAM_PREVIEW = 0x0001; // Preview stream
    public const int KS_VIDEOSTREAM_CAPTURE = 0x0002; // Capture stream
    public const int KS_VIDEOSTREAM_VBI = 0x0010; // Field1 VBI
    public const int KS_VIDEOSTREAM_NABTS = 0x0020; // Field1 NABTS
    public const int KS_VIDEOSTREAM_CC = 0x0100; // Closed Captioning
    public const int KS_VIDEOSTREAM_EDS = 0x0200; // Extended Data Services
    public const int KS_VIDEOSTREAM_TELETEXT = 0x0400; // Field1 Teletext only
    public const int KS_VIDEOSTREAM_STILL = 0x1000; // Still image input
    public const int KS_VIDEOSTREAM_IS_VPE = 0x8000; // Is a VPE based stream?
    public const int KS_VIDEO_ALLOC_VPE_SYSTEM = 0x0001; // VPE surface in system memory
    public const int KS_VIDEO_ALLOC_VPE_DISPLAY = 0x0002; // VPE surface in display memory
    public const int KS_VIDEO_ALLOC_VPE_AGP = 0x0004; // VPE surface in AGP memory
    public const int KS_VBICAP_PROTECTION_MV_PRESENT = 0x0001;
    public const int KS_VBICAP_PROTECTION_MV_HARDWARE = 0x0002;
    public const int KS_VBICAP_PROTECTION_MV_DETECTED = 0x0004;
    public const int KS_NABTS_GROUPID_ORIGINAL_CONTENT_BASE = 0x800;
    public const int KS_NABTS_GROUPID_ORIGINAL_CONTENT_ADVERTISER_BASE = 0x810;
    public const int KS_NABTS_GROUPID_PRODUCTION_COMPANY_CONTENT_BASE = 0x820;
    public const int KS_NABTS_GROUPID_PRODUCTION_COMPANY_ADVERTISER_BASE = 0x830;
    public const int KS_NABTS_GROUPID_SYNDICATED_SHOW_CONTENT_BASE = 0x840;
    public const int KS_NABTS_GROUPID_SYNDICATED_SHOW_ADVERTISER_BASE = 0x850;
    public const int KS_NABTS_GROUPID_NETWORK_WIDE_CONTENT_BASE = 0x860;
    public const int KS_NABTS_GROUPID_NETWORK_WIDE_ADVERTISER_BASE = 0x870;
    public const int KS_NABTS_GROUPID_TELEVISION_STATION_CONTENT_BASE = 0x880;
    public const int KS_NABTS_GROUPID_TELEVISION_STATION_ADVERTISER_BASE = 0x890;
    public const int KS_NABTS_GROUPID_LOCAL_CABLE_SYSTEM_CONTENT_BASE = 0x8A0;
    public const int KS_NABTS_GROUPID_LOCAL_CABLE_SYSTEM_ADVERTISER_BASE = 0x8B0;
    public const int KS_NABTS_GROUPID_MICROSOFT_RESERVED_TEST_DATA_BASE = 0x8F0;
    public const int MAX_NABTS_VBI_LINES_PER_FIELD = 11;
    public const int NABTS_LINES_PER_BUNDLE = 16;
    public const int NABTS_PAYLOAD_PER_LINE = 28;
    public const int NABTS_BYTES_PER_LINE = 36;
    public const int KS_CC_SUBSTREAM_ODD = 0x0001; // Unfiltered Field 1 Data
    public const int KS_CC_SUBSTREAM_EVEN = 0x0002; // Unfiltered Field 2 Data
    public const int KS_CC_SUBSTREAM_FIELD1_MASK = 0x00F0;
    public const int KS_CC_SUBSTREAM_SERVICE_CC1 = 0x0010;
    public const int KS_CC_SUBSTREAM_SERVICE_CC2 = 0x0020;
    public const int KS_CC_SUBSTREAM_SERVICE_T1 = 0x0040;
    public const int KS_CC_SUBSTREAM_SERVICE_T2 = 0x0080;
    public const int KS_CC_SUBSTREAM_FIELD2_MASK = 0x1F00;
    public const int KS_CC_SUBSTREAM_SERVICE_CC3 = 0x0100;
    public const int KS_CC_SUBSTREAM_SERVICE_CC4 = 0x0200;
    public const int KS_CC_SUBSTREAM_SERVICE_T3 = 0x0400;
    public const int KS_CC_SUBSTREAM_SERVICE_T4 = 0x0800;
    public const int KS_CC_SUBSTREAM_SERVICE_XDS = 0x1000;
    public const int CC_MAX_HW_DECODE_LINES = 12;
    public const int NABTS_BUFFER_PICTURENUMBER_SUPPORT = 1;
    public const int WST_TVTUNER_CHANGE_BEGIN_TUNE = 0x1000; // Starting a tuning operation
    public const int WST_TVTUNER_CHANGE_END_TUNE = 0x2000; // Ending a tuning operation
    public const int MAX_WST_VBI_LINES_PER_FIELD = 17;
    public const int WST_BYTES_PER_LINE = 42;
    public const int KS_VIDEO_FLAG_FRAME = 0x0000; // Frame or Field (default is frame)
    public const int KS_VIDEO_FLAG_FIELD1 = 0x0001;
    public const int KS_VIDEO_FLAG_FIELD2 = 0x0002;
    public const int KS_VIDEO_FLAG_I_FRAME = 0x0000; // I, B, or P (default is I)
    public const int KS_VIDEO_FLAG_P_FRAME = 0x0010;
    public const int KS_VIDEO_FLAG_B_FRAME = 0x0020;
    public const int KS_VBI_FLAG_FIELD1 = 0x0001;
    public const int KS_VBI_FLAG_FIELD2 = 0x0002;
    public const int KS_VBI_FLAG_MV_PRESENT = 0x0100;
    public const int KS_VBI_FLAG_MV_HARDWARE = 0x0200;
    public const int KS_VBI_FLAG_MV_DETECTED = 0x0400;
    public const int KS_VBI_FLAG_TVTUNER_CHANGE = 0x0010; // TvTunerChangeInfo is valid
    public const int KS_VBI_FLAG_VBIINFOHEADER_CHANGE = 0x0020; // VBIInfoHeader is valid
    public const int KS_AnalogVideo_NTSC_Mask = 0x00000007;
    public const int KS_AnalogVideo_PAL_Mask = 0x00100FF0;
    public const int KS_AnalogVideo_SECAM_Mask = 0x000FF000;
    public const int KSPROPERTY_VIDEOPROCAMP_FLAGS_AUTO = 0X0001;
    public const int KSPROPERTY_VIDEOPROCAMP_FLAGS_MANUAL = 0X0002;
    public const int KSPROPERTY_CAMERACONTROL_FLAGS_AUTO = 0X0001;
    public const int KSPROPERTY_CAMERACONTROL_FLAGS_MANUAL = 0X0002;
    public const int KSPROPERTY_CAMERACONTROL_FLAGS_ABSOLUTE = 0X0000;
    public const int KSPROPERTY_CAMERACONTROL_FLAGS_RELATIVE = 0X0010;
    public const int KS_TVAUDIO_MODE_MONO = 0x0001; // Mono
    public const int KS_TVAUDIO_MODE_STEREO = 0x0002; // Stereo
    public const int KS_TVAUDIO_MODE_LANG_A = 0x0010; // Primary language
    public const int KS_TVAUDIO_MODE_LANG_B = 0x0020; // 2nd avail language
    public const int KS_TVAUDIO_MODE_LANG_C = 0x0040; // 3rd avail language
    public const int KS_AM_UseNewCSSKey = 0x1;
#if _KS_
    public const int AllocatorStrategy_DontCare = 0;
#endif
#if _KS_
    public const int AllocatorStrategy_MinimizeNumberOfFrames = 0x00000001;
#endif
#if _KS_
    public const int AllocatorStrategy_MinimizeFrameSize = 0x00000002;
#endif
#if _KS_
    public const int AllocatorStrategy_MinimizeNumberOfAllocators = 0x00000004;
#endif
#if _KS_
    public const int AllocatorStrategy_MaximizeSpeed = 0x00000008;
#endif
#if _KS_
    public const int PipeFactor_None = 0;
#endif
#if _KS_
    public const int PipeFactor_UserModeUpstream = 0x00000001;
#endif
#if _KS_
    public const int PipeFactor_UserModeDownstream = 0x00000002;
#endif
#if _KS_
    public const int PipeFactor_MemoryTypes = 0x00000004;
#endif
#if _KS_
    public const int PipeFactor_Flags = 0x00000008;
#endif
#if _KS_
    public const int PipeFactor_PhysicalRanges = 0x00000010;
#endif
#if _KS_
    public const int PipeFactor_OptimalRanges = 0x00000020;
#endif
#if _KS_
    public const int PipeFactor_FixedCompression = 0x00000040;
#endif
#if _KS_
    public const int PipeFactor_UnknownCompression = 0x00000080;
#endif
#if _KS_
    public const int PipeFactor_Buffers = 0x00000100;
#endif
#if _KS_
    public const int PipeFactor_Align = 0x00000200;
#endif
#if _KS_
    public const int PipeFactor_PhysicalEnd = 0x00000400;
#endif
#if _KS_
    public const int PipeFactor_LogicalEnd = 0x00000800;
#endif
    public const int MPBOOL_TRUE =  1 ;
    public const int MPBOOL_FALSE =  0 ;
    public const int DWORD_ALLPARAMS =  -1 ;
    public const int MPF_ENVLP_STANDARD =  0 ;
    public const int MPF_PUNCHIN_REFTIME =  0 ;
    public const int MPEG_PAT_PID = 0x0000;
    public const int MPEG_PAT_TID = 0x00;
    public const int MPEG_CAT_PID = 0x0001;
    public const int MPEG_CAT_TID = 0x01;
    public const int MPEG_PMT_TID = 0x02;
    public const int MPEG_TSDT_PID = 0x0002;
    public const int MPEG_TSDT_TID = 0x03;
    public const int ATSC_MGT_PID = 0x1FFB;
    public const int ATSC_MGT_TID = 0xC7;
    public const int ATSC_VCT_PID = 0x1FFB;
    public const int ATSC_VCT_TERR_TID = 0xC8;
    public const int ATSC_VCT_CABL_TID = 0xC9;
    public const int ATSC_RRT_PID = 0x1FFB;
    public const int ATSC_RRT_TID = 0xCA;
    public const int ATSC_EIT_TID = 0xCB;
    public const int ATSC_ETT_TID = 0xCC;
    public const int ATSC_STT_PID = 0x1FFB;
    public const int ATSC_STT_TID = 0xCD;
    public const int ATSC_PIT_TID = 0xD0;
    public const int DVB_NIT_PID = 0x0010;
    public const int DVB_NIT_ACTUAL_TID = 0x40;
    public const int DVB_NIT_OTHER_TID = 0x41;
    public const int DVB_SDT_PID = 0x0011;
    public const int DVB_SDT_ACTUAL_TID = 0x42;
    public const int DVB_SDT_OTHER_TID = 0x46;
    public const int DVB_BAT_PID = 0x0011;
    public const int DVB_BAT_TID = 0x4A;
    public const int DVB_EIT_PID = 0x0012;
    public const int DVB_EIT_ACTUAL_TID = 0x4E;
    public const int DVB_EIT_OTHER_TID = 0x4F;
    public const int DVB_RST_PID = 0x0013;
    public const int DVB_RST_TID = 0x71;
    public const int DVB_TDT_PID = 0x0014;
    public const int DVB_TDT_TID = 0x70;
    public const int DVB_ST_PID_16 = 0x0010;
    public const int DVB_ST_PID_17 = 0x0011;
    public const int DVB_ST_PID_18 = 0x0012;
    public const int DVB_ST_PID_19 = 0x0013;
    public const int DVB_ST_PID_20 = 0x0014;
    public const int DVB_ST_TID = 0x72;
    public const int DVB_TOT_PID = 0x0014;
    public const int DVB_TOT_TID = 0x73;
    public const int DVB_DIT_PID = 0x001E;
    public const int DVB_DIT_TID = 0x7E;
    public const int DVB_SIT_PID = 0x001F;
    public const int DVB_SIT_TID = 0x7F;
    public const int ISDB_DCT_PID = 0x0017;
    public const int ISDB_DCT_TID = 0xC0;
    public const int ISDB_LIT_PID = 0x0020;
    public const int ISDB_LIT_TID = 0xD0;
    public const int ISDB_ERT_PID = 0x0021;
    public const int ISDB_ERT_TID = 0xD1;
    public const int ISDB_ITT_TID = 0xD2;
    public const int ISDB_DLT_TID = 0xC1;
    public const int ISDB_PCAT_PID = 0x0022;
    public const int ISDB_PCAT_TID = 0xC2;
    public const int ISDB_SDTT_PID = 0x0023;
    public const int ISDB_SDTT_TID = 0xC3;
    public const int MPEG2_FILTER_VERSION_1_SIZE = 124;
    public const int AM_MPEG_AUDIO_DUAL_MERGE = 0;
    public const int AM_MPEG_AUDIO_DUAL_LEFT = 1;
    public const int AM_MPEG_AUDIO_DUAL_RIGHT = 2;
#if ! SM_CMONITORS
    public const int SM_XVIRTUALSCREEN = 76;
#endif
#if ! SM_CMONITORS
    public const int SM_YVIRTUALSCREEN = 77;
#endif
#if ! SM_CMONITORS
    public const int SM_CXVIRTUALSCREEN = 78;
#endif
#if ! SM_CMONITORS
    public const int SM_CYVIRTUALSCREEN = 79;
#endif
#if ! SM_CMONITORS
    public const int SM_CMONITORS = 80;
#endif
#if ! SM_CMONITORS
    public const int SM_SAMEDISPLAYFORMAT = 81;
#endif
#if ! SM_CMONITORS
    public const int MONITOR_DEFAULTTONULL = 0x00000000;
#endif
#if ! SM_CMONITORS
    public const int MONITOR_DEFAULTTOPRIMARY = 0x00000001;
#endif
#if ! SM_CMONITORS
    public const int MONITOR_DEFAULTTONEAREST = 0x00000002;
#endif
#if ! SM_CMONITORS
    public const int MONITORINFOF_PRIMARY = 0x00000001;
#endif
#if ! SM_CMONITORS
    public const int CCHDEVICENAME = 32;
#endif
#if ! SM_CMONITORS && ! DISPLAY_DEVICE_ATTACHED_TO_DESKTOP
    public const int DISPLAY_DEVICE_ATTACHED_TO_DESKTOP = 0x00000001;
#endif
#if ! SM_CMONITORS && ! DISPLAY_DEVICE_ATTACHED_TO_DESKTOP
    public const int DISPLAY_DEVICE_MULTI_DRIVER = 0x00000002;
#endif
#if ! SM_CMONITORS && ! DISPLAY_DEVICE_ATTACHED_TO_DESKTOP
    public const int DISPLAY_DEVICE_PRIMARY_DEVICE = 0x00000004;
#endif
#if ! SM_CMONITORS && ! DISPLAY_DEVICE_ATTACHED_TO_DESKTOP
    public const int DISPLAY_DEVICE_MIRRORING_DRIVER = 0x00000008;
#endif
#if ! SM_CMONITORS && ! DISPLAY_DEVICE_ATTACHED_TO_DESKTOP
    public const int DISPLAY_DEVICE_VGA_COMPATIBLE = 0x00000010;
#endif
    public const int PIX_PLUGIN_SYSTEM_VERSION = 0x101;
    public const int DEX_IDS_BAD_SOURCE_NAME = 1400;
    public const int DEX_IDS_BAD_SOURCE_NAME2 = 1401;
    public const int DEX_IDS_MISSING_SOURCE_NAME = 1402;
    public const int DEX_IDS_UNKNOWN_SOURCE = 1403;
    public const int DEX_IDS_INSTALL_PROBLEM = 1404;
    public const int DEX_IDS_NO_SOURCE_NAMES = 1405;
    public const int DEX_IDS_BAD_MEDIATYPE = 1406;
    public const int DEX_IDS_STREAM_NUMBER = 1407;
    public const int DEX_IDS_OUTOFMEMORY = 1408;
    public const int DEX_IDS_DIBSEQ_NOTALLSAME = 1409;
    public const int DEX_IDS_CLIPTOOSHORT = 1410;
    public const int DEX_IDS_INVALID_DXT = 1411;
    public const int DEX_IDS_INVALID_DEFAULT_DXT = 1412;
    public const int DEX_IDS_NO_3D = 1413;
    public const int DEX_IDS_BROKEN_DXT = 1414;
    public const int DEX_IDS_NO_SUCH_PROPERTY = 1415;
    public const int DEX_IDS_ILLEGAL_PROPERTY_VAL = 1416;
    public const int DEX_IDS_INVALID_XML = 1417;
    public const int DEX_IDS_CANT_FIND_FILTER = 1418;
    public const int DEX_IDS_DISK_WRITE_ERROR = 1419;
    public const int DEX_IDS_INVALID_AUDIO_FX = 1420;
    public const int DEX_IDS_CANT_FIND_COMPRESSOR = 1421;
    public const int DEX_IDS_TIMELINE_PARSE = 1426;
    public const int DEX_IDS_GRAPH_ERROR = 1427;
    public const int DEX_IDS_GRID_ERROR = 1428;
    public const int DEX_IDS_INTERFACE_ERROR = 1429;
    public const int D3DRM_XTEMPLATE_BYTES = 3278;
    public const int STREAMBUFFER_EC_BASE = 0x0326;
#if ! _NTSTRSAFE_H_INCLUDED_
    public const int STRSAFE_MAX_CCH = 2147483647; // max # of characters we support (same as INT_MAX)
#endif
#if ! _NTSTRSAFE_H_INCLUDED_
    public const int STRSAFE_IGNORE_NULLS = 0x00000100; // treat null as TEXT("") -- don't fault on NULL buffers
#endif
#if ! _NTSTRSAFE_H_INCLUDED_
    public const int STRSAFE_FILL_BEHIND_NULL = 0x00000200; // fill in extra space behind the null terminator
#endif
#if ! _NTSTRSAFE_H_INCLUDED_
    public const int STRSAFE_FILL_ON_FAILURE = 0x00000400; // on failure, overwrite pszDest with fill pattern and null terminate it
#endif
#if ! _NTSTRSAFE_H_INCLUDED_
    public const int STRSAFE_NULL_ON_FAILURE = 0x00000800; // on failure, set *pszDest = TEXT('\0')
#endif
#if ! _NTSTRSAFE_H_INCLUDED_
    public const int STRSAFE_NO_TRUNCATION = 0x00001000; // instead of returning a truncated result, copy/append nothing to pszDest and null terminate it
#endif
    public const int ID_BUTTON_EXECUTE = 3;
    public const int IDR_MENU_MAIN = 101;
    public const int IDD_DIALOG_MAIN = 102;
    public const int IDD_PANEL_DEVICE = 103;
    public const int IDD_PANEL_KEY = 104;
    public const int IDD_PANEL_OPTION = 105;
    public const int IDC_TAB_MAIN = 1000;
    public const int IDC_RADIO_FULLSCREEN = 1001;
    public const int IDC_RADIO_WINDOW = 1002;
    public const int IDC_COMBO_WINDOWSIZE = 1003;
    public const int IDC_LIST_KEY = 1004;
    public const int IDC_LIST_OPTION = 1005;
    public const int IDC_RADIO_FPS_1 = 1006;
    public const int IDC_COMBO_PADINDEX = 1006;
    public const int IDC_RADIO_FPS_2 = 1007;
    public const int IDC_RADIO_FPS_3 = 1008;
    public const int IDC_RADIO_AUTO = 1009;
    public const int IDC_RADIO_FPS_AUTO = 1009;
    public const int ID_MENUITEM_MAIN_EXIT = 40001;
#if APSTUDIO_INVOKED && ! APSTUDIO_READONLY_SYMBOLS
    public const int _APS_NEXT_RESOURCE_VALUE = 106;
#endif
#if APSTUDIO_INVOKED && ! APSTUDIO_READONLY_SYMBOLS
    public const int _APS_NEXT_RESOURCE_VALUE = 105;
#endif
#if APSTUDIO_INVOKED && ! APSTUDIO_READONLY_SYMBOLS
    public const int _APS_NEXT_COMMAND_VALUE = 40002;
#endif
#if APSTUDIO_INVOKED && ! APSTUDIO_READONLY_SYMBOLS
    public const int _APS_NEXT_COMMAND_VALUE = 40009;
#endif
#if APSTUDIO_INVOKED && ! APSTUDIO_READONLY_SYMBOLS
    public const int _APS_NEXT_COMMAND_VALUE = 40010;
#endif
#if APSTUDIO_INVOKED && ! APSTUDIO_READONLY_SYMBOLS
    public const int _APS_NEXT_CONTROL_VALUE = 1007;
#endif
#if APSTUDIO_INVOKED && ! APSTUDIO_READONLY_SYMBOLS
    public const int _APS_NEXT_CONTROL_VALUE = 1005;
#endif
#if APSTUDIO_INVOKED && ! APSTUDIO_READONLY_SYMBOLS
    public const int _APS_NEXT_CONTROL_VALUE = 1008;
#endif
#if APSTUDIO_INVOKED && ! APSTUDIO_READONLY_SYMBOLS
    public const int _APS_NEXT_SYMED_VALUE = 101;
#endif
    public const int IDI_ICON = 103;
    public const int IDD_DIALOG_ERROR = 104;
    public const int IDC_EDIT_MESSAGE = 1004;
    public const int IDC_BUTTON_RELOAD_SCRIPT = 3;
    public const int IDD_DIALOG_UNITSELECT = 102;
    public const int IDD_DIALOG_SKILLSELECT = 103;
    public const int IDD_DIALOG_SELECT_SCRIPT = 103;
    public const int IDD_DIALOG_BACKSELECT = 104;
    public const int IDD_DIALOG_DEBUG = 104;
    public const int IDC_LIST_UNIT = 1001;
    public const int IDC_LIST_BACK = 1002;
    public const int IDC_LIST_SELECT_SCRIPT = 1003;
    public const int IDC_COMBO_TYPE_SCRIPT = 1004;
    public const int IDC_CHECK_PLAYER_INVINCIBILITY = 1006;
    public const int IDC_LIST1 = 1007;
    public const int ID_MENUITEM_EXIT = 40001;
    public const int ID_MENUITEM_MAIN_SAVE = 40002;
    public const int ID_MENUITEM_MAIN_LOAD = 40003;
    public const int ID_MENUITEM_MAIN_CLEAR = 40004;
    public const int ID_MENUITEM_MAIN_EVENT_SAVE = 40005;
    public const int ID_MENUITEM_MAIN_EVENT_LOAD = 40006;
    public const int ID_MENUITEM_MAIN_FIXEDAREA = 40007;
    public const int ID_MENUITEM_MAIN_LOGWINDOW = 40008;
    public const int ID_MENUITEM_MAIN_DEBUGWINDOW = 40009;
}