#pragma checksum "C:\Users\RJ Hughes\Documents\GitHub\CommerceBankApp\CommerceBlazorServer\Pages\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42e331cbf5bf90be017c80559512c677ba7a07a0"
// <auto-generated/>
#pragma warning disable 1591
namespace CommerceBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\RJ Hughes\Documents\GitHub\CommerceBankApp\CommerceBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RJ Hughes\Documents\GitHub\CommerceBankApp\CommerceBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RJ Hughes\Documents\GitHub\CommerceBankApp\CommerceBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\RJ Hughes\Documents\GitHub\CommerceBankApp\CommerceBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\RJ Hughes\Documents\GitHub\CommerceBankApp\CommerceBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\RJ Hughes\Documents\GitHub\CommerceBankApp\CommerceBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\RJ Hughes\Documents\GitHub\CommerceBankApp\CommerceBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\RJ Hughes\Documents\GitHub\CommerceBankApp\CommerceBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\RJ Hughes\Documents\GitHub\CommerceBankApp\CommerceBlazorServer\_Imports.razor"
using CommerceBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\RJ Hughes\Documents\GitHub\CommerceBankApp\CommerceBlazorServer\_Imports.razor"
using CommerceBlazorServer.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/settings")]
    public partial class Settings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddAttribute(1, "b-ak2hilm075");
            __builder.OpenElement(2, "PageTitle");
            __builder.AddAttribute(3, "b-ak2hilm075");
            __builder.AddContent(4, "Notification Settings");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "b-ak2hilm075");
            __builder.OpenElement(8, "p");
            __builder.AddAttribute(9, "b-ak2hilm075");
            __builder.AddMarkupContent(10, "<label b-ak2hilm075> Location Notification </label>\r\n\t<br b-ak2hilm075>\r\n     Get notifications about out of state purchases by choosing whitelisted state(s)\r\n\t <br b-ak2hilm075>\r\n\t <br b-ak2hilm075>\r\n     ");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "b-ak2hilm075");
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", "AL");
            __builder.AddAttribute(15, "b-ak2hilm075");
            __builder.AddContent(16, "Alabama");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\t\t");
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", "AK");
            __builder.AddAttribute(20, "b-ak2hilm075");
            __builder.AddContent(21, "Alaska");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\t\t");
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", "AZ");
            __builder.AddAttribute(25, "b-ak2hilm075");
            __builder.AddContent(26, "Arizona");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\t\t");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", "AR");
            __builder.AddAttribute(30, "b-ak2hilm075");
            __builder.AddContent(31, "Arkansas");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\t\t");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "CA");
            __builder.AddAttribute(35, "b-ak2hilm075");
            __builder.AddContent(36, "California");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\t\t");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "CO");
            __builder.AddAttribute(40, "b-ak2hilm075");
            __builder.AddContent(41, "Colorado");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\t\t");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "CT");
            __builder.AddAttribute(45, "b-ak2hilm075");
            __builder.AddContent(46, "Connecticut");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\t\t");
            __builder.OpenElement(48, "option");
            __builder.AddAttribute(49, "value", "DE");
            __builder.AddAttribute(50, "b-ak2hilm075");
            __builder.AddContent(51, "Delaware");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\t\t");
            __builder.OpenElement(53, "option");
            __builder.AddAttribute(54, "value", "DC");
            __builder.AddAttribute(55, "b-ak2hilm075");
            __builder.AddContent(56, "District Of Columbia");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\t\t");
            __builder.OpenElement(58, "option");
            __builder.AddAttribute(59, "value", "FL");
            __builder.AddAttribute(60, "b-ak2hilm075");
            __builder.AddContent(61, "Florida");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\t\t");
            __builder.OpenElement(63, "option");
            __builder.AddAttribute(64, "value", "GA");
            __builder.AddAttribute(65, "b-ak2hilm075");
            __builder.AddContent(66, "Georgia");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\t\t");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", "HI");
            __builder.AddAttribute(70, "b-ak2hilm075");
            __builder.AddContent(71, "Hawaii");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\t\t");
            __builder.OpenElement(73, "option");
            __builder.AddAttribute(74, "value", "ID");
            __builder.AddAttribute(75, "b-ak2hilm075");
            __builder.AddContent(76, "Idaho");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\t\t");
            __builder.OpenElement(78, "option");
            __builder.AddAttribute(79, "value", "IL");
            __builder.AddAttribute(80, "b-ak2hilm075");
            __builder.AddContent(81, "Illinois");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\t\t");
            __builder.OpenElement(83, "option");
            __builder.AddAttribute(84, "value", "IN");
            __builder.AddAttribute(85, "b-ak2hilm075");
            __builder.AddContent(86, "Indiana");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\t\t");
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value", "IA");
            __builder.AddAttribute(90, "b-ak2hilm075");
            __builder.AddContent(91, "Iowa");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\t\t");
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", "KS");
            __builder.AddAttribute(95, "b-ak2hilm075");
            __builder.AddContent(96, "Kansas");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n\t\t");
            __builder.OpenElement(98, "option");
            __builder.AddAttribute(99, "value", "KY");
            __builder.AddAttribute(100, "b-ak2hilm075");
            __builder.AddContent(101, "Kentucky");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n\t\t");
            __builder.OpenElement(103, "option");
            __builder.AddAttribute(104, "value", "LA");
            __builder.AddAttribute(105, "b-ak2hilm075");
            __builder.AddContent(106, "Louisiana");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n\t\t");
            __builder.OpenElement(108, "option");
            __builder.AddAttribute(109, "value", "ME");
            __builder.AddAttribute(110, "b-ak2hilm075");
            __builder.AddContent(111, "Maine");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n\t\t");
            __builder.OpenElement(113, "option");
            __builder.AddAttribute(114, "value", "MD");
            __builder.AddAttribute(115, "b-ak2hilm075");
            __builder.AddContent(116, "Maryland");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n\t\t");
            __builder.OpenElement(118, "option");
            __builder.AddAttribute(119, "value", "MA");
            __builder.AddAttribute(120, "b-ak2hilm075");
            __builder.AddContent(121, "Massachusetts");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n\t\t");
            __builder.OpenElement(123, "option");
            __builder.AddAttribute(124, "value", "MI");
            __builder.AddAttribute(125, "b-ak2hilm075");
            __builder.AddContent(126, "Michigan");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n\t\t");
            __builder.OpenElement(128, "option");
            __builder.AddAttribute(129, "value", "MN");
            __builder.AddAttribute(130, "b-ak2hilm075");
            __builder.AddContent(131, "Minnesota");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n\t\t");
            __builder.OpenElement(133, "option");
            __builder.AddAttribute(134, "value", "MS");
            __builder.AddAttribute(135, "b-ak2hilm075");
            __builder.AddContent(136, "Mississippi");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n\t\t");
            __builder.OpenElement(138, "option");
            __builder.AddAttribute(139, "value", "MO");
            __builder.AddAttribute(140, "b-ak2hilm075");
            __builder.AddContent(141, "Missouri");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n\t\t");
            __builder.OpenElement(143, "option");
            __builder.AddAttribute(144, "value", "MT");
            __builder.AddAttribute(145, "b-ak2hilm075");
            __builder.AddContent(146, "Montana");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n\t\t");
            __builder.OpenElement(148, "option");
            __builder.AddAttribute(149, "value", "NE");
            __builder.AddAttribute(150, "b-ak2hilm075");
            __builder.AddContent(151, "Nebraska");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n\t\t");
            __builder.OpenElement(153, "option");
            __builder.AddAttribute(154, "value", "NV");
            __builder.AddAttribute(155, "b-ak2hilm075");
            __builder.AddContent(156, "Nevada");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n\t\t");
            __builder.OpenElement(158, "option");
            __builder.AddAttribute(159, "value", "NH");
            __builder.AddAttribute(160, "b-ak2hilm075");
            __builder.AddContent(161, "New Hampshire");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n\t\t");
            __builder.OpenElement(163, "option");
            __builder.AddAttribute(164, "value", "NJ");
            __builder.AddAttribute(165, "b-ak2hilm075");
            __builder.AddContent(166, "New Jersey");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n\t\t");
            __builder.OpenElement(168, "option");
            __builder.AddAttribute(169, "value", "NM");
            __builder.AddAttribute(170, "b-ak2hilm075");
            __builder.AddContent(171, "New Mexico");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n\t\t");
            __builder.OpenElement(173, "option");
            __builder.AddAttribute(174, "value", "NY");
            __builder.AddAttribute(175, "b-ak2hilm075");
            __builder.AddContent(176, "New York");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n\t\t");
            __builder.OpenElement(178, "option");
            __builder.AddAttribute(179, "value", "NC");
            __builder.AddAttribute(180, "b-ak2hilm075");
            __builder.AddContent(181, "North Carolina");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n\t\t");
            __builder.OpenElement(183, "option");
            __builder.AddAttribute(184, "value", "ND");
            __builder.AddAttribute(185, "b-ak2hilm075");
            __builder.AddContent(186, "North Dakota");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n\t\t");
            __builder.OpenElement(188, "option");
            __builder.AddAttribute(189, "value", "OH");
            __builder.AddAttribute(190, "b-ak2hilm075");
            __builder.AddContent(191, "Ohio");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n\t\t");
            __builder.OpenElement(193, "option");
            __builder.AddAttribute(194, "value", "OK");
            __builder.AddAttribute(195, "b-ak2hilm075");
            __builder.AddContent(196, "Oklahoma");
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n\t\t");
            __builder.OpenElement(198, "option");
            __builder.AddAttribute(199, "value", "OR");
            __builder.AddAttribute(200, "b-ak2hilm075");
            __builder.AddContent(201, "Oregon");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n\t\t");
            __builder.OpenElement(203, "option");
            __builder.AddAttribute(204, "value", "PA");
            __builder.AddAttribute(205, "b-ak2hilm075");
            __builder.AddContent(206, "Pennsylvania");
            __builder.CloseElement();
            __builder.AddMarkupContent(207, "\r\n\t\t");
            __builder.OpenElement(208, "option");
            __builder.AddAttribute(209, "value", "RI");
            __builder.AddAttribute(210, "b-ak2hilm075");
            __builder.AddContent(211, "Rhode Island");
            __builder.CloseElement();
            __builder.AddMarkupContent(212, "\r\n\t\t");
            __builder.OpenElement(213, "option");
            __builder.AddAttribute(214, "value", "SC");
            __builder.AddAttribute(215, "b-ak2hilm075");
            __builder.AddContent(216, "South Carolina");
            __builder.CloseElement();
            __builder.AddMarkupContent(217, "\r\n\t\t");
            __builder.OpenElement(218, "option");
            __builder.AddAttribute(219, "value", "SD");
            __builder.AddAttribute(220, "b-ak2hilm075");
            __builder.AddContent(221, "South Dakota");
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\r\n\t\t");
            __builder.OpenElement(223, "option");
            __builder.AddAttribute(224, "value", "TN");
            __builder.AddAttribute(225, "b-ak2hilm075");
            __builder.AddContent(226, "Tennessee");
            __builder.CloseElement();
            __builder.AddMarkupContent(227, "\r\n\t\t");
            __builder.OpenElement(228, "option");
            __builder.AddAttribute(229, "value", "TX");
            __builder.AddAttribute(230, "b-ak2hilm075");
            __builder.AddContent(231, "Texas");
            __builder.CloseElement();
            __builder.AddMarkupContent(232, "\r\n\t\t");
            __builder.OpenElement(233, "option");
            __builder.AddAttribute(234, "value", "UT");
            __builder.AddAttribute(235, "b-ak2hilm075");
            __builder.AddContent(236, "Utah");
            __builder.CloseElement();
            __builder.AddMarkupContent(237, "\r\n\t\t");
            __builder.OpenElement(238, "option");
            __builder.AddAttribute(239, "value", "VT");
            __builder.AddAttribute(240, "b-ak2hilm075");
            __builder.AddContent(241, "Vermont");
            __builder.CloseElement();
            __builder.AddMarkupContent(242, "\r\n\t\t");
            __builder.OpenElement(243, "option");
            __builder.AddAttribute(244, "value", "VA");
            __builder.AddAttribute(245, "b-ak2hilm075");
            __builder.AddContent(246, "Virginia");
            __builder.CloseElement();
            __builder.AddMarkupContent(247, "\r\n\t\t");
            __builder.OpenElement(248, "option");
            __builder.AddAttribute(249, "value", "WA");
            __builder.AddAttribute(250, "b-ak2hilm075");
            __builder.AddContent(251, "Washington");
            __builder.CloseElement();
            __builder.AddMarkupContent(252, "\r\n\t\t");
            __builder.OpenElement(253, "option");
            __builder.AddAttribute(254, "value", "WV");
            __builder.AddAttribute(255, "b-ak2hilm075");
            __builder.AddContent(256, "West Virginia");
            __builder.CloseElement();
            __builder.AddMarkupContent(257, "\r\n\t\t");
            __builder.OpenElement(258, "option");
            __builder.AddAttribute(259, "value", "WI");
            __builder.AddAttribute(260, "b-ak2hilm075");
            __builder.AddContent(261, "Wisconsin");
            __builder.CloseElement();
            __builder.AddMarkupContent(262, "\r\n\t\t");
            __builder.OpenElement(263, "option");
            __builder.AddAttribute(264, "value", "WY");
            __builder.AddAttribute(265, "b-ak2hilm075");
            __builder.AddContent(266, "Wyoming");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(267, "\r\n\r\n\t");
            __builder.AddMarkupContent(268, @"<p b-ak2hilm075><label for=""cap"" b-ak2hilm075>Withdraw Size Notification </label>
	<br b-ak2hilm075>
	Choose for withdraws to notify over a set limit
	<br b-ak2hilm075>
	<br b-ak2hilm075>
	<input type=""text"" id=""cap"" name=""cap"" pattern=""[0-9]+"" b-ak2hilm075></p>

	");
            __builder.AddMarkupContent(269, @"<p b-ak2hilm075><label for=""category"" b-ak2hilm075>Category Notification</label>
	<br b-ak2hilm075>
	Choose to notify for specific transaction types
	<br b-ak2hilm075>
	<br b-ak2hilm075>
	<input type=""text"" id=""category"" name=""category"" b-ak2hilm075></p>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
