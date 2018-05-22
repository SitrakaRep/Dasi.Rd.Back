using System;

namespace Dasi.Rd.Data.Entities
{
    public class Fitandremana
    {
        public int ID { get; set; }
        public string FitandremanaName { get; set; }
        public string FitandremanaAdress { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateEdition { get; set; }
        public int? SynodaID { get; set; }
        public Synoda Synoda { get; set; }
    }
}