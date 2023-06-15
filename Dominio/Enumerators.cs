﻿public enum Estado
{
    Nuevo, 
    Reprogramado, 
    NoAsistio, 
    Cancelado, 
    Cerrado
}

public enum Especialidad
{
    Ginecologia,
    Pediatria,
    Oftalmologia,
    Oncologia,
    Traumatologia,
    Psicologia,
    Odontologia
}

public enum TipoUsuario
{
    Admin = 1,
    Doctor,
    Recepcionista,
    Paciente
}
public enum Sexo
{
    Masculino,
    Femenino,
    PrefiereNoDecir
}