@Imports System.Web.Http
@Imports System.Web.Http.Description
@Imports WebApiApp_net461_vb_NoAuth_1.Areas.HelpPage.Models
@ModelType HelpPageApiModel

@Code
    Dim description As ApiDescription = Model.ApiDescription
    ViewData("Title") = description.HttpMethod.Method + " " + description.RelativePath
End Code

<link type="text/css" href="~/Areas/HelpPage/HelpPage.css" rel="stylesheet" />
<div id="body" class="help-page">
    <section class="featured">
        <div class="content-wrapper">
            <p>
                @Html.ActionLink("Help Page Home", "Index")
            </p>
        </div>
    </section>
    <section class="content-wrapper main-content clear-fix">
        @Html.DisplayForModel()
    </section>
</div>
