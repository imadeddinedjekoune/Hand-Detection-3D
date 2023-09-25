#if !UNITY_WSA_10_0
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TextModule
{

    // C++: class TextDetectorCNN
    //javadoc: TextDetectorCNN

    public class TextDetectorCNN : TextDetector
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
                        text_TextDetectorCNN_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TextDetectorCNN(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TextDetectorCNN __fromPtr__(IntPtr addr) { return new TextDetectorCNN(addr); }

        //
        // C++: static Ptr_TextDetectorCNN cv::text::TextDetectorCNN::create(String modelArchFilename, String modelWeightsFilename)
        //

        //javadoc: TextDetectorCNN::create(modelArchFilename, modelWeightsFilename)
        public static TextDetectorCNN create(string modelArchFilename, string modelWeightsFilename)
        {
#if UNITY_5_3_OR_NEWER
        
        TextDetectorCNN retVal = TextDetectorCNN.__fromPtr__(text_TextDetectorCNN_create_10(modelArchFilename, modelWeightsFilename));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::text::TextDetectorCNN::detect(Mat inputImage, vector_Rect& Bbox, vector_float& confidence)
        //

        //javadoc: TextDetectorCNN::detect(inputImage, Bbox, confidence)
        public override void detect(Mat inputImage, MatOfRect Bbox, MatOfFloat confidence)
        {
            ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();
            if (Bbox != null) Bbox.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat Bbox_mat = Bbox;
        Mat confidence_mat = confidence;
        text_TextDetectorCNN_detect_10(nativeObj, inputImage.nativeObj, Bbox_mat.nativeObj, confidence_mat.nativeObj);
        
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



        // C++: static Ptr_TextDetectorCNN cv::text::TextDetectorCNN::create(String modelArchFilename, String modelWeightsFilename)
        [DllImport(LIBNAME)]
        private static extern IntPtr text_TextDetectorCNN_create_10(string modelArchFilename, string modelWeightsFilename);

        // C++:  void cv::text::TextDetectorCNN::detect(Mat inputImage, vector_Rect& Bbox, vector_float& confidence)
        [DllImport(LIBNAME)]
        private static extern void text_TextDetectorCNN_detect_10(IntPtr nativeObj, IntPtr inputImage_nativeObj, IntPtr Bbox_mat_nativeObj, IntPtr confidence_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void text_TextDetectorCNN_delete(IntPtr nativeObj);

    }
}
#endif