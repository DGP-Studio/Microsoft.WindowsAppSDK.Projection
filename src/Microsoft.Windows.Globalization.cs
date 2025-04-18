//------------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by cswinrt.exe version 2.2.0.241111.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WinRT;
using WinRT.Interop;


#pragma warning disable 0169 // warning CS0169: The field '...' is never used
#pragma warning disable 0649 // warning CS0169: Field '...' is never assigned to
#pragma warning disable CA2207, CA1063, CA1033, CA1001, CA2213

namespace Microsoft.Windows.Globalization
{
    [global::WinRT.WindowsRuntimeType("Microsoft.Windows.Globalization")][global::Windows.Foundation.Metadata.ContractVersion(typeof(global::Microsoft.Windows.ApplicationModel.Resources.MrtCoreContract), 131072u)]
    public static class ApplicationLanguages
    {

        public static I As<I>() => ActivationFactory.Get("Microsoft.Windows.Globalization.ApplicationLanguages").AsInterface<I>();

        private static volatile IObjectReference ___objRef_global__Microsoft_Windows_Globalization_IApplicationLanguagesStatics;
        private static IObjectReference _objRef_global__Microsoft_Windows_Globalization_IApplicationLanguagesStatics
        {
            get
            { 
                var factory = ___objRef_global__Microsoft_Windows_Globalization_IApplicationLanguagesStatics;
                if (factory != null && factory.IsInCurrentContext)
                {
                    return factory;
                }
                else
                {
                    return ___objRef_global__Microsoft_Windows_Globalization_IApplicationLanguagesStatics = ActivationFactory.Get("Microsoft.Windows.Globalization.ApplicationLanguages", global::ABI.Microsoft.Windows.Globalization.IApplicationLanguagesStaticsMethods.IID);
                }
            }
        }

        public static global::System.Collections.Generic.IReadOnlyList<string> Languages => global::ABI.Microsoft.Windows.Globalization.IApplicationLanguagesStaticsMethods.get_Languages(_objRef_global__Microsoft_Windows_Globalization_IApplicationLanguagesStatics);

        public static global::System.Collections.Generic.IReadOnlyList<string> ManifestLanguages => global::ABI.Microsoft.Windows.Globalization.IApplicationLanguagesStaticsMethods.get_ManifestLanguages(_objRef_global__Microsoft_Windows_Globalization_IApplicationLanguagesStatics);

        public static string PrimaryLanguageOverride
        {
            get => global::ABI.Microsoft.Windows.Globalization.IApplicationLanguagesStaticsMethods.get_PrimaryLanguageOverride(_objRef_global__Microsoft_Windows_Globalization_IApplicationLanguagesStatics);
            set => global::ABI.Microsoft.Windows.Globalization.IApplicationLanguagesStaticsMethods.set_PrimaryLanguageOverride(_objRef_global__Microsoft_Windows_Globalization_IApplicationLanguagesStatics, value);
        }
    }
    [global::WinRT.WindowsRuntimeType("Microsoft.Windows.Globalization")][Guid("58DFCEF9-08EC-5086-8AF1-D5BEAB79250A")][global::WinRT.WindowsRuntimeHelperType(typeof(global::ABI.Microsoft.Windows.Globalization.IApplicationLanguagesStatics))]
    [global::Windows.Foundation.Metadata.ContractVersion(typeof(global::Microsoft.Windows.ApplicationModel.Resources.MrtCoreContract), 131072u)]
    internal interface IApplicationLanguagesStatics
    {
        global::System.Collections.Generic.IReadOnlyList<string> Languages { get; }
        global::System.Collections.Generic.IReadOnlyList<string> ManifestLanguages { get; }
        string PrimaryLanguageOverride { get; set; }
    }
}

#pragma warning disable CA1416
namespace ABI.Microsoft.Windows.Globalization
{
    internal static class IApplicationLanguagesStaticsMethods
    {

        internal static unsafe global::System.Collections.Generic.IReadOnlyList<string> get_Languages(IObjectReference _obj)
        {
            var ThisPtr = _obj.ThisPtr;

            IntPtr __retval = default;
            try
            {
                global::WinRT.ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>**)ThisPtr)[6](ThisPtr, &__retval));
                global::System.GC.KeepAlive(_obj);
                _ = global::WinRT.GenericTypeInstantiations.Windows_Foundation_Collections_IVectorView_1_String.EnsureInitialized();
                return MarshalInterface<global::System.Collections.Generic.IReadOnlyList<string>>.FromAbi(__retval);
            }
            finally
            {
                MarshalInterface<global::System.Collections.Generic.IReadOnlyList<string>>.DisposeAbi(__retval);
            }
        }

        internal static unsafe global::System.Collections.Generic.IReadOnlyList<string> get_ManifestLanguages(IObjectReference _obj)
        {
            var ThisPtr = _obj.ThisPtr;

            IntPtr __retval = default;
            try
            {
                global::WinRT.ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>**)ThisPtr)[7](ThisPtr, &__retval));
                global::System.GC.KeepAlive(_obj);
                _ = global::WinRT.GenericTypeInstantiations.Windows_Foundation_Collections_IVectorView_1_String.EnsureInitialized();
                return MarshalInterface<global::System.Collections.Generic.IReadOnlyList<string>>.FromAbi(__retval);
            }
            finally
            {
                MarshalInterface<global::System.Collections.Generic.IReadOnlyList<string>>.DisposeAbi(__retval);
            }
        }

        internal static unsafe string get_PrimaryLanguageOverride(IObjectReference _obj)
        {
            var ThisPtr = _obj.ThisPtr;

            IntPtr __retval = default;
            try
            {
                global::WinRT.ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>**)ThisPtr)[8](ThisPtr, &__retval));
                global::System.GC.KeepAlive(_obj);
                return MarshalString.FromAbi(__retval);
            }
            finally
            {
                MarshalString.DisposeAbi(__retval);
            }
        }
        internal static unsafe void set_PrimaryLanguageOverride(IObjectReference _obj, string value)
        {
            var ThisPtr = _obj.ThisPtr;

            MarshalString.Pinnable __value = new(value);
            fixed(void* ___value = __value)
            {
                global::WinRT.ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>**)ThisPtr)[9](ThisPtr, MarshalString.GetAbi(ref __value)));
                global::System.GC.KeepAlive(_obj);
            }
        }



        public static ref readonly global::System.Guid IID
        {
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            get
            {
                global::System.ReadOnlySpan<byte> data = new byte[] { 0xF9, 0xCE, 0xDF, 0x58, 0xEC, 0x8, 0x86, 0x50, 0x8A, 0xF1, 0xD5, 0xBE, 0xAB, 0x79, 0x25, 0xA };
                return ref global::System.Runtime.CompilerServices.Unsafe.As<byte, global::System.Guid>(ref global::System.Runtime.InteropServices.MemoryMarshal.GetReference(data));
            }
        }

    }
    [Guid("58DFCEF9-08EC-5086-8AF1-D5BEAB79250A")]
    internal interface IApplicationLanguagesStatics : global::Microsoft.Windows.Globalization.IApplicationLanguagesStatics
    {
    }
}
#pragma warning restore CA1416
