using System;
using System.Collections.Generic;

namespace Dasi.Rd.Data.Entities
{
    public class Synoda
    {
        public int ID { get; set; }
        public string SynodaName { get; set; }
        public int SynodaNumber { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateEdition { get; set; }
        public ICollection<Fitandremana> Fitandremanas { get; set; }
    }
}