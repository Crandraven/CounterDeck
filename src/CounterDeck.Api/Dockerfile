FROM mcr.microsoft.com/dotnet/aspnet:6.0 as base
WORKDIR /app
EXPOSE 80
EXPOSE 443
#
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
#
# copy csproj and restore as distinct layers
#COPY ["../CounterDeck.sln", "."]
COPY ["src/CounterDeck.Api/CounterDeck.Api.csproj", "./CounterDeck.Api/"]
COPY ["src/CounterDeck.Application/CounterDeck.Application.csproj", "./CounterDeck.Application/"]
COPY ["src/CounterDeck.Infrastructure/CounterDeck.Infrastructure.csproj", "./CounterDeck.Infrastructure/"]
COPY ["src/CounterDeck.Contracts/CounterDeck.Contracts.csproj", "./CounterDeck.Contracts/"]
COPY ["src/CounterDeck.Domain/*.csproj", "./CounterDeck.Domain/"]
#
RUN dotnet restore "src/CounterDeck.Api/CounterDeck.Api.csproj"
#
# copy everything else and build app
COPY ["src/CounterDeck.Api/.", "./CounterDeck.Api/"]
COPY ["src/CounterDeck.Application/.", "./CounterDeck.Application/"]
COPY ["src/CounterDeck.Infrastructure/.", "./CounterDeck.Infrastructure/"]
COPY ["src/CounterDeck.Contracts/.", "./CounterDeck.Contracts/"]
COPY ["src/CounterDeck.Domain/.", "./CounterDeck.Domain/"]
#
WORKDIR /src/CounterDeck.Api
RUN dotnet build -c Release -o /app/build
#
FROM build as publish
RUN dotnet publish CounterDeck.Api.csproj -c publish -o /app/publish
#
FROM base AS runtime
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CounterDeck.Api.dll"]