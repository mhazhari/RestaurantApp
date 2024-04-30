using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.CustomeControls
{
    public class MySearchBar:SearchBar
    {
        public MySearchBar()
        {
            Microsoft.Maui.Handlers.SearchBarHandler.Mapper.AppendToMapping("CustomeSearchBar", (handler, view) =>
            {

            #if ANDROID

                Android.Widget.LinearLayout linearLayout=handler.PlatformView.GetChildAt(0) as Android.Widget.LinearLayout; 
                linearLayout=linearLayout.GetChildAt(2) as Android.Widget.LinearLayout;
                linearLayout = linearLayout.GetChildAt(1) as Android.Widget.LinearLayout;
                linearLayout.Background = null;

            #endif

            });
        }
    }
}
