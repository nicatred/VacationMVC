#pragma checksum "C:\Users\Nijatred\source\repos\Vacation\MvcUI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9d5ef75e82bd23dd0945bd0d2e005c245b02f9e"
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
#line 3 "C:\Users\Nijatred\source\repos\Vacation\MvcUI\Views\_ViewImports.cshtml"
using MvcUI.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nijatred\source\repos\Vacation\MvcUI\Views\_ViewImports.cshtml"
using DataAccess.Dtos.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9d5ef75e82bd23dd0945bd0d2e005c245b02f9e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecb4584e0fea7cf47906adc5595e155a13a63a90", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/twitter-bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9d5ef75e82bd23dd0945bd0d2e005c245b02f9e4841", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 195, "\"", 205, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 234, "\"", 244, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
    <title>Freelancer - Start Bootstrap Theme</title>
    <!-- Favicon-->
    <link rel=""icon"" type=""image/x-icon"" href=""assets/favicon.ico"" />
    <!-- Font Awesome icons (free version)-->
    <script src=""https://use.fontawesome.com/releases/v6.1.0/js/all.js"" crossorigin=""anonymous""></script>
    <!-- Google fonts-->
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,700"" rel=""stylesheet"" type=""text/css"" />
    <link href=""https://fonts.googleapis.com/css?family=Lato:400,700,400italic,700italic"" rel=""stylesheet"" type=""text/css"" />
    <!-- Core theme CSS (includes Bootstrap)-->
    <link href=""css/styles.css"" rel=""stylesheet"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9d5ef75e82bd23dd0945bd0d2e005c245b02f9e6312", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9d5ef75e82bd23dd0945bd0d2e005c245b02f9e7490", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n     <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9d5ef75e82bd23dd0945bd0d2e005c245b02f9e9599", async() => {
                WriteLiteral(@"
    <!-- Navigation-->
    <nav class=""navbar navbar-expand-lg bg-secondary text-uppercase fixed-top"" id=""mainNav"">
        <div class=""container"">
            <a class=""navbar-brand"" href=""#page-top"">Start Bootstrap</a>
            <button class=""navbar-toggler text-uppercase font-weight-bold bg-primary text-white rounded"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                Menu
                <i class=""fas fa-bars""></i>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav ms-auto"">
                    <li class=""nav-item mx-0 mx-lg-1""><a class=""nav-link py-3 px-0 px-lg-3 rounded"" href=""#portfolio"">Portfolio</a></li>
                    <li class=""nav-item mx-0 mx-lg-1""><a class=""nav-link py-3 px-0 px-lg-3 rounded"" href=""#about"">About</a></li>
                    <li class=""nav-item mx-0 mx-");
                WriteLiteral("lg-1\"><a class=\"nav-link py-3 px-0 px-lg-3 rounded\" href=\"#contact\">Contact</a></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n    ");
#nullable restore
#line 40 "C:\Users\Nijatred\source\repos\Vacation\MvcUI\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
    <!-- Footer-->
    <footer class=""footer text-center"">
        <div class=""container"">
            <div class=""row"">
                <!-- Footer Location-->
                <div class=""col-lg-4 mb-5 mb-lg-0"">
                    <h4 class=""text-uppercase mb-4"">Location</h4>
                    <p class=""lead mb-0"">
                        2215 John Daniel Drive
                        <br />
                        Clark, MO 65243
                    </p>
                </div>
                <!-- Footer Social Icons-->
                <div class=""col-lg-4 mb-5 mb-lg-0"">
                    <h4 class=""text-uppercase mb-4"">Around the Web</h4>
                    <a class=""btn btn-outline-light btn-social mx-1"" href=""#!""><i class=""fab fa-fw fa-facebook-f""></i></a>
                    <a class=""btn btn-outline-light btn-social mx-1"" href=""#!""><i class=""fab fa-fw fa-twitter""></i></a>
                    <a class=""btn btn-outline-light btn-social mx-1"" href=""#!""><i class=""fab fa-fw fa-lin");
                WriteLiteral(@"kedin-in""></i></a>
                    <a class=""btn btn-outline-light btn-social mx-1"" href=""#!""><i class=""fab fa-fw fa-dribbble""></i></a>
                </div>
                <!-- Footer About Text-->
                <div class=""col-lg-4"">
                    <h4 class=""text-uppercase mb-4"">About Freelancer</h4>
                    <p class=""lead mb-0"">
                        Freelance is a free to use, MIT licensed Bootstrap theme created by
                        <a href=""http://startbootstrap.com"">Start Bootstrap</a>
                        .
                    </p>
                </div>
            </div>
        </div>
    </footer>
    <!-- Portfolio Modals-->
    <!-- Portfolio Modal 1-->
    <div class=""portfolio-modal modal fade"" id=""portfolioModal1"" tabindex=""-1"" aria-labelledby=""portfolioModal1"" aria-hidden=""true"">
        <div class=""modal-dialog modal-xl"">
            <div class=""modal-content"">
                <div class=""modal-header border-0""><button class=""btn-clos");
                WriteLiteral(@"e"" type=""button"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
                <div class=""modal-body text-center pb-5"">
                    <div class=""container"">
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-8"">
                                <!-- Portfolio Modal - Title-->
                                <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">Log Cabin</h2>
                                <!-- Icon Divider-->
                                <div class=""divider-custom"">
                                    <div class=""divider-custom-line""></div>
                                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                                    <div class=""divider-custom-line""></div>
                                </div>
                                <!-- Portfolio Modal - Image-->
                                <img class=""img-fluid rounded mb");
                WriteLiteral(@"-5"" src=""assets/img/portfolio/cabin.png"" alt=""..."" />
                                <!-- Portfolio Modal - Text-->
                                <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil, molestias magnam, recusandae quos quis inventore quisquam velit asperiores, vitae? Reprehenderit soluta, eos quod consequuntur itaque. Nam.</p>
                                <button class=""btn btn-primary"" data-bs-dismiss=""modal"">
                                    <i class=""fas fa-xmark fa-fw""></i>
                                    Close Window
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Portfolio Modal 2-->
    <div class=""portfolio-modal modal fade"" id=""portfolioModal2"" tabindex=""-1"" aria-labelledby=""portfolioModal2"" aria-hidden=""true"">
        <div class=""modal-di");
                WriteLiteral(@"alog modal-xl"">
            <div class=""modal-content"">
                <div class=""modal-header border-0""><button class=""btn-close"" type=""button"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
                <div class=""modal-body text-center pb-5"">
                    <div class=""container"">
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-8"">
                                <!-- Portfolio Modal - Title-->
                                <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">Tasty Cake</h2>
                                <!-- Icon Divider-->
                                <div class=""divider-custom"">
                                    <div class=""divider-custom-line""></div>
                                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                                    <div class=""divider-custom-line""></div>
                                </di");
                WriteLiteral(@"v>
                                <!-- Portfolio Modal - Image-->
                                <img class=""img-fluid rounded mb-5"" src=""assets/img/portfolio/cake.png"" alt=""..."" />
                                <!-- Portfolio Modal - Text-->
                                <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil, molestias magnam, recusandae quos quis inventore quisquam velit asperiores, vitae? Reprehenderit soluta, eos quod consequuntur itaque. Nam.</p>
                                <button class=""btn btn-primary"" data-bs-dismiss=""modal"">
                                    <i class=""fas fa-xmark fa-fw""></i>
                                    Close Window
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Portfolio Modal 3-->
    <div class=""portfolio-moda");
                WriteLiteral(@"l modal fade"" id=""portfolioModal3"" tabindex=""-1"" aria-labelledby=""portfolioModal3"" aria-hidden=""true"">
        <div class=""modal-dialog modal-xl"">
            <div class=""modal-content"">
                <div class=""modal-header border-0""><button class=""btn-close"" type=""button"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
                <div class=""modal-body text-center pb-5"">
                    <div class=""container"">
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-8"">
                                <!-- Portfolio Modal - Title-->
                                <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">Circus Tent</h2>
                                <!-- Icon Divider-->
                                <div class=""divider-custom"">
                                    <div class=""divider-custom-line""></div>
                                    <div class=""divider-custom-icon""><i class=""fas f");
                WriteLiteral(@"a-star""></i></div>
                                    <div class=""divider-custom-line""></div>
                                </div>
                                <!-- Portfolio Modal - Image-->
                                <img class=""img-fluid rounded mb-5"" src=""assets/img/portfolio/circus.png"" alt=""..."" />
                                <!-- Portfolio Modal - Text-->
                                <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil, molestias magnam, recusandae quos quis inventore quisquam velit asperiores, vitae? Reprehenderit soluta, eos quod consequuntur itaque. Nam.</p>
                                <button class=""btn btn-primary"" data-bs-dismiss=""modal"">
                                    <i class=""fas fa-xmark fa-fw""></i>
                                    Close Window
                                </button>
                            </div>
                        </div>
                    </div>");
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <!-- Portfolio Modal 4-->
    <div class=""portfolio-modal modal fade"" id=""portfolioModal4"" tabindex=""-1"" aria-labelledby=""portfolioModal4"" aria-hidden=""true"">
        <div class=""modal-dialog modal-xl"">
            <div class=""modal-content"">
                <div class=""modal-header border-0""><button class=""btn-close"" type=""button"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
                <div class=""modal-body text-center pb-5"">
                    <div class=""container"">
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-8"">
                                <!-- Portfolio Modal - Title-->
                                <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">Controller</h2>
                                <!-- Icon Divider-->
                                <div class=""divider-custom"">
                           ");
                WriteLiteral(@"         <div class=""divider-custom-line""></div>
                                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                                    <div class=""divider-custom-line""></div>
                                </div>
                                <!-- Portfolio Modal - Image-->
                                <img class=""img-fluid rounded mb-5"" src=""assets/img/portfolio/game.png"" alt=""..."" />
                                <!-- Portfolio Modal - Text-->
                                <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil, molestias magnam, recusandae quos quis inventore quisquam velit asperiores, vitae? Reprehenderit soluta, eos quod consequuntur itaque. Nam.</p>
                                <button class=""btn btn-primary"" data-bs-dismiss=""modal"">
                                    <i class=""fas fa-xmark fa-fw""></i>
                                    Close Window
     ");
                WriteLiteral(@"                           </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Portfolio Modal 5-->
    <div class=""portfolio-modal modal fade"" id=""portfolioModal5"" tabindex=""-1"" aria-labelledby=""portfolioModal5"" aria-hidden=""true"">
        <div class=""modal-dialog modal-xl"">
            <div class=""modal-content"">
                <div class=""modal-header border-0""><button class=""btn-close"" type=""button"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
                <div class=""modal-body text-center pb-5"">
                    <div class=""container"">
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-8"">
                                <!-- Portfolio Modal - Title-->
                                <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">Locked Safe</h2>
          ");
                WriteLiteral(@"                      <!-- Icon Divider-->
                                <div class=""divider-custom"">
                                    <div class=""divider-custom-line""></div>
                                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                                    <div class=""divider-custom-line""></div>
                                </div>
                                <!-- Portfolio Modal - Image-->
                                <img class=""img-fluid rounded mb-5"" src=""assets/img/portfolio/safe.png"" alt=""..."" />
                                <!-- Portfolio Modal - Text-->
                                <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil, molestias magnam, recusandae quos quis inventore quisquam velit asperiores, vitae? Reprehenderit soluta, eos quod consequuntur itaque. Nam.</p>
                                <button class=""btn btn-primary"" data-bs-dismiss=""mod");
                WriteLiteral(@"al"">
                                    <i class=""fas fa-xmark fa-fw""></i>
                                    Close Window
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Portfolio Modal 6-->
    <div class=""portfolio-modal modal fade"" id=""portfolioModal6"" tabindex=""-1"" aria-labelledby=""portfolioModal6"" aria-hidden=""true"">
        <div class=""modal-dialog modal-xl"">
            <div class=""modal-content"">
                <div class=""modal-header border-0""><button class=""btn-close"" type=""button"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
                <div class=""modal-body text-center pb-5"">
                    <div class=""container"">
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-8"">
                                <!-- Portfolio Modal - Title-");
                WriteLiteral(@"->
                                <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">Submarine</h2>
                                <!-- Icon Divider-->
                                <div class=""divider-custom"">
                                    <div class=""divider-custom-line""></div>
                                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                                    <div class=""divider-custom-line""></div>
                                </div>
                                <!-- Portfolio Modal - Image-->
                                <img class=""img-fluid rounded mb-5"" src=""assets/img/portfolio/submarine.png"" alt=""..."" />
                                <!-- Portfolio Modal - Text-->
                                <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil, molestias magnam, recusandae quos quis inventore quisquam velit asperiores, vitae? Reprehende");
                WriteLiteral(@"rit soluta, eos quod consequuntur itaque. Nam.</p>
                                <button class=""btn btn-primary"" data-bs-dismiss=""modal"">
                                    <i class=""fas fa-xmark fa-fw""></i>
                                    Close Window
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Bootstrap core JS-->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""></script>
    <!-- Core theme JS-->
    <script src=""js/scripts.js""></script>
    <!-- * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *-->
    <!-- * *                               SB Forms JS                               * *-->
    <!-- * * Activate your form at https://startbootstrap.com/solution/contact-forms * *-->
    <!-- * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
                WriteLiteral(@"* * * * * * * * * * * * *-->
    <script src=""https://cdn.startbootstrap.com/sb-forms-latest.js""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/momentjs/2.14.1/moment.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.37/js/bootstrap-datetimepicker.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.37/css/bootstrap-datetimepicker.min.css"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
