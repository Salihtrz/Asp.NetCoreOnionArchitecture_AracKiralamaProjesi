﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.RentACarDtos
{
    public class FilterRentACarDto
    {
        public int carID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageURL { get; set; }
        public decimal Amount { get; set; }
    }
}
