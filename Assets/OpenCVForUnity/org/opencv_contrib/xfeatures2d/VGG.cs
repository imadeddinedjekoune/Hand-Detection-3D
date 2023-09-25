
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using OpenCVForUnity.Features2dModule;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class VGG
    //javadoc: VGG

    public class VGG : Feature2D
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
                        xfeatures2d_VGG_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal VGG(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new VGG __fromPtr__(IntPtr addr) { return new VGG(addr); }

        //
        // C++: static Ptr_VGG cv::xfeatures2d::VGG::create(int desc = VGG::VGG_120, float isigma = 1.4f, bool img_normalize = true, bool use_scale_orientation = true, float scale_factor = 6.25f, bool dsc_normalize = false)
        //

        //javadoc: VGG::create(desc, isigma, img_normalize, use_scale_orientation, scale_factor, dsc_normalize)
        public static VGG create(int desc, float isigma, bool img_normalize, bool use_scale_orientation, float scale_factor, bool dsc_normalize)
        {
#if UNITY_5_3_OR_NEWER
        
        VGG retVal = VGG.__fromPtr__(xfeatures2d_VGG_create_10(desc, isigma, img_normalize, use_scale_orientation, scale_factor, dsc_normalize));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: VGG::create(desc, isigma, img_normalize, use_scale_orientation, scale_factor)
        public static VGG create(int desc, float isigma, bool img_normalize, bool use_scale_orientation, float scale_factor)
        {
#if UNITY_5_3_OR_NEWER
        
        VGG retVal = VGG.__fromPtr__(xfeatures2d_VGG_create_11(desc, isigma, img_normalize, use_scale_orientation, scale_factor));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: VGG::create(desc, isigma, img_normalize, use_scale_orientation)
        public static VGG create(int desc, float isigma, bool img_normalize, bool use_scale_orientation)
        {
#if UNITY_5_3_OR_NEWER
        
        VGG retVal = VGG.__fromPtr__(xfeatures2d_VGG_create_12(desc, isigma, img_normalize, use_scale_orientation));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: VGG::create(desc, isigma, img_normalize)
        public static VGG create(int desc, float isigma, bool img_normalize)
        {
#if UNITY_5_3_OR_NEWER
        
        VGG retVal = VGG.__fromPtr__(xfeatures2d_VGG_create_13(desc, isigma, img_normalize));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: VGG::create(desc, isigma)
        public static VGG create(int desc, float isigma)
        {
#if UNITY_5_3_OR_NEWER
        
        VGG retVal = VGG.__fromPtr__(xfeatures2d_VGG_create_14(desc, isigma));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: VGG::create(desc)
        public static VGG create(int desc)
        {
#if UNITY_5_3_OR_NEWER
        
        VGG retVal = VGG.__fromPtr__(xfeatures2d_VGG_create_15(desc));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: VGG::create()
        public static VGG create()
        {
#if UNITY_5_3_OR_NEWER
        
        VGG retVal = VGG.__fromPtr__(xfeatures2d_VGG_create_16());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::xfeatures2d::VGG::getUseNormalizeDescriptor()
        //

        //javadoc: VGG::getUseNormalizeDescriptor()
        public bool getUseNormalizeDescriptor()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = xfeatures2d_VGG_getUseNormalizeDescriptor_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::xfeatures2d::VGG::getUseNormalizeImage()
        //

        //javadoc: VGG::getUseNormalizeImage()
        public bool getUseNormalizeImage()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = xfeatures2d_VGG_getUseNormalizeImage_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::xfeatures2d::VGG::getUseScaleOrientation()
        //

        //javadoc: VGG::getUseScaleOrientation()
        public bool getUseScaleOrientation()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = xfeatures2d_VGG_getUseScaleOrientation_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  float cv::xfeatures2d::VGG::getScaleFactor()
        //

        //javadoc: VGG::getScaleFactor()
        public float getScaleFactor()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_VGG_getScaleFactor_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::xfeatures2d::VGG::getSigma()
        //

        //javadoc: VGG::getSigma()
        public float getSigma()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_VGG_getSigma_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::VGG::setScaleFactor(float scale_factor)
        //

        //javadoc: VGG::setScaleFactor(scale_factor)
        public void setScaleFactor(float scale_factor)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_VGG_setScaleFactor_10(nativeObj, scale_factor);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::VGG::setSigma(float isigma)
        //

        //javadoc: VGG::setSigma(isigma)
        public void setSigma(float isigma)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_VGG_setSigma_10(nativeObj, isigma);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::VGG::setUseNormalizeDescriptor(bool dsc_normalize)
        //

        //javadoc: VGG::setUseNormalizeDescriptor(dsc_normalize)
        public void setUseNormalizeDescriptor(bool dsc_normalize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_VGG_setUseNormalizeDescriptor_10(nativeObj, dsc_normalize);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::VGG::setUseNormalizeImage(bool img_normalize)
        //

        //javadoc: VGG::setUseNormalizeImage(img_normalize)
        public void setUseNormalizeImage(bool img_normalize)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_VGG_setUseNormalizeImage_10(nativeObj, img_normalize);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::xfeatures2d::VGG::setUseScaleOrientation(bool use_scale_orientation)
        //

        //javadoc: VGG::setUseScaleOrientation(use_scale_orientation)
        public void setUseScaleOrientation(bool use_scale_orientation)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        xfeatures2d_VGG_setUseScaleOrientation_10(nativeObj, use_scale_orientation);
        
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



        // C++: static Ptr_VGG cv::xfeatures2d::VGG::create(int desc = VGG::VGG_120, float isigma = 1.4f, bool img_normalize = true, bool use_scale_orientation = true, float scale_factor = 6.25f, bool dsc_normalize = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_10(int desc, float isigma, [MarshalAs(UnmanagedType.U1)] bool img_normalize, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation, float scale_factor, [MarshalAs(UnmanagedType.U1)] bool dsc_normalize);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_11(int desc, float isigma, [MarshalAs(UnmanagedType.U1)] bool img_normalize, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation, float scale_factor);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_12(int desc, float isigma, [MarshalAs(UnmanagedType.U1)] bool img_normalize, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_13(int desc, float isigma, [MarshalAs(UnmanagedType.U1)] bool img_normalize);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_14(int desc, float isigma);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_15(int desc);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_16();

        // C++:  bool cv::xfeatures2d::VGG::getUseNormalizeDescriptor()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool xfeatures2d_VGG_getUseNormalizeDescriptor_10(IntPtr nativeObj);

        // C++:  bool cv::xfeatures2d::VGG::getUseNormalizeImage()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool xfeatures2d_VGG_getUseNormalizeImage_10(IntPtr nativeObj);

        // C++:  bool cv::xfeatures2d::VGG::getUseScaleOrientation()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool xfeatures2d_VGG_getUseScaleOrientation_10(IntPtr nativeObj);

        // C++:  float cv::xfeatures2d::VGG::getScaleFactor()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_VGG_getScaleFactor_10(IntPtr nativeObj);

        // C++:  float cv::xfeatures2d::VGG::getSigma()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_VGG_getSigma_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::VGG::setScaleFactor(float scale_factor)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_VGG_setScaleFactor_10(IntPtr nativeObj, float scale_factor);

        // C++:  void cv::xfeatures2d::VGG::setSigma(float isigma)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_VGG_setSigma_10(IntPtr nativeObj, float isigma);

        // C++:  void cv::xfeatures2d::VGG::setUseNormalizeDescriptor(bool dsc_normalize)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_VGG_setUseNormalizeDescriptor_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool dsc_normalize);

        // C++:  void cv::xfeatures2d::VGG::setUseNormalizeImage(bool img_normalize)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_VGG_setUseNormalizeImage_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool img_normalize);

        // C++:  void cv::xfeatures2d::VGG::setUseScaleOrientation(bool use_scale_orientation)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_VGG_setUseScaleOrientation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_VGG_delete(IntPtr nativeObj);

    }
}
