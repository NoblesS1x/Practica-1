using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Inventario
    {
        
        public int idinventario { get; set; }
        public String nombreCorto { get; set; }
        public String Descripcion { get; set; }
        public String serie { get; set; }
        public String color { get; set; }
        public String fechaAdquision { get; set; }
        public String tipoAdquision { get; set; }
        public String observaciones { get; set; }
        public int idAreas { get; set; }

        public Inventario()
        {

        }
        public Inventario(int idinventario, string nombreCorto, string descripcion, string serie, string color, string fechaAdquision, string tipoAdquision, string observaciones, int idAreas)
        {
            this.idinventario = idinventario;
            this.nombreCorto = nombreCorto;
            this.Descripcion = descripcion;
            this.serie = serie;
            this.color = color;
            this.fechaAdquision = fechaAdquision;
            this.tipoAdquision = tipoAdquision;
            this.observaciones = observaciones;
            this.idAreas = idAreas;
        }
    }
}
