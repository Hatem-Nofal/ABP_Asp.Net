using Abp.Domain.Entities.Auditing;
using ClothingShope.ItemsCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClothingShope.Items
{
    public class Item : AuditedEntity<long>
    {
        public string name { get; set; }
        public string imageUrl { get; set; }
        public double Price { get; set; }

        [ForeignKey("itemCategory")]
        public long itemCategoryId { get; set; }
        public itemCategory itemCategory { get; set; }



    }
}
