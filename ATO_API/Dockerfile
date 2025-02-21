
# Use official .NET image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
 WORKDIR /app
 EXPOSE 5000
 EXPOSE 5001

 # Build ứng dụng với .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
 ARG BUILD_CONFIGURATION=Development
 WORKDIR /src
 # Copy everything
 COPY . .

 # Install EF Tools
RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"

# Install EF Core Design package
WORKDIR "/src/ATO_API"
RUN dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.11
RUN dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.11
RUN dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 8.0.11
RUN dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.11
RUN dotnet add package Microsoft.Extensions.Configuration.Json --version 8.0.1

RUN dotnet tool restore
#RUN dotnet ef database update 

 # Restore and build the application
 RUN dotnet restore "./ATO_API.csproj"
 WORKDIR "/src/ATO_API"
 RUN dotnet build "./ATO_API.csproj" -c $BUILD_CONFIGURATION -o /app/build


 # Publish ứng dụng
 FROM build AS publish
 ARG BUILD_CONFIGURATION=Development
 RUN dotnet publish "./ATO_API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final 
WORKDIR /app
COPY --from=publish /app/publish .

# Apply EF migrations before starting the app
CMD ["dotnet", "ATO_API.dll"]
