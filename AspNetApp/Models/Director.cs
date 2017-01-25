using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApp.Models
{
    public class Director
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(30, MinimumLength = 3, ErrorMessage = "Imię musi mieć od 3 do 30 znaków!")]
        [Required(ErrorMessage = "Wpisz swoje imię!")]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [StringLength(30, MinimumLength = 2, ErrorMessage = "Nazwisko musi mieć od 2 do 30 znaków!")]
        [Required(ErrorMessage = "Wpisz swoje nazwisko!")]
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Wypełnij opis!")]
        [Display(Name = "Opis")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Opis musi posiadać od 10 do 200 znaków!")]
        public string Description { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }

    public class DirectorDbContext : DbContext
    {
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
