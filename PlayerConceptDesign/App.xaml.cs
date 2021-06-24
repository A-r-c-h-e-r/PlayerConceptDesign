using System;
using System.Windows;
using System.Windows.Threading;
using PlayerConceptDesign.Settings;
using RIS.Logging;
using Syncfusion.Licensing;

namespace PlayerConceptDesign
{
    public partial class App : Application
    {
        public App()
        {
            SyncfusionLicenseProvider.RegisterLicense(
                "NDQyNTYyQDMxMzkyZTMxMmUzMGhDMnNRUVlmVUFhMmJjMzcrelNKa0c5Z2NBUVZPWGxRV2FYSlU5UUJYeUk9");

            LogManager.Initialize();

            DispatcherUnhandledException += OnDispatcherUnhandledException;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            LogManager.DeleteLogs(SettingsManager.AppSettings
                .LogRetentionDaysPeriod);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            SettingsManager.AppSettings.Save();

            base.OnExit(e);
        }

        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            LogManager.Log.Fatal($"{e.Exception?.GetType().Name ?? "Unknown"} - Message={e.Exception?.Message ?? "Unknown"},HResult={e.Exception?.HResult.ToString() ?? "Unknown"},StackTrace=\n{e.Exception?.StackTrace ?? "Unknown"}");
        }
    }
}
