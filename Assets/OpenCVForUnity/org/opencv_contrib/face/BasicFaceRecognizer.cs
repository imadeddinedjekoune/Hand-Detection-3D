
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class BasicFaceRecognizer
    //javadoc: BasicFaceRecognizer

    public class BasicFaceRecognizer : FaceRecognizer
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
                        face_BasicFaceRecognizer_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BasicFaceRecognizer(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BasicFaceRecognizer __fromPtr__(IntPtr addr) { return new BasicFaceRecognizer(addr); }

        //
        // C++:  Mat cv::face::BasicFaceRecognizer::getEigenValues()
        //

        //javadoc: BasicFaceRecognizer::getEigenValues()
        public Mat getEigenValues()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(face_BasicFaceRecognizer_getEigenValues_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::face::BasicFaceRecognizer::getEigenVectors()
        //

        //javadoc: BasicFaceRecognizer::getEigenVectors()
        public Mat getEigenVectors()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(face_BasicFaceRecognizer_getEigenVectors_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::face::BasicFaceRecognizer::getLabels()
        //

        //javadoc: BasicFaceRecognizer::getLabels()
        public Mat getLabels()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(face_BasicFaceRecognizer_getLabels_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::face::BasicFaceRecognizer::getMean()
        //

        //javadoc: BasicFaceRecognizer::getMean()
        public Mat getMean()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(face_BasicFaceRecognizer_getMean_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  double cv::face::BasicFaceRecognizer::getThreshold()
        //

        //javadoc: BasicFaceRecognizer::getThreshold()
        public double getThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = face_BasicFaceRecognizer_getThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::face::BasicFaceRecognizer::getNumComponents()
        //

        //javadoc: BasicFaceRecognizer::getNumComponents()
        public int getNumComponents()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = face_BasicFaceRecognizer_getNumComponents_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  vector_Mat cv::face::BasicFaceRecognizer::getProjections()
        //

        //javadoc: BasicFaceRecognizer::getProjections()
        public List<Mat> getProjections()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        List<Mat> retVal = new List<Mat>();
        Mat retValMat = new Mat(face_BasicFaceRecognizer_getProjections_10(nativeObj));
        Converters.Mat_to_vector_Mat(retValMat, retVal);
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::face::BasicFaceRecognizer::setNumComponents(int val)
        //

        //javadoc: BasicFaceRecognizer::setNumComponents(val)
        public void setNumComponents(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_BasicFaceRecognizer_setNumComponents_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::face::BasicFaceRecognizer::setThreshold(double val)
        //

        //javadoc: BasicFaceRecognizer::setThreshold(val)
        public void setThreshold(double val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_BasicFaceRecognizer_setThreshold_10(nativeObj, val);
        
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



        // C++:  Mat cv::face::BasicFaceRecognizer::getEigenValues()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getEigenValues_10(IntPtr nativeObj);

        // C++:  Mat cv::face::BasicFaceRecognizer::getEigenVectors()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getEigenVectors_10(IntPtr nativeObj);

        // C++:  Mat cv::face::BasicFaceRecognizer::getLabels()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getLabels_10(IntPtr nativeObj);

        // C++:  Mat cv::face::BasicFaceRecognizer::getMean()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getMean_10(IntPtr nativeObj);

        // C++:  double cv::face::BasicFaceRecognizer::getThreshold()
        [DllImport(LIBNAME)]
        private static extern double face_BasicFaceRecognizer_getThreshold_10(IntPtr nativeObj);

        // C++:  int cv::face::BasicFaceRecognizer::getNumComponents()
        [DllImport(LIBNAME)]
        private static extern int face_BasicFaceRecognizer_getNumComponents_10(IntPtr nativeObj);

        // C++:  vector_Mat cv::face::BasicFaceRecognizer::getProjections()
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getProjections_10(IntPtr nativeObj);

        // C++:  void cv::face::BasicFaceRecognizer::setNumComponents(int val)
        [DllImport(LIBNAME)]
        private static extern void face_BasicFaceRecognizer_setNumComponents_10(IntPtr nativeObj, int val);

        // C++:  void cv::face::BasicFaceRecognizer::setThreshold(double val)
        [DllImport(LIBNAME)]
        private static extern void face_BasicFaceRecognizer_setThreshold_10(IntPtr nativeObj, double val);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_BasicFaceRecognizer_delete(IntPtr nativeObj);

    }
}
