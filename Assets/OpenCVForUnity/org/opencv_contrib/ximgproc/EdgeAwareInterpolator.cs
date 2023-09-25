
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class EdgeAwareInterpolator
    //javadoc: EdgeAwareInterpolator

    public class EdgeAwareInterpolator : SparseMatchInterpolator
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
                        ximgproc_EdgeAwareInterpolator_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal EdgeAwareInterpolator(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new EdgeAwareInterpolator __fromPtr__(IntPtr addr) { return new EdgeAwareInterpolator(addr); }

        //
        // C++:  bool cv::ximgproc::EdgeAwareInterpolator::getUsePostProcessing()
        //

        //javadoc: EdgeAwareInterpolator::getUsePostProcessing()
        public bool getUsePostProcessing()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ximgproc_EdgeAwareInterpolator_getUsePostProcessing_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getFGSLambda()
        //

        //javadoc: EdgeAwareInterpolator::getFGSLambda()
        public float getFGSLambda()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeAwareInterpolator_getFGSLambda_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getFGSSigma()
        //

        //javadoc: EdgeAwareInterpolator::getFGSSigma()
        public float getFGSSigma()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeAwareInterpolator_getFGSSigma_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getLambda()
        //

        //javadoc: EdgeAwareInterpolator::getLambda()
        public float getLambda()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeAwareInterpolator_getLambda_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getSigma()
        //

        //javadoc: EdgeAwareInterpolator::getSigma()
        public float getSigma()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeAwareInterpolator_getSigma_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ximgproc::EdgeAwareInterpolator::getK()
        //

        //javadoc: EdgeAwareInterpolator::getK()
        public int getK()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ximgproc_EdgeAwareInterpolator_getK_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setFGSLambda(float _lambda)
        //

        //javadoc: EdgeAwareInterpolator::setFGSLambda(_lambda)
        public void setFGSLambda(float _lambda)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeAwareInterpolator_setFGSLambda_10(nativeObj, _lambda);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setFGSSigma(float _sigma)
        //

        //javadoc: EdgeAwareInterpolator::setFGSSigma(_sigma)
        public void setFGSSigma(float _sigma)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeAwareInterpolator_setFGSSigma_10(nativeObj, _sigma);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setK(int _k)
        //

        //javadoc: EdgeAwareInterpolator::setK(_k)
        public void setK(int _k)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeAwareInterpolator_setK_10(nativeObj, _k);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setLambda(float _lambda)
        //

        //javadoc: EdgeAwareInterpolator::setLambda(_lambda)
        public void setLambda(float _lambda)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeAwareInterpolator_setLambda_10(nativeObj, _lambda);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setSigma(float _sigma)
        //

        //javadoc: EdgeAwareInterpolator::setSigma(_sigma)
        public void setSigma(float _sigma)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeAwareInterpolator_setSigma_10(nativeObj, _sigma);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setUsePostProcessing(bool _use_post_proc)
        //

        //javadoc: EdgeAwareInterpolator::setUsePostProcessing(_use_post_proc)
        public void setUsePostProcessing(bool _use_post_proc)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeAwareInterpolator_setUsePostProcessing_10(nativeObj, _use_post_proc);
        
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



        // C++:  bool cv::ximgproc::EdgeAwareInterpolator::getUsePostProcessing()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ximgproc_EdgeAwareInterpolator_getUsePostProcessing_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getFGSLambda()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeAwareInterpolator_getFGSLambda_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getFGSSigma()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeAwareInterpolator_getFGSSigma_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getLambda()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeAwareInterpolator_getLambda_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeAwareInterpolator::getSigma()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeAwareInterpolator_getSigma_10(IntPtr nativeObj);

        // C++:  int cv::ximgproc::EdgeAwareInterpolator::getK()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_EdgeAwareInterpolator_getK_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setFGSLambda(float _lambda)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_setFGSLambda_10(IntPtr nativeObj, float _lambda);

        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setFGSSigma(float _sigma)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_setFGSSigma_10(IntPtr nativeObj, float _sigma);

        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setK(int _k)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_setK_10(IntPtr nativeObj, int _k);

        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setLambda(float _lambda)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_setLambda_10(IntPtr nativeObj, float _lambda);

        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setSigma(float _sigma)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_setSigma_10(IntPtr nativeObj, float _sigma);

        // C++:  void cv::ximgproc::EdgeAwareInterpolator::setUsePostProcessing(bool _use_post_proc)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_setUsePostProcessing_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool _use_post_proc);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeAwareInterpolator_delete(IntPtr nativeObj);

    }
}
