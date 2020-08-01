using EmployeeManagement.Model;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeDetailBase: ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        //declaring parameter passed from view
        [Parameter]
        public string Id { get; set; }
        public string Cordinates { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee=await EmployeeService.GetEmployee(int.Parse(Id));
        }
        protected void MouseMove(MouseEventArgs e)
        {
            Cordinates = $"X={e.ScreenX} Y ={e.ScreenY}";
        }
    }
}
