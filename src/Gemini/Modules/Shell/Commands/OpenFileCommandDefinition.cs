using System;
using System.ComponentModel.Composition;
using System.Windows.Input;
using Gemini.Framework.Commands;
using Gemini.Properties;

namespace Gemini.Modules.Shell.Commands
{
    [CommandDefinition]
    public class OpenFileCommandDefinition : CommandDefinition
    {
        public const string CommandName = "File.OpenFile";

        public override string Name
        {
            get { return CommandName; }
        }

        public override string Text
        {
            get { return Resources.FileOpenCommandText; }
        }

        public override string ToolTip
        {
            get { return Resources.FileOpenCommandToolTip; }
        }

        public override string PathData =>
            "M250 187.5A12.5 12.5 0 0 1 237.5 200H142.6875L136.8 216.675A12.5125 12.5125 0 0 1 125 225H62.5A12.5 12.5 0 0 1 50 212.5V187.5H250zM250 162.5H50V87.5A12.5 12.5 0 0 1 62.5 75H237.5A12.5 12.5 0 0 1 250 87.5V162.5zM160.375 225H237.5A37.5 37.5 0 0 0 275 187.5V87.5A37.5 37.5 0 0 0 237.5 50H62.5A37.5 37.5 0 0 0 25 87.5V212.5A37.5 37.5 0 0 0 62.5 250H125C141.325 250 155.2125 239.5625 160.375 225z";

        public override string PathDataForegroundName => "OpenFileBrush";

        [Export]
        public static CommandKeyboardShortcut KeyGesture = new CommandKeyboardShortcut<OpenFileCommandDefinition>(new KeyGesture(Key.O, ModifierKeys.Control));
    }
}
