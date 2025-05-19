using System;

public class Drill : Tool
{

    // המתודות שעשינו להם פולימורפיזם והשתמשנו אצלם ב override
    public Drill(string name, double weight) : base(name, weight)
    {


    }



    public override void Describe()
    {
        Console.WriteLine($" the name tool its {name} and the weight of its {weight} kg");

    }
    public override void Use()

    {
        Console.WriteLine("Drill is used to make holes.");

    }
    

}


    


