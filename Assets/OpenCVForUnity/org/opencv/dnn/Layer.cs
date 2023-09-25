#if !UNITY_WSA_10_0
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{

    // C++: class Layer
    //javadoc: Layer

    public class Layer : Algorithm
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
                        dnn_Layer_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Layer(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new Layer __fromPtr__(IntPtr addr) { return new Layer(addr); }

        //
        // C++:  int cv::dnn::Layer::outputNameToIndex(String outputName)
        //

        //javadoc: Layer::outputNameToIndex(outputName)
        public int outputNameToIndex(string outputName)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = dnn_Layer_outputNameToIndex_10(nativeObj, outputName);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::dnn::Layer::finalize(vector_Mat inputs, vector_Mat& outputs)
        //

        //javadoc: Layer::finalize(inputs, outputs)
        public void finalize(List<Mat> inputs, List<Mat> outputs)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat inputs_mat = Converters.vector_Mat_to_Mat(inputs);
        Mat outputs_mat = new Mat();
        dnn_Layer_finalize_10(nativeObj, inputs_mat.nativeObj, outputs_mat.nativeObj);
        Converters.Mat_to_vector_Mat(outputs_mat, outputs);
        outputs_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::dnn::Layer::run(vector_Mat inputs, vector_Mat& outputs, vector_Mat& internals)
        //

        //javadoc: Layer::run(inputs, outputs, internals)
        [Obsolete("This method is deprecated.")]
        public void run(List<Mat> inputs, List<Mat> outputs, List<Mat> internals)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat inputs_mat = Converters.vector_Mat_to_Mat(inputs);
        Mat outputs_mat = new Mat();
        Mat internals_mat = Converters.vector_Mat_to_Mat(internals);
        dnn_Layer_run_10(nativeObj, inputs_mat.nativeObj, outputs_mat.nativeObj, internals_mat.nativeObj);
        Converters.Mat_to_vector_Mat(outputs_mat, outputs);
        outputs_mat.release();
        Converters.Mat_to_vector_Mat(internals_mat, internals);
        internals_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++: vector_Mat Layer::blobs
        //

        //javadoc: Layer::get_blobs()
        public List<Mat> get_blobs()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        List<Mat> retVal = new List<Mat>();
        Mat retValMat = new Mat(dnn_Layer_get_1blobs_10(nativeObj));
        Converters.Mat_to_vector_Mat(retValMat, retVal);
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: void Layer::blobs
        //

        //javadoc: Layer::set_blobs(blobs)
        public void set_blobs(List<Mat> blobs)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat blobs_mat = Converters.vector_Mat_to_Mat(blobs);
        dnn_Layer_set_1blobs_10(nativeObj, blobs_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: String Layer::name
        //

        //javadoc: Layer::get_name()
        public string get_name()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (dnn_Layer_get_1name_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: String Layer::type
        //

        //javadoc: Layer::get_type()
        public string get_type()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (dnn_Layer_get_1type_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: int Layer::preferableTarget
        //

        //javadoc: Layer::get_preferableTarget()
        public int get_preferableTarget()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = dnn_Layer_get_1preferableTarget_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::dnn::Layer::outputNameToIndex(String outputName)
        [DllImport(LIBNAME)]
        private static extern int dnn_Layer_outputNameToIndex_10(IntPtr nativeObj, string outputName);

        // C++:  void cv::dnn::Layer::finalize(vector_Mat inputs, vector_Mat& outputs)
        [DllImport(LIBNAME)]
        private static extern void dnn_Layer_finalize_10(IntPtr nativeObj, IntPtr inputs_mat_nativeObj, IntPtr outputs_mat_nativeObj);

        // C++:  void cv::dnn::Layer::run(vector_Mat inputs, vector_Mat& outputs, vector_Mat& internals)
        [DllImport(LIBNAME)]
        private static extern void dnn_Layer_run_10(IntPtr nativeObj, IntPtr inputs_mat_nativeObj, IntPtr outputs_mat_nativeObj, IntPtr internals_mat_nativeObj);

        // C++: vector_Mat Layer::blobs
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Layer_get_1blobs_10(IntPtr nativeObj);

        // C++: void Layer::blobs
        [DllImport(LIBNAME)]
        private static extern void dnn_Layer_set_1blobs_10(IntPtr nativeObj, IntPtr blobs_mat_nativeObj);

        // C++: String Layer::name
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Layer_get_1name_10(IntPtr nativeObj);

        // C++: String Layer::type
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Layer_get_1type_10(IntPtr nativeObj);

        // C++: int Layer::preferableTarget
        [DllImport(LIBNAME)]
        private static extern int dnn_Layer_get_1preferableTarget_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_Layer_delete(IntPtr nativeObj);

    }
}
#endif