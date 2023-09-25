
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.BioinspiredModule
{

    // C++: class Retina
    //javadoc: Retina

    public class Retina : Algorithm
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
                        bioinspired_Retina_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Retina(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new Retina __fromPtr__(IntPtr addr) { return new Retina(addr); }

        //
        // C++:  Mat cv::bioinspired::Retina::getMagnoRAW()
        //

        //javadoc: Retina::getMagnoRAW()
        public Mat getMagnoRAW()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(bioinspired_Retina_getMagnoRAW_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::bioinspired::Retina::getParvoRAW()
        //

        //javadoc: Retina::getParvoRAW()
        public Mat getParvoRAW()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(bioinspired_Retina_getParvoRAW_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_Retina cv::bioinspired::Retina::create(Size inputSize, bool colorMode, int colorSamplingMethod = RETINA_COLOR_BAYER, bool useRetinaLogSampling = false, float reductionFactor = 1.0f, float samplingStrenght = 10.0f)
        //

        //javadoc: Retina::create(inputSize, colorMode, colorSamplingMethod, useRetinaLogSampling, reductionFactor, samplingStrenght)
        public static Retina create(Size inputSize, bool colorMode, int colorSamplingMethod, bool useRetinaLogSampling, float reductionFactor, float samplingStrenght)
        {
#if UNITY_5_3_OR_NEWER
        
        Retina retVal = Retina.__fromPtr__(bioinspired_Retina_create_10(inputSize.width, inputSize.height, colorMode, colorSamplingMethod, useRetinaLogSampling, reductionFactor, samplingStrenght));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: Retina::create(inputSize, colorMode, colorSamplingMethod, useRetinaLogSampling, reductionFactor)
        public static Retina create(Size inputSize, bool colorMode, int colorSamplingMethod, bool useRetinaLogSampling, float reductionFactor)
        {
#if UNITY_5_3_OR_NEWER
        
        Retina retVal = Retina.__fromPtr__(bioinspired_Retina_create_11(inputSize.width, inputSize.height, colorMode, colorSamplingMethod, useRetinaLogSampling, reductionFactor));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: Retina::create(inputSize, colorMode, colorSamplingMethod, useRetinaLogSampling)
        public static Retina create(Size inputSize, bool colorMode, int colorSamplingMethod, bool useRetinaLogSampling)
        {
#if UNITY_5_3_OR_NEWER
        
        Retina retVal = Retina.__fromPtr__(bioinspired_Retina_create_12(inputSize.width, inputSize.height, colorMode, colorSamplingMethod, useRetinaLogSampling));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: Retina::create(inputSize, colorMode, colorSamplingMethod)
        public static Retina create(Size inputSize, bool colorMode, int colorSamplingMethod)
        {
#if UNITY_5_3_OR_NEWER
        
        Retina retVal = Retina.__fromPtr__(bioinspired_Retina_create_13(inputSize.width, inputSize.height, colorMode, colorSamplingMethod));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: Retina::create(inputSize, colorMode)
        public static Retina create(Size inputSize, bool colorMode)
        {
#if UNITY_5_3_OR_NEWER
        
        Retina retVal = Retina.__fromPtr__(bioinspired_Retina_create_14(inputSize.width, inputSize.height, colorMode));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_Retina cv::bioinspired::Retina::create(Size inputSize)
        //

        //javadoc: Retina::create(inputSize)
        public static Retina create(Size inputSize)
        {
#if UNITY_5_3_OR_NEWER
        
        Retina retVal = Retina.__fromPtr__(bioinspired_Retina_create_15(inputSize.width, inputSize.height));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Size cv::bioinspired::Retina::getInputSize()
        //

        //javadoc: Retina::getInputSize()
        public Size getInputSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
bioinspired_Retina_getInputSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Size cv::bioinspired::Retina::getOutputSize()
        //

        //javadoc: Retina::getOutputSize()
        public Size getOutputSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
bioinspired_Retina_getOutputSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::bioinspired::Retina::printSetup()
        //

        //javadoc: Retina::printSetup()
        public string printSetup()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (bioinspired_Retina_printSetup_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::activateContoursProcessing(bool activate)
        //

        //javadoc: Retina::activateContoursProcessing(activate)
        public void activateContoursProcessing(bool activate)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_activateContoursProcessing_10(nativeObj, activate);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::activateMovingContoursProcessing(bool activate)
        //

        //javadoc: Retina::activateMovingContoursProcessing(activate)
        public void activateMovingContoursProcessing(bool activate)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_activateMovingContoursProcessing_10(nativeObj, activate);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::applyFastToneMapping(Mat inputImage, Mat& outputToneMappedImage)
        //

        //javadoc: Retina::applyFastToneMapping(inputImage, outputToneMappedImage)
        public void applyFastToneMapping(Mat inputImage, Mat outputToneMappedImage)
        {
            ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();
            if (outputToneMappedImage != null) outputToneMappedImage.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_applyFastToneMapping_10(nativeObj, inputImage.nativeObj, outputToneMappedImage.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::clearBuffers()
        //

        //javadoc: Retina::clearBuffers()
        public void clearBuffers()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_clearBuffers_10(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::getMagno(Mat& retinaOutput_magno)
        //

        //javadoc: Retina::getMagno(retinaOutput_magno)
        public void getMagno(Mat retinaOutput_magno)
        {
            ThrowIfDisposed();
            if (retinaOutput_magno != null) retinaOutput_magno.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_getMagno_10(nativeObj, retinaOutput_magno.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::getMagnoRAW(Mat& retinaOutput_magno)
        //

        //javadoc: Retina::getMagnoRAW(retinaOutput_magno)
        public void getMagnoRAW(Mat retinaOutput_magno)
        {
            ThrowIfDisposed();
            if (retinaOutput_magno != null) retinaOutput_magno.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_getMagnoRAW_11(nativeObj, retinaOutput_magno.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::getParvo(Mat& retinaOutput_parvo)
        //

        //javadoc: Retina::getParvo(retinaOutput_parvo)
        public void getParvo(Mat retinaOutput_parvo)
        {
            ThrowIfDisposed();
            if (retinaOutput_parvo != null) retinaOutput_parvo.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_getParvo_10(nativeObj, retinaOutput_parvo.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::getParvoRAW(Mat& retinaOutput_parvo)
        //

        //javadoc: Retina::getParvoRAW(retinaOutput_parvo)
        public void getParvoRAW(Mat retinaOutput_parvo)
        {
            ThrowIfDisposed();
            if (retinaOutput_parvo != null) retinaOutput_parvo.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_getParvoRAW_11(nativeObj, retinaOutput_parvo.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::run(Mat inputImage)
        //

        //javadoc: Retina::run(inputImage)
        public void run(Mat inputImage)
        {
            ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_run_10(nativeObj, inputImage.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::setColorSaturation(bool saturateColors = true, float colorSaturationValue = 4.0f)
        //

        //javadoc: Retina::setColorSaturation(saturateColors, colorSaturationValue)
        public void setColorSaturation(bool saturateColors, float colorSaturationValue)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setColorSaturation_10(nativeObj, saturateColors, colorSaturationValue);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setColorSaturation(saturateColors)
        public void setColorSaturation(bool saturateColors)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setColorSaturation_11(nativeObj, saturateColors);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setColorSaturation()
        public void setColorSaturation()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setColorSaturation_12(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::setup(String retinaParameterFile = "", bool applyDefaultSetupOnFailure = true)
        //

        //javadoc: Retina::setup(retinaParameterFile, applyDefaultSetupOnFailure)
        public void setup(string retinaParameterFile, bool applyDefaultSetupOnFailure)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setup_10(nativeObj, retinaParameterFile, applyDefaultSetupOnFailure);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setup(retinaParameterFile)
        public void setup(string retinaParameterFile)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setup_11(nativeObj, retinaParameterFile);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setup()
        public void setup()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setup_12(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::setupIPLMagnoChannel(bool normaliseOutput = true, float parasolCells_beta = 0.f, float parasolCells_tau = 0.f, float parasolCells_k = 7.f, float amacrinCellsTemporalCutFrequency = 1.2f, float V0CompressionParameter = 0.95f, float localAdaptintegration_tau = 0.f, float localAdaptintegration_k = 7.f)
        //

        //javadoc: Retina::setupIPLMagnoChannel(normaliseOutput, parasolCells_beta, parasolCells_tau, parasolCells_k, amacrinCellsTemporalCutFrequency, V0CompressionParameter, localAdaptintegration_tau, localAdaptintegration_k)
        public void setupIPLMagnoChannel(bool normaliseOutput, float parasolCells_beta, float parasolCells_tau, float parasolCells_k, float amacrinCellsTemporalCutFrequency, float V0CompressionParameter, float localAdaptintegration_tau, float localAdaptintegration_k)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupIPLMagnoChannel_10(nativeObj, normaliseOutput, parasolCells_beta, parasolCells_tau, parasolCells_k, amacrinCellsTemporalCutFrequency, V0CompressionParameter, localAdaptintegration_tau, localAdaptintegration_k);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupIPLMagnoChannel(normaliseOutput, parasolCells_beta, parasolCells_tau, parasolCells_k, amacrinCellsTemporalCutFrequency, V0CompressionParameter, localAdaptintegration_tau)
        public void setupIPLMagnoChannel(bool normaliseOutput, float parasolCells_beta, float parasolCells_tau, float parasolCells_k, float amacrinCellsTemporalCutFrequency, float V0CompressionParameter, float localAdaptintegration_tau)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupIPLMagnoChannel_11(nativeObj, normaliseOutput, parasolCells_beta, parasolCells_tau, parasolCells_k, amacrinCellsTemporalCutFrequency, V0CompressionParameter, localAdaptintegration_tau);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupIPLMagnoChannel(normaliseOutput, parasolCells_beta, parasolCells_tau, parasolCells_k, amacrinCellsTemporalCutFrequency, V0CompressionParameter)
        public void setupIPLMagnoChannel(bool normaliseOutput, float parasolCells_beta, float parasolCells_tau, float parasolCells_k, float amacrinCellsTemporalCutFrequency, float V0CompressionParameter)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupIPLMagnoChannel_12(nativeObj, normaliseOutput, parasolCells_beta, parasolCells_tau, parasolCells_k, amacrinCellsTemporalCutFrequency, V0CompressionParameter);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupIPLMagnoChannel(normaliseOutput, parasolCells_beta, parasolCells_tau, parasolCells_k, amacrinCellsTemporalCutFrequency)
        public void setupIPLMagnoChannel(bool normaliseOutput, float parasolCells_beta, float parasolCells_tau, float parasolCells_k, float amacrinCellsTemporalCutFrequency)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupIPLMagnoChannel_13(nativeObj, normaliseOutput, parasolCells_beta, parasolCells_tau, parasolCells_k, amacrinCellsTemporalCutFrequency);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupIPLMagnoChannel(normaliseOutput, parasolCells_beta, parasolCells_tau, parasolCells_k)
        public void setupIPLMagnoChannel(bool normaliseOutput, float parasolCells_beta, float parasolCells_tau, float parasolCells_k)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupIPLMagnoChannel_14(nativeObj, normaliseOutput, parasolCells_beta, parasolCells_tau, parasolCells_k);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupIPLMagnoChannel(normaliseOutput, parasolCells_beta, parasolCells_tau)
        public void setupIPLMagnoChannel(bool normaliseOutput, float parasolCells_beta, float parasolCells_tau)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupIPLMagnoChannel_15(nativeObj, normaliseOutput, parasolCells_beta, parasolCells_tau);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupIPLMagnoChannel(normaliseOutput, parasolCells_beta)
        public void setupIPLMagnoChannel(bool normaliseOutput, float parasolCells_beta)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupIPLMagnoChannel_16(nativeObj, normaliseOutput, parasolCells_beta);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupIPLMagnoChannel(normaliseOutput)
        public void setupIPLMagnoChannel(bool normaliseOutput)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupIPLMagnoChannel_17(nativeObj, normaliseOutput);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupIPLMagnoChannel()
        public void setupIPLMagnoChannel()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupIPLMagnoChannel_18(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::setupOPLandIPLParvoChannel(bool colorMode = true, bool normaliseOutput = true, float photoreceptorsLocalAdaptationSensitivity = 0.7f, float photoreceptorsTemporalConstant = 0.5f, float photoreceptorsSpatialConstant = 0.53f, float horizontalCellsGain = 0.f, float HcellsTemporalConstant = 1.f, float HcellsSpatialConstant = 7.f, float ganglionCellsSensitivity = 0.7f)
        //

        //javadoc: Retina::setupOPLandIPLParvoChannel(colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant, photoreceptorsSpatialConstant, horizontalCellsGain, HcellsTemporalConstant, HcellsSpatialConstant, ganglionCellsSensitivity)
        public void setupOPLandIPLParvoChannel(bool colorMode, bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant, float photoreceptorsSpatialConstant, float horizontalCellsGain, float HcellsTemporalConstant, float HcellsSpatialConstant, float ganglionCellsSensitivity)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupOPLandIPLParvoChannel_10(nativeObj, colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant, photoreceptorsSpatialConstant, horizontalCellsGain, HcellsTemporalConstant, HcellsSpatialConstant, ganglionCellsSensitivity);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupOPLandIPLParvoChannel(colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant, photoreceptorsSpatialConstant, horizontalCellsGain, HcellsTemporalConstant, HcellsSpatialConstant)
        public void setupOPLandIPLParvoChannel(bool colorMode, bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant, float photoreceptorsSpatialConstant, float horizontalCellsGain, float HcellsTemporalConstant, float HcellsSpatialConstant)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupOPLandIPLParvoChannel_11(nativeObj, colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant, photoreceptorsSpatialConstant, horizontalCellsGain, HcellsTemporalConstant, HcellsSpatialConstant);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupOPLandIPLParvoChannel(colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant, photoreceptorsSpatialConstant, horizontalCellsGain, HcellsTemporalConstant)
        public void setupOPLandIPLParvoChannel(bool colorMode, bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant, float photoreceptorsSpatialConstant, float horizontalCellsGain, float HcellsTemporalConstant)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupOPLandIPLParvoChannel_12(nativeObj, colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant, photoreceptorsSpatialConstant, horizontalCellsGain, HcellsTemporalConstant);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupOPLandIPLParvoChannel(colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant, photoreceptorsSpatialConstant, horizontalCellsGain)
        public void setupOPLandIPLParvoChannel(bool colorMode, bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant, float photoreceptorsSpatialConstant, float horizontalCellsGain)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupOPLandIPLParvoChannel_13(nativeObj, colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant, photoreceptorsSpatialConstant, horizontalCellsGain);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupOPLandIPLParvoChannel(colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant, photoreceptorsSpatialConstant)
        public void setupOPLandIPLParvoChannel(bool colorMode, bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant, float photoreceptorsSpatialConstant)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupOPLandIPLParvoChannel_14(nativeObj, colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant, photoreceptorsSpatialConstant);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupOPLandIPLParvoChannel(colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant)
        public void setupOPLandIPLParvoChannel(bool colorMode, bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupOPLandIPLParvoChannel_15(nativeObj, colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupOPLandIPLParvoChannel(colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity)
        public void setupOPLandIPLParvoChannel(bool colorMode, bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupOPLandIPLParvoChannel_16(nativeObj, colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupOPLandIPLParvoChannel(colorMode, normaliseOutput)
        public void setupOPLandIPLParvoChannel(bool colorMode, bool normaliseOutput)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupOPLandIPLParvoChannel_17(nativeObj, colorMode, normaliseOutput);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupOPLandIPLParvoChannel(colorMode)
        public void setupOPLandIPLParvoChannel(bool colorMode)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupOPLandIPLParvoChannel_18(nativeObj, colorMode);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Retina::setupOPLandIPLParvoChannel()
        public void setupOPLandIPLParvoChannel()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupOPLandIPLParvoChannel_19(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::Retina::write(String fs)
        //

        //javadoc: Retina::write(fs)
        public void write(string fs)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_write_10(nativeObj, fs);
        
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



        // C++:  Mat cv::bioinspired::Retina::getMagnoRAW()
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_Retina_getMagnoRAW_10(IntPtr nativeObj);

        // C++:  Mat cv::bioinspired::Retina::getParvoRAW()
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_Retina_getParvoRAW_10(IntPtr nativeObj);

        // C++: static Ptr_Retina cv::bioinspired::Retina::create(Size inputSize, bool colorMode, int colorSamplingMethod = RETINA_COLOR_BAYER, bool useRetinaLogSampling = false, float reductionFactor = 1.0f, float samplingStrenght = 10.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_Retina_create_10(double inputSize_width, double inputSize_height, [MarshalAs(UnmanagedType.U1)] bool colorMode, int colorSamplingMethod, [MarshalAs(UnmanagedType.U1)] bool useRetinaLogSampling, float reductionFactor, float samplingStrenght);
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_Retina_create_11(double inputSize_width, double inputSize_height, [MarshalAs(UnmanagedType.U1)] bool colorMode, int colorSamplingMethod, [MarshalAs(UnmanagedType.U1)] bool useRetinaLogSampling, float reductionFactor);
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_Retina_create_12(double inputSize_width, double inputSize_height, [MarshalAs(UnmanagedType.U1)] bool colorMode, int colorSamplingMethod, [MarshalAs(UnmanagedType.U1)] bool useRetinaLogSampling);
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_Retina_create_13(double inputSize_width, double inputSize_height, [MarshalAs(UnmanagedType.U1)] bool colorMode, int colorSamplingMethod);
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_Retina_create_14(double inputSize_width, double inputSize_height, [MarshalAs(UnmanagedType.U1)] bool colorMode);

        // C++: static Ptr_Retina cv::bioinspired::Retina::create(Size inputSize)
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_Retina_create_15(double inputSize_width, double inputSize_height);

        // C++:  Size cv::bioinspired::Retina::getInputSize()
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_getInputSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  Size cv::bioinspired::Retina::getOutputSize()
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_getOutputSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  String cv::bioinspired::Retina::printSetup()
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_Retina_printSetup_10(IntPtr nativeObj);

        // C++:  void cv::bioinspired::Retina::activateContoursProcessing(bool activate)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_activateContoursProcessing_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool activate);

        // C++:  void cv::bioinspired::Retina::activateMovingContoursProcessing(bool activate)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_activateMovingContoursProcessing_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool activate);

        // C++:  void cv::bioinspired::Retina::applyFastToneMapping(Mat inputImage, Mat& outputToneMappedImage)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_applyFastToneMapping_10(IntPtr nativeObj, IntPtr inputImage_nativeObj, IntPtr outputToneMappedImage_nativeObj);

        // C++:  void cv::bioinspired::Retina::clearBuffers()
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_clearBuffers_10(IntPtr nativeObj);

        // C++:  void cv::bioinspired::Retina::getMagno(Mat& retinaOutput_magno)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_getMagno_10(IntPtr nativeObj, IntPtr retinaOutput_magno_nativeObj);

        // C++:  void cv::bioinspired::Retina::getMagnoRAW(Mat& retinaOutput_magno)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_getMagnoRAW_11(IntPtr nativeObj, IntPtr retinaOutput_magno_nativeObj);

        // C++:  void cv::bioinspired::Retina::getParvo(Mat& retinaOutput_parvo)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_getParvo_10(IntPtr nativeObj, IntPtr retinaOutput_parvo_nativeObj);

        // C++:  void cv::bioinspired::Retina::getParvoRAW(Mat& retinaOutput_parvo)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_getParvoRAW_11(IntPtr nativeObj, IntPtr retinaOutput_parvo_nativeObj);

        // C++:  void cv::bioinspired::Retina::run(Mat inputImage)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_run_10(IntPtr nativeObj, IntPtr inputImage_nativeObj);

        // C++:  void cv::bioinspired::Retina::setColorSaturation(bool saturateColors = true, float colorSaturationValue = 4.0f)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setColorSaturation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool saturateColors, float colorSaturationValue);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setColorSaturation_11(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool saturateColors);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setColorSaturation_12(IntPtr nativeObj);

        // C++:  void cv::bioinspired::Retina::setup(String retinaParameterFile = "", bool applyDefaultSetupOnFailure = true)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setup_10(IntPtr nativeObj, string retinaParameterFile, [MarshalAs(UnmanagedType.U1)] bool applyDefaultSetupOnFailure);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setup_11(IntPtr nativeObj, string retinaParameterFile);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setup_12(IntPtr nativeObj);

        // C++:  void cv::bioinspired::Retina::setupIPLMagnoChannel(bool normaliseOutput = true, float parasolCells_beta = 0.f, float parasolCells_tau = 0.f, float parasolCells_k = 7.f, float amacrinCellsTemporalCutFrequency = 1.2f, float V0CompressionParameter = 0.95f, float localAdaptintegration_tau = 0.f, float localAdaptintegration_k = 7.f)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupIPLMagnoChannel_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float parasolCells_beta, float parasolCells_tau, float parasolCells_k, float amacrinCellsTemporalCutFrequency, float V0CompressionParameter, float localAdaptintegration_tau, float localAdaptintegration_k);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupIPLMagnoChannel_11(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float parasolCells_beta, float parasolCells_tau, float parasolCells_k, float amacrinCellsTemporalCutFrequency, float V0CompressionParameter, float localAdaptintegration_tau);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupIPLMagnoChannel_12(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float parasolCells_beta, float parasolCells_tau, float parasolCells_k, float amacrinCellsTemporalCutFrequency, float V0CompressionParameter);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupIPLMagnoChannel_13(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float parasolCells_beta, float parasolCells_tau, float parasolCells_k, float amacrinCellsTemporalCutFrequency);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupIPLMagnoChannel_14(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float parasolCells_beta, float parasolCells_tau, float parasolCells_k);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupIPLMagnoChannel_15(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float parasolCells_beta, float parasolCells_tau);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupIPLMagnoChannel_16(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float parasolCells_beta);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupIPLMagnoChannel_17(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupIPLMagnoChannel_18(IntPtr nativeObj);

        // C++:  void cv::bioinspired::Retina::setupOPLandIPLParvoChannel(bool colorMode = true, bool normaliseOutput = true, float photoreceptorsLocalAdaptationSensitivity = 0.7f, float photoreceptorsTemporalConstant = 0.5f, float photoreceptorsSpatialConstant = 0.53f, float horizontalCellsGain = 0.f, float HcellsTemporalConstant = 1.f, float HcellsSpatialConstant = 7.f, float ganglionCellsSensitivity = 0.7f)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupOPLandIPLParvoChannel_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool colorMode, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant, float photoreceptorsSpatialConstant, float horizontalCellsGain, float HcellsTemporalConstant, float HcellsSpatialConstant, float ganglionCellsSensitivity);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupOPLandIPLParvoChannel_11(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool colorMode, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant, float photoreceptorsSpatialConstant, float horizontalCellsGain, float HcellsTemporalConstant, float HcellsSpatialConstant);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupOPLandIPLParvoChannel_12(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool colorMode, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant, float photoreceptorsSpatialConstant, float horizontalCellsGain, float HcellsTemporalConstant);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupOPLandIPLParvoChannel_13(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool colorMode, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant, float photoreceptorsSpatialConstant, float horizontalCellsGain);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupOPLandIPLParvoChannel_14(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool colorMode, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant, float photoreceptorsSpatialConstant);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupOPLandIPLParvoChannel_15(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool colorMode, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupOPLandIPLParvoChannel_16(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool colorMode, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupOPLandIPLParvoChannel_17(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool colorMode, [MarshalAs(UnmanagedType.U1)] bool normaliseOutput);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupOPLandIPLParvoChannel_18(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool colorMode);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_setupOPLandIPLParvoChannel_19(IntPtr nativeObj);

        // C++:  void cv::bioinspired::Retina::write(String fs)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_write_10(IntPtr nativeObj, string fs);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void bioinspired_Retina_delete(IntPtr nativeObj);

    }
}
