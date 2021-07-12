
--Will create table called StoreFront
Create table StoreFront
(
    store_id int,
    name varchar(40),
    AddressLine1 varchar(40),
    AddressLine2 varchar(40),
    City varchar(40),
    State varchar(40),
    ZipCode varchar(5),
    inventory varchar(40),
    Primary Key (store_Id)

);
-- Will create table called Customer
Create table Customer
(
    Customer_Id int,
    firstname varchar(40),
    lastname varchar(40),
    email varchar(50),
    addressLine1 varchar(50),
    addressLine2 varchar(50),
    City varchar(40),
    State varchar(40),
    orderlist varchar(40),
    Primary Key (Customer_Id)

);
-- Will create table called Orders
create table Orders
(
    Order_Id int identity,
    lineitems varchar(40),
    location varchar(40),
    totalprice decimal
        primary key (Order_Id)
);
--Will create table called LineItems
Create table LineItems
(
    product_Id varchar(40),
    quantity int
);


--Will create table called Products
create table Products
(
    product_Id int,
    name varchar(40),
    price decimal,
    decription varchar(80),
    Primary Key (product_Id)
)

drop table Storefront;
drop table Customer;
drop table Orders;
drop table LineItems;
drop table Products;


--StoreFront many to many relationship with LineItems:--
--Join table--
create table StoreFront_LineItems
(
    LineItem_Store_Id int references StoreFront(Store_Id),
    LineItem_Id int references LineItems(LineItem_Id)
);
--LineItems many to many relationship with Products:--
--Join table--
create table LineItem_Products
(
    LineItem_Product_Id int references Products(Product_Id),
    Product_Id int references LineItems(LineItem_Id)
);
--LineItems many to many relationship with Orders:--
--Join table--
create table LineItem_Orders
(
    LineItem_Id int references Orders(Order_Id),
    Order_Id int references LineItems(LineItem_Id)
);



