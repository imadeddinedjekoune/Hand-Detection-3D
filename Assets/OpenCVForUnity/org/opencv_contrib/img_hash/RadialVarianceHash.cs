
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Img_hashModule
{

    // C++: class RadialVarianceHash
    //javadoc: RadialVarianceHash

    public class RadialVarianceHash : ImgHashBase
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
                        img_1hash_RadialVarianceHash_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal RadialVarianceHash(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new RadialVarianceHash __fromPtr__(IntPtr addr) { return new RadialVarianceHash(addr); }

        //
        // C++: static Ptr_RadialVarianceHash cv::img_hash::RadialVarianceHash::create(double sigma = 1, int numOfAngleLine = 180)
        //

        //javadoc: RadialVarianceHash::create(sigma, numOfAngleLine)
        public static RadialVarianceHash create(double sigma, int numOfAngleLine)
        {
#if UNITY_5_3_OR_NEWER
        
        RadialVarianceHash retVal = RadialVarianceHash.__fromPtr__(img_1hash_RadialVarianceHash_create_10(sigma, numOfAngleLine));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RadialVarianceHash::create(sigma)
        public static RadialVarianceHash create(double sigma)
        {
#if UNITY_5_3_OR_NEWER
        
        RadialVarianceHash retVal = RadialVarianceHash.__fromPtr__(img_1hash_RadialVarianceHash_create_11(sigma));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: RadialVarianceHash::create()
        public static RadialVarianceHash create()
        {
#if UNITY_5_3_OR_NEWER
        
        RadialVarianceHash retVal = RadialVarianceHash.__fromPtr__(img_1hash_RadialVarianceHash_create_12());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  double cv::img_hash::RadialVarianceHash::getSigma()
        //

        //javadoc: RadialVarianceHash::getSigma()
        public double getSigma()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = img_1hash_RadialVarianceHash_getSigma_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::img_hash::RadialVarianceHash::getNumOfAngleLine()
        //

        //javadoc: RadialVarianceHash::getNumOfAngleLine()
        public int getNumOfAngleLine()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = img_1hash_RadialVarianceHash_getNumOfAngleLine_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::img_hash::RadialVarianceHash::setNumOfAngleLine(int value)
        //

        //javadoc: RadialVarianceHash::setNumOfAngleLine(value)
        public void setNumOfAngleLine(int value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_RadialVarianceHash_setNumOfAngleLine_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::img_hash::RadialVarianceHash::setSigma(double value)
        //

        //javadoc: RadialVarianceHash::setSigma(value)
        public void setSigma(double value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_RadialVarianceHash_setSigma_10(nativeObj, value);
        
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



        // C++: static Ptr_RadialVarianceHash cv::img_hash::RadialVarianceHash::create(double sigma = 1, int numOfAngleLine = 180)
        [DllImport(LIBNAME)]
        private static extern IntPtr img_1hash_RadialVarianceHash_create_10(double sigma, int numOfAngleLine);
        [DllImport(LIBNAME)]
        private static extern IntPtr img_1hash_RadialVarianceHash_create_11(double sigma);
        [DllImport(LIBNAME)]
        private static extern IntPtr img_1hash_RadialVarianceHash_create_12();

        // C++:  double cv::img_hash::RadialVarianceHash::getSigma()
        [DllImport(LIBNAME)]
        private static extern double img_1hash_RadialVarianceHash_getSigma_10(IntPtr nativeObj);

        // C++:  int cv::img_hash::RadialVarianceHash::getNumOfAngleLine()
        [DllImport(LIBNAME)]
        private static extern int img_1hash_RadialVarianceHash_getNumOfAngleLine_10(IntPtr nativeObj);

        // C++:  void cv::img_hash::RadialVarianceHash::setNumOfAngleLine(int value)
        [DllImport(LIBNAME)]
        private static extern void img_1hash_RadialVarianceHash_setNumOfAngleLine_10(IntPtr nativeObj, int value);

        // C++:  void cv::img_hash::RadialVarianceHash::setSigma(double value)
        [DllImport(LIBNAME)]
        private static extern void img_1hash_RadialVarianceHash_setSigma_10(IntPtr nativeObj, double value);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void img_1hash_RadialVarianceHash_delete(IntPtr nativeObj);

    }
}
