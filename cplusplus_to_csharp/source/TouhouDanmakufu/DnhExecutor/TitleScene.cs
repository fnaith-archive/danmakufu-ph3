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

/**********************************************************
//TitleScene
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class TitleScene : TaskBase, MenuTask
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            TASK_PRI_WORK = 5,
            TASK_PRI_RENDER = 5
        }

// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        private enum AnonymousEnum2
        {
            ITEM_COUNT = 7,
            ITEM_ALL = 0,
            ITEM_SINGLE,
            ITEM_PLURAL,
            ITEM_STAGE,
            ITEM_PACKAGE,
            ITEM_DIRECTORY,
            ITEM_QUIT
        }
        private ref_count_ptr<Sprite2D> spriteBack_ = new ref_count_ptr<Sprite2D>();

        /**********************************************************
        //TitleScene
        **********************************************************/
        public TitleScene()
        {
            pageMaxY_ = (int)AnonymousEnum2.ITEM_COUNT - 1;

            string pathBack = EPathProperty.GetSystemImageDirectory() + "System_Title_Background.png";
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

            string[] strText = { "All", "Single", "Plural", "Stage", "Package", "Directory", "Quit" };
            string[] strDescription = { "", L"", "", L"", "", L"", "", L"" };
            for (int iItem = 0 ; iItem < (int)AnonymousEnum2.ITEM_COUNT ; iItem++)
            {
                int x = 48 + iItem * 6 + 12 * System.Math.Pow((double) - 1,(int)(iItem - 1));
                int y = 154 + iItem * 30;
                AddMenuItem(new TitleSceneMenuItem(strText[iItem], strDescription[iItem], x, y));
            }

            cursorY_ = SystemController.GetInstance().GetSystemInformation().GetLastTitleSelectedIndex();
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
                SceneManager sceneManager = SystemController.GetInstance().GetSceneManager();

                // �I��C���f�b�N�X�ۑ�
                SystemController.GetInstance().GetSystemInformation().SetLastTitleSelectedIndex(cursorY_);

                switch (cursorY_)
                {
                    case AnonymousEnum2.ITEM_ALL:
                        sceneManager.TransScriptSelectScene_All();
                        break;
                    case AnonymousEnum2.ITEM_SINGLE:
                        sceneManager.TransScriptSelectScene_Single();
                        break;
                    case AnonymousEnum2.ITEM_PLURAL:
                        sceneManager.TransScriptSelectScene_Plural();
                        break;
                    case AnonymousEnum2.ITEM_STAGE:
                        sceneManager.TransScriptSelectScene_Stage();
                        break;
                    case AnonymousEnum2.ITEM_PACKAGE:
                        sceneManager.TransScriptSelectScene_Package();
                        break;
                    case AnonymousEnum2.ITEM_DIRECTORY:
                        sceneManager.TransScriptSelectScene_Directory();
                        break;
                    case AnonymousEnum2.ITEM_QUIT:
                        EApplication.GetInstance().End();
                        break;
                }

                return;
            }
            else if (input.GetVirtualKeyState(EDirectInput.KEY_CANCEL) == KEY_PUSH)
            {
                cursorY_ = (int)AnonymousEnum2.ITEM_QUIT;
            }
        }

        public new void Render()
        {
            EDirectGraphics graphics = EDirectGraphics.GetInstance();
            graphics.SetRenderStateFor2D(DirectGraphics.MODE_BLEND_ALPHA);

            spriteBack_.Render();

            base.Render();
        }
}

public class TitleSceneMenuItem : TextLightUpMenuItem
{
        private ref_count_ptr<DxTextRenderObject> objText_ = new ref_count_ptr<DxTextRenderObject>();
        private POINT pos_ = new POINT();

        private TitleScene _GetTitleScene()
        {
            return (TitleScene)menu_;
        }

        // TitleSceneMenuItem
        public TitleSceneMenuItem(string text, string description, int x, int y)
        {
            pos_.x = x;
            pos_.y = y;

            DxText dxText = new DxText();
            dxText.SetFontColorTop(D3DCOLOR_ARGB(255,255,255,255));
            dxText.SetFontColorBottom(D3DCOLOR_ARGB(255,64,64,64));
            dxText.SetFontBorderType(directx.DxFont.BORDER_FULL);
            dxText.SetFontBorderColor(D3DCOLOR_ARGB(255,32,32,128));
            dxText.SetFontBorderWidth(2);
            dxText.SetFontSize(24);
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
