using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Areas.ViewModels
{
    public class PageNationList<T> : List<T>
    {
        public PageNationList(IQueryable<T> entities, int pageIndex, int totalPages )
        {
            TotalPages = totalPages;
            PageIndex = pageIndex;

            AddRange(entities);
        } 
        public int TotalPages { get; set; }
        public int PageIndex { get; set; }

        public static PageNationList<T> Create(IQueryable<T> entities, int pageIndex, int pageItemCount)
        {
            int totalPages = (int)Math.Ceiling((decimal)entities.Count() / 5);

            if (pageIndex < 1 || pageIndex > totalPages)
            {
                pageIndex = 1;
            }

            entities = entities
           .Skip((pageIndex - 1) * pageItemCount)
           .Take(5);

            return new PageNationList<T>(entities, pageIndex, totalPages);

        }
    }
}
