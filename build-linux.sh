# https://learn.microsoft.com/en-us/dotnet/core/rid-catalog
dotnet publish -c Release -r linux-x64
dotnet publish -c Release -r linux-musl-x64
dotnet publish -c Release -r linux-musl-arm64
dotnet publish -c Release -r linux-arm
dotnet publish -c Release -r linux-arm64
