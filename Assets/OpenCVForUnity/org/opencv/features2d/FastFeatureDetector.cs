
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class FastFeatureDetector
    //javadoc: FastFeatureDetector

    public class FastFeatureDetector : Feature2D
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
                        features2d_FastFeatureDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FastFeatureDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FastFeatureDetector __fromPtr__(IntPtr addr) { return new FastFeatureDetector(addr); }

        // C++: enum DetectorType
        public const int TYPE_5_8 = 0;
        public const int TYPE_7_12 = 1;
        public const int TYPE_9_16 = 2;
        // C++: enum <unnamed>
        public const int THRESHOLD = 10000;
        public const int NONMAX_SUPPRESSION = 10001;
        public const int FAST_N = 10002;
        //
        // C++:  FastFeatureDetector_DetectorType cv::FastFeatureDetector::getType()
        //

        //javadoc: FastFeatureDetector::getType()
        public int getType()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_FastFeatureDetector_getType_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: static Ptr_FastFeatureDetector cv::FastFeatureDetector::create(int threshold = 10, bool nonmaxSuppression = true, FastFeatureDetector_DetectorType type = FastFeatureDetector::TYPE_9_16)
        //

        //javadoc: FastFeatureDetector::create(threshold, nonmaxSuppression, type)
        public static FastFeatureDetector create(int threshold, bool nonmaxSuppression, int type)
        {
#if UNITY_5_3_OR_NEWER
        
        FastFeatureDetector retVal = FastFeatureDetector.__fromPtr__(features2d_FastFeatureDetector_create_10(threshold, nonmaxSuppression, type));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FastFeatureDetector::create(threshold, nonmaxSuppression)
        public static FastFeatureDetector create(int threshold, bool nonmaxSuppression)
        {
#if UNITY_5_3_OR_NEWER
        
        FastFeatureDetector retVal = FastFeatureDetector.__fromPtr__(features2d_FastFeatureDetector_create_11(threshold, nonmaxSuppression));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FastFeatureDetector::create(threshold)
        public static FastFeatureDetector create(int threshold)
        {
#if UNITY_5_3_OR_NEWER
        
        FastFeatureDetector retVal = FastFeatureDetector.__fromPtr__(features2d_FastFeatureDetector_create_12(threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FastFeatureDetector::create()
        public static FastFeatureDetector create()
        {
#if UNITY_5_3_OR_NEWER
        
        FastFeatureDetector retVal = FastFeatureDetector.__fromPtr__(features2d_FastFeatureDetector_create_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::FastFeatureDetector::getDefaultName()
        //

        //javadoc: FastFeatureDetector::getDefaultName()
        public override string getDefaultName()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (features2d_FastFeatureDetector_getDefaultName_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::FastFeatureDetector::getNonmaxSuppression()
        //

        //javadoc: FastFeatureDetector::getNonmaxSuppression()
        public bool getNonmaxSuppression()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = features2d_FastFeatureDetector_getNonmaxSuppression_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  int cv::FastFeatureDetector::getThreshold()
        //

        //javadoc: FastFeatureDetector::getThreshold()
        public int getThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_FastFeatureDetector_getThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::FastFeatureDetector::setNonmaxSuppression(bool f)
        //

        //javadoc: FastFeatureDetector::setNonmaxSuppression(f)
        public void setNonmaxSuppression(bool f)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_FastFeatureDetector_setNonmaxSuppression_10(nativeObj, f);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::FastFeatureDetector::setThreshold(int threshold)
        //

        //javadoc: FastFeatureDetector::setThreshold(threshold)
        public void setThreshold(int threshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_FastFeatureDetector_setThreshold_10(nativeObj, threshold);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::FastFeatureDetector::setType(FastFeatureDetector_DetectorType type)
        //

        //javadoc: FastFeatureDetector::setType(type)
        public void setType(int type)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_FastFeatureDetector_setType_10(nativeObj, type);
        
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



        // C++:  FastFeatureDetector_DetectorType cv::FastFeatureDetector::getType()
        [DllImport(LIBNAME)]
        private static extern int features2d_FastFeatureDetector_getType_10(IntPtr nativeObj);

        // C++: static Ptr_FastFeatureDetector cv::FastFeatureDetector::create(int threshold = 10, bool nonmaxSuppression = true, FastFeatureDetector_DetectorType type = FastFeatureDetector::TYPE_9_16)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_FastFeatureDetector_create_10(int threshold, [MarshalAs(UnmanagedType.U1)] bool nonmaxSuppression, int type);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_FastFeatureDetector_create_11(int threshold, [MarshalAs(UnmanagedType.U1)] bool nonmaxSuppression);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_FastFeatureDetector_create_12(int threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_FastFeatureDetector_create_13();

        // C++:  String cv::FastFeatureDetector::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_FastFeatureDetector_getDefaultName_10(IntPtr nativeObj);

        // C++:  bool cv::FastFeatureDetector::getNonmaxSuppression()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_FastFeatureDetector_getNonmaxSuppression_10(IntPtr nativeObj);

        // C++:  int cv::FastFeatureDetector::getThreshold()
        [DllImport(LIBNAME)]
        private static extern int features2d_FastFeatureDetector_getThreshold_10(IntPtr nativeObj);

        // C++:  void cv::FastFeatureDetector::setNonmaxSuppression(bool f)
        [DllImport(LIBNAME)]
        private static extern void features2d_FastFeatureDetector_setNonmaxSuppression_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool f);

        // C++:  void cv::FastFeatureDetector::setThreshold(int threshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_FastFeatureDetector_setThreshold_10(IntPtr nativeObj, int threshold);

        // C++:  void cv::FastFeatureDetector::setType(FastFeatureDetector_DetectorType type)
        [DllImport(LIBNAME)]
        private static extern void features2d_FastFeatureDetector_setType_10(IntPtr nativeObj, int type);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_FastFeatureDetector_delete(IntPtr nativeObj);

    }
}
