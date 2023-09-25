
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class Tonemap
    //javadoc: Tonemap

    public class Tonemap : Algorithm
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
                        photo_Tonemap_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Tonemap(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new Tonemap __fromPtr__(IntPtr addr) { return new Tonemap(addr); }

        //
        // C++:  float cv::Tonemap::getGamma()
        //

        //javadoc: Tonemap::getGamma()
        public float getGamma()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = photo_Tonemap_getGamma_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::Tonemap::process(Mat src, Mat& dst)
        //

        //javadoc: Tonemap::process(src, dst)
        public void process(Mat src, Mat dst)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Tonemap_process_10(nativeObj, src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::Tonemap::setGamma(float gamma)
        //

        //javadoc: Tonemap::setGamma(gamma)
        public void setGamma(float gamma)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Tonemap_setGamma_10(nativeObj, gamma);
        
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



        // C++:  float cv::Tonemap::getGamma()
        [DllImport(LIBNAME)]
        private static extern float photo_Tonemap_getGamma_10(IntPtr nativeObj);

        // C++:  void cv::Tonemap::process(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void photo_Tonemap_process_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::Tonemap::setGamma(float gamma)
        [DllImport(LIBNAME)]
        private static extern void photo_Tonemap_setGamma_10(IntPtr nativeObj, float gamma);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_Tonemap_delete(IntPtr nativeObj);

    }
}
