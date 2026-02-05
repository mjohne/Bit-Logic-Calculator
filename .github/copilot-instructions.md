# Bit Logic Calculator - Copilot Onboarding Instructions

## Project Overview

**Bit Logic Calculator** is a Windows Forms desktop application written in C# that provides a graphical calculator for performing bitwise logical operations and bit manipulations. The application was last actively developed in 2019 and is currently being reinitialized for maintenance and updates.

### Technology Stack
- **Language**: C# (version 7.3)
- **Framework**: .NET Framework 4.0
- **Project Type**: Windows Forms Application (WinExe)
- **IDE**: Visual Studio 2019 (VisualStudioVersion 16.0.29519.181)
- **Build System**: MSBuild (via .csproj files)
- **License**: GNU General Public License v3.0

### Repository State
The repository has been recently cleaned up. The current master branch contains only metadata files (.gitignore, LICENSE, README.md, .gitattributes). The actual source code was removed during a cleanup process but is accessible in the git history (commit `67608ea00d3b41a1f935691add3748dfcbee01de` from December 2019).

## Project Structure

### Historical Project Layout (from 2019)
```
BitLogicCalculator/
├── BitLogicCalculator.sln          # Visual Studio solution file
├── BitLogicCalculator/             # Main project directory
│   ├── BitLogicCalculator.csproj   # C# project file
│   ├── Program.cs                  # Application entry point
│   ├── MainForm.cs                 # Main application form
│   ├── MainForm.Designer.cs        # Designer-generated UI code
│   ├── MainForm.resx               # Form resources
│   ├── ByteUnits.cs                # Byte/bit conversion utilities
│   ├── AboutBox.cs                 # About dialog
│   ├── StatisticsForm.cs           # Statistics dialog
│   ├── Properties/                 # Assembly metadata
│   └── packages.config             # NuGet package references
└── packages/                       # NuGet packages (not in source control)
```

### Current Repository Structure
```
.
├── .github/
│   └── copilot-instructions.md     # This file
├── .gitattributes                  # Git line ending configuration
├── .gitignore                      # Visual Studio .gitignore
├── LICENSE                         # GPL-3.0 license
└── README.md                       # Minimal readme
```

## Build & Development

### Prerequisites
- **Visual Studio**: 2019 or later with .NET Framework 4.0 development tools
- **Alternative**: .NET SDK with MSBuild for command-line builds
  - Current environment has .NET SDK 10.0.102 available via `dotnet` command
  - Note: .NET Framework 4.0 projects require MSBuild from Visual Studio or standalone installation

### Building the Project (When Source Code Exists)

**Note**: The current repository does not contain source code. To restore and work with the project, you would need to retrieve files from git history.

**If source code is present:**

1. **Using Visual Studio**:
   ```bash
   # Open the solution file
   # Visual Studio will restore NuGet packages automatically
   # Build using: Build > Build Solution (Ctrl+Shift+B)
   ```

2. **Using MSBuild (command line)**:
   ```bash
   # Restore NuGet packages first
   nuget restore BitLogicCalculator.sln
   
   # Build the solution
   msbuild BitLogicCalculator.sln /p:Configuration=Release /p:Platform="Any CPU"
   ```

### Build Configurations
The project supports the following configurations:
- **Debug|Any CPU**: Development build with debugging symbols, overflow checking, and code analysis
- **Debug|x64**: 64-bit debug build
- **Release|Any CPU**: Optimized release build
- **Release|x64**: 64-bit optimized release build

### Code Analysis
The project has code analysis enabled with the following analyzers (from 2019):
- Microsoft.CodeAnalysis.FxCopAnalyzers 2.9.6
- Microsoft.NetFramework.Analyzers 2.9.6
- Microsoft.NetCore.Analyzers 2.9.6
- Microsoft.CodeQuality.Analyzers 2.9.6
- Microsoft.CodeAnalysis.VersionCheckAnalyzer 2.9.6

**Important**: These analyzer packages may be outdated and could cause build warnings or errors. Consider updating to current versions or replacing with modern analyzers.

## Key Application Features

From the source code (MainForm.cs), the application provides:
- Bitwise logical operations on 32-bit values (BitArray with length=32)
- Two accumulators for input values
- Support for different byte sizes (1, 2, 3, or 4 bytes)
- Byte unit conversions (bits, bytes, KB, MB, GB, TB) via ByteUnits.cs
- Visual representation using checkboxes for individual bits
- Statistical information via StatisticsForm

## Git Workflows

### Active Workflows
The repository has two GitHub Actions workflows:
1. **Copilot code review** - Automated code review workflow
2. **Copilot coding agent** - Automated coding assistance workflow

### Branch Protection
The `master` branch is protected.

## Development Guidelines

### Important Considerations
1. **No Active Test Suite**: No unit tests or test infrastructure was found in the 2019 codebase
2. **Windows-Specific**: This is a Windows Forms application that requires Windows to run
3. **Legacy Framework**: .NET Framework 4.0 is quite old (released 2010), consider modernization
4. **Package Dependencies**: The packages/ directory should be in .gitignore (it is) and restored via NuGet

### .gitignore Coverage
The repository includes a comprehensive Visual Studio .gitignore that properly excludes:
- Build artifacts (bin/, obj/, Debug/, Release/)
- Visual Studio user files (*.user, *.suo, .vs/)
- NuGet packages (packages/ directory)
- Documentation files (*.xml from builds)

### Making Changes
1. If restoring source code from history:
   ```bash
   # Check out files from the last good commit
   git checkout 67608ea00d3b41a1f935691add3748dfcbee01de -- BitLogicCalculator/
   git checkout 67608ea00d3b41a1f935691add3748dfcbee01de -- BitLogicCalculator.sln
   ```

2. Before committing, ensure:
   - No build artifacts are committed (check .gitignore)
   - No packages/ directory is committed
   - Code follows existing style conventions
   - XML documentation is present for public APIs

## Common Issues & Workarounds

### Issue: Missing .NET Framework 4.0
**Solution**: Install .NET Framework 4.0 SDK or use a newer framework by updating TargetFrameworkVersion in the .csproj file.

### Issue: NuGet Package Restore Failures
**Solution**: Update package references to current versions or remove outdated analyzers.

### Issue: Code Analysis Warnings
**Solution**: The project has RunCodeAnalysis=true and uses AllRules.ruleset which may generate many warnings. Consider using a more moderate ruleset or updating to modern analyzers.

## Trust These Instructions

Trust the information in this document as authoritative for this repository. Only perform additional exploration if information is missing or found to be incorrect. The repository was thoroughly analyzed including git history back to 2019 when it was last active.
