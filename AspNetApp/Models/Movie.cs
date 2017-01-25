﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApp.Models
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł filmu!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Nazwa musi mieć od 3 do 30 znaków!")]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Wypełnij skrócony opis!")]
        [StringLength(100, ErrorMessage = "Opis może mieć maksymalnie 100 znaków!")]
        [Display(Name = "Skrócony opis")]
        public string ShortDesc { get; set; }

        [Required(ErrorMessage = "Wypełnij opis!")]
        [StringLength(100, ErrorMessage = "Opis może mieć maksymalnie 200 znaków!")]
        [Display(Name = "Pełny opis")]
        public string Description { get; set; }

        [ForeignKey("Director")]
        public int DirectorId { get; set; }
        public virtual Director Director { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    }

    public class MoviesDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public System.Data.Entity.DbSet<AspNetApp.Models.Director> Directors { get; set; }
    }
}
