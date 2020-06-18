using Android;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.Content;

namespace XamarinTrainicity.Droid
{
    [Activity(Label = "XamarinTrainicity", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private int PERMISSION_REQUEST_CODE = 1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
            {
                if (!PermissionGrantedForExternalStorage)
                {
                    RequestPermission();
                }
            }
        }
        private bool PermissionGrantedForExternalStorage
        {
            get
            {
                Permission permissionResult = ContextCompat.CheckSelfPermission(this, Manifest.Permission.WriteExternalStorage);
                if (permissionResult == Permission.Granted)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void RequestPermission()
        {
            if (!ActivityCompat.ShouldShowRequestPermissionRationale(this, Manifest.Permission.WriteExternalStorage))
            {
                ActivityCompat.RequestPermissions(this, new string[] { Manifest.Permission.WriteExternalStorage }, PERMISSION_REQUEST_CODE);
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}