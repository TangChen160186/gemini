using System.Windows.Input;

namespace Gemini.Modules.MainMenu.Models
{
    public abstract class StandardMenuItem : MenuItemBase
    {
        public abstract string Text { get; }
        public abstract string PathData { get; }
        public abstract string PathDataForegroundName { get; }
        public abstract string InputGestureText { get; }
        public abstract ICommand Command { get; }
        public abstract bool IsChecked { get; }
        public abstract bool IsVisible { get; }
    }
}
