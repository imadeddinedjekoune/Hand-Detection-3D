

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.BgsegmModule
{
    // C++: class BackgroundSubtractorLSBPDesc
    //javadoc: BackgroundSubtractorLSBPDesc

    public class BackgroundSubtractorLSBPDesc : DisposableOpenCVObject
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
                        bgsegm_BackgroundSubtractorLSBPDesc_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BackgroundSubtractorLSBPDesc(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static BackgroundSubtractorLSBPDesc __fromPtr__(IntPtr addr) { return new BackgroundSubtractorLSBPDesc(addr); }

#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorLSBPDesc_delete(IntPtr nativeObj);

    }
}
