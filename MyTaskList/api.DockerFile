FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY *.sln ./
COPY ./src/ApiMyTask/ApiMyTask.csproj /src/src/ApiMyTask/
COPY ./src/Dev.Business/Dev.Business.csproj /src/src/Dev.Business/
COPY ./src/Dev.Data/Dev.Data.csproj /src/src/Dev.Data/
RUN dotnet restore
COPY . .
WORKDIR /src/
RUN dotnet build -c Release -o /app

FROM build AS Publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app/ .
ENTRYPOINT ["dotnet", "ApiMyTask.dll"]

#comando terminal para gerar a imagem e rodar o docker
# docker build -t aspnetcoreapp -f api.DockerFile .
#comando que estara criando a img docker com o nome webapp_bazar e olhando para o arquivo .dockefile no diretorio de trabalho com nome Barca

# docker run --rm -it -p 4201:4200 aspnetcoreapp
#estara rodando o docker respondendo na porta 4201 da maquina mas 4200 no docker