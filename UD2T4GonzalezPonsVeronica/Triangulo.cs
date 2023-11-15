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
    internal class Triangulo : Figura
    {
        private float b, h;

        /// <summary>
        /// constructor de Triángulo
        /// </summary>
        /// <param name="b"></param>
        /// <param name="h"></param>

        public Triangulo(float b, float h)
        {
            this.b = b;
            this.h = h;

        }

        /// <summary>
        /// Sobreescribe el metodo Perímetro de la clase padre Figura
        /// </summary>
        /// <returns>
        /// Devuelve el perímetro de el Triángulo
        /// </returns>
        public override float Perimetro() => b * 3;

        /// <summary>
        /// Sobreescribe el metodo Área de la clase padre Figura
        /// </summary>
        /// <returns>
        /// Devuelve el area total de el Triángulo
        /// </returns>
        public override float Area() => (b * h) / 2;






    }
}
