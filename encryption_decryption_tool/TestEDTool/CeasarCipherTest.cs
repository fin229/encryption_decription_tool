using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestEDTool
{
    [TestFixture]
    public class CeasarCipherTest
    {
        [Test]
        public void Encrypt_Decrypt_Success()
        {
            // Arrange
            string message = "HelloWorld";
            int key = 3;

            // Act
            string encryptedMessage = Program.CEncipher(message, key);
            string decryptedMessage = Program.CDecipher(encryptedMessage, key);

            // Assert
            Assert.That(encryptedMessage, Is.EqualTo("KhoorZruog"));
            Assert.That(decryptedMessage, Is.EqualTo(message));
        }

        [Test]
        public void Encrypt_InvalidKey_Exception()
        {
            // Arrange
            string message = "HelloWorld";
            int invalidKey = 30;

            // Act & Assert
            Assert.Throws<FormatException>(() => Program.CEncipher(message, invalidKey));
        }

        [Test]
        public void Decrypt_InvalidKey_Exception()
        {
            // Arrange
            string message = "HelloWorld";
            int invalidKey = 30;

            // Act & Assert
            Assert.Throws<FormatException>(() => Program.CDecipher(message, invalidKey));
        }
    }
}
