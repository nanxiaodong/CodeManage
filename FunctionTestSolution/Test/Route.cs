using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Route
    {
        /// <summary>
        /// 产品所属供应商信息
        /// </summary>
        public Supplier Supplier { get; set; }

        /// <summary>
        /// 产品的基本信息
        /// </summary>
        public Summary Summary { get; set; }

        /// <summary>
        /// 参考行程,跟团游必须有
        /// </summary>
        public Days Days { get; set; }
        /// <summary>
        /// 自由行和自由打包的组成,自由行和自由打包时必填
        /// </summary>
        public Package[] Packages { get; set; }

        public Additionals Additionals { get; set; }
    }
    public class Supplier
    {
        /// <summary>
        /// 供应商店铺名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 供应商联系人名称
        /// </summary>

        public string Contactuser { get; set; }
        /// <summary>
        /// 联系人电话
        /// </summary>

        public string Contactphone { get; set; }
        /// <summary>
        /// 供应商联系邮箱
        /// </summary>

        public string Contactemail { get; set; }
    }
    public class Summary
    {
        /// <summary>
        /// 产品名称,必填
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 产品团号
        /// </summary>

        public string Teamno { get; set; }
        /// <summary>
        /// 对应供应商系统，产品ID,必填
        /// </summary>

        public string Resourceid { get; set; }
        /// <summary>
        /// 产品类别，free-自由行/group-跟团游/free_package-自由打包,必填
        /// </summary>

        public string Pfunction { get; set; }
        /// <summary>
        /// 自由行产品团期录入方式 0-日期录入方式,1-类型录入方式,默认为0,当为1时组成元素不能包含交通
        /// </summary>

        public string Teamtype { get; set; }
        /// <summary>
        /// 自由行产品组成元素（两项以上以"/"隔开），交通/酒店/门票/签证/接送机/其它(元素名称),自由行必填
        /// </summary>

        public string Pcomposition { get; set; }
        /// <summary>
        /// 是否需要出行人信息,自由行产品并且包含pcomposition包含交通项,默认为1-需要(0-不需要)
        /// </summary>

        public string Passengerinfo { get; set; }
        /// <summary>
        /// 服务承诺,铁定成团/无自费/无购物/如实描述(多选)
        /// </summary>

        public string Promise { get; set; }
        /// <summary>
        /// 行程天数，正整型,必填
        /// </summary>

        public string Pay { get; set; }
        /// <summary>
        /// 行程晚数，正整数,必填
        /// </summary>

        public string Night { get; set; }
        /// <summary>
        /// 提前报名天数，正整型,必填
        /// </summary>

        public string Advanceday { get; set; }
        /// <summary>
        /// 提前报名类型，自然日/工作日,必填
        /// </summary>

        public string Advancedaytype { get; set; }
        /// <summary>
        /// 始发地,必填
        /// </summary>

        public string Departure { get; set; }
        /// <summary>
        /// 目的地,必填
        /// </summary>

        public string Arrive { get; set; }
        /// <summary>
        /// 目的地类型，国内游/出境游/港澳台,必填
        /// </summary>

        public string Arrivetype { get; set; }
        /// <summary>
        /// 短途/长途,必填
        /// </summary>

        public string Distancetype { get; set; }
        /// <summary>
        /// 去程交通：火车/飞机/巴士/邮轮,必填
        /// </summary>

        public string Freetriptotraffic { get; set; }
        /// <summary>
        /// 回程交通：火车/飞机/巴士/邮轮,必填
        /// </summary>

        public string Freetripbacktraffic { get; set; }
        /// <summary>
        /// 图片链接，多图片用逗号分隔,必填,至少有一张图片
        /// </summary>

        public string Image { get; set; }
        /// <summary>
        /// 推荐理由,必填
        /// </summary>

        public string Recommendation { get; set; }
        /// <summary>
        /// 线路特色,必填,支持富文本
        /// </summary>

        public string Feature { get; set; }
        /// <summary>
        /// 签证,支持富文本
        /// </summary>

        public string Visa { get; set; }
        /// <summary>
        /// 费用包含,支持富文本
        /// </summary>

        public string Feeinclude { get; set; }
        /// <summary>
        /// 费用不包含,支持富文本
        /// </summary>

        public string Feeexclude { get; set; }
        /// <summary>
        /// 注意事项,支持富文本
        /// </summary>

        public string Attention { get; set; }
        /// <summary>
        /// 有情提示,支持富文本
        /// </summary>

        public string Tip { get; set; }
        /// <summary>
        /// 付款方式,0-即时付款/1-二次确认
        /// </summary>

        public string Payway { get; set; }
        /// <summary>
        /// 是否套餐，true/false
        /// </summary>

        public string Istaocan { get; set; }
        /// <summary>
        /// 套餐成人数,int,必填
        /// </summary>

        public string Taocanadultcount { get; set; }
        /// <summary>
        /// 套餐儿童数,int,默认为0
        /// </summary>

        public string Taocanchildcount { get; set; }
        /// <summary>
        /// 房间数,int,默认为0
        /// </summary>

        public string Taocanroomcount { get; set; }
        /// <summary>
        /// 跟团游参团方式,出发地参团/目的地参团
        /// </summary>

        public string Groupmethod { get; set; }
        /// <summary>
        /// 跟团游集合地信息
        /// </summary>

        public string Assembly { get; set; }
        /// <summary>
        /// 退改说明id
        /// </summary>

        public string RefundId { get; set; }
        /// <summary>
        /// 产品状态,on sale/offline
        /// </summary>

        public string Status { get; set; }
        /// <summary>
        /// 需要更新的字段名：title,teamno,resourceid........没有该字段默认全部更新,all表示全部更新
        /// </summary>

        public string Needupdateset { get; set; }
    }

    public class Days
    {
        /// <summary>
        /// true/false
        /// </summary>
        public string Isupdate { get; set; }
        /// <summary>
        ///  一个行程，可以多个
        /// </summary>
        public Day[] Day { get; set; }
    }
    public class Day
    {
        /// <summary>
        /// 图片，多图片用逗号分隔
        /// </summary>
        public string Sightimage { get; set; }
        /// <summary>
        /// 参考行程描述,必填,支持富文本
        /// </summary>
        public string Daydescription { get; set; }
        /// <summary>
        /// 汽车/飞机/火车/轮船/其他(其它内容)
        /// </summary>
        public string Daytraffic { get; set; }

        public DayDayhotelstar Dayhotelstar { get; set; }

        public Meal[] Meals { get; set; }

        /// <summary>
        /// 参考行程天数序号，正整数,必填
        /// </summary>
        public string Daynum { get; set; }
        /// <summary>
        /// 当天标题,必填
        /// </summary>
        public string Daytitle { get; set; }
    }
    public class DayDayhotelstar
    {
        /// <summary>
        /// 其他/客栈/农家院/二星或同等酒店/三星或同等酒店/四星或同等酒店/五星或同等酒店/六星或同等酒店/七星或同等酒店/八星或同等酒店
        /// </summary>
        public string Starname { get; set; }
        /// <summary>
        /// 住宿描述
        /// </summary>
        public string Stardesc { get; set; }
    }
    public class Meal
    {
        public string Mealtype { get; set; }

        public string Mealdesc { get; set; }
    }

    public class Package
    {
        /// <summary>
        /// 包唯一性id，自由打包必填
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 1,表示选中/2,表示未选中/3,表示删除,默认为选中
        /// </summary>
        public string Status { get; set; }

        public Traffics Traffics { get; set; }

        public Hotels Hotels { get; set; }

        public Additionals Additionals { get; set; }

        public Tickets Tickets { get; set; }

        public Freetripvisainfo Freetripvisainfo { get; set; }

        public Freetrippickupairinfo Freetrippickupairinfo { get; set; }

        public Freetripotherinfo Freetripotherinfo { get; set; }
    }
    public class Traffics
    {  
        /// <summary>
        /// true/false
        /// </summary>
        public string Isupdate { get; set; }
        public Traffic[] Traffic { get; set; }
    }
    public class Traffic
    {

    }
}
