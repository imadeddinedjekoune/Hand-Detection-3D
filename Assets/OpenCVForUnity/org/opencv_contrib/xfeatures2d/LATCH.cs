
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using OpenCVForUnity.Features2dModule;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class LATCH
    //javadoc: LATCH

    public class LATCH : Feature2D
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
                        xfeatures2d_LATCH_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal LATCH(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new LATCH __fromPtr__(IntPtr addr) { return new LATCH(addr); }

        //
        // C++: static Ptr_LATCH cv::xfeatures2d::LATCH::create(int bytes = 32, bool rotationInvariance = true, int half_ssd_size = 3, double sigma = 2.0)
        //

        //javadoc: LATCH::create(bytes, rotationInvariance, half_ssd_size, sigma)
        public static LATCH create(int bytes, bool rotationInvariance, int half_ssd_size, double sigma)
        {
#if UNITY_5_3_OR_NEWER
        
        LATCH retVal = LATCH.__fromPtr__(xfeatures2d_LATCH_create_10(bytes, rotationInvariance, half_ssd_size, sigma));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: LATCH::create(bytes, rotationInvariance, half_ssd_size)
        public static LATCH create(int bytes, bool rotationInvariance, int half_ssd_size)
        {
#if UNITY_5_3_OR_NEWER
        
        LATCH retVal = LATCH.__fromPtr__(xfeatures2d_LATCH_create_11(bytes, rotationInvariance, half_ssd_size));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: LATCH::create(bytes, rotationInvariance)
        public static LATCH create(int bytes, bool rotationInvariance)
        {
#if UNITY_5_3_OR_NEWER
        
        LATCH retVal = LATCH.__fromPtr__(xfeatures2d_LATCH_create_12(bytes, rotationInvariance));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: LATCH::create(bytes)
        public static LATCH create(int bytes)
        {
#if UNITY_5_3_OR_NEWER
        
        LATCH retVal = LATCH.__fromPtr__(xfeatures2d_LATCH_create_13(bytes));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: LATCH::create()
        public static LATCH create()
        {
#if UNITY_5_3_OR_NEWER
        
        LATCH retVal = LATCH.__fromPtr__(xfeatures2d_LATCH_create_14());
        
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



        // C++: static Ptr_LATCH cv::xfeatures2d::LATCH::create(int bytes = 32, bool rotationInvariance = true, int half_ssd_size = 3, double sigma = 2.0)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LATCH_create_10(int bytes, [MarshalAs(UnmanagedType.U1)] bool rotationInvariance, int half_ssd_size, double sigma);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LATCH_create_11(int bytes, [MarshalAs(UnmanagedType.U1)] bool rotationInvariance, int half_ssd_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LATCH_create_12(int bytes, [MarshalAs(UnmanagedType.U1)] bool rotationInvariance);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LATCH_create_13(int bytes);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LATCH_create_14();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_LATCH_delete(IntPtr nativeObj);

    }
}
