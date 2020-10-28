using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Timers;
using Timer = System.Timers.Timer;

namespace BuisnessLayer
{
    public class Podcast : ITitel
    {
        public string Url { get; set; }
        public string Kategori { get; set; }
        public string Uppdateringsfrekvens { get; set; }
        public string AntalAvsnitt { get; set; }
        public string Titel { get; set; }

        public List<Avsnitt> AvsnittLista = new List<Avsnitt>();

        [XmlIgnore]
        public Timer uppdateringsTimer = new Timer();
    }

  
}




