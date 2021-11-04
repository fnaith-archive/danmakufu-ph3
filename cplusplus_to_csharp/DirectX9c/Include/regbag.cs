using System;

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for regbag.idl:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
// @@MIDL_FILE_HEADING(  )


/* verify that the <rpcndr.h> version is high enough to compile this file*/

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "rpc.h"
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "rpcndr.h"

#if ! __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#if ! COM_NO_WINDOWS_H
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "ole2.h"
#endif //COM_NO_WINDOWS_H


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER && (_MSC_VER >= 1020)
#endif

/* Forward Declarations */ 



/* header files for imported files */
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "objidl.h"
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "oaidl.h"
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "ocidl.h"

#if __cplusplus
#endif

#else // C style interface

    public class ICreatePropBagOnRegKeyVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICreatePropBagOnRegKey * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICreatePropBagOnRegKey This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICreatePropBagOnRegKey * This);
        public delegate uint AddRefDelegate(@interface ICreatePropBagOnRegKey This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICreatePropBagOnRegKey * This);
        public delegate uint ReleaseDelegate(@interface ICreatePropBagOnRegKey This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Create)(interface ICreatePropBagOnRegKey * This, System.IntPtr hkey, LPCOLESTR subkey, uint ulOptions, uint samDesired, REFIID iid, object**ppBag);
        public delegate int CreateDelegate(@interface ICreatePropBagOnRegKey This, IntPtr hkey, LPCOLESTR subkey, uint ulOptions, uint samDesired, REFIID iid, object ppBag[] UnnamedParameter);
        public CreateDelegate Create;

//        END_INTERFACE
    }