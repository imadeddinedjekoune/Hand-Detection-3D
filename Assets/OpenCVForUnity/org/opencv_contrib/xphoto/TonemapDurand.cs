
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using OpenCVForUnity.PhotoModule;

namespace OpenCVForUnity.XphotoModule
{

    // C++: class TonemapDurand
    //javadoc: TonemapDurand

    public class TonemapDurand : Tonemap
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
                        xphoto_TonemapDurand_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TonemapDurand(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TonemapDurand __fromPtr__(IntPtr addr) { return new TonemapDurand(addr); }

        //
        // C++:  float cv::xphoto::TonemapDurand::getContrast()
        //

        //javadoc: TonemapDurand::getContrast()
        public float getContrast()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_TonemapDurand_getContrast_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xphoto::TonemapDurand::getSaturation()
        //

        //javadoc: TonemapDurand::getSaturation()
        public float getSaturation()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_TonemapDurand_getSaturation_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xphoto::TonemapDurand::getSigmaColor()
        //

        //javadoc: TonemapDurand::getSigmaColor()
        public float getSigmaColor()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_TonemapDurand_getSigmaColor_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xphoto::TonemapDurand::getSigmaSpace()
        //

        //javadoc: TonemapDurand::getSigmaSpace()
        public float getSigmaSpace()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_TonemapDurand_getSigmaSpace_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::xphoto::TonemapDurand::setContrast(float contrast)
        //

        //javadoc: TonemapDurand::setContrast(contrast)
        public void setContrast(float contrast)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_TonemapDurand_setContrast_10(nativeObj, contrast);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xphoto::TonemapDurand::setSaturation(float saturation)
        //

        //javadoc: TonemapDurand::setSaturation(saturation)
        public void setSaturation(float saturation)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_TonemapDurand_setSaturation_10(nativeObj, saturation);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xphoto::TonemapDurand::setSigmaColor(float sigma_color)
        //

        //javadoc: TonemapDurand::setSigmaColor(sigma_color)
        public void setSigmaColor(float sigma_color)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_TonemapDurand_setSigmaColor_10(nativeObj, sigma_color);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xphoto::TonemapDurand::setSigmaSpace(float sigma_space)
        //

        //javadoc: TonemapDurand::setSigmaSpace(sigma_space)
        public void setSigmaSpace(float sigma_space)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_TonemapDurand_setSigmaSpace_10(nativeObj, sigma_space);
        
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



        // C++:  float cv::xphoto::TonemapDurand::getContrast()
        [DllImport(LIBNAME)]
        private static extern float xphoto_TonemapDurand_getContrast_10(IntPtr nativeObj);

        // C++:  float cv::xphoto::TonemapDurand::getSaturation()
        [DllImport(LIBNAME)]
        private static extern float xphoto_TonemapDurand_getSaturation_10(IntPtr nativeObj);

        // C++:  float cv::xphoto::TonemapDurand::getSigmaColor()
        [DllImport(LIBNAME)]
        private static extern float xphoto_TonemapDurand_getSigmaColor_10(IntPtr nativeObj);

        // C++:  float cv::xphoto::TonemapDurand::getSigmaSpace()
        [DllImport(LIBNAME)]
        private static extern float xphoto_TonemapDurand_getSigmaSpace_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::TonemapDurand::setContrast(float contrast)
        [DllImport(LIBNAME)]
        private static extern void xphoto_TonemapDurand_setContrast_10(IntPtr nativeObj, float contrast);

        // C++:  void cv::xphoto::TonemapDurand::setSaturation(float saturation)
        [DllImport(LIBNAME)]
        private static extern void xphoto_TonemapDurand_setSaturation_10(IntPtr nativeObj, float saturation);

        // C++:  void cv::xphoto::TonemapDurand::setSigmaColor(float sigma_color)
        [DllImport(LIBNAME)]
        private static extern void xphoto_TonemapDurand_setSigmaColor_10(IntPtr nativeObj, float sigma_color);

        // C++:  void cv::xphoto::TonemapDurand::setSigmaSpace(float sigma_space)
        [DllImport(LIBNAME)]
        private static extern void xphoto_TonemapDurand_setSigmaSpace_10(IntPtr nativeObj, float sigma_space);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xphoto_TonemapDurand_delete(IntPtr nativeObj);

    }
}
