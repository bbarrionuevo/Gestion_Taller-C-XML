﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsVehiculo
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public int Kilometraje { get; set; }
        public string Categoria { get; set; }

        public BEClsVehiculo(string patente) 
        { Patente = patente; }
        public BEClsVehiculo() { }
    }
}
