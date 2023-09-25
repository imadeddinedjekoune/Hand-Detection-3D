
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Calib3dModule
{
    // C++: class Calib3d
    //javadoc: Calib3d

    public class Calib3d
    {

        // C++: enum UndistortTypes
        public const int PROJ_SPHERICAL_ORTHO = 0;
        public const int PROJ_SPHERICAL_EQRECT = 1;
        // C++: enum HandEyeCalibrationMethod
        public const int CALIB_HAND_EYE_TSAI = 0;
        public const int CALIB_HAND_EYE_PARK = 1;
        public const int CALIB_HAND_EYE_HORAUD = 2;
        public const int CALIB_HAND_EYE_ANDREFF = 3;
        public const int CALIB_HAND_EYE_DANIILIDIS = 4;
        // C++: enum <unnamed>
        public const int CALIB_USE_INTRINSIC_GUESS = 1;
        public const int CALIB_RECOMPUTE_EXTRINSIC = 2;
        public const int CALIB_CHECK_COND = 4;
        public const int CALIB_FIX_SKEW = 8;
        public const int CALIB_FIX_K1 = 16;
        public const int CALIB_FIX_K2 = 32;
        public const int CALIB_FIX_K3 = 64;
        public const int CALIB_FIX_K4 = 128;
        public const int CALIB_FIX_INTRINSIC = 256;
        public const int CV_ITERATIVE = 0;
        public const int CV_EPNP = 1;
        public const int CV_P3P = 2;
        public const int CV_DLS = 3;
        public const int CvLevMarq_DONE = 0;
        public const int CvLevMarq_STARTED = 1;
        public const int CvLevMarq_CALC_J = 2;
        public const int CvLevMarq_CHECK_ERR = 3;
        public const int LMEDS = 4;
        public const int RANSAC = 8;
        public const int RHO = 16;
        public const int SOLVEPNP_ITERATIVE = 0;
        public const int SOLVEPNP_EPNP = 1;
        public const int SOLVEPNP_P3P = 2;
        public const int SOLVEPNP_DLS = 3;
        public const int SOLVEPNP_UPNP = 4;
        public const int SOLVEPNP_AP3P = 5;
        public const int SOLVEPNP_MAX_COUNT = 5 + 1;
        public const int CALIB_CB_ADAPTIVE_THRESH = 1;
        public const int CALIB_CB_NORMALIZE_IMAGE = 2;
        public const int CALIB_CB_FILTER_QUADS = 4;
        public const int CALIB_CB_FAST_CHECK = 8;
        public const int CALIB_CB_EXHAUSTIVE = 16;
        public const int CALIB_CB_ACCURACY = 32;
        public const int CALIB_CB_SYMMETRIC_GRID = 1;
        public const int CALIB_CB_ASYMMETRIC_GRID = 2;
        public const int CALIB_CB_CLUSTERING = 4;
        public const int CALIB_NINTRINSIC = 18;
        public const int CALIB_FIX_ASPECT_RATIO = 0x00002;
        public const int CALIB_FIX_PRINCIPAL_POINT = 0x00004;
        public const int CALIB_ZERO_TANGENT_DIST = 0x00008;
        public const int CALIB_FIX_FOCAL_LENGTH = 0x00010;
        public const int CALIB_FIX_K5 = 0x01000;
        public const int CALIB_FIX_K6 = 0x02000;
        public const int CALIB_RATIONAL_MODEL = 0x04000;
        public const int CALIB_THIN_PRISM_MODEL = 0x08000;
        public const int CALIB_FIX_S1_S2_S3_S4 = 0x10000;
        public const int CALIB_TILTED_MODEL = 0x40000;
        public const int CALIB_FIX_TAUX_TAUY = 0x80000;
        public const int CALIB_USE_QR = 0x100000;
        public const int CALIB_FIX_TANGENT_DIST = 0x200000;
        public const int CALIB_SAME_FOCAL_LENGTH = 0x00200;
        public const int CALIB_ZERO_DISPARITY = 0x00400;
        public const int CALIB_USE_LU = (1 << 17);
        public const int CALIB_USE_EXTRINSIC_GUESS = (1 << 22);
        public const int FM_7POINT = 1;
        public const int FM_8POINT = 2;
        public const int FM_LMEDS = 4;
        public const int FM_RANSAC = 8;
        public const int fisheye_CALIB_USE_INTRINSIC_GUESS = 1 << 0;
        public const int fisheye_CALIB_RECOMPUTE_EXTRINSIC = 1 << 1;
        public const int fisheye_CALIB_CHECK_COND = 1 << 2;
        public const int fisheye_CALIB_FIX_SKEW = 1 << 3;
        public const int fisheye_CALIB_FIX_K1 = 1 << 4;
        public const int fisheye_CALIB_FIX_K2 = 1 << 5;
        public const int fisheye_CALIB_FIX_K3 = 1 << 6;
        public const int fisheye_CALIB_FIX_K4 = 1 << 7;
        public const int fisheye_CALIB_FIX_INTRINSIC = 1 << 8;
        public const int fisheye_CALIB_FIX_PRINCIPAL_POINT = 1 << 9;
        // C++: enum GridType
        public const int CirclesGridFinderParameters_SYMMETRIC_GRID = 0;
        public const int CirclesGridFinderParameters_ASYMMETRIC_GRID = 1;
        //
        // C++:  Mat cv::estimateAffine2D(Mat from, Mat to, Mat& inliers = Mat(), int method = RANSAC, double ransacReprojThreshold = 3, size_t maxIters = 2000, double confidence = 0.99, size_t refineIters = 10)
        //

        //javadoc: estimateAffine2D(from, to, inliers, method, ransacReprojThreshold, maxIters, confidence, refineIters)
        public static Mat estimateAffine2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, long maxIters, double confidence, long refineIters)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffine2D_10(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold, maxIters, confidence, refineIters));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: estimateAffine2D(from, to, inliers, method, ransacReprojThreshold, maxIters, confidence)
        public static Mat estimateAffine2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, long maxIters, double confidence)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffine2D_11(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold, maxIters, confidence));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: estimateAffine2D(from, to, inliers, method, ransacReprojThreshold, maxIters)
        public static Mat estimateAffine2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, long maxIters)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffine2D_12(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold, maxIters));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: estimateAffine2D(from, to, inliers, method, ransacReprojThreshold)
        public static Mat estimateAffine2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffine2D_13(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: estimateAffine2D(from, to, inliers, method)
        public static Mat estimateAffine2D(Mat from, Mat to, Mat inliers, int method)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffine2D_14(from.nativeObj, to.nativeObj, inliers.nativeObj, method));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: estimateAffine2D(from, to, inliers)
        public static Mat estimateAffine2D(Mat from, Mat to, Mat inliers)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffine2D_15(from.nativeObj, to.nativeObj, inliers.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: estimateAffine2D(from, to)
        public static Mat estimateAffine2D(Mat from, Mat to)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffine2D_16(from.nativeObj, to.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::estimateAffinePartial2D(Mat from, Mat to, Mat& inliers = Mat(), int method = RANSAC, double ransacReprojThreshold = 3, size_t maxIters = 2000, double confidence = 0.99, size_t refineIters = 10)
        //

        //javadoc: estimateAffinePartial2D(from, to, inliers, method, ransacReprojThreshold, maxIters, confidence, refineIters)
        public static Mat estimateAffinePartial2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, long maxIters, double confidence, long refineIters)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffinePartial2D_10(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold, maxIters, confidence, refineIters));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: estimateAffinePartial2D(from, to, inliers, method, ransacReprojThreshold, maxIters, confidence)
        public static Mat estimateAffinePartial2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, long maxIters, double confidence)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffinePartial2D_11(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold, maxIters, confidence));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: estimateAffinePartial2D(from, to, inliers, method, ransacReprojThreshold, maxIters)
        public static Mat estimateAffinePartial2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, long maxIters)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffinePartial2D_12(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold, maxIters));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: estimateAffinePartial2D(from, to, inliers, method, ransacReprojThreshold)
        public static Mat estimateAffinePartial2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffinePartial2D_13(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: estimateAffinePartial2D(from, to, inliers, method)
        public static Mat estimateAffinePartial2D(Mat from, Mat to, Mat inliers, int method)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffinePartial2D_14(from.nativeObj, to.nativeObj, inliers.nativeObj, method));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: estimateAffinePartial2D(from, to, inliers)
        public static Mat estimateAffinePartial2D(Mat from, Mat to, Mat inliers)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffinePartial2D_15(from.nativeObj, to.nativeObj, inliers.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: estimateAffinePartial2D(from, to)
        public static Mat estimateAffinePartial2D(Mat from, Mat to)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_estimateAffinePartial2D_16(from.nativeObj, to.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix, int method = RANSAC, double prob = 0.999, double threshold = 1.0, Mat& mask = Mat())
        //

        //javadoc: findEssentialMat(points1, points2, cameraMatrix, method, prob, threshold, mask)
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix, int method, double prob, double threshold, Mat mask)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_findEssentialMat_10(points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, method, prob, threshold, mask.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findEssentialMat(points1, points2, cameraMatrix, method, prob, threshold)
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix, int method, double prob, double threshold)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_findEssentialMat_11(points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, method, prob, threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findEssentialMat(points1, points2, cameraMatrix, method, prob)
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix, int method, double prob)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_findEssentialMat_12(points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, method, prob));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findEssentialMat(points1, points2, cameraMatrix, method)
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix, int method)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_findEssentialMat_13(points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, method));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findEssentialMat(points1, points2, cameraMatrix)
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_findEssentialMat_14(points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::findEssentialMat(Mat points1, Mat points2, double focal = 1.0, Point2d pp = Point2d(0, 0), int method = RANSAC, double prob = 0.999, double threshold = 1.0, Mat& mask = Mat())
        //

        //javadoc: findEssentialMat(points1, points2, focal, pp, method, prob, threshold, mask)
        public static Mat findEssentialMat(Mat points1, Mat points2, double focal, Point pp, int method, double prob, double threshold, Mat mask)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_findEssentialMat_15(points1.nativeObj, points2.nativeObj, focal, pp.x, pp.y, method, prob, threshold, mask.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findEssentialMat(points1, points2, focal, pp, method, prob, threshold)
        public static Mat findEssentialMat(Mat points1, Mat points2, double focal, Point pp, int method, double prob, double threshold)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_findEssentialMat_16(points1.nativeObj, points2.nativeObj, focal, pp.x, pp.y, method, prob, threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findEssentialMat(points1, points2, focal, pp, method, prob)
        public static Mat findEssentialMat(Mat points1, Mat points2, double focal, Point pp, int method, double prob)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_findEssentialMat_17(points1.nativeObj, points2.nativeObj, focal, pp.x, pp.y, method, prob));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findEssentialMat(points1, points2, focal, pp, method)
        public static Mat findEssentialMat(Mat points1, Mat points2, double focal, Point pp, int method)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_findEssentialMat_18(points1.nativeObj, points2.nativeObj, focal, pp.x, pp.y, method));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findEssentialMat(points1, points2, focal, pp)
        public static Mat findEssentialMat(Mat points1, Mat points2, double focal, Point pp)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_findEssentialMat_19(points1.nativeObj, points2.nativeObj, focal, pp.x, pp.y));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findEssentialMat(points1, points2, focal)
        public static Mat findEssentialMat(Mat points1, Mat points2, double focal)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_findEssentialMat_110(points1.nativeObj, points2.nativeObj, focal));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findEssentialMat(points1, points2)
        public static Mat findEssentialMat(Mat points1, Mat points2)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_findEssentialMat_111(points1.nativeObj, points2.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::findFundamentalMat(vector_Point2f points1, vector_Point2f points2, int method = FM_RANSAC, double ransacReprojThreshold = 3., double confidence = 0.99, Mat& mask = Mat())
        //

        //javadoc: findFundamentalMat(points1, points2, method, ransacReprojThreshold, confidence, mask)
        public static Mat findFundamentalMat(MatOfPoint2f points1, MatOfPoint2f points2, int method, double ransacReprojThreshold, double confidence, Mat mask)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat points1_mat = points1;
        Mat points2_mat = points2;
        Mat retVal = new Mat(calib3d_Calib3d_findFundamentalMat_10(points1_mat.nativeObj, points2_mat.nativeObj, method, ransacReprojThreshold, confidence, mask.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findFundamentalMat(points1, points2, method, ransacReprojThreshold, confidence)
        public static Mat findFundamentalMat(MatOfPoint2f points1, MatOfPoint2f points2, int method, double ransacReprojThreshold, double confidence)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat points1_mat = points1;
        Mat points2_mat = points2;
        Mat retVal = new Mat(calib3d_Calib3d_findFundamentalMat_11(points1_mat.nativeObj, points2_mat.nativeObj, method, ransacReprojThreshold, confidence));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findFundamentalMat(points1, points2, method, ransacReprojThreshold)
        public static Mat findFundamentalMat(MatOfPoint2f points1, MatOfPoint2f points2, int method, double ransacReprojThreshold)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat points1_mat = points1;
        Mat points2_mat = points2;
        Mat retVal = new Mat(calib3d_Calib3d_findFundamentalMat_12(points1_mat.nativeObj, points2_mat.nativeObj, method, ransacReprojThreshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findFundamentalMat(points1, points2, method)
        public static Mat findFundamentalMat(MatOfPoint2f points1, MatOfPoint2f points2, int method)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat points1_mat = points1;
        Mat points2_mat = points2;
        Mat retVal = new Mat(calib3d_Calib3d_findFundamentalMat_13(points1_mat.nativeObj, points2_mat.nativeObj, method));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findFundamentalMat(points1, points2)
        public static Mat findFundamentalMat(MatOfPoint2f points1, MatOfPoint2f points2)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat points1_mat = points1;
        Mat points2_mat = points2;
        Mat retVal = new Mat(calib3d_Calib3d_findFundamentalMat_14(points1_mat.nativeObj, points2_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::findHomography(vector_Point2f srcPoints, vector_Point2f dstPoints, int method = 0, double ransacReprojThreshold = 3, Mat& mask = Mat(), int maxIters = 2000, double confidence = 0.995)
        //

        //javadoc: findHomography(srcPoints, dstPoints, method, ransacReprojThreshold, mask, maxIters, confidence)
        public static Mat findHomography(MatOfPoint2f srcPoints, MatOfPoint2f dstPoints, int method, double ransacReprojThreshold, Mat mask, int maxIters, double confidence)
        {
            if (srcPoints != null) srcPoints.ThrowIfDisposed();
            if (dstPoints != null) dstPoints.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcPoints_mat = srcPoints;
        Mat dstPoints_mat = dstPoints;
        Mat retVal = new Mat(calib3d_Calib3d_findHomography_10(srcPoints_mat.nativeObj, dstPoints_mat.nativeObj, method, ransacReprojThreshold, mask.nativeObj, maxIters, confidence));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findHomography(srcPoints, dstPoints, method, ransacReprojThreshold, mask, maxIters)
        public static Mat findHomography(MatOfPoint2f srcPoints, MatOfPoint2f dstPoints, int method, double ransacReprojThreshold, Mat mask, int maxIters)
        {
            if (srcPoints != null) srcPoints.ThrowIfDisposed();
            if (dstPoints != null) dstPoints.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcPoints_mat = srcPoints;
        Mat dstPoints_mat = dstPoints;
        Mat retVal = new Mat(calib3d_Calib3d_findHomography_11(srcPoints_mat.nativeObj, dstPoints_mat.nativeObj, method, ransacReprojThreshold, mask.nativeObj, maxIters));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findHomography(srcPoints, dstPoints, method, ransacReprojThreshold, mask)
        public static Mat findHomography(MatOfPoint2f srcPoints, MatOfPoint2f dstPoints, int method, double ransacReprojThreshold, Mat mask)
        {
            if (srcPoints != null) srcPoints.ThrowIfDisposed();
            if (dstPoints != null) dstPoints.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcPoints_mat = srcPoints;
        Mat dstPoints_mat = dstPoints;
        Mat retVal = new Mat(calib3d_Calib3d_findHomography_12(srcPoints_mat.nativeObj, dstPoints_mat.nativeObj, method, ransacReprojThreshold, mask.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findHomography(srcPoints, dstPoints, method, ransacReprojThreshold)
        public static Mat findHomography(MatOfPoint2f srcPoints, MatOfPoint2f dstPoints, int method, double ransacReprojThreshold)
        {
            if (srcPoints != null) srcPoints.ThrowIfDisposed();
            if (dstPoints != null) dstPoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcPoints_mat = srcPoints;
        Mat dstPoints_mat = dstPoints;
        Mat retVal = new Mat(calib3d_Calib3d_findHomography_13(srcPoints_mat.nativeObj, dstPoints_mat.nativeObj, method, ransacReprojThreshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findHomography(srcPoints, dstPoints, method)
        public static Mat findHomography(MatOfPoint2f srcPoints, MatOfPoint2f dstPoints, int method)
        {
            if (srcPoints != null) srcPoints.ThrowIfDisposed();
            if (dstPoints != null) dstPoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcPoints_mat = srcPoints;
        Mat dstPoints_mat = dstPoints;
        Mat retVal = new Mat(calib3d_Calib3d_findHomography_14(srcPoints_mat.nativeObj, dstPoints_mat.nativeObj, method));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: findHomography(srcPoints, dstPoints)
        public static Mat findHomography(MatOfPoint2f srcPoints, MatOfPoint2f dstPoints)
        {
            if (srcPoints != null) srcPoints.ThrowIfDisposed();
            if (dstPoints != null) dstPoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcPoints_mat = srcPoints;
        Mat dstPoints_mat = dstPoints;
        Mat retVal = new Mat(calib3d_Calib3d_findHomography_15(srcPoints_mat.nativeObj, dstPoints_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::getDefaultNewCameraMatrix(Mat cameraMatrix, Size imgsize = Size(), bool centerPrincipalPoint = false)
        //

        //javadoc: getDefaultNewCameraMatrix(cameraMatrix, imgsize, centerPrincipalPoint)
        public static Mat getDefaultNewCameraMatrix(Mat cameraMatrix, Size imgsize, bool centerPrincipalPoint)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_getDefaultNewCameraMatrix_10(cameraMatrix.nativeObj, imgsize.width, imgsize.height, centerPrincipalPoint));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: getDefaultNewCameraMatrix(cameraMatrix, imgsize)
        public static Mat getDefaultNewCameraMatrix(Mat cameraMatrix, Size imgsize)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_getDefaultNewCameraMatrix_11(cameraMatrix.nativeObj, imgsize.width, imgsize.height));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: getDefaultNewCameraMatrix(cameraMatrix)
        public static Mat getDefaultNewCameraMatrix(Mat cameraMatrix)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_getDefaultNewCameraMatrix_12(cameraMatrix.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::getOptimalNewCameraMatrix(Mat cameraMatrix, Mat distCoeffs, Size imageSize, double alpha, Size newImgSize = Size(), Rect* validPixROI = 0, bool centerPrincipalPoint = false)
        //

        //javadoc: getOptimalNewCameraMatrix(cameraMatrix, distCoeffs, imageSize, alpha, newImgSize, validPixROI, centerPrincipalPoint)
        public static Mat getOptimalNewCameraMatrix(Mat cameraMatrix, Mat distCoeffs, Size imageSize, double alpha, Size newImgSize, Rect validPixROI, bool centerPrincipalPoint)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        double[] validPixROI_out = new double[4];
        Mat retVal = new Mat(calib3d_Calib3d_getOptimalNewCameraMatrix_10(cameraMatrix.nativeObj, distCoeffs.nativeObj, imageSize.width, imageSize.height, alpha, newImgSize.width, newImgSize.height, validPixROI_out, centerPrincipalPoint));
        if(validPixROI!=null){ validPixROI.x = (int)validPixROI_out[0]; validPixROI.y = (int)validPixROI_out[1]; validPixROI.width = (int)validPixROI_out[2]; validPixROI.height = (int)validPixROI_out[3]; } 
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: getOptimalNewCameraMatrix(cameraMatrix, distCoeffs, imageSize, alpha, newImgSize, validPixROI)
        public static Mat getOptimalNewCameraMatrix(Mat cameraMatrix, Mat distCoeffs, Size imageSize, double alpha, Size newImgSize, Rect validPixROI)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        double[] validPixROI_out = new double[4];
        Mat retVal = new Mat(calib3d_Calib3d_getOptimalNewCameraMatrix_11(cameraMatrix.nativeObj, distCoeffs.nativeObj, imageSize.width, imageSize.height, alpha, newImgSize.width, newImgSize.height, validPixROI_out));
        if(validPixROI!=null){ validPixROI.x = (int)validPixROI_out[0]; validPixROI.y = (int)validPixROI_out[1]; validPixROI.width = (int)validPixROI_out[2]; validPixROI.height = (int)validPixROI_out[3]; } 
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: getOptimalNewCameraMatrix(cameraMatrix, distCoeffs, imageSize, alpha, newImgSize)
        public static Mat getOptimalNewCameraMatrix(Mat cameraMatrix, Mat distCoeffs, Size imageSize, double alpha, Size newImgSize)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_getOptimalNewCameraMatrix_12(cameraMatrix.nativeObj, distCoeffs.nativeObj, imageSize.width, imageSize.height, alpha, newImgSize.width, newImgSize.height));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: getOptimalNewCameraMatrix(cameraMatrix, distCoeffs, imageSize, alpha)
        public static Mat getOptimalNewCameraMatrix(Mat cameraMatrix, Mat distCoeffs, Size imageSize, double alpha)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(calib3d_Calib3d_getOptimalNewCameraMatrix_13(cameraMatrix.nativeObj, distCoeffs.nativeObj, imageSize.width, imageSize.height, alpha));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::initCameraMatrix2D(vector_vector_Point3f objectPoints, vector_vector_Point2f imagePoints, Size imageSize, double aspectRatio = 1.0)
        //

        //javadoc: initCameraMatrix2D(objectPoints, imagePoints, imageSize, aspectRatio)
        public static Mat initCameraMatrix2D(List<MatOfPoint3f> objectPoints, List<MatOfPoint2f> imagePoints, Size imageSize, double aspectRatio)
        {
#if UNITY_5_3_OR_NEWER
        List<Mat> objectPoints_tmplm = new List<Mat>((objectPoints != null) ? objectPoints.Count : 0);
        Mat objectPoints_mat = Converters.vector_vector_Point3f_to_Mat(objectPoints, objectPoints_tmplm);
        List<Mat> imagePoints_tmplm = new List<Mat>((imagePoints != null) ? imagePoints.Count : 0);
        Mat imagePoints_mat = Converters.vector_vector_Point2f_to_Mat(imagePoints, imagePoints_tmplm);
        Mat retVal = new Mat(calib3d_Calib3d_initCameraMatrix2D_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, aspectRatio));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: initCameraMatrix2D(objectPoints, imagePoints, imageSize)
        public static Mat initCameraMatrix2D(List<MatOfPoint3f> objectPoints, List<MatOfPoint2f> imagePoints, Size imageSize)
        {
#if UNITY_5_3_OR_NEWER
        List<Mat> objectPoints_tmplm = new List<Mat>((objectPoints != null) ? objectPoints.Count : 0);
        Mat objectPoints_mat = Converters.vector_vector_Point3f_to_Mat(objectPoints, objectPoints_tmplm);
        List<Mat> imagePoints_tmplm = new List<Mat>((imagePoints != null) ? imagePoints.Count : 0);
        Mat imagePoints_mat = Converters.vector_vector_Point2f_to_Mat(imagePoints, imagePoints_tmplm);
        Mat retVal = new Mat(calib3d_Calib3d_initCameraMatrix2D_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Rect cv::getValidDisparityROI(Rect roi1, Rect roi2, int minDisparity, int numberOfDisparities, int SADWindowSize)
        //

        //javadoc: getValidDisparityROI(roi1, roi2, minDisparity, numberOfDisparities, SADWindowSize)
        public static Rect getValidDisparityROI(Rect roi1, Rect roi2, int minDisparity, int numberOfDisparities, int SADWindowSize)
        {
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[4];
calib3d_Calib3d_getValidDisparityROI_10(roi1.x, roi1.y, roi1.width, roi1.height, roi2.x, roi2.y, roi2.width, roi2.height, minDisparity, numberOfDisparities, SADWindowSize, tmpArray);
Rect retVal = new Rect (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Vec3d cv::RQDecomp3x3(Mat src, Mat& mtxR, Mat& mtxQ, Mat& Qx = Mat(), Mat& Qy = Mat(), Mat& Qz = Mat())
        //

        //javadoc: RQDecomp3x3(src, mtxR, mtxQ, Qx, Qy, Qz)
        public static double[] RQDecomp3x3(Mat src, Mat mtxR, Mat mtxQ, Mat Qx, Mat Qy, Mat Qz)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mtxR != null) mtxR.ThrowIfDisposed();
            if (mtxQ != null) mtxQ.ThrowIfDisposed();
            if (Qx != null) Qx.ThrowIfDisposed();
            if (Qy != null) Qy.ThrowIfDisposed();
            if (Qz != null) Qz.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] retVal = new double[3];
calib3d_Calib3d_RQDecomp3x3_10(src.nativeObj, mtxR.nativeObj, mtxQ.nativeObj, Qx.nativeObj, Qy.nativeObj, Qz.nativeObj, retVal);
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RQDecomp3x3(src, mtxR, mtxQ, Qx, Qy)
        public static double[] RQDecomp3x3(Mat src, Mat mtxR, Mat mtxQ, Mat Qx, Mat Qy)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mtxR != null) mtxR.ThrowIfDisposed();
            if (mtxQ != null) mtxQ.ThrowIfDisposed();
            if (Qx != null) Qx.ThrowIfDisposed();
            if (Qy != null) Qy.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] retVal = new double[3];
calib3d_Calib3d_RQDecomp3x3_11(src.nativeObj, mtxR.nativeObj, mtxQ.nativeObj, Qx.nativeObj, Qy.nativeObj, retVal);
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RQDecomp3x3(src, mtxR, mtxQ, Qx)
        public static double[] RQDecomp3x3(Mat src, Mat mtxR, Mat mtxQ, Mat Qx)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mtxR != null) mtxR.ThrowIfDisposed();
            if (mtxQ != null) mtxQ.ThrowIfDisposed();
            if (Qx != null) Qx.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] retVal = new double[3];
calib3d_Calib3d_RQDecomp3x3_12(src.nativeObj, mtxR.nativeObj, mtxQ.nativeObj, Qx.nativeObj, retVal);
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RQDecomp3x3(src, mtxR, mtxQ)
        public static double[] RQDecomp3x3(Mat src, Mat mtxR, Mat mtxQ)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mtxR != null) mtxR.ThrowIfDisposed();
            if (mtxQ != null) mtxQ.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] retVal = new double[3];
calib3d_Calib3d_RQDecomp3x3_13(src.nativeObj, mtxR.nativeObj, mtxQ.nativeObj, retVal);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::checkChessboard(Mat img, Size size)
        //

        //javadoc: checkChessboard(img, size)
        public static bool checkChessboard(Mat img, Size size)
        {
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = calib3d_Calib3d_checkChessboard_10(img.nativeObj, size.width, size.height);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::findChessboardCorners(Mat image, Size patternSize, vector_Point2f& corners, int flags = CALIB_CB_ADAPTIVE_THRESH + CALIB_CB_NORMALIZE_IMAGE)
        //

        //javadoc: findChessboardCorners(image, patternSize, corners, flags)
        public static bool findChessboardCorners(Mat image, Size patternSize, MatOfPoint2f corners, int flags)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = corners;
        bool retVal = calib3d_Calib3d_findChessboardCorners_10(image.nativeObj, patternSize.width, patternSize.height, corners_mat.nativeObj, flags);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: findChessboardCorners(image, patternSize, corners)
        public static bool findChessboardCorners(Mat image, Size patternSize, MatOfPoint2f corners)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = corners;
        bool retVal = calib3d_Calib3d_findChessboardCorners_11(image.nativeObj, patternSize.width, patternSize.height, corners_mat.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::findChessboardCornersSB(Mat image, Size patternSize, Mat& corners, int flags = 0)
        //

        //javadoc: findChessboardCornersSB(image, patternSize, corners, flags)
        public static bool findChessboardCornersSB(Mat image, Size patternSize, Mat corners, int flags)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = calib3d_Calib3d_findChessboardCornersSB_10(image.nativeObj, patternSize.width, patternSize.height, corners.nativeObj, flags);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: findChessboardCornersSB(image, patternSize, corners)
        public static bool findChessboardCornersSB(Mat image, Size patternSize, Mat corners)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = calib3d_Calib3d_findChessboardCornersSB_11(image.nativeObj, patternSize.width, patternSize.height, corners.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::findCirclesGrid(Mat image, Size patternSize, Mat& centers, int flags, Ptr_FeatureDetector blobDetector, CirclesGridFinderParameters parameters)
        //

        // Unknown type 'Ptr_FeatureDetector' (I), skipping the function


        //
        // C++:  bool cv::findCirclesGrid(Mat image, Size patternSize, Mat& centers, int flags = CALIB_CB_SYMMETRIC_GRID, Ptr_FeatureDetector blobDetector = SimpleBlobDetector::create())
        //

        //javadoc: findCirclesGrid(image, patternSize, centers, flags)
        public static bool findCirclesGrid(Mat image, Size patternSize, Mat centers, int flags)
        {
            if (image != null) image.ThrowIfDisposed();
            if (centers != null) centers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = calib3d_Calib3d_findCirclesGrid_10(image.nativeObj, patternSize.width, patternSize.height, centers.nativeObj, flags);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: findCirclesGrid(image, patternSize, centers)
        public static bool findCirclesGrid(Mat image, Size patternSize, Mat centers)
        {
            if (image != null) image.ThrowIfDisposed();
            if (centers != null) centers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = calib3d_Calib3d_findCirclesGrid_12(image.nativeObj, patternSize.width, patternSize.height, centers.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::solvePnP(vector_Point3f objectPoints, vector_Point2f imagePoints, Mat cameraMatrix, vector_double distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false, int flags = SOLVEPNP_ITERATIVE)
        //

        //javadoc: solvePnP(objectPoints, imagePoints, cameraMatrix, distCoeffs, rvec, tvec, useExtrinsicGuess, flags)
        public static bool solvePnP(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int flags)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat imagePoints_mat = imagePoints;
        Mat distCoeffs_mat = distCoeffs;
        bool retVal = calib3d_Calib3d_solvePnP_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, flags);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: solvePnP(objectPoints, imagePoints, cameraMatrix, distCoeffs, rvec, tvec, useExtrinsicGuess)
        public static bool solvePnP(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat imagePoints_mat = imagePoints;
        Mat distCoeffs_mat = distCoeffs;
        bool retVal = calib3d_Calib3d_solvePnP_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: solvePnP(objectPoints, imagePoints, cameraMatrix, distCoeffs, rvec, tvec)
        public static bool solvePnP(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat imagePoints_mat = imagePoints;
        Mat distCoeffs_mat = distCoeffs;
        bool retVal = calib3d_Calib3d_solvePnP_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::solvePnPRansac(vector_Point3f objectPoints, vector_Point2f imagePoints, Mat cameraMatrix, vector_double distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false, int iterationsCount = 100, float reprojectionError = 8.0, double confidence = 0.99, Mat& inliers = Mat(), int flags = SOLVEPNP_ITERATIVE)
        //

        //javadoc: solvePnPRansac(objectPoints, imagePoints, cameraMatrix, distCoeffs, rvec, tvec, useExtrinsicGuess, iterationsCount, reprojectionError, confidence, inliers, flags)
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence, Mat inliers, int flags)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat imagePoints_mat = imagePoints;
        Mat distCoeffs_mat = distCoeffs;
        bool retVal = calib3d_Calib3d_solvePnPRansac_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, iterationsCount, reprojectionError, confidence, inliers.nativeObj, flags);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: solvePnPRansac(objectPoints, imagePoints, cameraMatrix, distCoeffs, rvec, tvec, useExtrinsicGuess, iterationsCount, reprojectionError, confidence, inliers)
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence, Mat inliers)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat imagePoints_mat = imagePoints;
        Mat distCoeffs_mat = distCoeffs;
        bool retVal = calib3d_Calib3d_solvePnPRansac_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, iterationsCount, reprojectionError, confidence, inliers.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: solvePnPRansac(objectPoints, imagePoints, cameraMatrix, distCoeffs, rvec, tvec, useExtrinsicGuess, iterationsCount, reprojectionError, confidence)
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat imagePoints_mat = imagePoints;
        Mat distCoeffs_mat = distCoeffs;
        bool retVal = calib3d_Calib3d_solvePnPRansac_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, iterationsCount, reprojectionError, confidence);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: solvePnPRansac(objectPoints, imagePoints, cameraMatrix, distCoeffs, rvec, tvec, useExtrinsicGuess, iterationsCount, reprojectionError)
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat imagePoints_mat = imagePoints;
        Mat distCoeffs_mat = distCoeffs;
        bool retVal = calib3d_Calib3d_solvePnPRansac_13(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, iterationsCount, reprojectionError);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: solvePnPRansac(objectPoints, imagePoints, cameraMatrix, distCoeffs, rvec, tvec, useExtrinsicGuess, iterationsCount)
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat imagePoints_mat = imagePoints;
        Mat distCoeffs_mat = distCoeffs;
        bool retVal = calib3d_Calib3d_solvePnPRansac_14(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, iterationsCount);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: solvePnPRansac(objectPoints, imagePoints, cameraMatrix, distCoeffs, rvec, tvec, useExtrinsicGuess)
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat imagePoints_mat = imagePoints;
        Mat distCoeffs_mat = distCoeffs;
        bool retVal = calib3d_Calib3d_solvePnPRansac_15(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: solvePnPRansac(objectPoints, imagePoints, cameraMatrix, distCoeffs, rvec, tvec)
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat imagePoints_mat = imagePoints;
        Mat distCoeffs_mat = distCoeffs;
        bool retVal = calib3d_Calib3d_solvePnPRansac_16(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::stereoRectifyUncalibrated(Mat points1, Mat points2, Mat F, Size imgSize, Mat& H1, Mat& H2, double threshold = 5)
        //

        //javadoc: stereoRectifyUncalibrated(points1, points2, F, imgSize, H1, H2, threshold)
        public static bool stereoRectifyUncalibrated(Mat points1, Mat points2, Mat F, Size imgSize, Mat H1, Mat H2, double threshold)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (H1 != null) H1.ThrowIfDisposed();
            if (H2 != null) H2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = calib3d_Calib3d_stereoRectifyUncalibrated_10(points1.nativeObj, points2.nativeObj, F.nativeObj, imgSize.width, imgSize.height, H1.nativeObj, H2.nativeObj, threshold);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: stereoRectifyUncalibrated(points1, points2, F, imgSize, H1, H2)
        public static bool stereoRectifyUncalibrated(Mat points1, Mat points2, Mat F, Size imgSize, Mat H1, Mat H2)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (H1 != null) H1.ThrowIfDisposed();
            if (H2 != null) H2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = calib3d_Calib3d_stereoRectifyUncalibrated_11(points1.nativeObj, points2.nativeObj, F.nativeObj, imgSize.width, imgSize.height, H1.nativeObj, H2.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  double cv::calibrateCamera(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        //

        //javadoc: calibrateCameraExtended(objectPoints, imagePoints, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, stdDeviationsIntrinsics, stdDeviationsExtrinsics, perViewErrors, flags, criteria)
        public static double calibrateCameraExtended(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors, int flags, TermCriteria criteria)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_calibrateCameraExtended_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, perViewErrors.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraExtended(objectPoints, imagePoints, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, stdDeviationsIntrinsics, stdDeviationsExtrinsics, perViewErrors, flags)
        public static double calibrateCameraExtended(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors, int flags)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_calibrateCameraExtended_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, perViewErrors.nativeObj, flags);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraExtended(objectPoints, imagePoints, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, stdDeviationsIntrinsics, stdDeviationsExtrinsics, perViewErrors)
        public static double calibrateCameraExtended(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_calibrateCameraExtended_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, perViewErrors.nativeObj);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::calibrateCamera(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        //

        //javadoc: calibrateCamera(objectPoints, imagePoints, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, flags, criteria)
        public static double calibrateCamera(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, int flags, TermCriteria criteria)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_calibrateCamera_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCamera(objectPoints, imagePoints, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, flags)
        public static double calibrateCamera(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, int flags)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_calibrateCamera_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCamera(objectPoints, imagePoints, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs)
        public static double calibrateCamera(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_calibrateCamera_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::calibrateCameraRO(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, int iFixedPoint, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& newObjPoints, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& stdDeviationsObjPoints, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        //

        //javadoc: calibrateCameraROExtended(objectPoints, imagePoints, imageSize, iFixedPoint, cameraMatrix, distCoeffs, rvecs, tvecs, newObjPoints, stdDeviationsIntrinsics, stdDeviationsExtrinsics, stdDeviationsObjPoints, perViewErrors, flags, criteria)
        public static double calibrateCameraROExtended(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat newObjPoints, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat stdDeviationsObjPoints, Mat perViewErrors, int flags, TermCriteria criteria)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newObjPoints != null) newObjPoints.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (stdDeviationsObjPoints != null) stdDeviationsObjPoints.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_calibrateCameraROExtended_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, iFixedPoint, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, newObjPoints.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, stdDeviationsObjPoints.nativeObj, perViewErrors.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraROExtended(objectPoints, imagePoints, imageSize, iFixedPoint, cameraMatrix, distCoeffs, rvecs, tvecs, newObjPoints, stdDeviationsIntrinsics, stdDeviationsExtrinsics, stdDeviationsObjPoints, perViewErrors, flags)
        public static double calibrateCameraROExtended(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat newObjPoints, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat stdDeviationsObjPoints, Mat perViewErrors, int flags)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newObjPoints != null) newObjPoints.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (stdDeviationsObjPoints != null) stdDeviationsObjPoints.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_calibrateCameraROExtended_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, iFixedPoint, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, newObjPoints.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, stdDeviationsObjPoints.nativeObj, perViewErrors.nativeObj, flags);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraROExtended(objectPoints, imagePoints, imageSize, iFixedPoint, cameraMatrix, distCoeffs, rvecs, tvecs, newObjPoints, stdDeviationsIntrinsics, stdDeviationsExtrinsics, stdDeviationsObjPoints, perViewErrors)
        public static double calibrateCameraROExtended(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat newObjPoints, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat stdDeviationsObjPoints, Mat perViewErrors)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newObjPoints != null) newObjPoints.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (stdDeviationsObjPoints != null) stdDeviationsObjPoints.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_calibrateCameraROExtended_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, iFixedPoint, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, newObjPoints.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, stdDeviationsObjPoints.nativeObj, perViewErrors.nativeObj);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::calibrateCameraRO(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, int iFixedPoint, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& newObjPoints, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        //

        //javadoc: calibrateCameraRO(objectPoints, imagePoints, imageSize, iFixedPoint, cameraMatrix, distCoeffs, rvecs, tvecs, newObjPoints, flags, criteria)
        public static double calibrateCameraRO(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat newObjPoints, int flags, TermCriteria criteria)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newObjPoints != null) newObjPoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_calibrateCameraRO_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, iFixedPoint, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, newObjPoints.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraRO(objectPoints, imagePoints, imageSize, iFixedPoint, cameraMatrix, distCoeffs, rvecs, tvecs, newObjPoints, flags)
        public static double calibrateCameraRO(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat newObjPoints, int flags)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newObjPoints != null) newObjPoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_calibrateCameraRO_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, iFixedPoint, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, newObjPoints.nativeObj, flags);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraRO(objectPoints, imagePoints, imageSize, iFixedPoint, cameraMatrix, distCoeffs, rvecs, tvecs, newObjPoints)
        public static double calibrateCameraRO(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat newObjPoints)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newObjPoints != null) newObjPoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_calibrateCameraRO_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, iFixedPoint, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, newObjPoints.nativeObj);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::sampsonDistance(Mat pt1, Mat pt2, Mat F)
        //

        //javadoc: sampsonDistance(pt1, pt2, F)
        public static double sampsonDistance(Mat pt1, Mat pt2, Mat F)
        {
            if (pt1 != null) pt1.ThrowIfDisposed();
            if (pt2 != null) pt2.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = calib3d_Calib3d_sampsonDistance_10(pt1.nativeObj, pt2.nativeObj, F.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& cameraMatrix1, Mat& distCoeffs1, Mat& cameraMatrix2, Mat& distCoeffs2, Size imageSize, Mat& R, Mat& T, Mat& E, Mat& F, Mat& perViewErrors, int flags = CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 1e-6))
        //

        //javadoc: stereoCalibrateExtended(objectPoints, imagePoints1, imagePoints2, cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, imageSize, R, T, E, F, perViewErrors, flags, criteria)
        public static double stereoCalibrateExtended(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F, Mat perViewErrors, int flags, TermCriteria criteria)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
        Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
        double retVal = calib3d_Calib3d_stereoCalibrateExtended_10(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj, perViewErrors.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: stereoCalibrateExtended(objectPoints, imagePoints1, imagePoints2, cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, imageSize, R, T, E, F, perViewErrors, flags)
        public static double stereoCalibrateExtended(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F, Mat perViewErrors, int flags)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
        Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
        double retVal = calib3d_Calib3d_stereoCalibrateExtended_11(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj, perViewErrors.nativeObj, flags);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: stereoCalibrateExtended(objectPoints, imagePoints1, imagePoints2, cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, imageSize, R, T, E, F, perViewErrors)
        public static double stereoCalibrateExtended(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F, Mat perViewErrors)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
        Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
        double retVal = calib3d_Calib3d_stereoCalibrateExtended_12(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj, perViewErrors.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& cameraMatrix1, Mat& distCoeffs1, Mat& cameraMatrix2, Mat& distCoeffs2, Size imageSize, Mat& R, Mat& T, Mat& E, Mat& F, int flags = CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 1e-6))
        //

        //javadoc: stereoCalibrate(objectPoints, imagePoints1, imagePoints2, cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, imageSize, R, T, E, F, flags, criteria)
        public static double stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F, int flags, TermCriteria criteria)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
        Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
        double retVal = calib3d_Calib3d_stereoCalibrate_10(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: stereoCalibrate(objectPoints, imagePoints1, imagePoints2, cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, imageSize, R, T, E, F, flags)
        public static double stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F, int flags)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
        Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
        double retVal = calib3d_Calib3d_stereoCalibrate_11(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj, flags);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: stereoCalibrate(objectPoints, imagePoints1, imagePoints2, cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, imageSize, R, T, E, F)
        public static double stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
        Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
        double retVal = calib3d_Calib3d_stereoCalibrate_12(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::fisheye::calibrate(vector_Mat objectPoints, vector_Mat imagePoints, Size image_size, Mat& K, Mat& D, vector_Mat& rvecs, vector_Mat& tvecs, int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 100, DBL_EPSILON))
        //

        //javadoc: fisheye_calibrate(objectPoints, imagePoints, image_size, K, D, rvecs, tvecs, flags, criteria)
        public static double fisheye_calibrate(List<Mat> objectPoints, List<Mat> imagePoints, Size image_size, Mat K, Mat D, List<Mat> rvecs, List<Mat> tvecs, int flags, TermCriteria criteria)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_fisheye_1calibrate_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, image_size.width, image_size.height, K.nativeObj, D.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: fisheye_calibrate(objectPoints, imagePoints, image_size, K, D, rvecs, tvecs, flags)
        public static double fisheye_calibrate(List<Mat> objectPoints, List<Mat> imagePoints, Size image_size, Mat K, Mat D, List<Mat> rvecs, List<Mat> tvecs, int flags)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_fisheye_1calibrate_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, image_size.width, image_size.height, K.nativeObj, D.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: fisheye_calibrate(objectPoints, imagePoints, image_size, K, D, rvecs, tvecs)
        public static double fisheye_calibrate(List<Mat> objectPoints, List<Mat> imagePoints, Size image_size, Mat K, Mat D, List<Mat> rvecs, List<Mat> tvecs)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = calib3d_Calib3d_fisheye_1calibrate_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, image_size.width, image_size.height, K.nativeObj, D.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::fisheye::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& K1, Mat& D1, Mat& K2, Mat& D2, Size imageSize, Mat& R, Mat& T, int flags = fisheye::CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 100, DBL_EPSILON))
        //

        //javadoc: fisheye_stereoCalibrate(objectPoints, imagePoints1, imagePoints2, K1, D1, K2, D2, imageSize, R, T, flags, criteria)
        public static double fisheye_stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat T, int flags, TermCriteria criteria)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
        Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
        double retVal = calib3d_Calib3d_fisheye_1stereoCalibrate_10(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: fisheye_stereoCalibrate(objectPoints, imagePoints1, imagePoints2, K1, D1, K2, D2, imageSize, R, T, flags)
        public static double fisheye_stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat T, int flags)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
        Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
        double retVal = calib3d_Calib3d_fisheye_1stereoCalibrate_11(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, flags);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: fisheye_stereoCalibrate(objectPoints, imagePoints1, imagePoints2, K1, D1, K2, D2, imageSize, R, T)
        public static double fisheye_stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat T)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
        Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
        double retVal = calib3d_Calib3d_fisheye_1stereoCalibrate_12(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::rectify3Collinear(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat cameraMatrix3, Mat distCoeffs3, vector_Mat imgpt1, vector_Mat imgpt3, Size imageSize, Mat R12, Mat T12, Mat R13, Mat T13, Mat& R1, Mat& R2, Mat& R3, Mat& P1, Mat& P2, Mat& P3, Mat& Q, double alpha, Size newImgSize, Rect* roi1, Rect* roi2, int flags)
        //

        //javadoc: rectify3Collinear(cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, cameraMatrix3, distCoeffs3, imgpt1, imgpt3, imageSize, R12, T12, R13, T13, R1, R2, R3, P1, P2, P3, Q, alpha, newImgSize, roi1, roi2, flags)
        public static float rectify3Collinear(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat cameraMatrix3, Mat distCoeffs3, List<Mat> imgpt1, List<Mat> imgpt3, Size imageSize, Mat R12, Mat T12, Mat R13, Mat T13, Mat R1, Mat R2, Mat R3, Mat P1, Mat P2, Mat P3, Mat Q, double alpha, Size newImgSize, Rect roi1, Rect roi2, int flags)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (cameraMatrix3 != null) cameraMatrix3.ThrowIfDisposed();
            if (distCoeffs3 != null) distCoeffs3.ThrowIfDisposed();
            if (R12 != null) R12.ThrowIfDisposed();
            if (T12 != null) T12.ThrowIfDisposed();
            if (R13 != null) R13.ThrowIfDisposed();
            if (T13 != null) T13.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (R3 != null) R3.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (P3 != null) P3.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat imgpt1_mat = Converters.vector_Mat_to_Mat(imgpt1);
        Mat imgpt3_mat = Converters.vector_Mat_to_Mat(imgpt3);
        double[] roi1_out = new double[4];
        double[] roi2_out = new double[4];
        float retVal = calib3d_Calib3d_rectify3Collinear_10(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, cameraMatrix3.nativeObj, distCoeffs3.nativeObj, imgpt1_mat.nativeObj, imgpt3_mat.nativeObj, imageSize.width, imageSize.height, R12.nativeObj, T12.nativeObj, R13.nativeObj, T13.nativeObj, R1.nativeObj, R2.nativeObj, R3.nativeObj, P1.nativeObj, P2.nativeObj, P3.nativeObj, Q.nativeObj, alpha, newImgSize.width, newImgSize.height, roi1_out, roi2_out, flags);
        if(roi1!=null){ roi1.x = (int)roi1_out[0]; roi1.y = (int)roi1_out[1]; roi1.width = (int)roi1_out[2]; roi1.height = (int)roi1_out[3]; } 
        if(roi2!=null){ roi2.x = (int)roi2_out[0]; roi2.y = (int)roi2_out[1]; roi2.width = (int)roi2_out[2]; roi2.height = (int)roi2_out[3]; } 
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::decomposeHomographyMat(Mat H, Mat K, vector_Mat& rotations, vector_Mat& translations, vector_Mat& normals)
        //

        //javadoc: decomposeHomographyMat(H, K, rotations, translations, normals)
        public static int decomposeHomographyMat(Mat H, Mat K, List<Mat> rotations, List<Mat> translations, List<Mat> normals)
        {
            if (H != null) H.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat rotations_mat = new Mat();
        Mat translations_mat = new Mat();
        Mat normals_mat = new Mat();
        int retVal = calib3d_Calib3d_decomposeHomographyMat_10(H.nativeObj, K.nativeObj, rotations_mat.nativeObj, translations_mat.nativeObj, normals_mat.nativeObj);
        Converters.Mat_to_vector_Mat(rotations_mat, rotations);
        rotations_mat.release();
        Converters.Mat_to_vector_Mat(translations_mat, translations);
        translations_mat.release();
        Converters.Mat_to_vector_Mat(normals_mat, normals);
        normals_mat.release();
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::estimateAffine3D(Mat src, Mat dst, Mat& _out, Mat& inliers, double ransacThreshold = 3, double confidence = 0.99)
        //

        //javadoc: estimateAffine3D(src, dst, _out, inliers, ransacThreshold, confidence)
        public static int estimateAffine3D(Mat src, Mat dst, Mat _out, Mat inliers, double ransacThreshold, double confidence)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (_out != null) _out.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_Calib3d_estimateAffine3D_10(src.nativeObj, dst.nativeObj, _out.nativeObj, inliers.nativeObj, ransacThreshold, confidence);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: estimateAffine3D(src, dst, _out, inliers, ransacThreshold)
        public static int estimateAffine3D(Mat src, Mat dst, Mat _out, Mat inliers, double ransacThreshold)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (_out != null) _out.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_Calib3d_estimateAffine3D_11(src.nativeObj, dst.nativeObj, _out.nativeObj, inliers.nativeObj, ransacThreshold);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: estimateAffine3D(src, dst, _out, inliers)
        public static int estimateAffine3D(Mat src, Mat dst, Mat _out, Mat inliers)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (_out != null) _out.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_Calib3d_estimateAffine3D_12(src.nativeObj, dst.nativeObj, _out.nativeObj, inliers.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::recoverPose(Mat E, Mat points1, Mat points2, Mat& R, Mat& t, double focal = 1.0, Point2d pp = Point2d(0, 0), Mat& mask = Mat())
        //

        //javadoc: recoverPose(E, points1, points2, R, t, focal, pp, mask)
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat R, Mat t, double focal, Point pp, Mat mask)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_Calib3d_recoverPose_10(E.nativeObj, points1.nativeObj, points2.nativeObj, R.nativeObj, t.nativeObj, focal, pp.x, pp.y, mask.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: recoverPose(E, points1, points2, R, t, focal, pp)
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat R, Mat t, double focal, Point pp)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_Calib3d_recoverPose_11(E.nativeObj, points1.nativeObj, points2.nativeObj, R.nativeObj, t.nativeObj, focal, pp.x, pp.y);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: recoverPose(E, points1, points2, R, t, focal)
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat R, Mat t, double focal)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_Calib3d_recoverPose_12(E.nativeObj, points1.nativeObj, points2.nativeObj, R.nativeObj, t.nativeObj, focal);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: recoverPose(E, points1, points2, R, t)
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat R, Mat t)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_Calib3d_recoverPose_13(E.nativeObj, points1.nativeObj, points2.nativeObj, R.nativeObj, t.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat& R, Mat& t, Mat& mask = Mat())
        //

        //javadoc: recoverPose(E, points1, points2, cameraMatrix, R, t, mask)
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t, Mat mask)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_Calib3d_recoverPose_14(E.nativeObj, points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, R.nativeObj, t.nativeObj, mask.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: recoverPose(E, points1, points2, cameraMatrix, R, t)
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_Calib3d_recoverPose_15(E.nativeObj, points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, R.nativeObj, t.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat& R, Mat& t, double distanceThresh, Mat& mask = Mat(), Mat& triangulatedPoints = Mat())
        //

        //javadoc: recoverPose(E, points1, points2, cameraMatrix, R, t, distanceThresh, mask, triangulatedPoints)
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t, double distanceThresh, Mat mask, Mat triangulatedPoints)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (triangulatedPoints != null) triangulatedPoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_Calib3d_recoverPose_16(E.nativeObj, points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, R.nativeObj, t.nativeObj, distanceThresh, mask.nativeObj, triangulatedPoints.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: recoverPose(E, points1, points2, cameraMatrix, R, t, distanceThresh, mask)
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t, double distanceThresh, Mat mask)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_Calib3d_recoverPose_17(E.nativeObj, points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, R.nativeObj, t.nativeObj, distanceThresh, mask.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: recoverPose(E, points1, points2, cameraMatrix, R, t, distanceThresh)
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t, double distanceThresh)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_Calib3d_recoverPose_18(E.nativeObj, points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, R.nativeObj, t.nativeObj, distanceThresh);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::solveP3P(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, int flags)
        //

        //javadoc: solveP3P(objectPoints, imagePoints, cameraMatrix, distCoeffs, rvecs, tvecs, flags)
        public static int solveP3P(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, int flags)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        int retVal = calib3d_Calib3d_solveP3P_10(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::Rodrigues(Mat src, Mat& dst, Mat& jacobian = Mat())
        //

        //javadoc: Rodrigues(src, dst, jacobian)
        public static void Rodrigues(Mat src, Mat dst, Mat jacobian)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (jacobian != null) jacobian.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_Rodrigues_10(src.nativeObj, dst.nativeObj, jacobian.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Rodrigues(src, dst)
        public static void Rodrigues(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_Rodrigues_11(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::calibrateHandEye(vector_Mat R_gripper2base, vector_Mat t_gripper2base, vector_Mat R_target2cam, vector_Mat t_target2cam, Mat& R_cam2gripper, Mat& t_cam2gripper, HandEyeCalibrationMethod method = CALIB_HAND_EYE_TSAI)
        //

        //javadoc: calibrateHandEye(R_gripper2base, t_gripper2base, R_target2cam, t_target2cam, R_cam2gripper, t_cam2gripper, method)
        public static void calibrateHandEye(List<Mat> R_gripper2base, List<Mat> t_gripper2base, List<Mat> R_target2cam, List<Mat> t_target2cam, Mat R_cam2gripper, Mat t_cam2gripper, int method)
        {
            if (R_cam2gripper != null) R_cam2gripper.ThrowIfDisposed();
            if (t_cam2gripper != null) t_cam2gripper.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat R_gripper2base_mat = Converters.vector_Mat_to_Mat(R_gripper2base);
        Mat t_gripper2base_mat = Converters.vector_Mat_to_Mat(t_gripper2base);
        Mat R_target2cam_mat = Converters.vector_Mat_to_Mat(R_target2cam);
        Mat t_target2cam_mat = Converters.vector_Mat_to_Mat(t_target2cam);
        calib3d_Calib3d_calibrateHandEye_10(R_gripper2base_mat.nativeObj, t_gripper2base_mat.nativeObj, R_target2cam_mat.nativeObj, t_target2cam_mat.nativeObj, R_cam2gripper.nativeObj, t_cam2gripper.nativeObj, method);
        
        return;
#else
            return;
#endif
        }

        //javadoc: calibrateHandEye(R_gripper2base, t_gripper2base, R_target2cam, t_target2cam, R_cam2gripper, t_cam2gripper)
        public static void calibrateHandEye(List<Mat> R_gripper2base, List<Mat> t_gripper2base, List<Mat> R_target2cam, List<Mat> t_target2cam, Mat R_cam2gripper, Mat t_cam2gripper)
        {
            if (R_cam2gripper != null) R_cam2gripper.ThrowIfDisposed();
            if (t_cam2gripper != null) t_cam2gripper.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat R_gripper2base_mat = Converters.vector_Mat_to_Mat(R_gripper2base);
        Mat t_gripper2base_mat = Converters.vector_Mat_to_Mat(t_gripper2base);
        Mat R_target2cam_mat = Converters.vector_Mat_to_Mat(R_target2cam);
        Mat t_target2cam_mat = Converters.vector_Mat_to_Mat(t_target2cam);
        calib3d_Calib3d_calibrateHandEye_11(R_gripper2base_mat.nativeObj, t_gripper2base_mat.nativeObj, R_target2cam_mat.nativeObj, t_target2cam_mat.nativeObj, R_cam2gripper.nativeObj, t_cam2gripper.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::calibrationMatrixValues(Mat cameraMatrix, Size imageSize, double apertureWidth, double apertureHeight, double& fovx, double& fovy, double& focalLength, Point2d& principalPoint, double& aspectRatio)
        //

        //javadoc: calibrationMatrixValues(cameraMatrix, imageSize, apertureWidth, apertureHeight, fovx, fovy, focalLength, principalPoint, aspectRatio)
        public static void calibrationMatrixValues(Mat cameraMatrix, Size imageSize, double apertureWidth, double apertureHeight, double[] fovx, double[] fovy, double[] focalLength, Point principalPoint, double[] aspectRatio)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        double[] fovx_out = new double[1];
        double[] fovy_out = new double[1];
        double[] focalLength_out = new double[1];
        double[] principalPoint_out = new double[2];
        double[] aspectRatio_out = new double[1];
        calib3d_Calib3d_calibrationMatrixValues_10(cameraMatrix.nativeObj, imageSize.width, imageSize.height, apertureWidth, apertureHeight, fovx_out, fovy_out, focalLength_out, principalPoint_out, aspectRatio_out);
        if(fovx!=null) fovx[0] = (double)fovx_out[0];
        if(fovy!=null) fovy[0] = (double)fovy_out[0];
        if(focalLength!=null) focalLength[0] = (double)focalLength_out[0];
        if(principalPoint!=null){ principalPoint.x = principalPoint_out[0]; principalPoint.y = principalPoint_out[1]; } 
        if(aspectRatio!=null) aspectRatio[0] = (double)aspectRatio_out[0];
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat& rvec3, Mat& tvec3, Mat& dr3dr1 = Mat(), Mat& dr3dt1 = Mat(), Mat& dr3dr2 = Mat(), Mat& dr3dt2 = Mat(), Mat& dt3dr1 = Mat(), Mat& dt3dt1 = Mat(), Mat& dt3dr2 = Mat(), Mat& dt3dt2 = Mat())
        //

        //javadoc: composeRT(rvec1, tvec1, rvec2, tvec2, rvec3, tvec3, dr3dr1, dr3dt1, dr3dr2, dr3dt2, dt3dr1, dt3dt1, dt3dr2, dt3dt2)
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2, Mat dt3dr1, Mat dt3dt1, Mat dt3dr2, Mat dt3dt2)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();
            if (dr3dr2 != null) dr3dr2.ThrowIfDisposed();
            if (dr3dt2 != null) dr3dt2.ThrowIfDisposed();
            if (dt3dr1 != null) dt3dr1.ThrowIfDisposed();
            if (dt3dt1 != null) dt3dt1.ThrowIfDisposed();
            if (dt3dr2 != null) dt3dr2.ThrowIfDisposed();
            if (dt3dt2 != null) dt3dt2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_composeRT_10(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj, dr3dr2.nativeObj, dr3dt2.nativeObj, dt3dr1.nativeObj, dt3dt1.nativeObj, dt3dr2.nativeObj, dt3dt2.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: composeRT(rvec1, tvec1, rvec2, tvec2, rvec3, tvec3, dr3dr1, dr3dt1, dr3dr2, dr3dt2, dt3dr1, dt3dt1, dt3dr2)
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2, Mat dt3dr1, Mat dt3dt1, Mat dt3dr2)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();
            if (dr3dr2 != null) dr3dr2.ThrowIfDisposed();
            if (dr3dt2 != null) dr3dt2.ThrowIfDisposed();
            if (dt3dr1 != null) dt3dr1.ThrowIfDisposed();
            if (dt3dt1 != null) dt3dt1.ThrowIfDisposed();
            if (dt3dr2 != null) dt3dr2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_composeRT_11(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj, dr3dr2.nativeObj, dr3dt2.nativeObj, dt3dr1.nativeObj, dt3dt1.nativeObj, dt3dr2.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: composeRT(rvec1, tvec1, rvec2, tvec2, rvec3, tvec3, dr3dr1, dr3dt1, dr3dr2, dr3dt2, dt3dr1, dt3dt1)
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2, Mat dt3dr1, Mat dt3dt1)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();
            if (dr3dr2 != null) dr3dr2.ThrowIfDisposed();
            if (dr3dt2 != null) dr3dt2.ThrowIfDisposed();
            if (dt3dr1 != null) dt3dr1.ThrowIfDisposed();
            if (dt3dt1 != null) dt3dt1.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_composeRT_12(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj, dr3dr2.nativeObj, dr3dt2.nativeObj, dt3dr1.nativeObj, dt3dt1.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: composeRT(rvec1, tvec1, rvec2, tvec2, rvec3, tvec3, dr3dr1, dr3dt1, dr3dr2, dr3dt2, dt3dr1)
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2, Mat dt3dr1)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();
            if (dr3dr2 != null) dr3dr2.ThrowIfDisposed();
            if (dr3dt2 != null) dr3dt2.ThrowIfDisposed();
            if (dt3dr1 != null) dt3dr1.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_composeRT_13(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj, dr3dr2.nativeObj, dr3dt2.nativeObj, dt3dr1.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: composeRT(rvec1, tvec1, rvec2, tvec2, rvec3, tvec3, dr3dr1, dr3dt1, dr3dr2, dr3dt2)
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();
            if (dr3dr2 != null) dr3dr2.ThrowIfDisposed();
            if (dr3dt2 != null) dr3dt2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_composeRT_14(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj, dr3dr2.nativeObj, dr3dt2.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: composeRT(rvec1, tvec1, rvec2, tvec2, rvec3, tvec3, dr3dr1, dr3dt1, dr3dr2)
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();
            if (dr3dr2 != null) dr3dr2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_composeRT_15(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj, dr3dr2.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: composeRT(rvec1, tvec1, rvec2, tvec2, rvec3, tvec3, dr3dr1, dr3dt1)
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_composeRT_16(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: composeRT(rvec1, tvec1, rvec2, tvec2, rvec3, tvec3, dr3dr1)
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_composeRT_17(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: composeRT(rvec1, tvec1, rvec2, tvec2, rvec3, tvec3)
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_composeRT_18(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::computeCorrespondEpilines(Mat points, int whichImage, Mat F, Mat& lines)
        //

        //javadoc: computeCorrespondEpilines(points, whichImage, F, lines)
        public static void computeCorrespondEpilines(Mat points, int whichImage, Mat F, Mat lines)
        {
            if (points != null) points.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (lines != null) lines.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_computeCorrespondEpilines_10(points.nativeObj, whichImage, F.nativeObj, lines.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::convertPointsFromHomogeneous(Mat src, Mat& dst)
        //

        //javadoc: convertPointsFromHomogeneous(src, dst)
        public static void convertPointsFromHomogeneous(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_convertPointsFromHomogeneous_10(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::convertPointsToHomogeneous(Mat src, Mat& dst)
        //

        //javadoc: convertPointsToHomogeneous(src, dst)
        public static void convertPointsToHomogeneous(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_convertPointsToHomogeneous_10(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::correctMatches(Mat F, Mat points1, Mat points2, Mat& newPoints1, Mat& newPoints2)
        //

        //javadoc: correctMatches(F, points1, points2, newPoints1, newPoints2)
        public static void correctMatches(Mat F, Mat points1, Mat points2, Mat newPoints1, Mat newPoints2)
        {
            if (F != null) F.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (newPoints1 != null) newPoints1.ThrowIfDisposed();
            if (newPoints2 != null) newPoints2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_correctMatches_10(F.nativeObj, points1.nativeObj, points2.nativeObj, newPoints1.nativeObj, newPoints2.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::decomposeEssentialMat(Mat E, Mat& R1, Mat& R2, Mat& t)
        //

        //javadoc: decomposeEssentialMat(E, R1, R2, t)
        public static void decomposeEssentialMat(Mat E, Mat R1, Mat R2, Mat t)
        {
            if (E != null) E.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_decomposeEssentialMat_10(E.nativeObj, R1.nativeObj, R2.nativeObj, t.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::decomposeProjectionMatrix(Mat projMatrix, Mat& cameraMatrix, Mat& rotMatrix, Mat& transVect, Mat& rotMatrixX = Mat(), Mat& rotMatrixY = Mat(), Mat& rotMatrixZ = Mat(), Mat& eulerAngles = Mat())
        //

        //javadoc: decomposeProjectionMatrix(projMatrix, cameraMatrix, rotMatrix, transVect, rotMatrixX, rotMatrixY, rotMatrixZ, eulerAngles)
        public static void decomposeProjectionMatrix(Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect, Mat rotMatrixX, Mat rotMatrixY, Mat rotMatrixZ, Mat eulerAngles)
        {
            if (projMatrix != null) projMatrix.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (rotMatrix != null) rotMatrix.ThrowIfDisposed();
            if (transVect != null) transVect.ThrowIfDisposed();
            if (rotMatrixX != null) rotMatrixX.ThrowIfDisposed();
            if (rotMatrixY != null) rotMatrixY.ThrowIfDisposed();
            if (rotMatrixZ != null) rotMatrixZ.ThrowIfDisposed();
            if (eulerAngles != null) eulerAngles.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_decomposeProjectionMatrix_10(projMatrix.nativeObj, cameraMatrix.nativeObj, rotMatrix.nativeObj, transVect.nativeObj, rotMatrixX.nativeObj, rotMatrixY.nativeObj, rotMatrixZ.nativeObj, eulerAngles.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: decomposeProjectionMatrix(projMatrix, cameraMatrix, rotMatrix, transVect, rotMatrixX, rotMatrixY, rotMatrixZ)
        public static void decomposeProjectionMatrix(Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect, Mat rotMatrixX, Mat rotMatrixY, Mat rotMatrixZ)
        {
            if (projMatrix != null) projMatrix.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (rotMatrix != null) rotMatrix.ThrowIfDisposed();
            if (transVect != null) transVect.ThrowIfDisposed();
            if (rotMatrixX != null) rotMatrixX.ThrowIfDisposed();
            if (rotMatrixY != null) rotMatrixY.ThrowIfDisposed();
            if (rotMatrixZ != null) rotMatrixZ.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_decomposeProjectionMatrix_11(projMatrix.nativeObj, cameraMatrix.nativeObj, rotMatrix.nativeObj, transVect.nativeObj, rotMatrixX.nativeObj, rotMatrixY.nativeObj, rotMatrixZ.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: decomposeProjectionMatrix(projMatrix, cameraMatrix, rotMatrix, transVect, rotMatrixX, rotMatrixY)
        public static void decomposeProjectionMatrix(Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect, Mat rotMatrixX, Mat rotMatrixY)
        {
            if (projMatrix != null) projMatrix.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (rotMatrix != null) rotMatrix.ThrowIfDisposed();
            if (transVect != null) transVect.ThrowIfDisposed();
            if (rotMatrixX != null) rotMatrixX.ThrowIfDisposed();
            if (rotMatrixY != null) rotMatrixY.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_decomposeProjectionMatrix_12(projMatrix.nativeObj, cameraMatrix.nativeObj, rotMatrix.nativeObj, transVect.nativeObj, rotMatrixX.nativeObj, rotMatrixY.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: decomposeProjectionMatrix(projMatrix, cameraMatrix, rotMatrix, transVect, rotMatrixX)
        public static void decomposeProjectionMatrix(Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect, Mat rotMatrixX)
        {
            if (projMatrix != null) projMatrix.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (rotMatrix != null) rotMatrix.ThrowIfDisposed();
            if (transVect != null) transVect.ThrowIfDisposed();
            if (rotMatrixX != null) rotMatrixX.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_decomposeProjectionMatrix_13(projMatrix.nativeObj, cameraMatrix.nativeObj, rotMatrix.nativeObj, transVect.nativeObj, rotMatrixX.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: decomposeProjectionMatrix(projMatrix, cameraMatrix, rotMatrix, transVect)
        public static void decomposeProjectionMatrix(Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect)
        {
            if (projMatrix != null) projMatrix.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (rotMatrix != null) rotMatrix.ThrowIfDisposed();
            if (transVect != null) transVect.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_decomposeProjectionMatrix_14(projMatrix.nativeObj, cameraMatrix.nativeObj, rotMatrix.nativeObj, transVect.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::drawChessboardCorners(Mat& image, Size patternSize, vector_Point2f corners, bool patternWasFound)
        //

        //javadoc: drawChessboardCorners(image, patternSize, corners, patternWasFound)
        public static void drawChessboardCorners(Mat image, Size patternSize, MatOfPoint2f corners, bool patternWasFound)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = corners;
        calib3d_Calib3d_drawChessboardCorners_10(image.nativeObj, patternSize.width, patternSize.height, corners_mat.nativeObj, patternWasFound);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::drawFrameAxes(Mat& image, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, float length, int thickness = 3)
        //

        //javadoc: drawFrameAxes(image, cameraMatrix, distCoeffs, rvec, tvec, length, thickness)
        public static void drawFrameAxes(Mat image, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, float length, int thickness)
        {
            if (image != null) image.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_drawFrameAxes_10(image.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj, length, thickness);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawFrameAxes(image, cameraMatrix, distCoeffs, rvec, tvec, length)
        public static void drawFrameAxes(Mat image, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, float length)
        {
            if (image != null) image.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_drawFrameAxes_11(image.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj, length);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::filterHomographyDecompByVisibleRefpoints(vector_Mat rotations, vector_Mat normals, Mat beforePoints, Mat afterPoints, Mat& possibleSolutions, Mat pointsMask = Mat())
        //

        //javadoc: filterHomographyDecompByVisibleRefpoints(rotations, normals, beforePoints, afterPoints, possibleSolutions, pointsMask)
        public static void filterHomographyDecompByVisibleRefpoints(List<Mat> rotations, List<Mat> normals, Mat beforePoints, Mat afterPoints, Mat possibleSolutions, Mat pointsMask)
        {
            if (beforePoints != null) beforePoints.ThrowIfDisposed();
            if (afterPoints != null) afterPoints.ThrowIfDisposed();
            if (possibleSolutions != null) possibleSolutions.ThrowIfDisposed();
            if (pointsMask != null) pointsMask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat rotations_mat = Converters.vector_Mat_to_Mat(rotations);
        Mat normals_mat = Converters.vector_Mat_to_Mat(normals);
        calib3d_Calib3d_filterHomographyDecompByVisibleRefpoints_10(rotations_mat.nativeObj, normals_mat.nativeObj, beforePoints.nativeObj, afterPoints.nativeObj, possibleSolutions.nativeObj, pointsMask.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: filterHomographyDecompByVisibleRefpoints(rotations, normals, beforePoints, afterPoints, possibleSolutions)
        public static void filterHomographyDecompByVisibleRefpoints(List<Mat> rotations, List<Mat> normals, Mat beforePoints, Mat afterPoints, Mat possibleSolutions)
        {
            if (beforePoints != null) beforePoints.ThrowIfDisposed();
            if (afterPoints != null) afterPoints.ThrowIfDisposed();
            if (possibleSolutions != null) possibleSolutions.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat rotations_mat = Converters.vector_Mat_to_Mat(rotations);
        Mat normals_mat = Converters.vector_Mat_to_Mat(normals);
        calib3d_Calib3d_filterHomographyDecompByVisibleRefpoints_11(rotations_mat.nativeObj, normals_mat.nativeObj, beforePoints.nativeObj, afterPoints.nativeObj, possibleSolutions.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::filterSpeckles(Mat& img, double newVal, int maxSpeckleSize, double maxDiff, Mat& buf = Mat())
        //

        //javadoc: filterSpeckles(img, newVal, maxSpeckleSize, maxDiff, buf)
        public static void filterSpeckles(Mat img, double newVal, int maxSpeckleSize, double maxDiff, Mat buf)
        {
            if (img != null) img.ThrowIfDisposed();
            if (buf != null) buf.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_filterSpeckles_10(img.nativeObj, newVal, maxSpeckleSize, maxDiff, buf.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: filterSpeckles(img, newVal, maxSpeckleSize, maxDiff)
        public static void filterSpeckles(Mat img, double newVal, int maxSpeckleSize, double maxDiff)
        {
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_filterSpeckles_11(img.nativeObj, newVal, maxSpeckleSize, maxDiff);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::initUndistortRectifyMap(Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size size, int m1type, Mat& map1, Mat& map2)
        //

        //javadoc: initUndistortRectifyMap(cameraMatrix, distCoeffs, R, newCameraMatrix, size, m1type, map1, map2)
        public static void initUndistortRectifyMap(Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size size, int m1type, Mat map1, Mat map2)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (newCameraMatrix != null) newCameraMatrix.ThrowIfDisposed();
            if (map1 != null) map1.ThrowIfDisposed();
            if (map2 != null) map2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_initUndistortRectifyMap_10(cameraMatrix.nativeObj, distCoeffs.nativeObj, R.nativeObj, newCameraMatrix.nativeObj, size.width, size.height, m1type, map1.nativeObj, map2.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::matMulDeriv(Mat A, Mat B, Mat& dABdA, Mat& dABdB)
        //

        //javadoc: matMulDeriv(A, B, dABdA, dABdB)
        public static void matMulDeriv(Mat A, Mat B, Mat dABdA, Mat dABdB)
        {
            if (A != null) A.ThrowIfDisposed();
            if (B != null) B.ThrowIfDisposed();
            if (dABdA != null) dABdA.ThrowIfDisposed();
            if (dABdB != null) dABdB.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_matMulDeriv_10(A.nativeObj, B.nativeObj, dABdA.nativeObj, dABdB.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::projectPoints(vector_Point3f objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, vector_double distCoeffs, vector_Point2f& imagePoints, Mat& jacobian = Mat(), double aspectRatio = 0)
        //

        //javadoc: projectPoints(objectPoints, rvec, tvec, cameraMatrix, distCoeffs, imagePoints, jacobian, aspectRatio)
        public static void projectPoints(MatOfPoint3f objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, MatOfDouble distCoeffs, MatOfPoint2f imagePoints, Mat jacobian, double aspectRatio)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (jacobian != null) jacobian.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat distCoeffs_mat = distCoeffs;
        Mat imagePoints_mat = imagePoints;
        calib3d_Calib3d_projectPoints_10(objectPoints_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, imagePoints_mat.nativeObj, jacobian.nativeObj, aspectRatio);
        
        return;
#else
            return;
#endif
        }

        //javadoc: projectPoints(objectPoints, rvec, tvec, cameraMatrix, distCoeffs, imagePoints, jacobian)
        public static void projectPoints(MatOfPoint3f objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, MatOfDouble distCoeffs, MatOfPoint2f imagePoints, Mat jacobian)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (jacobian != null) jacobian.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat distCoeffs_mat = distCoeffs;
        Mat imagePoints_mat = imagePoints;
        calib3d_Calib3d_projectPoints_11(objectPoints_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, imagePoints_mat.nativeObj, jacobian.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: projectPoints(objectPoints, rvec, tvec, cameraMatrix, distCoeffs, imagePoints)
        public static void projectPoints(MatOfPoint3f objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, MatOfDouble distCoeffs, MatOfPoint2f imagePoints)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat distCoeffs_mat = distCoeffs;
        Mat imagePoints_mat = imagePoints;
        calib3d_Calib3d_projectPoints_12(objectPoints_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, imagePoints_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::reprojectImageTo3D(Mat disparity, Mat& _3dImage, Mat Q, bool handleMissingValues = false, int ddepth = -1)
        //

        //javadoc: reprojectImageTo3D(disparity, _3dImage, Q, handleMissingValues, ddepth)
        public static void reprojectImageTo3D(Mat disparity, Mat _3dImage, Mat Q, bool handleMissingValues, int ddepth)
        {
            if (disparity != null) disparity.ThrowIfDisposed();
            if (_3dImage != null) _3dImage.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_reprojectImageTo3D_10(disparity.nativeObj, _3dImage.nativeObj, Q.nativeObj, handleMissingValues, ddepth);
        
        return;
#else
            return;
#endif
        }

        //javadoc: reprojectImageTo3D(disparity, _3dImage, Q, handleMissingValues)
        public static void reprojectImageTo3D(Mat disparity, Mat _3dImage, Mat Q, bool handleMissingValues)
        {
            if (disparity != null) disparity.ThrowIfDisposed();
            if (_3dImage != null) _3dImage.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_reprojectImageTo3D_11(disparity.nativeObj, _3dImage.nativeObj, Q.nativeObj, handleMissingValues);
        
        return;
#else
            return;
#endif
        }

        //javadoc: reprojectImageTo3D(disparity, _3dImage, Q)
        public static void reprojectImageTo3D(Mat disparity, Mat _3dImage, Mat Q)
        {
            if (disparity != null) disparity.ThrowIfDisposed();
            if (_3dImage != null) _3dImage.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_reprojectImageTo3D_12(disparity.nativeObj, _3dImage.nativeObj, Q.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat& R1, Mat& R2, Mat& P1, Mat& P2, Mat& Q, int flags = CALIB_ZERO_DISPARITY, double alpha = -1, Size newImageSize = Size(), Rect* validPixROI1 = 0, Rect* validPixROI2 = 0)
        //

        //javadoc: stereoRectify(cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, imageSize, R, T, R1, R2, P1, P2, Q, flags, alpha, newImageSize, validPixROI1, validPixROI2)
        public static void stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, double alpha, Size newImageSize, Rect validPixROI1, Rect validPixROI2)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        double[] validPixROI1_out = new double[4];
        double[] validPixROI2_out = new double[4];
        calib3d_Calib3d_stereoRectify_10(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, alpha, newImageSize.width, newImageSize.height, validPixROI1_out, validPixROI2_out);
        if(validPixROI1!=null){ validPixROI1.x = (int)validPixROI1_out[0]; validPixROI1.y = (int)validPixROI1_out[1]; validPixROI1.width = (int)validPixROI1_out[2]; validPixROI1.height = (int)validPixROI1_out[3]; } 
        if(validPixROI2!=null){ validPixROI2.x = (int)validPixROI2_out[0]; validPixROI2.y = (int)validPixROI2_out[1]; validPixROI2.width = (int)validPixROI2_out[2]; validPixROI2.height = (int)validPixROI2_out[3]; } 
        return;
#else
            return;
#endif
        }

        //javadoc: stereoRectify(cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, imageSize, R, T, R1, R2, P1, P2, Q, flags, alpha, newImageSize, validPixROI1)
        public static void stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, double alpha, Size newImageSize, Rect validPixROI1)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        double[] validPixROI1_out = new double[4];
        calib3d_Calib3d_stereoRectify_11(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, alpha, newImageSize.width, newImageSize.height, validPixROI1_out);
        if(validPixROI1!=null){ validPixROI1.x = (int)validPixROI1_out[0]; validPixROI1.y = (int)validPixROI1_out[1]; validPixROI1.width = (int)validPixROI1_out[2]; validPixROI1.height = (int)validPixROI1_out[3]; } 
        return;
#else
            return;
#endif
        }

        //javadoc: stereoRectify(cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, imageSize, R, T, R1, R2, P1, P2, Q, flags, alpha, newImageSize)
        public static void stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, double alpha, Size newImageSize)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_stereoRectify_12(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, alpha, newImageSize.width, newImageSize.height);
        
        return;
#else
            return;
#endif
        }

        //javadoc: stereoRectify(cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, imageSize, R, T, R1, R2, P1, P2, Q, flags, alpha)
        public static void stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, double alpha)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_stereoRectify_13(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, alpha);
        
        return;
#else
            return;
#endif
        }

        //javadoc: stereoRectify(cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, imageSize, R, T, R1, R2, P1, P2, Q, flags)
        public static void stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_stereoRectify_14(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags);
        
        return;
#else
            return;
#endif
        }

        //javadoc: stereoRectify(cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, imageSize, R, T, R1, R2, P1, P2, Q)
        public static void stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_stereoRectify_15(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::triangulatePoints(Mat projMatr1, Mat projMatr2, Mat projPoints1, Mat projPoints2, Mat& points4D)
        //

        //javadoc: triangulatePoints(projMatr1, projMatr2, projPoints1, projPoints2, points4D)
        public static void triangulatePoints(Mat projMatr1, Mat projMatr2, Mat projPoints1, Mat projPoints2, Mat points4D)
        {
            if (projMatr1 != null) projMatr1.ThrowIfDisposed();
            if (projMatr2 != null) projMatr2.ThrowIfDisposed();
            if (projPoints1 != null) projPoints1.ThrowIfDisposed();
            if (projPoints2 != null) projPoints2.ThrowIfDisposed();
            if (points4D != null) points4D.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_triangulatePoints_10(projMatr1.nativeObj, projMatr2.nativeObj, projPoints1.nativeObj, projPoints2.nativeObj, points4D.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::undistort(Mat src, Mat& dst, Mat cameraMatrix, Mat distCoeffs, Mat newCameraMatrix = Mat())
        //

        //javadoc: undistort(src, dst, cameraMatrix, distCoeffs, newCameraMatrix)
        public static void undistort(Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs, Mat newCameraMatrix)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newCameraMatrix != null) newCameraMatrix.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_undistort_10(src.nativeObj, dst.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, newCameraMatrix.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: undistort(src, dst, cameraMatrix, distCoeffs)
        public static void undistort(Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_undistort_11(src.nativeObj, dst.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::undistortPoints(Mat src, Mat& dst, Mat cameraMatrix, Mat distCoeffs, Mat R, Mat P, TermCriteria criteria)
        //

        //javadoc: undistortPointsIter(src, dst, cameraMatrix, distCoeffs, R, P, criteria)
        public static void undistortPointsIter(Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs, Mat R, Mat P, TermCriteria criteria)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_undistortPointsIter_10(src.nativeObj, dst.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, R.nativeObj, P.nativeObj, criteria.type, criteria.maxCount, criteria.epsilon);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::undistortPoints(vector_Point2f src, vector_Point2f& dst, Mat cameraMatrix, Mat distCoeffs, Mat R = Mat(), Mat P = Mat())
        //

        //javadoc: undistortPoints(src, dst, cameraMatrix, distCoeffs, R, P)
        public static void undistortPoints(MatOfPoint2f src, MatOfPoint2f dst, Mat cameraMatrix, Mat distCoeffs, Mat R, Mat P)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat src_mat = src;
        Mat dst_mat = dst;
        calib3d_Calib3d_undistortPoints_10(src_mat.nativeObj, dst_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, R.nativeObj, P.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: undistortPoints(src, dst, cameraMatrix, distCoeffs, R)
        public static void undistortPoints(MatOfPoint2f src, MatOfPoint2f dst, Mat cameraMatrix, Mat distCoeffs, Mat R)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat src_mat = src;
        Mat dst_mat = dst;
        calib3d_Calib3d_undistortPoints_11(src_mat.nativeObj, dst_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, R.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: undistortPoints(src, dst, cameraMatrix, distCoeffs)
        public static void undistortPoints(MatOfPoint2f src, MatOfPoint2f dst, Mat cameraMatrix, Mat distCoeffs)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat src_mat = src;
        Mat dst_mat = dst;
        calib3d_Calib3d_undistortPoints_12(src_mat.nativeObj, dst_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::validateDisparity(Mat& disparity, Mat cost, int minDisparity, int numberOfDisparities, int disp12MaxDisp = 1)
        //

        //javadoc: validateDisparity(disparity, cost, minDisparity, numberOfDisparities, disp12MaxDisp)
        public static void validateDisparity(Mat disparity, Mat cost, int minDisparity, int numberOfDisparities, int disp12MaxDisp)
        {
            if (disparity != null) disparity.ThrowIfDisposed();
            if (cost != null) cost.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_validateDisparity_10(disparity.nativeObj, cost.nativeObj, minDisparity, numberOfDisparities, disp12MaxDisp);
        
        return;
#else
            return;
#endif
        }

        //javadoc: validateDisparity(disparity, cost, minDisparity, numberOfDisparities)
        public static void validateDisparity(Mat disparity, Mat cost, int minDisparity, int numberOfDisparities)
        {
            if (disparity != null) disparity.ThrowIfDisposed();
            if (cost != null) cost.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_validateDisparity_11(disparity.nativeObj, cost.nativeObj, minDisparity, numberOfDisparities);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::fisheye::distortPoints(Mat undistorted, Mat& distorted, Mat K, Mat D, double alpha = 0)
        //

        //javadoc: fisheye_distortPoints(undistorted, distorted, K, D, alpha)
        public static void fisheye_distortPoints(Mat undistorted, Mat distorted, Mat K, Mat D, double alpha)
        {
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (distorted != null) distorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1distortPoints_10(undistorted.nativeObj, distorted.nativeObj, K.nativeObj, D.nativeObj, alpha);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fisheye_distortPoints(undistorted, distorted, K, D)
        public static void fisheye_distortPoints(Mat undistorted, Mat distorted, Mat K, Mat D)
        {
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (distorted != null) distorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1distortPoints_11(undistorted.nativeObj, distorted.nativeObj, K.nativeObj, D.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::fisheye::estimateNewCameraMatrixForUndistortRectify(Mat K, Mat D, Size image_size, Mat R, Mat& P, double balance = 0.0, Size new_size = Size(), double fov_scale = 1.0)
        //

        //javadoc: fisheye_estimateNewCameraMatrixForUndistortRectify(K, D, image_size, R, P, balance, new_size, fov_scale)
        public static void fisheye_estimateNewCameraMatrixForUndistortRectify(Mat K, Mat D, Size image_size, Mat R, Mat P, double balance, Size new_size, double fov_scale)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_10(K.nativeObj, D.nativeObj, image_size.width, image_size.height, R.nativeObj, P.nativeObj, balance, new_size.width, new_size.height, fov_scale);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fisheye_estimateNewCameraMatrixForUndistortRectify(K, D, image_size, R, P, balance, new_size)
        public static void fisheye_estimateNewCameraMatrixForUndistortRectify(Mat K, Mat D, Size image_size, Mat R, Mat P, double balance, Size new_size)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_11(K.nativeObj, D.nativeObj, image_size.width, image_size.height, R.nativeObj, P.nativeObj, balance, new_size.width, new_size.height);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fisheye_estimateNewCameraMatrixForUndistortRectify(K, D, image_size, R, P, balance)
        public static void fisheye_estimateNewCameraMatrixForUndistortRectify(Mat K, Mat D, Size image_size, Mat R, Mat P, double balance)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_12(K.nativeObj, D.nativeObj, image_size.width, image_size.height, R.nativeObj, P.nativeObj, balance);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fisheye_estimateNewCameraMatrixForUndistortRectify(K, D, image_size, R, P)
        public static void fisheye_estimateNewCameraMatrixForUndistortRectify(Mat K, Mat D, Size image_size, Mat R, Mat P)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_13(K.nativeObj, D.nativeObj, image_size.width, image_size.height, R.nativeObj, P.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::fisheye::initUndistortRectifyMap(Mat K, Mat D, Mat R, Mat P, Size size, int m1type, Mat& map1, Mat& map2)
        //

        //javadoc: fisheye_initUndistortRectifyMap(K, D, R, P, size, m1type, map1, map2)
        public static void fisheye_initUndistortRectifyMap(Mat K, Mat D, Mat R, Mat P, Size size, int m1type, Mat map1, Mat map2)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();
            if (map1 != null) map1.ThrowIfDisposed();
            if (map2 != null) map2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1initUndistortRectifyMap_10(K.nativeObj, D.nativeObj, R.nativeObj, P.nativeObj, size.width, size.height, m1type, map1.nativeObj, map2.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::fisheye::projectPoints(Mat objectPoints, Mat& imagePoints, Mat rvec, Mat tvec, Mat K, Mat D, double alpha = 0, Mat& jacobian = Mat())
        //

        //javadoc: fisheye_projectPoints(objectPoints, imagePoints, rvec, tvec, K, D, alpha, jacobian)
        public static void fisheye_projectPoints(Mat objectPoints, Mat imagePoints, Mat rvec, Mat tvec, Mat K, Mat D, double alpha, Mat jacobian)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (jacobian != null) jacobian.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1projectPoints_10(objectPoints.nativeObj, imagePoints.nativeObj, rvec.nativeObj, tvec.nativeObj, K.nativeObj, D.nativeObj, alpha, jacobian.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fisheye_projectPoints(objectPoints, imagePoints, rvec, tvec, K, D, alpha)
        public static void fisheye_projectPoints(Mat objectPoints, Mat imagePoints, Mat rvec, Mat tvec, Mat K, Mat D, double alpha)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1projectPoints_11(objectPoints.nativeObj, imagePoints.nativeObj, rvec.nativeObj, tvec.nativeObj, K.nativeObj, D.nativeObj, alpha);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fisheye_projectPoints(objectPoints, imagePoints, rvec, tvec, K, D)
        public static void fisheye_projectPoints(Mat objectPoints, Mat imagePoints, Mat rvec, Mat tvec, Mat K, Mat D)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1projectPoints_12(objectPoints.nativeObj, imagePoints.nativeObj, rvec.nativeObj, tvec.nativeObj, K.nativeObj, D.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::fisheye::stereoRectify(Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat tvec, Mat& R1, Mat& R2, Mat& P1, Mat& P2, Mat& Q, int flags, Size newImageSize = Size(), double balance = 0.0, double fov_scale = 1.0)
        //

        //javadoc: fisheye_stereoRectify(K1, D1, K2, D2, imageSize, R, tvec, R1, R2, P1, P2, Q, flags, newImageSize, balance, fov_scale)
        public static void fisheye_stereoRectify(Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat tvec, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, Size newImageSize, double balance, double fov_scale)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1stereoRectify_10(K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, tvec.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, newImageSize.width, newImageSize.height, balance, fov_scale);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fisheye_stereoRectify(K1, D1, K2, D2, imageSize, R, tvec, R1, R2, P1, P2, Q, flags, newImageSize, balance)
        public static void fisheye_stereoRectify(Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat tvec, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, Size newImageSize, double balance)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1stereoRectify_11(K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, tvec.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, newImageSize.width, newImageSize.height, balance);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fisheye_stereoRectify(K1, D1, K2, D2, imageSize, R, tvec, R1, R2, P1, P2, Q, flags, newImageSize)
        public static void fisheye_stereoRectify(Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat tvec, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, Size newImageSize)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1stereoRectify_12(K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, tvec.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, newImageSize.width, newImageSize.height);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fisheye_stereoRectify(K1, D1, K2, D2, imageSize, R, tvec, R1, R2, P1, P2, Q, flags)
        public static void fisheye_stereoRectify(Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat tvec, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1stereoRectify_13(K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, tvec.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::fisheye::undistortImage(Mat distorted, Mat& undistorted, Mat K, Mat D, Mat Knew = cv::Mat(), Size new_size = Size())
        //

        //javadoc: fisheye_undistortImage(distorted, undistorted, K, D, Knew, new_size)
        public static void fisheye_undistortImage(Mat distorted, Mat undistorted, Mat K, Mat D, Mat Knew, Size new_size)
        {
            if (distorted != null) distorted.ThrowIfDisposed();
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (Knew != null) Knew.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1undistortImage_10(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, Knew.nativeObj, new_size.width, new_size.height);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fisheye_undistortImage(distorted, undistorted, K, D, Knew)
        public static void fisheye_undistortImage(Mat distorted, Mat undistorted, Mat K, Mat D, Mat Knew)
        {
            if (distorted != null) distorted.ThrowIfDisposed();
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (Knew != null) Knew.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1undistortImage_11(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, Knew.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fisheye_undistortImage(distorted, undistorted, K, D)
        public static void fisheye_undistortImage(Mat distorted, Mat undistorted, Mat K, Mat D)
        {
            if (distorted != null) distorted.ThrowIfDisposed();
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1undistortImage_12(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::fisheye::undistortPoints(Mat distorted, Mat& undistorted, Mat K, Mat D, Mat R = Mat(), Mat P = Mat())
        //

        //javadoc: fisheye_undistortPoints(distorted, undistorted, K, D, R, P)
        public static void fisheye_undistortPoints(Mat distorted, Mat undistorted, Mat K, Mat D, Mat R, Mat P)
        {
            if (distorted != null) distorted.ThrowIfDisposed();
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1undistortPoints_10(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, R.nativeObj, P.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fisheye_undistortPoints(distorted, undistorted, K, D, R)
        public static void fisheye_undistortPoints(Mat distorted, Mat undistorted, Mat K, Mat D, Mat R)
        {
            if (distorted != null) distorted.ThrowIfDisposed();
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1undistortPoints_11(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, R.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fisheye_undistortPoints(distorted, undistorted, K, D)
        public static void fisheye_undistortPoints(Mat distorted, Mat undistorted, Mat K, Mat D)
        {
            if (distorted != null) distorted.ThrowIfDisposed();
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_Calib3d_fisheye_1undistortPoints_12(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj);
        
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



        // C++:  Mat cv::estimateAffine2D(Mat from, Mat to, Mat& inliers = Mat(), int method = RANSAC, double ransacReprojThreshold = 3, size_t maxIters = 2000, double confidence = 0.99, size_t refineIters = 10)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_10(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold, long maxIters, double confidence, long refineIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_11(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold, long maxIters, double confidence);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_12(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold, long maxIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_13(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_14(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_15(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_16(IntPtr from_nativeObj, IntPtr to_nativeObj);

        // C++:  Mat cv::estimateAffinePartial2D(Mat from, Mat to, Mat& inliers = Mat(), int method = RANSAC, double ransacReprojThreshold = 3, size_t maxIters = 2000, double confidence = 0.99, size_t refineIters = 10)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_10(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold, long maxIters, double confidence, long refineIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_11(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold, long maxIters, double confidence);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_12(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold, long maxIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_13(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_14(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_15(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_16(IntPtr from_nativeObj, IntPtr to_nativeObj);

        // C++:  Mat cv::findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix, int method = RANSAC, double prob = 0.999, double threshold = 1.0, Mat& mask = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_10(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, int method, double prob, double threshold, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_11(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, int method, double prob, double threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_12(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, int method, double prob);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_13(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_14(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj);

        // C++:  Mat cv::findEssentialMat(Mat points1, Mat points2, double focal = 1.0, Point2d pp = Point2d(0, 0), int method = RANSAC, double prob = 0.999, double threshold = 1.0, Mat& mask = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_15(IntPtr points1_nativeObj, IntPtr points2_nativeObj, double focal, double pp_x, double pp_y, int method, double prob, double threshold, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_16(IntPtr points1_nativeObj, IntPtr points2_nativeObj, double focal, double pp_x, double pp_y, int method, double prob, double threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_17(IntPtr points1_nativeObj, IntPtr points2_nativeObj, double focal, double pp_x, double pp_y, int method, double prob);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_18(IntPtr points1_nativeObj, IntPtr points2_nativeObj, double focal, double pp_x, double pp_y, int method);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_19(IntPtr points1_nativeObj, IntPtr points2_nativeObj, double focal, double pp_x, double pp_y);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_110(IntPtr points1_nativeObj, IntPtr points2_nativeObj, double focal);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_111(IntPtr points1_nativeObj, IntPtr points2_nativeObj);

        // C++:  Mat cv::findFundamentalMat(vector_Point2f points1, vector_Point2f points2, int method = FM_RANSAC, double ransacReprojThreshold = 3., double confidence = 0.99, Mat& mask = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findFundamentalMat_10(IntPtr points1_mat_nativeObj, IntPtr points2_mat_nativeObj, int method, double ransacReprojThreshold, double confidence, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findFundamentalMat_11(IntPtr points1_mat_nativeObj, IntPtr points2_mat_nativeObj, int method, double ransacReprojThreshold, double confidence);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findFundamentalMat_12(IntPtr points1_mat_nativeObj, IntPtr points2_mat_nativeObj, int method, double ransacReprojThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findFundamentalMat_13(IntPtr points1_mat_nativeObj, IntPtr points2_mat_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findFundamentalMat_14(IntPtr points1_mat_nativeObj, IntPtr points2_mat_nativeObj);

        // C++:  Mat cv::findHomography(vector_Point2f srcPoints, vector_Point2f dstPoints, int method = 0, double ransacReprojThreshold = 3, Mat& mask = Mat(), int maxIters = 2000, double confidence = 0.995)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findHomography_10(IntPtr srcPoints_mat_nativeObj, IntPtr dstPoints_mat_nativeObj, int method, double ransacReprojThreshold, IntPtr mask_nativeObj, int maxIters, double confidence);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findHomography_11(IntPtr srcPoints_mat_nativeObj, IntPtr dstPoints_mat_nativeObj, int method, double ransacReprojThreshold, IntPtr mask_nativeObj, int maxIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findHomography_12(IntPtr srcPoints_mat_nativeObj, IntPtr dstPoints_mat_nativeObj, int method, double ransacReprojThreshold, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findHomography_13(IntPtr srcPoints_mat_nativeObj, IntPtr dstPoints_mat_nativeObj, int method, double ransacReprojThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findHomography_14(IntPtr srcPoints_mat_nativeObj, IntPtr dstPoints_mat_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findHomography_15(IntPtr srcPoints_mat_nativeObj, IntPtr dstPoints_mat_nativeObj);

        // C++:  Mat cv::getDefaultNewCameraMatrix(Mat cameraMatrix, Size imgsize = Size(), bool centerPrincipalPoint = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getDefaultNewCameraMatrix_10(IntPtr cameraMatrix_nativeObj, double imgsize_width, double imgsize_height, [MarshalAs(UnmanagedType.U1)] bool centerPrincipalPoint);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getDefaultNewCameraMatrix_11(IntPtr cameraMatrix_nativeObj, double imgsize_width, double imgsize_height);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getDefaultNewCameraMatrix_12(IntPtr cameraMatrix_nativeObj);

        // C++:  Mat cv::getOptimalNewCameraMatrix(Mat cameraMatrix, Mat distCoeffs, Size imageSize, double alpha, Size newImgSize = Size(), Rect* validPixROI = 0, bool centerPrincipalPoint = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getOptimalNewCameraMatrix_10(IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, double imageSize_width, double imageSize_height, double alpha, double newImgSize_width, double newImgSize_height, double[] validPixROI_out, [MarshalAs(UnmanagedType.U1)] bool centerPrincipalPoint);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getOptimalNewCameraMatrix_11(IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, double imageSize_width, double imageSize_height, double alpha, double newImgSize_width, double newImgSize_height, double[] validPixROI_out);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getOptimalNewCameraMatrix_12(IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, double imageSize_width, double imageSize_height, double alpha, double newImgSize_width, double newImgSize_height);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getOptimalNewCameraMatrix_13(IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, double imageSize_width, double imageSize_height, double alpha);

        // C++:  Mat cv::initCameraMatrix2D(vector_vector_Point3f objectPoints, vector_vector_Point2f imagePoints, Size imageSize, double aspectRatio = 1.0)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_initCameraMatrix2D_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, double aspectRatio);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_initCameraMatrix2D_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height);

        // C++:  Rect cv::getValidDisparityROI(Rect roi1, Rect roi2, int minDisparity, int numberOfDisparities, int SADWindowSize)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_getValidDisparityROI_10(int roi1_x, int roi1_y, int roi1_width, int roi1_height, int roi2_x, int roi2_y, int roi2_width, int roi2_height, int minDisparity, int numberOfDisparities, int SADWindowSize, double[] retVal);

        // C++:  Vec3d cv::RQDecomp3x3(Mat src, Mat& mtxR, Mat& mtxQ, Mat& Qx = Mat(), Mat& Qy = Mat(), Mat& Qz = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_RQDecomp3x3_10(IntPtr src_nativeObj, IntPtr mtxR_nativeObj, IntPtr mtxQ_nativeObj, IntPtr Qx_nativeObj, IntPtr Qy_nativeObj, IntPtr Qz_nativeObj, double[] retVal);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_RQDecomp3x3_11(IntPtr src_nativeObj, IntPtr mtxR_nativeObj, IntPtr mtxQ_nativeObj, IntPtr Qx_nativeObj, IntPtr Qy_nativeObj, double[] retVal);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_RQDecomp3x3_12(IntPtr src_nativeObj, IntPtr mtxR_nativeObj, IntPtr mtxQ_nativeObj, IntPtr Qx_nativeObj, double[] retVal);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_RQDecomp3x3_13(IntPtr src_nativeObj, IntPtr mtxR_nativeObj, IntPtr mtxQ_nativeObj, double[] retVal);

        // C++:  bool cv::checkChessboard(Mat img, Size size)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_checkChessboard_10(IntPtr img_nativeObj, double size_width, double size_height);

        // C++:  bool cv::findChessboardCorners(Mat image, Size patternSize, vector_Point2f& corners, int flags = CALIB_CB_ADAPTIVE_THRESH + CALIB_CB_NORMALIZE_IMAGE)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_findChessboardCorners_10(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_mat_nativeObj, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_findChessboardCorners_11(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_mat_nativeObj);

        // C++:  bool cv::findChessboardCornersSB(Mat image, Size patternSize, Mat& corners, int flags = 0)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_findChessboardCornersSB_10(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_nativeObj, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_findChessboardCornersSB_11(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_nativeObj);

        // C++:  bool cv::findCirclesGrid(Mat image, Size patternSize, Mat& centers, int flags = CALIB_CB_SYMMETRIC_GRID, Ptr_FeatureDetector blobDetector = SimpleBlobDetector::create())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_findCirclesGrid_10(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr centers_nativeObj, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_findCirclesGrid_12(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr centers_nativeObj);

        // C++:  bool cv::solvePnP(vector_Point3f objectPoints, vector_Point2f imagePoints, Mat cameraMatrix, vector_double distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false, int flags = SOLVEPNP_ITERATIVE)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnP_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnP_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnP_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj);

        // C++:  bool cv::solvePnPRansac(vector_Point3f objectPoints, vector_Point2f imagePoints, Mat cameraMatrix, vector_double distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false, int iterationsCount = 100, float reprojectionError = 8.0, double confidence = 0.99, Mat& inliers = Mat(), int flags = SOLVEPNP_ITERATIVE)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence, IntPtr inliers_nativeObj, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence, IntPtr inliers_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_13(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int iterationsCount, float reprojectionError);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_14(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int iterationsCount);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_15(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_16(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj);

        // C++:  bool cv::stereoRectifyUncalibrated(Mat points1, Mat points2, Mat F, Size imgSize, Mat& H1, Mat& H2, double threshold = 5)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_stereoRectifyUncalibrated_10(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr F_nativeObj, double imgSize_width, double imgSize_height, IntPtr H1_nativeObj, IntPtr H2_nativeObj, double threshold);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_stereoRectifyUncalibrated_11(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr F_nativeObj, double imgSize_width, double imgSize_height, IntPtr H1_nativeObj, IntPtr H2_nativeObj);

        // C++:  double cv::calibrateCamera(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraExtended_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr perViewErrors_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraExtended_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr perViewErrors_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraExtended_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr perViewErrors_nativeObj);

        // C++:  double cv::calibrateCamera(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCamera_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCamera_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCamera_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj);

        // C++:  double cv::calibrateCameraRO(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, int iFixedPoint, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& newObjPoints, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& stdDeviationsObjPoints, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraROExtended_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, int iFixedPoint, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr newObjPoints_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr stdDeviationsObjPoints_nativeObj, IntPtr perViewErrors_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraROExtended_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, int iFixedPoint, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr newObjPoints_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr stdDeviationsObjPoints_nativeObj, IntPtr perViewErrors_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraROExtended_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, int iFixedPoint, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr newObjPoints_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr stdDeviationsObjPoints_nativeObj, IntPtr perViewErrors_nativeObj);

        // C++:  double cv::calibrateCameraRO(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, int iFixedPoint, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& newObjPoints, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraRO_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, int iFixedPoint, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr newObjPoints_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraRO_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, int iFixedPoint, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr newObjPoints_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraRO_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, int iFixedPoint, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr newObjPoints_nativeObj);

        // C++:  double cv::sampsonDistance(Mat pt1, Mat pt2, Mat F)
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_sampsonDistance_10(IntPtr pt1_nativeObj, IntPtr pt2_nativeObj, IntPtr F_nativeObj);

        // C++:  double cv::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& cameraMatrix1, Mat& distCoeffs1, Mat& cameraMatrix2, Mat& distCoeffs2, Size imageSize, Mat& R, Mat& T, Mat& E, Mat& F, Mat& perViewErrors, int flags = CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 1e-6))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrateExtended_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj, IntPtr perViewErrors_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrateExtended_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj, IntPtr perViewErrors_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrateExtended_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj, IntPtr perViewErrors_nativeObj);

        // C++:  double cv::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& cameraMatrix1, Mat& distCoeffs1, Mat& cameraMatrix2, Mat& distCoeffs2, Size imageSize, Mat& R, Mat& T, Mat& E, Mat& F, int flags = CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 1e-6))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrate_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrate_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrate_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj);

        // C++:  double cv::fisheye::calibrate(vector_Mat objectPoints, vector_Mat imagePoints, Size image_size, Mat& K, Mat& D, vector_Mat& rvecs, vector_Mat& tvecs, int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 100, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1calibrate_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double image_size_width, double image_size_height, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1calibrate_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double image_size_width, double image_size_height, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1calibrate_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double image_size_width, double image_size_height, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj);

        // C++:  double cv::fisheye::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& K1, Mat& D1, Mat& K2, Mat& D2, Size imageSize, Mat& R, Mat& T, int flags = fisheye::CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 100, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1stereoCalibrate_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1stereoCalibrate_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1stereoCalibrate_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj);

        // C++:  float cv::rectify3Collinear(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat cameraMatrix3, Mat distCoeffs3, vector_Mat imgpt1, vector_Mat imgpt3, Size imageSize, Mat R12, Mat T12, Mat R13, Mat T13, Mat& R1, Mat& R2, Mat& R3, Mat& P1, Mat& P2, Mat& P3, Mat& Q, double alpha, Size newImgSize, Rect* roi1, Rect* roi2, int flags)
        [DllImport(LIBNAME)]
        private static extern float calib3d_Calib3d_rectify3Collinear_10(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, IntPtr cameraMatrix3_nativeObj, IntPtr distCoeffs3_nativeObj, IntPtr imgpt1_mat_nativeObj, IntPtr imgpt3_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr R12_nativeObj, IntPtr T12_nativeObj, IntPtr R13_nativeObj, IntPtr T13_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr R3_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr P3_nativeObj, IntPtr Q_nativeObj, double alpha, double newImgSize_width, double newImgSize_height, double[] roi1_out, double[] roi2_out, int flags);

        // C++:  int cv::decomposeHomographyMat(Mat H, Mat K, vector_Mat& rotations, vector_Mat& translations, vector_Mat& normals)
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_decomposeHomographyMat_10(IntPtr H_nativeObj, IntPtr K_nativeObj, IntPtr rotations_mat_nativeObj, IntPtr translations_mat_nativeObj, IntPtr normals_mat_nativeObj);

        // C++:  int cv::estimateAffine3D(Mat src, Mat dst, Mat& _out, Mat& inliers, double ransacThreshold = 3, double confidence = 0.99)
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_estimateAffine3D_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr _out_nativeObj, IntPtr inliers_nativeObj, double ransacThreshold, double confidence);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_estimateAffine3D_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr _out_nativeObj, IntPtr inliers_nativeObj, double ransacThreshold);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_estimateAffine3D_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr _out_nativeObj, IntPtr inliers_nativeObj);

        // C++:  int cv::recoverPose(Mat E, Mat points1, Mat points2, Mat& R, Mat& t, double focal = 1.0, Point2d pp = Point2d(0, 0), Mat& mask = Mat())
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_10(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, double focal, double pp_x, double pp_y, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_11(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, double focal, double pp_x, double pp_y);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_12(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, double focal);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_13(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj);

        // C++:  int cv::recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat& R, Mat& t, Mat& mask = Mat())
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_14(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_15(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj);

        // C++:  int cv::recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat& R, Mat& t, double distanceThresh, Mat& mask = Mat(), Mat& triangulatedPoints = Mat())
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_16(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, double distanceThresh, IntPtr mask_nativeObj, IntPtr triangulatedPoints_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_17(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, double distanceThresh, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_18(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, double distanceThresh);

        // C++:  int cv::solveP3P(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, int flags)
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_solveP3P_10(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags);

        // C++:  void cv::Rodrigues(Mat src, Mat& dst, Mat& jacobian = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_Rodrigues_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr jacobian_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_Rodrigues_11(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::calibrateHandEye(vector_Mat R_gripper2base, vector_Mat t_gripper2base, vector_Mat R_target2cam, vector_Mat t_target2cam, Mat& R_cam2gripper, Mat& t_cam2gripper, HandEyeCalibrationMethod method = CALIB_HAND_EYE_TSAI)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_calibrateHandEye_10(IntPtr R_gripper2base_mat_nativeObj, IntPtr t_gripper2base_mat_nativeObj, IntPtr R_target2cam_mat_nativeObj, IntPtr t_target2cam_mat_nativeObj, IntPtr R_cam2gripper_nativeObj, IntPtr t_cam2gripper_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_calibrateHandEye_11(IntPtr R_gripper2base_mat_nativeObj, IntPtr t_gripper2base_mat_nativeObj, IntPtr R_target2cam_mat_nativeObj, IntPtr t_target2cam_mat_nativeObj, IntPtr R_cam2gripper_nativeObj, IntPtr t_cam2gripper_nativeObj);

        // C++:  void cv::calibrationMatrixValues(Mat cameraMatrix, Size imageSize, double apertureWidth, double apertureHeight, double& fovx, double& fovy, double& focalLength, Point2d& principalPoint, double& aspectRatio)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_calibrationMatrixValues_10(IntPtr cameraMatrix_nativeObj, double imageSize_width, double imageSize_height, double apertureWidth, double apertureHeight, double[] fovx_out, double[] fovy_out, double[] focalLength_out, double[] principalPoint_out, double[] aspectRatio_out);

        // C++:  void cv::composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat& rvec3, Mat& tvec3, Mat& dr3dr1 = Mat(), Mat& dr3dt1 = Mat(), Mat& dr3dr2 = Mat(), Mat& dr3dt2 = Mat(), Mat& dt3dr1 = Mat(), Mat& dt3dt1 = Mat(), Mat& dt3dr2 = Mat(), Mat& dt3dt2 = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_10(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj, IntPtr dr3dr2_nativeObj, IntPtr dr3dt2_nativeObj, IntPtr dt3dr1_nativeObj, IntPtr dt3dt1_nativeObj, IntPtr dt3dr2_nativeObj, IntPtr dt3dt2_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_11(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj, IntPtr dr3dr2_nativeObj, IntPtr dr3dt2_nativeObj, IntPtr dt3dr1_nativeObj, IntPtr dt3dt1_nativeObj, IntPtr dt3dr2_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_12(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj, IntPtr dr3dr2_nativeObj, IntPtr dr3dt2_nativeObj, IntPtr dt3dr1_nativeObj, IntPtr dt3dt1_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_13(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj, IntPtr dr3dr2_nativeObj, IntPtr dr3dt2_nativeObj, IntPtr dt3dr1_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_14(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj, IntPtr dr3dr2_nativeObj, IntPtr dr3dt2_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_15(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj, IntPtr dr3dr2_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_16(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_17(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_18(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj);

        // C++:  void cv::computeCorrespondEpilines(Mat points, int whichImage, Mat F, Mat& lines)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_computeCorrespondEpilines_10(IntPtr points_nativeObj, int whichImage, IntPtr F_nativeObj, IntPtr lines_nativeObj);

        // C++:  void cv::convertPointsFromHomogeneous(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_convertPointsFromHomogeneous_10(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::convertPointsToHomogeneous(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_convertPointsToHomogeneous_10(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::correctMatches(Mat F, Mat points1, Mat points2, Mat& newPoints1, Mat& newPoints2)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_correctMatches_10(IntPtr F_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr newPoints1_nativeObj, IntPtr newPoints2_nativeObj);

        // C++:  void cv::decomposeEssentialMat(Mat E, Mat& R1, Mat& R2, Mat& t)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_decomposeEssentialMat_10(IntPtr E_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr t_nativeObj);

        // C++:  void cv::decomposeProjectionMatrix(Mat projMatrix, Mat& cameraMatrix, Mat& rotMatrix, Mat& transVect, Mat& rotMatrixX = Mat(), Mat& rotMatrixY = Mat(), Mat& rotMatrixZ = Mat(), Mat& eulerAngles = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_decomposeProjectionMatrix_10(IntPtr projMatrix_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr rotMatrix_nativeObj, IntPtr transVect_nativeObj, IntPtr rotMatrixX_nativeObj, IntPtr rotMatrixY_nativeObj, IntPtr rotMatrixZ_nativeObj, IntPtr eulerAngles_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_decomposeProjectionMatrix_11(IntPtr projMatrix_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr rotMatrix_nativeObj, IntPtr transVect_nativeObj, IntPtr rotMatrixX_nativeObj, IntPtr rotMatrixY_nativeObj, IntPtr rotMatrixZ_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_decomposeProjectionMatrix_12(IntPtr projMatrix_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr rotMatrix_nativeObj, IntPtr transVect_nativeObj, IntPtr rotMatrixX_nativeObj, IntPtr rotMatrixY_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_decomposeProjectionMatrix_13(IntPtr projMatrix_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr rotMatrix_nativeObj, IntPtr transVect_nativeObj, IntPtr rotMatrixX_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_decomposeProjectionMatrix_14(IntPtr projMatrix_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr rotMatrix_nativeObj, IntPtr transVect_nativeObj);

        // C++:  void cv::drawChessboardCorners(Mat& image, Size patternSize, vector_Point2f corners, bool patternWasFound)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_drawChessboardCorners_10(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool patternWasFound);

        // C++:  void cv::drawFrameAxes(Mat& image, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, float length, int thickness = 3)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_drawFrameAxes_10(IntPtr image_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, float length, int thickness);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_drawFrameAxes_11(IntPtr image_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, float length);

        // C++:  void cv::filterHomographyDecompByVisibleRefpoints(vector_Mat rotations, vector_Mat normals, Mat beforePoints, Mat afterPoints, Mat& possibleSolutions, Mat pointsMask = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_filterHomographyDecompByVisibleRefpoints_10(IntPtr rotations_mat_nativeObj, IntPtr normals_mat_nativeObj, IntPtr beforePoints_nativeObj, IntPtr afterPoints_nativeObj, IntPtr possibleSolutions_nativeObj, IntPtr pointsMask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_filterHomographyDecompByVisibleRefpoints_11(IntPtr rotations_mat_nativeObj, IntPtr normals_mat_nativeObj, IntPtr beforePoints_nativeObj, IntPtr afterPoints_nativeObj, IntPtr possibleSolutions_nativeObj);

        // C++:  void cv::filterSpeckles(Mat& img, double newVal, int maxSpeckleSize, double maxDiff, Mat& buf = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_filterSpeckles_10(IntPtr img_nativeObj, double newVal, int maxSpeckleSize, double maxDiff, IntPtr buf_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_filterSpeckles_11(IntPtr img_nativeObj, double newVal, int maxSpeckleSize, double maxDiff);

        // C++:  void cv::initUndistortRectifyMap(Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size size, int m1type, Mat& map1, Mat& map2)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_initUndistortRectifyMap_10(IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr R_nativeObj, IntPtr newCameraMatrix_nativeObj, double size_width, double size_height, int m1type, IntPtr map1_nativeObj, IntPtr map2_nativeObj);

        // C++:  void cv::matMulDeriv(Mat A, Mat B, Mat& dABdA, Mat& dABdB)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_matMulDeriv_10(IntPtr A_nativeObj, IntPtr B_nativeObj, IntPtr dABdA_nativeObj, IntPtr dABdB_nativeObj);

        // C++:  void cv::projectPoints(vector_Point3f objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, vector_double distCoeffs, vector_Point2f& imagePoints, Mat& jacobian = Mat(), double aspectRatio = 0)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_projectPoints_10(IntPtr objectPoints_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr jacobian_nativeObj, double aspectRatio);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_projectPoints_11(IntPtr objectPoints_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr jacobian_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_projectPoints_12(IntPtr objectPoints_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr imagePoints_mat_nativeObj);

        // C++:  void cv::reprojectImageTo3D(Mat disparity, Mat& _3dImage, Mat Q, bool handleMissingValues = false, int ddepth = -1)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_reprojectImageTo3D_10(IntPtr disparity_nativeObj, IntPtr _3dImage_nativeObj, IntPtr Q_nativeObj, [MarshalAs(UnmanagedType.U1)] bool handleMissingValues, int ddepth);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_reprojectImageTo3D_11(IntPtr disparity_nativeObj, IntPtr _3dImage_nativeObj, IntPtr Q_nativeObj, [MarshalAs(UnmanagedType.U1)] bool handleMissingValues);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_reprojectImageTo3D_12(IntPtr disparity_nativeObj, IntPtr _3dImage_nativeObj, IntPtr Q_nativeObj);

        // C++:  void cv::stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat& R1, Mat& R2, Mat& P1, Mat& P2, Mat& Q, int flags = CALIB_ZERO_DISPARITY, double alpha = -1, Size newImageSize = Size(), Rect* validPixROI1 = 0, Rect* validPixROI2 = 0)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_stereoRectify_10(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double alpha, double newImageSize_width, double newImageSize_height, double[] validPixROI1_out, double[] validPixROI2_out);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_stereoRectify_11(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double alpha, double newImageSize_width, double newImageSize_height, double[] validPixROI1_out);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_stereoRectify_12(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double alpha, double newImageSize_width, double newImageSize_height);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_stereoRectify_13(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double alpha);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_stereoRectify_14(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_stereoRectify_15(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj);

        // C++:  void cv::triangulatePoints(Mat projMatr1, Mat projMatr2, Mat projPoints1, Mat projPoints2, Mat& points4D)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_triangulatePoints_10(IntPtr projMatr1_nativeObj, IntPtr projMatr2_nativeObj, IntPtr projPoints1_nativeObj, IntPtr projPoints2_nativeObj, IntPtr points4D_nativeObj);

        // C++:  void cv::undistort(Mat src, Mat& dst, Mat cameraMatrix, Mat distCoeffs, Mat newCameraMatrix = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistort_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr newCameraMatrix_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistort_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);

        // C++:  void cv::undistortPoints(Mat src, Mat& dst, Mat cameraMatrix, Mat distCoeffs, Mat R, Mat P, TermCriteria criteria)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistortPointsIter_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr R_nativeObj, IntPtr P_nativeObj, int criteria_type, int criteria_maxCount, double criteria_epsilon);

        // C++:  void cv::undistortPoints(vector_Point2f src, vector_Point2f& dst, Mat cameraMatrix, Mat distCoeffs, Mat R = Mat(), Mat P = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistortPoints_10(IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr R_nativeObj, IntPtr P_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistortPoints_11(IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr R_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistortPoints_12(IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);

        // C++:  void cv::validateDisparity(Mat& disparity, Mat cost, int minDisparity, int numberOfDisparities, int disp12MaxDisp = 1)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_validateDisparity_10(IntPtr disparity_nativeObj, IntPtr cost_nativeObj, int minDisparity, int numberOfDisparities, int disp12MaxDisp);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_validateDisparity_11(IntPtr disparity_nativeObj, IntPtr cost_nativeObj, int minDisparity, int numberOfDisparities);

        // C++:  void cv::fisheye::distortPoints(Mat undistorted, Mat& distorted, Mat K, Mat D, double alpha = 0)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1distortPoints_10(IntPtr undistorted_nativeObj, IntPtr distorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, double alpha);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1distortPoints_11(IntPtr undistorted_nativeObj, IntPtr distorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj);

        // C++:  void cv::fisheye::estimateNewCameraMatrixForUndistortRectify(Mat K, Mat D, Size image_size, Mat R, Mat& P, double balance = 0.0, Size new_size = Size(), double fov_scale = 1.0)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_10(IntPtr K_nativeObj, IntPtr D_nativeObj, double image_size_width, double image_size_height, IntPtr R_nativeObj, IntPtr P_nativeObj, double balance, double new_size_width, double new_size_height, double fov_scale);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_11(IntPtr K_nativeObj, IntPtr D_nativeObj, double image_size_width, double image_size_height, IntPtr R_nativeObj, IntPtr P_nativeObj, double balance, double new_size_width, double new_size_height);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_12(IntPtr K_nativeObj, IntPtr D_nativeObj, double image_size_width, double image_size_height, IntPtr R_nativeObj, IntPtr P_nativeObj, double balance);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_13(IntPtr K_nativeObj, IntPtr D_nativeObj, double image_size_width, double image_size_height, IntPtr R_nativeObj, IntPtr P_nativeObj);

        // C++:  void cv::fisheye::initUndistortRectifyMap(Mat K, Mat D, Mat R, Mat P, Size size, int m1type, Mat& map1, Mat& map2)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1initUndistortRectifyMap_10(IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr R_nativeObj, IntPtr P_nativeObj, double size_width, double size_height, int m1type, IntPtr map1_nativeObj, IntPtr map2_nativeObj);

        // C++:  void cv::fisheye::projectPoints(Mat objectPoints, Mat& imagePoints, Mat rvec, Mat tvec, Mat K, Mat D, double alpha = 0, Mat& jacobian = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1projectPoints_10(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, double alpha, IntPtr jacobian_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1projectPoints_11(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, double alpha);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1projectPoints_12(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj);

        // C++:  void cv::fisheye::stereoRectify(Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat tvec, Mat& R1, Mat& R2, Mat& P1, Mat& P2, Mat& Q, int flags, Size newImageSize = Size(), double balance = 0.0, double fov_scale = 1.0)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1stereoRectify_10(IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr tvec_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double newImageSize_width, double newImageSize_height, double balance, double fov_scale);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1stereoRectify_11(IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr tvec_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double newImageSize_width, double newImageSize_height, double balance);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1stereoRectify_12(IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr tvec_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double newImageSize_width, double newImageSize_height);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1stereoRectify_13(IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr tvec_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags);

        // C++:  void cv::fisheye::undistortImage(Mat distorted, Mat& undistorted, Mat K, Mat D, Mat Knew = cv::Mat(), Size new_size = Size())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1undistortImage_10(IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr Knew_nativeObj, double new_size_width, double new_size_height);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1undistortImage_11(IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr Knew_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1undistortImage_12(IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj);

        // C++:  void cv::fisheye::undistortPoints(Mat distorted, Mat& undistorted, Mat K, Mat D, Mat R = Mat(), Mat P = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1undistortPoints_10(IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr R_nativeObj, IntPtr P_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1undistortPoints_11(IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr R_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1undistortPoints_12(IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj);

    }
}
