﻿namespace Entity.ProductEntity
{
    public class Product
    {
        public Guid ID { set; get; }
        
        public string Designation { set; get; }
        
        public string UnitMeasure { set; get; }

        public string DefaultTVARate { set; get; }
    }
}