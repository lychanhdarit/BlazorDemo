#pragma checksum "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaa4a084ab3dfb66bda348a631a63de61936728a"
// <auto-generated/>
#pragma warning disable 1591
namespace Todo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\_Imports.razor"
using Todo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\_Imports.razor"
using Todo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
using Todo.Component;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "input-group mb-3");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "input-group-prepend");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                          Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "class", "btn btn-outline-success");
            __builder.AddAttribute(7, "type", "button");
            __builder.AddContent(8, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "placeholder", "Todo");
            __builder.AddAttribute(14, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 41 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                                                                                          DoTheThing

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                  _current

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _current = __value, _current));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "input-group-append");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                          Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "btn btn-outline-success");
            __builder.AddAttribute(23, "type", "button");
            __builder.AddContent(24, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.OpenComponent<Todo.Component.TodoListItem>(26);
            __builder.AddAttribute(27, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Todo.Data.TodoItem>(
#nullable restore
#line 47 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                    _item

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenElement(29, "ol");
            __builder.AddAttribute(30, "class", "list-group");
#nullable restore
#line 49 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
     foreach (var i in _data)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "li");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "input-group" + " mb-3" + " " + (
#nullable restore
#line 52 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                                           i.Done ? "border border-success" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "input-group-prepend");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "input-group-text");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "checkbox");
            __builder.AddAttribute(40, "class", "custom-checkbox");
            __builder.AddAttribute(41, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                                                      i.Done

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => i.Done = __value, i.Done));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "text");
            __builder.AddAttribute(46, "class", "form-control");
            __builder.AddAttribute(47, "placeholder", "Todo");
            __builder.AddAttribute(48, "onfocus", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 58 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                                                                                                       e=>_item=i

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                                          i.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => i.Title = __value, i.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "text");
            __builder.AddAttribute(54, "class", "form-control");
            __builder.AddAttribute(55, "placeholder", "Note");
            __builder.AddAttribute(56, "onfocus", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 59 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                                                                                                      e=>_item=i

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                                          i.Note

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => i.Note = __value, i.Note));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "input-group-append");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn btn-outline-danger");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                                                                                     e=>_data.Remove(i)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(66, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                  Clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "class", "btn btn-outline-danger");
            __builder.AddContent(71, "Remove done");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                  ClearAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "class", "btn btn-outline-danger");
            __builder.AddContent(76, "Clear all");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
            __builder.OpenElement(78, "button");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
                  Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "class", "btn btn-outline-primary");
            __builder.AddContent(81, "Save");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "H:\2020 DATA\Learning\BlazorDemo\BlazorDemo\Todo\Pages\Index.razor"
      
    private List<TodoItem> _data;
    private string _current;
    private TodoItem _item;

    protected override void OnInitialized()
    {
        _data = Service.GetData();
        _item = _data != null && _data.Count > 0 ? _data[0] : null;
    }

    private void Add()
    {
        if (!string.IsNullOrWhiteSpace(_current))
            _data.Add(new TodoItem() { Title = _current });
    }

    private void Clear() => _data.RemoveAll(i => i.Done);

    private void ClearAll() => _data.Clear();

    private void DoTheThing(KeyboardEventArgs eventArgs)
    {
        if (eventArgs.Key == "Enter")        // fire on enter
        {
            Add();
        }
    }

    private void Save() => Service.SaveChanges();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TodoItemService Service { get; set; }
    }
}
#pragma warning restore 1591
