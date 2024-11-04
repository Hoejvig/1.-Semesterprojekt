/* World class for modeling the entire in-game world
 */

class World {
  Space entry;
  
  public World () {
    Space entry    = new Space("Entry");
<<<<<<< Updated upstream
    Space corridor = new Space("Corridor", question:"2+2", answer:"4");
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
    Space corridor = new Space("Corridor");
    
    // Number recognition
    Space door1     = new Space("Number_recognition");
    Space door1task1 = new Space("Task1", "What is the first number you see when you look at the number 5?", "5");
    Space door1task2 = new Space("Task2", "If you have the number 3, how many fingers do you need to hold up to show the same number?", "3");
    
    // Addition and subtraktion
    Space door2     = new Space("Addition_and_subtraktion", "2+2", "4");
    
    // Greater than or less than
    Space door3     = new Space("Greater_than_less than");
    Space door3task1 = new Space("Task1", "Are 5 'greater' or 'less' than 3", "greater");
    Space door3task2 = new Space("Task2", "Is this equation '3>1' 'correct' or 'false'", "correct");
    Space door3task3 = new Space("Task3", "Are 3 'greater' or 'less' than 5", "less");
    Space door3task4 = new Space("Task4", "Is this equation '7<3' 'correct' or 'false'", "false");
    Space door3task5 = new Space("Task5", "Is this equation '3>5' 'correct' or 'false'", "false");
    Space door3task6 = new Space("Task6", "Are 3 'greater' or 'equal' or 'less' than 5?", "equal");
    
    // Double and half
    Space door4     = new Space("Double_and_half");
    
    entry.AddEdge("door", corridor);
    
    // Corridor
    corridor.AddEdge("Number_recognition", door1);
    corridor.AddEdge("Addition_and_subtraktion", door2);
    corridor.AddEdge("Greater_than_less_than", door3);
    corridor.AddEdge("Double_and_half", door4);
    
    // Number recognition
    door1.AddEdge("Task1", door1task1);
    door1task1.AddEdge("Task2", door1task2);
>>>>>>> Stashed changes
    
    //Greater than or Less than tasks
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

