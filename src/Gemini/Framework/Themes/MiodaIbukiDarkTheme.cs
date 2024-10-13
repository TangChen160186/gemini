using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Gemini.Framework.Themes;

[Export(typeof(ITheme))]
public class MiodaIbukiDarkTheme : ITheme
{
    public virtual string Name
    {
        get { return Properties.Resources.ThemeMiodaIbukiDarkName; }
    }

    public virtual IEnumerable<Uri> ApplicationResources
    {
        get
        {
            yield return new Uri("pack://application:,,,/AvalonDock.Themes.VS2013;component/DarkTheme.xaml");
            yield return new Uri("pack://application:,,,/Gemini;component/Themes/VS2013/MiodaIbukiDarkTheme.xaml");
        }
    }

    public virtual IEnumerable<Uri> MainWindowResources
    {
        get { yield break; }
    }
}

