﻿namespace SettingsModelWPFDemo
{
    using MsgBox;
    using ServiceLocator;
    using Settings;
    using Settings.Interfaces;

    /// <summary>
    /// Creates and initializes all services.
    /// </summary>
    public static class ServiceInjector
    {
        /// <summary>
        /// Loads service objects into the ServiceContainer on startup of application.
        /// </summary>
        /// <returns>Returns the current <seealso cref="ServiceContainer"/> instance
        /// to let caller work with service container items right after creation.</returns>
        public static ServiceContainer InjectServices()
        {
            ServiceContainer.Instance.AddService<IMessageBoxService>(new MessageBoxService());
            ServiceContainer.Instance.AddService<ISettingsManager>(new SettingsManager());

            return ServiceContainer.Instance;
        }
    }
}
