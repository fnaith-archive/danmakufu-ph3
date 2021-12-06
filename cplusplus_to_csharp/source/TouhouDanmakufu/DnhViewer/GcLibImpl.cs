using System;

/**********************************************************
//EApplication
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:


/**********************************************************
//EDirectGraphics
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class EDirectGraphics : Singleton<EDirectGraphics>, DirectGraphics, System.IDisposable
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend Singleton<EDirectGraphics>;

        /**********************************************************
        //EDirectGraphics
        **********************************************************/
        private EDirectGraphics()
        {

        }

        public void Dispose()
        {
        }

        public virtual bool Initialize()
        {
            DnhConfiguration dnhConfig = DnhConfiguration.GetInstance();
            int screenWidth = dnhConfig.GetScreenWidth();
            int screenHeight = dnhConfig.GetScreenHeight();

            IntPtr hWndGraph = MainWindow.GetInstance().GetGraphicsWindow().GetWindowHandle();
            DirectGraphicsConfig config = new DirectGraphicsConfig();
            config.SetScreenWidth(screenWidth);
            config.SetScreenHeight(screenHeight);
            return DirectGraphics.Initialize(hWndGraph, config);
        }

        public void SetRenderStateFor2D(int blend)
        {
            DirectGraphics graphics = DirectGraphics.GetBase();
            graphics.SetBlendMode(blend);
            graphics.SetZBufferEnable(false);
            graphics.SetZWriteEnalbe(false);
        }
}
