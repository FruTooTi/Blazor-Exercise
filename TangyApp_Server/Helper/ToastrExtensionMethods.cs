using Microsoft.JSInterop;

namespace TangyApp_Server.Helper
{
    public static class ToastrExtensionMethods
    {
        public static async Task ToastrSuccess(this IJSRuntime JsRuntime)
        {
            await JsRuntime.InvokeVoidAsync("ShowToastr", "success");
        }
        public static async Task ToastrError(this IJSRuntime JsRuntime)
        {
            await JsRuntime.InvokeVoidAsync("ShowToastr", "error");
        }
    }
}
