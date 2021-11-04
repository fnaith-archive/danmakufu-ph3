using gstd;

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)

namespace gstd
{
    /**********************************************************
    //MersenneTwister
    //Mersenne Twister�́A���{�� �E������m�i�A���t�@�x�b�g���j
    //�ɂ��1996�N����1997�N�ɓn���ĊJ�����ꂽ
    //�^�����������A���S���Y���ł��B
    // http://www.math.sci.hiroshima-u.ac.jp/~m-mat/MT/what-is-mt.html
    **********************************************************/
    public class MersenneTwister : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: The implementation of the following type could not be found:
//            struct mt_struct;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend struct mt_struct;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            private enum AnonymousEnum
            {
                MT_N = 624,
                MT_M = 397
            }

            private class mt_struct : System.IDisposable
            {
                public uint[] mt = new uint[MT_N];
                public int mti;
                public virtual void Dispose()
                {
                }
            }
            private mt_struct mts = new mt_struct();
            private int seed_;
            private uint _GenrandInt32()
            {
                uint result;

                if (mts.mti >= (int)AnonymousEnum.MT_N)
                {
                    int kk;
                    uint y;

#if false
            // 		if (mts.mti == MT_N+1)
            // 			init_genrand(mt, 5489UL);
#endif

                    for (kk = 0; kk < (int)AnonymousEnum.MT_N - (int)AnonymousEnum.MT_M; ++kk)
                    {
                        y = (mts.mt[kk] & GlobalMembers.UPPER_MASK) | (mts.mt[kk + 1] & GlobalMembers.LOWER_MASK);
                        mts.mt[kk] = mts.mt[kk + (int)AnonymousEnum.MT_M] ^ (y >> 1) ^ GlobalMembers.mag01[y & 0x1U];
                    }
                    for (; kk < (int)AnonymousEnum.MT_N - 1; ++kk)
                    {
                        y = (mts.mt[kk] & GlobalMembers.UPPER_MASK) | (mts.mt[kk + 1] & GlobalMembers.LOWER_MASK);
                        mts.mt[kk] = mts.mt[kk + (AnonymousEnum.MT_M - AnonymousEnum.MT_N)] ^ (y >> 1) ^ GlobalMembers.mag01[y & 0x1U];
                    }

                    y = (mts.mt[(int)AnonymousEnum.MT_N - 1] & GlobalMembers.UPPER_MASK) | (mts.mt[0] & GlobalMembers.LOWER_MASK);
                    mts.mt[(int)AnonymousEnum.MT_N - 1] = mts.mt[(int)AnonymousEnum.MT_M - 1] ^ (y >> 1) ^ GlobalMembers.mag01[y & 0x1U];

                    mts.mti = 0;
                }

                result = mts.mt[mts.mti];
                ++(mts.mti);

                result ^= (result >> 11);
                result ^= (result << 7) & 0x9d2c5680U;
                result ^= (result << 15) & 0xefc60000U;
                result ^= (result >> 18);

                return result;
            }

            public MersenneTwister()
            {
                this.Initialize(0);
            }

            public MersenneTwister(uint s)
            {
                this.Initialize(s);
            }

            public virtual void Dispose()
            {
            }
            public void Initialize(uint s)
            {
                int i;
                mts.mt[0] = s;
                for (i = 1; i < (int)AnonymousEnum.MT_N; ++i)
                {
                    mts.mt[i] = 1812433253U * (mts.mt[i - 1] ^ (mts.mt[i - 1] >> 30)) + i;
                }
                mts.mti = i;
                seed_ = (int)s;
            }

            public void Initialize(uint[] init_key, int key_length)
            {
                int i;
                int j;
                int k;
                Initialize(19650218U);
                i = 1;
                j = 0;
                for (k = ((int)AnonymousEnum.MT_N > key_length) ? (int)AnonymousEnum.MT_N : key_length; k; --k)
                {
                    mts.mt[i] = (mts.mt[i] ^ ((mts.mt[i - 1] ^ (mts.mt[i - 1] >> 30)) * 1664525U)) + init_key[j] + j;
                    ++i;
                    if (i >= (int)AnonymousEnum.MT_N)
                    {
                        mts.mt[0] = mts.mt[(int)AnonymousEnum.MT_N - 1];
                        i = 1;
                    }
                    ++j;
                    if (j >= key_length)
                    {
                        j = 0;
                    }
                }
                for (k = (int)AnonymousEnum.MT_N - 1; k; --k)
                {
                    mts.mt[i] = (mts.mt[i] ^ ((mts.mt[i - 1] ^ (mts.mt[i - 1] >> 30)) * 1566083941U)) - i;
                    ++i;
                    if (i >= (int)AnonymousEnum.MT_N)
                    {
                        mts.mt[0] = mts.mt[(int)AnonymousEnum.MT_N - 1];
                        i = 1;
                    }
                }
                mts.mt[0] = 0x80000000U;
            }

            public int GetSeed()
            {
                return seed_;
            }
            public int GetInt()
            {
                return (int)(_GenrandInt32() >> 1);
            }

            public int GetInt(int min, int max)
            {
                return (int)this.GetReal(min, max);
            }

            public _int64 GetInt64()
            {
                return (_int64)this.GetReal();
            }

            public _int64 GetInt64(_int64 min, _int64 max)
            {
                return (_int64)this.GetReal(new _int64(min), new _int64(max));
            }

            public double GetReal()
            {
                return _GenrandInt32() * (1.0 / 4294967295.0);
            }

            public double GetReal(double min, double max)
            {
                if (min == max)
                {
                    return min;
                }
                if (min > max)
                {
                    double t = min;
                    min = max;
                    max = t;
                }
                double r = GetReal();
                r = r * (max - min) + min;
                return r;
            }
    }
}