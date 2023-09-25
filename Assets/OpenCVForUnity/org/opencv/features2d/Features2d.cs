
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{
    // C++: class Features2d
    //javadoc: Features2d

    public class Features2d
    {

        // C++: enum DrawMatchesFlags
        public const int DrawMatchesFlags_DEFAULT = 0;
        public const int DrawMatchesFlags_DRAW_OVER_OUTIMG = 1;
        public const int DrawMatchesFlags_NOT_DRAW_SINGLE_POINTS = 2;
        public const int DrawMatchesFlags_DRAW_RICH_KEYPOINTS = 4;
        //
        // C++:  void cv::drawKeypoints(Mat image, vector_KeyPoint keypoints, Mat& outImage, Scalar color = Scalar::all(-1), DrawMatchesFlags flags = DrawMatchesFlags::DEFAULT)
        //

        //javadoc: drawKeypoints(image, keypoints, outImage, color, flags)
        public static void drawKeypoints(Mat image, MatOfKeyPoint keypoints, Mat outImage, Scalar color, int flags)
        {
            if (image != null) image.ThrowIfDisposed();
            if (keypoints != null) keypoints.ThrowIfDisposed();
            if (outImage != null) outImage.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints_mat = keypoints;
        features2d_Features2d_drawKeypoints_10(image.nativeObj, keypoints_mat.nativeObj, outImage.nativeObj, color.val[0], color.val[1], color.val[2], color.val[3], flags);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawKeypoints(image, keypoints, outImage, color)
        public static void drawKeypoints(Mat image, MatOfKeyPoint keypoints, Mat outImage, Scalar color)
        {
            if (image != null) image.ThrowIfDisposed();
            if (keypoints != null) keypoints.ThrowIfDisposed();
            if (outImage != null) outImage.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints_mat = keypoints;
        features2d_Features2d_drawKeypoints_11(image.nativeObj, keypoints_mat.nativeObj, outImage.nativeObj, color.val[0], color.val[1], color.val[2], color.val[3]);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawKeypoints(image, keypoints, outImage)
        public static void drawKeypoints(Mat image, MatOfKeyPoint keypoints, Mat outImage)
        {
            if (image != null) image.ThrowIfDisposed();
            if (keypoints != null) keypoints.ThrowIfDisposed();
            if (outImage != null) outImage.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints_mat = keypoints;
        features2d_Features2d_drawKeypoints_12(image.nativeObj, keypoints_mat.nativeObj, outImage.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::drawMatches(Mat img1, vector_KeyPoint keypoints1, Mat img2, vector_KeyPoint keypoints2, vector_DMatch matches1to2, Mat& outImg, Scalar matchColor = Scalar::all(-1), Scalar singlePointColor = Scalar::all(-1), vector_char matchesMask = std::vector<char>(), DrawMatchesFlags flags = DrawMatchesFlags::DEFAULT)
        //

        //javadoc: drawMatches(img1, keypoints1, img2, keypoints2, matches1to2, outImg, matchColor, singlePointColor, matchesMask, flags)
        public static void drawMatches(Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor, MatOfByte matchesMask, int flags)
        {
            if (img1 != null) img1.ThrowIfDisposed();
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (img2 != null) img2.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            if (outImg != null) outImg.ThrowIfDisposed();
            if (matchesMask != null) matchesMask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        Mat matches1to2_mat = matches1to2;
        Mat matchesMask_mat = matchesMask;
        features2d_Features2d_drawMatches_10(img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj, matchColor.val[0], matchColor.val[1], matchColor.val[2], matchColor.val[3], singlePointColor.val[0], singlePointColor.val[1], singlePointColor.val[2], singlePointColor.val[3], matchesMask_mat.nativeObj, flags);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawMatches(img1, keypoints1, img2, keypoints2, matches1to2, outImg, matchColor, singlePointColor, matchesMask)
        public static void drawMatches(Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor, MatOfByte matchesMask)
        {
            if (img1 != null) img1.ThrowIfDisposed();
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (img2 != null) img2.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            if (outImg != null) outImg.ThrowIfDisposed();
            if (matchesMask != null) matchesMask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        Mat matches1to2_mat = matches1to2;
        Mat matchesMask_mat = matchesMask;
        features2d_Features2d_drawMatches_11(img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj, matchColor.val[0], matchColor.val[1], matchColor.val[2], matchColor.val[3], singlePointColor.val[0], singlePointColor.val[1], singlePointColor.val[2], singlePointColor.val[3], matchesMask_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawMatches(img1, keypoints1, img2, keypoints2, matches1to2, outImg, matchColor, singlePointColor)
        public static void drawMatches(Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor)
        {
            if (img1 != null) img1.ThrowIfDisposed();
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (img2 != null) img2.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            if (outImg != null) outImg.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        Mat matches1to2_mat = matches1to2;
        features2d_Features2d_drawMatches_12(img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj, matchColor.val[0], matchColor.val[1], matchColor.val[2], matchColor.val[3], singlePointColor.val[0], singlePointColor.val[1], singlePointColor.val[2], singlePointColor.val[3]);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawMatches(img1, keypoints1, img2, keypoints2, matches1to2, outImg, matchColor)
        public static void drawMatches(Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, Mat outImg, Scalar matchColor)
        {
            if (img1 != null) img1.ThrowIfDisposed();
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (img2 != null) img2.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            if (outImg != null) outImg.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        Mat matches1to2_mat = matches1to2;
        features2d_Features2d_drawMatches_13(img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj, matchColor.val[0], matchColor.val[1], matchColor.val[2], matchColor.val[3]);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawMatches(img1, keypoints1, img2, keypoints2, matches1to2, outImg)
        public static void drawMatches(Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, Mat outImg)
        {
            if (img1 != null) img1.ThrowIfDisposed();
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (img2 != null) img2.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            if (outImg != null) outImg.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        Mat matches1to2_mat = matches1to2;
        features2d_Features2d_drawMatches_14(img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::drawMatches(Mat img1, vector_KeyPoint keypoints1, Mat img2, vector_KeyPoint keypoints2, vector_vector_DMatch matches1to2, Mat& outImg, Scalar matchColor = Scalar::all(-1), Scalar singlePointColor = Scalar::all(-1), vector_vector_char matchesMask = std::vector<std::vector<char> >(), DrawMatchesFlags flags = DrawMatchesFlags::DEFAULT)
        //

        //javadoc: drawMatchesKnn(img1, keypoints1, img2, keypoints2, matches1to2, outImg, matchColor, singlePointColor, matchesMask, flags)
        public static void drawMatchesKnn(Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, List<MatOfDMatch> matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor, List<MatOfByte> matchesMask, int flags)
        {
            if (img1 != null) img1.ThrowIfDisposed();
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (img2 != null) img2.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (outImg != null) outImg.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        List<Mat> matches1to2_tmplm = new List<Mat>((matches1to2 != null) ? matches1to2.Count : 0);
        Mat matches1to2_mat = Converters.vector_vector_DMatch_to_Mat(matches1to2, matches1to2_tmplm);
        List<Mat> matchesMask_tmplm = new List<Mat>((matchesMask != null) ? matchesMask.Count : 0);
        Mat matchesMask_mat = Converters.vector_vector_char_to_Mat(matchesMask, matchesMask_tmplm);
        features2d_Features2d_drawMatchesKnn_10(img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj, matchColor.val[0], matchColor.val[1], matchColor.val[2], matchColor.val[3], singlePointColor.val[0], singlePointColor.val[1], singlePointColor.val[2], singlePointColor.val[3], matchesMask_mat.nativeObj, flags);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawMatchesKnn(img1, keypoints1, img2, keypoints2, matches1to2, outImg, matchColor, singlePointColor, matchesMask)
        public static void drawMatchesKnn(Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, List<MatOfDMatch> matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor, List<MatOfByte> matchesMask)
        {
            if (img1 != null) img1.ThrowIfDisposed();
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (img2 != null) img2.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (outImg != null) outImg.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        List<Mat> matches1to2_tmplm = new List<Mat>((matches1to2 != null) ? matches1to2.Count : 0);
        Mat matches1to2_mat = Converters.vector_vector_DMatch_to_Mat(matches1to2, matches1to2_tmplm);
        List<Mat> matchesMask_tmplm = new List<Mat>((matchesMask != null) ? matchesMask.Count : 0);
        Mat matchesMask_mat = Converters.vector_vector_char_to_Mat(matchesMask, matchesMask_tmplm);
        features2d_Features2d_drawMatchesKnn_11(img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj, matchColor.val[0], matchColor.val[1], matchColor.val[2], matchColor.val[3], singlePointColor.val[0], singlePointColor.val[1], singlePointColor.val[2], singlePointColor.val[3], matchesMask_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawMatchesKnn(img1, keypoints1, img2, keypoints2, matches1to2, outImg, matchColor, singlePointColor)
        public static void drawMatchesKnn(Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, List<MatOfDMatch> matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor)
        {
            if (img1 != null) img1.ThrowIfDisposed();
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (img2 != null) img2.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (outImg != null) outImg.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        List<Mat> matches1to2_tmplm = new List<Mat>((matches1to2 != null) ? matches1to2.Count : 0);
        Mat matches1to2_mat = Converters.vector_vector_DMatch_to_Mat(matches1to2, matches1to2_tmplm);
        features2d_Features2d_drawMatchesKnn_12(img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj, matchColor.val[0], matchColor.val[1], matchColor.val[2], matchColor.val[3], singlePointColor.val[0], singlePointColor.val[1], singlePointColor.val[2], singlePointColor.val[3]);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawMatchesKnn(img1, keypoints1, img2, keypoints2, matches1to2, outImg, matchColor)
        public static void drawMatchesKnn(Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, List<MatOfDMatch> matches1to2, Mat outImg, Scalar matchColor)
        {
            if (img1 != null) img1.ThrowIfDisposed();
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (img2 != null) img2.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (outImg != null) outImg.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        List<Mat> matches1to2_tmplm = new List<Mat>((matches1to2 != null) ? matches1to2.Count : 0);
        Mat matches1to2_mat = Converters.vector_vector_DMatch_to_Mat(matches1to2, matches1to2_tmplm);
        features2d_Features2d_drawMatchesKnn_13(img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj, matchColor.val[0], matchColor.val[1], matchColor.val[2], matchColor.val[3]);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawMatchesKnn(img1, keypoints1, img2, keypoints2, matches1to2, outImg)
        public static void drawMatchesKnn(Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, List<MatOfDMatch> matches1to2, Mat outImg)
        {
            if (img1 != null) img1.ThrowIfDisposed();
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (img2 != null) img2.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (outImg != null) outImg.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        List<Mat> matches1to2_tmplm = new List<Mat>((matches1to2 != null) ? matches1to2.Count : 0);
        Mat matches1to2_mat = Converters.vector_vector_DMatch_to_Mat(matches1to2, matches1to2_tmplm);
        features2d_Features2d_drawMatchesKnn_14(img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj);
        
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



        // C++:  void cv::drawKeypoints(Mat image, vector_KeyPoint keypoints, Mat& outImage, Scalar color = Scalar::all(-1), DrawMatchesFlags flags = DrawMatchesFlags::DEFAULT)
        [DllImport(LIBNAME)]
        private static extern void features2d_Features2d_drawKeypoints_10(IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr outImage_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3, int flags);
        [DllImport(LIBNAME)]
        private static extern void features2d_Features2d_drawKeypoints_11(IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr outImage_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3);
        [DllImport(LIBNAME)]
        private static extern void features2d_Features2d_drawKeypoints_12(IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr outImage_nativeObj);

        // C++:  void cv::drawMatches(Mat img1, vector_KeyPoint keypoints1, Mat img2, vector_KeyPoint keypoints2, vector_DMatch matches1to2, Mat& outImg, Scalar matchColor = Scalar::all(-1), Scalar singlePointColor = Scalar::all(-1), vector_char matchesMask = std::vector<char>(), DrawMatchesFlags flags = DrawMatchesFlags::DEFAULT)
        [DllImport(LIBNAME)]
        private static extern void features2d_Features2d_drawMatches_10(IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj, double matchColor_val0, double matchColor_val1, double matchColor_val2, double matchColor_val3, double singlePointColor_val0, double singlePointColor_val1, double singlePointColor_val2, double singlePointColor_val3, IntPtr matchesMask_mat_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern void features2d_Features2d_drawMatches_11(IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj, double matchColor_val0, double matchColor_val1, double matchColor_val2, double matchColor_val3, double singlePointColor_val0, double singlePointColor_val1, double singlePointColor_val2, double singlePointColor_val3, IntPtr matchesMask_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_Features2d_drawMatches_12(IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj, double matchColor_val0, double matchColor_val1, double matchColor_val2, double matchColor_val3, double singlePointColor_val0, double singlePointColor_val1, double singlePointColor_val2, double singlePointColor_val3);
        [DllImport(LIBNAME)]
        private static extern void features2d_Features2d_drawMatches_13(IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj, double matchColor_val0, double matchColor_val1, double matchColor_val2, double matchColor_val3);
        [DllImport(LIBNAME)]
        private static extern void features2d_Features2d_drawMatches_14(IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj);

        // C++:  void cv::drawMatches(Mat img1, vector_KeyPoint keypoints1, Mat img2, vector_KeyPoint keypoints2, vector_vector_DMatch matches1to2, Mat& outImg, Scalar matchColor = Scalar::all(-1), Scalar singlePointColor = Scalar::all(-1), vector_vector_char matchesMask = std::vector<std::vector<char> >(), DrawMatchesFlags flags = DrawMatchesFlags::DEFAULT)
        [DllImport(LIBNAME)]
        private static extern void features2d_Features2d_drawMatchesKnn_10(IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj, double matchColor_val0, double matchColor_val1, double matchColor_val2, double matchColor_val3, double singlePointColor_val0, double singlePointColor_val1, double singlePointColor_val2, double singlePointColor_val3, IntPtr matchesMask_mat_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern void features2d_Features2d_drawMatchesKnn_11(IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj, double matchColor_val0, double matchColor_val1, double matchColor_val2, double matchColor_val3, double singlePointColor_val0, double singlePointColor_val1, double singlePointColor_val2, double singlePointColor_val3, IntPtr matchesMask_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_Features2d_drawMatchesKnn_12(IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj, double matchColor_val0, double matchColor_val1, double matchColor_val2, double matchColor_val3, double singlePointColor_val0, double singlePointColor_val1, double singlePointColor_val2, double singlePointColor_val3);
        [DllImport(LIBNAME)]
        private static extern void features2d_Features2d_drawMatchesKnn_13(IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj, double matchColor_val0, double matchColor_val1, double matchColor_val2, double matchColor_val3);
        [DllImport(LIBNAME)]
        private static extern void features2d_Features2d_drawMatchesKnn_14(IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj);

    }
}
