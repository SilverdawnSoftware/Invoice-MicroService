FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443


FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["InvoiceRestAPI/InvoiceRestAPI.csproj", "InvoiceRestAPI/"]
RUN dotnet restore "InvoiceRestAPI/InvoiceRestAPI.csproj"
COPY . .
WORKDIR "/src/InvoiceRestAPI"
RUN dotnet build "InvoiceRestAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "InvoiceRestAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "InvoiceRestAPI.dll"]

