USE [master]
GO
/****** Object:  Database [REFACCIONARIA]    Script Date: 07/07/2021 07:37:09 p. m. ******/
CREATE DATABASE [REFACCIONARIA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'REFACCIONARIA', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\REFACCIONARIA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'REFACCIONARIA_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\REFACCIONARIA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [REFACCIONARIA] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [REFACCIONARIA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [REFACCIONARIA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET ARITHABORT OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [REFACCIONARIA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [REFACCIONARIA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [REFACCIONARIA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [REFACCIONARIA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET RECOVERY FULL 
GO
ALTER DATABASE [REFACCIONARIA] SET  MULTI_USER 
GO
ALTER DATABASE [REFACCIONARIA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [REFACCIONARIA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [REFACCIONARIA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [REFACCIONARIA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [REFACCIONARIA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [REFACCIONARIA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'REFACCIONARIA', N'ON'
GO
ALTER DATABASE [REFACCIONARIA] SET QUERY_STORE = OFF
GO
USE [REFACCIONARIA]
GO
/****** Object:  User [Usuario1]    Script Date: 07/07/2021 07:37:09 p. m. ******/
CREATE USER [Usuario1] FOR LOGIN [Usuario1] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Usuario1]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Usuario1]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nomCliente] [varchar](20) NOT NULL,
	[apPaterno] [varchar](20) NOT NULL,
	[apMaterno] [varchar](20) NOT NULL,
	[telCliente] [varchar](10) NOT NULL,
	[Descuentos] [int] NOT NULL,
	[compraTotal] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMPRAS]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPRAS](
	[idCompras] [int] IDENTITY(1,1) NOT NULL,
	[nomCompra] [varchar](100) NOT NULL,
	[precioCom] [int] NOT NULL,
	[numProCom] [int] NOT NULL,
	[fechaCompra] [date] NOT NULL,
	[totalCompra] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[idProveedor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCompras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIRECCIÓN]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIRECCIÓN](
	[idDireccion] [int] IDENTITY(1,1) NOT NULL,
	[numExt] [int] NOT NULL,
	[numInt] [int] NOT NULL,
	[Calle] [varchar](20) NOT NULL,
	[Municipio] [varchar](20) NOT NULL,
	[CP] [varchar](10) NOT NULL,
	[Estado] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDireccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADOS]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADOS](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[nomEmpleado] [varchar](20) NOT NULL,
	[apPaterno] [varchar](20) NOT NULL,
	[apMaterno] [varchar](20) NOT NULL,
	[CURP] [varchar](18) NOT NULL,
	[telEmpleado] [varchar](10) NOT NULL,
	[idLogin] [int] NOT NULL,
	[idDireccion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOGIN]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOGIN](
	[idLogin] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](10) NOT NULL,
	[Contraseña] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idLogin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MODULO]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MODULO](
	[idModulo] [int] IDENTITY(1,1) NOT NULL,
	[nomModulo] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OPERACION]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OPERACION](
	[idOperacion] [int] IDENTITY(1,1) NOT NULL,
	[nomOperacion] [varchar](100) NOT NULL,
	[idModulo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idOperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PREFIL_OPERACION]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PREFIL_OPERACION](
	[idRol] [int] NOT NULL,
	[idOperacion] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTOS]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTOS](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Precio] [int] NOT NULL,
	[Stock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVEEDOR]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDOR](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[razonSocial] [varchar](20) NOT NULL,
	[telProveedor] [varchar](10) NOT NULL,
	[idDireccion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[REPORTE_COMPRAS]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REPORTE_COMPRAS](
	[idReCompras] [int] IDENTITY(1,1) NOT NULL,
	[idCompras] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idReCompras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[REPORTE_PAGOS]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REPORTE_PAGOS](
	[idRePagos] [int] IDENTITY(1,1) NOT NULL,
	[idCompras] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idRePagos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[REPORTE_VENTAS]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REPORTE_VENTAS](
	[idReVentas] [int] IDENTITY(1,1) NOT NULL,
	[precioVenta] [int] NOT NULL,
	[canVentas] [int] NOT NULL,
	[totalVentas] [int] NOT NULL,
	[idVenta] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idReVentas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROL]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROL](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[nombreRol] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](100) NOT NULL,
	[Contraseña] [varchar](200) NOT NULL,
	[idRol] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENTA_AUDITADA]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENTA_AUDITADA](
	[idVenAuditada] [int] IDENTITY(1,1) NOT NULL,
	[Operacion] [varchar](100) NULL,
	[Usuario] [varchar](100) NULL,
	[Host] [varchar](100) NULL,
	[Modificado] [datetime] NULL,
	[Tabla] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idVenAuditada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENTAS]    Script Date: 07/07/2021 07:37:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENTAS](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[PrecioVen] [int] NOT NULL,
	[numProVen] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[precioTotal] [int] NOT NULL,
	[pagaCon] [int] NOT NULL,
	[Cambio] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CLIENTES] ON 
GO
INSERT [dbo].[CLIENTES] ([idCliente], [nomCliente], [apPaterno], [apMaterno], [telCliente], [Descuentos], [compraTotal]) VALUES (1, N'Hugo', N'González', N'Villagran', N'3246269997', 60, 850)
GO
INSERT [dbo].[CLIENTES] ([idCliente], [nomCliente], [apPaterno], [apMaterno], [telCliente], [Descuentos], [compraTotal]) VALUES (2, N'Elizabeth', N'González', N'Ornelas', N'3245069866', 50, 750)
GO
INSERT [dbo].[CLIENTES] ([idCliente], [nomCliente], [apPaterno], [apMaterno], [telCliente], [Descuentos], [compraTotal]) VALUES (3, N'Felipe', N'González', N'López', N'3245179832', 40, 900)
GO
INSERT [dbo].[CLIENTES] ([idCliente], [nomCliente], [apPaterno], [apMaterno], [telCliente], [Descuentos], [compraTotal]) VALUES (4, N'José', N'Murillo', N'Delgado', N'3245168810', 30, 600)
GO
INSERT [dbo].[CLIENTES] ([idCliente], [nomCliente], [apPaterno], [apMaterno], [telCliente], [Descuentos], [compraTotal]) VALUES (5, N'Jorge', N'González', N'Delgado', N'3241008810', 10, 500)
GO
INSERT [dbo].[CLIENTES] ([idCliente], [nomCliente], [apPaterno], [apMaterno], [telCliente], [Descuentos], [compraTotal]) VALUES (6, N'LALO', N'MARMOLEJO', N'ORNELAS', N'3241566226', 20, 100)
GO
SET IDENTITY_INSERT [dbo].[CLIENTES] OFF
GO
SET IDENTITY_INSERT [dbo].[COMPRAS] ON 
GO
INSERT [dbo].[COMPRAS] ([idCompras], [nomCompra], [precioCom], [numProCom], [fechaCompra], [totalCompra], [idProducto], [idProveedor]) VALUES (1, N'Frenos', 200, 10, CAST(N'2021-06-08' AS Date), 2000, 1, 1)
GO
INSERT [dbo].[COMPRAS] ([idCompras], [nomCompra], [precioCom], [numProCom], [fechaCompra], [totalCompra], [idProducto], [idProveedor]) VALUES (2, N'Resistencias', 200, 5, CAST(N'2021-06-08' AS Date), 1000, 2, 2)
GO
INSERT [dbo].[COMPRAS] ([idCompras], [nomCompra], [precioCom], [numProCom], [fechaCompra], [totalCompra], [idProducto], [idProveedor]) VALUES (3, N'Transmiciones', 200, 20, CAST(N'2021-06-08' AS Date), 4000, 3, 3)
GO
INSERT [dbo].[COMPRAS] ([idCompras], [nomCompra], [precioCom], [numProCom], [fechaCompra], [totalCompra], [idProducto], [idProveedor]) VALUES (4, N'Focos', 200, 10, CAST(N'2021-06-08' AS Date), 2000, 4, 4)
GO
INSERT [dbo].[COMPRAS] ([idCompras], [nomCompra], [precioCom], [numProCom], [fechaCompra], [totalCompra], [idProducto], [idProveedor]) VALUES (6, N'RUMBLE SILENCIADOR PERFORMANCE 17649MGF', 1819, 15, CAST(N'2021-04-07' AS Date), 27285, 16, 1)
GO
INSERT [dbo].[COMPRAS] ([idCompras], [nomCompra], [precioCom], [numProCom], [fechaCompra], [totalCompra], [idProducto], [idProveedor]) VALUES (7, N'HOPKINS CONECTOR PLANO DE 4 CABLES DE 48 PULG., CON EMPALMES', 90, 150, CAST(N'2021-04-07' AS Date), 13500, 17, 2)
GO
INSERT [dbo].[COMPRAS] ([idCompras], [nomCompra], [precioCom], [numProCom], [fechaCompra], [totalCompra], [idProducto], [idProveedor]) VALUES (8, N'HOPKINS CONECTOR PLANO DE 4 CABLES DE 48 PULG., CON EMPALMES', 90, 200, CAST(N'2021-04-07' AS Date), 18000, 17, 4)
GO
SET IDENTITY_INSERT [dbo].[COMPRAS] OFF
GO
SET IDENTITY_INSERT [dbo].[DIRECCIÓN] ON 
GO
INSERT [dbo].[DIRECCIÓN] ([idDireccion], [numExt], [numInt], [Calle], [Municipio], [CP], [Estado]) VALUES (1, 223, 0, N'Morelos', N'Ixtlán del Río', N'63940', N'Nayarit')
GO
INSERT [dbo].[DIRECCIÓN] ([idDireccion], [numExt], [numInt], [Calle], [Municipio], [CP], [Estado]) VALUES (2, 237, 0, N'Eulogio Parra', N'Ixtlán del Río', N'63940', N'Nayarit')
GO
INSERT [dbo].[DIRECCIÓN] ([idDireccion], [numExt], [numInt], [Calle], [Municipio], [CP], [Estado]) VALUES (3, 271, 0, N'Negrete', N'Ixtlán del Río', N'63940', N'Nayarit')
GO
INSERT [dbo].[DIRECCIÓN] ([idDireccion], [numExt], [numInt], [Calle], [Municipio], [CP], [Estado]) VALUES (4, 66, 0, N'Mérida', N'Ixtlán del Río', N'63940', N'Nayarit')
GO
SET IDENTITY_INSERT [dbo].[DIRECCIÓN] OFF
GO
SET IDENTITY_INSERT [dbo].[EMPLEADOS] ON 
GO
INSERT [dbo].[EMPLEADOS] ([idEmpleado], [nomEmpleado], [apPaterno], [apMaterno], [CURP], [telEmpleado], [idLogin], [idDireccion]) VALUES (1, N'Carlos', N'González', N'Chuyín', N'GOCC001101HNTRDA6', N'3245169887', 1, 1)
GO
INSERT [dbo].[EMPLEADOS] ([idEmpleado], [nomEmpleado], [apPaterno], [apMaterno], [CURP], [telEmpleado], [idLogin], [idDireccion]) VALUES (2, N'Guadalupe', N'Villegas', N'Vargas', N'JIVD001101HNTRTDA6', N'3245169878', 1, 2)
GO
INSERT [dbo].[EMPLEADOS] ([idEmpleado], [nomEmpleado], [apPaterno], [apMaterno], [CURP], [telEmpleado], [idLogin], [idDireccion]) VALUES (3, N'Edith', N'López', N'González', N'LOGE001101HNTRRDE6', N'3243169888', 1, 3)
GO
INSERT [dbo].[EMPLEADOS] ([idEmpleado], [nomEmpleado], [apPaterno], [apMaterno], [CURP], [telEmpleado], [idLogin], [idDireccion]) VALUES (4, N'JUAN', N'JIMÉNEZ', N'ZEPEDA', N'JIZJ001101HNTRRDA8', N'3245109887', 1, 4)
GO
INSERT [dbo].[EMPLEADOS] ([idEmpleado], [nomEmpleado], [apPaterno], [apMaterno], [CURP], [telEmpleado], [idLogin], [idDireccion]) VALUES (5, N'EDUARDO', N'MARMOLEJO', N'ORNELAS', N'MAOE001022HNTRRDA6', N'3241568987', 1, 1)
GO
INSERT [dbo].[EMPLEADOS] ([idEmpleado], [nomEmpleado], [apPaterno], [apMaterno], [CURP], [telEmpleado], [idLogin], [idDireccion]) VALUES (6, N'FELIPE', N'SANDOVAL', N'GONZÁLEZ', N'SAGF690526HNTRRDA6', N'5201478996', 1, 2)
GO
SET IDENTITY_INSERT [dbo].[EMPLEADOS] OFF
GO
SET IDENTITY_INSERT [dbo].[LOGIN] ON 
GO
INSERT [dbo].[LOGIN] ([idLogin], [Usuario], [Contraseña]) VALUES (1, N'admin', N'admin')
GO
SET IDENTITY_INSERT [dbo].[LOGIN] OFF
GO
SET IDENTITY_INSERT [dbo].[MODULO] ON 
GO
INSERT [dbo].[MODULO] ([idModulo], [nomModulo]) VALUES (1, N'Usuarios')
GO
INSERT [dbo].[MODULO] ([idModulo], [nomModulo]) VALUES (2, N'Roles')
GO
INSERT [dbo].[MODULO] ([idModulo], [nomModulo]) VALUES (3, N'Productos')
GO
INSERT [dbo].[MODULO] ([idModulo], [nomModulo]) VALUES (4, N'Compras')
GO
INSERT [dbo].[MODULO] ([idModulo], [nomModulo]) VALUES (5, N'Ventas')
GO
INSERT [dbo].[MODULO] ([idModulo], [nomModulo]) VALUES (6, N'Eempleados')
GO
INSERT [dbo].[MODULO] ([idModulo], [nomModulo]) VALUES (7, N'Clientes')
GO
INSERT [dbo].[MODULO] ([idModulo], [nomModulo]) VALUES (8, N'Proveedores')
GO
INSERT [dbo].[MODULO] ([idModulo], [nomModulo]) VALUES (9, N'Reportes Ventas')
GO
INSERT [dbo].[MODULO] ([idModulo], [nomModulo]) VALUES (10, N'Reportes Compras')
GO
INSERT [dbo].[MODULO] ([idModulo], [nomModulo]) VALUES (11, N'Reportes Pagos')
GO
SET IDENTITY_INSERT [dbo].[MODULO] OFF
GO
SET IDENTITY_INSERT [dbo].[OPERACION] ON 
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (1, N'AGREGAR', 1)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (2, N'MOSTRAR', 1)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (3, N'ACTUALIZAR', 1)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (4, N'ELIMINAR', 1)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (5, N'AGREGAR', 2)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (6, N'MOSTRAR', 2)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (7, N'ACTUALIZAR', 2)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (8, N'ELIMINAR', 2)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (9, N'AGREGAR', 3)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (10, N'MOSTRAR', 3)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (11, N'ACTUALIZAR', 3)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (12, N'ELIMINAR', 3)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (13, N'AGREGAR', 4)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (14, N'MOSTRAR', 4)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (15, N'ACTUALIZAR', 4)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (16, N'ELIMINAR', 4)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (17, N'AGREGAR', 5)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (18, N'MOSTRAR', 5)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (19, N'ACTUALIZAR', 5)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (20, N'ELIMINAR', 5)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (21, N'AGREGAR', 6)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (22, N'MOSTRAR', 6)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (23, N'ACTUALIZAR', 6)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (24, N'ELIMINAR', 6)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (25, N'AGREGAR', 7)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (26, N'MOSTRAR', 7)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (27, N'ACTUALIZAR', 7)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (28, N'ELIMINAR', 7)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (29, N'AGREGAR', 8)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (30, N'MOSTRAR', 8)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (31, N'ACTUALIZAR', 8)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (32, N'ELIMINAR', 8)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (33, N'AGREGAR', 9)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (34, N'MOSTRAR', 9)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (35, N'ACTUALIZAR', 9)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (36, N'ELIMINAR', 9)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (37, N'AGREGAR', 10)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (38, N'MOSTRAR', 10)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (39, N'ACTUALIZAR', 10)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (40, N'ELIMINAR', 10)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (41, N'AGREGAR', 11)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (42, N'MOSTRAR', 11)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (43, N'ACTUALIZAR', 11)
GO
INSERT [dbo].[OPERACION] ([idOperacion], [nomOperacion], [idModulo]) VALUES (44, N'ELIMINAR', 11)
GO
SET IDENTITY_INSERT [dbo].[OPERACION] OFF
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 1)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 2)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 3)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 4)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 5)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 6)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 7)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 8)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 9)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 10)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 11)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 12)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 13)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 14)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 15)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 16)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 17)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 18)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 19)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 20)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 21)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 22)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 23)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 24)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 25)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 26)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 27)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 28)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 29)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 30)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 31)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 32)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 33)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 34)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 35)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 36)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 37)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 38)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 39)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 40)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 41)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 42)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 43)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (1, 44)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 1)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 2)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 5)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 6)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 9)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 10)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 13)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 14)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 17)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 18)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 21)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 22)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 25)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 26)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 29)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 30)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 33)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 34)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 37)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 38)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 41)
GO
INSERT [dbo].[PREFIL_OPERACION] ([idRol], [idOperacion]) VALUES (2, 42)
GO
SET IDENTITY_INSERT [dbo].[PRODUCTOS] ON 
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (1, N'FRENOS', 469, 200)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (2, N'BUJÍA AUTOLITE', 164, 300)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (3, N'RESISTENCIAS', 150, 450)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (4, N'TRANSMICIONES', 200, 450)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (5, N'FOCO DELANTERO', 115, 150)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (6, N'BANDAS', 200, 200)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (7, N'BATERÍA PLATINUM', 4799, 500)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (8, N'ACEITE MOTOR SINTÉTICO', 266, 300)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (9, N'CERA LÍQUIDA COLOR NEGRO', 125, 200)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (10, N'PRESTONE LARGA DURACION 50% UNIVERSAL ANTICONGELANTE', 70, 100)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (11, N'RISLONE SELLADOR DE FUGAS, 500 ML', 429, 100)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (12, N'DURALAST MAX BALATA SEMI-METALICA DMAX601', 679, 500)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (13, N'K&N HIGH PERFORMANCE FILTRO DE AIRE E-0785', 2299, 500)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (14, N'SUREBILT JUEGO DE DESTORNILLADORES DE 100 PIEZAS', 699, 50)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (15, N'Duralast Alternador', 799, 490)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (16, N'RUMBLE SILENCIADOR PERFORMANCE 17649MGF', 1819, 20)
GO
INSERT [dbo].[PRODUCTOS] ([idProducto], [Nombre], [Precio], [Stock]) VALUES (17, N'HOPKINS CONECTOR PLANO DE 4 CABLES DE 48 PULG., CON EMPALMES', 90, 300)
GO
SET IDENTITY_INSERT [dbo].[PRODUCTOS] OFF
GO
SET IDENTITY_INSERT [dbo].[PROVEEDOR] ON 
GO
INSERT [dbo].[PROVEEDOR] ([idProveedor], [razonSocial], [telProveedor], [idDireccion]) VALUES (1, N'Repartidor', N'3241056996', 1)
GO
INSERT [dbo].[PROVEEDOR] ([idProveedor], [razonSocial], [telProveedor], [idDireccion]) VALUES (2, N'Repartidor 2', N'3241057896', 2)
GO
INSERT [dbo].[PROVEEDOR] ([idProveedor], [razonSocial], [telProveedor], [idDireccion]) VALUES (3, N'Repartidor 3', N'3241006996', 3)
GO
INSERT [dbo].[PROVEEDOR] ([idProveedor], [razonSocial], [telProveedor], [idDireccion]) VALUES (4, N'Repartidor 4', N'3241056896', 4)
GO
SET IDENTITY_INSERT [dbo].[PROVEEDOR] OFF
GO
SET IDENTITY_INSERT [dbo].[REPORTE_VENTAS] ON 
GO
INSERT [dbo].[REPORTE_VENTAS] ([idReVentas], [precioVenta], [canVentas], [totalVentas], [idVenta]) VALUES (1, 200, 3, 600, 5)
GO
SET IDENTITY_INSERT [dbo].[REPORTE_VENTAS] OFF
GO
SET IDENTITY_INSERT [dbo].[ROL] ON 
GO
INSERT [dbo].[ROL] ([idRol], [nombreRol]) VALUES (1, N'Administrador')
GO
INSERT [dbo].[ROL] ([idRol], [nombreRol]) VALUES (2, N'Capturista')
GO
SET IDENTITY_INSERT [dbo].[ROL] OFF
GO
SET IDENTITY_INSERT [dbo].[USUARIOS] ON 
GO
INSERT [dbo].[USUARIOS] ([idUsuario], [Usuario], [Contraseña], [idRol]) VALUES (1, N'admin', N'admin', 1)
GO
INSERT [dbo].[USUARIOS] ([idUsuario], [Usuario], [Contraseña], [idRol]) VALUES (2, N'capturista', N'capturista', 2)
GO
SET IDENTITY_INSERT [dbo].[USUARIOS] OFF
GO
SET IDENTITY_INSERT [dbo].[VENTA_AUDITADA] ON 
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (1, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-06-08T23:15:50.090' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (2, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-03T18:41:39.437' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (3, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-03T18:44:05.600' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (4, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-03T18:49:28.750' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (5, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-03T21:54:06.330' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (6, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-03T22:20:25.070' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (7, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-03T22:20:25.153' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (8, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-03T22:25:46.690' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (9, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-03T22:32:32.387' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (10, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-03T22:36:04.617' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (11, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-03T22:47:23.697' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (12, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-03T22:54:40.163' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (13, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-04T11:49:28.837' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (14, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-04T14:15:55.590' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (15, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-04T19:48:17.897' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (16, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-04T20:50:08.333' AS DateTime), N'VENTA')
GO
INSERT [dbo].[VENTA_AUDITADA] ([idVenAuditada], [Operacion], [Usuario], [Host], [Modificado], [Tabla]) VALUES (17, N'INSERT', N'LAPTOP-J2A28JHM\KAOS LALO', N'LAPTOP-J2A28JHM', CAST(N'2021-07-04T20:52:27.930' AS DateTime), N'VENTA')
GO
SET IDENTITY_INSERT [dbo].[VENTA_AUDITADA] OFF
GO
SET IDENTITY_INSERT [dbo].[VENTAS] ON 
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (1, N'Frenos', 200, 4, CAST(N'2021-06-08' AS Date), 800, 1000, 200, 1, 1)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (2, N'Resistencias', 150, 10, CAST(N'2021-06-08' AS Date), 1500, 2000, 500, 2, 2)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (3, N'Transmiciones', 200, 20, CAST(N'2021-06-08' AS Date), 4000, 5000, 1000, 3, 3)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (4, N'Focos', 150, 10, CAST(N'2021-06-08' AS Date), 1500, 2000, 500, 4, 4)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (5, N'Bandas', 200, 15, CAST(N'2021-06-08' AS Date), 3000, 4000, 100, 5, 5)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (6, N'Focos', 150, 15, CAST(N'2021-06-08' AS Date), 2250, 3000, 750, 4, 1)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (13, N'BUJÍAS AUTOLITE', 164, 1, CAST(N'2021-07-03' AS Date), 164, 200, 36, 2, 2)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (14, N'ACEITE MOTOR SINTÉTICO', 266, 2, CAST(N'2021-03-07' AS Date), 532, 600, 68, 8, 6)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (15, N'CERA LÍQUIDA COLOR NEGRO', 125, 1, CAST(N'2021-03-07' AS Date), 125, 200, 75, 9, 6)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (16, N'PRESTONE LARGA DURACION 50% UNIVERSAL ANTICONGELANTE', 70, 2, CAST(N'2021-03-07' AS Date), 140, 200, 60, 10, 6)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (17, N'RISLONE SELLADOR DE FUGAS, 500 ML', 429, 2, CAST(N'2021-03-07' AS Date), 858, 1000, 142, 11, 3)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (20, N'DURALAST MAX BALATA SEMI-METALICA DMAX601', 679, 1, CAST(N'2021-01-07' AS Date), 679, 700, 21, 12, 4)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (21, N'SUREBILT JUEGO DE DESTORNILLADORES DE 100 PIEZAS', 699, 1, CAST(N'2021-01-07' AS Date), 699, 700, 1, 14, 5)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (22, N'FOCO DELANTERO', 115, 2, CAST(N'2021-02-07' AS Date), 230, 300, 70, 5, 1)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (23, N'BUJÍAS AUTOLITE', 164, 1, CAST(N'2021-07-03' AS Date), 164, 200, 36, 2, 2)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (24, N'Duralast Alternador', 799, 5, CAST(N'2021-07-04' AS Date), 3995, 4000, 5, 15, 3)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (25, N'DURALAST ALTERNADOR', 799, 5, CAST(N'2021-04-07' AS Date), 3995, 4000, 5, 15, 2)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (26, N'RUMBLE SILENCIADOR PERFORMANCE 17649MGF', 1819, 5, CAST(N'2021-04-07' AS Date), 9095, 10000, 905, 16, 6)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (27, N'HOPKINS CONECTOR PLANO DE 4 CABLES DE 48 PULG., CON EMPALMES', 90, 50, CAST(N'2021-04-07' AS Date), 4500, 5000, 500, 17, 3)
GO
INSERT [dbo].[VENTAS] ([idVenta], [Nombre], [PrecioVen], [numProVen], [Fecha], [precioTotal], [pagaCon], [Cambio], [idProducto], [idCliente]) VALUES (28, N'HOPKINS CONECTOR PLANO DE 4 CABLES DE 48 PULG., CON EMPALMES', 90, 100, CAST(N'2021-04-07' AS Date), 9000, 10000, 1000, 17, 3)
GO
SET IDENTITY_INSERT [dbo].[VENTAS] OFF
GO
/****** Object:  Index [IDX_idCliente]    Script Date: 07/07/2021 07:37:10 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_idCliente] ON [dbo].[CLIENTES]
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_idCompra]    Script Date: 07/07/2021 07:37:10 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_idCompra] ON [dbo].[COMPRAS]
(
	[idCompras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_idEmpleado]    Script Date: 07/07/2021 07:37:10 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_idEmpleado] ON [dbo].[EMPLEADOS]
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__LOGIN__E3237CF7ABA2F2F0]    Script Date: 07/07/2021 07:37:10 p. m. ******/
ALTER TABLE [dbo].[LOGIN] ADD UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_idLogin]    Script Date: 07/07/2021 07:37:10 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_idLogin] ON [dbo].[LOGIN]
(
	[idLogin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_idProducto]    Script Date: 07/07/2021 07:37:10 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_idProducto] ON [dbo].[PRODUCTOS]
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_idProveedor]    Script Date: 07/07/2021 07:37:10 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_idProveedor] ON [dbo].[PROVEEDOR]
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_idReCompras]    Script Date: 07/07/2021 07:37:10 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_idReCompras] ON [dbo].[REPORTE_COMPRAS]
(
	[idReCompras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_idRePagos]    Script Date: 07/07/2021 07:37:10 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_idRePagos] ON [dbo].[REPORTE_PAGOS]
(
	[idRePagos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_idReVentas]    Script Date: 07/07/2021 07:37:10 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_idReVentas] ON [dbo].[REPORTE_VENTAS]
(
	[idReVentas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_idVentas]    Script Date: 07/07/2021 07:37:10 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_idVentas] ON [dbo].[VENTAS]
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[VENTA_AUDITADA] ADD  DEFAULT (NULL) FOR [Operacion]
GO
ALTER TABLE [dbo].[VENTA_AUDITADA] ADD  DEFAULT (NULL) FOR [Usuario]
GO
ALTER TABLE [dbo].[VENTA_AUDITADA] ADD  DEFAULT (NULL) FOR [Host]
GO
ALTER TABLE [dbo].[VENTA_AUDITADA] ADD  DEFAULT (NULL) FOR [Modificado]
GO
ALTER TABLE [dbo].[COMPRAS]  WITH CHECK ADD FOREIGN KEY([idProducto])
REFERENCES [dbo].[PRODUCTOS] ([idProducto])
GO
ALTER TABLE [dbo].[COMPRAS]  WITH CHECK ADD FOREIGN KEY([idProveedor])
REFERENCES [dbo].[PROVEEDOR] ([idProveedor])
GO
ALTER TABLE [dbo].[EMPLEADOS]  WITH CHECK ADD FOREIGN KEY([idDireccion])
REFERENCES [dbo].[DIRECCIÓN] ([idDireccion])
GO
ALTER TABLE [dbo].[EMPLEADOS]  WITH CHECK ADD FOREIGN KEY([idLogin])
REFERENCES [dbo].[LOGIN] ([idLogin])
GO
ALTER TABLE [dbo].[OPERACION]  WITH CHECK ADD FOREIGN KEY([idModulo])
REFERENCES [dbo].[MODULO] ([idModulo])
GO
ALTER TABLE [dbo].[PREFIL_OPERACION]  WITH CHECK ADD FOREIGN KEY([idOperacion])
REFERENCES [dbo].[OPERACION] ([idOperacion])
GO
ALTER TABLE [dbo].[PREFIL_OPERACION]  WITH CHECK ADD FOREIGN KEY([idRol])
REFERENCES [dbo].[ROL] ([idRol])
GO
ALTER TABLE [dbo].[PROVEEDOR]  WITH CHECK ADD FOREIGN KEY([idDireccion])
REFERENCES [dbo].[DIRECCIÓN] ([idDireccion])
GO
ALTER TABLE [dbo].[REPORTE_COMPRAS]  WITH CHECK ADD FOREIGN KEY([idCompras])
REFERENCES [dbo].[COMPRAS] ([idCompras])
GO
ALTER TABLE [dbo].[REPORTE_PAGOS]  WITH CHECK ADD FOREIGN KEY([idCompras])
REFERENCES [dbo].[COMPRAS] ([idCompras])
GO
ALTER TABLE [dbo].[REPORTE_VENTAS]  WITH CHECK ADD FOREIGN KEY([idVenta])
REFERENCES [dbo].[VENTAS] ([idVenta])
GO
ALTER TABLE [dbo].[USUARIOS]  WITH CHECK ADD FOREIGN KEY([idRol])
REFERENCES [dbo].[ROL] ([idRol])
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD FOREIGN KEY([idCliente])
REFERENCES [dbo].[CLIENTES] ([idCliente])
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD FOREIGN KEY([idProducto])
REFERENCES [dbo].[PRODUCTOS] ([idProducto])
GO
ALTER TABLE [dbo].[COMPRAS]  WITH CHECK ADD  CONSTRAINT [CK_numProCom] CHECK  (([numProCom]>=(0)))
GO
ALTER TABLE [dbo].[COMPRAS] CHECK CONSTRAINT [CK_numProCom]
GO
ALTER TABLE [dbo].[COMPRAS]  WITH CHECK ADD  CONSTRAINT [CK_precioCom] CHECK  (([precioCom]>=(0)))
GO
ALTER TABLE [dbo].[COMPRAS] CHECK CONSTRAINT [CK_precioCom]
GO
ALTER TABLE [dbo].[COMPRAS]  WITH CHECK ADD  CONSTRAINT [CK_totalCompra] CHECK  (([totalCompra]>=(0)))
GO
ALTER TABLE [dbo].[COMPRAS] CHECK CONSTRAINT [CK_totalCompra]
GO
ALTER TABLE [dbo].[PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [CK_Precio] CHECK  (([Precio]>=(0)))
GO
ALTER TABLE [dbo].[PRODUCTOS] CHECK CONSTRAINT [CK_Precio]
GO
ALTER TABLE [dbo].[PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [CK_Stock] CHECK  (([Stock]>=(0)))
GO
ALTER TABLE [dbo].[PRODUCTOS] CHECK CONSTRAINT [CK_Stock]
GO
ALTER TABLE [dbo].[REPORTE_COMPRAS]  WITH CHECK ADD  CONSTRAINT [CK_idCompras] CHECK  (([idCompras] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[REPORTE_COMPRAS] CHECK CONSTRAINT [CK_idCompras]
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD  CONSTRAINT [CK_Cambio] CHECK  (([Cambio]>=(0)))
GO
ALTER TABLE [dbo].[VENTAS] CHECK CONSTRAINT [CK_Cambio]
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD  CONSTRAINT [CK_numProVen] CHECK  (([numProVen]>=(0)))
GO
ALTER TABLE [dbo].[VENTAS] CHECK CONSTRAINT [CK_numProVen]
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD  CONSTRAINT [CK_pagaCon] CHECK  (([pagaCon]>=(0)))
GO
ALTER TABLE [dbo].[VENTAS] CHECK CONSTRAINT [CK_pagaCon]
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD  CONSTRAINT [CK_precioTotal] CHECK  (([precioTotal]>=(0)))
GO
ALTER TABLE [dbo].[VENTAS] CHECK CONSTRAINT [CK_precioTotal]
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD  CONSTRAINT [CK_PrecioVen] CHECK  (([PrecioVen]>=(0)))
GO
ALTER TABLE [dbo].[VENTAS] CHECK CONSTRAINT [CK_PrecioVen]
GO
/****** Object:  StoredProcedure [dbo].[BuscarClientes]    Script Date: 07/07/2021 07:37:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarClientes]
@BusClientes VARCHAR (200)
AS
SELECT nomCliente, apPaterno, apMaterno, telCliente, Descuentos, compraTotal FROM CLIENTES
WHERE nomCliente LIKE '%'+ @BusClientes + '%'
GO
/****** Object:  StoredProcedure [dbo].[BuscarEmpleados]    Script Date: 07/07/2021 07:37:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarEmpleados]
@BusEmpleados VARCHAR (200)
AS
SELECT nomEmpleado, apPaterno, apMaterno, CURP, telEmpleado, idLogin, idDireccion FROM EMPLEADOS
WHERE nomEmpleado LIKE '%'+ @BusEmpleados + '%'
GO
/****** Object:  StoredProcedure [dbo].[BuscarProductos]    Script Date: 07/07/2021 07:37:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarProductos]
@BusProductos VARCHAR (200)
AS
SELECT idProducto, Nombre, Precio, Stock FROM PRODUCTOS
WHERE Nombre LIKE '%'+ @BusProductos + '%'
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarClientes]    Script Date: 07/07/2021 07:37:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizarClientes]
@idCliente BIGINT,
@nomCliente VARCHAR (100),
@apPaterno VARCHAR (100),
@apMaterno VARCHAR (100),
@telCliente VARCHAR (10),
@Descuentos INT,
@compraTotal INT
AS
BEGIN
UPDATE CLIENTES SET nomCliente=@nomCliente, apPaterno=@apPaterno, apMaterno=@apMaterno, telCliente=@telCliente, Descuentos=@Descuentos,
compraTotal=@compraTotal WHERE idCliente=@idCliente
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarEmpleados]    Script Date: 07/07/2021 07:37:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizarEmpleados]
@idEmpleado BIGINT,
@nomEmpleado VARCHAR (100),
@apPaterno VARCHAR (100),
@apMaterno VARCHAR (100),
@CURP VARCHAR (18),
@telEmpleado VARCHAR (10),
@idLogin INT,
@idDireccion INT
AS
BEGIN
UPDATE EMPLEADOS SET nomEmpleado=@nomEmpleado, apPaterno=@apPaterno, apMaterno=@apMaterno, CURP=@CURP,telEmpleado=@telEmpleado,
idLogin=@idLogin, idDireccion=idDireccion WHERE idEmpleado=@idEmpleado
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarProductos]    Script Date: 07/07/2021 07:37:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizarProductos]
@idProducto BIGINT,
@Nombre VARCHAR (100),
@Precio INT,
@Stock INT
AS
BEGIN
UPDATE  PRODUCTOS SET Nombre=@Nombre, Precio=@Precio, Stock=@Stock WHERE idProducto=@idProducto
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarVentas]    Script Date: 07/07/2021 07:37:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BuscarVentas]
@BusVentas VARCHAR (200)
AS
SELECT idVenta, Nombre, PrecioVen, numProVen, Fecha, precioTotal, pagaCon, Cambio, idProducto, idCliente FROM VENTAS
WHERE Nombre LIKE '%'+ @BusVentas + '%'
GO
/****** Object:  StoredProcedure [dbo].[SP_ReportesCompras]    Script Date: 07/07/2021 07:37:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ReportesCompras]
AS
SELECT COMPRAS.idCompras,COMPRAS.idProducto,COMPRAS.nomCompra,COMPRAS.precioCom,COMPRAS.numProCom,COMPRAS.fechaCompra,COMPRAS.totalCompra,
COMPRAS.idProveedor FROM COMPRAS
INNER JOIN PROVEEDOR ON COMPRAS.idProveedor=PROVEEDOR.idProveedor
GO
/****** Object:  StoredProcedure [dbo].[SP_ReportesVentas]    Script Date: 07/07/2021 07:37:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ReportesVentas]
AS
SELECT VENTAS.idVenta,VENTAS.idProducto,VENTAS.Nombre,VENTAS.PrecioVen,VENTAS.numProVen,VENTAS.Fecha,VENTAS.precioTotal,
VENTAS.pagaCon,VENTAS.Cambio, VENTAS.idCliente FROM VENTAS
INNER JOIN CLIENTES ON CLIENTES.idCliente=VENTAS.idCliente
GO
/****** Object:  Trigger [dbo].[TR_AumentarStock]    Script Date: 07/07/2021 07:37:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AumentarStock]
ON [dbo].[COMPRAS]
AFTER INSERT
AS
UPDATE PRODUCTOS SET PRODUCTOS.Stock=PRODUCTOS.Stock+COMPRAS.numProCom
FROM inserted AS COMPRAS INNER JOIN PRODUCTOS AS PRODUCTOS ON
COMPRAS.idProducto=PRODUCTOS.idProducto
GO
ALTER TABLE [dbo].[COMPRAS] ENABLE TRIGGER [TR_AumentarStock]
GO
/****** Object:  Trigger [dbo].[TR_DisminuirStock]    Script Date: 07/07/2021 07:37:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_DisminuirStock]
ON [dbo].[VENTAS]
AFTER INSERT
AS
UPDATE PRODUCTOS SET PRODUCTOS.Stock=PRODUCTOS.Stock-VENTAS.numProVen
FROM inserted AS VENTAS INNER JOIN PRODUCTOS AS PRODUCTOS ON
VENTAS.idProducto=PRODUCTOS.idProducto
GO
ALTER TABLE [dbo].[VENTAS] ENABLE TRIGGER [TR_DisminuirStock]
GO
/****** Object:  Trigger [dbo].[TR_Venta]    Script Date: 07/07/2021 07:37:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_Venta]
ON [dbo].[VENTAS] 
AFTER INSERT
AS
BEGIN
INSERT INTO VENTA_AUDITADA (host,usuario,operacion,modificado, tabla)
   VALUES (@@SERVERNAME,SUSER_NAME(),'INSERT',GETDATE(),'VENTA')
END
GO
ALTER TABLE [dbo].[VENTAS] ENABLE TRIGGER [TR_Venta]
GO
USE [master]
GO
ALTER DATABASE [REFACCIONARIA] SET  READ_WRITE 
GO
