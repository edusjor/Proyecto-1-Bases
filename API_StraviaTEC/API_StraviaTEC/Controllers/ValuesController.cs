using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Npgsql;
using System.Diagnostics;

namespace API_StraviaTEC.Controllers
{
    public class ValuesController : ApiController
    {
        NpgsqlConnection conexion = new NpgsqlConnection();
        string cadenaConexion = "Server = 127.0.0.1; Port = 5432; Database = TallerA; User Id = postgres; Password = 123456";
        
        // GET api/values
        public List<string> Get()
        {
            conexion.ConnectionString = cadenaConexion;
            bool flag = false;
            var sql = "SELECT * FROM project";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conexion);
            string aux;
            List<string> prueba = new List<string>();
            try
            {
                conexion.Open();
            }
            catch
            {
                Debug.WriteLine("Usuario o contraseña incorrectos");
                conexion.Close();
            }
            if (conexion.State.ToString() == "Open")
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.Write("{0}\t{1} \n", dr[0], dr[1]);
                    prueba.Add(dr[0].ToString());
                    flag = true;
                }
                Debug.WriteLine("Conexion realizada con exito");
                conexion.Close();
                //flag = true;
            }    
            return prueba;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
