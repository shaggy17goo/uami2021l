#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Doctors.Web/Doctors.Web.csproj", "Doctors.Web/"]
COPY ["Doctors.Domain/Doctors.Domain.csproj", "Doctors.Domain/"]
COPY ["Doctors.Infrastructure/Doctors.Infrastructure.csproj", "Doctors.Infrastructure/"]
RUN dotnet restore "Doctors.Web/Doctors.Web.csproj"
COPY . .
WORKDIR "/src/Doctors.Web"
RUN dotnet build "Doctors.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Doctors.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Doctors.Web.dll"]