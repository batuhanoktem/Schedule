FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Schedule.Api/Schedule.Api.csproj", "Schedule.Api/"]
RUN dotnet restore "Schedule.Api/Schedule.Api.csproj"
COPY . .
WORKDIR "/src/Schedule.Api"
RUN dotnet build "Schedule.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Schedule.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Schedule.Api.dll"]