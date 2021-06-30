using System;
using System.Collections.Generic;
using System.Text;
using ERPCOREDAL.Models;
using Microsoft.EntityFrameworkCore;
namespace DAL.Entities
{
   public  class DbContext4S:DbContext
    {
        public DbContext4S(DbContextOptions<DbContext4S> options):base(options) { }

        //

        public virtual DbSet<AcceptInTrns> AcceptInTrns { get; set; }
        public virtual DbSet<Accountstree> Accountstree { get; set; }
        public virtual DbSet<Agriage> Agriage { get; set; }
        public virtual DbSet<Agridata> Agridata { get; set; }
        public virtual DbSet<Agrifarm> Agrifarm { get; set; }
        public virtual DbSet<Agriprocess> Agriprocess { get; set; }
        public virtual DbSet<Boatport> Boatport { get; set; }
        public virtual DbSet<Conditionsbooklet> Conditionsbooklet { get; set; }
        public virtual DbSet<Currencym> Currencym { get; set; }
        public virtual DbSet<Currencyo> Currencyo { get; set; }
        public virtual DbSet<Dimensionlevels> Dimensionlevels { get; set; }
        public virtual DbSet<Dimensions> Dimensions { get; set; }
        public virtual DbSet<Dimensionsdetails> Dimensionsdetails { get; set; }
        public virtual DbSet<DiscountItemM> DiscountItemM { get; set; }
        public virtual DbSet<DiscountListType> DiscountListType { get; set; }
        public virtual DbSet<Extras> Extras { get; set; }
        public virtual DbSet<Financepuposes> Financepuposes { get; set; }
        public virtual DbSet<Financespec> Financespec { get; set; }
        public virtual DbSet<Financetype> Financetype { get; set; }
        public virtual DbSet<GroupBasicData> GroupBasicData { get; set; }
        public virtual DbSet<Groupf> Groupf { get; set; }
        public virtual DbSet<Instprograms> Instprograms { get; set; }
        public virtual DbSet<Istransfer> Istransfer { get; set; }
        public virtual DbSet<MainTypes> MainTypes { get; set; }
        public virtual DbSet<Period> Period { get; set; }
        public virtual DbSet<Preferences> Preferences { get; set; }
        public virtual DbSet<Producationformla> Producationformla { get; set; }
        public virtual DbSet<Productformladetails> Productformladetails { get; set; }
        public virtual DbSet<Productstages> Productstages { get; set; }
        public virtual DbSet<Shippingcotypes> Shippingcotypes { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Stages> Stages { get; set; }
        public virtual DbSet<StoreAllcodes> StoreAllcodes { get; set; }
        public virtual DbSet<StoreAllcodesBegin> StoreAllcodesBegin { get; set; }
        public virtual DbSet<StoreAllsubcodes> StoreAllsubcodes { get; set; }
        public virtual DbSet<StoreDepSpecs> StoreDepSpecs { get; set; }
        public virtual DbSet<StoreDepSpecsDetails> StoreDepSpecsDetails { get; set; }
        public virtual DbSet<StoreItemUnits> StoreItemUnits { get; set; }
        public virtual DbSet<StoreItemformsSpecs> StoreItemformsSpecs { get; set; }
        public virtual DbSet<StoreItems> StoreItems { get; set; }
        public virtual DbSet<StoreSubCodeSpec> StoreSubCodeSpec { get; set; }
        public virtual DbSet<StoreTrns> StoreTrns { get; set; }
        public virtual DbSet<StoreTrnsAccept> StoreTrnsAccept { get; set; }
        public virtual DbSet<StoreTrnsDep> StoreTrnsDep { get; set; }
        public virtual DbSet<StoreTrnsDepDetails> StoreTrnsDepDetails { get; set; }
        public virtual DbSet<StoreTrnsM> StoreTrnsM { get; set; }
        public virtual DbSet<StoreTrnsO> StoreTrnsO { get; set; }
        public virtual DbSet<StoreTrnsProducationformla> StoreTrnsProducationformla { get; set; }
        public virtual DbSet<StoreTrnsoDimensionsdetails> StoreTrnsoDimensionsdetails { get; set; }
        public virtual DbSet<StoreUnits> StoreUnits { get; set; }
        public virtual DbSet<Storedsttypes> Storedsttypes { get; set; }
        public virtual DbSet<Storemextras> Storemextras { get; set; }
        public virtual DbSet<Storetrnsextras> Storetrnsextras { get; set; }
        public virtual DbSet<Userapps> Userapps { get; set; }
        public virtual DbSet<Usergroup> Usergroup { get; set; }
        public virtual DbSet<Userperiod> Userperiod { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Userstrans> Userstrans { get; set; }

        //

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Userperiod>()
        //        .HasKey(b => b.Periodid)
        //        .HasName("PrimaryKey_BlogId");
        //}

        public new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
