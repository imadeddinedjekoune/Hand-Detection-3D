
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class TrackerBoosting
    //javadoc: TrackerBoosting

    public class TrackerBoosting : Tracker
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
                        tracking_TrackerBoosting_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerBoosting(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TrackerBoosting __fromPtr__(IntPtr addr) { return new TrackerBoosting(addr); }

        //
        // C++: static Ptr_TrackerBoosting cv::TrackerBoosting::create()
        //

        //javadoc: TrackerBoosting::create()
        public static TrackerBoosting create()
        {
#if UNITY_5_3_OR_NEWER
        
        TrackerBoosting retVal = TrackerBoosting.__fromPtr__(tracking_TrackerBoosting_create_10());
        
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



        // C++: static Ptr_TrackerBoosting cv::TrackerBoosting::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_TrackerBoosting_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerBoosting_delete(IntPtr nativeObj);

    }
}
