# ONS

<img width="774" alt="Screenshot 2023-01-20 at 3 15 33 AM" src="https://user-images.githubusercontent.com/48947076/213538823-7e228108-5349-4ee2-bc0d-c55bbbcc7bda.png">

The below sections are the brief description of our game, which is quoted from our report.
To know more details about the game, please have a check on our complete report, game trailor, and powerpoint for presentation:

- Report: https://drive.google.com/file/d/1-A11an7jRfDNfYxRkxfP5H_wTHrGq3qt/view?usp=share_link
- Game Trailor: https://drive.google.com/file/d/1Dk83brhFq6JEJ7pGaBUYFOeSxhoV94Tz/view?usp=share_link
- Game Intrsuctions: https://drive.google.com/file/d/1yLWkY6hUuW1IgroWKpYt24ggq_Gz1fil/view?usp=share_link
- Powerpoint: https://drive.google.com/file/d/1RQrXAwE4NgkE9KFheP6ihWT7oeXViw6o/view?usp=share_link

## Overview

One night simulator is a 2D RPG game set in the nightlife district. Players get to experience typical happenings in Hong Kong bars and nightclubs (more specifically LKF). 

The goal of the game is to collect specific contacts of specific targets. It is a 2G RPG game in a mature setting and the target audience of the game is the young adults demographic..


## Game Background

Under current COVID-19 influenza, restriction order has prohibited parties and gatherings. Our game is inspired by this atmosphere and aimed to provide players an experience of local Hong Kong bar culture. We want to see if players can make contact with people in Lan Kwai Fong, and complete different missions that simulate common happenings in the nightlife district.



## Scope Of Project

Inspired by the classic RPGs, such as pokemon, Legend of Zelda and more, One Night Simulator is designed with similar aesthetics such that our team can create our own stage for different scenes without the concern of making it realistic. The pixelate style not only sets a tone for the game, it also helps with the manipulation of the game mechanics, as tools like Tiled, Sprite Editor in Unity works well with fixed sized elements. While the sprites and the tiles used are created by third-party, the composition of the scenes, i.e. the tileset, the scene layouts and UI design, are created by our team.

Initially, the project is set with a greater scope in mind -- it was planned that the initial status of the user is randomised, such that each run of the game brings a different experience. Moreover, more NPCs would be planned initially and there are more variations that the players can have with the game. 

However, the learning time for different techniques were underestimated. The randomised feature has too many parameters to be considered in order for it to fully function. For now, we have implemented the basic stream-line mechanics of the RPG games. Each decision made will affect the three values we set up, including health, sanity and money, and that the dialogue systems plug-in utilised would work with the stat changes across scenes. A timer is set such that the player is limited to only a 5 minute playtime each run. Replay is encouraged for the player to get all the target’s contacts. Currently, there are 4 targets available, and getting the contacts depends heavily on the conversation decisions made. The clues to the next steps in the game are not as obvious so that there are still some explorations and novelty for the player. The ultimate aim of the game is to get as many contacts as possible within the time limit. 



## Coding Process

Our group created a Github repository and edit the game as well as C# scripts respectively according to delegated parts. We held regular meetings to synchronize respective progress and coordinate different components together.



