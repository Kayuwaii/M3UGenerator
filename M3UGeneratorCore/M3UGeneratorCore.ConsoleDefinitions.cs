namespace M3UGeneratorCore
{
    /// <summary>
    /// This class holds configurations and values that may be accessed by other classes.
    /// It should only contain values and configuration or methods related to those.
    /// </summary>
    public static partial class M3UGeneratorCore
    {
        internal static ConsoleConfig[] ConsoleConfigurations =
        {
            new ConsoleConfig
            {
                FullName= "Sony - PlayStation",
                DiscExtension = ".cue",
                DiscDataExtension =".bin"
            },
            new ConsoleConfig
            {
                FullName = "Sony - PlayStation 2",
                DiscExtension = ".iso",
                DiscDataExtension =".iso"
            },
            new ConsoleConfig
            {
                FullName = "Nintendo - GameCube",
                DiscExtension = ".iso",
                DiscDataExtension =".iso"
            }
        };
    }
}