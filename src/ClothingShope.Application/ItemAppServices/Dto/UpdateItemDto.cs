using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ClothingShope.Items;


namespace ClothingShope.ItemCatogriesAppServices.Dto
{
    [AutoMap(typeof(Item))]
    public class UpdateItemDto : EntityDto<long>
    {
        public string name { get; set; }
        public string imageUrl { get; set; }
        public double Price { get; set; }
        public long itemCategoryId { get; set; }
    }
}
