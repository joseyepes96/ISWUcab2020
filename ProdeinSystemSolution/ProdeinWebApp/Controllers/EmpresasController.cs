using ProdeinWebApp.Command;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Controllers
{
    public class EmpresasController
    {
        public Empresas verificarEmpresa(int rif) //consulta por rif
        {
            var empresa = new Empresas();
            empresa._numeroRif = rif;
            EmpresasCommand ec = new EmpresasCommand();
            Empresas empresa1 = ec.consultarEmpre(empresa);
            return empresa1;
        }
        public bool eliminarEmpresa(Empresas empresa)
        {
            var respuesta = false;
            EmpresasCommand ec = new EmpresasCommand();
            respuesta = ec.eliminarEmpresa(empresa);
            return respuesta;
        }
        public bool modificarEmpresa(Empresas empresa)
        {
            bool respuesta = false;
            EmpresasCommand ec = new EmpresasCommand();
            respuesta = ec.modificarEmpresa(empresa);
            return respuesta;
        }

        public Empresas verificarEmpresa(string tipoDoc, string rif)
        {
            var userEmpresa = new Empresas();
            userEmpresa._numeroRif = int.Parse(rif);
            userEmpresa._rif = tipoDoc;
            EmpresasCommand ec = new EmpresasCommand();
            Empresas empresa = ec.consultarEmpresa(userEmpresa);

            return empresa;
        }

        public bool agregarEmpresa(Empresas empresa)
        {
            var respuesta = false;
            EmpresasCommand ec = new EmpresasCommand();
            respuesta = ec.agregarEmpresa(empresa);

            return respuesta;
        }

        public List<Empresas> consultarEmpresa()
        {
            List<Empresas> listaEmpresas = new List<Empresas>();
            EmpresasCommand ec = new EmpresasCommand();
            listaEmpresas = ec.consultarEmpresa();

            return listaEmpresas;
        }

        public Boolean validarTexto(string texto)
        {
            char letra = ' ';
            int flag = 0;

            if (!string.IsNullOrEmpty(texto))                   //si el campo no está vacío
            {
                for (int i = 0; i < texto.Length; i++)
                {
                    letra = texto[i];
                    if (!(letra >= 'A' && letra <= 'Z') && !(letra >= 'a' && letra <= 'z') && !(letra >= ',' && letra <= '/') && !(letra >= ' '))   //si tiene un caracter especial o numero.
                        flag = 1;
                }
            }
            if (flag == 1)
                return false;

            return true;
        }

        public Boolean validarCampoCorreo(string correo)
        {
            if (!string.IsNullOrEmpty(correo) && (correo.Contains("@gmail.com") || correo.Contains("@hotmail.com")))
                return true;
            else
                return false;
        }

        public Boolean validarCampoNumerico(string numero)
        {
            char letra = ' ';
            int flag = 0;

            if (!string.IsNullOrEmpty(numero))                   //si el campo no está vacío
            {
                for (int i = 0; i < numero.Length; i++)
                {
                    letra = numero[i];
                    if (!(letra >= '0' && letra <= '9'))    //si tiene un caracter que no es numero
                        flag = 1;
                }
            }
            if (flag == 1)
                return false;

            return true;
        }
        
    }
}