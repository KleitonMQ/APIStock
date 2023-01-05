<h2>Projeto com finalidade de estudo e prática.</h2>

<h3>A API possui um sistema de cadastro de itens de estoque. </h3>
<img src="src/Screenshots/swagger.png" alt="">
<p>Assim, pode ser cadastrado o nome do produto e a quantidade dele.</p>
<img src="src/Screenshots/post.png" alt="">
<p>É possível atualizar a quantidade de produtos em estoque buscando pelo nome do produto.</p>
<img src="src/Screenshots/put.png" alt="">
<p>Por fim o usuário também pode fazer uma pesquisa se determinado item está cadastrado no banco de dados, ou visualizar todos os produtos cadastrados.</p>
<img src="src/Screenshots/search.png" alt="">

<h3>Necessário para testar em sua máquina.</h3>

<p>1- Instalar pacote de ferramentas do Entity Framework na máquina:</p>
<p>dotnet tool install --global dotnet-ef</p>
<p>2- Instalar o suporte para criação de tabelas dentro do projeto:</p>
<p>dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.1</p>
<p>3- Instalar o suporte a conexão com banco de dados e gerenciamento dos códigos dentro do projeto (se for utilizar o SQLServer): </p>
<p>dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.1</p>
<p></p>
<p>4- Por fim, criar o banco de dados local no CLI da IDE:</p>
<p>dotnet ef database update</p>