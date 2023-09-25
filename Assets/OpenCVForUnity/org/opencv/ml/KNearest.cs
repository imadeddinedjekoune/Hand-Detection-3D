
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class KNearest
    //javadoc: KNearest

    public class KNearest : StatModel
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
                        ml_KNearest_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal KNearest(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new KNearest __fromPtr__(IntPtr addr) { return new KNearest(addr); }

        // C++: enum Types
        public const int BRUTE_FORCE = 1;
        public const int KDTREE = 2;
        //
        // C++: static Ptr_KNearest cv::ml::KNearest::create()
        //

        //javadoc: KNearest::create()
        public static KNearest create()
        {
#if UNITY_5_3_OR_NEWER
        
        KNearest retVal = KNearest.__fromPtr__(ml_KNearest_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::ml::KNearest::getIsClassifier()
        //

        //javadoc: KNearest::getIsClassifier()
        public bool getIsClassifier()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_KNearest_getIsClassifier_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  float cv::ml::KNearest::findNearest(Mat samples, int k, Mat& results, Mat& neighborResponses = Mat(), Mat& dist = Mat())
        //

        //javadoc: KNearest::findNearest(samples, k, results, neighborResponses, dist)
        public float findNearest(Mat samples, int k, Mat results, Mat neighborResponses, Mat dist)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (results != null) results.ThrowIfDisposed();
            if (neighborResponses != null) neighborResponses.ThrowIfDisposed();
            if (dist != null) dist.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ml_KNearest_findNearest_10(nativeObj, samples.nativeObj, k, results.nativeObj, neighborResponses.nativeObj, dist.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: KNearest::findNearest(samples, k, results, neighborResponses)
        public float findNearest(Mat samples, int k, Mat results, Mat neighborResponses)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (results != null) results.ThrowIfDisposed();
            if (neighborResponses != null) neighborResponses.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ml_KNearest_findNearest_11(nativeObj, samples.nativeObj, k, results.nativeObj, neighborResponses.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: KNearest::findNearest(samples, k, results)
        public float findNearest(Mat samples, int k, Mat results)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (results != null) results.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ml_KNearest_findNearest_12(nativeObj, samples.nativeObj, k, results.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::KNearest::getAlgorithmType()
        //

        //javadoc: KNearest::getAlgorithmType()
        public int getAlgorithmType()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_KNearest_getAlgorithmType_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::KNearest::getDefaultK()
        //

        //javadoc: KNearest::getDefaultK()
        public int getDefaultK()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_KNearest_getDefaultK_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::KNearest::getEmax()
        //

        //javadoc: KNearest::getEmax()
        public int getEmax()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_KNearest_getEmax_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ml::KNearest::setAlgorithmType(int val)
        //

        //javadoc: KNearest::setAlgorithmType(val)
        public void setAlgorithmType(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_KNearest_setAlgorithmType_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::KNearest::setDefaultK(int val)
        //

        //javadoc: KNearest::setDefaultK(val)
        public void setDefaultK(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_KNearest_setDefaultK_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::KNearest::setEmax(int val)
        //

        //javadoc: KNearest::setEmax(val)
        public void setEmax(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_KNearest_setEmax_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::KNearest::setIsClassifier(bool val)
        //

        //javadoc: KNearest::setIsClassifier(val)
        public void setIsClassifier(bool val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_KNearest_setIsClassifier_10(nativeObj, val);
        
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



        // C++: static Ptr_KNearest cv::ml::KNearest::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_KNearest_create_10();

        // C++:  bool cv::ml::KNearest::getIsClassifier()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_KNearest_getIsClassifier_10(IntPtr nativeObj);

        // C++:  float cv::ml::KNearest::findNearest(Mat samples, int k, Mat& results, Mat& neighborResponses = Mat(), Mat& dist = Mat())
        [DllImport(LIBNAME)]
        private static extern float ml_KNearest_findNearest_10(IntPtr nativeObj, IntPtr samples_nativeObj, int k, IntPtr results_nativeObj, IntPtr neighborResponses_nativeObj, IntPtr dist_nativeObj);
        [DllImport(LIBNAME)]
        private static extern float ml_KNearest_findNearest_11(IntPtr nativeObj, IntPtr samples_nativeObj, int k, IntPtr results_nativeObj, IntPtr neighborResponses_nativeObj);
        [DllImport(LIBNAME)]
        private static extern float ml_KNearest_findNearest_12(IntPtr nativeObj, IntPtr samples_nativeObj, int k, IntPtr results_nativeObj);

        // C++:  int cv::ml::KNearest::getAlgorithmType()
        [DllImport(LIBNAME)]
        private static extern int ml_KNearest_getAlgorithmType_10(IntPtr nativeObj);

        // C++:  int cv::ml::KNearest::getDefaultK()
        [DllImport(LIBNAME)]
        private static extern int ml_KNearest_getDefaultK_10(IntPtr nativeObj);

        // C++:  int cv::ml::KNearest::getEmax()
        [DllImport(LIBNAME)]
        private static extern int ml_KNearest_getEmax_10(IntPtr nativeObj);

        // C++:  void cv::ml::KNearest::setAlgorithmType(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_KNearest_setAlgorithmType_10(IntPtr nativeObj, int val);

        // C++:  void cv::ml::KNearest::setDefaultK(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_KNearest_setDefaultK_10(IntPtr nativeObj, int val);

        // C++:  void cv::ml::KNearest::setEmax(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_KNearest_setEmax_10(IntPtr nativeObj, int val);

        // C++:  void cv::ml::KNearest::setIsClassifier(bool val)
        [DllImport(LIBNAME)]
        private static extern void ml_KNearest_setIsClassifier_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_KNearest_delete(IntPtr nativeObj);

    }
}
