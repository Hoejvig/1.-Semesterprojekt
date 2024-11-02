namespace DefaultNamespace;
public class Boss
{
    //Attributes
    public static int HealthPoints = 100;
    
    
    //Method to attack Player HP, if Player gets answer wrong.
    public void DamagePlayer()
    {
        //If the question is answered false
        if (Question == false)
        {
            Player.HealthPoints -= 10;
            Console.WriteLine($"Wrong Answer. You lose 10 HP. Your Current HP: {Player.HealthPoints}");
        }
        //If the question is answered right
        else if (Question == true)
        {
            Boss.HealthPoints -= 10;   
            Console.WriteLine($"CORRECT! Nice One. Boss Current HP: {Boss.HealthPoints}");
        }
    }
    
}
