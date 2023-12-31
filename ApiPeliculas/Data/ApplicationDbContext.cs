﻿using ApiPeliculas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPeliculas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {        
        }
        //Agregar los modelos aca
        public DbSet<Categoria> Categoria { get; set; }
    }
}
