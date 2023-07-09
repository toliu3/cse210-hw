using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> comments1 = new List<Comment>();
        Comment comment1 = new Comment();
        comment1._name = "TastyTaster";
        comment1._comment = "These pasta recipes are making me hungry! Can't wait to try them out.";
        comments1.Add(comment1);

        Comment comment2 = new Comment();
        comment2._name = "CookingQueen";
        comment2._comment = "I tried the creamy garlic pasta, and it was amazing! Thanks for the recipe.";
        comments1.Add(comment2);

        Comment comment3 = new Comment();
        comment3._name = "PastaLover123";
        comment3._comment = "The carbonara recipe is a must-try! My family loved it.";
        comments1.Add(comment3);

        Video video1 = new Video();
        video1._title =  "Delicious Pasta Recipes";
        video1._author = "FoodiesKitchen";
        video1._videoLength = 320;
        video1._comments = comments1;
        videos.Add(video1);
        
        //
        List<Comment> comments2 = new List<Comment>();
        Comment comment21 = new Comment();
        comment21._name = "TimeManager";
        comment21._comment = "I've implemented some of these tips, and my productivity has skyrocketed!";
        comments2.Add(comment21);

        Comment comment22 = new Comment();
        comment22._name = "OrganizedLife";
        comment22._comment =  "The advice about prioritizing tasks was a game-changer for me. Thanks!";
        comments2.Add(comment22);

        Comment comment23 = new Comment();
        comment23._name = "DailyRoutine";
        comment23._comment =  "This video came at the perfect time. I needed a productivity boost.";
        comments2.Add(comment23);

        Comment comment24 = new Comment();
        comment24._name = "toliu3";
        comment24._comment =  "Good job, thanks for your sharing.";
        comments2.Add(comment24);
        
        Video video2 = new Video();
        video2._title =  "10 Tips for a Productive Day";
        video2._author = "ProductivityHacks";
        video2._videoLength = 435;
        video2._comments = comments2;
        videos.Add(video2);

        //
        List<Comment> comments3 = new List<Comment>();
        Comment comment31 = new Comment();
        comment31._name = "AdventurousSoul";
        comment31._comment =  "I can't believe these stunning places are budget-friendly! Adding them to my travel list.";
        comments3.Add(comment31);

        Comment comment32 = new Comment();
        comment32._name = "FrugalExplorer";
        comment32._comment =  "The tips for finding cheap accommodation were incredibly helpful. Thank you!";
        comments3.Add(comment32);

        Comment comment33 = new Comment();
        comment33._name = "WanderlustDreamer";
        comment33._comment = "This video has inspired me to travel more without breaking the bank.";
        comments3.Add(comment33);

        Video video3 = new Video();
        video3._title =  "Traveling on a Budget: Top Destinations";
        video3._author = "BudgetTraveler";
        video3._videoLength = 650;
        video3._comments = comments3;
        videos.Add(video3);

        foreach (Video video in videos )
        {
            video.Display();
        }

        
    }
}