using gstd;
using directx;

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
    //TransitionEffect
    **********************************************************/
    public abstract class TransitionEffect : System.IDisposable
    {


            /**********************************************************
            //TransitionEffect
            **********************************************************/
            public TransitionEffect()
            {

            }

            public virtual void Dispose()
            {

            }

            public abstract void Work();
            public abstract void Render();
            public virtual bool IsEnd()
            {
                return true;
            }
    }

    /**********************************************************
    //TransitionEffect_FadeOut
    **********************************************************/
    public class TransitionEffect_FadeOut : TransitionEffect
    {
            protected double diffAlpha_;
            protected double alpha_;
            protected gstd.ref_count_ptr<Sprite2D> sprite_ = new gstd.ref_count_ptr<Sprite2D>();

            /**********************************************************
            //TransitionEffect_FadeOut
            **********************************************************/
            public override void Work()
            {
                if (sprite_ == null)
                {
                    return;
                }
                alpha_ -= diffAlpha_;
                alpha_ = System.Math.Max(alpha_, 0);
                sprite_.SetAlpha((int)alpha_);
            }

            public override void Render()
            {
                if (sprite_ == null)
                {
                    return;
                }

                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ALPHA);
                graphics.SetZBufferEnable(false);
                graphics.SetZWriteEnalbe(false);
                sprite_.Render();
            }

            public override bool IsEnd()
            {
                bool res = (alpha_ <= 0);
                return res;
            }

            public void Initialize(int frame, gstd.ref_count_ptr<Texture> texture)
            {
                diffAlpha_ = 255.0 / frame;
                alpha_ = 255.0;
                DirectGraphics graphics = DirectGraphics.GetBase();
                int width = graphics.GetScreenWidth();
                int height = graphics.GetScreenHeight();
                RECT_D rect = new RECT_D() { left = 0.0, top = 0.0, right = (double)width, bottom = (double)height };

                sprite_ = new Sprite2D();
                sprite_.SetTexture(texture);
                sprite_.SetVertex(rect, rect, D3DCOLOR_ARGB((int)alpha_, 255, 255, 255));
            }

    }

    /**********************************************************
    //TransitionEffectTask
    **********************************************************/
    public class TransitionEffectTask : gstd.TaskBase
    {
            protected gstd.ref_count_ptr<TransitionEffect> effect_ = new gstd.ref_count_ptr<TransitionEffect>();

            /**********************************************************
            //TransitionEffectTask
            **********************************************************/
            public TransitionEffectTask()
            {
            }

            public new void Dispose()
            {
                base.Dispose();
            }

            public void SetTransition(gstd.ref_count_ptr<TransitionEffect> effect)
            {
                effect_.CopyFrom(effect);
            }

            public virtual void Work()
            {
                if (effect_ != null)
                {
                    effect_.Work();
                }
            }

            public virtual void Render()
            {
                if (effect_ != null)
                {
                    effect_.Render();
                }
            }
    }
}
