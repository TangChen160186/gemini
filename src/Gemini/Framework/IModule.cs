using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace Gemini.Framework
{
	public interface IModule
	{
        IEnumerable<ResourceDictionary> GlobalResourceDictionaries { get; }
        IEnumerable<KeyValuePair<string, IEnumerable<Uri>>> ThemeResourceDictionaries { get; }
        IEnumerable<KeyValuePair<string, IEnumerable<Uri>>> AutoLoadThemeResourceDictionaries { get; }
        IEnumerable<IDocument> DefaultDocuments { get; }
        IEnumerable<Type> DefaultTools { get; }
        bool AutoLoadThemeResource { get; }
        void PreInitialize();
		void Initialize();
        Task PostInitializeAsync();
	}
}
