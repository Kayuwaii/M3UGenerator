namespace M3UGeneratorCore
{
    internal static class Extensions
    {
        internal static ConsoleConfig GetConsoleConfig(this EmulatedConsole console)
        {
            return M3UGeneratorCore.ConsoleConfigurations[(int)console];
        }
    }
}