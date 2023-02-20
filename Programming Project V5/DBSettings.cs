using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Programming_Project_V5
{
    public static  class DBSettings
    {
       public static string CString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\carla\\Documents\\Computer Science\\NEA Progamming Project\\Programming Project V5\\DBofAll.mdb\"";
       public static OleDbConnection connection = new OleDbConnection(CString);
    }

}
