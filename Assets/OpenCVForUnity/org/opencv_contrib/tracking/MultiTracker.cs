
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class MultiTracker
    //javadoc: MultiTracker

    public class MultiTracker : Algorithm
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
                        tracking_MultiTracker_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal MultiTracker(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new MultiTracker __fromPtr__(IntPtr addr) { return new MultiTracker(addr); }

        //
        // C++:   cv::MultiTracker::MultiTracker()
        //

        //javadoc: MultiTracker::MultiTracker()
        public MultiTracker() :
#if UNITY_5_3_OR_NEWER
        
        base( tracking_MultiTracker_MultiTracker_10() )
        
#else
        base(IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++: static Ptr_MultiTracker cv::MultiTracker::create()
        //

        //javadoc: MultiTracker::create()
        public static MultiTracker create()
        {
#if UNITY_5_3_OR_NEWER
        
        MultiTracker retVal = MultiTracker.__fromPtr__(tracking_MultiTracker_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::MultiTracker::add(Ptr_Tracker newTracker, Mat image, Rect2d boundingBox)
        //

        //javadoc: MultiTracker::add(newTracker, image, boundingBox)
        public bool add(Tracker newTracker, Mat image, Rect2d boundingBox)
        {
            ThrowIfDisposed();
            if (newTracker != null) newTracker.ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = tracking_MultiTracker_add_10(nativeObj, newTracker.getNativeObjAddr(), image.nativeObj, boundingBox.x, boundingBox.y, boundingBox.width, boundingBox.height);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::MultiTracker::update(Mat image, vector_Rect2d& boundingBox)
        //

        //javadoc: MultiTracker::update(image, boundingBox)
        public bool update(Mat image, MatOfRect2d boundingBox)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (boundingBox != null) boundingBox.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat boundingBox_mat = boundingBox;
        bool retVal = tracking_MultiTracker_update_10(nativeObj, image.nativeObj, boundingBox_mat.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  vector_Rect2d cv::MultiTracker::getObjects()
        //

        //javadoc: MultiTracker::getObjects()
        public MatOfRect2d getObjects()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        MatOfRect2d retVal = MatOfRect2d.fromNativeAddr(tracking_MultiTracker_getObjects_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::MultiTracker::MultiTracker()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_MultiTracker_MultiTracker_10();

        // C++: static Ptr_MultiTracker cv::MultiTracker::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_MultiTracker_create_10();

        // C++:  bool cv::MultiTracker::add(Ptr_Tracker newTracker, Mat image, Rect2d boundingBox)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_MultiTracker_add_10(IntPtr nativeObj, IntPtr newTracker_nativeObj, IntPtr image_nativeObj, double boundingBox_x, double boundingBox_y, double boundingBox_width, double boundingBox_height);

        // C++:  bool cv::MultiTracker::update(Mat image, vector_Rect2d& boundingBox)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_MultiTracker_update_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr boundingBox_mat_nativeObj);

        // C++:  vector_Rect2d cv::MultiTracker::getObjects()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_MultiTracker_getObjects_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_MultiTracker_delete(IntPtr nativeObj);

    }
}
