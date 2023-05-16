create database dtbs_fazenda;
use dtbs_fazenda;
select*from tb_cad_plantio;
create table tb_add_talhao(
id_talhao smallint auto_increment primary key NOT NUll,
nome_talhao varchar(50) NOT NULL,
cult_atual varchar(50) NOT NULL,
cult_ultima varchar(50) NOT NULL,
area_talhao varchar(50) NOT NULL,
qualidade_solo varchar(50) NOT NULL,

id_adm smallint
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


create table tb_cad_plantio(
id_plantio smallint auto_increment primary key NOT NULL,
nome_talhao varchar(50) NOT NULL,
cultura varchar(50) NOT NULL,
variedade varchar(50) NOT NULL,
qtd_fertilizante varchar(50) NOT NULL,
plantas_metro varchar(50) NOT NULL,
plantas_ha varchar(50) NOT NULL,
espacamento varchar(50) NOT NULL, 
data_plantio datetime NOT NULL,

id_adm smallint
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

create table tb_cad_aplicacoes(
id_aplicacao smallint auto_increment primary key NOT NULL,
defensivo varchar(50) NOT NULL,
finalidade varchar(100) NOT NULL,
principio_ativo varchar(50) NOT NULL,
modo_acao varchar(50) NOT NULL,
dosagem_ha varchar(50) NOT NULL,
data_aplicacao datetime NOT NULL,

id_adm smallint
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


create table tb_adm(
id_adm smallint auto_increment primary key NOT NULL,
nome_log varchar(50) NOT NULL,
senha_log varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;