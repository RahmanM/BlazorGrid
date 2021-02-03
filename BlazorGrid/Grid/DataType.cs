using System;
using System.Collections.Generic;

namespace BlazorGrid.Grid
{
    public enum DataType
    {
        String,
        Number,
        Currency,
        Date,
        DateTime,
        TrueFalse,
        NotSet
    }

    public enum SortOrder
    {
        NotSet,
        Asc,
        Desc
    }

    public class Paging
    {
        public int PageSize { get; set; }

        public bool PagingEnabled { get; set; }


        public int NumberOfItemsToSkip(int currentPage)
        {
            if (PagingEnabled)
            {
                return (currentPage - 1) * PageSize;
            }

            return 0;
        }

        public int NumberOfItemsToTake(int totalPages)
        {
            if (PagingEnabled)
            {
                return PageSize;
            }

            return totalPages;
        }

        public int PreviousPageNumber(int currentPageNumber)
        {
            if (currentPageNumber > 1)
            {
                return currentPageNumber - 1;
            }

            return 1;
        }

        public int NextPageNumber(int currentPageNumber, int totalPages)
        {
            if (currentPageNumber < MaxPageNumber(totalPages))
            {
                return currentPageNumber + 1;
            }

            return currentPageNumber;
        }

        private int MaxPageNumber(int totalPages)
        {
            int maxpageNumber;

            double numberOfPages = totalPages / (double) PageSize;

            if(numberOfPages == Math.Floor(numberOfPages))
            {
                maxpageNumber = (int)numberOfPages;
            }
            else
            {
                maxpageNumber = (int)numberOfPages + 1;
            }

            return maxpageNumber;
        }
    }
}
