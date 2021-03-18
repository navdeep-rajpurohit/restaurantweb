using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturent.Models
{
    public static class JSInteropExt
    {
        public static async Task SaveAsFileAsync(this IJSRuntime js, string filename, byte[] data, string type = "application/octet-stream")
        {
            await js.InvokeAsync<object>("JSInteropExt.saveAsFile", filename, type, Convert.ToBase64String(data));


        }
    }
}

/*using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturent.Models
{
    public static class JsExcel
    {
        public static async Task SaveAsFileAsync(this IJSRuntime js, string filename, byte[] data, string type = "application/octet-stream")
        {
            await js.InvokeAsync<object>("JsExcel.saveAsFile", filename, type, Convert.ToBase64String(data));


        }
    }
}*/
