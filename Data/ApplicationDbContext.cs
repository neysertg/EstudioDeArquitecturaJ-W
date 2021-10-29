using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Estudio_de_Arquitectura_J_W.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {         
        }

        public DbSet<Estudio_de_Arquitectura_J_W.Models.Comentarios> Comentarios{get;set;}
        public DbSet<Estudio_de_Arquitectura_J_W.Models.Proyectos> Proyectos{get;set;}        
        public DbSet<Estudio_de_Arquitectura_J_W.Models.Servicios> Servicios{get;set;}


    }
}