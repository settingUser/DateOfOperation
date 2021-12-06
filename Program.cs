using System;

namespace DateOfOperationTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("从当前时间开始计算："); 
            DateTime dtNow = DateTime.Now;
            //获取当天时间
            string today = dtNow.ToString("yyyy-MM-dd");
            Console.WriteLine("获取当天时间：{0}", today);
            //本周的周一 
            string thisWeek = null;
            //获取本周的时间
            int dayOfWeek = -1 * (int)dtNow.Date.DayOfWeek;
            DateTime weekStartTime = dtNow.AddDays(dayOfWeek + 1);//取本周一
            if (dayOfWeek == 0) //如果今天是周日，则开始时间是上周一
            {
                weekStartTime = weekStartTime.AddDays(-7);
            }
            thisWeek = weekStartTime.ToString("yyy-MM-dd");
            Console.WriteLine("周一：{0}", thisWeek);
            //获取本月
            string thisMonth = dtNow.ToString("yyyy-MM"); //当前月份
            Console.WriteLine("当前月份：{0}", thisMonth);
            //当前季度的第一天
            string extreme = null;
            int month = (int)dtNow.Date.Month;
            if (month >= 1 && month <= 3)
            {
                extreme = dtNow.Year.ToString() + "-01-01";
            }
            else if (month >= 4 && month <= 6)
            {
                extreme = dtNow.Year.ToString() + "-04-01";
            }
            else if (month >= 7 && month <= 9)
            {
                extreme = dtNow.Year.ToString() + "-07-01";
            }
            else if (month >= 10 && month <= 12)
            {
                extreme = dtNow.Year.ToString() + "-10-01";
            }
            Console.WriteLine("当前季度的第一天：{0}", extreme);
            //半年
            string halfYear = null; 
            if (month > 6)
            {
                halfYear = dtNow.Year.ToString() + "-07-01";
            }
            if (month <= 6)
            {
                halfYear = dtNow.Year.ToString() + "-01-01";
            } 
            string year = dtNow.Year.ToString();
            Console.WriteLine("半年：{0}", halfYear);
            Console.ReadKey();
        }
    }
}
