using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using CustomListView;

namespace CustomListView{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity {
        private List<MyPerson> items;
        private AbsListView myListView;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            myListView = FindViewById<AbsListView>(Resource.Id.myListView);
            items = new List<MyPerson>() {
                new MyPerson() {
                    FirstName = "Pesho",
                    LastName = "Peshev",
                    Age = 20,
                    Gender = "MALE"
                },
                new MyPerson() {
                    FirstName = "Gosho",
                    LastName = "Goshov",
                    Age = 18,
                    Gender = "MALE"
                },
                new MyPerson() {
                    FirstName = "Tosho",
                    LastName = "Toshov",
                    Age = 25,
                    Gender = "MALE"
                }
            };

            MyListViewAdapter adapter = new MyListViewAdapter(this, items);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults) {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}