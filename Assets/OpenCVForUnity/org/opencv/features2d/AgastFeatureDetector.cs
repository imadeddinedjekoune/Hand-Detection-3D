
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class AgastFeatureDetector
    //javadoc: AgastFeatureDetector

    public class AgastFeatureDetector : Feature2D
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
                        features2d_AgastFeatureDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal AgastFeatureDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new AgastFeatureDetector __fromPtr__(IntPtr addr) { return new AgastFeatureDetector(addr); }

        // C++: enum <unnamed>
        public const int THRESHOLD = 10000;
        public const int NONMAX_SUPPRESSION = 10001;
        // C++: enum DetectorType
        public const int AGAST_5_8 = 0;
        public const int AGAST_7_12d = 1;
        public const int AGAST_7_12s = 2;
        public const int OAST_9_16 = 3;
        //
        // C++:  AgastFeatureDetector_DetectorType cv::AgastFeatureDetector::getType()
        //

        //javadoc: AgastFeatureDetector::getType()
        public int getType()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_AgastFeatureDetector_getType_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: static Ptr_AgastFeatureDetector cv::AgastFeatureDetector::create(int threshold = 10, bool nonmaxSuppression = true, AgastFeatureDetector_DetectorType type = AgastFeatureDetector::OAST_9_16)
        //

        //javadoc: AgastFeatureDetector::create(threshold, nonmaxSuppression, type)
        public static AgastFeatureDetector create(int threshold, bool nonmaxSuppression, int type)
        {
#if UNITY_5_3_OR_NEWER
        
        AgastFeatureDetector retVal = AgastFeatureDetector.__fromPtr__(features2d_AgastFeatureDetector_create_10(threshold, nonmaxSuppression, type));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: AgastFeatureDetector::create(threshold, nonmaxSuppression)
        public static AgastFeatureDetector create(int threshold, bool nonmaxSuppression)
        {
#if UNITY_5_3_OR_NEWER
        
        AgastFeatureDetector retVal = AgastFeatureDetector.__fromPtr__(features2d_AgastFeatureDetector_create_11(threshold, nonmaxSuppression));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: AgastFeatureDetector::create(threshold)
        public static AgastFeatureDetector create(int threshold)
        {
#if UNITY_5_3_OR_NEWER
        
        AgastFeatureDetector retVal = AgastFeatureDetector.__fromPtr__(features2d_AgastFeatureDetector_create_12(threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: AgastFeatureDetector::create()
        public static AgastFeatureDetector create()
        {
#if UNITY_5_3_OR_NEWER
        
        AgastFeatureDetector retVal = AgastFeatureDetector.__fromPtr__(features2d_AgastFeatureDetector_create_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::AgastFeatureDetector::getDefaultName()
        //

        //javadoc: AgastFeatureDetector::getDefaultName()
        public override string getDefaultName()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (features2d_AgastFeatureDetector_getDefaultName_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::AgastFeatureDetector::getNonmaxSuppression()
        //

        //javadoc: AgastFeatureDetector::getNonmaxSuppression()
        public bool getNonmaxSuppression()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = features2d_AgastFeatureDetector_getNonmaxSuppression_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  int cv::AgastFeatureDetector::getThreshold()
        //

        //javadoc: AgastFeatureDetector::getThreshold()
        public int getThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_AgastFeatureDetector_getThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::AgastFeatureDetector::setNonmaxSuppression(bool f)
        //

        //javadoc: AgastFeatureDetector::setNonmaxSuppression(f)
        public void setNonmaxSuppression(bool f)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_AgastFeatureDetector_setNonmaxSuppression_10(nativeObj, f);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AgastFeatureDetector::setThreshold(int threshold)
        //

        //javadoc: AgastFeatureDetector::setThreshold(threshold)
        public void setThreshold(int threshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_AgastFeatureDetector_setThreshold_10(nativeObj, threshold);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AgastFeatureDetector::setType(AgastFeatureDetector_DetectorType type)
        //

        //javadoc: AgastFeatureDetector::setType(type)
        public void setType(int type)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_AgastFeatureDetector_setType_10(nativeObj, type);
        
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



        // C++:  AgastFeatureDetector_DetectorType cv::AgastFeatureDetector::getType()
        [DllImport(LIBNAME)]
        private static extern int features2d_AgastFeatureDetector_getType_10(IntPtr nativeObj);

        // C++: static Ptr_AgastFeatureDetector cv::AgastFeatureDetector::create(int threshold = 10, bool nonmaxSuppression = true, AgastFeatureDetector_DetectorType type = AgastFeatureDetector::OAST_9_16)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AgastFeatureDetector_create_10(int threshold, [MarshalAs(UnmanagedType.U1)] bool nonmaxSuppression, int type);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AgastFeatureDetector_create_11(int threshold, [MarshalAs(UnmanagedType.U1)] bool nonmaxSuppression);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AgastFeatureDetector_create_12(int threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AgastFeatureDetector_create_13();

        // C++:  String cv::AgastFeatureDetector::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AgastFeatureDetector_getDefaultName_10(IntPtr nativeObj);

        // C++:  bool cv::AgastFeatureDetector::getNonmaxSuppression()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_AgastFeatureDetector_getNonmaxSuppression_10(IntPtr nativeObj);

        // C++:  int cv::AgastFeatureDetector::getThreshold()
        [DllImport(LIBNAME)]
        private static extern int features2d_AgastFeatureDetector_getThreshold_10(IntPtr nativeObj);

        // C++:  void cv::AgastFeatureDetector::setNonmaxSuppression(bool f)
        [DllImport(LIBNAME)]
        private static extern void features2d_AgastFeatureDetector_setNonmaxSuppression_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool f);

        // C++:  void cv::AgastFeatureDetector::setThreshold(int threshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_AgastFeatureDetector_setThreshold_10(IntPtr nativeObj, int threshold);

        // C++:  void cv::AgastFeatureDetector::setType(AgastFeatureDetector_DetectorType type)
        [DllImport(LIBNAME)]
        private static extern void features2d_AgastFeatureDetector_setType_10(IntPtr nativeObj, int type);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_AgastFeatureDetector_delete(IntPtr nativeObj);

    }
}
