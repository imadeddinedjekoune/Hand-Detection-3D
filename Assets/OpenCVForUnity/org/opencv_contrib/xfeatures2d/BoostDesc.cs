
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using OpenCVForUnity.Features2dModule;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class BoostDesc
    //javadoc: BoostDesc

    public class BoostDesc : Feature2D
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
                        xfeatures2d_BoostDesc_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BoostDesc(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BoostDesc __fromPtr__(IntPtr addr) { return new BoostDesc(addr); }

        //
        // C++: static Ptr_BoostDesc cv::xfeatures2d::BoostDesc::create(int desc = BoostDesc::BINBOOST_256, bool use_scale_orientation = true, float scale_factor = 6.25f)
        //

        //javadoc: BoostDesc::create(desc, use_scale_orientation, scale_factor)
        public static BoostDesc create(int desc, bool use_scale_orientation, float scale_factor)
        {
#if UNITY_5_3_OR_NEWER
        
        BoostDesc retVal = BoostDesc.__fromPtr__(xfeatures2d_BoostDesc_create_10(desc, use_scale_orientation, scale_factor));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BoostDesc::create(desc, use_scale_orientation)
        public static BoostDesc create(int desc, bool use_scale_orientation)
        {
#if UNITY_5_3_OR_NEWER
        
        BoostDesc retVal = BoostDesc.__fromPtr__(xfeatures2d_BoostDesc_create_11(desc, use_scale_orientation));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BoostDesc::create(desc)
        public static BoostDesc create(int desc)
        {
#if UNITY_5_3_OR_NEWER
        
        BoostDesc retVal = BoostDesc.__fromPtr__(xfeatures2d_BoostDesc_create_12(desc));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BoostDesc::create()
        public static BoostDesc create()
        {
#if UNITY_5_3_OR_NEWER
        
        BoostDesc retVal = BoostDesc.__fromPtr__(xfeatures2d_BoostDesc_create_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::xfeatures2d::BoostDesc::getUseScaleOrientation()
        //

        //javadoc: BoostDesc::getUseScaleOrientation()
        public bool getUseScaleOrientation()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = xfeatures2d_BoostDesc_getUseScaleOrientation_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  float cv::xfeatures2d::BoostDesc::getScaleFactor()
        //

        //javadoc: BoostDesc::getScaleFactor()
        public float getScaleFactor()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_BoostDesc_getScaleFactor_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::BoostDesc::setScaleFactor(float scale_factor)
        //

        //javadoc: BoostDesc::setScaleFactor(scale_factor)
        public void setScaleFactor(float scale_factor)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_BoostDesc_setScaleFactor_10(nativeObj, scale_factor);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::BoostDesc::setUseScaleOrientation(bool use_scale_orientation)
        //

        //javadoc: BoostDesc::setUseScaleOrientation(use_scale_orientation)
        public void setUseScaleOrientation(bool use_scale_orientation)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_BoostDesc_setUseScaleOrientation_10(nativeObj, use_scale_orientation);
        
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



        // C++: static Ptr_BoostDesc cv::xfeatures2d::BoostDesc::create(int desc = BoostDesc::BINBOOST_256, bool use_scale_orientation = true, float scale_factor = 6.25f)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BoostDesc_create_10(int desc, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation, float scale_factor);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BoostDesc_create_11(int desc, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BoostDesc_create_12(int desc);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BoostDesc_create_13();

        // C++:  bool cv::xfeatures2d::BoostDesc::getUseScaleOrientation()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool xfeatures2d_BoostDesc_getUseScaleOrientation_10(IntPtr nativeObj);

        // C++:  float cv::xfeatures2d::BoostDesc::getScaleFactor()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_BoostDesc_getScaleFactor_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::BoostDesc::setScaleFactor(float scale_factor)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_BoostDesc_setScaleFactor_10(IntPtr nativeObj, float scale_factor);

        // C++:  void cv::xfeatures2d::BoostDesc::setUseScaleOrientation(bool use_scale_orientation)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_BoostDesc_setUseScaleOrientation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_BoostDesc_delete(IntPtr nativeObj);

    }
}
