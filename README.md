# Dictionary 2015

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](LICENSE.txt)
[![Platform](https://img.shields.io/badge/Platform-Windows-blue.svg)]()
[![Language](https://img.shields.io/badge/Language-C%23-green.svg)]()
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.5.1-purple.svg)]()

![Dictionary_2015](https://github.com/amirargani/Dictionary_2015/blob/main/Dictionary_2015.png)

A Windows Forms application demonstrating smooth UI animations and continuous MP3 playback using Windows Media Player integration.

---

## 📋 Table of Contents

- [Overview](#-overview)
- [Features](#-features)
- [Requirements](#-requirements)
- [Installation](#-installation)
- [Usage](#-usage)
- [Technical Details](#-technical-details)
- [Project Structure](#-project-structure)
- [License](#-license)
- [Contributing](#-contributing)

---

## 🎯 Overview

**Dictionary 2015** is a Windows Forms desktop application built with C# that showcases elegant UI animations combined with background audio playback. The application demonstrates best practices for creating smooth visual transitions and integrating Windows Media Player functionality into a .NET Framework application.

### Key Highlights

- 🎶 **Continuous MP3 Playback** - Seamless background music using Windows Media Player COM library
- ✨ **Smooth Animations** - Elegant fade-in/fade-out effects with vertical slide transitions
- 🖱️ **Draggable Interface** - Custom window dragging functionality without standard title bar
- 📦 **Embedded Resources** - MP3 file embedded as application resource for portability
- 🎨 **Modern UI** - Clean, minimalist design with custom window controls

---

## ✨ Features

### Animation System
- **Fade-in Effect**: Smooth opacity transition from 0.1 to 1.0 on startup
- **Vertical Slide**: Window height animates from 100px to 600px
- **Centered Positioning**: Automatically centers window on screen during animations
- **Fade-out Exit**: Graceful closing animation with reverse effects

### Audio Playback
- **Embedded MP3**: Music file stored as embedded resource
- **Automatic Extraction**: Extracts MP3 to temp directory on launch
- **Continuous Loop**: Automatic replay functionality
- **WMP Integration**: Uses Windows Media Player COM library (WMPLib)

### User Interface
- **Borderless Window**: Custom-styled form without standard Windows chrome
- **Draggable Window**: Click and drag anywhere on the panel to move window
- **Custom Controls**: Minimize and close buttons with hover effects
- **Responsive Design**: Centered layout adapts to screen resolution

---

## 💻 Requirements

### System Requirements
- **Operating System**: Windows 7 or later
- **Framework**: .NET Framework 4.5.1 or higher
- **Windows Media Player**: Version 10 or later (included with Windows)

### Development Requirements
- **IDE**: Visual Studio 2013 or later
- **SDK**: Windows SDK
- **Build Tools**: MSBuild 12.0 or later

---

## 🚀 Installation

### Option 1: Download Release (Recommended)
1. Go to the [Releases](https://github.com/amirargani/Dictionary_2015/releases) page
2. Download the latest `Dictionary_2015.exe`
3. Run the executable - no installation required!

### Option 2: Build from Source

1. **Clone the repository**
   ```bash
   git clone https://github.com/amirargani/Dictionary_2015.git
   cd Dictionary_2015
   ```

2. **Open the solution**
   - Launch Visual Studio
   - Open `Dictionary_2015.sln`

3. **Restore dependencies**
   - The project uses Windows Media Player COM library (WMPLib)
   - COM reference should restore automatically

4. **Build the project**
   - Press `F6` or select `Build > Build Solution`
   - Output: `Dictionary_2015\bin\Debug\Dictionary_2015.exe`

5. **Run the application**
   - Press `F5` to run in debug mode
   - Or execute the compiled `.exe` file

---

## 📖 Usage

### Running the Application

1. **Launch**: Double-click `Dictionary_2015.exe`
2. **Watch**: The window will smoothly fade in and expand vertically
3. **Listen**: Background music begins playing automatically
4. **Move**: Click and drag the main panel to reposition the window
5. **Minimize**: Click the minimize button (-)
6. **Close**: Click the close button (X) - window will animate out before closing

### Controls

| Action | Method |
|--------|--------|
| **Move Window** | Click and drag anywhere on the main panel |
| **Minimize** | Click the minimize button |
| **Close** | Click the close button |

---

## 🔧 Technical Details

### Architecture

```
Dictionary_2015
├── Main.cs                 # Main form logic and event handlers
├── Main.Designer.cs        # Auto-generated UI designer code
├── Main.resx              # Form resources and embedded files
├── Program.cs             # Application entry point
└── Resources/
    └── Music.mp3          # Embedded audio file
```

### Core Components

#### 1. Animation System
- **Timer-based**: Uses `System.Windows.Forms.Timer` for smooth animations
- **Opacity Control**: Increments/decrements by 0.025 per tick
- **Height Animation**: Changes by 10px per tick
- **Dynamic Centering**: Recalculates position during animation

```csharp
// Fade-in animation
this.Opacity += 0.025;  // Smooth opacity transition
this.Height += 10;      // Vertical expansion
```

#### 2. Windows Media Player Integration
- **COM Interop**: Uses WMPLib COM library
- **Resource Extraction**: Extracts embedded MP3 to `%TEMP%\Music.mp3`
- **Playback Control**: Automatic play/stop/loop functionality

```csharp
WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
WMP.URL = SFTEMP + "\\Music.mp3";
WMP.controls.play();
```

#### 3. Custom Window Dragging
- **Win32 API**: Uses `user32.dll` for native window manipulation
- **Mouse Events**: Captures left-click on panel
- **Caption Simulation**: Treats panel as window title bar

```csharp
[DllImport("user32.dll")]
public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
```

### Dependencies

| Library | Purpose | Type |
|---------|---------|------|
| **System.Windows.Forms** | UI framework | .NET Framework |
| **System.Drawing** | Graphics and UI | .NET Framework |
| **WMPLib** | Media playback | COM Reference |
| **System.Runtime.InteropServices** | Win32 API calls | .NET Framework |

### Configuration

- **Target Framework**: .NET Framework 4.5.1
- **Platform Target**: AnyCPU
- **Output Type**: Windows Application (WinExe)
- **COM References**: Windows Media Player (WMPLib)

---

## 📁 Project Structure

```
Dictionary_2015/
│
├── Dictionary_2015/              # Main project directory
│   ├── Main.cs                   # Main form implementation
│   ├── Main.Designer.cs          # Form designer code
│   ├── Main.resx                 # Form resources
│   ├── Program.cs                # Entry point
│   ├── App.config                # Application configuration
│   ├── Dictionary_2015.csproj    # Project file
│   │
│   ├── Properties/               # Assembly properties
│   │   ├── AssemblyInfo.cs       # Assembly metadata
│   │   ├── Resources.resx        # Application resources
│   │   ├── Resources.Designer.cs # Resource designer code
│   │   └── Settings.settings     # Application settings
│   │
│   └── Resources/                # Embedded resources
│       └── Music.mp3             # Background music file
│
├── Dictionary_2015.sln           # Visual Studio solution
├── Dictionary_2015.png           # Project screenshot
├── LICENSE.txt                   # Apache 2.0 license
├── README.md                     # This file
├── .gitignore                    # Git ignore rules
└── .gitattributes                # Git attributes
```

---

### Apache 2.0 License Summary

- ✅ **Commercial use** - Use for commercial purposes
- ✅ **Modification** - Modify the source code
- ✅ **Distribution** - Distribute the software
- ✅ **Patent use** - Grant of patent rights
- ✅ **Private use** - Use privately
- ⚠️ **Trademark use** - Does not grant trademark rights
- ⚠️ **Liability** - Includes limitation of liability
- ⚠️ **Warranty** - Provided "as is" without warranty

---

## 🤝 Contributing

Contributions are welcome! Here's how you can help:

### Reporting Issues
1. Check if the issue already exists
2. Create a new issue with detailed description
3. Include steps to reproduce
4. Add screenshots if applicable

### Submitting Pull Requests
1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Development Guidelines
- Follow C# coding conventions
- Comment complex logic
- Test on Windows 7, 8, 10, and 11
- Ensure .NET Framework 4.5.1 compatibility

---

## 🙏 Acknowledgments

- **Windows Media Player** - For robust media playback capabilities
- **.NET Framework** - For comprehensive Windows Forms support
- **Visual Studio** - For excellent development tools

---

*Developed by Amir Argani*
