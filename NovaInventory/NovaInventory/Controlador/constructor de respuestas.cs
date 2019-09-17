using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using NovaInventory.Config;

namespace NovaInventory.Controlador
{
    class constructor_de_respuestas
    {
        public int id_respuesta { get; set; }
        public int preguntas { get; set; }
        public string Respuesta { get; set; }
        public int usuarioss { get; set; }

        public string usuario { get; set; }

        
        MySqlCommand cmd = new MySqlCommand();

        public constructor_de_respuestas()
        {

        }

        public constructor_de_respuestas(string usuario)
        {

            //string sql = "SELECT * FROM tbrespuesta;";
            string sql = "SELECT * FROM tbrespuesta where preguntas =1;";
            cmd = new MySqlCommand(sql,Conexion.obtenerconexion() );
            Conexion.obtenerconexion().Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("Entro");
                Console.WriteLine(reader.GetInt32(0));
                Console.WriteLine(reader.GetString(1));
                Console.WriteLine(reader.GetString(2));
                //reader.NextResult();
            }
            Conexion.obtenerconexion().Close();
            Console.WriteLine("Fin de constructor");
        }
        public constructor_de_respuestas(string usuario, int pregunta)
        {
            this.preguntas = pregunta;
            this.usuario = usuario;
        }

        public void asignarRespuesta()
        {
            try
            {
                string sql = "select tr.id_respuesta , tr.preguntas , tr.Respuesta, tr.usuarioss " +
                             " from tbrespuesta tr inner join tbusuarios tu on tr.usuarioss = tu.id_usuarios " +
                             "where tu.nickname = '"+this.usuario + "' and tr.preguntas = "+this.preguntas+";";
                cmd = new MySqlCommand(sql, Conexion.obtenerconexion());
                Conexion.obtenerconexion().Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { 
                this.id_respuesta = reader.GetInt32(0);
                this.Respuesta = reader.GetString(2);
                this.usuarioss = reader.GetInt32(3);
                    Console.WriteLine("Retorna valor");
                }
                else {
                    Console.WriteLine("No retorna nada");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error asignandoRespuesta: " + e);
            }
        }
    }
}
