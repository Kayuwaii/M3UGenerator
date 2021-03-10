using System;
using System.IO;
using System.Linq;

namespace M3UGeneratorCore
{
    /// <summary>
    /// This class holds all of the methods to generate files and interact with them.
    /// </summary>
    public static partial class M3UGeneratorCore
    {
        public static ConsoleConfig CurrentConsoleConfig { get; private set; }

        /// <summary>
        /// Sets the console to generate .m3u's for.
        /// </summary>
        /// <param name="selectedConsole">The desired console from the avaliable ones.</param>
        public static void SetConsole(EmulatedConsole selectedConsole)
        {
            CurrentConsoleConfig = selectedConsole.GetConsoleConfig();
        }

        /// <summary>
        /// Generates an .m3u file with the files in the specified directory
        /// </summary>
        /// <param name="DirToWork">A <see cref="String"/>representing the path of the desired directory</param>
        /// <param name="outName">The name for the generated file, defaults to the name of the directory.</param>
        /// <param name="outPath">The path to generate the file to, defaults to the DirToWork param.</param>
        public static void GenerateM3U(string _dirToWork, string _outName = null, string _outPath = null)
        {
            // Checks
            if (!Directory.Exists(_dirToWork)) throw new DirectoryNotFoundException(); // Verify directoy exists
            string[] _validFilesInDir = Directory.GetFiles(_dirToWork).Where(x => x.Contains(CurrentConsoleConfig.DiscExtension)).ToArray(); // Get all filenames
            if (_validFilesInDir.Length < 1) throw new FileNotFoundException(); // Verify that files exist
            // Since we verfied that everything we need exists we proceed

            // Set _out variables
            if (String.IsNullOrWhiteSpace(_outName))
            {
                var parPath = _dirToWork.Split(Path.DirectorySeparatorChar);
                _outName = parPath[parPath.Length - 1];
            }
            if (String.IsNullOrWhiteSpace(_outPath))
            {
                _outPath = String.Format("{0}{1}{2}.m3u", _dirToWork, Path.DirectorySeparatorChar, _outName);
            }

            FileStream createdFile = File.Create(_outPath);
            createdFile.Close();
            File.WriteAllLines(_outPath, _validFilesInDir);
        }
    }
}