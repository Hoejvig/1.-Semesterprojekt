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
    Space door1task3 = new Space("Task3", "What is the last number you see when you count from 1 to 4?", "4");
    Space door1task4 = new Space("Task4", "What number comes immediately after 6?", "7");
    Space door1task5 = new Space("Task5", "If you start at the number 2 and count up by one, what number do you get to after 3 steps?", "5");
    Space door1task6 = new Space("Task6", "If you count backward from 5, what is the number just before 4?", "3");



    // Addition and subtraktion
    Space door2     = new Space("Addition_and_subtraktion", "2+2", "4");
    
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
    door1task2.AddEdge("Task3", door1task3);
    door1task3.AddEdge("Task4", door1task4);
    door1task4.AddEdge("Task5", door1task5);
    door1task5.AddEdge("Task6", door1task6);
    

    
    this.entry = entry;
  }
  
  public Space GetEntry () {
    return entry;
  }
}

