using System;
using System.Collections;
using System.Linq;
using PPS.Mobile.ViewModels;
using Telerik.XamarinForms.Input.DataForm;

namespace PPS.Mobile.Utils
{
    public class UserPropertyDataSourceProvider : PropertyDataSourceProvider
    {
        public override IList GetSourceForKey(object key)
        {
            if (key.ToString().Equals(nameof(IssueViewModel.Severity)))
            {
                return Enumerable.Range(1, 10).ToList();
            }

            return base.GetSourceForKey(key);
        }
    }
}
