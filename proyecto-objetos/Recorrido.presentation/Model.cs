﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoParadigmas.Recorrido.presentation
{
    public class Model
    {

        private ArrayList listaDeSaltos;

        public Model()
        {
            listaDeSaltos = new ArrayList();
        }

        public ArrayList ListaDeSaltos { get => listaDeSaltos; set => listaDeSaltos = value; }
    }
}
