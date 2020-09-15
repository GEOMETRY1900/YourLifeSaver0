namespace YourLifeSaver.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class webQuizModel : DbContext
    {
        public webQuizModel()
            : base("name=webQuizModel")
        {
        }

        public virtual DbSet<quiz> quizs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
