
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class CalibrateDebevec
    //javadoc: CalibrateDebevec

    public class CalibrateDebevec : CalibrateCRF
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
                        photo_CalibrateDebevec_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal CalibrateDebevec(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new CalibrateDebevec __fromPtr__(IntPtr addr) { return new CalibrateDebevec(addr); }

        //
        // C++:  bool cv::CalibrateDebevec::getRandom()
        //

        //javadoc: CalibrateDebevec::getRandom()
        public bool getRandom()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = photo_CalibrateDebevec_getRandom_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  float cv::CalibrateDebevec::getLambda()
        //

        //javadoc: CalibrateDebevec::getLambda()
        public float getLambda()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = photo_CalibrateDebevec_getLambda_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::CalibrateDebevec::getSamples()
        //

        //javadoc: CalibrateDebevec::getSamples()
        public int getSamples()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = photo_CalibrateDebevec_getSamples_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::CalibrateDebevec::setLambda(float lambda)
        //

        //javadoc: CalibrateDebevec::setLambda(lambda)
        public void setLambda(float lambda)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_CalibrateDebevec_setLambda_10(nativeObj, lambda);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::CalibrateDebevec::setRandom(bool random)
        //

        //javadoc: CalibrateDebevec::setRandom(random)
        public void setRandom(bool random)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_CalibrateDebevec_setRandom_10(nativeObj, random);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::CalibrateDebevec::setSamples(int samples)
        //

        //javadoc: CalibrateDebevec::setSamples(samples)
        public void setSamples(int samples)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_CalibrateDebevec_setSamples_10(nativeObj, samples);
        
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



        // C++:  bool cv::CalibrateDebevec::getRandom()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool photo_CalibrateDebevec_getRandom_10(IntPtr nativeObj);

        // C++:  float cv::CalibrateDebevec::getLambda()
        [DllImport(LIBNAME)]
        private static extern float photo_CalibrateDebevec_getLambda_10(IntPtr nativeObj);

        // C++:  int cv::CalibrateDebevec::getSamples()
        [DllImport(LIBNAME)]
        private static extern int photo_CalibrateDebevec_getSamples_10(IntPtr nativeObj);

        // C++:  void cv::CalibrateDebevec::setLambda(float lambda)
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateDebevec_setLambda_10(IntPtr nativeObj, float lambda);

        // C++:  void cv::CalibrateDebevec::setRandom(bool random)
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateDebevec_setRandom_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool random);

        // C++:  void cv::CalibrateDebevec::setSamples(int samples)
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateDebevec_setSamples_10(IntPtr nativeObj, int samples);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateDebevec_delete(IntPtr nativeObj);

    }
}
