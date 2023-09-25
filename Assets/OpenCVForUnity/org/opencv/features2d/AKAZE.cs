
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class AKAZE
    //javadoc: AKAZE

    public class AKAZE : Feature2D
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
                        features2d_AKAZE_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal AKAZE(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new AKAZE __fromPtr__(IntPtr addr) { return new AKAZE(addr); }

        // C++: enum DescriptorType
        public const int DESCRIPTOR_KAZE_UPRIGHT = 2;
        public const int DESCRIPTOR_KAZE = 3;
        public const int DESCRIPTOR_MLDB_UPRIGHT = 4;
        public const int DESCRIPTOR_MLDB = 5;
        //
        // C++:  AKAZE_DescriptorType cv::AKAZE::getDescriptorType()
        //

        //javadoc: AKAZE::getDescriptorType()
        public int getDescriptorType()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_AKAZE_getDescriptorType_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  KAZE_DiffusivityType cv::AKAZE::getDiffusivity()
        //

        //javadoc: AKAZE::getDiffusivity()
        public int getDiffusivity()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_AKAZE_getDiffusivity_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: static Ptr_AKAZE cv::AKAZE::create(AKAZE_DescriptorType descriptor_type = AKAZE::DESCRIPTOR_MLDB, int descriptor_size = 0, int descriptor_channels = 3, float threshold = 0.001f, int nOctaves = 4, int nOctaveLayers = 4, KAZE_DiffusivityType diffusivity = KAZE::DIFF_PM_G2)
        //

        //javadoc: AKAZE::create(descriptor_type, descriptor_size, descriptor_channels, threshold, nOctaves, nOctaveLayers, diffusivity)
        public static AKAZE create(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves, int nOctaveLayers, int diffusivity)
        {
#if UNITY_5_3_OR_NEWER
        
        AKAZE retVal = AKAZE.__fromPtr__(features2d_AKAZE_create_10(descriptor_type, descriptor_size, descriptor_channels, threshold, nOctaves, nOctaveLayers, diffusivity));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: AKAZE::create(descriptor_type, descriptor_size, descriptor_channels, threshold, nOctaves, nOctaveLayers)
        public static AKAZE create(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves, int nOctaveLayers)
        {
#if UNITY_5_3_OR_NEWER
        
        AKAZE retVal = AKAZE.__fromPtr__(features2d_AKAZE_create_11(descriptor_type, descriptor_size, descriptor_channels, threshold, nOctaves, nOctaveLayers));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: AKAZE::create(descriptor_type, descriptor_size, descriptor_channels, threshold, nOctaves)
        public static AKAZE create(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves)
        {
#if UNITY_5_3_OR_NEWER
        
        AKAZE retVal = AKAZE.__fromPtr__(features2d_AKAZE_create_12(descriptor_type, descriptor_size, descriptor_channels, threshold, nOctaves));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: AKAZE::create(descriptor_type, descriptor_size, descriptor_channels, threshold)
        public static AKAZE create(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold)
        {
#if UNITY_5_3_OR_NEWER
        
        AKAZE retVal = AKAZE.__fromPtr__(features2d_AKAZE_create_13(descriptor_type, descriptor_size, descriptor_channels, threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: AKAZE::create(descriptor_type, descriptor_size, descriptor_channels)
        public static AKAZE create(int descriptor_type, int descriptor_size, int descriptor_channels)
        {
#if UNITY_5_3_OR_NEWER
        
        AKAZE retVal = AKAZE.__fromPtr__(features2d_AKAZE_create_14(descriptor_type, descriptor_size, descriptor_channels));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: AKAZE::create(descriptor_type, descriptor_size)
        public static AKAZE create(int descriptor_type, int descriptor_size)
        {
#if UNITY_5_3_OR_NEWER
        
        AKAZE retVal = AKAZE.__fromPtr__(features2d_AKAZE_create_15(descriptor_type, descriptor_size));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: AKAZE::create(descriptor_type)
        public static AKAZE create(int descriptor_type)
        {
#if UNITY_5_3_OR_NEWER
        
        AKAZE retVal = AKAZE.__fromPtr__(features2d_AKAZE_create_16(descriptor_type));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: AKAZE::create()
        public static AKAZE create()
        {
#if UNITY_5_3_OR_NEWER
        
        AKAZE retVal = AKAZE.__fromPtr__(features2d_AKAZE_create_17());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::AKAZE::getDefaultName()
        //

        //javadoc: AKAZE::getDefaultName()
        public override string getDefaultName()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (features2d_AKAZE_getDefaultName_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  double cv::AKAZE::getThreshold()
        //

        //javadoc: AKAZE::getThreshold()
        public double getThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = features2d_AKAZE_getThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::AKAZE::getDescriptorChannels()
        //

        //javadoc: AKAZE::getDescriptorChannels()
        public int getDescriptorChannels()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_AKAZE_getDescriptorChannels_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::AKAZE::getDescriptorSize()
        //

        //javadoc: AKAZE::getDescriptorSize()
        public int getDescriptorSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_AKAZE_getDescriptorSize_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::AKAZE::getNOctaveLayers()
        //

        //javadoc: AKAZE::getNOctaveLayers()
        public int getNOctaveLayers()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_AKAZE_getNOctaveLayers_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::AKAZE::getNOctaves()
        //

        //javadoc: AKAZE::getNOctaves()
        public int getNOctaves()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_AKAZE_getNOctaves_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::AKAZE::setDescriptorChannels(int dch)
        //

        //javadoc: AKAZE::setDescriptorChannels(dch)
        public void setDescriptorChannels(int dch)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_AKAZE_setDescriptorChannels_10(nativeObj, dch);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AKAZE::setDescriptorSize(int dsize)
        //

        //javadoc: AKAZE::setDescriptorSize(dsize)
        public void setDescriptorSize(int dsize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_AKAZE_setDescriptorSize_10(nativeObj, dsize);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AKAZE::setDescriptorType(AKAZE_DescriptorType dtype)
        //

        //javadoc: AKAZE::setDescriptorType(dtype)
        public void setDescriptorType(int dtype)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_AKAZE_setDescriptorType_10(nativeObj, dtype);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AKAZE::setDiffusivity(KAZE_DiffusivityType diff)
        //

        //javadoc: AKAZE::setDiffusivity(diff)
        public void setDiffusivity(int diff)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_AKAZE_setDiffusivity_10(nativeObj, diff);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AKAZE::setNOctaveLayers(int octaveLayers)
        //

        //javadoc: AKAZE::setNOctaveLayers(octaveLayers)
        public void setNOctaveLayers(int octaveLayers)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_AKAZE_setNOctaveLayers_10(nativeObj, octaveLayers);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AKAZE::setNOctaves(int octaves)
        //

        //javadoc: AKAZE::setNOctaves(octaves)
        public void setNOctaves(int octaves)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_AKAZE_setNOctaves_10(nativeObj, octaves);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::AKAZE::setThreshold(double threshold)
        //

        //javadoc: AKAZE::setThreshold(threshold)
        public void setThreshold(double threshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_AKAZE_setThreshold_10(nativeObj, threshold);
        
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



        // C++:  AKAZE_DescriptorType cv::AKAZE::getDescriptorType()
        [DllImport(LIBNAME)]
        private static extern int features2d_AKAZE_getDescriptorType_10(IntPtr nativeObj);

        // C++:  KAZE_DiffusivityType cv::AKAZE::getDiffusivity()
        [DllImport(LIBNAME)]
        private static extern int features2d_AKAZE_getDiffusivity_10(IntPtr nativeObj);

        // C++: static Ptr_AKAZE cv::AKAZE::create(AKAZE_DescriptorType descriptor_type = AKAZE::DESCRIPTOR_MLDB, int descriptor_size = 0, int descriptor_channels = 3, float threshold = 0.001f, int nOctaves = 4, int nOctaveLayers = 4, KAZE_DiffusivityType diffusivity = KAZE::DIFF_PM_G2)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_10(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves, int nOctaveLayers, int diffusivity);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_11(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves, int nOctaveLayers);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_12(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_13(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_14(int descriptor_type, int descriptor_size, int descriptor_channels);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_15(int descriptor_type, int descriptor_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_16(int descriptor_type);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_17();

        // C++:  String cv::AKAZE::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_getDefaultName_10(IntPtr nativeObj);

        // C++:  double cv::AKAZE::getThreshold()
        [DllImport(LIBNAME)]
        private static extern double features2d_AKAZE_getThreshold_10(IntPtr nativeObj);

        // C++:  int cv::AKAZE::getDescriptorChannels()
        [DllImport(LIBNAME)]
        private static extern int features2d_AKAZE_getDescriptorChannels_10(IntPtr nativeObj);

        // C++:  int cv::AKAZE::getDescriptorSize()
        [DllImport(LIBNAME)]
        private static extern int features2d_AKAZE_getDescriptorSize_10(IntPtr nativeObj);

        // C++:  int cv::AKAZE::getNOctaveLayers()
        [DllImport(LIBNAME)]
        private static extern int features2d_AKAZE_getNOctaveLayers_10(IntPtr nativeObj);

        // C++:  int cv::AKAZE::getNOctaves()
        [DllImport(LIBNAME)]
        private static extern int features2d_AKAZE_getNOctaves_10(IntPtr nativeObj);

        // C++:  void cv::AKAZE::setDescriptorChannels(int dch)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setDescriptorChannels_10(IntPtr nativeObj, int dch);

        // C++:  void cv::AKAZE::setDescriptorSize(int dsize)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setDescriptorSize_10(IntPtr nativeObj, int dsize);

        // C++:  void cv::AKAZE::setDescriptorType(AKAZE_DescriptorType dtype)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setDescriptorType_10(IntPtr nativeObj, int dtype);

        // C++:  void cv::AKAZE::setDiffusivity(KAZE_DiffusivityType diff)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setDiffusivity_10(IntPtr nativeObj, int diff);

        // C++:  void cv::AKAZE::setNOctaveLayers(int octaveLayers)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setNOctaveLayers_10(IntPtr nativeObj, int octaveLayers);

        // C++:  void cv::AKAZE::setNOctaves(int octaves)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setNOctaves_10(IntPtr nativeObj, int octaves);

        // C++:  void cv::AKAZE::setThreshold(double threshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setThreshold_10(IntPtr nativeObj, double threshold);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_delete(IntPtr nativeObj);

    }
}
