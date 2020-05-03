using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BusinessLogic
{
    public static class ProductosManager
    {
        public static int Guardar(Producto pProducto)
        {
            return ProductosDAL.Guardar(pProducto);
        }
        public static List<Producto> Buscar()
        {
            return ProductosDAL.Buscar();
        }
        public static List<Producto> Buscar(string pNombre)
        {
            return ProductosDAL.Buscar(pNombre);
        }
        public static int Eliminar(int pID)
        {
            return ProductosDAL.Eliminar(pID);
        }
    }
}
