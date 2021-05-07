#pragma checksum "C:\Users\sachi\source\repos\MapMvp1\MapMvp1\Views\Device\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d21d259648517d55b9240955b6f1940f9bc8232"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Device_Index), @"mvc.1.0.view", @"/Views/Device/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\sachi\source\repos\MapMvp1\MapMvp1\Views\_ViewImports.cshtml"
using MapMvp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sachi\source\repos\MapMvp1\MapMvp1\Views\_ViewImports.cshtml"
using MapMvp1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d21d259648517d55b9240955b6f1940f9bc8232", @"/Views/Device/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89ffb5761c97e05b51353c617d049bbecb0362b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Device_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\sachi\source\repos\MapMvp1\MapMvp1\Views\Device\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div id=""app"">

        <h1>Device</h1>

        <div class=""d-flex justify-content-center my-2"">


            <div class=""p-2 bd-highlight""></div>
            <div class=""p-2 bd-highlight"">


                <div class=""mb-3"">
                    <label for=""exampleInputEmail1"" class=""form-label"">Vehicle Id</label>
                    <input type=""number"" v-model=""submittedId"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"">
                </div>

                <button class=""btn btn-primary"" v-on:click=""shareLocation"">Share Location</button>



            </div>
            <div class=""p-2 bd-highlight""></div>



        </div>


    </div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        const { createApp, ref } = Vue;

        const App = {
            setup() {


                console.log(""----------Sharing Location----------ss"")

                const vehicleId = ref(null);
                const submittedId = ref(null);


                const shareLocation = () => {

                    console.log(""----------Sharing Location----------"")
                    console.log(""----------Sharing Location----------"")
                    console.log(""----------Sharing Location----------"")

                    if (submittedId.value != null) {

                        vehicleId.value = submittedId.value;
                        setInterval(function () {
                            navigator.geolocation.getCurrentPosition(showPosition );

                        }, 5000);

                     }

                }



              //      navigator.geolocation.getCurrentPosition(showPosition);

                


                function s");
                WriteLiteral(@"howPosition(position) {
                    let lat = position.coords.latitude;
                    let lon = position.coords.longitude;

                    console.log(lat);
                    console.log(lon);

                    SetLiveLocation(lat, lon);
                    console.log(""------Calling The Api------"");
                }


                const SetLiveLocation = async (latitude, longitude) => {
                    var liveLocationObject = {
                        VehicleId: Number(submittedId.value),
                        Latitude: latitude,
                        Longitude: longitude,
                        TimeStamp: Math.floor(Date.now() / 1000),
                    };

                    console.log(liveLocationObject);
                    axios
                        .post(""/api/LiveLocation/AddLiveLocation"", liveLocationObject)
                        .then(function (response) {
                            console.log(""hi"");

                        ");
                WriteLiteral(@"    console.log(response);
                        })
                        .catch(function (error) {
                            console.log(error);
                        });
                };


                //      setInterval(function () {
                //navigator.geolocation.getCurrentPosition(showPosition);

                //  }, 5000);


                return {  shareLocation, submittedId};
            },

        };

        createApp(App).mount(""#app"");

    </script>


");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
