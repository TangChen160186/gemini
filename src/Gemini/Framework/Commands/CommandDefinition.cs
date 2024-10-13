using System;

namespace Gemini.Framework.Commands
{
    public abstract class CommandDefinition : CommandDefinitionBase
    {
        
        public sealed override bool IsList
        {
            get { return false; }
        }

        public override string PathData
        {
            get { return null; }
        }

        public override string PathDataForegroundName
        {
            get { return null; }
        }
    }
}
