// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Iris.Web.Areas.Admin.Controllers
{
    public partial class PageController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected PageController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ConfirmDelete()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ConfirmDelete);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Delete()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Edit()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public PageController Actions { get { return MVC.Admin.Page; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "admin";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "page";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "page";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = ("Index").ToLowerInvariant();
            public readonly string Add = ("Add").ToLowerInvariant();
            public readonly string DataTable = ("DataTable").ToLowerInvariant();
            public readonly string ConfirmDelete = ("ConfirmDelete").ToLowerInvariant();
            public readonly string Delete = ("Delete").ToLowerInvariant();
            public readonly string Edit = ("Edit").ToLowerInvariant();
        }


        static readonly ActionParamsClass_Add s_params_Add = new ActionParamsClass_Add();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Add AddParams { get { return s_params_Add; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Add
        {
            public readonly string pageModel = ("pageModel").ToLowerInvariant();
        }
        static readonly ActionParamsClass_DataTable s_params_DataTable = new ActionParamsClass_DataTable();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DataTable DataTableParams { get { return s_params_DataTable; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DataTable
        {
            public readonly string term = ("term").ToLowerInvariant();
            public readonly string page = ("page").ToLowerInvariant();
            public readonly string count = ("count").ToLowerInvariant();
            public readonly string order = ("order").ToLowerInvariant();
            public readonly string orderBy = ("orderBy").ToLowerInvariant();
            public readonly string searchBy = ("searchBy").ToLowerInvariant();
        }
        static readonly ActionParamsClass_ConfirmDelete s_params_ConfirmDelete = new ActionParamsClass_ConfirmDelete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ConfirmDelete ConfirmDeleteParams { get { return s_params_ConfirmDelete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ConfirmDelete
        {
            public readonly string id = ("id").ToLowerInvariant();
        }
        static readonly ActionParamsClass_Delete s_params_Delete = new ActionParamsClass_Delete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Delete DeleteParams { get { return s_params_Delete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Delete
        {
            public readonly string id = ("id").ToLowerInvariant();
        }
        static readonly ActionParamsClass_Edit s_params_Edit = new ActionParamsClass_Edit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Edit EditParams { get { return s_params_Edit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Edit
        {
            public readonly string id = ("id").ToLowerInvariant();
            public readonly string pageModel = ("pageModel").ToLowerInvariant();
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _Add = "_Add";
                public readonly string _ConfirmDelete = "_ConfirmDelete";
                public readonly string _DataTable = "_DataTable";
                public readonly string _Edit = "_Edit";
                public readonly string _Index = "_Index";
                public readonly string _NavBar = "_NavBar";
            }
            public readonly string _Add = "~/Areas/Admin/Views/Page/_Add.cshtml";
            public readonly string _ConfirmDelete = "~/Areas/Admin/Views/Page/_ConfirmDelete.cshtml";
            public readonly string _DataTable = "~/Areas/Admin/Views/Page/_DataTable.cshtml";
            public readonly string _Edit = "~/Areas/Admin/Views/Page/_Edit.cshtml";
            public readonly string _Index = "~/Areas/Admin/Views/Page/_Index.cshtml";
            public readonly string _NavBar = "~/Areas/Admin/Views/Page/_NavBar.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_PageController : Iris.Web.Areas.Admin.Controllers.PageController
    {
        public T4MVC_PageController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void AddOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Add()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Add);
            AddOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void AddOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Iris.Model.AdminModel.AddPageModel pageModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult Add(Iris.Model.AdminModel.AddPageModel pageModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Add);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "pageModel", pageModel);
            AddOverride(callInfo, pageModel);
            return callInfo;
        }

        [NonAction]
        partial void DataTableOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string term, int page, int count, Iris.Servicelayer.EFServices.Enums.Order order, Iris.Servicelayer.EFServices.Enums.PageOrderBy orderBy, Iris.Servicelayer.EFServices.Enums.PageSearchBy searchBy);

        [NonAction]
        public override System.Web.Mvc.ActionResult DataTable(string term, int page, int count, Iris.Servicelayer.EFServices.Enums.Order order, Iris.Servicelayer.EFServices.Enums.PageOrderBy orderBy, Iris.Servicelayer.EFServices.Enums.PageSearchBy searchBy)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DataTable);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "term", term);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "count", count);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "order", order);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "orderBy", orderBy);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "searchBy", searchBy);
            DataTableOverride(callInfo, term, page, count, order, orderBy, searchBy);
            return callInfo;
        }

        [NonAction]
        partial void ConfirmDeleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult ConfirmDelete(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ConfirmDelete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ConfirmDeleteOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void DeleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Delete(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            DeleteOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            EditOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Iris.Model.AdminModel.EditPageModel pageModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(Iris.Model.AdminModel.EditPageModel pageModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "pageModel", pageModel);
            EditOverride(callInfo, pageModel);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
