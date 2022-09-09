# <h2>How to Install Docker Desktop on Windows</h2>
<h4>System requirements:</h4>
<h5>1: Enabled this features on Turn windows features on or off </h5>
<ul>
  <li>Hyper-V</li>
  <li>Containers</li>
  <li>Virtual Machine Platform</li>
  <li>Windows Subsystem for Linux</li>
</ul>

<h5>2: Virtualization enabled in the BIOS </h5>
<h5>3: Hypervisor enabled at Windows startup </h5>
<span> Open an administrative console prompt.<br>Run bcdedit /set hypervisorlaunchtype auto.<br>Restart Windows.
<h5>4: Download the Linux kernel update package from this Url:https://wslstorestorage.blob.core.windows.net/wslblob/wsl_update_x64.msi</h5>
<h5>5: Set WSL 2 as your default version </h5>
<span>Open PowerShell and run this command to set WSL 2 as the default version when installing a new Linux distribution:<br>
wsl --set-default-version 2<span>
<h3>Install Docker Desktop on Windows I hope everything is ok</h3>
