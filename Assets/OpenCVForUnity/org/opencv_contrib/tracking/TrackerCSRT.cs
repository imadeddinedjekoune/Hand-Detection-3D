
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class TrackerCSRT
    //javadoc: TrackerCSRT

    public class TrackerCSRT : Tracker
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
                        tracking_TrackerCSRT_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerCSRT(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TrackerCSRT __fromPtr__(IntPtr addr) { return new TrackerCSRT(addr); }

        //
        // C++: static Ptr_TrackerCSRT cv::TrackerCSRT::create()
        //

        //javadoc: TrackerCSRT::create()
        public static TrackerCSRT create()
        {
#if UNITY_5_3_OR_NEWER
        
        TrackerCSRT retVal = TrackerCSRT.__fromPtr__(tracking_TrackerCSRT_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::TrackerCSRT::setInitialMask(Mat mask)
        //

        //javadoc: TrackerCSRT::setInitialMask(mask)
        public void setInitialMask(Mat mask)
        {
            ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        tracking_TrackerCSRT_setInitialMask_10(nativeObj, mask.nativeObj);
        
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



        // C++: static Ptr_TrackerCSRT cv::TrackerCSRT::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_TrackerCSRT_create_10();

        // C++:  void cv::TrackerCSRT::setInitialMask(Mat mask)
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_setInitialMask_10(IntPtr nativeObj, IntPtr mask_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_delete(IntPtr nativeObj);

    }
}
