from misc import Vector2,Pathfinder
from scenario import grid

class collidable_char():
    
    MOVE_SPEED = 20 #Defines the amount of frames that the character will wait before move, lower numbers are faster
    position = Vector2(0,0)
    char = ""
    start_pos = Vector2(0,0) 
    
    def __init__(self,pos:Vector2,char:str):
        """Creates the character and defines it's starting position """
        self.position = pos
        self.start_pos = pos
        self.char = char
    

    m_dir = Vector2(0,0)

    def move(self,mapp:grid):
        """Moves the chacter in the m_dir direction if it's possible """
        new_pos = self.position+self.m_dir
        if new_pos == self.position:
            return

        #Checks if it's out of the borders
        if new_pos.Y> len(mapp.field)-1:
            new_pos.Y = 0
        elif new_pos.Y < 0:
            new_pos.Y = len(mapp.field)-1

        if new_pos.X> len(mapp.field[0])-1:
            new_pos.X = 0
        elif new_pos.X < 0:
            new_pos.X = len(mapp.field[0])-1

        #Collision check
        col_code = 0 #0-empty #1-wall #2-point #3-player #4-enemy
        if mapp.field[new_pos.Y][new_pos.X] == 1:#1=wall
            col_code = 1
            return col_code
        elif mapp.field[new_pos.Y][new_pos.X] == 2:#2=fruit
            col_code = 2
        elif mapp.field[new_pos.Y][new_pos.X] == 3 and self.char == "1":#3=player:
            col_code = 3
        elif mapp.field[new_pos.Y][new_pos.X] in [4,5]:#4,5=enemy:
            if self.char == "O":
                col_code = 4
            elif self.char == "1":
                col_code = 1
                return col_code 
        elif mapp.field[new_pos.Y][new_pos.X] == 6 and self.char == "O":#5-fruits:
            print("fruit")
            col_code = 5
        #print("Player move"+str(self.m_dir))
        mapp.move_char(self.char,self.position,new_pos)
        self.position = new_pos
        return col_code


class enemy(collidable_char):



    state = 0 #0 - chase 1 - run

    def follow_player(self,mapp,player_pos):


        ########old pathfinding logic
        #path = Pathfinder.find_path(mapp,self.position,'O')
        #self.m_dir = path[0]
        #self.move(mapp)
        #######new pac man original logic
        #Using the state, defines the target of the enemy
        if self.state == 0:
            new_dir = Pathfinder.find_next_move(mapp.field,self.position,player_pos,self.m_dir)
        
        elif self.state == 1:
            new_dir = Pathfinder.find_next_move(mapp.field,self.position,self.start_pos,self.m_dir)
        
        self.m_dir= new_dir
        col = self.move(mapp)
        return col
    
    def die(self):
        pass
    