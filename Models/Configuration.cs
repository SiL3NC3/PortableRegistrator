using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableRegistrator.Models
{
    public class Configuration
    {
        // STATICS
        internal static Configuration CreateDefault()
        {
            var config = new Configuration();

            var browser = new AppType("Web-Browser")
            {
                //PropertiesParameter = "-preferences",
                OpenParameters = "-url \"%1\"",
                FileAssociations = new List<string>() { ".htm", ".html", ".shtml", ".xht", ".xhtml", },
                URLAssociations = new List<string>() { "http", "https", "ftp", }
            };

            var mail = new AppType("Mail-Program")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".xpi", ".eml", ".msg", ".ics", ".mbox" },
                URLAssociations = new List<string>() { "mailto", }
            };

            // Committed by psorincatalin
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

            var sumatraPDF = new AppType("SumatraPDF")
            {
                //PropertiesParameter = "-preferences",
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() {
                    ".epub", ".azw", ".mobi", ".fb2", ".fb2z", ".zfb2", ".pdb", ".tcr", ".cbz", ".cbr",
                    ".cbt", ".cb7", ".djv", ".djvu", ".chm", ".xps", ".oxps", ".xod", },
            };

            config.AppTypes.Add(browser);
            config.AppTypes.Add(mail);
            config.AppTypes.Add(vlcPlayer);
            config.AppTypes.Add(sumatraPDF);

            return config;
        }

        // PROPERTIES
        public List<AppType> AppTypes { get; set; }

        // CONSTRUCTOR
        public Configuration()
        {
            AppTypes = new List<AppType>();
        }


    }
}
