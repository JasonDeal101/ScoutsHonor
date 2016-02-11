/*
    Author: Jason Deal
    Team: Crevolution
    Team Number: 2851
    Date Initialized: 2/10/2016
    Github Repository: https://github.com/JasonDeal101/ScoutsHonor/
*/
using Android.App;
using Android.OS;

namespace ScoutsHonor
{
    //Joe-Rock Android Tutorials Sliding Tab Interface
    [Activity(Label = "ScoutsHonor", MainLauncher = true, Icon = "@drawable/Icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
        }
    }
}

