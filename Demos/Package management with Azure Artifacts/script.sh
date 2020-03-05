dotnet pack --output pkg

dotnet nuget push .\pkg\Phonetic.Speller.1.0.0.nupkg --source <feed> --api-key - --interactive

dotnet nuget push .\pkg\pspell.1.0.0.nupkg --source <feed> --api-key - --interactive