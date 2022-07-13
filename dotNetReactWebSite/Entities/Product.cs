using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetReactWebSite.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public string PictureURL {get;set;} = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public int InStockQTY { get; set; }

    }
}