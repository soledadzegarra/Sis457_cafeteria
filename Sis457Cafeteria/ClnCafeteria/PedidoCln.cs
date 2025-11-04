using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadCafeteria;

namespace ClnCafeteria
{
    public class PedidoCln
    {
        public static int insertar(Pedido pedido)
        {
            using (var context = new LabCafeteriaEntities())
            {
                context.Pedido.Add(pedido);
                context.SaveChanges();
                return pedido.id;
            }
        }

        public static List<Pedido> listar()
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.Pedido.Where(x => x.estado != -1).ToList();
            }
        }
        public static List<paPedidoListar_Result> listarPa(string parametro)
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.paPedidoListar(parametro).ToList();
            }
        }
    }
}
