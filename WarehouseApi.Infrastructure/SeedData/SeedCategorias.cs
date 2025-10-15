using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApi.Core.Entities;

namespace WarehouseApi.Infrastructure.SeedData
{
    internal static class SeedCategorias
    {
        public static IEnumerable<Categorias> Get()
        {
            return
            [
                new Categorias {CategoriasId=1,Nombre="Electronicos" } ,
                new Categorias {CategoriasId=2,Nombre="Ropa" } ,
                new Categorias {CategoriasId=3,Nombre="Hogar" } ,
                new Categorias {CategoriasId=4,Nombre="Juguetes" } ,
                new Categorias {CategoriasId=5,Nombre="Deportes" } ,
                new Categorias {CategoriasId=6,Nombre="Libros" } ,
                new Categorias {CategoriasId=7,Nombre="Belleza" } ,

            ];
        }
    }
}
