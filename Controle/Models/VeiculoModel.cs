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
    public class VeiculoModel
    {
        public int Idveiculo { get; set; }
        public string Marca { get; set; }
        [Required(ErrorMessage = "Esse campo não pode ser vazio")]
        public string Placa { get; set; }
        public int Anofabrica { get; set; }
        public int Anomodelo { get; set; }
        public string Potencia { get; set; }
        public string Capacidade { get; set; }
        public string Cor { get; set; }

        public string Especie { get; set; }
        public string Combustivel { get; set; }

        public string Chassi { get; set; }
        public string Cliente_idCliente { get; set; }
        [Required(ErrorMessage = "Esse campo não pode ser vazio")]
        public string CpfCliente { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public VeiculoModel()
        {

        }
        // recebe o contexto para acesso as variaveis de sessão
        public VeiculoModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        public List<VeiculoModel> ListaVeiculo()
        {
            List<VeiculoModel> lista = new List<VeiculoModel>();
            VeiculoModel item;
            string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"SELECT IDVEICULO, MARCA, PLACA, ANOFABRICA, ANOMODELO, POTENCIA, CAPACIDADE, COR, ESPECIE, COMBUSTIVEL, CHASSI,  CLIENTE_IDCLIENTE, CPFCLIENTE FROM VEICULO WHERE CLIENTE_IDCLIENTE = {id_usuario_logado}";
            DAL objDal = new DAL();
            DataTable dt = objDal.RetdataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new VeiculoModel();

                item.Idveiculo = int.Parse(dt.Rows[i]["IDVEICULO"].ToString());
                item.Marca = dt.Rows[i]["MARCA"].ToString();
                item.Placa = dt.Rows[i]["PLACA"].ToString();
                item.Anofabrica = int.Parse(dt.Rows[i]["ANOFABRICA"].ToString());
                item.Anomodelo = int.Parse(dt.Rows[i]["ANOMODELO"].ToString());
                item.Potencia = dt.Rows[i]["POTENCIA"].ToString();
                item.Capacidade = dt.Rows[i]["CAPACIDADE"].ToString();
                item.Cor = dt.Rows[i]["COR"].ToString();
                item.Especie = dt.Rows[i]["ESPECIE"].ToString();
                item.Combustivel = dt.Rows[i]["COMBUSTIVEL"].ToString();
                item.Chassi = dt.Rows[i]["CHASSI"].ToString();
                item.Cliente_idCliente = dt.Rows[i]["CLIENTE_IDCLIENTE"].ToString();
                item.CpfCliente = dt.Rows[i]["CPFCLIENTE"].ToString();

                lista.Add(item);
            }
            return lista;
        }
        public void Insert()
        {
            string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"INSERT INTO veiculo ( Marca, Placa, AnoFabrica, AnoModelo, Potencia, Capacidade, Cor, Especie, Combustivel, Chassi, Cliente_idCliente, CpfCliente) VALUES  ('{Marca}','{Placa}','{Anofabrica}','{Anomodelo}','{Potencia}','{Capacidade}','{Cor}','{Especie}','{Combustivel}','{Chassi}', '{id_usuario_logado}', '{CpfCliente}') ";
            DAL objDal = new DAL();
            objDal.ExecutaComandosSQL(sql);

        }

        public void Excluir(int Idveiculo )
        {
            new DAL().ExecutaComandosSQL("DELETE FROM VEICULO WHERE idveiculo =" + Idveiculo );
        }
    }
}
