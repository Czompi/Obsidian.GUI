dotnet publish -c Release -f net5.0 -r win-x64
dotnet publish -c Release -f net5.0 -r linux-x64
dotnet publish -c Release -f net5.0 -r osx-x64
dotnet msbuild -t:BundleApp -p:RuntimeIdentifier=osx-x64 -p:UseAppHost=true