use DataDocument;

create table Users
(
Id integer identity(1,1)  not null,
UserLogin varchar(50) not null,
USerPassword varchar(50) not null
Constraint prim_key_users primary key (Id)
);

create table Documents
(
Id integer identity(1,1) not null,
Name varchar(50) not null,
DateOfCreation datetime not null,
UserId integer not null,
Document varbinary(max) not null,
Constraint prim_key_doc primary key (Id),
Constraint foreign_key_users foreign key (UserId) references Users(Id)
);

insert into Users (UserLogin, UserPassword)
values ('foktov', 1234);