
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using OpenCVForUnity.Features2dModule;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class DAISY
    //javadoc: DAISY

    public class DAISY : Feature2D
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
                        xfeatures2d_DAISY_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DAISY(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DAISY __fromPtr__(IntPtr addr) { return new DAISY(addr); }

        // C++: enum NormalizationType
        public const int NRM_NONE = 100;
        public const int NRM_PARTIAL = 101;
        public const int NRM_FULL = 102;
        public const int NRM_SIFT = 103;
        //
        // C++: static Ptr_DAISY cv::xfeatures2d::DAISY::create(float radius = 15, int q_radius = 3, int q_theta = 8, int q_hist = 8, DAISY_NormalizationType norm = DAISY::NRM_NONE, Mat H = Mat(), bool interpolation = true, bool use_orientation = false)
        //

        //javadoc: DAISY::create(radius, q_radius, q_theta, q_hist, H, interpolation, use_orientation)
        public static DAISY create(float radius, int q_radius, int q_theta, int q_hist, Mat H, bool interpolation, bool use_orientation)
        {
            if (H != null) H.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        DAISY retVal = DAISY.__fromPtr__(xfeatures2d_DAISY_create_10(radius, q_radius, q_theta, q_hist, H.nativeObj, interpolation, use_orientation));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DAISY::create(radius, q_radius, q_theta, q_hist, H, interpolation)
        public static DAISY create(float radius, int q_radius, int q_theta, int q_hist, Mat H, bool interpolation)
        {
            if (H != null) H.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        DAISY retVal = DAISY.__fromPtr__(xfeatures2d_DAISY_create_11(radius, q_radius, q_theta, q_hist, H.nativeObj, interpolation));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DAISY::create(radius, q_radius, q_theta, q_hist, H)
        public static DAISY create(float radius, int q_radius, int q_theta, int q_hist, Mat H)
        {
            if (H != null) H.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        DAISY retVal = DAISY.__fromPtr__(xfeatures2d_DAISY_create_12(radius, q_radius, q_theta, q_hist, H.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DAISY::create(radius, q_radius, q_theta, q_hist)
        public static DAISY create(float radius, int q_radius, int q_theta, int q_hist)
        {
#if UNITY_5_3_OR_NEWER
        
        DAISY retVal = DAISY.__fromPtr__(xfeatures2d_DAISY_create_13(radius, q_radius, q_theta, q_hist));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DAISY::create(radius, q_radius, q_theta)
        public static DAISY create(float radius, int q_radius, int q_theta)
        {
#if UNITY_5_3_OR_NEWER
        
        DAISY retVal = DAISY.__fromPtr__(xfeatures2d_DAISY_create_15(radius, q_radius, q_theta));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DAISY::create(radius, q_radius)
        public static DAISY create(float radius, int q_radius)
        {
#if UNITY_5_3_OR_NEWER
        
        DAISY retVal = DAISY.__fromPtr__(xfeatures2d_DAISY_create_16(radius, q_radius));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DAISY::create(radius)
        public static DAISY create(float radius)
        {
#if UNITY_5_3_OR_NEWER
        
        DAISY retVal = DAISY.__fromPtr__(xfeatures2d_DAISY_create_17(radius));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DAISY::create()
        public static DAISY create()
        {
#if UNITY_5_3_OR_NEWER
        
        DAISY retVal = DAISY.__fromPtr__(xfeatures2d_DAISY_create_18());
        
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



        // C++: static Ptr_DAISY cv::xfeatures2d::DAISY::create(float radius = 15, int q_radius = 3, int q_theta = 8, int q_hist = 8, DAISY_NormalizationType norm = DAISY::NRM_NONE, Mat H = Mat(), bool interpolation = true, bool use_orientation = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_10(float radius, int q_radius, int q_theta, int q_hist, IntPtr H_nativeObj, [MarshalAs(UnmanagedType.U1)] bool interpolation, [MarshalAs(UnmanagedType.U1)] bool use_orientation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_11(float radius, int q_radius, int q_theta, int q_hist, IntPtr H_nativeObj, [MarshalAs(UnmanagedType.U1)] bool interpolation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_12(float radius, int q_radius, int q_theta, int q_hist, IntPtr H_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_13(float radius, int q_radius, int q_theta, int q_hist);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_15(float radius, int q_radius, int q_theta);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_16(float radius, int q_radius);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_17(float radius);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_18();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_DAISY_delete(IntPtr nativeObj);

    }
}
