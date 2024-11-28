FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

ARG BUILD_CONFIGURATION=Debug

COPY ["src/CommunitySafety.WebUI/CommunitySafety.WebUI.csproj", "src/CommunitySafety.WebUI/"]
COPY ["src/CommunitySafety.Infrastructure.IoC/CommunitySafety.Infrastructure.IoC.csproj", "src/CommunitySafety.Infrastructure.IoC/"]
COPY ["src/CommunitySafety.Application/CommunitySafety.Application.csproj", "src/CommunitySafety.Application/"]
COPY ["src/CommunitySafety.Domain/CommunitySafety.Domain.csproj", "src/CommunitySafety.Domain/"]
COPY ["src/CommunitySafety.Infrastructure/CommunitySafety.Infrastructure.csproj", "src/CommunitySafety.Infrastructure/"]
RUN dotnet restore "./src/CommunitySafety.WebUI/CommunitySafety.WebUI.csproj"

COPY . .
WORKDIR "/app/src/CommunitySafety.WebUI"
RUN dotnet build "./CommunitySafety.WebUI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Debug
RUN dotnet publish "./CommunitySafety.WebUI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CommunitySafety.WebUI.dll"]