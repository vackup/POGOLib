namespace POGOLib.Logging
{
    /// <summary>
    /// This class contains the configuration for the POGOLib logger.
    /// </summary>
    public static class LoggerConfiguration
    {

        /// <summary>
        ///     Gets or sets the <see cref="MinimumLogLevel" /> for the <see cref="Logger"/>.
        /// </summary>
        public static LogLevel MinimumLogLevel { get; set; } = LogLevel.Debug;

    }
}
