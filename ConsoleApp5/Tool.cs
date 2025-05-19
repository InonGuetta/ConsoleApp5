using System;

public abstract class Tool
{

    // שדות 
        public string name { get; set; }
        public double weight { get; set; }

    // קונסטרקטור
    public Tool(string name, double weight)
    {
        this.name = name;
        this.weight = weight;


    }

    // מתודות
    public abstract void Describe();
    public abstract void Use();

}