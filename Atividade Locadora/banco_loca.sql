use bancoLocadora

create table usuario(
	id_usuario int identity(1,1) primary key,
	nome varchar(50) not null,
	email varchar(60) not null,
	senha varchar(20) not null
)

insert into usuario values('Daniel','Daniel123@gmail.com','daniel123')

Select id_usuario from usuario where email = 'Daniel123@gmail.com' and senha = 'daniel123'

Update usuario set nome='Daniel' where id_usuario = 5

select * from usuario;

drop table usuario;

create table filmes(
	id_filme int identity(1,1) primary key,
	nome varchar(60) not null,
	data_lancamento varchar(11) not null,
	sinopse text not null,
	tempo varchar(5)not null,
	url_cartaz text not null
)

create table administrador(
	id_adm int identity(1,1) primary key,
	nome varchar(60) not null,
	usename varchar(30)not null,
	senha varchar(30) not null,
)

insert into administrador values ('','','');
























