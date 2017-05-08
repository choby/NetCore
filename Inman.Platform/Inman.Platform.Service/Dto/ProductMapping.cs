using AutoMapper;
using Inman.Platform.Data.Entities;
using Inman.Platform.ServiceStub.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Inman.Infrastructure.Common.Extensions;

namespace Inman.Platform.Service.Dto
{
    public class ProductMapping
    {
        public static IMappingExpression<Inman_Product, Product> FromProduct(IMapperConfigurationExpression config)
        {
            return config.CreateMap<Inman_Product, Product>()
                
                         .ForMember(dest=>dest.Id,mo=>mo.MapFrom(s=>s.Id))
                         .ForMember(dest => dest.AccountID, mo => mo.MapFrom(s => s.AccountID))
                         .ForMember(dest => dest.ColorId, mo => mo.MapFrom(s => s.ColorID))
                         .ForMember(dest => dest.Deleted, mo => mo.MapFrom(s => s.Deleted))
                         .ForMember(dest => dest.Enabled, mo => mo.MapFrom(s => s.Enabled))
                         .ForMember(dest => dest.GoodsId, mo => mo.MapFrom(s => s.GoodsId))
                         .ForMember(dest => dest.CreatedOn, mo => mo.MapFrom(s => s.CreatedOn.ToString()))
                         .ForMember(dest => dest.CreatedCustomerId, mo => mo.MapFrom(s => s.CreatedCustomerId))
                         .ForMember(dest => dest.ModifiedBy, mo => mo.MapFrom(s => s.ModifiedBy))
                         .ForMember(dest => dest.ModifiedCustomerId, mo => mo.MapFrom(s => s.ModifiedCustomerId))
                         .ForMember(dest => dest.ModifiedOn, mo => mo.MapFrom(s => s.ModifiedOn.ToString()))
                         .ForMember(dest => dest.OwnerId, mo => mo.MapFrom(s => s.OwnerId))

                         .ForMember(dest => dest.PicturePath, mo => mo.Condition(s => !string.IsNullOrEmpty(s.PicturePath)))
                         .ForMember(dest => dest.ProductSN, mo =>  mo.Condition(s => !string.IsNullOrEmpty(s.ProductSN)))
                         .ForMember(dest => dest.Remark, mo => mo.Condition(s => !string.IsNullOrEmpty(s.Remark)))
                         .ForMember(dest => dest.CreatedBy, mo => mo.Condition(s => !string.IsNullOrEmpty(s.CreatedBy)))
                        // .ForMember(dest => dest.PicturePath, mo => mo.MapFrom(s => !string.IsNullOrEmpty(s.PicturePath)))
                ;
        }

        public static IMappingExpression<Inman_Goods, Product> FromGoods(IMapperConfigurationExpression config)
        {
            return config.CreateMap<Inman_Goods, Product>()
                         .ForMember(desc=>desc.Id,mo=>mo.Ignore())
                         .ForMember(dest => dest.ProductYear, mo => mo.MapFrom(s => s.ProductYear))
                         .ForMember(dest => dest.IsEmergency, mo => mo.MapFrom(s => s.IsEmergency))
                         .ForMember(dest => dest.IsUploadK3, mo => mo.MapFrom(s => s.IsUploadK3))

                         .ForMember(dest => dest.FillFeatherPercent, mo => mo.ResolveUsing(s => (s.FillFeatherPercent.CastToFloat())))
                         .ForMember(dest => dest.FirstOnsaleShelveDate, mo => mo.ResolveUsing(s => s.FirstOnsaleShelveDate.FormatToDate()))
                         .ForMember(dest => dest.FOBCost, mo => mo.ResolveUsing(s => s.FOBCost.CastToDouble()))
                         .ForMember(dest => dest.InternalPrice, mo => mo.ResolveUsing(s => s.InternalPrice.CastToDouble()))
                         .ForMember(dest => dest.ProcessingCost, mo => mo.ResolveUsing(s => s.ProcessingCost.CastToDouble()))
                         .ForMember(dest => dest.RADCost, mo => mo.ResolveUsing(s => s.RADCost.CastToDouble()))
                         .ForMember(dest => dest.SalesPrice, mo => mo.ResolveUsing(s => s.SalesPrice.CastToDouble()))
                         .ForMember(dest => dest.TagPrice, mo => mo.ResolveUsing(s => s.TagPrice.CastToDouble()))
                         .ForMember(dest => dest.UploadK3Date, mo => mo.ResolveUsing(s => s.UploadK3Date.FormatToDateTime()))
                         .ForMember(dest => dest.DevCost, mo => mo.ResolveUsing(s => s.DevCost.CastToDouble()))


                         .ForMember(dest => dest.WashingMethodPictureCode, mo => mo.Condition(s => s.WashingMethodPictureCode > 0))
                         .ForMember(dest => dest.BatchPrice, mo => mo.Condition(s => s.BatchPrice > 0))

                         .ForMember(dest => dest.Brand, mo => mo.Condition(s => !string.IsNullOrEmpty(s.Brand)))
                         .ForMember(dest => dest.CategoryClass, mo => mo.Condition(s => !string.IsNullOrEmpty(s.CategoryClass)))
                         .ForMember(dest => dest.Component, mo => mo.Condition(s => !string.IsNullOrEmpty(s.Component)))


                         .ForMember(dest => dest.ExecStandard, mo => mo.Condition(s => !string.IsNullOrEmpty(s.ExecStandard)))
                         .ForMember(dest => dest.Filler, mo => mo.Condition(s => !string.IsNullOrEmpty(s.Filler)))
                         .ForMember(dest => dest.ProductCategory1, mo => mo.Condition(s => !string.IsNullOrEmpty(s.ProductCategory1)))
                         .ForMember(dest => dest.ProductCategory2, mo => mo.Condition(s => !string.IsNullOrEmpty(s.ProductCategory2)))
                         .ForMember(dest => dest.ProductCategory3, mo => mo.Condition(s => !string.IsNullOrEmpty(s.ProductCategory3)))
                         .ForMember(dest => dest.ProductName, mo => mo.Condition(s => !string.IsNullOrEmpty(s.ProductName)))
                         .ForMember(dest => dest.ProductTitle, mo => mo.Condition(s => !string.IsNullOrEmpty(s.ProductTitle)))
                         .ForMember(dest => dest.QualityGrade, mo => mo.Condition(s => !string.IsNullOrEmpty(s.QualityGrade)))
                         .ForMember(dest => dest.SafetyCass, mo => mo.Condition(s => !string.IsNullOrEmpty(s.SafetyCass)))
                         .ForMember(dest => dest.Season, mo => mo.Condition(s => !string.IsNullOrEmpty(s.Season)))
                         .ForMember(dest => dest.Sex, mo => mo.Condition(s => !string.IsNullOrEmpty(s.Sex)))
                         .ForMember(dest => dest.WashingMethodPicture, mo => mo.Condition(s => !string.IsNullOrEmpty(s.WashingMethodPicture)))

                ;
        }
        public static IMappingExpression<Product, Inman_Product> ToProduct(IMapperConfigurationExpression config)
        {
            return config.CreateMap<Product, Inman_Product>()

                         .ForMember(dest => dest.Id, mo => mo.MapFrom(s => s.Id))
                         .ForMember(dest => dest.ProductSN, mo => mo.MapFrom(s => s.ProductSN))
                         .ForMember(dest => dest.Remark, mo => mo.MapFrom(s => s.Remark))
                         .ForMember(dest => dest.PicturePath, mo => mo.MapFrom(s => s.PicturePath))
                         .ForMember(dest => dest.ProductSN, mo => mo.MapFrom(s => s.ProductSN))
                         .ForMember(dest => dest.GoodsId, mo => mo.Ignore())//mo.MapFrom(s => s.GoodsId)
                         .ForMember(dest => dest.ColorID, mo=>mo.Ignore() )//mo => mo.MapFrom(s => s.ColorId)
                         .ForMember(dest => dest.CreatedOn, mo => mo.Ignore())
                ;
        }

        public static IMappingExpression<Product, Inman_Goods> ToGoods(IMapperConfigurationExpression config)
        {
            return config.CreateMap<Product, Inman_Goods>()

                         .ForMember(dest => dest.Id, mo => mo.MapFrom(s => s.Id))
                         .ForMember(dest => dest.ProductSN, mo => mo.MapFrom(s => s.ProductSN))
                         .ForMember(dest => dest.BatchPrice, mo => mo.MapFrom(s => s.BatchPrice))
                         .ForMember(dest => dest.ProductName, mo => mo.MapFrom(s => s.ProductName))
                         .ForMember(dest => dest.ProductYear, mo => mo.MapFrom(s => s.ProductYear))
                         .ForMember(dest => dest.FOBCost, mo => mo.MapFrom(s => s.FOBCost))
                         .ForMember(dest => dest.SalesPrice, mo => mo.MapFrom(s => s.SalesPrice))
                         .ForMember(dest => dest.TagPrice, mo => mo.MapFrom(s => s.TagPrice))
                         .ForMember(dest => dest.QualityGrade, mo => mo.MapFrom(s => s.QualityGrade))
                         .ForMember(dest => dest.ExecStandard, mo => mo.MapFrom(s => s.ExecStandard))
                         .ForMember(dest => dest.Filler, mo => mo.MapFrom(s => s.Filler))
                         .ForMember(dest => dest.Season, mo => mo.MapFrom(s => s.Season))
                         .ForMember(dest => dest.Brand, mo => mo.MapFrom(s => s.Brand))
                         .ForMember(dest => dest.Sex, mo => mo.MapFrom(s => s.Sex))
                         .ForMember(dest => dest.ProductCategory1, mo => mo.MapFrom(s => s.ProductCategory1))
                         .ForMember(dest => dest.ProductCategory2, mo => mo.MapFrom(s => s.ProductCategory2))
                         .ForMember(dest => dest.ProductCategory3, mo => mo.MapFrom(s => s.ProductCategory3))
                         .ForMember(dest => dest.WashingMethodPictureCode, mo => mo.MapFrom(s => s.WashingMethodPictureCode))
                         .ForMember(dest => dest.ProductCost, mo => mo.MapFrom(s => s.ProductCost))
                         .ForMember(dest => dest.WashingMethodPicture, mo => mo.MapFrom(s => s.WashingMethodPicture))
                         .ForMember(dest => dest.CategoryClass, mo => mo.MapFrom(s => s.CategoryClass))
                         .ForMember(dest => dest.Component, mo => mo.MapFrom(s => s.Component))
                         .ForMember(dest => dest.DesignID, mo => mo.MapFrom(s => s.DesignID))
                         .ForMember(dest => dest.DevCost, mo => mo.MapFrom(s => s.DevCost))
                         .ForMember(dest => dest.InternalPrice, mo => mo.MapFrom(s => s.InternalPrice))
                         .ForMember(dest => dest.IsEmergency, mo => mo.MapFrom(s => s.IsEmergency))
                         .ForMember(dest => dest.IsUploadK3, mo => mo.MapFrom(s => s.IsUploadK3))
                         .ForMember(dest => dest.ProcessingCost, mo => mo.MapFrom(s => s.ProcessingCost))
                         .ForMember(dest => dest.CreatedOn, mo => mo.Ignore())
                ;
        }
    }
}
