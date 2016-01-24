//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Courses.CourseLibrary;

//namespace Courses.Android
//{
//  // [Activity(Label = "CategoryActivity")]
//    //[Activity(Label = "CategoryActivity", MainLauncher = true, Icon = "@drawable/icon")]
//    public class CategoryActivity : ListActivity
//    {
//        CourseCategoryManager _courseCategoryManager;

//        protected override void OnCreate(Bundle savedInstanceState)
//        {
//            base.OnCreate(savedInstanceState);

//            // Create your application here


//            //Link for SimpleListItem1 solution: https://forums.xamarin.com/discussion/6562/no-predefined-resources
//            //http://stackoverflow.com/questions/3663745/what-is-android-r-layout-simple-list-item-1

//            //string[] categoryTitles = { "Category 1", "Category 2", "Category 3" };
//            //ListAdapter = 
//            //    new ArrayAdapter<string>(this, global::Android.Resource.Layout.SimpleListItem1, categoryTitles);

//            _courseCategoryManager = new CourseCategoryManager();
//            ListAdapter = new CourseCategoryManagerAdapter(this,
//                global::Android.Resource.Layout.SimpleListItem1,
//                _courseCategoryManager.);
//        }

//        protected override void OnListItemClick(ListView l, View v, int position, long id)
//        {
//            Intent intent = new Intent(this, typeof(CourseActivity));

//            StartActivity(intent);
//        }
//    }
//}