using System.Web.Mvc;
using MavenThought.Commons.Testing;

namespace MavenThought.PrDC.Demo.Tests.Controllers
{
    /// <summary>
    /// Base specification for SessionsController
    /// </summary>
    public abstract class BaseControllerSpecification<T, TModel> 
        : AutoMockSpecificationWithNoContract<T> where T : class
    {
        /// <summary>
        /// Actual result obtained 
        /// </summary>
        protected ActionResult ActualResult { get; set; }

        /// <summary>
        /// Gets the Model from the result view
        /// </summary>
        protected TModel Model
        {
            get
            {
                var result = (ViewResult)this.ActualResult;

                return (TModel) result.ViewData.Model;
            }
        }
    }
}