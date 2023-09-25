#if UNITY_5 || UNITY_5_3_OR_NEWER
using UnityEngine;
using UnityEditor;

using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;

namespace OpenCVForUnity
{
    class OpenCVForUnityMenuItem : MonoBehaviour
    {

        /// <summary>
        /// Open OpenCV for Unity API Reference.
        /// </summary>
        [MenuItem ("Tools/OpenCV for Unity/Open OpenCV for Unity API Reference", false, 12)]
        public static void OpenOpenCVForUnityAPIReference ()
        {
            Application.OpenURL ("http://enoxsoftware.github.io/OpenCVForUnity/3.0.0/doc/html/index.html");
        }

        /// <summary>
        /// Open OpenCV C++ API Reference.
        /// </summary>
        [MenuItem ("Tools/OpenCV for Unity/Open OpenCV C++ API Reference", false, 13)]
        public static void OpenOpenCVAPIReference ()
        {
            Application.OpenURL ("http://docs.opencv.org/3.3.0/index.html");
        }


        /// <summary>
        /// Sets the plugin import settings.
        /// </summary>
        [MenuItem ("Tools/OpenCV for Unity/Set Plugin Import Settings", false, 1)]
        public static void SetPluginImportSettings ()
        {
            string[] guids = UnityEditor.AssetDatabase.FindAssets ("OpenCVForUnityMenuItem");
            if (guids.Length == 0) {
                Debug.LogWarning ("SetPluginImportSettings Faild : OpenCVForUnityMenuItem.cs is missing.");
                return;
            }
            string opencvForUnityFolderPath = AssetDatabase.GUIDToAssetPath (guids [0]).Substring (0, AssetDatabase.GUIDToAssetPath (guids [0]).LastIndexOf ("Editor/OpenCVForUnityMenuItem.cs"));

            string pluginsFolderPath = opencvForUnityFolderPath + "Plugins";
//            Debug.Log ("pluginsFolderPath " + pluginsFolderPath);

            string extraFolderPath = opencvForUnityFolderPath + "Extra";
//            Debug.Log ("extraFolderPath " + extraFolderPath);


            //Disable Extra folder
            SetPlugins (GetPluginFilePaths (extraFolderPath + "/exclude_contrib/Android/libs/armeabi-v7a"), null, null);
            SetPlugins (GetPluginFilePaths (extraFolderPath + "/exclude_contrib/Android/libs/x86"), null, null);
            SetPlugins (GetPluginFilePaths (extraFolderPath + "/exclude_contrib/Android/libs/arm64-v8a"), null, null);
            SetPlugins (new string[] { extraFolderPath + "/exclude_contrib/iOS/opencv2.framework" }, null, null);
            SetPlugins (GetPluginFilePaths (extraFolderPath + "/exclude_contrib/iOS"), null, null);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/dll_version/Android/libs/armeabi-v7a"), null, null);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/dll_version/Android/libs/x86"), null, null);
            SetPlugins(GetPluginFilePaths(extraFolderPath + "/dll_version/Android/libs/arm64-v8a"), null, null);
            SetPlugins(new string[] { extraFolderPath + "/dll_version/Windows/x86/opencvforunity.dll" }, null,null);
            SetPlugins(new string[] { extraFolderPath + "/dll_version/Windows/x86_64/opencvforunity.dll" },null,null);


            //Android
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/Android/libs/armeabi-v7a"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>> () { {BuildTarget.Android,new Dictionary<string, string> () { {
                                "CPU",
                                "ARMv7"
                            }
                        }
                    }
                });
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/Android/libs/x86"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>> () { {BuildTarget.Android,new Dictionary<string, string> () { {
                                "CPU",
                                "x86"
                            }
                        }
                    }
                });
#if UNITY_2018_1_OR_NEWER
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/Android/libs/arm64-v8a"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>> () { {BuildTarget.Android,new Dictionary<string, string> () { {
                                "CPU",
                                "ARM64"
                            }
                        }
                    }
                });
#else
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/Android/libs/arm64-v8a"), null, null);
#endif
            
            //iOS
            SetPlugins (new string[] { pluginsFolderPath + "/iOS/opencv2.framework" }, null,
                new Dictionary<BuildTarget, Dictionary<string, string>> () { {
                        BuildTarget.iOS,
                        new Dictionary<string, string> () { {
                                "AddToEmbeddedBinaries",
                                "true"
                            }
                        }
                    }
                });
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/iOS"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>> () { {
                        BuildTarget.iOS,
                        null
                    }
                });
            
            //OSX
            SetPlugins (new string[] { pluginsFolderPath + "/macOS/opencvforunity.bundle" }, new Dictionary<string, string> () { {
                    "CPU",
                    "AnyCPU"
                }, {
                    "OS",
                    "OSX"
                }
            },
                new Dictionary<BuildTarget, Dictionary<string, string>> () {
#if UNITY_2017_3_OR_NEWER
                    {
                        BuildTarget.StandaloneOSX,new Dictionary<string, string> () { {
                                "CPU",
                                "AnyCPU"
                            }
                        }
                    }
#else
                    {
                        BuildTarget.StandaloneOSXIntel,new Dictionary<string, string> () { {
                                "CPU",
                                "x86"
                            }
                        }
                    }, {
                        BuildTarget.StandaloneOSXIntel64,new Dictionary<string, string> () { {
                                "CPU",
                                "x86_64"
                            }
                        }
                    }, {
                        BuildTarget.StandaloneOSXUniversal,new Dictionary<string, string> () { {
                                "CPU",
                                "AnyCPU"
                            }
                        }
                    }
#endif
                });
            
            //Windows
            SetPlugins (new string[] { pluginsFolderPath + "/Windows/x86/opencvforunity.dll" }, new Dictionary<string, string> () { {
                    "CPU",
                    "x86"
                }, {
                    "OS",
                    "Windows"
                }
            },
                new Dictionary<BuildTarget, Dictionary<string, string>> () { {BuildTarget.StandaloneWindows,new Dictionary<string, string> () { {
                                "CPU",
                                "x86"
                            }
                        }
                    }
                });
            SetPlugins (new string[] { pluginsFolderPath + "/Windows/x86_64/opencvforunity.dll" }, new Dictionary<string, string> () { {
                    "CPU",
                    "x86_64"
                }, {
                    "OS",
                    "Windows"
                }
            },
                new Dictionary<BuildTarget, Dictionary<string, string>> () { {BuildTarget.StandaloneWindows64,new Dictionary<string, string> () { {
                                "CPU",
                                "x86_64"
                            }
                        }
                    }
                });
            
            //Linux
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/Linux/x86"), new Dictionary<string, string> () { {
                    "CPU",
                    "x86"
                }, {
                    "OS",
                    "Linux"
                }
            },
                new Dictionary<BuildTarget, Dictionary<string, string>> () { {BuildTarget.StandaloneLinux,new Dictionary<string, string> () { {
                                "CPU",
                                "x86"
                            }
                        }
                    },
                });
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/Linux/x86_64"), new Dictionary<string, string> () { {
                    "CPU",
                    "x86_64"
                }, {
                    "OS",
                    "Linux"
                }
            },
                new Dictionary<BuildTarget, Dictionary<string, string>> () { {BuildTarget.StandaloneLinux64,new Dictionary<string, string> () { {
                                "CPU",
                                "x86_64"
                            }
                        }
                    },
                });
            
            
            //UWP
            #if UNITY_5_0 || UNITY_5_1
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/WSA/UWP/ARM"), null, null);
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/WSA/UWP/x64"), null, null);
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/WSA/UWP/x86"), null, null);
            #else
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/WSA/UWP/ARM"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>> () { {BuildTarget.WSAPlayer,new Dictionary<string, string> () { {
                                "SDK",
                                "UWP"
                            }, {
                                "CPU",
                                "ARM"
                            }
                        }
                    }
                });
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/WSA/UWP/x64"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>> () { {BuildTarget.WSAPlayer,new Dictionary<string, string> () { {
                                "SDK",
                                "UWP"
                            }, {
                                "CPU",
                                "x64"
                            }
                        }
                    }
                });
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/WSA/UWP/x86"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>> () { {BuildTarget.WSAPlayer,new Dictionary<string, string> () { {
                                "SDK",
                                "UWP"
                            }, {
                                "CPU",
                                "x86"
                            }
                        }
                    }
                });
            #endif
            
            //WebGL
            SetPlugins (new string[] { pluginsFolderPath + "/WebGL/5.6/opencvforunity.bc" }, null, null);
            SetPlugins (new string[] { pluginsFolderPath + "/WebGL/2018.2/opencvforunity.bc" }, null, null);
            SetPlugins (new string[] { pluginsFolderPath + "/WebGL/2019.1/opencvforunity.bc" }, null, null);
            #if UNITY_2019_1_OR_NEWER
            SetPlugins (new string[] { pluginsFolderPath + "/WebGL/2019.1/opencvforunity.bc" }, null, new Dictionary<BuildTarget, Dictionary<string, string>> () { {
                    BuildTarget.WebGL,
                    null
                }
            });
            #elif UNITY_2018_2_OR_NEWER
            SetPlugins (new string[] { pluginsFolderPath + "/WebGL/2018.2/opencvforunity.bc" }, null, new Dictionary<BuildTarget, Dictionary<string, string>> () { {
                    BuildTarget.WebGL,
                    null
                }
            });
            #elif UNITY_5_6_OR_NEWER
            SetPlugins (new string[] { pluginsFolderPath + "/WebGL/5.6/opencvforunity.bc" }, null, new Dictionary<BuildTarget, Dictionary<string, string>> () { {
                    BuildTarget.WebGL,
                    null
                }
            });
#endif


            //Lumin
#if UNITY_2019_1_OR_NEWER
            SetPlugins (GetPluginFilePaths (pluginsFolderPath + "/Lumin/libs/arm64-v8a"), null,
                new Dictionary<BuildTarget, Dictionary<string, string>> () { {BuildTarget.Lumin,new Dictionary<string, string> () { {
                                "CPU",
                                "ARM64"
                            }
                        }
                    }
                });
#else
            SetPlugins(GetPluginFilePaths(pluginsFolderPath + "/Lumin/libs/arm64-v8a"), null, null);
#endif
        }

        /// <summary>
        /// Gets the plugin file paths.
        /// </summary>
        /// <returns>The plugin file paths.</returns>
        /// <param name="folderPath">Folder path.</param>
        static string[] GetPluginFilePaths (string folderPath)
        {
            Regex reg = new Regex (".meta$|.DS_Store$|.zip");
            try {
                return Directory.GetFiles (folderPath).Where (f => !reg.IsMatch (f)).ToArray ();
            } catch (Exception ex) {
                Debug.LogWarning ("SetPluginImportSettings Faild :" + ex);
                return null;
            }
        }

        /// <summary>
        /// Sets the plugins.
        /// </summary>
        /// <param name="files">Files.</param>
        /// <param name="editorSettings">Editor settings.</param>
        /// <param name="settings">Settings.</param>
        public static void SetPlugins (string[] files, Dictionary<string, string> editorSettings, Dictionary<BuildTarget, Dictionary<string, string>> settings)
        {
            if (files == null)
                return;
            
            foreach (string item in files) {
                
                PluginImporter pluginImporter = PluginImporter.GetAtPath (item) as PluginImporter;
                
                if (pluginImporter != null) {
                    
                    pluginImporter.SetCompatibleWithAnyPlatform (false);
                    pluginImporter.SetCompatibleWithEditor (false);
                    pluginImporter.SetCompatibleWithPlatform (BuildTarget.Android, false);
                    pluginImporter.SetCompatibleWithPlatform (BuildTarget.iOS, false);
                    pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneWindows, false);
                    pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneWindows64, false);
#if UNITY_2017_3_OR_NEWER
                    pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneOSX, false);
#else
                    pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneOSXIntel, false);
                    pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneOSXIntel64, false);
                    pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneOSXUniversal, false);
#endif
                    pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneLinux, false);
                    pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneLinux64, false);
                    pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneLinuxUniversal, false);
                    pluginImporter.SetCompatibleWithPlatform (BuildTarget.WSAPlayer, false);
                    pluginImporter.SetCompatibleWithPlatform (BuildTarget.WebGL, false);
                    
                    
                    if (editorSettings != null) {
                        pluginImporter.SetCompatibleWithEditor (true);
                        
                        
                        foreach (KeyValuePair<string, string> pair in editorSettings) {
                            if (pluginImporter.GetEditorData (pair.Key) != pair.Value) {
                                pluginImporter.SetEditorData (pair.Key, pair.Value);
                            }
                        }
                    }
                    
                    if (settings != null) {
                        foreach (KeyValuePair<BuildTarget, Dictionary<string, string>> settingPair in settings) {
                            
                            pluginImporter.SetCompatibleWithPlatform (settingPair.Key, true);
                            if (settingPair.Value != null) {
                                foreach (KeyValuePair<string, string> pair in settingPair.Value) {
                                    if (pluginImporter.GetPlatformData (settingPair.Key, pair.Key) != pair.Value) {
                                        pluginImporter.SetPlatformData (settingPair.Key, pair.Key, pair.Value);
                                    }
                                }
                            }
                            
                        }

#if UNITY_2019_1_OR_NEWER
                        pluginImporter.isPreloaded = true;
#endif
                    }
                    else {
                        pluginImporter.SetCompatibleWithPlatform (BuildTarget.Android, false);
                        pluginImporter.SetCompatibleWithPlatform (BuildTarget.iOS, false);
                        pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneWindows, false);
                        pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneWindows64, false);
#if UNITY_2017_3_OR_NEWER
                        pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneOSX, false);
#else
                        pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneOSXIntel, false);
                        pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneOSXIntel64, false);
                        pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneOSXUniversal, false);
#endif
                        pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneLinux, false);
                        pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneLinux64, false);
                        pluginImporter.SetCompatibleWithPlatform (BuildTarget.StandaloneLinuxUniversal, false);
                        pluginImporter.SetCompatibleWithPlatform (BuildTarget.WSAPlayer, false);
                        pluginImporter.SetCompatibleWithPlatform (BuildTarget.WebGL, false);

#if UNITY_2019_1_OR_NEWER
                        pluginImporter.isPreloaded = false;
#endif
                    }


                    pluginImporter.SaveAndReimport ();
                    
                    Debug.Log ("SetPluginImportSettings Success :" + item);
                } else {
                    Debug.LogWarning ("SetPluginImportSettings Faild :" + item);
                }
            }
        }
    }
}
#endif