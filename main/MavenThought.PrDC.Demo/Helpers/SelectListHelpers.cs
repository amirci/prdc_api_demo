using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MavenThought.PrDC.Demo.Helpers
{
    public static class SelectListHelpers
    {
        public static SelectList ToSelectList<TModel>(this IEnumerable<TModel> itemCollection,
                                                      Func<TModel, string> buildOptionValue,
                                                      Func<TModel, string> buildOptionText)
        {
            var values = itemCollection.Select(x => new { value = buildOptionValue(x), text = buildOptionText(x) });

            return new SelectList(values, "value", "text");
        }
    }
}