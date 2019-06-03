using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WIKI_COMPRAR.Models
{
    public class Desarrollo
    {
        public long Id { get; set; }
        public string NommbreDesarrollo { get; set; }
        public IList<User> Participantes { get; set; }
        public string DescripcionTecnica { get; set; }
        public string DescripcionNegocio { get; set; }

    }
}