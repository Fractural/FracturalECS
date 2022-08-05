# FracturalEntitasECS

![Deploy](https://github.com/Fractural/FracturalEntitasECS/actions/workflows/deploy.yml/badge.svg) ![Unit Tests](https://github.com/Fractural/FracturalEntitasECS/actions/workflows/tests.yml/badge.svg)

Godot C# ECS implemented using Entitas Pure ECS. 

## Installation

1. Download the latest release
2. Edit your `.csproj` file to include the Entitas DLLs as follows:
 
```XML
<Project Sdk="...">

  ...

  <!-- COPY AND PASTE THE STUFF BELOW BETWEEEN THE PROJECT TAGS -->
  <ItemGroup>
    <Reference Include="Entitas">
      <HintPath>addons/FracturalEntitasECS/Entitas.dll</HintPath>
    </Reference>
      <Reference Include="Entitas.CodeGeneration.Attributes">
        <HintPath>addons/FracturalEntitasECS/Entitas.CodeGeneration.Attributes.dll</HintPath>
    </Reference>
  </ItemGroup>
  <!-- STOP HERE -->
  
  ...

</Project>
```