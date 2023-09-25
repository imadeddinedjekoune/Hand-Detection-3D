
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class SelectiveSearchSegmentationStrategySize
    //javadoc: SelectiveSearchSegmentationStrategySize

    public class SelectiveSearchSegmentationStrategySize : SelectiveSearchSegmentationStrategy
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
                        ximgproc_SelectiveSearchSegmentationStrategySize_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SelectiveSearchSegmentationStrategySize(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SelectiveSearchSegmentationStrategySize __fromPtr__(IntPtr addr) { return new SelectiveSearchSegmentationStrategySize(addr); }

#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategySize_delete(IntPtr nativeObj);

    }
}
