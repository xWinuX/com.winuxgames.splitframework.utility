using System.Collections.Generic;

namespace WinuXGames.SplitFramework.Utility.Editor
{
    public class EditorUIContainer : UIElement
    {
        private readonly List<UIElement> _children = new List<UIElement>();

        public void Add(UIElement uiElement)
        {
            uiElement.Parent = this;
            
            _children.Add(uiElement);
        }

        public void Clear()
        {
            foreach (UIElement uiElement in _children) { uiElement.Parent = null; }

            _children.Clear();
        }

        public override void Render()
        {
            foreach (UIElement uiElement in _children) { uiElement.Render(); }
        }
    }
}