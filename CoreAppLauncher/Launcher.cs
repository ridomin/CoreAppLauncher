using System;

namespace CoreAppLauncher
{
    public interface IIntializable
    {
        void InitializeComponent();
    }

    public class Launcher
    {
        public static void WPFLauncher<T>(T a) where T : System.Windows.Application, IIntializable
        {
            var baseTypeName = a.GetType().BaseType.Assembly.GetName().Name;
            a.InitializeComponent();
            var originalUri = a.StartupUri;
            a.StartupUri = new Uri($"/{baseTypeName};component/{originalUri.ToString()}", UriKind.Relative);
            a.Run();
        }
    }
    
}
