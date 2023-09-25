
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class AlignMTB
    //javadoc: AlignMTB

    public class AlignMTB : AlignExposures
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
                        photo_AlignMTB_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal AlignMTB(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new AlignMTB __fromPtr__(IntPtr addr) { return new AlignMTB(addr); }

        //
        // C++:  Point cv::AlignMTB::calculateShift(Mat img0, Mat img1)
        //

        //javadoc: AlignMTB::calculateShift(img0, img1)
        public Point calculateShift(Mat img0, Mat img1)
        {
            ThrowIfDisposed();
            if (img0 != null) img0.ThrowIfDisposed();
            if (img1 != null) img1.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
photo_AlignMTB_calculateShift_10(nativeObj, img0.nativeObj, img1.nativeObj, tmpArray);
Point retVal = new Point (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::AlignMTB::getCut()
        //

        //javadoc: AlignMTB::getCut()
        public bool getCut()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = photo_AlignMTB_getCut_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  int cv::AlignMTB::getExcludeRange()
        //

        //javadoc: AlignMTB::getExcludeRange()
        public int getExcludeRange()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = photo_AlignMTB_getExcludeRange_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::AlignMTB::getMaxBits()
        //

        //javadoc: AlignMTB::getMaxBits()
        public int getMaxBits()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = photo_AlignMTB_getMaxBits_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::AlignMTB::computeBitmaps(Mat img, Mat& tb, Mat& eb)
        //

        //javadoc: AlignMTB::computeBitmaps(img, tb, eb)
        public void computeBitmaps(Mat img, Mat tb, Mat eb)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (tb != null) tb.ThrowIfDisposed();
            if (eb != null) eb.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_AlignMTB_computeBitmaps_10(nativeObj, img.nativeObj, tb.nativeObj, eb.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AlignMTB::process(vector_Mat src, vector_Mat dst, Mat times, Mat response)
        //

        //javadoc: AlignMTB::process(src, dst, times, response)
        public override void process(List<Mat> src, List<Mat> dst, Mat times, Mat response)
        {
            ThrowIfDisposed();
            if (times != null) times.ThrowIfDisposed();
            if (response != null) response.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat src_mat = Converters.vector_Mat_to_Mat(src);
        Mat dst_mat = Converters.vector_Mat_to_Mat(dst);
        photo_AlignMTB_process_10(nativeObj, src_mat.nativeObj, dst_mat.nativeObj, times.nativeObj, response.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AlignMTB::process(vector_Mat src, vector_Mat dst)
        //

        //javadoc: AlignMTB::process(src, dst)
        public void process(List<Mat> src, List<Mat> dst)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat src_mat = Converters.vector_Mat_to_Mat(src);
        Mat dst_mat = Converters.vector_Mat_to_Mat(dst);
        photo_AlignMTB_process_11(nativeObj, src_mat.nativeObj, dst_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AlignMTB::setCut(bool value)
        //

        //javadoc: AlignMTB::setCut(value)
        public void setCut(bool value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_AlignMTB_setCut_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AlignMTB::setExcludeRange(int exclude_range)
        //

        //javadoc: AlignMTB::setExcludeRange(exclude_range)
        public void setExcludeRange(int exclude_range)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_AlignMTB_setExcludeRange_10(nativeObj, exclude_range);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AlignMTB::setMaxBits(int max_bits)
        //

        //javadoc: AlignMTB::setMaxBits(max_bits)
        public void setMaxBits(int max_bits)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_AlignMTB_setMaxBits_10(nativeObj, max_bits);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AlignMTB::shiftMat(Mat src, Mat& dst, Point shift)
        //

        //javadoc: AlignMTB::shiftMat(src, dst, shift)
        public void shiftMat(Mat src, Mat dst, Point shift)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_AlignMTB_shiftMat_10(nativeObj, src.nativeObj, dst.nativeObj, shift.x, shift.y);
        
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



        // C++:  Point cv::AlignMTB::calculateShift(Mat img0, Mat img1)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_calculateShift_10(IntPtr nativeObj, IntPtr img0_nativeObj, IntPtr img1_nativeObj, double[] retVal);

        // C++:  bool cv::AlignMTB::getCut()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool photo_AlignMTB_getCut_10(IntPtr nativeObj);

        // C++:  int cv::AlignMTB::getExcludeRange()
        [DllImport(LIBNAME)]
        private static extern int photo_AlignMTB_getExcludeRange_10(IntPtr nativeObj);

        // C++:  int cv::AlignMTB::getMaxBits()
        [DllImport(LIBNAME)]
        private static extern int photo_AlignMTB_getMaxBits_10(IntPtr nativeObj);

        // C++:  void cv::AlignMTB::computeBitmaps(Mat img, Mat& tb, Mat& eb)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_computeBitmaps_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr tb_nativeObj, IntPtr eb_nativeObj);

        // C++:  void cv::AlignMTB::process(vector_Mat src, vector_Mat dst, Mat times, Mat response)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_process_10(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr times_nativeObj, IntPtr response_nativeObj);

        // C++:  void cv::AlignMTB::process(vector_Mat src, vector_Mat dst)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_process_11(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj);

        // C++:  void cv::AlignMTB::setCut(bool value)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_setCut_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool value);

        // C++:  void cv::AlignMTB::setExcludeRange(int exclude_range)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_setExcludeRange_10(IntPtr nativeObj, int exclude_range);

        // C++:  void cv::AlignMTB::setMaxBits(int max_bits)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_setMaxBits_10(IntPtr nativeObj, int max_bits);

        // C++:  void cv::AlignMTB::shiftMat(Mat src, Mat& dst, Point shift)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_shiftMat_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double shift_x, double shift_y);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_delete(IntPtr nativeObj);

    }
}
