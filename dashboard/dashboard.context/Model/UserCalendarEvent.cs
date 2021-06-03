using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace dashboard.context.Model
{
    [Table("UserCalendarEvent")]
    public partial class UserCalendarEvent
    {
        [Key]
        public int Id { get; set; }
        public int User { get; set; }
        public int CalendarEvent { get; set; }

        [ForeignKey(nameof(CalendarEvent))]
        [InverseProperty("UserCalendarEvents")]
        public virtual CalendarEvent CalendarEventNavigation { get; set; }
        [ForeignKey(nameof(Id))]
        [InverseProperty("UserCalendarEvent")]
        public virtual User IdNavigation { get; set; }
    }
}
