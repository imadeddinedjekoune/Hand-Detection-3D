

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.CoreModule
{
    // C++: class TickMeter
    //javadoc: TickMeter

    public class TickMeter : DisposableOpenCVObject
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
                        core_TickMeter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TickMeter(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static TickMeter __fromPtr__(IntPtr addr) { return new TickMeter(addr); }

        //
        // C++:   cv::TickMeter::TickMeter()
        //

        //javadoc: TickMeter::TickMeter()
        public TickMeter()
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = core_TickMeter_TickMeter_10();

        return;
#else
            return null;
#endif
        }


        //
        // C++:  double cv::TickMeter::getTimeMicro()
        //

        //javadoc: TickMeter::getTimeMicro()
        public double getTimeMicro()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = core_TickMeter_getTimeMicro_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::TickMeter::getTimeMilli()
        //

        //javadoc: TickMeter::getTimeMilli()
        public double getTimeMilli()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = core_TickMeter_getTimeMilli_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::TickMeter::getTimeSec()
        //

        //javadoc: TickMeter::getTimeSec()
        public double getTimeSec()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = core_TickMeter_getTimeSec_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int64 cv::TickMeter::getCounter()
        //

        //javadoc: TickMeter::getCounter()
        public long getCounter()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        long retVal = core_TickMeter_getCounter_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int64 cv::TickMeter::getTimeTicks()
        //

        //javadoc: TickMeter::getTimeTicks()
        public long getTimeTicks()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        long retVal = core_TickMeter_getTimeTicks_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::TickMeter::reset()
        //

        //javadoc: TickMeter::reset()
        public void reset()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        core_TickMeter_reset_10(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::TickMeter::start()
        //

        //javadoc: TickMeter::start()
        public void start()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        core_TickMeter_start_10(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::TickMeter::stop()
        //

        //javadoc: TickMeter::stop()
        public void stop()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        core_TickMeter_stop_10(nativeObj);
        
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



        // C++:   cv::TickMeter::TickMeter()
        [DllImport(LIBNAME)]
        private static extern IntPtr core_TickMeter_TickMeter_10();

        // C++:  double cv::TickMeter::getTimeMicro()
        [DllImport(LIBNAME)]
        private static extern double core_TickMeter_getTimeMicro_10(IntPtr nativeObj);

        // C++:  double cv::TickMeter::getTimeMilli()
        [DllImport(LIBNAME)]
        private static extern double core_TickMeter_getTimeMilli_10(IntPtr nativeObj);

        // C++:  double cv::TickMeter::getTimeSec()
        [DllImport(LIBNAME)]
        private static extern double core_TickMeter_getTimeSec_10(IntPtr nativeObj);

        // C++:  int64 cv::TickMeter::getCounter()
        [DllImport(LIBNAME)]
        private static extern long core_TickMeter_getCounter_10(IntPtr nativeObj);

        // C++:  int64 cv::TickMeter::getTimeTicks()
        [DllImport(LIBNAME)]
        private static extern long core_TickMeter_getTimeTicks_10(IntPtr nativeObj);

        // C++:  void cv::TickMeter::reset()
        [DllImport(LIBNAME)]
        private static extern void core_TickMeter_reset_10(IntPtr nativeObj);

        // C++:  void cv::TickMeter::start()
        [DllImport(LIBNAME)]
        private static extern void core_TickMeter_start_10(IntPtr nativeObj);

        // C++:  void cv::TickMeter::stop()
        [DllImport(LIBNAME)]
        private static extern void core_TickMeter_stop_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void core_TickMeter_delete(IntPtr nativeObj);

    }
}
