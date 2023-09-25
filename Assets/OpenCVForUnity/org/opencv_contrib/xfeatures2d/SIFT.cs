
//using OpenCVForUnity.CoreModule;
//using OpenCVForUnity.UtilsModule;
//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;

//using OpenCVForUnity.Features2dModule;

//namespace OpenCVForUnity.Xfeatures2dModule
//{

//// C++: class SIFT
////javadoc: SIFT

//public class SIFT : Feature2D {

//protected override void Dispose (bool disposing)
//        {

//try {
//if (disposing) {
//}
//if (IsEnabledDispose) {
//if (nativeObj != IntPtr.Zero)
//xfeatures2d_SIFT_delete(nativeObj);
//nativeObj = IntPtr.Zero;
//}
//} finally {
//base.Dispose (disposing);
//}

//        }

//    protected internal SIFT(IntPtr addr) : base(addr) { }

//    // internal usage only
//    public static new SIFT __fromPtr__(IntPtr addr) { return new SIFT(addr); }

//    //
//    // C++: static Ptr_SIFT cv::xfeatures2d::SIFT::create(int nfeatures = 0, int nOctaveLayers = 3, double contrastThreshold = 0.04, double edgeThreshold = 10, double sigma = 1.6)
//    //

//    //javadoc: SIFT::create(nfeatures, nOctaveLayers, contrastThreshold, edgeThreshold, sigma)
//    public static SIFT create(int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma)
//    {
//        #if UNITY_5_3_OR_NEWER

//        SIFT retVal = SIFT.__fromPtr__(xfeatures2d_SIFT_create_10(nfeatures, nOctaveLayers, contrastThreshold, edgeThreshold, sigma));

//        return retVal;
//        #else
//        return null;
//        #endif
//    }

//    //javadoc: SIFT::create(nfeatures, nOctaveLayers, contrastThreshold, edgeThreshold)
//    public static SIFT create(int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold)
//    {
//        #if UNITY_5_3_OR_NEWER

//        SIFT retVal = SIFT.__fromPtr__(xfeatures2d_SIFT_create_11(nfeatures, nOctaveLayers, contrastThreshold, edgeThreshold));

//        return retVal;
//        #else
//        return null;
//        #endif
//    }

//    //javadoc: SIFT::create(nfeatures, nOctaveLayers, contrastThreshold)
//    public static SIFT create(int nfeatures, int nOctaveLayers, double contrastThreshold)
//    {
//        #if UNITY_5_3_OR_NEWER

//        SIFT retVal = SIFT.__fromPtr__(xfeatures2d_SIFT_create_12(nfeatures, nOctaveLayers, contrastThreshold));

//        return retVal;
//        #else
//        return null;
//        #endif
//    }

//    //javadoc: SIFT::create(nfeatures, nOctaveLayers)
//    public static SIFT create(int nfeatures, int nOctaveLayers)
//    {
//        #if UNITY_5_3_OR_NEWER

//        SIFT retVal = SIFT.__fromPtr__(xfeatures2d_SIFT_create_13(nfeatures, nOctaveLayers));

//        return retVal;
//        #else
//        return null;
//        #endif
//    }

//    //javadoc: SIFT::create(nfeatures)
//    public static SIFT create(int nfeatures)
//    {
//        #if UNITY_5_3_OR_NEWER

//        SIFT retVal = SIFT.__fromPtr__(xfeatures2d_SIFT_create_14(nfeatures));

//        return retVal;
//        #else
//        return null;
//        #endif
//    }

//    //javadoc: SIFT::create()
//    public static SIFT create()
//    {
//        #if UNITY_5_3_OR_NEWER

//        SIFT retVal = SIFT.__fromPtr__(xfeatures2d_SIFT_create_15());

//        return retVal;
//        #else
//        return null;
//        #endif
//    }


//        #if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
//        const string LIBNAME = "__Internal";
//        #else
//        const string LIBNAME = "opencvforunity";
//        #endif



//    // C++: static Ptr_SIFT cv::xfeatures2d::SIFT::create(int nfeatures = 0, int nOctaveLayers = 3, double contrastThreshold = 0.04, double edgeThreshold = 10, double sigma = 1.6)
//    [DllImport(LIBNAME)]
//    private static extern IntPtr xfeatures2d_SIFT_create_10(int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr xfeatures2d_SIFT_create_11(int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr xfeatures2d_SIFT_create_12(int nfeatures, int nOctaveLayers, double contrastThreshold);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr xfeatures2d_SIFT_create_13(int nfeatures, int nOctaveLayers);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr xfeatures2d_SIFT_create_14(int nfeatures);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr xfeatures2d_SIFT_create_15();

//    // native support for java finalize()
//    [DllImport(LIBNAME)]
//    private static extern void xfeatures2d_SIFT_delete(IntPtr nativeObj);

//}
//}
