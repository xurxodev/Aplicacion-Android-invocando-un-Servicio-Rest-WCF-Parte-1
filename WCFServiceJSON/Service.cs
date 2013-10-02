using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceJSON
{
    public class Service : IService
    {
        public List<DTOCliente> GetClientes()
        {

            List<DTOCliente> ListaClientes = new List<DTOCliente>();

            ListaClientes.Add (new DTOCliente { CodCliente = "CLI0001", RazonSocial = "Cliente ejemplo 1", Direccion = "Avenida de America Nº 32 Madrid", Telefono = "915896369" }) ;
            ListaClientes.Add (new DTOCliente { CodCliente = "CLI0002", RazonSocial = "Cliente ejemplo 2", Direccion = "Calle Jilgero Nº 24 Madrid", Telefono = "915896369" }) ;
            ListaClientes.Add (new DTOCliente { CodCliente = "CLI0003", RazonSocial = "Cliente ejemplo 3", Direccion = "Calle Campomanes a Nº 45 Pozuelo de Alarcon", Telefono = "915896369" }) ;
            ListaClientes.Add (new DTOCliente { CodCliente = "CLI0004", RazonSocial = "Cliente ejemplo 4", Direccion = "Calle Pinzón Nº 9 Madrid", Telefono = "915896369" }) ;
            ListaClientes.Add (new DTOCliente { CodCliente = "CLI0005", RazonSocial = "Cliente ejemplo 5", Direccion = "Calle  Nº 69 Madrid", Telefono = "915896369" }) ;
            ListaClientes.Add (new DTOCliente { CodCliente = "CLI0006", RazonSocial = "Cliente ejemplo 6", Direccion = "Avenida de Abrantes Nº 25 Madrid", Telefono = "915896369" }) ;
            ListaClientes.Add (new DTOCliente { CodCliente = "CLI0007", RazonSocial =  "Cliente ejemplo 7", Direccion = "Avenida de de Nuestra señora de Fatima Nº 25 Madrid", Telefono = "915896369" });

            return ListaClientes;
        }

        public List<DTOProveedor> GetProveedores()
        {
            List<DTOProveedor> ListaProveedores = new List<DTOProveedor>();

            ListaProveedores.Add (new DTOProveedor{ CodProveedor = "PROV0001", RazonSocial = "Proveedor ejemplo 1", Direccion = "Calle Alcala Nº32 Madrid", Telefono = "915896369" }) ;
            ListaProveedores.Add(new DTOProveedor { CodProveedor = "PROV0002", RazonSocial = "Proveedor ejemplo 2", Direccion = "Calle San Bernardo Nº45 Madrid", Telefono = "915896369" });
            ListaProveedores.Add(new DTOProveedor { CodProveedor = "PROV0003", RazonSocial = "Proveedor ejemplo 3", Direccion = "Calle Princesa Nº14 Madrid", Telefono = "915896369" });
            ListaProveedores.Add(new DTOProveedor { CodProveedor = "PROV0004", RazonSocial = "Proveedor ejemplo 4", Direccion = "Calle Goya Nº2 Madrid", Telefono = "915896369" });
            ListaProveedores.Add(new DTOProveedor { CodProveedor = "PROV0005", RazonSocial = "Proveedor ejemplo 5", Direccion = "Calle Principe de Vergara Nº22 Madrid", Telefono = "915896369" });
            ListaProveedores.Add(new DTOProveedor { CodProveedor = "PROV0006", RazonSocial = "Proveedor ejemplo 6", Direccion = "Calle Oca Nº5 Madrid", Telefono = "915896369" });
            ListaProveedores.Add(new DTOProveedor { CodProveedor = "PROV0007", RazonSocial = "Proveedor ejemplo 7", Direccion = "Avenida de los Poblados Nº9 Madrid", Telefono = "915896369" });

            return ListaProveedores;
        }
    }
}