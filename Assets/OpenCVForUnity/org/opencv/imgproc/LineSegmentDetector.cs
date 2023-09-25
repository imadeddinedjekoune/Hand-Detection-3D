
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ImgprocModule
{

    // C++: class LineSegmentDetector
    //javadoc: LineSegmentDetector

    public class LineSegmentDetector : Algorithm
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
                        imgproc_LineSegmentDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal LineSegmentDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new LineSegmentDetector __fromPtr__(IntPtr addr) { return new LineSegmentDetector(addr); }

        //
        // C++:  int cv::LineSegmentDetector::compareSegments(Size size, Mat lines1, Mat lines2, Mat& _image = Mat())
        //

        //javadoc: LineSegmentDetector::compareSegments(size, lines1, lines2, _image)
        public int compareSegments(Size size, Mat lines1, Mat lines2, Mat _image)
        {
            ThrowIfDisposed();
            if (lines1 != null) lines1.ThrowIfDisposed();
            if (lines2 != null) lines2.ThrowIfDisposed();
            if (_image != null) _image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_LineSegmentDetector_compareSegments_10(nativeObj, size.width, size.height, lines1.nativeObj, lines2.nativeObj, _image.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: LineSegmentDetector::compareSegments(size, lines1, lines2)
        public int compareSegments(Size size, Mat lines1, Mat lines2)
        {
            ThrowIfDisposed();
            if (lines1 != null) lines1.ThrowIfDisposed();
            if (lines2 != null) lines2.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_LineSegmentDetector_compareSegments_11(nativeObj, size.width, size.height, lines1.nativeObj, lines2.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::LineSegmentDetector::detect(Mat _image, Mat& _lines, Mat& width = Mat(), Mat& prec = Mat(), Mat& nfa = Mat())
        //

        //javadoc: LineSegmentDetector::detect(_image, _lines, width, prec, nfa)
        public void detect(Mat _image, Mat _lines, Mat width, Mat prec, Mat nfa)
        {
            ThrowIfDisposed();
            if (_image != null) _image.ThrowIfDisposed();
            if (_lines != null) _lines.ThrowIfDisposed();
            if (width != null) width.ThrowIfDisposed();
            if (prec != null) prec.ThrowIfDisposed();
            if (nfa != null) nfa.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_LineSegmentDetector_detect_10(nativeObj, _image.nativeObj, _lines.nativeObj, width.nativeObj, prec.nativeObj, nfa.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: LineSegmentDetector::detect(_image, _lines, width, prec)
        public void detect(Mat _image, Mat _lines, Mat width, Mat prec)
        {
            ThrowIfDisposed();
            if (_image != null) _image.ThrowIfDisposed();
            if (_lines != null) _lines.ThrowIfDisposed();
            if (width != null) width.ThrowIfDisposed();
            if (prec != null) prec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_LineSegmentDetector_detect_11(nativeObj, _image.nativeObj, _lines.nativeObj, width.nativeObj, prec.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: LineSegmentDetector::detect(_image, _lines, width)
        public void detect(Mat _image, Mat _lines, Mat width)
        {
            ThrowIfDisposed();
            if (_image != null) _image.ThrowIfDisposed();
            if (_lines != null) _lines.ThrowIfDisposed();
            if (width != null) width.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_LineSegmentDetector_detect_12(nativeObj, _image.nativeObj, _lines.nativeObj, width.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: LineSegmentDetector::detect(_image, _lines)
        public void detect(Mat _image, Mat _lines)
        {
            ThrowIfDisposed();
            if (_image != null) _image.ThrowIfDisposed();
            if (_lines != null) _lines.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_LineSegmentDetector_detect_13(nativeObj, _image.nativeObj, _lines.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::LineSegmentDetector::drawSegments(Mat& _image, Mat lines)
        //

        //javadoc: LineSegmentDetector::drawSegments(_image, lines)
        public void drawSegments(Mat _image, Mat lines)
        {
            ThrowIfDisposed();
            if (_image != null) _image.ThrowIfDisposed();
            if (lines != null) lines.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_LineSegmentDetector_drawSegments_10(nativeObj, _image.nativeObj, lines.nativeObj);
        
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



        // C++:  int cv::LineSegmentDetector::compareSegments(Size size, Mat lines1, Mat lines2, Mat& _image = Mat())
        [DllImport(LIBNAME)]
        private static extern int imgproc_LineSegmentDetector_compareSegments_10(IntPtr nativeObj, double size_width, double size_height, IntPtr lines1_nativeObj, IntPtr lines2_nativeObj, IntPtr _image_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int imgproc_LineSegmentDetector_compareSegments_11(IntPtr nativeObj, double size_width, double size_height, IntPtr lines1_nativeObj, IntPtr lines2_nativeObj);

        // C++:  void cv::LineSegmentDetector::detect(Mat _image, Mat& _lines, Mat& width = Mat(), Mat& prec = Mat(), Mat& nfa = Mat())
        [DllImport(LIBNAME)]
        private static extern void imgproc_LineSegmentDetector_detect_10(IntPtr nativeObj, IntPtr _image_nativeObj, IntPtr _lines_nativeObj, IntPtr width_nativeObj, IntPtr prec_nativeObj, IntPtr nfa_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void imgproc_LineSegmentDetector_detect_11(IntPtr nativeObj, IntPtr _image_nativeObj, IntPtr _lines_nativeObj, IntPtr width_nativeObj, IntPtr prec_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void imgproc_LineSegmentDetector_detect_12(IntPtr nativeObj, IntPtr _image_nativeObj, IntPtr _lines_nativeObj, IntPtr width_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void imgproc_LineSegmentDetector_detect_13(IntPtr nativeObj, IntPtr _image_nativeObj, IntPtr _lines_nativeObj);

        // C++:  void cv::LineSegmentDetector::drawSegments(Mat& _image, Mat lines)
        [DllImport(LIBNAME)]
        private static extern void imgproc_LineSegmentDetector_drawSegments_10(IntPtr nativeObj, IntPtr _image_nativeObj, IntPtr lines_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void imgproc_LineSegmentDetector_delete(IntPtr nativeObj);

    }
}
