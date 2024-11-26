/* World class for modeling the entire in-game world
 */

class World {
  Space entry;
  
  public World () {
    Space entry    = new Space("Entry");
    Space corridor = new Space("Corridor");
    
    // Addition
    Space door1    = new Space("Addition", "1+1", "2");
    Space door1task1 = new Space("Task1 ", "2+3","5");
    Space door1task2 = new Space("Task2","1+3","4");
    Space door1task3 = new Space("Task3","2+2","4");
    Space door1task4 = new Space ("Task4","2+1","3");
    Space door1task5 = new Space("Task5", "5+4","9");
    Space door1task6 = new Space("Task6" ,"3+3" ,"6");
    
    //Subtraction
    Space door2    = new Space("Subtraction", "2-1", "1");
    Space door2task1 = new Space("Task1 ", "61","5");
    Space door2task2 = new Space("Task2","10-6","4");
    Space door2task3 = new Space("Task3","8-6","2");
    Space door2task4 = new Space ("Task4","13-3","10");
    Space door2task5 = new Space("Task5", "12-2","10");
    Space door2task6 = new Space("Task6" ,"12-6","6");
    
    // Greater than
    Space door3     = new Space("Greater_than");
    Space door3task1 = new Space("Task1", "Which number is biggest, 19 or 29", "29");
    Space door3task2 = new Space("Task2", "Which number is biggest, 22 or 12", "22");
    Space door3task3 = new Space("Task3", "Which number is biggest, 40 or 49", "49");
    Space door3task4 = new Space("Task4", "Which number is biggest, 50 or 60", "60");
    Space door3task5 = new Space("Task5", "Which number is biggest, 88 or 80", "88");
    Space door3task6 = new Space("Task6", "Which number is biggest, 32 or 37", "37");
    
    // Edges
    entry.AddEdge("door", corridor);

    // Corridor
    corridor.AddEdge("Addition", door1);
    corridor.AddEdge("Subtraction", door2);
    corridor.AddEdge("Greater_than", door3);

    // Number recognition
    door1.AddEdge("Task1", door1task1);
    door1task1.AddEdge("Task2", door1task2);
    door1task2.AddEdge("Task3", door1task3);
    door1task3.AddEdge("Task4", door1task4);
    door1task4.AddEdge("Task5", door1task5);
    door1task5.AddEdge("Task6", door1task6);

    // Corridor and Edges in door2
    door2.AddEdge("Task1",door2task1);
    door2task1.AddEdge("Task2",door2task2);
    door2task2.AddEdge("Task3",door2task3);
    door2task3.AddEdge("Task4", door2task4);
    door2task4.AddEdge("Task5",door2task5);
    door2task5.AddEdge("Task6",door2task6);

    // Greater than or Less than tasks
    door3.AddEdge("Task1", door3task1);
    door3task1.AddEdge("Task2", door3task2);
    door3task2.AddEdge("Task3", door3task3);
    door3task3.AddEdge("Task4", door3task4);
    door3task4.AddEdge("Task5", door3task5);
    door3task5.AddEdge("Task6", door3task6);
    
    /*Remove comment when boss is implementet.
       door3task6.AddEdge("BOSS", door3Boss); 
    */

    this.entry = entry;
  }
  
  public Space GetEntry () {
    return entry;
  }
}

