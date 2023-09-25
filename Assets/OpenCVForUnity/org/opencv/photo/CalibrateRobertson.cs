
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class CalibrateRobertson
    //javadoc: CalibrateRobertson

    public class CalibrateRobertson : CalibrateCRF
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
                        photo_CalibrateRobertson_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal CalibrateRobertson(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new CalibrateRobertson __fromPtr__(IntPtr addr) { return new CalibrateRobertson(addr); }

        //
        // C++:  Mat cv::CalibrateRobertson::getRadiance()
        //

        //javadoc: CalibrateRobertson::getRadiance()
        public Mat getRadiance()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(photo_CalibrateRobertson_getRadiance_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  float cv::CalibrateRobertson::getThreshold()
        //

        //javadoc: CalibrateRobertson::getThreshold()
        public float getThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = photo_CalibrateRobertson_getThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::CalibrateRobertson::getMaxIter()
        //

        //javadoc: CalibrateRobertson::getMaxIter()
        public int getMaxIter()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = photo_CalibrateRobertson_getMaxIter_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::CalibrateRobertson::setMaxIter(int max_iter)
        //

        //javadoc: CalibrateRobertson::setMaxIter(max_iter)
        public void setMaxIter(int max_iter)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_CalibrateRobertson_setMaxIter_10(nativeObj, max_iter);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::CalibrateRobertson::setThreshold(float threshold)
        //

        //javadoc: CalibrateRobertson::setThreshold(threshold)
        public void setThreshold(float threshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_CalibrateRobertson_setThreshold_10(nativeObj, threshold);
        
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



        // C++:  Mat cv::CalibrateRobertson::getRadiance()
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_CalibrateRobertson_getRadiance_10(IntPtr nativeObj);

        // C++:  float cv::CalibrateRobertson::getThreshold()
        [DllImport(LIBNAME)]
        private static extern float photo_CalibrateRobertson_getThreshold_10(IntPtr nativeObj);

        // C++:  int cv::CalibrateRobertson::getMaxIter()
        [DllImport(LIBNAME)]
        private static extern int photo_CalibrateRobertson_getMaxIter_10(IntPtr nativeObj);

        // C++:  void cv::CalibrateRobertson::setMaxIter(int max_iter)
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateRobertson_setMaxIter_10(IntPtr nativeObj, int max_iter);

        // C++:  void cv::CalibrateRobertson::setThreshold(float threshold)
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateRobertson_setThreshold_10(IntPtr nativeObj, float threshold);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateRobertson_delete(IntPtr nativeObj);

    }
}
