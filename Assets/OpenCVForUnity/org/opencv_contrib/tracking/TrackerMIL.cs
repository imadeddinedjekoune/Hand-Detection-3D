
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class TrackerMIL
    //javadoc: TrackerMIL

    public class TrackerMIL : Tracker
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
                        tracking_TrackerMIL_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerMIL(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TrackerMIL __fromPtr__(IntPtr addr) { return new TrackerMIL(addr); }

        //
        // C++: static Ptr_TrackerMIL cv::TrackerMIL::create()
        //

        //javadoc: TrackerMIL::create()
        public static TrackerMIL create()
        {
#if UNITY_5_3_OR_NEWER
        
        TrackerMIL retVal = TrackerMIL.__fromPtr__(tracking_TrackerMIL_create_10());
        
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



        // C++: static Ptr_TrackerMIL cv::TrackerMIL::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_TrackerMIL_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerMIL_delete(IntPtr nativeObj);

    }
}
