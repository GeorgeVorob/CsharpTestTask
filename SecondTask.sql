CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(MAX) NOT NULL
);

CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName VARCHAR(MAX) NOT NULL
);

CREATE TABLE ProductCategories (
    ProductID INT,
    CategoryID INT,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
    PRIMARY KEY (ProductID, CategoryID)
);

INSERT INTO Products (ProductName) VALUES
('Product 1'),
('Product 2'),
('Product 3'),
('Product 4');

INSERT INTO Categories (CategoryName) VALUES
('Category 1'),
('Category 2'),
('Category 3');

-- Отношение многое ко многим
INSERT INTO ProductCategories (ProductID, CategoryID) VALUES
(1, 1),
(1, 2),
(2, 2),
(3, 3);

SELECT 
    p.ProductName AS ProductName,
    c.CategoryName AS ProductCategory
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID
ORDER BY 
    p.ProductName, 
    c.CategoryName;
