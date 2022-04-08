using System;

namespace WinuXGames.SplitFramework.Utility.Editor
{
    public class UICustom : UIElement
    {
        private readonly Action _custom;
        public UICustom(Action custom)
        {
            _custom = custom;
        }
        
        public override void Render()
        {
            _custom.Invoke();
        }
    }
}