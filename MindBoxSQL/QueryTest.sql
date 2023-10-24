CREATE DATABASE MindBoxTest

GO

USE MindBoxTest

GO

CREATE TABLE Products(
	ProductId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ProductName NVARCHAR(50),
	[Description] NVARCHAR(500)

)
GO

CREATE TABLE Categories(
	CategoryId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	CategoryName NVARCHAR(200),
	[Description] NVARCHAR(500)
)
GO

CREATE TABLE PdoductCategoryss(
	Product_Id INT ,
	Category_Id INT,
	Primary KEY(Product_Id,Category_Id),
	FOREIGN KEY (Product_Id) REFERENCES Products(ProductId),
    FOREIGN KEY (Category_Id) REFERENCES Categories(CategoryId)
)

GO

SELECT
    P.ProductName,
	C.CategoryName
	FROM Products P
	LEFT JOIN PdoductCategoryss PC ON P.ProductId = PC.Product_Id
	LEFT JOIN Categories C ON PC.Category_Id = C.CategoryId
	ORDER BY P.ProductName;
