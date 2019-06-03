using Controle.ConexãoBD;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Models
{
    public class UsuarioModel
    {
      
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "Esse campo não pode ser vazio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Esse campo não pode ser vazio")]
        public string  Email { get; set; }
        [Required(ErrorMessage = "Esse campo não pode ser vazio")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Esse campo não pode ser vazio")]
        public string DataNascimento { get; set; }

        public bool ValidarLogin()
        {
            string sql = $"SELECT IDUSUARIO, NOME, DATANASCIMENTO FROM USUARIO WHERE EMAIL= '{Email}' AND SENHA='{Senha}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetdataTable(sql);
             
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    IdUsuario = int.Parse(dt.Rows[0]["IDUsuario"].ToString());
                    Nome = dt.Rows[0]["NOME"].ToString();
                    DataNascimento = dt.Rows[0]["DATANASCIMENTO"].ToString();
                    return true;
                }
            }
            return false;
        }
        public void RegistrarUsuario()
        {
            string dataNascimento = DateTime.Parse(DataNascimento).ToString("yyy/MM/dd");
            //Interpolação de strings $
            string sql = $"INSERT INTO USUARIO (NOME, EMAIL, SENHA, DATANASCIMENTO) VALUES" +
                $" ('{Nome}','{Email}','{Senha}','{DataNascimento}')";
            DAL objDal = new DAL();
            objDal.ExecutaComandosSQL(sql);
        }
    }


}
