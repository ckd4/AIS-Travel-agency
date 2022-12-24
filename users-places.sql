create table users
(login nvarchar(30) primary key not null,
password nvarchar(50) not null)

Insert into users
values
('sa', '12345'),
('admin', 'admin');

create table places
(city nvarchar(50) Primary key,
hotel nvarchar(50),
price int null,
picture nvarchar(150) null)

insert into places
values
('Paris','Greatest', 1000, 'paris.jpg'),
('Mahal','Maneki Hotel', 2590, 'mahal.jpg'),
('Rome','Noori', 549, 'colizei.jpg'),
('Italy','Pizan Hotel', 4500, 'ptower.jpg'),
('New Zealand','Waterfall', 1800, 'mucan.jpg');

