using System;
using System.Text;

namespace MoreExtensions
{
    /// <summary>
    /// Exception Extensions
    /// </summary>
    public static class ExceptionExtension
    {
        /// <summary>
        /// Provide all exception information in HTML format to either display or send as an email.
        /// </summary>
        /// <returns>String</returns>
        public static string ToHtmlException(this Exception exception)
        {
            if(exception != null)
            {
                StringBuilder builder = new StringBuilder();

                builder.Append("<H3>Error Occured</h3><hr>");
                builder.AppendFormat("<b>Date Time:</b><br>{0}<br><br>", DateTime.Now);
                builder.AppendFormat("<b>Error Code: </b><br>{0}<br><br>", exception.GetHashCode());
                builder.AppendFormat("<b>Base Exception: </b><br>{0}<br><br>", exception.GetBaseException());
                builder.AppendFormat("<b>Type: </b><br>{0}<br><br>", exception.GetType());
                builder.AppendFormat("<b>Inner Exception: </b><br>{0}<br><br>", exception.InnerException);
                builder.AppendFormat("<b>Message: </b><br>{0}<br><br>", exception.Message);
                builder.AppendFormat("<b>Source: </b><br>{0}<br><br>", exception.Source);
                builder.AppendFormat("<b>Stack Trace: </b><br>{0}<br><br>", exception.StackTrace);
                builder.AppendFormat("<b>Generic Info: </b><br>{0}<br><br><hr>", exception);

                return builder.ToString();

            }

            return string.Empty;
        }
    }
}
