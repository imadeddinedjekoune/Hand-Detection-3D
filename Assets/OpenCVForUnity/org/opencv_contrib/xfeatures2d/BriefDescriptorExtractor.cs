
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using OpenCVForUnity.Features2dModule;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class BriefDescriptorExtractor
    //javadoc: BriefDescriptorExtractor

    public class BriefDescriptorExtractor : Feature2D
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
                        xfeatures2d_BriefDescriptorExtractor_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BriefDescriptorExtractor(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BriefDescriptorExtractor __fromPtr__(IntPtr addr) { return new BriefDescriptorExtractor(addr); }

        //
        // C++: static Ptr_BriefDescriptorExtractor cv::xfeatures2d::BriefDescriptorExtractor::create(int bytes = 32, bool use_orientation = false)
        //

        //javadoc: BriefDescriptorExtractor::create(bytes, use_orientation)
        public static BriefDescriptorExtractor create(int bytes, bool use_orientation)
        {
#if UNITY_5_3_OR_NEWER
        
        BriefDescriptorExtractor retVal = BriefDescriptorExtractor.__fromPtr__(xfeatures2d_BriefDescriptorExtractor_create_10(bytes, use_orientation));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BriefDescriptorExtractor::create(bytes)
        public static BriefDescriptorExtractor create(int bytes)
        {
#if UNITY_5_3_OR_NEWER
        
        BriefDescriptorExtractor retVal = BriefDescriptorExtractor.__fromPtr__(xfeatures2d_BriefDescriptorExtractor_create_11(bytes));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BriefDescriptorExtractor::create()
        public static BriefDescriptorExtractor create()
        {
#if UNITY_5_3_OR_NEWER
        
        BriefDescriptorExtractor retVal = BriefDescriptorExtractor.__fromPtr__(xfeatures2d_BriefDescriptorExtractor_create_12());
        
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



        // C++: static Ptr_BriefDescriptorExtractor cv::xfeatures2d::BriefDescriptorExtractor::create(int bytes = 32, bool use_orientation = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BriefDescriptorExtractor_create_10(int bytes, [MarshalAs(UnmanagedType.U1)] bool use_orientation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BriefDescriptorExtractor_create_11(int bytes);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BriefDescriptorExtractor_create_12();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_BriefDescriptorExtractor_delete(IntPtr nativeObj);

    }
}
