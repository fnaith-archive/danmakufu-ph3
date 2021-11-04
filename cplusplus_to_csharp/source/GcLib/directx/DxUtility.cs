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
    /**********************************************************
    //ColorAccess
    **********************************************************/
    public class ColorAccess
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                BIT_ALPHA = 24,
                BIT_RED = 16,
                BIT_GREEN = 8,
                BIT_BLUE = 0
            }

            /**********************************************************
            //ColorAccess
            **********************************************************/
            public static int GetColorA(D3DCOLOR color)
            {
                return gstd.BitAccess.GetByte(new D3DCOLOR(color), (int)AnonymousEnum.BIT_ALPHA);
            }

            public static D3DCOLOR SetColorA(D3DCOLOR color, int alpha)
            {
                if (alpha > 255)
                {
                    alpha = 255;
                }
                if (alpha < 0)
                {
                    alpha = 0;
                }
                return new D3DCOLOR(gstd.BitAccess.SetByte(color, (int)AnonymousEnum.BIT_ALPHA, (byte)alpha));
            }

            public static int GetColorR(D3DCOLOR color)
            {
                return gstd.BitAccess.GetByte(new D3DCOLOR(color), (int)AnonymousEnum.BIT_RED);
            }

            public static D3DCOLOR SetColorR(D3DCOLOR color, int red)
            {
                if (red > 255)
                {
                    red = 255;
                }
                if (red < 0)
                {
                    red = 0;
                }
                return new D3DCOLOR(gstd.BitAccess.SetByte(color, (int)AnonymousEnum.BIT_RED, (byte)red));
            }

            public static int GetColorG(D3DCOLOR color)
            {
                return gstd.BitAccess.GetByte(new D3DCOLOR(color), (int)AnonymousEnum.BIT_GREEN);
            }

            public static D3DCOLOR SetColorG(D3DCOLOR color, int green)
            {
                if (green > 255)
                {
                    green = 255;
                }
                if (green < 0)
                {
                    green = 0;
                }
                return new D3DCOLOR(gstd.BitAccess.SetByte(color, (int)AnonymousEnum.BIT_GREEN, (byte)green));
            }

            public static int GetColorB(D3DCOLOR color)
            {
                return gstd.BitAccess.GetByte(new D3DCOLOR(color), (int)AnonymousEnum.BIT_BLUE);
            }

            public static D3DCOLOR SetColorB(D3DCOLOR color, int blue)
            {
                if (blue > 255)
                {
                    blue = 255;
                }
                if (blue < 0)
                {
                    blue = 0;
                }
                return new D3DCOLOR(gstd.BitAccess.SetByte(color, (int)AnonymousEnum.BIT_BLUE, (byte)blue));
            }

            public static D3DCOLORVALUE SetColor(D3DCOLORVALUE value, D3DCOLOR color)
            {
                float a = (float)GetColorA(color) / 255.0f;
                float r = (float)GetColorR(new D3DCOLOR(color)) / 255.0f;
                float g = (float)GetColorG(color) / 255.0f;
                float b = (float)GetColorB(color) / 255.0f;
                value.r *= r;
                value.g *= g;
                value.b *= b;
                value.a *= a;
                return new D3DCOLORVALUE(value);
            }

            public static D3DMATERIAL9 SetColor(D3DMATERIAL9 mat, D3DCOLOR color)
            {
                float a = (float)GetColorA(color) / 255.0f;
                float r = (float)GetColorR(new D3DCOLOR(color)) / 255.0f;
                float g = (float)GetColorG(color) / 255.0f;
                float b = (float)GetColorB(color) / 255.0f;
                mat.Diffuse.r *= r;
                mat.Diffuse.g *= g;
                mat.Diffuse.b *= b;
                mat.Diffuse.a *= a;
                mat.Specular.r *= r;
                mat.Specular.g *= g;
                mat.Specular.b *= b;
                mat.Specular.a *= a;
                mat.Ambient.r *= r;
                mat.Ambient.g *= g;
                mat.Ambient.b *= b;
                mat.Ambient.a *= a;
                mat.Emissive.r *= r;
                mat.Emissive.g *= g;
                mat.Emissive.b *= b;
                mat.Emissive.a *= a;
                return new D3DMATERIAL9(mat);
            }

            public static D3DCOLOR ApplyAlpha(ref D3DCOLOR color, double alpha)
            {
                color = SetColorA(color, (int)GetColorA(color) * alpha);
                color = SetColorR(color, (int)GetColorR(new D3DCOLOR(color)) * alpha);
                color = SetColorG(color, (int)GetColorG(color) * alpha);
                color = SetColorB(color, (int)GetColorB(color) * alpha);
                return color;
            }

            public static D3DCOLOR SetColorHSV(D3DCOLOR color, int hue, int saturation, int value)
            {
                float f;
                int i;
                int p;
                int q;
                int t;

                i = (int)System.Math.Floor(hue / 60.0f) % 6;
                f = (float)(hue / 60.0f) - (float)System.Math.Floor(hue / 60.0f);
                p = (int)gstd.Math.Round(value * (1.0f - (saturation / 255.0f)));
                q = (int)gstd.Math.Round(value * (1.0f - (saturation / 255.0f) * f));
                t = (int)gstd.Math.Round(value * (1.0f - (saturation / 255.0f) * (1.0f - f)));

                int red = 0;
                int green = 0;
                int blue = 0;
                switch (i)
                {
                    case 0 :
                        red = value;
                        green = t;
                        blue = p;
                        break;
                    case 1 :
                        red = q;
                        green = value;
                        blue = p;
                        break;
                    case 2 :
                        red = p;
                        green = value;
                        blue = t;
                        break;
                    case 3 :
                        red = p;
                        green = q;
                        blue = value;
                        break;
                    case 4 :
                        red = t;
                        green = p;
                        blue = value;
                        break;
                    case 5 :
                        red = value;
                        green = p;
                        blue = q;
                        break;
                }

                SetColorR(color, red);
                SetColorG(color, green);
                SetColorB(color, blue);
                return color;
            }
    }


    /**********************************************************
    //�Փ˔���p�}�`
    **********************************************************/
    public class DxCircle : System.IDisposable
    {
            private double x_;
            private double y_;
            private double r_;
            public DxCircle()
            {
                x_ = 0;
                y_ = 0;
                r_ = 0;
            }
            public DxCircle(double x, double y, double r)
            {
                x_ = x;
                y_ = y;
                r_ = r;
            }
            public virtual void Dispose()
            {
            }
            public double GetX()
            {
                return x_;
            }
            public void SetX(float x)
            {
                x_ = x;
            }
            public double GetY()
            {
                return y_;
            }
            public void SetY(float y)
            {
                y_ = y;
            }
            public double GetR()
            {
                return r_;
            }
            public void SetR(float r)
            {
                r_ = r;
            }
    }

    public class DxWidthLine : System.IDisposable
    {
        // ���̂������
            private double posX1_;
            private double posY1_;
            private double posX2_;
            private double posY2_;
            private double width_;
            public DxWidthLine()
            {
                posX1_ = 0;
                posY1_ = 0;
                posX2_ = 0;
                posY2_ = 0;
                width_ = 0;
            }
            public DxWidthLine(double x1, double y1, double x2, double y2, double width)
            {
                posX1_ = x1;
                posY1_ = y1;
                posX2_ = x2;
                posY2_ = y2;
                width_ = width;
            }
            public virtual void Dispose()
            {
            }
            public double GetX1()
            {
                return posX1_;
            }
            public double GetY1()
            {
                return posY1_;
            }
            public double GetX2()
            {
                return posX2_;
            }
            public double GetY2()
            {
                return posY2_;
            }
            public double GetWidth()
            {
                return width_;
            }
    }

    public class DxLine3D
    {
            private D3DXVECTOR3[] vertex_ = Arrays.InitializeWithDefaultInstances<D3DXVECTOR3>(2);
            public DxLine3D()
            {
            }
            public DxLine3D(D3DXVECTOR3 p1, D3DXVECTOR3 p2)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vertex_[0] = p1;
                vertex_[0].CopyFrom(p1);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vertex_[1] = p2;
                vertex_[1].CopyFrom(p2);
            }

            public D3DXVECTOR3 GetPosition(int index)
            {
                return new D3DXVECTOR3(vertex_[index]);
            }
            public D3DXVECTOR3 GetPosition1()
            {
                return new D3DXVECTOR3(vertex_[0]);
            }
            public D3DXVECTOR3 GetPosition2()
            {
                return new D3DXVECTOR3(vertex_[1]);
            }

    }

    public class DxTriangle
    {
            private D3DXVECTOR3[] vertex_ = Arrays.InitializeWithDefaultInstances<D3DXVECTOR3>(3);
            private D3DXVECTOR3 normal_ = new D3DXVECTOR3();

            private void _Compute()
            {
                D3DXVECTOR3[] lv = Arrays.InitializeWithDefaultInstances<D3DXVECTOR3>(3);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: lv[0] = vertex_[1] - vertex_[0];
                lv[0].CopyFrom(vertex_[1] - vertex_[0]);
                lv[0] = *D3DXVec3Normalize(D3DXVECTOR3(), lv[0]);

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: lv[1] = vertex_[2] - vertex_[1];
                lv[1].CopyFrom(vertex_[2] - vertex_[1]);
                lv[1] = *D3DXVec3Normalize(D3DXVECTOR3(), lv[1]);

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: lv[2] = vertex_[0] - vertex_[2];
                lv[2].CopyFrom(vertex_[0] - vertex_[2]);
                lv[2] = *D3DXVec3Normalize(D3DXVECTOR3(), lv[2]);

                D3DXVECTOR3 cross = *D3DXVec3Cross(D3DXVECTOR3(), lv[0], lv[1]);
                normal_ = *D3DXVec3Normalize(D3DXVECTOR3(), cross);
            }
            public DxTriangle()
            {
            }
            public DxTriangle(D3DXVECTOR3 p1, D3DXVECTOR3 p2, D3DXVECTOR3 p3)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vertex_[0] = p1;
                vertex_[0].CopyFrom(p1);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vertex_[1] = p2;
                vertex_[1].CopyFrom(p2);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vertex_[2] = p3;
                vertex_[2].CopyFrom(p3);
                _Compute();
            }

            public D3DXVECTOR3 GetPosition(int index)
            {
                return new D3DXVECTOR3(vertex_[index]);
            }
            public D3DXVECTOR3 GetPosition1()
            {
                return new D3DXVECTOR3(vertex_[0]);
            }
            public D3DXVECTOR3 GetPosition2()
            {
                return new D3DXVECTOR3(vertex_[1]);
            }
            public D3DXVECTOR3 GetPosition3()
            {
                return new D3DXVECTOR3(vertex_[2]);
            }
    }

    /**********************************************************
    //DxMath
    **********************************************************/
    public class DxMath
    {
            public static D3DXVECTOR2 Normalize(D3DXVECTOR2 v)
            {
                return D3DXVec2Normalize(D3DXVECTOR2(), v);
            }
            public static D3DXVECTOR3 Normalize(D3DXVECTOR3 v)
            {
                return D3DXVec3Normalize(D3DXVECTOR3(), v);
            }
            public static float DotProduct(D3DXVECTOR2 v1, D3DXVECTOR2 v2)
            {
                return D3DXVec2Dot(v1, v2);
            }
            public static float DotProduct(D3DXVECTOR3 v1, D3DXVECTOR3 v2)
            {
                return D3DXVec3Dot(v1, v2);
            }
            public static float CrossProduct(D3DXVECTOR2 v1, D3DXVECTOR2 v2)
            {
                return D3DXVec2CCW(v1, v2);
            }
            public static D3DXVECTOR3 CrossProduct(D3DXVECTOR3 v1, D3DXVECTOR3 v2)
            {
                return D3DXVec3Cross(D3DXVECTOR3(), v1, v2);
            }

            // �x�N�g���ƍs��̐�

            /**********************************************************
            //DxMath
            **********************************************************/
            public static D3DXVECTOR4 VectMatMulti(D3DXVECTOR4 v, D3DMATRIX mat)
            {
                float x;
                float y;
                float z;

                x = v.x;
                y = v.y;
                z = v.z;

                v.x = (x * mat._11) + (y * mat._21) + (z * mat._31) + mat._41;
                v.y = (x * mat._12) + (y * mat._22) + (z * mat._32) + mat._42;
                v.z = (x * mat._13) + (y * mat._23) + (z * mat._33) + mat._43;
                v.w = (x * mat._14) + (y * mat._24) + (z * mat._34) + mat._44;

                return new D3DXVECTOR4(v);
            }

            // �Փ˔���F�_�|���p�`
            public static bool IsIntersected(D3DXVECTOR2 pos, List<D3DXVECTOR2> list)
            {
                if (list.Count <= 2)
                {
                    return false;
                }

                bool res = true;
                for (int iPos = 0 ; iPos < list.Count ; iPos++)
                {
                    int p1 = iPos;
                    int p2 = iPos + 1;
                    if (p2 >= list.Count)
                    {
                        p2 %= list.Count;
                    }

                    double cross_x = ((double)list[p2].x - (double)list[p1].x) * ((double)pos.y - (double)list[p1].y);
                    double corss_y = ((double)list[p2].y - (double)list[p1].y) * ((double)pos.x - (double)list[p1].x);
                    if (cross_x - corss_y < 0)
                    {
                        res = false;
                    }
                }
                return res;
            }

            // �Փ˔���F�~-�~
            public static bool IsIntersected(DxCircle circle1, DxCircle circle2)
            {
                double r1 = System.Math.Pow(circle1.GetX() - circle2.GetX(), 2) + System.Math.Pow(circle1.GetY() - circle2.GetY(), 2);
                double r2 = System.Math.Pow(circle1.GetR() + circle2.GetR(), 2);
                return r1 <= r2;
            }

            // �Փ˔���F�~-����
            public static bool IsIntersected(DxCircle circle, DxWidthLine line)
            {
                {
                // ��[������͏I�[���~��ɂ��邩�𒲂ׂ�
                    double radius = circle.GetR();
                    double dist1 = System.Math.Pow(System.Math.Pow(circle.GetX() - line.GetX1(),2) + System.Math.Pow(circle.GetY() - line.GetY1(),2), 0.5);
                    double dist2 = System.Math.Pow(System.Math.Pow(circle.GetX() - line.GetX2(),2) + System.Math.Pow(circle.GetY() - line.GetY2(),2), 0.5);
                    if (radius >= dist1 || radius >= dist2)
                    {
                        return true;
                    }
                }

                {
                // ������ɉ~�����邩�𒲂ׂ�
                    double lx1 = line.GetX2() - line.GetX1();
                    double ly1 = line.GetY2() - line.GetY1();
                    double cx1 = circle.GetX() - line.GetX1();
                    double cy1 = circle.GetY() - line.GetY1();
                    double inner1 = lx1 * cx1 + ly1 * cy1;

                    double lx2 = line.GetX1() - line.GetX2();
                    double ly2 = line.GetY1() - line.GetY2();
                    double cx2 = circle.GetX() - line.GetX2();
                    double cy2 = circle.GetY() - line.GetY2();
                    double inner2 = lx2 * cx2 + ly2 * cy2;

                    if (inner1 < 0 || inner2 < 0)
                    {
                        return false;
                    }
                }

                double ux1 = line.GetX2() - line.GetX1();
                double uy1 = line.GetY2() - line.GetY1();
                double px = circle.GetX() - line.GetX1();
                double py = circle.GetY() - line.GetY1();
                double u = System.Math.Pow(System.Math.Pow((double)ux1,(double)2) + System.Math.Pow((double)uy1,(double)2),0.5); // �����̋���
                double ux2 = ux1 / u; // �����̒P�ʃx�N�g��x
                double uy2 = uy1 / u; // �����̒P�ʃx�N�g��z
                double d = px * ux2 + py * uy2; // �����̒P�ʃx�N�g���Ǝn�_����_�܂Ńx�N�g���̓��
                double qx = d * ux2;
                double qy = d * uy2;
                double rx = px - qx; // �_���璼���܂ł̍ŒZ�����x�N�g��x
                double ry = py - qy; // �_���璼���܂ł̍ŒZ�����x�N�g��z
                double e = System.Math.Pow(System.Math.Pow((double)rx,(double)2) + System.Math.Pow((double)ry,(double)2),0.5); // �����̂Ɠ_�̋���
                double r = line.GetWidth() + circle.GetR();

                bool res = e < r;
                return res;
            }

            // �Փ˔���F����-����
            public static bool IsIntersected(DxWidthLine line1, DxWidthLine line2)
            {

                return false;
            }

            // �Փ˔���F�����F�O�p
            public static bool IsIntersected(DxLine3D line, List<DxTriangle> triangles, List<D3DXVECTOR3> @out)
            {
                @out.Clear();

                for (int iTri = 0; iTri < triangles.Count ; iTri++)
                {
                    DxTriangle tri = triangles[iTri];
                    D3DXPLANE plane = new D3DXPLANE(); // 3�p�`�̖�
                    D3DXPlaneFromPoints(plane, tri.GetPosition(0), tri.GetPosition(1), tri.GetPosition(2));

                    D3DXVECTOR3 vOut = new D3DXVECTOR3(); // �ʂƎ����̌�_�̍��W
                    if (D3DXPlaneIntersectLine(vOut, plane, line.GetPosition(0), line.GetPosition(1)))
                    {
                        // ��O����
                        D3DXVECTOR3[] vN = Arrays.InitializeWithDefaultInstances<D3DXVECTOR3>(3);
                        D3DXVECTOR3 vv1 = new D3DXVECTOR3();
                        D3DXVECTOR3 vv2 = new D3DXVECTOR3();
                        D3DXVECTOR3 vv3 = new D3DXVECTOR3();
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vv1 = tri.GetPosition(0) - vOut;
                        vv1.CopyFrom(tri.GetPosition(0) - vOut);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vv2 = tri.GetPosition(1) - vOut;
                        vv2.CopyFrom(tri.GetPosition(1) - vOut);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vv3 = tri.GetPosition(2) - vOut;
                        vv3.CopyFrom(tri.GetPosition(2) - vOut);
                        D3DXVec3Cross(vN[0], vv1, vv3);
                        D3DXVec3Cross(vN[1], vv2, vv1);
                        D3DXVec3Cross(vN[2], vv3, vv2);
                        if (D3DXVec3Dot(vN[0], vN[1]) < 0 || D3DXVec3Dot(vN[0], vN[2]) < 0)
                        {
                            continue;
                        }
                        else
                        { // ���(3�p�`�ɐڐG)
                            @out.Add(vOut);
                        }
                    }
                } // for(int i=0;i<tris.size();i++)

                bool res = @out.Count > 0;
                return res;
            }
    }

    public class RECT_D
    {
        public double left;
        public double top;
        public double right;
        public double bottom;
    }
}
