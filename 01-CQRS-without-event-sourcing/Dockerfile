FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["01-CQRS-without-event-sourcing/01-CQRS-without-event-sourcing.csproj", "01-CQRS-without-event-sourcing/"]
RUN dotnet restore "01-CQRS-without-event-sourcing/01-CQRS-without-event-sourcing.csproj"
COPY . .
WORKDIR "/src/01-CQRS-without-event-sourcing"
RUN dotnet build "01-CQRS-without-event-sourcing.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "01-CQRS-without-event-sourcing.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "01-CQRS-without-event-sourcing.dll"]
