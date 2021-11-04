using gstd;
using System;
using System.Collections.Generic;

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)

namespace gstd
{
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class FpsControlObject;
    /**********************************************************
    //FpsController
    **********************************************************/
    public abstract class FpsController : System.IDisposable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                FPS_FAST_MODE = 1200
            }
            protected int fps_; // �ݒ肳��Ă���FPS
            protected bool bUseTimer_; // �^�C�}�[����
            protected bool bCriticalFrame_;
            protected bool bFastMode_;

            protected LinkedList<ref_count_weak_ptr<FpsControlObject>> listFpsControlObject_ = new LinkedList<ref_count_weak_ptr<FpsControlObject>>();

            protected int _GetTime()
            {
            // 	int res = ::timeGetTime();

                LARGE_INTEGER nFreq = new LARGE_INTEGER();
                LARGE_INTEGER nCounter = new LARGE_INTEGER();
                QueryPerformanceFrequency(nFreq);
                QueryPerformanceCounter(nCounter);
                int res = (int)((uint)(nCounter.QuadPart * 1000 / nFreq.QuadPart));

                return res;
            }

            protected void _Sleep(int msec)
            {
                global::Sleep(msec);
            /*
            	int time = _GetTime();
            	while(abs(_GetTime() - time) < msec)
            		::Sleep(1);
            */
            }


            /**********************************************************
            //FpsController
            **********************************************************/
            public FpsController()
            {
                fps_ = 60;
                bUseTimer_ = true;
                global::timeBeginPeriod(1);
                bCriticalFrame_ = true;
                bFastMode_ = false;
            }

            public virtual void Dispose()
            {
                global::timeEndPeriod(1);
            }

            public virtual void SetFps(int fps)
            {
                fps_ = fps;
            }
            public virtual int GetFps()
            {
                return fps_;
            }
            public virtual void SetTimerEnable(bool b)
            {
                bUseTimer_ = b;
            }

            public abstract void Wait();
            public virtual bool IsSkip()
            {
                return false;
            }
            public virtual void SetCriticalFrame()
            {
                bCriticalFrame_ = true;
            }
            public abstract float GetCurrentFps();
            public virtual float GetCurrentWorkFps()
            {
                return GetCurrentFps();
            }
            public virtual float GetCurrentRenderFps()
            {
                return GetCurrentFps();
            }
            public bool IsFastMode()
            {
                return bFastMode_;
            }
            public void SetFastMode(bool b)
            {
                bFastMode_ = b;
            }

            public void AddFpsControlObject(ref_count_weak_ptr<FpsControlObject> obj)
            {
                listFpsControlObject_.AddLast(obj);
            }

            public void RemoveFpsControlObject(ref_count_weak_ptr<FpsControlObject> obj)
            {
                LinkedList<ref_count_weak_ptr<FpsControlObject>>.Enumerator itr = listFpsControlObject_.GetEnumerator();
                while (itr.MoveNext())
                {
                    ref_count_weak_ptr<FpsControlObject> tObj = itr.Current;
                    if (obj.GetPointer() == tObj.GetPointer())
                    {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                        listFpsControlObject_.erase(itr);
                        break;
                    }
                }
            }

            public int GetControlObjectFps()
            {
                int res = fps_;
                LinkedList<ref_count_weak_ptr<FpsControlObject>>.Enumerator itr = listFpsControlObject_.GetEnumerator();
                while (itr.MoveNext())
                {
                    ref_count_weak_ptr<FpsControlObject> obj = itr.Current;
                    if (obj.IsExists())
                    {
                        int fps = obj.GetFps();
                        res = Math.Min(res, fps);
                    }
                    else
                    {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                        itr = listFpsControlObject_.erase(itr);
                    }
                }
                return res;
            }
    }

    /**********************************************************
    //StaticFpsController
    **********************************************************/
    public class StaticFpsController : FpsController
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        private enum AnonymousEnum2
        {
            FAST_MODE_SKIP_RATE = 10
        }
            protected float fpsCurrent_; // ���݂�FPS
            protected int timePrevious_; // �O��Wait�����Ƃ��̎���
            protected int timeError_; // �����z������(�덷)
            protected int timeCurrentFpsUpdate_; // 1�b�𑪒肷�邽�߂̎��ԕێ�
            protected int rateSkip_; // �`��X�L�b�v��
            protected int countSkip_; // �`��X�L�b�v�J�E���g
            protected LinkedList<int> listFps_ = new LinkedList<int>(); // 1�b���ƂɌ���fps��v�Z���邽�߂�fps��ێ�


            /**********************************************************
            //StaticFpsController
            **********************************************************/
            public StaticFpsController()
            {
                rateSkip_ = 0;
                fpsCurrent_ = 60F;
                timePrevious_ = _GetTime();
                timeCurrentFpsUpdate_ = 0;
                bUseTimer_ = true;
                timeError_ = 0;
            }

            public new void Dispose()
            {

                base.Dispose();
            }

            public override void Wait()
            {
                int time = _GetTime();

                double tFps = fps_;
                tFps = Math.Min(tFps, GetControlObjectFps());
                if (bFastMode_)
                {
                    tFps = FPS_FAST_MODE;
                }

                int sTime = time - timePrevious_; // �O�t���[���Ƃ̎��ԍ�

                int frameAs1Sec = (int)sTime * tFps;
                int time1Sec = 1000 + timeError_;
                int sleepTime = 0;
                timeError_ = 0;
                if (frameAs1Sec < time1Sec)
                {
                    sleepTime = (int)(time1Sec - frameAs1Sec) / tFps; // �ҋ@����
                    if (sleepTime < 0)
                    {
                        sleepTime = 0;
                    }
                    if (bUseTimer_ || rateSkip_ != 0)
                    {
                        _Sleep(sleepTime); // ��莞�Ԃ��܂ŁAsleep
                        timeError_ = (time1Sec - frameAs1Sec) % (int)tFps;
                    }

                    if (timeError_ < 0)
                    {
                        timeError_ = 0;
                    }
                }

                // 1frame�ɂ����������Ԃ�ۑ�
                double timeCorrect = (double)sleepTime;
                if (time - timePrevious_ > 0)
                {
                    listFps_.AddLast((int)time - timePrevious_ + Math.Ceiling(timeCorrect));
                }
                timePrevious_ = _GetTime();

                if (time - timeCurrentFpsUpdate_ >= 1000)
                { // ��b���Ƃɕ\���t���[������X�V
                    if (listFps_.Count != 0)
                    {
                        double tFpsCurrent = 0;
                        LinkedList<int>.Enumerator itr;
                        for (itr = listFps_.GetEnumerator(); itr.MoveNext();)
                        {
                            tFpsCurrent += itr.Current;
                        }
                        fpsCurrent_ = (double)(1000.0) / ((double)tFpsCurrent / (double)listFps_.Count);
                        listFps_.Clear();
                    }
                    else
                    {
                        fpsCurrent_ = 0F;
                    }

                    timeCurrentFpsUpdate_ = _GetTime();
                }
                countSkip_++;

                int rateSkip = rateSkip_;
                if (bFastMode_)
                {
                    rateSkip = (int)AnonymousEnum2.FAST_MODE_SKIP_RATE;
                }
                countSkip_ %= (rateSkip + 1);
                bCriticalFrame_ = false;
            }

            public override bool IsSkip()
            {
                int rateSkip = rateSkip_;
                if (bFastMode_)
                {
                    rateSkip = (int)AnonymousEnum2.FAST_MODE_SKIP_RATE;
                }
                if (rateSkip == 0 || bCriticalFrame_)
                {
                    return false;
                }
                if (countSkip_ % (rateSkip + 1) != 0)
                {
                    return true;
                }
                return false;
            }

            public override void SetCriticalFrame()
            {
                bCriticalFrame_ = true;
                timeError_ = 0;
                countSkip_ = 0;
            }

            public void SetSkipRate(int value)
            {
                rateSkip_ = value;
                countSkip_ = 0;
            }

            public override float GetCurrentFps()
            {
                float fps = fpsCurrent_ / (rateSkip_ + 1);
                return fps;
            }

            public override float GetCurrentWorkFps()
            {
                return fpsCurrent_;
            }

            public override float GetCurrentRenderFps()
            {
                float fps = fpsCurrent_ / (rateSkip_ + 1);
                return fps;
            }
    }

    /**********************************************************
    //AutoSkipFpsController
    **********************************************************/
    public class AutoSkipFpsController : FpsController
    {
            protected float fpsCurrentWork_; // ���ۂ�fps
            protected float fpsCurrentRender_; // ���ۂ�fps
            protected int timePrevious_; // �O��Wait�����Ƃ��̎���
            protected int timePreviousWork_;
            protected int timePreviousRender_;
            protected int timeError_; // �����z������(�덷)
            protected int timeCurrentFpsUpdate_; // 1�b�𑪒肷�邽�߂̎��ԕێ�
            protected LinkedList<int> listFpsWork_ = new LinkedList<int>();
            protected LinkedList<int> listFpsRender_ = new LinkedList<int>();
            protected double countSkip_; // �A���`��X�L�b�v��
            protected int countSkipMax_; // �ő�A���`��X�L�b�v��


            /**********************************************************
            //AutoSkipFpsController
            **********************************************************/
            public AutoSkipFpsController()
            {
                timeError_ = 0;
                timePrevious_ = _GetTime();
                timePreviousWork_ = timePrevious_;
                timePreviousRender_ = timePrevious_;
                countSkip_ = 0;
                countSkipMax_ = 20;

                fpsCurrentWork_ = 0F;
                fpsCurrentRender_ = 0F;
                timeCurrentFpsUpdate_ = 0;
                timeError_ = 0;
            }

            public new void Dispose()
            {

                base.Dispose();
            }

            public override void Wait()
            {
                int time = _GetTime();

                double tFps = fps_;
                tFps = Math.Min(tFps, GetControlObjectFps());
                if (bFastMode_)
                {
                    tFps = FPS_FAST_MODE;
                }

                int sTime = time - timePrevious_; // �O�t���[���Ƃ̎��ԍ�
                int frameAs1Sec = (int)sTime * tFps;
                int time1Sec = 1000 + timeError_;
                int sleepTime = 0;
                timeError_ = 0;
                if (frameAs1Sec < time1Sec || bCriticalFrame_)
                {
                    sleepTime = (int)(time1Sec - frameAs1Sec) / tFps; // �ҋ@����
                    if (sleepTime < 0 || countSkip_ - 1 >= 0)
                    {
                        sleepTime = 0;
                    }
                    if (bUseTimer_)
                    {
                        _Sleep(sleepTime); // ��莞�Ԃ��܂ŁAsleep
                    }

                    timeError_ = (time1Sec - frameAs1Sec) % (int)tFps;
                    // if(timeError_< 0 )timeError_ = 0;
                }
                else if (countSkip_ <= 0)
                {
                    countSkip_ += (double)sTime * (double)tFps / 1000 + 1;
                    if (countSkip_ > countSkipMax_)
                    {
                        countSkip_ = countSkipMax_;
                    }
                }

                countSkip_--;
                bCriticalFrame_ = false;

                {
                    // 1Work�ɂ����������Ԃ�ۑ�
                    double timeCorrect = (double)sleepTime;
                    if (time - timePrevious_ > 0)
                    {
                        listFpsWork_.AddLast((int)time - timePrevious_ + Math.Ceiling(timeCorrect));
                    }
                    timePrevious_ = _GetTime();
                }
                if (countSkip_ <= 0)
                {
                    // 1�`��ɂ����������Ԃ�ۑ�
                    time = _GetTime();
                    if (time - timePreviousRender_ > 0)
                    {
                        listFpsRender_.AddLast(time - timePreviousRender_);
                    }
                    timePreviousRender_ = _GetTime();
                }

                timePrevious_ = _GetTime();
                if (time - timeCurrentFpsUpdate_ >= 1000)
                { // ��b���Ƃɕ\���t���[������X�V
                    if (listFpsWork_.Count != 0)
                    {
                        float tFpsCurrent = 0F;
                        LinkedList<int>.Enumerator itr;
                        for (itr = listFpsWork_.GetEnumerator(); itr.MoveNext();)
                        {
                            tFpsCurrent += itr.Current;
                        }
                        fpsCurrentWork_ = (float)(1000.0f) / ((float)tFpsCurrent / (float)listFpsWork_.Count);
                        listFpsWork_.Clear();
                    }
                    else
                    {
                        fpsCurrentWork_ = 0F;
                    }

                    if (listFpsRender_.Count != 0)
                    {
                        float tFpsCurrent = 0F;
                        LinkedList<int>.Enumerator itr;
                        for (itr = listFpsRender_.GetEnumerator(); itr.MoveNext();)
                        {
                            tFpsCurrent += itr.Current;
                        }
                        fpsCurrentRender_ = (float)(1000.0f) / ((float)tFpsCurrent / (float)listFpsRender_.Count);
                        listFpsRender_.Clear();
                    }
                    else
                    {
                        fpsCurrentRender_ = 0F;
                    }

                    timeCurrentFpsUpdate_ = _GetTime();
                }
            }

            public override bool IsSkip()
            {
                return countSkip_ > 0;
            }

            public override void SetCriticalFrame()
            {
                bCriticalFrame_ = true;
                timeError_ = 0;
                countSkip_ = 0;
            }

            public override float GetCurrentFps()
            {
                return GetCurrentWorkFps();
            }
            public new float GetCurrentWorkFps()
            {
                return fpsCurrentWork_;
            }
            public new float GetCurrentRenderFps()
            {
                return fpsCurrentRender_;
            }
    }

    /**********************************************************
    //FpsControlObject
    **********************************************************/
    public abstract class FpsControlObject : System.IDisposable
    {
            public FpsControlObject()
            {
            }
            public virtual void Dispose()
            {
            }
            public abstract int GetFps();
    }
}
