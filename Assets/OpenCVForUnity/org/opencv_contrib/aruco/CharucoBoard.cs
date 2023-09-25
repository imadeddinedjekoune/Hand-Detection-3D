
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ArucoModule
{

    // C++: class CharucoBoard
    //javadoc: CharucoBoard

    public class CharucoBoard : Board
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
                        aruco_CharucoBoard_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal CharucoBoard(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new CharucoBoard __fromPtr__(IntPtr addr) { return new CharucoBoard(addr); }

        //
        // C++: static Ptr_CharucoBoard cv::aruco::CharucoBoard::create(int squaresX, int squaresY, float squareLength, float markerLength, Ptr_Dictionary dictionary)
        //

        //javadoc: CharucoBoard::create(squaresX, squaresY, squareLength, markerLength, dictionary)
        public static CharucoBoard create(int squaresX, int squaresY, float squareLength, float markerLength, Dictionary dictionary)
        {
            if (dictionary != null) dictionary.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        CharucoBoard retVal = CharucoBoard.__fromPtr__(aruco_CharucoBoard_create_10(squaresX, squaresY, squareLength, markerLength, dictionary.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Size cv::aruco::CharucoBoard::getChessboardSize()
        //

        //javadoc: CharucoBoard::getChessboardSize()
        public Size getChessboardSize()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
aruco_CharucoBoard_getChessboardSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  float cv::aruco::CharucoBoard::getMarkerLength()
        //

        //javadoc: CharucoBoard::getMarkerLength()
        public float getMarkerLength()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = aruco_CharucoBoard_getMarkerLength_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::aruco::CharucoBoard::getSquareLength()
        //

        //javadoc: CharucoBoard::getSquareLength()
        public float getSquareLength()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = aruco_CharucoBoard_getSquareLength_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::aruco::CharucoBoard::draw(Size outSize, Mat& img, int marginSize = 0, int borderBits = 1)
        //

        //javadoc: CharucoBoard::draw(outSize, img, marginSize, borderBits)
        public void draw(Size outSize, Mat img, int marginSize, int borderBits)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_CharucoBoard_draw_10(nativeObj, outSize.width, outSize.height, img.nativeObj, marginSize, borderBits);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CharucoBoard::draw(outSize, img, marginSize)
        public void draw(Size outSize, Mat img, int marginSize)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_CharucoBoard_draw_11(nativeObj, outSize.width, outSize.height, img.nativeObj, marginSize);
        
        return;
#else
            return;
#endif
        }

        //javadoc: CharucoBoard::draw(outSize, img)
        public void draw(Size outSize, Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        aruco_CharucoBoard_draw_12(nativeObj, outSize.width, outSize.height, img.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: vector_Point3f CharucoBoard::chessboardCorners
        //

        //javadoc: CharucoBoard::get_chessboardCorners()
        public MatOfPoint3f get_chessboardCorners()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        MatOfPoint3f retVal = MatOfPoint3f.fromNativeAddr(aruco_CharucoBoard_get_1chessboardCorners_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: vector_vector_int CharucoBoard::nearestMarkerIdx
        //

        // Return type 'vector_vector_int' is not supported, skipping the function


        //
        // C++: vector_vector_int CharucoBoard::nearestMarkerCorners
        //

        // Return type 'vector_vector_int' is not supported, skipping the function


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_CharucoBoard cv::aruco::CharucoBoard::create(int squaresX, int squaresY, float squareLength, float markerLength, Ptr_Dictionary dictionary)
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_CharucoBoard_create_10(int squaresX, int squaresY, float squareLength, float markerLength, IntPtr dictionary_nativeObj);

        // C++:  Size cv::aruco::CharucoBoard::getChessboardSize()
        [DllImport(LIBNAME)]
        private static extern void aruco_CharucoBoard_getChessboardSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  float cv::aruco::CharucoBoard::getMarkerLength()
        [DllImport(LIBNAME)]
        private static extern float aruco_CharucoBoard_getMarkerLength_10(IntPtr nativeObj);

        // C++:  float cv::aruco::CharucoBoard::getSquareLength()
        [DllImport(LIBNAME)]
        private static extern float aruco_CharucoBoard_getSquareLength_10(IntPtr nativeObj);

        // C++:  void cv::aruco::CharucoBoard::draw(Size outSize, Mat& img, int marginSize = 0, int borderBits = 1)
        [DllImport(LIBNAME)]
        private static extern void aruco_CharucoBoard_draw_10(IntPtr nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj, int marginSize, int borderBits);
        [DllImport(LIBNAME)]
        private static extern void aruco_CharucoBoard_draw_11(IntPtr nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj, int marginSize);
        [DllImport(LIBNAME)]
        private static extern void aruco_CharucoBoard_draw_12(IntPtr nativeObj, double outSize_width, double outSize_height, IntPtr img_nativeObj);

        // C++: vector_Point3f CharucoBoard::chessboardCorners
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_CharucoBoard_get_1chessboardCorners_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void aruco_CharucoBoard_delete(IntPtr nativeObj);

    }
}
