
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XphotoModule
{

    // C++: class SimpleWB
    //javadoc: SimpleWB

    public class SimpleWB : WhiteBalancer
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
                        xphoto_SimpleWB_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SimpleWB(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SimpleWB __fromPtr__(IntPtr addr) { return new SimpleWB(addr); }

        //
        // C++:  float cv::xphoto::SimpleWB::getInputMax()
        //

        //javadoc: SimpleWB::getInputMax()
        public float getInputMax()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_SimpleWB_getInputMax_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xphoto::SimpleWB::getInputMin()
        //

        //javadoc: SimpleWB::getInputMin()
        public float getInputMin()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_SimpleWB_getInputMin_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xphoto::SimpleWB::getOutputMax()
        //

        //javadoc: SimpleWB::getOutputMax()
        public float getOutputMax()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_SimpleWB_getOutputMax_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xphoto::SimpleWB::getOutputMin()
        //

        //javadoc: SimpleWB::getOutputMin()
        public float getOutputMin()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_SimpleWB_getOutputMin_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xphoto::SimpleWB::getP()
        //

        //javadoc: SimpleWB::getP()
        public float getP()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_SimpleWB_getP_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::xphoto::SimpleWB::setInputMax(float val)
        //

        //javadoc: SimpleWB::setInputMax(val)
        public void setInputMax(float val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_SimpleWB_setInputMax_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xphoto::SimpleWB::setInputMin(float val)
        //

        //javadoc: SimpleWB::setInputMin(val)
        public void setInputMin(float val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_SimpleWB_setInputMin_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xphoto::SimpleWB::setOutputMax(float val)
        //

        //javadoc: SimpleWB::setOutputMax(val)
        public void setOutputMax(float val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_SimpleWB_setOutputMax_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xphoto::SimpleWB::setOutputMin(float val)
        //

        //javadoc: SimpleWB::setOutputMin(val)
        public void setOutputMin(float val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_SimpleWB_setOutputMin_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xphoto::SimpleWB::setP(float val)
        //

        //javadoc: SimpleWB::setP(val)
        public void setP(float val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_SimpleWB_setP_10(nativeObj, val);
        
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



        // C++:  float cv::xphoto::SimpleWB::getInputMax()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getInputMax_10(IntPtr nativeObj);

        // C++:  float cv::xphoto::SimpleWB::getInputMin()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getInputMin_10(IntPtr nativeObj);

        // C++:  float cv::xphoto::SimpleWB::getOutputMax()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getOutputMax_10(IntPtr nativeObj);

        // C++:  float cv::xphoto::SimpleWB::getOutputMin()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getOutputMin_10(IntPtr nativeObj);

        // C++:  float cv::xphoto::SimpleWB::getP()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getP_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::SimpleWB::setInputMax(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setInputMax_10(IntPtr nativeObj, float val);

        // C++:  void cv::xphoto::SimpleWB::setInputMin(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setInputMin_10(IntPtr nativeObj, float val);

        // C++:  void cv::xphoto::SimpleWB::setOutputMax(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setOutputMax_10(IntPtr nativeObj, float val);

        // C++:  void cv::xphoto::SimpleWB::setOutputMin(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setOutputMin_10(IntPtr nativeObj, float val);

        // C++:  void cv::xphoto::SimpleWB::setP(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setP_10(IntPtr nativeObj, float val);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_delete(IntPtr nativeObj);

    }
}
