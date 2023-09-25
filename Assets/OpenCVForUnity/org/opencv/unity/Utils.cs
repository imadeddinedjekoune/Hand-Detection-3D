using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using AOT;
using OpenCVForUnity.CoreModule;

namespace OpenCVForUnity.UnityUtils
{
    public static class Utils
    {
        /**
        * Returns this "OpenCV for Unity" version number.
        * 
        * @return this "OpenCV for Unity" version number
        */
        public static string getVersion()
        {
            return "2.3.5";
        }

        /**
        * Copies OpenCV Mat data to Pixel Data IntPtr.
        * <p>
        * <br>This function copies the OpenCV Mat data to the pixel data IntPtr.
        * <br>The pixel data has to be of the same byte size as the Mat data ([total() * elemSize()] byte).
        * <br>Because this function doesn't check bounds, is faster than Mat.get().
        *
        * @param mat a Mat object.
        * @param intPtr the pixel data has to be of the same byte size as the Mat data ([total() * elemSize()] byte).
        */
        public static void copyFromMat(Mat mat, IntPtr intPtr)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (mat == null)
                throw new ArgumentNullException("mat == null");
            if (intPtr == IntPtr.Zero)
                throw new ArgumentNullException("intPtr == IntPtr.Zero");

#if UNITY_5_3_OR_NEWER
            OpenCVForUnity_MatDataToByteArray (mat.nativeObj, intPtr);
#else
            return;
#endif
        }

        /**
        * Copies Pixel Data IntPtr to OpenCV Mat data.
        * <p>
        * <br>This function copy the pixel data IntPtr to the OpenCV Mat data.
        * <br>The Mat object has to be of the same byte size as the pixel data ([total() * elemSize()] byte).
        * <br>Because this function doesn't check bounds, is faster than Mat.put().
        * 
        * @param intPtr a pixel data IntPtr.
        * @param mat the Mat object has to be of the same byte size as the pixel data ([total() * elemSize()] byte).
        */
        public static void copyToMat(IntPtr intPtr, Mat mat)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (intPtr == IntPtr.Zero)
                throw new ArgumentNullException("intPtr == IntPtr.Zero");
            if (mat == null)
                throw new ArgumentNullException("mat == null");


#if UNITY_5_3_OR_NEWER
            OpenCVForUnity_ByteArrayToMatData (intPtr, mat.nativeObj);
#else
            return;
#endif
        }

        /**
        * Copies OpenCV Mat data to Pixel Data Array.
        * <p>
        * <br>This function copies the OpenCV Mat data to the pixel data Array.
        * <br>The pixel data Array has to be of the same byte size as the Mat data ([total() * elemSize()] byte).
        * <br>Because this function doesn't check bounds, is faster than Mat.get().
        *
        * @param mat a Mat object.
        * @param array the pixel data Array has to be of the same byte size as the Mat data ([total() * elemSize()] byte).
        */
        public static void copyFromMat<T>(Mat mat, IList<T> array)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (mat == null)
                throw new ArgumentNullException("mat == null");
            if (array == null)
                throw new ArgumentNullException("array == null");

#if UNITY_5_3_OR_NEWER
            GCHandle arrayHandle = GCHandle.Alloc (array, GCHandleType.Pinned);

            OpenCVForUnity_MatDataToByteArray (mat.nativeObj, arrayHandle.AddrOfPinnedObject ());

            arrayHandle.Free ();
#else
            return;
#endif
        }

        /**
        * Copies Pixel Data Array to OpenCV Mat data.
        * <p>
        * <br>This function copies the pixel data Array to the OpenCV Mat data.
        * <br>The Mat object has to be of the same byte size as the pixel data Array ([total() * elemSize()] byte).
        * <br>Because this function doesn't check bounds, is faster than Mat.put().
        * 
        * @param array a pixel data Array.
        * @param mat the Mat object has to be of the same byte size as the pixel data Array ([total() * elemSize()] byte).
        */
        public static void copyToMat<T>(IList<T> array, Mat mat)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (array == null)
                throw new ArgumentNullException("array == null");
            if (mat == null)
                throw new ArgumentNullException("mat == null");

#if UNITY_5_3_OR_NEWER
            GCHandle arrayHandle = GCHandle.Alloc (array, GCHandleType.Pinned);
            
            OpenCVForUnity_ByteArrayToMatData (arrayHandle.AddrOfPinnedObject (), mat.nativeObj);

            arrayHandle.Free ();
#else
            return;
#endif
        }

        /**
        * Converts OpenCV Mat to Unity Texture2D.
        * <p>
        * <br>This function converts the OpenCV Mat to the Unity Texture2D image.
        * <br>The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * <br>The Texture2D object has to be of the TextureFormat 'RGBA32' or 'ARGB32'. (SetPixels32() must function.)
        * <br>The Texture2D object has to be of the same size as the Mat (width * height).
        *
        * @param mat the Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY)
        * @param texture2D the Texture2D object has to be of the TextureFormat 'RGBA32' or 'ARGB32'. (SetPixels32() must function.) The Texture2D object has to be of the same size as the Mat (width * height).
        * @param flip if true, the mat is fliped before converting.
        * @param flipCode a flag to specify how to flip the array; 0 means flipping around the x-axis and positive value (for example, 1) means flipping around y-axis. Negative value (for example, -1) means flipping around both axes.
        * @param flipAfter if true, the mat is fliped after converting. If you want to use mat even after calling this function, set true.
        * @param updateMipmaps When set to true, mipmap levels are recalculated.
        * @param makeNoLongerReadable When set to true, system memory copy of a texture is released.
        */
        public static void matToTexture2D(Mat mat, Texture2D texture2D, bool flip = true, int flipCode = 0, bool flipAfter = false, bool updateMipmaps = false, bool makeNoLongerReadable = false)
        {
            matToTexture2D(mat, texture2D, null, flip, flipCode, flipAfter, updateMipmaps, makeNoLongerReadable);
        }

        /**
        * Converts OpenCV Mat to Unity Texture2D.
        * <p>
        * <br>This function converts the OpenCV Mat to the Unity Texture2D image.
        * <br>The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * <br>The Texture2D object has to be of the TextureFormat 'RGBA32' or 'ARGB32'. (SetPixels32() must function.)
        * <br>The Texture2D object has to be of the same size as the Mat (width * height).
        *
        * @param mat the Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY)
        * @param texture2D the Texture2D object has to be of the TextureFormat 'RGBA32' or 'ARGB32'. (SetPixels32() must function) The Texture2D object has to be of the same size as the Mat (width * height).
        * @param bufferColors the optional array to receive pixel data. 
        * You can optionally pass in an array of Color32s to use in colors to avoid allocating new memory each frame.
        * The array needs to be initialized to a length matching width * height of the texture. (<a href="http://docs.unity3d.com/ScriptReference/WebCamTexture.GetPixels32.html">http://docs.unity3d.com/ScriptReference/WebCamTexture.GetPixels32.html</a>)
        * @param flip if true, the mat is fliped before converting.
        * @param flipCode a flag to specify how to flip the array; 0 means flipping around the x-axis and positive value (for example, 1) means flipping around y-axis. Negative value (for example, -1) means flipping around both axes.
        * @param flipAfter if true, the mat is fliped after converting. If you want to use mat even after calling this function, set true.
        * @param updateMipmaps When set to true, mipmap levels are recalculated.
        * @param makeNoLongerReadable When set to true, system memory copy of a texture is released.
        */
        public static void matToTexture2D(Mat mat, Texture2D texture2D, Color32[] bufferColors, bool flip = true, int flipCode = 0, bool flipAfter = false, bool updateMipmaps = false, bool makeNoLongerReadable = false)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (mat == null)
                throw new ArgumentNullException("mat == null");
            if (texture2D == null)
                throw new ArgumentNullException("texture2D == null");

            if (mat.cols() != texture2D.width || mat.rows() != texture2D.height)
                throw new ArgumentException("The Texture2D object has to be of the same size");



            //                      Core.flip (mat, mat, 0);
            //
            //                      byte[] data = new byte[mat.cols () * mat.rows () * mat.channels ()];
            //                      mat.get (0, 0, data);
            //
            //                      Core.flip (mat, mat, 0);
            //
            //                      if (texture2D.format == TextureFormat.ARGB32 || texture2D.format == TextureFormat.BGRA32 || texture2D.format == TextureFormat.RGBA32) {
            //
            //                              Color32[] colors = new Color32[mat.cols () * mat.rows ()];
            //                              
            //                                      
            //
            //                              if (mat.type () == CvType.CV_8UC1) {
            //                                      for (int i = 0; i < colors.Length; i++) {
            //                                              colors [i] = new Color32 (data [i], data [i], data [i], 255);
            //                                      }
            //                              } else if (mat.type () == CvType.CV_8UC3) {
            //                                      for (int i = 0; i < colors.Length; i++) {
            //                                              colors [i] = new Color32 (data [(i * 3) + 0], data [(i * 3) + 1], data [(i * 3) + 2], 255);
            //                                      }
            //                              } else if (mat.type () == CvType.CV_8UC4) {
            //                                      for (int i = 0; i < colors.Length; i++) {
            //                                              colors [i] = new Color32 (data [(i * 4) + 0], data [(i * 4) + 1], data [(i * 4) + 2], data [(i * 4) + 3]);
            //                                      }
            //                              }
            //                                      
            //                              
            //                              texture2D.SetPixels32 (colors);
            //                              
            //                      } else {
            //                              Color[] colors = new Color[mat.cols () * mat.rows ()];
            //                              
            //                              if (mat.type () == CvType.CV_8UC1) {
            //                                      for (int i = 0; i < colors.Length; i++) {
            //                                              colors [i] = new Color ((float)data [i] / 255.0f, data [i] / 255.0f, data [i] / 255.0f);
            //                                      }
            //                              } else if (mat.type () == CvType.CV_8UC3) {
            //                                      for (int i = 0; i < colors.Length; i++) {
            //                                              colors [i] = new Color ((float)data [(i * 3) + 0] / 255.0f, (float)data [(i * 3) + 1] / 255.0f, (float)data [(i * 3) + 2] / 255.0f);
            //                                      }
            //                              } else if (mat.type () == CvType.CV_8UC4) {
            //                                      for (int i = 0; i < colors.Length; i++) {
            //                                              colors [i] = new Color ((float)data [(i * 4) + 0] / 255.0f, (float)data [(i * 4) + 1] / 255.0f, (float)data [(i * 4) + 2] / 255.0f);
            //                                      }
            //                              }
            //                  
            //                              
            //                              texture2D.SetPixels (colors);
            //
            //                      }
            //
            //                      texture2D.Apply ();

            //                      #if UNITY_5_3_OR_NEWER
            //          if(mat.type () == CvType.CV_8UC4){
            //              OpenCVForUnity_LowLevelMatToTexture (mat.nativeObj, texture2D.GetNativeTexturePtr(), texture2D.width, texture2D.height);
            //
            //          return;
            //          }
            //          
            //                      #endif



#if UNITY_5_3_OR_NEWER

            int type = mat.type ();

            if (mat.isContinuous () && (texture2D.format == TextureFormat.RGBA32 && type == CvType.CV_8UC4) || (texture2D.format == TextureFormat.RGB24 && type == CvType.CV_8UC3) || (texture2D.format == TextureFormat.Alpha8 && type == CvType.CV_8UC1)) {

                if (flip) {
                    Core.flip (mat, mat, flipCode);
                }
                texture2D.LoadRawTextureData ((IntPtr)mat.dataAddr (), (int)mat.total () * (int)mat.elemSize ());
                texture2D.Apply (updateMipmaps, makeNoLongerReadable);
                if (flipAfter) {
                    Core.flip (mat, mat, flipCode);
                }

                return;
            }

            GCHandle colorsHandle;

            if (bufferColors == null) {
                Color32[] colors = texture2D.GetPixels32 ();
                
                colorsHandle = GCHandle.Alloc (colors, GCHandleType.Pinned);

                OpenCVForUnity_MatToTexture (mat.nativeObj, colorsHandle.AddrOfPinnedObject (), flip, flipCode, flipAfter);
                
                texture2D.SetPixels32 (colors);
            } else {
                colorsHandle = GCHandle.Alloc (bufferColors, GCHandleType.Pinned);

                OpenCVForUnity_MatToTexture (mat.nativeObj, colorsHandle.AddrOfPinnedObject (), flip, flipCode, flipAfter);
                
                texture2D.SetPixels32 (bufferColors);
            }


            texture2D.Apply (updateMipmaps, makeNoLongerReadable);
            
            colorsHandle.Free ();

#else
            return;
#endif
        }

        /**
        * Fast converts OpenCV Mat to Unity Texture2D. (Unity5.3+)
        * <p>
        * <br>This function converts the OpenCV Mat to the Unity Texture2D image.
        * <br>Passed Mat data should be of required size to fill the whole texture according to its width, height, data format and mipmapCount. 
        * <br>This function doesn't check bounds.
        *
        * @param mat
        * @param texture2D The Texture2D object has to be of the same size as the Mat (width * height).
        * @param flip if true, the mat is fliped before converting.
        * @param flipCode a flag to specify how to flip the array; 0 means flipping around the x-axis and positive value (for example, 1) means flipping around y-axis. Negative value (for example, -1) means flipping around both axes.
        * @param flipAfter if true, the mat is fliped after converting. If you want to use mat even after calling this function, set true.
        * @param updateMipmaps When set to true, mipmap levels are recalculated.
        * @param makeNoLongerReadable When set to true, system memory copy of a texture is released.
        */
        public static void fastMatToTexture2D(Mat mat, Texture2D texture2D, bool flip = true, int flipCode = 0, bool flipAfter = false, bool updateMipmaps = false, bool makeNoLongerReadable = false)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (mat == null)
                throw new ArgumentNullException("mat == null");
            if (texture2D == null)
                throw new ArgumentNullException("texture2D == null");

#if UNITY_5_3_OR_NEWER

            if (!mat.isContinuous ()) {
                throw new ArgumentException ("mat.isContinuous() must be true.");
            }

            if (flip) {
                Core.flip (mat, mat, flipCode);
            }
            texture2D.LoadRawTextureData ((IntPtr)mat.dataAddr (), (int)mat.total () * (int)mat.elemSize ());
            texture2D.Apply (updateMipmaps, makeNoLongerReadable);
            if (flipAfter) {
                Core.flip (mat, mat, flipCode);
            }

            return;

#else
            return;
#endif
        }

        /**
        * Converts Unity Texture2D to OpenCV Mat.
        * <p>
        * <br>This function converts the Unity Texture2D image to the OpenCV Mat.
        * <br>The Mat object has to be of the same size as the Texture2D (width * height).
        * <br>The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * 
        * @param texture2D the Texture2D object has to be of the TextureFormat 'RGBA32' or 'ARGB32'. (SetPixels32() must function)
        * @param mat the Mat object has to be of the same size as the Texture2D (width * height).
        * The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * @param flip if true, the mat is fliped after converting.
        * @param flipCode a flag to specify how to flip the array; 0 means flipping around the x-axis and positive value (for example, 1) means flipping around y-axis. Negative value (for example, -1) means flipping around both axes.
        */
        public static void texture2DToMat(Texture2D texture2D, Mat mat, bool flip = true, int flipCode = 0)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (texture2D == null)
                throw new ArgumentNullException("texture2D == null");
            if (mat == null)
                throw new ArgumentNullException("mat == null");

            if (mat.cols() != texture2D.width || mat.rows() != texture2D.height)
                throw new ArgumentException("The Mat object has to be of the same size");

            //                      byte[] data = new byte[mat.cols () * mat.rows () * mat.channels ()];
            //
            //                      Color32[] colors = texture2D.GetPixels32 ();
            //
            //                      if (mat.type () == CvType.CV_8UC1) {
            //                              for (int i = 0; i < colors.Length; i++) {
            //                                      data [i] = colors [i].b;
            //                              }
            //                              mat.put (0, 0, data);
            //                              Core.flip (mat, mat, 0);
            //                      } else if (mat.type () == CvType.CV_8UC3) {
            //                              for (int i = 0; i < colors.Length; i++) {
            //                                      data [(i * 3) + 0] = colors [i].b;
            //                                      data [(i * 3) + 1] = colors [i].g;
            //                                      data [(i * 3) + 2] = colors [i].r;
            //                              }
            //                              mat.put (0, 0, data);
            //                              Core.flip (mat, mat, 0);
            //                      } else if (mat.type () == CvType.CV_8UC4) {
            //                              for (int i = 0; i < colors.Length; i++) {
            //                                      data [(i * 4) + 0] = colors [i].b;
            //                                      data [(i * 4) + 1] = colors [i].g;
            //                                      data [(i * 4) + 2] = colors [i].r;
            //                                      data [(i * 4) + 3] = colors [i].a;
            //                              }
            //                              mat.put (0, 0, data);
            //                              Core.flip (mat, mat, 0);
            //                      }


            //                      #if UNITY_5_3_OR_NEWER
            //          if(mat.type () == CvType.CV_8UC4){
            //              OpenCVForUnity_LowLevelTextureToMat (texture2D.GetNativeTexturePtr(), texture2D.width, texture2D.height, mat.nativeObj);
            //              
            //              return;
            //          }
            //          
            //                      #endif

#if UNITY_5_3_OR_NEWER

            int type = mat.type ();

            if ((texture2D.format == TextureFormat.RGBA32 && type == CvType.CV_8UC4) || (texture2D.format == TextureFormat.RGB24 && type == CvType.CV_8UC3) || (texture2D.format == TextureFormat.Alpha8 && type == CvType.CV_8UC1)) {
                mat.put (0, 0, texture2D.GetRawTextureData ());
                if (flip) {
                    Core.flip (mat, mat, flipCode);
                }

                return;
            }
            
            Color32[] colors = texture2D.GetPixels32 ();
            
            GCHandle colorsHandle = GCHandle.Alloc (colors, GCHandleType.Pinned);
            
            OpenCVForUnity_TextureToMat (colorsHandle.AddrOfPinnedObject (), mat.nativeObj, flip, flipCode);
            
            colorsHandle.Free ();
            
#else
            return;
#endif
        }

        /**
        * Fast converts Unity Texture2D to OpenCV Mat. (Unity5.1+)
        * <p>
        * <br>This function converts the Unity Texture2D image to the OpenCV Mat.
        * <br>Mat data size must be the same as the texture data size.
        * <br>This function doesn't check bounds.
        * 
        * @param texture2D
        * @param mat the Mat object has to be of the same size as the Texture2D (width * height).
        * @param flip if true, the mat is fliped after converting.
        * @param flipCode a flag to specify how to flip the array; 0 means flipping around the x-axis and positive value (for example, 1) means flipping around y-axis. Negative value (for example, -1) means flipping around both axes.
        */
        public static void fastTexture2DToMat(Texture2D texture2D, Mat mat, bool flip = true, int flipCode = 0)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (texture2D == null)
                throw new ArgumentNullException("texture2D == null");
            if (mat == null)
                throw new ArgumentNullException("mat == null");

#if UNITY_5_3_OR_NEWER

            Utils.copyToMat (texture2D.GetRawTextureData (), mat);
            if (flip) {
                Core.flip (mat, mat, flipCode);
            }

            return;

#else
            return;
#endif
        }

#if !(UNITY_LUMIN && !UNITY_EDITOR)

        /**
        * Converts Unity WebCamTexture to OpenCV Mat.
        * <p>
        * <br>This function converts the Unity WebCamTexture image to the OpenCV Mat.
        * <br>The Mat object has to be of the same size as the WebCamTexture (width * height).
        * <br>The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * 
        * @param webcamTexture a WebCamTexture object.
        * @param mat the Mat object has to be of the same size as the WebCamTexture (width * height).
        * The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * @param flip if true, the mat is fliped after converting.
        * @param flipCode a flag to specify how to flip the array; 0 means flipping around the x-axis and positive value (for example, 1) means flipping around y-axis. Negative value (for example, -1) means flipping around both axes.
        */
        public static void webCamTextureToMat(WebCamTexture webCamTexture, Mat mat, bool flip = true, int flipCode = 0)
        {
            webCamTextureToMat(webCamTexture, mat, null, flip, flipCode);
        }

        /**
        * Converts Unity WebCamTexture to OpenCV Mat.
        * <p>
        * <br>This function converts the Unity WebCamTexture image to the OpenCV Mat.
        * <br>The Mat object has to be of the same size as the WebCamTexture (width * height).
        * <br>The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * 
        * @param webcamTexture a WebCamTexture object.
        * @param mat the Mat object has to be of the same size as the WebCamTexture' (width * height).
        * The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * @param bufferColors the optional array to receive pixel data.
        * You can optionally pass in an array of Color32s to use in colors to avoid allocating new memory each frame.
        * The array needs to be initialized to a length matching width * height of the texture. (http://docs.unity3d.com/ScriptReference/WebCamTexture.GetPixels32.html)
        * @param flip if true, the mat is fliped after converting.
        * @param flipCode a flag to specify how to flip the array; 0 means flipping around the x-axis and positive value (for example, 1) means flipping around y-axis. Negative value (for example, -1) means flipping around both axes.
        */
        public static void webCamTextureToMat(WebCamTexture webCamTexture, Mat mat, Color32[] bufferColors, bool flip = true, int flipCode = 0)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (webCamTexture == null)
                throw new ArgumentNullException("webCamTexture == null");
            if (mat == null)
                throw new ArgumentNullException("mat == null");

            if (mat.cols() != webCamTexture.width || mat.rows() != webCamTexture.height)
                throw new ArgumentException("The Mat object has to be of the same size");

            //                                              byte[] data = new byte[mat.cols () * mat.rows () * mat.channels ()];
            //                      
            //                                              Color32[] colors = webCamTexture.GetPixels32 ();
            //                      
            //                                              if (mat.type () == CvType.CV_8UC1) {
            //                                                      for (int i = 0; i < colors.Length; i++) {
            //                                                              data [i] = colors [i].b;
            //                                                      }
            //                                                      mat.put (0, 0, data);
            //                                                      Core.flip (mat, mat, 0);
            //                                              } else if (mat.type () == CvType.CV_8UC3) {
            //                                                      for (int i = 0; i < colors.Length; i++) {
            //                                                              data [(i * 3) + 0] = colors [i].r;
            //                                                              data [(i * 3) + 1] = colors [i].g;
            //                                                              data [(i * 3) + 2] = colors [i].b;
            //                                                      }
            //                                                      mat.put (0, 0, data);
            //                                                      Core.flip (mat, mat, 0);
            //                                              } else if (mat.type () == CvType.CV_8UC4) {
            //                                                      for (int i = 0; i < colors.Length; i++) {
            //                                                              data [(i * 4) + 0] = colors [i].r;
            //                                                              data [(i * 4) + 1] = colors [i].g;
            //                                                              data [(i * 4) + 2] = colors [i].b;
            //                                                              data [(i * 4) + 3] = colors [i].a;
            //                                                      }
            //                                                      mat.put (0, 0, data);
            //                                                      Core.flip (mat, mat, 0);
            //                                              }


#if UNITY_5_3_OR_NEWER
            GCHandle colorsHandle;
            if (bufferColors == null) {

                Color32[] colors = webCamTexture.GetPixels32 ();
            
                colorsHandle = GCHandle.Alloc (colors, GCHandleType.Pinned);
            } else {
                webCamTexture.GetPixels32 (bufferColors);
                
                colorsHandle = GCHandle.Alloc (bufferColors, GCHandleType.Pinned);
            }
            
            OpenCVForUnity_TextureToMat (colorsHandle.AddrOfPinnedObject (), mat.nativeObj, flip, flipCode);
            
            colorsHandle.Free ();
            
#else
            return;
#endif
        }

#endif

        /**
        * Converts Texture to Texture2D.
        * <p>
        * <br>This function converts the Texture image to the Texture2D image.
        * <br>The texture and texture2D need to be the same size.
        * <br>The texture2D's TextureFormat needs to be RGBA32 (Unity5.5+), ARGB32, RGB24, RGBAFloat or RGBAHalf.
        * 
        * @param texture a texture object.
        * @param texture2D a texture2D object.
        */
        public static void textureToTexture2D(Texture texture, Texture2D texture2D)
        {
            if (texture == null)
                throw new ArgumentNullException("texture == null");
            if (texture2D == null)
                throw new ArgumentNullException("texture2D == null");

            if (texture.width != texture2D.width || texture.height != texture2D.height)
                throw new ArgumentException("texture and texture2D need to be the same size.");

            RenderTexture prevRT = RenderTexture.active;

            if (texture is RenderTexture)
            {
                RenderTexture.active = (RenderTexture)texture;
                texture2D.ReadPixels(new UnityEngine.Rect(0f, 0f, texture.width, texture.height), 0, 0, false);
                texture2D.Apply(false, false);

            }
            else
            {
                RenderTexture tempRT = RenderTexture.GetTemporary(texture.width, texture.height, 0, RenderTextureFormat.ARGB32);
                Graphics.Blit(texture, tempRT);

                RenderTexture.active = tempRT;
                texture2D.ReadPixels(new UnityEngine.Rect(0f, 0f, texture.width, texture.height), 0, 0, false);
                texture2D.Apply(false, false);
                RenderTexture.ReleaseTemporary(tempRT);
            }

            RenderTexture.active = prevRT;
        }

        /**
        * Register Plugin on WebGL.
        * <p>
        * <br>For the WebGL platform, please call this method before calling IntPtrToTextureInRenderThread(), ArrayToTextureInRenderThread() and MatToTextureInRenderThread() methods.
        */
        public static void registerWebGLPlugin()
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            if(isWebGLPluginRegistered)return;
            OpenCVForUnity_RegisterPlugin();
            isWebGLPluginRegistered = true;
#endif
        }

        /**
        * Copies Pixel Data IntPtr to Texture at render thread.
        * <p>
        * <br>This function copies the pixel data IntPtr to Texture at render thread.
        * <br>The pixel data has to be of the same byte size as the Texture data ([width * height * 4] byte)
        * <br>The texture's TextureFormat needs to be 4byte per pixel (RGBA32(Unity5.5+), ARGB32).
        * 
        * @param intPtr the pixel data has to be of the same byte size as the Texture data ([width * height * 4] byte).
        * @param texture the texture's TextureFormat needs to be 4byte per pixel (RGBA32(Unity5.5+), ARGB32).
        */
        public static void intPtrToTextureInRenderThread(IntPtr intPtr, Texture texture)
        {
            if (intPtr == IntPtr.Zero)
                throw new ArgumentNullException("intPtr == IntPtr.Zero");
            if (texture == null)
                throw new ArgumentNullException("texture == null");

#if UNITY_5_3_OR_NEWER
            OpenCVForUnity_SetByteArrayFromUnity (intPtr, 0, 0, 0);
            OpenCVForUnity_SetTextureFromUnity (texture.GetNativeTexturePtr (), texture.width, texture.height, 4);

            GL.IssuePluginEvent (OpenCVForUnity_GetRenderEventFunc (), 1);
#else
            return;
#endif
        }

        /**
        * Copies Pixel Data Array to Texture at render thread.
        * <p>
        * <br>This function copies the pixel data Array to Texture at render thread.
        * <br>The pixel data Array has to be of the same byte size as the Texture data ([width * height * 4] byte)
        * <br>The texture's TextureFormat needs to be 4byte per pixel (RGBA32(Unity5.5+), ARGB32).
        * 
        * @param array the pixel data Array has to be of the same byte size as the Texture data ([width * height * 4] byte).
        * @param texture the texture's TextureFormat needs to be 4byte per pixel (RGBA32(Unity5.5+), ARGB32).
        */
        public static void arrayToTextureInRenderThread<T>(IList<T> array, Texture texture)
        {
            if (array == null)
                throw new ArgumentNullException("array == null");
            if (texture == null)
                throw new ArgumentNullException("texture == null");

#if UNITY_5_3_OR_NEWER
            GCHandle arrayHandle = GCHandle.Alloc (array, GCHandleType.Pinned);

            OpenCVForUnity_SetByteArrayFromUnity (arrayHandle.AddrOfPinnedObject (), 0, 0, 0);
            OpenCVForUnity_SetTextureFromUnity (texture.GetNativeTexturePtr (), texture.width, texture.height, 4);

            GL.IssuePluginEvent (OpenCVForUnity_GetRenderEventFunc (), 1);

            arrayHandle.Free ();
#else
            return;
#endif
        }

        /**
        * Copies OpenCV Mat data to Texture at render thread.
        * <p>
        * <br>This function copies the OpenCV Mat data to Texture at render thread.
        * <br>This method does not flip mat before copying mat to the texture.
        * <br>The OpenCV Mat data has to be of the same byte size as the Texture data ([width * height * 4] byte)
        * <br>The texture's TextureFormat needs to be 4byte per pixel (RGBA32(Unity5.5+), ARGB32).
        * 
        * @param mat the OpenCV Mat data has to be of the same byte size as the Texture data ([width * height * 4] byte).
        * @param texture the texture's TextureFormat needs to be 4byte per pixel (RGBA32(Unity5.5+), ARGB32).
        */
        public static void matToTextureInRenderThread(Mat mat, Texture texture)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (mat == null)
                throw new ArgumentNullException("mat == null");
            if (texture == null)
                throw new ArgumentNullException("texture == null");

            if (mat.cols() != texture.width || mat.rows() != texture.height)
                throw new ArgumentException("The Texture object has to be of the same size");

#if UNITY_5_3_OR_NEWER
            if (!mat.isContinuous ()) {
                throw new ArgumentException ("mat.isContinuous() must be true.");
            }

            OpenCVForUnity_SetByteArrayFromUnity ((IntPtr)mat.dataAddr (), mat.width (), mat.height (), (int)mat.elemSize ());
            OpenCVForUnity_SetTextureFromUnity (texture.GetNativeTexturePtr (), texture.width, texture.height, 4);

            GL.IssuePluginEvent (OpenCVForUnity_GetRenderEventFunc (), 1);
#else
            return;
#endif
        }

        /**
        * Gets the readable path of a file in the "StreamingAssets" folder.
        * <p>
        * <br>Set a relative file path from the starting point of the "StreamingAssets" folder. e.g. "foobar.txt" or "hogehoge/foobar.txt".
        * <br>[Android] The target file that exists in the "StreamingAssets" folder is copied into the folder of the Application.persistentDataPath. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * <br>[WebGL] If the target file has not yet been copied to WebGL's virtual filesystem, you need to use getFilePathAsync() at first.
        * 
        * @param filepath a relative file path starting from "StreamingAssets" folder.
        * @param refresh [Android] If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied.
        * @param timeout [Android 2017.1+] Sets UnityWebRequest to attempt to abort after the number of seconds in timeout has passed. No timeout is applied when timeout is set to 0 and this property defaults to 0. 
        * @return returns a readable file path in case of success and returns empty in case of error.
        */
        public static string getFilePath(string filepath, bool refresh = false, int timeout = 0)
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            filepath = filepath.TrimStart (chTrims);

            string srcPath = Path.Combine (Application.streamingAssetsPath, filepath);
            string destPath = Path.Combine (Application.persistentDataPath, "opencvforunity");
            destPath = Path.Combine (destPath, filepath);

            if (!refresh && File.Exists (destPath))
                return destPath;

#if UNITY_2017_1_OR_NEWER
            using (UnityEngine.Networking.UnityWebRequest request = UnityEngine.Networking.UnityWebRequest.Get (srcPath)) {

                request.timeout = timeout;

#if UNITY_2018_2_OR_NEWER
                request.SendWebRequest ();
#else
                request.Send ();
#endif

                while (!request.isDone) {;}

#if UNITY_2017_1_OR_NEWER
                if (request.isHttpError || request.isNetworkError) {
#else
                if (request.isError) {
#endif
                    Debug.LogWarning (request.error);
                    Debug.LogWarning (request.responseCode);
                    return String.Empty;
                }

                //create Directory
                String dirPath = Path.GetDirectoryName (destPath);
                if (!Directory.Exists (dirPath))
                    Directory.CreateDirectory (dirPath);

                File.WriteAllBytes (destPath, request.downloadHandler.data);
            }
#else
            using (WWW request = new WWW (srcPath)) {
                while (!request.isDone) {;}

                if (!string.IsNullOrEmpty(request.error)) {
                    Debug.LogWarning (request.error);
                    return String.Empty;
                }

                //create Directory
                String dirPath = Path.GetDirectoryName (destPath);
                if (!Directory.Exists (dirPath))
                    Directory.CreateDirectory (dirPath);

                File.WriteAllBytes (destPath, request.bytes);
            }
#endif
            return destPath;
#elif UNITY_WEBGL && !UNITY_EDITOR
            filepath = filepath.TrimStart (chTrims);

            string destPath = Path.Combine(Path.AltDirectorySeparatorChar.ToString(), "opencvforunity");
            destPath = Path.Combine(destPath, filepath);

            if (File.Exists(destPath)){
                return destPath;
            }else{
                return String.Empty;
            }
#else
            filepath = filepath.TrimStart(chTrims);

            string destPath = Path.Combine(Application.streamingAssetsPath, filepath);

            if (File.Exists(destPath))
            {
                return destPath;
            }
            else
            {
                return String.Empty;
            }
#endif
        }

        /**
        * Gets the multiple readable paths of files in the "StreamingAssets" folder.
        * <p>
        * <br>Set a relative file path from the starting point of the "StreamingAssets" folder. e.g. "foobar.txt" or "hogehoge/foobar.txt".
        * <br>[Android] The target file that exists in the "StreamingAssets" folder is copied into the folder of the Application.persistentDataPath. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * <br>[WebGL] If the target file has not yet been copied to WebGL's virtual filesystem, you need to use getFilePathAsync() at first.
        * 
        * @param filepaths an array of relative file paths starting from the "StreamingAssets" folder.
        * @param refresh [Android] If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied.
        * @param timeout [Android 2017.1+] Sets UnityWebRequest to attempt to abort after the number of seconds in timeout has passed. No timeout is applied when timeout is set to 0 and this property defaults to 0. 
        * @return returns an array of readable file paths.
        */
        public static string[] getMultipleFilePaths(string[] filepaths, bool refresh = false, int timeout = 0)
        {
            string[] result = new string[filepaths.Length];

            for (int i = 0; i < filepaths.Length; i++)
            {
                result[i] = getFilePath(filepaths[i], refresh, timeout);
            }

            return result;
        }

        /**
        * Gets the readable path of a file in the "StreamingAssets" folder by using coroutines.
        * <p>
        * <br>Set a relative file path from the starting point of the "StreamingAssets" folder.  e.g. "foobar.txt" or "hogehoge/foobar.txt".
        * <br>[Android] The target file that exists in the "StreamingAssets" folder is copied into the folder of the Application.persistentDataPath. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * <br>[WebGL] The target file in the "StreamingAssets" folder is copied to the WebGL's virtual filesystem. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * 
        * @param filepath a relative file path starting from the "StreamingAssets" folder.
        * @param completed a callback function that is called when the process is completed. Returns a readable file path in case of success and returns empty in case of error.
        * @param refresh [Android][WebGL] If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied.
        * @param timeout [Android 2017.1+][WebGL] Sets UnityWebRequest to attempt to abort after the number of seconds in timeout has passed. No timeout is applied when timeout is set to 0 and this property defaults to 0. 
        * @return returns an IEnumerator object. Yielding the IEnumerator inside a coroutine will cause the coroutine to pause until the UnityWebRequest encounters a system error or finishes communicating.
        */
        public static IEnumerator getFilePathAsync(string filepath, Action<string> completed, bool refresh = false, int timeout = 0)
        {
            return getFilePathAsync(filepath, completed, null, null, refresh, timeout);
        }

        /**
        * Gets the readable path of a file in the "StreamingAssets" folder by using coroutines.
        * <p>
        * <br>Set a relative file path from the starting point of the "StreamingAssets" folder.  e.g. "foobar.txt" or "hogehoge/foobar.txt".
        * <br>[Android] The target file that exists in the "StreamingAssets" folder is copied into the folder of the Application.persistentDataPath. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * <br>[WebGL] The target file in the "StreamingAssets" folder is copied to the WebGL's virtual filesystem. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * 
        * @param filepath a relative file path starting from the "StreamingAssets" folder.
        * @param completed a callback function that is called when the process is completed. Returns a readable file path in case of success and returns empty in case of error.
        * @param progressChanged a callback function that is called when the process is the progress. Returns the file path and a progress value (0.0 to 1.0).
        * @param refresh [Android][WebGL] If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied.
        * @param timeout [Android 2017.1+][WebGL] Sets UnityWebRequest to attempt to abort after the number of seconds in timeout has passed. No timeout is applied when timeout is set to 0 and this property defaults to 0. 
        * @return returns an IEnumerator object. Yielding the IEnumerator inside a coroutine will cause the coroutine to pause until the UnityWebRequest encounters a system error or finishes communicating.
        */
        public static IEnumerator getFilePathAsync(string filepath, Action<string> completed, Action<string, float> progressChanged, bool refresh = false, int timeout = 0)
        {
            return getFilePathAsync(filepath, completed, progressChanged, null, refresh, timeout);
        }

        /**
        * Gets the readable path of a file in the "StreamingAssets" folder by using coroutines.
        * <p>
        * <br>Set a relative file path from the starting point of the "StreamingAssets" folder.  e.g. "foobar.txt" or "hogehoge/foobar.txt".
        * <br>[Android] The target file that exists in the "StreamingAssets" folder is copied into the folder of the Application.persistentDataPath. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * <br>[WebGL] The target file in the "StreamingAssets" folder is copied to the WebGL's virtual filesystem. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * 
        * @param filepath a relative file path starting from the "StreamingAssets" folder.
        * @param completed a callback function that is called when the process is completed. Returns a readable file path in case of success and returns empty in case of error.
        * @param progressChanged a callback function that is called when the process is the progress. Returns the file path and a progress value (0.0 to 1.0).
        * @param errorOccurred a callback function that is called when the process is error occurred. Returns the file path and an error string and an error response code.
        * @param refresh [Android][WebGL] If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied.
        * @param timeout [Android 2017.1+][WebGL] Sets UnityWebRequest to attempt to abort after the number of seconds in timeout has passed. No timeout is applied when timeout is set to 0 and this property defaults to 0. 
        * @return returns an IEnumerator object. Yielding the IEnumerator inside a coroutine will cause the coroutine to pause until the UnityWebRequest encounters a system error or finishes communicating.
        */
        public static IEnumerator getFilePathAsync(string filepath, Action<string> completed, Action<string, float> progressChanged, Action<string, string, long> errorOccurred, bool refresh = false, int timeout = 0)
        {
#if (UNITY_ANDROID || UNITY_WEBGL) && !UNITY_EDITOR
            filepath = filepath.TrimStart (chTrims);

            string srcPath = Path.Combine(Application.streamingAssetsPath, filepath);
#if UNITY_ANDROID
            string destPath = Path.Combine(Application.persistentDataPath, "opencvforunity");
#else
            string destPath = Path.Combine(Path.AltDirectorySeparatorChar.ToString(), "opencvforunity");
#endif
            destPath = Path.Combine(destPath, filepath);

            if (!refresh && File.Exists(destPath)){
                if (progressChanged != null)
                    progressChanged (filepath, 0);
                yield return null;
                if (progressChanged != null)
                    progressChanged (filepath, 1);
                if (completed != null)
                    completed (destPath);
            } else {

#if UNITY_WEBGL || (UNITY_ANDROID && UNITY_2017_1_OR_NEWER)
                using (UnityEngine.Networking.UnityWebRequest request = UnityEngine.Networking.UnityWebRequest.Get (srcPath)) {

                    request.timeout = timeout;

#if UNITY_2018_2_OR_NEWER
                    request.SendWebRequest ();
#else
                    request.Send ();
#endif

                    while (!request.isDone) {

                        if (progressChanged != null)
                            progressChanged (filepath, request.downloadProgress);

                        yield return null;
                    }

                    if (progressChanged != null)
                        progressChanged (filepath, request.downloadProgress);

#if UNITY_2017_1_OR_NEWER
                    if (request.isHttpError || request.isNetworkError) {
#else
                    if (request.isError) {
#endif
                        Debug.LogWarning (request.error);
                        Debug.LogWarning (request.responseCode);

                        if (errorOccurred != null) {
                            errorOccurred (filepath, request.error, request.responseCode);
                        } else {
                            if (completed != null)
                                completed (String.Empty);
                        }
                        yield break;
                    }

                    //create Directory
                    String dirPath = Path.GetDirectoryName (destPath);
                    if (!Directory.Exists (dirPath))
                        Directory.CreateDirectory (dirPath);

                    File.WriteAllBytes (destPath, request.downloadHandler.data);
                }
#else

                using (WWW request = new WWW (srcPath)) {

                    while (!request.isDone) {
                        if (progressChanged != null)
                            progressChanged(filepath, request.progress);

                        yield return null;
                    }

                    if (progressChanged != null)
                        progressChanged (filepath, request.progress);

                    if (!string.IsNullOrEmpty(request.error)) {
                        Debug.LogWarning (request.error);

                        if (errorOccurred != null) {
                            errorOccurred (filepath, request.error, 0);
                        } else {
                            if (completed != null)
                                completed (String.Empty);
                        }
                        yield break;
                    }

                    //create Directory
                    String dirPath = Path.GetDirectoryName (destPath);
                    if (!Directory.Exists (dirPath))
                        Directory.CreateDirectory (dirPath);

                    File.WriteAllBytes(destPath, request.bytes);
                }
#endif
                if (completed != null)
                    completed (destPath);
            }
#else
            filepath = filepath.TrimStart(chTrims);

            string destPath = Path.Combine(Application.streamingAssetsPath, filepath);

            if (progressChanged != null)
                progressChanged(filepath, 0);
            yield return null;
            if (progressChanged != null)
                progressChanged(filepath, 1);

            if (File.Exists(destPath))
            {
                if (completed != null)
                    completed(destPath);
            }
            else
            {
                if (errorOccurred != null)
                {
                    errorOccurred(filepath, "Unknown Error", 0);
                }
                else
                {
                    if (completed != null)
                        completed(String.Empty);
                }
            }
#endif

            yield break;
        }

        /**
        * Gets the multiple readable paths of files in the "StreamingAssets" folder by using coroutines.
        * <p>
        * <br>Set a relative file path from the starting point of the "StreamingAssets" folder.  e.g. "foobar.txt" or "hogehoge/foobar.txt".
        * <br>[Android] The target file that exists in the "StreamingAssets" folder is copied into the folder of the Application.persistentDataPath. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * <br>[WebGL] The target file in the "StreamingAssets" folder is copied to the WebGL's virtual filesystem. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * 
        * @param filepaths an array of relative file paths starting from the "StreamingAssets" folder.
        * @param allCompleted a callback function that is called when the process is completed. Returns an array of readable file paths.
        * @param refresh [Android][WebGL] If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied.
        * @param timeout [Android 2017.1+][WebGL] Sets UnityWebRequest to attempt to abort after the number of seconds in timeout has passed. No timeout is applied when timeout is set to 0 and this property defaults to 0. 
        * @return returns an IEnumerator object. Yielding the IEnumerator inside a coroutine will cause the coroutine to pause until the UnityWebRequest encounters a system error or finishes communicating.
        */
        public static IEnumerator getMultipleFilePathsAsync(string[] filepaths, Action<string[]> allCompleted, bool refresh = false, int timeout = 0)
        {
            return getMultipleFilePathsAsync(filepaths, allCompleted, null, null, refresh, timeout);
        }

        /**
        * Gets the multiple readable paths of files in the "StreamingAssets" folder by using coroutines.
        * <p>
        * <br>Set a relative file path from the starting point of the "StreamingAssets" folder.  e.g. "foobar.txt" or "hogehoge/foobar.txt".
        * <br>[Android] The target file that exists in the "StreamingAssets" folder is copied into the folder of the Application.persistentDataPath. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * <br>[WebGL] The target file in the "StreamingAssets" folder is copied to the WebGL's virtual filesystem. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * 
        * @param filepaths an array of relative file paths starting from the "StreamingAssets" folder.
        * @param allCompleted a callback function that is called when the process is completed. Returns an array of readable file paths.
        * @param progressChanged a callback function that is called when the process is the progress. Returns the file path and a progress value (0.0 to 1.0).
        * @param refresh [Android][WebGL] If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied.
        * @param timeout [Android 2017.1+][WebGL] Sets UnityWebRequest to attempt to abort after the number of seconds in timeout has passed. No timeout is applied when timeout is set to 0 and this property defaults to 0. 
        * @return returns an IEnumerator object. Yielding the IEnumerator inside a coroutine will cause the coroutine to pause until the UnityWebRequest encounters a system error or finishes communicating.
        */
        public static IEnumerator getMultipleFilePathsAsync(string[] filepaths, Action<string[]> allCompleted, Action<string, float> progressChanged, bool refresh = false, int timeout = 0)
        {
            return getMultipleFilePathsAsync(filepaths, allCompleted, progressChanged, null, refresh, timeout);
        }

        /**
        * Gets the multiple readable paths of files in the "StreamingAssets" folder by using coroutines.
        * <p>
        * <br>Set a relative file path from the starting point of the "StreamingAssets" folder.  e.g. "foobar.txt" or "hogehoge/foobar.txt".
        * <br>[Android] The target file that exists in the "StreamingAssets" folder is copied into the folder of the Application.persistentDataPath. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * <br>[WebGL] The target file in the "StreamingAssets" folder is copied to the WebGL's virtual filesystem. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied. 
        * 
        * @param filepaths an array of relative file paths starting from the "StreamingAssets" folder.
        * @param allCompleted a callback function that is called when the process is completed. Returns an array of readable file paths.
        * @param progressChanged a callback function that is called when the process is the progress. Returns the file path and a progress value (0.0 to 1.0).
        * @param errorOccurred a callback function that is called when the process is error occurred. Returns the file path and an error string and an error response code.
        * @param refresh [Android][WebGL] If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copied.
        * @param timeout [Android 2017.1+][WebGL] Sets UnityWebRequest to attempt to abort after the number of seconds in timeout has passed. No timeout is applied when timeout is set to 0 and this property defaults to 0. 
        * @return returns an IEnumerator object. Yielding the IEnumerator inside a coroutine will cause the coroutine to pause until the UnityWebRequest encounters a system error or finishes communicating.
        */
        public static IEnumerator getMultipleFilePathsAsync(string[] filepaths, Action<string[]> allCompleted, Action<string, float> progressChanged, Action<string, string, long> errorOccurred, bool refresh = false, int timeout = 0)
        {
            string[] readableFilePaths = new string[filepaths.Length];

            for (int i = 0; i < filepaths.Length; i++)
            {
                yield return getFilePathAsync(filepaths[i], (result) =>
                {
                    readableFilePaths[i] = result;
                }, progressChanged, errorOccurred, refresh, timeout);
            }

            if (allCompleted != null)
                allCompleted(readableFilePaths);
        }

        private static char[] chTrims = {
            '.',
            #if UNITY_WINRT_8_1 && !UNITY_EDITOR
            '/',
            '\\'
            #else
            System.IO.Path.DirectorySeparatorChar,
            System.IO.Path.AltDirectorySeparatorChar
            #endif
        };

        /// <summary>
        /// if true, CvException is thrown instead of calling Debug.LogError (msg).
        /// </summary>
#pragma warning disable 0414
        private static bool throwOpenCVException = false;
#pragma warning restore 0414

        /**
        * Sets the debug mode.
        * <p>
        * <br>if debugMode is true, The error log of the Native side OpenCV will be displayed on the Unity Editor Console.However, if throwException is true, CvException is thrown instead of calling Debug.LogError (msg).
        * <br>Please use as follows.
        * <br>Utils.setDebugMode(true);
        * <br>aaa
        * <br>bbb
        * <br>ccc
        * <br>Utils.setDebugMode(false);
        * 
        * @param debugMode if true, The error log of the Native side OpenCV will be displayed on the Unity Editor Console.
        * @param throwException if true, CvException is thrown instead of calling Debug.LogError (msg).
        */
        public static void setDebugMode(bool debugMode, bool throwException = false)
        {
#if UNITY_5_3_OR_NEWER
            OpenCVForUnity_SetDebugMode (debugMode);

            if (debugMode) {
                OpenCVForUnity_SetDebugLogFunc (debugLogFunc);
//                              OpenCVForUnity_DebugLogTest ();
            } else {
                OpenCVForUnity_SetDebugLogFunc (null);
            }
            
            throwOpenCVException = throwException;
           
#endif
        }

#if UNITY_5_3_OR_NEWER

        private delegate void DebugLogDelegate (string str);

        [MonoPInvokeCallback (typeof(DebugLogDelegate))]
        private static void debugLogFunc (string str)
        {
            if (throwOpenCVException) {
                throw new CvException (str);
            } else {
                Debug.LogError (str);
            }
        }

#endif

        internal static int URShift(int number, int bits)
        {
            if (number >= 0)
                return number >> bits;
            else
                return (number >> bits) + (2 << ~bits);
        }

        internal static long URShift(long number, int bits)//TODO:@check
        {
            if (number >= 0)
                return number >> bits;
            else
                return (number >> bits) + (2 << ~bits);
        }

        internal static int HashContents<T>(this IEnumerable<T> enumerable)//TODO:@check
        {
            int hash = 0x218A9B2C;
            foreach (var item in enumerable)
            {
                int thisHash = item.GetHashCode();
                //mix up the bits.
                hash = thisHash ^ ((hash << 5) + hash);
            }
            return hash;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif

        [DllImport(LIBNAME)]
        private static extern void OpenCVForUnity_SetDebugMode([MarshalAs(UnmanagedType.U1)] bool flag);

        [DllImport(LIBNAME)]
        private static extern void OpenCVForUnity_SetDebugLogFunc(DebugLogDelegate func);

        [DllImport(LIBNAME)]
        private static extern void OpenCVForUnity_DebugLogTest();

        [DllImport(LIBNAME)]
        private static extern void OpenCVForUnity_MatToTexture(IntPtr mat, IntPtr textureColors, [MarshalAs(UnmanagedType.U1)] bool flip, int flipCode, bool flipAfter);

        [DllImport(LIBNAME)]
        private static extern void OpenCVForUnity_TextureToMat(IntPtr textureColors, IntPtr Mat, [MarshalAs(UnmanagedType.U1)] bool flip, int flipCode);

        [DllImport(LIBNAME)]
        private static extern void OpenCVForUnity_MatDataToByteArray(IntPtr mat, IntPtr byteArray);

        [DllImport(LIBNAME)]
        private static extern void OpenCVForUnity_ByteArrayToMatData(IntPtr byteArray, IntPtr Mat);


        [DllImport(LIBNAME)]
        private static extern void OpenCVForUnity_SetTextureFromUnity(System.IntPtr texture, int width, int height, int bytesPerPixel);

        [DllImport(LIBNAME)]
        private static extern void OpenCVForUnity_SetByteArrayFromUnity(System.IntPtr byteArray, int width, int height, int bytesPerPixel);

        [DllImport(LIBNAME)]
        private static extern IntPtr OpenCVForUnity_GetRenderEventFunc();

#if UNITY_WEBGL && !UNITY_EDITOR
        private static bool isWebGLPluginRegistered = false;

        [DllImport(LIBNAME)]
        private static extern void OpenCVForUnity_RegisterPlugin();
#endif

    }
}
