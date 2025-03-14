using System;
using System.Collections.Generic;

namespace Assi2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PostProxy> Posts = new List<PostProxy>();

            PostProxy p1 = new PostProxy();
            Posts.Add(p1);

            PostProxy p2 = new PostProxy();
            Posts.Add(p2);

            PostProxy p3 = new PostProxy();
            Posts.Add(p3);

            
            Post postPrototype = new Post();

            Console.WriteLine("Welcome to the Social Network!\nEnter a command to get started, or 'help' to see a list of commands:");
            string command = "";

            while(command != "quit") {
                string[] commandArgs = command.Split(":");
                int postNum = -1;
                if(commandArgs.Length > 1) {
                    try {
                        postNum = int.Parse(commandArgs[1]);
                        postNum--;
                        
                        if(postNum < 0 || postNum >= Posts.Count) {
                            Console.WriteLine("Error: Invalid post number specified!");
                            postNum = -1;
                        }
                    } catch(FormatException) {
                        Console.WriteLine("Error: Invalid post number specified!");
                    }
                }

                switch(commandArgs[0]) {
                    case "help":
                        Console.WriteLine("help\t\t\tDisplay this menu");
                        Console.WriteLine("new\t\t\tCreate a new post.");
                        Console.WriteLine("list\t\t\tList all posts.");
                        Console.WriteLine("download:[id]\t\tDownload a post.");
                        Console.WriteLine("settitle:[id]:[title]\tSet a post's title.");
                        Console.WriteLine("setbody:[id]:[body]\tSet a post's body.");
                        Console.WriteLine("view:[id]\t\tView a post.");
                        Console.WriteLine("quit\t\t\tQuit the application");
                        break;

                    case "new":
                        PostProxy newProxy = new PostProxy();
                        newProxy.CreateNewPost(postPrototype); 
                        Posts.Add(newProxy);
                        Console.WriteLine("New post created (ID: " + Posts.Count + ")");
                        break;

                    case "list":
                        Console.WriteLine("Post's List:");
                        for(int i = 0; i < Posts.Count; i++) {
                            Console.WriteLine($"{i+1}.\t");
                            Posts[i].Print();
                        }
                        break;

                    case "download":
                        if(postNum != -1) {
                            Posts[postNum].Download();
                            Console.WriteLine($"Post {postNum+1} downloaded successfully!");
                        }
                        break;

                    case "settitle":
                        if(postNum != -1 && commandArgs.Length > 2) {
                            string newTitle = commandArgs[2];
                            Posts[postNum].SetTitle(newTitle);
                            Console.WriteLine($"Title for post {postNum+1} updated!");
                        } else {
                            Console.WriteLine("Error: Invalid command format. Use settitle:[id]:[title]");
                        }
                        break;

                    case "setbody":
                        if(postNum != -1 && commandArgs.Length > 2) {
                            string newBody = commandArgs[2];
                            Posts[postNum].SetBody(newBody);
                            Console.WriteLine($"Body for post {postNum+1} updated!");
                        } else {
                            Console.WriteLine("Error: Invalid command format. Use setbody:[id]:[body]");
                        }
                        break;

                    case "view":
                        if(postNum != -1) {
                            Console.WriteLine($"Post {postNum+1}:");
                            Posts[postNum].Print();
                        }
                        break;

                    case "":
                        break;

                    default:
                        if(command != "") {
                            Console.WriteLine("Invalid command. Type 'help' for a list of commands.");
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            
            Console.WriteLine("Thank you for using the Social Network!");
        }
    }
}
