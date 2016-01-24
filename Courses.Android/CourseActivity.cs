using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Courses.CourseLibrary;
using Android.Support.V4.View;

namespace Courses.Android
{
   // [Activity(Label = "AndroidCourses", MainLauncher = true, Icon = "@drawable/icon")]
    [Activity(Label= "CourseActivity")]
    public class CourseActivity : FragmentActivity
    {
        CourseManager _courseManager;
        CoursePagerAdapter _coursePagerAdapter;
        ViewPager _viewPager;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CourseActivity);

            _courseManager = new CourseManager();
            _courseManager.MoveFirst();

            _coursePagerAdapter = new CoursePagerAdapter(SupportFragmentManager, _courseManager);

            _viewPager = FindViewById<ViewPager>(Resource.Id.coursePager);
            _viewPager.Adapter = _coursePagerAdapter;

        }
    }
}