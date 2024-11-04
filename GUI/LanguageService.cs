using System;
using System.Globalization;
using System.Resources;
using System.Threading;
namespace GUI
{
    public static class LanguageService
    {
        public static event Action LanguageChanged;

        private static ResourceManager resManager = new ResourceManager("GUI.Resources", typeof(LanguageService).Assembly);
        private static CultureInfo currentCulture = new CultureInfo("vi"); // Mặc định là Tiếng Việt

        public static void ChangeLanguage(string languageCode)
        {
            currentCulture = new CultureInfo(languageCode);
            Thread.CurrentThread.CurrentUICulture = currentCulture;

            // Thông báo cho tất cả các form (subscribers) về thay đổi ngôn ngữ
            LanguageChanged?.Invoke();
        }

        public static string GetString(string key)
        {
            return resManager.GetString(key, currentCulture);
        }
    }
}
