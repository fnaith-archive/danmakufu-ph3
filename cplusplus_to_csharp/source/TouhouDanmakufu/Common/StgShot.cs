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

// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgShotDataList;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgShotData;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgShotRenderer;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgShotObject;
/**********************************************************
//StgShotManager
**********************************************************/
public class StgShotManager : System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            DEL_TYPE_ALL,
            DEL_TYPE_SHOT,
            DEL_TYPE_CHILD,
            TO_TYPE_IMMEDIATE,
            TO_TYPE_FADE,
            TO_TYPE_ITEM
        }

// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum2
        {
            BIT_EV_DELETE_IMMEDIATE = 1,
            BIT_EV_DELETE_TO_ITEM,
            BIT_EV_DELETE_FADE,
            BIT_EV_DELETE_COUNT
        }

        protected StgStageController stageController_;
        protected ref_count_ptr<StgShotDataList>.unsync listPlayerShotData_ = new ref_count_ptr<StgShotDataList>.unsync();
        protected ref_count_ptr<StgShotDataList>.unsync listEnemyShotData_ = new ref_count_ptr<StgShotDataList>.unsync();
        protected LinkedList<ref_count_ptr<StgShotObject>.unsync > listObj_ = new LinkedList<ref_count_ptr<StgShotObject>.unsync >();

        protected std::bitset<AnonymousEnum2.BIT_EV_DELETE_COUNT> listDeleteEventEnable_ = new std::bitset<AnonymousEnum2.BIT_EV_DELETE_COUNT>();


        /**********************************************************
        //StgShotManager
        **********************************************************/
        public StgShotManager(StgStageController stageController)
        {
            stageController_ = stageController;

            listPlayerShotData_ = new StgShotDataList();
            listEnemyShotData_ = new StgShotDataList();
        }

        public virtual void Dispose()
        {
            LinkedList<ref_count_ptr<StgShotObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgShotObject>.unsync obj = itr.Current;
                if (obj != null)
                {
                    obj.ClearShotObject();
                }
            }
        }

        public void Work()
        {
            LinkedList<ref_count_ptr<StgShotObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgShotObject>.unsync obj = itr.Current;
                if (obj.IsDeleted())
                {
                    obj.ClearShotObject();
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                    itr = listObj_.erase(itr);
                }
                else if (!obj.IsActive())
                {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                    itr = listObj_.erase(itr);
                }
                else
                {
                }
            }

        }

        public void Render(int targetPriority)
        {
            DirectGraphics graphics = DirectGraphics.GetBase();
            graphics.SetZBufferEnable(false);
            graphics.SetZWriteEnalbe(false);
            graphics.SetCullingMode(D3DCULL_NONE);
            graphics.SetLightingEnable(false);
            // graphics->SetTextureFilter(DirectGraphics::MODE_TEXTURE_FILTER_POINT);
            // 			MODE_TEXTURE_FILTER_POINT,//��ԂȂ�
            // 			MODE_TEXTURE_FILTER_LINEAR,//���`���
            // �t�H�O��������
            uint bEnableFog = false;
            graphics.GetDevice().GetRenderState(D3DRS_FOGENABLE, bEnableFog);
            if (bEnableFog != 0)
            {
                graphics.SetFogEnable(false);
            }

            DxCamera2D camera = graphics.GetCamera2D().GetPointer();
            D3DXMATRIX matCamera = camera.GetMatrix();

            LinkedList<ref_count_ptr<StgShotObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgShotObject>.unsync obj = itr.Current;
                if (obj.IsDeleted())
                {
                    continue;
                }
                if (!obj.IsActive())
                {
                    continue;
                }
                if (obj.GetRenderPriorityI() != targetPriority)
                {
                    continue;
                }
                obj.RenderOnShotManager(matCamera);
            }

            // �`��
            int countBlendType = (int)StgShotDataList.AnonymousEnum3.RENDER_TYPE_COUNT;
            int[] blendMode = { DirectGraphics.MODE_BLEND_ADD_ARGB, DirectGraphics.MODE_BLEND_ADD_RGB, DirectGraphics.MODE_BLEND_MULTIPLY, DirectGraphics.MODE_BLEND_SUBTRACT, DirectGraphics.MODE_BLEND_INV_DESTRGB, DirectGraphics.MODE_BLEND_ALPHA };
            int[] typeRender = { StgShotDataList.AnonymousEnum3.RENDER_ADD_ARGB, StgShotDataList.AnonymousEnum3.RENDER_ADD_RGB, StgShotDataList.AnonymousEnum3.RENDER_MULTIPLY, StgShotDataList.AnonymousEnum3.RENDER_SUBTRACT, StgShotDataList.AnonymousEnum3.RENDER_INV_DESTRGB, StgShotDataList.AnonymousEnum3.RENDER_ALPHA };
            for (int iBlend = 0 ; iBlend < countBlendType ; iBlend++)
            {
                graphics.SetBlendMode(blendMode[iBlend]);
                List<ref_count_ptr<StgShotRenderer>.unsync > listPlayer = listPlayerShotData_.GetRendererList(typeRender[iBlend]);
                int iRender = 0;
                for (iRender = 0 ; iRender < listPlayer.Count ; iRender++)
                {
                    (listPlayer[iRender]).Render();
                }

                List<ref_count_ptr<StgShotRenderer>.unsync > listEnemy = listEnemyShotData_.GetRendererList(typeRender[iBlend]);
                for (iRender = 0 ; iRender < listEnemy.Count ; iRender++)
                {
                    (listEnemy[iRender]).Render();
                }
            }

            if (bEnableFog != 0)
            {
                graphics.SetFogEnable(true);
            }
        }

        public void RegistIntersectionTarget()
        {
            LinkedList<ref_count_ptr<StgShotObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgShotObject>.unsync obj = itr.Current;
                if (!obj.IsDeleted() && obj.IsActive())
                {
                    obj.ClearIntersectedIdList();
                    obj.RegistIntersectionTarget();
                }
            }
        }

        public void AddShot(ref_count_ptr<StgShotObject>.unsync obj)
        {
            listObj_.AddLast(obj);
        }

        public StgShotDataList GetPlayerShotDataList()
        {
            return listPlayerShotData_.GetPointer();
        }
        public StgShotDataList GetEnemyShotDataList()
        {
            return listEnemyShotData_.GetPointer();
        }

        public bool LoadPlayerShotData(string path, bool bReload = false)
        {
            return listPlayerShotData_.AddShotDataList(path, bReload);
        }

        public bool LoadEnemyShotData(string path, bool bReload = false)
        {
            return listEnemyShotData_.AddShotDataList(path, bReload);
        }

        public RECT GetShotAutoDeleteClipRect()
        {
            ref_count_ptr<StgStageInformation> stageInfo = stageController_.GetStageInformation();
            RECT rcStgFrame = stageInfo.GetStgFrameRect();
            RECT rcClip = stageInfo.GetShotAutoDeleteClip();

            int width = rcStgFrame.right - rcStgFrame.left;
            int height = rcStgFrame.bottom - rcStgFrame.top;
            rcClip.right += width;
            rcClip.bottom += height;
            return new RECT(rcClip);
        }

        public void DeleteInCircle(int typeDelete, int typeTo, int typeOnwer, int cx, int cy, double radius)
        {
            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();

            LinkedList<ref_count_ptr<StgShotObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgShotObject>.unsync obj = itr.Current;
                if (obj.IsDeleted())
                {
                    continue;
                }

                if (typeOnwer != (int)StgShotObject.AnonymousEnum4.OWNER_NULL && obj.GetOwnerType() != typeOnwer)
                {
                    continue;
                }

                if (typeDelete == (int)AnonymousEnum.DEL_TYPE_SHOT && obj.GetLife() == StgShotObject.AnonymousEnum4.LIFE_SPELL_REGIST)
                {
                    continue;
                }

                double sx = obj.GetPositionX();
                double sy = obj.GetPositionY();

                double tr = System.Math.Pow(System.Math.Pow(cx - sx, 2) + System.Math.Pow(cy - sy, 2), 0.5);
                if (tr <= radius)
                {
                    if (typeTo == (int)AnonymousEnum.TO_TYPE_IMMEDIATE)
                    {
                        obj.DeleteImmediate();
                    }
                    else if (typeTo == (int)AnonymousEnum.TO_TYPE_FADE)
                    {
                        obj.SetFadeDelete();
                    }
                    else if (typeTo == (int)AnonymousEnum.TO_TYPE_ITEM)
                    {
                        obj.ConvertToItem();
                    }
                }

            }
        }

        public List<int> GetShotIdInCircle(int typeOnwer, int cx, int cy, int radius)
        {
            List<int> res = new List<int>();
            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();

            LinkedList<ref_count_ptr<StgShotObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgShotObject>.unsync obj = itr.Current;
                if (obj.IsDeleted())
                {
                    continue;
                }

                if (typeOnwer != (int)StgShotObject.AnonymousEnum4.OWNER_NULL && obj.GetOwnerType() != typeOnwer)
                {
                    continue;
                }

                double sx = obj.GetPositionX();
                double sy = obj.GetPositionY();

                double tr = System.Math.Pow(System.Math.Pow(cx - sx, 2) + System.Math.Pow(cy - sy, 2), 0.5);
                if (tr <= radius)
                {
                    int id = obj.GetObjectID();
                    res.Add(id);
                }

            }
            return new List<int>(res);
        }

        public int GetShotCount(int typeOnwer)
        {
            int res = 0;
            LinkedList<ref_count_ptr<StgShotObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgShotObject>.unsync obj = itr.Current;
                if (obj.IsDeleted())
                {
                    continue;
                }

                if (typeOnwer != (int)StgShotObject.AnonymousEnum4.OWNER_NULL && obj.GetOwnerType() != typeOnwer)
                {
                    continue;
                }

                res++;
            }
            return res;
        }

        public int GetShotCountAll()
        {
            return listObj_.Count;
        }
        public List<bool> GetValidRenderPriorityList()
        {
            List<bool> res = new List<bool>();
            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            res.Resize(objectManager.GetRenderBucketCapacity());

            LinkedList<ref_count_ptr<StgShotObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgShotObject>.unsync obj = itr.Current;
                if (obj.IsDeleted())
                {
                    continue;
                }

                int pri = obj.GetRenderPriorityI();
                res[pri] = true;
            }

            return new List<bool>(res);
        }

        public void SetDeleteEventEnableByType(int type, bool bEnable)
        {
            int bit = 0;
            switch (type)
            {
            case StgStageShotScript.EV_DELETE_SHOT_IMMEDIATE:
                bit = (int)StgShotManager.AnonymousEnum2.BIT_EV_DELETE_IMMEDIATE;
                break;
            case StgStageShotScript.EV_DELETE_SHOT_TO_ITEM:
                bit = (int)StgShotManager.AnonymousEnum2.BIT_EV_DELETE_TO_ITEM;
                break;
            case StgStageShotScript.EV_DELETE_SHOT_FADE:
                bit = (int)StgShotManager.AnonymousEnum2.BIT_EV_DELETE_FADE;
                break;
            }

            if (bEnable)
            {
                listDeleteEventEnable_.set(bit);
            }
            else
            {
                listDeleteEventEnable_.reset(bit);
            }
        }

        public bool IsDeleteEventEnable(int bit)
        {
            bool res = listDeleteEventEnable_[bit];
            return res;
        }
}

/**********************************************************
//StgShotDataList
**********************************************************/
public class StgShotDataList : System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum3
        {
            RENDER_TYPE_COUNT = 6,
            RENDER_ALPHA = 0,
            RENDER_ADD_RGB,
            RENDER_ADD_ARGB,
            RENDER_MULTIPLY,
            RENDER_SUBTRACT,
            RENDER_INV_DESTRGB
        }
        private SortedSet<string> listReadPath_ = new SortedSet<string>();
        private List<ref_count_ptr<Texture>> listTexture_ = new List<ref_count_ptr<Texture>>();
        private List<List<ref_count_ptr<StgShotRenderer>.unsync >> listRenderer_ = new List<List<ref_count_ptr<StgShotRenderer>.unsync >>();
        private List<ref_count_ptr<StgShotData>.unsync > listData_ = new List<ref_count_ptr<StgShotData>.unsync >();

        private D3DCOLOR defaultDelayColor_ = new D3DCOLOR();

        private void _ScanShot(List<ref_count_ptr<StgShotData>.unsync > listData, Scanner scanner)
        {
            Token tok = scanner.Next();
            if (tok.GetType() == Token.TK_NEWLINE)
            {
                tok = scanner.Next();
            }
            scanner.CheckType(tok, Token.TK_OPENC);

            ref_count_ptr<StgShotData>.unsync data = new StgShotData(this);
            data.colorDelay_ = defaultDelayColor_;
            int id = -1;

            while (true)
            {
                tok = scanner.Next();
                if (tok.GetType() == Token.TK_CLOSEC)
                {
                    break;
                }
                else if (tok.GetType() == Token.TK_ID)
                {
                    string element = tok.GetElement();

                    if (element == "id")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        id = scanner.Next().GetInteger();
                    }
                    else if (element == "rect")
                    {
                        List<string> list = _GetArgumentList(scanner);
                        RECT rect = new RECT();
                        rect.left = StringUtility.ToInteger(list[0]);
                        rect.top = StringUtility.ToInteger(list[1]);
                        rect.right = StringUtility.ToInteger(list[2]);
                        rect.bottom = StringUtility.ToInteger(list[3]);
                        data.rcSrc_ = rect;
                    }
                    else if (element == "delay_color")
                    {
                        List<string> list = _GetArgumentList(scanner);
                        data.colorDelay_ = D3DCOLOR_ARGB(255, StringUtility.ToInteger(list[0]), StringUtility.ToInteger(list[1]), StringUtility.ToInteger(list[2]));
                    }
                    else if (element == "delay_rect")
                    {
                        List<string> list = _GetArgumentList(scanner);
                        RECT rect = new RECT();
                        rect.left = StringUtility.ToInteger(list[0]);
                        rect.top = StringUtility.ToInteger(list[1]);
                        rect.right = StringUtility.ToInteger(list[2]);
                        rect.bottom = StringUtility.ToInteger(list[3]);
                        data.rcDelay_ = rect;
                    }
                    else if (element == "collision")
                    {
                        DxCircle circle = new DxCircle();
                        List<string> list = _GetArgumentList(scanner);
                        if (list.Count == 1)
                        {
                            circle.SetR(StringUtility.ToInteger(list[0]));
                        }
                        else if (list.Count == 3)
                        {
                            circle.SetR(StringUtility.ToInteger(list[0]));
                            circle.SetX(StringUtility.ToInteger(list[1]));
                            circle.SetY(StringUtility.ToInteger(list[2]));
                        }

                        data.listCol_.push_back(circle);
                    }
                    else if (element == "render" || element == "delay_render")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        string strRender = scanner.Next().GetElement();
                        int typeRender = DirectGraphics.MODE_BLEND_ALPHA;

                        if (strRender == "ADD" || strRender == "ADD_RGB")
                        {
                            typeRender = DirectGraphics.MODE_BLEND_ADD_RGB;
                        }
                        else if (strRender == "ADD_ARGB")
                        {
                            typeRender = DirectGraphics.MODE_BLEND_ADD_ARGB;
                        }
                        else if (strRender == "MULTIPLY")
                        {
                            typeRender = DirectGraphics.MODE_BLEND_MULTIPLY;
                        }
                        else if (strRender == "SUBTRACT")
                        {
                            typeRender = DirectGraphics.MODE_BLEND_SUBTRACT;
                        }
                        else if (strRender == "INV_DESTRGB")
                        {
                            typeRender = DirectGraphics.MODE_BLEND_INV_DESTRGB;
                        }

                        if (element == "render")
                        {
                            data.typeRender_ = typeRender;
                        }
                        else if (element == "delay_render")
                        {
                            data.typeDelayRender_ = typeRender;
                        }
                    }
                    else if (element == "alpha")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        data.alpha_ = scanner.Next().GetInteger();
                    }
                    else if (element == "angular_velocity")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        tok = scanner.Next();
                        if (tok.GetElement() == "rand")
                        {
                            scanner.CheckType(scanner.Next(), Token.TK_OPENP);
                            data.angularVelocityMin_ = scanner.Next().GetReal();
                            scanner.CheckType(scanner.Next(), Token.TK_COMMA);
                            data.angularVelocityMax_ = scanner.Next().GetReal();
                            scanner.CheckType(scanner.Next(), Token.TK_CLOSEP);
                        }
                        else
                        {
                            data.angularVelocityMin_ = tok.GetReal();
                            data.angularVelocityMax_ = data.angularVelocityMin_;
                        }
                    }
                    else if (element == "fixed_angle")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        tok = scanner.Next();
                        data.bFixedAngle_ = tok.GetElement() == "true";
                    }
                    else if (element == "AnimationData")
                    {
                        _ScanAnimation(new ref_count_ptr<StgShotData>.unsync(data), scanner);
                    }
                }
            }

            if (id >= 0)
            {
                if (data.listCol_.size() == 0)
                {
                    RECT rect = data.rcSrc_;
                    int rx = System.Math.Abs(rect.right - rect.left);
                    int ry = System.Math.Abs(rect.bottom - rect.top);
                    int r = System.Math.Min(rx, ry);
                    r = r / 3 - 3;
                    if (r <= 3)
                    {
                        r = 3;
                    }
                    DxCircle circle = new DxCircle(0, 0, r);
                    data.listCol_.push_back(circle);
                }
                if (listData.Count <= id)
                {
                    listData.Resize(id + 1);
                }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: listData[id] = data;
                listData[id].CopyFrom(data);
            }
        }

        private void _ScanAnimation(ref_count_ptr<StgShotData>.unsync shotData, Scanner scanner)
        {
            Token tok = scanner.Next();
            if (tok.GetType() == Token.TK_NEWLINE)
            {
                tok = scanner.Next();
            }
            scanner.CheckType(tok, Token.TK_OPENC);

            while (true)
            {
                tok = scanner.Next();
                if (tok.GetType() == Token.TK_CLOSEC)
                {
                    break;
                }
                else if (tok.GetType() == Token.TK_ID)
                {
                    string element = tok.GetElement();

                    if (element == "animation_data")
                    {
                        List<string> list = _GetArgumentList(scanner);
                        if (list.Count == 5)
                        {
                            StgShotData.AnimationData anime = new StgShotData.AnimationData();
                            int frame = StringUtility.ToInteger(list[0]);
                            RECT rcSrc = new RECT(StringUtility.ToInteger(list[1]), StringUtility.ToInteger(list[2]), StringUtility.ToInteger(list[3]), StringUtility.ToInteger(list[4]));

                            anime.frame_ = frame;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: anime.rcSrc_ = rcSrc;
                            anime.rcSrc_.CopyFrom(rcSrc);

                            shotData.listAnime_.push_back(anime);
                            shotData.totalAnimeFrame_ += frame;
                        }
                    }
                }
            }
        }

        private List<string> _GetArgumentList(Scanner scanner)
        {
            List<string> res = new List<string>();
            scanner.CheckType(scanner.Next(), Token.TK_EQUAL);

            Token tok = scanner.Next();

            if (tok.GetType() == Token.TK_OPENP)
            {
                while (true)
                {
                    tok = scanner.Next();
                    int type = tok.GetType();
                    if (type == Token.TK_CLOSEP)
                    {
                        break;
                    }
                    else if (type != Token.TK_COMMA)
                    {
                        string str = tok.GetElement();
                        res.Add(str);
                    }
                }
            }
            else
            {
                res.Add(tok.GetElement());
            }
            return new List<string>(res);
        }


        /**********************************************************
        //StgShotDataList
        **********************************************************/
        public StgShotDataList()
        {
            listRenderer_.Resize(AnonymousEnum3.RENDER_TYPE_COUNT);
            defaultDelayColor_ = D3DCOLOR_ARGB(255, 128, 128, 128);
        }

        public virtual void Dispose()
        {
        }

        public int GetTextureCount()
        {
            return listTexture_.Count;
        }
        public ref_count_ptr<Texture> GetTexture(int index)
        {
            return new ref_count_ptr<Texture>(listTexture_[index]);
        }
        public ref_count_ptr<StgShotRenderer>.unsync GetRenderer(int index, int typeRender)
        {
            return new ref_count_ptr<StgShotRenderer>.unsync(listRenderer_[typeRender][index]);
        }
        public List<ref_count_ptr<StgShotRenderer>.unsync > GetRendererList(int typeRender)
        {
            return new List<ref_count_ptr<StgShotRenderer>.unsync >(listRenderer_[typeRender]);
        }

        public ref_count_ptr<StgShotData>.unsync GetData(int id)
        {
            return (id >= 0 && id < listData_.Count) ? listData_[id] : null;
        }

        public bool AddShotDataList(string path, bool bReload)
        {
            if (!bReload && listReadPath_.find(path) != listReadPath_.end())
            {
                return true;
            }

            ref_count_ptr<FileReader> reader = FileManager.GetBase().GetFileReader(path);
            if (reader == null)
            {
                throw new gstd.wexception(ErrorUtility.GetFileNotFoundErrorMessage(path).c_str());
            }
            if (!reader.Open())
            {
                throw new gstd.wexception(ErrorUtility.GetFileNotFoundErrorMessage(path).c_str());
            }
            string source = reader.ReadAllString();

            bool res = false;
            Scanner scanner = new Scanner(source);
            try
            {
                List<ref_count_ptr<StgShotData>.unsync > listData = new List<ref_count_ptr<StgShotData>.unsync >();
                string pathImage = "";
                RECT rcDelay = new RECT(-1, -1, -1, -1);
                while (scanner.HasNext())
                {
                    Token tok = scanner.Next();
                    if (tok.GetType() == Token.TK_EOF) // Eof�̎��ʎq��������t�@�C���̒����I��
                    {
                        break;
                    }
                    else if (tok.GetType() == Token.TK_ID)
                    {
                        string element = tok.GetElement();
                        if (element == "ShotData")
                        {
                            _ScanShot(listData, scanner);
                        }
                        else if (element == "shot_image")
                        {
                            scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                            pathImage = scanner.Next().GetString();
                        }
                        else if (element == "delay_color")
                        {
                            List<string> list = _GetArgumentList(scanner);
                            defaultDelayColor_ = D3DCOLOR_ARGB(255, StringUtility.ToInteger(list[0]), StringUtility.ToInteger(list[1]), StringUtility.ToInteger(list[2]));
                        }
                        else if (element == "delay_rect")
                        {
                            List<string> list = _GetArgumentList(scanner);
                            RECT rect = new RECT();
                            rect.left = StringUtility.ToInteger(list[0]);
                            rect.top = StringUtility.ToInteger(list[1]);
                            rect.right = StringUtility.ToInteger(list[2]);
                            rect.bottom = StringUtility.ToInteger(list[3]);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcDelay = rect;
                            rcDelay.CopyFrom(rect);
                        }
                        if (scanner.HasNext())
                        {
                            tok = scanner.Next();
                        }

                    }
                }

                // �e�N�X�`���ǂݍ���
                if (pathImage.Length == 0)
                {
                    throw new gstd.wexception("�摜�t�@�C�����ݒ肳��Ă��܂���B");
                }
                string dir = PathProperty.GetFileDirectory(path);
                pathImage = StringUtility.Replace(pathImage, "./", dir);

                ref_count_ptr<Texture> texture = new Texture();
                bool bTexture = texture.CreateFromFile(pathImage);
                if (!bTexture)
                {
                    throw new gstd.wexception("�摜�t�@�C����������܂���ł����B");
                }

                int textureIndex = -1;
                for (int iTexture = 0 ;iTexture < listTexture_.Count ; iTexture++)
                {
                    ref_count_ptr<Texture> tSearch = listTexture_[iTexture];
                    if (tSearch.GetName() == texture.GetName())
                    {
                        textureIndex = iTexture;
                        break;
                    }
                }
                if (textureIndex < 0)
                {
                    textureIndex = listTexture_.Count;
                    listTexture_.Add(texture);
                    for (int iRender = 0 ; iRender < listRenderer_.Count; iRender++)
                    {
                        ref_count_ptr<StgShotRenderer>.unsync render = new StgShotRenderer();
                        render.SetTexture(texture);
                        listRenderer_[iRender].Add(render);
                    }
                }

                if (listData_.Count < listData.Count)
                {
                    listData_.Resize(listData.Count);
                }
                for (int iData = 0 ; iData < listData.Count ; iData++)
                {
                    ref_count_ptr<StgShotData>.unsync data = listData[iData];
                    if (data == null)
                    {
                        continue;
                    }
                    data.indexTexture_ = textureIndex;
                    if (data.rcDelay_.left < 0)
                    {
                        data.rcDelay_ = rcDelay;
                    }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: listData_[iData] = data;
                    listData_[iData].CopyFrom(data);
                }

                listReadPath_.Add(path);
                Logger.WriteTop(StringUtility.Format("�e�f�[�^��ǂݍ��݂܂���:%s", path));
                res = true;
            }
            catch (gstd.wexception e)
            {
                string log = StringUtility.Format("�e�f�[�^�ǂݍ��ݎ��s:%d�s��(%s)", scanner.GetCurrentLine(), e.what());
                Logger.WriteTop(log);
                res = null;
            }
            catch
            {
                string log = StringUtility.Format("�e�f�[�^�ǂݍ��ݎ��s:%d�s��", scanner.GetCurrentLine());
                Logger.WriteTop(log);
                res = null;
            }

            return res;
        }
}

public class StgShotData : System.IDisposable
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//    friend StgShotDataList;
        private class AnimationData
        {
            public RECT rcSrc_ = new RECT();
            public int frame_;
        }

        private StgShotDataList listShotData_;
        private int indexTexture_;
        private int typeRender_;
        private int typeDelayRender_;
        private RECT rcSrc_ = new RECT();
        private RECT rcDelay_ = new RECT();
        private int alpha_;
        private D3DCOLOR colorDelay_ = new D3DCOLOR();
        private List<DxCircle> listCol_ = new List<DxCircle>();

        private List<AnimationData> listAnime_ = new List<AnimationData>();
        private int totalAnimeFrame_;

        private double angularVelocityMin_;
        private double angularVelocityMax_;
        private bool bFixedAngle_;


        // StgShotData
        public StgShotData(StgShotDataList listShotData)
        {
            listShotData_ = listShotData;
            typeRender_ = DirectGraphics.MODE_BLEND_ALPHA;
            typeDelayRender_ = DirectGraphics.MODE_BLEND_ADD_ARGB;
            colorDelay_ = D3DCOLOR_ARGB(255, 255, 255, 255);
            SetRect(rcSrc_, 0, 0, 0, 0);
            SetRect(rcDelay_, -1, -1, -1, -1);
            alpha_ = 255;
            totalAnimeFrame_ = 0;
            angularVelocityMin_ = 0;
            angularVelocityMax_ = 0;
            bFixedAngle_ = false;
        }

        public virtual void Dispose()
        {
        }

        public int GetTextureIndex()
        {
            return indexTexture_;
        }
        public int GetRenderType()
        {
            return typeRender_;
        }
        public int GetDelayRenderType()
        {
            return typeDelayRender_;
        }
        public RECT GetRect(int frame)
        {
            if (totalAnimeFrame_ == 0)
            {
                return new RECT(rcSrc_);
            }

            RECT res = new RECT();
            frame = frame % totalAnimeFrame_;
            int total = 0;
            List<AnimationData>.Enumerator itr = listAnime_.GetEnumerator();
            while (itr.MoveNext())
            {
                // AnimationData* anime = itr;
                total += itr.frame_;
                if (total >= frame)
                {
                    res = itr.rcSrc_;
                    break;
                }
            }

            return new RECT(res);
        }

        public RECT GetDelayRect()
        {
            return new RECT(rcDelay_);
        }
        public int GetAlpha()
        {
            return alpha_;
        }
        public D3DCOLOR GetDelayColor()
        {
            return new D3DCOLOR(colorDelay_);
        }
        public List<DxCircle> GetIntersectionCircleList()
        {
            return new List<DxCircle>(listCol_);
        }
        public double GetAngularVelocityMin()
        {
            return angularVelocityMin_;
        }
        public double GetAngularVelocityMax()
        {
            return angularVelocityMax_;
        }
        public bool IsFixedAngle()
        {
            return bFixedAngle_;
        }

        public ref_count_ptr<Texture> GetTexture()
        {
            ref_count_ptr<Texture> res = listShotData_.GetTexture(indexTexture_);
            return new ref_count_ptr<Texture>(res);
        }

        public StgShotRenderer GetRenderer()
        {
            StgShotRenderer res = GetRendererFromGraphicsBlendType(typeRender_);
            return res;
        }

        public StgShotRenderer GetRenderer(int type)
        {
            return listShotData_.GetRenderer(indexTexture_, type).GetPointer();
        }

        public StgShotRenderer GetRendererFromGraphicsBlendType(int blendType)
        {
            StgShotRenderer res = null;
            if (blendType == DirectGraphics.MODE_BLEND_ALPHA)
            {
                res = listShotData_.GetRenderer(indexTexture_, (int)StgShotDataList.AnonymousEnum3.RENDER_ALPHA).GetPointer();
            }
            else if (blendType == DirectGraphics.MODE_BLEND_ADD_RGB)
            {
                res = listShotData_.GetRenderer(indexTexture_, (int)StgShotDataList.AnonymousEnum3.RENDER_ADD_RGB).GetPointer();
            }
            else if (blendType == DirectGraphics.MODE_BLEND_ADD_ARGB)
            {
                res = listShotData_.GetRenderer(indexTexture_, (int)StgShotDataList.AnonymousEnum3.RENDER_ADD_ARGB).GetPointer();
            }
            else if (blendType == DirectGraphics.MODE_BLEND_MULTIPLY)
            {
                res = listShotData_.GetRenderer(indexTexture_, (int)StgShotDataList.AnonymousEnum3.RENDER_MULTIPLY).GetPointer();
            }
            else if (blendType == DirectGraphics.MODE_BLEND_SUBTRACT)
            {
                res = listShotData_.GetRenderer(indexTexture_, (int)StgShotDataList.AnonymousEnum3.RENDER_SUBTRACT).GetPointer();
            }
            else if (blendType == DirectGraphics.MODE_BLEND_INV_DESTRGB)
            {
                res = listShotData_.GetRenderer(indexTexture_, (int)StgShotDataList.AnonymousEnum3.RENDER_INV_DESTRGB).GetPointer();
            }
            return res;
        }

        public static bool IsAlphaBlendValidType(int blendType)
        {
            bool bValidAlpha = false;
            if (blendType == DirectGraphics.MODE_BLEND_ALPHA || blendType == DirectGraphics.MODE_BLEND_ADD_ARGB || blendType == DirectGraphics.MODE_BLEND_SUBTRACT)
            {
                bValidAlpha = true;
            }
            return bValidAlpha;
        }
}

/**********************************************************
//StgShotRenderer
**********************************************************/
public class StgShotRenderer : RenderObjectTLX
{
        private int countRenderVertex_;

        /**********************************************************
        //StgShotRenderer
        **********************************************************/
        public StgShotRenderer()
        {
            countRenderVertex_ = 0;
            SetVertexCount(256 * 256);

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

            device.DrawPrimitiveUP(typePrimitive_, _GetPrimitiveCount(), vertex_.GetPointer(), strideVertexStreamZero_);

            // �`��Ώۂ�N���A����
            countRenderVertex_ = 0;
        }

        public void AddVertex(VERTEX_TLX vertex)
        {
            SetVertex(countRenderVertex_, vertex);
            countRenderVertex_++;
        }

        public void AddSquareVertex(VERTEX_TLX[] listVertex)
        {
            AddVertex(listVertex[0]);
            AddVertex(listVertex[2]);
            AddVertex(listVertex[1]);
            AddVertex(listVertex[1]);
            AddVertex(listVertex[2]);
            AddVertex(listVertex[3]);
        }
}

/**********************************************************
//StgShotObject
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public abstract class StgShotObject : DxScriptRenderObject, StgMoveObject, StgIntersectionObject
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum4
        {
            OWNER_PLAYER = 0,
            OWNER_ENEMY,
            OWNER_NULL,

            FRAME_FADEDELETE = 30,
            FRAME_FADEDELETE_LASER = 30,

            LIFE_SPELL_UNREGIST = 5,
            LIFE_SPELL_REGIST = 256 * 256 * 256
        }
        public class ReserveShotList
        {
                public class ListElement
                {
                        private LinkedList<ReserveShotListData> list_ = new LinkedList<ReserveShotListData>();
                        public ListElement()
                        {
                        }
                        public virtual void Dispose()
                        {
                        }
                        public void Add(ReserveShotListData data)
                        {
                            list_.push_back(data);
                        }
                        public LinkedList<ReserveShotListData> GetDataList()
                        {
                            return list_;
                        }
                }
                private int frame_;
                private SortedDictionary<int, ref_count_ptr<ListElement>.unsync > mapData_ = new SortedDictionary<int, ref_count_ptr<ListElement>.unsync >();
                public ReserveShotList()
                {
                    frame_ = 0;
                }
                public virtual void Dispose()
                {
                }

                // StgShotObject::ReserveShotList
                public ref_count_ptr<StgShotObject.ReserveShotList.ListElement>.unsync GetNextFrameData()
                {
                    ref_count_ptr<ListElement>.unsync res = null;
                    if (mapData_.find(frame_) != mapData_.end())
                    {
                        res = mapData_[frame_];
                        mapData_.erase(frame_);
                    }

                    frame_++;
                    return new ref_count_ptr<ListElement>.unsync(res);
                }

                public void AddData(int frame, int idShot, int radius, int angle)
                {
                    ref_count_ptr<ListElement>.unsync list = new ref_count_ptr<ListElement>.unsync();
                    if (mapData_.find(frame) == mapData_.end())
                    {
                        list = new ListElement();
                        mapData_[frame] = list;
                    }
                    else
                    {
                        list = mapData_[frame];
                    }

                    ReserveShotListData data = new ReserveShotListData();
                    data.idShot_ = idShot;
                    data.radius_ = radius;
                    data.angle_ = angle;
                    list.Add(data);
                }

                public void Clear(StgStageController stageController)
                {
                    ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController.GetMainObjectManager();
                    if (objectManager == null)
                    {
                        return;
                    }

                    SortedDictionary<int, ref_count_ptr<ListElement>.unsync >.Enumerator itrMap = mapData_.begin();
                    while (itrMap.MoveNext())
                    {
                        ref_count_ptr<ListElement>.unsync listElement = itrMap.Current.Value;
                        LinkedList<ReserveShotListData> list = listElement.GetDataList();
                        LinkedList<ReserveShotListData>.Enumerator itr = list.GetEnumerator();
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                        for (; itr != list.end() ; itr++)
                        {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                            StgShotObject.ReserveShotListData data = (itr);
                            int idShot = data.GetShotID();
                            ref_count_ptr<StgShotObject>.unsync objShot = new ref_count_ptr<StgShotObject>.unsync(objectManager.GetObject(idShot));
                            if (objShot != null)
                            {
                                objShot.ClearShotObject();
                            }
                            objectManager.DeleteObject(idShot);
                        }
                    }
                }
        }
        public class ReserveShotListData
        {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend ReserveShotList;
                private int idShot_; // �Ώ�ID
                private double radius_; // �o���ʒu����
                private double angle_; // �o���ʒu�p�x
                public ReserveShotListData()
                {
                    idShot_ = DxScript.ID_INVALID;
                    radius_ = 0;
                    angle_ = 0;
                }
                public virtual void Dispose()
                {
                }
                public int GetShotID()
                {
                    return idShot_;
                }
                public double GetRadius()
                {
                    return radius_;
                }
                public double GetAngle()
                {
                    return angle_;
                }
        }

        protected StgStageController stageController_;

        protected int frameWork_;
        protected int idShotData_;
        protected int typeOwner_;

        protected D3DCOLOR color_ = new D3DCOLOR();
        protected int delay_; // �x������
        protected int typeSourceBrend_; // �x�����ԃu�����h���
        protected int frameGrazeInvalid_; // �����薳���t���[��
        protected int frameFadeDelete_;
        protected double damage_;
        protected double life_; // �ђʗ�
        protected bool bAutoDelete_;
        protected bool bEraseShot_; // �e�폜�@�\
        protected bool bSpellFactor_; // �X�y���t��
        protected int frameAutoDelete_; // �����폜�t���[��
        protected ref_count_ptr<ReserveShotList>.unsync listReserveShot_ = new ref_count_ptr<ReserveShotList>.unsync();

        protected bool bUserIntersectionMode_; // ���[�U��`�����蔻�胂�[�h
        protected bool bIntersectionEnable_;
        protected bool bChangeItemEnable_;

        protected StgShotData _GetShotData()
        {
            StgShotData res = null;
            StgShotManager shotManager = stageController_.GetShotManager();
            StgShotDataList dataList = (typeOwner_ == (int)AnonymousEnum4.OWNER_PLAYER) ? shotManager.GetPlayerShotDataList() : shotManager.GetEnemyShotDataList();

            if (dataList != null)
            {
                res = dataList.GetData(idShotData_).GetPointer();
            }

            return res;
        }

        protected void _SetVertexPosition(VERTEX_TLX vertex, float x, float y, float z = 1.0f, float w = 1.0f)
        {
            float bias = -0.5f;
            vertex.position.x = x + bias;
            vertex.position.y = y + bias;
            vertex.position.z = z;
            vertex.position.w = w;
        }

        protected void _SetVertexUV(VERTEX_TLX vertex, float u, float v)
        {
            StgShotData shotData = _GetShotData();
            if (shotData == null)
            {
                return;
            }

            ref_count_ptr<Texture> texture = shotData.GetTexture();
            int width = texture.GetWidth();
            int height = texture.GetHeight();
            vertex.texcoord.x = u / width;
            vertex.texcoord.y = v / height;
        }

        protected void _SetVertexColorARGB(VERTEX_TLX vertex, D3DCOLOR color)
        {
            vertex.diffuse_color = color;
        }

        protected virtual void _DeleteInLife()
        {
            if (IsDeleted())
            {
                return;
            }
            if (life_ <= 0)
            {
                _SendDeleteEvent((int)StgShotManager.AnonymousEnum2.BIT_EV_DELETE_IMMEDIATE);
                ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
                objectManager.DeleteObject(idObject_);
            }
        }

        protected virtual void _DeleteInAutoClip()
        {
            if (IsDeleted())
            {
                return;
            }
            if (!IsAutoDelete())
            {
                return;
            }
            StgShotManager shotManager = stageController_.GetShotManager();
            RECT rect = shotManager.GetShotAutoDeleteClipRect();
            if (posX_ < rect.left || posX_ > rect.right || posY_ < rect.top || posY_ > rect.bottom)
            {
                ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
                objectManager.DeleteObject(idObject_);
            }
        }

        protected virtual void _DeleteInFadeDelete()
        {
            if (IsDeleted())
            {
                return;
            }
            if (frameFadeDelete_ == 0)
            {
                _SendDeleteEvent((int)StgShotManager.AnonymousEnum2.BIT_EV_DELETE_FADE);
                ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
                objectManager.DeleteObject(idObject_);
            }
        }

        protected virtual void _DeleteInAutoDeleteFrame()
        {
            if (IsDeleted())
            {
                return;
            }
            if (delay_ > 0)
            {
                return;
            }

            if (frameAutoDelete_ <= 0)
            {
                _SendDeleteEvent((int)StgShotManager.AnonymousEnum2.BIT_EV_DELETE_IMMEDIATE);
                ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
                objectManager.DeleteObject(idObject_);
                return;
            }
            frameAutoDelete_ = System.Math.Max(0, frameAutoDelete_ - 1);
        }

        protected override void _Move()
        {
            if (delay_ == 0)
            {
                base._Move();
            }
            SetX(posX_);
            SetY(posY_);

            // �e�摜�u����������
            if (pattern_ != null)
            {
                int idShot = pattern_.GetShotDataID();
                if (idShot != StgMovePattern.NO_CHANGE)
                {
                    SetShotDataID(idShot);
                }
            }
        }

        protected void _AddReservedShotWork()
        {
            if (IsDeleted())
            {
                return;
            }
            if (listReserveShot_ == null)
            {
                return;
            }
            ref_count_ptr<ReserveShotList.ListElement>.unsync listData = listReserveShot_.GetNextFrameData();
            if (listData == null)
            {
                return;
            }

            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            LinkedList<ReserveShotListData> list = listData.GetDataList();
            LinkedList<ReserveShotListData>.Enumerator itr = list.GetEnumerator();
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
            for (; itr != list.end() ; itr++)
            {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                StgShotObject.ReserveShotListData data = (itr);
                int idShot = data.GetShotID();
                ref_count_ptr<StgShotObject>.unsync obj = new ref_count_ptr<StgShotObject>.unsync(objectManager.GetObject(idShot));
                if (obj == null || obj.IsDeleted())
                {
                    continue;
                }

                _AddReservedShot(new ref_count_ptr<StgShotObject>.unsync(obj), data);
            }

        }

        protected virtual void _AddReservedShot(ref_count_ptr<StgShotObject>.unsync obj, StgShotObject.ReserveShotListData data)
        {
            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();

            double ownAngle = GetDirectionAngle();
            double ox = GetPositionX();
            double oy = GetPositionY();

            double dRadius = data.GetRadius();
            double dAngle = data.GetAngle();
            double sx = obj.GetPositionX();
            double sy = obj.GetPositionY();
            double sAngle = obj.GetDirectionAngle();
            double angle = ownAngle + dAngle;

            double tx = ox + sx + dRadius * System.Math.Cos(Math.DegreeToRadian(angle));
            double ty = oy + sy + dRadius * System.Math.Sin(Math.DegreeToRadian(angle));
            obj.SetX(tx);
            obj.SetY(ty);

            StgShotManager shotManager = stageController_.GetShotManager();
            shotManager.AddShot(new ref_count_ptr<StgShotObject>(obj));
            obj.Activate();
            objectManager.ActivateObject(obj.GetObjectID(), true);
        }

        protected virtual void _ConvertToItemAndSendEvent()
        {
        }
        protected virtual void _SendDeleteEvent(int bit)
        {
            if (typeOwner_ != (int)AnonymousEnum4.OWNER_ENEMY)
            {
                return;
            }

            StgStageScriptManager stageScriptManager = stageController_.GetScriptManagerP();
            ref_count_ptr<ManagedScript> scriptShot = stageScriptManager.GetShotScript();
            if (scriptShot == null)
            {
                return;
            }

            StgShotManager shotManager = stageController_.GetShotManager();
            bool bSendEnable = shotManager.IsDeleteEventEnable(bit);
            if (!bSendEnable)
            {
                return;
            }

            int posX = (int)GetPositionX();
            int posY = (int)GetPositionY();

            List<double> listPos = new List<double>();
            listPos.Add(posX);
            listPos.Add(posY);

            int typeEvent = 0;
            switch (bit)
            {
            case StgShotManager.AnonymousEnum2.BIT_EV_DELETE_IMMEDIATE:
                typeEvent = StgStageShotScript.EV_DELETE_SHOT_IMMEDIATE;
                break;
            case StgShotManager.AnonymousEnum2.BIT_EV_DELETE_TO_ITEM:
                typeEvent = StgStageShotScript.EV_DELETE_SHOT_TO_ITEM;
                break;
            case StgShotManager.AnonymousEnum2.BIT_EV_DELETE_FADE:
                typeEvent = StgStageShotScript.EV_DELETE_SHOT_FADE;
                break;
            }

            List<gstd.value> listScriptValue = new List<gstd.value>();
            listScriptValue.Add(scriptShot.CreateRealValue(idObject_));
            listScriptValue.Add(scriptShot.CreateRealArrayValue(listPos));
            scriptShot.RequestEvent(typeEvent, listScriptValue);
        }


        /**********************************************************
        //StgShotObject
        **********************************************************/
        public StgShotObject(StgStageController stageController) : base(stageController)
        {
            stageController_ = stageController;

            frameWork_ = 0;
            posX_ = 0;
            posY_ = 0;
            idShotData_ = 0;
            typeBlend_ = DirectGraphics.MODE_BLEND_NONE;
            typeSourceBrend_ = DirectGraphics.MODE_BLEND_NONE;

            damage_ = 1;
            life_ = AnonymousEnum4.LIFE_SPELL_UNREGIST;
            bAutoDelete_ = true;
            bEraseShot_ = false;
            bSpellFactor_ = false;

            color_ = D3DCOLOR_ARGB(255, 255, 255, 255);
            delay_ = 0;
            frameGrazeInvalid_ = 0;
            frameFadeDelete_ = -1;
            frameAutoDelete_ = int.MaxValue;

            typeOwner_ = (int)AnonymousEnum4.OWNER_ENEMY;
            bUserIntersectionMode_ = false;
            bIntersectionEnable_ = true;
            bChangeItemEnable_ = true;

            int priShotI = stageController_.GetStageInformation().GetShotObjectPriority();
            double priShotD = (double)priShotI / (stageController_.GetMainObjectManager().GetRenderBucketCapacity() - 1);
            SetRenderPriority(priShotD);
        }

        public override void Dispose()
        {
            if (listReserveShot_ != null)
            {
                listReserveShot_.Clear(stageController_);
            }
            base.Dispose();
        }

        public override void Work()
        {
        }

        public override void Render()
        {
        } // �ꊇ�ŕ`�悷�邽�߃I�u�W�F�N�g�Ǘ��ł̕`��͂��Ȃ�
        public virtual void Activate()
        {
        }
        public virtual void RenderOnShotManager(D3DXMATRIX mat)
        {
        }
        public override void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget)
        {

        }

        public virtual void ClearShotObject()
        {
            ClearIntersectionRelativeTarget();
        }
        public abstract void RegistIntersectionTarget();

        public override void SetX(double x)
        {
            posX_ = x;
            DxScriptRenderObject.SetX(x);
        }
        public override void SetY(double y)
        {
            posY_ = y;
            DxScriptRenderObject.SetY(y);
        }
        public override void SetColor(int r, int g, int b)
        {
            color_ = ColorAccess.SetColorR(color_, r);
            color_ = ColorAccess.SetColorG(color_, g);
            color_ = ColorAccess.SetColorB(color_, b);
        }

        public override void SetAlpha(int alpha)
        {
            color_ = ColorAccess.SetColorA(color_, alpha);
        }

        public override void SetRenderState()
        {
        }

        public ref_count_ptr<StgShotObject>.unsync GetOwnObject()
        {
            return ref_count_ptr<StgShotObject>.unsync.DownCast(stageController_.GetMainRenderObject(idObject_));
        }

        public int GetShotDataID()
        {
            return idShotData_;
        }
        public virtual void SetShotDataID(int id)
        {
            idShotData_ = id;
        }
        public int GetOwnerType()
        {
            return typeOwner_;
        }
        public void SetOwnerType(int type)
        {
            typeOwner_ = type;
        }

        public bool IsValidGraze()
        {
            return frameGrazeInvalid_ <= 0;
        }
        public int GetDelay()
        {
            return delay_;
        }
        public void SetDelay(int delay)
        {
            delay_ = delay;
        }
        public int GetSourceBlendType()
        {
            return typeSourceBrend_;
        }
        public void SetSourceBlendType(int type)
        {
            typeSourceBrend_ = type;
        }
        public double GetLife()
        {
            return life_;
        }
        public void SetLife(double life)
        {
            life_ = life;
        }
        public double GetDamage()
        {
            return damage_;
        }
        public void SetDamage(double damage)
        {
            damage_ = damage;
        }
        public virtual void SetFadeDelete()
        {
            if (frameFadeDelete_ < 0)
            {
                frameFadeDelete_ = (int)AnonymousEnum4.FRAME_FADEDELETE;
            }
        }
        public bool IsAutoDelete()
        {
            return bAutoDelete_;
        }
        public void SetAutoDelete(bool b)
        {
            bAutoDelete_ = b;
        }
        public void SetAutoDeleteFrame(int frame)
        {
            frameAutoDelete_ = frame;
        }
        public bool IsEraseShot()
        {
            return bEraseShot_;
        }
        public void SetEraseShot(bool bErase)
        {
            bEraseShot_ = bErase;
        }
        public bool IsSpellFactor()
        {
            return bSpellFactor_;
        }
        public void SetSpellFactor(bool bSpell)
        {
            bSpellFactor_ = bSpell;
        }
        public void SetUserIntersectionMode(bool b)
        {
            bUserIntersectionMode_ = b;
        }
        public void SetIntersectionEnable(bool b)
        {
            bIntersectionEnable_ = b;
        }
        public void SetItemChangeEnable(bool b)
        {
            bChangeItemEnable_ = b;
        }

        public virtual void DeleteImmediate()
        {
            if (IsDeleted())
            {
                return;
            }

            _SendDeleteEvent((int)StgShotManager.AnonymousEnum2.BIT_EV_DELETE_IMMEDIATE);

            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            objectManager.DeleteObject(idObject_);
        }

        public virtual void ConvertToItem()
        {
            if (IsDeleted())
            {
                return;
            }

            if (bChangeItemEnable_)
            {
                _ConvertToItemAndSendEvent();
                _SendDeleteEvent((int)StgShotManager.AnonymousEnum2.BIT_EV_DELETE_TO_ITEM);
            }

            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            objectManager.DeleteObject(idObject_);
        }

        public void AddShot(int frame, int idShot, int radius, int angle)
        {
            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            objectManager.ActivateObject(idShot, false);

            if (listReserveShot_ == null)
            {
                listReserveShot_ = new ReserveShotList();
            }
            listReserveShot_.AddData(frame, idShot, radius, angle);
        }
}



/**********************************************************
//StgNormalShotObject
**********************************************************/
public class StgNormalShotObject : StgShotObject
{
        protected double angularVelocity_;
        protected void _AddIntersectionRelativeTarget()
        {
            if (delay_ > 0)
            {
                return;
            }
            if (frameFadeDelete_ >= 0)
            {
                return;
            }
            ClearIntersected();
            if (IsDeleted())
            {
                return;
            }
            if (bUserIntersectionMode_)
            {
                return; // ���[�U��`�����蔻�胂�[�h
            }
            if (!bIntersectionEnable_)
            {
                return;
            }

            StgShotData shotData = _GetShotData();
            if (shotData == null)
            {
                return;
            }

            StgIntersectionManager intersectionManager = stageController_.GetIntersectionManager();
            List<DxCircle> listCircle = shotData.GetIntersectionCircleList();
            if (GetIntersectionRelativeTargetCount() != listCircle.Count)
            {
                ClearIntersectionRelativeTarget();

                ref_count_ptr<StgShotObject>.unsync obj = GetOwnObject();
                if (obj == null)
                {
                    return;
                }
                ref_count_weak_ptr<StgShotObject>.unsync wObj = obj;

                for (int iTarget = 0 ; iTarget < listCircle.Count ; iTarget++)
                {
                    ref_count_ptr<StgIntersectionTarget_Circle>.unsync target = new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_CIRCLE));
                    if (typeOwner_ == OWNER_PLAYER)
                    {
                        target.SetTargetType(StgIntersectionTarget.TYPE_PLAYER_SHOT);
                    }
                    else
                    {
                        target.SetTargetType(StgIntersectionTarget.TYPE_ENEMY_SHOT);
                    }
                    target.SetObject(wObj);
                    AddIntersectionRelativeTarget(target);
                }
            }

            bool bInvalid = true;
            for (int iCircle = 0 ; iCircle < listCircle.Count ; iCircle++)
            {
                ref_count_ptr<StgIntersectionTarget>.unsync target = GetIntersectionRelativeTarget(iCircle);
                StgIntersectionTarget_Circle cTarget = (StgIntersectionTarget_Circle)target.GetPointer();

                DxCircle circle = listCircle[iCircle];
                if (circle.GetX() != 0 || circle.GetY() != 0)
                {
                    double angleZ = 0;
                    if (!shotData.IsFixedAngle())
                    {
                        angleZ = GetDirectionAngle() + 90 + angle_.z;
                    }
                    else
                    {
                        angleZ = angle_.z;
                    }

                    double px = circle.GetX() * System.Math.Cos(D3DXToRadian(angleZ)) - (-circle.GetY()) * System.Math.Sin(D3DXToRadian(angleZ));
                    double py = circle.GetX() * System.Math.Sin(D3DXToRadian(angleZ)) + (-circle.GetY()) * System.Math.Cos(D3DXToRadian(angleZ));
                    circle.SetX(px + posX_);
                    circle.SetY(py + posY_);
                }
                else
                {
                    circle.SetX(circle.GetX() + posX_);
                    circle.SetY(circle.GetY() + posY_);
                }
                cTarget.SetCircle(circle);

                RECT rect = cTarget.GetIntersectionSapceRect();
                if (rect.left != rect.right && rect.top != rect.bottom)
                {
                    bInvalid = false;
                }
            }

            if (typeOwner_ == OWNER_PLAYER)
            {
                // ���e�̏ꍇ�͓o�^
                bInvalid = false;
            }
            else
            {
                // ���@�̈ړ��͈͂����̒l���\�ł���ΓG�e�ł�o�^
                ref_count_ptr<StgPlayerObject>.unsync player = stageController_.GetPlayerObject();
                if (player != null)
                {
                    RECT rcClip = player.GetClip();
                    if (rcClip.left < 0 || rcClip.top < 0)
                    {
                        bInvalid = false;
                    }
                }
            }

            if (!bInvalid)
            {
                RegistIntersectionRelativeTarget(intersectionManager);
            }
        }

        protected override void _ConvertToItemAndSendEvent()
        {
            StgItemManager itemManager = stageController_.GetItemManager();
            StgStageScriptManager stageScriptManager = stageController_.GetScriptManagerP();
            ref_count_ptr<ManagedScript> scriptItem = stageScriptManager.GetItemScript();

            int posX = (int)GetPositionX();
            int posY = (int)GetPositionY();
            if (scriptItem != null)
            {
                List<double> listPos = new List<double>();
                listPos.Add(posX);
                listPos.Add(posY);

                List<gstd.value> listScriptValue = new List<gstd.value>();
                listScriptValue.Add(scriptItem.CreateRealValue(idObject_));
                listScriptValue.Add(scriptItem.CreateRealArrayValue(listPos));
                scriptItem.RequestEvent(StgStageScript.EV_DELETE_SHOT_TO_ITEM, listScriptValue);
            }

            if (itemManager.IsDefaultBonusItemEnable())
            {
                ref_count_ptr<StgItemObject>.unsync obj = new StgItemObject_Bonus(stageController_);
                ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
                int id = objectManager.AddObject(obj);
                if (id != DxScript.ID_INVALID)
                {
                    // �e�̍��W�ɃA�C�e����쐬����
                    StgItemManager itemManager = stageController_.GetItemManager();
                    itemManager.AddItem(new ref_count_ptr<StgItemObject>.unsync(obj));
                    obj.SetPositionX(posX);
                    obj.SetPositionY(posY);
                }
            }
        }


        /**********************************************************
        //StgNormalShotObject
        **********************************************************/
        public StgNormalShotObject(StgStageController stageController) : base(stageController)
        {
            typeObject_ = StgStageScript.OBJ_SHOT;
            angularVelocity_ = 0;
        }

        public override void Dispose()
        {

            base.Dispose();
        }

        public override void Work()
        {
            _Move();
            if (delay_ == 0)
            {
                _AddReservedShotWork();
            }

            delay_ = System.Math.Max(delay_ - 1, 0);
            frameWork_++;

            angle_.z += angularVelocity_;

            if (frameFadeDelete_ >= 0)
            {
                frameFadeDelete_--;
            }

            _DeleteInAutoClip();
            _DeleteInLife();
            _DeleteInFadeDelete();
            _DeleteInAutoDeleteFrame();
        }

        public override void RenderOnShotManager(D3DXMATRIX mat)
        {
            if (!IsVisible())
            {
                return;
            }

            StgShotData shotData = _GetShotData();
            if (shotData == null)
            {
                return;
            }

            StgShotRenderer renderer = null;

            int shotBlendType = DirectGraphics.MODE_BLEND_ALPHA;
            if (delay_ > 0)
            {
                // �x������
                int objDelayBlendType = GetSourceBlendType();
                if (objDelayBlendType == DirectGraphics.MODE_BLEND_NONE)
                {
                    shotBlendType = shotData.GetDelayRenderType();
                    renderer = shotData.GetRendererFromGraphicsBlendType(shotBlendType);
                }
                else
                {
                    renderer = shotData.GetRendererFromGraphicsBlendType(objDelayBlendType);
                }
            }
            else
            {
                int objBlendType = GetBlendType();
                if (objBlendType == DirectGraphics.MODE_BLEND_NONE)
                {
                    renderer = shotData.GetRenderer();
                    shotBlendType = shotData.GetRenderType();
                }
                else
                {
                    renderer = shotData.GetRendererFromGraphicsBlendType(objBlendType);
                }
            }

            if (renderer == null)
            {
                return;
            }

            D3DXMATRIX matScale = new D3DXMATRIX();
            D3DXMATRIX matRot = new D3DXMATRIX();
            D3DXMATRIX matTrans = new D3DXMATRIX();
            RECT rcSrc = new RECT();
            D3DCOLOR color = new D3DCOLOR();
            if (delay_ > 0)
            {
                // �x������
                double expa = 0.5f + (double)delay_ / 30.0f * 2;
                if (expa > 2)
                {
                    expa = 2;
                }

                double angleZ = 0;
                if (!shotData.IsFixedAngle())
                {
                    angleZ = GetDirectionAngle() + 90 + angle_.z;
                }
                else
                {
                    angleZ = angle_.z;
                }

                D3DXMatrixScaling(matScale, expa, expa, 1.0f);
                D3DXMatrixRotationYawPitchRoll(matRot, D3DXToRadian(angle_.y), D3DXToRadian(angle_.x), D3DXToRadian(angleZ));
                D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = matScale * matRot * matTrans * mat;
                mat.CopyFrom(matScale * matRot * matTrans * mat);

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcSrc = shotData->GetDelayRect();
                rcSrc.CopyFrom(shotData.GetDelayRect());
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = shotData->GetDelayColor();
                color.CopyFrom(shotData.GetDelayColor());
            }
            else
            {
                double angleZ = 0;
                if (!shotData.IsFixedAngle())
                {
                    angleZ = GetDirectionAngle() + 90 + angle_.z;
                }
                else
                {
                    angleZ = angle_.z;
                }

                D3DXMatrixScaling(matScale, scale_.x, scale_.y, scale_.z);
                D3DXMatrixRotationYawPitchRoll(matRot, D3DXToRadian(angle_.y), D3DXToRadian(angle_.x), D3DXToRadian(angleZ));
                D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = matScale * matRot * matTrans * mat;
                mat.CopyFrom(matScale * matRot * matTrans * mat);

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcSrc = shotData->GetRect(frameWork_);
                rcSrc.CopyFrom(shotData.GetRect(frameWork_));
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = color_;
                color.CopyFrom(color_);
                double alpha = shotData.GetAlpha() / 255.0;
                if (frameFadeDelete_ >= 0)
                {
                    alpha = (double)frameFadeDelete_ / (double)FRAME_FADEDELETE;
                }

                bool bValidAlpha = StgShotData.IsAlphaBlendValidType(shotBlendType);
                if (bValidAlpha)
                {
                    // ���L��
                    int colorA = ColorAccess.GetColorA(color);
                    color = ColorAccess.SetColorA(color, alpha * colorA);
                }
                else
                {
                    // ������
                    color = ColorAccess.ApplyAlpha(color, alpha);
                }
            }

            int width = rcSrc.right - rcSrc.left;
            int height = rcSrc.bottom - rcSrc.top;
            RECT rcDest = new RECT(-width / 2, -height / 2, width / 2, height / 2);
            if (width % 2 == 1)
            {
                rcDest.right += 1;
            }
            if (height % 2 == 1)
            {
                rcDest.bottom += 1;
            }

            // if(bIntersected_)color = D3DCOLOR_ARGB(255, 255, 0, 0);//�ڐG�e�X�g

            VERTEX_TLX[] verts = Arrays.InitializeWithDefaultInstances<VERTEX_TLX>(4);
            int[] srcX = { rcSrc.left, rcSrc.right, rcSrc.left, rcSrc.right };
            int[] srcY = { rcSrc.top, rcSrc.top, rcSrc.bottom, rcSrc.bottom };
            int[] destX = { rcDest.left, rcDest.right, rcDest.left, rcDest.right };
            int[] destY = { rcDest.top, rcDest.top, rcDest.bottom, rcDest.bottom };
            for (int iVert = 0 ;iVert < 4 ; iVert++)
            {
                _SetVertexUV(verts[iVert], srcX[iVert], srcY[iVert]);
                _SetVertexPosition(verts[iVert], destX[iVert], destY[iVert]);
                _SetVertexColorARGB(verts[iVert], new D3DCOLOR(color));
                verts[iVert].position = DxMath.VectMatMulti(verts[iVert].position, mat);
            }

            renderer.AddVertex(verts[0]);
            renderer.AddVertex(verts[2]);
            renderer.AddVertex(verts[1]);
            renderer.AddVertex(verts[1]);
            renderer.AddVertex(verts[2]);
            renderer.AddVertex(verts[3]);
        }

        public override void ClearShotObject()
        {
            ClearIntersectionRelativeTarget();
        }

        public override void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget)
        {
            double damage = 0;
            int otherType = otherTarget.GetTargetType();
            switch (otherType)
            {
                case StgIntersectionTarget.TYPE_PLAYER:
                {
                    // ���@
                    frameGrazeInvalid_ = int.MaxValue;
                    break;
                }
                case StgIntersectionTarget.TYPE_PLAYER_SHOT:
                {
                    // ���@�e
                    StgShotObject shot = (StgShotObject)otherTarget.GetObject().GetPointer();
                    if (shot != null)
                    {
                        bool bEraseShot = shot.IsEraseShot();
                        if (bEraseShot && life_ != LIFE_SPELL_REGIST)
                        {
                            ConvertToItem();
                        }
                    }
                    break;
                }
                case StgIntersectionTarget.TYPE_PLAYER_SPELL:
                {
                    // ���@�X�y��
                    StgPlayerSpellObject spell = (StgPlayerSpellObject)otherTarget.GetObject().GetPointer();
                    if (spell != null)
                    {
                        bool bEraseShot = spell.IsEraseShot();
                        if (bEraseShot && life_ != LIFE_SPELL_REGIST)
                        {
                            ConvertToItem();
                        }
                    }
                    break;
                }
                case StgIntersectionTarget.TYPE_ENEMY:
                case StgIntersectionTarget.TYPE_ENEMY_SHOT:
                {
                    damage = 1;
                    break;
                }
            }

            if (life_ != LIFE_SPELL_REGIST)
            {
                life_ = System.Math.Max(life_ - damage, 0);
            }
        }

        public override void RegistIntersectionTarget()
        {
            if (!bUserIntersectionMode_)
            {
                _AddIntersectionRelativeTarget();
            }

        }

        public override List<ref_count_ptr<StgIntersectionTarget>.unsync > GetIntersectionTargetList()
        {
            List<ref_count_ptr<StgIntersectionTarget>.unsync > res = new List<ref_count_ptr<StgIntersectionTarget>.unsync >();

            if (delay_ > 0)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            if (frameFadeDelete_ >= 0)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            if (IsDeleted())
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            if (bUserIntersectionMode_)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res); // ���[�U��`�����蔻�胂�[�h
            }
            if (!bIntersectionEnable_)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }

            StgShotData shotData = _GetShotData();
            if (shotData == null)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }

            List<DxCircle> listCircle = shotData.GetIntersectionCircleList();
            StgIntersectionManager intersectionManager = stageController_.GetIntersectionManager();


            for (int iCircle = 0 ; iCircle < listCircle.Count ; iCircle++)
            {
                ref_count_ptr<StgIntersectionTarget_Circle>.unsync target = new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_CIRCLE));
                StgIntersectionTarget_Circle cTarget = (StgIntersectionTarget_Circle)target.GetPointer();

                DxCircle circle = listCircle[iCircle];
                if (circle.GetX() != 0 || circle.GetY() != 0)
                {
                    double angleZ = 0;
                    if (!shotData.IsFixedAngle())
                    {
                        angleZ = GetDirectionAngle() + 90 + angle_.z;
                    }
                    else
                    {
                        angleZ = angle_.z;
                    }

                    double px = circle.GetX() * System.Math.Cos(D3DXToRadian(angleZ)) - (-circle.GetY()) * System.Math.Sin(D3DXToRadian(angleZ));
                    double py = circle.GetX() * System.Math.Sin(D3DXToRadian(angleZ)) + (-circle.GetY()) * System.Math.Cos(D3DXToRadian(angleZ));
                    circle.SetX(px + posX_);
                    circle.SetY(py + posY_);
                }
                else
                {
                    circle.SetX(circle.GetX() + posX_);
                    circle.SetY(circle.GetY() + posY_);
                }
                cTarget.SetCircle(circle);

                res.Add(target);
            }

            return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
        }

        public override void SetShotDataID(int id)
        {
            StgShotData oldData = _GetShotData();
            base.SetShotDataID(id);

            // �p���x�X�V
            StgShotData shotData = _GetShotData();
            if (shotData != null && oldData != shotData)
            {
                if (angularVelocity_ != 0)
                {
                    angularVelocity_ = 0;
                    angle_.z = 0;
                }

                double avMin = shotData.GetAngularVelocityMin();
                double avMax = shotData.GetAngularVelocityMax();
                if (avMin != 0 || avMax != 0)
                {
                    ref_count_ptr<StgStageInformation> stageInfo = stageController_.GetStageInformation();
                    ref_count_ptr<MersenneTwister> rand = stageInfo.GetMersenneTwister();
                    angularVelocity_ = rand.GetReal(avMin, avMax);
                }

            }

        }
}

/**********************************************************
//StgLaserObject(���[�U�[��{��)
**********************************************************/
public abstract class StgLaserObject : StgShotObject
{
        protected int length_;
        protected int widthRender_;
        protected int widthIntersection_;
        protected int invalidLengthStart_;
        protected int invalidLengthEnd_;
        protected int frameGrazeInvalidStart_;
        protected double itemDistance_;
        protected void _AddIntersectionRelativeTarget()
        {
            if (delay_ > 0)
            {
                return;
            }
            if (frameFadeDelete_ >= 0)
            {
                return;
            }
            ClearIntersected();

            StgIntersectionManager intersectionManager = stageController_.GetIntersectionManager();
            List<ref_count_ptr<StgIntersectionTarget>.unsync > listTarget = GetIntersectionTargetList();
            for (int iTarget = 0 ; iTarget < listTarget.Count ; iTarget++)
            {
                intersectionManager.AddTarget(new List<ref_count_ptr<StgIntersectionTarget>.unsync >(listTarget[iTarget]));
            }
        }


        /**********************************************************
        //StgLaserObject(���[�U�[��{��)
        **********************************************************/
        public StgLaserObject(StgStageController stageController) : base(stageController)
        {
            life_ = LIFE_SPELL_REGIST;
            length_ = 0;
            widthRender_ = 0;
            widthIntersection_ = -1;
            invalidLengthStart_ = -1;
            invalidLengthEnd_ = -1;
            frameGrazeInvalidStart_ = 20;
            itemDistance_ = 24;
        }

        public override void ClearShotObject()
        {
            ClearIntersectionRelativeTarget();
        }

        public override void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget)
        {
            double damage = 0;
            int otherType = otherTarget.GetTargetType();
            switch (otherType)
            {
                case StgIntersectionTarget.TYPE_PLAYER:
                {
                    // ���@
                    if (frameGrazeInvalid_ <= 0)
                    {
                        frameGrazeInvalid_ = frameGrazeInvalidStart_ > 0 ? frameGrazeInvalidStart_ : int.MaxValue;
                    }
                    break;
                }
                case StgIntersectionTarget.TYPE_PLAYER_SHOT:
                {
                    // ���@�e�e
                    StgShotObject shot = (StgShotObject)otherTarget.GetObject().GetPointer();
                    if (shot != null)
                    {
                        bool bEraseShot = shot.IsEraseShot();
                        if (bEraseShot && life_ != LIFE_SPELL_REGIST)
                        {
                            damage = shot.GetDamage();
                            ConvertToItem();
                        }
                    }
                    break;
                }
                case StgIntersectionTarget.TYPE_PLAYER_SPELL:
                {
                    // ���@�X�y��
                    StgPlayerSpellObject spell = (StgPlayerSpellObject)otherTarget.GetObject().GetPointer();
                    if (spell != null)
                    {
                        bool bEraseShot = spell.IsEraseShot();
                        if (bEraseShot && life_ != LIFE_SPELL_REGIST)
                        {
                            damage = spell.GetDamage();
                            ConvertToItem();
                        }
                    }
                    break;
                }
            }
            if (life_ != LIFE_SPELL_REGIST)
            {
                life_ = System.Math.Max(life_ - damage, 0);
            }
        }

        public int GetLength()
        {
            return length_;
        }
        public void SetLength(int length)
        {
            length_ = length;
            if (invalidLengthStart_ < 0)
            {
                invalidLengthStart_ = (int)length_ * 0.1;
            }
            if (invalidLengthEnd_ < 0)
            {
                invalidLengthEnd_ = (int)length_ * 0.1;
            }
        }

        public int GetRenderWidth()
        {
            return widthRender_;
        }
        public void SetRenderWidth(int width)
        {
            widthRender_ = width;
            if (widthIntersection_ < 0)
            {
                widthIntersection_ = width / 4;
            }
        }

        public int GetIntersectionWidth()
        {
            return widthIntersection_;
        }
        public void SetIntersectionWidth(int width)
        {
            widthIntersection_ = width;
        }
        public void SetInvalidLength(int start, int end)
        {
            invalidLengthStart_ = start;
            invalidLengthEnd_ = end;
        }
        public void SetGrazeInvalidFrame(int frame)
        {
            frameGrazeInvalidStart_ = frame;
        }
        public void SetItemDistance(double dist)
        {
            itemDistance_ = dist;
        }
}

/**********************************************************
//StgLooseLaserObject(�ˏo�^���[�U�[)
**********************************************************/
public class StgLooseLaserObject : StgLaserObject
{
        protected double posXE_; // ���x
        protected double posYE_; // ���y

        protected override void _DeleteInAutoClip()
        {
            if (IsDeleted())
            {
                return;
            }
            if (!IsAutoDelete())
            {
                return;
            }
            StgShotManager shotManager = stageController_.GetShotManager();
            RECT rect = shotManager.GetShotAutoDeleteClipRect();
            if ((posX_ < rect.left && posXE_ < rect.left) || (posX_ > rect.right && posXE_ > rect.right) || (posY_ < rect.top && posYE_ < rect.top) || (posY_ > rect.bottom && posYE_ > rect.bottom))
            {
                ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
                objectManager.DeleteObject(idObject_);
            }
        }

        protected override void _Move()
        {
            if (delay_ == 0)
            {
                base._Move();
            }
            DxScriptRenderObject.SetX(posX_);
            DxScriptRenderObject.SetY(posY_);

            if (delay_ > 0)
            {
                return;
            }
            double radius = System.Math.Pow(System.Math.Pow(posXE_ - posX_,2) + System.Math.Pow(posYE_ - posY_,2), 0.5);
            if (radius > length_)
            {
                double speed = GetSpeed();
                double ang = GetDirectionAngle();
                posXE_ += speed * System.Math.Cos(Math.DegreeToRadian(ang));
                posYE_ += speed * System.Math.Sin(Math.DegreeToRadian(ang));
            }
        }

        protected override void _ConvertToItemAndSendEvent()
        {
            StgItemManager itemManager = stageController_.GetItemManager();
            StgStageScriptManager stageScriptManager = stageController_.GetScriptManagerP();
            ref_count_ptr<ManagedScript> scriptItem = stageScriptManager.GetItemScript();

            int ex = (int)GetPositionX();
            int ey = (int)GetPositionY();
            double angle = GetDirectionAngle();

            int length = System.Math.Pow(System.Math.Pow(posXE_ - posX_, 2) + System.Math.Pow(posYE_ - posY_, 2), 0.5);
            for (double itemPos = 0 ; itemPos < length ; itemPos += itemDistance_)
            {
                double posX = ex - itemPos * System.Math.Cos(Math.DegreeToRadian(angle));
                double posY = ey - itemPos * System.Math.Sin(Math.DegreeToRadian(angle));
                if (scriptItem != null)
                {
                    List<double> listPos = new List<double>();
                    listPos.Add(posX);
                    listPos.Add(posY);

                    List<gstd.value> listScriptValue = new List<gstd.value>();
                    listScriptValue.Add(scriptItem.CreateRealValue(idObject_));
                    listScriptValue.Add(scriptItem.CreateRealArrayValue(listPos));
                    scriptItem.RequestEvent(StgStageScript.EV_DELETE_SHOT_TO_ITEM, listScriptValue);
                }

                if (itemManager.IsDefaultBonusItemEnable() && delay_ == 0)
                {
                    ref_count_ptr<StgItemObject>.unsync obj = new StgItemObject_Bonus(stageController_);
                    int id = stageController_.GetMainObjectManager().AddObject(obj);
                    if (id != DxScript.ID_INVALID)
                    {
                        // �e�̍��W�ɃA�C�e����쐬����
                        itemManager.AddItem(new ref_count_ptr<StgItemObject>.unsync(obj));
                        obj.SetPositionX(posX);
                        obj.SetPositionY(posY);
                    }

                }
            }
        }


        /**********************************************************
        //StgLooseLaserObject(�ˏo�^���[�U�[)
        **********************************************************/
        public StgLooseLaserObject(StgStageController stageController) : base(stageController)
        {
            typeObject_ = StgStageScript.OBJ_LOOSE_LASER;
        }

        public override void Work()
        {
            // 1�t���[���ڂ͈ړ����Ȃ�
            if (frameWork_ == 0)
            {
                posXE_ = posX_;
                posYE_ = posY_;
            }

            _Move();
            if (delay_ == 0)
            {
                _AddReservedShotWork();
            }

            delay_ = System.Math.Max(delay_ - 1, 0);
            frameWork_++;

            if (frameFadeDelete_ >= 0)
            {
                frameFadeDelete_--;
            }

            _DeleteInAutoClip();
            _DeleteInLife();
            _DeleteInFadeDelete();
            _DeleteInAutoDeleteFrame();
        // 	_AddIntersectionRelativeTarget();
            frameGrazeInvalid_--;
        }

        public override void RenderOnShotManager(D3DXMATRIX mat)
        {
            if (!IsVisible())
            {
                return;
            }

            StgShotData shotData = _GetShotData();
            if (shotData == null)
            {
                return;
            }

            int shotBlendType = (int)StgShotDataList.AnonymousEnum3.RENDER_ADD_ARGB;
            StgShotRenderer renderer = null;
            if (delay_ > 0)
            {
                // �x������
                int objDelayBlendType = GetSourceBlendType();
                if (objDelayBlendType == DirectGraphics.MODE_BLEND_NONE)
                {
                    renderer = shotData.GetRenderer((int)StgShotDataList.AnonymousEnum3.RENDER_ADD_ARGB);
                    shotBlendType = DirectGraphics.MODE_BLEND_ADD_ARGB;
                }
                else
                {
                    renderer = shotData.GetRendererFromGraphicsBlendType(objDelayBlendType);
                }
            }
            else
            {
                int objBlendType = GetBlendType();
                int shotBlendType = objBlendType;
                if (objBlendType == DirectGraphics.MODE_BLEND_NONE)
                {
                    renderer = shotData.GetRenderer((int)StgShotDataList.AnonymousEnum3.RENDER_ADD_ARGB);
                    shotBlendType = DirectGraphics.MODE_BLEND_ADD_ARGB;
                }
                else
                {
                    renderer = shotData.GetRendererFromGraphicsBlendType(objBlendType);
                }
            }

            if (renderer == null)
            {
                return;
            }

            D3DXMATRIX matScale = new D3DXMATRIX();
            D3DXMATRIX matRot = new D3DXMATRIX();
            D3DXMATRIX matTrans = new D3DXMATRIX();
            RECT rcSrc = new RECT();
            RECT rcDest = new RECT();
            D3DCOLOR color = new D3DCOLOR();
            if (delay_ > 0)
            {
                // �x������
                double expa = 0.5f + (double)delay_ / 30.0f * 2;
                if (expa > 3.5)
                {
                    expa = 3.5;
                }

                D3DXMatrixScaling(matScale, expa, expa, 1.0f);
                D3DXMatrixRotationYawPitchRoll(matRot, 0, 0, D3DXToRadian(GetDirectionAngle() + 90));
                D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = matScale * matRot * matTrans * mat;
                mat.CopyFrom(matScale * matRot * matTrans * mat);

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcSrc = shotData->GetDelayRect();
                rcSrc.CopyFrom(shotData.GetDelayRect());
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = shotData->GetDelayColor();
                color.CopyFrom(shotData.GetDelayColor());

                int width = rcSrc.right - rcSrc.left;
                int height = rcSrc.bottom - rcSrc.top;
                SetRect(rcDest, -width / 2, -height / 2, width / 2, height / 2);
                if (width % 2 == 1)
                {
                    rcDest.right += 1;
                }
                if (height % 2 == 1)
                {
                    rcDest.bottom += 1;
                }
            }
            else
            {
                D3DXMatrixScaling(matScale, 1.0f, 1.0f, 1.0f);
                D3DXMatrixRotationYawPitchRoll(matRot, 0, 0, D3DXToRadian(GetDirectionAngle() + 90));
                D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = matScale * matRot * matTrans * mat;
                mat.CopyFrom(matScale * matRot * matTrans * mat);

                double radius = System.Math.Pow(System.Math.Pow(posXE_ - posX_,2) + System.Math.Pow(posYE_ - posY_,2), 0.5);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcSrc = shotData->GetRect(frameWork_);
                rcSrc.CopyFrom(shotData.GetRect(frameWork_));
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = color_;
                color.CopyFrom(color_);
                double alpha = shotData.GetAlpha() / 255.0;
                if (frameFadeDelete_ >= 0)
                {
                    alpha = (double)frameFadeDelete_ / (double)FRAME_FADEDELETE;
                }

                bool bValidAlpha = StgShotData.IsAlphaBlendValidType(shotBlendType);
                if (bValidAlpha)
                {
                    // ���L��
                    int colorA = ColorAccess.GetColorA(color);
                    color = ColorAccess.SetColorA(color, alpha * colorA);
                }
                else
                {
                    // ������
                    color = ColorAccess.ApplyAlpha(color, alpha);
                }

                color = ColorAccess.ApplyAlpha(color, alpha);
                SetRect(rcDest, -widthRender_ / 2, 0, widthRender_ / 2, radius);
            }


            VERTEX_TLX[] verts = Arrays.InitializeWithDefaultInstances<VERTEX_TLX>(4);
            int[] srcX = { rcSrc.left, rcSrc.right, rcSrc.left, rcSrc.right };
            int[] srcY = { rcSrc.top, rcSrc.top, rcSrc.bottom, rcSrc.bottom };
            int[] destX = { rcDest.left, rcDest.right, rcDest.left, rcDest.right };
            int[] destY = { rcDest.top, rcDest.top, rcDest.bottom, rcDest.bottom };
            for (int iVert = 0 ;iVert < 4 ; iVert++)
            {
                _SetVertexUV(verts[iVert], srcX[iVert], srcY[iVert]);
                _SetVertexPosition(verts[iVert], destX[iVert], destY[iVert]);
                _SetVertexColorARGB(verts[iVert], new D3DCOLOR(color));
                verts[iVert].position = DxMath.VectMatMulti(verts[iVert].position, mat);
            }

            renderer.AddVertex(verts[0]);
            renderer.AddVertex(verts[2]);
            renderer.AddVertex(verts[1]);
            renderer.AddVertex(verts[1]);
            renderer.AddVertex(verts[2]);
            renderer.AddVertex(verts[3]);
        }

        public override void RegistIntersectionTarget()
        {
            if (!bUserIntersectionMode_)
            {
                _AddIntersectionRelativeTarget();
            }
        }

        public override List<ref_count_ptr<StgIntersectionTarget>.unsync > GetIntersectionTargetList()
        {
            List<ref_count_ptr<StgIntersectionTarget>.unsync > res = new List<ref_count_ptr<StgIntersectionTarget>.unsync >();

            if (delay_ > 0)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            if (frameFadeDelete_ >= 0)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            if (IsDeleted())
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            if (bUserIntersectionMode_)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res); // ���[�U��`�����蔻�胂�[�h
            }
            if (!bIntersectionEnable_)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }

            StgShotData shotData = _GetShotData();
            if (shotData == null)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }

            ref_count_ptr<StgShotObject>.unsync obj = GetOwnObject();
            if (obj == null)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }

            // �����蔻��
            double ang = GetDirectionAngle();
            int length = System.Math.Pow(System.Math.Pow(posXE_ - posX_, 2) + System.Math.Pow(posYE_ - posY_, 2), 0.5);
            int invalidLengthS = System.Math.Min(length, invalidLengthStart_);
            int posXS = (int)posX_ - invalidLengthS * System.Math.Cos(Math.DegreeToRadian(ang));
            int posYS = (int)posY_ - invalidLengthS * System.Math.Sin(Math.DegreeToRadian(ang));
            int invalidLengthE = System.Math.Min(length, invalidLengthEnd_);
            int posXE = (int)posXE_ + invalidLengthE * System.Math.Cos(Math.DegreeToRadian(ang));
            int posYE = (int)posYE_ + invalidLengthE * System.Math.Sin(Math.DegreeToRadian(ang));

            StgIntersectionManager intersectionManager = stageController_.GetIntersectionManager();
            DxWidthLine line = new DxWidthLine(posXS, posYS, posXE, posYE, widthIntersection_);

            ref_count_weak_ptr<StgShotObject>.unsync wObj = obj;
            ref_count_ptr<StgIntersectionTarget_Line>.unsync target = new ref_count_ptr<StgIntersectionTarget_Line>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_LINE));
            if (typeOwner_ == OWNER_PLAYER)
            {
                target.SetTargetType(StgIntersectionTarget.TYPE_PLAYER_SHOT);
            }
            else
            {
                target.SetTargetType(StgIntersectionTarget.TYPE_ENEMY_SHOT);
            }
            target.SetObject(wObj);
            target.SetLine(line);

            res.Add(target);
            return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
        }

        public override void SetX(double x)
        {
            base.SetX(x);
            posXE_ = x;
        }
        public override void SetY(double y)
        {
            base.SetY(y);
            posYE_ = y;
        }
}

/**********************************************************
//StgStraightLaserObject(�ݒu�^���[�U�[)
**********************************************************/
public class StgStraightLaserObject : StgLaserObject
{
        protected double angLaser_;
        protected bool bUseSouce_;
        protected double scaleX_;

        protected override void _DeleteInAutoClip()
        {
            if (IsDeleted())
            {
                return;
            }
            if (!IsAutoDelete())
            {
                return;
            }
            StgShotManager shotManager = stageController_.GetShotManager();
            RECT rect = shotManager.GetShotAutoDeleteClipRect();
            int posXE = (int)posX_ + (int)(length_ * System.Math.Cos(Math.DegreeToRadian(angLaser_)));
            int posYE = (int)posY_ + (int)(length_ * System.Math.Sin(Math.DegreeToRadian(angLaser_)));

            if ((posX_ < rect.left && posXE < rect.left) || (posX_ > rect.right && posXE > rect.right) || (posY_ < rect.top && posYE < rect.top) || (posY_ > rect.bottom && posYE > rect.bottom))
            {
                ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
                objectManager.DeleteObject(idObject_);
            }
        }

        protected override void _DeleteInAutoDeleteFrame()
        {
            if (IsDeleted())
            {
                return;
            }
            if (delay_ > 0)
            {
                return;
            }

            if (frameAutoDelete_ <= 0)
            {
                SetFadeDelete();
            }
            frameAutoDelete_ = System.Math.Max(0, frameAutoDelete_ - 1);
        }

        protected override void _AddReservedShot(ref_count_ptr<StgShotObject>.unsync obj, StgShotObject.ReserveShotListData data)
        {
            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();

            double ownAngle = GetDirectionAngle();
            double ox = GetPositionX();
            double oy = GetPositionY();

            double dRadius = data.GetRadius();
            double dAngle = data.GetAngle();
            double sx = obj.GetPositionX();
            double sy = obj.GetPositionY();
            double objAngle = obj.GetDirectionAngle();
            double sAngle = angLaser_;
            double angle = sAngle + dAngle;

            double tx = ox + sx + dRadius * System.Math.Cos(Math.DegreeToRadian(angle));
            double ty = oy + sy + dRadius * System.Math.Sin(Math.DegreeToRadian(angle));
            obj.SetPositionX(tx);
            obj.SetPositionY(ty);
            obj.SetDirectionAngle(angle + objAngle);

            StgShotManager shotManager = stageController_.GetShotManager();
            shotManager.AddShot(new ref_count_ptr<StgShotObject>(obj));
            obj.Activate();
            objectManager.ActivateObject(obj.GetObjectID(), true);
        }

        protected override void _ConvertToItemAndSendEvent()
        {
            StgItemManager itemManager = stageController_.GetItemManager();
            StgStageScriptManager stageScriptManager = stageController_.GetScriptManagerP();
            ref_count_ptr<ManagedScript> scriptItem = stageScriptManager.GetItemScript();

            int ex = (int)GetPositionX();
            int ey = (int)GetPositionY();
            double angle = angLaser_;

            for (double itemPos = 0 ; itemPos < length_ ; itemPos += itemDistance_)
            {
                double posX = ex + itemPos * System.Math.Cos(Math.DegreeToRadian(angle));
                double posY = ey + itemPos * System.Math.Sin(Math.DegreeToRadian(angle));

                if (scriptItem != null)
                {
                    List<double> listPos = new List<double>();
                    listPos.Add(posX);
                    listPos.Add(posY);

                    List<gstd.value> listScriptValue = new List<gstd.value>();
                    listScriptValue.Add(scriptItem.CreateRealValue(idObject_));
                    listScriptValue.Add(scriptItem.CreateRealArrayValue(listPos));
                    scriptItem.RequestEvent(StgStageScript.EV_DELETE_SHOT_TO_ITEM, listScriptValue);
                }

                if (itemManager.IsDefaultBonusItemEnable() && delay_ == 0)
                {
                    ref_count_ptr<StgItemObject>.unsync obj = new StgItemObject_Bonus(stageController_);
                    int id = stageController_.GetMainObjectManager().AddObject(obj);
                    if (id != DxScript.ID_INVALID)
                    {
                        // �e�̍��W�ɃA�C�e����쐬����
                        itemManager.AddItem(new ref_count_ptr<StgItemObject>.unsync(obj));
                        obj.SetPositionX(posX);
                        obj.SetPositionY(posY);
                    }
                }
            }
        }


        /**********************************************************
        //StgStraightLaserObject(�ݒu�^���[�U�[)
        **********************************************************/
        public StgStraightLaserObject(StgStageController stageController) : base(stageController)
        {
            typeObject_ = StgStageScript.OBJ_STRAIGHT_LASER;
            angLaser_ = 270;
            frameFadeDelete_ = -1;
            bUseSouce_ = true;
            scaleX_ = 0.05;
        }

        public override void Work()
        {
            _Move();
            if (delay_ == 0)
            {
                _AddReservedShotWork();
            }

            delay_ = System.Math.Max(delay_ - 1, 0);
            if (delay_ <= 0)
            {
                scaleX_ = System.Math.Min(1.0, scaleX_ + 0.1);
            }

            frameWork_++;

            if (frameFadeDelete_ >= 0)
            {
                frameFadeDelete_--;
            }

            _DeleteInAutoClip();
            _DeleteInLife();
            _DeleteInFadeDelete();
            _DeleteInAutoDeleteFrame();
        // 	_AddIntersectionRelativeTarget();
            frameGrazeInvalid_--;
        }

        public override void RenderOnShotManager(D3DXMATRIX mat)
        {
            if (!IsVisible())
            {
                return;
            }

            StgShotData shotData = _GetShotData();
            if (shotData == null)
            {
                return;
            }

            int objBlendType = GetBlendType();
            int shotBlendType = objBlendType;
            {
                StgShotRenderer renderer = null;
                if (objBlendType == DirectGraphics.MODE_BLEND_NONE)
                {
                    renderer = shotData.GetRenderer((int)StgShotDataList.AnonymousEnum3.RENDER_ADD_ARGB);
                    shotBlendType = DirectGraphics.MODE_BLEND_ADD_ARGB;
                }
                else
                {
                    renderer = shotData.GetRendererFromGraphicsBlendType(objBlendType);
                }
                if (renderer == null)
                {
                    return;
                }

                // ���[�U�[
                D3DXMATRIX matScale = new D3DXMATRIX();
                D3DXMATRIX matRot = new D3DXMATRIX();
                D3DXMATRIX matTrans = new D3DXMATRIX();
                RECT rcSrc = new RECT();
                RECT rcDest = new RECT();
                D3DCOLOR color = new D3DCOLOR();
                D3DXMatrixScaling(matScale, scaleX_, 1.0f, 1.0f);
                D3DXMatrixRotationYawPitchRoll(matRot, 0, 0, D3DXToRadian(angLaser_ + 270));
                D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
                D3DXMATRIX matLaser = matScale * matRot * matTrans * mat;

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcSrc = shotData->GetRect(frameWork_);
                rcSrc.CopyFrom(shotData.GetRect(frameWork_));
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = color_;
                color.CopyFrom(color_);
                double alpha = shotData.GetAlpha() / 255.0;
                if (frameFadeDelete_ >= 0)
                {
                    alpha = (double)frameFadeDelete_ / (double)FRAME_FADEDELETE_LASER;
                }

                bool bValidAlpha = StgShotData.IsAlphaBlendValidType(shotBlendType);
                if (bValidAlpha)
                {
                    // ���L��
                    int colorA = ColorAccess.GetColorA(color);
                    color = ColorAccess.SetColorA(color, alpha * colorA);
                }
                else
                {
                    // ������
                    color = ColorAccess.ApplyAlpha(color, alpha);
                }

        // 		if(delay_ > 0)
        // 			SetRect(&rcDest, -16, length_, 16, 0);
        // 		else
                    SetRect(rcDest, -widthRender_ / 2, length_, widthRender_ / 2, 0);

                VERTEX_TLX[] verts = Arrays.InitializeWithDefaultInstances<VERTEX_TLX>(4);
                int[] srcX = { rcSrc.left, rcSrc.right, rcSrc.left, rcSrc.right };
                int[] srcY = { rcSrc.top, rcSrc.top, rcSrc.bottom, rcSrc.bottom };
                int[] destX = { rcDest.left, rcDest.right, rcDest.left, rcDest.right };
                int[] destY = { rcDest.top, rcDest.top, rcDest.bottom, rcDest.bottom };
                for (int iVert = 0 ;iVert < 4 ; iVert++)
                {
                    _SetVertexUV(verts[iVert], srcX[iVert], srcY[iVert]);
                    _SetVertexPosition(verts[iVert], destX[iVert], destY[iVert]);
                    _SetVertexColorARGB(verts[iVert], new D3DCOLOR(color));
                    verts[iVert].position = DxMath.VectMatMulti(verts[iVert].position, matLaser);
                }

                renderer.AddVertex(verts[0]);
                renderer.AddVertex(verts[2]);
                renderer.AddVertex(verts[1]);
                renderer.AddVertex(verts[1]);
                renderer.AddVertex(verts[2]);
                renderer.AddVertex(verts[3]);
            }

            if (bUseSouce_ && frameFadeDelete_ < 0)
            {
                StgShotRenderer renderer = null;
                int objSourceBlendType = GetSourceBlendType();
                int sourceBlendType = shotBlendType;
                if (objSourceBlendType == DirectGraphics.MODE_BLEND_NONE)
                {
                    // ���ݒ�̏ꍇ�́A���[�U�[�`���ʂ�����p��
                    renderer = shotData.GetRendererFromGraphicsBlendType(sourceBlendType);
                }
                else
                {
                    renderer = shotData.GetRendererFromGraphicsBlendType(objSourceBlendType);
                    sourceBlendType = objSourceBlendType;
                }
                if (renderer == null)
                {
                    return;
                }

                // ����
                D3DXMATRIX matScale = new D3DXMATRIX();
                D3DXMATRIX matRot = new D3DXMATRIX();
                D3DXMATRIX matTrans = new D3DXMATRIX();
                RECT rcSrc = new RECT();
                RECT rcDest = new RECT();
                D3DCOLOR color = new D3DCOLOR();
                D3DXMatrixScaling(matScale, 1.0f, 1.0f, 1.0f);
                D3DXMatrixRotationYawPitchRoll(matRot, 0, 0, D3DXToRadian(angLaser_ + 270));
                D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
                D3DXMATRIX matSource = matScale * matRot * matTrans * mat;

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcSrc = shotData->GetDelayRect();
                rcSrc.CopyFrom(shotData.GetDelayRect());
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = shotData->GetDelayColor();
                color.CopyFrom(shotData.GetDelayColor());

                int sourceWidth = widthRender_ * 2 / 3;
                SetRect(rcDest, -sourceWidth, -sourceWidth, sourceWidth, sourceWidth);

                VERTEX_TLX[] verts = Arrays.InitializeWithDefaultInstances<VERTEX_TLX>(4);
                int[] srcX = { rcSrc.left, rcSrc.right, rcSrc.left, rcSrc.right };
                int[] srcY = { rcSrc.top, rcSrc.top, rcSrc.bottom, rcSrc.bottom };
                int[] destX = { rcDest.left, rcDest.right, rcDest.left, rcDest.right };
                int[] destY = { rcDest.top, rcDest.top, rcDest.bottom, rcDest.bottom };
                for (int iVert = 0 ;iVert < 4 ; iVert++)
                {
                    _SetVertexUV(verts[iVert], srcX[iVert], srcY[iVert]);
                    _SetVertexPosition(verts[iVert], destX[iVert], destY[iVert]);
                    _SetVertexColorARGB(verts[iVert], new D3DCOLOR(color));
                    verts[iVert].position = DxMath.VectMatMulti(verts[iVert].position, matSource);
                }

                renderer.AddVertex(verts[0]);
                renderer.AddVertex(verts[2]);
                renderer.AddVertex(verts[1]);
                renderer.AddVertex(verts[1]);
                renderer.AddVertex(verts[2]);
                renderer.AddVertex(verts[3]);
            }

        }

        public override void RegistIntersectionTarget()
        {
            if (!bUserIntersectionMode_)
            {
                _AddIntersectionRelativeTarget();
            }
        }

        public override List<ref_count_ptr<StgIntersectionTarget>.unsync > GetIntersectionTargetList()
        {
            List<ref_count_ptr<StgIntersectionTarget>.unsync > res = new List<ref_count_ptr<StgIntersectionTarget>.unsync >();
            if (delay_ > 0)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            if (frameFadeDelete_ >= 0)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            if (IsDeleted())
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            if (bUserIntersectionMode_)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res); // ���[�U��`�����蔻�胂�[�h
            }
            if (!bIntersectionEnable_)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }

            StgShotData shotData = _GetShotData();
            if (shotData == null)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            if (scaleX_ < 1.0 && typeOwner_ != OWNER_PLAYER)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }

            // �����蔻��
            int posXS = (int)posX_ + invalidLengthStart_ * System.Math.Cos(Math.DegreeToRadian(angLaser_));
            int posYS = (int)posY_ + invalidLengthStart_ * System.Math.Sin(Math.DegreeToRadian(angLaser_));
            int length = System.Math.Max((length_ - invalidLengthEnd_), 0);
            int posXE = (int)posX_ + (int)(length * System.Math.Cos(Math.DegreeToRadian(angLaser_)));
            int posYE = (int)posY_ + (int)(length * System.Math.Sin(Math.DegreeToRadian(angLaser_)));

            StgIntersectionManager intersectionManager = stageController_.GetIntersectionManager();
            DxWidthLine line = new DxWidthLine(posXS, posYS, posXE, posYE, widthIntersection_);
            ref_count_ptr<StgShotObject>.unsync obj = GetOwnObject();
            if (obj == null)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }

            ref_count_weak_ptr<StgShotObject>.unsync wObj = obj;
            ref_count_ptr<StgIntersectionTarget_Line>.unsync target = new ref_count_ptr<StgIntersectionTarget_Line>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_LINE));
            if (typeOwner_ == OWNER_PLAYER)
            {
                target.SetTargetType(StgIntersectionTarget.TYPE_PLAYER_SHOT);
            }
            else
            {
                target.SetTargetType(StgIntersectionTarget.TYPE_ENEMY_SHOT);
            }
            target.SetObject(wObj);
            target.SetLine(line);

            res.Add(target);
            return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
        }

        public double GetLaserAngle()
        {
            return angLaser_;
        }
        public void SetLaserAngle(double angle)
        {
            angLaser_ = angle;
        }
        public new void SetFadeDelete()
        {
            if (frameFadeDelete_ < 0)
            {
                frameFadeDelete_ = FRAME_FADEDELETE_LASER;
            }
        }
        public void SetSourceEnable(bool bEnable)
        {
            bUseSouce_ = bEnable;
        }

}

/**********************************************************
//StgCurveLaserObject(�Ȃ���^���[�U�[)
**********************************************************/
public class StgCurveLaserObject : StgLaserObject
{
        protected class Position
        {
            public double x;
            public double y;
        }

        protected LinkedList<Position> listPosition_ = new LinkedList<Position>();
        protected double tipDecrement_;

        protected override void _DeleteInAutoClip()
        {
            if (IsDeleted())
            {
                return;
            }
            if (!IsAutoDelete())
            {
                return;
            }
            StgShotManager shotManager = stageController_.GetShotManager();
            RECT rect = shotManager.GetShotAutoDeleteClipRect();

            bool bDelete = listPosition_.Count > 0;
            LinkedList<Position>.Enumerator itr = listPosition_.GetEnumerator();
            while (itr.MoveNext())
            {
                Position pos = itr.Current;
                bool bXOut = pos.x < rect.left || pos.x > rect.right;
                bool bYOut = pos.y < rect.top || pos.y > rect.bottom;
                if (!bXOut && !bYOut)
                {
                    bDelete = false;
                    break;
                }
            }

            if (bDelete)
            {
                ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
                objectManager.DeleteObject(idObject_);
            }

        }

        protected override void _Move()
        {
            base._Move();
            DxScriptRenderObject.SetX(posX_);
            DxScriptRenderObject.SetY(posY_);

            Position pos = new Position();
            pos.x = posX_;
            pos.y = posY_;

            listPosition_.AddFirst(pos);
            if (listPosition_.Count > length_)
            {
                listPosition_.RemoveLast();
            }
        }

        protected override void _ConvertToItemAndSendEvent()
        {
            StgItemManager itemManager = stageController_.GetItemManager();
            StgStageScriptManager stageScriptManager = stageController_.GetScriptManagerP();
            ref_count_ptr<ManagedScript> scriptItem = stageScriptManager.GetItemScript();

            LinkedList<Position>.Enumerator itr = listPosition_.GetEnumerator();
            while (itr.MoveNext())
            {
                Position pos = itr.Current;
                double posX = pos.x;
                double posY = pos.y;

                if (scriptItem != null)
                {
                    List<double> listPos = new List<double>();
                    listPos.Add(posX);
                    listPos.Add(posY);

                    List<gstd.value> listScriptValue = new List<gstd.value>();
                    listScriptValue.Add(scriptItem.CreateRealValue(idObject_));
                    listScriptValue.Add(scriptItem.CreateRealArrayValue(listPos));
                    scriptItem.RequestEvent(StgStageScript.EV_DELETE_SHOT_TO_ITEM, listScriptValue);
                }

                if (itemManager.IsDefaultBonusItemEnable() && delay_ == 0)
                {
                    ref_count_ptr<StgItemObject>.unsync obj = new StgItemObject_Bonus(stageController_);
                    int id = stageController_.GetMainObjectManager().AddObject(obj);
                    if (id != DxScript.ID_INVALID)
                    {
                        // �e�̍��W�ɃA�C�e����쐬����
                        itemManager.AddItem(new ref_count_ptr<StgItemObject>.unsync(obj));
                        obj.SetPositionX(posX);
                        obj.SetPositionY(posY);
                    }

                }
            }
        }

        /**********************************************************
        //StgCurveLaserObject(�Ȃ���^���[�U�[)
        **********************************************************/
        public StgCurveLaserObject(StgStageController stageController) : base(stageController)
        {
            typeObject_ = StgStageScript.OBJ_CURVE_LASER;
            tipDecrement_ = 1.0;
        }

        public override void Work()
        {
            _Move();
            if (delay_ == 0)
            {
                _AddReservedShotWork();
            }

            delay_ = System.Math.Max(delay_ - 1, 0);
            frameWork_++;

            if (frameFadeDelete_ >= 0)
            {
                frameFadeDelete_--;
            }

            _DeleteInAutoClip();
            _DeleteInLife();
            _DeleteInFadeDelete();
            _DeleteInAutoDeleteFrame();
        // 	_AddIntersectionRelativeTarget();
            frameGrazeInvalid_--;
        }

        public override void RenderOnShotManager(D3DXMATRIX mat)
        {
            if (!IsVisible())
            {
                return;
            }

            StgShotData shotData = _GetShotData();
            if (shotData == null)
            {
                return;
            }

            int shotBlendType = (int)StgShotDataList.AnonymousEnum3.RENDER_ADD_ARGB;
            StgShotRenderer renderer = null;
            if (delay_ > 0)
            {
                // �x������
                int objDelayBlendType = GetSourceBlendType();
                if (objDelayBlendType == DirectGraphics.MODE_BLEND_NONE)
                {
                    renderer = shotData.GetRenderer((int)StgShotDataList.AnonymousEnum3.RENDER_ADD_ARGB);
                    shotBlendType = DirectGraphics.MODE_BLEND_ADD_ARGB;
                }
                else
                {
                    renderer = shotData.GetRendererFromGraphicsBlendType(objDelayBlendType);
                }
            }
            else
            {
                int objBlendType = GetBlendType();
                int shotBlendType = objBlendType;
                if (objBlendType == DirectGraphics.MODE_BLEND_NONE)
                {
                    renderer = shotData.GetRenderer((int)StgShotDataList.AnonymousEnum3.RENDER_ADD_ARGB);
                    shotBlendType = DirectGraphics.MODE_BLEND_ADD_ARGB;
                }
                else
                {
                    renderer = shotData.GetRendererFromGraphicsBlendType(objBlendType);
                }
            }
            if (renderer == null)
            {
                return;
            }

            D3DXMATRIX matScale = new D3DXMATRIX();
            D3DXMATRIX matRot = new D3DXMATRIX();
            D3DXMATRIX matTrans = new D3DXMATRIX();
            D3DCOLOR color = new D3DCOLOR();

            List<RECT_D> listRcSrc = new List<RECT_D>();
            List<RECT_D> listRcDest = new List<RECT_D>();
            List<D3DXMATRIX> listMatrix = new List<D3DXMATRIX>();
            if (delay_ > 0)
            {
                RECT rcSrc = shotData.GetDelayRect();
                RECT rcDest = new RECT();

                // �x������
                double expa = 0.5f + (double)delay_ / 30.0f * 2;
                if (expa > 3.5)
                {
                    expa = 3.5;
                }

                D3DXMatrixScaling(matScale, expa, expa, 1.0f);
                D3DXMatrixRotationYawPitchRoll(matRot, 0, 0, D3DXToRadian(GetDirectionAngle() + 90));
                D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
                D3DXMATRIX tMat = matScale * matRot * matTrans * mat;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = shotData->GetDelayColor();
                color.CopyFrom(shotData.GetDelayColor());

                int width = rcSrc.right - rcSrc.left;
                int height = rcSrc.bottom - rcSrc.top;
                SetRect(rcDest, -width / 2, -height / 2, width / 2, height / 2);
                if (width % 2 == 1)
                {
                    rcDest.right += 1;
                }
                if (height % 2 == 1)
                {
                    rcDest.bottom += 1;
                }

                RECT_D rcSrcD = directx.GlobalMembers.GetRectD(rcSrc);
                RECT_D rcDestD = directx.GlobalMembers.GetRectD(rcDest);
                listRcSrc.Add(rcSrcD);
                listRcDest.Add(rcDestD);
                listMatrix.Add(tMat);
            }
            else
            {
                List<Position> listPos = new List<Position>();
                LinkedList<Position>.Enumerator itr = listPosition_.GetEnumerator();
                while (itr.MoveNext())
                {
                    listPos.push_backitr.Current;
                }

                int countPos = listPos.Count;
                RECT rcSrcOrg = shotData.GetRect(frameWork_);
                double rate = (double)(rcSrcOrg.bottom - rcSrcOrg.top) / (double)System.Math.Max(countPos, 1);

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = color_;
                color.CopyFrom(color_);
                double alpha = shotData.GetAlpha() / 255.0;
                if (frameFadeDelete_ >= 0)
                {
                    alpha = (double)frameFadeDelete_ / (double)FRAME_FADEDELETE;
                }

                bool bValidAlpha = StgShotData.IsAlphaBlendValidType(shotBlendType);
                if (bValidAlpha)
                {
                    // ���L��
                    int colorA = ColorAccess.GetColorA(color);
                    color = ColorAccess.SetColorA(color, alpha * colorA);
                }
                else
                {
                    // ������
                    color = ColorAccess.ApplyAlpha(color, alpha);
                }

                RECT_D rcSrcD = directx.GlobalMembers.GetRectD(rcSrcOrg);
                rcSrcD.bottom = rcSrcD.top;
                double posSrc = 0;
                for (int iPos = 0 ; iPos < countPos - 1; iPos++)
                {
                    double posXS = listPos[iPos].x;
                    double posYS = listPos[iPos].y;
                    double posXE = listPos[iPos + 1].x;
                    double posYE = listPos[iPos + 1].y;
                    double ang = System.Math.Atan2(posYE - posYS, posXE - posXS);

                    RECT_D rcDestD = new RECT_D();
                    D3DXMatrixScaling(matScale, 1.0f, 1.0f, 1.0f);
                    D3DXMatrixRotationYawPitchRoll(matRot, 0, 0, ang + D3DXToRadian(90));
                    D3DXMatrixTranslation(matTrans, posXS, posYS, position_.z);
                    D3DXMATRIX tMat = matScale * matRot * matTrans * mat;

                    rcSrcD.top = rcSrcOrg.top + posSrc;
                    double bottom = rcSrcD.top + rate;
                    if (rcSrcD.top == bottom)
                    {
                        bottom = bottom + 1;
                    }
                    rcSrcD.bottom = bottom;
                    posSrc += rate;

                    double radius = System.Math.Pow(System.Math.Pow(posXE - posXS,2) + System.Math.Pow(posYE - posYS,2), 0.5);
                    directx.GlobalMembers.SetRectD(rcDestD, -widthRender_ / 2, radius, widthRender_ / 2, 0);

                    listRcSrc.Add(rcSrcD);
                    listRcDest.Add(rcDestD);
                    listMatrix.Add(tMat);
                }

            }


            int countRect = listRcSrc.Count;
            double tAlpha = ColorAccess.GetColorA(color);
            double dAlpha = tAlpha / (double)listRcSrc.Count * 2.0 * tipDecrement_;
            VERTEX_TLX[] oldVerts = Arrays.InitializeWithDefaultInstances<VERTEX_TLX>(4);
            for (int iRect = 0 ; iRect < countRect ; iRect++)
            {
                if (iRect > countRect / 2)
                {
                    tAlpha -= dAlpha;
                }
                if (iRect < listRcSrc.Count / 2)
                {
                    tAlpha = iRect * 256 / (listRcSrc.Count / 2) + (255 - tipDecrement_ * 255.0);
                }
                tAlpha = System.Math.Max(0, tAlpha);

                D3DCOLOR tColor = new D3DCOLOR(color);
                bool bValidAlpha = StgShotData.IsAlphaBlendValidType(shotBlendType);
                if (bValidAlpha)
                {
                    // ���L��
                    int colorA = ColorAccess.GetColorA(tColor);
                    tColor = ColorAccess.SetColorA(tColor, tAlpha * colorA);
                }
                else
                {
                    // ������
                    tColor = ColorAccess.ApplyAlpha(tColor, tAlpha / 255.0);
                }


                RECT_D rcSrc = listRcSrc[iRect];
                RECT_D rcDest = listRcDest[iRect];
                D3DXMATRIX tMat = listMatrix[iRect];

                VERTEX_TLX[] verts = Arrays.InitializeWithDefaultInstances<VERTEX_TLX>(4);
                double[] srcX = { rcSrc.left, rcSrc.right, rcSrc.left, rcSrc.right };
                double[] srcY = { rcSrc.top, rcSrc.top, rcSrc.bottom, rcSrc.bottom };
                double[] destX = { rcDest.left, rcDest.right, rcDest.left, rcDest.right };
                double[] destY = { rcDest.top, rcDest.top, rcDest.bottom, rcDest.bottom };
                for (int iVert = 0 ;iVert < 4 ; iVert++)
                {
                    _SetVertexUV(verts[iVert], srcX[iVert], srcY[iVert]);
                    _SetVertexPosition(verts[iVert], destX[iVert], destY[iVert]);
                    _SetVertexColorARGB(verts[iVert], new D3DCOLOR(tColor));
                    verts[iVert].position = DxMath.VectMatMulti(verts[iVert].position, tMat);
                }

                if (iRect > 0)
                {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: verts[0] = oldVerts[2];
                    verts[0].CopyFrom(oldVerts[2]);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: verts[1] = oldVerts[3];
                    verts[1].CopyFrom(oldVerts[3]);
                }
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(oldVerts, verts, sizeof(VERTEX_TLX) * 4);

                renderer.AddVertex(verts[0]);
                renderer.AddVertex(verts[2]);
                renderer.AddVertex(verts[1]);
                renderer.AddVertex(verts[1]);
                renderer.AddVertex(verts[2]);
                renderer.AddVertex(verts[3]);
            }

        }

        public override void RegistIntersectionTarget()
        {
            if (!bUserIntersectionMode_)
            {
                _AddIntersectionRelativeTarget();
            }
        }

        public override List<ref_count_ptr<StgIntersectionTarget>.unsync > GetIntersectionTargetList()
        {
            List<ref_count_ptr<StgIntersectionTarget>.unsync > res = new List<ref_count_ptr<StgIntersectionTarget>.unsync >();
            if (delay_ > 0)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            if (frameFadeDelete_ >= 0)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            if (IsDeleted())
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            if (bUserIntersectionMode_)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res); // ���[�U��`�����蔻�胂�[�h
            }
            if (!bIntersectionEnable_)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }

            StgShotData shotData = _GetShotData();
            if (shotData == null)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }

            ref_count_ptr<StgShotObject>.unsync obj = GetOwnObject();
            if (obj == null)
            {
                return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
            }
            ref_count_weak_ptr<StgShotObject>.unsync wObj = obj;

            // �����蔻��
            List<Position> listPos = new List<Position>();
            LinkedList<Position>.Enumerator itr = listPosition_.GetEnumerator();
            while (itr.MoveNext())
            {
                listPos.push_backitr.Current;
            }

            StgIntersectionManager intersectionManager = stageController_.GetIntersectionManager();
            int countPos = listPos.Count;
            for (int iPos = 0 ; iPos < countPos - 1; iPos++)
            {
                double posXS = listPos[iPos].x;
                double posYS = listPos[iPos].y;
                double posXE = listPos[iPos + 1].x;
                double posYE = listPos[iPos + 1].y;
        /*
        		if(iPos == 0)
        		{
        			double ang = atan2(posYE - posYS, posXE - posXS);
        			int length = min(0 , invalidLengthStart_);
        			posXS = posXS + length * cos(ang);
        			posYS = posYS + length * sin(ang);
        		}
        		if(iPos == countPos - 2)
        		{
        			double ang = atan2(posYE - posYS, posXE - posXS);
        			int length = max(invalidLengthEnd_, 0);
        			posXE = posXE - length * cos(ang);
        			posYE = posYE - length * sin(ang);
        		}
        */
                DxWidthLine line = new DxWidthLine(posXS, posYS, posXE, posYE, widthIntersection_);
                ref_count_ptr<StgIntersectionTarget_Line>.unsync target = new ref_count_ptr<StgIntersectionTarget_Line>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_LINE));
                if (typeOwner_ == OWNER_PLAYER)
                {
                    target.SetTargetType(StgIntersectionTarget.TYPE_PLAYER_SHOT);
                }
                else
                {
                    target.SetTargetType(StgIntersectionTarget.TYPE_ENEMY_SHOT);
                }
                target.SetObject(wObj);
                target.SetLine(line);

                res.Add(target);
            }
            return new List<ref_count_ptr<StgIntersectionTarget>.unsync >(res);
        }

        public void SetTipDecrement(double dec)
        {
            tipDecrement_ = dec;
        }
}
