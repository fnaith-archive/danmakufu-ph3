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
//    class DxWindowManager;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxWindow;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxWindowEvent;

    /**********************************************************
    //DxWindowEvent
    **********************************************************/
    public class DxWindowEvent : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxWindowManager;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                TYPE_MOUSE_LEFT_PUSH = 1 << 0,
                TYPE_MOUSE_LEFT_RELEASE = 1 << 1,
                TYPE_MOUSE_LEFT_CLICK = 1 << 2,
                TYPE_MOUSE_LEFT_HOLD = 1 << 3,

                TYPE_MOUSE_RIGHT_PUSH = 1 << 4,
                TYPE_MOUSE_RIGHT_RELEASE = 1 << 5,
                TYPE_MOUSE_RIGHT_CLICK = 1 << 6,
                TYPE_MOUSE_RIGHT_HOLD = 1 << 7
            }
            protected gstd.ref_count_ptr<DxWindow> windowSource_ = new gstd.ref_count_ptr<DxWindow>(); // �E�B���h�E
            protected int type_;
            public DxWindowEvent()
            {
                type_ = 0;
            }
            public virtual void Dispose()
            {
            }
            public void SetSourceWindow(gstd.ref_count_ptr<DxWindow> source)
            {
                windowSource_.CopyFrom(source);
            }
            public gstd.ref_count_ptr<DxWindow> GetSourceWindow()
            {
                return new gstd.ref_count_ptr<DxWindow>(windowSource_);
            }
            public void AddEventType(int type)
            {
                type_ |= type;
            }
            public bool HasEventType(int type)
            {
                return (type_ & type) != 0;
            }
            public bool IsEmpty()
            {
                return type_ == 0;
            }
    }

    /**********************************************************
    //DxWindowManager
    **********************************************************/
    public class DxWindowManager : gstd.TaskBase
    {
            protected LinkedList<gstd.ref_count_ptr<DxWindow>> listWindow_ = new LinkedList<gstd.ref_count_ptr<DxWindow>>(); // �őO�ʂ��A�N�e�B�u
            protected gstd.ref_count_ptr<DxWindow> wndCapture_ = new gstd.ref_count_ptr<DxWindow>();
            protected LinkedList<int> listLockID_ = new LinkedList<int>();

            protected void _ArrangeWindow()
            {
                LinkedList<gstd.ref_count_ptr<DxWindow>>.Enumerator itr;
                for (itr = listWindow_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                        itr = listWindow_.erase(itr);
                    }
                    else if (itr.Current.IsWindowDelete())
                    {
                        itr.Current.Dispose();
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                        itr = listWindow_.erase(itr);
                    }
                    else
                    {
                    }
                }
            }

            protected virtual void _DispatchMouseEvent()
            {
                DirectInput input = DirectInput.GetBase();
                if (input == null)
                {
                    return;
                }

                gstd.ref_count_ptr<DxWindowEvent> @event = new DxWindowEvent();
                gstd.ref_count_ptr<DxWindow> wndIntersect = GetIntersectedWindow();

                // ���N���b�N
                int mLeftState = input.GetMouseState(DI_MOUSE_LEFT);
                int mRightState = input.GetMouseState(DI_MOUSE_RIGHT);
                if (wndCapture_ == null)
                {
                    if (wndIntersect != null)
                    {
                        if (mLeftState == KEY_PUSH)
                        {
                            wndCapture_.CopyFrom(wndIntersect);
                            @event.AddEventType(DxWindowEvent.TYPE_MOUSE_LEFT_PUSH);
                            @event.SetSourceWindow(wndIntersect);
                        }
                        else if (mLeftState == KEY_HOLD)
                        {
                            wndCapture_.CopyFrom(wndIntersect);
                            @event.AddEventType(DxWindowEvent.TYPE_MOUSE_LEFT_PUSH);
                            @event.AddEventType(DxWindowEvent.TYPE_MOUSE_LEFT_HOLD);
                            @event.SetSourceWindow(wndIntersect);
                        }
                    }
                }
                else
                {
                    if (wndIntersect != null && wndIntersect == wndCapture_)
                    {
                        if (mLeftState == KEY_PULL)
                        {
                            @event.AddEventType(DxWindowEvent.TYPE_MOUSE_LEFT_RELEASE);
                            @event.AddEventType(DxWindowEvent.TYPE_MOUSE_LEFT_CLICK);
                            @event.SetSourceWindow(wndIntersect);
                            wndCapture_ = null;
                        }
                    }
                    else
                    {
                        if (mLeftState == KEY_PULL || mLeftState == KEY_FREE)
                        {
                            @event.AddEventType(DxWindowEvent.TYPE_MOUSE_LEFT_RELEASE);
                            @event.SetSourceWindow(wndCapture_);
                            wndCapture_ = null;
                        }
                        else if (mLeftState == KEY_PUSH || mLeftState == KEY_HOLD)
                        {
                            @event.AddEventType(DxWindowEvent.TYPE_MOUSE_LEFT_HOLD);
                            @event.SetSourceWindow(wndCapture_);
                        }
                    }
                }

                if (@event.IsEmpty())
                {
                    if (mLeftState == KEY_PUSH)
                    {
                        @event.AddEventType(DxWindowEvent.TYPE_MOUSE_LEFT_PUSH);
                    }
                    else if (mLeftState == KEY_PULL)
                    {
                        @event.AddEventType(DxWindowEvent.TYPE_MOUSE_LEFT_RELEASE);
                    }

                    if (mRightState == KEY_PUSH)
                    {
                        @event.AddEventType(DxWindowEvent.TYPE_MOUSE_RIGHT_PUSH);
                    }
                    else if (mRightState == KEY_PULL)
                    {
                        @event.AddEventType(DxWindowEvent.TYPE_MOUSE_RIGHT_RELEASE);
                    }
                }

                if (!@event.IsEmpty())
                {
                    LinkedList<ref_count_ptr<DxWindow>>.Enumerator itr;
                    for (itr = listWindow_.GetEnumerator(); itr.MoveNext();)
                    {
                        if (itr.Current == null)
                        {
                            continue;
                        }
                        if (itr.Current.IsWindowDelete())
                        {
                            continue;
                        }
                        if (!itr.Current.IsWindowEnable())
                        {
                            continue;
                        }
                        if (!itr.Current.IsWindowVisible())
                        {
                            continue;
                        }
                        itr.Current.DispatchedEvent(@event);
                    }
                }

            }


            /**********************************************************
            //DxWindowManager
            **********************************************************/
            public DxWindowManager()
            {
            }

            public override void Dispose()
            {
                Clear();
                base.Dispose();
            }

            public void Clear()
            {
                listWindow_.Clear();
                wndCapture_ = null;
            }

            public void AddWindow(gstd.ref_count_ptr<DxWindow> window)
            {
                LinkedList<ref_count_ptr<DxWindow>>.Enumerator itr = listWindow_.GetEnumerator();
                while (itr.MoveNext())
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current == window)
                    {
                        return; // ���d�o�^�͂����Ȃ�
                    }
                }
                window.manager_ = this;
                listWindow_.AddLast(window);
                window.AddedManager();
            }

            public void DeleteWindow(DxWindow window)
            {
                LinkedList<ref_count_ptr<DxWindow>>.Enumerator itr = listWindow_.GetEnumerator();
                while (itr.MoveNext())
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current != window)
                    {
                        continue;
                    }
                    itr.Current.DeleteWindow();
                    return;
                }
            }

            public void DeleteWindowFromID(int id)
            {
                LinkedList<ref_count_ptr<DxWindow>>.Enumerator itr;
                for (itr = listWindow_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current.IsWindowDelete())
                    {
                        continue;
                    }
                    if (itr.Current.idWindow_ != id)
                    {
                        continue;
                    }
                    itr.Current.DeleteWindow();
                    return;
                }
            }

            public virtual void Work()
            {
                LinkedList<ref_count_ptr<DxWindow>>.Enumerator itr;
                for (itr = listWindow_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (!itr.Current.IsWindowEnable())
                    {
                        continue;
                    }
                    if (itr.Current.IsWindowDelete())
                    {
                        continue;
                    }
                    itr.Current.Work();
                }
                _DispatchMouseEvent();
                _ArrangeWindow();
            }

            public virtual void Render()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.SetLightingEnable(false);
                graphics.SetZBufferEnable(false);
                graphics.SetZWriteEnalbe(false);
                graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ALPHA);
                LinkedList<ref_count_ptr<DxWindow>>.reverse_iterator itr = new LinkedList<ref_count_ptr<DxWindow>>.reverse_iterator();
                for (itr = listWindow_.rbegin(); itr != listWindow_.rend(); itr++)
                {
                    if ((*itr) == null)
                    {
                        continue;
                    }
                    if (itr.IsWindowDelete())
                    {
                        continue;
                    }
                    if (!itr.IsWindowVisible())
                    {
                        continue;
                    }
                    itr.Render();
                }
            }

            public void SetAllWindowEnable(bool bEnable)
            {
                LinkedList<ref_count_ptr<DxWindow>>.Enumerator itr;
                for (itr = listWindow_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current.IsWindowDelete())
                    {
                        continue;
                    }
                    itr.Current.SetWindowEnable(bEnable);
                }
                listLockID_.Clear();
            }

            public void SetWindowEnableWithoutArgumentWindow(bool bEnable, DxWindow window)
            {
                DxWindow parent = window;
                while (parent.windowParent_ != null)
                {
                    parent = parent.windowParent_;
                }
                int id = parent.GetID();

                if (bEnable)
                {
                    bool bError = false;
                    int idLock = -1;
                    if (listLockID_.Count > 0)
                    {
                        idLock = *listLockID_.GetEnumerator();
                        if (id != idLock)
                        {
                            bError = true;
                        }

                        listLockID_.RemoveFirst();
                        if (listLockID_.Count > 0)
                        {
                            id = *listLockID_.GetEnumerator();
                        }
                    }
                    else
                    {
                        return;
                    }

                    if (bError)
                    {
                        throw new gstd.wexception(StringUtility.Format("DxWindow���b�N���s���ł�:id[%d] idLock[%d]", id, idLock).c_str());
                    }
                }
                else
                {
                    LinkedList<int>.Enumerator itr;
                    for (itr = listLockID_.GetEnumerator(); itr.MoveNext();)
                    {
                        if (itr.Current != id)
                        {
                            continue;
                        }
                        return;
                    }
                    listLockID_.AddFirst(id);
                }

                LinkedList<ref_count_ptr<DxWindow>>.Enumerator itr;
                for (itr = listWindow_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current.IsWindowDelete())
                    {
                        continue;
                    }
                    if (id != -1 && itr.Current.GetID() == id)
                    {
                        continue;
                    }
                    itr.Current.SetWindowEnable(bEnable);
                }
            }

            public gstd.ref_count_ptr<DxWindow> GetIntersectedWindow()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                if (graphics == null)
                {
                    return null;
                }

                DirectInput input = DirectInput.GetBase();
                if (input == null)
                {
                    return null;
                }

                gstd.ref_count_ptr<DxWindow> res = null;
                POINT posMouse = graphics.GetMousePosition();
                LinkedList<ref_count_ptr<DxWindow>>.Enumerator itr;
                for (itr = listWindow_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current.IsWindowDelete())
                    {
                        continue;
                    }
                    if (!itr.Current.IsWindowEnable())
                    {
                        continue;
                    }
                    if (!itr.Current.IsWindowVisible())
                    {
                        continue;
                    }
                    res.CopyFrom(GetIntersectedWindow(posMouse, itr.Current));
                    if (res != null)
                    {
                        break;
                    }
                }
                return new gstd.ref_count_ptr<DxWindow>(res);
            }

            public gstd.ref_count_ptr<DxWindow> GetIntersectedWindow(POINT pos, gstd.ref_count_ptr<DxWindow> parent = null)
            {
                gstd.ref_count_ptr<DxWindow> res = null;
                if (parent == null)
                {
                    parent = *listWindow_.GetEnumerator();
                }
                if (parent == null)
                {
                    return null;
                }

                if (!parent.IsWindowEnable() || !parent.IsWindowVisible() || parent.IsWindowDelete())
                {
                    return null;
                }

                LinkedList<gstd.ref_count_ptr<DxWindow>>.Enumerator itr;
                for (itr = parent.listWindowChild_.begin(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current.IsWindowDelete())
                    {
                        continue;
                    }
                    if (!itr.Current.IsWindowEnable())
                    {
                        continue;
                    }
                    if (!itr.Current.IsWindowVisible())
                    {
                        continue;
                    }

                    res.CopyFrom(GetIntersectedWindow(pos, itr.Current));
                    if (res != null)
                    {
                        break;
                    }

                    bool bIntersect = itr.Current.IsIntersected(pos);
                    if (!bIntersect)
                    {
                        continue;
                    }
                    res = itr.Current;
                    break;
                }

                if (res == null)
                {
                    res.CopyFrom(parent.IsIntersected(pos) ? parent : null);
                }

                return new gstd.ref_count_ptr<DxWindow>(res);
            }
    }

    /**********************************************************
    //DxWindow
    **********************************************************/
    public class DxWindow : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DxWindowManager;
            private static LinkedList<int> listWndId_ = new LinkedList<int>();
            protected DxWindowManager manager_;
            protected int idWindow_;
            protected bool bWindowDelete_; // �폜�t���O
            protected bool bWindowEnable_;
            protected bool bWindowVisible_;
            protected RECT rectWindow_ = new RECT(); // �E�B���h�E���΍��W
            protected DxWindow windowParent_; // �e�E�B���h�E
            protected LinkedList<gstd.ref_count_ptr<DxWindow>> listWindowChild_ = new LinkedList<gstd.ref_count_ptr<DxWindow>>(); // �q�E�B���h�E

            protected D3DCOLOR color_ = new D3DCOLOR();
            protected gstd.ref_count_ptr<Sprite2D> spriteFrame_ = new gstd.ref_count_ptr<Sprite2D>();
            protected int typeRenderFrame_;

            protected void _WorkChild()
            {
                if (bWindowDelete_)
                {
                    return;
                }
                LinkedList<ref_count_ptr<DxWindow>>.Enumerator itr;
                for (itr = listWindowChild_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current.IsWindowDelete())
                    {
                        continue;
                    }
                    itr.Current.Work();
                }
            }

            protected void _RenderChild()
            {
                if (!bWindowVisible_ || bWindowDelete_)
                {
                    return;
                }
                LinkedList<ref_count_ptr<DxWindow>>.Enumerator itr;
                for (itr = listWindowChild_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current.IsWindowDelete())
                    {
                        continue;
                    }
                    if (!itr.Current.IsWindowVisible())
                    {
                        continue;
                    }
                    itr.Current.Render();
                }
            }

            protected void _DispatchEventToChild(gstd.ref_count_ptr<DxWindowEvent> @event)
            {
                if (!bWindowEnable_ || bWindowDelete_)
                {
                    return;
                }
                LinkedList<ref_count_ptr<DxWindow>>.Enumerator itr;
                for (itr = listWindowChild_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current.IsWindowDelete())
                    {
                        continue;
                    }
                    if (!itr.Current.IsWindowEnable())
                    {
                        continue;
                    }
                    itr.Current.DispatchedEvent(@event);
                }
            }

            protected virtual void _RenderFrame()
            {
                if (spriteFrame_ == null)
                {
                    return;
                }

                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.SetBlendMode((uint)typeRenderFrame_);
                int alphaWindow = GetAbsoluteAlpha();
                int alphaSprite = ColorAccess.GetColorA(spriteFrame_.GetVertex(0).diffuse_color);
                int alpha = System.Math.Min(255, alphaWindow * alphaSprite / 255);
                RECT rcDest = GetAbsoluteWindowRect();
                RECT_D drcDest = directx.GlobalMembers.GetRectD(rcDest);
                spriteFrame_.SetDestinationRect(drcDest);
                spriteFrame_.SetAlpha(alpha);
                spriteFrame_.Render();
                spriteFrame_.SetAlpha(alphaSprite);

                graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ALPHA);
            }

            public DxWindow()
            {
                windowParent_ = null;
                bWindowDelete_ = false;
                bWindowEnable_ = true;
                bWindowVisible_ = true;
                SetRect(rectWindow_, 0, 0, 0, 0);
                color_ = D3DCOLOR_ARGB(255, 255, 255, 255);

                // �󂢂Ă���WindowID�擾
                GlobalMembers.listWndId_.sort();
                int idFree = 0;
                LinkedList<int>.Enumerator itr;
                for (itr = GlobalMembers.listWndId_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current != idFree)
                    {
                        break;
                    }
                    idFree++;
                }
                idWindow_ = idFree;
                GlobalMembers.listWndId_.AddLast(idFree);

                typeRenderFrame_ = DirectGraphics.MODE_BLEND_ALPHA;
            }

            public virtual void Dispose()
            {
                // WindowID���
                LinkedList<int>.Enumerator itr;
                for (itr = GlobalMembers.listWndId_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current != idWindow_)
                    {
                        continue;
                    }
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                    GlobalMembers.listWndId_.erase(itr);
                    break;
                }
            }

            public virtual void DeleteWindow()
            {
                bWindowDelete_ = true;
                if (windowParent_ == null && manager_ != null)
                {
                    manager_.DeleteWindowFromID(idWindow_);
                }

                LinkedList<gstd.ref_count_ptr<DxWindow>>.Enumerator itr;
                for (itr = listWindowChild_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current.IsWindowDelete())
                    {
                        continue;
                    }
                    itr.Current.DeleteWindow();
                }
            }

            public bool IsWindowDelete()
            {
                return bWindowDelete_;
            }
            public void Dispose()
            {
                windowParent_ = null;
                listWindowChild_.Clear();
            }

            public virtual void AddedManager()
            {
            }
            public void AddChild(gstd.ref_count_ptr<DxWindow> window)
            {
                LinkedList<ref_count_ptr<DxWindow>>.Enumerator itr;
                for (itr = listWindowChild_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current == window)
                    {
                        return; // ���d�o�^�͂����Ȃ�
                    }
                }
                window.manager_ = manager_;
                window.windowParent_ = this;
                listWindowChild_.AddLast(window);
                window.AddedManager();
            }

            public virtual void Work()
            {
                _WorkChild();
            }
            public virtual void Render()
            {
                _RenderFrame();
                _RenderChild();
            }
            public virtual void DispatchedEvent(gstd.ref_count_ptr<DxWindowEvent> @event)
            {
                _DispatchEventToChild(new gstd.ref_count_ptr<DxWindowEvent>(@event));
            }

            public virtual void IntersectMouseCursor()
            {
            }

            public int GetID()
            {
                return idWindow_;
            }
            public virtual bool IsIntersected(POINT pos)
            {
                RECT rect = GetAbsoluteWindowRect();
                return pos.x >= rect.left && pos.x <= rect.right && pos.y >= rect.top && pos.y <= rect.bottom;
            }

            public void SetWindowRect(RECT rect)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rectWindow_ = rect;
                rectWindow_.CopyFrom(rect);
            }
            public RECT GetWindowRect()
            {
                return new RECT(rectWindow_);
            }
            public RECT GetAbsoluteWindowRect()
            {
                RECT res = new RECT(rectWindow_);
                DxWindow parent = windowParent_;
                while (parent != null)
                {
                    RECT rect = parent.rectWindow_;
                    res.left += rect.left;
                    res.right += rect.left;
                    res.top += rect.top;
                    res.bottom += rect.top;
                    parent = parent.windowParent_;
                }
                return new RECT(res);
            }

            public virtual void SetWindowEnable(bool bEnable)
            {
                bWindowEnable_ = bEnable;
            }
            public virtual bool IsWindowEnable()
            {
                return bWindowEnable_;
            }
            public virtual void SetWindowVisible(bool bVisible)
            {
                bWindowVisible_ = bVisible;
            }
            public virtual bool IsWindowVisible()
            {
                return bWindowVisible_;
            }
            public virtual bool IsWindowExists(int id)
            {
                if (bWindowDelete_)
                {
                    return false;
                }
                bool res = false;
                if (GetID() == id)
                {
                    return true;
                }
                LinkedList<ref_count_ptr<DxWindow>>.Enumerator itr;
                for (itr = listWindowChild_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current.IsWindowDelete())
                    {
                        continue;
                    }
                    res |= itr.Current.IsWindowExists(id);
                    if (res)
                    {
                        break;
                    }
                }
                return res;
            }

            public void SetAlpha(int alpha)
            {
                ColorAccess.SetColorA(color_, alpha);
            }
            public int GetAlpha()
            {
                return ColorAccess.GetColorA(color_);
            }
            public int GetAbsoluteAlpha()
            {
                int res = GetAlpha();
                DxWindow parent = windowParent_;
                while (parent != null)
                {
                    res = res * parent.GetAlpha() / 255;
                    parent = parent.windowParent_;
                }
                return res;
            }

            public void SetFrameSprite(gstd.ref_count_ptr<Sprite2D> sprite)
            {
                spriteFrame_.CopyFrom(sprite);
            }
    }

    /**********************************************************
    //DxLabel
    **********************************************************/
    public class DxLabel : DxWindow
    {
            protected gstd.ref_count_ptr<DxText> text_ = new gstd.ref_count_ptr<DxText>();


            /**********************************************************
            //DxLabel
            **********************************************************/
            public DxLabel()
            {
            }

            public override void Work()
            {
            }

            public override void Render()
            {
                _RenderFrame();
                if (text_ != null)
                {
                    text_.Render();
                }
                _RenderChild();
            }

            public void SetText(string str)
            {
                if (text_ == null)
                {
                    RECT rect = GetAbsoluteWindowRect();
                    int width = rect.right - rect.left;
                    int height = rect.bottom - rect.top;
                    text_ = new DxText();
                    text_.SetHorizontalAlignment(DxText.ALIGNMENT_CENTER);
                    text_.SetFontSize(System.Math.Min(width, height));
                    text_.SetPosition(rect.top, rect.bottom);
                }
                text_.SetText(str);
            }

            public void SetText(ref_count_ptr<DxText> text, bool bArrange = false)
            {
                text_ = text;

                if (bArrange)
                {
                    int sizeFont = text.GetFontSize();
                    RECT rect = GetAbsoluteWindowRect();
                    int width = rect.right - rect.left;
                    int height = rect.bottom - rect.top;
                    text_.SetMaxWidth(width);
                    text_.SetHorizontalAlignment(DxText.ALIGNMENT_CENTER);
                    text_.SetPosition(rect.left, rect.top + (height - sizeFont) / 2);
                }
            }
    }

    /**********************************************************
    //DxButton
    **********************************************************/
    public class DxButton : DxLabel
    {
            protected bool bIntersected_;
            protected bool bSelected_;

            /**********************************************************
            //DxButton
            **********************************************************/
            public DxButton()
            {
                bIntersected_ = false;
                bSelected_ = false;
            }

            public override void Work()
            {
                if (manager_ == null)
                {
                    return;
                }
                if (IsWindowDelete())
                {
                    return;
                }
                ref_count_ptr<DxWindow> wnd = manager_.GetIntersectedWindow();

                bool bOldIntersected = bIntersected_;
                bIntersected_ = wnd != null && wnd.GetID() == GetID();
                if (!bOldIntersected && bIntersected_)
                {
                    IntersectMouseCursor();
                }
                _WorkChild();
            }

            public override void Render()
            {
                _RenderFrame();
                if (text_ != null)
                {
                    text_.Render();
                }
                _RenderChild();

                if (bIntersected_)
                {
                    RenderIntersectedFrame();
                }
                if (bSelected_)
                {
                    RenderSelectedFrame();
                }
            }

            public virtual void RenderIntersectedFrame()
            {
                if (!bIntersected_)
                {
                    return;
                }
                if (!IsWindowEnable())
                {
                    return;
                }
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ADD_RGB);
                Sprite2D sprite = new Sprite2D();
                int alpha = 64;
                RECT_D rcSrc = new RECT_D() { left = 1, top = 1, right = 2, bottom = 2 };
                RECT_D rcDest = directx.GlobalMembers.GetRectD(GetAbsoluteWindowRect());
                sprite.SetVertex(rcSrc, rcDest, D3DCOLOR_ARGB(alpha, alpha, alpha, alpha));
                sprite.Render();
                graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ALPHA);
            }

            public virtual void RenderSelectedFrame()
            {
                if (!bSelected_)
                {
                    return;
                }
                if (!IsWindowEnable())
                {
                    return;
                }
                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ADD_RGB);
                Sprite2D sprite = new Sprite2D();
                int alpha = 64;
                RECT_D rcSrc = new RECT_D() { left = 1, top = 1, right = 2, bottom = 2 };
                RECT_D rcDest = directx.GlobalMembers.GetRectD(GetAbsoluteWindowRect());
                sprite.SetVertex(rcSrc, rcDest, D3DCOLOR_ARGB(alpha, alpha, alpha, alpha));
                sprite.Render();
                graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ALPHA);
            }

            public bool IsIntersected()
            {
                return bIntersected_;
            }
            public bool IsSelected()
            {
                return bSelected_;
            }
            public void SetSelected(bool bSelected)
            {
                bSelected_ = bSelected;
            }
    }

    /**********************************************************
    //DxMessageBox
    **********************************************************/
    public class DxMessageBox : DxWindow
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum2
            {
                INDEX_NULL = -1
            }

            protected int index_;
            protected gstd.ref_count_ptr<DxText> text_ = new gstd.ref_count_ptr<DxText>();
            protected List<gstd.ref_count_ptr<DxButton>> listButton_ = new List<gstd.ref_count_ptr<DxButton>>();


            /**********************************************************
            //DxMessageBox
            **********************************************************/
            public DxMessageBox()
            {
                index_ = (int)AnonymousEnum2.INDEX_NULL;
            }

            public override void DispatchedEvent(gstd.ref_count_ptr<DxWindowEvent> @event)
            {
                _DispatchEventToChild(new gstd.ref_count_ptr<DxWindowEvent>(@event));

            }

            public void SetText(ref_count_ptr<DxText> text)
            {
                text_ = text;
            }

            public void SetButton(List<gstd.ref_count_ptr<DxButton>> listButton)
            {
                listButton_ = new List<gstd.ref_count_ptr<DxButton>>(listButton);
            }

            public int GetSelectedIndex()
            {
                return index_;
            }
            public void UpdateWindowRect()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                int scrnWidth = graphics.GetScreenWidth();
                int scrnHeight = graphics.GetScreenHeight();

                int margin = 16;
                RECT rcWnd = GetWindowRect();
                int wndWidth = rcWnd.right - rcWnd.left;
                text_.SetMaxWidth(wndWidth - margin * 2);
                text_.SetPosition(rcWnd.left + margin, rcWnd.top + margin);
                gstd.ref_count_ptr<DxTextInfo> textInfo = text_.GetTextInfo();
                int textHeight = textInfo.GetTotalHeight();

                int iButton = 0;
                int totalButtonWidth = 0;
                int buttonHeight = 0;
                for (iButton = 0 ; iButton < listButton_.Count ; iButton++)
                {
                    RECT rect = listButton_[iButton].GetWindowRect();
                    totalButtonWidth += rect.right - rect.left + margin;
                    buttonHeight = System.Math.Max(buttonHeight, rect.bottom - rect.top);
                }

                int leftButton = wndWidth / 2 - totalButtonWidth / 2;
                int topButton = textHeight + margin * 2;
                for (iButton = 0 ; iButton < listButton_.Count ; iButton++)
                {
                    RECT rcButton = listButton_[iButton].GetWindowRect();
                    int width = rcButton.right - rcButton.left;
                    int height = rcButton.bottom - rcButton.top;
                    RECT rect = new RECT(leftButton, topButton, leftButton + width, topButton + height);
                    leftButton += width + margin;
                    listButton_[iButton].SetWindowRect(rect);
                }

                RECT rect = new RECT(rcWnd.left, rcWnd.top, rcWnd.right, rcWnd.top + textHeight + buttonHeight + margin * 3);
                SetWindowRect(new RECT(rect));
            }
    }
}