# DojoFitcard
API que provê serviços de cadastro de Categorias e Estabelecimentos.

Observações:

1. Criar banco de dados de acordo com a estrutura proposta na Domain.

2. Preencher os dados de conexão ao banco no web.config

<add name="NomeBanco" connectionString="server=HostBanco; user id=UsuarioBanco; pwd=SenhaBanco; persistsecurityinfo=true; database=NomeBanco; convert zero datetime=True" providerName="System.Data.SqlClient" />

3. Em DojoFitcard.Data.Database preencher com o nome do banco.

4. A classe Database está configurada para consumir um banco de dados MySQL.


