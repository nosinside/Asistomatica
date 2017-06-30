create database bd_Asistomatica
use bd_Asistomatica
go
create table tbo_docentes(nombre varchar (40),
						rut int primary key,
						usuario varchar (10),
						contraseña varchar (10))
go
create table tbo_asignatura(nombre varchar (20),
							seccion int,
							cantidadalumnos int,
							ubicacion varchar (40),
							sede varchar (40),
							horas int,
							porcentajeAsistencia int,
							codigo int primary key,
							docente int foreign key references tbo_docentes(rut))
go
create table tbo_alumnos(rut varchar (10) primary key ,
						nombre varchar (30),
						codigoAsignatura int foreign key references tbo_asignatura(codigo))
go
create table tbo_encargados(nombre varchar (20),
							rut int primary key,
							usuario varchar (10),
							contraseña varchar (10))
go
create table tbo_libros(identificador int primary key,
						rutDocente int foreign key references tbo_docentes(rut),
						codigoAsignatura int foreign key references tbo_asignatura(codigo),
						fechainicio datetime, fechatermino datetime,
						descripcionAsignatura varchar (100),
						porcentajeAsistencia int,
						sede varchar (50),
						cantidadAlumnos Int,
						horas int)



						