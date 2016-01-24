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
using Courses.CourseLibrary;

namespace Courses.Android
{
    [Activity(Label = "CategoriesActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class CategoriesActivity : ListActivity
    {
        CourseCategoryManager _courseCategoryManager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            _courseCategoryManager = new CourseCategoryManager();
            ListAdapter = new CourseCategoryManagerAdapter(this,
                global::Android.Resource.Layout.SimpleListItem1,
                _courseCategoryManager);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            Intent intent = new Intent(this, typeof(CourseActivity));

            StartActivity(intent);
        }
    }
}