﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inte_conti
{
    public class ConverterLibrary
    {
        public int GetInt(string nombre)
        {
            return int.Parse(nombre) + 1;
        }
    }
}
