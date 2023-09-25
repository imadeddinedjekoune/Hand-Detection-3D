
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ArucoModule
{
    // C++: class Aruco
    //javadoc: Aruco

    public class Aruco
    {

        // C++: enum CornerRefineMethod
        public const int CORNER_REFINE_NONE = 0;
        public const int CORNER_REFINE_SUBPIX = 1;
        public const int CORNER_REFINE_CONTOUR = 2;
        public const int CORNER_REFINE_APRILTAG = 3;
        // C++: enum PREDEFINED_DICTIONARY_NAME
        public const int DICT_4X4_50 = 0;
        public const int DICT_4X4_100 = 0 + 1;
        public const int DICT_4X4_250 = 0 + 2;
        public const int DICT_4X4_1000 = 0 + 3;
        public const int DICT_5X5_50 = 0 + 4;
        public const int DICT_5X5_100 = 0 + 5;
        public const int DICT_5X5_250 = 0 + 6;
        public const int DICT_5X5_1000 = 0 + 7;
        public const int DICT_6X6_50 = 0 + 8;
        public const int DICT_6X6_100 = 0 + 9;
        public const int DICT_6X6_250 = 0 + 10;
        public const int DICT_6X6_1000 = 0 + 11;
        public const int DICT_7X7_50 = 0 + 12;
        public const int DICT_7X7_100 = 0 + 13;
        public const int DICT_7X7_250 = 0 + 14;
        public const int DICT_7X7_1000 = 0 + 15;
        public const int DICT_ARUCO_ORIGINAL = 0 + 16;
        public const int DICT_APRILTAG_16h5 = 0 + 17;
        public const int DICT_APRILTAG_25h9 = 0 + 18;
        public const int DICT_APRILTAG_36h10 = 0 + 19;
        public const int DICT_APRILTAG_36h11 = 0 + 20;
        //
        // C++:  Ptr_Dictionary cv::aruco::generateCustomDictionary(int nMarkers, int markerSize, Ptr_Dictionary baseDictionary, int randomSeed = 0)
        //

        //javadoc: custom_dictionary_from(nMarkers, markerSize, baseDictionary, randomSeed)
        public static Dictionary custom_dictionary_from(int nMarkers, int markerSize, Dictionary baseDictionary, int randomSeed)
        {
            if (baseDictionary != null) baseDictionary.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Dictionary retVal = Dictionary.__fromPtr__(aruco_Aruco_custom_1dictionary_1from_10(nMarkers, markerSize, baseDictionary.getNativeObjAddr(), randomSeed));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: custom_dictionary_from(nMarkers, markerSize, baseDictionary)
        public static Dictionary custom_dictionary_from(int nMarkers, int markerSize, Dictionary baseDictionary)
        {
            if (baseDictionary != null) baseDictionary.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Dictionary retVal = Dictionary.__fromPtr__(aruco_Aruco_custom_1dictionary_1from_11(nMarkers, markerSize, baseDictionary.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_Dictionary cv::aruco::generateCustomDictionary(int nMarkers, int markerSize, int randomSeed = 0)
        //

        //javadoc: custom_dictionary(nMarkers, markerSize, randomSeed)
        public static Dictionary custom_dictionary(int nMarkers, int markerSize, int randomSeed)
        {
#if UNITY_5_3_OR_NEWER
        
        Dictionary retVal = Dictionary.__fromPtr__(aruco_Aruco_custom_1dictionary_10(nMarkers, markerSize, randomSeed));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: custom_dictionary(nMarkers, markerSize)
        public static Dictionary custom_dictionary(int nMarkers, int markerSize)
        {
#if UNITY_5_3_OR_NEWER
        
        Dictionary retVal = Dictionary.__fromPtr__(aruco_Aruco_custom_1dictionary_11(nMarkers, markerSize));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_Dictionary cv::aruco::getPredefinedDictionary(int dict)
        //

        //javadoc: getPredefinedDictionary(dict)
        public static Dictionary getPredefinedDictionary(int dict)
        {
#if UNITY_5_3_OR_NEWER
        
        Dictionary retVal = Dictionary.__fromPtr__(aruco_Aruco_getPredefinedDictionary_10(dict));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::aruco::estimatePoseCharucoBoard(Mat charucoCorners, Mat charucoIds, Ptr_CharucoBoard board, Mat cameraMatrix, Mat distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false)
        //

        //javadoc: estimatePoseCharucoBoard(charucoCorners, charucoIds, board, cameraMatrix, distCoeffs, rvec, tvec, useExtrinsicGuess)
        public static bool estimatePoseCharucoBoard(Mat charucoCorners, Mat charucoIds, CharucoBoard board, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess)
        {
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = aruco_Aruco_estimatePoseCharucoBoard_10(charucoCorners.nativeObj, charucoIds.nativeObj, board.getNativeObjAddr(), cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: estimatePoseCharucoBoard(charucoCorners, charucoIds, board, cameraMatrix, distCoeffs, rvec, tvec)
        public static bool estimatePoseCharucoBoard(Mat charucoCorners, Mat charucoIds, CharucoBoard board, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec)
        {
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = aruco_Aruco_estimatePoseCharucoBoard_11(charucoCorners.nativeObj, charucoIds.nativeObj, board.getNativeObjAddr(), cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  double cv::aruco::calibrateCameraAruco(vector_Mat corners, Mat ids, Mat counter, Ptr_Board board, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        //

        //javadoc: calibrateCameraArucoExtended(corners, ids, counter, board, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, stdDeviationsIntrinsics, stdDeviationsExtrinsics, perViewErrors, flags, criteria)
        public static double calibrateCameraArucoExtended(List<Mat> corners, Mat ids, Mat counter, Board board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors, int flags, TermCriteria criteria)
        {
            if (ids != null) ids.ThrowIfDisposed();
            if (counter != null) counter.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraArucoExtended_10(corners_mat.nativeObj, ids.nativeObj, counter.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, perViewErrors.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraArucoExtended(corners, ids, counter, board, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, stdDeviationsIntrinsics, stdDeviationsExtrinsics, perViewErrors, flags)
        public static double calibrateCameraArucoExtended(List<Mat> corners, Mat ids, Mat counter, Board board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors, int flags)
        {
            if (ids != null) ids.ThrowIfDisposed();
            if (counter != null) counter.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraArucoExtended_11(corners_mat.nativeObj, ids.nativeObj, counter.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, perViewErrors.nativeObj, flags);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraArucoExtended(corners, ids, counter, board, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, stdDeviationsIntrinsics, stdDeviationsExtrinsics, perViewErrors)
        public static double calibrateCameraArucoExtended(List<Mat> corners, Mat ids, Mat counter, Board board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors)
        {
            if (ids != null) ids.ThrowIfDisposed();
            if (counter != null) counter.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraArucoExtended_12(corners_mat.nativeObj, ids.nativeObj, counter.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, perViewErrors.nativeObj);
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
        // C++:  double cv::aruco::calibrateCameraAruco(vector_Mat corners, Mat ids, Mat counter, Ptr_Board board, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs = vector_Mat(), vector_Mat& tvecs = vector_Mat(), int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        //

        //javadoc: calibrateCameraAruco(corners, ids, counter, board, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, flags, criteria)
        public static double calibrateCameraAruco(List<Mat> corners, Mat ids, Mat counter, Board board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, int flags, TermCriteria criteria)
        {
            if (ids != null) ids.ThrowIfDisposed();
            if (counter != null) counter.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraAruco_10(corners_mat.nativeObj, ids.nativeObj, counter.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraAruco(corners, ids, counter, board, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, flags)
        public static double calibrateCameraAruco(List<Mat> corners, Mat ids, Mat counter, Board board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, int flags)
        {
            if (ids != null) ids.ThrowIfDisposed();
            if (counter != null) counter.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraAruco_11(corners_mat.nativeObj, ids.nativeObj, counter.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraAruco(corners, ids, counter, board, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs)
        public static double calibrateCameraAruco(List<Mat> corners, Mat ids, Mat counter, Board board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs)
        {
            if (ids != null) ids.ThrowIfDisposed();
            if (counter != null) counter.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraAruco_12(corners_mat.nativeObj, ids.nativeObj, counter.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraAruco(corners, ids, counter, board, imageSize, cameraMatrix, distCoeffs, rvecs)
        public static double calibrateCameraAruco(List<Mat> corners, Mat ids, Mat counter, Board board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs)
        {
            if (ids != null) ids.ThrowIfDisposed();
            if (counter != null) counter.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        Mat rvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraAruco_13(corners_mat.nativeObj, ids.nativeObj, counter.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraAruco(corners, ids, counter, board, imageSize, cameraMatrix, distCoeffs)
        public static double calibrateCameraAruco(List<Mat> corners, Mat ids, Mat counter, Board board, Size imageSize, Mat cameraMatrix, Mat distCoeffs)
        {
            if (ids != null) ids.ThrowIfDisposed();
            if (counter != null) counter.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        double retVal = aruco_Aruco_calibrateCameraAruco_14(corners_mat.nativeObj, ids.nativeObj, counter.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::aruco::calibrateCameraCharuco(vector_Mat charucoCorners, vector_Mat charucoIds, Ptr_CharucoBoard board, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        //

        //javadoc: calibrateCameraCharucoExtended(charucoCorners, charucoIds, board, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, stdDeviationsIntrinsics, stdDeviationsExtrinsics, perViewErrors, flags, criteria)
        public static double calibrateCameraCharucoExtended(List<Mat> charucoCorners, List<Mat> charucoIds, CharucoBoard board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors, int flags, TermCriteria criteria)
        {
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat charucoCorners_mat = Converters.vector_Mat_to_Mat(charucoCorners);
        Mat charucoIds_mat = Converters.vector_Mat_to_Mat(charucoIds);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraCharucoExtended_10(charucoCorners_mat.nativeObj, charucoIds_mat.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, perViewErrors.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraCharucoExtended(charucoCorners, charucoIds, board, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, stdDeviationsIntrinsics, stdDeviationsExtrinsics, perViewErrors, flags)
        public static double calibrateCameraCharucoExtended(List<Mat> charucoCorners, List<Mat> charucoIds, CharucoBoard board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors, int flags)
        {
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat charucoCorners_mat = Converters.vector_Mat_to_Mat(charucoCorners);
        Mat charucoIds_mat = Converters.vector_Mat_to_Mat(charucoIds);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraCharucoExtended_11(charucoCorners_mat.nativeObj, charucoIds_mat.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, perViewErrors.nativeObj, flags);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraCharucoExtended(charucoCorners, charucoIds, board, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, stdDeviationsIntrinsics, stdDeviationsExtrinsics, perViewErrors)
        public static double calibrateCameraCharucoExtended(List<Mat> charucoCorners, List<Mat> charucoIds, CharucoBoard board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors)
        {
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat charucoCorners_mat = Converters.vector_Mat_to_Mat(charucoCorners);
        Mat charucoIds_mat = Converters.vector_Mat_to_Mat(charucoIds);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraCharucoExtended_12(charucoCorners_mat.nativeObj, charucoIds_mat.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, perViewErrors.nativeObj);
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
        // C++:  double cv::aruco::calibrateCameraCharuco(vector_Mat charucoCorners, vector_Mat charucoIds, Ptr_CharucoBoard board, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs = vector_Mat(), vector_Mat& tvecs = vector_Mat(), int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        //

        //javadoc: calibrateCameraCharuco(charucoCorners, charucoIds, board, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, flags, criteria)
        public static double calibrateCameraCharuco(List<Mat> charucoCorners, List<Mat> charucoIds, CharucoBoard board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, int flags, TermCriteria criteria)
        {
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat charucoCorners_mat = Converters.vector_Mat_to_Mat(charucoCorners);
        Mat charucoIds_mat = Converters.vector_Mat_to_Mat(charucoIds);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraCharuco_10(charucoCorners_mat.nativeObj, charucoIds_mat.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraCharuco(charucoCorners, charucoIds, board, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs, flags)
        public static double calibrateCameraCharuco(List<Mat> charucoCorners, List<Mat> charucoIds, CharucoBoard board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, int flags)
        {
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat charucoCorners_mat = Converters.vector_Mat_to_Mat(charucoCorners);
        Mat charucoIds_mat = Converters.vector_Mat_to_Mat(charucoIds);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraCharuco_11(charucoCorners_mat.nativeObj, charucoIds_mat.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraCharuco(charucoCorners, charucoIds, board, imageSize, cameraMatrix, distCoeffs, rvecs, tvecs)
        public static double calibrateCameraCharuco(List<Mat> charucoCorners, List<Mat> charucoIds, CharucoBoard board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs)
        {
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat charucoCorners_mat = Converters.vector_Mat_to_Mat(charucoCorners);
        Mat charucoIds_mat = Converters.vector_Mat_to_Mat(charucoIds);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraCharuco_12(charucoCorners_mat.nativeObj, charucoIds_mat.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraCharuco(charucoCorners, charucoIds, board, imageSize, cameraMatrix, distCoeffs, rvecs)
        public static double calibrateCameraCharuco(List<Mat> charucoCorners, List<Mat> charucoIds, CharucoBoard board, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs)
        {
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat charucoCorners_mat = Converters.vector_Mat_to_Mat(charucoCorners);
        Mat charucoIds_mat = Converters.vector_Mat_to_Mat(charucoIds);
        Mat rvecs_mat = new Mat();
        double retVal = aruco_Aruco_calibrateCameraCharuco_13(charucoCorners_mat.nativeObj, charucoIds_mat.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrateCameraCharuco(charucoCorners, charucoIds, board, imageSize, cameraMatrix, distCoeffs)
        public static double calibrateCameraCharuco(List<Mat> charucoCorners, List<Mat> charucoIds, CharucoBoard board, Size imageSize, Mat cameraMatrix, Mat distCoeffs)
        {
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat charucoCorners_mat = Converters.vector_Mat_to_Mat(charucoCorners);
        Mat charucoIds_mat = Converters.vector_Mat_to_Mat(charucoIds);
        double retVal = aruco_Aruco_calibrateCameraCharuco_14(charucoCorners_mat.nativeObj, charucoIds_mat.nativeObj, board.getNativeObjAddr(), imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::aruco::estimatePoseBoard(vector_Mat corners, Mat ids, Ptr_Board board, Mat cameraMatrix, Mat distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false)
        //

        //javadoc: estimatePoseBoard(corners, ids, board, cameraMatrix, distCoeffs, rvec, tvec, useExtrinsicGuess)
        public static int estimatePoseBoard(List<Mat> corners, Mat ids, Board board, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess)
        {
            if (ids != null) ids.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        int retVal = aruco_Aruco_estimatePoseBoard_10(corners_mat.nativeObj, ids.nativeObj, board.getNativeObjAddr(), cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: estimatePoseBoard(corners, ids, board, cameraMatrix, distCoeffs, rvec, tvec)
        public static int estimatePoseBoard(List<Mat> corners, Mat ids, Board board, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec)
        {
            if (ids != null) ids.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        int retVal = aruco_Aruco_estimatePoseBoard_11(corners_mat.nativeObj, ids.nativeObj, board.getNativeObjAddr(), cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::aruco::interpolateCornersCharuco(vector_Mat markerCorners, Mat markerIds, Mat image, Ptr_CharucoBoard board, Mat& charucoCorners, Mat& charucoIds, Mat cameraMatrix = Mat(), Mat distCoeffs = Mat(), int minMarkers = 2)
        //

        //javadoc: interpolateCornersCharuco(markerCorners, markerIds, image, board, charucoCorners, charucoIds, cameraMatrix, distCoeffs, minMarkers)
        public static int interpolateCornersCharuco(List<Mat> markerCorners, Mat markerIds, Mat image, CharucoBoard board, Mat charucoCorners, Mat charucoIds, Mat cameraMatrix, Mat distCoeffs, int minMarkers)
        {
            if (markerIds != null) markerIds.ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat markerCorners_mat = Converters.vector_Mat_to_Mat(markerCorners);
        int retVal = aruco_Aruco_interpolateCornersCharuco_10(markerCorners_mat.nativeObj, markerIds.nativeObj, image.nativeObj, board.getNativeObjAddr(), charucoCorners.nativeObj, charucoIds.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, minMarkers);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: interpolateCornersCharuco(markerCorners, markerIds, image, board, charucoCorners, charucoIds, cameraMatrix, distCoeffs)
        public static int interpolateCornersCharuco(List<Mat> markerCorners, Mat markerIds, Mat image, CharucoBoard board, Mat charucoCorners, Mat charucoIds, Mat cameraMatrix, Mat distCoeffs)
        {
            if (markerIds != null) markerIds.ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat markerCorners_mat = Converters.vector_Mat_to_Mat(markerCorners);
        int retVal = aruco_Aruco_interpolateCornersCharuco_11(markerCorners_mat.nativeObj, markerIds.nativeObj, image.nativeObj, board.getNativeObjAddr(), charucoCorners.nativeObj, charucoIds.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: interpolateCornersCharuco(markerCorners, markerIds, image, board, charucoCorners, charucoIds, cameraMatrix)
        public static int interpolateCornersCharuco(List<Mat> markerCorners, Mat markerIds, Mat image, CharucoBoard board, Mat charucoCorners, Mat charucoIds, Mat cameraMatrix)
        {
            if (markerIds != null) markerIds.ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat markerCorners_mat = Converters.vector_Mat_to_Mat(markerCorners);
        int retVal = aruco_Aruco_interpolateCornersCharuco_12(markerCorners_mat.nativeObj, markerIds.nativeObj, image.nativeObj, board.getNativeObjAddr(), charucoCorners.nativeObj, charucoIds.nativeObj, cameraMatrix.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: interpolateCornersCharuco(markerCorners, markerIds, image, board, charucoCorners, charucoIds)
        public static int interpolateCornersCharuco(List<Mat> markerCorners, Mat markerIds, Mat image, CharucoBoard board, Mat charucoCorners, Mat charucoIds)
        {
            if (markerIds != null) markerIds.ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat markerCorners_mat = Converters.vector_Mat_to_Mat(markerCorners);
        int retVal = aruco_Aruco_interpolateCornersCharuco_13(markerCorners_mat.nativeObj, markerIds.nativeObj, image.nativeObj, board.getNativeObjAddr(), charucoCorners.nativeObj, charucoIds.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::aruco::detectCharucoDiamond(Mat image, vector_Mat markerCorners, Mat markerIds, float squareMarkerLengthRate, vector_Mat& diamondCorners, Mat& diamondIds, Mat cameraMatrix = Mat(), Mat distCoeffs = Mat())
        //

        //javadoc: detectCharucoDiamond(image, markerCorners, markerIds, squareMarkerLengthRate, diamondCorners, diamondIds, cameraMatrix, distCoeffs)
        public static void detectCharucoDiamond(Mat image, List<Mat> markerCorners, Mat markerIds, float squareMarkerLengthRate, List<Mat> diamondCorners, Mat diamondIds, Mat cameraMatrix, Mat distCoeffs)
        {
            if (image != null) image.ThrowIfDisposed();
            if (markerIds != null) markerIds.ThrowIfDisposed();
            if (diamondIds != null) diamondIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat markerCorners_mat = Converters.vector_Mat_to_Mat(markerCorners);
        Mat diamondCorners_mat = new Mat();
        aruco_Aruco_detectCharucoDiamond_10(image.nativeObj, markerCorners_mat.nativeObj, markerIds.nativeObj, squareMarkerLengthRate, diamondCorners_mat.nativeObj, diamondIds.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj);
        Converters.Mat_to_vector_Mat(diamondCorners_mat, diamondCorners);
        diamondCorners_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: detectCharucoDiamond(image, markerCorners, markerIds, squareMarkerLengthRate, diamondCorners, diamondIds, cameraMatrix)
        public static void detectCharucoDiamond(Mat image, List<Mat> markerCorners, Mat markerIds, float squareMarkerLengthRate, List<Mat> diamondCorners, Mat diamondIds, Mat cameraMatrix)
        {
            if (image != null) image.ThrowIfDisposed();
            if (markerIds != null) markerIds.ThrowIfDisposed();
            if (diamondIds != null) diamondIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat markerCorners_mat = Converters.vector_Mat_to_Mat(markerCorners);
        Mat diamondCorners_mat = new Mat();
        aruco_Aruco_detectCharucoDiamond_11(image.nativeObj, markerCorners_mat.nativeObj, markerIds.nativeObj, squareMarkerLengthRate, diamondCorners_mat.nativeObj, diamondIds.nativeObj, cameraMatrix.nativeObj);
        Converters.Mat_to_vector_Mat(diamondCorners_mat, diamondCorners);
        diamondCorners_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: detectCharucoDiamond(image, markerCorners, markerIds, squareMarkerLengthRate, diamondCorners, diamondIds)
        public static void detectCharucoDiamond(Mat image, List<Mat> markerCorners, Mat markerIds, float squareMarkerLengthRate, List<Mat> diamondCorners, Mat diamondIds)
        {
            if (image != null) image.ThrowIfDisposed();
            if (markerIds != null) markerIds.ThrowIfDisposed();
            if (diamondIds != null) diamondIds.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat markerCorners_mat = Converters.vector_Mat_to_Mat(markerCorners);
        Mat diamondCorners_mat = new Mat();
        aruco_Aruco_detectCharucoDiamond_12(image.nativeObj, markerCorners_mat.nativeObj, markerIds.nativeObj, squareMarkerLengthRate, diamondCorners_mat.nativeObj, diamondIds.nativeObj);
        Converters.Mat_to_vector_Mat(diamondCorners_mat, diamondCorners);
        diamondCorners_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::aruco::detectMarkers(Mat image, Ptr_Dictionary dictionary, vector_Mat& corners, Mat& ids, Ptr_DetectorParameters parameters = DetectorParameters::create(), vector_Mat& rejectedImgPoints = vector_Mat(), Mat cameraMatrix = Mat(), Mat distCoeff = Mat())
        //

        //javadoc: detectMarkers(image, dictionary, corners, ids, parameters, rejectedImgPoints, cameraMatrix, distCoeff)
        public static void detectMarkers(Mat image, Dictionary dictionary, List<Mat> corners, Mat ids, DetectorParameters parameters, List<Mat> rejectedImgPoints, Mat cameraMatrix, Mat distCoeff)
        {
            if (image != null) image.ThrowIfDisposed();
            if (dictionary != null) dictionary.ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();
            if (parameters != null) parameters.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeff != null) distCoeff.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = new Mat();
        Mat rejectedImgPoints_mat = new Mat();
        aruco_Aruco_detectMarkers_10(image.nativeObj, dictionary.getNativeObjAddr(), corners_mat.nativeObj, ids.nativeObj, parameters.getNativeObjAddr(), rejectedImgPoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeff.nativeObj);
        Converters.Mat_to_vector_Mat(corners_mat, corners);
        corners_mat.release();
        Converters.Mat_to_vector_Mat(rejectedImgPoints_mat, rejectedImgPoints);
        rejectedImgPoints_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: detectMarkers(image, dictionary, corners, ids, parameters, rejectedImgPoints, cameraMatrix)
        public static void detectMarkers(Mat image, Dictionary dictionary, List<Mat> corners, Mat ids, DetectorParameters parameters, List<Mat> rejectedImgPoints, Mat cameraMatrix)
        {
            if (image != null) image.ThrowIfDisposed();
            if (dictionary != null) dictionary.ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();
            if (parameters != null) parameters.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = new Mat();
        Mat rejectedImgPoints_mat = new Mat();
        aruco_Aruco_detectMarkers_11(image.nativeObj, dictionary.getNativeObjAddr(), corners_mat.nativeObj, ids.nativeObj, parameters.getNativeObjAddr(), rejectedImgPoints_mat.nativeObj, cameraMatrix.nativeObj);
        Converters.Mat_to_vector_Mat(corners_mat, corners);
        corners_mat.release();
        Converters.Mat_to_vector_Mat(rejectedImgPoints_mat, rejectedImgPoints);
        rejectedImgPoints_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: detectMarkers(image, dictionary, corners, ids, parameters, rejectedImgPoints)
        public static void detectMarkers(Mat image, Dictionary dictionary, List<Mat> corners, Mat ids, DetectorParameters parameters, List<Mat> rejectedImgPoints)
        {
            if (image != null) image.ThrowIfDisposed();
            if (dictionary != null) dictionary.ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();
            if (parameters != null) parameters.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = new Mat();
        Mat rejectedImgPoints_mat = new Mat();
        aruco_Aruco_detectMarkers_12(image.nativeObj, dictionary.getNativeObjAddr(), corners_mat.nativeObj, ids.nativeObj, parameters.getNativeObjAddr(), rejectedImgPoints_mat.nativeObj);
        Converters.Mat_to_vector_Mat(corners_mat, corners);
        corners_mat.release();
        Converters.Mat_to_vector_Mat(rejectedImgPoints_mat, rejectedImgPoints);
        rejectedImgPoints_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: detectMarkers(image, dictionary, corners, ids, parameters)
        public static void detectMarkers(Mat image, Dictionary dictionary, List<Mat> corners, Mat ids, DetectorParameters parameters)
        {
            if (image != null) image.ThrowIfDisposed();
            if (dictionary != null) dictionary.ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();
            if (parameters != null) parameters.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = new Mat();
        aruco_Aruco_detectMarkers_13(image.nativeObj, dictionary.getNativeObjAddr(), corners_mat.nativeObj, ids.nativeObj, parameters.getNativeObjAddr());
        Converters.Mat_to_vector_Mat(corners_mat, corners);
        corners_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: detectMarkers(image, dictionary, corners, ids)
        public static void detectMarkers(Mat image, Dictionary dictionary, List<Mat> corners, Mat ids)
        {
            if (image != null) image.ThrowIfDisposed();
            if (dictionary != null) dictionary.ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = new Mat();
        aruco_Aruco_detectMarkers_14(image.nativeObj, dictionary.getNativeObjAddr(), corners_mat.nativeObj, ids.nativeObj);
        Converters.Mat_to_vector_Mat(corners_mat, corners);
        corners_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::aruco::drawAxis(Mat& image, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, float length)
        //

        //javadoc: drawAxis(image, cameraMatrix, distCoeffs, rvec, tvec, length)
        public static void drawAxis(Mat image, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, float length)
        {
            if (image != null) image.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Aruco_drawAxis_10(image.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj, length);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::aruco::drawDetectedCornersCharuco(Mat& image, Mat charucoCorners, Mat charucoIds = Mat(), Scalar cornerColor = Scalar(255, 0, 0))
        //

        //javadoc: drawDetectedCornersCharuco(image, charucoCorners, charucoIds, cornerColor)
        public static void drawDetectedCornersCharuco(Mat image, Mat charucoCorners, Mat charucoIds, Scalar cornerColor)
        {
            if (image != null) image.ThrowIfDisposed();
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Aruco_drawDetectedCornersCharuco_10(image.nativeObj, charucoCorners.nativeObj, charucoIds.nativeObj, cornerColor.val[0], cornerColor.val[1], cornerColor.val[2], cornerColor.val[3]);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawDetectedCornersCharuco(image, charucoCorners, charucoIds)
        public static void drawDetectedCornersCharuco(Mat image, Mat charucoCorners, Mat charucoIds)
        {
            if (image != null) image.ThrowIfDisposed();
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
            if (charucoIds != null) charucoIds.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Aruco_drawDetectedCornersCharuco_11(image.nativeObj, charucoCorners.nativeObj, charucoIds.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawDetectedCornersCharuco(image, charucoCorners)
        public static void drawDetectedCornersCharuco(Mat image, Mat charucoCorners)
        {
            if (image != null) image.ThrowIfDisposed();
            if (charucoCorners != null) charucoCorners.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Aruco_drawDetectedCornersCharuco_12(image.nativeObj, charucoCorners.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::aruco::drawDetectedDiamonds(Mat& image, vector_Mat diamondCorners, Mat diamondIds = Mat(), Scalar borderColor = Scalar(0, 0, 255))
        //

        //javadoc: drawDetectedDiamonds(image, diamondCorners, diamondIds, borderColor)
        public static void drawDetectedDiamonds(Mat image, List<Mat> diamondCorners, Mat diamondIds, Scalar borderColor)
        {
            if (image != null) image.ThrowIfDisposed();
            if (diamondIds != null) diamondIds.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat diamondCorners_mat = Converters.vector_Mat_to_Mat(diamondCorners);
        aruco_Aruco_drawDetectedDiamonds_10(image.nativeObj, diamondCorners_mat.nativeObj, diamondIds.nativeObj, borderColor.val[0], borderColor.val[1], borderColor.val[2], borderColor.val[3]);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawDetectedDiamonds(image, diamondCorners, diamondIds)
        public static void drawDetectedDiamonds(Mat image, List<Mat> diamondCorners, Mat diamondIds)
        {
            if (image != null) image.ThrowIfDisposed();
            if (diamondIds != null) diamondIds.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat diamondCorners_mat = Converters.vector_Mat_to_Mat(diamondCorners);
        aruco_Aruco_drawDetectedDiamonds_11(image.nativeObj, diamondCorners_mat.nativeObj, diamondIds.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawDetectedDiamonds(image, diamondCorners)
        public static void drawDetectedDiamonds(Mat image, List<Mat> diamondCorners)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat diamondCorners_mat = Converters.vector_Mat_to_Mat(diamondCorners);
        aruco_Aruco_drawDetectedDiamonds_12(image.nativeObj, diamondCorners_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::aruco::drawDetectedMarkers(Mat& image, vector_Mat corners, Mat ids = Mat(), Scalar borderColor = Scalar(0, 255, 0))
        //

        //javadoc: drawDetectedMarkers(image, corners, ids, borderColor)
        public static void drawDetectedMarkers(Mat image, List<Mat> corners, Mat ids, Scalar borderColor)
        {
            if (image != null) image.ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        aruco_Aruco_drawDetectedMarkers_10(image.nativeObj, corners_mat.nativeObj, ids.nativeObj, borderColor.val[0], borderColor.val[1], borderColor.val[2], borderColor.val[3]);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawDetectedMarkers(image, corners, ids)
        public static void drawDetectedMarkers(Mat image, List<Mat> corners, Mat ids)
        {
            if (image != null) image.ThrowIfDisposed();
            if (ids != null) ids.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        aruco_Aruco_drawDetectedMarkers_11(image.nativeObj, corners_mat.nativeObj, ids.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawDetectedMarkers(image, corners)
        public static void drawDetectedMarkers(Mat image, List<Mat> corners)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        aruco_Aruco_drawDetectedMarkers_12(image.nativeObj, corners_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::aruco::drawMarker(Ptr_Dictionary dictionary, int id, int sidePixels, Mat& img, int borderBits = 1)
        //

        //javadoc: drawMarker(dictionary, id, sidePixels, img, borderBits)
        public static void drawMarker(Dictionary dictionary, int id, int sidePixels, Mat img, int borderBits)
        {
            if (dictionary != null) dictionary.ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Aruco_drawMarker_10(dictionary.getNativeObjAddr(), id, sidePixels, img.nativeObj, borderBits);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawMarker(dictionary, id, sidePixels, img)
        public static void drawMarker(Dictionary dictionary, int id, int sidePixels, Mat img)
        {
            if (dictionary != null) dictionary.ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Aruco_drawMarker_11(dictionary.getNativeObjAddr(), id, sidePixels, img.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::aruco::drawPlanarBoard(Ptr_Board board, Size outSize, Mat& img, int marginSize = 0, int borderBits = 1)
        //

        //javadoc: drawPlanarBoard(board, outSize, img, marginSize, borderBits)
        public static void drawPlanarBoard(Board board, Size outSize, Mat img, int marginSize, int borderBits)
        {
            if (board != null) board.ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Aruco_drawPlanarBoard_10(board.getNativeObjAddr(), outSize.width, outSize.height, img.nativeObj, marginSize, borderBits);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawPlanarBoard(board, outSize, img, marginSize)
        public static void drawPlanarBoard(Board board, Size outSize, Mat img, int marginSize)
        {
            if (board != null) board.ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Aruco_drawPlanarBoard_11(board.getNativeObjAddr(), outSize.width, outSize.height, img.nativeObj, marginSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawPlanarBoard(board, outSize, img)
        public static void drawPlanarBoard(Board board, Size outSize, Mat img)
        {
            if (board != null) board.ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Aruco_drawPlanarBoard_12(board.getNativeObjAddr(), outSize.width, outSize.height, img.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::aruco::estimatePoseSingleMarkers(vector_Mat corners, float markerLength, Mat cameraMatrix, Mat distCoeffs, Mat& rvecs, Mat& tvecs, Mat& _objPoints = Mat())
        //

        //javadoc: estimatePoseSingleMarkers(corners, markerLength, cameraMatrix, distCoeffs, rvecs, tvecs, _objPoints)
        public static void estimatePoseSingleMarkers(List<Mat> corners, float markerLength, Mat cameraMatrix, Mat distCoeffs, Mat rvecs, Mat tvecs, Mat _objPoints)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvecs != null) rvecs.ThrowIfDisposed();
            if (tvecs != null) tvecs.ThrowIfDisposed();
            if (_objPoints != null) _objPoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        aruco_Aruco_estimatePoseSingleMarkers_10(corners_mat.nativeObj, markerLength, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs.nativeObj, tvecs.nativeObj, _objPoints.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: estimatePoseSingleMarkers(corners, markerLength, cameraMatrix, distCoeffs, rvecs, tvecs)
        public static void estimatePoseSingleMarkers(List<Mat> corners, float markerLength, Mat cameraMatrix, Mat distCoeffs, Mat rvecs, Mat tvecs)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvecs != null) rvecs.ThrowIfDisposed();
            if (tvecs != null) tvecs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat corners_mat = Converters.vector_Mat_to_Mat(corners);
        aruco_Aruco_estimatePoseSingleMarkers_11(corners_mat.nativeObj, markerLength, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs.nativeObj, tvecs.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::aruco::getBoardObjectAndImagePoints(Ptr_Board board, vector_Mat detectedCorners, Mat detectedIds, Mat& objPoints, Mat& imgPoints)
        //

        //javadoc: getBoardObjectAndImagePoints(board, detectedCorners, detectedIds, objPoints, imgPoints)
        public static void getBoardObjectAndImagePoints(Board board, List<Mat> detectedCorners, Mat detectedIds, Mat objPoints, Mat imgPoints)
        {
            if (board != null) board.ThrowIfDisposed();
            if (detectedIds != null) detectedIds.ThrowIfDisposed();
            if (objPoints != null) objPoints.ThrowIfDisposed();
            if (imgPoints != null) imgPoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat detectedCorners_mat = Converters.vector_Mat_to_Mat(detectedCorners);
        aruco_Aruco_getBoardObjectAndImagePoints_10(board.getNativeObjAddr(), detectedCorners_mat.nativeObj, detectedIds.nativeObj, objPoints.nativeObj, imgPoints.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::aruco::refineDetectedMarkers(Mat image, Ptr_Board board, vector_Mat& detectedCorners, Mat& detectedIds, vector_Mat& rejectedCorners, Mat cameraMatrix = Mat(), Mat distCoeffs = Mat(), float minRepDistance = 10.f, float errorCorrectionRate = 3.f, bool checkAllOrders = true, Mat& recoveredIdxs = Mat(), Ptr_DetectorParameters parameters = DetectorParameters::create())
        //

        //javadoc: refineDetectedMarkers(image, board, detectedCorners, detectedIds, rejectedCorners, cameraMatrix, distCoeffs, minRepDistance, errorCorrectionRate, checkAllOrders, recoveredIdxs, parameters)
        public static void refineDetectedMarkers(Mat image, Board board, List<Mat> detectedCorners, Mat detectedIds, List<Mat> rejectedCorners, Mat cameraMatrix, Mat distCoeffs, float minRepDistance, float errorCorrectionRate, bool checkAllOrders, Mat recoveredIdxs, DetectorParameters parameters)
        {
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (detectedIds != null) detectedIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (recoveredIdxs != null) recoveredIdxs.ThrowIfDisposed();
            if (parameters != null) parameters.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat detectedCorners_mat = Converters.vector_Mat_to_Mat(detectedCorners);
        Mat rejectedCorners_mat = Converters.vector_Mat_to_Mat(rejectedCorners);
        aruco_Aruco_refineDetectedMarkers_10(image.nativeObj, board.getNativeObjAddr(), detectedCorners_mat.nativeObj, detectedIds.nativeObj, rejectedCorners_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, minRepDistance, errorCorrectionRate, checkAllOrders, recoveredIdxs.nativeObj, parameters.getNativeObjAddr());
        Converters.Mat_to_vector_Mat(detectedCorners_mat, detectedCorners);
        detectedCorners_mat.release();
        Converters.Mat_to_vector_Mat(rejectedCorners_mat, rejectedCorners);
        rejectedCorners_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: refineDetectedMarkers(image, board, detectedCorners, detectedIds, rejectedCorners, cameraMatrix, distCoeffs, minRepDistance, errorCorrectionRate, checkAllOrders, recoveredIdxs)
        public static void refineDetectedMarkers(Mat image, Board board, List<Mat> detectedCorners, Mat detectedIds, List<Mat> rejectedCorners, Mat cameraMatrix, Mat distCoeffs, float minRepDistance, float errorCorrectionRate, bool checkAllOrders, Mat recoveredIdxs)
        {
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (detectedIds != null) detectedIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (recoveredIdxs != null) recoveredIdxs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat detectedCorners_mat = Converters.vector_Mat_to_Mat(detectedCorners);
        Mat rejectedCorners_mat = Converters.vector_Mat_to_Mat(rejectedCorners);
        aruco_Aruco_refineDetectedMarkers_11(image.nativeObj, board.getNativeObjAddr(), detectedCorners_mat.nativeObj, detectedIds.nativeObj, rejectedCorners_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, minRepDistance, errorCorrectionRate, checkAllOrders, recoveredIdxs.nativeObj);
        Converters.Mat_to_vector_Mat(detectedCorners_mat, detectedCorners);
        detectedCorners_mat.release();
        Converters.Mat_to_vector_Mat(rejectedCorners_mat, rejectedCorners);
        rejectedCorners_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: refineDetectedMarkers(image, board, detectedCorners, detectedIds, rejectedCorners, cameraMatrix, distCoeffs, minRepDistance, errorCorrectionRate, checkAllOrders)
        public static void refineDetectedMarkers(Mat image, Board board, List<Mat> detectedCorners, Mat detectedIds, List<Mat> rejectedCorners, Mat cameraMatrix, Mat distCoeffs, float minRepDistance, float errorCorrectionRate, bool checkAllOrders)
        {
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (detectedIds != null) detectedIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat detectedCorners_mat = Converters.vector_Mat_to_Mat(detectedCorners);
        Mat rejectedCorners_mat = Converters.vector_Mat_to_Mat(rejectedCorners);
        aruco_Aruco_refineDetectedMarkers_12(image.nativeObj, board.getNativeObjAddr(), detectedCorners_mat.nativeObj, detectedIds.nativeObj, rejectedCorners_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, minRepDistance, errorCorrectionRate, checkAllOrders);
        Converters.Mat_to_vector_Mat(detectedCorners_mat, detectedCorners);
        detectedCorners_mat.release();
        Converters.Mat_to_vector_Mat(rejectedCorners_mat, rejectedCorners);
        rejectedCorners_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: refineDetectedMarkers(image, board, detectedCorners, detectedIds, rejectedCorners, cameraMatrix, distCoeffs, minRepDistance, errorCorrectionRate)
        public static void refineDetectedMarkers(Mat image, Board board, List<Mat> detectedCorners, Mat detectedIds, List<Mat> rejectedCorners, Mat cameraMatrix, Mat distCoeffs, float minRepDistance, float errorCorrectionRate)
        {
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (detectedIds != null) detectedIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat detectedCorners_mat = Converters.vector_Mat_to_Mat(detectedCorners);
        Mat rejectedCorners_mat = Converters.vector_Mat_to_Mat(rejectedCorners);
        aruco_Aruco_refineDetectedMarkers_13(image.nativeObj, board.getNativeObjAddr(), detectedCorners_mat.nativeObj, detectedIds.nativeObj, rejectedCorners_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, minRepDistance, errorCorrectionRate);
        Converters.Mat_to_vector_Mat(detectedCorners_mat, detectedCorners);
        detectedCorners_mat.release();
        Converters.Mat_to_vector_Mat(rejectedCorners_mat, rejectedCorners);
        rejectedCorners_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: refineDetectedMarkers(image, board, detectedCorners, detectedIds, rejectedCorners, cameraMatrix, distCoeffs, minRepDistance)
        public static void refineDetectedMarkers(Mat image, Board board, List<Mat> detectedCorners, Mat detectedIds, List<Mat> rejectedCorners, Mat cameraMatrix, Mat distCoeffs, float minRepDistance)
        {
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (detectedIds != null) detectedIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat detectedCorners_mat = Converters.vector_Mat_to_Mat(detectedCorners);
        Mat rejectedCorners_mat = Converters.vector_Mat_to_Mat(rejectedCorners);
        aruco_Aruco_refineDetectedMarkers_14(image.nativeObj, board.getNativeObjAddr(), detectedCorners_mat.nativeObj, detectedIds.nativeObj, rejectedCorners_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, minRepDistance);
        Converters.Mat_to_vector_Mat(detectedCorners_mat, detectedCorners);
        detectedCorners_mat.release();
        Converters.Mat_to_vector_Mat(rejectedCorners_mat, rejectedCorners);
        rejectedCorners_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: refineDetectedMarkers(image, board, detectedCorners, detectedIds, rejectedCorners, cameraMatrix, distCoeffs)
        public static void refineDetectedMarkers(Mat image, Board board, List<Mat> detectedCorners, Mat detectedIds, List<Mat> rejectedCorners, Mat cameraMatrix, Mat distCoeffs)
        {
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (detectedIds != null) detectedIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat detectedCorners_mat = Converters.vector_Mat_to_Mat(detectedCorners);
        Mat rejectedCorners_mat = Converters.vector_Mat_to_Mat(rejectedCorners);
        aruco_Aruco_refineDetectedMarkers_15(image.nativeObj, board.getNativeObjAddr(), detectedCorners_mat.nativeObj, detectedIds.nativeObj, rejectedCorners_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj);
        Converters.Mat_to_vector_Mat(detectedCorners_mat, detectedCorners);
        detectedCorners_mat.release();
        Converters.Mat_to_vector_Mat(rejectedCorners_mat, rejectedCorners);
        rejectedCorners_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: refineDetectedMarkers(image, board, detectedCorners, detectedIds, rejectedCorners, cameraMatrix)
        public static void refineDetectedMarkers(Mat image, Board board, List<Mat> detectedCorners, Mat detectedIds, List<Mat> rejectedCorners, Mat cameraMatrix)
        {
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (detectedIds != null) detectedIds.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat detectedCorners_mat = Converters.vector_Mat_to_Mat(detectedCorners);
        Mat rejectedCorners_mat = Converters.vector_Mat_to_Mat(rejectedCorners);
        aruco_Aruco_refineDetectedMarkers_16(image.nativeObj, board.getNativeObjAddr(), detectedCorners_mat.nativeObj, detectedIds.nativeObj, rejectedCorners_mat.nativeObj, cameraMatrix.nativeObj);
        Converters.Mat_to_vector_Mat(detectedCorners_mat, detectedCorners);
        detectedCorners_mat.release();
        Converters.Mat_to_vector_Mat(rejectedCorners_mat, rejectedCorners);
        rejectedCorners_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: refineDetectedMarkers(image, board, detectedCorners, detectedIds, rejectedCorners)
        public static void refineDetectedMarkers(Mat image, Board board, List<Mat> detectedCorners, Mat detectedIds, List<Mat> rejectedCorners)
        {
            if (image != null) image.ThrowIfDisposed();
            if (board != null) board.ThrowIfDisposed();
            if (detectedIds != null) detectedIds.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat detectedCorners_mat = Converters.vector_Mat_to_Mat(detectedCorners);
        Mat rejectedCorners_mat = Converters.vector_Mat_to_Mat(rejectedCorners);
        aruco_Aruco_refineDetectedMarkers_17(image.nativeObj, board.getNativeObjAddr(), detectedCorners_mat.nativeObj, detectedIds.nativeObj, rejectedCorners_mat.nativeObj);
        Converters.Mat_to_vector_Mat(detectedCorners_mat, detectedCorners);
        detectedCorners_mat.release();
        Converters.Mat_to_vector_Mat(rejectedCorners_mat, rejectedCorners);
        rejectedCorners_mat.release();
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



        // C++:  Ptr_Dictionary cv::aruco::generateCustomDictionary(int nMarkers, int markerSize, Ptr_Dictionary baseDictionary, int randomSeed = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Aruco_custom_1dictionary_1from_10(int nMarkers, int markerSize, IntPtr baseDictionary_nativeObj, int randomSeed);
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Aruco_custom_1dictionary_1from_11(int nMarkers, int markerSize, IntPtr baseDictionary_nativeObj);

        // C++:  Ptr_Dictionary cv::aruco::generateCustomDictionary(int nMarkers, int markerSize, int randomSeed = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Aruco_custom_1dictionary_10(int nMarkers, int markerSize, int randomSeed);
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Aruco_custom_1dictionary_11(int nMarkers, int markerSize);

        // C++:  Ptr_Dictionary cv::aruco::getPredefinedDictionary(int dict)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Aruco_getPredefinedDictionary_10(int dict);

        // C++:  bool cv::aruco::estimatePoseCharucoBoard(Mat charucoCorners, Mat charucoIds, Ptr_CharucoBoard board, Mat cameraMatrix, Mat distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool aruco_Aruco_estimatePoseCharucoBoard_10(IntPtr charucoCorners_nativeObj, IntPtr charucoIds_nativeObj, IntPtr board_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool aruco_Aruco_estimatePoseCharucoBoard_11(IntPtr charucoCorners_nativeObj, IntPtr charucoIds_nativeObj, IntPtr board_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj);

        // C++:  double cv::aruco::calibrateCameraAruco(vector_Mat corners, Mat ids, Mat counter, Ptr_Board board, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraArucoExtended_10(IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr counter_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr perViewErrors_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraArucoExtended_11(IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr counter_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr perViewErrors_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraArucoExtended_12(IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr counter_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr perViewErrors_nativeObj);

        // C++:  double cv::aruco::calibrateCameraAruco(vector_Mat corners, Mat ids, Mat counter, Ptr_Board board, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs = vector_Mat(), vector_Mat& tvecs = vector_Mat(), int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraAruco_10(IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr counter_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraAruco_11(IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr counter_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraAruco_12(IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr counter_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraAruco_13(IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr counter_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraAruco_14(IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr counter_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);

        // C++:  double cv::aruco::calibrateCameraCharuco(vector_Mat charucoCorners, vector_Mat charucoIds, Ptr_CharucoBoard board, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraCharucoExtended_10(IntPtr charucoCorners_mat_nativeObj, IntPtr charucoIds_mat_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr perViewErrors_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraCharucoExtended_11(IntPtr charucoCorners_mat_nativeObj, IntPtr charucoIds_mat_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr perViewErrors_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraCharucoExtended_12(IntPtr charucoCorners_mat_nativeObj, IntPtr charucoIds_mat_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr perViewErrors_nativeObj);

        // C++:  double cv::aruco::calibrateCameraCharuco(vector_Mat charucoCorners, vector_Mat charucoIds, Ptr_CharucoBoard board, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs = vector_Mat(), vector_Mat& tvecs = vector_Mat(), int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraCharuco_10(IntPtr charucoCorners_mat_nativeObj, IntPtr charucoIds_mat_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraCharuco_11(IntPtr charucoCorners_mat_nativeObj, IntPtr charucoIds_mat_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraCharuco_12(IntPtr charucoCorners_mat_nativeObj, IntPtr charucoIds_mat_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraCharuco_13(IntPtr charucoCorners_mat_nativeObj, IntPtr charucoIds_mat_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern double aruco_Aruco_calibrateCameraCharuco_14(IntPtr charucoCorners_mat_nativeObj, IntPtr charucoIds_mat_nativeObj, IntPtr board_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);

        // C++:  int cv::aruco::estimatePoseBoard(vector_Mat corners, Mat ids, Ptr_Board board, Mat cameraMatrix, Mat distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false)
        [DllImport(LIBNAME)]
        private static extern int aruco_Aruco_estimatePoseBoard_10(IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr board_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess);
        [DllImport(LIBNAME)]
        private static extern int aruco_Aruco_estimatePoseBoard_11(IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr board_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj);

        // C++:  int cv::aruco::interpolateCornersCharuco(vector_Mat markerCorners, Mat markerIds, Mat image, Ptr_CharucoBoard board, Mat& charucoCorners, Mat& charucoIds, Mat cameraMatrix = Mat(), Mat distCoeffs = Mat(), int minMarkers = 2)
        [DllImport(LIBNAME)]
        private static extern int aruco_Aruco_interpolateCornersCharuco_10(IntPtr markerCorners_mat_nativeObj, IntPtr markerIds_nativeObj, IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr charucoCorners_nativeObj, IntPtr charucoIds_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, int minMarkers);
        [DllImport(LIBNAME)]
        private static extern int aruco_Aruco_interpolateCornersCharuco_11(IntPtr markerCorners_mat_nativeObj, IntPtr markerIds_nativeObj, IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr charucoCorners_nativeObj, IntPtr charucoIds_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int aruco_Aruco_interpolateCornersCharuco_12(IntPtr markerCorners_mat_nativeObj, IntPtr markerIds_nativeObj, IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr charucoCorners_nativeObj, IntPtr charucoIds_nativeObj, IntPtr cameraMatrix_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int aruco_Aruco_interpolateCornersCharuco_13(IntPtr markerCorners_mat_nativeObj, IntPtr markerIds_nativeObj, IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr charucoCorners_nativeObj, IntPtr charucoIds_nativeObj);

        // C++:  void cv::aruco::detectCharucoDiamond(Mat image, vector_Mat markerCorners, Mat markerIds, float squareMarkerLengthRate, vector_Mat& diamondCorners, Mat& diamondIds, Mat cameraMatrix = Mat(), Mat distCoeffs = Mat())
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_detectCharucoDiamond_10(IntPtr image_nativeObj, IntPtr markerCorners_mat_nativeObj, IntPtr markerIds_nativeObj, float squareMarkerLengthRate, IntPtr diamondCorners_mat_nativeObj, IntPtr diamondIds_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_detectCharucoDiamond_11(IntPtr image_nativeObj, IntPtr markerCorners_mat_nativeObj, IntPtr markerIds_nativeObj, float squareMarkerLengthRate, IntPtr diamondCorners_mat_nativeObj, IntPtr diamondIds_nativeObj, IntPtr cameraMatrix_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_detectCharucoDiamond_12(IntPtr image_nativeObj, IntPtr markerCorners_mat_nativeObj, IntPtr markerIds_nativeObj, float squareMarkerLengthRate, IntPtr diamondCorners_mat_nativeObj, IntPtr diamondIds_nativeObj);

        // C++:  void cv::aruco::detectMarkers(Mat image, Ptr_Dictionary dictionary, vector_Mat& corners, Mat& ids, Ptr_DetectorParameters parameters = DetectorParameters::create(), vector_Mat& rejectedImgPoints = vector_Mat(), Mat cameraMatrix = Mat(), Mat distCoeff = Mat())
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_detectMarkers_10(IntPtr image_nativeObj, IntPtr dictionary_nativeObj, IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr parameters_nativeObj, IntPtr rejectedImgPoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeff_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_detectMarkers_11(IntPtr image_nativeObj, IntPtr dictionary_nativeObj, IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr parameters_nativeObj, IntPtr rejectedImgPoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_detectMarkers_12(IntPtr image_nativeObj, IntPtr dictionary_nativeObj, IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr parameters_nativeObj, IntPtr rejectedImgPoints_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_detectMarkers_13(IntPtr image_nativeObj, IntPtr dictionary_nativeObj, IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, IntPtr parameters_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_detectMarkers_14(IntPtr image_nativeObj, IntPtr dictionary_nativeObj, IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj);

        // C++:  void cv::aruco::drawAxis(Mat& image, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, float length)
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawAxis_10(IntPtr image_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, float length);

        // C++:  void cv::aruco::drawDetectedCornersCharuco(Mat& image, Mat charucoCorners, Mat charucoIds = Mat(), Scalar cornerColor = Scalar(255, 0, 0))
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawDetectedCornersCharuco_10(IntPtr image_nativeObj, IntPtr charucoCorners_nativeObj, IntPtr charucoIds_nativeObj, double cornerColor_val0, double cornerColor_val1, double cornerColor_val2, double cornerColor_val3);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawDetectedCornersCharuco_11(IntPtr image_nativeObj, IntPtr charucoCorners_nativeObj, IntPtr charucoIds_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawDetectedCornersCharuco_12(IntPtr image_nativeObj, IntPtr charucoCorners_nativeObj);

        // C++:  void cv::aruco::drawDetectedDiamonds(Mat& image, vector_Mat diamondCorners, Mat diamondIds = Mat(), Scalar borderColor = Scalar(0, 0, 255))
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawDetectedDiamonds_10(IntPtr image_nativeObj, IntPtr diamondCorners_mat_nativeObj, IntPtr diamondIds_nativeObj, double borderColor_val0, double borderColor_val1, double borderColor_val2, double borderColor_val3);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawDetectedDiamonds_11(IntPtr image_nativeObj, IntPtr diamondCorners_mat_nativeObj, IntPtr diamondIds_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawDetectedDiamonds_12(IntPtr image_nativeObj, IntPtr diamondCorners_mat_nativeObj);

        // C++:  void cv::aruco::drawDetectedMarkers(Mat& image, vector_Mat corners, Mat ids = Mat(), Scalar borderColor = Scalar(0, 255, 0))
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawDetectedMarkers_10(IntPtr image_nativeObj, IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj, double borderColor_val0, double borderColor_val1, double borderColor_val2, double borderColor_val3);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawDetectedMarkers_11(IntPtr image_nativeObj, IntPtr corners_mat_nativeObj, IntPtr ids_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawDetectedMarkers_12(IntPtr image_nativeObj, IntPtr corners_mat_nativeObj);

        // C++:  void cv::aruco::drawMarker(Ptr_Dictionary dictionary, int id, int sidePixels, Mat& img, int borderBits = 1)
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawMarker_10(IntPtr dictionary_nativeObj, int id, int sidePixels, IntPtr img_nativeObj, int borderBits);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawMarker_11(IntPtr dictionary_nativeObj, int id, int sidePixels, IntPtr img_nativeObj);

        // C++:  void cv::aruco::drawPlanarBoard(Ptr_Board board, Size outSize, Mat& img, int marginSize = 0, int borderBits = 1)
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawPlanarBoard_10(IntPtr board_nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj, int marginSize, int borderBits);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawPlanarBoard_11(IntPtr board_nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj, int marginSize);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_drawPlanarBoard_12(IntPtr board_nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj);

        // C++:  void cv::aruco::estimatePoseSingleMarkers(vector_Mat corners, float markerLength, Mat cameraMatrix, Mat distCoeffs, Mat& rvecs, Mat& tvecs, Mat& _objPoints = Mat())
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_estimatePoseSingleMarkers_10(IntPtr corners_mat_nativeObj, float markerLength, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_nativeObj, IntPtr tvecs_nativeObj, IntPtr _objPoints_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_estimatePoseSingleMarkers_11(IntPtr corners_mat_nativeObj, float markerLength, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_nativeObj, IntPtr tvecs_nativeObj);

        // C++:  void cv::aruco::getBoardObjectAndImagePoints(Ptr_Board board, vector_Mat detectedCorners, Mat detectedIds, Mat& objPoints, Mat& imgPoints)
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_getBoardObjectAndImagePoints_10(IntPtr board_nativeObj, IntPtr detectedCorners_mat_nativeObj, IntPtr detectedIds_nativeObj, IntPtr objPoints_nativeObj, IntPtr imgPoints_nativeObj);

        // C++:  void cv::aruco::refineDetectedMarkers(Mat image, Ptr_Board board, vector_Mat& detectedCorners, Mat& detectedIds, vector_Mat& rejectedCorners, Mat cameraMatrix = Mat(), Mat distCoeffs = Mat(), float minRepDistance = 10.f, float errorCorrectionRate = 3.f, bool checkAllOrders = true, Mat& recoveredIdxs = Mat(), Ptr_DetectorParameters parameters = DetectorParameters::create())
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_refineDetectedMarkers_10(IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr detectedCorners_mat_nativeObj, IntPtr detectedIds_nativeObj, IntPtr rejectedCorners_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, float minRepDistance, float errorCorrectionRate, [MarshalAs(UnmanagedType.U1)] bool checkAllOrders, IntPtr recoveredIdxs_nativeObj, IntPtr parameters_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_refineDetectedMarkers_11(IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr detectedCorners_mat_nativeObj, IntPtr detectedIds_nativeObj, IntPtr rejectedCorners_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, float minRepDistance, float errorCorrectionRate, [MarshalAs(UnmanagedType.U1)] bool checkAllOrders, IntPtr recoveredIdxs_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_refineDetectedMarkers_12(IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr detectedCorners_mat_nativeObj, IntPtr detectedIds_nativeObj, IntPtr rejectedCorners_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, float minRepDistance, float errorCorrectionRate, [MarshalAs(UnmanagedType.U1)] bool checkAllOrders);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_refineDetectedMarkers_13(IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr detectedCorners_mat_nativeObj, IntPtr detectedIds_nativeObj, IntPtr rejectedCorners_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, float minRepDistance, float errorCorrectionRate);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_refineDetectedMarkers_14(IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr detectedCorners_mat_nativeObj, IntPtr detectedIds_nativeObj, IntPtr rejectedCorners_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, float minRepDistance);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_refineDetectedMarkers_15(IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr detectedCorners_mat_nativeObj, IntPtr detectedIds_nativeObj, IntPtr rejectedCorners_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_refineDetectedMarkers_16(IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr detectedCorners_mat_nativeObj, IntPtr detectedIds_nativeObj, IntPtr rejectedCorners_mat_nativeObj, IntPtr cameraMatrix_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void aruco_Aruco_refineDetectedMarkers_17(IntPtr image_nativeObj, IntPtr board_nativeObj, IntPtr detectedCorners_mat_nativeObj, IntPtr detectedIds_nativeObj, IntPtr rejectedCorners_mat_nativeObj);

    }
}
