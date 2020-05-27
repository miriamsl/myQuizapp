using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System;
using System.Linq;

namespace myQuizapp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new QuestionContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<QuestionContext>>()))
            {
                // Look for any movies.
                if (context.Question.Any())
                {
                    return;   // DB has been seeded
                }

                context.Question.AddRange(
                    new Question
                    {
                        Quest = "What is the tallest mountain in the world?",
                        RightAnswer = "Mount Everest",
                        alt1 = "K2",
                        alt2 = "Mount Everest",
                        alt3 = "Makalu"
                    },

                    new Question
                    {
                        Quest = "What is the capitol of Norway? ",
                        RightAnswer = "Oslo",
                        alt1 = "Oslo",
                        alt2 = "Stockholm",
                        alt3 = "London"
                    },

                    new Question
                    {
                        Quest = "What is the largest country in the world? ",
                        RightAnswer = "Russia",
                        alt1 = "USA",
                        alt2 = "China",
                        alt3 = "Russia"
                    },

                    new Question
                    {
                        Quest = "What is NTNU? ",
                        RightAnswer = "University",
                        alt1 = "University",
                        alt2 = "Shopping mall",
                        alt3 = "Hotel"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
