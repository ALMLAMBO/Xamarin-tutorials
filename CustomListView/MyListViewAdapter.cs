using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SimpleListView {
	public class MyListViewAdapter : BaseAdapter<MyPerson> {
		private List<MyPerson> items;
		private Context context;

		public MyListViewAdapter(Context context, List<MyPerson> items) {
			this.items = items;
			this.context = context;
		}

		public override MyPerson this[int position] => items[position];

		public override int Count { get => items.Count; }

		public override long GetItemId(int position) {
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent) {
			View row = convertView;

			if(row == null) {
				row = LayoutInflater.From(null)
					.Inflate(Resource.Layout.listview_row, null, false);
			}

			//TextView txtFirstName = row.FindViewById<TextView>
			//	(Android.Resource.Id.txtFirstName);
			//
			//txtFirstName.Text = items[position].FirstName;
			//
			//TextView txtLastName = row.FindViewById<TextView>
			//	(Android.Resource.Id.txtLastName);
			//
			//txtLastName.Text = items[position].LastName;
			//
			//TextView txtAge = row.FindViewById<TextView>
			//	(Android.Resource.Id.txtAge);
			//
			//txtAge.Text = items[position].Age.ToString();
			//
			//TextView txtGender = row.FindViewById<TextView>
			//	(Android.Resource.Id.txtGender);
			//
			//txtGender.Text = items[position].Gender;

			return row;
		}
	}
}