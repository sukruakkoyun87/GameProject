using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using GameProject.Concreate;

namespace GameProject.Entities
{
    public class Campaign:IEntity
    {
        public string CampignName { get; set; }
        public double DiscountRate { get; set; }
    }
}
