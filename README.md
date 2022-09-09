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
<hr/>
<h3>Docker cmd</h3>
<h4>docker images </h4> =>> get list of img
<h4>docker pull name-image </h4> =>> just get image 
<h4>docker run name-image </h4> =>> just run image if you does not have image docker goes to get image from docker hub
<h4>docker ps </h4> =>> list of containers when containers is runing
<h4>docker ps -a </h4> =>> list of containers when containers was runing
<h4>docker rm Containerid </h4> =>> delete the container
<h4>docker rmi name-image </h4> =>> delete image
<h4>docker container prune </h4> =>> delete all of the container
<h4>docker stop name-container </h4> =>> just stop container
<hr/>
<h4>docker command --help </h4> =>> get list of help that can use with this command
<h4>docker run --rm </h4> => run image and after that excit delete auto
<h4>docker run -d -p 80:80 name-image </h4> =>> set port container to port system -- -d from debug container
<h4>docker run  --name somename name-image </h4> =>> set name from container
<h4>docker exec -it name-container </h4> =>> work wtih container =>>docker exec -it namecontainer redis-cli =>> we can work with container of redis
