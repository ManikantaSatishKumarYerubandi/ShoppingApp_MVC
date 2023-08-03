create table productList( 
pID int primary key,
pName varchar(20),
pCategory varchar(20),
pPrice int, 
pIsInStock bit
)



insert into productList values(1,'Pepsi','Cold-Drink',200,1)
insert into productList values(2,'Iphone','Smart Phone',40000,0)
insert into productList values(3,'Orange','Fruit',200,1)


Select * from productList