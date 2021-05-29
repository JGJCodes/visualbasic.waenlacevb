sp_helpdb


create database bdEnlaceVB

use bdEnlaceVB

sp_tables

create table Alumnos ( ctrol int, nombre varchar(30), carrera varchar(20))

insert into Alumnos (ctrol, nombre, carrera) values (1,'hugo sanchez', 'dentista')
insert into Alumnos (ctrol, nombre, carrera) values (2,'manlo negrete', 'abogado')
insert into Alumnos (ctrol, nombre, carrera) values (3,'luis flores', 'ingeniero')
insert into Alumnos (ctrol, nombre, carrera) values (4,'tuca ferreti', 'entrenador')
insert into Alumnos (ctrol, nombre, carrera) values (5,'jorge campos', 'dentista')

select * from Alumnos
