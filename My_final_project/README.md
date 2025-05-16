Ideas:
- Fake Inazuma Eleven Game
- Boxer Life Simulator 2D
- 3D Platform Game

# overviev
  GAME NAME is a dynamic single-player game that combines sports elements with RPG and tactics. The game offers exciting matches with bots that have unique play styles and special techniques.

# gameplay
  1. show menu
  2. start match - button option  (tutorial)
  3. choose team
  4. start match 
  5. render football pitch (with goals, game area, player and bots )
  6. break time after 4 minutes
  7. end after 8 minutes 
  8. winner team is the one with higher score
  9. team gets the point when ball reached goal 
  10. player's actions: run, shoot, pass, special techniques, tackle, Ball reception, chenge character, goalkeppeing

  # task list 
    1. design menu (x)
    2. name of the game (x)
    3. special techniques (x)
    4. 3D or 2D (x)
  
  # special techniques
  ## list

  1. god hand - goalkeeper technique ( big gold hand ) - power 20 stamina cost 10 
  2. fire storm - shoot technique ( fire blast around ) - power 20 stamina cost 10
  3. meteor blade - shoot technique ( colorfull ball ) - power 40 stamina cost 30 
  4. beast fang - goalkeeper technique ( wolf bite ball ) - power 60 stamina cost 80
  5. snow land - reciver the ball technique ( attcaking player freeze ) - power 30 stamina cost 15

  ## notes
  - when the power of special techniqes is equal we should compare the current level of players stamina and choose higher value
  - to trigger ST player needs to pay the stamina cost
  - special technique is assigned to specific player (predifined)
  
  # models
  
  ## player
  - stamina [int]
  - name [string]
  - position [string?]
  ## special techiques
  - power [int]
  - name [string]
  - types goalkeeper technique, shoot technique, defense  technique, movement technique 
  