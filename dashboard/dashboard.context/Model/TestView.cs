using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace dashboard.context.Model
{
    [Keyless]
    public partial class TestView
    {
        [StringLength(255)]
        public string Email { get; set; }
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Start { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime End { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Couleur { get; set; }
        public int Createur { get; set; }
        public string Description { get; set; }
    }
}
