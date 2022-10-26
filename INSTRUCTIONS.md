## How to containerized a new Asp.net Boiler Plate Application 

#### Intro:

This is a video demonstration for How to containerized a new Asp.net Boiler Plate Application. The following instructions will allow you running one aspnetboilerplate application as docker container. The Dockerfile and docker-compose files are taken from a repository with a pull request and it is explained down below in the following steps. 

#### Requirements:

For you to follow along the following instructions you will need to be familiar with git, aspnetboilerplate, docker, aspnet core, angular. that is why I will not be exaplaining anything about aspnetboilerplate, I going to be creating a full series of videos about how to create your project with aspnetboilerplate, this video is only how to run the project as a docker container. 

I am going to be using the following tools:
- Git command line for Linux or Mac or Git bash for Windows
- Docker for Linux or Mac or Windows
- Docker Compose for Linux or Mac or Windows
- SQL Server Management Studio 

#### Instructions:

- Download the new template application from aspnetboilerplate website. Ex: `https://aspnetboilerplate.com/Templates`. For our example we are taking ASP.NET Core target version v7.x and Single Page Web Application with Angular. 
- Leave the Options by default which will be Include login, register, user, roles and tenant management pages. And untick the One solution. 
- Set your project name to be MyCollege.
- Enter the captcha code, leave the latest stable version and click the download project button. 
- You will get a MyCollege.zip file. 
- Extract this file, and inside you will file the version number in our example we have 7.3. We don't need this version now. Go inside the version number folder and create a git repository in there. In my example, I will be doing: 
    - `unzip MyCollege.zip -d MyCollege/`
    - `cd MyCollege/7.3.0/`
- Once terminal and navigated to inside the version number folder, once there execute those commands:
    - `git init`
    - `git add .`
    - `git commit -m 'my initial commit'`
- Then we are going to add some Docker files from this repository pull request `https://github.com/aspnetboilerplate/module-zero-core-template/pull/613`. Basically we are taking all updated and new files from this pull request and copy them over to our new project folder. In my example I am copying those file with this command:
    - `cp -r ../../copy-from-merge/* ./`
    - `git status` 
    - Open the folder: `/root/source/MyCollege/7.3.0`, and Look that files, for example:
    - `angular/src/assets/appconfig.container.json`
    - `angular/Dockerfile`
    - `angular/.dockerignore`
    - `aspnet-core/Dockerfile`
    - `aspnet-core/.dockerignore`
    - `aspnet-core/build/build-with-ng-updated.sh`
    - `aspnet-core/docker/ng/docker-compose.yml`
    - `aspnet-core/docker/ng/.gitignore`
- Open the root of the repository folder with any IDE/text editor of your preference, I am using VS Code. 
- Update the file `aspnet-core/Dockerfile` place holder `AbpCompanyName.AbpProjectName` with your project own name. In my case I am doing `MyCollege` name, and executing this commands: 
    - `cat ./aspnet-core/Dockerfile`
    - `sed -i "s/AbpCompanyName.AbpProjectName/MyCollege/g" ./aspnet-core/Dockerfile`
    - `cat ./aspnet-core/Dockerfile`
- Create a new database in your MS SQL Server, for me it will be `MyCollegeDb`. Therefore I am going to MS SQL Management Studio and executing the `CREATE DATABASE MyCollegeDb` command.
- Go back to VS code and set the connection string in the `aspnet-core/src/MyCollege.Migrator/appsettings.json` file. For my example the connection string will be:  `Server=192.168.22.101;Database=MyCollegeDb;User Id=sa;Password=D8JeW7jjSmBVXLcRxWLDwMjYLnf6xVG8;`. For my example:
    - `cat ./aspnet-core/src/MyCollege.Migrator/appsettings.json`
    - `sed -i "s/Server=localhost; Database=MyCollegeDb; Trusted_Connection=True;/Server=192.168.22.101;Database=MyCollegeDb;User Id=sa;Password=D8JeW7jjSmBVXLcRxWLDwMjYLnf6xVG8;/g" ./aspnet-core/src/MyCollege.Migrator/appsettings.json`
    - `cat ./aspnet-core/src/MyCollege.Migrator/appsettings.json`
- With your terminal navigate to migration project folder and run this project with the following command:
    - `cd ./aspnet-core/src/MyCollege.Migrator`
    - `dotnet run`
- Build the container image for the Angular Application and the Aspnet Core Application by running the script hosted in `aspnet-core/build/build-with-ng-updated.sh`. Please note this script is expecting you to navigate your terminal to the folder `aspnet-core/build` and then execute the script from there. 
    - `cd ../../../aspnet-core/build`
    - `ls -al`
    - `cat ./build-with-ng-updated.sh`
    - `docker image ls`
    - `./build-with-ng-updated.sh`
- Run your docker-compose file by updating the environment variables on the file `aspnet-core/docker/ng/docker-compose.yml` as desired. and finally, navigate your terminal to: `aspnet-core/docker/ng`, once there execute the following command:
    - `cd ../../aspnet-core/docker/ng`
    - `cat ./docker-compose.yml`
    - `sed -i "s/Server=10.0.75.1; Database=AbpProjectNameDb; User=AbpProjectNameUser; Password=YourStrongPassword;/Server=192.168.22.101;Database=MyCollegeDb;User Id=sa;Password=D8JeW7jjSmBVXLcRxWLDwMjYLnf6xVG8;/g" ./docker-compose.yml`
    - `cat ./docker-compose.yml`
    - `docker-compose up -d`
    - `docker-compose ps`

#### Final Notes:
Once the pull request is merged all you would need to run your application as docker container is follow the steps number 11 and 15. 

#### Finally updating the remote repository:
- `git remote add origin git@github.com:EduardoSantanaSeverino/MyCollegeTest01.git`
- `git push origin master`
