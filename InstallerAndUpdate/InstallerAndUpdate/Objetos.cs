using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstallerAndUpdate
{
    class Objetos
    {
    }
    public class Configuracion
    {
        public string imagen { get; set; }
        public string readme { get; set; }
        public string version { get; set; }
    }

    public class Filename
    {
        public string archivo { get; set; }
        public string checksum { get; set; }
        public string path { get; set; }
        public string url { get; set; }
    }

    public class Resultados
    {
        public Configuracion configuracion { get; set; }
        public List<Filename> filename { get; set; }
    }
}
