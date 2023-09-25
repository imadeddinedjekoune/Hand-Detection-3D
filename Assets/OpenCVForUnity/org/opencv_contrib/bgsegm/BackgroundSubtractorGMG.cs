
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using OpenCVForUnity.VideoModule;

namespace OpenCVForUnity.BgsegmModule
{

    // C++: class BackgroundSubtractorGMG
    //javadoc: BackgroundSubtractorGMG

    public class BackgroundSubtractorGMG : BackgroundSubtractor
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
                        bgsegm_BackgroundSubtractorGMG_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BackgroundSubtractorGMG(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BackgroundSubtractorGMG __fromPtr__(IntPtr addr) { return new BackgroundSubtractorGMG(addr); }

        //
        // C++:  bool cv::bgsegm::BackgroundSubtractorGMG::getUpdateBackgroundModel()
        //

        //javadoc: BackgroundSubtractorGMG::getUpdateBackgroundModel()
        public bool getUpdateBackgroundModel()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = bgsegm_BackgroundSubtractorGMG_getUpdateBackgroundModel_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getBackgroundPrior()
        //

        //javadoc: BackgroundSubtractorGMG::getBackgroundPrior()
        public double getBackgroundPrior()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = bgsegm_BackgroundSubtractorGMG_getBackgroundPrior_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getDecisionThreshold()
        //

        //javadoc: BackgroundSubtractorGMG::getDecisionThreshold()
        public double getDecisionThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = bgsegm_BackgroundSubtractorGMG_getDecisionThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getDefaultLearningRate()
        //

        //javadoc: BackgroundSubtractorGMG::getDefaultLearningRate()
        public double getDefaultLearningRate()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = bgsegm_BackgroundSubtractorGMG_getDefaultLearningRate_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getMaxVal()
        //

        //javadoc: BackgroundSubtractorGMG::getMaxVal()
        public double getMaxVal()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = bgsegm_BackgroundSubtractorGMG_getMaxVal_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getMinVal()
        //

        //javadoc: BackgroundSubtractorGMG::getMinVal()
        public double getMinVal()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = bgsegm_BackgroundSubtractorGMG_getMinVal_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getMaxFeatures()
        //

        //javadoc: BackgroundSubtractorGMG::getMaxFeatures()
        public int getMaxFeatures()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = bgsegm_BackgroundSubtractorGMG_getMaxFeatures_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getNumFrames()
        //

        //javadoc: BackgroundSubtractorGMG::getNumFrames()
        public int getNumFrames()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = bgsegm_BackgroundSubtractorGMG_getNumFrames_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getQuantizationLevels()
        //

        //javadoc: BackgroundSubtractorGMG::getQuantizationLevels()
        public int getQuantizationLevels()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = bgsegm_BackgroundSubtractorGMG_getQuantizationLevels_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getSmoothingRadius()
        //

        //javadoc: BackgroundSubtractorGMG::getSmoothingRadius()
        public int getSmoothingRadius()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = bgsegm_BackgroundSubtractorGMG_getSmoothingRadius_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setBackgroundPrior(double bgprior)
        //

        //javadoc: BackgroundSubtractorGMG::setBackgroundPrior(bgprior)
        public void setBackgroundPrior(double bgprior)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorGMG_setBackgroundPrior_10(nativeObj, bgprior);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setDecisionThreshold(double thresh)
        //

        //javadoc: BackgroundSubtractorGMG::setDecisionThreshold(thresh)
        public void setDecisionThreshold(double thresh)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorGMG_setDecisionThreshold_10(nativeObj, thresh);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setDefaultLearningRate(double lr)
        //

        //javadoc: BackgroundSubtractorGMG::setDefaultLearningRate(lr)
        public void setDefaultLearningRate(double lr)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorGMG_setDefaultLearningRate_10(nativeObj, lr);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setMaxFeatures(int maxFeatures)
        //

        //javadoc: BackgroundSubtractorGMG::setMaxFeatures(maxFeatures)
        public void setMaxFeatures(int maxFeatures)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorGMG_setMaxFeatures_10(nativeObj, maxFeatures);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setMaxVal(double val)
        //

        //javadoc: BackgroundSubtractorGMG::setMaxVal(val)
        public void setMaxVal(double val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorGMG_setMaxVal_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setMinVal(double val)
        //

        //javadoc: BackgroundSubtractorGMG::setMinVal(val)
        public void setMinVal(double val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorGMG_setMinVal_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setNumFrames(int nframes)
        //

        //javadoc: BackgroundSubtractorGMG::setNumFrames(nframes)
        public void setNumFrames(int nframes)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorGMG_setNumFrames_10(nativeObj, nframes);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setQuantizationLevels(int nlevels)
        //

        //javadoc: BackgroundSubtractorGMG::setQuantizationLevels(nlevels)
        public void setQuantizationLevels(int nlevels)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorGMG_setQuantizationLevels_10(nativeObj, nlevels);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setSmoothingRadius(int radius)
        //

        //javadoc: BackgroundSubtractorGMG::setSmoothingRadius(radius)
        public void setSmoothingRadius(int radius)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorGMG_setSmoothingRadius_10(nativeObj, radius);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setUpdateBackgroundModel(bool update)
        //

        //javadoc: BackgroundSubtractorGMG::setUpdateBackgroundModel(update)
        public void setUpdateBackgroundModel(bool update)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bgsegm_BackgroundSubtractorGMG_setUpdateBackgroundModel_10(nativeObj, update);
        
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



        // C++:  bool cv::bgsegm::BackgroundSubtractorGMG::getUpdateBackgroundModel()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool bgsegm_BackgroundSubtractorGMG_getUpdateBackgroundModel_10(IntPtr nativeObj);

        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getBackgroundPrior()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorGMG_getBackgroundPrior_10(IntPtr nativeObj);

        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getDecisionThreshold()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorGMG_getDecisionThreshold_10(IntPtr nativeObj);

        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getDefaultLearningRate()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorGMG_getDefaultLearningRate_10(IntPtr nativeObj);

        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getMaxVal()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorGMG_getMaxVal_10(IntPtr nativeObj);

        // C++:  double cv::bgsegm::BackgroundSubtractorGMG::getMinVal()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorGMG_getMinVal_10(IntPtr nativeObj);

        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getMaxFeatures()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorGMG_getMaxFeatures_10(IntPtr nativeObj);

        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getNumFrames()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorGMG_getNumFrames_10(IntPtr nativeObj);

        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getQuantizationLevels()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorGMG_getQuantizationLevels_10(IntPtr nativeObj);

        // C++:  int cv::bgsegm::BackgroundSubtractorGMG::getSmoothingRadius()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorGMG_getSmoothingRadius_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setBackgroundPrior(double bgprior)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setBackgroundPrior_10(IntPtr nativeObj, double bgprior);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setDecisionThreshold(double thresh)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setDecisionThreshold_10(IntPtr nativeObj, double thresh);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setDefaultLearningRate(double lr)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setDefaultLearningRate_10(IntPtr nativeObj, double lr);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setMaxFeatures(int maxFeatures)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setMaxFeatures_10(IntPtr nativeObj, int maxFeatures);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setMaxVal(double val)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setMaxVal_10(IntPtr nativeObj, double val);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setMinVal(double val)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setMinVal_10(IntPtr nativeObj, double val);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setNumFrames(int nframes)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setNumFrames_10(IntPtr nativeObj, int nframes);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setQuantizationLevels(int nlevels)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setQuantizationLevels_10(IntPtr nativeObj, int nlevels);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setSmoothingRadius(int radius)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setSmoothingRadius_10(IntPtr nativeObj, int radius);

        // C++:  void cv::bgsegm::BackgroundSubtractorGMG::setUpdateBackgroundModel(bool update)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_setUpdateBackgroundModel_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool update);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorGMG_delete(IntPtr nativeObj);

    }
}
