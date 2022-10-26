FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/MyCollege.Web.Host/MyCollege.Web.Host.csproj", "src/MyCollege.Web.Host/"]
COPY ["src/MyCollege.Web.Core/MyCollege.Web.Core.csproj", "src/MyCollege.Web.Core/"]
COPY ["src/MyCollege.Application/MyCollege.Application.csproj", "src/MyCollege.Application/"]
COPY ["src/MyCollege.Core/MyCollege.Core.csproj", "src/MyCollege.Core/"]
COPY ["src/MyCollege.EntityFrameworkCore/MyCollege.EntityFrameworkCore.csproj", "src/MyCollege.EntityFrameworkCore/"]
WORKDIR "/src/src/MyCollege.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/MyCollege.Web.Host", "src/MyCollege.Web.Host"]
COPY ["src/MyCollege.Web.Core", "src/MyCollege.Web.Core"]
COPY ["src/MyCollege.Application", "src/MyCollege.Application"]
COPY ["src/MyCollege.Core", "src/MyCollege.Core"]
COPY ["src/MyCollege.EntityFrameworkCore", "src/MyCollege.EntityFrameworkCore"]
WORKDIR "/src/src/MyCollege.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "MyCollege.Web.Host.dll"]
