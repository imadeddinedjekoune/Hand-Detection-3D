
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class FastBilateralSolverFilter
    //javadoc: FastBilateralSolverFilter

    public class FastBilateralSolverFilter : Algorithm
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
                        ximgproc_FastBilateralSolverFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FastBilateralSolverFilter(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FastBilateralSolverFilter __fromPtr__(IntPtr addr) { return new FastBilateralSolverFilter(addr); }

        //
        // C++:  void cv::ximgproc::FastBilateralSolverFilter::filter(Mat src, Mat confidence, Mat& dst)
        //

        //javadoc: FastBilateralSolverFilter::filter(src, confidence, dst)
        public void filter(Mat src, Mat confidence, Mat dst)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_FastBilateralSolverFilter_filter_10(nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj);
        
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



        // C++:  void cv::ximgproc::FastBilateralSolverFilter::filter(Mat src, Mat confidence, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_FastBilateralSolverFilter_filter_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_FastBilateralSolverFilter_delete(IntPtr nativeObj);

    }
}
