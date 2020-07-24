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



    }
}