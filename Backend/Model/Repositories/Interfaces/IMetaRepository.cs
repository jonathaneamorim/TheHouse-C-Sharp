﻿using Model.Entities.GrupoMeta;

namespace Model.Repositories.Interfaces
{
    public interface IMetaRepository
    {
        Task<IEnumerable<Meta>> GetAllMeta();
        Task<Meta?> GetMetaById(int id);
        Task SaveChangesAsync();
        Task AddMeta(Meta meta);
    }
}
