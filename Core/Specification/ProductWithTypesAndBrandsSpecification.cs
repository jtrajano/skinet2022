using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specification
{
    public class ProductWithTypesAndBrandsSpecification: BaseSpecification<Product>
    {
        public ProductWithTypesAndBrandsSpecification(string sort)
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=> x.ProductBrand);
            switch (sort)
            {
                case "priceAsc":
                    AddOrderBy(p=>p.Price);
                    break;
                case "priceDesc":          
                    AddOrderByDescending(p=>p.Price);
                    break;
                default:
                    AddOrderBy(p=>p.Name);
                    break;
            }
      
        }
        
        public ProductWithTypesAndBrandsSpecification(int id): base(x=>x.Id == id)
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=> x.ProductBrand);
        }
    }
}