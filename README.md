# dotnet-packages

## Publishing Packages to Github Packages
- https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-nuget-registry#publishing-a-package
- Package the project: `dotnet pack --configuration Release`
- Push to registry: `dotnet nuget push "bin/Release/{project}.{version}.nupkg"  --api-key YOUR_GITHUB_PAT --source "github"`