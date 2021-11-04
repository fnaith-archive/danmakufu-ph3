using System;
using System.Collections.Generic;

/**********************************************************
//MenuTask
**********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class MenuItem;
public class MenuTask : System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        protected enum AnonymousEnum
        {
            CURSOR_NONE = -1,
            CURSOR_LEFT = 0,
            CURSOR_RIGHT,
            CURSOR_UP,
            CURSOR_DOWN,
            CURSOR_COUNT = 4
        }
        protected CriticalSection cs_ = new CriticalSection();
        protected bool bActive_;
        protected List<ref_count_ptr<MenuItem>> item_ = new List<ref_count_ptr<MenuItem>>();

        protected List<int> cursorFrame_ = new List<int>();
        protected int cursorX_;
        protected int cursorY_;
        protected int pageCurrent_;
        protected int pageMaxX_;
        protected int pageMaxY_;
        protected bool bPageChangeX_;
        protected bool bPageChangeY_;
        protected bool bWaitedKeyFree_;

        protected int _GetCursorKeyState()
        {
            EDirectInput input = EDirectInput.GetInstance();
            int res = (int)AnonymousEnum.CURSOR_NONE;
            int[] vkeys = { EDirectInput.KEY_LEFT, EDirectInput.KEY_RIGHT, EDirectInput.KEY_UP, EDirectInput.KEY_DOWN };
            for (int iKey = 0 ; iKey < (int)AnonymousEnum.CURSOR_COUNT && res == (int)AnonymousEnum.CURSOR_NONE; iKey++)
            {
                int state = input.GetVirtualKeyState(vkeys[iKey]);
                if (state == KEY_PUSH)
                {
                    cursorFrame_[iKey] = 0;
                    res = iKey;
                }
                else if (state == KEY_HOLD)
                {
                    cursorFrame_[iKey]++;
                    if (cursorFrame_[iKey] % 5 == 4 && cursorFrame_[iKey] > 15)
                    {
                        res = iKey;
                    }
                }
            }
            return res;
        }

        protected virtual void _MoveCursor()
        {
            int stateCursor = _GetCursorKeyState();

            if (stateCursor != (int)AnonymousEnum.CURSOR_NONE)
            {
                Lock @lock = new Lock(cs_);
                int pageLast = pageCurrent_;
                int countItem = item_.Count;
                int countCurrentPageItem = GetCurrentPageItemCount();
                int countCurrentPageMaxX = GetCurrentPageMaxX();
                int countCurrentPageMaxY = GetCurrentPageMaxY();
                if (stateCursor == (int)AnonymousEnum.CURSOR_LEFT)
                {
                    cursorX_--;
                    if (cursorX_ < 0)
                    {
                        if (bPageChangeX_)
                        {
                            pageCurrent_--;
                            if (pageCurrent_ <= 0)
                            {
                                pageCurrent_ = GetPageCount();
                            }
                        }
                        cursorX_ = countCurrentPageMaxX;
                    }
                    cursorY_ = Math.Min(cursorY_, GetCurrentPageMaxY());
                }
                else if (stateCursor == (int)AnonymousEnum.CURSOR_RIGHT)
                {
                    cursorX_++;
                    if (cursorX_ > countCurrentPageMaxX)
                    {
                        if (bPageChangeX_)
                        {
                            pageCurrent_++;
                            if (pageCurrent_ > GetPageCount())
                            {
                                pageCurrent_ = 1;
                            }
                        }
                        cursorX_ = 0;
                    }
                    cursorY_ = Math.Min(cursorY_, GetCurrentPageMaxY());
                }
                else if (stateCursor == (int)AnonymousEnum.CURSOR_UP)
                {
                    cursorY_--;
                    if (cursorY_ < 0)
                    {
                        if (bPageChangeY_)
                        {
                            pageCurrent_--;
                            if (pageCurrent_ <= 0)
                            {
                                pageCurrent_ = GetPageCount();
                            }
                        }
                        cursorY_ = countCurrentPageMaxY;
                    }
                }
                else if (stateCursor == (int)AnonymousEnum.CURSOR_DOWN)
                {
                    cursorY_++;
                    if (cursorY_ > countCurrentPageMaxY)
                    {
                        if (bPageChangeY_)
                        {
                            pageCurrent_++;
                            if (pageCurrent_ >= GetPageCount())
                            {
                                pageCurrent_ = 1;
                            }
                        }
                        cursorY_ = 0;
                    }
                }

                if (pageLast != pageCurrent_)
                {
                    // �y�[�W�ύX
                    _ChangePage();
                }
            }
        }

        protected virtual void _ChangePage()
        {
        }

        protected bool _IsWaitedKeyFree()
        {
            return bWaitedKeyFree_;
        }


        /**********************************************************
        //MenuTask
        **********************************************************/
        public MenuTask()
        {
            bActive_ = true;
            cursorFrame_.Resize(AnonymousEnum.CURSOR_COUNT);
            cursorX_ = 0;
            cursorY_ = 0;
            pageMaxX_ = 0;
            pageMaxY_ = 0;
            pageCurrent_ = 1;
            bPageChangeX_ = false;
            bPageChangeY_ = false;
            bWaitedKeyFree_ = false;
        }

        public virtual void Dispose()
        {
        }

        public virtual void Clear()
        {
            item_.Clear();
            cursorX_ = 0;
            cursorY_ = 0;
        }

        public virtual void Work()
        {
            if (!bActive_)
            {
                bWaitedKeyFree_ = false;
                return;
            }

            EDirectInput input = EDirectInput.GetInstance();
            if (input.GetVirtualKeyState(EDirectInput.KEY_OK) == KEY_FREE && input.GetVirtualKeyState(EDirectInput.KEY_CANCEL) == KEY_FREE)
            {
                bWaitedKeyFree_ = true;
            }

            _MoveCursor();

            {
                Lock @lock = new Lock(cs_);
                int indexTop = ((pageMaxX_ + 1) * (pageMaxY_ + 1)) * (pageCurrent_ - 1);
                int countCurrentPageItem = GetCurrentPageItemCount();
                for (int iItem = 0 ; iItem < countCurrentPageItem ; iItem++)
                {
                    int index = indexTop + iItem;
                    ref_count_ptr<MenuItem> item = item_[index];
                    if (item == null)
                    {
                        continue;
                    }
                    item.Work();
                }
            }
        }

        public virtual void Render()
        {
            {
                Lock @lock = new Lock(cs_);
                int indexTop = ((pageMaxX_ + 1) * (pageMaxY_ + 1)) * (pageCurrent_ - 1);
                int countCurrentPageItem = GetCurrentPageItemCount();
                for (int iItem = 0 ; iItem < countCurrentPageItem ; iItem++)
                {
                    int index = indexTop + iItem;
                    ref_count_ptr<MenuItem> item = item_[index];
                    if (item == null)
                    {
                        continue;
                    }
                    item.Render();
                }
            }
        }

        public void SetActive(bool bActive)
        {
            bActive_ = bActive;
        }

        public virtual void AddMenuItem(ref_count_ptr<MenuItem> item)
        {
            {
                Lock @lock = new Lock(cs_);
                item.menu_ = this;
                item_.Add(item);
            }
        }

        public int GetPageCount()
        {
            int res = 0;
            {
                Lock @lock = new Lock(cs_);
                int countOnePage = (pageMaxX_ + 1) * (pageMaxY_ + 1);
                int countItem = item_.Count;
                res = Math.Max(1, (countItem - 1) / countOnePage + 1);
            }
            return res;
        }

        public int GetSelectedItemIndex()
        {
            int res = -1;
            {
                Lock @lock = new Lock(cs_);
                int indexTop = ((pageMaxX_ + 1) * (pageMaxY_ + 1)) * (pageCurrent_ - 1);
                res = indexTop + cursorX_ + cursorY_ * (pageMaxX_ + 1);
            }
            return res;
        }

        public ref_count_ptr<MenuItem> GetSelectedMenuItem()
        {
            ref_count_ptr<MenuItem> res = null;
            {
                Lock @lock = new Lock(cs_);
                int index = GetSelectedItemIndex();
                if (index >= 0 && index < item_.Count)
                {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res = item_[index];
                    res.CopyFrom(item_[index]);
                }
            }
            return new ref_count_ptr<MenuItem>(res);
        }

        public int GetCurrentPageItemCount()
        {
            int countItem = item_.Count;
            int countCurrentPageItem = countItem - ((pageMaxX_ + 1) * (pageMaxY_ + 1)) * (pageCurrent_ - 1);
            countCurrentPageItem = Math.Min(countCurrentPageItem, (pageMaxX_ + 1) * (pageMaxY_ + 1));
            return countCurrentPageItem;
        }

        public int GetCurrentPageMaxX()
        {
            int countCurrentPageItem = GetCurrentPageItemCount();
            int countCurrentPageMaxX = Math.Min(pageMaxX_, Math.Max(0, countCurrentPageItem - 1));
            return countCurrentPageMaxX;
        }

        public int GetCurrentPageMaxY()
        {
            int countCurrentPageItem = GetCurrentPageItemCount();
            int countCurrentPageMaxY = Math.Min(pageMaxY_, Math.Max(0, (countCurrentPageItem - 1) / (pageMaxX_ + 1)));
            return countCurrentPageMaxY;
        }
}
public class MenuItem : System.IDisposable
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//    friend MenuTask;
        protected MenuTask menu_;
        public MenuItem()
        {
        }
        public virtual void Dispose()
        {
        }
        public virtual void Work()
        {
        }
        public virtual void Render()
        {
        }
}
public class TextLightUpMenuItem : MenuItem
{
        protected int frameSelected_;

        protected void _WorkSelectedItem()
        {
            if (menu_.GetSelectedMenuItem() == this)
            {
                frameSelected_++;
            }
            else
            {
                frameSelected_ = 0;
            }
        }

        protected int _GetSelectedItemAlpha()
        {
            int res = 0;
            if (menu_.GetSelectedMenuItem() == this)
            {
                int cycle = 60;
                int alpha = frameSelected_ % cycle;
                if (alpha < cycle / 2)
                {
                    alpha = (int)255 * (float)((float)(cycle / 2 - alpha) / (float)(cycle / 2));
                }
                else
                {
                    alpha = (int)255 * (float)((float)(alpha - cycle / 2) / (float)(cycle / 2));
                }
                res = alpha;
            }
            return res;
        }


        // TextLightUpMenuItem
        public TextLightUpMenuItem()
        {
            frameSelected_ = 0;
        }

}
