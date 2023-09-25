
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Img_hashModule
{

    // C++: class ImgHashBase
    //javadoc: ImgHashBase

    public class ImgHashBase : Algorithm
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
                        img_1hash_ImgHashBase_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal ImgHashBase(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new ImgHashBase __fromPtr__(IntPtr addr) { return new ImgHashBase(addr); }

        //
        // C++:  double cv::img_hash::ImgHashBase::compare(Mat hashOne, Mat hashTwo)
        //

        //javadoc: ImgHashBase::compare(hashOne, hashTwo)
        public double compare(Mat hashOne, Mat hashTwo)
        {
            ThrowIfDisposed();
            if (hashOne != null) hashOne.ThrowIfDisposed();
            if (hashTwo != null) hashTwo.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = img_1hash_ImgHashBase_compare_10(nativeObj, hashOne.nativeObj, hashTwo.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::img_hash::ImgHashBase::compute(Mat inputArr, Mat& outputArr)
        //

        //javadoc: ImgHashBase::compute(inputArr, outputArr)
        public void compute(Mat inputArr, Mat outputArr)
        {
            ThrowIfDisposed();
            if (inputArr != null) inputArr.ThrowIfDisposed();
            if (outputArr != null) outputArr.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_ImgHashBase_compute_10(nativeObj, inputArr.nativeObj, outputArr.nativeObj);
        
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



        // C++:  double cv::img_hash::ImgHashBase::compare(Mat hashOne, Mat hashTwo)
        [DllImport(LIBNAME)]
        private static extern double img_1hash_ImgHashBase_compare_10(IntPtr nativeObj, IntPtr hashOne_nativeObj, IntPtr hashTwo_nativeObj);

        // C++:  void cv::img_hash::ImgHashBase::compute(Mat inputArr, Mat& outputArr)
        [DllImport(LIBNAME)]
        private static extern void img_1hash_ImgHashBase_compute_10(IntPtr nativeObj, IntPtr inputArr_nativeObj, IntPtr outputArr_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void img_1hash_ImgHashBase_delete(IntPtr nativeObj);

    }
}
