using ClassSchedule.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassSchedule.Components
{
    public class DayFilter : ViewComponent
    {
        private IRepository<Day> days { get; set; }
        public DayFilter(IRepository<Day> rep) => days = rep;
        public IViewComponentResult Invoke(string selesctedValue)
        {
            var day = days.List(new QueryOptions<Day>
            {
                OrderBy = day => day.DayId
            });
            var vm = new DropDownViewModel
            {

            }
        }
    }
}
