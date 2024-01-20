# Dockerfile for RepositoryPattern.WebAPI

# Use the official ASP.NET Core runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Use the official .NET SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy the solution and restore dependencies
COPY RepositoryPattern.sln ./
COPY RepositoryPattern.WebAPI/RepositoryPattern.WebAPI.csproj RepositoryPattern.WebAPI/
RUN dotnet restore RepositoryPattern.WebAPI/RepositoryPattern.WebAPI.csproj

# Copy the rest of the application code and build it
COPY . .
WORKDIR /src/RepositoryPattern.WebAPI
RUN dotnet build RepositoryPattern.WebAPI.csproj -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish RepositoryPattern.WebAPI.csproj -c Release -o /app/publish

# Use the runtime image for the final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RepositoryPattern.WebAPI.dll"]
