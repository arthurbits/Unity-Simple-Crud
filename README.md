
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


## Considerações Finais

Mesmo sendo simples o exemplo, se tem uma certa dificuldade de encontrar alguns materiais específicos na internet e para chegar em algumas soluções, então,  precisamos sempre pegar um pouco de cada conteúdo e criar nossa propria solução. 
O foco aqui foi apenas o exemplo mais simples que eu pude criar, por enquanto de um CRUD com banco de dados local.



# Simple CRUD Project

The idea is to exemplify in a simple way how to use a local database in a Unity project, with the functions of registering, listing, listing, deleting and searching by id, but in this example the search was by name.


## Installation

Just copy the code from the C# file and the structure shown in the images.

    
## Screenshots

How the Screen should look.

![Tela de Desenvolvimento](https://github.com/arthurbits/Unity-Simple-Crud/blob/416e090415d3f2131a2334c21b3a0fc2db380f28/TelaUnity.png)

The running screen.

![Tela de Execução](https://github.com/arthurbits/Unity-Simple-Crud/blob/416e090415d3f2131a2334c21b3a0fc2db380f28/TelaBasica.png)

* Here the registered files are in the lblList.   
* To search, just type in inpBuscar.
* Change button modifies the registration that appears in the inpNome bar after the search.

## Deploy

To do this, you must pay attention to the code on line 19.
dbName = "URI=file:" + Application.dataPath + "/StreammingAssets/dbDesabrocha.db";

* Because it is in a StreammingAssets folder, Unity brings this folder when deploying.
* If you have problems, you can set it next to the executable folder and use Application.persistentDataPath+"/databasename.db"
