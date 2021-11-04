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
// class StgItemDataList;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgItemObject;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgItemData;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgItemRenderer;
/**********************************************************
//StgItemManager
**********************************************************/
public class StgItemManager : System.IDisposable
{
        private StgStageController stageController_;
        private ref_count_ptr<SpriteList2D>.unsync listSpriteItem_ = new ref_count_ptr<SpriteList2D>.unsync();
        private ref_count_ptr<SpriteList2D>.unsync listSpriteDigit_ = new ref_count_ptr<SpriteList2D>.unsync();
        private ref_count_ptr<StgItemDataList>.unsync listItemData_ = new ref_count_ptr<StgItemDataList>.unsync();

        private LinkedList<ref_count_ptr<StgItemObject>.unsync > listObj_ = new LinkedList<ref_count_ptr<StgItemObject>.unsync >();
        private SortedSet<int> listItemTypeToPlayer_ = new SortedSet<int>();
        private LinkedList<DxCircle> listCircleToPlayer_ = new LinkedList<DxCircle>();
        private bool bAllItemToPlayer_;
        private bool bCancelToPlayer_;
        private bool bDefaultBonusItemEnable_;



        /**********************************************************
        //StgItemManager
        **********************************************************/
        public StgItemManager(StgStageController stageController)
        {
            stageController_ = stageController;
            listItemData_ = new StgItemDataList();

            string dir = EPathProperty.GetSystemImageDirectory();

            listSpriteItem_ = new SpriteList2D();
            string pathItem = dir + "System_Stg_Item.png";
            ref_count_ptr<Texture> textureItem = new Texture();
            textureItem.CreateFromFile(pathItem);
            listSpriteItem_.SetTexture(textureItem);

            listSpriteDigit_ = new SpriteList2D();
            string pathDigit = dir + "System_Stg_Digit.png";
            ref_count_ptr<Texture> textureDigit = new Texture();
            textureDigit.CreateFromFile(pathDigit);
            listSpriteDigit_.SetTexture(textureDigit);

            bDefaultBonusItemEnable_ = true;
            bAllItemToPlayer_ = false;

        }

        public virtual void Dispose()
        {
        }

        public void Work()
        {
            ref_count_ptr<StgPlayerObject>.unsync objPlayer = stageController_.GetPlayerObject();
            double px = objPlayer.GetX();
            double py = objPlayer.GetY();
            double pr = objPlayer.GetItemIntersectionRadius();
            int pAutoItemCollectY = objPlayer.GetAutoItemCollectY();

            LinkedList<ref_count_ptr<StgItemObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgItemObject>.unsync obj = itr.Current;
                if (obj.IsDeleted())
                {
                    // obj->Clear();
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                    itr = listObj_.erase(itr);
                }
                else
                {
                    double ix = obj.GetPositionX();
                    double iy = obj.GetPositionY();
                    if (objPlayer.GetState() == StgPlayerObject.STATE_NORMAL)
                    {
                        double radius = System.Math.Pow(System.Math.Pow(px - ix, 2) + System.Math.Pow(py - iy, 2), 0.5);
                        if (radius <= pr)
                        {
                            obj.Intersect(null, null);
                        }

                        if (bCancelToPlayer_)
                        {
                            // ��������L�����Z��
                            obj.SetMoveToPlayer(false);
                        }
                        else if (obj.IsPermitMoveToPlayer())
                        {
                            bool bMoveToPlayer = false;
                            if (pAutoItemCollectY >= 0)
                            {
                                // �㕔�������
                                int typeMove = obj.GetMoveType();
                                if (!obj.IsMoveToPlayer() && py <= pAutoItemCollectY)
                                {
                                    bMoveToPlayer = true;
                                }
                            }

                            if (listItemTypeToPlayer_.Count > 0)
                            {
                                // ���@�ɃA�C�e����W�߂�
                                int typeItem = obj.GetItemType();
                                bool bFind = listItemTypeToPlayer_.find(typeItem) != listItemTypeToPlayer_.end();
                                if (bFind)
                                {
                                    bMoveToPlayer = true;
                                }
                            }

                            if (listCircleToPlayer_.Count > 0)
                            {
                                LinkedList<DxCircle>.Enumerator itr = listCircleToPlayer_.GetEnumerator();
                                while (itr.MoveNext())
                                {
                                    DxCircle circle = itr.Current;
                                    double cr = System.Math.Pow(System.Math.Pow(ix - circle.GetX(), 2) + System.Math.Pow(iy - circle.GetY(), 2), 0.5);
                                    if (cr <= circle.GetR())
                                    {
                                        bMoveToPlayer = true;
                                        break;
                                    }
                                }
                            }

                            if (bAllItemToPlayer_)
                            {
                                bMoveToPlayer = true;
                            }

                            if (bMoveToPlayer)
                            {
                                obj.SetMoveToPlayer(true);
                            }
                        }

                    }
                    else
                    {
                        obj.SetMoveToPlayer(false);
                    }

                }
            }
            listItemTypeToPlayer_.Clear();
            listCircleToPlayer_.Clear();
            bAllItemToPlayer_ = false;
            bCancelToPlayer_ = false;

        }

        public void Render(int targetPriority)
        {
            DirectGraphics graphics = DirectGraphics.GetBase();
            graphics.SetZBufferEnable(false);
            graphics.SetZWriteEnalbe(false);
            graphics.SetCullingMode(D3DCULL_NONE);
            graphics.SetLightingEnable(false);

            // �t�H�O��������
            uint bEnableFog = false;
            graphics.GetDevice().GetRenderState(D3DRS_FOGENABLE, bEnableFog);
            if (bEnableFog != 0)
            {
                graphics.SetFogEnable(false);
            }

            // �g�嗦�Ȃǌv�Z
            DxCamera2D camera = graphics.GetCamera2D().GetPointer();
            D3DXMATRIX matCamera = camera.GetMatrix();

            LinkedList<ref_count_ptr<StgItemObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgItemObject>.unsync obj = itr.Current;
                if (obj.IsDeleted())
                {
                    continue;
                }
                if (obj.GetRenderPriorityI() != targetPriority)
                {
                    continue;
                }

                obj.RenderOnItemManager(matCamera);
            }

            int countBlendType = (int)StgItemDataList.AnonymousEnum.RENDER_TYPE_COUNT;
            int[] blendMode = { DirectGraphics.MODE_BLEND_ADD_ARGB, DirectGraphics.MODE_BLEND_ADD_RGB, DirectGraphics.MODE_BLEND_ALPHA };
            int[] typeRender = { StgShotDataList.RENDER_ADD_ARGB, StgShotDataList.RENDER_ADD_RGB, StgShotDataList.RENDER_ALPHA };
            ref_count_ptr<SpriteList2D>.unsync[] listSprite = { listSpriteDigit_, listSpriteItem_ };
            for (int iBlend = 0 ; iBlend < countBlendType ; iBlend++)
            {
                graphics.SetBlendMode(blendMode[iBlend]);
                if (blendMode[iBlend] == DirectGraphics.MODE_BLEND_ADD_ARGB)
                {
                    listSpriteDigit_.Render();
                    listSpriteDigit_.ClearVertexCount();
                }
                else if (blendMode[iBlend] == DirectGraphics.MODE_BLEND_ALPHA)
                {
                    listSpriteItem_.Render();
                    listSpriteItem_.ClearVertexCount();
                }

                List<ref_count_ptr<StgItemRenderer>.unsync > listRenderer = listItemData_.GetRendererList(typeRender[iBlend]);
                int iRender = 0;
                for (iRender = 0 ; iRender < listRenderer.Count ; iRender++)
                {
                    (listRenderer[iRender]).Render();
                }
            }

            if (bEnableFog != 0)
            {
                graphics.SetFogEnable(true);
            }
        }

        public void AddItem(ref_count_ptr<StgItemObject>.unsync obj)
        {
            listObj_.AddLast(obj);
        }
        public int GetItemCount()
        {
            return listObj_.Count;
        }

        public SpriteList2D GetItemRenderer()
        {
            return listSpriteItem_.GetPointer();
        }
        public SpriteList2D GetDigitRenderer()
        {
            return listSpriteDigit_.GetPointer();
        }
        public List<bool> GetValidRenderPriorityList()
        {
            List<bool> res = new List<bool>();
            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            res.Resize(objectManager.GetRenderBucketCapacity());

            LinkedList<ref_count_ptr<StgItemObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgItemObject>.unsync obj = itr.Current;
                if (obj.IsDeleted())
                {
                    continue;
                }

                int pri = obj.GetRenderPriorityI();
                res[pri] = true;
            }

            return new List<bool>(res);
        }

        public StgItemDataList GetItemDataList()
        {
            return listItemData_.GetPointer();
        }
        public bool LoadItemData(string path, bool bReload = false)
        {
            return listItemData_.AddItemDataList(path, bReload);
        }

        public ref_count_ptr<StgItemObject>.unsync CreateItem(int type)
        {
            ref_count_ptr<StgItemObject>.unsync res = new ref_count_ptr<StgItemObject>.unsync();
            switch (type)
            {
            case StgItemObject.AnonymousEnum2.ITEM_1UP:
            case StgItemObject.AnonymousEnum2.ITEM_1UP_S:
                res = new StgItemObject_1UP(stageController_);
                break;
            case StgItemObject.AnonymousEnum2.ITEM_SPELL:
            case StgItemObject.AnonymousEnum2.ITEM_SPELL_S:
                res = new StgItemObject_Bomb(stageController_);
                break;
            case StgItemObject.AnonymousEnum2.ITEM_POWER:
            case StgItemObject.AnonymousEnum2.ITEM_POWER_S:
                res = new StgItemObject_Power(stageController_);
                break;
            case StgItemObject.AnonymousEnum2.ITEM_POINT:
            case StgItemObject.AnonymousEnum2.ITEM_POINT_S:
                res = new StgItemObject_Point(stageController_);
                break;
            case StgItemObject.AnonymousEnum2.ITEM_USER:
                res = new StgItemObject_User(stageController_);
                break;
            }
            res.SetItemType(type);

            return new ref_count_ptr<StgItemObject>.unsync(res);
        }

        public void CollectItemsAll()
        {
            bAllItemToPlayer_ = true;
        }

        public void CollectItemsByType(int type)
        {
            listItemTypeToPlayer_.Add(type);
        }

        public void CollectItemsInCircle(DxCircle circle)
        {
            listCircleToPlayer_.AddLast(circle);
        }

        public void CancelCollectItems()
        {
            bCancelToPlayer_ = true;
        }

        public bool IsDefaultBonusItemEnable()
        {
            return bDefaultBonusItemEnable_;
        }
        public void SetDefaultBonusItemEnable(bool bEnable)
        {
            bDefaultBonusItemEnable_ = bEnable;
        }
}

/**********************************************************
//StgItemDataList
**********************************************************/
public class StgItemDataList : System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            RENDER_TYPE_COUNT = 3,
            RENDER_ALPHA = 0,
            RENDER_ADD_RGB,
            RENDER_ADD_ARGB
        }
        private SortedSet<string> listReadPath_ = new SortedSet<string>();
        private List<ref_count_ptr<Texture>> listTexture_ = new List<ref_count_ptr<Texture>>();
        private List<List<ref_count_ptr<StgItemRenderer>.unsync >> listRenderer_ = new List<List<ref_count_ptr<StgItemRenderer>.unsync >>();
        private List<ref_count_ptr<StgItemData>.unsync > listData_ = new List<ref_count_ptr<StgItemData>.unsync >();

        private void _ScanItem(List<ref_count_ptr<StgItemData>.unsync > listData, Scanner scanner)
        {
            Token tok = scanner.Next();
            if (tok.GetType() == Token.TK_NEWLINE)
            {
                tok = scanner.Next();
            }
            scanner.CheckType(tok, Token.TK_OPENC);

            ref_count_ptr<StgItemData>.unsync data = new StgItemData(this);
            int id = -1;
            int typeItem = -1;

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
                    else if (element == "type")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        typeItem = scanner.Next().GetInteger();
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
                    else if (element == "out")
                    {
                        List<string> list = _GetArgumentList(scanner);
                        RECT rect = new RECT();
                        rect.left = StringUtility.ToInteger(list[0]);
                        rect.top = StringUtility.ToInteger(list[1]);
                        rect.right = StringUtility.ToInteger(list[2]);
                        rect.bottom = StringUtility.ToInteger(list[3]);
                        data.rcOut_ = rect;
                    }
                    else if (element == "render")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        string render = scanner.Next().GetElement();
                        if (render == "ADD" || render == "ADD_RGB")
                        {
                            data.typeRender_ = DirectGraphics.MODE_BLEND_ADD_RGB;
                        }
                        else if (render == "ADD_ARGB")
                        {
                            data.typeRender_ = DirectGraphics.MODE_BLEND_ADD_ARGB;
                        }
                    }
                    else if (element == "alpha")
                    {
                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                        data.alpha_ = scanner.Next().GetInteger();
                    }
                    else if (element == "AnimationData")
                    {
                        _ScanAnimation(new ref_count_ptr<StgItemData>.unsync(data), scanner);
                    }
                }
            }

            if (id >= 0)
            {
                if (listData.Count <= id)
                {
                    listData.Resize(id + 1);
                }

                if (typeItem < 0)
                {
                    typeItem = id;
                }
                data.typeItem_ = typeItem;

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: listData[id] = data;
                listData[id].CopyFrom(data);
            }
        }

        private void _ScanAnimation(ref_count_ptr<StgItemData>.unsync itemData, Scanner scanner)
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
                            StgItemData.AnimationData anime = new StgItemData.AnimationData();
                            int frame = StringUtility.ToInteger(list[0]);
                            RECT rcSrc = new RECT(StringUtility.ToInteger(list[1]), StringUtility.ToInteger(list[2]), StringUtility.ToInteger(list[3]), StringUtility.ToInteger(list[4]));

                            anime.frame_ = frame;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: anime.rcSrc_ = rcSrc;
                            anime.rcSrc_.CopyFrom(rcSrc);

                            itemData.listAnime_.push_back(anime);
                            itemData.totalAnimeFrame_ += frame;
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
        //StgItemDataList
        **********************************************************/
        public StgItemDataList()
        {
            listRenderer_.Resize(AnonymousEnum.RENDER_TYPE_COUNT);
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
        public ref_count_ptr<StgItemRenderer>.unsync GetRenderer(int index, int typeRender)
        {
            return new ref_count_ptr<StgItemRenderer>.unsync(listRenderer_[typeRender][index]);
        }
        public List<ref_count_ptr<StgItemRenderer>.unsync > GetRendererList(int typeRender)
        {
            return new List<ref_count_ptr<StgItemRenderer>.unsync >(listRenderer_[typeRender]);
        }

        public ref_count_ptr<StgItemData>.unsync GetData(int id)
        {
            return (id >= 0 && id < listData_.Count) ? listData_[id] : null;
        }

        public bool AddItemDataList(string path, bool bReload)
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
                List<ref_count_ptr<StgItemData>.unsync > listData = new List<ref_count_ptr<StgItemData>.unsync >();
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
                        if (element == "ItemData")
                        {
                            _ScanItem(listData, scanner);
                        }
                        else if (element == "item_image")
                        {
                            scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                            pathImage = scanner.Next().GetString();
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
                        ref_count_ptr<StgItemRenderer>.unsync render = new StgItemRenderer();
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
                    ref_count_ptr<StgItemData>.unsync data = listData[iData];
                    if (data == null)
                    {
                        continue;
                    }
                    data.indexTexture_ = textureIndex;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: listData_[iData] = data;
                    listData_[iData].CopyFrom(data);
                }

                listReadPath_.Add(path);
                Logger.WriteTop(StringUtility.Format("�A�C�e���f�[�^��ǂݍ��݂܂���:%s", path));
                res = true;
            }
            catch (gstd.wexception e)
            {
                string log = StringUtility.Format("�A�C�e���f�[�^�ǂݍ��ݎ��s:%d�s��(%s)", scanner.GetCurrentLine(), e.what());
                Logger.WriteTop(log);
                res = null;
            }
            catch
            {
                string log = StringUtility.Format("�A�C�e���f�[�^�ǂݍ��ݎ��s:%d�s��", scanner.GetCurrentLine());
                Logger.WriteTop(log);
                res = null;
            }

            return res;
        }
}

public class StgItemData : System.IDisposable
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//    friend StgItemDataList;
        private class AnimationData
        {
            public RECT rcSrc_ = new RECT();
            public int frame_;
        }

        private StgItemDataList listItemData_;
        private int indexTexture_;

        private int typeItem_;
        private int typeRender_;
        private RECT rcSrc_ = new RECT();
        private RECT rcOut_ = new RECT();
        private int alpha_;

        private List<AnimationData> listAnime_ = new List<AnimationData>();
        private int totalAnimeFrame_;


        // StgItemData
        public StgItemData(StgItemDataList listItemData)
        {
            listItemData_ = listItemData;
            typeRender_ = DirectGraphics.MODE_BLEND_ALPHA;
            SetRect(rcSrc_, 0, 0, 0, 0);
            SetRect(rcOut_, 0, 0, 0, 0);
            alpha_ = 255;
            totalAnimeFrame_ = 0;
        }

        public virtual void Dispose()
        {
        }

        public int GetTextureIndex()
        {
            return indexTexture_;
        }
        public int GetItemType()
        {
            return typeItem_;
        }
        public int GetRenderType()
        {
            return typeRender_;
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

        public RECT GetOut()
        {
            return new RECT(rcOut_);
        }
        public int GetAlpha()
        {
            return alpha_;
        }

        public ref_count_ptr<Texture> GetTexture()
        {
            ref_count_ptr<Texture> res = listItemData_.GetTexture(indexTexture_);
            return new ref_count_ptr<Texture>(res);
        }

        public StgItemRenderer GetRenderer()
        {
            StgItemRenderer res = null;
            if (typeRender_ == DirectGraphics.MODE_BLEND_ALPHA)
            {
                res = listItemData_.GetRenderer(indexTexture_, (int)StgItemDataList.AnonymousEnum.RENDER_ALPHA).GetPointer();
            }
            else if (typeRender_ == DirectGraphics.MODE_BLEND_ADD_RGB)
            {
                res = listItemData_.GetRenderer(indexTexture_, (int)StgItemDataList.AnonymousEnum.RENDER_ADD_RGB).GetPointer();
            }
            else if (typeRender_ == DirectGraphics.MODE_BLEND_ADD_ARGB)
            {
                res = listItemData_.GetRenderer(indexTexture_, (int)StgItemDataList.AnonymousEnum.RENDER_ADD_ARGB).GetPointer();
            }
            return res;
        }

        public StgItemRenderer GetRenderer(int type)
        {
            return listItemData_.GetRenderer(indexTexture_, type).GetPointer();
        }
}

/**********************************************************
//StgItemRenderer
**********************************************************/
public class StgItemRenderer : RenderObjectTLX
{
        private int countRenderVertex_;

        /**********************************************************
        //StgItemRenderer
        **********************************************************/
        public StgItemRenderer()
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
//StgItemObject
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public abstract class StgItemObject : DxScriptRenderObject, StgMoveObject, StgIntersectionObject
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum2
        {
            ITEM_1UP = -256 * 256,
            ITEM_1UP_S,
            ITEM_SPELL,
            ITEM_SPELL_S,
            ITEM_POWER,
            ITEM_POWER_S,
            ITEM_POINT,
            ITEM_POINT_S,

            ITEM_SCORE,
            ITEM_BONUS,

            ITEM_USER = 0
        }
        protected StgStageController stageController_;
        protected int typeItem_;
        protected D3DCOLOR color_ = new D3DCOLOR();

        protected _int64 score_ = new _int64();
        protected bool bMoveToPlayer_; // ���@�ړ��t���O
        protected bool bPermitMoveToPlayer_; // ���@�����������
        protected bool bChangeItemScore_;

        protected void _DeleteInAutoClip()
        {
            DirectGraphics graphics = DirectGraphics.GetBase();

            RECT rcClip = new RECT();
            ZeroMemory(rcClip, sizeof(RECT));
            rcClip.left = -64;
            rcClip.right = graphics.GetScreenWidth() + 64;
            rcClip.bottom = graphics.GetScreenHeight() + 64;
            bool bDelete = (posX_ < rcClip.left || posX_ > rcClip.right || posY_ > rcClip.bottom);
            if (!bDelete)
            {
                return;
            }

            stageController_.GetMainObjectManager().DeleteObject(GetObjectID());
        }

        protected void _CreateScoreItem()
        {
            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            StgItemManager itemManager = stageController_.GetItemManager();
            ref_count_ptr<StgItemObject_Score>.unsync obj = new StgItemObject_Score(stageController_);
            obj.SetX(posX_);
            obj.SetY(posY_);
            obj.SetScore(score_);
            objectManager.AddObject(obj);
            itemManager.AddItem(new ref_count_ptr<StgItemObject_Score>.unsync(obj));
        }

        protected void _NotifyEventToPlayerScript(List<double> listValue)
        {
            // ���@�X�N���v�g�֒ʒm
            ref_count_ptr<StgPlayerObject>.unsync player = stageController_.GetPlayerObject();
            StgStagePlayerScript scriptPlayer = player.GetPlayerScript();
            List<gstd.value> listScriptValue = new List<gstd.value>();
            for (int iVal = 0 ; iVal < listValue.Count ; iVal++)
            {
                listScriptValue.Add(scriptPlayer.CreateRealValue(listValue[iVal]));
            }

            scriptPlayer.RequestEvent(StgStageItemScript.EV_GET_ITEM, listScriptValue);
        }

        protected void _NotifyEventToItemScript(List<double> listValue)
        {
            // �A�C�e���X�N���v�g�֒ʒm
            StgStageScriptManager stageScriptManager = stageController_.GetScriptManagerP();
            _int64 idItemScript = stageScriptManager.GetItemScriptID();
            if (idItemScript != StgControlScriptManager.ID_INVALID)
            {
                ref_count_ptr<ManagedScript> scriptItem = stageScriptManager.GetScript(idItemScript);
                if (scriptItem != null)
                {
                    List<gstd.value> listScriptValue = new List<gstd.value>();
                    for (int iVal = 0 ; iVal < listValue.Count ; iVal++)
                    {
                        listScriptValue.Add(scriptItem.CreateRealValue(listValue[iVal]));
                    }
                    scriptItem.RequestEvent(StgStageItemScript.EV_GET_ITEM, listScriptValue);
                }
            }
        }


        /**********************************************************
        //StgItemObject
        **********************************************************/
        public StgItemObject(StgStageController stageController) : base(stageController)
        {
            stageController_ = stageController;
            typeObject_ = StgStageScript.OBJ_ITEM;

            pattern_ = new StgMovePattern_Item(this);
            color_ = D3DCOLOR_ARGB(255, 255, 255, 255);
            score_ = 0;

            bMoveToPlayer_ = false;
            bPermitMoveToPlayer_ = true;
            bChangeItemScore_ = true;

            int priItemI = stageController_.GetStageInformation().GetItemObjectPriority();
            double priItemD = (double)priItemI / (stageController_.GetMainObjectManager().GetRenderBucketCapacity() - 1);
            SetRenderPriority(priItemD);
        }

        public override void Work()
        {
            bool bDefaultMovePattern = ref_count_ptr<StgMovePattern_Item>.unsync.DownCast(GetPattern()) != null;
            if (!bDefaultMovePattern && IsMoveToPlayer())
            {
                double speed = 8;
                ref_count_ptr<StgPlayerObject>.unsync objPlayer = stageController_.GetPlayerObject();
                double angle = System.Math.Atan2(objPlayer.GetY() - GetPositionY(), objPlayer.GetX() - GetPositionX());
                double angDirection = Math.RadianToDegree(angle);
                SetSpeed(speed);
                SetDirectionAngle(angDirection);
            }
            base._Move();
            SetX(posX_);
            SetY(posY_);

            _DeleteInAutoClip();
        }

        public override void Render()
        {
        } // �ꊇ�ŕ`�悷�邽�߃I�u�W�F�N�g�Ǘ��ł̕`��͂��Ȃ�
        public virtual void RenderOnItemManager(D3DXMATRIX mat)
        {
            StgItemManager itemManager = stageController_.GetItemManager();
            SpriteList2D renderer = typeItem_ == (int)AnonymousEnum2.ITEM_SCORE ? itemManager.GetDigitRenderer() : itemManager.GetItemRenderer();

            if (typeItem_ != (int)AnonymousEnum2.ITEM_SCORE)
            {
                double scale = 1.0;
                switch (typeItem_)
                {
                case AnonymousEnum2.ITEM_1UP:
                case AnonymousEnum2.ITEM_SPELL:
                case AnonymousEnum2.ITEM_POWER:
                case AnonymousEnum2.ITEM_POINT:
                    scale = 1.0;
                    break;

                case AnonymousEnum2.ITEM_1UP_S:
                case AnonymousEnum2.ITEM_SPELL_S:
                case AnonymousEnum2.ITEM_POWER_S:
                case AnonymousEnum2.ITEM_POINT_S:
                case AnonymousEnum2.ITEM_BONUS:
                    scale = 0.75;
                    break;
                }

                RECT rcSrc = new RECT();
                switch (typeItem_)
                {
                case AnonymousEnum2.ITEM_1UP:
                case AnonymousEnum2.ITEM_1UP_S:
                    SetRect(rcSrc, 1, 1, 16, 16);
                    break;
                case AnonymousEnum2.ITEM_SPELL:
                case AnonymousEnum2.ITEM_SPELL_S:
                    SetRect(rcSrc, 20, 1, 35, 16);
                    break;
                case AnonymousEnum2.ITEM_POWER:
                case AnonymousEnum2.ITEM_POWER_S:
                    SetRect(rcSrc, 40, 1, 55, 16);
                    break;
                case AnonymousEnum2.ITEM_POINT:
                case AnonymousEnum2.ITEM_POINT_S:
                    SetRect(rcSrc, 1, 20, 16, 35);
                    break;
                case AnonymousEnum2.ITEM_BONUS:
                    SetRect(rcSrc, 20, 20, 35, 35);
                    break;
                }

                // ��ɂ͂ݏo���Ă���
                double posY = posY_;
                D3DCOLOR color = D3DCOLOR_ARGB(255, 255, 255, 255);
                if (posY_ <= 0)
                {
                    D3DCOLOR colorOver = D3DCOLOR_ARGB(255, 255, 255, 255);
                    switch (typeItem_)
                    {
                    case AnonymousEnum2.ITEM_1UP:
                    case AnonymousEnum2.ITEM_1UP_S:
                        colorOver = D3DCOLOR_ARGB(255, 236, 0, 236);
                        break;
                    case AnonymousEnum2.ITEM_SPELL:
                    case AnonymousEnum2.ITEM_SPELL_S:
                        colorOver = D3DCOLOR_ARGB(255, 0, 160, 0);
                        break;
                    case AnonymousEnum2.ITEM_POWER:
                    case AnonymousEnum2.ITEM_POWER_S:
                        colorOver = D3DCOLOR_ARGB(255, 209, 0, 0);
                        break;
                    case AnonymousEnum2.ITEM_POINT:
                    case AnonymousEnum2.ITEM_POINT_S:
                        colorOver = D3DCOLOR_ARGB(255, 0, 0, 160);
                        break;
                    }
                    if (color != colorOver)
                    {
                        SetRect(rcSrc, 113, 1, 126, 10);
                        posY = 6;
                    }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = colorOver;
                    color.CopyFrom(colorOver);
                }

                RECT_D rcSrcD = directx.GlobalMembers.GetRectD(rcSrc);
                renderer.SetColor(color);
                renderer.SetPosition(posX_, posY, 0);
                renderer.SetScaleXYZ(scale, scale, scale);
                renderer.SetSourceRect(rcSrcD);
                renderer.SetDestinationCenter();
                renderer.AddVertex();
            }
            else
            {
                renderer.SetScaleXYZ(1.0, 1.0, 1.0);
                renderer.SetColor(color_);
                renderer.SetPosition(0, 0, 0);

                int fontSize = 14;
                _int64 score = new _int64(score_);
                List<int> listNum = new List<int>();
                while (true)
                {
                    int tnum = score % 10;
                    score /= 10;
                    listNum.Add(tnum);
                    if (score == 0)
                    {
                        break;
                    }
                }
                for (int iNum = listNum.Count - 1; iNum >= 0 ; iNum--)
                {
                    RECT_D rcSrc = new RECT_D((double)(listNum[iNum] * 36), 0.0, (double)((listNum[iNum] + 1) * 36 - 1), 31.0);
                    RECT_D rcDest = new RECT_D((double)(posX_ + (listNum.Count - 1 - iNum) * fontSize / 2), (double)posY_, (double)(posX_ + (listNum.Count - iNum) * fontSize / 2), (double)(posY_ + fontSize));
                    renderer.SetSourceRect(rcSrc);
                    renderer.SetDestinationRect(rcDest);
                    renderer.AddVertex();
                }
            }
        }

        public override void SetRenderState()
        {
        }
        public virtual void Activate()
        {
        }

        public abstract void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget);

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

        public void SetToPosition(POINT pos)
        {
            StgMovePattern_Item move = (StgMovePattern_Item)pattern_.GetPointer();
            move.SetToPosition(new POINT(pos));
        }

        public _int64 GetScore()
        {
            return new _int64(score_);
        }
        public void SetScore(_int64 score)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: score_ = score;
            score_.CopyFrom(score);
        }
        public bool IsMoveToPlayer()
        {
            return bMoveToPlayer_;
        }
        public void SetMoveToPlayer(bool b)
        {
            bMoveToPlayer_ = b;
        }
        public bool IsPermitMoveToPlayer()
        {
            return bPermitMoveToPlayer_;
        }
        public void SetPermitMoveToPlayer(bool bPermit)
        {
            bPermitMoveToPlayer_ = bPermit;
        }
        public void SetChangeItemScore(bool b)
        {
            bChangeItemScore_ = b;
        }

        public int GetMoveType()
        {
            int res = (int)StgMovePattern_Item.AnonymousEnum3.MOVE_NONE;

            StgMovePattern_Item move = pattern_.GetPointer() as StgMovePattern_Item;
            if (move != null)
            {
                res = move.GetItemMoveType();
            }
            return res;
        }

        public void SetMoveType(int type)
        {
            StgMovePattern_Item move = pattern_.GetPointer() as StgMovePattern_Item;
            if (move != null)
            {
                move.SetItemMoveType(type);
            }
        }

        public int GetItemType()
        {
            return typeItem_;
        }
        public void SetItemType(int type)
        {
            typeItem_ = type;
        }
        public StgStageController GetStageController()
        {
            return stageController_;
        }
}

public class StgItemObject_1UP : StgItemObject
{

        // StgItemObject_1UP
        public StgItemObject_1UP(StgStageController stageController) : base(stageController)
        {
            typeItem_ = ITEM_1UP;
            StgMovePattern_Item move = (StgMovePattern_Item)pattern_.GetPointer();
            move.SetItemMoveType((int)StgMovePattern_Item.AnonymousEnum3.MOVE_TOPOSITION_A);
        }

        public override void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget)
        {
            List<double> listValue = new List<double>();
            listValue.Add(typeItem_);
            listValue.Add(idObject_);
            _NotifyEventToPlayerScript(listValue);
            _NotifyEventToItemScript(listValue);

            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            objectManager.DeleteObject(GetObjectID());
        }
}

public class StgItemObject_Bomb : StgItemObject
{

        // StgItemObject_Bomb
        public StgItemObject_Bomb(StgStageController stageController) : base(stageController)
        {
            typeItem_ = ITEM_SPELL;
            StgMovePattern_Item move = (StgMovePattern_Item)pattern_.GetPointer();
            move.SetItemMoveType((int)StgMovePattern_Item.AnonymousEnum3.MOVE_TOPOSITION_A);
        }

        public override void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget)
        {
            List<double> listValue = new List<double>();
            listValue.Add(typeItem_);
            listValue.Add(idObject_);
            _NotifyEventToPlayerScript(listValue);
            _NotifyEventToItemScript(listValue);

            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            objectManager.DeleteObject(GetObjectID());
        }
}

public class StgItemObject_Power : StgItemObject
{

        // StgItemObject_Power
        public StgItemObject_Power(StgStageController stageController) : base(stageController)
        {
            typeItem_ = ITEM_POWER;
            StgMovePattern_Item move = (StgMovePattern_Item)pattern_.GetPointer();
            move.SetItemMoveType((int)StgMovePattern_Item.AnonymousEnum3.MOVE_TOPOSITION_A);
            score_ = 10;
        }

        public override void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget)
        {
            if (bChangeItemScore_)
            {
                _CreateScoreItem();
            }
            stageController_.GetStageInformation().AddScore(score_);

            List<double> listValue = new List<double>();
            listValue.Add(typeItem_);
            listValue.Add(idObject_);
            _NotifyEventToPlayerScript(listValue);
            _NotifyEventToItemScript(listValue);

            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            objectManager.DeleteObject(GetObjectID());
        }
}

public class StgItemObject_Point : StgItemObject
{

        // StgItemObject_Point
        public StgItemObject_Point(StgStageController stageController) : base(stageController)
        {
            typeItem_ = ITEM_POINT;
            StgMovePattern_Item move = (StgMovePattern_Item)pattern_.GetPointer();
            move.SetItemMoveType((int)StgMovePattern_Item.AnonymousEnum3.MOVE_TOPOSITION_A);
        }

        public override void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget)
        {
            if (bChangeItemScore_)
            {
                _CreateScoreItem();
            }
            stageController_.GetStageInformation().AddScore(score_);

            List<double> listValue = new List<double>();
            listValue.Add(typeItem_);
            listValue.Add(idObject_);
            _NotifyEventToPlayerScript(listValue);
            _NotifyEventToItemScript(listValue);

            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            objectManager.DeleteObject(GetObjectID());
        }
}

public class StgItemObject_Bonus : StgItemObject
{

        // StgItemObject_Bonus
        public StgItemObject_Bonus(StgStageController stageController) : base(stageController)
        {
            typeItem_ = ITEM_BONUS;
            StgMovePattern_Item move = (StgMovePattern_Item)pattern_.GetPointer();
            move.SetItemMoveType((int)StgMovePattern_Item.AnonymousEnum3.MOVE_TOPLAYER);

            int graze = stageController.GetStageInformation().GetGraze();
            score_ = (int)(graze / 40) * 10 + 300;
        }

        public override void Work()
        {
            base.Work();

            ref_count_ptr<StgPlayerObject>.unsync objPlayer = stageController_.GetPlayerObject();
            if (objPlayer.GetState() != StgPlayerObject.STATE_NORMAL)
            {
                _CreateScoreItem();
                stageController_.GetStageInformation().AddScore(score_);

                ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
                objectManager.DeleteObject(GetObjectID());
            }
        }

        public override void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget)
        {
            _CreateScoreItem();
            stageController_.GetStageInformation().AddScore(score_);

            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            objectManager.DeleteObject(GetObjectID());
        }
}

public class StgItemObject_Score : StgItemObject
{
        private int frameDelete_;

        // StgItemObject_Score
        public StgItemObject_Score(StgStageController stageController) : base(stageController)
        {
            typeItem_ = ITEM_SCORE;
            StgMovePattern_Item move = (StgMovePattern_Item)pattern_.GetPointer();
            move.SetItemMoveType((int)StgMovePattern_Item.AnonymousEnum3.MOVE_SCORE);

            bPermitMoveToPlayer_ = false;

            frameDelete_ = 0;
        }

        public override void Work()
        {
            base.Work();
            int alpha = 255 - frameDelete_ * 8;
            color_ = D3DCOLOR_ARGB(alpha, alpha, alpha, alpha);

            if (frameDelete_ > 30)
            {
                stageController_.GetMainObjectManager().DeleteObject(GetObjectID());
                return;
            }
            frameDelete_++;
        }

        public override void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget)
        {
        }
}

public class StgItemObject_User : StgItemObject
{
        private int frameWork_;
        private int idImage_;

        private StgItemData _GetItemData()
        {
            StgItemData res = null;
            StgItemManager itemManager = stageController_.GetItemManager();
            StgItemDataList dataList = itemManager.GetItemDataList();

            if (dataList != null)
            {
                res = dataList.GetData(idImage_).GetPointer();
            }

            return res;
        }

        private void _SetVertexPosition(VERTEX_TLX vertex, float x, float y, float z = 1.0f, float w = 1.0f)
        {
            float bias = -0.5f;
            vertex.position.x = x + bias;
            vertex.position.y = y + bias;
            vertex.position.z = z;
            vertex.position.w = w;
        }

        private void _SetVertexUV(VERTEX_TLX vertex, float u, float v)
        {
            StgItemData itemData = _GetItemData();
            if (itemData == null)
            {
                return;
            }

            ref_count_ptr<Texture> texture = itemData.GetTexture();
            int width = texture.GetWidth();
            int height = texture.GetHeight();
            vertex.texcoord.x = u / width;
            vertex.texcoord.y = v / height;
        }

        private void _SetVertexColorARGB(VERTEX_TLX vertex, D3DCOLOR color)
        {
            vertex.diffuse_color = color;
        }


        // StgItemObject_User
        public StgItemObject_User(StgStageController stageController) : base(stageController)
        {
            typeItem_ = ITEM_USER;
            idImage_ = -1;
            frameWork_ = 0;
            StgMovePattern_Item move = (StgMovePattern_Item)pattern_.GetPointer();
            move.SetItemMoveType((int)StgMovePattern_Item.AnonymousEnum3.MOVE_DOWN);

            bChangeItemScore_ = true;
        }

        public override void Work()
        {
            base.Work();
            frameWork_++;
        }

        public override void RenderOnItemManager(D3DXMATRIX mat)
        {
            if (!IsVisible())
            {
                return;
            }

            StgItemData itemData = _GetItemData();
            if (itemData == null)
            {
                return;
            }

            int objBlendType = GetBlendType();
            StgItemRenderer renderer = itemData.GetRenderer();
            if (renderer == null)
            {
                return;
            }

            D3DXMATRIX matScale = new D3DXMATRIX();
            D3DXMATRIX matRot = new D3DXMATRIX();
            D3DXMATRIX matTrans = new D3DXMATRIX();
            RECT rcSrc = new RECT();
            D3DCOLOR color = new D3DCOLOR();
            {
                // ��ɂ͂ݏo���Ă���
                bool bOutY = false;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcSrc = itemData->GetRect(frameWork_);
                rcSrc.CopyFrom(itemData.GetRect(frameWork_));
                if (position_.y + (rcSrc.bottom - rcSrc.top) / 2 <= 0)
                {
                    bOutY = true;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcSrc = itemData->GetOut();
                    rcSrc.CopyFrom(itemData.GetOut());
                }

                double angleZ = angle_.z;
                if (!bOutY)
                {
                    D3DXMatrixScaling(matScale, scale_.x, scale_.y, scale_.z);
                    D3DXMatrixRotationYawPitchRoll(matRot, D3DXToRadian(angle_.y), D3DXToRadian(angle_.x), D3DXToRadian(angleZ));
                    D3DXMatrixTranslation(matTrans, position_.x, position_.y, position_.z);
                }
                else
                {
                    D3DXMatrixIdentity(matScale);
                    D3DXMatrixIdentity(matRot);
                    D3DXMatrixTranslation(matTrans, position_.x, (rcSrc.bottom - rcSrc.top) / 2, position_.z);
                }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mat = matScale * matRot * matTrans * mat;
                mat.CopyFrom(matScale * matRot * matTrans * mat);

                bool bBlendAddRGB = (objBlendType == DirectGraphics.MODE_BLEND_ADD_RGB);

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: color = color_;
                color.CopyFrom(color_);
                double alpha = itemData.GetAlpha() / 255.0;
                if (bBlendAddRGB)
                {
                    color = ColorAccess.ApplyAlpha(color, alpha);
                }
                else
                {
                    int colorA = ColorAccess.GetColorA(color);
                    color = ColorAccess.SetColorA(color, alpha * colorA);
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

        public override void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget)
        {
            if (bChangeItemScore_)
            {
                _CreateScoreItem();
            }
            stageController_.GetStageInformation().AddScore(score_);

            List<double> listValue = new List<double>();
            listValue.Add(typeItem_);
            listValue.Add(idObject_);
            _NotifyEventToItemScript(listValue);

            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            objectManager.DeleteObject(GetObjectID());
        }

        public void SetImageID(int id)
        {
            idImage_ = id;
            StgItemData data = _GetItemData();
            if (data != null)
            {
                typeItem_ = data.GetItemType();
            }
        }
}

/**********************************************************
//StgMovePattern_Item
**********************************************************/
public class StgMovePattern_Item : StgMovePattern
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum3
        {
            MOVE_NONE,
            MOVE_TOPOSITION_A, // �w��|�C���g�ւ̈ړ�(60�t���[��)
            MOVE_DOWN, // ���~
            MOVE_TOPLAYER, // ���@�ֈړ�
            MOVE_SCORE // ���_(�㏸)
        }

        protected int frame_;
        protected int typeMove_;
        protected double speed_;
        protected double angDirection_;

        protected POINT posTo_ = new POINT();


        /**********************************************************
        //StgMovePattern_Item
        **********************************************************/
        public StgMovePattern_Item(StgMoveObject target) : base(target)
        {
            frame_ = 0;
            typeMove_ = (int)AnonymousEnum3.MOVE_DOWN;
            speed_ = 3;
            angDirection_ = 270;
            ZeroMemory(posTo_, sizeof(POINT));
        }

        public override void Move()
        {
            StgItemObject itemObject = (StgItemObject)target_;
            StgStageController stageController = itemObject.GetStageController();

            double px = target_.GetPositionX();
            double py = target_.GetPositionY();
            if (typeMove_ == (int)AnonymousEnum3.MOVE_TOPLAYER || itemObject.IsMoveToPlayer())
            {
                speed_ = 8;
                ref_count_ptr<StgPlayerObject>.unsync objPlayer = stageController.GetPlayerObject();
                double angle = System.Math.Atan2(objPlayer.GetY() - py, objPlayer.GetX() - px);
                angDirection_ = Math.RadianToDegree(angle);
            }
            else if (typeMove_ == (int)AnonymousEnum3.MOVE_TOPOSITION_A)
            {
                double tarX = px;
                double tarY = py;

                double toX = posTo_.x;
                double toY = posTo_.y;
                speed_ = System.Math.Pow(System.Math.Pow(toX - tarX, 2) + System.Math.Pow(toY - tarY, 2), 0.5) / 16;

                double angle = System.Math.Atan2(toY - tarY, toX - tarX);
                angDirection_ = Math.RadianToDegree(angle);
                if (frame_ == 60)
                {
                    speed_ = 0;
                    angDirection_ = 90;
                    typeMove_ = (int)AnonymousEnum3.MOVE_DOWN;
                }
            }
            else if (typeMove_ == (int)AnonymousEnum3.MOVE_DOWN)
            {
                speed_ += 3.0f / 60.0f;
                if (speed_ > 2.5f)
                {
                    speed_ = 2.5f;
                }
                angDirection_ = 90;
            }
            else if (typeMove_ == (int)AnonymousEnum3.MOVE_SCORE)
            {
                speed_ = 1;
                angDirection_ = 270;
            }

            if (typeMove_ != (int)AnonymousEnum3.MOVE_NONE)
            {
                double sx = speed_ * System.Math.Cos(Math.DegreeToRadian(angDirection_));
                double sy = speed_ * System.Math.Sin(Math.DegreeToRadian(angDirection_));
                px = target_.GetPositionX() + sx;
                py = target_.GetPositionY() + sy;
                target_.SetPositionX(px);
                target_.SetPositionY(py);
            }

            frame_++;
        }

        public new int GetType()
        {
            return TYPE_OTHER;
        }
        public override double GetSpeed()
        {
            return 0;
        }
        public override double GetDirectionAngle()
        {
            return 0;
        }
        public void SetToPosition(POINT pos)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: posTo_ = pos;
            posTo_.CopyFrom(pos);
        }

        public int GetItemMoveType()
        {
            return typeMove_;
        }
        public void SetItemMoveType(int type)
        {
            typeMove_ = type;
        }
}

