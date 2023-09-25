
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.BioinspiredModule
{

    // C++: class TransientAreasSegmentationModule
    //javadoc: TransientAreasSegmentationModule

    public class TransientAreasSegmentationModule : Algorithm
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
                        bioinspired_TransientAreasSegmentationModule_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TransientAreasSegmentationModule(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TransientAreasSegmentationModule __fromPtr__(IntPtr addr) { return new TransientAreasSegmentationModule(addr); }

        //
        // C++: static Ptr_TransientAreasSegmentationModule cv::bioinspired::TransientAreasSegmentationModule::create(Size inputSize)
        //

        //javadoc: TransientAreasSegmentationModule::create(inputSize)
        public static TransientAreasSegmentationModule create(Size inputSize)
        {
#if UNITY_5_3_OR_NEWER
        
        TransientAreasSegmentationModule retVal = TransientAreasSegmentationModule.__fromPtr__(bioinspired_TransientAreasSegmentationModule_create_10(inputSize.width, inputSize.height));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Size cv::bioinspired::TransientAreasSegmentationModule::getSize()
        //

        //javadoc: TransientAreasSegmentationModule::getSize()
        public Size getSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
bioinspired_TransientAreasSegmentationModule_getSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::bioinspired::TransientAreasSegmentationModule::printSetup()
        //

        //javadoc: TransientAreasSegmentationModule::printSetup()
        public string printSetup()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (bioinspired_TransientAreasSegmentationModule_printSetup_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::clearAllBuffers()
        //

        //javadoc: TransientAreasSegmentationModule::clearAllBuffers()
        public void clearAllBuffers()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_TransientAreasSegmentationModule_clearAllBuffers_10(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::getSegmentationPicture(Mat& transientAreas)
        //

        //javadoc: TransientAreasSegmentationModule::getSegmentationPicture(transientAreas)
        public void getSegmentationPicture(Mat transientAreas)
        {
            ThrowIfDisposed();
            if (transientAreas != null) transientAreas.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_TransientAreasSegmentationModule_getSegmentationPicture_10(nativeObj, transientAreas.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::run(Mat inputToSegment, int channelIndex = 0)
        //

        //javadoc: TransientAreasSegmentationModule::run(inputToSegment, channelIndex)
        public void run(Mat inputToSegment, int channelIndex)
        {
            ThrowIfDisposed();
            if (inputToSegment != null) inputToSegment.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_TransientAreasSegmentationModule_run_10(nativeObj, inputToSegment.nativeObj, channelIndex);
        
        return;
#else
            return;
#endif
        }

        //javadoc: TransientAreasSegmentationModule::run(inputToSegment)
        public void run(Mat inputToSegment)
        {
            ThrowIfDisposed();
            if (inputToSegment != null) inputToSegment.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_TransientAreasSegmentationModule_run_11(nativeObj, inputToSegment.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::setup(String segmentationParameterFile = "", bool applyDefaultSetupOnFailure = true)
        //

        //javadoc: TransientAreasSegmentationModule::setup(segmentationParameterFile, applyDefaultSetupOnFailure)
        public void setup(string segmentationParameterFile, bool applyDefaultSetupOnFailure)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_TransientAreasSegmentationModule_setup_10(nativeObj, segmentationParameterFile, applyDefaultSetupOnFailure);
        
        return;
#else
            return;
#endif
        }

        //javadoc: TransientAreasSegmentationModule::setup(segmentationParameterFile)
        public void setup(string segmentationParameterFile)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_TransientAreasSegmentationModule_setup_11(nativeObj, segmentationParameterFile);
        
        return;
#else
            return;
#endif
        }

        //javadoc: TransientAreasSegmentationModule::setup()
        public void setup()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_TransientAreasSegmentationModule_setup_12(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::write(String fs)
        //

        //javadoc: TransientAreasSegmentationModule::write(fs)
        public void write(string fs)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bioinspired_TransientAreasSegmentationModule_write_10(nativeObj, fs);
        
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



        // C++: static Ptr_TransientAreasSegmentationModule cv::bioinspired::TransientAreasSegmentationModule::create(Size inputSize)
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_TransientAreasSegmentationModule_create_10(double inputSize_width, double inputSize_height);

        // C++:  Size cv::bioinspired::TransientAreasSegmentationModule::getSize()
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_getSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  String cv::bioinspired::TransientAreasSegmentationModule::printSetup()
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_TransientAreasSegmentationModule_printSetup_10(IntPtr nativeObj);

        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::clearAllBuffers()
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_clearAllBuffers_10(IntPtr nativeObj);

        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::getSegmentationPicture(Mat& transientAreas)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_getSegmentationPicture_10(IntPtr nativeObj, IntPtr transientAreas_nativeObj);

        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::run(Mat inputToSegment, int channelIndex = 0)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_run_10(IntPtr nativeObj, IntPtr inputToSegment_nativeObj, int channelIndex);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_run_11(IntPtr nativeObj, IntPtr inputToSegment_nativeObj);

        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::setup(String segmentationParameterFile = "", bool applyDefaultSetupOnFailure = true)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_setup_10(IntPtr nativeObj, string segmentationParameterFile, [MarshalAs(UnmanagedType.U1)] bool applyDefaultSetupOnFailure);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_setup_11(IntPtr nativeObj, string segmentationParameterFile);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_setup_12(IntPtr nativeObj);

        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::write(String fs)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_write_10(IntPtr nativeObj, string fs);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_delete(IntPtr nativeObj);

    }
}
