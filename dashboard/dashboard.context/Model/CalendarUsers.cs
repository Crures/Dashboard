using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.context.Model
{
    public partial class CalendarUsers
    {

        public int Id { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Title { get; set; }
        public string Couleur { get; set; }
        public int Createur { get; set; }
        public string Description { get; set; }
        public int[] users { get; set; }

    }
}
