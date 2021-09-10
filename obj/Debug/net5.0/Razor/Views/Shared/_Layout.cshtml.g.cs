#pragma checksum "/Users/emmanuelsarpong/Desktop/rocket-elevators-main/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34ada7b9e064fd8ffed124212ab9845ac120f41a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "/Users/emmanuelsarpong/Desktop/rocket-elevators-main/Views/Shared/_Layout.cshtml"
using RocketElevator.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34ada7b9e064fd8ffed124212ab9845ac120f41a", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("smoothscroll enable-animation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/emmanuelsarpong/Desktop/rocket-elevators-main/Views/Shared/_Layout.cshtml"
  
    var user = Context.Session.GetObjectFromJson<RocketElevator.Models.Users>("user");

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34ada7b9e064fd8ffed124212ab9845ac120f41a3636", async() => {
                WriteLiteral("\n    <meta http-equiv=\"content-type\" content=\"text/html; charset=utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
#nullable restore
#line 10 "/Users/emmanuelsarpong/Desktop/rocket-elevators-main/Views/Shared/_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" | Rocket Elevators Portal</title>

    <!-- mobile settings -->
    <meta name=""viewport"" content=""width=device-width, maximum-scale=1, initial-scale=1, user-scalable=0"" />
    <!--[if IE]><meta http-equiv='X-UA-Compatible' content='IE=edge,chrome=1'><![endif]-->
    <!-- WEB FONTS : use %7C instead of | (pipe) -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,400,600%7CRaleway:300,400,500,600,700%7CLato:300,400,400italic,600,700"" rel=""stylesheet"" type=""text/css"" />

    <!-- CORE CSS -->
    <link href=""assets/plugins/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"" type=""text/css"" />

    <!-- SWIPER SLIDER -->
    <link href=""assets/plugins/slider.swiper/dist/css/swiper.min.css"" rel=""stylesheet"" type=""text/css"" />

    <!-- THEME CSS -->
    <link href=""assets/css/essentials.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""assets/css/layout.css"" rel=""stylesheet"" type=""text/css"" />

    <!-- PAGE LEVEL SCRIPTS -->
    <link href=""assets/css/header-1.css"" rel=""stylesheet"" ty");
                WriteLiteral("pe=\"text/css\" />\n    <link href=\"assets/css/color_scheme/green.css\" rel=\"stylesheet\" type=\"text/css\" id=\"color_scheme\" />\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34ada7b9e064fd8ffed124212ab9845ac120f41a6211", async() => {
                WriteLiteral(@"

    <div id=""header"" class=""navbar-toggleable-md sticky bottom header-sm dark clearfix"">

        <!-- TOP NAV -->
        <header id=""topNav"">
            <div class=""container"">

                <!-- Mobile Menu Button -->
                <button class=""btn btn-mobile"" data-toggle=""collapse"" data-target="".nav-main-collapse"">
                    <i class=""fa fa-bars""></i>
                </button>

                <!-- Logo -->
                <a class=""logo float-left scrollTo"" href=""#top"">
                    <img src=""../../Assets/R2.png""");
                BeginWriteAttribute("alt", " alt=\"", 2080, "\"", 2086, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                </a>

                <!--
                    Top Nav

                    AVAILABLE CLASSES:
                    submenu-dark = dark sub menu
                -->
                <div class=""navbar-collapse collapse float-right nav-main-collapse submenu-dark"">
                    <nav class=""nav-main"">

                        <ul id=""topMain"" class=""nav nav-pills nav-main nav-onepage"">
                            <li class=""active"">
                                <!-- HOME -->
                                <a href=""/"">
                                    HOME
                                </a>
                            </li>

");
#nullable restore
#line 68 "/Users/emmanuelsarpong/Desktop/rocket-elevators-main/Views/Shared/_Layout.cshtml"
                             if (Context.Session.IsAvailable && user != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <li>
                                    <!-- PRODUCTS -->
                                    <a href=""/products"">
                                        PRODUCTS
                                    </a>
                                </li>
                                <li>
                                    <!-- INTERVENTION -->
                                    <a href=""/intervention"">
                                        INTERVENTION
                                    </a>
                                </li>
");
#nullable restore
#line 82 "/Users/emmanuelsarpong/Desktop/rocket-elevators-main/Views/Shared/_Layout.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "/Users/emmanuelsarpong/Desktop/rocket-elevators-main/Views/Shared/_Layout.cshtml"
                             if (Context.Session.IsAvailable && user != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li>\n                                    <a");
                BeginWriteAttribute("class", " class=\"", 3635, "\"", 3643, 0);
                EndWriteAttribute();
                WriteLiteral(@" href=""javascript:void(0);""
                                       onclick=""event.preventDefault();
                                            document.getElementById('logout-form').submit();"">
                                        LOGOUT
                                    </a>
                                    <form id=""logout-form""");
                BeginWriteAttribute("action", " action=\"", 3985, "\"", 4017, 1);
#nullable restore
#line 91 "/Users/emmanuelsarpong/Desktop/rocket-elevators-main/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 3994, Url.RouteUrl("Logout"), 3994, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" method=\"POST\" style=\"display: none;\"></form>\n                                </li>\n");
#nullable restore
#line 93 "/Users/emmanuelsarpong/Desktop/rocket-elevators-main/Views/Shared/_Layout.cshtml"

                            }

                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <li>
                                    <!-- VISIT US -->
                                    <a href=""#contact"">
                                        VISIT US
                                    </a>
                                </li>
                                <li>
                                    <a");
                BeginWriteAttribute("href", " href=\"", 4547, "\"", 4580, 1);
#nullable restore
#line 105 "/Users/emmanuelsarpong/Desktop/rocket-elevators-main/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 4554, Url.RouteUrl("ShowLogin"), 4554, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">LOGIN</a>\n                                </li>\n");
#nullable restore
#line 107 "/Users/emmanuelsarpong/Desktop/rocket-elevators-main/Views/Shared/_Layout.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\n                    </nav>\n                </div>\n\n            </div>\n        </header>\n        <!-- /Top Nav -->\n\n    </div>\n    <!--Main layout-->\n    <main role=\"main\">\n\n        ");
#nullable restore
#line 120 "/Users/emmanuelsarpong/Desktop/rocket-elevators-main/Views/Shared/_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    </main>
    <!--/Main layout-->


    <section class=""callout-dark heading-title heading-arrow-bottom"" style=""z-index:100;"">
        <div class=""container"">

            <div class=""text-center"">
                <h3 class=""fs-30"">ELEVATE SAFETY, SPEED AND STYLE!</h3>
            </div>

        </div>
    </section>
    <!-- /CALLOUT -->
    <!-- CONTACT US -->
    <div class=""callout alert alert-transparent b-0 mt-60 mb-60"">

        <div class=""text-center"">

            <h3>Call now at <strong>(418) 555-1234</strong>!</h3>
            <p class=""font-lato fs-20"">
                We truly care about our users and our product.
            </p>

            <a href=""#contact"" class=""scrollTo btn btn-default btn-lg mt-30"">CONTACT US</a>

        </div>

    </div>
    <!-- /CONTACT US -->
    </div>


    <!-- PARALLAX -->
    <section class=""parallax parallax-2"" style=""background-image: url('../../Assets/parallax2.jpg');"">
        <div class=""overlay dark-8""><!-- dark overlay [1 to 9 opacity] --></div>

");
                WriteLiteral(@"        <div class=""container"">

            <div class=""text-center"">
                <h3 class=""m-0"">In business since 1976!</h3>
            </div>
        </div>

    </section>
    <!-- /PARALLAX -->
    <!-- CONTACT -->
    <section id=""contact"">
        <div class=""container"">

            <header class=""text-center mb-60"">
                <h2>Visit Us</h2>
                <hr />
            </header>


            <div class=""row"">

                <!-- INFO -->
                <div class=""col-md-4 col-sm-4"">

                    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2798.5158879660034!2d-73.56930918444276!3d45.459410779100956!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4cc91067ae856153%3A0x320cd8b1b79bec0f!2s4468%20Wellington%20St%20Suite%20204%2C%20Verdun%2C%20QC%20H4G%201W5!5e0!3m2!1sen!2sca!4v1627316713713!5m2!1sen!2sca"" class=""center"" width=""1150"" height=""300"" style=""border:0;""");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 6848, "\"", 6866, 0);
                EndWriteAttribute();
                WriteLiteral(@" loading=""lazy""></iframe>


                    <hr />

                    <p>
                        <span class=""block""><strong><i class=""fa fa-map-marker""></i> Address:</strong> 4468 Wellington St, Verdun, QC H4G 1W5</span>
                        <span class=""block""><strong><i class=""fa fa-phone""></i> Phone:</strong> <a href=""tel:1800-555-1234"">(418) 555-1234</a></span>
                        <span class=""block""><strong><i class=""fa fa-envelope""></i> Email:</strong> <a href=""mailto:mail@yourdomain.com"">info@codeboxx.biz</a></span>
                    </p>

                </div>
                <!-- /INFO -->

            </div>

        </div>
    </section>
    <!-- /CONTACT -->
    <!-- FOOTER -->
    <footer id=""footer"">
        <div class=""container"">

            <div class=""row"">

                <div class=""col-md-3"">
                    <!-- Footer Logo -->
                    <h4 class=""letter-spacing-1"">ROCKET ELEVATORS</h4>

                    <!-- Contact Address -->
                    <");
                WriteLiteral(@"address>
                        <ul class=""list-unstyled"">
                            <li class=""footer-sprite address"">
                                4468 Wellington St,  <br>
                                Verdun, QC<br>
                                H4G 1W5<br>
                            </li>
                            <li class=""footer-sprite phone"">
                                Phone: (418) 555-1234
                            </li>
                            <li class=""footer-sprite email"">
                                <a href=""mailto:support@yourname.com"">info@codeboxx.biz</a>
                            </li>
                        </ul>
                    </address>
                    <!-- /Contact Address -->

                </div>

                <div class=""col-md-3"">



                </div>

                <div class=""col-md-2"">

                    <!-- Links -->
                    <h4 class=""letter-spacing-1"">EXPLORE</h4>
                    <ul class=""footer-links lis");
                WriteLiteral(@"t-unstyled"">
                        <li><a href=""Home"">Home</a></li>
                        <li><a href=""Products"">Products</a></li>
                        <li><a href=""Intervention"">Intervention Form</a></li>
                        <li><a href=""#"">Visit Us</a></li>
                    </ul>
                    <!-- /Links -->

                </div>

                <div class=""col-md-4"">

                    <!-- Newsletter Form -->
                    <h4 class=""letter-spacing-1"">KEEP IN TOUCH</h4>
                    <p>Subscribe to Our Newsletter to get Important News &amp; Offers</p>

                    <form class=""validate"" action=""php/newsletter.php"" method=""post"" data-success=""Subscribed! Thank you!"" data-toastr-position=""bottom-right"">
                        <div class=""input-group"">
                            <span class=""input-group-addon""><i class=""fa fa-envelope""></i></span>
                            <input type=""email"" id=""email"" name=""email"" class=""form-control required"" placeholder=");
                WriteLiteral(@"""Enter your Email"">
                            <span class=""input-group-btn"">
                                <button style=""border-color:#8B0000;background-color:#8B0000;"" class=""btn btn-success"" type=""submit"">Subscribe</button>
                            </span>
                        </div>
                    </form>
                    <!-- /Newsletter Form -->



                </div>

            </div>

        </div>

        <div class=""copyright"">
            <div class=""container"">
                <ul class=""float-right m-0 list-inline mobile-block"">
                    <li><a href=""#"">Terms &amp; Conditions</a></li>
                    <li>&bull;</li>
                    <li><a href=""#"">Privacy</a></li>
                </ul>
                &copy; All Rights Reserved, Company LTD
            </div>
        </div>
    </footer>
    <!-- /FOOTER -->
    </div>
    <!-- /wrapper -->
    <!-- SCROLL TO TOP -->
    <a href=""#"" id=""toTop""></a>


    <!-- PRELOADER -->
    <div id=""preloader"">
     ");
                WriteLiteral(@"   <div class=""inner"">
            <span class=""loader""></span>
        </div>
    </div><!-- /PRELOADER -->
    <!-- JAVASCRIPT FILES -->
    <script>var plugin_path = 'assets/plugins/';</script>
    <script src=""assets/plugins/jquery/jquery-3.3.1.min.js""></script>

    <script src=""assets/js/scripts.js""></script>



    <!-- SWIPER SLIDER -->
    <script src=""assets/plugins/slider.swiper/dist/js/swiper.min.js""></script>
    <script src=""assets/js/view/demo.swiper_slider.js""></script>

    <!-- PAGELEVEL SCRIPTS -->
    <script src=""assets/js/contact.js""></script>

    <!--
        GMAP.JS
        http://hpneo.github.io/gmaps/
    -->
    <script src=""//maps.google.com/maps/api/js?key=AIzaSyCqCn84CgZN6o1Xc3P4dM657HIxkX3jzPY""></script>
    <script src=""assets/plugins/gmaps.js""></script>
    ");
#nullable restore
#line 322 "/Users/emmanuelsarpong/Desktop/rocket-elevators-main/Views/Shared/_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
