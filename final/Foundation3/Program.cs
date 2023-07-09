using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("32 W 5030 S", "Salt Lake City", "UT 84129", "USA");
        string title = "Introduction to Machine Learning";
        string description = "Join us for an informative lecture on the basics of machine learning.";
        Lecture lecture = new Lecture("Helen Smith", 100, title, description, "2023-08-26", "14:00", address);
        Console.WriteLine($"Stander Details:\n{lecture.GetStanderDetails()}\n");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine($"Short Description:\nThe type of Event: Lecture\n{lecture.GetShortDescription()}\n");
        //
        Console.WriteLine("--------------------------------------------------------------");
        Address address1 = new Address("34 N Orange Avenue", "La Puente","CA 91744","USA");
        string title1 = "Networking Reception";
        string description1 = "Join us for a networking event to connect with industry professionals.";
        Reception reception = new Reception("info@eventplan.com", title1, description1, "2023-09-23", "19:00", address1);
        Console.WriteLine($"Stander Details:\n{reception.GetStanderDetails()}\n");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine($"Short Description:\nThe type of Event: Reception\n{reception.GetShortDescription()}\n");
        //
        Console.WriteLine("--------------------------------------------------------------");
        Address address2 = new Address("25 Eychander Road", "Rozet","WY 82727","USA");
        string title2 = "Summer Picnic";
        string description2 =  "Enjoy a fun-filled day with family and friends at our summer picnic.";
        OutdoorGathering outdoorGathering = new OutdoorGathering("Sunny", title2, description2, "2023-09-09", "09:00", address2);
        Console.WriteLine($"Stander Details:\n{outdoorGathering.GetStanderDetails()}\n");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine($"Short Description:\nThe type of Event: Reception\n{outdoorGathering.GetShortDescription()}");


    }
}