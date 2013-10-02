using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCFServiceJSON
{
    [DataContract]
    public class DTOCliente 
    {
        [DataMember]
        public string CodCliente { get; set; }
        [DataMember]
        public string RazonSocial { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Telefono { get; set; }

    }

    [DataContract]
    public class DTOProveedor
    {
        [DataMember]
        public string CodProveedor { get; set; }
        [DataMember]
        public string RazonSocial { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Telefono { get; set; }
    }
}
