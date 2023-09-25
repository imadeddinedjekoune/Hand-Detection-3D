

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ImgprocModule
{
    // C++: class Subdiv2D
    //javadoc: Subdiv2D

    public class Subdiv2D : DisposableOpenCVObject
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
                        imgproc_Subdiv2D_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Subdiv2D(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static Subdiv2D __fromPtr__(IntPtr addr) { return new Subdiv2D(addr); }

        // C++: enum <unnamed>
        public const int PTLOC_ERROR = -2;
        public const int PTLOC_OUTSIDE_RECT = -1;
        public const int PTLOC_INSIDE = 0;
        public const int PTLOC_VERTEX = 1;
        public const int PTLOC_ON_EDGE = 2;
        public const int NEXT_AROUND_ORG = 0x00;
        public const int NEXT_AROUND_DST = 0x22;
        public const int PREV_AROUND_ORG = 0x11;
        public const int PREV_AROUND_DST = 0x33;
        public const int NEXT_AROUND_LEFT = 0x13;
        public const int NEXT_AROUND_RIGHT = 0x31;
        public const int PREV_AROUND_LEFT = 0x20;
        public const int PREV_AROUND_RIGHT = 0x02;
        //
        // C++:   cv::Subdiv2D::Subdiv2D(Rect rect)
        //

        //javadoc: Subdiv2D::Subdiv2D(rect)
        public Subdiv2D(Rect rect)
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = imgproc_Subdiv2D_Subdiv2D_10(rect.x, rect.y, rect.width, rect.height);
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:   cv::Subdiv2D::Subdiv2D()
        //

        //javadoc: Subdiv2D::Subdiv2D()
        public Subdiv2D()
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = imgproc_Subdiv2D_Subdiv2D_11();
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:  Point2f cv::Subdiv2D::getVertex(int vertex, int* firstEdge = 0)
        //

        //javadoc: Subdiv2D::getVertex(vertex, firstEdge)
        public Point getVertex(int vertex, int[] firstEdge)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        double[] firstEdge_out = new double[1];
        double[] tmpArray = new double[2];
imgproc_Subdiv2D_getVertex_10(nativeObj, vertex, firstEdge_out, tmpArray);
Point retVal = new Point (tmpArray);
        if(firstEdge!=null) firstEdge[0] = (int)firstEdge_out[0];
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: Subdiv2D::getVertex(vertex)
        public Point getVertex(int vertex)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
imgproc_Subdiv2D_getVertex_11(nativeObj, vertex, tmpArray);
Point retVal = new Point (tmpArray);
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  int cv::Subdiv2D::edgeDst(int edge, Point2f* dstpt = 0)
        //

        //javadoc: Subdiv2D::edgeDst(edge, dstpt)
        public int edgeDst(int edge, Point dstpt)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        double[] dstpt_out = new double[2];
        int retVal = imgproc_Subdiv2D_edgeDst_10(nativeObj, edge, dstpt_out);
        if(dstpt!=null){ dstpt.x = dstpt_out[0]; dstpt.y = dstpt_out[1]; } 
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: Subdiv2D::edgeDst(edge)
        public int edgeDst(int edge)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_Subdiv2D_edgeDst_11(nativeObj, edge);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::Subdiv2D::edgeOrg(int edge, Point2f* orgpt = 0)
        //

        //javadoc: Subdiv2D::edgeOrg(edge, orgpt)
        public int edgeOrg(int edge, Point orgpt)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        double[] orgpt_out = new double[2];
        int retVal = imgproc_Subdiv2D_edgeOrg_10(nativeObj, edge, orgpt_out);
        if(orgpt!=null){ orgpt.x = orgpt_out[0]; orgpt.y = orgpt_out[1]; } 
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: Subdiv2D::edgeOrg(edge)
        public int edgeOrg(int edge)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_Subdiv2D_edgeOrg_11(nativeObj, edge);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::Subdiv2D::findNearest(Point2f pt, Point2f* nearestPt = 0)
        //

        //javadoc: Subdiv2D::findNearest(pt, nearestPt)
        public int findNearest(Point pt, Point nearestPt)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        double[] nearestPt_out = new double[2];
        int retVal = imgproc_Subdiv2D_findNearest_10(nativeObj, pt.x, pt.y, nearestPt_out);
        if(nearestPt!=null){ nearestPt.x = nearestPt_out[0]; nearestPt.y = nearestPt_out[1]; } 
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: Subdiv2D::findNearest(pt)
        public int findNearest(Point pt)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_Subdiv2D_findNearest_11(nativeObj, pt.x, pt.y);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::Subdiv2D::getEdge(int edge, int nextEdgeType)
        //

        //javadoc: Subdiv2D::getEdge(edge, nextEdgeType)
        public int getEdge(int edge, int nextEdgeType)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_Subdiv2D_getEdge_10(nativeObj, edge, nextEdgeType);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::Subdiv2D::insert(Point2f pt)
        //

        //javadoc: Subdiv2D::insert(pt)
        public int insert(Point pt)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_Subdiv2D_insert_10(nativeObj, pt.x, pt.y);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::Subdiv2D::locate(Point2f pt, int& edge, int& vertex)
        //

        //javadoc: Subdiv2D::locate(pt, edge, vertex)
        public int locate(Point pt, int[] edge, int[] vertex)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        double[] edge_out = new double[1];
        double[] vertex_out = new double[1];
        int retVal = imgproc_Subdiv2D_locate_10(nativeObj, pt.x, pt.y, edge_out, vertex_out);
        if(edge!=null) edge[0] = (int)edge_out[0];
        if(vertex!=null) vertex[0] = (int)vertex_out[0];
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::Subdiv2D::nextEdge(int edge)
        //

        //javadoc: Subdiv2D::nextEdge(edge)
        public int nextEdge(int edge)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_Subdiv2D_nextEdge_10(nativeObj, edge);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::Subdiv2D::rotateEdge(int edge, int rotate)
        //

        //javadoc: Subdiv2D::rotateEdge(edge, rotate)
        public int rotateEdge(int edge, int rotate)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_Subdiv2D_rotateEdge_10(nativeObj, edge, rotate);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::Subdiv2D::symEdge(int edge)
        //

        //javadoc: Subdiv2D::symEdge(edge)
        public int symEdge(int edge)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_Subdiv2D_symEdge_10(nativeObj, edge);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::Subdiv2D::getEdgeList(vector_Vec4f& edgeList)
        //

        //javadoc: Subdiv2D::getEdgeList(edgeList)
        public void getEdgeList(MatOfFloat4 edgeList)
        {
            ThrowIfDisposed();
            if (edgeList != null) edgeList.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat edgeList_mat = edgeList;
        imgproc_Subdiv2D_getEdgeList_10(nativeObj, edgeList_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::Subdiv2D::getLeadingEdgeList(vector_int& leadingEdgeList)
        //

        //javadoc: Subdiv2D::getLeadingEdgeList(leadingEdgeList)
        public void getLeadingEdgeList(MatOfInt leadingEdgeList)
        {
            ThrowIfDisposed();
            if (leadingEdgeList != null) leadingEdgeList.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat leadingEdgeList_mat = leadingEdgeList;
        imgproc_Subdiv2D_getLeadingEdgeList_10(nativeObj, leadingEdgeList_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::Subdiv2D::getTriangleList(vector_Vec6f& triangleList)
        //

        //javadoc: Subdiv2D::getTriangleList(triangleList)
        public void getTriangleList(MatOfFloat6 triangleList)
        {
            ThrowIfDisposed();
            if (triangleList != null) triangleList.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat triangleList_mat = triangleList;
        imgproc_Subdiv2D_getTriangleList_10(nativeObj, triangleList_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::Subdiv2D::getVoronoiFacetList(vector_int idx, vector_vector_Point2f& facetList, vector_Point2f& facetCenters)
        //

        //javadoc: Subdiv2D::getVoronoiFacetList(idx, facetList, facetCenters)
        public void getVoronoiFacetList(MatOfInt idx, List<MatOfPoint2f> facetList, MatOfPoint2f facetCenters)
        {
            ThrowIfDisposed();
            if (idx != null) idx.ThrowIfDisposed();
            if (facetCenters != null) facetCenters.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat idx_mat = idx;
        Mat facetList_mat = new Mat();
        Mat facetCenters_mat = facetCenters;
        imgproc_Subdiv2D_getVoronoiFacetList_10(nativeObj, idx_mat.nativeObj, facetList_mat.nativeObj, facetCenters_mat.nativeObj);
        Converters.Mat_to_vector_vector_Point2f(facetList_mat, facetList);
        facetList_mat.release();
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::Subdiv2D::initDelaunay(Rect rect)
        //

        //javadoc: Subdiv2D::initDelaunay(rect)
        public void initDelaunay(Rect rect)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_Subdiv2D_initDelaunay_10(nativeObj, rect.x, rect.y, rect.width, rect.height);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::Subdiv2D::insert(vector_Point2f ptvec)
        //

        //javadoc: Subdiv2D::insert(ptvec)
        public void insert(MatOfPoint2f ptvec)
        {
            ThrowIfDisposed();
            if (ptvec != null) ptvec.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat ptvec_mat = ptvec;
        imgproc_Subdiv2D_insert_11(nativeObj, ptvec_mat.nativeObj);
        
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



        // C++:   cv::Subdiv2D::Subdiv2D(Rect rect)
        [DllImport(LIBNAME)]
        private static extern IntPtr imgproc_Subdiv2D_Subdiv2D_10(int rect_x, int rect_y, int rect_width, int rect_height);

        // C++:   cv::Subdiv2D::Subdiv2D()
        [DllImport(LIBNAME)]
        private static extern IntPtr imgproc_Subdiv2D_Subdiv2D_11();

        // C++:  Point2f cv::Subdiv2D::getVertex(int vertex, int* firstEdge = 0)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_getVertex_10(IntPtr nativeObj, int vertex, double[] firstEdge_out, double[] retVal);
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_getVertex_11(IntPtr nativeObj, int vertex, double[] retVal);

        // C++:  int cv::Subdiv2D::edgeDst(int edge, Point2f* dstpt = 0)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_edgeDst_10(IntPtr nativeObj, int edge, double[] dstpt_out);
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_edgeDst_11(IntPtr nativeObj, int edge);

        // C++:  int cv::Subdiv2D::edgeOrg(int edge, Point2f* orgpt = 0)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_edgeOrg_10(IntPtr nativeObj, int edge, double[] orgpt_out);
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_edgeOrg_11(IntPtr nativeObj, int edge);

        // C++:  int cv::Subdiv2D::findNearest(Point2f pt, Point2f* nearestPt = 0)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_findNearest_10(IntPtr nativeObj, double pt_x, double pt_y, double[] nearestPt_out);
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_findNearest_11(IntPtr nativeObj, double pt_x, double pt_y);

        // C++:  int cv::Subdiv2D::getEdge(int edge, int nextEdgeType)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_getEdge_10(IntPtr nativeObj, int edge, int nextEdgeType);

        // C++:  int cv::Subdiv2D::insert(Point2f pt)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_insert_10(IntPtr nativeObj, double pt_x, double pt_y);

        // C++:  int cv::Subdiv2D::locate(Point2f pt, int& edge, int& vertex)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_locate_10(IntPtr nativeObj, double pt_x, double pt_y, double[] edge_out, double[] vertex_out);

        // C++:  int cv::Subdiv2D::nextEdge(int edge)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_nextEdge_10(IntPtr nativeObj, int edge);

        // C++:  int cv::Subdiv2D::rotateEdge(int edge, int rotate)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_rotateEdge_10(IntPtr nativeObj, int edge, int rotate);

        // C++:  int cv::Subdiv2D::symEdge(int edge)
        [DllImport(LIBNAME)]
        private static extern int imgproc_Subdiv2D_symEdge_10(IntPtr nativeObj, int edge);

        // C++:  void cv::Subdiv2D::getEdgeList(vector_Vec4f& edgeList)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_getEdgeList_10(IntPtr nativeObj, IntPtr edgeList_mat_nativeObj);

        // C++:  void cv::Subdiv2D::getLeadingEdgeList(vector_int& leadingEdgeList)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_getLeadingEdgeList_10(IntPtr nativeObj, IntPtr leadingEdgeList_mat_nativeObj);

        // C++:  void cv::Subdiv2D::getTriangleList(vector_Vec6f& triangleList)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_getTriangleList_10(IntPtr nativeObj, IntPtr triangleList_mat_nativeObj);

        // C++:  void cv::Subdiv2D::getVoronoiFacetList(vector_int idx, vector_vector_Point2f& facetList, vector_Point2f& facetCenters)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_getVoronoiFacetList_10(IntPtr nativeObj, IntPtr idx_mat_nativeObj, IntPtr facetList_mat_nativeObj, IntPtr facetCenters_mat_nativeObj);

        // C++:  void cv::Subdiv2D::initDelaunay(Rect rect)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_initDelaunay_10(IntPtr nativeObj, int rect_x, int rect_y, int rect_width, int rect_height);

        // C++:  void cv::Subdiv2D::insert(vector_Point2f ptvec)
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_insert_11(IntPtr nativeObj, IntPtr ptvec_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void imgproc_Subdiv2D_delete(IntPtr nativeObj);

    }
}
