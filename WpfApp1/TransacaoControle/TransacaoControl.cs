using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using TransacaoEntidade;
using System.Reflection;

namespace TransacaoControle
{    
    public class TransacaoControl
    {
        private string _nomeArquivoExcel;
        private IList<Transacao> _dados;
        public TransacaoControl()
        {
            _nomeArquivoExcel = "D:\\PROJETO\\TESTE_EMPREGO\\CaseCapta\\Dados.xls";
           _dados= CarregaDados();
        }

        public TransacaoControl(string nomeArquivo)
        {
            _nomeArquivoExcel = nomeArquivo;
            _dados = CarregaDados();
        }
        private IList<Transacao> CarregaDados()
        {
            IList<Transacao> resultado = new List<Transacao>();

            string excelcn1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _nomeArquivoExcel + ";";
            string excelcn2 = "Extended Properties='Excel 8.0;HDR=YES;'";

                    string excelConnectionString = excelcn1 + excelcn2;
            using (System.Data.OleDb.OleDbConnection connection = new OleDbConnection (excelConnectionString))
            {
                string sql = "SELECT TransactionId,MerchantCnpj,CheckoutCode,CipheredCardNumber,AmountInCent,Installments,AcquirerName,PaymentMethod,CardBrandName,Status,StatusInfo,CreatedAt,AcquirerAuthorizationDateTime FROM [Dados$]";
                OleDbCommand comando = new OleDbCommand(sql, connection);
                connection.Open();
                using (OleDbDataReader dr = comando.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Transacao tr = new Transacao(dr.GetString(1), Int32.Parse(dr.GetString(2)), dr.GetString(3),
                                                                       Int32.Parse(dr.GetValue(4).ToString()), Int32.Parse(dr.GetValue(5).ToString()), dr.GetString(6),
                                                                       dr.GetString(7), dr.GetString(8), dr.GetString(9),
                                                                       dr.GetString(10), DateTime.Parse(dr.GetString(11)), DateTime.Parse(dr.GetString(12)));
                            resultado.Add(tr);
                        }
                    }              
                }


            }

            return resultado;
        }

        /// <summary>
        /// Faz um filtro através dos dados solicitados.
        /// </summary>
        /// <param name="merchantCnpj">CNPJ</param>
        /// <param name="acquirerName">Nome da máquina que adquiriu os dados</param>
        /// <param name="cardBrandName">Bandeira do cartão</param>
        /// <param name="dayAcquirerAuthorizationDateTime">Quantidade de dias (anterior o de hoje) que deseja ver o relatorio</param>
        /// <param name="dataCAcquirerAuthorizationDateTimereateAt">Data que deseja ver o relatório</param>
        /// <returns></returns>
        public IList<Transacao> Filtro(string merchantCnpj
                                     , string acquirerName
                                     , string cardBrandName
                                     , int dayAcquirerAuthorizationDateTime
                                     , System.DateTime? dataCAcquirerAuthorizationDateTimereateAt = null)
        {
            IList<Transacao> resultado = _dados;
            if (merchantCnpj != "")
            {
               resultado= resultado.Where(p => p.MerchantCnpj.Contains(merchantCnpj)).ToList();
            }
            if (acquirerName != "")
            {
                resultado = resultado.Where(p => p.AcquirerName.Contains(acquirerName)).ToList();
            }
            if (cardBrandName != "")
            {
                resultado = resultado.Where(p => p.CardBrandName.Contains(cardBrandName)).ToList();
            }
            if (dayAcquirerAuthorizationDateTime > -1)
            {
                resultado = resultado.Where(p => p.AcquirerAuthorizationDateTime >= DateTime.Now.AddDays(System.Convert.ToDouble(-dayAcquirerAuthorizationDateTime))).ToList();
            }
            if (dataCAcquirerAuthorizationDateTimereateAt.HasValue)
            {
                resultado = resultado.Where(p => p.AcquirerAuthorizationDateTime.Day == dataCAcquirerAuthorizationDateTimereateAt.Value.Day && p.AcquirerAuthorizationDateTime.Month== dataCAcquirerAuthorizationDateTimereateAt.Value.Month && p.AcquirerAuthorizationDateTime.Year== dataCAcquirerAuthorizationDateTimereateAt.Value.Year).ToList();
            }
         return resultado;
        }

        /// <summary>
        /// Filtra os dados no formato de DataTable para que possa ser preenchido no DataGridView
        /// </summary>
        /// <param name="merchantCnpj">CNPJ</param>
        /// <param name="acquirerName">Nome da máquina que adquiriu os dados</param>
        /// <param name="cardBrandName">Bandeira do cartão</param>
        /// <param name="dayCAcquirerAuthorizationDateTimereateAt">Quantidade de dias (anterior o de hoje) que deseja ver o relatorio</param>
        /// <param name="dataCAcquirerAuthorizationDateTimereateAt">Data que deseja ver o relatório</param>
        /// <returns></returns>
        public DataTable FiltroDataTable(string merchantCnpj
                                     , string acquirerName
                                     , string cardBrandName
                                     , int dayCAcquirerAuthorizationDateTimereateAt
                                     , System.DateTime? dataCAcquirerAuthorizationDateTimereateAt = null)
        {
            DataTable resultado = ToDataTable<Transacao>(Filtro(merchantCnpj,acquirerName, cardBrandName, dayCAcquirerAuthorizationDateTimereateAt, dataCAcquirerAuthorizationDateTimereateAt));
            
            return resultado;

        }

        /// <summary>
        /// Inicializa os dados
        /// </summary>
        /// <returns></returns>
        public DataTable Inicializa()
        {
            DataTable resultado = ToDataTable<Transacao>(_dados);
            return resultado;
        }

        private static DataTable ToDataTable<T>(IList<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}
