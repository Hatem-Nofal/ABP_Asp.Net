using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ClothingShope.ItemCatogriesAppServices.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShope.ItemCatogriesAppServices
{
    public interface IItemCatogriesAppService : IAsyncCrudAppService<ItemCategoryDto, long, PagedAndSortedResultRequestDto, CreateItemCategoryDto, UpdateItemCategoryDto>
    {
    }
}
