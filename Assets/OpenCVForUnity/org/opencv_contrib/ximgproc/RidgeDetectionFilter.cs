
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class RidgeDetectionFilter
    //javadoc: RidgeDetectionFilter

    public class RidgeDetectionFilter : Algorithm
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
                        ximgproc_RidgeDetectionFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal RidgeDetectionFilter(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new RidgeDetectionFilter __fromPtr__(IntPtr addr) { return new RidgeDetectionFilter(addr); }

        //
        // C++: static Ptr_RidgeDetectionFilter cv::ximgproc::RidgeDetectionFilter::create(int ddepth = CV_32FC1, int dx = 1, int dy = 1, int ksize = 3, int out_dtype = CV_8UC1, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
        //

        //javadoc: RidgeDetectionFilter::create(ddepth, dx, dy, ksize, out_dtype, scale, delta, borderType)
        public static RidgeDetectionFilter create(int ddepth, int dx, int dy, int ksize, int out_dtype, double scale, double delta, int borderType)
        {
#if UNITY_5_3_OR_NEWER
        
        RidgeDetectionFilter retVal = RidgeDetectionFilter.__fromPtr__(ximgproc_RidgeDetectionFilter_create_10(ddepth, dx, dy, ksize, out_dtype, scale, delta, borderType));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RidgeDetectionFilter::create(ddepth, dx, dy, ksize, out_dtype, scale, delta)
        public static RidgeDetectionFilter create(int ddepth, int dx, int dy, int ksize, int out_dtype, double scale, double delta)
        {
#if UNITY_5_3_OR_NEWER
        
        RidgeDetectionFilter retVal = RidgeDetectionFilter.__fromPtr__(ximgproc_RidgeDetectionFilter_create_11(ddepth, dx, dy, ksize, out_dtype, scale, delta));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RidgeDetectionFilter::create(ddepth, dx, dy, ksize, out_dtype, scale)
        public static RidgeDetectionFilter create(int ddepth, int dx, int dy, int ksize, int out_dtype, double scale)
        {
#if UNITY_5_3_OR_NEWER
        
        RidgeDetectionFilter retVal = RidgeDetectionFilter.__fromPtr__(ximgproc_RidgeDetectionFilter_create_12(ddepth, dx, dy, ksize, out_dtype, scale));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RidgeDetectionFilter::create(ddepth, dx, dy, ksize, out_dtype)
        public static RidgeDetectionFilter create(int ddepth, int dx, int dy, int ksize, int out_dtype)
        {
#if UNITY_5_3_OR_NEWER
        
        RidgeDetectionFilter retVal = RidgeDetectionFilter.__fromPtr__(ximgproc_RidgeDetectionFilter_create_13(ddepth, dx, dy, ksize, out_dtype));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RidgeDetectionFilter::create(ddepth, dx, dy, ksize)
        public static RidgeDetectionFilter create(int ddepth, int dx, int dy, int ksize)
        {
#if UNITY_5_3_OR_NEWER
        
        RidgeDetectionFilter retVal = RidgeDetectionFilter.__fromPtr__(ximgproc_RidgeDetectionFilter_create_14(ddepth, dx, dy, ksize));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RidgeDetectionFilter::create(ddepth, dx, dy)
        public static RidgeDetectionFilter create(int ddepth, int dx, int dy)
        {
#if UNITY_5_3_OR_NEWER
        
        RidgeDetectionFilter retVal = RidgeDetectionFilter.__fromPtr__(ximgproc_RidgeDetectionFilter_create_15(ddepth, dx, dy));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RidgeDetectionFilter::create(ddepth, dx)
        public static RidgeDetectionFilter create(int ddepth, int dx)
        {
#if UNITY_5_3_OR_NEWER
        
        RidgeDetectionFilter retVal = RidgeDetectionFilter.__fromPtr__(ximgproc_RidgeDetectionFilter_create_16(ddepth, dx));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RidgeDetectionFilter::create(ddepth)
        public static RidgeDetectionFilter create(int ddepth)
        {
#if UNITY_5_3_OR_NEWER
        
        RidgeDetectionFilter retVal = RidgeDetectionFilter.__fromPtr__(ximgproc_RidgeDetectionFilter_create_17(ddepth));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RidgeDetectionFilter::create()
        public static RidgeDetectionFilter create()
        {
#if UNITY_5_3_OR_NEWER
        
        RidgeDetectionFilter retVal = RidgeDetectionFilter.__fromPtr__(ximgproc_RidgeDetectionFilter_create_18());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::ximgproc::RidgeDetectionFilter::getRidgeFilteredImage(Mat _img, Mat& _out)
        //

        //javadoc: RidgeDetectionFilter::getRidgeFilteredImage(_img, _out)
        public void getRidgeFilteredImage(Mat _img, Mat _out)
        {
            ThrowIfDisposed();
            if (_img != null) _img.ThrowIfDisposed();
            if (_out != null) _out.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_RidgeDetectionFilter_getRidgeFilteredImage_10(nativeObj, _img.nativeObj, _out.nativeObj);
        
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



        // C++: static Ptr_RidgeDetectionFilter cv::ximgproc::RidgeDetectionFilter::create(int ddepth = CV_32FC1, int dx = 1, int dy = 1, int ksize = 3, int out_dtype = CV_8UC1, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_10(int ddepth, int dx, int dy, int ksize, int out_dtype, double scale, double delta, int borderType);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_11(int ddepth, int dx, int dy, int ksize, int out_dtype, double scale, double delta);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_12(int ddepth, int dx, int dy, int ksize, int out_dtype, double scale);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_13(int ddepth, int dx, int dy, int ksize, int out_dtype);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_14(int ddepth, int dx, int dy, int ksize);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_15(int ddepth, int dx, int dy);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_16(int ddepth, int dx);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_17(int ddepth);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_18();

        // C++:  void cv::ximgproc::RidgeDetectionFilter::getRidgeFilteredImage(Mat _img, Mat& _out)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RidgeDetectionFilter_getRidgeFilteredImage_10(IntPtr nativeObj, IntPtr _img_nativeObj, IntPtr _out_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RidgeDetectionFilter_delete(IntPtr nativeObj);

    }
}
