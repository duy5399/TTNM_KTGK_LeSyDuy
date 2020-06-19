use master
drop Database QLDLGiuaKy
--Tao CSDL
create database QLDLGiuaKy
GO
use QLDLGiuaKy
GO

CREATE TABLE PRODUCT
(
	ID int identity(1,1) NOT NULL,
	Code varchar(50) NOT NULL,
	Name varchar(50) NOT NULL,
	ShortName varchar(50) NOT NULL,
	Note varchar(50) NOT NULL,
	CategoryID int NOT NULL
	CONSTRAINT PK_PRODUCT PRIMARY KEY(ID)
	CONSTRAINT FK_PRODUCT_CATEGORY FOREIGN KEY (CategoryID) REFERENCES CATEGORY(ID)
)


CREATE TABLE CATEGORY
(
	ID int identity(1,1) NOT NULL,
	Name varchar(50) NOT NULL,
	Note varchar(50) NOT NULL
	CONSTRAINT PK_CATEGORY PRIMARY KEY(ID)
)