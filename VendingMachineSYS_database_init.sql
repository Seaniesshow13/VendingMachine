--CREATE TABLE menuItems(
--    itemName Varchar2(20),
--    price Decimal(3, 2)
--);

DROP TABLE orders;
DROP TABLE menu;
DROP TABLE Categories;

CREATE TABLE Categories(
    CatID Numeric(4),
    Name Varchar2(20),
    Description Varchar2(50),
    CONSTRAINT Primary_cID PRIMARY KEY(CatID)
);

CREATE TABLE menu(
    menuID Numeric(4),
    name Varchar2(20),
    Price Decimal(3, 2),
    Description Varchar(50),
    CatID Numeric(4),
    Calories Decimal(3, 2),
    CONSTRAINT Primary_mID PRIMARY KEY(menuID),
    CONSTRAINT Foreign_cID FOREIGN KEY(CatID) REFERENCES Categories
);

CREATE TABLE orders(
    oID Numeric(4),
    orderNumber Numeric(4),
    menuID Numeric(4),
    CONSTRAINT Primary_oID PRIMARY KEY(oID),
    CONSTRAINT Foreign_mID FOREIGN KEY(menuID) REFERENCES menu
);