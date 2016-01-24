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
    public class CourseCategoryManagerAdapter : BaseAdapter<CourseCategory>
    {
        Context _context;
        int _layoutResourceId;
        CourseCategoryManager _courseCategoryManager;


        public CourseCategoryManagerAdapter(Context context, 
            int layoutResourceId, CourseCategoryManager courseCategoryManager)
        {
            _context = context;
            _layoutResourceId = layoutResourceId;
            _courseCategoryManager = courseCategoryManager;
        }

        public override CourseCategory this[int position]
        {
            get
            {
                _courseCategoryManager.MoveTo(position);
                return _courseCategoryManager.Current;
            }
        }

        public override int Count
        {
            get
            {
                return _courseCategoryManager.Length;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
            {
                LayoutInflater inflater = 
                    _context.GetSystemService(Context.LayoutInflaterService) as LayoutInflater;
                view = inflater.Inflate(_layoutResourceId,null);
            }

            TextView textView = view.FindViewById<TextView>(Android.Resource.Id.text);

            textView.Text = this[position].Title;

            return view;
        }
    }
}