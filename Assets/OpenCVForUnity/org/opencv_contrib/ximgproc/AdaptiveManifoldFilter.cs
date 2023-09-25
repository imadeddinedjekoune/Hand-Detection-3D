
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class AdaptiveManifoldFilter
    //javadoc: AdaptiveManifoldFilter

    public class AdaptiveManifoldFilter : Algorithm
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
                        ximgproc_AdaptiveManifoldFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal AdaptiveManifoldFilter(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new AdaptiveManifoldFilter __fromPtr__(IntPtr addr) { return new AdaptiveManifoldFilter(addr); }

        //
        // C++: static Ptr_AdaptiveManifoldFilter cv::ximgproc::AdaptiveManifoldFilter::create()
        //

        //javadoc: AdaptiveManifoldFilter::create()
        public static AdaptiveManifoldFilter create()
        {
#if UNITY_5_3_OR_NEWER
        
        AdaptiveManifoldFilter retVal = AdaptiveManifoldFilter.__fromPtr__(ximgproc_AdaptiveManifoldFilter_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::ximgproc::AdaptiveManifoldFilter::collectGarbage()
        //

        //javadoc: AdaptiveManifoldFilter::collectGarbage()
        public void collectGarbage()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_AdaptiveManifoldFilter_collectGarbage_10(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::AdaptiveManifoldFilter::filter(Mat src, Mat& dst, Mat joint = Mat())
        //

        //javadoc: AdaptiveManifoldFilter::filter(src, dst, joint)
        public void filter(Mat src, Mat dst, Mat joint)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (joint != null) joint.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_AdaptiveManifoldFilter_filter_10(nativeObj, src.nativeObj, dst.nativeObj, joint.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: AdaptiveManifoldFilter::filter(src, dst)
        public void filter(Mat src, Mat dst)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_AdaptiveManifoldFilter_filter_11(nativeObj, src.nativeObj, dst.nativeObj);
        
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



        // C++: static Ptr_AdaptiveManifoldFilter cv::ximgproc::AdaptiveManifoldFilter::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_AdaptiveManifoldFilter_create_10();

        // C++:  void cv::ximgproc::AdaptiveManifoldFilter::collectGarbage()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_AdaptiveManifoldFilter_collectGarbage_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::AdaptiveManifoldFilter::filter(Mat src, Mat& dst, Mat joint = Mat())
        [DllImport(LIBNAME)]
        private static extern void ximgproc_AdaptiveManifoldFilter_filter_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr joint_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_AdaptiveManifoldFilter_filter_11(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_AdaptiveManifoldFilter_delete(IntPtr nativeObj);

    }
}
