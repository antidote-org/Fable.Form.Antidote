# Fable.Form.Antidote
Github Repo [link](https://github.com/antidote-org/Fable.Form.Antidote)

## Overview

Extension for new (opinionated) Fable.Forms fields outside of the base HTML form fields. These fields were created for Antidote.FormStudio, but can be used to extend Fable.Forms in a stand-alone fashion. Also note, that this repo adds the "form field functionality" and you can create the appropriate views yourself (conforming to the Fable.Forms philosophy). If you want a read-made solution, there is a separate repo that adds the Feliz.Bulma "implementation views".


## Installation

```
## using nuget
dotnet add package Fable.Form.Antidote
```

## or with paket

```
paket add Fable.Form.Antidote --project /path/to/project.fsproj
```


## To publish

*For maintainers only*

```ps1
cd Fable.Form.Antidote
dotnet pack -c Release
dotnet nuget push .\bin\Release\Fable.Form.Antidote.X.X.X.snupkg -s nuget.org -k <nuget_key>
dotnet nuget push .\bin\Release\Fable.Form.Antidote.X.X.X.nupkg -s nuget.org -k <nuget_key>
```
