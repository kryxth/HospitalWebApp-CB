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
    public class DoctoresController : Controller
    {
        // GET: Doctores
        public ActionResult Index()
        {
            IEnumerable<Doctor> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Doctores").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<Doctor>>().Result;
            return View(empList);
        }

        // GET: Doctores/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Doctores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doctores/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Doctor doctor)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Doctores/", doctor).Result;
                TempData["SuccessMessage"] = "Creado exitosamente";
            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index");
        }

        // GET: Doctores/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0)
                return View(new Doctor());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Doctores/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<Doctor>().Result);
            }
        }

        // POST: Doctores/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Doctor doctor)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Doctores/" + doctor.Id, doctor).Result;
                TempData["SuccessMessage"] = "Actualizado exitosamente";
            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index");
        }

        // GET: Doctores/Delete/5
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Doctores/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Borrado exitsoamente";
            return RedirectToAction("Index");
        }

        // POST: Doctores/Delete/5
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