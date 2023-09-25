

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{
    // C++: class TrainData
    //javadoc: TrainData

    public class TrainData : DisposableOpenCVObject
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
                        ml_TrainData_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrainData(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static TrainData __fromPtr__(IntPtr addr) { return new TrainData(addr); }

        //
        // C++:  Mat cv::ml::TrainData::getCatMap()
        //

        //javadoc: TrainData::getCatMap()
        public Mat getCatMap()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getCatMap_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getCatOfs()
        //

        //javadoc: TrainData::getCatOfs()
        public Mat getCatOfs()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getCatOfs_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getClassLabels()
        //

        //javadoc: TrainData::getClassLabels()
        public Mat getClassLabels()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getClassLabels_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getDefaultSubstValues()
        //

        //javadoc: TrainData::getDefaultSubstValues()
        public Mat getDefaultSubstValues()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getDefaultSubstValues_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getMissing()
        //

        //javadoc: TrainData::getMissing()
        public Mat getMissing()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getMissing_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getNormCatResponses()
        //

        //javadoc: TrainData::getNormCatResponses()
        public Mat getNormCatResponses()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getNormCatResponses_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getResponses()
        //

        //javadoc: TrainData::getResponses()
        public Mat getResponses()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getResponses_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getSampleWeights()
        //

        //javadoc: TrainData::getSampleWeights()
        public Mat getSampleWeights()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getSampleWeights_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getSamples()
        //

        //javadoc: TrainData::getSamples()
        public Mat getSamples()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getSamples_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Mat cv::ml::TrainData::getSubMatrix(Mat matrix, Mat idx, int layout)
        //

        //javadoc: TrainData::getSubMatrix(matrix, idx, layout)
        public static Mat getSubMatrix(Mat matrix, Mat idx, int layout)
        {
            if (matrix != null) matrix.ThrowIfDisposed();
            if (idx != null) idx.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getSubMatrix_10(matrix.nativeObj, idx.nativeObj, layout));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Mat cv::ml::TrainData::getSubVector(Mat vec, Mat idx)
        //

        //javadoc: TrainData::getSubVector(vec, idx)
        public static Mat getSubVector(Mat vec, Mat idx)
        {
            if (vec != null) vec.ThrowIfDisposed();
            if (idx != null) idx.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getSubVector_10(vec.nativeObj, idx.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getTestNormCatResponses()
        //

        //javadoc: TrainData::getTestNormCatResponses()
        public Mat getTestNormCatResponses()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getTestNormCatResponses_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getTestResponses()
        //

        //javadoc: TrainData::getTestResponses()
        public Mat getTestResponses()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getTestResponses_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getTestSampleIdx()
        //

        //javadoc: TrainData::getTestSampleIdx()
        public Mat getTestSampleIdx()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getTestSampleIdx_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getTestSampleWeights()
        //

        //javadoc: TrainData::getTestSampleWeights()
        public Mat getTestSampleWeights()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getTestSampleWeights_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getTestSamples()
        //

        //javadoc: TrainData::getTestSamples()
        public Mat getTestSamples()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getTestSamples_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getTrainNormCatResponses()
        //

        //javadoc: TrainData::getTrainNormCatResponses()
        public Mat getTrainNormCatResponses()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getTrainNormCatResponses_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getTrainResponses()
        //

        //javadoc: TrainData::getTrainResponses()
        public Mat getTrainResponses()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getTrainResponses_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getTrainSampleIdx()
        //

        //javadoc: TrainData::getTrainSampleIdx()
        public Mat getTrainSampleIdx()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getTrainSampleIdx_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getTrainSampleWeights()
        //

        //javadoc: TrainData::getTrainSampleWeights()
        public Mat getTrainSampleWeights()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getTrainSampleWeights_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getTrainSamples(int layout = ROW_SAMPLE, bool compressSamples = true, bool compressVars = true)
        //

        //javadoc: TrainData::getTrainSamples(layout, compressSamples, compressVars)
        public Mat getTrainSamples(int layout, bool compressSamples, bool compressVars)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getTrainSamples_10(nativeObj, layout, compressSamples, compressVars));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: TrainData::getTrainSamples(layout, compressSamples)
        public Mat getTrainSamples(int layout, bool compressSamples)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getTrainSamples_11(nativeObj, layout, compressSamples));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: TrainData::getTrainSamples(layout)
        public Mat getTrainSamples(int layout)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getTrainSamples_12(nativeObj, layout));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: TrainData::getTrainSamples()
        public Mat getTrainSamples()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getTrainSamples_13(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getVarIdx()
        //

        //javadoc: TrainData::getVarIdx()
        public Mat getVarIdx()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getVarIdx_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getVarSymbolFlags()
        //

        //javadoc: TrainData::getVarSymbolFlags()
        public Mat getVarSymbolFlags()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getVarSymbolFlags_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::TrainData::getVarType()
        //

        //javadoc: TrainData::getVarType()
        public Mat getVarType()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_TrainData_getVarType_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_TrainData cv::ml::TrainData::create(Mat samples, int layout, Mat responses, Mat varIdx = Mat(), Mat sampleIdx = Mat(), Mat sampleWeights = Mat(), Mat varType = Mat())
        //

        //javadoc: TrainData::create(samples, layout, responses, varIdx, sampleIdx, sampleWeights, varType)
        public static TrainData create(Mat samples, int layout, Mat responses, Mat varIdx, Mat sampleIdx, Mat sampleWeights, Mat varType)
        {
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();
            if (varIdx != null) varIdx.ThrowIfDisposed();
            if (sampleIdx != null) sampleIdx.ThrowIfDisposed();
            if (sampleWeights != null) sampleWeights.ThrowIfDisposed();
            if (varType != null) varType.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        TrainData retVal = TrainData.__fromPtr__(ml_TrainData_create_10(samples.nativeObj, layout, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, sampleWeights.nativeObj, varType.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: TrainData::create(samples, layout, responses, varIdx, sampleIdx, sampleWeights)
        public static TrainData create(Mat samples, int layout, Mat responses, Mat varIdx, Mat sampleIdx, Mat sampleWeights)
        {
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();
            if (varIdx != null) varIdx.ThrowIfDisposed();
            if (sampleIdx != null) sampleIdx.ThrowIfDisposed();
            if (sampleWeights != null) sampleWeights.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        TrainData retVal = TrainData.__fromPtr__(ml_TrainData_create_11(samples.nativeObj, layout, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, sampleWeights.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: TrainData::create(samples, layout, responses, varIdx, sampleIdx)
        public static TrainData create(Mat samples, int layout, Mat responses, Mat varIdx, Mat sampleIdx)
        {
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();
            if (varIdx != null) varIdx.ThrowIfDisposed();
            if (sampleIdx != null) sampleIdx.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        TrainData retVal = TrainData.__fromPtr__(ml_TrainData_create_12(samples.nativeObj, layout, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: TrainData::create(samples, layout, responses, varIdx)
        public static TrainData create(Mat samples, int layout, Mat responses, Mat varIdx)
        {
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();
            if (varIdx != null) varIdx.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        TrainData retVal = TrainData.__fromPtr__(ml_TrainData_create_13(samples.nativeObj, layout, responses.nativeObj, varIdx.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: TrainData::create(samples, layout, responses)
        public static TrainData create(Mat samples, int layout, Mat responses)
        {
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        TrainData retVal = TrainData.__fromPtr__(ml_TrainData_create_14(samples.nativeObj, layout, responses.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  int cv::ml::TrainData::getCatCount(int vi)
        //

        //javadoc: TrainData::getCatCount(vi)
        public int getCatCount(int vi)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_TrainData_getCatCount_10(nativeObj, vi);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::TrainData::getLayout()
        //

        //javadoc: TrainData::getLayout()
        public int getLayout()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_TrainData_getLayout_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::TrainData::getNAllVars()
        //

        //javadoc: TrainData::getNAllVars()
        public int getNAllVars()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_TrainData_getNAllVars_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::TrainData::getNSamples()
        //

        //javadoc: TrainData::getNSamples()
        public int getNSamples()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_TrainData_getNSamples_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::TrainData::getNTestSamples()
        //

        //javadoc: TrainData::getNTestSamples()
        public int getNTestSamples()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_TrainData_getNTestSamples_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::TrainData::getNTrainSamples()
        //

        //javadoc: TrainData::getNTrainSamples()
        public int getNTrainSamples()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_TrainData_getNTrainSamples_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::TrainData::getNVars()
        //

        //javadoc: TrainData::getNVars()
        public int getNVars()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_TrainData_getNVars_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::TrainData::getResponseType()
        //

        //javadoc: TrainData::getResponseType()
        public int getResponseType()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_TrainData_getResponseType_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ml::TrainData::getNames(vector_String names)
        //

        //javadoc: TrainData::getNames(names)
        public void getNames(List<string> names)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat names_mat = Converters.vector_String_to_Mat(names);
        ml_TrainData_getNames_10(nativeObj, names_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::TrainData::getSample(Mat varIdx, int sidx, float* buf)
        //

        //javadoc: TrainData::getSample(varIdx, sidx, buf)
        public void getSample(Mat varIdx, int sidx, float buf)
        {
            ThrowIfDisposed();
            if (varIdx != null) varIdx.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_TrainData_getSample_10(nativeObj, varIdx.nativeObj, sidx, buf);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::TrainData::getValues(int vi, Mat sidx, float* values)
        //

        //javadoc: TrainData::getValues(vi, sidx, values)
        public void getValues(int vi, Mat sidx, float values)
        {
            ThrowIfDisposed();
            if (sidx != null) sidx.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_TrainData_getValues_10(nativeObj, vi, sidx.nativeObj, values);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::TrainData::setTrainTestSplit(int count, bool shuffle = true)
        //

        //javadoc: TrainData::setTrainTestSplit(count, shuffle)
        public void setTrainTestSplit(int count, bool shuffle)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_TrainData_setTrainTestSplit_10(nativeObj, count, shuffle);
        
        return;
#else
            return;
#endif
        }

        //javadoc: TrainData::setTrainTestSplit(count)
        public void setTrainTestSplit(int count)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_TrainData_setTrainTestSplit_11(nativeObj, count);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::TrainData::setTrainTestSplitRatio(double ratio, bool shuffle = true)
        //

        //javadoc: TrainData::setTrainTestSplitRatio(ratio, shuffle)
        public void setTrainTestSplitRatio(double ratio, bool shuffle)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_TrainData_setTrainTestSplitRatio_10(nativeObj, ratio, shuffle);
        
        return;
#else
            return;
#endif
        }

        //javadoc: TrainData::setTrainTestSplitRatio(ratio)
        public void setTrainTestSplitRatio(double ratio)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_TrainData_setTrainTestSplitRatio_11(nativeObj, ratio);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::TrainData::shuffleTrainTest()
        //

        //javadoc: TrainData::shuffleTrainTest()
        public void shuffleTrainTest()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_TrainData_shuffleTrainTest_10(nativeObj);
        
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



        // C++:  Mat cv::ml::TrainData::getCatMap()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getCatMap_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getCatOfs()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getCatOfs_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getClassLabels()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getClassLabels_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getDefaultSubstValues()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getDefaultSubstValues_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getMissing()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getMissing_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getNormCatResponses()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getNormCatResponses_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getResponses()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getResponses_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getSampleWeights()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getSampleWeights_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getSamples()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getSamples_10(IntPtr nativeObj);

        // C++: static Mat cv::ml::TrainData::getSubMatrix(Mat matrix, Mat idx, int layout)
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getSubMatrix_10(IntPtr matrix_nativeObj, IntPtr idx_nativeObj, int layout);

        // C++: static Mat cv::ml::TrainData::getSubVector(Mat vec, Mat idx)
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getSubVector_10(IntPtr vec_nativeObj, IntPtr idx_nativeObj);

        // C++:  Mat cv::ml::TrainData::getTestNormCatResponses()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getTestNormCatResponses_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getTestResponses()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getTestResponses_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getTestSampleIdx()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getTestSampleIdx_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getTestSampleWeights()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getTestSampleWeights_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getTestSamples()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getTestSamples_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getTrainNormCatResponses()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getTrainNormCatResponses_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getTrainResponses()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getTrainResponses_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getTrainSampleIdx()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getTrainSampleIdx_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getTrainSampleWeights()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getTrainSampleWeights_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getTrainSamples(int layout = ROW_SAMPLE, bool compressSamples = true, bool compressVars = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getTrainSamples_10(IntPtr nativeObj, int layout, [MarshalAs(UnmanagedType.U1)] bool compressSamples, [MarshalAs(UnmanagedType.U1)] bool compressVars);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getTrainSamples_11(IntPtr nativeObj, int layout, [MarshalAs(UnmanagedType.U1)] bool compressSamples);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getTrainSamples_12(IntPtr nativeObj, int layout);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getTrainSamples_13(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getVarIdx()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getVarIdx_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getVarSymbolFlags()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getVarSymbolFlags_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::TrainData::getVarType()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_getVarType_10(IntPtr nativeObj);

        // C++: static Ptr_TrainData cv::ml::TrainData::create(Mat samples, int layout, Mat responses, Mat varIdx = Mat(), Mat sampleIdx = Mat(), Mat sampleWeights = Mat(), Mat varType = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_create_10(IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr sampleWeights_nativeObj, IntPtr varType_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_create_11(IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr sampleWeights_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_create_12(IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_create_13(IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_TrainData_create_14(IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj);

        // C++:  int cv::ml::TrainData::getCatCount(int vi)
        [DllImport(LIBNAME)]
        private static extern int ml_TrainData_getCatCount_10(IntPtr nativeObj, int vi);

        // C++:  int cv::ml::TrainData::getLayout()
        [DllImport(LIBNAME)]
        private static extern int ml_TrainData_getLayout_10(IntPtr nativeObj);

        // C++:  int cv::ml::TrainData::getNAllVars()
        [DllImport(LIBNAME)]
        private static extern int ml_TrainData_getNAllVars_10(IntPtr nativeObj);

        // C++:  int cv::ml::TrainData::getNSamples()
        [DllImport(LIBNAME)]
        private static extern int ml_TrainData_getNSamples_10(IntPtr nativeObj);

        // C++:  int cv::ml::TrainData::getNTestSamples()
        [DllImport(LIBNAME)]
        private static extern int ml_TrainData_getNTestSamples_10(IntPtr nativeObj);

        // C++:  int cv::ml::TrainData::getNTrainSamples()
        [DllImport(LIBNAME)]
        private static extern int ml_TrainData_getNTrainSamples_10(IntPtr nativeObj);

        // C++:  int cv::ml::TrainData::getNVars()
        [DllImport(LIBNAME)]
        private static extern int ml_TrainData_getNVars_10(IntPtr nativeObj);

        // C++:  int cv::ml::TrainData::getResponseType()
        [DllImport(LIBNAME)]
        private static extern int ml_TrainData_getResponseType_10(IntPtr nativeObj);

        // C++:  void cv::ml::TrainData::getNames(vector_String names)
        [DllImport(LIBNAME)]
        private static extern void ml_TrainData_getNames_10(IntPtr nativeObj, IntPtr names_mat_nativeObj);

        // C++:  void cv::ml::TrainData::getSample(Mat varIdx, int sidx, float* buf)
        [DllImport(LIBNAME)]
        private static extern void ml_TrainData_getSample_10(IntPtr nativeObj, IntPtr varIdx_nativeObj, int sidx, float buf);

        // C++:  void cv::ml::TrainData::getValues(int vi, Mat sidx, float* values)
        [DllImport(LIBNAME)]
        private static extern void ml_TrainData_getValues_10(IntPtr nativeObj, int vi, IntPtr sidx_nativeObj, float values);

        // C++:  void cv::ml::TrainData::setTrainTestSplit(int count, bool shuffle = true)
        [DllImport(LIBNAME)]
        private static extern void ml_TrainData_setTrainTestSplit_10(IntPtr nativeObj, int count, [MarshalAs(UnmanagedType.U1)] bool shuffle);
        [DllImport(LIBNAME)]
        private static extern void ml_TrainData_setTrainTestSplit_11(IntPtr nativeObj, int count);

        // C++:  void cv::ml::TrainData::setTrainTestSplitRatio(double ratio, bool shuffle = true)
        [DllImport(LIBNAME)]
        private static extern void ml_TrainData_setTrainTestSplitRatio_10(IntPtr nativeObj, double ratio, [MarshalAs(UnmanagedType.U1)] bool shuffle);
        [DllImport(LIBNAME)]
        private static extern void ml_TrainData_setTrainTestSplitRatio_11(IntPtr nativeObj, double ratio);

        // C++:  void cv::ml::TrainData::shuffleTrainTest()
        [DllImport(LIBNAME)]
        private static extern void ml_TrainData_shuffleTrainTest_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_TrainData_delete(IntPtr nativeObj);

    }
}
