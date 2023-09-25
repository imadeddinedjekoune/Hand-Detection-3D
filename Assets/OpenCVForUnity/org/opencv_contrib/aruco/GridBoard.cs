
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ArucoModule
{

    // C++: class GridBoard
    //javadoc: GridBoard

    public class GridBoard : Board
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
                        aruco_GridBoard_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GridBoard(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GridBoard __fromPtr__(IntPtr addr) { return new GridBoard(addr); }

        //
        // C++: static Ptr_GridBoard cv::aruco::GridBoard::create(int markersX, int markersY, float markerLength, float markerSeparation, Ptr_Dictionary dictionary, int firstMarker = 0)
        //

        //javadoc: GridBoard::create(markersX, markersY, markerLength, markerSeparation, dictionary, firstMarker)
        public static GridBoard create(int markersX, int markersY, float markerLength, float markerSeparation, Dictionary dictionary, int firstMarker)
        {
            if (dictionary != null) dictionary.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        GridBoard retVal = GridBoard.__fromPtr__(aruco_GridBoard_create_10(markersX, markersY, markerLength, markerSeparation, dictionary.getNativeObjAddr(), firstMarker));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: GridBoard::create(markersX, markersY, markerLength, markerSeparation, dictionary)
        public static GridBoard create(int markersX, int markersY, float markerLength, float markerSeparation, Dictionary dictionary)
        {
            if (dictionary != null) dictionary.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        GridBoard retVal = GridBoard.__fromPtr__(aruco_GridBoard_create_11(markersX, markersY, markerLength, markerSeparation, dictionary.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Size cv::aruco::GridBoard::getGridSize()
        //

        //javadoc: GridBoard::getGridSize()
        public Size getGridSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
aruco_GridBoard_getGridSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  float cv::aruco::GridBoard::getMarkerLength()
        //

        //javadoc: GridBoard::getMarkerLength()
        public float getMarkerLength()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = aruco_GridBoard_getMarkerLength_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::aruco::GridBoard::getMarkerSeparation()
        //

        //javadoc: GridBoard::getMarkerSeparation()
        public float getMarkerSeparation()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = aruco_GridBoard_getMarkerSeparation_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::aruco::GridBoard::draw(Size outSize, Mat& img, int marginSize = 0, int borderBits = 1)
        //

        //javadoc: GridBoard::draw(outSize, img, marginSize, borderBits)
        public void draw(Size outSize, Mat img, int marginSize, int borderBits)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_GridBoard_draw_10(nativeObj, outSize.width, outSize.height, img.nativeObj, marginSize, borderBits);
        
        return;
#else
            return;
#endif
        }

        //javadoc: GridBoard::draw(outSize, img, marginSize)
        public void draw(Size outSize, Mat img, int marginSize)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_GridBoard_draw_11(nativeObj, outSize.width, outSize.height, img.nativeObj, marginSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: GridBoard::draw(outSize, img)
        public void draw(Size outSize, Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_GridBoard_draw_12(nativeObj, outSize.width, outSize.height, img.nativeObj);
        
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



        // C++: static Ptr_GridBoard cv::aruco::GridBoard::create(int markersX, int markersY, float markerLength, float markerSeparation, Ptr_Dictionary dictionary, int firstMarker = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_GridBoard_create_10(int markersX, int markersY, float markerLength, float markerSeparation, IntPtr dictionary_nativeObj, int firstMarker);
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_GridBoard_create_11(int markersX, int markersY, float markerLength, float markerSeparation, IntPtr dictionary_nativeObj);

        // C++:  Size cv::aruco::GridBoard::getGridSize()
        [DllImport(LIBNAME)]
        private static extern void aruco_GridBoard_getGridSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  float cv::aruco::GridBoard::getMarkerLength()
        [DllImport(LIBNAME)]
        private static extern float aruco_GridBoard_getMarkerLength_10(IntPtr nativeObj);

        // C++:  float cv::aruco::GridBoard::getMarkerSeparation()
        [DllImport(LIBNAME)]
        private static extern float aruco_GridBoard_getMarkerSeparation_10(IntPtr nativeObj);

        // C++:  void cv::aruco::GridBoard::draw(Size outSize, Mat& img, int marginSize = 0, int borderBits = 1)
        [DllImport(LIBNAME)]
        private static extern void aruco_GridBoard_draw_10(IntPtr nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj, int marginSize, int borderBits);
        [DllImport(LIBNAME)]
        private static extern void aruco_GridBoard_draw_11(IntPtr nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj, int marginSize);
        [DllImport(LIBNAME)]
        private static extern void aruco_GridBoard_draw_12(IntPtr nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void aruco_GridBoard_delete(IntPtr nativeObj);

    }
}
