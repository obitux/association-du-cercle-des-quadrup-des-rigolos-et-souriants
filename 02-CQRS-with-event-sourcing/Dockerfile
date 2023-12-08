FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["02-CQRS-with-event-sourcing/02-CQRS-with-event-sourcing.csproj", "02-CQRS-with-event-sourcing/"]
RUN dotnet restore "02-CQRS-with-event-sourcing/02-CQRS-with-event-sourcing.csproj"
COPY . .
WORKDIR "/src/02-CQRS-with-event-sourcing"
RUN dotnet build "02-CQRS-with-event-sourcing.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "02-CQRS-with-event-sourcing.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "02-CQRS-with-event-sourcing.dll"]
