using Microsoft.OData.Edm;
using Prueba_Bolsa_Empleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba_Bolsa_Empleados.Controllers
{
    public class AutenticacionController : Controller
    {

        static Conexion conexion = new Conexion();
        // GET: Autenticacion
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View();
        }


        public ActionResult LoginAdmin()
        {
            return View();
        }



        public ActionResult LoginEmpleado()
        {
            return View();

        }


        [HttpPost]
        public ActionResult Autorizacion(Prueba_Bolsa_Empleados.Models.Administrador administrador)
        {
            using (DBBolsaEmpleoEntities db = new DBBolsaEmpleoEntities())
            {
                var detalle = db.Administrador.Where(x => x.Usuario == administrador.Usuario && x.Contraseña == administrador.Contraseña).FirstOrDefault();

                if (detalle == null)
                {
                    administrador.ErrorLogin = "El usuario o Contraseña es invalido !";
                    return View("LoginAdmin", administrador);


                }

                else
                {



                    Session["IDAdmin"] = administrador.IDAdmin;
                    Session["Usuario"] = administrador.Usuario;
                    Session["Nombre"] = administrador.Nombre;
                    Session["Contraseña"] = administrador.Contraseña;



                    return RedirectToAction("Index1", "Autenticacion");

                }



            }



        }
        [HttpPost]
        public ActionResult Autorizacion1(Prueba_Bolsa_Empleados.Models.Empleado  empleado)
        {
            using (DBBolsaEmpleoEntities db = new DBBolsaEmpleoEntities())
            {
                var detallito = db.Empleado.Where(x => x.Usuario == empleado.Usuario && x.Contraseña == empleado.Contraseña).FirstOrDefault();

                if (detallito == null)
                {
                    empleado.ErrorLogin = "El usuario o Contraseña es invalido !";
                    return View("LoginEmpleado", empleado);


                }

                else
                {



                    Session["IDEmpleado"] = empleado.IDEmpleado;
                    Session["Usuario"] = empleado.Usuario;
                    Session["Nombre"] = empleado.Nombre;
                    Session["Contraseña"] = empleado.Contraseña;



                    return RedirectToAction("Index","Autenticacion");

                }



            }



        }








        public ActionResult LogOut1()
        {

            int iDempleado = (int)Session["IDEmpleado"];


            Session.Abandon();

            return RedirectToAction("Principal", "Prueba");


        }







        [HttpGet]
        public ActionResult AgregarPublicacion_Diseñador()
        {


            return View();



        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AgregarPublicacion_Diseñador([Bind] Publicacion publicacion)
        {
            if (ModelState.IsValid)
            {
                conexion.AgregarPublicacionesDiseñado(publicacion);
                return RedirectToAction("Index");

            }
            return View(publicacion);





        }

        [HttpGet]
        public ActionResult AgregarPublicacion_Programador()
        {


            return View();



        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AgregarPublicacion_Programador([Bind] Publicacion publicacion)
        {
            if (ModelState.IsValid)
            {
                conexion.AgregarPublicacionesProgramador(publicacion);
                return RedirectToAction("Index");

            }
            return View(publicacion);





        }

        [HttpGet]
        public ActionResult AgregarPublicacion_Administrativa()
        {


            return View();



        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AgregarPublicacion_Administrativa([Bind] Publicacion publicacion)
        {
            if (ModelState.IsValid)
            {
                conexion.AgregarPublicacionesAdministrativa(publicacion);
                return RedirectToAction("Index");

            }
            return View(publicacion);   





        }

        public ActionResult AgregarPublicacion_Mantenimiento()
        {


            return View();



        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AgregarPublicacion_Mantenimiento([Bind] Publicacion publicacion)
        {
            if (ModelState.IsValid)
            {
                conexion.AgregarPublicacionesMantenimiento(publicacion);
                return RedirectToAction("Index");

            }
            return View(publicacion);





        }



        public ActionResult PublicacionesEmpleados()
        {
            List<Publicacion> lista = new List<Publicacion>();

            lista = conexion.lasPublicacion().ToList();


            return View(lista);

        }

        public ActionResult ActualizarDiseñador(int? id)
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
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult ActualizarDiseñador(int? id, [Bind] Publicacion publicacion)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            if (ModelState.IsValid)
            {
                conexion.ActualizarDiseñador(publicacion);
                return RedirectToAction("VerDiseñado");
            }

            return View(conexion);


        }

        public ActionResult VerDiseñado()
        {
            List<Publicacion> lista = new List<Publicacion>();

            lista = conexion.lasPublicacion().ToList();


            return View(lista);

        }

        public ActionResult VerProgramador()
        {
            List<Publicacion> lista = new List<Publicacion>();

            lista = conexion.TodolasPublicacion().ToList();


            return View(lista);

        }


        public ActionResult VerAdministrativa()
        {
            List<Publicacion> lista = new List<Publicacion>();

            lista = conexion.TodolasPublicacion_Adminitrativa().ToList();


            return View(lista);

        }

        public ActionResult VerMantenimiento()
        {
            List<Publicacion> lista = new List<Publicacion>();

            lista = conexion.TodolasPublicacion_Matenimiento().ToList();


            return View(lista);

        }


        public ActionResult VerEmpleado()
        {
            List<Empleado> lista = new List<Empleado>();

            lista = conexion.TodosLosEmpleados().ToList();


            return View(lista);

        }



        public ActionResult EliminarDiseñado(int? id)
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

        [HttpPost, ActionName("EliminarDiseñado")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarDiseñado(int id)
        {
            conexion.EliminarDiseñado(id);
            return RedirectToAction("VerProgramador");

        }








        public ActionResult EliminarProgramador(int? id)
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

        [HttpPost, ActionName("EliminarProgramador")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarProgramador(int id)
        {
            conexion.EliminarProgramador(id);
            return RedirectToAction("VerProgramador");

        }





        public ActionResult ActualizarProgramador(int? id)
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
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult ActualizarProgramador(int? id, [Bind] Publicacion publicacion)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            if (ModelState.IsValid)
            {
                conexion.ActualizarProgramador(publicacion);
                return RedirectToAction("VerProgramador");
            }

            return View(conexion);


        }



        public ActionResult ActualizarAdministrativa(int? id)
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
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult ActualizarAdministrativa(int? id, [Bind] Publicacion publicacion)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            if (ModelState.IsValid)
            {
                conexion.ActualizarAdministrativa(publicacion);
                return RedirectToAction("VerAdministrativa");
            }

            return View(conexion);


        }
        public ActionResult EliminarAdministrativa(int? id)
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

        [HttpPost, ActionName("EliminarAdministrativa")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarAdministrativa(int id)
        {
            conexion.EliminarAdministrativa(id);
            return RedirectToAction("VerAdministrativa");

        }




        public ActionResult ActualizarMantenimiento(int? id)
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
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult ActualizarMantenimiento(int? id, [Bind] Publicacion publicacion)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            if (ModelState.IsValid)
            {
                conexion.ActualizarMantenimiento(publicacion);
                return RedirectToAction("VerMantenimiento");
            }

            return View(conexion);


        }


        public ActionResult EliminarMantenimiento(int? id)
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

        [HttpPost, ActionName("EliminarMantenimiento")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarMantenimiento(int id)
        {
            conexion.EliminarMantenimiento(id);
            return RedirectToAction("VerMantenimiento");

        }









        [HttpGet]
        public ActionResult AgregarEmpleado()
        {


            return View();



        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AgregarEmpleado([Bind] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                conexion.Agregar_Empleado(empleado);
                return RedirectToAction("Index1");

            }
            return View(empleado);





        }








        public ActionResult EliminarEmpleado(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();


            }
            Empleado empleado = conexion.Obtener_datos_empleado(id);
            if (empleado == null)
            {
                return HttpNotFound();


            }

            return View(empleado);



        }

        [HttpPost, ActionName("EliminarEmpleado")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarEmpleado(int id)
        {
            conexion.EliminarEmpleado(id);
            return RedirectToAction("VerEmpleado");

        }

        public ActionResult ActualizarEmpleado(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Empleado empleado = conexion.Obtener_datos_empleado(id);
            if (empleado == null)
            {
                return HttpNotFound();

            }

            return View(empleado);


        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult ActualizarEmpleado(int? id, [Bind] Empleado empleado)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            if (ModelState.IsValid)
            {
                conexion.Modificar_Empleado(empleado);
                return RedirectToAction("VerEmpleado");
            }

            return View(conexion);


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













    }





















}