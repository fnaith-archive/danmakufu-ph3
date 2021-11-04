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
// class StgIntersectionSpace;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgIntersectionCheckList;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgIntersectionTarget;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgIntersectionObject;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgIntersectionTargetPoint;

/**********************************************************
//StgIntersectionManager
//���L��Q�l
//http://marupeke296.com/COL_2D_No8_QuadTree.html
**********************************************************/
public class StgIntersectionManager : ObjectPool<StgIntersectionTarget, false>, System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        private enum AnonymousEnum
        {
            SPACE_PLAYER_ENEMY = 0, // ���@-�G�A�G�e
            SPACE_PLAYERSOHT_ENEMY, // ���e,�X�y��-�G
            SPACE_PLAYERSHOT_ENEMYSHOT // ���e,�X�y��-�G�e
        }
        private List<ref_count_ptr<StgIntersectionSpace>> listSpace_ = new List<ref_count_ptr<StgIntersectionSpace>>();
        private List<StgIntersectionTargetPoint> listEnemyTargetPoint_ = new List<StgIntersectionTargetPoint>();
        private List<StgIntersectionTargetPoint> listEnemyTargetPointNext_ = new List<StgIntersectionTargetPoint>();

        private virtual void _ResetPoolObject(gstd.ref_count_ptr<StgIntersectionTarget>.unsync obj)
        {
        // 	ELogger::WriteTop(StringUtility::Format("_ResetPoolObject:start:%s)", obj->GetInfoAsString().c_str()));
            obj.obj_ = null;
        // 	ELogger::WriteTop("_ResetPoolObject:end");
        }

        private virtual gstd.ref_count_ptr<StgIntersectionTarget>.unsync _CreatePoolObject(int type)
        {
            gstd.ref_count_ptr<StgIntersectionTarget>.unsync res = null;
            switch (type)
            {
                case StgIntersectionTarget.AnonymousEnum3.SHAPE_CIRCLE:
                    res = new StgIntersectionTarget_Circle();
                    break;
                case StgIntersectionTarget.AnonymousEnum3.SHAPE_LINE:
                    res = new StgIntersectionTarget_Line();
                    break;
            }
            return new gstd.ref_count_ptr<StgIntersectionTarget>.unsync(res);
        }


        /**********************************************************
        //StgIntersectionManager
        **********************************************************/
        public StgIntersectionManager()
        {
            DirectGraphics graphics = DirectGraphics.GetBase();
            int screenWidth = graphics.GetScreenWidth();
            int screenHeight = graphics.GetScreenWidth();

            _CreatePool(2);
            listSpace_.Resize(3);
            for (int iSpace = 0 ; iSpace < listSpace_.Count ; iSpace++)
            {
                StgIntersectionSpace space = new StgIntersectionSpace();
                space.Initialize(4, -100, -100, screenWidth + 100, screenHeight + 100);
                listSpace_[iSpace] = space;
            }
        }

        public virtual void Dispose()
        {
        }

        public void Work()
        {
            listEnemyTargetPoint_ = new List<StgIntersectionTargetPoint>(listEnemyTargetPointNext_);
            listEnemyTargetPointNext_.Clear();

            int totalCheck = 0;
            List<ref_count_ptr<StgIntersectionSpace>>.Enumerator itr = listSpace_.GetEnumerator();
            while (itr.MoveNext())
            {
                StgIntersectionSpace space = itr.Current.GetPointer();
                ref_count_ptr<StgIntersectionCheckList>.unsync listCheck = space.CreateIntersectionCheckList();
                int countCheck = listCheck.GetCheckCount();
                for (int iCheck = 0 ; iCheck < countCheck ; iCheck++)
                {
                    // Get��1�񂵂��g�p�ł��܂���
                    ref_count_ptr<StgIntersectionTarget>.unsync targetA = listCheck.GetTargetA(iCheck);
                    ref_count_ptr<StgIntersectionTarget>.unsync targetB = listCheck.GetTargetB(iCheck);

                    bool bIntersected = IsIntersected(targetA, targetB);
                    if (!bIntersected)
                    {
                        continue;
                    }

                    // Graze�̊֌W�ŁA��Ɏ��@�̓����蔻������K�v������B
                    ref_count_weak_ptr<StgIntersectionObject>.unsync objA = targetA.GetObject();
                    ref_count_weak_ptr<StgIntersectionObject>.unsync objB = targetB.GetObject();
                    if (objA != null)
                    {
                        objA.Intersect(targetA, targetB);
                        objA.SetIntersected();

                        if (objB != null)
                        {
                            int idObject = objB.GetDxScriptObjectID();
                            objA.AddIntersectedId(idObject);
                        }
                    }

                    if (objB != null)
                    {
                        objB.Intersect(targetB, targetA);
                        objB.SetIntersected();
                        if (objA != null)
                        {
                            int idObject = objA.GetDxScriptObjectID();
                            objB.AddIntersectedId(idObject);
                        }
                    }
                }

                totalCheck += countCheck;
                space.ClearTarget();
            }

            _ArrangePool();

            ELogger logger = ELogger.GetInstance();
            if (logger.IsWindowVisible())
            {
                int countUsed = GetUsedPoolObjectCount();
                int countCache = GetCachePoolObjectCount();
                logger.SetInfo(9, "stg intersection_count", StringUtility.Format("used=%4d, cache=%4d, total=%4d check=%4d", countUsed, countCache, countUsed + countCache, totalCheck));
            }
        }

        public void AddTarget(ref_count_ptr<StgIntersectionTarget>.unsync target)
        {
            // SPACE_PLAYER_ENEMY = 0,//���@-�G�A�G�e
            // SPACE_PLAYERSOHT_ENEMY,//���e,�X�y��-�G
            // SPACE_PLAYERSHOT_ENEMYSHOT,//���e,�X�y��-�G�e

            target.SetMortonNumber(-1);
            // target->ClearObjectIntersectedIdList();

            int type = target.GetTargetType();
            switch (type)
            {
                case StgIntersectionTarget.AnonymousEnum3.TYPE_PLAYER:
                {
                    listSpace_[(int)AnonymousEnum.SPACE_PLAYER_ENEMY].RegistTargetA(target);
                    break;
                }

                case StgIntersectionTarget.AnonymousEnum3.TYPE_PLAYER_SHOT:
                case StgIntersectionTarget.AnonymousEnum3.TYPE_PLAYER_SPELL:
                {
                    listSpace_[(int)AnonymousEnum.SPACE_PLAYERSOHT_ENEMY].RegistTargetA(target);

                    // �e�����\�͕t���Ȃ�
                    bool bEraseShot = false;
                    if (type == (int)StgIntersectionTarget.AnonymousEnum3.TYPE_PLAYER_SHOT)
                    {
                        StgShotObject shot = (StgShotObject)target.GetObject().GetPointer();
                        if (shot != null)
                        {
                            bEraseShot = shot.IsEraseShot();
                        }
                    }
                    else if (type == (int)StgIntersectionTarget.AnonymousEnum3.TYPE_PLAYER_SPELL)
                    {
                        StgPlayerSpellObject spell = (StgPlayerSpellObject)target.GetObject().GetPointer();
                        if (spell != null)
                        {
                            bEraseShot = spell.IsEraseShot();
                        }
                    }

                    if (bEraseShot)
                    {
                        listSpace_[(int)AnonymousEnum.SPACE_PLAYERSHOT_ENEMYSHOT].RegistTargetA(target);
                    }
                    break;
                }

                case StgIntersectionTarget.AnonymousEnum3.TYPE_ENEMY:
                {
                    listSpace_[(int)AnonymousEnum.SPACE_PLAYER_ENEMY].RegistTargetB(target);
                    listSpace_[(int)AnonymousEnum.SPACE_PLAYERSOHT_ENEMY].RegistTargetB(target);

                    ref_count_ptr<StgIntersectionTarget_Circle>.unsync circle = new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(target);
                    if (circle != null)
                    {
                        ref_count_weak_ptr<StgEnemyObject>.unsync objEnemy = new ref_count_weak_ptr<StgEnemyObject>.unsync(target.GetObject());
                        if (objEnemy != null)
                        {
                            int idObject = objEnemy.GetObjectID();
                            POINT pos = new POINT((int)circle.GetCircle().GetX(), (int)circle.GetCircle().GetY());
                            StgIntersectionTargetPoint tp = new StgIntersectionTargetPoint();
                            tp.SetObjectID(idObject);
                            tp.SetPoint(pos);
                            listEnemyTargetPointNext_.Add(tp);
                        }
                    }

                    break;
                }

                case StgIntersectionTarget.AnonymousEnum3.TYPE_ENEMY_SHOT:
                {
                    listSpace_[(int)AnonymousEnum.SPACE_PLAYER_ENEMY].RegistTargetB(target);
                    listSpace_[(int)AnonymousEnum.SPACE_PLAYERSHOT_ENEMYSHOT].RegistTargetB(target);
                    break;
                }
            }
        }

        public void AddEnemyTargetToShot(ref_count_ptr<StgIntersectionTarget>.unsync target)
        {
            target.SetMortonNumber(-1);
            // target->ClearObjectIntersectedIdList();

            int type = target.GetTargetType();
            switch (type)
            {
                case StgIntersectionTarget.AnonymousEnum3.TYPE_ENEMY:
                {
                    listSpace_[(int)AnonymousEnum.SPACE_PLAYERSOHT_ENEMY].RegistTargetB(target);

                    ref_count_ptr<StgIntersectionTarget_Circle>.unsync circle = new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(target);
                    if (circle != null)
                    {
                        ref_count_weak_ptr<StgEnemyObject>.unsync objEnemy = new ref_count_weak_ptr<StgEnemyObject>.unsync(target.GetObject());
                        if (objEnemy != null)
                        {
                            int idObject = objEnemy.GetObjectID();
                            POINT pos = new POINT((int)circle.GetCircle().GetX(), (int)circle.GetCircle().GetY());
                            StgIntersectionTargetPoint tp = new StgIntersectionTargetPoint();
                            tp.SetObjectID(idObject);
                            tp.SetPoint(pos);
                            listEnemyTargetPointNext_.Add(tp);
                        }
                    }

                    break;
                }
            }
        }

        public void AddEnemyTargetToPlayer(ref_count_ptr<StgIntersectionTarget>.unsync target)
        {
            target.SetMortonNumber(-1);
            // target->ClearObjectIntersectedIdList();

            int type = target.GetTargetType();
            switch (type)
            {
                case StgIntersectionTarget.AnonymousEnum3.TYPE_ENEMY:
                {
                    listSpace_[(int)AnonymousEnum.SPACE_PLAYER_ENEMY].RegistTargetB(target);
                    break;
                }
            }
        }

        public List<StgIntersectionTargetPoint> GetAllEnemyTargetPoint()
        {
            return new List<StgIntersectionTargetPoint>(listEnemyTargetPoint_);
        }

        public void CheckDeletedObject(string funcName)
        {
            int countType = listUsedPool_.size();
            for (int iType = 0 ; iType < countType ; iType++)
            {
                LinkedList<gstd.ref_count_ptr<StgIntersectionTarget, false>> listUsed = listUsedPool_[iType];
                List<gstd.ref_count_ptr<StgIntersectionTarget, false>> listCache = listCachePool_[iType];

                LinkedList<gstd.ref_count_ptr<StgIntersectionTarget, false>>.Enumerator itr = listUsed.GetEnumerator();
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                for (; itr != listUsed.end() ; itr++)
                {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    gstd.ref_count_ptr<StgIntersectionTarget, false> target = (itr);
                    ref_count_weak_ptr<DxScriptObjectBase>.unsync dxObj = new ref_count_weak_ptr<DxScriptObjectBase>.unsync(target.GetObject());
                    if (dxObj != null && dxObj.IsDeleted())
                    {
                        ELogger.WriteTop(StringUtility.Format("%s(deleted):%s", funcName, target.GetInfoAsString().c_str()));
                    }
                }
            }
        }

        public static bool IsIntersected(ref_count_ptr<StgIntersectionTarget>.unsync target1, ref_count_ptr<StgIntersectionTarget>.unsync target2)
        {
            bool res = false;
            int shape1 = target1.GetShape();
            int shape2 = target2.GetShape();
            if (shape1 == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_CIRCLE && shape2 == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_CIRCLE)
            {
                ref_count_ptr<StgIntersectionTarget_Circle>.unsync c1 = new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(target1);
                ref_count_ptr<StgIntersectionTarget_Circle>.unsync c2 = new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(target2);
                res = DxMath.IsIntersected(c1.GetCircle(), c2.GetCircle());
            }
            else if ((shape1 == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_CIRCLE && shape2 == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_LINE) || (shape1 == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_LINE && shape2 == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_CIRCLE))
            {
                ref_count_ptr<StgIntersectionTarget_Circle>.unsync c = null;
                ref_count_ptr<StgIntersectionTarget_Line>.unsync l = null;
                if (shape1 == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_CIRCLE && shape2 == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_LINE)
                {
                    c = ref_count_ptr<StgIntersectionTarget_Circle>.unsync.DownCast(target1);
                    l = ref_count_ptr<StgIntersectionTarget_Line>.unsync.DownCast(target2);
                }
                else
                {
                    c = ref_count_ptr<StgIntersectionTarget_Circle>.unsync.DownCast(target2);
                    l = ref_count_ptr<StgIntersectionTarget_Line>.unsync.DownCast(target1);
                }

                res = IsIntersected(c.GetCircle(), l.GetLine());
            }
            else if (shape1 == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_LINE && shape2 == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_LINE)
            {
                ref_count_ptr<StgIntersectionTarget_Line>.unsync l1 = new ref_count_ptr<StgIntersectionTarget_Line>.unsync(target1);
                ref_count_ptr<StgIntersectionTarget_Line>.unsync l2 = new ref_count_ptr<StgIntersectionTarget_Line>.unsync(target2);
                res = IsIntersected(l1.GetLine(), l2.GetLine());
            }
            return res;
        }

        public static bool IsIntersected(DxCircle circle, DxWidthLine line)
        {
            {
            // ��[������͏I�[���~��ɂ��邩�𒲂ׂ�
                double radius = circle.GetR();
                double dist1 = System.Math.Pow(System.Math.Pow(circle.GetX() - line.GetX1(),2) + System.Math.Pow(circle.GetY() - line.GetY1(),2), 0.5);
                double dist2 = System.Math.Pow(System.Math.Pow(circle.GetX() - line.GetX2(),2) + System.Math.Pow(circle.GetY() - line.GetY2(),2), 0.5);
                if (radius >= dist1 || radius >= dist2)
                {
                    return true;
                }
            }

            {
            // ������ɉ~�����邩�𒲂ׂ�
                double lx1 = line.GetX2() - line.GetX1();
                double ly1 = line.GetY2() - line.GetY1();
                double cx1 = circle.GetX() - line.GetX1();
                double cy1 = circle.GetY() - line.GetY1();
                double inner1 = lx1 * cx1 + ly1 * cy1;

                double lx2 = line.GetX1() - line.GetX2();
                double ly2 = line.GetY1() - line.GetY2();
                double cx2 = circle.GetX() - line.GetX2();
                double cy2 = circle.GetY() - line.GetY2();
                double inner2 = lx2 * cx2 + ly2 * cy2;

                if (inner1 < 0 || inner2 < 0)
                {
                    return false;
                }
            }

            if (false)
            { // tr1:���[�U�[�̒����Atr2:���[�U�[�̐悩�画���܂ł̒���
                double radius = circle.GetR(); // pow(pow(line.GetX2()-line.GetX1(),2) + pow(line.GetY2()-line.GetY1(),2), 0.5);
                double dist1 = System.Math.Pow(System.Math.Pow(circle.GetX() - line.GetX1(),2) + System.Math.Pow(circle.GetY() - line.GetY1(),2), 0.5);
                double dist2 = System.Math.Pow(System.Math.Pow(circle.GetX() - line.GetX2(),2) + System.Math.Pow(circle.GetY() - line.GetY2(),2), 0.5);
                // tr1 -= 18;//�[�𔻒肵�Ȃ����߂̕␳
                // if(tr1 < 18)tr1 = 18;
                if (radius < dist1 && radius < dist2)
                {
                    return false;
                }
            }

            double lx = line.GetX2() - line.GetX1();
            double ly = line.GetY2() - line.GetY1();
            double px = circle.GetX() - line.GetX1();
            double py = circle.GetY() - line.GetY1();
            double u = System.Math.Pow(System.Math.Pow(lx,2) + System.Math.Pow(ly, 2), 0.5); // �����̋���
            if (u <= 0)
            {
                return false;
            }

            double ux = lx / u; // �����̒P�ʃx�N�g��x
            double uy = ly / u; // �����̒P�ʃx�N�g��z
            double d = px * ux + py * uy; // �����̒P�ʃx�N�g���Ǝn�_����_�܂Ńx�N�g���̓��
            double qx = d * ux;
            double qy = d * uy;
            double rx = px - qx; // �_���璼���܂ł̍ŒZ�����x�N�g��x
            double ry = py - qy; // �_���璼���܂ł̍ŒZ�����x�N�g��z
            double e = System.Math.Pow(System.Math.Pow(rx, 2) + System.Math.Pow(ry, 2),0.5); // �����̂Ɠ_�̋���
            double r = line.GetWidth() + circle.GetR();
            bool res = e < r;
            return res;
        }

        public static bool IsIntersected(DxWidthLine line1, DxWidthLine line2)
        {
            return false;
        }
}

/**********************************************************
//StgIntersectionSpace
//�ȉ��T�C�g��Q�l
//�@���~�i�܂�؂��j����[�ǂ��ƃR��
//�@http://marupeke296.com/
**********************************************************/
public class StgIntersectionSpace : System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
    private enum AnonymousEnum2
    {
        MAX_LEVEL = 9,
        TYPE_A = 0,
        TYPE_B = 1
    }
        // Cell TARGETA/B listTarget
        protected List<List<List<ref_count_ptr<StgIntersectionTarget>.unsync >> > listCell_ = new List<List<List<ref_count_ptr<StgIntersectionTarget>.unsync >> >();
        protected int[] listCountLevel_ = new int[(int)AnonymousEnum2.MAX_LEVEL + 1]; // �e���x���̃Z����
        protected double spaceWidth_; // �̈��X����
        protected double spaceHeight_; // �̈��Y����
        protected double spaceLeft_; // �̈�̍����iX���ŏ��l�j
        protected double spaceTop_; // �̈�̏㑤�iY���ŏ��l�j
        protected double unitWidth_; // �ŏ����x����Ԃ̕��P��
        protected double unitHeight_; // �ŏ����x����Ԃ̍��P��
        protected int countCell_; // ��Ԃ̐�
        protected int unitLevel_; // �ŉ��ʃ��x��
        protected ref_count_ptr<StgIntersectionCheckList>.unsync listCheck_ = new ref_count_ptr<StgIntersectionCheckList>.unsync();

        protected uint _GetMortonNumber(float left, float top, float right, float bottom)
        {
            // ���W�����Ԕԍ���Z�o
            // �ŏ����x���ɂ�����e���ʒu��Z�o
            uint LT = _GetPointElem(left, top);
            uint RB = _GetPointElem(right, bottom);

            // ��Ԕԍ��̔r���I�_���a����
            // �������x����Z�o
            uint def = RB ^ LT;
            uint hiLevel = 0;
            for (int iLevel = 0; iLevel < unitLevel_; iLevel++)
            {
                uint Check = (uint)((def >> (iLevel * 2)) & 0x3);
                if (Check != 0)
                {
                    hiLevel = (uint)(iLevel + 1);
                }
            }
            uint spaceIndex = (uint)(RB >> (hiLevel * 2));
            uint addIndex = (uint)((listCountLevel_[unitLevel_ - hiLevel] - 1) / 3);
            spaceIndex += addIndex;

            if (spaceIndex > countCell_)
            {
                return 0xffffffff;
            }

            return spaceIndex;
        }

        protected uint _BitSeparate32(uint n)
        {
            // �r�b�g�����֐�
            n = (n | (n << 8)) & 0x00ff00ff;
            n = (n | (n << 4)) & 0x0f0f0f0f;
            n = (n | (n << 2)) & 0x33333333;
            return (n | (n << 1)) & 0x55555555;
        }

        protected ushort _Get2DMortonNumber(ushort x, ushort y)
        {
            // 2D���[�g����Ԕԍ��Z�o�֐�
            return (ushort)(_BitSeparate32(x) | (_BitSeparate32(y) << 1));
        }

        protected uint _GetPointElem(float pos_x, float pos_y)
        {
            // ���W�����`4���ؗv�f�ԍ��ϊ��֐�
            float val1 = System.Math.Max(pos_x - spaceLeft_, 0);
            float val2 = System.Math.Max(pos_y - spaceTop_, 0);
            return _Get2DMortonNumber((ushort)(val1 / unitWidth_), (ushort)(val2 / unitHeight_));
        }

        protected void _WriteIntersectionCheckList(int indexSpace, ref_count_ptr<StgIntersectionCheckList>.unsync listCheck, List<List<ref_count_ptr<StgIntersectionTarget>.unsync >> listStack)
        {
            List<List<ref_count_ptr<StgIntersectionTarget>.unsync >> listCell = listCell_[indexSpace];
            int typeCount = listCell.Count;
            for (int iType1 = 0 ; iType1 < typeCount ; iType1++)
            {
                List<ref_count_ptr<StgIntersectionTarget>.unsync > list1 = listCell[iType1];
                int iType2 = 0;
                for (iType2 = iType1 + 1 ; iType2 < typeCount ; iType2++)
                {
                    List<ref_count_ptr<StgIntersectionTarget>.unsync > list2 = listCell[iType2];

                    // �@ ��ԓ�̃I�u�W�F�N�g���m�̏Փ˃��X�g�쐬
                    List<ref_count_ptr<StgIntersectionTarget>.unsync >.Enumerator itr1 = list1.GetEnumerator();
                    while (itr1.MoveNext())
                    {
                        List<ref_count_ptr<StgIntersectionTarget>.unsync >.Enumerator itr2 = list2.GetEnumerator();
                        while (itr2.MoveNext())
                        {
                            ref_count_ptr<StgIntersectionTarget>.unsync target1 = itr1.Current;
                            ref_count_ptr<StgIntersectionTarget>.unsync target2 = itr2.Current;
                            listCheck.Add(target1, target2);
                        }
                    }

                }

                List<ref_count_ptr<StgIntersectionTarget>.unsync > stack = listStack[iType1];
                for (iType2 = 0; iType2 < typeCount ; iType2++)
                {
                    if (iType1 == iType2)
                    {
                        continue;
                    }
                    List<ref_count_ptr<StgIntersectionTarget>.unsync > list2 = listCell[iType2];

                    // �A �Փ˃X�^�b�N�Ƃ̏Փ˃��X�g�쐬
                    List<ref_count_ptr<StgIntersectionTarget>.unsync >.Enumerator itrStack = stack.GetEnumerator();
                    while (itrStack.MoveNext())
                    {
                        List<ref_count_ptr<StgIntersectionTarget>.unsync >.Enumerator itr2 = list2.GetEnumerator();
                        while (itr2.MoveNext())
                        {
                            ref_count_ptr<StgIntersectionTarget>.unsync target2 = itr2.Current;
                            ref_count_ptr<StgIntersectionTarget>.unsync targetStack = itrStack.Current;
                            if (iType1 < iType2)
                            {
                                listCheck.Add(targetStack, target2);
                            }
                            else
                            {
                                listCheck.Add(target2, targetStack);
                            }
                        }
                    }
                }
            }

            // ��ԓ�̃I�u�W�F�N�g��X�^�b�N�ɒǉ�
            int iType = 0;
            for (iType = 0 ; iType < typeCount ; iType++)
            {
                List<ref_count_ptr<StgIntersectionTarget>.unsync > list = listCell[iType];
                List<ref_count_ptr<StgIntersectionTarget>.unsync > stack = listStack[iType];
                List<ref_count_ptr<StgIntersectionTarget>.unsync >.Enumerator itr = list.GetEnumerator();
                while (itr.MoveNext())
                {
                    ref_count_ptr<StgIntersectionTarget>.unsync target = itr.Current;
                    stack.Add(target);
                }
            }

            // �B �q��ԂɈړ�
            for (int iChild = 0 ; iChild < 4 ; iChild++)
            {
                int indexChild = indexSpace * 4 + 1 + iChild;
                if (indexChild < countCell_)
                {
                    _WriteIntersectionCheckList(indexChild, listCheck, listStack);
                }
            }

            // �X�^�b�N������
            for (iType = 0 ; iType < typeCount ; iType++)
            {
                List<ref_count_ptr<StgIntersectionTarget>.unsync > list = listCell[iType];
                List<ref_count_ptr<StgIntersectionTarget>.unsync > stack = listStack[iType];
                int count = list.Count;
                for (int iCount = 0 ; iCount < count ; iCount++)
                {
                    stack.RemoveAt(stack.Count - 1);
                }
            }
        }


        /**********************************************************
        //StgIntersectionSpace
        **********************************************************/
        public StgIntersectionSpace()
        {
            spaceLeft_ = 0;
            spaceTop_ = 0;
            spaceWidth_ = 0;
            spaceHeight_ = 0;
            unitWidth_ = 0;
            unitHeight_ = 0;
            countCell_ = 0;
            unitLevel_ = 0;

            // �e���x���ł̋�Ԑ���Z�o
            listCountLevel_[0] = 1;
            for (int iLevel = 1 ; iLevel < (int)AnonymousEnum2.MAX_LEVEL + 1 ; iLevel++)
            {
                listCountLevel_[iLevel] = listCountLevel_[iLevel - 1] * 4;
            }

            listCheck_ = new StgIntersectionCheckList();

        }

        public virtual void Dispose()
        {
        }

        public bool Initialize(int level, int left, int top, int right, int bottom)
        {
            // �ݒ�ō����x���ȏ�̋�Ԃ͍��Ȃ�
            if (level >= (int)AnonymousEnum2.MAX_LEVEL)
            {
                return false;
            }

            countCell_ = (listCountLevel_[level + 1] - 1) / 3;
            listCell_.Resize(countCell_);
            for (int iCell = 0 ; iCell < listCell_.Count ; iCell++)
            {
                listCell_[iCell].Resize(2);
            }

            spaceLeft_ = left;
            spaceTop_ = top;
            spaceWidth_ = right - left;
            spaceHeight_ = bottom - top;

            unitWidth_ = spaceWidth_ / (1 << level);
            unitHeight_ = spaceHeight_ / (1 << level);
            unitLevel_ = level;

            return true;
        }

        public bool RegistTarget(int type, ref_count_ptr<StgIntersectionTarget>.unsync target)
        {
            RECT rect = target.GetIntersectionSapceRect();
            if (rect.right < spaceLeft_ || rect.bottom < spaceTop_ || rect.left > (spaceLeft_ + spaceWidth_) || rect.top > (spaceTop_ + spaceHeight_))
            {
                return false;
            }

            // �I�u�W�F�N�g�̋��E�͈͂���o�^���[�g���ԍ���Z�o
            bool res = false;
            int index = target.GetMortonNumber();
            if (index < 0)
            {
                index = (int)_GetMortonNumber(rect.left, rect.top, rect.right, rect.bottom);
                target.SetMortonNumber(index);
            }

            if (index >= 0 && index < countCell_)
            {
                listCell_[index][type].Add(target);
                res = true;
            }

            return res;
        }

        public bool RegistTargetA(ref_count_ptr<StgIntersectionTarget>.unsync target)
        {
            return RegistTarget((int)AnonymousEnum2.TYPE_A, target);
        }
        public bool RegistTargetB(ref_count_ptr<StgIntersectionTarget>.unsync target)
        {
            return RegistTarget((int)AnonymousEnum2.TYPE_B, target);
        }
        public void ClearTarget()
        {
            for (int iCell = 0 ; iCell < listCell_.Count ; iCell++)
            {
                for (int iType = 0 ; iType < listCell_[iCell].Count ; iType++)
                {
                    listCell_[iCell][iType].Clear();
                }
            }
        }

        public ref_count_ptr<StgIntersectionCheckList>.unsync CreateIntersectionCheckList()
        {
            ref_count_ptr<StgIntersectionCheckList>.unsync res = new ref_count_ptr<StgIntersectionCheckList>.unsync(listCheck_);
            res.Clear();
            List<List<ref_count_ptr<StgIntersectionTarget>.unsync >> listStack = new List<List<ref_count_ptr<StgIntersectionTarget>.unsync >>();
            listStack.Resize(listCell_[0].Count);

            _WriteIntersectionCheckList(0, res, listStack);

            return new ref_count_ptr<StgIntersectionCheckList>.unsync(res);
        }
}

public class StgIntersectionCheckList : System.IDisposable
{
        private int count_;
        private List<ref_count_ptr<StgIntersectionTarget>.unsync > listTargetA_ = new List<ref_count_ptr<StgIntersectionTarget>.unsync >();
        private List<ref_count_ptr<StgIntersectionTarget>.unsync > listTargetB_ = new List<ref_count_ptr<StgIntersectionTarget>.unsync >();
        public StgIntersectionCheckList()
        {
            count_ = 0;
        }
        public virtual void Dispose()
        {
        }

        public void Clear()
        {
            count_ = 0;
        }
        public int GetCheckCount()
        {
            return count_;
        }
        public void Add(ref_count_ptr<StgIntersectionTarget>.unsync targetA, ref_count_ptr<StgIntersectionTarget>.unsync targetB)
        {
            if (listTargetA_.Count <= count_)
            {
                listTargetA_.Add(targetA);
                listTargetB_.Add(targetB);
            }
            else
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: listTargetA_[count_] = targetA;
                listTargetA_[count_].CopyFrom(targetA);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: listTargetB_[count_] = targetB;
                listTargetB_[count_].CopyFrom(targetB);
            }
            count_++;
        }
        public ref_count_ptr<StgIntersectionTarget>.unsync GetTargetA(int index)
        {
            ref_count_ptr<StgIntersectionTarget>.unsync res = listTargetA_[index];
            listTargetA_[index] = null;
            return new ref_count_ptr<StgIntersectionTarget>.unsync(res);
        }
        public ref_count_ptr<StgIntersectionTarget>.unsync GetTargetB(int index)
        {
            ref_count_ptr<StgIntersectionTarget>.unsync res = listTargetB_[index];
            listTargetB_[index] = null;
            return new ref_count_ptr<StgIntersectionTarget>.unsync(res);
        }
}

public abstract class StgIntersectionObject : System.IDisposable
{
        protected bool bIntersected_; // �Փ˔���
        protected int intersectedCount_;
        protected List<ref_count_ptr<StgIntersectionTarget>.unsync > listRelativeTarget_ = new List<ref_count_ptr<StgIntersectionTarget>.unsync >();
        protected List<DxCircle> listOrgCircle_ = new List<DxCircle>();
        protected List<DxWidthLine> listOrgLine_ = new List<DxWidthLine>();
        protected List<int> listIntersectedID_ = new List<int>();

        public StgIntersectionObject()
        {
            bIntersected_ = false;
            intersectedCount_ = 0;
        }
        public virtual void Dispose()
        {
        }
        public abstract void Intersect(ref_count_ptr<StgIntersectionTarget>.unsync ownTarget, ref_count_ptr<StgIntersectionTarget>.unsync otherTarget);
        public void ClearIntersected()
        {
            bIntersected_ = false;
            intersectedCount_ = 0;
        }
        public bool IsIntersected()
        {
            return bIntersected_;
        }
        public void SetIntersected()
        {
            bIntersected_ = true;
            intersectedCount_++;
        }
        public int GetIntersectedCount()
        {
            return intersectedCount_;
        }
        public void ClearIntersectedIdList()
        {
            if (listIntersectedID_.Count > 0)
            {
                listIntersectedID_.Clear();
            }
        }
        public void AddIntersectedId(int id)
        {
            listIntersectedID_.Add(id);
        }
        public List<int> GetIntersectedIdList()
        {
            return new List<int>(listIntersectedID_);
        }


        // StgIntersectionObject
        public void ClearIntersectionRelativeTarget()
        {
            for (int iTarget = 0 ; iTarget < listRelativeTarget_.Count ; iTarget++)
            {
                ref_count_weak_ptr<StgIntersectionTarget>.unsync target = listRelativeTarget_[iTarget];
                target.SetObject(null);
            }
            listRelativeTarget_.Clear();
        }

        public void AddIntersectionRelativeTarget(ref_count_ptr<StgIntersectionTarget>.unsync target)
        {
            listRelativeTarget_.Add(target);
            int shape = target.GetShape();
            if (shape == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_CIRCLE)
            {
                StgIntersectionTarget_Circle tTarget = (StgIntersectionTarget_Circle)target.GetPointer();
                listOrgCircle_.Add(tTarget.GetCircle());
            }
            else if (shape == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_LINE)
            {
                StgIntersectionTarget_Line tTarget = (StgIntersectionTarget_Line)target.GetPointer();
                listOrgLine_.Add(tTarget.GetLine());
            }
        }

        public ref_count_ptr<StgIntersectionTarget>.unsync GetIntersectionRelativeTarget(int index)
        {
            return new ref_count_ptr<StgIntersectionTarget>.unsync(listRelativeTarget_[index]);
        }

        public void UpdateIntersectionRelativeTarget(int posX, int posY, double angle)
        {
            int iCircle = 0;
            int iLine = 0;
            for (int iTarget = 0 ; iTarget < listRelativeTarget_.Count ; iTarget++)
            {
                ref_count_ptr<StgIntersectionTarget>.unsync target = listRelativeTarget_[iTarget];
                int shape = target.GetShape();
                if (shape == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_CIRCLE)
                {
                    StgIntersectionTarget_Circle tTarget = (StgIntersectionTarget_Circle)target.GetPointer();
                    DxCircle org = listOrgCircle_[iCircle];
                    int px = org.GetX() + posX;
                    int py = org.GetY() + posY;

                    DxCircle circle = tTarget.GetCircle();
                    circle.SetX(px);
                    circle.SetY(py);
                    tTarget.SetCircle(circle);
                    iCircle++;
                }
                else if (shape == (int)StgIntersectionTarget.AnonymousEnum3.SHAPE_LINE)
                {
                    StgIntersectionTarget_Line tTarget = (StgIntersectionTarget_Line)target.GetPointer();
                    iLine++;
                }
            }
        }

        public void RegistIntersectionRelativeTarget(StgIntersectionManager manager)
        {
            for (int iTarget = 0 ; iTarget < listRelativeTarget_.Count ; iTarget++)
            {
                ref_count_ptr<StgIntersectionTarget>.unsync target = listRelativeTarget_[iTarget];
                manager.AddTarget(new ref_count_ptr<StgIntersectionTarget>.unsync(target));
            }
        }

        public int GetIntersectionRelativeTargetCount()
        {
            return listRelativeTarget_.Count;
        }
        public int GetDxScriptObjectID()
        {
            int res = DxScript.ID_INVALID;
            StgEnemyObject objEnemy = this as StgEnemyObject;
            if (objEnemy != null)
            {
                res = objEnemy.GetObjectID();
            }

            return res;
        }

        public virtual List<ref_count_ptr<StgIntersectionTarget>.unsync > GetIntersectionTargetList()
        {
            return new List<ref_count_ptr<StgIntersectionTarget>.unsync >();
        }
}

/**********************************************************
//StgIntersectionTarget
**********************************************************/
public abstract class StgIntersectionTarget : IStringInfo
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//    friend StgIntersectionManager;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum3
        {
            SHAPE_CIRCLE = 0,
            SHAPE_LINE = 1,

            TYPE_PLAYER,
            TYPE_PLAYER_SHOT,
            TYPE_PLAYER_SPELL,
            TYPE_ENEMY,
            TYPE_ENEMY_SHOT
        }

        protected int mortonNo_;
        protected int typeTarget_;
        protected int shape_;
        protected ref_count_weak_ptr<StgIntersectionObject>.unsync obj_ = new ref_count_weak_ptr<StgIntersectionObject>.unsync();

        public StgIntersectionTarget()
        {
            mortonNo_ = -1;
        }
        public override void Dispose()
        {
            base.Dispose();
        }
        public abstract RECT GetIntersectionSapceRect();

        public int GetTargetType()
        {
            return typeTarget_;
        }
        public void SetTargetType(int type)
        {
            typeTarget_ = type;
        }
        public int GetShape()
        {
            return shape_;
        }
        public ref_count_weak_ptr<StgIntersectionObject>.unsync GetObject()
        {
            return new ref_count_weak_ptr<StgIntersectionObject>.unsync(obj_);
        }
        public void SetObject(ref_count_weak_ptr<StgIntersectionObject>.unsync obj)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: obj_ = obj;
            obj_.CopyFrom(obj);
        }

        public int GetMortonNumber()
        {
            return mortonNo_;
        }
        public void SetMortonNumber(int no)
        {
            mortonNo_ = no;
        }

        /**********************************************************
        //StgIntersectionTarget
        **********************************************************/
        public void ClearObjectIntersectedIdList()
        {
            if (obj_ != null)
            {
                obj_.ClearIntersectedIdList();
            }
        }

        public override string GetInfoAsString()
        {
            string res;
            res += "type[";
            switch (typeTarget_)
            {
            case AnonymousEnum3.TYPE_PLAYER:
                res += "PLAYER";
                break;
            case AnonymousEnum3.TYPE_PLAYER_SHOT:
                res += "PLAYER_SHOT";
                break;
            case AnonymousEnum3.TYPE_PLAYER_SPELL:
                res += "PLAYER_SPELL";
                break;
            case AnonymousEnum3.TYPE_ENEMY:
                res += "ENEMY";
                break;
            case AnonymousEnum3.TYPE_ENEMY_SHOT:
                res += "ENEMY_SHOT";
                break;
            }
            res += "] ";

            res += "shape[";
            switch (shape_)
            {
            case AnonymousEnum3.SHAPE_CIRCLE:
                res += "CIRCLE";
                break;
            case AnonymousEnum3.SHAPE_LINE:
                res += "LINE";
                break;
            }
            res += "] ";

            res += StringUtility.Format("address[%08x] ", (int)this);

            res += "obj[";
            if (obj_ == null)
            {
                res += "NULL";
            }
            else
            {
                ref_count_weak_ptr<DxScriptObjectBase>.unsync dxObj = new ref_count_weak_ptr<DxScriptObjectBase>.unsync(obj_);
                if (dxObj == null)
                {
                    res += "UNKNOWN";
                }
                else
                {
                    int address = (int)dxObj.GetPointer();
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: char* className = (char*)typeid(*this).name();
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                    char className = (string)typeid(this).name();
                    res += StringUtility.Format("ref=%d, delete=%s, active=%s, class=%s[%08x]", dxObj.GetReferenceCount(), dxObj.IsDeleted() ? "true" : "false", dxObj.IsActive() ? "true" : "false", className, address);
                }
            }
            res += "] ";

            return res;
        }
}

public class StgIntersectionTarget_Circle : StgIntersectionTarget
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//    friend StgIntersectionManager;
        private DxCircle circle_ = new DxCircle();



        public StgIntersectionTarget_Circle()
        {
            shape_ = SHAPE_CIRCLE;
        }
        public override void Dispose()
        {
            base.Dispose();
        }
        public override RECT GetIntersectionSapceRect()
        {
            DirectGraphics graphics = DirectGraphics.GetBase();
            int screenWidth = graphics.GetScreenWidth();
            int screenHeight = graphics.GetScreenWidth();

            double x = circle_.GetX();
            double y = circle_.GetY();
            double r = circle_.GetR();
            RECT rect = new RECT((int)(x - r), (int)(y - r), (int)(x + r), (int)(y + r));
            rect.left = System.Math.Max(rect.left, 0);
            rect.left = System.Math.Min(rect.left, screenWidth);
            rect.top = System.Math.Max(rect.top, 0);
            rect.top = System.Math.Min(rect.top, screenHeight);

            rect.right = System.Math.Max(rect.right, 0);
            rect.right = System.Math.Min(rect.right, screenWidth);
            rect.bottom = System.Math.Max(rect.bottom, 0);
            rect.bottom = System.Math.Min(rect.bottom, screenHeight);
            return new RECT(rect);
        }

        public DxCircle GetCircle()
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return circle_;
            return new directx.DxCircle(circle_);
        }
        public void SetCircle(DxCircle circle)
        {
            circle_ = circle;
        }

}

public class StgIntersectionTarget_Line : StgIntersectionTarget
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//    friend StgIntersectionManager;
        private DxWidthLine line_ = new DxWidthLine();

        protected StgIntersectionTarget_Line()
        {
            shape_ = SHAPE_LINE;
        }

        public override void Dispose()
        {
            base.Dispose();
        }
        public override RECT GetIntersectionSapceRect()
        {
            double x1 = line_.GetX1();
            double y1 = line_.GetY1();
            double x2 = line_.GetX2();
            double y2 = line_.GetY2();
            double width = line_.GetWidth();
            if (x1 > x2)
            {
                double tx = x1;
                x1 = x2;
                x2 = tx;
            }
            if (y1 > y2)
            {
                double ty = y1;
                y1 = y2;
                y2 = ty;
            }

            x1 -= width;
            x2 += width;
            y1 -= width;
            y2 += width;

            DirectGraphics graphics = DirectGraphics.GetBase();
            int screenWidth = graphics.GetScreenWidth();
            int screenHeight = graphics.GetScreenWidth();
            x1 = System.Math.Min(x1, screenWidth);
            x1 = System.Math.Max(x1, 0);
            x2 = System.Math.Min(x2, screenWidth);
            x2 = System.Math.Max(x2, 0);

            y1 = System.Math.Min(y1, screenHeight);
            y1 = System.Math.Max(y1, 0);
            y2 = System.Math.Min(y2, screenHeight);
            y2 = System.Math.Max(y2, 0);

            // RECT rect = {x1 - width, y1 - width, x2 + width, y2 + width};
            RECT rect = new RECT((int)x1, (int)y1, (int)x2, (int)y2);
            return new RECT(rect);
        }

        public DxWidthLine GetLine()
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return line_;
            return new directx.DxWidthLine(line_);
        }
        public void SetLine(DxWidthLine line)
        {
            line_ = line;
        }

}

/**********************************************************
//StgIntersectionTargetPoint
**********************************************************/
public class StgIntersectionTargetPoint
{
        private POINT pos_ = new POINT();
        private int idObject_;

        public POINT GetPoint()
        {
            return new POINT(pos_);
        }
        public void SetPoint(POINT pos)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: pos_ = pos;
            pos_.CopyFrom(pos);
        }
        public int GetObjectID()
        {
            return idObject_;
        }
        public void SetObjectID(int id)
        {
            idObject_ = id;
        }
}

