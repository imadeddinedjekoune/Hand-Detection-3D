#if (UNITY_5 || UNITY_5_3_OR_NEWER) && UNITY_IOS
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;

using System.Diagnostics;

#if UNITY_2017_2_OR_NEWER
using UnityEditor.iOS.Xcode.Extensions;
#endif
using System;
using System.Collections;
using System.IO;

namespace OpenCVForUnity
{
    public class OpenCVForUnityIOSBuildPostprocessor : MonoBehaviour
    {
        
        [PostProcessBuild]
        public static void OnPostprocessBuild (BuildTarget buildTarget, string path)
        {
            if (buildTarget == BuildTarget.iOS) {

                string[] guids = UnityEditor.AssetDatabase.FindAssets ("OpenCVForUnityIOSBuildPostprocessor");
                if (guids.Length == 0) {
                    UnityEngine.Debug.LogWarning ("SetPluginImportSettings Faild : OpenCVForUnityIOSBuildPostprocessor.cs is missing.");
                    return;
                }
                string opencvForUnityFolderPath = AssetDatabase.GUIDToAssetPath (guids [0]).Substring ("Assets/".Length);
                opencvForUnityFolderPath = opencvForUnityFolderPath.Substring (0, opencvForUnityFolderPath.LastIndexOf ("Editor/OpenCVForUnityIOSBuildPostprocessor.cs"));


                if (PlayerSettings.iOS.sdkVersion == iOSSdkVersion.DeviceSDK) {
                    RemoveSimulatorArchitectures (path + "/Frameworks/"+opencvForUnityFolderPath+"Plugins/iOS/", "opencv2.framework/opencv2");
                    RemoveSimulatorArchitectures (path + "/Libraries/"+opencvForUnityFolderPath+"Plugins/iOS/", "libopencvforunity.a");
                }

#if UNITY_5_0 || UNITY_5_1 || UNITY5_2
                                string projPath = path + "/Unity-iPhone.xcodeproj/project.pbxproj";
#else
                string projPath = PBXProject.GetPBXProjectPath (path);
#endif
            
                PBXProject proj = new PBXProject ();
                proj.ReadFromString (System.IO.File.ReadAllText (projPath));
                    
#if UNITY_5_0 || UNITY_5_1 || UNITY5_2
                                string target = proj.TargetGuidByName ("Unity-iPhone");
#else
                string target = proj.TargetGuidByName (PBXProject.GetUnityTargetName ());
#endif

#if UNITY_2018_1_OR_NEWER

#elif UNITY_2017_2_OR_NEWER
                string frameworkPath = "Frameworks/"+opencvForUnityFolderPath+"Plugins/iOS/opencv2.framework";
                string fileGuid = proj.FindFileGuidByProjectPath(frameworkPath);

                proj.AddFileToBuild(target, fileGuid);
                proj.AddFileToEmbedFrameworks(target, fileGuid);
                foreach (var configName in proj.BuildConfigNames()) {
                    var configGuid = proj.BuildConfigByName(target, configName);
                    proj.SetBuildPropertyForConfig(configGuid, "LD_RUNPATH_SEARCH_PATHS", "$(inherited) @executable_path/Frameworks");
                }
#else
                UnityEngine.Debug.LogError ("If the version of Unity is less than 2017.2, you have to set opencv2.framework to Embedded Binaries manually.");
#endif

                File.WriteAllText (projPath, proj.WriteToString ());

#if UNITY_5_5_OR_NEWER
                if ((int)Convert.ToDecimal (PlayerSettings.iOS.targetOSVersionString) < 8) {
#else
                if ((int)PlayerSettings.iOS.targetOSVersion < (int)iOSTargetOSVersion.iOS_8_0) {
#endif
                    UnityEngine.Debug.LogError ("Please set Target minimum iOS Version to 8.0 or higher.");
                }

            }
        }

        /// <summary>
        /// Removes the simulator architectures.
        /// </summary>
        /// <param name="WorkingDirectory">Working directory.</param>
        /// <param name="filePath">File path.</param>
        private static void RemoveSimulatorArchitectures (string WorkingDirectory, string filePath)
        {
            Process process = new Process ();
            process.StartInfo.FileName = "/bin/bash";
            process.StartInfo.WorkingDirectory = WorkingDirectory;

            process.StartInfo.Arguments = "-c \" ";

            process.StartInfo.Arguments += "lipo -remove i386 " + filePath + " -o " + filePath + ";";
            process.StartInfo.Arguments += "lipo -remove x86_64 " + filePath + " -o " + filePath + ";";
            process.StartInfo.Arguments += "lipo -info " + filePath + ";";

            process.StartInfo.Arguments += " \"";

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.Start ();

            string output = process.StandardOutput.ReadToEnd ();
            string error = process.StandardError.ReadToEnd ();

            process.WaitForExit ();
            process.Close ();

            if (string.IsNullOrEmpty (error)) {
                UnityEngine.Debug.Log ("success : " + output);
            } else {
                UnityEngine.Debug.LogWarning ("error : " + error);
            }
        }
    }
}
#endif