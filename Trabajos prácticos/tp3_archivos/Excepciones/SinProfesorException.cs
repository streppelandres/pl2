﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException : Exception
    {

        /// <summary>
        /// Por defecto
        /// </summary>
        public SinProfesorException() : base() { }

        /// <summary>
        /// Envia el mensaje personalizado.
        /// </summary>
        /// <param name="mensaje"></param>
        public SinProfesorException(string mensaje) : base(mensaje) { }

        /// <summary>
        /// Envia el mensaje personalizado y la clase que provocó la excepción
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="origenError"></param>
        public SinProfesorException(string mensaje, string origenError) : base(mensaje)
        {
            base.Source = origenError;
        }

        /// <summary>
        /// Envia el mensaje personalizado y la excepción
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public SinProfesorException(string mensaje, Exception innerException) : base(mensaje, innerException) { }

        /// <summary>
        /// Envio el mensaje persoanlziado, la excepción y la clase que provocó la excepción
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="origenError"></param>
        /// <param name="innerException"></param>
        public SinProfesorException(string mensaje, string origenError, Exception innerException) : base(mensaje, innerException)
        {
            base.Source = origenError;
        }

        /// <summary>
        /// Sobreescritura del toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Mensaje: " + base.Message + ", Origen error: " + base.Source;
        }
    }
}
