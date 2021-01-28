using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Concreate;

namespace GameProject.Entities
{
     public class Players:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirtDateYear { get; set; }
        public long NationalId { get; set; }
    }
}
