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
//    class RenderObjectBase;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class RenderManager;
    /**********************************************************
    //FVF���_�t�H�[�}�b�g
    //http://msdn.microsoft.com/ja-jp/library/cc324487.aspx
    **********************************************************/
    public class VERTEX_TL
    {
        // ���W3D�ϊ��ς݁A���C�e�B���O�ς�
        public VERTEX_TL()
        {
        }
        public VERTEX_TL(D3DXVECTOR4 pos, D3DCOLOR dcol)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.position = pos;
            this.position.CopyFrom(pos);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.diffuse_color = dcol;
            this.diffuse_color.CopyFrom(dcol);
        }
        public D3DXVECTOR4 position = new D3DXVECTOR4();
        public D3DCOLOR diffuse_color = new D3DCOLOR();
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            fvf = (D3DFVF_XYZRHW | D3DFVF_DIFFUSE)
        }
    }

    public class VERTEX_TLX
    {
        // ���W3D�ϊ��ς݁A���C�e�B���O�ς݁A�e�N�X�`���L��
        public VERTEX_TLX()
        {
        }
        public VERTEX_TLX(D3DXVECTOR4 pos, D3DCOLOR diffcol, D3DXVECTOR2 tex)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.position = pos;
            this.position.CopyFrom(pos);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.diffuse_color = diffcol;
            this.diffuse_color.CopyFrom(diffcol);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.texcoord = tex;
            this.texcoord.CopyFrom(tex);
        }
        public D3DXVECTOR4 position = new D3DXVECTOR4();
        public D3DCOLOR diffuse_color = new D3DCOLOR();
        public D3DXVECTOR2 texcoord = new D3DXVECTOR2();
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum2
        {
            fvf = (D3DFVF_XYZRHW | D3DFVF_DIFFUSE | D3DFVF_TEX1)
        }
    }

    public class VERTEX_L
    {
        // ���C�e�B���O�ς�
        public VERTEX_L()
        {
        }
        public VERTEX_L(D3DXVECTOR3 pos, D3DCOLOR col)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.position = pos;
            this.position.CopyFrom(pos);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.diffuse_color = col;
            this.diffuse_color.CopyFrom(col);
        }
        public D3DXVECTOR3 position = new D3DXVECTOR3();
        public D3DCOLOR diffuse_color = new D3DCOLOR();
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum3
        {
            fvf = (D3DFVF_XYZ | D3DFVF_DIFFUSE)
        }
    }

    public class VERTEX_LX
    {
        // ���C�e�B���O�ς݁A�e�N�X�`���L��
        public VERTEX_LX()
        {
        }
        public VERTEX_LX(D3DXVECTOR3 pos, D3DCOLOR diffcol, D3DXVECTOR2 tex)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.position = pos;
            this.position.CopyFrom(pos);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.diffuse_color = diffcol;
            this.diffuse_color.CopyFrom(diffcol);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.texcoord = tex;
            this.texcoord.CopyFrom(tex);
        }
        public D3DXVECTOR3 position = new D3DXVECTOR3();
        public D3DCOLOR diffuse_color = new D3DCOLOR();
        public D3DXVECTOR2 texcoord = new D3DXVECTOR2();
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum4
        {
            fvf = (D3DFVF_XYZ | D3DFVF_DIFFUSE | D3DFVF_TEX1)
        }
    }

    public class VERTEX_N
    {
        // �����C�e�B���O
        public VERTEX_N()
        {
        }
        public VERTEX_N(D3DXVECTOR3 pos, D3DXVECTOR3 n)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.position = pos;
            this.position.CopyFrom(pos);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.normal = n;
            this.normal.CopyFrom(n);
        }
        public D3DXVECTOR3 position = new D3DXVECTOR3();
        public D3DXVECTOR3 normal = new D3DXVECTOR3();
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum5
        {
            fvf = (D3DFVF_XYZ | D3DFVF_NORMAL)
        }
    }

    public class VERTEX_NX
    {
        // �����C�e�B���O�A�e�N�X�`���L��
        public VERTEX_NX()
        {
        }
        public VERTEX_NX(D3DXVECTOR3 pos, D3DXVECTOR3 n, D3DXVECTOR2 tc)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.position = pos;
            this.position.CopyFrom(pos);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.normal = n;
            this.normal.CopyFrom(n);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.texcoord = tc;
            this.texcoord.CopyFrom(tc);
        }
        public D3DXVECTOR3 position = new D3DXVECTOR3();
        public D3DXVECTOR3 normal = new D3DXVECTOR3();
        public D3DXVECTOR2 texcoord = new D3DXVECTOR2();
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum6
        {
            fvf = (D3DFVF_XYZ | D3DFVF_NORMAL | D3DFVF_TEX1)
        }
    }

    public class VERTEX_NXG
    {
        public VERTEX_NXG()
        {
        }
        public VERTEX_NXG(D3DXVECTOR3 pos, D3DXVECTOR3 n, D3DXVECTOR2 tc)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.position = pos;
            this.position.CopyFrom(pos);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.normal = n;
            this.normal.CopyFrom(n);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.texcoord = tc;
            this.texcoord.CopyFrom(tc);
        }
        public D3DXVECTOR3 position = new D3DXVECTOR3();
        public float[] blend = new float[3];
        public D3DXVECTOR3 normal = new D3DXVECTOR3();
        public D3DXVECTOR2 texcoord = new D3DXVECTOR2();
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum7
        {
            fvf = (D3DFVF_XYZB3 | D3DFVF_NORMAL | D3DFVF_TEX1)
        }
    }

    public class VERTEX_B1NX
    {
        // �����C�e�B���O�A�e�N�X�`���L��A���_�u�����h1
        public VERTEX_B1NX()
        {
        }
        public VERTEX_B1NX(D3DXVECTOR3 pos, uint bi, D3DXVECTOR3 n, D3DXVECTOR2 tc)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.position = pos;
            this.position.CopyFrom(pos);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.normal = n;
            this.normal.CopyFrom(n);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.texcoord = tc;
            this.texcoord.CopyFrom(tc);
            blendIndex = bi;
        }
        public D3DXVECTOR3 position = new D3DXVECTOR3();
        public uint blendIndex;
        public D3DXVECTOR3 normal = new D3DXVECTOR3();
        public D3DXVECTOR2 texcoord = new D3DXVECTOR2();
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum8
        {
            fvf = (D3DFVF_XYZB1 | D3DFVF_LASTBETA_UBYTE4 | D3DFVF_NORMAL | D3DFVF_TEX1)
        }
    }

    public class VERTEX_B2NX
    {
        // �����C�e�B���O�A�e�N�X�`���L��A���_�u�����h2
        public VERTEX_B2NX()
        {
        }
        public VERTEX_B2NX(D3DXVECTOR3 pos, float rate, byte index1, byte index2, D3DXVECTOR3 n, D3DXVECTOR2 tc)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.position = pos;
            this.position.CopyFrom(pos);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.normal = n;
            this.normal.CopyFrom(n);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.texcoord = tc;
            this.texcoord.CopyFrom(tc);
            blendRate = rate;
            gstd.BitAccess.SetByte(blendIndex, 0, index1);
            gstd.BitAccess.SetByte(blendIndex, 8, index2);
        }
        public D3DXVECTOR3 position = new D3DXVECTOR3();
        public float blendRate;
        public uint blendIndex;
        public D3DXVECTOR3 normal = new D3DXVECTOR3();
        public D3DXVECTOR2 texcoord = new D3DXVECTOR2();
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum9
        {
            fvf = (D3DFVF_XYZB2 | D3DFVF_LASTBETA_UBYTE4 | D3DFVF_NORMAL | D3DFVF_TEX1)
        }
    }

    public class VERTEX_B4NX
    {
        // �����C�e�B���O�A�e�N�X�`���L��A���_�u�����h4
        public VERTEX_B4NX()
        {
        }
        public VERTEX_B4NX(D3DXVECTOR3 pos, float[] rate, byte[] index, D3DXVECTOR3 n, D3DXVECTOR2 tc)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.position = pos;
            this.position.CopyFrom(pos);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.normal = n;
            this.normal.CopyFrom(n);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this.texcoord = tc;
            this.texcoord.CopyFrom(tc);
            for (int iRate = 0 ; iRate < 3 ; iRate++)
            {
                blendRate[iRate] = rate[iRate];
            }
            for (int iIndex = 0 ; iIndex < 4 ; iIndex++)
            {
                gstd.BitAccess.SetByte(blendIndex, 8 * iIndex, index[iIndex]);
            }
        }
        public D3DXVECTOR3 position = new D3DXVECTOR3();
        public float[] blendRate = new float[3];
        public uint blendIndex;
        public D3DXVECTOR3 normal = new D3DXVECTOR3();
        public D3DXVECTOR2 texcoord = new D3DXVECTOR2();
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum10
        {
            fvf = (D3DFVF_XYZB4 | D3DFVF_LASTBETA_UBYTE4 | D3DFVF_NORMAL | D3DFVF_TEX1)
        }
    }

// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class RenderStateFunction;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class RenderBlock;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class RenderObject;

    /**********************************************************
    //RenderBlock
    **********************************************************/
    public abstract class RenderBlock : System.IDisposable
    {
            protected float posSortKey_;
            protected gstd.ref_count_ptr<RenderStateFunction> func_ = new gstd.ref_count_ptr<RenderStateFunction>();
            protected gstd.ref_count_ptr<RenderObject> obj_ = new gstd.ref_count_ptr<RenderObject>();

            protected D3DXVECTOR3 position_ = new D3DXVECTOR3(); // �ړ�����W
            protected D3DXVECTOR3 angle_ = new D3DXVECTOR3(); // ��]�p�x
            protected D3DXVECTOR3 scale_ = new D3DXVECTOR3(); // �g�嗦


            /**********************************************************
            //RenderBlock
            **********************************************************/
            public RenderBlock()
            {
                posSortKey_ = 0F;
            }

            public virtual void Dispose()
            {
                func_ = null;
                obj_ = null;
            }

            public void SetRenderFunction(gstd.ref_count_ptr<RenderStateFunction> func)
            {
                func_.CopyFrom(func);
            }
            public virtual void Render()
            {
                RenderObject obj = (RenderObject)obj_.GetPointer();
                obj.SetPosition(position_);
                obj.SetAngle(angle_);
                obj.SetScale(scale_);
                if (func_ != null)
                {
                    func_.CallRenderStateFunction();
                }
                obj.Render();
            }

            public abstract void CalculateZValue();
            public float GetZValue()
            {
                return posSortKey_;
            }
            public void SetZValue(float pos)
            {
                posSortKey_ = pos;
            }
            public abstract bool IsTranslucent(); // Z�\�[�g�ΏۂɎg�p

            public void SetRenderObject(gstd.ref_count_ptr<RenderObject> obj)
            {
                obj_.CopyFrom(obj);
            }
            public gstd.ref_count_ptr<RenderObject> GetRenderObject()
            {
                return new gstd.ref_count_ptr<RenderObject>(obj_);
            }
            public void SetPosition(D3DXVECTOR3 pos)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: position_ = pos;
                position_.CopyFrom(pos);
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
    }

    public class RenderBlocks : System.IDisposable
    {
            protected LinkedList<gstd.ref_count_ptr<RenderBlock>> listBlock_ = new LinkedList<gstd.ref_count_ptr<RenderBlock>>();
            public RenderBlocks()
            {
            }
            public virtual void Dispose()
            {
            }
            public void Add(gstd.ref_count_ptr<RenderBlock> block)
            {
                listBlock_.AddLast(block);
            }
            public LinkedList<gstd.ref_count_ptr<RenderBlock>> GetList()
            {
                return new LinkedList<gstd.ref_count_ptr<RenderBlock>>(listBlock_);
            }

    }

    /**********************************************************
    //RenderManager
    //�����_�����O�Ǘ�
    //3D�s�����I�u�W�F�N�g
    //3D�������I�u�W�F�N�gZ�\�[�g��
    //2D�I�u�W�F�N�g
    //���ɕ`�悷��
    **********************************************************/
    public class RenderManager : System.IDisposable
    {
        private class ComparatorRenderBlockTranslucent
        {
                public static bool functorMethod(gstd.ref_count_ptr<RenderBlock> l, gstd.ref_count_ptr<RenderBlock> r)
                {
                    return l.GetZValue() > r.GetZValue();
                }
        }
            protected LinkedList<gstd.ref_count_ptr<RenderBlock>> listBlockOpaque_ = new LinkedList<gstd.ref_count_ptr<RenderBlock>>();
            protected LinkedList<gstd.ref_count_ptr<RenderBlock>> listBlockTranslucent_ = new LinkedList<gstd.ref_count_ptr<RenderBlock>>();

            /**********************************************************
            //RenderManager
            **********************************************************/
            public RenderManager()
            {
            }

            public virtual void Dispose()
            {
            }

            public virtual void Render()
            {
                DirectGraphics graph = DirectGraphics.GetBase();

                // �s����
                graph.SetZBufferEnable(true);
                graph.SetZWriteEnalbe(true);
                LinkedList<gstd.ref_count_ptr<RenderBlock>>.Enumerator itrOpaque;
                for (itrOpaque = listBlockOpaque_.GetEnumerator(); itrOpaque.MoveNext();)
                {
                    itrOpaque.Current.Render();
                }

                // ������
                graph.SetZBufferEnable(true);
                graph.SetZWriteEnalbe(false);
                LinkedList<gstd.ref_count_ptr<RenderBlock>>.Enumerator itrTrans;
                for (itrTrans = listBlockTranslucent_.GetEnumerator(); itrTrans.MoveNext();)
                {
                    itrTrans.Current.CalculateZValue();
                }
                SortUtility.CombSort(listBlockTranslucent_.GetEnumerator(), listBlockTranslucent_.end(), new ComparatorRenderBlockTranslucent());
                for (itrTrans = listBlockTranslucent_.GetEnumerator(); itrTrans.MoveNext();)
                {
                    itrTrans.Current.Render();
                }

                listBlockOpaque_.Clear();
                listBlockTranslucent_.Clear();
            }

            public void AddBlock(gstd.ref_count_ptr<RenderBlock> block)
            {
                if (block == null)
                {
                    return;
                }
                if (block.IsTranslucent())
                {
                    listBlockTranslucent_.AddLast(block);
                }
                else
                {
                    listBlockOpaque_.AddLast(block);
                }
            }

            public void AddBlock(gstd.ref_count_ptr<RenderBlocks> blocks)
            {
                LinkedList<gstd.ref_count_ptr<RenderBlock>> listBlock = blocks.GetList();
                int size = listBlock.Count;
                LinkedList<gstd.ref_count_ptr<RenderBlock>>.Enumerator itr;
                for (itr = listBlock.GetEnumerator(); itr.MoveNext();)
                {
                    AddBlockitr.Current;
                }
            }
    }


    /**********************************************************
    //RenderStateFunction
    **********************************************************/
    public class RenderStateFunction : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend RenderObjectBase;
            private enum FUNC_TYPE
            {
                FUNC_LIGHTING,
                FUNC_CULLING,
                FUNC_ZBUFFER_ENABLE,
                FUNC_ZBUFFER_WRITE_ENABLE,
                FUNC_BLEND,
                FUNC_TEXTURE_FILTER
            }

            private SortedDictionary<FUNC_TYPE, gstd.ref_count_ptr<gstd.ByteBuffer>> mapFuncRenderState_ = new SortedDictionary<FUNC_TYPE, gstd.ref_count_ptr<gstd.ByteBuffer>>();

            /**********************************************************
            //RenderStateFunction
            **********************************************************/
            public RenderStateFunction()
            {

            }

            public virtual void Dispose()
            {

            }

            public void CallRenderStateFunction()
            {
                SortedDictionary<RenderStateFunction.FUNC_TYPE, gstd.ref_count_ptr<gstd.ByteBuffer>>.Enumerator itr;
                for (itr = mapFuncRenderState_.GetEnumerator(); itr.MoveNext();)
                {
                    RenderStateFunction.FUNC_TYPE type = itr.Current.Key;
                    gstd.ByteBuffer args = itr.Current.Value.GetPointer();
                    args.Seek(0);
                    if (type == RenderStateFunction.FUNC_LIGHTING)
                    {
                        bool bEnable = args.ReadBoolean();
                        DirectGraphics.GetBase().SetLightingEnable(bEnable);
                    }
                    // TODO
                }
                mapFuncRenderState_.Clear();
            }

            // �����_�����O�X�e�[�g�ݒ�(RenderManager�p)
            public void SetLightingEnable(bool bEnable)
            {
                int sizeArgs = sizeof(bool);
                gstd.ByteBuffer args = new gstd.ByteBuffer();
                args.SetSize(sizeArgs);
                args.WriteBoolean(bEnable);
                mapFuncRenderState_[RenderStateFunction.FUNC_LIGHTING] = args;
            }

            public void SetCullingMode(uint mode)
            {
                int sizeArgs = sizeof(uint);
                gstd.ByteBuffer args = new gstd.ByteBuffer();
                args.SetSize(sizeArgs);
                args.WriteInteger((int)mode);
                mapFuncRenderState_[RenderStateFunction.FUNC_CULLING] = args;
            }

            public void SetZBufferEnable(bool bEnable)
            {
                int sizeArgs = sizeof(bool);
                gstd.ByteBuffer args = new gstd.ByteBuffer();
                args.SetSize(sizeArgs);
                args.WriteBoolean(bEnable);
                mapFuncRenderState_[RenderStateFunction.FUNC_ZBUFFER_ENABLE] = args;
            }

            public void SetZWriteEnalbe(bool bEnable)
            {
                int sizeArgs = sizeof(bool);
                gstd.ByteBuffer args = new gstd.ByteBuffer();
                args.SetSize(sizeArgs);
                args.WriteBoolean(bEnable);
                mapFuncRenderState_[RenderStateFunction.FUNC_ZBUFFER_WRITE_ENABLE] = args;
            }

            public void SetBlendMode(uint mode, int stage = 0)
            {
                int sizeArgs = sizeof(uint) + sizeof(int);
                gstd.ByteBuffer args = new gstd.ByteBuffer();
                args.SetSize(sizeArgs);
                args.WriteInteger((int)mode);
                args.WriteInteger(stage);
                mapFuncRenderState_[RenderStateFunction.FUNC_BLEND] = args;
            }

            public void SetTextureFilter(uint mode, int stage = 0)
            {
                int sizeArgs = sizeof(uint) + sizeof(int);
                gstd.ByteBuffer args = new gstd.ByteBuffer();
                args.SetSize(sizeArgs);
                args.WriteInteger((int)mode);
                args.WriteInteger(stage);
                mapFuncRenderState_[RenderStateFunction.FUNC_TEXTURE_FILTER] = args;
            }
    }

    public class Matrices : System.IDisposable
    {
        private List<D3DXMATRIX> matrix_ = new List<D3DXMATRIX>();
            public Matrices()
            {
            }
            public virtual void Dispose()
            {
            }
            public void SetSize(int size)
            {
                matrix_.Resize(size);
                for (int iMat = 0;iMat < size;iMat++)
                {
                    D3DXMatrixIdentity(matrix_[iMat]);
                }
            }
            public int GetSize()
            {
                return matrix_.Count;
            }
            public void SetMatrix(int index, D3DXMATRIX mat)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: matrix_[index] = mat;
                matrix_[index].CopyFrom(mat);
            }
            public D3DXMATRIX GetMatrix(int index)
            {
                return new D3DXMATRIX(matrix_[index]);
            }
    }

    /**********************************************************
    //RenderObject
    //�����_�����O�I�u�W�F�N�g
    //�`��̍ŏ��P��
    //RenderManager�ɓo�^���ĕ`�悵�Ă�炤
    //(���ڕ`���\)
    **********************************************************/
    public abstract class RenderObject : System.IDisposable
    {
            protected D3DPRIMITIVETYPE typePrimitive_ = new D3DPRIMITIVETYPE();
            protected int strideVertexStreamZero_; // 1���_�̃T�C�Y
            protected gstd.ByteBuffer vertex_ = new gstd.ByteBuffer(); // ���_
            protected List<short> vertexIndices_ = new List<short>();
            protected List<gstd.ref_count_ptr<Texture>> texture_ = new List<gstd.ref_count_ptr<Texture>>(); // �e�N�X�`��
            protected D3DXVECTOR3 posWeightCenter_ = new D3DXVECTOR3(); // �d�S

            // �V�F�[�_�p
            protected IDirect3DVertexDeclaration9 pVertexDecl_;
            protected IDirect3DVertexBuffer9 pVertexBuffer_;
            protected IDirect3DIndexBuffer9 pIndexBuffer_;

            protected D3DXVECTOR3 position_ = new D3DXVECTOR3(); // �ړ�����W
            protected D3DXVECTOR3 angle_ = new D3DXVECTOR3(); // ��]�p�x
            protected D3DXVECTOR3 scale_ = new D3DXVECTOR3(); // �g�嗦
            protected D3DXMATRIX matRelative_ = new D3DXMATRIX(); // �֌W�s��
            protected bool bCoordinate2D_; // 2D���W�w��
            protected gstd.ref_count_ptr<Shader> shader_ = new gstd.ref_count_ptr<Shader>();

            protected virtual void _ReleaseVertexBuffer()
            {
                if (pIndexBuffer_ != null)
                {
                    pIndexBuffer_.Release();
                }
                if (pVertexBuffer_ != null)
                {
                    pVertexBuffer_.Release();
                }
                if (pVertexDecl_ != null)
                {
                    pVertexDecl_.Release();
                }
                pVertexDecl_ = null;
                pVertexBuffer_ = null;
                pIndexBuffer_ = null;
            }

            protected virtual void _RestoreVertexBuffer()
            {
                InitializeVertexBuffer();
            }

            protected virtual void _CreateVertexDeclaration()
            {
            }

            protected int _GetPrimitiveCount()
            {
                int res = 0;
                int count = GetVertexCount();
                if (vertexIndices_.Count != 0)
                {
                    count = vertexIndices_.Count;
                }
                switch (typePrimitive_)
                {
                    case D3DPT_POINTLIST: // �|�C���g���X�g
                        res = count;
                        break;
                    case D3DPT_LINELIST: // ���C�����X�g
                        res = count / 2;
                        break;
                    case D3DPT_LINESTRIP: // ���C���X�g���b�v
                        res = count - 1;
                        break;
                    case D3DPT_TRIANGLELIST: // �g���C�A���O�����X�g
                        res = count / 3;
                        break;
                    case D3DPT_TRIANGLESTRIP: // �g���C�A���O���X�g���b�v
                        res = count - 2;
                        break;
                    case D3DPT_TRIANGLEFAN: // �g���C�A���O���t�@��
                        res = count - 2;
                        break;
                }

                return res;
            }

            protected void _SetTextureStageCount(int count)
            {
                texture_.Resize(count);
                for (int i = 0;i < count;i++)
                {
                    texture_[i] = null;
                }
            }
            protected virtual D3DXMATRIX _CreateWorldTransformMaxtrix()
            {
                D3DXMATRIX mat = new D3DXMATRIX();
                D3DXMatrixIdentity(mat);
                bool bPos = position_.x != 0.0f || position_.y != 0.0f || position_.z != 0.0f;
                bool bAngle = angle_.x != 0.0f || angle_.y != 0.0f || angle_.z != 0.0f;
                bool bScale = scale_.x != 1.0f || scale_.y != 1.0f || scale_.z != 1.0f;
                if (bPos || bAngle || bScale)
                {
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

                    if (bPos)
                    {
                        D3DXMATRIX matTrans = new D3DXMATRIX();
                        D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matTrans;
                        mat.CopyFrom(mat * matTrans);
                    }
                }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matRelative_;
                mat.CopyFrom(mat * matRelative_);

                if (bCoordinate2D_)
                {
                    DirectGraphics graphics = DirectGraphics.GetBase();
                    IDirect3DDevice9 device = graphics.GetDevice();

                    D3DVIEWPORT9 viewPort = new D3DVIEWPORT9();
                    device.GetViewport(viewPort);
                    float width = viewPort.Width;
                    float height = viewPort.Height;

                    DxCamera2D camera2D = graphics.GetCamera2D().GetPointer();
                    if (camera2D.IsEnable())
                    {
                        D3DXMATRIX matCamera = camera2D.GetMatrix();
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matCamera;
                        mat.CopyFrom(mat * matCamera);
                    }

                    D3DXMATRIX matViewPort = new D3DXMATRIX();
                    D3DXMatrixIdentity(matViewPort);
                    matViewPort._11 = width / 2.0f;
                    matViewPort._41 = width / 2.0f;
                    matViewPort._22 = -height / 2.0f;
                    matViewPort._42 = height / 2.0f;

                    D3DXMATRIX matView = new D3DXMATRIX();
                    device.GetTransform(D3DTS_VIEW, matView);
                    D3DXMATRIX matProj = new D3DXMATRIX();
                    device.GetTransform(D3DTS_PROJECTION, matProj);

                    D3DXMATRIX matTrans = new D3DXMATRIX();
                    D3DXMatrixIdentity(matTrans);
                    D3DXMatrixTranslation(matTrans, -width / 2.0f, -height / 2.0f, 0);

                    D3DXMATRIX matScale = new D3DXMATRIX();
                    D3DXMatrixIdentity(matScale);
                    D3DXMatrixScaling(matScale, 200.0f, 200.0f, -0.002f);

                    D3DXMATRIX matInvView = new D3DXMATRIX();
                    D3DXMATRIX matInvProj = new D3DXMATRIX();
                    D3DXMATRIX matInvViewPort = new D3DXMATRIX();
                    D3DXMatrixInverse(matInvView, null, matView);
                    D3DXMatrixInverse(matInvProj, null, matProj);
                    D3DXMatrixInverse(matInvViewPort, null, matViewPort);

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matTrans * matScale * matInvViewPort * matInvProj * matInvView;
                    mat.CopyFrom(mat * matTrans * matScale * matInvViewPort * matInvProj * matInvView);
                    mat._43 *= -1;
                }

                return new D3DXMATRIX(mat);
            }

            protected void _SetCoordinate2dDeviceMatrix()
            {
                if (!bCoordinate2D_)
                {
                    return;
                }

                DirectGraphics graphics = DirectGraphics.GetBase();
                IDirect3DDevice9 device = graphics.GetDevice();
                float width = graphics.GetScreenWidth();
                float height = graphics.GetScreenHeight();

                D3DVIEWPORT9 viewPort = new D3DVIEWPORT9();
                device.GetViewport(viewPort);

                D3DXMATRIX viewMat = new D3DXMATRIX();
                D3DXMATRIX persMat = new D3DXMATRIX();
                D3DVECTOR viewFrom = D3DXVECTOR3(0,0,-100);
                D3DXMatrixLookAtLH(viewMat, (D3DXVECTOR3) viewFrom, D3DXVECTOR3(0,0,0), D3DXVECTOR3(0,1,0));
                D3DXMatrixPerspectiveFovLH(persMat, D3DXToRadian(180), (float)viewPort.Width / (float)viewPort.Height, 1, 2000);

                device.SetTransform(D3DTS_VIEW, viewMat);
                device.SetTransform(D3DTS_PROJECTION, persMat);
            }


            /**********************************************************
            //RenderObject
            **********************************************************/
            public RenderObject()
            {
                typePrimitive_ = D3DPT_TRIANGLELIST;
                position_ = D3DXVECTOR3(0.0f, 0.0f, 0.0f);
                angle_ = D3DXVECTOR3(0.0f, 0.0f, 0.0f);
                scale_ = D3DXVECTOR3(1.0f, 1.0f, 1.0f);
                posWeightCenter_ = D3DXVECTOR3(0.0f, 0.0f, 0.0f);
                D3DXMatrixIdentity(matRelative_);

                pVertexDecl_ = null;
                pVertexBuffer_ = null;
                pIndexBuffer_ = null;
                bCoordinate2D_ = false;
            }

            public virtual void Dispose()
            {
                _ReleaseVertexBuffer();
            }

            public abstract void Render();
            public virtual void InitializeVertexBuffer()
            {
            }
            public virtual void CalculateWeightCenter()
            {
            }
            public D3DXVECTOR3 GetWeightCenter()
            {
                return new D3DXVECTOR3(posWeightCenter_);
            }
            public gstd.ref_count_ptr<Texture> GetTexture(int pos = 0)
            {
                return new gstd.ref_count_ptr<Texture>(texture_[pos]);
            }

            public void SetRalativeMatrix(D3DXMATRIX mat)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: matRelative_ = mat;
                matRelative_.CopyFrom(mat);
            }

            // ���_�ݒ�
            public void SetPrimitiveType(D3DPRIMITIVETYPE type)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: typePrimitive_ = type;
                typePrimitive_.CopyFrom(type);
            }
            public virtual void SetVertexCount(int count)
            {
                vertex_.SetSize(count * strideVertexStreamZero_);
                ZeroMemory(vertex_.GetPointer(), vertex_.GetSize());
            }
            public virtual int GetVertexCount()
            {
                return vertex_.GetSize() / strideVertexStreamZero_;
            }
            public void SetVertexIndicies(List<short> indecies)
            {
                vertexIndices_ = new List<short>(indecies);
            }
            public gstd.ByteBuffer GetVertexPointer()
            {
                return new gstd.ByteBuffer(vertex_);
            }

            // �`��p�ݒ�
            public void SetPosition(D3DXVECTOR3 pos)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: position_ = pos;
                position_.CopyFrom(pos);
            }
            public void SetPosition(float x, float y, float z)
            {
                position_.x = x;
                position_.y = y;
                position_.z = z;
            }
            public void SetX(float x)
            {
                position_.x = x;
            }
            public void SetY(float y)
            {
                position_.y = y;
            }
            public void SetZ(float z)
            {
                position_.z = z;
            }
            public void SetAngle(D3DXVECTOR3 angle)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: angle_ = angle;
                angle_.CopyFrom(angle);
            }
            public void SetAngleXYZ(float angx = 0.0f, float angy = 0.0f, float angz = 0.0f)
            {
                angle_.x = angx;
                angle_.y = angy;
                angle_.z = angz;
            }
            public void SetScale(D3DXVECTOR3 scale)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: scale_ = scale;
                scale_.CopyFrom(scale);
            }
            public void SetScaleXYZ(float sx = 1.0f, float sy = 1.0f, float sz = 1.0f)
            {
                scale_.x = sx;
                scale_.y = sy;
                scale_.z = sz;
            }
            public void SetTexture(Texture texture, int stage = 0)
            {
                if (texture == null)
                {
                    texture_[stage] = null;
                }
                else
                {
                    if (stage >= texture_.Count)
                    {
                        return;
                    }
                    texture_[stage] = new Texture(texture);
                }
            }

            public void SetTexture(ref_count_ptr<Texture> texture, int stage = 0)
            {
                if (texture == null)
                {
                    texture_[stage] = null;
                }
                else
                {
                    if (stage >= texture_.Count)
                    {
                        return;
                    }
                    texture_[stage] = texture;
                }
            }

            public bool IsCoordinate2D()
            {
                return bCoordinate2D_;
            }
            public void SetCoordinate2D(bool b)
            {
                bCoordinate2D_ = b;
            }

            public gstd.ref_count_ptr<Shader> GetShader()
            {
                return new gstd.ref_count_ptr<Shader>(shader_);
            }
            public void SetShader(gstd.ref_count_ptr<Shader> shader)
            {
                shader_.CopyFrom(shader);
            }
            public void BeginShader()
            {
                if (shader_ == null)
                {
                    return;
                }

            // 	if(pVertexDecl_ == NULL)
            // 		_CreateVertexDeclaration();

                shader_.Begin();

                DirectGraphics graphics = DirectGraphics.GetBase();
                IDirect3DDevice9 device = graphics.GetDevice();
            // 	device->SetVertexDeclaration(pVertexDecl_);

            }

            public void EndShader()
            {
                if (shader_ == null)
                {
                    return;
                }
                shader_.End();

                DirectGraphics graphics = DirectGraphics.GetBase();
                IDirect3DDevice9 device = graphics.GetDevice();
                device.SetVertexDeclaration(null);
            }
    }

    /**********************************************************
    //RenderObjectTLX
    //���W3D�ϊ��ς݁A���C�e�B���O�ς݁A�e�N�X�`���L��
    //2D���R�ό`�X�v���C�g�p
    **********************************************************/
    public class RenderObjectTLX : RenderObject
    {
            protected bool bPermitCamera_;
            protected gstd.ByteBuffer vertCopy_ = new gstd.ByteBuffer();

            protected override void _CreateVertexDeclaration()
            {
                if (pVertexDecl_ != null)
                {
                    return;
                }

                // D3DFVF_XYZRHW|D3DFVF_DIFFUSE|D3DFVF_TEX1
                IDirect3DDevice9 device = DirectGraphics.GetBase().GetDevice();
                D3DVERTEXELEMENT9[] element =
                {
                    new D3DVERTEXELEMENT9(0, 0, D3DDECLTYPE_FLOAT4, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_POSITIONT, 0),
                    new D3DVERTEXELEMENT9(0, 16, D3DDECLTYPE_D3DCOLOR, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_COLOR, 0),
                    new D3DVERTEXELEMENT9(0, 20, D3DDECLTYPE_FLOAT2, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_TEXCOORD, 0),
                    D3DDECL_END()
                };
                device.CreateVertexDeclaration(element, pVertexDecl_);
            }


            /**********************************************************
            //RenderObjectTLX
            //���W3D�ϊ��ς݁A���C�e�B���O�ς݁A�e�N�X�`���L��
            **********************************************************/
            public RenderObjectTLX()
            {
                _SetTextureStageCount(1);
                strideVertexStreamZero_ = sizeof(VERTEX_TLX);
                bPermitCamera_ = true;
            }

            public new void Dispose()
            {

                base.Dispose();
            }

            public override void Render()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                DxCamera2D camera = graphics.GetCamera2D().GetPointer();
                IDirect3DDevice9 device = graphics.GetDevice();
                ref_count_ptr<Texture> texture = texture_[0];
                if (texture != null)
                {
                    device.SetTexture(0, texture.GetD3DTexture());
                }
                else
                {
                    device.SetTexture(0, null);
                }
                device.SetFVF(VERTEX_TLX.fvf);

                // ���W�ϊ�
                bool bPos = position_.x != 0.0f || position_.y != 0.0f || position_.z != 0.0f;
                bool bAngle = angle_.x != 0.0f || angle_.y != 0.0f || angle_.z != 0.0f;
                bool bScale = scale_.x != 1.0f || scale_.y != 1.0f || scale_.z != 1.0f;
                bool bCamera = camera.IsEnable() && bPermitCamera_;
                if (bPos || bAngle || bScale || bCamera)
                {
                    // ���W�ϊ��L��Ȃ�A���W3D�ϊ��ς݂Ȃ��ߎ��O�ŕϊ��������
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
                    if (bPos)
                    {
                        D3DXMATRIX matTrans = new D3DXMATRIX();
                        D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matTrans;
                        mat.CopyFrom(mat * matTrans);
                    }

                    if (bCamera)
                    {
                        D3DXMATRIX matCamera = camera.GetMatrix();
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matCamera;
                        mat.CopyFrom(mat * matCamera);
                    }

                    // ���_���̃R�s�[��Ƃ�
                    vertCopy_.Copy(vertex_);

                    // �e���_�ƍs��̐ς�v�Z����
                    int countVertex = GetVertexCount();
                    for (int iVert = 0; iVert < countVertex; iVert++)
                    {
                        int pos = iVert * strideVertexStreamZero_;
                        VERTEX_TLX vert = (VERTEX_TLX)vertCopy_.GetPointer(pos);
                        D3DXVec3TransformCoord((D3DXVECTOR3) vert.position, (D3DXVECTOR3) vert.position, mat);
                    }

                    // �`��
                    BeginShader();
                    int oldSamplerState = 0;
                    if (vertexIndices_.Count == 0)
                    {
                        device.DrawPrimitiveUP(typePrimitive_, _GetPrimitiveCount(), vertCopy_.GetPointer(), strideVertexStreamZero_);
                    }
                    else
                    {
                        device.DrawIndexedPrimitiveUP(typePrimitive_, 0, GetVertexCount(), _GetPrimitiveCount(), vertexIndices_[0], D3DFMT_INDEX16, vertCopy_.GetPointer(), strideVertexStreamZero_);
                    }
                    EndShader();

                    // ���_������ɖ߂�
                    // memcpy(vertex_.GetPointer(), vertCopy_.GetPointer(), vertex_.GetSize());
                }
                else
                {
                    // ���W�ϊ������Ȃ炻�̂܂ܕ`��
                    BeginShader();
                    if (vertexIndices_.Count == 0)
                    {
                        device.DrawPrimitiveUP(typePrimitive_, _GetPrimitiveCount(), vertex_.GetPointer(), strideVertexStreamZero_);
                    }
                    else
                    {
                        device.DrawIndexedPrimitiveUP(typePrimitive_, 0, GetVertexCount(), _GetPrimitiveCount(), vertexIndices_[0], D3DFMT_INDEX16, vertex_.GetPointer(), strideVertexStreamZero_);
                    }
                    EndShader();
                }
            }

            public override void SetVertexCount(int count)
            {
                base.SetVertexCount(count);
                SetColorRGB(D3DCOLOR_ARGB(255, 255,255, 255));
                SetAlpha(255);
            }

            // ���_�ݒ�
            public new VERTEX_TLX GetVertex(int index)
            {
                int pos = index * strideVertexStreamZero_;
                if (pos >= vertex_.GetSize())
                {
                    return null;
                }
                return (VERTEX_TLX)vertex_.GetPointer(pos);
            }

            public void SetVertex(int index, VERTEX_TLX vertex)
            {
                int pos = index * strideVertexStreamZero_;
                if (pos >= vertex_.GetSize())
                {
                    return;
                }
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(vertex_.GetPointer(pos), vertex, strideVertexStreamZero_);
            }

            public void SetVertexPosition(int index, float x, float y, float z = 1.0f, float w = 1.0f)
            {
                VERTEX_TLX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }

                float bias = -0.5f;
                vertex.position.x = x + bias;
                vertex.position.y = y + bias;
                vertex.position.z = z;
                vertex.position.w = w;
            }

            public new void SetVertexUV(int index, float u, float v)
            {
                VERTEX_TLX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                vertex.texcoord.x = u;
                vertex.texcoord.y = v;
            }

            public void SetVertexColor(int index, D3DCOLOR color)
            {
                VERTEX_TLX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vertex->diffuse_color = color;
                vertex.diffuse_color.CopyFrom(color);
            }

            public void SetVertexColorARGB(int index, int a, int r, int g, int b)
            {
                VERTEX_TLX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                vertex.diffuse_color = D3DCOLOR_ARGB(a, r, g, b);
            }

            public void SetVertexAlpha(int index, int alpha)
            {
                VERTEX_TLX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                D3DCOLOR color = vertex.diffuse_color;
                color = ColorAccess.SetColorA(color, alpha);
            }

            public void SetVertexColorRGB(int index, int r, int g, int b)
            {
                VERTEX_TLX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                D3DCOLOR color = vertex.diffuse_color;
                color = ColorAccess.SetColorR(color, r);
                color = ColorAccess.SetColorG(color, g);
                color = ColorAccess.SetColorB(color, b);
            }

            public void SetColorRGB(D3DCOLOR color)
            {
                int r = ColorAccess.GetColorR(new D3DCOLOR(color));
                int g = ColorAccess.GetColorG(color);
                int b = ColorAccess.GetColorB(color);
                for (int iVert = 0; iVert < vertex_.GetSize(); iVert++)
                {
                    SetVertexColorRGB(iVert, r, g, b);
                }
            }

            public void SetAlpha(int alpha)
            {
                for (int iVert = 0; iVert < vertex_.GetSize(); iVert++)
                {
                    SetVertexAlpha(iVert, alpha);
                }
            }

            // �J����
            public bool IsPermitCamera()
            {
                return bPermitCamera_;
            }
            public void SetPermitCamera(bool bPermit)
            {
                bPermitCamera_ = bPermit;
            }
    }

    /**********************************************************
    //RenderObjectLX
    //���C�e�B���O�ς݁A�e�N�X�`���L��
    //3D�G�t�F�N�g�p
    **********************************************************/
    public class RenderObjectLX : RenderObject
    {
            protected override void _CreateVertexDeclaration()
            {
                if (pVertexDecl_ != null)
                {
                    return;
                }

                // D3DFVF_XYZ|D3DFVF_DIFFUSE|D3DFVF_TEX1
                IDirect3DDevice9 device = DirectGraphics.GetBase().GetDevice();
                D3DVERTEXELEMENT9[] element =
                {
                    new D3DVERTEXELEMENT9(0, 0, D3DDECLTYPE_FLOAT3, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_POSITION, 0),
                    new D3DVERTEXELEMENT9(0, 12, D3DDECLTYPE_D3DCOLOR, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_COLOR, 0),
                    new D3DVERTEXELEMENT9(0, 16, D3DDECLTYPE_FLOAT2, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_TEXCOORD, 0),
                    D3DDECL_END()
                };
                device.CreateVertexDeclaration(element, pVertexDecl_);
            }

            /**********************************************************
            //RenderObjectLX
            //���C�e�B���O�ς݁A�e�N�X�`���L��
            **********************************************************/
            public RenderObjectLX()
            {
                _SetTextureStageCount(1);
                strideVertexStreamZero_ = sizeof(VERTEX_LX);
            }

            public new void Dispose()
            {

                base.Dispose();
            }

            public override void Render()
            {
                IDirect3DDevice9 device = DirectGraphics.GetBase().GetDevice();
                ref_count_ptr<Texture> texture = texture_[0];
                if (texture != null)
                {
                    device.SetTexture(0, texture.GetD3DTexture());
                }
                else
                {
                    device.SetTexture(0, null);
                }

                D3DXMATRIX mat = _CreateWorldTransformMaxtrix();
                device.SetTransform(D3DTS_WORLD, mat);

                device.SetFVF(VERTEX_LX.fvf);

                BeginShader();
                if (vertexIndices_.Count == 0)
                {
                    device.DrawPrimitiveUP(typePrimitive_, _GetPrimitiveCount(), vertex_.GetPointer(), strideVertexStreamZero_);
                }
                else
                {
                    device.DrawIndexedPrimitiveUP(typePrimitive_, 0, GetVertexCount(), _GetPrimitiveCount(), vertexIndices_[0], D3DFMT_INDEX16, vertex_.GetPointer(), strideVertexStreamZero_);
                }
                EndShader();
            }

            public override void SetVertexCount(int count)
            {
                base.SetVertexCount(count);
                SetColorRGB(D3DCOLOR_ARGB(255, 255,255, 255));
                SetAlpha(255);
            }

            // ���_�ݒ�
            public new VERTEX_LX GetVertex(int index)
            {
                int pos = index * strideVertexStreamZero_;
                if (pos >= vertex_.GetSize())
                {
                    return null;
                }
                return (VERTEX_LX)vertex_.GetPointer(pos);
            }

            public void SetVertex(int index, VERTEX_LX vertex)
            {
                int pos = index * strideVertexStreamZero_;
                if (pos >= vertex_.GetSize())
                {
                    return;
                }
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(vertex_.GetPointer(pos), vertex, strideVertexStreamZero_);
            }

            public new void SetVertexPosition(int index, float x, float y, float z)
            {
                VERTEX_LX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }

                float bias = -0.5f;
                vertex.position.x = x + bias;
                vertex.position.y = y + bias;
                vertex.position.z = z;
            }

            public new void SetVertexUV(int index, float u, float v)
            {
                VERTEX_LX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                vertex.texcoord.x = u;
                vertex.texcoord.y = v;
            }

            public void SetVertexColor(int index, D3DCOLOR color)
            {
                VERTEX_LX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vertex->diffuse_color = color;
                vertex.diffuse_color.CopyFrom(color);
            }

            public void SetVertexColorARGB(int index, int a, int r, int g, int b)
            {
                VERTEX_LX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                vertex.diffuse_color = D3DCOLOR_ARGB(a, r, g, b);
            }

            public void SetVertexAlpha(int index, int alpha)
            {
                VERTEX_LX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                D3DCOLOR color = vertex.diffuse_color;
                color = ColorAccess.SetColorA(color, alpha);
            }

            public void SetVertexColorRGB(int index, int r, int g, int b)
            {
                VERTEX_LX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                D3DCOLOR color = vertex.diffuse_color;
                color = ColorAccess.SetColorR(color, r);
                color = ColorAccess.SetColorG(color, g);
                color = ColorAccess.SetColorB(color, b);
            }

            public void SetColorRGB(D3DCOLOR color)
            {
                int r = ColorAccess.GetColorR(new D3DCOLOR(color));
                int g = ColorAccess.GetColorG(color);
                int b = ColorAccess.GetColorB(color);
                for (int iVert = 0; iVert < vertex_.GetSize(); iVert++)
                {
                    SetVertexColorRGB(iVert, r, g, b);
                }
            }

            public void SetAlpha(int alpha)
            {
                for (int iVert = 0; iVert < vertex_.GetSize(); iVert++)
                {
                    SetVertexAlpha(iVert, alpha);
                }
            }
    }

    /**********************************************************
    //RenderObjectNX
    //�@���L��A�e�N�X�`���L��
    **********************************************************/
    public class RenderObjectNX : RenderObject
    {
            protected D3DCOLOR color_ = new D3DCOLOR();
            protected override void _CreateVertexDeclaration()
            {
                if (pVertexDecl_ != null)
                {
                    return;
                }

                // D3DFVF_XYZ|D3DFVF_NORMAL|D3DFVF_TEX1
                IDirect3DDevice9 device = DirectGraphics.GetBase().GetDevice();
                D3DVERTEXELEMENT9[] element =
                {
                    new D3DVERTEXELEMENT9(0, 0, D3DDECLTYPE_FLOAT3, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_POSITION, 0),
                    new D3DVERTEXELEMENT9(0, 12, D3DDECLTYPE_FLOAT3, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_NORMAL, 0),
                    new D3DVERTEXELEMENT9(0, 24, D3DDECLTYPE_FLOAT2, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_TEXCOORD, 0),
                    D3DDECL_END()
                };
                device.CreateVertexDeclaration(element, pVertexDecl_);
            }

            /**********************************************************
            //RenderObjectNX
            **********************************************************/
            public RenderObjectNX()
            {
                _SetTextureStageCount(1);
                strideVertexStreamZero_ = sizeof(VERTEX_NX);
            }

            public new void Dispose()
            {

                base.Dispose();
            }

            public override void Render()
            {
                IDirect3DDevice9 device = DirectGraphics.GetBase().GetDevice();
                ref_count_ptr<Texture> texture = texture_[0];
                if (texture != null)
                {
                    device.SetTexture(0, texture.GetD3DTexture());
                }
                else
                {
                    device.SetTexture(0, null);
                }

                uint bFogEnable = false;
                D3DXMATRIX matView = new D3DXMATRIX();
                D3DXMATRIX matProj = new D3DXMATRIX();
                if (bCoordinate2D_)
                {
                    device.GetTransform(D3DTS_VIEW, matView);
                    device.GetTransform(D3DTS_PROJECTION, matProj);
                    device.GetRenderState(D3DRS_FOGENABLE, bFogEnable);
                    device.SetRenderState(D3DRS_FOGENABLE, false);
                    _SetCoordinate2dDeviceMatrix();
                }

                D3DXMATRIX mat = _CreateWorldTransformMaxtrix();
                device.SetTransform(D3DTS_WORLD, mat);

                device.SetFVF(VERTEX_NX.fvf);
                BeginShader();
                if (vertexIndices_.Count == 0)
                {
                    device.DrawPrimitiveUP(typePrimitive_, _GetPrimitiveCount(), vertex_.GetPointer(), strideVertexStreamZero_);
                }
                else
                {
                    device.DrawIndexedPrimitiveUP(typePrimitive_, 0, GetVertexCount(), _GetPrimitiveCount(), vertexIndices_[0], D3DFMT_INDEX16, vertex_.GetPointer(), strideVertexStreamZero_);
                }
                EndShader();

                if (bCoordinate2D_)
                {
                    device.SetTransform(D3DTS_VIEW, matView);
                    device.SetTransform(D3DTS_PROJECTION, matProj);
                    device.SetRenderState(D3DRS_FOGENABLE, bFogEnable);
                }
            }

            // ���_�ݒ�
            public new VERTEX_NX GetVertex(int index)
            {
                int pos = index * strideVertexStreamZero_;
                if (pos >= vertex_.GetSize())
                {
                    return null;
                }
                return (VERTEX_NX)vertex_.GetPointer(pos);
            }

            public new void SetVertex(int index, VERTEX_NX vertex)
            {
                int pos = index * strideVertexStreamZero_;
                if (pos >= vertex_.GetSize())
                {
                    return;
                }
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(vertex_.GetPointer(pos), vertex, strideVertexStreamZero_);
            }

            public new void SetVertexPosition(int index, float x, float y, float z)
            {
                VERTEX_NX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }

                float bias = -0.5f;
                vertex.position.x = x + bias;
                vertex.position.y = y + bias;
                vertex.position.z = z;
            }

            public new void SetVertexUV(int index, float u, float v)
            {
                VERTEX_NX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                vertex.texcoord.x = u;
                vertex.texcoord.y = v;
            }

            public new void SetVertexNormal(int index, float x, float y, float z)
            {
                VERTEX_NX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                vertex.normal.x = x;
                vertex.normal.y = y;
                vertex.normal.z = z;
            }

            public new void SetColor(D3DCOLOR color)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color_ = color;
                color_.CopyFrom(color);
            }
    }

    /**********************************************************
    //RenderObjectBNX
    //���_�u�����h
    //�@���L��
    //�e�N�X�`���L��
    **********************************************************/
    public abstract class RenderObjectBNX : RenderObject
    {
            public class Vertex
            {
                public D3DXVECTOR3 position = new D3DXVECTOR3();
                public D3DXVECTOR4 blendRate = new D3DXVECTOR4();
                public D3DXVECTOR4 blendIndex = new D3DXVECTOR4();
                public D3DXVECTOR3 normal = new D3DXVECTOR3();
                public D3DXVECTOR2 texcoord = new D3DXVECTOR2();
            }
            protected gstd.ref_count_ptr<Matrices> matrix_ = new gstd.ref_count_ptr<Matrices>();
            protected D3DCOLOR color_ = new D3DCOLOR();
            protected D3DMATERIAL9 materialBNX_ = new D3DMATERIAL9();
            protected override void _CreateVertexDeclaration()
            {
                if (pVertexDecl_ != null)
                {
                    return;
                }
                IDirect3DDevice9 device = DirectGraphics.GetBase().GetDevice();
                D3DVERTEXELEMENT9[] element =
                {
                    new D3DVERTEXELEMENT9(0, 0, D3DDECLTYPE_FLOAT3, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_POSITION, 0),
                    new D3DVERTEXELEMENT9(0, 12, D3DDECLTYPE_FLOAT4, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_BLENDWEIGHT, 0),
                    new D3DVERTEXELEMENT9(0, 28, D3DDECLTYPE_FLOAT4, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_BLENDINDICES, 0),
                    new D3DVERTEXELEMENT9(0, 44, D3DDECLTYPE_FLOAT3, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_NORMAL, 0),
                    new D3DVERTEXELEMENT9(0, 56, D3DDECLTYPE_FLOAT2, D3DDECLMETHOD_DEFAULT, D3DDECLUSAGE_TEXCOORD, 0),
                    D3DDECL_END()
                };
                device.CreateVertexDeclaration(element, pVertexDecl_);

            }

            protected abstract void _CopyVertexBufferOnInitialize();

            /**********************************************************
            //RenderObjectBNX
            **********************************************************/
            public RenderObjectBNX()
            {
                _SetTextureStageCount(1);
                color_ = D3DCOLOR_ARGB(255, 255, 255, 255);

                _CreateVertexDeclaration();
                materialBNX_.Diffuse.a = 1.0f;
                materialBNX_.Diffuse.r = 1.0f;
                materialBNX_.Diffuse.g = 1.0f;
                materialBNX_.Diffuse.b = 1.0f;
                materialBNX_.Ambient.a = 1.0f;
                materialBNX_.Ambient.r = 1.0f;
                materialBNX_.Ambient.g = 1.0f;
                materialBNX_.Ambient.b = 1.0f;
                materialBNX_.Specular.a = 1.0f;
                materialBNX_.Specular.r = 1.0f;
                materialBNX_.Specular.g = 1.0f;
                materialBNX_.Specular.b = 1.0f;
                materialBNX_.Emissive.a = 1.0f;
                materialBNX_.Emissive.r = 1.0f;
                materialBNX_.Emissive.g = 1.0f;
                materialBNX_.Emissive.b = 1.0f;
            }

            public new void Dispose()
            {
                base.Dispose();
            }

            public override void InitializeVertexBuffer()
            {
                int countVertex = GetVertexCount();
                IDirect3DDevice9 device = DirectGraphics.GetBase().GetDevice();
                device.CreateVertexBuffer(countVertex * sizeof(Vertex), 0, 0, D3DPOOL_MANAGED, pVertexBuffer_, null);

                // �R�s�[
                _CopyVertexBufferOnInitialize();

                int countIndex = vertexIndices_.Count;
                if (countIndex != 0)
                {
                    device.CreateIndexBuffer(sizeof(short) * countIndex, D3DUSAGE_WRITEONLY, D3DFMT_INDEX16, D3DPOOL_MANAGED, pIndexBuffer_, null);

// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte *bufIndex;
                    byte bufIndex;
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in C#:
                    int hrLockIndex = pIndexBuffer_.Lock(0, 0, reinterpret_cast<object>(bufIndex), 0);
                    if (!FAILED(hrLockIndex))
                    {
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                        memcpy(bufIndex, vertexIndices_[0], sizeof(short) * countIndex);
                        pIndexBuffer_.Unlock();
                    }
                }
            }

            public override void Render()
            {
                IDirect3DDevice9 device = DirectGraphics.GetBase().GetDevice();
                ref_count_ptr<Texture> texture = texture_[0];
                if (texture != null)
                {
                    device.SetTexture(0, texture.GetD3DTexture());
                }
                else
                {
                    device.SetTexture(0, null);
                }

                uint bFogEnable = false;
                D3DXMATRIX matView = new D3DXMATRIX();
                D3DXMATRIX matProj = new D3DXMATRIX();
                if (bCoordinate2D_)
                {
                    device.GetTransform(D3DTS_VIEW, matView);
                    device.GetTransform(D3DTS_PROJECTION, matProj);
                    device.GetRenderState(D3DRS_FOGENABLE, bFogEnable);
                    device.SetRenderState(D3DRS_FOGENABLE, false);
                    _SetCoordinate2dDeviceMatrix();
                }

                if (false)
                {
                    D3DXMATRIX mat = _CreateWorldTransformMaxtrix();
                    device.SetTransform(D3DTS_WORLD, mat);

                    int sizeMatrix = matrix_.GetSize();
                    for (int iMatrix = 0 ; iMatrix < sizeMatrix ; iMatrix++)
                    {
                        D3DXMATRIX matrix = matrix_.GetMatrix(iMatrix) * mat;
                        device.SetTransform(D3DTS_WORLDMATRIX(iMatrix), matrix);
                    }

                    device.SetRenderState(D3DRS_INDEXEDVERTEXBLENDENABLE,true);
                    device.SetRenderState(D3DRS_VERTEXBLEND,D3DVBF_1WEIGHTS);

                    device.SetFVF(VERTEX_B2NX.fvf);
                    if (vertexIndices_.Count == 0)
                    {
                        device.DrawPrimitiveUP(typePrimitive_, _GetPrimitiveCount(), vertex_.GetPointer(), strideVertexStreamZero_);
                    }
                    else
                    {
                        device.DrawIndexedPrimitiveUP(typePrimitive_, 0, GetVertexCount(), _GetPrimitiveCount(), vertexIndices_[0], D3DFMT_INDEX16, vertex_.GetPointer(), strideVertexStreamZero_);
                    }

                    device.SetRenderState(D3DRS_INDEXEDVERTEXBLENDENABLE,false);
                    device.SetRenderState(D3DRS_VERTEXBLEND,D3DVBF_DISABLE);
                }
                else
                {
                    ShaderManager manager = ShaderManager.GetBase();
                    ref_count_ptr<Shader> shader = manager.GetDefaultSkinnedMeshShader();
                    if (shader != null)
                    {
                        shader.SetTechnique("BasicTec");

                        D3DXMATRIX matView = new D3DXMATRIX();
                        device.GetTransform(D3DTS_VIEW, matView);
                        D3DXMATRIX matProj = new D3DXMATRIX();
                        device.GetTransform(D3DTS_PROJECTION, matProj);

                        shader.SetMatrix("mViewProj", matView * matProj);

                        D3DXMATRIX matWorld = _CreateWorldTransformMaxtrix();
                        D3DLIGHT9 light = new D3DLIGHT9();
                        device.GetLight(0, light);
                        D3DCOLORVALUE diffuse = materialBNX_.Diffuse;
                        diffuse.r = System.Math.Min(diffuse.r + light.Diffuse.r, 1.0f);
                        diffuse.g = System.Math.Min(diffuse.g + light.Diffuse.g, 1.0f);
                        diffuse.b = System.Math.Min(diffuse.b + light.Diffuse.b, 1.0f);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: diffuse = ColorAccess::SetColor(diffuse, color_);
                        diffuse.CopyFrom(ColorAccess.SetColor(new D3DCOLORVALUE(diffuse), new D3DCOLOR(color_)));

                        D3DCOLORVALUE ambient = materialBNX_.Ambient;
                        ambient.r = System.Math.Min(ambient.r + light.Ambient.r, 1.0f);
                        ambient.g = System.Math.Min(ambient.g + light.Ambient.g, 1.0f);
                        ambient.b = System.Math.Min(ambient.b + light.Ambient.b, 1.0f);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: ambient = ColorAccess::SetColor(ambient, color_);
                        ambient.CopyFrom(ColorAccess.SetColor(new D3DCOLORVALUE(ambient), new D3DCOLOR(color_)));


                        // ���C�g
                        shader.SetVector("lightDirection", D3DXVECTOR4(1.0f, 1.0f, 1.0f, 1.0f));
                        shader.SetVector("lightDiffuse", D3DXVECTOR4(1.0f, 1.0f, 1.0f, 1.0f));
                        shader.SetVector("materialDiffuse", (D3DXVECTOR4)diffuse);
                        shader.SetVector("materialAmbient", (D3DXVECTOR4)ambient);

                        // �t�H�O
                        uint fogNear = 0;
                        uint fogFar = 0;
                        device.GetRenderState(D3DRS_FOGSTART, fogNear);
                        device.GetRenderState(D3DRS_FOGEND, fogFar);
                        shader.SetFloat("fogNear", (float)fogNear);
                        shader.SetFloat("fogFar", (float)fogFar);

                        // ���W�ϊ�
                        int sizeMatrix = matrix_.GetSize();
                        List<D3DXMATRIX> listMatrix = new List<D3DXMATRIX>(sizeMatrix);
                        for (int iMatrix = 0 ; iMatrix < sizeMatrix ; iMatrix++)
                        {
                            D3DXMATRIX matrix = matrix_.GetMatrix(iMatrix) * matWorld;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: listMatrix[iMatrix] = matrix;
                            listMatrix[iMatrix].CopyFrom(matrix);
                        }
                        shader.SetMatrixArray("mWorldMatrixArray", listMatrix);

                        uint numPass = shader.Begin();

                        device.SetVertexDeclaration(pVertexDecl_);
                        device.SetStreamSource(0, pVertexBuffer_, 0, sizeof(Vertex));
                        if (vertexIndices_.Count == 0)
                        {
                            device.SetIndices(null);
                            device.DrawPrimitive(typePrimitive_, 0, _GetPrimitiveCount());
                        }
                        else
                        {
                            device.SetIndices(pIndexBuffer_);
                            device.DrawIndexedPrimitive(typePrimitive_, 0, 0, GetVertexCount(), 0, _GetPrimitiveCount());
                        }

                        shader.End();
                    }
                    else
                    {
                        Logger.WriteTop(StringUtility.Format("Shader error[%s]","DEFAULT"));
                    }


                    device.SetVertexDeclaration(null);
                    device.SetIndices(null);
                    device.SetTexture(0, null);
                }

                if (bCoordinate2D_)
                {
                    device.SetTransform(D3DTS_VIEW, matView);
                    device.SetTransform(D3DTS_PROJECTION, matProj);
                    device.SetRenderState(D3DRS_FOGENABLE, bFogEnable);
                }
            }

            // �`��p�ݒ�
            public void SetMatrix(gstd.ref_count_ptr<Matrices> matrix)
            {
                matrix_.CopyFrom(matrix);
            }
            public new void SetColor(D3DCOLOR color)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color_ = color;
                color_.CopyFrom(color);
            }
    }

    public abstract class RenderObjectBNXBlock : RenderBlock
    {
            protected gstd.ref_count_ptr<Matrices> matrix_ = new gstd.ref_count_ptr<Matrices>();
            protected D3DCOLOR color_ = new D3DCOLOR();

            public void SetMatrix(gstd.ref_count_ptr<Matrices> matrix)
            {
                matrix_.CopyFrom(matrix);
            }
            public void SetColor(D3DCOLOR color)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color_ = color;
                color_.CopyFrom(color);
            }
            public override bool IsTranslucent()
            {
                return ColorAccess.GetColorA(color_) != 255;
            }
    }

    /**********************************************************
    //RenderObjectB2NX
    //���_�u�����h2
    //�@���L��
    //�e�N�X�`���L��
    **********************************************************/
    public class RenderObjectB2NX : RenderObjectBNX
    {
            protected override void _CopyVertexBufferOnInitialize()
            {
                int countVertex = GetVertexCount();
                Vertex[] bufVertex;
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in C#:
                int hrLockVertex = pVertexBuffer_.Lock(0, 0, reinterpret_cast<object>(bufVertex), D3DLOCK_NOSYSLOCK);
                if (!FAILED(hrLockVertex))
                {
                    for (int iVert = 0 ; iVert < countVertex ; iVert++)
                    {
                        Vertex dest = bufVertex[iVert];
                        VERTEX_B2NX src = GetVertex(iVert);
                        ZeroMemory(dest, sizeof(Vertex));

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dest->position = src->position;
                        dest.position.CopyFrom(src.position);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dest->normal = src->normal;
                        dest.normal.CopyFrom(src.normal);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dest->texcoord = src->texcoord;
                        dest.texcoord.CopyFrom(src.texcoord);

                        for (int iBlend = 0 ;iBlend < 2 ; iBlend++)
                        {
                            int indexBlend = BitAccess.GetByte(src.blendIndex, iBlend * 8);
                            dest.blendIndex[iBlend] = indexBlend;
                        }

                        dest.blendRate[0] = src.blendRate;
                        dest.blendRate[1] = 1.0f - dest.blendRate[0];
                    }
                    pVertexBuffer_.Unlock();
                }
            }


            /**********************************************************
            //RenderObjectB2NX
            **********************************************************/
            public RenderObjectB2NX()
            {
                strideVertexStreamZero_ = sizeof(VERTEX_B2NX);
            }

            public new void Dispose()
            {

                base.Dispose();
            }

            public override void CalculateWeightCenter()
            {
                double xTotal = 0;
                double yTotal = 0;
                double zTotal = 0;
                int countVert = GetVertexCount();
                for (int iVert = 0 ; iVert < countVert ; iVert++)
                {
                    VERTEX_B2NX vertex = GetVertex(iVert);
                    xTotal += vertex.position.x;
                    yTotal += vertex.position.y;
                    zTotal += vertex.position.z;
                }
                xTotal /= countVert;
                yTotal /= countVert;
                zTotal /= countVert;
                posWeightCenter_.x = (float)xTotal;
                posWeightCenter_.y = (float)yTotal;
                posWeightCenter_.z = (float)zTotal;
            }

            // ���_�ݒ�
            public new VERTEX_B2NX GetVertex(int index)
            {
                int pos = index * strideVertexStreamZero_;
                if (pos >= vertex_.GetSize())
                {
                    return null;
                }
                return (VERTEX_B2NX)vertex_.GetPointer(pos);
            }

            public void SetVertex(int index, VERTEX_B2NX vertex)
            {
                int pos = index * strideVertexStreamZero_;
                if (pos >= vertex_.GetSize())
                {
                    return;
                }
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(vertex_.GetPointer(pos), vertex, strideVertexStreamZero_);
            }

            public new void SetVertexPosition(int index, float x, float y, float z)
            {
                VERTEX_B2NX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }

                float bias = -0.5f;
                vertex.position.x = x + bias;
                vertex.position.y = y + bias;
                vertex.position.z = z;
            }

            public new void SetVertexUV(int index, float u, float v)
            {
                VERTEX_B2NX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                vertex.texcoord.x = u;
                vertex.texcoord.y = v;
            }

            public void SetVertexBlend(int index, int pos, byte indexBlend, float rate)
            {
                VERTEX_B2NX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                BitAccess.SetByte(vertex.blendIndex, pos * 8, indexBlend);
                if (pos == 0)
                {
                    vertex.blendRate = rate;
                }
            }

            public new void SetVertexNormal(int index, float x, float y, float z)
            {
                VERTEX_B2NX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                vertex.normal.x = x;
                vertex.normal.y = y;
                vertex.normal.z = z;
            }
    }

    public abstract class RenderObjectB2NXBlock : RenderObjectBNXBlock
    {

            // RenderObjectB2NXBlock
            public RenderObjectB2NXBlock()
            {
            }

            public override void Dispose()
            {
                base.Dispose();
            }

            public override void Render()
            {
                RenderObjectB2NX obj = (RenderObjectB2NX)obj_.GetPointer();
                obj.SetMatrix(new gstd.ref_count_ptr<Matrices>(matrix_));
                base.Render();
            }
    }

    /**********************************************************
    //RenderObjectB4NX
    //���_�u�����h4
    //�@���L��
    //�e�N�X�`���L��
    **********************************************************/
    public class RenderObjectB4NX : RenderObjectBNX
    {
            protected override void _CopyVertexBufferOnInitialize()
            {
                int countVertex = GetVertexCount();
                Vertex[] bufVertex;
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in C#:
                int hrLockVertex = pVertexBuffer_.Lock(0, 0, reinterpret_cast<object>(bufVertex), D3DLOCK_NOSYSLOCK);
                if (!FAILED(hrLockVertex))
                {
                    for (int iVert = 0 ; iVert < countVertex ; iVert++)
                    {
                        Vertex dest = bufVertex[iVert];
                        VERTEX_B4NX src = GetVertex(iVert);
                        ZeroMemory(dest, sizeof(Vertex));

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dest->position = src->position;
                        dest.position.CopyFrom(src.position);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dest->normal = src->normal;
                        dest.normal.CopyFrom(src.normal);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dest->texcoord = src->texcoord;
                        dest.texcoord.CopyFrom(src.texcoord);

                        for (int iBlend = 0 ;iBlend < 4 ; iBlend++)
                        {
                            int indexBlend = BitAccess.GetByte(src.blendIndex, iBlend * 8);
                            dest.blendIndex[iBlend] = indexBlend;
                        }

                        float lastRate = 1.0f;
                        for (int iRate = 0 ; iRate < 3 ; iRate++)
                        {
                            float rate = src.blendRate[iRate];
                            dest.blendRate[iRate] = rate;
                            lastRate -= rate;
                        }
                        dest.blendRate[3] = lastRate;
                    }
                    pVertexBuffer_.Unlock();
                }
            }


            /**********************************************************
            //RenderObjectB4NX
            **********************************************************/
            public RenderObjectB4NX()
            {
                strideVertexStreamZero_ = sizeof(VERTEX_B4NX);
            }

            public new void Dispose()
            {

                base.Dispose();
            }

            public override void CalculateWeightCenter()
            {
                double xTotal = 0;
                double yTotal = 0;
                double zTotal = 0;
                int countVert = GetVertexCount();
                for (int iVert = 0 ; iVert < countVert ; iVert++)
                {
                    VERTEX_B4NX vertex = GetVertex(iVert);
                    xTotal += vertex.position.x;
                    yTotal += vertex.position.y;
                    zTotal += vertex.position.z;
                }
                xTotal /= countVert;
                yTotal /= countVert;
                zTotal /= countVert;
                posWeightCenter_.x = (float)xTotal;
                posWeightCenter_.y = (float)yTotal;
                posWeightCenter_.z = (float)zTotal;
            }

            // ���_�ݒ�
            public new VERTEX_B4NX GetVertex(int index)
            {
                int pos = index * strideVertexStreamZero_;
                if (pos >= vertex_.GetSize())
                {
                    return null;
                }
                return (VERTEX_B4NX)vertex_.GetPointer(pos);
            }

            public void SetVertex(int index, VERTEX_B4NX vertex)
            {
                int pos = index * strideVertexStreamZero_;
                if (pos >= vertex_.GetSize())
                {
                    return;
                }
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(vertex_.GetPointer(pos), vertex, strideVertexStreamZero_);
            }

            public new void SetVertexPosition(int index, float x, float y, float z)
            {
                VERTEX_B4NX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }

                float bias = -0.5f;
                vertex.position.x = x + bias;
                vertex.position.y = y + bias;
                vertex.position.z = z;
            }

            public new void SetVertexUV(int index, float u, float v)
            {
                VERTEX_B4NX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                vertex.texcoord.x = u;
                vertex.texcoord.y = v;
            }

            public void SetVertexBlend(int index, int pos, byte indexBlend, float rate)
            {
                VERTEX_B4NX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                BitAccess.SetByte(vertex.blendIndex, pos * 8, indexBlend);
                if (pos <= 2)
                {
                    vertex.blendRate[pos] = rate;
                }
            }

            public new void SetVertexNormal(int index, float x, float y, float z)
            {
                VERTEX_B4NX vertex = GetVertex(index);
                if (vertex == null)
                {
                    return;
                }
                vertex.normal.x = x;
                vertex.normal.y = y;
                vertex.normal.z = z;
            }
    }

    public abstract class RenderObjectB4NXBlock : RenderObjectBNXBlock
    {

            // RenderObjectB4NXBlock
            public RenderObjectB4NXBlock()
            {
            }

            public override void Dispose()
            {
                base.Dispose();
            }

            public override void Render()
            {
                RenderObjectB4NX obj = (RenderObjectB4NX)obj_.GetPointer();
                obj.SetMatrix(new gstd.ref_count_ptr<Matrices>(matrix_));
                base.Render();
            }
    }

    /**********************************************************
    //Sprite2D
    //��`�X�v���C�g
    **********************************************************/
    public class Sprite2D : RenderObjectTLX
    {

            /**********************************************************
            //Sprite2D
            //��`�X�v���C�g
            **********************************************************/
            public Sprite2D()
            {
                SetVertexCount(4); // ����A�E��A�����A�E��
                SetPrimitiveType(D3DPT_TRIANGLESTRIP);
            }

            public new void Dispose()
            {

                base.Dispose();
            }

            public void Copy(Sprite2D src)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: typePrimitive_ = src->typePrimitive_;
                typePrimitive_.CopyFrom(src.typePrimitive_);
                strideVertexStreamZero_ = src.strideVertexStreamZero_;
                vertex_.Copy(src.vertex_);
                vertexIndices_ = new List<short>(src.vertexIndices_);
                for (int iTex = 0 ; iTex < texture_.Count ; iTex++)
                {
                    texture_[iTex].CopyFrom(src.texture_[iTex]);
                }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: posWeightCenter_ = src->posWeightCenter_;
                posWeightCenter_.CopyFrom(src.posWeightCenter_);

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: position_ = src->position_;
                position_.CopyFrom(src.position_);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: angle_ = src->angle_;
                angle_.CopyFrom(src.angle_);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: scale_ = src->scale_;
                scale_.CopyFrom(src.scale_);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: matRelative_ = src->matRelative_;
                matRelative_.CopyFrom(src.matRelative_);
            }

            public void SetSourceRect(RECT_D rcSrc)
            {
                ref_count_ptr<Texture> texture = texture_[0];
                if (texture == null)
                {
                    return;
                }
                int width = texture.GetWidth();
                int height = texture.GetHeight();

                // �e�N�X�`��UV
                SetVertexUV(0, (float)rcSrc.left / (float)width, (float)rcSrc.top / (float)height);
                SetVertexUV(1, (float)rcSrc.right / (float)width, (float)rcSrc.top / (float)height);
                SetVertexUV(2, (float)rcSrc.left / (float)width, (float)rcSrc.bottom / (float)height);
                SetVertexUV(3, (float)rcSrc.right / (float)width, (float)rcSrc.bottom / (float)height);
            }

            public void SetDestinationRect(RECT_D rcDest)
            {
                // ���_�ʒu
                SetVertexPosition(0, rcDest.left, rcDest.top);
                SetVertexPosition(1, rcDest.right, rcDest.top);
                SetVertexPosition(2, rcDest.left, rcDest.bottom);
                SetVertexPosition(3, rcDest.right, rcDest.bottom);
            }

            public void SetDestinationCenter()
            {
                ref_count_ptr<Texture> texture = texture_[0];
                if (texture == null || GetVertexCount() < 4)
                {
                    return;
                }
                int width = texture.GetWidth();
                int height = texture.GetHeight();

                VERTEX_TLX vertLT = GetVertex(0); // ����
                VERTEX_TLX vertRB = GetVertex(3); // �E��

                int vWidth = vertRB.texcoord.x * width - vertLT.texcoord.x * width;
                int vHeight = vertRB.texcoord.y * height - vertLT.texcoord.y * height;
                RECT_D rcDest = new RECT_D() { left = -vWidth / 2.0, top = -vHeight / 2.0, right = vWidth / 2.0, bottom = vHeight / 2.0 };

                SetDestinationRect(rcDest);
            }

            public void SetVertex(RECT_D rcSrc, RECT_D rcDest, D3DCOLOR color = D3DCOLOR_ARGB(255,255,255,255))
            {
                SetSourceRect(rcSrc);
                SetDestinationRect(rcDest);
                SetColorRGB(new D3DCOLOR(color));
                SetAlpha(ColorAccess.GetColorA(color));
            }

            public RECT_D GetDestinationRect()
            {
                float bias = -0.5f;

                RECT_D rect = new RECT_D();
                VERTEX_TLX vertexLeftTop = GetVertex(0);
                VERTEX_TLX vertexRightBottom = GetVertex(3);

                rect.left = vertexLeftTop.position.x - bias;
                rect.top = vertexLeftTop.position.y - bias;
                rect.right = vertexRightBottom.position.x - bias;
                rect.bottom = vertexRightBottom.position.y - bias;

// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return rect;
                return new directx.RECT_D(rect);
            }
    }

    /**********************************************************
    //SpriteList2D
    //��`�X�v���C�g���X�g
    **********************************************************/
    public class SpriteList2D : RenderObjectTLX
    {
            private int countRenderVertex_;
            private RECT_D rcSrc_ = new RECT_D();
            private RECT_D rcDest_ = new RECT_D();
            private D3DCOLOR color_ = new D3DCOLOR();
            private bool bCloseVertexList_;
            private void _AddVertex(VERTEX_TLX vertex)
            {
                int count = vertex_.GetSize() / strideVertexStreamZero_;
                if (countRenderVertex_ >= count)
                {
                    // ���T�C�Y
                    int newCount = System.Math.Max(10, count * 1.5);
                    ByteBuffer buffer = new ByteBuffer(vertex_);
                    SetVertexCount(newCount);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                    memcpy(vertex_.GetPointer(), buffer.GetPointer(), buffer.GetSize());
                }
                SetVertex(countRenderVertex_, vertex);
                countRenderVertex_++;
            }


            /**********************************************************
            //SpriteList2D
            **********************************************************/
            public SpriteList2D()
            {
                countRenderVertex_ = 0;
                color_ = D3DCOLOR_ARGB(255, 255, 255, 255);
                bCloseVertexList_ = false;
            }

            public override int GetVertexCount()
            {
                int res = countRenderVertex_;
                res = System.Math.Min(countRenderVertex_, vertex_.GetSize() / strideVertexStreamZero_);
                return res;
            }

            public override void Render()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                DxCamera2D camera = graphics.GetCamera2D().GetPointer();
                IDirect3DDevice9 device = graphics.GetDevice();
                ref_count_ptr<Texture> texture = texture_[0];
                if (texture != null)
                {
                    device.SetTexture(0, texture.GetD3DTexture());
                }
                else
                {
                    device.SetTexture(0, null);
                }
                device.SetFVF(VERTEX_TLX.fvf);

                // ���W�ϊ�
                bool bPos = position_.x != 0.0f || position_.y != 0.0f || position_.z != 0.0f;
                bool bAngle = angle_.x != 0.0f || angle_.y != 0.0f || angle_.z != 0.0f;
                bool bScale = scale_.x != 1.0f || scale_.y != 1.0f || scale_.z != 1.0f;
                bool bCamera = camera.IsEnable() && bPermitCamera_;
                if (bPos || bAngle || bScale || bCamera)
                {
                    // ���W�ϊ��L��Ȃ�A���W3D�ϊ��ς݂Ȃ��ߎ��O�ŕϊ��������
                    D3DXMATRIX mat = new D3DXMATRIX();
                    D3DXMatrixIdentity(mat);

                    if (bCloseVertexList_)
                    {
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
                        if (bPos)
                        {
                            D3DXMATRIX matTrans = new D3DXMATRIX();
                            D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matTrans;
                            mat.CopyFrom(mat * matTrans);
                        }
                    }

                    if (bCamera)
                    {
                        D3DXMATRIX matCamera = camera.GetMatrix();
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matCamera;
                        mat.CopyFrom(mat * matCamera);
                    }

                    // ���_���̃R�s�[��Ƃ�
                    vertCopy_.Copy(vertex_);

                    // �e���_�ƍs��̐ς�v�Z����
                    int countVertex = GetVertexCount();
                    for (int iVert = 0; iVert < countVertex; iVert++)
                    {
                        int pos = iVert * strideVertexStreamZero_;
                        VERTEX_TLX vert = (VERTEX_TLX)vertCopy_.GetPointer(pos);
                        D3DXVec3TransformCoord((D3DXVECTOR3) vert.position, (D3DXVECTOR3) vert.position, mat);
                    }

                    // �`��
                    int oldSamplerState = 0;

                    BeginShader();
                    if (vertexIndices_.Count == 0)
                    {
                        device.DrawPrimitiveUP(typePrimitive_, _GetPrimitiveCount(), vertCopy_.GetPointer(), strideVertexStreamZero_);
                    }
                    else
                    {
                        device.DrawIndexedPrimitiveUP(typePrimitive_, 0, GetVertexCount(), _GetPrimitiveCount(), vertexIndices_[0], D3DFMT_INDEX16, vertCopy_.GetPointer(), strideVertexStreamZero_);
                    }
                    EndShader();

                    // ���_������ɖ߂�
                    // memcpy(vertex_.GetPointer(), vertCopy_.GetPointer(), vertex_.GetSize());
                }
                else
                {
                    // ���W�ϊ������Ȃ炻�̂܂ܕ`��
                    BeginShader();
                    if (vertexIndices_.Count == 0)
                    {
                        device.DrawPrimitiveUP(typePrimitive_, _GetPrimitiveCount(), vertex_.GetPointer(), strideVertexStreamZero_);
                    }
                    else
                    {
                        device.DrawIndexedPrimitiveUP(typePrimitive_, 0, GetVertexCount(), _GetPrimitiveCount(), vertexIndices_[0], D3DFMT_INDEX16, vertex_.GetPointer(), strideVertexStreamZero_);
                    }
                    EndShader();
                }
            }

            public void ClearVertexCount()
            {
                countRenderVertex_ = 0;
                bCloseVertexList_ = false;
            }
            public void AddVertex()
            {
                if (bCloseVertexList_)
                {
                    return;
                }

                ref_count_ptr<Texture> texture = texture_[0];
                if (texture == null)
                {
                    return;
                }

                int width = texture.GetWidth();
                int height = texture.GetHeight();

                D3DXMATRIX mat = new D3DXMATRIX();
                D3DXMatrixIdentity(mat);

                DirectGraphics graphics = DirectGraphics.GetBase();
                bool bPos = position_.x != 0.0f || position_.y != 0.0f || position_.z != 0.0f;
                bool bAngle = angle_.x != 0.0f || angle_.y != 0.0f || angle_.z != 0.0f;
                bool bScale = scale_.x != 1.0f || scale_.y != 1.0f || scale_.z != 1.0f;

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
                if (bPos)
                {
                    D3DXMATRIX matTrans = new D3DXMATRIX();
                    D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matTrans;
                    mat.CopyFrom(mat * matTrans);
                }

                VERTEX_TLX[] verts = Arrays.InitializeWithDefaultInstances<VERTEX_TLX>(4);
                float[] srcX = { (float)rcSrc_.left, (float)rcSrc_.right, (float)rcSrc_.left, (float)rcSrc_.right };
                float[] srcY = { (float)rcSrc_.top, (float)rcSrc_.top, (float)rcSrc_.bottom, (float)rcSrc_.bottom };
                int[] destX = { (int)rcDest_.left, (int)rcDest_.right, (int)rcDest_.left, (int)rcDest_.right };
                int[] destY = { (int)rcDest_.top, (int)rcDest_.top, (int)rcDest_.bottom, (int)rcDest_.bottom };
                for (int iVert = 0 ;iVert < 4 ; iVert++)
                {
                    VERTEX_TLX vert = verts[iVert];

                    vert.texcoord.x = srcX[iVert] / width;
                    vert.texcoord.y = srcY[iVert] / height;

                    float bias = -0.5f;
                    vert.position.x = destX[iVert] + bias;
                    vert.position.y = destY[iVert] + bias;
                    vert.position.z = 1.0;
                    vert.position.w = 1.0;

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vert.diffuse_color = color_;
                    vert.diffuse_color.CopyFrom(color_);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vert.position = DxMath::VectMatMulti(verts[iVert].position, mat);
                    vert.position.CopyFrom(DxMath.VectMatMulti(new D3DXVECTOR4(verts[iVert].position), mat));
                }

                _AddVertex(verts[0]);
                _AddVertex(verts[2]);
                _AddVertex(verts[1]);
                _AddVertex(verts[1]);
                _AddVertex(verts[2]);
                _AddVertex(verts[3]);
            }

            public void SetSourceRect(RECT_D rcSrc)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcSrc_ = rcSrc;
                rcSrc_.CopyFrom(rcSrc);
            }
            public void SetDestinationRect(RECT_D rcDest)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcDest_ = rcDest;
                rcDest_.CopyFrom(rcDest);
            }
            public void SetDestinationCenter()
            {
                ref_count_ptr<Texture> texture = texture_[0];
                if (texture == null)
                {
                    return;
                }
                int width = texture.GetWidth();
                int height = texture.GetHeight();

                VERTEX_TLX vertLT = GetVertex(0); // ����
                VERTEX_TLX vertRB = GetVertex(3); // �E��

                int vWidth = (int)rcSrc_.right - rcSrc_.left;
                int vHeight = (int)rcSrc_.bottom - rcSrc_.top;
                RECT_D rcDest = new RECT_D() { left = -vWidth / 2.0, top = -vHeight / 2.0, right = vWidth / 2.0, bottom = vHeight / 2.0 };

                SetDestinationRect(rcDest);
            }

            public D3DCOLOR GetColor()
            {
                return new D3DCOLOR(color_);
            }
            public new void SetColor(D3DCOLOR color)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color_ = color;
                color_.CopyFrom(color);
            }
            public void CloseVertex()
            {
                bCloseVertexList_ = true;

                position_ = D3DXVECTOR3(0.0f, 0.0f, 0.0f);
                angle_ = D3DXVECTOR3(0.0f, 0.0f, 0.0f);
                scale_ = D3DXVECTOR3(1.0f, 1.0f, 1.0f);
            }
    }

    /**********************************************************
    //Sprite3D
    //��`�X�v���C�g
    **********************************************************/
    public class Sprite3D : RenderObjectLX
    {
            protected bool bBillboard_;
            protected override D3DXMATRIX _CreateWorldTransformMaxtrix()
            {
                D3DXMATRIX mat = new D3DXMATRIX();
                D3DXMatrixIdentity(mat);
                bool bPos = position_.x != 0.0f || position_.y != 0.0f || position_.z != 0.0f;
                bool bAngle = angle_.x != 0.0f || angle_.y != 0.0f || angle_.z != 0.0f;
                bool bScale = scale_.x != 1.0f || scale_.y != 1.0f || scale_.z != 1.0f;
                if (bPos || bAngle || bScale || bBillboard_)
                {
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
                    if (bBillboard_)
                    {
                        DirectGraphics graph = DirectGraphics.GetBase();
                        IDirect3DDevice9 device = graph.GetDevice();
                        D3DXMATRIX matView = new D3DXMATRIX();
                        device.GetTransform(D3DTS_VIEW, matView);

                        D3DXMATRIX matInv = new D3DXMATRIX();
                        D3DXMatrixIdentity(matInv);
                        matInv._11 = matView._11;
                        matInv._12 = matView._21;
                        matInv._13 = matView._31;
                        matInv._21 = matView._12;
                        matInv._22 = matView._22;
                        matInv._23 = matView._32;
                        matInv._31 = matView._13;
                        matInv._32 = matView._23;
                        matInv._33 = matView._33;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matInv;
                        mat.CopyFrom(mat * matInv);
                    }
                    if (bPos)
                    {
                        D3DXMATRIX matTrans = new D3DXMATRIX();
                        D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matTrans;
                        mat.CopyFrom(mat * matTrans);
                    }
                }

                if (bBillboard_)
                {
                    D3DXMATRIX matRelative = new D3DXMATRIX();
                    D3DXMatrixIdentity(matRelative);
                    D3DXVECTOR3 pos = new D3DXVECTOR3();
                    D3DXVec3TransformCoord(pos, D3DXVECTOR3(0,0,0), matRelative_);
                    D3DXMatrixTranslation(matRelative, pos.x, pos.y, pos.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matRelative;
                    mat.CopyFrom(mat * matRelative);
                }
                else
                {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = mat * matRelative_;
                    mat.CopyFrom(mat * matRelative_);
                }
                return new D3DXMATRIX(mat);
            }


            /**********************************************************
            //Sprite3D
            **********************************************************/
            public Sprite3D()
            {
                SetVertexCount(4); // ����A�E��A�����A�E��
                SetPrimitiveType(D3DPT_TRIANGLESTRIP);
                bBillboard_ = false;
            }

            public new void Dispose()
            {
                base.Dispose();
            }

            public void SetSourceRect(RECT_D rcSrc)
            {
                ref_count_ptr<Texture> texture = texture_[0];
                if (texture == null)
                {
                    return;
                }
                int width = texture.GetWidth();
                int height = texture.GetHeight();

                // �e�N�X�`��UV
                SetVertexUV(0, (float)rcSrc.left / (float)width, (float)rcSrc.top / (float)height);
                SetVertexUV(1, (float)rcSrc.left / (float)width, (float)rcSrc.bottom / (float)height);
                SetVertexUV(2, (float)rcSrc.right / (float)width, (float)rcSrc.top / (float)height);
                SetVertexUV(3, (float)rcSrc.right / (float)width, (float)rcSrc.bottom / (float)height);
            }

            public void SetDestinationRect(RECT_D rcDest)
            {
                // ���_�ʒu
                SetVertexPosition(0, rcDest.left, rcDest.top, 0F);
                SetVertexPosition(1, rcDest.left, rcDest.bottom, 0F);
                SetVertexPosition(2, rcDest.right, rcDest.top, 0F);
                SetVertexPosition(3, rcDest.right, rcDest.bottom, 0F);
            }

            public void SetVertex(RECT_D rcSrc, RECT_D rcDest, D3DCOLOR color = D3DCOLOR_ARGB(255,255,255,255))
            {
                SetSourceRect(rcSrc);
                SetDestinationRect(rcDest);

                // ���_�F
                SetColorRGB(new D3DCOLOR(color));
                SetAlpha(ColorAccess.GetColorA(color));
            }

            public void SetSourceDestRect(RECT_D rcSrc)
            {
                int width = (int)rcSrc.right - rcSrc.left;
                int height = (int)rcSrc.bottom - rcSrc.top;
                RECT_D rcDest = new RECT_D();
                directx.GlobalMembers.SetRectD(rcDest, -width / 2.0, -height / 2.0, width / 2.0, height / 2.0);

                SetSourceRect(rcSrc);
                SetDestinationRect(rcDest);
            }

            public void SetVertex(RECT_D rcSrc, D3DCOLOR color = D3DCOLOR_ARGB(255,255,255,255))
            {
                SetSourceDestRect(rcSrc);

                // ���_�F
                SetColorRGB(new D3DCOLOR(color));
                SetAlpha(ColorAccess.GetColorA(color));
            }

            public void SetBillboardEnable(bool bEnable)
            {
                bBillboard_ = bEnable;
            }
    }

    /**********************************************************
    //TrajectoryObject3D
    //3D�O��
    **********************************************************/
    public class TrajectoryObject3D : RenderObjectLX
    {
        private class Data
        {
            public int alpha;
            public D3DXVECTOR3 pos1 = new D3DXVECTOR3();
            public D3DXVECTOR3 pos2 = new D3DXVECTOR3();
        }
            protected D3DCOLOR color_ = new D3DCOLOR();
            protected int diffAlpha_;
            protected int countComplement_;
            protected Data dataInit_ = new Data();
            protected Data dataLast1_ = new Data();
            protected Data dataLast2_ = new Data();
            protected LinkedList<Data> listData_ = new LinkedList<Data>();
            protected override D3DXMATRIX _CreateWorldTransformMaxtrix()
            {
                D3DXMATRIX mat = new D3DXMATRIX();
                D3DXMatrixIdentity(mat);
                return new D3DXMATRIX(mat);
            }


            /**********************************************************
            //TrajectoryObject3D
            **********************************************************/
            public TrajectoryObject3D()
            {
                SetPrimitiveType(D3DPT_TRIANGLESTRIP);
                diffAlpha_ = 20;
                countComplement_ = 8;
                color_ = D3DCOLOR_ARGB(255, 255, 255, 255);
            }

            public new void Dispose()
            {
                base.Dispose();
            }

            public virtual void Work()
            {
                LinkedList<Data>.Enumerator itr;
                for (itr = listData_.GetEnumerator(); itr.MoveNext();)
                {
                    Data data = itr.Current;
                    data.alpha -= diffAlpha_;
                    if (data.alpha < 0)
                    {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                        itr = listData_.erase(itr);
                    }
                    else
                    {
                    }
                }
            }

            public override void Render()
            {
                int size = listData_.Count * 2;
                SetVertexCount(size);

                int width = 1;
                gstd.ref_count_ptr<Texture> texture = texture_[0];
                if (texture != null)
                {
                    width = texture.GetWidth();
                }

                float dWidth = 1.0 / width / listData_.Count;
                int iData = 0;
                LinkedList<Data>.Enumerator itr;
                for (itr = listData_.GetEnumerator(); itr.MoveNext(); itr++, iData++)
                {
                    Data data = itr.Current;
                    int alpha = data.alpha;
                    for (int iPos = 0 ; iPos < 2 ; iPos++)
                    {
                        int index = iData * 2 + iPos;
                        D3DXVECTOR3 pos = iPos == 0 ? data.pos1 : data.pos2;
                        float u = dWidth * iData;
                        float v = iPos == 0 ? 0F : 1F;

                        SetVertexPosition(index, pos.x, pos.y, pos.z);
                        SetVertexUV(index, u, v);

                        float r = ColorAccess.GetColorR(new D3DCOLOR(color_)) * alpha / 255;
                        float g = ColorAccess.GetColorG(color_) * alpha / 255;
                        float b = ColorAccess.GetColorB(color_) * alpha / 255;
                        SetVertexColorARGB(index, alpha, (int)r, (int)g, (int)b);
                    }
                }
                base.Render();
            }

            public void SetInitialLine(D3DXVECTOR3 pos1, D3DXVECTOR3 pos2)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dataInit_.pos1 = pos1;
                dataInit_.pos1.CopyFrom(pos1);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dataInit_.pos2 = pos2;
                dataInit_.pos2.CopyFrom(pos2);
            }

            public void AddPoint(D3DXMATRIX mat)
            {
                Data data = new Data();
                data.alpha = 255;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: data.pos1 = dataInit_.pos1;
                data.pos1.CopyFrom(dataInit_.pos1);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: data.pos2 = dataInit_.pos2;
                data.pos2.CopyFrom(dataInit_.pos2);
                D3DXVec3TransformCoord((D3DXVECTOR3) data.pos1, (D3DXVECTOR3) data.pos1, mat);
                D3DXVec3TransformCoord((D3DXVECTOR3) data.pos2, (D3DXVECTOR3) data.pos2, mat);

                if (listData_.Count <= 1)
                {
                    listData_.AddLast(data);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dataLast2_ = dataLast1_;
                    dataLast2_.CopyFrom(dataLast1_);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dataLast1_ = data;
                    dataLast1_.CopyFrom(data);
                }
                else
                {
                    float cDiff = 1.0 / (countComplement_);
                    float diffAlpha = diffAlpha_ / countComplement_;
                    for (int iCount = 0 ; iCount < countComplement_ - 1 ; iCount++)
                    {
                        Data cData = new Data();
                        float flame = cDiff * (iCount + 1);
                        for (int iPos = 0 ; iPos < 2 ; iPos++)
                        {
                            D3DXVECTOR3 outPos = iPos == 0 ? cData.pos1 : cData.pos2;
                            D3DXVECTOR3 cPos = iPos == 0 ? data.pos1 : data.pos2;
                            D3DXVECTOR3 lPos1 = iPos == 0 ? dataLast1_.pos1 : dataLast1_.pos2;
                            D3DXVECTOR3 lPos2 = iPos == 0 ? dataLast2_.pos1 : dataLast2_.pos2;

                            D3DXVECTOR3 vPos1 = lPos1 - lPos2;
                            D3DXVECTOR3 vPos2 = lPos2 - cPos + vPos1;

            // 				D3DXVECTOR3 vPos1 = lPos2 - lPos1;
            // 				D3DXVECTOR3 vPos2 = lPos2 - cPos + vPos1;

                            // D3DXVECTOR3 vPos1 = lPos1 - lPos2;
                            // D3DXVECTOR3 vPos2 = cPos - lPos1;

                            D3DXVec3Hermite(outPos, lPos1, vPos1, cPos, vPos2, flame);
                        }

                        cData.alpha = (int)255 - diffAlpha * (countComplement_ - iCount - 1);
                        listData_.AddLast(cData);
                    }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dataLast2_ = dataLast1_;
                    dataLast2_.CopyFrom(dataLast1_);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: dataLast1_ = data;
                    dataLast1_.CopyFrom(data);
                }

            }

            public void SetAlphaVariation(int diff)
            {
                diffAlpha_ = diff;
            }
            public void SetComplementCount(int count)
            {
                countComplement_ = count;
            }
            public new void SetColor(D3DCOLOR color)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color_ = color;
                color_.CopyFrom(color);
            }
    }

    /**********************************************************
    //DxMesh
    **********************************************************/
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
    public enum AnonymousEnum11
    {
        MESH_ELFREINA,
        MESH_METASEQUOIA
    }
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxMeshManager;
    public abstract class DxMeshData : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend DxMeshManager;
            protected string name_ = "";
            protected DxMeshManager manager_;
// C++ TO C# CONVERTER TODO TASK: 'volatile' has a different meaning in C#:
// ORIGINAL LINE: volatile bool bLoad_;
            protected bool bLoad_;

            /**********************************************************
            //DxMesh
            **********************************************************/
            public DxMeshData()
            {
                manager_ = DxMeshManager.GetBase();
                bLoad_ = true;
            }

            public virtual void Dispose()
            {
            }

            public void SetName(string name)
            {
                name_ = name;
            }
            public string GetName()
            {
                return name_;
            }
            public abstract bool CreateFromFileReader(gstd.ref_count_ptr<gstd.FileReader> reader);
    }
    public abstract class DxMesh : gstd.FileManager.LoadObject, System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend DxMeshManager;
            protected D3DXVECTOR3 position_ = new D3DXVECTOR3(); // �ړ�����W
            protected D3DXVECTOR3 angle_ = new D3DXVECTOR3(); // ��]�p�x
            protected D3DXVECTOR3 scale_ = new D3DXVECTOR3(); // �g�嗦
            protected D3DCOLOR color_ = new D3DCOLOR();
            protected bool bCoordinate2D_; // 2D���W�w��
            protected gstd.ref_count_ptr<Shader> shader_ = new gstd.ref_count_ptr<Shader>();

            protected gstd.ref_count_ptr<DxMeshData> data_ = new gstd.ref_count_ptr<DxMeshData>();
            protected gstd.ref_count_ptr<DxMeshData> _GetFromManager(string name)
            {
                return DxMeshManager.GetBase()._GetMeshData(name);
            }

            protected void _AddManager(string name, gstd.ref_count_ptr<DxMeshData> data)
            {
                DxMeshManager.GetBase()._AddMeshData(name, data);
            }

            public DxMesh()
            {
                position_ = D3DXVECTOR3(0.0f, 0.0f, 0.0f);
                angle_ = D3DXVECTOR3(0.0f, 0.0f, 0.0f);
                scale_ = D3DXVECTOR3(1.0f, 1.0f, 1.0f);
                color_ = D3DCOLOR_ARGB(255, 255, 255, 255);
                bCoordinate2D_ = false;
            }

            public virtual void Dispose()
            {
                Release();
            }

            public virtual void Release()
            {
                {
                    DxMeshManager manager = DxMeshManager.GetBase();
                    Lock @lock = new Lock(manager.GetLock());
                    if (data_ != null)
                    {
                        if (manager.IsDataExists(data_.GetName()))
                        {
                            int countRef = data_.GetReferenceCount();
                            // ���g��DxMeshManager��̐������ɂȂ�����폜
                            if (countRef == 2)
                            {
                                manager._ReleaseMeshData(data_.GetName());
                            }
                        }
                        data_ = null;
                    }
                }
            }

            public bool CreateFromFile(string path)
            {
                try
                {
                    path = PathProperty.GetUnique(path);
                    ref_count_ptr<FileReader> reader = FileManager.GetBase().GetFileReader(path);
                    if (reader == null)
                    {
                        throw new gstd.wexception("�t�@�C����������܂���");
                    }
                    return CreateFromFileReader(new ref_count_ptr<FileReader>(reader));
                }
                catch (gstd.wexception e)
                {
                    string str = StringUtility.Format("DxMesh�F���b�V���ǂݍ��ݎ��s[%s]\n\t%s", path, e.what());
                    Logger.WriteTop(str);
                }
                return false;
            }

            public abstract bool CreateFromFileReader(gstd.ref_count_ptr<gstd.FileReader> reader);
            public virtual bool CreateFromFileInLoadThread(string path, int type)
            {
                bool res = false;
                {
                    Lock @lock = new Lock(DxMeshManager.GetBase().GetLock());
                    if (data_ != null)
                    {
                        Release();
                    }
                    DxMeshManager manager = DxMeshManager.GetBase();
                    ref_count_ptr<DxMesh> mesh = manager.CreateFromFileInLoadThread(path, type);
                    if (mesh != null)
                    {
                        data_ = mesh.data_;
                    }
                    res = data_ != null;
                }

                return res;
            }

            public abstract bool CreateFromFileInLoadThread(string path);
            public abstract string GetPath();

            public abstract void Render();
            public virtual void Render(string nameAnime, int time)
            {
                Render();
            }
            public void SetPosition(D3DXVECTOR3 pos)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: position_ = pos;
                position_.CopyFrom(pos);
            }
            public void SetPosition(float x, float y, float z)
            {
                position_.x = x;
                position_.y = y;
                position_.z = z;
            }
            public void SetX(float x)
            {
                position_.x = x;
            }
            public void SetY(float y)
            {
                position_.y = y;
            }
            public void SetZ(float z)
            {
                position_.z = z;
            }
            public void SetAngle(D3DXVECTOR3 angle)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: angle_ = angle;
                angle_.CopyFrom(angle);
            }
            public void SetAngleXYZ(float angx = 0.0f, float angy = 0.0f, float angz = 0.0f)
            {
                angle_.x = angx;
                angle_.y = angy;
                angle_.z = angz;
            }
            public void SetScale(D3DXVECTOR3 scale)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: scale_ = scale;
                scale_.CopyFrom(scale);
            }
            public void SetScaleXYZ(float sx = 1.0f, float sy = 1.0f, float sz = 1.0f)
            {
                scale_.x = sx;
                scale_.y = sy;
                scale_.z = sz;
            }

            public void SetColor(D3DCOLOR color)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color_ = color;
                color_.CopyFrom(color);
            }
            public void SetColorRGB(D3DCOLOR color)
            {
                int r = ColorAccess.GetColorR(new D3DCOLOR(color));
                int g = ColorAccess.GetColorG(color);
                int b = ColorAccess.GetColorB(color);
                ColorAccess.SetColorR(color_, r);
                ColorAccess.SetColorG(color_, g);
                ColorAccess.SetColorB(color_, b);
            }

            public void SetAlpha(int alpha)
            {
                ColorAccess.SetColorA(color_, alpha);
            }

            public bool IsCoordinate2D()
            {
                return bCoordinate2D_;
            }
            public void SetCoordinate2D(bool b)
            {
                bCoordinate2D_ = b;
            }

            public gstd.ref_count_ptr<RenderBlocks> CreateRenderBlocks()
            {
                return null;
            }
            public virtual D3DXMATRIX GetAnimationMatrix(string nameAnime, double time, string nameBone)
            {
                D3DXMATRIX mat = new D3DXMATRIX();
                D3DXMatrixIdentity(mat);
                return new D3DXMATRIX(mat);
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
    //DxMeshManager
    **********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxMeshInfoPanel;
    public class DxMeshManager : gstd.FileManager.LoadThreadListener, System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxMeshData;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxMesh;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxMeshInfoPanel;
        private static DxMeshManager thisBase_ = null;
            protected gstd.CriticalSection lock_ = new gstd.CriticalSection();
            protected SortedDictionary<string, gstd.ref_count_ptr<DxMesh>> mapMesh_ = new SortedDictionary<string, gstd.ref_count_ptr<DxMesh>>();
            protected SortedDictionary<string, gstd.ref_count_ptr<DxMeshData>> mapMeshData_ = new SortedDictionary<string, gstd.ref_count_ptr<DxMeshData>>();
            protected gstd.ref_count_ptr<DxMeshInfoPanel> panelInfo_ = new gstd.ref_count_ptr<DxMeshInfoPanel>();

            protected void _AddMeshData(string name, gstd.ref_count_ptr<DxMeshData> data)
            {
                {
                    Lock @lock = new Lock(lock_);
                    if (!IsDataExists(name))
                    {
                        mapMeshData_[name].CopyFrom(data);
                    }
                }
            }

            protected gstd.ref_count_ptr<DxMeshData> _GetMeshData(string name)
            {
                gstd.ref_count_ptr<DxMeshData> res = null;
                {
                    Lock @lock = new Lock(lock_);
                    if (IsDataExists(name))
                    {
                        res.CopyFrom(mapMeshData_[name]);
                    }
                }
                return new gstd.ref_count_ptr<DxMeshData>(res);
            }

            protected void _ReleaseMeshData(string name)
            {
                {
                    Lock @lock = new Lock(lock_);
                    if (IsDataExists(name))
                    {
                        mapMeshData_.Remove(name);
                        Logger.WriteTop(StringUtility.Format("DxMeshManager�F���b�V���������܂���[%s]", name));
                    }
                }
            }

            /**********************************************************
            //DxMeshManager
            **********************************************************/
            public DxMeshManager()
            {
            }

            public virtual void Dispose()
            {
                this.Clear();
                FileManager.GetBase().RemoveLoadThreadListener(this);
                panelInfo_ = null;
                thisBase_ = null;
            }

            public static DxMeshManager GetBase()
            {
                return thisBase_;
            }
            public bool Initialize()
            {
                thisBase_ = this;
                FileManager.GetBase().AddLoadThreadListener(this);
                return true;
            }

            public gstd.CriticalSection GetLock()
            {
                return new gstd.CriticalSection(lock_);
            }

            public virtual void Clear()
            {
                {
                    Lock @lock = new Lock(lock_);
                    mapMesh_.Clear();
                    mapMeshData_.Clear();
                }
            }

            public virtual void Add(string name, gstd.ref_count_ptr<DxMesh> mesh)
            {
                {
                    Lock @lock = new Lock(lock_);
                    bool bExist = mapMesh_.ContainsKey(name);
                    if (!bExist)
                    {
                        mapMesh_[name].CopyFrom(mesh);
                    }
                }
            }

            public virtual void Release(string name)
            {
                {
                    Lock @lock = new Lock(lock_);
                    mapMesh_.Remove(name);
                }
            }

            public virtual bool IsDataExists(string name)
            {
                bool res = false;
                {
                    Lock @lock = new Lock(lock_);
                    res = mapMeshData_.ContainsKey(name);
                }
                return res;
            }

            public gstd.ref_count_ptr<DxMesh> CreateFromFileInLoadThread(string path, int type)
            {
                gstd.ref_count_ptr<DxMesh> res = new gstd.ref_count_ptr<DxMesh>();
                {
                    Lock @lock = new Lock(lock_);
                    bool bExist = mapMesh_.ContainsKey(path);
                    if (bExist)
                    {
                        res.CopyFrom(mapMesh_[path]);
                    }
                    else
                    {
                        if (type == (int)AnonymousEnum11.MESH_ELFREINA)
                        {
                            res = new ElfreinaMesh();
                        }
                        else if (type == (int)AnonymousEnum11.MESH_METASEQUOIA)
                        {
                            res = new MetasequoiaMesh();
                        }
                        if (!IsDataExists(path))
                        {
                            ref_count_ptr<DxMeshData> data = null;
                            if (type == (int)AnonymousEnum11.MESH_ELFREINA)
                            {
                                data = new ElfreinaMeshData();
                            }
                            else if (type == (int)AnonymousEnum11.MESH_METASEQUOIA)
                            {
                                data = new MetasequoiaMeshData();
                            }
                            mapMeshData_[path] = data;
                            data.manager_ = this;
                            data.name_ = path;
                            data.bLoad_ = false;

                            ref_count_ptr<FileManager.LoadObject> source = new ref_count_ptr<FileManager.LoadObject>(res);
                            ref_count_ptr<FileManager.LoadThreadEvent> @event = new FileManager.LoadThreadEvent(this, path, res);
                            FileManager.GetBase().AddLoadThreadEvent(@event);
                        }

                        res.data_ = mapMeshData_[path];
                    }
                }
                return new gstd.ref_count_ptr<DxMesh>(res);
            }

            public virtual void CallFromLoadThread(ref_count_ptr<FileManager.LoadThreadEvent> @event)
            {
                string path = @event.GetPath();
                {
                    Lock @lock = new Lock(lock_);
                    ref_count_ptr<DxMesh> mesh = new ref_count_ptr<DxMesh>(@event.GetSource());
                    if (mesh == null)
                    {
                        return;
                    }

                    ref_count_ptr<DxMeshData> data = mesh.data_;
                    if (data.bLoad_)
                    {
                        return;
                    }

                    bool res = false;
                    ref_count_ptr<FileReader> reader = FileManager.GetBase().GetFileReader(path);
                    if (reader != null && reader.Open())
                    {
                        res = data.CreateFromFileReader(reader);
                    }
                    if (res)
                    {
                        Logger.WriteTop(StringUtility.Format("���b�V����ǂݍ��݂܂���[%s]", path));
                    }
                    else
                    {
                        Logger.WriteTop(StringUtility.Format("���b�V����ǂݍ��ݎ��s[%s]", path));
                    }
                    data.bLoad_ = true;
                }
            }

            public void SetInfoPanel(gstd.ref_count_ptr<DxMeshInfoPanel> panel)
            {
                panelInfo_.CopyFrom(panel);
            }
    }

// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
    public class DxMeshInfoPanel : gstd.WindowLogger.Panel, gstd.Thread, System.IDisposable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            protected enum AnonymousEnum12
            {
                    ROW_ADDRESS,
                    ROW_NAME,
                    ROW_FULLNAME,
                    ROW_COUNT_REFFRENCE
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

                wndListView_.AddColumn(64, (int)AnonymousEnum12.ROW_ADDRESS, "Address");
                wndListView_.AddColumn(96, (int)AnonymousEnum12.ROW_NAME, "Name");
                wndListView_.AddColumn(48, (int)AnonymousEnum12.ROW_FULLNAME, "FullName");
                wndListView_.AddColumn(32, (int)AnonymousEnum12.ROW_COUNT_REFFRENCE, "Ref");

                Start();

                return true;
            }

            protected void _Run()
            {
                while (GetStatus() == RUN)
                {
                    DxMeshManager manager = DxMeshManager.GetBase();
                    if (manager != null)
                    {
                        Update(manager);
                    }
                    Sleep(timeUpdateInterval_);
                }
            }


            // DxMeshInfoPanel
            public DxMeshInfoPanel()
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

            public virtual void Update(DxMeshManager manager)
            {
                if (!IsWindowVisible())
                {
                    return;
                }
                SortedSet<string> setKey = new SortedSet<string>();
                SortedDictionary<string, gstd.ref_count_ptr<DxMeshData>> mapData = manager.mapMeshData_;
                SortedDictionary<string, gstd.ref_count_ptr<DxMeshData>>.Enumerator itrMap;
                {
                    Lock @lock = new Lock(manager.GetLock());
                    for (itrMap = mapData.GetEnumerator(); itrMap.MoveNext();)
                    {
                        string name = itrMap.Current.Key;
                        DxMeshData data = (itrMap.Current.Value).GetPointer();

                        int address = (int)data;
                        string key = StringUtility.Format("%08x", address);
                        int index = wndListView_.GetIndexInColumn(key, (int)AnonymousEnum12.ROW_ADDRESS);
                        if (index == -1)
                        {
                            index = wndListView_.GetRowCount();
                            wndListView_.SetText(index, (int)AnonymousEnum12.ROW_ADDRESS, key);
                        }

                        int countRef = (itrMap.Current.Value).GetReferenceCount();

                        wndListView_.SetText(index, (int)AnonymousEnum12.ROW_NAME, PathProperty.GetFileName(name));
                        wndListView_.SetText(index, (int)AnonymousEnum12.ROW_FULLNAME, name);
                        wndListView_.SetText(index, (int)AnonymousEnum12.ROW_COUNT_REFFRENCE, StringUtility.Format("%d", countRef));

                        setKey.Add(key);
                    }
                }

                for (int iRow = 0; iRow < wndListView_.GetRowCount();)
                {
                    string key = wndListView_.GetText(iRow, (int)AnonymousEnum12.ROW_ADDRESS);
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
