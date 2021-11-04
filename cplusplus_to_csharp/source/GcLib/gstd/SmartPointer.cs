// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)

// ���L��Q�l
// http://marupeke296.com/CPP_SmartPointer.html

namespace gstd
{
    // ================================================================
    // �X�}�[�g�|�C���^�r��
    /*
    class ref_count_ptr_lock
    {
    		CRITICAL_SECTION cs_;
    	public:
    		ref_count_ptr_lock()
    		{
    			::InitializeCriticalSection(&cs_);
    		}
    		~ref_count_ptr_lock()
    		{
    			::DeleteCriticalSection(&cs_);
    		}
    		inline void Enter()
    		{
    			::EnterCriticalSection(&cs_);
    		}
    		inline void Leave()
    		{
    			::LeaveCriticalSection(&cs_);
    		}
    };
    static ref_count_ptr_lock REF_COUNT_PTR_LOCK;//�r���I�u�W�F�N�g
    */


    // ================================================================
    // �X�}�[�g�|�C���^���
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <class T>
    public class ref_count_ptr_info <T>
    {
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: int *countRef_;
        public int countRef_; // �Q�ƃJ�E���^�ւ̃|�C���^
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: int *countWeak_;
        public int countWeak_; // �Q�ƃJ�E���^�ւ̃|�C���^
        public T[] pPtr_; // T�^�̃I�u�W�F�N�g�̃|�C���^

        public ref_count_ptr_info()
        {
            countRef_ = null;
            countWeak_ = null;
            pPtr_ = null;
        }
    }


    // ================================================================
    // ref_count_ptr
    // inline void operator delete(volatile void *p)
    // { 
    // 	operator delete((volatile void*)(p)); 
    // }
// C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
// ORIGINAL LINE: template <class T, bool SYNC>
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class ref_count_weak_ptr;

// C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
// ORIGINAL LINE: template <class T, bool SYNC = true>
// C++ TO C# CONVERTER TODO TASK: C++ template specifiers containing defaults cannot be converted to C#:
    public class ref_count_ptr <T, bool SYNC = true> : System.IDisposable
    {
        private friend ref_count_weak_ptr<T, SYNC> = new friend();

            private ref_count_ptr_info<T> info_ = new ref_count_ptr_info<T>();

            // �Q�ƃJ�E���^����
            private void _AddRef()
            {
                if (info_.countRef_ == null)
                {
                    return;
                }

                if (SYNC)
                {
                    InterlockedIncrement(info_.countRef_);
                    InterlockedIncrement(info_.countWeak_);
                }
                else
                {
                    ++info_.countRef_;
                    ++info_.countWeak_;
                }
            }

            // �Q�ƃJ�E���^����
            private void _Release()
            {
                if (info_.countRef_ == null)
                {
                    return;
                }

                if (SYNC)
                {
                    if (InterlockedDecrement(info_.countRef_) == 0)
                    {
                        info_.pPtr_ = null;
                        info_.pPtr_ = null;
                    }
                    if (InterlockedDecrement(info_.countWeak_) == 0)
                    {
                        info_.countRef_ = null;
                        info_.countRef_ = null;
                        info_.countWeak_ = null;
                        info_.countWeak_ = null;
                    }
                }
                else
                {
                    if (--info_.countRef_ == null)
                    {
                        info_.pPtr_ = null;
                        info_.pPtr_ = null;
                    }
                    if (--info_.countWeak_ == null)
                    {
                        info_.countRef_ = null;
                        info_.countRef_ = null;
                        info_.countWeak_ = null;
                        info_.countWeak_ = null;
                    }
                }
            }

            public ref_count_ptr()
            {
                SetPointer(null);
            }
            // �f�t�H���g�R���X�g���N�^
            // explicit �K�v?
            public ref_count_ptr(T src, int add = 0)
            {
                SetPointer(src, add);
            }

            // �R�s�[�R���X�g���N�^
            public ref_count_ptr(ref_count_ptr<T, SYNC> src)
            {
                // ����̃|�C���^��R�s�[
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: info_ = src.info_;
                info_.CopyFrom(src.info_);

                // �������g�̎Q�ƃJ�E���^�𑝉�
                _AddRef();
            }

            // �R�s�[�R���X�g���N�^�i�ÖٓI�A�b�v�L���X�g�t���j
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class T2>
            public ref_count_ptr<T2>(ref_count_ptr<T2, SYNC> src)
            {
                // ����̃|�C���^��R�s�[
                info_.countRef_ = src._GetReferenceCountPointer();
                info_.countWeak_ = src._GetWeakCountPointer();
                info_.pPtr_ = src.GetPointer();

                // �������g�̎Q�ƃJ�E���^�𑝉�
                _AddRef();
            }

            // �f�X�g���N�^
            public void Dispose()
            {
                _Release();
            }

            // =������Z�q
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: ref_count_ptr<T, SYNC>& operator =(T *src)
            public ref_count_ptr<T, SYNC> CopyFrom(T src)
            {
                if (src == info_.pPtr_)
                {
                    return (this);
                }
                SetPointer(src);
                return (this);
            }

            // =������Z�q
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: ref_count_ptr<T, SYNC>& operator =(const ref_count_ptr<T, SYNC> &src)
            public ref_count_ptr<T, SYNC> CopyFrom(ref_count_ptr<T, SYNC> src)
            {
                // �������g�ւ̑���͕s���ňӖ��������̂�
                // �s��Ȃ��B
                if (src.info_.pPtr_ == info_.pPtr_)
                {
                    return (this);
                }

                // �����͑��l�ɂȂ��Ă��܂��̂�
                // �Q�ƃJ�E���^��1����
                _Release();

                // ����̃|�C���^��R�s�[
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: info_ = src.info_;
                info_.CopyFrom(src.info_);

                // �V�����������g�̎Q�ƃJ�E���^�𑝉�
                _AddRef();

                return (this);
            }

            // =������Z�q�i�����I�A�b�v�L���X�g�t���j
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class T2>
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: ref_count_ptr& operator =(ref_count_ptr<T2, SYNC> &src)
            public ref_count_ptr CopyFrom<T2>(ref_count_ptr<T2, SYNC> src)
            {
                // �������g�ւ̑���͕s���ňӖ��������̂�
                // �s��Ȃ��B
                if (src.GetPointer() == info_.pPtr_)
                {
                    return (this);
                }

                // �����͑��l�ɂȂ��Ă��܂��̂�
                // �Q�ƃJ�E���^��1����
                _Release();

                // ����̃|�C���^��R�s�[
                info_.countRef_ = src._GetReferenceCountPointer();
                info_.countWeak_ = src._GetWeakCountPointer();
                info_.pPtr_ = src.GetPointer();

                // �V�����������g�̎Q�ƃJ�E���^�𑝉�
                _AddRef();

                return (this);
            }

            // *�Ԑډ��Z�q
            public T Indirection()
            {
                return info_.pPtr_;
            }

            // ->�����o�I����Z�q
            public T Dereference()
            {
                return info_.pPtr_;
            }

            // []�z��Q�Ɖ��Z�q
            public T this[int n]
            {
                get
                {
                    return new T(info_.pPtr_[n]);
                }
                set
                {
                    info_.pPtr_[n] = value;
                }
            }

            // ==��r���Z�q
            public static bool operator == (ref_count_ptr ImpliedObject, T p)
            {
                return ImpliedObject.info_.pPtr_ == p;
            }
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator ==(const ref_count_ptr<T, SYNC>& p)const
            public static bool operator == (ref_count_ptr ImpliedObject, ref_count_ptr<T, SYNC> p)
            {
                return ImpliedObject.info_.pPtr_ == p.info_.pPtr_;
            }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template< class D >
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator ==(ref_count_ptr<D, SYNC>& p)const
            public static bool operator == < D >(ref_count_ptr ImpliedObject, ref_count_ptr<D, SYNC> p)
            {
                return ImpliedObject.info_.pPtr_ == p.GetPointer();
            }

            // !=��r���Z�q
            public static bool operator != (ref_count_ptr ImpliedObject, T p)
            {
                return ImpliedObject.info_.pPtr_ != p;
            }
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator !=(const ref_count_ptr<T, SYNC>& p)const
            public static bool operator != (ref_count_ptr ImpliedObject, ref_count_ptr<T, SYNC> p)
            {
                return ImpliedObject.info_.pPtr_ != p.info_.pPtr_;
            }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template< class D >
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator !=(ref_count_ptr<D, SYNC>& p)const
            public static bool operator != < D >(ref_count_ptr ImpliedObject, ref_count_ptr<D, SYNC> p)
            {
                return ImpliedObject.info_.pPtr_ != p.info_.pPtr_;
            }

            // �|�C���^�̖����I�ȓo�^
            public void SetPointer(T src = null, int add = 0)
            {
                // �Q�ƃJ�E���^����炵����ɍď�����
                _Release();
                if (src == null)
                {
                    info_.countRef_ = null;
                    info_.countWeak_ = null;
                }
                else
                {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                    info_.countRef_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) int;
                    info_.countRef_ = add;
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                    info_.countWeak_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) int;
                    info_.countWeak_ = add;
                }
                info_.pPtr_ = src;
                _AddRef();
            }

            // �|�C���^�݂̑��o��
            public T GetPointer()
            {
                return info_.pPtr_;
            }

            // �Q�ƃJ�E���^�ւ̃|�C���^��擾
// C++ TO C# CONVERTER WARNING: C# has no equivalent to methods returning pointers to value types:
// ORIGINAL LINE: inline int* _GetReferenceCountPointer()
            public int _GetReferenceCountPointer()
            {
                return info_.countRef_;
            } // ���̊֐��͊O�����炵�悤���Ȃ�����
// C++ TO C# CONVERTER WARNING: C# has no equivalent to methods returning pointers to value types:
// ORIGINAL LINE: inline int* _GetWeakCountPointer()
            public int _GetWeakCountPointer()
            {
                return info_.countWeak_;
            } // ���̊֐��͊O�����炵�悤���Ȃ�����
            public int GetReferenceCount()
            {
                int res = info_.countRef_ != null ? (int) info_.countRef_ : 0;
                return res;
            }

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <class T2>
            public static ref_count_ptr<T, SYNC> DownCast<T2>(ref_count_ptr<T2, SYNC> src)
            {
                // �����̃X�}�[�g�|�C���^�����|�C���^���A
                // �����̓o�^���Ă���|�C���^��
                // �_�E���L���X�g�\�ȏꍇ�̓I�u�W�F�N�g��Ԃ�
                ref_count_ptr<T, SYNC> res = new ref_count_ptr<T, SYNC>();
                T castPtr = src.GetPointer() as T;
                if (castPtr != null)
                {
                    // �_�E���L���X�g�
// 					res._Release();//���݂̎Q�Ƃ�j������K�v������
                    res.info_.countRef_ = src._GetReferenceCountPointer();
                    res.info_.countWeak_ = src._GetWeakCountPointer();
                    res.info_.pPtr_ = castPtr;
                    res._AddRef();
                }
                return new ref_count_ptr<T, SYNC>(res);
            }
    }

    // ================================================================
    // ref_count_weak_ptr
// C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
// ORIGINAL LINE: template <class T, bool SYNC = true>
// C++ TO C# CONVERTER TODO TASK: C++ template specifiers containing defaults cannot be converted to C#:
    public class ref_count_weak_ptr <T, bool SYNC = true> : System.IDisposable
    {

            private ref_count_ptr_info<T> info_ = new ref_count_ptr_info<T>();

            // �Q�ƃJ�E���^����
            private void _AddRef()
            {
                if (info_.countRef_ == null)
                {
                    return;
                }

                if (SYNC)
                {
                    InterlockedIncrement(info_.countWeak_);
                }
                else
                {
                    ++info_.countWeak_;
                }
            }

            // �Q�ƃJ�E���^����
            private void _Release()
            {
                if (info_.countRef_ == null)
                {
                    return;
                }

                if (SYNC)
                {
                    if (InterlockedDecrement(info_.countWeak_) == 0)
                    {
                        info_.countRef_ = null;
                        info_.countRef_ = null;
                        info_.countWeak_ = null;
                        info_.countWeak_ = null;
                    }
                }
                else
                {
                    if (--info_.countWeak_ == null)
                    {
                        info_.countRef_ = null;
                        info_.countRef_ = null;
                        info_.countWeak_ = null;
                        info_.countWeak_ = null;
                    }
                }
            }

            public ref_count_weak_ptr()
            {
            }
            public ref_count_weak_ptr(T src)
            {
                if (src != null)
                {
                    throw new System.Exception("ref_count_weak_ptr�R���X�g���N�^�ɔ�NULL�������悤�Ƃ��܂���");
                }
            }
            // �R�s�[�R���X�g���N�^
            public ref_count_weak_ptr(ref_count_weak_ptr<T, SYNC> src)
            {
                // ����̃|�C���^��R�s�[
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: info_ = src.info_;
                info_.CopyFrom(src.info_);

                // �������g�̎Q�ƃJ�E���^�𑝉�
                _AddRef();
            }

            // �R�s�[�R���X�g���N�^�i�ÖٓI�A�b�v�L���X�g�t���j
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class T2>
            public ref_count_weak_ptr<T2>(ref_count_weak_ptr<T2, SYNC> src)
            {
                // ����̃|�C���^��R�s�[
                info_.countRef_ = src._GetReferenceCountPointer();
                info_.countWeak_ = src._GetWeakCountPointer();
                info_.pPtr_ = src.GetPointer();

                // �������g�̎Q�ƃJ�E���^�𑝉�
                _AddRef();
            }

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class T2>
            public ref_count_weak_ptr<T2>(ref_count_ptr<T2, SYNC> src)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: info_ = src.info_;
                info_.CopyFrom(src.info_);
                _AddRef();
            }

            // �f�X�g���N�^
            public void Dispose()
            {
                _Release();
            }

            // =������Z�q
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: ref_count_weak_ptr<T, SYNC>& operator =(T *src)
            public ref_count_weak_ptr<T, SYNC> CopyFrom(T src)
            {
                if (src != null)
                {
                    throw new System.Exception("ref_count_weak_ptr =�ɔ�NULL�������悤�Ƃ��܂���");
                }
                _Release();
                info_.pPtr_ = src;
                info_.countRef_ = null;
                info_.countWeak_ = null;
                return (this);
            }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: ref_count_weak_ptr<T, SYNC>& operator =(const ref_count_weak_ptr<T, SYNC> &src)
            public ref_count_weak_ptr<T, SYNC> CopyFrom(ref_count_weak_ptr<T, SYNC> src)
            {
                // �������g�ւ̑���͕s���ňӖ��������̂�
                // �s��Ȃ��B
                if (src.info_.pPtr_ == info_.pPtr_)
                {
                    return (this);
                }

                // �����͑��l�ɂȂ��Ă��܂��̂�
                // �Q�ƃJ�E���^��1����
                _Release();

                // ����̃|�C���^��R�s�[
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: info_ = src.info_;
                info_.CopyFrom(src.info_);

                // �V�����������g�̎Q�ƃJ�E���^�𑝉�
                _AddRef();

                return (this);
            }

            // =������Z�q
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: ref_count_weak_ptr<T, SYNC>& operator =(const ref_count_ptr<T, SYNC> &src)
            public ref_count_weak_ptr<T, SYNC> CopyFrom(ref_count_ptr<T, SYNC> src)
            {
                // �������g�ւ̑���͕s���ňӖ��������̂�
                // �s��Ȃ��B
                if (src.info_.pPtr_ == info_.pPtr_)
                {
                    return (this);
                }

                // �����͑��l�ɂȂ��Ă��܂��̂�
                // �Q�ƃJ�E���^��1����
                _Release();

                // ����̃|�C���^��R�s�[
                info_.countRef_ = src.info_.countRef_;
                info_.countWeak_ = src.info_.countWeak_;
                info_.pPtr_ = src.info_.pPtr_;

                // �V�����������g�̎Q�ƃJ�E���^�𑝉�
                _AddRef();

                return (this);
            }

            // =������Z�q�i�����I�A�b�v�L���X�g�t���j
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class T2>
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: ref_count_weak_ptr& operator =(ref_count_weak_ptr<T2, SYNC> &src)
            public ref_count_weak_ptr CopyFrom<T2>(ref_count_weak_ptr<T2, SYNC> src)
            {
                // �������g�ւ̑���͕s���ňӖ��������̂�
                // �s��Ȃ��B
                if (src.GetPointer() == info_.pPtr_)
                {
                    return (this);
                }

                // �����͑��l�ɂȂ��Ă��܂��̂�
                // �Q�ƃJ�E���^��1����
                _Release();

                // ����̃|�C���^��R�s�[
                info_.countRef_ = src._GetReferenceCountPointer();
                info_.countWeak_ = src._GetWeakCountPointer();
                info_.pPtr_ = src.GetPointer();

                // �V�����������g�̎Q�ƃJ�E���^�𑝉�
                _AddRef();

                return (this);
            }

            // *�Ԑډ��Z�q
            public T Indirection()
            {
                return info_.pPtr_;
            }

            // ->�����o�I����Z�q
            public T Dereference()
            {
                return info_.pPtr_;
            }

            // []�z��Q�Ɖ��Z�q
            public T this[int n]
            {
                get
                {
                    return new T(info_.pPtr_[n]);
                }
                set
                {
                    info_.pPtr_[n] = value;
                }
            }

            // ==��r���Z�q
            public static bool operator == (ref_count_weak_ptr ImpliedObject, T p)
            {
                return ImpliedObject.IsExists() ? (ImpliedObject.info_.pPtr_ == p) : (null == p);
            }
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator ==(const ref_count_weak_ptr<T, SYNC>& p)const
            public static bool operator == (ref_count_weak_ptr ImpliedObject, ref_count_weak_ptr<T, SYNC> p)
            {
                return ImpliedObject.IsExists() ? (ImpliedObject.info_.pPtr_ == p.info_.pPtr_) : (null == p.info_.pPtr_);
            }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template< class D >
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator ==(ref_count_weak_ptr<D, SYNC>& p)const
            public static bool operator == < D >(ref_count_weak_ptr ImpliedObject, ref_count_weak_ptr<D, SYNC> p)
            {
                return ImpliedObject.IsExists() ? (ImpliedObject.info_.pPtr_ == p.GetPointer()) : (null == p.GetPointer());
            }

            // !=��r���Z�q
            public static bool operator != (ref_count_weak_ptr ImpliedObject, T p)
            {
                return ImpliedObject.IsExists() ? (ImpliedObject.info_.pPtr_ != p) : (null != p);
            }
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator !=(const ref_count_weak_ptr<T, SYNC>& p)const
            public static bool operator != (ref_count_weak_ptr ImpliedObject, ref_count_weak_ptr<T, SYNC> p)
            {
                return ImpliedObject.IsExists() ? (ImpliedObject.info_.pPtr_ != p.info_.pPtr_) : (null != p.info_.pPtr_);
            }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template< class D >
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator !=(ref_count_weak_ptr<D, SYNC>& p)const
            public static bool operator != < D >(ref_count_weak_ptr ImpliedObject, ref_count_weak_ptr<D, SYNC> p)
            {
                return ImpliedObject.IsExists() ? (ImpliedObject.info_.pPtr_ != p.GetPointer()) : (null != p.GetPointer());
            }

            // �|�C���^�݂̑��o��
            public T GetPointer()
            {
                return IsExists() ? info_.pPtr_ : null;
            }

            // �Q�ƃJ�E���^�ւ̃|�C���^��擾
// C++ TO C# CONVERTER WARNING: C# has no equivalent to methods returning pointers to value types:
// ORIGINAL LINE: inline int* _GetReferenceCountPointer()
            public int _GetReferenceCountPointer()
            {
                return info_.countRef_;
            } // ���̊֐��͊O�����炵�悤���Ȃ�����
// C++ TO C# CONVERTER WARNING: C# has no equivalent to methods returning pointers to value types:
// ORIGINAL LINE: inline int* _GetWeakCountPointer()
            public int _GetWeakCountPointer()
            {
                return info_.countWeak_;
            } // ���̊֐��͊O�����炵�悤���Ȃ�����
            public int GetReferenceCount()
            {
                int res = info_.countRef_ != null ? (int) info_.countRef_ : 0;
                return res;
            }
            public bool IsExists()
            {
                return info_.countRef_ != null ? (info_.countRef_ > null) : false;
            }

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <class T2>
            public static ref_count_weak_ptr<T, SYNC> DownCast<T2>(ref_count_weak_ptr<T2, SYNC> src)
            {
                // �����̃X�}�[�g�|�C���^�����|�C���^���A
                // �����̓o�^���Ă���|�C���^��
                // �_�E���L���X�g�\�ȏꍇ�̓I�u�W�F�N�g��Ԃ�
                ref_count_weak_ptr<T, SYNC> res = new ref_count_weak_ptr<T, SYNC>();
                T castPtr = src.GetPointer() as T;
                if (castPtr != null)
                {
                    // �_�E���L���X�g�
// 					res._Release();//���݂̎Q�Ƃ�j������K�v������
                    res.info_.countRef_ = src._GetReferenceCountPointer();
                    res.info_.countWeak_ = src._GetWeakCountPointer();
                    res.info_.pPtr_ = castPtr;
                    res._AddRef();
                }
                return new ref_count_weak_ptr<T, SYNC>(res);
            }
    }
}

