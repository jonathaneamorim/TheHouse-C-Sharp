﻿using Model.Entities.GrupoUsuario;

namespace Model.Repositories.UsuarioRepository
{
    public interface UsuarioService
    {
        Task<IEnumerable<Usuario>> GetAllUsuario();
        Task<Usuario?> GetUsuarioById(int id);
        Task AddUsuario(Usuario usuario);
        Task SaveChangesAsync();
    }
}