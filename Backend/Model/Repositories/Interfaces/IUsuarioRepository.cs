﻿using Model.Entities.Usuarios;

namespace Model.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> GetUsuarioById(Guid id);
        Usuario? GetUsuarioByEmail(string email);
        Task AddUsuario(Usuario usuario);
        Task SaveChangesAsync();
    }
}
