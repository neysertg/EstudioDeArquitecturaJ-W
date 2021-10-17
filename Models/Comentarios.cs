using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudio_de_Arquitectura_J_W.Models
{
    [Table ("t_comentarios")]
    public class Comentarios
    {

        public int id {get;set;}

        public string comentario{get;set;}
    }
}