using gstd;
using System;
using System.Collections.Generic;

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)

namespace gstd
{
    /**********************************************************
    //WindowBase
    **********************************************************/
    public class WindowBase : System.IDisposable
    {
            public class Style
            {
                    protected uint style_;
                    protected uint styleEx_;
                    public Style()
                    {
                        style_ = 0;
                        styleEx_ = 0;
                    }
                    public virtual void Dispose()
                    {
                    }
                    public uint GetStyle()
                    {
                        return style_;
                    }
                    public uint SetStyle(uint style)
                    {
                        style_ |= style;
                        return style_;
                    }
                    public uint RemoveStyle(uint style)
                    {
                        style_ &= ~style;
                        return style_;
                    }

                    public uint GetStyleEx()
                    {
                        return styleEx_;
                    }
                    public uint SetStyleEx(uint style)
                    {
                        styleEx_ |= style;
                        return styleEx_;
                    }
                    public uint RemoveStyleEx(uint style)
                    {
                        styleEx_ &= ~style;
                        return styleEx_;
                    }
            }
            private static LinkedList<int> listWndId_ = new LinkedList<int>();
            private static CriticalSection lock_ = new CriticalSection();

            protected IntPtr hWnd_;
            protected WNDPROC oldWndProc_ = new WNDPROC(); // �E�B���h�E�v���V�[�W���A�h���X
            protected int idWindow_;

// C++ TO C# CONVERTER NOTE: CALLBACK is not available in C#:
// ORIGINAL LINE: static int CALLBACK _StaticWindowProcedure(System.IntPtr hWnd, uint uMsg, System.IntPtr wParam, System.IntPtr lParam)
            protected static int _StaticWindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
            {
                WindowBase tWnd = (WindowBase)global::GetProp(hWnd, GlobalMembers.PROP_THIS);

                // �擾�ł��Ȃ������Ƃ��̏���
                if (tWnd == null)
                {
                    if ((uMsg == WM_CREATE) || (uMsg == WM_NCCREATE))
                    {
                        tWnd = (WindowBase)((LPCREATESTRUCT)lParam).lpCreateParams;
                    }
                    else if (uMsg == WM_INITDIALOG)
                    {
                        tWnd = (WindowBase)lParam;
                    }
                    if (tWnd != null)
                    {
                        tWnd.Attach(hWnd);
                    }
                }

                if (tWnd != null)
                {
                    int lResult = tWnd._WindowProcedure(hWnd, uMsg, wParam, lParam);
                    if (uMsg == WM_DESTROY)
                    {
                        tWnd.Detach();
                    }
                    return lResult;
                }

                // �_�C�A���O�ƃE�B���h�E�ŕԂ��l�𕪂���
                return global::GetWindowLong(hWnd, DWL_DLGPROC) ? false : global::DefWindowProc(hWnd, uMsg, wParam, lParam);
            }

            protected int _CallPreviousWindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
            {
                if (oldWndProc_ != null)
                {
                    return CallWindowProc(oldWndProc_, hWnd, uMsg, wParam, lParam);
                }

                // �_�C�A���O�ƃE�B���h�E�ŕԂ��l�𕪂���
                return global::GetWindowLong(hWnd, DWL_DLGPROC) ? false : global::DefWindowProc(hWnd, uMsg, wParam, lParam);
            }

            protected virtual int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
            {
                return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
            }

            public WindowBase()
            {
                hWnd_ = null;
                oldWndProc_ = null;

                {
                // �󂢂Ă���WindowID�擾
                    Lock @lock = new Lock(lock_);
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
                }

            }

            public virtual void Dispose()
            {
                this.Detach();

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

            public IntPtr GetWindowHandle()
            {
                return hWnd_;
            }
            public bool IsDialog()
            {
                return global::GetWindowLong(hWnd_, DWL_DLGPROC) != 0;
            }

            public bool Attach(IntPtr hWnd)
            {
                if (!hWnd)
                {
                    return false;
                }
                hWnd_ = hWnd;
                // �_�C�A���O���E�B���h�E���𔻒�
                int typeProc = global::GetWindowLong(hWnd, DWL_DLGPROC) != 0 ? DWL_DLGPROC : GWL_WNDPROC;

                // �v���p�e�B�ɃC���X�^���X��o�^
                global::SetProp(hWnd_, GlobalMembers.PROP_THIS, (IntPtr)this);

                // �����̃E�B���h�E��T�u�N���X��
                if (global::GetWindowLong(hWnd_, typeProc) != (int)_StaticWindowProcedure)
                {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: oldWndProc_ = (WNDPROC)global::SetWindowLong(hWnd_, typeProc, (int)_StaticWindowProcedure);
                    oldWndProc_.CopyFrom((WNDPROC)global::SetWindowLong(hWnd_, typeProc, (int)_StaticWindowProcedure));
                }
                return true;
            }

            public bool Detach()
            {
                if (hWnd_ == null)
                {
                    return false;
                }

                // �T�u�N���X������
                if (oldWndProc_ != null)
                {
                    int typeProc = global::GetWindowLong(hWnd_, DWL_DLGPROC) != 0 ? DWL_DLGPROC : GWL_WNDPROC;
                    global::SetWindowLong(hWnd_, typeProc, (uint)oldWndProc_);
                    oldWndProc_ = null;
                }
                global::RemoveProp(hWnd_, GlobalMembers.PROP_THIS);
                return true;
            }

            public int GetWindowId()
            {
                return idWindow_;
            }

            public virtual void SetBounds(int x, int y, int width, int height)
            {
                global::MoveWindow(hWnd_, x, y, width, height, true);
            }
            public RECT GetClientRect()
            {
                RECT rect = new RECT();
                global::GetClientRect(hWnd_, rect);
                return new RECT(rect);
            }
            public int GetClientX()
            {
                return GetClientRect().left;
            }
            public int GetClientY()
            {
                return GetClientRect().top;
            }
            public int GetClientWidth()
            {
                RECT rect = GetClientRect();
                return rect.right - rect.left;
            }
            public int GetClientHeight()
            {
                RECT rect = GetClientRect();
                return rect.bottom - rect.top;
            }

            public void SetWindowEnable(bool bEnable)
            {
                global::EnableWindow(hWnd_, bEnable);
            }
            public void SetWindowVisible(bool bVisible)
            {
                global::ShowWindow(hWnd_, bVisible ? SW_SHOW:SW_HIDE);
            }
            public bool IsWindowVisible()
            {
                return global::IsWindowVisible(hWnd_) ? true : false;
            }
            public void SetParentWindow(IntPtr hParentWnd)
            {
                if (hWnd_ != null)
                {
                    global::SetParent(hWnd_, hParentWnd);
                }
            }
            public uint SetWindowStyle(uint style)
            {
                uint prev = GetCurrentWindowStyle();
                uint next = prev | style;
                global::SetWindowLong(hWnd_, GWL_STYLE, next);
                return next;
            }
            public uint RemoveWindowStyle(uint style)
            {
                uint prev = GetCurrentWindowStyle();
                uint next = (uint)(prev&)~style;
                global::SetWindowLong(hWnd_, GWL_STYLE, next);
                return next;
            }
            public uint GetCurrentWindowStyle()
            {
                return GetWindowLong(hWnd_, GWL_STYLE);
            }

            public virtual void LocateParts()
            {
            } // ��ʕ��i�z�u
            public void MoveWindowCenter()
            {
                RECT drect = new RECT();
                RECT mrect = new RECT();
                IntPtr hDesk = global::GetDesktopWindow();
                global::GetWindowRect(hDesk, drect);
                global::GetWindowRect(hWnd_, mrect);
                int tWidth = mrect.right - mrect.left;
                int tHeight = mrect.bottom - mrect.top;
                int left = drect.right / 2 - tWidth / 2;
                int top = drect.bottom / 2 - tHeight / 2;
                global::MoveWindow(hWnd_,left,top,tWidth,tHeight,true);
            }

            public static IntPtr GetTopParentWindow(IntPtr hWnd)
            {
                IntPtr res = hWnd;
                while (true)
                {
                    IntPtr hParent = GetParent(hWnd);
                    if (hParent == null)
                    {
                        break;
                    }
                    res = hParent;
                }
                return res;
            }
    }


    /**********************************************************
    //ModalDialog
    **********************************************************/
    public class ModalDialog : WindowBase
    {
            protected IntPtr hParent_;
            protected bool bEndDialog_;
            protected void _RunMessageLoop()
            {
                bEndDialog_ = false;
                global::EnableWindow(hParent_, false);

                global::ShowWindow(hWnd_, SW_SHOW);

                MSG msg = new MSG();
                while (!bEndDialog_)
                { // ���b�Z�[�W���[�v
                    global::GetMessage(msg, null, 0, 0);
                    if (IsDialog() && hWnd_ && IsDialogMessage(hWnd_, msg))
                    {
                        continue;
                    }

                    global::TranslateMessage(msg);
                    global::DispatchMessage(msg);
                }

                global::EnableWindow(hParent_, true);
                global::SetWindowPos(hParent_, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
                global::BringWindowToTop(hParent_);
                global::SetActiveWindow(hParent_);

            }

            protected void _FinishMessageLoop()
            {
                global::SetWindowPos(hParent_, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
                bEndDialog_ = true;
            }

            public ModalDialog()
            {
                bEndDialog_ = false;
            }

            /**********************************************************
            //ModalDialog
            **********************************************************/
            public void Create(IntPtr hParent, string resource)
            {
                hParent_ = hParent;
                hWnd_ = CreateDialog((IntPtr)GetWindowLong(hParent,GWL_HINSTANCE), resource, hParent,(DLGPROC)this._StaticWindowProcedure);
                this.Attach(hWnd_);
            }
    }

    /**********************************************************
    //WPanel
    **********************************************************/
    public class WPanel : WindowBase
    {
            protected override int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
            {
                switch (uMsg)
                {
                    case WM_SIZE:
                    {
                        LocateParts();
                        break;
                    }
                }
                return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
            }

            /**********************************************************
            //WPanel
            **********************************************************/
            public void Create(IntPtr hWndParent)
            {
                IntPtr hInst = (IntPtr)global::GetWindowLong(hWndParent, GWL_HINSTANCE);

                hWnd_ = global::CreateWindowEx(0, "STATIC", null, WS_CHILD | WS_VISIBLE | WS_CLIPSIBLINGS | WS_CLIPCHILDREN, 0,0,0,0, hWndParent, (IntPtr)GetWindowId(), hInst, null);
                this.Attach(hWnd_);
                this.SetWindowStyle(SS_NOTIFY);
            }
    }

    /**********************************************************
    //WLabel
    **********************************************************/
    public class WLabel : WindowBase
    {
            private int colorText_;
            private int colorBack_;
            private override int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
            {
                switch (uMsg)
                {
                    case WM_CTLCOLORSTATIC:
                case WM_CTLCOLOR:
                {
                        global::SetTextColor((IntPtr)wParam, colorText_);
                        global::SetBkColor((IntPtr)wParam, colorBack_);
            // 			::SetBkMode((HDC)wParam, TRANSPARENT);
                        return (bool).GetStockObject(NULL_BRUSH);
                }
                }
                return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
            }


            /**********************************************************
            //WLabel
            **********************************************************/
            public WLabel()
            {
                colorText_ = RGB(0, 0, 0);
                colorBack_ = GetSysColor(COLOR_WINDOW);
            }

            public void Create(IntPtr hWndParent)
            {
                IntPtr hInst = (IntPtr)global::GetWindowLong(hWndParent, GWL_HINSTANCE);

                hWnd_ = global::CreateWindowEx(0, "STATIC", null, WS_CHILD | WS_VISIBLE, 0,0,0,0, hWndParent, (IntPtr)GetWindowId(), hInst, null);
                this.Attach(hWnd_);
                global::SendMessage(hWnd_, WM_SETFONT, (IntPtr)GetStockObject(DEFAULT_GUI_FONT), MAKELPARAM(false, 0));
            }

            public void SetText(string text)
            {
                if (text == GetText())
                {
                    return;
                }
                global::SetWindowText(hWnd_, text);
            }

            public void SetTextColor(int color)
            {
                colorText_ = color;
                global::InvalidateRect(hWnd_, null, true);
            }

            public void SetBackColor(int color)
            {
                colorBack_ = color;
                global::InvalidateRect(hWnd_, null, true);
            }

            public string GetText()
            {
                if (GetTextLength() == 0)
                {
                    return "";
                }

                string res;
                int count = GetTextLength() + 1;
                res.resize(count);
                global::GetWindowText(hWnd_, res[0], count);
                return res;
            }

            public int GetTextLength()
            {
                return global::GetWindowTextLength(hWnd_);
            }
    }

    /**********************************************************
    //WButton
    **********************************************************/
    public class WButton : WindowBase
    {
            public class Style : WindowBase.Style
            {
            }
            /**********************************************************
            //WButton
            **********************************************************/
            public void Create(IntPtr hWndParent)
            {
                IntPtr hInst = (IntPtr)global::GetWindowLong(hWndParent, GWL_HINSTANCE);
                hWnd_ = global::CreateWindow("BUTTON", "", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON, 0,0,0,0, hWndParent, (IntPtr)GetWindowId(), hInst, null);
                this.Attach(hWnd_);
                global::SendMessage(hWnd_, WM_SETFONT, (IntPtr)GetStockObject(DEFAULT_GUI_FONT), MAKELPARAM(false, 0));
            }

            public void Create(IntPtr hWndParent, WButton.Style style)
            {
                IntPtr hInst = (IntPtr)global::GetWindowLong(hWndParent, GWL_HINSTANCE);

                hWnd_ = global::CreateWindowEx(style.GetStyleEx(), "BUTTON", null, style.GetStyle(), 0,0,0,0, hWndParent, (IntPtr)GetWindowId(), hInst, null);

                this.Attach(hWnd_);
                global::SendMessage(hWnd_, WM_SETFONT, (IntPtr)GetStockObject(DEFAULT_GUI_FONT), MAKELPARAM(false, 0));
            }

            public void SetText(string text)
            {
                global::SetWindowText(hWnd_, text);
            }

            public bool IsChecked()
            {
                bool bCheck = SendMessage(hWnd_, BM_GETCHECK, 0, 0) == BST_CHECKED;
                return bCheck;
            }
    }

    /**********************************************************
    //WGroupBox
    **********************************************************/
    public class WGroupBox : WindowBase
    {

            /**********************************************************
            //WGroupBox
            **********************************************************/
            public void Create(IntPtr hWndParent)
            {
                IntPtr hInst = (IntPtr)global::GetWindowLong(hWndParent, GWL_HINSTANCE);
                hWnd_ = global::CreateWindow("BUTTON", "", WS_CHILD | WS_VISIBLE | BS_GROUPBOX, 0,0,0,0, hWndParent, (IntPtr)GetWindowId(), hInst, null);
                this.Attach(hWnd_);
                global::SendMessage(hWnd_, WM_SETFONT, (IntPtr)GetStockObject(DEFAULT_GUI_FONT), MAKELPARAM(false, 0));
            }

            public void SetText(string text)
            {
                global::SetWindowText(hWnd_, text);
            }
    }

    /**********************************************************
    //WEditBox
    **********************************************************/
    public class WEditBox : WindowBase
    {
            public class Style : WindowBase.Style
            {
            }

            /**********************************************************
            //WEditBox
            **********************************************************/
            public void Create(IntPtr hWndParent, WEditBox.Style style)
            {
                IntPtr hInst = (IntPtr)global::GetWindowLong(hWndParent, GWL_HINSTANCE);

            // 	DWORD style = 0;//ES_MULTILINE|ES_READONLY|ES_AUTOHSCROLL|ES_AUTOVSCROLL|WS_HSCROLL | WS_VSCROLL;
                hWnd_ = global::CreateWindowEx(style.GetStyleEx(), "EDIT", null, style.GetStyle(), 0,0,0,0, hWndParent, (IntPtr)GetWindowId(), hInst, null);

                this.Attach(hWnd_);
                global::SendMessage(hWnd_, WM_SETFONT, (IntPtr)GetStockObject(DEFAULT_GUI_FONT), MAKELPARAM(false, 0));
            }

            public void SetText(string text)
            {
                if (text == GetText())
                {
                    return;
                }
                global::SetWindowText(hWnd_, text);
            }

            public string GetText()
            {
                if (GetTextLength() == 0)
                {
                    return "";
                }

                string res;
                int count = GetTextLength() + 1;
                res.resize(count);
                global::GetWindowText(hWnd_, res[0], count);
                return res;
            }

            public int GetTextLength()
            {
                return global::GetWindowTextLength(hWnd_);
            }

            public int GetMaxTextLength()
            {
                return global::SendMessage(hWnd_, EM_GETLIMITTEXT, 0, 0);
            }
            public void SetMaxTextLength(int length)
            {
                global::SendMessage(hWnd_, EM_SETLIMITTEXT, (IntPtr)length, 0);
            }
    }


    /**********************************************************
    //WListBox
    **********************************************************/
    public class WListBox : WindowBase
    {
            public class Style : WindowBase.Style
            {
            }

            /**********************************************************
            //WListBox
            **********************************************************/
            // http://gurigumi.s349.xrea.com/programming/visualcpp/sdk_dialog_listbox.html
            // http://web.kyoto-inet.or.jp/people/ysskondo/from16/chap17.html
            public void Create(IntPtr hWndParent, WListBox.Style style)
            {
                IntPtr hInst = (IntPtr)global::GetWindowLong(hWndParent, GWL_HINSTANCE);

            // 	DWORD style = 0;//ES_MULTILINE|ES_READONLY|ES_AUTOHSCROLL|ES_AUTOVSCROLL|WS_HSCROLL | WS_VSCROLL;
                hWnd_ = global::CreateWindowEx(style.GetStyleEx(), "LISTBOX", null, style.GetStyle(), 0,0,0,0, hWndParent, (IntPtr)GetWindowId(), hInst, null);

                this.Attach(hWnd_);
                global::SendMessage(hWnd_, WM_SETFONT, (IntPtr)GetStockObject(DEFAULT_GUI_FONT), MAKELPARAM(false, 0));
            }

            public void Clear()
            {
                SendMessage(hWnd_, LB_RESETCONTENT, 0, 0);
            }

            public int GetCount()
            {
                int res = (int)SendMessage(hWnd_, LB_GETCOUNT, 0, 0);
                return res;
            }

            public void SetSelectedIndex(int index)
            {
                SendMessage(hWnd_, LB_SETCURSEL, index, 0);
            }

            public int GetSelectedIndex()
            {
                int res = (int)SendMessage(hWnd_, LB_GETCURSEL, 0, 0);
                return res;
            }

            public void AddString(string str)
            {
                SendMessage(hWnd_, LB_ADDSTRING, 0, (IntPtr)str);
            }

            public void InsertString(int index, string str)
            {
                SendMessage(hWnd_, LB_INSERTSTRING, index, (IntPtr)str);
            }

            public void DeleteString(int index)
            {
                SendMessage(hWnd_, LB_DELETESTRING, index, 0);
            }

            public string GetText(int index)
            {
                string res;
                int length = (int)SendMessage(hWnd_, LB_GETTEXTLEN, index, 0);
                res.resize(length);
                SendMessage(hWnd_, LB_GETTEXT, index, (IntPtr) res[0]);
                return res;
            }
    }

    /**********************************************************
    //WComboBox
    **********************************************************/
    public class WComboBox : WindowBase
    {
            public class Style : WindowBase.Style
            {
            }

            /**********************************************************
            //WComboBox
            **********************************************************/
            public void Create(IntPtr hWndParent, WComboBox.Style style)
            {
                IntPtr hInst = (IntPtr)global::GetWindowLong(hWndParent, GWL_HINSTANCE);

                hWnd_ = global::CreateWindowEx(style.GetStyleEx(), "COMBOBOX", null, style.GetStyle(), 0,0,0,0, hWndParent, (IntPtr)GetWindowId(), hInst, null);

                this.Attach(hWnd_);
                global::SendMessage(hWnd_, WM_SETFONT, (IntPtr)GetStockObject(DEFAULT_GUI_FONT), MAKELPARAM(false, 0));
            }

            public void SetItemHeight(int height)
            {
                global::SendMessage(hWnd_, CB_SETITEMHEIGHT, height, (IntPtr)0);
            }

            public void SetDropDownListWidth(int width)
            {
                global::SendMessage(hWnd_, CB_SETDROPPEDWIDTH, width, (IntPtr)0);
            }

            public void Clear()
            {
                while (GetCount() != 0)
                {
                    global::SendMessage(hWnd_, CB_DELETESTRING, 0, 0);
                }
            }

            public int GetCount()
            {
                return global::SendMessage(hWnd_, CB_GETCOUNT, 0, 0);
            }

            public void SetSelectedIndex(int index)
            {
                global::SendMessage(hWnd_, CB_SETCURSEL, index, 0);
            }

            public int GetSelectedIndex()
            {
                return global::SendMessage(hWnd_, CB_GETCURSEL, 0, 0);
            }

            public string GetSelectedText()
            {
                int index = GetSelectedIndex();
                string buf = new string(new char[256]);
                global::SendMessage(hWnd_, CB_GETLBTEXT, index, (IntPtr)buf);
                string res = buf;
                return res;
            }

            public void AddString(string str)
            {
                global::SendMessage(hWnd_, CB_ADDSTRING, 0, (IntPtr)str);
            }

            public void InsertString(int index, string str)
            {
                SendMessage(hWnd_, CB_INSERTSTRING, index, (IntPtr)str);
            }
    }

    /**********************************************************
    //WListView
    **********************************************************/
    public class WListView : WindowBase
    {
            public class Style : WindowBase.Style
            {
                    protected uint styleListViewEx_;
                    public Style()
                    {
                        styleListViewEx_ = 0;
                    }
                    public uint GetListViewStyleEx()
                    {
                        return styleListViewEx_;
                    }
                    public uint SetListViewStyleEx(uint style)
                    {
                        styleListViewEx_ |= style;
                        return styleListViewEx_;
                    }
                    public uint RemoveListViewStyleEx(uint style)
                    {
                        styleListViewEx_ &= ~style;
                        return styleListViewEx_;
                    }
            }
            /**********************************************************
            //WListView
            **********************************************************/
            public void Create(IntPtr hWndParent, Style style)
            {
                // WS_EX_CLIENTEDGE
                // WS_CHILD | WS_VISIBLE | LVS_REPORT | LVS_SHOWSELALWAYS
                IntPtr hInst = (IntPtr)global::GetWindowLong(hWndParent, GWL_HINSTANCE);
                hWnd_ = global::CreateWindowEx(style.GetStyleEx(), WC_LISTVIEW, null, style.GetStyle(), 0,0,0,0, hWndParent, (IntPtr)GetWindowId(), hInst, null);

                uint styleListViewEx = ListView_GetExtendedListViewStyle(hWnd_);
                styleListViewEx |= style.GetListViewStyleEx();
                ListView_SetExtendedListViewStyle(hWnd_, styleListViewEx);

                this.Attach(hWnd_);
                global::SendMessage(hWnd_, WM_SETFONT, (IntPtr)GetStockObject(DEFAULT_GUI_FONT), MAKELPARAM(false, 0));
            }

            public void Clear()
            {
                ListView_DeleteAllItems(hWnd_);
            }

            public void AddColumn(int cx, int sub, uint fmt, string text)
            {
                LV_COLUMN lvcol = new LV_COLUMN();
                lvcol.mask = LVCF_FMT | LVCF_WIDTH | LVCF_TEXT | LVCF_SUBITEM;
                lvcol.fmt = fmt;
                lvcol.cx = cx;
                lvcol.pszText = (string)text;
                lvcol.iSubItem = sub;
                ListView_InsertColumn(hWnd_, sub, lvcol);
            }

            public void AddColumn(int cx, int sub, string text)
            {
                AddColumn(cx, sub, LVCFMT_LEFT, text);
            }
            public void SetColumnText(int cx, string text)
            {
                LV_COLUMN lvcol = new LV_COLUMN();
                ListView_GetColumn(hWnd_, cx, lvcol);
                lvcol.pszText = (string)text;
                ListView_SetColumn(hWnd_, cx, lvcol);
            }

            public void AddRow(string text)
            {
                LVITEM item = new LVITEM();
                item.mask = LVIF_TEXT | LVIF_PARAM;
                item.iItem = 0;
                item.iSubItem = 0;
                item.pszText = (string)text;
                item.lParam = ListView_GetItemCount(hWnd_);
                ListView_InsertItem(hWnd_, item);
            }

            public void SetText(int row, int column, string text)
            {
                string pre = GetText(row, column);
                if (pre == text)
                {
                    return;
                }

                int count = ListView_GetItemCount(hWnd_);
                for (int iRow = count; iRow <= row ; iRow++)
                {
                    LVITEM item = new LVITEM();
                    item.mask = LVIF_TEXT | LVIF_PARAM;
                    item.iItem = iRow;
                    item.iSubItem = 0;
                    item.pszText = "";
                    item.lParam = iRow;
                    ListView_InsertItem(hWnd_, item);
                }

                LV_ITEM item = new LV_ITEM();
                item.iItem = row;
                item.pszText = (string)text;
                item.iSubItem = column;
                item.mask = LVIF_TEXT;
                ListView_SetItem(hWnd_, item);
            }

            public void DeleteRow(int row)
            {
                ListView_DeleteItem(hWnd_, row);
            }

            public int GetRowCount()
            {
                return ListView_GetItemCount(hWnd_);
            }

            public string GetText(int row, int column)
            {
                string res;
                string buf = new string(new char[256]);
                ListView_GetItemText(hWnd_, row, column, buf, sizeof(char));
                res = buf;
                return res;
            }

            public bool IsExistsInColumn(string value, int column)
            {
                int count = ListView_GetItemCount(hWnd_);
                for (int iRow = 0; iRow <= count ; iRow++)
                {
                    string str = GetText(iRow, column);
                    if (str == value)
                    {
                        return true;
                    }
                }
                return false;
            }

            public int GetIndexInColumn(string value, int column)
            {
                int res = -1;
                if (column == 0)
                {
                    LVFINDINFO info = new LVFINDINFO();
                    ZeroMemory(info, sizeof(LVFINDINFO));
                    info.flags = LVFI_STRING;
                    info.psz = value;
                    res = ListView_FindItem(hWnd_, -1, info);
                }
                else
                {
                    int count = ListView_GetItemCount(hWnd_);
                    for (int iRow = 0; iRow <= count ; iRow++)
                    {
                        string str = GetText(iRow, column);
                        if (str == value)
                        {
                            res = iRow;
                        }
                    }
                }

                return res;
            }

            public void SetSelectedRow(int index)
            {
                ListView_SetItemState(hWnd_, index, LVIS_SELECTED | LVIS_FOCUSED, LVIS_SELECTED | LVIS_FOCUSED);
                ListView_EnsureVisible(hWnd_, index, true);
            }

            public int GetSelectedRow()
            {
                return ListView_GetNextItem(hWnd_, -1, LVNI_SELECTED);
            }

            public void ClearSelection()
            {
                int index = GetSelectedRow();
                if (index >= 0)
                {
                    ListView_SetItemState(hWnd_, index, 0, LVIS_FOCUSED | LVIS_SELECTED);
                }
            }
    }

    /**********************************************************
    //WTreeView
    **********************************************************/
    public class WTreeView : WindowBase
    {
            public class Item
            {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend WTreeView;
                    private IntPtr hTree_;
                    private HTREEITEM hItem_ = new HTREEITEM();
                    // Item
                    public Item()
                    {
                        hItem_ = null;
                    }

                    public virtual void Dispose()
                    {

                    }

                    public ref_count_ptr<WTreeView.Item> CreateChild(WTreeView.ItemStyle style)
                    {
                    // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                        ref_count_ptr<Item> item = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new Item();
                        item.hTree_ = hTree_;

                        TVINSERTSTRUCT tvis = style.GetInsertStruct();
                        tvis.hParent = hItem_;
                        item.hItem_ = TreeView_InsertItem(hTree_, tvis);
                        return new ref_count_ptr<Item>(item);
                    }

                    public void Delete()
                    {
                        TreeView_DeleteItem(hTree_, hItem_);
                    }

                    public void SetText(string text)
                    {
                        if (GetText() == text)
                        {
                            return;
                        }
                        TVITEM tvi = new TVITEM();
                        tvi.mask = TVIF_TEXT;
                        tvi.hItem = hItem_;
                        tvi.pszText = (string)text;
                        TreeView_SetItem(hTree_, tvi);
                    }

                    public string GetText()
                    {
                        string text = new string(new char[256]);
                        ZeroMemory(text, sizeof(char));
                        TVITEM tvi = new TVITEM();
                        tvi.mask = TVIF_TEXT;
                        tvi.hItem = hItem_;
                        tvi.cchTextMax = sizeof(char) - 1;
                        tvi.pszText = text;
                        TreeView_GetItem(hTree_, tvi);
                        return new string(text);
                    }

                    public void SetParam(IntPtr param)
                    {
                        TVITEM tvi = new TVITEM();
                        tvi.mask = TVIF_PARAM;
                        tvi.hItem = hItem_;
                        tvi.lParam = param;
                        TreeView_SetItem(hTree_, tvi);
                    }

                    public IntPtr GetParam()
                    {
                        TVITEM tvi = new TVITEM();
                        tvi.mask = TVIF_PARAM;
                        tvi.hItem = hItem_;
                        TreeView_GetItem(hTree_, tvi);
                        return tvi.lParam;
                    }

                    public LinkedList<ref_count_ptr<WTreeView.Item>> GetChildList()
                    {
                        LinkedList<ref_count_ptr<Item>> res = new LinkedList<new ref_count_ptr<Item>>();
                        HTREEITEM hChild = TreeView_GetChild(hTree_, hItem_);
                        while (true)
                        {
                            if (hChild == null)
                            {
                                break;
                            }

                    // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                            ref_count_ptr<Item> item = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new Item();
                            item.hTree_ = hTree_;
                            item.hItem_ = hChild;
                            res.AddLast(item);

                            hChild = TreeView_GetNextSibling(hTree_, hChild);
                        }

                        return new LinkedList<ref_count_ptr<Item>>(res);
                    }
            }
            public class ItemStyle
            {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend WTreeView;
                    private TVINSERTSTRUCT tvis_ = new TVINSERTSTRUCT();
                    public ItemStyle()
                    {
                        ZeroMemory(tvis_, sizeof(TVINSERTSTRUCT));
                        tvis_.hInsertAfter = TVI_LAST;
                    }
                    public TVINSERTSTRUCT GetInsertStruct()
                    {
                        return tvis_;
                    }
                    public void SetMask(uint mask)
                    {
                        tvis_.item.mask |= mask;
                    }
            }
            public class Style : WindowBase.Style
            {
            }

            public ref_count_ptr<Item> itemRoot_ = new ref_count_ptr<Item>();

            /**********************************************************
            //WTreeView
            **********************************************************/
            public WTreeView()
            {
            }

            public new void Dispose()
            {
                this.Clear();
                base.Dispose();
            }

            public void Create(IntPtr hWndParent, Style style)
            {
                // TVS_HASLINES | TVS_HASBUTTONS | TVS_LINESATROOT
                IntPtr hInst = (IntPtr)global::GetWindowLong(hWndParent, GWL_HINSTANCE);
                hWnd_ = CreateWindowEx(style.GetStyleEx(), WC_TREEVIEW, "", style.GetStyle(), 0, 0, 0, 0, hWndParent, (IntPtr)GetWindowId(), hInst, null);
                this.Attach(hWnd_);
                global::SendMessage(hWnd_, WM_SETFONT, (IntPtr)GetStockObject(DEFAULT_GUI_FONT), MAKELPARAM(false, 0));
            }

            public void Clear()
            {
                itemRoot_ = null;
                TreeView_DeleteAllItems(hWnd_);
            }
            public void CreateRootItem(ItemStyle style)
            {
                this.Clear();

            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                itemRoot_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new Item();
                itemRoot_.hTree_ = hWnd_;

                TVINSERTSTRUCT tvis = style.GetInsertStruct();
                tvis.hParent = TVI_ROOT;
                itemRoot_.hItem_ = TreeView_InsertItem(hWnd_, tvis);
            }

            public ref_count_ptr<Item> GetRootItem()
            {
                return new ref_count_ptr<Item>(itemRoot_);
            }
            public ref_count_ptr<WTreeView.Item> GetSelectedItem()
            {
                HTREEITEM hTreeItem = TreeView_GetSelection(hWnd_);
                if (hTreeItem == null)
                {
                    return null;
                }

            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                ref_count_ptr<Item> res = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new Item();
                res.hTree_ = hWnd_;
                res.hItem_ = hTreeItem;
                return new ref_count_ptr<Item>(res);
            }
    }

    /**********************************************************
    //WTabControll
    **********************************************************/
    public class WTabControll : WindowBase
    {
        private List<ref_count_ptr<WPanel>> vectPanel_ = new List<ref_count_ptr<WPanel>>();
            protected override int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
            {
                switch (uMsg)
                {
                    case WM_SIZE:
                    {
                        LocateParts();
                        break;
                    }
                }
                return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
            }

            /**********************************************************
            //WTabControll
            **********************************************************/
            public new void Dispose()
            {
                vectPanel_.Clear();
                base.Dispose();
            }

            public void Create(IntPtr hWndParent)
            {
                IntPtr hInst = (IntPtr)global::GetWindowLong(hWndParent, GWL_HINSTANCE);
                hWnd_ = global::CreateWindowEx(0, WC_TABCONTROL, null, WS_CHILD | WS_VISIBLE | WS_CLIPSIBLINGS | WS_CLIPCHILDREN, 0,0,0,0, hWndParent, (IntPtr)GetWindowId(), hInst, null);
                this.Attach(hWnd_);
                global::SendMessage(hWnd_, WM_SETFONT, (IntPtr)GetStockObject(DEFAULT_GUI_FONT), MAKELPARAM(false, 0));
                global::SetClassLong(hWnd_, GCL_STYLE, 0);
            }

            public void AddTab(string text)
            {
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                ref_count_ptr<WPanel> panel = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new WPanel();
                this.AddTab(text, new ref_count_ptr<WPanel>(panel));
            }

            public void AddTab(string text, ref_count_ptr<WPanel> panel)
            {
                TC_ITEM item = new TC_ITEM();
                item.mask = TCIF_TEXT;
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to 'const_cast' in C#:
                item.pszText = const_cast<char>(text);
                SendMessage(hWnd_, TCM_INSERTITEM, (IntPtr)vectPanel_.Count, (IntPtr) item);

                vectPanel_.Add(panel);
            }

            public void ShowPage()
            {
                int page = TabCtrl_GetCurSel(hWnd_);
                if (page == -1)
                {
                    return;
                }
                for (int iPanel = 0 ; iPanel < vectPanel_.Count ; iPanel++)
                {
                    vectPanel_[iPanel].SetWindowVisible(false);
                }
                vectPanel_[page].SetWindowVisible(true);
            }

            public int GetCurrentPage()
            {
                return TabCtrl_GetCurSel(hWnd_);
            }
            public void SetCurrentPage(int page)
            {
                TabCtrl_SetCurSel(hWnd_, page);
                ShowPage();
            }
            public ref_count_ptr<WPanel> GetPanel(int page)
            {
                return new ref_count_ptr<WPanel>(vectPanel_[page]);
            }
            public int GetPageCount()
            {
                return vectPanel_.Count;
            }
            public override void LocateParts()
            {
                RECT rect = new RECT();
                global::GetClientRect(hWnd_, rect);
                TabCtrl_AdjustRect(hWnd_, false, rect);

                int wx = rect.left;
                int wy = rect.top;
                int wWidth = rect.right - rect.left;
                int wHeight = rect.bottom - rect.top;

                for (int iPanel = 0;iPanel < vectPanel_.Count;iPanel++)
                {
                    vectPanel_[iPanel].SetBounds(wx + 1, wy + 3, wWidth - 2, wHeight - 5);
                }
            }
    }

    /**********************************************************
    //WStatusBar
    **********************************************************/
    public class WStatusBar : WindowBase
    {

            /**********************************************************
            //WStatusBar
            **********************************************************/
            public void Create(IntPtr hWndParent)
            {
                hWnd_ = CreateStatusWindow(WS_CHILD | WS_VISIBLE | CCS_BOTTOM | SBARS_SIZEGRIP, null, hWndParent, null);
                this.Attach(hWnd_);
                global::SendMessage(hWnd_, WM_SETFONT, (IntPtr)GetStockObject(DEFAULT_GUI_FONT), MAKELPARAM(false, 0));
            }

            public void SetPartsSize(List<int> parts)
            {
                global::SendMessage(hWnd_, SB_SETPARTS, (IntPtr)parts.Count, (IntPtr)(int) parts[0]);
            }

            public void SetText(int pos, string text)
            {
                global::SendMessage(hWnd_, SB_SETTEXT, 0 | pos, (IntPtr)(string)text);
            }

            public void SetBounds(IntPtr wParam, IntPtr lParam)
            {
                global::SendMessage(hWnd_, WM_SIZE, wParam, lParam);
            }
    }

    /**********************************************************
    //WSplitter
    **********************************************************/
    public class WSplitter : WindowBase
    {
            public enum SplitType
            {
                TYPE_VERTICAL,
                TYPE_HORIZONTAL
            }
            protected SplitType type_;
            protected bool bCapture_;
            protected float ratioX_;
            protected float ratioY_;
            protected override int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
            {
                switch (uMsg)
                {
                    case WM_MOUSEMOVE:
                    {
                        if (bCapture_)
                        {
                            IntPtr hWndParent = GetParent(hWnd);
                            POINT pt = new POINT();
                            GetCursorPos(pt);
                            ScreenToClient(hWndParent, pt);

                            RECT rect = new RECT();
                            global::GetClientRect(hWndParent, rect);

                            int width = rect.right - rect.left;
                            int height = rect.bottom - rect.top;
                            if (type_ == SplitType.TYPE_VERTICAL)
                            {
                                ratioX_ = (float)(pt.x) / (float)(rect.right - rect.left);
                                if (ratioX_ <= 0.05f)
                                {
                                    ratioX_ = 0.05f;
                                }
                                if (ratioX_ >= 0.95f)
                                {
                                    ratioX_ = 0.95f;
                                }
                            }
                            else if (type_ == SplitType.TYPE_HORIZONTAL)
                            {
                                ratioY_ = (float)(pt.y) / (float)(rect.bottom - rect.top);
                                if (ratioY_ <= 0.05f)
                                {
                                    ratioY_ = 0.05f;
                                }
                                if (ratioY_ >= 0.95f)
                                {
                                    ratioY_ = 0.95f;
                                }
                            }

                            SendMessage(hWndParent, WM_SIZE, 0, MAKELPARAM(rect.right, rect.bottom));
                        }
                        break;
                    }
                    case WM_SETCURSOR:
                    {
                        RECT rect = new RECT();
                        POINT pt = new POINT();
                        GetCursorPos(pt);
                        global::GetWindowRect(hWnd, rect);
                        if (pt.x >= rect.left && pt.x <= rect.right && pt.y> rect.top && pt.y < rect.bottom)
                        {
                            string cursor = type_ == SplitType.TYPE_VERTICAL ? IDC_SIZEWE : IDC_SIZENS;
                            SetCursor(LoadCursor(null, cursor));
                            SetClassLong(hWnd, GCL_HCURSOR, 0);
                        }
                        else
                        {
                            SetCursor(LoadCursor(null,IDC_ARROW));
                            SetClassLong(hWnd, GCL_HCURSOR, (int)LoadCursor(null,IDC_ARROW));
                        }
                        break;
                    }
                    case WM_LBUTTONDOWN:
                    {
                        RECT rect = new RECT();
                        POINT pt = new POINT();
                        GetCursorPos(pt);
                        global::GetWindowRect(hWnd, rect);
                        if (type_ == SplitType.TYPE_VERTICAL && pt.x >= rect.left && pt.x <= rect.right)
                        {
                            bCapture_ = true;
                            SetCapture(hWnd);
                        }
                        else if (type_ == SplitType.TYPE_HORIZONTAL && pt.y >= rect.top && pt.y <= rect.bottom)
                        {
                            bCapture_ = true;
                            SetCapture(hWnd);
                        }
                        else
                        {
                            bCapture_ = false;
                        }
                        break;
                    }
                    case WM_LBUTTONUP:
                    {
                        SetClassLong(hWnd, GCL_HCURSOR, (int)LoadCursor(null,IDC_ARROW));
                        bCapture_ = false;
                        ReleaseCapture();
                        break;
                    }
                }
                return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
            }


            /**********************************************************
            //WSplitter
            **********************************************************/
            public WSplitter()
            {
                bCapture_ = false;
                ratioX_ = 0.5f;
                ratioY_ = 0.5f;
            }

            public new void Dispose()
            {
                base.Dispose();
            }

            public void Create(IntPtr hWndParent, SplitType type)
            {
                // WS_EX_DLGMODALFRAME
                type_ = type;
                IntPtr hInst = (IntPtr)global::GetWindowLong(hWndParent, GWL_HINSTANCE);
                hWnd_ = global::CreateWindowEx(0, "STATIC", null, WS_CHILD | WS_VISIBLE | WS_CLIPSIBLINGS | WS_CLIPCHILDREN, 0,0,0,0, hWndParent, (IntPtr)GetWindowId(), hInst, null);
                this.Attach(hWnd_);
                this.SetWindowStyle(SS_NOTIFY);
            }

            public void SetRatioX(float ratio)
            {
                ratioX_ = ratio;
            }
            public float GetRatioX()
            {
                return ratioX_;
            }
            public void SetRatioY(float ratio)
            {
                ratioY_ = ratio;
            }
            public float GetRatioY()
            {
                return ratioY_;
            }
    }

    /**********************************************************
    //WindowUtility
    **********************************************************/
    public class WindowUtility
    {

            /**********************************************************
            //WindowUtility
            **********************************************************/
            public static void SetMouseVisible(bool bVisible)
            {
                if (bVisible)
                {
                    while (ShowCursor(true) < 0)
                    {
                    }
                }
                else
                {
                    while (ShowCursor(false) >= 0)
                    {
                    }
                }
            }
    }
}