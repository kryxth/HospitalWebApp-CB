using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HospitalWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApp.Controllers
{
    public class PacientesController : Controller
    {
        // GET: Pacientes
        public ActionResult Index()
        {
            IEnumerable<Paciente> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Pacientes").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<Paciente>>().Result;
            return View(empList);
        }

        // GET: Pacientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pacientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pacientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Paciente Paciente)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Pacientes/", Paciente).Result;
                TempData["SuccessMessage"] = "Creado exitosamente";
            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index");
        }

        // GET: Pacientes/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0)
                return View(new Paciente());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Pacientes/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<Paciente>().Result);
            }
        }

        // POST: Pacientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Paciente Paciente)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Pacientes/" + Paciente.Id, Paciente).Result;
                TempData["SuccessMessage"] = "Actualizado exitosamente";
            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index");
        }

        // GET: Pacientes/Delete/5
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Pacientes/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Borrado exitsoamente";
            return RedirectToAction("Index");
        }

        // POST: Pacientes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}