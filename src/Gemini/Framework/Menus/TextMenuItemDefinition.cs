using System;
using System.Windows.Input;
using Gemini.Framework.Commands;

namespace Gemini.Framework.Menus
{
    public class TextMenuItemDefinition : MenuItemDefinition
    {
        private readonly string _text;
        private readonly Uri _iconSource;

        public override string Text => _text;
        public override string PathData { get; }
        public override string PathDataForegroundName { get; }


        public override KeyGesture KeyGesture => null;

        public override CommandDefinitionBase CommandDefinition => null;

        public TextMenuItemDefinition(MenuItemGroupDefinition group, int sortOrder, string text, string pathData = null,string pathDataForegroundName = null)
            : base(group, sortOrder)
        {
            _text = text;
            PathData = pathData;
            PathDataForegroundName = pathDataForegroundName;
        }
    }
}
