
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XphotoModule
{
    // C++: class Xphoto
    //javadoc: Xphoto

    public class Xphoto
    {

        // C++: enum InpaintTypes
        public const int INPAINT_SHIFTMAP = 0;
        // C++: enum TransformTypes
        public const int HAAR = 0;
        // C++: enum Bm3dSteps
        public const int BM3D_STEPALL = 0;
        public const int BM3D_STEP1 = 1;
        public const int BM3D_STEP2 = 2;
        //
        // C++:  Ptr_GrayworldWB cv::xphoto::createGrayworldWB()
        //

        //javadoc: createGrayworldWB()
        public static GrayworldWB createGrayworldWB()
        {
#if UNITY_5_3_OR_NEWER
        
        GrayworldWB retVal = GrayworldWB.__fromPtr__(xphoto_Xphoto_createGrayworldWB_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_LearningBasedWB cv::xphoto::createLearningBasedWB(String path_to_model = String())
        //

        //javadoc: createLearningBasedWB(path_to_model)
        public static LearningBasedWB createLearningBasedWB(string path_to_model)
        {
#if UNITY_5_3_OR_NEWER
        
        LearningBasedWB retVal = LearningBasedWB.__fromPtr__(xphoto_Xphoto_createLearningBasedWB_10(path_to_model));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createLearningBasedWB()
        public static LearningBasedWB createLearningBasedWB()
        {
#if UNITY_5_3_OR_NEWER
        
        LearningBasedWB retVal = LearningBasedWB.__fromPtr__(xphoto_Xphoto_createLearningBasedWB_11());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SimpleWB cv::xphoto::createSimpleWB()
        //

        //javadoc: createSimpleWB()
        public static SimpleWB createSimpleWB()
        {
#if UNITY_5_3_OR_NEWER
        
        SimpleWB retVal = SimpleWB.__fromPtr__(xphoto_Xphoto_createSimpleWB_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_TonemapDurand cv::xphoto::createTonemapDurand(float gamma = 1.0f, float contrast = 4.0f, float saturation = 1.0f, float sigma_space = 2.0f, float sigma_color = 2.0f)
        //

        //javadoc: createTonemapDurand(gamma, contrast, saturation, sigma_space, sigma_color)
        public static TonemapDurand createTonemapDurand(float gamma, float contrast, float saturation, float sigma_space, float sigma_color)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapDurand retVal = TonemapDurand.__fromPtr__(xphoto_Xphoto_createTonemapDurand_10(gamma, contrast, saturation, sigma_space, sigma_color));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapDurand(gamma, contrast, saturation, sigma_space)
        public static TonemapDurand createTonemapDurand(float gamma, float contrast, float saturation, float sigma_space)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapDurand retVal = TonemapDurand.__fromPtr__(xphoto_Xphoto_createTonemapDurand_11(gamma, contrast, saturation, sigma_space));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapDurand(gamma, contrast, saturation)
        public static TonemapDurand createTonemapDurand(float gamma, float contrast, float saturation)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapDurand retVal = TonemapDurand.__fromPtr__(xphoto_Xphoto_createTonemapDurand_12(gamma, contrast, saturation));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapDurand(gamma, contrast)
        public static TonemapDurand createTonemapDurand(float gamma, float contrast)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapDurand retVal = TonemapDurand.__fromPtr__(xphoto_Xphoto_createTonemapDurand_13(gamma, contrast));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapDurand(gamma)
        public static TonemapDurand createTonemapDurand(float gamma)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapDurand retVal = TonemapDurand.__fromPtr__(xphoto_Xphoto_createTonemapDurand_14(gamma));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapDurand()
        public static TonemapDurand createTonemapDurand()
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapDurand retVal = TonemapDurand.__fromPtr__(xphoto_Xphoto_createTonemapDurand_15());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::xphoto::applyChannelGains(Mat src, Mat& dst, float gainB, float gainG, float gainR)
        //

        //javadoc: applyChannelGains(src, dst, gainB, gainG, gainR)
        public static void applyChannelGains(Mat src, Mat dst, float gainB, float gainG, float gainR)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_applyChannelGains_10(src.nativeObj, dst.nativeObj, gainB, gainG, gainR);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xphoto::bm3dDenoising(Mat src, Mat& dst, float h = 1, int templateWindowSize = 4, int searchWindowSize = 16, int blockMatchingStep1 = 2500, int blockMatchingStep2 = 400, int groupSize = 8, int slidingStep = 1, float beta = 2.0f, int normType = cv::NORM_L2, int step = cv::xphoto::BM3D_STEPALL, int transformType = cv::xphoto::HAAR)
        //

        //javadoc: bm3dDenoising(src, dst, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType, step, transformType)
        public static void bm3dDenoising(Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType, int step, int transformType)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_10(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType, step, transformType);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dst, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType, step)
        public static void bm3dDenoising(Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType, int step)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_11(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType, step);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dst, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType)
        public static void bm3dDenoising(Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_12(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dst, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta)
        public static void bm3dDenoising(Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_13(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dst, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep)
        public static void bm3dDenoising(Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_14(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dst, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize)
        public static void bm3dDenoising(Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_15(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dst, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2)
        public static void bm3dDenoising(Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_16(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dst, h, templateWindowSize, searchWindowSize, blockMatchingStep1)
        public static void bm3dDenoising(Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_17(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dst, h, templateWindowSize, searchWindowSize)
        public static void bm3dDenoising(Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_18(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dst, h, templateWindowSize)
        public static void bm3dDenoising(Mat src, Mat dst, float h, int templateWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_19(src.nativeObj, dst.nativeObj, h, templateWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dst, h)
        public static void bm3dDenoising(Mat src, Mat dst, float h)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_110(src.nativeObj, dst.nativeObj, h);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dst)
        public static void bm3dDenoising(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_111(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xphoto::bm3dDenoising(Mat src, Mat& dstStep1, Mat& dstStep2, float h = 1, int templateWindowSize = 4, int searchWindowSize = 16, int blockMatchingStep1 = 2500, int blockMatchingStep2 = 400, int groupSize = 8, int slidingStep = 1, float beta = 2.0f, int normType = cv::NORM_L2, int step = cv::xphoto::BM3D_STEPALL, int transformType = cv::xphoto::HAAR)
        //

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType, step, transformType)
        public static void bm3dDenoising(Mat src, Mat dstStep1, Mat dstStep2, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType, int step, int transformType)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_112(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType, step, transformType);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType, step)
        public static void bm3dDenoising(Mat src, Mat dstStep1, Mat dstStep2, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType, int step)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_113(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType, step);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType)
        public static void bm3dDenoising(Mat src, Mat dstStep1, Mat dstStep2, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_114(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta)
        public static void bm3dDenoising(Mat src, Mat dstStep1, Mat dstStep2, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_115(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep)
        public static void bm3dDenoising(Mat src, Mat dstStep1, Mat dstStep2, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_116(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize)
        public static void bm3dDenoising(Mat src, Mat dstStep1, Mat dstStep2, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_117(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2)
        public static void bm3dDenoising(Mat src, Mat dstStep1, Mat dstStep2, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_118(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2, h, templateWindowSize, searchWindowSize, blockMatchingStep1)
        public static void bm3dDenoising(Mat src, Mat dstStep1, Mat dstStep2, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_119(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2, h, templateWindowSize, searchWindowSize)
        public static void bm3dDenoising(Mat src, Mat dstStep1, Mat dstStep2, float h, int templateWindowSize, int searchWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_120(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj, h, templateWindowSize, searchWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2, h, templateWindowSize)
        public static void bm3dDenoising(Mat src, Mat dstStep1, Mat dstStep2, float h, int templateWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_121(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj, h, templateWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2, h)
        public static void bm3dDenoising(Mat src, Mat dstStep1, Mat dstStep2, float h)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_122(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj, h);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2)
        public static void bm3dDenoising(Mat src, Mat dstStep1, Mat dstStep2)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_123(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xphoto::dctDenoising(Mat src, Mat dst, double sigma, int psize = 16)
        //

        //javadoc: dctDenoising(src, dst, sigma, psize)
        public static void dctDenoising(Mat src, Mat dst, double sigma, int psize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_dctDenoising_10(src.nativeObj, dst.nativeObj, sigma, psize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: dctDenoising(src, dst, sigma)
        public static void dctDenoising(Mat src, Mat dst, double sigma)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_dctDenoising_11(src.nativeObj, dst.nativeObj, sigma);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xphoto::inpaint(Mat src, Mat mask, Mat dst, int algorithmType)
        //

        //javadoc: inpaint(src, mask, dst, algorithmType)
        public static void inpaint(Mat src, Mat mask, Mat dst, int algorithmType)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_inpaint_10(src.nativeObj, mask.nativeObj, dst.nativeObj, algorithmType);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xphoto::oilPainting(Mat src, Mat& dst, int size, int dynRatio, int code)
        //

        //javadoc: oilPainting(src, dst, size, dynRatio, code)
        public static void oilPainting(Mat src, Mat dst, int size, int dynRatio, int code)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_oilPainting_10(src.nativeObj, dst.nativeObj, size, dynRatio, code);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xphoto::oilPainting(Mat src, Mat& dst, int size, int dynRatio)
        //

        //javadoc: oilPainting(src, dst, size, dynRatio)
        public static void oilPainting(Mat src, Mat dst, int size, int dynRatio)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_oilPainting_11(src.nativeObj, dst.nativeObj, size, dynRatio);
        
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



        // C++:  Ptr_GrayworldWB cv::xphoto::createGrayworldWB()
        [DllImport(LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createGrayworldWB_10();

        // C++:  Ptr_LearningBasedWB cv::xphoto::createLearningBasedWB(String path_to_model = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createLearningBasedWB_10(string path_to_model);
        [DllImport(LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createLearningBasedWB_11();

        // C++:  Ptr_SimpleWB cv::xphoto::createSimpleWB()
        [DllImport(LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createSimpleWB_10();

        // C++:  Ptr_TonemapDurand cv::xphoto::createTonemapDurand(float gamma = 1.0f, float contrast = 4.0f, float saturation = 1.0f, float sigma_space = 2.0f, float sigma_color = 2.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createTonemapDurand_10(float gamma, float contrast, float saturation, float sigma_space, float sigma_color);
        [DllImport(LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createTonemapDurand_11(float gamma, float contrast, float saturation, float sigma_space);
        [DllImport(LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createTonemapDurand_12(float gamma, float contrast, float saturation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createTonemapDurand_13(float gamma, float contrast);
        [DllImport(LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createTonemapDurand_14(float gamma);
        [DllImport(LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createTonemapDurand_15();

        // C++:  void cv::xphoto::applyChannelGains(Mat src, Mat& dst, float gainB, float gainG, float gainR)
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_applyChannelGains_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float gainB, float gainG, float gainR);

        // C++:  void cv::xphoto::bm3dDenoising(Mat src, Mat& dst, float h = 1, int templateWindowSize = 4, int searchWindowSize = 16, int blockMatchingStep1 = 2500, int blockMatchingStep2 = 400, int groupSize = 8, int slidingStep = 1, float beta = 2.0f, int normType = cv::NORM_L2, int step = cv::xphoto::BM3D_STEPALL, int transformType = cv::xphoto::HAAR)
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType, int step, int transformType);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType, int step);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_13(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_14(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_15(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_16(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_17(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_18(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_19(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_110(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_111(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::xphoto::bm3dDenoising(Mat src, Mat& dstStep1, Mat& dstStep2, float h = 1, int templateWindowSize = 4, int searchWindowSize = 16, int blockMatchingStep1 = 2500, int blockMatchingStep2 = 400, int groupSize = 8, int slidingStep = 1, float beta = 2.0f, int normType = cv::NORM_L2, int step = cv::xphoto::BM3D_STEPALL, int transformType = cv::xphoto::HAAR)
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_112(IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType, int step, int transformType);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_113(IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType, int step);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_114(IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_115(IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_116(IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_117(IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_118(IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_119(IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_120(IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj, float h, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_121(IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj, float h, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_122(IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj, float h);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_123(IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj);

        // C++:  void cv::xphoto::dctDenoising(Mat src, Mat dst, double sigma, int psize = 16)
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_dctDenoising_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma, int psize);
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_dctDenoising_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma);

        // C++:  void cv::xphoto::inpaint(Mat src, Mat mask, Mat dst, int algorithmType)
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_inpaint_10(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, int algorithmType);

        // C++:  void cv::xphoto::oilPainting(Mat src, Mat& dst, int size, int dynRatio, int code)
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_oilPainting_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int size, int dynRatio, int code);

        // C++:  void cv::xphoto::oilPainting(Mat src, Mat& dst, int size, int dynRatio)
        [DllImport(LIBNAME)]
        private static extern void xphoto_Xphoto_oilPainting_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int size, int dynRatio);

    }
}
