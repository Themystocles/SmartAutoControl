using Controle.ConexãoBD;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Models
{
    public class LembretesModel
    {
        public int IdLembrete { get; set; }
        public string Lembretes { get; set; }

        public string idusuarioLogado { get; set; }



        public IHttpContextAccessor HttpContextAccessor { get; set; }


        public LembretesModel( ) { }

        public LembretesModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public List<LembretesModel> ListaLembretes()
        {
            List<LembretesModel> lista = new List<LembretesModel>();
            LembretesModel item;
            string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");

            string sql = $"SELECT IDLEMBRETE, LEMBRETE, idusuarioLogado FROM LEMBRETES WHERE idusuarioLogado = {id_usuario_logado}";
            DAL objDal = new DAL();
            DataTable dt = objDal.RetdataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new LembretesModel();
                item.IdLembrete = int.Parse(dt.Rows[i]["IDLEMBRETE"].ToString());
                item.Lembretes = dt.Rows[i]["LEMBRETE"].ToString();
                item.idusuarioLogado = dt.Rows[i]["idusuarioLogado"].ToString();

                lista.Add(item);
            }
            return lista;
        }
        public void Insert()
        {
            string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");

            string sql = $"INSERT INTO Lembretes (LEMBRETE , IDUSUARIOLOGADO) VALUES ('{Lembretes}','{id_usuario_logado}') ";
            DAL objDal = new DAL();
            objDal.ExecutaComandosSQL(sql);

        }

        public void Excluir(int IdLembrete)
        {
            new DAL().ExecutaComandosSQL("DELETE FROM Lembretes WHERE IDLEMBRETE =" + IdLembrete);
        }
    }

}
