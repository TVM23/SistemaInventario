﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos.Especificaciones
{
    public class MetaData
    {
        public int TotalPage { get; set; } //Total de pagina de mi tabla productos
        public int PageSize { get; set; } 
        public int TotalCount {  get; set; } //Total de registros deproductos
    }
}
