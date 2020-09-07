using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ClothingShope.Items;
using ClothingShope.ItemsCategories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShope.ItemCatogriesAppServices.Dto
{
    [AutoMap(typeof(Item))]
    public class CreateItemDto : EntityDto<long>
    {
        public string name { get; set; }
        public string imageUrl { get; set; }
        public double Price { get; set; }
        public long itemCategoryId { get; set; }
    }
}
