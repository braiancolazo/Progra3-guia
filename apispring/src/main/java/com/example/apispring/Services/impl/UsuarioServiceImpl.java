package com.example.apispring.Services.impl;

import com.example.apispring.Services.UsuarioService;
import com.example.apispring.entitiy.UsuarioEntity;
import com.example.apispring.model.Usuario;
import com.example.apispring.repositories.jpa.UsuarioJpaRepository;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class UsuarioServiceImpl implements UsuarioService {
    @Autowired
    private UsuarioJpaRepository usuarioJpaRepository;

    @Autowired
    private ModelMapper modelMapper;

    @Override
    public Usuario getUsuarioById(Long id) {
        UsuarioEntity usuarioEntity = usuarioJpaRepository.getReferenceById(id);
        Usuario usuario = modelMapper.map(usuarioEntity,Usuario.class);
        return usuario;
    }

    @Override
    public Usuario saveUsuario(Usuario usuario) {
        UsuarioEntity usuarioentitiy = modelMapper.map(usuario,UsuarioEntity.class);
        UsuarioEntity saveusuarientity =usuarioJpaRepository.save(usuarioentitiy);
        return modelMapper.map(saveusuarientity,Usuario.class);
    }
}
