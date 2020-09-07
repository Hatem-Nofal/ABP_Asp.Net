using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ClothingShope.ItemCatogriesAppServices.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShope.ItemAppServices
{
    public interface IItemAppService : IAsyncCrudAppService<ItemDto, long, PagedAndSortedResultRequestDto, CreateItemDto, UpdateItemDto>
    {

    }
}
