
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XphotoModule
{

    // C++: class GrayworldWB
    //javadoc: GrayworldWB

    public class GrayworldWB : WhiteBalancer
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
                        xphoto_GrayworldWB_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GrayworldWB(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GrayworldWB __fromPtr__(IntPtr addr) { return new GrayworldWB(addr); }

        //
        // C++:  float cv::xphoto::GrayworldWB::getSaturationThreshold()
        //

        //javadoc: GrayworldWB::getSaturationThreshold()
        public float getSaturationThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_GrayworldWB_getSaturationThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::xphoto::GrayworldWB::setSaturationThreshold(float val)
        //

        //javadoc: GrayworldWB::setSaturationThreshold(val)
        public void setSaturationThreshold(float val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_GrayworldWB_setSaturationThreshold_10(nativeObj, val);
        
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



        // C++:  float cv::xphoto::GrayworldWB::getSaturationThreshold()
        [DllImport(LIBNAME)]
        private static extern float xphoto_GrayworldWB_getSaturationThreshold_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::GrayworldWB::setSaturationThreshold(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_GrayworldWB_setSaturationThreshold_10(IntPtr nativeObj, float val);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xphoto_GrayworldWB_delete(IntPtr nativeObj);

    }
}
