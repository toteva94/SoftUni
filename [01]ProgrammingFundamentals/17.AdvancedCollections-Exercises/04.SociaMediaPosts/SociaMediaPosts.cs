namespace _04.SociaMediaPosts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SociaMediaPosts
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var likes = new Dictionary<string, int>();
            var dislikes = new Dictionary<string, int>();
            var comments = new Dictionary<string, Dictionary<string, string>>();
            var comment = new List<string>();

            while (input != "drop the media")
            {
                var elements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstElement = elements[0];
                var postName = elements[1];
                comment.Clear();

                if (firstElement.Equals("post"))
                {
                    if (!likes.ContainsKey(postName))
                    {
                        likes[postName] = 0;
                        dislikes[postName] = 0;
                        comments[postName] = new Dictionary<string, string>();
                    }
                }
                else if (firstElement.Equals("like"))
                    likes[postName]++;
                else if (firstElement.Equals("dislike"))
                    dislikes[postName]++;
                else if(firstElement.Equals("comment"))
                {
                    var commentator = elements[2];
                    for (int i = 3; i < elements.Length; i++)
                    {
                        comment.Add(elements[i]);
                    }

                    comments[postName][commentator] = string.Join(" ", comment);
                }

                input = Console.ReadLine();
            }

            foreach (var namePost in comments)
            {
                Console.WriteLine($"Post: {namePost.Key} | Likes: {likes[namePost.Key]} | Dislikes: {dislikes[namePost.Key]}");
                Console.WriteLine("Comments:");
                if (namePost.Value.Count == 0)
                    Console.WriteLine("None");
                else
                {
                    foreach (var post in namePost.Value)
                    {
                        Console.WriteLine($"*  {post.Key}: {string.Join(" ", post.Value)}");
                    }
                }
            }
        }
    }
}
