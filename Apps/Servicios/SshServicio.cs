﻿using Core.Models;
using Renci.SshNet;
using System;

namespace Apps.Servicios
{
    public  class SshServicio
    {
        public string ExecuteCommand(Server server, string commandText)
        {
            if (server == null) throw new ArgumentNullException(nameof(server));
            if (string.IsNullOrWhiteSpace(commandText)) throw new ArgumentException("El comando no puede estar vacío.");

            // Desencriptar la contraseña
            Utils.EncryptionHelper des = new Utils.EncryptionHelper();
            var password = des.Decrypt(server.EncryptedPassword);

            try
            {
                using var client = new SshClient(server.IP, server.Username, password);
                client.Connect();
                var cmd = client.CreateCommand(commandText);
                var result = cmd.Execute();

                // Capturar también posibles errores
                var error = cmd.Error;
                client.Disconnect();

                return string.IsNullOrEmpty(error)
                    ? result
                    : $"ERROR: {error}\n{result}";
            }
            catch (Exception ex)
            {
                // Log o rethrow según conveniencia
                return $"Excepción al ejecutar SSH: {ex.Message}";
            }
        }
    }
}
