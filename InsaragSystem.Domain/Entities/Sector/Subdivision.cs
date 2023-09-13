using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Entities.Sector
{
    public sealed class Subdivision
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public List<Subfield> Subfields { get; set; }
        

        public Subdivision()
        {
            Subfields = new List<Subfield>();
        }

        public void AddSubfield(Subfield subfield)
        {
            if (subfield == null)
                throw new ArgumentNullException(nameof(subfield));

            if (!Subfields.Contains(subfield))
                Subfields.Add(subfield);
        }

        public void RemoveSubfield(Subfield subfield)
        {
            if (subfield == null)
                throw new ArgumentNullException(nameof(subfield));

            if (Subfields.Contains(subfield))
                Subfields.Remove(subfield);
        }

        public int SectorId { get; set; }
        public Sector Sector { get; set; }
    }

}
