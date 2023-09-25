
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using OpenCVForUnity.Features2dModule;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class LUCID
    //javadoc: LUCID

    public class LUCID : Feature2D
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
                        xfeatures2d_LUCID_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal LUCID(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new LUCID __fromPtr__(IntPtr addr) { return new LUCID(addr); }

        //
        // C++: static Ptr_LUCID cv::xfeatures2d::LUCID::create(int lucid_kernel = 1, int blur_kernel = 2)
        //

        //javadoc: LUCID::create(lucid_kernel, blur_kernel)
        public static LUCID create(int lucid_kernel, int blur_kernel)
        {
#if UNITY_5_3_OR_NEWER
        
        LUCID retVal = LUCID.__fromPtr__(xfeatures2d_LUCID_create_10(lucid_kernel, blur_kernel));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: LUCID::create(lucid_kernel)
        public static LUCID create(int lucid_kernel)
        {
#if UNITY_5_3_OR_NEWER
        
        LUCID retVal = LUCID.__fromPtr__(xfeatures2d_LUCID_create_11(lucid_kernel));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: LUCID::create()
        public static LUCID create()
        {
#if UNITY_5_3_OR_NEWER
        
        LUCID retVal = LUCID.__fromPtr__(xfeatures2d_LUCID_create_12());
        
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



        // C++: static Ptr_LUCID cv::xfeatures2d::LUCID::create(int lucid_kernel = 1, int blur_kernel = 2)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LUCID_create_10(int lucid_kernel, int blur_kernel);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LUCID_create_11(int lucid_kernel);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LUCID_create_12();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_LUCID_delete(IntPtr nativeObj);

    }
}
