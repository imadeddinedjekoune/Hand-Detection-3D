

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class QRCodeDetector
    //javadoc: QRCodeDetector

    public class QRCodeDetector : DisposableOpenCVObject
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
                        objdetect_QRCodeDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal QRCodeDetector(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static QRCodeDetector __fromPtr__(IntPtr addr) { return new QRCodeDetector(addr); }

        //
        // C++:   cv::QRCodeDetector::QRCodeDetector()
        //

        //javadoc: QRCodeDetector::QRCodeDetector()
        public QRCodeDetector()
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = objdetect_QRCodeDetector_QRCodeDetector_10();
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::QRCodeDetector::detect(Mat img, Mat& points)
        //

        //javadoc: QRCodeDetector::detect(img, points)
        public bool detect(Mat img, Mat points)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_QRCodeDetector_detect_10(nativeObj, img.nativeObj, points.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  string cv::QRCodeDetector::decode(Mat img, Mat points, Mat& straight_qrcode = Mat())
        //

        //javadoc: QRCodeDetector::decode(img, points, straight_qrcode)
        public string decode(Mat img, Mat points, Mat straight_qrcode)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();
            if (straight_qrcode != null) straight_qrcode.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (objdetect_QRCodeDetector_decode_10(nativeObj, img.nativeObj, points.nativeObj, straight_qrcode.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: QRCodeDetector::decode(img, points)
        public string decode(Mat img, Mat points)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (objdetect_QRCodeDetector_decode_11(nativeObj, img.nativeObj, points.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  string cv::QRCodeDetector::detectAndDecode(Mat img, Mat& points = Mat(), Mat& straight_qrcode = Mat())
        //

        //javadoc: QRCodeDetector::detectAndDecode(img, points, straight_qrcode)
        public string detectAndDecode(Mat img, Mat points, Mat straight_qrcode)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();
            if (straight_qrcode != null) straight_qrcode.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (objdetect_QRCodeDetector_detectAndDecode_10(nativeObj, img.nativeObj, points.nativeObj, straight_qrcode.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: QRCodeDetector::detectAndDecode(img, points)
        public string detectAndDecode(Mat img, Mat points)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (objdetect_QRCodeDetector_detectAndDecode_11(nativeObj, img.nativeObj, points.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: QRCodeDetector::detectAndDecode(img)
        public string detectAndDecode(Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (objdetect_QRCodeDetector_detectAndDecode_12(nativeObj, img.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::QRCodeDetector::setEpsX(double epsX)
        //

        //javadoc: QRCodeDetector::setEpsX(epsX)
        public void setEpsX(double epsX)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        objdetect_QRCodeDetector_setEpsX_10(nativeObj, epsX);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::QRCodeDetector::setEpsY(double epsY)
        //

        //javadoc: QRCodeDetector::setEpsY(epsY)
        public void setEpsY(double epsY)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        objdetect_QRCodeDetector_setEpsY_10(nativeObj, epsY);
        
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



        // C++:   cv::QRCodeDetector::QRCodeDetector()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeDetector_QRCodeDetector_10();

        // C++:  bool cv::QRCodeDetector::detect(Mat img, Mat& points)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_QRCodeDetector_detect_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_nativeObj);

        // C++:  string cv::QRCodeDetector::decode(Mat img, Mat points, Mat& straight_qrcode = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeDetector_decode_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_nativeObj, IntPtr straight_qrcode_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeDetector_decode_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_nativeObj);

        // C++:  string cv::QRCodeDetector::detectAndDecode(Mat img, Mat& points = Mat(), Mat& straight_qrcode = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeDetector_detectAndDecode_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_nativeObj, IntPtr straight_qrcode_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeDetector_detectAndDecode_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeDetector_detectAndDecode_12(IntPtr nativeObj, IntPtr img_nativeObj);

        // C++:  void cv::QRCodeDetector::setEpsX(double epsX)
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeDetector_setEpsX_10(IntPtr nativeObj, double epsX);

        // C++:  void cv::QRCodeDetector::setEpsY(double epsY)
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeDetector_setEpsY_10(IntPtr nativeObj, double epsY);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeDetector_delete(IntPtr nativeObj);

    }
}
