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
    // http://msdn.microsoft.com/ja-jp/library/bb944006(v=vs.85).aspx
    // http://msdn.microsoft.com/ja-jp/library/bb509647(v=vs.85).aspx

// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class ShaderManager;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class Shader;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class ShaderData;
    /**********************************************************
    //ShaderData
    **********************************************************/
    public class ShaderData : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend Shader;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend ShaderManager;
            private ShaderManager manager_;
            private ID3DXEffect effect_;
            private string name_ = "";
// C++ TO C# CONVERTER TODO TASK: 'volatile' has a different meaning in C#:
// ORIGINAL LINE: volatile bool bLoad_;
            private bool bLoad_;
// C++ TO C# CONVERTER TODO TASK: 'volatile' has a different meaning in C#:
// ORIGINAL LINE: volatile bool bText_;
            private bool bText_;


            /**********************************************************
            //ShaderData
            **********************************************************/
            public ShaderData()
            {
                manager_ = null;
                bLoad_ = false;
                effect_ = null;
                bText_ = false;
            }

            public virtual void Dispose()
            {
            }

            public string GetName()
            {
                return name_;
            }
    }

    /**********************************************************
    //ShaderManager
    **********************************************************/
    public class ShaderManager : DirectGraphicsListener
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend Shader;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend ShaderData;
        private static ShaderManager thisBase_ = null;
            protected gstd.CriticalSection lock_ = new gstd.CriticalSection();
            protected SortedDictionary<string, gstd.ref_count_ptr<Shader>> mapShader_ = new SortedDictionary<string, gstd.ref_count_ptr<Shader>>();
            protected SortedDictionary<string, gstd.ref_count_ptr<ShaderData>> mapShaderData_ = new SortedDictionary<string, gstd.ref_count_ptr<ShaderData>>();

            protected LinkedList<Shader> listExecuteShader_ = new LinkedList<Shader>();
            protected string lastError_ = "";

            protected void _ReleaseShaderData(string name)
            {
                {
                    Lock @lock = new Lock(lock_);
                    if (IsDataExists(name))
                    {
                        mapShaderData_[name].bLoad_ = true; // �ǂݍ��݊�������
                        mapShaderData_.Remove(name);
                        Logger.WriteTop(StringUtility.Format("ShaderManager�FShader�������܂���(Shader Released)[%s]", name));
                    }
                }
            }

            protected bool _CreateFromFile(string path)
            {
                lastError_ = "";
                if (IsDataExists(path))
                {
                    return true;
                }

                path = PathProperty.GetUnique(path);
                ref_count_ptr<FileReader> reader = FileManager.GetBase().GetFileReader(path);
                if (reader == null || !reader.Open())
                {
                    string log = StringUtility.Format("Shader�ǂݍ��ݎ��s(Shader Load Failed)�F\r\n%s", path);
                    Logger.WriteTop(log);
                    lastError_ = log;
                    return false;
                }

                int size = reader.GetFileSize();
                ByteBuffer buf = new ByteBuffer();
                buf.SetSize(size);
                reader.Read(buf.GetPointer(), size);

                string source;
                source.resize(size);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(source[0], buf.GetPointer(), size);

                gstd.ref_count_ptr<ShaderData> data = new gstd.ref_count_ptr<ShaderData>(new ShaderData());

                DirectGraphics graphics = DirectGraphics.GetBase();
                ID3DXBuffer pErr = null;
                int hr = D3DXCreateEffect(graphics.GetDevice(), source, source.Length, null, null, 0, null, data.effect_, pErr);

                bool res = true;
                if (FAILED(hr))
                {
                    res = false;
                    string err = "";
                    if (pErr != null)
                    {
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: char* cText = (char*)pErr->GetBufferPointer();
                        char cText = (string)pErr.GetBufferPointer();
                        err = StringUtility.ConvertMultiToWide(cText);
                    }
                    string log = StringUtility.Format("Shader�ǂݍ��ݎ��s(Shader Load Failed)�F\r\n%s\r\n[%s]", path, err);
                    Logger.WriteTop(log);
                    lastError_ = log;
                }
                else
                {
                    string log = StringUtility.Format("Shader�ǂݍ���(Shader Load Success)�F\r\n%s", path);
                    Logger.WriteTop(log);

                    mapShaderData_[path].CopyFrom(data);
                    data.manager_ = this;
                    data.name_ = path;
                }
                return res;
            }

            protected bool _CreateFromText(string source)
            {
                lastError_ = "";
                string id = _GetTextSourceID(source);
                if (IsDataExists(id))
                {
                    return true;
                }

                bool res = true;
                DirectGraphics graphics = DirectGraphics.GetBase();

                gstd.ref_count_ptr<ShaderData> data = new gstd.ref_count_ptr<ShaderData>(new ShaderData());
                ID3DXBuffer pErr = null;
                int hr = D3DXCreateEffect(graphics.GetDevice(), source, source.Length, null, null, 0, null, data.effect_, pErr);

                string tStr = StringUtility.Slice(source, 128);
                if (FAILED(hr))
                {
                    res = false;
                    string err = "";
                    if (pErr != null)
                    {
                        err = (string)pErr.GetBufferPointer();
                    }
                    string log = StringUtility.Format("Shader�ǂݍ��ݎ��s(Load Shader Failed)�F\r\n%s\r\n[%s]", tStr, err);
                    Logger.WriteTop(log);
                    lastError_ = log;
                }
                else
                {
                    string log = "Shader�ǂݍ���(Load Shader Success)�F";
                    log += StringUtility.FormatToWide("%s", tStr);
                    Logger.WriteTop(log);

                    mapShaderData_[id].CopyFrom(data);
                    data.manager_ = this;
                    data.name_ = id;
                    data.bText_ = true;
                }

                return res;
            }

            protected void _BeginShader(Shader shader, int pass)
            {
                Shader lastShader = null;
                if (listExecuteShader_.Count > 0)
                {
                    lastShader = *listExecuteShader_.rbegin();
                }

                if (shader != null && shader != lastShader)
                {
                    if (lastShader != null)
                    {
                        lastShader._EndPass();
                        lastShader._End();
                    }

                    shader._Begin();
                    shader._BeginPass(pass);
                }
                else if (shader == null && lastShader != null)
                {
                    lastShader._EndPass();
                    lastShader._End();
                }

                listExecuteShader_.AddLast(shader);
            }

            protected void _EndShader(Shader shader)
            {
                Shader preShader = null;
                if (listExecuteShader_.Count > 0)
                {
                    preShader = *listExecuteShader_.rbegin();
                    listExecuteShader_.RemoveLast();
                }

                if (shader != preShader)
                {
                    throw new gstd.wexception("EndShader�ُ�");
                }

                preShader = null;
                if (listExecuteShader_.Count > 0)
                {
                    preShader = *listExecuteShader_.rbegin();
                }

                // ����Shader�Ȃ牽����Ȃ�
                if (shader == preShader)
                {
                    return;
                }
                shader._EndPass();
                shader._End();

                if (preShader != null)
                {
                    shader._Begin();
                    shader._BeginPass();
                }

            }

            protected static string _GetTextSourceID(string source)
            {
                string res = StringUtility.ConvertMultiToWide(source);
                res = StringUtility.Slice(res, 64);
                return res;
            }

            public ShaderManager()
            {
            }

            public override void Dispose()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.RemoveDirectGraphicsListener(this);

                Clear();
                base.Dispose();
            }

            public static ShaderManager GetBase()
            {
                return thisBase_;
            }
            public virtual bool Initialize()
            {
                if (thisBase_ != null)
                {
                    return false;
                }

                bool res = true;
                thisBase_ = this;
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.AddDirectGraphicsListener(this);

                ref_count_ptr<Shader> shaderSkinedMesh = new Shader();
                string sourceSkinedMesh = GlobalMembers.HLSL_DEFAULT_SKINED_MESH;
                shaderSkinedMesh.CreateFromText(sourceSkinedMesh);
                AddShader(GlobalMembers.NAME_DEFAULT_SKINNED_MESH, new ref_count_ptr<Shader>(shaderSkinedMesh));

            // 	shaderSkinedMesh->Begin();
            // 	shaderSkinedMesh->End();

            /*
            	ref_count_ptr<Shader> shaderTest = new Shader();
            	std::string pathDir = PathProperty::GetModuleDirectory() + "shader\\";
            	shaderTest->CreateFromFile(pathDir + "Sharder_SkinnedMesh.txt");
            	AddShader(NAME_DEFAULT_SKINNED_MESH, shaderTest);
            */
            /*
            	File file(pathDir + "test.txt");
            	if(file.Open())
            	{
            		std::string str;
            		int size = file.GetSize();
            		str.resize(size);
            		file.Read(&str[0], size);
            
            		ref_count_ptr<Shader> shaderTestFile = new Shader();
            		shaderTestFile->CreateFromText(str);
            	}
            */
                return res;
            }

            public gstd.CriticalSection GetLock()
            {
                return new gstd.CriticalSection(lock_);
            }
            public void Clear()
            {
                {
                    Lock @lock = new Lock(lock_);
                    mapShader_.Clear();
                    mapShaderData_.Clear();
                }
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
                SortedDictionary<string, gstd.ref_count_ptr<Shader>>.Enumerator itrMap;
                {
                    for (itrMap = mapShader_.GetEnumerator(); itrMap.MoveNext();)
                    {
                        string name = itrMap.Current.Key;
                        Shader data = (itrMap.Current.Value).GetPointer();
                        data.ReleaseDxResource();
                    }
                }
            }

            public void RestoreDxResource()
            {
                SortedDictionary<string, gstd.ref_count_ptr<Shader>>.Enumerator itrMap;
                {
                    for (itrMap = mapShader_.GetEnumerator(); itrMap.MoveNext();)
                    {
                        string name = itrMap.Current.Key;
                        Shader data = (itrMap.Current.Value).GetPointer();
                        data.RestoreDxResource();
                    }
                }
            }

            public virtual bool IsDataExists(string name)
            {
                bool res = false;
                {
                    Lock @lock = new Lock(lock_);
                    res = mapShaderData_.ContainsKey(name);
                }
                return res;
            }

            public gstd.ref_count_ptr<ShaderData> GetShaderData(string name)
            {
                gstd.ref_count_ptr<ShaderData> res = new gstd.ref_count_ptr<ShaderData>();
                {
                    Lock @lock = new Lock(lock_);
                    bool bExist = mapShaderData_.ContainsKey(name);
                    if (bExist)
                    {
                        res.CopyFrom(mapShaderData_[name]);
                    }
                }
                return new gstd.ref_count_ptr<ShaderData>(res);
            }

            public gstd.ref_count_ptr<Shader> CreateFromFile(string path)
            {
                path = PathProperty.GetUnique(path);
                gstd.ref_count_ptr<Shader> res = new gstd.ref_count_ptr<Shader>();
                {
                    Lock @lock = new Lock(lock_);
                    bool bExist = mapShader_.ContainsKey(path);
                    if (bExist)
                    {
                        res.CopyFrom(mapShader_[path]);
                    }
                    else
                    {
                        bool bSuccess = _CreateFromFile(path);
                        if (bSuccess)
                        {
                            res = new Shader();
                            res.data_ = mapShaderData_[path];
                        }
                    }
                }
                return new gstd.ref_count_ptr<Shader>(res);
            }

            public gstd.ref_count_ptr<Shader> CreateFromText(string source)
            {
                gstd.ref_count_ptr<Shader> res = new gstd.ref_count_ptr<Shader>();
                {
                    Lock @lock = new Lock(lock_);
                    string id = _GetTextSourceID(source);
                    bool bExist = mapShader_.ContainsKey(id);
                    if (bExist)
                    {
                        res.CopyFrom(mapShader_[id]);
                    }
                    else
                    {
                        bool bSuccess = _CreateFromText(source);
                        if (bSuccess)
                        {
                            res = new Shader();
                            res.data_ = mapShaderData_[id];
                        }
                    }
                }
                return new gstd.ref_count_ptr<Shader>(res);
            }

            public gstd.ref_count_ptr<Shader> CreateFromFileInLoadThread(string path)
            {
                return false;
            }

            public virtual void CallFromLoadThread(gstd.ref_count_ptr<gstd.FileManager.LoadThreadEvent> @event)
            {
            }

            public void AddShader(string name, gstd.ref_count_ptr<Shader> shader)
            {
                {
                    Lock @lock = new Lock(lock_);
                    mapShader_[name].CopyFrom(shader);
                }
            }

            public void DeleteShader(string name)
            {
                {
                    Lock @lock = new Lock(lock_);
                    mapShader_.Remove(name);
                }
            }

            public gstd.ref_count_ptr<Shader> GetShader(string name)
            {
                gstd.ref_count_ptr<Shader> res = new gstd.ref_count_ptr<Shader>();
                {
                    Lock @lock = new Lock(lock_);
                    bool bExist = mapShader_.ContainsKey(name);
                    if (bExist)
                    {
                        res.CopyFrom(mapShader_[name]);
                    }
                }
                return new gstd.ref_count_ptr<Shader>(res);
            }

            public gstd.ref_count_ptr<Shader> GetDefaultSkinnedMeshShader()
            {
                gstd.ref_count_ptr<Shader> res = GetShader(GlobalMembers.NAME_DEFAULT_SKINNED_MESH);
                return new gstd.ref_count_ptr<Shader>(res);
            }

            public void CheckExecutingShaderZero()
            {
                if (listExecuteShader_.Count > 0)
                {
                    throw new gstd.wexception("CheckExecutingShaderZero");
                }
            }

            public string GetLastError()
            {
                string res;
                {
                    Lock @lock = new Lock(lock_);
                    res = lastError_;
                }
                return res;
            }
    }

    /**********************************************************
    //ShaderParameter
    **********************************************************/
    public class ShaderParameter : System.IDisposable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                TYPE_UNKNOWN,
                TYPE_MATRIX,
                TYPE_MATRIX_ARRAY,
                TYPE_VECTOR,
                TYPE_FLOAT,
                TYPE_FLOAT_ARRAY,
                TYPE_TEXTURE
            }
            private int type_;
            private gstd.ref_count_ptr<gstd.ByteBuffer> value_ = new gstd.ref_count_ptr<gstd.ByteBuffer>();
            private gstd.ref_count_ptr<Texture> texture_ = new gstd.ref_count_ptr<Texture>();



            /**********************************************************
            //ShaderParameter
            **********************************************************/
            public ShaderParameter()
            {
                type_ = (int)AnonymousEnum.TYPE_UNKNOWN;
                value_ = new ByteBuffer();
            }

            public virtual void Dispose()
            {
            }

            public int GetType()
            {
                return type_;
            }
            public void SetMatrix(D3DXMATRIX matrix)
            {
                type_ = (int)AnonymousEnum.TYPE_MATRIX;
                int size = sizeof(D3DXMATRIX);
                value_.Seek(0);
                value_.Write(matrix, size);
            }

            public D3DXMATRIX GetMatrix()
            {
                D3DXMATRIX res = (D3DXMATRIX) * value_.GetPointer();
                return new D3DXMATRIX(res);
            }

            public void SetMatrixArray(List<D3DXMATRIX> listMatrix)
            {
                type_ = (int)AnonymousEnum.TYPE_MATRIX_ARRAY;
                value_.Seek(0);
                for (int iMatrix = 0 ; iMatrix < listMatrix.Count ; iMatrix++)
                {
                    int size = sizeof(D3DMATRIX);
                    D3DXMATRIX matrix = listMatrix[iMatrix];
                    value_.Write(matrix.m, size);
                }

            }

            public List<D3DXMATRIX> GetMatrixArray()
            {
                List<D3DXMATRIX> res = new List<D3DXMATRIX>();
                int count = value_.GetSize() / sizeof(D3DMATRIX);
                res.Resize(count);

                value_.Seek(0);
                for (int iMatrix = 0 ; iMatrix < res.Count ; iMatrix++)
                {
                    value_.Read(res[iMatrix].m, sizeof(D3DMATRIX));
                }

                return new List<D3DXMATRIX>(res);
            }

            public void SetVector(D3DXVECTOR4 vector)
            {
                type_ = (int)AnonymousEnum.TYPE_VECTOR;
                int size = sizeof(D3DXVECTOR4);
                value_.Seek(0);
                value_.Write(vector, size);
            }

            public D3DXVECTOR4 GetVector()
            {
                D3DXVECTOR4 res = (D3DXVECTOR4) * value_.GetPointer();
                return new D3DXVECTOR4(res);
            }

            public void SetFloat(float value)
            {
                type_ = (int)AnonymousEnum.TYPE_FLOAT;
                int size = sizeof(float);
                value_.Seek(0);
                value_.Write(value, size);
            }

            public float GetFloat()
            {
                float res = (float) * value_.GetPointer();
                return res;
            }

            public void SetFloatArray(List<float> values)
            {
                type_ = (int)AnonymousEnum.TYPE_FLOAT_ARRAY;
                int size = sizeof(float) * values.Count;
                value_.Seek(0);
                value_.Write(values[0], size);
            }

            public List<float> GetFloatArray()
            {
                List<float> res = new List<float>();
                int count = value_.GetSize() / sizeof(float);
                res.Resize(count);

                value_.Seek(0);
                value_.Read(res[0], value_.GetSize());
                return new List<float>(res);
            }

            public void SetTexture(gstd.ref_count_ptr<Texture> texture)
            {
                type_ = (int)AnonymousEnum.TYPE_TEXTURE;
                texture_.CopyFrom(texture);
            }

            public gstd.ref_count_ptr<Texture> GetTexture()
            {
                return new gstd.ref_count_ptr<Texture>(texture_);
            }

    }

    /**********************************************************
    //Shader
    **********************************************************/
    public class Shader : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend ShaderManager;
            protected gstd.ref_count_ptr<ShaderData> data_ = new gstd.ref_count_ptr<ShaderData>();

            // bool bLoadShader_;
            // IDirect3DVertexShader9* pVertexShader_;
            // IDirect3DPixelShader9* pPixelShader_;

            protected string technique_ = "";
            protected SortedDictionary<string, gstd.ref_count_ptr<ShaderParameter>> mapParam_ = new SortedDictionary<string, gstd.ref_count_ptr<ShaderParameter>>();

            protected ShaderData _GetShaderData()
            {
                return data_.GetPointer();
            }
            protected gstd.ref_count_ptr<ShaderParameter> _GetParameter(string name, bool bCreate)
            {
                bool bFind = mapParam_.ContainsKey(name);
                if (!bFind && !bCreate)
                {
                    return null;
                }

                gstd.ref_count_ptr<ShaderParameter> res = null;
                if (!bFind)
                {
                    res = new ShaderParameter();
                    mapParam_[name].CopyFrom(res);
                }
                else
                {
                    res.CopyFrom(mapParam_[name]);
                }

                return new gstd.ref_count_ptr<ShaderParameter>(res);
            }

            protected int _Begin()
            {
                ID3DXEffect effect = GetEffect();
                if (effect == null)
                {
                    return 0;
                }
                _SetupParameter();

                uint res = S_OK;
                int hr = effect.Begin(res, 0);
                return (int)res;
            }

            protected void _End()
            {
                ID3DXEffect effect = GetEffect();
                if (effect == null)
                {
                    return;
                }
                effect.End();
            }

            protected void _BeginPass(int pass = 0)
            {
                ID3DXEffect effect = GetEffect();
                if (effect == null)
                {
                    return;
                }
                effect.BeginPass(pass);
            /*
            	IDirect3DDevice9* device = DirectGraphics::GetBase()->GetDevice();
            	if(!bLoadShader_)
            	{
            		//http://www.gamedev.net/topic/646178-given-an-effect-technique-pass-handle-how-to-get-the-pixelshader/
            		D3DXHANDLE hTechnique = effect->GetCurrentTechnique();
            		D3DXHANDLE hPass = effect->GetPass(hTechnique, pass);
            
            		D3DXPASS_DESC passDesc;
            		effect->GetPassDesc(hPass, &passDesc);
            		if(passDesc.pVertexShaderFunction != NULL)
            			device->CreateVertexShader(passDesc.pVertexShaderFunction, &pVertexShader_);
            		if(passDesc.pPixelShaderFunction != NULL)
            			device->CreatePixelShader(passDesc.pPixelShaderFunction, &pPixelShader_);
            		bLoadShader_ = true;
            	}
            
            //	device->SetVertexShader(pVertexShader_);
            	device->SetPixelShader(pPixelShader_);
            */
            }

            protected void _EndPass()
            {
                ID3DXEffect effect = GetEffect();
                if (effect == null)
                {
                    return;
                }
                effect.EndPass();

            /*
            	IDirect3DDevice9* device = DirectGraphics::GetBase()->GetDevice();
            //	device->SetVertexShader(NULL);
            	device->SetPixelShader(NULL);
            */
            }

            protected bool _SetupParameter()
            {
                ID3DXEffect effect = GetEffect();
                if (effect == null)
                {
                    return false;
                }
                int hr = effect.SetTechnique(technique_);
                if (FAILED(hr))
                {
                    return false;
                }

                SortedDictionary<string, gstd.ref_count_ptr<ShaderParameter>>.Enumerator itrParam;
                for (itrParam = mapParam_.GetEnumerator(); itrParam.MoveNext();)
                {
                    string name = itrParam.Current.Key;
                    gstd.ref_count_ptr<ShaderParameter> param = itrParam.Current.Value;
                    int type = param.GetType();
                    switch (type)
                    {
                        case ShaderParameter.TYPE_MATRIX:
                        {
                            D3DXMATRIX matrix = param.GetMatrix();
                            hr = effect.SetMatrix(name, matrix);
                            break;
                        }
                        case ShaderParameter.TYPE_MATRIX_ARRAY:
                        {
                            List<D3DXMATRIX> matrixArray = param.GetMatrixArray();
                            hr = effect.SetMatrixArray(name, matrixArray[0], matrixArray.Count);
                            break;
                        }
                        case ShaderParameter.TYPE_VECTOR:
                        {
                            D3DXVECTOR4 vect = param.GetVector();
                            hr = effect.SetVector(name, vect);
                            break;
                        }
                        case ShaderParameter.TYPE_FLOAT:
                        {
                            float value = param.GetFloat();
                            hr = effect.SetFloat(name, value);
                            break;
                        }
                        case ShaderParameter.TYPE_FLOAT_ARRAY:
                        {
                            List<float> value = param.GetFloatArray();
                            hr = effect.SetFloatArray(name, value[0], value.Count);
                            break;
                        }
                        case ShaderParameter.TYPE_TEXTURE:
                        {
                            gstd.ref_count_ptr<Texture> texture = param.GetTexture();
                            IDirect3DTexture9 pTex = texture.GetD3DTexture();
                            hr = effect.SetTexture(name, pTex);
                            break;
                        }
                    }
                    // if(FAILED(hr))return false;
                }
                return true;
            }


            /**********************************************************
            //Shader
            **********************************************************/
            public Shader()
            {
                data_ = null;
                // bLoadShader_ = false;
                // pVertexShader_ = NULL;
                // pPixelShader_ = NULL;
            }

            public Shader(Shader shader)
            {
                {
                    Lock @lock = new Lock(ShaderManager.GetBase().GetLock());
                    data_.CopyFrom(shader.data_);
                }
            }

            public virtual void Dispose()
            {
                Release();
            }

            public void Release()
            {
                // if(pVertexShader_ != NULL)
                // 	pVertexShader_->Release();
                // if(pPixelShader_ != NULL)
                // 	pPixelShader_->Release();
                {
                    Lock @lock = new Lock(ShaderManager.GetBase().GetLock());
                    if (data_ != null)
                    {
                        ShaderManager manager = data_.manager_;
                        if (manager != null && manager.IsDataExists(data_.name_))
                        {
                            int countRef = data_.GetReferenceCount();
                            // ���g��TextureManager��̐������ɂȂ�����폜
                            if (countRef == 2)
                            {
                                manager._ReleaseShaderData(data_.name_);
                            }
                        }
                        data_ = null;
                    }
                }
            }

            public int Begin(int pass = 0)
            {
                ShaderManager manager = ShaderManager.GetBase();
                manager._BeginShader(this, pass);
                return 1;
            }

            public void End()
            {
                ShaderManager manager = ShaderManager.GetBase();
                manager._EndShader(this);
            }

            public ID3DXEffect GetEffect()
            {
                ID3DXEffect res = null;
                if (data_ != null)
                {
                    res = data_.effect_;
                }
                return res;
            }

            public void ReleaseDxResource()
            {
                ID3DXEffect effect = GetEffect();
                if (effect == null)
                {
                    return;
                }
                effect.OnLostDevice();
            }

            public void RestoreDxResource()
            {
                ID3DXEffect effect = GetEffect();
                if (effect == null)
                {
                    return;
                }
                effect.OnResetDevice();
            }

            public bool CreateFromFile(string path)
            {
                path = PathProperty.GetUnique(path);

                bool res = false;
                {
                    Lock @lock = new Lock(ShaderManager.GetBase().GetLock());
                    if (data_ != null)
                    {
                        Release();
                    }
                    ShaderManager manager = ShaderManager.GetBase();
                    ref_count_ptr<Shader> shader = manager.CreateFromFile(path);
                    if (shader != null)
                    {
                        data_ = shader.data_;
                    }
                    res = data_ != null;
                }

                return res;
            }

            public bool CreateFromText(string source)
            {
                bool res = false;
                {
                    Lock @lock = new Lock(ShaderManager.GetBase().GetLock());
                    if (data_ != null)
                    {
                        Release();
                    }
                    ShaderManager manager = ShaderManager.GetBase();
                    ref_count_ptr<Shader> shader = manager.CreateFromText(source);
                    if (shader != null)
                    {
                        data_ = shader.data_;
                    }
                    res = data_ != null;
                }

                return res;
            }

            public bool IsLoad()
            {
                return data_ != null && data_.bLoad_;
            }

            public bool SetTechnique(string name)
            {
                // ID3DXEffect* effect = GetEffect();
                // if(effect == NULL)return false;
                // effect->SetTechnique(name.c_str());

                technique_ = name;
                return true;
            }

            public bool SetMatrix(string name, D3DXMATRIX matrix)
            {
                // ID3DXEffect* effect = GetEffect();
                // if(effect == NULL)return false;
                // effect->SetMatrix(name.c_str(), &matrix);

                gstd.ref_count_ptr<ShaderParameter> param = _GetParameter(name, true);
                param.SetMatrix(matrix);

                return true;
            }

            public bool SetMatrixArray(string name, List<D3DXMATRIX> matrix)
            {
                // ID3DXEffect* effect = GetEffect();
                // if(effect == NULL)return false;
                // effect->SetMatrixArray(name.c_str(), &matrix[0], matrix.size());

                gstd.ref_count_ptr<ShaderParameter> param = _GetParameter(name, true);
                param.SetMatrixArray(matrix);

                return true;
            }

            public bool SetVector(string name, D3DXVECTOR4 vector)
            {
                // ID3DXEffect* effect = GetEffect();
                // if(effect == NULL)return false;
                // effect->SetVector(name.c_str(), &vector);

                gstd.ref_count_ptr<ShaderParameter> param = _GetParameter(name, true);
                param.SetVector(vector);
                return true;
            }

            public bool SetFloat(string name, float value)
            {
                // ID3DXEffect* effect = GetEffect();
                // if(effect == NULL)return false;
                // effect->SetFloat(name.c_str(), value);

                gstd.ref_count_ptr<ShaderParameter> param = _GetParameter(name, true);
                param.SetFloat(value);
                return true;
            }

            public bool SetFloatArray(string name, List<float> values)
            {
                gstd.ref_count_ptr<ShaderParameter> param = _GetParameter(name, true);
                param.SetFloatArray(values);
                return true;
            }

            public bool SetTexture(string name, gstd.ref_count_ptr<Texture> texture)
            {
                gstd.ref_count_ptr<ShaderParameter> param = _GetParameter(name, true);
                param.SetTexture(texture);
                return true;
            }


    }
}