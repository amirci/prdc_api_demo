using System;
using System.Collections.Generic;
using MavenThought.Commons.Extensions;

namespace MavenThought.PrDC.Api.Tests
{
    public class RandomEntities
    {
        /// <summary>
        /// Generates a random collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static IEnumerable<T> CollectionOf<T>(int amount)
        {
            return amount.Times(i => GenerateRandomOf<T>(i));
        }

        /// <summary>
        /// Generates a random value for {T}
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="i"></param>
        /// <returns></returns>
        public static T GenerateRandomOf<T>(int i)
        {
            Func<int, object> fn = RandomSession;

            if (typeof(T) == typeof(Presenter))
            {
                fn = RandomPresenter;
            }

            return (T)fn(i);
        }

        private static Session RandomSession(int i)
        {
            return new Session
            {
                Id = new DateTime().Millisecond,
                Track = string.Format("Tracks {0}", i),
                Abstract = "This is a very nice session",
                Presenter = string.Format("Presenter {0}", i),
                Style = "Dojo",
                Year = 2011,
                Title = string.Format("How to work with lions part {0}", i)
            };
        }

        private static Presenter RandomPresenter(int i)
        {
            return new Presenter
            {
                Id = new DateTime().Millisecond,
                Bio = "This is the bio for a random presenter",
                Blog = "http://blog.com",
                Company = "New software",
                Email = string.Format("presenter_{0}@gmail.com", i),
                FirstName = string.Format("Presenter_{0}", i),
                LastName = "Last name",
                Location = string.Format("Some location {0}", i),
                Twitter = string.Format("@presenter_{0}", i),
                Year = 2011,
                WebSite = "http://thepresenter.com",
                Picture = "somepicture.jpg"
            };
        }
    }
}