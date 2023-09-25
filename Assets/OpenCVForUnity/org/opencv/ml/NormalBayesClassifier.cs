
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class NormalBayesClassifier
    //javadoc: NormalBayesClassifier

    public class NormalBayesClassifier : StatModel
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
                        ml_NormalBayesClassifier_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal NormalBayesClassifier(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new NormalBayesClassifier __fromPtr__(IntPtr addr) { return new NormalBayesClassifier(addr); }

        //
        // C++: static Ptr_NormalBayesClassifier cv::ml::NormalBayesClassifier::create()
        //

        //javadoc: NormalBayesClassifier::create()
        public static NormalBayesClassifier create()
        {
#if UNITY_5_3_OR_NEWER
        
        NormalBayesClassifier retVal = NormalBayesClassifier.__fromPtr__(ml_NormalBayesClassifier_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_NormalBayesClassifier cv::ml::NormalBayesClassifier::load(String filepath, String nodeName = String())
        //

        //javadoc: NormalBayesClassifier::load(filepath, nodeName)
        public static NormalBayesClassifier load(string filepath, string nodeName)
        {
#if UNITY_5_3_OR_NEWER
        
        NormalBayesClassifier retVal = NormalBayesClassifier.__fromPtr__(ml_NormalBayesClassifier_load_10(filepath, nodeName));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: NormalBayesClassifier::load(filepath)
        public static NormalBayesClassifier load(string filepath)
        {
#if UNITY_5_3_OR_NEWER
        
        NormalBayesClassifier retVal = NormalBayesClassifier.__fromPtr__(ml_NormalBayesClassifier_load_11(filepath));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  float cv::ml::NormalBayesClassifier::predictProb(Mat inputs, Mat& outputs, Mat& outputProbs, int flags = 0)
        //

        //javadoc: NormalBayesClassifier::predictProb(inputs, outputs, outputProbs, flags)
        public float predictProb(Mat inputs, Mat outputs, Mat outputProbs, int flags)
        {
            ThrowIfDisposed();
            if (inputs != null) inputs.ThrowIfDisposed();
            if (outputs != null) outputs.ThrowIfDisposed();
            if (outputProbs != null) outputProbs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ml_NormalBayesClassifier_predictProb_10(nativeObj, inputs.nativeObj, outputs.nativeObj, outputProbs.nativeObj, flags);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: NormalBayesClassifier::predictProb(inputs, outputs, outputProbs)
        public float predictProb(Mat inputs, Mat outputs, Mat outputProbs)
        {
            ThrowIfDisposed();
            if (inputs != null) inputs.ThrowIfDisposed();
            if (outputs != null) outputs.ThrowIfDisposed();
            if (outputProbs != null) outputProbs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ml_NormalBayesClassifier_predictProb_11(nativeObj, inputs.nativeObj, outputs.nativeObj, outputProbs.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_NormalBayesClassifier cv::ml::NormalBayesClassifier::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_NormalBayesClassifier_create_10();

        // C++: static Ptr_NormalBayesClassifier cv::ml::NormalBayesClassifier::load(String filepath, String nodeName = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_NormalBayesClassifier_load_10(string filepath, string nodeName);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_NormalBayesClassifier_load_11(string filepath);

        // C++:  float cv::ml::NormalBayesClassifier::predictProb(Mat inputs, Mat& outputs, Mat& outputProbs, int flags = 0)
        [DllImport(LIBNAME)]
        private static extern float ml_NormalBayesClassifier_predictProb_10(IntPtr nativeObj, IntPtr inputs_nativeObj, IntPtr outputs_nativeObj, IntPtr outputProbs_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern float ml_NormalBayesClassifier_predictProb_11(IntPtr nativeObj, IntPtr inputs_nativeObj, IntPtr outputs_nativeObj, IntPtr outputProbs_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_NormalBayesClassifier_delete(IntPtr nativeObj);

    }
}
