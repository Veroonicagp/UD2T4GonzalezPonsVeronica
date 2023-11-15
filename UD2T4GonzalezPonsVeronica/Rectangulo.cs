/////////////////////////////////////////////
///Tarea:UD2T4
///Alumna: Verónica González Pons
///Curso: 2023/2024
////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4GonzalezPonsVeronica
{
    internal class Rectangulo : Figura
    {
        private float l1, l2;

        /// <summary>
        /// constructor de rectangulo
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        public Rectangulo(float l1, float l2)
        {
            this.l1 = l1;
            this.l2 = l2;
        }

        /// <summary>
        /// Sobreescribe el metodo Perímetro de la clase padre Figura
        /// </summary>
        /// <returns>
        /// Devuelve el perímetro de el rectángulo
        /// </returns>
        public override float Perimetro() => (l1 + l2) * 2;

        /// <summary>
        /// Sobreescribe el metodo Área de la clase padre Figura
        /// </summary>
        /// <returns>
        /// Devuelve el area total de el rectángulo
        /// </returns>
        public override float Area() => l1 * l2;



    }
}

