using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace WinuXGames.SplitFramework.Utility
{
    public static class SceneUtility
    {
        public static void GetCurrentlyLoadedScenesNonAlloc(ICollection<Scene> list)
        {
            list.Clear();

            for (int i = 0; i < SceneManager.sceneCount; i++) { list.Add(SceneManager.GetSceneAt(i)); }
        }
        
        public static void LoadScenes(IReadOnlyList<Scene> scenesToLoad, bool unloadOpen = true)
        {
            for (int i = 0; i < scenesToLoad.Count; i++)
            {
                Scene scene = scenesToLoad[i];
                SceneManager.LoadScene(scene.name,  i == 0 && unloadOpen ? LoadSceneMode.Single : LoadSceneMode.Additive);
            }
        }

    }
}