using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T> where T : BaseEntity
    {
        public BaseSpecification()
        {
            
        }
        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }
        public Expression<Func<T, bool>> Criteria {get;}
        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();
        public Expression<Func<T, object>> OrderBy { get ;  private set ; }
        public Expression<Func<T, object>> OrderByDesc { get ;  private set ; }
        public int Take {get; private set;}
        public int Skip {get; private set;}
        public bool IsPagingEnabled {get; private set;}
        protected void ApplyPaging (int skip, int take){
            this.Take = take;
            this.Skip = skip;
            this.IsPagingEnabled = true;
        }
        protected void AddInclude(Expression<Func<T, object>> includes)
        {
            Includes.Add(includes);
        }
        protected void AddOrderBy(Expression<Func<T,object>> orderByExpression)
        {

            OrderBy = orderByExpression;
        }
        protected void AddOrderByDesc(Expression<Func<T,object>> orderByDescExpression)
        {

            OrderByDesc = orderByDescExpression;
        }
    }
}