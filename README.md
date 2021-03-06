# UsersChallenge

## System Requirements to run the application: ##

- [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48) minimum required.

- Windows must have installed:
	- [WebPlatformInstaller](https://www.microsoft.com/web/downloads/platform.aspx)
	- [URL Rewrite Module 2](https://www.microsoft.com/en-us/download/details.aspx?id=7435)
	- [Web Deploy](https://www.microsoft.com/en-us/download/details.aspx?id=43717)

- IIS must be enabled in "Control Panel > Programs And Feaures > Turn Windows feature on or off" and have enabled the resources under:
	- World Wide Web > Application Development Features > ASP.NET 4.8 

- In IIS Manager go to Handler Mappings and click twice on the following Handler Mapping: "ExtensionlessUrlHandler-Integrated-4.0"
	- Click on Request Restrictions > Verbs
	- Select "All Verbs"
	- Click OK on both dialog windows
	- Restart IIS

- IIS must have the Default Web Site created

## Deployment of the application ##
- Download the UsersChallenge1.0.zip package from [here](https://github.com/lucasvcardoso/UsersTechChallenge/releases/tag/1.0)
	- Extract the deploy package to a folder on the Windows machine that will run the site
	- Open Powershell or CMD as an Adminstrator
	- Run the script called "UsersChallengeAPI.deploy.cmd"

### Open a web browser and go to http://localhost ###
	
