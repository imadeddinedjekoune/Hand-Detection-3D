
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class PCTSignatures
    //javadoc: PCTSignatures

    public class PCTSignatures : Algorithm
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
                        xfeatures2d_PCTSignatures_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal PCTSignatures(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new PCTSignatures __fromPtr__(IntPtr addr) { return new PCTSignatures(addr); }

        // C++: enum SimilarityFunction
        public const int MINUS = 0;
        public const int GAUSSIAN = 1;
        public const int HEURISTIC = 2;
        // C++: enum PointDistribution
        public const int UNIFORM = 0;
        public const int REGULAR = 1;
        public const int NORMAL = 2;
        // C++: enum DistanceFunction
        public const int L0_25 = 0;
        public const int L0_5 = 1;
        public const int L1 = 2;
        public const int L2 = 3;
        public const int L2SQUARED = 4;
        public const int L5 = 5;
        public const int L_INFINITY = 6;
        //
        // C++: static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(int initSampleCount = 2000, int initSeedCount = 400, int pointDistribution = 0)
        //

        //javadoc: PCTSignatures::create(initSampleCount, initSeedCount, pointDistribution)
        public static PCTSignatures create(int initSampleCount, int initSeedCount, int pointDistribution)
        {
#if UNITY_5_3_OR_NEWER
        
        PCTSignatures retVal = PCTSignatures.__fromPtr__(xfeatures2d_PCTSignatures_create_10(initSampleCount, initSeedCount, pointDistribution));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: PCTSignatures::create(initSampleCount, initSeedCount)
        public static PCTSignatures create(int initSampleCount, int initSeedCount)
        {
#if UNITY_5_3_OR_NEWER
        
        PCTSignatures retVal = PCTSignatures.__fromPtr__(xfeatures2d_PCTSignatures_create_11(initSampleCount, initSeedCount));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: PCTSignatures::create(initSampleCount)
        public static PCTSignatures create(int initSampleCount)
        {
#if UNITY_5_3_OR_NEWER
        
        PCTSignatures retVal = PCTSignatures.__fromPtr__(xfeatures2d_PCTSignatures_create_12(initSampleCount));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: PCTSignatures::create()
        public static PCTSignatures create()
        {
#if UNITY_5_3_OR_NEWER
        
        PCTSignatures retVal = PCTSignatures.__fromPtr__(xfeatures2d_PCTSignatures_create_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(vector_Point2f initSamplingPoints, int initSeedCount)
        //

        //javadoc: PCTSignatures::create(initSamplingPoints, initSeedCount)
        public static PCTSignatures create(MatOfPoint2f initSamplingPoints, int initSeedCount)
        {
            if (initSamplingPoints != null) initSamplingPoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat initSamplingPoints_mat = initSamplingPoints;
        PCTSignatures retVal = PCTSignatures.__fromPtr__(xfeatures2d_PCTSignatures_create_14(initSamplingPoints_mat.nativeObj, initSeedCount));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(vector_Point2f initSamplingPoints, vector_int initClusterSeedIndexes)
        //

        //javadoc: PCTSignatures::create(initSamplingPoints, initClusterSeedIndexes)
        public static PCTSignatures create(MatOfPoint2f initSamplingPoints, MatOfInt initClusterSeedIndexes)
        {
            if (initSamplingPoints != null) initSamplingPoints.ThrowIfDisposed();
            if (initClusterSeedIndexes != null) initClusterSeedIndexes.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat initSamplingPoints_mat = initSamplingPoints;
        Mat initClusterSeedIndexes_mat = initClusterSeedIndexes;
        PCTSignatures retVal = PCTSignatures.__fromPtr__(xfeatures2d_PCTSignatures_create_15(initSamplingPoints_mat.nativeObj, initClusterSeedIndexes_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getDropThreshold()
        //

        //javadoc: PCTSignatures::getDropThreshold()
        public float getDropThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getDropThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getJoiningDistance()
        //

        //javadoc: PCTSignatures::getJoiningDistance()
        public float getJoiningDistance()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getJoiningDistance_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightA()
        //

        //javadoc: PCTSignatures::getWeightA()
        public float getWeightA()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightA_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightB()
        //

        //javadoc: PCTSignatures::getWeightB()
        public float getWeightB()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightB_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightContrast()
        //

        //javadoc: PCTSignatures::getWeightContrast()
        public float getWeightContrast()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightContrast_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightEntropy()
        //

        //javadoc: PCTSignatures::getWeightEntropy()
        public float getWeightEntropy()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightEntropy_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightL()
        //

        //javadoc: PCTSignatures::getWeightL()
        public float getWeightL()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightL_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightX()
        //

        //javadoc: PCTSignatures::getWeightX()
        public float getWeightX()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightX_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightY()
        //

        //javadoc: PCTSignatures::getWeightY()
        public float getWeightY()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightY_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getClusterMinSize()
        //

        //javadoc: PCTSignatures::getClusterMinSize()
        public int getClusterMinSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getClusterMinSize_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getDistanceFunction()
        //

        //javadoc: PCTSignatures::getDistanceFunction()
        public int getDistanceFunction()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getDistanceFunction_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getGrayscaleBits()
        //

        //javadoc: PCTSignatures::getGrayscaleBits()
        public int getGrayscaleBits()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getGrayscaleBits_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getInitSeedCount()
        //

        //javadoc: PCTSignatures::getInitSeedCount()
        public int getInitSeedCount()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getInitSeedCount_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getIterationCount()
        //

        //javadoc: PCTSignatures::getIterationCount()
        public int getIterationCount()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getIterationCount_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getMaxClustersCount()
        //

        //javadoc: PCTSignatures::getMaxClustersCount()
        public int getMaxClustersCount()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getMaxClustersCount_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getSampleCount()
        //

        //javadoc: PCTSignatures::getSampleCount()
        public int getSampleCount()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getSampleCount_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getWindowRadius()
        //

        //javadoc: PCTSignatures::getWindowRadius()
        public int getWindowRadius()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getWindowRadius_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  vector_Point2f cv::xfeatures2d::PCTSignatures::getSamplingPoints()
        //

        //javadoc: PCTSignatures::getSamplingPoints()
        public MatOfPoint2f getSamplingPoints()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        MatOfPoint2f retVal = MatOfPoint2f.fromNativeAddr(xfeatures2d_PCTSignatures_getSamplingPoints_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  vector_int cv::xfeatures2d::PCTSignatures::getInitSeedIndexes()
        //

        //javadoc: PCTSignatures::getInitSeedIndexes()
        public MatOfInt getInitSeedIndexes()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        MatOfInt retVal = MatOfInt.fromNativeAddr(xfeatures2d_PCTSignatures_getInitSeedIndexes_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::computeSignature(Mat image, Mat& signature)
        //

        //javadoc: PCTSignatures::computeSignature(image, signature)
        public void computeSignature(Mat image, Mat signature)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (signature != null) signature.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_computeSignature_10(nativeObj, image.nativeObj, signature.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::computeSignatures(vector_Mat images, vector_Mat signatures)
        //

        //javadoc: PCTSignatures::computeSignatures(images, signatures)
        public void computeSignatures(List<Mat> images, List<Mat> signatures)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_Mat_to_Mat(images);
        Mat signatures_mat = Converters.vector_Mat_to_Mat(signatures);
        xfeatures2d_PCTSignatures_computeSignatures_10(nativeObj, images_mat.nativeObj, signatures_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: static void cv::xfeatures2d::PCTSignatures::drawSignature(Mat source, Mat signature, Mat& result, float radiusToShorterSideRatio = 1.0 / 8, int borderThickness = 1)
        //

        //javadoc: PCTSignatures::drawSignature(source, signature, result, radiusToShorterSideRatio, borderThickness)
        public static void drawSignature(Mat source, Mat signature, Mat result, float radiusToShorterSideRatio, int borderThickness)
        {
            if (source != null) source.ThrowIfDisposed();
            if (signature != null) signature.ThrowIfDisposed();
            if (result != null) result.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_drawSignature_10(source.nativeObj, signature.nativeObj, result.nativeObj, radiusToShorterSideRatio, borderThickness);
        
        return;
#else
            return;
#endif
        }

        //javadoc: PCTSignatures::drawSignature(source, signature, result, radiusToShorterSideRatio)
        public static void drawSignature(Mat source, Mat signature, Mat result, float radiusToShorterSideRatio)
        {
            if (source != null) source.ThrowIfDisposed();
            if (signature != null) signature.ThrowIfDisposed();
            if (result != null) result.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_drawSignature_11(source.nativeObj, signature.nativeObj, result.nativeObj, radiusToShorterSideRatio);
        
        return;
#else
            return;
#endif
        }

        //javadoc: PCTSignatures::drawSignature(source, signature, result)
        public static void drawSignature(Mat source, Mat signature, Mat result)
        {
            if (source != null) source.ThrowIfDisposed();
            if (signature != null) signature.ThrowIfDisposed();
            if (result != null) result.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_drawSignature_12(source.nativeObj, signature.nativeObj, result.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: static void cv::xfeatures2d::PCTSignatures::generateInitPoints(vector_Point2f initPoints, int count, int pointDistribution)
        //

        //javadoc: PCTSignatures::generateInitPoints(initPoints, count, pointDistribution)
        public static void generateInitPoints(MatOfPoint2f initPoints, int count, int pointDistribution)
        {
            if (initPoints != null) initPoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat initPoints_mat = initPoints;
        xfeatures2d_PCTSignatures_generateInitPoints_10(initPoints_mat.nativeObj, count, pointDistribution);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setClusterMinSize(int clusterMinSize)
        //

        //javadoc: PCTSignatures::setClusterMinSize(clusterMinSize)
        public void setClusterMinSize(int clusterMinSize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setClusterMinSize_10(nativeObj, clusterMinSize);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setDistanceFunction(int distanceFunction)
        //

        //javadoc: PCTSignatures::setDistanceFunction(distanceFunction)
        public void setDistanceFunction(int distanceFunction)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setDistanceFunction_10(nativeObj, distanceFunction);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setDropThreshold(float dropThreshold)
        //

        //javadoc: PCTSignatures::setDropThreshold(dropThreshold)
        public void setDropThreshold(float dropThreshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setDropThreshold_10(nativeObj, dropThreshold);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setGrayscaleBits(int grayscaleBits)
        //

        //javadoc: PCTSignatures::setGrayscaleBits(grayscaleBits)
        public void setGrayscaleBits(int grayscaleBits)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setGrayscaleBits_10(nativeObj, grayscaleBits);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setInitSeedIndexes(vector_int initSeedIndexes)
        //

        //javadoc: PCTSignatures::setInitSeedIndexes(initSeedIndexes)
        public void setInitSeedIndexes(MatOfInt initSeedIndexes)
        {
            ThrowIfDisposed();
            if (initSeedIndexes != null) initSeedIndexes.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat initSeedIndexes_mat = initSeedIndexes;
        xfeatures2d_PCTSignatures_setInitSeedIndexes_10(nativeObj, initSeedIndexes_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setIterationCount(int iterationCount)
        //

        //javadoc: PCTSignatures::setIterationCount(iterationCount)
        public void setIterationCount(int iterationCount)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setIterationCount_10(nativeObj, iterationCount);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setJoiningDistance(float joiningDistance)
        //

        //javadoc: PCTSignatures::setJoiningDistance(joiningDistance)
        public void setJoiningDistance(float joiningDistance)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setJoiningDistance_10(nativeObj, joiningDistance);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setMaxClustersCount(int maxClustersCount)
        //

        //javadoc: PCTSignatures::setMaxClustersCount(maxClustersCount)
        public void setMaxClustersCount(int maxClustersCount)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setMaxClustersCount_10(nativeObj, maxClustersCount);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setSamplingPoints(vector_Point2f samplingPoints)
        //

        //javadoc: PCTSignatures::setSamplingPoints(samplingPoints)
        public void setSamplingPoints(MatOfPoint2f samplingPoints)
        {
            ThrowIfDisposed();
            if (samplingPoints != null) samplingPoints.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat samplingPoints_mat = samplingPoints;
        xfeatures2d_PCTSignatures_setSamplingPoints_10(nativeObj, samplingPoints_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setTranslation(int idx, float value)
        //

        //javadoc: PCTSignatures::setTranslation(idx, value)
        public void setTranslation(int idx, float value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setTranslation_10(nativeObj, idx, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setTranslations(vector_float translations)
        //

        //javadoc: PCTSignatures::setTranslations(translations)
        public void setTranslations(MatOfFloat translations)
        {
            ThrowIfDisposed();
            if (translations != null) translations.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat translations_mat = translations;
        xfeatures2d_PCTSignatures_setTranslations_10(nativeObj, translations_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeight(int idx, float value)
        //

        //javadoc: PCTSignatures::setWeight(idx, value)
        public void setWeight(int idx, float value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeight_10(nativeObj, idx, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightA(float weight)
        //

        //javadoc: PCTSignatures::setWeightA(weight)
        public void setWeightA(float weight)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightA_10(nativeObj, weight);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightB(float weight)
        //

        //javadoc: PCTSignatures::setWeightB(weight)
        public void setWeightB(float weight)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightB_10(nativeObj, weight);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightContrast(float weight)
        //

        //javadoc: PCTSignatures::setWeightContrast(weight)
        public void setWeightContrast(float weight)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightContrast_10(nativeObj, weight);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightEntropy(float weight)
        //

        //javadoc: PCTSignatures::setWeightEntropy(weight)
        public void setWeightEntropy(float weight)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightEntropy_10(nativeObj, weight);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightL(float weight)
        //

        //javadoc: PCTSignatures::setWeightL(weight)
        public void setWeightL(float weight)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightL_10(nativeObj, weight);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightX(float weight)
        //

        //javadoc: PCTSignatures::setWeightX(weight)
        public void setWeightX(float weight)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightX_10(nativeObj, weight);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightY(float weight)
        //

        //javadoc: PCTSignatures::setWeightY(weight)
        public void setWeightY(float weight)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightY_10(nativeObj, weight);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeights(vector_float weights)
        //

        //javadoc: PCTSignatures::setWeights(weights)
        public void setWeights(MatOfFloat weights)
        {
            ThrowIfDisposed();
            if (weights != null) weights.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat weights_mat = weights;
        xfeatures2d_PCTSignatures_setWeights_10(nativeObj, weights_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWindowRadius(int radius)
        //

        //javadoc: PCTSignatures::setWindowRadius(radius)
        public void setWindowRadius(int radius)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWindowRadius_10(nativeObj, radius);
        
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



        // C++: static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(int initSampleCount = 2000, int initSeedCount = 400, int pointDistribution = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_10(int initSampleCount, int initSeedCount, int pointDistribution);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_11(int initSampleCount, int initSeedCount);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_12(int initSampleCount);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_13();

        // C++: static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(vector_Point2f initSamplingPoints, int initSeedCount)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_14(IntPtr initSamplingPoints_mat_nativeObj, int initSeedCount);

        // C++: static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(vector_Point2f initSamplingPoints, vector_int initClusterSeedIndexes)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_15(IntPtr initSamplingPoints_mat_nativeObj, IntPtr initClusterSeedIndexes_mat_nativeObj);

        // C++:  float cv::xfeatures2d::PCTSignatures::getDropThreshold()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getDropThreshold_10(IntPtr nativeObj);

        // C++:  float cv::xfeatures2d::PCTSignatures::getJoiningDistance()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getJoiningDistance_10(IntPtr nativeObj);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightA()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightA_10(IntPtr nativeObj);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightB()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightB_10(IntPtr nativeObj);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightContrast()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightContrast_10(IntPtr nativeObj);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightEntropy()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightEntropy_10(IntPtr nativeObj);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightL()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightL_10(IntPtr nativeObj);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightX()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightX_10(IntPtr nativeObj);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightY()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightY_10(IntPtr nativeObj);

        // C++:  int cv::xfeatures2d::PCTSignatures::getClusterMinSize()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getClusterMinSize_10(IntPtr nativeObj);

        // C++:  int cv::xfeatures2d::PCTSignatures::getDistanceFunction()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getDistanceFunction_10(IntPtr nativeObj);

        // C++:  int cv::xfeatures2d::PCTSignatures::getGrayscaleBits()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getGrayscaleBits_10(IntPtr nativeObj);

        // C++:  int cv::xfeatures2d::PCTSignatures::getInitSeedCount()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getInitSeedCount_10(IntPtr nativeObj);

        // C++:  int cv::xfeatures2d::PCTSignatures::getIterationCount()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getIterationCount_10(IntPtr nativeObj);

        // C++:  int cv::xfeatures2d::PCTSignatures::getMaxClustersCount()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getMaxClustersCount_10(IntPtr nativeObj);

        // C++:  int cv::xfeatures2d::PCTSignatures::getSampleCount()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getSampleCount_10(IntPtr nativeObj);

        // C++:  int cv::xfeatures2d::PCTSignatures::getWindowRadius()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getWindowRadius_10(IntPtr nativeObj);

        // C++:  vector_Point2f cv::xfeatures2d::PCTSignatures::getSamplingPoints()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_getSamplingPoints_10(IntPtr nativeObj);

        // C++:  vector_int cv::xfeatures2d::PCTSignatures::getInitSeedIndexes()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_getInitSeedIndexes_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::computeSignature(Mat image, Mat& signature)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_computeSignature_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr signature_nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::computeSignatures(vector_Mat images, vector_Mat signatures)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_computeSignatures_10(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr signatures_mat_nativeObj);

        // C++: static void cv::xfeatures2d::PCTSignatures::drawSignature(Mat source, Mat signature, Mat& result, float radiusToShorterSideRatio = 1.0 / 8, int borderThickness = 1)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_drawSignature_10(IntPtr source_nativeObj, IntPtr signature_nativeObj, IntPtr result_nativeObj, float radiusToShorterSideRatio, int borderThickness);
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_drawSignature_11(IntPtr source_nativeObj, IntPtr signature_nativeObj, IntPtr result_nativeObj, float radiusToShorterSideRatio);
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_drawSignature_12(IntPtr source_nativeObj, IntPtr signature_nativeObj, IntPtr result_nativeObj);

        // C++: static void cv::xfeatures2d::PCTSignatures::generateInitPoints(vector_Point2f initPoints, int count, int pointDistribution)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_generateInitPoints_10(IntPtr initPoints_mat_nativeObj, int count, int pointDistribution);

        // C++:  void cv::xfeatures2d::PCTSignatures::setClusterMinSize(int clusterMinSize)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setClusterMinSize_10(IntPtr nativeObj, int clusterMinSize);

        // C++:  void cv::xfeatures2d::PCTSignatures::setDistanceFunction(int distanceFunction)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setDistanceFunction_10(IntPtr nativeObj, int distanceFunction);

        // C++:  void cv::xfeatures2d::PCTSignatures::setDropThreshold(float dropThreshold)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setDropThreshold_10(IntPtr nativeObj, float dropThreshold);

        // C++:  void cv::xfeatures2d::PCTSignatures::setGrayscaleBits(int grayscaleBits)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setGrayscaleBits_10(IntPtr nativeObj, int grayscaleBits);

        // C++:  void cv::xfeatures2d::PCTSignatures::setInitSeedIndexes(vector_int initSeedIndexes)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setInitSeedIndexes_10(IntPtr nativeObj, IntPtr initSeedIndexes_mat_nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setIterationCount(int iterationCount)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setIterationCount_10(IntPtr nativeObj, int iterationCount);

        // C++:  void cv::xfeatures2d::PCTSignatures::setJoiningDistance(float joiningDistance)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setJoiningDistance_10(IntPtr nativeObj, float joiningDistance);

        // C++:  void cv::xfeatures2d::PCTSignatures::setMaxClustersCount(int maxClustersCount)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setMaxClustersCount_10(IntPtr nativeObj, int maxClustersCount);

        // C++:  void cv::xfeatures2d::PCTSignatures::setSamplingPoints(vector_Point2f samplingPoints)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setSamplingPoints_10(IntPtr nativeObj, IntPtr samplingPoints_mat_nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setTranslation(int idx, float value)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setTranslation_10(IntPtr nativeObj, int idx, float value);

        // C++:  void cv::xfeatures2d::PCTSignatures::setTranslations(vector_float translations)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setTranslations_10(IntPtr nativeObj, IntPtr translations_mat_nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeight(int idx, float value)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeight_10(IntPtr nativeObj, int idx, float value);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightA(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightA_10(IntPtr nativeObj, float weight);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightB(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightB_10(IntPtr nativeObj, float weight);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightContrast(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightContrast_10(IntPtr nativeObj, float weight);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightEntropy(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightEntropy_10(IntPtr nativeObj, float weight);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightL(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightL_10(IntPtr nativeObj, float weight);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightX(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightX_10(IntPtr nativeObj, float weight);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightY(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightY_10(IntPtr nativeObj, float weight);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeights(vector_float weights)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeights_10(IntPtr nativeObj, IntPtr weights_mat_nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWindowRadius(int radius)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWindowRadius_10(IntPtr nativeObj, int radius);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_delete(IntPtr nativeObj);

    }
}
