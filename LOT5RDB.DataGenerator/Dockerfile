FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LOT5RDB.DataGenerator/LOT5RDB.DataGenerator.csproj", "LOT5RDB.DataGenerator/"]
RUN dotnet restore "LOT5RDB.DataGenerator/LOT5RDB.DataGenerator.csproj"
COPY . .
WORKDIR "/src/LOT5RDB.DataGenerator"
RUN dotnet build "LOT5RDB.DataGenerator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LOT5RDB.DataGenerator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LOT5RDB.DataGenerator.dll"]
