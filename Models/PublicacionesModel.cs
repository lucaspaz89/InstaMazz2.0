﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InstaMazz2._0.Models
{
    public class PublicacionesModel
    {
        public int IdPost { get; set; }
        public int IdUsuario { get; set; }
        public string UrlImg { get; set; }
        public string Descripcion { get; set; }
    }
}