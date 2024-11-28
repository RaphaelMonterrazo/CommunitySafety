FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ./src/CommunitySafety.Application/CommunitySafety.Application.csproj ./src/CommunitySafety.Application/
COPY ./src/CommunitySafety.Domain/CommunitySafety.Domain.csproj ./src/CommunitySafety.Domain/
COPY ./src/CommunitySafety.Infrastructure/CommunitySafety.Infrastructure.csproj ./src/CommunitySafety.Infrastructure/
COPY ./src/CommunitySafety.Infrastructure.IoC/CommunitySafety.Infrastructure.IoC.csproj ./src/CommunitySafety.Infrastructure.IoC/
COPY ./src/CommunitySafety.WebUI/CommunitySafety.WebUI.csproj ./src/CommunitySafety.WebUI/

RUN dotnet restore ./src/CommunitySafety.WebUI/CommunitySafety.WebUI.csproj

COPY ./src ./src

RUN dotnet publish ./src/CommunitySafety.WebUI/CommunitySafety.WebUI.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
EXPOSE 8081
ENTRYPOINT ["dotnet", "CommunitySafety.WebUI.dll"]