using GerenciadorDeFuncionários.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GerenciadorDeFuncionários.DataContext
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}