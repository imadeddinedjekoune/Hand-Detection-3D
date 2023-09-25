

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Structured_lightModule
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
                        structured_1light_Params_delete(nativeObj);
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
        // C++:   cv::structured_light::SinusoidalPattern::Params::Params()
        //

        //javadoc: Params::Params()
        public Params()
        {
#if UNITY_5_3_OR_NEWER
        
        nativeObj = structured_1light_Params_Params_10();
        
        return;
#else
            return null;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::structured_light::SinusoidalPattern::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr structured_1light_Params_Params_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void structured_1light_Params_delete(IntPtr nativeObj);

    }
}
