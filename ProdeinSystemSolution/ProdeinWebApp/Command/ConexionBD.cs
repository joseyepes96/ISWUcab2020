using MySql.Data.MySqlClient;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Command
{
    public class ConexionBD
    {
        // parametros de conexion de la base de datos
        private string servidor = "localhost"; //nombre o ip del servidor
        private string nombreBd = "proyectoIng"; // nombre de la bd
        private string usuario = "proyecto";
        private string password = "proyecto123";
        private string puerto = "3306";
        private string cadenaConexion;

        /// <summary>
        /// Realiza la conexion con la base de datos
        /// </summary>
        /// <returns>El objeto conexion </returns>
        private MySqlConnection conectarBD()
        {
            cadenaConexion = "database=" + nombreBd + ";datasource=" + servidor + ";username=" + usuario + ";password=" + password + ";port=" + puerto + ";";
            
            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            return conexionBD;
        }

        public Usuario consultarUsuarioNombre(string nombre)
        {
            Usuario userBD = new Usuario();
            MySqlConnection conexionBD = conectarBD(); //llamo a conectar la bd
            MySqlDataReader reader = null;
            
            try
            {
                string query = "SELECT * FROM Usuario WHERE nombre = '" + nombre + "';"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                MySqlCommand comando = new MySqlCommand(query); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    //Almacena cada registro
                    userBD._id = reader.GetInt32(0);
                    userBD._nombre = reader.GetString(1);
                    userBD._password = reader.GetString(2);
                    userBD._rol = reader.GetString(3);
                    userBD._permisos = reader.GetString(4);
                }
            }
            catch (MySqlException ex)
            {
                throw ex; //Si existe un error aquí muestra el mensaje
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
            return userBD;
        }

        /// <summary>
        /// Consulta todos los usuarios registrados en el sistema
        /// </summary>
        /// <returns>Devuelve una lista de tipo Usuario</returns>
        public List<Usuario> consultarUsuarios()
        {
            List <Usuario> users = new List <Usuario>();
            Usuario userBD = new Usuario();
            MySqlConnection conexionBD = conectarBD(); //llamo a conectar la bd
            MySqlDataReader reader = null;

            try
            {
                string query = "SELECT * FROM Usuario;"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                MySqlCommand comando = new MySqlCommand(query); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    //Almacena cada registro
                    userBD = new Usuario();

                    userBD._id = reader.GetInt32(0);
                    userBD._nombre = reader.GetString(1);
                    userBD._password = reader.GetString(2);
                    userBD._rol = reader.GetString(3);
                    userBD._permisos = reader.GetString(4);
                   
                    users.Add(userBD);
                }
            }
            catch (MySqlException ex)
            {
                throw ex; //Si existe un error aquí muestra el mensaje
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
            return users;
        }

        /// <summary>
        /// Registro de usuarios que lo hace un admin
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool registrarUsuario(Usuario user)
        {
            Usuario userBD = new Usuario();
            MySqlConnection conexionBD = conectarBD(); //llamo a conectar la bd
            MySqlDataReader reader = null;
            bool respuesta = false;

            try
            {               
                string query = "INSERT INTO usuario(nombre, password, rol, permisos) VALUES ( '" + user._nombre+ "', '" + user._password + "', '" + user._rol + "', '" + user._permisos + "');"; 
                MySqlCommand comando = new MySqlCommand(query); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader
                respuesta = true;
            }
            catch (MySqlException ex)
            {
                throw ex; //Si existe un error aquí muestra el mensaje
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }       
            return respuesta;
        }        
    }
}