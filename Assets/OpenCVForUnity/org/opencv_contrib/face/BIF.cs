
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class BIF
    //javadoc: BIF

    public class BIF : Algorithm
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
                        face_BIF_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BIF(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BIF __fromPtr__(IntPtr addr) { return new BIF(addr); }

        //
        // C++: static Ptr_BIF cv::face::BIF::create(int num_bands = 8, int num_rotations = 12)
        //

        //javadoc: BIF::create(num_bands, num_rotations)
        public static BIF create(int num_bands, int num_rotations)
        {
#if UNITY_5_3_OR_NEWER
        
        BIF retVal = BIF.__fromPtr__(face_BIF_create_10(num_bands, num_rotations));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BIF::create(num_bands)
        public static BIF create(int num_bands)
        {
#if UNITY_5_3_OR_NEWER
        
        BIF retVal = BIF.__fromPtr__(face_BIF_create_11(num_bands));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BIF::create()
        public static BIF create()
        {
#if UNITY_5_3_OR_NEWER
        
        BIF retVal = BIF.__fromPtr__(face_BIF_create_12());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  int cv::face::BIF::getNumBands()
        //

        //javadoc: BIF::getNumBands()
        public int getNumBands()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = face_BIF_getNumBands_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::face::BIF::getNumRotations()
        //

        //javadoc: BIF::getNumRotations()
        public int getNumRotations()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = face_BIF_getNumRotations_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::face::BIF::compute(Mat image, Mat& features)
        //

        //javadoc: BIF::compute(image, features)
        public void compute(Mat image, Mat features)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (features != null) features.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_BIF_compute_10(nativeObj, image.nativeObj, features.nativeObj);
        
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



        // C++: static Ptr_BIF cv::face::BIF::create(int num_bands = 8, int num_rotations = 12)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BIF_create_10(int num_bands, int num_rotations);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BIF_create_11(int num_bands);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BIF_create_12();

        // C++:  int cv::face::BIF::getNumBands()
        [DllImport(LIBNAME)]
        private static extern int face_BIF_getNumBands_10(IntPtr nativeObj);

        // C++:  int cv::face::BIF::getNumRotations()
        [DllImport(LIBNAME)]
        private static extern int face_BIF_getNumRotations_10(IntPtr nativeObj);

        // C++:  void cv::face::BIF::compute(Mat image, Mat& features)
        [DllImport(LIBNAME)]
        private static extern void face_BIF_compute_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr features_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_BIF_delete(IntPtr nativeObj);

    }
}
