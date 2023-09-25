
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XphotoModule
{

    // C++: class WhiteBalancer
    //javadoc: WhiteBalancer

    public class WhiteBalancer : Algorithm
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
                        xphoto_WhiteBalancer_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal WhiteBalancer(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new WhiteBalancer __fromPtr__(IntPtr addr) { return new WhiteBalancer(addr); }

        //
        // C++:  void cv::xphoto::WhiteBalancer::balanceWhite(Mat src, Mat& dst)
        //

        //javadoc: WhiteBalancer::balanceWhite(src, dst)
        public void balanceWhite(Mat src, Mat dst)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_WhiteBalancer_balanceWhite_10(nativeObj, src.nativeObj, dst.nativeObj);
        
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



        // C++:  void cv::xphoto::WhiteBalancer::balanceWhite(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void xphoto_WhiteBalancer_balanceWhite_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xphoto_WhiteBalancer_delete(IntPtr nativeObj);

    }
}
