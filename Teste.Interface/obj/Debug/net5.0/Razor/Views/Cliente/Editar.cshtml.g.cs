#pragma checksum "C:\prj\b\Thomasgreg\Thomagreg.Interface\Views\Cliente\Editar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7e324980e1661ee7ac2f58dd974e724ff66ae9c519c57f3855eb86198d3e4fe1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Editar), @"mvc.1.0.view", @"/Views/Cliente/Editar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7e324980e1661ee7ac2f58dd974e724ff66ae9c519c57f3855eb86198d3e4fe1", @"/Views/Cliente/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de5f4fa0c7a30af8494ad328c2a2906384a98fbb175f221150381df84a8ee6a7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cliente_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Thomagreg.Interface.Model.DtoCliente>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editarCliente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("editarCliente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("criarLogradouro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("criarLogradouro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editarLogradouro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("editarLogradouro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\prj\b\Thomasgreg\Thomagreg.Interface\Views\Cliente\Editar.cshtml"
  
    ViewData["Title"] = "Editar Cliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-md-center\">\r\n    <div class=\"col-md-10\">\r\n\r\n        <div class=\"alert\" id=\"alertCliente\" role=\"alert\"></div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e324980e1661ee7ac2f58dd974e724ff66ae9c519c57f3855eb86198d3e4fe15697", async() => {
                WriteLiteral("\r\n            <input id=\"id\" type=\"hidden\" name=\"id\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 366, "\"", 383, 1);
#nullable restore
#line 11 "C:\prj\b\Thomasgreg\Thomagreg.Interface\Views\Cliente\Editar.cshtml"
WriteAttributeValue("", 374, Model.Id, 374, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

            <h2 class=""text-monospace"">Editar Cliente</h2>
            <hr />
            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <label for=""nome"" class=""control-label"">Nome do Cliente</label>
                        <input id=""nome"" name=""nome"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 750, "\"", 769, 1);
#nullable restore
#line 19 "C:\prj\b\Thomasgreg\Thomagreg.Interface\Views\Cliente\Editar.cshtml"
WriteAttributeValue("", 758, Model.Nome, 758, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <label for=""email"" class=""control-label"">Email</label>
                        <input id=""email"" name=""email"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1068, "\"", 1088, 1);
#nullable restore
#line 25 "C:\prj\b\Thomasgreg\Thomagreg.Interface\Views\Cliente\Editar.cshtml"
WriteAttributeValue("", 1076, Model.Email, 1076, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <label for=""fileInput"">Escolha um arquivo</label>
                        <div class=""custom-file"">
                            <input name=""arquivo"" type=""file"" class=""custom-file-input"" id=""arquivo"" accept=""image/*"">
                            <label class=""custom-file-label"" for=""fileInput"" data-browse=""Escolher"">Selecione o arquivo</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <button id=""editCliente"" type=""button"" class=""btn btn-success"">Salvar</button>
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
            WriteLiteral("\r\n        <h2 class=\"text-monospace mt-4\">\r\n            Logradouros\r\n        </h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e324980e1661ee7ac2f58dd974e724ff66ae9c519c57f3855eb86198d3e4fe19892", async() => {
                WriteLiteral(@"
            <hr />
            <div class=""row"">
                <div class=""col-md-3"">
                    <div class=""form-group"">
                        <label for=""rua"" class=""control-label"">Rua</label>
                        <input id=""rua"" name=""rua"" class=""form-control"" />
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""form-group"">
                        <label for=""numero"" class=""control-label"">Numero</label>
                        <input id=""numero"" name=""numero"" class=""form-control"" />
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""form-group"">
                        <label for=""bairro"" class=""control-label"">Bairro</label>
                        <input id=""bairro"" name=""bairro"" class=""form-control"" />
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""form-");
                WriteLiteral(@"group"">
                        <label for=""cidade"" class=""control-label"">Cidade</label>
                        <input id=""cidade"" name=""cidade"" class=""form-control"" />
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <label for=""estado"" class=""control-label"">Estado</label>
                        <input id=""estado"" name=""estado"" class=""form-control"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <label for=""cep"" class=""control-label"">CEP</label>
                        <input id=""cep"" name=""cep"" class=""form-control"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <label for=""complemento"" class=""control-label""");
                WriteLiteral(@">Complemento</label>
                        <input id=""complemento"" name=""complemento"" class=""form-control"" />
                    </div>
                </div>

            </div>
            <div class=""form-group"">
                <button id=""addLogradouro"" type=""button"" class=""btn btn-success"">Salvar</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <table class=""table table-striped"" id=""tbLogradouros"">
            <thead>
                <tr>
                    <th scope=""col"">Rua</th>
                    <th scope=""col"">Numero</th>
                    <th scope=""col"">Bairro</th>
                    <th scope=""col"">Cidade</th>
                    <th scope=""col"">Estado</th>
                    <th scope=""col"">CEP</th>
                    <th scope=""col"">Complemento</th>
                    <th scope=""col""></th>
                    <th scope=""col""></th>
                </tr>
            </thead>
        </table>
    </div>
</div>



<div class=""modal fade"" id=""modalLogradouro"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Criar Logradouro</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
            ");
            WriteLiteral("        <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e324980e1661ee7ac2f58dd974e724ff66ae9c519c57f3855eb86198d3e4fe115156", async() => {
                WriteLiteral(@"
                    <input id=""idLogradouro"" type=""hidden"" name=""id"" class=""form-control"" />
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <div class=""form-group"">
                                <label for=""rua"" class=""control-label"">Rua</label>
                                <input name=""rua"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""col-md-3"">
                            <div class=""form-group"">
                                <label for=""numero"" class=""control-label"">Numero</label>
                                <input name=""numero"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""col-md-3"">
                            <div class=""form-group"">
                                <label for=""bairro"" class=""control-label"">Bairro</label>
                              ");
                WriteLiteral(@"  <input name=""bairro"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""col-md-3"">
                            <div class=""form-group"">
                                <label for=""cidade"" class=""control-label"">Cidade</label>
                                <input name=""cidade"" class=""form-control"" />
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label for=""estado"" class=""control-label"">Estado</label>
                                <input name=""estado"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label for=""cep"" class=""control");
                WriteLiteral(@"-label"">CEP</label>
                                <input name=""cep"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label for=""complemento"" class=""control-label"">Complemento</label>
                                <input name=""complemento"" class=""form-control"" />
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <button id=""atualizaLogradouro"" type=""button"" class=""btn btn-success"">Salvar</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
            carregarFuncoesLogradouro();

            $('#editCliente').click(async function (e) {

                showLoading();
                e.preventDefault();

                // get form data
                const form = document.forms.editarCliente;
                const { nome, email, id } = form;

                // validation
                if (nome.value === """") {
                    hideLoading();
                    alert('E necessário adicionar o nome do cliente!');
                    return false;
                }
                if (email.value === """") {
                    hideLoa");
                WriteLiteral(@"ding();
                    alert('E necessário adicionar o email cliente!');
                    return false;
                }

                // mount client object
                let obj = {};
                obj.Id = id.value;
                obj.Nome = nome.value;
                obj.Email = email.value;

                const arq = document.getElementById('arquivo').files[0];
                const base64 = await leArquivo(arq);
                let ext = arq.name.split('.');
                ext = ext[ext.length - 1];


                obj.Logotipo = {
                    Base64: base64.split(',')[1],
                    Extensao: ext
                };

                // request edition
                $.ajax({
                    url: '/Cliente/EditarCliente',
                    method: 'POST',
                    data: JSON.stringify(obj),
                    dataType: 'json',
                    contentType: 'application/json',
                    success: function (");
                WriteLiteral(@"data) {
                        hideLoading();
                    }
                });

            });
        })

        /****************************************************************** */

        function carregarFuncoesLogradouro() {
            console.log(""");
#nullable restore
#line 256 "C:\prj\b\Thomasgreg\Thomagreg.Interface\Views\Cliente\Editar.cshtml"
                    Write(Url.ActionLink("ListarLogradouros","Cliente"));

#line default
#line hidden
#nullable disable
                WriteLiteral("/\" + $(\"#id\").val())\r\n            new DataTable(\'#tbLogradouros\', {\r\n                ajax: { url: \"");
#nullable restore
#line 258 "C:\prj\b\Thomasgreg\Thomagreg.Interface\Views\Cliente\Editar.cshtml"
                         Write(Url.ActionLink("ListarLogradouros","Cliente"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/"" + $(""#id"").val(), dataSrc: """" },
                language: {
                    url: '//cdn.datatables.net/plug-ins/1.13.6/i18n/pt-BR.json'
                },
                columns: [
                    { data: 'rua' },
                    { data: 'numero' },
                    { data: 'bairro' },
                    { data: 'cidade' },
                    { data: 'estado' },
                    { data: 'cep' },
                    { data: 'complemento' },
                    {
                        data: 'id', render: function (data) {
                            if (data == '' || data == undefined)
                                return '';
                            return `<a class=""deletarCliente"" onclick=""removerLogradouro('${data}')"" href=""javascript:void(0)"">&#x274C;</a>`;
                        }
                    },
                    {
                        data: 'id', render: function (data) {
                            if (data == '' || data == undefined)
 ");
                WriteLiteral(@"                               return '';
                            return `<a class=""deletarCliente"" onclick=""editaLogradouro('${data}')"" href=""javascript:void(0)"">editar</a>`;
                        }
                    }
                ]
            });

            $('#addLogradouro').click(function (e) {
                showLoading();
                e.preventDefault();
                const form = document.forms.criarLogradouro;

                const {
                    rua
                    , numero
                    , bairro
                    , cidade
                    , estado
                    , cep
                    , complemento } = form;




                const obj = {};
                obj.Id = """";
                obj.IdCliente = $(""#id"").val();
                obj.Rua = rua.value;
                obj.Bairro = bairro.value;
                obj.Cidade = cidade.value;
                obj.Estado = estado.value;
                obj.Cep = cep.value");
                WriteLiteral(@";
                obj.Complemento = complemento.value;
                obj.Numero = numero.value;
                console.log(obj);
                $.ajax({
                    url: '/Cliente/AdicionarLogradouro',
                    method: 'POST',
                    data: JSON.stringify(obj),
                    dataType: 'json',
                    contentType: 'application/json',
                    success: function (data) {

                        hideLoading();
                        $(""#tbLogradouros"").DataTable().ajax.reload();
                    }
                });

            });

            $(""#atualizaLogradouro"").click(function (e) {
                showLoading();
                e.preventDefault();
                const form = document.forms.editarLogradouro;

                const {
                    id,
                    rua
                    , numero
                    , bairro
                    , cidade
                    , estado
           ");
                WriteLiteral(@"         , cep
                    , complemento } = form;




                const obj = {};
                obj.Id = id.value;
                obj.IdCliente = $(""#id"").val();
                obj.Rua = rua.value;
                obj.Bairro = bairro.value;
                obj.Cidade = cidade.value;
                obj.Estado = estado.value;
                obj.Cep = cep.value;
                obj.Complemento = complemento.value;
                obj.Numero = numero.value;
                console.log(obj);
                $.ajax({
                    url: '/Cliente/EditarLogradouro',
                    method: 'POST',
                    data: JSON.stringify(obj),
                    dataType: 'json',
                    contentType: 'application/json',
                    success: function (data) {

                        hideLoading();
                        $(""#tbLogradouros"").DataTable().ajax.reload();
                        $('#modalLogradouro').modal('hide');
             ");
                WriteLiteral(@"       }
                });
            });
        }

        function removerLogradouro(id) {
            showLoading();
            $.ajax({
                url: '/RemoverLogradouro/' + id,
                method: 'DELETE',
                dataType: 'json',
                contentType: 'application/json',
                success: function (data) {
                    hideLoading();
                    $(""#tbLogradouros"").DataTable().ajax.reload();
                }
            });
        }

        function editaLogradouro(id) {
            showLoading();
            $.ajax({
                url: '/Cliente/EditarLogradouro/' + id,
                method: 'GET',
                dataType: 'json',
                contentType: 'application/json',
                success: function (data) {
                    var mapping = {
                        ""id"": ""id"",
                        ""rua"": ""rua"",
                        ""numero"": ""numero"",
                        ""bairro"": ""bai");
                WriteLiteral(@"rro"",
                        ""cidade"": ""cidade"",
                        ""estado"": ""estado"",
                        ""cep"": ""cep"",
                        ""complemento"": ""complemento""
                    };

                    var form = $(""form[name='editarLogradouro']"");

                    Object.keys(mapping).forEach(function (fieldName) {
                        form.find(""input[name='"" + fieldName + ""']"").val(data[mapping[fieldName]]);
                    });
                    hideLoading();
                    $('#modalLogradouro').modal('show');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Thomagreg.Interface.Model.DtoCliente> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
