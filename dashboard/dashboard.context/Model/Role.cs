using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace dashboard.context.Model
{
    public partial class Role
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Type { get; set; }
        public string Permissions { get; set; }
    }
}
