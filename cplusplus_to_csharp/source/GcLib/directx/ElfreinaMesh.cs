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
//    class RenderObjectElfreinaBlock;
    /**********************************************************
    //ElfreinaMesh
    **********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class ElfreinaMesh;
    public class ElfreinaMeshData : DxMeshData
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend ElfreinaMesh;
            public class Bone
            {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend ElfreinaMesh;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend ElfreinaMeshData;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
                    public enum AnonymousEnum
                    {
                        NO_PARENT = -1
                    }
                    protected string name_ = "";
                    protected D3DXMATRIX matOffset_ = new D3DXMATRIX();
                    protected D3DXMATRIX matInitPosture_ = new D3DXMATRIX();

                    protected int indexParent_;
                    protected List<int> indexChild_ = new List<int>();

                    public Bone()
                    {
                    }
                    public virtual void Dispose()
                    {
                    }
                    public int GetParentIndex()
                    {
                        return indexParent_;
                    }
                    public List<int> GetChildIndex()
                    {
                        return indexChild_;
                    }
                    public D3DXMATRIX GetOffsetMatrix()
                    {
                        return matOffset_;
                    }
                    public D3DXMATRIX GetInitPostureMatrix()
                    {
                        return matInitPosture_;
                    }
            }
            public class Material
            {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend ElfreinaMeshData;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend ElfreinaMeshData::Mesh;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend RenderObjectElfreinaBlock;
                    protected string name_ = "";
                    protected D3DMATERIAL9 mat_ = new D3DMATERIAL9();
                    protected gstd.ref_count_ptr<Texture> texture_ = new gstd.ref_count_ptr<Texture>();
                    public Material()
                    {
                    }
                    public virtual void Dispose()
                    {
                    }

            }
            public class Mesh : RenderObjectB4NX
            {
                // ���_�{�[���f�[�^�ǂݍ��݂Ɏg���ꎞ�f�[�^
                private class BoneWeightData
                {
                    public int index;
                    public float weight;
                }
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend ElfreinaMeshData;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend RenderObjectElfreinaBlock;
                    protected string name_ = "";
                    protected gstd.ref_count_ptr<Material> material_ = new gstd.ref_count_ptr<Material>();
                    protected int indexWeightForCalucZValue_;

                    // ElfreinaMeshData::Mesh
                    public Mesh()
                    {
                        SetPrimitiveType(D3DPT_TRIANGLELIST);
                    }

                    public virtual void Dispose()
                    {
                    }

                    public virtual void Render()
                    {
                        IDirect3DDevice9 device = DirectGraphics.GetBase().GetDevice();
                        ElfreinaMeshData.Material material = material_.GetPointer();
                        SetTexture(material.texture_);
                        materialBNX_ = material.mat_;
                        device.SetMaterial(materialBNX_);
                        RenderObjectB4NX.Render();
                        // RenderObjectB2NX::Render();
                    /*
                    	{
                    		RenderObjectLX obj;
                    		int count = GetVertexCount();
                    		obj.SetVertexCount(count);
                    		for(int iVert=0;iVert<count;iVert++)
                    		{
                    			VERTEX_B2NX* b2 = GetVertex(iVert);
                    			obj.SetVertexPosition(iVert, b2->position.x, b2->position.y, b2->position.z);
                    			obj.SetVertexUV(iVert, b2->texcoord.x, b2->texcoord.y);
                    			obj.SetVertexAlpha(iVert, 255);
                    			obj.SetVertexColorARGB(iVert,255,255,255,255);
                    		}
                    		obj.SetVertexIndicies(vertexIndices_);
                    		obj.SetTexture(mat->texture_);
                    		obj.Render();
                    	}
                    */
                    }

                    public gstd.ref_count_ptr<RenderBlock> CreateRenderBlock()
                    {
                        gstd.ref_count_ptr<RenderObjectElfreinaBlock> res = new RenderObjectElfreinaBlock();
                        res.SetPosition(position_);
                        res.SetAngle(angle_);
                        res.SetScale(scale_);
                        res.SetMatrix(matrix_);
                        return new gstd.ref_count_ptr<RenderObjectElfreinaBlock>(res);
                    }
            }
            public class AnimationData
            {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend ElfreinaMesh;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend ElfreinaMeshData;
                    protected string name_ = "";
                    protected int timeTotal_;
                    protected int framePerSecond_;
                    protected bool bLoop_;
                    protected List<gstd.ref_count_ptr<ElfreinaMeshData.BoneAnimationPart>> animeBone_ = new List<gstd.ref_count_ptr<ElfreinaMeshData.BoneAnimationPart>>();

                    protected void _CreateBoneAnimationMatrix(int time, ElfreinaMeshData mesh, gstd.ref_count_ptr<Matrices> matrix, int indexOwn, D3DXMATRIX matrixParentAnime)
                    {
                        List<gstd.ref_count_ptr<Bone>> bones = mesh.GetBones();

                        D3DXMATRIX matInit = bones[indexOwn].GetInitPostureMatrix();
                        D3DXMATRIX matOffset = bones[indexOwn].GetOffsetMatrix();
                        D3DXMATRIX mat = _CalculateMatrix(time, indexOwn) * matInit * matrixParentAnime;

                        // ���g�̍s���ݒ�
                        matrix.SetMatrix(indexOwn, matOffset * mat);

                        // �q�̍s���v�Z
                        List<int> indexChild = bones[indexOwn].GetChildIndex();
                        for (int iChild = 0 ; iChild < indexChild.Count; iChild++)
                        {
                            int index = indexChild[iChild];
                            _CreateBoneAnimationMatrix(time, mesh, matrix, index, mat);
                        }
                    }

                    protected D3DXMATRIX _CalculateMatrix(double time, int index)
                    {
                        D3DXMATRIX res = new D3DXMATRIX();
                        BoneAnimationPart part = animeBone_[index].GetPointer();
                        if (part == null)
                        {
                            D3DXMatrixIdentity(res);
                            return new D3DXMATRIX(res);
                        }

                        List<float> keyTime = part.GetTimeKey();

                        // �A�j���[�V�����C���f�b�N�X�����
                        int keyNext = -1;
                        int keyPrevious = -1;
                        for (int iTime = 0 ; iTime < keyTime.Count; iTime++)
                        {
                            int tTime = timeTotal_ * keyTime[iTime];
                            if (tTime < time)
                            {
                                continue;
                            }
                            keyPrevious = iTime - 1;
                            keyNext = iTime;
                            break;
                        }
                        if (keyNext == -1)
                        {
                            keyNext = keyTime.Count - 1;
                            keyPrevious = keyNext - 1;
                        }
                        if (keyPrevious < 0)
                        {
                            keyPrevious = 0;
                        }
                        if (keyNext < 0)
                        {
                            keyNext = 0;
                        }

                        float timeDiffKey = (float)timeTotal_ * keyTime[keyNext] - (float)timeTotal_ * keyTime[keyPrevious];
                        float timeDiffAnime = (float)(time - timeTotal_ * keyTime[keyPrevious]);
                        float rateToNext = timeDiffKey != 0.0f ? timeDiffAnime / timeDiffKey : 0F;

                        // �e�s���쐬
                        List<D3DXVECTOR3> keyTrans = part.GetTransKey();
                        D3DXMATRIX matTrans = new D3DXMATRIX();
                        D3DXMatrixIdentity(matTrans);
                        D3DXVECTOR3 pos = new D3DXVECTOR3();
                        pos.x = keyTrans[keyPrevious].x + (keyTrans[keyNext].x - keyTrans[keyPrevious].x) * rateToNext;
                        pos.y = keyTrans[keyPrevious].y + (keyTrans[keyNext].y - keyTrans[keyPrevious].y) * rateToNext;
                        pos.z = keyTrans[keyPrevious].z + (keyTrans[keyNext].z - keyTrans[keyPrevious].z) * rateToNext;
                        D3DXMatrixTranslation(matTrans, pos.x, pos.y, pos.z);

                        List<D3DXVECTOR3> keyScale = part.GetScaleKey();
                        D3DXMATRIX matScale = new D3DXMATRIX();
                        D3DXMatrixIdentity(matScale);
                        D3DXVECTOR3 scale = new D3DXVECTOR3();
                        scale.x = keyScale[keyPrevious].x + (keyScale[keyNext].x - keyScale[keyPrevious].x) * rateToNext;
                        scale.y = keyScale[keyPrevious].y + (keyScale[keyNext].y - keyScale[keyPrevious].y) * rateToNext;
                        scale.z = keyScale[keyPrevious].z + (keyScale[keyNext].z - keyScale[keyPrevious].z) * rateToNext;
                        D3DXMatrixScaling(matScale, scale.x, scale.y, scale.z);

                        List<D3DXQUATERNION> keyRotate = part.GetRotateKey();
                        D3DXMATRIX matRotate = new D3DXMATRIX();
                        D3DXMatrixIdentity(matRotate);
                        D3DXQUATERNION quat = new D3DXQUATERNION();
                        D3DXQuaternionSlerp(quat, keyRotate[keyPrevious], keyRotate[keyNext], rateToNext);
                        D3DXMatrixRotationQuaternion(matRotate, quat);

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res = matScale * matRotate * matTrans;
                        res.CopyFrom(matScale * matRotate * matTrans);
                        return new D3DXMATRIX(res);
                    }

                    public AnimationData()
                    {
                    }
                    public virtual void Dispose()
                    {
                    }

                    // ElfreinaMeshData::AnimationData
                    public gstd.ref_count_ptr<Matrices> CreateBoneAnimationMatrix(double time, ElfreinaMeshData mesh)
                    {
                        List<gstd.ref_count_ptr<Bone>> bones = mesh.GetBones();

                        gstd.ref_count_ptr<Matrices> matrix = new Matrices();
                        matrix.SetSize(bones.Count);

                        // �ŏ�ʂ̐e��T��
                        for (int iBone = 0; iBone < bones.Count ; iBone++)
                        {
                            if (bones[iBone].GetParentIndex() != ElfreinaMeshData.Bone.NO_PARENT)
                            {
                                continue;
                            }

                            D3DXMATRIX matInit = bones[iBone].GetInitPostureMatrix();
                            D3DXMATRIX matOffset = bones[iBone].GetOffsetMatrix();
                            D3DXMATRIX mat = _CalculateMatrix(time, iBone) * matInit;

                            // ���g�̍s���ݒ�
                            matrix.SetMatrix(iBone, matOffset * mat);

                            // �q�̍s���v�Z
                            List<int> indexChild = bones[iBone].GetChildIndex();
                            for (int iChild = 0 ; iChild < indexChild.Count; iChild++)
                            {
                                int index = indexChild[iChild];
                                _CreateBoneAnimationMatrix(time, mesh, matrix, index, mat);
                            }
                        }

                        return new gstd.ref_count_ptr<Matrices>(matrix);
                    }
            }
            public class BoneAnimationPart
            {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend ElfreinaMeshData;
                    protected List<float> keyTime_ = new List<float>();
                    protected List<D3DXVECTOR3> keyTrans_ = new List<D3DXVECTOR3>();
                    protected List<D3DXQUATERNION> keyRotate_ = new List<D3DXQUATERNION>();
                    protected List<D3DXVECTOR3> keyScale_ = new List<D3DXVECTOR3>();
                    public BoneAnimationPart()
                    {
                    }
                    public virtual void Dispose()
                    {
                    }
                    public List<float> GetTimeKey()
                    {
                        return keyTime_;
                    }
                    public List<D3DXVECTOR3> GetTransKey()
                    {
                        return keyTrans_;
                    }
                    public List<D3DXQUATERNION> GetRotateKey()
                    {
                        return keyRotate_;
                    }
                    public List<D3DXVECTOR3> GetScaleKey()
                    {
                        return keyScale_;
                    }
            }
            protected string path_ = "";
            protected List<gstd.ref_count_ptr<Mesh>> mesh_ = new List<gstd.ref_count_ptr<Mesh>>();
            protected List<gstd.ref_count_ptr<Bone>> bone_ = new List<gstd.ref_count_ptr<Bone>>();
            protected List<gstd.ref_count_ptr<Material>> material_ = new List<gstd.ref_count_ptr<Material>>();
            protected SortedDictionary<string, gstd.ref_count_ptr<AnimationData>> anime_ = new SortedDictionary<string, gstd.ref_count_ptr<AnimationData>>();

            protected SortedDictionary<string, int> mapBoneNameIndex_ = new SortedDictionary<string, int>();

            protected void _ReadMeshContainer(gstd.Scanner scanner)
            {
                int countReadMesh = 0;
                while (scanner.HasNext())
                {
                    gstd.Token tok = scanner.Next();
                    if (tok.GetType() == Token.TK_CLOSEC)
                    {
                        break;
                    }

                    if (tok.GetElement() == "Name")
                    {
                    }
                    else if (tok.GetElement() == "BoneCount")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        tok = scanner.Next();
                        int countBone = tok.GetInteger();
                        bone_.Resize(countBone);
                        for (int iBone = 0; iBone < countBone; iBone++)
                        {
                            bone_[iBone] = new Bone();
                        }
                    }
                    else if (tok.GetElement() == "MeshCount")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        tok = scanner.Next();
                        int countObj = tok.GetInteger();
                        mesh_.Resize(countObj);
                        for (int iObj = 0; iObj < countObj; iObj++)
                        {
                            mesh_[iObj] = new Mesh();
                        }
                    }
                    else if (tok.GetElement() == "VertexFormat")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        while (true)
                        {
                            if (scanner.Next().GetType() == Token.TK_CLOSEC)
                            {
                                break;
                            }
                        }
                    }
                    else if (tok.GetElement() == "BoneNames")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        int iBone = 0;
                        while (true)
                        {
                            tok = scanner.Next();
                            if (tok.GetType() == Token.TK_CLOSEC)
                            {
                                break;
                            }
                            if (tok.GetType() != Token.TK_STRING)
                            {
                                continue;
                            }
                            bone_[iBone].name_ = tok.GetString();
                            iBone++;
                        }
                    }
                    else if (tok.GetElement() == "OffsetMatrices")
                    {
                        int iCount = 0;
                        int iBone = -1;
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        while (true)
                        {
                            tok = scanner.Next();
                            if (tok.GetType() == Token.TK_CLOSEC)
                            {
                                break;
                            }

                            if (tok.GetType() == Token.TK_NEWLINE)
                            {
                                if (iCount != 0 && iBone != -1 && iCount != 16)
                                {
                                    throw new gstd.wexception("ElfreinaMeshData:OffsetMatrices�̐����s���ł�");
                                }
                                iCount = 0;
                                iBone++;
                            }

                            if (tok.GetType() != Token.TK_INT && tok.GetType() != Token.TK_REAL)
                            {
                                continue;
                            }

                            bone_[iBone].matOffset_.m[iCount / 4][iCount % 4] = tok.GetReal();
                            iCount++;
                        }
                    }
                    else if (tok.GetElement() == "Materials")
                    {
                        int posMat = 0;
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        while (true)
                        {
                            tok = scanner.Next();
                            if (tok.GetType() == Token.TK_CLOSEC)
                            {
                                break;
                            }
                            if (tok.GetElement() == "MaterialCount")
                            {
                                scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                                tok = scanner.Next();
                                int countMaterial = tok.GetInteger();
                                material_.Resize(countMaterial);
                                for (int iMat = 0; iMat < countMaterial; iMat++)
                                {
                                    material_[iMat] = new Material();
                                }
                            }
                            else if (tok.GetElement() == "Material")
                            {
                                scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                                _ReadMaterials(scanner, material_[posMat].GetPointer());
                                posMat++;
                            }
                        }
                    }
                    else if (tok.GetElement() == "Mesh")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        _ReadMesh(scanner, mesh_[countReadMesh].GetPointer());
                        countReadMesh++;
                    }
                }
            }

            protected void _ReadMaterials(gstd.Scanner scanner, Material material)
            {
                while (true)
                {
                    gstd.Token tok = scanner.Next();
                    if (tok.GetType() == Token.TK_CLOSEC)
                    {
                        break;
                    }

                    if (tok.GetElement() == "Name")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        tok = scanner.Next();
                        material.name_ = tok.GetString();
                    }
                    else if (tok.GetElement() == "Diffuse" || tok.GetElement() == "Ambient" || tok.GetElement() == "Emissive" || tok.GetElement() == "Specular")
                    {
                        D3DMATERIAL9 mat = material.mat_;
                        D3DCOLORVALUE color;
                        if (tok.GetElement() == "Diffuse")
                        {
                            color = mat.Diffuse;
                        }
                        else if (tok.GetElement() == "Ambient")
                        {
                            color = mat.Ambient;
                        }
                        else if (tok.GetElement() == "Emissive")
                        {
                            color = mat.Emissive;
                        }
                        else if (tok.GetElement() == "Specular")
                        {
                            color = mat.Specular;
                        }

                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        color.a = scanner.Next().GetReal();
                        scanner.CheckType(scanner.Next(), Token.TK_COLON);
                        color.r = scanner.Next().GetReal();
                        scanner.CheckType(scanner.Next(), Token.TK_COLON);
                        color.g = scanner.Next().GetReal();
                        scanner.CheckType(scanner.Next(), Token.TK_COLON);
                        color.b = scanner.Next().GetReal();
                    }
                    else if (tok.GetElement() == "SpecularSharpness")
                    {
                    }
                    else if (tok.GetElement() == "TextureFilename")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        tok = scanner.Next();

                        string wPathTexture = tok.GetString();
                        string path = PathProperty.GetFileDirectory(path_) + wPathTexture;
                        material.texture_ = new Texture();
                        material.texture_.CreateFromFile(path);
                    }
                }
            }

            protected void _ReadMesh(gstd.Scanner scanner, Mesh mesh)
            {
                List<List<Mesh.BoneWeightData>> vectWeight = new List<List<Mesh.BoneWeightData>>();
                while (true)
                {
                    gstd.Token tok = scanner.Next();
                    if (tok.GetType() == Token.TK_CLOSEC)
                    {
                        break;
                    }

                    if (tok.GetElement() == "Name")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        tok = scanner.Next();
                        mesh.name_ = tok.GetString();
                    }
                    else if (tok.GetElement() == "VertexCount")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        tok = scanner.Next();
                        int countVertex = tok.GetInteger();
                        mesh.SetVertexCount(countVertex);
                        vectWeight.Resize(countVertex);
                    }
                    else if (tok.GetElement() == "FaceCount")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        tok = scanner.Next();
                        int countFace = tok.GetInteger();
                        mesh.vertexIndices_.resize(countFace * 3);
                    }
                    else if (tok.GetElement() == "Positions" || tok.GetElement() == "Normals")
                    {
                        bool bPosition = tok.GetElement() == "Positions";
                        bool bNormal = tok.GetElement() == "Normals";
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);

                        int countVertex = mesh.GetVertexCount();
                        for (int iVert = 0 ; iVert < countVertex; iVert++)
                        {
                            float x = scanner.Next().GetReal();
                            scanner.CheckType(scanner.Next(), Token.TK_COLON);
                            float y = scanner.Next().GetReal();
                            scanner.CheckType(scanner.Next(), Token.TK_COLON);
                            float z = scanner.Next().GetReal();
                            scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                            if (bPosition)
                            {
                                mesh.SetVertexPosition(iVert, x, y, z);
                            }
                            else if (bNormal)
                            {
                                mesh.SetVertexNormal(iVert, x, y, z);
                            }
                        }
                        scanner.CheckType(scanner.Next(), Token.TK_CLOSEC);
                    }
                    else if (tok.GetElement() == "BlendList")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        while (true)
                        {
                            gstd.Token tok = scanner.Next();
                            if (tok.GetType() == Token.TK_CLOSEC)
                            {
                                break;
                            }
                            if (tok.GetElement() == "BlendPart")
                            {
                                scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                                scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);

                                scanner.CheckIdentifer(scanner.Next(), "BoneName");
                                scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                                string name = scanner.Next().GetString();

                                scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                                scanner.CheckIdentifer(scanner.Next(), "TransformIndex");
                                scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                                int indexBone = scanner.Next().GetInteger();

                                scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                                scanner.CheckIdentifer(scanner.Next(), "VertexBlend");
                                scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                                Bone bone = bone_[indexBone].GetPointer();
                                bone.name_ = name;

                                while (true)
                                {
                                    tok = scanner.Next();
                                    if (tok.GetType() == Token.TK_CLOSEC)
                                    {
                                        break;
                                    }
                                    if (tok.GetType() != Token.TK_INT && tok.GetType() != Token.TK_REAL)
                                    {
                                        continue;
                                    }

                                    int index = tok.GetInteger();
                                    scanner.CheckType(scanner.Next(), Token.TK_COMMA);
                                    float weight = scanner.Next().GetReal();

                                    Mesh.BoneWeightData data = new Mesh.BoneWeightData();
                                    data.index = indexBone;
                                    data.weight = weight;
                                    vectWeight[index].Add(data);
                                }
                                scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                                scanner.CheckType(scanner.Next(), Token.TK_CLOSEC);
                            }
                        }

                    }
                    else if (tok.GetElement() == "TextureUV")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);

                        int countVertex = mesh.GetVertexCount();
                        for (int iVert = 0 ; iVert < countVertex; iVert++)
                        {
                            float u = scanner.Next().GetReal();
                            scanner.CheckType(scanner.Next(), Token.TK_COLON);
                            float v = scanner.Next().GetReal();
                            scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                            mesh.SetVertexUV(iVert, u, v);
                        }
                        scanner.CheckType(scanner.Next(), Token.TK_CLOSEC);
                    }
                    else if (tok.GetElement() == "VertexIndices")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);

                        int countFace = mesh.vertexIndices_.size() / 3;
                        for (int iFace = 0 ; iFace < countFace; iFace++)
                        {
                            int face = scanner.Next().GetInteger();
                            if (face != 3)
                            {
                                throw new gstd.wexception("3���_�Ō`������Ă��Ȃ��ʂ�����܂�");
                            }
                            scanner.CheckType(scanner.Next(), Token.TK_COMMA);
                            mesh.vertexIndices_[iFace * 3] = scanner.Next().GetInteger();
                            scanner.CheckType(scanner.Next(), Token.TK_COLON);
                            mesh.vertexIndices_[iFace * 3 + 1] = scanner.Next().GetInteger();
                            scanner.CheckType(scanner.Next(), Token.TK_COLON);
                            mesh.vertexIndices_[iFace * 3 + 2] = scanner.Next().GetInteger();
                            scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        }
                        scanner.CheckType(scanner.Next(), Token.TK_CLOSEC);
                    }
                    else if (tok.GetElement() == "Attributes")
                    {
                        int attr = -1;
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        int countFace = mesh.vertexIndices_.size() / 3;
                        for (int iFace = 0 ; iFace < countFace; iFace++)
                        {
                            int index = scanner.Next().GetInteger();
                            if (attr == -1)
                            {
                                attr = index;
                            }
                            if (attr != index)
                            {
                                throw new gstd.wexception("1�I�u�W�F�N�g�ɕ����}�e���A���͔�Ή�");
                            }
                            scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        }
                        mesh.material_ = material_[attr];
                        scanner.CheckType(scanner.Next(), Token.TK_CLOSEC);
                    }
                }

                // �{�[���E�F�C�g�f�[�^����
                int boneCount = bone_.Count;
                List<double> totalWeight = new List<double>();
                totalWeight.Resize(boneCount);
                ZeroMemory(totalWeight[0], sizeof(double) * bone_.Count);
                for (int iVert = 0 ; iVert < vectWeight.Count; iVert++)
                {
                    List<Mesh.BoneWeightData> datas = vectWeight[iVert];
                    if (false)
                    {
                        // BLEND2
                        Mesh.BoneWeightData data1 = null;
                        Mesh.BoneWeightData data2 = null;
                        for (int iDatas = 0; iDatas < datas.Count; iDatas++)
                        {
                            Mesh.BoneWeightData data = datas[iDatas];
                            totalWeight[data.index] += data.weight;
                            if (data1 == null)
                            {
                                data1 = data;
                            }
                            else if (data2 == null)
                            {
                                data2 = data;
                                if (data1.weight < data2.weight)
                                {
                                    Mesh.BoneWeightData temp = data1;
                                    data1 = data2;
                                    data2 = temp;
                                }
                            }
                            else
                            {
                                if (data1.weight < data.weight)
                                {
                                    data2 = data1;
                                    data1 = data;
                                }
                                else if (data2.weight < data.weight)
                                {
                                    data2 = data;
                                }
                            }
                        }

                        // ���_�f�[�^�ɐݒ�
                        if (data1 != null && data2 != null)
                        {
                            float sub = 1.0f - data1.weight - data2.weight;
                            data1.weight += sub / 2.0f;
                            data2.weight += sub / 2.0f;
                            if (data1.weight > 1.0f)
                            {
                                data1.weight = 1.0f;
                            }
                            if (data2.weight > 1.0f)
                            {
                                data2.weight = 1.0f;
                            }
                        }

                        if (data1 != null)
                        {
                            mesh.SetVertexBlend(iVert, 0, data1.index, data1.weight);
                        }
                        if (data2 != null)
                        {
                            mesh.SetVertexBlend(iVert, 1, data2.index, data2.weight);
                        }
                    }
                    else
                    {
                        int dataCount = datas.Count;
                        for (int iDatas = 0; iDatas < dataCount; iDatas++)
                        {
                            Mesh.BoneWeightData data = datas[iDatas];
                            if (data == null)
                            {
                                continue;
                            }
                            totalWeight[data.index] += data.weight;
                            mesh.SetVertexBlend(iVert, iDatas, data.index, data.weight);
                        }
                    }
                }

                // �d�S
                double maxWeight = 0;
                mesh.CalculateWeightCenter();
                for (int iBone = 0 ; iBone < totalWeight.Count ; iBone++)
                {
                    if (totalWeight[iBone] < maxWeight)
                    {
                        continue;
                    }
                    mesh.indexWeightForCalucZValue_ = iBone;
                    maxWeight = totalWeight[iBone];
                }
            }

            protected void _ReadHierarchyList(gstd.Scanner scanner)
            {
                for (int iBone = 0 ; iBone < bone_.Count; iBone++)
                {
                    string name = bone_[iBone].name_;
                    mapBoneNameIndex_[name] = iBone;
                }

                while (true)
                {
                    gstd.Token tok = scanner.Next();
                    if (tok.GetType() == Token.TK_CLOSEC)
                    {
                        break;
                    }
                    if (tok.GetElement() == "Node")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        _ReadNode(scanner, Bone.NO_PARENT);
                    }
                }
            }

            protected int _ReadNode(gstd.Scanner scanner, int parent)
            {
                int indexBone = -1;
                Bone bone = null;
                while (true)
                {
                    gstd.Token tok = scanner.Next();
                    if (tok.GetType() == Token.TK_CLOSEC)
                    {
                        break;
                    }
                    if (tok.GetElement() == "NodeName")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        string name = scanner.Next().GetString();
                        indexBone = mapBoneNameIndex_[name];
                        bone = bone_[indexBone].GetPointer();
                        bone.indexParent_ = parent;
                    }
                    else if (tok.GetElement() == "InitPostureMatrix")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        for (int iCount = 0; iCount < 16; iCount++)
                        {
                            bone.matInitPosture_.m[iCount / 4][iCount % 4] = scanner.Next().GetReal();
                            if (iCount <= 14)
                            {
                                scanner.CheckType(scanner.Next(), Token.TK_COLON);
                            }
                        }
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                    }
                    if (tok.GetElement() == "Node")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        int indexChild = _ReadNode(scanner, indexBone);
                        bone.indexChild_.push_back(indexChild);
                    }
                }
                return indexBone;
            }

            protected void _ReadAnimationList(gstd.Scanner scanner)
            {
                while (true)
                {
                    gstd.Token tok = scanner.Next();
                    if (tok.GetType() == Token.TK_CLOSEC)
                    {
                        break;
                    }
                    if (tok.GetElement() == "AnimationCount")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        scanner.Next().GetInteger();
                    }
                    else if (tok.GetElement() == "AnimationData")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        gstd.ref_count_ptr<AnimationData> anime = _ReadAnimationData(scanner);
                        if (anime != null)
                        {
                            anime_[anime.name_].CopyFrom(anime);
                        }
                    }
                }
            }

            protected gstd.ref_count_ptr<ElfreinaMeshData.AnimationData> _ReadAnimationData(gstd.Scanner scanner)
            {
                gstd.ref_count_ptr<AnimationData> anime = new AnimationData();
                anime.animeBone_.resize(bone_.Count);
                AnimationData pAnime = anime.GetPointer();
                while (true)
                {
                    gstd.Token tok = scanner.Next();
                    if (tok.GetType() == Token.TK_CLOSEC)
                    {
                        break;
                    }
                    if (tok.GetElement() == "AnimationName")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        pAnime.name_ = scanner.Next().GetString();
                    }
                    else if (tok.GetElement() == "AnimationTime")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        pAnime.timeTotal_ = scanner.Next().GetInteger();
                    }
                    else if (tok.GetElement() == "FrameParSecond")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        pAnime.framePerSecond_ = scanner.Next().GetInteger();
                    }
                    else if (tok.GetElement() == "TransitionTime")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                    }
                    else if (tok.GetElement() == "Priority")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                    }
                    else if (tok.GetElement() == "Loop")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        string id = scanner.Next().GetElement();
                        pAnime.bLoop_ = id == "True";
                    }
                    else if (tok.GetElement() == "BoneAnimation")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        _ReadBoneAnimation(scanner, pAnime);
                    }
                    else if (tok.GetElement() == "UVAnimation")
                    {
                        // TODO
                        int count = 1;
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        while (true)
                        {
                            tok = scanner.Next();
                            if (tok.GetType() == Token.TK_OPENC)
                            {
                                count++;
                            }
                            else if (tok.GetType() == Token.TK_CLOSEC)
                            {
                                count--;
                            }
                            if (count == 0)
                            {
                                break;
                            }
                        }
                    }
                }
                return new gstd.ref_count_ptr<AnimationData>(anime);
            }

            protected void _ReadBoneAnimation(gstd.Scanner scanner, AnimationData anime)
            {
                while (true)
                {
                    gstd.Token tok = scanner.Next();
                    if (tok.GetType() == Token.TK_CLOSEC)
                    {
                        break;
                    }
                    if (tok.GetElement() == "TimeKeys")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        while (scanner.Next().GetType() != Token.TK_CLOSEC)
                        {
                        }
                    }
                    else if (tok.GetElement() == "AnimationPart")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        _ReadBoneAnimationPart(scanner, anime);
                    }
                }
            }

            protected void _ReadBoneAnimationPart(gstd.Scanner scanner, AnimationData anime)
            {
                int indexBone = -1;
                BoneAnimationPart part = new BoneAnimationPart();
                while (true)
                {
                    gstd.Token tok = scanner.Next();
                    if (tok.GetType() == Token.TK_CLOSEC)
                    {
                        break;
                    }
                    if (tok.GetElement() == "NodeName")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        string name = scanner.Next().GetString();
                        indexBone = mapBoneNameIndex_[name];
                    }
                    else if (tok.GetElement() == "TimeKeys")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        while (true)
                        {
                            gstd.Token tok = scanner.Next();
                            if (tok.GetType() == Token.TK_CLOSEC)
                            {
                                break;
                            }
                            if (tok.GetType() != Token.TK_INT && tok.GetType() != Token.TK_REAL)
                            {
                                continue;
                            }
                            part.keyTime_.push_back(tok.GetReal());
                        }
                    }
                    else if (tok.GetElement() == "TransKeys" || tok.GetElement() == "ScaleKeys" || tok.GetElement() == "RotateKeys")
                    {
                        bool bTrans = tok.GetElement() == "TransKeys";
                        bool bScale = tok.GetElement() == "ScaleKeys";
                        bool bRotate = tok.GetElement() == "RotateKeys";
                        scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                        scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        while (true)
                        {
                            gstd.Token tok = scanner.Next();
                            if (tok.GetType() == Token.TK_CLOSEC)
                            {
                                break;
                            }
                            if (tok.GetType() != Token.TK_INT && tok.GetType() != Token.TK_REAL)
                            {
                                continue;
                            }
                            float x = tok.GetReal();
                            scanner.CheckType(scanner.Next(), Token.TK_COLON);
                            float y = scanner.Next().GetReal();
                            scanner.CheckType(scanner.Next(), Token.TK_COLON);
                            float z = scanner.Next().GetReal();

                            if (bTrans || bScale)
                            {
                                D3DXVECTOR3 vect = new D3DXVECTOR3(x, y, z);
                                if (bTrans)
                                {
                                    part.keyTrans_.push_back(vect);
                                }
                                else if (bScale)
                                {
                                    part.keyScale_.push_back(vect);
                                }
                            }
                            else if (bRotate)
                            {
                                scanner.CheckType(scanner.Next(), Token.TK_COLON);
                                float w = scanner.Next().GetReal();

                                D3DXQUATERNION vect = new D3DXQUATERNION(x, y, z, w);
                                part.keyRotate_.push_back(vect);
                            }

                            scanner.CheckType(scanner.Next(), Token.TK_NEWLINE);
                        }
                    }
                }
                if (indexBone != -1)
                {
                    anime.animeBone_[indexBone] = part;
                }
            }


            /**********************************************************
            //ElfreinaMesh
            **********************************************************/
            // ElfreinaMeshData
            public ElfreinaMeshData()
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
                int size = reader.GetFileSize();
                List<char> textUtf8 = new List<char>();
                textUtf8.Resize(size+1);
                reader.Read(textUtf8[0], size);
                textUtf8[size] = '\0';

                // �����R�[�h�ϊ�
                string text = StringUtility.ConvertUtf8ToWide(textUtf8);

                gstd.Scanner scanner = new gstd.Scanner(text);
                try
                {
                    while (scanner.HasNext())
                    {
                        gstd.Token tok = scanner.Next();
                        if (tok.GetElement() == "MeshContainer")
                        {
                            scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                            _ReadMeshContainer(scanner);
                        }
                        else if (tok.GetElement() == "HierarchyList")
                        {
                            scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                            _ReadHierarchyList(scanner);
                        }
                        else if (tok.GetElement() == "AnimationList")
                        {
                            scanner.CheckType(scanner.Next(), Token.TK_OPENC);
                            _ReadAnimationList(scanner);
                        }
                    }

                    // ���_�o�b�t�@�쐬
                    for (int iMesh = 0 ; iMesh < mesh_.Count; iMesh++)
                    {
                        mesh_[iMesh].InitializeVertexBuffer();
                    }

                    res = true;
                }
                catch (gstd.wexception e)
                {
                    Logger.WriteTop(StringUtility.Format("ElfreinaMeshData�ǂݍ��ݎ��s %s %d", e.what(), scanner.GetCurrentLine()));
                    res = false;
                }

                if (false)
                {
                    Logger.WriteTop(StringUtility.Format("ElfreinaMeshData�ǂݍ��ݐ���[%s]", reader.GetOriginalPath().c_str()));
                    for (int iMesh = 0 ; iMesh < mesh_.Count; iMesh++)
                    {
                        string name = mesh_[iMesh].name_;
                        string log = " Mesh ";
                        log += StringUtility.Format("name[%s] ",name);
                        log += StringUtility.Format("vert[%d] ",mesh_[iMesh].GetVertexCount());
                        Logger.WriteTop(log);

                        if (iMesh == 6)
                        {
                            int countVert = mesh_[iMesh].GetVertexCount();
                            int iVert = 0;
                            for (iVert = 0;iVert < countVert;iVert++)
                            {
                                VERTEX_B4NX vert = mesh_[iMesh].GetVertex(iVert);
                                // VERTEX_B2NX* vert = mesh_[iMesh]->GetVertex(iVert);
                                log = "  vert ";
                                log += StringUtility.Format("pos[%f,%f,%f] ",vert.position.x, vert.position.y, vert.position.z);
                                log += StringUtility.Format("blend1[%d,%f] ",BitAccess.GetByte(vert.blendIndex, 0), vert.blendRate);
                                log += StringUtility.Format("blend2[%d] ",BitAccess.GetByte(vert.blendIndex, 4));
                                Logger.WriteTop(log);
                            }

                            int iFace = 0;
                            List<short> indexVert = mesh_[iMesh].vertexIndices_;
                            int countFace = mesh_[iMesh].vertexIndices_.size() / 3;
                            for (iFace = 0;iFace < countFace;iFace++)
                            {
                                log = "  vert ";
                                log += StringUtility.Format("index[%d,%d,%d] ", indexVert[iFace * 3], indexVert[iFace * 3 + 1], indexVert[iFace * 3 + 2]);
                                Logger.WriteTop(log);
                            }

                        }
                    }
                    for (int iBone = 0; iBone < bone_.Count; iBone++)
                    {
                        string log = " Bone ";
                        string name = bone_[iBone].name_;
                        log += StringUtility.Format("name[%s] ",name);
                        Logger.WriteTop(log);
                    }

                    SortedDictionary<string, gstd.ref_count_ptr<AnimationData>>.Enumerator itr;
                    for (itr = anime_.GetEnumerator(); itr.MoveNext();)
                    {
                        string name = itr.Current.Key;
                        string log = " Anime ";
                        log += StringUtility.Format("name[%s] ",name);
                        Logger.WriteTop(log);

                    }
                }

                return res;
            }

            public List<gstd.ref_count_ptr<Bone>> GetBones()
            {
                return new List<gstd.ref_count_ptr<Bone>>(bone_);
            }
    }


    public class RenderObjectElfreinaBlock : RenderObjectB2NXBlock
    {

            // RenderObjectElfreinaBlock
            public new void Dispose()
            {

                base.Dispose();
            }

            public override bool IsTranslucent()
            {
                ElfreinaMeshData.Mesh obj = (ElfreinaMeshData.Mesh)obj_.GetPointer();
                D3DMATERIAL9 mat = obj.material_.mat_;
                bool bTrans = true;
                bTrans &= (mat.Diffuse.a != 1.0f);
                return base.IsTranslucent() || bTrans;
            }

            public override void CalculateZValue()
            {
                DirectGraphics graph = DirectGraphics.GetBase();
                IDirect3DDevice9 pDevice = graph.GetDevice();
                ElfreinaMeshData.Mesh obj = (ElfreinaMeshData.Mesh)obj_.GetPointer();

                D3DXMATRIX matTrans = obj._CreateWorldTransformMaxtrix();
                D3DXMATRIX matView = new D3DXMATRIX();
                D3DXMATRIX matPers = new D3DXMATRIX();
                pDevice.GetTransform(D3DTS_VIEW, matView);
                pDevice.GetTransform(D3DTS_PROJECTION, matPers);
                D3DXMATRIX matAnime = matrix_.GetMatrix(obj.indexWeightForCalucZValue_);

                D3DXMATRIX mat = matAnime * matTrans * matView * matPers;
                D3DXVECTOR3 posCenter = obj.GetWeightCenter();
                D3DXVec3TransformCoord(posCenter, posCenter, mat);
                posSortKey_ = posCenter.z;
            }
    }

    public class ElfreinaMesh : DxMesh
    {
            protected double _CalcFrameToTime(double time, gstd.ref_count_ptr<ElfreinaMeshData.AnimationData> anime)
            {
                bool bLoop = anime.bLoop_;
                int framePerSec = anime.framePerSecond_;
                time = (int)((double)1000 / (double)framePerSec * (double)time);

                int timeTotal = anime.timeTotal_;
                if (bLoop)
                {
                    int tTime = (int)time / timeTotal;
                    time -= (int)timeTotal * tTime;
                }
                else
                {
                    if (time > timeTotal)
                    {
                        time = timeTotal;
                    }
                }
                return time;
            }

            public ElfreinaMesh()
            {
            }
            public override void Dispose()
            {
                base.Dispose();
            }

            // ElfreinaMesh
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
                        data_ = new ElfreinaMeshData();
                        data_.SetName(name);
                        ElfreinaMeshData data = (ElfreinaMeshData)data_.GetPointer();
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
                return base.CreateFromFileInLoadThread(path, MESH_ELFREINA);
            }

            public override string GetPath()
            {
                if (data_ == null)
                {
                    return "";
                }
                return ((ElfreinaMeshData)data_.GetPointer()).path_;
            }

            public override void Render()
            {
                if (data_ == null)
                {
                    return;
                }

                ElfreinaMeshData data = (ElfreinaMeshData)data_.GetPointer();
                for (int iMesh = 0 ; iMesh < data.mesh_.size(); iMesh++)
                {
                    ElfreinaMeshData.Mesh mesh = data.mesh_[iMesh].GetPointer();
                    mesh.SetPosition(position_);
                    mesh.SetAngle(angle_);
                    mesh.SetScale(scale_);
                    mesh.SetColor(color_);
                    mesh.SetCoordinate2D(bCoordinate2D_);
                    mesh.Render();
                }
                // mesh_[6]->Render();
            }

            public override void Render(string nameAnime, int time)
            {
                if (data_ == null)
                {
                    return;
                }

                gstd.ref_count_ptr<Matrices> matrix = CreateAnimationMatrix(nameAnime, time);
                if (matrix == null)
                {
                    return;
                }

                ElfreinaMeshData data = (ElfreinaMeshData)data_.GetPointer();
                while (!data.bLoad_)
                {
                    global::Sleep(1);
                }

                for (int iMesh = 0 ; iMesh < data.mesh_.size(); iMesh++)
                {
                    ElfreinaMeshData.Mesh mesh = data.mesh_[iMesh].GetPointer();
                    mesh.SetMatrix(matrix);
                }
                Render();
            }

            public new gstd.ref_count_ptr<RenderBlocks> CreateRenderBlocks()
            {
                if (data_ == null)
                {
                    return null;
                }
                gstd.ref_count_ptr<RenderBlocks> res = new RenderBlocks();
                ElfreinaMeshData data = (ElfreinaMeshData)data_.GetPointer();
                for (int iMesh = 0 ; iMesh < data.mesh_.size(); iMesh++)
                {
                    gstd.ref_count_ptr<ElfreinaMeshData.Mesh> mesh = data.mesh_[iMesh];
                    mesh.SetPosition(position_);
                    mesh.SetAngle(angle_);
                    mesh.SetScale(scale_);
                    mesh.SetColor(color_);

                    gstd.ref_count_ptr<RenderBlock> block = mesh.CreateRenderBlock();
                    block.SetRenderObject(mesh);
                    res.Add(block);
                }
                return new gstd.ref_count_ptr<RenderBlocks>(res);
            }

            public gstd.ref_count_ptr<RenderBlocks> CreateRenderBlocks(string nameAnime, double time)
            {
                if (data_ == null)
                {
                    return null;
                }

                gstd.ref_count_ptr<Matrices> matrix = CreateAnimationMatrix(nameAnime, time);
                if (matrix == null)
                {
                    return null;
                }
                ElfreinaMeshData data = (ElfreinaMeshData)data_.GetPointer();
                for (int iMesh = 0 ; iMesh < data.mesh_.size(); iMesh++)
                {
                    ElfreinaMeshData.Mesh mesh = data.mesh_[iMesh].GetPointer();
                    mesh.SetMatrix(matrix);
                }

                return new gstd.ref_count_ptr<RenderBlocks>(CreateRenderBlocks());
            }

            public gstd.ref_count_ptr<Matrices> CreateAnimationMatrix(string nameAnime, double time)
            {
                if (data_ == null)
                {
                    return null;
                }

                ElfreinaMeshData data = (ElfreinaMeshData)data_.GetPointer();
                bool bExist = data.anime_.find(nameAnime) != data.anime_.end();
                if (!bExist)
                {
                    return null;
                }
                gstd.ref_count_ptr<ElfreinaMeshData.AnimationData> anime = data.anime_[nameAnime];

                // ���[�v�L���Ŏ��Ԃ�v�Z����
                time = _CalcFrameToTime(time, new gstd.ref_count_ptr<ElfreinaMeshData.AnimationData>(anime));

                gstd.ref_count_ptr<Matrices> matrix = anime.CreateBoneAnimationMatrix(time, data);
                return new gstd.ref_count_ptr<Matrices>(matrix);
            }

            public override D3DXMATRIX GetAnimationMatrix(string nameAnime, double time, string nameBone)
            {
                D3DXMATRIX res = new D3DXMATRIX();
                ElfreinaMeshData data = (ElfreinaMeshData)data_.GetPointer();
                if (data.mapBoneNameIndex_.find(nameBone) != data.mapBoneNameIndex_.end())
                {
                    int indexBone = data.mapBoneNameIndex_[nameBone];
                    bool bExist = data.anime_.find(nameAnime) != data.anime_.end();
                    if (bExist)
                    {
                        gstd.ref_count_ptr<ElfreinaMeshData.AnimationData> anime = data.anime_[nameAnime];

                        // ���[�v�L���Ŏ��Ԃ�v�Z����
                        time = _CalcFrameToTime(time, new gstd.ref_count_ptr<ElfreinaMeshData.AnimationData>(anime));
                        gstd.ref_count_ptr<Matrices> matrix = anime.CreateBoneAnimationMatrix(time, data);
                        D3DXMATRIX matBone = matrix.GetMatrix(indexBone);

                        D3DXMATRIX matInv = data.bone_[indexBone].matOffset_;
                        D3DXMatrixInverse(matInv, null, matInv);
            // 			D3DXVECTOR3 pos;
            // 			D3DXVec3TransformCoord(&pos, &D3DXVECTOR3(0,0,0), &matInv);
            // 			D3DXMatrixTranslation(&matInv,pos.x,pos.y,pos.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res = matInv * matBone;
                        res.CopyFrom(matInv * matBone);

                        D3DXMATRIX matScale = new D3DXMATRIX();
                        D3DXMatrixScaling(matScale, scale_.x, scale_.y, scale_.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res = res * matScale;
                        res.CopyFrom(res * matScale);

                        D3DXMATRIX matRot = new D3DXMATRIX();
                        D3DXMatrixRotationYawPitchRoll(matRot, D3DXToRadian(angle_.y), D3DXToRadian(angle_.x), D3DXToRadian(angle_.z));
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res = res * matRot;
                        res.CopyFrom(res * matRot);

                        D3DXMATRIX matTrans = new D3DXMATRIX();
                        D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res = res * matTrans;
                        res.CopyFrom(res * matTrans);
                    }
                }
                return new D3DXMATRIX(res);
            }
    }
}
