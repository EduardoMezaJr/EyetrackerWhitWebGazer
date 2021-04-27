using Antlr.Runtime;
using Experimentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Experimentos.Controllers
{
    public class HomeController : Controller
    {
        Experiments_App_Entities _db = new Experiments_App_Entities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Encuestas()
        {
            ViewBag.Message = "Encuestas para alumnos y docentes";

            return View();
        }

        public ActionResult Experimentos()
        {
            ViewBag.Message = "Experimentos";

            return View();
        }

        public ActionResult Declaracion()
        {
            ViewBag.Message = "Declaración de privacidad";

            return View();
        }

        public ActionResult Profesor()
        {
            ViewBag.Message = "Encuesta para profesores";

            return View();
        }

        public ActionResult Alumno()
        {
            ViewBag.Message = "Encuesta para alumnos";

            return View();
        }

        public ActionResult Agradecimientos()
        {
            ViewBag.Message = "Pagina de agradecimientos";

            return View();
        }

        public ActionResult Instrucciones()
        {
            ViewBag.Message = "Pagina de Instrucciones";

            return View();
        }

        public ActionResult ExpBasico1()
        {
            ViewBag.Message = "Resultados experimento básico 1";

            return View();
        }
        public ActionResult ExpBasico2()
        {
            ViewBag.Message = "Resultados experimento básico 2";

            return View();
        }
        public ActionResult ExpBasico3()
        {
            ViewBag.Message = "Resultados experimento básico 3";

            return View();
        }
        public ActionResult ExpBasico4()
        {
            ViewBag.Message = "Resultados experimento intermedio 1";

            return View();
        }
        public ActionResult ExpBasico5()
        {
            ViewBag.Message = "Resultados experimento intermedio 2";

            return View();
        }
        public ActionResult ExpBasico6()
        {
            ViewBag.Message = "Resultados experimento intermedio 3";

            return View();
        }
        public ActionResult ExpBasico7()
        {
            ViewBag.Message = "Resultados experimento avanzado 1";

            return View();
        }
        public ActionResult ExpBasico8()
        {
            ViewBag.Message = "Resultados experimento avanzado 2";

            return View();
        }
        public ActionResult ExpBasico9()
        {
            ViewBag.Message = "Resultados experimento avanzado 3";

            return View();
        }

        public ActionResult ExpBas1(FormCollection formCollection)
        {
            _db.respuestasExperimentos.Add(new respuestasExperimento { id_Participante = GlobalVariables.id_participante, nivelBasicoExp1 = formCollection["nivelBasicoExp1"]});
            _db.SaveChanges();
            return View("Experimento2");
        }

        public ActionResult Experimento2()
        {
            return View();
        }

        public ActionResult ExpBas2(FormCollection formCollection)
        {
            respuestasExperimento RE = _db.respuestasExperimentos.Where(x => x.id_Participante == GlobalVariables.id_participante).FirstOrDefault();
            RE.nivelBasicoExp2 = formCollection["nivelBasicoExp2"];
            _db.SaveChanges();
            return View("Experimento3");
        }

        public ActionResult Experimento3()
        {
            return View();
        }

        public ActionResult ExpBas3(FormCollection formCollection)
        {
            respuestasExperimento RE = _db.respuestasExperimentos.Where(x => x.id_Participante == GlobalVariables.id_participante).FirstOrDefault();
            RE.nivelBasicoExp3 = formCollection["nivelBasicoExp3"];
            _db.SaveChanges();
            return View("Experimento4");
        }

        public ActionResult Experimento4()
        {
            return View();
        }

        public ActionResult ExpBas4(FormCollection formCollection)
        {
            respuestasExperimento RE = _db.respuestasExperimentos.Where(x => x.id_Participante == GlobalVariables.id_participante).FirstOrDefault();
            RE.nivelIntermedioExp1 = formCollection["nivelIntermedioExp1"];
            _db.SaveChanges();
            return View("Experimento5");
        }

        public ActionResult Experimento5()
        {
            return View();
        }

        public ActionResult ExpBas5(FormCollection formCollection)
        {
            respuestasExperimento RE = _db.respuestasExperimentos.Where(x => x.id_Participante == GlobalVariables.id_participante).FirstOrDefault();
            RE.nivelIntermedioExp2 = formCollection["nivelIntermedioExp2"];
            _db.SaveChanges();
            return View("Experimento6");
        }

        public ActionResult Experimento6()
        {
            return View();
        }

        public ActionResult ExpBas6(FormCollection formCollection)
        {
            respuestasExperimento RE = _db.respuestasExperimentos.Where(x => x.id_Participante == GlobalVariables.id_participante).FirstOrDefault();
            RE.nivelIntermedioExp3 = formCollection["nivelIntermedioExp3"];
            _db.SaveChanges();
            return View("Experimento7");
        }

        public ActionResult Experimento7()
        {
            return View();
        }

        public ActionResult ExpBas7(FormCollection formCollection)
        {
            respuestasExperimento RE = _db.respuestasExperimentos.Where(x => x.id_Participante == GlobalVariables.id_participante).FirstOrDefault();
            RE.nivelAvanzadoExp1 = formCollection["nivelAvanzadoExp1"];
            _db.SaveChanges();
            return View("Experimento8");
        }

        public ActionResult Experimento8()
        {
            return View();
        }

        public ActionResult ExpBas8(FormCollection formCollection)
        {
            respuestasExperimento RE = _db.respuestasExperimentos.Where(x => x.id_Participante == GlobalVariables.id_participante).FirstOrDefault();
            RE.nivelAvanzadoExp2 = formCollection["nivelAvanzadoExp2"];
            _db.SaveChanges();
            return View("Experimento9");
        }

        public ActionResult Experimento9()
        {
            return View();
        }

        public ActionResult ExpBas9(FormCollection formCollection)
        {
            respuestasExperimento RE = _db.respuestasExperimentos.Where(x => x.id_Participante == GlobalVariables.id_participante).FirstOrDefault();
            RE.nivelAvanzadoExp3 = formCollection["nivelAvanzadoExp3"];
            _db.SaveChanges();
            return View("Agradecimientos");
        }
        [HttpPost]
        public ActionResult ProcesarDatos(IEnumerable<eyeData> data)
        {
            foreach (eyeData obj in data) 
            {
                _db.eyeDatas.Add(new eyeData{ id_participante = GlobalVariables.id_participante, clock = obj.clock, x = obj.x, y = obj.y, experimento = obj.experimento });
                _db.SaveChanges();
            }

            return View();
        }

        public ActionResult CuestionarioProfesor(FormCollection formCollection)
        {
            participante part = _db.participantes.Add(new participante { edad = Convert.ToInt32(formCollection["edad"]), sexo = formCollection["sexo"], cuestionario = 1});
            _db.SaveChanges();
            _db.cuestionarios.Add(new cuestionario { id_participante = part.id_participante, 
             //   id_preguntas = 1,
                p1 = formCollection["p1"],
                p2 = formCollection["p2"],
                p3 = formCollection["p3"],
                p4 = formCollection["p4"],
                p5 = formCollection["p5"],
                p6 = formCollection["p6"],
                p7 = formCollection["p7"],
                p8 = formCollection["p8"]
            });
            _db.SaveChanges();
            return View("Agradecimientos");
        }

        public ActionResult CuestionarioAlumno(FormCollection formCollection)
        {
            participante part = _db.participantes.Add(new participante { edad = Convert.ToInt32(formCollection["edad"]),
                sexo = formCollection["sexo"],
                semestre = formCollection["semestre"],
                nivel = formCollection["nivel"],
                cuestionario = 1,
                lentes = formCollection["lentes"]
            });
            _db.SaveChanges();

            GlobalVariables.id_participante = part.id_participante;

            _db.cuestionarios.Add(new cuestionario
            {
                id_participante = part.id_participante,
                id_preguntas = 1, // cambiar a 1 
                p1 = formCollection["p1"],
                p2 = formCollection["p2"],
                p3 = formCollection["p3"],
                p4 = formCollection["p4"],
                p5 = formCollection["p5"],
                p6 = formCollection["p6"],
                p7 = formCollection["p7"],
            });
            _db.SaveChanges();

            return View("Instrucciones");
        }
    }
}