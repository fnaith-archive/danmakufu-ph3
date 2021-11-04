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
// class StgEnemyObject;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgEnemyBossSceneObject;
/**********************************************************
//StgEnemyManager
**********************************************************/
public class StgEnemyManager : System.IDisposable
{
        private StgStageController stageController_;
        private LinkedList<ref_count_ptr<StgEnemyObject>.unsync > listObj_ = new LinkedList<ref_count_ptr<StgEnemyObject>.unsync >();
        private ref_count_ptr<StgEnemyBossSceneObject>.unsync objBossScene_ = new ref_count_ptr<StgEnemyBossSceneObject>.unsync();

        /**********************************************************
        //StgEnemyManager
        **********************************************************/
        public StgEnemyManager(StgStageController stageController)
        {
            stageController_ = stageController;
        }

        public virtual void Dispose()
        {
            LinkedList<ref_count_ptr<StgEnemyObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgEnemyObject>.unsync obj = itr.Current;
                if (obj != null)
                {
                    obj.ClearEnemyObject();
                }
            }
        }

        public void Work()
        {
            LinkedList<ref_count_ptr<StgEnemyObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgEnemyObject>.unsync obj = itr.Current;
                if (obj.IsDeleted())
                {
                    obj.ClearEnemyObject();
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                    itr = listObj_.erase(itr);
                }
                else
                {
                }
            }

        }

        public void RegistIntersectionTarget()
        {
            LinkedList<ref_count_ptr<StgEnemyObject>.unsync >.Enumerator itr = listObj_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgEnemyObject>.unsync obj = itr.Current;
                if (!obj.IsDeleted())
                {
                    obj.ClearIntersectedIdList();
                    obj.RegistIntersectionTarget();
                }
            }
        }

        public void AddEnemy(ref_count_ptr<StgEnemyObject>.unsync obj)
        {
            listObj_.AddLast(obj);
        }
        public int GetEnemyCount()
        {
            return listObj_.Count;
        }

        public void SetBossSceneObject(ref_count_ptr<StgEnemyBossSceneObject>.unsync obj)
        {
            if (objBossScene_ != null && !objBossScene_.IsDeleted())
            {
                throw new gstd.wexception("���ł�EnemyBossScene�I�u�W�F�N�g�����݂��܂�");
            }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: objBossScene_ = obj;
            objBossScene_.CopyFrom(obj);
        }

        public ref_count_ptr<StgEnemyBossSceneObject>.unsync GetBossSceneObject()
        {
            ref_count_ptr<StgEnemyBossSceneObject>.unsync res = null;
            if (objBossScene_ != null && !objBossScene_.IsDeleted())
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res = objBossScene_;
                res.CopyFrom(objBossScene_);
            }
            return new ref_count_ptr<StgEnemyBossSceneObject>.unsync(res);
        }

        public LinkedList<ref_count_ptr<StgEnemyObject>.unsync > GetEnemyList()
        {
            return new LinkedList<ref_count_ptr<StgEnemyObject>.unsync >(listObj_);
        }

}

/**********************************************************
//StgEnemyObject
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class StgEnemyObject : DxScriptSpriteObject2D, StgMoveObject, StgIntersectionObject
{
        protected StgStageController stageController_;

        protected double life_;
        protected double rateDamageShot_;
        protected double rateDamageSpell_;
        protected int intersectedPlayerShotCount_;

        protected override void _Move()
        {
            base._Move();
            SetX(posX_);
            SetY(posY_);
        }

        protected virtual void _AddRelativeIntersection()
        {
            StgIntersectionManager intersectionManager = stageController_.GetIntersectionManager();

            UpdateIntersectionRelativeTarget(posX_, posY_, 0);
            RegistIntersectionRelativeTarget(intersectionManager);
        }


        /**********************************************************
        //StgEnemyObject
        **********************************************************/
        public StgEnemyObject(StgStageController stageController) : base(stageController)
        {
            stageController_ = stageController;
            typeObject_ = StgStageScript.OBJ_ENEMY;

            SetRenderPriority(0.40);

            life_ = 0;
            rateDamageShot_ = 100;
            rateDamageSpell_ = 100;
            intersectedPlayerShotCount_ = 0;
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public override void Work()
        {
            ClearIntersected();
            intersectedPlayerShotCount_ = 0;

            _Move();
        }

        public virtual void Activate()
        {
        }

        public override void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget)
        {
            double damage = 0;
            if (otherTarget.GetTargetType() == StgIntersectionTarget.TYPE_PLAYER_SHOT)
            {
                StgShotObject shot = (StgShotObject)otherTarget.GetObject().GetPointer();
                if (shot != null)
                {
                    damage = shot.GetDamage();
                    if (shot.IsSpellFactor())
                    {
                        damage = damage * rateDamageSpell_ / 100;
                    }
                    else
                    {
                        damage = damage * rateDamageShot_ / 100;
                    }
                    intersectedPlayerShotCount_++;
                }
            }
            else if (otherTarget.GetTargetType() == StgIntersectionTarget.TYPE_PLAYER_SPELL)
            {
                StgPlayerSpellObject spell = (StgPlayerSpellObject)otherTarget.GetObject().GetPointer();
                if (spell != null)
                {
                    damage = spell.GetDamage();
                    damage = damage * rateDamageSpell_ / 100;
                }
            }
            life_ = System.Math.Max(life_ - damage, 0);
        }

        public virtual void ClearEnemyObject()
        {
            ClearIntersectionRelativeTarget();
        }
        public virtual void RegistIntersectionTarget()
        {
            _AddRelativeIntersection();
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

        public ref_count_ptr<StgEnemyObject>.unsync GetOwnObject()
        {
            return ref_count_ptr<StgEnemyObject>.unsync.DownCast(stageController_.GetMainRenderObject(idObject_));
        }

        public double GetLife()
        {
            return life_;
        }
        public void SetLife(double life)
        {
            life_ = life;
        }
        public void AddLife(double inc)
        {
            life_ += inc;
            life_ = System.Math.Max(life_, 0);
        }
        public void SetDamageRate(double rateShot, double rateSpell)
        {
            rateDamageShot_ = rateShot;
            rateDamageSpell_ = rateSpell;
        }
        public double GetShotDamageRate()
        {
            return rateDamageShot_;
        }
        public double GetSpellDamageRate()
        {
            return rateDamageSpell_;
        }
        public int GetIntersectedPlayerShotCount()
        {
            return intersectedPlayerShotCount_;
        }
}

/**********************************************************
//StgEnemyBossObject
**********************************************************/
public class StgEnemyBossObject : StgEnemyObject
{
        private int timeSpellCard_;

        /**********************************************************
        //StgEnemyBossObject
        **********************************************************/
        public StgEnemyBossObject(StgStageController stageController) : base(stageController)
        {
            typeObject_ = StgStageScript.OBJ_ENEMY_BOSS;
        }
}

/**********************************************************
//StgEnemyBossSceneObject
**********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgEnemyBossSceneData;
public class StgEnemyBossSceneObject : DxScriptObjectBase
{
        private StgStageController stageController_;
// C++ TO C# CONVERTER TODO TASK: 'volatile' has a different meaning in C#:
// ORIGINAL LINE: volatile bool bLoad_;
        private bool bLoad_;

        private int dataStep_;
        private int dataIndex_;
        private ref_count_ptr<StgEnemyBossSceneData>.unsync activeData_ = new ref_count_ptr<StgEnemyBossSceneData>.unsync();
        private List<List<ref_count_ptr<StgEnemyBossSceneData>.unsync >> listData_ = new List<List<ref_count_ptr<StgEnemyBossSceneData>.unsync >>();

        private bool _NextStep()
        {
            if (dataStep_ >= listData_.Count)
            {
                return false;
            }

            StgStageScriptManager scriptManager = stageController_.GetScriptManagerP();

            // ���X�e�b�v�I���ʒm
            if (activeData_ != null)
            {
                scriptManager.RequestEventAll(StgStageScript.EV_END_BOSS_STEP);
            }

            dataIndex_++;
            if (dataIndex_ >= listData_[dataStep_].Count)
            {
                dataIndex_ = 0;
                while (true)
                {
                    dataStep_++;
                    if (dataStep_ >= listData_.Count)
                    {
                        return false;
                    }
                    if (listData_[dataStep_].Count > 0)
                    {
                        break;
                    }
                }
            }

            ref_count_ptr<StgEnemyBossSceneData>.unsync oldActiveData = new ref_count_ptr<StgEnemyBossSceneData>.unsync(activeData_);

            // �G�o�^
            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: activeData_ = listData_[dataStep_][dataIndex_];
            activeData_.CopyFrom(listData_[dataStep_][dataIndex_]);
            List<ref_count_ptr<StgEnemyBossObject>.unsync > listEnemy = activeData_.GetEnemyObjectList();
            List<double> listLife = activeData_.GetLifeList();
            for (int iEnemy = 0 ; iEnemy < listEnemy.Count ; iEnemy++)
            {
                ref_count_ptr<StgEnemyBossObject>.unsync obj = listEnemy[iEnemy];
                obj.SetLife(listLife[iEnemy]);
                if (oldActiveData != null)
                {
                    List<ref_count_ptr<StgEnemyBossObject>.unsync > listOldEnemyObject = oldActiveData.GetEnemyObjectList();
                    if (iEnemy < listOldEnemyObject.Count)
                    {
                        ref_count_ptr<StgEnemyBossObject>.unsync objOld = listOldEnemyObject[iEnemy];
                        obj.SetPositionX(objOld.GetPositionX());
                        obj.SetPositionY(objOld.GetPositionY());
                    }
                }
                objectManager.ActivateObject(obj.GetObjectID(), true);
            }

            // �X�N���v�g�J�n
            _int64 idScript = activeData_.GetScriptID();
            scriptManager.StartScript(idScript);

            // �V�X�e�b�v�J�n�ʒm
            scriptManager.RequestEventAll(StgStageScript.EV_START_BOSS_STEP);

            return true;
        }


        /**********************************************************
        //StgEnemyBossSceneObject
        **********************************************************/
        public StgEnemyBossSceneObject(StgStageController stageController)
        {
            stageController_ = stageController;
            typeObject_ = StgStageScript.OBJ_ENEMY_BOSS_SCENE;

            bVisible_ = false;
            bLoad_ = false;
            dataStep_ = 0;
            dataIndex_ = -1;
        }

        public override void Work()
        {
            if (activeData_.IsReadyNext())
            {
                // ���X�e�b�v�J�ډ
        // 		bool bEnemyExists = false;
                List<ref_count_ptr<StgEnemyBossObject>.unsync > listEnemy = activeData_.GetEnemyObjectList();
                for (int iEnemy = 0 ; iEnemy < listEnemy.Count ; iEnemy++)
                {
                    ref_count_ptr<StgEnemyBossObject>.unsync obj = listEnemy[iEnemy];
                    bEnemyExists |= (!obj.IsDeleted());
                }

                if (!bEnemyExists)
                {
                    bool bNext = _NextStep();
                    if (!bNext)
                    {
                        // �I��
                        StgEnemyManager enemyManager = stageController_.GetEnemyManager();
                        ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
                        objectManager.DeleteObject(idObject_);
                        enemyManager.SetBossSceneObject(null);
                        return;
                    }
                }

            }
            else if (!activeData_.IsReadyNext())
            {
                // �^�C�}�[�Ď�
                bool bZeroTimer = false;
                int timer = activeData_.GetSpellTimer();
                if (timer > 0)
                {
                    timer--;
                    activeData_.SetSpellTimer(timer);
                    if (timer == 0)
                    {
                        bZeroTimer = true;
                    }
                }

                // ���X�g�X�y���Ď�
                bool bEndLastSpell = false;
                if (activeData_.IsLastSpell())
                {
                    bEndLastSpell = activeData_.GetPlayerShootDownCount() > 0;
                }

                if (bZeroTimer || bEndLastSpell)
                {
                    // �^�C�}�[0�Ȃ�G�̃��C�t��0�ɂ���
                    List<ref_count_ptr<StgEnemyBossObject>.unsync > listEnemy = activeData_.GetEnemyObjectList();
                    for (int iEnemy = 0 ; iEnemy < listEnemy.Count ; iEnemy++)
                    {
                        ref_count_ptr<StgEnemyBossObject>.unsync obj = listEnemy[iEnemy];
                        obj.SetLife(0);
                    }

                    if (bZeroTimer)
                    {
                        // �^�C���A�E�g�ʒm
                        StgStageScriptManager scriptManager = stageController_.GetScriptManagerP();
                        scriptManager.RequestEventAll(StgStageScript.EV_TIMEOUT);
                    }
                }

                // ���V�[���ւ̑J�ڃt���O�ݒ�
                bool bReadyNext = true;
                List<ref_count_ptr<StgEnemyBossObject>.unsync > listEnemy = activeData_.GetEnemyObjectList();
                for (int iEnemy = 0 ; iEnemy < listEnemy.Count ; iEnemy++)
                {
                    ref_count_ptr<StgEnemyBossObject>.unsync obj = listEnemy[iEnemy];
                    if (obj.GetLife() > 0)
                    {
                        bReadyNext = false;
                    }
                }

                if (bReadyNext)
                {
                    if (activeData_.IsSpellCard())
                    {
                        // �X�y���J�[�h�擾
                        // �E�^�C�}�[0�^�X�y���g�p�^��e���͎擾�s��
                        // �E�ϋv�̏ꍇ�̓^�C�}�[0�ł�擾�
        // 				bool bGrain = true;
                        bGrain &= (activeData_.GetPlayerShootDownCount() == 0);
                        bGrain &= (activeData_.GetPlayerSpellCount() == 0);
                        bGrain &= (activeData_.IsDurable() || activeData_.GetSpellTimer() > 0);

                        if (bGrain)
                        {
                            StgStageScriptManager scriptManager = stageController_.GetScriptManagerP();
                            _int64 score = activeData_.GetCurrentSpellScore();
                            scriptManager.RequestEventAll(StgStageScript.EV_GAIN_SPELL);
                        }
                    }
                    activeData_.SetReadyNext();
                }

            }
        }

        public virtual void Activate()
        {
            // �X�N���v�g��ǂݍ���ł��Ȃ�������ǂݍ��ށB
            if (!bLoad_)
            {
                LoadAllScriptInThread();
            }

            StgStageScriptManager scriptManager = stageController_.GetScriptManagerP();
            ref_count_ptr<StgStageScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
            for (int iStep = 0 ; iStep < listData_.Count ; iStep++)
            {
                for (int iData = 0 ; iData < listData_[iStep].Count ; iData++)
                {
                    ref_count_ptr<StgEnemyBossSceneData>.unsync data = listData_[iStep][iData];
                    _int64 idScript = data.GetScriptID();
                    ref_count_ptr<ManagedScript> script = scriptManager.GetScript(idScript);
                    if (script == null)
                    {
                        throw new gstd.wexception(StringUtility.Format("�ǂݍ��܂�Ă��Ȃ��X�N���v�g�F%s", data.GetPath().c_str()).c_str());
                    }
                    if (!script.IsLoad())
                    {
                        int count = 0;
                        while (!script.IsLoad())
                        {
                            if (count % 1000 == 999)
                            {
                                string log = StringUtility.Format("�ǂݍ��݊����ҋ@(StgEnemyBossSceneObject)�F[%d, %d] %s", iStep, iData, data.GetPath().c_str());
                                Logger.WriteTop(log);

                            }
                            Sleep(1);
                            count++;
                        }
                    }

                    if (stageController_.GetSystemInformation().IsError())
                    {
                        continue;
                    }

                    // ���C�t�ǂݍ���
                    List<double> listLife = new List<double>();
                    gstd.value vLife = script.RequestEvent(StgStageScript.EV_REQUEST_LIFE);
                    if (script.IsRealValue(vLife))
                    {
                        double life = vLife.as_real();
                        listLife.Add(life);
                    }
                    else if (script.IsRealArrayValue(vLife))
                    {
                        int count = (int)vLife.length_as_array();
                        for (int iLife = 0 ; iLife < count ; iLife++)
                        {
                            double life = vLife.index_as_array((uint)iLife).as_real();
                            listLife.Add(life);
                        }
                    }

                    if (listLife.Count == 0)
                    {
                        throw new gstd.wexception(StringUtility.Format("�G���C�t��K�؂ɕԂ��Ă��܂���B(%s)", data.GetPath().c_str()).c_str());
                    }
                    data.SetLifeList(listLife);

                    // �^�C�}�[�ǂݍ���
                    gstd.value vTimer = script.RequestEvent(StgStageScript.EV_REQUEST_TIMER);
                    if (script.IsRealValue(vTimer))
                    {
                        data.SetOriginalSpellTimer(vTimer.as_real() * GlobalMembers.STANDARD_FPS);
                    }

                    // �X�y��
                    gstd.value vSpell = script.RequestEvent(StgStageScript.EV_REQUEST_IS_SPELL);
                    if (script.IsBooleanValue(vSpell))
                    {
                        data.SetSpellCard(vSpell.as_boolean());
                    }

                    {
                        // �X�R�A�A���X�g�X�y���A�ϋv�X�y����ǂݍ���
                        gstd.value vScore = script.RequestEvent(StgStageScript.EV_REQUEST_SPELL_SCORE);
                        if (script.IsRealValue(vScore))
                        {
                            data.SetSpellScore(vScore.as_real());
                        }

                        gstd.value vLast = script.RequestEvent(StgStageScript.EV_REQUEST_IS_LAST_SPELL);
                        if (script.IsBooleanValue(vLast))
                        {
                            data.SetLastSpell(vLast.as_boolean());
                        }

                        gstd.value vDurable = script.RequestEvent(StgStageScript.EV_REQUEST_IS_DURABLE_SPELL);
                        if (script.IsBooleanValue(vDurable))
                        {
                            data.SetDurable(vDurable.as_boolean());
                        }
                    }

                    // �G�I�u�W�F�N�g�쐬
                    List<ref_count_ptr<StgEnemyBossObject>.unsync > listEnemyObject = new List<ref_count_ptr<StgEnemyBossObject>.unsync >();
                    for (int iEnemy = 0 ; iEnemy < listLife.Count ; iEnemy++)
                    {
                        ref_count_ptr<StgEnemyBossObject>.unsync obj = new StgEnemyBossObject(stageController_);
                        int idEnemy = objectManager.AddObject(obj, false);
                        listEnemyObject.Add(obj);
                    }
                    data.SetEnemyObjectList(listEnemyObject);
                }
            }

            // �o�^
            _NextStep();

        }

        public override void Render()
        {
        } // ������Ȃ�
        public override void SetRenderState()
        {
        } // ������Ȃ�

        public void AddData(int step, ref_count_ptr<StgEnemyBossSceneData>.unsync data)
        {
            if (listData_.Count <= step)
            {
                listData_.Resize(step + 1);
            }
            listData_[step].Add(data);
        }

        public ref_count_ptr<StgEnemyBossSceneData>.unsync GetActiveData()
        {
            return new ref_count_ptr<StgEnemyBossSceneData>.unsync(activeData_);
        }
        public void LoadAllScriptInThread()
        {
            StgStageScriptManager scriptManager = stageController_.GetScriptManagerP();
            for (int iStep = 0 ; iStep < listData_.Count ; iStep++)
            {
                for (int iData = 0 ; iData < listData_[iStep].Count ; iData++)
                {
                    ref_count_ptr<StgEnemyBossSceneData>.unsync data = listData_[iStep][iData];
                    string path = data.GetPath();

                    _int64 idScript = scriptManager.LoadScriptInThread(path, StgStageScript.TYPE_SYSTEM);
                    data.SetScriptID(idScript);
                }
            }
            bLoad_ = true;
        }

        public int GetRemainStepCount()
        {
            int res = listData_.Count - dataStep_ - 1;
            res = System.Math.Max(res, 0);
            return res;
        }

        public int GetActiveStepLifeCount()
        {
            if (dataStep_ >= listData_.Count)
            {
                return 0;
            }
            return listData_[dataStep_].Count;
        }

        public double GetActiveStepTotalMaxLife()
        {
            if (dataStep_ >= listData_.Count)
            {
                return 0;
            }

            double res = 0;
            for (int iData = 0 ; iData < listData_[dataStep_].Count ; iData++)
            {
                ref_count_ptr<StgEnemyBossSceneData>.unsync data = listData_[dataStep_][iData];
                List<double> listLife = data.GetLifeList();
                for (int iLife = 0 ; iLife < listLife.Count ; iLife++)
                {
                    res += listLife[iLife];
                }
            }
            return res;
        }

        public double GetActiveStepTotalLife()
        {
            if (dataStep_ >= listData_.Count)
            {
                return 0;
            }

            double res = 0;
            for (int iData = dataIndex_ ; iData < listData_[dataStep_].Count ; iData++)
            {
                res += GetActiveStepLife(iData);
            }
            return res;
        }

        public double GetActiveStepLife(int index)
        {
            if (dataStep_ >= listData_.Count)
            {
                return 0;
            }
            if (index < dataIndex_)
            {
                return 0;
            }

            double res = 0;
            ref_count_ptr<StgEnemyBossSceneData>.unsync data = listData_[dataStep_][index];
            if (index == dataIndex_)
            {
                List<ref_count_ptr<StgEnemyBossObject>.unsync > listEnemyObject = data.GetEnemyObjectList();
                for (int iEnemy = 0 ; iEnemy < listEnemyObject.Count ; iEnemy++)
                {
                    ref_count_ptr<StgEnemyBossObject>.unsync obj = listEnemyObject[iEnemy];
                    res += obj.GetLife();
                }
            }
            else
            {
                List<double> listLife = data.GetLifeList();
                for (int iLife = 0 ; iLife < listLife.Count ; iLife++)
                {
                    res += listLife[iLife];
                }
            }
            return res;
        }

        public List<double> GetActiveStepLifeRateList()
        {
            List<double> res = new List<double>();
            int count = GetActiveStepLifeCount();
            double total = GetActiveStepTotalMaxLife();
            double rate = 0;
            for (int iData = 0 ; iData < count; iData++)
            {
                ref_count_ptr<StgEnemyBossSceneData>.unsync data = listData_[dataStep_][iData];

                double life = 0;
                List<double> listLife = data.GetLifeList();
                for (int iLife = 0 ; iLife < listLife.Count ; iLife++)
                {
                    life += listLife[iLife];
                }
                rate += life / total;
                res.Add(rate);
            }
            return new List<double>(res);
        }

        public int GetDataStep()
        {
            return dataStep_;
        }
        public int GetDataIndex()
        {
            return dataIndex_;
        }

        public void AddPlayerShootDownCount()
        {
            if (activeData_ == null)
            {
                return;
            }
            activeData_.AddPlayerShootDownCount();
        }

        public void AddPlayerSpellCount()
        {
            if (activeData_ == null)
            {
                return;
            }
            activeData_.AddPlayerSpellCount();
        }
}

public class StgEnemyBossSceneData : System.IDisposable
{
        private string path_ = "";
        private _int64 isScript_ = new _int64();
        private List<double> listLife_ = new List<double>();
        private List<ref_count_ptr<StgEnemyBossObject>.unsync > listEnemyObject_ = new List<ref_count_ptr<StgEnemyBossObject>.unsync >();
        private int countCreate_; // �{�X�������BlistEnemyObject_�𒴂��Đ������悤�Ƃ�����G���[�B
        private bool bReadyNext_;

        private bool bSpell_; // �X�y���J�[�h
        private bool bLastSpell_; // ���X�g�X�y��
        private bool bDurable_; // �ϋv�X�y��
        private _int64 scoreSpell_ = new _int64();
        private int timerSpellOrg_; // �����^�C�}�[ �t���[���P�� -1�Ŗ���
        private int timerSpell_; // �^�C�}�[ �t���[���P�� -1�Ŗ���
        private int countPlayerShootDown_; // ���@���j��
        private int countPlayerSpell_; // ���@�X�y���g�p��


        // StgEnemyBossSceneData
        public StgEnemyBossSceneData()
        {
            countCreate_ = 0;
            bReadyNext_ = false;

            scoreSpell_ = 0;
            timerSpell_ = -1;
            bSpell_ = false;
            bLastSpell_ = false;
            bDurable_ = false;
            countPlayerShootDown_ = 0;
            countPlayerSpell_ = 0;
        }

        public virtual void Dispose()
        {
        }
        public string GetPath()
        {
            return path_;
        }
        public void SetPath(string path)
        {
            path_ = path;
        }
        public _int64 GetScriptID()
        {
            return new _int64(isScript_);
        }
        public void SetScriptID(_int64 id)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: isScript_ = id;
            isScript_.CopyFrom(id);
        }
        public List<double> GetLifeList()
        {
            return new List<double>(listLife_);
        }
        public void SetLifeList(List<double> list)
        {
            listLife_ = new List<double>(list);
        }
        public List<ref_count_ptr<StgEnemyBossObject>.unsync > GetEnemyObjectList()
        {
            return new List<ref_count_ptr<StgEnemyBossObject>.unsync >(listEnemyObject_);
        }
        public void SetEnemyObjectList(List<ref_count_ptr<StgEnemyBossObject>.unsync > list)
        {
            listEnemyObject_ = new List<ref_count_ptr<StgEnemyBossObject>.unsync >(list);
        }
        public int GetEnemyBossIdInCreate()
        {
            if (countCreate_ >= listEnemyObject_.Count)
            {
                string log = StringUtility.Format("EnemyBoss�I�u�W�F�N�g�͂���ȏ�쐬�ł��܂���:%d", countCreate_);
                throw new gstd.wexception(log);
            }

            ref_count_ptr<StgEnemyBossObject>.unsync obj = listEnemyObject_[countCreate_];
            countCreate_++;

            return obj.GetObjectID();
        }

        public bool IsReadyNext()
        {
            return bReadyNext_;
        }
        public void SetReadyNext()
        {
            bReadyNext_ = true;
        }

        public _int64 GetCurrentSpellScore()
        {
            _int64 res = new _int64(scoreSpell_);
            if (!bDurable_)
            {
                double rate = (double)timerSpell_ / (double)timerSpellOrg_;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res = scoreSpell_ * rate;
                res.CopyFrom(scoreSpell_ * rate);
            }
            return new _int64(res);
        }

        public _int64 GetSpellScore()
        {
            return new _int64(scoreSpell_);
        }
        public void SetSpellScore(_int64 score)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: scoreSpell_ = score;
            scoreSpell_.CopyFrom(score);
        }
        public int GetSpellTimer()
        {
            return timerSpell_;
        }
        public void SetSpellTimer(int timer)
        {
            timerSpell_ = timer;
        }
        public int GetOriginalSpellTimer()
        {
            return timerSpellOrg_;
        }
        public void SetOriginalSpellTimer(int timer)
        {
            timerSpellOrg_ = timer;
            timerSpell_ = timer;
        }
        public bool IsSpellCard()
        {
            return bSpell_;
        }
        public void SetSpellCard(bool b)
        {
            bSpell_ = b;
        }
        public bool IsLastSpell()
        {
            return bLastSpell_;
        }
        public void SetLastSpell(bool b)
        {
            bLastSpell_ = b;
        }
        public bool IsDurable()
        {
            return bDurable_;
        }
        public void SetDurable(bool b)
        {
            bDurable_ = b;
        }

        public void AddPlayerShootDownCount()
        {
            countPlayerShootDown_++;
        }
        public int GetPlayerShootDownCount()
        {
            return countPlayerShootDown_;
        }
        public void AddPlayerSpellCount()
        {
            countPlayerSpell_++;
        }
        public int GetPlayerSpellCount()
        {
            return countPlayerSpell_;
        }
}


