﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
   public class RegisterHelloBL
    {
        RegisterHelloRL _registerHelloRL;

        public RegisterHelloBL(RegisterHelloRL registerHelloRL)
        {
            _registerHelloRL = registerHelloRL;
        }
        public string registration(string name)
        {
            return "This is Bussiness Layer Data = "+ _registerHelloRL.getHello(name);
        }
    }
}
