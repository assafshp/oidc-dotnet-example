dotnet new webapi -o secure-api -f net6.0
cd secure-api
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 6.0.15
dotnet run
dotnet watch run


dotnet dev-certs https --trust
dotnet add package Microsoft.AspNetCore.Authentication.Certificate --version 6.0.15