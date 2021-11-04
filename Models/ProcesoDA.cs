using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudio_de_Arquitectura_J_W.Models
{
    [Table ("t_procesoDA")]
    public class ProcesoDA
    {

        public int id {get;set;}

        public string procesoDA{get;set;}
        public DiseñoArquitectonico DiseñoArquitectonico { get; set; }
    }
}