
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using OpenCVForUnity.Features2dModule;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class HarrisLaplaceFeatureDetector
    //javadoc: HarrisLaplaceFeatureDetector

    public class HarrisLaplaceFeatureDetector : Feature2D
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
                        xfeatures2d_HarrisLaplaceFeatureDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal HarrisLaplaceFeatureDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new HarrisLaplaceFeatureDetector __fromPtr__(IntPtr addr) { return new HarrisLaplaceFeatureDetector(addr); }

        //
        // C++: static Ptr_HarrisLaplaceFeatureDetector cv::xfeatures2d::HarrisLaplaceFeatureDetector::create(int numOctaves = 6, float corn_thresh = 0.01f, float DOG_thresh = 0.01f, int maxCorners = 5000, int num_layers = 4)
        //

        //javadoc: HarrisLaplaceFeatureDetector::create(numOctaves, corn_thresh, DOG_thresh, maxCorners, num_layers)
        public static HarrisLaplaceFeatureDetector create(int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners, int num_layers)
        {
#if UNITY_5_3_OR_NEWER
        
        HarrisLaplaceFeatureDetector retVal = HarrisLaplaceFeatureDetector.__fromPtr__(xfeatures2d_HarrisLaplaceFeatureDetector_create_10(numOctaves, corn_thresh, DOG_thresh, maxCorners, num_layers));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: HarrisLaplaceFeatureDetector::create(numOctaves, corn_thresh, DOG_thresh, maxCorners)
        public static HarrisLaplaceFeatureDetector create(int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners)
        {
#if UNITY_5_3_OR_NEWER
        
        HarrisLaplaceFeatureDetector retVal = HarrisLaplaceFeatureDetector.__fromPtr__(xfeatures2d_HarrisLaplaceFeatureDetector_create_11(numOctaves, corn_thresh, DOG_thresh, maxCorners));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: HarrisLaplaceFeatureDetector::create(numOctaves, corn_thresh, DOG_thresh)
        public static HarrisLaplaceFeatureDetector create(int numOctaves, float corn_thresh, float DOG_thresh)
        {
#if UNITY_5_3_OR_NEWER
        
        HarrisLaplaceFeatureDetector retVal = HarrisLaplaceFeatureDetector.__fromPtr__(xfeatures2d_HarrisLaplaceFeatureDetector_create_12(numOctaves, corn_thresh, DOG_thresh));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: HarrisLaplaceFeatureDetector::create(numOctaves, corn_thresh)
        public static HarrisLaplaceFeatureDetector create(int numOctaves, float corn_thresh)
        {
#if UNITY_5_3_OR_NEWER
        
        HarrisLaplaceFeatureDetector retVal = HarrisLaplaceFeatureDetector.__fromPtr__(xfeatures2d_HarrisLaplaceFeatureDetector_create_13(numOctaves, corn_thresh));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: HarrisLaplaceFeatureDetector::create(numOctaves)
        public static HarrisLaplaceFeatureDetector create(int numOctaves)
        {
#if UNITY_5_3_OR_NEWER
        
        HarrisLaplaceFeatureDetector retVal = HarrisLaplaceFeatureDetector.__fromPtr__(xfeatures2d_HarrisLaplaceFeatureDetector_create_14(numOctaves));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: HarrisLaplaceFeatureDetector::create()
        public static HarrisLaplaceFeatureDetector create()
        {
#if UNITY_5_3_OR_NEWER
        
        HarrisLaplaceFeatureDetector retVal = HarrisLaplaceFeatureDetector.__fromPtr__(xfeatures2d_HarrisLaplaceFeatureDetector_create_15());
        
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



        // C++: static Ptr_HarrisLaplaceFeatureDetector cv::xfeatures2d::HarrisLaplaceFeatureDetector::create(int numOctaves = 6, float corn_thresh = 0.01f, float DOG_thresh = 0.01f, int maxCorners = 5000, int num_layers = 4)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_10(int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners, int num_layers);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_11(int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_12(int numOctaves, float corn_thresh, float DOG_thresh);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_13(int numOctaves, float corn_thresh);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_14(int numOctaves);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_15();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_HarrisLaplaceFeatureDetector_delete(IntPtr nativeObj);

    }
}
