using Directx.Util;
using Directx.Shader;

namespace Directx.DxScript
{
    public abstract class DxScriptRenderObject : DxScriptObjectBase
    {
        protected bool bZWrite;
        protected bool bZTest;
        protected bool bFogEnable;
        //protected int modeCulling;
        protected D3DXVECTOR3 position = new D3DXVECTOR3(); // �ړ�����W
        protected D3DXVECTOR3 angle = new D3DXVECTOR3(); // ��]�p�x
        protected D3DXVECTOR3 scale = new D3DXVECTOR3(); // �g�嗦
        protected BlendType typeBlend;
        protected int idRelative;
        protected string nameRelativeBone = "";
        public DxScriptRenderObject()
        {
            bZWrite = false;
            bZTest = false;
            bFogEnable = false;
            typeBlend = BlendType.MODE_BLEND_ALPHA;
            //modeCulling = D3DCULL_NONE;
            position = new D3DXVECTOR3(0.0f, 0.0f, 0.0f);
            angle = new D3DXVECTOR3(0.0f, 0.0f, 0.0f);
            scale = new D3DXVECTOR3(1.0f, 1.0f, 1.0f);
        }
        public virtual void SetX(float x)
        {
            position.x = x;
        }
        public virtual void SetY(float y)
        {
            position.y = y;
        }
        public virtual void SetZ(float z)
        {
            position.z = z;
        }
        public virtual void SetAngleX(float x)
        {
            angle.x = x;
        }
        public virtual void SetAngleY(float y)
        {
            angle.y = y;
        }
        public virtual void SetAngleZ(float z)
        {
            angle.z = z;
        }
        public virtual void SetScaleX(float x)
        {
            scale.x = x;
        }
        public virtual void SetScaleY(float y)
        {
            scale.y = y;
        }
        public virtual void SetScaleZ(float z)
        {
            scale.z = z;
        }
        public abstract void SetColor(int r, int g, int b);
        public abstract void SetAlpha(int alpha);
        public D3DXVECTOR3 GetPosition()
        {
            return position;
        }
        public D3DXVECTOR3 GetAngle()
        {
            return angle;
        }
        public D3DXVECTOR3 GetScale()
        {
            return scale;
        }
        public void SetPosition(D3DXVECTOR3 pos)
        {
            position.CopyFrom(pos);
        }
        public void SetAngle(D3DXVECTOR3 angle)
        {
            angle.CopyFrom(angle);
        }
        public void SetScale(D3DXVECTOR3 scale)
        {
            scale.CopyFrom(scale);
        }
        public BlendType GetBlendType()
        {
            return typeBlend;
        }
        public void SetRelativeObject(int id, string bone)
        {
            idRelative = id;
            nameRelativeBone = bone;
        }
        public virtual Shader.Shader GetShader()
        {
            return null;
        }
        public virtual void SetShader(Shader.Shader shader)
        {
        }
        public override void Render()
        {
        }
        public override void SetRenderState()
        {
        }
    }
}
