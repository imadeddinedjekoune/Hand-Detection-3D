#if !UNITY_WSA_10_0
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{
    // C++: class Dnn
    //javadoc: Dnn

    public class Dnn
    {

        // C++: enum Target
        public const int DNN_TARGET_CPU = 0;
        public const int DNN_TARGET_OPENCL = 1;
        public const int DNN_TARGET_OPENCL_FP16 = 2;
        public const int DNN_TARGET_MYRIAD = 3;
        public const int DNN_TARGET_VULKAN = 4;
        public const int DNN_TARGET_FPGA = 5;
        // C++: enum Backend
        public const int DNN_BACKEND_DEFAULT = 0;
        public const int DNN_BACKEND_HALIDE = 1;
        public const int DNN_BACKEND_INFERENCE_ENGINE = 2;
        public const int DNN_BACKEND_OPENCV = 3;
        public const int DNN_BACKEND_VKCOM = 4;
        //
        // C++:  Mat cv::dnn::blobFromImage(Mat image, double scalefactor = 1.0, Size size = Size(), Scalar mean = Scalar(), bool swapRB = false, bool crop = false, int ddepth = CV_32F)
        //

        //javadoc: blobFromImage(image, scalefactor, size, mean, swapRB, crop, ddepth)
        public static Mat blobFromImage(Mat image, double scalefactor, Size size, Scalar mean, bool swapRB, bool crop, int ddepth)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(dnn_Dnn_blobFromImage_10(image.nativeObj, scalefactor, size.width, size.height, mean.val[0], mean.val[1], mean.val[2], mean.val[3], swapRB, crop, ddepth));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: blobFromImage(image, scalefactor, size, mean, swapRB, crop)
        public static Mat blobFromImage(Mat image, double scalefactor, Size size, Scalar mean, bool swapRB, bool crop)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(dnn_Dnn_blobFromImage_11(image.nativeObj, scalefactor, size.width, size.height, mean.val[0], mean.val[1], mean.val[2], mean.val[3], swapRB, crop));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: blobFromImage(image, scalefactor, size, mean, swapRB)
        public static Mat blobFromImage(Mat image, double scalefactor, Size size, Scalar mean, bool swapRB)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(dnn_Dnn_blobFromImage_12(image.nativeObj, scalefactor, size.width, size.height, mean.val[0], mean.val[1], mean.val[2], mean.val[3], swapRB));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: blobFromImage(image, scalefactor, size, mean)
        public static Mat blobFromImage(Mat image, double scalefactor, Size size, Scalar mean)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(dnn_Dnn_blobFromImage_13(image.nativeObj, scalefactor, size.width, size.height, mean.val[0], mean.val[1], mean.val[2], mean.val[3]));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: blobFromImage(image, scalefactor, size)
        public static Mat blobFromImage(Mat image, double scalefactor, Size size)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(dnn_Dnn_blobFromImage_14(image.nativeObj, scalefactor, size.width, size.height));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: blobFromImage(image, scalefactor)
        public static Mat blobFromImage(Mat image, double scalefactor)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(dnn_Dnn_blobFromImage_15(image.nativeObj, scalefactor));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: blobFromImage(image)
        public static Mat blobFromImage(Mat image)
        {
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(dnn_Dnn_blobFromImage_16(image.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::dnn::blobFromImages(vector_Mat images, double scalefactor = 1.0, Size size = Size(), Scalar mean = Scalar(), bool swapRB = false, bool crop = false, int ddepth = CV_32F)
        //

        //javadoc: blobFromImages(images, scalefactor, size, mean, swapRB, crop, ddepth)
        public static Mat blobFromImages(List<Mat> images, double scalefactor, Size size, Scalar mean, bool swapRB, bool crop, int ddepth)
        {
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_Mat_to_Mat(images);
        Mat retVal = new Mat(dnn_Dnn_blobFromImages_10(images_mat.nativeObj, scalefactor, size.width, size.height, mean.val[0], mean.val[1], mean.val[2], mean.val[3], swapRB, crop, ddepth));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: blobFromImages(images, scalefactor, size, mean, swapRB, crop)
        public static Mat blobFromImages(List<Mat> images, double scalefactor, Size size, Scalar mean, bool swapRB, bool crop)
        {
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_Mat_to_Mat(images);
        Mat retVal = new Mat(dnn_Dnn_blobFromImages_11(images_mat.nativeObj, scalefactor, size.width, size.height, mean.val[0], mean.val[1], mean.val[2], mean.val[3], swapRB, crop));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: blobFromImages(images, scalefactor, size, mean, swapRB)
        public static Mat blobFromImages(List<Mat> images, double scalefactor, Size size, Scalar mean, bool swapRB)
        {
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_Mat_to_Mat(images);
        Mat retVal = new Mat(dnn_Dnn_blobFromImages_12(images_mat.nativeObj, scalefactor, size.width, size.height, mean.val[0], mean.val[1], mean.val[2], mean.val[3], swapRB));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: blobFromImages(images, scalefactor, size, mean)
        public static Mat blobFromImages(List<Mat> images, double scalefactor, Size size, Scalar mean)
        {
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_Mat_to_Mat(images);
        Mat retVal = new Mat(dnn_Dnn_blobFromImages_13(images_mat.nativeObj, scalefactor, size.width, size.height, mean.val[0], mean.val[1], mean.val[2], mean.val[3]));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: blobFromImages(images, scalefactor, size)
        public static Mat blobFromImages(List<Mat> images, double scalefactor, Size size)
        {
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_Mat_to_Mat(images);
        Mat retVal = new Mat(dnn_Dnn_blobFromImages_14(images_mat.nativeObj, scalefactor, size.width, size.height));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: blobFromImages(images, scalefactor)
        public static Mat blobFromImages(List<Mat> images, double scalefactor)
        {
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_Mat_to_Mat(images);
        Mat retVal = new Mat(dnn_Dnn_blobFromImages_15(images_mat.nativeObj, scalefactor));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: blobFromImages(images)
        public static Mat blobFromImages(List<Mat> images)
        {
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_Mat_to_Mat(images);
        Mat retVal = new Mat(dnn_Dnn_blobFromImages_16(images_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::dnn::readTensorFromONNX(String path)
        //

        //javadoc: readTensorFromONNX(path)
        public static Mat readTensorFromONNX(string path)
        {
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(dnn_Dnn_readTensorFromONNX_10(path));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::dnn::readTorchBlob(String filename, bool isBinary = true)
        //

        //javadoc: readTorchBlob(filename, isBinary)
        public static Mat readTorchBlob(string filename, bool isBinary)
        {
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(dnn_Dnn_readTorchBlob_10(filename, isBinary));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: readTorchBlob(filename)
        public static Mat readTorchBlob(string filename)
        {
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(dnn_Dnn_readTorchBlob_11(filename));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Net cv::dnn::readNet(String framework, vector_uchar bufferModel, vector_uchar bufferConfig = std::vector<uchar>())
        //

        //javadoc: readNet(framework, bufferModel, bufferConfig)
        public static Net readNet(string framework, MatOfByte bufferModel, MatOfByte bufferConfig)
        {
            if (bufferModel != null) bufferModel.ThrowIfDisposed();
            if (bufferConfig != null) bufferConfig.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bufferModel_mat = bufferModel;
        Mat bufferConfig_mat = bufferConfig;
        Net retVal = new Net(dnn_Dnn_readNet_10(framework, bufferModel_mat.nativeObj, bufferConfig_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: readNet(framework, bufferModel)
        public static Net readNet(string framework, MatOfByte bufferModel)
        {
            if (bufferModel != null) bufferModel.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bufferModel_mat = bufferModel;
        Net retVal = new Net(dnn_Dnn_readNet_11(framework, bufferModel_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Net cv::dnn::readNet(String model, String config = "", String framework = "")
        //

        //javadoc: readNet(model, config, framework)
        public static Net readNet(string model, string config, string framework)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNet_12(model, config, framework));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: readNet(model, config)
        public static Net readNet(string model, string config)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNet_13(model, config));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: readNet(model)
        public static Net readNet(string model)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNet_14(model));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Net cv::dnn::readNetFromCaffe(String prototxt, String caffeModel = String())
        //

        //javadoc: readNetFromCaffe(prototxt, caffeModel)
        public static Net readNetFromCaffe(string prototxt, string caffeModel)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNetFromCaffe_10(prototxt, caffeModel));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: readNetFromCaffe(prototxt)
        public static Net readNetFromCaffe(string prototxt)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNetFromCaffe_11(prototxt));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Net cv::dnn::readNetFromCaffe(vector_uchar bufferProto, vector_uchar bufferModel = std::vector<uchar>())
        //

        //javadoc: readNetFromCaffe(bufferProto, bufferModel)
        public static Net readNetFromCaffe(MatOfByte bufferProto, MatOfByte bufferModel)
        {
            if (bufferProto != null) bufferProto.ThrowIfDisposed();
            if (bufferModel != null) bufferModel.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bufferProto_mat = bufferProto;
        Mat bufferModel_mat = bufferModel;
        Net retVal = new Net(dnn_Dnn_readNetFromCaffe_12(bufferProto_mat.nativeObj, bufferModel_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: readNetFromCaffe(bufferProto)
        public static Net readNetFromCaffe(MatOfByte bufferProto)
        {
            if (bufferProto != null) bufferProto.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bufferProto_mat = bufferProto;
        Net retVal = new Net(dnn_Dnn_readNetFromCaffe_13(bufferProto_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Net cv::dnn::readNetFromDarknet(String cfgFile, String darknetModel = String())
        //

        //javadoc: readNetFromDarknet(cfgFile, darknetModel)
        public static Net readNetFromDarknet(string cfgFile, string darknetModel)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNetFromDarknet_10(cfgFile, darknetModel));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: readNetFromDarknet(cfgFile)
        public static Net readNetFromDarknet(string cfgFile)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNetFromDarknet_11(cfgFile));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Net cv::dnn::readNetFromDarknet(vector_uchar bufferCfg, vector_uchar bufferModel = std::vector<uchar>())
        //

        //javadoc: readNetFromDarknet(bufferCfg, bufferModel)
        public static Net readNetFromDarknet(MatOfByte bufferCfg, MatOfByte bufferModel)
        {
            if (bufferCfg != null) bufferCfg.ThrowIfDisposed();
            if (bufferModel != null) bufferModel.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bufferCfg_mat = bufferCfg;
        Mat bufferModel_mat = bufferModel;
        Net retVal = new Net(dnn_Dnn_readNetFromDarknet_12(bufferCfg_mat.nativeObj, bufferModel_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: readNetFromDarknet(bufferCfg)
        public static Net readNetFromDarknet(MatOfByte bufferCfg)
        {
            if (bufferCfg != null) bufferCfg.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bufferCfg_mat = bufferCfg;
        Net retVal = new Net(dnn_Dnn_readNetFromDarknet_13(bufferCfg_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Net cv::dnn::readNetFromModelOptimizer(String xml, String bin)
        //

        //javadoc: readNetFromModelOptimizer(xml, bin)
        public static Net readNetFromModelOptimizer(string xml, string bin)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNetFromModelOptimizer_10(xml, bin));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Net cv::dnn::readNetFromONNX(String onnxFile)
        //

        //javadoc: readNetFromONNX(onnxFile)
        public static Net readNetFromONNX(string onnxFile)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNetFromONNX_10(onnxFile));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Net cv::dnn::readNetFromTensorflow(String model, String config = String())
        //

        //javadoc: readNetFromTensorflow(model, config)
        public static Net readNetFromTensorflow(string model, string config)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNetFromTensorflow_10(model, config));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: readNetFromTensorflow(model)
        public static Net readNetFromTensorflow(string model)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNetFromTensorflow_11(model));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Net cv::dnn::readNetFromTensorflow(vector_uchar bufferModel, vector_uchar bufferConfig = std::vector<uchar>())
        //

        //javadoc: readNetFromTensorflow(bufferModel, bufferConfig)
        public static Net readNetFromTensorflow(MatOfByte bufferModel, MatOfByte bufferConfig)
        {
            if (bufferModel != null) bufferModel.ThrowIfDisposed();
            if (bufferConfig != null) bufferConfig.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bufferModel_mat = bufferModel;
        Mat bufferConfig_mat = bufferConfig;
        Net retVal = new Net(dnn_Dnn_readNetFromTensorflow_12(bufferModel_mat.nativeObj, bufferConfig_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: readNetFromTensorflow(bufferModel)
        public static Net readNetFromTensorflow(MatOfByte bufferModel)
        {
            if (bufferModel != null) bufferModel.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bufferModel_mat = bufferModel;
        Net retVal = new Net(dnn_Dnn_readNetFromTensorflow_13(bufferModel_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Net cv::dnn::readNetFromTorch(String model, bool isBinary = true, bool evaluate = true)
        //

        //javadoc: readNetFromTorch(model, isBinary, evaluate)
        public static Net readNetFromTorch(string model, bool isBinary, bool evaluate)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNetFromTorch_10(model, isBinary, evaluate));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: readNetFromTorch(model, isBinary)
        public static Net readNetFromTorch(string model, bool isBinary)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNetFromTorch_11(model, isBinary));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: readNetFromTorch(model)
        public static Net readNetFromTorch(string model)
        {
#if UNITY_5_3_OR_NEWER
        
        Net retVal = new Net(dnn_Dnn_readNetFromTorch_12(model));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::dnn::getInferenceEngineVPUType()
        //

        //javadoc: getInferenceEngineVPUType()
        public static string getInferenceEngineVPUType()
        {
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (dnn_Dnn_getInferenceEngineVPUType_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::dnn::NMSBoxes(vector_Rect bboxes, vector_float scores, float score_threshold, float nms_threshold, vector_int& indices, float eta = 1.f, int top_k = 0)
        //

        //javadoc: NMSBoxes(bboxes, scores, score_threshold, nms_threshold, indices, eta, top_k)
        public static void NMSBoxes(MatOfRect bboxes, MatOfFloat scores, float score_threshold, float nms_threshold, MatOfInt indices, float eta, int top_k)
        {
            if (bboxes != null) bboxes.ThrowIfDisposed();
            if (scores != null) scores.ThrowIfDisposed();
            if (indices != null) indices.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bboxes_mat = bboxes;
        Mat scores_mat = scores;
        Mat indices_mat = indices;
        dnn_Dnn_NMSBoxes_10(bboxes_mat.nativeObj, scores_mat.nativeObj, score_threshold, nms_threshold, indices_mat.nativeObj, eta, top_k);
        
        return;
#else
            return;
#endif
        }

        //javadoc: NMSBoxes(bboxes, scores, score_threshold, nms_threshold, indices, eta)
        public static void NMSBoxes(MatOfRect bboxes, MatOfFloat scores, float score_threshold, float nms_threshold, MatOfInt indices, float eta)
        {
            if (bboxes != null) bboxes.ThrowIfDisposed();
            if (scores != null) scores.ThrowIfDisposed();
            if (indices != null) indices.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bboxes_mat = bboxes;
        Mat scores_mat = scores;
        Mat indices_mat = indices;
        dnn_Dnn_NMSBoxes_11(bboxes_mat.nativeObj, scores_mat.nativeObj, score_threshold, nms_threshold, indices_mat.nativeObj, eta);
        
        return;
#else
            return;
#endif
        }

        //javadoc: NMSBoxes(bboxes, scores, score_threshold, nms_threshold, indices)
        public static void NMSBoxes(MatOfRect bboxes, MatOfFloat scores, float score_threshold, float nms_threshold, MatOfInt indices)
        {
            if (bboxes != null) bboxes.ThrowIfDisposed();
            if (scores != null) scores.ThrowIfDisposed();
            if (indices != null) indices.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bboxes_mat = bboxes;
        Mat scores_mat = scores;
        Mat indices_mat = indices;
        dnn_Dnn_NMSBoxes_12(bboxes_mat.nativeObj, scores_mat.nativeObj, score_threshold, nms_threshold, indices_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::dnn::NMSBoxes(vector_Rect2d bboxes, vector_float scores, float score_threshold, float nms_threshold, vector_int& indices, float eta = 1.f, int top_k = 0)
        //

        //javadoc: NMSBoxes(bboxes, scores, score_threshold, nms_threshold, indices, eta, top_k)
        public static void NMSBoxes(MatOfRect2d bboxes, MatOfFloat scores, float score_threshold, float nms_threshold, MatOfInt indices, float eta, int top_k)
        {
            if (bboxes != null) bboxes.ThrowIfDisposed();
            if (scores != null) scores.ThrowIfDisposed();
            if (indices != null) indices.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bboxes_mat = bboxes;
        Mat scores_mat = scores;
        Mat indices_mat = indices;
        dnn_Dnn_NMSBoxes_13(bboxes_mat.nativeObj, scores_mat.nativeObj, score_threshold, nms_threshold, indices_mat.nativeObj, eta, top_k);
        
        return;
#else
            return;
#endif
        }

        //javadoc: NMSBoxes(bboxes, scores, score_threshold, nms_threshold, indices, eta)
        public static void NMSBoxes(MatOfRect2d bboxes, MatOfFloat scores, float score_threshold, float nms_threshold, MatOfInt indices, float eta)
        {
            if (bboxes != null) bboxes.ThrowIfDisposed();
            if (scores != null) scores.ThrowIfDisposed();
            if (indices != null) indices.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bboxes_mat = bboxes;
        Mat scores_mat = scores;
        Mat indices_mat = indices;
        dnn_Dnn_NMSBoxes_14(bboxes_mat.nativeObj, scores_mat.nativeObj, score_threshold, nms_threshold, indices_mat.nativeObj, eta);
        
        return;
#else
            return;
#endif
        }

        //javadoc: NMSBoxes(bboxes, scores, score_threshold, nms_threshold, indices)
        public static void NMSBoxes(MatOfRect2d bboxes, MatOfFloat scores, float score_threshold, float nms_threshold, MatOfInt indices)
        {
            if (bboxes != null) bboxes.ThrowIfDisposed();
            if (scores != null) scores.ThrowIfDisposed();
            if (indices != null) indices.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bboxes_mat = bboxes;
        Mat scores_mat = scores;
        Mat indices_mat = indices;
        dnn_Dnn_NMSBoxes_15(bboxes_mat.nativeObj, scores_mat.nativeObj, score_threshold, nms_threshold, indices_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::dnn::NMSBoxes(vector_RotatedRect bboxes, vector_float scores, float score_threshold, float nms_threshold, vector_int& indices, float eta = 1.f, int top_k = 0)
        //

        //javadoc: NMSBoxesRotated(bboxes, scores, score_threshold, nms_threshold, indices, eta, top_k)
        public static void NMSBoxesRotated(MatOfRotatedRect bboxes, MatOfFloat scores, float score_threshold, float nms_threshold, MatOfInt indices, float eta, int top_k)
        {
            if (bboxes != null) bboxes.ThrowIfDisposed();
            if (scores != null) scores.ThrowIfDisposed();
            if (indices != null) indices.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bboxes_mat = bboxes;
        Mat scores_mat = scores;
        Mat indices_mat = indices;
        dnn_Dnn_NMSBoxesRotated_10(bboxes_mat.nativeObj, scores_mat.nativeObj, score_threshold, nms_threshold, indices_mat.nativeObj, eta, top_k);
        
        return;
#else
            return;
#endif
        }

        //javadoc: NMSBoxesRotated(bboxes, scores, score_threshold, nms_threshold, indices, eta)
        public static void NMSBoxesRotated(MatOfRotatedRect bboxes, MatOfFloat scores, float score_threshold, float nms_threshold, MatOfInt indices, float eta)
        {
            if (bboxes != null) bboxes.ThrowIfDisposed();
            if (scores != null) scores.ThrowIfDisposed();
            if (indices != null) indices.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bboxes_mat = bboxes;
        Mat scores_mat = scores;
        Mat indices_mat = indices;
        dnn_Dnn_NMSBoxesRotated_11(bboxes_mat.nativeObj, scores_mat.nativeObj, score_threshold, nms_threshold, indices_mat.nativeObj, eta);
        
        return;
#else
            return;
#endif
        }

        //javadoc: NMSBoxesRotated(bboxes, scores, score_threshold, nms_threshold, indices)
        public static void NMSBoxesRotated(MatOfRotatedRect bboxes, MatOfFloat scores, float score_threshold, float nms_threshold, MatOfInt indices)
        {
            if (bboxes != null) bboxes.ThrowIfDisposed();
            if (scores != null) scores.ThrowIfDisposed();
            if (indices != null) indices.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat bboxes_mat = bboxes;
        Mat scores_mat = scores;
        Mat indices_mat = indices;
        dnn_Dnn_NMSBoxesRotated_12(bboxes_mat.nativeObj, scores_mat.nativeObj, score_threshold, nms_threshold, indices_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::dnn::imagesFromBlob(Mat blob_, vector_Mat& images_)
        //

        //javadoc: imagesFromBlob(blob_, images_)
        public static void imagesFromBlob(Mat blob_, List<Mat> images_)
        {
            if (blob_ != null) blob_.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat images__mat = new Mat();
        dnn_Dnn_imagesFromBlob_10(blob_.nativeObj, images__mat.nativeObj);
        Converters.Mat_to_vector_Mat(images__mat, images_);
        images__mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::dnn::resetMyriadDevice()
        //

        //javadoc: resetMyriadDevice()
        public static void resetMyriadDevice()
        {
#if UNITY_5_3_OR_NEWER
        
        dnn_Dnn_resetMyriadDevice_10();
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::dnn::shrinkCaffeModel(String src, String dst, vector_String layersTypes = std::vector<String>())
        //

        //javadoc: shrinkCaffeModel(src, dst, layersTypes)
        public static void shrinkCaffeModel(string src, string dst, List<string> layersTypes)
        {
#if UNITY_5_3_OR_NEWER
        Mat layersTypes_mat = Converters.vector_String_to_Mat(layersTypes);
        dnn_Dnn_shrinkCaffeModel_10(src, dst, layersTypes_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: shrinkCaffeModel(src, dst)
        public static void shrinkCaffeModel(string src, string dst)
        {
#if UNITY_5_3_OR_NEWER
        
        dnn_Dnn_shrinkCaffeModel_11(src, dst);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::dnn::writeTextGraph(String model, String output)
        //

        //javadoc: writeTextGraph(model, output)
        public static void writeTextGraph(string model, string output)
        {
#if UNITY_5_3_OR_NEWER
        
        dnn_Dnn_writeTextGraph_10(model, output);
        
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



        // C++:  Mat cv::dnn::blobFromImage(Mat image, double scalefactor = 1.0, Size size = Size(), Scalar mean = Scalar(), bool swapRB = false, bool crop = false, int ddepth = CV_32F)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImage_10(IntPtr image_nativeObj, double scalefactor, double size_width, double size_height, double mean_val0, double mean_val1, double mean_val2, double mean_val3, [MarshalAs(UnmanagedType.U1)] bool swapRB, [MarshalAs(UnmanagedType.U1)] bool crop, int ddepth);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImage_11(IntPtr image_nativeObj, double scalefactor, double size_width, double size_height, double mean_val0, double mean_val1, double mean_val2, double mean_val3, [MarshalAs(UnmanagedType.U1)] bool swapRB, [MarshalAs(UnmanagedType.U1)] bool crop);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImage_12(IntPtr image_nativeObj, double scalefactor, double size_width, double size_height, double mean_val0, double mean_val1, double mean_val2, double mean_val3, [MarshalAs(UnmanagedType.U1)] bool swapRB);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImage_13(IntPtr image_nativeObj, double scalefactor, double size_width, double size_height, double mean_val0, double mean_val1, double mean_val2, double mean_val3);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImage_14(IntPtr image_nativeObj, double scalefactor, double size_width, double size_height);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImage_15(IntPtr image_nativeObj, double scalefactor);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImage_16(IntPtr image_nativeObj);

        // C++:  Mat cv::dnn::blobFromImages(vector_Mat images, double scalefactor = 1.0, Size size = Size(), Scalar mean = Scalar(), bool swapRB = false, bool crop = false, int ddepth = CV_32F)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImages_10(IntPtr images_mat_nativeObj, double scalefactor, double size_width, double size_height, double mean_val0, double mean_val1, double mean_val2, double mean_val3, [MarshalAs(UnmanagedType.U1)] bool swapRB, [MarshalAs(UnmanagedType.U1)] bool crop, int ddepth);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImages_11(IntPtr images_mat_nativeObj, double scalefactor, double size_width, double size_height, double mean_val0, double mean_val1, double mean_val2, double mean_val3, [MarshalAs(UnmanagedType.U1)] bool swapRB, [MarshalAs(UnmanagedType.U1)] bool crop);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImages_12(IntPtr images_mat_nativeObj, double scalefactor, double size_width, double size_height, double mean_val0, double mean_val1, double mean_val2, double mean_val3, [MarshalAs(UnmanagedType.U1)] bool swapRB);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImages_13(IntPtr images_mat_nativeObj, double scalefactor, double size_width, double size_height, double mean_val0, double mean_val1, double mean_val2, double mean_val3);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImages_14(IntPtr images_mat_nativeObj, double scalefactor, double size_width, double size_height);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImages_15(IntPtr images_mat_nativeObj, double scalefactor);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_blobFromImages_16(IntPtr images_mat_nativeObj);

        // C++:  Mat cv::dnn::readTensorFromONNX(String path)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readTensorFromONNX_10(string path);

        // C++:  Mat cv::dnn::readTorchBlob(String filename, bool isBinary = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readTorchBlob_10(string filename, [MarshalAs(UnmanagedType.U1)] bool isBinary);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readTorchBlob_11(string filename);

        // C++:  Net cv::dnn::readNet(String framework, vector_uchar bufferModel, vector_uchar bufferConfig = std::vector<uchar>())
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNet_10(string framework, IntPtr bufferModel_mat_nativeObj, IntPtr bufferConfig_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNet_11(string framework, IntPtr bufferModel_mat_nativeObj);

        // C++:  Net cv::dnn::readNet(String model, String config = "", String framework = "")
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNet_12(string model, string config, string framework);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNet_13(string model, string config);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNet_14(string model);

        // C++:  Net cv::dnn::readNetFromCaffe(String prototxt, String caffeModel = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromCaffe_10(string prototxt, string caffeModel);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromCaffe_11(string prototxt);

        // C++:  Net cv::dnn::readNetFromCaffe(vector_uchar bufferProto, vector_uchar bufferModel = std::vector<uchar>())
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromCaffe_12(IntPtr bufferProto_mat_nativeObj, IntPtr bufferModel_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromCaffe_13(IntPtr bufferProto_mat_nativeObj);

        // C++:  Net cv::dnn::readNetFromDarknet(String cfgFile, String darknetModel = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromDarknet_10(string cfgFile, string darknetModel);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromDarknet_11(string cfgFile);

        // C++:  Net cv::dnn::readNetFromDarknet(vector_uchar bufferCfg, vector_uchar bufferModel = std::vector<uchar>())
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromDarknet_12(IntPtr bufferCfg_mat_nativeObj, IntPtr bufferModel_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromDarknet_13(IntPtr bufferCfg_mat_nativeObj);

        // C++:  Net cv::dnn::readNetFromModelOptimizer(String xml, String bin)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromModelOptimizer_10(string xml, string bin);

        // C++:  Net cv::dnn::readNetFromONNX(String onnxFile)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromONNX_10(string onnxFile);

        // C++:  Net cv::dnn::readNetFromTensorflow(String model, String config = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromTensorflow_10(string model, string config);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromTensorflow_11(string model);

        // C++:  Net cv::dnn::readNetFromTensorflow(vector_uchar bufferModel, vector_uchar bufferConfig = std::vector<uchar>())
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromTensorflow_12(IntPtr bufferModel_mat_nativeObj, IntPtr bufferConfig_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromTensorflow_13(IntPtr bufferModel_mat_nativeObj);

        // C++:  Net cv::dnn::readNetFromTorch(String model, bool isBinary = true, bool evaluate = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromTorch_10(string model, [MarshalAs(UnmanagedType.U1)] bool isBinary, [MarshalAs(UnmanagedType.U1)] bool evaluate);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromTorch_11(string model, [MarshalAs(UnmanagedType.U1)] bool isBinary);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_readNetFromTorch_12(string model);

        // C++:  String cv::dnn::getInferenceEngineVPUType()
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Dnn_getInferenceEngineVPUType_10();

        // C++:  void cv::dnn::NMSBoxes(vector_Rect bboxes, vector_float scores, float score_threshold, float nms_threshold, vector_int& indices, float eta = 1.f, int top_k = 0)
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_NMSBoxes_10(IntPtr bboxes_mat_nativeObj, IntPtr scores_mat_nativeObj, float score_threshold, float nms_threshold, IntPtr indices_mat_nativeObj, float eta, int top_k);
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_NMSBoxes_11(IntPtr bboxes_mat_nativeObj, IntPtr scores_mat_nativeObj, float score_threshold, float nms_threshold, IntPtr indices_mat_nativeObj, float eta);
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_NMSBoxes_12(IntPtr bboxes_mat_nativeObj, IntPtr scores_mat_nativeObj, float score_threshold, float nms_threshold, IntPtr indices_mat_nativeObj);

        // C++:  void cv::dnn::NMSBoxes(vector_Rect2d bboxes, vector_float scores, float score_threshold, float nms_threshold, vector_int& indices, float eta = 1.f, int top_k = 0)
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_NMSBoxes_13(IntPtr bboxes_mat_nativeObj, IntPtr scores_mat_nativeObj, float score_threshold, float nms_threshold, IntPtr indices_mat_nativeObj, float eta, int top_k);
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_NMSBoxes_14(IntPtr bboxes_mat_nativeObj, IntPtr scores_mat_nativeObj, float score_threshold, float nms_threshold, IntPtr indices_mat_nativeObj, float eta);
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_NMSBoxes_15(IntPtr bboxes_mat_nativeObj, IntPtr scores_mat_nativeObj, float score_threshold, float nms_threshold, IntPtr indices_mat_nativeObj);

        // C++:  void cv::dnn::NMSBoxes(vector_RotatedRect bboxes, vector_float scores, float score_threshold, float nms_threshold, vector_int& indices, float eta = 1.f, int top_k = 0)
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_NMSBoxesRotated_10(IntPtr bboxes_mat_nativeObj, IntPtr scores_mat_nativeObj, float score_threshold, float nms_threshold, IntPtr indices_mat_nativeObj, float eta, int top_k);
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_NMSBoxesRotated_11(IntPtr bboxes_mat_nativeObj, IntPtr scores_mat_nativeObj, float score_threshold, float nms_threshold, IntPtr indices_mat_nativeObj, float eta);
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_NMSBoxesRotated_12(IntPtr bboxes_mat_nativeObj, IntPtr scores_mat_nativeObj, float score_threshold, float nms_threshold, IntPtr indices_mat_nativeObj);

        // C++:  void cv::dnn::imagesFromBlob(Mat blob_, vector_Mat& images_)
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_imagesFromBlob_10(IntPtr blob__nativeObj, IntPtr images__mat_nativeObj);

        // C++:  void cv::dnn::resetMyriadDevice()
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_resetMyriadDevice_10();

        // C++:  void cv::dnn::shrinkCaffeModel(String src, String dst, vector_String layersTypes = std::vector<String>())
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_shrinkCaffeModel_10(string src, string dst, IntPtr layersTypes_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_shrinkCaffeModel_11(string src, string dst);

        // C++:  void cv::dnn::writeTextGraph(String model, String output)
        [DllImport(LIBNAME)]
        private static extern void dnn_Dnn_writeTextGraph_10(string model, string output);

    }
}
#endif