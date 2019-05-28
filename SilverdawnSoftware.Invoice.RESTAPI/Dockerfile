FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 30000
EXPOSE 11111

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["SilverdawnSoftware.Invoice.RESTAPI/SilverdawnSoftware.Invoice.RESTAPI.csproj", "SilverdawnSoftware.Invoice.RESTAPI/"]
RUN dotnet restore "SilverdawnSoftware.Invoice.RESTAPI/SilverdawnSoftware.Invoice.RESTAPI.csproj"
COPY . .
WORKDIR "/src/SilverdawnSoftware.Invoice.RESTAPI"
RUN dotnet build "SilverdawnSoftware.Invoice.RESTAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SilverdawnSoftware.Invoice.RESTAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SilverdawnSoftware.Invoice.RESTAPI.dll"]