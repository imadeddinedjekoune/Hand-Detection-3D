
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Calib3dModule
{

    // C++: class StereoMatcher
    //javadoc: StereoMatcher

    public class StereoMatcher : Algorithm
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
                        calib3d_StereoMatcher_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StereoMatcher(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StereoMatcher __fromPtr__(IntPtr addr) { return new StereoMatcher(addr); }

        // C++: enum <unnamed>
        public const int DISP_SHIFT = 4;
        public const int DISP_SCALE = (1 << DISP_SHIFT);
        //
        // C++:  int cv::StereoMatcher::getBlockSize()
        //

        //javadoc: StereoMatcher::getBlockSize()
        public int getBlockSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoMatcher_getBlockSize_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::StereoMatcher::getDisp12MaxDiff()
        //

        //javadoc: StereoMatcher::getDisp12MaxDiff()
        public int getDisp12MaxDiff()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoMatcher_getDisp12MaxDiff_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::StereoMatcher::getMinDisparity()
        //

        //javadoc: StereoMatcher::getMinDisparity()
        public int getMinDisparity()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoMatcher_getMinDisparity_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::StereoMatcher::getNumDisparities()
        //

        //javadoc: StereoMatcher::getNumDisparities()
        public int getNumDisparities()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoMatcher_getNumDisparities_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::StereoMatcher::getSpeckleRange()
        //

        //javadoc: StereoMatcher::getSpeckleRange()
        public int getSpeckleRange()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoMatcher_getSpeckleRange_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::StereoMatcher::getSpeckleWindowSize()
        //

        //javadoc: StereoMatcher::getSpeckleWindowSize()
        public int getSpeckleWindowSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoMatcher_getSpeckleWindowSize_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::StereoMatcher::compute(Mat left, Mat right, Mat& disparity)
        //

        //javadoc: StereoMatcher::compute(left, right, disparity)
        public void compute(Mat left, Mat right, Mat disparity)
        {
            ThrowIfDisposed();
            if (left != null) left.ThrowIfDisposed();
            if (right != null) right.ThrowIfDisposed();
            if (disparity != null) disparity.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_StereoMatcher_compute_10(nativeObj, left.nativeObj, right.nativeObj, disparity.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::StereoMatcher::setBlockSize(int blockSize)
        //

        //javadoc: StereoMatcher::setBlockSize(blockSize)
        public void setBlockSize(int blockSize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_StereoMatcher_setBlockSize_10(nativeObj, blockSize);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::StereoMatcher::setDisp12MaxDiff(int disp12MaxDiff)
        //

        //javadoc: StereoMatcher::setDisp12MaxDiff(disp12MaxDiff)
        public void setDisp12MaxDiff(int disp12MaxDiff)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_StereoMatcher_setDisp12MaxDiff_10(nativeObj, disp12MaxDiff);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::StereoMatcher::setMinDisparity(int minDisparity)
        //

        //javadoc: StereoMatcher::setMinDisparity(minDisparity)
        public void setMinDisparity(int minDisparity)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_StereoMatcher_setMinDisparity_10(nativeObj, minDisparity);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::StereoMatcher::setNumDisparities(int numDisparities)
        //

        //javadoc: StereoMatcher::setNumDisparities(numDisparities)
        public void setNumDisparities(int numDisparities)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_StereoMatcher_setNumDisparities_10(nativeObj, numDisparities);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::StereoMatcher::setSpeckleRange(int speckleRange)
        //

        //javadoc: StereoMatcher::setSpeckleRange(speckleRange)
        public void setSpeckleRange(int speckleRange)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_StereoMatcher_setSpeckleRange_10(nativeObj, speckleRange);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::StereoMatcher::setSpeckleWindowSize(int speckleWindowSize)
        //

        //javadoc: StereoMatcher::setSpeckleWindowSize(speckleWindowSize)
        public void setSpeckleWindowSize(int speckleWindowSize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_StereoMatcher_setSpeckleWindowSize_10(nativeObj, speckleWindowSize);
        
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



        // C++:  int cv::StereoMatcher::getBlockSize()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoMatcher_getBlockSize_10(IntPtr nativeObj);

        // C++:  int cv::StereoMatcher::getDisp12MaxDiff()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoMatcher_getDisp12MaxDiff_10(IntPtr nativeObj);

        // C++:  int cv::StereoMatcher::getMinDisparity()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoMatcher_getMinDisparity_10(IntPtr nativeObj);

        // C++:  int cv::StereoMatcher::getNumDisparities()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoMatcher_getNumDisparities_10(IntPtr nativeObj);

        // C++:  int cv::StereoMatcher::getSpeckleRange()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoMatcher_getSpeckleRange_10(IntPtr nativeObj);

        // C++:  int cv::StereoMatcher::getSpeckleWindowSize()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoMatcher_getSpeckleWindowSize_10(IntPtr nativeObj);

        // C++:  void cv::StereoMatcher::compute(Mat left, Mat right, Mat& disparity)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_compute_10(IntPtr nativeObj, IntPtr left_nativeObj, IntPtr right_nativeObj, IntPtr disparity_nativeObj);

        // C++:  void cv::StereoMatcher::setBlockSize(int blockSize)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_setBlockSize_10(IntPtr nativeObj, int blockSize);

        // C++:  void cv::StereoMatcher::setDisp12MaxDiff(int disp12MaxDiff)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_setDisp12MaxDiff_10(IntPtr nativeObj, int disp12MaxDiff);

        // C++:  void cv::StereoMatcher::setMinDisparity(int minDisparity)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_setMinDisparity_10(IntPtr nativeObj, int minDisparity);

        // C++:  void cv::StereoMatcher::setNumDisparities(int numDisparities)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_setNumDisparities_10(IntPtr nativeObj, int numDisparities);

        // C++:  void cv::StereoMatcher::setSpeckleRange(int speckleRange)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_setSpeckleRange_10(IntPtr nativeObj, int speckleRange);

        // C++:  void cv::StereoMatcher::setSpeckleWindowSize(int speckleWindowSize)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_setSpeckleWindowSize_10(IntPtr nativeObj, int speckleWindowSize);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_delete(IntPtr nativeObj);

    }
}
