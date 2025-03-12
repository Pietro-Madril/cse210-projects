using System;

public class Resume
{
    public string _name;

    //When initiate the list do it in "new List<>" before use it
    public List<Job> _jobs = new List<Job>(); //link job informations
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs) //create a loop to call information from Job custom data type
        {
            job.Display(); //call job display
        }
    }
}