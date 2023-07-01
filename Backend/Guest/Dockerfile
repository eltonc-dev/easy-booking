# Base image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

ENV ASPNETCORE_ENVIRONMENT="Development"
# Set the working directory inside the container
WORKDIR /app

# Copy the project files to the container
COPY . ./

WORKDIR /app/GuestWeb

# Restaurar as dependências do projeto
RUN dotnet restore

# Publish the application
RUN dotnet publish -c Release -o out

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0

# Set the working directory inside the container
WORKDIR /app/GuestWeb

# Copy the published output from the build container to the runtime container
COPY --from=build /app/GuestWeb/out ./

# Expose the port that the application will listen on
EXPOSE 5000

# Set the entry point for the container
ENTRYPOINT ["dotnet", "GuestWeb.dll", "--urls", "http://0.0.0.0:5000"]
