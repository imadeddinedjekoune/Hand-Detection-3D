
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class StandardCollector
    //javadoc: StandardCollector

    public class StandardCollector : PredictCollector
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
                        face_StandardCollector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StandardCollector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StandardCollector __fromPtr__(IntPtr addr) { return new StandardCollector(addr); }

        //
        // C++: static Ptr_StandardCollector cv::face::StandardCollector::create(double threshold = DBL_MAX)
        //

        //javadoc: StandardCollector::create(threshold)
        public static StandardCollector create(double threshold)
        {
#if UNITY_5_3_OR_NEWER
        
        StandardCollector retVal = StandardCollector.__fromPtr__(face_StandardCollector_create_10(threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StandardCollector::create()
        public static StandardCollector create()
        {
#if UNITY_5_3_OR_NEWER
        
        StandardCollector retVal = StandardCollector.__fromPtr__(face_StandardCollector_create_11());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  double cv::face::StandardCollector::getMinDist()
        //

        //javadoc: StandardCollector::getMinDist()
        public double getMinDist()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = face_StandardCollector_getMinDist_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::face::StandardCollector::getMinLabel()
        //

        //javadoc: StandardCollector::getMinLabel()
        public int getMinLabel()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = face_StandardCollector_getMinLabel_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  vector_pair_int_and_double cv::face::StandardCollector::getResults(bool sorted = false)
        //

        // Return type 'vector_pair_int_and_double' is not supported, skipping the function


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_StandardCollector cv::face::StandardCollector::create(double threshold = DBL_MAX)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_StandardCollector_create_10(double threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_StandardCollector_create_11();

        // C++:  double cv::face::StandardCollector::getMinDist()
        [DllImport(LIBNAME)]
        private static extern double face_StandardCollector_getMinDist_10(IntPtr nativeObj);

        // C++:  int cv::face::StandardCollector::getMinLabel()
        [DllImport(LIBNAME)]
        private static extern int face_StandardCollector_getMinLabel_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_StandardCollector_delete(IntPtr nativeObj);

    }
}
