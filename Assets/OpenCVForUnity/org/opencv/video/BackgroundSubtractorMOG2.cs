
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class BackgroundSubtractorMOG2
    //javadoc: BackgroundSubtractorMOG2

    public class BackgroundSubtractorMOG2 : BackgroundSubtractor
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
                        video_BackgroundSubtractorMOG2_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BackgroundSubtractorMOG2(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BackgroundSubtractorMOG2 __fromPtr__(IntPtr addr) { return new BackgroundSubtractorMOG2(addr); }

        //
        // C++:  bool cv::BackgroundSubtractorMOG2::getDetectShadows()
        //

        //javadoc: BackgroundSubtractorMOG2::getDetectShadows()
        public bool getDetectShadows()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = video_BackgroundSubtractorMOG2_getDetectShadows_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getBackgroundRatio()
        //

        //javadoc: BackgroundSubtractorMOG2::getBackgroundRatio()
        public double getBackgroundRatio()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = video_BackgroundSubtractorMOG2_getBackgroundRatio_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getComplexityReductionThreshold()
        //

        //javadoc: BackgroundSubtractorMOG2::getComplexityReductionThreshold()
        public double getComplexityReductionThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = video_BackgroundSubtractorMOG2_getComplexityReductionThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getShadowThreshold()
        //

        //javadoc: BackgroundSubtractorMOG2::getShadowThreshold()
        public double getShadowThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = video_BackgroundSubtractorMOG2_getShadowThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getVarInit()
        //

        //javadoc: BackgroundSubtractorMOG2::getVarInit()
        public double getVarInit()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = video_BackgroundSubtractorMOG2_getVarInit_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getVarMax()
        //

        //javadoc: BackgroundSubtractorMOG2::getVarMax()
        public double getVarMax()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = video_BackgroundSubtractorMOG2_getVarMax_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getVarMin()
        //

        //javadoc: BackgroundSubtractorMOG2::getVarMin()
        public double getVarMin()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = video_BackgroundSubtractorMOG2_getVarMin_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getVarThreshold()
        //

        //javadoc: BackgroundSubtractorMOG2::getVarThreshold()
        public double getVarThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = video_BackgroundSubtractorMOG2_getVarThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getVarThresholdGen()
        //

        //javadoc: BackgroundSubtractorMOG2::getVarThresholdGen()
        public double getVarThresholdGen()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = video_BackgroundSubtractorMOG2_getVarThresholdGen_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::BackgroundSubtractorMOG2::getHistory()
        //

        //javadoc: BackgroundSubtractorMOG2::getHistory()
        public int getHistory()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_BackgroundSubtractorMOG2_getHistory_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::BackgroundSubtractorMOG2::getNMixtures()
        //

        //javadoc: BackgroundSubtractorMOG2::getNMixtures()
        public int getNMixtures()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_BackgroundSubtractorMOG2_getNMixtures_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::BackgroundSubtractorMOG2::getShadowValue()
        //

        //javadoc: BackgroundSubtractorMOG2::getShadowValue()
        public int getShadowValue()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_BackgroundSubtractorMOG2_getShadowValue_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::apply(Mat image, Mat& fgmask, double learningRate = -1)
        //

        //javadoc: BackgroundSubtractorMOG2::apply(image, fgmask, learningRate)
        public override void apply(Mat image, Mat fgmask, double learningRate)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_apply_10(nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);
        
        return;
#else
            return;
#endif
        }

        //javadoc: BackgroundSubtractorMOG2::apply(image, fgmask)
        public override void apply(Mat image, Mat fgmask)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_apply_11(nativeObj, image.nativeObj, fgmask.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setBackgroundRatio(double ratio)
        //

        //javadoc: BackgroundSubtractorMOG2::setBackgroundRatio(ratio)
        public void setBackgroundRatio(double ratio)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_setBackgroundRatio_10(nativeObj, ratio);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setComplexityReductionThreshold(double ct)
        //

        //javadoc: BackgroundSubtractorMOG2::setComplexityReductionThreshold(ct)
        public void setComplexityReductionThreshold(double ct)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_setComplexityReductionThreshold_10(nativeObj, ct);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setDetectShadows(bool detectShadows)
        //

        //javadoc: BackgroundSubtractorMOG2::setDetectShadows(detectShadows)
        public void setDetectShadows(bool detectShadows)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_setDetectShadows_10(nativeObj, detectShadows);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setHistory(int history)
        //

        //javadoc: BackgroundSubtractorMOG2::setHistory(history)
        public void setHistory(int history)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_setHistory_10(nativeObj, history);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setNMixtures(int nmixtures)
        //

        //javadoc: BackgroundSubtractorMOG2::setNMixtures(nmixtures)
        public void setNMixtures(int nmixtures)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_setNMixtures_10(nativeObj, nmixtures);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setShadowThreshold(double threshold)
        //

        //javadoc: BackgroundSubtractorMOG2::setShadowThreshold(threshold)
        public void setShadowThreshold(double threshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_setShadowThreshold_10(nativeObj, threshold);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setShadowValue(int value)
        //

        //javadoc: BackgroundSubtractorMOG2::setShadowValue(value)
        public void setShadowValue(int value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_setShadowValue_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setVarInit(double varInit)
        //

        //javadoc: BackgroundSubtractorMOG2::setVarInit(varInit)
        public void setVarInit(double varInit)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_setVarInit_10(nativeObj, varInit);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setVarMax(double varMax)
        //

        //javadoc: BackgroundSubtractorMOG2::setVarMax(varMax)
        public void setVarMax(double varMax)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_setVarMax_10(nativeObj, varMax);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setVarMin(double varMin)
        //

        //javadoc: BackgroundSubtractorMOG2::setVarMin(varMin)
        public void setVarMin(double varMin)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_setVarMin_10(nativeObj, varMin);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setVarThreshold(double varThreshold)
        //

        //javadoc: BackgroundSubtractorMOG2::setVarThreshold(varThreshold)
        public void setVarThreshold(double varThreshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_setVarThreshold_10(nativeObj, varThreshold);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setVarThresholdGen(double varThresholdGen)
        //

        //javadoc: BackgroundSubtractorMOG2::setVarThresholdGen(varThresholdGen)
        public void setVarThresholdGen(double varThresholdGen)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorMOG2_setVarThresholdGen_10(nativeObj, varThresholdGen);
        
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



        // C++:  bool cv::BackgroundSubtractorMOG2::getDetectShadows()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool video_BackgroundSubtractorMOG2_getDetectShadows_10(IntPtr nativeObj);

        // C++:  double cv::BackgroundSubtractorMOG2::getBackgroundRatio()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getBackgroundRatio_10(IntPtr nativeObj);

        // C++:  double cv::BackgroundSubtractorMOG2::getComplexityReductionThreshold()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getComplexityReductionThreshold_10(IntPtr nativeObj);

        // C++:  double cv::BackgroundSubtractorMOG2::getShadowThreshold()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getShadowThreshold_10(IntPtr nativeObj);

        // C++:  double cv::BackgroundSubtractorMOG2::getVarInit()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarInit_10(IntPtr nativeObj);

        // C++:  double cv::BackgroundSubtractorMOG2::getVarMax()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarMax_10(IntPtr nativeObj);

        // C++:  double cv::BackgroundSubtractorMOG2::getVarMin()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarMin_10(IntPtr nativeObj);

        // C++:  double cv::BackgroundSubtractorMOG2::getVarThreshold()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarThreshold_10(IntPtr nativeObj);

        // C++:  double cv::BackgroundSubtractorMOG2::getVarThresholdGen()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarThresholdGen_10(IntPtr nativeObj);

        // C++:  int cv::BackgroundSubtractorMOG2::getHistory()
        [DllImport(LIBNAME)]
        private static extern int video_BackgroundSubtractorMOG2_getHistory_10(IntPtr nativeObj);

        // C++:  int cv::BackgroundSubtractorMOG2::getNMixtures()
        [DllImport(LIBNAME)]
        private static extern int video_BackgroundSubtractorMOG2_getNMixtures_10(IntPtr nativeObj);

        // C++:  int cv::BackgroundSubtractorMOG2::getShadowValue()
        [DllImport(LIBNAME)]
        private static extern int video_BackgroundSubtractorMOG2_getShadowValue_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::apply(Mat image, Mat& fgmask, double learningRate = -1)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_apply_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_apply_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::setBackgroundRatio(double ratio)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setBackgroundRatio_10(IntPtr nativeObj, double ratio);

        // C++:  void cv::BackgroundSubtractorMOG2::setComplexityReductionThreshold(double ct)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setComplexityReductionThreshold_10(IntPtr nativeObj, double ct);

        // C++:  void cv::BackgroundSubtractorMOG2::setDetectShadows(bool detectShadows)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setDetectShadows_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool detectShadows);

        // C++:  void cv::BackgroundSubtractorMOG2::setHistory(int history)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setHistory_10(IntPtr nativeObj, int history);

        // C++:  void cv::BackgroundSubtractorMOG2::setNMixtures(int nmixtures)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setNMixtures_10(IntPtr nativeObj, int nmixtures);

        // C++:  void cv::BackgroundSubtractorMOG2::setShadowThreshold(double threshold)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setShadowThreshold_10(IntPtr nativeObj, double threshold);

        // C++:  void cv::BackgroundSubtractorMOG2::setShadowValue(int value)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setShadowValue_10(IntPtr nativeObj, int value);

        // C++:  void cv::BackgroundSubtractorMOG2::setVarInit(double varInit)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarInit_10(IntPtr nativeObj, double varInit);

        // C++:  void cv::BackgroundSubtractorMOG2::setVarMax(double varMax)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarMax_10(IntPtr nativeObj, double varMax);

        // C++:  void cv::BackgroundSubtractorMOG2::setVarMin(double varMin)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarMin_10(IntPtr nativeObj, double varMin);

        // C++:  void cv::BackgroundSubtractorMOG2::setVarThreshold(double varThreshold)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarThreshold_10(IntPtr nativeObj, double varThreshold);

        // C++:  void cv::BackgroundSubtractorMOG2::setVarThresholdGen(double varThresholdGen)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarThresholdGen_10(IntPtr nativeObj, double varThresholdGen);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_delete(IntPtr nativeObj);

    }
}
