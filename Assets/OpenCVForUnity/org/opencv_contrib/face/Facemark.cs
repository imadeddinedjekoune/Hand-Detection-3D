
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class Facemark
    //javadoc: Facemark

    public class Facemark : Algorithm
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
                        face_Facemark_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Facemark(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new Facemark __fromPtr__(IntPtr addr) { return new Facemark(addr); }

        //
        // C++:  bool cv::face::Facemark::fit(Mat image, vector_Rect faces, vector_vector_Point2f& landmarks)
        //

        //javadoc: Facemark::fit(image, faces, landmarks)
        public bool fit(Mat image, MatOfRect faces, List<MatOfPoint2f> landmarks)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (faces != null) faces.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat faces_mat = faces;
        Mat landmarks_mat = new Mat();
        bool retVal = face_Facemark_fit_10(nativeObj, image.nativeObj, faces_mat.nativeObj, landmarks_mat.nativeObj);
        Converters.Mat_to_vector_vector_Point2f(landmarks_mat, landmarks);
        landmarks_mat.release();
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  void cv::face::Facemark::loadModel(String model)
        //

        //javadoc: Facemark::loadModel(model)
        public void loadModel(string model)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_Facemark_loadModel_10(nativeObj, model);
        
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



        // C++:  bool cv::face::Facemark::fit(Mat image, vector_Rect faces, vector_vector_Point2f& landmarks)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_Facemark_fit_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr faces_mat_nativeObj, IntPtr landmarks_mat_nativeObj);

        // C++:  void cv::face::Facemark::loadModel(String model)
        [DllImport(LIBNAME)]
        private static extern void face_Facemark_loadModel_10(IntPtr nativeObj, string model);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_Facemark_delete(IntPtr nativeObj);

    }
}
