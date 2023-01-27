Create database ACTIVIDAD_CEDIS; 

Use ACTIVIDAD_CEDIS;


-----------------[Tablas]---------------------

Create Table CATALOGO(
Codigo int PRIMARY KEY,
Descripcion Varchar(60),
Proveedor int, 
Activo int); 


Select * from CATALOGO; 

Create Table PROVEEDORES(
ID_PROVEEDOR int PRIMARY KEY,
NOMBRE Varchar(60)); 

Select * from PROVEEDORES; 



Insert into CATALOGO(Codigo, Descripcion,Proveedor, Activo)
Values (1, 'Algo',1, 1);


-------------[Procedimientos Almacenados]-------------


--###[Insertar a CATALOGO]
Create Proc SP_INSERTAR_ARTICULO(
@Codigo int,
@Descripcion Varchar(60),
@Proveedor int,
@Activo int
)
as
Insert into CATALOGO(Codigo, Descripcion,Proveedor, Activo)
Values (@Codigo, @Descripcion,@Proveedor, @Activo);


--###[Seleccionar todo el CATALOGO]
Create Proc SP_SELECT_ALL_CATALOGO
as
Select * from CATALOGO;

--###[Seleccionar solo Activos del CATALOGO]
Create Proc SP_SELECT_ACTIVO_CATALOGO
as
Select * from CATALOGO WHERE Activo=1;


--###[Seleccionar Codigo Unico del CATALOGO]
Create Proc SP_SELECT_CODIGO_CATALOGO(@Codigo int)
as
Select * from CATALOGO WHERE Codigo=@Codigo;

--###[Seleccionar todos los proveedores]
Create Proc SP_SELECT_ALL_PROVEEDORES
as
Select * from PROVEEDORES;


--###[Borrar registro del Catalogo con el parametro de Codigo Unico]
Create Proc SP_DELETE_ONE_CATALOGO(@Codigo int)
as
Delete from CATALOGO WHERE Codigo=@Codigo;


--###[Modificar un registro del Catalogo]
Create Proc SP_UPDATE_ONE_CATALOGO(
@Codigo int,
@Descripcion Varchar(60),
@Proveedor int,
@Activo int
)
as
Update CATALOGO Set
Codigo=@Codigo,
Descripcion=@Descripcion,
Proveedor=@Proveedor,
Activo=@Activo
where Codigo=@Codigo;

--Delete from CATALOGO WHERE Codigo=15;
