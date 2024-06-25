using Dominio_DDD_Fechadenacimiento_ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;

namespace TestProject_TP_DDD_Dominio_Fechadenacimiento_ValueObjects
{
    [TestClass]
    public class FechaNacimientoTests
    {
        [TestMethod]
        public void EsMayorDeEdad_DeberiaRetornarTrue_CuandoEsMayorOIgualA18()
        {
            // Arrange
            DateTime fechaNacimiento = DateTime.Today.AddYears(-18); // Justo 18 años
            FechaNacimiento fecha = new FechaNacimiento(fechaNacimiento);

            // Act
            bool esMayorDeEdad = fecha.EsMayorDeEdad();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(esMayorDeEdad, "Debería ser mayor de edad para una persona de 18 años.");
        }

        [TestMethod]
        public void EsMayorDeEdad_DeberiaRetornarFalse_CuandoEsMenorDe18()
        {
            // Arrange
            DateTime fechaNacimiento = DateTime.Today.AddYears(-17); // 17 años
            FechaNacimiento fecha = new FechaNacimiento(fechaNacimiento);

            // Act
            bool esMayorDeEdad = fecha.EsMayorDeEdad();

            // Assert
            Xunit.Assert.False(esMayorDeEdad, "No debería ser mayor de edad para una persona de 17 años.");
        }

        [TestMethod]
        public void Valor_DeberiaRetornarFechaCorrecta()
        {
            // Arrange
            DateTime fechaNacimiento = new DateTime(2000, 1, 1);
            FechaNacimiento fecha = new FechaNacimiento(fechaNacimiento);

            // Act
            DateTime valorRetornado = fecha.Valor();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(fechaNacimiento, valorRetornado, "La fecha retornada debería ser igual a la fecha de nacimiento inicial.");
        }
    }
}