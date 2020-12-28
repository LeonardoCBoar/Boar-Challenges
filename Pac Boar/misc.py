

class Vector2():
    """Mathematical bidimensional vector """

    X = 0
    Y = 0
    def __init__(self,x:int,y:int):
        self.X = x
        self.Y = y


    def __add__(self,vector2):
        x = self.X + vector2.X
        y = self.Y + vector2.Y
        return Vector2(x,y)
    
    def __sub__(self,vector2):
        x  = self.X - vector2.X
        y = self.Y - vector2.Y
        return Vector2(x,y)
    
    def __mul__(self,multiplier):
        x = self.X*multiplier
        y = self.Y*multiplier
        return Vector2(x,y)
    
    
    def __str__(self):
        return f"({self.X},{self.Y})"
    
    def __repr__(self):
        return f"({self.X},{self.Y})"

    def __eq__(self,vector2):
        if self.X == vector2.X and self.Y ==vector2.Y:
            return True
    
    def reversed(self):
        return self.__mul__(-1)

    @staticmethod
    def distance(origin,target):
        width = target.X-origin.X
        height = target.Y- origin.Y
        distance = ((width**2)+(height**2))**0.5
        return distance


class directions():
    #Direction Vector2 constraints
    UP = Vector2(0,-1)
    DOWN = Vector2(0,1)
    LEFT = Vector2(-1,0)
    RIGHT = Vector2(1,0)

class Pathfinder():
    
    @staticmethod
    def is_action_valid(grid:list,action:Vector2,target_pos:Vector2):
        """Checks if the end of the path is a valid place in the grid""" 
        

        
        pos = action

        #Ignores this path if the goes out of the grid
        if pos.X<0 or pos.Y<0 or pos.Y >= len(grid) or pos.X>=len(grid[0]):
            return 0,"case 1",str(pos)
        
        #Ignores this path if the passes through a wall
        elif grid[pos.Y][pos.X] == 1:
            return 0,"case 2",str(pos)
        
        #Defines this as the final path, when the it passes through the target point
        elif pos==target_pos:
            return 2,f"Path was founded at {grid[pos.Y][pos.X]}"
        
        #Keeps searching it this path is valid
        else:
            return 1,"Valid path",str(pos)




    @staticmethod
    def find_path(grid:list,pos:Vector2,target:str):
        """Finds the path between two points in the grid """
        Sides = [directions.UP,directions.DOWN,directions.LEFT,directions.RIGHT]
        paths = [[]]
        count = 0
        while True:
            count+=1
            #rint(count)
            #Goes to the four directions from the first path in the paths list,if it's valid it's added to the end
            #The first time a path reachs the target, it's returned 
            
            for dirr in Sides:
                c_path = paths[0].copy()
                c_path.append(dirr)

                #Ignores this path if it's redundant
                if len(c_path)>1 and c_path[-1] == c_path[-2].reversed():
                    continue
                #Sent the current path to the validation and gets the answer code
                code = Pathfinder.is_action_valid(grid.field,c_path,target)
                if code[0] == 0:
                    continue
                elif code[0] == 1:
                    paths.append(c_path)
                elif code[0] == 2:
                    return c_path
            paths.pop(0) #removes the path that was updated with new movements

    @staticmethod
    def find_next_move(grid:list,pos:Vector2,target_pos:Vector2,c_dir:Vector2):
        
        Sides = [directions.UP,directions.DOWN,directions.LEFT,directions.RIGHT]
        if c_dir != Vector2(0,0):
            Sides.remove(c_dir.reversed())

        move = None
        for dirr in Sides:
            moved_pos = pos+dirr
            
            a =  Pathfinder.is_action_valid(grid,moved_pos,target_pos)
            if a[0]==0:
                continue
            #elif a[0] == 2:
                #return Vector2(0,0)
            elif not move:
                move = dirr
            elif Vector2.distance(moved_pos,target_pos) < Vector2.distance(pos+move,target_pos):
                move = dirr
        if not move:
            move = Vector2(0,0)
        return move
        
        
        

        




