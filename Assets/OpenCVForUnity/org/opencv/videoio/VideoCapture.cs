

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoioModule
{
    // C++: class VideoCapture
    //javadoc: VideoCapture

    public class VideoCapture : DisposableOpenCVObject
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
                        videoio_VideoCapture_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal VideoCapture(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static VideoCapture __fromPtr__(IntPtr addr) { return new VideoCapture(addr); }

        //
        // C++:   cv::VideoCapture::VideoCapture(String filename, int apiPreference = CAP_ANY)
        //

        //javadoc: VideoCapture::VideoCapture(filename, apiPreference)
        public VideoCapture(string filename, int apiPreference)
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoCapture_VideoCapture_10(filename, apiPreference);
        
        return;
#else
            return null;
#endif
        }

        //javadoc: VideoCapture::VideoCapture(filename)
        public VideoCapture(string filename)
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoCapture_VideoCapture_11(filename);
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:   cv::VideoCapture::VideoCapture(int index, int apiPreference = CAP_ANY)
        //

        //javadoc: VideoCapture::VideoCapture(index, apiPreference)
        public VideoCapture(int index, int apiPreference)
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoCapture_VideoCapture_12(index, apiPreference);
        
        return;
#else
            return null;
#endif
        }

        //javadoc: VideoCapture::VideoCapture(index)
        public VideoCapture(int index)
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoCapture_VideoCapture_13(index);
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:   cv::VideoCapture::VideoCapture()
        //

        //javadoc: VideoCapture::VideoCapture()
        public VideoCapture()
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoCapture_VideoCapture_14();
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::VideoCapture::getBackendName()
        //

        //javadoc: VideoCapture::getBackendName()
        public string getBackendName()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (videoio_VideoCapture_getBackendName_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::VideoCapture::grab()
        //

        //javadoc: VideoCapture::grab()
        public bool grab()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_grab_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::VideoCapture::isOpened()
        //

        //javadoc: VideoCapture::isOpened()
        public bool isOpened()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_isOpened_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::VideoCapture::open(String filename, int apiPreference = CAP_ANY)
        //

        //javadoc: VideoCapture::open(filename, apiPreference)
        public bool open(string filename, int apiPreference)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_open_10(nativeObj, filename, apiPreference);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: VideoCapture::open(filename)
        public bool open(string filename)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_open_11(nativeObj, filename);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::VideoCapture::open(int index, int apiPreference = CAP_ANY)
        //

        //javadoc: VideoCapture::open(index, apiPreference)
        public bool open(int index, int apiPreference)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_open_12(nativeObj, index, apiPreference);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: VideoCapture::open(index)
        public bool open(int index)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_open_13(nativeObj, index);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::VideoCapture::read(Mat& image)
        //

        //javadoc: VideoCapture::read(image)
        public bool read(Mat image)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_read_10(nativeObj, image.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::VideoCapture::retrieve(Mat& image, int flag = 0)
        //

        //javadoc: VideoCapture::retrieve(image, flag)
        public bool retrieve(Mat image, int flag)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_retrieve_10(nativeObj, image.nativeObj, flag);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: VideoCapture::retrieve(image)
        public bool retrieve(Mat image)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_retrieve_11(nativeObj, image.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::VideoCapture::set(int propId, double value)
        //

        //javadoc: VideoCapture::set(propId, value)
        public bool set(int propId, double value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_set_10(nativeObj, propId, value);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  double cv::VideoCapture::get(int propId)
        //

        //javadoc: VideoCapture::get(propId)
        public double get(int propId)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = videoio_VideoCapture_get_10(nativeObj, propId);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::VideoCapture::release()
        //

        //javadoc: VideoCapture::release()
        public void release()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        videoio_VideoCapture_release_10(nativeObj);
        
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



        // C++:   cv::VideoCapture::VideoCapture(String filename, int apiPreference = CAP_ANY)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_10(string filename, int apiPreference);
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_11(string filename);

        // C++:   cv::VideoCapture::VideoCapture(int index, int apiPreference = CAP_ANY)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_12(int index, int apiPreference);
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_13(int index);

        // C++:   cv::VideoCapture::VideoCapture()
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_14();

        // C++:  String cv::VideoCapture::getBackendName()
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_getBackendName_10(IntPtr nativeObj);

        // C++:  bool cv::VideoCapture::grab()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_grab_10(IntPtr nativeObj);

        // C++:  bool cv::VideoCapture::isOpened()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_isOpened_10(IntPtr nativeObj);

        // C++:  bool cv::VideoCapture::open(String filename, int apiPreference = CAP_ANY)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_10(IntPtr nativeObj, string filename, int apiPreference);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_11(IntPtr nativeObj, string filename);

        // C++:  bool cv::VideoCapture::open(int index, int apiPreference = CAP_ANY)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_12(IntPtr nativeObj, int index, int apiPreference);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_13(IntPtr nativeObj, int index);

        // C++:  bool cv::VideoCapture::read(Mat& image)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_read_10(IntPtr nativeObj, IntPtr image_nativeObj);

        // C++:  bool cv::VideoCapture::retrieve(Mat& image, int flag = 0)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_retrieve_10(IntPtr nativeObj, IntPtr image_nativeObj, int flag);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_retrieve_11(IntPtr nativeObj, IntPtr image_nativeObj);

        // C++:  bool cv::VideoCapture::set(int propId, double value)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_set_10(IntPtr nativeObj, int propId, double value);

        // C++:  double cv::VideoCapture::get(int propId)
        [DllImport(LIBNAME)]
        private static extern double videoio_VideoCapture_get_10(IntPtr nativeObj, int propId);

        // C++:  void cv::VideoCapture::release()
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoCapture_release_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoCapture_delete(IntPtr nativeObj);

    }
}
