
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using OpenCVForUnity.VideoModule;

namespace OpenCVForUnity.BgsegmModule
{

    // C++: class BackgroundSubtractorCNT
    //javadoc: BackgroundSubtractorCNT

    public class BackgroundSubtractorCNT : BackgroundSubtractor
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
                        bgsegm_BackgroundSubtractorCNT_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BackgroundSubtractorCNT(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BackgroundSubtractorCNT __fromPtr__(IntPtr addr) { return new BackgroundSubtractorCNT(addr); }

        //
        // C++:  bool cv::bgsegm::BackgroundSubtractorCNT::getIsParallel()
        //

        //javadoc: BackgroundSubtractorCNT::getIsParallel()
        public bool getIsParallel()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = bgsegm_BackgroundSubtractorCNT_getIsParallel_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::bgsegm::BackgroundSubtractorCNT::getUseHistory()
        //

        //javadoc: BackgroundSubtractorCNT::getUseHistory()
        public bool getUseHistory()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = bgsegm_BackgroundSubtractorCNT_getUseHistory_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorCNT::getMaxPixelStability()
        //

        //javadoc: BackgroundSubtractorCNT::getMaxPixelStability()
        public int getMaxPixelStability()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = bgsegm_BackgroundSubtractorCNT_getMaxPixelStability_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorCNT::getMinPixelStability()
        //

        //javadoc: BackgroundSubtractorCNT::getMinPixelStability()
        public int getMinPixelStability()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = bgsegm_BackgroundSubtractorCNT_getMinPixelStability_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::apply(Mat image, Mat& fgmask, double learningRate = -1)
        //

        //javadoc: BackgroundSubtractorCNT::apply(image, fgmask, learningRate)
        public override void apply(Mat image, Mat fgmask, double learningRate)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorCNT_apply_10(nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);
        
        return;
#else
            return;
#endif
        }

        //javadoc: BackgroundSubtractorCNT::apply(image, fgmask)
        public override void apply(Mat image, Mat fgmask)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorCNT_apply_11(nativeObj, image.nativeObj, fgmask.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::getBackgroundImage(Mat& backgroundImage)
        //

        //javadoc: BackgroundSubtractorCNT::getBackgroundImage(backgroundImage)
        public override void getBackgroundImage(Mat backgroundImage)
        {
            ThrowIfDisposed();
            if (backgroundImage != null) backgroundImage.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorCNT_getBackgroundImage_10(nativeObj, backgroundImage.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setIsParallel(bool value)
        //

        //javadoc: BackgroundSubtractorCNT::setIsParallel(value)
        public void setIsParallel(bool value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorCNT_setIsParallel_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setMaxPixelStability(int value)
        //

        //javadoc: BackgroundSubtractorCNT::setMaxPixelStability(value)
        public void setMaxPixelStability(int value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorCNT_setMaxPixelStability_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setMinPixelStability(int value)
        //

        //javadoc: BackgroundSubtractorCNT::setMinPixelStability(value)
        public void setMinPixelStability(int value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorCNT_setMinPixelStability_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setUseHistory(bool value)
        //

        //javadoc: BackgroundSubtractorCNT::setUseHistory(value)
        public void setUseHistory(bool value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorCNT_setUseHistory_10(nativeObj, value);
        
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



        // C++:  bool cv::bgsegm::BackgroundSubtractorCNT::getIsParallel()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool bgsegm_BackgroundSubtractorCNT_getIsParallel_10(IntPtr nativeObj);

        // C++:  bool cv::bgsegm::BackgroundSubtractorCNT::getUseHistory()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool bgsegm_BackgroundSubtractorCNT_getUseHistory_10(IntPtr nativeObj);

        // C++:  int cv::bgsegm::BackgroundSubtractorCNT::getMaxPixelStability()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorCNT_getMaxPixelStability_10(IntPtr nativeObj);

        // C++:  int cv::bgsegm::BackgroundSubtractorCNT::getMinPixelStability()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorCNT_getMinPixelStability_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::apply(Mat image, Mat& fgmask, double learningRate = -1)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_apply_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_apply_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::getBackgroundImage(Mat& backgroundImage)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_getBackgroundImage_10(IntPtr nativeObj, IntPtr backgroundImage_nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setIsParallel(bool value)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_setIsParallel_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool value);

        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setMaxPixelStability(int value)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_setMaxPixelStability_10(IntPtr nativeObj, int value);

        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setMinPixelStability(int value)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_setMinPixelStability_10(IntPtr nativeObj, int value);

        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setUseHistory(bool value)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_setUseHistory_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool value);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_delete(IntPtr nativeObj);

    }
}
