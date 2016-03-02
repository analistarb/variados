using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows
{
    class Poligono
    {
        public Poligono()
        {
            this.Lados = new HashSet<Lado>();
        }

        public string Nome { get; set; }
        public virtual ICollection<Lado> Lados { get; set; }
        
        public int GetQtdLados()
        {
            return Lados.Count;
        }
    
    }
}
