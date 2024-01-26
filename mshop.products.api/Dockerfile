#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["mshop.products.api/mshop.products.api.csproj", "mshop.products.api/"]
COPY ["mshop.products.application/mshop.products.application.csproj", "mshop.products.application/"]
COPY ["mshop.products.domain/mshop.products.domain.csproj", "mshop.products.domain/"]
COPY ["mshop.products.infrastructure/mshop.products.infrastructure.csproj", "mshop.products.infrastructure/"]
RUN dotnet restore "./mshop.products.api/./mshop.products.api.csproj"
COPY . .
WORKDIR "/src/mshop.products.api"
RUN dotnet build "./mshop.products.api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./mshop.products.api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "mshop.products.api.dll"]