#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{
    // C++: class DictValue
    //javadoc: DictValue

    public class DictValue : DisposableOpenCVObject
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
                        dnn_DictValue_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DictValue(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static DictValue __fromPtr__(IntPtr addr) { return new DictValue(addr); }

        //
        // C++:   cv::dnn::DictValue::DictValue(String s)
        //

        //javadoc: DictValue::DictValue(s)
        public DictValue(string s)
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = dnn_DictValue_DictValue_10(s);
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:   cv::dnn::DictValue::DictValue(double p)
        //

        //javadoc: DictValue::DictValue(p)
        public DictValue(double p)
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = dnn_DictValue_DictValue_11(p);
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:   cv::dnn::DictValue::DictValue(int i)
        //

        //javadoc: DictValue::DictValue(i)
        public DictValue(int i)
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = dnn_DictValue_DictValue_12(i);
        
        return;
#else
            return null;
#endif
        }


        //
        // C++:  String cv::dnn::DictValue::getStringValue(int idx = -1)
        //

        //javadoc: DictValue::getStringValue(idx)
        public string getStringValue(int idx)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (dnn_DictValue_getStringValue_10(nativeObj, idx));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DictValue::getStringValue()
        public string getStringValue()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (dnn_DictValue_getStringValue_11(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::dnn::DictValue::isInt()
        //

        //javadoc: DictValue::isInt()
        public bool isInt()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = dnn_DictValue_isInt_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::dnn::DictValue::isReal()
        //

        //javadoc: DictValue::isReal()
        public bool isReal()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = dnn_DictValue_isReal_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::dnn::DictValue::isString()
        //

        //javadoc: DictValue::isString()
        public bool isString()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = dnn_DictValue_isString_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  double cv::dnn::DictValue::getRealValue(int idx = -1)
        //

        //javadoc: DictValue::getRealValue(idx)
        public double getRealValue(int idx)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = dnn_DictValue_getRealValue_10(nativeObj, idx);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: DictValue::getRealValue()
        public double getRealValue()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = dnn_DictValue_getRealValue_11(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::dnn::DictValue::getIntValue(int idx = -1)
        //

        //javadoc: DictValue::getIntValue(idx)
        public int getIntValue(int idx)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = dnn_DictValue_getIntValue_10(nativeObj, idx);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: DictValue::getIntValue()
        public int getIntValue()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = dnn_DictValue_getIntValue_11(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::dnn::DictValue::DictValue(String s)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DictValue_DictValue_10(string s);

        // C++:   cv::dnn::DictValue::DictValue(double p)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DictValue_DictValue_11(double p);

        // C++:   cv::dnn::DictValue::DictValue(int i)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DictValue_DictValue_12(int i);

        // C++:  String cv::dnn::DictValue::getStringValue(int idx = -1)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DictValue_getStringValue_10(IntPtr nativeObj, int idx);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DictValue_getStringValue_11(IntPtr nativeObj);

        // C++:  bool cv::dnn::DictValue::isInt()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool dnn_DictValue_isInt_10(IntPtr nativeObj);

        // C++:  bool cv::dnn::DictValue::isReal()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool dnn_DictValue_isReal_10(IntPtr nativeObj);

        // C++:  bool cv::dnn::DictValue::isString()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool dnn_DictValue_isString_10(IntPtr nativeObj);

        // C++:  double cv::dnn::DictValue::getRealValue(int idx = -1)
        [DllImport(LIBNAME)]
        private static extern double dnn_DictValue_getRealValue_10(IntPtr nativeObj, int idx);
        [DllImport(LIBNAME)]
        private static extern double dnn_DictValue_getRealValue_11(IntPtr nativeObj);

        // C++:  int cv::dnn::DictValue::getIntValue(int idx = -1)
        [DllImport(LIBNAME)]
        private static extern int dnn_DictValue_getIntValue_10(IntPtr nativeObj, int idx);
        [DllImport(LIBNAME)]
        private static extern int dnn_DictValue_getIntValue_11(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_DictValue_delete(IntPtr nativeObj);

    }
}
#endif