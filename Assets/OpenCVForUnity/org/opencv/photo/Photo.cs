
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{
    // C++: class Photo
    //javadoc: Photo

    public class Photo
    {

        // C++: enum <unnamed>
        public const int INPAINT_NS = 0;
        public const int INPAINT_TELEA = 1;
        public const int LDR_SIZE = 256;
        public const int NORMAL_CLONE = 1;
        public const int MIXED_CLONE = 2;
        public const int MONOCHROME_TRANSFER = 3;
        public const int RECURS_FILTER = 1;
        public const int NORMCONV_FILTER = 2;
        //
        // C++:  Ptr_AlignMTB cv::createAlignMTB(int max_bits = 6, int exclude_range = 4, bool cut = true)
        //

        //javadoc: createAlignMTB(max_bits, exclude_range, cut)
        public static AlignMTB createAlignMTB(int max_bits, int exclude_range, bool cut)
        {
#if UNITY_5_3_OR_NEWER
        
        AlignMTB retVal = AlignMTB.__fromPtr__(photo_Photo_createAlignMTB_10(max_bits, exclude_range, cut));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createAlignMTB(max_bits, exclude_range)
        public static AlignMTB createAlignMTB(int max_bits, int exclude_range)
        {
#if UNITY_5_3_OR_NEWER
        
        AlignMTB retVal = AlignMTB.__fromPtr__(photo_Photo_createAlignMTB_11(max_bits, exclude_range));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createAlignMTB(max_bits)
        public static AlignMTB createAlignMTB(int max_bits)
        {
#if UNITY_5_3_OR_NEWER
        
        AlignMTB retVal = AlignMTB.__fromPtr__(photo_Photo_createAlignMTB_12(max_bits));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createAlignMTB()
        public static AlignMTB createAlignMTB()
        {
#if UNITY_5_3_OR_NEWER
        
        AlignMTB retVal = AlignMTB.__fromPtr__(photo_Photo_createAlignMTB_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_CalibrateDebevec cv::createCalibrateDebevec(int samples = 70, float lambda = 10.0f, bool random = false)
        //

        //javadoc: createCalibrateDebevec(samples, lambda, random)
        public static CalibrateDebevec createCalibrateDebevec(int samples, float lambda, bool random)
        {
#if UNITY_5_3_OR_NEWER
        
        CalibrateDebevec retVal = CalibrateDebevec.__fromPtr__(photo_Photo_createCalibrateDebevec_10(samples, lambda, random));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createCalibrateDebevec(samples, lambda)
        public static CalibrateDebevec createCalibrateDebevec(int samples, float lambda)
        {
#if UNITY_5_3_OR_NEWER
        
        CalibrateDebevec retVal = CalibrateDebevec.__fromPtr__(photo_Photo_createCalibrateDebevec_11(samples, lambda));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createCalibrateDebevec(samples)
        public static CalibrateDebevec createCalibrateDebevec(int samples)
        {
#if UNITY_5_3_OR_NEWER
        
        CalibrateDebevec retVal = CalibrateDebevec.__fromPtr__(photo_Photo_createCalibrateDebevec_12(samples));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createCalibrateDebevec()
        public static CalibrateDebevec createCalibrateDebevec()
        {
#if UNITY_5_3_OR_NEWER
        
        CalibrateDebevec retVal = CalibrateDebevec.__fromPtr__(photo_Photo_createCalibrateDebevec_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_CalibrateRobertson cv::createCalibrateRobertson(int max_iter = 30, float threshold = 0.01f)
        //

        //javadoc: createCalibrateRobertson(max_iter, threshold)
        public static CalibrateRobertson createCalibrateRobertson(int max_iter, float threshold)
        {
#if UNITY_5_3_OR_NEWER
        
        CalibrateRobertson retVal = CalibrateRobertson.__fromPtr__(photo_Photo_createCalibrateRobertson_10(max_iter, threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createCalibrateRobertson(max_iter)
        public static CalibrateRobertson createCalibrateRobertson(int max_iter)
        {
#if UNITY_5_3_OR_NEWER
        
        CalibrateRobertson retVal = CalibrateRobertson.__fromPtr__(photo_Photo_createCalibrateRobertson_11(max_iter));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createCalibrateRobertson()
        public static CalibrateRobertson createCalibrateRobertson()
        {
#if UNITY_5_3_OR_NEWER
        
        CalibrateRobertson retVal = CalibrateRobertson.__fromPtr__(photo_Photo_createCalibrateRobertson_12());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_MergeDebevec cv::createMergeDebevec()
        //

        //javadoc: createMergeDebevec()
        public static MergeDebevec createMergeDebevec()
        {
#if UNITY_5_3_OR_NEWER
        
        MergeDebevec retVal = MergeDebevec.__fromPtr__(photo_Photo_createMergeDebevec_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_MergeMertens cv::createMergeMertens(float contrast_weight = 1.0f, float saturation_weight = 1.0f, float exposure_weight = 0.0f)
        //

        //javadoc: createMergeMertens(contrast_weight, saturation_weight, exposure_weight)
        public static MergeMertens createMergeMertens(float contrast_weight, float saturation_weight, float exposure_weight)
        {
#if UNITY_5_3_OR_NEWER
        
        MergeMertens retVal = MergeMertens.__fromPtr__(photo_Photo_createMergeMertens_10(contrast_weight, saturation_weight, exposure_weight));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createMergeMertens(contrast_weight, saturation_weight)
        public static MergeMertens createMergeMertens(float contrast_weight, float saturation_weight)
        {
#if UNITY_5_3_OR_NEWER
        
        MergeMertens retVal = MergeMertens.__fromPtr__(photo_Photo_createMergeMertens_11(contrast_weight, saturation_weight));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createMergeMertens(contrast_weight)
        public static MergeMertens createMergeMertens(float contrast_weight)
        {
#if UNITY_5_3_OR_NEWER
        
        MergeMertens retVal = MergeMertens.__fromPtr__(photo_Photo_createMergeMertens_12(contrast_weight));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createMergeMertens()
        public static MergeMertens createMergeMertens()
        {
#if UNITY_5_3_OR_NEWER
        
        MergeMertens retVal = MergeMertens.__fromPtr__(photo_Photo_createMergeMertens_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_MergeRobertson cv::createMergeRobertson()
        //

        //javadoc: createMergeRobertson()
        public static MergeRobertson createMergeRobertson()
        {
#if UNITY_5_3_OR_NEWER
        
        MergeRobertson retVal = MergeRobertson.__fromPtr__(photo_Photo_createMergeRobertson_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_Tonemap cv::createTonemap(float gamma = 1.0f)
        //

        //javadoc: createTonemap(gamma)
        public static Tonemap createTonemap(float gamma)
        {
#if UNITY_5_3_OR_NEWER
        
        Tonemap retVal = Tonemap.__fromPtr__(photo_Photo_createTonemap_10(gamma));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemap()
        public static Tonemap createTonemap()
        {
#if UNITY_5_3_OR_NEWER
        
        Tonemap retVal = Tonemap.__fromPtr__(photo_Photo_createTonemap_11());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_TonemapDrago cv::createTonemapDrago(float gamma = 1.0f, float saturation = 1.0f, float bias = 0.85f)
        //

        //javadoc: createTonemapDrago(gamma, saturation, bias)
        public static TonemapDrago createTonemapDrago(float gamma, float saturation, float bias)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapDrago retVal = TonemapDrago.__fromPtr__(photo_Photo_createTonemapDrago_10(gamma, saturation, bias));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapDrago(gamma, saturation)
        public static TonemapDrago createTonemapDrago(float gamma, float saturation)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapDrago retVal = TonemapDrago.__fromPtr__(photo_Photo_createTonemapDrago_11(gamma, saturation));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapDrago(gamma)
        public static TonemapDrago createTonemapDrago(float gamma)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapDrago retVal = TonemapDrago.__fromPtr__(photo_Photo_createTonemapDrago_12(gamma));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapDrago()
        public static TonemapDrago createTonemapDrago()
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapDrago retVal = TonemapDrago.__fromPtr__(photo_Photo_createTonemapDrago_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_TonemapMantiuk cv::createTonemapMantiuk(float gamma = 1.0f, float scale = 0.7f, float saturation = 1.0f)
        //

        //javadoc: createTonemapMantiuk(gamma, scale, saturation)
        public static TonemapMantiuk createTonemapMantiuk(float gamma, float scale, float saturation)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapMantiuk retVal = TonemapMantiuk.__fromPtr__(photo_Photo_createTonemapMantiuk_10(gamma, scale, saturation));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapMantiuk(gamma, scale)
        public static TonemapMantiuk createTonemapMantiuk(float gamma, float scale)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapMantiuk retVal = TonemapMantiuk.__fromPtr__(photo_Photo_createTonemapMantiuk_11(gamma, scale));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapMantiuk(gamma)
        public static TonemapMantiuk createTonemapMantiuk(float gamma)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapMantiuk retVal = TonemapMantiuk.__fromPtr__(photo_Photo_createTonemapMantiuk_12(gamma));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapMantiuk()
        public static TonemapMantiuk createTonemapMantiuk()
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapMantiuk retVal = TonemapMantiuk.__fromPtr__(photo_Photo_createTonemapMantiuk_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_TonemapReinhard cv::createTonemapReinhard(float gamma = 1.0f, float intensity = 0.0f, float light_adapt = 1.0f, float color_adapt = 0.0f)
        //

        //javadoc: createTonemapReinhard(gamma, intensity, light_adapt, color_adapt)
        public static TonemapReinhard createTonemapReinhard(float gamma, float intensity, float light_adapt, float color_adapt)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapReinhard retVal = TonemapReinhard.__fromPtr__(photo_Photo_createTonemapReinhard_10(gamma, intensity, light_adapt, color_adapt));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapReinhard(gamma, intensity, light_adapt)
        public static TonemapReinhard createTonemapReinhard(float gamma, float intensity, float light_adapt)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapReinhard retVal = TonemapReinhard.__fromPtr__(photo_Photo_createTonemapReinhard_11(gamma, intensity, light_adapt));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapReinhard(gamma, intensity)
        public static TonemapReinhard createTonemapReinhard(float gamma, float intensity)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapReinhard retVal = TonemapReinhard.__fromPtr__(photo_Photo_createTonemapReinhard_12(gamma, intensity));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapReinhard(gamma)
        public static TonemapReinhard createTonemapReinhard(float gamma)
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapReinhard retVal = TonemapReinhard.__fromPtr__(photo_Photo_createTonemapReinhard_13(gamma));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createTonemapReinhard()
        public static TonemapReinhard createTonemapReinhard()
        {
#if UNITY_5_3_OR_NEWER
        
        TonemapReinhard retVal = TonemapReinhard.__fromPtr__(photo_Photo_createTonemapReinhard_14());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::colorChange(Mat src, Mat mask, Mat& dst, float red_mul = 1.0f, float green_mul = 1.0f, float blue_mul = 1.0f)
        //

        //javadoc: colorChange(src, mask, dst, red_mul, green_mul, blue_mul)
        public static void colorChange(Mat src, Mat mask, Mat dst, float red_mul, float green_mul, float blue_mul)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_colorChange_10(src.nativeObj, mask.nativeObj, dst.nativeObj, red_mul, green_mul, blue_mul);
        
        return;
#else
            return;
#endif
        }

        //javadoc: colorChange(src, mask, dst, red_mul, green_mul)
        public static void colorChange(Mat src, Mat mask, Mat dst, float red_mul, float green_mul)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_colorChange_11(src.nativeObj, mask.nativeObj, dst.nativeObj, red_mul, green_mul);
        
        return;
#else
            return;
#endif
        }

        //javadoc: colorChange(src, mask, dst, red_mul)
        public static void colorChange(Mat src, Mat mask, Mat dst, float red_mul)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_colorChange_12(src.nativeObj, mask.nativeObj, dst.nativeObj, red_mul);
        
        return;
#else
            return;
#endif
        }

        //javadoc: colorChange(src, mask, dst)
        public static void colorChange(Mat src, Mat mask, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_colorChange_13(src.nativeObj, mask.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::decolor(Mat src, Mat& grayscale, Mat& color_boost)
        //

        //javadoc: decolor(src, grayscale, color_boost)
        public static void decolor(Mat src, Mat grayscale, Mat color_boost)
        {
            if (src != null) src.ThrowIfDisposed();
            if (grayscale != null) grayscale.ThrowIfDisposed();
            if (color_boost != null) color_boost.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_decolor_10(src.nativeObj, grayscale.nativeObj, color_boost.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::denoise_TVL1(vector_Mat observations, Mat result, double lambda = 1.0, int niters = 30)
        //

        //javadoc: denoise_TVL1(observations, result, lambda, niters)
        public static void denoise_TVL1(List<Mat> observations, Mat result, double lambda, int niters)
        {
            if (result != null) result.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat observations_mat = Converters.vector_Mat_to_Mat(observations);
        photo_Photo_denoise_1TVL1_10(observations_mat.nativeObj, result.nativeObj, lambda, niters);
        
        return;
#else
            return;
#endif
        }

        //javadoc: denoise_TVL1(observations, result, lambda)
        public static void denoise_TVL1(List<Mat> observations, Mat result, double lambda)
        {
            if (result != null) result.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat observations_mat = Converters.vector_Mat_to_Mat(observations);
        photo_Photo_denoise_1TVL1_11(observations_mat.nativeObj, result.nativeObj, lambda);
        
        return;
#else
            return;
#endif
        }

        //javadoc: denoise_TVL1(observations, result)
        public static void denoise_TVL1(List<Mat> observations, Mat result)
        {
            if (result != null) result.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat observations_mat = Converters.vector_Mat_to_Mat(observations);
        photo_Photo_denoise_1TVL1_12(observations_mat.nativeObj, result.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::detailEnhance(Mat src, Mat& dst, float sigma_s = 10, float sigma_r = 0.15f)
        //

        //javadoc: detailEnhance(src, dst, sigma_s, sigma_r)
        public static void detailEnhance(Mat src, Mat dst, float sigma_s, float sigma_r)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_detailEnhance_10(src.nativeObj, dst.nativeObj, sigma_s, sigma_r);
        
        return;
#else
            return;
#endif
        }

        //javadoc: detailEnhance(src, dst, sigma_s)
        public static void detailEnhance(Mat src, Mat dst, float sigma_s)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_detailEnhance_11(src.nativeObj, dst.nativeObj, sigma_s);
        
        return;
#else
            return;
#endif
        }

        //javadoc: detailEnhance(src, dst)
        public static void detailEnhance(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_detailEnhance_12(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::edgePreservingFilter(Mat src, Mat& dst, int flags = 1, float sigma_s = 60, float sigma_r = 0.4f)
        //

        //javadoc: edgePreservingFilter(src, dst, flags, sigma_s, sigma_r)
        public static void edgePreservingFilter(Mat src, Mat dst, int flags, float sigma_s, float sigma_r)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_edgePreservingFilter_10(src.nativeObj, dst.nativeObj, flags, sigma_s, sigma_r);
        
        return;
#else
            return;
#endif
        }

        //javadoc: edgePreservingFilter(src, dst, flags, sigma_s)
        public static void edgePreservingFilter(Mat src, Mat dst, int flags, float sigma_s)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_edgePreservingFilter_11(src.nativeObj, dst.nativeObj, flags, sigma_s);
        
        return;
#else
            return;
#endif
        }

        //javadoc: edgePreservingFilter(src, dst, flags)
        public static void edgePreservingFilter(Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_edgePreservingFilter_12(src.nativeObj, dst.nativeObj, flags);
        
        return;
#else
            return;
#endif
        }

        //javadoc: edgePreservingFilter(src, dst)
        public static void edgePreservingFilter(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_edgePreservingFilter_13(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::fastNlMeansDenoising(Mat src, Mat& dst, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        //javadoc: fastNlMeansDenoising(src, dst, h, templateWindowSize, searchWindowSize)
        public static void fastNlMeansDenoising(Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_fastNlMeansDenoising_10(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoising(src, dst, h, templateWindowSize)
        public static void fastNlMeansDenoising(Mat src, Mat dst, float h, int templateWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_fastNlMeansDenoising_11(src.nativeObj, dst.nativeObj, h, templateWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoising(src, dst, h)
        public static void fastNlMeansDenoising(Mat src, Mat dst, float h)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_fastNlMeansDenoising_12(src.nativeObj, dst.nativeObj, h);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoising(src, dst)
        public static void fastNlMeansDenoising(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_fastNlMeansDenoising_13(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::fastNlMeansDenoising(Mat src, Mat& dst, vector_float h, int templateWindowSize = 7, int searchWindowSize = 21, int normType = NORM_L2)
        //

        //javadoc: fastNlMeansDenoising(src, dst, h, templateWindowSize, searchWindowSize, normType)
        public static void fastNlMeansDenoising(Mat src, Mat dst, MatOfFloat h, int templateWindowSize, int searchWindowSize, int normType)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat h_mat = h;
        photo_Photo_fastNlMeansDenoising_14(src.nativeObj, dst.nativeObj, h_mat.nativeObj, templateWindowSize, searchWindowSize, normType);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoising(src, dst, h, templateWindowSize, searchWindowSize)
        public static void fastNlMeansDenoising(Mat src, Mat dst, MatOfFloat h, int templateWindowSize, int searchWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat h_mat = h;
        photo_Photo_fastNlMeansDenoising_15(src.nativeObj, dst.nativeObj, h_mat.nativeObj, templateWindowSize, searchWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoising(src, dst, h, templateWindowSize)
        public static void fastNlMeansDenoising(Mat src, Mat dst, MatOfFloat h, int templateWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat h_mat = h;
        photo_Photo_fastNlMeansDenoising_16(src.nativeObj, dst.nativeObj, h_mat.nativeObj, templateWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoising(src, dst, h)
        public static void fastNlMeansDenoising(Mat src, Mat dst, MatOfFloat h)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat h_mat = h;
        photo_Photo_fastNlMeansDenoising_17(src.nativeObj, dst.nativeObj, h_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::fastNlMeansDenoisingColored(Mat src, Mat& dst, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        //javadoc: fastNlMeansDenoisingColored(src, dst, h, hColor, templateWindowSize, searchWindowSize)
        public static void fastNlMeansDenoisingColored(Mat src, Mat dst, float h, float hColor, int templateWindowSize, int searchWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_fastNlMeansDenoisingColored_10(src.nativeObj, dst.nativeObj, h, hColor, templateWindowSize, searchWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingColored(src, dst, h, hColor, templateWindowSize)
        public static void fastNlMeansDenoisingColored(Mat src, Mat dst, float h, float hColor, int templateWindowSize)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_fastNlMeansDenoisingColored_11(src.nativeObj, dst.nativeObj, h, hColor, templateWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingColored(src, dst, h, hColor)
        public static void fastNlMeansDenoisingColored(Mat src, Mat dst, float h, float hColor)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_fastNlMeansDenoisingColored_12(src.nativeObj, dst.nativeObj, h, hColor);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingColored(src, dst, h)
        public static void fastNlMeansDenoisingColored(Mat src, Mat dst, float h)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_fastNlMeansDenoisingColored_13(src.nativeObj, dst.nativeObj, h);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingColored(src, dst)
        public static void fastNlMeansDenoisingColored(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_fastNlMeansDenoisingColored_14(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::fastNlMeansDenoisingColoredMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        //javadoc: fastNlMeansDenoisingColoredMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h, hColor, templateWindowSize, searchWindowSize)
        public static void fastNlMeansDenoisingColoredMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize, int searchWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        photo_Photo_fastNlMeansDenoisingColoredMulti_10(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, hColor, templateWindowSize, searchWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingColoredMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h, hColor, templateWindowSize)
        public static void fastNlMeansDenoisingColoredMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        photo_Photo_fastNlMeansDenoisingColoredMulti_11(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, hColor, templateWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingColoredMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h, hColor)
        public static void fastNlMeansDenoisingColoredMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor)
        {
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        photo_Photo_fastNlMeansDenoisingColoredMulti_12(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, hColor);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingColoredMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h)
        public static void fastNlMeansDenoisingColoredMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h)
        {
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        photo_Photo_fastNlMeansDenoisingColoredMulti_13(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingColoredMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize)
        public static void fastNlMeansDenoisingColoredMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        photo_Photo_fastNlMeansDenoisingColoredMulti_14(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        //javadoc: fastNlMeansDenoisingMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h, templateWindowSize, searchWindowSize)
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize, int searchWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        photo_Photo_fastNlMeansDenoisingMulti_10(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, templateWindowSize, searchWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h, templateWindowSize)
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        photo_Photo_fastNlMeansDenoisingMulti_11(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, templateWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h)
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h)
        {
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        photo_Photo_fastNlMeansDenoisingMulti_12(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize)
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        photo_Photo_fastNlMeansDenoisingMulti_13(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, vector_float h, int templateWindowSize = 7, int searchWindowSize = 21, int normType = NORM_L2)
        //

        //javadoc: fastNlMeansDenoisingMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h, templateWindowSize, searchWindowSize, normType)
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, MatOfFloat h, int templateWindowSize, int searchWindowSize, int normType)
        {
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        Mat h_mat = h;
        photo_Photo_fastNlMeansDenoisingMulti_14(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h_mat.nativeObj, templateWindowSize, searchWindowSize, normType);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h, templateWindowSize, searchWindowSize)
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, MatOfFloat h, int templateWindowSize, int searchWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        Mat h_mat = h;
        photo_Photo_fastNlMeansDenoisingMulti_15(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h_mat.nativeObj, templateWindowSize, searchWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h, templateWindowSize)
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, MatOfFloat h, int templateWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        Mat h_mat = h;
        photo_Photo_fastNlMeansDenoisingMulti_16(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h_mat.nativeObj, templateWindowSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastNlMeansDenoisingMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h)
        public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, MatOfFloat h)
        {
            if (dst != null) dst.ThrowIfDisposed();
            if (h != null) h.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        Mat h_mat = h;
        photo_Photo_fastNlMeansDenoisingMulti_17(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::illuminationChange(Mat src, Mat mask, Mat& dst, float alpha = 0.2f, float beta = 0.4f)
        //

        //javadoc: illuminationChange(src, mask, dst, alpha, beta)
        public static void illuminationChange(Mat src, Mat mask, Mat dst, float alpha, float beta)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_illuminationChange_10(src.nativeObj, mask.nativeObj, dst.nativeObj, alpha, beta);
        
        return;
#else
            return;
#endif
        }

        //javadoc: illuminationChange(src, mask, dst, alpha)
        public static void illuminationChange(Mat src, Mat mask, Mat dst, float alpha)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_illuminationChange_11(src.nativeObj, mask.nativeObj, dst.nativeObj, alpha);
        
        return;
#else
            return;
#endif
        }

        //javadoc: illuminationChange(src, mask, dst)
        public static void illuminationChange(Mat src, Mat mask, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_illuminationChange_12(src.nativeObj, mask.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::inpaint(Mat src, Mat inpaintMask, Mat& dst, double inpaintRadius, int flags)
        //

        //javadoc: inpaint(src, inpaintMask, dst, inpaintRadius, flags)
        public static void inpaint(Mat src, Mat inpaintMask, Mat dst, double inpaintRadius, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (inpaintMask != null) inpaintMask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_inpaint_10(src.nativeObj, inpaintMask.nativeObj, dst.nativeObj, inpaintRadius, flags);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::pencilSketch(Mat src, Mat& dst1, Mat& dst2, float sigma_s = 60, float sigma_r = 0.07f, float shade_factor = 0.02f)
        //

        //javadoc: pencilSketch(src, dst1, dst2, sigma_s, sigma_r, shade_factor)
        public static void pencilSketch(Mat src, Mat dst1, Mat dst2, float sigma_s, float sigma_r, float shade_factor)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst1 != null) dst1.ThrowIfDisposed();
            if (dst2 != null) dst2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_pencilSketch_10(src.nativeObj, dst1.nativeObj, dst2.nativeObj, sigma_s, sigma_r, shade_factor);
        
        return;
#else
            return;
#endif
        }

        //javadoc: pencilSketch(src, dst1, dst2, sigma_s, sigma_r)
        public static void pencilSketch(Mat src, Mat dst1, Mat dst2, float sigma_s, float sigma_r)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst1 != null) dst1.ThrowIfDisposed();
            if (dst2 != null) dst2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_pencilSketch_11(src.nativeObj, dst1.nativeObj, dst2.nativeObj, sigma_s, sigma_r);
        
        return;
#else
            return;
#endif
        }

        //javadoc: pencilSketch(src, dst1, dst2, sigma_s)
        public static void pencilSketch(Mat src, Mat dst1, Mat dst2, float sigma_s)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst1 != null) dst1.ThrowIfDisposed();
            if (dst2 != null) dst2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_pencilSketch_12(src.nativeObj, dst1.nativeObj, dst2.nativeObj, sigma_s);
        
        return;
#else
            return;
#endif
        }

        //javadoc: pencilSketch(src, dst1, dst2)
        public static void pencilSketch(Mat src, Mat dst1, Mat dst2)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst1 != null) dst1.ThrowIfDisposed();
            if (dst2 != null) dst2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_pencilSketch_13(src.nativeObj, dst1.nativeObj, dst2.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::seamlessClone(Mat src, Mat dst, Mat mask, Point p, Mat& blend, int flags)
        //

        //javadoc: seamlessClone(src, dst, mask, p, blend, flags)
        public static void seamlessClone(Mat src, Mat dst, Mat mask, Point p, Mat blend, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (blend != null) blend.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_seamlessClone_10(src.nativeObj, dst.nativeObj, mask.nativeObj, p.x, p.y, blend.nativeObj, flags);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::stylization(Mat src, Mat& dst, float sigma_s = 60, float sigma_r = 0.45f)
        //

        //javadoc: stylization(src, dst, sigma_s, sigma_r)
        public static void stylization(Mat src, Mat dst, float sigma_s, float sigma_r)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_stylization_10(src.nativeObj, dst.nativeObj, sigma_s, sigma_r);
        
        return;
#else
            return;
#endif
        }

        //javadoc: stylization(src, dst, sigma_s)
        public static void stylization(Mat src, Mat dst, float sigma_s)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_stylization_11(src.nativeObj, dst.nativeObj, sigma_s);
        
        return;
#else
            return;
#endif
        }

        //javadoc: stylization(src, dst)
        public static void stylization(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_stylization_12(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::textureFlattening(Mat src, Mat mask, Mat& dst, float low_threshold = 30, float high_threshold = 45, int kernel_size = 3)
        //

        //javadoc: textureFlattening(src, mask, dst, low_threshold, high_threshold, kernel_size)
        public static void textureFlattening(Mat src, Mat mask, Mat dst, float low_threshold, float high_threshold, int kernel_size)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_textureFlattening_10(src.nativeObj, mask.nativeObj, dst.nativeObj, low_threshold, high_threshold, kernel_size);
        
        return;
#else
            return;
#endif
        }

        //javadoc: textureFlattening(src, mask, dst, low_threshold, high_threshold)
        public static void textureFlattening(Mat src, Mat mask, Mat dst, float low_threshold, float high_threshold)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_textureFlattening_11(src.nativeObj, mask.nativeObj, dst.nativeObj, low_threshold, high_threshold);
        
        return;
#else
            return;
#endif
        }

        //javadoc: textureFlattening(src, mask, dst, low_threshold)
        public static void textureFlattening(Mat src, Mat mask, Mat dst, float low_threshold)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_textureFlattening_12(src.nativeObj, mask.nativeObj, dst.nativeObj, low_threshold);
        
        return;
#else
            return;
#endif
        }

        //javadoc: textureFlattening(src, mask, dst)
        public static void textureFlattening(Mat src, Mat mask, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        photo_Photo_textureFlattening_13(src.nativeObj, mask.nativeObj, dst.nativeObj);
        
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



        // C++:  Ptr_AlignMTB cv::createAlignMTB(int max_bits = 6, int exclude_range = 4, bool cut = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createAlignMTB_10(int max_bits, int exclude_range, [MarshalAs(UnmanagedType.U1)] bool cut);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createAlignMTB_11(int max_bits, int exclude_range);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createAlignMTB_12(int max_bits);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createAlignMTB_13();

        // C++:  Ptr_CalibrateDebevec cv::createCalibrateDebevec(int samples = 70, float lambda = 10.0f, bool random = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateDebevec_10(int samples, float lambda, [MarshalAs(UnmanagedType.U1)] bool random);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateDebevec_11(int samples, float lambda);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateDebevec_12(int samples);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateDebevec_13();

        // C++:  Ptr_CalibrateRobertson cv::createCalibrateRobertson(int max_iter = 30, float threshold = 0.01f)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateRobertson_10(int max_iter, float threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateRobertson_11(int max_iter);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateRobertson_12();

        // C++:  Ptr_MergeDebevec cv::createMergeDebevec()
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeDebevec_10();

        // C++:  Ptr_MergeMertens cv::createMergeMertens(float contrast_weight = 1.0f, float saturation_weight = 1.0f, float exposure_weight = 0.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeMertens_10(float contrast_weight, float saturation_weight, float exposure_weight);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeMertens_11(float contrast_weight, float saturation_weight);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeMertens_12(float contrast_weight);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeMertens_13();

        // C++:  Ptr_MergeRobertson cv::createMergeRobertson()
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeRobertson_10();

        // C++:  Ptr_Tonemap cv::createTonemap(float gamma = 1.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemap_10(float gamma);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemap_11();

        // C++:  Ptr_TonemapDrago cv::createTonemapDrago(float gamma = 1.0f, float saturation = 1.0f, float bias = 0.85f)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapDrago_10(float gamma, float saturation, float bias);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapDrago_11(float gamma, float saturation);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapDrago_12(float gamma);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapDrago_13();

        // C++:  Ptr_TonemapMantiuk cv::createTonemapMantiuk(float gamma = 1.0f, float scale = 0.7f, float saturation = 1.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapMantiuk_10(float gamma, float scale, float saturation);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapMantiuk_11(float gamma, float scale);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapMantiuk_12(float gamma);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapMantiuk_13();

        // C++:  Ptr_TonemapReinhard cv::createTonemapReinhard(float gamma = 1.0f, float intensity = 0.0f, float light_adapt = 1.0f, float color_adapt = 0.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapReinhard_10(float gamma, float intensity, float light_adapt, float color_adapt);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapReinhard_11(float gamma, float intensity, float light_adapt);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapReinhard_12(float gamma, float intensity);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapReinhard_13(float gamma);
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapReinhard_14();

        // C++:  void cv::colorChange(Mat src, Mat mask, Mat& dst, float red_mul = 1.0f, float green_mul = 1.0f, float blue_mul = 1.0f)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_colorChange_10(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float red_mul, float green_mul, float blue_mul);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_colorChange_11(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float red_mul, float green_mul);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_colorChange_12(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float red_mul);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_colorChange_13(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::decolor(Mat src, Mat& grayscale, Mat& color_boost)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_decolor_10(IntPtr src_nativeObj, IntPtr grayscale_nativeObj, IntPtr color_boost_nativeObj);

        // C++:  void cv::denoise_TVL1(vector_Mat observations, Mat result, double lambda = 1.0, int niters = 30)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_denoise_1TVL1_10(IntPtr observations_mat_nativeObj, IntPtr result_nativeObj, double lambda, int niters);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_denoise_1TVL1_11(IntPtr observations_mat_nativeObj, IntPtr result_nativeObj, double lambda);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_denoise_1TVL1_12(IntPtr observations_mat_nativeObj, IntPtr result_nativeObj);

        // C++:  void cv::detailEnhance(Mat src, Mat& dst, float sigma_s = 10, float sigma_r = 0.15f)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_detailEnhance_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float sigma_s, float sigma_r);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_detailEnhance_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, float sigma_s);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_detailEnhance_12(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::edgePreservingFilter(Mat src, Mat& dst, int flags = 1, float sigma_s = 60, float sigma_r = 0.4f)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_edgePreservingFilter_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags, float sigma_s, float sigma_r);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_edgePreservingFilter_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags, float sigma_s);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_edgePreservingFilter_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_edgePreservingFilter_13(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::fastNlMeansDenoising(Mat src, Mat& dst, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_13(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::fastNlMeansDenoising(Mat src, Mat& dst, vector_float h, int templateWindowSize = 7, int searchWindowSize = 21, int normType = NORM_L2)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_14(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr h_mat_nativeObj, int templateWindowSize, int searchWindowSize, int normType);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_15(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr h_mat_nativeObj, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_16(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr h_mat_nativeObj, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_17(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr h_mat_nativeObj);

        // C++:  void cv::fastNlMeansDenoisingColored(Mat src, Mat& dst, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColored_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, float hColor, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColored_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, float hColor, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColored_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, float hColor);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColored_13(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColored_14(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::fastNlMeansDenoisingColoredMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColoredMulti_10(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColoredMulti_11(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColoredMulti_12(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColoredMulti_13(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColoredMulti_14(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize);

        // C++:  void cv::fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_10(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_11(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_12(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_13(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize);

        // C++:  void cv::fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, vector_float h, int templateWindowSize = 7, int searchWindowSize = 21, int normType = NORM_L2)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_14(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, IntPtr h_mat_nativeObj, int templateWindowSize, int searchWindowSize, int normType);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_15(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, IntPtr h_mat_nativeObj, int templateWindowSize, int searchWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_16(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, IntPtr h_mat_nativeObj, int templateWindowSize);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_17(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, IntPtr h_mat_nativeObj);

        // C++:  void cv::illuminationChange(Mat src, Mat mask, Mat& dst, float alpha = 0.2f, float beta = 0.4f)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_illuminationChange_10(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float alpha, float beta);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_illuminationChange_11(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float alpha);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_illuminationChange_12(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::inpaint(Mat src, Mat inpaintMask, Mat& dst, double inpaintRadius, int flags)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_inpaint_10(IntPtr src_nativeObj, IntPtr inpaintMask_nativeObj, IntPtr dst_nativeObj, double inpaintRadius, int flags);

        // C++:  void cv::pencilSketch(Mat src, Mat& dst1, Mat& dst2, float sigma_s = 60, float sigma_r = 0.07f, float shade_factor = 0.02f)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_pencilSketch_10(IntPtr src_nativeObj, IntPtr dst1_nativeObj, IntPtr dst2_nativeObj, float sigma_s, float sigma_r, float shade_factor);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_pencilSketch_11(IntPtr src_nativeObj, IntPtr dst1_nativeObj, IntPtr dst2_nativeObj, float sigma_s, float sigma_r);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_pencilSketch_12(IntPtr src_nativeObj, IntPtr dst1_nativeObj, IntPtr dst2_nativeObj, float sigma_s);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_pencilSketch_13(IntPtr src_nativeObj, IntPtr dst1_nativeObj, IntPtr dst2_nativeObj);

        // C++:  void cv::seamlessClone(Mat src, Mat dst, Mat mask, Point p, Mat& blend, int flags)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_seamlessClone_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj, double p_x, double p_y, IntPtr blend_nativeObj, int flags);

        // C++:  void cv::stylization(Mat src, Mat& dst, float sigma_s = 60, float sigma_r = 0.45f)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_stylization_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float sigma_s, float sigma_r);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_stylization_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, float sigma_s);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_stylization_12(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::textureFlattening(Mat src, Mat mask, Mat& dst, float low_threshold = 30, float high_threshold = 45, int kernel_size = 3)
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_textureFlattening_10(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float low_threshold, float high_threshold, int kernel_size);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_textureFlattening_11(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float low_threshold, float high_threshold);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_textureFlattening_12(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float low_threshold);
        [DllImport(LIBNAME)]
        private static extern void photo_Photo_textureFlattening_13(IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj);

    }
}
