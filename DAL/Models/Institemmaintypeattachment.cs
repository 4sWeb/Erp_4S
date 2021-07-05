using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemmaintypeattachment
    {
        public Institemmaintypeattachment()
        {
            Cminstitemattatchments = new HashSet<Cminstitemattatchment>();
            Institemattatchments = new HashSet<Institemattatchment>();
            Institemattatchmentsus = new HashSet<Institemattatchmentsu>();
            Salerentinstitemattatchments = new HashSet<Salerentinstitemattatchment>();
        }

        public decimal Id { get; set; }
        public decimal? InstitemMainTypesId { get; set; }
        public decimal? AttachmentTypeId { get; set; }

        public virtual Attachmenttype AttachmentType { get; set; }
        public virtual Institemmaintype InstitemMainTypes { get; set; }
        public virtual ICollection<Cminstitemattatchment> Cminstitemattatchments { get; set; }
        public virtual ICollection<Institemattatchment> Institemattatchments { get; set; }
        public virtual ICollection<Institemattatchmentsu> Institemattatchmentsus { get; set; }
        public virtual ICollection<Salerentinstitemattatchment> Salerentinstitemattatchments { get; set; }
    }
}
