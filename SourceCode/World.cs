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
    Space door2    = new Space("Addition_and_subtraktion", "1+1", "2");
    Space door2task1 = new Space("Task1 ", "3+2","5");
    Space door2task2 = new Space("Task2","3-2","1");
    Space door2task3 = new Space("Task3","7+3","10");
    Space door2task4 = new Space ("Task4","7-3","4");
    Space door2task5 = new Space("Task5", "8+2","10");
    Space door2task6 = new Space("Task6" ,"8-2" ,"6" );
    
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
    Space door4task1 = new Space("Task1", "If you have 2 apples, how many apples do you have if you double them?", "4");
    Space door4task2 = new Space("Task2", "You have 6 basketballs. How many balls do you have if you take half?", "3");
    Space door4task3 = new Space("Task3", "You have 10 cakes. What is half of the cakes?", "5");
    Space door4task4 = new Space("Task4", "There are 3 dogs. How many dogs are there if we make twice as many dogs? ", "6");
    Space door4task5 = new Space("Task5", "If there are 4 cats, how many cats are there if we double them?", "8");
    Space door4task6 = new Space("Task6", "If you have 8 crayons, how many do you have if you only keep half?", "4");
    Space door4boss1 = new Space("boss1");


    // Edges
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

    // Double and half
    door4.AddEdge("Task1", door4task1);
    door4task1.AddEdge("Task2", door4task2);
    door4task2.AddEdge("Task3", door4task3);
    door4task3.AddEdge("Task4", door4task4);
    door4task4.AddEdge("Task5", door4task5);
    door4task5.AddEdge("Task6", door4task6);
    door4task6.AddEdge("Boss", door4boss1);
    door4boss1.AddEdge("Corridor", corridor);

    /*Remove comment when boss is implementet.
       door3task6.AddEdge("BOSS", door3Boss); 
    */

    this.entry = entry;
  }
  
  public Space GetEntry () {
    return entry;
  }
}

