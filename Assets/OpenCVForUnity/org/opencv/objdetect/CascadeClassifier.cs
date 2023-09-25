

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class CascadeClassifier
    //javadoc: CascadeClassifier

    public class CascadeClassifier : DisposableOpenCVObject
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
                        objdetect_CascadeClassifier_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal CascadeClassifier(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static CascadeClassifier __fromPtr__(IntPtr addr) { return new CascadeClassifier(addr); }

        //
        // C++:   cv::CascadeClassifier::CascadeClassifier(String filename)
        //

        //javadoc: CascadeClassifier::CascadeClassifier(filename)
        public CascadeClassifier(string filename)
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = objdetect_CascadeClassifier_CascadeClassifier_10(filename);
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:   cv::CascadeClassifier::CascadeClassifier()
        //

        //javadoc: CascadeClassifier::CascadeClassifier()
        public CascadeClassifier()
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = objdetect_CascadeClassifier_CascadeClassifier_11();
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:  Size cv::CascadeClassifier::getOriginalWindowSize()
        //

        //javadoc: CascadeClassifier::getOriginalWindowSize()
        public Size getOriginalWindowSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
objdetect_CascadeClassifier_getOriginalWindowSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static bool cv::CascadeClassifier::convert(String oldcascade, String newcascade)
        //

        //javadoc: CascadeClassifier::convert(oldcascade, newcascade)
        public static bool convert(string oldcascade, string newcascade)
        {
#if UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_CascadeClassifier_convert_10(oldcascade, newcascade);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::CascadeClassifier::empty()
        //

        //javadoc: CascadeClassifier::empty()
        public bool empty()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_CascadeClassifier_empty_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::CascadeClassifier::isOldFormatCascade()
        //

        //javadoc: CascadeClassifier::isOldFormatCascade()
        public bool isOldFormatCascade()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_CascadeClassifier_isOldFormatCascade_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::CascadeClassifier::load(String filename)
        //

        //javadoc: CascadeClassifier::load(filename)
        public bool load(string filename)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_CascadeClassifier_load_10(nativeObj, filename);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::CascadeClassifier::read(FileNode node)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  int cv::CascadeClassifier::getFeatureType()
        //

        //javadoc: CascadeClassifier::getFeatureType()
        public int getFeatureType()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = objdetect_CascadeClassifier_getFeatureType_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        //

        //javadoc: CascadeClassifier::detectMultiScale(image, objects, scaleFactor, minNeighbors, flags, minSize, maxSize)
        public void detectMultiScale(Mat image, MatOfRect objects, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        objdetect_CascadeClassifier_detectMultiScale_10(nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale(image, objects, scaleFactor, minNeighbors, flags, minSize)
        public void detectMultiScale(Mat image, MatOfRect objects, double scaleFactor, int minNeighbors, int flags, Size minSize)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        objdetect_CascadeClassifier_detectMultiScale_11(nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale(image, objects, scaleFactor, minNeighbors, flags)
        public void detectMultiScale(Mat image, MatOfRect objects, double scaleFactor, int minNeighbors, int flags)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        objdetect_CascadeClassifier_detectMultiScale_12(nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor, minNeighbors, flags);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale(image, objects, scaleFactor, minNeighbors)
        public void detectMultiScale(Mat image, MatOfRect objects, double scaleFactor, int minNeighbors)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        objdetect_CascadeClassifier_detectMultiScale_13(nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor, minNeighbors);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale(image, objects, scaleFactor)
        public void detectMultiScale(Mat image, MatOfRect objects, double scaleFactor)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        objdetect_CascadeClassifier_detectMultiScale_14(nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale(image, objects)
        public void detectMultiScale(Mat image, MatOfRect objects)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        objdetect_CascadeClassifier_detectMultiScale_15(nativeObj, image.nativeObj, objects_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, vector_int& numDetections, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        //

        //javadoc: CascadeClassifier::detectMultiScale2(image, objects, numDetections, scaleFactor, minNeighbors, flags, minSize, maxSize)
        public void detectMultiScale2(Mat image, MatOfRect objects, MatOfInt numDetections, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (numDetections != null) numDetections.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat numDetections_mat = numDetections;
        objdetect_CascadeClassifier_detectMultiScale2_10(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale2(image, objects, numDetections, scaleFactor, minNeighbors, flags, minSize)
        public void detectMultiScale2(Mat image, MatOfRect objects, MatOfInt numDetections, double scaleFactor, int minNeighbors, int flags, Size minSize)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (numDetections != null) numDetections.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat numDetections_mat = numDetections;
        objdetect_CascadeClassifier_detectMultiScale2_11(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale2(image, objects, numDetections, scaleFactor, minNeighbors, flags)
        public void detectMultiScale2(Mat image, MatOfRect objects, MatOfInt numDetections, double scaleFactor, int minNeighbors, int flags)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (numDetections != null) numDetections.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat numDetections_mat = numDetections;
        objdetect_CascadeClassifier_detectMultiScale2_12(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj, scaleFactor, minNeighbors, flags);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale2(image, objects, numDetections, scaleFactor, minNeighbors)
        public void detectMultiScale2(Mat image, MatOfRect objects, MatOfInt numDetections, double scaleFactor, int minNeighbors)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (numDetections != null) numDetections.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat numDetections_mat = numDetections;
        objdetect_CascadeClassifier_detectMultiScale2_13(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj, scaleFactor, minNeighbors);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale2(image, objects, numDetections, scaleFactor)
        public void detectMultiScale2(Mat image, MatOfRect objects, MatOfInt numDetections, double scaleFactor)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (numDetections != null) numDetections.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat numDetections_mat = numDetections;
        objdetect_CascadeClassifier_detectMultiScale2_14(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj, scaleFactor);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale2(image, objects, numDetections)
        public void detectMultiScale2(Mat image, MatOfRect objects, MatOfInt numDetections)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (numDetections != null) numDetections.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat numDetections_mat = numDetections;
        objdetect_CascadeClassifier_detectMultiScale2_15(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, vector_int& rejectLevels, vector_double& levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
        //

        //javadoc: CascadeClassifier::detectMultiScale3(image, objects, rejectLevels, levelWeights, scaleFactor, minNeighbors, flags, minSize, maxSize, outputRejectLevels)
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize, bool outputRejectLevels)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat rejectLevels_mat = rejectLevels;
        Mat levelWeights_mat = levelWeights;
        objdetect_CascadeClassifier_detectMultiScale3_10(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height, outputRejectLevels);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale3(image, objects, rejectLevels, levelWeights, scaleFactor, minNeighbors, flags, minSize, maxSize)
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat rejectLevels_mat = rejectLevels;
        Mat levelWeights_mat = levelWeights;
        objdetect_CascadeClassifier_detectMultiScale3_11(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale3(image, objects, rejectLevels, levelWeights, scaleFactor, minNeighbors, flags, minSize)
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors, int flags, Size minSize)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat rejectLevels_mat = rejectLevels;
        Mat levelWeights_mat = levelWeights;
        objdetect_CascadeClassifier_detectMultiScale3_12(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale3(image, objects, rejectLevels, levelWeights, scaleFactor, minNeighbors, flags)
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors, int flags)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat rejectLevels_mat = rejectLevels;
        Mat levelWeights_mat = levelWeights;
        objdetect_CascadeClassifier_detectMultiScale3_13(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors, flags);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale3(image, objects, rejectLevels, levelWeights, scaleFactor, minNeighbors)
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat rejectLevels_mat = rejectLevels;
        Mat levelWeights_mat = levelWeights;
        objdetect_CascadeClassifier_detectMultiScale3_14(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale3(image, objects, rejectLevels, levelWeights, scaleFactor)
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat rejectLevels_mat = rejectLevels;
        Mat levelWeights_mat = levelWeights;
        objdetect_CascadeClassifier_detectMultiScale3_15(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CascadeClassifier::detectMultiScale3(image, objects, rejectLevels, levelWeights)
        public void detectMultiScale3(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (objects != null) objects.ThrowIfDisposed();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed();
            if (levelWeights != null) levelWeights.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat rejectLevels_mat = rejectLevels;
        Mat levelWeights_mat = levelWeights;
        objdetect_CascadeClassifier_detectMultiScale3_16(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj);
        
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



        // C++:   cv::CascadeClassifier::CascadeClassifier(String filename)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_10(string filename);

        // C++:   cv::CascadeClassifier::CascadeClassifier()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_11();

        // C++:  Size cv::CascadeClassifier::getOriginalWindowSize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_getOriginalWindowSize_10(IntPtr nativeObj, double[] retVal);

        // C++: static bool cv::CascadeClassifier::convert(String oldcascade, String newcascade)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_CascadeClassifier_convert_10(string oldcascade, string newcascade);

        // C++:  bool cv::CascadeClassifier::empty()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_CascadeClassifier_empty_10(IntPtr nativeObj);

        // C++:  bool cv::CascadeClassifier::isOldFormatCascade()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_CascadeClassifier_isOldFormatCascade_10(IntPtr nativeObj);

        // C++:  bool cv::CascadeClassifier::load(String filename)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_CascadeClassifier_load_10(IntPtr nativeObj, string filename);

        // C++:  int cv::CascadeClassifier::getFeatureType()
        [DllImport(LIBNAME)]
        private static extern int objdetect_CascadeClassifier_getFeatureType_10(IntPtr nativeObj);

        // C++:  void cv::CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors, int flags);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_13(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_14(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_15(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj);

        // C++:  void cv::CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, vector_int& numDetections, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj, double scaleFactor, int minNeighbors, int flags);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_13(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj, double scaleFactor, int minNeighbors);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_14(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj, double scaleFactor);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_15(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj);

        // C++:  void cv::CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, vector_int& rejectLevels, vector_double& levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height, [MarshalAs(UnmanagedType.U1)] bool outputRejectLevels);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_13(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_14(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_15(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor);
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_16(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_CascadeClassifier_delete(IntPtr nativeObj);

    }
}
