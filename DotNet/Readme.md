# .Net Framework

O .NET Framework é uma iniciativa da empresa Microsoft, que visa uma plataforma única para desenvolvimento e execução de sistemas e aplicações. Todo e qualquer código gerado para .NET pode ser executado em qualquer dispositivo que possua um framework de tal plataforma

## Instalar o .Net 5 no Windows

- Abrir o link https://dotnet.microsoft.com/download
- Clicar em **Download .Net SDK x64** e executar o arquivo 
  >Faz-se necessária a instalação do VisualStudio para total usufruto do framework
  >Mais informações no link *https://visualstudio.microsoft.com/pt-br/downloads/*
  >
## Criar um projeto utilizando o Terminal

- Digitar ``dotnet new console -n NovoProjeto`` no terminal
  > O comando "new console" cria um projeto baseado no template "console"
  > Para mais informações, digite ``--help`` após o comando que desejar

- Para executar o projeto, digite ``dotnet build`` e em seguida ``dotnet run``
