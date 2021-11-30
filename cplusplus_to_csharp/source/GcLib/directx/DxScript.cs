using gstd;
using directx;
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
//    class DxScript;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxScriptObjectManager;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxScriptObjectBase;
    /**********************************************************
    //DxScriptRenderObject
    **********************************************************/
    public abstract class DxScriptRenderObject : DxScriptObjectBase
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxScript;
            protected bool bZWrite_;
            protected bool bZTest_;
            protected bool bFogEnable_;
            protected int modeCulling_;

            protected D3DXVECTOR3 position_ = new D3DXVECTOR3(); // �ړ�����W
            protected D3DXVECTOR3 angle_ = new D3DXVECTOR3(); // ��]�p�x
            protected D3DXVECTOR3 scale_ = new D3DXVECTOR3(); // �g�嗦
            protected int typeBlend_;

            protected int idRelative_;
            protected string nameRelativeBone_ = "";

            /**********************************************************
            //DxScriptRenderObject
            **********************************************************/
            public DxScriptRenderObject()
            {
                bZWrite_ = false;
                bZTest_ = false;
                bFogEnable_ = false;
                typeBlend_ = DirectGraphics.MODE_BLEND_ALPHA;
                modeCulling_ = D3DCULL_NONE;
                position_ = D3DXVECTOR3(0.0f, 0.0f, 0.0f);
                angle_ = D3DXVECTOR3(0.0f, 0.0f, 0.0f);
                scale_ = D3DXVECTOR3(1.0f, 1.0f, 1.0f);
            }

            public virtual void SetX(double x)
            {
                position_.x = x;
            }
            public virtual void SetY(double y)
            {
                position_.y = y;
            }
            public virtual void SetZ(double z)
            {
                position_.z = z;
            }
            public virtual void SetAngleX(double x)
            {
                angle_.x = x;
            }
            public virtual void SetAngleY(double y)
            {
                angle_.y = y;
            }
            public virtual void SetAngleZ(double z)
            {
                angle_.z = z;
            }
            public virtual void SetScaleX(double x)
            {
                scale_.x = x;
            }
            public virtual void SetScaleY(double y)
            {
                scale_.y = y;
            }
            public virtual void SetScaleZ(double z)
            {
                scale_.z = z;
            }
            public abstract void SetColor(int r, int g, int b);
            public abstract void SetAlpha(int alpha);

            public D3DXVECTOR3 GetPosition()
            {
                return new D3DXVECTOR3(position_);
            }
            public D3DXVECTOR3 GetAngle()
            {
                return new D3DXVECTOR3(angle_);
            }
            public D3DXVECTOR3 GetScale()
            {
                return new D3DXVECTOR3(scale_);
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

            public int GetBlendType()
            {
                return typeBlend_;
            }
            public void SetRelativeObject(int id, string bone)
            {
                idRelative_ = id;
                nameRelativeBone_ = bone;
            }

            public virtual gstd.ref_count_ptr<Shader> GetShader()
            {
                return null;
            }
            public virtual void SetShader(gstd.ref_count_ptr<Shader> shader)
            {
            }
            public override void Render()
            {
            }
            public override void SetRenderState()
            {
            }
    }

    /**********************************************************
    //DxScriptShaderObject
    **********************************************************/
    public class DxScriptShaderObject : DxScriptRenderObject
    {
            private gstd.ref_count_ptr<Shader> shader_ = new gstd.ref_count_ptr<Shader>();


            /**********************************************************
            //DxScriptShaderObject
            **********************************************************/
            public DxScriptShaderObject()
            {
                typeObject_ = DxScript.OBJ_SHADER;
            }

            public override gstd.ref_count_ptr<Shader> GetShader()
            {
                return new gstd.ref_count_ptr<Shader>(shader_);
            }
            public override void SetShader(gstd.ref_count_ptr<Shader> shader)
            {
                shader_.CopyFrom(shader);
            }

            public override void SetColor(int r, int g, int b)
            {
            }
            public override void SetAlpha(int alpha)
            {
            }
    }

    /**********************************************************
    //DxScriptPrimitiveObject
    **********************************************************/
    public abstract class DxScriptPrimitiveObject : DxScriptRenderObject
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxScript;
            protected gstd.ref_count_ptr<RenderObject> objRender_ = new gstd.ref_count_ptr<RenderObject>();


            /**********************************************************
            //DxScriptPrimitiveObject
            **********************************************************/
            public DxScriptPrimitiveObject()
            {
                idRelative_ = -1;
            }

            public void SetPrimitiveType(D3DPRIMITIVETYPE type)
            {
                objRender_.SetPrimitiveType(type);
            }

            public void SetVertexCount(int count)
            {
                objRender_.SetVertexCount(count);
            }

            public int GetVertexCount()
            {
                return objRender_.GetVertexCount();
            }

            public gstd.ref_count_ptr<Texture> GetTexture()
            {
                return objRender_.GetTexture();
            }

            public virtual void SetTexture(gstd.ref_count_ptr<Texture> texture)
            {
                objRender_.SetTexture(texture);
            }

            public abstract bool IsValidVertexIndex(int index);
            public abstract void SetVertexPosition(int index, float x, float y, float z);
            public abstract void SetVertexUV(int index, float u, float v);
            public abstract void SetVertexAlpha(int index, int alpha);
            public abstract void SetVertexColor(int index, int r, int g, int b);
            public abstract D3DXVECTOR3 GetVertexPosition(int index);

            public override gstd.ref_count_ptr<Shader> GetShader()
            {
                return objRender_.GetShader();
            }

            public override void SetShader(gstd.ref_count_ptr<Shader> shader)
            {
                objRender_.SetShader(shader);
            }
    }

    /**********************************************************
    //DxScriptPrimitiveObject2D
    **********************************************************/
    public class DxScriptPrimitiveObject2D : DxScriptPrimitiveObject
    {

            /**********************************************************
            //DxScriptPrimitiveObject2D
            **********************************************************/
            public DxScriptPrimitiveObject2D()
            {
                typeObject_ = DxScript.OBJ_PRIMITIVE_2D;

                objRender_ = new RenderObjectTLX();
                bZWrite_ = false;
                bZTest_ = false;
            }

            public override void Render()
            {
                RenderObjectTLX obj = GetObjectPointer();

                // �t�H�O��������
                DirectGraphics graphics = DirectGraphics.GetBase();
                uint bEnableFog = false;
                graphics.GetDevice().GetRenderState(D3DRS_FOGENABLE, bEnableFog);
                if (bEnableFog != 0)
                {
                    graphics.SetFogEnable(false);
                }

                SetRenderState();
                obj.Render();

                if (bEnableFog != 0)
                {
                    graphics.SetFogEnable(true);
                }
            }

            public override void SetRenderState()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                RenderObjectTLX obj = GetObjectPointer();
                obj.SetPosition(position_);
                obj.SetAngle(angle_);
                obj.SetScale(scale_);
                graphics.SetLightingEnable(false);
                graphics.SetZWriteEnalbe(false);
                graphics.SetZBufferEnable(false);
                graphics.SetBlendMode((uint)typeBlend_);
                graphics.SetCullingMode(D3DCULL_NONE);
            }

            public RenderObjectTLX GetObjectPointer()
            {
                return (RenderObjectTLX)objRender_.GetPointer();
            }
            public override bool IsValidVertexIndex(int index)
            {
                RenderObjectTLX obj = GetObjectPointer();
                int count = obj.GetVertexCount();
                return index >= 0 && index < count;
            }

            public override void SetColor(int r, int g, int b)
            {
                RenderObjectTLX obj = GetObjectPointer();

                int count = obj.GetVertexCount();
                for (int iVert = 0 ; iVert < count ; iVert++)
                {
                    VERTEX_TLX vert = obj.GetVertex(iVert);
                    D3DCOLOR color = vert.diffuse_color;
                    color = ColorAccess.SetColorR(color, r);
                    color = ColorAccess.SetColorG(color, g);
                    color = ColorAccess.SetColorB(color, b);
                }
            }

            public override void SetAlpha(int alpha)
            {
                RenderObjectTLX obj = GetObjectPointer();

                int count = obj.GetVertexCount();
                for (int iVert = 0 ; iVert < count ; iVert++)
                {
                    VERTEX_TLX vert = obj.GetVertex(iVert);
                    D3DCOLOR color = vert.diffuse_color;
                    color = ColorAccess.SetColorA(color, alpha);
                }
            }

            public override void SetVertexPosition(int index, float x, float y, float z)
            {
                if (!IsValidVertexIndex(index))
                {
                    return;
                }
                RenderObjectTLX obj = GetObjectPointer();
                obj.SetVertexPosition(index, x, y, z);
            }

            public override void SetVertexUV(int index, float u, float v)
            {
                if (!IsValidVertexIndex(index))
                {
                    return;
                }
                RenderObjectTLX obj = GetObjectPointer();
                obj.SetVertexUV(index, u, v);
            }

            public override void SetVertexAlpha(int index, int alpha)
            {
                if (!IsValidVertexIndex(index))
                {
                    return;
                }
                RenderObjectTLX obj = GetObjectPointer();
                VERTEX_TLX vert = obj.GetVertex(index);
                D3DCOLOR color = vert.diffuse_color;
                color = ColorAccess.SetColorA(color, alpha);
            }

            public override void SetVertexColor(int index, int r, int g, int b)
            {
                if (!IsValidVertexIndex(index))
                {
                    return;
                }
                RenderObjectTLX obj = GetObjectPointer();
                VERTEX_TLX vert = obj.GetVertex(index);
                D3DCOLOR color = vert.diffuse_color;
                color = ColorAccess.SetColorR(color, r);
                color = ColorAccess.SetColorG(color, g);
                color = ColorAccess.SetColorB(color, b);
            }

            public void SetPermitCamera(bool bPermit)
            {
                RenderObjectTLX obj = GetObjectPointer();
                obj.SetPermitCamera(bPermit);
            }

            public override D3DXVECTOR3 GetVertexPosition(int index)
            {
                D3DXVECTOR3 res = new D3DXVECTOR3(0, 0, 0);
                if (!IsValidVertexIndex(index))
                {
                    return new D3DXVECTOR3(res);
                }
                RenderObjectTLX obj = GetObjectPointer();
                VERTEX_TLX vert = obj.GetVertex(index);

                float bias = 0.5f;
                res.x = vert.position.x + bias;
                res.y = vert.position.y + bias;
                res.z = 0;

                return new D3DXVECTOR3(res);
            }
    }

    /**********************************************************
    //DxScriptSpriteObject2D
    **********************************************************/
    public class DxScriptSpriteObject2D : DxScriptPrimitiveObject2D
    {

            /**********************************************************
            //DxScriptSpriteObject2D
            **********************************************************/
            public DxScriptSpriteObject2D()
            {
                typeObject_ = DxScript.OBJ_SPRITE_2D;
                objRender_ = new Sprite2D();
            }

            public void Copy(DxScriptSpriteObject2D src)
            {
                priRender_ = src.priRender_;
                bZWrite_ = src.bZWrite_;
                bZTest_ = src.bZTest_;
                modeCulling_ = src.modeCulling_;
                bVisible_ = src.bVisible_;
                manager_ = src.manager_;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: position_ = src->position_;
                position_.CopyFrom(src.position_);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: angle_ = src->angle_;
                angle_.CopyFrom(src.angle_);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: scale_ = src->scale_;
                scale_.CopyFrom(src.scale_);
                typeBlend_ = src.typeBlend_;

                Sprite2D destSprite2D = (Sprite2D)objRender_.GetPointer();
                Sprite2D srcSprite2D = (Sprite2D)src.objRender_.GetPointer();
                destSprite2D.Copy(srcSprite2D);
            }

            public Sprite2D GetSpritePointer()
            {
                return (Sprite2D)objRender_.GetPointer();
            }
    }

    /**********************************************************
    //DxScriptSpriteListObject2D
    **********************************************************/
    public class DxScriptSpriteListObject2D : DxScriptPrimitiveObject2D
    {

            /**********************************************************
            //DxScriptSpriteListObject2D
            **********************************************************/
            public DxScriptSpriteListObject2D()
            {
                typeObject_ = DxScript.OBJ_SPRITE_LIST_2D;
                objRender_ = new SpriteList2D();
            }

            public override void SetColor(int r, int g, int b)
            {
                D3DCOLOR color = GetSpritePointer().GetColor();
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = ColorAccess::SetColorR(color, r);
                color.CopyFrom(ColorAccess.SetColorR(color, r));
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = ColorAccess::SetColorG(color, g);
                color.CopyFrom(ColorAccess.SetColorG(color, g));
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = ColorAccess::SetColorB(color, b);
                color.CopyFrom(ColorAccess.SetColorB(color, b));
                GetSpritePointer().SetColor(new D3DCOLOR(color));
            }

            public override void SetAlpha(int alpha)
            {
                D3DCOLOR color = GetSpritePointer().GetColor();
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = ColorAccess::SetColorA(color, alpha);
                color.CopyFrom(ColorAccess.SetColorA(color, alpha));
                GetSpritePointer().SetColor(new D3DCOLOR(color));
            }

            public void AddVertex()
            {
                SpriteList2D obj = GetSpritePointer();
                obj.SetPosition(position_);
                obj.SetAngle(angle_);
                obj.SetScale(scale_);
                obj.AddVertex();
            }

            public void CloseVertex()
            {
                SpriteList2D obj = GetSpritePointer();
                obj.CloseVertex();

                position_ = D3DXVECTOR3(0.0f, 0.0f, 0.0f);
                angle_ = D3DXVECTOR3(0.0f, 0.0f, 0.0f);
                scale_ = D3DXVECTOR3(1.0f, 1.0f, 1.0f);
            }

            public SpriteList2D GetSpritePointer()
            {
                return (SpriteList2D)objRender_.GetPointer();
            }
    }

    /**********************************************************
    //DxScriptPrimitiveObject3D
    **********************************************************/
    public class DxScriptPrimitiveObject3D : DxScriptPrimitiveObject
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend DxScript;

            /**********************************************************
            //DxScriptPrimitiveObject3D
            **********************************************************/
            public DxScriptPrimitiveObject3D()
            {
                typeObject_ = DxScript.OBJ_PRIMITIVE_3D;
                objRender_ = new RenderObjectLX();
                bZWrite_ = false;
                bZTest_ = true;
                bFogEnable_ = true;
            }

            public override void Render()
            {
                RenderObjectLX obj = GetObjectPointer();
                DirectGraphics graphics = DirectGraphics.GetBase();
                bool bEnvFogEnable = graphics.IsFogEnable();
                SetRenderState();
                obj.Render();

                // �t�H�O�̏�Ԃ���Z�b�g
                if (bEnvFogEnable)
                {
                    graphics.SetFogEnable(true);
                }
            }

            public override void SetRenderState()
            {
                if (idRelative_ >= 0)
                {
                    ref_count_ptr<DxScriptObjectBase>.unsync objRelative = manager_.GetObject(idRelative_);
                    if (objRelative != null)
                    {
                        objRelative.SetRenderState();
                        DxScriptMeshObject objMesh = objRelative.GetPointer() as DxScriptMeshObject;
                        if (objMesh != null)
                        {
                            int frameAnime = objMesh.GetAnimeFrame();
                            string nameAnime = objMesh.GetAnimeName();
                            ref_count_ptr<DxMesh> mesh = objMesh.GetMesh();
                            D3DXMATRIX mat = mesh.GetAnimationMatrix(nameAnime, frameAnime, nameRelativeBone_);
                            objRender_.SetRalativeMatrix(mat);
                        }
                    }
                }

                DirectGraphics graphics = DirectGraphics.GetBase();
                bool bEnvFogEnable = graphics.IsFogEnable();

                RenderObjectLX obj = GetObjectPointer();
                obj.SetPosition(position_);
                obj.SetAngle(angle_);
                obj.SetScale(scale_);
                graphics.SetLightingEnable(false);
                graphics.SetZWriteEnalbe(bZWrite_);
                graphics.SetZBufferEnable(bZTest_);
                if (bEnvFogEnable)
                {
                    graphics.SetFogEnable(bFogEnable_);
                }
                graphics.SetBlendMode((uint)typeBlend_);
                graphics.SetCullingMode((uint)modeCulling_);

            }

            public RenderObjectLX GetObjectPointer()
            {
                return (RenderObjectLX)objRender_.GetPointer();
            }
            public override bool IsValidVertexIndex(int index)
            {
                RenderObjectLX obj = GetObjectPointer();
                int count = obj.GetVertexCount();
                return index >= 0 && index < count;
            }

            public override void SetColor(int r, int g, int b)
            {
                RenderObjectLX obj = GetObjectPointer();

                int count = obj.GetVertexCount();
                for (int iVert = 0 ; iVert < count ; iVert++)
                {
                    VERTEX_LX vert = obj.GetVertex(iVert);
                    D3DCOLOR color = vert.diffuse_color;
                    color = ColorAccess.SetColorR(color, r);
                    color = ColorAccess.SetColorG(color, g);
                    color = ColorAccess.SetColorB(color, b);
                }
            }

            public override void SetAlpha(int alpha)
            {
                RenderObjectLX obj = GetObjectPointer();

                int count = obj.GetVertexCount();
                for (int iVert = 0 ; iVert < count ; iVert++)
                {
                    VERTEX_LX vert = obj.GetVertex(iVert);
                    D3DCOLOR color = vert.diffuse_color;
                    color = ColorAccess.SetColorA(color, alpha);
                }
            }

            public override void SetVertexPosition(int index, float x, float y, float z)
            {
                if (!IsValidVertexIndex(index))
                {
                    return;
                }
                RenderObjectLX obj = GetObjectPointer();
                VERTEX_LX vert = obj.GetVertex(index);
                vert.position.x = x;
                vert.position.y = y;
                vert.position.z = z;
            }

            public override void SetVertexUV(int index, float u, float v)
            {
                if (!IsValidVertexIndex(index))
                {
                    return;
                }
                RenderObjectLX obj = GetObjectPointer();

                VERTEX_LX vert = obj.GetVertex(index);
                vert.texcoord.x = u;
                vert.texcoord.y = v;
            }

            public override void SetVertexAlpha(int index, int alpha)
            {
                if (!IsValidVertexIndex(index))
                {
                    return;
                }
                RenderObjectLX obj = GetObjectPointer();
                VERTEX_LX vert = obj.GetVertex(index);
                D3DCOLOR color = vert.diffuse_color;
                color = ColorAccess.SetColorA(color, alpha);
            }

            public override void SetVertexColor(int index, int r, int g, int b)
            {
                if (!IsValidVertexIndex(index))
                {
                    return;
                }
                RenderObjectLX obj = GetObjectPointer();
                VERTEX_LX vert = obj.GetVertex(index);
                D3DCOLOR color = vert.diffuse_color;
                color = ColorAccess.SetColorR(color, r);
                color = ColorAccess.SetColorG(color, g);
                color = ColorAccess.SetColorB(color, b);
            }

            public override D3DXVECTOR3 GetVertexPosition(int index)
            {
                D3DXVECTOR3 res = new D3DXVECTOR3(0, 0, 0);
                if (!IsValidVertexIndex(index))
                {
                    return new D3DXVECTOR3(res);
                }
                RenderObjectLX obj = GetObjectPointer();
                VERTEX_LX vert = obj.GetVertex(index);

                res.x = vert.position.x;
                res.y = vert.position.y;
                res.z = vert.position.z;

                return new D3DXVECTOR3(res);
            }
    }
    /**********************************************************
    //DxScriptSpriteObject3D
    **********************************************************/
    public class DxScriptSpriteObject3D : DxScriptPrimitiveObject3D
    {
            /**********************************************************
            //DxScriptSpriteObject3D
            **********************************************************/
            public DxScriptSpriteObject3D()
            {
                typeObject_ = DxScript.OBJ_SPRITE_3D;
                objRender_ = new Sprite3D();
            }

            public Sprite3D GetSpritePointer()
            {
                return (Sprite3D)objRender_.GetPointer();
            }
    }

    /**********************************************************
    //DxScriptTrajectoryObject3D
    **********************************************************/
    public class DxScriptTrajectoryObject3D : DxScriptPrimitiveObject
    {
            /**********************************************************
            //DxScriptTrajectoryObject3D
            **********************************************************/
            public DxScriptTrajectoryObject3D()
            {
                typeObject_ = DxScript.OBJ_TRAJECTORY_3D;
                objRender_ = new TrajectoryObject3D();
            }

            public override void Work()
            {
                if (idRelative_ >= 0)
                {
                    ref_count_ptr<DxScriptObjectBase>.unsync objRelative = manager_.GetObject(idRelative_);
                    if (objRelative != null)
                    {
                        objRelative.SetRenderState();
                        DxScriptMeshObject objMesh = objRelative.GetPointer() as DxScriptMeshObject;
                        if (objMesh != null)
                        {
                            int frameAnime = objMesh.GetAnimeFrame();
                            string nameAnime = objMesh.GetAnimeName();
                            ref_count_ptr<DxMesh> mesh = objMesh.GetMesh();
                            D3DXMATRIX matAnime = mesh.GetAnimationMatrix(nameAnime, frameAnime, nameRelativeBone_);

                            TrajectoryObject3D objRender = GetObjectPointer();
                            objRender.AddPoint(new D3DXMATRIX(matAnime));
                        }
                    }
                }

                TrajectoryObject3D obj = GetObjectPointer();
                obj.Work();
            }

            public override void Render()
            {
                TrajectoryObject3D obj = GetObjectPointer();
                SetRenderState();
                obj.Render();
            }

            public override void SetRenderState()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                TrajectoryObject3D obj = GetObjectPointer();
                graphics.SetLightingEnable(false);
                graphics.SetZWriteEnalbe(bZWrite_);
                graphics.SetZBufferEnable(bZTest_);
                graphics.SetBlendMode((uint)typeBlend_);
                graphics.SetCullingMode((uint)modeCulling_);
            }

            public TrajectoryObject3D GetObjectPointer()
            {
                return (TrajectoryObject3D)objRender_.GetPointer();
            }

            public override bool IsValidVertexIndex(int index)
            {
                return false;
            }
            public override void SetColor(int r, int g, int b)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                TrajectoryObject3D obj = GetObjectPointer();
                obj.SetColor(D3DCOLOR_ARGB(255, r, g, b));
            }

            public override void SetAlpha(int alpha)
            {
            }
            public override void SetVertexPosition(int index, float x, float y, float z)
            {
            }
            public override void SetVertexUV(int index, float u, float v)
            {
            }
            public override void SetVertexAlpha(int index, int alpha)
            {
            }
            public override void SetVertexColor(int index, int r, int g, int b)
            {
            }
            public override D3DXVECTOR3 GetVertexPosition(int index)
            {
                return D3DXVECTOR3(0, 0, 0);
            }
    }

    /**********************************************************
    //DxScriptMeshObject
    **********************************************************/
    public class DxScriptMeshObject : DxScriptRenderObject
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxScript;
            protected gstd.ref_count_ptr<DxMesh> mesh_ = new gstd.ref_count_ptr<DxMesh>();
            protected int time_;
            protected string anime_ = "";
            protected D3DCOLOR color_ = new D3DCOLOR();
            protected bool bCoordinate2D_;
            protected void _UpdateMeshState()
            {
                if (mesh_ == null)
                {
                    return;
                }
                mesh_.SetPosition(position_);
                mesh_.SetAngle(angle_);
                mesh_.SetScale(scale_);
                mesh_.SetColor(color_);
            }


            /**********************************************************
            //DxScriptMeshObject
            **********************************************************/
            public DxScriptMeshObject()
            {
                typeObject_ = DxScript.OBJ_MESH;
                bZWrite_ = true;
                bZTest_ = true;
                bFogEnable_ = true;
                time_ = 0;
                anime_ = "";
                color_ = D3DCOLOR_ARGB(255, 255, 255, 255);
                bCoordinate2D_ = false;
            }

            public override void Render()
            {
                if (mesh_ == null)
                {
                    return;
                }
                DirectGraphics graphics = DirectGraphics.GetBase();
                bool bEnvFogEnable = graphics.IsFogEnable();
                SetRenderState();
                mesh_.Render(anime_, time_);

                // �t�H�O�̏�Ԃ���Z�b�g
                if (bEnvFogEnable)
                {
                    graphics.SetFogEnable(true);
                }
            }

            public override void SetRenderState()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                bool bEnvFogEnable = graphics.IsFogEnable();

                mesh_.SetPosition(position_);
                mesh_.SetAngle(angle_);
                mesh_.SetScale(scale_);
                mesh_.SetColor(color_);
                mesh_.SetCoordinate2D(bCoordinate2D_);

                graphics.SetLightingEnable(true);
                graphics.SetZWriteEnalbe(bZWrite_);
                graphics.SetZBufferEnable(bZTest_);
                if (bEnvFogEnable)
                {
                    graphics.SetFogEnable(bFogEnable_);
                }
                graphics.SetBlendMode((uint)typeBlend_);
                graphics.SetCullingMode((uint)modeCulling_);
            }

            public override void SetColor(int r, int g, int b)
            {
                ColorAccess.SetColorR(color_, r);
                ColorAccess.SetColorG(color_, g);
                ColorAccess.SetColorB(color_, b);
            }

            public override void SetAlpha(int alpha)
            {
                ColorAccess.SetColorA(color_, alpha);
            }

            public void SetMesh(gstd.ref_count_ptr<DxMesh> mesh)
            {
                mesh_.CopyFrom(mesh);
            }
            public gstd.ref_count_ptr<DxMesh> GetMesh()
            {
                return new gstd.ref_count_ptr<DxMesh>(mesh_);
            }
            public int GetAnimeFrame()
            {
                return time_;
            }
            public string GetAnimeName()
            {
                return anime_;
            }

            public virtual void SetX(float x)
            {
                position_.x = x;
                _UpdateMeshState();
            }
            public virtual void SetY(float y)
            {
                position_.y = y;
                _UpdateMeshState();
            }
            public virtual void SetZ(float z)
            {
                position_.z = z;
                _UpdateMeshState();
            }
            public virtual void SetAngleX(float x)
            {
                angle_.x = x;
                _UpdateMeshState();
            }
            public virtual void SetAngleY(float y)
            {
                angle_.y = y;
                _UpdateMeshState();
            }
            public virtual void SetAngleZ(float z)
            {
                angle_.z = z;
                _UpdateMeshState();
            }
            public virtual void SetScaleX(float x)
            {
                scale_.x = x;
                _UpdateMeshState();
            }
            public virtual void SetScaleY(float y)
            {
                scale_.y = y;
                _UpdateMeshState();
            }
            public virtual void SetScaleZ(float z)
            {
                scale_.z = z;
                _UpdateMeshState();
            }
            public override void SetShader(gstd.ref_count_ptr<Shader> shader)
            {
                if (mesh_ == null)
                {
                    return;
                }
                mesh_.SetShader(shader);
            }
    }

    /**********************************************************
    //DxScriptTextObject
    **********************************************************/
    public class DxScriptTextObject : DxScriptRenderObject
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend DxScript;
            protected bool bChange_;
            protected DxText text_ = new DxText();
            protected gstd.ref_count_ptr<DxTextInfo> textInfo_ = new gstd.ref_count_ptr<DxTextInfo>();
            protected gstd.ref_count_ptr<DxTextRenderObject> objRender_ = new gstd.ref_count_ptr<DxTextRenderObject>();
            protected D3DXVECTOR2 center_ = new D3DXVECTOR2(); // ���W�ϊ��̒��S
            protected bool bAutoCenter_;

            protected void _UpdateRenderer()
            {
                if (bChange_)
                {
                    textInfo_.CopyFrom(text_.GetTextInfo());
                    objRender_.CopyFrom(text_.CreateRenderObject(new gstd.ref_count_ptr<DxTextInfo>(textInfo_)));
                }
                bChange_ = false;
            }


            /**********************************************************
            //DxScriptTextObject
            **********************************************************/
            public DxScriptTextObject()
            {
                typeObject_ = DxScript.OBJ_TEXT;
                bChange_ = true;
                bAutoCenter_ = true;
                center_ = D3DXVECTOR2(0, 0);
            }

            public override void Render()
            {
                // �t�H�O��������
                DirectGraphics graphics = DirectGraphics.GetBase();
                uint bEnableFog = false;
                graphics.GetDevice().GetRenderState(D3DRS_FOGENABLE, bEnableFog);
                if (bEnableFog != 0)
                {
                    graphics.SetFogEnable(false);
                }

                SetRenderState();
                text_.SetPosition(position_.x, position_.y);
                _UpdateRenderer();
                objRender_.SetPosition(position_.x, position_.y);
                objRender_.SetAngle(angle_);
                objRender_.SetScale(scale_);
                objRender_.SetVertexColor(text_.GetVertexColor());
                objRender_.SetTransCenter(center_);
                objRender_.SetAutoCenter(bAutoCenter_);
                objRender_.Render();
                bChange_ = false;

                if (bEnableFog != 0)
                {
                    graphics.SetFogEnable(true);
                }
            }

            public override void SetRenderState()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.SetLightingEnable(false);
                graphics.SetZWriteEnalbe(false);
                graphics.SetZBufferEnable(false);
                graphics.SetBlendMode((uint)typeBlend_);
                graphics.SetCullingMode(D3DCULL_NONE);
            }

            public void SetText(string text)
            {
                text_.SetText(text);
                bChange_ = true;
            }
            public string GetText()
            {
                return text_.GetText();
            }
            public List<int> GetTextCountCU()
            {
                _UpdateRenderer();
                int lineCount = textInfo_.GetLineCount();
                List<int> listCount = new List<int>();
                for (int iLine = 0 ; iLine < lineCount ; iLine++)
                {
                    gstd.ref_count_ptr<DxTextLine> textLine = textInfo_.GetTextLine(iLine);
                    int count = textLine.GetTextCodeCount();
                    listCount.Add(count);
                }
                return new List<int>(listCount);
            }

            public int GetTotalWidth()
            {
                _UpdateRenderer();
                int res = textInfo_.GetTotalWidth();
                return res;
            }

            public int GetTotalHeight()
            {
                _UpdateRenderer();
                int res = textInfo_.GetTotalHeight();
                return res;
            }

            public void SetFontType(string type)
            {
                text_.SetFontType(type);
                bChange_ = true;
            }
            public void SetFontSize(int size)
            {
                text_.SetFontSize(size);
                bChange_ = true;
            }
            public void SetFontBold(bool bBold)
            {
                text_.SetFontBold(bBold);
            }
            public void SetFontItalic(bool bItalic)
            {
                text_.SetFontItalic(bItalic);
                bChange_ = true;
            }
            public void SetFontUnderLine(bool bLine)
            {
                text_.SetFontUnderLine(bLine);
                bChange_ = true;
            }

            public void SetFontColorTop(int r, int g, int b)
            {
                text_.SetFontColorTop(D3DCOLOR_ARGB(255, r, g, b));
                bChange_ = true;
            }
            public void SetFontColorBottom(int r, int g, int b)
            {
                text_.SetFontColorBottom(D3DCOLOR_ARGB(255, r, g, b));
                bChange_ = true;
            }
            public void SetFontBorderWidth(int width)
            {
                text_.SetFontBorderWidth(width);
                bChange_ = true;
            }
            public void SetFontBorderType(int type)
            {
                text_.SetFontBorderType(type);
                bChange_ = true;
            }
            public void SetFontBorderColor(int r, int g, int b)
            {
                text_.SetFontBorderColor(D3DCOLOR_ARGB(255, r, g, b));
                bChange_ = true;
            }

            public void SetMaxWidth(int width)
            {
                text_.SetMaxWidth(width);
                bChange_ = true;
            }
            public void SetMaxHeight(int height)
            {
                text_.SetMaxHeight(height);
                bChange_ = true;
            }
            public void SetLinePitch(int pitch)
            {
                text_.SetLinePitch(pitch);
                bChange_ = true;
            }
            public void SetSidePitch(int pitch)
            {
                text_.SetSidePitch(pitch);
                bChange_ = true;
            }
            public void SetHorizontalAlignment(int value)
            {
                text_.SetHorizontalAlignment(value);
                bChange_ = true;
            }
            public void SetVerticalAlignment(int value)
            {
                text_.SetVerticalAlignment(value);
                bChange_ = true;
            }
            public void SetPermitCamera(bool bPermit)
            {
                text_.SetPermitCamera(bPermit);
            }
            public void SetSyntacticAnalysis(bool bEnable)
            {
                text_.SetSyntacticAnalysis(bEnable);
            }

            public override void SetAlpha(int alpha)
            {
                D3DCOLOR color = text_.GetVertexColor();
                int r = ColorAccess.GetColorR(new D3DCOLOR(color));
                int g = ColorAccess.GetColorG(color);
                int b = ColorAccess.GetColorB(color);

                alpha = System.Math.Max(alpha, 0);
                alpha = System.Math.Min(alpha, 255);

                SetVertexColor(D3DCOLOR_ARGB(alpha, r, g, b));
            }

            public override void SetColor(int r, int g, int b)
            {
                D3DCOLOR color = text_.GetVertexColor();
                int a = ColorAccess.GetColorA(color);
                r = System.Math.Max(r, 0);
                r = System.Math.Min(r, 255);
                g = System.Math.Max(g, 0);
                g = System.Math.Min(g, 255);
                b = System.Math.Max(b, 0);
                b = System.Math.Min(b, 255);

                SetVertexColor(D3DCOLOR_ARGB(a, r, g, b));
            }

            public void SetVertexColor(D3DCOLOR color)
            {
                text_.SetVertexColor(new D3DCOLOR(color));
            }
            public override void SetShader(gstd.ref_count_ptr<Shader> shader)
            {
                text_.SetShader(new gstd.ref_count_ptr<Shader>(shader));
                bChange_ = true;
            }
    }

    /**********************************************************
    //DxSoundObject
    **********************************************************/
    public class DxSoundObject : DxScriptObjectBase
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend DxScript;
            protected gstd.ref_count_ptr<SoundPlayer> player_ = new gstd.ref_count_ptr<SoundPlayer>();
            protected SoundPlayer.PlayStyle style_ = new SoundPlayer.PlayStyle();

            /**********************************************************
            //DxSoundObject
            **********************************************************/
            public DxSoundObject()
            {
                typeObject_ = DxScript.OBJ_SOUND;
            }

            public new void Dispose()
            {
                if (player_ == null)
                {
                    return;
                }
                player_.Delete();
                base.Dispose();
            }

            public override void Render()
            {
            }
            public override void SetRenderState()
            {
            }

            public bool Load(string path)
            {
                DirectSoundManager manager = DirectSoundManager.GetBase();
                player_.CopyFrom(manager.GetPlayer(path));
                if (player_ == null)
                {
                    return false;
                }

                return true;
            }

            public void Play()
            {
                if (player_ != null)
                {
                    player_.Play(style_);
                }
            }

            public gstd.ref_count_ptr<SoundPlayer> GetPlayer()
            {
                return new gstd.ref_count_ptr<SoundPlayer>(player_);
            }
            public SoundPlayer.PlayStyle GetStyle()
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return style_;
                return new directx.SoundPlayer.PlayStyle(style_);
            }
    }

    /**********************************************************
    //DxFileObject
    **********************************************************/
    public abstract class DxFileObject : DxScriptObjectBase
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend DxScript;
            protected gstd.ref_count_ptr<gstd.File> file_ = new gstd.ref_count_ptr<gstd.File>();


            /**********************************************************
            //DxFileObject
            **********************************************************/
            public DxFileObject()
            {
            }

            public new void Dispose()
            {
                base.Dispose();
            }

            public gstd.ref_count_ptr<gstd.File> GetFile()
            {
                return new gstd.ref_count_ptr<gstd.File>(file_);
            }

            public override void Render()
            {
            }
            public override void SetRenderState()
            {
            }

            public virtual bool OpenR(string path)
            {
                file_ = new File(path);
                bool res = file_.Open();
                if (!res)
                {
                    file_ = null;
                }
                return res;
            }

            public virtual bool OpenW(string path)
            {
                path = PathProperty.Canonicalize(path);
                path = PathProperty.ReplaceYenToSlash(path);

                string dir = PathProperty.GetFileDirectory(path);
                File fDir = new File(dir);
                bool bDir = fDir.CreateDirectory();
                if (!bDir)
                {
                    return false;
                }

                string dirModule = PathProperty.GetFileDirectory(path);
                if (dir.IndexOf(dirModule) == -1)
                {
                    return false;
                }

                file_ = new File(path);
                bool res = file_.Create();
                if (!res)
                {
                    file_ = null;
                }
                return res;
            }

            public abstract bool Store();
            public virtual void Close()
            {
                if (file_ == null)
                {
                    return;
                }
                file_.Close();
            }
    }

    /**********************************************************
    //DxTextFileObject
    **********************************************************/
    public class DxTextFileObject : DxFileObject
    {
            protected List<string> listLine_ = new List<string>();


            /**********************************************************
            //DxTextFileObject
            **********************************************************/
            public DxTextFileObject()
            {
                typeObject_ = DxScript.OBJ_FILE_TEXT;
            }

            public override void Dispose()
            {
                base.Dispose();
            }

            public class TextScanner
            {
                    private string text_;
                    private int pos_;
                    public TextScanner(string text)
                    {
                        text_ = text;
                        pos_ = 0;
                    }
                    public int GetPosition()
                    {
                        return pos_;
                    }
                    public char GetCurrentCharactor()
                    {
                        return text_[pos_];
                    }
                    public void Advance()
                    {
                        pos_++;
                        if (pos_ >= text_.Length)
                        {
                            throw new gstd.wexception();
                        }
                    }
            }
            public override bool OpenR(string path)
            {
                listLine_.Clear();
                bool res = base.OpenR(path);
                if (!res)
                {
                    return false;
                }

                int size = file_.GetSize();
                if (size == 0)
                {
                    return true;
                }

                string text;
                text.resize(size+1);
                file_.Read(text[0], size);
                text = StringFunctions.ChangeCharacter(text, size, '\0');

                TextScanner scan = new TextScanner(text);

                try
                {
                    int pointer = 0;
                    int posStart = 0;
                    while (true)
                    {
                        if (scan.GetPosition() >= size)
                        {
                            break;
                        }
                        if (IsDBCSLeadByte(scan.GetCurrentCharactor()))
                        {
                            while (IsDBCSLeadByte(scan.GetCurrentCharactor()))
                            {
                                scan.Advance();
                            }
                        }
                        else
                        {
                            char ch = scan.GetCurrentCharactor();
                            if (ch == '\r' || ch == '\n')
                            {
                                int posEnd = scan.GetPosition();
                                if (ch == '\r')
                                {
                                    scan.Advance();
                                }
                                scan.Advance();

                                string str = text.Substring(posStart, posEnd - posStart);
                                listLine_.Add(str);
                                posStart = scan.GetPosition();
                            }
                            else
                            {
                                scan.Advance();
                            }
                        }

                    };
                    string str = text.Substring(posStart, size - posStart);
                    listLine_.Add(str);
                }
                catch
                {
                    return false;
                }

                return true;
            }

            public override bool OpenW(string path)
            {
                bool res = base.OpenW(path);
                return res;
            }

            public override bool Store()
            {
                if (file_ == null)
                {
                    return false;
                }
                for (int iLine = 0 ; iLine < listLine_.Count ; iLine++)
                {
                    string str = listLine_[iLine];
                    if (iLine < listLine_.Count - 1)
                    {
                        str += "\r\n";
                    }

// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: const char* text = str.c_str();
                    char text = str;
                    int length = str.Length;
                    file_.Write((object)text, length);
                }
                return true;
            }

            public int GetLineCount()
            {
                return listLine_.Count;
            }
            public string GetLine(int line)
            {
                line--; // �s����1�J�n
                if (line >= listLine_.Count)
                {
                    return "";
                }

                string res = listLine_[line];
                return res;
            }

            public void AddLine(string line)
            {
                listLine_.Add(line);
            }
            public void ClearLine()
            {
                listLine_.Clear();
            }
    }

    /**********************************************************
    //DxBinaryFileObject
    **********************************************************/
    public class DxBinaryFileObject : DxFileObject
    {
            protected int byteOrder_;
            protected uint codePage_;
            protected gstd.ref_count_ptr<gstd.ByteBuffer> buffer_ = new gstd.ref_count_ptr<gstd.ByteBuffer>();


            /**********************************************************
            //DxBinaryFileObject
            **********************************************************/
            public DxBinaryFileObject()
            {
                typeObject_ = DxScript.OBJ_FILE_BINARY;
                byteOrder_ = ByteOrder.ENDIAN_LITTLE;
                codePage_ = CP_ACP;
            }

            public override void Dispose()
            {
                base.Dispose();
            }

            public override bool OpenR(string path)
            {
                bool res = base.OpenR(path);
                if (!res)
                {
                    return false;
                }

                int size = file_.GetSize();
                buffer_ = new gstd.ByteBuffer();
                buffer_.SetSize(size);

                file_.Read(buffer_.GetPointer(), size);

                return true;
            }

            public override bool OpenW(string path)
            {
                return false;
            }

            public override bool Store()
            {
                return false;
            }

            public gstd.ref_count_ptr<gstd.ByteBuffer> GetBuffer()
            {
                return new gstd.ref_count_ptr<gstd.ByteBuffer>(buffer_);
            }
            public bool IsReadableSize(int size)
            {
                int pos = buffer_.GetOffset();
                bool res = pos + size <= buffer_.GetSize();
                return res;
            }

            public uint GetCodePage()
            {
                return codePage_;
            }
            public void SetCodePage(uint page)
            {
                codePage_ = page;
            }

            public void SetByteOrder(int order)
            {
                byteOrder_ = order;
            }
            public int GetByteOrder()
            {
                return byteOrder_;
            }
    }

    /**********************************************************
    //DxScriptObjectManager
    **********************************************************/
    public class DxScriptObjectManager : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxScriptObjectBase;
            public class SoundInfo : System.IDisposable
            {
                public gstd.ref_count_ptr<SoundPlayer> player_ = new gstd.ref_count_ptr<SoundPlayer>();
                public SoundPlayer.PlayStyle style_ = new SoundPlayer.PlayStyle();
                public virtual void Dispose()
                {
                }
            }
            protected _int64 totalObjectCreateCount_ = new _int64();
            protected LinkedList<int> listUnusedIndex_ = new LinkedList<int>();
            protected List<gstd.ref_count_ptr<DxScriptObjectBase>.unsync > obj_ = new List<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >(); // �I�u�W�F�N�g
            protected LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync > listActiveObject_ = new LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >();
            protected SortedDictionary<string, gstd.ref_count_ptr<SoundInfo>> mapReservedSound_ = new SortedDictionary<string, gstd.ref_count_ptr<SoundInfo>>();

            // �t�H�O
            protected bool bFogEnable_;
            protected D3DCOLOR fogColor_ = new D3DCOLOR();
            protected float fogStart_;
            protected float fogEnd_;

            protected List<LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >> objRender_ = new List<LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >>(); // �`��o�P�b�g�\�[�g
            protected List<gstd.ref_count_ptr<Shader>> listShader_ = new List<gstd.ref_count_ptr<Shader>>();

            protected void _SetObjectID(DxScriptObjectBase obj, int index)
            {
                obj.idObject_ = index;
                obj.manager_ = this;
            }
            protected void _ArrangeActiveObjectList()
            {
                LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >.Enumerator itr;
                for (itr = listActiveObject_.GetEnumerator(); itr.MoveNext();)
                {
                    gstd.ref_count_ptr<DxScriptObjectBase>.unsync obj = itr.Current;
                    if (obj == null || obj.IsDeleted() || !obj.IsActive())
                    {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                        itr = listActiveObject_.erase(itr);
                    }
                    else
                    {
                    }
                }
            }


            /**********************************************************
            //DxScriptObjectManager
            **********************************************************/
            public DxScriptObjectManager()
            {
                SetMaxObject(256 * 256);
                SetRenderBucketCapacity(101);
                totalObjectCreateCount_ = 0;

                bFogEnable_ = false;
                fogColor_ = D3DCOLOR_ARGB(255, 255, 255, 255);
                fogStart_ = 0F;
                fogEnd_ = 0F;
            }

            public virtual void Dispose()
            {
            }

            public int GetMaxObject()
            {
                return obj_.Count;
            }
            public void SetMaxObject(int max)
            {
                if (obj_.Count == max)
                {
                    return;
                }

                if (obj_.Count < max)
                {
                    listUnusedIndex_.Clear();
                    for (int iObj = 0 ; iObj < obj_.Count ; iObj++)
                    {
                        if (obj_[iObj] != null)
                        {
                            continue;
                        }
                        listUnusedIndex_.AddLast(iObj);
                    }
                }
                for (int iObj = obj_.Count ; iObj < max ; iObj++)
                {
                    listUnusedIndex_.AddLast(iObj);
                }
                obj_.Resize(max);
            }

            public int GetAliveObjectCount()
            {
                return obj_.Count - listUnusedIndex_.Count;
            }
            public int GetRenderBucketCapacity()
            {
                return objRender_.Count;
            }
            public void SetRenderBucketCapacity(int capacity)
            {
                objRender_.Resize(capacity);
                listShader_.Resize(capacity);
            }

            public virtual int AddObject(gstd.ref_count_ptr<DxScriptObjectBase>.unsync obj, bool bActivate = true)
            {
                int res = DxScript.ID_INVALID;
                if (listUnusedIndex_.Count <= obj_.Count / 2)
                {
                    // �󂫂��Ȃ�(�O�̂��߂ɋ󂫂������ȉ�)�̂Ŋg��
                    int oldSize = obj_.Count;
                    int newSize = (int)oldSize * 1.5;
                    SetMaxObject(newSize);
                    Logger.WriteTop(StringUtility.Format("DxScriptObjectManager�T�C�Y�g��[%d->%d]", oldSize, newSize));
                }

                if (listUnusedIndex_.Count != 0)
                {
                    res = listUnusedIndex_.First.Value;
                    listUnusedIndex_.RemoveFirst();

                    obj_[res].CopyFrom(obj);
                    if (bActivate)
                    {
                        obj.bActive_ = true;
                        listActiveObject_.AddLast(obj);
                    }
                    obj.idObject_ = res;
                    obj.manager_ = this;

                    totalObjectCreateCount_++;
                }

                return res;
            }

            public void AddObject(int id, gstd.ref_count_ptr<DxScriptObjectBase>.unsync obj, bool bActivate = true)
            {
                obj_[id].CopyFrom(obj);
                obj.idObject_ = id;
                obj.manager_ = this;
                if (bActivate)
                {
                    obj.bActive_ = true;
                    listActiveObject_.AddLast(obj);
                }

                LinkedList<int>.Enumerator itr = listUnusedIndex_.GetEnumerator();
                while (itr.MoveNext())
                {
                    if (itr.Current == id)
                    {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                        listUnusedIndex_.erase(itr);
                        totalObjectCreateCount_++;
                        break;
                    }
                }
            }

            public void ActivateObject(int id, bool bActivate)
            {
                gstd.ref_count_ptr<DxScriptObjectBase>.unsync obj = GetObject(id);
                if (obj == null || obj.IsDeleted())
                {
                    return;
                }

                if (bActivate && !obj.IsActive())
                {
                    obj.bActive_ = true;
                    listActiveObject_.AddLast(obj);
                }
                else if (!bActivate)
                {
                    obj.bActive_ = false;
                }
            }

            public gstd.ref_count_ptr<DxScriptObjectBase>.unsync GetObject(int id)
            {
                return new gstd.ref_count_ptr<DxScriptObjectBase>.unsync(obj_[id]);
            }
            public List<int> GetValidObjectIdentifier()
            {
                List<int> res = new List<int>();
                for (int iObj = 0 ; iObj < obj_.Count ; iObj++)
                {
                    if (obj_[iObj] == null)
                    {
                        continue;
                    }
                    res.Add(obj_[iObj].idObject_);
                }
                return new List<int>(res);
            }

            public DxScriptObjectBase GetObjectPointer(int id)
            {
                if (id < 0 || id >= obj_.Count)
                {
                    return null;
                }
                return obj_[id].GetPointer();
            }

            public virtual void DeleteObject(int id)
            {
                if (id < 0 || id >= obj_.Count)
                {
                    return;
                }
                if (obj_[id] == null)
                {
                    return;
                }

                obj_[id].bDeleted_ = true;
                obj_[id] = null;
                // listUnusedIndex_.push_back(id);
            }

            public void ClearObject()
            {
                int size = obj_.Count;
                obj_.Clear();
                obj_.Resize(size);
                listActiveObject_.Clear();

                listUnusedIndex_.Clear();
                for (int iObj = 0 ; iObj < size ; iObj++)
                {
                    listUnusedIndex_.AddLast(iObj);
                }
            }

            public void DeleteObjectByScriptID(_int64 idScript)
            {
                if (idScript == ScriptClientBase.ID_SCRIPT_FREE)
                {
                    return;
                }

                for (int iObj = 0 ; iObj < obj_.Count ; iObj++)
                {
                    if (obj_[iObj] == null)
                    {
                        continue;
                    }
                    if (obj_[iObj].GetScriptID() != idScript)
                    {
                        continue;
                    }
                    DeleteObject(obj_[iObj].GetObjectID());
                }
            }

            public void AddRenderObject(gstd.ref_count_ptr<DxScriptObjectBase>.unsync obj)
            {
                if (!obj.IsVisible())
                {
                    return;
                }

                int renderSize = objRender_.Count;
                double pri = obj.priRender_;
                int tPri = (int)(pri * (objRender_.Count - 1) + 0.5);
                if (tPri > objRender_.Count - 1)
                {
                    tPri = objRender_.Count - 1;
                }
                objRender_[tPri].AddLast(obj);
            }

            public void WorkObject()
            {
                _ArrangeActiveObjectList();
                LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >.Enumerator itr;
                for (itr = listActiveObject_.GetEnumerator(); itr.MoveNext();)
                {
                    gstd.ref_count_ptr<DxScriptObjectBase>.unsync obj = itr.Current;
                    if (obj == null || obj.IsDeleted())
                    {
                        continue;
                    }
                    obj.Work();
                }

                // �����Đ�
                DirectSoundManager soundManager = DirectSoundManager.GetBase();
                SortedDictionary<string, ref_count_ptr<SoundInfo>>.Enumerator itrSound = mapReservedSound_.GetEnumerator();
                while (itrSound.MoveNext())
                {
                    gstd.ref_count_ptr<SoundInfo> info = itrSound.Current.Value;
                    gstd.ref_count_ptr<SoundPlayer> player = info.player_;
                    SoundPlayer.PlayStyle style = info.style_;
                    player.Play(style);
                }
                mapReservedSound_.Clear();

            }

            public void RenderObject()
            {
                PrepareRenderObject();

                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.SetVertexFog(bFogEnable_, new D3DCOLOR(fogColor_), fogStart_, fogEnd_);

                for (int iPri = 0 ; iPri < objRender_.Count ; iPri++)
                {
                    ref_count_ptr<Shader> shader = listShader_[iPri];
                    if (shader != null)
                    {
                        shader.Begin();
                    }

                    LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >.Enumerator itr;
                    for (itr = objRender_[iPri].GetEnumerator(); itr.MoveNext();)
                    {
                        itr.Current.Render();
                    }
                    objRender_[iPri].Clear();

                    if (shader != null)
                    {
                        shader.End();
                    }
                }

            }

            public void PrepareRenderObject()
            {
                LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >.Enumerator itr;
                for (itr = listActiveObject_.GetEnumerator(); itr.MoveNext();)
                {
                    gstd.ref_count_ptr<DxScriptObjectBase>.unsync obj = itr.Current;
                    if (obj == null || obj.IsDeleted())
                    {
                        continue;
                    }
                    if (!obj.IsVisible())
                    {
                        continue;
                    }
                    AddRenderObject(new gstd.ref_count_ptr<DxScriptObjectBase>.unsync(obj));
                }
            }

            public void ClearRenderObject()
            {
                for (int iPri = 0 ; iPri < objRender_.Count ; iPri++)
                {
                    objRender_[iPri].Clear();
                }
            }

            public List<LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >> GetRenderObjectListPointer()
            {
                return new List<LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >>(objRender_);
            }

            public void SetShader(gstd.ref_count_ptr<Shader> shader, double min, double max)
            {
                int tPriMin = (int)(min * (listShader_.Count - 1) + 0.5);
                int tPriMax = (int)(max * (listShader_.Count - 1) + 0.5);
                for (int iPri = tPriMin ; iPri <= tPriMax ; iPri++)
                {
                    if (iPri < 0 || iPri >= listShader_.Count)
                    {
                        break;
                    }
                    listShader_[iPri].CopyFrom(shader);
                }
            }

            public void ResetShader()
            {
                ResetShader(0, listShader_.Count);
            }

            public void ResetShader(double min, double max)
            {
                SetShader(null, min, max);
            }

            public gstd.ref_count_ptr<Shader> GetShader(int index)
            {
                if (index < 0 || index >= listShader_.Count)
                {
                    return null;
                }
                ref_count_ptr<Shader> shader = listShader_[index];
                return new ref_count_ptr<Shader>(shader);
            }

            public void ReserveSound(ref_count_ptr<SoundPlayer> player, SoundPlayer.PlayStyle style)
            {
                ref_count_ptr<SoundInfo> info = new SoundInfo();
                info.player_ = player;
                info.style_ = style;

                string path = player.GetPath();
                mapReservedSound_[path] = info;
            }

            public void DeleteReservedSound(gstd.ref_count_ptr<SoundPlayer> player)
            {
                string path = player.GetPath();
                mapReservedSound_.Remove(path);
            }

            public void SetFogParam(bool bEnable, D3DCOLOR fogColor, float start, float end)
            {
                bFogEnable_ = bEnable;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: fogColor_ = fogColor;
                fogColor_.CopyFrom(fogColor);
                fogStart_ = start;
                fogEnd_ = end;
            }

            public _int64 GetTotalObjectCreateCount()
            {
                return new _int64(totalObjectCreateCount_);
            }

            public bool IsFogEneble()
            {
                return bFogEnable_;
            }
            public D3DCOLOR GetFogColor()
            {
                return new D3DCOLOR(fogColor_);
            }
            public float GetFogStart()
            {
                return fogStart_;
            }
            public float GetFogEnd()
            {
                return fogEnd_;
            }
    }

    /**********************************************************
    //DxScript
    **********************************************************/
    public class DxScript : gstd.ScriptClientBase
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                ID_INVALID = -1,
                OBJ_INVALID = -1,
                OBJ_PRIMITIVE_2D = 1,
                OBJ_SPRITE_2D,
                OBJ_SPRITE_LIST_2D,
                OBJ_PRIMITIVE_3D,
                OBJ_SPRITE_3D,
                OBJ_TRAJECTORY_3D,
                OBJ_SHADER,

                OBJ_MESH,
                OBJ_TEXT,
                OBJ_SOUND,

                OBJ_FILE_TEXT,
                OBJ_FILE_BINARY,

                CODE_ACP = CP_ACP,
                CODE_UTF8 = CP_UTF8,
                CODE_UTF16LE,
                CODE_UTF16BE
            }

            protected gstd.ref_count_ptr<DxScriptObjectManager> objManager_ = new gstd.ref_count_ptr<DxScriptObjectManager>();

            // ���\�[�X
            protected SortedDictionary<string, gstd.ref_count_ptr<Texture>> mapTexture_ = new SortedDictionary<string, gstd.ref_count_ptr<Texture>>();
            protected SortedDictionary<string, gstd.ref_count_ptr<SoundPlayer>> mapSoundPlayer_ = new SortedDictionary<string, gstd.ref_count_ptr<SoundPlayer>>();
            protected SortedDictionary<string, gstd.ref_count_ptr<DxMesh>> mapMesh_ = new SortedDictionary<string, gstd.ref_count_ptr<DxMesh>>();

            protected void _ClearResource()
            {
                mapTexture_.Clear();
                mapMesh_.Clear();

                SortedDictionary<string, gstd.ref_count_ptr<SoundPlayer>>.Enumerator itrSound;
                for (itrSound = mapSoundPlayer_.GetEnumerator(); itrSound.MoveNext();)
                {
                    SoundPlayer player = (itrSound.Current.Value).GetPointer();
                    player.Delete();
                }
                mapSoundPlayer_.Clear();
            }

            protected gstd.ref_count_ptr<Texture> _GetTexture(string name)
            {
                gstd.ref_count_ptr<Texture> res = new gstd.ref_count_ptr<Texture>();
                if (mapTexture_.ContainsKey(name))
                {
                    res.CopyFrom(mapTexture_[name]);
                }
                return new gstd.ref_count_ptr<Texture>(res);
            }

            public DxScript()
            {
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(dxFunction, sizeof(dxFunction) / sizeof(function));
                _AddFunction(GlobalMembers.dxFunction, GlobalMembers.dxFunction.Length);
                objManager_ = new DxScriptObjectManager();
            }

            public override void Dispose()
            {
                _ClearResource();
                base.Dispose();
            }

            public void SetObjectManager(gstd.ref_count_ptr<DxScriptObjectManager> manager)
            {
                objManager_.CopyFrom(manager);
            }
            public gstd.ref_count_ptr<DxScriptObjectManager> GetObjectManager()
            {
                return new gstd.ref_count_ptr<DxScriptObjectManager>(objManager_);
            }
            public void SetMaxObject(int max)
            {
                objManager_.SetMaxObject(max);
            }
            public void SetRenderBucketCapacity(int capacity)
            {
                objManager_.SetRenderBucketCapacity(capacity);
            }
            public virtual int AddObject(gstd.ref_count_ptr<DxScriptObjectBase>.unsync obj, bool bActivate = true)
            {
                obj.idScript_ = idScript_;
                return objManager_.AddObject(obj, bActivate);
            }

            public virtual void ActivateObject(int id, bool bActivate)
            {
                objManager_.ActivateObject(id, bActivate);
            }
            public gstd.ref_count_ptr<DxScriptObjectBase>.unsync GetObject(int id)
            {
                return objManager_.GetObject(id);
            }
            public DxScriptObjectBase GetObjectPointer(int id)
            {
                return objManager_.GetObjectPointer(id);
            }
            public virtual void DeleteObject(int id)
            {
                objManager_.DeleteObject(id);
            }
            public void ClearObject()
            {
                objManager_.ClearObject();
            }
            public virtual void WorkObject()
            {
                objManager_.WorkObject();
            }
            public virtual void RenderObject()
            {
                objManager_.RenderObject();
            }

            public void AddMeshResource(string name, gstd.ref_count_ptr<DxMesh> mesh)
            {
                mapMesh_[name].CopyFrom(mesh);
            }

            // Dx�֐��F�V�X�e���n

            // Dx�֐��F�V�X�e���n�n
            public static gstd.value Func_InstallFont(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                DirectSoundManager manager = DirectSoundManager.GetBase();

                string path = argv[0].as_string();
                path = PathProperty.GetUnique(path);
                DxTextRenderer renderer = DxTextRenderer.GetBase();
                bool res = false;
                try
                {
                    res = renderer.AddFontFromFile(path);
                }
                catch (gstd.wexception e)
                {
                    Logger.WriteTop(e.what());
                }

                return new value(machine.get_engine().get_boolean_type(), res);
            }

            // Dx�֐��F�����n

            // Dx�֐��F�����n
            public static value Func_LoadSound(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                DirectSoundManager manager = DirectSoundManager.GetBase();

                string path = argv[0].as_string();
                path = PathProperty.GetUnique(path);
                if (script.mapSoundPlayer_.ContainsKey(path))
                {
                        return new value(machine.get_engine().get_boolean_type(), true);
                }

                ref_count_ptr<SoundPlayer> player = manager.GetPlayer(path, true);
                if (player != null)
                {
                    script.mapSoundPlayer_[path] = player;
                }
                return new value(machine.get_engine().get_boolean_type(), player != null);
            }

            public static value Func_RemoveSound(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                DirectSoundManager manager = DirectSoundManager.GetBase();

                string path = argv[0].as_string();
                path = PathProperty.GetUnique(path);
                if (!script.mapSoundPlayer_.ContainsKey(path))
                {
                    return new value();
                }

                ref_count_ptr<SoundPlayer> player = script.mapSoundPlayer_[path];
                player.Delete();
                script.mapSoundPlayer_.Remove(path);

                return new value();
            }

            public static value Func_PlayBGM(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                DirectSoundManager manager = DirectSoundManager.GetBase();

                string path = argv[0].as_string();
                path = PathProperty.GetUnique(path);
                if (!script.mapSoundPlayer_.ContainsKey(path))
                {
                    return new value();
                }

                double loopStart = argv[1].as_real();
                double loopEnd = argv[2].as_real();

                ref_count_ptr<SoundPlayer> player = script.mapSoundPlayer_[path];
                player.SetSoundDivision(SoundDivision.DIVISION_BGM);

                SoundPlayer.PlayStyle style = new SoundPlayer.PlayStyle();
                style.SetLoopEnable(true);
                style.SetLoopStartTime(loopStart);
                style.SetLoopEndTime(loopEnd);
                // player->Play(style);
                script.GetObjectManager().ReserveSound(player, style);

                return new value();
            }

            public static gstd.value Func_PlaySE(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                DirectSoundManager manager = DirectSoundManager.GetBase();

                string path = argv[0].as_string();
                path = PathProperty.GetUnique(path);
                if (!script.mapSoundPlayer_.ContainsKey(path))
                {
                    return new value();
                }

                ref_count_ptr<SoundPlayer> player = script.mapSoundPlayer_[path];
                player.SetSoundDivision(SoundDivision.DIVISION_SE);

                SoundPlayer.PlayStyle style = new SoundPlayer.PlayStyle();
                style.SetLoopEnable(false);
                // player->Play(style);
                script.GetObjectManager().ReserveSound(player, style);
                return new value();
            }

            public static value Func_StopSound(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                DirectSoundManager manager = DirectSoundManager.GetBase();

                string path = argv[0].as_string();
                path = PathProperty.GetUnique(path);
                if (!script.mapSoundPlayer_.ContainsKey(path))
                {
                    return new value();
                }

                ref_count_ptr<SoundPlayer> player = script.mapSoundPlayer_[path];
                player.Stop();
                script.GetObjectManager().DeleteReservedSound(player);

                return new value();
            }

            // Dx�֐��F�L�[�n

            // Dx�֐��F�L�[�n
            public static gstd.value Func_GetKeyState(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DirectInput input = DirectInput.GetBase();
                int key = (int)argv[0].as_real();
                double res = input.GetKeyState(key);
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_GetMouseX(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetMousePosition().x;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_GetMouseY(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetMousePosition().y;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_GetMouseMoveZ(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DirectInput input = DirectInput.GetBase();
                double res = input.GetMouseMoveZ();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_GetMouseState(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DirectInput input = DirectInput.GetBase();
                double res = input.GetMouseState((int)argv[0].as_real());
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_GetVirtualKeyState(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                double res = KEY_FREE;
                VirtualKeyManager input = DirectInput.GetBase() as VirtualKeyManager;
                if (input != null)
                {
                    int id = (int)(argv[0].as_real());
                    res = input.GetVirtualKeyState(id);
                }

                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_SetVirtualKeyState(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                VirtualKeyManager input = DirectInput.GetBase() as VirtualKeyManager;
                if (input != null)
                {
                    int id = (int)(argv[0].as_real());
                    int state = (int)(argv[1].as_real());
                    ref_count_ptr<VirtualKey> vkey = input.GetVirtualKey(id);
                    if (vkey != null)
                    {
                        vkey.SetKeyState(state);
                    }
                }

                return new value();
            }

            // Dx�֐��F�`��n
            // Dx�֐��F�`��n
            public static gstd.value Func_GetScreenWidth(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                int res = graphics.GetScreenWidth();
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            public static gstd.value Func_GetScreenHeight(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                int res = graphics.GetScreenHeight();
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            public static value Func_LoadTexture(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                bool res = true;
                string path = argv[0].as_string();
                path = PathProperty.GetUnique(path);

                if (!script.mapTexture_.ContainsKey(path))
                {
                    ref_count_ptr<Texture> texture = new Texture();
                    bool res = texture.CreateFromFile(path);
                    if (res)
                    {
                        Lock @lock = new Lock(script.criticalSection_);
                        script.mapTexture_[path] = texture;
                    }
                }
                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static value Func_LoadTextureInLoadThread(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                bool res = true;
                string path = argv[0].as_string();
                path = PathProperty.GetUnique(path);

                if (!script.mapTexture_.ContainsKey(path))
                {
                    ref_count_ptr<Texture> texture = new Texture();
                    bool res = texture.CreateFromFileInLoadThread(path);
                    if (res)
                    {
                        Lock @lock = new Lock(script.criticalSection_);
                        script.mapTexture_[path] = texture;
                    }
                }
                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static value Func_RemoveTexture(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                string path = argv[0].as_string();
                path = PathProperty.GetUnique(path);
                {
                    Lock @lock = new Lock(script.criticalSection_);
                    script.mapTexture_.Remove(path);
                }
                return new value();
            }

            public static value Func_GetTextureWidth(script_machine machine, int argc, value[] argv)
            {
                double res = 0;
                DxScript script = (DxScript)machine.data;
                string path = argv[0].as_string();
                path = PathProperty.GetUnique(path);
                TextureManager textureManager = TextureManager.GetBase();

                gstd.ref_count_ptr<TextureData> textureData = textureManager.GetTextureData(path);
                if (textureData != null)
                {
                    D3DXIMAGE_INFO imageInfo = textureData.GetImageInfo();
                    res = imageInfo.Width;
                }

                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_GetTextureHeight(script_machine machine, int argc, value[] argv)
            {
                double res = 0;
                DxScript script = (DxScript)machine.data;
                string path = argv[0].as_string();
                path = PathProperty.GetUnique(path);
                TextureManager textureManager = TextureManager.GetBase();

                gstd.ref_count_ptr<TextureData> textureData = textureManager.GetTextureData(path);
                if (textureData != null)
                {
                    D3DXIMAGE_INFO imageInfo = textureData.GetImageInfo();
                    res = imageInfo.Height;
                }

                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_SetFogEnable(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                bool bEnable = argv[0].as_boolean();
                script.GetObjectManager().SetFogParam(bEnable, 0, 0, 0);
                return new value();
            }

            public static gstd.value Func_SetFogParam(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                double start = argv[0].as_real();
                double end = argv[1].as_real();
                int r = (int)argv[2].as_real();
                int g = (int)argv[3].as_real();
                int b = (int)argv[4].as_real();
                D3DCOLOR color = D3DCOLOR_ARGB(255, r, g, b);
                script.GetObjectManager().SetFogParam(true, color, start, end);

                return new value();
            }

            public static gstd.value Func_CreateRenderTarget(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                bool res = true;
                string name = argv[0].as_string();

                if (!script.mapTexture_.ContainsKey(name))
                {
                    ref_count_ptr<Texture> texture = new Texture();
                    bool res = texture.CreateRenderTarget(name);
                    if (res)
                    {
                        Lock @lock = new Lock(script.criticalSection_);
                        script.mapTexture_[name] = texture;
                    }
                }
                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static gstd.value Func_SetRenderTarget(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                TextureManager textureManager = TextureManager.GetBase();

                string name = argv[0].as_string();
                ref_count_ptr<Texture> texture = script._GetTexture(name);
                if (texture == null)
                {
                    texture = textureManager.GetTexture(name);
                }
                if (texture == null)
                {
                    return new value();
                }

                DirectGraphics graphics = DirectGraphics.GetBase();
                ref_count_ptr<Texture> current = graphics.GetRenderTarget();
                graphics.SetRenderTarget(new ref_count_ptr<Texture>(texture));
                graphics.ClearRenderTarget();
                graphics.SetRenderTarget(new ref_count_ptr<Texture>(current));

                return new value();
            }

            public static gstd.value Func_GetTransitionRenderTargetName(gstd.script_machine machine, int argc, gstd.value argv)
            {
                string res = TextureManager.TARGET_TRANSITION;
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static gstd.value Func_SaveRenderedTextureA1(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                string nameTexture = argv[0].as_string();
                string path = argv[1].as_string();
                path = PathProperty.GetUnique(path);

                TextureManager textureManager = TextureManager.GetBase();
                DirectGraphics graphics = DirectGraphics.GetBase();

                ref_count_ptr<Texture> texture = script._GetTexture(nameTexture);
                if (texture == null)
                {
                    texture = textureManager.GetTexture(nameTexture);
                }

                if (texture != null)
                {
                    // �t�H���_����
                    string dir = PathProperty.GetFileDirectory(path);
                    File fDir = new File(dir);
                    fDir.CreateDirectory();

                    // �ۑ�
                    IDirect3DSurface9 pSurface = texture.GetD3DSurface();
                    RECT rect = new RECT(0, 0, graphics.GetScreenWidth(), graphics.GetScreenHeight());
                    D3DXSaveSurfaceToFile(path, D3DXIFF_BMP, pSurface, null, rect);
                }

                return new value();
            }

            public static gstd.value Func_SaveRenderedTextureA2(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;

                string nameTexture = argv[0].as_string();
                string path = argv[1].as_string();
                path = PathProperty.GetUnique(path);

                int rcLeft = (int)argv[2].as_real();
                int rcTop = (int)argv[3].as_real();
                int rcRight = (int)argv[4].as_real();
                int rcBottom = (int)argv[5].as_real();

                TextureManager textureManager = TextureManager.GetBase();
                DirectGraphics graphics = DirectGraphics.GetBase();

                ref_count_ptr<Texture> texture = script._GetTexture(nameTexture);
                if (texture == null)
                {
                    texture = textureManager.GetTexture(nameTexture);
                }
                if (texture != null)
                {
                    // �t�H���_����
                    string dir = PathProperty.GetFileDirectory(path);
                    File fDir = new File(dir);
                    fDir.CreateDirectory();

                    // �ۑ�
                    IDirect3DSurface9 pSurface = texture.GetD3DSurface();
                    RECT rect = new RECT(rcLeft, rcTop, rcRight, rcBottom);
                    D3DXSaveSurfaceToFile(path, D3DXIFF_BMP, pSurface, null, rect);
                }

                return new value();
            }

            public static gstd.value Func_SetShader(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }

                ref_count_ptr<Shader> shader = obj.GetShader();

                double min = (double)argv[1].as_real();
                double max = (double)argv[2].as_real();
                gstd.ref_count_ptr<DxScriptObjectManager> objectManager = script.GetObjectManager();
                objectManager.SetShader(shader, min, max);

                return new value();
            }

            public static gstd.value Func_SetShaderI(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }

                ref_count_ptr<Shader> shader = obj.GetShader();

                int size = script.GetObjectManager().GetRenderBucketCapacity();
                int min = (int)(argv[1].as_real() + 0.5);
                int max = (int)(argv[2].as_real() + 0.5);

                double priMin = (double)min / (double)(size - 1);
                double priMax = (double)max / (double)(size - 1);

                gstd.ref_count_ptr<DxScriptObjectManager> objectManager = script.GetObjectManager();
                objectManager.SetShader(shader, priMin, priMax);

                return new value();
            }

            public static gstd.value Func_ResetShader(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                ref_count_ptr<Shader> shader = null;

                double min = (double)argv[0].as_real();
                double max = (double)argv[1].as_real();
                gstd.ref_count_ptr<DxScriptObjectManager> objectManager = script.GetObjectManager();
                objectManager.SetShader(shader, min, max);

                return new value();
            }

            public static gstd.value Func_ResetShaderI(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                ref_count_ptr<Shader> shader = null;

                int size = script.GetObjectManager().GetRenderBucketCapacity();
                int min = (int)(argv[0].as_real() + 0.5);
                int max = (int)(argv[1].as_real() + 0.5);

                double priMin = (double)min / (double)(size - 1);
                double priMax = (double)max / (double)(size - 1);

                gstd.ref_count_ptr<DxScriptObjectManager> objectManager = script.GetObjectManager();
                objectManager.SetShader(shader, priMin, priMax);

                return new value();
            }

            public static gstd.value Func_IsPixelShaderSupported(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                ref_count_ptr<Shader> shader = null;

                int major = (int)(argv[0].as_real() + 0.5);
                int minor = (int)(argv[1].as_real() + 0.5);

                DirectGraphics graphics = DirectGraphics.GetBase();
                bool res = graphics.IsPixelShaderSupported(major, minor);

                return new value(machine.get_engine().get_boolean_type(), res);
            }


            // Dx�֐��F�J����3D

            // Dx�֐��F�J����3D
            public static value Func_SetCameraFocusX(script_machine machine, int argc, value[] argv)
            {
                float x = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera().SetFocusX(x);
                return new value();
            }

            public static value Func_SetCameraFocusY(script_machine machine, int argc, value[] argv)
            {
                float y = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera().SetFocusY(y);
                return new value();
            }

            public static value Func_SetCameraFocusZ(script_machine machine, int argc, value[] argv)
            {
                float z = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera().SetFocusZ(z);
                return new value();
            }

            public static value Func_SetCameraFocusXYZ(script_machine machine, int argc, value[] argv)
            {
                float x = argv[0].as_real();
                float y = argv[1].as_real();
                float z = argv[2].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera().SetFocusX(x);
                graphics.GetCamera().SetFocusY(y);
                graphics.GetCamera().SetFocusZ(z);
                return new value();
            }

            public static value Func_SetCameraRadius(script_machine machine, int argc, value[] argv)
            {
                float r = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera().SetRadius(r);
                return new value();
            }

            public static value Func_SetCameraAzimuthAngle(script_machine machine, int argc, value[] argv)
            {
                float angle = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera().SetAzimuthAngle(angle);
                return new value();
            }

            public static value Func_SetCameraElevationAngle(script_machine machine, int argc, value[] argv)
            {
                float angle = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera().SetElevationAngle(angle);
                return new value();
            }

            public static value Func_SetCameraYaw(script_machine machine, int argc, value[] argv)
            {
                float angle = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera().SetYaw(angle);
                return new value();
            }

            public static value Func_SetCameraPitch(script_machine machine, int argc, value[] argv)
            {
                float angle = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera().SetPitch(angle);
                return new value();
            }

            public static value Func_SetCameraRoll(script_machine machine, int argc, value[] argv)
            {
                float angle = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera().SetRoll(angle);
                return new value();
            }

            public static value Func_GetCameraX(script_machine machine, int argc, value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera().GetCameraPosition().x;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_GetCameraY(script_machine machine, int argc, value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera().GetCameraPosition().y;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_GetCameraZ(script_machine machine, int argc, value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera().GetCameraPosition().z;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_GetCameraFocusX(script_machine machine, int argc, value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera().GetFocusPosition().x;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_GetCameraFocusY(script_machine machine, int argc, value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera().GetFocusPosition().y;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_GetCameraFocusZ(script_machine machine, int argc, value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera().GetFocusPosition().z;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_GetCameraRadius(script_machine machine, int argc, value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera().GetRadius();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_GetCameraAzimuthAngle(script_machine machine, int argc, value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera().GetAzimuthAngle();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_GetCameraElevationAngle(script_machine machine, int argc, value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera().GetElevationAngle();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_GetCameraYaw(script_machine machine, int argc, value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera().GetYaw();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_GetCameraPitch(script_machine machine, int argc, value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera().GetPitch();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_GetCameraRoll(script_machine machine, int argc, value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera().GetRoll();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_SetCameraPerspectiveClip(script_machine machine, int argc, value[] argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double clipNear = argv[0].as_real();
                double clipFar = argv[1].as_real();
                int width = graphics.GetScreenWidth();
                int height = graphics.GetScreenHeight();

                graphics.GetCamera().SetProjectionMatrix(width, height, clipNear, clipFar);
                return new value();
            }

            // Dx�֐��F�J����2D

            // Dx�֐��F�J����2D
            public static gstd.value Func_Set2DCameraFocusX(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                float x = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera2D().SetFocusX(x);
                return new gstd.value();
            }

            public static gstd.value Func_Set2DCameraFocusY(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                float y = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera2D().SetFocusY(y);
                return new gstd.value();
            }

            public static gstd.value Func_Set2DCameraAngleZ(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                float angle = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera2D().SetAngleZ(angle);
                return new gstd.value();
            }

            public static gstd.value Func_Set2DCameraRatio(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                float ratio = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera2D().SetRatio(ratio);
                return new gstd.value();
            }

            public static gstd.value Func_Set2DCameraRatioX(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                float ratio = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera2D().SetRatioX(ratio);
                return new gstd.value();
            }

            public static gstd.value Func_Set2DCameraRatioY(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                float ratio = argv[0].as_real();
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera2D().SetRatioY(ratio);
                return new gstd.value();
            }

            public static gstd.value Func_Reset2DCamera(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.GetCamera2D().Reset();
                return new gstd.value();
            }

            public static gstd.value Func_Get2DCameraX(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera2D().GetFocusX();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_Get2DCameraY(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera2D().GetFocusY();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_Get2DCameraAngleZ(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera2D().GetAngleZ();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_Get2DCameraRatio(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera2D().GetRatio();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_Get2DCameraRatioX(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera2D().GetRatioX();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_Get2DCameraRatioY(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                double res = graphics.GetCamera2D().GetRatioY();
                return new value(machine.get_engine().get_real_type(), res);
            }

            // Dx�֐��F���̑�

            // Dx�֐��F���̑�
            public static gstd.value Func_GetObjectDistance(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id1 = (int)argv[0].as_real();
                int id2 = (int)argv[1].as_real();

                DxScriptRenderObject obj1 = script.GetObjectPointer(id1) as DxScriptRenderObject;
                if (obj1 == null)
                {
                    return new value(machine.get_engine().get_real_type(), (double) - 1);
                }

                DxScriptRenderObject obj2 = script.GetObjectPointer(id2) as DxScriptRenderObject;
                if (obj2 == null)
                {
                    return new value(machine.get_engine().get_real_type(), (double) - 1);
                }

                int tx = obj1.GetPosition().x - obj2.GetPosition().x;
                int ty = obj1.GetPosition().y - obj2.GetPosition().y;
                int tz = obj1.GetPosition().z - obj2.GetPosition().z;

                double res = System.Math.Pow(System.Math.Pow(tx, 2) + System.Math.Pow(ty, 2) + System.Math.Pow(tz, 2), 0.5);
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_GetObject2dPosition(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();

                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    script.RaiseError("error invalid object");
                }

                DirectGraphics graphics = DirectGraphics.GetBase();
                gstd.ref_count_ptr<DxCamera> camera = graphics.GetCamera();
                D3DXVECTOR3 pos = obj.GetPosition();

                D3DXVECTOR2 point = camera.TransformCoordinateTo2D(pos);
                List<double> listRes = new List<double>();
                listRes.Add(point.x);
                listRes.Add(point.y);

                gstd.value res = script.CreateRealArrayValue(listRes);
                return new gstd.value(res);
            }

            public static gstd.value Func_Get2dPosition(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                double px = argv[0].as_real();
                double py = argv[1].as_real();
                double pz = argv[2].as_real();

                D3DXVECTOR3 pos = new D3DXVECTOR3(px, py, pz);

                DirectGraphics graphics = DirectGraphics.GetBase();
                gstd.ref_count_ptr<DxCamera> camera = graphics.GetCamera();
                D3DXVECTOR2 point = camera.TransformCoordinateTo2D(pos);
                List<double> listRes = new List<double>();
                listRes.Add(point.x);
                listRes.Add(point.y);

                gstd.value res = script.CreateRealArrayValue(listRes);
                return new gstd.value(res);
            }


            // Dx�֐��F�I�u�W�F�N�g����(����)

            // Dx�֐��F�I�u�W�F�N�g����(����)
            public static value Func_Obj_Delete(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                script.CheckRunInMainThread();
                int id = (int)argv[0].as_real();
                script.DeleteObject(id);
                return new value();
            }

            public static value Func_Obj_IsDeleted(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptObjectBase obj = script.GetObjectPointer(id);
                bool res = obj == null;
                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static value Func_Obj_SetVisible(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptObjectBase obj = script.GetObjectPointer(id);
                if (obj == null)
                {
                    return new value();
                }
                obj.bVisible_ = argv[1].as_boolean();
                return new value();
            }

            public static value Func_Obj_IsVisible(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptObjectBase obj = script.GetObjectPointer(id);
                bool res = false;
                if (obj != null)
                {
                    res = obj.bVisible_;
                }
                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static value Func_Obj_SetRenderPriority(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptObjectBase obj = script.GetObjectPointer(id);
                if (obj == null)
                {
                    return new value();
                }
                double pri = argv[1].as_real();
                if (pri < 0)
                {
                    pri = 0;
                }
                else if (pri > 1)
                {
                    pri = 1;
                }
                obj.priRender_ = pri;
                return new value();
            }

            public static value Func_Obj_SetRenderPriorityI(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptObjectBase obj = script.GetObjectPointer(id);
                if (obj == null)
                {
                    return new value();
                }

                int pos = (int)(argv[1].as_real() + 0.5);
                int size = script.GetObjectManager().GetRenderBucketCapacity();
                double pri = (double)pos / (double)(size - 1);

                if (pri < 0)
                {
                    pri = 0;
                }
                else if (pri > 1)
                {
                    pri = 1;
                }
                obj.priRender_ = pri;
                return new value();
            }

            public static gstd.value Func_Obj_GetRenderPriority(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                double res = 0;

                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptObjectBase obj = script.GetObjectPointer(id);
                if (obj != null)
                {
                    res = obj.GetRenderPriority();
                }
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_Obj_GetRenderPriorityI(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                double res = 0;

                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptObjectBase obj = script.GetObjectPointer(id);
                if (obj != null)
                {
                    res = obj.GetRenderPriorityI();
                }
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_Obj_GetValue(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                string key = argv[1].as_string();

                DxScriptObjectBase obj = script.GetObjectPointer(id);
                if (obj == null)
                {
                    return new value();
                }

                gstd.value res = obj.GetObjectValue(key);
                return new gstd.value(res);
            }

            public static gstd.value Func_Obj_GetValueD(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                string key = argv[1].as_string();
                gstd.value def = argv[2];

                DxScriptObjectBase obj = script.GetObjectPointer(id);
                if (obj == null)
                {
                    return new gstd.value(def);
                }

                gstd.value res = def;
                bool bExists = obj.IsObjectValueExists(key);
                if (bExists)
                {
                    res.CopyFrom(obj.GetObjectValue(key));
                }

                return new gstd.value(res);
            }

            public static gstd.value Func_Obj_SetValue(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                string key = argv[1].as_string();
                gstd.value val = argv[2];

                DxScriptObjectBase obj = script.GetObjectPointer(id);
                if (obj == null)
                {
                    return new value();
                }

                obj.SetObjectValue(key, new gstd.value(val));
                return new value();
            }

            public static gstd.value Func_Obj_DeleteValue(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                string key = argv[1].as_string();

                DxScriptObjectBase obj = script.GetObjectPointer(id);
                if (obj == null)
                {
                    return new value();
                }

                obj.DeleteObjectValue(key);
                return new value();
            }

            public static gstd.value Func_Obj_IsValueExists(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                string key = argv[1].as_string();

                DxScriptObjectBase obj = script.GetObjectPointer(id);
                if (obj == null)
                {
                    return new value();
                }

                bool res = obj.IsObjectValueExists(key);
                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static value Func_Obj_GetType(script_machine machine, int argc, value[] argv)
            {
                double res = DxScript.OBJ_INVALID;
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptObjectBase obj = script.GetObjectPointer(id) as DxScriptObjectBase;
                if (obj != null)
                {
                    res = obj.GetObjectType();
                }
                return new value(machine.get_engine().get_real_type(),res);
            }

            // Dx�֐��F�I�u�W�F�N�g����(RenderObject)

            // Dx�֐��F�I�u�W�F�N�g����(RenderObject)
            public static value Func_ObjRender_SetX(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetX(argv[1].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetY(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetY(argv[1].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetZ(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetZ(argv[1].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetPosition(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetX(argv[1].as_real());
                obj.SetY(argv[2].as_real());
                obj.SetZ(argv[3].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetAngleX(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetAngleX(argv[1].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetAngleY(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetAngleY(argv[1].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetAngleZ(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetAngleZ(argv[1].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetAngleXYZ(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetAngleX(argv[1].as_real());
                obj.SetAngleY(argv[2].as_real());
                obj.SetAngleZ(argv[3].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetScaleX(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetScaleX(argv[1].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetScaleY(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetScaleY(argv[1].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetScaleZ(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetScaleZ(argv[1].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetScaleXYZ(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetScaleX(argv[1].as_real());
                obj.SetScaleY(argv[2].as_real());
                obj.SetScaleZ(argv[3].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetColor(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetColor((int)argv[1].as_real(), (int)argv[2].as_real(), (int)argv[3].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetColorHSV(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }

                int hue = (int)argv[1].as_real();
                int sat = (int)argv[2].as_real();
                int val = (int)argv[3].as_real();

                D3DCOLOR color = D3DCOLOR_ARGB(255, 255, 255, 255);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = ColorAccess::SetColorHSV(color, hue, sat, val);
                color.CopyFrom(ColorAccess.SetColorHSV(color, hue, sat, val));

                int red = ColorAccess.GetColorR(new D3DCOLOR(color));
                int green = ColorAccess.GetColorG(color);
                int blue = ColorAccess.GetColorB(color);

                obj.SetColor(red, green, blue);
                return new value();
            }

            public static value Func_ObjRender_SetAlpha(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetAlpha((int)argv[1].as_real());
                return new value();
            }

            public static value Func_ObjRender_SetBlendType(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.typeBlend_ = (int)argv[1].as_real();
                return new value();
            }

            public static value Func_ObjRender_GetX(script_machine machine, int argc, value[] argv)
            {
                double res = 0;
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj != null)
                {
                    res = obj.position_.x;
                }
                return new value(machine.get_engine().get_real_type(),res);
            }

            public static value Func_ObjRender_GetY(script_machine machine, int argc, value[] argv)
            {
                double res = 0;
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj != null)
                {
                    res = obj.position_.y;
                }
                return new value(machine.get_engine().get_real_type(),res);
            }

            public static value Func_ObjRender_GetZ(script_machine machine, int argc, value[] argv)
            {
                double res = 0;
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj != null)
                {
                    res = obj.position_.z;
                }
                return new value(machine.get_engine().get_real_type(),res);
            }

            public static gstd.value Func_ObjRender_GetAngleX(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                double res = 0;
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj != null)
                {
                    res = obj.angle_.x;
                }
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_ObjRender_GetAngleY(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                double res = 0;
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj != null)
                {
                    res = obj.angle_.y;
                }
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_ObjRender_GetAngleZ(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                double res = 0;
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj != null)
                {
                    res = obj.angle_.z;
                }
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_ObjRender_GetScaleX(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                double res = 0;
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj != null)
                {
                    res = obj.scale_.x;
                }
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_ObjRender_GetScaleY(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                double res = 0;
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj != null)
                {
                    res = obj.scale_.y;
                }
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_ObjRender_GetScaleZ(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                double res = 0;
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj != null)
                {
                    res = obj.scale_.z;
                }
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_ObjRender_SetZWrite(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.bZWrite_ = argv[1].as_boolean();
                return new value();
            }

            public static value Func_ObjRender_SetZTest(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.bZTest_ = argv[1].as_boolean();
                return new value();
            }

            public static value Func_ObjRender_SetFogEnable(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.bFogEnable_ = argv[1].as_boolean();
                return new value();
            }

            public static value Func_ObjRender_SetCullingMode(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.modeCulling_ = (int)argv[1].as_boolean();
                return new value();
            }

            public static value Func_ObjRender_SetRalativeObject(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }

                int idRelative = (int)argv[1].as_real();
                string nameBone = argv[2].as_string();
                obj.SetRelativeObject(idRelative, nameBone);
                DxScriptObjectBase objRelative = script.GetObjectPointer(idRelative) as DxScriptObjectBase;
                if (objRelative == null)
                {
                    return new value();
                }

                return new value();
            }

            public static value Func_ObjRender_SetPermitCamera(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                bool bEnable = argv[1].as_boolean();

                DxScriptPrimitiveObject2D obj2D = script.GetObjectPointer(id) as DxScriptPrimitiveObject2D;
                DxScriptTextObject objText = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj2D != null)
                {
                    obj2D.SetPermitCamera(bEnable);
                }
                else if (objText != null)
                {
                    objText.SetPermitCamera(bEnable);
                }

                return new value();
            }

            public static gstd.value Func_ObjRender_GetBlendType(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                int res = 0;
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj != null)
                {
                    res = obj.GetBlendType();
                }
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            // Dx�֐��F�I�u�W�F�N�g����(ShaderObject)

            // Dx�֐��F�I�u�W�F�N�g����(ShaderObject)
            public static gstd.value Func_ObjShader_Create(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                script.CheckRunInMainThread();
                int type = (int)argv[0].as_real();
                ref_count_ptr<DxScriptShaderObject>.unsync obj = new DxScriptShaderObject();

                int id = (int)AnonymousEnum.ID_INVALID;
                if (obj != null)
                {
                    obj.Initialize();
                    obj.manager_ = script.objManager_.GetPointer();
                    id = script.AddObject(new ref_count_ptr<DxScriptShaderObject>.unsync(obj));
                }
                return new value(machine.get_engine().get_real_type(), (double)id);
            }

            public static gstd.value Func_ObjShader_SetShaderF(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_boolean_type(), false);
                }

                bool res = false;
                string path = argv[1].as_string();
                path = PathProperty.GetUnique(path);
                if (false)
                {

                }
                else
                {
                    ref_count_ptr<Shader> shader = new Shader();
                    res = shader.CreateFromFile(path);
                    obj.SetShader(new ref_count_ptr<Shader>(shader));

                    if (!res)
                    {
                        string error = ShaderManager.GetBase().GetLastError();
                        script.RaiseError(error);
                    }
                }

                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static gstd.value Func_ObjShader_SetShaderO(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id1 = (int)argv[0].as_real();
                DxScriptRenderObject obj1 = script.GetObjectPointer(id1) as DxScriptRenderObject;
                if (obj1 == null)
                {
                    return new value(machine.get_engine().get_boolean_type(), false);
                }

                int id2 = (int)argv[1].as_real();
                DxScriptRenderObject obj2 = script.GetObjectPointer(id2) as DxScriptRenderObject;
                if (obj2 == null)
                {
                    return new value(machine.get_engine().get_boolean_type(), false);
                }

                ref_count_ptr<Shader> shader = obj2.GetShader();
                if (shader == null)
                {
                    return new value(machine.get_engine().get_boolean_type(), false);
                }
                obj1.SetShader(new ref_count_ptr<Shader>(shader));

                return new value(machine.get_engine().get_boolean_type(), true);
            }

            public static gstd.value Func_ObjShader_ResetShader(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetShader(null);

                return new value();
            }

            public static gstd.value Func_ObjShader_SetTechnique(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }

                ref_count_ptr<Shader> shader = obj.GetShader();
                if (shader == null)
                {
                    return new value();
                }

                string aPath = StringUtility.ConvertWideToMulti(argv[1].as_string());
                shader.SetTechnique(aPath);

                return new value();
            }

            public static gstd.value Func_ObjShader_SetMatrix(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }

                ref_count_ptr<Shader> shader = obj.GetShader();
                if (shader == null)
                {
                    return new value();
                }

                string name = StringUtility.ConvertWideToMulti(argv[1].as_string());
                gstd.value sMatrix = argv[2];
                type_data.type_kind kind = sMatrix.get_type().get_kind();
                if (kind != type_data.tk_array)
                {
                    return new value();
                }
                int arrayLength = (int)sMatrix.length_as_array();
                if (arrayLength != 16)
                {
                    return new value();
                }

                D3DXMATRIX matrix = new D3DXMATRIX();
                for (int iRow = 0 ; iRow < 4 ; iRow++)
                {
                    for (int iCol = 0 ; iCol < 4 ; iCol++)
                    {
                        int index = iRow * 4 + iCol;
                        value arrayValue = sMatrix.index_as_array((uint)index);
                        float fValue = (float)arrayValue.as_real();
                        matrix.m[iRow][iCol] = fValue;
                    }
                }
                shader.SetMatrix(name, matrix);

                return new value();
            }

            public static gstd.value Func_ObjShader_SetMatrixArray(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }

                ref_count_ptr<Shader> shader = obj.GetShader();
                if (shader == null)
                {
                    return new value();
                }

                string name = StringUtility.ConvertWideToMulti(argv[1].as_string());
                gstd.value array = argv[2];
                type_data.type_kind kind = array.get_type().get_kind();
                if (kind != type_data.tk_array)
                {
                    return new value();
                }

                int dataLength = (int)array.length_as_array();
                List<D3DXMATRIX> listMatrix = new List<D3DXMATRIX>();
                for (int iArray = 0 ; iArray < dataLength ; iArray++)
                {
                    value sMatrix = array.index_as_array((uint)iArray);
                    type_data.type_kind kind = sMatrix.get_type().get_kind();
                    if (kind != type_data.tk_array)
                    {
                        return new value();
                    }
                    int arrayLength = sMatrix.length_as_array();
                    if (arrayLength != 16)
                    {
                        return new value();
                    }

                    D3DXMATRIX matrix = new D3DXMATRIX();
                    for (int iRow = 0 ; iRow < 4 ; iRow++)
                    {
                        for (int iCol = 0 ; iCol < 4 ; iCol++)
                        {
                            int index = iRow * 4 + iCol;
                            value arrayValue = sMatrix.index_as_array(index);
                            float fValue = (float)arrayValue.as_real();
                            matrix.m[iRow][iCol] = fValue;
                        }
                    }
                    listMatrix.Add(matrix);
                }
                shader.SetMatrixArray(name, listMatrix);

                return new value();
            }

            public static gstd.value Func_ObjShader_SetVector(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }

                ref_count_ptr<Shader> shader = obj.GetShader();
                if (shader == null)
                {
                    return new value();
                }

                string name = StringUtility.ConvertWideToMulti(argv[1].as_string());
                D3DXVECTOR4 vect4 = new D3DXVECTOR4();
                vect4.x = (float)argv[2].as_real();
                vect4.y = (float)argv[3].as_real();
                vect4.z = (float)argv[4].as_real();
                vect4.w = (float)argv[5].as_real();
                shader.SetVector(name, vect4);
                return new value();
            }

            public static gstd.value Func_ObjShader_SetFloat(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }

                ref_count_ptr<Shader> shader = obj.GetShader();
                if (shader == null)
                {
                    return new value();
                }

                string name = StringUtility.ConvertWideToMulti(argv[1].as_string());
                float vValue = (float)argv[2].as_real();
                shader.SetFloat(name, vValue);
                return new value();
            }

            public static gstd.value Func_ObjShader_SetFloatArray(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }

                ref_count_ptr<Shader> shader = obj.GetShader();
                if (shader == null)
                {
                    return new value();
                }

                string name = StringUtility.ConvertWideToMulti(argv[1].as_string());
                gstd.value array = argv[2];
                type_data.type_kind kind = array.get_type().get_kind();
                if (kind != type_data.tk_array)
                {
                    return new value();
                }

                int dataLength = (int)array.length_as_array();
                List<float> listFloat = new List<float>();
                for (int iArray = 0 ; iArray < dataLength ; iArray++)
                {
                    value aValue = array.index_as_array((uint)iArray);
                    float fValue = (float)aValue.as_real();
                    listFloat.Add(fValue);
                }
                shader.SetFloatArray(name, listFloat);

                return new value();
            }

            public static gstd.value Func_ObjShader_SetTexture(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
                if (obj == null)
                {
                    return new value();
                }

                ref_count_ptr<Shader> shader = obj.GetShader();
                if (shader == null)
                {
                    return new value();
                }

                string name = StringUtility.ConvertWideToMulti(argv[1].as_string());
                string path = argv[2].as_string();
                path = PathProperty.GetUnique(path);

                if (script.mapTexture_.ContainsKey(path))
                {
                    shader.SetTexture(name, script.mapTexture_[path]);
                }
                else
                {
                    ref_count_ptr<Texture> texture = new Texture();
                    texture.CreateFromFile(path);
                    shader.SetTexture(name, texture);
                }
                return new value();
            }

            // Dx�֐��F�I�u�W�F�N�g����(PrimitiveObject)

            // Dx�֐��F�I�u�W�F�N�g����(PrimitiveObject)
            public static value Func_ObjPrimitive_Create(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                script.CheckRunInMainThread();
                int type = (int)argv[0].as_real();
                ref_count_ptr<DxScriptPrimitiveObject>.unsync obj = new ref_count_ptr<DxScriptPrimitiveObject>.unsync();
                if (type == (int)AnonymousEnum.OBJ_PRIMITIVE_2D)
                {
                    obj = new DxScriptPrimitiveObject2D();
                }
                else if (type == (int)AnonymousEnum.OBJ_SPRITE_2D)
                {
                    obj = new DxScriptSpriteObject2D();
                }
                else if (type == (int)AnonymousEnum.OBJ_SPRITE_LIST_2D)
                {
                    obj = new DxScriptSpriteListObject2D();
                }
                else if (type == (int)AnonymousEnum.OBJ_PRIMITIVE_3D)
                {
                    obj = new DxScriptPrimitiveObject3D();
                }
                else if (type == (int)AnonymousEnum.OBJ_SPRITE_3D)
                {
                    obj = new DxScriptSpriteObject3D();
                }
                else if (type == (int)AnonymousEnum.OBJ_TRAJECTORY_3D)
                {
                    obj = new DxScriptTrajectoryObject3D();
                }

                int id = (int)AnonymousEnum.ID_INVALID;
                if (obj != null)
                {
                    obj.Initialize();
                    obj.manager_ = script.objManager_.GetPointer();
                    id = script.AddObject(new ref_count_ptr<DxScriptPrimitiveObject>.unsync(obj));
                }
                return new value(machine.get_engine().get_real_type(),(double)id);
            }

            public static value Func_ObjPrimitive_SetPrimitiveType(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptPrimitiveObject obj = script.GetObjectPointer(id) as DxScriptPrimitiveObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetPrimitiveType((D3DPRIMITIVETYPE)(int)argv[1].as_real());
                return new value();
            }

            public static value Func_ObjPrimitive_SetVertexCount(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptPrimitiveObject obj = script.GetObjectPointer(id) as DxScriptPrimitiveObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetVertexCount((int)argv[1].as_real());
                return new value();
            }

            public static value Func_ObjPrimitive_SetTexture(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptPrimitiveObject obj = script.GetObjectPointer(id) as DxScriptPrimitiveObject;
                if (obj == null)
                {
                    return new value();
                }

                string path = argv[1].as_string();
                path = PathProperty.GetUnique(path);
                if (script.mapTexture_.ContainsKey(path))
                {
                    obj.SetTexture(new SortedDictionary<string, gstd.ref_count_ptr<Texture>>(script.mapTexture_[path]));
                }
                else
                {
                    ref_count_ptr<Texture> texture = new Texture();
                    texture.CreateFromFile(path);
                    obj.SetTexture(new ref_count_ptr<Texture>(texture));
                }
                return new value();
            }

            public static value Func_ObjPrimitive_GetVertexCount(script_machine machine, int argc, value[] argv)
            {
                double res = 0;
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptPrimitiveObject obj = script.GetObjectPointer(id) as DxScriptPrimitiveObject;
                if (obj != null)
                {
                    res = obj.GetVertexCount();
                }
                return new value(machine.get_engine().get_real_type(),res);
            }

            public static value Func_ObjPrimitive_SetVertexPosition(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptPrimitiveObject obj = script.GetObjectPointer(id) as DxScriptPrimitiveObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetVertexPosition((int)argv[1].as_real(), argv[2].as_real(), argv[3].as_real(), argv[4].as_real());
                return new value();
            }

            public static value Func_ObjPrimitive_SetVertexUV(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptPrimitiveObject obj = script.GetObjectPointer(id) as DxScriptPrimitiveObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetVertexUV((int)argv[1].as_real(), argv[2].as_real(), argv[3].as_real());
                return new value();
            }

            public static gstd.value Func_ObjPrimitive_SetVertexUVT(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptPrimitiveObject obj = script.GetObjectPointer(id) as DxScriptPrimitiveObject;
                if (obj == null)
                {
                    return new value();
                }

                ref_count_ptr<Texture> texture = obj.GetTexture();
                if (texture == null)
                {
                    return new value();
                }

                int width = texture.GetWidth();
                int height = texture.GetHeight();
                obj.SetVertexUV((int)argv[1].as_real(), argv[2].as_real() / (double)width, argv[3].as_real() / (double)height);

                return new value();
            }

            public static value Func_ObjPrimitive_SetVertexColor(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptPrimitiveObject obj = script.GetObjectPointer(id) as DxScriptPrimitiveObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetVertexColor((int)argv[1].as_real(), (int)argv[2].as_real(), (int)argv[3].as_real(), (int)argv[4].as_real());
                return new value();
            }

            public static value Func_ObjPrimitive_SetVertexAlpha(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptPrimitiveObject obj = script.GetObjectPointer(id) as DxScriptPrimitiveObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetVertexAlpha((int)argv[1].as_real(), (int)argv[2].as_real());
                return new value();
            }

            public static value Func_ObjPrimitive_GetVertexPosition(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                int index = (int)argv[1].as_real();

                D3DXVECTOR3 pos = new D3DXVECTOR3(0,0, 0);
                DxScriptPrimitiveObject obj = script.GetObjectPointer(id) as DxScriptPrimitiveObject;
                if (obj != null)
                {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: pos = obj->GetVertexPosition(index);
                    pos.CopyFrom(obj.GetVertexPosition(index));
                }

                List<double> listPos = new List<double>();
                listPos.Resize(3);
                listPos[0] = pos.x;
                listPos[1] = pos.y;
                listPos[2] = pos.z;

                gstd.value res = script.CreateRealArrayValue(listPos);
                return new gstd.value(res);
            }


            // Dx�֐��F�I�u�W�F�N�g����(Sprite2D)

            // Dx�֐��F�I�u�W�F�N�g����(Sprite2D)
            public static value Func_ObjSprite2D_SetSourceRect(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptSpriteObject2D obj = script.GetObjectPointer(id) as DxScriptSpriteObject2D;
                if (obj == null)
                {
                    return new value();
                }

                RECT_D rcDest = new RECT_D() { left = (double)argv[1].as_real(), top = (double)argv[2].as_real(), right = (double)argv[3].as_real(), bottom = (double)argv[4].as_real() };
                obj.GetSpritePointer().SetSourceRect(rcDest);

                return new value();
            }

            public static value Func_ObjSprite2D_SetDestRect(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptSpriteObject2D obj = script.GetObjectPointer(id) as DxScriptSpriteObject2D;
                if (obj == null)
                {
                    return new value();
                }

                RECT_D rcDest = new RECT_D() { left = (double)argv[1].as_real(), top = (double)argv[2].as_real(), right = (double)argv[3].as_real(), bottom = (double)argv[4].as_real() };
                obj.GetSpritePointer().SetDestinationRect(rcDest);

                return new value();
            }

            public static value Func_ObjSprite2D_SetDestCenter(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptSpriteObject2D obj = script.GetObjectPointer(id) as DxScriptSpriteObject2D;
                if (obj == null)
                {
                    return new value();
                }

                obj.GetSpritePointer().SetDestinationCenter();

                return new value();
            }

            // Dx�֐��F�I�u�W�F�N�g����(SpriteList2D)

            // Dx�֐��F�I�u�W�F�N�g����(SpriteList2D)
            public static gstd.value Func_ObjSpriteList2D_SetSourceRect(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptSpriteListObject2D obj = script.GetObjectPointer(id) as DxScriptSpriteListObject2D;
                if (obj == null)
                {
                    return new value();
                }

                RECT_D rcDest = new RECT_D() { left = (double)argv[1].as_real(), top = (double)argv[2].as_real(), right = (double)argv[3].as_real(), bottom = (double)argv[4].as_real() };
                obj.GetSpritePointer().SetSourceRect(rcDest);

                return new value();
            }

            public static gstd.value Func_ObjSpriteList2D_SetDestRect(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptSpriteListObject2D obj = script.GetObjectPointer(id) as DxScriptSpriteListObject2D;
                if (obj == null)
                {
                    return new value();
                }

                RECT_D rcDest = new RECT_D() { left = (double)argv[1].as_real(), top = (double)argv[2].as_real(), right = (double)argv[3].as_real(), bottom = (double)argv[4].as_real() };
                obj.GetSpritePointer().SetDestinationRect(rcDest);

                return new value();
            }

            public static gstd.value Func_ObjSpriteList2D_SetDestCenter(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptSpriteListObject2D obj = script.GetObjectPointer(id) as DxScriptSpriteListObject2D;
                if (obj == null)
                {
                    return new value();
                }

                obj.GetSpritePointer().SetDestinationCenter();

                return new value();
            }

            public static gstd.value Func_ObjSpriteList2D_AddVertex(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptSpriteListObject2D obj = script.GetObjectPointer(id) as DxScriptSpriteListObject2D;
                if (obj == null)
                {
                    return new value();
                }

                obj.AddVertex();

                return new value();
            }

            public static gstd.value Func_ObjSpriteList2D_CloseVertex(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptSpriteListObject2D obj = script.GetObjectPointer(id) as DxScriptSpriteListObject2D;
                if (obj == null)
                {
                    return new value();
                }

                obj.CloseVertex();

                return new value();
            }

            public static gstd.value Func_ObjSpriteList2D_ClearVertexCount(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptSpriteListObject2D obj = script.GetObjectPointer(id) as DxScriptSpriteListObject2D;
                if (obj == null)
                {
                    return new value();
                }

                obj.GetSpritePointer().ClearVertexCount();

                return new value();
            }

            // Dx�֐��F�I�u�W�F�N�g����(Sprite3D)

            // Dx�֐��F�I�u�W�F�N�g����(Sprite3D)
            public static value Func_ObjSprite3D_SetSourceRect(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptSpriteObject3D obj = script.GetObjectPointer(id) as DxScriptSpriteObject3D;
                if (obj == null)
                {
                    return new value();
                }

                RECT_D rcSrc = new RECT_D() { left = (double)argv[1].as_real(), top = (double)argv[2].as_real(), right = (double)argv[3].as_real(), bottom = (double)argv[4].as_real() };
                obj.GetSpritePointer().SetSourceRect(rcSrc);

                return new value();
            }

            public static value Func_ObjSprite3D_SetDestRect(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptSpriteObject3D obj = script.GetObjectPointer(id) as DxScriptSpriteObject3D;
                if (obj == null)
                {
                    return new value();
                }

                RECT_D rcDest = new RECT_D() { left = (double)argv[1].as_real(), top = (double)argv[2].as_real(), right = (double)argv[3].as_real(), bottom = (double)argv[4].as_real() };
                obj.GetSpritePointer().SetDestinationRect(rcDest);

                return new value();
            }

            public static value Func_ObjSprite3D_SetSourceDestRect(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptSpriteObject3D obj = script.GetObjectPointer(id) as DxScriptSpriteObject3D;
                if (obj == null)
                {
                    return new value();
                }

                RECT_D rcSrc = new RECT_D() { left = (double)argv[1].as_real(), top = (double)argv[2].as_real(), right = (double)argv[3].as_real(), bottom = (double)argv[4].as_real() };
                obj.GetSpritePointer().SetSourceDestRect(rcSrc);
                return new value();
            }

            public static value Func_ObjSprite3D_SetBillboard(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptSpriteObject3D obj = script.GetObjectPointer(id) as DxScriptSpriteObject3D;
                if (obj == null)
                {
                    return new value();
                }

                bool bEnable = argv[1].as_boolean();
                obj.GetSpritePointer().SetBillboardEnable(bEnable);

                return new value();
            }

            // Dx�֐��F�I�u�W�F�N�g����(TrajectoryObject3D)
            // Dx�֐��F�I�u�W�F�N�g����(TrajectoryObject3D)
            public static value Func_ObjTrajectory3D_SetInitialPoint(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTrajectoryObject3D obj = script.GetObjectPointer(id) as DxScriptTrajectoryObject3D;
                if (obj == null)
                {
                    return new value();
                }

                D3DXVECTOR3 pos1 = new D3DXVECTOR3(argv[1].as_real(), argv[2].as_real(), argv[3].as_real());
                D3DXVECTOR3 pos2 = new D3DXVECTOR3(argv[4].as_real(), argv[5].as_real(), argv[6].as_real());
                obj.GetObjectPointer().SetInitialLine(new D3DXVECTOR3(pos1), new D3DXVECTOR3(pos2));

                return new value();
            }

            public static value Func_ObjTrajectory3D_SetAlphaVariation(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTrajectoryObject3D obj = script.GetObjectPointer(id) as DxScriptTrajectoryObject3D;
                if (obj == null)
                {
                    return new value();
                }

                obj.GetObjectPointer().SetAlphaVariation(argv[1].as_real());

                return new value();
            }

            public static value Func_ObjTrajectory3D_SetComplementCount(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTrajectoryObject3D obj = script.GetObjectPointer(id) as DxScriptTrajectoryObject3D;
                if (obj == null)
                {
                    return new value();
                }

                obj.GetObjectPointer().SetComplementCount((int)argv[1].as_real());

                return new value();
            }

            // Dx�֐��F�I�u�W�F�N�g����(DxMesh)

            // Dx�֐��F�I�u�W�F�N�g����(DxMesh)
            public static value Func_ObjMesh_Create(script_machine machine, int argc, value argv)
            {
                DxScript script = (DxScript)machine.data;
                ref_count_ptr<DxScriptMeshObject>.unsync obj = new DxScriptMeshObject();
                int id = (int)AnonymousEnum.ID_INVALID;
                if (obj != null)
                {
                    id = script.AddObject(new ref_count_ptr<DxScriptMeshObject>.unsync(obj));
                }
                return new value(machine.get_engine().get_real_type(),(double)id);
            }

            public static value Func_ObjMesh_Load(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptMeshObject obj = script.GetObjectPointer(id) as DxScriptMeshObject;
                if (obj == null)
                {
                    return new value();
                }

                ref_count_ptr<DxMesh> mesh = new ref_count_ptr<DxMesh>();
                string path = argv[1].as_string();
                path = PathProperty.GetUnique(path);
                string ext = PathProperty.GetFileExtension(path);

                bool res = false;
                if (ext == ".mqo")
                {
                    mesh = new MetasequoiaMesh();
                    res = mesh.CreateFromFile(path);
                }
                else if (ext == ".elem")
                {
                    mesh = new ElfreinaMesh();
                    res = mesh.CreateFromFile(path);
                }
                if (res)
                {
                    obj.mesh_ = mesh;
                    // script->AddMeshResource(path, mesh);
                }
                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static value Func_ObjMesh_SetColor(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptMeshObject obj = script.GetObjectPointer(id) as DxScriptMeshObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetColor((int)argv[1].as_real(), (int)argv[2].as_real(), (int)argv[3].as_real());
                return new value();
            }

            public static value Func_ObjMesh_SetAlpha(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptMeshObject obj = script.GetObjectPointer(id) as DxScriptMeshObject;
                if (obj == null)
                {
                    return new value();
                }
                obj.SetAlpha((int)argv[1].as_real());
                return new value();
            }

            public static value Func_ObjMesh_SetAnimation(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptMeshObject obj = script.GetObjectPointer(id) as DxScriptMeshObject;
                if (obj == null)
                {
                    return new value();
                }

                string anime = argv[1].as_string();
                obj.anime_ = anime;
                obj.time_ = (int)argv[2].as_real();

            // 	D3DXMATRIX mat = obj->mesh_->GetAnimationMatrix(anime, obj->time_, "�I�v�O��");
            // 	D3DXVECTOR3 pos;
            // 	D3DXVec3TransformCoord(&pos, &D3DXVECTOR3(0,0,0), &mat);
                return new value();
            }

            public static gstd.value Func_ObjMesh_SetCoordinate2D(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptMeshObject obj = script.GetObjectPointer(id) as DxScriptMeshObject;
                if (obj == null)
                {
                    return new value();
                }

                bool bEnable = argv[1].as_boolean();
                obj.bCoordinate2D_ = bEnable;
                return new value();
            }

            public static value Func_ObjMesh_GetPath(script_machine machine, int argc, value[] argv)
            {
                string res;
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptMeshObject obj = script.GetObjectPointer(id) as DxScriptMeshObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_string_type(), res);
                }
                DxMesh mesh = obj.mesh_.GetPointer();
                if (mesh == null)
                {
                    return new value(machine.get_engine().get_string_type(), res);
                }
                res = mesh.GetPath();
                return new value(machine.get_engine().get_string_type(), res);
            }

            // Dx�֐��F�e�L�X�g����(DxText)

            // Dx�֐��F�I�u�W�F�N�g����(DxText)
            public static value Func_ObjText_Create(script_machine machine, int argc, value argv)
            {
                DxScript script = (DxScript)machine.data;
                ref_count_ptr<DxScriptTextObject>.unsync obj = new DxScriptTextObject();
                int id = (int)AnonymousEnum.ID_INVALID;
                if (obj != null)
                {
                    id = script.AddObject(new ref_count_ptr<DxScriptTextObject>.unsync(obj));
                }
                return new value(machine.get_engine().get_real_type(),(double)id);
            }

            public static value Func_ObjText_SetText(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                string wstr = argv[1].as_string();
                obj.SetText(wstr);
                return new value();
            }

            public static value Func_ObjText_SetFontType(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                string wstr = argv[1].as_string();
                obj.SetFontType(wstr);
                return new value();
            }

            public static value Func_ObjText_SetFontSize(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                int size = (int)argv[1].as_real();
                obj.SetFontSize(size);
                return new value();
            }

            public static value Func_ObjText_SetFontBold(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                bool bBold = argv[1].as_boolean();
                obj.SetFontBold(bBold);
                return new value();
            }

            public static value Func_ObjText_SetFontColorTop(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                int r = (int)argv[1].as_real();
                int g = (int)argv[2].as_real();
                int b = (int)argv[3].as_real();
                obj.SetFontColorTop(r, g, b);
                return new value();
            }

            public static value Func_ObjText_SetFontColorBottom(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                int r = (int)argv[1].as_real();
                int g = (int)argv[2].as_real();
                int b = (int)argv[3].as_real();
                obj.SetFontColorBottom(r, g, b);
                return new value();
            }

            public static value Func_ObjText_SetFontBorderWidth(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                int width = (int)argv[1].as_real();
                obj.SetFontBorderWidth(width);
                return new value();
            }

            public static value Func_ObjText_SetFontBorderType(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                int type = (int)argv[1].as_real();
                obj.SetFontBorderType(type);
                return new value();
            }

            public static value Func_ObjText_SetFontBorderColor(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                int r = (int)argv[1].as_real();
                int g = (int)argv[2].as_real();
                int b = (int)argv[3].as_real();
                obj.SetFontBorderColor(r, g, b);
                return new value();
            }

            public static value Func_ObjText_SetMaxWidth(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                int width = (int)argv[1].as_real();
                obj.SetMaxWidth(width);
                return new value();
            }

            public static value Func_ObjText_SetMaxHeight(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                int height = (int)argv[1].as_real();
                obj.SetMaxHeight(height);
                return new value();
            }

            public static value Func_ObjText_SetLinePitch(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                int pitch = (int)argv[1].as_real();
                obj.SetLinePitch(pitch);
                return new value();
            }

            public static value Func_ObjText_SetSidePitch(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                int pitch = (int)argv[1].as_real();
                obj.SetSidePitch(pitch);
                return new value();
            }

            public static value Func_ObjText_SetVertexColor(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                int a = (int)argv[1].as_real();
                int r = (int)argv[2].as_real();
                int g = (int)argv[3].as_real();
                int b = (int)argv[4].as_real();
                obj.SetVertexColor(D3DCOLOR_ARGB(a, r, g, b));
                return new value();
            }

            public static gstd.value Func_ObjText_SetTransCenter(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                double centerX = argv[1].as_real();
                double centerY = argv[2].as_real();

                obj.center_ = D3DXVECTOR2(centerX, centerY);

                return new value();
            }

            public static gstd.value Func_ObjText_SetAutoTransCenter(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                bool bAutoCenter = argv[1].as_boolean();

                obj.bAutoCenter_ = bAutoCenter;

                return new value();
            }

            public static gstd.value Func_ObjText_SetHorizontalAlignment(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                int align = (int)argv[1].as_real();

                obj.SetHorizontalAlignment(align);

                return new value();
            }

            public static gstd.value Func_ObjText_SetSyntacticAnalysis(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                bool bEnable = argv[1].as_boolean();

                obj.SetSyntacticAnalysis(bEnable);

                return new value();
            }

            public static value Func_ObjText_GetTextLength(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                string text = obj.GetText();
                int res = StringUtility.CountAsciiSizeCharacter(text);
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            public static value Func_ObjText_GetTextLengthCU(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                List<int> listCount = obj.GetTextCountCU();
                int res = 0;
                for (int iLine = 0 ; iLine < listCount.Count ; iLine++)
                {
                    int count = listCount[iLine];
                    res += count;
                }
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            public static value Func_ObjText_GetTextLengthCUL(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }
                List<int> listCount = obj.GetTextCountCU();
                List<double> listCountD = new List<double>();
                for (int iLine = 0 ; iLine < listCount.Count ; iLine++)
                {
                    int count = listCount[iLine];
                    listCountD.Add(count);
                }

                gstd.value res = script.CreateRealArrayValue(listCountD);
                return new gstd.value(res);
            }

            public static value Func_ObjText_GetTotalWidth(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }

                int res = obj.GetTotalWidth();
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            public static value Func_ObjText_GetTotalHeight(script_machine machine, int argc, value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxScriptTextObject obj = script.GetObjectPointer(id) as DxScriptTextObject;
                if (obj == null)
                {
                    return new value();
                }

                int res = obj.GetTotalHeight();
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            // Dx�֐��F��������(DxSoundObject)

            // Dx�֐��F��������(DxSoundObject)
            public static gstd.value Func_ObjSound_Create(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DxScript script = (DxScript)machine.data;
                DirectSoundManager manager = DirectSoundManager.GetBase();

                ref_count_ptr<DxSoundObject>.unsync obj = new DxSoundObject();
                int id = script.AddObject(new ref_count_ptr<DxSoundObject>.unsync(obj));
                return new value(machine.get_engine().get_real_type(), (double)id);
            }

            public static gstd.value Func_ObjSound_Load(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxSoundObject obj = script.GetObjectPointer(id) as DxSoundObject;
                if (obj == null)
                {
                    return new value();
                }

                string path = argv[1].as_string();
                path = PathProperty.GetUnique(path);
                bool bLoad = obj.Load(path);

                return new value(machine.get_engine().get_boolean_type(), bLoad);
            }

            public static gstd.value Func_ObjSound_Play(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxSoundObject obj = script.GetObjectPointer(id) as DxSoundObject;
                if (obj == null)
                {
                    return new value();
                }
                ref_count_ptr<SoundPlayer> player = obj.GetPlayer();
                if (player == null)
                {
                    return new value();
                }

                // obj->Play();
                script.GetObjectManager().ReserveSound(player, obj.GetStyle());
                return new value();
            }

            public static gstd.value Func_ObjSound_Stop(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxSoundObject obj = script.GetObjectPointer(id) as DxSoundObject;
                if (obj == null)
                {
                    return new value();
                }
                ref_count_ptr<SoundPlayer> player = obj.GetPlayer();
                if (player == null)
                {
                    return new value();
                }

                player.Stop();
                script.GetObjectManager().DeleteReservedSound(player);

                return new value();
            }

            public static gstd.value Func_ObjSound_SetVolumeRate(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxSoundObject obj = script.GetObjectPointer(id) as DxSoundObject;
                if (obj == null)
                {
                    return new value();
                }
                ref_count_ptr<SoundPlayer> player = obj.GetPlayer();
                if (player == null)
                {
                    return new value();
                }

                double rate = argv[1].as_real();
                player.SetVolumeRate(rate);

                return new value();
            }

            public static gstd.value Func_ObjSound_SetPanRate(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxSoundObject obj = script.GetObjectPointer(id) as DxSoundObject;
                if (obj == null)
                {
                    return new value();
                }
                ref_count_ptr<SoundPlayer> player = obj.GetPlayer();
                if (player == null)
                {
                    return new value();
                }

                double rate = argv[1].as_real();
                player.SetPanRate(rate);

                return new value();
            }

            public static gstd.value Func_ObjSound_SetFade(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxSoundObject obj = script.GetObjectPointer(id) as DxSoundObject;
                if (obj == null)
                {
                    return new value();
                }
                ref_count_ptr<SoundPlayer> player = obj.GetPlayer();
                if (player == null)
                {
                    return new value();
                }

                double fade = argv[1].as_real();
                player.SetFade(fade);

                return new value();
            }

            public static gstd.value Func_ObjSound_SetLoopEnable(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxSoundObject obj = script.GetObjectPointer(id) as DxSoundObject;
                if (obj == null)
                {
                    return new value();
                }
                ref_count_ptr<SoundPlayer> player = obj.GetPlayer();
                if (player == null)
                {
                    return new value();
                }

                bool bLoop = (bool)argv[1].as_boolean();
                SoundPlayer.PlayStyle style = obj.GetStyle();
                style.SetLoopEnable(bLoop);

                return new value();
            }

            public static gstd.value Func_ObjSound_SetLoopTime(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxSoundObject obj = script.GetObjectPointer(id) as DxSoundObject;
                if (obj == null)
                {
                    return new value();
                }
                ref_count_ptr<SoundPlayer> player = obj.GetPlayer();
                if (player == null)
                {
                    return new value();
                }

                double startTime = argv[1].as_real();
                double endTime = argv[2].as_real();
                SoundPlayer.PlayStyle style = obj.GetStyle();
                style.SetLoopStartTime(startTime);
                style.SetLoopEndTime(endTime);

                return new value();
            }

            public static gstd.value Func_ObjSound_SetLoopSampleCount(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxSoundObject obj = script.GetObjectPointer(id) as DxSoundObject;
                if (obj == null)
                {
                    return new value();
                }
                ref_count_ptr<SoundPlayer> player = obj.GetPlayer();
                if (player == null)
                {
                    return new value();
                }

                double startSample = argv[1].as_real();
                double endSample = argv[2].as_real();

                WAVEFORMATEX fmt = obj.GetPlayer().GetWaveFormat();
                double startTime = startSample / (double)fmt.nSamplesPerSec;
                double endTime = endSample / (double)fmt.nSamplesPerSec;
                SoundPlayer.PlayStyle style = obj.GetStyle();
                style.SetLoopStartTime(startTime);
                style.SetLoopEndTime(endTime);

                return new value();
            }

            public static gstd.value Func_ObjSound_SetRestartEnable(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxSoundObject obj = script.GetObjectPointer(id) as DxSoundObject;
                if (obj == null)
                {
                    return new value();
                }
                ref_count_ptr<SoundPlayer> player = obj.GetPlayer();
                if (player == null)
                {
                    return new value();
                }

                bool bRestart = (bool)argv[1].as_boolean();
                SoundPlayer.PlayStyle style = obj.GetStyle();
                style.SetRestart(bRestart);

                return new value();
            }

            public static gstd.value Func_ObjSound_SetSoundDivision(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxSoundObject obj = script.GetObjectPointer(id) as DxSoundObject;
                if (obj == null)
                {
                    return new value();
                }
                ref_count_ptr<SoundPlayer> player = obj.GetPlayer();
                if (player == null)
                {
                    return new value();
                }

                int div = (int)argv[1].as_real();
                player.SetSoundDivision(div);

                return new value();
            }

            public static gstd.value Func_ObjSound_IsPlaying(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxSoundObject obj = script.GetObjectPointer(id) as DxSoundObject;
                if (obj == null)
                {
                    return new value();
                }
                ref_count_ptr<SoundPlayer> player = obj.GetPlayer();
                if (player == null)
                {
                    return new value(machine.get_engine().get_boolean_type(), false);
                }

                bool bPlay = player.IsPlaying();

                return new value(machine.get_engine().get_boolean_type(), bPlay);
            }

            public static gstd.value Func_ObjSound_GetVolumeRate(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxSoundObject obj = script.GetObjectPointer(id) as DxSoundObject;
                if (obj == null)
                {
                    return new value();
                }
                ref_count_ptr<SoundPlayer> player = obj.GetPlayer();
                if (player == null)
                {
                    return new value(machine.get_engine().get_real_type(), (double)0);
                }

                double rate = player.GetVolumeRate();

                return new value(machine.get_engine().get_real_type(), (double)rate);
            }

            // Dx�֐��F�t�@�C������(DxFileObject)

            // Dx�֐��F�t�@�C������(DxFileObject)
            public static gstd.value Func_ObjFile_Create(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
            // 	script->CheckRunInMainThread();
                int type = (int)argv[0].as_real();
                ref_count_ptr<DxFileObject>.unsync obj = new ref_count_ptr<DxFileObject>.unsync();
                if (type == (int)AnonymousEnum.OBJ_FILE_TEXT)
                {
                    obj = new DxTextFileObject();
                }
                else if (type == (int)AnonymousEnum.OBJ_FILE_BINARY)
                {
                    obj = new DxBinaryFileObject();
                }

                int id = (int)AnonymousEnum.ID_INVALID;
                if (obj != null)
                {
                    obj.Initialize();
                    obj.manager_ = script.objManager_.GetPointer();
                    id = script.AddObject(new ref_count_ptr<DxFileObject>.unsync(obj));
                }
                return new value(machine.get_engine().get_real_type(), (double)id);
            }

            public static gstd.value Func_ObjFile_Open(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxFileObject obj = script.GetObjectPointer(id) as DxFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_boolean_type(), false);
                }

                string path = argv[1].as_string();
                path = PathProperty.GetUnique(path);
                bool res = obj.OpenR(path);

                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static gstd.value Func_ObjFile_OpenNW(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxFileObject obj = script.GetObjectPointer(id) as DxFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_boolean_type(), false);
                }

                string path = argv[1].as_string();
                path = PathProperty.GetUnique(path);
                bool res = obj.OpenW(path);

                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static gstd.value Func_ObjFile_Store(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxFileObject obj = script.GetObjectPointer(id) as DxFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_boolean_type(), false);
                }

                bool res = obj.Store();
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            public static gstd.value Func_ObjFile_GetSize(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxFileObject obj = script.GetObjectPointer(id) as DxFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_real_type(), (double)0);
                }

                gstd.ref_count_ptr<File> file = obj.GetFile();
                int res = file != null ? file.GetSize() : 0;
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            // Dx�֐��F�t�@�C������(DxTextFileObject)

            // Dx�֐��F�t�@�C������(DxTextFileObject)
            public static gstd.value Func_ObjFileT_GetLineCount(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxTextFileObject obj = script.GetObjectPointer(id) as DxTextFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_real_type(), (double)0);
                }

                int res = obj.GetLineCount();
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            public static gstd.value Func_ObjFileT_GetLineText(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxTextFileObject obj = script.GetObjectPointer(id) as DxTextFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_string_type(), new string());
                }

                int pos = (int)argv[1].as_real();
                string line = obj.GetLine(pos);
                string res = to_wide(line);
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static gstd.value Func_ObjFileT_SplitLineText(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxTextFileObject obj = script.GetObjectPointer(id) as DxTextFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_string_type(), new string());
                }

                int pos = (int)argv[1].as_real();
                string delim = to_mbcs(argv[2].as_string());
                string line = obj.GetLine(pos);
                List<string> list = StringUtility.Split(line, delim);

                gstd.value res = script.CreateStringArrayValue(list);
                return new gstd.value(res);
            }

            public static gstd.value Func_ObjFileT_AddLine(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxTextFileObject obj = script.GetObjectPointer(id) as DxTextFileObject;
                if (obj == null)
                {
                    return new value();
                }

                string str = to_mbcs(argv[1].as_string());
                obj.AddLine(str);
                return new value();
            }

            public static gstd.value Func_ObjFileT_ClearLine(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxTextFileObject obj = script.GetObjectPointer(id) as DxTextFileObject;
                if (obj == null)
                {
                    return new value();
                }

                obj.ClearLine();
                return new value();
            }

            // Dx�֐��F�t�@�C������(DxBinalyFileObject)

            // Dx�֐��F�t�@�C������(DxBinalyFileObject)
            public static gstd.value Func_ObjFileB_SetByteOrder(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxBinaryFileObject obj = script.GetObjectPointer(id) as DxBinaryFileObject;
                if (obj == null)
                {
                    return new gstd.value();
                }

                int order = (int)argv[1].as_real();
                obj.SetByteOrder(order);
                return new gstd.value();
            }

            public static gstd.value Func_ObjFileB_SetCharacterCode(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxBinaryFileObject obj = script.GetObjectPointer(id) as DxBinaryFileObject;
                if (obj == null)
                {
                    return new gstd.value();
                }

                uint code = (uint)argv[1].as_real();
                obj.SetCodePage(code);
                return new gstd.value();
            }

            public static gstd.value Func_ObjFileB_GetPointer(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxBinaryFileObject obj = script.GetObjectPointer(id) as DxBinaryFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_real_type(), (double) - 1);
                }

                gstd.ref_count_ptr<gstd.ByteBuffer> buffer = obj.GetBuffer();
                double res = buffer.GetOffset();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_ObjFileB_Seek(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxBinaryFileObject obj = script.GetObjectPointer(id) as DxBinaryFileObject;
                if (obj == null)
                {
                    return new gstd.value();
                }

                int pos = (int)argv[1].as_real();
                gstd.ref_count_ptr<gstd.ByteBuffer> buffer = obj.GetBuffer();
                buffer.Seek(pos);
                return new gstd.value();
            }

            public static gstd.value Func_ObjFileB_ReadBoolean(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxBinaryFileObject obj = script.GetObjectPointer(id) as DxBinaryFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_real_type(), (double) - 1);
                }
                if (!obj.IsReadableSize(1))
                {
                    script.RaiseError(gstd.ErrorUtility.GetErrorMessage(ErrorUtility.ERROR_END_OF_FILE));
                }

                gstd.ref_count_ptr<gstd.ByteBuffer> buffer = obj.GetBuffer();
                bool res = buffer.ReadBoolean();
                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static gstd.value Func_ObjFileB_ReadByte(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxBinaryFileObject obj = script.GetObjectPointer(id) as DxBinaryFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_real_type(), (double) - 1);
                }
                if (!obj.IsReadableSize(1))
                {
                    script.RaiseError(gstd.ErrorUtility.GetErrorMessage(ErrorUtility.ERROR_END_OF_FILE));
                }

                gstd.ref_count_ptr<gstd.ByteBuffer> buffer = obj.GetBuffer();
                double res = buffer.ReadCharacter();
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_ObjFileB_ReadShort(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxBinaryFileObject obj = script.GetObjectPointer(id) as DxBinaryFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_real_type(), (double)0);
                }
                if (!obj.IsReadableSize(2))
                {
                    script.RaiseError(gstd.ErrorUtility.GetErrorMessage(ErrorUtility.ERROR_END_OF_FILE));
                }

                gstd.ref_count_ptr<gstd.ByteBuffer> buffer = obj.GetBuffer();
                short bv = buffer.ReadShort();
                if (obj.GetByteOrder() == ByteOrder.ENDIAN_BIG)
                {
                    ByteOrder.Reverse(bv, sizeof(short));
                }

                double res = bv;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_ObjFileB_ReadInteger(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxBinaryFileObject obj = script.GetObjectPointer(id) as DxBinaryFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_real_type(), (double) - 1);
                }
                if (!obj.IsReadableSize(4))
                {
                    script.RaiseError(gstd.ErrorUtility.GetErrorMessage(ErrorUtility.ERROR_END_OF_FILE));
                }

                gstd.ref_count_ptr<gstd.ByteBuffer> buffer = obj.GetBuffer();
                int bv = buffer.ReadInteger();
                if (obj.GetByteOrder() == ByteOrder.ENDIAN_BIG)
                {
                    ByteOrder.Reverse(bv, sizeof(int));
                }

                double res = bv;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_ObjFileB_ReadLong(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxBinaryFileObject obj = script.GetObjectPointer(id) as DxBinaryFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_real_type(), (double) - 1);
                }
                if (!obj.IsReadableSize(8))
                {
                    script.RaiseError(gstd.ErrorUtility.GetErrorMessage(ErrorUtility.ERROR_END_OF_FILE));
                }

                gstd.ref_count_ptr<gstd.ByteBuffer> buffer = obj.GetBuffer();
                _int64 bv = buffer.ReadInteger64();
                if (obj.GetByteOrder() == ByteOrder.ENDIAN_BIG)
                {
                    ByteOrder.Reverse(bv, sizeof(_int64));
                }
                double res = bv;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_ObjFileB_ReadFloat(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxBinaryFileObject obj = script.GetObjectPointer(id) as DxBinaryFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_real_type(), (double) - 1);
                }
                if (!obj.IsReadableSize(4))
                {
                    script.RaiseError(gstd.ErrorUtility.GetErrorMessage(ErrorUtility.ERROR_END_OF_FILE));
                }

                gstd.ref_count_ptr<gstd.ByteBuffer> buffer = obj.GetBuffer();
                double res = 0;
                if (obj.GetByteOrder() == ByteOrder.ENDIAN_BIG)
                {
                    int bv = buffer.ReadInteger();
                    ByteOrder.Reverse(bv, sizeof(int));
                    res = (float)bv;
                }
                else
                {
                    res = buffer.ReadFloat();
                }
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_ObjFileB_ReadDouble(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxBinaryFileObject obj = script.GetObjectPointer(id) as DxBinaryFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_real_type(), (double) - 1);
                }
                if (!obj.IsReadableSize(8))
                {
                    script.RaiseError(gstd.ErrorUtility.GetErrorMessage(ErrorUtility.ERROR_END_OF_FILE));
                }

                gstd.ref_count_ptr<gstd.ByteBuffer> buffer = obj.GetBuffer();
                double res = 0;
                if (obj.GetByteOrder() == ByteOrder.ENDIAN_BIG)
                {
                    _int64 bv = buffer.ReadInteger64();
                    ByteOrder.Reverse(bv, sizeof(_int64));
                    res = (double)bv;
                }
                else
                {
                    res = buffer.ReadDouble();
                }
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static gstd.value Func_ObjFileB_ReadString(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScript script = (DxScript)machine.data;
                int id = (int)argv[0].as_real();
                DxBinaryFileObject obj = script.GetObjectPointer(id) as DxBinaryFileObject;
                if (obj == null)
                {
                    return new value(machine.get_engine().get_string_type(), new string());
                }

                int readSize = (int)argv[1].as_real();
                if (!obj.IsReadableSize(readSize))
                {
                    script.RaiseError(gstd.ErrorUtility.GetErrorMessage(ErrorUtility.ERROR_END_OF_FILE));
                }

                ref_count_ptr<gstd.ByteBuffer> data = new gstd.ByteBuffer();
                data.SetSize(readSize);

                gstd.ref_count_ptr<gstd.ByteBuffer> buffer = obj.GetBuffer();
                buffer.Read(data.GetPointer(), readSize);

                string res;
                int code = (int)obj.GetCodePage();
                if (code == (int)AnonymousEnum.CODE_ACP || code == (int)AnonymousEnum.CODE_UTF8)
                {
                    string str;
                    str.resize(readSize);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                    memcpy(str[0], data.GetPointer(), readSize);

                    if (code == (int)AnonymousEnum.CODE_UTF8)
                    {
                        string wstr = StringUtility.ConvertMultiToWide(str, code);
                        str = StringUtility.ConvertWideToMulti(wstr, CP_ACP);
                    }
                    res = to_wide(str);
                }
                else if (code == (int)AnonymousEnum.CODE_UTF16LE || code == (int)AnonymousEnum.CODE_UTF16BE)
                {
                    int strSize = readSize / 2 * 2;
                    int wsize = strSize / 2;
                    if (code == (int)AnonymousEnum.CODE_UTF16BE)
                    {
                        char[] pt = data.GetPointer();
                        for (int iChar = 0 ; iChar < wsize ; iChar++)
                        {
                            int pos = iChar * 2;
                            char temp = pt[pos];
                            pt[pos] = pt[pos + 1];
                            pt[pos + 1] = temp;
                        }
                    }
                    res.resize(wsize);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                    memcpy(res[0], data.GetPointer(), readSize);

                    string str = StringUtility.ConvertWideToMulti(res);
                    res = to_wide(str);
                }

                return new value(machine.get_engine().get_string_type(), res);
            }
    }
}