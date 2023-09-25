
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Img_hashModule
{

    // C++: class PHash
    //javadoc: PHash

    public class PHash : ImgHashBase
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
                        img_1hash_PHash_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal PHash(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new PHash __fromPtr__(IntPtr addr) { return new PHash(addr); }

        //
        // C++: static Ptr_PHash cv::img_hash::PHash::create()
        //

        //javadoc: PHash::create()
        public static PHash create()
        {
#if UNITY_5_3_OR_NEWER
        
        PHash retVal = PHash.__fromPtr__(img_1hash_PHash_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_PHash cv::img_hash::PHash::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr img_1hash_PHash_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void img_1hash_PHash_delete(IntPtr nativeObj);

    }
}
