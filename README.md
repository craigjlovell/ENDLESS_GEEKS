# PROJECT NAME

## About the Game
PONG – New Dimension is a modern remake of the classic duel game.  A player must manipulate their paddle to bounce a ball past the other sides paddle to score points. 

The primary difference from regular pong is when a point is scored the camera will rotate towards the player who scored until eventually the gameplay switches to 3D gameplay. 

PONG – New Dimensions also includes collectable powerups and destructible objects. 

### Contributors:
Contributors to the project are strictly limated to AIE Students as part of their group work project.

Members (example):
- Craig Lovell: Programmer
- Rachel Espinosa: Artist
- Daniel Leonards: Artist
- Sasha Smirnova: Artist
- Joel Cefai: Designer
- Jasper Eyers: Designer

## Build Steps:
The project can currently be built for both windows and webgl in the following ways:

* **Manual:** Via the Unity Engine Build Settings.
  * Open the project in untiy
  * Select `File->BuildSettings`
  * Switch to the desired build platform (windows or webgl)
  * Select `Build`
  * You will be prompted to select an output directory
  * Once the build has finished open your chosed folder to find your build

* **Automated**: `build_all.bat` will run build and `pc` and `webgl` version of the project
  * Double click on `build_all.bat`
  * The process will take some time, leave the console window open
  * The following files will be produced:
    * PC Build: `builds/pc/YourGame.exe` 
    * WebGL Build: `builds/web/index.html`

## Daily Builds:
Daily builds of the project be uploaded to microsoft teams for each platform.
A Web build should be published each day to GitHubPages

## Deploy to Github Pages
1. Build the project - run `build_all.bat`
2. Deploy to gh-pages - run `gh-pages-deploy.bat`
3. Check the game runs as expected on the web build


## Unity Best Practices - Version Control and Folder Structure

This unity project has been created following the guidelines outlined in the following article.<br/>
http://www.arreverie.com/blogs/unity3d-best-practices-folder-structure-source-control/


# Credits:
 Are there assets, sounds or media included within the project that require attributation? list them here: