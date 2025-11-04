using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadCafeteria;

namespace ClnCafeteria
{
    public class CategoriasCln
    {
        public static List<Categoria> listar()
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.Categoria.Where(x => x.estado != -1).ToList();
            }
        }

        public static int insertar(Categoria categoria)
        {
            using (var context = new LabCafeteriaEntities())
            {
                var existente = context.Categoria
                .FirstOrDefault(c => c.nombre.ToLower() == categoria.nombre.ToLower());
                if (existente != null)
                {
                    if (existente.estado == -1)
                    {
                        existente.estado = 1;
                        context.SaveChanges();
                        return existente.id;
                    }
                }
                context.Categoria.Add(categoria);
                context.SaveChanges();
                return categoria.id;
            }
        }

        public static int eliminar(int id)
        {
            using (var context = new LabCafeteriaEntities())
            {
                var categoria = context.Categoria.Find(id);
                categoria.estado = -1;
                return context.SaveChanges();
            }
        }

        public static Categoria obtenerUno(int id)
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.Categoria.Find(id);
            }
        }
    }
}
