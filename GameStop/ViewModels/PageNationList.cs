using GameStop.Models;
using GameStop.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewModels
{
    public class PageNationList<T> : List<T>
    {

        public PageNationList(IQueryable<T> entities, int page, int totalPages )
        {
            TotalPages = totalPages;
            PageIndex = page;

            int start = PageIndex - 2;
            int end = PageIndex + 2;

            if (start <= 0)
            {
                end = end -(start - 1);
                start = 1;
            }

            if (end > TotalPages)
            {
                end = TotalPages;

                if (end > 5)
                {
                    start = end - 4;
                }
            }

            Start = start;
            End = end;



            AddRange(entities);
        }

        public int TotalPages { get; }
        public int PageIndex { get; }

        public bool HasNext => PageIndex < TotalPages;
        public bool HasPrev => PageIndex > 1 ;
        public int Start { get; }
        public int End { get; }

        public static PageNationList<T> Create(IQueryable<T> entities, int page, int pageItemCount)
        {
            int totalPages = (int)Math.Ceiling((decimal)entities.Count() / pageItemCount);

            if (page < 1 || page > totalPages)
            {
                page = 1;
            }

            entities = entities
           .Skip((page - 1) * pageItemCount)
           .Take(pageItemCount);

            return new PageNationList<T>(entities, page, totalPages);

        }
    }
}
