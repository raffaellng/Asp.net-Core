# Asp.net-Core
Estudo asp.net

Usando a arquitetura ----

Usando Migrations
Ferramentas usadas
 - Evolve (Inspirtado no Flyway do Java)
 - Serilog (Log .NET simples com eventos totalmente estruturados)
 - Serilog.AspNetCore (Suporte Serilog para log ASP.NET Core)
 - Serilog.sinks.Console (Um coletor Serilog que grava eventos de log no console/terminal.)

Usando Projetos Generic Repository

Usando Vo(Value Object) para as estruturas imut�veis que compoe entidades de neg�cio, concentrando regras e removendo a necessidade de reescrita de c�digo, e parecido com o DTO, porem o VO � um objeto que tem um valor na aplica��o

Usando HATEOAS - (hypermedia as the Engine of Application state) - A hiperm�dia como o mecanismo do estado do aplicativo
O HATEOAS e uma especie de guia de recursos da Api, e os principais recursos tanto parta ir ou retornar informa��es
Resumindo, HATEOAS ajudar os clientes a consumirem o servi�o sem a necessidade de conhecimento pr�vio profundo da API.

CORS - � um mecanismo que permite que recursos restritos em uma p�gina da web sejam recuperados por outro dom�nio fora do dom�nio ao qual pertence o recurso que ser� recuperado.

JWTBearer - para fazer autenttication de token



ESTRUTURA
- cria primeiro o Model
- adiciona a classe criada no model na classe de MySQLContext para fazer funcionar as migrations
- Criar a classe Repository e Interface do repository
- Crie a classVO
- Crie a Bussines
- 




Usuario
raffaell
senha
admin123