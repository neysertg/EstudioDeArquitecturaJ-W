using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudio_de_Arquitectura_J_W.Models
{
    [Table ("t_procesoSa")]
    public class ProcesoSa 
    {

        public int id {get;set;}

        public string procesoSa{get;set;}
        public Saneamiento Saneamiento { get; set; }
    }
}