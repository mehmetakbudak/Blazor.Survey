#pragma checksum "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f0b1a5997da34ee8d3bc0045a1f9ac18a2c68e0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorLearn.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\_Imports.razor"
using BlazorLearn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\_Imports.razor"
using BlazorLearn.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
using BlazorLearn.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
using BlazorLearn.Models.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/QuestionCategories")]
    public partial class QuestionCategories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mb-2");
            __builder.AddMarkupContent(2, "<div class=\"col\"><h5>Soru Kategorileri</h5></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col");
            __builder.OpenComponent<AntDesign.Button>(5);
            __builder.AddAttribute(6, "class", "float-right");
            __builder.AddAttribute(7, "Type", "primary");
            __builder.AddAttribute(8, "Icon", "plus");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                                                                         Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Ekle");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __Blazor.BlazorLearn.Pages.QuestionCategories.TypeInference.CreateTable_0(__builder, 13, 14, 
#nullable restore
#line 18 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                    questionCategories

#line default
#line hidden
#nullable disable
            , 15, 
#nullable restore
#line 19 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                 true

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 20 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
              total

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 21 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                loading

#line default
#line hidden
#nullable disable
            , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<AntDesign.PaginationEventArgs>(this, 
#nullable restore
#line 24 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                          pageIndexChange

#line default
#line hidden
#nullable disable
            ), 19, 
#nullable restore
#line 22 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                        pageIndex

#line default
#line hidden
#nullable disable
            , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pageIndex = __value, pageIndex)), 21, 
#nullable restore
#line 23 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                       pageSize

#line default
#line hidden
#nullable disable
            , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pageSize = __value, pageSize)), 23, (context) => (__builder2) => {
                __builder2.OpenComponent<AntDesign.ActionColumn>(24);
                __builder2.AddAttribute(25, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                         100

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Space>(27);
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.SpaceItem>(29);
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<AntDesign.Button>(31);
                            __builder5.AddAttribute(32, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                                 ()=>Edit(context)

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(34, "Düzenle");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(35, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.SpaceItem>(36);
                        __builder4.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<AntDesign.Button>(38);
                            __builder5.AddAttribute(39, "Danger", true);
                            __builder5.AddAttribute(40, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                                        ()=>Delete(context.Id)

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(42, "Sil");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n    ");
                __Blazor.BlazorLearn.Pages.QuestionCategories.TypeInference.CreateColumn_1(__builder2, 44, 45, "Kategori Adı", 46, 
#nullable restore
#line 35 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                          context.Name

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Name = __value, context.Name)), 48, () => context.Name);
            }
            , 49, (__value) => {
#nullable restore
#line 17 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
             table = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 39 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
  
    RenderFragment footer = 

#line default
#line hidden
#nullable disable
            (__builder2) => {
                __builder2.OpenComponent<AntDesign.Template>(50);
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Button>(52);
                    __builder3.AddAttribute(53, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                          Cancel

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(55, "Kapat");
                    }
                    ));
                    __builder3.SetKey(
#nullable restore
#line 41 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                                          "back"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.Button>(57);
                    __builder3.AddAttribute(58, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                          Save

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(59, "Type", "primary");
                    __builder3.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(61, "\r\n            Kaydet\r\n        ");
                    }
                    ));
                    __builder3.SetKey(
#nullable restore
#line 42 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                                        "submit"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
#nullable restore
#line 46 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
               ;

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AntDesign.Modal>(62);
            __builder.AddAttribute(63, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>(
#nullable restore
#line 49 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
               modalTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                 modalVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "OnOk", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
              Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(66, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                  Cancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(67, "Footer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>?>(
#nullable restore
#line 53 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                footer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(69);
                __builder2.AddAttribute(70, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 54 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                            editContext

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 54 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                                                         Save

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(73);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(75);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\r\n        ");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "form-group");
                    __builder3.AddMarkupContent(79, "<label>Kategori Adı</label>\r\n            ");
                    __Blazor.BlazorLearn.Pages.QuestionCategories.TypeInference.CreateInput_2(__builder3, 80, 81, "Kategori Adı", 82, 
#nullable restore
#line 59 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                                                           questionCategory.Name

#line default
#line hidden
#nullable disable
                    , 83, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => questionCategory.Name = __value, questionCategory.Name)), 84, () => questionCategory.Name);
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\r\n        ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "form-group");
                    __builder3.AddMarkupContent(88, "<label>Aktif</label>\r\n            ");
                    __builder3.OpenComponent<AntDesign.Switch>(89);
                    __builder3.AddAttribute(90, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 63 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
                             questionCategory.IsActive

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\Projects\BlazorLearn\BlazorLearn\BlazorLearn\Pages\QuestionCategories.razor"
       
    ITable table;

    int pageIndex = 1;
    int pageSize = 5;
    int total = 0;
    bool loading = true;

    QuestionCategory questionCategory = new QuestionCategory();
    EditContext editContext;

    string modalTitle = string.Empty;
    bool modalVisible = false;

    private IList<QuestionCategory> questionCategories;

    protected override void OnInitialized()
    {
        editContext = new EditContext(questionCategory);
        LoadData();
    }

    private void LoadData()
    {
        var result = questionService.Get(pageIndex, pageSize);
        questionCategories = result.Results;
        total = result.RowCount;
        loading = false;
    }

    private void Add()
    {
        modalVisible = true;
        modalTitle = "Soru Kategorisi Ekle";
    }

    private void Edit(QuestionCategory model)
    {
        modalVisible = true;
        modalTitle = "Soru Kategorisi Düzenle";
        questionCategory = model;
        editContext = new EditContext(model);
    }

    private void Delete(int id)
    {
    }

    private void pageIndexChange(PaginationEventArgs args)
    {
        pageIndex = args.PageIndex;
        LoadData();
    }

    private void Save()
    {
        if (editContext.Validate())
        {
            if (questionCategory.Id == 0)
            {
                questionService.Add(questionCategory);
            }
            else
            {
                questionService.Edit(questionCategory);
            }
            modalVisible = false;
            LoadData();
        }
    }

    private void Cancel()
    {
        modalVisible = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionCategoryService questionService { get; set; }
    }
}
namespace __Blazor.BlazorLearn.Pages.QuestionCategories
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTable_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Int32 __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<global::AntDesign.PaginationEventArgs> __arg4, int __seq5, global::System.Int32 __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32> __arg6, int __seq7, global::System.Int32 __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32> __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg9, int __seq10, global::System.Action<global::AntDesign.Table<TItem>> __arg10)
        {
        __builder.OpenComponent<global::AntDesign.Table<TItem>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "Bordered", __arg1);
        __builder.AddAttribute(__seq2, "Total", __arg2);
        __builder.AddAttribute(__seq3, "Loading", __arg3);
        __builder.AddAttribute(__seq4, "OnPageIndexChange", __arg4);
        __builder.AddAttribute(__seq5, "PageIndex", __arg5);
        __builder.AddAttribute(__seq6, "PageIndexChanged", __arg6);
        __builder.AddAttribute(__seq7, "PageSize", __arg7);
        __builder.AddAttribute(__seq8, "PageSizeChanged", __arg8);
        __builder.AddAttribute(__seq9, "ChildContent", __arg9);
        __builder.AddComponentReferenceCapture(__seq10, (__value) => { __arg10((global::AntDesign.Table<TItem>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateColumn_1<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TData __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg3)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "FieldChanged", __arg2);
        __builder.AddAttribute(__seq3, "FieldExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInput_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
