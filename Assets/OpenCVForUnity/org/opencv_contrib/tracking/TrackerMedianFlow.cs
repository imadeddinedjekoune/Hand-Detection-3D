
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class TrackerMedianFlow
    //javadoc: TrackerMedianFlow

    public class TrackerMedianFlow : Tracker
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
                        tracking_TrackerMedianFlow_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerMedianFlow(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TrackerMedianFlow __fromPtr__(IntPtr addr) { return new TrackerMedianFlow(addr); }

        //
        // C++: static Ptr_TrackerMedianFlow cv::TrackerMedianFlow::create()
        //

        //javadoc: TrackerMedianFlow::create()
        public static TrackerMedianFlow create()
        {
#if UNITY_5_3_OR_NEWER
        
        TrackerMedianFlow retVal = TrackerMedianFlow.__fromPtr__(tracking_TrackerMedianFlow_create_10());
        
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



        // C++: static Ptr_TrackerMedianFlow cv::TrackerMedianFlow::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_TrackerMedianFlow_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerMedianFlow_delete(IntPtr nativeObj);

    }
}
