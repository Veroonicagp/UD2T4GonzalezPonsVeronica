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
    internal class Circulo : Figura
    {
        private float r;

        /// <summary>
        /// constructor del círculo
        /// </summary>
        /// <param name="r"></param>

        public Circulo(float r)
        {
            this.r = r;

        }

        /// <summary>
        /// Sobreescribe el metodo Perímetro de la clase padre Figura
        /// </summary>
        /// <returns>
        /// Devuelve el perímetro de el rectángulo
        /// </returns>
        public override float Perimetro() => (float)Math.PI * r * 2;

        /// <summary>
        /// Sobreescribe el metodo Área de la clase padre Figura
        /// </summary>
        /// <returns>
        /// Devuelve el area total de el rectángulo
        /// </returns>
        public override float Area() => (float)Math.PI * (r * r);


    }
}

