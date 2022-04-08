using UnityEngine;

namespace WinuXGames.SplitFramework.Utility.Editor
{
    public class EditorScrollView<T>
    {
        public Vector2 Scroll  { get; set; } = Vector2.zero;
        public T       Content { get; }

        public EditorScrollView(T content) { Content = content; }
    }
}