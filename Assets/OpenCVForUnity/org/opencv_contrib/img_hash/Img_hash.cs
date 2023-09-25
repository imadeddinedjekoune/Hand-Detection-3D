
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Img_hashModule
{
    // C++: class Img_hash
    //javadoc: Img_hash

    public class Img_hash
    {

        // C++: enum BlockMeanHashMode
        public const int BLOCK_MEAN_HASH_MODE_0 = 0;
        public const int BLOCK_MEAN_HASH_MODE_1 = 1;
        //
        // C++:  void cv::img_hash::averageHash(Mat inputArr, Mat& outputArr)
        //

        //javadoc: averageHash(inputArr, outputArr)
        public static void averageHash(Mat inputArr, Mat outputArr)
        {
            if (inputArr != null) inputArr.ThrowIfDisposed();
            if (outputArr != null) outputArr.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_Img_1hash_averageHash_10(inputArr.nativeObj, outputArr.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::img_hash::blockMeanHash(Mat inputArr, Mat& outputArr, int mode = BLOCK_MEAN_HASH_MODE_0)
        //

        //javadoc: blockMeanHash(inputArr, outputArr, mode)
        public static void blockMeanHash(Mat inputArr, Mat outputArr, int mode)
        {
            if (inputArr != null) inputArr.ThrowIfDisposed();
            if (outputArr != null) outputArr.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_Img_1hash_blockMeanHash_10(inputArr.nativeObj, outputArr.nativeObj, mode);
        
        return;
#else
            return;
#endif
        }

        //javadoc: blockMeanHash(inputArr, outputArr)
        public static void blockMeanHash(Mat inputArr, Mat outputArr)
        {
            if (inputArr != null) inputArr.ThrowIfDisposed();
            if (outputArr != null) outputArr.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_Img_1hash_blockMeanHash_11(inputArr.nativeObj, outputArr.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::img_hash::colorMomentHash(Mat inputArr, Mat& outputArr)
        //

        //javadoc: colorMomentHash(inputArr, outputArr)
        public static void colorMomentHash(Mat inputArr, Mat outputArr)
        {
            if (inputArr != null) inputArr.ThrowIfDisposed();
            if (outputArr != null) outputArr.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_Img_1hash_colorMomentHash_10(inputArr.nativeObj, outputArr.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::img_hash::marrHildrethHash(Mat inputArr, Mat& outputArr, float alpha = 2.0f, float scale = 1.0f)
        //

        //javadoc: marrHildrethHash(inputArr, outputArr, alpha, scale)
        public static void marrHildrethHash(Mat inputArr, Mat outputArr, float alpha, float scale)
        {
            if (inputArr != null) inputArr.ThrowIfDisposed();
            if (outputArr != null) outputArr.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_Img_1hash_marrHildrethHash_10(inputArr.nativeObj, outputArr.nativeObj, alpha, scale);
        
        return;
#else
            return;
#endif
        }

        //javadoc: marrHildrethHash(inputArr, outputArr, alpha)
        public static void marrHildrethHash(Mat inputArr, Mat outputArr, float alpha)
        {
            if (inputArr != null) inputArr.ThrowIfDisposed();
            if (outputArr != null) outputArr.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_Img_1hash_marrHildrethHash_11(inputArr.nativeObj, outputArr.nativeObj, alpha);
        
        return;
#else
            return;
#endif
        }

        //javadoc: marrHildrethHash(inputArr, outputArr)
        public static void marrHildrethHash(Mat inputArr, Mat outputArr)
        {
            if (inputArr != null) inputArr.ThrowIfDisposed();
            if (outputArr != null) outputArr.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_Img_1hash_marrHildrethHash_12(inputArr.nativeObj, outputArr.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::img_hash::pHash(Mat inputArr, Mat& outputArr)
        //

        //javadoc: pHash(inputArr, outputArr)
        public static void pHash(Mat inputArr, Mat outputArr)
        {
            if (inputArr != null) inputArr.ThrowIfDisposed();
            if (outputArr != null) outputArr.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_Img_1hash_pHash_10(inputArr.nativeObj, outputArr.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::img_hash::radialVarianceHash(Mat inputArr, Mat& outputArr, double sigma = 1, int numOfAngleLine = 180)
        //

        //javadoc: radialVarianceHash(inputArr, outputArr, sigma, numOfAngleLine)
        public static void radialVarianceHash(Mat inputArr, Mat outputArr, double sigma, int numOfAngleLine)
        {
            if (inputArr != null) inputArr.ThrowIfDisposed();
            if (outputArr != null) outputArr.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_Img_1hash_radialVarianceHash_10(inputArr.nativeObj, outputArr.nativeObj, sigma, numOfAngleLine);
        
        return;
#else
            return;
#endif
        }

        //javadoc: radialVarianceHash(inputArr, outputArr, sigma)
        public static void radialVarianceHash(Mat inputArr, Mat outputArr, double sigma)
        {
            if (inputArr != null) inputArr.ThrowIfDisposed();
            if (outputArr != null) outputArr.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_Img_1hash_radialVarianceHash_11(inputArr.nativeObj, outputArr.nativeObj, sigma);
        
        return;
#else
            return;
#endif
        }

        //javadoc: radialVarianceHash(inputArr, outputArr)
        public static void radialVarianceHash(Mat inputArr, Mat outputArr)
        {
            if (inputArr != null) inputArr.ThrowIfDisposed();
            if (outputArr != null) outputArr.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        img_1hash_Img_1hash_radialVarianceHash_12(inputArr.nativeObj, outputArr.nativeObj);
        
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



        // C++:  void cv::img_hash::averageHash(Mat inputArr, Mat& outputArr)
        [DllImport(LIBNAME)]
        private static extern void img_1hash_Img_1hash_averageHash_10(IntPtr inputArr_nativeObj, IntPtr outputArr_nativeObj);

        // C++:  void cv::img_hash::blockMeanHash(Mat inputArr, Mat& outputArr, int mode = BLOCK_MEAN_HASH_MODE_0)
        [DllImport(LIBNAME)]
        private static extern void img_1hash_Img_1hash_blockMeanHash_10(IntPtr inputArr_nativeObj, IntPtr outputArr_nativeObj, int mode);
        [DllImport(LIBNAME)]
        private static extern void img_1hash_Img_1hash_blockMeanHash_11(IntPtr inputArr_nativeObj, IntPtr outputArr_nativeObj);

        // C++:  void cv::img_hash::colorMomentHash(Mat inputArr, Mat& outputArr)
        [DllImport(LIBNAME)]
        private static extern void img_1hash_Img_1hash_colorMomentHash_10(IntPtr inputArr_nativeObj, IntPtr outputArr_nativeObj);

        // C++:  void cv::img_hash::marrHildrethHash(Mat inputArr, Mat& outputArr, float alpha = 2.0f, float scale = 1.0f)
        [DllImport(LIBNAME)]
        private static extern void img_1hash_Img_1hash_marrHildrethHash_10(IntPtr inputArr_nativeObj, IntPtr outputArr_nativeObj, float alpha, float scale);
        [DllImport(LIBNAME)]
        private static extern void img_1hash_Img_1hash_marrHildrethHash_11(IntPtr inputArr_nativeObj, IntPtr outputArr_nativeObj, float alpha);
        [DllImport(LIBNAME)]
        private static extern void img_1hash_Img_1hash_marrHildrethHash_12(IntPtr inputArr_nativeObj, IntPtr outputArr_nativeObj);

        // C++:  void cv::img_hash::pHash(Mat inputArr, Mat& outputArr)
        [DllImport(LIBNAME)]
        private static extern void img_1hash_Img_1hash_pHash_10(IntPtr inputArr_nativeObj, IntPtr outputArr_nativeObj);

        // C++:  void cv::img_hash::radialVarianceHash(Mat inputArr, Mat& outputArr, double sigma = 1, int numOfAngleLine = 180)
        [DllImport(LIBNAME)]
        private static extern void img_1hash_Img_1hash_radialVarianceHash_10(IntPtr inputArr_nativeObj, IntPtr outputArr_nativeObj, double sigma, int numOfAngleLine);
        [DllImport(LIBNAME)]
        private static extern void img_1hash_Img_1hash_radialVarianceHash_11(IntPtr inputArr_nativeObj, IntPtr outputArr_nativeObj, double sigma);
        [DllImport(LIBNAME)]
        private static extern void img_1hash_Img_1hash_radialVarianceHash_12(IntPtr inputArr_nativeObj, IntPtr outputArr_nativeObj);

    }
}
