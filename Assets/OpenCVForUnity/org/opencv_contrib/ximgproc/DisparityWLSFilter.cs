
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class DisparityWLSFilter
    //javadoc: DisparityWLSFilter

    public class DisparityWLSFilter : DisparityFilter
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
                        ximgproc_DisparityWLSFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DisparityWLSFilter(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DisparityWLSFilter __fromPtr__(IntPtr addr) { return new DisparityWLSFilter(addr); }

        //
        // C++:  Mat cv::ximgproc::DisparityWLSFilter::getConfidenceMap()
        //

        //javadoc: DisparityWLSFilter::getConfidenceMap()
        public Mat getConfidenceMap()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ximgproc_DisparityWLSFilter_getConfidenceMap_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Rect cv::ximgproc::DisparityWLSFilter::getROI()
        //

        //javadoc: DisparityWLSFilter::getROI()
        public Rect getROI()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[4];
ximgproc_DisparityWLSFilter_getROI_10(nativeObj, tmpArray);
Rect retVal = new Rect (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  double cv::ximgproc::DisparityWLSFilter::getLambda()
        //

        //javadoc: DisparityWLSFilter::getLambda()
        public double getLambda()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = ximgproc_DisparityWLSFilter_getLambda_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::ximgproc::DisparityWLSFilter::getSigmaColor()
        //

        //javadoc: DisparityWLSFilter::getSigmaColor()
        public double getSigmaColor()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = ximgproc_DisparityWLSFilter_getSigmaColor_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ximgproc::DisparityWLSFilter::getDepthDiscontinuityRadius()
        //

        //javadoc: DisparityWLSFilter::getDepthDiscontinuityRadius()
        public int getDepthDiscontinuityRadius()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ximgproc_DisparityWLSFilter_getDepthDiscontinuityRadius_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ximgproc::DisparityWLSFilter::getLRCthresh()
        //

        //javadoc: DisparityWLSFilter::getLRCthresh()
        public int getLRCthresh()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ximgproc_DisparityWLSFilter_getLRCthresh_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ximgproc::DisparityWLSFilter::setDepthDiscontinuityRadius(int _disc_radius)
        //

        //javadoc: DisparityWLSFilter::setDepthDiscontinuityRadius(_disc_radius)
        public void setDepthDiscontinuityRadius(int _disc_radius)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_DisparityWLSFilter_setDepthDiscontinuityRadius_10(nativeObj, _disc_radius);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::DisparityWLSFilter::setLRCthresh(int _LRC_thresh)
        //

        //javadoc: DisparityWLSFilter::setLRCthresh(_LRC_thresh)
        public void setLRCthresh(int _LRC_thresh)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_DisparityWLSFilter_setLRCthresh_10(nativeObj, _LRC_thresh);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::DisparityWLSFilter::setLambda(double _lambda)
        //

        //javadoc: DisparityWLSFilter::setLambda(_lambda)
        public void setLambda(double _lambda)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_DisparityWLSFilter_setLambda_10(nativeObj, _lambda);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::DisparityWLSFilter::setSigmaColor(double _sigma_color)
        //

        //javadoc: DisparityWLSFilter::setSigmaColor(_sigma_color)
        public void setSigmaColor(double _sigma_color)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_DisparityWLSFilter_setSigmaColor_10(nativeObj, _sigma_color);
        
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



        // C++:  Mat cv::ximgproc::DisparityWLSFilter::getConfidenceMap()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_DisparityWLSFilter_getConfidenceMap_10(IntPtr nativeObj);

        // C++:  Rect cv::ximgproc::DisparityWLSFilter::getROI()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_getROI_10(IntPtr nativeObj, double[] retVal);

        // C++:  double cv::ximgproc::DisparityWLSFilter::getLambda()
        [DllImport(LIBNAME)]
        private static extern double ximgproc_DisparityWLSFilter_getLambda_10(IntPtr nativeObj);

        // C++:  double cv::ximgproc::DisparityWLSFilter::getSigmaColor()
        [DllImport(LIBNAME)]
        private static extern double ximgproc_DisparityWLSFilter_getSigmaColor_10(IntPtr nativeObj);

        // C++:  int cv::ximgproc::DisparityWLSFilter::getDepthDiscontinuityRadius()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_DisparityWLSFilter_getDepthDiscontinuityRadius_10(IntPtr nativeObj);

        // C++:  int cv::ximgproc::DisparityWLSFilter::getLRCthresh()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_DisparityWLSFilter_getLRCthresh_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::DisparityWLSFilter::setDepthDiscontinuityRadius(int _disc_radius)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_setDepthDiscontinuityRadius_10(IntPtr nativeObj, int _disc_radius);

        // C++:  void cv::ximgproc::DisparityWLSFilter::setLRCthresh(int _LRC_thresh)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_setLRCthresh_10(IntPtr nativeObj, int _LRC_thresh);

        // C++:  void cv::ximgproc::DisparityWLSFilter::setLambda(double _lambda)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_setLambda_10(IntPtr nativeObj, double _lambda);

        // C++:  void cv::ximgproc::DisparityWLSFilter::setSigmaColor(double _sigma_color)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_setSigmaColor_10(IntPtr nativeObj, double _sigma_color);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_delete(IntPtr nativeObj);

    }
}
