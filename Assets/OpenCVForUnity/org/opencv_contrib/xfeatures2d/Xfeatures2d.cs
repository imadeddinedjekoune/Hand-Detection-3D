
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{
    // C++: class Xfeatures2d
    //javadoc: Xfeatures2d

    public class Xfeatures2d
    {

        // C++: enum KeypointLayout
        public const int SURF_CUDA_X_ROW = 0;
        public const int SURF_CUDA_Y_ROW = 0 + 1;
        public const int SURF_CUDA_LAPLACIAN_ROW = 0 + 2;
        public const int SURF_CUDA_OCTAVE_ROW = 0 + 3;
        public const int SURF_CUDA_SIZE_ROW = 0 + 4;
        public const int SURF_CUDA_ANGLE_ROW = 0 + 5;
        public const int SURF_CUDA_HESSIAN_ROW = 0 + 6;
        public const int SURF_CUDA_ROWS_COUNT = 0 + 7;
        //
        // C++:  void cv::xfeatures2d::matchGMS(Size size1, Size size2, vector_KeyPoint keypoints1, vector_KeyPoint keypoints2, vector_DMatch matches1to2, vector_DMatch& matchesGMS, bool withRotation = false, bool withScale = false, double thresholdFactor = 6.0)
        //

        //javadoc: matchGMS(size1, size2, keypoints1, keypoints2, matches1to2, matchesGMS, withRotation, withScale, thresholdFactor)
        public static void matchGMS(Size size1, Size size2, MatOfKeyPoint keypoints1, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, MatOfDMatch matchesGMS, bool withRotation, bool withScale, double thresholdFactor)
        {
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            if (matchesGMS != null) matchesGMS.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        Mat matches1to2_mat = matches1to2;
        Mat matchesGMS_mat = matchesGMS;
        xfeatures2d_Xfeatures2d_matchGMS_10(size1.width, size1.height, size2.width, size2.height, keypoints1_mat.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, matchesGMS_mat.nativeObj, withRotation, withScale, thresholdFactor);
        
        return;
#else
            return;
#endif
        }

        //javadoc: matchGMS(size1, size2, keypoints1, keypoints2, matches1to2, matchesGMS, withRotation, withScale)
        public static void matchGMS(Size size1, Size size2, MatOfKeyPoint keypoints1, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, MatOfDMatch matchesGMS, bool withRotation, bool withScale)
        {
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            if (matchesGMS != null) matchesGMS.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        Mat matches1to2_mat = matches1to2;
        Mat matchesGMS_mat = matchesGMS;
        xfeatures2d_Xfeatures2d_matchGMS_11(size1.width, size1.height, size2.width, size2.height, keypoints1_mat.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, matchesGMS_mat.nativeObj, withRotation, withScale);
        
        return;
#else
            return;
#endif
        }

        //javadoc: matchGMS(size1, size2, keypoints1, keypoints2, matches1to2, matchesGMS, withRotation)
        public static void matchGMS(Size size1, Size size2, MatOfKeyPoint keypoints1, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, MatOfDMatch matchesGMS, bool withRotation)
        {
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            if (matchesGMS != null) matchesGMS.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        Mat matches1to2_mat = matches1to2;
        Mat matchesGMS_mat = matchesGMS;
        xfeatures2d_Xfeatures2d_matchGMS_12(size1.width, size1.height, size2.width, size2.height, keypoints1_mat.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, matchesGMS_mat.nativeObj, withRotation);
        
        return;
#else
            return;
#endif
        }

        //javadoc: matchGMS(size1, size2, keypoints1, keypoints2, matches1to2, matchesGMS)
        public static void matchGMS(Size size1, Size size2, MatOfKeyPoint keypoints1, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, MatOfDMatch matchesGMS)
        {
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            if (matchesGMS != null) matchesGMS.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints1_mat = keypoints1;
        Mat keypoints2_mat = keypoints2;
        Mat matches1to2_mat = matches1to2;
        Mat matchesGMS_mat = matchesGMS;
        xfeatures2d_Xfeatures2d_matchGMS_13(size1.width, size1.height, size2.width, size2.height, keypoints1_mat.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, matchesGMS_mat.nativeObj);
        
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



        // C++:  void cv::xfeatures2d::matchGMS(Size size1, Size size2, vector_KeyPoint keypoints1, vector_KeyPoint keypoints2, vector_DMatch matches1to2, vector_DMatch& matchesGMS, bool withRotation = false, bool withScale = false, double thresholdFactor = 6.0)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_Xfeatures2d_matchGMS_10(double size1_width, double size1_height, double size2_width, double size2_height, IntPtr keypoints1_mat_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr matchesGMS_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool withRotation, [MarshalAs(UnmanagedType.U1)] bool withScale, double thresholdFactor);
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_Xfeatures2d_matchGMS_11(double size1_width, double size1_height, double size2_width, double size2_height, IntPtr keypoints1_mat_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr matchesGMS_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool withRotation, [MarshalAs(UnmanagedType.U1)] bool withScale);
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_Xfeatures2d_matchGMS_12(double size1_width, double size1_height, double size2_width, double size2_height, IntPtr keypoints1_mat_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr matchesGMS_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool withRotation);
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_Xfeatures2d_matchGMS_13(double size1_width, double size1_height, double size2_width, double size2_height, IntPtr keypoints1_mat_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr matchesGMS_mat_nativeObj);

    }
}
