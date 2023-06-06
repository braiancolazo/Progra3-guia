package com.example.apispring.repositories.jpa;

import com.example.apispring.entitiy.UsuarioEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface UsuarioJpaRepository extends JpaRepository<UsuarioEntity,Long> {

}
