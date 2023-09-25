#if !UNITY_WSA_10_0
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TextModule
{
    // C++: class Text
    //javadoc: Text

    public class Text
    {

        // C++: enum <unnamed>
        public const int ERFILTER_NM_RGBLGrad = 0;
        public const int ERFILTER_NM_IHSGrad = 1;
        public const int OCR_LEVEL_WORD = 0;
        public const int OCR_LEVEL_TEXTLINE = 1;
        // C++: enum decoder_mode
        public const int OCR_DECODER_VITERBI = 0;
        // C++: enum ocr_engine_mode
        public const int OEM_TESSERACT_ONLY = 0;
        public const int OEM_CUBE_ONLY = 1;
        public const int OEM_TESSERACT_CUBE_COMBINED = 2;
        public const int OEM_DEFAULT = 3;
        // C++: enum erGrouping_Modes
        public const int ERGROUPING_ORIENTATION_HORIZ = 0;
        public const int ERGROUPING_ORIENTATION_ANY = 1;
        // C++: enum page_seg_mode
        public const int PSM_OSD_ONLY = 0;
        public const int PSM_AUTO_OSD = 1;
        public const int PSM_AUTO_ONLY = 2;
        public const int PSM_AUTO = 3;
        public const int PSM_SINGLE_COLUMN = 4;
        public const int PSM_SINGLE_BLOCK_VERT_TEXT = 5;
        public const int PSM_SINGLE_BLOCK = 6;
        public const int PSM_SINGLE_LINE = 7;
        public const int PSM_SINGLE_WORD = 8;
        public const int PSM_CIRCLE_WORD = 9;
        public const int PSM_SINGLE_CHAR = 10;
        // C++: enum classifier_type
        public const int OCR_KNN_CLASSIFIER = 0;
        public const int OCR_CNN_CLASSIFIER = 1;
        //
        // C++:  Mat cv::text::createOCRHMMTransitionsTable(String vocabulary, vector_String lexicon)
        //

        //javadoc: createOCRHMMTransitionsTable(vocabulary, lexicon)
        public static Mat createOCRHMMTransitionsTable(string vocabulary, List<string> lexicon)
        {
#if UNITY_5_3_OR_NEWER
        Mat lexicon_mat = Converters.vector_String_to_Mat(lexicon);
        Mat retVal = new Mat(text_Text_createOCRHMMTransitionsTable_10(vocabulary, lexicon_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_ERFilter cv::text::createERFilterNM1(Ptr_ERFilter_Callback cb, int thresholdDelta = 1, float minArea = (float)0.00025, float maxArea = (float)0.13, float minProbability = (float)0.4, bool nonMaxSuppression = true, float minProbabilityDiff = (float)0.1)
        //

        // Unknown type 'Ptr_ERFilter_Callback' (I), skipping the function


        //
        // C++:  Ptr_ERFilter cv::text::createERFilterNM1(String filename, int thresholdDelta = 1, float minArea = (float)0.00025, float maxArea = (float)0.13, float minProbability = (float)0.4, bool nonMaxSuppression = true, float minProbabilityDiff = (float)0.1)
        //

        //javadoc: createERFilterNM1(filename, thresholdDelta, minArea, maxArea, minProbability, nonMaxSuppression, minProbabilityDiff)
        public static ERFilter createERFilterNM1(string filename, int thresholdDelta, float minArea, float maxArea, float minProbability, bool nonMaxSuppression, float minProbabilityDiff)
        {
#if UNITY_5_3_OR_NEWER
        
        ERFilter retVal = ERFilter.__fromPtr__(text_Text_createERFilterNM1_10(filename, thresholdDelta, minArea, maxArea, minProbability, nonMaxSuppression, minProbabilityDiff));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createERFilterNM1(filename, thresholdDelta, minArea, maxArea, minProbability, nonMaxSuppression)
        public static ERFilter createERFilterNM1(string filename, int thresholdDelta, float minArea, float maxArea, float minProbability, bool nonMaxSuppression)
        {
#if UNITY_5_3_OR_NEWER
        
        ERFilter retVal = ERFilter.__fromPtr__(text_Text_createERFilterNM1_11(filename, thresholdDelta, minArea, maxArea, minProbability, nonMaxSuppression));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createERFilterNM1(filename, thresholdDelta, minArea, maxArea, minProbability)
        public static ERFilter createERFilterNM1(string filename, int thresholdDelta, float minArea, float maxArea, float minProbability)
        {
#if UNITY_5_3_OR_NEWER
        
        ERFilter retVal = ERFilter.__fromPtr__(text_Text_createERFilterNM1_12(filename, thresholdDelta, minArea, maxArea, minProbability));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createERFilterNM1(filename, thresholdDelta, minArea, maxArea)
        public static ERFilter createERFilterNM1(string filename, int thresholdDelta, float minArea, float maxArea)
        {
#if UNITY_5_3_OR_NEWER
        
        ERFilter retVal = ERFilter.__fromPtr__(text_Text_createERFilterNM1_13(filename, thresholdDelta, minArea, maxArea));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createERFilterNM1(filename, thresholdDelta, minArea)
        public static ERFilter createERFilterNM1(string filename, int thresholdDelta, float minArea)
        {
#if UNITY_5_3_OR_NEWER
        
        ERFilter retVal = ERFilter.__fromPtr__(text_Text_createERFilterNM1_14(filename, thresholdDelta, minArea));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createERFilterNM1(filename, thresholdDelta)
        public static ERFilter createERFilterNM1(string filename, int thresholdDelta)
        {
#if UNITY_5_3_OR_NEWER
        
        ERFilter retVal = ERFilter.__fromPtr__(text_Text_createERFilterNM1_15(filename, thresholdDelta));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createERFilterNM1(filename)
        public static ERFilter createERFilterNM1(string filename)
        {
#if UNITY_5_3_OR_NEWER
        
        ERFilter retVal = ERFilter.__fromPtr__(text_Text_createERFilterNM1_16(filename));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_ERFilter cv::text::createERFilterNM2(Ptr_ERFilter_Callback cb, float minProbability = (float)0.3)
        //

        // Unknown type 'Ptr_ERFilter_Callback' (I), skipping the function


        //
        // C++:  Ptr_ERFilter cv::text::createERFilterNM2(String filename, float minProbability = (float)0.3)
        //

        //javadoc: createERFilterNM2(filename, minProbability)
        public static ERFilter createERFilterNM2(string filename, float minProbability)
        {
#if UNITY_5_3_OR_NEWER
        
        ERFilter retVal = ERFilter.__fromPtr__(text_Text_createERFilterNM2_10(filename, minProbability));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createERFilterNM2(filename)
        public static ERFilter createERFilterNM2(string filename)
        {
#if UNITY_5_3_OR_NEWER
        
        ERFilter retVal = ERFilter.__fromPtr__(text_Text_createERFilterNM2_11(filename));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_ERFilter_Callback cv::text::loadClassifierNM1(String filename)
        //

        // Return type 'Ptr_ERFilter_Callback' is not supported, skipping the function


        //
        // C++:  Ptr_ERFilter_Callback cv::text::loadClassifierNM2(String filename)
        //

        // Return type 'Ptr_ERFilter_Callback' is not supported, skipping the function


        //
        // C++:  Ptr_OCRBeamSearchDecoder_ClassifierCallback cv::text::loadOCRBeamSearchClassifierCNN(String filename)
        //

        // Return type 'Ptr_OCRBeamSearchDecoder_ClassifierCallback' is not supported, skipping the function


        //
        // C++:  Ptr_OCRHMMDecoder_ClassifierCallback cv::text::loadOCRHMMClassifier(String filename, int classifier)
        //

        // Return type 'Ptr_OCRHMMDecoder_ClassifierCallback' is not supported, skipping the function


        //
        // C++:  Ptr_OCRHMMDecoder_ClassifierCallback cv::text::loadOCRHMMClassifierCNN(String filename)
        //

        // Return type 'Ptr_OCRHMMDecoder_ClassifierCallback' is not supported, skipping the function


        //
        // C++:  Ptr_OCRHMMDecoder_ClassifierCallback cv::text::loadOCRHMMClassifierNM(String filename)
        //

        // Return type 'Ptr_OCRHMMDecoder_ClassifierCallback' is not supported, skipping the function


        //
        // C++:  void cv::text::computeNMChannels(Mat _src, vector_Mat& _channels, int _mode = ERFILTER_NM_RGBLGrad)
        //

        //javadoc: computeNMChannels(_src, _channels, _mode)
        public static void computeNMChannels(Mat _src, List<Mat> _channels, int _mode)
        {
            if (_src != null) _src.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat _channels_mat = new Mat();
        text_Text_computeNMChannels_10(_src.nativeObj, _channels_mat.nativeObj, _mode);
        Converters.Mat_to_vector_Mat(_channels_mat, _channels);
        _channels_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: computeNMChannels(_src, _channels)
        public static void computeNMChannels(Mat _src, List<Mat> _channels)
        {
            if (_src != null) _src.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat _channels_mat = new Mat();
        text_Text_computeNMChannels_11(_src.nativeObj, _channels_mat.nativeObj);
        Converters.Mat_to_vector_Mat(_channels_mat, _channels);
        _channels_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::text::detectRegions(Mat image, Ptr_ERFilter er_filter1, Ptr_ERFilter er_filter2, vector_Rect& groups_rects, int method = ERGROUPING_ORIENTATION_HORIZ, String filename = String(), float minProbability = (float)0.5)
        //

        //javadoc: detectRegions(image, er_filter1, er_filter2, groups_rects, method, filename, minProbability)
        public static void detectRegions(Mat image, ERFilter er_filter1, ERFilter er_filter2, MatOfRect groups_rects, int method, string filename, float minProbability)
        {
            if (image != null) image.ThrowIfDisposed();
            if (er_filter1 != null) er_filter1.ThrowIfDisposed();
            if (er_filter2 != null) er_filter2.ThrowIfDisposed();
            if (groups_rects != null) groups_rects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat groups_rects_mat = groups_rects;
        text_Text_detectRegions_10(image.nativeObj, er_filter1.getNativeObjAddr(), er_filter2.getNativeObjAddr(), groups_rects_mat.nativeObj, method, filename, minProbability);
        
        return;
#else
            return;
#endif
        }

        //javadoc: detectRegions(image, er_filter1, er_filter2, groups_rects, method, filename)
        public static void detectRegions(Mat image, ERFilter er_filter1, ERFilter er_filter2, MatOfRect groups_rects, int method, string filename)
        {
            if (image != null) image.ThrowIfDisposed();
            if (er_filter1 != null) er_filter1.ThrowIfDisposed();
            if (er_filter2 != null) er_filter2.ThrowIfDisposed();
            if (groups_rects != null) groups_rects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat groups_rects_mat = groups_rects;
        text_Text_detectRegions_11(image.nativeObj, er_filter1.getNativeObjAddr(), er_filter2.getNativeObjAddr(), groups_rects_mat.nativeObj, method, filename);
        
        return;
#else
            return;
#endif
        }

        //javadoc: detectRegions(image, er_filter1, er_filter2, groups_rects, method)
        public static void detectRegions(Mat image, ERFilter er_filter1, ERFilter er_filter2, MatOfRect groups_rects, int method)
        {
            if (image != null) image.ThrowIfDisposed();
            if (er_filter1 != null) er_filter1.ThrowIfDisposed();
            if (er_filter2 != null) er_filter2.ThrowIfDisposed();
            if (groups_rects != null) groups_rects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat groups_rects_mat = groups_rects;
        text_Text_detectRegions_12(image.nativeObj, er_filter1.getNativeObjAddr(), er_filter2.getNativeObjAddr(), groups_rects_mat.nativeObj, method);
        
        return;
#else
            return;
#endif
        }

        //javadoc: detectRegions(image, er_filter1, er_filter2, groups_rects)
        public static void detectRegions(Mat image, ERFilter er_filter1, ERFilter er_filter2, MatOfRect groups_rects)
        {
            if (image != null) image.ThrowIfDisposed();
            if (er_filter1 != null) er_filter1.ThrowIfDisposed();
            if (er_filter2 != null) er_filter2.ThrowIfDisposed();
            if (groups_rects != null) groups_rects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat groups_rects_mat = groups_rects;
        text_Text_detectRegions_13(image.nativeObj, er_filter1.getNativeObjAddr(), er_filter2.getNativeObjAddr(), groups_rects_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::text::detectRegions(Mat image, Ptr_ERFilter er_filter1, Ptr_ERFilter er_filter2, vector_vector_Point& regions)
        //

        //javadoc: detectRegions(image, er_filter1, er_filter2, regions)
        public static void detectRegions(Mat image, ERFilter er_filter1, ERFilter er_filter2, List<MatOfPoint> regions)
        {
            if (image != null) image.ThrowIfDisposed();
            if (er_filter1 != null) er_filter1.ThrowIfDisposed();
            if (er_filter2 != null) er_filter2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat regions_mat = new Mat();
        text_Text_detectRegions_14(image.nativeObj, er_filter1.getNativeObjAddr(), er_filter2.getNativeObjAddr(), regions_mat.nativeObj);
        Converters.Mat_to_vector_vector_Point(regions_mat, regions);
        regions_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::text::erGrouping(Mat image, Mat channel, vector_vector_Point regions, vector_Rect& groups_rects, int method = ERGROUPING_ORIENTATION_HORIZ, String filename = String(), float minProbablity = (float)0.5)
        //

        //javadoc: erGrouping(image, channel, regions, groups_rects, method, filename, minProbablity)
        public static void erGrouping(Mat image, Mat channel, List<MatOfPoint> regions, MatOfRect groups_rects, int method, string filename, float minProbablity)
        {
            if (image != null) image.ThrowIfDisposed();
            if (channel != null) channel.ThrowIfDisposed();
            if (groups_rects != null) groups_rects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        List<Mat> regions_tmplm = new List<Mat>((regions != null) ? regions.Count : 0);
        Mat regions_mat = Converters.vector_vector_Point_to_Mat(regions, regions_tmplm);
        Mat groups_rects_mat = groups_rects;
        text_Text_erGrouping_10(image.nativeObj, channel.nativeObj, regions_mat.nativeObj, groups_rects_mat.nativeObj, method, filename, minProbablity);
        
        return;
#else
            return;
#endif
        }

        //javadoc: erGrouping(image, channel, regions, groups_rects, method, filename)
        public static void erGrouping(Mat image, Mat channel, List<MatOfPoint> regions, MatOfRect groups_rects, int method, string filename)
        {
            if (image != null) image.ThrowIfDisposed();
            if (channel != null) channel.ThrowIfDisposed();
            if (groups_rects != null) groups_rects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        List<Mat> regions_tmplm = new List<Mat>((regions != null) ? regions.Count : 0);
        Mat regions_mat = Converters.vector_vector_Point_to_Mat(regions, regions_tmplm);
        Mat groups_rects_mat = groups_rects;
        text_Text_erGrouping_11(image.nativeObj, channel.nativeObj, regions_mat.nativeObj, groups_rects_mat.nativeObj, method, filename);
        
        return;
#else
            return;
#endif
        }

        //javadoc: erGrouping(image, channel, regions, groups_rects, method)
        public static void erGrouping(Mat image, Mat channel, List<MatOfPoint> regions, MatOfRect groups_rects, int method)
        {
            if (image != null) image.ThrowIfDisposed();
            if (channel != null) channel.ThrowIfDisposed();
            if (groups_rects != null) groups_rects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        List<Mat> regions_tmplm = new List<Mat>((regions != null) ? regions.Count : 0);
        Mat regions_mat = Converters.vector_vector_Point_to_Mat(regions, regions_tmplm);
        Mat groups_rects_mat = groups_rects;
        text_Text_erGrouping_12(image.nativeObj, channel.nativeObj, regions_mat.nativeObj, groups_rects_mat.nativeObj, method);
        
        return;
#else
            return;
#endif
        }

        //javadoc: erGrouping(image, channel, regions, groups_rects)
        public static void erGrouping(Mat image, Mat channel, List<MatOfPoint> regions, MatOfRect groups_rects)
        {
            if (image != null) image.ThrowIfDisposed();
            if (channel != null) channel.ThrowIfDisposed();
            if (groups_rects != null) groups_rects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        List<Mat> regions_tmplm = new List<Mat>((regions != null) ? regions.Count : 0);
        Mat regions_mat = Converters.vector_vector_Point_to_Mat(regions, regions_tmplm);
        Mat groups_rects_mat = groups_rects;
        text_Text_erGrouping_13(image.nativeObj, channel.nativeObj, regions_mat.nativeObj, groups_rects_mat.nativeObj);
        
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



        // C++:  Mat cv::text::createOCRHMMTransitionsTable(String vocabulary, vector_String lexicon)
        [DllImport(LIBNAME)]
        private static extern IntPtr text_Text_createOCRHMMTransitionsTable_10(string vocabulary, IntPtr lexicon_mat_nativeObj);

        // C++:  Ptr_ERFilter cv::text::createERFilterNM1(String filename, int thresholdDelta = 1, float minArea = (float)0.00025, float maxArea = (float)0.13, float minProbability = (float)0.4, bool nonMaxSuppression = true, float minProbabilityDiff = (float)0.1)
        [DllImport(LIBNAME)]
        private static extern IntPtr text_Text_createERFilterNM1_10(string filename, int thresholdDelta, float minArea, float maxArea, float minProbability, [MarshalAs(UnmanagedType.U1)] bool nonMaxSuppression, float minProbabilityDiff);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_Text_createERFilterNM1_11(string filename, int thresholdDelta, float minArea, float maxArea, float minProbability, [MarshalAs(UnmanagedType.U1)] bool nonMaxSuppression);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_Text_createERFilterNM1_12(string filename, int thresholdDelta, float minArea, float maxArea, float minProbability);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_Text_createERFilterNM1_13(string filename, int thresholdDelta, float minArea, float maxArea);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_Text_createERFilterNM1_14(string filename, int thresholdDelta, float minArea);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_Text_createERFilterNM1_15(string filename, int thresholdDelta);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_Text_createERFilterNM1_16(string filename);

        // C++:  Ptr_ERFilter cv::text::createERFilterNM2(String filename, float minProbability = (float)0.3)
        [DllImport(LIBNAME)]
        private static extern IntPtr text_Text_createERFilterNM2_10(string filename, float minProbability);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_Text_createERFilterNM2_11(string filename);

        // C++:  void cv::text::computeNMChannels(Mat _src, vector_Mat& _channels, int _mode = ERFILTER_NM_RGBLGrad)
        [DllImport(LIBNAME)]
        private static extern void text_Text_computeNMChannels_10(IntPtr _src_nativeObj, IntPtr _channels_mat_nativeObj, int _mode);
        [DllImport(LIBNAME)]
        private static extern void text_Text_computeNMChannels_11(IntPtr _src_nativeObj, IntPtr _channels_mat_nativeObj);

        // C++:  void cv::text::detectRegions(Mat image, Ptr_ERFilter er_filter1, Ptr_ERFilter er_filter2, vector_Rect& groups_rects, int method = ERGROUPING_ORIENTATION_HORIZ, String filename = String(), float minProbability = (float)0.5)
        [DllImport(LIBNAME)]
        private static extern void text_Text_detectRegions_10(IntPtr image_nativeObj, IntPtr er_filter1_nativeObj, IntPtr er_filter2_nativeObj, IntPtr groups_rects_mat_nativeObj, int method, string filename, float minProbability);
        [DllImport(LIBNAME)]
        private static extern void text_Text_detectRegions_11(IntPtr image_nativeObj, IntPtr er_filter1_nativeObj, IntPtr er_filter2_nativeObj, IntPtr groups_rects_mat_nativeObj, int method, string filename);
        [DllImport(LIBNAME)]
        private static extern void text_Text_detectRegions_12(IntPtr image_nativeObj, IntPtr er_filter1_nativeObj, IntPtr er_filter2_nativeObj, IntPtr groups_rects_mat_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern void text_Text_detectRegions_13(IntPtr image_nativeObj, IntPtr er_filter1_nativeObj, IntPtr er_filter2_nativeObj, IntPtr groups_rects_mat_nativeObj);

        // C++:  void cv::text::detectRegions(Mat image, Ptr_ERFilter er_filter1, Ptr_ERFilter er_filter2, vector_vector_Point& regions)
        [DllImport(LIBNAME)]
        private static extern void text_Text_detectRegions_14(IntPtr image_nativeObj, IntPtr er_filter1_nativeObj, IntPtr er_filter2_nativeObj, IntPtr regions_mat_nativeObj);

        // C++:  void cv::text::erGrouping(Mat image, Mat channel, vector_vector_Point regions, vector_Rect& groups_rects, int method = ERGROUPING_ORIENTATION_HORIZ, String filename = String(), float minProbablity = (float)0.5)
        [DllImport(LIBNAME)]
        private static extern void text_Text_erGrouping_10(IntPtr image_nativeObj, IntPtr channel_nativeObj, IntPtr regions_mat_nativeObj, IntPtr groups_rects_mat_nativeObj, int method, string filename, float minProbablity);
        [DllImport(LIBNAME)]
        private static extern void text_Text_erGrouping_11(IntPtr image_nativeObj, IntPtr channel_nativeObj, IntPtr regions_mat_nativeObj, IntPtr groups_rects_mat_nativeObj, int method, string filename);
        [DllImport(LIBNAME)]
        private static extern void text_Text_erGrouping_12(IntPtr image_nativeObj, IntPtr channel_nativeObj, IntPtr regions_mat_nativeObj, IntPtr groups_rects_mat_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern void text_Text_erGrouping_13(IntPtr image_nativeObj, IntPtr channel_nativeObj, IntPtr regions_mat_nativeObj, IntPtr groups_rects_mat_nativeObj);

    }
}
#endif