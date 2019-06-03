using Controle.ConexãoBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Models
{
    public class HomeModel
    {

        public string LerNomeUsuario()
        {
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetdataTable("select * from  usuario");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["nome"].ToString();
                }
            }

            return "nome não encontrado";

        }
    }
}
