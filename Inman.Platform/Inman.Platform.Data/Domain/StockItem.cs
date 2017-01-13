//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inman.Platform.Data
{
#pragma warning disable 1573
    using System;

    public partial class StockItem 
    {
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> ColorID { get; set; }
        public Nullable<int> ItemCategoryId1 { get; set; }
        public Nullable<int> ItemCategoryId2 { get; set; }
        public Nullable<int> ItemCategoryId3 { get; set; }
        public string FirstYear { get; set; }
        public string FirstSeason { get; set; }
        public string DevMonth { get; set; }
        public string Developer { get; set; }
        public string ItemCode { get; set; }
        public string ItemCode2 { get; set; }
        public string ColorCode { get; set; }
        public string ItemName { get; set; }
        public string ItemSpec { get; set; }
        public Nullable<int> BuyerId { get; set; }
        public string Buyer { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> DevPrice { get; set; }
        public Nullable<decimal> ExclusiveTaxPrice { get; set; }
        public Nullable<decimal> DevExclusiveTaxPrice { get; set; }
        public Nullable<decimal> ExclusiveTaxPriceAgent { get; set; }
        public Nullable<decimal> PriceAgent { get; set; }
        public Nullable<decimal> KGPrice { get; set; }
        public string Unit { get; set; }
        public string Component { get; set; }
        public double LateralContraction { get; set; }
        public double DirectContraction { get; set; }
        public double ItemWidth { get; set; }
        public double Weight { get; set; }
        public double KilogramMeter { get; set; }
        public string DaysSupply { get; set; }
        public double MOQ { get; set; }
        public double UpperInventory { get; set; }
        public double BelowInventory { get; set; }
        public string SupplierItemCode { get; set; }
        public string SupplierItemColor { get; set; }
        public string Remark { get; set; }
        public string PicturePath { get; set; }
        public bool HaveApproveDevPrice { get; set; }
        public bool HaveApprovePrice { get; set; }
        public Nullable<int> SortCode { get; set; }
        public string Brand { get; set; }
        public string DevType { get; set; }
        public string ApprovalPriceRemark { get; set; }
        public int ExemptionState { get; set; }
        public int AccountID { get; set; }
        public string CreatedBy { get; set; }
        public int CreatedCustomerId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int Enabled { get; set; }
   
        public int Id { get; set; }
        public bool IsEnabled { get; }
        public string ModifiedBy { get; set; }
        public int ModifiedCustomerId { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int OwnerId { get; set; }
    }
}