using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudio_de_Arquitectura_J_W.Models
{
    [Table ("t_consultoria")]
    public class Consultoria
    {

        public int id {get;set;}

        public string descripcionConsultoria{get;set;}
        public string imagenConsultoria{get;set;}
        public ICollection<ProcesoCons> procesoConsultoria { get; set; }
    }
}