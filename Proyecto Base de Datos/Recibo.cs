using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Base_de_Datos
{
    public class Recibo
    {
        public string numFolio { get; set; }
        public string fecha { get; set; }
        public string importe { get; set; }
        public string importeLetra { get; set; }
        public string periodo { get; set; }
        public string reciboSocio { get; set; }
        public string reciboEstatus { get; set; }

        public static List<Recibo> lista = new List<Recibo>();


        public void getList()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=BDProyecto;Integrated Security=true;");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM recibo";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            lista.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Recibo detalles = new Recibo
                    {
                        numFolio = reader["num_folio"].ToString(),
                        fecha = reader["fecha"].ToString(),
                        importe = reader["importe"].ToString(),
                        importeLetra = reader["importe_letra"].ToString(),
                        periodo = reader["periodo"].ToString(),
                        reciboSocio = reader["socio_socio_rfc"].ToString(),
                        reciboEstatus = reader["estatus_estatus_codigo"].ToString()
                    };
                    lista.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }


        public void SeleccionarRecibo(string folio)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=BDProyecto;Integrated Security=true;");
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM recibo WHERE num_folio = '" + folio + "'";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                numFolio = reader["num_folio"].ToString();
                fecha = reader["fecha"].ToString();
                importe = reader["importe"].ToString();
                importeLetra = reader["importe_letra"].ToString();
                periodo = reader["periodo"].ToString();
                reciboSocio = reader["socio_socio_rfc"].ToString();
                reciboEstatus = reader["estatus_estatus_codigo"].ToString();

            }
            cmd.Dispose();
            reader.Close();
            conn.Close();
        }
    }
}
