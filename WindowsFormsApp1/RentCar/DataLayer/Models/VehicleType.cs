﻿using System.ComponentModel.DataAnnotations;

namespace RentCar.DataLayer.Models
{
    public sealed class VehicleType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
