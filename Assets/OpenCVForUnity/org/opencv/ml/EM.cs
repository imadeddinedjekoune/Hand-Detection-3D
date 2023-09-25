
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class EM
    //javadoc: EM

    public class EM : StatModel
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
                        ml_EM_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal EM(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new EM __fromPtr__(IntPtr addr) { return new EM(addr); }

        // C++: enum Types
        public const int COV_MAT_SPHERICAL = 0;
        public const int COV_MAT_DIAGONAL = 1;
        public const int COV_MAT_GENERIC = 2;
        public const int COV_MAT_DEFAULT = COV_MAT_DIAGONAL;
        // C++: enum <unnamed>
        public const int DEFAULT_NCLUSTERS = 5;
        public const int DEFAULT_MAX_ITERS = 100;
        public const int START_E_STEP = 1;
        public const int START_M_STEP = 2;
        public const int START_AUTO_STEP = 0;
        //
        // C++:  Mat cv::ml::EM::getMeans()
        //

        //javadoc: EM::getMeans()
        public Mat getMeans()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_EM_getMeans_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::ml::EM::getWeights()
        //

        //javadoc: EM::getWeights()
        public Mat getWeights()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_EM_getWeights_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_EM cv::ml::EM::create()
        //

        //javadoc: EM::create()
        public static EM create()
        {
#if UNITY_5_3_OR_NEWER
        
        EM retVal = EM.__fromPtr__(ml_EM_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_EM cv::ml::EM::load(String filepath, String nodeName = String())
        //

        //javadoc: EM::load(filepath, nodeName)
        public static EM load(string filepath, string nodeName)
        {
#if UNITY_5_3_OR_NEWER
        
        EM retVal = EM.__fromPtr__(ml_EM_load_10(filepath, nodeName));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: EM::load(filepath)
        public static EM load(string filepath)
        {
#if UNITY_5_3_OR_NEWER
        
        EM retVal = EM.__fromPtr__(ml_EM_load_11(filepath));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  TermCriteria cv::ml::EM::getTermCriteria()
        //

        //javadoc: EM::getTermCriteria()
        public TermCriteria getTermCriteria()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[3];
ml_EM_getTermCriteria_10(nativeObj, tmpArray);
TermCriteria retVal = new TermCriteria (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Vec2d cv::ml::EM::predict2(Mat sample, Mat& probs)
        //

        //javadoc: EM::predict2(sample, probs)
        public double[] predict2(Mat sample, Mat probs)
        {
            ThrowIfDisposed();
            if (sample != null) sample.ThrowIfDisposed();
            if (probs != null) probs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] retVal = new double[2];
ml_EM_predict2_10(nativeObj, sample.nativeObj, probs.nativeObj, retVal);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::ml::EM::trainE(Mat samples, Mat means0, Mat covs0 = Mat(), Mat weights0 = Mat(), Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        //

        //javadoc: EM::trainE(samples, means0, covs0, weights0, logLikelihoods, labels, probs)
        public bool trainE(Mat samples, Mat means0, Mat covs0, Mat weights0, Mat logLikelihoods, Mat labels, Mat probs)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (means0 != null) means0.ThrowIfDisposed();
            if (covs0 != null) covs0.ThrowIfDisposed();
            if (weights0 != null) weights0.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();
            if (probs != null) probs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainE_10(nativeObj, samples.nativeObj, means0.nativeObj, covs0.nativeObj, weights0.nativeObj, logLikelihoods.nativeObj, labels.nativeObj, probs.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: EM::trainE(samples, means0, covs0, weights0, logLikelihoods, labels)
        public bool trainE(Mat samples, Mat means0, Mat covs0, Mat weights0, Mat logLikelihoods, Mat labels)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (means0 != null) means0.ThrowIfDisposed();
            if (covs0 != null) covs0.ThrowIfDisposed();
            if (weights0 != null) weights0.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainE_11(nativeObj, samples.nativeObj, means0.nativeObj, covs0.nativeObj, weights0.nativeObj, logLikelihoods.nativeObj, labels.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: EM::trainE(samples, means0, covs0, weights0, logLikelihoods)
        public bool trainE(Mat samples, Mat means0, Mat covs0, Mat weights0, Mat logLikelihoods)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (means0 != null) means0.ThrowIfDisposed();
            if (covs0 != null) covs0.ThrowIfDisposed();
            if (weights0 != null) weights0.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainE_12(nativeObj, samples.nativeObj, means0.nativeObj, covs0.nativeObj, weights0.nativeObj, logLikelihoods.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: EM::trainE(samples, means0, covs0, weights0)
        public bool trainE(Mat samples, Mat means0, Mat covs0, Mat weights0)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (means0 != null) means0.ThrowIfDisposed();
            if (covs0 != null) covs0.ThrowIfDisposed();
            if (weights0 != null) weights0.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainE_13(nativeObj, samples.nativeObj, means0.nativeObj, covs0.nativeObj, weights0.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: EM::trainE(samples, means0, covs0)
        public bool trainE(Mat samples, Mat means0, Mat covs0)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (means0 != null) means0.ThrowIfDisposed();
            if (covs0 != null) covs0.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainE_14(nativeObj, samples.nativeObj, means0.nativeObj, covs0.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: EM::trainE(samples, means0)
        public bool trainE(Mat samples, Mat means0)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (means0 != null) means0.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainE_15(nativeObj, samples.nativeObj, means0.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::ml::EM::trainEM(Mat samples, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        //

        //javadoc: EM::trainEM(samples, logLikelihoods, labels, probs)
        public bool trainEM(Mat samples, Mat logLikelihoods, Mat labels, Mat probs)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();
            if (probs != null) probs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainEM_10(nativeObj, samples.nativeObj, logLikelihoods.nativeObj, labels.nativeObj, probs.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: EM::trainEM(samples, logLikelihoods, labels)
        public bool trainEM(Mat samples, Mat logLikelihoods, Mat labels)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainEM_11(nativeObj, samples.nativeObj, logLikelihoods.nativeObj, labels.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: EM::trainEM(samples, logLikelihoods)
        public bool trainEM(Mat samples, Mat logLikelihoods)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainEM_12(nativeObj, samples.nativeObj, logLikelihoods.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: EM::trainEM(samples)
        public bool trainEM(Mat samples)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainEM_13(nativeObj, samples.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::ml::EM::trainM(Mat samples, Mat probs0, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        //

        //javadoc: EM::trainM(samples, probs0, logLikelihoods, labels, probs)
        public bool trainM(Mat samples, Mat probs0, Mat logLikelihoods, Mat labels, Mat probs)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (probs0 != null) probs0.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();
            if (probs != null) probs.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainM_10(nativeObj, samples.nativeObj, probs0.nativeObj, logLikelihoods.nativeObj, labels.nativeObj, probs.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: EM::trainM(samples, probs0, logLikelihoods, labels)
        public bool trainM(Mat samples, Mat probs0, Mat logLikelihoods, Mat labels)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (probs0 != null) probs0.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
            if (labels != null) labels.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainM_11(nativeObj, samples.nativeObj, probs0.nativeObj, logLikelihoods.nativeObj, labels.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: EM::trainM(samples, probs0, logLikelihoods)
        public bool trainM(Mat samples, Mat probs0, Mat logLikelihoods)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (probs0 != null) probs0.ThrowIfDisposed();
            if (logLikelihoods != null) logLikelihoods.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainM_12(nativeObj, samples.nativeObj, probs0.nativeObj, logLikelihoods.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: EM::trainM(samples, probs0)
        public bool trainM(Mat samples, Mat probs0)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (probs0 != null) probs0.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = ml_EM_trainM_13(nativeObj, samples.nativeObj, probs0.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  float cv::ml::EM::predict(Mat samples, Mat& results = Mat(), int flags = 0)
        //

        //javadoc: EM::predict(samples, results, flags)
        public override float predict(Mat samples, Mat results, int flags)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (results != null) results.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ml_EM_predict_10(nativeObj, samples.nativeObj, results.nativeObj, flags);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: EM::predict(samples, results)
        public override float predict(Mat samples, Mat results)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (results != null) results.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ml_EM_predict_11(nativeObj, samples.nativeObj, results.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: EM::predict(samples)
        public override float predict(Mat samples)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ml_EM_predict_12(nativeObj, samples.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::EM::getClustersNumber()
        //

        //javadoc: EM::getClustersNumber()
        public int getClustersNumber()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_EM_getClustersNumber_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::EM::getCovarianceMatrixType()
        //

        //javadoc: EM::getCovarianceMatrixType()
        public int getCovarianceMatrixType()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_EM_getCovarianceMatrixType_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ml::EM::getCovs(vector_Mat& covs)
        //

        //javadoc: EM::getCovs(covs)
        public void getCovs(List<Mat> covs)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat covs_mat = new Mat();
        ml_EM_getCovs_10(nativeObj, covs_mat.nativeObj);
        Converters.Mat_to_vector_Mat(covs_mat, covs);
        covs_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::EM::setClustersNumber(int val)
        //

        //javadoc: EM::setClustersNumber(val)
        public void setClustersNumber(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_EM_setClustersNumber_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::EM::setCovarianceMatrixType(int val)
        //

        //javadoc: EM::setCovarianceMatrixType(val)
        public void setCovarianceMatrixType(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_EM_setCovarianceMatrixType_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::EM::setTermCriteria(TermCriteria val)
        //

        //javadoc: EM::setTermCriteria(val)
        public void setTermCriteria(TermCriteria val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_EM_setTermCriteria_10(nativeObj, val.type, val.maxCount, val.epsilon);
        
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



        // C++:  Mat cv::ml::EM::getMeans()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_EM_getMeans_10(IntPtr nativeObj);

        // C++:  Mat cv::ml::EM::getWeights()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_EM_getWeights_10(IntPtr nativeObj);

        // C++: static Ptr_EM cv::ml::EM::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_EM_create_10();

        // C++: static Ptr_EM cv::ml::EM::load(String filepath, String nodeName = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_EM_load_10(string filepath, string nodeName);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_EM_load_11(string filepath);

        // C++:  TermCriteria cv::ml::EM::getTermCriteria()
        [DllImport(LIBNAME)]
        private static extern void ml_EM_getTermCriteria_10(IntPtr nativeObj, double[] retVal);

        // C++:  Vec2d cv::ml::EM::predict2(Mat sample, Mat& probs)
        [DllImport(LIBNAME)]
        private static extern void ml_EM_predict2_10(IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr probs_nativeObj, double[] retVal);

        // C++:  bool cv::ml::EM::trainE(Mat samples, Mat means0, Mat covs0 = Mat(), Mat weights0 = Mat(), Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainE_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj, IntPtr covs0_nativeObj, IntPtr weights0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainE_11(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj, IntPtr covs0_nativeObj, IntPtr weights0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainE_12(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj, IntPtr covs0_nativeObj, IntPtr weights0_nativeObj, IntPtr logLikelihoods_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainE_13(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj, IntPtr covs0_nativeObj, IntPtr weights0_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainE_14(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj, IntPtr covs0_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainE_15(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj);

        // C++:  bool cv::ml::EM::trainEM(Mat samples, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainEM_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainEM_11(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainEM_12(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr logLikelihoods_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainEM_13(IntPtr nativeObj, IntPtr samples_nativeObj);

        // C++:  bool cv::ml::EM::trainM(Mat samples, Mat probs0, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainM_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainM_11(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainM_12(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj, IntPtr logLikelihoods_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_EM_trainM_13(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj);

        // C++:  float cv::ml::EM::predict(Mat samples, Mat& results = Mat(), int flags = 0)
        [DllImport(LIBNAME)]
        private static extern float ml_EM_predict_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern float ml_EM_predict_11(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj);
        [DllImport(LIBNAME)]
        private static extern float ml_EM_predict_12(IntPtr nativeObj, IntPtr samples_nativeObj);

        // C++:  int cv::ml::EM::getClustersNumber()
        [DllImport(LIBNAME)]
        private static extern int ml_EM_getClustersNumber_10(IntPtr nativeObj);

        // C++:  int cv::ml::EM::getCovarianceMatrixType()
        [DllImport(LIBNAME)]
        private static extern int ml_EM_getCovarianceMatrixType_10(IntPtr nativeObj);

        // C++:  void cv::ml::EM::getCovs(vector_Mat& covs)
        [DllImport(LIBNAME)]
        private static extern void ml_EM_getCovs_10(IntPtr nativeObj, IntPtr covs_mat_nativeObj);

        // C++:  void cv::ml::EM::setClustersNumber(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_EM_setClustersNumber_10(IntPtr nativeObj, int val);

        // C++:  void cv::ml::EM::setCovarianceMatrixType(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_EM_setCovarianceMatrixType_10(IntPtr nativeObj, int val);

        // C++:  void cv::ml::EM::setTermCriteria(TermCriteria val)
        [DllImport(LIBNAME)]
        private static extern void ml_EM_setTermCriteria_10(IntPtr nativeObj, int val_type, int val_maxCount, double val_epsilon);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_EM_delete(IntPtr nativeObj);

    }
}
