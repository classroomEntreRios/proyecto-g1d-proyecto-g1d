﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viajes.Models.WS
{
    public class Respuesta
    {
        public int Resultado { get; set; }
        public object Datos { get; set; }
        public string Mensaje { get; set; }
    }
}