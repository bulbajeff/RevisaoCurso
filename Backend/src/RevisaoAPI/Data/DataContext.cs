using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoUdemyAPI.Models;

namespace RevisaoAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
    }
}