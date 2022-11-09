using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria {get;}

        List<Expression<Func<T, object>>> Includes {get;}

        Expression<Func<T, object>> OrderBy{get;set;}
        Expression<Func<T, object>> OrderByDesc{get;set;}
        
    }
}