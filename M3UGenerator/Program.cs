using M3UGeneratorCore;
using System;

namespace M3UGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            M3UGeneratorCore.M3UGeneratorCore.SetConsole(EmulatedConsole.PSX);
            M3UGeneratorCore.M3UGeneratorCore.GenerateM3U(@"G:\GAMES\ROMS\PSX\Xenogears");
        }
    }
}