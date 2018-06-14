/*
 Navicat Premium Data Transfer

 Source Server         : MSsql od adriana
 Source Server Type    : SQL Server
 Source Server Version : 14001000
 Source Host           : 34.203.200.61:1433
 Source Catalog        : SSprint
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 14001000
 File Encoding         : 65001

 Date: 14/06/2018 17:18:04
*/


-- ----------------------------
-- Table structure for colors
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[colors]') AND type IN ('U'))
	DROP TABLE [dbo].[colors]
GO

CREATE TABLE [dbo].[colors] (
  [id] int NOT NULL,
  [name] varchar(255) COLLATE Polish_100_CI_AS NOT NULL,
  [hex_value] varchar(255) COLLATE Polish_100_CI_AS NULL
)
GO

ALTER TABLE [dbo].[colors] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for companies
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[companies]') AND type IN ('U'))
	DROP TABLE [dbo].[companies]
GO

CREATE TABLE [dbo].[companies] (
  [id] int NOT NULL,
  [name] varchar(255) COLLATE Polish_100_CI_AS NOT NULL,
  [phone] varchar(255) COLLATE Polish_100_CI_AS NULL,
  [email] varchar(255) COLLATE Polish_100_CI_AS NULL
)
GO

ALTER TABLE [dbo].[companies] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for orders
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[orders]') AND type IN ('U'))
	DROP TABLE [dbo].[orders]
GO

CREATE TABLE [dbo].[orders] (
  [id] int NOT NULL,
  [status] int DEFAULT ((0)) NOT NULL,
  [picture_id] int NULL,
  [client_name] varchar(255) COLLATE Polish_100_CI_AS NOT NULL,
  [client_email] varchar(255) COLLATE Polish_100_CI_AS NULL,
  [client_phone] varchar(255) COLLATE Polish_100_CI_AS NULL,
  [end_date] datetime NULL,
  [order_date] datetime NOT NULL
)
GO

ALTER TABLE [dbo].[orders] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for pictures
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[pictures]') AND type IN ('U'))
	DROP TABLE [dbo].[pictures]
GO

CREATE TABLE [dbo].[pictures] (
  [id] int NOT NULL,
  [name] varchar(255) COLLATE Polish_100_CI_AS NOT NULL,
  [picture_data] text COLLATE Polish_100_CI_AS NOT NULL
)
GO

ALTER TABLE [dbo].[pictures] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for singleItemOrder
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[singleItemOrder]') AND type IN ('U'))
	DROP TABLE [dbo].[singleItemOrder]
GO

CREATE TABLE [dbo].[singleItemOrder] (
  [id] int NOT NULL,
  [order_id] int NOT NULL,
  [tshirt_id] int NOT NULL,
  [amount] int DEFAULT ((0)) NOT NULL
)
GO

ALTER TABLE [dbo].[singleItemOrder] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for styles
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[styles]') AND type IN ('U'))
	DROP TABLE [dbo].[styles]
GO

CREATE TABLE [dbo].[styles] (
  [id] int NOT NULL,
  [name] varchar(255) COLLATE Polish_100_CI_AS NOT NULL
)
GO

ALTER TABLE [dbo].[styles] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tshirts
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tshirts]') AND type IN ('U'))
	DROP TABLE [dbo].[tshirts]
GO

CREATE TABLE [dbo].[tshirts] (
  [id] int NOT NULL,
  [company_id] int NOT NULL,
  [style_id] int NOT NULL,
  [sex] varchar(255) COLLATE Polish_100_CI_AS NOT NULL,
  [color_id] int NOT NULL,
  [in_stock] int DEFAULT ((0)) NOT NULL,
  [default_loss_percentage] int DEFAULT ((10)) NOT NULL
)
GO

ALTER TABLE [dbo].[tshirts] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Indexes structure for table colors
-- ----------------------------
CREATE UNIQUE NONCLUSTERED INDEX [naim]
ON [dbo].[colors] (
  [id] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table colors
-- ----------------------------
ALTER TABLE [dbo].[colors] ADD CONSTRAINT [PK__colors__3213E83F99D1941E] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table companies
-- ----------------------------
CREATE UNIQUE NONCLUSTERED INDEX [main]
ON [dbo].[companies] (
  [id] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table companies
-- ----------------------------
ALTER TABLE [dbo].[companies] ADD CONSTRAINT [PK__companie__3213E83F96F9CE54] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table orders
-- ----------------------------
CREATE UNIQUE NONCLUSTERED INDEX [main]
ON [dbo].[orders] (
  [id] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table orders
-- ----------------------------
ALTER TABLE [dbo].[orders] ADD CONSTRAINT [PK__orders__3213E83F4AAC33BF] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table pictures
-- ----------------------------
CREATE UNIQUE NONCLUSTERED INDEX [main]
ON [dbo].[pictures] (
  [id] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table pictures
-- ----------------------------
ALTER TABLE [dbo].[pictures] ADD CONSTRAINT [PK__pictures__3213E83FECAE79D6] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table singleItemOrder
-- ----------------------------
CREATE UNIQUE NONCLUSTERED INDEX [main]
ON [dbo].[singleItemOrder] (
  [id] ASC
)
GO


-- ----------------------------
-- Indexes structure for table styles
-- ----------------------------
CREATE UNIQUE NONCLUSTERED INDEX [main]
ON [dbo].[styles] (
  [id] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table styles
-- ----------------------------
ALTER TABLE [dbo].[styles] ADD CONSTRAINT [PK__styles__3213E83F5680870E] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table tshirts
-- ----------------------------
CREATE UNIQUE NONCLUSTERED INDEX [main]
ON [dbo].[tshirts] (
  [id] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table tshirts
-- ----------------------------
ALTER TABLE [dbo].[tshirts] ADD CONSTRAINT [PK__tshirts__3213E83FA1BECA13] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table orders
-- ----------------------------
ALTER TABLE [dbo].[orders] ADD CONSTRAINT [picture_id] FOREIGN KEY ([picture_id]) REFERENCES [pictures] ([id]) ON DELETE SET NULL ON UPDATE CASCADE
GO


-- ----------------------------
-- Foreign Keys structure for table singleItemOrder
-- ----------------------------
ALTER TABLE [dbo].[singleItemOrder] ADD CONSTRAINT [order_id] FOREIGN KEY ([order_id]) REFERENCES [orders] ([id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[singleItemOrder] ADD CONSTRAINT [tshirt_id] FOREIGN KEY ([tshirt_id]) REFERENCES [tshirts] ([id]) ON DELETE NO ACTION ON UPDATE CASCADE
GO


-- ----------------------------
-- Foreign Keys structure for table tshirts
-- ----------------------------
ALTER TABLE [dbo].[tshirts] ADD CONSTRAINT [style_id] FOREIGN KEY ([style_id]) REFERENCES [styles] ([id]) ON DELETE NO ACTION ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[tshirts] ADD CONSTRAINT [company_id] FOREIGN KEY ([company_id]) REFERENCES [companies] ([id]) ON DELETE NO ACTION ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[tshirts] ADD CONSTRAINT [color_id] FOREIGN KEY ([color_id]) REFERENCES [colors] ([id]) ON DELETE NO ACTION ON UPDATE CASCADE
GO

