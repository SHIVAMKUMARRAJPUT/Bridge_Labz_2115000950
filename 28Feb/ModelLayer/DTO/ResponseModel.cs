﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
   public  class ResponseModel<T>
    {
        public bool success { get; set; } = true;
        public string Message { get; set; } = "";
        public T Data { get; set; } = default(T);

            
    }
}
