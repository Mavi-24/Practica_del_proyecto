

create table Tipos_empleado(
cod_tipo_empleado int identity(1,1),
descripcion varchar(20),
constraint pk_tipos_empleados primary key (cod_tipo_empleado)
)

create table Empleados(
legajo int identity(1,1),
nombre varchar(50),
cod_tipo_empleado int,
constraint pk_empleados primary key (legajo),
constraint fk_tipos_empleados foreign key (cod_tipo_empleado)
	references Tipos_empleado (cod_tipo_empleado)
)

create table Modelos(
cod_modelo int identity(1,1),
modelo varchar(20),
constraint pk_modelos primary key (cod_modelo)
)

CREATE TABLE Tipos_vehiculo(
cod_tipo_vehiculo int IDENTITY(1,1) NOT NULL,
descripcion varchar(20) NULL,
CONSTRAINT pk_tipos_vehiculos PRIMARY KEY (cod_tipo_vehiculo)
)

-------------------------- CREATE TIPOS_PRODUCTOS ----------------------------------------------

create table Tipos_producto(
cod_tipo_producto int identity(1,1),
descripcion varchar(75),
constraint pk_tipos_producto primary key(cod_tipo_producto)
)
-------------------------- CREATE PRODUCTOS ----------------------------------------------
create table Productos
(
cod_producto int identity(1,1),
descripcion varchar(50) null,
cod_tipo_producto int,
cod_modelo int,
cod_tipo_vehiculo int,
stock int,
precio money
constraint pk_producto primary key (cod_producto),
constraint fk_modelos foreign key (cod_modelo)
	references Modelos (cod_modelo),
constraint fk_tipos_vehiculo foreign key (cod_tipo_vehiculo)
	references Tipos_vehiculo (cod_tipo_vehiculo),
constraint fk_tipos_producto foreign key (cod_tipo_producto)
	references Tipos_producto (cod_tipo_producto)
)

create table Autoplanes(
cod_plan int identity(0,1),
nom_plan varchar(30),
cant_coutas int,
tasa_interes int,
constraint pk_planes primary key (cod_plan)
)

create table Tipos_cliente(
cod_tipo_cliente int identity(1,1),
descripcion varchar(25),
constraint pk_tipos_clientes primary key (cod_tipo_cliente)
)

create table Facturas(
cod_factura int identity(1,1),
cod_empleado int,
fecha date,
nom_cliente varchar(50),
cuit bigint,
cod_plan int,
cod_tipo_cliente int,
constraint pk_facturas primary key (cod_factura),
constraint fk_tipos_clientes foreign key (cod_tipo_cliente)
	references Tipos_cliente (cod_tipo_cliente),
constraint fk_planes foreign key (cod_plan)
	references Autoplanes (cod_plan),
constraint fk_empleados_factura foreign key (cod_empleado)
	references Empleados (legajo)
)

create table Detalles_factura(
cod_det_factura int identity(1,1),
cod_factura int,
cod_producto int,
cantidad int,
precio money,
constraint pk_detalles_facturas primary key (cod_det_factura),
constraint fk_facturas foreign key (cod_factura)
	references Facturas (cod_factura),
constraint fk_cod_producto foreign key (cod_producto)
	references Productos (cod_producto),

)

CREATE TABLE Usuarios(
id int IDENTITY(1,1) not null,
nombre varchar(50) not NULL,
usuario varchar(50) not null,
pass varchar(50) not NULL,
)

--------------------------- INSERT USUARIOS --------------------------------------------------
insert into Usuarios values  ('Analia', 'AnaliaRomulo', 'Ana123'),
							 ('Mariano', 'MarianoRojas', 'Mar456'),
							 ('Diego', 'admi','9876'),
							 ('Nico', 'admin','admin')

--------------------------- INSERT TIPOS_CLIENTES ---------------------------------------------
insert into Tipos_cliente (descripcion)
				   values ('Consumidor Final'),
			              ('Responsable Inscripto'),
			              ('Monotributista')

-------------------------- INSERT TIPOS_EMPLEADO ----------------------------------------------
insert into Tipos_empleado (descripcion)
                    values ('Vendedor'),
						   ('Técnico')

-------------------------- INSERT EMPLEADOS ---------------------------------------------------
insert into Empleados(nombre            ,cod_tipo_empleado)
               values('Leonardo Fuentes', 1),
                     ('Nicolas Garcia'  , 1),
				     ('Agustina Ojeda'  , 1),
                     ('Joaquin Moya'    , 2),
                     ('Sofia Villanueva', 2),
					 ('Diego Carrizo'   , 2),
					 ('Fernando Rosso'  , 2)

-------------------------- INSERT MODELOS ----------------------------------------------------
INSERT INTO Modelos (modelo)
			 VALUES ('Argo'),
					('Cronos'),
					('Uno'),
					('Fiorino'),
					('Ducato'),
					('Toro')


-------------------------- INSERT AUTOPLANES -------------------------------------------------
INSERT INTO autoplanes (nom_plan        , cant_coutas, tasa_interes)
				VALUES('Autoparte',0,0),
						('Tu Primer 0KM' , 24         , 15),
					   ('Plan Ahorro'   , 12         , 10),
					   ('Plan 50 Cuotas', 50         , 25),
					   ('Plan Automovil', 16         , 17)

-------------------------- INSERT TIPOS_VEHICULO ---------------------------------------------
insert into Tipos_vehiculo (descripcion)
					values ('Sedan'),
						   ('SUV'),
						   ('Coupe'),
						   ('Utilitario'),
						   ('Pick up'),
						   ('Van'),
						   ('Hatchback')


-------------------------- INSERT TIPOS_PRODUCTOS ----------------------------------------------
insert into Tipos_producto(descripcion)
                    values ('Autos'),
						   ('Autopartes')

-------------------------- INSERT PRODUCTOS ----------------------------------------------------



select * from Tipos_vehiculo

select * from Modelos


insert into Productos(cod_tipo_producto, cod_modelo, cod_tipo_vehiculo, stock, precio)
			values (1, 1, 7,200, 4934137),
				   (1, 2, 1,150,	4534165),
				   (1, 3, 7,400, 4804518),
				   (1, 4, 4,200,	4408912),
				   (1, 5, 6,150, 4173716),
				   (1, 6, 5,80,	4296281)

insert into Productos(cod_tipo_producto, descripcion	, cod_modelo, cod_tipo_vehiculo, stock, precio)
			 values (2                 ,'Puerta'		, 2			, 3, 1289, 19129),
				   (2					, 'Frenos'		,3			, 4, 325, 17861),
				   (2					, 'Correa'		,5			, 1, 1152, 17745),
				   (2					, 'Amortiguadores',2		, 5, 2231, 10862),
				   (2					, 'Lampara',1				, 4, 3241, 15332),
				   (2					, 'Bateria',6				, 5, 2251, 9327),
				   (2					, 'Bujias',3				, 2, 952, 10872),
				   (2					, 'Inyector',4				, 1, 823, 19313),
				   (2					, 'Limpiaparabrisa',5		, 7, 2352, 16654),
				   (2					, 'Cubierta',4				, 6, 2123, 11986)

-------------------------- INSERT AUTOMOVILES -----------------------------------------------
--insert into Automoviles (cod_modelo,cod_tipo_vehiculo,color,precio,fec_fabricacion)
--				values (	5	,	1	,'blanco',	4934137	,'2022-04-30'),
--					   (	1	,	2	,'rojo',	4534165	,'2022-08-12'),
--					   (	7	,	1	,'negro',	4804518	,'2022-10-11'),
--					   (	5	,	7	,'azul',	4408912	,'2022-05-16'),
--					   (	2	,	6	,'blanco',	4173716	,'2022-11-30'),
--					   (	7	,	1	,'gris',	4296281	,'2022-07-26')

-------------------------- INSERT FACTURAS --------------------------------------------------
insert into Facturas (cod_empleado,fecha,nom_cliente,cuit       ,  cod_plan,cod_tipo_cliente)
			values (	5	,'2022-05-24','Erick Rojas',	23483912043	,	3	   ,	1	),
					(	3	,'2022-10-19','Miguel Ramirez',	25776031906	,	4	   ,	1	),
					(	1	,'2022-08-17','Silvia Carrillo',	22602625065	,	3	   ,	3	),
					(	1	,'2022-06-06','Natalia Cabrera', 20295707565,	3	   ,	1	),
					(	3	,'2022-05-29','Jose Oliva', 24375348629   ,	0	,	3	),
					(	3	,'2022-01-22','Leandro Pavon',20622776951	,	0	,	1	),
					(	5	,'2022-07-06','Franco Montes',	24534263550	,	0	,	2	),
					(	2	,'2022-12-24','Alfredo Villalba',21784166754	,	0	,	1	)

select * from Productos
-------------------------- INSERT DETALLES FACTURA ------------------------------------------
--insert into Detalles_factura (cod_factura,patente ,nro_serie,cantidad,precio)
--					  values (	1		,	1004  ,	null	,	1	,	4160072	),
--							(	2		,	1000  ,	null	,	1	,	4684958	),
--							(	3		,	1004  ,	null	,	1	,	4333919	),
--							(	4		,	1004  ,	null	,	1	,	4980734	),
--							(	7		,	null  ,	9		,	1	,	17046	),
--							(	8		,	null  ,	4		,	2	,	18951	),
--							(	5		,	null  ,	3		,	3	,	16407	),
--							(	8		,	null  ,	10		,	3	,	7732	),
--							(	7		,	null  ,	2		,	3	,	13195	),
--							(	6		,	null  ,	1		,	2	,	18614	),
--							(	6		,	null  ,	5		,	3	,	12737	),
--							(	5		,	null  ,	6		,	3	,	15291	),
--							(	7		,	null  ,	7		,	3	,	13666	),
--							(	6		,	null  ,	8		,	2	,	9944	)
insert into Detalles_factura (cod_factura, cod_producto,cantidad,precio)
					  values(1,	1, 1, 4160072),
							(2,	2,	1,	4684958),
							(3,	5,	1,	4333919),
							(4,	6,	1,	4980734),
							(7,	4,	1,	17046),
							(8,	9,	2,	18951),
							(5,	10,	3,	11407),
							(8,	15,	3,	16754),
							(7,	14,	3,	20195),
							(6,	11,	2,	16614),
							(6,	7,	3,	21737),
							(5,	16,	3,	12291),
							(7,	8,	3, 18666),
							(6,	12,	2, 9944)

----------------------------------------------------------------------------------------------------------------------------------------
--		                  PROCEDIMIENTOS ALMACENADOS

create procedure pa_modelos
as
begin
	select * from Modelos
end

create procedure pa_tipos_vehiculos
as
begin
	select * from Tipos_vehiculo
end

create procedure pa_autopartes
as
begin
	select cod_producto, descripcion from Productos
	where cod_tipo_producto=2
end

create procedure pa_autoplanes
as
begin
	select cod_plan, nom_plan from Autoplanes
end

create procedure pa_automoviles
as
begin
	select cod_producto, m.modelo +' - '+ t.descripcion  'automovil'
	from Productos p
	join Tipos_vehiculo t on t.cod_tipo_vehiculo = p.cod_tipo_vehiculo
	join Modelos m on m.cod_modelo = p.cod_modelo
	join Tipos_producto tp on tp.cod_tipo_producto=p.cod_tipo_producto
	where tp.cod_tipo_producto=1
end

create procedure pa_clientes
as
begin
	select cod_factura, nom_cliente from Facturas
end

create procedure pa_login
@usuario varchar(100),
@pass varchar(100)
as
begin
   select top 1 count(*) from usuarios u
   where u.usuario = @usuario and u.pass = @pass
end

CREATE PROCEDURE SP_PROXIMO_ID
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(cod_factura)+1  FROM Facturas);
END

create procedure pa_empleados
as
begin
	select legajo, nombre from Empleados
end


--SP INSERTAR FACTURA

CREATE PROCEDURE SP_INSERTAR_FACTURA
	@cod_empleado int,
	@nom_cliente varchar(50),
	@cuit bigint = null,
	@cod_plan int = null,
	@cod_tipo_cliente int = null,
	@cod_factura int OUTPUT
AS
BEGIN
	INSERT INTO Facturas(cod_empleado, fecha, nom_cliente, cuit, cod_plan, cod_tipo_cliente)
    VALUES (@cod_empleado, GETDATE(), @nom_cliente, @cuit, @cod_plan, @cod_tipo_cliente);
    --Asignamos el valor del último ID autogenerado (obtenido --  
    --mediante la función SCOPE_IDENTITY() de SQLServer)	
    SET @cod_factura = SCOPE_IDENTITY();
END


--SP INSERTAR DETALLE

CREATE PROC SP_INSERTAR_DETALLE
	@cod_factura int,
	@cod_producto int,
	@cantidad int,
	@precio money
as
begin
	INSERT INTO Detalles_factura (cod_factura, cod_producto, cantidad, precio)
	VALUES (@cod_factura, @cod_producto, @cantidad, @precio)
end

create procedure pa_eliminar_factura
@cod int
as
begin
	delete from Detalles_factura where cod_factura = @cod
	delete from Facturas where cod_factura = @cod
end

create procedure pa_consultar_factura
@cod int
as
begin
	select cod_factura, cod_empleado, fecha, nom_cliente, cod_plan,cod_tipo_cliente
	from Facturas
	where cod_factura = @cod
end

create procedure pa_consultar_detalle
@cod int
as
begin
	select d.cod_producto,case p.cod_tipo_producto
		when 1 then(select m.modelo+' - '+tv.descripcion)
		else(select p.descripcion)end as descripcion, cantidad, d.precio
	from Detalles_factura d
	join Productos p on p.cod_producto = d.cod_producto
	join Modelos m on m.cod_modelo = p.cod_modelo
	join Tipos_vehiculo tv on tv.cod_tipo_vehiculo = p.cod_tipo_vehiculo
	where cod_factura = @cod
end


CREATE PROC SP_CONSULTAR_DESCRIPCION
@cod int,
@value varchar(50) output
as
begin
	set @value = (SELECT descripcion from Productos where cod_producto = @cod)
end

CREATE PROC SP_CONSULTAR_PRECIO
@cod int,
@value varchar(50) output
as
begin
	set @value = (SELECT precio from Productos where cod_producto = @cod)
end

CREATE PROC SP_CONSULTAR_MODELO
@cod int,
@value varchar(50) output
as
begin
	set @value = (SELECT m.modelo from Productos p join modelos m on m.cod_modelo = p.cod_modelo where cod_producto = @cod )
end


CREATE PROC SP_CONSULTAR_VEHICULO
@cod int,
@value varchar(50) output
as
begin
	set @value = (SELECT v.descripcion from Productos p join Tipos_vehiculo v on v.cod_tipo_vehiculo = p.cod_tipo_vehiculo where cod_producto = @cod)
end


CREATE PROC SP_INSERTAR_AUTOPARTE
	@descripcion varchar(50),
	@modelo int,
	@vehiculo int,
	@precio money
as
begin
	INSERT INTO Productos(descripcion, cod_tipo_producto, cod_modelo, cod_tipo_vehiculo, precio)
	VALUES (@descripcion, 2, @modelo, @vehiculo, @precio)
END


CREATE PROC SP_MODIFICAR_AUTOPARTE
@cod int,
@descripcion varchar(50),
@vehiculo int,
@modelo int,
@precio money
as
begin
	update Productos
	set descripcion = @descripcion, cod_modelo = @modelo, cod_tipo_vehiculo = @vehiculo, precio = @precio
	where cod_producto = @cod
end


CREATE PROC SP_INSERTAR_AUTOMOVIL
	@modelo varchar(50),
	@vehiculo int,
	@precio money,
	@aux int = NULL
as
begin
	INSERT INTO Modelos VALUES (@modelo)

	set @aux = (SELECT MAX(cod_modelo) from Modelos)

	INSERT INTO Productos(descripcion, cod_tipo_producto, cod_modelo, cod_tipo_vehiculo, precio)
	VALUES (NULL, 1, @aux, @vehiculo, @precio)
END


CREATE PROC SP_MODIFICAR_AUTOMOVIL
@cod int,
@vehiculo int,
@precio money
as
begin
	update Productos
	set cod_tipo_vehiculo = @vehiculo, precio = @precio
	where cod_producto = @cod
end


CREATE PROC SPA_CONSULTAR_MODELO
@cod int,
@value varchar(50) output
as
begin
	set @value = (SELECT m.modelo from Productos p join modelos m on p.cod_modelo = m.cod_modelo where cod_producto = @cod and p.cod_tipo_producto = 1)
end

CREATE PROC SPA_CONSULTAR_VEHICULO
@cod int,
@value varchar(50) output
as
begin
	set @value = (SELECT v.descripcion FROM Productos p join Tipos_vehiculo v on p.cod_tipo_vehiculo = v.cod_tipo_vehiculo where cod_producto = @cod)
end

CREATE PROC SPA_CONSULTAR_PRECIO
@cod int,
@value varchar(50) output
as
begin
	set @value = (SELECT precio from Productos where cod_producto = @cod)
end



CREATE PROCEDURE SP_PROXIMO_ID_PRODUCTO
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(cod_producto)+1  FROM Productos);
END

