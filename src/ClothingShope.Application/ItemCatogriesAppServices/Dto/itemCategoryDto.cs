using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ClothingShope.Items;
using ClothingShope.ItemsCategories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShope.ItemCatogriesAppServices.Dto
{
    [AutoMap(typeof(itemCategory))]

    public class ItemCategoryDto : EntityDto<long>
    {
        public string Title { get; set; }
        public string RouteName { get; set; }
        public List<Item> Items { get; set; }
    }
}
