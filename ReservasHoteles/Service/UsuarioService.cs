﻿using ReservasHoteles.Domain.IRepositories;
using ReservasHoteles.Domain.IServices;
using ReservasHoteles.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservasHoteles.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task SaveUser(Usuario usuario)
        {
            await _usuarioRepository.SaveUser(usuario);
        }

        public async Task<List<Perfiles>> getPerfil()
        {
          return  await _usuarioRepository.getPerfil();
        }
    }
}
