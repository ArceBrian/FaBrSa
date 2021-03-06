USE [Farmacia]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 11/14/2019 11:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[NombreCliente] [varchar](50) NULL,
	[ApellidoCliente] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Localidad] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[IdEstado] [int] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ClientesxProductos]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientesxProductos](
	[IdClientexProducto] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[IdProducto] [int] NULL,
 CONSTRAINT [PK_ClientesxProductos] PRIMARY KEY CLUSTERED 
(
	[IdClientexProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CondicionesIva]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CondicionesIva](
	[IdIva] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_CondicionesIva] PRIMARY KEY CLUSTERED 
(
	[IdIva] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ComprasDetalles]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprasDetalles](
	[IdCompraDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdCompra] [int] NULL,
	[Cantidad] [float] NULL,
	[Precio] [money] NULL,
	[IdProducto] [int] NULL,
	[Total] [money] NULL,
 CONSTRAINT [PK_ComprasDetalles] PRIMARY KEY CLUSTERED 
(
	[IdCompraDetalle] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdProveedor] [int] NULL,
	[Fecha] [date] NULL,
	[NumeroComprobante] [float] NULL,
	[Total] [money] NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Facturas](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[Letra] [varchar](50) NULL,
	[PuntoVenta] [int] NULL,
	[Numero] [int] NULL,
	[Fecha] [date] NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estados](
	[IdEstado] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CuentaCorrientes]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CuentaCorrientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NULL,
	[NombreCliente] [varchar](50) NULL,
	[Precio] [float] NULL,
	[Cantidad] [float] NULL,
	[Fecha] [date] NULL,
	[Total] [float] NULL,
	[Descuento] [float] NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_CuentaCorrientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lotes]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lotes](
	[IdLote] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NULL,
	[FechaVencimiento] [date] NULL,
	[FechaIngreso] [date] NULL,
	[Cantidad] [float] NULL,
 CONSTRAINT [PK_Lotes] PRIMARY KEY CLUSTERED 
(
	[IdLote] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InicioSecion]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InicioSecion](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[login] [varchar](50) NULL,
	[pasword] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_InicioSecion] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[CodigoMSP] [int] NULL,
	[Descripcion] [varchar](50) NULL,
	[IdSeccion] [int] NULL,
	[Seccion] [varchar](50) NULL,
	[Venta] [int] NULL,
	[TipoCodBarra1] [varchar](50) NULL,
	[CodigoBarra1] [varchar](50) NULL,
	[TipoCodBarra2] [varchar](50) NULL,
	[CodigoBarra2] [varchar](50) NULL,
	[TipoCodBarra3] [varchar](50) NULL,
	[CodigoBarra3] [varchar](50) NULL,
	[TipoCodBarra4] [varchar](50) NULL,
	[CodigoBarra4] [varchar](50) NULL,
	[PrecioVentaCliente] [float] NULL,
	[PrecioSugerido] [float] NULL,
	[CodigoLaboratorio] [float] NULL,
	[Laboratorio] [varchar](50) NULL,
	[CuitLaboratorio] [float] NULL,
	[IdSubRubro] [float] NULL,
	[Cantidad] [float] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Compañia] [varchar](50) NULL,
	[Localidad] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Cargo] [varchar](50) NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rubros]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rubros](
	[IdRubro] [int] IDENTITY(1,1) NOT NULL,
	[Rubro] [varchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Rubros] PRIMARY KEY CLUSTERED 
(
	[IdRubro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SubRubros]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubRubros](
	[IdSubRubro] [int] IDENTITY(1,1) NOT NULL,
	[IdRubro] [int] NULL,
	[SubRubro] [varchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_SubRubros] PRIMARY KEY CLUSTERED 
(
	[IdSubRubro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Secciones]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Secciones](
	[IdSeccion] [int] IDENTITY(1,1) NOT NULL,
	[Seccion] [varchar](50) NULL,
 CONSTRAINT [PK_Secciones] PRIMARY KEY CLUSTERED 
(
	[IdSeccion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoFacturas]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoFacturas](
	[IdTipoFactura] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TipoFacturas] PRIMARY KEY CLUSTERED 
(
	[IdTipoFactura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FacturasDetalles]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturasDetalles](
	[IdFacturaDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdFactura] [int] NULL,
	[IdProducto] [int] NULL,
	[Cantidad] [int] NULL,
	[PrecioUnitario] [money] NULL,
	[Total] [money] NULL,
 CONSTRAINT [PK_DetalleFactura] PRIMARY KEY CLUSTERED 
(
	[IdFacturaDetalle] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentasLibres]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VentasLibres](
	[IdVenta] [int] NOT NULL,
	[Venta] [varchar](50) NULL,
 CONSTRAINT [PK_VentasLibres] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VentasDetalles]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentasDetalles](
	[IdDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdVenta] [int] NULL,
	[Cantidad] [float] NULL,
	[Precio] [money] NULL,
	[IdProducto] [int] NULL,
	[Total] [money] NULL,
 CONSTRAINT [PK_DetallesVentas] PRIMARY KEY CLUSTERED 
(
	[IdDetalleVenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 11/14/2019 11:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[FechaFactura] [date] NULL,
	[NumeroComprobante] [float] NULL,
	[Total] [money] NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Usuarios_BuscarPorLoginPass]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuarios_BuscarPorLoginPass]
@Login varchar(50),
@Password varchar(50)
AS
SELECT *
FROM InicioSecion
WHERE nombre=rtrim(@Login) and pasword= rtrim(@Password)
and Activo=1
GO
/****** Object:  StoredProcedure [dbo].[Usuarios_BuscarPorID_Usuario]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuarios_BuscarPorID_Usuario]
@ID_Usuario int
AS
SELECT *
FROM InicioSecion
WHERE IDUsuario=@ID_Usuario
GO
/****** Object:  StoredProcedure [dbo].[FacturasBuscarTodos]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FacturasBuscarTodos]
as
select IdFacturaDetalle,
IdFactura,
IdProducto,
Cantidad,
PrecioUnitario,
Total
from FacturasDetalles
GO
/****** Object:  StoredProcedure [dbo].[FacturasBuscarPorId]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FacturasBuscarPorId]
@IdFactura int
as
select IdFacturaDetalle,
IdFactura,
Descripcion,
F.Cantidad,
PrecioUnitario,
Total
from FacturasDetalles F inner join Productos P on F.IdProducto = P.IdProducto
--from Facturas F inner join FacturasDetalles D on F.IdFactura = D.IdFactura
where IdFactura = @IdFactura
GO
/****** Object:  StoredProcedure [dbo].[FacturasBuscar]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FacturasBuscar]
as
select * 
from facturas
GO
/****** Object:  StoredProcedure [dbo].[TipoFactura]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TipoFactura]
AS
SELECT *
from TipoFacturas
GO
/****** Object:  StoredProcedure [dbo].[SubRubrosModificar]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SubRubrosModificar]
@IdSubRubro int,
@IdRubro int,
@SubRubro varchar (50),
@Activo bit
as
update SubRubros
set IdRubro= @IdRubro, SubRubro = @SubRubro, Activo = @Activo
where IdSubRubro = @IdSubRubro
GO
/****** Object:  StoredProcedure [dbo].[SubRubrosEliminar]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SubRubrosEliminar]
@IdSubRubro int
as
delete SubRubros
where IdSubRubro = @IdSubRubro
GO
/****** Object:  StoredProcedure [dbo].[SubRubrosBuscarTodos]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SubRubrosBuscarTodos]
  as
  select S.IdSubRubro, S.SubRubro, R.Rubro, S.Activo
  from SubRubros S inner join Rubros R on S.IdRubro = R.IdRubro
GO
/****** Object:  StoredProcedure [dbo].[SubRubrosBuscarPorID_Rubro]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SubRubrosBuscarPorID_Rubro]
@IdRubro int
as
select s.IdRubro
from SubRubros S inner join Rubros R on S.IdRubro = R.IdRubro
where S.IdRubro = @IdRubro
GO
/****** Object:  StoredProcedure [dbo].[SubRubrosBuscarPorID]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SubRubrosBuscarPorID]
@IdSubRubro int
as
select *
from SubRubros
where IdSubRubro = @IdSubRubro
GO
/****** Object:  StoredProcedure [dbo].[SubRubrosAgregar]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SubRubrosAgregar]
@IdRubro int,
@SubRubro varchar(50),
@Activo bit
as
insert into SubRubros  
values (@IdRubro, @SubRubro,@Activo)
GO
/****** Object:  StoredProcedure [dbo].[RubrosModificar]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RubrosModificar]
@IdRubro int,
@Rubro varchar (50),
@Activo bit
as
update Rubros
set Rubro = @Rubro, Activo = @Activo
where IdRubro = @IdRubro
GO
/****** Object:  StoredProcedure [dbo].[RubrosEliminar]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RubrosEliminar]
@IdRubro int
as
delete Rubros
where IdRubro = @IdRubro
GO
/****** Object:  StoredProcedure [dbo].[RubrosBuscarTodos]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RubrosBuscarTodos]
  as
  select *
  from
  Rubros
GO
/****** Object:  StoredProcedure [dbo].[RubrosBuscarPorID]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RubrosBuscarPorID]
@IdRubro int
as
select *
from Rubros
where IdRubro = @IdRubro
GO
/****** Object:  StoredProcedure [dbo].[RubrosAgregar]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RubrosAgregar]
@Rubro varchar(50),
@Activo bit
as
insert into Rubros  
values (@Rubro,@Activo)
GO
/****** Object:  StoredProcedure [dbo].[ProveedorModificar]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ProveedorModificar]
@IdProveedor int ,
@Nombre as varchar(50),
@Compañoa as varchar(50),
@Localidad as varchar(50),
@Direccion as varchar(50),
@Cargo as varchar(50)
as
update Proveedor
set Nombre = @Nombre,
Compañia = @Compañoa,
Localidad = @Localidad,
Direccion = @Direccion,
Cargo = @Cargo
where IdProveedor = @IdProveedor
GO
/****** Object:  StoredProcedure [dbo].[ProveedorBuscarTodos]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProveedorBuscarTodos]
AS
SELECT *
from Proveedor
GO
/****** Object:  StoredProcedure [dbo].[ProveedorBuscarPorID]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProveedorBuscarPorID]
@IdProveedor int
as
select IdProveedor, Nombre,Compañia,Localidad,Direccion,Cargo
from Proveedor
where IdProveedor = @IdProveedor
GO
/****** Object:  StoredProcedure [dbo].[ProveedorAgregar]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ProveedorAgregar]
@Nombre as varchar(50),
@Compañia as varchar (50),
@Localidad as varchar(50),
@Direccion as varchar(50),
@Cargo as varchar(50)
as
insert into Proveedor  
(Nombre,Compañia,Localidad,Direccion,Cargo)
values
(@Nombre,@Compañia,@Localidad,@Direccion,@Cargo)
GO
/****** Object:  StoredProcedure [dbo].[ProductossModificar]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProductossModificar]
@IdProducto int, @CodigoMSP as int, @Descripcion as varchar(50), @IdSeccion as int, @Seccion as varchar(50), @Venta as int, @TipoCodBarra1 as varchar(50), @CodigoBarra1 as varchar(50), @TipoCodBarra2 as varchar(50), @CodigoBarra2 as varchar(50), @TipoCodBarra3 as varchar(50), @CodigoBarra3 as varchar(50), @TipoCodBarra4 as varchar(50), @CodigoBarra4 as varchar(50), @PrecioVentaCliente as float, @PrecioSugerido as float, @CodigoLaboratorio as float, @Laboratorio as varchar(50), @CuitLaboratorio as float, @IdSubRubro as float, @Cantidad as float
as
update Productos
set CodigoMSP = @CodigoMSP, Descripcion = @Descripcion, IdSeccion = @IdSeccion, Seccion = @Seccion, Venta = @Venta, TipoCodBarra1 = @TipoCodBarra1, CodigoBarra1 = @CodigoBarra1, TipoCodBarra2 = @TipoCodBarra2, CodigoBarra2 = @CodigoBarra2, TipoCodBarra3 = @TipoCodBarra3, CodigoBarra3 = @CodigoBarra3, TipoCodBarra4 = @TipoCodBarra4, CodigoBarra4 = @CodigoBarra4, PrecioVentaCliente = @PrecioVentaCliente, PrecioSugerido = @PrecioSugerido, CodigoLaboratorio = @CodigoLaboratorio, Laboratorio = @Laboratorio, CuitLaboratorio = @CuitLaboratorio, IdSubRubro = @IdSubRubro, Cantidad = @Cantidad
where IdProducto = @IdProducto
GO
/****** Object:  StoredProcedure [dbo].[ProductossAgregar]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProductossAgregar]
@CodigoMSP as integer, @Descripcion as varchar(50), @IdSeccion as integer, @Seccion as varchar(50), @Venta as integer, @TipoCodBarra1 as varchar(50), @CodigoBarra1 as varchar(50), @TipoCodBarra2 as varchar(50), @CodigoBarra2 as varchar(50), @TipoCodBarra3 as varchar(50), @CodigoBarra3 as varchar(50), @TipoCodBarra4 as varchar(50), @CodigoBarra4 as varchar(50), @PrecioVentaCliente as float, @PrecioSugerido as float, @CodigoLaboratorio as float, @Laboratorio as varchar(50), @CuitLaboratorio as float, @IdSubRubro as float, @Cantidad as integer
as
insert into Productos  
(CodigoMSP, Descripcion, IdSeccion, Seccion, Venta, TipoCodBarra1, CodigoBarra1, TipoCodBarra2, CodigoBarra2, TipoCodBarra3, CodigoBarra3, TipoCodBarra4, CodigoBarra4, PrecioVentaCliente, PrecioSugerido, CodigoLaboratorio, Laboratorio, CuitLaboratorio, IdSubRubro, Cantidad)
values
(@CodigoMSP, @Descripcion, @IdSeccion, @Seccion, @Venta, @TipoCodBarra1, @CodigoBarra1, @TipoCodBarra2, @CodigoBarra2, @TipoCodBarra3, @CodigoBarra3, @TipoCodBarra4, @CodigoBarra4, @PrecioVentaCliente, @PrecioSugerido, @CodigoLaboratorio, @Laboratorio, @CuitLaboratorio, @IdSubRubro, @Cantidad)
GO
/****** Object:  StoredProcedure [dbo].[ProductosBuscarTodos]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProductosBuscarTodos]
AS
SELECT *
from Productos
GO
/****** Object:  StoredProcedure [dbo].[ProductosBuscarPorTroquel]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProductosBuscarPorTroquel]
@CodigoMSP integer
as
select IdProducto,Descripcion, PrecioVentaCliente
from Productos
where CodigoMSP = @CodigoMSP
GO
/****** Object:  StoredProcedure [dbo].[ProductosBuscarPorNombre]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ProductosBuscarPorNombre]
@Descripcion varchar(50)
as
select IdProducto, PrecioVentaCliente
from Productos
where Descripcion = @Descripcion
GO
/****** Object:  StoredProcedure [dbo].[ProductosBuscarPorId]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProductosBuscarPorId]
@IdProducto int
as
select IdProducto, CodigoMSP, Descripcion, IdSeccion, Seccion, Venta, TipoCodBarra1, CodigoBarra1, TipoCodBarra2, CodigoBarra2, TipoCodBarra3, CodigoBarra3, TipoCodBarra4, CodigoBarra4, PrecioVentaCliente, PrecioSugerido, CodigoLaboratorio, Laboratorio, CuitLaboratorio, IdSubRubro, Cantidad
from Productos
where IdProducto = @IdProducto
GO
/****** Object:  StoredProcedure [dbo].[ProductosBuscarID]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure ProductosBuscarTodos
--AS
--SELECT IdProducto, IdSubRubro, Descripcion, Cantidad, CodigoMSP, PrecioVentaCliente
--from Productos

CREATE procedure [dbo].[ProductosBuscarID]
@IdProducto int
as
select CodigoMSP, Descripcion, IdSeccion, Seccion, Venta, TipoCodBarra1, CodigoBarra1, TipoCodBarra2, CodigoBarra2, TipoCodBarra3, CodigoBarra3, TipoCodBarra4, CodigoBarra4, PrecioVentaCliente, PrecioSugerido, CodigoLaboratorio, Laboratorio, CuitLaboratorio, IdSubRubro, Cantidad
from Productos
where IdProducto = @IdProducto
GO
/****** Object:  StoredProcedure [dbo].[ProductosAgregar]    Script Date: 11/14/2019 11:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProductosAgregar]
@NombreCliente as varchar(50),
@Producto as varchar (50),
@Cantidad as varchar(50),
@Fecha as date,
@Total as integer
as
insert into CuentaCorrientes  
(NombreCliente,Descripcion,Cantidad,Fecha,Total)
values
(@NombreCliente,@Producto,@Cantidad,@Fecha,@Total)
GO
/****** Object:  StoredProcedure [dbo].[Productos_SumarStock]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Productos_SumarStock]
@IDproducto int,
@Cantidad int
as 
update productos
set cantidad=cantidad +  @Cantidad
where idproducto=@IDproducto
GO
/****** Object:  StoredProcedure [dbo].[Productos_RestarStock]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Productos_RestarStock]
@IDproducto int,
@Cantidad int
as 
update productos
set cantidad=cantidad -  @Cantidad
where idproducto=@IDproducto
GO
/****** Object:  StoredProcedure [dbo].[PoductosItemBuscaTodos]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PoductosItemBuscaTodos]
as
select IdProducto, Cantidad, Descripcion, PrecioVentaCliente
from Productos
GO
/****** Object:  StoredProcedure [dbo].[NumeroComprobante]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[NumeroComprobante]
as
select MAX (IdFactura) + 1 IdFactura
from Facturas
GO
/****** Object:  StoredProcedure [dbo].[FiltrarDatosPI]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FiltrarDatosPI]
@Descripcion varchar(50)
as
select IdProducto, Cantidad, Descripcion, PrecioVentaCliente
from Productos
where Descripcion like '%' + @Descripcion + '%'
GO
/****** Object:  StoredProcedure [dbo].[FiltrarDatosClientes]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FiltrarDatosClientes]
@NombreCliente varchar(50)
as
select IdCliente,NombreCliente,ApellidoCliente,Direccion,Localidad,Telefono,IdEstado
from Clientes
where NombreCliente like '%' + @NombreCliente + '%'
GO
/****** Object:  StoredProcedure [dbo].[FiltrarDatos]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FiltrarDatos]
@NombreCliente varchar(50)
as
select IdCliente,NombreCliente,ApellidoCliente,Direccion,Localidad,Telefono,IdEstado
from Clientes
where NombreCliente like '%' + @NombreCliente + '%'
GO
/****** Object:  StoredProcedure [dbo].[FacturasFiltrarDatos]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FacturasFiltrarDatos]
@NombreCliente varchar(50)
as
select IdFactura,NombreCliente,Letra,PuntoVenta,Numero,Fecha,Total
from Facturas F inner join Clientes C on F.IdCliente = C.IdCliente
where NombreCliente like '%' + @NombreCliente + '%'
GO
/****** Object:  StoredProcedure [dbo].[CondicionesIvabuscar]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CondicionesIvabuscar]
as
select * 
from CondicionesIva
GO
/****** Object:  StoredProcedure [dbo].[CompraClienteModificar]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CompraClienteModificar]
@IDClientes int ,
@NombreCliente as varchar(50),
@Descripcion as varchar(50),
@Cantidad as integer,
@Fecha as date
as
update CuentaCorrientes
set NombreCliente = @NombreCliente,
@Descripcion = @Descripcion,
Cantidad = @Cantidad,
Fecha = @Fecha
where IDCliente=@IDClientes
GO
/****** Object:  StoredProcedure [dbo].[ClietnesItemBuscaTodos]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ClietnesItemBuscaTodos]
as
select IdCliente,NombreCliente,ApellidoCliente,Direccion,Localidad,Telefono,IdEstado
from Clientes
GO
/****** Object:  StoredProcedure [dbo].[ClientesModificar]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ClientesModificar]
@IDClientes int ,
@Nombre varchar(50),
@Apellido varchar(50),
@Direccion varchar(50),
@Localidad varchar(50),
@Telefono varchar(50),
@IdEstado Integer
as
update Clientes
set NombreCliente=@Nombre,
ApellidoCliente=@Apellido,
Direccion=@Direccion,
Localidad=@Localidad,
Telefono=@Telefono,
IdEstado=@IdEstado
where IDCliente=@IDClientes
GO
/****** Object:  StoredProcedure [dbo].[ClientesBuscarTodos]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ClientesBuscarTodos]
as
select Clientes.IdCliente,NombreCliente,ApellidoCliente,Direccion,Localidad,Telefono,Estados.Nombre
from Clientes join Estados on Clientes.IdEstado=Estados.IdEstado
GO
/****** Object:  StoredProcedure [dbo].[ClientesBuscarPorNombre]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ClientesBuscarPorNombre]
@Nombre varchar(50)
as
select IdCliente, NombreCliente, ApellidoCliente, Direccion, Localidad, Telefono, IdEstado
from Clientes
where NombreCliente = @Nombre
GO
/****** Object:  StoredProcedure [dbo].[ClientesBuscarPorId]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ClientesBuscarPorId]
@IdCliente int
as
select IdCliente, NombreCliente,ApellidoCliente,Direccion,Localidad,Telefono,IdEstado
from Clientes
where IdCliente = @IdCliente
GO
/****** Object:  StoredProcedure [dbo].[ClientesAgregar]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ClientesAgregar]
@NombreCliente as varchar (50),
@ApellidoCliente as varchar(50),
@Direccion as varchar(50),
@Localidad as varchar(50),
@Telefono as varchar(50),
@IdEstado as int
as
insert into Clientes 
(NombreCliente,ApellidoCliente,Direccion,Localidad,Telefono,IdEstado)
values
(@NombreCliente,@ApellidoCliente,@Direccion,@Localidad,@Telefono,@IdEstado)
GO
/****** Object:  StoredProcedure [dbo].[AgregarFacturaDetalle]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AgregarFacturaDetalle]
@IdFactura as integer,
@IdProducto as integer,

@Cantidad as integer,
@PrecioUnitario as money,
@Total as money
as
insert into FacturasDetalles 
(IdFactura,IdProducto,Cantidad,PrecioUnitario,Total)
values
(@IdFactura,@IdProducto,@Cantidad,@PrecioUnitario,@Total)
GO
/****** Object:  StoredProcedure [dbo].[AgregarFactura]    Script Date: 11/14/2019 11:00:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AgregarFactura]
@Letra as varchar(50),
@PuntoVenta as integer,
@Numero as integer,
@IdCliente as integer,
@Fecha as date,
@Total as money
as
insert into Facturas
(Letra,PuntoVenta,Numero,IdCliente,Fecha,total)
values
(@Letra,@PuntoVenta,@Numero,@IdCliente,@Fecha,@Total)
select @@identity
GO
