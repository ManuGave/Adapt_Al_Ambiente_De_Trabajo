-- 1. Tabla Especialidad
CREATE TABLE Especialidad (
    id INTEGER PRIMARY KEY,
    nombre TEXT NOT NULL,
    duracion INTEGER,
    matricula_medico_FK INTEGER REFERENCES Medico(matricula)
);

-- 2. Tabla Medico
CREATE TABLE Medico (
    matricula INTEGER PRIMARY KEY,
    nombre TEXT NOT NULL,
    apellido TEXT NOT NULL
);

-- 3. Tabla Paciente
CREATE TABLE Paciente (
    dni INTEGER PRIMARY KEY,
    nombre TEXT NOT NULL,
    apellido TEXT NOT NULL,
    tel TEXT,
    mail TEXT,
    fecha_nac TEXT,
    fecha_baja TEXT
);

-- 4. Tabla Estado
CREATE TABLE Estado (
    id INTEGER PRIMARY KEY,
    descripcion TEXT NOT NULL
);

-- 5. Tabla Disponibilidad
CREATE TABLE Disponibilidad (
    dia TEXT,
    hora_ini TEXT,
    hora_fin TEXT,
    matricula_FK INTEGER,
    especialidad_id_FK INTEGER,
    PRIMARY KEY (matricula_FK, especialidad_id_FK, dia, hora_ini),
    FOREIGN KEY (matricula_FK) REFERENCES Medico(matricula),
    FOREIGN KEY (especialidad_id_FK) REFERENCES Especialidad(id)
);

-- 6. Tabla Turno
CREATE TABLE Turno (
    dni_paciente_FK INTEGER,
    especialidad_id_FK INTEGER,
    matricula_FK INTEGER,
    hora TEXT NOT NULL,
    fecha TEXT NOT NULL,
    estado_id_FK INTEGER,
    PRIMARY KEY (dni_paciente_FK, especialidad_id_FK, matricula_FK, fecha, hora),
    FOREIGN KEY (dni_paciente_FK) REFERENCES Paciente(dni),
    FOREIGN KEY (especialidad_id_FK) REFERENCES Especialidad(id),
    FOREIGN KEY (matricula_FK) REFERENCES Medico(matricula),
    FOREIGN KEY (estado_id_FK) REFERENCES Estado(id)
);