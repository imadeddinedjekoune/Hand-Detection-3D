
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class Boost
    //javadoc: Boost

    public class Boost : DTrees
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
                        ml_Boost_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Boost(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new Boost __fromPtr__(IntPtr addr) { return new Boost(addr); }

        // C++: enum Types
        public const int DISCRETE = 0;
        public const int REAL = 1;
        public const int LOGIT = 2;
        public const int GENTLE = 3;
        //
        // C++: static Ptr_Boost cv::ml::Boost::create()
        //

        //javadoc: Boost::create()
        public static new Boost create()
        {
#if UNITY_5_3_OR_NEWER
        
        Boost retVal = Boost.__fromPtr__(ml_Boost_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_Boost cv::ml::Boost::load(String filepath, String nodeName = String())
        //

        //javadoc: Boost::load(filepath, nodeName)
        public static new Boost load(string filepath, string nodeName)
        {
#if UNITY_5_3_OR_NEWER
        
        Boost retVal = Boost.__fromPtr__(ml_Boost_load_10(filepath, nodeName));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: Boost::load(filepath)
        public static new Boost load(string filepath)
        {
#if UNITY_5_3_OR_NEWER
        
        Boost retVal = Boost.__fromPtr__(ml_Boost_load_11(filepath));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  double cv::ml::Boost::getWeightTrimRate()
        //

        //javadoc: Boost::getWeightTrimRate()
        public double getWeightTrimRate()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        double retVal = ml_Boost_getWeightTrimRate_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::Boost::getBoostType()
        //

        //javadoc: Boost::getBoostType()
        public int getBoostType()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_Boost_getBoostType_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::ml::Boost::getWeakCount()
        //

        //javadoc: Boost::getWeakCount()
        public int getWeakCount()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = ml_Boost_getWeakCount_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ml::Boost::setBoostType(int val)
        //

        //javadoc: Boost::setBoostType(val)
        public void setBoostType(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_Boost_setBoostType_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::Boost::setWeakCount(int val)
        //

        //javadoc: Boost::setWeakCount(val)
        public void setWeakCount(int val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_Boost_setWeakCount_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ml::Boost::setWeightTrimRate(double val)
        //

        //javadoc: Boost::setWeightTrimRate(val)
        public void setWeightTrimRate(double val)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        ml_Boost_setWeightTrimRate_10(nativeObj, val);
        
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



        // C++: static Ptr_Boost cv::ml::Boost::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_Boost_create_10();

        // C++: static Ptr_Boost cv::ml::Boost::load(String filepath, String nodeName = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_Boost_load_10(string filepath, string nodeName);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_Boost_load_11(string filepath);

        // C++:  double cv::ml::Boost::getWeightTrimRate()
        [DllImport(LIBNAME)]
        private static extern double ml_Boost_getWeightTrimRate_10(IntPtr nativeObj);

        // C++:  int cv::ml::Boost::getBoostType()
        [DllImport(LIBNAME)]
        private static extern int ml_Boost_getBoostType_10(IntPtr nativeObj);

        // C++:  int cv::ml::Boost::getWeakCount()
        [DllImport(LIBNAME)]
        private static extern int ml_Boost_getWeakCount_10(IntPtr nativeObj);

        // C++:  void cv::ml::Boost::setBoostType(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_Boost_setBoostType_10(IntPtr nativeObj, int val);

        // C++:  void cv::ml::Boost::setWeakCount(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_Boost_setWeakCount_10(IntPtr nativeObj, int val);

        // C++:  void cv::ml::Boost::setWeightTrimRate(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_Boost_setWeightTrimRate_10(IntPtr nativeObj, double val);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_Boost_delete(IntPtr nativeObj);

    }
}
