using Controle.ConexãoBD;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Models
{
    public class RelatorioModel
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string RuaBairroNumero { get; set; }
        public string Cidade { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public int Usuario_idUsuario { get; set; }

        //Veiculo

        public int Idveiculo { get; set; }
        public string Marca { get; set; }

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

        public string CpfCliente { get; set; }

        //Serviço

        public int IdS { get; set; }
        public string Tipo { get; set; }
        public string Custo { get; set; }
        public string Estoque { get; set; }
        public string Dataentrada { get; set; }
        public string DataSaida { get; set; }
        public string Obs { get; set; }
        public string iDUsuario { get; set; }
        public string CpfCli { get; set; }

        public String placa { get; set; }




        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public RelatorioModel()
        {

        }
        // recebe o contexto para acesso as variaveis de sessão
        public RelatorioModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }



        public List<RelatorioModel> ListaRelatorio()
        {
            List<RelatorioModel> lista = new List<RelatorioModel>();
            RelatorioModel item;
            string id_usuario_logado = @HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"SELECT * FROM CLIENTE JOIN VEICULO JOIN SERV WHERE CLIENTE.CPF = '{Cpf}' AND VEICULO.CPFCLIENTE = '{Cpf}' AND SERV.PLACA = '{placa}' AND VEICULO.PLACA = '{placa}' ";
            DAL objDal = new DAL();
          
            DataTable dt = objDal.RetdataTable(sql);
           

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RelatorioModel();
                item.IdCliente = int.Parse(dt.Rows[i]["IDCLIENTE"].ToString());
                item.Nome = dt.Rows[i]["NOME"].ToString();
                item.Cpf = dt.Rows[i]["CPF"].ToString();
                item.RuaBairroNumero = dt.Rows[i]["RUABAIRRONUMERO"].ToString();
                item.Cidade = dt.Rows[i]["CIDADE"].ToString();
                item.Responsavel = dt.Rows[i]["RESPONSAVEL"].ToString();
                item.Telefone = dt.Rows[i]["TELEFONE"].ToString();
                item.Usuario_idUsuario = int.Parse(dt.Rows[i]["USUARIO_IDUSUARIO"].ToString());
                //veiculo
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

                // Serviços

                item.IdS = int.Parse(dt.Rows[i]["IDS"].ToString());
                item.Tipo = dt.Rows[i]["TIPO"].ToString();
                item.Custo = dt.Rows[i]["CUSTO"].ToString();
                item.Estoque = dt.Rows[i]["ESTOQUE"].ToString();
                item.Dataentrada = dt.Rows[i]["DATTAENTRADA"].ToString();
                item.DataSaida = dt.Rows[i]["DATASAIDA"].ToString();
                item.Obs = dt.Rows[i]["OBS"].ToString();
                item.iDUsuario = dt.Rows[i]["IDUSUARIO"].ToString();
                item.CpfCli = dt.Rows[i]["CPFCLI"].ToString();
                item.placa = dt.Rows[i]["placa"].ToString();


                lista.Add(item);

            }
            return lista;
        }
    }
}
