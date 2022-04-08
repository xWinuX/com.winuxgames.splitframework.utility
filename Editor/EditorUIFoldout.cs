using UnityEditor;
using UnityEngine;

namespace WinuXGames.SplitFramework.Utility.Editor
{
    public class EditorUIFoldout : EditorUIContainer
    {
        public bool Open    { get; set; }
        public bool Checked { get; set; }

        private readonly string _header;
        private readonly float  _indent;

        public EditorUIFoldout(string header, float indent = 0f)
        {
            _header = header;
            _indent = indent;
        }

        public override void Render()
        {
            EditorGUILayout.BeginVertical(_indent == 0 ? EditorStyles.helpBox : EditorStyles.label);
            EditorGUILayout.BeginHorizontal();
            GUILayout.Space(_indent * TabSize);
            EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);
            Checked = EditorGUILayout.Toggle(Checked, GUILayout.Width(20f));
            Open    = EditorGUILayout.Foldout(Open, _header);
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.EndHorizontal();

            if (Open) { base.Render(); }

            GUILayout.EndVertical();
        }
    }
}