using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace WinuXGames.SplitFramework.Utility.Editor
{
    public static class EditorUtility
    {
        public static string AssetPath                  => "Assets/_" + GetProjectName();
        public static string ScriptableObjectsPath      => AssetPath + "/ScriptableObjects";
        public static string CharacterScriptableObjects => ScriptableObjectsPath + "/Characters/";
        public static string DefaultLightningDataPath   => ScriptableObjectsPath + "/Environment/Default.asset";
        public static string BaseScenePath              => AssetPath + "/Scenes/Base.unity";

        public static string GetProjectName()
        {
            string[] s           = Application.dataPath.Split('/');
            string   projectName = s[^2];
            return projectName;
        }

        public static string AbsoluteToRelative(string path)
        {
            path = path.Replace('\\', '/');

            if (path.StartsWith(Application.dataPath)) { return "Assets" + path[Application.dataPath.Length..]; }

            return "";
        }

        public static void InstantiatePrefabFromResources(string path)
        {
            Object     o          = Resources.Load(path);
            GameObject gameObject = (GameObject)PrefabUtility.InstantiatePrefab(o);
            if (Selection.gameObjects.Length > 0) { gameObject.transform.SetParent(Selection.gameObjects[0].transform, false); }

            EditorSceneManager.MarkAllScenesDirty();
        }

        public static bool PathIsRelative(string path) => path.StartsWith("Assets");

        public static T MenuCommandContextToType<T>(MenuCommand command) where T : Object => (T)command.context;

        public static T LoadAsset<T>(string path) where T : Object => (T)EditorGUIUtility.Load(PathIsRelative(path) ? path : AbsoluteToRelative(path));
    }
}