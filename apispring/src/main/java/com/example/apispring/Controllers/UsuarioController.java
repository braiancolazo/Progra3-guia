package com.example.apispring.Controllers;

import com.example.apispring.Services.UsuarioService;
import com.example.apispring.entitiy.UsuarioEntity;
import com.example.apispring.model.Usuario;
import com.example.apispring.repositories.jpa.UsuarioJpaRepository;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/usuarios")
public class UsuarioController {
    @Autowired
    private UsuarioService usuarioService;



    @GetMapping("/{id}")
    public ResponseEntity<Usuario> getById(@PathVariable Long id){



        return ResponseEntity.ok(usuarioService.getUsuarioById(id));
    }

    @PostMapping("")
    public ResponseEntity<Usuario> saveUsuario(@RequestBody @Valid Usuario usuario){
        return ResponseEntity.ok(usuarioService.saveUsuario(usuario));
    }
}
