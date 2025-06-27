# Mail.dat.Abstractions

**Mail.dat.Abstractions** is a foundational .NET 9 library for the Open Mail.dat project. It provides core interfaces, contracts, and utility types that enable consistent, extensible, and type-safe handling of Mail.dat file import/export operations, file metadata, and related abstractions.

## Features

- **Core Abstractions:** Defines interfaces for import/export options, file handling, and progress reporting.
- **Extensible Contracts:** Enables custom implementations for file operations, logging, and configuration.
- **Async Support:** All major operations are designed for asynchronous workflows.
- **.NET 9 Ready:** Leverages modern C# and .NET features for performance and maintainability.

## Key Interfaces

### `IMaildatFile`
Represents a Mail.dat file and provides methods for file management, including zip/unzip operations.

**Properties & Methods:**
- `bool Exists`
- `string FilePath`
- `bool IsZipped`
- `string HeaderFilePath`
- `string GetFile(string extension)`
- `string UnzippedDirectory`
- `Task<bool> Unzip(string targetDirectory)`
- `Task<bool> Zip(string targetFilePath)`

### `IImportOptions`
Defines options for importing Mail.dat files.

**Properties:**
- `IMaildatFile SourceFile`
- `string TemporaryDirectory`
- `string TargetFile`
- `bool SkipPbc`
- `ILogger<IImportOptions> Logger`
- `CancellationToken CancellationToken`
- `bool FavorMemoryOverPerformance`
- `int MaxRecordsInMemory`

### `IExportOptions`
Defines options for exporting data to a target file.

**Properties:**
- `IMaildatFile TargetFile`
- `string TaregtVersion` *(typo in property name, should be `TargetVersion`)*
- `string SourceFile`
- `Encoding Encoding`
- `string LineTerminator`
- `ILogger<IImportOptions> Logger`
- `CancellationToken CancellationToken`

## Getting Started

1. **Reference the library:**
   Add a project or NuGet reference to `Mail.dat.Abstractions` in your .NET 9 solution.

2. **Implement the interfaces:**
   Create your own classes implementing `IMaildatFile`, `IImportOptions`, or `IExportOptions` as needed for your application.

3. **Use in your workflow:**
   Pass your implementations to higher-level Mail.dat processing libraries (such as `Mail.dat.Io`) to perform import/export operations.
1. 