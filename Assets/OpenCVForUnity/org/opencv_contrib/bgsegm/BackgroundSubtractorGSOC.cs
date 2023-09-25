
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using OpenCVForUnity.VideoModule;

namespace OpenCVForUnity.BgsegmModule
{

    // C++: class BackgroundSubtractorGSOC
    //javadoc: BackgroundSubtractorGSOC

    public class BackgroundSubtractorGSOC : BackgroundSubtractor
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
                        bgsegm_BackgroundSubtractorGSOC_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BackgroundSubtractorGSOC(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BackgroundSubtractorGSOC __fromPtr__(IntPtr addr) { return new BackgroundSubtractorGSOC(addr); }

        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGSOC::apply(Mat image, Mat& fgmask, double learningRate = -1)
        //

        //javadoc: BackgroundSubtractorGSOC::apply(image, fgmask, learningRate)
        public override void apply(Mat image, Mat fgmask, double learningRate)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorGSOC_apply_10(nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);
        
        return;
#else
            return;
#endif
        }

        //javadoc: BackgroundSubtractorGSOC::apply(image, fgmask)
        public override void apply(Mat image, Mat fgmask)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorGSOC_apply_11(nativeObj, image.nativeObj, fgmask.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGSOC::getBackgroundImage(Mat& backgroundImage)
        //

        //javadoc: BackgroundSubtractorGSOC::getBackgroundImage(backgroundImage)
        public override void getBackgroundImage(Mat backgroundImage)
        {
            ThrowIfDisposed();
            if (backgroundImage != null) backgroundImage.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorGSOC_getBackgroundImage_10(nativeObj, backgroundImage.nativeObj);
        
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



        // C++:  void cv::bgsegm::BackgroundSubtractorGSOC::apply(Mat image, Mat& fgmask, double learningRate = -1)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGSOC_apply_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGSOC_apply_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorGSOC::getBackgroundImage(Mat& backgroundImage)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGSOC_getBackgroundImage_10(IntPtr nativeObj, IntPtr backgroundImage_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGSOC_delete(IntPtr nativeObj);

    }
}
