namespace ClassLibrary1
{
    public static class Extensions
    {
        public static ConsoleConfig GetConfig(this EmulatedConsole grade)
        {
            return grade >= minPassing;
        }
    }
}