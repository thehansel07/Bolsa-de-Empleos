using Microsoft.OData.Edm;
using Prueba_Bolsa_Empleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba_Bolsa_Empleados.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        static Conexion conexion = new Conexion();



        public ActionResult principal()
        {
        


            return View();

        }




        public ActionResult Index()
        {
            List<Publicacion> lista = new List<Publicacion>();

            lista = conexion.TodolasPublicacion().ToList();

            
            return View(lista);

        }
        public ActionResult Index1()
        {
            List<Publicacion> lista = new List<Publicacion>();

            lista = conexion.lasPublicacion().ToList();


            return View(lista);

        }
        public ActionResult Index2()
        {
            List<Publicacion> lista = new List<Publicacion>();

            lista = conexion.TodolasPublicacion_Adminitrativa().ToList();


            return View(lista);

        }





        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();


            }
            Publicacion publicacion = conexion.FiltrarDatosProgramador(id);
            if (publicacion == null)
            {
                return HttpNotFound();


            }
            return View(publicacion);

        }

        public ActionResult Details1(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();


            }
            Publicacion publicacion = conexion.FiltrarDatosDiseñador(id);
            if (publicacion == null)
            {
                return HttpNotFound();


            }
            return View(publicacion);

        }

        public ActionResult Details2(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();


            }
            Publicacion publicacion = conexion.FiltrarDatosAdministrativa(id);
            if (publicacion == null)
            {
                return HttpNotFound();


            }
            return View(publicacion);

        }

        public ActionResult Index3()
        {
            List<Publicacion> lista = new List<Publicacion>();

            lista = conexion.TodolasPublicacion_Matenimiento().ToList();


            return View(lista);

        }

        public ActionResult Details3(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();


            }
            Publicacion publicacion = conexion.FiltrarDatosMantenimiento(id);
            if (publicacion == null)
            {
                return HttpNotFound();


            }
            return View(publicacion);

        }



        public ActionResult obtener_diseñado_fecha(Date? Fecha_Publicacion)
        {
            if (Fecha_Publicacion == null)
            {
                return HttpNotFound();


            }
            Publicacion publicacion = conexion.ObtenerFechaDiseñador(Fecha_Publicacion);
            if (publicacion == null)
            {
                return HttpNotFound();


            }
            return View(publicacion);

        }


















        public ActionResult Hola()
        {
           
            return View();

        }



        public ActionResult VerPostulados()
        {
            List<Usuario> lista = new List<Usuario>();

            lista = conexion.Ver_Usuario().ToList();


            return View(lista);

        }
        [HttpGet]
        public ActionResult AgregarPostulados()
        {


            return View();



        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AgregarPostulados([Bind] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                conexion.AgregarPostulado(usuario);
                return RedirectToAction("Principal");

            }
            return View(usuario);





        }












    }




}