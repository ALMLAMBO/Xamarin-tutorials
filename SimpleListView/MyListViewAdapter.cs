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

namespace SimpleListView {
	public class MyListViewAdapter : BaseAdapter<string> {
		private List<string> items;
		private Context context;

		public MyListViewAdapter(Context context, List<string> items) {
			this.items = items;
			this.context = context;
		}

		public override string this[int position] => items[position];

		public override int Count { get => items.Count; }

		public override long GetItemId(int position) {
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent) {
			View row = convertView;

			if(row == null) {
				row = LayoutInflater.From(context)
					.Inflate(Resource.Layout.listview_row, null, false);
			}

			TextView txtName = row.FindViewById<TextView>
				(Resource.Id.txtName);

			txtName.Text = items[position];

			return row;
		}
	}
}