

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ArucoModule
{
    // C++: class Dictionary
    //javadoc: Dictionary

    public class Dictionary : DisposableOpenCVObject
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
                        aruco_Dictionary_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Dictionary(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static Dictionary __fromPtr__(IntPtr addr) { return new Dictionary(addr); }

        //
        // C++: static Mat cv::aruco::Dictionary::getBitsFromByteList(Mat byteList, int markerSize)
        //

        //javadoc: Dictionary::getBitsFromByteList(byteList, markerSize)
        public static Mat getBitsFromByteList(Mat byteList, int markerSize)
        {
            if (byteList != null) byteList.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(aruco_Dictionary_getBitsFromByteList_10(byteList.nativeObj, markerSize));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Mat cv::aruco::Dictionary::getByteListFromBits(Mat bits)
        //

        //javadoc: Dictionary::getByteListFromBits(bits)
        public static Mat getByteListFromBits(Mat bits)
        {
            if (bits != null) bits.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(aruco_Dictionary_getByteListFromBits_10(bits.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_Dictionary cv::aruco::Dictionary::create(int nMarkers, int markerSize, Ptr_Dictionary baseDictionary, int randomSeed = 0)
        //

        //javadoc: Dictionary::create_from(nMarkers, markerSize, baseDictionary, randomSeed)
        public static Dictionary create_from(int nMarkers, int markerSize, Dictionary baseDictionary, int randomSeed)
        {
            if (baseDictionary != null) baseDictionary.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Dictionary retVal = Dictionary.__fromPtr__(aruco_Dictionary_create_1from_10(nMarkers, markerSize, baseDictionary.getNativeObjAddr(), randomSeed));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: Dictionary::create_from(nMarkers, markerSize, baseDictionary)
        public static Dictionary create_from(int nMarkers, int markerSize, Dictionary baseDictionary)
        {
            if (baseDictionary != null) baseDictionary.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Dictionary retVal = Dictionary.__fromPtr__(aruco_Dictionary_create_1from_11(nMarkers, markerSize, baseDictionary.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_Dictionary cv::aruco::Dictionary::create(int nMarkers, int markerSize, int randomSeed = 0)
        //

        //javadoc: Dictionary::create(nMarkers, markerSize, randomSeed)
        public static Dictionary create(int nMarkers, int markerSize, int randomSeed)
        {
#if UNITY_5_3_OR_NEWER
        
        Dictionary retVal = Dictionary.__fromPtr__(aruco_Dictionary_create_10(nMarkers, markerSize, randomSeed));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: Dictionary::create(nMarkers, markerSize)
        public static Dictionary create(int nMarkers, int markerSize)
        {
#if UNITY_5_3_OR_NEWER
        
        Dictionary retVal = Dictionary.__fromPtr__(aruco_Dictionary_create_11(nMarkers, markerSize));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_Dictionary cv::aruco::Dictionary::get(int dict)
        //

        //javadoc: Dictionary::get(dict)
        public static Dictionary get(int dict)
        {
#if UNITY_5_3_OR_NEWER
        
        Dictionary retVal = Dictionary.__fromPtr__(aruco_Dictionary_get_10(dict));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::aruco::Dictionary::drawMarker(int id, int sidePixels, Mat& _img, int borderBits = 1)
        //

        //javadoc: Dictionary::drawMarker(id, sidePixels, _img, borderBits)
        public void drawMarker(int id, int sidePixels, Mat _img, int borderBits)
        {
            ThrowIfDisposed();
            if (_img != null) _img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Dictionary_drawMarker_10(nativeObj, id, sidePixels, _img.nativeObj, borderBits);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Dictionary::drawMarker(id, sidePixels, _img)
        public void drawMarker(int id, int sidePixels, Mat _img)
        {
            ThrowIfDisposed();
            if (_img != null) _img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Dictionary_drawMarker_11(nativeObj, id, sidePixels, _img.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: Mat Dictionary::bytesList
        //

        //javadoc: Dictionary::get_bytesList()
        public Mat get_bytesList()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(aruco_Dictionary_get_1bytesList_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: void Dictionary::bytesList
        //

        //javadoc: Dictionary::set_bytesList(bytesList)
        public void set_bytesList(Mat bytesList)
        {
            ThrowIfDisposed();
            if (bytesList != null) bytesList.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Dictionary_set_1bytesList_10(nativeObj, bytesList.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: int Dictionary::markerSize
        //

        //javadoc: Dictionary::get_markerSize()
        public int get_markerSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = aruco_Dictionary_get_1markerSize_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Dictionary::markerSize
        //

        //javadoc: Dictionary::set_markerSize(markerSize)
        public void set_markerSize(int markerSize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Dictionary_set_1markerSize_10(nativeObj, markerSize);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: int Dictionary::maxCorrectionBits
        //

        //javadoc: Dictionary::get_maxCorrectionBits()
        public int get_maxCorrectionBits()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = aruco_Dictionary_get_1maxCorrectionBits_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Dictionary::maxCorrectionBits
        //

        //javadoc: Dictionary::set_maxCorrectionBits(maxCorrectionBits)
        public void set_maxCorrectionBits(int maxCorrectionBits)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_Dictionary_set_1maxCorrectionBits_10(nativeObj, maxCorrectionBits);
        
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



        // C++: static Mat cv::aruco::Dictionary::getBitsFromByteList(Mat byteList, int markerSize)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_getBitsFromByteList_10(IntPtr byteList_nativeObj, int markerSize);

        // C++: static Mat cv::aruco::Dictionary::getByteListFromBits(Mat bits)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_getByteListFromBits_10(IntPtr bits_nativeObj);

        // C++: static Ptr_Dictionary cv::aruco::Dictionary::create(int nMarkers, int markerSize, Ptr_Dictionary baseDictionary, int randomSeed = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_create_1from_10(int nMarkers, int markerSize, IntPtr baseDictionary_nativeObj, int randomSeed);
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_create_1from_11(int nMarkers, int markerSize, IntPtr baseDictionary_nativeObj);

        // C++: static Ptr_Dictionary cv::aruco::Dictionary::create(int nMarkers, int markerSize, int randomSeed = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_create_10(int nMarkers, int markerSize, int randomSeed);
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_create_11(int nMarkers, int markerSize);

        // C++: static Ptr_Dictionary cv::aruco::Dictionary::get(int dict)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_get_10(int dict);

        // C++:  void cv::aruco::Dictionary::drawMarker(int id, int sidePixels, Mat& _img, int borderBits = 1)
        [DllImport(LIBNAME)]
        private static extern void aruco_Dictionary_drawMarker_10(IntPtr nativeObj, int id, int sidePixels, IntPtr _img_nativeObj, int borderBits);
        [DllImport(LIBNAME)]
        private static extern void aruco_Dictionary_drawMarker_11(IntPtr nativeObj, int id, int sidePixels, IntPtr _img_nativeObj);

        // C++: Mat Dictionary::bytesList
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Dictionary_get_1bytesList_10(IntPtr nativeObj);

        // C++: void Dictionary::bytesList
        [DllImport(LIBNAME)]
        private static extern void aruco_Dictionary_set_1bytesList_10(IntPtr nativeObj, IntPtr bytesList_nativeObj);

        // C++: int Dictionary::markerSize
        [DllImport(LIBNAME)]
        private static extern int aruco_Dictionary_get_1markerSize_10(IntPtr nativeObj);

        // C++: void Dictionary::markerSize
        [DllImport(LIBNAME)]
        private static extern void aruco_Dictionary_set_1markerSize_10(IntPtr nativeObj, int markerSize);

        // C++: int Dictionary::maxCorrectionBits
        [DllImport(LIBNAME)]
        private static extern int aruco_Dictionary_get_1maxCorrectionBits_10(IntPtr nativeObj);

        // C++: void Dictionary::maxCorrectionBits
        [DllImport(LIBNAME)]
        private static extern void aruco_Dictionary_set_1maxCorrectionBits_10(IntPtr nativeObj, int maxCorrectionBits);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void aruco_Dictionary_delete(IntPtr nativeObj);

    }
}
