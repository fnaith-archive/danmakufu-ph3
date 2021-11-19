using System;
using System.Collections.Generic;

namespace Gstd
{
    namespace MersenneTwister
    {
        public class MersenneTwister : System.IDisposable // TODO test
        {
            private static readonly int MT_N = 624;
            private static readonly int MT_M = 397;
            private static readonly uint MATRIX_A = 0x9908b0dfU;
            private static readonly uint UPPER_MASK = 0x80000000U;
            private static readonly uint LOWER_MASK = 0x7fffffffU;
            private static readonly uint[] mag01 = { 0x0U, MATRIX_A };

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

                if (mts.mti >= MT_N)
                {
                    int kk;
                    uint y;

                    for (kk = 0; kk < MT_N - MT_M; ++kk)
                    {
                        y = (mts.mt[kk] & UPPER_MASK) | (mts.mt[kk + 1] & LOWER_MASK);
                        mts.mt[kk] = mts.mt[kk + MT_M] ^ (y >> 1) ^ mag01[y & 0x1U];
                    }
                    for (; kk < MT_N - 1; ++kk)
                    {
                        y = (mts.mt[kk] & UPPER_MASK) | (mts.mt[kk + 1] & LOWER_MASK);
                        mts.mt[kk] = mts.mt[kk + (MT_M - MT_N)] ^ (y >> 1) ^ mag01[y & 0x1U];
                    }

                    y = (mts.mt[MT_N - 1] & UPPER_MASK) | (mts.mt[0] & LOWER_MASK);
                    mts.mt[MT_N - 1] = mts.mt[MT_M - 1] ^ (y >> 1) ^ mag01[y & 0x1U];

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
                for (i = 1; i < MT_N; ++i)
                {
                    mts.mt[i] = (uint)(1812433253U * (mts.mt[i - 1] ^ (mts.mt[i - 1] >> 30)) + i);
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
                for (k = (MT_N > key_length) ? MT_N : key_length; k != 0; --k)
                {
                    mts.mt[i] = (uint)((mts.mt[i] ^ ((mts.mt[i - 1] ^ (mts.mt[i - 1] >> 30)) * 1664525U)) + init_key[j] + j);
                    ++i;
                    if (i >= MT_N)
                    {
                        mts.mt[0] = mts.mt[MT_N - 1];
                        i = 1;
                    }
                    ++j;
                    if (j >= key_length)
                    {
                        j = 0;
                    }
                }
                for (k = MT_N - 1; k != 0; --k)
                {
                    mts.mt[i] = (uint)((mts.mt[i] ^ ((mts.mt[i - 1] ^ (mts.mt[i - 1] >> 30)) * 1566083941U)) - i);
                    ++i;
                    if (i >= MT_N)
                    {
                        mts.mt[0] = mts.mt[MT_N - 1];
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

            public long GetInt64()
            {
                return (long)this.GetReal();
            }

            public long GetInt64(long min, long max)
            {
                return (long)this.GetReal((long)(min), (long)(max));
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
}
