using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12_cv_api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http.Headers;

namespace _12_cv_WPF
{
    class WPFModel
    {
        public List<SelectListItem> OperationList { get; } = new List<SelectListItem>
        {
             new SelectListItem { Value = "plus", Text = "+"},
             new SelectListItem { Value = "minus", Text = "-"},
             new SelectListItem { Value = "krat", Text = "*"},
             new SelectListItem { Value = "deleno", Text = "/"}
        };
    }
}
