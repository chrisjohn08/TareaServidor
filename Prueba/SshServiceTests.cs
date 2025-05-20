using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Core.Interfaces;
using Core.Models;
using Renci.SshNet;
using Apps.Utils;
using ISshClient = Core.Interfaces.ISshClient;



namespace Tests
{
    [TestClass]
    public class SshServiceTests
    {

        Apps.Utils.EncryptionHelper des = new Apps.Utils.EncryptionHelper();

        [TestMethod]

        
        public void ExecuteCommand_Valid_CallsConnectExecuteDisconnect()
        {
            // Arrange
            var mockFactory = new Mock<ISSHClientFactory>();
            var mockClient = new Mock<Core.Interfaces.ISshClient>();
            // Creamos un SshCommand simulado que devuelva algo
            var fakeCmd = new Mock<SshCommand>(MockBehavior.Loose, (object)null);
            fakeCmd.Setup(c => c.Execute()).Returns("OK");

            mockClient
                .Setup(c => c.CreateCommand("ls"))
                .Returns(fakeCmd.Object);

            mockFactory
                .Setup(f => f.Create(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns(mockClient.Object);

            var service = new SshService(mockFactory.Object);
            var server = new Server
            

            {
                IP = "host",
                Username = "usr",
                EncryptedPassword = des.Encrypt("pwd") // puedes usar un string plano también
            };

            // Act
            var output = service.ExecuteCommand(server, "ls");

            // Assert
            mockClient.Verify(c => c.Connect(), Times.Once);
            mockClient.Verify(c => c.CreateCommand("ls"), Times.Once);
            mockClient.Verify(c => c.Disconnect(), Times.Once);
            Assert.AreEqual("OK", output);
        }

        [TestMethod]
        public void ExecuteCommand_Valid_ReturnsOutput()
        {
            // Arrange
            var mockFactory = new Mock<ISSHClientFactory>();
            var mockClient = new Mock<ISshClient>();
            mockFactory
                .Setup(f => f.Create(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns(mockClient.Object);
            mockClient.Setup(c => c.CreateCommand("ls")).Returns(new Mock<SshCommand>().Object);
            var service = new SshService(mockFactory.Object);
            var server = new Server { IP = "host", Username = "usr", EncryptedPassword = "pwd" };

            // Act
            var output = service.ExecuteCommand(server, "ls");

            // Assert
            mockClient.Verify(c => c.Connect(), Times.Once);
            mockClient.Verify(c => c.CreateCommand("ls"), Times.Once);
            mockClient.Verify(c => c.Disconnect(), Times.Once);
        }


    }
}
