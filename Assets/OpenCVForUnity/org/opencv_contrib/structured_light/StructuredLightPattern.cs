
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Structured_lightModule
{

    // C++: class StructuredLightPattern
    //javadoc: StructuredLightPattern

    public class StructuredLightPattern : Algorithm
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
                        structured_1light_StructuredLightPattern_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StructuredLightPattern(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StructuredLightPattern __fromPtr__(IntPtr addr) { return new StructuredLightPattern(addr); }

        //
        // C++:  bool cv::structured_light::StructuredLightPattern::decode(vector_vector_Mat patternImages, Mat& disparityMap, vector_Mat blackImages = vector_Mat(), vector_Mat whiteImages = vector_Mat(), int flags = DECODE_3D_UNDERWORLD)
        //

        // Unknown type 'vector_vector_Mat' (I), skipping the function


        //
        // C++:  bool cv::structured_light::StructuredLightPattern::generate(vector_Mat& patternImages)
        //

        //javadoc: StructuredLightPattern::generate(patternImages)
        public bool generate(List<Mat> patternImages)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat patternImages_mat = new Mat();
        bool retVal = structured_1light_StructuredLightPattern_generate_10(nativeObj, patternImages_mat.nativeObj);
        Converters.Mat_to_vector_Mat(patternImages_mat, patternImages);
        patternImages_mat.release();
        return retVal;
#else
            return false;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  bool cv::structured_light::StructuredLightPattern::generate(vector_Mat& patternImages)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool structured_1light_StructuredLightPattern_generate_10(IntPtr nativeObj, IntPtr patternImages_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void structured_1light_StructuredLightPattern_delete(IntPtr nativeObj);

    }
}
