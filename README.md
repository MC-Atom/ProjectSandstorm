# ProjectSandstorm

## Using github desktop

### Downloading and Setup
0. Download, install, and log into github desktop (https://desktop.github.com/)
1. Clone this repository into an empty folder (The URL is https://github.com/MC-Atom/ProjectSandstorm.git)
2. Be sure to initialize git LFS when asked
3. From the unity hub, create a unity project in the same folder you just cloned into. **Use version 2021.3.2f1**

### Pulling files from github
In github desktop, navigate to the project and click the "fetch / pull origin" button at the top. This will update all the files that other people edited and pushed to the online repository.

### Pushing to github command line
In github desktop, commit your edited files by adding a summery and clicking the commit button. Then click the "fetch / pull / push origin" button at the top.


## Using Command Line

### Downloading and Setup
0. Install git and be familiar with terminal (or ask someone who is). Download unity hub.
1. Navigate to desired location in terminal (use cd)
2. Clone the project `$ git clone https://github.com/MC-Atom/ProjectSandstorm.git`
3. Enable large file storage `$ git lfs install`
4. From the unity hub, create a unity project in the same folder you just cloned into. **Use version 2021.3.2f1**

### Pulling files from github
Use `$ git pull` to update all files that other people edited and pushed to the online repository. Make sure you do this every time you start work on the project to minimise conflicts

### Pushing to github command line
Use `$ git add *` to add any files you changed before committing

Use `$ git commit -m "[change message]"` to commit your changes to the main project

Use `$ git push` to update the online project
