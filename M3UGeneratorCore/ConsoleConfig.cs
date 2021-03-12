using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3UGeneratorCore
{
    public class ConsoleConfig
    {
        /// <summary>
        /// Full Console Name.
        /// Mainly so the user can verify it's the one they want
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The extension of the files to be included in the .m3u.
        /// </summary>
        /// <example>
        /// For PSX it's .cue while for PS2 it's .iso
        /// </example>
        public string DiscExtension { get; set; }

        /// <summary>
        /// The extension of the files that contain the Disc Data.
        /// </summary>
        /// <example>
        /// For PSX it's .bin while for PS2 it's .iso
        /// </example>
        public string DiscDataExtension { get; set; }
    }
}