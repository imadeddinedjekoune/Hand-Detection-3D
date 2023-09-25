
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class RTrees
    //javadoc: RTrees

    public class RTrees : DTrees
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
                        ml_RTrees_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal RTrees(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new RTrees __fromPtr__(IntPtr addr) { return new RTrees(addr); }

        //
        // C++:  Mat cv::ml::RTrees::getVarImportance()
        //

        //javadoc: RTrees::getVarImportance()
        public Mat getVarImportance()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_RTrees_getVarImportance_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_RTrees cv::ml::RTrees::create()
        //

        //javadoc: RTrees::create()
        public static new RTrees create()
        {
#if UNITY_5_3_OR_NEWER
        
        RTrees retVal = RTrees.__fromPtr__(ml_RTrees_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_RTrees cv::ml::RTrees::load(String filepath, String nodeName = String())
        //

        //javadoc: RTrees::load(filepath, nodeName)
        public static new RTrees load(string filepath, string nodeName)
        {
#if UNITY_5_3_OR_NEWER
        
        RTrees retVal = RTrees.__fromPtr__(ml_RTrees_load_10(filepath, nodeName));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RTrees::load(filepath)
        public static new RTrees load(string filepath)
        {
#if UNITY_5_3_OR_NEWER
        
        RTrees retVal = RTrees.__fromPtr__(ml_RTrees_load_11(filepath));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  TermCriteria cv::ml::RTrees::getTermCriteria()
        //

        //javadoc: RTrees::getTermCriteria()
        public TermCriteria getTermCriteria()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[3];
ml_RTrees_getTermCriteria_10(nativeObj, tmpArray);
TermCriteria retVal = new TermCriteria (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::ml::RTrees::getCalculateVarImportance()
        //

        //javadoc: RTrees::getCalculateVarImportance()
        public bool getCalculateVarImportance()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_RTrees_getCalculateVarImportance_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  int cv::ml::RTrees::getActiveVarCount()
        //

        //javadoc: RTrees::getActiveVarCount()
        public int getActiveVarCount()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_RTrees_getActiveVarCount_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ml::RTrees::getVotes(Mat samples, Mat& results, int flags)
        //

        //javadoc: RTrees::getVotes(samples, results, flags)
        public void getVotes(Mat samples, Mat results, int flags)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (results != null) results.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_RTrees_getVotes_10(nativeObj, samples.nativeObj, results.nativeObj, flags);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::RTrees::setActiveVarCount(int val)
        //

        //javadoc: RTrees::setActiveVarCount(val)
        public void setActiveVarCount(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_RTrees_setActiveVarCount_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::RTrees::setCalculateVarImportance(bool val)
        //

        //javadoc: RTrees::setCalculateVarImportance(val)
        public void setCalculateVarImportance(bool val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_RTrees_setCalculateVarImportance_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::RTrees::setTermCriteria(TermCriteria val)
        //

        //javadoc: RTrees::setTermCriteria(val)
        public void setTermCriteria(TermCriteria val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_RTrees_setTermCriteria_10(nativeObj, val.type, val.maxCount, val.epsilon);
        
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



        // C++:  Mat cv::ml::RTrees::getVarImportance()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_RTrees_getVarImportance_10(IntPtr nativeObj);

        // C++: static Ptr_RTrees cv::ml::RTrees::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_RTrees_create_10();

        // C++: static Ptr_RTrees cv::ml::RTrees::load(String filepath, String nodeName = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_RTrees_load_10(string filepath, string nodeName);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_RTrees_load_11(string filepath);

        // C++:  TermCriteria cv::ml::RTrees::getTermCriteria()
        [DllImport(LIBNAME)]
        private static extern void ml_RTrees_getTermCriteria_10(IntPtr nativeObj, double[] retVal);

        // C++:  bool cv::ml::RTrees::getCalculateVarImportance()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_RTrees_getCalculateVarImportance_10(IntPtr nativeObj);

        // C++:  int cv::ml::RTrees::getActiveVarCount()
        [DllImport(LIBNAME)]
        private static extern int ml_RTrees_getActiveVarCount_10(IntPtr nativeObj);

        // C++:  void cv::ml::RTrees::getVotes(Mat samples, Mat& results, int flags)
        [DllImport(LIBNAME)]
        private static extern void ml_RTrees_getVotes_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj, int flags);

        // C++:  void cv::ml::RTrees::setActiveVarCount(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_RTrees_setActiveVarCount_10(IntPtr nativeObj, int val);

        // C++:  void cv::ml::RTrees::setCalculateVarImportance(bool val)
        [DllImport(LIBNAME)]
        private static extern void ml_RTrees_setCalculateVarImportance_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  void cv::ml::RTrees::setTermCriteria(TermCriteria val)
        [DllImport(LIBNAME)]
        private static extern void ml_RTrees_setTermCriteria_10(IntPtr nativeObj, int val_type, int val_maxCount, double val_epsilon);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_RTrees_delete(IntPtr nativeObj);

    }
}
