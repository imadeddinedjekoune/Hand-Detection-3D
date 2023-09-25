
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class KAZE
    //javadoc: KAZE

    public class KAZE : Feature2D
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
                        features2d_KAZE_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal KAZE(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new KAZE __fromPtr__(IntPtr addr) { return new KAZE(addr); }

        // C++: enum DiffusivityType
        public const int DIFF_PM_G1 = 0;
        public const int DIFF_PM_G2 = 1;
        public const int DIFF_WEICKERT = 2;
        public const int DIFF_CHARBONNIER = 3;
        //
        // C++:  KAZE_DiffusivityType cv::KAZE::getDiffusivity()
        //

        //javadoc: KAZE::getDiffusivity()
        public int getDiffusivity()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_KAZE_getDiffusivity_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: static Ptr_KAZE cv::KAZE::create(bool extended = false, bool upright = false, float threshold = 0.001f, int nOctaves = 4, int nOctaveLayers = 4, KAZE_DiffusivityType diffusivity = KAZE::DIFF_PM_G2)
        //

        //javadoc: KAZE::create(extended, upright, threshold, nOctaves, nOctaveLayers, diffusivity)
        public static KAZE create(bool extended, bool upright, float threshold, int nOctaves, int nOctaveLayers, int diffusivity)
        {
#if UNITY_5_3_OR_NEWER
        
        KAZE retVal = KAZE.__fromPtr__(features2d_KAZE_create_10(extended, upright, threshold, nOctaves, nOctaveLayers, diffusivity));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: KAZE::create(extended, upright, threshold, nOctaves, nOctaveLayers)
        public static KAZE create(bool extended, bool upright, float threshold, int nOctaves, int nOctaveLayers)
        {
#if UNITY_5_3_OR_NEWER
        
        KAZE retVal = KAZE.__fromPtr__(features2d_KAZE_create_11(extended, upright, threshold, nOctaves, nOctaveLayers));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: KAZE::create(extended, upright, threshold, nOctaves)
        public static KAZE create(bool extended, bool upright, float threshold, int nOctaves)
        {
#if UNITY_5_3_OR_NEWER
        
        KAZE retVal = KAZE.__fromPtr__(features2d_KAZE_create_12(extended, upright, threshold, nOctaves));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: KAZE::create(extended, upright, threshold)
        public static KAZE create(bool extended, bool upright, float threshold)
        {
#if UNITY_5_3_OR_NEWER
        
        KAZE retVal = KAZE.__fromPtr__(features2d_KAZE_create_13(extended, upright, threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: KAZE::create(extended, upright)
        public static KAZE create(bool extended, bool upright)
        {
#if UNITY_5_3_OR_NEWER
        
        KAZE retVal = KAZE.__fromPtr__(features2d_KAZE_create_14(extended, upright));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: KAZE::create(extended)
        public static KAZE create(bool extended)
        {
#if UNITY_5_3_OR_NEWER
        
        KAZE retVal = KAZE.__fromPtr__(features2d_KAZE_create_15(extended));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: KAZE::create()
        public static KAZE create()
        {
#if UNITY_5_3_OR_NEWER
        
        KAZE retVal = KAZE.__fromPtr__(features2d_KAZE_create_16());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::KAZE::getDefaultName()
        //

        //javadoc: KAZE::getDefaultName()
        public override string getDefaultName()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (features2d_KAZE_getDefaultName_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::KAZE::getExtended()
        //

        //javadoc: KAZE::getExtended()
        public bool getExtended()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = features2d_KAZE_getExtended_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::KAZE::getUpright()
        //

        //javadoc: KAZE::getUpright()
        public bool getUpright()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = features2d_KAZE_getUpright_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  double cv::KAZE::getThreshold()
        //

        //javadoc: KAZE::getThreshold()
        public double getThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = features2d_KAZE_getThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::KAZE::getNOctaveLayers()
        //

        //javadoc: KAZE::getNOctaveLayers()
        public int getNOctaveLayers()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_KAZE_getNOctaveLayers_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::KAZE::getNOctaves()
        //

        //javadoc: KAZE::getNOctaves()
        public int getNOctaves()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_KAZE_getNOctaves_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::KAZE::setDiffusivity(KAZE_DiffusivityType diff)
        //

        //javadoc: KAZE::setDiffusivity(diff)
        public void setDiffusivity(int diff)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_KAZE_setDiffusivity_10(nativeObj, diff);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::KAZE::setExtended(bool extended)
        //

        //javadoc: KAZE::setExtended(extended)
        public void setExtended(bool extended)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_KAZE_setExtended_10(nativeObj, extended);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::KAZE::setNOctaveLayers(int octaveLayers)
        //

        //javadoc: KAZE::setNOctaveLayers(octaveLayers)
        public void setNOctaveLayers(int octaveLayers)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_KAZE_setNOctaveLayers_10(nativeObj, octaveLayers);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::KAZE::setNOctaves(int octaves)
        //

        //javadoc: KAZE::setNOctaves(octaves)
        public void setNOctaves(int octaves)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_KAZE_setNOctaves_10(nativeObj, octaves);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::KAZE::setThreshold(double threshold)
        //

        //javadoc: KAZE::setThreshold(threshold)
        public void setThreshold(double threshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_KAZE_setThreshold_10(nativeObj, threshold);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::KAZE::setUpright(bool upright)
        //

        //javadoc: KAZE::setUpright(upright)
        public void setUpright(bool upright)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_KAZE_setUpright_10(nativeObj, upright);
        
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



        // C++:  KAZE_DiffusivityType cv::KAZE::getDiffusivity()
        [DllImport(LIBNAME)]
        private static extern int features2d_KAZE_getDiffusivity_10(IntPtr nativeObj);

        // C++: static Ptr_KAZE cv::KAZE::create(bool extended = false, bool upright = false, float threshold = 0.001f, int nOctaves = 4, int nOctaveLayers = 4, KAZE_DiffusivityType diffusivity = KAZE::DIFF_PM_G2)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_10([MarshalAs(UnmanagedType.U1)] bool extended, [MarshalAs(UnmanagedType.U1)] bool upright, float threshold, int nOctaves, int nOctaveLayers, int diffusivity);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_11([MarshalAs(UnmanagedType.U1)] bool extended, [MarshalAs(UnmanagedType.U1)] bool upright, float threshold, int nOctaves, int nOctaveLayers);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_12([MarshalAs(UnmanagedType.U1)] bool extended, [MarshalAs(UnmanagedType.U1)] bool upright, float threshold, int nOctaves);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_13([MarshalAs(UnmanagedType.U1)] bool extended, [MarshalAs(UnmanagedType.U1)] bool upright, float threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_14([MarshalAs(UnmanagedType.U1)] bool extended, [MarshalAs(UnmanagedType.U1)] bool upright);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_15([MarshalAs(UnmanagedType.U1)] bool extended);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_16();

        // C++:  String cv::KAZE::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_getDefaultName_10(IntPtr nativeObj);

        // C++:  bool cv::KAZE::getExtended()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_KAZE_getExtended_10(IntPtr nativeObj);

        // C++:  bool cv::KAZE::getUpright()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_KAZE_getUpright_10(IntPtr nativeObj);

        // C++:  double cv::KAZE::getThreshold()
        [DllImport(LIBNAME)]
        private static extern double features2d_KAZE_getThreshold_10(IntPtr nativeObj);

        // C++:  int cv::KAZE::getNOctaveLayers()
        [DllImport(LIBNAME)]
        private static extern int features2d_KAZE_getNOctaveLayers_10(IntPtr nativeObj);

        // C++:  int cv::KAZE::getNOctaves()
        [DllImport(LIBNAME)]
        private static extern int features2d_KAZE_getNOctaves_10(IntPtr nativeObj);

        // C++:  void cv::KAZE::setDiffusivity(KAZE_DiffusivityType diff)
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_setDiffusivity_10(IntPtr nativeObj, int diff);

        // C++:  void cv::KAZE::setExtended(bool extended)
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_setExtended_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool extended);

        // C++:  void cv::KAZE::setNOctaveLayers(int octaveLayers)
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_setNOctaveLayers_10(IntPtr nativeObj, int octaveLayers);

        // C++:  void cv::KAZE::setNOctaves(int octaves)
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_setNOctaves_10(IntPtr nativeObj, int octaves);

        // C++:  void cv::KAZE::setThreshold(double threshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_setThreshold_10(IntPtr nativeObj, double threshold);

        // C++:  void cv::KAZE::setUpright(bool upright)
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_setUpright_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool upright);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_delete(IntPtr nativeObj);

    }
}
