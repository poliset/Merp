﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace Merp.Web.Site.Areas.ProjectManagement.Models.Home
{
    public class IndexViewModel
    {
        [DisplayName("Current only")]
        public bool CurrentOnly { get; set; }
        [DisplayName("Customer")]
        public IEnumerable<SelectListItem> Customers { get; set; }
        public Guid SelectedCustomerId { get; set; }

        public class CustomerInfo
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
        }

        public class Project
        {
            public Guid Id { get; set; }
            public Guid CustomerId { get; set; }
            public string Name { get; set; }
            public string Number { get; set; }
            public bool IsCompleted { get; set; }
        }
    }
}