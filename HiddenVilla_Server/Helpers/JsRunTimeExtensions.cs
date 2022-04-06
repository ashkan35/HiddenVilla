using Microsoft.JSInterop;

namespace HiddenVilla_Server.Helpers
{
    public static class JsRunTimeExtensions
    {
        public static async ValueTask ShowErrorToaster(this IJSRuntime jsRuntime, string message)
        {
           await jsRuntime.InvokeVoidAsync("ShowToaster","error", message);
        }
        public static async ValueTask ShowSuccessToaster(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToaster", "success", message);
        }
        public static async ValueTask ShowWarningToaster(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToaster", "warning", message);
        }
        public static async ValueTask ShowInfoToaster(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToaster", "info", message);
        }
        public static async ValueTask ShowSuccessSweetAlert(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowSweetAlert", "success", message);
        }
    }
}
