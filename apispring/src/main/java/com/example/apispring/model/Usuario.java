package com.example.apispring.model;

import com.fasterxml.jackson.annotation.JsonFormat;
import jakarta.annotation.Nullable;
import jakarta.validation.constraints.Email;
import jakarta.validation.constraints.NotNull;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;


import java.time.LocalDateTime;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class Usuario {
    private Long id;
    @NotNull(message = "el username no puede ser nulo")
    private String username;
    @NotNull(message = "la password no puede ser nulo")
    private String password;
    @NotNull(message = "el email no puede ser nulo")
    @Email(message = "El email tiene que ser valido")
    private String email;
    private String avatar;
    @JsonFormat(shape = JsonFormat.Shape.STRING, pattern = "dd-MM-yyyy hh:mm:ss")
    private LocalDateTime lastLoginDate;



}
