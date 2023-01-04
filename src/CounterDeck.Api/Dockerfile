FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
#
# copy csproj and restore as distinct layers
COPY *.sln .
COPY src/CounterDeck.Api/*.csproj ./CounterDeck.Api/
COPY src/CounterDeck.Application/*.csproj ./CounterDeck.Application/
COPY src/CounterDeck.Infrastructure/*.csproj ./CounterDeck.Infrastructure/
COPY src/CounterDeck.Contracts/*.csproj ./CounterDeck.Contracts/
COPY src/CounterDeck.Domain/*.csproj ./CounterDeck.Domain/
#
RUN dotnet restore
#
# copy everything else and build app
COPY src/CounterDeck.Api/. ./CounterDeck.Api/
COPY src/CounterDeck.Application/. ./CounterDeck.Application/
COPY src/CounterDeck.Infrastructure/. ./CounterDeck.Infrastructure/
COPY src/CounterDeck.Contracts/. ./CounterDeck.Contracts/
COPY src/CounterDeck.Domain/. ./CounterDeck.Domain/
#
WORKDIR /app/CounterDeck
RUN dotnet publish -c Release -o out
#
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
#
COPY --from=build /app/CounterDeck/out ./
ENTRYPOINT ["dotnet", "CounterDeck.Api.dll"]