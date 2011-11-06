using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using MarkdownSharp;
using MavenThought.PrDC.Api;

namespace MavenThought.PrDC.Demo.Helpers
{
    public static class SpeakersHelper
    {
        public static IHtmlString Bio(this HtmlHelper<IEnumerable<ISpeaker>> helper, ISpeaker speaker)
        {
            return helper.Raw(new Markdown().Transform(speaker.Bio));
        }

        public static string LinkTo(this HtmlHelper helper, string link, string text)
        {
            var tag = new TagBuilder("a");

            tag.Attributes["target"] = "blank";

            tag.Attributes["href"] = link;

            tag.SetInnerText(text);

            return tag.ToString();
        }

        public static IHtmlString MediaLinks(this HtmlHelper<IEnumerable<ISpeaker>> helper, ISpeaker speaker)
        {
            var result = new StringBuilder();

            if (speaker.Email != string.Empty)
            {
                result.Append(helper.LinkTo(string.Format("mailto:{0}", speaker.Email), "Email"));
            }

            if (speaker.Blog != string.Empty)
            {
                result.Append(helper.LinkTo(speaker.Blog, "Blog"));
            }
                                
            if (speaker.WebSite != string.Empty)
            {
                result.Append(helper.LinkTo(speaker.WebSite, "Website"));
            }

            if (!string.IsNullOrEmpty(speaker.Twitter))
            {
                result.Append(helper.LinkTo(string.Format("http://www.twitter.com/{0}", speaker.Twitter), "Twitter"));
            }

            return helper.Raw(result.ToString());
        }
    }
}