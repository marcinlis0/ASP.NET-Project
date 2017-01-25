using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApp.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Dodaj ocenę!")]
        [IntegerValidator(MinValue = 0, MaxValue = 5)]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Wypełnij pole komentarz!")]
        [StringLength(100, ErrorMessage = "Komentarz może mieć maksymalnie 100 znaków!")]
        [Display(Name = "Komentarz")]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        //[ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }
    }

    public class CommentDbContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }

        public System.Data.Entity.DbSet<AspNetApp.Models.Movie> Movies { get; set; }
    }
}
