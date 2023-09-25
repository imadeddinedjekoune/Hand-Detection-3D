
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using OpenCVForUnity.VideoModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.BgsegmModule
{
    // C++: class Bgsegm
    //javadoc: Bgsegm

    public class Bgsegm
    {

        // C++: enum LSBPCameraMotionCompensation
        public const int LSBP_CAMERA_MOTION_COMPENSATION_NONE = 0;
        public const int LSBP_CAMERA_MOTION_COMPENSATION_LK = 0 + 1;
        //
        // C++:  Ptr_BackgroundSubtractorCNT cv::bgsegm::createBackgroundSubtractorCNT(int minPixelStability = 15, bool useHistory = true, int maxPixelStability = 15*60, bool isParallel = true)
        //

        //javadoc: createBackgroundSubtractorCNT(minPixelStability, useHistory, maxPixelStability, isParallel)
        public static BackgroundSubtractorCNT createBackgroundSubtractorCNT(int minPixelStability, bool useHistory, int maxPixelStability, bool isParallel)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorCNT retVal = BackgroundSubtractorCNT.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorCNT_10(minPixelStability, useHistory, maxPixelStability, isParallel));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorCNT(minPixelStability, useHistory, maxPixelStability)
        public static BackgroundSubtractorCNT createBackgroundSubtractorCNT(int minPixelStability, bool useHistory, int maxPixelStability)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorCNT retVal = BackgroundSubtractorCNT.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorCNT_11(minPixelStability, useHistory, maxPixelStability));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorCNT(minPixelStability, useHistory)
        public static BackgroundSubtractorCNT createBackgroundSubtractorCNT(int minPixelStability, bool useHistory)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorCNT retVal = BackgroundSubtractorCNT.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorCNT_12(minPixelStability, useHistory));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorCNT(minPixelStability)
        public static BackgroundSubtractorCNT createBackgroundSubtractorCNT(int minPixelStability)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorCNT retVal = BackgroundSubtractorCNT.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorCNT_13(minPixelStability));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorCNT()
        public static BackgroundSubtractorCNT createBackgroundSubtractorCNT()
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorCNT retVal = BackgroundSubtractorCNT.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorCNT_14());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_BackgroundSubtractorGMG cv::bgsegm::createBackgroundSubtractorGMG(int initializationFrames = 120, double decisionThreshold = 0.8)
        //

        //javadoc: createBackgroundSubtractorGMG(initializationFrames, decisionThreshold)
        public static BackgroundSubtractorGMG createBackgroundSubtractorGMG(int initializationFrames, double decisionThreshold)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGMG retVal = BackgroundSubtractorGMG.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGMG_10(initializationFrames, decisionThreshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorGMG(initializationFrames)
        public static BackgroundSubtractorGMG createBackgroundSubtractorGMG(int initializationFrames)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGMG retVal = BackgroundSubtractorGMG.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGMG_11(initializationFrames));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorGMG()
        public static BackgroundSubtractorGMG createBackgroundSubtractorGMG()
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGMG retVal = BackgroundSubtractorGMG.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGMG_12());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_BackgroundSubtractorGSOC cv::bgsegm::createBackgroundSubtractorGSOC(int mc = LSBP_CAMERA_MOTION_COMPENSATION_NONE, int nSamples = 20, float replaceRate = 0.003f, float propagationRate = 0.01f, int hitsThreshold = 32, float alpha = 0.01f, float beta = 0.0022f, float blinkingSupressionDecay = 0.1f, float blinkingSupressionMultiplier = 0.1f, float noiseRemovalThresholdFacBG = 0.0004f, float noiseRemovalThresholdFacFG = 0.0008f)
        //

        //javadoc: createBackgroundSubtractorGSOC(mc, nSamples, replaceRate, propagationRate, hitsThreshold, alpha, beta, blinkingSupressionDecay, blinkingSupressionMultiplier, noiseRemovalThresholdFacBG, noiseRemovalThresholdFacFG)
        public static BackgroundSubtractorGSOC createBackgroundSubtractorGSOC(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold, float alpha, float beta, float blinkingSupressionDecay, float blinkingSupressionMultiplier, float noiseRemovalThresholdFacBG, float noiseRemovalThresholdFacFG)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGSOC retVal = BackgroundSubtractorGSOC.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGSOC_10(mc, nSamples, replaceRate, propagationRate, hitsThreshold, alpha, beta, blinkingSupressionDecay, blinkingSupressionMultiplier, noiseRemovalThresholdFacBG, noiseRemovalThresholdFacFG));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorGSOC(mc, nSamples, replaceRate, propagationRate, hitsThreshold, alpha, beta, blinkingSupressionDecay, blinkingSupressionMultiplier, noiseRemovalThresholdFacBG)
        public static BackgroundSubtractorGSOC createBackgroundSubtractorGSOC(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold, float alpha, float beta, float blinkingSupressionDecay, float blinkingSupressionMultiplier, float noiseRemovalThresholdFacBG)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGSOC retVal = BackgroundSubtractorGSOC.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGSOC_11(mc, nSamples, replaceRate, propagationRate, hitsThreshold, alpha, beta, blinkingSupressionDecay, blinkingSupressionMultiplier, noiseRemovalThresholdFacBG));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorGSOC(mc, nSamples, replaceRate, propagationRate, hitsThreshold, alpha, beta, blinkingSupressionDecay, blinkingSupressionMultiplier)
        public static BackgroundSubtractorGSOC createBackgroundSubtractorGSOC(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold, float alpha, float beta, float blinkingSupressionDecay, float blinkingSupressionMultiplier)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGSOC retVal = BackgroundSubtractorGSOC.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGSOC_12(mc, nSamples, replaceRate, propagationRate, hitsThreshold, alpha, beta, blinkingSupressionDecay, blinkingSupressionMultiplier));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorGSOC(mc, nSamples, replaceRate, propagationRate, hitsThreshold, alpha, beta, blinkingSupressionDecay)
        public static BackgroundSubtractorGSOC createBackgroundSubtractorGSOC(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold, float alpha, float beta, float blinkingSupressionDecay)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGSOC retVal = BackgroundSubtractorGSOC.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGSOC_13(mc, nSamples, replaceRate, propagationRate, hitsThreshold, alpha, beta, blinkingSupressionDecay));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorGSOC(mc, nSamples, replaceRate, propagationRate, hitsThreshold, alpha, beta)
        public static BackgroundSubtractorGSOC createBackgroundSubtractorGSOC(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold, float alpha, float beta)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGSOC retVal = BackgroundSubtractorGSOC.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGSOC_14(mc, nSamples, replaceRate, propagationRate, hitsThreshold, alpha, beta));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorGSOC(mc, nSamples, replaceRate, propagationRate, hitsThreshold, alpha)
        public static BackgroundSubtractorGSOC createBackgroundSubtractorGSOC(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold, float alpha)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGSOC retVal = BackgroundSubtractorGSOC.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGSOC_15(mc, nSamples, replaceRate, propagationRate, hitsThreshold, alpha));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorGSOC(mc, nSamples, replaceRate, propagationRate, hitsThreshold)
        public static BackgroundSubtractorGSOC createBackgroundSubtractorGSOC(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGSOC retVal = BackgroundSubtractorGSOC.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGSOC_16(mc, nSamples, replaceRate, propagationRate, hitsThreshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorGSOC(mc, nSamples, replaceRate, propagationRate)
        public static BackgroundSubtractorGSOC createBackgroundSubtractorGSOC(int mc, int nSamples, float replaceRate, float propagationRate)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGSOC retVal = BackgroundSubtractorGSOC.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGSOC_17(mc, nSamples, replaceRate, propagationRate));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorGSOC(mc, nSamples, replaceRate)
        public static BackgroundSubtractorGSOC createBackgroundSubtractorGSOC(int mc, int nSamples, float replaceRate)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGSOC retVal = BackgroundSubtractorGSOC.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGSOC_18(mc, nSamples, replaceRate));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorGSOC(mc, nSamples)
        public static BackgroundSubtractorGSOC createBackgroundSubtractorGSOC(int mc, int nSamples)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGSOC retVal = BackgroundSubtractorGSOC.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGSOC_19(mc, nSamples));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorGSOC(mc)
        public static BackgroundSubtractorGSOC createBackgroundSubtractorGSOC(int mc)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGSOC retVal = BackgroundSubtractorGSOC.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGSOC_110(mc));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorGSOC()
        public static BackgroundSubtractorGSOC createBackgroundSubtractorGSOC()
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGSOC retVal = BackgroundSubtractorGSOC.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorGSOC_111());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_BackgroundSubtractorLSBP cv::bgsegm::createBackgroundSubtractorLSBP(int mc = LSBP_CAMERA_MOTION_COMPENSATION_NONE, int nSamples = 20, int LSBPRadius = 16, float Tlower = 2.0f, float Tupper = 32.0f, float Tinc = 1.0f, float Tdec = 0.05f, float Rscale = 10.0f, float Rincdec = 0.005f, float noiseRemovalThresholdFacBG = 0.0004f, float noiseRemovalThresholdFacFG = 0.0008f, int LSBPthreshold = 8, int minCount = 2)
        //

        //javadoc: createBackgroundSubtractorLSBP(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec, Rscale, Rincdec, noiseRemovalThresholdFacBG, noiseRemovalThresholdFacFG, LSBPthreshold, minCount)
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec, float Rscale, float Rincdec, float noiseRemovalThresholdFacBG, float noiseRemovalThresholdFacFG, int LSBPthreshold, int minCount)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_10(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec, Rscale, Rincdec, noiseRemovalThresholdFacBG, noiseRemovalThresholdFacFG, LSBPthreshold, minCount));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorLSBP(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec, Rscale, Rincdec, noiseRemovalThresholdFacBG, noiseRemovalThresholdFacFG, LSBPthreshold)
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec, float Rscale, float Rincdec, float noiseRemovalThresholdFacBG, float noiseRemovalThresholdFacFG, int LSBPthreshold)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_11(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec, Rscale, Rincdec, noiseRemovalThresholdFacBG, noiseRemovalThresholdFacFG, LSBPthreshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorLSBP(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec, Rscale, Rincdec, noiseRemovalThresholdFacBG, noiseRemovalThresholdFacFG)
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec, float Rscale, float Rincdec, float noiseRemovalThresholdFacBG, float noiseRemovalThresholdFacFG)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_12(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec, Rscale, Rincdec, noiseRemovalThresholdFacBG, noiseRemovalThresholdFacFG));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorLSBP(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec, Rscale, Rincdec, noiseRemovalThresholdFacBG)
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec, float Rscale, float Rincdec, float noiseRemovalThresholdFacBG)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_13(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec, Rscale, Rincdec, noiseRemovalThresholdFacBG));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorLSBP(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec, Rscale, Rincdec)
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec, float Rscale, float Rincdec)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_14(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec, Rscale, Rincdec));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorLSBP(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec, Rscale)
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec, float Rscale)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_15(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec, Rscale));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorLSBP(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec)
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_16(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc, Tdec));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorLSBP(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc)
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_17(mc, nSamples, LSBPRadius, Tlower, Tupper, Tinc));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorLSBP(mc, nSamples, LSBPRadius, Tlower, Tupper)
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_18(mc, nSamples, LSBPRadius, Tlower, Tupper));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorLSBP(mc, nSamples, LSBPRadius, Tlower)
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP(int mc, int nSamples, int LSBPRadius, float Tlower)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_19(mc, nSamples, LSBPRadius, Tlower));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorLSBP(mc, nSamples, LSBPRadius)
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP(int mc, int nSamples, int LSBPRadius)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_110(mc, nSamples, LSBPRadius));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorLSBP(mc, nSamples)
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP(int mc, int nSamples)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_111(mc, nSamples));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorLSBP(mc)
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP(int mc)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_112(mc));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorLSBP()
        public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP()
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorLSBP retVal = BackgroundSubtractorLSBP.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorLSBP_113());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_BackgroundSubtractorMOG cv::bgsegm::createBackgroundSubtractorMOG(int history = 200, int nmixtures = 5, double backgroundRatio = 0.7, double noiseSigma = 0)
        //

        //javadoc: createBackgroundSubtractorMOG(history, nmixtures, backgroundRatio, noiseSigma)
        public static BackgroundSubtractorMOG createBackgroundSubtractorMOG(int history, int nmixtures, double backgroundRatio, double noiseSigma)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorMOG retVal = BackgroundSubtractorMOG.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorMOG_10(history, nmixtures, backgroundRatio, noiseSigma));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorMOG(history, nmixtures, backgroundRatio)
        public static BackgroundSubtractorMOG createBackgroundSubtractorMOG(int history, int nmixtures, double backgroundRatio)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorMOG retVal = BackgroundSubtractorMOG.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorMOG_11(history, nmixtures, backgroundRatio));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorMOG(history, nmixtures)
        public static BackgroundSubtractorMOG createBackgroundSubtractorMOG(int history, int nmixtures)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorMOG retVal = BackgroundSubtractorMOG.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorMOG_12(history, nmixtures));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorMOG(history)
        public static BackgroundSubtractorMOG createBackgroundSubtractorMOG(int history)
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorMOG retVal = BackgroundSubtractorMOG.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorMOG_13(history));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorMOG()
        public static BackgroundSubtractorMOG createBackgroundSubtractorMOG()
        {
#if UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorMOG retVal = BackgroundSubtractorMOG.__fromPtr__(bgsegm_Bgsegm_createBackgroundSubtractorMOG_14());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_SyntheticSequenceGenerator cv::bgsegm::createSyntheticSequenceGenerator(Mat background, Mat _object, double amplitude = 2.0, double wavelength = 20.0, double wavespeed = 0.2, double objspeed = 6.0)
        //

        //javadoc: createSyntheticSequenceGenerator(background, _object, amplitude, wavelength, wavespeed, objspeed)
        public static SyntheticSequenceGenerator createSyntheticSequenceGenerator(Mat background, Mat _object, double amplitude, double wavelength, double wavespeed, double objspeed)
        {
            if (background != null) background.ThrowIfDisposed();
            if (_object != null) _object.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SyntheticSequenceGenerator retVal = SyntheticSequenceGenerator.__fromPtr__(bgsegm_Bgsegm_createSyntheticSequenceGenerator_10(background.nativeObj, _object.nativeObj, amplitude, wavelength, wavespeed, objspeed));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createSyntheticSequenceGenerator(background, _object, amplitude, wavelength, wavespeed)
        public static SyntheticSequenceGenerator createSyntheticSequenceGenerator(Mat background, Mat _object, double amplitude, double wavelength, double wavespeed)
        {
            if (background != null) background.ThrowIfDisposed();
            if (_object != null) _object.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SyntheticSequenceGenerator retVal = SyntheticSequenceGenerator.__fromPtr__(bgsegm_Bgsegm_createSyntheticSequenceGenerator_11(background.nativeObj, _object.nativeObj, amplitude, wavelength, wavespeed));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createSyntheticSequenceGenerator(background, _object, amplitude, wavelength)
        public static SyntheticSequenceGenerator createSyntheticSequenceGenerator(Mat background, Mat _object, double amplitude, double wavelength)
        {
            if (background != null) background.ThrowIfDisposed();
            if (_object != null) _object.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SyntheticSequenceGenerator retVal = SyntheticSequenceGenerator.__fromPtr__(bgsegm_Bgsegm_createSyntheticSequenceGenerator_12(background.nativeObj, _object.nativeObj, amplitude, wavelength));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createSyntheticSequenceGenerator(background, _object, amplitude)
        public static SyntheticSequenceGenerator createSyntheticSequenceGenerator(Mat background, Mat _object, double amplitude)
        {
            if (background != null) background.ThrowIfDisposed();
            if (_object != null) _object.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SyntheticSequenceGenerator retVal = SyntheticSequenceGenerator.__fromPtr__(bgsegm_Bgsegm_createSyntheticSequenceGenerator_13(background.nativeObj, _object.nativeObj, amplitude));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createSyntheticSequenceGenerator(background, _object)
        public static SyntheticSequenceGenerator createSyntheticSequenceGenerator(Mat background, Mat _object)
        {
            if (background != null) background.ThrowIfDisposed();
            if (_object != null) _object.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        SyntheticSequenceGenerator retVal = SyntheticSequenceGenerator.__fromPtr__(bgsegm_Bgsegm_createSyntheticSequenceGenerator_14(background.nativeObj, _object.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  Ptr_BackgroundSubtractorCNT cv::bgsegm::createBackgroundSubtractorCNT(int minPixelStability = 15, bool useHistory = true, int maxPixelStability = 15*60, bool isParallel = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorCNT_10(int minPixelStability, [MarshalAs(UnmanagedType.U1)] bool useHistory, int maxPixelStability, [MarshalAs(UnmanagedType.U1)] bool isParallel);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorCNT_11(int minPixelStability, [MarshalAs(UnmanagedType.U1)] bool useHistory, int maxPixelStability);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorCNT_12(int minPixelStability, [MarshalAs(UnmanagedType.U1)] bool useHistory);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorCNT_13(int minPixelStability);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorCNT_14();

        // C++:  Ptr_BackgroundSubtractorGMG cv::bgsegm::createBackgroundSubtractorGMG(int initializationFrames = 120, double decisionThreshold = 0.8)
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGMG_10(int initializationFrames, double decisionThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGMG_11(int initializationFrames);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGMG_12();

        // C++:  Ptr_BackgroundSubtractorGSOC cv::bgsegm::createBackgroundSubtractorGSOC(int mc = LSBP_CAMERA_MOTION_COMPENSATION_NONE, int nSamples = 20, float replaceRate = 0.003f, float propagationRate = 0.01f, int hitsThreshold = 32, float alpha = 0.01f, float beta = 0.0022f, float blinkingSupressionDecay = 0.1f, float blinkingSupressionMultiplier = 0.1f, float noiseRemovalThresholdFacBG = 0.0004f, float noiseRemovalThresholdFacFG = 0.0008f)
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGSOC_10(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold, float alpha, float beta, float blinkingSupressionDecay, float blinkingSupressionMultiplier, float noiseRemovalThresholdFacBG, float noiseRemovalThresholdFacFG);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGSOC_11(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold, float alpha, float beta, float blinkingSupressionDecay, float blinkingSupressionMultiplier, float noiseRemovalThresholdFacBG);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGSOC_12(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold, float alpha, float beta, float blinkingSupressionDecay, float blinkingSupressionMultiplier);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGSOC_13(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold, float alpha, float beta, float blinkingSupressionDecay);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGSOC_14(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold, float alpha, float beta);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGSOC_15(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold, float alpha);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGSOC_16(int mc, int nSamples, float replaceRate, float propagationRate, int hitsThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGSOC_17(int mc, int nSamples, float replaceRate, float propagationRate);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGSOC_18(int mc, int nSamples, float replaceRate);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGSOC_19(int mc, int nSamples);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGSOC_110(int mc);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGSOC_111();

        // C++:  Ptr_BackgroundSubtractorLSBP cv::bgsegm::createBackgroundSubtractorLSBP(int mc = LSBP_CAMERA_MOTION_COMPENSATION_NONE, int nSamples = 20, int LSBPRadius = 16, float Tlower = 2.0f, float Tupper = 32.0f, float Tinc = 1.0f, float Tdec = 0.05f, float Rscale = 10.0f, float Rincdec = 0.005f, float noiseRemovalThresholdFacBG = 0.0004f, float noiseRemovalThresholdFacFG = 0.0008f, int LSBPthreshold = 8, int minCount = 2)
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_10(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec, float Rscale, float Rincdec, float noiseRemovalThresholdFacBG, float noiseRemovalThresholdFacFG, int LSBPthreshold, int minCount);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_11(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec, float Rscale, float Rincdec, float noiseRemovalThresholdFacBG, float noiseRemovalThresholdFacFG, int LSBPthreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_12(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec, float Rscale, float Rincdec, float noiseRemovalThresholdFacBG, float noiseRemovalThresholdFacFG);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_13(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec, float Rscale, float Rincdec, float noiseRemovalThresholdFacBG);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_14(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec, float Rscale, float Rincdec);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_15(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec, float Rscale);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_16(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_17(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_18(int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_19(int mc, int nSamples, int LSBPRadius, float Tlower);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_110(int mc, int nSamples, int LSBPRadius);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_111(int mc, int nSamples);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_112(int mc);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorLSBP_113();

        // C++:  Ptr_BackgroundSubtractorMOG cv::bgsegm::createBackgroundSubtractorMOG(int history = 200, int nmixtures = 5, double backgroundRatio = 0.7, double noiseSigma = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorMOG_10(int history, int nmixtures, double backgroundRatio, double noiseSigma);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorMOG_11(int history, int nmixtures, double backgroundRatio);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorMOG_12(int history, int nmixtures);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorMOG_13(int history);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorMOG_14();

        // C++:  Ptr_SyntheticSequenceGenerator cv::bgsegm::createSyntheticSequenceGenerator(Mat background, Mat _object, double amplitude = 2.0, double wavelength = 20.0, double wavespeed = 0.2, double objspeed = 6.0)
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createSyntheticSequenceGenerator_10(IntPtr background_nativeObj, IntPtr _object_nativeObj, double amplitude, double wavelength, double wavespeed, double objspeed);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createSyntheticSequenceGenerator_11(IntPtr background_nativeObj, IntPtr _object_nativeObj, double amplitude, double wavelength, double wavespeed);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createSyntheticSequenceGenerator_12(IntPtr background_nativeObj, IntPtr _object_nativeObj, double amplitude, double wavelength);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createSyntheticSequenceGenerator_13(IntPtr background_nativeObj, IntPtr _object_nativeObj, double amplitude);
        [DllImport(LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createSyntheticSequenceGenerator_14(IntPtr background_nativeObj, IntPtr _object_nativeObj);

    }
}
