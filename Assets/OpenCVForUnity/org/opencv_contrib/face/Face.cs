
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{
    // C++: class Face
    //javadoc: Face

    public class Face
    {

        //
        // C++:  Ptr_Facemark cv::face::createFacemarkAAM()
        //

        //javadoc: createFacemarkAAM()
        public static Facemark createFacemarkAAM()
        {
#if UNITY_5_3_OR_NEWER
        
        Facemark retVal = Facemark.__fromPtr__(face_Face_createFacemarkAAM_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_Facemark cv::face::createFacemarkKazemi()
        //

        //javadoc: createFacemarkKazemi()
        public static Facemark createFacemarkKazemi()
        {
#if UNITY_5_3_OR_NEWER
        
        Facemark retVal = Facemark.__fromPtr__(face_Face_createFacemarkKazemi_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_Facemark cv::face::createFacemarkLBF()
        //

        //javadoc: createFacemarkLBF()
        public static Facemark createFacemarkLBF()
        {
#if UNITY_5_3_OR_NEWER
        
        Facemark retVal = Facemark.__fromPtr__(face_Face_createFacemarkLBF_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::face::getFacesHAAR(Mat image, Mat& faces, String face_cascade_name)
        //

        //javadoc: getFacesHAAR(image, faces, face_cascade_name)
        public static bool getFacesHAAR(Mat image, Mat faces, string face_cascade_name)
        {
            if (image != null) image.ThrowIfDisposed();
            if (faces != null) faces.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = face_Face_getFacesHAAR_10(image.nativeObj, faces.nativeObj, face_cascade_name);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::face::loadDatasetList(String imageList, String annotationList, vector_String images, vector_String annotations)
        //

        //javadoc: loadDatasetList(imageList, annotationList, images, annotations)
        public static bool loadDatasetList(string imageList, string annotationList, List<string> images, List<string> annotations)
        {
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_String_to_Mat(images);
        Mat annotations_mat = Converters.vector_String_to_Mat(annotations);
        bool retVal = face_Face_loadDatasetList_10(imageList, annotationList, images_mat.nativeObj, annotations_mat.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::face::loadFacePoints(String filename, Mat& points, float offset = 0.0f)
        //

        //javadoc: loadFacePoints(filename, points, offset)
        public static bool loadFacePoints(string filename, Mat points, float offset)
        {
            if (points != null) points.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = face_Face_loadFacePoints_10(filename, points.nativeObj, offset);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: loadFacePoints(filename, points)
        public static bool loadFacePoints(string filename, Mat points)
        {
            if (points != null) points.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = face_Face_loadFacePoints_11(filename, points.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::face::loadTrainingData(String filename, vector_String images, Mat& facePoints, char delim = ' ', float offset = 0.0f)
        //

        //javadoc: loadTrainingData(filename, images, facePoints, delim, offset)
        public static bool loadTrainingData(string filename, List<string> images, Mat facePoints, char delim, float offset)
        {
            if (facePoints != null) facePoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_String_to_Mat(images);
        bool retVal = face_Face_loadTrainingData_10(filename, images_mat.nativeObj, facePoints.nativeObj, delim, offset);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: loadTrainingData(filename, images, facePoints, delim)
        public static bool loadTrainingData(string filename, List<string> images, Mat facePoints, char delim)
        {
            if (facePoints != null) facePoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_String_to_Mat(images);
        bool retVal = face_Face_loadTrainingData_11(filename, images_mat.nativeObj, facePoints.nativeObj, delim);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: loadTrainingData(filename, images, facePoints)
        public static bool loadTrainingData(string filename, List<string> images, Mat facePoints)
        {
            if (facePoints != null) facePoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_String_to_Mat(images);
        bool retVal = face_Face_loadTrainingData_12(filename, images_mat.nativeObj, facePoints.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::face::loadTrainingData(String imageList, String groundTruth, vector_String images, Mat& facePoints, float offset = 0.0f)
        //

        //javadoc: loadTrainingData(imageList, groundTruth, images, facePoints, offset)
        public static bool loadTrainingData(string imageList, string groundTruth, List<string> images, Mat facePoints, float offset)
        {
            if (facePoints != null) facePoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_String_to_Mat(images);
        bool retVal = face_Face_loadTrainingData_13(imageList, groundTruth, images_mat.nativeObj, facePoints.nativeObj, offset);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: loadTrainingData(imageList, groundTruth, images, facePoints)
        public static bool loadTrainingData(string imageList, string groundTruth, List<string> images, Mat facePoints)
        {
            if (facePoints != null) facePoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_String_to_Mat(images);
        bool retVal = face_Face_loadTrainingData_14(imageList, groundTruth, images_mat.nativeObj, facePoints.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::face::loadTrainingData(vector_String filename, vector_vector_Point2f trainlandmarks, vector_String trainimages)
        //

        //javadoc: loadTrainingData(filename, trainlandmarks, trainimages)
        public static bool loadTrainingData(List<string> filename, List<MatOfPoint2f> trainlandmarks, List<string> trainimages)
        {
#if UNITY_5_3_OR_NEWER
        Mat filename_mat = Converters.vector_String_to_Mat(filename);
        List<Mat> trainlandmarks_tmplm = new List<Mat>((trainlandmarks != null) ? trainlandmarks.Count : 0);
        Mat trainlandmarks_mat = Converters.vector_vector_Point2f_to_Mat(trainlandmarks, trainlandmarks_tmplm);
        Mat trainimages_mat = Converters.vector_String_to_Mat(trainimages);
        bool retVal = face_Face_loadTrainingData_15(filename_mat.nativeObj, trainlandmarks_mat.nativeObj, trainimages_mat.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  void cv::face::drawFacemarks(Mat& image, Mat points, Scalar color = Scalar(255,0,0))
        //

        //javadoc: drawFacemarks(image, points, color)
        public static void drawFacemarks(Mat image, Mat points, Scalar color)
        {
            if (image != null) image.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_Face_drawFacemarks_10(image.nativeObj, points.nativeObj, color.val[0], color.val[1], color.val[2], color.val[3]);
        
        return;
#else
            return;
#endif
        }

        //javadoc: drawFacemarks(image, points)
        public static void drawFacemarks(Mat image, Mat points)
        {
            if (image != null) image.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_Face_drawFacemarks_11(image.nativeObj, points.nativeObj);
        
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



        // C++:  Ptr_Facemark cv::face::createFacemarkAAM()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createFacemarkAAM_10();

        // C++:  Ptr_Facemark cv::face::createFacemarkKazemi()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createFacemarkKazemi_10();

        // C++:  Ptr_Facemark cv::face::createFacemarkLBF()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createFacemarkLBF_10();

        // C++:  bool cv::face::getFacesHAAR(Mat image, Mat& faces, String face_cascade_name)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_getFacesHAAR_10(IntPtr image_nativeObj, IntPtr faces_nativeObj, string face_cascade_name);

        // C++:  bool cv::face::loadDatasetList(String imageList, String annotationList, vector_String images, vector_String annotations)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadDatasetList_10(string imageList, string annotationList, IntPtr images_mat_nativeObj, IntPtr annotations_mat_nativeObj);

        // C++:  bool cv::face::loadFacePoints(String filename, Mat& points, float offset = 0.0f)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadFacePoints_10(string filename, IntPtr points_nativeObj, float offset);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadFacePoints_11(string filename, IntPtr points_nativeObj);

        // C++:  bool cv::face::loadTrainingData(String filename, vector_String images, Mat& facePoints, char delim = ' ', float offset = 0.0f)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadTrainingData_10(string filename, IntPtr images_mat_nativeObj, IntPtr facePoints_nativeObj, char delim, float offset);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadTrainingData_11(string filename, IntPtr images_mat_nativeObj, IntPtr facePoints_nativeObj, char delim);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadTrainingData_12(string filename, IntPtr images_mat_nativeObj, IntPtr facePoints_nativeObj);

        // C++:  bool cv::face::loadTrainingData(String imageList, String groundTruth, vector_String images, Mat& facePoints, float offset = 0.0f)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadTrainingData_13(string imageList, string groundTruth, IntPtr images_mat_nativeObj, IntPtr facePoints_nativeObj, float offset);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadTrainingData_14(string imageList, string groundTruth, IntPtr images_mat_nativeObj, IntPtr facePoints_nativeObj);

        // C++:  bool cv::face::loadTrainingData(vector_String filename, vector_vector_Point2f trainlandmarks, vector_String trainimages)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Face_loadTrainingData_15(IntPtr filename_mat_nativeObj, IntPtr trainlandmarks_mat_nativeObj, IntPtr trainimages_mat_nativeObj);

        // C++:  void cv::face::drawFacemarks(Mat& image, Mat points, Scalar color = Scalar(255,0,0))
        [DllImport(LIBNAME)]
        private static extern void face_Face_drawFacemarks_10(IntPtr image_nativeObj, IntPtr points_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3);
        [DllImport(LIBNAME)]
        private static extern void face_Face_drawFacemarks_11(IntPtr image_nativeObj, IntPtr points_nativeObj);

    }
}
