
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class BFMatcher
    //javadoc: BFMatcher

    public class BFMatcher : DescriptorMatcher
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
                        features2d_BFMatcher_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BFMatcher(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BFMatcher __fromPtr__(IntPtr addr) { return new BFMatcher(addr); }

        //
        // C++:   cv::BFMatcher::BFMatcher(int normType = NORM_L2, bool crossCheck = false)
        //

        //javadoc: BFMatcher::BFMatcher(normType, crossCheck)
        public BFMatcher(int normType, bool crossCheck) :
#if UNITY_5_3_OR_NEWER
        
        base( features2d_BFMatcher_BFMatcher_10(normType, crossCheck) )
        
#else
        base(IntPtr.Zero)
#endif
        {

            return;

        }

        //javadoc: BFMatcher::BFMatcher(normType)
        public BFMatcher(int normType) :
#if UNITY_5_3_OR_NEWER
        
        base( features2d_BFMatcher_BFMatcher_11(normType) )
        
#else
        base(IntPtr.Zero)
#endif
        {

            return;

        }

        //javadoc: BFMatcher::BFMatcher()
        public BFMatcher() :
#if UNITY_5_3_OR_NEWER
        
        base( features2d_BFMatcher_BFMatcher_12() )
        
#else
        base(IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++: static Ptr_BFMatcher cv::BFMatcher::create(int normType = NORM_L2, bool crossCheck = false)
        //

        //javadoc: BFMatcher::create(normType, crossCheck)
        public static BFMatcher create(int normType, bool crossCheck)
        {
#if UNITY_5_3_OR_NEWER
        
        BFMatcher retVal = BFMatcher.__fromPtr__(features2d_BFMatcher_create_10(normType, crossCheck));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BFMatcher::create(normType)
        public static new BFMatcher create(int normType)
        {
#if UNITY_5_3_OR_NEWER
        
        BFMatcher retVal = BFMatcher.__fromPtr__(features2d_BFMatcher_create_11(normType));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BFMatcher::create()
        public static BFMatcher create()
        {
#if UNITY_5_3_OR_NEWER
        
        BFMatcher retVal = BFMatcher.__fromPtr__(features2d_BFMatcher_create_12());
        
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



        // C++:   cv::BFMatcher::BFMatcher(int normType = NORM_L2, bool crossCheck = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_BFMatcher_10(int normType, [MarshalAs(UnmanagedType.U1)] bool crossCheck);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_BFMatcher_11(int normType);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_BFMatcher_12();

        // C++: static Ptr_BFMatcher cv::BFMatcher::create(int normType = NORM_L2, bool crossCheck = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_create_10(int normType, [MarshalAs(UnmanagedType.U1)] bool crossCheck);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_create_11(int normType);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_create_12();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_BFMatcher_delete(IntPtr nativeObj);

    }
}
