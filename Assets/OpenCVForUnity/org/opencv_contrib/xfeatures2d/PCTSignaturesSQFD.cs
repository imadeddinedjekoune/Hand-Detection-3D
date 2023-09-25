
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class PCTSignaturesSQFD
    //javadoc: PCTSignaturesSQFD

    public class PCTSignaturesSQFD : Algorithm
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
                        xfeatures2d_PCTSignaturesSQFD_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal PCTSignaturesSQFD(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new PCTSignaturesSQFD __fromPtr__(IntPtr addr) { return new PCTSignaturesSQFD(addr); }

        //
        // C++: static Ptr_PCTSignaturesSQFD cv::xfeatures2d::PCTSignaturesSQFD::create(int distanceFunction = 3, int similarityFunction = 2, float similarityParameter = 1.0f)
        //

        //javadoc: PCTSignaturesSQFD::create(distanceFunction, similarityFunction, similarityParameter)
        public static PCTSignaturesSQFD create(int distanceFunction, int similarityFunction, float similarityParameter)
        {
#if UNITY_5_3_OR_NEWER
        
        PCTSignaturesSQFD retVal = PCTSignaturesSQFD.__fromPtr__(xfeatures2d_PCTSignaturesSQFD_create_10(distanceFunction, similarityFunction, similarityParameter));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: PCTSignaturesSQFD::create(distanceFunction, similarityFunction)
        public static PCTSignaturesSQFD create(int distanceFunction, int similarityFunction)
        {
#if UNITY_5_3_OR_NEWER
        
        PCTSignaturesSQFD retVal = PCTSignaturesSQFD.__fromPtr__(xfeatures2d_PCTSignaturesSQFD_create_11(distanceFunction, similarityFunction));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: PCTSignaturesSQFD::create(distanceFunction)
        public static PCTSignaturesSQFD create(int distanceFunction)
        {
#if UNITY_5_3_OR_NEWER
        
        PCTSignaturesSQFD retVal = PCTSignaturesSQFD.__fromPtr__(xfeatures2d_PCTSignaturesSQFD_create_12(distanceFunction));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: PCTSignaturesSQFD::create()
        public static PCTSignaturesSQFD create()
        {
#if UNITY_5_3_OR_NEWER
        
        PCTSignaturesSQFD retVal = PCTSignaturesSQFD.__fromPtr__(xfeatures2d_PCTSignaturesSQFD_create_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  float cv::xfeatures2d::PCTSignaturesSQFD::computeQuadraticFormDistance(Mat _signature0, Mat _signature1)
        //

        //javadoc: PCTSignaturesSQFD::computeQuadraticFormDistance(_signature0, _signature1)
        public float computeQuadraticFormDistance(Mat _signature0, Mat _signature1)
        {
            ThrowIfDisposed();
            if (_signature0 != null) _signature0.ThrowIfDisposed();
            if (_signature1 != null) _signature1.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignaturesSQFD_computeQuadraticFormDistance_10(nativeObj, _signature0.nativeObj, _signature1.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignaturesSQFD::computeQuadraticFormDistances(Mat sourceSignature, vector_Mat imageSignatures, vector_float distances)
        //

        //javadoc: PCTSignaturesSQFD::computeQuadraticFormDistances(sourceSignature, imageSignatures, distances)
        public void computeQuadraticFormDistances(Mat sourceSignature, List<Mat> imageSignatures, MatOfFloat distances)
        {
            ThrowIfDisposed();
            if (sourceSignature != null) sourceSignature.ThrowIfDisposed();
            if (distances != null) distances.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat imageSignatures_mat = Converters.vector_Mat_to_Mat(imageSignatures);
        Mat distances_mat = distances;
        xfeatures2d_PCTSignaturesSQFD_computeQuadraticFormDistances_10(nativeObj, sourceSignature.nativeObj, imageSignatures_mat.nativeObj, distances_mat.nativeObj);
        
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



        // C++: static Ptr_PCTSignaturesSQFD cv::xfeatures2d::PCTSignaturesSQFD::create(int distanceFunction = 3, int similarityFunction = 2, float similarityParameter = 1.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignaturesSQFD_create_10(int distanceFunction, int similarityFunction, float similarityParameter);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignaturesSQFD_create_11(int distanceFunction, int similarityFunction);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignaturesSQFD_create_12(int distanceFunction);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignaturesSQFD_create_13();

        // C++:  float cv::xfeatures2d::PCTSignaturesSQFD::computeQuadraticFormDistance(Mat _signature0, Mat _signature1)
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignaturesSQFD_computeQuadraticFormDistance_10(IntPtr nativeObj, IntPtr _signature0_nativeObj, IntPtr _signature1_nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignaturesSQFD::computeQuadraticFormDistances(Mat sourceSignature, vector_Mat imageSignatures, vector_float distances)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignaturesSQFD_computeQuadraticFormDistances_10(IntPtr nativeObj, IntPtr sourceSignature_nativeObj, IntPtr imageSignatures_mat_nativeObj, IntPtr distances_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignaturesSQFD_delete(IntPtr nativeObj);

    }
}
