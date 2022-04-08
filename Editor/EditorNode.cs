using System.Collections.Generic;

namespace WinuXGames.SplitFramework.Utility.Editor
{
    public class EditorNode<T>
    {
        public          T                   Content { get; }
        public          EditorNode<T>       Parent  { get; internal set; }
        public readonly List<EditorNode<T>> Children = new List<EditorNode<T>>();

        public EditorNode(T content) { Content = content; }

        public void Add(EditorNode<T> node)
        {
            node.Parent = this;

            Children.Add(node);
        }

        public void Clear()
        {
            foreach (EditorNode<T> editorNode in Children) { editorNode.Parent = null; }

            Children.Clear();
        }
    }
}