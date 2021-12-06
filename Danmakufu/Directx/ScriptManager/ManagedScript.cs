using Directx.DxScript;

namespace Directx.ScriptManager
{
    class ManagedScript : DxScript.DxScript // TODO LoadObject
    {
        public const int TYPE_ALL = -1;
            public ManagedScript()
            {
                //scriptManager_ = null; TODO
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(commonFunction, sizeof(commonFunction) / sizeof(function));
                _AddFunction(CommonFunction.commonFunction);

                //bLoad_ = false; TODO
                //bEndScript_ = false; TODO
                //bAutoDeleteObject_ = false; TODO
            }
        // TODO
    }
}
