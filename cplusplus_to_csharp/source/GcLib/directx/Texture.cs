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
//    class TextureData;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class Texture;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class TextureManager;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class TextureInfoPanel;

    /**********************************************************
    //Texture
    **********************************************************/
    public class TextureData : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend Texture;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend TextureManager;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend TextureInfoPanel;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                TYPE_TEXTURE,
                TYPE_RENDER_TARGET
            }
            protected int type_;
            protected TextureManager manager_;
            protected IDirect3DTexture9 pTexture_;
            protected D3DXIMAGE_INFO infoImage_ = new D3DXIMAGE_INFO();
            protected string name_ = "";
// C++ TO C# CONVERTER TODO TASK: 'volatile' has a different meaning in C#:
// ORIGINAL LINE: volatile bool bLoad_;
            protected bool bLoad_;

            protected IDirect3DSurface9 lpRenderSurface_; // �o�b�N�o�b�t�@����(�����_�����O�^�[�Q�b�g�p)
            protected IDirect3DSurface9 lpRenderZ_; // �o�b�N�o�b�t�@��Z�o�b�t�@����(�����_�����O�^�[�Q�b�g�p)

            /**********************************************************
            //TextureData
            **********************************************************/
            public TextureData()
            {
                manager_ = null;
                pTexture_ = null;
                lpRenderSurface_ = null;
                lpRenderZ_ = null;
                bLoad_ = true;

                ZeroMemory(infoImage_, sizeof(D3DXIMAGE_INFO));
                type_ = (int)AnonymousEnum.TYPE_TEXTURE;
            }

            public virtual void Dispose()
            {
                if (pTexture_ != null)
                {
                    pTexture_.Release();
                }
                if (lpRenderSurface_ != null)
                {
                    lpRenderSurface_.Release();
                }
                if (lpRenderZ_ != null)
                {
                    lpRenderZ_.Release();
                }
            }

            public string GetName()
            {
                return name_;
            }
            public D3DXIMAGE_INFO GetImageInfo()
            {
                return new D3DXIMAGE_INFO(infoImage_);
            }
    }

    public class Texture : gstd.FileManager.LoadObject, System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend TextureData;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend TextureManager;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend TextureInfoPanel;
            protected gstd.ref_count_ptr<TextureData> data_ = new gstd.ref_count_ptr<TextureData>();
            protected TextureData _GetTextureData()
            {
                return data_.GetPointer();
            }

            /**********************************************************
            //Texture
            **********************************************************/
            public Texture()
            {
            }

            public Texture(Texture texture)
            {
                {
                    Lock @lock = new Lock(TextureManager.GetBase().GetLock());
                    data_.CopyFrom(texture.data_);
                }
            }

            public virtual void Dispose()
            {
                Release();
            }

            public void Release()
            {
                {
                    Lock @lock = new Lock(TextureManager.GetBase().GetLock());
                    if (data_ != null)
                    {
                        TextureManager manager = data_.manager_;
                        if (manager != null && manager.IsDataExists(data_.name_))
                        {
                            int countRef = data_.GetReferenceCount();
                            // ���g��TextureManager��̐������ɂȂ�����폜
                            if (countRef == 2)
                            {
                                manager._ReleaseTextureData(data_.name_);
                            }
                        }
                        data_ = null;
                    }
                }
            }

            public string GetName()
            {
                string res = "";
                {
                    Lock @lock = new Lock(TextureManager.GetBase().GetLock());
                    if (data_ != null)
                    {
                        res = data_.GetName();
                    }
                }
                return res;
            }

            public bool CreateFromFile(string path)
            {
                path = PathProperty.GetUnique(path);

                bool res = false;
                {
                    Lock @lock = new Lock(TextureManager.GetBase().GetLock());
                    if (data_ != null)
                    {
                        Release();
                    }
                    TextureManager manager = TextureManager.GetBase();
                    ref_count_ptr<Texture> texture = manager.CreateFromFile(path);
                    if (texture != null)
                    {
                        data_ = texture.data_;
                    }
                    res = data_ != null;
                }

                return res;
            }

            public bool CreateRenderTarget(string name)
            {
                bool res = false;
                {
                    Lock @lock = new Lock(TextureManager.GetBase().GetLock());
                    if (data_ != null)
                    {
                        Release();
                    }
                    TextureManager manager = TextureManager.GetBase();
                    ref_count_ptr<Texture> texture = manager.CreateRenderTarget(name);
                    if (texture != null)
                    {
                        data_ = texture.data_;
                    }
                    res = data_ != null;
                }
                return res;
            }

            public bool CreateFromFileInLoadThread(string path, bool bLoadImageInfo = false)
            {
                path = PathProperty.GetUnique(path);

                bool res = false;
                {
                    Lock @lock = new Lock(TextureManager.GetBase().GetLock());
                    if (data_ != null)
                    {
                        Release();
                    }
                    TextureManager manager = TextureManager.GetBase();
                    ref_count_ptr<Texture> texture = manager.CreateFromFileInLoadThread(path, bLoadImageInfo);
                    if (texture != null)
                    {
                        data_ = texture.data_;
                    }
                    res = data_ != null;
                }

                return res;
            }

            public void SetTexture(IDirect3DTexture9 pTexture)
            {
                {
                    Lock @lock = new Lock(TextureManager.GetBase().GetLock());
                    if (data_ != null)
                    {
                        Release();
                    }
                    TextureData textureData = new TextureData();
                    textureData.pTexture_ = pTexture;
                    D3DSURFACE_DESC desc = new D3DSURFACE_DESC();
                    pTexture.GetLevelDesc(0, desc);

                    D3DXIMAGE_INFO infoImage = textureData.infoImage_;
                    infoImage.Width = desc.Width;
                    infoImage.Height = desc.Height;
                    infoImage.Format = desc.Format;
                    infoImage.ImageFileFormat = D3DXIFF_BMP;
                    infoImage.ResourceType = D3DRTYPE_TEXTURE;
                    data_ = textureData;
                }
            }

            public IDirect3DTexture9 GetD3DTexture()
            {
                IDirect3DTexture9 res = null;
                {
                    bool bWait = true;
                    int time = timeGetTime();
                    while (bWait)
                    {
                        Lock @lock = new Lock(TextureManager.GetBase().GetLock());
                        if (data_ != null)
                        {
                            bWait = !data_.bLoad_;
                            if (!bWait)
                            {
                                res = _GetTextureData().pTexture_;
                            }

                            if (bWait && System.Math.Abs((int)(timeGetTime() - time)) > 10000)
                            {
                                // ��莞�Ԃ����Ă���߂������烍�b�N�H
                                string path = data_.GetName();
                                Logger.WriteTop(StringUtility.Format("�e�N�X�`���ǂݍ��݂�s���Ă��܂���B���b�N�H �F%s", path));
                                data_.bLoad_ = true;
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }

                        if (bWait)
                        {
                            global::Sleep(1);
                        }
                    }

                }
                return res;
            }

            public IDirect3DSurface9 GetD3DSurface()
            {
                IDirect3DSurface9 res = null;
                {
                    Lock @lock = new Lock(TextureManager.GetBase().GetLock());
                    if (data_ != null)
                    {
                        res = _GetTextureData().lpRenderSurface_;
                    }
                }
                return res;
            }

            public IDirect3DSurface9 GetD3DZBuffer()
            {
                IDirect3DSurface9 res = null;
                {
                    Lock @lock = new Lock(TextureManager.GetBase().GetLock());
                    if (data_ != null)
                    {
                        res = _GetTextureData().lpRenderZ_;
                    }
                }
                return res;
            }

            public int GetWidth()
            {
                int res = 0;
                {
                    Lock @lock = new Lock(TextureManager.GetBase().GetLock());
                    TextureData data = _GetTextureData();
                    if (data != null)
                    {
                        res = data.infoImage_.Width;
                    }
                }
                return res;
            }

            public int GetHeight()
            {
                int res = 0;
                {
                    Lock @lock = new Lock(TextureManager.GetBase().GetLock());
                    TextureData data = _GetTextureData();
                    if (data != null)
                    {
                        res = data.infoImage_.Height;
                    }
                }
                return res;
            }

            public bool IsLoad()
            {
                return data_ != null && data_.bLoad_;
            }
    }

    /**********************************************************
    //TextureManager
    **********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
    public class TextureManager : DirectGraphicsListener, gstd.FileManager.LoadThreadListener
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend Texture;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend TextureData;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend TextureInfoPanel;
        private static TextureManager thisBase_ = null;
            public const string TARGET_TRANSITION = "__RENDERTARGET_TRANSITION__";
            protected gstd.CriticalSection lock_ = new gstd.CriticalSection();
            protected SortedDictionary<string, gstd.ref_count_ptr<Texture>> mapTexture_ = new SortedDictionary<string, gstd.ref_count_ptr<Texture>>();
            protected SortedDictionary<string, gstd.ref_count_ptr<TextureData>> mapTextureData_ = new SortedDictionary<string, gstd.ref_count_ptr<TextureData>>();
            protected gstd.ref_count_ptr<TextureInfoPanel> panelInfo_ = new gstd.ref_count_ptr<TextureInfoPanel>();

            protected void _ReleaseTextureData(string name)
            {
                {
                    Lock @lock = new Lock(lock_);
                    if (IsDataExists(name))
                    {
                        mapTextureData_[name].bLoad_ = true; // �ǂݍ��݊�������
                        mapTextureData_.Remove(name);
                        Logger.WriteTop(StringUtility.Format("TextureManager�F�e�N�X�`���������܂���[%s]", name));
                    }
                }
            }

            protected bool _CreateFromFile(string path)
            {
                if (IsDataExists(path))
                {
                    return true;
                }

                // �܂��쐬����Ă��Ȃ��Ȃ�A�쐬
                try
                {
                    ref_count_ptr<FileReader> reader = FileManager.GetBase().GetFileReader(path);
                    if (reader == null)
                    {
                        throw new gstd.wexception("�t�@�C����������܂���");
                    }
                    if (!reader.Open())
                    {
                        throw new gstd.wexception("�t�@�C�����J���܂���");
                    }

                    int size = reader.GetFileSize();
                    ByteBuffer buf = new ByteBuffer();
                    buf.SetSize(size);
                    reader.Read(buf.GetPointer(), size);

            // 		D3DXIMAGE_INFO info;
            // 		D3DXGetImageInfoFromFileInMemory(buf.GetPointer(), size, &info);

                    D3DCOLOR colorKey = D3DCOLOR_ARGB(255,0,0,0);
                    if (path.IndexOf(".bmp") == -1) // bmp�̂݃J���[�L�[�K��
                    {
                        colorKey = 0;
                    }
                    D3DFORMAT pixelFormat = D3DFMT_A8R8G8B8;

                    ref_count_ptr<TextureData> data = new ref_count_ptr<TextureData>(new TextureData());

                    int hr = D3DXCreateTextureFromFileInMemoryEx(DirectGraphics.GetBase().GetDevice(), buf.GetPointer(), size, D3DX_DEFAULT, D3DX_DEFAULT, 0, 0, pixelFormat, D3DPOOL_MANAGED, D3DX_FILTER_BOX, D3DX_DEFAULT, colorKey, null, null, data.pTexture_);
                    if (FAILED(hr))
                    {
                        throw new gstd.wexception("D3DXCreateTextureFromFileInMemoryEx���s");
                    }

                    mapTextureData_[path] = data;
                    data.manager_ = this;
                    data.name_ = path;
                    D3DXGetImageInfoFromFileInMemory(buf.GetPointer(), size, data.infoImage_);

                    Logger.WriteTop(StringUtility.Format("TextureManager�F�e�N�X�`����ǂݍ��݂܂���[%s]", path));
                }
                catch (gstd.wexception e)
                {
                    string str = StringUtility.Format("TextureManager�F�e�N�X�`���ǂݍ��ݎ��s[%s]\n\t%s", path, e.what());
                    Logger.WriteTop(str);
                    return false;
                }

                return true;
            }

            protected bool _CreateRenderTarget(string name)
            {
                if (IsDataExists(name))
                {
                    return true;
                }

                bool res = true;
                try
                {
                    ref_count_ptr<TextureData> data = new TextureData();
                    DirectGraphics graphics = DirectGraphics.GetBase();
                    int screenWidth = graphics.GetScreenWidth();
                    int screenHeight = graphics.GetScreenHeight();
                    int width = 2;
                    int height = 2;
                    while (width <= screenWidth)
                    {
                        width *= 2;
                    }
                    while (height <= screenHeight)
                    {
                        height *= 2;
                    }

                    int hr;
                    hr = graphics.GetDevice().CreateDepthStencilSurface(width, height, D3DFMT_D16, D3DMULTISAMPLE_NONE, 0, false, data.lpRenderZ_, null);
                    if (FAILED(hr))
                    {
                        throw false;
                    }
                    D3DFORMAT fmt = D3DFMT_A8R8G8B8;
                    hr = graphics.GetDevice().CreateTexture(width, height, 1, D3DUSAGE_RENDERTARGET, fmt, D3DPOOL_DEFAULT, data.pTexture_, null);
                    if (FAILED(hr))
                    {
                        // �e�N�X�`���𐳕��`�ɂ���
                        if (width > height)
                        {
                            height = width;
                        }
                        else if (height > width)
                        {
                            width = height;
                        }
                        hr = graphics.GetDevice().CreateDepthStencilSurface(width, height, D3DFMT_D16, D3DMULTISAMPLE_NONE, 0, false, data.lpRenderZ_, null);
                        if (FAILED(hr))
                        {
                            throw false;
                        }
                        D3DFORMAT fmt = D3DFMT_A8R8G8B8;
                        hr = graphics.GetDevice().CreateTexture(width, height, 1, D3DUSAGE_RENDERTARGET, fmt, D3DPOOL_DEFAULT, data.pTexture_, null);
                        if (FAILED(hr))
                        {
                            throw false;
                        }
                    }
                    data.pTexture_.GetSurfaceLevel(0, data.lpRenderSurface_);

                    mapTextureData_[name] = data;
                    data.manager_ = this;
                    data.name_ = name;
                    data.type_ = TextureData.TYPE_RENDER_TARGET;
                    data.infoImage_.Width = width;
                    data.infoImage_.Height = height;

                    Logger.WriteTop(StringUtility.Format("TextureManager�F�����_�����O�^�[�Q�b�g�쐬[%s]", name));

                }
                catch
                {
                    Logger.WriteTop(StringUtility.Format("TextureManager�F�����_�����O�^�[�Q�b�g�쐬���s[%s]", name));
                    res = false;
                }

                return res;
            }

            /**********************************************************
            //TextureManager
            **********************************************************/
            public TextureManager()
            {

            }

            public override void Dispose()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.RemoveDirectGraphicsListener(this);
                this.Clear();

                FileManager.GetBase().RemoveLoadThreadListener(this);

                panelInfo_ = null;
                thisBase_ = null;
                base.Dispose();
            }

            public static TextureManager GetBase()
            {
                return thisBase_;
            }
            public virtual bool Initialize()
            {
                if (thisBase_ != null)
                {
                    return false;
                }

                thisBase_ = this;
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.AddDirectGraphicsListener(this);

                ref_count_ptr<Texture> texTransition = new Texture();
                bool res = texTransition.CreateRenderTarget(TARGET_TRANSITION);
                Add(TARGET_TRANSITION, new ref_count_ptr<Texture>(texTransition));

                FileManager.GetBase().AddLoadThreadListener(this);

                return res;
            }

            public gstd.CriticalSection GetLock()
            {
                return new gstd.CriticalSection(lock_);
            }

            public virtual void Clear()
            {
                {
                    Lock @lock = new Lock(lock_);
                    mapTexture_.Clear();
                    mapTextureData_.Clear();
                }
            }

            public virtual void Add(string name, gstd.ref_count_ptr<Texture> texture)
            {
                {
                    Lock @lock = new Lock(lock_);
                    bool bExist = mapTexture_.ContainsKey(name);
                    if (!bExist)
                    {
                        mapTexture_[name].CopyFrom(texture);
                    }
                }
            }

            public virtual void Release(string name)
            {
                {
                    Lock @lock = new Lock(lock_);
                    mapTexture_.Remove(name);
                }
            }

            public virtual bool IsDataExists(string name)
            {
                bool res = false;
                {
                    Lock @lock = new Lock(lock_);
                    res = mapTextureData_.ContainsKey(name);
                }
                return res;
            }

            public override void ReleaseDirectGraphics()
            {
                ReleaseDxResource();
            }
            public override void RestoreDirectGraphics()
            {
                RestoreDxResource();
            }
            public void ReleaseDxResource()
            {
                SortedDictionary<string, gstd.ref_count_ptr<TextureData>>.Enumerator itrMap;
                {
                    Lock @lock = new Lock(GetLock());
                    for (itrMap = mapTextureData_.GetEnumerator(); itrMap.MoveNext();)
                    {
                        string name = itrMap.Current.Key;
                        TextureData data = (itrMap.Current.Value).GetPointer();
                        if (data.type_ == TextureData.TYPE_RENDER_TARGET)
                        {
                            if (data.pTexture_ != null)
                            {
                                data.pTexture_.Release();
                            }
                            if (data.lpRenderSurface_ != null)
                            {
                                data.lpRenderSurface_.Release();
                            }
                            if (data.lpRenderZ_ != null)
                            {
                                data.lpRenderZ_.Release();
                            }
                        }
                    }
                }
            }

            public void RestoreDxResource()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                SortedDictionary<string, gstd.ref_count_ptr<TextureData>>.Enumerator itrMap;
                {
                    Lock @lock = new Lock(GetLock());
                    for (itrMap = mapTextureData_.GetEnumerator(); itrMap.MoveNext();)
                    {
                        string name = itrMap.Current.Key;
                        TextureData data = (itrMap.Current.Value).GetPointer();
                        if (data.type_ == TextureData.TYPE_RENDER_TARGET)
                        {
                            int width = data.infoImage_.Width;
                            int height = data.infoImage_.Height;

                            int hr;
                            // Z�o�b�t�@����
                            hr = graphics.GetDevice().CreateDepthStencilSurface(width, height, D3DFMT_D16, D3DMULTISAMPLE_NONE, 0, false, data.lpRenderZ_, null);
                            // �e�N�X�`���쐬
                            D3DFORMAT fmt = new D3DFORMAT();
                            if (graphics.GetScreenMode() == DirectGraphics.SCREENMODE_FULLSCREEN)
                            {
                                fmt = graphics.GetFullScreenPresentParameter().BackBufferFormat;
                            }
                            else
                            {
                                fmt = graphics.GetWindowPresentParameter().BackBufferFormat;
                            }

                            hr = graphics.GetDevice().CreateTexture(width, height, 1, D3DUSAGE_RENDERTARGET, fmt, D3DPOOL_DEFAULT, data.pTexture_, null);
                            data.pTexture_.GetSurfaceLevel(0, data.lpRenderSurface_);
                        }
                    }
                }
            }

            public gstd.ref_count_ptr<TextureData> GetTextureData(string name)
            {
                gstd.ref_count_ptr<TextureData> res = new gstd.ref_count_ptr<TextureData>();
                {
                    Lock @lock = new Lock(lock_);
                    bool bExist = mapTextureData_.ContainsKey(name);
                    if (bExist)
                    {
                        res.CopyFrom(mapTextureData_[name]);
                    }
                }
                return new gstd.ref_count_ptr<TextureData>(res);
            }

            public gstd.ref_count_ptr<Texture> CreateFromFile(string path)
            {
                path = PathProperty.GetUnique(path);
                gstd.ref_count_ptr<Texture> res = new gstd.ref_count_ptr<Texture>();
                {
                    Lock @lock = new Lock(lock_);
                    bool bExist = mapTexture_.ContainsKey(path);
                    if (bExist)
                    {
                        res.CopyFrom(mapTexture_[path]);
                    }
                    else
                    {
                        bool bSuccess = _CreateFromFile(path);
                        if (bSuccess)
                        {
                            res = new Texture();
                            res.data_ = mapTextureData_[path];
                        }
                    }
                }
                return new gstd.ref_count_ptr<Texture>(res);
            }

            public gstd.ref_count_ptr<Texture> CreateRenderTarget(string name)
            {
                gstd.ref_count_ptr<Texture> res = new gstd.ref_count_ptr<Texture>();
                {
                    Lock @lock = new Lock(lock_);
                    bool bExist = mapTexture_.ContainsKey(name);
                    if (bExist)
                    {
                        res.CopyFrom(mapTexture_[name]);
                    }
                    else
                    {
                        bool bSuccess = _CreateRenderTarget(name);
                        if (bSuccess)
                        {
                            res = new Texture();
                            res.data_ = mapTextureData_[name];
                        }
                    }
                }
                return new gstd.ref_count_ptr<Texture>(res);
            }

            public gstd.ref_count_ptr<Texture> GetTexture(string name)
            {
                gstd.ref_count_ptr<Texture> res = new gstd.ref_count_ptr<Texture>();
                {
                    Lock @lock = new Lock(lock_);
                    bool bExist = mapTexture_.ContainsKey(name);
                    if (bExist)
                    {
                        res.CopyFrom(mapTexture_[name]);
                    }
                }
                return new gstd.ref_count_ptr<Texture>(res);
            }

            public gstd.ref_count_ptr<Texture> CreateFromFileInLoadThread(string path, bool bLoadImageInfo = false)
            {
                path = PathProperty.GetUnique(path);
                gstd.ref_count_ptr<Texture> res = new gstd.ref_count_ptr<Texture>();
                {
                    Lock @lock = new Lock(lock_);
                    bool bExist = mapTexture_.ContainsKey(path);

                    if (bExist)
                    {
                        res.CopyFrom(mapTexture_[path]);
                    }
                    else
                    {
                        bool bLoadTarget = true;
                        res = new Texture();
                        if (!IsDataExists(path))
                        {
                            ref_count_ptr<TextureData> data = new ref_count_ptr<TextureData>(new TextureData());
                            mapTextureData_[path] = data;
                            data.manager_ = this;
                            data.name_ = path;
                            data.bLoad_ = false;

                            // �摜��񂾂����O�ɓǂݍ���
                            if (bLoadImageInfo)
                            {
                                try
                                {
                                    ref_count_ptr<FileReader> reader = FileManager.GetBase().GetFileReader(path);
                                    if (reader == null)
                                    {
                                        throw new gstd.wexception("�t�@�C����������܂���");
                                    }
                                    if (!reader.Open())
                                    {
                                        throw new gstd.wexception("�t�@�C�����J���܂���");
                                    }

                                    int size = reader.GetFileSize();
                                    ByteBuffer buf = new ByteBuffer();
                                    buf.SetSize(size);
                                    reader.Read(buf.GetPointer(), size);

                                    D3DXIMAGE_INFO info = new D3DXIMAGE_INFO();
                                    int hr = D3DXGetImageInfoFromFileInMemory(buf.GetPointer(), size, info);
                                    if (FAILED(hr))
                                    {
                                        throw new gstd.wexception("D3DXGetImageInfoFromFileInMemory���s");
                                    }

                                    data.infoImage_ = info;
                                }
                                catch (gstd.wexception e)
                                {
                                    string str = StringUtility.Format("TextureManager�F�e�N�X�`���ǂݍ��ݎ��s[%s]\n\t%s", path, e.what());
                                    Logger.WriteTop(str);
                                    data.bLoad_ = true; // �ǂݍ��݊�������
                                    bLoadTarget = false;
                                }
                            }
                        }
                        else
                        {
                            bLoadTarget = false;
                        }

                        res.data_ = mapTextureData_[path];
                        if (bLoadTarget)
                        {
                            ref_count_ptr<FileManager.LoadObject> source = new ref_count_ptr<FileManager.LoadObject>(res);
                            ref_count_ptr<FileManager.LoadThreadEvent> @event = new FileManager.LoadThreadEvent(this, path, res);
                            FileManager.GetBase().AddLoadThreadEvent(@event);

                        }
                    }
                }
                return new gstd.ref_count_ptr<Texture>(res);
            }

            public virtual void CallFromLoadThread(ref_count_ptr<FileManager.LoadThreadEvent> @event)
            {
                string path = @event.GetPath();
                {
                    Lock @lock = new Lock(lock_);
                    ref_count_ptr<Texture> texture = new ref_count_ptr<Texture>(@event.GetSource());
                    if (texture == null)
                    {
                        return;
                    }

                    ref_count_ptr<TextureData> data = texture.data_;
                    if (data == null || data.bLoad_)
                    {
                        return;
                    }

                    int countRef = data.GetReferenceCount();
                    // ���g��TextureManager��̐������ɂȂ�����ǂݍ��܂Ȃ��B
                    if (countRef <= 2)
                    {
                        data.bLoad_ = true; // �O�̂��ߓǂݍ��݊�������
                        return;
                    }

                    try
                    {
                        ref_count_ptr<FileReader> reader = FileManager.GetBase().GetFileReader(path);
                        if (reader == null)
                        {
                            throw new gstd.wexception("�t�@�C����������܂���");
                        }
                        if (!reader.Open())
                        {
                            throw new gstd.wexception("�t�@�C�����J���܂���");
                        }

                        int size = reader.GetFileSize();
                        ByteBuffer buf = new ByteBuffer();
                        buf.SetSize(size);
                        reader.Read(buf.GetPointer(), size);

                        D3DCOLOR colorKey = D3DCOLOR_ARGB(255,0,0,0);
                        if (path.IndexOf(".bmp") == -1) // bmp�̂݃J���[�L�[�K��
                        {
                            colorKey = 0;
                        }

                        D3DFORMAT pixelFormat = D3DFMT_A8R8G8B8;

                        int hr = D3DXCreateTextureFromFileInMemoryEx(DirectGraphics.GetBase().GetDevice(), buf.GetPointer(), size, D3DX_DEFAULT, D3DX_DEFAULT, 0, 0, pixelFormat, D3DPOOL_MANAGED, D3DX_FILTER_BOX, D3DX_DEFAULT, colorKey, null, null, data.pTexture_);
                        if (FAILED(hr))
                        {
                            throw new gstd.wexception("D3DXCreateTextureFromFileInMemoryEx���s");
                        }

                        D3DXGetImageInfoFromFileInMemory(buf.GetPointer(), size, data.infoImage_);

                        Logger.WriteTop(StringUtility.Format("TextureManager�F�e�N�X�`����ǂݍ��݂܂���(LT)[%s]", path));
                    }
                    catch (gstd.wexception e)
                    {
                        string str = StringUtility.Format("TextureManager�F�e�N�X�`���ǂݍ��ݎ��s(LT)[%s]\n\t%s", path, e.what());
                        Logger.WriteTop(str);
                    }
                    data.bLoad_ = true;
                }
            }

            public void SetInfoPanel(gstd.ref_count_ptr<TextureInfoPanel> panel)
            {
                panelInfo_.CopyFrom(panel);
            }
    }

    /**********************************************************
    //TextureInfoPanel
    **********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
    public class TextureInfoPanel : gstd.WindowLogger.Panel, gstd.Thread, System.IDisposable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            protected enum AnonymousEnum2
            {
                    ROW_ADDRESS,
                    ROW_NAME,
                    ROW_FULLNAME,
                    ROW_COUNT_REFFRENCE,
                    ROW_WIDTH_IMAGE,
                    ROW_HEIGHT_IMAGE
            }
            protected int timeUpdateInterval_;
            protected gstd.WListView wndListView_ = new gstd.WListView();
            protected virtual bool _AddedLogger(IntPtr hTab)
            {
                Create(hTab);

                gstd.WListView.Style styleListView = new gstd.WListView.Style();
                styleListView.SetStyle(WS_CHILD | WS_VISIBLE | LVS_REPORT | LVS_SHOWSELALWAYS | LVS_SINGLESEL | LVS_NOSORTHEADER);
                styleListView.SetStyleEx(WS_EX_CLIENTEDGE);
                styleListView.SetListViewStyleEx(LVS_EX_FULLROWSELECT | LVS_EX_GRIDLINES);
                wndListView_.Create(hWnd_, styleListView);

                wndListView_.AddColumn(64, (int)AnonymousEnum2.ROW_ADDRESS, "Address");
                wndListView_.AddColumn(96, (int)AnonymousEnum2.ROW_NAME, "Name");
                wndListView_.AddColumn(48, (int)AnonymousEnum2.ROW_FULLNAME, "FullName");
                wndListView_.AddColumn(32, (int)AnonymousEnum2.ROW_COUNT_REFFRENCE, "Ref");
                wndListView_.AddColumn(48, (int)AnonymousEnum2.ROW_WIDTH_IMAGE, "Width");
                wndListView_.AddColumn(48, (int)AnonymousEnum2.ROW_HEIGHT_IMAGE, "Height");

                Start();

                return true;
            }

            protected void _Run()
            {
                while (GetStatus() == RUN)
                {
                    TextureManager manager = TextureManager.GetBase();
                    if (manager != null)
                    {
                        Update(manager);
                    }
                    Sleep(timeUpdateInterval_);
                }
            }


            /**********************************************************
            //TextureInfoPanel
            **********************************************************/
            public TextureInfoPanel()
            {
                timeUpdateInterval_ = 500;
            }

            public void Dispose()
            {
                Stop();
                Join(1000);
            }

            public virtual void LocateParts()
            {
                int wx = GetClientX();
                int wy = GetClientY();
                int wWidth = GetClientWidth();
                int wHeight = GetClientHeight();

                wndListView_.SetBounds(wx, wy, wWidth, wHeight);
            }

            public virtual void Update(TextureManager manager)
            {
                if (!IsWindowVisible())
                {
                    return;
                }
                SortedSet<string> setKey = new SortedSet<string>();
                SortedDictionary<string, gstd.ref_count_ptr<TextureData>>.Enumerator itrMap;
                {
                    Lock @lock = new Lock(manager.GetLock());

                    SortedDictionary<string, gstd.ref_count_ptr<TextureData>> mapData = manager.mapTextureData_;
                    for (itrMap = mapData.GetEnumerator(); itrMap.MoveNext();)
                    {
                        string name = itrMap.Current.Key;
                        TextureData data = (itrMap.Current.Value).GetPointer();

                        int address = (int)data;
                        string key = StringUtility.Format("%08x", address);
                        int index = wndListView_.GetIndexInColumn(key, (int)AnonymousEnum2.ROW_ADDRESS);
                        if (index == -1)
                        {
                            index = wndListView_.GetRowCount();
                            wndListView_.SetText(index, (int)AnonymousEnum2.ROW_ADDRESS, key);
                        }

                        int countRef = (itrMap.Current.Value).GetReferenceCount();
                        D3DXIMAGE_INFO infoImage = data.infoImage_;

                        wndListView_.SetText(index, (int)AnonymousEnum2.ROW_NAME, PathProperty.GetFileName(name));
                        wndListView_.SetText(index, (int)AnonymousEnum2.ROW_FULLNAME, name);
                        wndListView_.SetText(index, (int)AnonymousEnum2.ROW_COUNT_REFFRENCE, StringUtility.Format("%d", countRef));
                        wndListView_.SetText(index, (int)AnonymousEnum2.ROW_WIDTH_IMAGE, StringUtility.Format("%d", infoImage.Width));
                        wndListView_.SetText(index, (int)AnonymousEnum2.ROW_HEIGHT_IMAGE, StringUtility.Format("%d", infoImage.Height));

                        setKey.Add(key);
                    }
                }

                for (int iRow = 0; iRow < wndListView_.GetRowCount();)
                {
                    string key = wndListView_.GetText(iRow, (int)AnonymousEnum2.ROW_ADDRESS);
                    if (setKey.find(key) != setKey.end())
                    {
                        iRow++;
                    }
                    else
                    {
                        wndListView_.DeleteRow(iRow);
                    }
                }
            }
    }
}
