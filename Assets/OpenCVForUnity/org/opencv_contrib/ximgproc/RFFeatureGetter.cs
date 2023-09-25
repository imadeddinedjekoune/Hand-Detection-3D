
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class RFFeatureGetter
    //javadoc: RFFeatureGetter

    public class RFFeatureGetter : Algorithm
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
                        ximgproc_RFFeatureGetter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal RFFeatureGetter(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new RFFeatureGetter __fromPtr__(IntPtr addr) { return new RFFeatureGetter(addr); }

        //
        // C++:  void cv::ximgproc::RFFeatureGetter::getFeatures(Mat src, Mat features, int gnrmRad, int gsmthRad, int shrink, int outNum, int gradNum)
        //

        //javadoc: RFFeatureGetter::getFeatures(src, features, gnrmRad, gsmthRad, shrink, outNum, gradNum)
        public void getFeatures(Mat src, Mat features, int gnrmRad, int gsmthRad, int shrink, int outNum, int gradNum)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (features != null) features.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_RFFeatureGetter_getFeatures_10(nativeObj, src.nativeObj, features.nativeObj, gnrmRad, gsmthRad, shrink, outNum, gradNum);
        
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



        // C++:  void cv::ximgproc::RFFeatureGetter::getFeatures(Mat src, Mat features, int gnrmRad, int gsmthRad, int shrink, int outNum, int gradNum)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RFFeatureGetter_getFeatures_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr features_nativeObj, int gnrmRad, int gsmthRad, int shrink, int outNum, int gradNum);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RFFeatureGetter_delete(IntPtr nativeObj);

    }
}
