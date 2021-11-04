/* DirectInput �L�[���ʃR�[�h�
DIK_ESCAPE 0x01 Esc   
DIK_1 0x02 1   
DIK_2 0x03 2   
DIK_3 0x04 3   
DIK_4 0x05 4   
DIK_5 0x06 5   
DIK_6 0x07 6   
DIK_7 0x08 7   
DIK_8 0x09 8   
DIK_9 0x0A 9   
DIK_0 0x0B 0   
DIK_MINUS 0x0C -   
DIK_EQUALS 0x0D =   
DIK_BACK 0x0E Back Space   
DIK_TAB 0x0F Tab   
DIK_Q 0x10 Q   
DIK_W 0x11 W   
DIK_E 0x12 E   
DIK_R 0x13 R   
DIK_T 0x14 T   
DIK_Y 0x15 Y   
DIK_U 0x16 U   
DIK_I 0x17 I   
DIK_O 0x18 O   
DIK_P 0x19 P   
DIK_LBRACKET 0x1A [   
DIK_RBRACKET 0x1B ]   
DIK_RETURN 0x1C Enter   
DIK_LCONTROL 0x1D Ctrl (Left)   
DIK_A 0x1E A   
DIK_S 0x1F S   
DIK_D 0x20 D   
DIK_F 0x21 F   
DIK_G 0x22 G   
DIK_H 0x23 H   
DIK_J 0x24 J   
DIK_K 0x25 K   
DIK_L 0x26 L   
DIK_SEMICOLON 0x27 ;   
DIK_APOSTROPHE 0x28 '   
DIK_GRAVE 0x29 `   
DIK_LSHIFT 0x2A Shift (Left)   
DIK_BACKSLASH 0x2B
DIK_Z 0x2C Z   
DIK_X 0x2D X   
DIK_C 0x2E C   
DIK_V 0x2F V   
DIK_B 0x30 B   
DIK_N 0x31 N   
DIK_M 0x32 M   
DIK_COMMA 0x33 ,   
DIK_PERIOD 0x34 .   
DIK_SLASH 0x35 /   
DIK_RSHIFT 0x36 Shift (Right)   
DIK_MULTIPLY 0x37 * (Numpad)   
DIK_LMENU 0x38 Alt (Left)   
DIK_SPACE 0x39 Space   
DIK_CAPITAL 0x3A Caps Lock   
DIK_F1 0x3B F1   
DIK_F2 0x3C F2   
DIK_F3 0x3D F3   
DIK_F4 0x3E F4   
DIK_F5 0x3F F5   
DIK_F6 0x40 F6   
DIK_F7 0x41 F7   
DIK_F8 0x42 F8   
DIK_F9 0x43 F9   
DIK_F10 0x44 F10   
DIK_NUMLOCK 0x45 Num Lock   
DIK_SCROLL 0x46 Scroll Lock   
DIK_NUMPAD7 0x47 7 (Numpad)   
DIK_NUMPAD8 0x48 8 (Numpad)   
DIK_NUMPAD9 0x49 9 (Numpad)   
DIK_SUBTRACT 0x4A - (Numpad)   
DIK_NUMPAD4 0x4B 4 (Numpad)   
DIK_NUMPAD5 0x4C 5 (Numpad)   
DIK_NUMPAD6 0x4D 6 (Numpad)   
DIK_ADD 0x4E + (Numpad)   
DIK_NUMPAD1 0x4F 1 (Numpad)   
DIK_NUMPAD2 0x50 2 (Numpad)   
DIK_NUMPAD3 0x51 3 (Numpad)   
DIK_NUMPAD0 0x52 0 (Numpad)   
DIK_DECIMAL 0x53 . (Numpad)   
DIK_F11 0x57 F11   
DIK_F12 0x58 F12   
DIK_F13 0x64 F13 NEC PC-98 
DIK_F14 0x65 F14 NEC PC-98 
DIK_F15 0x66 F15 NEC PC-98 
DIK_KANA 0x70 �J�i ���{��L�[�{�[�h 
DIK_CONVERT 0x79 �ϊ� ���{��L�[�{�[�h 
DIK_NOCONVERT 0x7B ���ϊ� ���{��L�[�{�[�h 
DIK_YEN 0x7D \ ���{��L�[�{�[�h 
DIK_NUMPADEQUALS 0x8D = (Numpad) NEC PC-98 
DIK_CIRCUMFLEX 0x90 �s�� ���{��L�[�{�[�h 
DIK_AT 0x91 @ NEC PC-98 
DIK_COLON 0x92 : NEC PC-98 
DIK_UNDERLINE 0x93 _ NEC PC-98 
DIK_KANJI 0x94 ���� ���{��L�[�{�[�h 
DIK_STOP 0x95 Stop NEC PC-98 
DIK_AX 0x96 (Japan AX)   
DIK_UNLABELED 0x97 (J3100)   
DIK_NUMPADENTER 0x9C Enter (Numpad)   
DIK_RCONTROL 0x9D Ctrl (Right)   
DIK_NUMPADCOMMA 0xB3 , (Numpad) NEC PC-98 
DIK_DIVIDE 0xB5 / (Numpad)   
DIK_SYSRQ 0xB7 Sys Rq   
DIK_RMENU 0xB8 Alt (Right)   
DIK_PAUSE 0xC5 Pause   
DIK_HOME 0xC7 Home   
DIK_UP 0xC8 ��   
DIK_PRIOR 0xC9 Page Up   
DIK_LEFT 0xCB ��   
DIK_RIGHT 0xCD ��   
DIK_END 0xCF End   
DIK_DOWN 0xD0 ��   
DIK_NEXT 0xD1 Page Down   
DIK_INSERT 0xD2 Insert   
DIK_DELETE 0xD3 Delete   
DIK_LWIN 0xDB Windows (Left)   
DIK_RWIN 0xDC Windows (Right)   
DIK_APPS 0xDD Menu   
DIK_POWER 0xDE Power   
DIK_SLEEP 0xDF Sleep   
*/



using gstd;
using directx;
using System;
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

namespace directx
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
    public enum AnonymousEnum
    {
        DI_MOUSE_LEFT = 0,
        DI_MOUSE_RIGHT = 1,
        DI_MOUSE_MIDDLE = 2
    }

// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
    public enum AnonymousEnum2
    {
        KEY_FREE = 0, // �L�[��������Ă��Ȃ����
        KEY_PUSH = 1, // �L�[��������u��
        KEY_PULL = 2, // �L�[�������ꂽ�u��
        KEY_HOLD = 3 // �L�[��������Ă�����
    }

    /**********************************************************
    //DirectInput
    **********************************************************/
    public class DirectInput : System.IDisposable
    {
            private static DirectInput thisBase_ = null;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum3
            {
                MAX_JOYPAD = 4,
                MAX_KEY = 256,
                MAX_MOUSE_BUTTON = 4,
                MAX_PAD_BUTTON = 16
            }

            protected IntPtr hWnd_;
            protected LPDIRECTINPUT8 pInput_ = new LPDIRECTINPUT8();
            protected LPDIRECTINPUTDEVICE8 pKeyboard_ = new LPDIRECTINPUTDEVICE8();
            protected LPDIRECTINPUTDEVICE8 pMouse_ = new LPDIRECTINPUTDEVICE8();
            protected List<LPDIRECTINPUTDEVICE8> pJoypad_ = new List<LPDIRECTINPUTDEVICE8>(); // �p�b�h�f�o�C�X�I�u�W�F�N�g
            protected byte[] stateKey_ = new byte[(int)AnonymousEnum3.MAX_KEY];
            protected DIMOUSESTATE stateMouse_ = new DIMOUSESTATE();
            protected List<DIJOYSTATE> statePad_ = new List<DIJOYSTATE>();
            protected List<int> padRes_ = new List<int>(); // �p�b�h�̗V��

            protected int[] bufKey_ = new int[(int)AnonymousEnum3.MAX_KEY]; // ���t���[���̃L�[�̏��
            protected int[] bufMouse_ = new int[(int)AnonymousEnum3.MAX_MOUSE_BUTTON]; // ���t���[���̃}�E�X�̏��
            protected List<List<int>> bufPad_ = new List<List<int>>(); // ���t���[���̃p�b�h�̏��

            protected bool _InitializeKeyBoard()
            {
                Logger.WriteTop("DirectIuput�F�L�[�{�[�h������");

                int hrDevice = pInput_.CreateDevice(GUID_SysKeyboard, pKeyboard_, null);
                if (FAILED(hrDevice))
                {
                    Logger.WriteTop("DirectInput�F�L�[�{�[�h�̃f�o�C�X�I�u�W�F�N�g�쐬���s");
                    return false;
                }

                int hrFormat = pKeyboard_.SetDataFormat(c_dfDIKeyboard);
                if (FAILED(hrFormat))
                {
                    Logger.WriteTop("DirectInput�F�L�[�{�[�h�̃f�[�^�t�H�[�}�b�g�ݒ莸�s");
                    return false;
                }

                int hrCoop = pKeyboard_.SetCooperativeLevel(hWnd_, DISCL_NONEXCLUSIVE | DISCL_BACKGROUND);
                if (FAILED(hrCoop))
                {
                    Logger.WriteTop("DirectInput�F�L�[�{�[�h�̓���ݒ莸�s");
                    return false;
                }

                // ���͐���J�n
                pKeyboard_.Acquire();

                Logger.WriteTop("DirectIuput�F�L�[�{�[�h����������");

                return true;
            }

            protected bool _InitializeMouse()
            {
                Logger.WriteTop("DirectIuput�F�}�E�X������");

                int hrDevice = pInput_.CreateDevice(GUID_SysMouse, pMouse_, null);
                if (FAILED(hrDevice))
                {
                    Logger.WriteTop("DirectInput�F�}�E�X�̃f�o�C�X�I�u�W�F�N�g�쐬���s");
                    return false;
                }

                int hrFormat = pMouse_.SetDataFormat(c_dfDIMouse);
                if (FAILED(hrFormat))
                {
                    Logger.WriteTop("DirectInput�F�}�E�X�̃f�[�^�t�H�[�}�b�g�ݒ莸�s");
                    return false;
                }

                int hrCoop = pMouse_.SetCooperativeLevel(hWnd_, DISCL_NONEXCLUSIVE | DISCL_BACKGROUND);
                if (FAILED(hrCoop))
                {
                    Logger.WriteTop("DirectInput�F�}�E�X�̓���ݒ莸�s");
                    return false;
                }

                // ���͐���J�n
                pMouse_.Acquire();

                Logger.WriteTop("DirectIuput�F�}�E�X����������");
                return true;
            }

            protected bool _InitializeJoypad()
            {
                Logger.WriteTop("DirectIuput�F�W���C�p�b�h������");
                pInput_.EnumDevices(DI8DEVCLASS_GAMECTRL, (LPDIENUMDEVICESCALLBACK)_GetJoypadStaticCallback, this, DIEDFL_ATTACHEDONLY);
                int count = pJoypad_.Count;
                if (count == 0)
                {
                    Logger.WriteTop("DirectIuput�F�W���C�p�b�h�͌�����܂���ł���");
                    return false; // �W���C�p�b�h�����t����Ȃ�
                }

                statePad_.Resize(count);
                padRes_.Resize(count);
                for (int iPad = 0;iPad < count;iPad++)
                {
                    padRes_[iPad] = 500;
                }

                Logger.WriteTop("DirectIuput�F�W���C�p�b�h����������");

                return true;
            }

// C++ TO C# CONVERTER NOTE: CALLBACK is not available in C#:
// ORIGINAL LINE: static bool CALLBACK _GetJoypadStaticCallback(LPDIDEVICEINSTANCE lpddi, object* pvRef)
            protected static bool _GetJoypadStaticCallback(LPDIDEVICEINSTANCE lpddi, object pvRef)
            {
                DirectInput input = (DirectInput)pvRef;
                return input._GetJoypadCallback(new LPDIDEVICEINSTANCE(lpddi));
            }

            protected bool _GetJoypadCallback(LPDIDEVICEINSTANCE lpddi)
            {
                Logger.WriteTop("DirectInput�F�W���C�p�b�h������܂���");
                LPDIRECTINPUTDEVICE8 pJoypad = null;
                int hrDevice = pInput_.CreateDevice(lpddi.guidInstance, pJoypad, null);
                if (FAILED(hrDevice))
                {
                    Logger.WriteTop("DirectInput�F���͑��u�̃f�o�C�X�I�u�W�F�N�g�쐬���s");
                    return DIENUM_CONTINUE;
                }

                {
                // ���\��
                    DIDEVICEINSTANCE State = new DIDEVICEINSTANCE();
                    ZeroMemory(State, sizeof(DIDEVICEINSTANCE));
                    State.dwSize = sizeof(DIDEVICEINSTANCE);
                    pJoypad.GetDeviceInfo(State);

                    Logger.WriteTop(StringUtility.Format("�f�o�C�X�̓o�^��:%s", State.tszInstanceName));
                    Logger.WriteTop(StringUtility.Format("�f�o�C�X�̐��i�o�^��:%s", State.tszProductName));
                }

                int hrFormat = pJoypad.SetDataFormat(c_dfDIJoystick);
                if (FAILED(hrFormat))
                {
                    if (pJoypad != null)
                    {
                        pJoypad.Release();
                    }
                    Logger.WriteTop("DirectInput�F�W���C�p�b�h�̃f�[�^�t�H�[�}�b�g�ݒ莸�s");
                    return DIENUM_CONTINUE;
                }

                int hrCoop = pJoypad.SetCooperativeLevel(hWnd_, DISCL_NONEXCLUSIVE | DISCL_BACKGROUND);
                if (FAILED(hrCoop))
                {
                    if (pJoypad != null)
                    {
                        pJoypad.Release();
                    }
                    Logger.WriteTop("DirectInput�F�W���C�p�b�h�̓���ݒ莸�s");
                    return DIENUM_CONTINUE;
                }

                // x�͈̔͂�ݒ�
                DIPROPRANGE diprg = new DIPROPRANGE();
                diprg.diph.dwSize = sizeof(DIPROPRANGE);
                diprg.diph.dwHeaderSize = sizeof(diprg.diph);
                diprg.diph.dwObj = DIJOFS_X;
                diprg.diph.dwHow = DIPH_BYOFFSET;
                diprg.lMin = -1000;
                diprg.lMax = +1000;
                int hrRangeX = pJoypad.SetProperty(DIPROP_RANGE, diprg.diph);
                if (FAILED(hrRangeX))
                {
                    if (pJoypad != null)
                    {
                        pJoypad.Release();
                    }
                    Logger.WriteTop("DirectInput�F�W���C�p�b�h�f�o�C�X��x���֌W�̐ݒ�Ɏ��s���܂���");
                    return DIENUM_CONTINUE;
                }

                // y�͈̔͂�ݒ�
                diprg.diph.dwObj = DIJOFS_Y;
                int hrRangeY = pJoypad.SetProperty(DIPROP_RANGE, diprg.diph);
                if (FAILED(hrRangeY))
                {
                    if (pJoypad != null)
                    {
                        pJoypad.Release();
                    }
                    Logger.WriteTop("DirectInput�F�W���C�p�b�h�f�o�C�X��y���֌W�̐ݒ�Ɏ��s���܂���");
                    return DIENUM_CONTINUE;
                }

                // z�͈̔͂�ݒ�
                diprg.diph.dwObj = DIJOFS_Z;
                int hrRangeZ = pJoypad.SetProperty(DIPROP_RANGE, diprg.diph);
                if (FAILED(hrRangeZ))
                {
                    Logger.WriteTop("DirectInput�F�W���C�p�b�h�f�o�C�X��z���֌W�̐ݒ�Ɏ��s���܂���");
                }

                // x�̖����]�[����ݒ�
                DIPROPDWORD dipdw = new DIPROPDWORD();
                dipdw.diph.dwSize = sizeof(DIPROPDWORD);
                dipdw.diph.dwHeaderSize = sizeof(dipdw.diph);
                dipdw.diph.dwObj = DIJOFS_X;
                dipdw.diph.dwHow = DIPH_BYOFFSET;
                dipdw.dwData = 2500;
                int hrDeadX = pJoypad.SetProperty(DIPROP_DEADZONE, dipdw.diph);
                if (FAILED(hrDeadX))
                {
                    if (pJoypad != null)
                    {
                        pJoypad.Release();
                    }
                    Logger.WriteTop("DirectInput�F�W���C�p�b�h�f�o�C�X��x���̖����]�[���̐ݒ�Ɏ��s���܂���");
                    return DIENUM_CONTINUE;
                }

                // y�̖����]�[����ݒ�
                dipdw.diph.dwObj = DIJOFS_Y;
                int hrDeadY = pJoypad.SetProperty(DIPROP_DEADZONE, dipdw.diph);
                if (FAILED(hrDeadY))
                {
                    if (pJoypad != null)
                    {
                        pJoypad.Release();
                    }
                    Logger.WriteTop("DirectInput�F�W���C�p�b�h�f�o�C�X��y���̖����]�[���̐ݒ�Ɏ��s���܂���");
                    return DIENUM_CONTINUE;
                }

                // �y�̖����]�[����ݒ�
                dipdw.diph.dwObj = DIJOFS_Z;
                int hrDeadZ = pJoypad.SetProperty(DIPROP_DEADZONE, dipdw.diph);
                if (FAILED(hrDeadZ))
                {
                    Logger.WriteTop("DirectInput�F�W���C�p�b�h�f�o�C�X��z���̖����]�[���̐ݒ�Ɏ��s���܂���");
                }

                // ���͐���J�n
                pJoypad.Acquire();

                pJoypad_.Add(pJoypad);

                return DIENUM_CONTINUE;
            }

            protected bool _IdleKeyboard()
            {
                if (pInput_ == null || pKeyboard_ == null)
                {
                    return false;
                }

                int hr = pKeyboard_.GetDeviceState(AnonymousEnum3.MAX_KEY, stateKey_);
                if (SUCCEEDED(hr))
                {

                }
                else if (hr == DIERR_INPUTLOST)
                {
                    pKeyboard_.Acquire();
                }
                return true;
            }

            protected bool _IdleJoypad()
            {
                if (pJoypad_.Count == 0)
                {
                    return false;
                }
                for (int iPad = 0; iPad < pJoypad_.Count; iPad++)
                {
                    if (pInput_ == null || pJoypad_[iPad] == null)
                    {
                        return false;
                    }

                    pJoypad_[iPad].Poll();
                    int hr = pJoypad_[iPad].GetDeviceState(sizeof(DIJOYSTATE), statePad_[iPad]);
                    if (SUCCEEDED(hr))
                    {

                    }
                    else if (hr == DIERR_INPUTLOST)
                    {
                        pJoypad_[iPad].Acquire();
                    }
                }
                return true;
            }

            protected bool _IdleMouse()
            {
                if (pInput_ == null || pMouse_ == null)
                {
                    return false;
                }

                int hr = pMouse_.GetDeviceState(sizeof(DIMOUSESTATE), stateMouse_);
                if (SUCCEEDED(hr))
                {

                }
                else if (hr == DIERR_INPUTLOST)
                {
                    pMouse_.Acquire();
                }

                return true;
            }

            protected int _GetKey(uint code, int state)
            {
                return _GetStateSub((stateKey_[code] & 0x80) == 0x80, state);
            }

            protected int _GetMouseButton(int button, int state)
            {
                return _GetStateSub((stateMouse_.rgbButtons[button] & 0x80) == 0x80, state);
            }

            protected int _GetPadDirection(int index, uint code, int state)
            {
                if (index >= pJoypad_.Count)
                {
                    return (int)AnonymousEnum2.KEY_FREE;
                }
                int response = padRes_[index];

                int res = (int)AnonymousEnum2.KEY_FREE;

                switch (code)
                {
                    case DIK_UP:
                        res = _GetStateSub(statePad_[index].lY < -response, state);
                        break;
                    case DIK_DOWN:
                        res = _GetStateSub(statePad_[index].lY > response, state);
                        break;
                    case DIK_LEFT:
                        res = _GetStateSub(statePad_[index].lX < -response, state);
                        break;
                    case DIK_RIGHT:
                        res = _GetStateSub(statePad_[index].lX > response, state);
                        break;
                }

                return res;
            }

            protected int _GetPadButton(int index, int buttonNo, int state)
            {
                return _GetStateSub((statePad_[index].rgbButtons[buttonNo] & 0x80) == 0x80, state);
            }

            protected int _GetStateSub(bool flag, int state)
            {
                int res = (int)AnonymousEnum2.KEY_FREE;
                if (flag)
                {
                    if (state == (int)AnonymousEnum2.KEY_FREE)
                    {
                        res = (int)AnonymousEnum2.KEY_PUSH;
                    }
                    else
                    {
                        res = (int)AnonymousEnum2.KEY_HOLD;
                    }
                }
                else
                {
                    if (state == (int)AnonymousEnum2.KEY_PUSH || state == (int)AnonymousEnum2.KEY_HOLD)
                    {
                        res = (int)AnonymousEnum2.KEY_PULL;
                    }
                    else
                    {
                        res = (int)AnonymousEnum2.KEY_FREE;
                    }
                }
                return res;
            }


            /**********************************************************
            //DirectInput
            **********************************************************/
            public DirectInput()
            {
                hWnd_ = null;
                pInput_ = null;
                pKeyboard_ = null;
                pMouse_ = null;
            }

            public virtual void Dispose()
            {
                Logger.WriteTop("DirectInput�F�I���J�n");
                for (int iPad = 0; iPad < pJoypad_.Count; iPad++)
                {
                    if (pJoypad_[iPad] == null)
                    {
                        continue;
                    }
                    pJoypad_[iPad].Unacquire();
                    if (pJoypad_[iPad] != null)
                    {
                        pJoypad_[iPad].Release();
                    }
                }

                if (pMouse_ != null)
                {
                    pMouse_.Unacquire();
                    pMouse_.Release();
                }

                if (pKeyboard_ != null)
                {
                    pKeyboard_.Unacquire();
                    pKeyboard_.Release();
                }

                if (pInput_ != null)
                {
                    pInput_.Release();
                }
                thisBase_ = null;
                Logger.WriteTop("DirectInput�F�I������");
            }

            public static DirectInput GetBase()
            {
                return thisBase_;
            }

            public virtual bool Initialize(IntPtr hWnd)
            {
                if (thisBase_ != null)
                {
                    return false;
                }
                Logger.WriteTop("DirectInput�F������");
                hWnd_ = hWnd;

                IntPtr hInst = global::GetModuleHandle(null);
                int hrInput = DirectInput8Create(hInst, DefineConstants.DIRECTINPUT_VERSION, IID_IDirectInput8, (object) pInput_, null);
                if (FAILED(hrInput))
                {
                    Logger.WriteTop("DirectInput�FDirectInput8Create���s");
                    return false; // DirectInput8�̍쐬�Ɏ��s
                }

                _InitializeKeyBoard();
                _InitializeMouse();
                _InitializeJoypad();

                bufPad_.Resize(pJoypad_.Count);
                for (int iPad = 0; iPad < pJoypad_.Count; iPad++)
                {
                    bufPad_[iPad].Resize(32);
                }

                thisBase_ = this;
                Logger.WriteTop("DirectInput�F����������");
                return true;
            }

            public virtual void Update()
            {
                this._IdleKeyboard();
                this._IdleJoypad();
                this._IdleMouse();

                for (int iKey = 0; iKey < 255; iKey++)
                {
                    bufKey_[iKey] = _GetKey((uint)iKey, bufKey_[iKey]);
                }

                for (int iButton = 0;iButton < 3;iButton++)
                {
                    bufMouse_[iButton] = _GetMouseButton(iButton, bufMouse_[iButton]);
                }

                for (int iPad = 0; iPad < pJoypad_.Count; iPad++)
                {
                    bufPad_[iPad][0] = _GetPadDirection(iPad, DIK_LEFT, new List<List<int>>(bufPad_[iPad][0]));
                    bufPad_[iPad][1] = _GetPadDirection(iPad, DIK_RIGHT, new List<List<int>>(bufPad_[iPad][1]));
                    bufPad_[iPad][2] = _GetPadDirection(iPad, DIK_UP, new List<List<int>>(bufPad_[iPad][2]));
                    bufPad_[iPad][3] = _GetPadDirection(iPad, DIK_DOWN, new List<List<int>>(bufPad_[iPad][3]));

                    for (int iButton = 0;iButton < (int)AnonymousEnum3.MAX_PAD_BUTTON;iButton++)
                    {
                        bufPad_[iPad][iButton + 4] = _GetPadButton(iPad, iButton, new List<List<int>>(bufPad_[iPad][iButton + 4]));
                    }
                }
            }

            public int GetKeyState(int key)
            {
                if (key < 0 || key >= (int)AnonymousEnum3.MAX_KEY)
                {
                    return (int)AnonymousEnum2.KEY_FREE;
                }
                return bufKey_[key];
            }

            public int GetMouseState(int button)
            {
                if (button < 0 || button >= (int)AnonymousEnum3.MAX_MOUSE_BUTTON)
                {
                    return (int)AnonymousEnum2.KEY_FREE;
                }
                return bufMouse_[button];
            }

            public int GetPadState(int padNo, int button)
            {
                int res = (int)AnonymousEnum2.KEY_FREE;
                if (padNo < bufPad_.Count)
                {
                    res = bufPad_[padNo][button];
                }
                return res;
            }

            public int GetMouseMoveX()
            {
                return stateMouse_.lX;
            } // �}�E�X�̈ړ��ʂ�擾X
            public int GetMouseMoveY()
            {
                return stateMouse_.lY;
            } // �}�E�X�̈ړ��ʂ�擾Y
            public int GetMouseMoveZ()
            {
                return stateMouse_.lZ;
            } // �}�E�X�̈ړ��ʂ�擾Z
            public POINT GetMousePosition()
            {
                POINT res = new POINT(0, 0);
                GetCursorPos(res);
                ScreenToClient(hWnd_, res);
                return new POINT(res);
            }

            public void ResetInputState()
            {
                ResetMouseState();
                ResetKeyState();
                ResetPadState();
            }

            public void ResetMouseState()
            {
                for (int iButton = 0;iButton < 3;iButton++)
                {
                    bufMouse_[iButton] = (int)AnonymousEnum2.KEY_FREE;
                }
                ZeroMemory(stateMouse_, sizeof(DIMOUSESTATE));
            }

            public void ResetKeyState()
            {
                for (int iKey = 0;iKey < (int)AnonymousEnum3.MAX_KEY;iKey++)
                {
                    bufKey_[iKey] = (int)AnonymousEnum2.KEY_FREE;
                }
                ZeroMemory(stateKey_, sizeof(byte));
            }

            public void ResetPadState()
            {
                for (int iPad = 0 ; iPad < bufPad_.Count ; iPad++)
                {
                    for (int iKey = 0;iKey < bufPad_.Count;iKey++)
                    {
                        bufPad_[iPad][iKey] = (int)AnonymousEnum2.KEY_FREE;
                    }
                    statePad_[iPad].lX = 0;
                    statePad_[iPad].lY = 0;
                    for (int iButton = 0 ; iButton < (int)AnonymousEnum3.MAX_PAD_BUTTON ; iButton++)
                    {
                        statePad_[iPad].rgbButtons[iButton] = AnonymousEnum2.KEY_FREE;
                    }
                }
            }

            public int GetPadDeviceCount()
            {
                return bufPad_.Count;
            }
            public DIDEVICEINSTANCE GetPadDeviceInformation(int padIndex)
            {
                DIDEVICEINSTANCE state = new DIDEVICEINSTANCE();
                ZeroMemory(state, sizeof(DIDEVICEINSTANCE));
                state.dwSize = sizeof(DIDEVICEINSTANCE);
                pJoypad_[padIndex].GetDeviceInfo(state);
                return new DIDEVICEINSTANCE(state);
            }
    }

    /**********************************************************
    //VirtualKeyManager
    **********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class VirtualKeyManager;
    public class VirtualKey : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend VirtualKeyManager;
            private int keyboard_; // �L�[�{�[�h�̃L�[
            private int padIndex_; // �W���C�p�b�h�̔ԍ�
            private int padButton_; // �W���C�p�b�h�̃{�^��
            private int state_; // ���݂̏��


            /**********************************************************
            //VirtualKeyManager
            **********************************************************/
            // VirtualKey
            public VirtualKey(int keyboard, int padIndex, int padButton)
            {
                keyboard_ = keyboard;
                padIndex_ = padIndex;
                padButton_ = padButton;
                state_ = (int)AnonymousEnum2.KEY_FREE;
            }

            public virtual void Dispose()
            {
            }

            public int GetKeyState()
            {
                return state_;
            }
            public void SetKeyState(int state)
            {
                state_ = state;
            }

            public int GetKeyCode()
            {
                return keyboard_;
            }
            public void SetKeyCode(int code)
            {
                keyboard_ = code;
            }
            public int GetPadIndex()
            {
                return padIndex_;
            }
            public void SetPadIndex(int index)
            {
                padIndex_ = index;
            }
            public int GetPadButton()
            {
                return padButton_;
            }
            public void SetPadButton(int button)
            {
                padButton_ = button;
            }

    }

    public class VirtualKeyManager : DirectInput
    {
            protected SortedDictionary<int, gstd.ref_count_ptr<VirtualKey>> mapKey_ = new SortedDictionary<int, gstd.ref_count_ptr<VirtualKey>>();

            protected int _GetVirtualKeyState(int id)
            {
                if (!mapKey_.ContainsKey(id))
                {
                    return (int)AnonymousEnum2.KEY_FREE;
                }

                gstd.ref_count_ptr<VirtualKey> key = mapKey_[id];

                int res = (int)AnonymousEnum2.KEY_FREE;
                if (key.keyboard_ >= 0 && key.keyboard_ < MAX_KEY)
                {
                    res = bufKey_[key.keyboard_];
                }
                if (res == (int)AnonymousEnum2.KEY_FREE)
                {
                    int indexPad = key.padIndex_;
                    if (indexPad >= 0 && indexPad < pJoypad_.Count)
                    {
                        if (key.padButton_ >= 0 && key.padButton_ < bufPad_[indexPad].Count)
                        {
                            res = bufPad_[indexPad][key.padButton_];
                        }
                    }
                }

                return res;
            }


            // VirtualKeyManager
            public VirtualKeyManager()
            {

            }

            public new void Dispose()
            {

                base.Dispose();
            }

            public override void Update()
            {
                base.Update();

                SortedDictionary<int, gstd.ref_count_ptr<VirtualKey>>.Enumerator itr = mapKey_.GetEnumerator();
                while (itr.MoveNext())
                {
                    int id = itr.Current.Key;
                    gstd.ref_count_ptr<VirtualKey> key = itr.Current.Value;

                    int state = _GetVirtualKeyState(id);
                    key.SetKeyState(state);
                }
            }

            public void ClearKeyState()
            {
                base.ResetInputState();
                SortedDictionary<int, gstd.ref_count_ptr<VirtualKey>>.Enumerator itr = mapKey_.GetEnumerator();
                while (itr.MoveNext())
                {
                    gstd.ref_count_ptr<VirtualKey> key = itr.Current.Value;
                    key.SetKeyState(AnonymousEnum2.KEY_FREE);
                }
            }

            public void AddKeyMap(int id, gstd.ref_count_ptr<VirtualKey> key)
            {
                mapKey_[id].CopyFrom(key);
            }
            public void DeleteKeyMap(int id)
            {
                mapKey_.Remove(id);
            }
            public void ClearKeyMap()
            {
                mapKey_.Clear();
            }
            public int GetVirtualKeyState(int id)
            {
                if (!mapKey_.ContainsKey(id))
                {
                    return (int)AnonymousEnum2.KEY_FREE;
                }
                gstd.ref_count_ptr<VirtualKey> key = mapKey_[id];
                return key.GetKeyState();
            }

            public gstd.ref_count_ptr<VirtualKey> GetVirtualKey(int id)
            {
                if (!mapKey_.ContainsKey(id))
                {
                    return null;
                }
                return new gstd.ref_count_ptr<VirtualKey>(mapKey_[id]);
            }

            public bool IsTargetKeyCode(int key)
            {
                bool res = false;
                SortedDictionary<int, gstd.ref_count_ptr<VirtualKey>>.Enumerator itr = mapKey_.GetEnumerator();
                while (itr.MoveNext())
                {
                    gstd.ref_count_ptr<VirtualKey> vKey = itr.Current.Value;
                    int keyCode = vKey.GetKeyCode();
                    if (key == keyCode)
                    {
                        res = true;
                        break;
                    }
                }
                return res;
            }
    }

    /**********************************************************
    //KeyReplayManager
    **********************************************************/
    public class KeyReplayManager : System.IDisposable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum4
            {
                STATE_RECORD,
                STATE_REPLAY
            }
            protected class ReplayData
            {
                public int id_;
                public int frame_;
                public int state_;
            }

            protected int state_;
            protected int frame_;
            protected SortedDictionary<int, int> mapLastKeyState_ = new SortedDictionary<int, int>();
            protected LinkedList<int> listTarget_ = new LinkedList<int>();
            protected LinkedList<ReplayData> listReplayData_ = new LinkedList<ReplayData>();
            protected VirtualKeyManager input_;

            /**********************************************************
            //KeyReplayManager
            **********************************************************/
            public KeyReplayManager(VirtualKeyManager input)
            {
                frame_ = 0;
                input_ = input;
                state_ = (int)AnonymousEnum4.STATE_RECORD;
            }

            public virtual void Dispose()
            {
            }

            public void SetManageState(int state)
            {
                state_ = state;
            }
            public void AddTarget(int key)
            {
                listTarget_.AddLast(key);
                mapLastKeyState_[key] = (int)AnonymousEnum2.KEY_FREE;
            }

            public bool IsTargetKeyCode(int key)
            {
                bool res = false;
                LinkedList<int>.Enumerator itrTarget = listTarget_.GetEnumerator();
                while (itrTarget.MoveNext())
                {
                    int idKey = itrTarget.Current;
                    gstd.ref_count_ptr<VirtualKey> vKey = input_.GetVirtualKey(idKey);
                    int keyCode = vKey.GetKeyCode();
                    if (key == keyCode)
                    {
                        res = true;
                        break;
                    }
                }
                return res;
            }

            public void Update()
            {
                if (state_ == (int)AnonymousEnum4.STATE_RECORD)
                {
                    LinkedList<int>.Enumerator itrTarget = listTarget_.GetEnumerator();
                    while (itrTarget.MoveNext())
                    {
                        int idKey = itrTarget.Current;
                        int keyState = input_.GetVirtualKeyState(idKey);
                        bool bInsert = (frame_ == 0 || mapLastKeyState_[idKey] != keyState);
                        if (bInsert)
                        {
                            ReplayData data = new ReplayData();
                            data.id_ = idKey;
                            data.frame_ = frame_;
                            data.state_ = keyState;
                            listReplayData_.AddLast(data);
                        }
                        mapLastKeyState_[idKey] = keyState;
                    }
                }
                else if (state_ == (int)AnonymousEnum4.STATE_REPLAY)
                {
                    LinkedList<int>.Enumerator itrTarget = listTarget_.GetEnumerator();
                    while (itrTarget.MoveNext())
                    {
                        int idKey = itrTarget.Current;
                        LinkedList<ReplayData>.Enumerator itrData = listReplayData_.GetEnumerator();
                        while (itrData.MoveNext())
                        {
                            ReplayData data = itrData.Current;
                            if (data.frame_ > frame_)
                            {
                                break;
                            }

                            if (idKey == data.id_ && data.frame_ == frame_)
                            {
                                mapLastKeyState_[idKey] = data.state_;
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                                itrData = listReplayData_.erase(itrData);
                            }
                            else
                            {
                            }
                        }

                        gstd.ref_count_ptr<VirtualKey> key = input_.GetVirtualKey(idKey);
                        int lastKeyState = mapLastKeyState_[idKey];
                        key.SetKeyState(lastKeyState);
                    }
                }
                frame_++;
            }

            public void ReadRecord(gstd.RecordBuffer record)
            {
                int countReplayData = record.GetRecordAsInteger("count");

                ByteBuffer buffer = new ByteBuffer();
                buffer.SetSize(sizeof(ReplayData) * countReplayData);
                record.GetRecord("data", buffer.GetPointer(), buffer.GetSize());

                for (int iRec = 0 ; iRec < countReplayData ; iRec++)
                {
                    ReplayData data = new ReplayData();
                    buffer.Read(data, sizeof(ReplayData));
                    listReplayData_.AddLast(data);
                }
            }

            public void WriteRecord(gstd.RecordBuffer record)
            {
                int countReplayData = listReplayData_.Count;
                record.SetRecordAsInteger("count", countReplayData);

                ByteBuffer buffer = new ByteBuffer();
                LinkedList<ReplayData>.Enumerator itrData = listReplayData_.GetEnumerator();
                while (itrData.MoveNext())
                {
                    ReplayData data = itrData.Current;
                    buffer.Write(data, sizeof(ReplayData));
                }

                record.SetRecord("data", buffer.GetPointer(), buffer.GetSize());
            }
    }
}

