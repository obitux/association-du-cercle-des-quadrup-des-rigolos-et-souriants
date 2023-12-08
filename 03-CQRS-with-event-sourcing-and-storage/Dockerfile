FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["03-CQRS-with-event-sourcing-and-storage/03-CQRS-with-event-sourcing-and-storage.csproj", "03-CQRS-with-event-sourcing-and-storage/"]
RUN dotnet restore "03-CQRS-with-event-sourcing-and-storage/03-CQRS-with-event-sourcing-and-storage.csproj"
COPY . .
WORKDIR "/src/03-CQRS-with-event-sourcing-and-storage"
RUN dotnet build "03-CQRS-with-event-sourcing-and-storage.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "03-CQRS-with-event-sourcing-and-storage.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "03-CQRS-with-event-sourcing-and-storage.dll"]
