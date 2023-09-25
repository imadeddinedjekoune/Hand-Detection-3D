
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class DTFilter
    //javadoc: DTFilter

    public class DTFilter : Algorithm
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
                        ximgproc_DTFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DTFilter(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DTFilter __fromPtr__(IntPtr addr) { return new DTFilter(addr); }

        //
        // C++:  void cv::ximgproc::DTFilter::filter(Mat src, Mat& dst, int dDepth = -1)
        //

        //javadoc: DTFilter::filter(src, dst, dDepth)
        public void filter(Mat src, Mat dst, int dDepth)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_DTFilter_filter_10(nativeObj, src.nativeObj, dst.nativeObj, dDepth);
        
        return;
#else
            return;
#endif
        }

        //javadoc: DTFilter::filter(src, dst)
        public void filter(Mat src, Mat dst)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_DTFilter_filter_11(nativeObj, src.nativeObj, dst.nativeObj);
        
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



        // C++:  void cv::ximgproc::DTFilter::filter(Mat src, Mat& dst, int dDepth = -1)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DTFilter_filter_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int dDepth);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DTFilter_filter_11(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DTFilter_delete(IntPtr nativeObj);

    }
}
