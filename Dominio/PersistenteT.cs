﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Persistente<T> : Persistente
    {
        public abstract List<T> TraerTodo();
        
        
    }
}
