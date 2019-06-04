DROP TABLE remedios
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

INSERT INTO remedios (nome)
    VALUES 
('clonazepam');

SELECT nome FROM remedios;
	