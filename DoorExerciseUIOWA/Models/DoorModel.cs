using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoorExerciseUIOWA.Models
{
    public enum State
    {
        Open,
        Close
    }
    public class DoorModel
    {
        public DoorModel(int ID)
        {
            this.ID = ID;
            State = State.Close;
        }
      public int ID { get; set; }
      public State State { get; set; }
    }
}