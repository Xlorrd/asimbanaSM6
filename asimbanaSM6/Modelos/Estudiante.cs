﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asimbanaSM6.Modelos
{
    public class Estudiante
    {
        public int codigo { set; get; }
        public required string nombre { set; get; }
        public required string apellido { set; get; }
        public int edad { set; get; }
    }
}
