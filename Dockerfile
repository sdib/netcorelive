FROM microsoft/dotnet:latest

WORKDIR /dotnetapp

# copy project.json and restore as distinct layers
COPY netcorelive.csproj .
RUN dotnet restore

#copy and build everything else
COPY . .
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/dotnetapp.dll"]