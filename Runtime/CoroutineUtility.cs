using System;
using System.Collections;
using UnityEngine;

namespace WinuXGames.SplitFramework.Utility
{
    public static class CoroutineUtility
    {
        public static readonly YieldInstruction WaitForEndOfFrameInstruction = new WaitForEndOfFrame();

        public static IEnumerator WaitForEndOfFrame(Action action)
        {
            yield return WaitForEndOfFrameInstruction;
            action.Invoke();
        }
        
        public static IEnumerator WaitForOneFrame(Action action)
        {
            yield return null;
            action.Invoke();
        }
    }
}