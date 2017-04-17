using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ContractLicence
{
    public interface IConnection
    {
        SqlConnection Connection { get; }
    }
}
