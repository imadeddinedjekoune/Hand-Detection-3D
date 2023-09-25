

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{
    // C++: class Params
    //javadoc: Params

    public class Params : DisposableOpenCVObject
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
                        features2d_Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static Params __fromPtr__(IntPtr addr) { return new Params(addr); }

        //
        // C++:   cv::SimpleBlobDetector::Params::Params()
        //

        //javadoc: Params::Params()
        public Params()
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = features2d_Params_Params_10();
        
        return;
#else
            return null;
#endif
        }


        //
        // C++: float Params::thresholdStep
        //

        //javadoc: Params::get_thresholdStep()
        public float get_thresholdStep()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = features2d_Params_get_1thresholdStep_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Params::thresholdStep
        //

        //javadoc: Params::set_thresholdStep(thresholdStep)
        public void set_thresholdStep(float thresholdStep)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1thresholdStep_10(nativeObj, thresholdStep);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: float Params::minThreshold
        //

        //javadoc: Params::get_minThreshold()
        public float get_minThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = features2d_Params_get_1minThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Params::minThreshold
        //

        //javadoc: Params::set_minThreshold(minThreshold)
        public void set_minThreshold(float minThreshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1minThreshold_10(nativeObj, minThreshold);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: float Params::maxThreshold
        //

        //javadoc: Params::get_maxThreshold()
        public float get_maxThreshold()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = features2d_Params_get_1maxThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Params::maxThreshold
        //

        //javadoc: Params::set_maxThreshold(maxThreshold)
        public void set_maxThreshold(float maxThreshold)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1maxThreshold_10(nativeObj, maxThreshold);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: size_t Params::minRepeatability
        //

        //javadoc: Params::get_minRepeatability()
        public long get_minRepeatability()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        long retVal = features2d_Params_get_1minRepeatability_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Params::minRepeatability
        //

        //javadoc: Params::set_minRepeatability(minRepeatability)
        public void set_minRepeatability(long minRepeatability)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1minRepeatability_10(nativeObj, minRepeatability);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: float Params::minDistBetweenBlobs
        //

        //javadoc: Params::get_minDistBetweenBlobs()
        public float get_minDistBetweenBlobs()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = features2d_Params_get_1minDistBetweenBlobs_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Params::minDistBetweenBlobs
        //

        //javadoc: Params::set_minDistBetweenBlobs(minDistBetweenBlobs)
        public void set_minDistBetweenBlobs(float minDistBetweenBlobs)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1minDistBetweenBlobs_10(nativeObj, minDistBetweenBlobs);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: bool Params::filterByColor
        //

        //javadoc: Params::get_filterByColor()
        public bool get_filterByColor()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = features2d_Params_get_1filterByColor_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++: void Params::filterByColor
        //

        //javadoc: Params::set_filterByColor(filterByColor)
        public void set_filterByColor(bool filterByColor)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1filterByColor_10(nativeObj, filterByColor);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: uchar Params::blobColor
        //

        // Return type 'uchar' is not supported, skipping the function


        //
        // C++: void Params::blobColor
        //

        // Unknown type 'uchar' (I), skipping the function


        //
        // C++: bool Params::filterByArea
        //

        //javadoc: Params::get_filterByArea()
        public bool get_filterByArea()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = features2d_Params_get_1filterByArea_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++: void Params::filterByArea
        //

        //javadoc: Params::set_filterByArea(filterByArea)
        public void set_filterByArea(bool filterByArea)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1filterByArea_10(nativeObj, filterByArea);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: float Params::minArea
        //

        //javadoc: Params::get_minArea()
        public float get_minArea()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = features2d_Params_get_1minArea_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Params::minArea
        //

        //javadoc: Params::set_minArea(minArea)
        public void set_minArea(float minArea)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1minArea_10(nativeObj, minArea);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: float Params::maxArea
        //

        //javadoc: Params::get_maxArea()
        public float get_maxArea()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = features2d_Params_get_1maxArea_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Params::maxArea
        //

        //javadoc: Params::set_maxArea(maxArea)
        public void set_maxArea(float maxArea)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1maxArea_10(nativeObj, maxArea);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: bool Params::filterByCircularity
        //

        //javadoc: Params::get_filterByCircularity()
        public bool get_filterByCircularity()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = features2d_Params_get_1filterByCircularity_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++: void Params::filterByCircularity
        //

        //javadoc: Params::set_filterByCircularity(filterByCircularity)
        public void set_filterByCircularity(bool filterByCircularity)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1filterByCircularity_10(nativeObj, filterByCircularity);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: float Params::minCircularity
        //

        //javadoc: Params::get_minCircularity()
        public float get_minCircularity()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = features2d_Params_get_1minCircularity_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Params::minCircularity
        //

        //javadoc: Params::set_minCircularity(minCircularity)
        public void set_minCircularity(float minCircularity)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1minCircularity_10(nativeObj, minCircularity);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: float Params::maxCircularity
        //

        //javadoc: Params::get_maxCircularity()
        public float get_maxCircularity()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = features2d_Params_get_1maxCircularity_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Params::maxCircularity
        //

        //javadoc: Params::set_maxCircularity(maxCircularity)
        public void set_maxCircularity(float maxCircularity)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1maxCircularity_10(nativeObj, maxCircularity);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: bool Params::filterByInertia
        //

        //javadoc: Params::get_filterByInertia()
        public bool get_filterByInertia()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = features2d_Params_get_1filterByInertia_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++: void Params::filterByInertia
        //

        //javadoc: Params::set_filterByInertia(filterByInertia)
        public void set_filterByInertia(bool filterByInertia)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1filterByInertia_10(nativeObj, filterByInertia);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: float Params::minInertiaRatio
        //

        //javadoc: Params::get_minInertiaRatio()
        public float get_minInertiaRatio()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = features2d_Params_get_1minInertiaRatio_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Params::minInertiaRatio
        //

        //javadoc: Params::set_minInertiaRatio(minInertiaRatio)
        public void set_minInertiaRatio(float minInertiaRatio)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1minInertiaRatio_10(nativeObj, minInertiaRatio);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: float Params::maxInertiaRatio
        //

        //javadoc: Params::get_maxInertiaRatio()
        public float get_maxInertiaRatio()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = features2d_Params_get_1maxInertiaRatio_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Params::maxInertiaRatio
        //

        //javadoc: Params::set_maxInertiaRatio(maxInertiaRatio)
        public void set_maxInertiaRatio(float maxInertiaRatio)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1maxInertiaRatio_10(nativeObj, maxInertiaRatio);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: bool Params::filterByConvexity
        //

        //javadoc: Params::get_filterByConvexity()
        public bool get_filterByConvexity()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = features2d_Params_get_1filterByConvexity_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++: void Params::filterByConvexity
        //

        //javadoc: Params::set_filterByConvexity(filterByConvexity)
        public void set_filterByConvexity(bool filterByConvexity)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1filterByConvexity_10(nativeObj, filterByConvexity);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: float Params::minConvexity
        //

        //javadoc: Params::get_minConvexity()
        public float get_minConvexity()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = features2d_Params_get_1minConvexity_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Params::minConvexity
        //

        //javadoc: Params::set_minConvexity(minConvexity)
        public void set_minConvexity(float minConvexity)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1minConvexity_10(nativeObj, minConvexity);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: float Params::maxConvexity
        //

        //javadoc: Params::get_maxConvexity()
        public float get_maxConvexity()
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        float retVal = features2d_Params_get_1maxConvexity_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void Params::maxConvexity
        //

        //javadoc: Params::set_maxConvexity(maxConvexity)
        public void set_maxConvexity(float maxConvexity)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        features2d_Params_set_1maxConvexity_10(nativeObj, maxConvexity);
        
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



        // C++:   cv::SimpleBlobDetector::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_Params_Params_10();

        // C++: float Params::thresholdStep
        [DllImport(LIBNAME)]
        private static extern float features2d_Params_get_1thresholdStep_10(IntPtr nativeObj);

        // C++: void Params::thresholdStep
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1thresholdStep_10(IntPtr nativeObj, float thresholdStep);

        // C++: float Params::minThreshold
        [DllImport(LIBNAME)]
        private static extern float features2d_Params_get_1minThreshold_10(IntPtr nativeObj);

        // C++: void Params::minThreshold
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1minThreshold_10(IntPtr nativeObj, float minThreshold);

        // C++: float Params::maxThreshold
        [DllImport(LIBNAME)]
        private static extern float features2d_Params_get_1maxThreshold_10(IntPtr nativeObj);

        // C++: void Params::maxThreshold
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1maxThreshold_10(IntPtr nativeObj, float maxThreshold);

        // C++: size_t Params::minRepeatability
        [DllImport(LIBNAME)]
        private static extern long features2d_Params_get_1minRepeatability_10(IntPtr nativeObj);

        // C++: void Params::minRepeatability
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1minRepeatability_10(IntPtr nativeObj, long minRepeatability);

        // C++: float Params::minDistBetweenBlobs
        [DllImport(LIBNAME)]
        private static extern float features2d_Params_get_1minDistBetweenBlobs_10(IntPtr nativeObj);

        // C++: void Params::minDistBetweenBlobs
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1minDistBetweenBlobs_10(IntPtr nativeObj, float minDistBetweenBlobs);

        // C++: bool Params::filterByColor
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_Params_get_1filterByColor_10(IntPtr nativeObj);

        // C++: void Params::filterByColor
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1filterByColor_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool filterByColor);

        // C++: bool Params::filterByArea
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_Params_get_1filterByArea_10(IntPtr nativeObj);

        // C++: void Params::filterByArea
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1filterByArea_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool filterByArea);

        // C++: float Params::minArea
        [DllImport(LIBNAME)]
        private static extern float features2d_Params_get_1minArea_10(IntPtr nativeObj);

        // C++: void Params::minArea
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1minArea_10(IntPtr nativeObj, float minArea);

        // C++: float Params::maxArea
        [DllImport(LIBNAME)]
        private static extern float features2d_Params_get_1maxArea_10(IntPtr nativeObj);

        // C++: void Params::maxArea
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1maxArea_10(IntPtr nativeObj, float maxArea);

        // C++: bool Params::filterByCircularity
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_Params_get_1filterByCircularity_10(IntPtr nativeObj);

        // C++: void Params::filterByCircularity
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1filterByCircularity_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool filterByCircularity);

        // C++: float Params::minCircularity
        [DllImport(LIBNAME)]
        private static extern float features2d_Params_get_1minCircularity_10(IntPtr nativeObj);

        // C++: void Params::minCircularity
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1minCircularity_10(IntPtr nativeObj, float minCircularity);

        // C++: float Params::maxCircularity
        [DllImport(LIBNAME)]
        private static extern float features2d_Params_get_1maxCircularity_10(IntPtr nativeObj);

        // C++: void Params::maxCircularity
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1maxCircularity_10(IntPtr nativeObj, float maxCircularity);

        // C++: bool Params::filterByInertia
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_Params_get_1filterByInertia_10(IntPtr nativeObj);

        // C++: void Params::filterByInertia
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1filterByInertia_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool filterByInertia);

        // C++: float Params::minInertiaRatio
        [DllImport(LIBNAME)]
        private static extern float features2d_Params_get_1minInertiaRatio_10(IntPtr nativeObj);

        // C++: void Params::minInertiaRatio
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1minInertiaRatio_10(IntPtr nativeObj, float minInertiaRatio);

        // C++: float Params::maxInertiaRatio
        [DllImport(LIBNAME)]
        private static extern float features2d_Params_get_1maxInertiaRatio_10(IntPtr nativeObj);

        // C++: void Params::maxInertiaRatio
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1maxInertiaRatio_10(IntPtr nativeObj, float maxInertiaRatio);

        // C++: bool Params::filterByConvexity
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_Params_get_1filterByConvexity_10(IntPtr nativeObj);

        // C++: void Params::filterByConvexity
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1filterByConvexity_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool filterByConvexity);

        // C++: float Params::minConvexity
        [DllImport(LIBNAME)]
        private static extern float features2d_Params_get_1minConvexity_10(IntPtr nativeObj);

        // C++: void Params::minConvexity
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1minConvexity_10(IntPtr nativeObj, float minConvexity);

        // C++: float Params::maxConvexity
        [DllImport(LIBNAME)]
        private static extern float features2d_Params_get_1maxConvexity_10(IntPtr nativeObj);

        // C++: void Params::maxConvexity
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_set_1maxConvexity_10(IntPtr nativeObj, float maxConvexity);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_Params_delete(IntPtr nativeObj);

    }
}
