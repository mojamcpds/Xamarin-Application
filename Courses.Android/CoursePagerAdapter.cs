using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Courses.CourseLibrary;

namespace Courses.Android
{
    public class CoursePagerAdapter : FragmentStatePagerAdapter
    {

        CourseManager _courseManager;

        public CoursePagerAdapter(FragmentManager fm, CourseManager courseManager) 
            : base(fm)
        {
            _courseManager = courseManager;
        }

        public override int Count
        {
            get
            {
                return _courseManager.Length;
            }
        }

        public override global::Android.Support.V4.App.Fragment GetItem(int position)
        {
            _courseManager.MoveTo(position);
            CourseFragment courseFragment = new CourseFragment();
            courseFragment.Course = _courseManager.Current;

            return courseFragment;
        }

        /*      Important Note about adding Fragment
        
        -->. Install-Package Xamarin.Android.Support.v4
        -->. Install-Package Xamarin.Android.Support.v7.AppCompat
        -->. Download https://dl-ssl.google.com/android/repository/android_m2repository_r25.zip
        -->. Extract it
        -->. Paste it into
	            -->. C:\Users\DELL\AppData\Local\Xamarin\Android.Support.v4\23.1.1.0\content
	            -->. C:\Users\DELL\AppData\Local\Xamarin\Android.Support.v7.AppCompat\23.1.1.0\content

        And the problem is solved.
        
        */
    }
}