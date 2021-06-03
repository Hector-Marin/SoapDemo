using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapDemo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class OperationService : IOperationService
    {
        public string OperateValues(int operator1, int operator2)
        {
            var result = operator1 + operator2;
            return string.Format("The Result Is: {0}", result);
        }

        public string OperateObject(OperationElements elements)
        {
            var result = elements.OpA + elements.OpB;
            return string.Format("The Result Is: {0}", result);
        }
    }
}
