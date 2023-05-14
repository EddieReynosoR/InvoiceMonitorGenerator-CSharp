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

        public string admins { get; set; }

        public static List<Recibo> lista = new List<Recibo>();


        public void getListConFirmas()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=BDProyecto;Integrated Security=true; MultipleActiveResultSets=True;");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT recibo_num_folio, socio.socio_rfc, recibo.fecha, recibo.importe, recibo.importe_letra, recibo.periodo,(STRING_AGG(administrador.admin_pnombre + ' - ' + CAST(puesto_nombre AS VARCHAR) + ' - ' + CAST(firma_fecha AS VARCHAR), ' ,')) AS 'firmas_admin', estatus.estatus_nombre FROM firma INNER JOIN administrador on firma.administrador_admin_id = administrador.admin_id LEFT JOIN puesto on administrador.puesto_id_puesto = puesto.id_puesto LEFT JOIN recibo on firma.recibo_num_folio = recibo.num_folio LEFT JOIN socio on recibo.socio_socio_rfc = socio.socio_rfc LEFT JOIN estatus on recibo.estatus_estatus_codigo = estatus.estatus_codigo WHERE(recibo_num_folio IN(SELECT recibo_num_folio FROM firma GROUP BY recibo_num_folio HAVING(COUNT(recibo_num_folio) > 1))) GROUP BY recibo_num_folio, socio.socio_rfc, socio.socio_nombre, socio.socio_inicial, socio.socio_apellidop, socio.socio_apellidom,  estatus.estatus_nombre, recibo.fecha, recibo.importe, recibo.importe_letra, recibo.periodo";
            cmd.CommandText = sql;

            
            SqlDataReader reader = cmd.ExecuteReader();

            lista.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Recibo detalles = new Recibo
                    {
                        numFolio = reader["recibo_num_folio"].ToString(),
                        fecha = reader["fecha"].ToString(),
                        importe = reader["importe"].ToString(),
                        importeLetra = reader["importe_letra"].ToString(),
                        periodo = reader["periodo"].ToString(),
                        reciboSocio = reader["socio_rfc"].ToString(),
                        reciboEstatus = reader["estatus_nombre"].ToString(),
                        admins = reader["firmas_admin"].ToString()
                    };
                    lista.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }

        public void getListSinFirmas()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=BDProyecto;Integrated Security=true;");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT fd.administrador_admin_id, administrador.admin_pnombre, administrador.puesto_id_puesto, puesto.puesto_nombre, recibo.num_folio, recibo.fecha, recibo.importe, recibo.importe_letra, recibo.periodo ,socio.socio_rfc, socio_nombre, estatus_nombre FROM firma fd INNER JOIN administrador on fd.administrador_admin_id = administrador.admin_id LEFT JOIN recibo on fd.recibo_num_folio = recibo.num_folio LEFT JOIN socio on recibo.socio_socio_rfc = socio.socio_rfc LEFT JOIN puesto on administrador.puesto_id_puesto = puesto.id_puesto LEFT JOIN estatus on recibo.estatus_estatus_codigo = estatus.estatus_codigo WHERE(fd.recibo_num_folio IN(SELECT recibo_num_folio FROM firma GROUP BY recibo_num_folio HAVING(COUNT(recibo_num_folio) < 2))); ";
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
                        reciboSocio = reader["socio_rfc"].ToString(),
                        reciboEstatus = reader["estatus_nombre"].ToString(),
                        admins = reader["admin_pnombre"].ToString()
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
