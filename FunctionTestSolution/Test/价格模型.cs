
public class Route
{
    /// <summary>
    /// 产品的基本信息 
    /// </summary>
    public Summary Summary { get; set; }
    /// <summary>
    /// 自由行和自由打包的组成,自由行和自由打包时必填
    /// </summary>
    public Packages Packages { get; set; }
    public Additionals Additionals { get; set; }
}



/// <summary>
/// 产品的基本信息 
/// </summary>
public class Summary
{
    /// <summary>
    /// 对应供应商系统，产品ID,必填
    /// </summary>
    public string Resourceid { get; set; }
    /// <summary>
    /// 产品类别，free-自由行/group-跟团游/free_package-自由打包,必填
    /// </summary>
    public string Pfunction { get; set; }
    /// <summary>
    /// 是否套餐，true/false
    /// </summary>
    public string Istaocan { get; set; }
}


/// <summary>
/// 自由行和自由打包的组成,自由行和自由打包时必填
/// </summary>
public class Packages
{
    public Package[] package { get; set; }
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
    public Team[] Teams { get; set; }
    public PackagesPackageProducttype[] producttypes { get; set; }
}



public class Team
{
    /// <summary>
    /// 团期，如：2012-07-12,必填
    /// </summary>
    public string Takeoffdate { get; set; }
    /// <summary>
    /// 价格名称，必填
    /// </summary>
    public string Pricename { get; set; }
    /// <summary>
    /// 市场价，正整数,必填
    /// </summary>
    public string Marketprice { get; set; }
    /// <summary>
    /// 去哪儿价
    /// </summary>
    public Qunarprice Qunarprice { get; set; }
    public Adultprice Adultprice { get; set; }
    public string Containchildprice { get; set; }
    public Childprice Childprice { get; set; }
    public string Childpricedesc { get; set; }
    public string Roomnum { get; set; }
    public string Roomsendprice { get; set; }
    public string Availablecount { get; set; }
    public string Minbuycount { get; set; }
    public string Maxbuycount { get; set; }
    public string Pricedesc { get; set; }
    public string Status { get; set; }
    public string Needupdateset { get; set; }
    public string Takeoffdate1 { get; set; }
    public string Marketprice1 { get; set; }
    public string Adultprice1 { get; set; }
    public string Containchildprice1 { get; set; }
    public string Childprice1 { get; set; }
    public string Childpricedesc1 { get; set; }
    public string Roomnum1 { get; set; }
    public string Roomsendprice1 { get; set; }
    public string Availablecount1 { get; set; }
    public string Minbuycount1 { get; set; }
    public string Maxbuycount1 { get; set; }
    public string Pricedesc1 { get; set; }
    public string Status1 { get; set; }
}



public class Qunarprice
{
    /// <summary>
    /// 价格计算规则,0-价格方式,1-比例方式
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// 底价,正整数
    /// </summary>
    public string Floorprice { get; set; }
    /// <summary>
    /// 分销价比例,正整数
    /// </summary>
    public string Distribupercent { get; set; }
    /// <summary>
    /// 建议售价比例,正整数
    /// </summary>
    public string Suggest { get; set; }
    /// <summary>
    /// 分销价,正整数
    /// </summary>
    public string Distributprice { get; set; }
    /// <summary>
    /// 建议售价,正整数
    /// </summary>
    public string Suggestprice { get; set; }
    
}


/// <summary>
/// 成人价
/// </summary>
public class Adultprice
{
    public string Type { get; set; }
    public string Floorprice { get; set; }
    public string Distributpercent { get; set; }
    public string Suggestpercent { get; set; }
    public string Distributprice { get; set; }
    public string Suggestprice { get; set; }
}
public class Childprice
{
    public string floorprice { get; set; }
    public string distributpercent { get; set; }
    public string suggestpercent { get; set; }
    public string distributprice { get; set; }
    public string suggestprice { get; set; }
    public string type { get; set; }
}



public class PackagesPackageProducttype
{
    public string title { get; set; }
    public string pricetype { get; set; }
    public string accuratedayofweek { get; set; }
    public string begindate { get; set; }
    public string enddate { get; set; }
    public string marketprice { get; set; }
    public PackagesPackageProducttypeTaocanprice taocanprice { get; set; }
    public PackagesPackageProducttypeAdultprice adultprice { get; set; }
    public string containchildprice { get; set; }
    public PackagesPackageProducttypeChildprice childprice { get; set; }
    public string roomnum { get; set; }
    public string roomsendprice { get; set; }
    public string availablecount { get; set; }
    public string minbuycount { get; set; }
    public string maxbuycount { get; set; }
    public string feedescription { get; set; }
    public string usedescription { get; set; }
    public string status { get; set; }
    public string needupdateset { get; set; }
    public string id { get; set; }
    public string feedescription1 { get; set; }
    public string usedescription1 { get; set; }
    public string status1 { get; set; }
}



public class PackagesPackageProducttypeTaocanprice
{
    public string floorprice { get; set; }
    public string distributpercent { get; set; }
    public string suggestpercent { get; set; }
    public string distributprice { get; set; }
    public string suggestprice { get; set; }
    public string type { get; set; }
}



public class PackagesPackageProducttypeAdultprice
{
    public string floorprice { get; set; }
    public string distributpercent { get; set; }
    public string suggestpercent { get; set; }
    public string distributprice { get; set; }
    public string suggestprice { get; set; }
    public string type { get; set; }
}



public class PackagesPackageProducttypeChildprice
{
    public string floorprice { get; set; }
    public string distributpercent { get; set; }
    public string suggestpercent { get; set; }
    public string distributprice { get; set; }
    public string suggestprice { get; set; }
    public string type { get; set; }
}



public class Additionals
{
    public AdditionalsAdditional additional { get; set; }
    public string isupdate { get; set; }
}



public class AdditionalsAdditional
{
    public AdditionalsAdditionalPrice price { get; set; }
    public string id { get; set; }
}



public class AdditionalsAdditionalPrice
{
    public string marketprice { get; set; }
    public string qunarprice { get; set; }
    public string availablecount { get; set; }
}

