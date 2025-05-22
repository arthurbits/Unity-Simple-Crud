
# Projeto Simples de CRUD 

A ideia é exemplificar de maneira simples como se utiliza um banco de dados local em um projeto Unity , com as funcões de cadastrar, listar, listar, excluir e buscar por id, mas neste exemplo a busca foi pelo nome.


## Instalação

Basta copiar o código do arquivo C# e a estrutura apresentada nas imagens.


    
## Screenshots

Como a Tela deve ficar.

![Tela de Desenvolvimento](https://github.com/arthurbits/Unity-Simple-Crud/blob/416e090415d3f2131a2334c21b3a0fc2db380f28/TelaUnity.png)

A tela em execução.

![Tela de Execução](https://github.com/arthurbits/Unity-Simple-Crud/blob/416e090415d3f2131a2334c21b3a0fc2db380f28/TelaBasica.png)

* Aqui os arquivos cadastrados ficam fica na lblList.   
* Para buscar basta digitar na inpBuscar.
* Botão alterar modifica o cadastro que fica na barra inpNome após a busca.

## Deploy

Para realizar deve-se prestar atenção no código da linha 19;
dbName = "URI=file:" + Application.dataPath + "/StreammingAssets/dbDesabrocha.db";

* Por estar em uma pasta StreammingAssets o Unity traz esta pasta ao fazer o deploy.
* Caso tenha problemas pode setar junto a pasta do executavel e utilizando o Application.persistentDataPath+"/nomeBancoDeDados.db"
