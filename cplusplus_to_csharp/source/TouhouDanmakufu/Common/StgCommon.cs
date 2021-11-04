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
// class StgSystemController;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgSystemInformation;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgStageController;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgPackageController;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgStageInformation;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgSystemInformation;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgMovePattern;

/**********************************************************
//StgMoveObject
**********************************************************/
public class StgMoveObject : System.IDisposable
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//    friend StgMovePattern;
        private StgStageController stageController_;
        protected double posX_;
        protected double posY_;
        protected ref_count_ptr<StgMovePattern>.unsync pattern_ = new ref_count_ptr<StgMovePattern>.unsync();

        protected int framePattern_;
        protected SortedDictionary<int, ref_count_ptr<StgMovePattern>.unsync > mapPattern_ = new SortedDictionary<int, ref_count_ptr<StgMovePattern>.unsync >();
        protected virtual void _Move()
        {
            if (pattern_ == null)
            {
                return;
            }

            if (mapPattern_.Count > 0)
            {
                SortedDictionary<int, ref_count_ptr<StgMovePattern>.unsync >.Enumerator itr = mapPattern_.GetEnumerator();
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                int frame = itr.first;
                if (frame == framePattern_)
                {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    ref_count_ptr<StgMovePattern>.unsync pattern = itr.second;
                    _AttachReservedPattern(new ref_count_ptr<StgMovePattern>.unsync(pattern));
                    mapPattern_.Remove(frame);
                }
            }

            pattern_.Move();
            framePattern_++;
        }

        protected void _AttachReservedPattern(ref_count_ptr<StgMovePattern>.unsync pattern)
        {
            // ���x�p���Ȃ�
            if (pattern_ == null)
            {
                pattern_ = new StgMovePattern_Angle(this);
            }

            int newMoveType = pattern.GetType();
            if (newMoveType == (int)StgMovePattern.AnonymousEnum.TYPE_ANGLE)
            {
                StgMovePattern_Angle angPattern = (StgMovePattern_Angle)pattern.GetPointer();
                if (angPattern.GetSpeed() == StgMovePattern.AnonymousEnum.NO_CHANGE)
                {
                    angPattern.SetSpeed(pattern_.GetSpeed());
                }
                if (angPattern.GetDirectionAngle() == StgMovePattern.AnonymousEnum.NO_CHANGE)
                {
                    angPattern.SetDirectionAngle(pattern_.GetDirectionAngle());
                }
            }
            else if (newMoveType == (int)StgMovePattern.AnonymousEnum.TYPE_XY)
            {
                StgMovePattern_XY xyPattern = (StgMovePattern_XY)pattern.GetPointer();

                double speed = pattern_.GetSpeed();
                double angle = pattern_.GetDirectionAngle();
                double speedX = speed * System.Math.Cos(Math.DegreeToRadian(angle));
                double speedY = speed * System.Math.Sin(Math.DegreeToRadian(angle));

                if (xyPattern.GetSpeedX() == StgMovePattern.AnonymousEnum.NO_CHANGE)
                {
                    xyPattern.SetSpeedX(speedX);
                }
                if (xyPattern.GetSpeedY() == StgMovePattern.AnonymousEnum.NO_CHANGE)
                {
                    xyPattern.SetSpeedY(speedY);
                }
            }

            // �u������
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: pattern_ = pattern;
            pattern_.CopyFrom(pattern);
        }


        /**********************************************************
        //StgMoveObject
        **********************************************************/
        public StgMoveObject(StgStageController stageController)
        {
            posX_ = 0;
            posY_ = 0;
            framePattern_ = 0;
            stageController_ = stageController;
        }

        public virtual void Dispose()
        {

        }

        public double GetPositionX()
        {
            return posX_;
        }
        public void SetPositionX(double pos)
        {
            posX_ = pos;
        }
        public double GetPositionY()
        {
            return posY_;
        }
        public void SetPositionY(double pos)
        {
            posY_ = pos;
        }

        public double GetSpeed()
        {
            if (pattern_ == null)
            {
                return 0;
            }
            double res = pattern_.GetSpeed();
            return res;
        }

        public void SetSpeed(double speed)
        {
            if (pattern_ == null || pattern_.GetType() != StgMovePattern.AnonymousEnum.TYPE_ANGLE)
            {
                pattern_ = new StgMovePattern_Angle(this);
            }
            StgMovePattern_Angle pattern = (StgMovePattern_Angle)pattern_.GetPointer();
            pattern.SetSpeed(speed);
        }

        public double GetDirectionAngle()
        {
            if (pattern_ == null)
            {
                return 0;
            }
            double res = pattern_.GetDirectionAngle();
            return res;
        }

        public void SetDirectionAngle(double angle)
        {
            if (pattern_ == null || pattern_.GetType() != StgMovePattern.AnonymousEnum.TYPE_ANGLE)
            {
                pattern_ = new StgMovePattern_Angle(this);
            }
            StgMovePattern_Angle pattern = (StgMovePattern_Angle)pattern_.GetPointer();
            pattern.SetDirectionAngle(angle);
        }

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        void SetSpeedX(double speedX);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//        void SetSpeedY(double sppedY);

        public ref_count_ptr<StgMovePattern>.unsync GetPattern()
        {
            return new ref_count_ptr<StgMovePattern>.unsync(pattern_);
        }
        public void SetPattern(ref_count_ptr<StgMovePattern>.unsync pattern)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: pattern_ = pattern;
            pattern_.CopyFrom(pattern);
        }
        public void AddPattern(int frameDelay, ref_count_ptr<StgMovePattern>.unsync pattern)
        {
            if (frameDelay == 0)
            {
                _AttachReservedPattern(new ref_count_ptr<StgMovePattern>(pattern));
            }
            else
            {
                int frame = frameDelay + framePattern_;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mapPattern_[frame] = pattern;
                mapPattern_[frame].CopyFrom(pattern);
            }
        }
}

/**********************************************************
//StgMovePattern
**********************************************************/
public abstract class StgMovePattern : System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            TYPE_OTHER,
            TYPE_ANGLE,
            TYPE_XY,
            TYPE_LINE,

            NO_CHANGE = -256 * 256 * 256
        }

        protected int typeMove_;
        protected StgMoveObject target_;

        protected int frameWork_; // �A�N�e�B�u�ɂȂ�t���[���B
        protected int idShotData_; // �e�摜ID(�e�I�u�W�F�N�g��p)

        protected StgStageController _GetStageController()
        {
            return target_.stageController_;
        }
        protected ref_count_ptr<StgMoveObject>.unsync _GetMoveObject(int id)
        {
            StgStageController controller = _GetStageController();
            ref_count_ptr<DxScriptObjectBase>.unsync @base = controller.GetMainRenderObject(id);
            if (@base == null || @base.IsDeleted())
            {
                return null;
            }

            return ref_count_ptr<StgMoveObject>.unsync.DownCast(@base);
        }

        protected virtual void _Activate()
        {
        }

        /**********************************************************
        //StgMovePattern
        **********************************************************/
        // StgMovePattern
        public StgMovePattern(StgMoveObject target)
        {
            target_ = target;
            idShotData_ = (int)AnonymousEnum.NO_CHANGE;
            frameWork_ = 0;
            typeMove_ = (int)AnonymousEnum.TYPE_OTHER;
        }

        public virtual void Dispose()
        {
        }
        public abstract void Move();


        public int GetType()
        {
            return typeMove_;
        }

        public abstract double GetSpeed();
        public abstract double GetDirectionAngle();
        public int GetShotDataID()
        {
            return idShotData_;
        }
        public void SetShotDataID(int id)
        {
            idShotData_ = id;
        }
}

public class StgMovePattern_Angle : StgMovePattern
{
        protected double speed_;
        protected double angDirection_;
        protected double acceleration_;
        protected double maxSpeed_;
        protected double angularVelocity_;
        protected int idRalativeID_;

        protected override void _Activate()
        {
            if (idRalativeID_ != DxScript.ID_INVALID)
            {
                ref_count_ptr<StgMoveObject>.unsync obj = _GetMoveObject(idRalativeID_);
                if (obj != null)
                {
                    double px = target_.GetPositionX();
                    double py = target_.GetPositionY();
                    double tx = obj.GetPositionX();
                    double ty = obj.GetPositionY();
                    double angle = Math.RadianToDegree(System.Math.Atan2(ty - py, tx - px));
                    angDirection_ += angle;
                }
            }

        }


        // StgMovePattern_Angle
        public StgMovePattern_Angle(StgMoveObject target) : base(target)
        {
            typeMove_ = TYPE_ANGLE;
            speed_ = 0;
            angDirection_ = 0;
            acceleration_ = 0;
            maxSpeed_ = 0;
            angularVelocity_ = 0;
            idRalativeID_ = DxScript.ID_INVALID;
        }

        public override void Move()
        {
            if (frameWork_ == 0)
            {
                _Activate();
            }
            double angle = angDirection_;

            if (acceleration_ != 0)
            {
                speed_ += acceleration_;
                if (acceleration_ > 0)
                {
                    speed_ = System.Math.Min(speed_, maxSpeed_);
                }
                if (acceleration_ < 0)
                {
                    speed_ = System.Math.Max(speed_, maxSpeed_);
                }
            }
            if (angularVelocity_ != 0)
            {
                angDirection_ += angularVelocity_;
            }

            double sx = speed_ * System.Math.Cos(Math.DegreeToRadian(angDirection_));
            double sy = speed_ * System.Math.Sin(Math.DegreeToRadian(angDirection_));
            double px = target_.GetPositionX() + sx;
            double py = target_.GetPositionY() + sy;

            target_.SetPositionX(px);
            target_.SetPositionY(py);

            frameWork_++;
        }

        public override double GetSpeed()
        {
            return speed_;
        }
        public override double GetDirectionAngle()
        {
            return angDirection_;
        }

        public void SetSpeed(double speed)
        {
            speed_ = speed;
        }
        public void SetDirectionAngle(double angle)
        {
            angDirection_ = angle;
        }
        public void SetAcceleration(double accel)
        {
            acceleration_ = accel;
        }
        public void SetMaxSpeed(double max)
        {
            maxSpeed_ = max;
        }
        public void SetAngularVelocity(double av)
        {
            angularVelocity_ = av;
        }
        public void SetRelativeObjectID(int id)
        {
            idRalativeID_ = id;
        }
}

public class StgMovePattern_XY : StgMovePattern
{
        protected double speedX_;
        protected double speedY_;
        protected double accelerationX_;
        protected double accelerationY_;
        protected double maxSpeedX_;
        protected double maxSpeedY_;


        // StgMovePattern_XY
        public StgMovePattern_XY(StgMoveObject target) : base(target)
        {
            typeMove_ = TYPE_XY;
            speedX_ = 0;
            speedY_ = 0;
            accelerationX_ = 0;
            accelerationY_ = 0;
            maxSpeedX_ = int.MaxValue;
            maxSpeedY_ = int.MaxValue;
        }

        public override void Move()
        {
            if (frameWork_ == 0)
            {
                _Activate();
            }

            if (accelerationX_ != 0)
            {
                speedX_ += accelerationX_;
                if (accelerationX_ > 0)
                {
                    speedX_ = System.Math.Min(speedX_, maxSpeedX_);
                }
                if (accelerationX_ < 0)
                {
                    speedX_ = System.Math.Max(speedX_, maxSpeedX_);
                }
            }
            if (accelerationY_ != 0)
            {
                speedY_ += accelerationY_;
                if (accelerationY_ > 0)
                {
                    speedY_ = System.Math.Min(speedY_, maxSpeedY_);
                }
                if (accelerationY_ < 0)
                {
                    speedY_ = System.Math.Max(speedY_, maxSpeedY_);
                }
            }

            double px = target_.GetPositionX() + speedX_;
            double py = target_.GetPositionY() + speedY_;

            target_.SetPositionX(px);
            target_.SetPositionY(py);

            frameWork_++;
        }

        public override double GetSpeed()
        {
            double res = System.Math.Pow(speedX_ * speedX_ + speedY_ * speedY_, 0.5);
            return res;
        }

        public override double GetDirectionAngle()
        {
            double res = Math.RadianToDegree(System.Math.Atan2(speedY_, speedX_));
            return res;
        }

        public double GetSpeedX()
        {
            return speedX_;
        }
        public double GetSpeedY()
        {
            return speedY_;
        }
        public void SetSpeedX(double value)
        {
            speedX_ = value;
        }
        public void SetSpeedY(double value)
        {
            speedY_ = value;
        }
        public void SetAccelerationX(double value)
        {
            accelerationX_ = value;
        }
        public void SetAccelerationY(double value)
        {
            accelerationY_ = value;
        }
        public void SetMaxSpeedX(double value)
        {
            maxSpeedX_ = value;
        }
        public void SetMaxSpeedY(double value)
        {
            maxSpeedY_ = value;
        }
}

public class StgMovePattern_Line : StgMovePattern
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        protected enum AnonymousEnum2
        {
            TYPE_SPEED,
            TYPE_FRAME,
            TYPE_WEIGHT,
            TYPE_NONE
        }

        protected int typeLine_;
        protected double speed_;
        protected double angDirection_;
        protected double weight_;
        protected double maxSpeed_;
        protected int frameStop_;
        protected double toX_;
        protected double toY_;


        // StgMovePattern_Line
        public StgMovePattern_Line(StgMoveObject target) : base(target)
        {
            typeMove_ = (int)AnonymousEnum2.TYPE_NONE;
            speed_ = 0;
            angDirection_ = 0;
            weight_ = 0;
            maxSpeed_ = 0;
            frameStop_ = 0;
        }

        public override void Move()
        {
            if (typeLine_ == (int)AnonymousEnum2.TYPE_SPEED || typeLine_ == (int)AnonymousEnum2.TYPE_FRAME)
            {
                double sx = speed_ * System.Math.Cos(Math.DegreeToRadian(angDirection_));
                double sy = speed_ * System.Math.Sin(Math.DegreeToRadian(angDirection_));
                double px = target_.GetPositionX() + sx;
                double py = target_.GetPositionY() + sy;

                target_.SetPositionX(px);
                target_.SetPositionY(py);
                frameStop_--;
                if (frameStop_ <= 0)
                {
                    typeLine_ = (int)AnonymousEnum2.TYPE_NONE;
                    speed_ = 0;
                }
            }
            else if (typeLine_ == (int)AnonymousEnum2.TYPE_WEIGHT)
            {
                double nx = target_.GetPositionX();
                double ny = target_.GetPositionY();
                double dist = System.Math.Pow(System.Math.Pow(toX_ - nx, 2) + System.Math.Pow(toY_ - ny, 2), 0.5);
                if (dist < 1)
                {
                    typeLine_ = (int)AnonymousEnum2.TYPE_NONE;
                    speed_ = 0;
                }
                else
                {
                    speed_ = dist / weight_;
                    if (speed_ > maxSpeed_)
                    {
                        speed_ = maxSpeed_;
                    }
                    double px = target_.GetPositionX() + speed_ * System.Math.Cos(Math.DegreeToRadian(angDirection_));
                    double py = target_.GetPositionY() + speed_ * System.Math.Sin(Math.DegreeToRadian(angDirection_));
                    target_.SetPositionX(px);
                    target_.SetPositionY(py);
                }

            }
        }

        public override double GetSpeed()
        {
            return speed_;
        }
        public override double GetDirectionAngle()
        {
            return angDirection_;
        }

        public void SetAtSpeed(double tx, double ty, double speed)
        {
            typeLine_ = (int)AnonymousEnum2.TYPE_SPEED;
            toX_ = tx;
            toY_ = ty;
            double nx = target_.GetPositionX();
            double ny = target_.GetPositionY();
            double dist = System.Math.Pow(System.Math.Pow(tx - nx, 2) + System.Math.Pow(ty - ny, 2), 0.5);
            speed_ = speed;
            angDirection_ = Math.RadianToDegree(System.Math.Atan2(ty - ny, tx - nx));
            frameStop_ = (int)dist / speed;
        }

        public void SetAtFrame(double tx, double ty, double frame)
        {
            typeLine_ = (int)AnonymousEnum2.TYPE_FRAME;
            toX_ = tx;
            toY_ = ty;
            double nx = target_.GetPositionX();
            double ny = target_.GetPositionY();
            double dist = System.Math.Pow(System.Math.Pow(tx - nx, 2) + System.Math.Pow(ty - ny, 2), 0.5);
            speed_ = dist / frame;
            angDirection_ = Math.RadianToDegree(System.Math.Atan2(ty - ny, tx - nx));
            frameStop_ = (int)frame;
        }

        public void SetAtWait(double tx, double ty, double weight, double maxSpeed)
        {
            typeLine_ = (int)AnonymousEnum2.TYPE_WEIGHT;
            toX_ = tx;
            toY_ = ty;
            weight_ = weight;
            maxSpeed_ = maxSpeed;
            double nx = target_.GetPositionX();
            double ny = target_.GetPositionY();
            double dist = System.Math.Pow(System.Math.Pow(tx - nx, 2) + System.Math.Pow(ty - ny, 2), 0.5);
            speed_ = maxSpeed_;
            angDirection_ = Math.RadianToDegree(System.Math.Atan2(ty - ny, tx - nx));
        }
}
