#if !UNITY_WSA_10_0
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TextModule
{

    // C++: class OCRHMMDecoder
    //javadoc: OCRHMMDecoder

    public class OCRHMMDecoder : BaseOCR
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
                        text_OCRHMMDecoder_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal OCRHMMDecoder(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new OCRHMMDecoder __fromPtr__(IntPtr addr) { return new OCRHMMDecoder(addr); }

        //
        // C++: static Ptr_OCRHMMDecoder cv::text::OCRHMMDecoder::create(Ptr_OCRHMMDecoder_ClassifierCallback classifier, String vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, int mode = OCR_DECODER_VITERBI)
        //

        // Unknown type 'Ptr_OCRHMMDecoder_ClassifierCallback' (I), skipping the function


        //
        // C++: static Ptr_OCRHMMDecoder cv::text::OCRHMMDecoder::create(String filename, String vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, int mode = OCR_DECODER_VITERBI, int classifier = OCR_KNN_CLASSIFIER)
        //

        //javadoc: OCRHMMDecoder::create(filename, vocabulary, transition_probabilities_table, emission_probabilities_table, mode, classifier)
        public static OCRHMMDecoder create(string filename, string vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, int mode, int classifier)
        {
            if (transition_probabilities_table != null) transition_probabilities_table.ThrowIfDisposed();
            if (emission_probabilities_table != null) emission_probabilities_table.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        OCRHMMDecoder retVal = OCRHMMDecoder.__fromPtr__(text_OCRHMMDecoder_create_10(filename, vocabulary, transition_probabilities_table.nativeObj, emission_probabilities_table.nativeObj, mode, classifier));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: OCRHMMDecoder::create(filename, vocabulary, transition_probabilities_table, emission_probabilities_table, mode)
        public static OCRHMMDecoder create(string filename, string vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, int mode)
        {
            if (transition_probabilities_table != null) transition_probabilities_table.ThrowIfDisposed();
            if (emission_probabilities_table != null) emission_probabilities_table.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        OCRHMMDecoder retVal = OCRHMMDecoder.__fromPtr__(text_OCRHMMDecoder_create_11(filename, vocabulary, transition_probabilities_table.nativeObj, emission_probabilities_table.nativeObj, mode));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: OCRHMMDecoder::create(filename, vocabulary, transition_probabilities_table, emission_probabilities_table)
        public static OCRHMMDecoder create(string filename, string vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table)
        {
            if (transition_probabilities_table != null) transition_probabilities_table.ThrowIfDisposed();
            if (emission_probabilities_table != null) emission_probabilities_table.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        OCRHMMDecoder retVal = OCRHMMDecoder.__fromPtr__(text_OCRHMMDecoder_create_12(filename, vocabulary, transition_probabilities_table.nativeObj, emission_probabilities_table.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::text::OCRHMMDecoder::run(Mat image, Mat mask, int min_confidence, int component_level = 0)
        //

        //javadoc: OCRHMMDecoder::run(image, mask, min_confidence, component_level)
        public string run(Mat image, Mat mask, int min_confidence, int component_level)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (text_OCRHMMDecoder_run_10(nativeObj, image.nativeObj, mask.nativeObj, min_confidence, component_level));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: OCRHMMDecoder::run(image, mask, min_confidence)
        public string run(Mat image, Mat mask, int min_confidence)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (text_OCRHMMDecoder_run_11(nativeObj, image.nativeObj, mask.nativeObj, min_confidence));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::text::OCRHMMDecoder::run(Mat image, int min_confidence, int component_level = 0)
        //

        //javadoc: OCRHMMDecoder::run(image, min_confidence, component_level)
        public string run(Mat image, int min_confidence, int component_level)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (text_OCRHMMDecoder_run_12(nativeObj, image.nativeObj, min_confidence, component_level));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: OCRHMMDecoder::run(image, min_confidence)
        public string run(Mat image, int min_confidence)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (text_OCRHMMDecoder_run_13(nativeObj, image.nativeObj, min_confidence));
        
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



        // C++: static Ptr_OCRHMMDecoder cv::text::OCRHMMDecoder::create(String filename, String vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, int mode = OCR_DECODER_VITERBI, int classifier = OCR_KNN_CLASSIFIER)
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRHMMDecoder_create_10(string filename, string vocabulary, IntPtr transition_probabilities_table_nativeObj, IntPtr emission_probabilities_table_nativeObj, int mode, int classifier);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRHMMDecoder_create_11(string filename, string vocabulary, IntPtr transition_probabilities_table_nativeObj, IntPtr emission_probabilities_table_nativeObj, int mode);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRHMMDecoder_create_12(string filename, string vocabulary, IntPtr transition_probabilities_table_nativeObj, IntPtr emission_probabilities_table_nativeObj);

        // C++:  String cv::text::OCRHMMDecoder::run(Mat image, Mat mask, int min_confidence, int component_level = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRHMMDecoder_run_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, int min_confidence, int component_level);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRHMMDecoder_run_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, int min_confidence);

        // C++:  String cv::text::OCRHMMDecoder::run(Mat image, int min_confidence, int component_level = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRHMMDecoder_run_12(IntPtr nativeObj, IntPtr image_nativeObj, int min_confidence, int component_level);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRHMMDecoder_run_13(IntPtr nativeObj, IntPtr image_nativeObj, int min_confidence);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void text_OCRHMMDecoder_delete(IntPtr nativeObj);

    }
}
#endif