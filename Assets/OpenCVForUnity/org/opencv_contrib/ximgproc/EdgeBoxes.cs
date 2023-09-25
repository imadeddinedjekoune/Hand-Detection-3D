
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class EdgeBoxes
    //javadoc: EdgeBoxes

    public class EdgeBoxes : Algorithm
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
                        ximgproc_EdgeBoxes_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal EdgeBoxes(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new EdgeBoxes __fromPtr__(IntPtr addr) { return new EdgeBoxes(addr); }

        //
        // C++:  float cv::ximgproc::EdgeBoxes::getAlpha()
        //

        //javadoc: EdgeBoxes::getAlpha()
        public float getAlpha()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getAlpha_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getBeta()
        //

        //javadoc: EdgeBoxes::getBeta()
        public float getBeta()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getBeta_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getClusterMinMag()
        //

        //javadoc: EdgeBoxes::getClusterMinMag()
        public float getClusterMinMag()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getClusterMinMag_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getEdgeMergeThr()
        //

        //javadoc: EdgeBoxes::getEdgeMergeThr()
        public float getEdgeMergeThr()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getEdgeMergeThr_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getEdgeMinMag()
        //

        //javadoc: EdgeBoxes::getEdgeMinMag()
        public float getEdgeMinMag()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getEdgeMinMag_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getEta()
        //

        //javadoc: EdgeBoxes::getEta()
        public float getEta()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getEta_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getGamma()
        //

        //javadoc: EdgeBoxes::getGamma()
        public float getGamma()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getGamma_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getKappa()
        //

        //javadoc: EdgeBoxes::getKappa()
        public float getKappa()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getKappa_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getMaxAspectRatio()
        //

        //javadoc: EdgeBoxes::getMaxAspectRatio()
        public float getMaxAspectRatio()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getMaxAspectRatio_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getMinBoxArea()
        //

        //javadoc: EdgeBoxes::getMinBoxArea()
        public float getMinBoxArea()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getMinBoxArea_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::ximgproc::EdgeBoxes::getMinScore()
        //

        //javadoc: EdgeBoxes::getMinScore()
        public float getMinScore()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getMinScore_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ximgproc::EdgeBoxes::getMaxBoxes()
        //

        //javadoc: EdgeBoxes::getMaxBoxes()
        public int getMaxBoxes()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ximgproc_EdgeBoxes_getMaxBoxes_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::getBoundingBoxes(Mat edge_map, Mat orientation_map, vector_Rect& boxes)
        //

        //javadoc: EdgeBoxes::getBoundingBoxes(edge_map, orientation_map, boxes)
        public void getBoundingBoxes(Mat edge_map, Mat orientation_map, MatOfRect boxes)
        {
            ThrowIfDisposed();
            if (edge_map != null) edge_map.ThrowIfDisposed();
            if (orientation_map != null) orientation_map.ThrowIfDisposed();
            if (boxes != null) boxes.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat boxes_mat = boxes;
        ximgproc_EdgeBoxes_getBoundingBoxes_10(nativeObj, edge_map.nativeObj, orientation_map.nativeObj, boxes_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setAlpha(float value)
        //

        //javadoc: EdgeBoxes::setAlpha(value)
        public void setAlpha(float value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setAlpha_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setBeta(float value)
        //

        //javadoc: EdgeBoxes::setBeta(value)
        public void setBeta(float value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setBeta_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setClusterMinMag(float value)
        //

        //javadoc: EdgeBoxes::setClusterMinMag(value)
        public void setClusterMinMag(float value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setClusterMinMag_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setEdgeMergeThr(float value)
        //

        //javadoc: EdgeBoxes::setEdgeMergeThr(value)
        public void setEdgeMergeThr(float value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setEdgeMergeThr_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setEdgeMinMag(float value)
        //

        //javadoc: EdgeBoxes::setEdgeMinMag(value)
        public void setEdgeMinMag(float value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setEdgeMinMag_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setEta(float value)
        //

        //javadoc: EdgeBoxes::setEta(value)
        public void setEta(float value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setEta_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setGamma(float value)
        //

        //javadoc: EdgeBoxes::setGamma(value)
        public void setGamma(float value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setGamma_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setKappa(float value)
        //

        //javadoc: EdgeBoxes::setKappa(value)
        public void setKappa(float value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setKappa_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setMaxAspectRatio(float value)
        //

        //javadoc: EdgeBoxes::setMaxAspectRatio(value)
        public void setMaxAspectRatio(float value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setMaxAspectRatio_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setMaxBoxes(int value)
        //

        //javadoc: EdgeBoxes::setMaxBoxes(value)
        public void setMaxBoxes(int value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setMaxBoxes_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setMinBoxArea(float value)
        //

        //javadoc: EdgeBoxes::setMinBoxArea(value)
        public void setMinBoxArea(float value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setMinBoxArea_10(nativeObj, value);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ximgproc::EdgeBoxes::setMinScore(float value)
        //

        //javadoc: EdgeBoxes::setMinScore(value)
        public void setMinScore(float value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setMinScore_10(nativeObj, value);
        
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



        // C++:  float cv::ximgproc::EdgeBoxes::getAlpha()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getAlpha_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeBoxes::getBeta()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getBeta_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeBoxes::getClusterMinMag()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getClusterMinMag_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeBoxes::getEdgeMergeThr()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getEdgeMergeThr_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeBoxes::getEdgeMinMag()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getEdgeMinMag_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeBoxes::getEta()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getEta_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeBoxes::getGamma()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getGamma_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeBoxes::getKappa()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getKappa_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeBoxes::getMaxAspectRatio()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getMaxAspectRatio_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeBoxes::getMinBoxArea()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getMinBoxArea_10(IntPtr nativeObj);

        // C++:  float cv::ximgproc::EdgeBoxes::getMinScore()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getMinScore_10(IntPtr nativeObj);

        // C++:  int cv::ximgproc::EdgeBoxes::getMaxBoxes()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_EdgeBoxes_getMaxBoxes_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::getBoundingBoxes(Mat edge_map, Mat orientation_map, vector_Rect& boxes)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_getBoundingBoxes_10(IntPtr nativeObj, IntPtr edge_map_nativeObj, IntPtr orientation_map_nativeObj, IntPtr boxes_mat_nativeObj);

        // C++:  void cv::ximgproc::EdgeBoxes::setAlpha(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setAlpha_10(IntPtr nativeObj, float value);

        // C++:  void cv::ximgproc::EdgeBoxes::setBeta(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setBeta_10(IntPtr nativeObj, float value);

        // C++:  void cv::ximgproc::EdgeBoxes::setClusterMinMag(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setClusterMinMag_10(IntPtr nativeObj, float value);

        // C++:  void cv::ximgproc::EdgeBoxes::setEdgeMergeThr(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setEdgeMergeThr_10(IntPtr nativeObj, float value);

        // C++:  void cv::ximgproc::EdgeBoxes::setEdgeMinMag(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setEdgeMinMag_10(IntPtr nativeObj, float value);

        // C++:  void cv::ximgproc::EdgeBoxes::setEta(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setEta_10(IntPtr nativeObj, float value);

        // C++:  void cv::ximgproc::EdgeBoxes::setGamma(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setGamma_10(IntPtr nativeObj, float value);

        // C++:  void cv::ximgproc::EdgeBoxes::setKappa(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setKappa_10(IntPtr nativeObj, float value);

        // C++:  void cv::ximgproc::EdgeBoxes::setMaxAspectRatio(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setMaxAspectRatio_10(IntPtr nativeObj, float value);

        // C++:  void cv::ximgproc::EdgeBoxes::setMaxBoxes(int value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setMaxBoxes_10(IntPtr nativeObj, int value);

        // C++:  void cv::ximgproc::EdgeBoxes::setMinBoxArea(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setMinBoxArea_10(IntPtr nativeObj, float value);

        // C++:  void cv::ximgproc::EdgeBoxes::setMinScore(float value)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setMinScore_10(IntPtr nativeObj, float value);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_delete(IntPtr nativeObj);

    }
}
