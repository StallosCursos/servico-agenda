using AgendaServico.Modelo;
using AgendaServico.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AgendaServico.Service.Extensoes
{
    public static class UsuarioExtension
    {
        public static string HashSenha(this Usuario usuario)
        {
            if (!string.IsNullOrEmpty(usuario.Senha))
            {
                byte[] encodeSenha = new UTF8Encoding().GetBytes(usuario.Senha);
                byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodeSenha);

                return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
            }
            else
                throw UsuarioException.SenhaNaoFornecida;
        }
    }
}
