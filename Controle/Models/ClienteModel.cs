using Controle.ConexãoBD;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Models
{
    public class ClienteModel
    {
        [Required(ErrorMessage = "Esse campo não pode ser vazio")]
        public int IdCliente { get; set; }
        [Required(ErrorMessage = "Esse campo não pode ser vazio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Esse campo não pode ser vazio")]
        public string  Cpf { get; set; }
        public string  RuaBairroNumero { get; set; }
        public string Cidade { get; set; }
        public string  Responsavel { get; set; }
        public string Telefone { get; set; }
        public int Usuario_idUsuario { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public ClienteModel()
        {

        }
        // recebe o contexto para acesso as variaveis de sessão
        public ClienteModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }


        
        public List<ClienteModel> ListaCliente()
        {
            List<ClienteModel> lista = new List<ClienteModel>();
            ClienteModel item;
            string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");

            string sql = $"SELECT IDCLIENTE, NOME, CPF, RUABAIRRONUMERO, CIDADE, RESPONSAVEL, TELEFONE, USUARIO_IDUSUARIO FROM CLIENTE WHERE USUARIO_IDUSUARIO = {id_usuario_logado}";
            DAL objDal = new DAL();
            DataTable dt = objDal.RetdataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ClienteModel();
                item.IdCliente = int.Parse(dt.Rows[i]["IDCLIENTE"].ToString());
                item.Nome = dt.Rows[i]["NOME"].ToString();
                item.Cpf = dt.Rows[i]["CPF"].ToString();
                item.RuaBairroNumero = dt.Rows[i]["RUABAIRRONUMERO"].ToString();
                item.Cidade = dt.Rows[i]["CIDADE"].ToString();
                item.Responsavel = dt.Rows[i]["RESPONSAVEL"].ToString();
                item.Telefone = dt.Rows[i]["TELEFONE"].ToString();
                item.Usuario_idUsuario = int.Parse(dt.Rows[i]["USUARIO_IDUSUARIO"].ToString());
                lista.Add(item);
            }
            return lista;
        }

        public void Insert()
        {
            string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            
            string sql = $"INSERT INTO CLIENTE (NOME, CPF, RUABAIRRONUMERO, CIDADE, RESPONSAVEL, TELEFONE, USUARIO_IDUSUARIO) VALUES ('{Nome}','{Cpf}','{RuaBairroNumero}',default ,'{Responsavel}','{Telefone}','{id_usuario_logado}') ";
            DAL objDal = new DAL();
            objDal.ExecutaComandosSQL(sql);

        }

        public void Excluir(int idcliente)
        {
            new DAL().ExecutaComandosSQL("DELETE FROM CLIENTE WHERE IDCLIENTE =" + idcliente);
        }

    }
}
