USE SoulHealer_201602713;

--REPORTE 1--
SELECT DISTINCT Editorial.nombre, SUM(Libro.cantidad) AS [Cantidad]
FROM Libro, Editorial
WHERE Libro.id_editorial = Editorial.id_editorial
GROUP BY Editorial.nombre;

select * from Libro
--REPORTE 2----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
----------------[           0          ]--[          1         ]--[           2           ]--[              3              ]--[                  4                  ]--[                        5                               ]
SELECT DISTINCT Libro.titulo AS [Titulo], Libro.autor AS [Autor], Genero.nombre AS [Género], Editorial.nombre AS [Editorial], COUNT(Prestamo.id_libro) AS [Prestados], Libro.cantidad - COUNT(Prestamo.id_libro) AS [Disponibles]
FROM Libro, Prestamo, Genero, Editorial																	 --Llamamos a las tablas involucradas
WHERE Prestamo.id_libro = Libro.id_libro																 --Unir Prestamo con Libro
AND Libro.id_editorial = Editorial.id_editorial															 --Unir Libro con Editorial
AND Libro.genero = Genero.id_genero																		 --Unir Libro con Género
AND Prestamo.estatus = 1																				 --Limitamos a mostrar únicamente a los que se encuentras prestados
GROUP BY Prestamo.id_libro, Libro.titulo, Libro.cantidad, Libro.autor, Genero.nombre, Editorial.nombre;  --Agrupamos por cada columna agregada arriba


--REPORTE 3---
SELECT Libro.titulo, COUNT(Prestamo.estatus) AS [Numero de Veces Prestado]
FROM Prestamo, Libro
WHERE Prestamo.id_libro = Libro.id_libro
GROUP BY Libro.titulo; 

select * from Prestamo
--REPORTE 4---
SELECT --usuario y contar estatus
FROM Prestamo, Usuario
--agrupar

--REPORTE 5---
SELECT top 3 --usuario y contar estatus
FROM Prestamo, Usuario
--agrupar
--ordenar conteo descendente

--REPORTE 6---
SELECT top 5 --libro y contar estatus
FROM Prestamo
--agrupar
--ordenar conteo descendente


--///////////////////////////////////////////////////////////////////////////////////////////////////////



--Eliminar todos los registros de una tabla

DELETE FROM Usuario
DBCC CHECKIDENT ('Usuario', RESEED, 0);
--*Se realizan inserts*--
SELECT * FROM Usuario;


--Eliminar cierto registro de una tabla
DELETE FROM Usuario
WHERE id_usuario = 1;

DELETE FROM Usuario
WHERE nombre = 'Gustavo'
AND apellido = 'Hernandez';


SELECT * FROM Prestamo;
DELETE FROM Prestamo
WHERE id_prestamo > 1000;

SELECT DISTINCT Libro.titulo AS [Titulo], Libro.autor AS [Autor], Genero.nombre AS [Género], Editorial.nombre AS [Editorial], COUNT(Prestamo.id_libro) AS [Prestados], Libro.cantidad - COUNT(Prestamo.id_libro) AS [Disponibles]
FROM Libro, Prestamo, Genero, Editorial																	 --Llamamos a las tablas involucradas
WHERE Prestamo.id_libro = Libro.id_libro																 --Unir Prestamo con Libro
AND Libro.id_editorial = Editorial.id_editorial															 --Unir Libro con Editorial
AND Libro.genero = Genero.id_genero		
AND Libro.titulo LIKE '%y el%'																		 --Limitamos a mostrar únicamente a los que se encuentras prestados
GROUP BY Prestamo.id_libro, Libro.titulo, Libro.cantidad, Libro.autor, Genero.nombre, Editorial.nombre;