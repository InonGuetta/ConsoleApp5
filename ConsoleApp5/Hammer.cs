using System;

public class Hammer : Tool
{



    
    // המתודות שעשינו להם פולימורפיזם והשתמשנו אצלם ב override
    // קונסטרקטור
    public Hammer(string name, double weight) : base(name, weight)
    {


    }



    public override void Describe()
    {
        Console.WriteLine($" the name tool its {name} and the weight of its {weight} kg");

    }
    public override void Use()

    {
        Console.WriteLine("Hammer is used to make holes.");

    }


}





