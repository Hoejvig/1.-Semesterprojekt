/* World class for modeling the entire in-game world
 */

class World {
  Space entry;
  
  public World () {
    Space entry    = new Space("Entry");
    Space corridor = new Space("Corridor", "Here you can choose between multiple doors.\\That all end up at different places.");
    
    // Addition
    SpaceQuestion door1    = new SpaceQuestion("Addition", "1+1", "2");
    SpaceQuestion door1task1 = new SpaceQuestion("Task1 ", "2+3","5");
    SpaceQuestion door1task2 = new SpaceQuestion("Task2","1+3","4");
    SpaceQuestion door1task3 = new SpaceQuestion("Task3","2+2","4");
    SpaceQuestion door1task4 = new SpaceQuestion("Task4","2+1","3");
    SpaceQuestion door1task5 = new SpaceQuestion("Task5", "5+4","9");
    SpaceQuestion door1task6 = new SpaceQuestion("Task6" ,"3+3" ,"6");
    SpaceLocked lane = new SpaceLocked("Lane", "Addition Emblem", door1task6);
    corridor.AddEdge("Lane", lane);
    
    // Subtraction
    SpaceQuestion door2    = new SpaceQuestion("Subtraction", "2-1", "1");
    SpaceQuestion door2task1 = new SpaceQuestion("Task1 ", "61","5");
    SpaceQuestion door2task2 = new SpaceQuestion("Task2","10-6","4");
    SpaceQuestion door2task3 = new SpaceQuestion("Task3","8-6","2");
    SpaceQuestion door2task4 = new SpaceQuestion("Task4","13-3","10");
    SpaceQuestion door2task5 = new SpaceQuestion("Task5", "12-2","10");
    SpaceQuestion door2task6 = new SpaceQuestion("Task6" ,"12-6","6");
    
    // Greater than
    Space door3     = new Space("Greater_than");
    SpaceQuestion door3task1 = new SpaceQuestion("Task1", "Which number is biggest, 19 or 29", "29");
    SpaceQuestion door3task2 = new SpaceQuestion("Task2", "Which number is biggest, 22 or 12", "22");
    SpaceQuestion door3task3 = new SpaceQuestion("Task3", "Which number is biggest, 40 or 49", "49");
    SpaceQuestion door3task4 = new SpaceQuestion("Task4", "Which number is biggest, 50 or 60", "60");
    SpaceQuestion door3task5 = new SpaceQuestion("Task5", "Which number is biggest, 88 or 80", "88");
    SpaceQuestion door3task6 = new SpaceQuestion("Task6", "Which number is biggest, 32 or 37", "37");
    
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

