using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SQLBuilderDan
{
    class TableDetail
    {
        public int ColumnID { get; set; }
        public string ColumnName { get; set; }
        public string ColumnText { get; set; }
        public string ServerName { get; set; }
        public string ServerInstance { get; set; }
        public string ComputerName { get; set; }
        public string IPAddr4 { get; set; }
        public string DatabaseName { get; set; }
        public string Port { get; set; }
        public string TableName { get; set; }
        public int Sequence { get; set; }
        public string LibraryName { get; set; }
        public string ColumnType { get; set; }
        public string ColumnTypeInternal { get; set; }
        public int AuthorityFlag { get; set; }
        public int ColumnLength { get; set; }
        public int ColumnDecimals { get; set; }
        public int ColumnDecimalsDB { get; set; }
        public string ColumnAlias { get; set; }
        public string ColumnHeading { get; set; }
        public string ImportedBy { get; set; }
        public DateTime ImportDate { get; set; }
        public string ChangedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public int Status { get; set; }
        public int HeaderID { get; set; }
        public string SortField { get; set; }
        public bool IsPrimaryKey { get; set; }
    }
}
