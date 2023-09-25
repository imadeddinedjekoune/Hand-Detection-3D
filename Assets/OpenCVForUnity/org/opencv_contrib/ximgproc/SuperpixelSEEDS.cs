
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class SuperpixelSEEDS
    //javadoc: SuperpixelSEEDS

    public class SuperpixelSEEDS : Algorithm
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
                        ximgproc_SuperpixelSEEDS_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SuperpixelSEEDS(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SuperpixelSEEDS __fromPtr__(IntPtr addr) { return new SuperpixelSEEDS(addr); }

        //
        // C++:  int cv::ximgproc::SuperpixelSEEDS::getNumberOfSuperpixels()
        //

        //javadoc: SuperpixelSEEDS::getNumberOfSuperpixels()
        public int getNumberOfSuperpixels()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ximgproc_SuperpixelSEEDS_getNumberOfSuperpixels_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ximgproc::SuperpixelSEEDS::getLabelContourMask(Mat& image, bool thick_line = false)
        //

        //javadoc: SuperpixelSEEDS::getLabelContourMask(image, thick_line)
        public void getLabelContourMask(Mat image, bool thick_line)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelSEEDS_getLabelContourMask_10(nativeObj, image.nativeObj, thick_line);
        
        return;
#else
            return;
#endif
        }

        //javadoc: SuperpixelSEEDS::getLabelContourMask(image)
        public void getLabelContourMask(Mat image)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelSEEDS_getLabelContourMask_11(nativeObj, image.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::SuperpixelSEEDS::getLabels(Mat& labels_out)
        //

        //javadoc: SuperpixelSEEDS::getLabels(labels_out)
        public void getLabels(Mat labels_out)
        {
            ThrowIfDisposed();
            if (labels_out != null) labels_out.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelSEEDS_getLabels_10(nativeObj, labels_out.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::SuperpixelSEEDS::iterate(Mat img, int num_iterations = 4)
        //

        //javadoc: SuperpixelSEEDS::iterate(img, num_iterations)
        public void iterate(Mat img, int num_iterations)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelSEEDS_iterate_10(nativeObj, img.nativeObj, num_iterations);
        
        return;
#else
            return;
#endif
        }

        //javadoc: SuperpixelSEEDS::iterate(img)
        public void iterate(Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelSEEDS_iterate_11(nativeObj, img.nativeObj);
        
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



        // C++:  int cv::ximgproc::SuperpixelSEEDS::getNumberOfSuperpixels()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_SuperpixelSEEDS_getNumberOfSuperpixels_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::SuperpixelSEEDS::getLabelContourMask(Mat& image, bool thick_line = false)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SuperpixelSEEDS_getLabelContourMask_10(IntPtr nativeObj, IntPtr image_nativeObj, [MarshalAs(UnmanagedType.U1)] bool thick_line);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SuperpixelSEEDS_getLabelContourMask_11(IntPtr nativeObj, IntPtr image_nativeObj);

        // C++:  void cv::ximgproc::SuperpixelSEEDS::getLabels(Mat& labels_out)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SuperpixelSEEDS_getLabels_10(IntPtr nativeObj, IntPtr labels_out_nativeObj);

        // C++:  void cv::ximgproc::SuperpixelSEEDS::iterate(Mat img, int num_iterations = 4)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SuperpixelSEEDS_iterate_10(IntPtr nativeObj, IntPtr img_nativeObj, int num_iterations);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SuperpixelSEEDS_iterate_11(IntPtr nativeObj, IntPtr img_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SuperpixelSEEDS_delete(IntPtr nativeObj);

    }
}
