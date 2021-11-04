using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudio_de_Arquitectura_J_W.Models
{
    [Table ("t_construccion")]
    public class Construccion
    {

        public int id {get;set;}
        public string descripcionConstruccion{get;set;}
        public string imagenConstruccion{get;set;}
        public ICollection<ProcesoConstruccion> procesoConstruccion { get; set; }
    }
}