using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core2._2TestApp.ViewModels
{
    public class EmployeeEditViewModel :EmployeeCreateViewModel
    {
        public int Id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
