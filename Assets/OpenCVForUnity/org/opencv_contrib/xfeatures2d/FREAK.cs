
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using OpenCVForUnity.Features2dModule;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class FREAK
    //javadoc: FREAK

    public class FREAK : Feature2D
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
                        xfeatures2d_FREAK_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FREAK(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FREAK __fromPtr__(IntPtr addr) { return new FREAK(addr); }

        //
        // C++: static Ptr_FREAK cv::xfeatures2d::FREAK::create(bool orientationNormalized = true, bool scaleNormalized = true, float patternScale = 22.0f, int nOctaves = 4, vector_int selectedPairs = std::vector<int>())
        //

        //javadoc: FREAK::create(orientationNormalized, scaleNormalized, patternScale, nOctaves, selectedPairs)
        public static FREAK create(bool orientationNormalized, bool scaleNormalized, float patternScale, int nOctaves, MatOfInt selectedPairs)
        {
            if (selectedPairs != null) selectedPairs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat selectedPairs_mat = selectedPairs;
        FREAK retVal = FREAK.__fromPtr__(xfeatures2d_FREAK_create_10(orientationNormalized, scaleNormalized, patternScale, nOctaves, selectedPairs_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FREAK::create(orientationNormalized, scaleNormalized, patternScale, nOctaves)
        public static FREAK create(bool orientationNormalized, bool scaleNormalized, float patternScale, int nOctaves)
        {
#if UNITY_5_3_OR_NEWER
        
        FREAK retVal = FREAK.__fromPtr__(xfeatures2d_FREAK_create_11(orientationNormalized, scaleNormalized, patternScale, nOctaves));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FREAK::create(orientationNormalized, scaleNormalized, patternScale)
        public static FREAK create(bool orientationNormalized, bool scaleNormalized, float patternScale)
        {
#if UNITY_5_3_OR_NEWER
        
        FREAK retVal = FREAK.__fromPtr__(xfeatures2d_FREAK_create_12(orientationNormalized, scaleNormalized, patternScale));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FREAK::create(orientationNormalized, scaleNormalized)
        public static FREAK create(bool orientationNormalized, bool scaleNormalized)
        {
#if UNITY_5_3_OR_NEWER
        
        FREAK retVal = FREAK.__fromPtr__(xfeatures2d_FREAK_create_13(orientationNormalized, scaleNormalized));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FREAK::create(orientationNormalized)
        public static FREAK create(bool orientationNormalized)
        {
#if UNITY_5_3_OR_NEWER
        
        FREAK retVal = FREAK.__fromPtr__(xfeatures2d_FREAK_create_14(orientationNormalized));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: FREAK::create()
        public static FREAK create()
        {
#if UNITY_5_3_OR_NEWER
        
        FREAK retVal = FREAK.__fromPtr__(xfeatures2d_FREAK_create_15());
        
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



        // C++: static Ptr_FREAK cv::xfeatures2d::FREAK::create(bool orientationNormalized = true, bool scaleNormalized = true, float patternScale = 22.0f, int nOctaves = 4, vector_int selectedPairs = std::vector<int>())
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_10([MarshalAs(UnmanagedType.U1)] bool orientationNormalized, [MarshalAs(UnmanagedType.U1)] bool scaleNormalized, float patternScale, int nOctaves, IntPtr selectedPairs_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_11([MarshalAs(UnmanagedType.U1)] bool orientationNormalized, [MarshalAs(UnmanagedType.U1)] bool scaleNormalized, float patternScale, int nOctaves);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_12([MarshalAs(UnmanagedType.U1)] bool orientationNormalized, [MarshalAs(UnmanagedType.U1)] bool scaleNormalized, float patternScale);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_13([MarshalAs(UnmanagedType.U1)] bool orientationNormalized, [MarshalAs(UnmanagedType.U1)] bool scaleNormalized);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_14([MarshalAs(UnmanagedType.U1)] bool orientationNormalized);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_15();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_FREAK_delete(IntPtr nativeObj);

    }
}
