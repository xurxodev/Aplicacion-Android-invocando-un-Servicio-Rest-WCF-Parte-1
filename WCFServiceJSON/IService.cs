using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;  

namespace WCFServiceJSON
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<DTOCliente> GetClientes();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<DTOProveedor> GetProveedores();

    }
}
