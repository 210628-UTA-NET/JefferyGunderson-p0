Create table StoreFront
(
    store_Id int identity,
    Storename varchar(40),
    AddressLine1 varchar(40),
    AddressLine2 varchar(40),
    City varchar(40),
    StoreState varchar(40),
    ZipCode varchar(5),
    inventory varchar(40),
    primary key (store_Id)
)

Create table Customer
(
    Customer_Id int identity,
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
    product_Id int identity,
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





