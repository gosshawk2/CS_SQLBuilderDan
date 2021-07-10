using System;
using System.Collections.Generic;
using System.Text;

namespace CS_SQLBuilderDan
{
    class HeaderList
    {
        public int DatasetID { get; set; }
        public string DBType { get; set; }
        public string ConString { get; set; }
        public string DatabaseName { get; set; }
        public string DatasetName { get; set; }
        public string DatasetHeaderText { get; set; }
        public string Description { get; set; }
        public string ServerName { get; set; }
        public string ServerInstance { get; set; }
        public string ComputerName { get; set; }
        public string IPAddr4 { get; set; }
        public string TableName { get; set; }
        public string LibraryName { get; set; }
        public string Port { get; set; }
        public string DatasetType { get; set; }
        public int AuthorityFlag { get; set; }
        public string DatasetLevel { get; set; }
        public int Status { get; set; }
        public string SortField { get; set; }
        public string FileLocation { get; set; }
        public string ImportedBy { get; set; }
        public DateTime ImportDate { get; set; }
        public string ChangedBy { get; set; }
        public DateTime ChangeDate { get; set; }
        public int TotalRecords { get; set; }
        public bool Tables { get; set; }
        public bool Views { get; set; }
    }
}
