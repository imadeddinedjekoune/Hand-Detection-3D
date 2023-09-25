
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class FisherFaceRecognizer
    //javadoc: FisherFaceRecognizer

    public class FisherFaceRecognizer : BasicFaceRecognizer
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
                        face_FisherFaceRecognizer_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FisherFaceRecognizer(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FisherFaceRecognizer __fromPtr__(IntPtr addr) { return new FisherFaceRecognizer(addr); }

        //
        // C++: static Ptr_FisherFaceRecognizer cv::face::FisherFaceRecognizer::create(int num_components = 0, double threshold = DBL_MAX)
        //

        //javadoc: FisherFaceRecognizer::create(num_components, threshold)
        public static FisherFaceRecognizer create(int num_components, double threshold)
        {
#if UNITY_5_3_OR_NEWER
        
        FisherFaceRecognizer retVal = FisherFaceRecognizer.__fromPtr__(face_FisherFaceRecognizer_create_10(num_components, threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FisherFaceRecognizer::create(num_components)
        public static FisherFaceRecognizer create(int num_components)
        {
#if UNITY_5_3_OR_NEWER
        
        FisherFaceRecognizer retVal = FisherFaceRecognizer.__fromPtr__(face_FisherFaceRecognizer_create_11(num_components));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FisherFaceRecognizer::create()
        public static FisherFaceRecognizer create()
        {
#if UNITY_5_3_OR_NEWER
        
        FisherFaceRecognizer retVal = FisherFaceRecognizer.__fromPtr__(face_FisherFaceRecognizer_create_12());
        
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



        // C++: static Ptr_FisherFaceRecognizer cv::face::FisherFaceRecognizer::create(int num_components = 0, double threshold = DBL_MAX)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_FisherFaceRecognizer_create_10(int num_components, double threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_FisherFaceRecognizer_create_11(int num_components);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_FisherFaceRecognizer_create_12();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_FisherFaceRecognizer_delete(IntPtr nativeObj);

    }
}
