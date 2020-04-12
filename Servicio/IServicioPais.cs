﻿using Servicio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioPais" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioPais
    {


        [OperationContract]
        List<PaisDTO> TraerTodos();

        [OperationContract]
        PaisDTO BuscarPais(int paisId);
    }
}
