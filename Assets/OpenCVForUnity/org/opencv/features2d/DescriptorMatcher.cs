
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class DescriptorMatcher
    //javadoc: DescriptorMatcher

    public class DescriptorMatcher : Algorithm
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
                        features2d_DescriptorMatcher_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DescriptorMatcher(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DescriptorMatcher __fromPtr__(IntPtr addr) { return new DescriptorMatcher(addr); }

        // C++: enum MatcherType
        public const int FLANNBASED = 1;
        public const int BRUTEFORCE = 2;
        public const int BRUTEFORCE_L1 = 3;
        public const int BRUTEFORCE_HAMMING = 4;
        public const int BRUTEFORCE_HAMMINGLUT = 5;
        public const int BRUTEFORCE_SL2 = 6;
        //
        // C++:  Ptr_DescriptorMatcher cv::DescriptorMatcher::clone(bool emptyTrainData = false)
        //

        //javadoc: DescriptorMatcher::clone(emptyTrainData)
        public DescriptorMatcher clone(bool emptyTrainData)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        DescriptorMatcher retVal = DescriptorMatcher.__fromPtr__(features2d_DescriptorMatcher_clone_10(nativeObj, emptyTrainData));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DescriptorMatcher::clone()
        public DescriptorMatcher clone()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        DescriptorMatcher retVal = DescriptorMatcher.__fromPtr__(features2d_DescriptorMatcher_clone_11(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_DescriptorMatcher cv::DescriptorMatcher::create(DescriptorMatcher_MatcherType matcherType)
        //

        //javadoc: DescriptorMatcher::create(matcherType)
        public static DescriptorMatcher create(int matcherType)
        {
#if UNITY_5_3_OR_NEWER
        
        DescriptorMatcher retVal = DescriptorMatcher.__fromPtr__(features2d_DescriptorMatcher_create_10(matcherType));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_DescriptorMatcher cv::DescriptorMatcher::create(String descriptorMatcherType)
        //

        //javadoc: DescriptorMatcher::create(descriptorMatcherType)
        public static DescriptorMatcher create(string descriptorMatcherType)
        {
#if UNITY_5_3_OR_NEWER
        
        DescriptorMatcher retVal = DescriptorMatcher.__fromPtr__(features2d_DescriptorMatcher_create_11(descriptorMatcherType));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::DescriptorMatcher::empty()
        //

        //javadoc: DescriptorMatcher::empty()
        public override bool empty()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = features2d_DescriptorMatcher_empty_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::DescriptorMatcher::isMaskSupported()
        //

        //javadoc: DescriptorMatcher::isMaskSupported()
        public bool isMaskSupported()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = features2d_DescriptorMatcher_isMaskSupported_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  vector_Mat cv::DescriptorMatcher::getTrainDescriptors()
        //

        //javadoc: DescriptorMatcher::getTrainDescriptors()
        public List<Mat> getTrainDescriptors()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        List<Mat> retVal = new List<Mat>();
        Mat retValMat = new Mat(features2d_DescriptorMatcher_getTrainDescriptors_10(nativeObj));
        Converters.Mat_to_vector_Mat(retValMat, retVal);
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::DescriptorMatcher::add(vector_Mat descriptors)
        //

        //javadoc: DescriptorMatcher::add(descriptors)
        public void add(List<Mat> descriptors)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat descriptors_mat = Converters.vector_Mat_to_Mat(descriptors);
        features2d_DescriptorMatcher_add_10(nativeObj, descriptors_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DescriptorMatcher::clear()
        //

        //javadoc: DescriptorMatcher::clear()
        public override void clear()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_DescriptorMatcher_clear_10(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DescriptorMatcher::knnMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
        //

        //javadoc: DescriptorMatcher::knnMatch(queryDescriptors, trainDescriptors, matches, k, mask, compactResult)
        public void knnMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, int k, Mat mask, bool compactResult)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_knnMatch_10(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, k, mask.nativeObj, compactResult);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: DescriptorMatcher::knnMatch(queryDescriptors, trainDescriptors, matches, k, mask)
        public void knnMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, int k, Mat mask)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_knnMatch_11(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, k, mask.nativeObj);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: DescriptorMatcher::knnMatch(queryDescriptors, trainDescriptors, matches, k)
        public void knnMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, int k)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_knnMatch_12(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, k);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DescriptorMatcher::knnMatch(Mat queryDescriptors, vector_vector_DMatch& matches, int k, vector_Mat masks = vector_Mat(), bool compactResult = false)
        //

        //javadoc: DescriptorMatcher::knnMatch(queryDescriptors, matches, k, masks, compactResult)
        public void knnMatch(Mat queryDescriptors, List<MatOfDMatch> matches, int k, List<Mat> masks, bool compactResult)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = new Mat();
        Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
        features2d_DescriptorMatcher_knnMatch_13(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, k, masks_mat.nativeObj, compactResult);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: DescriptorMatcher::knnMatch(queryDescriptors, matches, k, masks)
        public void knnMatch(Mat queryDescriptors, List<MatOfDMatch> matches, int k, List<Mat> masks)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = new Mat();
        Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
        features2d_DescriptorMatcher_knnMatch_14(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, k, masks_mat.nativeObj);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: DescriptorMatcher::knnMatch(queryDescriptors, matches, k)
        public void knnMatch(Mat queryDescriptors, List<MatOfDMatch> matches, int k)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_knnMatch_15(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, k);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DescriptorMatcher::match(Mat queryDescriptors, Mat trainDescriptors, vector_DMatch& matches, Mat mask = Mat())
        //

        //javadoc: DescriptorMatcher::match(queryDescriptors, trainDescriptors, matches, mask)
        public void match(Mat queryDescriptors, Mat trainDescriptors, MatOfDMatch matches, Mat mask)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            if (matches != null) matches.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = matches;
        features2d_DescriptorMatcher_match_10(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, mask.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: DescriptorMatcher::match(queryDescriptors, trainDescriptors, matches)
        public void match(Mat queryDescriptors, Mat trainDescriptors, MatOfDMatch matches)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            if (matches != null) matches.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = matches;
        features2d_DescriptorMatcher_match_11(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DescriptorMatcher::match(Mat queryDescriptors, vector_DMatch& matches, vector_Mat masks = vector_Mat())
        //

        //javadoc: DescriptorMatcher::match(queryDescriptors, matches, masks)
        public void match(Mat queryDescriptors, MatOfDMatch matches, List<Mat> masks)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (matches != null) matches.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = matches;
        Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
        features2d_DescriptorMatcher_match_12(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, masks_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: DescriptorMatcher::match(queryDescriptors, matches)
        public void match(Mat queryDescriptors, MatOfDMatch matches)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (matches != null) matches.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = matches;
        features2d_DescriptorMatcher_match_13(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DescriptorMatcher::radiusMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
        //

        //javadoc: DescriptorMatcher::radiusMatch(queryDescriptors, trainDescriptors, matches, maxDistance, mask, compactResult)
        public void radiusMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, float maxDistance, Mat mask, bool compactResult)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_radiusMatch_10(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, mask.nativeObj, compactResult);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: DescriptorMatcher::radiusMatch(queryDescriptors, trainDescriptors, matches, maxDistance, mask)
        public void radiusMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, float maxDistance, Mat mask)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_radiusMatch_11(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, mask.nativeObj);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: DescriptorMatcher::radiusMatch(queryDescriptors, trainDescriptors, matches, maxDistance)
        public void radiusMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, float maxDistance)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null) trainDescriptors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_radiusMatch_12(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, maxDistance);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DescriptorMatcher::radiusMatch(Mat queryDescriptors, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector_Mat(), bool compactResult = false)
        //

        //javadoc: DescriptorMatcher::radiusMatch(queryDescriptors, matches, maxDistance, masks, compactResult)
        public void radiusMatch(Mat queryDescriptors, List<MatOfDMatch> matches, float maxDistance, List<Mat> masks, bool compactResult)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = new Mat();
        Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
        features2d_DescriptorMatcher_radiusMatch_13(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, masks_mat.nativeObj, compactResult);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: DescriptorMatcher::radiusMatch(queryDescriptors, matches, maxDistance, masks)
        public void radiusMatch(Mat queryDescriptors, List<MatOfDMatch> matches, float maxDistance, List<Mat> masks)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = new Mat();
        Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
        features2d_DescriptorMatcher_radiusMatch_14(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, masks_mat.nativeObj);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
            return;
#endif
        }

        //javadoc: DescriptorMatcher::radiusMatch(queryDescriptors, matches, maxDistance)
        public void radiusMatch(Mat queryDescriptors, List<MatOfDMatch> matches, float maxDistance)
        {
            ThrowIfDisposed();
            if (queryDescriptors != null) queryDescriptors.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_radiusMatch_15(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, maxDistance);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DescriptorMatcher::read(FileNode arg1)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  void cv::DescriptorMatcher::read(String fileName)
        //

        //javadoc: DescriptorMatcher::read(fileName)
        public void read(string fileName)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_DescriptorMatcher_read_10(nativeObj, fileName);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DescriptorMatcher::train()
        //

        //javadoc: DescriptorMatcher::train()
        public void train()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_DescriptorMatcher_train_10(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DescriptorMatcher::write(Ptr_FileStorage fs, String name = String())
        //

        // Unknown type 'Ptr_FileStorage' (I), skipping the function


        //
        // C++:  void cv::DescriptorMatcher::write(String fileName)
        //

        //javadoc: DescriptorMatcher::write(fileName)
        public void write(string fileName)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_DescriptorMatcher_write_10(nativeObj, fileName);
        
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



        // C++:  Ptr_DescriptorMatcher cv::DescriptorMatcher::clone(bool emptyTrainData = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_DescriptorMatcher_clone_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool emptyTrainData);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_DescriptorMatcher_clone_11(IntPtr nativeObj);

        // C++: static Ptr_DescriptorMatcher cv::DescriptorMatcher::create(DescriptorMatcher_MatcherType matcherType)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_DescriptorMatcher_create_10(int matcherType);

        // C++: static Ptr_DescriptorMatcher cv::DescriptorMatcher::create(String descriptorMatcherType)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_DescriptorMatcher_create_11(string descriptorMatcherType);

        // C++:  bool cv::DescriptorMatcher::empty()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_DescriptorMatcher_empty_10(IntPtr nativeObj);

        // C++:  bool cv::DescriptorMatcher::isMaskSupported()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_DescriptorMatcher_isMaskSupported_10(IntPtr nativeObj);

        // C++:  vector_Mat cv::DescriptorMatcher::getTrainDescriptors()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_DescriptorMatcher_getTrainDescriptors_10(IntPtr nativeObj);

        // C++:  void cv::DescriptorMatcher::add(vector_Mat descriptors)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_add_10(IntPtr nativeObj, IntPtr descriptors_mat_nativeObj);

        // C++:  void cv::DescriptorMatcher::clear()
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_clear_10(IntPtr nativeObj);

        // C++:  void cv::DescriptorMatcher::knnMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_knnMatch_10(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr mask_nativeObj, [MarshalAs(UnmanagedType.U1)] bool compactResult);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_knnMatch_11(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_knnMatch_12(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k);

        // C++:  void cv::DescriptorMatcher::knnMatch(Mat queryDescriptors, vector_vector_DMatch& matches, int k, vector_Mat masks = vector_Mat(), bool compactResult = false)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_knnMatch_13(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr masks_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool compactResult);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_knnMatch_14(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr masks_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_knnMatch_15(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k);

        // C++:  void cv::DescriptorMatcher::match(Mat queryDescriptors, Mat trainDescriptors, vector_DMatch& matches, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_match_10(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_match_11(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj);

        // C++:  void cv::DescriptorMatcher::match(Mat queryDescriptors, vector_DMatch& matches, vector_Mat masks = vector_Mat())
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_match_12(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, IntPtr masks_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_match_13(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj);

        // C++:  void cv::DescriptorMatcher::radiusMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_radiusMatch_10(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr mask_nativeObj, [MarshalAs(UnmanagedType.U1)] bool compactResult);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_radiusMatch_11(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_radiusMatch_12(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);

        // C++:  void cv::DescriptorMatcher::radiusMatch(Mat queryDescriptors, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector_Mat(), bool compactResult = false)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_radiusMatch_13(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr masks_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool compactResult);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_radiusMatch_14(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr masks_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_radiusMatch_15(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);

        // C++:  void cv::DescriptorMatcher::read(String fileName)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_read_10(IntPtr nativeObj, string fileName);

        // C++:  void cv::DescriptorMatcher::train()
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_train_10(IntPtr nativeObj);

        // C++:  void cv::DescriptorMatcher::write(String fileName)
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_write_10(IntPtr nativeObj, string fileName);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_DescriptorMatcher_delete(IntPtr nativeObj);

    }
}
