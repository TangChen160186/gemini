using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Gemini.Framework.Services;
using Gemini.Framework.Themes;
using Gemini.Framework.Utils;
using Gemini.Modules.MainMenu;
using Gemini.Modules.ToolBars;

namespace Gemini.Framework
{
	public abstract class ModuleBase : IModule
	{
#pragma warning disable 649

        [Import]
        private IThemeManager _themeManager;
        [Import]
        private IMainWindow _mainWindow;

        [Import]
        private IShell _shell;
#pragma warning restore 649

        protected IMainWindow MainWindow
	    {
	        get { return _mainWindow; }
	    }

		protected IShell Shell
		{
			get { return _shell; }
		}

		protected IMenu MainMenu
		{
			get { return _shell.MainMenu; }
		}

        protected IToolBars ToolBars
        {
            get { return _shell.ToolBars; }
        }

        public virtual IEnumerable<ResourceDictionary> GlobalResourceDictionaries
        {
            get { yield break; }
        }

        public virtual IEnumerable<KeyValuePair<string, IEnumerable<Uri>>> ThemeResourceDictionaries
        {
            get { yield break; }
        }

        private IEnumerable<KeyValuePair<string, IEnumerable<Uri>>> _autoLoadThemeResourceDictionaries = [];

        public IEnumerable<KeyValuePair<string, IEnumerable<Uri>>> AutoLoadThemeResourceDictionaries
            => _autoLoadThemeResourceDictionaries;

        public virtual IEnumerable<IDocument> DefaultDocuments
        {
            get { yield break; }
        }

	    public virtual IEnumerable<Type> DefaultTools
	    {
            get { yield break; }
	    }

        public virtual bool AutoLoadThemeResource { get; } = true;

        public virtual void PreInitialize()
        {
            if (AutoLoadThemeResource)
            {
                var result = new List<KeyValuePair<string, IEnumerable<Uri>>>();
                if (AutoLoadThemeResource)
                {
                    var assemblyName = this.GetType().Assembly.GetName().Name;
                    foreach (var theme in _themeManager.Themes)
                    {
                        List<Uri> uris = new List<Uri>();
                        result.Add(new KeyValuePair<string, IEnumerable<Uri>>(theme.Name, uris));

                        var uri1 = new Uri($"pack://application:,,,/{assemblyName};component/Themes/{theme.Name}.xaml");
                        if (ResourceUtility.ResourceUriExists(uri1))
                            uris.Add(uri1);

                        var uri2 = new Uri($"pack://application:,,,/{assemblyName};component/Themes/{theme.Name}Theme.xaml");
                        if (ResourceUtility.ResourceUriExists(uri2))
                            uris.Add(uri2);

                    }
                }
                _autoLoadThemeResourceDictionaries = result;
            }
           

     
        }

		public virtual void Initialize()
		{
		    
		}

        public virtual Task PostInitializeAsync()
        {
            return Task.CompletedTask;
        }

        
	}
}
