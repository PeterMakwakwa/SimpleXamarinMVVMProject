using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTest.ViewModel
{
    public class ViewModelLocator
    {
        public AddEmployeeViewModel AddEmployeeViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddEmployeeViewModel>();
            }
        }
        public AddPeopleViewModel AddPeopleViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddPeopleViewModel>();
            }
        }

        public PeopleViewModel PeopleViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<PeopleViewModel>();
            }
        }
        public EmployeeViewModel EmployeeViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EmployeeViewModel>();
            }
        }
        

    }
}
