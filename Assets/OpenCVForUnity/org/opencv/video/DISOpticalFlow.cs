
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class DISOpticalFlow
    //javadoc: DISOpticalFlow

    public class DISOpticalFlow : DenseOpticalFlow
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
                        video_DISOpticalFlow_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DISOpticalFlow(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DISOpticalFlow __fromPtr__(IntPtr addr) { return new DISOpticalFlow(addr); }

        // C++: enum <unnamed>
        public const int PRESET_ULTRAFAST = 0;
        public const int PRESET_FAST = 1;
        public const int PRESET_MEDIUM = 2;
        //
        // C++: static Ptr_DISOpticalFlow cv::DISOpticalFlow::create(int preset = DISOpticalFlow::PRESET_FAST)
        //

        //javadoc: DISOpticalFlow::create(preset)
        public static DISOpticalFlow create(int preset)
        {
#if UNITY_5_3_OR_NEWER
        
        DISOpticalFlow retVal = DISOpticalFlow.__fromPtr__(video_DISOpticalFlow_create_10(preset));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DISOpticalFlow::create()
        public static DISOpticalFlow create()
        {
#if UNITY_5_3_OR_NEWER
        
        DISOpticalFlow retVal = DISOpticalFlow.__fromPtr__(video_DISOpticalFlow_create_11());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::DISOpticalFlow::getUseMeanNormalization()
        //

        //javadoc: DISOpticalFlow::getUseMeanNormalization()
        public bool getUseMeanNormalization()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = video_DISOpticalFlow_getUseMeanNormalization_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::DISOpticalFlow::getUseSpatialPropagation()
        //

        //javadoc: DISOpticalFlow::getUseSpatialPropagation()
        public bool getUseSpatialPropagation()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = video_DISOpticalFlow_getUseSpatialPropagation_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  float cv::DISOpticalFlow::getVariationalRefinementAlpha()
        //

        //javadoc: DISOpticalFlow::getVariationalRefinementAlpha()
        public float getVariationalRefinementAlpha()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = video_DISOpticalFlow_getVariationalRefinementAlpha_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::DISOpticalFlow::getVariationalRefinementDelta()
        //

        //javadoc: DISOpticalFlow::getVariationalRefinementDelta()
        public float getVariationalRefinementDelta()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = video_DISOpticalFlow_getVariationalRefinementDelta_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::DISOpticalFlow::getVariationalRefinementGamma()
        //

        //javadoc: DISOpticalFlow::getVariationalRefinementGamma()
        public float getVariationalRefinementGamma()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = video_DISOpticalFlow_getVariationalRefinementGamma_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::DISOpticalFlow::getFinestScale()
        //

        //javadoc: DISOpticalFlow::getFinestScale()
        public int getFinestScale()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_DISOpticalFlow_getFinestScale_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::DISOpticalFlow::getGradientDescentIterations()
        //

        //javadoc: DISOpticalFlow::getGradientDescentIterations()
        public int getGradientDescentIterations()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_DISOpticalFlow_getGradientDescentIterations_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::DISOpticalFlow::getPatchSize()
        //

        //javadoc: DISOpticalFlow::getPatchSize()
        public int getPatchSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_DISOpticalFlow_getPatchSize_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::DISOpticalFlow::getPatchStride()
        //

        //javadoc: DISOpticalFlow::getPatchStride()
        public int getPatchStride()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_DISOpticalFlow_getPatchStride_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::DISOpticalFlow::getVariationalRefinementIterations()
        //

        //javadoc: DISOpticalFlow::getVariationalRefinementIterations()
        public int getVariationalRefinementIterations()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = video_DISOpticalFlow_getVariationalRefinementIterations_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::DISOpticalFlow::setFinestScale(int val)
        //

        //javadoc: DISOpticalFlow::setFinestScale(val)
        public void setFinestScale(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_DISOpticalFlow_setFinestScale_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DISOpticalFlow::setGradientDescentIterations(int val)
        //

        //javadoc: DISOpticalFlow::setGradientDescentIterations(val)
        public void setGradientDescentIterations(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_DISOpticalFlow_setGradientDescentIterations_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DISOpticalFlow::setPatchSize(int val)
        //

        //javadoc: DISOpticalFlow::setPatchSize(val)
        public void setPatchSize(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_DISOpticalFlow_setPatchSize_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DISOpticalFlow::setPatchStride(int val)
        //

        //javadoc: DISOpticalFlow::setPatchStride(val)
        public void setPatchStride(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_DISOpticalFlow_setPatchStride_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DISOpticalFlow::setUseMeanNormalization(bool val)
        //

        //javadoc: DISOpticalFlow::setUseMeanNormalization(val)
        public void setUseMeanNormalization(bool val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_DISOpticalFlow_setUseMeanNormalization_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DISOpticalFlow::setUseSpatialPropagation(bool val)
        //

        //javadoc: DISOpticalFlow::setUseSpatialPropagation(val)
        public void setUseSpatialPropagation(bool val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_DISOpticalFlow_setUseSpatialPropagation_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DISOpticalFlow::setVariationalRefinementAlpha(float val)
        //

        //javadoc: DISOpticalFlow::setVariationalRefinementAlpha(val)
        public void setVariationalRefinementAlpha(float val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_DISOpticalFlow_setVariationalRefinementAlpha_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DISOpticalFlow::setVariationalRefinementDelta(float val)
        //

        //javadoc: DISOpticalFlow::setVariationalRefinementDelta(val)
        public void setVariationalRefinementDelta(float val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_DISOpticalFlow_setVariationalRefinementDelta_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DISOpticalFlow::setVariationalRefinementGamma(float val)
        //

        //javadoc: DISOpticalFlow::setVariationalRefinementGamma(val)
        public void setVariationalRefinementGamma(float val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_DISOpticalFlow_setVariationalRefinementGamma_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DISOpticalFlow::setVariationalRefinementIterations(int val)
        //

        //javadoc: DISOpticalFlow::setVariationalRefinementIterations(val)
        public void setVariationalRefinementIterations(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        video_DISOpticalFlow_setVariationalRefinementIterations_10(nativeObj, val);
        
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



        // C++: static Ptr_DISOpticalFlow cv::DISOpticalFlow::create(int preset = DISOpticalFlow::PRESET_FAST)
        [DllImport(LIBNAME)]
        private static extern IntPtr video_DISOpticalFlow_create_10(int preset);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_DISOpticalFlow_create_11();

        // C++:  bool cv::DISOpticalFlow::getUseMeanNormalization()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool video_DISOpticalFlow_getUseMeanNormalization_10(IntPtr nativeObj);

        // C++:  bool cv::DISOpticalFlow::getUseSpatialPropagation()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool video_DISOpticalFlow_getUseSpatialPropagation_10(IntPtr nativeObj);

        // C++:  float cv::DISOpticalFlow::getVariationalRefinementAlpha()
        [DllImport(LIBNAME)]
        private static extern float video_DISOpticalFlow_getVariationalRefinementAlpha_10(IntPtr nativeObj);

        // C++:  float cv::DISOpticalFlow::getVariationalRefinementDelta()
        [DllImport(LIBNAME)]
        private static extern float video_DISOpticalFlow_getVariationalRefinementDelta_10(IntPtr nativeObj);

        // C++:  float cv::DISOpticalFlow::getVariationalRefinementGamma()
        [DllImport(LIBNAME)]
        private static extern float video_DISOpticalFlow_getVariationalRefinementGamma_10(IntPtr nativeObj);

        // C++:  int cv::DISOpticalFlow::getFinestScale()
        [DllImport(LIBNAME)]
        private static extern int video_DISOpticalFlow_getFinestScale_10(IntPtr nativeObj);

        // C++:  int cv::DISOpticalFlow::getGradientDescentIterations()
        [DllImport(LIBNAME)]
        private static extern int video_DISOpticalFlow_getGradientDescentIterations_10(IntPtr nativeObj);

        // C++:  int cv::DISOpticalFlow::getPatchSize()
        [DllImport(LIBNAME)]
        private static extern int video_DISOpticalFlow_getPatchSize_10(IntPtr nativeObj);

        // C++:  int cv::DISOpticalFlow::getPatchStride()
        [DllImport(LIBNAME)]
        private static extern int video_DISOpticalFlow_getPatchStride_10(IntPtr nativeObj);

        // C++:  int cv::DISOpticalFlow::getVariationalRefinementIterations()
        [DllImport(LIBNAME)]
        private static extern int video_DISOpticalFlow_getVariationalRefinementIterations_10(IntPtr nativeObj);

        // C++:  void cv::DISOpticalFlow::setFinestScale(int val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setFinestScale_10(IntPtr nativeObj, int val);

        // C++:  void cv::DISOpticalFlow::setGradientDescentIterations(int val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setGradientDescentIterations_10(IntPtr nativeObj, int val);

        // C++:  void cv::DISOpticalFlow::setPatchSize(int val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setPatchSize_10(IntPtr nativeObj, int val);

        // C++:  void cv::DISOpticalFlow::setPatchStride(int val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setPatchStride_10(IntPtr nativeObj, int val);

        // C++:  void cv::DISOpticalFlow::setUseMeanNormalization(bool val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setUseMeanNormalization_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  void cv::DISOpticalFlow::setUseSpatialPropagation(bool val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setUseSpatialPropagation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  void cv::DISOpticalFlow::setVariationalRefinementAlpha(float val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setVariationalRefinementAlpha_10(IntPtr nativeObj, float val);

        // C++:  void cv::DISOpticalFlow::setVariationalRefinementDelta(float val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setVariationalRefinementDelta_10(IntPtr nativeObj, float val);

        // C++:  void cv::DISOpticalFlow::setVariationalRefinementGamma(float val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setVariationalRefinementGamma_10(IntPtr nativeObj, float val);

        // C++:  void cv::DISOpticalFlow::setVariationalRefinementIterations(int val)
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_setVariationalRefinementIterations_10(IntPtr nativeObj, int val);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_DISOpticalFlow_delete(IntPtr nativeObj);

    }
}
