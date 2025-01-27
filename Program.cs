// See https://aka.ms/new-console-template for more information

using Mission3;

internal class Program
{
    
    // creates a list of FoodItems 
    
    static List<FoodItem> foodInventory = new List<FoodItem>();
    
    public static void Main(string[] args)
    {

        int taskNum = 0;
        
        // loops through potential tasks until the user types 4 to exit the program

        while (taskNum != 4)
        {
            // Prints out potential tasks the user can do
            
            Console.WriteLine("\nTASKS:");
            Console.WriteLine("1: Add new food items to the list");
            Console.WriteLine("2: Remove existing food items from the list");
            Console.WriteLine("3: View the current list of food items");
            Console.WriteLine("4: Exit the program");
            Console.Write("Please select a task by typing the corresponding number: ");
            
            // Checks to see if the input is a number between 1-4 
            // If the number is between 1-4 the if statement checks the number and performs whatever code 
            // coincides with that number
            
            if (int.TryParse(Console.ReadLine(), out taskNum))
            {
                if (taskNum == 1)
                {
                    Console.WriteLine("\nYou selected: Add new food items to the list.");
                    
                    AddItem();
                }
                else if (taskNum == 2)
                {
                    Console.WriteLine("\nYou selected: Remove existing food items from the list.");
                    
                    RemoveItem();
                }
                else if (taskNum == 3)
                {
                    Console.WriteLine("\nYou selected: View the current list of food items.");
                    
                    PrintItems();
                }
                else if (taskNum == 4)
                {
                    Console.WriteLine("\nExiting the program. Goodbye!");
                }
                else
                {
                    Console.WriteLine("\nInvalid option. Please select a number between 1 and 4.");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a valid number.");
            }
        }

        static void AddItem()
        {
            // Gets user input to make a food item
            
            Console.Write("\nEnter the name of the food item: ");
            string name = Console.ReadLine();
                    
            Console.Write("Enter the category of the food item: ");
            string category = Console.ReadLine();
                    
            Console.Write("Enter the quantity of the food item: ");
            int quantity = int.Parse(Console.ReadLine());
                    
            Console.Write("Enter the expiration date of the food item (MM/DD/YYYY): ");
            DateTime expirationDate = DateTime.Parse(Console.ReadLine());
            
            // creates a new FoodItem and adds it to the foodInventory array so it can be accessed later
                    
            foodInventory.Add(new FoodItem(name, category, quantity, expirationDate));
                    
            Console.WriteLine($"\nYou added {quantity} units of {name} to the {category} category.");
        }

        static void RemoveItem()
        {
            // Asks the user the name of the food item they want to remove
            
            Console.Write("\nEnter the name of the food item: ");
            string name = Console.ReadLine();
            
            // looks through the foodInventory array to find the FootItem that matches the name the user inputted
            
            FoodItem itemToRemove = foodInventory.Find(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            
            // Checks to see if there is a FoodItem by that name and removes it if so
            
            if (itemToRemove != null)
            {
                foodInventory.Remove(itemToRemove);
                Console.WriteLine("\nFood item removed successfully!");
            }
            else
            {
                Console.WriteLine("\nFood item not found.");
            }
        }

        static void PrintItems()
        {
            
            // Checks to see if there is items in the list to print
            
            if (foodInventory.Count == 0)
            {
                Console.WriteLine("\nThere are no items in the list.");
            }
            else
            {
                Console.WriteLine("\nThere are " + foodInventory.Count + " food items in the list.");
                
                // Loops through the foodInventory array and prints out each FoodItem by calling the Print()
                // method in the FoodItem class
                
                foreach (FoodItem items in foodInventory)
                {
                    items.Print();
                    
                    //test comment
                }
            }
        }
        
    }
}