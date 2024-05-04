# Library API

Para iniciar esse projeto, será necessário instalar os seguintes pacotes:

1) Esse pacote possui ferramentas para conexão com o banco de dados.
````shell
dotnet add package Microsoft.EntityFrameworkCore --version 9.0.0-preview.3.24172.4
````

````shell
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 9.0.0-preview.1
````

````shell
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.0-preview.3.24172.4
````
````shell
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 9.0.0-preview.3.24172.4
````
Após ter criado suas models, é hora de joga-las no banco de dados, para isso rode o seguinte comando:

````shell
dotnet ef migrations add InitialCreate
````
````shell
dotnet ef database update
````


Lembre-se de instalar o pacote para rodar as migration

````shell
dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.0-preview.3.24172.4
````


Agora vamos tratar do Mapper, começamos instalando o mesmo:

````shell
dotnet add package AutoMapper --version 13.0.1
````

````shell
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.0
````

Obs: o mapper serve para efetuar o mapeamento entre a model e os dados recebidos/enviados dos usuários. É importante lembrar de que com mapper evitamos exibir nossa model ao mundo.

