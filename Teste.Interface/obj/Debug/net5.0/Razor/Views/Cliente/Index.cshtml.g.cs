#pragma checksum "C:\prj\b\Thomasgreg\Thomagreg.Interface\Views\Cliente\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b9ad314aef6b6df8581f94f7e48b6cced5f9b46db9f3d5bfcec8a73bd91ac720"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\prj\b\Thomasgreg\Thomagreg.Interface\Views\_ViewImports.cshtml"
using Urna;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b9ad314aef6b6df8581f94f7e48b6cced5f9b46db9f3d5bfcec8a73bd91ac720", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de5f4fa0c7a30af8494ad328c2a2906384a98fbb175f221150381df84a8ee6a7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("criarCliente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("criarCliente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\prj\b\Thomasgreg\Thomagreg.Interface\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Clientes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-md-center\">\r\n    <div class=\"col-md-10\">\r\n\r\n        <div class=\"alert\" id=\"alertCliente\" role=\"alert\"></div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9ad314aef6b6df8581f94f7e48b6cced5f9b46db9f3d5bfcec8a73bd91ac7204240", async() => {
                WriteLiteral(@"
            <h2 class=""text-monospace"">Novo Cliente</h2>
            <hr />
            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <label for=""nome"" class=""control-label"">Nome do Cliente</label>
                        <input id=""nome"" name=""nome"" class=""form-control"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <label for=""email"" class=""control-label"">Email</label>
                        <input id=""email"" name=""email"" class=""form-control"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <label for=""fileInput"">Escolha um arquivo</label>
                        <div class=""custom-file"">
                            <input name=""arquivo"" type=""file"" class=""custom-file-input"" id=""arquiv");
                WriteLiteral(@"o"" accept=""image/*"">
                            <label class=""custom-file-label"" for=""fileInput"" data-browse=""Escolher"">Selecione o arquivo</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <button id=""addCliente"" type=""button"" class=""btn btn-success"">ADICIONAR</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <h2 class=""text-monospace mt-4"">
            Clientes já cadastrados
        </h2>

        <table class=""table table-striped"" id=""tbClientes"">
            <thead>
                <tr>
                    <th scope=""col"">Nome</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Logotipo</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
        </table>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        const arqBase64 = arq => new Promise((resolve, reject) => {
            const reader = new FileReader();
            reader.readAsDataURL(arq);
            reader.onload = () => resolve(reader.result);
            reader.onerror = reject;
        });

        async function leArquivo(arq) {
            return arqBase64(arq);
        }

        $(function () {
            new DataTable('#tbClientes', {
                ajax: { url: """);
#nullable restore
#line 71 "C:\prj\b\Thomasgreg\Thomagreg.Interface\Views\Cliente\Index.cshtml"
                         Write(Url.ActionLink("ListarClientes","Cliente"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""", dataSrc: """" },
                language: {
                    url: '//cdn.datatables.net/plug-ins/1.13.6/i18n/pt-BR.json'
                },
                columns: [
                    { data: 'nome' },
                    { data: 'email' },
                    {
                        data: 'logoBase64', render: function (data) {
                            if (data == '' || data == undefined)
                                return '';
                            return `<img id=""imagemBase64"" src=""${data}"" width=""50px"">`;
                        }
                    },
                    {
                        data: 'id', render: function (data) {
                            if (data == '' || data == undefined)
                                return '';
                            return `<a class=""deletarCliente"" onclick=""deletarCliente('${data}')"" href=""javascript:void(0)"">&#x274C;</a>`;
                        }
                    },
                    {
             ");
                WriteLiteral("           data: \'id\', render: function (data) {\r\n                            if (data == \'\' || data == undefined)\r\n                                return \'\';\r\n                            return `<a class=\"deletarCliente\" href=\"");
#nullable restore
#line 96 "C:\prj\b\Thomasgreg\Thomagreg.Interface\Views\Cliente\Index.cshtml"
                                                               Write(Url.Action("Editar","Cliente"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/${data}"">editar</a>`;
                        }
                    }
                ]
            });

            $('#addCliente').click(async function (e) {
                showLoading();
                e.preventDefault();
                const form = document.forms.criarCliente;

                const { nome, email } = form;


                if (nome.value === """") {
                    hideLoading();
                    alert('E necessário adicionar o nome do cliente!');
                    return false;
                }
                if (email.value === """") {
                    hideLoading();
                    alert('E necessário adicionar o email cliente!');
                    return false;
                }

                const obj = {};
                obj.Id = """";
                obj.Nome = nome.value;
                obj.Email = email.value;

                const arq = document.getElementById('arquivo').files[0];
                const base64 = await leArq");
                WriteLiteral(@"uivo(arq);
                let ext = arq.name.split('.');
                ext = ext[ext.length - 1];
                console.log(ext);
                console.log(base64);

                obj.Logotipo = {
                    Base64: base64.split(',')[1],
                    Extensao: ext
                };
                console.log(obj);

                $.ajax({
                    url: '/Cliente/CriarCliente',
                    method: 'POST',
                    data: JSON.stringify(obj),
                    dataType: 'json',
                    contentType: 'application/json',
                    success: function (data) {
                        var ret = JSON.parse(data.ret)
                        console.log(data.sucesso);
                        console.log(ret);
                        console.log(ret.exibicaoMensagem);
                        if (data.sucesso) {
                            $('#alertCliente').addClass('alert-success');
                            $('#al");
                WriteLiteral(@"ertCliente').removeClass('alert-danger');
                            $('#alertCliente').html('cliente cadastrado com sucesso!');
                            $('#alertCliente').fadeIn();
                        } else {
                            $('#alertCliente').addClass('alert-danger');
                            $('#alertCliente').removeClass('alert-success');
                            $('#alertCliente').html(ret.exibicaoMensagem.mensagemCurta);
                            $('#alertCliente').fadeIn();
                        }
                        //$('#IdLegenda').val("""");
                        //$('#nomeCandidato').val("""");
                        //$('#viceCandidato').val("""");
                        //setTimeout(function () {
                        //    $('#criarCandidato').fadeOut();
                        //    $('#alertCandidato').fadeOut();
                        //}, 3000);
                        hideLoading();
                        $(""#tbClientes"").DataTable().a");
                WriteLiteral(@"jax.reload();
                    }
                });

            });
        })
        function deletarCliente(id) {
            showLoading();
            $.ajax({
                url: '/DeletarCliente/' + id,
                method: 'DELETE',
                dataType: 'json',
                contentType: 'application/json',
                success: function (data) {
                    hideLoading();
                    $(""#tbClientes"").DataTable().ajax.reload();
                }
            });
        }

    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
