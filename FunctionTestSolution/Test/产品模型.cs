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
    public Package[] Packages { get; set; }
    public Additionals Additionals { get; set; }
}
public class Supplier
{
    public string Name { get; set; }
    public string Contactuser { get; set; }
    public string Contactphone { get; set; }
    public string Contactemail { get; set; }
}

public class Summary
{
    public string Title { get; set; }
    public string Teamno { get; set; }
    public string Resourceid { get; set; }
    public string Pfunction { get; set; }
    public string Teamtype { get; set; }
    public string Pcomposition { get; set; }
    public string Passengerinfo { get; set; }
    public string Promise { get; set; }
    public string Day { get; set; }
    public string Night { get; set; }
    public string Advanceday { get; set; }
    public string Advancedaytype { get; set; }
    public string Departure { get; set; }
    public string Arrive { get; set; }
    public string Arrivetype { get; set; }
    public string Distancetype { get; set; }
    public string Freetriptotraffic { get; set; }
    public string Freetripbacktraffic { get; set; }
    public string Image { get; set; }
    public string Recommendation { get; set; }
    public string Feature { get; set; }
    public string Visa { get; set; }
    public string Feeinclude { get; set; }
    public string Feeexclude { get; set; }
    public string Attention { get; set; }
    public string Tip { get; set; }
    public string Payway { get; set; }
    public string Istaocan { get; set; }
    public string Taocanadultcount { get; set; }
    public string Taocanchildcount { get; set; }
    public string Taocanroomcount { get; set; }
    public string Groupmethod { get; set; }
    public string Assembly { get; set; }
    public string RefundId { get; set; }
    public string Status { get; set; }
    public string Needupdateset { get; set; }
}
public class Days
{
    public Day[] Day { get; set; }
    /// <summary>
    /// true/false
    /// </summary>
    public string Isupdate { get; set; }
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
    public Dayhotelstar Dayhotelstar { get; set; }
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
public class Dayhotelstar
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
    /// <summary>
    /// 早、中、晚
    /// </summary>
    public string Mealtype { get; set; }
    /// <summary>
    /// 描述
    /// </summary>
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
    /// <summary>
    /// 
    /// </summary>
    public Traffics Traffics { get; set; }
    /// <summary>
    /// 自由行或自由打包酒店元素
    /// </summary>
    public Hotels Hotels { get; set; }
    /// <summary>
    /// 自由打包关联的附加产品
    /// </summary>
    public Additionals additionals { get; set; }
    /// <summary>
    /// 自由行组成门票元素
    /// </summary>
    public Tickets tickets { get; set; }
    public Freetripvisainfo freetripvisainfo { get; set; }
    public Freetrippickupairinfo freetrippickupairinfo { get; set; }
    public Freetripotherinfo freetripotherinfo { get; set; }
}

public class Traffics
{
    public string Isupdate { get; set; }
    public Traffic[] Traffic { get; set; }
}

public class Traffic
{
    /// <summary>
    /// 自由行或自由打包去程交通
    /// </summary>
    public Totraffic Totraffic { get; set; }
    public Backtraffic Backtraffic { get; set; }
}

/// <summary>
/// 自由行或自由打包去程交通
/// </summary>
public class Totraffic
{
    public Flight Flight { get; set; }
    public Train Train { get; set; }
    public Bus Bus { get; set; }
}
public class Backtraffic
{
    public Flight flight { get; set; }

    public Train train { get; set; }

    public Bus bus { get; set; }
}
/// <summary>
/// 请保证seq唯一性，因为这个交通的顺序号，不可以重复
/// </summary>
public class Flight
{
    /// <summary>
    /// 序号,必填
    /// </summary>
    public string Seq { get; set; }
    /// <summary>
    /// 航班号,必填
    /// </summary>
    public string Flightno { get; set; }
    /// <summary>
    /// 机型
    /// </summary>
    public string Plantype { get; set; }
    /// <summary>
    /// 起飞机场
    /// </summary>
    public string Depairport { get; set; }
    /// <summary>
    /// 目的地机场
    /// </summary>
    public string Arrairport { get; set; }
    /// <summary>
    /// 起飞城市
    /// </summary>
    public string Depcity { get; set; }
    /// <summary>
    /// 到达城市
    /// </summary>
    public string Arrcity { get; set; }
    /// <summary>
    /// 起飞时间,格式：hh:ss
    /// </summary>
    public string Deptime { get; set; }
    /// <summary>
    /// 到达时间,格式：hh:ss
    /// </summary>
    public string Arrtime { get; set; }
    /// <summary>
    /// 是否跨天，0表示不跨天，1表示跨一天
    /// </summary>
    public string Arrflag { get; set; }
    /// <summary>
    /// 是否经停，0-无经停/1-有经停
    /// </summary>
    public string Stopflag { get; set; }
    /// <summary>
    /// 经停说明
    /// </summary>
    public string Stopcomment { get; set; }
    /// <summary>
    /// 是否中转，0-非中转航班，1-中转航班
    /// </summary>
    public string Transefer { get; set; }
}
/// <summary>
/// 请保证seq唯一性，因为这个交通的顺序号，不可以重复
/// </summary>
public class Train
{
    /// <summary>
    /// 序号，必填
    /// </summary>
    public string Seq { get; set; }
    /// <summary>
    /// 车次
    /// </summary>
    public string Trainno { get; set; }
    /// <summary>
    /// 车型
    /// </summary>
    public string Trainmodel { get; set; }
    /// <summary>
    /// 上车站点
    /// </summary>
    public string Depstation { get; set; }
    /// <summary>
    /// 下车站点
    /// </summary>
    public string Arrstation { get; set; }
    /// <summary>
    /// 发车时间,格式：hh:ss
    /// </summary>
    public string Deptime { get; set; }
    /// <summary>
    /// 到达时间,格式：hh:ss
    /// </summary>
    public string Arrtime { get; set; }
    /// <summary>
    /// 总时长,格式：hh:ss
    /// </summary>
    public string Traintime { get; set; }
    /// <summary>
    /// 火车席位
    /// </summary>
    public string Trainseat { get; set; }
    /// <summary>
    /// 是否中转，0-非中转火车，1-中转火车
    /// </summary>
    public string Transefer { get; set; }
}
/// <summary>
/// 请保证seq唯一性，因为这个交通的顺序号，不可以重复
/// </summary>
public class Bus
{
    /// <summary>
    /// 序号，必填
    /// </summary>
    public string Seq { get; set; }
    /// <summary>
    /// 车型
    /// </summary>
    public string Busmodel { get; set; }
    /// <summary>
    /// 座位数
    /// </summary>
    public string Seatcount { get; set; }
    /// <summary>
    /// 集合时间
    /// </summary>
    public string Gathertime { get; set; }
    /// <summary>
    /// 集合地点
    /// </summary>
    public string Gatherspot { get; set; }
    /// <summary>
    /// 出发时间,格式：hh:ss
    /// </summary>
    public string Deptime { get; set; }
    /// <summary>
    /// 到达时间,格式：hh:ss
    /// </summary>
    public string Arrtime { get; set; }
    /// <summary>
    /// 备注
    /// </summary>
    public string Remarks { get; set; }
    /// <summary>
    /// 是否中转，0-非中转巴士，1-中转巴士
    /// </summary>
    public string Transefer { get; set; }
}

public class Hotels
{
    /// <summary>
    /// true/false}
    /// </summary>
    public string Isupdate { get; set; }
    public Hotelprogram[] Hotelprogram { get; set; }

}

public class Hotelprogram
{
    public Hotel Hotel { get; set; }
}

public class Hotel
{
    /// <summary>
    /// 酒店关联id
    /// </summary>
    public string Relateid { get; set; }
    /// <summary>
    /// 酒店序号，必填
    /// </summary>
    public string Seq { get; set; }
    /// <summary>
    /// 开始入住晚数，必填
    /// </summary>
    public string Startnight { get; set; }
    /// <summary>
    /// 结束入住晚数，必填
    /// </summary>
    public string Endnight { get; set; }
    /// <summary>
    /// 酒店所在城市，必填
    /// </summary>
    public string Hotelcity { get; set; }
    /// <summary>
    /// 酒店名称,必填
    /// </summary>
    public string Hotelname { get; set; }
    /// <summary>
    /// 酒店地标
    /// </summary>
    public string Hotelmark { get; set; }
    /// <summary>
    /// 酒店英文名称
    /// </summary>
    public string Hotelenglistname { get; set; }
    /// <summary>
    /// 入住天数
    /// </summary>
    public string Bookday { get; set; }
    public Hotelstar Hotelstar { get; set; }
    /// <summary>
    /// 酒店档次,二星及其他/经济型/舒适型/高档型/豪华型/其他，其他说明
    /// </summary>
    public string Hotelgrade { get; set; }
    /// <summary>
    /// 床型：大床/双床/大床或双床/其它（写其他名称）
    /// </summary>
    public string Bedtype { get; set; }
    /// <summary>
    /// 床位数：1/2/3/4/5/6,默认2
    /// </summary>
    public string Roomtype { get; set; }
    /// <summary>
    /// 房型名称
    /// </summary>
    public string Roomname { get; set; }
    /// <summary>
    /// 房型英文名称
    /// </summary>
    public string Roomenglish { get; set; }
    /// <summary>
    /// 酒店地址
    /// </summary>
    public string Address { get; set; }
    /// <summary>
    /// 酒店URL
    /// </summary>
    public string Website { get; set; }
    /// <summary>
    /// 图片，多图片用逗号分隔
    /// </summary>
    public string Image { get; set; }
    /// <summary>
    /// 酒店介绍,必填,支持富文本
    /// </summary>
    public string Introduction { get; set; }

    public Meal Meal { get; set; }
    /// <summary>
    /// 自费/免费/其他，其他说明
    /// </summary>
    public string Network { get; set; }
}

public class Hotelstar
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
    /// <summary>
    /// 0-不含/1-含
    /// </summary>
    public string Breakfast { get; set; }
    /// <summary>
    /// 0-不含/1-含
    /// </summary>
    public string Lunch { get; set; }
    /// <summary>
    /// 0-不含/1-含
    /// </summary>
    public string Dinner { get; set; }
}

public class Additionals
{
    /// <summary>
    /// true/false
    /// </summary>
    public string Isupdate { get; set; }
    public Additional[] Additional { get; set; }

}

/// <summary>
/// 自由打包关联的附加产品
/// </summary>
public class Additional
{
    /// <summary>
    /// 0-其他/1-接送机/2-签证/3-保险，必填
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// 产品标题，必填
    /// </summary>
    public string Additiontitle { get; set; }
    /// <summary>
    /// 产品介绍
    /// </summary>
    public string Additiondesc { get; set; }
    /// <summary>
    /// 使用说明
    /// </summary>
    public string Additionusedesc { get; set; }
}

public class Tickets
{
    /// <summary>
    /// true/false
    /// </summary>
    public string Isupdate { get; set; }
    public Ticket[] Ticket { get; set; }

}

/// <summary>
/// 自由行组成门票元素
/// </summary>
public class Ticket
{
    /// <summary>
    /// 景区关联id
    /// </summary>
    public string Relateid { get; set; }
    /// <summary>
    /// 门票序号
    /// </summary>
    public string Seq { get; set; }
    /// <summary>
    /// 门票名称,必填
    /// </summary>
    public string Tickettitle { get; set; }
    /// <summary>
    /// 景区名称，多景区用逗号分隔
    /// </summary>
    public string Sightname { get; set; }
    /// <summary>
    /// 景区级别，未评定/1A/2A/3A/4A/5A
    /// </summary>
    public string Star { get; set; }
    /// <summary>
    /// 景区地址
    /// </summary>
    public string Address { get; set; }
    /// <summary>
    /// 景区开放时间
    /// </summary>
    public string Opentime { get; set; }
    /// <summary>
    /// 图片，多图片用逗号分隔
    /// </summary>
    public string Image { get; set; }
    /// <summary>
    /// 景区/门票介绍,必填,支持富文本
    /// </summary>
    public string Introduction { get; set; }

}



public class Freetripvisainfo
{
    /// <summary>
    /// true/false
    /// </summary>
    public string Isupdate { get; set; }
    /// <summary>
    /// 自由行组成签证元素，如自由行类别中有，必填,支持富文本
    /// </summary>
    public string Value { get; set; }
}



public class Freetrippickupairinfo
{
    /// <summary>
    /// true/false
    /// </summary>
    public string isupdate { get; set; }
    /// <summary>
    /// 自由行组成接送机元素，如自由行类别中有，必填,支持富文本
    /// </summary>
    public string Value { get; set; }
}



public class Freetripotherinfo
{
    /// <summary>
    /// true/false
    /// </summary>
    public string isupdate { get; set; }
    /// <summary>
    /// 自由行组成自定义元素，如自由行类别中有，必填,支持富文本
    /// </summary>
    public string Value { get; set; }
}



public class Additionals
{
    /// <summary>
    /// true/false
    /// </summary>
    public string Isupdate { get; set; }
    public Additional[] Additional { get; set; }

}



public class Additional
{
    /// <summary>
    /// 供应商方的id
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// 1-接送机/2-签证/3-保险/4-其他，必填
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// 产品标题，必填
    /// </summary>
    public string Additiontitle { get; set; }
    /// <summary>
    /// 产品介绍
    /// </summary>
    public string Additiondesc { get; set; }
    /// <summary>
    /// 使用说明
    /// </summary>
    public string Additionusedesc { get; set; }
    /// <summary>
    /// 0-不必须，1-必须
    /// </summary>
    public string Status { get; set; }

}

