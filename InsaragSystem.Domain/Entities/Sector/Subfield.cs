using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Entities.Sector
{
    public sealed class Subfield
    {
        public int Id { get; set; }
        public char Code { get; set; }
        public int SubdivisionId { get; set; }
        public Subdivision Subdivision { get; set; }
    }
}
