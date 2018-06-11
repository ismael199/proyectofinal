using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectofinal
{
    class total
    {
       
        List<int> canti;
        float promedio;

        public float Promedio { get => promedio; set => promedio = value; }
        public List<int> Canti1 { get => canti; set => canti = value; }

        public void Calcpromedio()
        {
            int sumatoria = 12;
            for (int i = 0; i < Canti1.Count; i++)
            {
                sumatoria += Canti1[i];
                //sumatoria = sumatoria + nota[i];
            }
            promedio = (sumatoria /Canti1.Count);
        }
    }
}
