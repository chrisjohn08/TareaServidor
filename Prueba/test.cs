using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Models;
using Core.Repositorios;
using System;
using System.Collections.Generic;
using System.IO;


namespace Prueba
{
    [TestClass]
    public class XmlRepositoryTests
    {
        private string _tempFile;

        [TestInitialize]
        public void Setup()
        {
            _tempFile = Path.GetTempFileName();
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(_tempFile)) File.Delete(_tempFile);
        }

        [TestMethod]
        public void SaveAndLoad_ServesMultipleServers_ReturnsSameList()
        {
            // Arrange
            var servers = new List<Server>
            {
                new Server
                {
                    Id = Guid.NewGuid(),
                    Name = "Test1",
                    IP = "127.0.0.1",
                    Username = "usr",
                    EncryptedPassword = "pwd",
                    Comandos = new List<comandos>
                    {
                        new comandos { Id = Guid.NewGuid(), ServerId = Guid.Empty, Text = "echo Hi" }
                    }
                }
            };
            var repo = new XMLRepositorio(_tempFile);

            // Act
            repo.SaveAllServers(servers);
            var loaded = repo.LoadAllServers();

            // Assert
            Assert.AreEqual(servers.Count, loaded.Count);
            Assert.AreEqual(servers[0].Name, loaded[0].Name);
            Assert.AreEqual(servers[0].Comandos[0].Text, loaded[0].Comandos[0].Text);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void LoadAllServers_InvalidXml_ThrowsInvalidOperationException()
        {
            // Arrange: escribir contenido no XML
            File.WriteAllText(_tempFile, "not xml content");
            var repo = new XMLRepositorio(_tempFile);

            // Act
            var _ = repo.LoadAllServers();
        }
    }
}
