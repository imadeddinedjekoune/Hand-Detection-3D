
using OpenCVForUnity.Calib3dModule;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{
    // C++: class Ximgproc
    //javadoc: Ximgproc

    public class Ximgproc
    {

        // C++: enum HoughOp
        public const int FHT_MIN = 0;
        public const int FHT_MAX = 1;
        public const int FHT_ADD = 2;
        public const int FHT_AVE = 3;
        // C++: enum LocalBinarizationMethods
        public const int BINARIZATION_NIBLACK = 0;
        public const int BINARIZATION_SAUVOLA = 1;
        public const int BINARIZATION_WOLF = 2;
        public const int BINARIZATION_NICK = 3;
        // C++: enum SLICType
        public const int SLIC = 100;
        public const int SLICO = 101;
        public const int MSLIC = 102;
        // C++: enum WMFWeightType
        public const int WMF_EXP = 1;
        public const int WMF_IV1 = 1 << 1;
        public const int WMF_IV2 = 1 << 2;
        public const int WMF_COS = 1 << 3;
        public const int WMF_JAC = 1 << 4;
        public const int WMF_OFF = 1 << 5;
        // C++: enum EdgeAwareFiltersList
        public const int DTF_NC = 0;
        public const int DTF_IC = 1;
        public const int DTF_RF = 2;
        public const int GUIDED_FILTER = 3;
        public const int AM_FILTER = 4;
        // C++: enum AngleRangeOption
        public const int ARO_0_45 = 0;
        public const int ARO_45_90 = 1;
        public const int ARO_90_135 = 2;
        public const int ARO_315_0 = 3;
        public const int ARO_315_45 = 4;
        public const int ARO_45_135 = 5;
        public const int ARO_315_135 = 6;
        public const int ARO_CTR_HOR = 7;
        public const int ARO_CTR_VER = 8;
        // C++: enum HoughDeskewOption
        public const int HDO_RAW = 0;
        public const int HDO_DESKEW = 1;
        // C++: enum ThinningTypes
        public const int THINNING_ZHANGSUEN = 0;
        public const int THINNING_GUOHALL = 1;
        //
        // C++:  Ptr_AdaptiveManifoldFilter cv::ximgproc::createAMFilter(double sigma_s, double sigma_r, bool adjust_outliers = false)
        //

        //javadoc: createAMFilter(sigma_s, sigma_r, adjust_outliers)
        public static AdaptiveManifoldFilter createAMFilter(double sigma_s, double sigma_r, bool adjust_outliers)
        {
#if UNITY_5_3_OR_NEWER
        
        AdaptiveManifoldFilter retVal = AdaptiveManifoldFilter.__fromPtr__(ximgproc_Ximgproc_createAMFilter_10(sigma_s, sigma_r, adjust_outliers));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createAMFilter(sigma_s, sigma_r)
        public static AdaptiveManifoldFilter createAMFilter(double sigma_s, double sigma_r)
        {
#if UNITY_5_3_OR_NEWER
        
        AdaptiveManifoldFilter retVal = AdaptiveManifoldFilter.__fromPtr__(ximgproc_Ximgproc_createAMFilter_11(sigma_s, sigma_r));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_ContourFitting cv::ximgproc::createContourFitting(int ctr = 1024, int fd = 16)
        //

        //javadoc: createContourFitting(ctr, fd)
        public static ContourFitting createContourFitting(int ctr, int fd)
        {
#if UNITY_5_3_OR_NEWER
        
        ContourFitting retVal = ContourFitting.__fromPtr__(ximgproc_Ximgproc_createContourFitting_10(ctr, fd));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createContourFitting(ctr)
        public static ContourFitting createContourFitting(int ctr)
        {
#if UNITY_5_3_OR_NEWER
        
        ContourFitting retVal = ContourFitting.__fromPtr__(ximgproc_Ximgproc_createContourFitting_11(ctr));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createContourFitting()
        public static ContourFitting createContourFitting()
        {
#if UNITY_5_3_OR_NEWER
        
        ContourFitting retVal = ContourFitting.__fromPtr__(ximgproc_Ximgproc_createContourFitting_12());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_DTFilter cv::ximgproc::createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        //

        //javadoc: createDTFilter(guide, sigmaSpatial, sigmaColor, mode, numIters)
        public static DTFilter createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor, int mode, int numIters)
        {
            if (guide != null) guide.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        DTFilter retVal = DTFilter.__fromPtr__(ximgproc_Ximgproc_createDTFilter_10(guide.nativeObj, sigmaSpatial, sigmaColor, mode, numIters));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createDTFilter(guide, sigmaSpatial, sigmaColor, mode)
        public static DTFilter createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor, int mode)
        {
            if (guide != null) guide.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        DTFilter retVal = DTFilter.__fromPtr__(ximgproc_Ximgproc_createDTFilter_11(guide.nativeObj, sigmaSpatial, sigmaColor, mode));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createDTFilter(guide, sigmaSpatial, sigmaColor)
        public static DTFilter createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor)
        {
            if (guide != null) guide.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        DTFilter retVal = DTFilter.__fromPtr__(ximgproc_Ximgproc_createDTFilter_12(guide.nativeObj, sigmaSpatial, sigmaColor));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_DisparityWLSFilter cv::ximgproc::createDisparityWLSFilter(Ptr_StereoMatcher matcher_left)
        //

        //javadoc: createDisparityWLSFilter(matcher_left)
        public static DisparityWLSFilter createDisparityWLSFilter(StereoMatcher matcher_left)
        {
            if (matcher_left != null) matcher_left.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        DisparityWLSFilter retVal = DisparityWLSFilter.__fromPtr__(ximgproc_Ximgproc_createDisparityWLSFilter_10(matcher_left.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_DisparityWLSFilter cv::ximgproc::createDisparityWLSFilterGeneric(bool use_confidence)
        //

        //javadoc: createDisparityWLSFilterGeneric(use_confidence)
        public static DisparityWLSFilter createDisparityWLSFilterGeneric(bool use_confidence)
        {
#if UNITY_5_3_OR_NEWER
        
        DisparityWLSFilter retVal = DisparityWLSFilter.__fromPtr__(ximgproc_Ximgproc_createDisparityWLSFilterGeneric_10(use_confidence));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_EdgeAwareInterpolator cv::ximgproc::createEdgeAwareInterpolator()
        //

        //javadoc: createEdgeAwareInterpolator()
        public static EdgeAwareInterpolator createEdgeAwareInterpolator()
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeAwareInterpolator retVal = EdgeAwareInterpolator.__fromPtr__(ximgproc_Ximgproc_createEdgeAwareInterpolator_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_EdgeBoxes cv::ximgproc::createEdgeBoxes(float alpha = 0.65f, float beta = 0.75f, float eta = 1, float minScore = 0.01f, int maxBoxes = 10000, float edgeMinMag = 0.1f, float edgeMergeThr = 0.5f, float clusterMinMag = 0.5f, float maxAspectRatio = 3, float minBoxArea = 1000, float gamma = 2, float kappa = 1.5f)
        //

        //javadoc: createEdgeBoxes(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio, minBoxArea, gamma, kappa)
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea, float gamma, float kappa)
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = EdgeBoxes.__fromPtr__(ximgproc_Ximgproc_createEdgeBoxes_10(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio, minBoxArea, gamma, kappa));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEdgeBoxes(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio, minBoxArea, gamma)
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea, float gamma)
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = EdgeBoxes.__fromPtr__(ximgproc_Ximgproc_createEdgeBoxes_11(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio, minBoxArea, gamma));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEdgeBoxes(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio, minBoxArea)
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea)
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = EdgeBoxes.__fromPtr__(ximgproc_Ximgproc_createEdgeBoxes_12(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio, minBoxArea));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEdgeBoxes(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio)
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio)
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = EdgeBoxes.__fromPtr__(ximgproc_Ximgproc_createEdgeBoxes_13(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEdgeBoxes(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag)
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag)
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = EdgeBoxes.__fromPtr__(ximgproc_Ximgproc_createEdgeBoxes_14(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEdgeBoxes(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr)
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr)
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = EdgeBoxes.__fromPtr__(ximgproc_Ximgproc_createEdgeBoxes_15(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEdgeBoxes(alpha, beta, eta, minScore, maxBoxes, edgeMinMag)
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag)
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = EdgeBoxes.__fromPtr__(ximgproc_Ximgproc_createEdgeBoxes_16(alpha, beta, eta, minScore, maxBoxes, edgeMinMag));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEdgeBoxes(alpha, beta, eta, minScore, maxBoxes)
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes)
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = EdgeBoxes.__fromPtr__(ximgproc_Ximgproc_createEdgeBoxes_17(alpha, beta, eta, minScore, maxBoxes));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEdgeBoxes(alpha, beta, eta, minScore)
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore)
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = EdgeBoxes.__fromPtr__(ximgproc_Ximgproc_createEdgeBoxes_18(alpha, beta, eta, minScore));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEdgeBoxes(alpha, beta, eta)
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta)
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = EdgeBoxes.__fromPtr__(ximgproc_Ximgproc_createEdgeBoxes_19(alpha, beta, eta));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEdgeBoxes(alpha, beta)
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta)
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = EdgeBoxes.__fromPtr__(ximgproc_Ximgproc_createEdgeBoxes_110(alpha, beta));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEdgeBoxes(alpha)
        public static EdgeBoxes createEdgeBoxes(float alpha)
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = EdgeBoxes.__fromPtr__(ximgproc_Ximgproc_createEdgeBoxes_111(alpha));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEdgeBoxes()
        public static EdgeBoxes createEdgeBoxes()
        {
#if UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = EdgeBoxes.__fromPtr__(ximgproc_Ximgproc_createEdgeBoxes_112());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_FastBilateralSolverFilter cv::ximgproc::createFastBilateralSolverFilter(Mat guide, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda = 128.0, int num_iter = 25, double max_tol = 1e-5)
        //

        //javadoc: createFastBilateralSolverFilter(guide, sigma_spatial, sigma_luma, sigma_chroma, lambda, num_iter, max_tol)
        public static FastBilateralSolverFilter createFastBilateralSolverFilter(Mat guide, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter, double max_tol)
        {
            if (guide != null) guide.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        FastBilateralSolverFilter retVal = FastBilateralSolverFilter.__fromPtr__(ximgproc_Ximgproc_createFastBilateralSolverFilter_10(guide.nativeObj, sigma_spatial, sigma_luma, sigma_chroma, lambda, num_iter, max_tol));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createFastBilateralSolverFilter(guide, sigma_spatial, sigma_luma, sigma_chroma, lambda, num_iter)
        public static FastBilateralSolverFilter createFastBilateralSolverFilter(Mat guide, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter)
        {
            if (guide != null) guide.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        FastBilateralSolverFilter retVal = FastBilateralSolverFilter.__fromPtr__(ximgproc_Ximgproc_createFastBilateralSolverFilter_11(guide.nativeObj, sigma_spatial, sigma_luma, sigma_chroma, lambda, num_iter));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createFastBilateralSolverFilter(guide, sigma_spatial, sigma_luma, sigma_chroma, lambda)
        public static FastBilateralSolverFilter createFastBilateralSolverFilter(Mat guide, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda)
        {
            if (guide != null) guide.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        FastBilateralSolverFilter retVal = FastBilateralSolverFilter.__fromPtr__(ximgproc_Ximgproc_createFastBilateralSolverFilter_12(guide.nativeObj, sigma_spatial, sigma_luma, sigma_chroma, lambda));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createFastBilateralSolverFilter(guide, sigma_spatial, sigma_luma, sigma_chroma)
        public static FastBilateralSolverFilter createFastBilateralSolverFilter(Mat guide, double sigma_spatial, double sigma_luma, double sigma_chroma)
        {
            if (guide != null) guide.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        FastBilateralSolverFilter retVal = FastBilateralSolverFilter.__fromPtr__(ximgproc_Ximgproc_createFastBilateralSolverFilter_13(guide.nativeObj, sigma_spatial, sigma_luma, sigma_chroma));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_FastGlobalSmootherFilter cv::ximgproc::createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        //

        //javadoc: createFastGlobalSmootherFilter(guide, lambda, sigma_color, lambda_attenuation, num_iter)
        public static FastGlobalSmootherFilter createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color, double lambda_attenuation, int num_iter)
        {
            if (guide != null) guide.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        FastGlobalSmootherFilter retVal = FastGlobalSmootherFilter.__fromPtr__(ximgproc_Ximgproc_createFastGlobalSmootherFilter_10(guide.nativeObj, lambda, sigma_color, lambda_attenuation, num_iter));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createFastGlobalSmootherFilter(guide, lambda, sigma_color, lambda_attenuation)
        public static FastGlobalSmootherFilter createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color, double lambda_attenuation)
        {
            if (guide != null) guide.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        FastGlobalSmootherFilter retVal = FastGlobalSmootherFilter.__fromPtr__(ximgproc_Ximgproc_createFastGlobalSmootherFilter_11(guide.nativeObj, lambda, sigma_color, lambda_attenuation));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createFastGlobalSmootherFilter(guide, lambda, sigma_color)
        public static FastGlobalSmootherFilter createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color)
        {
            if (guide != null) guide.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        FastGlobalSmootherFilter retVal = FastGlobalSmootherFilter.__fromPtr__(ximgproc_Ximgproc_createFastGlobalSmootherFilter_12(guide.nativeObj, lambda, sigma_color));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_FastLineDetector cv::ximgproc::createFastLineDetector(int _length_threshold = 10, float _distance_threshold = 1.414213562f, double _canny_th1 = 50.0, double _canny_th2 = 50.0, int _canny_aperture_size = 3, bool _do_merge = false)
        //

        //javadoc: createFastLineDetector(_length_threshold, _distance_threshold, _canny_th1, _canny_th2, _canny_aperture_size, _do_merge)
        public static FastLineDetector createFastLineDetector(int _length_threshold, float _distance_threshold, double _canny_th1, double _canny_th2, int _canny_aperture_size, bool _do_merge)
        {
#if UNITY_5_3_OR_NEWER
        
        FastLineDetector retVal = FastLineDetector.__fromPtr__(ximgproc_Ximgproc_createFastLineDetector_10(_length_threshold, _distance_threshold, _canny_th1, _canny_th2, _canny_aperture_size, _do_merge));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createFastLineDetector(_length_threshold, _distance_threshold, _canny_th1, _canny_th2, _canny_aperture_size)
        public static FastLineDetector createFastLineDetector(int _length_threshold, float _distance_threshold, double _canny_th1, double _canny_th2, int _canny_aperture_size)
        {
#if UNITY_5_3_OR_NEWER
        
        FastLineDetector retVal = FastLineDetector.__fromPtr__(ximgproc_Ximgproc_createFastLineDetector_11(_length_threshold, _distance_threshold, _canny_th1, _canny_th2, _canny_aperture_size));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createFastLineDetector(_length_threshold, _distance_threshold, _canny_th1, _canny_th2)
        public static FastLineDetector createFastLineDetector(int _length_threshold, float _distance_threshold, double _canny_th1, double _canny_th2)
        {
#if UNITY_5_3_OR_NEWER
        
        FastLineDetector retVal = FastLineDetector.__fromPtr__(ximgproc_Ximgproc_createFastLineDetector_12(_length_threshold, _distance_threshold, _canny_th1, _canny_th2));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createFastLineDetector(_length_threshold, _distance_threshold, _canny_th1)
        public static FastLineDetector createFastLineDetector(int _length_threshold, float _distance_threshold, double _canny_th1)
        {
#if UNITY_5_3_OR_NEWER
        
        FastLineDetector retVal = FastLineDetector.__fromPtr__(ximgproc_Ximgproc_createFastLineDetector_13(_length_threshold, _distance_threshold, _canny_th1));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createFastLineDetector(_length_threshold, _distance_threshold)
        public static FastLineDetector createFastLineDetector(int _length_threshold, float _distance_threshold)
        {
#if UNITY_5_3_OR_NEWER
        
        FastLineDetector retVal = FastLineDetector.__fromPtr__(ximgproc_Ximgproc_createFastLineDetector_14(_length_threshold, _distance_threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createFastLineDetector(_length_threshold)
        public static FastLineDetector createFastLineDetector(int _length_threshold)
        {
#if UNITY_5_3_OR_NEWER
        
        FastLineDetector retVal = FastLineDetector.__fromPtr__(ximgproc_Ximgproc_createFastLineDetector_15(_length_threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createFastLineDetector()
        public static FastLineDetector createFastLineDetector()
        {
#if UNITY_5_3_OR_NEWER
        
        FastLineDetector retVal = FastLineDetector.__fromPtr__(ximgproc_Ximgproc_createFastLineDetector_16());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_GraphSegmentation cv::ximgproc::segmentation::createGraphSegmentation(double sigma = 0.5, float k = 300, int min_size = 100)
        //

        //javadoc: createGraphSegmentation(sigma, k, min_size)
        public static GraphSegmentation createGraphSegmentation(double sigma, float k, int min_size)
        {
#if UNITY_5_3_OR_NEWER
        
        GraphSegmentation retVal = GraphSegmentation.__fromPtr__(ximgproc_Ximgproc_createGraphSegmentation_10(sigma, k, min_size));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createGraphSegmentation(sigma, k)
        public static GraphSegmentation createGraphSegmentation(double sigma, float k)
        {
#if UNITY_5_3_OR_NEWER
        
        GraphSegmentation retVal = GraphSegmentation.__fromPtr__(ximgproc_Ximgproc_createGraphSegmentation_11(sigma, k));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createGraphSegmentation(sigma)
        public static GraphSegmentation createGraphSegmentation(double sigma)
        {
#if UNITY_5_3_OR_NEWER
        
        GraphSegmentation retVal = GraphSegmentation.__fromPtr__(ximgproc_Ximgproc_createGraphSegmentation_12(sigma));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createGraphSegmentation()
        public static GraphSegmentation createGraphSegmentation()
        {
#if UNITY_5_3_OR_NEWER
        
        GraphSegmentation retVal = GraphSegmentation.__fromPtr__(ximgproc_Ximgproc_createGraphSegmentation_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_GuidedFilter cv::ximgproc::createGuidedFilter(Mat guide, int radius, double eps)
        //

        //javadoc: createGuidedFilter(guide, radius, eps)
        public static GuidedFilter createGuidedFilter(Mat guide, int radius, double eps)
        {
            if (guide != null) guide.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        GuidedFilter retVal = GuidedFilter.__fromPtr__(ximgproc_Ximgproc_createGuidedFilter_10(guide.nativeObj, radius, eps));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_RFFeatureGetter cv::ximgproc::createRFFeatureGetter()
        //

        //javadoc: createRFFeatureGetter()
        public static RFFeatureGetter createRFFeatureGetter()
        {
#if UNITY_5_3_OR_NEWER
        
        RFFeatureGetter retVal = RFFeatureGetter.__fromPtr__(ximgproc_Ximgproc_createRFFeatureGetter_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentation cv::ximgproc::segmentation::createSelectiveSearchSegmentation()
        //

        //javadoc: createSelectiveSearchSegmentation()
        public static SelectiveSearchSegmentation createSelectiveSearchSegmentation()
        {
#if UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentation retVal = SelectiveSearchSegmentation.__fromPtr__(ximgproc_Ximgproc_createSelectiveSearchSegmentation_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyColor cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyColor()
        //

        //javadoc: createSelectiveSearchSegmentationStrategyColor()
        public static SelectiveSearchSegmentationStrategyColor createSelectiveSearchSegmentationStrategyColor()
        {
#if UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyColor retVal = SelectiveSearchSegmentationStrategyColor.__fromPtr__(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyColor_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyFill cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyFill()
        //

        //javadoc: createSelectiveSearchSegmentationStrategyFill()
        public static SelectiveSearchSegmentationStrategyFill createSelectiveSearchSegmentationStrategyFill()
        {
#if UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyFill retVal = SelectiveSearchSegmentationStrategyFill.__fromPtr__(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyFill_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3, Ptr_SelectiveSearchSegmentationStrategy s4)
        //

        //javadoc: createSelectiveSearchSegmentationStrategyMultiple(s1, s2, s3, s4)
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(SelectiveSearchSegmentationStrategy s1, SelectiveSearchSegmentationStrategy s2, SelectiveSearchSegmentationStrategy s3, SelectiveSearchSegmentationStrategy s4)
        {
            if (s1 != null) s1.ThrowIfDisposed();
            if (s2 != null) s2.ThrowIfDisposed();
            if (s3 != null) s3.ThrowIfDisposed();
            if (s4 != null) s4.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyMultiple retVal = SelectiveSearchSegmentationStrategyMultiple.__fromPtr__(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_10(s1.getNativeObjAddr(), s2.getNativeObjAddr(), s3.getNativeObjAddr(), s4.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3)
        //

        //javadoc: createSelectiveSearchSegmentationStrategyMultiple(s1, s2, s3)
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(SelectiveSearchSegmentationStrategy s1, SelectiveSearchSegmentationStrategy s2, SelectiveSearchSegmentationStrategy s3)
        {
            if (s1 != null) s1.ThrowIfDisposed();
            if (s2 != null) s2.ThrowIfDisposed();
            if (s3 != null) s3.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyMultiple retVal = SelectiveSearchSegmentationStrategyMultiple.__fromPtr__(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_11(s1.getNativeObjAddr(), s2.getNativeObjAddr(), s3.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2)
        //

        //javadoc: createSelectiveSearchSegmentationStrategyMultiple(s1, s2)
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(SelectiveSearchSegmentationStrategy s1, SelectiveSearchSegmentationStrategy s2)
        {
            if (s1 != null) s1.ThrowIfDisposed();
            if (s2 != null) s2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyMultiple retVal = SelectiveSearchSegmentationStrategyMultiple.__fromPtr__(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_12(s1.getNativeObjAddr(), s2.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1)
        //

        //javadoc: createSelectiveSearchSegmentationStrategyMultiple(s1)
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(SelectiveSearchSegmentationStrategy s1)
        {
            if (s1 != null) s1.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyMultiple retVal = SelectiveSearchSegmentationStrategyMultiple.__fromPtr__(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_13(s1.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple()
        //

        //javadoc: createSelectiveSearchSegmentationStrategyMultiple()
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple()
        {
#if UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyMultiple retVal = SelectiveSearchSegmentationStrategyMultiple.__fromPtr__(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_14());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategySize cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategySize()
        //

        //javadoc: createSelectiveSearchSegmentationStrategySize()
        public static SelectiveSearchSegmentationStrategySize createSelectiveSearchSegmentationStrategySize()
        {
#if UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategySize retVal = SelectiveSearchSegmentationStrategySize.__fromPtr__(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategySize_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyTexture cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyTexture()
        //

        //javadoc: createSelectiveSearchSegmentationStrategyTexture()
        public static SelectiveSearchSegmentationStrategyTexture createSelectiveSearchSegmentationStrategyTexture()
        {
#if UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyTexture retVal = SelectiveSearchSegmentationStrategyTexture.__fromPtr__(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyTexture_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_StereoMatcher cv::ximgproc::createRightMatcher(Ptr_StereoMatcher matcher_left)
        //

        //javadoc: createRightMatcher(matcher_left)
        public static StereoMatcher createRightMatcher(StereoMatcher matcher_left)
        {
            if (matcher_left != null) matcher_left.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        StereoMatcher retVal = StereoMatcher.__fromPtr__(ximgproc_Ximgproc_createRightMatcher_10(matcher_left.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_StructuredEdgeDetection cv::ximgproc::createStructuredEdgeDetection(String model, Ptr_RFFeatureGetter howToGetFeatures = Ptr<RFFeatureGetter>())
        //

        //javadoc: createStructuredEdgeDetection(model, howToGetFeatures)
        public static StructuredEdgeDetection createStructuredEdgeDetection(string model, RFFeatureGetter howToGetFeatures)
        {
            if (howToGetFeatures != null) howToGetFeatures.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        StructuredEdgeDetection retVal = StructuredEdgeDetection.__fromPtr__(ximgproc_Ximgproc_createStructuredEdgeDetection_10(model, howToGetFeatures.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createStructuredEdgeDetection(model)
        public static StructuredEdgeDetection createStructuredEdgeDetection(string model)
        {
#if UNITY_5_3_OR_NEWER
        
        StructuredEdgeDetection retVal = StructuredEdgeDetection.__fromPtr__(ximgproc_Ximgproc_createStructuredEdgeDetection_11(model));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SuperpixelLSC cv::ximgproc::createSuperpixelLSC(Mat image, int region_size = 10, float ratio = 0.075f)
        //

        //javadoc: createSuperpixelLSC(image, region_size, ratio)
        public static SuperpixelLSC createSuperpixelLSC(Mat image, int region_size, float ratio)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SuperpixelLSC retVal = SuperpixelLSC.__fromPtr__(ximgproc_Ximgproc_createSuperpixelLSC_10(image.nativeObj, region_size, ratio));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createSuperpixelLSC(image, region_size)
        public static SuperpixelLSC createSuperpixelLSC(Mat image, int region_size)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SuperpixelLSC retVal = SuperpixelLSC.__fromPtr__(ximgproc_Ximgproc_createSuperpixelLSC_11(image.nativeObj, region_size));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createSuperpixelLSC(image)
        public static SuperpixelLSC createSuperpixelLSC(Mat image)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SuperpixelLSC retVal = SuperpixelLSC.__fromPtr__(ximgproc_Ximgproc_createSuperpixelLSC_12(image.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SuperpixelSEEDS cv::ximgproc::createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior = 2, int histogram_bins = 5, bool double_step = false)
        //

        //javadoc: createSuperpixelSEEDS(image_width, image_height, image_channels, num_superpixels, num_levels, prior, histogram_bins, double_step)
        public static SuperpixelSEEDS createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior, int histogram_bins, bool double_step)
        {
#if UNITY_5_3_OR_NEWER
        
        SuperpixelSEEDS retVal = SuperpixelSEEDS.__fromPtr__(ximgproc_Ximgproc_createSuperpixelSEEDS_10(image_width, image_height, image_channels, num_superpixels, num_levels, prior, histogram_bins, double_step));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createSuperpixelSEEDS(image_width, image_height, image_channels, num_superpixels, num_levels, prior, histogram_bins)
        public static SuperpixelSEEDS createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior, int histogram_bins)
        {
#if UNITY_5_3_OR_NEWER
        
        SuperpixelSEEDS retVal = SuperpixelSEEDS.__fromPtr__(ximgproc_Ximgproc_createSuperpixelSEEDS_11(image_width, image_height, image_channels, num_superpixels, num_levels, prior, histogram_bins));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createSuperpixelSEEDS(image_width, image_height, image_channels, num_superpixels, num_levels, prior)
        public static SuperpixelSEEDS createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior)
        {
#if UNITY_5_3_OR_NEWER
        
        SuperpixelSEEDS retVal = SuperpixelSEEDS.__fromPtr__(ximgproc_Ximgproc_createSuperpixelSEEDS_12(image_width, image_height, image_channels, num_superpixels, num_levels, prior));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createSuperpixelSEEDS(image_width, image_height, image_channels, num_superpixels, num_levels)
        public static SuperpixelSEEDS createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels)
        {
#if UNITY_5_3_OR_NEWER
        
        SuperpixelSEEDS retVal = SuperpixelSEEDS.__fromPtr__(ximgproc_Ximgproc_createSuperpixelSEEDS_13(image_width, image_height, image_channels, num_superpixels, num_levels));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SuperpixelSLIC cv::ximgproc::createSuperpixelSLIC(Mat image, int algorithm = SLICO, int region_size = 10, float ruler = 10.0f)
        //

        //javadoc: createSuperpixelSLIC(image, algorithm, region_size, ruler)
        public static SuperpixelSLIC createSuperpixelSLIC(Mat image, int algorithm, int region_size, float ruler)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SuperpixelSLIC retVal = SuperpixelSLIC.__fromPtr__(ximgproc_Ximgproc_createSuperpixelSLIC_10(image.nativeObj, algorithm, region_size, ruler));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createSuperpixelSLIC(image, algorithm, region_size)
        public static SuperpixelSLIC createSuperpixelSLIC(Mat image, int algorithm, int region_size)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SuperpixelSLIC retVal = SuperpixelSLIC.__fromPtr__(ximgproc_Ximgproc_createSuperpixelSLIC_11(image.nativeObj, algorithm, region_size));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createSuperpixelSLIC(image, algorithm)
        public static SuperpixelSLIC createSuperpixelSLIC(Mat image, int algorithm)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SuperpixelSLIC retVal = SuperpixelSLIC.__fromPtr__(ximgproc_Ximgproc_createSuperpixelSLIC_12(image.nativeObj, algorithm));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createSuperpixelSLIC(image)
        public static SuperpixelSLIC createSuperpixelSLIC(Mat image)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SuperpixelSLIC retVal = SuperpixelSLIC.__fromPtr__(ximgproc_Ximgproc_createSuperpixelSLIC_13(image.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Vec4i cv::ximgproc::HoughPoint2Line(Point houghPoint, Mat srcImgInfo, int angleRange = ARO_315_135, int makeSkew = HDO_DESKEW, int rules = RO_IGNORE_BORDERS)
        //

        // Return type 'Vec4i' is not supported, skipping the function


        //
        // C++:  void cv::ximgproc::FastHoughTransform(Mat src, Mat& dst, int dstMatDepth, int angleRange = ARO_315_135, int op = FHT_ADD, int makeSkew = HDO_DESKEW)
        //

        //javadoc: FastHoughTransform(src, dst, dstMatDepth, angleRange, op, makeSkew)
        public static void FastHoughTransform(Mat src, Mat dst, int dstMatDepth, int angleRange, int op, int makeSkew)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_FastHoughTransform_10(src.nativeObj, dst.nativeObj, dstMatDepth, angleRange, op, makeSkew);
        
        return;
#else
            return;
#endif
        }

        //javadoc: FastHoughTransform(src, dst, dstMatDepth, angleRange, op)
        public static void FastHoughTransform(Mat src, Mat dst, int dstMatDepth, int angleRange, int op)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_FastHoughTransform_11(src.nativeObj, dst.nativeObj, dstMatDepth, angleRange, op);
        
        return;
#else
            return;
#endif
        }

        //javadoc: FastHoughTransform(src, dst, dstMatDepth, angleRange)
        public static void FastHoughTransform(Mat src, Mat dst, int dstMatDepth, int angleRange)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_FastHoughTransform_12(src.nativeObj, dst.nativeObj, dstMatDepth, angleRange);
        
        return;
#else
            return;
#endif
        }

        //javadoc: FastHoughTransform(src, dst, dstMatDepth)
        public static void FastHoughTransform(Mat src, Mat dst, int dstMatDepth)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_FastHoughTransform_13(src.nativeObj, dst.nativeObj, dstMatDepth);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::GradientDericheX(Mat op, Mat& dst, double alpha, double omega)
        //

        //javadoc: GradientDericheX(op, dst, alpha, omega)
        public static void GradientDericheX(Mat op, Mat dst, double alpha, double omega)
        {
            if (op != null) op.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_GradientDericheX_10(op.nativeObj, dst.nativeObj, alpha, omega);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::GradientDericheY(Mat op, Mat& dst, double alpha, double omega)
        //

        //javadoc: GradientDericheY(op, dst, alpha, omega)
        public static void GradientDericheY(Mat op, Mat dst, double alpha, double omega)
        {
            if (op != null) op.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_GradientDericheY_10(op.nativeObj, dst.nativeObj, alpha, omega);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::PeiLinNormalization(Mat I, Mat& T)
        //

        //javadoc: PeiLinNormalization(I, T)
        public static void PeiLinNormalization(Mat I, Mat T)
        {
            if (I != null) I.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_PeiLinNormalization_10(I.nativeObj, T.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::amFilter(Mat joint, Mat src, Mat& dst, double sigma_s, double sigma_r, bool adjust_outliers = false)
        //

        //javadoc: amFilter(joint, src, dst, sigma_s, sigma_r, adjust_outliers)
        public static void amFilter(Mat joint, Mat src, Mat dst, double sigma_s, double sigma_r, bool adjust_outliers)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_amFilter_10(joint.nativeObj, src.nativeObj, dst.nativeObj, sigma_s, sigma_r, adjust_outliers);
        
        return;
#else
            return;
#endif
        }

        //javadoc: amFilter(joint, src, dst, sigma_s, sigma_r)
        public static void amFilter(Mat joint, Mat src, Mat dst, double sigma_s, double sigma_r)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_amFilter_11(joint.nativeObj, src.nativeObj, dst.nativeObj, sigma_s, sigma_r);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::anisotropicDiffusion(Mat src, Mat& dst, float alpha, float K, int niters)
        //

        //javadoc: anisotropicDiffusion(src, dst, alpha, K, niters)
        public static void anisotropicDiffusion(Mat src, Mat dst, float alpha, float K, int niters)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_anisotropicDiffusion_10(src.nativeObj, dst.nativeObj, alpha, K, niters);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::bilateralTextureFilter(Mat src, Mat& dst, int fr = 3, int numIter = 1, double sigmaAlpha = -1., double sigmaAvg = -1.)
        //

        //javadoc: bilateralTextureFilter(src, dst, fr, numIter, sigmaAlpha, sigmaAvg)
        public static void bilateralTextureFilter(Mat src, Mat dst, int fr, int numIter, double sigmaAlpha, double sigmaAvg)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_bilateralTextureFilter_10(src.nativeObj, dst.nativeObj, fr, numIter, sigmaAlpha, sigmaAvg);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bilateralTextureFilter(src, dst, fr, numIter, sigmaAlpha)
        public static void bilateralTextureFilter(Mat src, Mat dst, int fr, int numIter, double sigmaAlpha)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_bilateralTextureFilter_11(src.nativeObj, dst.nativeObj, fr, numIter, sigmaAlpha);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bilateralTextureFilter(src, dst, fr, numIter)
        public static void bilateralTextureFilter(Mat src, Mat dst, int fr, int numIter)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_bilateralTextureFilter_12(src.nativeObj, dst.nativeObj, fr, numIter);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bilateralTextureFilter(src, dst, fr)
        public static void bilateralTextureFilter(Mat src, Mat dst, int fr)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_bilateralTextureFilter_13(src.nativeObj, dst.nativeObj, fr);
        
        return;
#else
            return;
#endif
        }

        //javadoc: bilateralTextureFilter(src, dst)
        public static void bilateralTextureFilter(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_bilateralTextureFilter_14(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::colorMatchTemplate(Mat img, Mat templ, Mat& result)
        //

        //javadoc: colorMatchTemplate(img, templ, result)
        public static void colorMatchTemplate(Mat img, Mat templ, Mat result)
        {
            if (img != null) img.ThrowIfDisposed();
            if (templ != null) templ.ThrowIfDisposed();
            if (result != null) result.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_colorMatchTemplate_10(img.nativeObj, templ.nativeObj, result.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::contourSampling(Mat src, Mat& _out, int nbElt)
        //

        //javadoc: contourSampling(src, _out, nbElt)
        public static void contourSampling(Mat src, Mat _out, int nbElt)
        {
            if (src != null) src.ThrowIfDisposed();
            if (_out != null) _out.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_contourSampling_10(src.nativeObj, _out.nativeObj, nbElt);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::covarianceEstimation(Mat src, Mat& dst, int windowRows, int windowCols)
        //

        //javadoc: covarianceEstimation(src, dst, windowRows, windowCols)
        public static void covarianceEstimation(Mat src, Mat dst, int windowRows, int windowCols)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_covarianceEstimation_10(src.nativeObj, dst.nativeObj, windowRows, windowCols);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::createQuaternionImage(Mat img, Mat& qimg)
        //

        //javadoc: createQuaternionImage(img, qimg)
        public static void createQuaternionImage(Mat img, Mat qimg)
        {
            if (img != null) img.ThrowIfDisposed();
            if (qimg != null) qimg.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_createQuaternionImage_10(img.nativeObj, qimg.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::dtFilter(Mat guide, Mat src, Mat& dst, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        //

        //javadoc: dtFilter(guide, src, dst, sigmaSpatial, sigmaColor, mode, numIters)
        public static void dtFilter(Mat guide, Mat src, Mat dst, double sigmaSpatial, double sigmaColor, int mode, int numIters)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_dtFilter_10(guide.nativeObj, src.nativeObj, dst.nativeObj, sigmaSpatial, sigmaColor, mode, numIters);
        
        return;
#else
            return;
#endif
        }

        //javadoc: dtFilter(guide, src, dst, sigmaSpatial, sigmaColor, mode)
        public static void dtFilter(Mat guide, Mat src, Mat dst, double sigmaSpatial, double sigmaColor, int mode)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_dtFilter_11(guide.nativeObj, src.nativeObj, dst.nativeObj, sigmaSpatial, sigmaColor, mode);
        
        return;
#else
            return;
#endif
        }

        //javadoc: dtFilter(guide, src, dst, sigmaSpatial, sigmaColor)
        public static void dtFilter(Mat guide, Mat src, Mat dst, double sigmaSpatial, double sigmaColor)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_dtFilter_12(guide.nativeObj, src.nativeObj, dst.nativeObj, sigmaSpatial, sigmaColor);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::edgePreservingFilter(Mat src, Mat& dst, int d, double threshold)
        //

        //javadoc: edgePreservingFilter(src, dst, d, threshold)
        public static void edgePreservingFilter(Mat src, Mat dst, int d, double threshold)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_edgePreservingFilter_10(src.nativeObj, dst.nativeObj, d, threshold);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat& dst, double sigma_spatial = 8, double sigma_luma = 8, double sigma_chroma = 8, double lambda = 128.0, int num_iter = 25, double max_tol = 1e-5)
        //

        //javadoc: fastBilateralSolverFilter(guide, src, confidence, dst, sigma_spatial, sigma_luma, sigma_chroma, lambda, num_iter, max_tol)
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter, double max_tol)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fastBilateralSolverFilter_10(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj, sigma_spatial, sigma_luma, sigma_chroma, lambda, num_iter, max_tol);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastBilateralSolverFilter(guide, src, confidence, dst, sigma_spatial, sigma_luma, sigma_chroma, lambda, num_iter)
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fastBilateralSolverFilter_11(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj, sigma_spatial, sigma_luma, sigma_chroma, lambda, num_iter);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastBilateralSolverFilter(guide, src, confidence, dst, sigma_spatial, sigma_luma, sigma_chroma, lambda)
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fastBilateralSolverFilter_12(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj, sigma_spatial, sigma_luma, sigma_chroma, lambda);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastBilateralSolverFilter(guide, src, confidence, dst, sigma_spatial, sigma_luma, sigma_chroma)
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst, double sigma_spatial, double sigma_luma, double sigma_chroma)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fastBilateralSolverFilter_13(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj, sigma_spatial, sigma_luma, sigma_chroma);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastBilateralSolverFilter(guide, src, confidence, dst, sigma_spatial, sigma_luma)
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst, double sigma_spatial, double sigma_luma)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fastBilateralSolverFilter_14(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj, sigma_spatial, sigma_luma);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastBilateralSolverFilter(guide, src, confidence, dst, sigma_spatial)
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst, double sigma_spatial)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fastBilateralSolverFilter_15(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj, sigma_spatial);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastBilateralSolverFilter(guide, src, confidence, dst)
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fastBilateralSolverFilter_16(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::fastGlobalSmootherFilter(Mat guide, Mat src, Mat& dst, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        //

        //javadoc: fastGlobalSmootherFilter(guide, src, dst, lambda, sigma_color, lambda_attenuation, num_iter)
        public static void fastGlobalSmootherFilter(Mat guide, Mat src, Mat dst, double lambda, double sigma_color, double lambda_attenuation, int num_iter)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fastGlobalSmootherFilter_10(guide.nativeObj, src.nativeObj, dst.nativeObj, lambda, sigma_color, lambda_attenuation, num_iter);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastGlobalSmootherFilter(guide, src, dst, lambda, sigma_color, lambda_attenuation)
        public static void fastGlobalSmootherFilter(Mat guide, Mat src, Mat dst, double lambda, double sigma_color, double lambda_attenuation)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fastGlobalSmootherFilter_11(guide.nativeObj, src.nativeObj, dst.nativeObj, lambda, sigma_color, lambda_attenuation);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fastGlobalSmootherFilter(guide, src, dst, lambda, sigma_color)
        public static void fastGlobalSmootherFilter(Mat guide, Mat src, Mat dst, double lambda, double sigma_color)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fastGlobalSmootherFilter_12(guide.nativeObj, src.nativeObj, dst.nativeObj, lambda, sigma_color);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::fourierDescriptor(Mat src, Mat& dst, int nbElt = -1, int nbFD = -1)
        //

        //javadoc: fourierDescriptor(src, dst, nbElt, nbFD)
        public static void fourierDescriptor(Mat src, Mat dst, int nbElt, int nbFD)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fourierDescriptor_10(src.nativeObj, dst.nativeObj, nbElt, nbFD);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fourierDescriptor(src, dst, nbElt)
        public static void fourierDescriptor(Mat src, Mat dst, int nbElt)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fourierDescriptor_11(src.nativeObj, dst.nativeObj, nbElt);
        
        return;
#else
            return;
#endif
        }

        //javadoc: fourierDescriptor(src, dst)
        public static void fourierDescriptor(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fourierDescriptor_12(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::guidedFilter(Mat guide, Mat src, Mat& dst, int radius, double eps, int dDepth = -1)
        //

        //javadoc: guidedFilter(guide, src, dst, radius, eps, dDepth)
        public static void guidedFilter(Mat guide, Mat src, Mat dst, int radius, double eps, int dDepth)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_guidedFilter_10(guide.nativeObj, src.nativeObj, dst.nativeObj, radius, eps, dDepth);
        
        return;
#else
            return;
#endif
        }

        //javadoc: guidedFilter(guide, src, dst, radius, eps)
        public static void guidedFilter(Mat guide, Mat src, Mat dst, int radius, double eps)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_guidedFilter_11(guide.nativeObj, src.nativeObj, dst.nativeObj, radius, eps);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::jointBilateralFilter(Mat joint, Mat src, Mat& dst, int d, double sigmaColor, double sigmaSpace, int borderType = BORDER_DEFAULT)
        //

        //javadoc: jointBilateralFilter(joint, src, dst, d, sigmaColor, sigmaSpace, borderType)
        public static void jointBilateralFilter(Mat joint, Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, int borderType)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_jointBilateralFilter_10(joint.nativeObj, src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace, borderType);
        
        return;
#else
            return;
#endif
        }

        //javadoc: jointBilateralFilter(joint, src, dst, d, sigmaColor, sigmaSpace)
        public static void jointBilateralFilter(Mat joint, Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_jointBilateralFilter_11(joint.nativeObj, src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::l0Smooth(Mat src, Mat& dst, double lambda = 0.02, double kappa = 2.0)
        //

        //javadoc: l0Smooth(src, dst, lambda, kappa)
        public static void l0Smooth(Mat src, Mat dst, double lambda, double kappa)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_l0Smooth_10(src.nativeObj, dst.nativeObj, lambda, kappa);
        
        return;
#else
            return;
#endif
        }

        //javadoc: l0Smooth(src, dst, lambda)
        public static void l0Smooth(Mat src, Mat dst, double lambda)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_l0Smooth_11(src.nativeObj, dst.nativeObj, lambda);
        
        return;
#else
            return;
#endif
        }

        //javadoc: l0Smooth(src, dst)
        public static void l0Smooth(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_l0Smooth_12(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::niBlackThreshold(Mat _src, Mat& _dst, double maxValue, int type, int blockSize, double k, int binarizationMethod = BINARIZATION_NIBLACK)
        //

        //javadoc: niBlackThreshold(_src, _dst, maxValue, type, blockSize, k, binarizationMethod)
        public static void niBlackThreshold(Mat _src, Mat _dst, double maxValue, int type, int blockSize, double k, int binarizationMethod)
        {
            if (_src != null) _src.ThrowIfDisposed();
            if (_dst != null) _dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_niBlackThreshold_10(_src.nativeObj, _dst.nativeObj, maxValue, type, blockSize, k, binarizationMethod);
        
        return;
#else
            return;
#endif
        }

        //javadoc: niBlackThreshold(_src, _dst, maxValue, type, blockSize, k)
        public static void niBlackThreshold(Mat _src, Mat _dst, double maxValue, int type, int blockSize, double k)
        {
            if (_src != null) _src.ThrowIfDisposed();
            if (_dst != null) _dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_niBlackThreshold_11(_src.nativeObj, _dst.nativeObj, maxValue, type, blockSize, k);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::qconj(Mat qimg, Mat& qcimg)
        //

        //javadoc: qconj(qimg, qcimg)
        public static void qconj(Mat qimg, Mat qcimg)
        {
            if (qimg != null) qimg.ThrowIfDisposed();
            if (qcimg != null) qcimg.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_qconj_10(qimg.nativeObj, qcimg.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::qdft(Mat img, Mat& qimg, int flags, bool sideLeft)
        //

        //javadoc: qdft(img, qimg, flags, sideLeft)
        public static void qdft(Mat img, Mat qimg, int flags, bool sideLeft)
        {
            if (img != null) img.ThrowIfDisposed();
            if (qimg != null) qimg.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_qdft_10(img.nativeObj, qimg.nativeObj, flags, sideLeft);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::qmultiply(Mat src1, Mat src2, Mat& dst)
        //

        //javadoc: qmultiply(src1, src2, dst)
        public static void qmultiply(Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_qmultiply_10(src1.nativeObj, src2.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::qunitary(Mat qimg, Mat& qnimg)
        //

        //javadoc: qunitary(qimg, qnimg)
        public static void qunitary(Mat qimg, Mat qnimg)
        {
            if (qimg != null) qimg.ThrowIfDisposed();
            if (qnimg != null) qnimg.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_qunitary_10(qimg.nativeObj, qnimg.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::rollingGuidanceFilter(Mat src, Mat& dst, int d = -1, double sigmaColor = 25, double sigmaSpace = 3, int numOfIter = 4, int borderType = BORDER_DEFAULT)
        //

        //javadoc: rollingGuidanceFilter(src, dst, d, sigmaColor, sigmaSpace, numOfIter, borderType)
        public static void rollingGuidanceFilter(Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, int numOfIter, int borderType)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_rollingGuidanceFilter_10(src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace, numOfIter, borderType);
        
        return;
#else
            return;
#endif
        }

        //javadoc: rollingGuidanceFilter(src, dst, d, sigmaColor, sigmaSpace, numOfIter)
        public static void rollingGuidanceFilter(Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, int numOfIter)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_rollingGuidanceFilter_11(src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace, numOfIter);
        
        return;
#else
            return;
#endif
        }

        //javadoc: rollingGuidanceFilter(src, dst, d, sigmaColor, sigmaSpace)
        public static void rollingGuidanceFilter(Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_rollingGuidanceFilter_12(src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace);
        
        return;
#else
            return;
#endif
        }

        //javadoc: rollingGuidanceFilter(src, dst, d, sigmaColor)
        public static void rollingGuidanceFilter(Mat src, Mat dst, int d, double sigmaColor)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_rollingGuidanceFilter_13(src.nativeObj, dst.nativeObj, d, sigmaColor);
        
        return;
#else
            return;
#endif
        }

        //javadoc: rollingGuidanceFilter(src, dst, d)
        public static void rollingGuidanceFilter(Mat src, Mat dst, int d)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_rollingGuidanceFilter_14(src.nativeObj, dst.nativeObj, d);
        
        return;
#else
            return;
#endif
        }

        //javadoc: rollingGuidanceFilter(src, dst)
        public static void rollingGuidanceFilter(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_rollingGuidanceFilter_15(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::thinning(Mat src, Mat& dst, int thinningType = THINNING_ZHANGSUEN)
        //

        //javadoc: thinning(src, dst, thinningType)
        public static void thinning(Mat src, Mat dst, int thinningType)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_thinning_10(src.nativeObj, dst.nativeObj, thinningType);
        
        return;
#else
            return;
#endif
        }

        //javadoc: thinning(src, dst)
        public static void thinning(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_thinning_11(src.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::transformFD(Mat src, Mat t, Mat& dst, bool fdContour = true)
        //

        //javadoc: transformFD(src, t, dst, fdContour)
        public static void transformFD(Mat src, Mat t, Mat dst, bool fdContour)
        {
            if (src != null) src.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_transformFD_10(src.nativeObj, t.nativeObj, dst.nativeObj, fdContour);
        
        return;
#else
            return;
#endif
        }

        //javadoc: transformFD(src, t, dst)
        public static void transformFD(Mat src, Mat t, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_transformFD_11(src.nativeObj, t.nativeObj, dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::weightedMedianFilter(Mat joint, Mat src, Mat& dst, int r, double sigma = 25.5, int weightType = WMF_EXP, Mat mask = Mat())
        //

        //javadoc: weightedMedianFilter(joint, src, dst, r, sigma, weightType, mask)
        public static void weightedMedianFilter(Mat joint, Mat src, Mat dst, int r, double sigma, int weightType, Mat mask)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_weightedMedianFilter_10(joint.nativeObj, src.nativeObj, dst.nativeObj, r, sigma, weightType, mask.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: weightedMedianFilter(joint, src, dst, r, sigma, weightType)
        public static void weightedMedianFilter(Mat joint, Mat src, Mat dst, int r, double sigma, int weightType)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_weightedMedianFilter_11(joint.nativeObj, src.nativeObj, dst.nativeObj, r, sigma, weightType);
        
        return;
#else
            return;
#endif
        }

        //javadoc: weightedMedianFilter(joint, src, dst, r, sigma)
        public static void weightedMedianFilter(Mat joint, Mat src, Mat dst, int r, double sigma)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_weightedMedianFilter_12(joint.nativeObj, src.nativeObj, dst.nativeObj, r, sigma);
        
        return;
#else
            return;
#endif
        }

        //javadoc: weightedMedianFilter(joint, src, dst, r)
        public static void weightedMedianFilter(Mat joint, Mat src, Mat dst, int r)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_weightedMedianFilter_13(joint.nativeObj, src.nativeObj, dst.nativeObj, r);
        
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



        // C++:  Ptr_AdaptiveManifoldFilter cv::ximgproc::createAMFilter(double sigma_s, double sigma_r, bool adjust_outliers = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createAMFilter_10(double sigma_s, double sigma_r, [MarshalAs(UnmanagedType.U1)] bool adjust_outliers);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createAMFilter_11(double sigma_s, double sigma_r);

        // C++:  Ptr_ContourFitting cv::ximgproc::createContourFitting(int ctr = 1024, int fd = 16)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createContourFitting_10(int ctr, int fd);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createContourFitting_11(int ctr);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createContourFitting_12();

        // C++:  Ptr_DTFilter cv::ximgproc::createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDTFilter_10(IntPtr guide_nativeObj, double sigmaSpatial, double sigmaColor, int mode, int numIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDTFilter_11(IntPtr guide_nativeObj, double sigmaSpatial, double sigmaColor, int mode);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDTFilter_12(IntPtr guide_nativeObj, double sigmaSpatial, double sigmaColor);

        // C++:  Ptr_DisparityWLSFilter cv::ximgproc::createDisparityWLSFilter(Ptr_StereoMatcher matcher_left)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDisparityWLSFilter_10(IntPtr matcher_left_nativeObj);

        // C++:  Ptr_DisparityWLSFilter cv::ximgproc::createDisparityWLSFilterGeneric(bool use_confidence)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDisparityWLSFilterGeneric_10([MarshalAs(UnmanagedType.U1)] bool use_confidence);

        // C++:  Ptr_EdgeAwareInterpolator cv::ximgproc::createEdgeAwareInterpolator()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeAwareInterpolator_10();

        // C++:  Ptr_EdgeBoxes cv::ximgproc::createEdgeBoxes(float alpha = 0.65f, float beta = 0.75f, float eta = 1, float minScore = 0.01f, int maxBoxes = 10000, float edgeMinMag = 0.1f, float edgeMergeThr = 0.5f, float clusterMinMag = 0.5f, float maxAspectRatio = 3, float minBoxArea = 1000, float gamma = 2, float kappa = 1.5f)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_10(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea, float gamma, float kappa);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_11(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea, float gamma);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_12(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_13(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_14(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_15(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_16(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_17(float alpha, float beta, float eta, float minScore, int maxBoxes);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_18(float alpha, float beta, float eta, float minScore);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_19(float alpha, float beta, float eta);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_110(float alpha, float beta);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_111(float alpha);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_112();

        // C++:  Ptr_FastBilateralSolverFilter cv::ximgproc::createFastBilateralSolverFilter(Mat guide, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda = 128.0, int num_iter = 25, double max_tol = 1e-5)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastBilateralSolverFilter_10(IntPtr guide_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter, double max_tol);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastBilateralSolverFilter_11(IntPtr guide_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastBilateralSolverFilter_12(IntPtr guide_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastBilateralSolverFilter_13(IntPtr guide_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma);

        // C++:  Ptr_FastGlobalSmootherFilter cv::ximgproc::createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastGlobalSmootherFilter_10(IntPtr guide_nativeObj, double lambda, double sigma_color, double lambda_attenuation, int num_iter);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastGlobalSmootherFilter_11(IntPtr guide_nativeObj, double lambda, double sigma_color, double lambda_attenuation);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastGlobalSmootherFilter_12(IntPtr guide_nativeObj, double lambda, double sigma_color);

        // C++:  Ptr_FastLineDetector cv::ximgproc::createFastLineDetector(int _length_threshold = 10, float _distance_threshold = 1.414213562f, double _canny_th1 = 50.0, double _canny_th2 = 50.0, int _canny_aperture_size = 3, bool _do_merge = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_10(int _length_threshold, float _distance_threshold, double _canny_th1, double _canny_th2, int _canny_aperture_size, [MarshalAs(UnmanagedType.U1)] bool _do_merge);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_11(int _length_threshold, float _distance_threshold, double _canny_th1, double _canny_th2, int _canny_aperture_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_12(int _length_threshold, float _distance_threshold, double _canny_th1, double _canny_th2);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_13(int _length_threshold, float _distance_threshold, double _canny_th1);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_14(int _length_threshold, float _distance_threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_15(int _length_threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_16();

        // C++:  Ptr_GraphSegmentation cv::ximgproc::segmentation::createGraphSegmentation(double sigma = 0.5, float k = 300, int min_size = 100)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGraphSegmentation_10(double sigma, float k, int min_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGraphSegmentation_11(double sigma, float k);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGraphSegmentation_12(double sigma);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGraphSegmentation_13();

        // C++:  Ptr_GuidedFilter cv::ximgproc::createGuidedFilter(Mat guide, int radius, double eps)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGuidedFilter_10(IntPtr guide_nativeObj, int radius, double eps);

        // C++:  Ptr_RFFeatureGetter cv::ximgproc::createRFFeatureGetter()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createRFFeatureGetter_10();

        // C++:  Ptr_SelectiveSearchSegmentation cv::ximgproc::segmentation::createSelectiveSearchSegmentation()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentation_10();

        // C++:  Ptr_SelectiveSearchSegmentationStrategyColor cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyColor()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyColor_10();

        // C++:  Ptr_SelectiveSearchSegmentationStrategyFill cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyFill()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyFill_10();

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3, Ptr_SelectiveSearchSegmentationStrategy s4)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_10(IntPtr s1_nativeObj, IntPtr s2_nativeObj, IntPtr s3_nativeObj, IntPtr s4_nativeObj);

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_11(IntPtr s1_nativeObj, IntPtr s2_nativeObj, IntPtr s3_nativeObj);

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_12(IntPtr s1_nativeObj, IntPtr s2_nativeObj);

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_13(IntPtr s1_nativeObj);

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_14();

        // C++:  Ptr_SelectiveSearchSegmentationStrategySize cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategySize()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategySize_10();

        // C++:  Ptr_SelectiveSearchSegmentationStrategyTexture cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyTexture()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyTexture_10();

        // C++:  Ptr_StereoMatcher cv::ximgproc::createRightMatcher(Ptr_StereoMatcher matcher_left)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createRightMatcher_10(IntPtr matcher_left_nativeObj);

        // C++:  Ptr_StructuredEdgeDetection cv::ximgproc::createStructuredEdgeDetection(String model, Ptr_RFFeatureGetter howToGetFeatures = Ptr<RFFeatureGetter>())
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createStructuredEdgeDetection_10(string model, IntPtr howToGetFeatures_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createStructuredEdgeDetection_11(string model);

        // C++:  Ptr_SuperpixelLSC cv::ximgproc::createSuperpixelLSC(Mat image, int region_size = 10, float ratio = 0.075f)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelLSC_10(IntPtr image_nativeObj, int region_size, float ratio);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelLSC_11(IntPtr image_nativeObj, int region_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelLSC_12(IntPtr image_nativeObj);

        // C++:  Ptr_SuperpixelSEEDS cv::ximgproc::createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior = 2, int histogram_bins = 5, bool double_step = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSEEDS_10(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior, int histogram_bins, [MarshalAs(UnmanagedType.U1)] bool double_step);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSEEDS_11(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior, int histogram_bins);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSEEDS_12(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSEEDS_13(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels);

        // C++:  Ptr_SuperpixelSLIC cv::ximgproc::createSuperpixelSLIC(Mat image, int algorithm = SLICO, int region_size = 10, float ruler = 10.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSLIC_10(IntPtr image_nativeObj, int algorithm, int region_size, float ruler);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSLIC_11(IntPtr image_nativeObj, int algorithm, int region_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSLIC_12(IntPtr image_nativeObj, int algorithm);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSLIC_13(IntPtr image_nativeObj);

        // C++:  void cv::ximgproc::FastHoughTransform(Mat src, Mat& dst, int dstMatDepth, int angleRange = ARO_315_135, int op = FHT_ADD, int makeSkew = HDO_DESKEW)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_FastHoughTransform_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int dstMatDepth, int angleRange, int op, int makeSkew);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_FastHoughTransform_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int dstMatDepth, int angleRange, int op);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_FastHoughTransform_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, int dstMatDepth, int angleRange);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_FastHoughTransform_13(IntPtr src_nativeObj, IntPtr dst_nativeObj, int dstMatDepth);

        // C++:  void cv::ximgproc::GradientDericheX(Mat op, Mat& dst, double alpha, double omega)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_GradientDericheX_10(IntPtr op_nativeObj, IntPtr dst_nativeObj, double alpha, double omega);

        // C++:  void cv::ximgproc::GradientDericheY(Mat op, Mat& dst, double alpha, double omega)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_GradientDericheY_10(IntPtr op_nativeObj, IntPtr dst_nativeObj, double alpha, double omega);

        // C++:  void cv::ximgproc::PeiLinNormalization(Mat I, Mat& T)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_PeiLinNormalization_10(IntPtr I_nativeObj, IntPtr T_nativeObj);

        // C++:  void cv::ximgproc::amFilter(Mat joint, Mat src, Mat& dst, double sigma_s, double sigma_r, bool adjust_outliers = false)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_amFilter_10(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma_s, double sigma_r, [MarshalAs(UnmanagedType.U1)] bool adjust_outliers);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_amFilter_11(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma_s, double sigma_r);

        // C++:  void cv::ximgproc::anisotropicDiffusion(Mat src, Mat& dst, float alpha, float K, int niters)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_anisotropicDiffusion_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float alpha, float K, int niters);

        // C++:  void cv::ximgproc::bilateralTextureFilter(Mat src, Mat& dst, int fr = 3, int numIter = 1, double sigmaAlpha = -1., double sigmaAvg = -1.)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int fr, int numIter, double sigmaAlpha, double sigmaAvg);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int fr, int numIter, double sigmaAlpha);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, int fr, int numIter);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_13(IntPtr src_nativeObj, IntPtr dst_nativeObj, int fr);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_14(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::colorMatchTemplate(Mat img, Mat templ, Mat& result)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_colorMatchTemplate_10(IntPtr img_nativeObj, IntPtr templ_nativeObj, IntPtr result_nativeObj);

        // C++:  void cv::ximgproc::contourSampling(Mat src, Mat& _out, int nbElt)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_contourSampling_10(IntPtr src_nativeObj, IntPtr _out_nativeObj, int nbElt);

        // C++:  void cv::ximgproc::covarianceEstimation(Mat src, Mat& dst, int windowRows, int windowCols)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_covarianceEstimation_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int windowRows, int windowCols);

        // C++:  void cv::ximgproc::createQuaternionImage(Mat img, Mat& qimg)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_createQuaternionImage_10(IntPtr img_nativeObj, IntPtr qimg_nativeObj);

        // C++:  void cv::ximgproc::dtFilter(Mat guide, Mat src, Mat& dst, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_dtFilter_10(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigmaSpatial, double sigmaColor, int mode, int numIters);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_dtFilter_11(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigmaSpatial, double sigmaColor, int mode);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_dtFilter_12(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigmaSpatial, double sigmaColor);

        // C++:  void cv::ximgproc::edgePreservingFilter(Mat src, Mat& dst, int d, double threshold)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_edgePreservingFilter_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double threshold);

        // C++:  void cv::ximgproc::fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat& dst, double sigma_spatial = 8, double sigma_luma = 8, double sigma_chroma = 8, double lambda = 128.0, int num_iter = 25, double max_tol = 1e-5)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_10(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter, double max_tol);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_11(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_12(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_13(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_14(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj, double sigma_spatial, double sigma_luma);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_15(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj, double sigma_spatial);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_16(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::fastGlobalSmootherFilter(Mat guide, Mat src, Mat& dst, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastGlobalSmootherFilter_10(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double sigma_color, double lambda_attenuation, int num_iter);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastGlobalSmootherFilter_11(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double sigma_color, double lambda_attenuation);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastGlobalSmootherFilter_12(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double sigma_color);

        // C++:  void cv::ximgproc::fourierDescriptor(Mat src, Mat& dst, int nbElt = -1, int nbFD = -1)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fourierDescriptor_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int nbElt, int nbFD);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fourierDescriptor_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int nbElt);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fourierDescriptor_12(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::guidedFilter(Mat guide, Mat src, Mat& dst, int radius, double eps, int dDepth = -1)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_guidedFilter_10(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int radius, double eps, int dDepth);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_guidedFilter_11(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int radius, double eps);

        // C++:  void cv::ximgproc::jointBilateralFilter(Mat joint, Mat src, Mat& dst, int d, double sigmaColor, double sigmaSpace, int borderType = BORDER_DEFAULT)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_jointBilateralFilter_10(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int borderType);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_jointBilateralFilter_11(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace);

        // C++:  void cv::ximgproc::l0Smooth(Mat src, Mat& dst, double lambda = 0.02, double kappa = 2.0)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_l0Smooth_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double kappa);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_l0Smooth_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_l0Smooth_12(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::niBlackThreshold(Mat _src, Mat& _dst, double maxValue, int type, int blockSize, double k, int binarizationMethod = BINARIZATION_NIBLACK)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_niBlackThreshold_10(IntPtr _src_nativeObj, IntPtr _dst_nativeObj, double maxValue, int type, int blockSize, double k, int binarizationMethod);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_niBlackThreshold_11(IntPtr _src_nativeObj, IntPtr _dst_nativeObj, double maxValue, int type, int blockSize, double k);

        // C++:  void cv::ximgproc::qconj(Mat qimg, Mat& qcimg)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_qconj_10(IntPtr qimg_nativeObj, IntPtr qcimg_nativeObj);

        // C++:  void cv::ximgproc::qdft(Mat img, Mat& qimg, int flags, bool sideLeft)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_qdft_10(IntPtr img_nativeObj, IntPtr qimg_nativeObj, int flags, [MarshalAs(UnmanagedType.U1)] bool sideLeft);

        // C++:  void cv::ximgproc::qmultiply(Mat src1, Mat src2, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_qmultiply_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::qunitary(Mat qimg, Mat& qnimg)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_qunitary_10(IntPtr qimg_nativeObj, IntPtr qnimg_nativeObj);

        // C++:  void cv::ximgproc::rollingGuidanceFilter(Mat src, Mat& dst, int d = -1, double sigmaColor = 25, double sigmaSpace = 3, int numOfIter = 4, int borderType = BORDER_DEFAULT)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int numOfIter, int borderType);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int numOfIter);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_13(IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_14(IntPtr src_nativeObj, IntPtr dst_nativeObj, int d);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_15(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::thinning(Mat src, Mat& dst, int thinningType = THINNING_ZHANGSUEN)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_thinning_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int thinningType);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_thinning_11(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::transformFD(Mat src, Mat t, Mat& dst, bool fdContour = true)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_transformFD_10(IntPtr src_nativeObj, IntPtr t_nativeObj, IntPtr dst_nativeObj, [MarshalAs(UnmanagedType.U1)] bool fdContour);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_transformFD_11(IntPtr src_nativeObj, IntPtr t_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::weightedMedianFilter(Mat joint, Mat src, Mat& dst, int r, double sigma = 25.5, int weightType = WMF_EXP, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_weightedMedianFilter_10(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int r, double sigma, int weightType, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_weightedMedianFilter_11(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int r, double sigma, int weightType);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_weightedMedianFilter_12(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int r, double sigma);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_weightedMedianFilter_13(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int r);

    }
}
