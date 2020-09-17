# UsersChallenge

##System Requirements to run the application:

- .NET Framework 4.8 minimum required.

- Windows must have installed:
	- WebPlatformInstaller
	- URL Rewrite Module 2
	- Web Deploy

- IIS must be enabled in "Control Panel > Programs And Feaures > Turn Windows feature on or off" and have enabled the resources under:
	- World Wide Web > Application Development Features > ASP.NET 4.8 

- In IIS Manager go to Handler Mappings and click twice on the following Handler Mapping: "ExtensionlessUrlHandler-Integrated-4.0"
	- Click on Request Restrictions > Verbs
	- Select "All Verbs"
	- Click OK on both dialog windows
	- Restart IIS

- IIS must have the Default Web Site created

*Deployment of the application
- Download the UsersChallenge1.0.zip package
	- Extract the deploy package to a folder on the Windows machine that will run the site
	- Open Powershell or CMD as an Adminstrator
	- Run the script called "UsersChallengeAPI.deploy.cmd"

*Open a web browser and go to http://localhost
	
