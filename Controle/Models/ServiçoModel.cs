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
    public class ServiçoModel
    {
        public int IdS { get; set; }
        public string Tipo { get; set; }
        public string Custo { get; set; }
        public string Estoque { get; set; }
        public string Dataentrada { get; set; }
        public string DataSaida { get; set; }
        public string Obs { get; set; }
        public string iDUsuario { get; set; }
        [Required(ErrorMessage = "Esse campo não pode ser vazio")]
        public string CpfCli { get; set; }
        [Required(ErrorMessage = "Esse campo não pode ser vazio")]
        public string Placa { get; set; }

        public IHttpContextAccessor HttpContextAccessor { get; set; }



        public ServiçoModel()
        {

        }
        // recebe o contexto para acesso as variaveis de sessão
        public ServiçoModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        //MINHA LISTA DE SERVIÇOS
        public List<ServiçoModel> ListaServiço()
        {
            List<ServiçoModel> lista = new List<ServiçoModel>();
            ServiçoModel item;
            string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $" SELECT IDS, TIPO, CUSTO, ESTOQUE, DATTAENTRADA, DATASAIDA, OBS, IDUSUARIO, CpfCli, PLACA  FROM SERV WHERE IDUSUARIO = {id_usuario_logado}";
            DAL objDal = new DAL();
            DataTable dt = objDal.RetdataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ServiçoModel();

                item.IdS = int.Parse(dt.Rows[i]["IDS"].ToString());
                item.Tipo = dt.Rows[i]["TIPO"].ToString();
                item.Custo = dt.Rows[i]["CUSTO"].ToString();
                item.Estoque = dt.Rows[i]["ESTOQUE"].ToString();
                item.Dataentrada = dt.Rows[i]["DATTAENTRADA"].ToString();
                item.DataSaida = dt.Rows[i]["DATASAIDA"].ToString();
                item.Obs = dt.Rows[i]["OBS"].ToString();
                item.iDUsuario = dt.Rows[i]["IdUsuario"].ToString();
                item.CpfCli = dt.Rows[i]["CPFCLI"].ToString();
                item.Placa = dt.Rows[i]["placa"].ToString();


                lista.Add(item);
            }
            return lista;

        }

        public ServiçoModel CarregarRegistro(int? Ids)
        {
            ServiçoModel item = new ServiçoModel();

            string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $" SELECT IDS, TIPO, CUSTO, ESTOQUE, DATTAENTRADA, DATASAIDA, OBS, IDUSUARIO, CpfCli, PLACA  FROM SERV where IDS = {Ids} ";
            DAL OBJdAL = new DAL();
            DataTable dt = OBJdAL.RetdataTable(sql);


            item.IdS = int.Parse(dt.Rows[0]["IDS"].ToString());
            item.Tipo = dt.Rows[0]["TIPO"].ToString();
            item.Custo = dt.Rows[0]["CUSTO"].ToString();
            item.Estoque = dt.Rows[0]["ESTOQUE"].ToString();
            item.Dataentrada = dt.Rows[0]["DATTAENTRADA"].ToString();
            item.DataSaida = dt.Rows[0]["DATASAIDA"].ToString();
            item.Obs = dt.Rows[0]["OBS"].ToString();
            item.iDUsuario = dt.Rows[0]["IdUsuario"].ToString();
            item.CpfCli = dt.Rows[0]["CPFCLI"].ToString();
            item.Placa = dt.Rows[0]["placa"].ToString();
           





            return item;
        }







        public void Insert()
        {
            string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"INSERT INTO SERV (TIPO, CUSTO, ESTOQUE, DAtTAENTRADA, DATASAIDA, OBS, IDUSUARIO, CpfCli, PLACA ) VALUES  ('{Tipo}','{Custo}','{Estoque}','{Dataentrada}','{DataSaida}','{Obs}','{id_usuario_logado}','{CpfCli}','{Placa}') ";
            DAL objDal = new DAL();
            objDal.ExecutaComandosSQL(sql);

        }

        public void Excluir(int IdServiço)
        {
            new DAL().ExecutaComandosSQL("DELETE FROM SERV WHERE IDS =" + IdServiço);
        }
    }



}