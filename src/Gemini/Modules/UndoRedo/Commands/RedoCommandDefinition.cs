using System;
using System.ComponentModel.Composition;
using System.Windows.Input;
using Gemini.Framework.Commands;
using Gemini.Properties;

namespace Gemini.Modules.UndoRedo.Commands
{
    [CommandDefinition]
    public class RedoCommandDefinition : CommandDefinition
    {
        public const string CommandName = "Edit.Redo";

        public override string Name
        {
            get { return CommandName; }
        }

        public override string Text
        {
            get { return Resources.EditRedoCommandText; }
        }

        public override string ToolTip
        {
            get { return Resources.EditRedoCommandToolTip; }
        }

        public override string PathData => "M167.51,127.51,195,100H88a44,44,0,0,0,0,88h88a12,12,0,0,1,0,24H88A68,68,0,0,1,88,76H195L167.51,48.49a12,12,0,1,1,17-17l48,48a12,12,0,0,1,0,17l-48,48a12,12,0,0,1-17-17Z";

        public override string PathDataForegroundName => "RedoBrush";

        [Export]
        public static CommandKeyboardShortcut KeyGesture = new CommandKeyboardShortcut<RedoCommandDefinition>(new KeyGesture(Key.Y, ModifierKeys.Control));
    }
}
