# FracturalECS

![Deploy](https://github.com/Fractural/FracturalECS/actions/workflows/deploy.yml/badge.svg) ![Unit Tests](https://github.com/Fractural/FracturalECS/actions/workflows/tests.yml/badge.svg)

ECS framework in Godot C# that wraps around Svelto.ECS. 

## Installation

1. Add `FracturalECS` and `FracturalCommons` to the addons folder
2. Edit your project's `.csproj` file to look like this

```XML
<Project>

...

  <!-- Required for FracturalECS  -->
  <PropertyGroup>
	  <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="System.Runtime.CompilerServices.Unsafe" Version="6.0.0" />
  </ItemGroup>
  <!-- Required for FracturalECS  -->

...

</Project>
```