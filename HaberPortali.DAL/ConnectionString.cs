using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.DAL
{
    class ConnectionString
    {
        internal static string ConnectionStr
        {
            get { return "Server=DESKTOP-9O81J9B\\SQLEXPRESS; Database=HaberDB; Integrated Security = True;"; }

            //get { return "Server=.; Database=HaberDB; Uid=sa; Pwd=123"; } MultipleActiveResultSets =true;
        }
    }
}
