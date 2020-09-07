using Abp.Domain.Entities.Auditing;
using ClothingShope.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShope.ItemsCategories
{
    public class itemCategory : AuditedEntity<long>
    {
        public string Title { get; set; }
        public string RouteName { get; set; }
        public List<Item> Items { get; set; }
    }
}
