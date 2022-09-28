using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entity.Crud
{
    /* public class Company
     {
         public int Id { get; set; }
         public string? Name { get; set; } // название компании

         public List<User> Users { get; set; } = new();
     }
     public class User
     {
         public int Id { get; set; }
         public string? Name { get; set; } // имя пользователя
         public int Age { get; set; } // возраст пользователя
         public string Gender { get; set; }// пол пользователя

         public int? CompanyInfoKey { get; set; }
         [ForeignKey("CompanyInfoKey")]
         public Company? Company { get; set; }
     }*/
    /*public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<User> Users { get; set; } = new();
    }

    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Company? Company { get; set; }
    }*/
    // столица страны
    public class User
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }

        public UserProfile? Profile { get; set; }
    }

    public class UserProfile
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        public int Age { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }

    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<UserProfile> UserProfiles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}
