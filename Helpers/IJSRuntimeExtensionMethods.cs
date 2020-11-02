using Microsoft.JSInterop;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

public static class IJSRuntimeExtensionMethods
{
    public static async ValueTask MyFunction(this IJSRuntime js, string message)
    {
        await js.InvokeVoidAsync("my_function", message);
    }

    public static async ValueTask FocusInput(this IJSRuntime js, string id)
    {
        await js.InvokeVoidAsync("focusInput", id);
    }

    public static async ValueTask ShowAlert(this IJSRuntime js, string message)
    {
        await js.InvokeVoidAsync("showAlert", message);
    }
    
    public static ValueTask FocusAsync(this IJSRuntime jsRuntime, ElementReference elementReference)
    {
        return jsRuntime.InvokeVoidAsync("BlazorFocusElement", elementReference);
    }
}