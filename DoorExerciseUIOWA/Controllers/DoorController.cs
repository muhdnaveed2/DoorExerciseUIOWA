using DoorExerciseUIOWA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoorExerciseUIOWA.Controllers
{
    public class DoorController : Controller
    {
        // GET: Door
        public ActionResult Index()
        {
            List<DoorModel> doorList = new List<DoorModel>(100);

            //creating 100 doors
            for (int count = 1; count <= 100; count++)
            {
                DoorModel door = new DoorModel(count);
                doorList.Add(door);
            }

            // Passing through doors 100 times
            for (int pass = 1; pass <= 100; pass++)
            {
                for (int i = pass; i < doorList.Capacity; i += pass)
                { 
                   doorList[i-1].State = doorList[i-1].State == State.Open ? State.Close : State.Open;
                }
            }
            return View("Door", doorList);
        }

    }
}