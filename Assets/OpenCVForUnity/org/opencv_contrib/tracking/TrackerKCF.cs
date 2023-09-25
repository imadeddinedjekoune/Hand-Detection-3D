
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class TrackerKCF
    //javadoc: TrackerKCF

    public class TrackerKCF : Tracker
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
                        tracking_TrackerKCF_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerKCF(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TrackerKCF __fromPtr__(IntPtr addr) { return new TrackerKCF(addr); }

        // C++: enum MODE
        public const int GRAY = (1 << 0);
        public const int CN = (1 << 1);
        public const int CUSTOM = (1 << 2);
        //
        // C++: static Ptr_TrackerKCF cv::TrackerKCF::create()
        //

        //javadoc: TrackerKCF::create()
        public static TrackerKCF create()
        {
#if UNITY_5_3_OR_NEWER
        
        TrackerKCF retVal = TrackerKCF.__fromPtr__(tracking_TrackerKCF_create_10());
        
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



        // C++: static Ptr_TrackerKCF cv::TrackerKCF::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_TrackerKCF_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerKCF_delete(IntPtr nativeObj);

    }
}
