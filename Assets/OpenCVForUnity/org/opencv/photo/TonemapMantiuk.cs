
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class TonemapMantiuk
    //javadoc: TonemapMantiuk

    public class TonemapMantiuk : Tonemap
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
                        photo_TonemapMantiuk_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TonemapMantiuk(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TonemapMantiuk __fromPtr__(IntPtr addr) { return new TonemapMantiuk(addr); }

        //
        // C++:  float cv::TonemapMantiuk::getSaturation()
        //

        //javadoc: TonemapMantiuk::getSaturation()
        public float getSaturation()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapMantiuk_getSaturation_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::TonemapMantiuk::getScale()
        //

        //javadoc: TonemapMantiuk::getScale()
        public float getScale()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapMantiuk_getScale_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::TonemapMantiuk::setSaturation(float saturation)
        //

        //javadoc: TonemapMantiuk::setSaturation(saturation)
        public void setSaturation(float saturation)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_TonemapMantiuk_setSaturation_10(nativeObj, saturation);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::TonemapMantiuk::setScale(float scale)
        //

        //javadoc: TonemapMantiuk::setScale(scale)
        public void setScale(float scale)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_TonemapMantiuk_setScale_10(nativeObj, scale);
        
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



        // C++:  float cv::TonemapMantiuk::getSaturation()
        [DllImport(LIBNAME)]
        private static extern float photo_TonemapMantiuk_getSaturation_10(IntPtr nativeObj);

        // C++:  float cv::TonemapMantiuk::getScale()
        [DllImport(LIBNAME)]
        private static extern float photo_TonemapMantiuk_getScale_10(IntPtr nativeObj);

        // C++:  void cv::TonemapMantiuk::setSaturation(float saturation)
        [DllImport(LIBNAME)]
        private static extern void photo_TonemapMantiuk_setSaturation_10(IntPtr nativeObj, float saturation);

        // C++:  void cv::TonemapMantiuk::setScale(float scale)
        [DllImport(LIBNAME)]
        private static extern void photo_TonemapMantiuk_setScale_10(IntPtr nativeObj, float scale);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_TonemapMantiuk_delete(IntPtr nativeObj);

    }
}
