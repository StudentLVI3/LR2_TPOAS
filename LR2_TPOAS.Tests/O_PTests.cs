using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LR2_TPOAS.Tests
{
    [TestClass]
    public class O_PTests
    {
        // Test №1
        [TestMethod]
        public void OP_X0_Y3_Z4_5returned()
        {
            // Arrange
            double X = 0;
            double Y = 3;
            double Z = 4;
            double expected = 5;

            // Act
            O_P op = new O_P();
            double actual = op.OP(X, Y, Z);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // Test №2
        [TestMethod]
        public void OP_X3_Y0_Z4_5returned()
        {
            // Arrange
            double X = 3;
            double Y = 0;
            double Z = 4;
            double expected = 5;

            // Act
            O_P op = new O_P();
            double actual = op.OP(X, Y, Z);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // Test №3
        [TestMethod]
        public void OP_X3_Y4_Z0_5returned()
        {
            // Arrange
            double X = 3;
            double Y = 4;
            double Z = 0;
            double expected = 5;

            // Act
            O_P op = new O_P();
            double actual = op.OP(X, Y, Z);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // Test №4
        [TestMethod]
        public void OP_X0_Yminus3_Zminus4_5returned()
        {
            // Arrange
            double X = 0;
            double Y = -3;
            double Z = -4;
            double expected = 5;

            // Act
            O_P op = new O_P();
            double actual = op.OP(X, Y, Z);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // Test №5
        [TestMethod]
        public void OP_Xminus3_Y0_Zminus4_5returned()
        {
            // Arrange
            double X = -3;
            double Y = 0;
            double Z = -4;
            double expected = 5;

            // Act
            O_P op = new O_P();
            double actual = op.OP(X, Y, Z);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // Test №6
        [TestMethod]
        public void OP_Xminus3_Yminus4_Z0_5returned()
        {
            // Arrange
            double X = -3;
            double Y = -4;
            double Z = 0;
            double expected = 5;

            // Act
            O_P op = new O_P();
            double actual = op.OP(X, Y, Z);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // Test №7
        [TestMethod]
        public void OP_X0_Y0_Z0_0returned()
        {
            // Arrange
            double X = 0;
            double Y = 0;
            double Z = 0;
            double expected = 0;

            // Act
            O_P op = new O_P();
            double actual = op.OP(X, Y, Z);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // Test №8
        [TestMethod]
        public void OP_X3_Y6_Z6_9returned()
        {
            // Arrange
            double X = 3;
            double Y = 6;
            double Z = 6;
            double expected = 9;

            // Act
            O_P op = new O_P();
            double actual = op.OP(X, Y, Z);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // Test №9
        [TestMethod]
        public void OP_X3000_Y6000_Z6000_9000returned()
        {
            // Arrange
            double X = 3000;
            double Y = 6000;
            double Z = 6000;
            double expected = 9000;

            // Act
            O_P op = new O_P();
            double actual = op.OP(X, Y, Z);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // Test №10
        [TestMethod]
        public void OP_Xminus3000_Yminus6000_Zminus6000_9000returned()
        {
            // Arrange
            double X = -3000;
            double Y = -6000;
            double Z = -6000;
            double expected = 9000;

            // Act
            O_P op = new O_P();
            double actual = op.OP(X, Y, Z);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}