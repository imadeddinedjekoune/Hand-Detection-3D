
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class SelectiveSearchSegmentation
    //javadoc: SelectiveSearchSegmentation

    public class SelectiveSearchSegmentation : Algorithm
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
                        ximgproc_SelectiveSearchSegmentation_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SelectiveSearchSegmentation(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SelectiveSearchSegmentation __fromPtr__(IntPtr addr) { return new SelectiveSearchSegmentation(addr); }

        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addGraphSegmentation(Ptr_GraphSegmentation g)
        //

        //javadoc: SelectiveSearchSegmentation::addGraphSegmentation(g)
        public void addGraphSegmentation(GraphSegmentation g)
        {
            ThrowIfDisposed();
            if (g != null) g.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_addGraphSegmentation_10(nativeObj, g.getNativeObjAddr());
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addImage(Mat img)
        //

        //javadoc: SelectiveSearchSegmentation::addImage(img)
        public void addImage(Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_addImage_10(nativeObj, img.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addStrategy(Ptr_SelectiveSearchSegmentationStrategy s)
        //

        //javadoc: SelectiveSearchSegmentation::addStrategy(s)
        public void addStrategy(SelectiveSearchSegmentationStrategy s)
        {
            ThrowIfDisposed();
            if (s != null) s.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_addStrategy_10(nativeObj, s.getNativeObjAddr());
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearGraphSegmentations()
        //

        //javadoc: SelectiveSearchSegmentation::clearGraphSegmentations()
        public void clearGraphSegmentations()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_clearGraphSegmentations_10(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearImages()
        //

        //javadoc: SelectiveSearchSegmentation::clearImages()
        public void clearImages()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_clearImages_10(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearStrategies()
        //

        //javadoc: SelectiveSearchSegmentation::clearStrategies()
        public void clearStrategies()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_clearStrategies_10(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::process(vector_Rect& rects)
        //

        //javadoc: SelectiveSearchSegmentation::process(rects)
        public void process(MatOfRect rects)
        {
            ThrowIfDisposed();
            if (rects != null) rects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat rects_mat = rects;
        ximgproc_SelectiveSearchSegmentation_process_10(nativeObj, rects_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::setBaseImage(Mat img)
        //

        //javadoc: SelectiveSearchSegmentation::setBaseImage(img)
        public void setBaseImage(Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_setBaseImage_10(nativeObj, img.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSelectiveSearchFast(int base_k = 150, int inc_k = 150, float sigma = 0.8f)
        //

        //javadoc: SelectiveSearchSegmentation::switchToSelectiveSearchFast(base_k, inc_k, sigma)
        public void switchToSelectiveSearchFast(int base_k, int inc_k, float sigma)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_10(nativeObj, base_k, inc_k, sigma);
        
        return;
#else
            return;
#endif
        }

        //javadoc: SelectiveSearchSegmentation::switchToSelectiveSearchFast(base_k, inc_k)
        public void switchToSelectiveSearchFast(int base_k, int inc_k)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_11(nativeObj, base_k, inc_k);
        
        return;
#else
            return;
#endif
        }

        //javadoc: SelectiveSearchSegmentation::switchToSelectiveSearchFast(base_k)
        public void switchToSelectiveSearchFast(int base_k)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_12(nativeObj, base_k);
        
        return;
#else
            return;
#endif
        }

        //javadoc: SelectiveSearchSegmentation::switchToSelectiveSearchFast()
        public void switchToSelectiveSearchFast()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_13(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSelectiveSearchQuality(int base_k = 150, int inc_k = 150, float sigma = 0.8f)
        //

        //javadoc: SelectiveSearchSegmentation::switchToSelectiveSearchQuality(base_k, inc_k, sigma)
        public void switchToSelectiveSearchQuality(int base_k, int inc_k, float sigma)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_10(nativeObj, base_k, inc_k, sigma);
        
        return;
#else
            return;
#endif
        }

        //javadoc: SelectiveSearchSegmentation::switchToSelectiveSearchQuality(base_k, inc_k)
        public void switchToSelectiveSearchQuality(int base_k, int inc_k)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_11(nativeObj, base_k, inc_k);
        
        return;
#else
            return;
#endif
        }

        //javadoc: SelectiveSearchSegmentation::switchToSelectiveSearchQuality(base_k)
        public void switchToSelectiveSearchQuality(int base_k)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_12(nativeObj, base_k);
        
        return;
#else
            return;
#endif
        }

        //javadoc: SelectiveSearchSegmentation::switchToSelectiveSearchQuality()
        public void switchToSelectiveSearchQuality()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_13(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSingleStrategy(int k = 200, float sigma = 0.8f)
        //

        //javadoc: SelectiveSearchSegmentation::switchToSingleStrategy(k, sigma)
        public void switchToSingleStrategy(int k, float sigma)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_switchToSingleStrategy_10(nativeObj, k, sigma);
        
        return;
#else
            return;
#endif
        }

        //javadoc: SelectiveSearchSegmentation::switchToSingleStrategy(k)
        public void switchToSingleStrategy(int k)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_switchToSingleStrategy_11(nativeObj, k);
        
        return;
#else
            return;
#endif
        }

        //javadoc: SelectiveSearchSegmentation::switchToSingleStrategy()
        public void switchToSingleStrategy()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentation_switchToSingleStrategy_12(nativeObj);
        
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



        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addGraphSegmentation(Ptr_GraphSegmentation g)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_addGraphSegmentation_10(IntPtr nativeObj, IntPtr g_nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addImage(Mat img)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_addImage_10(IntPtr nativeObj, IntPtr img_nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addStrategy(Ptr_SelectiveSearchSegmentationStrategy s)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_addStrategy_10(IntPtr nativeObj, IntPtr s_nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearGraphSegmentations()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_clearGraphSegmentations_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearImages()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_clearImages_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearStrategies()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_clearStrategies_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::process(vector_Rect& rects)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_process_10(IntPtr nativeObj, IntPtr rects_mat_nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::setBaseImage(Mat img)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_setBaseImage_10(IntPtr nativeObj, IntPtr img_nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSelectiveSearchFast(int base_k = 150, int inc_k = 150, float sigma = 0.8f)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_10(IntPtr nativeObj, int base_k, int inc_k, float sigma);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_11(IntPtr nativeObj, int base_k, int inc_k);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_12(IntPtr nativeObj, int base_k);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_13(IntPtr nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSelectiveSearchQuality(int base_k = 150, int inc_k = 150, float sigma = 0.8f)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_10(IntPtr nativeObj, int base_k, int inc_k, float sigma);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_11(IntPtr nativeObj, int base_k, int inc_k);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_12(IntPtr nativeObj, int base_k);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_13(IntPtr nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSingleStrategy(int k = 200, float sigma = 0.8f)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSingleStrategy_10(IntPtr nativeObj, int k, float sigma);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSingleStrategy_11(IntPtr nativeObj, int k);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSingleStrategy_12(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_delete(IntPtr nativeObj);

    }
}
