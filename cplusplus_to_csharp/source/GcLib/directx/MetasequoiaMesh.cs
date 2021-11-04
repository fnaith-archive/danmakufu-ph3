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
    //MetasequoiaMesh
    **********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class MetasequoiaMesh;
    public class MetasequoiaMeshData : DxMeshData
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend MetasequoiaMesh;
            private class NormalData : System.IDisposable
            {
                public List<int> listIndex_ = new List<int>();
                public D3DXVECTOR3 normal_ = new D3DXVECTOR3();
                public virtual void Dispose()
                {
                }
            }
            public class Material
            {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend MetasequoiaMeshData;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend MetasequoiaMeshData::RenderObject;
                    protected string name_ = ""; // �ގ���
                    protected D3DMATERIAL9 mat_ = new D3DMATERIAL9();
                    protected gstd.ref_count_ptr<Texture> texture_ = new gstd.ref_count_ptr<Texture>(); // �͗l�}�b�s���O ���΃p�X
                    protected string pathTextureAlpha_ = ""; // �����}�b�s���O�̖��O ���΃p�X(���g�p)
                    protected string pathTextureBump_ = ""; // ���ʃ}�b�s���O�̖��O ���΃p�X(���g�p)

                    public Material()
                    {
                        ZeroMemory(mat_, sizeof(D3DMATERIAL9));
                    }
                    public virtual void Dispose()
                    {
                    }
            }
            public class Object
            {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend MetasequoiaMeshData;
                    protected class Face
                    {
                        // �ʂ̒��_
                        public class Vertex
                        {
                            public int indexVertex_; // ���_�̃C���f�b�N�X
                            public D3DXVECTOR2 tcoord_ = new D3DXVECTOR2(); // �e�N�X�`���̍��W
                        }
                        public int indexMaterial_; // �}�e���A���̃C���f�b�N�X
                        public List<Vertex> vertices_ = new List<Vertex>(); // �ʂ̒��_
                        public Face()
                        {
                            indexMaterial_ = -1;
                        }
                    }
                    protected bool bVisible_;
                    protected string name_ = ""; // �I�u�W�F�N�g��
                    protected List<D3DXVECTOR3> vertices_ = new List<D3DXVECTOR3>(); // ���_����
                    protected List<Face> faces_ = new List<Face>(); // �ʂ���
                    public Object()
                    {
                    }
                    public virtual void Dispose()
                    {
                    }
            }
            public class RenderObject : RenderObjectNX
            {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend MetasequoiaMeshData;

                    protected gstd.ref_count_ptr<Material> material_ = new gstd.ref_count_ptr<Material>();

                    public RenderObject()
                    {
                    }
                    public virtual void Dispose()
                    {
                    }

                    // MetasequoiaMeshData::RenderObject
                    public virtual void Render()
                    {
                        IDirect3DDevice9 device = DirectGraphics.GetBase().GetDevice();
                        MetasequoiaMeshData.Material material = material_.GetPointer();
                        if (material != null)
                        {
                            if (material.texture_ != null)
                            {
                                SetTexture(material.texture_);
                            }
                            D3DMATERIAL9 tMaterial = ColorAccess.SetColor(material.mat_, color_);
                            device.SetMaterial(tMaterial);
                        }

                        base.Render();
                    }
            }
            protected string path_ = "";
            protected List<gstd.ref_count_ptr<Material>> material_ = new List<gstd.ref_count_ptr<Material>>();
            protected List<gstd.ref_count_ptr<RenderObject>> obj_ = new List<gstd.ref_count_ptr<RenderObject>>();

            protected void _ReadMaterial(gstd.Scanner scanner)
            {
                int countMaterial = scanner.Next().GetInteger();
                material_.Resize(countMaterial);
                for (int iMat = 0 ; iMat < countMaterial; iMat++)
                {
                    material_[iMat] = new Material();
                }
                scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);

                int posMat = 0;
                Material mat = material_[posMat].GetPointer();
                D3DCOLORVALUE color = new D3DCOLORVALUE();
                ZeroMemory(color, sizeof(D3DCOLORVALUE));
                while (true)
                {
                    gstd.Token tok = scanner.Next();
                    if (tok.GetType() == Token.TK_CLOSEC)
                    {
                        break;
                    }

                    if (tok.GetType() == Token.TK_NEWLINE)
                    {
                        posMat++;
                        if (material_.Count <= posMat)
                        {
                            break;
                        }
                        mat = material_[posMat].GetPointer();
                        ZeroMemory(color, sizeof(D3DCOLORVALUE));
                    }
                    else if (tok.GetType() == Token.TK_STRING)
                    {
                        mat.name_ = tok.GetString();
                    }
                    else if (tok.GetElement() == "col")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENP);
                        color.r = scanner.Next().GetReal();
                        color.g = scanner.Next().GetReal();
                        color.b = scanner.Next().GetReal();
                        color.a = scanner.Next().GetReal();
                        scanner.CheckType(scanner.Next(), Token.TK_CLOSEP);
                    }
                    else if (tok.GetElement() == "dif" || tok.GetElement() == "amb" || tok.GetElement() == "emi" || tok.GetElement() == "spc")
                    {
                        D3DCOLORVALUE value = null;
                        if (tok.GetElement() == "dif")
                        {
                            value = mat.mat_.Diffuse;
                        }
                        else if (tok.GetElement() == "amb")
                        {
                            value = mat.mat_.Ambient;
                        }
                        else if (tok.GetElement() == "emi")
                        {
                            value = mat.mat_.Emissive;
                        }
                        else if (tok.GetElement() == "spc")
                        {
                            value = mat.mat_.Specular;
                        }

                        scanner.CheckType(scanner.Next(), Token.TK_OPENP);
                        float num = scanner.Next().GetReal();
                        if (value != null)
                        {
                            value.a = color.a;
                            value.r = color.r * num;
                            value.g = color.g * num;
                            value.b = color.b * num;
                        }
                        scanner.CheckType(scanner.Next(), Token.TK_CLOSEP);
                    }
                    else if (tok.GetElement() == "power")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENP);
                        mat.mat_.Power = scanner.Next().GetReal();
                        scanner.CheckType(scanner.Next(), Token.TK_CLOSEP);
                    }
                    else if (tok.GetElement() == "tex")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENP);
                        tok = scanner.Next();

                        string wPathTexture = tok.GetString();
                        string path = PathProperty.GetFileDirectory(path_) + wPathTexture;
                        mat.texture_ = new Texture();
                        mat.texture_.CreateFromFile(path);
                        scanner.CheckType(scanner.Next(), Token.TK_CLOSEP);
                    }
                }
            }

            protected void _ReadObject(gstd.Scanner scanner)
            {
                Object obj = new Object();
                obj.name_ = scanner.Next().GetString();
                scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);

                SortedDictionary<int, LinkedList<MetasequoiaMeshData.Object.Face>> mapFace = new SortedDictionary<int, LinkedList<MetasequoiaMeshData.Object.Face>>();

                while (true)
                {
                    gstd.Token tok = scanner.Next();
                    if (tok.GetType() == Token.TK_CLOSEC)
                    {
                        break;
                    }

                    if (tok.GetElement() == "visible")
                    {
                        obj.bVisible_ = scanner.Next().GetInteger() == 15;
                    }
                    else if (tok.GetElement() == "vertex")
                    {
                        int count = scanner.Next().GetInteger();
                        obj.vertices_.resize(count);
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        for (int iVert = 0; iVert < count; iVert++)
                        {
                            obj.vertices_[iVert].x = scanner.Next().GetReal();
                            obj.vertices_[iVert].y = scanner.Next().GetReal();
                            obj.vertices_[iVert].z = -scanner.Next().GetReal();
                            scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        }
                        scanner.CheckType(scanner.Next(), Token.TK_CLOSEC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                    }
                    else if (tok.GetElement() == "face")
                    {
                        int countFace = scanner.Next().GetInteger();
                        obj.faces_.resize(countFace);
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);

                        for (int iFace = 0 ; iFace < countFace ; iFace++)
                        {
                            int countVert = scanner.Next().GetInteger();
                            obj.faces_[iFace].vertices_.resize(countVert);
                            MetasequoiaMeshData.Object.Face face = obj.faces_[iFace];
                            while (true)
                            {
                                gstd.Token tok = scanner.Next();
                                if (tok.GetType() == Token.TK_NEWLINE)
                                {
                                    break;
                                }
                                if (tok.GetElement() == "V")
                                {
                                    scanner.CheckType(scanner.Next(), Token.TK_OPENP);
                                    for (int iVert = 0 ; iVert < countVert; iVert++)
                                    {
                                        face.vertices_[iVert].indexVertex_ = scanner.Next().GetInteger();
                                    }
                                    scanner.CheckType(scanner.Next(), Token.TK_CLOSEP);
                                }
                                else if (tok.GetElement() == "M")
                                {
                                    scanner.CheckType(scanner.Next(), Token.TK_OPENP);
                                    face.indexMaterial_ = scanner.Next().GetInteger();
                                    scanner.CheckType(scanner.Next(), Token.TK_CLOSEP);
                                }
                                else if (tok.GetElement() == "UV")
                                {
                                    scanner.CheckType(scanner.Next(), Token.TK_OPENP);
                                    for (int iVert = 0 ; iVert < countVert; iVert++)
                                    {
                                        face.vertices_[iVert].tcoord_.x = scanner.Next().GetReal();
                                        face.vertices_[iVert].tcoord_.y = scanner.Next().GetReal();
                                    }
                                    scanner.CheckType(scanner.Next(), Token.TK_CLOSEP);
                                }
                            }

                            mapFace[face.indexMaterial_].AddLast(face);
                        }

                        scanner.CheckType(scanner.Next(), Token.TK_CLOSEC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                    }
                    else if (tok.GetType() == Token.TK_ID)
                    {
                        while (scanner.GetToken().GetType() != Token.TK_OPENC && scanner.GetToken().GetType() != Token.TK_NEWLINE)
                        {
                            scanner.Next();
                        }
                        if (scanner.GetToken().GetType() == Token.TK_OPENC)
                        {
                            while (scanner.GetToken().GetType() != Token.TK_CLOSEC)
                            {
                                scanner.Next();
                            }
                        }
                    }
                }

                // �s���Ȃ�I�u�W�F�N�g��쐬���Ȃ�
                if (!obj.bVisible_)
                {
                    return;
                }

                // �}�e���A�����ƂɎd�����ăI�u�W�F�N�g��쐬
                SortedDictionary<int, LinkedList<MetasequoiaMeshData.Object.Face>>.Enumerator itrMap;
                for (itrMap = mapFace.GetEnumerator(); itrMap.MoveNext();)
                {
                    int indexMaterial = itrMap.Current.Key;
                    LinkedList<MetasequoiaMeshData.Object.Face> listFace = itrMap.Current.Value;

                    MetasequoiaMeshData.RenderObject render = new MetasequoiaMeshData.RenderObject();
                    obj_.Add(render);
                    if (indexMaterial >= 0)
                    {
                        render.material_ = material_[indexMaterial];
                    }

                    int countVert = 0;
                    LinkedList<MetasequoiaMeshData.Object.Face>.Enumerator itrFace;
                    for (itrFace = listFace.GetEnumerator(); itrFace.MoveNext();)
                    {
                        MetasequoiaMeshData.Object.Face face = itrFace.Current;
                        countVert += face.vertices_.size() == 3 ? 3 : 6;
                    }

                    List<ref_count_ptr<NormalData>> listNormalData = new List<new ref_count_ptr<NormalData>>();
                    listNormalData.Resize(countVert);
                    render.SetVertexCount(countVert);
                    int posVert = 0;
                    for (itrFace = listFace.GetEnumerator(); itrFace.MoveNext();)
                    {
                        MetasequoiaMeshData.Object.Face face = itrFace.Current;
                        if (face.vertices_.size() == 3)
                        {
                            int[] indexVert = { face.vertices_[0].indexVertex_, face.vertices_[1].indexVertex_, face.vertices_[2].indexVertex_ };
                            D3DXVECTOR3 normal = DxMath.Normalize(DxMath.CrossProduct(obj.vertices_[indexVert[1]] - obj.vertices_[indexVert[0]], obj.vertices_[indexVert[2]] - obj.vertices_[indexVert[0]]));

                            for (int iVert = 0 ; iVert < 3 ; iVert++)
                            {
                                int mqoVertexIndex = indexVert[iVert];
                                int nxVertexIndex = posVert + iVert;
                                VERTEX_NX vert = render.GetVertex(nxVertexIndex);
                                vert.position = obj.vertices_[mqoVertexIndex];
                                vert.texcoord = face.vertices_[iVert].tcoord_;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vert->normal = normal;
                                vert.normal.CopyFrom(normal);
            /*
            					ref_count_ptr<NormalData> norlamData = listNormalData[mqoVertexIndex];
            					if(norlamData == NULL)
            					{
            						norlamData = new NormalData();
            						norlamData->normal_ = normal;
            						listNormalData[mqoVertexIndex] = norlamData;
            					}
            					else
            					{
            						D3DXVECTOR3 tNormal = norlamData->normal_;
            						int norlamCountOld = norlamData->listIndex_.size();
            						int normalCountNew = norlamCountOld + 1;
            						norlamData->normal_.x = tNormal.x * norlamCountOld / normalCountNew + normal.x / normalCountNew;
            						norlamData->normal_.y = tNormal.y * norlamCountOld / normalCountNew + normal.y / normalCountNew;
            						norlamData->normal_.z = tNormal.z * norlamCountOld / normalCountNew + normal.z / normalCountNew;
            					}
            					norlamData->listIndex_.push_back(nxVertexIndex);
            */
                            }
                            posVert += 3;
                        }
                        else if (face.vertices_.size() == 4)
                        {
                            int[] indexVert = { face.vertices_[0].indexVertex_, face.vertices_[1].indexVertex_, face.vertices_[2].indexVertex_, face.vertices_[3].indexVertex_ };
                            D3DXVECTOR3[] normals = { DxMath.Normalize(DxMath.CrossProduct(obj.vertices_[indexVert[1]] - obj.vertices_[indexVert[0]], obj.vertices_[indexVert[2]] - obj.vertices_[indexVert[0]])), DxMath.Normalize(DxMath.CrossProduct(obj.vertices_[indexVert[3]] - obj.vertices_[indexVert[2]], obj.vertices_[indexVert[0]] - obj.vertices_[indexVert[2]])) };

                            for (int iVert = 0 ; iVert < 6 ; iVert++)
                            {
                                int nxVertexIndex = posVert + iVert;
                                VERTEX_NX vert = render.GetVertex(nxVertexIndex);

                                int indexFace = iVert;
                                if (iVert == 3)
                                {
                                    indexFace = 2;
                                }
                                else if (iVert == 4)
                                {
                                    indexFace = 3;
                                }
                                else if (iVert == 5)
                                {
                                    indexFace = 0;
                                }

                                int mqoVertexIndex = indexVert[indexFace];
                                vert.position = obj.vertices_[mqoVertexIndex];
                                vert.texcoord = face.vertices_[indexFace].tcoord_;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: vert->normal = iVert < 3 ? normals[0] : normals[1];
                                vert.normal.CopyFrom(iVert < 3 ? normals[0] : normals[1]);
            /*
            					ref_count_ptr<NormalData> norlamData = listNormalData[mqoVertexIndex];
            					if(norlamData == NULL)
            					{
            						norlamData = new NormalData();
            						norlamData->normal_ = vert->normal;
            						listNormalData[mqoVertexIndex] = norlamData;
            					}
            					else
            					{
            						D3DXVECTOR3 tNormal = norlamData->normal_;
            						int norlamCountOld = norlamData->listIndex_.size();
            						int normalCountNew = norlamCountOld + 1;
            						norlamData->normal_.x = tNormal.x * norlamCountOld / normalCountNew + vert->normal.x / normalCountNew;
            						norlamData->normal_.y = tNormal.y * norlamCountOld / normalCountNew + vert->normal.y / normalCountNew;
            						norlamData->normal_.z = tNormal.z * norlamCountOld / normalCountNew + vert->normal.z / normalCountNew;
            					}
            					norlamData->listIndex_.push_back(nxVertexIndex);
            */
                            }

                            posVert += 6;
                        }
                    }

                    int countNormalData = listNormalData.Count;
                    for (int iData = 0 ; iData < countNormalData ; iData++)
                    {
                        ref_count_ptr<NormalData> normalData = listNormalData[iData];
                        if (normalData != null)
                        {
                            int countVertexIndex = normalData.listIndex_.size();
                            for (int iVert = 0 ; iVert < countVertexIndex ; iVert++)
                            {
                                int nvVertexIndex = normalData.listIndex_[iVert];
                                VERTEX_NX vert = render.GetVertex(nvVertexIndex);
                                vert.normal = normalData.normal_;
                            }
                        }
                    }
                }
            }


            /**********************************************************
            //MetasequoiaMesh
            **********************************************************/

            // MetasequoiaMeshData
            public MetasequoiaMeshData()
            {
            }

            public new void Dispose()
            {
                base.Dispose();
            }

            public override bool CreateFromFileReader(gstd.ref_count_ptr<gstd.FileReader> reader)
            {
                bool res = false;
                path_ = reader.GetOriginalPath();
                string text;
                int size = reader.GetFileSize();
                text.resize(size);
                reader.Read(text[0], size);

                gstd.Scanner scanner = new gstd.Scanner(text);
                try
                {
                    while (scanner.HasNext())
                    {
                        gstd.Token tok = scanner.Next();
                        if (tok.GetElement() == "Material")
                        {
                            _ReadMaterial(scanner);
                        }
                        else if (tok.GetElement() == "Object")
                        {
                            _ReadObject(scanner);
                        }
                    }

                    res = true;
                }
                catch (gstd.wexception e)
                {
                    Logger.WriteTop(StringUtility.Format("MetasequoiaMeshData�ǂݍ��ݎ��s %s %d", e.what(), scanner.GetCurrentLine()));
                    res = false;
                }
                return res;
            }
    }




    public class MetasequoiaMesh : DxMesh
    {
            public MetasequoiaMesh()
            {
            }
            public override void Dispose()
            {
                base.Dispose();
            }

            // MetasequoiaMesh
            public override bool CreateFromFileReader(gstd.ref_count_ptr<gstd.FileReader> reader)
            {
                bool res = false;
                {
                    Lock @lock = new Lock(DxMeshManager.GetBase().GetLock());
                    if (data_ != null)
                    {
                        Release();
                    }

                    string name = reader.GetOriginalPath();

                    data_ = _GetFromManager(name);
                    if (data_ == null)
                    {
                        if (!reader.Open())
                        {
                            throw new gstd.wexception("�t�@�C�����J���܂���");
                        }
                        data_ = new MetasequoiaMeshData();
                        data_.SetName(name);
                        MetasequoiaMeshData data = (MetasequoiaMeshData)data_.GetPointer();
                        res = data.CreateFromFileReader(new gstd.ref_count_ptr<gstd.FileReader>(reader));
                        if (res)
                        {
                            Logger.WriteTop(StringUtility.Format("���b�V����ǂݍ��݂܂���[%s]", name));
                            _AddManager(name, data_);
                        }
                        else
                        {
                            data_ = null;
                        }
                    }
                    else
                    {
                        res = true;
                    }
                }
                return res;
            }

            public override bool CreateFromFileInLoadThread(string path)
            {
                return base.CreateFromFileInLoadThread(path, MESH_METASEQUOIA);
            }

            public override string GetPath()
            {
                if (data_ == null)
                {
                    return "";
                }
                return ((MetasequoiaMeshData)data_.GetPointer()).path_;
            }

            public override void Render()
            {
                if (data_ == null)
                {
                    return;
                }

                MetasequoiaMeshData data = (MetasequoiaMeshData)data_.GetPointer();

                while (!data.bLoad_)
                {
                    global::Sleep(1);
                }

                for (int iObj = 0 ; iObj < data.obj_.size(); iObj++)
                {
                    MetasequoiaMeshData.RenderObject obj = (MetasequoiaMeshData.RenderObject)data.obj_[iObj].GetPointer();
                    obj.SetShader(shader_);
                    obj.SetPosition(position_);
                    obj.SetAngle(angle_);
                    obj.SetScale(scale_);
                    obj.SetColor(color_);
                    obj.SetCoordinate2D(bCoordinate2D_);
                    obj.Render();
                }

            }

            public List<DxTriangle> CreateIntersectionTriangles()
            {
                List<DxTriangle> res = new List<DxTriangle>();
                MetasequoiaMeshData data = (MetasequoiaMeshData)data_.GetPointer();
                for (int iObj = 0 ; iObj < data.obj_.size(); iObj++)
                {
                    MetasequoiaMeshData.RenderObject obj = (MetasequoiaMeshData.RenderObject)data.obj_[iObj].GetPointer();
                    int vertexCount = obj.GetVertexCount();
                    for (int iVert = 0 ; iVert < vertexCount - 2;)
                    {
                        VERTEX_NX nx1 = obj.GetVertex(iVert);
                        VERTEX_NX nx2 = obj.GetVertex(iVert + 1);
                        VERTEX_NX nx3 = obj.GetVertex(iVert + 2);
                        DxTriangle triangle = new DxTriangle(nx1.position, nx2.position, nx3.position);
                        res.Add(triangle);

                        iVert += 3;
                    }
                }

                return new List<DxTriangle>(res);
            }
    }
}
