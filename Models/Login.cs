using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudio_de_Arquitectura_J_W.Models
{
    [Table ("t_login")]
    public class Login
    {

        public int id {get;set;}

        public string correo{get;set;}

        public string contraseña{get;set;}
    }
}