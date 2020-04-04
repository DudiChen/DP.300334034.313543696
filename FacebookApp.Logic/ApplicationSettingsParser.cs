﻿using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;

namespace FacebookApp.Logic
{
    /// <summary>
    /// //////////////////////////////////////////////////////
    /// ///// !!! NEED TO EDIT BEFORE SUBMITION !!! //////////
    /// //////////////////////////////////////////////////////
    /// //////////////////////////////////////////////////////
    /// </summary>
    internal class ApplicationSettingsParser
    {
        public static ApplicationSettings Desirialize(Stream i_Stream)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ApplicationSettings));
            ApplicationSettings result = xmlSerializer.Deserialize(i_Stream) as ApplicationSettings;
            return result;
        }

        public static void Serialize(Stream i_Stream, object i_Caller)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ApplicationSettings));
            xmlSerializer.Serialize(i_Stream, i_Caller);
        }
    }
}