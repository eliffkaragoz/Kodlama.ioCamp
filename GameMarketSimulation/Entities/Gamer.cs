﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Entities
{
    public class Gamer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NatioanalityId { get; set; }
    }
}
