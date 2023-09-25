
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class FaceRecognizer
    //javadoc: FaceRecognizer

    public class FaceRecognizer : Algorithm
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
                        face_FaceRecognizer_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FaceRecognizer(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FaceRecognizer __fromPtr__(IntPtr addr) { return new FaceRecognizer(addr); }

        //
        // C++:  String cv::face::FaceRecognizer::getLabelInfo(int label)
        //

        //javadoc: FaceRecognizer::getLabelInfo(label)
        public string getLabelInfo(int label)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (face_FaceRecognizer_getLabelInfo_10(nativeObj, label));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  int cv::face::FaceRecognizer::predict(Mat src)
        //

        //javadoc: FaceRecognizer::predict_label(src)
        public int predict_label(Mat src)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = face_FaceRecognizer_predict_1label_10(nativeObj, src.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  vector_int cv::face::FaceRecognizer::getLabelsByString(String str)
        //

        //javadoc: FaceRecognizer::getLabelsByString(str)
        public MatOfInt getLabelsByString(string str)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        MatOfInt retVal = MatOfInt.fromNativeAddr(face_FaceRecognizer_getLabelsByString_10(nativeObj, str));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::face::FaceRecognizer::predict(Mat src, Ptr_PredictCollector collector)
        //

        //javadoc: FaceRecognizer::predict_collect(src, collector)
        public void predict_collect(Mat src, PredictCollector collector)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (collector != null) collector.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_FaceRecognizer_predict_1collect_10(nativeObj, src.nativeObj, collector.getNativeObjAddr());
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::face::FaceRecognizer::predict(Mat src, int& label, double& confidence)
        //

        //javadoc: FaceRecognizer::predict(src, label, confidence)
        public void predict(Mat src, int[] label, double[] confidence)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        double[] label_out = new double[1];
        double[] confidence_out = new double[1];
        face_FaceRecognizer_predict_10(nativeObj, src.nativeObj, label_out, confidence_out);
        if(label!=null) label[0] = (int)label_out[0];
        if(confidence!=null) confidence[0] = (double)confidence_out[0];
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::face::FaceRecognizer::read(String filename)
        //

        //javadoc: FaceRecognizer::read(filename)
        public void read(string filename)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_FaceRecognizer_read_10(nativeObj, filename);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::face::FaceRecognizer::setLabelInfo(int label, String strInfo)
        //

        //javadoc: FaceRecognizer::setLabelInfo(label, strInfo)
        public void setLabelInfo(int label, string strInfo)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_FaceRecognizer_setLabelInfo_10(nativeObj, label, strInfo);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::face::FaceRecognizer::train(vector_Mat src, Mat labels)
        //

        //javadoc: FaceRecognizer::train(src, labels)
        public void train(List<Mat> src, Mat labels)
        {
            ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat src_mat = Converters.vector_Mat_to_Mat(src);
        face_FaceRecognizer_train_10(nativeObj, src_mat.nativeObj, labels.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::face::FaceRecognizer::update(vector_Mat src, Mat labels)
        //

        //javadoc: FaceRecognizer::update(src, labels)
        public void update(List<Mat> src, Mat labels)
        {
            ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat src_mat = Converters.vector_Mat_to_Mat(src);
        face_FaceRecognizer_update_10(nativeObj, src_mat.nativeObj, labels.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::face::FaceRecognizer::write(String filename)
        //

        //javadoc: FaceRecognizer::write(filename)
        public void write(string filename)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_FaceRecognizer_write_10(nativeObj, filename);
        
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



        // C++:  String cv::face::FaceRecognizer::getLabelInfo(int label)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_FaceRecognizer_getLabelInfo_10(IntPtr nativeObj, int label);

        // C++:  int cv::face::FaceRecognizer::predict(Mat src)
        [DllImport(LIBNAME)]
        private static extern int face_FaceRecognizer_predict_1label_10(IntPtr nativeObj, IntPtr src_nativeObj);

        // C++:  vector_int cv::face::FaceRecognizer::getLabelsByString(String str)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_FaceRecognizer_getLabelsByString_10(IntPtr nativeObj, string str);

        // C++:  void cv::face::FaceRecognizer::predict(Mat src, Ptr_PredictCollector collector)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_predict_1collect_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr collector_nativeObj);

        // C++:  void cv::face::FaceRecognizer::predict(Mat src, int& label, double& confidence)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_predict_10(IntPtr nativeObj, IntPtr src_nativeObj, double[] label_out, double[] confidence_out);

        // C++:  void cv::face::FaceRecognizer::read(String filename)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_read_10(IntPtr nativeObj, string filename);

        // C++:  void cv::face::FaceRecognizer::setLabelInfo(int label, String strInfo)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_setLabelInfo_10(IntPtr nativeObj, int label, string strInfo);

        // C++:  void cv::face::FaceRecognizer::train(vector_Mat src, Mat labels)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_train_10(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr labels_nativeObj);

        // C++:  void cv::face::FaceRecognizer::update(vector_Mat src, Mat labels)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_update_10(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr labels_nativeObj);

        // C++:  void cv::face::FaceRecognizer::write(String filename)
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_write_10(IntPtr nativeObj, string filename);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_FaceRecognizer_delete(IntPtr nativeObj);

    }
}
