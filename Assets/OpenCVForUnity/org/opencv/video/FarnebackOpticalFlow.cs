
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class FarnebackOpticalFlow
    //javadoc: FarnebackOpticalFlow

    public class FarnebackOpticalFlow : DenseOpticalFlow
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
                        video_FarnebackOpticalFlow_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FarnebackOpticalFlow(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FarnebackOpticalFlow __fromPtr__(IntPtr addr) { return new FarnebackOpticalFlow(addr); }

        //
        // C++: static Ptr_FarnebackOpticalFlow cv::FarnebackOpticalFlow::create(int numLevels = 5, double pyrScale = 0.5, bool fastPyramids = false, int winSize = 13, int numIters = 10, int polyN = 5, double polySigma = 1.1, int flags = 0)
        //

        //javadoc: FarnebackOpticalFlow::create(numLevels, pyrScale, fastPyramids, winSize, numIters, polyN, polySigma, flags)
        public static FarnebackOpticalFlow create(int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters, int polyN, double polySigma, int flags)
        {
#if UNITY_5_3_OR_NEWER
        
        FarnebackOpticalFlow retVal = FarnebackOpticalFlow.__fromPtr__(video_FarnebackOpticalFlow_create_10(numLevels, pyrScale, fastPyramids, winSize, numIters, polyN, polySigma, flags));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FarnebackOpticalFlow::create(numLevels, pyrScale, fastPyramids, winSize, numIters, polyN, polySigma)
        public static FarnebackOpticalFlow create(int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters, int polyN, double polySigma)
        {
#if UNITY_5_3_OR_NEWER
        
        FarnebackOpticalFlow retVal = FarnebackOpticalFlow.__fromPtr__(video_FarnebackOpticalFlow_create_11(numLevels, pyrScale, fastPyramids, winSize, numIters, polyN, polySigma));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FarnebackOpticalFlow::create(numLevels, pyrScale, fastPyramids, winSize, numIters, polyN)
        public static FarnebackOpticalFlow create(int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters, int polyN)
        {
#if UNITY_5_3_OR_NEWER
        
        FarnebackOpticalFlow retVal = FarnebackOpticalFlow.__fromPtr__(video_FarnebackOpticalFlow_create_12(numLevels, pyrScale, fastPyramids, winSize, numIters, polyN));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FarnebackOpticalFlow::create(numLevels, pyrScale, fastPyramids, winSize, numIters)
        public static FarnebackOpticalFlow create(int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters)
        {
#if UNITY_5_3_OR_NEWER
        
        FarnebackOpticalFlow retVal = FarnebackOpticalFlow.__fromPtr__(video_FarnebackOpticalFlow_create_13(numLevels, pyrScale, fastPyramids, winSize, numIters));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FarnebackOpticalFlow::create(numLevels, pyrScale, fastPyramids, winSize)
        public static FarnebackOpticalFlow create(int numLevels, double pyrScale, bool fastPyramids, int winSize)
        {
#if UNITY_5_3_OR_NEWER
        
        FarnebackOpticalFlow retVal = FarnebackOpticalFlow.__fromPtr__(video_FarnebackOpticalFlow_create_14(numLevels, pyrScale, fastPyramids, winSize));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FarnebackOpticalFlow::create(numLevels, pyrScale, fastPyramids)
        public static FarnebackOpticalFlow create(int numLevels, double pyrScale, bool fastPyramids)
        {
#if UNITY_5_3_OR_NEWER
        
        FarnebackOpticalFlow retVal = FarnebackOpticalFlow.__fromPtr__(video_FarnebackOpticalFlow_create_15(numLevels, pyrScale, fastPyramids));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FarnebackOpticalFlow::create(numLevels, pyrScale)
        public static FarnebackOpticalFlow create(int numLevels, double pyrScale)
        {
#if UNITY_5_3_OR_NEWER
        
        FarnebackOpticalFlow retVal = FarnebackOpticalFlow.__fromPtr__(video_FarnebackOpticalFlow_create_16(numLevels, pyrScale));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FarnebackOpticalFlow::create(numLevels)
        public static FarnebackOpticalFlow create(int numLevels)
        {
#if UNITY_5_3_OR_NEWER
        
        FarnebackOpticalFlow retVal = FarnebackOpticalFlow.__fromPtr__(video_FarnebackOpticalFlow_create_17(numLevels));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FarnebackOpticalFlow::create()
        public static FarnebackOpticalFlow create()
        {
#if UNITY_5_3_OR_NEWER
        
        FarnebackOpticalFlow retVal = FarnebackOpticalFlow.__fromPtr__(video_FarnebackOpticalFlow_create_18());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::FarnebackOpticalFlow::getFastPyramids()
        //

        //javadoc: FarnebackOpticalFlow::getFastPyramids()
        public bool getFastPyramids()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = video_FarnebackOpticalFlow_getFastPyramids_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  double cv::FarnebackOpticalFlow::getPolySigma()
        //

        //javadoc: FarnebackOpticalFlow::getPolySigma()
        public double getPolySigma()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = video_FarnebackOpticalFlow_getPolySigma_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::FarnebackOpticalFlow::getPyrScale()
        //

        //javadoc: FarnebackOpticalFlow::getPyrScale()
        public double getPyrScale()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = video_FarnebackOpticalFlow_getPyrScale_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::FarnebackOpticalFlow::getFlags()
        //

        //javadoc: FarnebackOpticalFlow::getFlags()
        public int getFlags()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_FarnebackOpticalFlow_getFlags_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::FarnebackOpticalFlow::getNumIters()
        //

        //javadoc: FarnebackOpticalFlow::getNumIters()
        public int getNumIters()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_FarnebackOpticalFlow_getNumIters_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::FarnebackOpticalFlow::getNumLevels()
        //

        //javadoc: FarnebackOpticalFlow::getNumLevels()
        public int getNumLevels()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_FarnebackOpticalFlow_getNumLevels_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::FarnebackOpticalFlow::getPolyN()
        //

        //javadoc: FarnebackOpticalFlow::getPolyN()
        public int getPolyN()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_FarnebackOpticalFlow_getPolyN_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::FarnebackOpticalFlow::getWinSize()
        //

        //javadoc: FarnebackOpticalFlow::getWinSize()
        public int getWinSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_FarnebackOpticalFlow_getWinSize_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setFastPyramids(bool fastPyramids)
        //

        //javadoc: FarnebackOpticalFlow::setFastPyramids(fastPyramids)
        public void setFastPyramids(bool fastPyramids)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setFastPyramids_10(nativeObj, fastPyramids);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setFlags(int flags)
        //

        //javadoc: FarnebackOpticalFlow::setFlags(flags)
        public void setFlags(int flags)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setFlags_10(nativeObj, flags);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setNumIters(int numIters)
        //

        //javadoc: FarnebackOpticalFlow::setNumIters(numIters)
        public void setNumIters(int numIters)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setNumIters_10(nativeObj, numIters);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setNumLevels(int numLevels)
        //

        //javadoc: FarnebackOpticalFlow::setNumLevels(numLevels)
        public void setNumLevels(int numLevels)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setNumLevels_10(nativeObj, numLevels);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setPolyN(int polyN)
        //

        //javadoc: FarnebackOpticalFlow::setPolyN(polyN)
        public void setPolyN(int polyN)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setPolyN_10(nativeObj, polyN);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setPolySigma(double polySigma)
        //

        //javadoc: FarnebackOpticalFlow::setPolySigma(polySigma)
        public void setPolySigma(double polySigma)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setPolySigma_10(nativeObj, polySigma);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setPyrScale(double pyrScale)
        //

        //javadoc: FarnebackOpticalFlow::setPyrScale(pyrScale)
        public void setPyrScale(double pyrScale)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setPyrScale_10(nativeObj, pyrScale);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setWinSize(int winSize)
        //

        //javadoc: FarnebackOpticalFlow::setWinSize(winSize)
        public void setWinSize(int winSize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setWinSize_10(nativeObj, winSize);
        
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



        // C++: static Ptr_FarnebackOpticalFlow cv::FarnebackOpticalFlow::create(int numLevels = 5, double pyrScale = 0.5, bool fastPyramids = false, int winSize = 13, int numIters = 10, int polyN = 5, double polySigma = 1.1, int flags = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_10(int numLevels, double pyrScale, [MarshalAs(UnmanagedType.U1)] bool fastPyramids, int winSize, int numIters, int polyN, double polySigma, int flags);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_11(int numLevels, double pyrScale, [MarshalAs(UnmanagedType.U1)] bool fastPyramids, int winSize, int numIters, int polyN, double polySigma);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_12(int numLevels, double pyrScale, [MarshalAs(UnmanagedType.U1)] bool fastPyramids, int winSize, int numIters, int polyN);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_13(int numLevels, double pyrScale, [MarshalAs(UnmanagedType.U1)] bool fastPyramids, int winSize, int numIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_14(int numLevels, double pyrScale, [MarshalAs(UnmanagedType.U1)] bool fastPyramids, int winSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_15(int numLevels, double pyrScale, [MarshalAs(UnmanagedType.U1)] bool fastPyramids);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_16(int numLevels, double pyrScale);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_17(int numLevels);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_18();

        // C++:  bool cv::FarnebackOpticalFlow::getFastPyramids()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool video_FarnebackOpticalFlow_getFastPyramids_10(IntPtr nativeObj);

        // C++:  double cv::FarnebackOpticalFlow::getPolySigma()
        [DllImport(LIBNAME)]
        private static extern double video_FarnebackOpticalFlow_getPolySigma_10(IntPtr nativeObj);

        // C++:  double cv::FarnebackOpticalFlow::getPyrScale()
        [DllImport(LIBNAME)]
        private static extern double video_FarnebackOpticalFlow_getPyrScale_10(IntPtr nativeObj);

        // C++:  int cv::FarnebackOpticalFlow::getFlags()
        [DllImport(LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getFlags_10(IntPtr nativeObj);

        // C++:  int cv::FarnebackOpticalFlow::getNumIters()
        [DllImport(LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getNumIters_10(IntPtr nativeObj);

        // C++:  int cv::FarnebackOpticalFlow::getNumLevels()
        [DllImport(LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getNumLevels_10(IntPtr nativeObj);

        // C++:  int cv::FarnebackOpticalFlow::getPolyN()
        [DllImport(LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getPolyN_10(IntPtr nativeObj);

        // C++:  int cv::FarnebackOpticalFlow::getWinSize()
        [DllImport(LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getWinSize_10(IntPtr nativeObj);

        // C++:  void cv::FarnebackOpticalFlow::setFastPyramids(bool fastPyramids)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setFastPyramids_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool fastPyramids);

        // C++:  void cv::FarnebackOpticalFlow::setFlags(int flags)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setFlags_10(IntPtr nativeObj, int flags);

        // C++:  void cv::FarnebackOpticalFlow::setNumIters(int numIters)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setNumIters_10(IntPtr nativeObj, int numIters);

        // C++:  void cv::FarnebackOpticalFlow::setNumLevels(int numLevels)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setNumLevels_10(IntPtr nativeObj, int numLevels);

        // C++:  void cv::FarnebackOpticalFlow::setPolyN(int polyN)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setPolyN_10(IntPtr nativeObj, int polyN);

        // C++:  void cv::FarnebackOpticalFlow::setPolySigma(double polySigma)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setPolySigma_10(IntPtr nativeObj, double polySigma);

        // C++:  void cv::FarnebackOpticalFlow::setPyrScale(double pyrScale)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setPyrScale_10(IntPtr nativeObj, double pyrScale);

        // C++:  void cv::FarnebackOpticalFlow::setWinSize(int winSize)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setWinSize_10(IntPtr nativeObj, int winSize);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_delete(IntPtr nativeObj);

    }
}
