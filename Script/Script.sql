-- ajustes del modelo para agregar cambios y algunas correcciones

-- agregar un campo de observaciones a la informacion del turista

alter table turista add observaciones varchar(200);

-- cambiar la clave del detalle de factura para que en la clave se incluya el nro de renglon
alter table det_factura_turista drop constraint pk_det_factura_turista;
alter table det_factura_turista add constraint pk_det_factura_turista primary key(nro_fact, serie_fact, letra_fact,nro_renglon);

-- tabla para tener parametrizada de los destinos
create table destino(codigo serial primary key, nombre varchar(120),descripcion varchar(250));
-- vinculacion del destino al paquete para tener un lugar donde visitar.
alter table paquete add cod_destino int;
alter table paquete add constraint fk_paquete_destino foreign key(cod_destino) references destino(codigo);

-- este ultimo campo esta pensado para lograr un resumen de los detinos mas visitados.

-- tabla de usuarios del sistema - clave en texto claro, mejoras de este esquema tener la clave encriptada con algun algoritmo y para verificar, generar 
-- la clave con el texto que se ingresa desde la interfaz visual.
create table usuarios(id serial primary key, usuario varchar(90), clave varchar(120), fecha_login time, es_admin boolean default(false));
-- los roles de sistema permiten diferenciar accesos a funciones, por ejemplo
-- rol de consulta no podria acceder a operaciones de actualizacion de informacion
-- rol de operador -- algunas operaciones pueden ser restringidas segun rol.
-- rol de administrador.
create table roles(codigo int primary key, nombre varchar(40));

create table usuario_roles(codigo serial primary key, cod_usuario int, cod_rol int);

/* Mapeo de los permisos del usuario*/
/* Gestion de permiso administrador en el sistema, posee acceso a cada item del menu.*/
--- 

create table funciones(codigo serial primary key, nombre varchar(90));

create table funciones_rol(codigo serial primary key, cod_funcion int, cod_rol int, puede boolean default(false));

-- usuarios que se pueden conectar

insert into usuarios(usuario, clave,es_admin)
values
('msantander', 'lenguaje',true), --1  -- administrador Full, no se verifican permisos pero por las dudas se asignan permisos---
('operador','operador',false), --2 
('admin', 'admin', false),		 --3
('consulta','consulta',false), 	 --4
('opAgencias','Agencias',false),--5
('opTuristas','Turistas',false),  --6
('opConsulta','consult',false);  --7

-- roles que pueden tomar los usuarios
insert into roles(codigo,nombre) values(1,'consulta'),(2,'operador'),(3,'responsable'), (4,'administrador'),(5,'operadorAgencias'),(6,'operadorTuristas'),(7,'operadorConsulta');

-- funciones del sistema para dar permisos de acceso

insert into funciones(nombre) 
values
('AltaTurista'),('ModificaTurista'),('ConsultaTurista'), -- 1,2,3
('AltaAgencia'),('ModificaAgencia'),('ConsultaAgencia'), --4,5,6
('AltaActividad'),('ModificaActividad'),('ConsultaActividad'), --7,8,9
('AltaPaquete'),('ModificaPaquete'),('ConsultaPaquete'),--10,11,12
('AltaTipoActividad'),('ModificaTipoActividad'),('ConsultaTipoActividad'), --13,14,15
('AltaTipoPaquete'),('ModificaTipoPaquete'),('ConsultaTipoPaquete'), -- 16,17,18
('AltaLocalidad'),('ModificaLocalidad'),('ConsultaLocalidad'), --19,20,21
('AltaFormaPago'),('ModificaFormaPago'),('ConsultaFormaPago'),--22,23,24
('Facturar'),('Listados'),('ConsultaAuditoria');--25,26,27

-- rol asignado a usuario
-- asignacion de roles a usuarios
/*
msantander -> administrador
operador -> operador
admin -> administrador
consulta -> consulta
opAgencias -> operadorAgencia
opTurista -> operadorTurista

*/
insert into usuario_roles(cod_usuario,cod_rol)values(1,4),(2,2),(3,4),(4,1),(5,5),(6,6),(7,7) ;

-- asignacion de funciones(todos) a rol administrador
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(1,4,true),(2,4,true),(3,4,true),(4,4,true),(5,4,true),(6,4,true),(7,4,true),(8,4,true),(9,4,true),(10,4,true),(11,4,true),(12,4,true),
(13,4,true),(14,4,true),(15,4,true),(16,4,true),(17,4,true),(18,4,true),(19,4,true),(20,4,true),(21,4,true),(22,4,true),(23,4,true),(24,4,true),(25,4,true),(26,4,true),(27,4,true);

-- asignacion de permisos a consulta --  todas funciones de consulta y listado
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(3,1,true),(6,1,true),(9,1,true),(12,1,true),(15,1,true),(18,1,true),(21,1,true),(26,1,true);

-- asignacion de permisos a operadorAgencia --  todas funciones de Agencias, listado y estadisticas
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(4,5,true),(5,5,true),(6,5,true),(26,5,true);

-- asignacion de permisos a operadorTurista --  todas funciones de Turistas, listado y estadisticas
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(1,6,true),(2,6,true),(3,6,true),(26,6,true);

-- permisos para operador
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(2,2,true),(3,2,true),(5,2,true),(6,2,true),(8,2,true),(9,2,true),(11,2,true),(12,2,true),(14,2,true),(17,2,true),(20,2,true),(21,2,true),(24,2,true),(25,2,true),(26,2,true);

-- permisos para operadorConsulta
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(3,7,true),(6,7,true),(7,7,true),(8,7,true),(9,7,true),(12,7,true),(18,7,true),(21,7,true),(22,7,true),(23,7,true),(24,7,true),(26,7,true);

--- tabla de auditoria.
create table logger(id serial primary key, usuario varchar(90), objeto varchar(90), fecha timestamp, operacion varchar(80), detalle varchar(8000));
