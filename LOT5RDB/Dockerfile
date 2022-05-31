FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LOT5RDB/LOT5RDB.csproj", "LOT5RDB/"]
RUN dotnet restore "LOT5RDB/LOT5RDB.csproj"
COPY . .
WORKDIR "/src/LOT5RDB"
RUN dotnet build "LOT5RDB.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LOT5RDB.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LOT5RDB.dll"]
