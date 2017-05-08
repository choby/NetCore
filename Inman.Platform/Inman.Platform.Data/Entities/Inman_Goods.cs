using Inman.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inman.Platform.Data.Entities
{
    public class Inman_Goods : BaseEntity
    {
        public virtual int? DesignID { get; set; }
        public virtual string ProductSN { get; set; }
        public virtual string ProductCategory1 { get; set; }
        public virtual string ProductCategory2 { get; set; }
        public virtual string ProductCategory3 { get; set; }
        public virtual int? ProductCategory3ID { get; set; }
        public virtual string Brand { get; set; }
        public virtual string ProductName { get; set; }
        public virtual int ProductYear { get; set; }
        public virtual string Season { get; set; }
        public virtual string ExecStandard { get; set; }
        public virtual string SafetyCass { get; set; }
        public virtual string Component { get; set; }
        public virtual decimal? DevCost { get; set; }
        public virtual decimal? FOBCost { get; set; }
        public virtual decimal? ProcessingCost { get; set; }
        public virtual decimal? ProductCost { get; set; }
        public virtual decimal? InternalPrice { get; set; }
        public virtual decimal? SalesPrice { get; set; }
        public virtual decimal? TagPrice { get; set; }
        public virtual decimal? BatchPrice { get; set; }
        public virtual decimal? RADCost { get; set; }
        public virtual bool IsEmergency { get; set; }
        public virtual string ProductTitle { get; set; }
        public virtual string QualityGrade { get; set; }
        public virtual string Filler { get; set; }
        public virtual decimal? FillFeatherPercent { get; set; }
        public virtual int? WashingMethodPictureCode { get; set; }
        public virtual DateTime? FirstOnsaleShelveDate { get; set; }
        public virtual int SortCode { get; set; }
       
        public virtual string Sex { get; set; }
        public virtual string WashingMethodPicture { get; set; }
        public virtual string CategoryClass { get; set; }
        public virtual bool IsUploadK3 { get; set; }
        public virtual DateTime? UploadK3Date { get; set; }
       
    }
}
