using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGrid.Grid
{
    public class ColumnsConifg
    {
        public string ColumnName { get; set; }

        public string Caption { get; set; }

        public DataType DataType { get; set; }

        public string Format { get; set; }

        public Alignment Alignment { get; set; }

        public SortOrder SortOrder { get; set; }
    }
}
