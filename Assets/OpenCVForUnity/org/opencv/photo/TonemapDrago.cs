
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class TonemapDrago
    //javadoc: TonemapDrago

    public class TonemapDrago : Tonemap
    {

        protected override void Dispose(bool disposing)
        {

            try
            {
                if (disposing)
                {
                }
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        photo_TonemapDrago_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TonemapDrago(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TonemapDrago __fromPtr__(IntPtr addr) { return new TonemapDrago(addr); }

        //
        // C++:  float cv::TonemapDrago::getBias()
        //

        //javadoc: TonemapDrago::getBias()
        public float getBias()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapDrago_getBias_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::TonemapDrago::getSaturation()
        //

        //javadoc: TonemapDrago::getSaturation()
        public float getSaturation()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapDrago_getSaturation_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::TonemapDrago::setBias(float bias)
        //

        //javadoc: TonemapDrago::setBias(bias)
        public void setBias(float bias)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_TonemapDrago_setBias_10(nativeObj, bias);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::TonemapDrago::setSaturation(float saturation)
        //

        //javadoc: TonemapDrago::setSaturation(saturation)
        public void setSaturation(float saturation)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_TonemapDrago_setSaturation_10(nativeObj, saturation);
        
        return;
#else
            return;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  float cv::TonemapDrago::getBias()
        [DllImport(LIBNAME)]
        private static extern float photo_TonemapDrago_getBias_10(IntPtr nativeObj);

        // C++:  float cv::TonemapDrago::getSaturation()
        [DllImport(LIBNAME)]
        private static extern float photo_TonemapDrago_getSaturation_10(IntPtr nativeObj);

        // C++:  void cv::TonemapDrago::setBias(float bias)
        [DllImport(LIBNAME)]
        private static extern void photo_TonemapDrago_setBias_10(IntPtr nativeObj, float bias);

        // C++:  void cv::TonemapDrago::setSaturation(float saturation)
        [DllImport(LIBNAME)]
        private static extern void photo_TonemapDrago_setSaturation_10(IntPtr nativeObj, float saturation);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_TonemapDrago_delete(IntPtr nativeObj);

    }
}
