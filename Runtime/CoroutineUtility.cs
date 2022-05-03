using System;
using System.Collections;
using UnityEngine;

namespace WinuXGames.SplitFramework.Utility
{
    public static class CoroutineUtility
    {
        public static IEnumerator WaitForOneFrame(Action action)
        {
            yield return new WaitForEndOfFrame();
            action.Invoke();
        }
    }
}