#Built-in
from os import system,name
from time import sleep,time
from random import randint

#Third-party
from keyboard import is_pressed

#Custom classes
from misc import Vector2,directions
from scenario import grid
from characters import collidable_char,enemy



def clean():
    if name == "nt":
        system("cls")
    else:
        system("clean")

######Declaration of initial game vars
mapp = grid()
started = False
points = 0

p_pos = Vector2(9,15)
player = collidable_char(p_pos,'O')

##Instaciation of the enemies
enemies = []
e_poss = [Vector2(1,1),Vector2(17,1),Vector2(9,9)]
for e_pos in e_poss:
    enem = enemy(e_pos,'1')
    enemies.append(enem)

counter = 0 

clean()
print(mapp)
print("PRESS ENTER TO START")

state_counter = 0
state = 0 #0 - chase 1 - run
while True:
    #Game logic loop
    frame_start = time()
    
    #Direction player inputs
    if is_pressed("w"):
        #print("w input" )
        player.m_dir = directions.UP
    elif is_pressed("s"):
        #print("s input" )
        player.m_dir = directions.DOWN
    elif is_pressed("a"):
        player.m_dir = directions.LEFT
        #print("a input" )
    elif is_pressed("d"):
        #print("d input" )
        player.m_dir = directions.RIGHT
        started = True
    elif is_pressed("enter"):
        started = True

    #Moves the characters every MOVE_SPEED frames
    counter +=1
    if counter>=collidable_char.MOVE_SPEED and  started:
        counter = 0
        #Moves the player and get it's collision code
        p_collision = player.move(mapp)
        if p_collision == 2:
            points+=1
        elif p_collision == 5:
            state=1
            state_counter=0
            grid.colors["1"] = "\u001b[32m"
        #Change enemies state
        

        state_counter+=1
        if state_counter>20+randint(0,10):
            if state == 0:
                #print("RUN")
                state=1
                grid.colors["1"] = "\u001b[32m"
            elif state==1:
                #print("CHASE")
                state = 0
                grid.colors["1"] =  "\u001b[31m"
            state_counter = 0

        #Moves the enemies torwards the player and get it's collision code

        e_collision = []
        for enem in enemies:
            col = enem.follow_player(mapp,player.position)
            e_collision.append(col)
            
            enem.state = state

        #Prints the new frame
        clean()
        print(mapp)
        print(f"Points : {points}")
        #print(mapp.fruit_counter)
        if points == mapp.fruit_counter:
            print("YOU WINNNN")
        elif (3 in e_collision) or p_collision==4:
            print("Game over")
            break

    #framerate of the game, it's higher than the physics update in order to don't lose any input
    FRAME_RATE = 60
    wait_time = 1.0/FRAME_RATE-(time()-frame_start)
    sleep(max(wait_time,0.0))
