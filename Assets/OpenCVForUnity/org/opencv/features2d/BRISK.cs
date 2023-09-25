
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class BRISK
    //javadoc: BRISK

    public class BRISK : Feature2D
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
                        features2d_BRISK_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BRISK(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BRISK __fromPtr__(IntPtr addr) { return new BRISK(addr); }

        //
        // C++: static Ptr_BRISK cv::BRISK::create(int thresh, int octaves, vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        //

        //javadoc: BRISK::create(thresh, octaves, radiusList, numberList, dMax, dMin, indexChange)
        public static BRISK create(int thresh, int octaves, MatOfFloat radiusList, MatOfInt numberList, float dMax, float dMin, MatOfInt indexChange)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
            if (indexChange != null) indexChange.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat radiusList_mat = radiusList;
        Mat numberList_mat = numberList;
        Mat indexChange_mat = indexChange;
        BRISK retVal = BRISK.__fromPtr__(features2d_BRISK_create_10(thresh, octaves, radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax, dMin, indexChange_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BRISK::create(thresh, octaves, radiusList, numberList, dMax, dMin)
        public static BRISK create(int thresh, int octaves, MatOfFloat radiusList, MatOfInt numberList, float dMax, float dMin)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat radiusList_mat = radiusList;
        Mat numberList_mat = numberList;
        BRISK retVal = BRISK.__fromPtr__(features2d_BRISK_create_11(thresh, octaves, radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax, dMin));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BRISK::create(thresh, octaves, radiusList, numberList, dMax)
        public static BRISK create(int thresh, int octaves, MatOfFloat radiusList, MatOfInt numberList, float dMax)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat radiusList_mat = radiusList;
        Mat numberList_mat = numberList;
        BRISK retVal = BRISK.__fromPtr__(features2d_BRISK_create_12(thresh, octaves, radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BRISK::create(thresh, octaves, radiusList, numberList)
        public static BRISK create(int thresh, int octaves, MatOfFloat radiusList, MatOfInt numberList)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat radiusList_mat = radiusList;
        Mat numberList_mat = numberList;
        BRISK retVal = BRISK.__fromPtr__(features2d_BRISK_create_13(thresh, octaves, radiusList_mat.nativeObj, numberList_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_BRISK cv::BRISK::create(int thresh = 30, int octaves = 3, float patternScale = 1.0f)
        //

        //javadoc: BRISK::create(thresh, octaves, patternScale)
        public static BRISK create(int thresh, int octaves, float patternScale)
        {
#if UNITY_5_3_OR_NEWER
        
        BRISK retVal = BRISK.__fromPtr__(features2d_BRISK_create_14(thresh, octaves, patternScale));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BRISK::create(thresh, octaves)
        public static BRISK create(int thresh, int octaves)
        {
#if UNITY_5_3_OR_NEWER
        
        BRISK retVal = BRISK.__fromPtr__(features2d_BRISK_create_15(thresh, octaves));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BRISK::create(thresh)
        public static BRISK create(int thresh)
        {
#if UNITY_5_3_OR_NEWER
        
        BRISK retVal = BRISK.__fromPtr__(features2d_BRISK_create_16(thresh));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BRISK::create()
        public static BRISK create()
        {
#if UNITY_5_3_OR_NEWER
        
        BRISK retVal = BRISK.__fromPtr__(features2d_BRISK_create_17());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_BRISK cv::BRISK::create(vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        //

        //javadoc: BRISK::create(radiusList, numberList, dMax, dMin, indexChange)
        public static BRISK create(MatOfFloat radiusList, MatOfInt numberList, float dMax, float dMin, MatOfInt indexChange)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
            if (indexChange != null) indexChange.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat radiusList_mat = radiusList;
        Mat numberList_mat = numberList;
        Mat indexChange_mat = indexChange;
        BRISK retVal = BRISK.__fromPtr__(features2d_BRISK_create_18(radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax, dMin, indexChange_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BRISK::create(radiusList, numberList, dMax, dMin)
        public static BRISK create(MatOfFloat radiusList, MatOfInt numberList, float dMax, float dMin)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat radiusList_mat = radiusList;
        Mat numberList_mat = numberList;
        BRISK retVal = BRISK.__fromPtr__(features2d_BRISK_create_19(radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax, dMin));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BRISK::create(radiusList, numberList, dMax)
        public static BRISK create(MatOfFloat radiusList, MatOfInt numberList, float dMax)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat radiusList_mat = radiusList;
        Mat numberList_mat = numberList;
        BRISK retVal = BRISK.__fromPtr__(features2d_BRISK_create_110(radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BRISK::create(radiusList, numberList)
        public static BRISK create(MatOfFloat radiusList, MatOfInt numberList)
        {
            if (radiusList != null) radiusList.ThrowIfDisposed();
            if (numberList != null) numberList.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat radiusList_mat = radiusList;
        Mat numberList_mat = numberList;
        BRISK retVal = BRISK.__fromPtr__(features2d_BRISK_create_111(radiusList_mat.nativeObj, numberList_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::BRISK::getDefaultName()
        //

        //javadoc: BRISK::getDefaultName()
        public override string getDefaultName()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (features2d_BRISK_getDefaultName_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  int cv::BRISK::getOctaves()
        //

        //javadoc: BRISK::getOctaves()
        public int getOctaves()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_BRISK_getOctaves_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::BRISK::getThreshold()
        //

        //javadoc: BRISK::getThreshold()
        public int getThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = features2d_BRISK_getThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::BRISK::setOctaves(int octaves)
        //

        //javadoc: BRISK::setOctaves(octaves)
        public void setOctaves(int octaves)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_BRISK_setOctaves_10(nativeObj, octaves);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::BRISK::setThreshold(int threshold)
        //

        //javadoc: BRISK::setThreshold(threshold)
        public void setThreshold(int threshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_BRISK_setThreshold_10(nativeObj, threshold);
        
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



        // C++: static Ptr_BRISK cv::BRISK::create(int thresh, int octaves, vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_10(int thresh, int octaves, IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax, float dMin, IntPtr indexChange_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_11(int thresh, int octaves, IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax, float dMin);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_12(int thresh, int octaves, IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_13(int thresh, int octaves, IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj);

        // C++: static Ptr_BRISK cv::BRISK::create(int thresh = 30, int octaves = 3, float patternScale = 1.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_14(int thresh, int octaves, float patternScale);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_15(int thresh, int octaves);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_16(int thresh);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_17();

        // C++: static Ptr_BRISK cv::BRISK::create(vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_18(IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax, float dMin, IntPtr indexChange_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_19(IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax, float dMin);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_110(IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_111(IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj);

        // C++:  String cv::BRISK::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_getDefaultName_10(IntPtr nativeObj);

        // C++:  int cv::BRISK::getOctaves()
        [DllImport(LIBNAME)]
        private static extern int features2d_BRISK_getOctaves_10(IntPtr nativeObj);

        // C++:  int cv::BRISK::getThreshold()
        [DllImport(LIBNAME)]
        private static extern int features2d_BRISK_getThreshold_10(IntPtr nativeObj);

        // C++:  void cv::BRISK::setOctaves(int octaves)
        [DllImport(LIBNAME)]
        private static extern void features2d_BRISK_setOctaves_10(IntPtr nativeObj, int octaves);

        // C++:  void cv::BRISK::setThreshold(int threshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_BRISK_setThreshold_10(IntPtr nativeObj, int threshold);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_BRISK_delete(IntPtr nativeObj);

    }
}
