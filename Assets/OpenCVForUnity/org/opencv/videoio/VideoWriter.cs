

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoioModule
{
    // C++: class VideoWriter
    //javadoc: VideoWriter

    public class VideoWriter : DisposableOpenCVObject
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
                        videoio_VideoWriter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal VideoWriter(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static VideoWriter __fromPtr__(IntPtr addr) { return new VideoWriter(addr); }

        //
        // C++:   cv::VideoWriter::VideoWriter(String filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor = true)
        //

        //javadoc: VideoWriter::VideoWriter(filename, apiPreference, fourcc, fps, frameSize, isColor)
        public VideoWriter(string filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor)
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoWriter_VideoWriter_10(filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height, isColor);
        
        return;
#else
            return null;
#endif
        }

        //javadoc: VideoWriter::VideoWriter(filename, apiPreference, fourcc, fps, frameSize)
        public VideoWriter(string filename, int apiPreference, int fourcc, double fps, Size frameSize)
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoWriter_VideoWriter_11(filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height);
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:   cv::VideoWriter::VideoWriter(String filename, int fourcc, double fps, Size frameSize, bool isColor = true)
        //

        //javadoc: VideoWriter::VideoWriter(filename, fourcc, fps, frameSize, isColor)
        public VideoWriter(string filename, int fourcc, double fps, Size frameSize, bool isColor)
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoWriter_VideoWriter_12(filename, fourcc, fps, frameSize.width, frameSize.height, isColor);
        
        return;
#else
            return null;
#endif
        }

        //javadoc: VideoWriter::VideoWriter(filename, fourcc, fps, frameSize)
        public VideoWriter(string filename, int fourcc, double fps, Size frameSize)
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoWriter_VideoWriter_13(filename, fourcc, fps, frameSize.width, frameSize.height);
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:   cv::VideoWriter::VideoWriter()
        //

        //javadoc: VideoWriter::VideoWriter()
        public VideoWriter()
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoWriter_VideoWriter_14();
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::VideoWriter::getBackendName()
        //

        //javadoc: VideoWriter::getBackendName()
        public string getBackendName()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (videoio_VideoWriter_getBackendName_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::VideoWriter::isOpened()
        //

        //javadoc: VideoWriter::isOpened()
        public bool isOpened()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoWriter_isOpened_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::VideoWriter::open(String filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor = true)
        //

        //javadoc: VideoWriter::open(filename, apiPreference, fourcc, fps, frameSize, isColor)
        public bool open(string filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoWriter_open_10(nativeObj, filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height, isColor);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: VideoWriter::open(filename, apiPreference, fourcc, fps, frameSize)
        public bool open(string filename, int apiPreference, int fourcc, double fps, Size frameSize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoWriter_open_11(nativeObj, filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::VideoWriter::open(String filename, int fourcc, double fps, Size frameSize, bool isColor = true)
        //

        //javadoc: VideoWriter::open(filename, fourcc, fps, frameSize, isColor)
        public bool open(string filename, int fourcc, double fps, Size frameSize, bool isColor)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoWriter_open_12(nativeObj, filename, fourcc, fps, frameSize.width, frameSize.height, isColor);
        
        return retVal;
#else
            return false;
#endif
        }

        //javadoc: VideoWriter::open(filename, fourcc, fps, frameSize)
        public bool open(string filename, int fourcc, double fps, Size frameSize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoWriter_open_13(nativeObj, filename, fourcc, fps, frameSize.width, frameSize.height);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::VideoWriter::set(int propId, double value)
        //

        //javadoc: VideoWriter::set(propId, value)
        public bool set(int propId, double value)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoWriter_set_10(nativeObj, propId, value);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  double cv::VideoWriter::get(int propId)
        //

        //javadoc: VideoWriter::get(propId)
        public double get(int propId)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = videoio_VideoWriter_get_10(nativeObj, propId);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: static int cv::VideoWriter::fourcc(char c1, char c2, char c3, char c4)
        //

        //javadoc: VideoWriter::fourcc(c1, c2, c3, c4)
        public static int fourcc(char c1, char c2, char c3, char c4)
        {
#if UNITY_5_3_OR_NEWER
        
        int retVal = videoio_VideoWriter_fourcc_10(c1, c2, c3, c4);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::VideoWriter::release()
        //

        //javadoc: VideoWriter::release()
        public void release()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        videoio_VideoWriter_release_10(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::VideoWriter::write(Mat image)
        //

        //javadoc: VideoWriter::write(image)
        public void write(Mat image)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        videoio_VideoWriter_write_10(nativeObj, image.nativeObj);
        
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



        // C++:   cv::VideoWriter::VideoWriter(String filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_10(string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height, [MarshalAs(UnmanagedType.U1)] bool isColor);
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_11(string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height);

        // C++:   cv::VideoWriter::VideoWriter(String filename, int fourcc, double fps, Size frameSize, bool isColor = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_12(string filename, int fourcc, double fps, double frameSize_width, double frameSize_height, [MarshalAs(UnmanagedType.U1)] bool isColor);
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_13(string filename, int fourcc, double fps, double frameSize_width, double frameSize_height);

        // C++:   cv::VideoWriter::VideoWriter()
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_14();

        // C++:  String cv::VideoWriter::getBackendName()
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_getBackendName_10(IntPtr nativeObj);

        // C++:  bool cv::VideoWriter::isOpened()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_isOpened_10(IntPtr nativeObj);

        // C++:  bool cv::VideoWriter::open(String filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor = true)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_open_10(IntPtr nativeObj, string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height, [MarshalAs(UnmanagedType.U1)] bool isColor);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_open_11(IntPtr nativeObj, string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height);

        // C++:  bool cv::VideoWriter::open(String filename, int fourcc, double fps, Size frameSize, bool isColor = true)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_open_12(IntPtr nativeObj, string filename, int fourcc, double fps, double frameSize_width, double frameSize_height, [MarshalAs(UnmanagedType.U1)] bool isColor);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_open_13(IntPtr nativeObj, string filename, int fourcc, double fps, double frameSize_width, double frameSize_height);

        // C++:  bool cv::VideoWriter::set(int propId, double value)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoWriter_set_10(IntPtr nativeObj, int propId, double value);

        // C++:  double cv::VideoWriter::get(int propId)
        [DllImport(LIBNAME)]
        private static extern double videoio_VideoWriter_get_10(IntPtr nativeObj, int propId);

        // C++: static int cv::VideoWriter::fourcc(char c1, char c2, char c3, char c4)
        [DllImport(LIBNAME)]
        private static extern int videoio_VideoWriter_fourcc_10(char c1, char c2, char c3, char c4);

        // C++:  void cv::VideoWriter::release()
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoWriter_release_10(IntPtr nativeObj);

        // C++:  void cv::VideoWriter::write(Mat image)
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoWriter_write_10(IntPtr nativeObj, IntPtr image_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoWriter_delete(IntPtr nativeObj);

    }
}
