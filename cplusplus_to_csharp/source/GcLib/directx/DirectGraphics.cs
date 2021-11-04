using gstd;
using directx;
using System;
using System.Collections.Generic;

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DWORD_PTR DWORD*
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_malloc malloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_calloc calloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_realloc realloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_free free
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)

namespace directx
{
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxCamera;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxCamera2D;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class Texture;
    /**********************************************************
    //DirectGraphicsConfig
    **********************************************************/
    public class DirectGraphicsConfig : System.IDisposable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                COLOR_MODE_16BIT,
                COLOR_MODE_32BIT
            }
            protected bool bShowWindow_;
            protected int widthScreen_;
            protected int heightScreen_;
            protected bool bWindowed_;
            protected bool bUseRef_;
            protected int colorMode_;
            protected bool bUseTripleBuffer_;
            protected bool bUseWaitTimer_;
            protected bool bPseudoFullScreen_;

            /**********************************************************
            //DirectGraphicsConfig
            **********************************************************/
            public DirectGraphicsConfig()
            {
                bShowWindow_ = true;
                widthScreen_ = 800;
                heightScreen_ = 600;
                bWindowed_ = true;
                bUseRef_ = false;
                colorMode_ = (int)AnonymousEnum.COLOR_MODE_32BIT;
                bUseTripleBuffer_ = true;
                bUseWaitTimer_ = false;
                bPseudoFullScreen_ = true;
            }

            public virtual void Dispose()
            {

            }

            public bool IsShowWindow()
            {
                return bShowWindow_;
            }
            public void SetShowWindow(bool b)
            {
                bShowWindow_ = b;
            }
            public int GetScreenWidth()
            {
                return widthScreen_;
            }
            public void SetScreenWidth(int width)
            {
                widthScreen_ = width;
            }
            public int GetScreenHeight()
            {
                return heightScreen_;
            }
            public void SetScreenHeight(int height)
            {
                heightScreen_ = height;
            }
            public bool IsWindowed()
            {
                return bWindowed_;
            }
            public void SetWindowd(bool bWindowed)
            {
                bWindowed_ = bWindowed;
            }
            public bool IsReferenceEnable()
            {
                return bUseRef_;
            }
            public void SetReferenceEnable(bool bEnable)
            {
                bUseRef_ = bEnable;
            }
            public int GetColorMode()
            {
                return colorMode_;
            }
            public void SetColorMode(int mode)
            {
                colorMode_ = mode;
            }
            public bool IsTripleBufferEnable()
            {
                return bUseTripleBuffer_;
            }
            public void SetTripleBufferEnable(bool bEnable)
            {
                bUseTripleBuffer_ = bEnable;
            }
            public bool IsWaitTimerEnable()
            {
                return bUseWaitTimer_;
            }
            public void SetWaitTimerEnable(bool bEnable)
            {
                bUseWaitTimer_ = bEnable;
            }
            public bool IsPseudoFullScreen()
            {
                return bPseudoFullScreen_;
            }
            public void SetbPseudoFullScreen(bool b)
            {
                bPseudoFullScreen_ = b;
            }
    }

    public class DirectGraphicsListener : System.IDisposable
    {
            public virtual void Dispose()
            {
            }
            public virtual void ReleaseDirectGraphics()
            {
            }
            public virtual void RestoreDirectGraphics()
            {
            }
            public virtual void StartChangeScreenMode()
            {
                ReleaseDirectGraphics();
            }
            public virtual void EndChangeScreenMode()
            {
                RestoreDirectGraphics();
            }
    }

    public class DirectGraphics : System.IDisposable
    {
            private static DirectGraphics thisBase_ = null;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum2
            {
                SCREENMODE_FULLSCREEN,
                SCREENMODE_WINDOW
            }
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum3
            {
                MODE_BLEND_NONE, // �Ȃ�
                MODE_BLEND_ALPHA, // ���Ŕ���������
                MODE_BLEND_ADD_RGB, // RGB�ŉ��Z����
                MODE_BLEND_ADD_ARGB, // ���ŉ��Z����
                MODE_BLEND_MULTIPLY, // ��Z����
                MODE_BLEND_SUBTRACT, // ���Z����
                MODE_BLEND_SHADOW, // �e�`��p
                MODE_BLEND_INV_DESTRGB, // �`���F���]����

                MODE_TEXTURE_FILTER_NONE, // �t�B���^�Ȃ�
                MODE_TEXTURE_FILTER_POINT, // ��ԂȂ�
                MODE_TEXTURE_FILTER_LINEAR // ���`���
            }
            protected IDirect3D9 pDirect3D_;
            protected IDirect3DDevice9 pDevice_;
            protected D3DPRESENT_PARAMETERS d3dppFull_ = new D3DPRESENT_PARAMETERS();
            protected D3DPRESENT_PARAMETERS d3dppWin_ = new D3DPRESENT_PARAMETERS();
            protected IDirect3DSurface9 pBackSurf_;
            protected IDirect3DSurface9 pZBuffer_;

            protected DirectGraphicsConfig config_ = new DirectGraphicsConfig();
            protected IntPtr hAttachedWindow_;
            protected uint wndStyleFull_;
            protected uint wndStyleWin_;
            protected int modeScreen_;
            protected LinkedList<DirectGraphicsListener> listListener_ = new LinkedList<DirectGraphicsListener>();

            protected gstd.ref_count_ptr<DxCamera> camera_ = new gstd.ref_count_ptr<DxCamera>();
            protected gstd.ref_count_ptr<DxCamera2D> camera2D_ = new gstd.ref_count_ptr<DxCamera2D>();
            protected gstd.ref_count_ptr<Texture> textureTarget_ = new gstd.ref_count_ptr<Texture>();

            protected void _ReleaseDxResource()
            {
                if (pZBuffer_ != null)
                {
                    pZBuffer_.Release();
                }
                if (pBackSurf_ != null)
                {
                    pBackSurf_.Release();
                }
                LinkedList<DirectGraphicsListener>.Enumerator itr;
                for (itr = listListener_.GetEnumerator(); itr.MoveNext();)
                {
                    itr.Current.ReleaseDirectGraphics();
                }
            }

            protected void _RestoreDxResource()
            {
                pDevice_.GetRenderTarget(0, pBackSurf_);
                pDevice_.GetDepthStencilSurface(pZBuffer_);
                LinkedList<DirectGraphicsListener>.Enumerator itr;
                for (itr = listListener_.GetEnumerator(); itr.MoveNext();)
                {
                    itr.Current.RestoreDirectGraphics();
                }
                _InitializeDeviceState();
            }

            protected void _Restore()
            {
                Logger.WriteTop("DirectGraphics�F_Restore�J�n");
                // �f�B�X�v���C�̋������x���𒲍�
                int hr = pDevice_.TestCooperativeLevel();
                if (hr == D3DERR_DEVICELOST)
                {
                    int count = 0;
                    do
                    {
                        Sleep(500); // 0.5�b�҂�
                        count += 500;
                        hr = pDevice_.TestCooperativeLevel();
                        if (hr == D3DERR_DEVICENOTRESET)
                        {
                            break;
                        }
                    }while (count < 6000);
                }

                // ���X�g�A
                _ReleaseDxResource();

                // �f�o�C�X���Z�b�g
                if (modeScreen_ == (int)AnonymousEnum2.SCREENMODE_FULLSCREEN)
                {
                    pDevice_.Reset(d3dppFull_);
                }
                else
                {
                    pDevice_.Reset(d3dppWin_);
                }

                _RestoreDxResource();

                Logger.WriteTop("DirectGraphics�F_Restore����");
            }

            protected void _InitializeDeviceState()
            {
                D3DXMATRIX viewMat = new D3DXMATRIX();
                D3DXMATRIX persMat = new D3DXMATRIX();
                if (camera_ != null)
                {
                    camera_.UpdateDeviceWorldViewMatrix();
                }
                else
                {
                    D3DVECTOR viewFrom = D3DXVECTOR3(100,300,-500);
                    D3DXMatrixLookAtLH(viewMat, (D3DXVECTOR3) viewFrom, D3DXVECTOR3(0,0,0), D3DXVECTOR3(0,1,0));
                }
                D3DXMatrixPerspectiveFovLH(persMat, D3DXToRadian(45.0), (float)config_.GetScreenWidth() / (float)config_.GetScreenHeight(), 10, 2000);

                pDevice_.SetTransform(D3DTS_VIEW, viewMat);
                pDevice_.SetTransform(D3DTS_PROJECTION, persMat);

                SetCullingMode(D3DCULL_NONE);
                pDevice_.SetRenderState(D3DRS_SHADEMODE, D3DSHADE_GOURAUD);
                pDevice_.SetRenderState(D3DRS_AMBIENT, RGB(192, 192, 192));
                SetLightingEnable(true);

                D3DVECTOR dir = new D3DVECTOR();
                dir.x = -1;
                dir.y = -1;
                dir.z = -1;
                SetDirectionalLight(dir);

                SetBlendMode((uint)AnonymousEnum3.MODE_BLEND_ALPHA);


            // ���e�X�g
                SetAlphaTest(true, 0, D3DCMP_GREATER);

            // Z�e�X�g
                SetZBufferEnable(false);
                SetZWriteEnalbe(false);

            // Filter
                SetTextureFilter((uint)AnonymousEnum3.MODE_TEXTURE_FILTER_LINEAR);

            // ViewPort
                ResetViewPort();
            }


            /**********************************************************
            //DirectGraphics
            **********************************************************/
            /**********************************************************
            //DirectGraphics
            **********************************************************/

            public DirectGraphics()
            {
                pDirect3D_ = null;
                pDevice_ = null;
                pBackSurf_ = null;
                pZBuffer_ = null;
                camera_ = new DxCamera();
                camera2D_ = new DxCamera2D();
            }

            public virtual void Dispose()
            {
                Logger.WriteTop("DirectGraphics�F�I���J�n");

                if (pZBuffer_ != null)
                {
                    pZBuffer_.Release();
                }
                if (pBackSurf_ != null)
                {
                    pBackSurf_.Release();
                }
                if (pDevice_ != null)
                {
                    pDevice_.Release();
                }
                if (pDirect3D_ != null)
                {
                    pDirect3D_.Release();
                }
                thisBase_ = null;
                Logger.WriteTop("DirectGraphics�F�I������");
            }

            public static DirectGraphics GetBase()
            {
                return thisBase_;
            }
            public IntPtr GetAttachedWindowHandle()
            {
                return hAttachedWindow_;
            }

            public virtual bool Initialize(IntPtr hWnd)
            {
                return this.Initialize(hWnd, config_);
            }

            public virtual bool Initialize(IntPtr hWnd, DirectGraphicsConfig config)
            {
                if (thisBase_ != null)
                {
                    return false;
                }

                Logger.WriteTop("DirectGraphics�F������");
                pDirect3D_ = Direct3DCreate9(D3D_SDK_VERSION);
                if (pDirect3D_ == null)
                {
                    throw new gstd.wexception("Direct3DCreate9���s");
                }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: config_ = config;
                config_.CopyFrom(config);
                wndStyleFull_ = WS_POPUP;
                wndStyleWin_ = WS_OVERLAPPEDWINDOW - WS_SIZEBOX;
                hAttachedWindow_ = hWnd;

                // FullScreenMode�̐ݒ�
                ZeroMemory(d3dppFull_, sizeof(D3DPRESENT_PARAMETERS));
                d3dppFull_.hDeviceWindow = hWnd;
                d3dppFull_.BackBufferWidth = config_.GetScreenWidth();
                d3dppFull_.BackBufferHeight = config_.GetScreenHeight();
                d3dppFull_.Windowed = false;
                d3dppFull_.SwapEffect = D3DSWAPEFFECT_DISCARD;
                if (config_.GetColorMode() == DirectGraphicsConfig.COLOR_MODE_16BIT)
                {
                    d3dppFull_.BackBufferFormat = D3DFMT_R5G6B5;
                }
                else
                {
                    d3dppFull_.BackBufferFormat = D3DFMT_X8R8G8B8;
                }
                if (config_.IsTripleBufferEnable())
                {
                    d3dppFull_.BackBufferCount = 1;
                }
                else
                {
                    d3dppFull_.BackBufferCount = 2;
                }
                if (config_.IsWaitTimerEnable() == false)
                {
                    d3dppFull_.FullScreen_RefreshRateInHz = 60;
                }
                d3dppFull_.EnableAutoDepthStencil = true;
                d3dppFull_.AutoDepthStencilFormat = D3DFMT_D16;
                d3dppFull_.MultiSampleType = D3DMULTISAMPLE_NONE;

                // WindowMode�̐ݒ�
                D3DDISPLAYMODE dmode = new D3DDISPLAYMODE();
                int hrAdapt = pDirect3D_.GetAdapterDisplayMode(D3DADAPTER_DEFAULT, dmode);
                ZeroMemory(d3dppWin_, sizeof(D3DPRESENT_PARAMETERS));
                d3dppWin_.BackBufferWidth = config_.GetScreenWidth();
                d3dppWin_.BackBufferHeight = config_.GetScreenHeight();
                d3dppWin_.Windowed = true;
                d3dppWin_.SwapEffect = D3DSWAPEFFECT_DISCARD;
                d3dppWin_.BackBufferFormat = D3DFMT_UNKNOWN;
                d3dppWin_.hDeviceWindow = hWnd;
                d3dppWin_.PresentationInterval = D3DPRESENT_INTERVAL_IMMEDIATE;

                if (config_.IsTripleBufferEnable())
                {
                    d3dppWin_.BackBufferCount = 1;
                }
                else
                {
                    d3dppWin_.BackBufferCount = 2;
                }
                d3dppWin_.EnableAutoDepthStencil = true;
                d3dppWin_.AutoDepthStencilFormat = D3DFMT_D16;
                d3dppWin_.MultiSampleType = D3DMULTISAMPLE_NONE;

                if (!config_.IsWindowed())
                { // FullScreenMode
                    global::SetWindowLong(hWnd, GWL_STYLE, wndStyleFull_);
                    global::ShowWindow(hWnd, SW_SHOW);
                }

                int countAdapt = pDirect3D_.GetAdapterCount();

                D3DPRESENT_PARAMETERS d3dpp = config_.IsWindowed() ? d3dppWin_ : d3dppFull_;
                modeScreen_ = config_.IsWindowed() ? (int)AnonymousEnum2.SCREENMODE_WINDOW : (int)AnonymousEnum2.SCREENMODE_FULLSCREEN;
                int hrDevice = -1;
                if (config_.IsReferenceEnable())
                {
                    hrDevice = pDirect3D_.CreateDevice(D3DADAPTER_DEFAULT, D3DDEVTYPE_REF, hWnd, D3DCREATE_SOFTWARE_VERTEXPROCESSING | D3DCREATE_MULTITHREADED | D3DCREATE_FPU_PRESERVE, d3dpp, pDevice_);
                }
                else
                {
                    D3DCAPS9 caps = new D3DCAPS9();
                    pDirect3D_.GetDeviceCaps(D3DADAPTER_DEFAULT, D3DDEVTYPE_HAL, caps);
                    if (caps.VertexShaderVersion >= D3DVS_VERSION(2,0))
                    {
                        hrDevice = pDirect3D_.CreateDevice(D3DADAPTER_DEFAULT, D3DDEVTYPE_HAL, hWnd, D3DCREATE_HARDWARE_VERTEXPROCESSING | D3DCREATE_MULTITHREADED | D3DCREATE_FPU_PRESERVE, d3dpp, pDevice_);
                        if (!FAILED(hrDevice))
                        {
                            Logger.WriteTop("DirectGraphics�F�f�o�C�X����������->D3DCREATE_HARDWARE_VERTEXPROCESSING");
                        }
                        if (FAILED(hrDevice))
                        {
                            hrDevice = pDirect3D_.CreateDevice(D3DADAPTER_DEFAULT, D3DDEVTYPE_HAL, hWnd, D3DCREATE_SOFTWARE_VERTEXPROCESSING | D3DCREATE_MULTITHREADED | D3DCREATE_FPU_PRESERVE, d3dpp, pDevice_);
                            if (!FAILED(hrDevice))
                            {
                                Logger.WriteTop("DirectGraphics�F�f�o�C�X����������->D3DCREATE_SOFTWARE_VERTEXPROCESSING");
                            }
                        }
                    }
                    else
                    {
                        hrDevice = pDirect3D_.CreateDevice(D3DADAPTER_DEFAULT, D3DDEVTYPE_HAL, hWnd, D3DCREATE_SOFTWARE_VERTEXPROCESSING | D3DCREATE_MULTITHREADED | D3DCREATE_FPU_PRESERVE, d3dpp, pDevice_);
                        if (!FAILED(hrDevice))
                        {
                            Logger.WriteTop("DirectGraphics�F�f�o�C�X����������->D3DCREATE_SOFTWARE_VERTEXPROCESSING");
                        }
                    }

                    if (FAILED(hrDevice))
                    {
                        Logger.WriteTop("DirectGraphics�FHEL���삵�܂��B�����炭���퓮�삵�܂���B");
                        hrDevice = pDirect3D_.CreateDevice(D3DADAPTER_DEFAULT, D3DDEVTYPE_REF, hWnd, D3DCREATE_SOFTWARE_VERTEXPROCESSING | D3DCREATE_MULTITHREADED | D3DCREATE_FPU_PRESERVE, d3dpp, pDevice_);
                    }

                }

                if (FAILED(hrDevice))
                {
                    throw new gstd.wexception("IDirect3DDevice9::CreateDevice���s");
                }

            // BackSurface�擾
                pDevice_.GetRenderTarget(0, pBackSurf_);

            // Z�o�b�t�@�擾
                pDevice_.GetDepthStencilSurface(pZBuffer_);

                thisBase_ = this;

                if (camera2D_ != null)
                {
                    camera2D_.Reset();
                }
                _InitializeDeviceState();

                BeginScene();
                EndScene();

                Logger.WriteTop("DirectGraphics�F����������");
                return true;
            }

            public void AddDirectGraphicsListener(DirectGraphicsListener listener)
            {
                LinkedList<DirectGraphicsListener>.Enumerator itr;
                for (itr = listListener_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == listener)
                    {
                        return;
                    }
                }
                listListener_.AddLast(listener);
            }

            public void RemoveDirectGraphicsListener(DirectGraphicsListener listener)
            {
                LinkedList<DirectGraphicsListener>.Enumerator itr;
                for (itr = listListener_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current != listener)
                    {
                        continue;
                    }
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                    listListener_.erase(itr);
                    break;
                }
            }

            public int GetScreenMode()
            {
                return modeScreen_;
            }
            public D3DPRESENT_PARAMETERS GetFullScreenPresentParameter()
            {
                return new D3DPRESENT_PARAMETERS(d3dppFull_);
            }
            public D3DPRESENT_PARAMETERS GetWindowPresentParameter()
            {
                return new D3DPRESENT_PARAMETERS(d3dppWin_);
            }

            public IDirect3DDevice9 GetDevice()
            {
                return pDevice_;
            }
            public DirectGraphicsConfig GetConfigData()
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return config_;
                return new directx.DirectGraphicsConfig(config_);
            }

            public void BeginScene(bool bClear = true)
            {
                if (bClear)
                {
                    ClearRenderTarget();
                }
                pDevice_.BeginScene();
                camera_.UpdateDeviceWorldViewMatrix();
            }

            public void EndScene()
            {
                pDevice_.EndScene();

                int hr = pDevice_.Present(null,null,null,null);
                if (FAILED(hr))
                {
                    _Restore();
                    _InitializeDeviceState();
                }
            }

            public void ClearRenderTarget()
            {
                int width = GetScreenWidth();
                int height = GetScreenWidth();
                D3DRECT rcDest = new D3DRECT(0, 0, width, height);
                if (textureTarget_ == null)
                {
                    pDevice_.Clear(0, null, D3DCLEAR_TARGET | D3DCLEAR_ZBUFFER, D3DCOLOR_XRGB(0,0,0), 1.0,0);
                }
                else
                {
                    pDevice_.Clear(0, null, D3DCLEAR_TARGET | D3DCLEAR_ZBUFFER, D3DCOLOR_ARGB(0,0,0,0), 1.0,0);
                }
            }

            public void ClearRenderTarget(RECT rect)
            {
                D3DRECT rcDest = new D3DRECT(rect.left, rect.top, rect.right, rect.bottom);
                if (textureTarget_ == null)
                {
                    pDevice_.Clear(1, rcDest, D3DCLEAR_TARGET | D3DCLEAR_ZBUFFER, D3DCOLOR_XRGB(0,0,0), 1.0, 0);
                }
                else
                {
                    pDevice_.Clear(1, rcDest, D3DCLEAR_TARGET | D3DCLEAR_ZBUFFER, D3DCOLOR_ARGB(0,0,0,0), 1.0, 0);
                }
            }

            public void SetRenderTarget(gstd.ref_count_ptr<Texture> texture)
            {
                textureTarget_.CopyFrom(texture);
                if (texture == null)
                {
                    pDevice_.SetRenderTarget(0, pBackSurf_);
                    pDevice_.SetDepthStencilSurface(pZBuffer_);
                }
                else
                {
                    pDevice_.SetRenderTarget(0, texture.GetD3DSurface());
                    pDevice_.SetDepthStencilSurface(texture.GetD3DZBuffer());
                }
                _InitializeDeviceState();
            }

            public gstd.ref_count_ptr<Texture> GetRenderTarget()
            {
                return new gstd.ref_count_ptr<Texture>(textureTarget_);
            }

            // �����_�����O�X�e�[�g���b�p
            public void SetLightingEnable(bool bEnable)
            {
                pDevice_.SetRenderState(D3DRS_LIGHTING, bEnable);
            }

            public void SetSpecularEnable(bool bEnable)
            {
                pDevice_.SetRenderState(D3DRS_SPECULARENABLE, bEnable);
            }

            public void SetCullingMode(uint mode)
            {
                pDevice_.SetRenderState(D3DRS_CULLMODE, mode);
            }

            public void SetShadingMode(uint mode)
            {
                pDevice_.SetRenderState(D3DRS_SHADEMODE, mode);
            }

            public void SetZBufferEnable(bool bEnable)
            {
                pDevice_.SetRenderState(D3DRS_ZENABLE, bEnable);
            }

            public void SetZWriteEnalbe(bool bEnable)
            {
                pDevice_.SetRenderState(D3DRS_ZWRITEENABLE, bEnable);
            }

            public void SetAlphaTest(bool bEnable, uint @ref = 0, D3DCMPFUNC func = D3DCMP_GREATER)
            {
                pDevice_.SetRenderState(D3DRS_ALPHATESTENABLE, bEnable);
                if (bEnable)
                {
                    pDevice_.SetRenderState(D3DRS_ALPHAFUNC, func);
                    pDevice_.SetRenderState(D3DRS_ALPHAREF, @ref);
                }
            }

            public void SetBlendMode(uint mode, int stage = 0)
            {
                switch (mode)
                {
                    case AnonymousEnum3.MODE_BLEND_NONE: // �Ȃ�
                        pDevice_.SetTextureStageState(stage, D3DTSS_COLOROP,D3DTOP_MODULATE);
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAARG2,D3DTA_CURRENT);
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAOP,D3DTOP_SELECTARG1);
                        pDevice_.SetRenderState(D3DRS_ALPHABLENDENABLE,false);
                        pDevice_.SetRenderState(D3DRS_BLENDOP, D3DBLENDOP_ADD);
                        break;
                    case AnonymousEnum3.MODE_BLEND_ALPHA: // ���Ŕ���������
                        pDevice_.SetTextureStageState(stage, D3DTSS_COLOROP,D3DTOP_MODULATE);
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAARG2,D3DTA_DIFFUSE);
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAOP,D3DTOP_MODULATE);
                        pDevice_.SetRenderState(D3DRS_ALPHABLENDENABLE,true);
                        pDevice_.SetRenderState(D3DRS_BLENDOP, D3DBLENDOP_ADD);
                        pDevice_.SetRenderState(D3DRS_SRCBLEND,D3DBLEND_SRCALPHA);
                        pDevice_.SetRenderState(D3DRS_DESTBLEND,D3DBLEND_INVSRCALPHA);
                        break;
                    case AnonymousEnum3.MODE_BLEND_ADD_RGB: // RGB�ŉ��Z����
                        pDevice_.SetTextureStageState(stage, D3DTSS_COLOROP,D3DTOP_MODULATE);
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAARG2,D3DTA_CURRENT);
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAOP,D3DTOP_SELECTARG1);
                        pDevice_.SetRenderState(D3DRS_ALPHABLENDENABLE,true);
                        pDevice_.SetRenderState(D3DRS_BLENDOP, D3DBLENDOP_ADD);
                        pDevice_.SetRenderState(D3DRS_SRCBLEND,D3DBLEND_ONE);
                        pDevice_.SetRenderState(D3DRS_DESTBLEND,D3DBLEND_ONE);
                        break;
                    case AnonymousEnum3.MODE_BLEND_ADD_ARGB: // ���ŉ��Z����
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAOP,D3DTOP_MODULATE); // ARG1��ARG2�̃��l���Z���ă��l��擾���܂��B
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAARG1,D3DTA_TEXTURE); // �e�N�X�`���̃��l
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAARG2,D3DTA_DIFFUSE); // ���_�̃��l
                        pDevice_.SetTextureStageState(stage, D3DTSS_COLOROP,D3DTOP_MODULATE); // ARG1��ARG2�̃J���[�̒l���Z���܂��B
                        pDevice_.SetTextureStageState(stage, D3DTSS_COLORARG1,D3DTA_TEXTURE); // �e�N�X�`���̃J���[
                        pDevice_.SetTextureStageState(stage, D3DTSS_COLORARG2,D3DTA_DIFFUSE); // ���_�̃J���[
                        pDevice_.SetRenderState(D3DRS_ALPHABLENDENABLE,true);
                        pDevice_.SetRenderState(D3DRS_BLENDOP, D3DBLENDOP_ADD);
                        pDevice_.SetRenderState(D3DRS_SRCBLEND, D3DBLEND_SRCALPHA);
                        pDevice_.SetRenderState(D3DRS_DESTBLEND, D3DBLEND_ONE);
                        break;
                    case AnonymousEnum3.MODE_BLEND_MULTIPLY: // ��Z����

                        pDevice_.SetTextureStageState(stage, D3DTSS_COLOROP,D3DTOP_MODULATE);
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAARG2,D3DTA_CURRENT);
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAOP,D3DTOP_SELECTARG1);
                        pDevice_.SetRenderState(D3DRS_ALPHABLENDENABLE,true);
                        pDevice_.SetRenderState(D3DRS_BLENDOP, D3DBLENDOP_ADD);
                        pDevice_.SetRenderState(D3DRS_SRCBLEND,D3DBLEND_ZERO);
                        pDevice_.SetRenderState(D3DRS_DESTBLEND,D3DBLEND_SRCCOLOR);
            // 			pDevice_->SetRenderState(D3DRS_SRCBLEND,D3DBLEND_DESTCOLOR);
            // 			pDevice_->SetRenderState(D3DRS_DESTBLEND,D3DBLEND_ZERO);
            /*
            			pDevice_->SetTextureStageState(stage,D3DTSS_COLOROP,D3DTOP_MODULATE);
            			pDevice_->SetTextureStageState(stage,D3DTSS_ALPHAARG2,D3DTA_CURRENT);
            			pDevice_->SetTextureStageState(stage,D3DTSS_ALPHAOP,D3DTOP_SELECTARG1);
            			pDevice_->SetRenderState(D3DRS_ALPHABLENDENABLE,TRUE);
            			pDevice_->SetRenderState(D3DRS_SRCBLEND,D3DBLEND_ZERO);
            			pDevice_->SetRenderState(D3DRS_DESTBLEND,D3DBLEND_SRCCOLOR);
            */
                        break;
            /*
            		case MODE_BLEND_SUBTRACT://���Z����
            			pDevice_->SetTextureStageState(stage, D3DTSS_COLOROP,D3DTOP_MODULATE);
            			pDevice_->SetTextureStageState(stage, D3DTSS_ALPHAARG2,D3DTA_CURRENT);
            			pDevice_->SetTextureStageState(stage, D3DTSS_ALPHAOP,D3DTOP_SELECTARG1);
            			pDevice_->SetRenderState(D3DRS_ALPHABLENDENABLE,TRUE);
            			pDevice_->SetRenderState(D3DRS_BLENDOP, D3DBLENDOP_REVSUBTRACT);
            			pDevice_->SetRenderState(D3DRS_SRCBLEND,D3DBLEND_ONE);
            			pDevice_->SetRenderState(D3DRS_DESTBLEND,D3DBLEND_ONE);
            			break;
            */
                    case AnonymousEnum3.MODE_BLEND_SUBTRACT: // ���Z����
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAOP,D3DTOP_MODULATE); // ARG1��ARG2�̃��l���Z���ă��l��擾���܂��B
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAARG1,D3DTA_TEXTURE); // �e�N�X�`���̃��l
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAARG2,D3DTA_DIFFUSE); // ���_�̃��l
                        pDevice_.SetTextureStageState(stage, D3DTSS_COLOROP,D3DTOP_MODULATE); // ARG1��ARG2�̃J���[�̒l���Z���܂��B
                        pDevice_.SetTextureStageState(stage, D3DTSS_COLORARG1,D3DTA_TEXTURE); // �e�N�X�`���̃J���[
                        pDevice_.SetTextureStageState(stage, D3DTSS_COLORARG2,D3DTA_DIFFUSE); // ���_�̃J���[
                        pDevice_.SetRenderState(D3DRS_ALPHABLENDENABLE,true);
                        pDevice_.SetRenderState(D3DRS_BLENDOP, D3DBLENDOP_REVSUBTRACT);
                        pDevice_.SetRenderState(D3DRS_SRCBLEND, D3DBLEND_SRCALPHA);
                        pDevice_.SetRenderState(D3DRS_DESTBLEND,D3DBLEND_ONE);
                        break;

                    case AnonymousEnum3.MODE_BLEND_SHADOW: // �e�`��p
                        pDevice_.SetTextureStageState(stage, D3DTSS_COLOROP,D3DTOP_MODULATE);
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAARG2,D3DTA_CURRENT);
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAOP,D3DTOP_SELECTARG1);
                        pDevice_.SetRenderState(D3DRS_ALPHABLENDENABLE,true);
                        pDevice_.SetRenderState(D3DRS_BLENDOP, D3DBLENDOP_ADD);
                        pDevice_.SetRenderState(D3DRS_SRCBLEND,D3DBLEND_ZERO);
                        pDevice_.SetRenderState(D3DRS_DESTBLEND,D3DBLEND_INVSRCCOLOR);
                        break;
                    case AnonymousEnum3.MODE_BLEND_INV_DESTRGB: // �`���F���]����
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAOP,D3DTOP_MODULATE); // ARG1��ARG2�̃��l���Z���ă��l��擾���܂��B
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAARG1,D3DTA_TEXTURE); // �e�N�X�`���̃��l
                        pDevice_.SetTextureStageState(stage, D3DTSS_ALPHAARG2,D3DTA_DIFFUSE); // ���_�̃��l
                        pDevice_.SetTextureStageState(stage, D3DTSS_COLOROP,D3DTOP_MODULATE); // ARG1��ARG2�̃J���[�̒l���Z���܂��B
                        pDevice_.SetTextureStageState(stage, D3DTSS_COLORARG1,D3DTA_TEXTURE); // �e�N�X�`���̃J���[
                        pDevice_.SetTextureStageState(stage, D3DTSS_COLORARG2,D3DTA_DIFFUSE); // ���_�̃J���[
                        pDevice_.SetRenderState(D3DRS_ALPHABLENDENABLE,true);
                        pDevice_.SetRenderState(D3DRS_BLENDOP, D3DBLENDOP_ADD);
                        pDevice_.SetRenderState(D3DRS_SRCBLEND, D3DBLEND_INVDESTCOLOR);
                        pDevice_.SetRenderState(D3DRS_DESTBLEND, D3DBLEND_INVSRCCOLOR);
                        break;
                }
                // ���Z����������
                // pDevice_->SetRenderState(D3DRS_BLENDOP, D3DBLENDOP_REVSUBTRACT);
                // pDevice_->SetRenderState(D3DRS_SRCBLEND, D3DBLEND_SRCALPHA);
                // pDevice_->SetRenderState(D3DRS_DESTBLEND, D3DBLEND_ONE);

                // �n�C���C�g(�����Ă�)
                // pDevice_->SetRenderState(D3DRS_BLENDOP, D3DBLENDOP_ADD);
                // pDevice_->SetRenderState(D3DRS_SRCBLEND, D3DBLEND_DESTCOLOR);
                // pDevice_->SetRenderState(D3DRS_DESTBLEND, D3DBLEND_ONE);

                // ���o�[�X(���])
                // pDevice_->SetRenderState(D3DRS_BLENDOP, D3DBLENDOP_ADD);
                // pDevice_->SetRenderState(D3DRS_SRCBLEND, D3DBLEND_INVDESTCOLOR);
                // pDevice_->SetRenderState(D3DRS_DESTBLEND, D3DBLEND_ZERO);
            }

            public void SetFillMode(uint mode)
            {
                pDevice_.SetRenderState(D3DRS_FILLMODE, mode);
            }

            public void SetFogEnable(bool bEnable)
            {
                pDevice_.SetRenderState(D3DRS_FOGENABLE, bEnable ? true : false);
            }

            public bool IsFogEnable()
            {
                uint fog = false;
                pDevice_.GetRenderState(D3DRS_FOGENABLE, fog);
                bool res = fog == true;
                return res;
            }

            public void SetVertexFog(bool bEnable, D3DCOLOR color, float start, float end)
            {
                SetFogEnable(bEnable);
                pDevice_.SetRenderState(D3DRS_FOGCOLOR,color);
                pDevice_.SetRenderState(D3DRS_FOGVERTEXMODE,D3DFOG_LINEAR);
                pDevice_.SetRenderState(D3DRS_FOGSTART, (uint)(start));
                pDevice_.SetRenderState(D3DRS_FOGEND, (uint)(end));
            }

            public void SetPixelFog(bool bEnable, D3DCOLOR color, float start, float end)
            {
            }

            public void SetTextureFilter(uint mode, int stage = 0)
            {
                switch (mode)
                {
                    case AnonymousEnum3.MODE_TEXTURE_FILTER_NONE:
                        pDevice_.SetSamplerState(stage, D3DSAMP_MINFILTER, D3DTEXF_NONE);
                        pDevice_.SetSamplerState(stage, D3DSAMP_MAGFILTER, D3DTEXF_NONE);
                        break;
                    case AnonymousEnum3.MODE_TEXTURE_FILTER_POINT:
                        pDevice_.SetSamplerState(stage, D3DSAMP_MINFILTER, D3DTEXF_POINT);
                        pDevice_.SetSamplerState(stage, D3DSAMP_MAGFILTER, D3DTEXF_POINT);
                        break;
                    case AnonymousEnum3.MODE_TEXTURE_FILTER_LINEAR:
                        pDevice_.SetSamplerState(stage, D3DSAMP_MINFILTER, D3DTEXF_LINEAR);
                        pDevice_.SetSamplerState(stage, D3DSAMP_MAGFILTER, D3DTEXF_LINEAR);
                        break;
                }
            }

            public uint GetTextureFilter(int stage = 0)
            {
                int res = (int)AnonymousEnum3.MODE_TEXTURE_FILTER_NONE;
                uint mode;
                pDevice_.GetSamplerState(stage, D3DSAMP_MINFILTER, mode);
                switch (mode)
                {
                    case D3DTEXF_NONE:
                        res = (int)AnonymousEnum3.MODE_TEXTURE_FILTER_NONE;
                        break;
                    case D3DTEXF_POINT:
                        res = (int)AnonymousEnum3.MODE_TEXTURE_FILTER_POINT;
                        break;
                    case D3DTEXF_LINEAR:
                        res = (int)AnonymousEnum3.MODE_TEXTURE_FILTER_LINEAR;
                        break;
                }
                return (uint)res;
            }


            public void SetDirectionalLight(D3DVECTOR dir)
            {
                D3DLIGHT9 light = new D3DLIGHT9();
                ZeroMemory(light, sizeof(D3DLIGHT9));
                light.Type = D3DLIGHT_DIRECTIONAL;
                light.Diffuse.r = 0.5f;
                light.Diffuse.g = 0.5f;
                light.Diffuse.b = 0.5f;
                light.Ambient.r = 0.5f;
                light.Ambient.g = 0.5f;
                light.Ambient.b = 0.5f;
                light.Direction = dir;
                pDevice_.SetLight(0, light);
                pDevice_.LightEnable(0, true);
            }

            public void SetViewPort(int x, int y, int width, int height)
            {
                D3DVIEWPORT9 viewPort = new D3DVIEWPORT9();
                ZeroMemory(viewPort, sizeof(D3DVIEWPORT9));
                viewPort.X = x;
                viewPort.Y = y;
                viewPort.Width = width;
                viewPort.Height = height;
                viewPort.MinZ = 0.0f;
                viewPort.MaxZ = 1.0f;
                pDevice_.SetViewport(viewPort);
            }

            public void ResetViewPort()
            {
                SetViewPort(0, 0, GetScreenWidth(), GetScreenHeight());
            }

            public int GetScreenWidth()
            {
                return config_.GetScreenWidth();
            }

            public int GetScreenHeight()
            {
                return config_.GetScreenHeight();
            }

            public double GetScreenWidthRatio()
            {
                RECT rect = new RECT();
                global::GetWindowRect(hAttachedWindow_, rect);
                double widthWindow = rect.right - rect.left;
                double widthView = config_.GetScreenWidth();

                uint style = global::GetWindowLong(hAttachedWindow_, GWL_STYLE);
                if (modeScreen_ == (int)AnonymousEnum2.SCREENMODE_WINDOW && (style & (WS_OVERLAPPEDWINDOW - WS_SIZEBOX)) > 0)
                {
                    widthWindow -= GetSystemMetrics(SM_CXEDGE) + GetSystemMetrics(SM_CXBORDER) + GetSystemMetrics(SM_CXDLGFRAME);
                }

                return widthWindow / widthView;
            }

            public double GetScreenHeightRatio()
            {
                RECT rect = new RECT();
                global::GetWindowRect(hAttachedWindow_, rect);
                double heightWindow = rect.bottom - rect.top;
                double heightView = config_.GetScreenHeight();

                uint style = global::GetWindowLong(hAttachedWindow_, GWL_STYLE);
                if (modeScreen_ == (int)AnonymousEnum2.SCREENMODE_WINDOW && (style & (WS_OVERLAPPEDWINDOW - WS_SIZEBOX)) > 0)
                {
                    heightWindow -= GetSystemMetrics(SM_CYEDGE) + GetSystemMetrics(SM_CYBORDER) + GetSystemMetrics(SM_CYDLGFRAME) + GetSystemMetrics(SM_CYCAPTION);
                }

                return heightWindow / heightView;
            }

            public POINT GetMousePosition()
            {
                POINT res = new POINT(0, 0);
                GetCursorPos(res);
                ScreenToClient(hAttachedWindow_, res);

                double ratioWidth = GetScreenWidthRatio();
                double ratioHeight = GetScreenHeightRatio();
                if (ratioWidth != 0)
                {
                    res.x = (int)(res.x / ratioWidth);
                }
                if (ratioHeight != 0)
                {
                    res.y = (int)(res.y / ratioHeight);
                }

                return new POINT(res);
            }

            public gstd.ref_count_ptr<DxCamera> GetCamera()
            {
                return new gstd.ref_count_ptr<DxCamera>(camera_);
            }
            public gstd.ref_count_ptr<DxCamera2D> GetCamera2D()
            {
                return new gstd.ref_count_ptr<DxCamera2D>(camera2D_);
            }

            public void SaveBackSurfaceToFile(string path)
            {
                RECT rect = new RECT(0, 0, config_.GetScreenWidth(), config_.GetScreenHeight());
                LPDIRECT3DSURFACE9 pBackSurface = null;
                pDevice_.GetRenderTarget(0, pBackSurface);
                D3DXSaveSurfaceToFile(path, D3DXIFF_BMP, pBackSurface, null, rect);
                pBackSurface.Release();
            }

            public bool IsPixelShaderSupported(int major, int minor)
            {
                D3DCAPS9 caps = new D3DCAPS9();
                pDevice_.GetDeviceCaps(caps);
                bool res = caps.PixelShaderVersion >= D3DPS_VERSION(major, minor);
                return res;
            }
    }

    /**********************************************************
    //DirectGraphicsPrimaryWindow
    **********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
    public class DirectGraphicsPrimaryWindow : DirectGraphics, gstd.WindowBase
    {
            protected gstd.WindowBase wndGraphics_ = new gstd.WindowBase();
            protected override int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
            {
                switch (uMsg)
                {
                    case WM_CLOSE:
                    {
                        global::DestroyWindow(hWnd);
                        return false;
                    }
                    case WM_DESTROY:
                    {
                        global::PostQuitMessage(0);
                        return false;
                    }
                    case WM_ACTIVATEAPP:
                    {
                        if ((bool)wParam)
                        {
                            _RestartDrawing();
                        }
                        else
                        {
                            _PauseDrawing();
                        }
                        return false;
                    }
                    case WM_ENTERMENULOOP:
                    {
                        // ���j���[���I����ꂽ�瓮����~����
                        _PauseDrawing();
                        return false;
                    }
                    case WM_EXITMENULOOP:
                    {
                        // ���j���[�̑I���������ꂽ�瓮���ĊJ����
                        _RestartDrawing();
                        return false;
                    }
                    case WM_SIZE:
                    {
                        if (wndGraphics_.GetWindowHandle() != null)
                        {
                            RECT rect = new RECT();
                            global::GetClientRect(hWnd, rect);
                            int width = rect.right;
                            int height = rect.bottom;

                            int screenWidth = config_.GetScreenWidth();
                            int screenHeight = config_.GetScreenHeight();

                            double ratioWH = (double)screenWidth / (double)screenHeight;
                            if (width > rect.right)
                            {
                                width = rect.right;
                            }
                            height = (int)(double)width / ratioWH;

                            double ratioHW = (double)screenHeight / (double)screenWidth;
                            if (height > rect.bottom)
                            {
                                height = rect.bottom;
                            }
                            width = (int)(double)height / ratioHW;

                            int wX = (rect.right - width) / 2;
                            int wY = (rect.bottom - height) / 2;
                            wndGraphics_.SetBounds(wX, wY, width, height);
                        }

                        return false;
                    }
                    case WM_GETMINMAXINFO:
                    {
                        int tw = global::GetSystemMetrics(SM_CXEDGE) + GetSystemMetrics(SM_CXBORDER) + GetSystemMetrics(SM_CXDLGFRAME);
                        int th = global::GetSystemMetrics(SM_CYEDGE) + GetSystemMetrics(SM_CYBORDER) + GetSystemMetrics(SM_CYDLGFRAME) + GetSystemMetrics(SM_CYCAPTION);

                        MINMAXINFO info = (MINMAXINFO)lParam;
                        int wWidth = global::GetSystemMetrics(SM_CXFULLSCREEN);
                        int wHeight = global::GetSystemMetrics(SM_CYFULLSCREEN);

                        int screenWidth = config_.GetScreenWidth();
                        int screenHeight = config_.GetScreenHeight();
                        int width = wWidth;
                        int height = wHeight;

                        double ratioWH = (double)screenWidth / (double)screenHeight;
                        if (width > wWidth)
                        {
                            width = wWidth;
                        }
                        height = (int)(double)width / ratioWH;

                        double ratioHW = (double)screenHeight / (double)screenWidth;
                        if (height > wHeight)
                        {
                            height = wHeight;
                        }
                        width = (int)(double)height / ratioHW;

                        info.ptMaxSize.x = width + tw;
                        info.ptMaxSize.y = height + th;
                        return false;
                    }
                    case WM_KEYDOWN:
                    {
                        switch (wParam)
                        {
                            case VK_F12:
                                global::PostMessage(hWnd,WM_CLOSE,0,0);
                                break;
                        }
                        return false;
                    }
                    case WM_SYSCHAR:
                    {
                        if (wParam == VK_RETURN)
                        {
                            this.ChangeScreenMode();
                        }
                        return false;
                    }
                }
                return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
            }

            protected void _PauseDrawing()
            {
            // 	gstd::Application::GetBase()->SetActive(false);
                // �E�C���h�E�̃��j���[�o�[��`�悷��
                global::DrawMenuBar(hWnd_);
                // �E�C���h�E�̃t���[����`�悷��
                global::RedrawWindow(hWnd_, null, null, RDW_FRAME);
            }

            protected void _RestartDrawing()
            {
                gstd.Application.GetBase().SetActive(true);
            }


            /**********************************************************
            //DirectGraphicsPrimaryWindow
            **********************************************************/
            public DirectGraphicsPrimaryWindow()
            {

            }

            public new void Dispose()
            {

                base.Dispose();
            }

            public virtual bool Initialize()
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: this->Initialize(config_);
                this.Initialize(new directx.DirectGraphicsConfig(config_));
                return true;
            }

            public virtual bool Initialize(DirectGraphicsConfig config)
            {
                IntPtr hInst = global::GetModuleHandle(null);
                {
                    string nameClass = "DirectGraphicsPrimaryWindow";
                    WNDCLASSEX wcex = new WNDCLASSEX();
                    ZeroMemory(wcex, sizeof(WNDCLASSEX));
                    wcex.cbSize = sizeof(WNDCLASSEX);
            // 		wcex.style=CS_HREDRAW|CS_VREDRAW;
                    wcex.lpfnWndProc = (WNDPROC)WindowBase._StaticWindowProcedure;
                    wcex.hInstance = hInst;
                    wcex.hIcon = null;
                    wcex.hCursor = LoadCursor(null, IDC_ARROW);
                    wcex.hbrBackground = (IntPtr)(COLOR_WINDOW + 2);
                    wcex.lpszMenuName = null;
                    wcex.lpszClassName = nameClass;
                    wcex.hIconSm = null;
                    global::RegisterClassEx(wcex);

                    int wWidth = config.GetScreenWidth();
                    int wHeight = config.GetScreenHeight();
                    int tw = global::GetSystemMetrics(SM_CXEDGE) + GetSystemMetrics(SM_CXBORDER) + GetSystemMetrics(SM_CXDLGFRAME);
                    int th = global::GetSystemMetrics(SM_CYEDGE) + GetSystemMetrics(SM_CYBORDER) + GetSystemMetrics(SM_CYDLGFRAME) + GetSystemMetrics(SM_CYCAPTION);
                    wWidth += tw;
                    wHeight += th;

                       hWnd_ = global::CreateWindow(wcex.lpszClassName, "", WS_OVERLAPPEDWINDOW - WS_SIZEBOX, 0,0,wWidth,wHeight,null,null,hInst,null);
                }


                IntPtr hWndGraphics = null;
                if (config.IsPseudoFullScreen())
                {
                    // �[���t���X�N���[���̏ꍇ�́A�q�E�B���h�E��DirectGraphics��z�u����
                    string nameClass = "DirectGraphicsPrimaryWindow.Child";
                    WNDCLASSEX wcex = new WNDCLASSEX();
                    ZeroMemory(wcex, sizeof(WNDCLASSEX));
                    wcex.cbSize = sizeof(WNDCLASSEX);
                    wcex.style = CS_HREDRAW | CS_VREDRAW;
                    wcex.lpfnWndProc = (WNDPROC)WindowBase._StaticWindowProcedure;
                    wcex.hInstance = hInst;
                    wcex.hCursor = LoadCursor(null, IDC_ARROW);
                    wcex.hbrBackground = (IntPtr)(COLOR_WINDOW + 2);
                    wcex.lpszClassName = nameClass;
                    global::RegisterClassEx(wcex);

                    int screenWidth = config_.GetScreenWidth();
                    int screenHeight = config_.GetScreenHeight();
                       IntPtr hWnd = global::CreateWindow(wcex.lpszClassName, "", WS_CHILD | WS_VISIBLE, 0,0,screenWidth,screenHeight,hWnd_,null,hInst,null);
                    wndGraphics_.Attach(hWnd);

                    hWndGraphics = hWnd;
                }
                else
                {
                    if (config.IsShowWindow())
                    {
                        global::ShowWindow(hWnd_, SW_SHOW);
                    }
                    hWndGraphics = hWnd_;
                }
                global::UpdateWindow(hWnd_);
                this.Attach(hWnd_);

            // Window���ʂ̒����Ɉړ�
                RECT drect = new RECT();
                RECT mrect = new RECT();
                IntPtr hDesk = global::GetDesktopWindow();
                global::GetWindowRect(hDesk, drect);
                global::GetWindowRect(hWnd_, mrect);
                int tWidth = mrect.right - mrect.left;
                int tHeight = mrect.bottom - mrect.top;
                int left = drect.right / 2 - tWidth / 2;
                int top = drect.bottom / 2 - tHeight / 2;
                global::MoveWindow(hWnd_,left,top,tWidth,tHeight,true);

                base.Initialize(hWndGraphics, config);

                return true;
            }

            public void ChangeScreenMode()
            {
                if (!config_.IsPseudoFullScreen())
                {
                    if (modeScreen_ == SCREENMODE_WINDOW)
                    {
                        int screenWidth = config_.GetScreenWidth();
                        int screenHeight = config_.GetScreenHeight();
                        int wWidth = global::GetSystemMetrics(SM_CXFULLSCREEN);
                        int wHeight = global::GetSystemMetrics(SM_CYFULLSCREEN);
                        bool bFullScreenEnable = screenWidth <= wWidth && screenHeight <= wHeight;
                        if (!bFullScreenEnable)
                        {
                            string log = StringUtility.Format("this display cannot change full screen : display[%d-%d] screen[%d-%d]", wWidth, wHeight, screenWidth, screenHeight);
                            Logger.WriteTop(log);
                            return;
                        }
                    }

                    Application.GetBase().SetActive(true);

                    // �e�N�X�`�����
                    _ReleaseDxResource();

                    if (modeScreen_ == SCREENMODE_FULLSCREEN)
                    {
                        pDevice_.Reset(d3dppWin_);
                        global::SetWindowLong(hAttachedWindow_, GWL_STYLE, wndStyleWin_);
                        global::ShowWindow(hAttachedWindow_, SW_SHOW);

                        // Window���ʂ̒����Ɉړ�
                        int tw = global::GetSystemMetrics(SM_CXEDGE) + GetSystemMetrics(SM_CXBORDER) + GetSystemMetrics(SM_CXDLGFRAME);
                        int th = global::GetSystemMetrics(SM_CYEDGE) + GetSystemMetrics(SM_CYBORDER) + GetSystemMetrics(SM_CYDLGFRAME) + GetSystemMetrics(SM_CYCAPTION);
                        RECT drect = new RECT();
                        RECT mrect = new RECT();
                        IntPtr hDesk = global::GetDesktopWindow();
                        global::GetWindowRect(hDesk, drect);
                        global::GetWindowRect(hAttachedWindow_, mrect);
                        int wWidth = mrect.right - mrect.left;
                        int wHeight = mrect.bottom - mrect.top;
                        int left = drect.right / 2 - wWidth / 2;
                        int top = drect.bottom / 2 - wHeight / 2;
                        global::MoveWindow(hAttachedWindow_, left, top, wWidth + tw, wHeight + th, true);

                        global::SetWindowPos(hAttachedWindow_,HWND_NOTOPMOST, 0,0,0,0, SWP_NOSIZE | SWP_NOMOVE | SWP_NOREDRAW | SWP_NOACTIVATE | SWP_NOCOPYBITS | SWP_NOSENDCHANGING);

                        modeScreen_ = SCREENMODE_WINDOW;
                        while (global::ShowCursor(true) < 0)
                        {
                        }; // �}�E�X�J�[�\����o��������
                    }
                    else
                    {
                        pDevice_.Reset(d3dppFull_);
                        global::SetWindowLong(hAttachedWindow_, GWL_STYLE, wndStyleFull_);
                        global::ShowWindow(hAttachedWindow_, SW_SHOW);
                        modeScreen_ = SCREENMODE_FULLSCREEN;
                    }

                    // �e�N�X�`�����X�g�A
                    _RestoreDxResource();
                }
                else
                {
                    if (modeScreen_ == SCREENMODE_FULLSCREEN)
                    {
                        global::SetWindowLong(hWnd_, GWL_STYLE, wndStyleWin_);
                        global::ShowWindow(hWnd_, SW_SHOW);

                        // Window���ʂ̒����Ɉړ�
                        int tw = global::GetSystemMetrics(SM_CXEDGE) + GetSystemMetrics(SM_CXBORDER) + GetSystemMetrics(SM_CXDLGFRAME);
                        int th = global::GetSystemMetrics(SM_CYEDGE) + GetSystemMetrics(SM_CYBORDER) + GetSystemMetrics(SM_CYDLGFRAME) + GetSystemMetrics(SM_CYCAPTION);

                        int wWidth = global::GetSystemMetrics(SM_CXFULLSCREEN);
                        int wHeight = global::GetSystemMetrics(SM_CYFULLSCREEN);
                        int screenWidth = config_.GetScreenWidth();
                        int screenHeight = config_.GetScreenHeight();
                        int width = screenWidth;
                        int height = screenHeight;

                        double ratioWH = (double)screenWidth / (double)screenHeight;
                        if (width > wWidth)
                        {
                            width = wWidth;
                        }
                        height = (int)(double)width / ratioWH;

                        double ratioHW = (double)screenHeight / (double)screenWidth;
                        if (height > wHeight)
                        {
                            height = wHeight;
                        }
                        width = (int)(double)height / ratioHW;

                        width += tw;
                        height += th;

                        SetBounds(0, 0, width, height);
                        MoveWindowCenter();

                        modeScreen_ = SCREENMODE_WINDOW;
                    }
                    else
                    {
                        RECT rect = new RECT();
                        GetWindowRect(GetDesktopWindow(), rect);
                        global::SetWindowLong(hWnd_, GWL_STYLE, wndStyleFull_);
                        global::ShowWindow(hWnd_, SW_SHOW);
                        global::MoveWindow(hWnd_, 0, 0, rect.right, rect.bottom, true);

                        modeScreen_ = SCREENMODE_FULLSCREEN;
                    }
                }

            }
    }

    /**********************************************************
    //DxCamera
    **********************************************************/
    public class DxCamera : System.IDisposable
    {
            private D3DXVECTOR3 pos_ = new D3DXVECTOR3(); // �œ_
            private float radius_;
            private float angleAzimuth_;
            private float angleElevation_;
            private D3DXMATRIX matProjection_ = new D3DXMATRIX();

            private float yaw_;
            private float pitch_;
            private float roll_;

            private double clipNear_;
            private double clipFar_;


            /**********************************************************
            //DxCamera
            **********************************************************/
            public DxCamera()
            {
                Reset();
            }

            public virtual void Dispose()
            {

            }

            public void Reset()
            {
                radius_ = 500F;
                angleAzimuth_ = 15F;
                angleElevation_ = 45F;
                pos_.x = 0;
                pos_.y = 0;
                pos_.z = 0;

                yaw_ = 0F;
                pitch_ = 0F;
                roll_ = 0F;

                clipNear_ = 10;
                clipFar_ = 2000;
            }

            public D3DXVECTOR3 GetCameraPosition()
            {
                D3DXVECTOR3 res = new D3DXVECTOR3();
                res.x = pos_.x + (float)(radius_ * System.Math.Cos(D3DXToRadian(angleElevation_)) * System.Math.Cos(D3DXToRadian(angleAzimuth_)));
                res.y = pos_.y + (float)(radius_ * System.Math.Sin(D3DXToRadian(angleElevation_)));
                res.z = pos_.z + (float)(radius_ * System.Math.Cos(D3DXToRadian(angleElevation_)) * System.Math.Sin(D3DXToRadian(angleAzimuth_)));
                return new D3DXVECTOR3(res);
            }

            public D3DXVECTOR3 GetFocusPosition()
            {
                return new D3DXVECTOR3(pos_);
            }
            public void SetFocus(float x, float y, float z)
            {
                pos_.x = x;
                pos_.y = y;
                pos_.z = z;
            }
            public void SetFocusX(float x)
            {
                pos_.x = x;
            }
            public void SetFocusY(float y)
            {
                pos_.y = y;
            }
            public void SetFocusZ(float z)
            {
                pos_.z = z;
            }
            public float GetRadius()
            {
                return radius_;
            }
            public void SetRadius(float r)
            {
                radius_ = r;
            }
            public float GetAzimuthAngle()
            {
                return angleAzimuth_;
            }
            public void SetAzimuthAngle(float angle)
            {
                angleAzimuth_ = angle;
            }
            public float GetElevationAngle()
            {
                return angleElevation_;
            }
            public void SetElevationAngle(float angle)
            {
                angleElevation_ = angle;
            }

            public float GetYaw()
            {
                return yaw_;
            }
            public void SetYaw(float yaw)
            {
                yaw_ = yaw;
            }
            public float GetPitch()
            {
                return pitch_;
            }
            public void SetPitch(float pitch)
            {
                pitch_ = pitch;
            }
            public float GetRoll()
            {
                return roll_;
            }
            public void SetRoll(float roll)
            {
                roll_ = roll;
            }

            public double GetNearClip()
            {
                return clipNear_;
            }
            public double GetFarClip()
            {
                return clipFar_;
            }

            public D3DXMATRIX GetMatrixLookAtLH()
            {
                D3DXMATRIX res = new D3DXMATRIX();
                D3DXVECTOR3 posCamera = GetCameraPosition();

                D3DXVECTOR3 vCameraUp = new D3DXVECTOR3(0, 1, 0);
                {
                    D3DXQUATERNION qRot = new D3DXQUATERNION(0, 0, 0, 1.0f);
                    D3DXQuaternionRotationYawPitchRoll(qRot, Math.DegreeToRadian(yaw_), Math.DegreeToRadian(pitch_), Math.DegreeToRadian(roll_));
                    D3DXMATRIX matRot = new D3DXMATRIX();
                    D3DXMatrixRotationQuaternion(matRot, qRot);
                    D3DXVec3TransformCoord((D3DXVECTOR3) vCameraUp, (D3DXVECTOR3) vCameraUp, matRot);
                }

                D3DXVECTOR3 posTo = new D3DXVECTOR3(pos_);
                {
                    D3DXMATRIX matTrans1 = new D3DXMATRIX();
                    D3DXMatrixTranslation(matTrans1, -posCamera.x, -posCamera.y, -posCamera.z);
                    D3DXMATRIX matTrans2 = new D3DXMATRIX();
                    D3DXMatrixTranslation(matTrans2, posCamera.x, posCamera.y, posCamera.z);

                    float pitch = pitch_;

                    D3DXQUATERNION qRot = new D3DXQUATERNION(0, 0, 0, 1.0f);
                    D3DXQuaternionRotationYawPitchRoll(qRot, Math.DegreeToRadian(yaw_), Math.DegreeToRadian(pitch_), Math.DegreeToRadian(0));
                    D3DXMATRIX matRot = new D3DXMATRIX();
                    D3DXMatrixRotationQuaternion(matRot, qRot);

                    D3DXMATRIX mat = new D3DXMATRIX();
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = matTrans1 * matRot * matTrans2;
                    mat.CopyFrom(matTrans1 * matRot * matTrans2);
                    D3DXVec3TransformCoord((D3DXVECTOR3) posTo, (D3DXVECTOR3) posTo, mat);
                }

                D3DXMatrixLookAtLH(res, posCamera, posTo, vCameraUp);
                return new D3DXMATRIX(res);
            }

            public void UpdateDeviceWorldViewMatrix()
            {
                DirectGraphics graph = DirectGraphics.GetBase();
                if (graph == null)
                {
                    return;
                }
                IDirect3DDevice9 device = graph.GetDevice();

                D3DXMATRIX matView = GetMatrixLookAtLH();
                device.SetTransform(D3DTS_VIEW, matView);
            }

            public void SetProjectionMatrix(float width, float height, float posNear, float posFar)
            {
                DirectGraphics graph = DirectGraphics.GetBase();
                if (graph == null)
                {
                    return;
                }
                IDirect3DDevice9 device = graph.GetDevice();

                D3DXMatrixPerspectiveFovLH(matProjection_, D3DXToRadian(45.0), width / height, posNear, posFar);

                if (clipNear_ < 1)
                {
                    clipNear_ = 1;
                }
                if (clipFar_ < 1)
                {
                    clipFar_ = 1;
                }
                clipNear_ = posNear;
                clipFar_ = posFar;

            /*
            	ref_count_ptr<DxCamera2D> camera2D = graph->GetCamera2D();
            	D3DXVECTOR2 pos = camera2D->GetLeftTopPosition();
            	double ratio = camera2D->GetRatio();
            	D3DXMATRIX matScale;
            	D3DXMatrixScaling(&matScale, ratio, ratio, 1.0);
            	D3DXMATRIX matTrans;
            	D3DXMatrixTranslation(&matTrans, pos.x / width, pos.y / height, 0);
            
            	persMat = persMat * matScale;
            	persMat = persMat * matTrans;
            */


            }

            public void UpdateDeviceProjectionMatrix()
            {
                DirectGraphics graph = DirectGraphics.GetBase();
                if (graph == null)
                {
                    return;
                }
                IDirect3DDevice9 device = graph.GetDevice();
                device.SetTransform(D3DTS_PROJECTION, matProjection_);
            }

            public D3DXVECTOR2 TransformCoordinateTo2D(D3DXVECTOR3 pos)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                IDirect3DDevice9 device = graphics.GetDevice();
                int width = graphics.GetConfigData().GetScreenWidth();
                int height = graphics.GetConfigData().GetScreenHeight();

                D3DXMATRIX matView = new D3DXMATRIX();
                device.GetTransform(D3DTS_VIEW, matView);
                D3DXMATRIX matPers = new D3DXMATRIX();
                device.GetTransform(D3DTS_PROJECTION, matPers);

                D3DXMATRIX mat = matView * matPers;
                D3DXVECTOR4 vect = new D3DXVECTOR4();
                vect.x = pos.x;
                vect.y = pos.y;
                vect.z = pos.z;
                vect.w = 1;

                float vx = vect.x;
                float vy = vect.y;
                float vz = vect.z;

                vect.x = (vx * mat._11) + (vy * mat._21) + (vz * mat._31) + mat._41;
                vect.y = (vx * mat._12) + (vy * mat._22) + (vz * mat._32) + mat._42;
                vect.z = (vx * mat._13) + (vy * mat._23) + (vz * mat._33) + mat._43;
                vect.w = (vx * mat._14) + (vy * mat._24) + (vz * mat._34) + mat._44;

                if (vect.w > 0)
                {
                    vect.x = width / 2 + (vect.x / vect.w) * width / 2;
                    vect.y = height / 2 - (vect.y / vect.w) * height / 2; // �x�����͏オ���ƂȂ邽��
                }

                D3DXVECTOR2 res = new D3DXVECTOR2(vect.x, vect.y);
                return new D3DXVECTOR2(res);
            }
    }

    /**********************************************************
    //DxCamera2D
    **********************************************************/
    public class DxCamera2D : System.IDisposable
    {

            private bool bEnable_;
            private D3DXVECTOR2 pos_ = new D3DXVECTOR2(); // �œ_
            private double ratioX_; // �g�嗦
            private double ratioY_;
            private double angleZ_;
            private RECT rcClip_ = new RECT(); // ����

            private gstd.ref_count_ptr<D3DXVECTOR2> posReset_ = new gstd.ref_count_ptr<D3DXVECTOR2>();

            /**********************************************************
            //DxCamera2D
            **********************************************************/
            public DxCamera2D()
            {
                pos_.x = 400;
                pos_.y = 300;
                ratioX_ = 1.0;
                ratioY_ = 1.0;
                angleZ_ = 0;
                bEnable_ = false;
            }

            public virtual void Dispose()
            {
            }

            public bool IsEnable()
            {
                return bEnable_;
            }
            public void SetEnable(bool bEnable)
            {
                bEnable_ = bEnable;
            }

            public D3DXVECTOR2 GetFocusPosition()
            {
                return new D3DXVECTOR2(pos_);
            }
            public float GetFocusX()
            {
                return pos_.x;
            }
            public float GetFocusY()
            {
                return pos_.y;
            }
            public void SetFocus(float x, float y)
            {
                pos_.x = x;
                pos_.y = y;
            }
            public void SetFocus(D3DXVECTOR2 pos)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: pos_ = pos;
                pos_.CopyFrom(pos);
            }
            public void SetFocusX(float x)
            {
                pos_.x = x;
            }
            public void SetFocusY(float y)
            {
                pos_.y = y;
            }
            public double GetRatio()
            {
                return System.Math.Max(ratioX_, ratioY_);
            }
            public void SetRatio(double ratio)
            {
                ratioX_ = ratio;
                ratioY_ = ratio;
            }
            public double GetRatioX()
            {
                return ratioX_;
            }
            public void SetRatioX(double ratio)
            {
                ratioX_ = ratio;
            }
            public double GetRatioY()
            {
                return ratioY_;
            }
            public void SetRatioY(double ratio)
            {
                ratioY_ = ratio;
            }
            public double GetAngleZ()
            {
                return angleZ_;
            }
            public void SetAngleZ(double angle)
            {
                angleZ_ = angle;
            }

            public RECT GetClip()
            {
                return new RECT(rcClip_);
            }
            public void SetClip(RECT rect)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcClip_ = rect;
                rcClip_.CopyFrom(rect);
            }

            public void SetResetFocus(gstd.ref_count_ptr<D3DXVECTOR2> pos)
            {
                posReset_.CopyFrom(pos);
            }
            public void Reset()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                int width = graphics.GetScreenWidth();
                int height = graphics.GetScreenHeight();
                if (posReset_ == null)
                {
                    pos_.x = width / 2;
                    pos_.y = height / 2;
                }
                else
                {
                    pos_.x = posReset_.x;
                    pos_.y = posReset_.y;
                }
                ratioX_ = 1.0;
                ratioY_ = 1.0;
                SetRect(rcClip_, 0, 0, width, height);

                angleZ_ = 0;
            }

            public D3DXVECTOR2 GetLeftTopPosition()
            {
                return new D3DXVECTOR2(GetLeftTopPosition(new D3DXVECTOR2(pos_), ratioX_, ratioY_, new RECT(rcClip_)));
            }

            public static D3DXVECTOR2 GetLeftTopPosition(D3DXVECTOR2 focus, double ratio)
            {
                return new D3DXVECTOR2(GetLeftTopPosition(new D3DXVECTOR2(focus), ratio, ratio));
            }

            public static D3DXVECTOR2 GetLeftTopPosition(D3DXVECTOR2 focus, double ratioX, double ratioY)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                int width = graphics.GetScreenWidth();
                int height = graphics.GetScreenHeight();
                RECT rcClip = new RECT();
                ZeroMemory(rcClip, sizeof(RECT));
                rcClip.right = width;
                rcClip.bottom = height;
                return new D3DXVECTOR2(GetLeftTopPosition(new D3DXVECTOR2(focus), ratioX, ratioY, new RECT(rcClip)));
            }

            public static D3DXVECTOR2 GetLeftTopPosition(D3DXVECTOR2 focus, double ratioX, double ratioY, RECT rcClip)
            {
                int width = rcClip.right - rcClip.left;
                int height = rcClip.bottom - rcClip.top;

                int cx = rcClip.left + width / 2; // ��ʂ̒��S���Wx
                int cy = rcClip.top + height / 2; // ��ʂ̒��S���Wy

                int dx = focus.x - cx; // ���t�H�[�J�X�ł̉�ʍ��[�ʒu
                int dy = focus.y - cy; // ���t�H�[�J�X�ł̉�ʏ�[�ʒu

                D3DXVECTOR2 res = new D3DXVECTOR2();
                res.x = cx - dx * ratioX; // ���t�H�[�J�X�ł̉�ʒ��S�̈ʒu(x���W�ϊ���)
                res.y = cy - dy * ratioY; // ���t�H�[�J�X�ł̉�ʒ��S�̈ʒu(y���W�ϊ���)

                res.x -= (width / 2) * ratioX; // ���t�H�[�J�X�ł̉�ʍ��̈ʒu(x���W�ϊ���)
                res.y -= (height / 2) * ratioY; // ���t�H�[�J�X�ł̉�ʒ��S�̈ʒu(x���W�ϊ���)

                return new D3DXVECTOR2(res);
            }

            public D3DXMATRIX GetMatrix()
            {
                D3DXVECTOR2 pos = GetLeftTopPosition();
                D3DXMATRIX matScale = new D3DXMATRIX();
                D3DXMatrixScaling(matScale, ratioX_, ratioY_, 1.0);
                D3DXMATRIX matTrans = new D3DXMATRIX();
                D3DXMatrixTranslation(matTrans, pos.x, pos.y, 0);

                D3DXMATRIX matAngleZ = new D3DXMATRIX();
                D3DXMatrixIdentity(matAngleZ);
                if (angleZ_ != 0)
                {
                    D3DXMATRIX matTransRot1 = new D3DXMATRIX();
                    D3DXMatrixTranslation(matTransRot1, -GetFocusX() + pos.x, -GetFocusY() + pos.y, 0);
                    D3DXMATRIX matRot = new D3DXMATRIX();
                    D3DXMatrixRotationYawPitchRoll(matRot, 0, 0, D3DXToRadian(angleZ_));
                    D3DXMATRIX matTransRot2 = new D3DXMATRIX();
                    D3DXMatrixTranslation(matTransRot2, GetFocusX() - pos.x, GetFocusY() - pos.y, 0);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: matAngleZ = matTransRot1 * matRot * matTransRot2;
                    matAngleZ.CopyFrom(matTransRot1 * matRot * matTransRot2);
                }

                D3DXMATRIX mat = new D3DXMATRIX();
                D3DXMatrixIdentity(mat);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matScale;
                mat.CopyFrom(mat * matScale);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matAngleZ;
                mat.CopyFrom(mat * matAngleZ);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matTrans;
                mat.CopyFrom(mat * matTrans);
                return new D3DXMATRIX(mat);
            }
    }
}
