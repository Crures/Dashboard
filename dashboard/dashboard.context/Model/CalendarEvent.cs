using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace dashboard.context.Model
{
    [Table("CalendarEvent")]
    public partial class CalendarEvent
    {
        public CalendarEvent()
        {
            UserCalendarEvents = new HashSet<UserCalendarEvent>();
        }

        [Key]
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

        [InverseProperty(nameof(UserCalendarEvent.CalendarEventNavigation))]
        public virtual ICollection<UserCalendarEvent> UserCalendarEvents { get; set; }
    }
}
