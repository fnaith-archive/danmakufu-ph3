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


// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class ScriptSelectSceneMenuItem;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class ScriptSelectModel;
/**********************************************************
//ScriptSelectScene
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class ScriptSelectScene : TaskBase, MenuTask
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            TASK_PRI_WORK = 5,
            TASK_PRI_RENDER = 5
        }
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum2
        {
            TYPE_SINGLE,
            TYPE_PLURAL,
            TYPE_STAGE,
            TYPE_PACKAGE,
            TYPE_DIR,
            TYPE_ALL
        }
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum3
        {
            COUNT_MENU_TEXT = 10
        }
        public class Sort
        {
            public static bool functorMethod(ref_count_ptr<MenuItem> lf, ref_count_ptr<MenuItem> rf)
            {
                ref_count_ptr<MenuItem> lsp = new ref_count_ptr<MenuItem>(lf);
                ref_count_ptr<MenuItem> rsp = new ref_count_ptr<MenuItem>(rf);
                ScriptSelectSceneMenuItem lp = (ScriptSelectSceneMenuItem)lsp.GetPointer();
                ScriptSelectSceneMenuItem rp = (ScriptSelectSceneMenuItem)rsp.GetPointer();

                if (lp.GetType() == (int)ScriptSelectSceneMenuItem.AnonymousEnum4.TYPE_DIR && rp.GetType() != (int)ScriptSelectSceneMenuItem.AnonymousEnum4.TYPE_DIR)
                {
                    return true;
                }
                if (lp.GetType() != (int)ScriptSelectSceneMenuItem.AnonymousEnum4.TYPE_DIR && rp.GetType() == (int)ScriptSelectSceneMenuItem.AnonymousEnum4.TYPE_DIR)
                {
                    return false;
                }

                string lPath = lp.GetPath();
                string rPath = rp.GetPath();
                bool res = CompareString(LOCALE_SYSTEM_DEFAULT, NORM_IGNORECASE, lPath, -1, rPath, -1);
                return res == CSTR_LESS_THAN ? true : false;
            }
        }

        private ref_count_ptr<ScriptSelectModel> model_ = new ref_count_ptr<ScriptSelectModel>();
        private ref_count_ptr<Sprite2D> spriteBack_ = new ref_count_ptr<Sprite2D>();
        private ref_count_ptr<Sprite2D> spriteImage_ = new ref_count_ptr<Sprite2D>();
        private List<ref_count_ptr<DxTextRenderObject>> objMenuText_ = new List<ref_count_ptr<DxTextRenderObject>>();
        private int frameSelect_;

        private override void _ChangePage()
        {
            DxText dxText = new DxText();
            dxText.SetFontBorderType(directx.DxFont.BORDER_FULL);
            dxText.SetFontBorderWidth(2);
            dxText.SetFontSize(16);
            dxText.SetFontBold(true);

            int top = (pageCurrent_ - 1) * (pageMaxY_ + 1);
            for (int iItem = 0 ; iItem <= pageMaxY_ ; iItem++)
            {
                int index = top + iItem;
                if (index < item_.Count && item_[index] != null)
                {
                    ScriptSelectSceneMenuItem pItem = (ScriptSelectSceneMenuItem)item_[index].GetPointer();
                    if (pItem.GetType() == ScriptSelectSceneMenuItem.TYPE_DIR)
                    {
                        dxText.SetFontColorTop(D3DCOLOR_ARGB(255,255,255,255));
                        dxText.SetFontColorBottom(D3DCOLOR_ARGB(255,255,64,64));
                        dxText.SetFontBorderColor(D3DCOLOR_ARGB(255,128,32,32));
                        string path = pItem.GetPath();
                        string text = "[DIR.] ";
                        text += PathProperty.GetDirectoryName(path);
                        dxText.SetText(text);
                    }
                    else
                    {
                        dxText.SetFontColorTop(D3DCOLOR_ARGB(255,255,255,255));
                        dxText.SetFontColorBottom(D3DCOLOR_ARGB(255,64,64,255));
                        dxText.SetFontBorderColor(D3DCOLOR_ARGB(255,32,32,128));
                        ref_count_ptr<ScriptInformation> info = pItem.GetScriptInformation();
                        dxText.SetText(info.GetTitle());
                    }

                    objMenuText_[iItem] = dxText.CreateRenderObject();
                }
                else
                {
                    objMenuText_[iItem] = null;
                }
            }

            frameSelect_ = 0;
        }


        /**********************************************************
        //ScriptSelectScene
        **********************************************************/
        public ScriptSelectScene()
        {
            string pathBack = EPathProperty.GetSystemImageDirectory() + "System_ScriptSelect_Background.png";
            ref_count_ptr<Texture> textureBack = new Texture();
            textureBack.CreateFromFile(pathBack);

            DirectGraphics graphics = DirectGraphics.GetBase();
            int screenWidth = graphics.GetScreenWidth();
            int screenHeight = graphics.GetScreenHeight();
            RECT_D srcBack = new RECT_D(0.0, 0.0, 640.0, 480.0);
            RECT_D destBack = new RECT_D(0.0, 0.0, (double)screenWidth, (double)screenHeight);
            spriteBack_ = new Sprite2D();
            spriteBack_.SetTexture(textureBack);
            spriteBack_.SetVertex(srcBack, destBack);

            spriteImage_ = new Sprite2D();

            pageMaxY_ = 9;
            objMenuText_.Resize(AnonymousEnum3.COUNT_MENU_TEXT);
            bPageChangeX_ = true;

            frameSelect_ = 0;
        }

        public new void Dispose()
        {
            ClearModel();
            base.Dispose();
        }

        public override void Work()
        {
            {
                ref_count_ptr<ScriptSelectFileModel> model = new ref_count_ptr<ScriptSelectFileModel>(model_);
                if (model != null && model.GetStatus() == Thread.RUN)
                {
                    if (model.GetWaitPath().size() > 0)
                    {
                        return;
                    }
                }
            }
            if (!bActive_)
            {
                return;
            }

            int lastCursorY = cursorY_;

            base.Work();
            if (!_IsWaitedKeyFree())
            {
                return;
            }

            EDirectInput input = EDirectInput.GetInstance();
            if (input.GetVirtualKeyState(EDirectInput.KEY_OK) == KEY_PUSH)
            {
                ref_count_ptr<MenuItem> tItem = GetSelectedMenuItem();
                ref_count_ptr<ScriptSelectSceneMenuItem> item = new ref_count_ptr<ScriptSelectSceneMenuItem>(tItem);
                if (item != null)
                {
                    bool bDir = item.GetType() == ScriptSelectSceneMenuItem.TYPE_DIR;
                    if (bDir)
                    {
                        // �f�B���N�g��
                        ref_count_ptr<ScriptSelectModel> model = null;
                        int index = GetSelectedItemIndex();
                        ScriptSelectSceneMenuItem pItem = (ScriptSelectSceneMenuItem)item_[index].GetPointer();
                        string dir = pItem.GetPath();

                        // �y�[�W���Z�b�g
                        cursorX_ = 0;
                        cursorY_ = 0;
                        pageCurrent_ = 1;

                        model = new ScriptSelectFileModel((int)AnonymousEnum2.TYPE_DIR, dir);
                        SetModel(new ref_count_ptr<ScriptSelectModel>(model));

                        SystemController.GetInstance().GetSystemInformation().SetLastScriptSearchDirectory(dir);
                        bWaitedKeyFree_ = false;
                    }
                    else
                    {
                        // �X�N���v�g
                        SetActive(false);

                        int index = GetSelectedItemIndex();
                        ScriptSelectSceneMenuItem pItem = (ScriptSelectSceneMenuItem)item_[index].GetPointer();
                        ref_count_ptr<ScriptInformation> info = pItem.GetScriptInformation();

                        string pathLastSelected = info.GetScriptPath();
                        SystemController.GetInstance().GetSystemInformation().SetLastSelectedScriptPath(pathLastSelected);

                        ETaskManager taskManager = ETaskManager.GetInstance();
                        ref_count_ptr<PlayTypeSelectScene> task = new PlayTypeSelectScene(info);
                        taskManager.AddTask(task);
                        taskManager.AddWorkFunction(TTaskFunction<PlayTypeSelectScene>.Create(task, PlayTypeSelectScene.Work), PlayTypeSelectScene.TASK_PRI_WORK);
                        taskManager.AddRenderFunction(TTaskFunction<PlayTypeSelectScene>.Create(task, PlayTypeSelectScene.Render), PlayTypeSelectScene.TASK_PRI_RENDER);

                        return;
                    }
                }
            }
            else if (input.GetVirtualKeyState(EDirectInput.KEY_CANCEL) == KEY_PUSH)
            {
                bool bTitle = true;

                if (GetType() == (int)AnonymousEnum2.TYPE_DIR)
                {
                    ref_count_ptr<ScriptSelectFileModel> fileModel = new ref_count_ptr<ScriptSelectFileModel>(model_);
                    string dir = fileModel.GetDirectory();
                    string root = EPathProperty.GetStgScriptRootDirectory();
                    if (!File.IsEqualsPath(dir, root))
                    {
                        // �L�����Z��
                        bTitle = false;
                        string dirOld = SystemController.GetInstance().GetSystemInformation().GetLastScriptSearchDirectory();
                        string.size_type pos = dirOld.LastIndexOfAny((Convert.ToString("/")).ToCharArray(), dirOld.Length - 2);
                        string dir = dirOld.Substring(0, pos) + "/";
                        ref_count_ptr<ScriptSelectFileModel> model = new ScriptSelectFileModel((int)AnonymousEnum2.TYPE_DIR, dir);
                        model.SetWaitPath(dirOld);

                        // SetWaitPath�őI�𒆂̃p�X�Ɉړ������邽�߂�
                        // �y�[�W���Z�b�g
                        cursorX_ = 0;
                        cursorY_ = 0;
                        pageCurrent_ = 1;
                        SetModel(new ref_count_ptr<ScriptSelectFileModel>(model));

                        SystemController.GetInstance().GetSystemInformation().SetLastScriptSearchDirectory(dir);
                        bWaitedKeyFree_ = false;
                        return;
                    }
                }

                if (bTitle)
                {
                    SceneManager sceneManager = SystemController.GetInstance().GetSceneManager();
                    sceneManager.TransTitleScene();
                    return;
                }
            }

            if (lastCursorY != cursorY_)
            {
                frameSelect_ = 0;
            }
            else
            {
                frameSelect_++;
            }
        }

        public override void Render()
        {
            EDirectGraphics graphics = EDirectGraphics.GetInstance();
            graphics.SetRenderStateFor2D(DirectGraphics.MODE_BLEND_ALPHA);

            spriteBack_.Render();

            string strType;
            switch (GetType())
            {
                case AnonymousEnum2.TYPE_SINGLE:
                    strType = "Single";
                    break;
                case AnonymousEnum2.TYPE_PLURAL:
                    strType = "Plural";
                    break;
                case AnonymousEnum2.TYPE_STAGE:
                    strType = "Stage";
                    break;
                case AnonymousEnum2.TYPE_PACKAGE:
                    strType = "Package";
                    break;
                case AnonymousEnum2.TYPE_DIR:
                    strType = "Directory";
                    break;
                case AnonymousEnum2.TYPE_ALL:
                    strType = "All";
                    break;
            }

            string strDescription = StringUtility.Format("�t�@�C����I����Ă������� (%s�F%d/%d)", strType, pageCurrent_, GetPageCount());

            DxText dxTextDescription = new DxText();
            dxTextDescription.SetFontColorTop(D3DCOLOR_ARGB(255,128,128,255));
            dxTextDescription.SetFontColorBottom(D3DCOLOR_ARGB(255,64,64,255));
            dxTextDescription.SetFontBorderType(directx.DxFont.BORDER_FULL);
            dxTextDescription.SetFontBorderColor(D3DCOLOR_ARGB(255,255,255,255));
            dxTextDescription.SetFontBorderWidth(2);
            dxTextDescription.SetFontSize(20);
            dxTextDescription.SetFontBold(true);
            dxTextDescription.SetText(strDescription);
            dxTextDescription.SetPosition(32,8);
            dxTextDescription.Render();

            // �f�B���N�g����
            if (GetType() == (int)AnonymousEnum2.TYPE_DIR)
            {
                ref_count_ptr<ScriptSelectFileModel> fileModel = new ref_count_ptr<ScriptSelectFileModel>(model_);
                string dir = fileModel.GetDirectory();
                string root = EPathProperty.GetStgScriptRootDirectory();

                dir = PathProperty.ReplaceYenToSlash(dir);
                root = PathProperty.ReplaceYenToSlash(root);
                string textDir = "script/" + StringUtility.ReplaceAll(dir, root, "");

                DxText dxTextDir = new DxText();
                dxTextDir.SetFontColorTop(D3DCOLOR_ARGB(255,255,255,255));
                dxTextDir.SetFontColorBottom(D3DCOLOR_ARGB(255,255,128,128));
                dxTextDir.SetFontBorderType(directx.DxFont.BORDER_NONE);
                dxTextDir.SetFontBorderWidth(0);
                dxTextDir.SetFontSize(14);
                dxTextDir.SetFontBold(true);
                dxTextDir.SetText(strDescription);
                dxTextDir.SetPosition(40,32);
                dxTextDir.SetText(textDir);
                dxTextDir.Render();
            }

            {
                // �^�C�g��
                Lock @lock = new Lock(cs_);
                for (int iItem = 0 ; iItem <= pageMaxY_ ; iItem++)
                {
                    ref_count_ptr<DxTextRenderObject> obj = objMenuText_[iItem];
                    if (obj == null)
                    {
                        continue;
                    }
                    int alphaText = bActive_ ? 255 : 128;
                    obj.SetVertexColor(D3DCOLOR_ARGB(255, alphaText, alphaText, alphaText));
                    obj.SetPosition(32, 48 + iItem * 18);
                    obj.Render();

                    if (iItem == cursorY_)
                    {
                        graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ADD_RGB);
                        int cycle = 60;
                        int alpha = frameSelect_ % cycle;
                        if (alpha < cycle / 2)
                        {
                            alpha = (int)255 * (float)((float)(cycle / 2 - alpha) / (float)(cycle / 2));
                        }
                        else
                        {
                            alpha = (int)255 * (float)((float)(alpha - cycle / 2) / (float)(cycle / 2));
                        }
                        obj.SetVertexColor(D3DCOLOR_ARGB(255, alpha, alpha, alpha));
                        obj.Render();
                        obj.SetVertexColor(D3DCOLOR_ARGB(255, 255, 255, 255));
                        graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ALPHA);
                    }
                }

                ref_count_ptr<ScriptSelectSceneMenuItem> item = new ref_count_ptr<ScriptSelectSceneMenuItem>(GetSelectedMenuItem());
                if (bActive_ && item != null && item.GetType() != ScriptSelectSceneMenuItem.TYPE_DIR)
                {
                    ref_count_ptr<ScriptInformation> info = item.GetScriptInformation();

                    DxText dxTextInfo = new DxText();
                    dxTextInfo.SetFontBorderColor(D3DCOLOR_ARGB(255,255,255,255));
                    dxTextInfo.SetFontBorderType(directx.DxFont.BORDER_NONE);
                    dxTextInfo.SetFontBorderWidth(0);
                    dxTextInfo.SetFontSize(16);
                    dxTextInfo.SetFontBold(true);

                    // �C���[�W
                    ref_count_ptr<Texture> texture = spriteImage_.GetTexture();
                    string pathImage1 = "";
                    if (texture != null)
                    {
                        pathImage1 = texture.GetName();
                    }
                    string pathImage2 = info.GetImagePath();
                    if (pathImage1 != pathImage2)
                    {
                        texture = new Texture();
                        File file = new File(pathImage2);
                        if (file.IsExists())
                        {
                            texture.CreateFromFileInLoadThread(pathImage2);
                            spriteImage_.SetTexture(texture);
                        }
                        else
                        {
                            spriteImage_.SetTexture(null);
                        }

                    }

                    texture = spriteImage_.GetTexture();
                    if (texture != null && texture.IsLoad())
                    {
                        RECT_D rcSrc = new RECT_D(0.0, 0.0, (double)texture.GetWidth(), (double)texture.GetHeight());
                        RECT_D rcDest = new RECT_D(340.0, 250.0, (double)(rcDest.left + 280), (double)(rcDest.top + 210));
                        spriteImage_.SetSourceRect(rcSrc);
                        spriteImage_.SetDestinationRect(rcDest);
                        spriteImage_.Render();
                    }

                    // �X�N���v�g�p�X
                    string path = info.GetScriptPath();
                    string root = EPathProperty.GetStgScriptRootDirectory();
                    root = PathProperty.ReplaceYenToSlash(root);
                    path = PathProperty.ReplaceYenToSlash(path);
                    path = StringUtility.ReplaceAll(path, root, "");

                    string archive = info.GetArchivePath();
                    if (archive.Length > 0)
                    {
                        archive = PathProperty.ReplaceYenToSlash(archive);
                        archive = StringUtility.ReplaceAll(archive, root, "");
                        path += StringUtility.Format(" [%s]", archive);
                    }

                    dxTextInfo.SetFontColorTop(D3DCOLOR_ARGB(255,255,255,255));
                    dxTextInfo.SetFontColorBottom(D3DCOLOR_ARGB(255,255,64,64));
                    dxTextInfo.SetText(path);
                    dxTextInfo.SetPosition(16, 240);
                    dxTextInfo.Render();

                    // �X�N���v�g���
                    int type = info.GetType();
                    string strType = "";
                    switch (type)
                    {
                    case ScriptInformation.TYPE_SINGLE:
                        strType = "(Single)";
                        break;
                    case ScriptInformation.TYPE_PLURAL:
                        strType = "(Plural)";
                        break;
                    case ScriptInformation.TYPE_STAGE:
                        strType = "(Stage)";
                        break;
                    case ScriptInformation.TYPE_PACKAGE:
                        strType = "(Package)";
                        break;
                    }
                    dxTextInfo.SetFontColorTop(D3DCOLOR_ARGB(255,255,255,255));
                    dxTextInfo.SetFontColorBottom(D3DCOLOR_ARGB(255,255,64,255));
                    dxTextInfo.SetText(strType);
                    dxTextInfo.SetPosition(32, 256);
                    dxTextInfo.Render();

                    // �e�L�X�g
                    string text = info.GetText();
                    dxTextInfo.SetFontColorTop(D3DCOLOR_ARGB(255,255,255,255));
                    dxTextInfo.SetFontColorBottom(D3DCOLOR_ARGB(255,64,64,255));
                    dxTextInfo.SetFontSize(18);
                    dxTextInfo.SetLinePitch(9);
                    dxTextInfo.SetText(text);
                    dxTextInfo.SetPosition(24, 288);
                    dxTextInfo.SetMaxWidth(320);
                    dxTextInfo.Render();

                }

            }

            if (!model_.IsCreated())
            {
                // ���[�h��
                string text = "Now Loading...";
                DxText dxTextNowLoad = new DxText();
                dxTextNowLoad.SetFontColorTop(D3DCOLOR_ARGB(255,128,128,128));
                dxTextNowLoad.SetFontColorBottom(D3DCOLOR_ARGB(255,64,64,64));
                dxTextNowLoad.SetFontBorderType(directx.DxFont.BORDER_FULL);
                dxTextNowLoad.SetFontBorderColor(D3DCOLOR_ARGB(255,255,255,255));
                dxTextNowLoad.SetFontBorderWidth(2);
                dxTextNowLoad.SetFontSize(18);
                dxTextNowLoad.SetFontBold(true);
                dxTextNowLoad.SetText(strDescription);
                dxTextNowLoad.SetPosition(24, 452);
                dxTextNowLoad.SetText(text);
                dxTextNowLoad.Render();
            }
        }

        public override void Clear()
        {
            base.Clear();
            objMenuText_.Clear();
            objMenuText_.Resize(AnonymousEnum3.COUNT_MENU_TEXT);
        }

        public int GetType()
        {
            int res = (int)AnonymousEnum2.TYPE_SINGLE;
            ref_count_ptr<ScriptSelectFileModel> fileModel = new ref_count_ptr<ScriptSelectFileModel>(model_);
            if (fileModel != null)
            {
                res = fileModel.GetType();
            }
            return res;
        }

        public void SetModel(ref_count_ptr<ScriptSelectModel> model)
        {
            ClearModel();

            if (model == null)
            {
                return;
            }
            model.scene_ = this;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: model_ = model;
            model_.CopyFrom(model);

            ref_count_ptr<ScriptSelectFileModel> fileModel = new ref_count_ptr<ScriptSelectFileModel>(model_);
            if (fileModel != null)
            {
                SystemController.GetInstance().GetSystemInformation().SetLastSelectScriptSceneType(fileModel.GetType());
            }

            model.CreateMenuItem();
        }

        public void ClearModel()
        {
            Clear();
            if (model_ != null)
            {
                ref_count_ptr<ScriptSelectFileModel> fileModel = new ref_count_ptr<ScriptSelectFileModel>(model_);
                if (fileModel != null)
                {
                    fileModel.Stop();
                }
                fileModel.Join();
            }

            model_ = null;
        }

        public void AddMenuItem(LinkedList<ref_count_ptr<ScriptSelectSceneMenuItem>> listItem)
        {
            if (listItem.Count == 0)
            {
                return;
            }

            {
                Lock @lock = new Lock(cs_);

                LinkedList<ref_count_ptr<ScriptSelectSceneMenuItem>>.Enumerator itr = listItem.GetEnumerator();
                while (itr.MoveNext())
                {
                    base.AddMenuItem(itr.Current);
                }

                // ���ݑI�𒆂̃A�C�e��
                ref_count_ptr<MenuItem> item = GetSelectedMenuItem();

                // �\�[�g
// C++ TO C# CONVERTER TODO TASK: The 'Compare' parameter of std::sort produces a boolean value, while the .NET Comparison parameter produces a tri-state result:
// ORIGINAL LINE: std::sort(item_.begin(), item_.end(), ScriptSelectScene::Sort());
                item_.Sort(new ScriptSelectScene.Sort());

                // ���ݑI�𒆂̃A�C�e���Ɉړ�
                if (item != null)
                {
                    bool bWait = false;
                    string path = "";
                    ref_count_ptr<ScriptSelectFileModel> model = new ref_count_ptr<ScriptSelectFileModel>(model_);
                    if (model != null)
                    {
                        path = model.GetWaitPath();
                        if (path.Length > 0)
                        {
                            bWait = true;
                        }
                    }

                    if (path.Length == 0 && (pageCurrent_ > 1 || cursorY_ > 0))
                    {
                        ScriptSelectSceneMenuItem pItem = (ScriptSelectSceneMenuItem)item.GetPointer();
                        path = pItem.GetPath();
                    }

                    for (int iItem = 0 ; iItem < item_.Count ; iItem++)
                    {
                        ScriptSelectSceneMenuItem itrItem = (ScriptSelectSceneMenuItem)item_[iItem].GetPointer();
                        if (itrItem == null)
                        {
                            continue;
                        }

                        bool bEqualsPath = File.IsEqualsPath(path, itrItem.GetPath());
                        if (!bEqualsPath)
                        {
                            continue;
                        }

                        pageCurrent_ = iItem / (pageMaxY_ + 1) + 1;
                        cursorY_ = iItem % (pageMaxY_ + 1);

                        if (bWait)
                        {
                            model.SetWaitPath("");
                        }

                        break;
                    }
                }

                _ChangePage();
            }
        }

}

public class ScriptSelectSceneMenuItem : MenuItem
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//    friend ScriptSelectScene;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum4
        {
            TYPE_SINGLE,
            TYPE_PLURAL,
            TYPE_STAGE,
            TYPE_PACKAGE,
            TYPE_DIR
        }

        private int type_;
        private string path_ = "";
        private ref_count_ptr<ScriptInformation> info_ = new ref_count_ptr<ScriptInformation>();
        private ScriptSelectScene _GetScriptSelectScene()
        {
            return (ScriptSelectScene)menu_;
        }


        // ScriptSelectSceneMenuItem
        public ScriptSelectSceneMenuItem(int type, string path, ref_count_ptr<ScriptInformation> info)
        {
            type_ = type;
            path_ = PathProperty.ReplaceYenToSlash(path);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: info_ = info;
            info_.CopyFrom(info);
        }

        public new void Dispose()
        {
            base.Dispose();
        }

        public int GetType()
        {
            return type_;
        }
        public string GetPath()
        {
            return path_;
        }
        public ref_count_ptr<ScriptInformation> GetScriptInformation()
        {
            return new ref_count_ptr<ScriptInformation>(info_);
        }
}


/**********************************************************
//ScriptSelectModel
**********************************************************/
public abstract class ScriptSelectModel : System.IDisposable
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//    friend ScriptSelectScene;
// C++ TO C# CONVERTER TODO TASK: 'volatile' has a different meaning in C#:
// ORIGINAL LINE: volatile bool bCreated_;
        protected bool bCreated_;
        protected ScriptSelectScene scene_;


        /**********************************************************
        //ScriptSelectModel
        **********************************************************/
        public ScriptSelectModel()
        {
            bCreated_ = false;
        }

        public virtual void Dispose()
        {
        }

        public abstract void CreateMenuItem();
        public bool IsCreated()
        {
            return bCreated_;
        }
}

// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class ScriptSelectFileModel : ScriptSelectModel, Thread
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum5
        {
            TYPE_SINGLE = ScriptSelectScene.AnonymousEnum2.TYPE_SINGLE,
            TYPE_PLURAL = ScriptSelectScene.AnonymousEnum2.TYPE_PLURAL,
            TYPE_STAGE = ScriptSelectScene.AnonymousEnum2.TYPE_STAGE,
            TYPE_PACKAGE = ScriptSelectScene.AnonymousEnum2.TYPE_PACKAGE,
            TYPE_DIR = ScriptSelectScene.AnonymousEnum2.TYPE_DIR,
            TYPE_ALL = ScriptSelectScene.AnonymousEnum2.TYPE_ALL
        }

        protected int type_;
        protected string dir_ = "";
        protected string pathWait_ = "";
        protected int timeLastUpdate_;

        protected LinkedList<ref_count_ptr<ScriptSelectSceneMenuItem>> listItem_ = new LinkedList<ref_count_ptr<ScriptSelectSceneMenuItem>>();
        protected virtual void _Run()
        {
            timeLastUpdate_ = global::timeGetTime() - 1000;
            _SearchScript(dir_);
            if (GetStatus() == RUN)
            {
                scene_.AddMenuItem(listItem_);
                listItem_.Clear();
            }
            bCreated_ = true;
        }

        protected virtual void _SearchScript(string dir)
        {
            WIN32_FIND_DATA data = new WIN32_FIND_DATA();
            IntPtr hFind;
            string findDir = dir + "*.*";
            hFind = FindFirstFile(findDir, data);
            do
            {
                if (GetStatus() != RUN)
                {
                    return;
                }

                int time = global::timeGetTime();
                if (System.Math.Abs(time - timeLastUpdate_) > 500)
                {
                    // 500ms���ɍX�V
                    timeLastUpdate_ = time;
                    scene_.AddMenuItem(listItem_);
                    listItem_.Clear();
                }

                string name = data.cFileName;
                if ((data.dwFileAttributes & FILE_ATTRIBUTE_DIRECTORY) != 0 && (name != ".." && name != "."))
                {
                    // �f�B���N�g��
                    string tDir = dir + name;
                    tDir += "\\";

                    if (type_ == (int)AnonymousEnum5.TYPE_DIR)
                    {
                        // �f�B���N�g��
                        ref_count_ptr<ScriptSelectSceneMenuItem> item = new ScriptSelectSceneMenuItem((int)ScriptSelectSceneMenuItem.AnonymousEnum4.TYPE_DIR, tDir, null);
                        listItem_.AddLast(item);
                    }
                    else
                    {
                        _SearchScript(tDir);
                    }
                    continue;
                }
                if (wcscmp(data.cFileName, "..") == 0 || wcscmp(data.cFileName, ".") == 0)
                {
                    continue;
                }

                // �t�@�C��
                string path = dir + name;

                _CreateMenuItem(path);

            }while (FindNextFile(hFind, data));
            FindClose(hFind);
        }

        protected void _CreateMenuItem(string path)
        {
            List<ref_count_ptr<ScriptInformation>> listInfo = ScriptInformation.CreateScriptInformationList(path, true);
            for (int iInfo = 0 ; iInfo < listInfo.Count ; iInfo++)
            {
                ref_count_ptr<ScriptInformation> info = listInfo[iInfo];
                if (!_IsValidScriptInformation(new ref_count_ptr<ScriptInformation>(info)))
                {
                    continue;
                }

                int typeItem = _ConvertTypeInfoToItem(info.GetType());
                ref_count_ptr<ScriptSelectSceneMenuItem> item = new ScriptSelectSceneMenuItem(typeItem, info.GetScriptPath(), info);
                listItem_.AddLast(item);
            }

        }

        protected bool _IsValidScriptInformation(ref_count_ptr<ScriptInformation> info)
        {
            int typeScript = info.GetType();
            bool bTarget = false;
            switch (type_)
            {
                case AnonymousEnum5.TYPE_SINGLE:
                    bTarget = (typeScript == ScriptInformation.TYPE_SINGLE);
                    break;
                case AnonymousEnum5.TYPE_PLURAL:
                    bTarget = (typeScript == ScriptInformation.TYPE_PLURAL);
                    break;
                case AnonymousEnum5.TYPE_STAGE:
                    bTarget |= (typeScript == ScriptInformation.TYPE_STAGE);
                    // bTarget |= (typeScript == ScriptInformation::TYPE_PACKAGE);
                    break;
                case AnonymousEnum5.TYPE_PACKAGE:
                    bTarget = (typeScript == ScriptInformation.TYPE_PACKAGE);
                    break;
                case AnonymousEnum5.TYPE_DIR:
                    bTarget = (typeScript != ScriptInformation.TYPE_PLAYER);
                    break;
                case AnonymousEnum5.TYPE_ALL:
                    bTarget = (typeScript != ScriptInformation.TYPE_PLAYER);
                    break;
            }

            return bTarget;
        }

        protected int _ConvertTypeInfoToItem(int typeInfo)
        {
            int typeItem = (int)ScriptSelectSceneMenuItem.AnonymousEnum4.TYPE_SINGLE;
            switch (typeInfo)
            {
                case ScriptInformation.TYPE_SINGLE:
                    typeItem = (int)ScriptSelectSceneMenuItem.AnonymousEnum4.TYPE_SINGLE;
                    break;
                case ScriptInformation.TYPE_PLURAL:
                    typeItem = (int)ScriptSelectSceneMenuItem.AnonymousEnum4.TYPE_PLURAL;
                    break;
                case ScriptInformation.TYPE_STAGE:
                    typeItem = (int)ScriptSelectSceneMenuItem.AnonymousEnum4.TYPE_STAGE;
                    break;
                case ScriptInformation.TYPE_PACKAGE:
                    typeItem = (int)ScriptSelectSceneMenuItem.AnonymousEnum4.TYPE_PACKAGE;
                    break;
            }
            return typeItem;
        }


        // ScriptSelectFileModel
        public ScriptSelectFileModel(int type, string dir)
        {
            type_ = type;
            dir_ = dir;
        }

        public override void Dispose()
        {

            base.Dispose();
        }

        public override void CreateMenuItem()
        {
            bCreated_ = false;
            if (type_ == (int)AnonymousEnum5.TYPE_DIR)
            {
                SystemController.GetInstance().GetSystemInformation().SetLastScriptSearchDirectory(dir_);
            }
            Start();
        }

        public int GetType()
        {
            return type_;
        }
        public string GetDirectory()
        {
            return dir_;
        }

        public string GetWaitPath()
        {
            return pathWait_;
        }
        public void SetWaitPath(string path)
        {
            pathWait_ = path;
        }
}

/**********************************************************
//PlayTypeSelectScene
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class PlayTypeSelectScene : TaskBase, MenuTask
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum6
        {
            TASK_PRI_WORK = 6,
            TASK_PRI_RENDER = 6
        }

        private ref_count_ptr<ScriptInformation> info_ = new ref_count_ptr<ScriptInformation>();
        private ref_count_ptr<ReplayInformationManager> replayInfoManager_ = new ref_count_ptr<ReplayInformationManager>();


        /**********************************************************
        //PlayTypeSelectScene
        **********************************************************/
        public PlayTypeSelectScene(ref_count_ptr<ScriptInformation> info)
        {
            pageMaxY_ = 10;
            bPageChangeX_ = true;

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: info_ = info;
            info_.CopyFrom(info);
            int mx = 24;
            int my = 256;
            AddMenuItem(new PlayTypeSelectMenuItem("Play", mx, my));

            // ���v���C
            if (info.GetType() != ScriptInformation.TYPE_PACKAGE)
            {
                int itemCount = 1;
                string pathScript = info.GetScriptPath();
                replayInfoManager_ = new ReplayInformationManager();
                replayInfoManager_.UpdateInformationList(pathScript);
                List<int> listReplayIndex = replayInfoManager_.GetIndexList();
                for (int iList = 0 ; iList < listReplayIndex.Count ; iList++)
                {
                    int index = listReplayIndex[iList];
                    ref_count_ptr<ReplayInformation> replay = replayInfoManager_.GetInformation(index);
                    int itemY = 256 + (itemCount % pageMaxY_) * 20;

                    string text = StringUtility.Format("No.%02d %-8s %012I64d %-8s (%2.2ffps) <%s>", index, replay.GetUserName().c_str(), replay.GetTotalScore(), replay.GetPlayerScriptReplayName().c_str(), replay.GetAvarageFps(), replay.GetDateAsString().c_str());
                    AddMenuItem(new PlayTypeSelectMenuItem(text, mx, itemY));
                    itemCount++;
                }
            }

        }

        public new void Work()
        {
            base.Work();
            if (!_IsWaitedKeyFree())
            {
                return;
            }

            EDirectInput input = EDirectInput.GetInstance();
            if (input.GetVirtualKeyState(EDirectInput.KEY_OK) == KEY_PUSH)
            {
                if (info_.GetType() == ScriptInformation.TYPE_PACKAGE)
                {
                    // �p�b�P�[�W���[�h
                    SceneManager sceneManager = SystemController.GetInstance().GetSceneManager();
                    sceneManager.TransPackageScene(new ref_count_ptr<ScriptInformation>(info_));
                }
                else
                {
                    // �p�b�P�[�W�ȊO
                    int indexSelect = GetSelectedItemIndex();
                    if (indexSelect == 0)
                    {
                        // ���@�I��
                        TransitionManager transitionManager = SystemController.GetInstance().GetTransitionManager();
                        transitionManager.DoFadeOut();

                        ETaskManager taskManager = ETaskManager.GetInstance();
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                        taskManager.SetRenderFunctionEnable(false, typeid(ScriptSelectScene));
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                        taskManager.SetWorkFunctionEnable(false, typeid(PlayTypeSelectScene));
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                        taskManager.SetRenderFunctionEnable(false, typeid(PlayTypeSelectScene));

                        ref_count_ptr<PlayerSelectScene> task = new PlayerSelectScene(info_);
                        taskManager.AddTask(task);
                        taskManager.AddWorkFunction(TTaskFunction<PlayerSelectScene>.Create(task, PlayerSelectScene.Work), PlayerSelectScene.TASK_PRI_WORK);
                        taskManager.AddRenderFunction(TTaskFunction<PlayerSelectScene>.Create(task, PlayerSelectScene.Render), PlayerSelectScene.TASK_PRI_RENDER);
                    }
                    else
                    {
                        // ���v���C
                        List<int> listReplayIndex = replayInfoManager_.GetIndexList();
                        int replayIndex = listReplayIndex[indexSelect - 1];
                        ref_count_ptr<ReplayInformation> replay = replayInfoManager_.GetInformation(replayIndex);

                        SceneManager sceneManager = SystemController.GetInstance().GetSceneManager();
                        sceneManager.TransStgScene(new ref_count_ptr<ScriptInformation>(info_), new ref_count_ptr<ReplayInformation>(replay));
                    }
                }

                return;
            }
            else if (input.GetVirtualKeyState(EDirectInput.KEY_CANCEL) == KEY_PUSH)
            {
                ETaskManager taskManager = ETaskManager.GetInstance();
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                ref_count_ptr<ScriptSelectScene> scriptSelectScene = new ref_count_ptr<ScriptSelectScene>(taskManager.GetTask(typeid(ScriptSelectScene)));
                scriptSelectScene.SetActive(true);

// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                taskManager.RemoveTask(typeid(PlayTypeSelectScene));
                return;
            }

        }

        public new void Render()
        {
            base.Render();
        }
}
public class PlayTypeSelectMenuItem : TextLightUpMenuItem
{
        private ref_count_ptr<DxTextRenderObject> objText_ = new ref_count_ptr<DxTextRenderObject>();
        private POINT pos_ = new POINT();

        private PlayTypeSelectScene _GetTitleScene()
        {
            return (PlayTypeSelectScene)menu_;
        }

        // PlayTypeSelectMenuItem
        public PlayTypeSelectMenuItem(string text, int x, int y)
        {
            pos_.x = x;
            pos_.y = y;

            DxText dxText = new DxText();
            dxText.SetFontColorTop(D3DCOLOR_ARGB(255,255,255,255));
            dxText.SetFontColorBottom(D3DCOLOR_ARGB(255,64,64,64));
            dxText.SetFontBorderType(directx.DxFont.BORDER_FULL);
            dxText.SetFontBorderColor(D3DCOLOR_ARGB(255,32,32,128));
            dxText.SetFontBorderWidth(1);
            dxText.SetFontSize(14);
            dxText.SetFontBold(true);
            dxText.SetText(text);
            objText_ = dxText.CreateRenderObject();
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public new void Work()
        {
            _WorkSelectedItem();
        }

        public new void Render()
        {
            objText_.SetPosition(pos_);
            objText_.Render();

            if (menu_.GetSelectedMenuItem() == this)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ADD_RGB);

                int alpha = _GetSelectedItemAlpha();
                objText_.SetVertexColor(D3DCOLOR_ARGB(255, alpha, alpha, alpha));
                objText_.Render();
                objText_.SetVertexColor(D3DCOLOR_ARGB(255, 255, 255, 255));
                graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ALPHA);
            }
        }
}

/**********************************************************
//PlayerSelectScene
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class PlayerSelectScene : TaskBase, MenuTask
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum7
        {
            TASK_PRI_WORK = 7,
            TASK_PRI_RENDER = 7
        }

        private ref_count_ptr<Sprite2D> spriteBack_ = new ref_count_ptr<Sprite2D>();
        private ref_count_ptr<Sprite2D> spriteImage_ = new ref_count_ptr<Sprite2D>();
        private ref_count_ptr<ScriptInformation> info_ = new ref_count_ptr<ScriptInformation>();
        private List<ref_count_ptr<ScriptInformation>> listPlayer_ = new List<ref_count_ptr<ScriptInformation>>();
        private int frameSelect_;

        private override void _ChangePage()
        {
            frameSelect_ = 0;
        }

        /**********************************************************
        //PlayerSelectScene
        **********************************************************/
        public PlayerSelectScene(ref_count_ptr<ScriptInformation> info)
        {
            pageMaxY_ = 4;
            bPageChangeX_ = true;
            frameSelect_ = 0;

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: info_ = info;
            info_.CopyFrom(info);

            string pathBack = EPathProperty.GetSystemImageDirectory() + "System_ScriptSelect_Background.png";
            ref_count_ptr<Texture> textureBack = new Texture();
            textureBack.CreateFromFile(pathBack);

            DirectGraphics graphics = DirectGraphics.GetBase();
            int screenWidth = graphics.GetScreenWidth();
            int screenHeight = graphics.GetScreenHeight();
            RECT_D srcBack = new RECT_D(0.0, 0.0, 640.0, 480.0);
            RECT_D destBack = new RECT_D(0.0, 0.0, (double)screenWidth, (double)screenHeight);

            spriteBack_ = new Sprite2D();
            spriteBack_.SetTexture(textureBack);
            spriteBack_.SetVertex(srcBack, destBack);

            spriteImage_ = new Sprite2D();

            SystemInformation systemInfo = SystemController.GetInstance().GetSystemInformation();

            // ���@�ꗗ��쐬
            List<string> listPlayerPath = info_.GetPlayerList();
            if (listPlayerPath.Count == 0)
            {
                listPlayer_ = new List<ref_count_ptr<ScriptInformation>>(systemInfo.GetFreePlayerScriptInformationList());
            }
            else
            {
                listPlayer_ = info_.CreatePlayerScriptInformationList();
            }

            // ���j���[�쐬
            for (int iMenu = 0 ; iMenu < listPlayer_.Count; iMenu++)
            {
                AddMenuItem(new PlayerSelectMenuItem(listPlayer_[iMenu]));
            }

            List<ref_count_ptr<ScriptInformation>> listLastPlayerSelect = systemInfo.GetLastPlayerSelectedList();
            bool bSameList = false;
            if (listPlayer_.Count == listLastPlayerSelect.Count)
            {
                bSameList = true;
                for (int iList = 0 ; iList < listPlayer_.Count ; iList++)
                {
                    bSameList &= listPlayer_[iList] == listLastPlayerSelect[iList];
                }
            }
            if (bSameList)
            {
                int lastIndex = systemInfo.GetLastSelectedPlayerIndex();
                cursorY_ = lastIndex % (pageMaxY_ + 1);
                pageCurrent_ = lastIndex / (pageMaxY_ + 1) + 1;
            }

        }

        public new void Work()
        {
            int lastCursorY = cursorY_;

            base.Work();
            if (!_IsWaitedKeyFree())
            {
                return;
            }

            EDirectInput input = EDirectInput.GetInstance();
            if (input.GetVirtualKeyState(EDirectInput.KEY_OK) == KEY_PUSH)
            {
                int index = GetSelectedItemIndex();
                ref_count_ptr<ScriptInformation> infoPlayer = listPlayer_[index];
                SystemController.GetInstance().GetSystemInformation().SetLastSelectedPlayerIndex(index, listPlayer_);

                SceneManager sceneManager = SystemController.GetInstance().GetSceneManager();
                sceneManager.TransStgScene(new ref_count_ptr<ScriptInformation>(info_), new ref_count_ptr<ScriptInformation>(infoPlayer), null);

                return;
            }
            else if (input.GetVirtualKeyState(EDirectInput.KEY_CANCEL) == KEY_PUSH)
            {
                ETaskManager taskManager = ETaskManager.GetInstance();
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                taskManager.SetRenderFunctionEnable(true, typeid(ScriptSelectScene));
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                taskManager.SetWorkFunctionEnable(true, typeid(PlayTypeSelectScene));
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                taskManager.SetRenderFunctionEnable(true, typeid(PlayTypeSelectScene));

// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                taskManager.RemoveTask(typeid(PlayerSelectScene));

                return;
            }

            if (lastCursorY != cursorY_)
            {
                frameSelect_ = 0;
            }
            else
            {
                frameSelect_++;
            }
        }

        public new void Render()
        {
            EDirectGraphics graphics = EDirectGraphics.GetInstance();
            graphics.SetRenderStateFor2D(DirectGraphics.MODE_BLEND_ALPHA);

            spriteBack_.Render();

            int top = (pageCurrent_ - 1) * (pageMaxY_ + 1);
            ref_count_ptr<ScriptInformation> infoSelected = null;
            {
                Lock @lock = new Lock(cs_);
                for (int iItem = 0 ; iItem <= pageMaxY_ ; iItem++)
                {
                    int index = top + iItem;
                    if (index < item_.Count && item_[index] != null)
                    {
                        PlayerSelectMenuItem pItem = (PlayerSelectMenuItem)item_[index].GetPointer();
                        ref_count_ptr<ScriptInformation> info = pItem.GetScriptInformation();
                        if (GetSelectedItemIndex() == index)
                        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoSelected = info;
                            infoSelected.CopyFrom(info);
                        }
                    }
                }
            }

            if (infoSelected != null)
            {
                DxText dxTextInfo = new DxText();
                dxTextInfo.SetFontBorderColor(D3DCOLOR_ARGB(255,255,255,255));
                dxTextInfo.SetFontBorderType(directx.DxFont.BORDER_NONE);
                dxTextInfo.SetFontBold(true);

                // �C���[�W
                ref_count_ptr<Texture> texture = spriteImage_.GetTexture();
                string pathImage1 = "";
                if (texture != null)
                {
                    pathImage1 = texture.GetName();
                }
                string pathImage2 = infoSelected.GetImagePath();
                if (pathImage1 != pathImage2)
                {
                    texture = new Texture();
                    File file = new File(pathImage2);
                    if (file.IsExists())
                    {
                        texture.CreateFromFileInLoadThread(pathImage2);
                        spriteImage_.SetTexture(texture);
                    }
                    else
                    {
                        spriteImage_.SetTexture(null);
                    }

                }

                texture = spriteImage_.GetTexture();
                if (texture != null && texture.IsLoad())
                {
                    RECT_D rcSrc = new RECT_D(0.0, 0.0, (double)texture.GetWidth(), (double)texture.GetHeight());
                    RECT_D rcDest = new RECT_D(0.0, 0.0, (double)texture.GetWidth(), (double)texture.GetHeight());
                    spriteImage_.SetSourceRect(rcSrc);
                    spriteImage_.SetDestinationRect(rcDest);
                    spriteImage_.Render();
                }

                // �X�N���v�g�p�X
                string path = infoSelected.GetScriptPath();
                string root = EPathProperty.GetStgScriptRootDirectory();
                root = PathProperty.ReplaceYenToSlash(root);
                path = PathProperty.ReplaceYenToSlash(path);
                path = StringUtility.ReplaceAll(path, root, "");

                string archive = infoSelected.GetArchivePath();
                if (archive.Length > 0)
                {
                    archive = PathProperty.ReplaceYenToSlash(archive);
                    archive = StringUtility.ReplaceAll(archive, root, "");
                    path += StringUtility.Format(" [%s]", archive);
                }

                dxTextInfo.SetFontColorTop(D3DCOLOR_ARGB(255,255,255,255));
                dxTextInfo.SetFontColorBottom(D3DCOLOR_ARGB(255,255,128,128));
                dxTextInfo.SetFontSize(14);
                dxTextInfo.SetText(path);
                dxTextInfo.SetPosition(40,32);
                dxTextInfo.Render();

                // �e�L�X�g
                dxTextInfo.SetFontBorderType(directx.DxFont.BORDER_SHADOW);
                dxTextInfo.SetFontBold(false);
                dxTextInfo.SetFontBorderWidth(2);
                dxTextInfo.SetFontSize(16);
                dxTextInfo.SetFontBorderColor(D3DCOLOR_ARGB(255,255,255,255));
                dxTextInfo.SetFontColorTop(D3DCOLOR_ARGB(255,160,160,160));
                dxTextInfo.SetFontColorBottom(D3DCOLOR_ARGB(255,255,64,64));
                dxTextInfo.SetText(infoSelected.GetText());
                dxTextInfo.SetPosition(320, 240);
                dxTextInfo.Render();

            }

            string strDescription = StringUtility.Format("�U�����@��I����Ă������� (%d/%d)", pageCurrent_, GetPageCount());

            DxText dxTextDescription = new DxText();
            dxTextDescription.SetFontColorTop(D3DCOLOR_ARGB(255,128,128,255));
            dxTextDescription.SetFontColorBottom(D3DCOLOR_ARGB(255,64,64,255));
            dxTextDescription.SetFontBorderType(directx.DxFont.BORDER_FULL);
            dxTextDescription.SetFontBorderColor(D3DCOLOR_ARGB(255,255,255,255));
            dxTextDescription.SetFontBorderWidth(2);
            dxTextDescription.SetFontSize(20);
            dxTextDescription.SetFontBold(true);
            dxTextDescription.SetText(strDescription);
            dxTextDescription.SetPosition(32,8);
            dxTextDescription.Render();

            {
                Lock @lock = new Lock(cs_);
                for (int iItem = 0 ; iItem <= pageMaxY_ ; iItem++)
                {
                    int index = top + iItem;
                    if (index < item_.Count && item_[index] != null)
                    {
                        int mx = 320;
                        int my = 48 + (iItem % (pageMaxY_ + 1)) * 18;

                        PlayerSelectMenuItem pItem = (PlayerSelectMenuItem)item_[index].GetPointer();
                        ref_count_ptr<ScriptInformation> info = pItem.GetScriptInformation();

                        DxText dxText = new DxText();
                        dxText.SetPosition(mx, my);
                        dxText.SetFontBorderType(directx.DxFont.BORDER_FULL);
                        dxText.SetFontBorderWidth(2);
                        dxText.SetFontSize(16);
                        dxText.SetFontBold(true);
                        dxText.SetFontColorTop(D3DCOLOR_ARGB(255,255,255,255));
                        dxText.SetFontColorBottom(D3DCOLOR_ARGB(255,64,64,255));
                        dxText.SetFontBorderColor(D3DCOLOR_ARGB(255,32,32,128));
                        dxText.SetText(info.GetTitle());
                        dxText.Render();

                        if (GetSelectedItemIndex() == index)
                        {
                            graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ADD_RGB);
                            int cycle = 60;
                            int alpha = frameSelect_ % cycle;
                            if (alpha < cycle / 2)
                            {
                                alpha = (int)255 * (float)((float)(cycle / 2 - alpha) / (float)(cycle / 2));
                            }
                            else
                            {
                                alpha = (int)255 * (float)((float)(alpha - cycle / 2) / (float)(cycle / 2));
                            }
                            dxText.SetVertexColor(D3DCOLOR_ARGB(255, alpha, alpha, alpha));
                            dxText.Render();
                            graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ALPHA);
                        }
                    }
                }

            }
        }
}
public class PlayerSelectMenuItem : TextLightUpMenuItem
{
        private ref_count_ptr<ScriptInformation> info_ = new ref_count_ptr<ScriptInformation>(); // ���@���

        private PlayerSelectScene _GetTitleScene()
        {
            return (PlayerSelectScene)menu_;
        }

        // PlayerSelectMenuItem
        public PlayerSelectMenuItem(ref_count_ptr<ScriptInformation> info)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: info_ = info;
            info_.CopyFrom(info);
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public new void Work()
        {
            _WorkSelectedItem();
        }

        public new void Render()
        {

        }

        public ref_count_ptr<ScriptInformation> GetScriptInformation()
        {
            return new ref_count_ptr<ScriptInformation>(info_);
        }
}
