using System;
using UnityEditor;
using UnityEngine;

namespace WinuXGames.SplitFramework.Utility.Editor
{
    public abstract class UIElement
    {
        public const float TabSize = 5;

        public UIElement Parent { get; internal set; }

        public abstract void Render();

        public static void WithIndent(float indent, Action layout)
        {
            GUILayout.BeginHorizontal();
            EditorGUILayout.Space(indent * TabSize, false);
            layout.Invoke();
            GUILayout.EndHorizontal();
        }
    }
}