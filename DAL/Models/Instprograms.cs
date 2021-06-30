using System;
using System.Collections.Generic;

namespace ERPCOREDAL.Models
{
    public partial class Instprograms
    {
        public Instprograms()
        {
         //   StoreTrnsM = new HashSet<StoreTrnsM>();
        }
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
        public byte? NoOfInstalmentYears { get; set; }
        public byte? NoOfInstalments { get; set; }
        public string Insttype { get; set; }
        public decimal? Totalinstdetails { get; set; }
      //  public virtual ICollection<StoreTrnsM> StoreTrnsM { get; set; }
    }
}
