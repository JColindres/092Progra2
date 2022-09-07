CREATE DATABASE SoulHealer_201602713;
USE SoulHealer_201602713;

-- CREAR TABLA GENERO
CREATE TABLE Genero(
	id_genero INT NOT NULL IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	PRIMARY KEY(id_genero)
);


-- CREAR TABLA EDITORIAL
CREATE TABLE Editorial(
	id_editorial INT  NOT NULL IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	direccion VARCHAR(50) NOT NULL,
	telefono INT NOT NULL,
    PRIMARY KEY(id_editorial)
);


-- CREAR TABLA USUARIO
CREATE TABLE Usuario(
	id_usuario INT NOT NULL IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(50) NOT NULL,
	usuario VARCHAR(50) NOT NULL,
	tipo_usr VARCHAR(50) NOT NULL,
	nacimiento DATE NOT NULL,
	contrasenia VARCHAR(50) NOT NULL
	PRIMARY KEY(id_usuario)
);


-- CREAR TABLA LIBRO
CREATE TABLE Libro(
	id_libro INT NOT NULL IDENTITY(1,1),
	id_editorial INT NOT NULL,
	genero INT NOT NULL,
	titulo VARCHAR(50) NOT NULL,
	autor VARCHAR(50) NOT NULL,
	cantidad INT NOT NULL,

	PRIMARY KEY(id_libro),
	CONSTRAINT fk_id_editorial FOREIGN KEY(id_editorial)
		REFERENCES Editorial(id_editorial) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT fk_id_genero FOREIGN KEY(genero)
		REFERENCES Genero(id_genero) ON UPDATE CASCADE ON DELETE CASCADE
);


-- CREAR TABLA PRESTAMO
CREATE TABLE Prestamo(
	id_prestamo INT NOT NULL IDENTITY(1,1),
	id_usuario INT NOT NULL,
	id_libro INT NOT NULL,
	estatus BIT NOT NULL,
	PRIMARY KEY(id_prestamo),
	
	CONSTRAINT fk_id_usuario FOREIGN KEY(id_usuario)
		REFERENCES Usuario(id_usuario) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT fk_id_libro FOREIGN KEY(id_libro)
		REFERENCES Libro(id_libro) ON UPDATE CASCADE ON DELETE CASCADE
);


-- INSERTANDO LOS GENEROS DE LIBROS
INSERT INTO Genero(nombre)
VALUES('Aventuras');
INSERT INTO Genero(nombre)
VALUES('Ciencia Ficcion');
INSERT INTO Genero(nombre)
VALUES('Policiaco');
INSERT INTO Genero(nombre)
VALUES('Terror y misterio');
INSERT INTO Genero(nombre)
VALUES('Romantica');
INSERT INTO Genero(nombre)
VALUES('Humor');

-- INSERTANDO EDITORIALES
INSERT INTO Editorial(nombre,direccion,telefono)
VALUES('Alianza','Direccion1',12345678);
INSERT INTO Editorial(nombre,direccion,telefono)
VALUES('Ariel','Direccion2',90123456);
INSERT INTO Editorial(nombre,direccion,telefono)
VALUES('Catedra','Direccion3',78901234);
INSERT INTO Editorial(nombre,direccion,telefono)
VALUES('Tirant Lo Blanch','Direccion4',56789012);
INSERT INTO Editorial(nombre,direccion,telefono)
VALUES('Akal','Direccion5',34556789);

-- INSERTANDO USUARIO
INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia)
VALUES('Gustavo','Hernandez','user1','Administrador','03-09-1998','1234');
INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia)
VALUES('Manuel','Rey','user2','Cliente','06-03-2000','5678');
INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia)
VALUES('Angel','Sanchez','user3','Administrador','06-03-2000','qwer');
INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia)
VALUES('Maria','Blanco','user4','Cliente','03-09-1999','asdf');
INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia)
VALUES('Julia','Polo','user5','Administrador','04-10-1989','zxcv');
INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia)
VALUES('Kimberly','Castellanos','user6','Cliente','03-07-2002','yuti');

-- INSERTANDO LIBRO
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(1,1,'Dos años de vacaciones','Julio Verner',5);
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(3,1,'Las aventuras de Tom Sawyer','Mark Twain',7);
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(2,2,'El señor de los anillos','JRR Tolkien',3);
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(2,2,'Harry Potter y el caliz de fuego','JK Rowling',1);
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(2,3,'Los crímenes de la calle Morgue','Edgar Allan Poe',4);
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(4,3,'El misterio de Marie Rogêt','Edgar Allan Poe',2);
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(4,6,'El proyecto esposa','Graeme Simsion',3);


-- INSERTANDO PRESTAMO
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(2,1,0);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(2,2,0);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(2,3,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(2,4,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(2,5,0);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(2,6,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(4,3,0);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(4,4,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(4,5,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(4,6,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(3,2,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(3,1,0);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(1,1,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(5,4,0);


select * from Prestamo;
truncate table usuario;

DELETE FROM Usuario
WHERE id_usuario = 1;

DELETE FROM Usuario
WHERE nombre = 'Gustavo'
AND apellido = 'Hernandez';

TRUNCATE TABLE Usuario;


DELETE FROM Prestamo
DBCC CHECKIDENT ('Prestamo', RESEED, 0);

DELETE FROM Usuario
DBCC CHECKIDENT ('Usuario', RESEED, 0);
--*Se realizan inserts*--
SELECT * FROM Usuario;

SELECT * 
FROM Prestamo;

SELECT Libro.titulo AS [Libro], Usuario.usuario AS [Prestado por], Prestamo.estatus AS [Aun lo tiene?]
FROM Libro, Usuario, Prestamo
WHERE Prestamo.id_libro = Libro.id_libro
AND Prestamo.id_usuario = Usuario.id_usuario;

/*
SELECT ed.nombre, COUNT(li.titulo) AS cantidad
FROM Editorial ed
JOIN Libro Li
ON ed.id_editorial = li.id_editorial
GROUP BY ed.nombre

SELECT li.titulo, COUNT(pr.id_usuario)
FROM Prestamo pr
INNER JOIN Libro li
ON pr.id_libro = li.id_libro
GROUP BY li.titulo




SELECT us.nombre, us.apellido, COUNT(pr.id_prestamo)
FROM Prestamo pr
INNER JOIN Libro li
ON pr.id_libro = li.id_libro
INNER JOIN Usuario us
ON us.id_usuario = pr.id_usuario/*