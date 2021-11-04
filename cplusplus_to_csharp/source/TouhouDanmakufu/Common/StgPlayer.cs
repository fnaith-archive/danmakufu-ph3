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
// class StgPlayerObject;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgPlayerInformation;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgPlayerSpellManageObject;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgPlayerSpellObject;
/**********************************************************
//StgPlayerObject
**********************************************************/
public class StgPlayerInformation : System.IDisposable
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//    friend StgPlayerObject;
        private double life_;
        private double countBomb_;
        private double power_;
        private int frameRebirth_; // ���炢�{���L���t���[��
        public StgPlayerInformation()
        {
        }
        public virtual void Dispose()
        {
        }

        public double GetLife()
        {
            return life_;
        }
        public void SetLife(double life)
        {
            life_ = life;
        }
        public double GetSpell()
        {
            return countBomb_;
        }
        public void SetSpell(double spell)
        {
            countBomb_ = spell;
        }
        public double GetPower()
        {
            return power_;
        }
        public void SetPower(double power)
        {
            power_ = power;
        }

        public int GetRebirthFrame()
        {
            return frameRebirth_;
        }
        public void SetRebirthFrame(int frame)
        {
            frameRebirth_ = frame;
        }
}

// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class StgPlayerObject : DxScriptSpriteObject2D, StgMoveObject, StgIntersectionObject
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            STATE_NORMAL,
            STATE_HIT,
            STATE_DOWN,
            STATE_END
        }
        protected StgStageController stageController_;
        protected StgStagePlayerScript script_;
        protected ref_count_ptr<StgPlayerInformation> infoPlayer_ = new ref_count_ptr<StgPlayerInformation>();
        protected ref_count_ptr<StgPlayerSpellManageObject>.unsync objSpell_ = new ref_count_ptr<StgPlayerSpellManageObject>.unsync();

        protected double speedFast_;
        protected double speedSlow_;
        protected RECT rcClip_ = new RECT();

        protected int state_;
        protected int frameState_; // �e�X�e�[�g�Ŏg�p�����t���[��
        protected int frameRebirthMax_; // ���炢�{���L���t���[�������l
        protected int frameRebirthDiff_; // ���炢�{��������
        protected int frameStateDown_;

        protected List<ref_count_weak_ptr<StgIntersectionObject>.unsync > listGrazedShot_ = new List<ref_count_weak_ptr<StgIntersectionObject>.unsync >();
        protected int hitObjectID_;

        protected double itemCircle_;
        protected int frameInvincibility_;
        protected bool bForbidShot_;
        protected bool bForbidSpell_;
        protected int yAutoItemCollect_;

        protected void _InitializeRebirth()
        {
            RECT rcStgFrame = stageController_.GetStageInformation().GetStgFrameRect();
            int stgWidth = rcStgFrame.right - rcStgFrame.left;
            int stgHeight = rcStgFrame.bottom - rcStgFrame.top;

            SetX(stgWidth / 2);
            SetY(rcStgFrame.bottom - 48);
        }

        protected new void _Move()
        {
            double sx = 0;
            double sy = 0;
            EDirectInput input = EDirectInput.GetInstance();
            int keyLeft = input.GetVirtualKeyState(EDirectInput.KEY_LEFT);
            int keyRight = input.GetVirtualKeyState(EDirectInput.KEY_RIGHT);
            int keyUp = input.GetVirtualKeyState(EDirectInput.KEY_UP);
            int keyDown = input.GetVirtualKeyState(EDirectInput.KEY_DOWN);
            int keySlow = input.GetVirtualKeyState(EDirectInput.KEY_SLOWMOVE);

            double speed = speedFast_;
            if (keySlow == KEY_PUSH || keySlow == KEY_HOLD)
            {
                speed = speedSlow_;
            }

            bool bKetLeft = keyLeft == KEY_PUSH || keyLeft == KEY_HOLD;
            bool bKeyRight = keyRight == KEY_PUSH || keyRight == KEY_HOLD;
            bool bKeyUp = keyUp == KEY_PUSH || keyUp == KEY_HOLD;
            bool bKeyDown = keyDown == KEY_PUSH || keyDown == KEY_HOLD;

            if (bKetLeft && !bKeyRight)
            {
                sx += -speed;
            }
            if (!bKetLeft && bKeyRight)
            {
                sx += speed;
            }
            if (bKeyUp && !bKeyDown)
            {
                sy += -speed;
            }
            if (!bKeyUp && bKeyDown)
            {
                sy += speed;
            }

            if (sx != 0 && sy != 0)
            {
                sx /= 1.41421356;
                sy /= 1.41421356;
            }

            double px = posX_ + sx;
            double py = posY_ + sy;

            // �͂ݏo���Ƃ��̏���
            px = System.Math.Max(px, rcClip_.left);
            px = System.Math.Min(px, rcClip_.right);
            py = System.Math.Max(py, rcClip_.top);
            py = System.Math.Min(py, rcClip_.bottom);

            SetX(px);
            SetY(py);
        }

        protected void _AddIntersection()
        {
            if (frameInvincibility_ > 0)
            {
                return;
            }
            StgIntersectionManager intersectionManager = stageController_.GetIntersectionManager();

            UpdateIntersectionRelativeTarget(posX_, posY_, 0);
            RegistIntersectionRelativeTarget(intersectionManager);
        }

        protected bool _IsValidSpell()
        {
            bool res = true;
            res &= (state_ == (int)AnonymousEnum.STATE_NORMAL || (state_ == (int)AnonymousEnum.STATE_HIT && frameState_ > 0));
            res &= (objSpell_ == null || objSpell_.IsDeleted());
            return res;
        }


        /**********************************************************
        //StgPlayerObject
        **********************************************************/
        public StgPlayerObject(StgStageController stageController) : base(stageController)
        {
            stageController_ = stageController;
            typeObject_ = StgStageScript.OBJ_PLAYER;

            infoPlayer_ = new StgPlayerInformation();
            RECT rcStgFrame = stageController_.GetStageInformation().GetStgFrameRect();
            int stgWidth = rcStgFrame.right - rcStgFrame.left;
            int stgHeight = rcStgFrame.bottom - rcStgFrame.top;

            SetRenderPriority(0.30);
            speedFast_ = 4;
            speedSlow_ = 1.6;
            SetRect(rcClip_, 0, 0, stgWidth, stgHeight);

            state_ = (int)AnonymousEnum.STATE_NORMAL;
            frameStateDown_ = 120;
            frameRebirthMax_ = 15;
            infoPlayer_.frameRebirth_ = frameRebirthMax_;
            frameRebirthDiff_ = 3;

            infoPlayer_.life_ = 2;
            infoPlayer_.countBomb_ = 3;
            infoPlayer_.power_ = 1.0;

            itemCircle_ = 24;
            frameInvincibility_ = 0;
            bForbidShot_ = false;
            bForbidSpell_ = false;
            yAutoItemCollect_ = -256 * 256;

            hitObjectID_ = DxScript.ID_INVALID;

            _InitializeRebirth();
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public void Clear()
        {
            ClearIntersectionRelativeTarget();
        }
        public void SetScript(StgStagePlayerScript script)
        {
            script_ = script;
        }

        public override void Work()
        {
            EDirectInput input = EDirectInput.GetInstance();
            StgStageScriptManager scriptManager = stageController_.GetScriptManagerP();
            StgEnemyManager enemyManager = stageController_.GetEnemyManager();

            // �����蔻��N���A
            ClearIntersected();

            if (state_ == (int)AnonymousEnum.STATE_NORMAL)
            {
                // �ʏ펞
                if (hitObjectID_ != DxScript.ID_INVALID)
                {
                    state_ = (int)AnonymousEnum.STATE_HIT;
                    frameState_ = infoPlayer_.frameRebirth_;

                    gstd.value valueHitObjectID = script_.CreateRealValue(hitObjectID_);
                    List<gstd.value> listScriptValue = new List<gstd.value>();
                    listScriptValue.Add(valueHitObjectID);
                    script_.RequestEvent(StgStagePlayerScript.EV_HIT, listScriptValue);
                }
                else
                {
                    if (listGrazedShot_.Count > 0)
                    {
                        List<value> listValPos = new List<value>();
                        List<double> listShotID = new List<double>();
                        int grazedShotCount = listGrazedShot_.Count;
                        for (int iObj = 0 ; iObj < grazedShotCount ; iObj++)
                        {
                            ref_count_weak_ptr<StgShotObject>.unsync objShot = new ref_count_weak_ptr<StgShotObject>.unsync(listGrazedShot_[iObj]);
                            if (objShot != null)
                            {
                                int id = objShot.GetObjectID();
                                listShotID.Add(id);

                                List<double> listPos = new List<double>();
                                listPos.Add(objShot.GetPositionX());
                                listPos.Add(objShot.GetPositionY());
                                listValPos.Add(script_.CreateRealArrayValue(listPos));
                            }
                        }

                        List<gstd.value> listScriptValue = new List<gstd.value>();
                        listScriptValue.Add(script_.CreateRealValue(grazedShotCount));
                        listScriptValue.Add(script_.CreateRealArrayValue(listShotID));
                        listScriptValue.Add(script_.CreateValueArrayValue(listValPos));
                        script_.RequestEvent(StgStagePlayerScript.EV_GRAZE, listScriptValue);

                        ref_count_ptr<StgStageScriptManager> stageScriptManager = stageController_.GetScriptManagerR();
                        ref_count_ptr<ManagedScript> itemScript = stageScriptManager.GetItemScript();
                        if (itemScript != null)
                        {
                            itemScript.RequestEvent(StgStagePlayerScript.EV_GRAZE, listScriptValue);
                        }
                    }
                    // _Move();
                    if (input.GetVirtualKeyState(EDirectInput.KEY_BOMB) == KEY_PUSH)
                    {
                        CallSpell();
                    }

                    _AddIntersection();
                }
            }
            if (state_ == (int)AnonymousEnum.STATE_HIT)
            {
                // ���炢�{���ҋ@
                if (input.GetVirtualKeyState(EDirectInput.KEY_BOMB) == KEY_PUSH)
                {
                    CallSpell();
                }

                if (state_ == (int)AnonymousEnum.STATE_HIT)
                {
                    // ���炢�{���L���t���[������
                    frameState_--;
                    if (frameState_ < 0)
                    {
                        // ���@�_�E��
                        bool bEnemyLastSpell = false;
                        ref_count_ptr<StgEnemyBossSceneObject>.unsync objBossScene = enemyManager.GetBossSceneObject();
                        if (objBossScene != null)
                        {
                            objBossScene.AddPlayerShootDownCount();
                            if (objBossScene.GetActiveData().IsLastSpell())
                            {
                                bEnemyLastSpell = true;
                            }
                        }
                        if (!bEnemyLastSpell)
                        {
                            infoPlayer_.life_--;
                        }
                        scriptManager.RequestEventAll(StgStagePlayerScript.EV_PLAYER_SHOOTDOWN);

                        if (infoPlayer_.life_ >= 0)
                        {
                            bVisible_ = false;
                            state_ = (int)AnonymousEnum.STATE_DOWN;
                            frameState_ = frameStateDown_;
                        }
                        else
                        {
                            state_ = (int)AnonymousEnum.STATE_END;
                        }
                    }
                }
            }
            if (state_ == (int)AnonymousEnum.STATE_DOWN)
            {
                // �_�E��
                frameState_--;
                if (frameState_ <= 0)
                {
                    bVisible_ = true;
                    _InitializeRebirth();
                    state_ = (int)AnonymousEnum.STATE_NORMAL;
                    scriptManager.RequestEventAll(StgStageScript.EV_PLAYER_REBIRTH);
                }
            }
            if (state_ == (int)AnonymousEnum.STATE_END)
            {
                bVisible_ = false;
            }

            frameInvincibility_ = System.Math.Max(frameInvincibility_ - 1, 0);
            listGrazedShot_.Clear();
            hitObjectID_ = DxScript.ID_INVALID;
        }

        public void Move()
        {
            if (state_ == (int)AnonymousEnum.STATE_NORMAL)
            {
                // �ʏ펞
                if (hitObjectID_ == DxScript.ID_INVALID)
                {
                    _Move();
                }
            }
        }

        public override void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget)
        {
            StgIntersectionTarget_Player own = (StgIntersectionTarget_Player)ownTarget.GetPointer();
            int otherType = otherTarget.GetTargetType();
            switch (otherType)
            {
                case StgIntersectionTarget.TYPE_ENEMY_SHOT:
                {
                    // �G�e
                    if (own.IsGraze())
                    {
                        StgShotObject objShot = (StgShotObject)otherTarget.GetObject().GetPointer();
                        if (objShot != null && objShot.IsValidGraze())
                        {
                            listGrazedShot_.Add(otherTarget.GetObject());
                            stageController_.GetStageInformation().AddGraze(1);
                        }
                    }
                    else
                    {
                        ref_count_weak_ptr<StgShotObject>.unsync objShot = new ref_count_weak_ptr<StgShotObject>.unsync(otherTarget.GetObject());
                        if (objShot != null)
                        {
                            hitObjectID_ = objShot.GetObjectID();
                        }
                    }
                }
                break;

                case StgIntersectionTarget.TYPE_ENEMY:
                {
                    // �G
                    if (!own.IsGraze())
                    {
                        ref_count_weak_ptr<StgEnemyObject>.unsync objEnemy = new ref_count_weak_ptr<StgEnemyObject>.unsync(otherTarget.GetObject());
                        if (objEnemy != null)
                        {
                            hitObjectID_ = objEnemy.GetObjectID();
                        }
                    }
                }
                break;
            }


        }

        public void CallSpell()
        {
            if (!_IsValidSpell())
            {
                return;
            }
            if (!IsPermitSpell())
            {
                return;
            }

            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            objSpell_ = new StgPlayerSpellManageObject();
            int idSpell = objectManager.AddObject(objSpell_);

            gstd.value vUse = script_.RequestEvent(StgStagePlayerScript.EV_REQUEST_SPELL);
            if (!script_.IsBooleanValue(vUse))
            {
                throw new gstd.wexception("@Event(EV_REQUEST_SPELL)���boolean�^�̒l���Ԃ���Ă��܂���B");
            }
            bool bUse = vUse.as_boolean();
            if (!bUse)
            {
                objSpell_ = null;
                objectManager.DeleteObject(idSpell);
                return;
            }

            if (state_ == (int)AnonymousEnum.STATE_HIT)
            {
                state_ = (int)AnonymousEnum.STATE_NORMAL;
                infoPlayer_.frameRebirth_ = System.Math.Max(infoPlayer_.frameRebirth_ - frameRebirthDiff_, 0);
            }

            StgEnemyManager enemyManager = stageController_.GetEnemyManager();
            ref_count_ptr<StgEnemyBossSceneObject>.unsync objBossScene = enemyManager.GetBossSceneObject();
            if (objBossScene != null)
            {
                objBossScene.AddPlayerSpellCount();
            }

            StgStageScriptManager scriptManager = stageController_.GetScriptManagerP();
            scriptManager.RequestEventAll(StgStageScript.EV_PLAYER_SPELL);
        }

        public override void SetX(double x)
        {
            posX_ = x;
            DxScriptRenderObject.SetX(x);
        }
        public override void SetY(double y)
        {
            posY_ = y;
            DxScriptRenderObject.SetY(y);
        }

        public ref_count_ptr<StgPlayerInformation> GetPlayerInformation()
        {
            return new ref_count_ptr<StgPlayerInformation>(infoPlayer_);
        }
        public void SetPlayerInforamtion(ref_count_ptr<StgPlayerInformation> info)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoPlayer_ = info;
            infoPlayer_.CopyFrom(info);
        }
        public ref_count_ptr<StgPlayerSpellManageObject>.unsync GetSpellManageObject()
        {
            return new ref_count_ptr<StgPlayerSpellManageObject>.unsync(objSpell_);
        }

        public StgStagePlayerScript GetPlayerScript()
        {
            return script_;
        }
        public ref_count_ptr<StgPlayerObject>.unsync GetOwnObject()
        {
            return ref_count_ptr<StgPlayerObject>.unsync.DownCast(stageController_.GetMainRenderObject(idObject_));
        }

        public double GetX()
        {
            return posX_;
        }
        public double GetY()
        {
            return posY_;
        }
        public double GetFastSpeed()
        {
            return speedFast_;
        }
        public void SetFastSpeed(double speed)
        {
            speedFast_ = speed;
        }
        public double GetSlowSpeed()
        {
            return speedSlow_;
        }
        public void SetSlowSpeed(double speed)
        {
            speedSlow_ = speed;
        }

        public RECT GetClip()
        {
            return new RECT(rcClip_);
        }
        public void SetClip(RECT rect)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcClip_ = rect;
            rcClip_.CopyFrom(rect);
        }

        public int GetState()
        {
            return state_;
        }
        public int GetDownStateFrame()
        {
            return frameStateDown_;
        }
        public void SetDownStateFrame(int frame)
        {
            frameStateDown_ = frame;
        }
        public int GetRebirthFrame()
        {
            return infoPlayer_.GetRebirthFrame();
        }
        public void SetRebirthFrameMax(int frame)
        {
            frameRebirthMax_ = frame;
        }
        public void SetRebirthFrame(int frame)
        {
            infoPlayer_.SetRebirthFrame(frame);
        }
        public void SetRebirthLossFrame(int frame)
        {
            frameRebirthDiff_ = frame;
        }
        public double GetItemIntersectionRadius()
        {
            return itemCircle_;
        }
        public void SetItemIntersectionRadius(double r)
        {
            itemCircle_ = r;
        }
        public double GetLife()
        {
            return infoPlayer_.GetLife();
        }
        public void SetLife(double life)
        {
            infoPlayer_.SetLife(life);
        }
        public double GetSpell()
        {
            return infoPlayer_.GetSpell();
        }
        public void SetSpell(double spell)
        {
            infoPlayer_.SetSpell(spell);
        }
        public double GetPower()
        {
            return infoPlayer_.GetPower();
        }
        public void SetPower(double power)
        {
            infoPlayer_.SetPower(power);
        }
        public int GetInvincibilityFrame()
        {
            return frameInvincibility_;
        }
        public void SetInvincibilityFrame(int frame)
        {
            frameInvincibility_ = frame;
        }
        public int GetAutoItemCollectY()
        {
            return yAutoItemCollect_;
        }
        public void SetAutoItemCollectY(int y)
        {
            yAutoItemCollect_ = y;
        }

        public bool IsPermitShot()
        {
            // �ȉ��̂Ƃ��s��
            // �E��b��
            return !bForbidShot_;
        }

        public void SetForbidShot(bool bForbid)
        {
            bForbidShot_ = bForbid;
        }
        public bool IsPermitSpell()
        {
            // �ȉ��̂Ƃ��s��
            // �E��b��
            // �E���X�g�X�y����
            StgEnemyManager enemyManager = stageController_.GetEnemyManager();
            bool bEnemyLastSpell = false;
            ref_count_ptr<StgEnemyBossSceneObject>.unsync objBossScene = enemyManager.GetBossSceneObject();
            if (objBossScene != null)
            {
                ref_count_ptr<StgEnemyBossSceneData>.unsync data = objBossScene.GetActiveData();
                if (data != null && data.IsLastSpell())
                {
                    bEnemyLastSpell = true;
                }
            }

            return !bEnemyLastSpell && !bForbidSpell_;
        }

        public void SetForbidSpell(bool bForbid)
        {
            bForbidSpell_ = bForbid;
        }
        public bool IsWaitLastSpell()
        {
            bool res = IsPermitSpell() && state_ == (int)AnonymousEnum.STATE_HIT;
            return res;
        }
}


public class StgIntersectionTarget_Player : StgIntersectionTarget_Circle
{
        private bool bGraze_;
        public StgIntersectionTarget_Player(bool bGraze)
        {
            typeTarget_ = TYPE_PLAYER;
            bGraze_ = bGraze;
        }
        public bool IsGraze()
        {
            return bGraze_;
        }
}

/**********************************************************
//StgPlayerSpellManageObject
**********************************************************/
public class StgPlayerSpellManageObject : DxScriptObjectBase
{
        public StgPlayerSpellManageObject()
        {
            bVisible_ = false;
        }
        public override void Render()
        {
        }
        public override void SetRenderState()
        {
        }
}

/**********************************************************
//StgPlayerSpellObject
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class StgPlayerSpellObject : DxScriptPrimitiveObject2D, StgIntersectionObject
{
        protected StgStageController stageController_;
        protected double damage_;
        protected bool bEraseShot_;
        protected double life_; // �ђʗ�


        /**********************************************************
        //StgPlayerSpellObject
        **********************************************************/
        public StgPlayerSpellObject(StgStageController stageController)
        {
            stageController_ = stageController;
            damage_ = 0;
            bEraseShot_ = true;
            life_ = 256 * 256 * 256;
        }

        public override void Work()
        {
            if (IsDeleted())
            {
                return;
            }
            if (life_ <= 0)
            {
                ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
                objectManager.DeleteObject(idObject_);
            }
        }

        public override void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget)
        {
            double damage = 0;
            int otherType = otherTarget.GetTargetType();
            switch (otherType)
            {
                case StgIntersectionTarget.TYPE_ENEMY:
                case StgIntersectionTarget.TYPE_ENEMY_SHOT:
                {
                    damage = 1;
                    break;
                }
            }
            life_ -= damage;
            life_ = System.Math.Max(life_, 0);
        }

        public double GetDamage()
        {
            return damage_;
        }
        public void SetDamage(double damage)
        {
            damage_ = damage;
        }
        public bool IsEraseShot()
        {
            return bEraseShot_;
        }
        public void SetEraseShot(bool b)
        {
            bEraseShot_ = b;
        }
        public double GetLife()
        {
            return life_;
        }
        public void SetLife(double life)
        {
            life_ = life;
        }
}


