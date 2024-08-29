using ForumApp.Data.Models;
using System;
using System.Collections.Generic;

namespace ForumApp.Data.Seeding
{
    internal class PostSeeder
    {
        internal Post[] GeneratePosts()
        {
            ICollection<Post> posts = new HashSet<Post>();
            Post currentPost;

            currentPost = new Post()
            {
                Id = Guid.NewGuid(),  // Generate a unique GUID for Id
                Title = "My first post",
                Content = "Ksdfn, rprprprmg tmerptm mr trlntrltm, rptmr."
            };
            posts.Add(currentPost);

            currentPost = new Post()
            {
                Id = Guid.NewGuid(),  // Generate a unique GUID for Id
                Title = "My second post",
                Content = "Jspsejfpe lfnrtl pmrprmp me ptrtneptp trt. Kmetertoerton elnerl rm."
            };
            posts.Add(currentPost);

            currentPost = new Post()
            {
                Id = Guid.NewGuid(),  // Generate a unique GUID for Id
                Title = "My third post",
                Content = "Ojdoffornfo fnro forjnoerntorj, owenfron, prnrpr."
            };
            posts.Add(currentPost);

            return posts.ToArray();
        }
    }
}