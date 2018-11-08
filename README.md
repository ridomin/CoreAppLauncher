# CoreAppLauncher


When migrating Desktop apps to .NETCore 3.0  you might find this small util usefull. It allows to launch a NETFX app in the context of .NETCORE3.

If you want to launch your WPF app named `MyWPFApp` that has an `App.xaml` file as startup, you must create a .NET Core app and in the `Program.cs` file add the launcher:

```csharp
static class Program
{
  class MyApp : MyWPFApp.App, CoreAppLauncher.IIntializable{}

  [STAThread]
  static void Main()
  {
     CoreAppLauncher.Launcher.WPFLauncher(new MyApp());  
  }
}
```

NuGet package available at http://nuget.org/packages/Rido.CoreAppLauncher