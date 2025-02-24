﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.CarDtos
{
    public class UpdateCarDto
    {
        public int CarID { get; set; }
        public int brandID { get; set; }
        public string model { get; set; }
        public string coverImageURL { get; set; }
        public int km { get; set; }
        public string transmission { get; set; }
        public int seat { get; set; }
        public int luggage { get; set; }
        public string fuel { get; set; }
        public string bigImageURL { get; set; }
    }
}
