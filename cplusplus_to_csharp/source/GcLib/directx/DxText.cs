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
//    class DxChar;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxCharCache;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxCharCacheKey;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxTextRenderer;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxText;

    /**********************************************************
    //DxFont
    **********************************************************/
    public class DxFont : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxCharCache;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxCharCacheKey;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                BORDER_NONE,
                BORDER_FULL,
                BORDER_SHADOW
            }
            protected LOGFONT info_ = new LOGFONT(); // �t�H���g���
            protected D3DCOLOR colorTop_ = new D3DCOLOR();
            protected D3DCOLOR colorBottom_ = new D3DCOLOR();
            protected int typeBorder_; // �����
            protected int widthBorder_;
            protected D3DCOLOR colorBorder_ = new D3DCOLOR(); // �����F

            /**********************************************************
            //DxFont
            **********************************************************/
            public DxFont()
            {
                ZeroMemory(info_, sizeof(LOGFONT));
                colorTop_ = D3DCOLOR_ARGB(255,128,128,255);
                colorBottom_ = D3DCOLOR_ARGB(255,32,32,255);
                typeBorder_ = (int)AnonymousEnum.BORDER_NONE;
                widthBorder_ = 2;
                colorBorder_ = D3DCOLOR_ARGB(128,255,255,255);
            }

            public virtual void Dispose()
            {

            }

            public void SetLogFont(LOGFONT font)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: info_ = font;
                info_.CopyFrom(font);
            }
            public LOGFONT GetLogFont()
            {
                return new LOGFONT(info_);
            }
            public void SetTopColor(D3DCOLOR color)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: colorTop_ = color;
                colorTop_.CopyFrom(color);
            }
            public D3DCOLOR GetTopColor()
            {
                return new D3DCOLOR(colorTop_);
            }
            public void SetBottomColor(D3DCOLOR color)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: colorBottom_ = color;
                colorBottom_.CopyFrom(color);
            }
            public D3DCOLOR GetBottomColor()
            {
                return new D3DCOLOR(colorBottom_);
            }
            public void SetBorderType(int type)
            {
                typeBorder_ = type;
            }
            public int GetBorderType()
            {
                return typeBorder_;
            }
            public void SetBorderWidth(int width)
            {
                widthBorder_ = width;
            }
            public int GetBorderWidth()
            {
                return widthBorder_;
            }
            public void SetBorderColor(D3DCOLOR color)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: colorBorder_ = color;
                colorBorder_.CopyFrom(color);
            }
            public D3DCOLOR GetBorderColor()
            {
                return new D3DCOLOR(colorBorder_);
            }
    }

    /**********************************************************
    //DxChar
    //����1�����̃e�N�X�`��
    **********************************************************/
    public class DxChar : System.IDisposable
    {
            private gstd.ref_count_ptr<Texture> texture_ = new gstd.ref_count_ptr<Texture>();
            private int code_;
            private DxFont font_ = new DxFont();

            private int width_;
            private int height_;

            /**********************************************************
            //DxChar
            **********************************************************/
            public DxChar()
            {

            }

            public virtual void Dispose()
            {
            }

            public bool Create(int code, Font winFont, DxFont dxFont)
            {
                code_ = code;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: font_ = dxFont;
                font_.CopyFrom(dxFont);

                int typeBorder = font_.GetBorderType();
                D3DCOLOR colorTop = font_.GetTopColor();
                D3DCOLOR colorBottom = font_.GetBottomColor();
                D3DCOLOR colorBorder = font_.GetBorderColor();
                int widthBorder = typeBorder != DxFont.BORDER_NONE ? font_.GetBorderWidth() : 0;

                IntPtr hDC = global::GetDC(null);
                IntPtr oldFont = (IntPtr)SelectObject(hDC, winFont.GetHandle());

                // �t�H���g�r�b�g�}�b�v�擾
                TEXTMETRIC tm = new TEXTMETRIC();
                global::GetTextMetrics(hDC, tm);
                GLYPHMETRICS gm = new GLYPHMETRICS();
                CONST MAT2 mat =
                {
                    { 0,1 },
                    { 0,0 },
                    { 0,0 },
                    { 0,1 }
                };
                int uFormat = GGO_GRAY2_BITMAP; // typeBorder == DxFont::BORDER_FULL ? GGO_BITMAP : GGO_GRAY2_BITMAP;
                if (dxFont.GetLogFont().lfHeight <= 12)
                {
                    uFormat = GGO_BITMAP;
                }
                uint size = global::GetGlyphOutline(hDC, code, uFormat, gm, 0, null, mat);
                ref_count_ptr<byte> ptr = new byte[size];
                global::GetGlyphOutline(hDC, code, uFormat, gm, size, ptr.GetPointer(), mat);

                // �f�o�C�X�R���e�L�X�g�ƃt�H���g�n���h���̉��
                global::SelectObject(hDC, oldFont);
                global::ReleaseDC(null, hDC);

                // �e�N�X�`���쐬
                int tex_x = gm.gmCellIncX + widthBorder * 2;
                int tex_y = tm.tmHeight + widthBorder * 2;
                int widthTexture = 0;
                int heightTexture = 0;
                int num_x = 1;
                while (true)
                {
                    tex_x /= 2;
                    if (tex_x == 0)
                    {
                        widthTexture = System.Math.Pow(2.0, num_x);
                        break;
                    }
                    num_x++;
                }
                int num_y = 1;
                while (true)
                {
                    tex_y /= 2;
                    if (tex_y == 0)
                    {
                        heightTexture = System.Math.Pow(2.0, num_y);
                        break;
                    }
                    num_y++;
                }
                IDirect3DTexture9 pTexture = null;
                int hr = DirectGraphics.GetBase().GetDevice().CreateTexture(widthTexture, heightTexture, 1, D3DPOOL_DEFAULT, D3DFMT_A8R8G8B8, D3DPOOL_MANAGED, pTexture, null);
                if (FAILED(hr))
                {
                    return false;
                }

                D3DLOCKED_RECT @lock = new D3DLOCKED_RECT();
                if (FAILED(pTexture.LockRect(0, @lock, null, D3DLOCK_DISCARD)))
                {
                    return false;
                }
                int iOfs_x = gm.gmptGlyphOrigin.x;
                int iOfs_y = tm.tmAscent - gm.gmptGlyphOrigin.y;
                int iBmp_w = uFormat != GGO_BITMAP ? gm.gmBlackBoxX + (4 - (gm.gmBlackBoxX % 4)) % 4 : gm.gmBlackBoxX;
                int iBmp_h = gm.gmBlackBoxY;
                int level = 5; // GGO_GRAY4_BITMAP;
                FillMemory(@lock.pBits, @lock.Pitch * tm.tmHeight, 0);

                double gapColor = 1.0 / (double)iBmp_h;
                double gapColorR = (double)(ColorAccess.GetColorR(new D3DCOLOR(colorTop)) - ColorAccess.GetColorR(new D3DCOLOR(colorBottom))) * gapColor;
                double gapColorG = (double)(ColorAccess.GetColorG(colorTop) - ColorAccess.GetColorG(colorBottom)) * gapColor;
                double gapColorB = (double)(ColorAccess.GetColorB(colorTop) - ColorAccess.GetColorB(colorBottom)) * gapColor;

                int xMax = iBmp_w + iOfs_x + widthBorder * 2;
                int yMax = iBmp_h + iOfs_y + widthBorder * 2;
                for (int iy = 0; iy < yMax && size > 0; iy++)
                {
                    int yBmp = iy - iOfs_y - widthBorder;
                    int colorR = (int)ColorAccess.GetColorR(new D3DCOLOR(colorTop)) - gapColorR * yBmp;
                    int colorG = (int)ColorAccess.GetColorG(colorTop) - gapColorG * yBmp;
                    int colorB = (int)ColorAccess.GetColorB(colorTop) - gapColorB * yBmp;

                    for (int ix = 0; ix < xMax; ix++)
                    {
                        int xBmp = ix - iOfs_x - widthBorder;

                        uint alpha = 255;
                        if (uFormat != GGO_BITMAP)
                        {
                            int posBmp = xBmp + iBmp_w * yBmp;
                            alpha = (uint)(xBmp >= 0 && xBmp < iBmp_w && yBmp >= 0 && yBmp < iBmp_h? (255 * ptr[posBmp]) / (level - 1) : 0);
                        }
                        else
                        {
                            if (xBmp >= 0 && xBmp < iBmp_w && yBmp >= 0 && yBmp < iBmp_h)
                            {
                                int lineByte = (1 + (iBmp_w / 32)) * 4; // 1�s�Ɏg�p���Ă���BYTE���i4�o�C�g���E����j
                                int posBmp = xBmp / 8 + lineByte * yBmp;
                                alpha = (uint)(BitAccess.GetBit(ptr[posBmp], 7 - xBmp % 8) ? 255 : 0);
                            }
                            else
                            {
                                alpha = 0;
                            }
                        }

                        uint color = 0;
                        if (typeBorder != DxFont.BORDER_NONE && alpha != 255)
                        {
                            if (alpha == 0)
                            {
                                int count = 0;
                                int antiDist = 0;
                                int bx = typeBorder == DxFont.BORDER_FULL ? xBmp + widthBorder + antiDist : xBmp + 1;
                                int by = typeBorder == DxFont.BORDER_FULL ? yBmp + widthBorder + antiDist : yBmp + 1;
                                int minAlphaEnableDist = 255 * 255;
                                for (int ax = xBmp - widthBorder - antiDist; ax <= bx;ax++)
                                {
                                    for (int ay = yBmp - widthBorder - antiDist; ay <= by;ay++)
                                    {
                                        int dist = System.Math.Abs(ax - xBmp) + System.Math.Abs(ay - yBmp);
                                        if (dist > widthBorder + antiDist || dist == 0)
                                        {
                                            continue;
                                        }

                                        uint tAlpha = 255;
                                        if (uFormat != GGO_BITMAP)
                                        {
                                            tAlpha = (uint)(ax >= 0 && ax < iBmp_w && ay >= 0 && ay < iBmp_h? (255 * ptr[ax + iBmp_w * ay]) / (level - 1) : 0);
                                        }
                                        else
                                        {
                                            if (ax >= 0 && ax < iBmp_w && ay >= 0 && ay < iBmp_h)
                                            {
                                                int lineByte = (1 + (iBmp_w / 32)) * 4; // 1�s�Ɏg�p���Ă���BYTE���i4�o�C�g���E����j
                                                int tPos = ax / 8 + lineByte * ay;
                                                tAlpha = (uint)(BitAccess.GetBit(ptr[tPos], 7 - ax % 8) ? 255 : 0);
                                            }
                                            else
                                            {
                                                tAlpha = 0;
                                            }
                                        }

                                        if (tAlpha > 0)
                                        {
                                            minAlphaEnableDist = System.Math.Min(minAlphaEnableDist, dist);
                                        }

                                        int tCount = (int)tAlpha /= dist;
                                        tCount *= 2;
                                        if (typeBorder == DxFont.BORDER_SHADOW && (ax >= xBmp || ay >= yBmp))
                                        {
                                            tCount /= 2;
                                        }
                                        count += tCount;

                                    }
                                }
                                color = colorBorder;

                                int destAlpha = 0;
                                if (minAlphaEnableDist < widthBorder)
                                {
                                    destAlpha = 255;
                                }
                                else if (minAlphaEnableDist == widthBorder)
                                {
                                    destAlpha = count;
                                }
                                else
                                {
                                    destAlpha = 0;
                                }
                                // color = ColorAccess::SetColorA(color, ColorAccess::GetColorA(colorBorder)*count/255);
                                color = ColorAccess.SetColorA(color, ColorAccess.GetColorA(colorBorder) * destAlpha / 255);
                            }
                            else
                            {
                                int oAlpha = (int)(alpha + 64);
                                if (alpha > 255)
                                {
                                    alpha = 255;
                                }

                                int count = 0;
                                int cDist = 1;
                                int bx = typeBorder == DxFont.BORDER_FULL ? xBmp + cDist : xBmp + 1;
                                int by = typeBorder == DxFont.BORDER_FULL ? yBmp + cDist : yBmp + 1;
                                for (int ax = xBmp - cDist; ax <= bx;ax++)
                                {
                                    for (int ay = yBmp - cDist; ay <= by;ay++)
                                    {
                                        uint tAlpha = 255;
                                        if (uFormat != GGO_BITMAP)
                                        {
                                            tAlpha = tAlpha = (uint)(ax >= 0 && ax < iBmp_w && ay >= 0 && ay < iBmp_h? (255 * ptr[ax + iBmp_w * ay]) / (level - 1) : 0);
                                        }
                                        else
                                        {
                                            if (ax >= 0 && ax < iBmp_w && ay >= 0 && ay < iBmp_h)
                                            {
                                                int lineByte = (1 + (iBmp_w / 32)) * 4; // 1�s�Ɏg�p���Ă���BYTE���i4�o�C�g���E����j
                                                int tPos = ax / 8 + lineByte * ay;
                                                tAlpha = (uint)(BitAccess.GetBit(ptr[tPos], 7 - ax % 8) ? 255 : 0);
                                            }
                                            else
                                            {
                                                tAlpha = 0;
                                            }
                                        }

                                        if (tAlpha > 0)
                                        {
                                            count++;
                                        }
                                    }
                                }
                                if (count >= 2)
                                {
                                    oAlpha = (int)alpha;
                                }

                                int bAlpha = 255 - oAlpha;
                                color = ColorAccess.SetColorA(color, 255);
                                color = ColorAccess.SetColorR(color, colorR * oAlpha / 255 + ColorAccess.GetColorR(new D3DCOLOR(colorBorder)) * bAlpha / 255);
                                color = ColorAccess.SetColorG(color, colorG * oAlpha / 255 + ColorAccess.GetColorG(colorBorder) * bAlpha / 255);
                                color = ColorAccess.SetColorB(color, colorB * oAlpha / 255 + ColorAccess.GetColorB(colorBorder) * bAlpha / 255);
                            }
                        }
                        else
                        {
                            if (typeBorder != DxFont.BORDER_NONE && alpha > 0)
                            {
                                alpha = 255;
                            }
                            color = (uint)(0x00ffffff | (alpha << 24));
                            color = ColorAccess.SetColorR(color, colorR);
                            color = ColorAccess.SetColorG(color, colorG);
                            color = ColorAccess.SetColorB(color, colorB);
                        }
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                        memcpy((byte)@lock.pBits + @lock.Pitch * iy + 4 * ix, color, sizeof(uint));
                    }
                }
                pTexture.UnlockRect(0);

                texture_ = new Texture();
                texture_.SetTexture(pTexture);

                width_ = gm.gmCellIncX + widthBorder * 2;
                height_ = tm.tmHeight + widthBorder * 2;

                return true;
            }

            public gstd.ref_count_ptr<Texture> GetTexture()
            {
                return new gstd.ref_count_ptr<Texture>(texture_);
            }
            public int GetWidth()
            {
                return width_;
            }
            public int GetHeight()
            {
                return height_;
            }
            public LOGFONT GetInfo()
            {
                return new LOGFONT(font_.GetLogFont());
            }
    }


    /**********************************************************
    //DxCharCache
    //�����L���b�V��
    **********************************************************/
    public class DxCharCacheKey
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxCharCache;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxTextRenderer;
            private int code_;
            private DxFont font_ = new DxFont();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator ==(const DxCharCacheKey& key)const
            public static bool operator == (DxCharCacheKey ImpliedObject, DxCharCacheKey key)
            {
                bool res = true;
                res &= (ImpliedObject.code_ == key.code_);
                res &= (ImpliedObject.font_.colorTop_ == key.font_.colorTop_);
                res &= (ImpliedObject.font_.colorBottom_ == key.font_.colorBottom_);
                res &= (ImpliedObject.font_.typeBorder_ == key.font_.typeBorder_);
                res &= (ImpliedObject.font_.widthBorder_ == key.font_.widthBorder_);
                res &= (ImpliedObject.font_.colorBorder_ == key.font_.colorBorder_);
                if (!res)
                {
                    return res;
                }
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                res &= (memcmp(key.font_.info_, ImpliedObject.font_.info_, sizeof(LOGFONT)) == 0);
                return res;
            }
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator <(const DxCharCacheKey& key)const
            public static bool operator < (DxCharCacheKey ImpliedObject, DxCharCacheKey key)
            {
                if (ImpliedObject.code_ != key.code_)
                {
                    return ImpliedObject.code_ < key.code_;
                }
                if (ImpliedObject.font_.colorTop_ != key.font_.colorTop_)
                {
                    return ImpliedObject.font_.colorTop_ < key.font_.colorTop_;
                }
                if (ImpliedObject.font_.colorBottom_ != key.font_.colorBottom_)
                {
                    return ImpliedObject.font_.colorBottom_ < key.font_.colorBottom_;
                }
// 				if(font_.typeBorder_ != key.font_.typeBorder_)return (font_.typeBorder_ != key.font_.typeBorder_ );
                if (ImpliedObject.font_.widthBorder_ != key.font_.widthBorder_)
                {
                    return ImpliedObject.font_.widthBorder_ < key.font_.widthBorder_;
                }
                if (ImpliedObject.font_.colorBorder_ != key.font_.colorBorder_)
                {
                    return ImpliedObject.font_.colorBorder_ < key.font_.colorBorder_;
                }
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                return (memcmp(key.font_.info_, ImpliedObject.font_.info_, sizeof(LOGFONT)) < 0);
            }
    }
    public class DxCharCache : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxTextRenderer;
            private int sizeMax_;
            private int countPri_;
            private SortedDictionary<DxCharCacheKey, gstd.ref_count_ptr<DxChar>> mapCache_ = new SortedDictionary<DxCharCacheKey, gstd.ref_count_ptr<DxChar>>();
            private SortedDictionary<int, DxCharCacheKey > mapPriKey_ = new SortedDictionary<int, DxCharCacheKey >();
            private SortedDictionary<DxCharCacheKey, int > mapKeyPri_ = new SortedDictionary<DxCharCacheKey, int >();

            private void _arrange()
            {
                countPri_ = 0;
                SortedDictionary<int, DxCharCacheKey > mapPriKeyLast = mapPriKey_;
                mapPriKey_.Clear();
                mapKeyPri_.Clear();
                SortedDictionary<int, DxCharCacheKey >.Enumerator itr;
                for (itr = mapPriKeyLast.GetEnumerator(); itr.MoveNext();)
                {
                    DxCharCacheKey key = itr.Current.Value;
                    int pri = countPri_;

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mapPriKey_[pri] = key;
                    mapPriKey_[pri].CopyFrom(key);
                    mapKeyPri_[key] = pri;

                    countPri_++;
                }
            }


            /**********************************************************
            //DxCharCache
            **********************************************************/
            public DxCharCache()
            {
                sizeMax_ = 512;
                countPri_ = 0;
            }

            public void Dispose()
            {
                Clear();
            }

            public void Clear()
            {
                mapPriKey_.Clear();
                mapKeyPri_.Clear();
                mapCache_.Clear();
            }

            public int GetCacheCount()
            {
                return mapCache_.Count;
            }

            public ref_count_ptr<DxChar> GetChar(DxCharCacheKey key)
            {
                gstd.ref_count_ptr<DxChar> res = new gstd.ref_count_ptr<DxChar>();
                bool bExist = mapCache_.ContainsKey(key);
                if (bExist)
                {
                    res.CopyFrom(mapCache_[key]);
            /*
            		//�L�[�̗D�揇�ʂ�g�b�v�ɂ���
            		int tPri = mapKeyPri_[key];
            		mapPriKey_.erase(tPri);
            
            		countPri_++;
            		int nPri = countPri_;
            		mapKeyPri_[key] = nPri;
            		mapPriKey_[nPri] = key;
            
            		if(countPri_ >= INT_MAX)
            		{
            			//�Ĕz�u
            			_arrange();
            		}
            */
                }
                return new gstd.ref_count_ptr<DxChar>(res);
            }

            public void AddChar(DxCharCacheKey key, ref_count_ptr<DxChar> value)
            {
                bool bExist = mapCache_.ContainsKey(key);
                if (bExist)
                {
                    return;
                }
                mapCache_[key] = value;

                if (mapCache_.Count >= sizeMax_)
                {
                    mapCache_.Clear();
            /*
            		//�D��x�̒Ⴂ�L���b�V����폜
            		std::map<int, DxCharCacheKey>::iterator itrMinPri = mapPriKey_.begin();
            		int minPri = itrMinPri->first;
            		DxCharCacheKey keyMinPri = itrMinPri->second;
            
            		mapCache_.erase(keyMinPri);
            		mapKeyPri_.erase(keyMinPri);
            		mapPriKey_.erase(minPri);
            */
                }
            }
    }

    /**********************************************************
    //DxTextScanner
    **********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxTextScanner;
    public class DxTextToken : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxTextScanner;
            public enum Type
            {
                TK_UNKNOWN,
                TK_EOF,
                TK_NEWLINE,
                TK_ID,
                TK_INT,
                TK_REAL,
                TK_STRING,

                TK_OPENP,
                TK_CLOSEP,
                TK_OPENB,
                TK_CLOSEB,
                TK_OPENC,
                TK_CLOSEC,
                TK_SHARP,

                TK_COMMA,
                TK_EQUAL,
                TK_ASTERISK,
                TK_SLASH,
                TK_COLON,
                TK_SEMICOLON,
                TK_TILDE,
                TK_EXCLAMATION,
                TK_PLUS,
                TK_MINUS,
                TK_LESS,
                TK_GREATER,

                TK_TEXT
            }
            protected Type type_;
            protected string element_ = "";
            public DxTextToken()
            {
                type_ = Type.TK_UNKNOWN;
            }
            public DxTextToken(Type type, string element)
            {
                type_ = type;
                element_ = element;
            }

            public virtual void Dispose()
            {
            }
            public Type GetType()
            {
                return type_;
            }
            public string GetElement()
            {
                return element_;
            }

            public int GetInteger()
            {
                if (type_ != Type.TK_INT)
                {
                    throw new gstd.wexception("DxTextToken::GetInterger:�f�[�^�̃^�C�v���Ⴂ�܂�");
                }
                int res = StringUtility.ToInteger(element_);
                return res;
            }

            public double GetReal()
            {
                if (type_ != Type.TK_REAL && type_ != Type.TK_INT)
                {
                    throw new gstd.wexception("DxTextToken::GetReal:�f�[�^�̃^�C�v���Ⴂ�܂�");
                }

                double res = StringUtility.ToDouble(element_);
                return res;
            }

            public bool GetBoolean()
            {
                bool res = false;
                if (type_ == Type.TK_REAL && type_ == Type.TK_INT)
                {
                    res = GetReal() == 1;
                }
                else
                {
                    res = element_ == "true";
                }
                return res;
            }

            public string GetString()
            {
                if (type_ != Type.TK_STRING)
                {
                    throw new gstd.wexception("DxTextToken::GetString:�f�[�^�̃^�C�v���Ⴂ�܂�");
                }
                return element_.Substring(1,element_.Length - 2);
            }


            // DxTextToken
            public string GetIdentifier()
            {
                if (type_ != Type.TK_ID)
                {
                    throw new gstd.wexception("DxTextToken::GetIdentifier:�f�[�^�̃^�C�v���Ⴂ�܂�");
                }
                return element_;
            }
    }

    public class DxTextScanner : System.IDisposable
    {
            public const int TOKEN_TAG_START = DxTextToken.TK_OPENB;
            public const int TOKEN_TAG_END = DxTextToken.TK_CLOSEB;
            public const string TAG_START = "[";
            public const string TAG_END = "]";
            public const string TAG_NEW_LINE = "r";
            public const string TAG_RUBY = "ruby";
            public const string TAG_FONT = "font";
            protected int line_;
            protected List<char> buffer_ = new List<char>();
            protected List<char>.Enumerator pointer_; // ���̈ʒu
            protected DxTextToken token_ = new DxTextToken(); // ���݂̃g�[�N��
            protected boolean bTagScan_ = new boolean();

            protected char _NextChar()
            {
                if (HasNext() == false)
                {
                    string source;
                    source.resize(buffer_.Count);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                    memcpy(source[0], buffer_[0], source.Length * sizeof(char));
                    string log = StringUtility.Format("_NextChar(Text):���łɕ�����I�[�ł� -> %s", source);
                    _RaiseError(log);
                }

// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                pointer_++;

// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                if (pointer_ == '\n')
                {
                    line_++;
                }
                return new List<char>.Enumerator(pointer_);
            }

            protected virtual void _SkipComment()
            {
                while (true)
                {
                    List<char>.Enumerator posStart = pointer_;
                    _SkipSpace();

// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    char ch = pointer_;

                    if (ch == '/')
                    { // �R�����g�A�E�g����
                        List<char>.Enumerator tPos = pointer_;
                        ch = _NextChar();
                        if (ch == '/')
                        { // "//"
                            while (true)
                            {
                                ch = _NextChar();
                                if (ch == '\r' || ch == '\n')
                                {
                                    break;
                                }
                            }
                        }
                        else if (ch == '*')
                        { // "/*"-"*/"
                            while (true)
                            {
                                ch = _NextChar();
                                if (ch == '*')
                                {
                                    ch = _NextChar();
                                    if (ch == '/')
                                    {
                                        break;
                                    }
                                }
                            }
                            ch = _NextChar();
                        }
                        else
                        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: pointer_ = tPos;
                            pointer_.CopyFrom(tPos);
                            ch = '/';
                        }
                    }

                    // �X�L�b�v��󔒔�΂�������ꍇ�A�I��
                    if (posStart == pointer_)
                    {
                        break;
                    }
                }
            }

            protected virtual void _SkipSpace()
            {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                char ch = pointer_;
                while (true)
                {
                    if (ch != ' ' && ch != '\t')
                    {
                        break;
                    }
                    ch = _NextChar();
                }
            }

            protected virtual void _RaiseError(string str)
            {
                throw new gstd.wexception(str);
            }

            protected bool _IsTextStartSign()
            {
                if (bTagScan_ != null)
                {
                    return false;
                }

                bool res = false;
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                char ch = pointer_;

                if (false && ch == '\\')
                {
                    List<char>.Enumerator pos = pointer_;
                    ch = _NextChar(); // ���̃^�O�܂Ői�߂�
                    bool bLess = ch == GlobalMembers.CHAR_TAG_START;
                    if (!bLess)
                    {
                        res = false;
                        SetCurrentPointer(new List<char>.Enumerator(pos));
                    }
                    else
                    {
                        res = !bLess;
                    }
                }
                else
                {
                    bool bLess = ch == GlobalMembers.CHAR_TAG_START;
                    res = !bLess;
                }

                return res;
            }

            protected bool _IsTextScan()
            {
                bool res = false;
                char ch = _NextChar();
                if (!HasNext())
                {
                    return false;
                }
                else if (ch == '/')
                {
                    ch = *(pointer_ + 1);
                    if (ch == '/' || ch == '*')
                    {
                        res = false;
                    }
                }
                else if (false && ch == '\\')
                {
                    ch = _NextChar(); // ���̃^�O�܂Ői�߂�
                    res = true;
                }
                else
                {
                    bool bGreater = ch == GlobalMembers.CHAR_TAG_END;
                    if (bGreater)
                    {
                        _RaiseError("�e�L�X�g���Ƀ^�O�I�����������݂��܂���");
                    }
                    bool bNotLess = ch != GlobalMembers.CHAR_TAG_START;
                    res = bNotLess;
                }
                return res;
            }

            public DxTextScanner(ref string str, int charCount)
            {
                List<char> buf = new List<char>();
                buf.Resize(charCount);
                if (buf.Count != 0)
                {
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                    memcpy(buf[0], str, charCount * sizeof(char));
                }

                buf.Add('\0');
                this.DxTextScanner(buf);
            }

            public DxTextScanner(string str)
            {
                List<char> buf = new List<char>();
                buf.Resize(str.Length + 1);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(buf[0], str, (str.Length + 1) * sizeof(char));
                this.DxTextScanner(buf);
            }

            public DxTextScanner(List<char> buf)
            {
                buffer_ = new List<char>(buf);
                pointer_ = buffer_.GetEnumerator();

                line_ = 1;
                bTagScan_ = false;
            }

            public virtual void Dispose()
            {

            }

            public DxTextToken GetToken()
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return token_;
                return new directx.DxTextToken(token_);
            }

            public DxTextToken Next()
            {
                if (!HasNext())
                {
                    string source;
                    source.resize(buffer_.Count);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                    memcpy(source[0], buffer_[0], source.Length * sizeof(char));
                    string log = StringUtility.Format("Next(Text):���łɏI�[�ł� -> %s", source);
                    _RaiseError(log);
                }

                _SkipComment(); // �R�����g��Ƃ΂��܂�

// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                char ch = pointer_;
                if (ch == '\0')
                {
                    token_ = new DxTextToken(DxTextToken.TK_EOF, "\0");
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return token_;
                    return new directx.DxTextToken(token_);
                }

                DxTextToken.Type type = DxTextToken.TK_UNKNOWN;
                List<char>.Enumerator posStart = pointer_; // �擪��ۑ�

                if (_IsTextStartSign())
                {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    ch = pointer_;

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: posStart = pointer_;
                    posStart.CopyFrom(pointer_);
                    while (_IsTextScan())
                    {

                    }

// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    ch = pointer_;
                    if (ch == GlobalMembers.CHAR_TAG_START)
                    {
                    }
                    else if (!HasNext())
                    {
                    }
            // 		else _RaiseError("Next:���łɕ�����I�[�ł�");

                    type = DxTextToken.TK_TEXT;
                    string text = new string(posStart, pointer_);
                    text = StringUtility.ReplaceAll(text, "\\", "");
                    token_ = new DxTextToken(type, text);
                }
                else
                {
                    switch (ch)
                    {
                        case '\0':
                            type = DxTextToken.TK_EOF;
                            break; // �I�[
                        case ',':
                            _NextChar();
                            type = DxTextToken.TK_COMMA;
                            break;
                        case '=':
                            _NextChar();
                            type = DxTextToken.TK_EQUAL;
                            break;
                        case '(':
                            _NextChar();
                            type = DxTextToken.TK_OPENP;
                            break;
                        case ')':
                            _NextChar();
                            type = DxTextToken.TK_CLOSEP;
                            break;
                        case '[':
                            _NextChar();
                            type = DxTextToken.TK_OPENB;
                            break;
                        case ']':
                            _NextChar();
                            type = DxTextToken.TK_CLOSEB;
                            break;
                        case '{':
                            _NextChar();
                            type = DxTextToken.TK_OPENC;
                            break;
                        case '}':
                            _NextChar();
                            type = DxTextToken.TK_CLOSEC;
                            break;
                        case '*':
                            _NextChar();
                            type = DxTextToken.TK_ASTERISK;
                            break;
                        case '/':
                            _NextChar();
                            type = DxTextToken.TK_SLASH;
                            break;
                        case ':':
                            _NextChar();
                            type = DxTextToken.TK_COLON;
                            break;
                        case ';':
                            _NextChar();
                            type = DxTextToken.TK_SEMICOLON;
                            break;
                        case '~':
                            _NextChar();
                            type = DxTextToken.TK_TILDE;
                            break;
                        case '!':
                            _NextChar();
                            type = DxTextToken.TK_EXCLAMATION;
                            break;
                        case '#':
                            _NextChar();
                            type = DxTextToken.TK_SHARP;
                            break;
                        case '<':
                            _NextChar();
                            type = DxTextToken.TK_LESS;
                            break;
                        case '>':
                            _NextChar();
                            type = DxTextToken.TK_GREATER;
                            break;

                        case '"':
                        {
                            ch = _NextChar(); // 1�i�߂�
                            char pre = ch;
                            while (true)
                            {
                                if (ch == '"' && pre != '\\')
                                {
                                    break;
                                }
                                pre = ch;
                                ch = _NextChar(); // ���̃_�u���N�I�[�e�[�V�����܂Ői�߂�
                            }

                            if (ch == '"')
                            {
                                _NextChar(); // �_�u���N�I�[�e�[�V������������1�i�߂�
                            }
                            else
                            {
                                _RaiseError("Next(Text):���łɕ�����I�[�ł�");
                            }
                            type = DxTextToken.TK_STRING;
                            break;
                        }

                        case '\r':
                    case '\n': // ���s
                            // ���s�����܂ł�����悤�Ȃ̂�1�̉��s�Ƃ��Ĉ���
                            while (ch == '\r' || ch == '\n')
                            {
                                ch = _NextChar();
                            }
                            type = DxTextToken.TK_NEWLINE;
                            break;

                        case '+':
                    case '-':
                    {
                            if (ch == '+')
                            {
                                ch = _NextChar();
                                type = DxTextToken.TK_PLUS;

                            }
                            else if (ch == '-')
                            {
                                ch = _NextChar();
                                type = DxTextToken.TK_MINUS;
                            }

                            if (!iswdigit(ch))
                            {
                                break; // ���������łȂ��Ȃ甲����
                            }
                    }


// C++ TO C# CONVERTER TODO TASK: C# does not allow fall-through from a non-empty 'case':
                        default:
                        {
                            if (iswdigit(ch))
                            {
                                // ����������
                                while (iswdigit(ch))
                                {
                                    ch = _NextChar(); // ���������̊ԃ|�C���^��i�߂�
                                }
                                type = DxTextToken.TK_INT;
                                if (ch == '.')
                                {
                                    // �������������𒲂ׂ�B�����_�������������
                                    ch = _NextChar();
                                    while (iswdigit(ch))
                                    {
                                        ch = _NextChar(); // ���������̊ԃ|�C���^��i�߂�
                                    }
                                    type = DxTextToken.TK_REAL;
                                }

                                if (ch == 'E' || ch == 'e')
                                {
                                    // 1E-5�݂����ȃP�[�X
                                    List<char>.Enumerator pos = pointer_;
                                    ch = _NextChar();
                                    while (iswdigit(ch) || ch == '-')
                                    {
                                        ch = _NextChar(); // ���������̊ԃ|�C���^��i�߂�
                                    }
                                    type = DxTextToken.TK_REAL;
                                }

                            }
                            else if (iswalpha(ch) || ch == '_')
                            {
                                // ���Ԃ񎯕ʎq
                                while (iswalpha(ch) || iswdigit(ch) || ch == '_')
                                {
                                    ch = _NextChar(); // ���Ԃ񎯕ʎq�Ȋԃ|�C���^��i�߂�
                                }
                                type = DxTextToken.TK_ID;
                            }
                            else
                            {
                                _NextChar();
                                type = DxTextToken.TK_UNKNOWN;
                            }
                            break;
                        }
                    }
                    if (type == DxTextScanner.TOKEN_TAG_START)
                    {
                        bTagScan_ = true;
                    }
                    else if (type == DxTextScanner.TOKEN_TAG_END)
                    {
                        bTagScan_ = false;
                    }

                    if (type == DxTextToken.TK_STRING)
                    {
                        // \�����
                        string str = StringUtility.ReplaceAll(new string(posStart, pointer_), "\\\"", "\"");
                        token_ = new DxTextToken(type, str);
                    }
                    else
                    {
                        token_ = new DxTextToken(type, new string(posStart, pointer_));
                    }

                }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return token_;
                return new directx.DxTextToken(token_);
            }

            public bool HasNext()
            {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                return pointer_ != buffer_.end() && pointer_ != '\0' && token_.GetType() != DxTextToken.TK_EOF;
            }

            public void CheckType(DxTextToken tok, int type)
            {
                if ((int)tok.type_ != type)
                {
                    string str = StringUtility.Format("CheckType error[%s]:",tok.element_.c_str());
                    _RaiseError(str);
                }
            }

            public void CheckIdentifer(DxTextToken tok, string id)
            {
                if (tok.type_ != DxTextToken.TK_ID || tok.GetIdentifier() != id)
                {
                    string str = StringUtility.Format("CheckID error[%s]:",tok.element_.c_str());
                    _RaiseError(str);
                }
            }

            public int GetCurrentLine()
            {
                return line_;
            }

            public int SearchCurrentLine()
            {
                int line = 1;
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
                char * pbuf = &(*buffer_.GetEnumerator());
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: char* ebuf = &(*pointer_);
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                char ebuf = &(pointer_);
                while (true)
                {
                    if (pbuf >= ebuf)
                    {
                        break;
                    }
                    else if (*pbuf == '\n')
                    {
                        line++;
                    }

                    pbuf++;
                }
                return line;
            }

            public List<char>.Enumerator GetCurrentPointer()
            {
                return new List<char>.Enumerator(pointer_);
            }

            public void SetCurrentPointer(List<char>.Enumerator pos)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: pointer_ = pos;
                pointer_.CopyFrom(pos);
            }

            public void SetPointerBegin()
            {
                pointer_ = buffer_.GetEnumerator();
            }
            public int GetCurrentPosition()
            {
                if (buffer_.Count == 0)
                {
                    return 0;
                }
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                string pos = (string)pointer_;
                return pos - buffer_[0];
            }

            public void SetTagScanEnable(bool bEnable)
            {
                bTagScan_ = bEnable;
            }
    }

    /**********************************************************
    //DxTextRenderer
    //�e�L�X�g�`��G���W��
    **********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxTextLine;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxTextInfo;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxTextRenderer;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxTextTag;
    public class DxTextTag : System.IDisposable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum2
            {
                TYPE_UNKNOWN,
                TYPE_RUBY,
                TYPE_FONT
            }
            protected int typeTag_;
            protected int indexTag_;
            public DxTextTag()
            {
                indexTag_ = 0;
                typeTag_ = (int)AnonymousEnum2.TYPE_UNKNOWN;
            }
            public virtual void Dispose()
            {
            }
            public int GetTagType()
            {
                return typeTag_;
            }
            public int GetTagIndex()
            {
                return indexTag_;
            }
            public void SetTagIndex(int index)
            {
                indexTag_ = index;
            }
    }
    public class DxTextTag_Ruby : DxTextTag
    {
            private int leftMargin_;
            private string text_ = "";
            private string ruby_ = "";
            private gstd.ref_count_ptr<DxText> dxText_ = new gstd.ref_count_ptr<DxText>();
            public DxTextTag_Ruby()
            {
                typeTag_ = TYPE_RUBY;
                leftMargin_ = 0;
            }
            public int GetLeftMargin()
            {
                return leftMargin_;
            }
            public void SetLeftMargin(int left)
            {
                leftMargin_ = left;
            }

            public string GetText()
            {
                return text_;
            }
            public void SetText(string text)
            {
                text_ = text;
            }
            public string GetRuby()
            {
                return ruby_;
            }
            public void SetRuby(string ruby)
            {
                ruby_ = ruby;
            }

            public gstd.ref_count_ptr<DxText> GetRenderText()
            {
                return new gstd.ref_count_ptr<DxText>(dxText_);
            }
            public void SetRenderText(gstd.ref_count_ptr<DxText> text)
            {
                dxText_.CopyFrom(text);
            }
    }
    public class DxTextTag_Font : DxTextTag
    {
            private DxFont font_ = new DxFont();
            public DxTextTag_Font()
            {
                typeTag_ = TYPE_FONT;
            }
            public void SetFont(DxFont font)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: font_ = font;
                font_.CopyFrom(font);
            }
            public DxFont GetFont()
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return font_;
                return new directx.DxFont(font_);
            }
    }
    public class DxTextLine : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxTextRenderer;
            protected int width_;
            protected int height_;
            protected int sidePitch_;
            protected List<int> code_ = new List<int>();
            protected List<gstd.ref_count_ptr<DxTextTag>> tag_ = new List<gstd.ref_count_ptr<DxTextTag>>();
            public DxTextLine()
            {
                width_ = 0;
                height_ = 0;
                sidePitch_ = 0;
            }
            public virtual void Dispose()
            {
            }
            public int GetWidth()
            {
                return width_;
            }
            public int GetHeight()
            {
                return height_;
            }
            public int GetSidePitch()
            {
                return sidePitch_;
            }
            public void SetSidePitch(int pitch)
            {
                sidePitch_ = pitch;
            }
            public List<int> GetTextCodes()
            {
                return new List<int>(code_);
            }
            public int GetTextCodeCount()
            {
                return code_.Count;
            }
            public int GetTagCount()
            {
                return tag_.Count;
            }
            public gstd.ref_count_ptr<DxTextTag> GetTag(int index)
            {
                return new gstd.ref_count_ptr<DxTextTag>(tag_[index]);
            }
    }
    public class DxTextInfo : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxTextRenderer;
            protected int totalWidth_;
            protected int totalHeight_;
            protected int lineValidStart_;
            protected int lineValidEnd_;
            protected bool bAutoIndent_;
            protected List<gstd.ref_count_ptr<DxTextLine>> textLine_ = new List<gstd.ref_count_ptr<DxTextLine>>();
            public DxTextInfo()
            {
                totalWidth_ = 0;
                totalHeight_ = 0;
                lineValidStart_ = 1;
                lineValidEnd_ = 0;
                bAutoIndent_ = false;
            }
            public virtual void Dispose()
            {
            }
            public int GetTotalWidth()
            {
                return totalWidth_;
            }
            public int GetTotalHeight()
            {
                return totalHeight_;
            }
            public int GetValidStartLine()
            {
                return lineValidStart_;
            }
            public int GetValidEndLine()
            {
                return lineValidEnd_;
            }
            public void SetValidStartLine(int line)
            {
                lineValidStart_ = line;
            }
            public void SetValidEndLine(int line)
            {
                lineValidEnd_ = line;
            }
            public bool IsAutoIndent()
            {
                return bAutoIndent_;
            }
            public void SetAutoIndent(bool bEnable)
            {
                bAutoIndent_ = bEnable;
            }

            public int GetLineCount()
            {
                return textLine_.Count;
            }
            public void AddTextLine(gstd.ref_count_ptr<DxTextLine> text)
            {
                textLine_.Add(text), lineValidEnd_++;
            }
            public gstd.ref_count_ptr<DxTextLine> GetTextLine(int pos)
            {
                return new gstd.ref_count_ptr<DxTextLine>(textLine_[pos]);
            }

    }

    public class DxTextRenderObject : System.IDisposable
    {
        private class ObjectData
        {
            public POINT bias = new POINT();
            public gstd.ref_count_ptr<Sprite2D> sprite = new gstd.ref_count_ptr<Sprite2D>();
        }
            protected POINT position_ = new POINT(); // �ړ�����W
            protected D3DXVECTOR3 angle_ = new D3DXVECTOR3(); // ��]�p�x
            protected D3DXVECTOR3 scale_ = new D3DXVECTOR3(); // �g�嗦
            protected D3DCOLOR color_ = new D3DCOLOR();
            protected LinkedList<ObjectData> listData_ = new LinkedList<ObjectData>();
            protected D3DXVECTOR2 center_ = new D3DXVECTOR2(); // ���W�ϊ��̒��S
            protected bool bAutoCenter_;
            protected bool bPermitCamera_;
            protected gstd.ref_count_ptr<Shader> shader_ = new gstd.ref_count_ptr<Shader>();


            /**********************************************************
            //DxTextRenderer
            //�e�L�X�g�`��G���W��
            **********************************************************/
            // Tag

            // DxTextTag_Ruby


            // DxTextRenderObject
            public DxTextRenderObject()
            {
                position_.x = 0;
                position_.y = 0;

                angle_ = D3DXVECTOR3(0.0f, 0.0f, 0.0f);
                scale_ = D3DXVECTOR3(1.0f, 1.0f, 1.0f);
                center_ = D3DXVECTOR2(0.0f, 0.0f);
                bAutoCenter_ = true;
                bPermitCamera_ = true;
            }

            public virtual void Dispose()
            {
            }

            public void Render()
            {
                POINT pos = new POINT(position_);

                bool bAngle = angle_.x != 0.0f || angle_.y != 0.0f || angle_.z != 0.0f;
                bool bScale = scale_.x != 1.0f || scale_.y != 1.0f || scale_.z != 1.0f;
                bool bMatrix = bAngle || bScale;
                D3DXMATRIX mat = new D3DXMATRIX();
                D3DXMatrixIdentity(mat);
                if (bScale)
                {
                    D3DXMATRIX matScale = new D3DXMATRIX();
                    D3DXMatrixScaling(matScale, scale_.x, scale_.y, scale_.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matScale;
                    mat.CopyFrom(mat * matScale);
                }
                if (bAngle)
                {
                    D3DXMATRIX matRot = new D3DXMATRIX();
                    D3DXMatrixRotationYawPitchRoll(matRot, D3DXToRadian(angle_.y), D3DXToRadian(angle_.x), D3DXToRadian(angle_.z));
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matRot;
                    mat.CopyFrom(mat * matRot);
                }

                D3DXVECTOR2 center = new D3DXVECTOR2(center_);
                if (bMatrix && bAutoCenter_)
                {
                    RECT rect = new RECT();
                    ZeroMemory(rect, sizeof(RECT));
                    LinkedList<ObjectData >.Enumerator itr = listData_.GetEnumerator();
                    while (itr.MoveNext())
                    {
                        ObjectData obj = itr.Current;
                        gstd.ref_count_ptr<Sprite2D> sprite = obj.sprite;
                        RECT_D rcDest = sprite.GetDestinationRect();
                        rect.left = System.Math.Min(rect.left, rcDest.left);
                        rect.top = System.Math.Min(rect.top, rcDest.top);
                        rect.right = System.Math.Max(rect.right, rcDest.right);
                        rect.bottom = System.Math.Max(rect.bottom, rcDest.bottom);
                    }
                    center.x = (rect.right + rect.left) / 2;
                    center.y = (rect.bottom + rect.top) / 2;
                }

                LinkedList<ObjectData >.Enumerator itr = listData_.GetEnumerator();
                while (itr.MoveNext())
                {
                    ObjectData obj = itr.Current;
                    POINT bias = new POINT(obj.bias);
                    gstd.ref_count_ptr<Sprite2D> sprite = obj.sprite;
                    sprite.SetColorRGB(color_);
                    sprite.SetAlpha(ColorAccess.GetColorA(color_));
                    RECT_D rcDestCopy = sprite.GetDestinationRect();

                    // ���W�ϊ�
                    if (bMatrix)
                    {
                        int countVertex = sprite.GetVertexCount();
                        for (int iVert = 0 ; iVert < countVertex ; iVert++)
                        {
                            VERTEX_TLX vert = sprite.GetVertex(iVert);
                            vert.position.x -= center.x;
                            vert.position.y -= center.y;
                            D3DXVec3TransformCoord((D3DXVECTOR3) vert.position, (D3DXVECTOR3) vert.position, mat);
                            vert.position.x += center.x + pos.x + bias.x;
                            vert.position.y += center.y + pos.y + bias.y;
                        }
                    }
                    else
                    {
                        RECT_D tRect = sprite.GetDestinationRect();
                        tRect.left += pos.x + bias.x;
                        tRect.right += pos.x + bias.x;
                        tRect.top += pos.y + bias.y;
                        tRect.bottom += pos.y + bias.y;
                        sprite.SetDestinationRect(tRect);
                    }

                    sprite.SetPermitCamera(bPermitCamera_);
                    sprite.SetShader(shader_);
                    sprite.Render();
                    sprite.SetDestinationRect(rcDestCopy);
                }
            }

            public void AddRenderObject(gstd.ref_count_ptr<Sprite2D> obj)
            {
                ObjectData data = new ObjectData();
                ZeroMemory(data.bias, sizeof(POINT));
                data.sprite.CopyFrom(obj);
                listData_.AddLast(data);
            }

            public void AddRenderObject(gstd.ref_count_ptr<DxTextRenderObject> obj, POINT bias)
            {
                LinkedList<ObjectData>.Enumerator itr = obj.listData_.begin();
                while (itr.MoveNext())
                {
                    itr.Current.bias = bias;
                    listData_.push_backitr.Current;
                }
            }

            public POINT GetPosition()
            {
                return new POINT(position_);
            }
            public void SetPosition(POINT pos)
            {
                position_.x = pos.x;
                position_.y = pos.y;
            }
            public void SetPosition(int x, int y)
            {
                position_.x = x;
                position_.y = y;
            }
            public void SetVertexColor(D3DCOLOR color)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color_ = color;
                color_.CopyFrom(color);
            }

            public void SetAngle(D3DXVECTOR3 angle)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: angle_ = angle;
                angle_.CopyFrom(angle);
            }
            public void SetScale(D3DXVECTOR3 scale)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: scale_ = scale;
                scale_.CopyFrom(scale);
            }
            public void SetTransCenter(D3DXVECTOR2 center)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: center_ = center;
                center_.CopyFrom(center);
            }
            public void SetAutoCenter(bool bAuto)
            {
                bAutoCenter_ = bAuto;
            }
            public void SetPermitCamera(bool bPermit)
            {
                bPermitCamera_ = bPermit;
            }

            public gstd.ref_count_ptr<Shader> GetShader()
            {
                return new gstd.ref_count_ptr<Shader>(shader_);
            }
            public void SetShader(gstd.ref_count_ptr<Shader> shader)
            {
                shader_.CopyFrom(shader);
            }
    }

    public class DxTextRenderer : System.IDisposable
    {
        private static DxTextRenderer thisBase_ = null;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum3
            {
                ALIGNMENT_LEFT,
                ALIGNMENT_RIGHT,
                ALIGNMENT_TOP,
                ALIGNMENT_BOTTOM,
                ALIGNMENT_CENTER
            }

            protected DxCharCache cache_ = new DxCharCache();
            protected gstd.Font winFont_ = new gstd.Font();
            protected D3DCOLOR colorVertex_ = new D3DCOLOR();
            protected gstd.CriticalSection lock_ = new gstd.CriticalSection();

            protected SIZE _GetTextSize(IntPtr hDC, ref string pText)
            {
                // �����R�[�h
                int charCount = 1;
                int code = 0;

                // �����T�C�Y�v�Z
                SIZE size = new SIZE();
                global::GetTextExtentPoint32(hDC, pText, charCount, size);
                return new SIZE(size);
            }

            protected ref_count_ptr<DxTextLine> _GetTextInfoSub(string text, DxText dxText, DxTextInfo textInfo, ref_count_ptr<DxTextLine> textLine, IntPtr hDC, ref int totalWidth, ref int totalHeight)
            {
                DxFont dxFont = dxText.GetFont();
                int sidePitch = dxText.GetSidePitch();
                int linePitch = dxText.GetLinePitch();
                int widthMax = dxText.GetMaxWidth();
                int heightMax = dxText.GetMaxHeight();
                int widthBorder = dxFont.GetBorderType() != DxFont.BORDER_NONE ? dxFont.GetBorderWidth() : 0;
                textLine.SetSidePitch(sidePitch);

                const string strFirstForbid = "�v�A�B";

// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to 'const_cast' in C#:
                char * pText = const_cast<char>(text.data());
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: char* eText=const_cast<char*>(text.data() + text.size());
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to 'const_cast' in C#:
                char eText = const_cast<char>(text.data() + text.Length);
                while (true)
                {
                    if (*pText == '\0' || pText >= eText)
                    {
                        break;
                    }

                    // �����R�[�h
                    int charCount = 1;
                    int code = *pText;

                    // �֑�����
                    SIZE sizeNext = new SIZE();
                    ZeroMemory(sizeNext, sizeof(SIZE));
                    string pNextChar = pText + charCount;
                    if (pNextChar < eText)
                    {
                        // ���̕���
                        string strNext = "";
                        strNext.resize(1);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                        memcpy(strNext[0], pNextChar, strNext.Length * sizeof(char));

                        bool bFirstForbid = strFirstForbid.IndexOf(strNext) != -1;
                        if (bFirstForbid)
                        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: sizeNext = _GetTextSize(hDC, pNextChar);
                            sizeNext.CopyFrom(_GetTextSize(hDC, ref pNextChar));
                        }
                    }

                    // �����T�C�Y�v�Z
                    SIZE size = _GetTextSize(hDC, ref pText);
                    int lw = size.cx + widthBorder + sidePitch;
                    int lh = size.cy;
                    if (textLine.width_ + lw + sizeNext.cx >= widthMax)
                    {
                        // ���s
                        totalWidth = System.Math.Max(totalWidth, textLine.width_);
                        totalHeight += textLine.height_ + linePitch;
                        textInfo.AddTextLine(new ref_count_ptr<DxTextLine>(textLine));
                        textLine = new DxTextLine();
                        textLine.SetSidePitch(sidePitch);
                        continue;
                    }
                    if (totalHeight + size.cy > heightMax)
                    {
                        textLine = null;
                        break;
                    }
                    textLine.width_ += lw;
                    textLine.height_ = System.Math.Max(textLine.height_, lh);
                    textLine.code_.push_back(code);

                    pText += charCount;
                }
                return new ref_count_ptr<DxTextLine>(textLine);
            }

            protected void _CreateRenderObject(gstd.ref_count_ptr<DxTextRenderObject> objRender, POINT pos, ref DxFont dxFont, gstd.ref_count_ptr<DxTextLine> textLine)
            {
                SetFont(dxFont.GetLogFont());
                DxCharCacheKey keyFont = new DxCharCacheKey();
                keyFont.font_ = dxFont;
                int textHeight = textLine.GetHeight();

                int xRender = pos.x;
                int yRender = pos.y;

                int countTag = textLine.GetTagCount();
                int indexTag = 0;
                int countCode = textLine.code_.size();
                for (int iCode = 0 ; iCode < countCode ; iCode++)
                {
                    for (;indexTag < countTag;)
                    {
                        gstd.ref_count_ptr<DxTextTag> tag = textLine.GetTag(indexTag);
                        int tagNo = tag.GetTagIndex();
                        if (tagNo != iCode)
                        {
                            break;
                        }
                        int type = tag.GetTagType();
                        if (type == DxTextTag.TYPE_FONT)
                        {
                            DxTextTag_Font font = (DxTextTag_Font)tag.GetPointer();
                            dxFont = font.GetFont();
                            keyFont.font_ = dxFont;
                            winFont_.CreateFontIndirect(dxFont.GetLogFont());
                            indexTag++;
                        }
                        else if (type == DxTextTag.TYPE_RUBY)
                        {
                            DxTextTag_Ruby ruby = (DxTextTag_Ruby)tag.GetPointer();
                            ref_count_ptr<DxText> textRuby = ruby.GetRenderText();

                            RECT margin = new RECT();
                            ZeroMemory(margin, sizeof(RECT));
                            margin.left = xRender + ruby.GetLeftMargin();
                            margin.top = pos.y - textRuby.GetFontSize();
                            textRuby.SetMargin(margin);

                            POINT bias = new POINT();
                            ZeroMemory(bias, sizeof(POINT));

                            objRender.AddRenderObject(textRuby.CreateRenderObject(), bias);

                            SetFont(dxFont.GetLogFont());

                            indexTag++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    // �����R�[�h
                    int code = textLine.code_[iCode];

                    // �L���b�V���ɑ��݂��邩�m�F
                    keyFont.code_ = code;
                    keyFont.font_ = dxFont;
                    ref_count_ptr<DxChar> dxChar = cache_.GetChar(keyFont);
                    if (dxChar == null)
                    {
                        // �L���b�V���ɂȂ��ꍇ�A�쐬���Ēǉ�
                        dxChar = new DxChar();
                        dxChar.Create(code, winFont_, dxFont);
                        cache_.AddChar(keyFont, new ref_count_ptr<DxChar>(dxChar));
                    }

                    // �`��
                    ref_count_ptr<Sprite2D> spriteText = new Sprite2D();
                    int yGap = 0;
                    yRender = pos.y + yGap;
                    ref_count_ptr<Texture> texture = dxChar.GetTexture();
                    spriteText.SetTexture(texture);

            // 		int objWidth = texture->GetWidth();//dxChar->GetWidth();
            // 		int objHeight = texture->GetHeight();//dxChar->GetHeight();
                    int objWidth = dxChar.GetWidth();
                    int objHeight = dxChar.GetHeight();
                    RECT_D rcDest = new RECT_D() { left = (double)xRender, top = (double)yRender, right = (double)(objWidth + xRender), bottom = (double)(objHeight + yRender) };
                    RECT_D rcSrc = new RECT_D() { left = 0.0, top = 0.0, right = (double)objWidth, bottom = (double)objHeight };
                    spriteText.SetVertex(rcSrc, rcDest, colorVertex_);
                    objRender.AddRenderObject(spriteText);

                    // ���̕���
                    xRender += dxChar.GetWidth() - dxFont.GetBorderWidth() + textLine.GetSidePitch();
                }
            }

            protected string _ReplaceRenderText(ref string text)
            {
                text = StringUtility.ReplaceAll(text, "\r", "");
                text = StringUtility.ReplaceAll(text, "\n", "");
                text = StringUtility.ReplaceAll(text, "\t", "");
                text = StringUtility.ReplaceAll(text, "&nbsp;", " ");
                text = StringUtility.ReplaceAll(text, "&quot;", "\"");
                text = StringUtility.ReplaceAll(text, "&osb;", "[");
                text = StringUtility.ReplaceAll(text, "&csb;", "]");
                return text;
            }


            // DxTextRenderer
            public DxTextRenderer()
            {
                colorVertex_ = D3DCOLOR_ARGB(255, 255, 255, 255);
            }

            public virtual void Dispose()
            {

            }

            public static DxTextRenderer GetBase()
            {
                return thisBase_;
            }
            public bool Initialize()
            {
                if (thisBase_ != null)
                {
                    return false;
                }

                winFont_.CreateFont(Font.GOTHIC, 20, true);

                thisBase_ = this;
                return true;
            }

            public gstd.CriticalSection GetLock()
            {
                return new gstd.CriticalSection(lock_);
            }

            public void ClearCache()
            {
                cache_.Clear();
            }
            public void SetFont(LOGFONT logFont)
            {
                winFont_.CreateFontIndirect(logFont);
            }
            public void SetVertexColor(D3DCOLOR color)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: colorVertex_ = color;
                colorVertex_.CopyFrom(color);
            }
            public gstd.ref_count_ptr<DxTextInfo> GetTextInfo(DxText dxText)
            {
                SetFont(dxText.dxFont_.GetLogFont());
                DxTextInfo res = new DxTextInfo();
                string text = dxText.GetText();
                DxFont dxFont = dxText.GetFont();
                int linePitch = dxText.GetLinePitch();
                int widthMax = dxText.GetMaxWidth();
                int heightMax = dxText.GetMaxHeight();
                RECT margin = dxText.GetMargin();

                ref_count_ptr<Font> fontTemp = new ref_count_ptr<Font>();

                IntPtr hDC = global::GetDC(null);
                IntPtr oldFont = (IntPtr)SelectObject(hDC, winFont_.GetHandle());

                bool bEnd = false;
                int totalWidth = 0;
                int totalHeight = 0;
                int widthBorder = dxFont.GetBorderType() != DxFont.BORDER_NONE ? dxFont.GetBorderWidth() : 0;
                ref_count_ptr<DxTextLine> textLine = new DxTextLine();
                textLine.width_ = margin.left;

                if (dxText.IsSyntacticAnalysis())
                {
                    DxTextScanner scan = new DxTextScanner(text);
                    while (!bEnd)
                    {
                        if (!scan.HasNext())
                        {
                            // �c��������
                            if (textLine.code_.size() > 0)
                            {
                                totalWidth = System.Math.Max(totalWidth, textLine.width_);
                                totalHeight += textLine.height_;
                                res.AddTextLine(new ref_count_ptr<DxTextLine>(textLine));
                            }
                            break;
                        }

                        DxTextToken tok = scan.Next();
                        int typeToken = (int)tok.GetType();
                        if (typeToken == DxTextToken.TK_TEXT)
                        {
                            string text = tok.GetElement();
                            text = _ReplaceRenderText(ref text);
                            if (text.Length == 0 || text == "")
                            {
                                continue;
                            }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: textLine = _GetTextInfoSub(text, dxText, res, textLine, hDC, totalWidth, totalHeight);
                            textLine.CopyFrom(_GetTextInfoSub(text, dxText, res, new ref_count_ptr<DxTextLine>(textLine), hDC, ref totalWidth, ref totalHeight));
                            if (textLine == null)
                            {
                                bEnd = true;
                            }
                        }
                        else if (typeToken == DxTextScanner.TOKEN_TAG_START)
                        {
                            int indexTag = textLine.code_.size();
                            tok = scan.Next();
                            string element = tok.GetElement();
                            if (element == DxTextScanner.TAG_NEW_LINE)
                            {
                                // ���s
                                if (textLine.height_ == 0)
                                {
                                    // �󕶎��̏ꍇ��󔒕����ō�����v�Z����
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: textLine = _GetTextInfoSub(" ", dxText, res, textLine, hDC, totalWidth, totalHeight);
                                    textLine.CopyFrom(_GetTextInfoSub(" ", dxText, res, new ref_count_ptr<DxTextLine>(textLine), hDC, ref totalWidth, ref totalHeight));
                                }

                                if (textLine != null)
                                {
                                    totalWidth = System.Math.Max(totalWidth, textLine.width_);
                                    totalHeight += textLine.height_ + linePitch;
                                    res.AddTextLine(new ref_count_ptr<DxTextLine>(textLine));
                                }

                                textLine = new DxTextLine();
                            }
                            else if (element == DxTextScanner.TAG_RUBY)
                            {
                                ref_count_ptr<DxTextTag_Ruby> tag = new DxTextTag_Ruby();
                                tag.SetTagIndex(indexTag);

                                while (true)
                                {
                                    tok = scan.Next();
                                    if (tok.GetType() == DxTextScanner.TOKEN_TAG_END)
                                    {
                                        break;
                                    }
                                    string str = tok.GetElement();
                                    if (str == "rb")
                                    {
                                        scan.CheckType(scan.Next(), DxTextToken.TK_EQUAL);
                                        string text = scan.Next().GetString();
                                        tag.SetText(text);
                                    }
                                    else if (str == "rt")
                                    {
                                        scan.CheckType(scan.Next(), DxTextToken.TK_EQUAL);
                                        string text = scan.Next().GetString();
                                        tag.SetRuby(text);
                                    }
                                }

                                int linePos = res.GetLineCount();
                                int codeCount = textLine.GetTextCodes().size();
                                string text = tag.GetText();
                                ref_count_ptr<DxTextLine> textLineRuby = new ref_count_ptr<DxTextLine>(textLine);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: textLine = _GetTextInfoSub(text, dxText, res, textLine, hDC, totalWidth, totalHeight);
                                textLine.CopyFrom(_GetTextInfoSub(text, dxText, res, new ref_count_ptr<DxTextLine>(textLine), hDC, ref totalWidth, ref totalHeight));

                                SIZE sizeText = new SIZE();
                                global::GetTextExtentPoint32(hDC, text[0], text.Length, sizeText);
                                int rubyWidth = dxText.GetFontSize() / 2;
                                string sRuby = tag.GetRuby();
                                int rubyCount = StringUtility.CountAsciiSizeCharacter(sRuby);
                                if (rubyCount > 0)
                                {
                                    int rubyPitch = System.Math.Max(sizeText.cx / rubyCount - rubyWidth, 0);
                                    int rubyMarginLeft = rubyPitch / 2;
                                    tag.SetLeftMargin(rubyMarginLeft);

                                    gstd.ref_count_ptr<DxText> dxTextRuby = new DxText();
                                    dxTextRuby.SetText(tag.GetRuby());
                                    dxTextRuby.SetFont(dxFont);
                                    dxTextRuby.SetPosition(dxText.GetPosition());
                                    dxTextRuby.SetMaxWidth(dxText.GetMaxWidth());
                                    dxTextRuby.SetSidePitch(rubyPitch);
                                    dxTextRuby.SetLinePitch(linePitch + dxText.GetFontSize() - rubyWidth);
                                    dxTextRuby.SetFontBold(true);
                                    dxTextRuby.SetFontItalic(false);
                                    dxTextRuby.SetFontUnderLine(false);
                                    dxTextRuby.SetFontSize(rubyWidth);
                                    dxTextRuby.SetFontBorderWidth(dxFont.GetBorderWidth() / 2);
                                    tag.SetRenderText(dxTextRuby);

                                    int currentCodeCount = textLineRuby.GetTextCodes().size();
                                    if (codeCount == currentCodeCount)
                                    {
                                        // �^�O�����S�Ɏ��̍s�ɉ��ꍇ
                                        tag.SetTagIndex(0);
                                        textLine.tag_.push_back(tag);
                                    }
                                    else
                                    {
                                        textLineRuby.tag_.push_back(tag);
                                    }


                                }

                            }
                            else if (element == DxTextScanner.TAG_FONT)
                            {
                                DxTextTag_Font tag = new DxTextTag_Font();
                                DxFont font = dxText.GetFont();
                                LOGFONT logFont = font.GetLogFont();
                                tag.SetTagIndex(indexTag);

                                bool bClear = false;
                                while (true)
                                {
                                    tok = scan.Next();
                                    if (tok.GetType() == DxTextScanner.TOKEN_TAG_END)
                                    {
                                        break;
                                    }
                                    string str = tok.GetElement();
                                    if (str == "clear")
                                    {
                                        bClear = true;
                                    }
                                    else if (str == "size")
                                    {
                                        scan.CheckType(scan.Next(), DxTextToken.TK_EQUAL);
                                        int size = scan.Next().GetInteger();
                                        logFont.lfHeight = size;
                                    }
                                }

                                if (bClear)
                                {
                                    widthBorder = dxFont.GetBorderType() != DxFont.BORDER_NONE ? dxFont.GetBorderWidth() : 0;
                                    fontTemp = null;
                                    oldFont = (IntPtr)SelectObject(hDC, winFont_.GetHandle());
                                }
                                else
                                {
                                    widthBorder = font.GetBorderType() != DxFont.BORDER_NONE ? font.GetBorderWidth() : 0;
                                    fontTemp = new Font();
                                    fontTemp.CreateFontIndirect(logFont);
                                    font.SetLogFont(logFont);
                                    oldFont = (IntPtr)SelectObject(hDC, fontTemp.GetHandle());
                                }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: tag->SetFont(font);
                                tag.SetFont(new directx.DxFont(font));
                                textLine.tag_.push_back(tag);
                            }
                            else
                            {
                                string text = DxTextScanner.TAG_START;
                                text += tok.GetElement();
                                while (true)
                                {
                                    if (tok.GetType() == DxTextScanner.TOKEN_TAG_END)
                                    {
                                        break;
                                    }
                                    tok = scan.Next();
                                    text += tok.GetElement();
                                }
                                text = _ReplaceRenderText(ref text);
                                if (text.Length == 0 || text == "")
                                {
                                    continue;
                                }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: textLine = _GetTextInfoSub(text, dxText, res, textLine, hDC, totalWidth, totalHeight);
                                textLine.CopyFrom(_GetTextInfoSub(text, dxText, res, new ref_count_ptr<DxTextLine>(textLine), hDC, ref totalWidth, ref totalHeight));
                                if (textLine == null)
                                {
                                    bEnd = true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    string text = dxText.GetText();
                    text = _ReplaceRenderText(ref text);
                    if (text.Length > 0)
                    {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: textLine = _GetTextInfoSub(text, dxText, res, textLine, hDC, totalWidth, totalHeight);
                        textLine.CopyFrom(_GetTextInfoSub(text, dxText, res, new ref_count_ptr<DxTextLine>(textLine), hDC, ref totalWidth, ref totalHeight));
                        res.AddTextLine(new ref_count_ptr<DxTextLine>(textLine));
                    }
                }

                res.totalWidth_ = totalWidth + widthBorder;
                res.totalHeight_ = totalHeight + widthBorder;
                global::SelectObject(hDC, oldFont);
                global::ReleaseDC(null, hDC);
                return res;
            }

            public gstd.ref_count_ptr<DxTextRenderObject> CreateRenderObject(DxText dxText, ref_count_ptr<DxTextInfo> textInfo)
            {
                {
                    Lock @lock = new Lock(lock_);
                    gstd.ref_count_ptr<DxTextRenderObject> objRender = new DxTextRenderObject();
                    objRender.SetPosition(dxText.GetPosition());
                    objRender.SetVertexColor(dxText.GetVertexColor());
                    objRender.SetPermitCamera(dxText.IsPermitCamera());
                    objRender.SetShader(dxText.GetShader());

                    DxFont dxFont = dxText.GetFont();
                    int linePitch = dxText.GetLinePitch();
                    int widthMax = dxText.GetMaxWidth();
                    int heightMax = dxText.GetMaxHeight();
                    RECT margin = dxText.GetMargin();
                    int alignmentHorizontal = dxText.GetHorizontalAlignment();
                    int alignmentVertical = dxText.GetVerticalAlignment();
                    POINT pos = new POINT();
                    ZeroMemory(pos, sizeof(POINT));
                    bool bAutoIndent = textInfo.IsAutoIndent();

                    switch (alignmentVertical)
                    {
                        case AnonymousEnum3.ALIGNMENT_TOP:
                            break;
                        case AnonymousEnum3.ALIGNMENT_CENTER:
                        {
                            int cy = pos.y + heightMax / 2;
                            pos.y = cy - textInfo.totalHeight_ / 2;
                            break;
                        }
                        case AnonymousEnum3.ALIGNMENT_BOTTOM:
                        {
                            int by = pos.y + heightMax;
                            pos.y = by - textInfo.totalHeight_;
                            break;
                        }
                    }
                    pos.y += margin.top;

                    int heightTotal = 0;
                    int countLine = textInfo.textLine_.size();
                    int lineStart = textInfo.GetValidStartLine() - 1;
                    int lineEnd = textInfo.GetValidEndLine() - 1;
                    for (int iLine = lineStart; iLine <= lineEnd ; iLine++)
                    {
                        gstd.ref_count_ptr<DxTextLine> textLine = textInfo.GetTextLine(iLine);
                        pos.x = 0; // dxText->GetPosition().x;
                        if (iLine == 0)
                        {
                            pos.x += margin.left;
                        }
                        switch (alignmentHorizontal)
                        {
                            case AnonymousEnum3.ALIGNMENT_LEFT:
                                if (iLine >= 1 && bAutoIndent)
                                {
                                    pos.x = dxText.GetFontSize();
                                }
                                break;
                            case AnonymousEnum3.ALIGNMENT_CENTER:
                            {
                                int cx = pos.x + widthMax / 2;
                                pos.x = cx - textLine.width_ / 2;
                                break;
                            }
                            case AnonymousEnum3.ALIGNMENT_RIGHT:
                            {
                                int rx = pos.x + widthMax;
                                pos.x = rx - textLine.width_;
                                break;
                            }
                        }

                        heightTotal += textLine.height_ + linePitch;
                        if (heightTotal > heightMax)
                        {
                            break;
                        }

                        _CreateRenderObject(new gstd.ref_count_ptr<DxTextRenderObject>(objRender), new POINT(pos), ref dxFont, new gstd.ref_count_ptr<DxTextLine>(textLine));

                        pos.y += textLine.height_ + linePitch;
                    }
                    return new gstd.ref_count_ptr<DxTextRenderObject>(objRender);
                }

            }

            public void Render(DxText dxText)
            {
                {
                    Lock @lock = new Lock(lock_);
                    ref_count_ptr<DxTextInfo> textInfo = GetTextInfo(dxText);
                    Render(dxText, new ref_count_ptr<DxTextInfo>(textInfo));
                }
            }

            public void Render(DxText dxText, gstd.ref_count_ptr<DxTextInfo> textInfo)
            {
                {
                    Lock @lock = new Lock(lock_);
                    ref_count_ptr<DxTextRenderObject> objRender = CreateRenderObject(dxText, new gstd.ref_count_ptr<DxTextInfo>(textInfo));
                    objRender.Render();
                }
            }

            public int GetCacheCount()
            {
                return cache_.GetCacheCount();
            }

            public bool AddFontFromFile(string path)
            {
                ref_count_ptr<FileReader> reader = FileManager.GetBase().GetFileReader(path);
                if (reader == null)
                {
                    throw new gstd.wexception(StringUtility.Format("�t�H���g�t�@�C����������܂���(%s)", path).c_str());
                }
                if (!reader.Open())
                {
                    throw new gstd.wexception(StringUtility.Format("�t�H���g�t�@�C����J���܂���(%s)", path).c_str());
                }

                int size = reader.GetFileSize();
                ByteBuffer buf = new ByteBuffer();
                buf.SetSize(size);
                reader.Read(buf.GetPointer(), size);

                uint count = 0;
                IntPtr handle = global::AddFontMemResourceEx(buf.GetPointer(), size, null, count);

                Logger.WriteTop("�t�H���g�ǂݍ��݁F" + path);
                return handle != null;
            }
    }

    /**********************************************************
    //DxText
    //�e�L�X�g�`��
    **********************************************************/
    public class DxText : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxTextRenderer;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum4
            {
                ALIGNMENT_LEFT = DxTextRenderer.ALIGNMENT_LEFT,
                ALIGNMENT_RIGHT = DxTextRenderer.ALIGNMENT_RIGHT,
                ALIGNMENT_TOP = DxTextRenderer.ALIGNMENT_TOP,
                ALIGNMENT_BOTTOM = DxTextRenderer.ALIGNMENT_BOTTOM,
                ALIGNMENT_CENTER = DxTextRenderer.ALIGNMENT_CENTER
            }
            protected DxFont dxFont_ = new DxFont();
            protected POINT pos_ = new POINT();
            protected int widthMax_;
            protected int heightMax_;
            protected int sidePitch_;
            protected int linePitch_;
            protected RECT margin_ = new RECT();
            protected int alignmentHorizontal_;
            protected int alignmentVertical_;
            protected D3DCOLOR colorVertex_ = new D3DCOLOR();
            protected bool bPermitCamera_;
            protected bool bSyntacticAnalysis_;

            protected gstd.ref_count_ptr<Shader> shader_ = new gstd.ref_count_ptr<Shader>();
            protected string text_ = "";

            /**********************************************************
            //DxText
            //�e�L�X�g�`��
            **********************************************************/
            public DxText()
            {
                dxFont_.SetTopColor(D3DCOLOR_ARGB(255,255,255,255));
                dxFont_.SetBottomColor(D3DCOLOR_ARGB(255,255,255,255));
                dxFont_.SetBorderType(DxFont.BORDER_NONE);
                dxFont_.SetBorderWidth(0);
                dxFont_.SetBorderColor(D3DCOLOR_ARGB(255,255,255,255));

                LOGFONT logFont = new LOGFONT();
                ZeroMemory(logFont, sizeof(LOGFONT));
                logFont.lfEscapement = 0;
                logFont.lfWidth = 0;
                logFont.lfCharSet = ANSI_CHARSET;
                SetFont(new LOGFONT(logFont));
                SetFontSize(20);
                SetFontType(Font.GOTHIC);
                SetFontBold(false);
                SetFontItalic(false);
                SetFontUnderLine(false);

                pos_.x = 0;
                pos_.y = 0;
                widthMax_ = int.MaxValue;
                heightMax_ = int.MaxValue;
                sidePitch_ = 0;
                linePitch_ = 4;
                alignmentHorizontal_ = (int)AnonymousEnum4.ALIGNMENT_LEFT;
                alignmentVertical_ = (int)AnonymousEnum4.ALIGNMENT_TOP;
                ZeroMemory(margin_, sizeof(RECT));

                colorVertex_ = D3DCOLOR_ARGB(255, 255, 255, 255);
                bPermitCamera_ = true;
                bSyntacticAnalysis_ = true;
            }

            public virtual void Dispose()
            {
            }

            public void Copy(DxText src)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dxFont_ = src.dxFont_;
                dxFont_.CopyFrom(src.dxFont_);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: pos_ = src.pos_;
                pos_.CopyFrom(src.pos_);
                widthMax_ = src.widthMax_;
                heightMax_ = src.heightMax_;
                sidePitch_ = src.sidePitch_;
                linePitch_ = src.linePitch_;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: margin_ = src.margin_;
                margin_.CopyFrom(src.margin_);
                alignmentHorizontal_ = src.alignmentHorizontal_;
                alignmentVertical_ = src.alignmentVertical_;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: colorVertex_ = src.colorVertex_;
                colorVertex_.CopyFrom(src.colorVertex_);
                text_ = src.text_;
            }

            public virtual void Render()
            {
                DxTextRenderer renderer = DxTextRenderer.GetBase();
                {
                    Lock @lock = new Lock(renderer.GetLock());
                    renderer.SetVertexColor(new D3DCOLOR(colorVertex_));
                    renderer.Render(this);
                }
            }

            public void Render(gstd.ref_count_ptr<DxTextInfo> textInfo)
            {
                DxTextRenderer renderer = DxTextRenderer.GetBase();
                {
                    Lock @lock = new Lock(renderer.GetLock());
                    renderer.SetVertexColor(new D3DCOLOR(colorVertex_));
                    renderer.Render(this, new gstd.ref_count_ptr<DxTextInfo>(textInfo));
                }
            }

            public gstd.ref_count_ptr<DxTextInfo> GetTextInfo()
            {
                DxTextRenderer renderer = DxTextRenderer.GetBase();
                {
                    Lock @lock = new Lock(renderer.GetLock());
                    renderer.SetVertexColor(new D3DCOLOR(colorVertex_));
                    return new gstd.ref_count_ptr<DxTextInfo>(renderer.GetTextInfo(this));
                }
            }

            public gstd.ref_count_ptr<DxTextRenderObject> CreateRenderObject()
            {
                DxTextRenderer renderer = DxTextRenderer.GetBase();
                {
                    Lock @lock = new Lock(renderer.GetLock());
                    renderer.SetVertexColor(new D3DCOLOR(colorVertex_));
                    gstd.ref_count_ptr<DxTextInfo> textInfo = renderer.GetTextInfo(this);
                    gstd.ref_count_ptr<DxTextRenderObject> res = renderer.CreateRenderObject(this, new gstd.ref_count_ptr<DxTextInfo>(textInfo));
                    return new gstd.ref_count_ptr<DxTextRenderObject>(res);
                }
            }

            public gstd.ref_count_ptr<DxTextRenderObject> CreateRenderObject(gstd.ref_count_ptr<DxTextInfo> textInfo)
            {
                DxTextRenderer renderer = DxTextRenderer.GetBase();
                {
                    Lock @lock = new Lock(renderer.GetLock());
                    renderer.SetVertexColor(new D3DCOLOR(colorVertex_));
                    gstd.ref_count_ptr<DxTextRenderObject> res = renderer.CreateRenderObject(this, new gstd.ref_count_ptr<DxTextInfo>(textInfo));
                    return new gstd.ref_count_ptr<DxTextRenderObject>(res);
                }
            }

            public DxFont GetFont()
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return dxFont_;
                return new directx.DxFont(dxFont_);
            }
            public void SetFont(DxFont font)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dxFont_ = font;
                dxFont_.CopyFrom(font);
            }
            public void SetFont(LOGFONT logFont)
            {
                dxFont_.SetLogFont(logFont);
            }

            public void SetFontType(string type)
            {
                LOGFONT info = dxFont_.GetLogFont();
                lstrcpy(info.lfFaceName, type);
                info.lfCharSet = DEFAULT_CHARSET;

                for (int i = 0;i < (int)wcslen(type);i++)
                {
                    if (!(IsCharAlphaNumeric(type[i]) || type[i] == ' ' || type[i] == '-'))
                    {
                        info.lfCharSet = SHIFTJIS_CHARSET;
                        break;
                    }
                }
                SetFont(new LOGFONT(info));
            }

            public int GetFontSize()
            {
                return dxFont_.GetLogFont().lfHeight;
            }
            public void SetFontSize(int size)
            {
                LOGFONT info = dxFont_.GetLogFont();
                info.lfHeight = size;
                SetFont(new LOGFONT(info));
            }
            public void SetFontBold(bool bBold)
            {
                LOGFONT info = dxFont_.GetLogFont();
                info.lfWeight = (bBold == false) * FW_NORMAL + (bBold == true) * FW_BOLD;
                SetFont(new LOGFONT(info));
            }
            public void SetFontItalic(bool bItalic)
            {
                LOGFONT info = dxFont_.GetLogFont();
                info.lfItalic = bItalic;
                SetFont(new LOGFONT(info));
            }
            public void SetFontUnderLine(bool bLine)
            {
                LOGFONT info = dxFont_.GetLogFont();
                info.lfUnderline = bLine;
                SetFont(new LOGFONT(info));
            }

            public void SetFontColorTop(D3DCOLOR color)
            {
                dxFont_.SetTopColor(new D3DCOLOR(color));
            }
            public void SetFontColorBottom(D3DCOLOR color)
            {
                dxFont_.SetBottomColor(new D3DCOLOR(color));
            }
            public void SetFontBorderWidth(int width)
            {
                dxFont_.SetBorderWidth(width);
            }
            public void SetFontBorderType(int type)
            {
                dxFont_.SetBorderType(type);
            }
            public void SetFontBorderColor(D3DCOLOR color)
            {
                dxFont_.SetBorderColor(new D3DCOLOR(color));
            }

            public POINT GetPosition()
            {
                return new POINT(pos_);
            }
            public void SetPosition(int x, int y)
            {
                pos_.x = x;
                pos_.y = y;
            }
            public void SetPosition(POINT pos)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: pos_ = pos;
                pos_.CopyFrom(pos);
            }
            public int GetMaxWidth()
            {
                return widthMax_;
            }
            public void SetMaxWidth(int width)
            {
                widthMax_ = width;
            }
            public int GetMaxHeight()
            {
                return heightMax_;
            }
            public void SetMaxHeight(int height)
            {
                heightMax_ = height;
            }
            public int GetSidePitch()
            {
                return sidePitch_;
            }
            public void SetSidePitch(int pitch)
            {
                sidePitch_ = pitch;
            }
            public int GetLinePitch()
            {
                return linePitch_;
            }
            public void SetLinePitch(int pitch)
            {
                linePitch_ = pitch;
            }
            public RECT GetMargin()
            {
                return new RECT(margin_);
            }
            public void SetMargin(RECT margin)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: margin_ = margin;
                margin_.CopyFrom(margin);
            }
            public int GetHorizontalAlignment()
            {
                return alignmentHorizontal_;
            }
            public void SetHorizontalAlignment(int value)
            {
                alignmentHorizontal_ = value;
            }
            public int GetVerticalAlignment()
            {
                return alignmentVertical_;
            }
            public void SetVerticalAlignment(int value)
            {
                alignmentVertical_ = value;
            }

            public D3DCOLOR GetVertexColor()
            {
                return new D3DCOLOR(colorVertex_);
            }
            public void SetVertexColor(D3DCOLOR color)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: colorVertex_ = color;
                colorVertex_.CopyFrom(color);
            }
            public bool IsPermitCamera()
            {
                return bPermitCamera_;
            }
            public void SetPermitCamera(bool bPermit)
            {
                bPermitCamera_ = bPermit;
            }
            public bool IsSyntacticAnalysis()
            {
                return bSyntacticAnalysis_;
            }
            public void SetSyntacticAnalysis(bool bEnable)
            {
                bSyntacticAnalysis_ = bEnable;
            }

            public string GetText()
            {
                return text_;
            }
            public void SetText(string text)
            {
                text_ = text;
            }

            public gstd.ref_count_ptr<Shader> GetShader()
            {
                return new gstd.ref_count_ptr<Shader>(shader_);
            }
            public void SetShader(gstd.ref_count_ptr<Shader> shader)
            {
                shader_.CopyFrom(shader);
            }
    }

    /**********************************************************
    //DxTextStepper
    **********************************************************/
    public class DxTextStepper : System.IDisposable
    {
            protected int posNext_;
            protected string text_ = "";
            protected string source_ = "";
            protected int framePerSec_;
            protected int countNextPerFrame_;
            protected double countFrame_;
            protected void _Next()
            {
                if (!HasNext())
                {
                    return;
                }

                if (source_[posNext_] == DxTextScanner.TAG_START[0])
                {
                    text_ += source_[posNext_];
                    posNext_++;
                    while (true)
                    {
                        bool bBreak = (source_[posNext_] == DxTextScanner.TAG_END[0]);
                        text_ += source_[posNext_];
                        posNext_++;
                        if (bBreak)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    text_ += source_[posNext_];
                    posNext_++;
                }
            }


            /**********************************************************
            //DxTextStepper
            **********************************************************/
            public DxTextStepper()
            {
                posNext_ = 0;
                framePerSec_ = 60;
                countNextPerFrame_ = 60;
                countFrame_ = 0;
                Clear();
            }

            public virtual void Dispose()
            {
            }

            public void Clear()
            {
                posNext_ = 0;
                text_ = "";
                source_ = "";
            }

            public string GetText()
            {
                return text_;
            }
            public void Next()
            {
                double ratioFrame = (double)countNextPerFrame_ / (double)framePerSec_;
                int lastCountFrame = (int)countFrame_;
                countFrame_ += ratioFrame;
                while (true)
                {
                    if (countFrame_ < 1.0)
                    {
                        break;
                    }
                    countFrame_ -= 1.0;
                    _Next();
                }
            }

            public void NextSkip()
            {
                while (HasNext())
                {
                    _Next();
                }
            }

            public bool HasNext()
            {
                return posNext_ < source_.Length;
            }

            public void SetSource(string text)
            {
                posNext_ = 0;
                source_ = text;
            // 	text_ = "";
            }
    }

}