using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows;

namespace Gemini.Framework.Utils;

public static class ResourceUtility
{
    public static bool ResourceUriExists(Uri uri)
    {
        // 确保 URI 是相对 URI，并且以 "pack://" 开头
        if (uri != null && uri.IsAbsoluteUri && uri.Scheme == "pack")
        {
            try
            {
                // 使用 Application.GetResourceStream 检查资源
                var resourceInfo = Application.GetResourceStream(uri);
                return resourceInfo != null;
            }
            catch (IOException)
            {
                return false;
            }
        }
        return false;
    }
}
