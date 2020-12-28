

class grid():
    from misc import Vector2
    
    fruit_counter = 0

    field = []
    #empty/wall/player/fruit/enemy
    simbols = {" ":0,"#":1,".":2,"O":3,"1":4,"U":6}
    simbols_list =  [" ","#",".","O","1","1","U","1"]
    def __init__(self):
        """Creation of the game field based on the arena .txt """
        #Reads the file, then converts it to a bidimensional matrix
        arena = open("arena.txt").readlines()
        for row in arena:
            line = []
            for case in row:  
                if case == ".":
                    self.fruit_counter+=1
                if case=="\n":
                    continue
                line.append(self.simbols[case])
            self.field.append(line)
    
    #yellow,blue,white,red
    colors = {"O":"\u001b[33m","#":"\u001b[34m",".":"\u001b[37m","1":"\u001b[31m"," ":"","U":"\u001b[36m"}
    def __str__(self):
        """Renders a formated string of the field to print"""
        output = ""
        for Y in self.field:
            for X in Y:
                #Adds the color code of the char, then adds the char
                char = self.simbols_list[int(X)]
                output+=self.colors[char]
                output+=char
            output+= "\n"
        output+="\u001b[0m"
        return output

    elements = {"Player":'O',"Wall":'#',"Empty":" ","Ball":"."}

    def move_char(self,char:str,old:Vector2,new:Vector2):
        """Changes the position of a element in the field """

        if char == "1":
            if self.field[new.Y][new.X] == 2:
                self.field[new.Y][new.X] = 5
            elif self.field[new.Y][new.X] == 6:
                self.field[new.Y][new.X] = 7
            else:
                self.field[new.Y][new.X] = self.field[old.Y][old.X]
                self.field[old.Y][old.X]= 0
    
        else:
            self.field[new.Y][new.X] = self.field[old.Y][old.X]
        
        
        if self.field[old.Y][old.X] == 5:
            self.field[old.Y][old.X] = 2
        elif self.field[old.Y][old.X] == 7:
            self.field[old.Y][old.X] = 6
        else:
            self.field[old.Y][old.X] = 0






