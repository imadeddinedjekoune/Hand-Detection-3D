
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class SelectiveSearchSegmentationStrategyTexture
    //javadoc: SelectiveSearchSegmentationStrategyTexture

    public class SelectiveSearchSegmentationStrategyTexture : SelectiveSearchSegmentationStrategy
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
                        ximgproc_SelectiveSearchSegmentationStrategyTexture_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SelectiveSearchSegmentationStrategyTexture(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SelectiveSearchSegmentationStrategyTexture __fromPtr__(IntPtr addr) { return new SelectiveSearchSegmentationStrategyTexture(addr); }

#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategyTexture_delete(IntPtr nativeObj);

    }
}
