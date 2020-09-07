using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using ClothingShope.ItemCatogriesAppServices.Dto;
using ClothingShope.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShope.ItemAppServices
{
    public class ItemAppService : AsyncCrudAppService<Item, ItemDto, long, PagedAndSortedResultRequestDto, CreateItemDto, UpdateItemDto>, IItemAppService
    {
        public ItemAppService(IRepository<Item, long> repository) : base(repository)
        {

        }
    }
}
