using System;

namespace Gemini.Framework.Commands
{
    public abstract class CommandDefinitionBase
    {
        public abstract string Name { get; }
        public abstract string Text { get; }
        public abstract string ToolTip { get; }

        public abstract string PathData { get; }
        public abstract string PathDataForegroundName { get; }
        public abstract bool IsList { get; }
    }
}
