
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class FlannBasedMatcher
    //javadoc: FlannBasedMatcher

    public class FlannBasedMatcher : DescriptorMatcher
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
                        features2d_FlannBasedMatcher_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FlannBasedMatcher(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FlannBasedMatcher __fromPtr__(IntPtr addr) { return new FlannBasedMatcher(addr); }

        //
        // C++:   cv::FlannBasedMatcher::FlannBasedMatcher(Ptr_flann_IndexParams indexParams = makePtr<flann::KDTreeIndexParams>(), Ptr_flann_SearchParams searchParams = makePtr<flann::SearchParams>())
        //

        //javadoc: FlannBasedMatcher::FlannBasedMatcher()
        public FlannBasedMatcher() :
#if UNITY_5_3_OR_NEWER
        
        base( features2d_FlannBasedMatcher_FlannBasedMatcher_10() )
        
#else
        base(IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++: static Ptr_FlannBasedMatcher cv::FlannBasedMatcher::create()
        //

        //javadoc: FlannBasedMatcher::create()
        public static FlannBasedMatcher create()
        {
#if UNITY_5_3_OR_NEWER
        
        FlannBasedMatcher retVal = FlannBasedMatcher.__fromPtr__(features2d_FlannBasedMatcher_create_10());
        
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



        // C++:   cv::FlannBasedMatcher::FlannBasedMatcher(Ptr_flann_IndexParams indexParams = makePtr<flann::KDTreeIndexParams>(), Ptr_flann_SearchParams searchParams = makePtr<flann::SearchParams>())
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_FlannBasedMatcher_FlannBasedMatcher_10();

        // C++: static Ptr_FlannBasedMatcher cv::FlannBasedMatcher::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_FlannBasedMatcher_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_FlannBasedMatcher_delete(IntPtr nativeObj);

    }
}
