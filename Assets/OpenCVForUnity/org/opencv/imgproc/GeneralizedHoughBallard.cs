
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ImgprocModule
{

    // C++: class GeneralizedHoughBallard
    //javadoc: GeneralizedHoughBallard

    public class GeneralizedHoughBallard : GeneralizedHough
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
                        imgproc_GeneralizedHoughBallard_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GeneralizedHoughBallard(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GeneralizedHoughBallard __fromPtr__(IntPtr addr) { return new GeneralizedHoughBallard(addr); }

        //
        // C++:  int cv::GeneralizedHoughBallard::getLevels()
        //

        //javadoc: GeneralizedHoughBallard::getLevels()
        public int getLevels()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_GeneralizedHoughBallard_getLevels_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::GeneralizedHoughBallard::getVotesThreshold()
        //

        //javadoc: GeneralizedHoughBallard::getVotesThreshold()
        public int getVotesThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        int retVal = imgproc_GeneralizedHoughBallard_getVotesThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::GeneralizedHoughBallard::setLevels(int levels)
        //

        //javadoc: GeneralizedHoughBallard::setLevels(levels)
        public void setLevels(int levels)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHoughBallard_setLevels_10(nativeObj, levels);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::GeneralizedHoughBallard::setVotesThreshold(int votesThreshold)
        //

        //javadoc: GeneralizedHoughBallard::setVotesThreshold(votesThreshold)
        public void setVotesThreshold(int votesThreshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        imgproc_GeneralizedHoughBallard_setVotesThreshold_10(nativeObj, votesThreshold);
        
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



        // C++:  int cv::GeneralizedHoughBallard::getLevels()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHoughBallard_getLevels_10(IntPtr nativeObj);

        // C++:  int cv::GeneralizedHoughBallard::getVotesThreshold()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHoughBallard_getVotesThreshold_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHoughBallard::setLevels(int levels)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughBallard_setLevels_10(IntPtr nativeObj, int levels);

        // C++:  void cv::GeneralizedHoughBallard::setVotesThreshold(int votesThreshold)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughBallard_setVotesThreshold_10(IntPtr nativeObj, int votesThreshold);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHoughBallard_delete(IntPtr nativeObj);

    }
}
