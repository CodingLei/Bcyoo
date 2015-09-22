using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XianShou.bcyoo.Common.Helper
{
    public class DateHelper
    {
        /// <summary>  
        /// 得到本周第一天(以星期天为第一天)  
        /// </summary>  
        /// <param name="datetime"></param>  
        /// <returns></returns>  
        public static DateTime GetWeekFirstDaySun(DateTime datetime)
        {
            //星期天为第一天  
            int weeknow = Convert.ToInt32(datetime.DayOfWeek);
            int daydiff = (-1) * weeknow;

            //本周第一天  
            string FirstDay = datetime.AddDays(daydiff).ToString("yyyy-MM-dd");
            return Convert.ToDateTime(FirstDay);
        }

        /// <summary>  
        /// 得到本周第一天(以星期一为第一天)  
        /// </summary>  
        /// <param name="datetime"></param>  
        /// <returns></returns>  
        public static DateTime GetWeekFirstDayMon(DateTime datetime)
        {
            //星期一为第一天  
            int weeknow = Convert.ToInt32(datetime.DayOfWeek);

            //因为是以星期一为第一天，所以要判断weeknow等于0时，要向前推6天。  
            weeknow = (weeknow == 0 ? (7 - 1) : (weeknow - 1));
            int daydiff = (-1) * weeknow;

            //本周第一天  
            string FirstDay = datetime.AddDays(daydiff).ToString("yyyy-MM-dd");
            return Convert.ToDateTime(FirstDay);
        }

        /// <summary>  
        /// 得到本周最后一天(以星期六为最后一天)  
        /// </summary>  
        /// <param name="datetime"></param>  
        /// <returns></returns>  
        public static DateTime GetWeekLastDaySat(DateTime datetime)
        {
            //星期六为最后一天  
            int weeknow = Convert.ToInt32(datetime.DayOfWeek);
            int daydiff = (7 - weeknow) - 1;

            //本周最后一天  
            string LastDay = datetime.AddDays(daydiff).ToString("yyyy-MM-dd");
            return Convert.ToDateTime(LastDay);
        }

        /// <summary>  
        /// 得到本周最后一天(以星期天为最后一天)  
        /// </summary>  
        /// <param name="datetime"></param>  
        /// <returns></returns>  
        public static DateTime GetWeekLastDaySun(DateTime datetime)
        {
            //星期天为最后一天  
            int weeknow = Convert.ToInt32(datetime.DayOfWeek);
            weeknow = (weeknow == 0 ? 7 : weeknow);
            int daydiff = (7 - weeknow);

            //本周最后一天  
            string LastDay = datetime.AddDays(daydiff).ToString("yyyy-MM-dd");
            return Convert.ToDateTime(LastDay);
        }


        /// <summary>
        /// 获取本月第一天
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime GetMonthFirstDay(DateTime datetime)
        {
            return new DateTime(datetime.Year, datetime.Month, 1);
        }

        /// <summary>
        /// 获取本月最后一天
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime GetMonthLastDay(DateTime datetime)
        {
            return GetMonthFirstDay(datetime).AddMonths(1).AddDays(-1);
        }

        /// <summary>
        /// 时间戳转换成日期
        /// </summary>
        /// <param name="datestr"></param>
        /// <returns></returns>
        public static DateTime ConvertDate(string datestr)
        {
              DateTime conTime = new DateTime();  
              DateTime firstTime = new DateTime(1970, 1, 1);  
              int stime = -1;  
              if (int.TryParse(datestr, out stime) == false)  
              {  
                  conTime = Convert.ToDateTime(datestr);  
              }  
              else  
              {  
                  conTime = Convert.ToDateTime(firstTime.AddSeconds(stime));  
              }  
              return conTime;  
        }
        /// <summary>
        /// 转换日期变为描述
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ChangeDateToDescribe(DateTime date)
        {
            string result = date.ToString("MM-dd");
            if (date.Year == DateTime.Now.Year && date.Month == DateTime.Now.Month && date.Date == DateTime.Now.Date)
            {
                result = "今天";
            }
            if (date.Year == DateTime.Now.Year && date.Month == DateTime.Now.Month && date.Day == (DateTime.Now.Day - 1))
            {
                result = "昨天";
            }
            if (date.Year == DateTime.Now.Year && date.Month == DateTime.Now.Month && date.Day == (DateTime.Now.Day - 2))
            {
                result = "前天";
            }
            if (date.Year != DateTime.Now.Year)
            {
                result = date.ToString("yy-MM-dd");
            }
            return result;
        }

    }
}
