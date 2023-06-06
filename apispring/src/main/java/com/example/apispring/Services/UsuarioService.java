package com.example.apispring.Services;

import com.example.apispring.model.Usuario;
import org.springframework.stereotype.Service;

@Service
public interface UsuarioService {
    Usuario getUsuarioById(Long id);
    Usuario saveUsuario(Usuario usuario);

}
