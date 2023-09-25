
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class FastLineDetector
    //javadoc: FastLineDetector

    public class FastLineDetector : Algorithm
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
                        ximgproc_FastLineDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FastLineDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FastLineDetector __fromPtr__(IntPtr addr) { return new FastLineDetector(addr); }

        //
        // C++:  void cv::ximgproc::FastLineDetector::detect(Mat _image, Mat& _lines)
        //

        //javadoc: FastLineDetector::detect(_image, _lines)
        public void detect(Mat _image, Mat _lines)
        {
            ThrowIfDisposed();
            if (_image != null) _image.ThrowIfDisposed();
            if (_lines != null) _lines.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_FastLineDetector_detect_10(nativeObj, _image.nativeObj, _lines.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::FastLineDetector::drawSegments(Mat& _image, Mat lines, bool draw_arrow = false)
        //

        //javadoc: FastLineDetector::drawSegments(_image, lines, draw_arrow)
        public void drawSegments(Mat _image, Mat lines, bool draw_arrow)
        {
            ThrowIfDisposed();
            if (_image != null) _image.ThrowIfDisposed();
            if (lines != null) lines.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_FastLineDetector_drawSegments_10(nativeObj, _image.nativeObj, lines.nativeObj, draw_arrow);
        
        return;
#else
            return;
#endif
        }

        //javadoc: FastLineDetector::drawSegments(_image, lines)
        public void drawSegments(Mat _image, Mat lines)
        {
            ThrowIfDisposed();
            if (_image != null) _image.ThrowIfDisposed();
            if (lines != null) lines.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_FastLineDetector_drawSegments_11(nativeObj, _image.nativeObj, lines.nativeObj);
        
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



        // C++:  void cv::ximgproc::FastLineDetector::detect(Mat _image, Mat& _lines)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_FastLineDetector_detect_10(IntPtr nativeObj, IntPtr _image_nativeObj, IntPtr _lines_nativeObj);

        // C++:  void cv::ximgproc::FastLineDetector::drawSegments(Mat& _image, Mat lines, bool draw_arrow = false)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_FastLineDetector_drawSegments_10(IntPtr nativeObj, IntPtr _image_nativeObj, IntPtr lines_nativeObj, [MarshalAs(UnmanagedType.U1)] bool draw_arrow);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_FastLineDetector_drawSegments_11(IntPtr nativeObj, IntPtr _image_nativeObj, IntPtr lines_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_FastLineDetector_delete(IntPtr nativeObj);

    }
}
