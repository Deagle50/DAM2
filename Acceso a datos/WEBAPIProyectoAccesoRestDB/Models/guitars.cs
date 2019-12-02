using System;
using System.Collections.Generic;

namespace WEBAPIProyectoAccesoRestDB.Models
{

    public class Guitarra
    {
        public int id_guitarra { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string forma { get; set; }
        public string pastillas { get; set; }
        public string color { get; set; }
        public float precio { get; set; }
    }
}