
//using OpenCVForUnity.CoreModule;
//using OpenCVForUnity.UtilsModule;
//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;

//namespace OpenCVForUnity.TrackingModule
//{

//// C++: class TrackerGOTURN
////javadoc: TrackerGOTURN

//public class TrackerGOTURN : Tracker {

//protected override void Dispose (bool disposing)
//        {

//try {
//if (disposing) {
//}
//if (IsEnabledDispose) {
//if (nativeObj != IntPtr.Zero)
//tracking_TrackerGOTURN_delete(nativeObj);
//nativeObj = IntPtr.Zero;
//}
//} finally {
//base.Dispose (disposing);
//}

//        }

//    protected internal TrackerGOTURN(IntPtr addr) : base(addr) { }

//    // internal usage only
//    public static new TrackerGOTURN __fromPtr__(IntPtr addr) { return new TrackerGOTURN(addr); }

//    //
//    // C++: static Ptr_TrackerGOTURN cv::TrackerGOTURN::create()
//    //

//    //javadoc: TrackerGOTURN::create()
//    public static TrackerGOTURN create()
//    {
//        #if UNITY_5_3_OR_NEWER

//        TrackerGOTURN retVal = TrackerGOTURN.__fromPtr__(tracking_TrackerGOTURN_create_10());

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



//    // C++: static Ptr_TrackerGOTURN cv::TrackerGOTURN::create()
//    [DllImport(LIBNAME)]
//    private static extern IntPtr tracking_TrackerGOTURN_create_10();

//    // native support for java finalize()
//    [DllImport(LIBNAME)]
//    private static extern void tracking_TrackerGOTURN_delete(IntPtr nativeObj);

//}
//}
