
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class MACE
    //javadoc: MACE

    public class MACE : Algorithm
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
                        face_MACE_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal MACE(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new MACE __fromPtr__(IntPtr addr) { return new MACE(addr); }

        //
        // C++: static Ptr_MACE cv::face::MACE::create(int IMGSIZE = 64)
        //

        //javadoc: MACE::create(IMGSIZE)
        public static MACE create(int IMGSIZE)
        {
#if UNITY_5_3_OR_NEWER
        
        MACE retVal = MACE.__fromPtr__(face_MACE_create_10(IMGSIZE));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: MACE::create()
        public static MACE create()
        {
#if UNITY_5_3_OR_NEWER
        
        MACE retVal = MACE.__fromPtr__(face_MACE_create_11());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_MACE cv::face::MACE::load(String filename, String objname = String())
        //

        //javadoc: MACE::load(filename, objname)
        public static MACE load(string filename, string objname)
        {
#if UNITY_5_3_OR_NEWER
        
        MACE retVal = MACE.__fromPtr__(face_MACE_load_10(filename, objname));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: MACE::load(filename)
        public static MACE load(string filename)
        {
#if UNITY_5_3_OR_NEWER
        
        MACE retVal = MACE.__fromPtr__(face_MACE_load_11(filename));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::face::MACE::same(Mat query)
        //

        //javadoc: MACE::same(query)
        public bool same(Mat query)
        {
            ThrowIfDisposed();
            if (query != null) query.ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        bool retVal = face_MACE_same_10(nativeObj, query.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  void cv::face::MACE::salt(String passphrase)
        //

        //javadoc: MACE::salt(passphrase)
        public void salt(string passphrase)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        
        face_MACE_salt_10(nativeObj, passphrase);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::face::MACE::train(vector_Mat images)
        //

        //javadoc: MACE::train(images)
        public void train(List<Mat> images)
        {
            ThrowIfDisposed();
#if UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_Mat_to_Mat(images);
        face_MACE_train_10(nativeObj, images_mat.nativeObj);
        
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



        // C++: static Ptr_MACE cv::face::MACE::create(int IMGSIZE = 64)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_MACE_create_10(int IMGSIZE);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_MACE_create_11();

        // C++: static Ptr_MACE cv::face::MACE::load(String filename, String objname = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr face_MACE_load_10(string filename, string objname);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_MACE_load_11(string filename);

        // C++:  bool cv::face::MACE::same(Mat query)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool face_MACE_same_10(IntPtr nativeObj, IntPtr query_nativeObj);

        // C++:  void cv::face::MACE::salt(String passphrase)
        [DllImport(LIBNAME)]
        private static extern void face_MACE_salt_10(IntPtr nativeObj, string passphrase);

        // C++:  void cv::face::MACE::train(vector_Mat images)
        [DllImport(LIBNAME)]
        private static extern void face_MACE_train_10(IntPtr nativeObj, IntPtr images_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_MACE_delete(IntPtr nativeObj);

    }
}
