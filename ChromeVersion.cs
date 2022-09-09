using Microsoft.Win32;
using System.Diagnostics;
using System.IO;

namespace GetChromeVersion
{
    public class ChromeVersion
    {
        /// <summary>
        /// 获取谷歌浏览器版本
        /// </summary>
        /// <returns></returns>
        public static string GetChromeVersion()
        {
            //1.获取浏览器本地路径
            string dqPath = GetChromePath();
            //2.获取当前版本
            return GetChromeDqVersion(dqPath);
        }
        /// <summary>
        /// 获取浏览器路径
        /// </summary>
        /// <returns></returns>
        private static string GetChromePath()
        {
            RegistryKey regKey = Registry.ClassesRoot;
            string path = "";
            string chromeKey = "";
            foreach (var chrome in regKey.GetSubKeyNames())
            {
                if (chrome.ToUpper().Contains("CHROMEHTML"))
                {
                    chromeKey = chrome;
                }
            }
            if (!string.IsNullOrEmpty(chromeKey))
            {
                path = Registry.GetValue(@"HKEY_CLASSES_ROOT\" + chromeKey + @"\shell\open\command", null, null) as string;
                if (path != null)
                {
                    var split = path.Split('\"');
                    path = split.Length >= 2 ? split[1] : null;
                }
            }
            return path;
        }

        /// <summary>
        /// 获取浏览器版本
        /// </summary>
        /// <param name="chromePath"></param>
        /// <returns></returns>
        private static string GetChromeDqVersion(string chromePath)
        {
            string version = "";
            if (File.Exists(chromePath))
            {
                FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(chromePath);
                version = versionInfo.ProductVersion;
            }
            return version;
        }
    }
}
