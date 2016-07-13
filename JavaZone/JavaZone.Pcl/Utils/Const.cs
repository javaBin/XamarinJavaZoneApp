using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaZone.Pcl.Utils
{
    public class Const
    {
        public static string BaseUrl = "https://javazone.no/javazone-web-api/events/javazone_2016/sessions";
        public static string SessionFeedbackUriTest = "http://test.javazone.no/devnull/server/";
        public static string SessionFeedbackUrl = "http://javazone.no/devnull/server/";
        public static string FeedbackEndPoint = "events/{0}/sessions/{1}/feedbacks";

        public static string ConferenceHashTag = "#javazone2016";
        public static string ConferenceHashTagPrefix = "#javazone";

        public static string ConferenceDayStart1 = "2015-09-09T08:00:00.000+01:00";
        public static string ConferenceDayEnd1 = "2015-09-09T23:59:59.000+01:00";
        public static string ConferenceDayStart2 = "2015-09-10T08:00:00.000+01:00";
        public static string ConferenceDayEnd2 = "2015-09-10T23:59:59.000+01:00";

        public static string TimeZone = "Europe/Oslo";

    }
}
