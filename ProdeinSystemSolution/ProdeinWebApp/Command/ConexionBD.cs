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
        public bool eliminarUsuario(String user)
        {
            Usuario userBD = new Usuario();
            MySqlConnection conexionBD = conectarBD(); //llamo a conectar la bd
            MySqlDataReader reader = null;
            bool respuesta = false;
            
            
            try
            {
                string query = "DELETE FROM `usuario` WHERE nombre = '" + user + "';";
                MySqlCommand comando = new MySqlCommand(query);
                comando.Connection = conexionBD; 
                conexionBD.Open(); 
                reader = comando.ExecuteReader(); 
                respuesta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexionBD.Close(); 
            }
            return respuesta;
        }
        public bool modificarUsuario(Usuario user)
        {
            Usuario userBD = new Usuario();
            MySqlConnection conexionBD = conectarBD(); 
            MySqlDataReader reader = null;
            bool respuesta = false;
            try
            {
                string query = "UPDATE `usuario` SET `nombre`='" + user._nombre + "', `password`='" + user._password + "', `rol`='" + user._rol + "',`permisos`= '" + user._permisos + "' WHERE nombre ='" + user._nombre + "' ";
                MySqlCommand comando = new MySqlCommand(query); 
                comando.Connection = conexionBD; 
                conexionBD.Open(); 
                reader = comando.ExecuteReader(); 
                respuesta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexionBD.Close();
            }
            return respuesta;
        }
        public Personas consultarPersona(int cedula)
        {
            Personas userBD = new Personas();
            MySqlConnection conexionBD = conectarBD();
            MySqlDataReader reader = null;

            try
            {
                string query = "SELECT * FROM `persona` WHERE `numeroCedula` = '" + cedula + "';";
                MySqlCommand comando = new MySqlCommand(query);
                comando.Connection = conexionBD;
                conexionBD.Open();
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    userBD._id = reader.GetInt32(0);
                    userBD._cedulaRif = reader.GetString(1);
                    userBD._numeroCedulaRif = reader.GetInt32(2);
                    userBD._nombre = reader.GetString(3);
                    userBD._sexo = reader.GetString(4);
                    userBD._estadoCivil = reader.GetString(5);
                    userBD._edad = reader.GetInt32(6);
                    userBD._profesion = reader.GetString(7);
                    userBD._correo = reader.GetString(8);
                    userBD._direccion = reader.GetString(9);
                    userBD._pais = reader.GetString(10);
                    userBD._estado = reader.GetString(11);
                    userBD._zonaPostal = reader.GetInt32(12);
                    userBD._telf1 = reader.GetInt32(13);
                    userBD._telf2 = reader.GetInt32(14);
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexionBD.Close();
            }
            return userBD;
        }
        public bool eliminarPersona(int cedula)
        {
            Personas personaBD = new Personas();
            MySqlConnection conexionBD = conectarBD();
            MySqlDataReader reader = null;
            bool respuesta = false;


            try
            {
                string query = "DELETE FROM `persona` WHERE `numeroCedula` = '" + cedula + "';";
                MySqlCommand comando = new MySqlCommand(query);
                comando.Connection = conexionBD;
                conexionBD.Open();
                reader = comando.ExecuteReader();
                respuesta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexionBD.Close();
            }
            return respuesta;
        }
        public bool modificarPersona(Personas persona)
        {
            Personas personaBD = persona;
            MySqlConnection conexionBD = conectarBD();
            MySqlDataReader reader = null;
            bool respuesta = false;
            try
            {
                string query = "UPDATE `persona` SET `tipoDocumento`='" + persona._cedulaRif + "',`numeroCedula`='" + persona._numeroCedulaRif + "',`nombreRazonsocial`='" + persona._nombre + "',`sexo`='" + persona._sexo + "',`estadoCivil`='" + persona._estadoCivil + "',`edad`='" + persona._edad + "',`profesion`='" + persona._profesion + "',`correo`='" + persona._correo + "',`direccion`='" + persona._direccion + "',`pais`='" + persona._pais + "',`estado`='" + persona._estado + "',`zonaPostal`='" + persona._zonaPostal + "',`telefono1`='" + persona._telf1 + "',`telefono2`='" + persona._telf2 + "' WHERE `numeroCedula` ='" + persona._numeroCedulaRif + "'";
                MySqlCommand comando = new MySqlCommand(query);
                comando.Connection = conexionBD;
                conexionBD.Open();
                reader = comando.ExecuteReader();
                respuesta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexionBD.Close();
            }
            return respuesta;
        }
        public Personas consultarPersonaCedula(string tipoDoc, int cedula)
        {
            Personas userBD = new Personas();
            MySqlConnection conexionBD = conectarBD(); //llamo a conectar la bd
            MySqlDataReader reader = null;

            try
            {
                string query = "SELECT * FROM Persona WHERE tipoDocumento  = '" + tipoDoc + "' and numeroCedula ='" + cedula + "';"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                MySqlCommand comando = new MySqlCommand(query); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    //Almacena cada registro

                    userBD._id = reader.GetInt32(0);
                    userBD._cedulaRif = reader.GetString(1);
                    userBD._numeroCedulaRif = reader.GetInt32(2);
                    userBD._nombre = reader.GetString(3);
                    userBD._sexo = reader.GetString(4);
                    userBD._estadoCivil = reader.GetString(5);
                    userBD._edad = reader.GetInt32(6);
                    userBD._profesion = reader.GetString(7);
                    userBD._correo = reader.GetString(8);
                    userBD._direccion = reader.GetString(9);
                    userBD._pais = reader.GetString(10);
                    userBD._estado = reader.GetString(11);
                    userBD._zonaPostal = reader.GetInt32(12);
                    userBD._telf1 = reader.GetInt32(13);
                    userBD._telf2 = reader.GetInt32(14);

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
        public List<Personas> consultarPersona()
        {
            List<Personas> users = new List<Personas>();
            Personas userBD = new Personas();
            MySqlConnection conexionBD = conectarBD(); //llamo a conectar la bd
            MySqlDataReader reader = null;

            try
            {
                string query = "SELECT * FROM Persona;"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                MySqlCommand comando = new MySqlCommand(query); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    //Almacena cada registro
                    userBD = new Personas();

                    userBD._id = reader.GetInt32(0);
                    userBD._cedulaRif = reader.GetString(1);
                    userBD._numeroCedulaRif = reader.GetInt32(2);
                    userBD._nombre = reader.GetString(3);
                    userBD._sexo = reader.GetString(4);
                    userBD._estadoCivil = reader.GetString(5);
                    userBD._edad = reader.GetInt32(6);
                    userBD._profesion = reader.GetString(7);
                    userBD._correo = reader.GetString(8);
                    userBD._direccion = reader.GetString(9);
                    userBD._pais = reader.GetString(10);
                    userBD._estado = reader.GetString(11);
                    userBD._zonaPostal = reader.GetInt32(12);
                    userBD._telf1 = reader.GetInt32(13);
                    userBD._telf2 = reader.GetInt32(14);

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
        /// <param name="person"></param>
        /// <returns></returns>
        public bool registrarPersona(Personas person)
        {
            Personas userBD = new Personas();
            MySqlConnection conexionBD = conectarBD(); //llamo a conectar la bd
            MySqlDataReader reader = null;
            bool respuesta = false;

            try
            {
                string query = "INSERT INTO persona(tipoDocumento, numeroCedula, nombreRazonsocial, sexo, estadoCivil, edad, profesion, correo, " +
                    "direccion, pais, estado, zonaPostal, telefono1, telefono2) VALUES ( '" + person._cedulaRif + "', '" + person._numeroCedulaRif + "', '" + person._nombre + "', " +
                    "'" + person._sexo + "', '" + person._estadoCivil + "','" + person._edad + "', '" + person._profesion + "', '" + person._correo + "','" + person._direccion + "'," +
                    "'" + person._pais + "', '" + person._estado + "','" + person._zonaPostal + "', '" + person._telf1 + "','" + person._telf2 + "');";
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