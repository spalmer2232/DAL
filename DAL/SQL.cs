using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Net;
using System.IO;


namespace DAL
{
    public class SQL
    {

        #region Properties
        private  DataTable _AllData;
        public  DataTable AllData
        {
            get
            {
                return _AllData;
            }
            set
            {
                _AllData = value;
            }
        }

        private  DataTable _MyDataTable;
        public  DataTable MyDataTable
        {
            get
            {
                return _MyDataTable;
            }
            set
            {
                _MyDataTable = value;
            }
        }

        #endregion

        private  string sql = string.Empty;
 
        public  string HelloWorld()
        {
            return "Hello World";
        }

        public void Select()
        {
            MSSQL DB = new MSSQL();
            DB.OpenConnection();
            string sql = "Select * from TimeSlice";
            AllData = DB.GetDataTable(sql);
            DB.CloseConnection();
        }


    }
}
