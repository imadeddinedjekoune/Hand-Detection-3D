
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ImgprocModule
{

    // C++: class GeneralizedHough
    //javadoc: GeneralizedHough

    public class GeneralizedHough : Algorithm
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
                        imgproc_GeneralizedHough_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GeneralizedHough(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GeneralizedHough __fromPtr__(IntPtr addr) { return new GeneralizedHough(addr); }

        //
        // C++:  double cv::GeneralizedHough::getDp()
        //

        //javadoc: GeneralizedHough::getDp()
        public double getDp()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = imgproc_GeneralizedHough_getDp_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::GeneralizedHough::getMinDist()
        //

        //javadoc: GeneralizedHough::getMinDist()
        public double getMinDist()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = imgproc_GeneralizedHough_getMinDist_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::GeneralizedHough::getCannyHighThresh()
        //

        //javadoc: GeneralizedHough::getCannyHighThresh()
        public int getCannyHighThresh()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_GeneralizedHough_getCannyHighThresh_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::GeneralizedHough::getCannyLowThresh()
        //

        //javadoc: GeneralizedHough::getCannyLowThresh()
        public int getCannyLowThresh()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_GeneralizedHough_getCannyLowThresh_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::GeneralizedHough::getMaxBufferSize()
        //

        //javadoc: GeneralizedHough::getMaxBufferSize()
        public int getMaxBufferSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_GeneralizedHough_getMaxBufferSize_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::GeneralizedHough::detect(Mat edges, Mat dx, Mat dy, Mat& positions, Mat& votes = Mat())
        //

        //javadoc: GeneralizedHough::detect(edges, dx, dy, positions, votes)
        public void detect(Mat edges, Mat dx, Mat dy, Mat positions, Mat votes)
        {
            ThrowIfDisposed();
            if (edges != null) edges.ThrowIfDisposed();
            if (dx != null) dx.ThrowIfDisposed();
            if (dy != null) dy.ThrowIfDisposed();
            if (positions != null) positions.ThrowIfDisposed();
            if (votes != null) votes.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHough_detect_10(nativeObj, edges.nativeObj, dx.nativeObj, dy.nativeObj, positions.nativeObj, votes.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: GeneralizedHough::detect(edges, dx, dy, positions)
        public void detect(Mat edges, Mat dx, Mat dy, Mat positions)
        {
            ThrowIfDisposed();
            if (edges != null) edges.ThrowIfDisposed();
            if (dx != null) dx.ThrowIfDisposed();
            if (dy != null) dy.ThrowIfDisposed();
            if (positions != null) positions.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHough_detect_11(nativeObj, edges.nativeObj, dx.nativeObj, dy.nativeObj, positions.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GeneralizedHough::detect(Mat image, Mat& positions, Mat& votes = Mat())
        //

        //javadoc: GeneralizedHough::detect(image, positions, votes)
        public void detect(Mat image, Mat positions, Mat votes)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (positions != null) positions.ThrowIfDisposed();
            if (votes != null) votes.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHough_detect_12(nativeObj, image.nativeObj, positions.nativeObj, votes.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: GeneralizedHough::detect(image, positions)
        public void detect(Mat image, Mat positions)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (positions != null) positions.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHough_detect_13(nativeObj, image.nativeObj, positions.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GeneralizedHough::setCannyHighThresh(int cannyHighThresh)
        //

        //javadoc: GeneralizedHough::setCannyHighThresh(cannyHighThresh)
        public void setCannyHighThresh(int cannyHighThresh)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHough_setCannyHighThresh_10(nativeObj, cannyHighThresh);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GeneralizedHough::setCannyLowThresh(int cannyLowThresh)
        //

        //javadoc: GeneralizedHough::setCannyLowThresh(cannyLowThresh)
        public void setCannyLowThresh(int cannyLowThresh)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHough_setCannyLowThresh_10(nativeObj, cannyLowThresh);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GeneralizedHough::setDp(double dp)
        //

        //javadoc: GeneralizedHough::setDp(dp)
        public void setDp(double dp)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHough_setDp_10(nativeObj, dp);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GeneralizedHough::setMaxBufferSize(int maxBufferSize)
        //

        //javadoc: GeneralizedHough::setMaxBufferSize(maxBufferSize)
        public void setMaxBufferSize(int maxBufferSize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHough_setMaxBufferSize_10(nativeObj, maxBufferSize);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GeneralizedHough::setMinDist(double minDist)
        //

        //javadoc: GeneralizedHough::setMinDist(minDist)
        public void setMinDist(double minDist)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHough_setMinDist_10(nativeObj, minDist);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GeneralizedHough::setTemplate(Mat edges, Mat dx, Mat dy, Point templCenter = Point(-1, -1))
        //

        //javadoc: GeneralizedHough::setTemplate(edges, dx, dy, templCenter)
        public void setTemplate(Mat edges, Mat dx, Mat dy, Point templCenter)
        {
            ThrowIfDisposed();
            if (edges != null) edges.ThrowIfDisposed();
            if (dx != null) dx.ThrowIfDisposed();
            if (dy != null) dy.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHough_setTemplate_10(nativeObj, edges.nativeObj, dx.nativeObj, dy.nativeObj, templCenter.x, templCenter.y);
        
        return;
#else
            return;
#endif
        }

        //javadoc: GeneralizedHough::setTemplate(edges, dx, dy)
        public void setTemplate(Mat edges, Mat dx, Mat dy)
        {
            ThrowIfDisposed();
            if (edges != null) edges.ThrowIfDisposed();
            if (dx != null) dx.ThrowIfDisposed();
            if (dy != null) dy.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHough_setTemplate_11(nativeObj, edges.nativeObj, dx.nativeObj, dy.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GeneralizedHough::setTemplate(Mat templ, Point templCenter = Point(-1, -1))
        //

        //javadoc: GeneralizedHough::setTemplate(templ, templCenter)
        public void setTemplate(Mat templ, Point templCenter)
        {
            ThrowIfDisposed();
            if (templ != null) templ.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHough_setTemplate_12(nativeObj, templ.nativeObj, templCenter.x, templCenter.y);
        
        return;
#else
            return;
#endif
        }

        //javadoc: GeneralizedHough::setTemplate(templ)
        public void setTemplate(Mat templ)
        {
            ThrowIfDisposed();
            if (templ != null) templ.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHough_setTemplate_13(nativeObj, templ.nativeObj);
        
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



        // C++:  double cv::GeneralizedHough::getDp()
        [DllImport(LIBNAME)]
        private static extern double imgproc_GeneralizedHough_getDp_10(IntPtr nativeObj);

        // C++:  double cv::GeneralizedHough::getMinDist()
        [DllImport(LIBNAME)]
        private static extern double imgproc_GeneralizedHough_getMinDist_10(IntPtr nativeObj);

        // C++:  int cv::GeneralizedHough::getCannyHighThresh()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHough_getCannyHighThresh_10(IntPtr nativeObj);

        // C++:  int cv::GeneralizedHough::getCannyLowThresh()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHough_getCannyLowThresh_10(IntPtr nativeObj);

        // C++:  int cv::GeneralizedHough::getMaxBufferSize()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHough_getMaxBufferSize_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHough::detect(Mat edges, Mat dx, Mat dy, Mat& positions, Mat& votes = Mat())
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_detect_10(IntPtr nativeObj, IntPtr edges_nativeObj, IntPtr dx_nativeObj, IntPtr dy_nativeObj, IntPtr positions_nativeObj, IntPtr votes_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_detect_11(IntPtr nativeObj, IntPtr edges_nativeObj, IntPtr dx_nativeObj, IntPtr dy_nativeObj, IntPtr positions_nativeObj);

        // C++:  void cv::GeneralizedHough::detect(Mat image, Mat& positions, Mat& votes = Mat())
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_detect_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr positions_nativeObj, IntPtr votes_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_detect_13(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr positions_nativeObj);

        // C++:  void cv::GeneralizedHough::setCannyHighThresh(int cannyHighThresh)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setCannyHighThresh_10(IntPtr nativeObj, int cannyHighThresh);

        // C++:  void cv::GeneralizedHough::setCannyLowThresh(int cannyLowThresh)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setCannyLowThresh_10(IntPtr nativeObj, int cannyLowThresh);

        // C++:  void cv::GeneralizedHough::setDp(double dp)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setDp_10(IntPtr nativeObj, double dp);

        // C++:  void cv::GeneralizedHough::setMaxBufferSize(int maxBufferSize)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setMaxBufferSize_10(IntPtr nativeObj, int maxBufferSize);

        // C++:  void cv::GeneralizedHough::setMinDist(double minDist)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setMinDist_10(IntPtr nativeObj, double minDist);

        // C++:  void cv::GeneralizedHough::setTemplate(Mat edges, Mat dx, Mat dy, Point templCenter = Point(-1, -1))
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setTemplate_10(IntPtr nativeObj, IntPtr edges_nativeObj, IntPtr dx_nativeObj, IntPtr dy_nativeObj, double templCenter_x, double templCenter_y);
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setTemplate_11(IntPtr nativeObj, IntPtr edges_nativeObj, IntPtr dx_nativeObj, IntPtr dy_nativeObj);

        // C++:  void cv::GeneralizedHough::setTemplate(Mat templ, Point templCenter = Point(-1, -1))
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setTemplate_12(IntPtr nativeObj, IntPtr templ_nativeObj, double templCenter_x, double templCenter_y);
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setTemplate_13(IntPtr nativeObj, IntPtr templ_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_delete(IntPtr nativeObj);

    }
}
