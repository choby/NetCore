namespace cpp Inman.Platform.ServiceStub.Thrift.DataData
namespace d Inman.Platform.ServiceStub.Thrift.DataData // "shared" would collide with the eponymous D keyword.
namespace dart Inman.Platform.ServiceStub.Thrift.DataData
namespace java Inman.Platform.ServiceStub.Thrift.DataData
namespace perl Inman.Platform.ServiceStub.Thrift.DataData
namespace php Inman.Platform.ServiceStub.Thrift.DataData
namespace haxe Inman.Platform.ServiceStub.Thrift.DataData
namespace netcore Inman.Platform.ServiceStub.Thrift.Data



struct User{
	1:i32 Id ;
	2:string OpenId ;
	3:string UserName ;
}


struct StockItem {
  1:i32 Id ;
  2:i32 SupplierID ;
  3:i32 ColorID ;
  4:i32 ItemCategoryId1 ;
  5:i32 ItemCategoryId2 ;
  6:i32 ItemCategoryId3 ;
  7:string FirstYear ;
  8:string FirstSeason ;
  9:string DevMonth ;
  10:string Developer ;
  11:string ItemCode ;
  12:string ItemCode2 ;
  13:string ColorCode ;
  14:string ItemName ;
  15:string ItemSpec ;
  16:i32 BuyerId ;
  17:i32 Buyer ;
  18:double Price ;
  19:double  DevPrice ;
  20:double ExclusiveTaxPrice ;
  21:double DevExclusiveTaxPrice ;
  22:double ExclusiveTaxPriceAgent ;
  23:double PriceAgent ;
  24:double   KGPrice ;
  25:string  Unit ;
  26:string  Component ;
  27:double LateralContraction ;
  28:double  DirectContraction ;
  29:double  ItemWidth ;
  30:double  Weight ;
  31:double KilogramMeter ;
  32:string   DaysSupply ;
  33:double  MOQ ;
  34:double UpperInventory ;
  35:double BelowInventory ;
  36:string SupplierItemCode ;
  37:string  SupplierItemColor ;
  38:string  Remark ;
  39:string PicturePath ;
  40:bool  HaveApproveDevPrice ;
  41:bool HaveApprovePrice  ;
  42:string  Brand ;
  43:string DevType ;
  44:i32  SortCode;
  45:bool Enabled ;
  46:bool Deleted ;
  47:i32  AccountID ;
  48:string CreatedOn ;
  49:string CreatedBy ;
  50:i32 CreatedCustomerId ;
  51:string ModifiedOn ;
  52:string  ModifiedBy ;
  53:i32  ModifiedCustomerId ;
  54:string  ApprovalPriceRemark ;
  55:i32  ExemptionState	    ;
  56:i32 OwnerId			    ;
}

struct Product {
  1:i32 Id ;
  2:i32 ColorId;
  3:i32 GoodsId ;
  4:string ProductSN ;
  5:string PicturePath ;
  6:string Remark ;
  7:i32 AccountID ;
  8:bool Deleted ;
  9:i32 Enabled ;
  10:string CreatedOn ;
  11:string CreatedBy ;
  12:i32 CreatedCustomerId ;
  13:string ModifiedOn ;
  14:string ModifiedBy ;
  15:i32 ModifiedCustomerId ;
  16:i32 OwnerId ;
  17:Goods Goods ;
}

struct Goods {
  1:i32 Id ;
  2:i32 DesignID;
  3:string ProductCategory1 ;
  4:string ProductCategory2;
  5:string ProductCategory3;
  6:string Brand;
  7:string ProductName;
  8:i32 ProductYear;
  9:string Season;
  10:string ExecStandard ;
  11:string SafetyCass ;
  12:string Component ;
  13:double DevCost ;
  14:string ProductSN ;
  15:double FOBCost ;
  16:double ProcessingCost ;
  17:double ProductCost ;
  18:double InternalPrice ;
  19:double SalesPrice ;
  20:double TagPrice ;
  21:double BatchPrice ;
  22:double RADCost ;
  23:bool IsEmergency ;
  24:string ProductTitle ;
  25:string QualityGrade ;
  26:string Filler ;
  27:double FillFeatherPercent ;
  28:i32 WashingMethodPictureCode;
  29:string FirstOnsaleShelveDate ;
  30:i32 SortCode ;
  31:i32 AccountID ;
  32:bool Deleted ;
  33:i32 Enabled ;
  34:string CreatedOn ;
  35:string CreatedBy ;
  36:i32 CreatedCustomerId ;
  37:string ModifiedOn ;
  38:string ModifiedBy ;
  39:i32 ModifiedCustomerId ;
  40:string Sex ;
  41:string WashingMethodPicture ;
  42:string CategoryClass ;
  43:bool IsUploadK3 ;
  44:string UploadK3Date ;
  45:i32 OwnerId ;
  46:Design Design ;
}

struct Design
{
	1:i32 Id;
	2:i32 DevYear;
	3:string DesignGroup;
	4:string DesignSeason;
	5:string Theme;
	6:string Collection;
	7:string DesignAssistantName;
	8:string DesignProductSN;
	9:string ProductName;
	10:string CommitProductNameDate ;
	11:string Material ;
	12:string Technology ;
	13:string Collar ;
	14:string Shape ;
	15:string ClothesLong ;
	16:string SleeveShape ;
	17:string SleeveLong ;
	18:string TypeDecomposition ;
	19:string Particulars ;
	20:string Aekbuh ;
	21:string SkirtLong;
	22:string WaistShape ;
	23:string Element ;
	24:string TrousersShape ;
	25:string Outseam ;
	26:string Peplum ;
	27:string Commission ;
	28:string PicturePath ;
	29:string Status ;
	30:string Batch ;
	31:string UpnewDate;
	32:string Remark ;
	33:i32 SortCode ;
	34:i32 AccountID ;
    35:bool Deleted ;
    36:i32 Enabled ;
    37:string CreatedOn ;
    38:string CreatedBy ;
    39:i32 CreatedCustomerId ;
    40:string ModifiedOn ;
    41:string ModifiedBy ;
    42:i32 ModifiedCustomerId ;
    43:i32 SizeCateId ;
    44:string IsMainPush ;
    45:string WaveSession ;
    46:string Gender ;
    47:string DesignCate ;
    48:i32 OwnerId ;
    49:string DesignSource ;
    50:string PriceRange ;
}