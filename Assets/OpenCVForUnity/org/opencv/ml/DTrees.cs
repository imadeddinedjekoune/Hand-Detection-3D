
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class DTrees
    //javadoc: DTrees

    public class DTrees : StatModel
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
                        ml_DTrees_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DTrees(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DTrees __fromPtr__(IntPtr addr) { return new DTrees(addr); }

        // C++: enum Flags
        public const int PREDICT_AUTO = 0;
        public const int PREDICT_SUM = (1 << 8);
        public const int PREDICT_MAX_VOTE = (2 << 8);
        public const int PREDICT_MASK = (3 << 8);
        //
        // C++:  Mat cv::ml::DTrees::getPriors()
        //

        //javadoc: DTrees::getPriors()
        public Mat getPriors()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_DTrees_getPriors_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_DTrees cv::ml::DTrees::create()
        //

        //javadoc: DTrees::create()
        public static DTrees create()
        {
#if UNITY_5_3_OR_NEWER
        
        DTrees retVal = DTrees.__fromPtr__(ml_DTrees_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_DTrees cv::ml::DTrees::load(String filepath, String nodeName = String())
        //

        //javadoc: DTrees::load(filepath, nodeName)
        public static DTrees load(string filepath, string nodeName)
        {
#if UNITY_5_3_OR_NEWER
        
        DTrees retVal = DTrees.__fromPtr__(ml_DTrees_load_10(filepath, nodeName));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DTrees::load(filepath)
        public static DTrees load(string filepath)
        {
#if UNITY_5_3_OR_NEWER
        
        DTrees retVal = DTrees.__fromPtr__(ml_DTrees_load_11(filepath));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::ml::DTrees::getTruncatePrunedTree()
        //

        //javadoc: DTrees::getTruncatePrunedTree()
        public bool getTruncatePrunedTree()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_DTrees_getTruncatePrunedTree_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::ml::DTrees::getUse1SERule()
        //

        //javadoc: DTrees::getUse1SERule()
        public bool getUse1SERule()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_DTrees_getUse1SERule_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::ml::DTrees::getUseSurrogates()
        //

        //javadoc: DTrees::getUseSurrogates()
        public bool getUseSurrogates()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_DTrees_getUseSurrogates_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  float cv::ml::DTrees::getRegressionAccuracy()
        //

        //javadoc: DTrees::getRegressionAccuracy()
        public float getRegressionAccuracy()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ml_DTrees_getRegressionAccuracy_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::DTrees::getCVFolds()
        //

        //javadoc: DTrees::getCVFolds()
        public int getCVFolds()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_DTrees_getCVFolds_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::DTrees::getMaxCategories()
        //

        //javadoc: DTrees::getMaxCategories()
        public int getMaxCategories()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_DTrees_getMaxCategories_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::DTrees::getMaxDepth()
        //

        //javadoc: DTrees::getMaxDepth()
        public int getMaxDepth()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_DTrees_getMaxDepth_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::DTrees::getMinSampleCount()
        //

        //javadoc: DTrees::getMinSampleCount()
        public int getMinSampleCount()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_DTrees_getMinSampleCount_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ml::DTrees::setCVFolds(int val)
        //

        //javadoc: DTrees::setCVFolds(val)
        public void setCVFolds(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_DTrees_setCVFolds_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::DTrees::setMaxCategories(int val)
        //

        //javadoc: DTrees::setMaxCategories(val)
        public void setMaxCategories(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_DTrees_setMaxCategories_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::DTrees::setMaxDepth(int val)
        //

        //javadoc: DTrees::setMaxDepth(val)
        public void setMaxDepth(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_DTrees_setMaxDepth_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::DTrees::setMinSampleCount(int val)
        //

        //javadoc: DTrees::setMinSampleCount(val)
        public void setMinSampleCount(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_DTrees_setMinSampleCount_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::DTrees::setPriors(Mat val)
        //

        //javadoc: DTrees::setPriors(val)
        public void setPriors(Mat val)
        {
            ThrowIfDisposed();
            if (val != null) val.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_DTrees_setPriors_10(nativeObj, val.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::DTrees::setRegressionAccuracy(float val)
        //

        //javadoc: DTrees::setRegressionAccuracy(val)
        public void setRegressionAccuracy(float val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_DTrees_setRegressionAccuracy_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::DTrees::setTruncatePrunedTree(bool val)
        //

        //javadoc: DTrees::setTruncatePrunedTree(val)
        public void setTruncatePrunedTree(bool val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_DTrees_setTruncatePrunedTree_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::DTrees::setUse1SERule(bool val)
        //

        //javadoc: DTrees::setUse1SERule(val)
        public void setUse1SERule(bool val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_DTrees_setUse1SERule_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::DTrees::setUseSurrogates(bool val)
        //

        //javadoc: DTrees::setUseSurrogates(val)
        public void setUseSurrogates(bool val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_DTrees_setUseSurrogates_10(nativeObj, val);
        
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



        // C++:  Mat cv::ml::DTrees::getPriors()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_DTrees_getPriors_10(IntPtr nativeObj);

        // C++: static Ptr_DTrees cv::ml::DTrees::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_DTrees_create_10();

        // C++: static Ptr_DTrees cv::ml::DTrees::load(String filepath, String nodeName = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_DTrees_load_10(string filepath, string nodeName);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_DTrees_load_11(string filepath);

        // C++:  bool cv::ml::DTrees::getTruncatePrunedTree()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_DTrees_getTruncatePrunedTree_10(IntPtr nativeObj);

        // C++:  bool cv::ml::DTrees::getUse1SERule()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_DTrees_getUse1SERule_10(IntPtr nativeObj);

        // C++:  bool cv::ml::DTrees::getUseSurrogates()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_DTrees_getUseSurrogates_10(IntPtr nativeObj);

        // C++:  float cv::ml::DTrees::getRegressionAccuracy()
        [DllImport(LIBNAME)]
        private static extern float ml_DTrees_getRegressionAccuracy_10(IntPtr nativeObj);

        // C++:  int cv::ml::DTrees::getCVFolds()
        [DllImport(LIBNAME)]
        private static extern int ml_DTrees_getCVFolds_10(IntPtr nativeObj);

        // C++:  int cv::ml::DTrees::getMaxCategories()
        [DllImport(LIBNAME)]
        private static extern int ml_DTrees_getMaxCategories_10(IntPtr nativeObj);

        // C++:  int cv::ml::DTrees::getMaxDepth()
        [DllImport(LIBNAME)]
        private static extern int ml_DTrees_getMaxDepth_10(IntPtr nativeObj);

        // C++:  int cv::ml::DTrees::getMinSampleCount()
        [DllImport(LIBNAME)]
        private static extern int ml_DTrees_getMinSampleCount_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setCVFolds(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setCVFolds_10(IntPtr nativeObj, int val);

        // C++:  void cv::ml::DTrees::setMaxCategories(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setMaxCategories_10(IntPtr nativeObj, int val);

        // C++:  void cv::ml::DTrees::setMaxDepth(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setMaxDepth_10(IntPtr nativeObj, int val);

        // C++:  void cv::ml::DTrees::setMinSampleCount(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setMinSampleCount_10(IntPtr nativeObj, int val);

        // C++:  void cv::ml::DTrees::setPriors(Mat val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setPriors_10(IntPtr nativeObj, IntPtr val_nativeObj);

        // C++:  void cv::ml::DTrees::setRegressionAccuracy(float val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setRegressionAccuracy_10(IntPtr nativeObj, float val);

        // C++:  void cv::ml::DTrees::setTruncatePrunedTree(bool val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setTruncatePrunedTree_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  void cv::ml::DTrees::setUse1SERule(bool val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setUse1SERule_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  void cv::ml::DTrees::setUseSurrogates(bool val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setUseSurrogates_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_delete(IntPtr nativeObj);

    }
}
