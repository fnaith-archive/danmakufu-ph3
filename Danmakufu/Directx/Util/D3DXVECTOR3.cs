using Gstd.ScriptClient;

namespace Directx.Util
{
    public sealed class D3DXVECTOR3
    {
        public D3DXVECTOR3()
        {
        }
        public D3DXVECTOR3(float[] pf)
        {
            x = pf[0];
            y = pf[1];
            z = pf[2];
        }
        public D3DXVECTOR3(D3DXVECTOR3 v)
        {
            x = v.x;
            y = v.y;
            z = v.z;
        }
        public D3DXVECTOR3(float fx, float fy, float fz)
        {
            x = fx;
            y = fy;
            z = fz;
        }
        public void CopyFrom(D3DXVECTOR3 v)
        {
            x = v.x;
            y = v.y;
            z = v.z;
        }
        public static D3DXVECTOR3 operator + (D3DXVECTOR3 ImpliedObject)
        {
            return ImpliedObject;
        }
        public static D3DXVECTOR3 operator - (D3DXVECTOR3 ImpliedObject)
        {
            return new D3DXVECTOR3(-ImpliedObject.x, -ImpliedObject.y, -ImpliedObject.z);
        }

        public static D3DXVECTOR3 operator + (D3DXVECTOR3 ImpliedObject, D3DXVECTOR3 v)
        {
            return new D3DXVECTOR3(ImpliedObject.x + v.x, ImpliedObject.y + v.y, ImpliedObject.z + v.z);
        }
        public static D3DXVECTOR3 operator - (D3DXVECTOR3 ImpliedObject, D3DXVECTOR3 v)
        {
            return new D3DXVECTOR3(ImpliedObject.x - v.x, ImpliedObject.y - v.y, ImpliedObject.z - v.z);
        }
        public static D3DXVECTOR3 operator * (D3DXVECTOR3 ImpliedObject, float f)
        {
            return new D3DXVECTOR3(ImpliedObject.x * f, ImpliedObject.y * f, ImpliedObject.z * f);
        }
        public static D3DXVECTOR3 operator / (D3DXVECTOR3 ImpliedObject, float f)
        {
            float fInv = 1.0f / f;
            return new D3DXVECTOR3(ImpliedObject.x * fInv, ImpliedObject.y * fInv, ImpliedObject.z * fInv);
        }
        public static D3DXVECTOR3 operator * (float f, D3DXVECTOR3 v)
        {
            return new D3DXVECTOR3(f * v.x, f * v.y, f * v.z);
        }
        public static bool operator == (D3DXVECTOR3 ImpliedObject, D3DXVECTOR3 v)
        {
            return ImpliedObject.x == v.x && ImpliedObject.y == v.y && ImpliedObject.z == v.z;
        }
        public static bool operator != (D3DXVECTOR3 ImpliedObject, D3DXVECTOR3 v)
        {
            return ImpliedObject.x != v.x || ImpliedObject.y != v.y || ImpliedObject.z != v.z;
        }
        public float x;
        public float y;
        public float z;
    }
}
