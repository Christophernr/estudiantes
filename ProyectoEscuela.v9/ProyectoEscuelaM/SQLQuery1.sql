--creacion de base
create database DBEstudiantes
go

use DBEstudiantes
go
--aqui termina creacion de base

--creacion de secuencias
CREATE SEQUENCE sq_estudiante
AS INT 
START WITH 1 
INCREMENT BY 1 
NO MAXVALUE 
NO CACHE;
GO

--drop sequence sq_estudiante

CREATE SEQUENCE sq_asistencia
AS INT 
START WITH 1 
INCREMENT BY 1 
NO MAXVALUE 
NO CACHE;
GO

--drop sequence sq_asistencia

CREATE SEQUENCE sq_seccion
AS INT 
START WITH 1 
INCREMENT BY 1 
NO MAXVALUE 
NO CACHE;
GO

--drop sequence sq_seccion

CREATE SEQUENCE sq_justificacion
AS INT 
START WITH 1 
INCREMENT BY 1 
NO MAXVALUE 
NO CACHE;
GO

--drop sequence sq_justificacion

---creacion de tablas 

--tabla estudiantes

create table estudiantes(
idEstudiante int primary key,
IdCedula nvarchar(13),
nombre nvarchar (30),
apellidos nvarchar(50),
idSeccionFO int -- foreign
)
GO


--drop table estudiantes

-- tabla de asistencia

create table asistencia(
idAsistencia int primary key,
idEstudianteFO int, --foreign key 
fecha date,
estado nvarchar(1)

)
go

--drop table asistencia

--tabla de justificacion
CREATE TABLE justificacion (
idJustificacion INT PRIMARY KEY,
idAsistenciaFO INT, --foreign key
motivo nvarchar(max),
fechaJustificacion DATE
)
go
-- tabla de secciones
--drop table justificacion

create table seccion(
idSeccion int primary key,
seccion nvarchar(4)
)

--drop table seccion
---creacion de llaves foraneas
--relacion de asistencia a estudientes
ALTER TABLE asistencia
ADD CONSTRAINT fk_estudiantes_asistencia
foreign key (idEstudianteFO)
references estudiantes(idEstudiante)
go

-- relación estudiante -> sección
ALTER TABLE estudiantes
ADD CONSTRAINT FK_Estudiantes_Seccion
FOREIGN KEY (idSeccionFO)
REFERENCES seccion(idSeccion);
GO

--relacion de justificacion a asistencia
ALTER TABLE justificacion
ADD CONSTRAINT FK_Justificacion_Asistencia
FOREIGN KEY (idAsistenciaFO)
REFERENCES asistencia(idAsistencia);
GO



-- parte de procs

--propcs de estudiantes

create proc spBuscarEstudiantes
@textobuscar nvarchar(50)
as
select top 100 idEstudiante,IdCedula,apellidos,idSeccionFO
from estudiantes
where nombre like '%' + @textobuscar + '%' 
   or apellidos like '%' + @textobuscar + '%'
   or IdCedula like '%' + @textobuscar + '%'
order by nombre asc
go

--drop proc spBuscarEstudiantes

create proc spInsertarEstudiantes
@IdCedula nvarchar(13),
@nombre nvarchar(30),
@apellidos nvarchar(50),
@seccion int
as
insert into estudiantes(idEstudiante,IdCedula,nombre,apellidos,idSeccionFO)
values(next value for sq_estudiante,@IdCedula,@nombre,@apellidos,@seccion)
go

create proc spEditarEstudiantes
@idEstudiante int,
@Cedula nvarchar(13),
@nombre nvarchar(30),
@apellidos nvarchar(50),
@seccion int
as
update estudiantes set IdCedula=@Cedula, nombre=@nombre, apellidos=@apellidos, idSeccionFO=@seccion
where idEstudiante=@idEstudiante
go

create proc spExisteEstudiantes
@IdCedula nvarchar(20)
as
select IdCedula
from estudiantes
where IdCedula=@IdCedula
go


create proc spEliminarEstudiante
@idEstudiante int
as
delete from estudiantes
where @idEstudiante= idEstudiante
go
--create proc spCargarEstudiantes
--@seccion
--as
--begin
--    select idEstudiante, IdCedula,nombre,apellidos,idSeccionFO
--    from estudiantes
	
--    order by idEstudiante asc
--end
--go

--drop proc spCargarEstudiantes
--por si tengo que dropear en un futuro xd
--drop proc spBuscarEstudiantes
--go

--drop proc spInsertarEstudiantes
--go

--drop proc spEditarEstudiantes
--go

--drop proc spExisteEstudiantes
--go

--procs de asistencia

create proc spInsertarAsistencia
@idEstudianteFO int,
@estado nvarchar(1)
as
insert into asistencia(idAsistencia,idEstudianteFO,fecha,estado)
values(next value for sq_asistencia,@idEstudianteFO,GETDATE(),@estado)
go


create proc spEditarModificarAsistencia
@idAsistencia int, 
@fecha date,
@estado nvarchar(1)
as
update asistencia set fecha=@fecha, estado=@estado
where idAsistencia=@idAsistencia
go

create proc spBuscarAsistencia
@textobuscar date
as
select top 100 idAsistencia, idEstudianteFO, fecha, estado
from asistencia
where fecha = @textobuscar
order by fecha asc
go


--procs de justificacion

create proc spInsertarJustificacion
@idAsistenciaFO int,
@motivo nvarchar(max)
as
insert into justificacion(idJustificacion,idAsistenciaFO,motivo,fechaJustificacion)
values (next value for sq_justificacion, @idAsistenciaFO, @motivo,GETDATE())
go

create proc spEditarJustificacion
@idJustificacion int,
@idAsistenciaFO int,
@motivo nvarchar(max)
as
update justificacion set idAsistenciaFO= @idAsistenciaFO, motivo=@motivo
where idJustificacion=@idJustificacion
go

create proc spExisteJustificacion
@idAsistenciaFo int
as
select idJustificacion
from justificacion
where idAsistenciaFO=@idAsistenciaFo
go

--create proc spBuscarJustificacion
--@fecha date
--as
--select top 100 idJustificacion, idAsistenciaFO, motivo,fechaJustificacion
--from justificacion
--where fechaJustificacion = @fecha
--order by fechaJustificacion asc
--go

--drop proc spBuscarJustificacion
---procs de seccion

create proc spInsertarSeccion
@seccion nvarchar(4)
as
insert into seccion(idSeccion,seccion)
values (next value for sq_seccion, @seccion)
go

create proc spEditarSeccion
@idSeccion int,
@seccion nvarchar(4)
as
update seccion set seccion= @seccion
where idSeccion=@idSeccion
go


create proc spBuscarSeccion
@textobuscar nvarchar
as
select top 100 idSeccion,seccion
from seccion
where seccion like '%' + @textobuscar + '%'
order by seccion asc
go


create proc spExisteSeccion
@Seccion nvarchar(20)
as
select seccion
from seccion
where seccion= @Seccion
go

create proc spCargarSecciones
as
begin
    select idSeccion, seccion
    from seccion
    order by seccion asc
end
go

create proc spEliminarSeccion
@idSeccion int
as
delete from seccion
where idSeccion = @idSeccion
go
--drop proc spEliminarSeccion
---------------------------------------------
---------------------------------------------
-----------PROCEDIMIENTO PARA FILTARLOS POR SECCION, asistencias y justificaciones
---------------------------------------------
----------------------------------------------------
---para no poner una casilla de asistencia o ausencia y estarle sumando a cada rato

--asistencia=a
--estudiantes=e
--seccion= s
create proc spFiltrarAsistenciasConteo
@idseccion int
as
select 
		e.idEstudiante,
		e.nombre,
		s.seccion,
		SUM(case when a.estado= 'P' then 1 else 0 end) as Presente,
		SUM(case when a.estado= 'A' then 1 else 0 end) as Ausente,
		SUM(case when a.estado= 'T' then 1 else 0 end) as Tardias,
		sum(case when a.estado= 'J' then 1 else 0 end) as Justificado
from estudiantes e
join asistencia a on e.idEstudiante = a.idEstudianteFO
join seccion s on e.idSeccionFO= s.idSeccion
where s.idSeccion = @idseccion
group by e.idEstudiante, e.nombre, s.seccion;
go

--drop proc spFiltrarAsistenciasConteo
create proc spFiltrarEstudiantePorSuSeccion
@idseccion int
as
select
	e.idEstudiante,
	e.IdCedula,
	e.nombre,
	e.apellidos,
	s.seccion
from estudiantes e
join seccion s on e.idSeccionFO= s.idSeccion
where s.idSeccion= @idseccion;
go

create proc spFiltrarJustificacionPorSeccion
@idseccion int
as
select 
	e.idEstudiante,
	a.idAsistencia,
	e.nombre,
	e.apellidos,
	a.estado,
	a.fecha
from estudiantes e
join asistencia a on e.idEstudiante = a.idEstudianteFO
join seccion s on e.idSeccionFO = s.idSeccion
where s.idSeccion= @idseccion
and a.estado in ('A', 'T');
go

create proc spBuscarJustificacionPorSeccionPorFecha
@idSeccion int,
@fecha date
as 
select 
	e.idEstudiante,
	a.idAsistencia,
	e.nombre,
	e.apellidos,
	a.estado,
	a.fecha
from estudiantes e
join asistencia a on e.idEstudiante = a.idEstudianteFO
join seccion s on e.idSeccionFO = s.idSeccion
where
    s.idSeccion = @idSeccion
    AND a.estado IN ('A', 'T')
	AND CAST(a.fecha AS DATE) = @fecha
order by e.nombre asc 
go
 
--go



--drop proc spExisteSeccion
--drop proc spBuscarSeccion
--drop proc spEditarSeccion


select * from seccion
select * from estudiantes
select * from asistencia
--drop table estudiantes
--drop table seccion


