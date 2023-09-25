
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class SparsePyrLKOpticalFlow
    //javadoc: SparsePyrLKOpticalFlow

    public class SparsePyrLKOpticalFlow : SparseOpticalFlow
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
                        video_SparsePyrLKOpticalFlow_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SparsePyrLKOpticalFlow(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SparsePyrLKOpticalFlow __fromPtr__(IntPtr addr) { return new SparsePyrLKOpticalFlow(addr); }

        //
        // C++: static Ptr_SparsePyrLKOpticalFlow cv::SparsePyrLKOpticalFlow::create(Size winSize = Size(21, 21), int maxLevel = 3, TermCriteria crit = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 0.01), int flags = 0, double minEigThreshold = 1e-4)
        //

        //javadoc: SparsePyrLKOpticalFlow::create(winSize, maxLevel, crit, flags, minEigThreshold)
        public static SparsePyrLKOpticalFlow create(Size winSize, int maxLevel, TermCriteria crit, int flags, double minEigThreshold)
        {
#if UNITY_5_3_OR_NEWER
        
        SparsePyrLKOpticalFlow retVal = SparsePyrLKOpticalFlow.__fromPtr__(video_SparsePyrLKOpticalFlow_create_10(winSize.width, winSize.height, maxLevel, crit.type, crit.maxCount, crit.epsilon, flags, minEigThreshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: SparsePyrLKOpticalFlow::create(winSize, maxLevel, crit, flags)
        public static SparsePyrLKOpticalFlow create(Size winSize, int maxLevel, TermCriteria crit, int flags)
        {
#if UNITY_5_3_OR_NEWER
        
        SparsePyrLKOpticalFlow retVal = SparsePyrLKOpticalFlow.__fromPtr__(video_SparsePyrLKOpticalFlow_create_11(winSize.width, winSize.height, maxLevel, crit.type, crit.maxCount, crit.epsilon, flags));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: SparsePyrLKOpticalFlow::create(winSize, maxLevel, crit)
        public static SparsePyrLKOpticalFlow create(Size winSize, int maxLevel, TermCriteria crit)
        {
#if UNITY_5_3_OR_NEWER
        
        SparsePyrLKOpticalFlow retVal = SparsePyrLKOpticalFlow.__fromPtr__(video_SparsePyrLKOpticalFlow_create_12(winSize.width, winSize.height, maxLevel, crit.type, crit.maxCount, crit.epsilon));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: SparsePyrLKOpticalFlow::create(winSize, maxLevel)
        public static SparsePyrLKOpticalFlow create(Size winSize, int maxLevel)
        {
#if UNITY_5_3_OR_NEWER
        
        SparsePyrLKOpticalFlow retVal = SparsePyrLKOpticalFlow.__fromPtr__(video_SparsePyrLKOpticalFlow_create_13(winSize.width, winSize.height, maxLevel));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: SparsePyrLKOpticalFlow::create(winSize)
        public static SparsePyrLKOpticalFlow create(Size winSize)
        {
#if UNITY_5_3_OR_NEWER
        
        SparsePyrLKOpticalFlow retVal = SparsePyrLKOpticalFlow.__fromPtr__(video_SparsePyrLKOpticalFlow_create_14(winSize.width, winSize.height));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: SparsePyrLKOpticalFlow::create()
        public static SparsePyrLKOpticalFlow create()
        {
#if UNITY_5_3_OR_NEWER
        
        SparsePyrLKOpticalFlow retVal = SparsePyrLKOpticalFlow.__fromPtr__(video_SparsePyrLKOpticalFlow_create_15());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Size cv::SparsePyrLKOpticalFlow::getWinSize()
        //

        //javadoc: SparsePyrLKOpticalFlow::getWinSize()
        public Size getWinSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
video_SparsePyrLKOpticalFlow_getWinSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  TermCriteria cv::SparsePyrLKOpticalFlow::getTermCriteria()
        //

        //javadoc: SparsePyrLKOpticalFlow::getTermCriteria()
        public TermCriteria getTermCriteria()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[3];
video_SparsePyrLKOpticalFlow_getTermCriteria_10(nativeObj, tmpArray);
TermCriteria retVal = new TermCriteria (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  double cv::SparsePyrLKOpticalFlow::getMinEigThreshold()
        //

        //javadoc: SparsePyrLKOpticalFlow::getMinEigThreshold()
        public double getMinEigThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = video_SparsePyrLKOpticalFlow_getMinEigThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::SparsePyrLKOpticalFlow::getFlags()
        //

        //javadoc: SparsePyrLKOpticalFlow::getFlags()
        public int getFlags()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_SparsePyrLKOpticalFlow_getFlags_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::SparsePyrLKOpticalFlow::getMaxLevel()
        //

        //javadoc: SparsePyrLKOpticalFlow::getMaxLevel()
        public int getMaxLevel()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_SparsePyrLKOpticalFlow_getMaxLevel_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::SparsePyrLKOpticalFlow::setFlags(int flags)
        //

        //javadoc: SparsePyrLKOpticalFlow::setFlags(flags)
        public void setFlags(int flags)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_SparsePyrLKOpticalFlow_setFlags_10(nativeObj, flags);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::SparsePyrLKOpticalFlow::setMaxLevel(int maxLevel)
        //

        //javadoc: SparsePyrLKOpticalFlow::setMaxLevel(maxLevel)
        public void setMaxLevel(int maxLevel)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_SparsePyrLKOpticalFlow_setMaxLevel_10(nativeObj, maxLevel);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::SparsePyrLKOpticalFlow::setMinEigThreshold(double minEigThreshold)
        //

        //javadoc: SparsePyrLKOpticalFlow::setMinEigThreshold(minEigThreshold)
        public void setMinEigThreshold(double minEigThreshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_SparsePyrLKOpticalFlow_setMinEigThreshold_10(nativeObj, minEigThreshold);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::SparsePyrLKOpticalFlow::setTermCriteria(TermCriteria crit)
        //

        //javadoc: SparsePyrLKOpticalFlow::setTermCriteria(crit)
        public void setTermCriteria(TermCriteria crit)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_SparsePyrLKOpticalFlow_setTermCriteria_10(nativeObj, crit.type, crit.maxCount, crit.epsilon);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::SparsePyrLKOpticalFlow::setWinSize(Size winSize)
        //

        //javadoc: SparsePyrLKOpticalFlow::setWinSize(winSize)
        public void setWinSize(Size winSize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_SparsePyrLKOpticalFlow_setWinSize_10(nativeObj, winSize.width, winSize.height);
        
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



        // C++: static Ptr_SparsePyrLKOpticalFlow cv::SparsePyrLKOpticalFlow::create(Size winSize = Size(21, 21), int maxLevel = 3, TermCriteria crit = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 0.01), int flags = 0, double minEigThreshold = 1e-4)
        [DllImport(LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_10(double winSize_width, double winSize_height, int maxLevel, int crit_type, int crit_maxCount, double crit_epsilon, int flags, double minEigThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_11(double winSize_width, double winSize_height, int maxLevel, int crit_type, int crit_maxCount, double crit_epsilon, int flags);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_12(double winSize_width, double winSize_height, int maxLevel, int crit_type, int crit_maxCount, double crit_epsilon);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_13(double winSize_width, double winSize_height, int maxLevel);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_14(double winSize_width, double winSize_height);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_15();

        // C++:  Size cv::SparsePyrLKOpticalFlow::getWinSize()
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_getWinSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  TermCriteria cv::SparsePyrLKOpticalFlow::getTermCriteria()
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_getTermCriteria_10(IntPtr nativeObj, double[] retVal);

        // C++:  double cv::SparsePyrLKOpticalFlow::getMinEigThreshold()
        [DllImport(LIBNAME)]
        private static extern double video_SparsePyrLKOpticalFlow_getMinEigThreshold_10(IntPtr nativeObj);

        // C++:  int cv::SparsePyrLKOpticalFlow::getFlags()
        [DllImport(LIBNAME)]
        private static extern int video_SparsePyrLKOpticalFlow_getFlags_10(IntPtr nativeObj);

        // C++:  int cv::SparsePyrLKOpticalFlow::getMaxLevel()
        [DllImport(LIBNAME)]
        private static extern int video_SparsePyrLKOpticalFlow_getMaxLevel_10(IntPtr nativeObj);

        // C++:  void cv::SparsePyrLKOpticalFlow::setFlags(int flags)
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setFlags_10(IntPtr nativeObj, int flags);

        // C++:  void cv::SparsePyrLKOpticalFlow::setMaxLevel(int maxLevel)
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setMaxLevel_10(IntPtr nativeObj, int maxLevel);

        // C++:  void cv::SparsePyrLKOpticalFlow::setMinEigThreshold(double minEigThreshold)
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setMinEigThreshold_10(IntPtr nativeObj, double minEigThreshold);

        // C++:  void cv::SparsePyrLKOpticalFlow::setTermCriteria(TermCriteria crit)
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setTermCriteria_10(IntPtr nativeObj, int crit_type, int crit_maxCount, double crit_epsilon);

        // C++:  void cv::SparsePyrLKOpticalFlow::setWinSize(Size winSize)
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setWinSize_10(IntPtr nativeObj, double winSize_width, double winSize_height);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_delete(IntPtr nativeObj);

    }
}
