
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class MergeMertens
    //javadoc: MergeMertens

    public class MergeMertens : MergeExposures
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
                        photo_MergeMertens_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal MergeMertens(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new MergeMertens __fromPtr__(IntPtr addr) { return new MergeMertens(addr); }

        //
        // C++:  float cv::MergeMertens::getContrastWeight()
        //

        //javadoc: MergeMertens::getContrastWeight()
        public float getContrastWeight()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = photo_MergeMertens_getContrastWeight_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::MergeMertens::getExposureWeight()
        //

        //javadoc: MergeMertens::getExposureWeight()
        public float getExposureWeight()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = photo_MergeMertens_getExposureWeight_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::MergeMertens::getSaturationWeight()
        //

        //javadoc: MergeMertens::getSaturationWeight()
        public float getSaturationWeight()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = photo_MergeMertens_getSaturationWeight_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::MergeMertens::process(vector_Mat src, Mat& dst, Mat times, Mat response)
        //

        //javadoc: MergeMertens::process(src, dst, times, response)
        public override void process(List<Mat> src, Mat dst, Mat times, Mat response)
        {
            ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (times != null) times.ThrowIfDisposed();
            if (response != null) response.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat src_mat = Converters.vector_Mat_to_Mat(src);
        photo_MergeMertens_process_10(nativeObj, src_mat.nativeObj, dst.nativeObj, times.nativeObj, response.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::MergeMertens::process(vector_Mat src, Mat& dst)
        //

        //javadoc: MergeMertens::process(src, dst)
        public void process(List<Mat> src, Mat dst)
        {
            ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat src_mat = Converters.vector_Mat_to_Mat(src);
        photo_MergeMertens_process_11(nativeObj, src_mat.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::MergeMertens::setContrastWeight(float contrast_weiht)
        //

        //javadoc: MergeMertens::setContrastWeight(contrast_weiht)
        public void setContrastWeight(float contrast_weiht)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_MergeMertens_setContrastWeight_10(nativeObj, contrast_weiht);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::MergeMertens::setExposureWeight(float exposure_weight)
        //

        //javadoc: MergeMertens::setExposureWeight(exposure_weight)
        public void setExposureWeight(float exposure_weight)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_MergeMertens_setExposureWeight_10(nativeObj, exposure_weight);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::MergeMertens::setSaturationWeight(float saturation_weight)
        //

        //javadoc: MergeMertens::setSaturationWeight(saturation_weight)
        public void setSaturationWeight(float saturation_weight)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_MergeMertens_setSaturationWeight_10(nativeObj, saturation_weight);
        
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



        // C++:  float cv::MergeMertens::getContrastWeight()
        [DllImport(LIBNAME)]
        private static extern float photo_MergeMertens_getContrastWeight_10(IntPtr nativeObj);

        // C++:  float cv::MergeMertens::getExposureWeight()
        [DllImport(LIBNAME)]
        private static extern float photo_MergeMertens_getExposureWeight_10(IntPtr nativeObj);

        // C++:  float cv::MergeMertens::getSaturationWeight()
        [DllImport(LIBNAME)]
        private static extern float photo_MergeMertens_getSaturationWeight_10(IntPtr nativeObj);

        // C++:  void cv::MergeMertens::process(vector_Mat src, Mat& dst, Mat times, Mat response)
        [DllImport(LIBNAME)]
        private static extern void photo_MergeMertens_process_10(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_nativeObj, IntPtr times_nativeObj, IntPtr response_nativeObj);

        // C++:  void cv::MergeMertens::process(vector_Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void photo_MergeMertens_process_11(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::MergeMertens::setContrastWeight(float contrast_weiht)
        [DllImport(LIBNAME)]
        private static extern void photo_MergeMertens_setContrastWeight_10(IntPtr nativeObj, float contrast_weiht);

        // C++:  void cv::MergeMertens::setExposureWeight(float exposure_weight)
        [DllImport(LIBNAME)]
        private static extern void photo_MergeMertens_setExposureWeight_10(IntPtr nativeObj, float exposure_weight);

        // C++:  void cv::MergeMertens::setSaturationWeight(float saturation_weight)
        [DllImport(LIBNAME)]
        private static extern void photo_MergeMertens_setSaturationWeight_10(IntPtr nativeObj, float saturation_weight);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_MergeMertens_delete(IntPtr nativeObj);

    }
}
