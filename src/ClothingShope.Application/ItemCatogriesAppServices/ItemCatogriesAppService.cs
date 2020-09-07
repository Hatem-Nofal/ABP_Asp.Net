using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using ClothingShope.ItemCatogriesAppServices.Dto;
using ClothingShope.ItemsCategories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShope.ItemCatogriesAppServices
{
    class ItemCatogriesAppService : AsyncCrudAppService<itemCategory, ItemCategoryDto, long, PagedAndSortedResultRequestDto, CreateItemCategoryDto, UpdateItemCategoryDto>, IItemCatogriesAppService
    {

        public ItemCatogriesAppService(IRepository<itemCategory, long> repository) : base(repository)
        {

        }
    }
}
