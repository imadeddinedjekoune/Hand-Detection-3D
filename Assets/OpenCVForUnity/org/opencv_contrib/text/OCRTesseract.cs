//#if !UNITY_WSA_10_0
//using OpenCVForUnity.CoreModule;
//using OpenCVForUnity.UtilsModule;
//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;

//namespace OpenCVForUnity.TextModule
//{

//// C++: class OCRTesseract
////javadoc: OCRTesseract

//public class OCRTesseract : BaseOCR {

//protected override void Dispose (bool disposing)
//        {

//try {
//if (disposing) {
//}
//if (IsEnabledDispose) {
//if (nativeObj != IntPtr.Zero)
//text_OCRTesseract_delete(nativeObj);
//nativeObj = IntPtr.Zero;
//}
//} finally {
//base.Dispose (disposing);
//}

//        }

//    protected internal OCRTesseract(IntPtr addr) : base(addr) { }

//    // internal usage only
//    public static new OCRTesseract __fromPtr__(IntPtr addr) { return new OCRTesseract(addr); }

//    //
//    // C++: static Ptr_OCRTesseract cv::text::OCRTesseract::create(c_string datapath = 0, c_string language = 0, c_string char_whitelist = 0, int oem = OEM_DEFAULT, int psmode = PSM_AUTO)
//    //

//    //javadoc: OCRTesseract::create(datapath, language, char_whitelist, oem, psmode)
//    public static OCRTesseract create(string datapath, string language, string char_whitelist, int oem, int psmode)
//    {
//#if UNITY_5_3_OR_NEWER

//        OCRTesseract retVal = OCRTesseract.__fromPtr__(text_OCRTesseract_create_10(datapath, language, char_whitelist, oem, psmode));

//        return retVal;
//#else
//        return null;
//#endif
//    }

//    //javadoc: OCRTesseract::create(datapath, language, char_whitelist, oem)
//    public static OCRTesseract create(string datapath, string language, string char_whitelist, int oem)
//    {
//#if UNITY_5_3_OR_NEWER

//        OCRTesseract retVal = OCRTesseract.__fromPtr__(text_OCRTesseract_create_11(datapath, language, char_whitelist, oem));

//        return retVal;
//#else
//        return null;
//#endif
//    }

//    //javadoc: OCRTesseract::create(datapath, language, char_whitelist)
//    public static OCRTesseract create(string datapath, string language, string char_whitelist)
//    {
//#if UNITY_5_3_OR_NEWER

//        OCRTesseract retVal = OCRTesseract.__fromPtr__(text_OCRTesseract_create_12(datapath, language, char_whitelist));

//        return retVal;
//#else
//        return null;
//#endif
//    }

//    //javadoc: OCRTesseract::create(datapath, language)
//    public static OCRTesseract create(string datapath, string language)
//    {
//#if UNITY_5_3_OR_NEWER

//        OCRTesseract retVal = OCRTesseract.__fromPtr__(text_OCRTesseract_create_13(datapath, language));

//        return retVal;
//#else
//        return null;
//#endif
//    }

//    //javadoc: OCRTesseract::create(datapath)
//    public static OCRTesseract create(string datapath)
//    {
//#if UNITY_5_3_OR_NEWER

//        OCRTesseract retVal = OCRTesseract.__fromPtr__(text_OCRTesseract_create_14(datapath));

//        return retVal;
//#else
//        return null;
//#endif
//    }

//    //javadoc: OCRTesseract::create()
//    public static OCRTesseract create()
//    {
//#if UNITY_5_3_OR_NEWER

//        OCRTesseract retVal = OCRTesseract.__fromPtr__(text_OCRTesseract_create_15());

//        return retVal;
//#else
//        return null;
//#endif
//    }


//    //
//    // C++:  String cv::text::OCRTesseract::run(Mat image, Mat mask, int min_confidence, int component_level = 0)
//    //

//    //javadoc: OCRTesseract::run(image, mask, min_confidence, component_level)
//    public  string run(Mat image, Mat mask, int min_confidence, int component_level)
//    {
//        ThrowIfDisposed ();
//        if (image != null)image.ThrowIfDisposed ();
//        if (mask != null)mask.ThrowIfDisposed ();
//#if UNITY_5_3_OR_NEWER

//        string retVal = Marshal.PtrToStringAnsi (text_OCRTesseract_run_10(nativeObj, image.nativeObj, mask.nativeObj, min_confidence, component_level));

//        return retVal;
//#else
//        return null;
//#endif
//    }

//    //javadoc: OCRTesseract::run(image, mask, min_confidence)
//    public  string run(Mat image, Mat mask, int min_confidence)
//    {
//        ThrowIfDisposed ();
//        if (image != null)image.ThrowIfDisposed ();
//        if (mask != null)mask.ThrowIfDisposed ();
//#if UNITY_5_3_OR_NEWER

//        string retVal = Marshal.PtrToStringAnsi (text_OCRTesseract_run_11(nativeObj, image.nativeObj, mask.nativeObj, min_confidence));

//        return retVal;
//#else
//        return null;
//#endif
//    }


//    //
//    // C++:  String cv::text::OCRTesseract::run(Mat image, int min_confidence, int component_level = 0)
//    //

//    //javadoc: OCRTesseract::run(image, min_confidence, component_level)
//    public  string run(Mat image, int min_confidence, int component_level)
//    {
//        ThrowIfDisposed ();
//        if (image != null)image.ThrowIfDisposed ();
//#if UNITY_5_3_OR_NEWER

//        string retVal = Marshal.PtrToStringAnsi (text_OCRTesseract_run_12(nativeObj, image.nativeObj, min_confidence, component_level));

//        return retVal;
//#else
//        return null;
//#endif
//    }

//    //javadoc: OCRTesseract::run(image, min_confidence)
//    public  string run(Mat image, int min_confidence)
//    {
//        ThrowIfDisposed ();
//        if (image != null)image.ThrowIfDisposed ();
//#if UNITY_5_3_OR_NEWER

//        string retVal = Marshal.PtrToStringAnsi (text_OCRTesseract_run_13(nativeObj, image.nativeObj, min_confidence));

//        return retVal;
//#else
//        return null;
//#endif
//    }


//    //
//    // C++:  void cv::text::OCRTesseract::setWhiteList(String char_whitelist)
//    //

//    //javadoc: OCRTesseract::setWhiteList(char_whitelist)
//    public  void setWhiteList(string char_whitelist)
//    {
//        ThrowIfDisposed ();
//#if UNITY_5_3_OR_NEWER

//        text_OCRTesseract_setWhiteList_10(nativeObj, char_whitelist);

//        return;
//#else
//        return;
//#endif
//    }


//#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
//        const string LIBNAME = "__Internal";
//#else
//        const string LIBNAME = "opencvforunity";
//#endif



//    // C++: static Ptr_OCRTesseract cv::text::OCRTesseract::create(c_string datapath = 0, c_string language = 0, c_string char_whitelist = 0, int oem = OEM_DEFAULT, int psmode = PSM_AUTO)
//    [DllImport(LIBNAME)]
//    private static extern IntPtr text_OCRTesseract_create_10(string datapath, string language, string char_whitelist, int oem, int psmode);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr text_OCRTesseract_create_11(string datapath, string language, string char_whitelist, int oem);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr text_OCRTesseract_create_12(string datapath, string language, string char_whitelist);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr text_OCRTesseract_create_13(string datapath, string language);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr text_OCRTesseract_create_14(string datapath);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr text_OCRTesseract_create_15();

//    // C++:  String cv::text::OCRTesseract::run(Mat image, Mat mask, int min_confidence, int component_level = 0)
//    [DllImport(LIBNAME)]
//    private static extern IntPtr text_OCRTesseract_run_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, int min_confidence, int component_level);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr text_OCRTesseract_run_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, int min_confidence);

//    // C++:  String cv::text::OCRTesseract::run(Mat image, int min_confidence, int component_level = 0)
//    [DllImport(LIBNAME)]
//    private static extern IntPtr text_OCRTesseract_run_12(IntPtr nativeObj, IntPtr image_nativeObj, int min_confidence, int component_level);
//    [DllImport(LIBNAME)]
//    private static extern IntPtr text_OCRTesseract_run_13(IntPtr nativeObj, IntPtr image_nativeObj, int min_confidence);

//    // C++:  void cv::text::OCRTesseract::setWhiteList(String char_whitelist)
//    [DllImport(LIBNAME)]
//    private static extern void text_OCRTesseract_setWhiteList_10(IntPtr nativeObj, string char_whitelist);

//    // native support for java finalize()
//    [DllImport(LIBNAME)]
//    private static extern void text_OCRTesseract_delete(IntPtr nativeObj);

//}
//}
//#endif