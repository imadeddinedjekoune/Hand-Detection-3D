
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.BioinspiredModule
{

    // C++: class RetinaFastToneMapping
    //javadoc: RetinaFastToneMapping

    public class RetinaFastToneMapping : Algorithm
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
                        bioinspired_RetinaFastToneMapping_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal RetinaFastToneMapping(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new RetinaFastToneMapping __fromPtr__(IntPtr addr) { return new RetinaFastToneMapping(addr); }

        //
        // C++: static Ptr_RetinaFastToneMapping cv::bioinspired::RetinaFastToneMapping::create(Size inputSize)
        //

        //javadoc: RetinaFastToneMapping::create(inputSize)
        public static RetinaFastToneMapping create(Size inputSize)
        {
#if UNITY_5_3_OR_NEWER
        
        RetinaFastToneMapping retVal = RetinaFastToneMapping.__fromPtr__(bioinspired_RetinaFastToneMapping_create_10(inputSize.width, inputSize.height));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::bioinspired::RetinaFastToneMapping::applyFastToneMapping(Mat inputImage, Mat& outputToneMappedImage)
        //

        //javadoc: RetinaFastToneMapping::applyFastToneMapping(inputImage, outputToneMappedImage)
        public void applyFastToneMapping(Mat inputImage, Mat outputToneMappedImage)
        {
            ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();
            if (outputToneMappedImage != null) outputToneMappedImage.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_RetinaFastToneMapping_applyFastToneMapping_10(nativeObj, inputImage.nativeObj, outputToneMappedImage.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::RetinaFastToneMapping::setup(float photoreceptorsNeighborhoodRadius = 3.f, float ganglioncellsNeighborhoodRadius = 1.f, float meanLuminanceModulatorK = 1.f)
        //

        //javadoc: RetinaFastToneMapping::setup(photoreceptorsNeighborhoodRadius, ganglioncellsNeighborhoodRadius, meanLuminanceModulatorK)
        public void setup(float photoreceptorsNeighborhoodRadius, float ganglioncellsNeighborhoodRadius, float meanLuminanceModulatorK)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_RetinaFastToneMapping_setup_10(nativeObj, photoreceptorsNeighborhoodRadius, ganglioncellsNeighborhoodRadius, meanLuminanceModulatorK);
        
        return;
#else
            return;
#endif
        }

        //javadoc: RetinaFastToneMapping::setup(photoreceptorsNeighborhoodRadius, ganglioncellsNeighborhoodRadius)
        public void setup(float photoreceptorsNeighborhoodRadius, float ganglioncellsNeighborhoodRadius)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_RetinaFastToneMapping_setup_11(nativeObj, photoreceptorsNeighborhoodRadius, ganglioncellsNeighborhoodRadius);
        
        return;
#else
            return;
#endif
        }

        //javadoc: RetinaFastToneMapping::setup(photoreceptorsNeighborhoodRadius)
        public void setup(float photoreceptorsNeighborhoodRadius)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_RetinaFastToneMapping_setup_12(nativeObj, photoreceptorsNeighborhoodRadius);
        
        return;
#else
            return;
#endif
        }

        //javadoc: RetinaFastToneMapping::setup()
        public void setup()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_RetinaFastToneMapping_setup_13(nativeObj);
        
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



        // C++: static Ptr_RetinaFastToneMapping cv::bioinspired::RetinaFastToneMapping::create(Size inputSize)
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_RetinaFastToneMapping_create_10(double inputSize_width, double inputSize_height);

        // C++:  void cv::bioinspired::RetinaFastToneMapping::applyFastToneMapping(Mat inputImage, Mat& outputToneMappedImage)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_applyFastToneMapping_10(IntPtr nativeObj, IntPtr inputImage_nativeObj, IntPtr outputToneMappedImage_nativeObj);

        // C++:  void cv::bioinspired::RetinaFastToneMapping::setup(float photoreceptorsNeighborhoodRadius = 3.f, float ganglioncellsNeighborhoodRadius = 1.f, float meanLuminanceModulatorK = 1.f)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_setup_10(IntPtr nativeObj, float photoreceptorsNeighborhoodRadius, float ganglioncellsNeighborhoodRadius, float meanLuminanceModulatorK);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_setup_11(IntPtr nativeObj, float photoreceptorsNeighborhoodRadius, float ganglioncellsNeighborhoodRadius);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_setup_12(IntPtr nativeObj, float photoreceptorsNeighborhoodRadius);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_setup_13(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_delete(IntPtr nativeObj);

    }
}
