
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class Feature2D
    //javadoc: Feature2D

    public class Feature2D : Algorithm
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
                        features2d_Feature2D_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Feature2D(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new Feature2D __fromPtr__(IntPtr addr) { return new Feature2D(addr); }

        //
        // C++:  String cv::Feature2D::getDefaultName()
        //

        //javadoc: Feature2D::getDefaultName()
        public override string getDefaultName()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (features2d_Feature2D_getDefaultName_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::Feature2D::empty()
        //

        //javadoc: Feature2D::empty()
        public override bool empty()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = features2d_Feature2D_empty_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  int cv::Feature2D::defaultNorm()
        //

        //javadoc: Feature2D::defaultNorm()
        public int defaultNorm()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_Feature2D_defaultNorm_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::Feature2D::descriptorSize()
        //

        //javadoc: Feature2D::descriptorSize()
        public int descriptorSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_Feature2D_descriptorSize_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::Feature2D::descriptorType()
        //

        //javadoc: Feature2D::descriptorType()
        public int descriptorType()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_Feature2D_descriptorType_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::Feature2D::compute(Mat image, vector_KeyPoint& keypoints, Mat& descriptors)
        //

        //javadoc: Feature2D::compute(image, keypoints, descriptors)
        public void compute(Mat image, MatOfKeyPoint keypoints, Mat descriptors)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (keypoints != null) keypoints.ThrowIfDisposed();
            if (descriptors != null) descriptors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints_mat = keypoints;
        features2d_Feature2D_compute_10(nativeObj, image.nativeObj, keypoints_mat.nativeObj, descriptors.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::Feature2D::compute(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat& descriptors)
        //

        //javadoc: Feature2D::compute(images, keypoints, descriptors)
        public void compute(List<Mat> images, List<MatOfKeyPoint> keypoints, List<Mat> descriptors)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_Mat_to_Mat(images);
        List<Mat> keypoints_tmplm = new List<Mat>((keypoints != null) ? keypoints.Count : 0);
        Mat keypoints_mat = Converters.vector_vector_KeyPoint_to_Mat(keypoints, keypoints_tmplm);
        Mat descriptors_mat = new Mat();
        features2d_Feature2D_compute_11(nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj, descriptors_mat.nativeObj);
        Converters.Mat_to_vector_vector_KeyPoint(keypoints_mat, keypoints);
        keypoints_mat.release();
        Converters.Mat_to_vector_Mat(descriptors_mat, descriptors);
        descriptors_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::Feature2D::detect(Mat image, vector_KeyPoint& keypoints, Mat mask = Mat())
        //

        //javadoc: Feature2D::detect(image, keypoints, mask)
        public void detect(Mat image, MatOfKeyPoint keypoints, Mat mask)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (keypoints != null) keypoints.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints_mat = keypoints;
        features2d_Feature2D_detect_10(nativeObj, image.nativeObj, keypoints_mat.nativeObj, mask.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Feature2D::detect(image, keypoints)
        public void detect(Mat image, MatOfKeyPoint keypoints)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (keypoints != null) keypoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints_mat = keypoints;
        features2d_Feature2D_detect_11(nativeObj, image.nativeObj, keypoints_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::Feature2D::detect(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat masks = vector_Mat())
        //

        //javadoc: Feature2D::detect(images, keypoints, masks)
        public void detect(List<Mat> images, List<MatOfKeyPoint> keypoints, List<Mat> masks)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_Mat_to_Mat(images);
        Mat keypoints_mat = new Mat();
        Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
        features2d_Feature2D_detect_12(nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj, masks_mat.nativeObj);
        Converters.Mat_to_vector_vector_KeyPoint(keypoints_mat, keypoints);
        keypoints_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: Feature2D::detect(images, keypoints)
        public void detect(List<Mat> images, List<MatOfKeyPoint> keypoints)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_Mat_to_Mat(images);
        Mat keypoints_mat = new Mat();
        features2d_Feature2D_detect_13(nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj);
        Converters.Mat_to_vector_vector_KeyPoint(keypoints_mat, keypoints);
        keypoints_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::Feature2D::detectAndCompute(Mat image, Mat mask, vector_KeyPoint& keypoints, Mat& descriptors, bool useProvidedKeypoints = false)
        //

        //javadoc: Feature2D::detectAndCompute(image, mask, keypoints, descriptors, useProvidedKeypoints)
        public void detectAndCompute(Mat image, Mat mask, MatOfKeyPoint keypoints, Mat descriptors, bool useProvidedKeypoints)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (keypoints != null) keypoints.ThrowIfDisposed();
            if (descriptors != null) descriptors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints_mat = keypoints;
        features2d_Feature2D_detectAndCompute_10(nativeObj, image.nativeObj, mask.nativeObj, keypoints_mat.nativeObj, descriptors.nativeObj, useProvidedKeypoints);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Feature2D::detectAndCompute(image, mask, keypoints, descriptors)
        public void detectAndCompute(Mat image, Mat mask, MatOfKeyPoint keypoints, Mat descriptors)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (keypoints != null) keypoints.ThrowIfDisposed();
            if (descriptors != null) descriptors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat keypoints_mat = keypoints;
        features2d_Feature2D_detectAndCompute_11(nativeObj, image.nativeObj, mask.nativeObj, keypoints_mat.nativeObj, descriptors.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::Feature2D::read(FileNode arg1)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  void cv::Feature2D::read(String fileName)
        //

        //javadoc: Feature2D::read(fileName)
        public void read(string fileName)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Feature2D_read_10(nativeObj, fileName);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::Feature2D::write(Ptr_FileStorage fs, String name = String())
        //

        // Unknown type 'Ptr_FileStorage' (I), skipping the function


        //
        // C++:  void cv::Feature2D::write(String fileName)
        //

        //javadoc: Feature2D::write(fileName)
        public void write(string fileName)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Feature2D_write_10(nativeObj, fileName);
        
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



        // C++:  String cv::Feature2D::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_Feature2D_getDefaultName_10(IntPtr nativeObj);

        // C++:  bool cv::Feature2D::empty()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_Feature2D_empty_10(IntPtr nativeObj);

        // C++:  int cv::Feature2D::defaultNorm()
        [DllImport(LIBNAME)]
        private static extern int features2d_Feature2D_defaultNorm_10(IntPtr nativeObj);

        // C++:  int cv::Feature2D::descriptorSize()
        [DllImport(LIBNAME)]
        private static extern int features2d_Feature2D_descriptorSize_10(IntPtr nativeObj);

        // C++:  int cv::Feature2D::descriptorType()
        [DllImport(LIBNAME)]
        private static extern int features2d_Feature2D_descriptorType_10(IntPtr nativeObj);

        // C++:  void cv::Feature2D::compute(Mat image, vector_KeyPoint& keypoints, Mat& descriptors)
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_compute_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj);

        // C++:  void cv::Feature2D::compute(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat& descriptors)
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_compute_11(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_mat_nativeObj);

        // C++:  void cv::Feature2D::detect(Mat image, vector_KeyPoint& keypoints, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detect_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detect_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj);

        // C++:  void cv::Feature2D::detect(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat masks = vector_Mat())
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detect_12(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr masks_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detect_13(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj);

        // C++:  void cv::Feature2D::detectAndCompute(Mat image, Mat mask, vector_KeyPoint& keypoints, Mat& descriptors, bool useProvidedKeypoints = false)
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detectAndCompute_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useProvidedKeypoints);
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detectAndCompute_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj);

        // C++:  void cv::Feature2D::read(String fileName)
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_read_10(IntPtr nativeObj, string fileName);

        // C++:  void cv::Feature2D::write(String fileName)
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_write_10(IntPtr nativeObj, string fileName);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_delete(IntPtr nativeObj);

    }
}
