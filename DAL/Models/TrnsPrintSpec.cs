using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TrnsPrintSpec
    {
        public TrnsPrintSpec()
        {
            TrnsPrintSpecdetails = new HashSet<TrnsPrintSpecdetail>();
        }

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
        public bool? Showbalance { get; set; }
        public bool? Printdistdetails { get; set; }
        public string Offerheadere { get; set; }
        public string Offerheader { get; set; }
        public string Offernotese { get; set; }
        public string Offernotes { get; set; }
        public string Offerfootere { get; set; }
        public string Offerfooter { get; set; }
        public DateTime? Offerdate { get; set; }
        public string Disc2labele { get; set; }
        public string Disc2label { get; set; }
        public decimal? Disc2value { get; set; }
        public string Addition1label { get; set; }
        public string Addition1labele { get; set; }
        public decimal? Addition1value { get; set; }
        public string Addition2label { get; set; }
        public string Addition2labele { get; set; }
        public decimal? Addition2value { get; set; }
        public string Addition3label { get; set; }
        public string Addition3labele { get; set; }
        public decimal? Addition3value { get; set; }
        public string Remark1label { get; set; }
        public string Remark1labele { get; set; }
        public string Remark1value { get; set; }
        public string Remark2label { get; set; }
        public string Remark2labele { get; set; }
        public string Remark2value { get; set; }
        public string Remark3label { get; set; }
        public string Remark3labele { get; set; }
        public string Remark3value { get; set; }
        public string Remark4label { get; set; }
        public string Remark4labele { get; set; }
        public string Remark4value { get; set; }
        public string Remark5label { get; set; }
        public string Remark5labele { get; set; }
        public string Remark5value { get; set; }
        public string Remark6label { get; set; }
        public string Remark6labele { get; set; }
        public string Remark6value { get; set; }
        public string Remark6valuee { get; set; }
        public string Remark5valuee { get; set; }
        public string Remark4valuee { get; set; }
        public string Remark3valuee { get; set; }
        public string Remark2valuee { get; set; }
        public string Remark1valuee { get; set; }
        public string Batchno { get; set; }
        public string Batchlabel { get; set; }
        public string Batchlabele { get; set; }
        public string Productionstagedesc { get; set; }
        public decimal? Productionstageid { get; set; }
        public string Numbermlabel { get; set; }
        public string Numbermlabele { get; set; }
        public string Numbermvalue { get; set; }
        public string Numberolabel { get; set; }
        public string Numberolabele { get; set; }
        public string Numberovalue { get; set; }
        public string Stringmlabel { get; set; }
        public string Stringmlabele { get; set; }
        public string Stringmvalue { get; set; }
        public string Stringolabel { get; set; }
        public string Stringolabele { get; set; }
        public string Stringovalue { get; set; }
        public string Remark7label { get; set; }
        public string Remark7labele { get; set; }
        public string Remark7value { get; set; }
        public string Remark7valuee { get; set; }
        public string Remark8label { get; set; }
        public string Remark8labele { get; set; }
        public string Remark8value { get; set; }
        public string Remark8valuee { get; set; }
        public string Remark9label { get; set; }
        public string Remark9labele { get; set; }
        public string Remark9value { get; set; }
        public string Remark9valuee { get; set; }
        public string Remark10label { get; set; }
        public string Remark10labele { get; set; }
        public string Remark10value { get; set; }
        public string Remark10valuee { get; set; }
        public bool? DocNoshow { get; set; }
        public string Branchlabel { get; set; }
        public bool? Showextras { get; set; }

        public virtual Productstage Productionstage { get; set; }
        public virtual StoreTrn TrnsCodeNavigation { get; set; }
        public virtual ICollection<TrnsPrintSpecdetail> TrnsPrintSpecdetails { get; set; }
    }
}
