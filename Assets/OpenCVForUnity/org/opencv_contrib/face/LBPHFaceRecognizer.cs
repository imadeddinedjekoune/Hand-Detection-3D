
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class LBPHFaceRecognizer
    //javadoc: LBPHFaceRecognizer

    public class LBPHFaceRecognizer : FaceRecognizer
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
                        face_LBPHFaceRecognizer_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal LBPHFaceRecognizer(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new LBPHFaceRecognizer __fromPtr__(IntPtr addr) { return new LBPHFaceRecognizer(addr); }

        //
        // C++:  Mat cv::face::LBPHFaceRecognizer::getLabels()
        //

        //javadoc: LBPHFaceRecognizer::getLabels()
        public Mat getLabels()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(face_LBPHFaceRecognizer_getLabels_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_LBPHFaceRecognizer cv::face::LBPHFaceRecognizer::create(int radius = 1, int neighbors = 8, int grid_x = 8, int grid_y = 8, double threshold = DBL_MAX)
        //

        //javadoc: LBPHFaceRecognizer::create(radius, neighbors, grid_x, grid_y, threshold)
        public static LBPHFaceRecognizer create(int radius, int neighbors, int grid_x, int grid_y, double threshold)
        {
#if UNITY_5_3_OR_NEWER
        
        LBPHFaceRecognizer retVal = LBPHFaceRecognizer.__fromPtr__(face_LBPHFaceRecognizer_create_10(radius, neighbors, grid_x, grid_y, threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: LBPHFaceRecognizer::create(radius, neighbors, grid_x, grid_y)
        public static LBPHFaceRecognizer create(int radius, int neighbors, int grid_x, int grid_y)
        {
#if UNITY_5_3_OR_NEWER
        
        LBPHFaceRecognizer retVal = LBPHFaceRecognizer.__fromPtr__(face_LBPHFaceRecognizer_create_11(radius, neighbors, grid_x, grid_y));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: LBPHFaceRecognizer::create(radius, neighbors, grid_x)
        public static LBPHFaceRecognizer create(int radius, int neighbors, int grid_x)
        {
#if UNITY_5_3_OR_NEWER
        
        LBPHFaceRecognizer retVal = LBPHFaceRecognizer.__fromPtr__(face_LBPHFaceRecognizer_create_12(radius, neighbors, grid_x));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: LBPHFaceRecognizer::create(radius, neighbors)
        public static LBPHFaceRecognizer create(int radius, int neighbors)
        {
#if UNITY_5_3_OR_NEWER
        
        LBPHFaceRecognizer retVal = LBPHFaceRecognizer.__fromPtr__(face_LBPHFaceRecognizer_create_13(radius, neighbors));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: LBPHFaceRecognizer::create(radius)
        public static LBPHFaceRecognizer create(int radius)
        {
#if UNITY_5_3_OR_NEWER
        
        LBPHFaceRecognizer retVal = LBPHFaceRecognizer.__fromPtr__(face_LBPHFaceRecognizer_create_14(radius));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: LBPHFaceRecognizer::create()
        public static LBPHFaceRecognizer create()
        {
#if UNITY_5_3_OR_NEWER
        
        LBPHFaceRecognizer retVal = LBPHFaceRecognizer.__fromPtr__(face_LBPHFaceRecognizer_create_15());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  double cv::face::LBPHFaceRecognizer::getThreshold()
        //

        //javadoc: LBPHFaceRecognizer::getThreshold()
        public double getThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = face_LBPHFaceRecognizer_getThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::face::LBPHFaceRecognizer::getGridX()
        //

        //javadoc: LBPHFaceRecognizer::getGridX()
        public int getGridX()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = face_LBPHFaceRecognizer_getGridX_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::face::LBPHFaceRecognizer::getGridY()
        //

        //javadoc: LBPHFaceRecognizer::getGridY()
        public int getGridY()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = face_LBPHFaceRecognizer_getGridY_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::face::LBPHFaceRecognizer::getNeighbors()
        //

        //javadoc: LBPHFaceRecognizer::getNeighbors()
        public int getNeighbors()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = face_LBPHFaceRecognizer_getNeighbors_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::face::LBPHFaceRecognizer::getRadius()
        //

        //javadoc: LBPHFaceRecognizer::getRadius()
        public int getRadius()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = face_LBPHFaceRecognizer_getRadius_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  vector_Mat cv::face::LBPHFaceRecognizer::getHistograms()
        //

        //javadoc: LBPHFaceRecognizer::getHistograms()
        public List<Mat> getHistograms()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        List<Mat> retVal = new List<Mat>();
        Mat retValMat = new Mat(face_LBPHFaceRecognizer_getHistograms_10(nativeObj));
        Converters.Mat_to_vector_Mat(retValMat, retVal);
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::face::LBPHFaceRecognizer::setGridX(int val)
        //

        //javadoc: LBPHFaceRecognizer::setGridX(val)
        public void setGridX(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_LBPHFaceRecognizer_setGridX_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::face::LBPHFaceRecognizer::setGridY(int val)
        //

        //javadoc: LBPHFaceRecognizer::setGridY(val)
        public void setGridY(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_LBPHFaceRecognizer_setGridY_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::face::LBPHFaceRecognizer::setNeighbors(int val)
        //

        //javadoc: LBPHFaceRecognizer::setNeighbors(val)
        public void setNeighbors(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_LBPHFaceRecognizer_setNeighbors_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::face::LBPHFaceRecognizer::setRadius(int val)
        //

        //javadoc: LBPHFaceRecognizer::setRadius(val)
        public void setRadius(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_LBPHFaceRecognizer_setRadius_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::face::LBPHFaceRecognizer::setThreshold(double val)
        //

        //javadoc: LBPHFaceRecognizer::setThreshold(val)
        public void setThreshold(double val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_LBPHFaceRecognizer_setThreshold_10(nativeObj, val);
        
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



        // C++:  Mat cv::face::LBPHFaceRecognizer::getLabels()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_getLabels_10(IntPtr nativeObj);

        // C++: static Ptr_LBPHFaceRecognizer cv::face::LBPHFaceRecognizer::create(int radius = 1, int neighbors = 8, int grid_x = 8, int grid_y = 8, double threshold = DBL_MAX)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_10(int radius, int neighbors, int grid_x, int grid_y, double threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_11(int radius, int neighbors, int grid_x, int grid_y);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_12(int radius, int neighbors, int grid_x);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_13(int radius, int neighbors);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_14(int radius);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_15();

        // C++:  double cv::face::LBPHFaceRecognizer::getThreshold()
        [DllImport(LIBNAME)]
        private static extern double face_LBPHFaceRecognizer_getThreshold_10(IntPtr nativeObj);

        // C++:  int cv::face::LBPHFaceRecognizer::getGridX()
        [DllImport(LIBNAME)]
        private static extern int face_LBPHFaceRecognizer_getGridX_10(IntPtr nativeObj);

        // C++:  int cv::face::LBPHFaceRecognizer::getGridY()
        [DllImport(LIBNAME)]
        private static extern int face_LBPHFaceRecognizer_getGridY_10(IntPtr nativeObj);

        // C++:  int cv::face::LBPHFaceRecognizer::getNeighbors()
        [DllImport(LIBNAME)]
        private static extern int face_LBPHFaceRecognizer_getNeighbors_10(IntPtr nativeObj);

        // C++:  int cv::face::LBPHFaceRecognizer::getRadius()
        [DllImport(LIBNAME)]
        private static extern int face_LBPHFaceRecognizer_getRadius_10(IntPtr nativeObj);

        // C++:  vector_Mat cv::face::LBPHFaceRecognizer::getHistograms()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_getHistograms_10(IntPtr nativeObj);

        // C++:  void cv::face::LBPHFaceRecognizer::setGridX(int val)
        [DllImport(LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setGridX_10(IntPtr nativeObj, int val);

        // C++:  void cv::face::LBPHFaceRecognizer::setGridY(int val)
        [DllImport(LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setGridY_10(IntPtr nativeObj, int val);

        // C++:  void cv::face::LBPHFaceRecognizer::setNeighbors(int val)
        [DllImport(LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setNeighbors_10(IntPtr nativeObj, int val);

        // C++:  void cv::face::LBPHFaceRecognizer::setRadius(int val)
        [DllImport(LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setRadius_10(IntPtr nativeObj, int val);

        // C++:  void cv::face::LBPHFaceRecognizer::setThreshold(double val)
        [DllImport(LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setThreshold_10(IntPtr nativeObj, double val);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_delete(IntPtr nativeObj);

    }
}
