class CommandInventory : BaseCommand, ICommand
{
    public CommandInventory()
    {
        description = "Show your inventory";
    }

    public void Execute(Context context, string command, string[] parameters)
    {
        Game.inventory.ShowInventory();
    }
}