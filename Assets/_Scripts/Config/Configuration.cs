using Assets._Scripts.Translation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Config
{
    class Configuration
    {
        public static readonly Dictionary<Languages, string> TranslationFilePaths = new Dictionary<Languages, string>()
        {
            { Languages.English, "Translation/Default.json" },
            { Languages.Polish, "Translation/Polish.json" },
            { Languages.Spanish, "Translation/Spanish.json" }
        };
    }
}