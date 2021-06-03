using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapDemo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IOperationService
    {

        [OperationContract]
        string OperateValues(int operator1, int operator2);

        [OperationContract]
        string OperateObject(OperationElements op);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class OperationElements
    {

        [DataMember]
        public int OpA { get; set; }

        [DataMember]
        public int OpB { get; set; }

    }
}
