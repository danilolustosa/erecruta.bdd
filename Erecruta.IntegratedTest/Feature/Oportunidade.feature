Funcionalidade: Oportunidade
	Testes integrados das funcionalidade relacionadas ao end-point Oportunidade


Esquema do Cenario: Listar Oportunidades
	Dado que o endpoint é 'Oportunidade/listar'
	E que o método http é 'GET'
	Quando obter a oportunidade
	Então a resposta será 200


Esquema do Cenario: Obter Oportunidade inexistente
	Dado que o endpoint é 'Oportunidade/obter'
	E que o método http é 'GET'
	E que o id é <id>
	Quando obter a oportunidade
	Então a resposta será <resposta>

	Exemplos: 
		| id | resposta |
		| 1  | 404      |
		| 2  | 200      |
