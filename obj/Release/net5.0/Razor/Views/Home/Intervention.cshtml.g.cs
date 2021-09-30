#pragma checksum "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0acbd74f0fa0480a3c8c930de8fe85bdfb14b4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Intervention), @"mvc.1.0.view", @"/Views/Home/Intervention.cshtml")]
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
#line 1 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
using RocketElevator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0acbd74f0fa0480a3c8c930de8fe85bdfb14b4d", @"/Views/Home/Intervention.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Intervention : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InterventionFormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
  
    ViewData["Title"] = "Intervention";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""slider"" class=""fullheight"">

    <div class=""swiper-container"" data-effect=""slide"" data-autoplay=""false"">
        <div class=""swiper-wrapper"">

            <!-- SLIDE 1 -->
            <div class=""swiper-slide"" style=""background-image: url('/../../Assets/pexels-olga-lioncat-7245354.jpg');"">
                <div class=""overlay dark-5""><!-- dark overlay [1 to 9 opacity] --></div>

                <div class=""display-table"">
                    <div class=""display-table-cell vertical-align-middle"">
                        <div class=""container"">

                            <div class=""row"">
                                <div class=""text-center col-md-8 col-12 offset-md-2"">
                                    <h1 class=""bold font-raleway wow fadeInUp"" data-wow-delay=""0.4s"">Intervention Form</h1>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</se");
            WriteLiteral("ction>\n\n<!-- CONTACT -->\n<section id=\"contact\">\n    <div class=\"container\">\n        <form method=\"POST\"");
            BeginWriteAttribute("action", " action=\"", 1235, "\"", 1273, 1);
#nullable restore
#line 36 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
WriteAttributeValue("", 1244, Url.RouteUrl("Intervention"), 1244, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <div id=""building_id"" class=""col-md-4"">
                <label id=""building_label"">Building List:</label>
                <select id=""building_id_selector"" required class=""form-control pointer"" name=""intervention[BuildingID]"">
                    <option value=""nulltest"">---None---</option>
");
#nullable restore
#line 41 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                     foreach (var Building in Model.Buildings)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 1696, "\"", 1716, 1);
#nullable restore
#line 43 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
WriteAttributeValue("", 1704, Building.Id, 1704, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Building with ID: ");
#nullable restore
#line 43 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                                                                  Write(Building.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\n");
#nullable restore
#line 44 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
                <br>
            </div>
            <div id=""battery_id"" class=""col-md-4"">
                <label id=""battery_label"">Battery List:</label>
                <select id=""battery_id_selector"" required class=""form-control pointer"" name=""intervention[BatteryID]"">
                    <option value=""nulltest"">---None---</option>
");
#nullable restore
#line 52 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                     foreach (var item in Model.Batteries)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 2257, "\"", 2273, 1);
#nullable restore
#line 54 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
WriteAttributeValue("", 2265, item.Id, 2265, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Battery with ID: ");
#nullable restore
#line 54 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\n");
#nullable restore
#line 55 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
                <br>
            </div>
            <div id=""column_id"" class=""col-md-4"">
                <label id=""column_label"">Column List:</label>
                <select id=""column_id_selector"" required class=""form-control pointer"" name=""intervention[ColumnID]"">
                    <option value=""nulltest"">---None---</option>
");
#nullable restore
#line 63 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                     foreach (var Columns in Model.Columns)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 2805, "\"", 2824, 1);
#nullable restore
#line 65 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
WriteAttributeValue("", 2813, Columns.Id, 2813, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Column with ID: ");
#nullable restore
#line 65 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                                                               Write(Columns.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\n");
#nullable restore
#line 66 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
                <br>
            </div>
            <div id=""elevator_id"" class=""col-md-4"">
                <label id=""elevator_label"">Elevator List:</label>
                <select id=""elevator_id_selector"" required class=""form-control pointer"" name=""intervention[ElevatorID]"">
                    <option value=""nulltest"">---None---</option>
");
#nullable restore
#line 74 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                     foreach (var Elevators in Model.Elevators)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 3372, "\"", 3403, 1);
#nullable restore
#line 76 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
WriteAttributeValue("", 3380, Elevators.SerialNumber, 3380, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Serial: ");
#nullable restore
#line 76 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                                                                   Write(Elevators.SerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\n");
#nullable restore
#line 77 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </div>
            <br>
            <div id=""description"" class=""col-md-4"">
                <label>Description:</label>
                <textarea cols=""100"" id=""person_description"" name=""Report"" rows=""4""></textarea>
            </div>
            <br>
            <div class=""col-md-4"">
                <button class=""btn btn-3d btn-lg btn-red wow fadeIn"" data-wow-delay=""1.5s"" type=""submit"">SUBMIT</button>
            </div>
");
#nullable restore
#line 89 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
              if (ViewData.ContainsKey("ErrorMessage"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p id=\"status\" class=\"invalid-feedback d-block text-danger\" role=\"alert\">\n                        ");
#nullable restore
#line 92 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                   Write(ViewData["ErrorMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n");
#nullable restore
#line 94 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
              if (ViewData.ContainsKey("SuccessMessage"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p id=\"status\" class=\"invalid-feedback d-block text-danger\" role=\"alert\" style=\"color:green\">\n                        ");
#nullable restore
#line 99 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                   Write(ViewData["SuccessMessage"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n");
#nullable restore
#line 101 "/Users/emmanuelsarpong/Desktop/Rocket_Elevators_Customer_Portal/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </form>\n      \n\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
            <script>jQuery(document).ready(function () {

                    $(""#battery_id_selector"").hide();
                    $(""#battery_id"").hide();

                    $(""#column_id_selector"").hide();
                    $(""#column_id"").hide();

                    $(""#elevator_id_selector"").hide();
                    $(""#elevator_id"").hide();

                });

                $('#building_id_selector').change(function () {
                    ShowHide();
                });

                $('#battery_id_selector').change(function () {
                    ShowHide();
                });

                $('#column_id_selector').change(function () {
                    ShowHide();
                });

                function ShowHide() {

                    $(""#battery_id_selector"").hide();
                    $(""#battery_id"").hide();

                    $(""#column_id_selector"").hide();
                    $(""#column_id"").hide();

                    $(""#elevator_id_selector"").hide();
    ");
                WriteLiteral(@"                $(""#elevator_id"").hide();

                    if ($(""#building_id_selector"").val() != ""nulltest"") {
                        $(""#battery_id_selector"").show();
                        $(""#battery_id"").show();

                        if ($(""#battery_id_selector"").val() != ""nulltest"") {
                            $(""#column_id_selector"").show();
                            $(""#column_id"").show();

                            if ($(""#column_id_selector"").val() != ""nulltest"") {
                                $(""#elevator_id_selector"").show();
                                $(""#elevator_id"").show();
                            }
                        }
                    }
                }
            </script>
        ");
            }
            );
            WriteLiteral("    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InterventionFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
