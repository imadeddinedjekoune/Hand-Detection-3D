
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class CalibrateCRF
    //javadoc: CalibrateCRF

    public class CalibrateCRF : Algorithm
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
                        photo_CalibrateCRF_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal CalibrateCRF(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new CalibrateCRF __fromPtr__(IntPtr addr) { return new CalibrateCRF(addr); }

        //
        // C++:  void cv::CalibrateCRF::process(vector_Mat src, Mat& dst, Mat times)
        //

        //javadoc: CalibrateCRF::process(src, dst, times)
        public void process(List<Mat> src, Mat dst, Mat times)
        {
            ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (times != null) times.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat src_mat = Converters.vector_Mat_to_Mat(src);
        photo_CalibrateCRF_process_10(nativeObj, src_mat.nativeObj, dst.nativeObj, times.nativeObj);
        
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



        // C++:  void cv::CalibrateCRF::process(vector_Mat src, Mat& dst, Mat times)
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateCRF_process_10(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_nativeObj, IntPtr times_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateCRF_delete(IntPtr nativeObj);

    }
}
