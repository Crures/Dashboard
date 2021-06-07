using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace dashboard.context.Model
{
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Password { get; set; }
        public int? Role { get; set; }
        public string Dashboard { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
