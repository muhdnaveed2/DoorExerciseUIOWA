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
        const int _DOOR = 100;
        const int _PASS = 3;

        // GET: Door
        public ActionResult Index()
        {
            List<DoorModel> doorList = new List<DoorModel>(_DOOR);

            //creating 100 doors
            for (int count = 1; count <= _DOOR; count++)
            {
                DoorModel door = new DoorModel(count);
                doorList.Add(door);
            }

            // Passing through doors 100 times
            for (int pass = 1; pass <= _PASS; pass++)
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