using System.Data.Entity;
using TraineeSchoolDDD.Domain.Entities;

namespace TraineeSchoolDDD.Infra.Data.Contexto
{
    public class TraineeSchoolContext : DbContext
        
    {
        public TraineeSchoolContext()
            : base("TraineeSchoolDDD")
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

    }
}
