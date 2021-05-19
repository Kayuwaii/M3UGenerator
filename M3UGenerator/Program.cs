using M3UGeneratorCore;
using System;
using System.IO;
using System.Threading.Channels;


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
            ParseParams(args); //Parse Parameters from console
            if (help)
            {
                ShowHelpAndClose();
            }

            M3UGeneratorCore.M3UGeneratorCore.SetConsole(selConsole);
            M3UGeneratorCore.M3UGeneratorCore.GenerateM3U(ogPath, outName, destPath, recursive);
        }

        private static void ShowHelpAndClose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Parses the user provided parameters.
        /// </summary>
        /// <param name="args">The console parameters</param>
        private static void ParseParams(string[] args)
        {
            foreach (var param in args)
            {
                if (param.StartsWith("-r")) recursive = true;
                else if (param.StartsWith("-h")) help = true;
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
                            if (!Enum.TryParse<EmulatedConsole>(parsedParam[1], false, out selConsole))
                            {
                                Console.WriteLine("Invalid value for --EmulationTarget");
                                return;
                            }

                            break;
                    }
                }
            }
        }
    }
}