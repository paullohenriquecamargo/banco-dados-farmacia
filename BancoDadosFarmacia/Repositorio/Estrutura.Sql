﻿DROP TABLE remedios
CREATE TABLE remedios (
	eh_generico BIT,
	nome VARCHAR(30),
	id INT PRIMARY KEY IDENTITY,
	categoria VARCHAR(30),
	eh_solido BIT,
	contra_indicacoes VARCHAR(30),
	bula VARCHAR(30),
	faixa VARCHAR(30),
	precisa_receita BIT
);
DROP TABLE cosmeticos
CREATE TABLE cosmeticos (
	id INT PRIMARY KEY IDENTITY,
	nome VARCHAR (30),
	valor DECIMAL(20,2),
	data_vencimento DATETIME2,
	quantidade INT,
	marca VARCHAR(15)
);
DROP TABLE produtos_higienicos
CREATE TABLE produtos_higienicos (
	id INT PRIMARY KEY IDENTITY,
	nome VARCHAR(20),
	categoria VARCHAR(25)
);



INSERT INTO cosmeticos(nome,quantidade) VALUES
   ('BB',2);


INSERT INTO remedios (nome, eh_generico, categoria, eh_solido, contra_indicacoes, bula, faixa, precisa_receita )
    VALUES 
('clonazepam',1 ,'antinflamatorio', 0, 'dengue', 'amarelo', 'preta', 0);

DELETE FROM remedios WHERE precisa_receita = 1;

SELECT * FROM cosmeticos;
	