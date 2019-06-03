using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WIKI_COMPRAR.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Nombre { get; set; }  
        public string Apellido { get; set; }    
        public string Email { get; set; }

    }
}