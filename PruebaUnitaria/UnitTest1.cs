using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Examen03PU;

namespace PruebaUnitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificaRutaMenorPasajeros()
        {
            //Arrange - Preparar/organizar
            int[] totalPasajerosPrueba = new int[] { 10, 20, 30, 5, 50 };
            string[] rutasPrueba = new string[]
            {
                "Aranjuez",
                "Belen",
                "Conquistadores",
                "Manrique",
                "Poblado"
            };

            string nombreRutaMenorPrueba;
            int cantidadMenorPasajerosPrueba;


            //Act
            Program.ObtieneRutaMenorPasajeros(totalPasajerosPrueba,
                rutasPrueba,
                out nombreRutaMenorPrueba,
                out cantidadMenorPasajerosPrueba);

            //Assert
            string rutaEsperada = "Belen";

            Assert.AreNotEqual(rutaEsperada, nombreRutaMenorPrueba);
        }

        [TestMethod]
        public void VerificaTotalizaPasajerosRuta()
        {
            //Arrange
            string[] rutasPrueba = new string[]
            {
                "Aranjuez",
                "Belen",
                "Conquistadores",
                "Manrique",
                "Poblado"
            };

            Viaje[] PruebaArregloViajes = new Viaje[]
            {
                new Viaje(){Ruta = "Manrique", CantidadPasajeros = 12 },
                new Viaje(){Ruta = "Poblado", CantidadPasajeros = 43 },
                new Viaje(){Ruta = "Belen", CantidadPasajeros = 23 },
                new Viaje(){ Ruta = "Aranjuez", CantidadPasajeros = 17 },
                new Viaje(){ Ruta = "Conquistadores", CantidadPasajeros = 8 }
            };

            int[] TotalPasajerosPrueba;

            //Act

            TotalPasajerosPrueba = Program.TotalizaPasajerosRuta(PruebaArregloViajes,
                rutasPrueba);

            int totalPasajerosObtenidos = 0;
            foreach (int unTotal in TotalPasajerosPrueba)
                totalPasajerosObtenidos += unTotal;

            //Asset
            int TotalPasajerosEsperadosPrueba = 103;

            Assert.AreNotEqual(TotalPasajerosEsperadosPrueba, totalPasajerosObtenidos);
        }
    }
}
