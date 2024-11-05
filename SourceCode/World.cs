/* World class for modeling the entire in-game world
 */

class World {
  Space entry;
  
  public World () {
    Space entry    = new Space("Entry");
    Space corridor = new Space("Corridor");
    
    // Number recognition
    Space door1     = new Space("Number_recognition");
    Space door1task1 = new Space("Task1", "What is the first number you see when you look at the number 5?", "5");
    Space door1task2 = new Space("Task2", "If you have the number 3, how many fingers do you need to hold up to show the same number?", "3");
    
    // Addition and subtraktion
    Space door2    = new Space("Addition_and_subtraktion", "1+1", "2");
    Space door2task1 = new Space("Task1 ", "3+2","5");
    Space door2task2 = new Space("Task2","3-2","1");
    Space door2task3 = new Space("Task3","7+3","10");
    Space door2task4 = new Space ("Task4","7-3","4");
    Space door2task5 = new Space("Task5", "8+2","10");
    Space door2task6 = new Space("Task6" ,"8-2" ,"6" );
    
        //Corridor and Edges in door2
    
        door2.AddEdge("Task1",door2task1);
        door2task1.AddEdge("Task2",door2task2);
        door2task2.AddEdge("Task3",door2task3);
        door2task3.AddEdge("Task4", door2task4);
        door2task4.AddEdge("Task5",door2task5);
        door2task5.AddEdge("Task6",door2task6);

    // Greater than less than
    Space door3     = new Space("Greater_than_less than");
    
    // Double and half
    Space door4     = new Space("Double_and_half");
    
    entry.AddEdge("door", corridor);
    
    // Corridor
    corridor.AddEdge("Number_recognition", door1);
    corridor.AddEdge("Addition_and_subtraktion", door2);
    corridor.AddEdge("Greather_than_less_than", door3);
    corridor.AddEdge("Double_and_half", door4);
    
    // Number recognition
    door1.AddEdge("Task1", door1task1);
    door1task1.AddEdge("Task2", door1task2);
    
    this.entry = entry;
  }
  
  public Space GetEntry () {
    return entry;
  }
}

