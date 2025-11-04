using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadCafeteria;

namespace ClnCafeteria
{
    public class DetallePedidoCln
    {
        public static int insertar(DetallePedido detalle)
        {
            using (var context = new LabCafeteriaEntities())
            {
                context.DetallePedido.Add(detalle);
                context.SaveChanges();
                return detalle.id;
            }
        }

        public static List<DetallePedido> listarPorPedido(int idPedido)
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.DetallePedido.Where(x => x.idPedido == idPedido && x.estado != -1).ToList();
            }
        }
    }
}
