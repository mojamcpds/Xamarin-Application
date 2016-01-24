using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Courses.CourseLibrary;

namespace Courses.Android
{
    //[Activity(Label = "Courses.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btnPrev;
        Button btnNext;
        TextView txtTitle;
        ImageView imgCourse; 
        TextView txtDescription;
        CourseManager courseManager;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our buttons and text views from the layout resource,
            btnPrev = FindViewById<Button>(Resource.Id.btnPrev);
            btnNext = FindViewById<Button>(Resource.Id.btnNext);
            txtTitle = FindViewById<TextView>(Resource.Id.txtTitle);
            imgCourse = FindViewById<ImageView>(Resource.Id.imgCourse);
            txtDescription = FindViewById<TextView>(Resource.Id.txtDescription);

            // and attach an event to it
            btnPrev.Click += BtnPrev_Click;
            btnNext.Click += BtnNext_Click;

            courseManager = new CourseManager();
            courseManager.MoveFirst();
            UpdateUI();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            courseManager.MovePrev();
            UpdateUI();
            // txtTitle.Text = "Previous Clicked";
            //txtDescription.Text = "The description that appears when Prev is clicked";
            //imgCourse.SetImageResource(Resource.Drawable.ps_top_card_01);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            courseManager.MoveNext();
            UpdateUI();
            //txtTitle.Text = "Next Clicked";
            //txtDescription.Text = "The description that appears when Next is clicked";
            //imgCourse.SetImageResource(Resource.Drawable.ps_top_card_02);
        }

        private void UpdateUI()
        {
            txtTitle.Text = courseManager.Current.Title;
            txtDescription.Text = courseManager.Current.Description;
            //imgCourse.SetImageResource(ResourceHelper.TranslateDrawable(courseManager.Current.Image));
            imgCourse.SetImageResource(ResourceHelper.TranslateDrawableWithReflection(courseManager.Current.Image));
            btnPrev.Enabled = courseManager.CanMovePrev;
            btnNext.Enabled = courseManager.CanMoveNext;
        }
    }
}

