using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemmaintype
    {
        public Institemmaintype()
        {
            Cminstitemlayoutlayers = new HashSet<Cminstitemlayoutlayer>();
            Cminstitemtempletes = new HashSet<Cminstitemtemplete>();
            Institemmaintypeattachments = new HashSet<Institemmaintypeattachment>();
            Institemmaintypefeatures = new HashSet<Institemmaintypefeature>();
            Institemmaintypeservices = new HashSet<Institemmaintypeservice>();
            Institemmaintypesproperties = new HashSet<Institemmaintypesproperty>();
            Institems = new HashSet<Institem>();
            Institemus = new HashSet<Institemu>();
            Salerentinstitems = new HashSet<Salerentinstitem>();
            ServicesInstitemInstitemMainTypes = new HashSet<ServicesInstitem>();
            ServicesInstitemInstitemmaintypesId1Navigations = new HashSet<ServicesInstitem>();
            Termsofinstaintemsales = new HashSet<Termsofinstaintemsale>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
        public decimal? BusinesstypeId { get; set; }
        public string Institem1name { get; set; }
        public string Institem1ename { get; set; }
        public string UseInstitem1 { get; set; }
        public string UseInstitem1q { get; set; }
        public string Institem2name { get; set; }
        public string Institem2ename { get; set; }
        public string UseInstitem2 { get; set; }
        public string UseInstitem2q { get; set; }
        public string Institem3name { get; set; }
        public string Institem3ename { get; set; }
        public string UseInstitem3 { get; set; }
        public string UseInstitem3q { get; set; }
        public string Mayrent { get; set; }
        public bool? Calcpricebymeter { get; set; }
        public decimal? OriginalId { get; set; }

        public virtual StoreAllsubcode Businesstype { get; set; }
        public virtual ICollection<Cminstitemlayoutlayer> Cminstitemlayoutlayers { get; set; }
        public virtual ICollection<Cminstitemtemplete> Cminstitemtempletes { get; set; }
        public virtual ICollection<Institemmaintypeattachment> Institemmaintypeattachments { get; set; }
        public virtual ICollection<Institemmaintypefeature> Institemmaintypefeatures { get; set; }
        public virtual ICollection<Institemmaintypeservice> Institemmaintypeservices { get; set; }
        public virtual ICollection<Institemmaintypesproperty> Institemmaintypesproperties { get; set; }
        public virtual ICollection<Institem> Institems { get; set; }
        public virtual ICollection<Institemu> Institemus { get; set; }
        public virtual ICollection<Salerentinstitem> Salerentinstitems { get; set; }
        public virtual ICollection<ServicesInstitem> ServicesInstitemInstitemMainTypes { get; set; }
        public virtual ICollection<ServicesInstitem> ServicesInstitemInstitemmaintypesId1Navigations { get; set; }
        public virtual ICollection<Termsofinstaintemsale> Termsofinstaintemsales { get; set; }
    }
}
