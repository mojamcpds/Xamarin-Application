﻿using System;

namespace Courses.CourseLibrary
{
    public class CourseManager
    {
        private readonly Course[] courses;
        int currentIndex = 0;
        private readonly int lastIndex;


        public CourseManager()
            :this("Android")
        {
            
        }

        public CourseManager(string categoryTitle)
        {
            switch (categoryTitle)
            {
                case "Android":
                    courses = InitCoursesAndroid();
                    break;
                case "iOS":
                    courses = InitCoursesiOS();
                    break;
                case "Windows Phone":
                    courses = InitCoursesWindowsPhone();
                    break;
            }

            if(courses!=null)
                lastIndex = courses.Length - 1;
        }

        private Course[] InitCoursesAndroid()
        {
            var initCourses = new Course[] {
                new Course()
                {
                    Title = "Android for .NET Developers",
                    Description = "Provides an overview of the tools used in the Android " +
                    "development process including the newly released Android Studio.",
                    Image = "ps_top_card_01"
                },

                new Course()
                {
                    Title = "Android Dreams, Widgets, Notifications",
                    Description = "Provide users with a rich and interactive experience " +
                    "without ever requiring them to open your app.",
                    Image = "ps_top_card_02"
                },
                new Course()
                {
                    Title = "Android Photo/Video Programming",
                    Description = "Learn how to capitalize on the Android camera " +
                    "within your apps to capture still photos and video.",
                    Image = "ps_top_card_03"
                },
                new Course()
                {
                    Title = "Android Location-Based Apps",
                    Description = "Cover the wide range of Android location capabilities " +
                    "including determining user location, power management, and " +
                    "translating location data to human-readable addresses.",
                    Image = "ps_top_card_04"
                }

            };

            return initCourses;
        }

        private Course[] InitCoursesiOS()
        {
            var initCourses = new Course[] {
                new Course()
                {
                    Title = "iOS for .NET Developers",
                    Description = "Provides an overview of the tools used in the iOS " +
                    "development process including the newly released iOS Studio.",
                    Image = "ps_top_card_01"
                },

                new Course()
                {
                    Title = "iOS Dreams, Widgets, Notifications",
                    Description = "Provide users with a rich and interactive experience " +
                    "without ever requiring them to open your app.",
                    Image = "ps_top_card_02"
                },
                new Course()
                {
                    Title = "iOS Photo/Video Programming",
                    Description = "Learn how to capitalize on the iOS camera " +
                    "within your apps to capture still photos and video.",
                    Image = "ps_top_card_03"
                },
                new Course()
                {
                    Title = "iOS Location-Based Apps",
                    Description = "Cover the wide range of iOS location capabilities " +
                    "including determining user location, power management, and " +
                    "translating location data to human-readable addresses.",
                    Image = "ps_top_card_04"
                }

            };

            return initCourses;
        }

        private Course[] InitCoursesWindowsPhone()
        {
            var initCourses = new Course[] {
                new Course()
                {
                    Title = "Windows Phone for .NET Developers",
                    Description = "Provides an overview of the tools used in the Windows Phone " +
                    "development process including the newly released Windows Phone Studio.",
                    Image = "ps_top_card_01"
                },

                new Course()
                {
                    Title = "Windows Phone Dreams, Widgets, Notifications",
                    Description = "Provide users with a rich and interactive experience " +
                    "without ever requiring them to open your app.",
                    Image = "ps_top_card_02"
                },
                new Course()
                {
                    Title = "Windows Phone Photo/Video Programming",
                    Description = "Learn how to capitalize on the Windows Phone camera " +
                    "within your apps to capture still photos and video.",
                    Image = "ps_top_card_03"
                },
                new Course()
                {
                    Title = "Windows Phone Location-Based Apps",
                    Description = "Cover the wide range of Windows Phone location capabilities " +
                    "including determining user location, power management, and " +
                    "translating location data to human-readable addresses.",
                    Image = "ps_top_card_04"
                }

            };

            return initCourses;
        }

        public int Length
        {
            get
            {
                return courses.Length;
            }
        }


        public void MoveFirst()
        {
            currentIndex = 0;
        }

        public void MovePrev()
        {
            if (currentIndex > 0)
                --currentIndex;
        }

        public void MoveNext()
        {
            if (currentIndex < lastIndex)
                ++currentIndex;
        }

        public void MoveTo(int position)
        {
            if (position >= 0 && position <= lastIndex)
                currentIndex = position;
            else
                throw new IndexOutOfRangeException(
                    String.Format("{0} is an invalid position. Must be between 0 and {1}",
                    position, lastIndex));
        }

        public Course Current
        {
            get { return courses[currentIndex]; }
        }

        public Boolean CanMovePrev
        {
            get { return currentIndex > 0; }
        }

        public Boolean CanMoveNext
        {
            get { return currentIndex < lastIndex; }
        }
    }
}
