USE [master]
GO
/****** Object:  Database [Farmacia]    Script Date: 10/10/2019 16:51:47 ******/
CREATE DATABASE [Farmacia] ON  PRIMARY 
( NAME = N'Farmacia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Farmacia.mdf' , SIZE = 12288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Farmacia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Farmacia_1.ldf' , SIZE = 112384KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Farmacia] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Farmacia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Farmacia] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Farmacia] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Farmacia] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Farmacia] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Farmacia] SET ARITHABORT OFF
GO
ALTER DATABASE [Farmacia] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Farmacia] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Farmacia] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Farmacia] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Farmacia] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Farmacia] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Farmacia] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Farmacia] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Farmacia] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Farmacia] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Farmacia] SET  DISABLE_BROKER
GO
ALTER DATABASE [Farmacia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Farmacia] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Farmacia] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Farmacia] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Farmacia] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Farmacia] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Farmacia] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Farmacia] SET  READ_WRITE
GO
ALTER DATABASE [Farmacia] SET RECOVERY FULL
GO
ALTER DATABASE [Farmacia] SET  MULTI_USER
GO
ALTER DATABASE [Farmacia] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Farmacia] SET DB_CHAINING OFF
GO
USE [Farmacia]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[ClientesxProductos]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[Facturas]    Script Date: 10/10/2019 16:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Facturas](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[Descripcion] [varchar](50) NULL,
	[PrecioUnitario] [float] NULL,
	[Numero] [int] NULL,
	[Fecha] [date] NULL,
	[Cantidad] [int] NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[CuentaCorrientes]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[CondicionesIva]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[ComprasDetalles]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[Compras]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[FacturasDetalles]    Script Date: 10/10/2019 16:51:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturasDetalles](
	[IdFacturaDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdFactura] [int] NULL,
	[IdProducto] [int] NULL,
	[PrecioUnitario] [int] NULL,
	[Cantidad] [int] NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_DetalleFactura] PRIMARY KEY CLUSTERED 
(
	[IdFacturaDetalle] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lotes]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[Productos]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[Proveedor]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[Rubros]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[SubRubros]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[Secciones]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[VentasLibres]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[VentasDetalles]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[Ventas]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  Table [dbo].[TipoFacturas]    Script Date: 10/10/2019 16:51:48 ******/
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
/****** Object:  StoredProcedure [dbo].[TipoFactura]    Script Date: 10/10/2019 16:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TipoFactura]
AS
SELECT *
from TipoFacturas
GO
/****** Object:  StoredProcedure [dbo].[SubRubrosModificar]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[SubRubrosEliminar]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[SubRubrosBuscarTodos]    Script Date: 10/10/2019 16:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SubRubrosBuscarTodos]
  as
  select S.IdSubRubro, S.SubRubro, R.Rubro, S.Activo
  from SubRubros S inner join Rubros R on S.IdRubro = R.IdRubro
GO
/****** Object:  StoredProcedure [dbo].[SubRubrosBuscarPorID_Rubro]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[SubRubrosBuscarPorID]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[SubRubrosAgregar]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[RubrosModificar]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[RubrosEliminar]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[RubrosBuscarTodos]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[RubrosBuscarPorID]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[RubrosAgregar]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[ProveedorModificar]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[ProveedorBuscarTodos]    Script Date: 10/10/2019 16:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProveedorBuscarTodos]
AS
SELECT *
from Proveedor
GO
/****** Object:  StoredProcedure [dbo].[ProveedorBuscarPorID]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[ProveedorAgregar]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[ProductossModificar]    Script Date: 10/10/2019 16:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ProductossModificar]
@IdProducto int ,
@Descripcion as varchar(50),
@Cantidad as integer,
@CodigoMSP integer,
@PrecioV as integer
as
update Productos
set Descripcion = @Descripcion,
Cantidad = @Cantidad,
CodigoMSP = @CodigoMSP,
PrecioVentaCliente = @PrecioV
where IdProducto = @IdProducto
GO
/****** Object:  StoredProcedure [dbo].[ProductossAgregar]    Script Date: 10/10/2019 16:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProductossAgregar]
@Descripcion as varchar(50),
@Cantidad as integer,
@CodigoMSP as integer,
@Precio as integer
as
insert into Productos  
(Descripcion,Cantidad,CodigoMSP,PrecioVentaCliente)
values
(@Descripcion,@Cantidad,@CodigoMSP,@Precio)
GO
/****** Object:  StoredProcedure [dbo].[ProductosBuscarTodos]    Script Date: 10/10/2019 16:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ProductosBuscarTodos]
AS
SELECT IdProducto, IdSubRubro, Descripcion, Cantidad, CodigoMSP, PrecioVentaCliente
from Productos
GO
/****** Object:  StoredProcedure [dbo].[ProductosBuscarPorTroquel]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[ProductosBuscarPorNombre]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[ProductosBuscarPorId]    Script Date: 10/10/2019 16:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProductosBuscarPorId]
@IdProducto int
as
select CodigoMSP,Descripcion,PrecioVentaCliente,IdProducto
from Productos
where IdProducto = @IdProducto
GO
/****** Object:  StoredProcedure [dbo].[ProductosBuscarID]    Script Date: 10/10/2019 16:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create procedure ProductosBuscarTodos
--AS
--SELECT IdProducto, IdSubRubro, Descripcion, Cantidad, CodigoMSP, PrecioVentaCliente
--from Productos

create procedure [dbo].[ProductosBuscarID]
@IdProducto int
as
select IdSubRubro, Descripcion, Cantidad, CodigoMSP, PrecioVentaCliente
from Productos
where IdProducto = @IdProducto
GO
/****** Object:  StoredProcedure [dbo].[ProductosAgregar]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[PoductosItemBuscaTodos]    Script Date: 10/10/2019 16:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PoductosItemBuscaTodos]
as
select IdProducto, Cantidad, Descripcion, PrecioVentaCliente
from Productos
GO
/****** Object:  StoredProcedure [dbo].[FiltrarDatosPI]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[FiltrarDatos]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[FacturasBuscar]    Script Date: 10/10/2019 16:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FacturasBuscar]
as
select * 
from facturas
GO
/****** Object:  StoredProcedure [dbo].[CompraClienteModificar]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[CondicionesIvabuscar]    Script Date: 10/10/2019 16:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CondicionesIvabuscar]
as
select * 
from CondicionesIva
GO
/****** Object:  StoredProcedure [dbo].[ClientesModificar]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[ClientesBuscarTodos]    Script Date: 10/10/2019 16:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ClientesBuscarTodos]
as
select Clientes.IdCliente,NombreCliente,ApellidoCliente,Direccion,Localidad,Telefono,Estados.Nombre
from Clientes join Estados on Clientes.IdEstado=Estados.IdEstado
GO
/****** Object:  StoredProcedure [dbo].[ClientesBuscarPorNombre]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[ClientesBuscarPorId]    Script Date: 10/10/2019 16:51:49 ******/
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
/****** Object:  StoredProcedure [dbo].[ClientesAgregar]    Script Date: 10/10/2019 16:51:49 ******/
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
