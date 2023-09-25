
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class EigenFaceRecognizer
    //javadoc: EigenFaceRecognizer

    public class EigenFaceRecognizer : BasicFaceRecognizer
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
                        face_EigenFaceRecognizer_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal EigenFaceRecognizer(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new EigenFaceRecognizer __fromPtr__(IntPtr addr) { return new EigenFaceRecognizer(addr); }

        //
        // C++: static Ptr_EigenFaceRecognizer cv::face::EigenFaceRecognizer::create(int num_components = 0, double threshold = DBL_MAX)
        //

        //javadoc: EigenFaceRecognizer::create(num_components, threshold)
        public static EigenFaceRecognizer create(int num_components, double threshold)
        {
#if UNITY_5_3_OR_NEWER
        
        EigenFaceRecognizer retVal = EigenFaceRecognizer.__fromPtr__(face_EigenFaceRecognizer_create_10(num_components, threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: EigenFaceRecognizer::create(num_components)
        public static EigenFaceRecognizer create(int num_components)
        {
#if UNITY_5_3_OR_NEWER
        
        EigenFaceRecognizer retVal = EigenFaceRecognizer.__fromPtr__(face_EigenFaceRecognizer_create_11(num_components));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: EigenFaceRecognizer::create()
        public static EigenFaceRecognizer create()
        {
#if UNITY_5_3_OR_NEWER
        
        EigenFaceRecognizer retVal = EigenFaceRecognizer.__fromPtr__(face_EigenFaceRecognizer_create_12());
        
        return retVal;
#else
            return null;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_EigenFaceRecognizer cv::face::EigenFaceRecognizer::create(int num_components = 0, double threshold = DBL_MAX)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_EigenFaceRecognizer_create_10(int num_components, double threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_EigenFaceRecognizer_create_11(int num_components);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_EigenFaceRecognizer_create_12();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_EigenFaceRecognizer_delete(IntPtr nativeObj);

    }
}
