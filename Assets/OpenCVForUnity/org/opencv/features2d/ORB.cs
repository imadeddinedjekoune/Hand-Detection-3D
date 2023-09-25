
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class ORB
    //javadoc: ORB

    public class ORB : Feature2D
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
                        features2d_ORB_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal ORB(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new ORB __fromPtr__(IntPtr addr) { return new ORB(addr); }

        // C++: enum ScoreType
        public const int HARRIS_SCORE = 0;
        public const int FAST_SCORE = 1;
        //
        // C++:  ORB_ScoreType cv::ORB::getScoreType()
        //

        //javadoc: ORB::getScoreType()
        public int getScoreType()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_ORB_getScoreType_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: static Ptr_ORB cv::ORB::create(int nfeatures = 500, float scaleFactor = 1.2f, int nlevels = 8, int edgeThreshold = 31, int firstLevel = 0, int WTA_K = 2, ORB_ScoreType scoreType = ORB::HARRIS_SCORE, int patchSize = 31, int fastThreshold = 20)
        //

        //javadoc: ORB::create(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K, scoreType, patchSize, fastThreshold)
        public static ORB create(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType, int patchSize, int fastThreshold)
        {
#if UNITY_5_3_OR_NEWER
        
        ORB retVal = ORB.__fromPtr__(features2d_ORB_create_10(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K, scoreType, patchSize, fastThreshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: ORB::create(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K, scoreType, patchSize)
        public static ORB create(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType, int patchSize)
        {
#if UNITY_5_3_OR_NEWER
        
        ORB retVal = ORB.__fromPtr__(features2d_ORB_create_11(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K, scoreType, patchSize));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: ORB::create(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K, scoreType)
        public static ORB create(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType)
        {
#if UNITY_5_3_OR_NEWER
        
        ORB retVal = ORB.__fromPtr__(features2d_ORB_create_12(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K, scoreType));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: ORB::create(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K)
        public static ORB create(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K)
        {
#if UNITY_5_3_OR_NEWER
        
        ORB retVal = ORB.__fromPtr__(features2d_ORB_create_13(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: ORB::create(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel)
        public static ORB create(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel)
        {
#if UNITY_5_3_OR_NEWER
        
        ORB retVal = ORB.__fromPtr__(features2d_ORB_create_14(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: ORB::create(nfeatures, scaleFactor, nlevels, edgeThreshold)
        public static ORB create(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold)
        {
#if UNITY_5_3_OR_NEWER
        
        ORB retVal = ORB.__fromPtr__(features2d_ORB_create_15(nfeatures, scaleFactor, nlevels, edgeThreshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: ORB::create(nfeatures, scaleFactor, nlevels)
        public static ORB create(int nfeatures, float scaleFactor, int nlevels)
        {
#if UNITY_5_3_OR_NEWER
        
        ORB retVal = ORB.__fromPtr__(features2d_ORB_create_16(nfeatures, scaleFactor, nlevels));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: ORB::create(nfeatures, scaleFactor)
        public static ORB create(int nfeatures, float scaleFactor)
        {
#if UNITY_5_3_OR_NEWER
        
        ORB retVal = ORB.__fromPtr__(features2d_ORB_create_17(nfeatures, scaleFactor));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: ORB::create(nfeatures)
        public static ORB create(int nfeatures)
        {
#if UNITY_5_3_OR_NEWER
        
        ORB retVal = ORB.__fromPtr__(features2d_ORB_create_18(nfeatures));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: ORB::create()
        public static ORB create()
        {
#if UNITY_5_3_OR_NEWER
        
        ORB retVal = ORB.__fromPtr__(features2d_ORB_create_19());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::ORB::getDefaultName()
        //

        //javadoc: ORB::getDefaultName()
        public override string getDefaultName()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (features2d_ORB_getDefaultName_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  double cv::ORB::getScaleFactor()
        //

        //javadoc: ORB::getScaleFactor()
        public double getScaleFactor()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = features2d_ORB_getScaleFactor_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ORB::getEdgeThreshold()
        //

        //javadoc: ORB::getEdgeThreshold()
        public int getEdgeThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_ORB_getEdgeThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ORB::getFastThreshold()
        //

        //javadoc: ORB::getFastThreshold()
        public int getFastThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_ORB_getFastThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ORB::getFirstLevel()
        //

        //javadoc: ORB::getFirstLevel()
        public int getFirstLevel()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_ORB_getFirstLevel_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ORB::getMaxFeatures()
        //

        //javadoc: ORB::getMaxFeatures()
        public int getMaxFeatures()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_ORB_getMaxFeatures_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ORB::getNLevels()
        //

        //javadoc: ORB::getNLevels()
        public int getNLevels()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_ORB_getNLevels_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ORB::getPatchSize()
        //

        //javadoc: ORB::getPatchSize()
        public int getPatchSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_ORB_getPatchSize_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ORB::getWTA_K()
        //

        //javadoc: ORB::getWTA_K()
        public int getWTA_K()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_ORB_getWTA_1K_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ORB::setEdgeThreshold(int edgeThreshold)
        //

        //javadoc: ORB::setEdgeThreshold(edgeThreshold)
        public void setEdgeThreshold(int edgeThreshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_ORB_setEdgeThreshold_10(nativeObj, edgeThreshold);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ORB::setFastThreshold(int fastThreshold)
        //

        //javadoc: ORB::setFastThreshold(fastThreshold)
        public void setFastThreshold(int fastThreshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_ORB_setFastThreshold_10(nativeObj, fastThreshold);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ORB::setFirstLevel(int firstLevel)
        //

        //javadoc: ORB::setFirstLevel(firstLevel)
        public void setFirstLevel(int firstLevel)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_ORB_setFirstLevel_10(nativeObj, firstLevel);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ORB::setMaxFeatures(int maxFeatures)
        //

        //javadoc: ORB::setMaxFeatures(maxFeatures)
        public void setMaxFeatures(int maxFeatures)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_ORB_setMaxFeatures_10(nativeObj, maxFeatures);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ORB::setNLevels(int nlevels)
        //

        //javadoc: ORB::setNLevels(nlevels)
        public void setNLevels(int nlevels)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_ORB_setNLevels_10(nativeObj, nlevels);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ORB::setPatchSize(int patchSize)
        //

        //javadoc: ORB::setPatchSize(patchSize)
        public void setPatchSize(int patchSize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_ORB_setPatchSize_10(nativeObj, patchSize);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ORB::setScaleFactor(double scaleFactor)
        //

        //javadoc: ORB::setScaleFactor(scaleFactor)
        public void setScaleFactor(double scaleFactor)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_ORB_setScaleFactor_10(nativeObj, scaleFactor);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ORB::setScoreType(ORB_ScoreType scoreType)
        //

        //javadoc: ORB::setScoreType(scoreType)
        public void setScoreType(int scoreType)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_ORB_setScoreType_10(nativeObj, scoreType);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ORB::setWTA_K(int wta_k)
        //

        //javadoc: ORB::setWTA_K(wta_k)
        public void setWTA_K(int wta_k)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_ORB_setWTA_1K_10(nativeObj, wta_k);
        
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



        // C++:  ORB_ScoreType cv::ORB::getScoreType()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getScoreType_10(IntPtr nativeObj);

        // C++: static Ptr_ORB cv::ORB::create(int nfeatures = 500, float scaleFactor = 1.2f, int nlevels = 8, int edgeThreshold = 31, int firstLevel = 0, int WTA_K = 2, ORB_ScoreType scoreType = ORB::HARRIS_SCORE, int patchSize = 31, int fastThreshold = 20)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_10(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType, int patchSize, int fastThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_11(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType, int patchSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_12(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_13(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_14(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_15(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_16(int nfeatures, float scaleFactor, int nlevels);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_17(int nfeatures, float scaleFactor);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_18(int nfeatures);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_19();

        // C++:  String cv::ORB::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_getDefaultName_10(IntPtr nativeObj);

        // C++:  double cv::ORB::getScaleFactor()
        [DllImport(LIBNAME)]
        private static extern double features2d_ORB_getScaleFactor_10(IntPtr nativeObj);

        // C++:  int cv::ORB::getEdgeThreshold()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getEdgeThreshold_10(IntPtr nativeObj);

        // C++:  int cv::ORB::getFastThreshold()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getFastThreshold_10(IntPtr nativeObj);

        // C++:  int cv::ORB::getFirstLevel()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getFirstLevel_10(IntPtr nativeObj);

        // C++:  int cv::ORB::getMaxFeatures()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getMaxFeatures_10(IntPtr nativeObj);

        // C++:  int cv::ORB::getNLevels()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getNLevels_10(IntPtr nativeObj);

        // C++:  int cv::ORB::getPatchSize()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getPatchSize_10(IntPtr nativeObj);

        // C++:  int cv::ORB::getWTA_K()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getWTA_1K_10(IntPtr nativeObj);

        // C++:  void cv::ORB::setEdgeThreshold(int edgeThreshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setEdgeThreshold_10(IntPtr nativeObj, int edgeThreshold);

        // C++:  void cv::ORB::setFastThreshold(int fastThreshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setFastThreshold_10(IntPtr nativeObj, int fastThreshold);

        // C++:  void cv::ORB::setFirstLevel(int firstLevel)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setFirstLevel_10(IntPtr nativeObj, int firstLevel);

        // C++:  void cv::ORB::setMaxFeatures(int maxFeatures)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setMaxFeatures_10(IntPtr nativeObj, int maxFeatures);

        // C++:  void cv::ORB::setNLevels(int nlevels)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setNLevels_10(IntPtr nativeObj, int nlevels);

        // C++:  void cv::ORB::setPatchSize(int patchSize)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setPatchSize_10(IntPtr nativeObj, int patchSize);

        // C++:  void cv::ORB::setScaleFactor(double scaleFactor)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setScaleFactor_10(IntPtr nativeObj, double scaleFactor);

        // C++:  void cv::ORB::setScoreType(ORB_ScoreType scoreType)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setScoreType_10(IntPtr nativeObj, int scoreType);

        // C++:  void cv::ORB::setWTA_K(int wta_k)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setWTA_1K_10(IntPtr nativeObj, int wta_k);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_delete(IntPtr nativeObj);

    }
}
