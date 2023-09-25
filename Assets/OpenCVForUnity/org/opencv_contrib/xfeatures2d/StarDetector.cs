
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using OpenCVForUnity.Features2dModule;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class StarDetector
    //javadoc: StarDetector

    public class StarDetector : Feature2D
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
                        xfeatures2d_StarDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StarDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StarDetector __fromPtr__(IntPtr addr) { return new StarDetector(addr); }

        //
        // C++: static Ptr_StarDetector cv::xfeatures2d::StarDetector::create(int maxSize = 45, int responseThreshold = 30, int lineThresholdProjected = 10, int lineThresholdBinarized = 8, int suppressNonmaxSize = 5)
        //

        //javadoc: StarDetector::create(maxSize, responseThreshold, lineThresholdProjected, lineThresholdBinarized, suppressNonmaxSize)
        public static StarDetector create(int maxSize, int responseThreshold, int lineThresholdProjected, int lineThresholdBinarized, int suppressNonmaxSize)
        {
#if UNITY_5_3_OR_NEWER
        
        StarDetector retVal = StarDetector.__fromPtr__(xfeatures2d_StarDetector_create_10(maxSize, responseThreshold, lineThresholdProjected, lineThresholdBinarized, suppressNonmaxSize));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StarDetector::create(maxSize, responseThreshold, lineThresholdProjected, lineThresholdBinarized)
        public static StarDetector create(int maxSize, int responseThreshold, int lineThresholdProjected, int lineThresholdBinarized)
        {
#if UNITY_5_3_OR_NEWER
        
        StarDetector retVal = StarDetector.__fromPtr__(xfeatures2d_StarDetector_create_11(maxSize, responseThreshold, lineThresholdProjected, lineThresholdBinarized));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StarDetector::create(maxSize, responseThreshold, lineThresholdProjected)
        public static StarDetector create(int maxSize, int responseThreshold, int lineThresholdProjected)
        {
#if UNITY_5_3_OR_NEWER
        
        StarDetector retVal = StarDetector.__fromPtr__(xfeatures2d_StarDetector_create_12(maxSize, responseThreshold, lineThresholdProjected));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StarDetector::create(maxSize, responseThreshold)
        public static StarDetector create(int maxSize, int responseThreshold)
        {
#if UNITY_5_3_OR_NEWER
        
        StarDetector retVal = StarDetector.__fromPtr__(xfeatures2d_StarDetector_create_13(maxSize, responseThreshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StarDetector::create(maxSize)
        public static StarDetector create(int maxSize)
        {
#if UNITY_5_3_OR_NEWER
        
        StarDetector retVal = StarDetector.__fromPtr__(xfeatures2d_StarDetector_create_14(maxSize));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StarDetector::create()
        public static StarDetector create()
        {
#if UNITY_5_3_OR_NEWER
        
        StarDetector retVal = StarDetector.__fromPtr__(xfeatures2d_StarDetector_create_15());
        
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



        // C++: static Ptr_StarDetector cv::xfeatures2d::StarDetector::create(int maxSize = 45, int responseThreshold = 30, int lineThresholdProjected = 10, int lineThresholdBinarized = 8, int suppressNonmaxSize = 5)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_10(int maxSize, int responseThreshold, int lineThresholdProjected, int lineThresholdBinarized, int suppressNonmaxSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_11(int maxSize, int responseThreshold, int lineThresholdProjected, int lineThresholdBinarized);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_12(int maxSize, int responseThreshold, int lineThresholdProjected);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_13(int maxSize, int responseThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_14(int maxSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_15();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_StarDetector_delete(IntPtr nativeObj);

    }
}
