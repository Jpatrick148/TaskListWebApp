using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ListWebApp.Models
{
    public class Info
    {
        [Key] 
        public int ID { get; set; }

    }

    public class User : Info
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class Task : Info
    {
        public string Description { get; set; }
        public DateTime DueDateTime { get; set; }
        public bool IsComplete = false;
    }

    public class InformationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}