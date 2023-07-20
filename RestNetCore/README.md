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

Usando Vo(Value Object) para as estruturas imutáveis que compoe entidades de negócio, concentrando regras e removendo a necessidade de reescrita de código, e parecido com o DTO, porem o VO é um objeto que tem um valor na aplicação

Usando HATEOAS - (hypermedia as the Engine of Application state) - A hipermídia como o mecanismo do estado do aplicativo
O HATEOAS e uma especie de guia de recursos da Api, e os principais recursos tanto parta ir ou retornar informações
Resumindo, HATEOAS ajudar os clientes a consumirem o serviço sem a necessidade de conhecimento prévio profundo da API.

CORS - é um mecanismo que permite que recursos restritos em uma página da web sejam recuperados por outro domínio fora do domínio ao qual pertence o recurso que será recuperado.

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