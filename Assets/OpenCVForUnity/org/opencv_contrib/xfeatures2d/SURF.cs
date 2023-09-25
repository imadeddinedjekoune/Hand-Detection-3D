
//using OpenCVForUnity.CoreModule;
//using OpenCVForUnity.UtilsModule;
//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;

//using OpenCVForUnity.Features2dModule;

//namespace OpenCVForUnity.Xfeatures2dModule
//{

//// C++: class SURF
////javadoc: SURF

//public class SURF : Feature2D {

//protected override void Dispose (bool disposing)
//        {

//try {
//if (disposing) {
//}
//if (IsEnabledDispose) {
//if (nativeObj != IntPtr.Zero)
//xfeatures2d_SURF_delete(nativeObj);
//nativeObj = IntPtr.Zero;
//}
//} finally {
//base.Dispose (disposing);
//}

//        }

//    protected internal SURF(IntPtr addr) : base(addr) { }

//    // internal usage only
//    public static new SURF __fromPtr__(IntPtr addr) { return new SURF(addr); }

//    //
//    // C++: static Ptr_SURF cv::xfeatures2d::SURF::create(double hessianThreshold = 100, int nOctaves = 4, int nOctaveLayers = 3, bool extended = false, bool upright = false)
//    //

//    //javadoc: SURF::create(hessianThreshold, nOctaves, nOctaveLayers, extended, upright)
//    public static SURF create(double hessianThreshold, int nOctaves, int nOctaveLayers, bool extended, bool upright)
//    {
//        #if UNITY_5_3_OR_NEWER

//        SURF retVal = SURF.__fromPtr__(xfeatures2d_SURF_create_10(hessianThreshold, nOctaves, nOctaveLayers, extended, upright));

//        return retVal;
//        #else
//        return null;
//        #endif
//    }

//    //javadoc: SURF::create(hessianThreshold, nOctaves, nOctaveLayers, extended)
//    public static SURF create(double hessianThreshold, int nOctaves, int nOctaveLayers, bool extended)
//    {
//        #if UNITY_5_3_OR_NEWER

//        SURF retVal = SURF.__fromPtr__(xfeatures2d_SURF_create_11(hessianThreshold, nOctaves, nOctaveLayers, extended));

//        return retVal;
//        #else
//        return null;
//        #endif
//    }

//    //javadoc: SURF::create(hessianThreshold, nOctaves, nOctaveLayers)
//    public static SURF create(double hessianThreshold, int nOctaves, int nOctaveLayers)
//    {
//        #if UNITY_5_3_OR_NEWER

//        SURF retVal = SURF.__fromPtr__(xfeatures2d_SURF_create_12(hessianThreshold, nOctaves, nOctaveLayers));

//        return retVal;
//        #else
//        return null;
//        #endif
//    }

//    //javadoc: SURF::create(hessianThreshold, nOctaves)
//    public static SURF create(double hessianThreshold, int nOctaves)
//    {
//        #if UNITY_5_3_OR_NEWER

//        SURF retVal = SURF.__fromPtr__(xfeatures2d_SURF_create_13(hessianThreshold, nOctaves));

//        return retVal;
//        #else
//        return null;
//        #endif
//    }

//    //javadoc: SURF::create(hessianThreshold)
//    public static SURF create(double hessianThreshold)
//    {
//        #if UNITY_5_3_OR_NEWER

//        SURF retVal = SURF.__fromPtr__(xfeatures2d_SURF_create_14(hessianThreshold));

//        return retVal;
//        #else
//        return null;
//        #endif
//    }

//    //javadoc: SURF::create()
//    public static SURF create()
//    {
//        #if UNITY_5_3_OR_NEWER

//        SURF retVal = SURF.__fromPtr__(xfeatures2d_SURF_create_15());

//        return retVal;
//        #else
//        return null;
//        #endif
//    }


//    //
//    // C++:  bool cv::xfeatures2d::SURF::getExtended()
//    //

//    //javadoc: SURF::getExtended()
//    public  bool getExtended()
//    {
//        ThrowIfDisposed ();
//        #if UNITY_5_3_OR_NEWER

//        bool retVal = xfeatures2d_SURF_getExtended_10(nativeObj);

//        return retVal;
//        #else
//        return false;
//        #endif
//    }


//    //
//    // C++:  bool cv::xfeatures2d::SURF::getUpright()
//    //

//    //javadoc: SURF::getUpright()
//    public  bool getUpright()
//    {
//        ThrowIfDisposed ();
//        #if UNITY_5_3_OR_NEWER

//        bool retVal = xfeatures2d_SURF_getUpright_10(nativeObj);

//        return retVal;
//        #else
//        return false;
//        #endif
//    }


//    //
//    // C++:  double cv::xfeatures2d::SURF::getHessianThreshold()
//    //

//    //javadoc: SURF::getHessianThreshold()
//    public  double getHessianThreshold()
//    {
//        ThrowIfDisposed ();
//        #if UNITY_5_3_OR_NEWER

//        double retVal = xfeatures2d_SURF_getHessianThreshold_10(nativeObj);

//        return retVal;
//        #else
//        return -1;
//        #endif
//    }


//    //
//    // C++:  int cv::xfeatures2d::SURF::getNOctaveLayers()
//    //

//    //javadoc: SURF::getNOctaveLayers()
//    public  int getNOctaveLayers()
//    {
//        ThrowIfDisposed ();
//        #if UNITY_5_3_OR_NEWER

//        int retVal = xfeatures2d_SURF_getNOctaveLayers_10(nativeObj);

//        return retVal;
//        #else
//        return -1;
//        #endif
//    }


//    //
//    // C++:  int cv::xfeatures2d::SURF::getNOctaves()
//    //

//    //javadoc: SURF::getNOctaves()
//    public  int getNOctaves()
//    {
//        ThrowIfDisposed ();
//        #if UNITY_5_3_OR_NEWER

//        int retVal = xfeatures2d_SURF_getNOctaves_10(nativeObj);

//        return retVal;
//        #else
//        return -1;
//        #endif
//    }


//    //
//    // C++:  void cv::xfeatures2d::SURF::setExtended(bool extended)
//    //

//    //javadoc: SURF::setExtended(extended)
//    public  void setExtended(bool extended)
//    {
//        ThrowIfDisposed ();
//        #if UNITY_5_3_OR_NEWER

//        xfeatures2d_SURF_setExtended_10(nativeObj, extended);

//        return;
//        #else
//        return;
//        #endif
//    }


//    //
//    // C++:  void cv::xfeatures2d::SURF::setHessianThreshold(double hessianThreshold)
//    //

//    //javadoc: SURF::setHessianThreshold(hessianThreshold)
//    public  void setHessianThreshold(double hessianThreshold)
//    {
//        ThrowIfDisposed ();
//        #if UNITY_5_3_OR_NEWER

//        xfeatures2d_SURF_setHessianThreshold_10(nativeObj, hessianThreshold);

//        return;
//        #else
//        return;
//        #endif
//    }


//    //
//    // C++:  void cv::xfeatures2d::SURF::setNOctaveLayers(int nOctaveLayers)
//    //

//    //javadoc: SURF::setNOctaveLayers(nOctaveLayers)
//    public  void setNOctaveLayers(int nOctaveLayers)
//    {
//        ThrowIfDisposed ();
//        #if UNITY_5_3_OR_NEWER

//        xfeatures2d_SURF_setNOctaveLayers_10(nativeObj, nOctaveLayers);

//        return;
//        #else
//        return;
//        #endif
//    }


//    //
//    // C++:  void cv::xfeatures2d::SURF::setNOctaves(int nOctaves)
//    //

//    //javadoc: SURF::setNOctaves(nOctaves)
//    public  void setNOctaves(int nOctaves)
//    {
//        ThrowIfDisposed ();
//        #if UNITY_5_3_OR_NEWER

//        xfeatures2d_SURF_setNOctaves_10(nativeObj, nOctaves);

//        return;
//        #else
//        return;
//        #endif
//    }


//    //
//    // C++:  void cv::xfeatures2d::SURF::setUpright(bool upright)
//    //

//    //javadoc: SURF::setUpright(upright)
//    public  void setUpright(bool upright)
//    {
//        ThrowIfDisposed ();
//        #if UNITY_5_3_OR_NEWER

//        xfeatures2d_SURF_setUpright_10(nativeObj, upright);

//        return;
//        #else
//        return;
//        #endif
//    }


//        #if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
//        const string LIBNAME = "__Internal";
//        #else
//        const string LIBNAME = "opencvforunity";
//        #endif



//    // C++: static Ptr_SURF cv::xfeatures2d::SURF::create(double hessianThreshold = 100, int nOctaves = 4, int nOctaveLayers = 3, bool extended = false, bool upright = false)
//    [DllImport(LIBNAME)]
//    private static extern IntPtr xfeatures2d_SURF_create_10(double hessianThreshold, int nOctaves, int nOctaveLayers, [MarshalAs(UnmanagedType.U1)] bool extended, [MarshalAs(UnmanagedType.U1)] bool upright);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr xfeatures2d_SURF_create_11(double hessianThreshold, int nOctaves, int nOctaveLayers, [MarshalAs(UnmanagedType.U1)] bool extended);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr xfeatures2d_SURF_create_12(double hessianThreshold, int nOctaves, int nOctaveLayers);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr xfeatures2d_SURF_create_13(double hessianThreshold, int nOctaves);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr xfeatures2d_SURF_create_14(double hessianThreshold);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr xfeatures2d_SURF_create_15();

//    // C++:  bool cv::xfeatures2d::SURF::getExtended()
//    [DllImport(LIBNAME)]
//    [return: MarshalAs(UnmanagedType.U1)]
//    private static extern bool xfeatures2d_SURF_getExtended_10(IntPtr nativeObj);

//    // C++:  bool cv::xfeatures2d::SURF::getUpright()
//    [DllImport(LIBNAME)]
//    [return: MarshalAs(UnmanagedType.U1)]
//    private static extern bool xfeatures2d_SURF_getUpright_10(IntPtr nativeObj);

//    // C++:  double cv::xfeatures2d::SURF::getHessianThreshold()
//    [DllImport(LIBNAME)]
//    private static extern double xfeatures2d_SURF_getHessianThreshold_10(IntPtr nativeObj);

//    // C++:  int cv::xfeatures2d::SURF::getNOctaveLayers()
//    [DllImport(LIBNAME)]
//    private static extern int xfeatures2d_SURF_getNOctaveLayers_10(IntPtr nativeObj);

//    // C++:  int cv::xfeatures2d::SURF::getNOctaves()
//    [DllImport(LIBNAME)]
//    private static extern int xfeatures2d_SURF_getNOctaves_10(IntPtr nativeObj);

//    // C++:  void cv::xfeatures2d::SURF::setExtended(bool extended)
//    [DllImport(LIBNAME)]
//    private static extern void xfeatures2d_SURF_setExtended_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool extended);

//    // C++:  void cv::xfeatures2d::SURF::setHessianThreshold(double hessianThreshold)
//    [DllImport(LIBNAME)]
//    private static extern void xfeatures2d_SURF_setHessianThreshold_10(IntPtr nativeObj, double hessianThreshold);

//    // C++:  void cv::xfeatures2d::SURF::setNOctaveLayers(int nOctaveLayers)
//    [DllImport(LIBNAME)]
//    private static extern void xfeatures2d_SURF_setNOctaveLayers_10(IntPtr nativeObj, int nOctaveLayers);

//    // C++:  void cv::xfeatures2d::SURF::setNOctaves(int nOctaves)
//    [DllImport(LIBNAME)]
//    private static extern void xfeatures2d_SURF_setNOctaves_10(IntPtr nativeObj, int nOctaves);

//    // C++:  void cv::xfeatures2d::SURF::setUpright(bool upright)
//    [DllImport(LIBNAME)]
//    private static extern void xfeatures2d_SURF_setUpright_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool upright);

//    // native support for java finalize()
//    [DllImport(LIBNAME)]
//    private static extern void xfeatures2d_SURF_delete(IntPtr nativeObj);

//}
//}
