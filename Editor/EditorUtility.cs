using UnityEditor;
using UnityEngine;

namespace WinuXGames.SplitFramework.Utility.Editor
{
    public static class EditorUtility
    {
        public const string AssetPath                  = "Assets/_SplitApart";
        public const string ScriptableObjectsPath      = AssetPath + "/ScriptableObjects";
        public const string CharacterScriptableObjects = ScriptableObjectsPath + "/Characters/";
        public const string DefaultLightningDataPath   = ScriptableObjectsPath + "/Environment/Default.asset";
        public const string BaseScenePath              = AssetPath+ "/Scenes/Base.unity";
        
        public static string AbsoluteToRelative(string path)
        {
            path = path.Replace('\\', '/');

            if (path.StartsWith(Application.dataPath)) { return "Assets" + path[Application.dataPath.Length..]; }

            return "";
        }

        public static bool PathIsRelative(string path) => path.StartsWith("Assets");

        public static T MenuCommandContextToType<T>(MenuCommand command) where T : Object => (T)command.context;
        
        public static T LoadAsset<T>(string path) where T : Object => (T)EditorGUIUtility.Load(PathIsRelative(path) ? path : AbsoluteToRelative(path));

    }
}