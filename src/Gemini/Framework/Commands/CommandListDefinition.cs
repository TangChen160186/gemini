using System;

namespace Gemini.Framework.Commands
{
    public abstract class CommandListDefinition : CommandDefinitionBase
    {
        public override sealed string Text
        {
            get { return "[NotUsed]"; }
        }

        public override sealed string ToolTip
        {
            get { return "[NotUsed]"; }
        }


        public override sealed bool IsList
        {
            get { return true; }
        }

        public override string PathData
        {
            get { return null; }
        }

        public override string PathDataForegroundName
        {
            get
            {
                return null;
            }
        }
    }
}
