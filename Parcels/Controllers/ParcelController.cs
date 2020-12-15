using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
    public class ParcelsController : Controller
    {
        [HttpGet("/parcels")]
        public ActionResult Index()
        {
            List<Parcel> allParcels = Parcel.GetAll();
            return View(allParcels);
        }

        [HttpGet("/parcels/new")]
        public ActionResult CreateForm()
        {
            return View();
        }


        [HttpPost("/parcels")]
        public ActionResult Create(int length, int width, int height, int weight, int volume, int cost)
        {
            Parcel myParcel = new Parcel(length, width, weight, height);
            myParcel.CalculateVolume();
            myParcel.CostToShip();
            return RedirectToAction("Index");
        }
    }
}