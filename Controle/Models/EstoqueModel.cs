using Controle.ConexãoBD;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Models
{
    public class EstoqueModel
    {
         
        public int IdEstoque { get; set; }
        public string Equipamentos { get; set; }

        public int Quantidade { get; set; }

        public string Calendario { get; set; }
        public string IdUsuario { get; set; }



        public IHttpContextAccessor HttpContextAccessor { get; set; }


        public EstoqueModel() { }

        public EstoqueModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public List<EstoqueModel> ListaEstoque()
        {
            List<EstoqueModel> lista = new List<EstoqueModel>();
            EstoqueModel item;
            string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");

            string sql = $"SELECT IDESTOQUE, EQUIPAMENTOS, QUANTIDADE, CALENDARIO, IDUSUARIO FROM ESTOQUE   WHERE IDUSUARIO = {id_usuario_logado}";
            DAL objDal = new DAL();
            DataTable dt = objDal.RetdataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new EstoqueModel();
                item.IdEstoque = int.Parse(dt.Rows[i]["IDESTOQUE"].ToString());
                item.Equipamentos = dt.Rows[i]["EQUIPAMENTOS"].ToString();
                item.Quantidade = int.Parse(dt.Rows[i]["QUANTIDADE"].ToString());
                item.IdUsuario = dt.Rows[i]["IDUSUARIO"].ToString();

                lista.Add(item);
            }
            return lista;
        }
        public void Insert()
        {
            string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");

            string sql = $"INSERT INTO ESTOQUE (EQUIPAMENTOS, QUANTIDADE, IDUSUARIO) VALUES ('{Equipamentos}','{Quantidade}','{id_usuario_logado}') ";
            DAL objDal = new DAL();
            objDal.ExecutaComandosSQL(sql);

        }

        public void Excluir(int IdEstoque)
        {
            new DAL().ExecutaComandosSQL("DELETE FROM ESTOQUE WHERE IDESTOQUE =" + IdEstoque);
        }




        public void Mais()

        {
            EstoqueModel objEstoque = new EstoqueModel();

            var soma = objEstoque.Equipamentos + 1 ;


            
        }

        public void Mais(IHttpContextAccessor httpContextAccessor)

        {
            EstoqueModel objEstoque = new EstoqueModel();

            var soma = objEstoque.Equipamentos + 1;



        }
    }

}

