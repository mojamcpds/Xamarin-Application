using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Courses.CourseLibrary;
using Android.Support.V4.App;

namespace Courses.Android
{
    public class CourseFragment : Fragment
    {
        public Course Course { get; set; }

        TextView txtTitle;
        ImageView imgCourse;
        TextView txtDescription;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            View rootView = inflater.Inflate(Resource.Layout.CourseFragment, container, false);
            txtTitle = rootView.FindViewById<TextView>(Resource.Id.txtTitle);
            imgCourse = rootView.FindViewById<ImageView>(Resource.Id.imgCourse);
            txtDescription = rootView.FindViewById<TextView>(Resource.Id.txtDescription);

            txtTitle.Text = Course.Title;
            txtDescription.Text = Course.Description;
            imgCourse.SetImageResource(ResourceHelper.TranslateDrawableWithReflection(Course.Image));

            return rootView;
        }
    }
}