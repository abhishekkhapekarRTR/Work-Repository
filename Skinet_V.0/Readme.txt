* Setting up angular to use https:
	- In Skinet.Client -> Create folder with name 'ssl'
	- Open command prompt in administration mode and go to the above location (Skinet.Client/ssl)
	- Enter command (@"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command " [System.Net.ServicePointManager]::SecurityProtocol = 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin") and hit enter.
	- Reference : https://stackoverflow.com/questions/47861537/choco-command-not-recognized-when-run-as-administrator-on-windows
	- Once the installation is successful enter command 'choco' and hit enter, you will get the choco version as output.
	- Noe go to the VS code and open terminal, and move to the location (Skinet.Client/ssl)
	- Enter command 'mkcert install'
	- you will get the message as 'Created a new local CA'
	- Now enter command 'mkcert localhost'
	- Check the 'ssl' folder if the .pem files has been created.
	- If yes then on the same terminal move to the previous folder i.e. Skinet.Client.
	- Now your application is running on 'https://localhost:4200/'

-------------------------------------------------------------------------------------------------
