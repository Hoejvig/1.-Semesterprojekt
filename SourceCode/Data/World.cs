/* World class for modeling the entire in-game world
 */

class World {
  private Space entry;
  
  public World () {
    Space entry    = new Space("Entry");
    Space hub = new Space("Hub", "Here you can choose between multiple doors.\\That all end up at different places.");
    Space end = new Space("End of Game", "Congratulations for finishing the game, you can now add, subtract and find the bigger of two numbers!");
    
    // Addition
    Space door1    = new Space("Addition", "Addition is when you put two or more numbers together to find out how much they add up to. \\It's something we do all the time, like when we count our money, figure out how much we spent at the store, or even add up time. \\Which is why it is so important to learn, an example is 2 + 2 = 4");
    SpaceQuestion door1task1 = new SpaceQuestion("Task1 ", "What is 4 + 1","5");
    SpaceQuestion door1task2 = new SpaceQuestion("Task2","What is 2 + 3","5");
    SpaceQuestion door1task3 = new SpaceQuestion("Task3","What is 1 + 3","4");
    SpaceQuestion door1task4 = new SpaceQuestion("Task4","What is 3 + 2","5");
    SpaceQuestion door1task5 = new SpaceQuestion("Task5", "What is 2 + 2","4");
    SpaceQuestion door1task6 = new SpaceQuestion("Task6" ,"What is 2 + 1" ,"3");

    // Creating the Boss Addition Space
    string[] questionsBossAdd = { "What is 6 + 2?", "What is 4 + 3?", "What is 5 + 1?", "What is 2 + 6?", "What is 5 + 4?", "What is 3 + 3?", "What is 4 + 1?" };
    string[] answersBossAdd = { "8", "7", "6", "8", "9", "6", "5" };
    
    SpaceBoss bossAddition = new SpaceBoss("Add_Boss", new Item("Addition Emblem"), 100, questionsBossAdd, answersBossAdd);
    door1task6.AddEdge("Add_Boss", bossAddition);
    bossAddition.AddEdge("Hub", hub);
    
    // Subtraction
    Space door2    = new Space("Subtraction", "Subtraction is when you take one number away from another. \\It's a basic math skill shown by the symbol (-), and it helps you find out how much is left or the difference between two numbers. An example of subtraction is 2 - 1 = 1");
    SpaceQuestion door2task1 = new SpaceQuestion("Task1 ", "What is 6 - 1","5");
    SpaceQuestion door2task2 = new SpaceQuestion("Task2","What is 10 - 6","4");
    SpaceQuestion door2task3 = new SpaceQuestion("Task3","What is 8 - 6","2");
    SpaceQuestion door2task4 = new SpaceQuestion("Task4","What is 13 - 3","10");
    SpaceQuestion door2task5 = new SpaceQuestion("Task5", "What is 12 - 2","10");
    SpaceQuestion door2task6 = new SpaceQuestion("Task6" ,"What is 12 - 6","6");
    
    // Creating the Boss Subtraction Space
    string[] questionsBossSub = { "What is 6-4?", "What is 10 - 2?", "What is 10 - 5?", "What is 13 - 6?","What is 6 - 6?","What is 8 - 3?","What is 12 - 7?" };
    string[] answersBossSub = {"2","8","5","7","0","5","5"};
    
    SpaceBoss bossSubtraction = new SpaceBoss("Subtract_Boss", new Item("Subtraction Emblem"), 100, questionsBossSub, answersBossSub);
    door2task6.AddEdge("Subtract_Boss", bossSubtraction);
    bossSubtraction.AddEdge("Hub", hub);
    
    // Greater than
    Space door3     = new Space("Greater_than", "Greater than/bigger is when one number is bigger than another. \\For example, if you have 8 apples and your friend has 5 apples, then you have a greater amount of apples.");
    SpaceQuestion door3task1 = new SpaceQuestion("Task1", "Which number is biggest, 19 or 29", "29");
    SpaceQuestion door3task2 = new SpaceQuestion("Task2", "Which number is biggest, 22 or 12", "22");
    SpaceQuestion door3task3 = new SpaceQuestion("Task3", "Which number is biggest, 40 or 49", "49");
    SpaceQuestion door3task4 = new SpaceQuestion("Task4", "Which number is biggest, 50 or 60", "60");
    SpaceQuestion door3task5 = new SpaceQuestion("Task5", "Which number is biggest, 88 or 18", "88");
    SpaceQuestion door3task6 = new SpaceQuestion("Task6", "Which number is biggest, 32 or 37", "37");
    
    // Creating the Boss Grater_than Space
    string[] questionsBossGreat = { "Which number is biggest, 83 or 84", "Which number is biggest, 26 or 16", "Which number is biggest, 30 or 50", "Which number is biggest, 14 or 18", "Which number is biggest, 71 or 17", "Which number is biggest, 99 or 96", "Which number is biggest, 67 or 66"};
    string[] answersBossGreat = { "84", "26", "50", "18", "71", "99", "67" };
    
    SpaceBoss bossGreat = new SpaceBoss("Great_Boss", new Item("Greater Emblem"), 100, questionsBossGreat, answersBossGreat);
    door3task6.AddEdge("Great_Boss", bossGreat);
    bossGreat.AddEdge("End_of_Game", end);
    
    // Entry and End edge
    entry.AddEdge("Door", hub);
    end.AddEdge("Hub", hub);

    // Hub edge
    hub.AddEdge("Addition", door1);
    
    // Locked Subtraction Space
    SpaceLocked subLock = new SpaceLocked("Subtraction_entry", "Addition Emblem", door2);
    hub.AddEdge("Subtraction_entry", subLock);
    subLock.AddEdge("Hub", hub);
    
    // Locked Greater_than Space
    SpaceLocked greatLock = new SpaceLocked("Greater_than_entry", "Subtraction Emblem", door3);
    hub.AddEdge("Greater_than_entry", greatLock);
    greatLock.AddEdge("Hub", hub);

    // Addition edges
    door1.AddEdge("Task1", door1task1);
    door1task1.AddEdge("Task2", door1task2);
    door1task2.AddEdge("Task3", door1task3);
    door1task3.AddEdge("Task4", door1task4);
    door1task4.AddEdge("Task5", door1task5);
    door1task5.AddEdge("Task6", door1task6);

    // Subtraction edges
    door2.AddEdge("Task1",door2task1);
    door2task1.AddEdge("Task2",door2task2);
    door2task2.AddEdge("Task3",door2task3);
    door2task3.AddEdge("Task4", door2task4);
    door2task4.AddEdge("Task5",door2task5);
    door2task5.AddEdge("Task6",door2task6);

    // Greater than or Less than edges
    door3.AddEdge("Task1", door3task1);
    door3task1.AddEdge("Task2", door3task2);
    door3task2.AddEdge("Task3", door3task3);
    door3task3.AddEdge("Task4", door3task4);
    door3task4.AddEdge("Task5", door3task5);
    door3task5.AddEdge("Task6", door3task6);

    this.entry = entry;
  }
  
  public Space GetEntry () {
    return entry;
  }
}

