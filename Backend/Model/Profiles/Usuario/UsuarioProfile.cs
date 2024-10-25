﻿using AutoMapper;
using Model.DTOs.UsuarioDto;
using Model.Entities.GrupoUsuario;

namespace Model.Profiles.UsuarioProfile
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile() {
            // Mapear de Usuario para UsuarioDto
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
        }
    }
}
