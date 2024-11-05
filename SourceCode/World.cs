/* World class for modeling the entire in-game world
 */

class World {
  Space entry;
  
  public World () {
    Space entry    = new Space("Entry");
    Space corridor = new Space("Corridor");
<<<<<<< Updated upstream
    Space cave     = new Space("Cave");
    Space pit      = new Space("Darkest Pit");
    Space outside  = new Space("Outside");
    
    entry.AddEdge("door", corridor);
    corridor.AddEdge("door", cave);
    cave.AddEdge("north", pit);
    cave.AddEdge("south", outside);
    pit.AddEdge("door", cave);
    outside.AddEdge("door", cave);
=======
    
    // Number recognition
    Space door1     = new Space("Number_recognition");
      
    // Addition and subtraktion
    Space door2     = new Space("Addition_and_subtraktion", "2+2", "4");
    
    // Greater than less than
    Space door3     = new Space("Greater_than_less than");
    
    // Double and half
    Space door4     = new Space("Double_and_half");
    Space door4task1 = new Space("Task1", "If you have 2 apples, how many apples do you have if you double them?", "4");
    Space door4task2 = new Space("Task2", "You have 6 basketballs. How many balls do you have if you take half?", "3");
    Space door4task3 = new Space("Task3", "You have 10 cakes. What is half of the cakes?", "5");
    Space door4task4 = new Space("Task4", "There are 3 dogs. How many dogs are there if we make twice as many dogs? ", "6");
    Space door4task5 = new Space("Task5", "If there are 4 cats, how many cats are there if we double them?", "8");
    Space door4task6 = new Space("Task6", "If you have 8 crayons, how many do you have if you only keep half?", "4");
    Space door4boss1 = new Space("boss1");
    
    // Corridor
    corridor.AddEdge("Number_recognition", door1);
    corridor.AddEdge("Addition_and_subtraktion", door2);
    corridor.AddEdge("Greather_than_less_than", door3);
    corridor.AddEdge("Double_and_half", door4);
    
    // Double and half
    door1.AddEdge("Task1", door4task1);
    door4task1.AddEdge("Task2", door4task2);
    door4task2.AddEdge("Task3", door4task3);
    door4task3.AddEdge("Task4", door4task4);
    door4task4.AddEdge("Task5", door4task5);
    door4task5.AddEdge("Task6", door4task6);
    door4task6.AddEdge("Boss", door4boss1);
    door4boss1.AddEdge("Corridor", corridor);
>>>>>>> Stashed changes
    
    this.entry = entry;
  }
  
  public Space GetEntry () {
    return entry;
  }
}

