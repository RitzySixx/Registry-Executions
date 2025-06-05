# Registry Executions
 Lists cached programs in the registry
 
## Functions
This program lists the cached programs in a DataGridView control, which contains:
- Name of the file
- If the file currently exists
- Creation date of the file (if it exists)
- Modification date of the file (if it exists)
- Full path of the file

### Themes
The program has a dark and light theme option. Just click a button to toggle between these two options.

### Filters
The program has a ComboBox with 4 options for filters, where you can type some text and filter results based on your options
This is useful to track a certain file or path.

### Path context menu
You can right click on the path column to enable a context menu. This menu allows you to:
- Open the folder that the file is cached in (if it exists)
- Execute the file (if it exists)
- Show properties of the file (if it exists)

## 🔍 What It Scans

This executable reads from the following key locations:

### 📌 Application & Execution Traces
- `SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store`
- `SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers`
- `SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Persisted`
- `SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache`

### 📂 File/Document/Usage History
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\RecentDocs`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\ComDlg32\OpenSavePidlMRU`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\ComDlg32\LastVisitedPidlMRU`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Search\RecentApps`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\UFH\SHC`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\UserAssist`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FileExts`

### ⚙️ Startup / Execution Paths
- `SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Run`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StartPage`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StartPage2`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StartPage\NewShortcuts`
- `SOFTWARE\Microsoft\Windows\ShellNoRoam\MUICache`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData`
- `SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\RunMRU`

---
