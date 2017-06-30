create database bd_Asistomatica
go
use bd_Asistomatica
go
create table tbo_docentes(nombre varchar (50) not null,
						rut int primary key,
						usuario varchar (50) not null,
						contraseña varchar (50) not null,
						tipoUsuario varchar (1) not null)
go
create table tbo_asignatura(nombre varchar (50)not null,
							seccion int not null,
							cantidadalumnos int not null,
							ubicacion varchar (40) not null,
							sede varchar (40) not null,
							horas int not null,
							porcentajeAsistencia int not null,
							codigo int IDENTITY(0,1) primary key,
							docente int foreign key references tbo_docentes(rut) not null)
go
create table tbo_alumnos(rut varchar (10) primary key ,
						nombre varchar (30) not null,
						codigoAsignatura int foreign key references tbo_asignatura(codigo) )
go
create table tbo_encargados(nombre varchar (50) not null,
							rut int primary key,
							usuario varchar (50) not null,
							contraseña varchar (50) not null,
							tipoUsuario varchar (1) not null)
go
create table tbo_libros(identificador int IDENTITY(0,1) primary key,
						rutDocente int foreign key references tbo_docentes(rut),
						codigoAsignatura int foreign key references tbo_asignatura(codigo) not null,
						fechainicio datetime, fechatermino datetime not null,
						descripcionAsignatura varchar (100) not null,
						porcentajeAsistencia int,
						sede varchar (50) not null,
						cantidadAlumnos Int not null,
						horas int not null)
go
insert into tbo_docentes values ('Wilfero Soler Jaldin', 111111111, 'wsoler', '123', 'D')
go
insert into tbo_encargados values ('Encargado Asistencia Antofagasta', 222222222, 'easistencia', '123', 'E')
go
insert into tbo_asignatura values ('Ingeniería en informática', 715, 5, '318', 'Antofagasta', '70','', 111111111)