
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class GFTTDetector
    //javadoc: GFTTDetector

    public class GFTTDetector : Feature2D
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
                        features2d_GFTTDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GFTTDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GFTTDetector __fromPtr__(IntPtr addr) { return new GFTTDetector(addr); }

        //
        // C++: static Ptr_GFTTDetector cv::GFTTDetector::create(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector = false, double k = 0.04)
        //

        //javadoc: GFTTDetector::create(maxCorners, qualityLevel, minDistance, blockSize, gradiantSize, useHarrisDetector, k)
        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector, double k)
        {
#if UNITY_5_3_OR_NEWER
        
        GFTTDetector retVal = GFTTDetector.__fromPtr__(features2d_GFTTDetector_create_10(maxCorners, qualityLevel, minDistance, blockSize, gradiantSize, useHarrisDetector, k));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: GFTTDetector::create(maxCorners, qualityLevel, minDistance, blockSize, gradiantSize, useHarrisDetector)
        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector)
        {
#if UNITY_5_3_OR_NEWER
        
        GFTTDetector retVal = GFTTDetector.__fromPtr__(features2d_GFTTDetector_create_11(maxCorners, qualityLevel, minDistance, blockSize, gradiantSize, useHarrisDetector));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: GFTTDetector::create(maxCorners, qualityLevel, minDistance, blockSize, gradiantSize)
        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize)
        {
#if UNITY_5_3_OR_NEWER
        
        GFTTDetector retVal = GFTTDetector.__fromPtr__(features2d_GFTTDetector_create_12(maxCorners, qualityLevel, minDistance, blockSize, gradiantSize));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_GFTTDetector cv::GFTTDetector::create(int maxCorners = 1000, double qualityLevel = 0.01, double minDistance = 1, int blockSize = 3, bool useHarrisDetector = false, double k = 0.04)
        //

        //javadoc: GFTTDetector::create(maxCorners, qualityLevel, minDistance, blockSize, useHarrisDetector, k)
        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize, bool useHarrisDetector, double k)
        {
#if UNITY_5_3_OR_NEWER
        
        GFTTDetector retVal = GFTTDetector.__fromPtr__(features2d_GFTTDetector_create_13(maxCorners, qualityLevel, minDistance, blockSize, useHarrisDetector, k));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: GFTTDetector::create(maxCorners, qualityLevel, minDistance, blockSize, useHarrisDetector)
        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize, bool useHarrisDetector)
        {
#if UNITY_5_3_OR_NEWER
        
        GFTTDetector retVal = GFTTDetector.__fromPtr__(features2d_GFTTDetector_create_14(maxCorners, qualityLevel, minDistance, blockSize, useHarrisDetector));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: GFTTDetector::create(maxCorners, qualityLevel, minDistance, blockSize)
        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize)
        {
#if UNITY_5_3_OR_NEWER
        
        GFTTDetector retVal = GFTTDetector.__fromPtr__(features2d_GFTTDetector_create_15(maxCorners, qualityLevel, minDistance, blockSize));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: GFTTDetector::create(maxCorners, qualityLevel, minDistance)
        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance)
        {
#if UNITY_5_3_OR_NEWER
        
        GFTTDetector retVal = GFTTDetector.__fromPtr__(features2d_GFTTDetector_create_16(maxCorners, qualityLevel, minDistance));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: GFTTDetector::create(maxCorners, qualityLevel)
        public static GFTTDetector create(int maxCorners, double qualityLevel)
        {
#if UNITY_5_3_OR_NEWER
        
        GFTTDetector retVal = GFTTDetector.__fromPtr__(features2d_GFTTDetector_create_17(maxCorners, qualityLevel));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: GFTTDetector::create(maxCorners)
        public static GFTTDetector create(int maxCorners)
        {
#if UNITY_5_3_OR_NEWER
        
        GFTTDetector retVal = GFTTDetector.__fromPtr__(features2d_GFTTDetector_create_18(maxCorners));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: GFTTDetector::create()
        public static GFTTDetector create()
        {
#if UNITY_5_3_OR_NEWER
        
        GFTTDetector retVal = GFTTDetector.__fromPtr__(features2d_GFTTDetector_create_19());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::GFTTDetector::getDefaultName()
        //

        //javadoc: GFTTDetector::getDefaultName()
        public override string getDefaultName()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (features2d_GFTTDetector_getDefaultName_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::GFTTDetector::getHarrisDetector()
        //

        //javadoc: GFTTDetector::getHarrisDetector()
        public bool getHarrisDetector()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = features2d_GFTTDetector_getHarrisDetector_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  double cv::GFTTDetector::getK()
        //

        //javadoc: GFTTDetector::getK()
        public double getK()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = features2d_GFTTDetector_getK_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::GFTTDetector::getMinDistance()
        //

        //javadoc: GFTTDetector::getMinDistance()
        public double getMinDistance()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = features2d_GFTTDetector_getMinDistance_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::GFTTDetector::getQualityLevel()
        //

        //javadoc: GFTTDetector::getQualityLevel()
        public double getQualityLevel()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = features2d_GFTTDetector_getQualityLevel_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::GFTTDetector::getBlockSize()
        //

        //javadoc: GFTTDetector::getBlockSize()
        public int getBlockSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_GFTTDetector_getBlockSize_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::GFTTDetector::getMaxFeatures()
        //

        //javadoc: GFTTDetector::getMaxFeatures()
        public int getMaxFeatures()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_GFTTDetector_getMaxFeatures_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::GFTTDetector::setBlockSize(int blockSize)
        //

        //javadoc: GFTTDetector::setBlockSize(blockSize)
        public void setBlockSize(int blockSize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_GFTTDetector_setBlockSize_10(nativeObj, blockSize);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GFTTDetector::setHarrisDetector(bool val)
        //

        //javadoc: GFTTDetector::setHarrisDetector(val)
        public void setHarrisDetector(bool val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_GFTTDetector_setHarrisDetector_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GFTTDetector::setK(double k)
        //

        //javadoc: GFTTDetector::setK(k)
        public void setK(double k)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_GFTTDetector_setK_10(nativeObj, k);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GFTTDetector::setMaxFeatures(int maxFeatures)
        //

        //javadoc: GFTTDetector::setMaxFeatures(maxFeatures)
        public void setMaxFeatures(int maxFeatures)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_GFTTDetector_setMaxFeatures_10(nativeObj, maxFeatures);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GFTTDetector::setMinDistance(double minDistance)
        //

        //javadoc: GFTTDetector::setMinDistance(minDistance)
        public void setMinDistance(double minDistance)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_GFTTDetector_setMinDistance_10(nativeObj, minDistance);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GFTTDetector::setQualityLevel(double qlevel)
        //

        //javadoc: GFTTDetector::setQualityLevel(qlevel)
        public void setQualityLevel(double qlevel)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_GFTTDetector_setQualityLevel_10(nativeObj, qlevel);
        
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



        // C++: static Ptr_GFTTDetector cv::GFTTDetector::create(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector = false, double k = 0.04)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_10(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, [MarshalAs(UnmanagedType.U1)] bool useHarrisDetector, double k);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_11(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, [MarshalAs(UnmanagedType.U1)] bool useHarrisDetector);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_12(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize);

        // C++: static Ptr_GFTTDetector cv::GFTTDetector::create(int maxCorners = 1000, double qualityLevel = 0.01, double minDistance = 1, int blockSize = 3, bool useHarrisDetector = false, double k = 0.04)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_13(int maxCorners, double qualityLevel, double minDistance, int blockSize, [MarshalAs(UnmanagedType.U1)] bool useHarrisDetector, double k);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_14(int maxCorners, double qualityLevel, double minDistance, int blockSize, [MarshalAs(UnmanagedType.U1)] bool useHarrisDetector);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_15(int maxCorners, double qualityLevel, double minDistance, int blockSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_16(int maxCorners, double qualityLevel, double minDistance);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_17(int maxCorners, double qualityLevel);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_18(int maxCorners);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_19();

        // C++:  String cv::GFTTDetector::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_getDefaultName_10(IntPtr nativeObj);

        // C++:  bool cv::GFTTDetector::getHarrisDetector()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_GFTTDetector_getHarrisDetector_10(IntPtr nativeObj);

        // C++:  double cv::GFTTDetector::getK()
        [DllImport(LIBNAME)]
        private static extern double features2d_GFTTDetector_getK_10(IntPtr nativeObj);

        // C++:  double cv::GFTTDetector::getMinDistance()
        [DllImport(LIBNAME)]
        private static extern double features2d_GFTTDetector_getMinDistance_10(IntPtr nativeObj);

        // C++:  double cv::GFTTDetector::getQualityLevel()
        [DllImport(LIBNAME)]
        private static extern double features2d_GFTTDetector_getQualityLevel_10(IntPtr nativeObj);

        // C++:  int cv::GFTTDetector::getBlockSize()
        [DllImport(LIBNAME)]
        private static extern int features2d_GFTTDetector_getBlockSize_10(IntPtr nativeObj);

        // C++:  int cv::GFTTDetector::getMaxFeatures()
        [DllImport(LIBNAME)]
        private static extern int features2d_GFTTDetector_getMaxFeatures_10(IntPtr nativeObj);

        // C++:  void cv::GFTTDetector::setBlockSize(int blockSize)
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_setBlockSize_10(IntPtr nativeObj, int blockSize);

        // C++:  void cv::GFTTDetector::setHarrisDetector(bool val)
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_setHarrisDetector_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  void cv::GFTTDetector::setK(double k)
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_setK_10(IntPtr nativeObj, double k);

        // C++:  void cv::GFTTDetector::setMaxFeatures(int maxFeatures)
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_setMaxFeatures_10(IntPtr nativeObj, int maxFeatures);

        // C++:  void cv::GFTTDetector::setMinDistance(double minDistance)
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_setMinDistance_10(IntPtr nativeObj, double minDistance);

        // C++:  void cv::GFTTDetector::setQualityLevel(double qlevel)
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_setQualityLevel_10(IntPtr nativeObj, double qlevel);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_delete(IntPtr nativeObj);

    }
}
