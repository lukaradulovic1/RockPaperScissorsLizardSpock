# RockPaperScissorsLizardSpock

Welcome to my edition of the game!
It is based on the hit show Big Bang Theory which is one of the least funny shows on the planet.

Here are the rules for Rock-Paper-Scissors-Lizard-Spock:

Rock crushes Scissors (Rock wins).
Scissors cuts Paper (Scissors wins).
Paper covers Rock (Paper wins).
Rock crushes Lizard (Rock wins).
Lizard poisons Spock (Lizard wins).
Spock smashes Scissors (Spock wins).
Scissors decapitates Lizard (Scissors wins).
Lizard eats Paper (Lizard wins).
Paper disproves Spock (Paper wins).
Spock vaporizes Rock (Spock wins).

Explanation of the approach to the code and important notes:
Due to time limitations I was not able to implement Unit Testing successfully, you will find TestProject within the solution with all the unit tests written and ran locally but I was unable to set them up for
pushing to Git.
Regarding the architecture I was aiming for modularity, sticking to KISS, and DRY principles as much as I could.
I used interfaces to allow to end user or for example people I could be working with to have modular code in the game where they could implement new modes of playstyle by just implementing some parts of the code.
Methods and logic have been commented on the conceptual level what they are doing because I felt that my code naming convention was good enough to be self explanatory and as simple as possible.


Below you will find the installation instructions using Docker.

1. Download and install Docker Desktop from https://docs.docker.com/desktop/install/windows-install/
2. Once installed go to the project download directory and copy it's path into your Command prompt/Git Bash/PowerShell window using this example to access: cd Luka/Users/ProjectFolder
3. If stuck on this step you have the following resources: https://www.youtube.com/watch?v=NA4zyB4b0eI - https://www.wikihow.com/Open-a-Folder-in-Cmd or ask ChatGPT
4. Make sure you are running Docker desktop!
5. Once in the folder in console app type in:
6. Docker-compose build --no-cache and once it is finished...
7. ...type in Docker-compose up
8. That will build the image and it will be accessible on port http://127.0.0.1:7012/
9. Copy or type in that port in any of your favorite browsers and it should take you to our game!

Troubleshooting:
If you encounter any issues with Docker, you can find help here:
https://docs.docker.com/desktop/faqs/general/
