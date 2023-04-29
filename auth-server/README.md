dotnet new webapi -o auth-server -f net6.0
cd auth-server
dotnet add package IdentityServer4 --version 4.1.2
dotnet watch run
dotnet run
