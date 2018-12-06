FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Couponize_Voucher_API/Couponize_Voucher_API.csproj", "Couponize_Voucher_API/"]
COPY ["VoucherDependencies/VoucherDependencies.csproj", "VoucherDependencies/"]
RUN dotnet restore "Couponize_Voucher_API/Couponize_Voucher_API.csproj"
COPY . .
WORKDIR "/src/Couponize_Voucher_API"
RUN dotnet build "Couponize_Voucher_API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Couponize_Voucher_API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Couponize_Voucher_API.dll"]