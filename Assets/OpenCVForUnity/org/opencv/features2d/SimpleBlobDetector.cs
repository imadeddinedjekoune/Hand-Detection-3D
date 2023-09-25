
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class SimpleBlobDetector
    //javadoc: SimpleBlobDetector

    public class SimpleBlobDetector : Feature2D
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
                        features2d_SimpleBlobDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SimpleBlobDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SimpleBlobDetector __fromPtr__(IntPtr addr) { return new SimpleBlobDetector(addr); }

        //
        // C++: static Ptr_SimpleBlobDetector cv::SimpleBlobDetector::create(SimpleBlobDetector_Params parameters = SimpleBlobDetector::Params())
        //

        //javadoc: SimpleBlobDetector::create()
        public static SimpleBlobDetector create()
        {
#if UNITY_5_3_OR_NEWER
        
        SimpleBlobDetector retVal = SimpleBlobDetector.__fromPtr__(features2d_SimpleBlobDetector_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::SimpleBlobDetector::getDefaultName()
        //

        //javadoc: SimpleBlobDetector::getDefaultName()
        public override string getDefaultName()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (features2d_SimpleBlobDetector_getDefaultName_10(nativeObj));
        
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



        // C++: static Ptr_SimpleBlobDetector cv::SimpleBlobDetector::create(SimpleBlobDetector_Params parameters = SimpleBlobDetector::Params())
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SimpleBlobDetector_create_10();

        // C++:  String cv::SimpleBlobDetector::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_SimpleBlobDetector_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_SimpleBlobDetector_delete(IntPtr nativeObj);

    }
}
