/**********************************************************
//SystemResidentTask
**********************************************************/
public class SystemResidentTask : TaskBase, System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            TASK_PRI_RENDER_FPS = 9
        }

        private DxText textFps_ = new DxText();


        /**********************************************************
        //SystemResidentTask
        **********************************************************/
        public SystemResidentTask()
        {
            DirectGraphics graphics = DirectGraphics.GetBase();
            int screenWidth = graphics.GetScreenWidth();
            int screenHeight = graphics.GetScreenHeight();

            textFps_.SetFontColorTop(D3DCOLOR_ARGB(255,160,160,255));
            textFps_.SetFontColorBottom(D3DCOLOR_ARGB(255,64,64,255));
            textFps_.SetFontBorderType(directx.DxFont.BORDER_FULL);
            textFps_.SetFontBorderColor(D3DCOLOR_ARGB(255,255,255,255));
            textFps_.SetFontBorderWidth(2);
            textFps_.SetFontSize(14);
            textFps_.SetFontBold(true);
            textFps_.SetMaxWidth(screenWidth - 8);
            textFps_.SetHorizontalAlignment(DxText.ALIGNMENT_RIGHT);
            textFps_.SetPosition(0, screenHeight - 20);
        }

        public void Dispose()
        {
        }

        public void RenderFps()
        {
            DirectGraphics graphics = DirectGraphics.GetBase();
            graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ALPHA);
            graphics.SetZBufferEnable(false);
            graphics.SetZWriteEnalbe(false);
            graphics.SetFogEnable(false);

            EFpsController fpsController = EFpsController.GetInstance();
            float fps = fpsController.GetCurrentWorkFps();
            textFps_.SetText(StringUtility.Format("%.2ffps", fps));
            // textFps_.Render();
        }
}
