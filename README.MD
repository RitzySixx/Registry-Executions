# Windows Registry Executable Scanner

A C++ tool that scans Windows registry locations for executed applications, verifies their digital signatures, and exports the results to CSV. Designed for security analysis and forensic investigations.

## Features

- Scans multiple registry locations for executed applications:
  - BAM (Background Activity Moderator) keys
  - Compatibility Assistant entries
  - MuiCache from both Shell and ShellNoRoam
- Verifies digital signatures (Authenticode and Catalog)
- Detects deleted/missing executables
- Removes duplicate file paths across scans
- Sorts results by signature status (Invalid → Deleted → Valid)
- Exports to CSV for easy analysis
- Requires and verifies Administrator privileges

## Registry Locations Scanned

1. `HKLM\SYSTEM\CurrentControlSet\Services\bam\UserSettings`
2. `HKLM\SYSTEM\CurrentControlSet\Services\bam\state\UserSettings`
3. `HKCU\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store`
4. `HKCU\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache`
5. `HKCU\Software\Microsoft\Windows\ShellNoRoam\MUICache`

## Signature Verification

Each found executable is checked for:
- Authenticode signatures (standard PE signatures)
- Catalog signatures (Windows Defender signatures)
- File existence (marks as "Deleted" if missing)
- Invalid signatures (failed verification)

## Build Instructions

### Requirements
- Windows SDK
- Visual Studio (or compatible C++ compiler)
- Administrator privileges to run

### Compilation
1. Open the solution in Visual Studio
2. Build as Release x64
3. Or compile from command line:
