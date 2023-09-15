using encryption_decryption_tool;
using NUnit.Framework;
using System;

namespace CeasarCipherTest
{
    [TestFixture]
    public class CeasarCiphertest1
    {
        [Test]
        public void TestCEncipher()
        {
            // Arrange
            string message = "Hello, World!";
            int key = 3;

            // Act
            string encryptedText = Program.CEncipher(message, key);

            // Assert
            string expected = "Khoor, Zruog!";
            Assert.That(encryptedText, Is.EqualTo(expected));
        }

        [Test]
        public void TestCDecipher()
        {
            // Arrange
            string encryptedText = "Khoor, Zruog!";
            int key = 3;

            // Act
            string decryptedText = Program.CDecipher(encryptedText, key);

            // Assert
            string expected = "Hello, World!";
            Assert.That(decryptedText, Is.EqualTo(expected));
        }
        [Test]
        public void TestInvalidKey()
        {
            // Arrange
            string message = "Hello, World!";
            int key = -5; // An invalid key (e.g., outside the valid range)

            // Act & Assert
            Assert.Throws<FormatException>(() => Program.CEncipher(message, key));
            Assert.Throws<FormatException>(() => Program.CDecipher(message, key));
        }
    }
}