using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableRegistratorCommon
{
    public class Configuration
    {
        private const string _configFile = "PortableRegistrator.conf";
        public string ConfigFile { get { return _configFile; } }

        // STATICS
        internal static Configuration CreateDefault()
        {
            var config = new Configuration();

            // Defaults
            // ----------------
            // Contributors:
            //   - Holgi (Deskmodder: https://www.deskmodder.de/phpBB3/viewtopic.php?t=27857)
            //   - psorincatalin

            var mediaplayer = new AppType("Generic Media-Player")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".m3u8", ".mp4", },
                //URLAssociations = new List<string>() { "m3u8", "mp4" }   // REMOVED, no making sense to me
            };
            config.AppTypes.Add(mediaplayer);

            var browser = new AppType("Generic Web-Browser")
            {
                //PropertiesParameter = "-preferences",
                OpenParameters = "-url \"%1\"",
                FileAssociations = new List<string>() { ".htm", ".html", ".shtml", ".xht", ".xhtml", },
                URLAssociations = new List<string>() { "http", "https", "ftp", }
            };
            config.AppTypes.Add(browser);

            var mail = new AppType("Generic Mail-Program")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".xpi", ".eml", ".msg", ".ics", ".mbox" },
                URLAssociations = new List<string>() { "mailto", }
            };
            config.AppTypes.Add(mail);

            var vlcPlayer = new AppType("VLC-Player")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() {
                    ".3ga",".669",".a52",".aac",".ac3",".adt",".adts",".aif",".aifc",".aiff",".au",".amr",".aob",
                    ".ape",".caf",".cda",".dts",".flac",".it",".m4a",".m4p",".mid",".mka",".mlp",".mod",".mp1",
                    ".mp2",".mp3",".mpc",".mpga",".oga",".oma",".opus",".qcp",".ra",".rmi",".snd",".s3m",".spx",
                    ".tta",".voc",".vqf",".w64",".wav",".wma",".wv",".xa",".xm",".3g2",".3gp",".3gp2",".3gpp",
                    ".amv",".asf",".avi",".bik",".divx",".drc",".dv",".f4v",".flv",".gvi",".gxf",".m1v",".m2t",
                    ".m2v",".m2ts",".m4v",".mkv",".mov",".mp2v",".mp4",".mp4v",".mpa",".mpe",".mpeg",".mpeg1",
                    ".mpeg2",".mpeg4",".mpg",".mpv2",".mts",".mtv",".mxf",".nsv",".nuv",".ogg",".ogm",".ogx",
                    ".ogv",".rec",".rm",".rmvb",".rpl",".thp",".tod",".ts",".tts",".vob",".vro",".webm",".wmv",
                    ".xesc",".asx",".b4s",".cue",".ifo",".m3u",".m3u8",".pls",".ram",".sdp",".vlc",".wvx",".xspf"}
            };
            config.AppTypes.Add(vlcPlayer);

            var sumatraPDF = new AppType("SumatraPDF")
            {
                //PropertiesParameter = "-preferences",
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() {
                    ".epub", ".azw", ".mobi", ".fb2", ".fb2z", ".zfb2", ".pdb", ".tcr", ".cbz", ".cbr",
                    ".cbt", ".cb7", ".djv", ".djvu", ".chm", ".xps", ".oxps", ".xod", ".pdf" },
            };
            config.AppTypes.Add(sumatraPDF);

            var excel = new AppType("MS Office - Excel")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".xls", ".xlsb", ".xlsm", ".xlsx", ".xlt", ".ods", ".xltm", ".xltx", ".xlt", },
                URLAssociations = new List<string>() { "view", }
            };
            config.AppTypes.Add(excel);

            var word = new AppType("MS Office - Word")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".doc", ".docx", ".dot", ".dotx", ".dotm", ".odt", },
                URLAssociations = new List<string>() { "view", }
            };
            config.AppTypes.Add(word);

            var powerpoint = new AppType("MS Office - Powerpoint")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".odp", ".otp", ".pot", ".potm", ".potx", ".pps", ".ppsx", ".ppt", ".pptm", ".pptx", ".odp", ".otp", },
                URLAssociations = new List<string>() { "view", }
            };
            config.AppTypes.Add(powerpoint);

            var winrar = new AppType("Winrar")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".7zip", ".zip", ".rar", ".gz", ".cab", },
                URLAssociations = new List<string>() { "view", }
            };
            config.AppTypes.Add(winrar);

            var imageViewer = new AppType("Generic Image-Viewer")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".jpg", ".gif", ".bmp", ".png", ".ico", ".jpeg", ".tif", ".tiff", },
                URLAssociations = new List<string>() { "view", }
            };
            config.AppTypes.Add(imageViewer);

            var notepad = new AppType("Generic Notepad")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".txt", ".conf", ".reg", },
                URLAssociations = new List<string>() { "view", }
            };
            config.AppTypes.Add(notepad);

            return config;
        }

        // PROPERTIES
        public List<AppType> AppTypes { get; set; }

        // CONSTRUCTOR
        public Configuration()
        {
            AppTypes = new List<AppType>();
        }

        public static Configuration Load()
        {
            try
            {
                if (!File.Exists(_configFile))
                {
                    var config = Configuration.CreateDefault();
                    config.Save();
                    return config;
                }
                else
                {
                    return Helper.XMLSerializer.Deserialize<Configuration>(_configFile);
                }
            }
            catch (Exception ex)
            {
                SimpleLogger.Instance.Error(ex);
                throw ex;
            }
        }

        public void Save()
        {
            Helper.XMLSerializer.Serialize(this, _configFile);
        }
    }
}
