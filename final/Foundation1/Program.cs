using Foundation1;
using System;

class Program
{
    static void Main(string[] args)
    {
        // video 1
        Video video1 = new Video("Breeze KAY/O Lineups w/ the KAY/O VOICE ACTOR", "todo", 1764);
        video1.AddComment("I like this dynamic alot", "@frostedolive4969" );
        video1.AddComment("SHEESH", "@SilverceVAL");
        video1.DisplayVideoDetails();

        // video 2
        Video video2 = new Video("How far is a .22 lethal?", "Garand Thumb", 765);
        video2.AddComment("This is insane! So .22 in a pinch can actually be a very good range defense option. With as quiet as it is, you’d never give up your location.", "@joejones323");
        video2.AddComment("Nobody ever said “don’t worry, they’re only shooting at us with a .22”", "@JohnnyTruthseed");
        video2.AddComment("Alls I know is that no matter what caliber, no matter from how far away, I don't want it being fired at me", "@Khan.WrathOf");
        video2.DisplayVideoDetails();

        // video 3 
        Video video3 = new Video("Spring Cut Day 8 - Arms", "Sam Sulek", 2943);
        video3.AddComment("Sam is the Bob Ross of bodybuilding", "@CS-of8oj");
        video3.AddComment("For every like I will do a puch up", "@steamy4498");
        video3.DisplayVideoDetails();

    }
}