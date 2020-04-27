﻿using System;
using System.Linq;

namespace SimpleLinq2
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 158 },
                new Profile() { Name = "고현정", Height = 172 },
                new Profile() { Name = "이문세", Height = 178 },
                new Profile() { Name = "하하", Height = 171 },
            };

            var profiles = arrProfile.
                Where(profile => profile.Height <  175).Where
                OrderBy(Profile => Profile.Height).
                Select(Profile =>
                new )
        }
    }
}
