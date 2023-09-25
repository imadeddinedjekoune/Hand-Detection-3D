
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Calib3dModule
{

    // C++: class StereoSGBM
    //javadoc: StereoSGBM

    public class StereoSGBM : StereoMatcher
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
                        calib3d_StereoSGBM_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StereoSGBM(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StereoSGBM __fromPtr__(IntPtr addr) { return new StereoSGBM(addr); }

        // C++: enum <unnamed>
        public const int MODE_SGBM = 0;
        public const int MODE_HH = 1;
        public const int MODE_SGBM_3WAY = 2;
        public const int MODE_HH4 = 3;
        //
        // C++: static Ptr_StereoSGBM cv::StereoSGBM::create(int minDisparity = 0, int numDisparities = 16, int blockSize = 3, int P1 = 0, int P2 = 0, int disp12MaxDiff = 0, int preFilterCap = 0, int uniquenessRatio = 0, int speckleWindowSize = 0, int speckleRange = 0, int mode = StereoSGBM::MODE_SGBM)
        //

        //javadoc: StereoSGBM::create(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio, speckleWindowSize, speckleRange, mode)
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange, int mode)
        {
#if UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = StereoSGBM.__fromPtr__(calib3d_StereoSGBM_create_10(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio, speckleWindowSize, speckleRange, mode));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StereoSGBM::create(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio, speckleWindowSize, speckleRange)
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange)
        {
#if UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = StereoSGBM.__fromPtr__(calib3d_StereoSGBM_create_11(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio, speckleWindowSize, speckleRange));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StereoSGBM::create(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio, speckleWindowSize)
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize)
        {
#if UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = StereoSGBM.__fromPtr__(calib3d_StereoSGBM_create_12(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio, speckleWindowSize));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StereoSGBM::create(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio)
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio)
        {
#if UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = StereoSGBM.__fromPtr__(calib3d_StereoSGBM_create_13(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StereoSGBM::create(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap)
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap)
        {
#if UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = StereoSGBM.__fromPtr__(calib3d_StereoSGBM_create_14(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StereoSGBM::create(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff)
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff)
        {
#if UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = StereoSGBM.__fromPtr__(calib3d_StereoSGBM_create_15(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StereoSGBM::create(minDisparity, numDisparities, blockSize, P1, P2)
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1, int P2)
        {
#if UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = StereoSGBM.__fromPtr__(calib3d_StereoSGBM_create_16(minDisparity, numDisparities, blockSize, P1, P2));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StereoSGBM::create(minDisparity, numDisparities, blockSize, P1)
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize, int P1)
        {
#if UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = StereoSGBM.__fromPtr__(calib3d_StereoSGBM_create_17(minDisparity, numDisparities, blockSize, P1));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StereoSGBM::create(minDisparity, numDisparities, blockSize)
        public static StereoSGBM create(int minDisparity, int numDisparities, int blockSize)
        {
#if UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = StereoSGBM.__fromPtr__(calib3d_StereoSGBM_create_18(minDisparity, numDisparities, blockSize));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StereoSGBM::create(minDisparity, numDisparities)
        public static StereoSGBM create(int minDisparity, int numDisparities)
        {
#if UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = StereoSGBM.__fromPtr__(calib3d_StereoSGBM_create_19(minDisparity, numDisparities));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StereoSGBM::create(minDisparity)
        public static StereoSGBM create(int minDisparity)
        {
#if UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = StereoSGBM.__fromPtr__(calib3d_StereoSGBM_create_110(minDisparity));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StereoSGBM::create()
        public static StereoSGBM create()
        {
#if UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = StereoSGBM.__fromPtr__(calib3d_StereoSGBM_create_111());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  int cv::StereoSGBM::getMode()
        //

        //javadoc: StereoSGBM::getMode()
        public int getMode()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoSGBM_getMode_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::StereoSGBM::getP1()
        //

        //javadoc: StereoSGBM::getP1()
        public int getP1()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoSGBM_getP1_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::StereoSGBM::getP2()
        //

        //javadoc: StereoSGBM::getP2()
        public int getP2()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoSGBM_getP2_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::StereoSGBM::getPreFilterCap()
        //

        //javadoc: StereoSGBM::getPreFilterCap()
        public int getPreFilterCap()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoSGBM_getPreFilterCap_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::StereoSGBM::getUniquenessRatio()
        //

        //javadoc: StereoSGBM::getUniquenessRatio()
        public int getUniquenessRatio()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoSGBM_getUniquenessRatio_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::StereoSGBM::setMode(int mode)
        //

        //javadoc: StereoSGBM::setMode(mode)
        public void setMode(int mode)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_StereoSGBM_setMode_10(nativeObj, mode);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::StereoSGBM::setP1(int P1)
        //

        //javadoc: StereoSGBM::setP1(P1)
        public void setP1(int P1)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_StereoSGBM_setP1_10(nativeObj, P1);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::StereoSGBM::setP2(int P2)
        //

        //javadoc: StereoSGBM::setP2(P2)
        public void setP2(int P2)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_StereoSGBM_setP2_10(nativeObj, P2);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::StereoSGBM::setPreFilterCap(int preFilterCap)
        //

        //javadoc: StereoSGBM::setPreFilterCap(preFilterCap)
        public void setPreFilterCap(int preFilterCap)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_StereoSGBM_setPreFilterCap_10(nativeObj, preFilterCap);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::StereoSGBM::setUniquenessRatio(int uniquenessRatio)
        //

        //javadoc: StereoSGBM::setUniquenessRatio(uniquenessRatio)
        public void setUniquenessRatio(int uniquenessRatio)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        calib3d_StereoSGBM_setUniquenessRatio_10(nativeObj, uniquenessRatio);
        
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



        // C++: static Ptr_StereoSGBM cv::StereoSGBM::create(int minDisparity = 0, int numDisparities = 16, int blockSize = 3, int P1 = 0, int P2 = 0, int disp12MaxDiff = 0, int preFilterCap = 0, int uniquenessRatio = 0, int speckleWindowSize = 0, int speckleRange = 0, int mode = StereoSGBM::MODE_SGBM)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_10(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange, int mode);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_11(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_12(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_13(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_14(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_15(int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_16(int minDisparity, int numDisparities, int blockSize, int P1, int P2);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_17(int minDisparity, int numDisparities, int blockSize, int P1);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_18(int minDisparity, int numDisparities, int blockSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_19(int minDisparity, int numDisparities);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_110(int minDisparity);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_111();

        // C++:  int cv::StereoSGBM::getMode()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoSGBM_getMode_10(IntPtr nativeObj);

        // C++:  int cv::StereoSGBM::getP1()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoSGBM_getP1_10(IntPtr nativeObj);

        // C++:  int cv::StereoSGBM::getP2()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoSGBM_getP2_10(IntPtr nativeObj);

        // C++:  int cv::StereoSGBM::getPreFilterCap()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoSGBM_getPreFilterCap_10(IntPtr nativeObj);

        // C++:  int cv::StereoSGBM::getUniquenessRatio()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoSGBM_getUniquenessRatio_10(IntPtr nativeObj);

        // C++:  void cv::StereoSGBM::setMode(int mode)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoSGBM_setMode_10(IntPtr nativeObj, int mode);

        // C++:  void cv::StereoSGBM::setP1(int P1)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoSGBM_setP1_10(IntPtr nativeObj, int P1);

        // C++:  void cv::StereoSGBM::setP2(int P2)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoSGBM_setP2_10(IntPtr nativeObj, int P2);

        // C++:  void cv::StereoSGBM::setPreFilterCap(int preFilterCap)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoSGBM_setPreFilterCap_10(IntPtr nativeObj, int preFilterCap);

        // C++:  void cv::StereoSGBM::setUniquenessRatio(int uniquenessRatio)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoSGBM_setUniquenessRatio_10(IntPtr nativeObj, int uniquenessRatio);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoSGBM_delete(IntPtr nativeObj);

    }
}
