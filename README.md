# 🧠 Windows Registry Activity Scanner (.exe)

A lightweight C++-based tool that scans and parses a wide range of **Windows Registry paths** to extract information about application activity, execution history, recent documents, and more.

The program outputs detailed entries, including:

- ✅ Entry name  
- 📁 Registry path  
- 🕒 Last execution time or timestamp (if available)

---

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

## 🛠️ How to Use

### 🔹 Requirements

- Windows 10/11 (Admin privileges recommended)
- No installation needed – just run the `.exe`

### 🔹 Steps

1. Download or compile the executable.
2. Run it (double-click or via terminal).
3. View the populated list of registry entries in the GUI.

---

## ⚠️ Disclaimer

> This tool is intended for **educational and forensic analysis purposes only**. Accessing registry data may reveal sensitive user behavior. Use responsibly and never in unauthorized environments.

---

## 📄 License

Licensed under the [MIT License](LICENSE). Open to contributions, forks, and feedback.

---

## 👨‍💻 Developer Notes

- Built in **C++** using `WinReg` and optionally WinForms/WinAPI/.NET bindings.
- Expandable to include export to CSV or JSON for reports.
- Contributions and suggestions welcome via GitHub Issues or Pull Requests.
