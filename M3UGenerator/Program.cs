using M3UGeneratorCore;
using System;
using System.IO;

namespace M3UGenerator
{
    public class M3UGenerator
    {
        private static bool recursive = false;
        private static bool help = false;
        private static string ogPath = Directory.GetCurrentDirectory();
        private static string destPath;
        private static string outName;
        private static EmulatedConsole selConsole;

        private static void Main(string[] args)
        {
            ParseParams(args);

            M3UGeneratorCore.M3UGeneratorCore.SetConsole(selConsole);
            M3UGeneratorCore.M3UGeneratorCore.GenerateM3U(ogPath, outName, destPath, recursive);
        }

        private static void ParseParams(string[] args)
        {
            foreach (var param in args)
            {
                if (param.StartsWith("-r")) recursive = true;
                if (param.StartsWith("-h")) help = true;
                else
                {
                    var parsedParam = param.Split("=");
                    switch (parsedParam[0])
                    {
                        case "--ROMDirectory":
                            ogPath = parsedParam[1];
                            break;

                        case "--FileName":
                            outName = parsedParam[1];
                            break;

                        case "--OutputDirectory":
                            destPath = parsedParam[1];
                            break;

                        case "--EmulationTarget":
                            try
                            {
                                selConsole = Enum.Parse<EmulatedConsole>(parsedParam[1]);
                            }
                            catch (Exception ex)
                            {
                            }
                            break;
                    }
                }
            }
        }
    }
}