
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class StructuredEdgeDetection
    //javadoc: StructuredEdgeDetection

    public class StructuredEdgeDetection : Algorithm
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
                        ximgproc_StructuredEdgeDetection_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StructuredEdgeDetection(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StructuredEdgeDetection __fromPtr__(IntPtr addr) { return new StructuredEdgeDetection(addr); }

        //
        // C++:  void cv::ximgproc::StructuredEdgeDetection::computeOrientation(Mat _src, Mat& _dst)
        //

        //javadoc: StructuredEdgeDetection::computeOrientation(_src, _dst)
        public void computeOrientation(Mat _src, Mat _dst)
        {
            ThrowIfDisposed();
            if (_src != null) _src.ThrowIfDisposed();
            if (_dst != null) _dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_StructuredEdgeDetection_computeOrientation_10(nativeObj, _src.nativeObj, _dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::StructuredEdgeDetection::detectEdges(Mat _src, Mat& _dst)
        //

        //javadoc: StructuredEdgeDetection::detectEdges(_src, _dst)
        public void detectEdges(Mat _src, Mat _dst)
        {
            ThrowIfDisposed();
            if (_src != null) _src.ThrowIfDisposed();
            if (_dst != null) _dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_StructuredEdgeDetection_detectEdges_10(nativeObj, _src.nativeObj, _dst.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::StructuredEdgeDetection::edgesNms(Mat edge_image, Mat orientation_image, Mat& _dst, int r = 2, int s = 0, float m = 1, bool isParallel = true)
        //

        //javadoc: StructuredEdgeDetection::edgesNms(edge_image, orientation_image, _dst, r, s, m, isParallel)
        public void edgesNms(Mat edge_image, Mat orientation_image, Mat _dst, int r, int s, float m, bool isParallel)
        {
            ThrowIfDisposed();
            if (edge_image != null) edge_image.ThrowIfDisposed();
            if (orientation_image != null) orientation_image.ThrowIfDisposed();
            if (_dst != null) _dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_StructuredEdgeDetection_edgesNms_10(nativeObj, edge_image.nativeObj, orientation_image.nativeObj, _dst.nativeObj, r, s, m, isParallel);
        
        return;
#else
            return;
#endif
        }

        //javadoc: StructuredEdgeDetection::edgesNms(edge_image, orientation_image, _dst, r, s, m)
        public void edgesNms(Mat edge_image, Mat orientation_image, Mat _dst, int r, int s, float m)
        {
            ThrowIfDisposed();
            if (edge_image != null) edge_image.ThrowIfDisposed();
            if (orientation_image != null) orientation_image.ThrowIfDisposed();
            if (_dst != null) _dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_StructuredEdgeDetection_edgesNms_11(nativeObj, edge_image.nativeObj, orientation_image.nativeObj, _dst.nativeObj, r, s, m);
        
        return;
#else
            return;
#endif
        }

        //javadoc: StructuredEdgeDetection::edgesNms(edge_image, orientation_image, _dst, r, s)
        public void edgesNms(Mat edge_image, Mat orientation_image, Mat _dst, int r, int s)
        {
            ThrowIfDisposed();
            if (edge_image != null) edge_image.ThrowIfDisposed();
            if (orientation_image != null) orientation_image.ThrowIfDisposed();
            if (_dst != null) _dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_StructuredEdgeDetection_edgesNms_12(nativeObj, edge_image.nativeObj, orientation_image.nativeObj, _dst.nativeObj, r, s);
        
        return;
#else
            return;
#endif
        }

        //javadoc: StructuredEdgeDetection::edgesNms(edge_image, orientation_image, _dst, r)
        public void edgesNms(Mat edge_image, Mat orientation_image, Mat _dst, int r)
        {
            ThrowIfDisposed();
            if (edge_image != null) edge_image.ThrowIfDisposed();
            if (orientation_image != null) orientation_image.ThrowIfDisposed();
            if (_dst != null) _dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_StructuredEdgeDetection_edgesNms_13(nativeObj, edge_image.nativeObj, orientation_image.nativeObj, _dst.nativeObj, r);
        
        return;
#else
            return;
#endif
        }

        //javadoc: StructuredEdgeDetection::edgesNms(edge_image, orientation_image, _dst)
        public void edgesNms(Mat edge_image, Mat orientation_image, Mat _dst)
        {
            ThrowIfDisposed();
            if (edge_image != null) edge_image.ThrowIfDisposed();
            if (orientation_image != null) orientation_image.ThrowIfDisposed();
            if (_dst != null) _dst.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_StructuredEdgeDetection_edgesNms_14(nativeObj, edge_image.nativeObj, orientation_image.nativeObj, _dst.nativeObj);
        
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



        // C++:  void cv::ximgproc::StructuredEdgeDetection::computeOrientation(Mat _src, Mat& _dst)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_StructuredEdgeDetection_computeOrientation_10(IntPtr nativeObj, IntPtr _src_nativeObj, IntPtr _dst_nativeObj);

        // C++:  void cv::ximgproc::StructuredEdgeDetection::detectEdges(Mat _src, Mat& _dst)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_StructuredEdgeDetection_detectEdges_10(IntPtr nativeObj, IntPtr _src_nativeObj, IntPtr _dst_nativeObj);

        // C++:  void cv::ximgproc::StructuredEdgeDetection::edgesNms(Mat edge_image, Mat orientation_image, Mat& _dst, int r = 2, int s = 0, float m = 1, bool isParallel = true)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_StructuredEdgeDetection_edgesNms_10(IntPtr nativeObj, IntPtr edge_image_nativeObj, IntPtr orientation_image_nativeObj, IntPtr _dst_nativeObj, int r, int s, float m, [MarshalAs(UnmanagedType.U1)] bool isParallel);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_StructuredEdgeDetection_edgesNms_11(IntPtr nativeObj, IntPtr edge_image_nativeObj, IntPtr orientation_image_nativeObj, IntPtr _dst_nativeObj, int r, int s, float m);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_StructuredEdgeDetection_edgesNms_12(IntPtr nativeObj, IntPtr edge_image_nativeObj, IntPtr orientation_image_nativeObj, IntPtr _dst_nativeObj, int r, int s);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_StructuredEdgeDetection_edgesNms_13(IntPtr nativeObj, IntPtr edge_image_nativeObj, IntPtr orientation_image_nativeObj, IntPtr _dst_nativeObj, int r);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_StructuredEdgeDetection_edgesNms_14(IntPtr nativeObj, IntPtr edge_image_nativeObj, IntPtr orientation_image_nativeObj, IntPtr _dst_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_StructuredEdgeDetection_delete(IntPtr nativeObj);

    }
}
