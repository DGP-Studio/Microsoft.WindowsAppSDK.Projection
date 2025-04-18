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

namespace Microsoft.UI.Xaml.Resources
{
    [global::WinRT.WindowsRuntimeType("Microsoft.UI.Xaml")]
    [global::WinRT.WindowsRuntimeHelperType(typeof(global::ABI.Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader))]
    [global::ABI.Microsoft.UI.Xaml.Resources.CustomXamlResourceLoaderRcwFactory]
    [global::WinRT.ProjectedRuntimeClass(typeof(ICustomXamlResourceLoader))]
    [global::Windows.Foundation.Metadata.ContractVersion(typeof(global::Microsoft.UI.Xaml.WinUIContract), 65536u)]
    public class CustomXamlResourceLoader : ICustomXamlResourceLoaderOverrides, global::System.Runtime.InteropServices.ICustomQueryInterface, IWinRTObject, IEquatable<CustomXamlResourceLoader>
    {
        private IntPtr ThisPtr => _inner == null ? (((IWinRTObject)this).NativeObject).ThisPtr : _inner.ThisPtr;

        private readonly IObjectReference _inner = null;




        private volatile IObjectReference ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoader;
        private IObjectReference Make___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoader()
        {
            global::System.Threading.Interlocked.CompareExchange(ref ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoader, ((IWinRTObject)this).NativeObject.As<IUnknownVftbl>(global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderMethods.IID), null);
            return ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoader;
        }
        private IObjectReference _objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoader => ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoader ?? Make___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoader();

        private volatile IObjectReference ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderOverrides;
        private IObjectReference Make___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderOverrides()
        {
            global::System.Threading.Interlocked.CompareExchange(ref ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderOverrides, ((IWinRTObject)this).NativeObject.As<IUnknownVftbl>(global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderOverridesMethods.IID), null);
            return ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderOverrides;
        }
        private IObjectReference _objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderOverrides => ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderOverrides ?? Make___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderOverrides();



        private static class _ICustomXamlResourceLoaderFactoryMethods
        {
            public static unsafe IntPtr CreateInstance(IObjectReference _obj, object baseInterface, out IntPtr innerInterface)
            {
                var ThisPtr = _obj.ThisPtr;

                ObjectReferenceValue __baseInterface = default;
                IntPtr __innerInterface = default;
                IntPtr __retval = default;
                try
                {
                    __baseInterface = MarshalInspectable<object>.CreateMarshaler2(baseInterface);
                    global::WinRT.ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr*, IntPtr*, int>**)ThisPtr)[6](ThisPtr, MarshalInspectable<object>.GetAbi(__baseInterface), &__innerInterface, &__retval));
                    global::System.GC.KeepAlive(_obj);
                    innerInterface = __innerInterface;
                    return __retval;
                }
                finally
                {
                    MarshalInspectable<object>.DisposeMarshaler(__baseInterface);
                }
            }
        }

        private static volatile IObjectReference ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderFactory;
        private static IObjectReference _objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderFactory
        {
            get
            { 
                var factory = ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderFactory;
                if (factory != null && factory.IsInCurrentContext)
                {
                    return factory;
                }
                else
                {
                    return ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderFactory = ActivationFactory.Get("Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader", global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderFactoryMethods.IID);
                }
            }
        }

        public CustomXamlResourceLoader()
        {
            bool isAggregation = this.GetType() != typeof(CustomXamlResourceLoader);
            object baseInspectable = isAggregation ? this : null;
            IntPtr composed = _ICustomXamlResourceLoaderFactoryMethods.CreateInstance(_objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderFactory,  baseInspectable, out IntPtr inner);
            try
            {
                ComWrappersHelper.Init(isAggregation, this, composed, inner, global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderMethods.IID, out _inner);

            }
            finally
            {
                Marshal.Release(inner);   
            }
        }

        public static I As<I>() => ActivationFactory.Get("Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader").AsInterface<I>();

        private static volatile IObjectReference ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderStatics;
        private static IObjectReference _objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderStatics
        {
            get
            { 
                var factory = ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderStatics;
                if (factory != null && factory.IsInCurrentContext)
                {
                    return factory;
                }
                else
                {
                    return ___objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderStatics = ActivationFactory.Get("Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader", global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderStaticsMethods.IID);
                }
            }
        }

        public static CustomXamlResourceLoader Current
        {
            get => global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderStaticsMethods.get_Current(_objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderStatics);
            set => global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderStaticsMethods.set_Current(_objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderStatics, value);
        }

        public static CustomXamlResourceLoader FromAbi(IntPtr thisPtr)
        {
            if (thisPtr == IntPtr.Zero) return null;
            return MarshalInspectable<CustomXamlResourceLoader>.FromAbi(thisPtr);
        }

        protected internal CustomXamlResourceLoader(IObjectReference objRef)
        {
            _inner = objRef.As(global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderMethods.IID);

        }


        public static bool operator ==(CustomXamlResourceLoader x, CustomXamlResourceLoader y) => (x?.ThisPtr ?? IntPtr.Zero) == (y?.ThisPtr ?? IntPtr.Zero);
        public static bool operator !=(CustomXamlResourceLoader x, CustomXamlResourceLoader y) => !(x == y);
        public bool Equals(CustomXamlResourceLoader other) => this == other;
        public override bool Equals(object obj) => obj is CustomXamlResourceLoader that && this == that;
        public override int GetHashCode() => ThisPtr.GetHashCode();


        protected CustomXamlResourceLoader(global::WinRT.DerivedComposed _)
        {

        }
        bool IWinRTObject.HasUnwrappableNativeObject => this.GetType() == typeof(CustomXamlResourceLoader);
        IObjectReference IWinRTObject.NativeObject => _inner;
        private volatile global::System.Collections.Concurrent.ConcurrentDictionary<RuntimeTypeHandle, IObjectReference> _queryInterfaceCache;
        private global::System.Collections.Concurrent.ConcurrentDictionary<RuntimeTypeHandle, IObjectReference> MakeQueryInterfaceCache()
        {
            global::System.Threading.Interlocked.CompareExchange(ref _queryInterfaceCache, new global::System.Collections.Concurrent.ConcurrentDictionary<RuntimeTypeHandle, IObjectReference>(), null); 
            return _queryInterfaceCache;
        }
        global::System.Collections.Concurrent.ConcurrentDictionary<RuntimeTypeHandle, IObjectReference> IWinRTObject.QueryInterfaceCache => _queryInterfaceCache ?? MakeQueryInterfaceCache();
        private volatile global::System.Collections.Concurrent.ConcurrentDictionary<RuntimeTypeHandle, object> _additionalTypeData;
        private global::System.Collections.Concurrent.ConcurrentDictionary<RuntimeTypeHandle, object> MakeAdditionalTypeData()
        {
            global::System.Threading.Interlocked.CompareExchange(ref _additionalTypeData, new global::System.Collections.Concurrent.ConcurrentDictionary<RuntimeTypeHandle, object>(), null); 
            return _additionalTypeData;
        }
        global::System.Collections.Concurrent.ConcurrentDictionary<RuntimeTypeHandle, object> IWinRTObject.AdditionalTypeData => _additionalTypeData ?? MakeAdditionalTypeData();

        private struct InterfaceTag<I>{};


        protected virtual object GetResource(string resourceId, string objectType, string propertyName, string propertyType) => global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderOverridesMethods.GetResource(_objRef_global__Microsoft_UI_Xaml_Resources_ICustomXamlResourceLoaderOverrides, resourceId, objectType, propertyName, propertyType);

        object ICustomXamlResourceLoaderOverrides.GetResource(string resourceId, string objectType, string propertyName, string propertyType) => GetResource(resourceId, objectType, propertyName, propertyType);
        protected virtual bool IsOverridableInterface(Guid iid) => global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderOverridesMethods.IID == iid;

        global::System.Runtime.InteropServices.CustomQueryInterfaceResult global::System.Runtime.InteropServices.ICustomQueryInterface.GetInterface(ref Guid iid, out IntPtr ppv)
        {
            ppv = IntPtr.Zero;
            if (IsOverridableInterface(iid) || global::WinRT.Interop.IID.IID_IInspectable == iid)
            {
                return global::System.Runtime.InteropServices.CustomQueryInterfaceResult.NotHandled;
            }

            if (((IWinRTObject)this).NativeObject.TryAs(iid, out ppv) >= 0)
            {
                return global::System.Runtime.InteropServices.CustomQueryInterfaceResult.Handled;
            }

            return global::System.Runtime.InteropServices.CustomQueryInterfaceResult.NotHandled;
        }
    }
    [global::WinRT.WindowsRuntimeType("Microsoft.UI.Xaml")][Guid("2832C2E5-2ACE-5993-A173-3C9C3B992B2E")][global::WinRT.WindowsRuntimeHelperType(typeof(global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoader))]
    [global::Windows.Foundation.Metadata.ContractVersion(typeof(global::Microsoft.UI.Xaml.WinUIContract), 65536u)]
    internal interface ICustomXamlResourceLoader
    {
    }
    [global::WinRT.WindowsRuntimeType("Microsoft.UI.Xaml")][Guid("174D49A6-E1E2-5F7B-A618-A8A953D1B5A0")][global::WinRT.WindowsRuntimeHelperType(typeof(global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderFactory))]
    [global::Windows.Foundation.Metadata.ContractVersion(typeof(global::Microsoft.UI.Xaml.WinUIContract), 65536u)]
    internal interface ICustomXamlResourceLoaderFactory
    {
        CustomXamlResourceLoader CreateInstance(object baseInterface, out object innerInterface);
    }
    [global::WinRT.WindowsRuntimeType("Microsoft.UI.Xaml")][Guid("84BB504C-6730-586A-BD04-9198264B2DC7")][global::WinRT.WindowsRuntimeHelperType(typeof(global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderOverrides))]
    [global::Windows.Foundation.Metadata.ContractVersion(typeof(global::Microsoft.UI.Xaml.WinUIContract), 65536u)]
    internal interface ICustomXamlResourceLoaderOverrides
    {
        object GetResource(string resourceId, string objectType, string propertyName, string propertyType);
    }
    [global::WinRT.WindowsRuntimeType("Microsoft.UI.Xaml")][Guid("E08A5A92-B1A2-539A-9D4A-7994E4468CD7")][global::WinRT.WindowsRuntimeHelperType(typeof(global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderStatics))]
    [global::Windows.Foundation.Metadata.ContractVersion(typeof(global::Microsoft.UI.Xaml.WinUIContract), 65536u)]
    internal interface ICustomXamlResourceLoaderStatics
    {
        CustomXamlResourceLoader Current { get; set; }
    }
}

#pragma warning disable CA1416
namespace ABI.Microsoft.UI.Xaml.Resources
{
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    public struct CustomXamlResourceLoader
    {

        public static IObjectReference CreateMarshaler(global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader obj) => obj is null ? null : MarshalInspectable<global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader>.CreateMarshaler<IUnknownVftbl>(obj, global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderMethods.IID);
        public static ObjectReferenceValue CreateMarshaler2(global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader obj) => MarshalInspectable<object>.CreateMarshaler2(obj, global::ABI.Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderMethods.IID);
        public static IntPtr GetAbi(IObjectReference value) => value is null ? IntPtr.Zero : MarshalInterfaceHelper<object>.GetAbi(value);
        public static global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader FromAbi(IntPtr thisPtr) => global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader.FromAbi(thisPtr);
        public static IntPtr FromManaged(global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader obj) => obj is null ? IntPtr.Zero : CreateMarshaler2(obj).Detach();
        public static unsafe MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader>.MarshalerArray CreateMarshalerArray(global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader[] array) => MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader>.CreateMarshalerArray2(array, (o) => CreateMarshaler2(o));
        public static (int length, IntPtr data) GetAbiArray(object box) => MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader>.GetAbiArray(box);
        public static unsafe global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader[] FromAbiArray(object box) => MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader>.FromAbiArray(box, FromAbi);
        public static void CopyAbiArray(global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader[] array, object box) => MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader>.CopyAbiArray(array, box, FromAbi);
        public static (int length, IntPtr data) FromManagedArray(global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader[] array) => MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader>.FromManagedArray(array, (o) => FromManaged(o));
        public static void DisposeMarshaler(IObjectReference value) => MarshalInspectable<object>.DisposeMarshaler(value);
        public static void DisposeMarshalerArray(MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader>.MarshalerArray array) => MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader>.DisposeMarshalerArray(array);
        public static void DisposeAbi(IntPtr abi) => MarshalInspectable<object>.DisposeAbi(abi);
        public static unsafe void DisposeAbiArray(object box) => MarshalInspectable<object>.DisposeAbiArray(box);
    }
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class CustomXamlResourceLoaderRcwFactoryAttribute : global::WinRT.WinRTImplementationTypeRcwFactoryAttribute
    {
        public override object CreateInstance(global::WinRT.IInspectable inspectable)
            => new global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader(inspectable.ObjRef);
    }
    internal static class ICustomXamlResourceLoaderMethods
    {



        public static ref readonly global::System.Guid IID
        {
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            get
            {
                global::System.ReadOnlySpan<byte> data = new byte[] { 0xE5, 0xC2, 0x32, 0x28, 0xCE, 0x2A, 0x93, 0x59, 0xA1, 0x73, 0x3C, 0x9C, 0x3B, 0x99, 0x2B, 0x2E };
                return ref global::System.Runtime.CompilerServices.Unsafe.As<byte, global::System.Guid>(ref global::System.Runtime.InteropServices.MemoryMarshal.GetReference(data));
            }
        }

    }
    [Guid("2832C2E5-2ACE-5993-A173-3C9C3B992B2E")]
    internal interface ICustomXamlResourceLoader : global::Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoader
    {
    }
    internal static class ICustomXamlResourceLoaderFactoryMethods
    {


        internal static unsafe global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader CreateInstance(IObjectReference _obj, object baseInterface, out object innerInterface)
        {
            var ThisPtr = _obj.ThisPtr;

            ObjectReferenceValue __baseInterface = default;
            IntPtr __innerInterface = default;
            IntPtr __retval = default;
            try
            {
                __baseInterface = MarshalInspectable<object>.CreateMarshaler2(baseInterface);
                global::WinRT.ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr*, IntPtr*, int>**)ThisPtr)[6](ThisPtr, MarshalInspectable<object>.GetAbi(__baseInterface), &__innerInterface, &__retval));
                global::System.GC.KeepAlive(_obj);
                innerInterface = MarshalInspectable<object>.FromAbi(__innerInterface);
                return global::ABI.Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader.FromAbi(__retval);
            }
            finally
            {
                MarshalInspectable<object>.DisposeMarshaler(__baseInterface);
                MarshalInspectable<object>.DisposeAbi(__innerInterface);
                global::ABI.Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader.DisposeAbi(__retval);
            }
        }


        public static ref readonly global::System.Guid IID
        {
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            get
            {
                global::System.ReadOnlySpan<byte> data = new byte[] { 0xA6, 0x49, 0x4D, 0x17, 0xE2, 0xE1, 0x7B, 0x5F, 0xA6, 0x18, 0xA8, 0xA9, 0x53, 0xD1, 0xB5, 0xA0 };
                return ref global::System.Runtime.CompilerServices.Unsafe.As<byte, global::System.Guid>(ref global::System.Runtime.InteropServices.MemoryMarshal.GetReference(data));
            }
        }

    }
    [Guid("174D49A6-E1E2-5F7B-A618-A8A953D1B5A0")]
    internal interface ICustomXamlResourceLoaderFactory : global::Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderFactory
    {
    }
    public static class ICustomXamlResourceLoaderOverridesMethods
    {


        internal static unsafe object GetResource(IObjectReference _obj, string resourceId, string objectType, string propertyName, string propertyType)
        {
            var ThisPtr = _obj.ThisPtr;

            IntPtr __retval = default;
            try
            {
                MarshalString.Pinnable __resourceId = new(resourceId);
                MarshalString.Pinnable __objectType = new(objectType);
                MarshalString.Pinnable __propertyName = new(propertyName);
                MarshalString.Pinnable __propertyType = new(propertyType);
                fixed(void* ___resourceId = __resourceId, ___objectType = __objectType, ___propertyName = __propertyName, ___propertyType = __propertyType)
                {
                    global::WinRT.ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr*, int>**)ThisPtr)[6](ThisPtr, MarshalString.GetAbi(ref __resourceId), MarshalString.GetAbi(ref __objectType), MarshalString.GetAbi(ref __propertyName), MarshalString.GetAbi(ref __propertyType), &__retval));
                    global::System.GC.KeepAlive(_obj);
                    return MarshalInspectable<object>.FromAbi(__retval);
                }
            }
            finally
            {
                MarshalInspectable<object>.DisposeAbi(__retval);
            }
        }


        public static ref readonly global::System.Guid IID
        {
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            get
            {
                global::System.ReadOnlySpan<byte> data = new byte[] { 0x4C, 0x50, 0xBB, 0x84, 0x30, 0x67, 0x6A, 0x58, 0xBD, 0x4, 0x91, 0x98, 0x26, 0x4B, 0x2D, 0xC7 };
                return ref global::System.Runtime.CompilerServices.Unsafe.As<byte, global::System.Guid>(ref global::System.Runtime.InteropServices.MemoryMarshal.GetReference(data));
            }
        }

        public static global::System.IntPtr AbiToProjectionVftablePtr => ICustomXamlResourceLoaderOverrides.AbiToProjectionVftablePtr;

    }

    [Guid("84BB504C-6730-586A-BD04-9198264B2DC7")]
    internal unsafe interface ICustomXamlResourceLoaderOverrides : global::Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderOverrides
    {

        public static readonly IntPtr AbiToProjectionVftablePtr;
        static unsafe ICustomXamlResourceLoaderOverrides()
        {
            AbiToProjectionVftablePtr = ComWrappersSupport.AllocateVtableMemory(typeof(ICustomXamlResourceLoaderOverrides), sizeof(IInspectable.Vftbl) + sizeof(IntPtr) * 1);
            *(IInspectable.Vftbl*)AbiToProjectionVftablePtr = IInspectable.Vftbl.AbiToProjectionVftable;
            ((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr*, int>*)AbiToProjectionVftablePtr)[6] = &Do_Abi_GetResource_0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
        private static unsafe int Do_Abi_GetResource_0(IntPtr thisPtr, IntPtr resourceId, IntPtr objectType, IntPtr propertyName, IntPtr propertyType, IntPtr* result)
        {

            object __result = default;

            *result = default;

            try
            {
                __result = global::WinRT.ComWrappersSupport.FindObject<global::Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderOverrides>(thisPtr).GetResource(MarshalString.FromAbi(resourceId), MarshalString.FromAbi(objectType), MarshalString.FromAbi(propertyName), MarshalString.FromAbi(propertyType));
                *result = MarshalInspectable<object>.FromManaged(__result);

            }
            catch (Exception __exception__)
            {
                global::WinRT.ExceptionHelpers.SetErrorInfo(__exception__);
                return global::WinRT.ExceptionHelpers.GetHRForException(__exception__);
            }
            return 0;
        }
    }

    internal static class ICustomXamlResourceLoaderStaticsMethods
    {

        internal static unsafe global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader get_Current(IObjectReference _obj)
        {
            var ThisPtr = _obj.ThisPtr;

            IntPtr __retval = default;
            try
            {
                global::WinRT.ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>**)ThisPtr)[6](ThisPtr, &__retval));
                global::System.GC.KeepAlive(_obj);
                return global::ABI.Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader.FromAbi(__retval);
            }
            finally
            {
                global::ABI.Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader.DisposeAbi(__retval);
            }
        }
        internal static unsafe void set_Current(IObjectReference _obj, global::Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader value)
        {
            var ThisPtr = _obj.ThisPtr;

            ObjectReferenceValue __value = default;
            try
            {
                __value = global::ABI.Microsoft.UI.Xaml.Resources.CustomXamlResourceLoader.CreateMarshaler2(value);
                global::WinRT.ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>**)ThisPtr)[7](ThisPtr, MarshalInspectable<object>.GetAbi(__value)));
                global::System.GC.KeepAlive(_obj);
            }
            finally
            {
                MarshalInspectable<object>.DisposeMarshaler(__value);
            }
        }



        public static ref readonly global::System.Guid IID
        {
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            get
            {
                global::System.ReadOnlySpan<byte> data = new byte[] { 0x92, 0x5A, 0x8A, 0xE0, 0xA2, 0xB1, 0x9A, 0x53, 0x9D, 0x4A, 0x79, 0x94, 0xE4, 0x46, 0x8C, 0xD7 };
                return ref global::System.Runtime.CompilerServices.Unsafe.As<byte, global::System.Guid>(ref global::System.Runtime.InteropServices.MemoryMarshal.GetReference(data));
            }
        }

    }
    [Guid("E08A5A92-B1A2-539A-9D4A-7994E4468CD7")]
    internal interface ICustomXamlResourceLoaderStatics : global::Microsoft.UI.Xaml.Resources.ICustomXamlResourceLoaderStatics
    {
    }
}
#pragma warning restore CA1416
