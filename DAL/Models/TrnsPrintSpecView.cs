using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TrnsPrintSpecView
    {
        public decimal Id { get; set; }
        public decimal TrnsCode { get; set; }
        public bool? Fromcode { get; set; }
        public bool? Tocode { get; set; }
        public bool? Fromname { get; set; }
        public bool? Toname { get; set; }
        public bool? Fromotherdata { get; set; }
        public bool? Tootherdata { get; set; }
        public bool? Trnsdepno { get; set; }
        public bool? Trnsdepaddno { get; set; }
        public bool? Itemcode { get; set; }
        public bool? ItemNameOnTwoRow { get; set; }
        public bool? Notescolumn { get; set; }
        public bool? Multiunits { get; set; }
        public bool? Costprice { get; set; }
        public bool? Totalldeptrnsno { get; set; }
        public bool? Account { get; set; }
        public bool? Price { get; set; }
        public bool? Totallprice { get; set; }
        public bool? Trnsnote { get; set; }
        public bool? Companylogo { get; set; }
        public bool? Totallqty { get; set; }
        public bool? Itemnameonsupp { get; set; }
        public bool? Notsonitem { get; set; }
        public bool? Reciveddate { get; set; }
        public bool? Notesinstadofname { get; set; }
        public string Notecolumnaddress { get; set; }
        public bool? Costcenter { get; set; }
        public bool? Orderbyserial { get; set; }
        public string Signonetype { get; set; }
        public string Signonename { get; set; }
        public string Signtwotype { get; set; }
        public string Signtwoname { get; set; }
        public string Signthreetype { get; set; }
        public string Signthreename { get; set; }
        public bool? Commentoneshow { get; set; }
        public bool? Commenttwoshow { get; set; }
        public bool? Commentthreeshow { get; set; }
        public bool? Commentthreeplace { get; set; }
        public string Commentthreetxt { get; set; }
        public bool? Briefprint { get; set; }
        public string Commentonetxt { get; set; }
        public string Commenttwotxt { get; set; }
        public string Reportaddress { get; set; }
    }
}
